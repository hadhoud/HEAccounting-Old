Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports HEHAccounting.My.MySettings

Public Class Database
    Dim connectionstrng As String
    Private ReadOnly ConSql As New SqlConnection
    Public Function Connectionstr() As String
        'If My.MySettings.Default.ServerMode = "SQL" Then
        '    connectionstrng = New String() {"Data Source=", My.MySettings.Default.ServerName, " ; Database =",
        '                                           My.MySettings.Default.DBName, " ; ", " Integrated Security = False;",
        '                                           "UserID=", My.MySettings.Default.UserName, "Password=", My.MySettings.Default.UserPassword}
        'Else
        '    connectionstrng = New String() {"Data Source=", My.MySettings.Default.ServerName, " ; Initial Catalog =",
        '                                           My.MySettings.Default.DBName, " ; ", " Integrated Security = true;"}
        'End If
        '   connectionstrng = {"Data Source=HadiEsraa;", "Initial Catalog=HEAccounting;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"}
        ' connectionstrng = {"Data Source=HadiEsraa;Initial Catalog=HEAccounting;Integrated Security=True"}

        connectionstrng = My.Settings.ConnectionString.ToString
        Return String.Concat(connectionstrng)
    End Function

    Public Function Connect() As Boolean
        Try
            If ConSql.State = ConnectionState.Open Then
                Return True
            Else
                ConSql.ConnectionString = Connectionstr()
                ConSql.Open()
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Sub Close()
        ConSql.Close()
    End Sub
    Public Sub ExecuteQuery(Query As String)  
        'Try
        If Connect() Then
            Dim cmd As New SqlCommand With {
                    .CommandType = CommandType.Text,
                    .CommandText = Query,
                    .Connection = ConSql
                }
            cmd.ExecuteNonQuery()
            Close()
        End If
        'Catch ex As Exception
        '    Close()
        '    LogError(ex)
        'End Try
    End Sub

    Public Sub ExecuteProcedure(ProcedureName As String)
        If Connect() Then
            Dim cmd As New SqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = ProcedureName,
                .Connection = ConSql
            }
            cmd.ExecuteNonQuery()
            Close()
        End If

    End Sub

    Public Sub ExecuteProcedureWithParam(Procedure As String, ByVal Param As SqlParameter())
        If Connect() Then
            Dim cmd As New SqlCommand With {
                .CommandType = CommandType.StoredProcedure,
                .CommandText = Procedure,
                .Connection = ConSql
            }
            cmd.Parameters.AddRange(Param)
            cmd.ExecuteNonQuery()
            Close()
        End If
    End Sub

    Public Function SelectQueryDatatable(Query As String) As DataTable

        If Connect() Then
            SelectQueryDatatable = New DataTable
            Dim da As SqlDataAdapter = New SqlDataAdapter
            Dim cmd As New SqlCommand With {
                .CommandType = CommandType.Text,
                .CommandText = Query,
                .Connection = ConSql
           }
            da.SelectCommand = cmd
            SelectQueryDatatable.BeginLoadData()
            da.Fill(SelectQueryDatatable)
            SelectQueryDatatable.EndLoadData()
            Close()
            Return SelectQueryDatatable
        Else
            Return Nothing
        End If

    End Function

    Public Function SelectProcedureDataTableWithParam(Procedure As String, ByVal Param As SqlParameter()) As DataTable
        If Connect() Then
            Dim dt As New DataTable
            Dim da As SqlDataAdapter = New SqlDataAdapter
            Dim cmd As New SqlCommand With {
        .CommandType = CommandType.StoredProcedure,
        .CommandText = Procedure,
        .Connection = ConSql
    }
            cmd.Parameters.AddRange(Param)
            da.SelectCommand = cmd
            dt.BeginLoadData()
            da.Fill(dt)
            dt.EndLoadData()
            Close()
            Return dt
        Else
            Return Nothing
        End If
    End Function

    Public Function SelectProcedureDataTable(Procedure As String) As DataTable
        If Connect() Then
            Dim dt As New DataTable
            Dim da As SqlDataAdapter = New SqlDataAdapter
            Dim cmd As New SqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = Procedure,
            .Connection = ConSql
        }
            da.SelectCommand = cmd
            dt.BeginLoadData()
            da.Fill(dt)
            dt.EndLoadData()
            Close()
            Return dt
        Else
            Return Nothing
        End If

    End Function

    Public Function GetScalarProcedureWithParam(Procedure As String, Param As SqlParameter()) As String
        Try
            If Connect() Then
                Dim cmd As New SqlCommand With {
            .CommandType = CommandType.StoredProcedure,
            .CommandText = Procedure,
            .Connection = ConSql
        }
                cmd.Parameters.AddRange(Param)
                Return cmd.ExecuteScalar()

            Else
                Return "0"
            End If
        Catch ex As Exception
            Close()
            Return "0"
        End Try
    End Function

    Public Function GetScalarQuery(QueryText As String) As String
        Try
            If Connect() Then
                Dim cmd As New SqlCommand With {
            .CommandType = CommandType.Text,
            .CommandText = QueryText,
            .Connection = ConSql
        }
                GetScalarQuery = cmd.ExecuteScalar()
                Return GetScalarQuery
            Else
                Return "0"
            End If
        Catch ex As Exception
            Close()
            Return "0"
        End Try
    End Function
End Class
