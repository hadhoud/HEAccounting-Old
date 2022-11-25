
Public Class BackupFrm
    Public BackupOrRestore As String = "Backup"
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'DbSaveFileDialog.FileName = "HEAccounting"      
        If Me.TxtFolder.Text.Trim.Length <> 0 And DbProgressBar.Visible = False Then
            DbProgressBar.Value1 = 0
            DbProgressBar.Visible = True
            DbTimer.Enabled = True
            Me.BtnSave.Enabled = False
            DbBackgroundWorker.RunWorkerAsync()
        End If
    End Sub

    Private Sub DbTimer_Tick(sender As Object, e As EventArgs) Handles DbTimer.Tick
        If DbProgressBar.Value1 = 100 Then
            DbTimer.Enabled = False
            DbProgressBar.Visible = False
            Me.TxtFolder.Text = ""
            MessageShowInfo(Con.Msg_Successfully_Done)
        Else
            DbProgressBar.Value1 = DbProgressBar.Value1 + 1
        End If
    End Sub

    Private Sub DbBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles DbBackgroundWorker.DoWork
        ' DbProgressBar.Visible = True
        If BackupOrRestore = "Backup" Then
            Dim s As String
            Dim BakName As String
            BakName = "\HEAccounting-" & Date.Today.Day & "-" & Date.Today.Month & "-" & Date.Today.Year & "-" &
            TimeOfDay.Hour & "-" & TimeOfDay.Minute.ToString & ".Bak"
            s = DbFolderBrowserDialog.SelectedPath
            ExecuteQuerySQL("BACKUP database HEAccounting" & " to disk='" & s & BakName & "'")
        ElseIf BackupOrRestore = "Restore" Then
            Dim SQl_Restore As String
            SQl_Restore = " alter database HEAccounting set offline with rollback immediate"
            SQl_Restore &= " RESTORE database HEAccounting" & " FROM disk='" & Me.DbOpenFileDialog.FileName & "'"
            SQl_Restore &= " alter database HEAccounting set online"
            ExecuteQuerySQL(SQl_Restore)
        End If

    End Sub

    Private Sub FolderPath_Click(sender As Object, e As EventArgs) Handles FolderPath.Click
        If DbProgressBar.Visible = False Then
            If BackupOrRestore = "Backup" Then
                DbFolderBrowserDialog.ShowDialog()
                Me.TxtFolder.Text = Me.DbFolderBrowserDialog.SelectedPath
            ElseIf BackupOrRestore = "Restore" Then
                DbOpenFileDialog.FileName = ""
                DbOpenFileDialog.Filter = "Backup Files|*.Bak"
                DbOpenFileDialog.ShowDialog()
                Me.TxtFolder.Text = Me.DbOpenFileDialog.FileName
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BakupFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DbProgressBar.Visible = True Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub BackupFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BackupOrRestore = "Backup" Then

        ElseIf BackupOrRestore = "Restore" Then
            Me.BtnSave.Text = Con.Restore
            Me.Text = Con.RestoreDatabase
        End If
    End Sub
End Class
