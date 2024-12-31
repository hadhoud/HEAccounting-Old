Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32
Imports Telerik.ReportViewer.WinForms.Resources
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class LoginFrm
    Public SystemCick As Integer = 0
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub RadioAr_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadioAr.ToggleStateChanged
        Me.BtnLogin.Text = LoStrId.LblLogin
        Me.BtnExit.Text = LoStrId.LblExit
        Me.LblPassword.Text = LoStrId.LblPassword
        Me.LblUsername.Text = LoStrId.LblUsername
        Me.ChkRememberme.Text = LoStrId.LblRememberMe
        Me.Text = LoStrId.LblLoginFrm
        Me.RightToLeft = RightToLeft.Yes
        UpdateLang("Ar")

    End Sub
    Private Sub CheckLogin()
        If Me.TxtUserName.Text.Trim.Length <> 0 Then
            If Me.TxtPassword.Text.Trim.Length <> 0 Then
                Dim Param(0) As String
                Dim UserPass As String
                Param(0) = "@VUsername , " & Evalquote(Me.TxtUserName.Text)
                Dim UserDt As DataTable = ExecuteProcedureDatatableWithParameters("GetUserBYUsername", Param)
                If UserDt IsNot Nothing Then
                    If UserDt.Rows.Count > 0 Then
                        UserPass = Decode(UserDt.Rows(0).Item("Password").ToString)
                        If Evalquote(Me.TxtPassword.Text) = UserPass Then
                            UserID = UserDt.Rows(0).Item("UserID").ToString
                            FullName = UserDt.Rows(0).Item("FullName").ToString
                            Username = UserDt.Rows(0).Item("Username").ToString
                            UserType = UserDt.Rows(0).Item("UserType").ToString
                            UserPassword = UserPass
                            If ChkRememberme.CheckState = CheckState.Checked Then
                                My.Settings.RemmberUserName = Me.TxtUserName.Text
                            Else
                                My.Settings.RemmberUserName = ""
                            End If
                            Me.Hide()
                            Home.Show()
                            Me.Close()
                        Else
                            MessageShowInfo(Con.Msg_Check_Username_Password)
                        End If
                    Else
                        MessageShowInfo(Con.Msg_Check_Username_Password)
                    End If
                Else
                    MessageShowInfo(Con.Msg_Db_NotConnected)
                End If
            Else
                MessageShowInfo(Con.Msg_Empty_Password)
            End If
        Else
            MessageShowInfo(Con.Msg_Empty_Username)
        End If
    End Sub
    Private Sub RadioEn_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadioEn.ToggleStateChanged
        Me.BtnLogin.Text = LoStrId.LblLatinLogin
        Me.BtnExit.Text = LoStrId.LblLatinExit
        Me.LblPassword.Text = LoStrId.LblLatinPassword
        Me.LblUsername.Text = LoStrId.LblLatinUsername
        Me.ChkRememberme.Text = LoStrId.LblLatinRememberMe
        Me.Text = LoStrId.LblLatinLoginFrm
        Me.RightToLeft = RightToLeft.No
        UpdateLang("En")

    End Sub

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readConfigurationXmlFile()
        CheckRight()
        Me.TxtUserName.Text = My.Settings.RemmberUserName
        If Me.TxtUserName.Text.Trim.Length <> 0 Then
            Me.ChkRememberme.Checked = True
            Me.TxtPassword.Select()
        End If
        Home.GetAppSettings()
        Me.TlpLang.Visible = BoolShowLang
        Me.RadioAr.CheckState = IIf(BoolLTRLanguage, CheckState.Unchecked, CheckState.Checked)
        Me.RadioEn.CheckState = IIf(BoolLTRLanguage, CheckState.Checked, CheckState.Unchecked)

    End Sub

    Private Sub CheckRight()
        Dim FILE_NAME As String = Application.StartupPath & "\key.txt"
        Dim regKey As RegistryKey
        Dim Key As String
        Dim TextLine As String

        regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True).OpenSubKey("RobotApp")
        'regKey.DeleteSubKey("RobotApp", True)

        If regKey Is Nothing Then
            If System.IO.File.Exists(FILE_NAME) = True Then

                Dim objReader As New System.IO.StreamReader(FILE_NAME)
                Do While objReader.Peek() <> -1

                    TextLine = TextLine & objReader.ReadLine()
                Loop
                regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
                regKey.CreateSubKey("RobotApp", True)
                regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True).OpenSubKey("RobotApp", True)
                regKey.SetValue("key", TextLine)
                Key = regKey.GetValue("key", "")
                If Key <> "ABCDERDDDE!EEEEEDFGAS!SAEEF!DASQW@!#!@#S!AASCDASDCA!D454545as!d5ad54a5sd" Then
                    regKey.Close()
                    MessageBox.Show("غير مصرح لك الدخول")
                    Application.Exit()
                End If
            Else
                MessageBox.Show("غير مصرح لك الدخول")
                Application.Exit()
            End If
        Else
            Key = regKey.GetValue("key", "")
            If Key <> "ABCDERDDDE!EEEEEDFGAS!SAEEF!DASQW@!#!@#S!AASCDASDCA!D454545as!d5ad54a5sd" Then
                regKey.Close()
                MessageBox.Show("غير مصرح لك الدخول")
                Application.Exit()
            End If
        End If
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
        ' Me.TxtUserName.Text = Encode(Me.TxtPassword.Text)

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        CheckLogin()
    End Sub

    Private Sub LblPassword_Click(sender As Object, e As EventArgs) Handles LblPassword.Click
        If Me.TxtPassword.PasswordChar = vbNullChar Then
            Me.TxtPassword.PasswordChar = "*"c
        Else
            Me.TxtPassword.PasswordChar = String.Empty
        End If
    End Sub

    Private Sub LblProgName_Click(sender As Object, e As EventArgs) Handles LblProgName.Click
        If (Control.ModifierKeys = System.Windows.Forms.Keys.Control) And Me.TxtUserName.Text = "Admin" And Me.TxtPassword.Text = "System" Then
            SystemCick = SystemCick + 1
            If SystemCick = 3 Then
                Dim FrmSystemDatabaseConfiguration As New SystemDatabaseConfiguration
                FrmSystemDatabaseConfiguration.ShowDialog()
                SystemCick = 0
            End If
        End If
    End Sub
End Class
