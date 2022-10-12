<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginFrm
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFrm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtUserName = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtPassword = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpLang = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioAr = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadioEn = New Telerik.WinControls.UI.RadRadioButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnExit = New Telerik.WinControls.UI.RadButton()
        Me.BtnLogin = New Telerik.WinControls.UI.RadButton()
        Me.LblProgName = New System.Windows.Forms.Label()
        Me.ChkRememberme = New Telerik.WinControls.UI.RadCheckBox()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TlpLang.SuspendLayout()
        CType(Me.RadioAr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioEn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkRememberme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.75339!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.24661!))
        Me.TableLayoutPanel1.Controls.Add(Me.LblUsername, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblPassword, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtUserName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtPassword, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LblProgName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkRememberme, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(310, 184)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LblUsername
        '
        Me.LblUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUsername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(193, 47)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(114, 30)
        Me.LblUsername.TabIndex = 68
        Me.LblUsername.Text = "إسم المستخدم"
        Me.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPassword
        '
        Me.LblPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(193, 77)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(114, 30)
        Me.LblPassword.TabIndex = 69
        Me.LblPassword.Text = "كلمة المرور"
        Me.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtUserName
        '
        Me.TxtUserName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtUserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Location = New System.Drawing.Point(3, 50)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.ShortcutsEnabled = False
        Me.TxtUserName.ShowClearButton = True
        Me.TxtUserName.Size = New System.Drawing.Size(184, 24)
        Me.TxtUserName.TabIndex = 70
        Me.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtUserName.ThemeName = "Office2010Blue"
        '
        'TxtPassword
        '
        Me.TxtPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(3, 80)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.ShortcutsEnabled = False
        Me.TxtPassword.ShowClearButton = True
        Me.TxtPassword.Size = New System.Drawing.Size(184, 24)
        Me.TxtPassword.TabIndex = 71
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPassword.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TlpLang, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 122)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(301, 60)
        Me.TableLayoutPanel2.TabIndex = 74
        '
        'TlpLang
        '
        Me.TlpLang.ColumnCount = 1
        Me.TlpLang.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpLang.Controls.Add(Me.RadioAr, 0, 0)
        Me.TlpLang.Controls.Add(Me.RadioEn, 0, 1)
        Me.TlpLang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpLang.Location = New System.Drawing.Point(239, 3)
        Me.TlpLang.Name = "TlpLang"
        Me.TlpLang.RowCount = 2
        Me.TlpLang.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpLang.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpLang.Size = New System.Drawing.Size(59, 54)
        Me.TlpLang.TabIndex = 74
        '
        'RadioAr
        '
        Me.RadioAr.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioAr.Location = New System.Drawing.Point(15, 3)
        Me.RadioAr.Name = "RadioAr"
        Me.RadioAr.Size = New System.Drawing.Size(41, 22)
        Me.RadioAr.TabIndex = 0
        Me.RadioAr.TabStop = False
        Me.RadioAr.Text = "Ar"
        Me.RadioAr.ThemeName = "Office2010Blue"
        '
        'RadioEn
        '
        Me.RadioEn.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioEn.Location = New System.Drawing.Point(14, 31)
        Me.RadioEn.Name = "RadioEn"
        Me.RadioEn.Size = New System.Drawing.Size(42, 22)
        Me.RadioEn.TabIndex = 1
        Me.RadioEn.TabStop = False
        Me.RadioEn.Text = "En"
        Me.RadioEn.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.BtnExit, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnLogin, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(230, 54)
        Me.TableLayoutPanel4.TabIndex = 77
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Image = Global.HEHAccounting.My.Resources.Resources.logout
        Me.BtnExit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnExit.Location = New System.Drawing.Point(16, 9)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(83, 36)
        Me.BtnExit.TabIndex = 72
        Me.BtnExit.Tag = "Exit"
        Me.BtnExit.Text = "إغلاق"
        Me.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnLogin
        '
        Me.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnLogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Image = Global.HEHAccounting.My.Resources.Resources.login
        Me.BtnLogin.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnLogin.Location = New System.Drawing.Point(131, 9)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(83, 36)
        Me.BtnLogin.TabIndex = 73
        Me.BtnLogin.Tag = "login"
        Me.BtnLogin.Text = "دخول"
        Me.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'LblProgName
        '
        Me.LblProgName.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.LblProgName, 2)
        Me.LblProgName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblProgName.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.LblProgName.Location = New System.Drawing.Point(3, 0)
        Me.LblProgName.Name = "LblProgName"
        Me.LblProgName.Size = New System.Drawing.Size(304, 19)
        Me.LblProgName.TabIndex = 76
        Me.LblProgName.Text = "HE Accouting"
        Me.LblProgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkRememberme
        '
        Me.ChkRememberme.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChkRememberme.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRememberme.Location = New System.Drawing.Point(3, 22)
        Me.ChkRememberme.Name = "ChkRememberme"
        Me.ChkRememberme.Size = New System.Drawing.Size(59, 22)
        Me.ChkRememberme.TabIndex = 77
        Me.ChkRememberme.Text = "تذكرني"
        '
        'LoginFrm
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(310, 184)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إذن دحول"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TlpLang.ResumeLayout(False)
        Me.TlpLang.PerformLayout()
        CType(Me.RadioAr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioEn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.BtnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkRememberme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtUserName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtPassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnExit As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnLogin As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadioAr As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadioEn As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents LblProgName As Label
    Friend WithEvents TlpLang As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents ChkRememberme As Telerik.WinControls.UI.RadCheckBox
End Class

