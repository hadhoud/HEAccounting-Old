Module AllPublicVariables

    Public UserID As String
    Public Username As String
    Public FullName As String
    Public UserType As String
    Public UserPassword As String

    'CompanyInfo
    Public CompanyInfoName As String
    Public CompanyLatinName As String
    Public CompanyAddress As String
    Public CompanyLatinAddress As String
    Public CompanyPhone As String
    Public CompanyCellPhone As String
    Public CompanyEmail As String

    'AppSettings 
    Public BoolShowBarcode As Boolean
    Public BoolShowUnits As Boolean
    Public BoolShowUsers As Boolean
    Public BoolShowLang As Boolean
    Public BoolLTRLanguage As Boolean
    Public Lang As String
    Public BoolShowSalesDailyWin As Boolean
    Public BoolShowDashboardForm As Boolean
    Public BoolShowCurrencyRateInStatus As Boolean

    'User Permissions:
    Public BoolShowHomeScreenByUser As Boolean
    Public BoolShowSalesDailyWinScreenByUser As Boolean
    Public BoolShowDashboardScreenByUser As Boolean
    Public BoolShowPurchasingPriceInScreensByUser As Boolean
    Public BoolShowItemsSalesWinReportScreenByUser As Boolean

    'UserSettings

    'Sale Order Setting
    Public BoolShowItemsInSOMainForm As Boolean
    Public BoolShowSOAsWindow As Boolean
    Public DefaultSOStatus As Integer
    Public iSalesOrderDefaultCustomerID As Integer
    Public BoolShowSalesOrdersPrintQuestionAfterSave As Boolean

    'Purchase Order Setting
    Public BoolShowItemsInPOMainForm As Boolean
    Public BoolUpdateItemPurchasingPriceAfterPO As Boolean
    Public BoolUpdateItemSellingPriceAfterPO As Boolean
    Public DefaultPOStatus As Integer
    'Public BoolShowPurchasesOrdersColVendorTitle As Boolean
    'Public BoolShowPurchasesOrdersColCurrencySymb As Boolean

    'Notes Pay Setting
    Public DefaultNPStatus As Integer

    'Notes Receive Setting
    Public DefaultNRStatus As Integer

    'Option Panels setting
    Public BoolOptionPanelTreasury As Boolean
    Public BoolOptionPanelDaily As Boolean
    Public BoolOptionPanelAnalysis As Boolean
    Public BoolOptionPanelSalesProfits As Boolean
    Public BoolOptionPanelItemsSalesProfits As Boolean
    Public BoolOptionPanelItems As Boolean
    Public BoolOptionPanelCustomers As Boolean
    Public BoolOptionPanelVendors As Boolean
    Public BoolOptionPanelSalesOrders As Boolean
    Public BoolOptionPanelPurchasesOrders As Boolean
    Public BoolOptionPanelCreditorsDebitors As Boolean
    Public BoolOptionPanelAllInventory As Boolean

    'Program General Setting
    Public BoolShowProgramAlerts As Boolean
    Public BoolShowDailyPageWhenOpen As Boolean
    Public TimerHomeForm As Integer
    Public TimerDailyForm As Integer
    Public ProgramFormCurrency As Integer
    Public ShowChequesDay As Integer

    'Report Setting
    Public ReportFormCurrency As Integer

    'Customer Setting
    Public BoolAllowCustomerRepetition As Boolean
    Public BoolForcingEnterCustomerLatin As Boolean

    'Vendor Setting
    Public BoolAllowVendorRepetition As Boolean
    Public BoolForcingEnterVendorLatin As Boolean

    'Curency Setting
    Public BoolForcingEnterCurrencyNameLatin As Boolean
    Public BoolForcingEnterCurrencyPartLatin As Boolean
    Public BoolForcingEnterCurrencySymbLatin As Boolean

    'Fields Visible Setting
    'Sales Order
    Public BoolShowSalesOrdersColCustomerTitle As Boolean
    Public BoolShowSalesOrdersColTotalDueLL As Boolean
    Public BoolShowSalesOrdersColTotalDueUSD As Boolean
    Public BoolShowSalesOrdersColDiscountLL As Boolean
    Public BoolShowSalesOrdersColDiscountUSD As Boolean
    Public BoolShowSalesOrdersColSubTotalLL As Boolean
    Public BoolShowSalesOrdersColSubTotalUSD As Boolean
    Public BoolShowSalesOrdersColCurrencySymb As Boolean
    Public BoolShowSalesOrdersColCurrencyRate As Boolean
    Public BoolShowSalesOrdersColStatus As Boolean

    'sales Win
    Public BoolShowSalesWinColTotalDueLL As Boolean
    Public BoolShowSalesWinColTotalDueUSD As Boolean
    Public BoolShowSalesWinColDiscountLL As Boolean
    Public BoolShowSalesWinColDiscountUSD As Boolean
    Public BoolShowSalesWinColSubTotalLL As Boolean
    Public BoolShowSalesWinColSubTotalUSD As Boolean
    Public BoolShowSalesWinColSubTotalPurchasingLL As Boolean
    Public BoolShowSalesWinColSubTotalPurchasingUSD As Boolean
    Public BoolShowSalesWinColColProfitLL As Boolean
    Public BoolShowSalesWinColColProfitUSD As Boolean
    Public BoolShowSalesWinColCurrencyRate As Boolean

    'sales Items Win
    Public BoolShowSalesItemsWinColPurchasingPriceLL As Boolean
    Public BoolShowSalesItemsWinColPurchasingPriceUSD As Boolean
    Public BoolShowSalesItemsWinColSellingPriceLL As Boolean
    Public BoolShowSalesItemsWinColSellingPriceUSD As Boolean
    Public BoolShowSalesItemsWinColTotalPurchasingPriceLL As Boolean
    Public BoolShowSalesItemsWinColTotalPurchasingPriceUSD As Boolean
    Public BoolShowSalesItemsWinColSubTotalSellingPriceLL As Boolean
    Public BoolShowSalesItemsWinColSubTotalSellingPriceUSD As Boolean
    Public BoolShowSalesItemsWinColDiscountLL As Boolean
    Public BoolShowSalesItemsWinColDiscountUSD As Boolean
    Public BoolShowSalesItemsWinColTotalDueSellingPriceLL As Boolean
    Public BoolShowSalesItemsWinColTotalDueSellingPriceUSD As Boolean
    Public BoolShowSalesItemsWinColSellPurchaseDifferenceLL As Boolean
    Public BoolShowSalesItemsWinColSellPurchaseDifferenceUSD As Boolean
    Public BoolShowSalesItemsWinColCurrencyRate As Boolean

    'Purchase Order
    Public BoolShowPurchaseOrdersColVendorTitle As Boolean
    Public BoolShowPurchaseOrdersColSubTotalLL As Boolean
    Public BoolShowPurchaseOrdersColSubTotalUSD As Boolean
    Public BoolShowPurchaseOrdersColDiscountLL As Boolean
    Public BoolShowPurchaseOrdersColDiscountUSD As Boolean
    Public BoolShowPurchaseOrdersColTotalDueLL As Boolean
    Public BoolShowPurchaseOrdersColTotalDueUSD As Boolean
    Public BoolShowPurchaseOrdersColCurrencySymb As Boolean
    Public BoolShowPurchaseOrdersColCurrencyRate As Boolean
    Public BoolShowPurchaseOrdersColStatus As Boolean

    'Add Sales Order
    Public BoolShowAddSalesOrdersColPurchasePrice As Boolean

    'Add Purchase Order
    Public BoolShowAddPurchasesOrdersColPurchasePrice As Boolean

    'Invoice Sales Order
    Public BoolShowInvSaleOrderSubTotalLL As Boolean
    Public BoolShowInvSaleOrderDiscountLL As Boolean
    Public BoolShowInvSaleOrderTotalDueLL As Boolean
    Public BoolShowInvSaleOrderSubTotalUSD As Boolean
    Public BoolShowInvSaleOrderDiscountUSD As Boolean
    Public BoolShowInvSaleOrderTotalDueUSD As Boolean
    Public BoolShowInvSaleOrderCurrencyRate As Boolean
    Public BoolShowInvSaleOrderBalanceLL As Boolean
    Public BoolShowInvSaleOrderBalanceUSD As Boolean

    'Customer Invoices Report
    Public BoolShowCustomerInvSalesOrdersTotalDueUSD As Boolean
    Public BoolShowCustomerInvSalesOrdersTotalDueLL As Boolean
    Public BoolShowCustomerInvSalesOrdersCurrencyRate As Boolean

    'End Fields visible setting

    'General Variable Data
    Public CustomerNameAuto As AutoCompleteStringCollection
    Public ItemsNameAuto As AutoCompleteStringCollection
    Public VendorNameAuto As AutoCompleteStringCollection
    Public GroupNameAuto As AutoCompleteStringCollection

    'General
    Public ToDoRefrech As Boolean = False
    Public Appfont As New Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point)
    Public LinkLabelFont As New Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point)
    Public MenuFont As Font = New Font("Times New Roman", 11, FontStyle.Bold)
    Public Con As HEConstant
    Public LoStrId As New StringlocalizationId
    Public Currencydata As DataTable
    Public UserRolesdt As DataTable

    Public LastDollarCurrencyRate As String
End Module
