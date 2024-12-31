<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProgramLog
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
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProgramLog))
        Me.GridLogs = New Telerik.WinControls.UI.RadGridView()
        Me.MskTxtInvDateTo = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.MskTxtInvDateFrom = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.CheckDateFrom = New Telerik.WinControls.UI.RadCheckBox()
        Me.CheckDateTo = New Telerik.WinControls.UI.RadCheckBox()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.BtnRefrech = New Telerik.WinControls.UI.RadButton()
        Me.btnDeleteAll = New Telerik.WinControls.UI.RadButton()
        CType(Me.GridLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLogs.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridLogs
        '
        Me.GridLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridLogs.Location = New System.Drawing.Point(3, 3)
        '
        '
        '
        Me.GridLogs.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.GridLogs.Name = "GridLogs"
        Me.GridLogs.Size = New System.Drawing.Size(623, 408)
        Me.GridLogs.TabIndex = 5
        '
        'MskTxtInvDateTo
        '
        Me.MskTxtInvDateTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateTo.Enabled = False
        Me.MskTxtInvDateTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtInvDateTo.Location = New System.Drawing.Point(3, 3)
        Me.MskTxtInvDateTo.Mask = "dd/MM/yyyy"
        Me.MskTxtInvDateTo.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtInvDateTo.Name = "MskTxtInvDateTo"
        Me.MskTxtInvDateTo.Size = New System.Drawing.Size(166, 24)
        Me.MskTxtInvDateTo.TabIndex = 44
        Me.MskTxtInvDateTo.TabStop = False
        Me.MskTxtInvDateTo.Text = "01/01/2020"
        Me.MskTxtInvDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDateTo.ThemeName = "Office2010Blue"
        '
        'MskTxtInvDateFrom
        '
        Me.MskTxtInvDateFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateFrom.Enabled = False
        Me.MskTxtInvDateFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtInvDateFrom.Location = New System.Drawing.Point(3, 3)
        Me.MskTxtInvDateFrom.Mask = "dd/MM/yyyy"
        Me.MskTxtInvDateFrom.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtInvDateFrom.Name = "MskTxtInvDateFrom"
        Me.MskTxtInvDateFrom.Size = New System.Drawing.Size(166, 24)
        Me.MskTxtInvDateFrom.TabIndex = 25
        Me.MskTxtInvDateFrom.TabStop = False
        Me.MskTxtInvDateFrom.Text = "01/01/2020"
        Me.MskTxtInvDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDateFrom.ThemeName = "Office2010Blue"
        '
        'CheckDateFrom
        '
        Me.CheckDateFrom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckDateFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDateFrom.Location = New System.Drawing.Point(175, 7)
        Me.CheckDateFrom.Name = "CheckDateFrom"
        Me.CheckDateFrom.Size = New System.Drawing.Size(15, 15)
        Me.CheckDateFrom.TabIndex = 44
        Me.CheckDateFrom.ThemeName = "Office2010Blue"
        '
        'CheckDateTo
        '
        Me.CheckDateTo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckDateTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDateTo.Location = New System.Drawing.Point(175, 7)
        Me.CheckDateTo.Name = "CheckDateTo"
        Me.CheckDateTo.Size = New System.Drawing.Size(15, 15)
        Me.CheckDateTo.TabIndex = 45
        Me.CheckDateTo.ThemeName = "Office2010Blue"
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTo.Location = New System.Drawing.Point(202, 56)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(26, 36)
        Me.LblTo.TabIndex = 18
        Me.LblTo.Text = "إلى"
        Me.LblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFrom.Location = New System.Drawing.Point(202, 20)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(26, 36)
        Me.LblFrom.TabIndex = 17
        Me.LblFrom.Text = "من"
        Me.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Image = Global.HEHAccounting.My.Resources.Resources.Redo
        Me.BtnReset.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnReset.Location = New System.Drawing.Point(13, 3)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(90, 36)
        Me.BtnReset.TabIndex = 8
        Me.BtnReset.Text = "تصفير"
        Me.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnFiltering
        '
        Me.BtnFiltering.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFiltering.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFiltering.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnFiltering.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltering.Location = New System.Drawing.Point(129, 3)
        Me.BtnFiltering.Name = "BtnFiltering"
        Me.BtnFiltering.Size = New System.Drawing.Size(90, 36)
        Me.BtnFiltering.TabIndex = 16
        Me.BtnFiltering.Text = "بحث"
        Me.BtnFiltering.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.MskTxtInvDateFrom, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.CheckDateFrom, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 23)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(193, 30)
        Me.TableLayoutPanel4.TabIndex = 42
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Image = Global.HEHAccounting.My.Resources.Resources.print
        Me.BtnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPrint.Location = New System.Drawing.Point(128, 45)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(90, 36)
        Me.BtnPrint.TabIndex = 17
        Me.BtnPrint.Tag = "Print"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrint.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnPrint, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnFiltering, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnReset, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 321)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(231, 84)
        Me.TableLayoutPanel3.TabIndex = 16
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.MskTxtInvDateTo, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.CheckDateTo, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 59)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(193, 30)
        Me.TableLayoutPanel5.TabIndex = 43
        '
        'PnlOptions
        '
        Me.PnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel6)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlOptions.Location = New System.Drawing.Point(632, 3)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(237, 408)
        Me.PnlOptions.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LblTo, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LblFrom, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 130)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(231, 191)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PnlOptions, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GridLogs, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(872, 414)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.BtnDelete, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.BtnRefrech, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.btnDeleteAll, 0, 2)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 4
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(231, 127)
        Me.TableLayoutPanel6.TabIndex = 17
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(119, 24)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(109, 36)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnRefrech
        '
        Me.BtnRefrech.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRefrech.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRefrech.Image = Global.HEHAccounting.My.Resources.Resources.Sync
        Me.BtnRefrech.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnRefrech.Location = New System.Drawing.Point(4, 24)
        Me.BtnRefrech.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.BtnRefrech.Name = "BtnRefrech"
        Me.BtnRefrech.Size = New System.Drawing.Size(109, 36)
        Me.BtnRefrech.TabIndex = 3
        Me.BtnRefrech.Text = "تحديث"
        Me.BtnRefrech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btnDeleteAll
        '
        Me.btnDeleteAll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDeleteAll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteAll.Image = CType(resources.GetObject("btnDeleteAll.Image"), System.Drawing.Image)
        Me.btnDeleteAll.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDeleteAll.Location = New System.Drawing.Point(119, 73)
        Me.btnDeleteAll.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btnDeleteAll.Name = "btnDeleteAll"
        Me.btnDeleteAll.Size = New System.Drawing.Size(109, 36)
        Me.btnDeleteAll.TabIndex = 4
        Me.btnDeleteAll.Text = "حذف الحميع"
        Me.btnDeleteAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'ProgramLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 414)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProgramLog"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "FrmProgLog"
        Me.Text = "LOG"
        Me.ThemeName = "Office2010Blue"
        CType(Me.GridLogs.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridLogs As Telerik.WinControls.UI.RadGridView
    Friend WithEvents MskTxtInvDateTo As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents MskTxtInvDateFrom As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents CheckDateFrom As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents CheckDateTo As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents LblTo As Label
    Friend WithEvents LblFrom As Label
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnRefrech As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnDeleteAll As Telerik.WinControls.UI.RadButton
End Class

