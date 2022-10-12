Public Class CompanyInfo
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FillData()
    End Sub
    Private Sub FillData()
        Dim dtComp As DataTable = ExecuteProcedureDatatable("SelectCompanyInfo")
        If dtComp.Rows.Count > 0 Then
            Me.TxtCompName.Text = dtComp.Rows(0).Item("CompanyName").ToString
            Me.TxtCompLatinName.Text = dtComp.Rows(0).Item("LatinName").ToString
            Me.TxtCompAddress.Text = dtComp.Rows(0).Item("Address").ToString
            Me.TxtCompLatinAddress.Text = dtComp.Rows(0).Item("LatinAddress").ToString
            Me.MTxtPhone.Text = dtComp.Rows(0).Item("Phone").ToString
            Me.MTxtCellPhone.Text = dtComp.Rows(0).Item("CellPhone").ToString
            Me.TxtEmail.Text = dtComp.Rows(0).Item("Email").ToString
            Me.TxtPicLocation.Text = dtComp.Rows(0).Item("CompPic").ToString
            If TxtPicLocation.Text.Length <> 0 Then
                Me.CompPic.ImageLocation = Me.TxtPicLocation.Text
            End If
        End If
    End Sub
    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If Me.TxtCompName.Text.Trim.Length <> 0 Then
            If MessageShowAsk(Con.Ask_Add) = DialogResult.Yes Then
                Dim Param(7) As String
                Param(0) = "@CCompanyName , " & Me.TxtCompName.Text
                Param(1) = "@CLatinName  ," & Me.TxtCompLatinName.Text
                Param(2) = "@CAddress   , " & Me.TxtCompAddress.Text
                Param(3) = "@CLatinAddress , " & Me.TxtCompLatinAddress.Text
                Param(4) = "@CPhone , " & Me.MTxtPhone.Value
                Param(5) = "@CCellPhone , " & Me.MTxtCellPhone.Value
                Param(6) = "@CEmail , " & Me.TxtEmail.Text
                Param(7) = "@CCompPic , " & IIf(Me.TxtPicLocation.Text.Length > 0, Me.TxtPicLocation.Text, Nothing)
                ExecuteProcedureWithParameters("InsertCompanyInfo", Param)
            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub CompPic_Click(sender As Object, e As EventArgs) Handles CompPic.Click
        Me.OpenFileDialog1.FileName = "Document"
        Me.OpenFileDialog1.Filter = "Bitmaps|*.JPG;*.jpeg;*.jpg;*.bmp" & "|Icons|*.ico" & "|All Files|*.*"
        Me.OpenFileDialog1.FilterIndex = 1
        Me.OpenFileDialog1.Multiselect = False
        If Me.OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, Application.StartupPath & "\Reports" & "\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName), Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, FileIO.UICancelOption.DoNothing)
            Me.CompPic.ImageLocation = OpenFileDialog1.FileName.ToString
            Me.TxtPicLocation.Text = Application.StartupPath & "\Reports" & "\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
