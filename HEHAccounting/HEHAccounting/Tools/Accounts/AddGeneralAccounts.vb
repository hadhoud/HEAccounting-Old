Imports Telerik.WinControls.UI

Public Class AddGeneralAccounts

    Public BoolForEdit As Boolean = False
    Public Row As GridViewRowInfo
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
        Me.Text = LoStrId.LblAddAccounts
        Me.LblCode.Text = LoStrId.LblCode
        Me.LblLatinName.Text = LoStrId.LblLatinName
        Me.LblName.Text = LoStrId.LblName
        Me.BtnClose.Text = LoStrId.LblClose
        Me.BtnSaveAndNew.Text = LoStrId.LblSaveNew
    End Sub

    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If Me.TxtAccName.Text.Trim.Length <> 0 Then
            If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                Dim Param(3) As String
                Param(0) = "@IAccountID , " & Me.TxtCode.Text
                Param(1) = "@CAccountName , " & Evalquote(Me.TxtAccName.Text)
                Param(2) = "@CAccountLatinName , " & IIf(Me.TxtLatinName.Text.Trim.Length <> 0, Evalquote(Me.TxtLatinName.Text), Evalquote(Me.TxtAccName.Text))
                Param(3) = "@IUserID , " & UserID
                If BtnSaveAndNew.Tag = "Save" Then
                    ExecuteProcedureWithParameters("InsertGeneralAccount", Param)
                    FormClear()
                ElseIf BtnSaveAndNew.Tag = "Edit" Then
                    Param(0) = "@CAccountNum , " & Me.TxtAccNum.Text
                    ExecuteProcedureWithParameters("UpdateGeneralAccount", Param)
                    MessageShowInfo(Con.Msg_Account_Has_Been_Updated)
                End If
            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub AddGeneralAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not BoolForEdit Then
            FormClear()
        Else
            Me.BtnSaveAndNew.Tag = "Edit"
            Me.BtnSaveAndNew.Text = Con.Edit
            ShowEdit()
        End If
    End Sub
    Public Sub ShowEdit()
        Me.TxtAccNum.Text = Row.Cells("AccountNumber").Value.ToString
        Me.TxtAccName.Text = Row.Cells("AccountName").Value.ToString
        Me.TxtLatinName.Text = Row.Cells("AccountLatinName").Value.ToString

    End Sub

    Private Sub FormClear()
        Me.TxtAccName.Text = String.Empty
        Me.TxtLatinName.Text = String.Empty
        Me.TxtAccName.Focus()
        GetID()
    End Sub
    Private Sub GetID()
        Dim Param(0) As String
        Param(0) = "@VTableName , Accounts"
        Me.TxtCode.Text = GetScalarProcedure("GetID", Param)
        Dim Code As String = Me.TxtCode.Text
        Dim AccNum As String
        Dim ZeroAcc As String = "00000"
        ZeroAcc = ZeroAcc.Substring(0, ZeroAcc.Length - Code.Length)
        AccNum = "ACG" & ZeroAcc & Code
        Me.TxtAccNum.Text = AccNum
    End Sub
End Class
