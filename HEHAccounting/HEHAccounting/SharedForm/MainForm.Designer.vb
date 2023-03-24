<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits Telerik.WinControls.UI.RadRibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Private components As System.ComponentModel.IContainer
    'Required by the Windows Form Designer


    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    '' <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.LblUserName = New Telerik.WinControls.UI.RadLabelElement()
        Me.LblStatusUsername = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.StripLblDateNow = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.stripLblLastDollarRate = New Telerik.WinControls.UI.RadLabelElement()
        Me.stripLblDollarRateValue = New Telerik.WinControls.UI.RadLabelElement()
        Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.StriplblVersion = New Telerik.WinControls.UI.RadLabelElement()
        Me.StriplblVersionInfo = New Telerik.WinControls.UI.RadLabelElement()
        Me.RadRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.WindowDock = New Telerik.WinControls.UI.Docking.RadDock()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.RadOffice2007ScreenTipElement4 = New Telerik.WinControls.UI.RadOffice2007ScreenTipElement()
        Me.RadOffice2007ScreenTipElement1 = New Telerik.WinControls.UI.RadOffice2007ScreenTipElement()
        Me.RadOffice2007ScreenTipElement2 = New Telerik.WinControls.UI.RadOffice2007ScreenTipElement()
        Me.RadOffice2007ScreenTipElement3 = New Telerik.WinControls.UI.RadOffice2007ScreenTipElement()
        Me.RadRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
        Me.RibbonTabHome = New Telerik.WinControls.UI.RibbonTab()
        Me.RibGOption = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnDaily = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnHomeForm = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibButtonDashboard = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnSalesWin = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibGForms = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibonbtnItems = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnCustomers = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnVendors = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnSalesOrders = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnPurchaseOrders = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibGFastLink = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnAddSalesInvoices = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnAddPurchaseInvoices = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnAddItem = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnNotesPay = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnNotesReceive = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibTabTools = New Telerik.WinControls.UI.RibbonTab()
        Me.RGToolsItems = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnItemsTree = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnGroups = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnItemsInventory = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnAllInventory = New Telerik.WinControls.UI.RadButtonElement()
        Me.RGGournalEntry = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnKoyod = New Telerik.WinControls.UI.RadDropDownButtonElement()
        Me.GeneralNotesPayable = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.GeneralNotesReceive = New Telerik.WinControls.UI.RadMenuItem()
        Me.RGToolsAccounts = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnAccounts = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnAddAccount = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnOpenningBalance = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnAccountReport = New Telerik.WinControls.UI.RadButtonElement()
        Me.RGToolsCurrency = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnCurrencies = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnCurrRate = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibTabReports = New Telerik.WinControls.UI.RibbonTab()
        Me.RGReportsDebitCredit = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnCreditsReport = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnDebitsReport = New Telerik.WinControls.UI.RadButtonElement()
        Me.RGItemsReports = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnPurchasePrices = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnItemPurchase = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnQuantity = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnSalesPrices = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnItemMostSell = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnInventoryItems = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnItemsSalesWin = New Telerik.WinControls.UI.RadButtonElement()
        Me.RGReportsGeneralReports = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RadButtonElement5 = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnRptCheques = New Telerik.WinControls.UI.RadButtonElement()
        Me.RBTabSetting = New Telerik.WinControls.UI.RibbonTab()
        Me.RGSettingSetting = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnUserSettings = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnDatabase = New Telerik.WinControls.UI.RadDropDownButtonElement()
        Me.RadMenuBackup = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.RadMenuRestore = New Telerik.WinControls.UI.RadMenuItem()
        Me.RGSettingUsers = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnChangePass = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnUsers = New Telerik.WinControls.UI.RadButtonElement()
        Me.RGSettingProgram = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.RibBtnUserInfo = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnAbout = New Telerik.WinControls.UI.RadButtonElement()
        Me.RibBtnExit = New Telerik.WinControls.UI.RadButtonElement()
        Me.RGSettingProgrammer = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.CommandBarRowElement3 = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarRowTopMostanad = New Telerik.WinControls.UI.CommandBarRowElement()
        Me.CommandBarMostanadStripElement = New Telerik.WinControls.UI.CommandBarStripElement()
        Me.BtnCommandBarMostanadNew = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.BtnCommandBarEdit = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.BtnCommandBarCloseForm = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator6 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.BtnCommandBarShowHideForm = New Telerik.WinControls.UI.CommandBarToggleButton()
        Me.CommandBarSeparator7 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.BtnCommandBarExitApp = New Telerik.WinControls.UI.CommandBarButton()
        Me.CommandBarSeparator8 = New Telerik.WinControls.UI.CommandBarSeparator()
        Me.CommandBarMostanad = New Telerik.WinControls.UI.RadCommandBar()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WindowDock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WindowDock.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandBarMostanad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.LblUserName, Me.LblStatusUsername, Me.CommandBarSeparator1, Me.StripLblDateNow, Me.CommandBarSeparator2, Me.stripLblLastDollarRate, Me.stripLblDollarRateValue, Me.CommandBarSeparator3, Me.StriplblVersion, Me.StriplblVersionInfo})
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 713)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(1356, 24)
        Me.RadStatusStrip1.SizingGrip = False
        Me.RadStatusStrip1.TabIndex = 1
        Me.RadStatusStrip1.ThemeName = "Office2010Blue"
        '
        'LblUserName
        '
        Me.LblUserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserName.Name = "LblUserName"
        Me.RadStatusStrip1.SetSpring(Me.LblUserName, False)
        Me.LblUserName.Text = "إسم المستخدم :"
        Me.LblUserName.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.LblUserName.TextWrap = True
        '
        'LblStatusUsername
        '
        Me.LblStatusUsername.FlipText = False
        Me.LblStatusUsername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.LblStatusUsername.Name = "LblStatusUsername"
        Me.RadStatusStrip1.SetSpring(Me.LblStatusUsername, False)
        Me.LblStatusUsername.Text = "RadLabelElement2"
        Me.LblStatusUsername.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.LblStatusUsername.TextWrap = True
        '
        'CommandBarSeparator1
        '
        Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator1, False)
        Me.CommandBarSeparator1.VisibleInOverflowMenu = False
        '
        'StripLblDateNow
        '
        Me.StripLblDateNow.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.StripLblDateNow.Name = "StripLblDateNow"
        Me.RadStatusStrip1.SetSpring(Me.StripLblDateNow, False)
        Me.StripLblDateNow.Text = "12/12/2012"
        Me.StripLblDateNow.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.StripLblDateNow.TextWrap = True
        '
        'CommandBarSeparator2
        '
        Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator2, False)
        Me.CommandBarSeparator2.VisibleInOverflowMenu = False
        '
        'stripLblLastDollarRate
        '
        Me.stripLblLastDollarRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stripLblLastDollarRate.Name = "stripLblLastDollarRate"
        Me.RadStatusStrip1.SetSpring(Me.stripLblLastDollarRate, False)
        Me.stripLblLastDollarRate.Text = "سعر صرف الدولار:"
        Me.stripLblLastDollarRate.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.stripLblLastDollarRate.TextWrap = True
        '
        'stripLblDollarRateValue
        '
        Me.stripLblDollarRateValue.FlipText = False
        Me.stripLblDollarRateValue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stripLblDollarRateValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.stripLblDollarRateValue.Name = "stripLblDollarRateValue"
        Me.RadStatusStrip1.SetSpring(Me.stripLblDollarRateValue, False)
        Me.stripLblDollarRateValue.Text = "RadLabelElement2"
        Me.stripLblDollarRateValue.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.stripLblDollarRateValue.TextWrap = True
        '
        'CommandBarSeparator3
        '
        Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
        Me.RadStatusStrip1.SetSpring(Me.CommandBarSeparator3, False)
        Me.CommandBarSeparator3.VisibleInOverflowMenu = False
        '
        'StriplblVersion
        '
        Me.StriplblVersion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.StriplblVersion.Name = "StriplblVersion"
        Me.RadStatusStrip1.SetSpring(Me.StriplblVersion, False)
        Me.StriplblVersion.Text = "الإصدار:"
        Me.StriplblVersion.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.StriplblVersion.TextWrap = True
        '
        'StriplblVersionInfo
        '
        Me.StriplblVersionInfo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.StriplblVersionInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.StriplblVersionInfo.Name = "StriplblVersionInfo"
        Me.RadStatusStrip1.SetSpring(Me.StriplblVersionInfo, False)
        Me.StriplblVersionInfo.Text = "{0}.{1}.{2}{3}"
        Me.StriplblVersionInfo.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.StriplblVersionInfo.TextWrap = True
        '
        'RadRibbonBarGroup1
        '
        Me.RadRibbonBarGroup1.CreateAdapterMethod = Nothing
        Me.RadRibbonBarGroup1.Name = "RadRibbonBarGroup1"
        '
        'WindowDock
        '
        Me.WindowDock.AutoDetectMdiChildren = True
        Me.WindowDock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.WindowDock.Controls.Add(Me.DocumentContainer1)
        Me.WindowDock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowDock.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.ToBack
        Me.WindowDock.IsCleanUpTarget = True
        Me.WindowDock.Location = New System.Drawing.Point(0, 201)
        Me.WindowDock.MainDocumentContainer = Me.DocumentContainer1
        Me.WindowDock.Name = "WindowDock"
        Me.WindowDock.Padding = New System.Windows.Forms.Padding(0)
        '
        '
        '
        Me.WindowDock.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.WindowDock.SingleScreen = True
        Me.WindowDock.Size = New System.Drawing.Size(1356, 512)
        Me.WindowDock.TabIndex = 6
        Me.WindowDock.TabStop = False
        Me.WindowDock.ThemeName = "Office2010Blue"
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.ThemeName = "Office2010Blue"
        '
        'RadOffice2007ScreenTipElement4
        '
        Me.RadOffice2007ScreenTipElement4.Description = "Override this property and provide custom screentip template description in Desig" &
    "nTime."
        Me.RadOffice2007ScreenTipElement4.Name = "RadOffice2007ScreenTipElement4"
        Me.RadOffice2007ScreenTipElement4.TemplateType = Nothing
        Me.RadOffice2007ScreenTipElement4.TipSize = New System.Drawing.Size(0, 0)
        '
        'RadOffice2007ScreenTipElement1
        '
        Me.RadOffice2007ScreenTipElement1.Description = "Override this property and provide custom screentip template description in Desig" &
    "nTime."
        Me.RadOffice2007ScreenTipElement1.Name = "RadOffice2007ScreenTipElement1"
        Me.RadOffice2007ScreenTipElement1.TemplateType = Nothing
        Me.RadOffice2007ScreenTipElement1.TipSize = New System.Drawing.Size(0, 0)
        '
        'RadOffice2007ScreenTipElement2
        '
        Me.RadOffice2007ScreenTipElement2.Description = "Override this property and provide custom screentip template description in Desig" &
    "nTime."
        Me.RadOffice2007ScreenTipElement2.Name = "RadOffice2007ScreenTipElement2"
        Me.RadOffice2007ScreenTipElement2.TemplateType = Nothing
        Me.RadOffice2007ScreenTipElement2.TipSize = New System.Drawing.Size(0, 0)
        '
        'RadOffice2007ScreenTipElement3
        '
        Me.RadOffice2007ScreenTipElement3.Description = "Override this property and provide custom screentip template description in Desig" &
    "nTime."
        Me.RadOffice2007ScreenTipElement3.Name = "RadOffice2007ScreenTipElement3"
        Me.RadOffice2007ScreenTipElement3.TemplateType = Nothing
        Me.RadOffice2007ScreenTipElement3.TipSize = New System.Drawing.Size(0, 0)
        '
        'RadRibbonBar1
        '
        Me.RadRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() {Me.RibbonTabHome, Me.RibTabTools, Me.RibTabReports, Me.RBTabSetting})
        Me.RadRibbonBar1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadRibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadRibbonBar1.Name = "RadRibbonBar1"
        '
        '
        '
        Me.RadRibbonBar1.RootElement.AutoSize = True
        Me.RadRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.[Auto]
        Me.RadRibbonBar1.Size = New System.Drawing.Size(1356, 166)
        Me.RadRibbonBar1.StartButtonImage = Global.HEHAccounting.My.Resources.Resources.applogo
        Me.RadRibbonBar1.TabIndex = 0
        Me.RadRibbonBar1.Text = "MainForm"
        Me.RadRibbonBar1.ThemeName = "ControlDefault"
        '
        'RibbonTabHome
        '
        Me.RibbonTabHome.IsSelected = True
        Me.RibbonTabHome.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibGOption, Me.RibGForms, Me.RibGFastLink})
        Me.RibbonTabHome.Name = "RibbonTabHome"
        Me.RibbonTabHome.ShowHorizontalLine = False
        Me.RibbonTabHome.Text = "الرئيسية"
        Me.RibbonTabHome.UseMnemonic = False
        '
        'RibGOption
        '
        Me.RibGOption.CreateAdapterMethod = Nothing
        Me.RibGOption.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnDaily, Me.RibBtnHomeForm, Me.RibButtonDashboard, Me.RibBtnSalesWin})
        Me.RibGOption.Name = "RibGOption"
        Me.RibGOption.Text = "خيارات"
        '
        'RibBtnDaily
        '
        Me.RibBtnDaily.Image = Global.HEHAccounting.My.Resources.Resources.EveryDay
        Me.RibBtnDaily.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnDaily.Name = "RibBtnDaily"
        Me.RibBtnDaily.Text = "اليومية"
        Me.RibBtnDaily.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnHomeForm
        '
        Me.RibBtnHomeForm.Image = Global.HEHAccounting.My.Resources.Resources.home
        Me.RibBtnHomeForm.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnHomeForm.Name = "RibBtnHomeForm"
        Me.RibBtnHomeForm.Text = "الرئيسية"
        Me.RibBtnHomeForm.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnHomeForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibButtonDashboard
        '
        Me.RibButtonDashboard.Image = Global.HEHAccounting.My.Resources.Resources.statistics1
        Me.RibButtonDashboard.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibButtonDashboard.Name = "RibButtonDashboard"
        Me.RibButtonDashboard.Text = "تحليلات"
        Me.RibButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnSalesWin
        '
        Me.RibBtnSalesWin.Image = Global.HEHAccounting.My.Resources.Resources.my_invoices
        Me.RibBtnSalesWin.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnSalesWin.Name = "RibBtnSalesWin"
        Me.RibBtnSalesWin.Text = "أرباح مبيعات"
        Me.RibBtnSalesWin.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnSalesWin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibGForms
        '
        Me.RibGForms.CreateAdapterMethod = Nothing
        Me.RibGForms.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibonbtnItems, Me.RibBtnCustomers, Me.RibBtnVendors, Me.RibBtnSalesOrders, Me.RibBtnPurchaseOrders})
        Me.RibGForms.Name = "RibGForms"
        Me.RibGForms.Text = "النماذج"
        '
        'RibonbtnItems
        '
        Me.RibonbtnItems.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RibonbtnItems.Image = Global.HEHAccounting.My.Resources.Resources.Listt
        Me.RibonbtnItems.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibonbtnItems.Name = "RibonbtnItems"
        Me.RibonbtnItems.Text = "الأصناف"
        Me.RibonbtnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnCustomers
        '
        Me.RibBtnCustomers.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RibBtnCustomers.Image = Global.HEHAccounting.My.Resources.Resources.Suplier
        Me.RibBtnCustomers.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnCustomers.Name = "RibBtnCustomers"
        Me.RibBtnCustomers.Text = "الزبائن"
        Me.RibBtnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnVendors
        '
        Me.RibBtnVendors.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RibBtnVendors.Image = Global.HEHAccounting.My.Resources.Resources.Supplier
        Me.RibBtnVendors.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnVendors.Name = "RibBtnVendors"
        Me.RibBtnVendors.Text = "الموردين"
        Me.RibBtnVendors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnSalesOrders
        '
        Me.RibBtnSalesOrders.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RibBtnSalesOrders.AutoSize = True
        Me.RibBtnSalesOrders.Image = Global.HEHAccounting.My.Resources.Resources.billing
        Me.RibBtnSalesOrders.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnSalesOrders.Name = "RibBtnSalesOrders"
        Me.RibBtnSalesOrders.StretchHorizontally = True
        Me.RibBtnSalesOrders.StretchVertically = True
        Me.RibBtnSalesOrders.Text = "فواتير مبيعات"
        Me.RibBtnSalesOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RibBtnSalesOrders.TextWrap = True
        '
        'RibBtnPurchaseOrders
        '
        Me.RibBtnPurchaseOrders.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.RibBtnPurchaseOrders.AutoSize = True
        Me.RibBtnPurchaseOrders.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.RibBtnPurchaseOrders.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        Me.RibBtnPurchaseOrders.FlipText = False
        Me.RibBtnPurchaseOrders.Image = Global.HEHAccounting.My.Resources.Resources.invoice
        Me.RibBtnPurchaseOrders.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnPurchaseOrders.Name = "RibBtnPurchaseOrders"
        Me.RibBtnPurchaseOrders.Shape = Nothing
        Me.RibBtnPurchaseOrders.StretchHorizontally = True
        Me.RibBtnPurchaseOrders.StretchVertically = True
        Me.RibBtnPurchaseOrders.Text = "فواتير مشتريات"
        Me.RibBtnPurchaseOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RibBtnPurchaseOrders.TextWrap = True
        CType(Me.RibBtnPurchaseOrders.GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).MeasureTrailingSpaces = True
        CType(Me.RibBtnPurchaseOrders.GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextWrap = True
        CType(Me.RibBtnPurchaseOrders.GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).FlipText = False
        CType(Me.RibBtnPurchaseOrders.GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
        CType(Me.RibBtnPurchaseOrders.GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.RibBtnPurchaseOrders.GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.[Auto]
        CType(Me.RibBtnPurchaseOrders.GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        CType(Me.RibBtnPurchaseOrders.GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RibGFastLink
        '
        Me.RibGFastLink.CreateAdapterMethod = Nothing
        Me.RibGFastLink.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnAddSalesInvoices, Me.RibBtnAddPurchaseInvoices, Me.RibBtnAddItem, Me.RibBtnNotesPay, Me.RibBtnNotesReceive})
        Me.RibGFastLink.Name = "RibGFastLink"
        Me.RibGFastLink.Text = "روابط سريعة"
        '
        'RibBtnAddSalesInvoices
        '
        Me.RibBtnAddSalesInvoices.Image = Global.HEHAccounting.My.Resources.Resources.my_invoices
        Me.RibBtnAddSalesInvoices.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnAddSalesInvoices.Name = "RibBtnAddSalesInvoices"
        Me.RibBtnAddSalesInvoices.Text = "فاتورة مبيع"
        Me.RibBtnAddSalesInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnAddPurchaseInvoices
        '
        Me.RibBtnAddPurchaseInvoices.AutoSize = True
        Me.RibBtnAddPurchaseInvoices.Image = Global.HEHAccounting.My.Resources.Resources.my_invoices
        Me.RibBtnAddPurchaseInvoices.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnAddPurchaseInvoices.KeyTip = "1"
        Me.RibBtnAddPurchaseInvoices.Name = "RibBtnAddPurchaseInvoices"
        Me.RibBtnAddPurchaseInvoices.Text = "فاتورة شراء"
        Me.RibBtnAddPurchaseInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnAddItem
        '
        Me.RibBtnAddItem.Image = Global.HEHAccounting.My.Resources.Resources.page_white_add
        Me.RibBtnAddItem.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnAddItem.Name = "RibBtnAddItem"
        Me.RibBtnAddItem.Text = "إضافة صنف"
        Me.RibBtnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnNotesPay
        '
        Me.RibBtnNotesPay.Image = Global.HEHAccounting.My.Resources.Resources.money_delete
        Me.RibBtnNotesPay.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnNotesPay.Name = "RibBtnNotesPay"
        Me.RibBtnNotesPay.Text = "سند صرف"
        Me.RibBtnNotesPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnNotesReceive
        '
        Me.RibBtnNotesReceive.Image = Global.HEHAccounting.My.Resources.Resources.money_add
        Me.RibBtnNotesReceive.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnNotesReceive.Name = "RibBtnNotesReceive"
        Me.RibBtnNotesReceive.Text = "سند قبض"
        Me.RibBtnNotesReceive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibTabTools
        '
        Me.RibTabTools.IsSelected = False
        Me.RibTabTools.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RGToolsItems, Me.RGGournalEntry, Me.RGToolsAccounts, Me.RGToolsCurrency})
        Me.RibTabTools.Name = "RibTabTools"
        Me.RibTabTools.Text = "أدوات"
        Me.RibTabTools.UseMnemonic = False
        '
        'RGToolsItems
        '
        Me.RGToolsItems.CreateAdapterMethod = Nothing
        Me.RGToolsItems.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnItemsTree, Me.RibBtnGroups, Me.RibBtnItemsInventory, Me.RibBtnAllInventory, Me.RibBtnItemsInventory})
        Me.RGToolsItems.Name = "RGToolsItems"
        Me.RGToolsItems.Text = "الأصناف"
        '
        'RibBtnItemsTree
        '
        Me.RibBtnItemsTree.Image = Global.HEHAccounting.My.Resources.Resources.category
        Me.RibBtnItemsTree.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnItemsTree.Name = "RibBtnItemsTree"
        Me.RibBtnItemsTree.Text = "دليل الأصناف"
        Me.RibBtnItemsTree.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnGroups
        '
        Me.RibBtnGroups.Image = Global.HEHAccounting.My.Resources.Resources.Groups
        Me.RibBtnGroups.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnGroups.Name = "RibBtnGroups"
        Me.RibBtnGroups.Text = "المجموعات"
        Me.RibBtnGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.RibBtnGroups.UseCompatibleTextRendering = False
        '
        'RibBtnItemsInventory
        '
        Me.RibBtnItemsInventory.Image = Global.HEHAccounting.My.Resources.Resources.Shopping_cart
        Me.RibBtnItemsInventory.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnItemsInventory.Name = "RibBtnItemsInventory"
        Me.RibBtnItemsInventory.StretchHorizontally = True
        Me.RibBtnItemsInventory.StretchVertically = True
        Me.RibBtnItemsInventory.Text = "جردة أصناف"
        Me.RibBtnItemsInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnAllInventory
        '
        Me.RibBtnAllInventory.Image = Global.HEHAccounting.My.Resources.Resources.Shopping_cart
        Me.RibBtnAllInventory.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnAllInventory.Name = "RibBtnAllInventory"
        Me.RibBtnAllInventory.Text = "الجردات"
        Me.RibBtnAllInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RGGournalEntry
        '
        Me.RGGournalEntry.AutoSize = True
        Me.RGGournalEntry.CreateAdapterMethod = Nothing
        Me.RGGournalEntry.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnKoyod})
        Me.RGGournalEntry.Name = "RGGournalEntry"
        Me.RGGournalEntry.Text = "القيود"
        '
        'RibBtnKoyod
        '
        Me.RibBtnKoyod.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
        Me.RibBtnKoyod.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
        Me.RibBtnKoyod.ExpandArrowButton = False
        Me.RibBtnKoyod.Image = Global.HEHAccounting.My.Resources.Resources.money
        Me.RibBtnKoyod.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnKoyod.Items.AddRange(New Telerik.WinControls.RadItem() {Me.GeneralNotesPayable, Me.RadMenuSeparatorItem1, Me.GeneralNotesReceive})
        Me.RibBtnKoyod.Name = "RibBtnKoyod"
        Me.RibBtnKoyod.Text = "قيود يومية"
        Me.RibBtnKoyod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GeneralNotesPayable
        '
        Me.GeneralNotesPayable.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralNotesPayable.Name = "GeneralNotesPayable"
        Me.GeneralNotesPayable.Text = "سند صرف عام"
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GeneralNotesReceive
        '
        Me.GeneralNotesReceive.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GeneralNotesReceive.Name = "GeneralNotesReceive"
        Me.GeneralNotesReceive.Text = "سند قبض عام"
        '
        'RGToolsAccounts
        '
        Me.RGToolsAccounts.CreateAdapterMethod = Nothing
        Me.RGToolsAccounts.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnAccounts, Me.RibBtnAddAccount, Me.RibBtnOpenningBalance, Me.RibBtnAccountReport})
        Me.RGToolsAccounts.Name = "RGToolsAccounts"
        Me.RGToolsAccounts.Text = "الحسابات"
        '
        'RibBtnAccounts
        '
        Me.RibBtnAccounts.Image = Global.HEHAccounting.My.Resources.Resources.report_magnify
        Me.RibBtnAccounts.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnAccounts.Name = "RibBtnAccounts"
        Me.RibBtnAccounts.Text = "الحسابات"
        Me.RibBtnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnAddAccount
        '
        Me.RibBtnAddAccount.Image = Global.HEHAccounting.My.Resources.Resources.report_add
        Me.RibBtnAddAccount.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnAddAccount.Name = "RibBtnAddAccount"
        Me.RibBtnAddAccount.Text = "إضافة حساب"
        Me.RibBtnAddAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnOpenningBalance
        '
        Me.RibBtnOpenningBalance.Image = Global.HEHAccounting.My.Resources.Resources.book_open
        Me.RibBtnOpenningBalance.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnOpenningBalance.Name = "RibBtnOpenningBalance"
        Me.RibBtnOpenningBalance.Text = "رصيد إفتتاحي"
        Me.RibBtnOpenningBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnAccountReport
        '
        Me.RibBtnAccountReport.Image = Global.HEHAccounting.My.Resources.Resources.report_user
        Me.RibBtnAccountReport.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnAccountReport.Name = "RibBtnAccountReport"
        Me.RibBtnAccountReport.Text = "كشف حساب"
        Me.RibBtnAccountReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RGToolsCurrency
        '
        Me.RGToolsCurrency.CreateAdapterMethod = Nothing
        Me.RGToolsCurrency.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnCurrencies, Me.RibBtnCurrRate})
        Me.RGToolsCurrency.Name = "RGToolsCurrency"
        Me.RGToolsCurrency.Text = "العملات"
        '
        'RibBtnCurrencies
        '
        Me.RibBtnCurrencies.Image = Global.HEHAccounting.My.Resources.Resources.money_euro
        Me.RibBtnCurrencies.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnCurrencies.Name = "RibBtnCurrencies"
        Me.RibBtnCurrencies.Text = "العملات"
        Me.RibBtnCurrencies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnCurrRate
        '
        Me.RibBtnCurrRate.Image = Global.HEHAccounting.My.Resources.Resources.Favourites
        Me.RibBtnCurrRate.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnCurrRate.Name = "RibBtnCurrRate"
        Me.RibBtnCurrRate.Text = "أسعار العملات"
        Me.RibBtnCurrRate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibTabReports
        '
        Me.RibTabReports.IsSelected = False
        Me.RibTabReports.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RGReportsDebitCredit, Me.RGItemsReports, Me.RGReportsGeneralReports})
        Me.RibTabReports.Name = "RibTabReports"
        Me.RibTabReports.Text = "تقارير"
        Me.RibTabReports.UseMnemonic = False
        '
        'RGReportsDebitCredit
        '
        Me.RGReportsDebitCredit.CreateAdapterMethod = Nothing
        Me.RGReportsDebitCredit.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnCreditsReport, Me.RibBtnDebitsReport})
        Me.RGReportsDebitCredit.Name = "RGReportsDebitCredit"
        Me.RGReportsDebitCredit.Text = "الديون"
        '
        'RibBtnCreditsReport
        '
        Me.RibBtnCreditsReport.Image = Global.HEHAccounting.My.Resources.Resources.box_down___Copy
        Me.RibBtnCreditsReport.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnCreditsReport.Name = "RibBtnCreditsReport"
        Me.RibBtnCreditsReport.Text = "دائنون/لهم"
        Me.RibBtnCreditsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnDebitsReport
        '
        Me.RibBtnDebitsReport.Image = Global.HEHAccounting.My.Resources.Resources.box_down
        Me.RibBtnDebitsReport.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnDebitsReport.Name = "RibBtnDebitsReport"
        Me.RibBtnDebitsReport.Text = "مدينون/عليهم"
        Me.RibBtnDebitsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RGItemsReports
        '
        Me.RGItemsReports.CreateAdapterMethod = Nothing
        Me.RGItemsReports.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnPurchasePrices, Me.RibBtnItemPurchase, Me.RibBtnQuantity, Me.RibBtnSalesPrices, Me.RibBtnItemMostSell, Me.RibBtnInventoryItems, Me.RibBtnItemsSalesWin})
        Me.RGItemsReports.Name = "RGItemsReports"
        Me.RGItemsReports.Text = "حركة أصناف"
        '
        'RibBtnPurchasePrices
        '
        Me.RibBtnPurchasePrices.Image = Global.HEHAccounting.My.Resources.Resources.cost
        Me.RibBtnPurchasePrices.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnPurchasePrices.Name = "RibBtnPurchasePrices"
        Me.RibBtnPurchasePrices.Padding = New System.Windows.Forms.Padding(0)
        Me.RibBtnPurchasePrices.Text = "سعر الشراء"
        Me.RibBtnPurchasePrices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnItemPurchase
        '
        Me.RibBtnItemPurchase.Image = Global.HEHAccounting.My.Resources.Resources.statistics
        Me.RibBtnItemPurchase.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnItemPurchase.Name = "RibBtnItemPurchase"
        Me.RibBtnItemPurchase.Text = "عدد الشراء"
        Me.RibBtnItemPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnQuantity
        '
        Me.RibBtnQuantity.Image = Global.HEHAccounting.My.Resources.Resources.basket
        Me.RibBtnQuantity.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnQuantity.Name = "RibBtnQuantity"
        Me.RibBtnQuantity.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.RibBtnQuantity.Text = "الكمية"
        Me.RibBtnQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnSalesPrices
        '
        Me.RibBtnSalesPrices.Image = Global.HEHAccounting.My.Resources.Resources.cost
        Me.RibBtnSalesPrices.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnSalesPrices.Name = "RibBtnSalesPrices"
        Me.RibBtnSalesPrices.Text = "سعر المبيع"
        Me.RibBtnSalesPrices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnItemMostSell
        '
        Me.RibBtnItemMostSell.Image = Global.HEHAccounting.My.Resources.Resources.statistics
        Me.RibBtnItemMostSell.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnItemMostSell.Name = "RibBtnItemMostSell"
        Me.RibBtnItemMostSell.Text = "عدد المبيع"
        Me.RibBtnItemMostSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnInventoryItems
        '
        Me.RibBtnInventoryItems.Image = Global.HEHAccounting.My.Resources.Resources.Shopping_cart
        Me.RibBtnInventoryItems.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnInventoryItems.Name = "RibBtnInventoryItems"
        Me.RibBtnInventoryItems.Text = "جردات الأصناف"
        Me.RibBtnInventoryItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnItemsSalesWin
        '
        Me.RibBtnItemsSalesWin.Image = Global.HEHAccounting.My.Resources.Resources.my_invoices
        Me.RibBtnItemsSalesWin.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnItemsSalesWin.Name = "RibBtnItemsSalesWin"
        Me.RibBtnItemsSalesWin.Text = "أرباح مبيعات أصناف"
        Me.RibBtnItemsSalesWin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RGReportsGeneralReports
        '
        Me.RGReportsGeneralReports.CreateAdapterMethod = Nothing
        Me.RGReportsGeneralReports.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadButtonElement5, Me.RibBtnRptCheques})
        Me.RGReportsGeneralReports.Name = "RGReportsGeneralReports"
        Me.RGReportsGeneralReports.Text = "تقارير عامة"
        '
        'RadButtonElement5
        '
        Me.RadButtonElement5.Name = "RadButtonElement5"
        Me.RadButtonElement5.Text = "إجماليات"
        Me.RadButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'RibBtnRptCheques
        '
        Me.RibBtnRptCheques.Image = Global.HEHAccounting.My.Resources.Resources.Dollars
        Me.RibBtnRptCheques.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnRptCheques.Name = "RibBtnRptCheques"
        Me.RibBtnRptCheques.Text = "الشيكات"
        Me.RibBtnRptCheques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RBTabSetting
        '
        Me.RBTabSetting.IsSelected = False
        Me.RBTabSetting.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RGSettingSetting, Me.RGSettingUsers, Me.RGSettingProgram, Me.RGSettingProgrammer})
        Me.RBTabSetting.Name = "RBTabSetting"
        Me.RBTabSetting.Text = "الإعدادات"
        Me.RBTabSetting.UseMnemonic = False
        '
        'RGSettingSetting
        '
        Me.RGSettingSetting.CreateAdapterMethod = Nothing
        Me.RGSettingSetting.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnUserSettings, Me.RibBtnDatabase})
        Me.RGSettingSetting.Name = "RGSettingSetting"
        Me.RGSettingSetting.Text = "الإعدادات"
        '
        'RibBtnUserSettings
        '
        Me.RibBtnUserSettings.Image = Global.HEHAccounting.My.Resources.Resources.Application
        Me.RibBtnUserSettings.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnUserSettings.Name = "RibBtnUserSettings"
        Me.RibBtnUserSettings.Text = "الإعدادات"
        Me.RibBtnUserSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnDatabase
        '
        Me.RibBtnDatabase.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
        Me.RibBtnDatabase.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
        Me.RibBtnDatabase.ExpandArrowButton = False
        Me.RibBtnDatabase.Image = Global.HEHAccounting.My.Resources.Resources.Database
        Me.RibBtnDatabase.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnDatabase.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadMenuBackup, Me.RadMenuSeparatorItem2, Me.RadMenuRestore})
        Me.RibBtnDatabase.Name = "RibBtnDatabase"
        Me.RibBtnDatabase.Text = "قاعدة البيانات"
        Me.RibBtnDatabase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RadMenuBackup
        '
        Me.RadMenuBackup.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadMenuBackup.Name = "RadMenuBackup"
        Me.RadMenuBackup.Text = "نسخة إحتياطية"
        '
        'RadMenuSeparatorItem2
        '
        Me.RadMenuSeparatorItem2.Name = "RadMenuSeparatorItem2"
        Me.RadMenuSeparatorItem2.Text = "RadMenuSeparatorItem2"
        Me.RadMenuSeparatorItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadMenuRestore
        '
        Me.RadMenuRestore.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadMenuRestore.Name = "RadMenuRestore"
        Me.RadMenuRestore.Text = "إستعادة نسخة"
        '
        'RGSettingUsers
        '
        Me.RGSettingUsers.CreateAdapterMethod = Nothing
        Me.RGSettingUsers.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnChangePass, Me.RibBtnUsers})
        Me.RGSettingUsers.Name = "RGSettingUsers"
        Me.RGSettingUsers.Text = "مستخدمين"
        '
        'RibBtnChangePass
        '
        Me.RibBtnChangePass.Image = Global.HEHAccounting.My.Resources.Resources.lock_edit
        Me.RibBtnChangePass.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnChangePass.Name = "RibBtnChangePass"
        Me.RibBtnChangePass.Text = "كلمة المرور"
        Me.RibBtnChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnUsers
        '
        Me.RibBtnUsers.Image = Global.HEHAccounting.My.Resources.Resources.user
        Me.RibBtnUsers.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnUsers.Name = "RibBtnUsers"
        Me.RibBtnUsers.Text = "مستخدمين"
        Me.RibBtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RGSettingProgram
        '
        Me.RGSettingProgram.CreateAdapterMethod = Nothing
        Me.RGSettingProgram.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RibBtnUserInfo, Me.RibBtnAbout, Me.RibBtnExit})
        Me.RGSettingProgram.Name = "RGSettingProgram"
        Me.RGSettingProgram.Text = "البرنامج"
        '
        'RibBtnUserInfo
        '
        Me.RibBtnUserInfo.Image = CType(resources.GetObject("RibBtnUserInfo.Image"), System.Drawing.Image)
        Me.RibBtnUserInfo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnUserInfo.Name = "RibBtnUserInfo"
        Me.RibBtnUserInfo.Text = "معلومات"
        Me.RibBtnUserInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RibBtnAbout
        '
        Me.RibBtnAbout.Image = Global.HEHAccounting.My.Resources.Resources.Information
        Me.RibBtnAbout.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnAbout.Name = "RibBtnAbout"
        Me.RibBtnAbout.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.RibBtnAbout.Text = "حول "
        Me.RibBtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        CType(Me.RibBtnAbout.GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).LineLimit = False
        CType(Me.RibBtnAbout.GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RibBtnExit
        '
        Me.RibBtnExit.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.RibBtnExit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RibBtnExit.Name = "RibBtnExit"
        Me.RibBtnExit.Text = "خروج"
        Me.RibBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'RGSettingProgrammer
        '
        Me.RGSettingProgrammer.CreateAdapterMethod = Nothing
        Me.RGSettingProgrammer.Name = "RGSettingProgrammer"
        Me.RGSettingProgrammer.Text = "مبرمج"
        '
        'CommandBarRowElement3
        '
        Me.CommandBarRowElement3.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowElement3.Name = "CommandBarRowElement3"
        '
        'CommandBarRowTopMostanad
        '
        Me.CommandBarRowTopMostanad.AutoSize = True
        Me.CommandBarRowTopMostanad.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        Me.CommandBarRowTopMostanad.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowTopMostanad.DrawBorder = False
        Me.CommandBarRowTopMostanad.DrawFill = False
        Me.CommandBarRowTopMostanad.DrawImage = True
        Me.CommandBarRowTopMostanad.DrawText = False
        Me.CommandBarRowTopMostanad.EnableElementShadow = False
        Me.CommandBarRowTopMostanad.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        Me.CommandBarRowTopMostanad.FlipText = False
        Me.CommandBarRowTopMostanad.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommandBarRowTopMostanad.GradientStyle = Telerik.WinControls.GradientStyles.Linear
        Me.CommandBarRowTopMostanad.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CommandBarRowTopMostanad.MinSize = New System.Drawing.Size(25, 25)
        Me.CommandBarRowTopMostanad.Name = "CommandBarRowTopMostanad"
        Me.CommandBarRowTopMostanad.ShowHorizontalLine = False
        Me.CommandBarRowTopMostanad.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarMostanadStripElement})
        Me.CommandBarRowTopMostanad.Text = ""
        Me.CommandBarRowTopMostanad.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CommandBarRowTopMostanad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CommandBarRowTopMostanad.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.CommandBarRowTopMostanad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarRowTopMostanad.UseCompatibleTextRendering = False
        '
        'CommandBarMostanadStripElement
        '
        Me.CommandBarMostanadStripElement.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        Me.CommandBarMostanadStripElement.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarMostanadStripElement.DisplayName = "CommandBarMostanadStripElement"
        Me.CommandBarMostanadStripElement.DrawBorder = True
        Me.CommandBarMostanadStripElement.DrawFill = True
        Me.CommandBarMostanadStripElement.DrawImage = True
        Me.CommandBarMostanadStripElement.EnableDragging = False
        '
        '
        '
        Me.CommandBarMostanadStripElement.Grip.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        Me.CommandBarMostanadStripElement.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.BtnCommandBarMostanadNew, Me.CommandBarSeparator4, Me.BtnCommandBarEdit, Me.CommandBarSeparator5, Me.BtnCommandBarCloseForm, Me.CommandBarSeparator6, Me.BtnCommandBarShowHideForm, Me.CommandBarSeparator7, Me.BtnCommandBarExitApp, Me.CommandBarSeparator8})
        Me.CommandBarMostanadStripElement.Name = "CommandBarMostanadStripElement"
        '
        '
        '
        Me.CommandBarMostanadStripElement.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        Me.CommandBarMostanadStripElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.CommandBarMostanadStripElement.StretchHorizontally = True
        Me.CommandBarMostanadStripElement.StretchVertically = True
        Me.CommandBarMostanadStripElement.Text = ""
        Me.CommandBarMostanadStripElement.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarMostanadStripElement.UseCompatibleTextRendering = False
        CType(Me.CommandBarMostanadStripElement.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.CommandBarMostanadStripElement.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        '
        'BtnCommandBarMostanadNew
        '
        Me.BtnCommandBarMostanadNew.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BtnCommandBarMostanadNew.DisplayName = "CommandBarButton1"
        Me.BtnCommandBarMostanadNew.DrawText = True
        Me.BtnCommandBarMostanadNew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BtnCommandBarMostanadNew.Image = Global.HEHAccounting.My.Resources.Resources.Create
        Me.BtnCommandBarMostanadNew.Name = "BtnCommandBarMostanadNew"
        Me.BtnCommandBarMostanadNew.Text = "جديد"
        Me.BtnCommandBarMostanadNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCommandBarMostanadNew.TextOrientation = System.Windows.Forms.Orientation.Horizontal
        Me.BtnCommandBarMostanadNew.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BtnCommandBarMostanadNew.TextWrap = False
        Me.BtnCommandBarMostanadNew.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator4
        '
        Me.CommandBarSeparator4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator4.DisplayName = "CommandBarSeparator4"
        Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
        Me.CommandBarSeparator4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator4.UseCompatibleTextRendering = False
        Me.CommandBarSeparator4.VisibleInOverflowMenu = False
        '
        'BtnCommandBarEdit
        '
        Me.BtnCommandBarEdit.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BtnCommandBarEdit.DisplayName = "CommandBarButton1"
        Me.BtnCommandBarEdit.DrawText = True
        Me.BtnCommandBarEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BtnCommandBarEdit.Image = Global.HEHAccounting.My.Resources.Resources.Modify
        Me.BtnCommandBarEdit.Name = "BtnCommandBarEdit"
        Me.BtnCommandBarEdit.Text = "تعديل"
        Me.BtnCommandBarEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCommandBarEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BtnCommandBarEdit.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator5
        '
        Me.CommandBarSeparator5.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator5.DisplayName = "CommandBarSeparator5"
        Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
        Me.CommandBarSeparator5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator5.UseCompatibleTextRendering = False
        Me.CommandBarSeparator5.VisibleInOverflowMenu = False
        '
        'BtnCommandBarCloseForm
        '
        Me.BtnCommandBarCloseForm.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BtnCommandBarCloseForm.DisplayName = "CommandBarButton2"
        Me.BtnCommandBarCloseForm.DrawText = True
        Me.BtnCommandBarCloseForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BtnCommandBarCloseForm.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnCommandBarCloseForm.Name = "BtnCommandBarCloseForm"
        Me.BtnCommandBarCloseForm.Text = "إغلاق"
        Me.BtnCommandBarCloseForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCommandBarCloseForm.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BtnCommandBarCloseForm.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator6
        '
        Me.CommandBarSeparator6.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator6.DisplayName = "CommandBarSeparator6"
        Me.CommandBarSeparator6.Name = "CommandBarSeparator6"
        Me.CommandBarSeparator6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator6.UseCompatibleTextRendering = False
        Me.CommandBarSeparator6.VisibleInOverflowMenu = False
        '
        'BtnCommandBarShowHideForm
        '
        Me.BtnCommandBarShowHideForm.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BtnCommandBarShowHideForm.DisplayName = "CommandBarToggleButton1"
        Me.BtnCommandBarShowHideForm.DrawText = True
        Me.BtnCommandBarShowHideForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BtnCommandBarShowHideForm.Image = Global.HEHAccounting.My.Resources.Resources.Target
        Me.BtnCommandBarShowHideForm.Name = "BtnCommandBarShowHideForm"
        Me.BtnCommandBarShowHideForm.Text = "إظهار"
        Me.BtnCommandBarShowHideForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCommandBarShowHideForm.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BtnCommandBarShowHideForm.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator7
        '
        Me.CommandBarSeparator7.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator7.DisplayName = "CommandBarSeparator7"
        Me.CommandBarSeparator7.Name = "CommandBarSeparator7"
        Me.CommandBarSeparator7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator7.UseCompatibleTextRendering = False
        Me.CommandBarSeparator7.VisibleInOverflowMenu = False
        '
        'BtnCommandBarExitApp
        '
        Me.BtnCommandBarExitApp.Alignment = System.Drawing.ContentAlignment.TopLeft
        Me.BtnCommandBarExitApp.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BtnCommandBarExitApp.DisplayName = "CommandBarButton1"
        Me.BtnCommandBarExitApp.DrawText = True
        Me.BtnCommandBarExitApp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BtnCommandBarExitApp.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnCommandBarExitApp.Name = "BtnCommandBarExitApp"
        Me.BtnCommandBarExitApp.Text = "خروج"
        Me.BtnCommandBarExitApp.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnCommandBarExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCommandBarExitApp.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.BtnCommandBarExitApp.UseCompatibleTextRendering = False
        '
        'CommandBarSeparator8
        '
        Me.CommandBarSeparator8.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator8.DisplayName = "CommandBarSeparator8"
        Me.CommandBarSeparator8.Name = "CommandBarSeparator8"
        Me.CommandBarSeparator8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.CommandBarSeparator8.UseCompatibleTextRendering = False
        Me.CommandBarSeparator8.VisibleInOverflowMenu = False
        '
        'CommandBarMostanad
        '
        Me.CommandBarMostanad.Dock = System.Windows.Forms.DockStyle.Top
        Me.CommandBarMostanad.Location = New System.Drawing.Point(0, 166)
        Me.CommandBarMostanad.Name = "CommandBarMostanad"
        Me.CommandBarMostanad.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowTopMostanad})
        Me.CommandBarMostanad.Size = New System.Drawing.Size(1356, 35)
        Me.CommandBarMostanad.TabIndex = 7
        CType(Me.CommandBarMostanad.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarElement).DrawFill = True
        '
        'MainForm
        '
        Me.AllowAero = False
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 737)
        Me.Controls.Add(Me.WindowDock)
        Me.Controls.Add(Me.CommandBarMostanad)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadRibbonBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Nothing
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "MainForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.[Auto]
        Me.RootElement.MinSize = New System.Drawing.Size(1460, 743)
        Me.Text = "MainForm"
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WindowDock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WindowDock.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandBarMostanad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend RadRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
    Friend RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend RibbonTabHome As Telerik.WinControls.UI.RibbonTab
    Friend RadRibbonBarGroup1 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend RibTabReports As Telerik.WinControls.UI.RibbonTab
    Friend RibTabTools As Telerik.WinControls.UI.RibbonTab
    Friend RibGFastLink As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend RibonbtnItems As Telerik.WinControls.UI.RadButtonElement
    Friend Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WindowDock As Telerik.WinControls.UI.Docking.RadDock
    Friend DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend RibGOption As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend RibGForms As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RibBtnCustomers As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnVendors As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents RibBtnAddItem As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnItemsTree As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnAddSalesInvoices As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnAddPurchaseInvoices As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnSalesOrders As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnPurchaseOrders As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RGToolsItems As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RibBtnUserSettings As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnCurrencies As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnGroups As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnNotesPay As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnNotesReceive As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnDaily As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadOffice2007ScreenTipElement1 As Telerik.WinControls.UI.RadOffice2007ScreenTipElement
    Friend WithEvents RadOffice2007ScreenTipElement2 As Telerik.WinControls.UI.RadOffice2007ScreenTipElement
    Friend WithEvents RadOffice2007ScreenTipElement3 As Telerik.WinControls.UI.RadOffice2007ScreenTipElement
    Friend WithEvents RadOffice2007ScreenTipElement4 As Telerik.WinControls.UI.RadOffice2007ScreenTipElement
    Friend WithEvents RGToolsCurrency As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RibBtnExit As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnCurrRate As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RGGournalEntry As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RibBtnKoyod As Telerik.WinControls.UI.RadDropDownButtonElement
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents GeneralNotesPayable As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents GeneralNotesReceive As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RibBtnAddAccount As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnChangePass As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnUsers As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnAccounts As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RGToolsAccounts As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RibBtnAccountReport As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnOpenningBalance As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RGReportsDebitCredit As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RibBtnCreditsReport As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnDebitsReport As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnItemsInventory As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RGItemsReports As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RibBtnPurchasePrices As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnQuantity As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnItemMostSell As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RGReportsGeneralReports As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RadButtonElement5 As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnItemPurchase As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnSalesPrices As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents LblUserName As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents stripLblLastDollarRate As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents LblStatusUsername As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator1 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarSeparator2 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents StripLblDateNow As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RibBtnHomeForm As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnUserInfo As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnAbout As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnDatabase As Telerik.WinControls.UI.RadDropDownButtonElement
    Friend WithEvents RadMenuBackup As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuRestore As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents RibBtnInventoryItems As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnRptCheques As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibBtnSalesWin As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents stripLblDollarRateValue As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents CommandBarSeparator3 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents RibBtnItemsSalesWin As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RibButtonDashboard As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents CommandBarRowElement3 As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarRowTopMostanad As Telerik.WinControls.UI.CommandBarRowElement
    Friend WithEvents CommandBarMostanadStripElement As Telerik.WinControls.UI.CommandBarStripElement
    Friend WithEvents BtnCommandBarMostanadNew As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator4 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents BtnCommandBarEdit As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator5 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents BtnCommandBarCloseForm As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator6 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents BtnCommandBarShowHideForm As Telerik.WinControls.UI.CommandBarToggleButton
    Friend WithEvents CommandBarSeparator7 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents BtnCommandBarExitApp As Telerik.WinControls.UI.CommandBarButton
    Friend WithEvents CommandBarSeparator8 As Telerik.WinControls.UI.CommandBarSeparator
    Friend WithEvents CommandBarMostanad As Telerik.WinControls.UI.RadCommandBar
    Friend WithEvents StriplblVersion As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents StriplblVersionInfo As Telerik.WinControls.UI.RadLabelElement
    Friend WithEvents RBTabSetting As Telerik.WinControls.UI.RibbonTab
    Friend WithEvents RGSettingSetting As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RGSettingProgram As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RGSettingUsers As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RGSettingProgrammer As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents RibBtnAllInventory As Telerik.WinControls.UI.RadButtonElement
End Class
