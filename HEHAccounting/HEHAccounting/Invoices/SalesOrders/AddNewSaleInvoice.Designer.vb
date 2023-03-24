<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewSaleInvoice
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
        Dim GridViewSummaryItem2 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem3 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem4 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem5 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem6 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.GridInvItem = New Telerik.WinControls.UI.RadGridView()
        Me.TLPHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.lblItemPurchasePriceLira = New Telerik.WinControls.UI.RadLabel()
        Me.CustomTxtItemName = New HEHAccounting.CustomItemNameTextBoxControl()
        Me.TxtItemBarcode = New Telerik.WinControls.UI.RadTextBox()
        Me.LblItemID = New System.Windows.Forms.Label()
        Me.LblBarcode = New System.Windows.Forms.Label()
        Me.TxtItemid = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.lblItemPurchasePriceDollar = New Telerik.WinControls.UI.RadLabel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioCurrencyDollar = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadioCurrencyLebanease = New Telerik.WinControls.UI.RadRadioButton()
        Me.txtTotalDueBig = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.DropStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.RadioCash = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadioReturns = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadioSales = New Telerik.WinControls.UI.RadRadioButton()
        Me.TxtCustomer = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.TxtCustomerBtn = New Telerik.WinControls.UI.RadButtonElement()
        Me.TxtInvID = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtSubTotal = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtTotalDue = New Telerik.WinControls.UI.RadTextBox()
        Me.TLPSOHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.tblCurrencyRow = New System.Windows.Forms.TableLayoutPanel()
        Me.txtDollarRate = New Telerik.WinControls.UI.RadTextBox()
        Me.BtnGetCurrencyVal = New Telerik.WinControls.UI.RadButton()
        Me.LblInvID = New System.Windows.Forms.Label()
        Me.LblDueTotal = New System.Windows.Forms.Label()
        Me.LblDiscount = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblInvSubTotal = New System.Windows.Forms.Label()
        Me.LblInvCustomer = New System.Windows.Forms.Label()
        Me.LblInvDate = New System.Windows.Forms.Label()
        Me.LblInvType = New System.Windows.Forms.Label()
        Me.TxtDiscount = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.MskTxtInvDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioDebt = New Telerik.WinControls.UI.RadRadioButton()
        Me.LblDropCurrency = New System.Windows.Forms.Label()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.LblCurrValue = New System.Windows.Forms.Label()
        Me.TxtCurrencyVal = New Telerik.WinControls.UI.RadTextBox()
        Me.LblPaymentType = New System.Windows.Forms.Label()
        Me.LblPaid = New System.Windows.Forms.Label()
        Me.lblProfit = New System.Windows.Forms.Label()
        Me.TxtProfit = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPCommand = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        Me.BtnPrint = New Telerik.WinControls.UI.RadButton()
        Me.CustomerTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimerPurchasePrice = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GridInvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInvItem.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPHeader.SuspendLayout()
        CType(Me.lblItemPurchasePriceLira, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblItemPurchasePriceDollar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.RadioCurrencyDollar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioCurrencyLebanease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalDueBig, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioReturns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotalDue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPSOHeader.SuspendLayout()
        Me.tblCurrencyRow.SuspendLayout()
        CType(Me.txtDollarRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnGetCurrencyVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.TxtDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.RadioDebt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCurrencyVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtProfit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TLPCommand.SuspendLayout()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridInvItem
        '
        Me.GridInvItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridInvItem.Location = New System.Drawing.Point(5, 71)
        '
        '
        '
        GridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem1.AggregateExpression = Nothing
        GridViewSummaryItem1.FormatString = "{0}"
        GridViewSummaryItem1.Name = "PurchasingPrice"
        GridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem2.AggregateExpression = Nothing
        GridViewSummaryItem2.FormatString = "{0}"
        GridViewSummaryItem2.Name = "SalesProfitByQty"
        GridViewSummaryItem3.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem3.AggregateExpression = Nothing
        GridViewSummaryItem3.FormatString = "{0}"
        GridViewSummaryItem3.Name = "SubTotal"
        GridViewSummaryItem4.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem4.AggregateExpression = Nothing
        GridViewSummaryItem4.FormatString = "{0}"
        GridViewSummaryItem4.Name = "ItemDiscount"
        GridViewSummaryItem5.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem5.AggregateExpression = Nothing
        GridViewSummaryItem5.FormatString = "{0}"
        GridViewSummaryItem5.Name = "TotalDue"
        GridViewSummaryItem6.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count
        GridViewSummaryItem6.AggregateExpression = Nothing
        GridViewSummaryItem6.FormatString = "{0}"
        GridViewSummaryItem6.Name = "Item_id"
        Me.GridInvItem.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem1, GridViewSummaryItem2, GridViewSummaryItem3, GridViewSummaryItem4, GridViewSummaryItem5, GridViewSummaryItem6}))
        Me.GridInvItem.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridInvItem.Name = "GridInvItem"
        Me.GridInvItem.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell
        Me.TableLayoutPanel1.SetRowSpan(Me.GridInvItem, 2)
        Me.GridInvItem.Size = New System.Drawing.Size(979, 426)
        Me.GridInvItem.TabIndex = 4
        Me.GridInvItem.TabStop = False
        Me.GridInvItem.ThemeName = "Office2010Blue"
        '
        'TLPHeader
        '
        Me.TLPHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TLPHeader.ColumnCount = 8
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.TLPHeader.Controls.Add(Me.LblItemName, 2, 0)
        Me.TLPHeader.Controls.Add(Me.lblItemPurchasePriceLira, 7, 0)
        Me.TLPHeader.Controls.Add(Me.CustomTxtItemName, 2, 1)
        Me.TLPHeader.Controls.Add(Me.TxtItemBarcode, 0, 1)
        Me.TLPHeader.Controls.Add(Me.LblItemID, 1, 0)
        Me.TLPHeader.Controls.Add(Me.LblBarcode, 0, 0)
        Me.TLPHeader.Controls.Add(Me.TxtItemid, 1, 1)
        Me.TLPHeader.Controls.Add(Me.BtnAdd, 4, 0)
        Me.TLPHeader.Controls.Add(Me.lblItemPurchasePriceDollar, 7, 1)
        Me.TLPHeader.Controls.Add(Me.TableLayoutPanel5, 5, 0)
        Me.TLPHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLPHeader.Location = New System.Drawing.Point(5, 3)
        Me.TLPHeader.Name = "TLPHeader"
        Me.TLPHeader.RowCount = 2
        Me.TLPHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPHeader.Size = New System.Drawing.Size(979, 62)
        Me.TLPHeader.TabIndex = 2
        '
        'LblItemName
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemName.Location = New System.Drawing.Point(512, 0)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(162, 30)
        Me.LblItemName.TabIndex = 74
        Me.LblItemName.Text = "إسم الصنف"
        Me.LblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemPurchasePriceLira
        '
        Me.lblItemPurchasePriceLira.AutoSize = False
        Me.lblItemPurchasePriceLira.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPurchasePriceLira.Location = New System.Drawing.Point(21, 3)
        Me.lblItemPurchasePriceLira.Name = "lblItemPurchasePriceLira"
        Me.lblItemPurchasePriceLira.Size = New System.Drawing.Size(113, 24)
        Me.lblItemPurchasePriceLira.TabIndex = 75
        Me.lblItemPurchasePriceLira.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.lblItemPurchasePriceLira.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CustomTxtItemName
        '
        Me.CustomTxtItemName.Location = New System.Drawing.Point(512, 33)
        Me.CustomTxtItemName.Name = "CustomTxtItemName"
        Me.CustomTxtItemName.Size = New System.Drawing.Size(162, 24)
        Me.CustomTxtItemName.TabIndex = 2
        Me.CustomTxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtItemBarcode
        '
        Me.TxtItemBarcode.AcceptsTab = True
        Me.TxtItemBarcode.BackColor = System.Drawing.Color.White
        Me.TxtItemBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemBarcode.HideSelection = False
        Me.TxtItemBarcode.Location = New System.Drawing.Point(831, 33)
        Me.TxtItemBarcode.MaxLength = 65535
        Me.TxtItemBarcode.Name = "TxtItemBarcode"
        Me.TxtItemBarcode.ShowClearButton = True
        Me.TxtItemBarcode.Size = New System.Drawing.Size(145, 24)
        Me.TxtItemBarcode.TabIndex = 0
        Me.TxtItemBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemBarcode.ThemeName = "Office2010Blue"
        Me.TxtItemBarcode.WordWrap = False
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblItemID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemID.Location = New System.Drawing.Point(680, 0)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(145, 30)
        Me.LblItemID.TabIndex = 73
        Me.LblItemID.Text = "كود الصنف"
        Me.LblItemID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBarcode
        '
        Me.LblBarcode.AutoSize = True
        Me.LblBarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarcode.Location = New System.Drawing.Point(831, 0)
        Me.LblBarcode.Name = "LblBarcode"
        Me.LblBarcode.Size = New System.Drawing.Size(145, 30)
        Me.LblBarcode.TabIndex = 66
        Me.LblBarcode.Text = "الباركود"
        Me.LblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtItemid
        '
        Me.TxtItemid.AcceptsTab = True
        Me.TxtItemid.BackColor = System.Drawing.Color.White
        Me.TxtItemid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemid.HideSelection = False
        Me.TxtItemid.Location = New System.Drawing.Point(680, 33)
        Me.TxtItemid.Mask = "G"
        Me.TxtItemid.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtItemid.Name = "TxtItemid"
        Me.TxtItemid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtItemid.Size = New System.Drawing.Size(145, 24)
        Me.TxtItemid.TabIndex = 1
        Me.TxtItemid.TabStop = False
        Me.TxtItemid.Text = "0"
        Me.TxtItemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemid.ThemeName = "Office2010Blue"
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.HEHAccounting.My.Resources.Resources.Create
        Me.BtnAdd.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Location = New System.Drawing.Point(406, 12)
        Me.BtnAdd.Name = "BtnAdd"
        Me.TLPHeader.SetRowSpan(Me.BtnAdd, 2)
        Me.BtnAdd.Size = New System.Drawing.Size(91, 37)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Tag = "Save"
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'lblItemPurchasePriceDollar
        '
        Me.lblItemPurchasePriceDollar.AutoSize = False
        Me.lblItemPurchasePriceDollar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemPurchasePriceDollar.Location = New System.Drawing.Point(21, 33)
        Me.lblItemPurchasePriceDollar.Name = "lblItemPurchasePriceDollar"
        Me.lblItemPurchasePriceDollar.Size = New System.Drawing.Size(113, 24)
        Me.lblItemPurchasePriceDollar.TabIndex = 76
        Me.lblItemPurchasePriceDollar.TextAlignment = System.Drawing.ContentAlignment.TopRight
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.RadioCurrencyDollar, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.RadioCurrencyLebanease, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.txtTotalDueBig, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(190, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TLPHeader.SetRowSpan(Me.TableLayoutPanel5, 2)
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.71429!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.28571!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(210, 56)
        Me.TableLayoutPanel5.TabIndex = 78
        '
        'RadioCurrencyDollar
        '
        Me.RadioCurrencyDollar.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioCurrencyDollar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioCurrencyDollar.Location = New System.Drawing.Point(74, 37)
        Me.RadioCurrencyDollar.Name = "RadioCurrencyDollar"
        Me.RadioCurrencyDollar.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioCurrencyDollar.Size = New System.Drawing.Size(28, 18)
        Me.RadioCurrencyDollar.TabIndex = 79
        Me.RadioCurrencyDollar.TabStop = False
        Me.RadioCurrencyDollar.Text = "$"
        '
        'RadioCurrencyLebanease
        '
        Me.RadioCurrencyLebanease.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadioCurrencyLebanease.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadioCurrencyLebanease.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioCurrencyLebanease.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioCurrencyLebanease.Location = New System.Drawing.Point(108, 37)
        Me.RadioCurrencyLebanease.Name = "RadioCurrencyLebanease"
        Me.RadioCurrencyLebanease.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioCurrencyLebanease.Size = New System.Drawing.Size(42, 18)
        Me.RadioCurrencyLebanease.TabIndex = 78
        Me.RadioCurrencyLebanease.Text = "L.L"
        Me.RadioCurrencyLebanease.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'txtTotalDueBig
        '
        Me.txtTotalDueBig.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel5.SetColumnSpan(Me.txtTotalDueBig, 2)
        Me.txtTotalDueBig.Culture = New System.Globalization.CultureInfo("ar-LB")
        Me.txtTotalDueBig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTotalDueBig.Enabled = False
        Me.txtTotalDueBig.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDueBig.ForeColor = System.Drawing.Color.Black
        Me.txtTotalDueBig.Location = New System.Drawing.Point(3, 3)
        Me.txtTotalDueBig.Mask = "C"
        Me.txtTotalDueBig.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtTotalDueBig.Name = "txtTotalDueBig"
        Me.txtTotalDueBig.Size = New System.Drawing.Size(204, 28)
        Me.txtTotalDueBig.TabIndex = 79
        Me.txtTotalDueBig.TabStop = False
        Me.txtTotalDueBig.Text = "0.00 ل.ل.‏"
        Me.txtTotalDueBig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DropStatus
        '
        Me.DropStatus.BackColor = System.Drawing.Color.White
        Me.DropStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropStatus.DropDownAnimationEnabled = True
        Me.DropStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropStatus.Location = New System.Drawing.Point(3, 213)
        Me.DropStatus.MaxLength = 65535
        Me.DropStatus.Name = "DropStatus"
        Me.DropStatus.Size = New System.Drawing.Size(153, 24)
        Me.DropStatus.TabIndex = 13
        Me.DropStatus.ThemeName = "Office2010Blue"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(162, 210)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(77, 30)
        Me.LblStatus.TabIndex = 4
        Me.LblStatus.Text = "الحالة"
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioCash
        '
        Me.RadioCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RadioCash.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadioCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioCash.Location = New System.Drawing.Point(52, 3)
        Me.RadioCash.Name = "RadioCash"
        Me.RadioCash.Size = New System.Drawing.Size(41, 22)
        Me.RadioCash.TabIndex = 0
        Me.RadioCash.Tag = "C"
        Me.RadioCash.Text = "نقدا"
        Me.RadioCash.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioCash.ThemeName = "Office2010Blue"
        Me.RadioCash.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadioReturns
        '
        Me.RadioReturns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RadioReturns.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioReturns.Location = New System.Drawing.Point(3, 3)
        Me.RadioReturns.Name = "RadioReturns"
        Me.RadioReturns.Size = New System.Drawing.Size(57, 22)
        Me.RadioReturns.TabIndex = 1
        Me.RadioReturns.TabStop = False
        Me.RadioReturns.Tag = ""
        Me.RadioReturns.Text = "مرتجع"
        Me.RadioReturns.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioReturns.ThemeName = "Office2010Blue"
        '
        'RadioSales
        '
        Me.RadioSales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RadioSales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadioSales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSales.Location = New System.Drawing.Point(72, 3)
        Me.RadioSales.Name = "RadioSales"
        Me.RadioSales.Size = New System.Drawing.Size(45, 22)
        Me.RadioSales.TabIndex = 0
        Me.RadioSales.Tag = "S"
        Me.RadioSales.Text = "مبيع"
        Me.RadioSales.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioSales.ThemeName = "Office2010Blue"
        Me.RadioSales.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'TxtCustomer
        '
        Me.TxtCustomer.AcceptsTab = True
        Me.TxtCustomer.AutoSize = False
        Me.TxtCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCustomer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomer.HideSelection = False
        Me.TxtCustomer.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.TxtCustomerBtn})
        Me.TxtCustomer.Location = New System.Drawing.Point(3, 183)
        Me.TxtCustomer.MaxLength = 65535
        Me.TxtCustomer.Name = "TxtCustomer"
        Me.TxtCustomer.ShowClearButton = True
        Me.TxtCustomer.Size = New System.Drawing.Size(153, 24)
        Me.TxtCustomer.TabIndex = 12
        Me.TxtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCustomer.ThemeName = "Office2010Blue"
        Me.TxtCustomer.WordWrap = False
        '
        'TxtCustomerBtn
        '
        Me.TxtCustomerBtn.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.TxtCustomerBtn.Image = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtCustomerBtn.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TxtCustomerBtn.Name = "TxtCustomerBtn"
        Me.TxtCustomerBtn.SmallImage = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtCustomerBtn.Text = ""
        Me.TxtCustomerBtn.UseCompatibleTextRendering = False
        '
        'TxtInvID
        '
        Me.TxtInvID.AcceptsTab = True
        Me.TxtInvID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvID.Enabled = False
        Me.TxtInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvID.HideSelection = False
        Me.TxtInvID.Location = New System.Drawing.Point(3, 89)
        Me.TxtInvID.MaxLength = 65535
        Me.TxtInvID.Name = "TxtInvID"
        Me.TxtInvID.Size = New System.Drawing.Size(153, 24)
        Me.TxtInvID.TabIndex = 9
        Me.TxtInvID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInvID.ThemeName = "Office2010Blue"
        Me.TxtInvID.WordWrap = False
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.AcceptsTab = True
        Me.TxtSubTotal.BackColor = System.Drawing.Color.White
        Me.TxtSubTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSubTotal.Enabled = False
        Me.TxtSubTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubTotal.HideSelection = False
        Me.TxtSubTotal.Location = New System.Drawing.Point(3, 243)
        Me.TxtSubTotal.MaxLength = 65535
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(153, 24)
        Me.TxtSubTotal.TabIndex = 14
        Me.TxtSubTotal.Text = "0"
        Me.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtSubTotal.ThemeName = "Office2010Blue"
        Me.TxtSubTotal.WordWrap = False
        '
        'TxtTotalDue
        '
        Me.TxtTotalDue.AcceptsTab = True
        Me.TxtTotalDue.BackColor = System.Drawing.Color.White
        Me.TxtTotalDue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTotalDue.Enabled = False
        Me.TxtTotalDue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalDue.HideSelection = False
        Me.TxtTotalDue.Location = New System.Drawing.Point(3, 303)
        Me.TxtTotalDue.MaxLength = 65535
        Me.TxtTotalDue.Name = "TxtTotalDue"
        Me.TxtTotalDue.Size = New System.Drawing.Size(153, 24)
        Me.TxtTotalDue.TabIndex = 16
        Me.TxtTotalDue.Text = "0"
        Me.TxtTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTotalDue.ThemeName = "Office2010Blue"
        Me.TxtTotalDue.WordWrap = False
        '
        'TLPSOHeader
        '
        Me.TLPSOHeader.AutoSize = True
        Me.TLPSOHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TLPSOHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TLPSOHeader.ColumnCount = 2
        Me.TLPSOHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPSOHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPSOHeader.Controls.Add(Me.tblCurrencyRow, 1, 2)
        Me.TLPSOHeader.Controls.Add(Me.LblInvID, 0, 3)
        Me.TLPSOHeader.Controls.Add(Me.LblDueTotal, 0, 10)
        Me.TLPSOHeader.Controls.Add(Me.LblDiscount, 0, 9)
        Me.TLPSOHeader.Controls.Add(Me.TableLayoutPanel3, 1, 4)
        Me.TLPSOHeader.Controls.Add(Me.LblInvSubTotal, 0, 8)
        Me.TLPSOHeader.Controls.Add(Me.LblInvCustomer, 0, 6)
        Me.TLPSOHeader.Controls.Add(Me.LblInvDate, 0, 5)
        Me.TLPSOHeader.Controls.Add(Me.LblInvType, 0, 4)
        Me.TLPSOHeader.Controls.Add(Me.TxtInvID, 1, 3)
        Me.TLPSOHeader.Controls.Add(Me.TxtCustomer, 1, 6)
        Me.TLPSOHeader.Controls.Add(Me.LblStatus, 0, 7)
        Me.TLPSOHeader.Controls.Add(Me.DropStatus, 1, 7)
        Me.TLPSOHeader.Controls.Add(Me.TxtSubTotal, 1, 8)
        Me.TLPSOHeader.Controls.Add(Me.TxtTotalDue, 1, 10)
        Me.TLPSOHeader.Controls.Add(Me.TxtDiscount, 1, 9)
        Me.TLPSOHeader.Controls.Add(Me.MskTxtInvDate, 1, 5)
        Me.TLPSOHeader.Controls.Add(Me.TableLayoutPanel2, 1, 12)
        Me.TLPSOHeader.Controls.Add(Me.LblDropCurrency, 0, 1)
        Me.TLPSOHeader.Controls.Add(Me.DropCurrency, 1, 1)
        Me.TLPSOHeader.Controls.Add(Me.LblCurrValue, 0, 2)
        Me.TLPSOHeader.Controls.Add(Me.TxtCurrencyVal, 1, 0)
        Me.TLPSOHeader.Controls.Add(Me.LblPaymentType, 0, 12)
        Me.TLPSOHeader.Controls.Add(Me.LblPaid, 0, 13)
        Me.TLPSOHeader.Controls.Add(Me.lblProfit, 0, 11)
        Me.TLPSOHeader.Controls.Add(Me.TxtProfit, 1, 11)
        Me.TLPSOHeader.Location = New System.Drawing.Point(987, 0)
        Me.TLPSOHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPSOHeader.Name = "TLPSOHeader"
        Me.TLPSOHeader.RowCount = 15
        Me.TableLayoutPanel1.SetRowSpan(Me.TLPSOHeader, 2)
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPSOHeader.Size = New System.Drawing.Size(242, 421)
        Me.TLPSOHeader.TabIndex = 0
        '
        'tblCurrencyRow
        '
        Me.tblCurrencyRow.AutoSize = True
        Me.tblCurrencyRow.ColumnCount = 2
        Me.tblCurrencyRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblCurrencyRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblCurrencyRow.Controls.Add(Me.txtDollarRate, 0, 0)
        Me.tblCurrencyRow.Controls.Add(Me.BtnGetCurrencyVal, 1, 0)
        Me.tblCurrencyRow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblCurrencyRow.Location = New System.Drawing.Point(0, 53)
        Me.tblCurrencyRow.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.tblCurrencyRow.Name = "tblCurrencyRow"
        Me.tblCurrencyRow.RowCount = 1
        Me.tblCurrencyRow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblCurrencyRow.Size = New System.Drawing.Size(159, 30)
        Me.tblCurrencyRow.TabIndex = 44
        '
        'txtDollarRate
        '
        Me.txtDollarRate.AcceptsTab = True
        Me.txtDollarRate.AutoSize = False
        Me.txtDollarRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDollarRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDollarRate.Enabled = False
        Me.txtDollarRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDollarRate.HideSelection = False
        Me.txtDollarRate.Location = New System.Drawing.Point(35, 3)
        Me.txtDollarRate.MaxLength = 65535
        Me.txtDollarRate.Name = "txtDollarRate"
        Me.txtDollarRate.Size = New System.Drawing.Size(121, 24)
        Me.txtDollarRate.TabIndex = 6
        Me.txtDollarRate.Tag = "1"
        Me.txtDollarRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDollarRate.ThemeName = "Office2010Blue"
        Me.txtDollarRate.WordWrap = False
        '
        'BtnGetCurrencyVal
        '
        Me.BtnGetCurrencyVal.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.BtnGetCurrencyVal.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnGetCurrencyVal.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnGetCurrencyVal.Location = New System.Drawing.Point(3, 3)
        Me.BtnGetCurrencyVal.Name = "BtnGetCurrencyVal"
        Me.BtnGetCurrencyVal.Size = New System.Drawing.Size(26, 24)
        Me.BtnGetCurrencyVal.TabIndex = 6
        Me.BtnGetCurrencyVal.Text = "RadButton1"
        '
        'LblInvID
        '
        Me.LblInvID.AutoSize = True
        Me.LblInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvID.Location = New System.Drawing.Point(162, 86)
        Me.LblInvID.Name = "LblInvID"
        Me.LblInvID.Size = New System.Drawing.Size(77, 30)
        Me.LblInvID.TabIndex = 0
        Me.LblInvID.Text = "رقم الفاتورة"
        Me.LblInvID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDueTotal
        '
        Me.LblDueTotal.AutoSize = True
        Me.LblDueTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDueTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDueTotal.Location = New System.Drawing.Point(162, 300)
        Me.LblDueTotal.Name = "LblDueTotal"
        Me.LblDueTotal.Size = New System.Drawing.Size(77, 30)
        Me.LblDueTotal.TabIndex = 7
        Me.LblDueTotal.Text = "الصافي"
        Me.LblDueTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDiscount
        '
        Me.LblDiscount.AutoSize = True
        Me.LblDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDiscount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiscount.Location = New System.Drawing.Point(162, 270)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(77, 30)
        Me.LblDiscount.TabIndex = 6
        Me.LblDiscount.Text = "الخصم"
        Me.LblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.RadioSales, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RadioReturns, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(17, 119)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(126, 28)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'LblInvSubTotal
        '
        Me.LblInvSubTotal.AutoSize = True
        Me.LblInvSubTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvSubTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSubTotal.Location = New System.Drawing.Point(162, 240)
        Me.LblInvSubTotal.Name = "LblInvSubTotal"
        Me.LblInvSubTotal.Size = New System.Drawing.Size(77, 30)
        Me.LblInvSubTotal.TabIndex = 5
        Me.LblInvSubTotal.Text = "المجموع"
        Me.LblInvSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInvCustomer
        '
        Me.LblInvCustomer.AutoSize = True
        Me.LblInvCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvCustomer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvCustomer.Location = New System.Drawing.Point(162, 180)
        Me.LblInvCustomer.Name = "LblInvCustomer"
        Me.LblInvCustomer.Size = New System.Drawing.Size(77, 30)
        Me.LblInvCustomer.TabIndex = 3
        Me.LblInvCustomer.Text = "الزبون"
        Me.LblInvCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInvDate
        '
        Me.LblInvDate.AutoSize = True
        Me.LblInvDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvDate.Location = New System.Drawing.Point(162, 150)
        Me.LblInvDate.Name = "LblInvDate"
        Me.LblInvDate.Size = New System.Drawing.Size(77, 30)
        Me.LblInvDate.TabIndex = 2
        Me.LblInvDate.Text = "التاريخ"
        Me.LblInvDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInvType
        '
        Me.LblInvType.AutoSize = True
        Me.LblInvType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvType.Location = New System.Drawing.Point(162, 116)
        Me.LblInvType.Name = "LblInvType"
        Me.LblInvType.Size = New System.Drawing.Size(77, 34)
        Me.LblInvType.TabIndex = 1
        Me.LblInvType.Text = " نوع الفاتورة"
        Me.LblInvType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDiscount
        '
        Me.TxtDiscount.BackColor = System.Drawing.Color.White
        Me.TxtDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDiscount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiscount.Location = New System.Drawing.Point(3, 273)
        Me.TxtDiscount.Mask = "G"
        Me.TxtDiscount.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.PromptChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.TxtDiscount.Size = New System.Drawing.Size(153, 24)
        Me.TxtDiscount.TabIndex = 15
        Me.TxtDiscount.TabStop = False
        Me.TxtDiscount.Text = "0"
        Me.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDiscount.ThemeName = "Office2010Blue"
        '
        'MskTxtInvDate
        '
        Me.MskTxtInvDate.BackColor = System.Drawing.Color.White
        Me.MskTxtInvDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtInvDate.Location = New System.Drawing.Point(3, 153)
        Me.MskTxtInvDate.Mask = "dd/MM/yyyy"
        Me.MskTxtInvDate.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtInvDate.Name = "MskTxtInvDate"
        Me.MskTxtInvDate.Size = New System.Drawing.Size(153, 24)
        Me.MskTxtInvDate.TabIndex = 11
        Me.MskTxtInvDate.TabStop = False
        Me.MskTxtInvDate.Text = "01/01/2020"
        Me.MskTxtInvDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDate.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RadioDebt, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioCash, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(32, 363)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(96, 28)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'RadioDebt
        '
        Me.RadioDebt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RadioDebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDebt.Location = New System.Drawing.Point(3, 3)
        Me.RadioDebt.Name = "RadioDebt"
        Me.RadioDebt.Size = New System.Drawing.Size(42, 22)
        Me.RadioDebt.TabIndex = 1
        Me.RadioDebt.TabStop = False
        Me.RadioDebt.Tag = "D"
        Me.RadioDebt.Text = "آجل"
        Me.RadioDebt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioDebt.ThemeName = "Office2010Blue"
        '
        'LblDropCurrency
        '
        Me.LblDropCurrency.AutoSize = True
        Me.LblDropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDropCurrency.Location = New System.Drawing.Point(162, 20)
        Me.LblDropCurrency.Name = "LblDropCurrency"
        Me.LblDropCurrency.Size = New System.Drawing.Size(77, 30)
        Me.LblDropCurrency.TabIndex = 18
        Me.LblDropCurrency.Text = "العملة"
        Me.LblDropCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropCurrency
        '
        Me.DropCurrency.BackColor = System.Drawing.Color.White
        Me.DropCurrency.DropDownAnimationEnabled = True
        Me.DropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrency.Location = New System.Drawing.Point(3, 23)
        Me.DropCurrency.MaxLength = 65535
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Size = New System.Drawing.Size(153, 24)
        Me.DropCurrency.TabIndex = 19
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'LblCurrValue
        '
        Me.LblCurrValue.AutoSize = True
        Me.LblCurrValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCurrValue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrValue.Location = New System.Drawing.Point(162, 50)
        Me.LblCurrValue.Name = "LblCurrValue"
        Me.LblCurrValue.Size = New System.Drawing.Size(77, 36)
        Me.LblCurrValue.TabIndex = 20
        Me.LblCurrValue.Text = "قيمة الصرف"
        Me.LblCurrValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCurrencyVal
        '
        Me.TxtCurrencyVal.AcceptsTab = True
        Me.TxtCurrencyVal.AutoSize = False
        Me.TxtCurrencyVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCurrencyVal.Enabled = False
        Me.TxtCurrencyVal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurrencyVal.HideSelection = False
        Me.TxtCurrencyVal.Location = New System.Drawing.Point(125, 3)
        Me.TxtCurrencyVal.MaxLength = 65535
        Me.TxtCurrencyVal.Name = "TxtCurrencyVal"
        Me.TxtCurrencyVal.Size = New System.Drawing.Size(31, 14)
        Me.TxtCurrencyVal.TabIndex = 5
        Me.TxtCurrencyVal.Tag = "1"
        Me.TxtCurrencyVal.Text = "1"
        Me.TxtCurrencyVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCurrencyVal.ThemeName = "Office2010Blue"
        Me.TxtCurrencyVal.Visible = False
        Me.TxtCurrencyVal.WordWrap = False
        '
        'LblPaymentType
        '
        Me.LblPaymentType.AutoSize = True
        Me.LblPaymentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPaymentType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaymentType.Location = New System.Drawing.Point(162, 360)
        Me.LblPaymentType.Name = "LblPaymentType"
        Me.LblPaymentType.Size = New System.Drawing.Size(77, 34)
        Me.LblPaymentType.TabIndex = 8
        Me.LblPaymentType.Text = "الدفع"
        Me.LblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPaid
        '
        Me.LblPaid.AutoSize = True
        Me.TLPSOHeader.SetColumnSpan(Me.LblPaid, 2)
        Me.LblPaid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPaid.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaid.ForeColor = System.Drawing.Color.Red
        Me.LblPaid.Location = New System.Drawing.Point(3, 394)
        Me.LblPaid.Name = "LblPaid"
        Me.LblPaid.Size = New System.Drawing.Size(236, 25)
        Me.LblPaid.TabIndex = 45
        Me.LblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProfit
        '
        Me.lblProfit.AutoSize = True
        Me.lblProfit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProfit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfit.Location = New System.Drawing.Point(162, 330)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(77, 30)
        Me.lblProfit.TabIndex = 46
        Me.lblProfit.Text = "الربح"
        Me.lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtProfit
        '
        Me.TxtProfit.AcceptsTab = True
        Me.TxtProfit.BackColor = System.Drawing.Color.White
        Me.TxtProfit.Enabled = False
        Me.TxtProfit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProfit.HideSelection = False
        Me.TxtProfit.Location = New System.Drawing.Point(3, 333)
        Me.TxtProfit.MaxLength = 65535
        Me.TxtProfit.Name = "TxtProfit"
        Me.TxtProfit.Size = New System.Drawing.Size(153, 24)
        Me.TxtProfit.TabIndex = 47
        Me.TxtProfit.Text = "0"
        Me.TxtProfit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtProfit.ThemeName = "Office2010Blue"
        Me.TxtProfit.WordWrap = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GridInvItem, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TLPSOHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TLPHeader, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TLPCommand, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1229, 500)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TLPCommand
        '
        Me.TLPCommand.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TLPCommand.ColumnCount = 2
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.Controls.Add(Me.BtnSaveAndNew, 0, 0)
        Me.TLPCommand.Controls.Add(Me.BtnPrint, 1, 0)
        Me.TLPCommand.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLPCommand.Location = New System.Drawing.Point(987, 421)
        Me.TLPCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPCommand.Name = "TLPCommand"
        Me.TLPCommand.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TLPCommand.RowCount = 2
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPCommand.Size = New System.Drawing.Size(242, 49)
        Me.TLPCommand.TabIndex = 1
        '
        'BtnSaveAndNew
        '
        Me.BtnSaveAndNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSaveAndNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveAndNew.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSaveAndNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveAndNew.Location = New System.Drawing.Point(131, 3)
        Me.BtnSaveAndNew.Name = "BtnSaveAndNew"
        Me.BtnSaveAndNew.Size = New System.Drawing.Size(104, 32)
        Me.BtnSaveAndNew.TabIndex = 1
        Me.BtnSaveAndNew.Tag = "Save"
        Me.BtnSaveAndNew.Text = "حفظ _ جديد"
        Me.BtnSaveAndNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPrint.Location = New System.Drawing.Point(14, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(104, 33)
        Me.BtnPrint.TabIndex = 2
        Me.BtnPrint.Tag = "Print"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TimerPurchasePrice
        '
        '
        'AddNewSaleInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1229, 500)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNewSaleInvoice"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "AddNewSaleInvoice"
        Me.Text = "فاتورة مبيع"
        Me.ThemeName = "Office2010Blue"
        CType(Me.GridInvItem.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPHeader.ResumeLayout(False)
        Me.TLPHeader.PerformLayout()
        CType(Me.lblItemPurchasePriceLira, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblItemPurchasePriceDollar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.RadioCurrencyDollar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioCurrencyLebanease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalDueBig, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioReturns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotalDue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPSOHeader.ResumeLayout(False)
        Me.TLPSOHeader.PerformLayout()
        Me.tblCurrencyRow.ResumeLayout(False)
        CType(Me.txtDollarRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnGetCurrencyVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.TxtDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.RadioDebt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCurrencyVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtProfit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TLPCommand.ResumeLayout(False)
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents TxtTotalDue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtSubTotal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtInvID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtCustomer As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents TxtCustomerBtn As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadioSales As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadioReturns As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadioCash As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents GridInvItem As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TLPHeader As TableLayoutPanel
    Friend WithEvents LblItemName As Label
    Friend WithEvents TxtItemid As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents DropStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents LblItemID As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents TLPSOHeader As TableLayoutPanel
    Friend WithEvents LblInvType As Label
    Friend WithEvents LblInvID As Label
    Friend WithEvents LblDueTotal As Label
    Friend WithEvents LblDiscount As Label
    Friend WithEvents LblInvSubTotal As Label
    Friend WithEvents LblInvCustomer As Label
    Friend WithEvents LblInvDate As Label
    Friend WithEvents LblPaymentType As Label
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtDiscount As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Private WithEvents MskTxtInvDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadioDebt As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TxtItemBarcode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblBarcode As Label
    Friend WithEvents LblDropCurrency As Label
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents LblCurrValue As Label
    Friend WithEvents TLPCommand As TableLayoutPanel
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents CustomerTooltip As ToolTip
    Friend WithEvents tblCurrencyRow As TableLayoutPanel
    Friend WithEvents TxtCurrencyVal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BtnGetCurrencyVal As Telerik.WinControls.UI.RadButton
    Friend WithEvents LblPaid As Label
    Friend WithEvents txtDollarRate As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents lblItemPurchasePriceLira As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblItemPurchasePriceDollar As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TimerPurchasePrice As Timer
    Friend WithEvents lblProfit As Label
    Friend WithEvents TxtProfit As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents RadioCurrencyDollar As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadioCurrencyLebanease As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents txtTotalDueBig As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents CustomTxtItemName As CustomItemNameTextBoxControl
End Class

