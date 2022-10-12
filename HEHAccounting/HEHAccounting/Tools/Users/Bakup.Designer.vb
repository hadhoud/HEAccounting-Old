<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BackupFrm
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
        Me.components = New System.ComponentModel.Container()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.BtnSave = New Telerik.WinControls.UI.RadButton()
        Me.TxtItemPicture = New Telerik.WinControls.UI.RadTextBox()
        Me.DbProgressBar = New Telerik.WinControls.UI.RadProgressBar()
        Me.TxtFolder = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.FolderPath = New Telerik.WinControls.UI.RadButtonElement()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DbTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DbBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.DbFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.DbOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DbProgressBar, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtFolder, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(422, 221)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnClose, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnSave, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtItemPicture, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 146)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(416, 41)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(101, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(104, 35)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.HEHAccounting.My.Resources.Resources.database_save
        Me.BtnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSave.Location = New System.Drawing.Point(211, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(104, 35)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Tag = "Save"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TxtItemPicture
        '
        Me.TxtItemPicture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemPicture.Location = New System.Drawing.Point(412, 3)
        Me.TxtItemPicture.Name = "TxtItemPicture"
        Me.TxtItemPicture.ShowClearButton = True
        Me.TxtItemPicture.Size = New System.Drawing.Size(1, 24)
        Me.TxtItemPicture.TabIndex = 37
        Me.TxtItemPicture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemPicture.ThemeName = "Office2010Blue"
        Me.TxtItemPicture.Visible = False
        '
        'DbProgressBar
        '
        Me.DbProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DbProgressBar.Location = New System.Drawing.Point(3, 193)
        Me.DbProgressBar.Name = "DbProgressBar"
        Me.DbProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DbProgressBar.SeparatorNumberOfColors = 1
        Me.DbProgressBar.ShowProgressIndicators = True
        Me.DbProgressBar.Size = New System.Drawing.Size(416, 25)
        Me.DbProgressBar.TabIndex = 10
        Me.DbProgressBar.Text = "0 %"
        Me.DbProgressBar.ThemeName = "Office2010Blue"
        Me.DbProgressBar.Visible = False
        '
        'TxtFolder
        '
        Me.TxtFolder.AcceptsTab = True
        Me.TxtFolder.BackColor = System.Drawing.Color.White
        Me.TxtFolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtFolder.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFolder.HideSelection = False
        Me.TxtFolder.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.FolderPath})
        Me.TxtFolder.Location = New System.Drawing.Point(3, 114)
        Me.TxtFolder.MaxLength = 65535
        Me.TxtFolder.Name = "TxtFolder"
        Me.TxtFolder.ReadOnly = True
        Me.TxtFolder.ShowClearButton = True
        Me.TxtFolder.Size = New System.Drawing.Size(416, 26)
        Me.TxtFolder.TabIndex = 11
        Me.TxtFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtFolder.ThemeName = "Office2010Blue"
        Me.TxtFolder.WordWrap = False
        '
        'FolderPath
        '
        Me.FolderPath.DisplayStyle = Telerik.WinControls.DisplayStyle.Text
        Me.FolderPath.Image = Nothing
        Me.FolderPath.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.FolderPath.Name = "FolderPath"
        Me.FolderPath.SmallImage = Nothing
        Me.FolderPath.Text = "..."
        Me.FolderPath.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.FolderPath.UseCompatibleTextRendering = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.HEHAccounting.My.Resources.Resources.DatabasePic
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(416, 105)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'DbTimer
        '
        Me.DbTimer.Interval = 200
        '
        'DbBackgroundWorker
        '
        Me.DbBackgroundWorker.WorkerReportsProgress = True
        '
        'DbOpenFileDialog
        '
        Me.DbOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'BackupFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 221)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BackupFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نسخة إحتياطية"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtItemPicture As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents DbTimer As Timer
    Friend WithEvents DbProgressBar As Telerik.WinControls.UI.RadProgressBar
    Friend WithEvents DbBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtFolder As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents FolderPath As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents DbFolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DbOpenFileDialog As OpenFileDialog
End Class

