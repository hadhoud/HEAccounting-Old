<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageBarcodes
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
        Dim Upca1 As Telerik.WinControls.UI.Barcode.UPCA = New Telerik.WinControls.UI.Barcode.UPCA()
        Dim GridViewSummaryItem1 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem2 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem3 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New Telerik.WinControls.UI.RadDropDownButton()
        Me.BtnPrintInvoice = New Telerik.WinControls.UI.RadMenuItem()
        Me.BtnInvoicesReport = New Telerik.WinControls.UI.RadMenuItem()
        Me.BtnRefrech = New Telerik.WinControls.UI.RadButton()
        Me.BtnImportItemsWithoutBarCode = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.BtnClearGrid = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblInvID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomTxtItemName = New HEHAccounting.CustomItemNameTextBoxControl()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
        Me.BtnPrintBarcodeFormtec1056 = New Telerik.WinControls.UI.RadMenuItem()
        Me.BtnRefreshBarcodeProp = New Telerik.WinControls.UI.RadButton()
        Me.BtnSaveBarcodes = New Telerik.WinControls.UI.RadButton()
        Me.BtnResetBarcodeProp = New Telerik.WinControls.UI.RadButton()
        Me.BarcodeItemView = New Telerik.WinControls.UI.Barcode.RadBarcodeView()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtBarCodeStartNumber = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.lblBarcodeStartingNumber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DropBarcodeType = New Telerik.WinControls.UI.RadDropDownList()
        Me.ChkShowItemCode = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkShowCompanyName = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkShowItemPrice = New Telerik.WinControls.UI.RadCheckBox()
        Me.GridItems = New Telerik.WinControls.UI.RadGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnImportItemsWithoutBarCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClearGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.RadDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefreshBarcodeProp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSaveBarcodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnResetBarcodeProp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarcodeItemView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.TxtBarCodeStartNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropBarcodeType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowItemCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowCompanyName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowItemPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridItems.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlOptions
        '
        Me.PnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlOptions.Location = New System.Drawing.Point(605, 3)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(215, 470)
        Me.PnlOptions.TabIndex = 3
        Me.PnlOptions.Tag = ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2008!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7992!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnPrint, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnRefrech, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnImportItemsWithoutBarCode, 0, 0)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(209, 135)
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
        Me.BtnPrint.Location = New System.Drawing.Point(112, 94)
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
        Me.BtnRefrech.Location = New System.Drawing.Point(8, 45)
        Me.BtnRefrech.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BtnRefrech.Name = "BtnRefrech"
        Me.BtnRefrech.Size = New System.Drawing.Size(90, 36)
        Me.BtnRefrech.TabIndex = 3
        Me.BtnRefrech.Text = "تحديث"
        Me.BtnRefrech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnRefrech.Visible = False
        '
        'BtnImportItemsWithoutBarCode
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.BtnImportItemsWithoutBarCode, 2)
        Me.BtnImportItemsWithoutBarCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnImportItemsWithoutBarCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImportItemsWithoutBarCode.Image = Global.HEHAccounting.My.Resources.Resources.import__1_
        Me.BtnImportItemsWithoutBarCode.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnImportItemsWithoutBarCode.Location = New System.Drawing.Point(3, 3)
        Me.BtnImportItemsWithoutBarCode.Name = "BtnImportItemsWithoutBarCode"
        Me.BtnImportItemsWithoutBarCode.Size = New System.Drawing.Size(203, 36)
        Me.BtnImportItemsWithoutBarCode.TabIndex = 4
        Me.BtnImportItemsWithoutBarCode.Text = "إستيراد أصناف بدون باركود"
        Me.BtnImportItemsWithoutBarCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.HEHAccounting.My.Resources.Resources.feedback
        Me.BtnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(8, 94)
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
        Me.BtnClearGrid.Location = New System.Drawing.Point(112, 48)
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
        Me.TableLayoutPanel1.Controls.Add(Me.CustomTxtItemName, 1, 1)
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
        Me.LblInvID.Location = New System.Drawing.Point(161, 19)
        Me.LblInvID.Name = "LblInvID"
        Me.LblInvID.Size = New System.Drawing.Size(45, 30)
        Me.LblInvID.TabIndex = 17
        Me.LblInvID.Text = "الصنف"
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
        Me.Label1.Text = "الأصناف"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomTxtItemName
        '
        Me.CustomTxtItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomTxtItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomTxtItemName.Location = New System.Drawing.Point(3, 22)
        Me.CustomTxtItemName.Name = "CustomTxtItemName"
        Me.CustomTxtItemName.Size = New System.Drawing.Size(152, 24)
        Me.CustomTxtItemName.TabIndex = 18
        Me.CustomTxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.RadPanel1.Controls.Add(Me.TableLayoutPanel3)
        Me.RadPanel1.Controls.Add(Me.BarcodeItemView)
        Me.RadPanel1.Controls.Add(Me.TableLayoutPanel5)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.Location = New System.Drawing.Point(348, 3)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Padding = New System.Windows.Forms.Padding(3)
        Me.RadPanel1.Size = New System.Drawing.Size(251, 470)
        Me.RadPanel1.TabIndex = 4
        Me.RadPanel1.Tag = ""
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
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 171)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(245, 93)
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
        Me.RadDropDownButton1.Location = New System.Drawing.Point(139, 52)
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
        Me.BtnRefreshBarcodeProp.Location = New System.Drawing.Point(17, 3)
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
        Me.BtnSaveBarcodes.Location = New System.Drawing.Point(17, 52)
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
        Me.BtnResetBarcodeProp.Location = New System.Drawing.Point(139, 6)
        Me.BtnResetBarcodeProp.Name = "BtnResetBarcodeProp"
        Me.BtnResetBarcodeProp.Size = New System.Drawing.Size(90, 36)
        Me.BtnResetBarcodeProp.TabIndex = 8
        Me.BtnResetBarcodeProp.Text = "تصفير"
        Me.BtnResetBarcodeProp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BarcodeItemView
        '
        Me.BarcodeItemView.Location = New System.Drawing.Point(20, 320)
        Me.BarcodeItemView.Name = "BarcodeItemView"
        Me.BarcodeItemView.Size = New System.Drawing.Size(221, 67)
        Upca1.AutoChecksum = False
        Upca1.CodeTextSpacing = 0R
        Upca1.LineAlign = System.Drawing.StringAlignment.Near
        Upca1.ShowText = False
        Upca1.SizingMode = Telerik.WinControls.UI.Barcode.SizingMode.Snap
        Upca1.TextAlign = System.Drawing.StringAlignment.Near
        Me.BarcodeItemView.Symbology = Upca1
        Me.BarcodeItemView.TabIndex = 20
        Me.BarcodeItemView.TabStop = False
        Me.BarcodeItemView.Text = "590123412345"
        Me.BarcodeItemView.Value = "05901234123"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.TxtBarCodeStartNumber, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.lblBarcodeStartingNumber, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.DropBarcodeType, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.ChkShowItemCode, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.ChkShowCompanyName, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.ChkShowItemPrice, 0, 6)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 8
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(245, 168)
        Me.TableLayoutPanel5.TabIndex = 19
        '
        'TxtBarCodeStartNumber
        '
        Me.TxtBarCodeStartNumber.BackColor = System.Drawing.Color.White
        Me.TxtBarCodeStartNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtBarCodeStartNumber.Enabled = False
        Me.TxtBarCodeStartNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarCodeStartNumber.Location = New System.Drawing.Point(3, 27)
        Me.TxtBarCodeStartNumber.Mask = "G"
        Me.TxtBarCodeStartNumber.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtBarCodeStartNumber.Name = "TxtBarCodeStartNumber"
        Me.TxtBarCodeStartNumber.Size = New System.Drawing.Size(136, 24)
        Me.TxtBarCodeStartNumber.TabIndex = 76
        Me.TxtBarCodeStartNumber.TabStop = False
        Me.TxtBarCodeStartNumber.Text = "0"
        Me.TxtBarCodeStartNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBarCodeStartNumber.ThemeName = "Office2010Blue"
        '
        'lblBarcodeStartingNumber
        '
        Me.lblBarcodeStartingNumber.AutoSize = True
        Me.lblBarcodeStartingNumber.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBarcodeStartingNumber.Location = New System.Drawing.Point(145, 24)
        Me.lblBarcodeStartingNumber.Name = "lblBarcodeStartingNumber"
        Me.lblBarcodeStartingNumber.Size = New System.Drawing.Size(97, 30)
        Me.lblBarcodeStartingNumber.TabIndex = 75
        Me.lblBarcodeStartingNumber.Text = "رقم ترميز باركود"
        Me.lblBarcodeStartingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel5.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 19)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "خصائض الباركود"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(145, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 30)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "نوع الباركود"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropBarcodeType
        '
        Me.DropBarcodeType.BackColor = System.Drawing.Color.White
        Me.DropBarcodeType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropBarcodeType.DropDownAnimationEnabled = True
        Me.DropBarcodeType.Enabled = False
        Me.DropBarcodeType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropBarcodeType.Location = New System.Drawing.Point(3, 57)
        Me.DropBarcodeType.MaxLength = 65535
        Me.DropBarcodeType.Name = "DropBarcodeType"
        Me.DropBarcodeType.Size = New System.Drawing.Size(136, 24)
        Me.DropBarcodeType.TabIndex = 70
        Me.DropBarcodeType.Tag = ""
        Me.DropBarcodeType.ThemeName = "Office2010Blue"
        '
        'ChkShowItemCode
        '
        Me.TableLayoutPanel5.SetColumnSpan(Me.ChkShowItemCode, 2)
        Me.ChkShowItemCode.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChkShowItemCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChkShowItemCode.Location = New System.Drawing.Point(122, 115)
        Me.ChkShowItemCode.Name = "ChkShowItemCode"
        Me.ChkShowItemCode.Size = New System.Drawing.Size(120, 22)
        Me.ChkShowItemCode.TabIndex = 74
        Me.ChkShowItemCode.Text = "عرض كود الصنف"
        '
        'ChkShowCompanyName
        '
        Me.TableLayoutPanel5.SetColumnSpan(Me.ChkShowCompanyName, 2)
        Me.ChkShowCompanyName.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChkShowCompanyName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChkShowCompanyName.Location = New System.Drawing.Point(129, 87)
        Me.ChkShowCompanyName.Name = "ChkShowCompanyName"
        Me.ChkShowCompanyName.Size = New System.Drawing.Size(113, 22)
        Me.ChkShowCompanyName.TabIndex = 72
        Me.ChkShowCompanyName.Text = "عرض إسم المحل"
        '
        'ChkShowItemPrice
        '
        Me.TableLayoutPanel5.SetColumnSpan(Me.ChkShowItemPrice, 2)
        Me.ChkShowItemPrice.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChkShowItemPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChkShowItemPrice.Location = New System.Drawing.Point(124, 143)
        Me.ChkShowItemPrice.Name = "ChkShowItemPrice"
        Me.ChkShowItemPrice.Size = New System.Drawing.Size(118, 22)
        Me.ChkShowItemPrice.TabIndex = 73
        Me.ChkShowItemPrice.Text = "عرض سعر المبيع"
        '
        'GridItems
        '
        Me.GridItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItems.Location = New System.Drawing.Point(3, 3)
        '
        '
        '
        Me.GridItems.MasterTemplate.BottomPinnedRowsMode = Telerik.WinControls.UI.GridViewBottomPinnedRowsMode.Fixed
        GridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count
        GridViewSummaryItem1.AggregateExpression = Nothing
        GridViewSummaryItem1.FormatString = "{0}"
        GridViewSummaryItem1.Name = "NotesID"
        GridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem2.AggregateExpression = Nothing
        GridViewSummaryItem2.FormatString = "{0}"
        GridViewSummaryItem2.Name = "AmountLL"
        GridViewSummaryItem3.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem3.AggregateExpression = Nothing
        GridViewSummaryItem3.FormatString = "{0}"
        GridViewSummaryItem3.Name = "AmountUSD"
        Me.GridItems.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem1, GridViewSummaryItem2, GridViewSummaryItem3}))
        Me.GridItems.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridItems.Name = "GridItems"
        Me.GridItems.Size = New System.Drawing.Size(339, 470)
        Me.GridItems.TabIndex = 5
        Me.GridItems.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.GridItems, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.RadPanel1, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PnlOptions, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(823, 476)
        Me.TableLayoutPanel4.TabIndex = 17
        '
        'ManageBarcodes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CancelButton = Me.BtnClearGrid
        Me.ClientSize = New System.Drawing.Size(823, 476)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageBarcodes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.Tag = "FrmManageBarCodes"
        Me.Text = "تصميم الباركود"
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnImportItemsWithoutBarCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClearGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.RadDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefreshBarcodeProp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSaveBarcodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnResetBarcodeProp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarcodeItemView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.TxtBarCodeStartNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropBarcodeType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowItemCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowCompanyName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowItemPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridItems.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
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
    Friend WithEvents BtnImportItemsWithoutBarCode As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnClearGrid As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblInvID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomTxtItemName As CustomItemNameTextBoxControl
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents RadDropDownButton1 As Telerik.WinControls.UI.RadDropDownButton
    Friend WithEvents BtnPrintBarcodeFormtec1056 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents BtnRefreshBarcodeProp As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSaveBarcodes As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnResetBarcodeProp As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Private WithEvents TxtBarCodeStartNumber As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents lblBarcodeStartingNumber As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DropBarcodeType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ChkShowItemCode As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkShowCompanyName As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkShowItemPrice As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents GridItems As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BarcodeItemView As Telerik.WinControls.UI.Barcode.RadBarcodeView
End Class

