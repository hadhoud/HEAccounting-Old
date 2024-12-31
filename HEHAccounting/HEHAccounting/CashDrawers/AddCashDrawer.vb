Imports Telerik.WinControls.UI

Public Class AddCashDrawer

    Public BoolForEdit As Boolean = False
    Public Row As GridViewRowInfo
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        FillDropList()
        'ShowPermissions()
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.lblAddDrawer
        Me.LblDrawerName.Text = LoStrId.LblDrawerName
        Me.LblDrawerID.Text = LoStrId.LblCode
        Me.LblDrawerNote.Text = LoStrId.LblDrawerNote
        Me.LblCurrency.Text = LoStrId.LblCurrency
        Me.BtnClose.Text = LoStrId.LblClose
        Me.BtnSaveAndNew.Text = LoStrId.LblSaveNew
    End Sub

    Private Sub FillDropList()
        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrency.DataSource = Currencydata
        Initiatedropdownlist(Me.DropCurrency, False)
        Me.DropCurrency.SelectedValue = ProgramFormCurrency
    End Sub

    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If Me.TxtDrawerName.Text.Trim.Length <> 0 Then
            If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                If NameRepetition() Then
                    MessageShowInfo(Con.Msg_Drawer_Already_Added)
                    Exit Sub
                End If
                If BtnSaveAndNew.Tag = "Save" Then
                    Dim Param(3) As String
                    Param(0) = "@cDrawerName , " & Evalquote(Me.TxtDrawerName.Text)
                    Param(1) = "@iCurrencyID , " & DropCurrency.SelectedValue
                    Param(2) = "@cDrawerDesc , " & Evalquote(Me.TxtDesc.Text)
                    Param(3) = "@iUserID , " & UserID

                    ExecuteProcedureWithParameters("InsertNewCashDrawer", Param)
                    FormClear()
                ElseIf BtnSaveAndNew.Tag = "Edit" Then
                    Dim Update_Param(4) As String
                    Update_Param(0) = "@iDrawerID , " & Me.TxtDrawerCode.Text
                    Update_Param(1) = "@cDrawerName , " & Evalquote(Me.TxtDrawerName.Text)
                    Update_Param(2) = "@iCurrencyID , " & DropCurrency.SelectedValue
                    Update_Param(3) = "@cDrawerDesc , " & Evalquote(Me.TxtDesc.Text)
                    Update_Param(4) = "@iUserID , " & UserID

                    ExecuteProcedureWithParameters("UpdateCashDrawer", Update_Param)
                    MessageShowInfo(Con.Msg_Drawer_Has_Been_Updated)
                End If
            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Function NameRepetition() As Boolean
        If BtnSaveAndNew.Tag = "Edit" Then
            Dim Param(2) As String
            Param(0) = "@VTableName , Drawers"
            Param(1) = "@CName , " & Me.TxtDrawerName.Text
            Param(2) = "@IID , " & Me.TxtDrawerCode.Text
            If GetScalarProcedure("GetNameRepetition", Param) = "0" Then
                Return False
            Else
                Return True
            End If
        Else
            Dim Param(1) As String
            Param(0) = "@VTableName , Drawers"
            Param(1) = "@CName , " & Me.TxtDrawerName.Text
            If GetScalarProcedure("GetNameRepetition", Param) = "0" Then
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Private Sub AddDrawer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not BoolForEdit Then
            FormClear()
        Else
            Me.BtnSaveAndNew.Tag = "Edit"
            Me.BtnSaveAndNew.Text = Con.Edit
            ShowEdit()
        End If
    End Sub
    Public Sub ShowEdit()
        Me.TxtDrawerCode.Text = Row.Cells("DrawerID").Value.ToString
        Me.TxtDrawerName.Text = Row.Cells("DrawerName").Value.ToString
        Me.TxtDesc.Text = Row.Cells("DrawerDescription").Value.ToString
        Me.DropCurrency.SelectedValue = Row.Cells("CurrencyID").Value
        Me.TxtDrawerCode.Visible = True
        Me.LblDrawerID.Visible = True
    End Sub

    Private Sub FormClear()
        Me.TxtDrawerCode.Text = String.Empty
        Me.TxtDrawerName.Text = String.Empty
        Me.TxtDesc.Text = String.Empty
        Me.TxtDrawerName.Focus()
        Me.DropCurrency.SelectedValue = ProgramFormCurrency
    End Sub

End Class
