<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daily
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
        Me.components = New System.ComponentModel.Container()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.LblCustomerVendor = New System.Windows.Forms.Label()
        Me.LblType = New System.Windows.Forms.Label()
        Me.TxtCustomerVendor = New Telerik.WinControls.UI.RadTextBox()
        Me.DropTrxType = New Telerik.WinControls.UI.RadDropDownList()
        Me.DropStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnOpen = New Telerik.WinControls.UI.RadButton()
        Me.BtnRefrech = New Telerik.WinControls.UI.RadButton()
        Me.GridDaily = New Telerik.WinControls.UI.RadGridView()
        Me.TimerFrm = New System.Windows.Forms.Timer(Me.components)
        Me.MskTxtInvDateTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.MskTxtInvDateFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.LblTo = New System.Windows.Forms.Label()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtCustomerVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropTrxType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDaily.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlOptions
        '
        Me.PnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlOptions.Location = New System.Drawing.Point(0, 0)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(255, 503)
        Me.PnlOptions.TabIndex = 4
        Me.PnlOptions.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnFiltering, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnReset, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 458)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(249, 42)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'BtnFiltering
        '
        Me.BtnFiltering.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFiltering.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFiltering.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnFiltering.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltering.Location = New System.Drawing.Point(142, 3)
        Me.BtnFiltering.Name = "BtnFiltering"
        Me.BtnFiltering.Size = New System.Drawing.Size(90, 36)
        Me.BtnFiltering.TabIndex = 7
        Me.BtnFiltering.Text = "بحث"
        Me.BtnFiltering.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Image = Global.HEHAccounting.My.Resources.Resources.Redo
        Me.BtnReset.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnReset.Location = New System.Drawing.Point(18, 3)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(90, 36)
        Me.BtnReset.TabIndex = 8
        Me.BtnReset.Text = "تصفير"
        Me.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LblTo, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LblFrom, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtInvDateTo, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatus, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtInvDateFrom, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCustomerVendor, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblType, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCustomerVendor, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DropTrxType, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DropStatus, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 74)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 230)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatus.Location = New System.Drawing.Point(180, 80)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(66, 30)
        Me.lblStatus.TabIndex = 20
        Me.lblStatus.Text = "الحالة"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCustomerVendor
        '
        Me.LblCustomerVendor.AutoSize = True
        Me.LblCustomerVendor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCustomerVendor.Location = New System.Drawing.Point(180, 50)
        Me.LblCustomerVendor.Name = "LblCustomerVendor"
        Me.LblCustomerVendor.Size = New System.Drawing.Size(66, 30)
        Me.LblCustomerVendor.TabIndex = 19
        Me.LblCustomerVendor.Text = "زبون/مورد"
        Me.LblCustomerVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblType
        '
        Me.LblType.AutoSize = True
        Me.LblType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblType.Location = New System.Drawing.Point(180, 20)
        Me.LblType.Name = "LblType"
        Me.LblType.Size = New System.Drawing.Size(66, 30)
        Me.LblType.TabIndex = 18
        Me.LblType.Text = "النوع"
        Me.LblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCustomerVendor
        '
        Me.TxtCustomerVendor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCustomerVendor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerVendor.Location = New System.Drawing.Point(3, 53)
        Me.TxtCustomerVendor.Name = "TxtCustomerVendor"
        Me.TxtCustomerVendor.ShortcutsEnabled = False
        Me.TxtCustomerVendor.ShowClearButton = True
        Me.TxtCustomerVendor.Size = New System.Drawing.Size(171, 24)
        Me.TxtCustomerVendor.TabIndex = 5
        Me.TxtCustomerVendor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCustomerVendor.ThemeName = "Office2010Blue"
        '
        'DropTrxType
        '
        Me.DropTrxType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropTrxType.DropDownAnimationEnabled = True
        Me.DropTrxType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropTrxType.Location = New System.Drawing.Point(3, 23)
        Me.DropTrxType.MaxLength = 65535
        Me.DropTrxType.Name = "DropTrxType"
        Me.DropTrxType.Size = New System.Drawing.Size(171, 24)
        Me.DropTrxType.TabIndex = 21
        Me.DropTrxType.Tag = ""
        Me.DropTrxType.ThemeName = "Office2010Blue"
        '
        'DropStatus
        '
        Me.DropStatus.BackColor = System.Drawing.Color.White
        Me.DropStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropStatus.DropDownAnimationEnabled = True
        Me.DropStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropStatus.Location = New System.Drawing.Point(3, 83)
        Me.DropStatus.MaxLength = 65535
        Me.DropStatus.Name = "DropStatus"
        Me.DropStatus.Size = New System.Drawing.Size(171, 24)
        Me.DropStatus.TabIndex = 23
        Me.DropStatus.Tag = ""
        Me.DropStatus.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnOpen, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnRefrech, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(249, 71)
        Me.TableLayoutPanel2.TabIndex = 18
        '
        'BtnOpen
        '
        Me.BtnOpen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnOpen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpen.Image = Global.HEHAccounting.My.Resources.Resources.book_open
        Me.BtnOpen.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOpen.Location = New System.Drawing.Point(142, 23)
        Me.BtnOpen.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(90, 36)
        Me.BtnOpen.TabIndex = 0
        Me.BtnOpen.Text = "معاينة"
        Me.BtnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnRefrech
        '
        Me.BtnRefrech.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRefrech.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefrech.Image = Global.HEHAccounting.My.Resources.Resources.Sync
        Me.BtnRefrech.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrech.Location = New System.Drawing.Point(18, 23)
        Me.BtnRefrech.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BtnRefrech.Name = "BtnRefrech"
        Me.BtnRefrech.Size = New System.Drawing.Size(90, 36)
        Me.BtnRefrech.TabIndex = 1
        Me.BtnRefrech.Text = "تحديث"
        Me.BtnRefrech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'GridDaily
        '
        Me.GridDaily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDaily.Location = New System.Drawing.Point(255, 0)
        '
        '
        '
        Me.GridDaily.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.GridDaily.Name = "GridDaily"
        Me.GridDaily.Size = New System.Drawing.Size(380, 503)
        Me.GridDaily.TabIndex = 5
        Me.GridDaily.ThemeName = "Office2010Blue"
        '
        'TimerFrm
        '
        '
        'MskTxtInvDateTo
        '
        Me.MskTxtInvDateTo.CustomFormat = "dd/MM/yyyy"
        Me.MskTxtInvDateTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MskTxtInvDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MskTxtInvDateTo.Location = New System.Drawing.Point(3, 143)
        Me.MskTxtInvDateTo.Name = "MskTxtInvDateTo"
        Me.MskTxtInvDateTo.ShowCheckBox = True
        Me.MskTxtInvDateTo.Size = New System.Drawing.Size(171, 24)
        Me.MskTxtInvDateTo.TabIndex = 20
        Me.MskTxtInvDateTo.TabStop = False
        Me.MskTxtInvDateTo.Text = "14/01/2023"
        Me.MskTxtInvDateTo.ThemeName = "Office2010Blue"
        Me.MskTxtInvDateTo.Value = New Date(2023, 1, 14, 0, 0, 0, 0)
        CType(Me.MskTxtInvDateTo.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).RightToLeft = True
        CType(Me.MskTxtInvDateTo.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "14/01/2023"
        '
        'MskTxtInvDateFrom
        '
        Me.MskTxtInvDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.MskTxtInvDateFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MskTxtInvDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MskTxtInvDateFrom.Location = New System.Drawing.Point(3, 113)
        Me.MskTxtInvDateFrom.Name = "MskTxtInvDateFrom"
        Me.MskTxtInvDateFrom.ShowCheckBox = True
        Me.MskTxtInvDateFrom.Size = New System.Drawing.Size(171, 24)
        Me.MskTxtInvDateFrom.TabIndex = 19
        Me.MskTxtInvDateFrom.TabStop = False
        Me.MskTxtInvDateFrom.Text = "14/01/2023"
        Me.MskTxtInvDateFrom.ThemeName = "Office2010Blue"
        Me.MskTxtInvDateFrom.Value = New Date(2023, 1, 14, 0, 0, 0, 0)
        CType(Me.MskTxtInvDateFrom.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).RightToLeft = True
        CType(Me.MskTxtInvDateFrom.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "14/01/2023"
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFrom.Location = New System.Drawing.Point(180, 110)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(66, 30)
        Me.LblFrom.TabIndex = 19
        Me.LblFrom.Text = "من"
        Me.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTo.Location = New System.Drawing.Point(180, 140)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(66, 30)
        Me.LblTo.TabIndex = 21
        Me.LblTo.Text = "إلى"
        Me.LblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Daily
        '
        Me.AcceptButton = Me.BtnFiltering
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 503)
        Me.Controls.Add(Me.GridDaily)
        Me.Controls.Add(Me.PnlOptions)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Daily"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Tag = "Daily"
        Me.Text = "اليومية"
        Me.ThemeName = "Office2010Blue"
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtCustomerVendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropTrxType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDaily.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDaily, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblCustomerVendor As Label
    Friend WithEvents LblType As Label
    Friend WithEvents TxtCustomerVendor As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents GridDaily As Telerik.WinControls.UI.RadGridView
    Friend WithEvents DropTrxType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnOpen As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnRefrech As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents DropStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TimerFrm As Timer
    Friend WithEvents MskTxtInvDateTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents MskTxtInvDateFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents LblFrom As Label
    Friend WithEvents LblTo As Label
End Class

