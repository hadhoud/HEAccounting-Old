Imports HEHAccounting.My
Imports HEHAccounting.My.MySettings
Public Class SystemDatabaseConfiguration

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If Me.txtServerName.Text.Length = 0 Or Me.TxtDBName.Text.Length = 0 Then
            MessageShowInfo(Con.Msg_Enter_All_Fields)
            Exit Sub
        Else
            If isDbWindowsAuth.Checked = False Then
                If Me.TxtDBUserName.Text.Length = 0 Or Me.TxtDBPassword.Text.Length = 0 Then
                    MessageShowInfo(Con.Msg_System_Config_Enter_User_And_Pass)
                    Exit Sub
                Else
                    My.Settings.DBName = Me.TxtDBName.Text
                    My.Settings.DBUserName = Me.TxtDBUserName.Text
                    My.Settings.DBUserPassword = Encode(Me.TxtDBPassword.Text)
                    My.Settings.ServerName = Me.txtServerName.Text
                    My.Settings.ServerMode = "SQLServer"
                End If
            Else
                My.Settings.DBName = Me.TxtDBName.Text
                My.Settings.DBUserName = ""
                My.Settings.DBUserPassword = ""
                My.Settings.ServerName = Me.txtServerName.Text
                My.Settings.ServerMode = "Windows"
            End If
        End If
        Me.Close()
    End Sub

    Private Sub SystemDatabaseConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtDBName.Text = My.Settings.DBName
        Me.TxtDBUserName.Text = My.Settings.DBUserName
        Me.txtServerName.Text = My.Settings.ServerName
        If My.Settings.ServerMode = "Windows" Then
            Me.isDbWindowsAuth.Checked = True
        Else
            Me.isDbWindowsAuth.Checked = False
        End If
    End Sub

    Private Sub isDbWindowsAuth_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles isDbWindowsAuth.ToggleStateChanged
        If isDbWindowsAuth.Checked = False Then
            Me.TxtDBUserName.Enabled = True
            Me.TxtDBPassword.Enabled = True
        Else
            Me.TxtDBUserName.Enabled = False
            Me.TxtDBPassword.Enabled = False
            Me.TxtDBUserName.Clear()
            Me.TxtDBPassword.Clear()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Me.TxtDBPassword.PasswordChar = vbNullChar Then
            Me.TxtDBPassword.PasswordChar = "*"c
        Else
            Me.TxtDBPassword.PasswordChar = String.Empty
        End If
    End Sub
End Class
