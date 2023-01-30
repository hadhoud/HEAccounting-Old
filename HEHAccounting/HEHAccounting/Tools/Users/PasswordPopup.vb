Public Class PasswordPopup
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.TxtPassword.Text.Length <> 0 And Me.TxtPassword.Text = "alrida" Then
            Me.DialogResult = DialogResult.Yes
        Else
            Me.TxtPassword.Clear()
            Me.TxtPassword.Focus()
        End If
    End Sub
End Class
