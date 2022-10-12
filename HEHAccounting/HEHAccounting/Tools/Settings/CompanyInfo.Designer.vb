<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompanyInfo))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MTxtCellPhone = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.MTxtPhone = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtEmail = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtCompLatinAddress = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtCompAddress = New Telerik.WinControls.UI.RadTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCompName = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtCompLatinName = New Telerik.WinControls.UI.RadTextBox()
        Me.CompPic = New System.Windows.Forms.PictureBox()
        Me.TxtPicLocation = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MTxtCellPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MTxtPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCompLatinAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCompAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCompName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCompLatinName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPicLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MTxtCellPhone, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.MTxtPhone, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtEmail, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCompLatinAddress, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCompAddress, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LblUsername, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCompName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCompLatinName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CompPic, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtPicLocation, 0, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(417, 224)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MTxtCellPhone
        '
        Me.MTxtCellPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MTxtCellPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtCellPhone.Location = New System.Drawing.Point(160, 153)
        Me.MTxtCellPhone.Mask = "00-000000"
        Me.MTxtCellPhone.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.MTxtCellPhone.Name = "MTxtCellPhone"
        Me.MTxtCellPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MTxtCellPhone.ShortcutsEnabled = False
        Me.MTxtCellPhone.Size = New System.Drawing.Size(159, 24)
        Me.MTxtCellPhone.TabIndex = 87
        Me.MTxtCellPhone.TabStop = False
        Me.MTxtCellPhone.Text = "__-______"
        Me.MTxtCellPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MTxtCellPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MTxtCellPhone.ThemeName = "Office2010Blue"
        '
        'MTxtPhone
        '
        Me.MTxtPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MTxtPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtPhone.Location = New System.Drawing.Point(160, 123)
        Me.MTxtPhone.Mask = "00-000000"
        Me.MTxtPhone.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.MTxtPhone.Name = "MTxtPhone"
        Me.MTxtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MTxtPhone.ShortcutsEnabled = False
        Me.MTxtPhone.Size = New System.Drawing.Size(159, 24)
        Me.MTxtPhone.TabIndex = 86
        Me.MTxtPhone.TabStop = False
        Me.MTxtPhone.Text = "__-______"
        Me.MTxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MTxtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MTxtPhone.ThemeName = "Office2010Blue"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.White
        Me.TxtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtEmail.Location = New System.Drawing.Point(160, 183)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ShortcutsEnabled = False
        Me.TxtEmail.Size = New System.Drawing.Size(159, 24)
        Me.TxtEmail.TabIndex = 85
        Me.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtEmail.ThemeName = "Office2010Blue"
        '
        'TxtCompLatinAddress
        '
        Me.TxtCompLatinAddress.BackColor = System.Drawing.Color.White
        Me.TxtCompLatinAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCompLatinAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtCompLatinAddress.Location = New System.Drawing.Point(160, 93)
        Me.TxtCompLatinAddress.Name = "TxtCompLatinAddress"
        Me.TxtCompLatinAddress.ShortcutsEnabled = False
        Me.TxtCompLatinAddress.Size = New System.Drawing.Size(159, 24)
        Me.TxtCompLatinAddress.TabIndex = 85
        Me.TxtCompLatinAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCompLatinAddress.ThemeName = "Office2010Blue"
        '
        'TxtCompAddress
        '
        Me.TxtCompAddress.BackColor = System.Drawing.Color.White
        Me.TxtCompAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCompAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtCompAddress.Location = New System.Drawing.Point(160, 63)
        Me.TxtCompAddress.Name = "TxtCompAddress"
        Me.TxtCompAddress.ShortcutsEnabled = False
        Me.TxtCompAddress.Size = New System.Drawing.Size(159, 24)
        Me.TxtCompAddress.TabIndex = 85
        Me.TxtCompAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCompAddress.ThemeName = "Office2010Blue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(325, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 30)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "الإميل"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(325, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 30)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "الخليوي"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUsername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblUsername.Location = New System.Drawing.Point(325, 0)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(89, 30)
        Me.LblUsername.TabIndex = 76
        Me.LblUsername.Text = "إسم المؤسسة"
        Me.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(325, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 30)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "الهاتف"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(325, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 30)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "العنوان"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(325, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 30)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "الإسم اللاتيني"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(325, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 30)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "العنوان اللاتيني"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCompName
        '
        Me.TxtCompName.BackColor = System.Drawing.Color.White
        Me.TxtCompName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCompName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtCompName.Location = New System.Drawing.Point(160, 3)
        Me.TxtCompName.Name = "TxtCompName"
        Me.TxtCompName.ShortcutsEnabled = False
        Me.TxtCompName.Size = New System.Drawing.Size(159, 24)
        Me.TxtCompName.TabIndex = 83
        Me.TxtCompName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCompName.ThemeName = "Office2010Blue"
        '
        'TxtCompLatinName
        '
        Me.TxtCompLatinName.BackColor = System.Drawing.Color.White
        Me.TxtCompLatinName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCompLatinName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtCompLatinName.Location = New System.Drawing.Point(160, 33)
        Me.TxtCompLatinName.Name = "TxtCompLatinName"
        Me.TxtCompLatinName.ShortcutsEnabled = False
        Me.TxtCompLatinName.Size = New System.Drawing.Size(159, 24)
        Me.TxtCompLatinName.TabIndex = 84
        Me.TxtCompLatinName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCompLatinName.ThemeName = "Office2010Blue"
        '
        'CompPic
        '
        Me.CompPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CompPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompPic.Image = Global.HEHAccounting.My.Resources.Resources.photo
        Me.CompPic.Location = New System.Drawing.Point(3, 3)
        Me.CompPic.Name = "CompPic"
        Me.TableLayoutPanel1.SetRowSpan(Me.CompPic, 7)
        Me.CompPic.Size = New System.Drawing.Size(151, 204)
        Me.CompPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CompPic.TabIndex = 88
        Me.CompPic.TabStop = False
        '
        'TxtPicLocation
        '
        Me.TxtPicLocation.Location = New System.Drawing.Point(413, 213)
        Me.TxtPicLocation.Name = "TxtPicLocation"
        Me.TxtPicLocation.Size = New System.Drawing.Size(1, 20)
        Me.TxtPicLocation.TabIndex = 89
        Me.TxtPicLocation.Visible = False
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 224)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(417, 44)
        Me.TableLayoutPanel2.TabIndex = 80
        '
        'BtnSaveAndNew
        '
        Me.BtnSaveAndNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSaveAndNew.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSaveAndNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveAndNew.Location = New System.Drawing.Point(213, 3)
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
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(111, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(94, 36)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CompanyInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 268)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompanyInfo"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "معلومات عامة"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.MTxtCellPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MTxtPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCompLatinAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCompAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCompName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCompLatinName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPicLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtCompLatinAddress As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtCompAddress As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtCompName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtCompLatinName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents MTxtCellPhone As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents MTxtPhone As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents CompPic As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TxtPicLocation As Telerik.WinControls.UI.RadTextBox
End Class

