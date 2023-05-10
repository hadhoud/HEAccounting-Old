Public Class HEConstant

    ' All Messages String

    'version
    Public Lbl_One_Version As Integer
    Public Lbl_Two_Version As Integer
    Public Lbl_Year_One_Version As Integer
    Public Lbl_Year_Two_Version As Integer

    'For label not in StringlocalizationId
    Public Lbl_Yes As String
    Public Lbl_No As String
    Public Lbl_OK As String
    Public Lbl_All As String
    Public Lbl_NotInGroups As String
    Public SO_Description As String
    Public RSO_Description As String
    Public PO_Description As String
    Public RPO_Description As String
    Public Cash As String
    Public Paid As String
    Public Taasit As String
    Public Check As String
    Public Debt As String
    Public Collected As String
    Public NotCollected As String
    Public Returned As String
    Public Credit As String
    Public Debit As String
    Public Creditors As String
    Public Debtors As String
    Public RestoreDatabase As String
    Public Restore As String

    'Arabic - En
    Public ForHim As String
    Public OnHim As String
    Public Balance As String
    Public WePaidToMr As String
    Public WeReceivedFromMr As String
    Public AmountOF As String
    Public ViaCheckNum As String
    Public ForInvNum As String
    Public LebaneasePound As String
    Public Edit As String
    Public CountOfPurchases As String
    Public CountOfSales As String
    Public SalesPriceHistory As String
    Public PurchasesPriceHistory As String
    Public PanelChequesDue As String
    Public PanelQtyAlert As String
    Public PanelMessages As String
    Public PanelShortcuts As String

    'Constant Value
    Public ACC_Cust_VEND As String
    Public ACC_GENERAL As String

    ''Settings:
    'Public AllowAdd As String
    'Public AllowDelete As String
    'Public AllowEdit As String
    'Public AllowPosted As String

    'Status
    Public Posted As String
    Public UnPosted As String

    Public Programmer As String
    Public Admin As String
    Public User As String

    'Transaction
    Public SalesOrder As String
    Public ReturnSales As String
    Public PurchaseOrder As String
    Public ReturnPurchases As String
    Public NotesReceive As String
    Public NotesPay As String
    Public GeneralNotesReceive As String
    Public GeneralNotesPay As String

    'Reports Name
    Public RptSalesOrder As String
    Public RptSOCustomers As String
    Public RptPurchaseOrder As String
    Public RptAccReports As String
    Public RptAccReportsCurrency As String
    Public RptNotesPay As String
    Public RptNotesReceive As String
    Public RptQuantityHistory As String

    Public RptThermalInvSalesOrder As String

    ' For Ask 
    Public Ask_Add As String
    Public Ask_Edit As String
    Public Ask_Delete As String
    Public Ask_Delete_Confirm As String
    Public Ask_Delete_With_Quantity_Confirm As String
    Public Ask_Grid_Has_Error As String
    Public Ask_Are_You_Sure_You_Want_To_Move_Item As String
    Public Ask_To_Group As String
    Public Ask_Selling_Is_Smaller_Than_Purchasing_Price As String
    Public Ask_Do_You_Want_Print_Invoice As String
    Public Ask_Do_You_Want_Print_Voucher As String
    Public Ask_Do_You_Want_Exit As String
    Public Ask_Pay As String
    Public Ask_Pay_with_amount_zero As String

    ' For Information 
    Public Msg_Db_NotConnected As String
    Public msg_has_note_or_not_found As String
    Public Msg_Enter_All_Fields As String
    Public Msg_Password_Has_Been_Updated As String
    Public Msg_Press_Search_Button As String
    Public Msg_No_Trx_on_Accounts As String
    Public Msg_No_Items_Added As String
    Public Msg_Items_Already_Added As String
    Public Msg_Items_Barcode_Already_Added As String
    Public Msg_Item_Has_Been_Updated As String
    Public Msg_Group_Has_Been_Updated As String
    Public Msg_Invoice_Has_Been_Updated As String
    Public Msg_NotesPay_Has_Been_Updated As String
    Public Msg_NotesReceive_Has_Been_Updated As String
    Public Msg_NotesPay_Cannot_Delete_Permission As String
    Public Msg_NotesReceive_Cannot_Delete_Permission As String
    Public Msg_Customer_Has_Been_Updated As String
    Public Msg_Vendor_Has_Been_Updated As String
    Public Msg_An_Error_Occured As String
    Public Msg_Cust_Updated_From_Customer_Form As String
    Public Msg_Ven_Updated_From_Vendor_Form As String
    Public Msg_Qty_Must_Be_Smaller_Than_Available_Quantity As String
    Public Msg_Discount_Is_Greater_Than_Total_Price As String
    Public Msg_Selling_Is_Smaller_Than_Purchasing_Price As String
    Public Msg_You_Cannot_Move_This_Item_To_This_Group As String
    Public Msg_Check_Username_Password As String
    Public Msg_Check_Old_Password As String
    Public Msg_Empty_Username As String
    Public Msg_Empty_Password As String
    Public Msg_Item_Has_Been_Added As String
    Public Msg_Item_Not_Found As String
    Public Msg_Account_Has_Been_Updated As String
    Public Msg_Customer_Already_Added As String
    Public Msg_Vendor_Already_Added As String
    Public Msg_Groups_Already_Added As String
    Public Msg_Users_Already_Added As String
    Public Msg_NewPass_NotEqual_Confirm As String
    Public Msg_Cannot_Delete_User As String
    Public Msg_Successfully_Done As String
    Public Msg_Is_Not_Debt_Invoice As String
    Public Msg_Invoice_Status_ISUnposted As String
    Public Msg_Notes_Status_ISUnposted As String
    Public Msg_Choose_a_Customer As String
    Public Msg_System_Config_Enter_User_And_Pass As String
    Public Msg_INV_Do_Not_Have_Payments As String
    Sub New()

        'version
        Lbl_One_Version = 1
        Lbl_Two_Version = 9
        Lbl_Year_One_Version = 2
        Lbl_Year_Two_Version = 9

        'Always not related to lang
        'Constant Value
        ACC_Cust_VEND = "Cust/Vend"
        ACC_GENERAL = "General"

        If BoolLTRLanguage Then

            'For label not in StringlocalizationId  Arabic - Engish
            OnHim = "On Him"
            ForHim = "For Him"
            Balance = "Balance"
            WePaidToMr = "We Paid To Mr. "
            WeReceivedFromMr = "We Received From Mr."
            AmountOF = "Amount "
            ViaCheckNum = " Via Check No. "
            ForInvNum = "For Invoice No. "

            Lbl_Yes = "yes"
            Lbl_No = "No"
            Lbl_OK = "Ok"
            Lbl_All = "All"
            Lbl_NotInGroups = "Not In Any Group"
            SO_Description = "Sales"
            RSO_Description = "Sales Return"
            PO_Description = "Purchases"
            RPO_Description = "Purchases Return"
            Cash = "Cash"
            Paid = "Paid"
            Debt = "Debt"
            Taasit = "Installement"
            Check = "Check"
            Collected = "Collected"
            NotCollected = "NotCollected"
            Returned = "Returned"
            Edit = "Edit"
            LebaneasePound = "Lebanease Pound"
            Credit = "Credit"
            Debit = "Debit"
            Creditors = "Creditors"
            Debtors = "Debtors"
            RestoreDatabase = "Restore Database"
            Restore = "Restore"
            CountOfPurchases = "Count Of Purchases"
            CountOfSales = "Count Of Sales"
            SalesPriceHistory = "Sales Prices History"
            PurchasesPriceHistory = "Purchase Price History"
            PanelChequesDue = "Due Cheques"
            PanelMessages = "Messages"
            PanelQtyAlert = "Quantity Alert"
            PanelShortcuts = "Shortcuts"

            'Status
            Posted = "Posted"
            UnPosted = "UnPosted"

            Programmer = "Programmer"
            Admin = "Admin"
            User = "User"

            ''Settings:
            'AllowAdd = "Add"
            'AllowDelete = "Delete"
            'AllowEdit = "Edit"
            'AllowPosted = "Posted"

            SalesOrder = "Sales Order"
            ReturnSales = "Return Sales"
            PurchaseOrder = "Purchases Order"
            ReturnPurchases = "Return Purchases"
            NotesReceive = "Note Receive"
            NotesPay = "Note Pay"
            GeneralNotesPay = "General Note Pay"
            GeneralNotesReceive = "General Note Receive"

            'Reports Name
            RptPurchaseOrder = "EnPO101"
            RptSalesOrder = "EnSO101"
            RptSOCustomers = "ArSOCustomers"
            RptAccReports = "EnAccRpt101"
            RptAccReportsCurrency = "ArAccRptCur101"
            RptNotesPay = "ArNP101"
            RptNotesReceive = "ArNR101"
            RptQuantityHistory = "ArQuantityHistory101"

            RptThermalInvSalesOrder = "/Thermal/AR/ArSODetails101"

            Msg_Check_Username_Password = "Check Your Username And Password"
            Msg_Empty_Username = "Enter Your Username"
            Msg_Empty_Password = "Enter Your Password"
            Msg_Check_Old_Password = "Check Your Old Password"

            ' For Ask 
            Ask_Add = "Are you sure you want to Add?"
            Ask_Edit = "Are you sure you want to Edit?"
            Ask_Delete = "Are You Sure you want to Delete?"
            Ask_Delete_Confirm = "Are You Sure you want to Delete?"
            Ask_Delete_With_Quantity_Confirm = "You Want to ReAdd the Quantity To Items"
            Ask_Grid_Has_Error = "You Have Some Error in Item Do You Want Continue?"
            Ask_Are_You_Sure_You_Want_To_Move_Item = "Are You Sure You Want To Move Item ("
            Ask_To_Group = ") To Group ("
            Ask_Selling_Is_Smaller_Than_Purchasing_Price = "Selling Price Is Smaller Than Purchasing Price Do You Want Continue?"
            Ask_Do_You_Want_Print_Invoice = "Do you want Print This SO?"
            Ask_Do_You_Want_Print_Voucher = "Do you want Print This Voucher?"
            Ask_Do_You_Want_Exit = "Are you Sure You Want Exit?"
            Ask_Pay = "Are you sure you want to Pay?"
            Ask_Pay_with_amount_zero = "The amount is Zero , this will close the invoice and make it as paid , Continue?"
            ' For Information
            Msg_Enter_All_Fields = "Enter Required Fields"
            Msg_Press_Search_Button = "Press Search Buton"
            Msg_No_Trx_on_Accounts = "No Transaction For This Account"
            Msg_No_Items_Added = "Item must be added"
            Msg_Db_NotConnected = "Database is not connected"
            Msg_An_Error_Occured = "An Error Occurred Please Contact Administrator"
            Msg_Item_Has_Been_Updated = "Item Has Been Modified"
            Msg_Group_Has_Been_Updated = "Group Has Been Modified"
            Msg_Customer_Has_Been_Updated = "Customer Has Been Modified"
            Msg_Invoice_Has_Been_Updated = "Invoice Has Been Modified"
            Msg_Vendor_Has_Been_Updated = "Vendor Has Been Modified"
            Msg_NotesReceive_Has_Been_Updated = "Notes Receive Has Been Modified"
            Msg_NotesPay_Has_Been_Updated = "Notes Pay Has Been Modified"
            Msg_NotesPay_Cannot_Delete_Permission = "You dont Have Permission to Delete"
            Msg_NotesReceive_Cannot_Delete_Permission = "You dont Have Permission to Delete"
            Msg_Qty_Must_Be_Smaller_Than_Available_Quantity = "-Quantity Must Be Smaller Than Available Quantity-"
            Msg_Discount_Is_Greater_Than_Total_Price = "-Discount Is Greater Than Total Price-"
            Msg_Selling_Is_Smaller_Than_Purchasing_Price = "-Selling Price Is Smaller Than Purchasing Price-"
            Msg_Item_Has_Been_Added = "Item Has been Added , Change Quantiy"
            Msg_Item_Not_Found = "Item Not Exist"
            Msg_You_Cannot_Move_This_Item_To_This_Group = "You Cannot Move This Item To This Group"
            Msg_Cust_Updated_From_Customer_Form = "It's a Customer Account Update It From Customer Form"
            Msg_Ven_Updated_From_Vendor_Form = "It's a Vendor Account Update It From Vendor Form"
            Msg_Account_Has_Been_Updated = "Account Has Been Modified"
            Msg_Items_Already_Added = "Item Name Already Added Before"
            Msg_Items_Barcode_Already_Added = "Item Barcode Already Added Before"
            Msg_Customer_Already_Added = "Customer Already Added Before"
            Msg_Vendor_Already_Added = "Vendor Already Added Before"
            Msg_Groups_Already_Added = "Group Already Added Before"
            Msg_Users_Already_Added = "User Already Added Before"
            Msg_NewPass_NotEqual_Confirm = "New Password Not Equal Confirm Passsword"
            Msg_Password_Has_Been_Updated = "your Password Has Been Modified"
            Msg_Cannot_Delete_User = "Cannot Delete This User"
            Msg_Successfully_Done = "Successfully Done"
            Msg_Is_Not_Debt_Invoice = "Is Not A Debit Invoice"
            Msg_INV_Do_Not_Have_Payments = "Invoice does Not Have Payments"
            Msg_Invoice_Status_ISUnposted = "Invoice Is Unposted"
            Msg_Notes_Status_ISUnposted = "Notes Is Unposted"
            Msg_Choose_a_Customer = "Choose a Customer"
            Msg_System_Config_Enter_User_And_Pass = "Please Enter UserName and Password"
        Else


            'For label not in StringlocalizationId Arabic - Engish
            OnHim = "عليه"
            ForHim = "له"
            Balance = "الرصيد"
            WePaidToMr = "دفعنا لأمر السيد "
            WeReceivedFromMr = "إستلمنا من السيد "
            AmountOF = " مبلغ و قدره "
            ViaCheckNum = " عبر شيك رقم "
            ForInvNum = " عن فاتورة رقم "
            Edit = "تعديل"
            Lbl_Yes = "نعم"
            Lbl_No = "كلا"
            Lbl_OK = "موافق"
            Lbl_All = "الجميع"
            Lbl_NotInGroups = "غير مدرج ضمن مجموعة"
            SO_Description = "فاتورة مبيع"
            RSO_Description = "مرتجع مبيع"
            PO_Description = "فاتورة شراء"
            RPO_Description = "مرتجع شراء"
            Cash = "نقدا"
            Paid = "مسددة"
            Debt = "آجل"
            Taasit = "تقسيط"
            Check = "شيك"
            Collected = "محصل"
            NotCollected = "قيد التحصيل"
            Returned = "مرتجع"
            LebaneasePound = "ليرة لبنانية"
            Credit = "دائن"
            Debit = "مدين"
            Creditors = "دائنون"
            Debtors = "مدينون"
            RestoreDatabase = "إستعادة قاعدة بيانات"
            Restore = "إستعادة"
            CountOfPurchases = "عدد الشراء"
            CountOfSales = "عدد المبيع"
            SalesPriceHistory = "سعر المبيع"
            PurchasesPriceHistory = "سعر الشراء"
            PanelChequesDue = "الشيكات المستحقة"
            PanelMessages = "رسائل تذكير"
            PanelQtyAlert = "أصناف تخطت الحد الأدنى"
            PanelShortcuts = "إختصارات"
            'Status
            Posted = "مرحل"
            UnPosted = "غير مرحل"

            Programmer = "مبرمج"
            Admin = "مدير"
            User = "مستخدم"

            ''Settings:
            'AllowAdd = "إضافة"
            'AllowDelete = "حذ"
            'AllowEdit = "Edit"
            'AllowPosted = "Posted"

            'Transactions
            SalesOrder = "فاتورة مبيع"
            ReturnSales = "مرتجع مبيع"
            PurchaseOrder = "فاتورة شراء"
            ReturnPurchases = "مرتجع شراء"
            NotesReceive = "سند قبض"
            NotesPay = "سند صرف"
            GeneralNotesPay = "سند صرف عام"
            GeneralNotesReceive = "سند قبض عام"

            'Reports Name
            RptPurchaseOrder = "ArPO101"
            RptSalesOrder = "ArSO101"
            RptSOCustomers = "ArSOCustomers"
            RptAccReports = "ArAccRpt101"
            RptAccReportsCurrency = "ArAccRptCur101"
            RptNotesPay = "ArNP101"
            RptNotesReceive = "ArNR101"
            RptQuantityHistory = "ArQuantityHistory101"

            RptThermalInvSalesOrder = "/Thermal/AR/ArSODetails101"

            ' For Ask 
            Ask_Add = "هل أنت متأكد أنك تريد الإضافة؟"
            Ask_Edit = "هل أنت متأكد أنك تريد التعديل؟"
            Ask_Delete = "هل أنت متأكد أنك تريد الحذف؟"
            Ask_Delete_Confirm = "لا يمكنك الرجوع لاحقا!هل أنت متأكد أنك تريد الحذف؟"
            Ask_Delete_With_Quantity_Confirm = "هل تريد تعديل الكمية بعد الحذف؟"
            Ask_Grid_Has_Error = "يوجد أخطاء في الأصناف هل تريد المتابعة؟"
            Ask_Are_You_Sure_You_Want_To_Move_Item = "هل أنت متأكد أنك تريد نقل الصنف ( "
            Ask_To_Group = " ) إلى المجموعة ( "
            Msg_You_Cannot_Move_This_Item_To_This_Group = "لا يمكنك نقل هذا الصنف لهذه المجموعة"
            Ask_Selling_Is_Smaller_Than_Purchasing_Price = "سعر البيع أصغر من سعر الشراء هل تريد المتابعة؟"
            Ask_Do_You_Want_Print_Invoice = "هل تريد طباعة الفاتورة؟"
            Ask_Do_You_Want_Print_Voucher = "هل تريد طباعة السند؟"
            Ask_Do_You_Want_Exit = "هل أنت متأكد أنك تريد الخروج؟"
            Ask_Pay = "هل أنت متأكد أنك تريد التسديد؟"
            Ask_Pay_with_amount_zero = "المبلغ المسدد 0 مما سيجعل الفاتورة مسددة , هل تريد المتابعة؟"

            ' For Information
            Msg_Enter_All_Fields = "يجب تعبئة الحقول المطلوبة"
            Msg_Press_Search_Button = "يجب الضغط على بحث"
            Msg_No_Trx_on_Accounts = "لا يوجد حركة على الحساب"
            Msg_No_Items_Added = "يجب إضافة صنف"
            Msg_Db_NotConnected = "هناك مشكلة بالإتصال بقاعدة البيانات"
            Msg_Item_Has_Been_Updated = "تم تعديل الصنف"
            Msg_An_Error_Occured = "حدثت مشكلة نتمنى التواصل مع المبرمج"
            Msg_Group_Has_Been_Updated = "تم تعديل المجموعة"
            Msg_Customer_Has_Been_Updated = "تم تعديل الزبون"
            Msg_Invoice_Has_Been_Updated = "تم تعديل الفاتورة"
            Msg_Vendor_Has_Been_Updated = "تم تعديل المورد"
            Msg_NotesReceive_Has_Been_Updated = "تم تعديل سند القبض"
            Msg_NotesPay_Has_Been_Updated = "تم تعديل سند الصرف"
            Msg_NotesPay_Cannot_Delete_Permission = "لا تمتلك صلاحية لحذف السند , بإمكانك مراجعة المدير"
            Msg_NotesReceive_Cannot_Delete_Permission = "لا تمتلك صلاحية لحذف السند , بإمكانك مراجعة المدير"
            Msg_Qty_Must_Be_Smaller_Than_Available_Quantity = "-الكمية يجب أن تكون أقل من الكمية المتاحة-"
            Msg_Discount_Is_Greater_Than_Total_Price = "-الخصم أكبر من المجموع-"
            Msg_Selling_Is_Smaller_Than_Purchasing_Price = "-سعر البيع أصغر من سعر الشراء-"
            Msg_Item_Has_Been_Added = "تم إضافة الصنف يمكنك تغيير الكمية"
            Msg_Item_Not_Found = "صنف غير موجود"
            Msg_Check_Username_Password = "تأكد من إسم المستخدم و كلمة المرور"
            Msg_Check_Old_Password = "تأكد من كلمة المرور القديمة"
            Msg_Empty_Username = "أدخل إسم المستخدم"
            Msg_Empty_Password = "أدخل كلمة المرور"
            Msg_Cust_Updated_From_Customer_Form = "حساب زيون يمكن تعديله من نموزج الزبائن"
            Msg_Ven_Updated_From_Vendor_Form = "حساب مورد يمكن تعديله من نموزج الموردين"
            Msg_Account_Has_Been_Updated = "تم تعديل الحساب"
            Msg_Items_Already_Added = "الصنف موجود لا يمكن تكرار الإسم"
            Msg_Items_Barcode_Already_Added = "الصنف موجود لا يمكن تكرار الباركود"
            Msg_Customer_Already_Added = "الزيون موجود لا يمكن تكرار الإسم"
            Msg_Vendor_Already_Added = "المورد موجود لا يمكن تكرار الإسم"
            Msg_Groups_Already_Added = "المجموعة موجودة لا يمكن تكرار الإسم"
            Msg_Users_Already_Added = "المستخدم موجود لا يمكن تكرار الإسم"
            Msg_NewPass_NotEqual_Confirm = "كلمة المرور الجديدة غير مطابفة"
            Msg_Password_Has_Been_Updated = "تم تعديل كلمة المرور"
            Msg_Cannot_Delete_User = "لا يمكنك حذف هذا المستخدم"
            Msg_Successfully_Done = "تمت العملية بنجاح"
            Msg_Is_Not_Debt_Invoice = "هذه الفاتورة مسددة"
            Msg_INV_Do_Not_Have_Payments = "لا يوجد دفعات لهذه الفاتورة"
            Msg_Invoice_Status_ISUnposted = "هذه الفاتورة غير مرحلة"
            Msg_Notes_Status_ISUnposted = "السند غير مرحل"
            Msg_Choose_a_Customer = "يجب إختيار زبون"
            Msg_System_Config_Enter_User_And_Pass = "تأكد من إسم المستخدم و كلمة المرور"
        End If


    End Sub
End Class
