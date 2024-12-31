Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Cryptography
Imports Telerik.Reporting
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI


Module DatabaseFunctions
    ReadOnly Db As New Database

    Function CheckConnection() As Boolean
        Return Db.checkConnection()
    End Function

    Public Sub UpdateLang(ByVal Lang As String)
        Dim param(1) As String
        param(0) = "@lang , " & Lang
        param(1) = "@LTR , " & IIf(Lang = "Ar", False, True)
        ExecuteProcedureWithParameters("UpdateLanguage", param)
        Home.GetAppSettings()
    End Sub

    Function GetInitialIDValue(ByVal VTableName As String)
        Dim Param(0) As String
        Param(0) = "@VTableName , " & VTableName
        Return GetScalarProcedure("GetID", Param)
    End Function

    Public Sub FillGridViewProcedure(ByVal Grid As RadGridView, ByVal ProcedureName As String)
        Grid.MasterTemplate.BeginUpdate()
        Grid.MasterTemplate.DataSource = Db.SelectProcedureDataTable(ProcedureName)
        Grid.MasterTemplate.EndUpdate()
    End Sub

    Public Sub FillTreeProcedure(ByVal MTree As RadTreeView, ByVal ProcedureName As String)
        MTree.BeginUpdate()
        MTree.DataSource = Db.SelectProcedureDataTable(ProcedureName)
        MTree.ValueMember = "GroupID"
        MTree.DisplayMember = "GroupName"
        MTree.EndUpdate()
    End Sub

    Public Sub FillGridViewQuery(ByVal Grid As RadGridView, ByVal Query As String)
        Grid.BeginUpdate()
        Grid.DataSource = Db.SelectQueryDatatable(Query)
        Grid.EndUpdate()
    End Sub

    Public Sub FillGridViewProcedureWithParameters(ByVal Grid As RadGridView, ByVal ProcedureName As String, ByVal Param() As String)
        Grid.MasterTemplate.BeginUpdate()
        Grid.MasterTemplate.DataSource = Db.SelectProcedureDataTableWithParam(ProcedureName, GetSqlParameter(Param))
        Grid.MasterTemplate.EndUpdate()
    End Sub

    Public Sub ExecuteProcedureWithParameters(ByVal ProcedureName As String, ByVal Param() As String)
        Db.ExecuteProcedureWithParam(ProcedureName, GetSqlParameter(Param))
    End Sub
    Public Sub ExecuteQuerySQL(ByVal Query As String)
        Db.ExecuteQuery(Query)
    End Sub
    Function ExecuteQueryDatatable(ByVal Query As String) As DataTable
        Return Db.SelectQueryDatatable(Query)
    End Function

    Function GetSqlParameter(ByVal Param() As String) As SqlParameter()
        Dim TypeChar As String
        Dim parametercount As Integer = Param.Count - 1
        Dim OneSqlParameter As SqlParameter
        Dim ReturnSqlParameter(parametercount) As SqlParameter
        Dim i As Integer = 0
        Dim ParameterName As String
        Dim ParameterValue As String
        For Each pa In Param
            Dim PR() As String
            PR = pa.Split(",")
            ParameterName = PR(0).Trim
            ParameterValue = PR(1).Trim
            TypeChar = ParameterName.Substring(1, 1)

            Select Case TypeChar.ToUpper()

                Case "I" 'Integer
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.Int)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = Integer.Parse(ParameterValue)
                    End If
                    Exit Select

                Case "F" 'Float
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.Float)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = Double.Parse(ParameterValue)
                    End If
                    Exit Select

                Case "B" 'Bit
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.Bit) With {
                        .Value = Convert.ToBoolean(ParameterValue)
                    }
                    Exit Select

                Case "D"
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.Decimal)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = Decimal.Parse(ParameterValue)
                    End If
                    Exit Select

                Case "T"
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.DateTime)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = Convert.ToDateTime(ParameterValue)
                    End If
                    Exit Select

                Case "C"
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.NVarChar)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = ParameterValue
                    End If
                    Exit Select

                Case "V"
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.NVarChar)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = ParameterValue
                    End If
                    Exit Select

                Case Else
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.Char)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = ParameterValue
                    End If
                    Exit Select

            End Select

            ReturnSqlParameter(i) = OneSqlParameter
            i += 1
        Next

        Return ReturnSqlParameter

    End Function

    Function GetValueQuery(ByVal Query As String) As String
        Return Db.GetScalarQuery(Query)
    End Function

    Function GetScalarProcedure(ByVal Procedure As String, ByVal Param() As String) As String
        Return Db.GetScalarProcedureWithParam(Procedure, GetSqlParameter(Param))
    End Function
    Function GetScalarProcedureWithoutParam(ByVal Procedure As String) As String
        Return Db.GetScalarProcedureWithoutParam(Procedure)
    End Function

    Function ExecuteProcedureDatatableWithParameters(ByVal Procedure As String, ByVal Param() As String) As DataTable
        Return Db.SelectProcedureDataTableWithParam(Procedure, GetSqlParameter(Param))
    End Function

    Function ExecuteProcedureDatatable(ByVal Procedure As String) As DataTable
        Return Db.SelectProcedureDataTable(Procedure)
    End Function

End Module
