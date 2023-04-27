<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserSettings
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserSettings))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.BtnSave = New Telerik.WinControls.UI.RadButton()
        Me.TxtItemPicture = New Telerik.WinControls.UI.RadTextBox()
        Me.PagesSettings = New Telerik.WinControls.UI.RadPageView()
        Me.PageGeneral = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.ChkShowDailyPageWhenOpen = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkShowProgramAlerts = New Telerik.WinControls.UI.RadCheckBox()
        Me.LblTimerHome = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerHome = New System.Windows.Forms.NumericUpDown()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumChequesDay = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel14 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TimerDaily = New System.Windows.Forms.NumericUpDown()
        Me.PageSuppliers = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.ChkAllowCustomerRepetition = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkAllowVendorRepetition = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkForcingEnterVendorLatin = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkForcingEnterCustomerLatin = New Telerik.WinControls.UI.RadCheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PageInvoices = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtSODefaultCustomer = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.TxtCustomerBtn = New Telerik.WinControls.UI.RadButtonElement()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DropSOStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.ChkShowItemsInSOMainForm = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkShowSOInWindow = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkSOShowPrintQuestionAfterSave = New Telerik.WinControls.UI.RadCheckBox()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DropPOStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DropNRStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.FlowLayoutPanel12 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel13 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DropNPStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.ChkShowItemsInPOMainForm = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkUpdateItemPurchasingPriceAfterPO = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkUpdateItemSellingPriceAfterPO = New Telerik.WinControls.UI.RadCheckBox()
        Me.PageOptionsPanel = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.chkOptionSalesProfits = New Telerik.WinControls.UI.RadCheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.chkOptionTreasury = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionDaily = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionAnalysis = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionItems = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionCustomers = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionVendors = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionSalesOrders = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionItemsSalesProfits = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionPurchasesOrders = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionCreditorsDebitors = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionAllInventory = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkOptionQuantityHistory = New Telerik.WinControls.UI.RadCheckBox()
        Me.PageShortcuts = New Telerik.WinControls.UI.RadPageViewPage()
        Me.GridShortcuts = New Telerik.WinControls.UI.RadGridView()
        Me.PageReports = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DropCurrenyReport = New Telerik.WinControls.UI.RadDropDownList()
        Me.PageProgrammer = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel16 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ChkShowLang = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkShowUsers = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkShowBarcode = New Telerik.WinControls.UI.RadCheckBox()
        Me.ChkShowItemsUnits = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkShowSalesDailyWin = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkShowDashboardForm = New Telerik.WinControls.UI.RadCheckBox()
        Me.DropLang = New Telerik.WinControls.UI.RadDropDownList()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.chkShowCurrencyRateInStatus = New Telerik.WinControls.UI.RadCheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PagesSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PagesSettings.SuspendLayout()
        Me.PageGeneral.SuspendLayout()
        Me.TableLayoutPanel10.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowDailyPageWhenOpen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowProgramAlerts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel3.SuspendLayout()
        CType(Me.TimerHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel4.SuspendLayout()
        CType(Me.NumChequesDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel14.SuspendLayout()
        CType(Me.TimerDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageSuppliers.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkAllowCustomerRepetition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkAllowVendorRepetition, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkForcingEnterVendorLatin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkForcingEnterCustomerLatin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageInvoices.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel6.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        CType(Me.TxtSODefaultCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel7.SuspendLayout()
        CType(Me.DropSOStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowItemsInSOMainForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowSOInWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSOShowPrintQuestionAfterSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel8.SuspendLayout()
        Me.FlowLayoutPanel9.SuspendLayout()
        CType(Me.DropPOStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel10.SuspendLayout()
        Me.FlowLayoutPanel11.SuspendLayout()
        CType(Me.DropNRStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel12.SuspendLayout()
        Me.FlowLayoutPanel13.SuspendLayout()
        CType(Me.DropNPStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowItemsInPOMainForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkUpdateItemPurchasingPriceAfterPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkUpdateItemSellingPriceAfterPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageOptionsPanel.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.chkOptionSalesProfits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionTreasury, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionSalesOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionItemsSalesProfits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionPurchasesOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionCreditorsDebitors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionAllInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOptionQuantityHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageShortcuts.SuspendLayout()
        CType(Me.GridShortcuts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridShortcuts.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageReports.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropCurrenyReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PageProgrammer.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel16.SuspendLayout()
        CType(Me.ChkShowLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkShowItemsUnits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowSalesDailyWin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowDashboardForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowCurrencyRateInStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PagesSettings, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.78812!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.21189!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(745, 444)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.01504!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.98496!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnClose, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSave, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtItemPicture, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 394)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(735, 45)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(221, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(104, 36)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSave.Location = New System.Drawing.Point(366, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(103, 36)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Tag = "Save"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TxtItemPicture
        '
        Me.TxtItemPicture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemPicture.Location = New System.Drawing.Point(731, 3)
        Me.TxtItemPicture.Name = "TxtItemPicture"
        Me.TxtItemPicture.ShowClearButton = True
        Me.TxtItemPicture.Size = New System.Drawing.Size(1, 5)
        Me.TxtItemPicture.TabIndex = 37
        Me.TxtItemPicture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemPicture.ThemeName = "Office2010Blue"
        Me.TxtItemPicture.Visible = False
        '
        'PagesSettings
        '
        Me.PagesSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PagesSettings.Controls.Add(Me.PageGeneral)
        Me.PagesSettings.Controls.Add(Me.PageSuppliers)
        Me.PagesSettings.Controls.Add(Me.PageInvoices)
        Me.PagesSettings.Controls.Add(Me.PageOptionsPanel)
        Me.PagesSettings.Controls.Add(Me.PageShortcuts)
        Me.PagesSettings.Controls.Add(Me.PageReports)
        Me.PagesSettings.Controls.Add(Me.PageProgrammer)
        Me.PagesSettings.DefaultPage = Me.PageGeneral
        Me.PagesSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PagesSettings.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagesSettings.Location = New System.Drawing.Point(5, 5)
        Me.PagesSettings.Name = "PagesSettings"
        Me.PagesSettings.PageBackColor = System.Drawing.Color.White
        '
        '
        '
        Me.PagesSettings.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        Me.PagesSettings.SelectedPage = Me.PageGeneral
        Me.PagesSettings.Size = New System.Drawing.Size(735, 369)
        Me.PagesSettings.TabIndex = 0
        Me.PagesSettings.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage
        CType(Me.PagesSettings.GetChildAt(0), Telerik.WinControls.UI.RadPageViewBackstageElement).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.FillHeight
        CType(Me.PagesSettings.GetChildAt(0), Telerik.WinControls.UI.RadPageViewBackstageElement).ItemSpacing = 0
        CType(Me.PagesSettings.GetChildAt(0), Telerik.WinControls.UI.RadPageViewBackstageElement).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight
        CType(Me.PagesSettings.GetChildAt(0), Telerik.WinControls.UI.RadPageViewBackstageElement).DrawFill = True
        CType(Me.PagesSettings.GetChildAt(0), Telerik.WinControls.UI.RadPageViewBackstageElement).DrawBorder = False
        CType(Me.PagesSettings.GetChildAt(0), Telerik.WinControls.UI.RadPageViewBackstageElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.PagesSettings.GetChildAt(0), Telerik.WinControls.UI.RadPageViewBackstageElement).Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.StripViewItemContainer).DrawBorder = False
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.StripViewItemContainer).Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.StripViewItemContainer).MinSize = New System.Drawing.Size(100, 0)
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.StripViewItemLayout).DrawBorder = False
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.StripViewItemLayout).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.StripViewItemLayout).Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).ShouldPaint = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).DrawBorder = False
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).ToolTipText = "Scroll Strip Left"
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).Enabled = False
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).ShouldPaint = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).DrawFill = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).DrawBorder = False
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).DrawBackgroundImage = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).BackColor3 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).BackColor4 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).ShowHorizontalLine = False
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).BorderDashStyle = System.Drawing.Drawing2D.DashStyle.Solid
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).UseDefaultDisabledPaint = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).ShadowDepth = 0
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).ShadowColor = System.Drawing.Color.Empty
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).EnableFocusBorderAnimation = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).BorderHighlightThickness = 0
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).ClipDrawing = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).StretchHorizontally = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).StretchVertically = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RadPageViewLabelElement).ShouldPaint = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RadPageViewLabelElement).DrawFill = False
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RadPageViewLabelElement).DrawBorder = False
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.RadPageViewLabelElement).Text = "عام"
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadPageViewLabelElement).ShouldPaint = True
        CType(Me.PagesSettings.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadPageViewLabelElement).Text = "عام"
        '
        'PageGeneral
        '
        Me.PageGeneral.AutoScroll = True
        Me.PageGeneral.Controls.Add(Me.TableLayoutPanel10)
        Me.PageGeneral.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PageGeneral.ItemSize = New System.Drawing.SizeF(132.0!, 45.0!)
        Me.PageGeneral.Location = New System.Drawing.Point(5, 5)
        Me.PageGeneral.Name = "PageGeneral"
        Me.PageGeneral.Size = New System.Drawing.Size(569, 359)
        Me.PageGeneral.Text = "عام"
        Me.PageGeneral.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 2
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 1
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(569, 359)
        Me.TableLayoutPanel10.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowCurrencyRateInStatus)
        Me.FlowLayoutPanel1.Controls.Add(Me.ChkShowDailyPageWhenOpen)
        Me.FlowLayoutPanel1.Controls.Add(Me.ChkShowProgramAlerts)
        Me.FlowLayoutPanel1.Controls.Add(Me.LblTimerHome)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel14)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(288, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(278, 353)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "عام"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel2.Controls.Add(Me.DropCurrency)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(5, 22)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(270, 30)
        Me.FlowLayoutPanel2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(167, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 27)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "العملة الرئيسية"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropCurrency
        '
        Me.DropCurrency.BackColor = System.Drawing.Color.White
        Me.DropCurrency.DropDownAnimationEnabled = True
        Me.DropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrency.Location = New System.Drawing.Point(3, 3)
        Me.DropCurrency.MaxLength = 65535
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Size = New System.Drawing.Size(158, 24)
        Me.DropCurrency.TabIndex = 23
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'ChkShowDailyPageWhenOpen
        '
        Me.ChkShowDailyPageWhenOpen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowDailyPageWhenOpen.Location = New System.Drawing.Point(53, 86)
        Me.ChkShowDailyPageWhenOpen.Name = "ChkShowDailyPageWhenOpen"
        Me.ChkShowDailyPageWhenOpen.Size = New System.Drawing.Size(222, 22)
        Me.ChkShowDailyPageWhenOpen.TabIndex = 0
        Me.ChkShowDailyPageWhenOpen.Text = "إظهار شاشة اليومية عند فتح البرنامج"
        Me.ChkShowDailyPageWhenOpen.ThemeName = "Office2010Blue"
        '
        'ChkShowProgramAlerts
        '
        Me.ChkShowProgramAlerts.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowProgramAlerts.Location = New System.Drawing.Point(168, 114)
        Me.ChkShowProgramAlerts.Name = "ChkShowProgramAlerts"
        Me.ChkShowProgramAlerts.Size = New System.Drawing.Size(107, 22)
        Me.ChkShowProgramAlerts.TabIndex = 3
        Me.ChkShowProgramAlerts.Text = "عرض التنبيهات"
        Me.ChkShowProgramAlerts.ThemeName = "Office2010Blue"
        '
        'LblTimerHome
        '
        Me.LblTimerHome.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTimerHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LblTimerHome.Location = New System.Drawing.Point(5, 139)
        Me.LblTimerHome.Name = "LblTimerHome"
        Me.LblTimerHome.Size = New System.Drawing.Size(270, 19)
        Me.LblTimerHome.TabIndex = 10
        Me.LblTimerHome.Text = "الصفحة الرئيسية"
        Me.LblTimerHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel3.Controls.Add(Me.TimerHome)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(5, 161)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(270, 32)
        Me.FlowLayoutPanel3.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(186, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "مؤقت التحديث"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerHome
        '
        Me.TimerHome.Location = New System.Drawing.Point(22, 3)
        Me.TimerHome.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.TimerHome.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimerHome.Name = "TimerHome"
        Me.TimerHome.Size = New System.Drawing.Size(158, 26)
        Me.TimerHome.TabIndex = 11
        Me.TimerHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TimerHome.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel4.Controls.Add(Me.NumChequesDay)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(5, 199)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(270, 32)
        Me.FlowLayoutPanel4.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 19)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "الشيكات المستحقة"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumChequesDay
        '
        Me.NumChequesDay.Location = New System.Drawing.Point(22, 3)
        Me.NumChequesDay.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumChequesDay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumChequesDay.Name = "NumChequesDay"
        Me.NumChequesDay.Size = New System.Drawing.Size(135, 26)
        Me.NumChequesDay.TabIndex = 28
        Me.NumChequesDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumChequesDay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(5, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "الصفحة اليومية"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel14
        '
        Me.FlowLayoutPanel14.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel14.Controls.Add(Me.TimerDaily)
        Me.FlowLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel14.Location = New System.Drawing.Point(5, 256)
        Me.FlowLayoutPanel14.Name = "FlowLayoutPanel14"
        Me.FlowLayoutPanel14.Size = New System.Drawing.Size(270, 57)
        Me.FlowLayoutPanel14.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "مؤقت التحديث"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerDaily
        '
        Me.TimerDaily.Location = New System.Drawing.Point(26, 3)
        Me.TimerDaily.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.TimerDaily.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimerDaily.Name = "TimerDaily"
        Me.TimerDaily.Size = New System.Drawing.Size(154, 26)
        Me.TimerDaily.TabIndex = 13
        Me.TimerDaily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TimerDaily.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PageSuppliers
        '
        Me.PageSuppliers.Controls.Add(Me.TableLayoutPanel7)
        Me.PageSuppliers.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageSuppliers.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.PageSuppliers.ItemSize = New System.Drawing.SizeF(132.0!, 45.0!)
        Me.PageSuppliers.Location = New System.Drawing.Point(5, 5)
        Me.PageSuppliers.Name = "PageSuppliers"
        Me.PageSuppliers.Size = New System.Drawing.Size(569, 359)
        Me.PageSuppliers.Text = "العملاء"
        Me.PageSuppliers.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLayoutPanel7.ColumnCount = 6
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.RadLabel7, 0, 4)
        Me.TableLayoutPanel7.Controls.Add(Me.RadLabel8, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.ChkAllowCustomerRepetition, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.ChkAllowVendorRepetition, 0, 5)
        Me.TableLayoutPanel7.Controls.Add(Me.ChkForcingEnterVendorLatin, 0, 6)
        Me.TableLayoutPanel7.Controls.Add(Me.ChkForcingEnterCustomerLatin, 0, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.Panel2, 2, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 9
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(569, 359)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'RadLabel7
        '
        Me.RadLabel7.AutoSize = False
        Me.TableLayoutPanel7.SetColumnSpan(Me.RadLabel7, 2)
        Me.RadLabel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadLabel7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadLabel7.Location = New System.Drawing.Point(356, 96)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(210, 22)
        Me.RadLabel7.TabIndex = 9
        Me.RadLabel7.Text = "الموردين"
        Me.RadLabel7.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.RadLabel7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RadLabel8
        '
        Me.RadLabel8.AutoSize = False
        Me.TableLayoutPanel7.SetColumnSpan(Me.RadLabel8, 2)
        Me.RadLabel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RadLabel8.Location = New System.Drawing.Point(356, 12)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(210, 22)
        Me.RadLabel8.TabIndex = 8
        Me.RadLabel8.Text = "الزبائن"
        Me.RadLabel8.TextAlignment = System.Drawing.ContentAlignment.TopRight
        Me.RadLabel8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'ChkAllowCustomerRepetition
        '
        Me.TableLayoutPanel7.SetColumnSpan(Me.ChkAllowCustomerRepetition, 2)
        Me.ChkAllowCustomerRepetition.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAllowCustomerRepetition.Location = New System.Drawing.Point(407, 40)
        Me.ChkAllowCustomerRepetition.Name = "ChkAllowCustomerRepetition"
        Me.ChkAllowCustomerRepetition.Size = New System.Drawing.Size(159, 22)
        Me.ChkAllowCustomerRepetition.TabIndex = 1
        Me.ChkAllowCustomerRepetition.Text = "السماح بتكرار إسم الزبون"
        Me.ChkAllowCustomerRepetition.ThemeName = "Office2010Blue"
        '
        'ChkAllowVendorRepetition
        '
        Me.TableLayoutPanel7.SetColumnSpan(Me.ChkAllowVendorRepetition, 2)
        Me.ChkAllowVendorRepetition.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAllowVendorRepetition.Location = New System.Drawing.Point(407, 124)
        Me.ChkAllowVendorRepetition.Name = "ChkAllowVendorRepetition"
        Me.ChkAllowVendorRepetition.Size = New System.Drawing.Size(159, 22)
        Me.ChkAllowVendorRepetition.TabIndex = 2
        Me.ChkAllowVendorRepetition.Text = "السماح بتكرار إسم المورد"
        Me.ChkAllowVendorRepetition.ThemeName = "Office2010Blue"
        '
        'ChkForcingEnterVendorLatin
        '
        Me.TableLayoutPanel7.SetColumnSpan(Me.ChkForcingEnterVendorLatin, 2)
        Me.ChkForcingEnterVendorLatin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkForcingEnterVendorLatin.Location = New System.Drawing.Point(357, 152)
        Me.ChkForcingEnterVendorLatin.Name = "ChkForcingEnterVendorLatin"
        Me.ChkForcingEnterVendorLatin.Size = New System.Drawing.Size(209, 22)
        Me.ChkForcingEnterVendorLatin.TabIndex = 5
        Me.ChkForcingEnterVendorLatin.Text = "الإجبار بإدخال الإسم اللاتيني للمورد"
        Me.ChkForcingEnterVendorLatin.ThemeName = "Office2010Blue"
        '
        'ChkForcingEnterCustomerLatin
        '
        Me.TableLayoutPanel7.SetColumnSpan(Me.ChkForcingEnterCustomerLatin, 2)
        Me.ChkForcingEnterCustomerLatin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkForcingEnterCustomerLatin.Location = New System.Drawing.Point(356, 68)
        Me.ChkForcingEnterCustomerLatin.Name = "ChkForcingEnterCustomerLatin"
        Me.ChkForcingEnterCustomerLatin.Size = New System.Drawing.Size(210, 22)
        Me.ChkForcingEnterCustomerLatin.TabIndex = 4
        Me.ChkForcingEnterCustomerLatin.Text = "الإجبار بإدخال الإسم اللاتيني للزبون"
        Me.ChkForcingEnterCustomerLatin.ThemeName = "Office2010Blue"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(349, 3)
        Me.Panel2.Name = "Panel2"
        Me.TableLayoutPanel7.SetRowSpan(Me.Panel2, 8)
        Me.Panel2.Size = New System.Drawing.Size(1, 333)
        Me.Panel2.TabIndex = 15
        '
        'PageInvoices
        '
        Me.PageInvoices.Controls.Add(Me.TableLayoutPanel4)
        Me.PageInvoices.ItemSize = New System.Drawing.SizeF(132.0!, 45.0!)
        Me.PageInvoices.Location = New System.Drawing.Point(5, 5)
        Me.PageInvoices.Name = "PageInvoices"
        Me.PageInvoices.Size = New System.Drawing.Size(569, 359)
        Me.PageInvoices.Text = "الفواتير"
        Me.PageInvoices.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel6, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel8, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(569, 359)
        Me.TableLayoutPanel4.TabIndex = 48
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel6.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel6.Controls.Add(Me.FlowLayoutPanel5)
        Me.FlowLayoutPanel6.Controls.Add(Me.FlowLayoutPanel7)
        Me.FlowLayoutPanel6.Controls.Add(Me.ChkShowItemsInSOMainForm)
        Me.FlowLayoutPanel6.Controls.Add(Me.ChkShowSOInWindow)
        Me.FlowLayoutPanel6.Controls.Add(Me.chkSOShowPrintQuestionAfterSave)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(288, 3)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(278, 353)
        Me.FlowLayoutPanel6.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(273, 19)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "فواتير المبيعات"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.Label21)
        Me.FlowLayoutPanel5.Controls.Add(Me.TxtSODefaultCustomer)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(0, 22)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(273, 32)
        Me.FlowLayoutPanel5.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label21.Location = New System.Drawing.Point(201, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 27)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "الزبون"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSODefaultCustomer
        '
        Me.TxtSODefaultCustomer.AcceptsTab = True
        Me.TxtSODefaultCustomer.AutoSize = False
        Me.TxtSODefaultCustomer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSODefaultCustomer.HideSelection = False
        Me.TxtSODefaultCustomer.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.TxtCustomerBtn})
        Me.TxtSODefaultCustomer.Location = New System.Drawing.Point(27, 3)
        Me.TxtSODefaultCustomer.MaxLength = 65535
        Me.TxtSODefaultCustomer.Name = "TxtSODefaultCustomer"
        Me.TxtSODefaultCustomer.ShowClearButton = True
        Me.TxtSODefaultCustomer.Size = New System.Drawing.Size(168, 24)
        Me.TxtSODefaultCustomer.TabIndex = 54
        Me.TxtSODefaultCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtSODefaultCustomer.ThemeName = "Office2010Blue"
        Me.TxtSODefaultCustomer.WordWrap = False
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
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel7.Controls.Add(Me.DropSOStatus)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(0, 60)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(273, 33)
        Me.FlowLayoutPanel7.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(201, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 24)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "الحالة"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropSOStatus
        '
        Me.DropSOStatus.BackColor = System.Drawing.Color.White
        Me.DropSOStatus.DropDownAnimationEnabled = True
        Me.DropSOStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropSOStatus.Location = New System.Drawing.Point(27, 3)
        Me.DropSOStatus.MaxLength = 65535
        Me.DropSOStatus.Name = "DropSOStatus"
        Me.DropSOStatus.Size = New System.Drawing.Size(168, 24)
        Me.DropSOStatus.TabIndex = 41
        Me.DropSOStatus.Tag = ""
        Me.DropSOStatus.ThemeName = "Office2010Blue"
        '
        'ChkShowItemsInSOMainForm
        '
        Me.ChkShowItemsInSOMainForm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowItemsInSOMainForm.Location = New System.Drawing.Point(69, 99)
        Me.ChkShowItemsInSOMainForm.Name = "ChkShowItemsInSOMainForm"
        Me.ChkShowItemsInSOMainForm.Size = New System.Drawing.Size(204, 22)
        Me.ChkShowItemsInSOMainForm.TabIndex = 0
        Me.ChkShowItemsInSOMainForm.Text = "إظهار الأصناف في فواتير المبيعات"
        Me.ChkShowItemsInSOMainForm.ThemeName = "Office2010Blue"
        '
        'ChkShowSOInWindow
        '
        Me.ChkShowSOInWindow.AutoSize = False
        Me.ChkShowSOInWindow.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowSOInWindow.Location = New System.Drawing.Point(0, 127)
        Me.ChkShowSOInWindow.Name = "ChkShowSOInWindow"
        Me.ChkShowSOInWindow.Size = New System.Drawing.Size(273, 22)
        Me.ChkShowSOInWindow.TabIndex = 7
        Me.ChkShowSOInWindow.Text = "عرض إضافة فاتورة مبيع ضمن المستندات "
        Me.ChkShowSOInWindow.ThemeName = "Office2010Blue"
        '
        'chkSOShowPrintQuestionAfterSave
        '
        Me.chkSOShowPrintQuestionAfterSave.AutoSize = False
        Me.chkSOShowPrintQuestionAfterSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSOShowPrintQuestionAfterSave.Location = New System.Drawing.Point(0, 155)
        Me.chkSOShowPrintQuestionAfterSave.Name = "chkSOShowPrintQuestionAfterSave"
        Me.chkSOShowPrintQuestionAfterSave.Size = New System.Drawing.Size(273, 22)
        Me.chkSOShowPrintQuestionAfterSave.TabIndex = 8
        Me.chkSOShowPrintQuestionAfterSave.Text = "إظهار سؤال الطباعة بعد الحفظ"
        Me.chkSOShowPrintQuestionAfterSave.ThemeName = "Office2010Blue"
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.AutoSize = True
        Me.FlowLayoutPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel8.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel8.Controls.Add(Me.FlowLayoutPanel9)
        Me.FlowLayoutPanel8.Controls.Add(Me.FlowLayoutPanel10)
        Me.FlowLayoutPanel8.Controls.Add(Me.FlowLayoutPanel12)
        Me.FlowLayoutPanel8.Controls.Add(Me.ChkShowItemsInPOMainForm)
        Me.FlowLayoutPanel8.Controls.Add(Me.ChkUpdateItemPurchasingPriceAfterPO)
        Me.FlowLayoutPanel8.Controls.Add(Me.ChkUpdateItemSellingPriceAfterPO)
        Me.FlowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(279, 353)
        Me.FlowLayoutPanel8.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(14, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(260, 22)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "فواتير الشراء"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel9
        '
        Me.FlowLayoutPanel9.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel9.Controls.Add(Me.DropPOStatus)
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(14, 25)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(260, 29)
        Me.FlowLayoutPanel9.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(188, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 30)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "الحالة"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropPOStatus
        '
        Me.DropPOStatus.AutoSize = False
        Me.DropPOStatus.BackColor = System.Drawing.Color.White
        Me.DropPOStatus.DropDownAnimationEnabled = True
        Me.DropPOStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropPOStatus.Location = New System.Drawing.Point(14, 3)
        Me.DropPOStatus.MaxLength = 65535
        Me.DropPOStatus.Name = "DropPOStatus"
        Me.DropPOStatus.Size = New System.Drawing.Size(168, 24)
        Me.DropPOStatus.TabIndex = 42
        Me.DropPOStatus.Tag = ""
        Me.DropPOStatus.ThemeName = "Office2010Blue"
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel10.Controls.Add(Me.FlowLayoutPanel11)
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(7, 60)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(267, 66)
        Me.FlowLayoutPanel10.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(260, 22)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "سندات القبض"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel11
        '
        Me.FlowLayoutPanel11.Controls.Add(Me.Label15)
        Me.FlowLayoutPanel11.Controls.Add(Me.DropNRStatus)
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(4, 25)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(260, 35)
        Me.FlowLayoutPanel11.TabIndex = 53
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(188, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 30)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "الحالة"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropNRStatus
        '
        Me.DropNRStatus.AutoSize = False
        Me.DropNRStatus.BackColor = System.Drawing.Color.White
        Me.DropNRStatus.DropDownAnimationEnabled = True
        Me.DropNRStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropNRStatus.Location = New System.Drawing.Point(14, 3)
        Me.DropNRStatus.MaxLength = 65535
        Me.DropNRStatus.Name = "DropNRStatus"
        Me.DropNRStatus.Size = New System.Drawing.Size(168, 24)
        Me.DropNRStatus.TabIndex = 48
        Me.DropNRStatus.Tag = ""
        Me.DropNRStatus.ThemeName = "Office2010Blue"
        '
        'FlowLayoutPanel12
        '
        Me.FlowLayoutPanel12.AutoSize = True
        Me.FlowLayoutPanel12.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel12.Controls.Add(Me.FlowLayoutPanel13)
        Me.FlowLayoutPanel12.Location = New System.Drawing.Point(8, 132)
        Me.FlowLayoutPanel12.Name = "FlowLayoutPanel12"
        Me.FlowLayoutPanel12.Size = New System.Drawing.Size(266, 63)
        Me.FlowLayoutPanel12.TabIndex = 53
        '
        'Label14
        '
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(260, 22)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "سندات الصرف"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel13
        '
        Me.FlowLayoutPanel13.Controls.Add(Me.Label16)
        Me.FlowLayoutPanel13.Controls.Add(Me.DropNPStatus)
        Me.FlowLayoutPanel13.Location = New System.Drawing.Point(3, 25)
        Me.FlowLayoutPanel13.Name = "FlowLayoutPanel13"
        Me.FlowLayoutPanel13.Size = New System.Drawing.Size(260, 35)
        Me.FlowLayoutPanel13.TabIndex = 50
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(188, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 30)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "الحالة"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropNPStatus
        '
        Me.DropNPStatus.AutoSize = False
        Me.DropNPStatus.BackColor = System.Drawing.Color.White
        Me.DropNPStatus.DropDownAnimationEnabled = True
        Me.DropNPStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropNPStatus.Location = New System.Drawing.Point(14, 3)
        Me.DropNPStatus.MaxLength = 65535
        Me.DropNPStatus.Name = "DropNPStatus"
        Me.DropNPStatus.Size = New System.Drawing.Size(168, 24)
        Me.DropNPStatus.TabIndex = 50
        Me.DropNPStatus.Tag = ""
        Me.DropNPStatus.ThemeName = "Office2010Blue"
        '
        'ChkShowItemsInPOMainForm
        '
        Me.ChkShowItemsInPOMainForm.AutoSize = False
        Me.ChkShowItemsInPOMainForm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowItemsInPOMainForm.Location = New System.Drawing.Point(14, 201)
        Me.ChkShowItemsInPOMainForm.Name = "ChkShowItemsInPOMainForm"
        Me.ChkShowItemsInPOMainForm.Size = New System.Drawing.Size(260, 22)
        Me.ChkShowItemsInPOMainForm.TabIndex = 1
        Me.ChkShowItemsInPOMainForm.Text = "عرض الأصناف في فواتير المشتريات"
        Me.ChkShowItemsInPOMainForm.ThemeName = "Office2010Blue"
        '
        'ChkUpdateItemPurchasingPriceAfterPO
        '
        Me.ChkUpdateItemPurchasingPriceAfterPO.AccessibleName = ""
        Me.ChkUpdateItemPurchasingPriceAfterPO.AutoSize = False
        Me.ChkUpdateItemPurchasingPriceAfterPO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUpdateItemPurchasingPriceAfterPO.Location = New System.Drawing.Point(14, 229)
        Me.ChkUpdateItemPurchasingPriceAfterPO.Name = "ChkUpdateItemPurchasingPriceAfterPO"
        Me.ChkUpdateItemPurchasingPriceAfterPO.Size = New System.Drawing.Size(260, 22)
        Me.ChkUpdateItemPurchasingPriceAfterPO.TabIndex = 2
        Me.ChkUpdateItemPurchasingPriceAfterPO.Text = "تعديل سعر شراء الصنف بعد فاتورة الشراء"
        Me.ChkUpdateItemPurchasingPriceAfterPO.ThemeName = "Office2010Blue"
        '
        'ChkUpdateItemSellingPriceAfterPO
        '
        Me.ChkUpdateItemSellingPriceAfterPO.AutoSize = False
        Me.ChkUpdateItemSellingPriceAfterPO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUpdateItemSellingPriceAfterPO.Location = New System.Drawing.Point(14, 257)
        Me.ChkUpdateItemSellingPriceAfterPO.Name = "ChkUpdateItemSellingPriceAfterPO"
        Me.ChkUpdateItemSellingPriceAfterPO.Size = New System.Drawing.Size(260, 22)
        Me.ChkUpdateItemSellingPriceAfterPO.TabIndex = 3
        Me.ChkUpdateItemSellingPriceAfterPO.Text = "تعديل سعر مبيع الصنف بعد فاتورة الشراء"
        Me.ChkUpdateItemSellingPriceAfterPO.ThemeName = "Office2010Blue"
        '
        'PageOptionsPanel
        '
        Me.PageOptionsPanel.Controls.Add(Me.TableLayoutPanel6)
        Me.PageOptionsPanel.ItemSize = New System.Drawing.SizeF(132.0!, 45.0!)
        Me.PageOptionsPanel.Location = New System.Drawing.Point(5, 5)
        Me.PageOptionsPanel.Name = "PageOptionsPanel"
        Me.PageOptionsPanel.Size = New System.Drawing.Size(569, 359)
        Me.PageOptionsPanel.Text = "خانة الخيارات والبحث"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TableLayoutPanel9, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 359.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(569, 359)
        Me.TableLayoutPanel6.TabIndex = 0
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 2
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionSalesProfits, 0, 4)
        Me.TableLayoutPanel9.Controls.Add(Me.Label23, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionTreasury, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionDaily, 0, 2)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionAnalysis, 0, 3)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionItems, 0, 6)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionCustomers, 0, 7)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionVendors, 0, 8)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionSalesOrders, 0, 9)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionItemsSalesProfits, 0, 5)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionPurchasesOrders, 0, 10)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionCreditorsDebitors, 0, 11)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionAllInventory, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.chkOptionQuantityHistory, 1, 2)
        Me.TableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(288, 3)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 13
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(278, 353)
        Me.TableLayoutPanel9.TabIndex = 4
        '
        'chkOptionSalesProfits
        '
        Me.chkOptionSalesProfits.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionSalesProfits.Location = New System.Drawing.Point(177, 106)
        Me.chkOptionSalesProfits.Name = "chkOptionSalesProfits"
        Me.chkOptionSalesProfits.Size = New System.Drawing.Size(98, 22)
        Me.chkOptionSalesProfits.TabIndex = 6
        Me.chkOptionSalesProfits.Text = "أرباح المبيعات"
        Me.chkOptionSalesProfits.ThemeName = "Office2010Blue"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.TableLayoutPanel9.SetColumnSpan(Me.Label23, 2)
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(3, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(272, 19)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "إظهار خانة الخيارات بشكل تلقائي"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkOptionTreasury
        '
        Me.chkOptionTreasury.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionTreasury.Location = New System.Drawing.Point(163, 22)
        Me.chkOptionTreasury.Name = "chkOptionTreasury"
        Me.chkOptionTreasury.Size = New System.Drawing.Size(112, 22)
        Me.chkOptionTreasury.TabIndex = 3
        Me.chkOptionTreasury.Text = "الصفحة الرئيسية"
        Me.chkOptionTreasury.ThemeName = "Office2010Blue"
        '
        'chkOptionDaily
        '
        Me.chkOptionDaily.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionDaily.Location = New System.Drawing.Point(171, 50)
        Me.chkOptionDaily.Name = "chkOptionDaily"
        Me.chkOptionDaily.Size = New System.Drawing.Size(104, 22)
        Me.chkOptionDaily.TabIndex = 4
        Me.chkOptionDaily.Text = "الصفحة اليومية"
        Me.chkOptionDaily.ThemeName = "Office2010Blue"
        '
        'chkOptionAnalysis
        '
        Me.chkOptionAnalysis.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionAnalysis.Location = New System.Drawing.Point(167, 78)
        Me.chkOptionAnalysis.Name = "chkOptionAnalysis"
        Me.chkOptionAnalysis.Size = New System.Drawing.Size(108, 22)
        Me.chkOptionAnalysis.TabIndex = 5
        Me.chkOptionAnalysis.Text = "صفحة التحليلات"
        Me.chkOptionAnalysis.ThemeName = "Office2010Blue"
        '
        'chkOptionItems
        '
        Me.chkOptionItems.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionItems.Location = New System.Drawing.Point(208, 162)
        Me.chkOptionItems.Name = "chkOptionItems"
        Me.chkOptionItems.Size = New System.Drawing.Size(67, 22)
        Me.chkOptionItems.TabIndex = 7
        Me.chkOptionItems.Text = "الأصناف"
        Me.chkOptionItems.ThemeName = "Office2010Blue"
        '
        'chkOptionCustomers
        '
        Me.chkOptionCustomers.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionCustomers.Location = New System.Drawing.Point(217, 190)
        Me.chkOptionCustomers.Name = "chkOptionCustomers"
        Me.chkOptionCustomers.Size = New System.Drawing.Size(58, 22)
        Me.chkOptionCustomers.TabIndex = 8
        Me.chkOptionCustomers.Text = "الزبائن"
        Me.chkOptionCustomers.ThemeName = "Office2010Blue"
        '
        'chkOptionVendors
        '
        Me.chkOptionVendors.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionVendors.Location = New System.Drawing.Point(205, 218)
        Me.chkOptionVendors.Name = "chkOptionVendors"
        Me.chkOptionVendors.Size = New System.Drawing.Size(70, 22)
        Me.chkOptionVendors.TabIndex = 9
        Me.chkOptionVendors.Text = "الموردين"
        Me.chkOptionVendors.ThemeName = "Office2010Blue"
        '
        'chkOptionSalesOrders
        '
        Me.chkOptionSalesOrders.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionSalesOrders.Location = New System.Drawing.Point(173, 246)
        Me.chkOptionSalesOrders.Name = "chkOptionSalesOrders"
        Me.chkOptionSalesOrders.Size = New System.Drawing.Size(102, 22)
        Me.chkOptionSalesOrders.TabIndex = 10
        Me.chkOptionSalesOrders.Text = "فواتير المبيعات"
        Me.chkOptionSalesOrders.ThemeName = "Office2010Blue"
        '
        'chkOptionItemsSalesProfits
        '
        Me.chkOptionItemsSalesProfits.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionItemsSalesProfits.Location = New System.Drawing.Point(143, 134)
        Me.chkOptionItemsSalesProfits.Name = "chkOptionItemsSalesProfits"
        Me.chkOptionItemsSalesProfits.Size = New System.Drawing.Size(132, 22)
        Me.chkOptionItemsSalesProfits.TabIndex = 12
        Me.chkOptionItemsSalesProfits.Text = "أرباح مبيعات أصناف"
        Me.chkOptionItemsSalesProfits.ThemeName = "Office2010Blue"
        '
        'chkOptionPurchasesOrders
        '
        Me.chkOptionPurchasesOrders.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionPurchasesOrders.Location = New System.Drawing.Point(162, 274)
        Me.chkOptionPurchasesOrders.Name = "chkOptionPurchasesOrders"
        Me.chkOptionPurchasesOrders.Size = New System.Drawing.Size(113, 22)
        Me.chkOptionPurchasesOrders.TabIndex = 11
        Me.chkOptionPurchasesOrders.Text = "فواتير المشتريات"
        Me.chkOptionPurchasesOrders.ThemeName = "Office2010Blue"
        '
        'chkOptionCreditorsDebitors
        '
        Me.chkOptionCreditorsDebitors.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionCreditorsDebitors.Location = New System.Drawing.Point(168, 302)
        Me.chkOptionCreditorsDebitors.Name = "chkOptionCreditorsDebitors"
        Me.chkOptionCreditorsDebitors.Size = New System.Drawing.Size(107, 22)
        Me.chkOptionCreditorsDebitors.TabIndex = 12
        Me.chkOptionCreditorsDebitors.Text = "مدينون / دائنون"
        Me.chkOptionCreditorsDebitors.ThemeName = "Office2010Blue"
        '
        'chkOptionAllInventory
        '
        Me.chkOptionAllInventory.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionAllInventory.Location = New System.Drawing.Point(71, 22)
        Me.chkOptionAllInventory.Name = "chkOptionAllInventory"
        Me.chkOptionAllInventory.Size = New System.Drawing.Size(65, 22)
        Me.chkOptionAllInventory.TabIndex = 13
        Me.chkOptionAllInventory.Text = "الجردات"
        Me.chkOptionAllInventory.ThemeName = "Office2010Blue"
        '
        'chkOptionQuantityHistory
        '
        Me.chkOptionQuantityHistory.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOptionQuantityHistory.Location = New System.Drawing.Point(50, 50)
        Me.chkOptionQuantityHistory.Name = "chkOptionQuantityHistory"
        Me.chkOptionQuantityHistory.Size = New System.Drawing.Size(86, 22)
        Me.chkOptionQuantityHistory.TabIndex = 14
        Me.chkOptionQuantityHistory.Text = "حركة الكمية"
        Me.chkOptionQuantityHistory.ThemeName = "Office2010Blue"
        '
        'PageShortcuts
        '
        Me.PageShortcuts.Controls.Add(Me.GridShortcuts)
        Me.PageShortcuts.ItemSize = New System.Drawing.SizeF(132.0!, 45.0!)
        Me.PageShortcuts.Location = New System.Drawing.Point(5, 5)
        Me.PageShortcuts.Name = "PageShortcuts"
        Me.PageShortcuts.Size = New System.Drawing.Size(569, 359)
        Me.PageShortcuts.Text = "الإختصارات"
        Me.PageShortcuts.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridShortcuts
        '
        Me.GridShortcuts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridShortcuts.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.GridShortcuts.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridShortcuts.Name = "GridShortcuts"
        Me.GridShortcuts.Size = New System.Drawing.Size(569, 359)
        Me.GridShortcuts.TabIndex = 0
        '
        'PageReports
        '
        Me.PageReports.Controls.Add(Me.TableLayoutPanel8)
        Me.PageReports.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageReports.ItemSize = New System.Drawing.SizeF(132.0!, 45.0!)
        Me.PageReports.Location = New System.Drawing.Point(5, 5)
        Me.PageReports.Name = "PageReports"
        Me.PageReports.Size = New System.Drawing.Size(569, 359)
        Me.PageReports.Text = "تقارير"
        Me.PageReports.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLayoutPanel8.ColumnCount = 6
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.NumericUpDown1, 1, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.DropCurrenyReport, 1, 1)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 11
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(569, 359)
        Me.TableLayoutPanel8.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(456, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "العملة"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NumericUpDown1.Location = New System.Drawing.Point(292, 31)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(158, 26)
        Me.NumericUpDown1.TabIndex = 11
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(456, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 32)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "مؤقت التحديث"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(285, 3)
        Me.Panel3.Name = "Panel3"
        Me.TableLayoutPanel8.SetRowSpan(Me.Panel3, 11)
        Me.Panel3.Size = New System.Drawing.Size(1, 353)
        Me.Panel3.TabIndex = 15
        '
        'DropCurrenyReport
        '
        Me.DropCurrenyReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropCurrenyReport.DropDownAnimationEnabled = True
        Me.DropCurrenyReport.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrenyReport.Location = New System.Drawing.Point(292, 12)
        Me.DropCurrenyReport.Name = "DropCurrenyReport"
        Me.DropCurrenyReport.Size = New System.Drawing.Size(158, 13)
        Me.DropCurrenyReport.TabIndex = 25
        Me.DropCurrenyReport.ThemeName = "Office2010Blue"
        '
        'PageProgrammer
        '
        Me.PageProgrammer.Controls.Add(Me.TableLayoutPanel5)
        Me.PageProgrammer.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.PageProgrammer.ItemSize = New System.Drawing.SizeF(132.0!, 45.0!)
        Me.PageProgrammer.Location = New System.Drawing.Point(5, 5)
        Me.PageProgrammer.Name = "PageProgrammer"
        Me.PageProgrammer.Size = New System.Drawing.Size(569, 359)
        Me.PageProgrammer.Text = "المبرمج"
        Me.PageProgrammer.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.FlowLayoutPanel16, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(569, 359)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'FlowLayoutPanel16
        '
        Me.FlowLayoutPanel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel16.Controls.Add(Me.Label22)
        Me.FlowLayoutPanel16.Controls.Add(Me.ChkShowLang)
        Me.FlowLayoutPanel16.Controls.Add(Me.ChkShowUsers)
        Me.FlowLayoutPanel16.Controls.Add(Me.ChkShowBarcode)
        Me.FlowLayoutPanel16.Controls.Add(Me.ChkShowItemsUnits)
        Me.FlowLayoutPanel16.Controls.Add(Me.chkShowSalesDailyWin)
        Me.FlowLayoutPanel16.Controls.Add(Me.chkShowDashboardForm)
        Me.FlowLayoutPanel16.Controls.Add(Me.DropLang)
        Me.FlowLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel16.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel16.Location = New System.Drawing.Point(288, 3)
        Me.FlowLayoutPanel16.Name = "FlowLayoutPanel16"
        Me.FlowLayoutPanel16.Size = New System.Drawing.Size(278, 353)
        Me.FlowLayoutPanel16.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(34, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(239, 23)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "البرنامج"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkShowLang
        '
        Me.ChkShowLang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowLang.Location = New System.Drawing.Point(185, 26)
        Me.ChkShowLang.Name = "ChkShowLang"
        Me.ChkShowLang.Size = New System.Drawing.Size(88, 22)
        Me.ChkShowLang.TabIndex = 0
        Me.ChkShowLang.Text = "إظهار اللغات"
        Me.ChkShowLang.ThemeName = "Office2010Blue"
        '
        'ChkShowUsers
        '
        Me.ChkShowUsers.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowUsers.Location = New System.Drawing.Point(153, 54)
        Me.ChkShowUsers.Name = "ChkShowUsers"
        Me.ChkShowUsers.Size = New System.Drawing.Size(120, 22)
        Me.ChkShowUsers.TabIndex = 1
        Me.ChkShowUsers.Text = "إظهار المستخدمين"
        Me.ChkShowUsers.ThemeName = "Office2010Blue"
        '
        'ChkShowBarcode
        '
        Me.ChkShowBarcode.AccessibleName = ""
        Me.ChkShowBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowBarcode.Location = New System.Drawing.Point(175, 82)
        Me.ChkShowBarcode.Name = "ChkShowBarcode"
        Me.ChkShowBarcode.Size = New System.Drawing.Size(98, 22)
        Me.ChkShowBarcode.TabIndex = 2
        Me.ChkShowBarcode.Text = "إظهار الباركود"
        Me.ChkShowBarcode.ThemeName = "Office2010Blue"
        '
        'ChkShowItemsUnits
        '
        Me.ChkShowItemsUnits.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShowItemsUnits.Location = New System.Drawing.Point(131, 110)
        Me.ChkShowItemsUnits.Name = "ChkShowItemsUnits"
        Me.ChkShowItemsUnits.Size = New System.Drawing.Size(142, 22)
        Me.ChkShowItemsUnits.TabIndex = 3
        Me.ChkShowItemsUnits.Text = "إظهار وحدات الأصناف"
        Me.ChkShowItemsUnits.ThemeName = "Office2010Blue"
        '
        'chkShowSalesDailyWin
        '
        Me.chkShowSalesDailyWin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowSalesDailyWin.Location = New System.Drawing.Point(105, 138)
        Me.chkShowSalesDailyWin.Name = "chkShowSalesDailyWin"
        Me.chkShowSalesDailyWin.Size = New System.Drawing.Size(168, 22)
        Me.chkShowSalesDailyWin.TabIndex = 4
        Me.chkShowSalesDailyWin.Text = "إظهار شاشة أرباح المبيعات"
        Me.chkShowSalesDailyWin.ThemeName = "Office2010Blue"
        '
        'chkShowDashboardForm
        '
        Me.chkShowDashboardForm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowDashboardForm.Location = New System.Drawing.Point(133, 166)
        Me.chkShowDashboardForm.Name = "chkShowDashboardForm"
        Me.chkShowDashboardForm.Size = New System.Drawing.Size(140, 22)
        Me.chkShowDashboardForm.TabIndex = 6
        Me.chkShowDashboardForm.Text = "إظهار شاشة التحليلات"
        Me.chkShowDashboardForm.ThemeName = "Office2010Blue"
        '
        'DropLang
        '
        Me.DropLang.AutoSize = False
        Me.DropLang.BackColor = System.Drawing.Color.White
        Me.DropLang.DropDownAnimationEnabled = True
        Me.DropLang.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropLang.Location = New System.Drawing.Point(105, 194)
        Me.DropLang.MaxLength = 65535
        Me.DropLang.Name = "DropLang"
        Me.DropLang.Size = New System.Drawing.Size(168, 24)
        Me.DropLang.TabIndex = 41
        Me.DropLang.Tag = ""
        Me.DropLang.ThemeName = "Office2010Blue"
        '
        'chkShowCurrencyRateInStatus
        '
        Me.chkShowCurrencyRateInStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowCurrencyRateInStatus.Location = New System.Drawing.Point(51, 58)
        Me.chkShowCurrencyRateInStatus.Name = "chkShowCurrencyRateInStatus"
        Me.chkShowCurrencyRateInStatus.Size = New System.Drawing.Size(224, 22)
        Me.chkShowCurrencyRateInStatus.TabIndex = 28
        Me.chkShowCurrencyRateInStatus.Text = "إظهار سعر الصرف في شريط البرنامج"
        Me.chkShowCurrencyRateInStatus.ThemeName = "Office2010Blue"
        '
        'UserSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 444)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserSettings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إعدادات المستخدم"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PagesSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PagesSettings.ResumeLayout(False)
        Me.PageGeneral.ResumeLayout(False)
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowDailyPageWhenOpen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowProgramAlerts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        CType(Me.TimerHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        CType(Me.NumChequesDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel14.ResumeLayout(False)
        Me.FlowLayoutPanel14.PerformLayout()
        CType(Me.TimerDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageSuppliers.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkAllowCustomerRepetition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkAllowVendorRepetition, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkForcingEnterVendorLatin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkForcingEnterCustomerLatin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageInvoices.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel6.ResumeLayout(False)
        Me.FlowLayoutPanel6.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        CType(Me.TxtSODefaultCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        CType(Me.DropSOStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowItemsInSOMainForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowSOInWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSOShowPrintQuestionAfterSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel8.ResumeLayout(False)
        Me.FlowLayoutPanel8.PerformLayout()
        Me.FlowLayoutPanel9.ResumeLayout(False)
        CType(Me.DropPOStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel10.ResumeLayout(False)
        Me.FlowLayoutPanel11.ResumeLayout(False)
        CType(Me.DropNRStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel12.ResumeLayout(False)
        Me.FlowLayoutPanel13.ResumeLayout(False)
        CType(Me.DropNPStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowItemsInPOMainForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkUpdateItemPurchasingPriceAfterPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkUpdateItemSellingPriceAfterPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageOptionsPanel.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.chkOptionSalesProfits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionTreasury, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionDaily, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionSalesOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionItemsSalesProfits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionPurchasesOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionCreditorsDebitors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionAllInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOptionQuantityHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageShortcuts.ResumeLayout(False)
        CType(Me.GridShortcuts.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridShortcuts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageReports.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropCurrenyReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PageProgrammer.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel16.ResumeLayout(False)
        Me.FlowLayoutPanel16.PerformLayout()
        CType(Me.ChkShowLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkShowItemsUnits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowSalesDailyWin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowDashboardForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowCurrencyRateInStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtItemPicture As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents PagesSettings As Telerik.WinControls.UI.RadPageView
    Friend WithEvents PageGeneral As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents ChkShowDailyPageWhenOpen As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkShowProgramAlerts As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents LblTimerHome As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TimerHome As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TimerDaily As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumChequesDay As NumericUpDown
    Friend WithEvents PageSuppliers As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ChkAllowCustomerRepetition As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkAllowVendorRepetition As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkForcingEnterVendorLatin As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkForcingEnterCustomerLatin As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PageInvoices As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents Label11 As Label
    Friend WithEvents ChkShowItemsInSOMainForm As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkShowSOInWindow As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkSOShowPrintQuestionAfterSave As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtSODefaultCustomer As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents TxtCustomerBtn As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents DropSOStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents Label12 As Label
    Friend WithEvents ChkShowItemsInPOMainForm As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkUpdateItemPurchasingPriceAfterPO As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkUpdateItemSellingPriceAfterPO As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents DropPOStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Friend WithEvents Label13 As Label
    Friend WithEvents FlowLayoutPanel11 As FlowLayoutPanel
    Friend WithEvents Label15 As Label
    Friend WithEvents DropNRStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents FlowLayoutPanel12 As FlowLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents FlowLayoutPanel13 As FlowLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents DropNPStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents PageOptionsPanel As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents chkOptionSalesProfits As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents chkOptionTreasury As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkOptionDaily As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkOptionAnalysis As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkOptionItems As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkOptionCustomers As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkOptionVendors As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkOptionSalesOrders As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkOptionItemsSalesProfits As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkOptionPurchasesOrders As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkOptionCreditorsDebitors As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkOptionAllInventory As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents PageShortcuts As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents GridShortcuts As Telerik.WinControls.UI.RadGridView
    Friend WithEvents PageReports As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DropCurrenyReport As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents PageProgrammer As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel16 As FlowLayoutPanel
    Friend WithEvents Label22 As Label
    Friend WithEvents ChkShowLang As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkShowUsers As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkShowBarcode As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents ChkShowItemsUnits As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkShowSalesDailyWin As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkShowDashboardForm As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents DropLang As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel14 As FlowLayoutPanel
    Friend WithEvents chkOptionQuantityHistory As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkShowCurrencyRateInStatus As Telerik.WinControls.UI.RadCheckBox
End Class

