Module AllPublicVariables

    Public UserID As String
    Public Username As String
    Public FullName As String
    Public UserType As String

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
    Public BoolShowAddSalesOrdersColPurchasePrice As Boolean
    Public BoolShowSalesOrdersColCustomerTitle As Boolean
    Public BoolShowSalesOrdersColCurrencySymb As Boolean
    Public iSalesOrderDefaultCustomerID As Integer
    Public BoolShowSalesOrdersPrintQuestionAfterSave As Boolean

    'Purchase Order Setting
    Public BoolShowItemsInPOMainForm As Boolean
    Public BoolUpdateItemPurchasingPriceAfterPO As Boolean
    Public BoolUpdateItemSellingPriceAfterPO As Boolean
    Public DefaultPOStatus As Integer
    Public BoolShowAddPurchasesOrdersColPurchasePrice As Boolean
    Public BoolShowPurchasesOrdersColVendorTitle As Boolean
    Public BoolShowPurchasesOrdersColCurrencySymb As Boolean

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

    'Program General Setting
    Public BoolShowProgramAlerts As Boolean
    Public BoolShowDailyPageWhenOpen As Boolean
    Public TimerHomeForm As Integer
    Public TimerDailyForm As Integer
    Public HomeFormCurrency As Integer
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
