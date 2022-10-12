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
    Public LblReference As String
    Public LblDueDate As String
    Public LblForms As String
    Public LblProgramName As String
    Public LblLatinProgramName As String
    Public LblCheckNumber As String
    Public lblBalance As String
    Public LblAddAccounts As String

    'Lang
    Public LangEn As String
    Public LangAr As String

    'Daily
    Public LblDaiy As String


    'Currencies
    Public LblCurrencies As String
    Public LblAddCurreny As String
    Public LblCurrenciesRate As String

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

    'Login
    Public LblLogin As String
    Public LblUsername As String
    Public LblPassword As String
    Public LblExit As String
    Public LblLatinExit As String
    Public LblLatinLogin As String
    Public LblLatinUsername As String
    Public LblLatinPassword As String
    Public LblLoginFrm As String
    Public LblLatinLoginFrm As String

    'Notes PAy
    Public LblNotePayable As String
    Public LblNoteReceive As String
    Public lblValue As String
    Public LblValueRate As String
    Public LblCheckType As String
    Public LblBankName As String
    Public LblAlertOnCheckDueDate As String
    Public LblDescription As String
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
        LblReference = "Reference"
        LblDueDate = "Due Date"
        LblForms = "Forms"
        LblProgramName = "برامج الهادي للمحاسبة"
        LblLatinProgramName = "HEH Accounting"
        LblCheckNumber = "Check No."
        lblBalance = "Balance"
        LblAddAccounts = "Add Accounts"
        LangEn = "En"
        LangAr = "Ar"

        'Daily
        LblDaiy = "Daily"


        'Currencies
        LblAddCurreny = "Add Currency"
        LblCurrencies = "Currencies"
        LblCurrenciesRate = "Currency Rate"

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
        LblItemTree = "Items Guide"
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

        'Purchase ORder sales Order
        LblAddPO = "Purchase Entry"
        lblPurchaseOrder = "Purchase Order"
        lblPurchasesOrders = "Purchases Orders"
        LblPurchase = "Purchase"
        LblSaleOrder = "Sale Order"
        LblSalesOrders = "Sales Orders"
        LblAddSO = "Sale Entry"
        LblInvType = "Inv. Type"
        LblSales = "Sales"
        LblReturn = "Return"
        LblCash = "Cash"
        LblDebt = "Debt"
        LblStatus = "Status"
        LblSubTotal = "Sub Total"
        LblDiscount = "Discount"
        LblDueTotal = "Due Total"
        LblPayment = "Payment"
        LblCheck = "Check"

        'Login
        LblLogin = "دخول"
        LblUsername = "إسم المستخدم"
        LblPassword = "كلمة المرور"
        LblExit = "إغلاق"
        LblLatinExit = "Exit"
        LblLatinLogin = "Login"
        LblLatinUsername = "Username"
        LblLatinPassword = "Passowrd"
        LblLatinLoginFrm = "Login"
        LblLoginFrm = "إذن دحول"

        'Notes PAy
        lblValue = "Value"
        LblValueRate = "Value Rate"
        LblCheckType = "Status"
        LblBankName = "Bank Name"
        LblNotePayable = "Note Pay"
        LblNoteReceive = "Note Receive"
        LblAlertOnCheckDueDate = "Alert On Check Due Date"
        LblDescription = "Description"
    End Sub
End Class
