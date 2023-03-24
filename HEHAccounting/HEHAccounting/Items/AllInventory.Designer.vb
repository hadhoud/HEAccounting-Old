<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllInventory))
        Dim GridViewSummaryItem10 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem11 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem12 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MskTxtInvDateFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.LblInvID = New System.Windows.Forms.Label()
        Me.TxtInvID = New Telerik.WinControls.UI.RadTextBox()
        Me.MskTxtInvDateTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.BtnNew = New Telerik.WinControls.UI.RadButton()
        Me.BtnPrint = New Telerik.WinControls.UI.RadDropDownButton()
        Me.BtnPrintInvoice = New Telerik.WinControls.UI.RadMenuItem()
        Me.BtnInvoicesReport = New Telerik.WinControls.UI.RadMenuItem()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.GridInventory = New Telerik.WinControls.UI.RadGridView()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.BtnRefrech = New Telerik.WinControls.UI.RadButton()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInventory.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlOptions
        '
        Me.PnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlOptions.Location = New System.Drawing.Point(0, 0)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(255, 467)
        Me.PnlOptions.TabIndex = 3
        Me.PnlOptions.Tag = ""
        Me.PnlOptions.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtInvDateFrom, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvID, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtInvID, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtInvDateTo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTo, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblFrom, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 158)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 264)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'MskTxtInvDateFrom
        '
        Me.MskTxtInvDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.MskTxtInvDateFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MskTxtInvDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MskTxtInvDateFrom.Location = New System.Drawing.Point(3, 53)
        Me.MskTxtInvDateFrom.Name = "MskTxtInvDateFrom"
        Me.MskTxtInvDateFrom.ShowCheckBox = True
        Me.MskTxtInvDateFrom.Size = New System.Drawing.Size(202, 24)
        Me.MskTxtInvDateFrom.TabIndex = 68
        Me.MskTxtInvDateFrom.TabStop = False
        Me.MskTxtInvDateFrom.Text = "01/11/2023"
        Me.MskTxtInvDateFrom.ThemeName = "Office2010Blue"
        Me.MskTxtInvDateFrom.Value = New Date(2023, 11, 1, 0, 0, 0, 0)
        CType(Me.MskTxtInvDateFrom.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).RightToLeft = True
        CType(Me.MskTxtInvDateFrom.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "01/11/2023"
        '
        'LblInvID
        '
        Me.LblInvID.AutoSize = True
        Me.LblInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvID.Location = New System.Drawing.Point(211, 20)
        Me.LblInvID.Name = "LblInvID"
        Me.LblInvID.Size = New System.Drawing.Size(35, 30)
        Me.LblInvID.TabIndex = 17
        Me.LblInvID.Text = "الرقم"
        Me.LblInvID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInvID
        '
        Me.TxtInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvID.Location = New System.Drawing.Point(3, 23)
        Me.TxtInvID.Name = "TxtInvID"
        Me.TxtInvID.ShortcutsEnabled = False
        Me.TxtInvID.ShowClearButton = True
        Me.TxtInvID.Size = New System.Drawing.Size(202, 24)
        Me.TxtInvID.TabIndex = 4
        Me.TxtInvID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInvID.ThemeName = "Office2010Blue"
        '
        'MskTxtInvDateTo
        '
        Me.MskTxtInvDateTo.CustomFormat = "dd/MM/yyyy"
        Me.MskTxtInvDateTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MskTxtInvDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MskTxtInvDateTo.Location = New System.Drawing.Point(3, 83)
        Me.MskTxtInvDateTo.Name = "MskTxtInvDateTo"
        Me.MskTxtInvDateTo.ShowCheckBox = True
        Me.MskTxtInvDateTo.Size = New System.Drawing.Size(202, 24)
        Me.MskTxtInvDateTo.TabIndex = 67
        Me.MskTxtInvDateTo.TabStop = False
        Me.MskTxtInvDateTo.Text = "11/01/2023"
        Me.MskTxtInvDateTo.ThemeName = "Office2010Blue"
        Me.MskTxtInvDateTo.Value = New Date(2023, 1, 11, 0, 0, 0, 0)
        CType(Me.MskTxtInvDateTo.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).RightToLeft = True
        CType(Me.MskTxtInvDateTo.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "11/01/2023"
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTo.Location = New System.Drawing.Point(211, 80)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(35, 30)
        Me.LblTo.TabIndex = 20
        Me.LblTo.Text = "إلى"
        Me.LblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFrom.Location = New System.Drawing.Point(211, 50)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(35, 30)
        Me.LblFrom.TabIndex = 18
        Me.LblFrom.Text = "من"
        Me.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnEdit, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnNew, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnPrint, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnDelete, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnRefrech, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(249, 155)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(142, 68)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(90, 36)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.HEHAccounting.My.Resources.Resources.feedback
        Me.BtnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(18, 23)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(90, 36)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEdit.Visible = False
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Image = Global.HEHAccounting.My.Resources.Resources.Creates
        Me.BtnNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(142, 23)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(90, 36)
        Me.BtnNew.TabIndex = 0
        Me.BtnNew.Text = "جديد"
        Me.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPrint.DropDownDirection = Telerik.WinControls.UI.RadDirection.Up
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.Image = Global.HEHAccounting.My.Resources.Resources.print
        Me.BtnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPrint.Items.AddRange(New Telerik.WinControls.RadItem() {Me.BtnPrintInvoice, Me.BtnInvoicesReport})
        Me.BtnPrint.Location = New System.Drawing.Point(142, 114)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(90, 36)
        Me.BtnPrint.TabIndex = 1
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrint.Visible = False
        '
        'BtnPrintInvoice
        '
        Me.BtnPrintInvoice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPrintInvoice.Image = Nothing
        Me.BtnPrintInvoice.Name = "BtnPrintInvoice"
        Me.BtnPrintInvoice.Text = "فاتورة"
        '
        'BtnInvoicesReport
        '
        Me.BtnInvoicesReport.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnInvoicesReport.Name = "BtnInvoicesReport"
        Me.BtnInvoicesReport.Text = "كشف فواتير"
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 422)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(249, 42)
        Me.TableLayoutPanel3.TabIndex = 16
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
        Me.BtnFiltering.TabIndex = 16
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
        'GridInventory
        '
        Me.GridInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridInventory.Location = New System.Drawing.Point(255, 0)
        '
        '
        '
        Me.GridInventory.MasterTemplate.BottomPinnedRowsMode = Telerik.WinControls.UI.GridViewBottomPinnedRowsMode.Fixed
        GridViewSummaryItem10.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count
        GridViewSummaryItem10.AggregateExpression = Nothing
        GridViewSummaryItem10.FormatString = "{0}"
        GridViewSummaryItem10.Name = "InventoryID"
        GridViewSummaryItem11.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem11.AggregateExpression = Nothing
        GridViewSummaryItem11.FormatString = "{0}"
        GridViewSummaryItem11.Name = "TotalPurchasingPriceLL"
        GridViewSummaryItem12.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem12.AggregateExpression = Nothing
        GridViewSummaryItem12.FormatString = "{0}"
        GridViewSummaryItem12.Name = "TotalPurchasingPriceUSD"
        Me.GridInventory.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem10, GridViewSummaryItem11, GridViewSummaryItem12}))
        Me.GridInventory.MasterTemplate.ViewDefinition = TableViewDefinition4
        Me.GridInventory.Name = "GridInventory"
        Me.GridInventory.Size = New System.Drawing.Size(278, 467)
        Me.GridInventory.TabIndex = 4
        Me.GridInventory.ThemeName = "Office2010Blue"
        '
        'BtnRefrech
        '
        Me.BtnRefrech.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRefrech.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefrech.Image = Global.HEHAccounting.My.Resources.Resources.Sync
        Me.BtnRefrech.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrech.Location = New System.Drawing.Point(18, 65)
        Me.BtnRefrech.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BtnRefrech.Name = "BtnRefrech"
        Me.BtnRefrech.Size = New System.Drawing.Size(90, 36)
        Me.BtnRefrech.TabIndex = 3
        Me.BtnRefrech.Text = "تحديث"
        Me.BtnRefrech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'AllInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CancelButton = Me.BtnReset
        Me.ClientSize = New System.Drawing.Size(533, 467)
        Me.Controls.Add(Me.GridInventory)
        Me.Controls.Add(Me.PnlOptions)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AllInventory"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.Tag = "FrmAllInventory"
        Me.Text = "الجردات"
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInventory.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblFrom As Label
    Friend WithEvents LblInvID As Label
    Friend WithEvents TxtInvID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblTo As Label
    Friend WithEvents GridInventory As Telerik.WinControls.UI.RadGridView
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents BtnPrintInvoice As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents BtnInvoicesReport As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents BtnNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents MskTxtInvDateTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents MskTxtInvDateFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnRefrech As Telerik.WinControls.UI.RadButton
End Class

