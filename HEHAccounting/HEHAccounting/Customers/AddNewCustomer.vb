Public Class AddNewCustomer

    Public BoolForEdit As Boolean = False
    Dim OldCustomerName As String
    Dim OldCustomerTitle As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If BoolLTRLanguage Then
            ChangeToEng()
        End If
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.PageGeneral.Text = LoStrId.LblPageGeneral
        Me.LblCustomerName.Text = LoStrId.LblName
        Me.LblCustomerID.Text = LoStrId.LblCode
        Me.LblTown.Text = LoStrId.LblTown
        Me.BtnClose.Text = LoStrId.LblClose
        Me.BtnSaveAndNew.Text = LoStrId.LblSaveNew
        Me.LblAddress.Text = LoStrId.LblAddress
        Me.LblPhone.Text = LoStrId.LblPhone
        Me.LblLatinName.Text = LoStrId.LblLatinName
        Me.LblTitle.Text = LoStrId.LblTitle
        Me.Text = LoStrId.LblAddCustomer
    End Sub
    Private Function NameRepetition() As Boolean
        Dim Param(2) As String
        Param(0) = "@VTableName , Customers"
        Param(1) = "@CName , " & Me.TxtCustomerName.Text
        If BtnSaveAndNew.Tag = "Save" Then
            Param(2) = "@IID , " & Nothing
        Else
            Param(2) = "@IID , " & Me.TxtCustomerCode.Text
        End If
        If GetScalarProcedure("GetNameRepetition", Param) = "0" Then
            Return False
        Else
            Return True
        End If

    End Function

    Function FormCheck() As Boolean
        If Me.TxtCustomerName.Text.Trim.Length = 0 Then
            Return False
        End If
        If BoolForcingEnterCustomerLatin Then
            If Me.TxtCustomerLatin.Text.Trim.Length = 0 Then
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If FormCheck() Then
            If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                If Not BoolAllowCustomerRepetition And NameRepetition() Then
                    MessageShowInfo(Con.Msg_Customer_Already_Added)
                    Exit Sub
                End If

                Dim Param(8) As String
                Param(0) = "@CCustomerName , " & Evalquote(Me.TxtCustomerName.Text)
                Param(1) = "@CCustomerLatin , " & Evalquote(Me.TxtCustomerLatin.Text)
                Param(2) = "@CCustomerTitle , " & Evalquote(Me.TxtTitle.Text)
                Param(3) = "@CCustomerAddress , " & Evalquote(Me.TxtCustomerAddress.Text)
                Param(4) = "@CCustomerPhone , " & Me.MTxtCustomerPhone.Value
                Param(5) = "@CCellPhone , " & Me.MTxtCellPhone.Value
                Param(6) = "@CCustomerTown , " & Evalquote(Me.TxtCustomerTown.Text)
                Param(7) = "@ICustomerID , " & Me.TxtCustomerCode.Text
                Param(8) = "@IUserID , " & UserID
                If BtnSaveAndNew.Tag = "Save" Then
                    ExecuteProcedureWithParameters("InsertNewCustomer", Param)
                    CustomerNameAuto.Add(Me.TxtCustomerName.Text.ToLower & "/" & Me.TxtTitle.Text.ToLower & "/" & Me.TxtCustomerCode.Text)
                    FormClear()
                    ToDoRefrech = True
                ElseIf BtnSaveAndNew.Tag = "Edit" Then
                    ExecuteProcedureWithParameters("UpdateCustomer", Param)
                    CustomerNameAuto.Remove(OldCustomerName & "/" & OldCustomerTitle & "/" & Me.TxtCustomerCode.Text)
                    CustomerNameAuto.Add(Me.TxtCustomerName.Text.ToLower & "/" & Me.TxtTitle.Text.ToLower & "/" & Me.TxtCustomerCode.Text)
                    MessageShowInfo(Con.Msg_Customer_Has_Been_Updated)
                    ToDoRefrech = True
                End If

            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub

    Public Sub ShowForEdit(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            Me.TxtCustomerName.Text = dt.Rows(0).Item("CustomerName").ToString
            OldCustomerName = Me.TxtCustomerName.Text.ToLower
            Me.TxtCustomerLatin.Text = dt.Rows(0).Item("CustomerLatinName").ToString
            Me.TxtTitle.Text = dt.Rows(0).Item("CustomerTitle").ToString
            OldCustomerTitle = Me.TxtTitle.Text.ToLower
            Me.TxtCustomerCode.Text = dt.Rows(0).Item("CustomerID").ToString
            Me.TxtCustomerTown.Text = dt.Rows(0).Item("CustomerTown").ToString
            Me.TxtCustomerAddress.Text = dt.Rows(0).Item("CustomerAddress").ToString
            Me.MTxtCustomerPhone.Value = dt.Rows(0).Item("CustomerPhone").ToString
            Me.MTxtCellPhone.Value = dt.Rows(0).Item("CellPhone").ToString
            Me.BtnSaveAndNew.Text = IIf(BoolLTRLanguage, LoStrId.LblEdit, "تعديل")
            Me.BtnSaveAndNew.Tag = "Edit"
            Me.Text = IIf(BoolLTRLanguage, LoStrId.LblEditCustomer, "تعديل الزبون")
        End If
    End Sub


    Private Sub FormClear()
        Me.MTxtCustomerPhone.Value = String.Empty
        Me.TxtCustomerAddress.Clear()
        Me.TxtCustomerCode.Clear()
        Me.TxtCustomerLatin.Clear()
        Me.TxtCustomerName.Clear()
        Me.TxtCustomerTown.Clear()
        Me.TxtTitle.Clear()
        Me.MTxtCellPhone.Value = String.Empty
        Me.AddNewPages.SelectedPage = Me.PageGeneral
        GetID()
        Me.TxtCustomerName.Focus()
    End Sub

    Private Sub GetID()
        Dim Param(0) As String
        Param(0) = "@VTableName , Customers"
        Me.TxtCustomerCode.Text = GetScalarProcedure("GetID", Param)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub AddNewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not BoolForEdit Then
            FormClear()
        End If
    End Sub
End Class
