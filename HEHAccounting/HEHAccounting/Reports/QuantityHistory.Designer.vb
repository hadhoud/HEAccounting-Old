<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuantityHistory
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
        Dim GridViewSummaryItem1 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem2 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem3 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem4 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuantityHistory))
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.GridQuantity = New Telerik.WinControls.UI.RadGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New Telerik.WinControls.UI.RadButton()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.MskTxtInvDateFrom = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.CheckDateFrom = New Telerik.WinControls.UI.RadCheckBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.MskTxtInvDateTo = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.CheckDateTo = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadioSales = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadioPurchase = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadoAll = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadioInventory = New Telerik.WinControls.UI.RadRadioButton()
        Me.CustomTxtItemName = New HEHAccounting.CustomItemNameTextBoxControl()
        CType(Me.GridQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridQuantity.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadoAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridQuantity
        '
        Me.GridQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridQuantity.Location = New System.Drawing.Point(3, 3)
        '
        '
        '
        Me.GridQuantity.MasterTemplate.BottomPinnedRowsMode = Telerik.WinControls.UI.GridViewBottomPinnedRowsMode.Fixed
        GridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count
        GridViewSummaryItem1.AggregateExpression = Nothing
        GridViewSummaryItem1.FormatString = "{0}"
        GridViewSummaryItem1.Name = "ItemID"
        GridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem2.AggregateExpression = Nothing
        GridViewSummaryItem2.FormatString = "{0}"
        GridViewSummaryItem2.Name = "AvailableQty"
        GridViewSummaryItem3.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem3.AggregateExpression = Nothing
        GridViewSummaryItem3.FormatString = "{0}"
        GridViewSummaryItem3.Name = "Qty"
        GridViewSummaryItem4.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem4.AggregateExpression = Nothing
        GridViewSummaryItem4.FormatString = "{0}"
        GridViewSummaryItem4.Name = "Balance"
        Me.GridQuantity.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem1, GridViewSummaryItem2, GridViewSummaryItem3, GridViewSummaryItem4}))
        Me.GridQuantity.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridQuantity.Name = "GridQuantity"
        Me.GridQuantity.Size = New System.Drawing.Size(631, 444)
        Me.GridQuantity.TabIndex = 5
        Me.GridQuantity.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PnlOptions, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GridQuantity, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(880, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PnlOptions
        '
        Me.PnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlOptions.Location = New System.Drawing.Point(640, 3)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(237, 444)
        Me.PnlOptions.TabIndex = 4
        Me.PnlOptions.Visible = False
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 357)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(231, 84)
        Me.TableLayoutPanel3.TabIndex = 18
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.LblTo, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LblItemName, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LblFrom, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioSales, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioPurchase, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.RadoAll, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioInventory, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.CustomTxtItemName, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(231, 253)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTo.Location = New System.Drawing.Point(183, 92)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(45, 36)
        Me.LblTo.TabIndex = 18
        Me.LblTo.Text = "إلى"
        Me.LblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblItemName
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblItemName.Location = New System.Drawing.Point(183, 28)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(45, 28)
        Me.LblItemName.TabIndex = 17
        Me.LblItemName.Text = "الصنف"
        Me.LblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFrom.Location = New System.Drawing.Point(183, 56)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(45, 36)
        Me.LblFrom.TabIndex = 17
        Me.LblFrom.Text = "من"
        Me.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 59)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(174, 30)
        Me.TableLayoutPanel4.TabIndex = 42
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
        Me.MskTxtInvDateFrom.Size = New System.Drawing.Size(147, 24)
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
        Me.CheckDateFrom.Location = New System.Drawing.Point(156, 7)
        Me.CheckDateFrom.Name = "CheckDateFrom"
        Me.CheckDateFrom.Size = New System.Drawing.Size(15, 15)
        Me.CheckDateFrom.TabIndex = 44
        Me.CheckDateFrom.ThemeName = "Office2010Blue"
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
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 95)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(174, 30)
        Me.TableLayoutPanel5.TabIndex = 43
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
        Me.MskTxtInvDateTo.Size = New System.Drawing.Size(147, 24)
        Me.MskTxtInvDateTo.TabIndex = 44
        Me.MskTxtInvDateTo.TabStop = False
        Me.MskTxtInvDateTo.Text = "01/01/2020"
        Me.MskTxtInvDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDateTo.ThemeName = "Office2010Blue"
        '
        'CheckDateTo
        '
        Me.CheckDateTo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckDateTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDateTo.Location = New System.Drawing.Point(156, 7)
        Me.CheckDateTo.Name = "CheckDateTo"
        Me.CheckDateTo.Size = New System.Drawing.Size(15, 15)
        Me.CheckDateTo.TabIndex = 45
        Me.CheckDateTo.ThemeName = "Office2010Blue"
        '
        'RadioSales
        '
        Me.RadioSales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioSales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadioSales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSales.Location = New System.Drawing.Point(95, 131)
        Me.RadioSales.Name = "RadioSales"
        Me.RadioSales.Size = New System.Drawing.Size(82, 22)
        Me.RadioSales.TabIndex = 44
        Me.RadioSales.Tag = ""
        Me.RadioSales.Text = "فواتير مبيع"
        Me.RadioSales.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioSales.ThemeName = "Office2010Blue"
        Me.RadioSales.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadioPurchase
        '
        Me.RadioPurchase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioPurchase.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPurchase.Location = New System.Drawing.Point(90, 159)
        Me.RadioPurchase.Name = "RadioPurchase"
        Me.RadioPurchase.Size = New System.Drawing.Size(87, 22)
        Me.RadioPurchase.TabIndex = 45
        Me.RadioPurchase.TabStop = False
        Me.RadioPurchase.Tag = ""
        Me.RadioPurchase.Text = "فواتير شراء"
        Me.RadioPurchase.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioPurchase.ThemeName = "Office2010Blue"
        '
        'RadoAll
        '
        Me.RadoAll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadoAll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadoAll.Location = New System.Drawing.Point(120, 215)
        Me.RadoAll.Name = "RadoAll"
        Me.RadoAll.Size = New System.Drawing.Size(57, 22)
        Me.RadoAll.TabIndex = 46
        Me.RadoAll.TabStop = False
        Me.RadoAll.Tag = ""
        Me.RadoAll.Text = "الجميع"
        Me.RadoAll.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadoAll.ThemeName = "Office2010Blue"
        '
        'RadioInventory
        '
        Me.RadioInventory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioInventory.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioInventory.Location = New System.Drawing.Point(112, 187)
        Me.RadioInventory.Name = "RadioInventory"
        Me.RadioInventory.Size = New System.Drawing.Size(65, 22)
        Me.RadioInventory.TabIndex = 47
        Me.RadioInventory.TabStop = False
        Me.RadioInventory.Tag = ""
        Me.RadioInventory.Text = "الجردات"
        Me.RadioInventory.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioInventory.ThemeName = "Office2010Blue"
        '
        'CustomTxtItemName
        '
        Me.CustomTxtItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomTxtItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomTxtItemName.Location = New System.Drawing.Point(3, 31)
        Me.CustomTxtItemName.Name = "CustomTxtItemName"
        Me.CustomTxtItemName.Size = New System.Drawing.Size(174, 22)
        Me.CustomTxtItemName.TabIndex = 19
        Me.CustomTxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QuantityHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuantityHistory"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.Tag = "FrmQuantityHistory"
        Me.Text = "حركة الكمية"
        Me.ThemeName = "Office2010Blue"
        CType(Me.GridQuantity.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadoAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents GridQuantity As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LblTo As Label
    Friend WithEvents LblItemName As Label
    Friend WithEvents LblFrom As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents MskTxtInvDateFrom As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents CheckDateFrom As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents MskTxtInvDateTo As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents CheckDateTo As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadioSales As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadioPurchase As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadoAll As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadioInventory As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents CustomTxtItemName As CustomItemNameTextBoxControl
End Class

