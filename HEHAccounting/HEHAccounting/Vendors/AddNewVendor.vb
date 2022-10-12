Public Class AddNewVendor
    Public BoolForEdit As Boolean = False
    Dim OldVendorName As String
    Dim OldVendorTitle As String

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
        Me.LblVendorName.Text = LoStrId.LblName
        Me.LblVendorID.Text = LoStrId.LblCode
        Me.LblTown.Text = LoStrId.LblTown
        Me.LblLatinName.Text = LoStrId.LblLatinName
        Me.LblAddress.Text = LoStrId.LblAddress
        Me.LblPhone.Text = LoStrId.LblPhone
        Me.LblVendorCompany.Text = LoStrId.LblCompany
        Me.BtnClose.Text = LoStrId.LblClose
        Me.BtnSaveAndNew.Text = LoStrId.LblSaveNew
        Me.LblTitle.Text = LoStrId.LblTitle
        Me.LblCellPhone.Text = LoStrId.LblCellPhone
        Me.Text = LoStrId.LblAddVendor
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Function NameRepetition() As Boolean
        Dim Param(2) As String
        Param(0) = "@VTableName , Vendors"
        Param(1) = "@CName , " & Me.TxtVendorName.Text
        If BtnSaveAndNew.Tag = "Save" Then
            Param(2) = "@IID , " & Nothing
        Else
            Param(2) = "@IID , " & Me.TxtVendorCode.Text
        End If
        If GetScalarProcedure("GetNameRepetition", Param) = "0" Then
            Return False
        Else
            Return True
        End If

    End Function
    Function FormCheck() As Boolean
        If Me.TxtVendorName.Text.Trim.Length = 0 Then
            Return False
        End If
        If BoolForcingEnterVendorLatin Then
            If Me.TxtVendorLatin.Text.Trim.Length = 0 Then
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If FormCheck() Then
            If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                If Not BoolAllowVendorRepetition And NameRepetition() Then
                    MessageShowInfo(Con.Msg_Vendor_Already_Added)
                    Exit Sub
                End If

                Dim Param(9) As String
                Param(0) = "@CVendorName , " & Evalquote(Me.TxtVendorName.Text)
                Param(1) = "@CVendorLatin , " & Evalquote(Me.TxtVendorLatin.Text)
                Param(2) = "@CVendorCompany , " & Evalquote(Me.TxtCompany.Text)
                Param(3) = "@CVendorTown , " & Evalquote(Me.TxtTown.Text)
                Param(4) = "@CVendorPhone , " & Me.MTxtPhone.Value
                Param(5) = "@CCellPhone , " & Me.MTxtCellPhone.Value
                Param(6) = "@CVendorAddress , " & Me.TxtAddress.Text
                Param(7) = "@CVendorTitle , " & Me.TxtTitle.Text
                Param(8) = "@IVendorID , " & Me.TxtVendorCode.Text
                Param(9) = "@IUserID , " & UserID
                If BtnSaveAndNew.Tag = "Save" Then
                    ExecuteProcedureWithParameters("InsertNewVendor", Param)
                    VendorNameAuto.Add(Me.TxtVendorName.Text.ToLower & "/" & Me.TxtTitle.Text.ToLower & "/" & Me.TxtVendorCode.Text)
                    FormClear()
                    ToDoRefrech = True
                ElseIf BtnSaveAndNew.Tag = "Edit" Then
                    ExecuteProcedureWithParameters("UpdateVendor", Param)
                    VendorNameAuto.Remove(OldVendorName & "/" & OldVendorTitle & "/" & Me.TxtVendorCode.Text)
                    '  VendorNameAuto.Remove(OldVendorName)
                    VendorNameAuto.Add(Me.TxtVendorName.Text.ToLower & "/" & Me.TxtTitle.Text.ToLower & "/" & Me.TxtVendorCode.Text)
                    MessageShowInfo(Con.Msg_Vendor_Has_Been_Updated)
                    ToDoRefrech = True
                End If
            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub

    Public Sub ShowForEdit(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            Me.TxtVendorName.Text = dt.Rows(0).Item("VendorName").ToString
            OldVendorName = Me.TxtVendorName.Text.ToLower
            Me.TxtVendorLatin.Text = dt.Rows(0).Item("VendorLatinName").ToString
            Me.TxtTitle.Text = dt.Rows(0).Item("VendorTitle").ToString
            OldVendorTitle = Me.TxtTitle.Text.ToLower
            Me.TxtCompany.Text = dt.Rows(0).Item("VendorCompany").ToString
            Me.TxtTown.Text = dt.Rows(0).Item("VendorTown").ToString
            Me.TxtAddress.Text = dt.Rows(0).Item("VendorAddress").ToString
            Me.MTxtPhone.Value = dt.Rows(0).Item("VendorPhone").ToString
            Me.MTxtCellPhone.Value = dt.Rows(0).Item("CellPhone").ToString
            Me.TxtVendorCode.Text = dt.Rows(0).Item("VendorID").ToString
            Me.BtnSaveAndNew.Text = IIf(BoolLTRLanguage, LoStrId.LblEdit, "تعديل")
            Me.BtnSaveAndNew.Tag = "Edit"
            Me.Text = IIf(BoolLTRLanguage, LoStrId.LblEditVendor, "تعديل المورد")
        End If
    End Sub
    Private Sub FormClear()
        Me.TxtVendorCode.Clear()
        Me.TxtVendorName.Clear()
        Me.TxtVendorLatin.Clear()
        Me.TxtTown.Clear()
        Me.MTxtPhone.Value = String.Empty
        Me.TxtCompany.Clear()
        Me.TxtAddress.Clear()
        Me.TxtTitle.Text = String.Empty
        Me.MTxtCellPhone.Value = String.Empty
        Me.AddNewPages.SelectedPage = Me.PageGeneral
        GetID()
        Me.TxtVendorName.Focus()
    End Sub

    Private Sub GetID()
        Dim Param(0) As String
        Param(0) = "@VTableName , Vendors"
        Me.TxtVendorCode.Text = GetScalarProcedure("GetID", Param)
    End Sub

    Private Sub AddNewVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not BoolForEdit Then
            FormClear()
        End If
    End Sub
End Class
