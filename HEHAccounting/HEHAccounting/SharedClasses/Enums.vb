
Module Enums

    Structure TagValue
        Const CurrencyUSDCommas = "CurrencyUSDCommas"
        Const CurrencyLLCommas = "CurrencyLLCommas"
    End Structure
    Enum Status
        'Order current status. Posted = 1 morhal ;UnPosted = 2 Not Morahal;
        Posted = 1
        UnPosted = 2
    End Enum

    Structure PaymentType
        Const Cash = "C"
        Const Debt = "D"
        Const Paid = "PI"
        Const Taasit = "TA"
    End Structure

    Enum UserRole
        'Order current status. Posted = 1 morhal ;UnPosted = 2 Not Morahal;
        Programmer = 1
        Admin = 2
        User = 3
    End Enum

    Structure AbbForms
        Const Items = "IT"
        Const AddItems = "AIT"
        Const GroupsTree = "GT"
        Const AddGroups = "AG"
        Const SalesOrders = "SO"
        Const AddSaleOrder = "ASO"
        Const PurchasesOrders = "PO"
        Const AddPurchaseOrder = "APO"
        Const NotesPay = "NP"
        Const NotesReceive = "NR"
        Const GeneralNotes = "NG"
    End Structure

    'Structure FormsPermissions
    '    Const Items = "IT"
    '    Const Groups = "G"
    '    Const SalesOrders = "SO"
    '    Const PurchasesOrders = "PO"
    '    Const NotesPay = "NP"
    '    Const NotesReceive = "NR"
    '    Const GeneralNotes = "NG"
    '    Const Account = "ACC"
    'End Structure

    Structure AbbTransaction
        Const SalesOrders = "SO"
        Const ReturnSales = "RSO"
        Const PurchasesOrders = "PO"
        Const ReturnPurchases = "RPO"
        Const NotesPay = "NP"
        Const NotesReceive = "NR"
        Const GeneralNotesPay = "NGP"
        Const GeneralNotesReceive = "NGR"
    End Structure

    Structure CreditsDebits
        Const Credits = "CForHim"
        Const Debts = "DOnHim"
    End Structure

    Enum CheckStatus
        'Check current status. 1 = NotCollected ;2 = Collected;  3 = Returned ;
        NotCollected = 1
        Collected = 2
        Returned = 3
    End Enum

End Module
