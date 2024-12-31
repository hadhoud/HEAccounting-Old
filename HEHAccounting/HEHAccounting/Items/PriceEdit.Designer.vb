<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PriceEdit
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
        Dim GridViewSummaryItem1 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.TreeGroups = New Telerik.WinControls.UI.RadTreeView()
        Me.TxtGroupSearch = New Telerik.WinControls.UI.RadTextBox()
        Me.GridItemsGroups = New Telerik.WinControls.UI.RadGridView()
        Me.tblItemsToAdd = New System.Windows.Forms.TableLayoutPanel()
        Me.CustomTxtItemName = New HEHAccounting.CustomItemNameTextBoxControl()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.LblItemID = New System.Windows.Forms.Label()
        Me.TxtItemid = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.LblBarcode = New System.Windows.Forms.Label()
        Me.TxtItemBarcode = New Telerik.WinControls.UI.RadTextBox()
        Me.btnAdd = New Telerik.WinControls.UI.RadButton()
        Me.RadContextMenuManager1 = New Telerik.WinControls.UI.RadContextMenuManager()
        Me.ContextGrid = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.chkEditPurchasingPrice = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkEditSellingPrice = New Telerik.WinControls.UI.RadCheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.radioEditPercentage = New Telerik.WinControls.UI.RadRadioButton()
        Me.radioEditAmount = New Telerik.WinControls.UI.RadRadioButton()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MskTextAmountPercent = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.BtnEditPrice = New Telerik.WinControls.UI.RadButton()
        Me.tblContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlRightGroups = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlLeft = New Telerik.WinControls.UI.RadPanel()
        Me.pnlLeftHeader = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlItemsToAdd = New System.Windows.Forms.Panel()
        Me.pnlHeaderPrices = New System.Windows.Forms.Panel()
        Me.tblHeaderPrices = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCalculate = New Telerik.WinControls.UI.RadButton()
        CType(Me.TreeGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtGroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridItemsGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridItemsGroups.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblItemsToAdd.SuspendLayout()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEditPurchasingPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEditSellingPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.radioEditPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioEditAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.MskTextAmountPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEditPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblContainer.SuspendLayout()
        CType(Me.pnlRightGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRightGroups.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeft.SuspendLayout()
        CType(Me.pnlLeftHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeftHeader.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.pnlItemsToAdd.SuspendLayout()
        Me.pnlHeaderPrices.SuspendLayout()
        Me.tblHeaderPrices.SuspendLayout()
        CType(Me.btnCalculate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeGroups
        '
        Me.TreeGroups.AllowAdd = True
        Me.TreeGroups.AllowDragDrop = True
        Me.TreeGroups.AllowDrop = True
        Me.TreeGroups.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeGroups.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeGroups.DropHintColor = System.Drawing.Color.Yellow
        Me.TreeGroups.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeGroups.ForeColor = System.Drawing.Color.Black
        Me.TreeGroups.ItemHeight = 30
        Me.TreeGroups.LineColor = System.Drawing.Color.DarkOrange
        Me.TreeGroups.Location = New System.Drawing.Point(3, 33)
        Me.TreeGroups.Name = "TreeGroups"
        Me.TreeGroups.ShowDragHint = False
        Me.TreeGroups.ShowDropHint = False
        Me.TreeGroups.ShowExpandCollapse = False
        Me.TreeGroups.ShowLines = True
        Me.TreeGroups.Size = New System.Drawing.Size(221, 418)
        Me.TreeGroups.SpacingBetweenNodes = 4
        Me.TreeGroups.TabIndex = 0
        Me.TreeGroups.ThemeName = "Office2010Blue"
        '
        'TxtGroupSearch
        '
        Me.TxtGroupSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtGroupSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGroupSearch.Location = New System.Drawing.Point(3, 3)
        Me.TxtGroupSearch.Name = "TxtGroupSearch"
        Me.TxtGroupSearch.Size = New System.Drawing.Size(221, 24)
        Me.TxtGroupSearch.TabIndex = 2
        Me.TxtGroupSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GridItemsGroups
        '
        Me.GridItemsGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItemsGroups.Location = New System.Drawing.Point(0, 142)
        '
        '
        '
        GridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count
        GridViewSummaryItem1.AggregateExpression = Nothing
        GridViewSummaryItem1.FormatString = "{0}"
        GridViewSummaryItem1.Name = "Item_id"
        Me.GridItemsGroups.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem1}))
        Me.GridItemsGroups.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridItemsGroups.Name = "GridItemsGroups"
        Me.GridItemsGroups.Size = New System.Drawing.Size(742, 312)
        Me.GridItemsGroups.TabIndex = 1
        '
        'tblItemsToAdd
        '
        Me.tblItemsToAdd.ColumnCount = 6
        Me.tblItemsToAdd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblItemsToAdd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblItemsToAdd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblItemsToAdd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tblItemsToAdd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblItemsToAdd.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.tblItemsToAdd.Controls.Add(Me.CustomTxtItemName, 2, 2)
        Me.tblItemsToAdd.Controls.Add(Me.LblItemName, 2, 1)
        Me.tblItemsToAdd.Controls.Add(Me.LblItemID, 1, 1)
        Me.tblItemsToAdd.Controls.Add(Me.TxtItemid, 0, 2)
        Me.tblItemsToAdd.Controls.Add(Me.LblBarcode, 0, 1)
        Me.tblItemsToAdd.Controls.Add(Me.TxtItemBarcode, 0, 2)
        Me.tblItemsToAdd.Controls.Add(Me.btnAdd, 4, 1)
        Me.tblItemsToAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblItemsToAdd.Location = New System.Drawing.Point(0, 0)
        Me.tblItemsToAdd.Name = "tblItemsToAdd"
        Me.tblItemsToAdd.RowCount = 3
        Me.tblItemsToAdd.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblItemsToAdd.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblItemsToAdd.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblItemsToAdd.Size = New System.Drawing.Size(734, 63)
        Me.tblItemsToAdd.TabIndex = 4
        '
        'CustomTxtItemName
        '
        Me.CustomTxtItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CustomTxtItemName.Location = New System.Drawing.Point(278, 22)
        Me.CustomTxtItemName.Name = "CustomTxtItemName"
        Me.CustomTxtItemName.Size = New System.Drawing.Size(153, 22)
        Me.CustomTxtItemName.TabIndex = 0
        Me.CustomTxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblItemName
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemName.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemName.Location = New System.Drawing.Point(278, 0)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(153, 19)
        Me.LblItemName.TabIndex = 76
        Me.LblItemName.Text = "إسم الصنف"
        Me.LblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblItemID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemID.Location = New System.Drawing.Point(437, 0)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(144, 19)
        Me.LblItemID.TabIndex = 75
        Me.LblItemID.Text = "كود الصنف"
        Me.LblItemID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtItemid
        '
        Me.TxtItemid.AcceptsTab = True
        Me.TxtItemid.BackColor = System.Drawing.Color.White
        Me.TxtItemid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemid.HideSelection = False
        Me.TxtItemid.Location = New System.Drawing.Point(437, 22)
        Me.TxtItemid.Mask = "G"
        Me.TxtItemid.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtItemid.Name = "TxtItemid"
        Me.TxtItemid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtItemid.Size = New System.Drawing.Size(144, 24)
        Me.TxtItemid.TabIndex = 74
        Me.TxtItemid.TabStop = False
        Me.TxtItemid.Text = "0"
        Me.TxtItemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemid.ThemeName = "Office2010Blue"
        '
        'LblBarcode
        '
        Me.LblBarcode.AutoSize = True
        Me.LblBarcode.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarcode.Location = New System.Drawing.Point(587, 0)
        Me.LblBarcode.Name = "LblBarcode"
        Me.LblBarcode.Size = New System.Drawing.Size(144, 19)
        Me.LblBarcode.TabIndex = 68
        Me.LblBarcode.Text = "الباركود"
        Me.LblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtItemBarcode
        '
        Me.TxtItemBarcode.AcceptsTab = True
        Me.TxtItemBarcode.BackColor = System.Drawing.Color.White
        Me.TxtItemBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemBarcode.HideSelection = False
        Me.TxtItemBarcode.Location = New System.Drawing.Point(587, 22)
        Me.TxtItemBarcode.MaxLength = 65535
        Me.TxtItemBarcode.Name = "TxtItemBarcode"
        Me.TxtItemBarcode.ShowClearButton = True
        Me.TxtItemBarcode.Size = New System.Drawing.Size(144, 24)
        Me.TxtItemBarcode.TabIndex = 67
        Me.TxtItemBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemBarcode.ThemeName = "Office2010Blue"
        Me.TxtItemBarcode.WordWrap = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = Global.HEHAccounting.My.Resources.Resources.Create
        Me.btnAdd.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.Location = New System.Drawing.Point(119, 13)
        Me.btnAdd.Name = "btnAdd"
        Me.tblItemsToAdd.SetRowSpan(Me.btnAdd, 2)
        Me.btnAdd.Size = New System.Drawing.Size(91, 37)
        Me.btnAdd.TabIndex = 78
        Me.btnAdd.Tag = "Save"
        Me.btnAdd.Text = "إضافة"
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'chkEditPurchasingPrice
        '
        Me.chkEditPurchasingPrice.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEditPurchasingPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEditPurchasingPrice.Location = New System.Drawing.Point(62, 3)
        Me.chkEditPurchasingPrice.Name = "chkEditPurchasingPrice"
        Me.chkEditPurchasingPrice.Size = New System.Drawing.Size(85, 22)
        Me.chkEditPurchasingPrice.TabIndex = 4
        Me.chkEditPurchasingPrice.Text = "سعر الشراء"
        Me.chkEditPurchasingPrice.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'chkEditSellingPrice
        '
        Me.chkEditSellingPrice.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEditSellingPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEditSellingPrice.Location = New System.Drawing.Point(67, 31)
        Me.chkEditSellingPrice.Name = "chkEditSellingPrice"
        Me.chkEditSellingPrice.Size = New System.Drawing.Size(80, 22)
        Me.chkEditSellingPrice.TabIndex = 5
        Me.chkEditSellingPrice.Text = "سعر المبيع"
        Me.chkEditSellingPrice.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.chkEditPurchasingPrice)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkEditSellingPrice)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(581, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(150, 57)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'radioEditPercentage
        '
        Me.radioEditPercentage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.radioEditPercentage.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.radioEditPercentage.Location = New System.Drawing.Point(6, 3)
        Me.radioEditPercentage.Name = "radioEditPercentage"
        Me.radioEditPercentage.Size = New System.Drawing.Size(130, 22)
        Me.radioEditPercentage.TabIndex = 7
        Me.radioEditPercentage.Text = "حسب النسبة المئوية"
        Me.radioEditPercentage.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'radioEditAmount
        '
        Me.radioEditAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.radioEditAmount.Location = New System.Drawing.Point(50, 31)
        Me.radioEditAmount.Name = "radioEditAmount"
        Me.radioEditAmount.Size = New System.Drawing.Size(86, 22)
        Me.radioEditAmount.TabIndex = 8
        Me.radioEditAmount.TabStop = False
        Me.radioEditAmount.Text = "حسب القيمة"
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.radioEditPercentage)
        Me.FlowLayoutPanel2.Controls.Add(Me.radioEditAmount)
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(436, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(139, 57)
        Me.FlowLayoutPanel2.TabIndex = 9
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel3.Controls.Add(Me.MskTextAmountPercent)
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(275, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(155, 57)
        Me.FlowLayoutPanel3.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "القيمة / النسبة"
        '
        'MskTextAmountPercent
        '
        Me.MskTextAmountPercent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTextAmountPercent.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MskTextAmountPercent.Location = New System.Drawing.Point(3, 22)
        Me.MskTextAmountPercent.Mask = "F3"
        Me.MskTextAmountPercent.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.MskTextAmountPercent.Name = "MskTextAmountPercent"
        Me.MskTextAmountPercent.Size = New System.Drawing.Size(149, 24)
        Me.MskTextAmountPercent.TabIndex = 10
        Me.MskTextAmountPercent.TabStop = False
        Me.MskTextAmountPercent.Text = "0.000"
        '
        'BtnEditPrice
        '
        Me.BtnEditPrice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnEditPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditPrice.Image = Global.HEHAccounting.My.Resources.Resources.cost
        Me.BtnEditPrice.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnEditPrice.Location = New System.Drawing.Point(84, 13)
        Me.BtnEditPrice.Name = "BtnEditPrice"
        Me.BtnEditPrice.Size = New System.Drawing.Size(83, 37)
        Me.BtnEditPrice.TabIndex = 10
        Me.BtnEditPrice.Tag = "Save"
        Me.BtnEditPrice.Text = "تعديل"
        Me.BtnEditPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'tblContainer
        '
        Me.tblContainer.ColumnCount = 2
        Me.tblContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblContainer.Controls.Add(Me.pnlRightGroups, 0, 0)
        Me.tblContainer.Controls.Add(Me.pnlLeft, 1, 0)
        Me.tblContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblContainer.Location = New System.Drawing.Point(0, 0)
        Me.tblContainer.Name = "tblContainer"
        Me.tblContainer.RowCount = 1
        Me.tblContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblContainer.Size = New System.Drawing.Size(981, 460)
        Me.tblContainer.TabIndex = 2
        '
        'pnlRightGroups
        '
        Me.pnlRightGroups.Controls.Add(Me.TableLayoutPanel4)
        Me.pnlRightGroups.Location = New System.Drawing.Point(751, 3)
        Me.pnlRightGroups.Name = "pnlRightGroups"
        Me.pnlRightGroups.Size = New System.Drawing.Size(227, 454)
        Me.pnlRightGroups.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TxtGroupSearch, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.TreeGroups, 0, 2)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(227, 454)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.GridItemsGroups)
        Me.pnlLeft.Controls.Add(Me.pnlLeftHeader)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLeft.Location = New System.Drawing.Point(3, 3)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(742, 454)
        Me.pnlLeft.TabIndex = 4
        '
        'pnlLeftHeader
        '
        Me.pnlLeftHeader.Controls.Add(Me.TableLayoutPanel5)
        Me.pnlLeftHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLeftHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeftHeader.Name = "pnlLeftHeader"
        Me.pnlLeftHeader.Size = New System.Drawing.Size(742, 142)
        Me.pnlLeftHeader.TabIndex = 0
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.pnlItemsToAdd, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.pnlHeaderPrices, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(742, 142)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'pnlItemsToAdd
        '
        Me.pnlItemsToAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItemsToAdd.Controls.Add(Me.tblItemsToAdd)
        Me.pnlItemsToAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlItemsToAdd.Location = New System.Drawing.Point(3, 74)
        Me.pnlItemsToAdd.Name = "pnlItemsToAdd"
        Me.pnlItemsToAdd.Size = New System.Drawing.Size(736, 65)
        Me.pnlItemsToAdd.TabIndex = 1
        '
        'pnlHeaderPrices
        '
        Me.pnlHeaderPrices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHeaderPrices.Controls.Add(Me.tblHeaderPrices)
        Me.pnlHeaderPrices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHeaderPrices.Location = New System.Drawing.Point(3, 3)
        Me.pnlHeaderPrices.Name = "pnlHeaderPrices"
        Me.pnlHeaderPrices.Size = New System.Drawing.Size(736, 65)
        Me.pnlHeaderPrices.TabIndex = 0
        '
        'tblHeaderPrices
        '
        Me.tblHeaderPrices.ColumnCount = 6
        Me.tblHeaderPrices.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblHeaderPrices.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblHeaderPrices.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblHeaderPrices.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.tblHeaderPrices.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblHeaderPrices.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblHeaderPrices.Controls.Add(Me.BtnEditPrice, 5, 0)
        Me.tblHeaderPrices.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.tblHeaderPrices.Controls.Add(Me.FlowLayoutPanel3, 2, 0)
        Me.tblHeaderPrices.Controls.Add(Me.FlowLayoutPanel2, 1, 0)
        Me.tblHeaderPrices.Controls.Add(Me.btnCalculate, 4, 0)
        Me.tblHeaderPrices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblHeaderPrices.Location = New System.Drawing.Point(0, 0)
        Me.tblHeaderPrices.Name = "tblHeaderPrices"
        Me.tblHeaderPrices.RowCount = 1
        Me.tblHeaderPrices.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeaderPrices.Size = New System.Drawing.Size(734, 63)
        Me.tblHeaderPrices.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCalculate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Image = Global.HEHAccounting.My.Resources.Resources.cost
        Me.btnCalculate.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCalculate.Location = New System.Drawing.Point(173, 13)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(83, 37)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Tag = ""
        Me.btnCalculate.Text = "إحتساب"
        Me.btnCalculate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'PriceEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 460)
        Me.Controls.Add(Me.tblContainer)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PriceEdit"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تعديل الأسعار"
        Me.ThemeName = "Office2010Blue"
        CType(Me.TreeGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtGroupSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridItemsGroups.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridItemsGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblItemsToAdd.ResumeLayout(False)
        Me.tblItemsToAdd.PerformLayout()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEditPurchasingPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEditSellingPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.radioEditPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioEditAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        CType(Me.MskTextAmountPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEditPrice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblContainer.ResumeLayout(False)
        CType(Me.pnlRightGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRightGroups.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeft.ResumeLayout(False)
        CType(Me.pnlLeftHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeftHeader.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.pnlItemsToAdd.ResumeLayout(False)
        Me.pnlHeaderPrices.ResumeLayout(False)
        Me.tblHeaderPrices.ResumeLayout(False)
        CType(Me.btnCalculate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeGroups As Telerik.WinControls.UI.RadTreeView
    Friend WithEvents GridItemsGroups As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadContextMenuManager1 As Telerik.WinControls.UI.RadContextMenuManager
    Friend WithEvents ContextGrid As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents TxtGroupSearch As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents chkEditSellingPrice As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkEditPurchasingPrice As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents radioEditAmount As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents radioEditPercentage As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents MskTextAmountPercent As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents BtnEditPrice As Telerik.WinControls.UI.RadButton
    Friend WithEvents tblItemsToAdd As TableLayoutPanel
    Friend WithEvents LblBarcode As Label
    Friend WithEvents TxtItemBarcode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblItemID As Label
    Friend WithEvents TxtItemid As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblItemName As Label
    Friend WithEvents btnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents tblContainer As TableLayoutPanel
    Friend WithEvents pnlRightGroups As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents pnlLeft As Telerik.WinControls.UI.RadPanel
    Friend WithEvents pnlLeftHeader As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents pnlItemsToAdd As Panel
    Friend WithEvents pnlHeaderPrices As Panel
    Friend WithEvents tblHeaderPrices As TableLayoutPanel
    Friend WithEvents CustomTxtItemName As CustomItemNameTextBoxControl
    Friend WithEvents btnCalculate As Telerik.WinControls.UI.RadButton
End Class

