<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageExcelReports
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
        Dim GridViewSummaryItem4 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem5 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem6 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
        Me.BtnPrintBarcodeFormtec1056 = New Telerik.WinControls.UI.RadMenuItem()
        Me.BtnRefreshBarcodeProp = New Telerik.WinControls.UI.RadButton()
        Me.BtnSaveBarcodes = New Telerik.WinControls.UI.RadButton()
        Me.BtnResetBarcodeProp = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New Telerik.WinControls.UI.RadDropDownButton()
        Me.BtnPrintInvoice = New Telerik.WinControls.UI.RadMenuItem()
        Me.BtnInvoicesReport = New Telerik.WinControls.UI.RadMenuItem()
        Me.BtnRefrech = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.BtnClearGrid = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblInvID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DropReportType = New Telerik.WinControls.UI.RadDropDownList()
        Me.GridFiledsExcelCells = New Telerik.WinControls.UI.RadGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.RadDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefreshBarcodeProp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSaveBarcodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnResetBarcodeProp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClearGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DropReportType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFiledsExcelCells, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFiledsExcelCells.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlOptions
        '
        Me.PnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlOptions.Location = New System.Drawing.Point(553, 3)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(215, 441)
        Me.PnlOptions.TabIndex = 3
        Me.PnlOptions.Tag = ""
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2008!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7992!))
        Me.TableLayoutPanel3.Controls.Add(Me.RadDropDownButton1, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnRefreshBarcodeProp, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnSaveBarcodes, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnResetBarcodeProp, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 225)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(209, 213)
        Me.TableLayoutPanel3.TabIndex = 21
        '
        'RadDropDownButton1
        '
        Me.RadDropDownButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RadDropDownButton1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Up
        Me.RadDropDownButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadDropDownButton1.Image = Global.HEHAccounting.My.Resources.Resources.print
        Me.RadDropDownButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadDropDownButton1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.BtnPrintBarcodeFormtec1056})
        Me.RadDropDownButton1.Location = New System.Drawing.Point(112, 52)
        Me.RadDropDownButton1.Name = "RadDropDownButton1"
        Me.RadDropDownButton1.Size = New System.Drawing.Size(90, 36)
        Me.RadDropDownButton1.TabIndex = 1
        Me.RadDropDownButton1.Text = "طباعة"
        Me.RadDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnPrintBarcodeFormtec1056
        '
        Me.BtnPrintBarcodeFormtec1056.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPrintBarcodeFormtec1056.Image = Nothing
        Me.BtnPrintBarcodeFormtec1056.Name = "BtnPrintBarcodeFormtec1056"
        Me.BtnPrintBarcodeFormtec1056.Text = "Formtec A4 1056"
        Me.BtnPrintBarcodeFormtec1056.UseCompatibleTextRendering = False
        '
        'BtnRefreshBarcodeProp
        '
        Me.BtnRefreshBarcodeProp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRefreshBarcodeProp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefreshBarcodeProp.Image = Global.HEHAccounting.My.Resources.Resources.Sync
        Me.BtnRefreshBarcodeProp.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefreshBarcodeProp.Location = New System.Drawing.Point(8, 3)
        Me.BtnRefreshBarcodeProp.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BtnRefreshBarcodeProp.Name = "BtnRefreshBarcodeProp"
        Me.BtnRefreshBarcodeProp.Size = New System.Drawing.Size(90, 36)
        Me.BtnRefreshBarcodeProp.TabIndex = 3
        Me.BtnRefreshBarcodeProp.Text = "تحديث"
        Me.BtnRefreshBarcodeProp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnSaveBarcodes
        '
        Me.BtnSaveBarcodes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSaveBarcodes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveBarcodes.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSaveBarcodes.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSaveBarcodes.Location = New System.Drawing.Point(8, 52)
        Me.BtnSaveBarcodes.Name = "BtnSaveBarcodes"
        Me.BtnSaveBarcodes.Size = New System.Drawing.Size(90, 36)
        Me.BtnSaveBarcodes.TabIndex = 1
        Me.BtnSaveBarcodes.Tag = "save"
        Me.BtnSaveBarcodes.Text = "حفظ"
        Me.BtnSaveBarcodes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnResetBarcodeProp
        '
        Me.BtnResetBarcodeProp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnResetBarcodeProp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnResetBarcodeProp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResetBarcodeProp.Image = Global.HEHAccounting.My.Resources.Resources.Redo
        Me.BtnResetBarcodeProp.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnResetBarcodeProp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnResetBarcodeProp.Location = New System.Drawing.Point(112, 6)
        Me.BtnResetBarcodeProp.Name = "BtnResetBarcodeProp"
        Me.BtnResetBarcodeProp.Size = New System.Drawing.Size(90, 36)
        Me.BtnResetBarcodeProp.TabIndex = 8
        Me.BtnResetBarcodeProp.Text = "تصفير"
        Me.BtnResetBarcodeProp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2008!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7992!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnPrint, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnRefrech, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnEdit, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnClearGrid, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 132)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(209, 93)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPrint.DropDownDirection = Telerik.WinControls.UI.RadDirection.Up
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.Image = Global.HEHAccounting.My.Resources.Resources.print
        Me.BtnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPrint.Items.AddRange(New Telerik.WinControls.RadItem() {Me.BtnPrintInvoice, Me.BtnInvoicesReport})
        Me.BtnPrint.Location = New System.Drawing.Point(112, 52)
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
        Me.BtnPrintInvoice.UseCompatibleTextRendering = False
        '
        'BtnInvoicesReport
        '
        Me.BtnInvoicesReport.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnInvoicesReport.Name = "BtnInvoicesReport"
        Me.BtnInvoicesReport.Text = "كشف فواتير"
        Me.BtnInvoicesReport.UseCompatibleTextRendering = False
        '
        'BtnRefrech
        '
        Me.BtnRefrech.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRefrech.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefrech.Image = Global.HEHAccounting.My.Resources.Resources.Sync
        Me.BtnRefrech.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrech.Location = New System.Drawing.Point(8, 3)
        Me.BtnRefrech.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BtnRefrech.Name = "BtnRefrech"
        Me.BtnRefrech.Size = New System.Drawing.Size(90, 36)
        Me.BtnRefrech.TabIndex = 3
        Me.BtnRefrech.Text = "تحديث"
        Me.BtnRefrech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRefrech.Visible = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.HEHAccounting.My.Resources.Resources.feedback
        Me.BtnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(8, 52)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(90, 36)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEdit.Visible = False
        '
        'BtnClearGrid
        '
        Me.BtnClearGrid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnClearGrid.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClearGrid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClearGrid.Image = Global.HEHAccounting.My.Resources.Resources.Redo
        Me.BtnClearGrid.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClearGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnClearGrid.Location = New System.Drawing.Point(112, 6)
        Me.BtnClearGrid.Name = "BtnClearGrid"
        Me.BtnClearGrid.Size = New System.Drawing.Size(90, 36)
        Me.BtnClearGrid.TabIndex = 8
        Me.BtnClearGrid.Text = "تصفير"
        Me.BtnClearGrid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvID, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DropReportType, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(209, 129)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'LblInvID
        '
        Me.LblInvID.AutoSize = True
        Me.LblInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvID.Location = New System.Drawing.Point(169, 19)
        Me.LblInvID.Name = "LblInvID"
        Me.LblInvID.Size = New System.Drawing.Size(37, 30)
        Me.LblInvID.TabIndex = 17
        Me.LblInvID.Text = "النوع"
        Me.LblInvID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 19)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "تصميم تقرير"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropReportType
        '
        Me.DropReportType.BackColor = System.Drawing.Color.White
        Me.DropReportType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropReportType.DropDownAnimationEnabled = True
        Me.DropReportType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropReportType.Location = New System.Drawing.Point(3, 22)
        Me.DropReportType.MaxLength = 65535
        Me.DropReportType.Name = "DropReportType"
        Me.DropReportType.Size = New System.Drawing.Size(160, 24)
        Me.DropReportType.TabIndex = 70
        Me.DropReportType.Tag = ""
        Me.DropReportType.ThemeName = "Office2010Blue"
        '
        'GridFiledsExcelCells
        '
        Me.GridFiledsExcelCells.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridFiledsExcelCells.Location = New System.Drawing.Point(3, 105)
        '
        '
        '
        Me.GridFiledsExcelCells.MasterTemplate.BottomPinnedRowsMode = Telerik.WinControls.UI.GridViewBottomPinnedRowsMode.Fixed
        GridViewSummaryItem4.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count
        GridViewSummaryItem4.AggregateExpression = Nothing
        GridViewSummaryItem4.FormatString = "{0}"
        GridViewSummaryItem4.Name = "NotesID"
        GridViewSummaryItem5.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem5.AggregateExpression = Nothing
        GridViewSummaryItem5.FormatString = "{0}"
        GridViewSummaryItem5.Name = "AmountLL"
        GridViewSummaryItem6.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem6.AggregateExpression = Nothing
        GridViewSummaryItem6.FormatString = "{0}"
        GridViewSummaryItem6.Name = "AmountUSD"
        Me.GridFiledsExcelCells.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem4, GridViewSummaryItem5, GridViewSummaryItem6}))
        Me.GridFiledsExcelCells.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.GridFiledsExcelCells.Name = "GridFiledsExcelCells"
        Me.GridFiledsExcelCells.Size = New System.Drawing.Size(538, 333)
        Me.GridFiledsExcelCells.TabIndex = 5
        Me.GridFiledsExcelCells.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.PnlOptions, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 2, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(771, 447)
        Me.TableLayoutPanel4.TabIndex = 17
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.GridFiledsExcelCells, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.1441!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.8559!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(544, 441)
        Me.TableLayoutPanel5.TabIndex = 9
        '
        'ManageExcelReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CancelButton = Me.BtnClearGrid
        Me.ClientSize = New System.Drawing.Size(771, 447)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManageExcelReports"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.Tag = ""
        Me.Text = "تصميم تقرير إكسل"
        Me.ThemeName = "Office2010Blue"
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.RadDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefreshBarcodeProp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSaveBarcodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnResetBarcodeProp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClearGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DropReportType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFiledsExcelCells.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFiledsExcelCells, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents BtnPrintInvoice As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents BtnInvoicesReport As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents BtnRefrech As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnClearGrid As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblInvID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents RadDropDownButton1 As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents BtnPrintBarcodeFormtec1056 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents BtnRefreshBarcodeProp As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSaveBarcodes As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnResetBarcodeProp As Telerik.WinControls.UI.RadButton
    Friend WithEvents DropReportType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents GridFiledsExcelCells As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
End Class

