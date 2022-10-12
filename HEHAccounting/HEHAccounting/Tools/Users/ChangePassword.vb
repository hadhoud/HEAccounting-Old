Public Class ChangePassword

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If Me.TxtOldPassword.Text.Trim.Length <> 0 And Me.TxtNewPass.Text.Trim.Length <> 0 And
            Me.TxtRetypeNewPass.Text.Trim.Length <> 0 Then
            If Me.TxtNewPass.Text <> Me.TxtRetypeNewPass.Text Then
                MessageShowInfo(Con.Msg_NewPass_NotEqual_Confirm)
                Exit Sub
            End If
            Dim Param(0) As String
            Dim UserPass As String
            Param(0) = "@VUsername , " & Username
            Dim UserDt As DataTable = ExecuteProcedureDatatableWithParameters("GetUserBYUsername", Param)
            UserPass = Decode(UserDt.Rows(0).Item("Password").ToString)
            If Me.TxtOldPassword.Text <> UserPass Then
                MessageShowInfo(Con.Msg_Check_Old_Password)
                Exit Sub
            End If
            Dim ParamPassword(1) As String
            ParamPassword(0) = "@IUserID , " & UserID
            ParamPassword(1) = "@CNPassword , " & Encode(Evalquote(Me.TxtNewPass.Text))
            ExecuteProcedureWithParameters("UpdatePassword", ParamPassword)
            MessageShowInfo(Con.Msg_Password_Has_Been_Updated)
            Me.TxtOldPassword.Clear()
            Me.TxtRetypeNewPass.Clear()
            Me.TxtNewPass.Clear()
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtUserName.Text = Username
    End Sub
End Class
