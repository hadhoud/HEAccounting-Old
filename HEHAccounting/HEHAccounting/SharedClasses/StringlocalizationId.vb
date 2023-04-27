Public Class StringlocalizationId

    'Ribbon
    Public lblHome As String
    Public LblQuicklinks As String
    Public LblDocument As String
    Public lblTools As String
    Public lblReports As String
    Public LblShow As String

    'Command Bar
    Public LblFiltering As String
    Public LblReset As String
    Public LblNew As String
    Public LblClose As String
    Public LblEdit As String
    Public LblAdd As String
    Public LblRefrech As String
    Public LblSaveNew As String
    Public LblSave As String
    Public LblDelete As String
    Public Password_Encryption As String

    'In All Code 
    Public LblName As String
    Public LblCode As String
    Public LblAll As String
    Public LblDate As String
    Public LblInvID As String
    Public LblFrom As String
    Public LblTo As String
    Public LblNum As String
    Public LblType As String
    Public LblCurrency As String
    Public LblCurrencyRate As String
    Public LblPrint As String
    Public LblPrintInvoiceAFour As String
    Public LblPrintInvoicesReportAFour As String

    Public LblReference As String
    Public LblDueDate As String
    Public LblForms As String
    Public LblProgramName As String
    Public LblLatinProgramName As String
    Public LblCheckNumber As String
    Public lblBalance As String
    Public LblPay As String

    'Accounts
    Public LblAddAccounts As String
    Public LblAccounts As String
    Public LblOpenningBalance As String
    Public LblAccountStatement As String

    'Lang
    Public LangEn As String
    Public LangAr As String

    'Daily
    Public LblDaily As String
    Public LblCustomerVendor As String
    Public LblAllDate As String

    'Home
    Public LblGeneral As String
    Public LblNotes As String

    'Dashboard
    Public LblDashboard As String
    Public str_Sales_Total As String
    Public str_latin_Sales_Total As String
    Public str_Sales_Profits As String
    Public str_latin_Proftis_Total As String

    'Profit
    Public lblSalesProfit As String
    Public lblProfit As String
    'Currencies
    Public LblCurrencies As String
    Public LblAddCurreny As String
    Public LblCurrenciesRate As String
    Public LblDollarRate As String

    'Customers - Vendors
    Public lblCustomers As String
    Public lblCustomer As String
    Public LblEditCustomer As String
    Public LblAddCustomer As String
    Public LblTown As String
    Public LblAddress As String
    Public LblPhone As String
    Public LblCellPhone As String
    Public lblVendors As String
    Public lblVendor As String
    Public LblEditVendor As String
    Public LblAddVendor As String
    Public LblCompany As String
    Public LblTitle As String

    'Groups - ITems - Addnew ITems
    Public LblItemTree As String
    Public LblAddItem As String
    Public LblAddNewItem As String
    Public LblPageGeneral As String
    Public LblPageOption As String
    Public LblItems As String
    Public LblItemName As String
    Public LblItemID As String
    Public LblBarcode As String
    Public LblSellingPrice As String   'سعر البيع
    Public LblPurchasingPrice As String  'سعر الشراء
    Public LblQuantity As String
    Public LblMinQuantity As String
    Public LblPercent As String
    Public LblLatinName As String
    Public LblExpiredDate As String
    Public LblIsitemHasExpiredDate As String
    Public LblAnalertbeforetheexpiration As String
    Public LblAnalertInMinQty As String
    Public LblAnalertInMinQtyInSell As String
    Public LblGroups As String
    Public LblGroupName As String
    Public LblGroup As String
    Public LblNote As String
    Public LblInventoryItems As String
    Public LblAllInventory As String

    'Purchase ORder sales Order
    Public LblAddPO As String
    Public lblPurchaseOrder As String
    Public lblPurchasesOrders As String
    Public LblPurchase As String
    Public LblSaleOrder As String
    Public LblSalesOrders As String
    Public LblAddSO As String
    Public LblInvType As String
    Public LblSales As String
    Public LblReturn As String
    Public LblCash As String
    Public LblDebt As String
    Public LblStatus As String
    Public LblSubTotal As String
    Public LblDiscount As String
    Public LblDueTotal As String
    Public LblPayment As String
    Public LblCheck As String
    Public LblAllPayments As String

    Public lblCashSales As String
    Public lblDebtSales As String
    Public lblReturnSalesCash As String
    Public lblReturnSalesDebt As String
    Public lblReturnSales As String

    Public LblPurchases As String
    Public lblCashPurchases As String
    Public lblDebtPurchases As String
    Public lblReturnPurchasesCash As String
    Public lblReturnPurchasesDebt As String
    Public lblReturnPurchases As String

    'Login
    Public LblLogin As String
    Public LblUsername As String
    Public LblPassword As String
    Public LblExit As String
    Public LblRememberMe As String
    Public LblLatinExit As String
    Public LblLatinLogin As String
    Public LblLatinUsername As String
    Public LblLatinPassword As String
    Public LblLoginFrm As String
    Public LblLatinLoginFrm As String
    Public LblLatinRememberMe As String
    'Users
    Public LblUsers As String
    Public LblChangePassword As String

    'Database
    Public LblDatabase As String
    Public LblDatabaseBackup As String
    Public LblDatabaseRestore As String

    'About
    Public LblAbout As String
    Public LblInfo As String
    'Setting
    Public LblSetting As String
    Public LblFieldsSetting As String
    Public lblProgram As String
    Public lblProgrammer As String
    Public LblVersion As String

    'Notes PAy
    Public LblNotePayable As String
    Public LblNoteReceive As String
    Public lblValue As String
    Public LblValueRate As String
    Public LblCheckType As String
    Public LblBankName As String
    Public LblAlertOnCheckDueDate As String
    Public LblDescription As String

    'Journal Entry
    Public LblJournalEntry As String
    Public LblGeneralJournalPay As String
    Public LblGeneralJournalReceive As String

    'Debit/Credit
    Public LblDebtorsCreditors As String
    Public LblDebtors As String
    Public LblCreditors As String

    'Items Reports
    Public LblItemsReports As String
    Public LblPurchasingPriceReport As String
    Public lblSellingPriceReport As String
    Public LblPurchasingCountReport As String
    Public LblQuantityReport As String
    Public LblSellingCountReport As String
    Public LblInevntoryItemsReport As String
    Public LblItemsSalesProfitReport As String

    'General Reports
    Public LblGeneralReports As String
    Public LblChequesReport As String
    Sub New()

        'Ribbon Main
        lblHome = "Home"
        LblQuicklinks = "Quick links"
        LblDocument = "Document"
        lblTools = "Tools"
        lblReports = "Reports"
        LblShow = "Show"

        'Command Bar
        LblFiltering = "Filter"
        LblReset = "Reset"
        LblNew = "New"
        LblClose = "Close"
        LblEdit = "Edit"
        LblAdd = "Add"
        LblRefrech = "Refrech"
        LblSaveNew = "Save_New"
        LblSave = "Save"
        LblDelete = "Delete"
        Password_Encryption = "HSsh8E12"

        'In All Code 
        LblName = "Name"
        LblCode = "Code"
        LblAll = "All"
        LblDate = "Date"
        LblInvID = "Inv. No."
        LblFrom = "From"
        LblTo = "To"
        LblNum = "No."
        LblType = "Type"
        LblCurrency = "Currency"
        LblCurrencyRate = "Rate"
        LblPrint = "Print"
        LblPrintInvoiceAFour = "Invoice A4"
        LblPrintInvoicesReportAFour = "Customer Invoices A4"

        LblReference = "Reference"
        LblDueDate = "Due Date"
        LblForms = "Forms"
        LblProgramName = "برامج الهادي للمحاسبة"
        LblLatinProgramName = "AL Hadi Accounting"
        LblCheckNumber = "Check No."
        lblBalance = "Balance"
        LangEn = "En"
        LangAr = "Ar"
        LblPay = "Pay"

        'Accounts
        LblAddAccounts = "Add Accounts"
        LblAccounts = "Accounts"
        LblOpenningBalance = "Opening Balance"
        LblAccountStatement = "Account Statement"


        'Daily
        LblDaily = "Daily"
        LblCustomerVendor = "Cust./Vend."
        LblAllDate = "All Date"

        'Home
        LblGeneral = "General"
        LblNotes = "Notes"

        'Dashboard
        LblDashboard = "Dashboard"
        str_latin_Sales_Total = "Sales Total"
        str_Sales_Total = "إجمالي المبيعات"
        str_latin_Proftis_Total = "Sales Proftis"
        str_Sales_Profits = "أرباح المبيعات"

        'Profit
        lblSalesProfit = "Sales Profit"
        lblProfit = "Profit"

        'Currencies
        LblAddCurreny = "Add Currency"
        LblCurrencies = "Currencies"
        LblCurrenciesRate = "Currency Rate"
        LblDollarRate = "Dollar Rate"

        'Customers - Vendors
        lblCustomers = "Customers"
        lblCustomer = "Customer"
        LblEditCustomer = "Edit Customer"
        LblAddCustomer = "Add Customer"
        LblTown = "Town"
        LblAddress = "Address"
        LblPhone = "Phone"
        LblCellPhone = "Cell Phone"
        lblVendors = "Vendors"
        lblVendor = "Vendor"
        LblEditVendor = "Edit Vendor"
        LblAddVendor = "Add Vendor"
        LblCompany = "Company"
        LblTitle = "Title"

        'Groups - ITems - Addnew ITems
        LblItemTree = "Items Tree"
        LblAddItem = "Add Item"
        LblAddNewItem = "Add New Item"
        LblPageGeneral = "General"
        LblPageOption = "Options"
        LblItems = "Items"
        LblItemName = "Item Name"
        LblItemID = "Item ID"
        LblBarcode = "Barcode"
        LblPurchasingPrice = "Purchasing Price"
        LblSellingPrice = "Selling Price"
        LblQuantity = "Quantity"
        LblMinQuantity = "Min Qty"
        LblPercent = "ratio"
        LblLatinName = "Latin"
        LblExpiredDate = "Expired Date"
        LblIsitemHasExpiredDate = "Item With An Expiration Date"
        LblAnalertbeforetheexpiration = "Alert Before Expiration Date"
        LblAnalertInMinQty = "Alert In Min Quantity"
        LblAnalertInMinQtyInSell = "Alert Quantity In Sell"
        LblGroups = "Groups"
        LblGroupName = "Group Name"
        LblNote = "Note"
        LblGroup = "Group"
        LblInventoryItems = "Inventory Items"
        LblAllInventory = "All Inventory"

        'Purchase ORder sales Order
        LblAddPO = "Purchases"
        lblPurchaseOrder = "Purchase Order"
        lblPurchasesOrders = "Purchases Orders"
        LblPurchase = "Purchase"
        LblSaleOrder = "Sale Order"
        LblSalesOrders = "Sales Orders"
        LblAddSO = "Sales"
        LblInvType = "Inv. Type"
        LblSales = "Sales"
        LblPurchases = "Purchases"
        LblReturn = "Return"
        LblCash = "Cash"
        LblDebt = "Debt"
        LblStatus = "Status"
        LblSubTotal = "Sub Total"
        LblDiscount = "Discount"
        LblDueTotal = "Due Total"
        LblPayment = "Payment"
        LblCheck = "Check"
        LblAllPayments = "Payments"

        lblCashSales = "Cash Sales"
        lblDebtSales = "Debt Sales"
        lblReturnSalesCash = "Cash Sales Returns"
        lblReturnSalesDebt = "Debt Sales Returns"
        lblReturnSales = "Sales Returns"

        lblCashPurchases = "Cash Purchases"
        lblDebtPurchases = "Debt Purchases"
        lblReturnPurchasesCash = "Cash Purchases Returns"
        lblReturnPurchasesDebt = "Debt Purchases Returns"
        lblReturnPurchases = "Purchases Returns"

        'Login
        LblLogin = "دخول"
        LblUsername = "إسم المستخدم"
        LblPassword = "كلمة المرور"
        LblExit = "إغلاق"
        LblRememberMe = "تذكرني"
        LblLoginFrm = "إذن دحول"
        LblLatinExit = "Exit"
        LblLatinLogin = "Login"
        LblLatinUsername = "Username"
        LblLatinPassword = "Passowrd"
        LblLatinLoginFrm = "Login"
        LblLatinRememberMe = "Remember Me"


        'Users
        LblUsers = "Users"
        LblChangePassword = "Password"

        'Database
        LblDatabase = "Database"
        LblDatabaseBackup = "Backup Database"
        LblDatabaseRestore = "Restore Database"

        'Setting
        LblSetting = "Setting"
        LblFieldsSetting = "Fields"
        lblProgram = "Program"
        lblProgrammer = "Programmer"
        LblVersion = "Version"

        'About
        LblAbout = "About"
        LblInfo = "Information"

        'Notes PAy
        lblValue = "Value"
        LblValueRate = "Value Rate"
        LblCheckType = "Status"
        LblBankName = "Bank Name"
        LblNotePayable = "Note Pay"
        LblNoteReceive = "Note Receive"
        LblAlertOnCheckDueDate = "Alert On Check Due Date"
        LblDescription = "Description"

        'Journal Entry
        LblJournalEntry = "Journal"
        LblGeneralJournalPay = "General Journal Pay"
        LblGeneralJournalReceive = "General Journal Receive"

        'Debit/Credit
        LblDebtorsCreditors = "Debtors/Creditors"
        LblDebtors = "Debtors"
        LblCreditors = "Creditors"

        'Items Reports
        LblItemsReports = "Items Reports"
        LblPurchasingPriceReport = "Purchasing Price"
        lblSellingPriceReport = "Selling Price"
        LblPurchasingCountReport = "Purchasing Count"
        LblQuantityReport = "Quantity"
        LblSellingCountReport = "Selling Count"
        LblInevntoryItemsReport = "Inevntory Items"
        LblItemsSalesProfitReport = "Items Sales Profit"

        'General Reports
        LblGeneralReports = "General Reports"
        LblChequesReport = "Cheques"

    End Sub
End Class
