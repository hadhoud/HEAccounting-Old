<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SystemDatabaseConfiguration
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SystemDatabaseConfiguration))
        Me.TxtDBPassword = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtDBName = New Telerik.WinControls.UI.RadTextBox()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtDBUserName = New Telerik.WinControls.UI.RadTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.isDbWindowsAuth = New Telerik.WinControls.UI.RadCheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtServerName = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRefreshConfig = New Telerik.WinControls.UI.RadButton()
        Me.btnTestConnection = New Telerik.WinControls.UI.RadButton()
        CType(Me.TxtDBPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDBName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtDBUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.isDbWindowsAuth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServerName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.btnRefreshConfig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTestConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDBPassword
        '
        Me.TxtDBPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDBPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDBPassword.Location = New System.Drawing.Point(3, 97)
        Me.TxtDBPassword.Name = "TxtDBPassword"
        Me.TxtDBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtDBPassword.ShowClearButton = True
        Me.TxtDBPassword.Size = New System.Drawing.Size(200, 24)
        Me.TxtDBPassword.TabIndex = 72
        Me.TxtDBPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDBPassword.ThemeName = "Office2010Blue"
        '
        'TxtDBName
        '
        Me.TxtDBName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDBName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDBName.Location = New System.Drawing.Point(3, 127)
        Me.TxtDBName.Name = "TxtDBName"
        Me.TxtDBName.ShowClearButton = True
        Me.TxtDBName.Size = New System.Drawing.Size(200, 24)
        Me.TxtDBName.TabIndex = 73
        Me.TxtDBName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDBName.ThemeName = "Office2010Blue"
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUsername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(209, 64)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(104, 30)
        Me.LblUsername.TabIndex = 75
        Me.LblUsername.Text = "إسم المستخدم"
        Me.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(209, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 30)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "كلمة المرور"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtDBUserName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblUsername, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtDBName, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtDBPassword, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.isDbWindowsAuth, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtServerName, 1, 4)
        Me.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(316, 235)
        Me.TableLayoutPanel1.TabIndex = 77
        '
        'TxtDBUserName
        '
        Me.TxtDBUserName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDBUserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDBUserName.Location = New System.Drawing.Point(3, 67)
        Me.TxtDBUserName.Name = "TxtDBUserName"
        Me.TxtDBUserName.ShowClearButton = True
        Me.TxtDBUserName.Size = New System.Drawing.Size(200, 24)
        Me.TxtDBUserName.TabIndex = 73
        Me.TxtDBUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDBUserName.ThemeName = "Office2010Blue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(209, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 21)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Windows Auth"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(209, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 30)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "قاعدة البيانات"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSaveAndNew, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnClose, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 235)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(316, 47)
        Me.TableLayoutPanel2.TabIndex = 79
        '
        'BtnSaveAndNew
        '
        Me.BtnSaveAndNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSaveAndNew.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSaveAndNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveAndNew.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSaveAndNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveAndNew.Location = New System.Drawing.Point(162, 3)
        Me.BtnSaveAndNew.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.BtnSaveAndNew.Name = "BtnSaveAndNew"
        Me.BtnSaveAndNew.Size = New System.Drawing.Size(94, 36)
        Me.BtnSaveAndNew.TabIndex = 6
        Me.BtnSaveAndNew.Tag = "Save"
        Me.BtnSaveAndNew.Text = "حفظ"
        Me.BtnSaveAndNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(60, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(94, 36)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'isDbWindowsAuth
        '
        Me.isDbWindowsAuth.Cursor = System.Windows.Forms.Cursors.Default
        Me.isDbWindowsAuth.Location = New System.Drawing.Point(188, 187)
        Me.isDbWindowsAuth.Name = "isDbWindowsAuth"
        Me.isDbWindowsAuth.Size = New System.Drawing.Size(15, 15)
        Me.isDbWindowsAuth.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(209, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 30)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Server"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtServerName
        '
        Me.txtServerName.BackColor = System.Drawing.Color.White
        Me.txtServerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtServerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServerName.Location = New System.Drawing.Point(3, 157)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.ShowClearButton = True
        Me.txtServerName.Size = New System.Drawing.Size(200, 24)
        Me.txtServerName.TabIndex = 82
        Me.txtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtServerName.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnRefreshConfig, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTestConnection, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(316, 47)
        Me.TableLayoutPanel3.TabIndex = 80
        '
        'btnRefreshConfig
        '
        Me.btnRefreshConfig.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRefreshConfig.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnRefreshConfig.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshConfig.Image = Global.HEHAccounting.My.Resources.Resources.Sync
        Me.btnRefreshConfig.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRefreshConfig.Location = New System.Drawing.Point(163, 3)
        Me.btnRefreshConfig.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.btnRefreshConfig.Name = "btnRefreshConfig"
        Me.btnRefreshConfig.Size = New System.Drawing.Size(87, 36)
        Me.btnRefreshConfig.TabIndex = 6
        Me.btnRefreshConfig.Tag = "Save"
        Me.btnRefreshConfig.Text = "تحديث"
        Me.btnRefreshConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnTestConnection
        '
        Me.btnTestConnection.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnTestConnection.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTestConnection.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestConnection.Image = Global.HEHAccounting.My.Resources.Resources.Database
        Me.btnTestConnection.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnTestConnection.Location = New System.Drawing.Point(66, 3)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(89, 36)
        Me.btnTestConnection.TabIndex = 5
        Me.btnTestConnection.Text = "فحص"
        Me.btnTestConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'SystemDatabaseConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 282)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SystemDatabaseConfiguration"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إعدادات قاعدة البيانات"
        Me.ThemeName = "Office2010Blue"
        CType(Me.TxtDBPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDBName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtDBUserName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.isDbWindowsAuth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServerName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.btnRefreshConfig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTestConnection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtDBPassword As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtDBName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents isDbWindowsAuth As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtServerName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtDBUserName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnRefreshConfig As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnTestConnection As Telerik.WinControls.UI.RadButton
End Class

