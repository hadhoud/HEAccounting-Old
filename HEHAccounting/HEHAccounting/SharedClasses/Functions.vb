Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Cryptography
Imports Telerik.Reporting
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI


Module Functions
    ReadOnly Db As New Database

    Function ChangeColNameToArabic(ByVal ColName As String) As String
        Select Case ColName
            'Form Items:
            Case "ID", "Item_id", "ItemID", "CustomerID", "VendorID", "CurrencyID", "UserID", "CheckID"
                Return "كود"

            Case "Item_name"
                Return "إسم الصنف"

            Case "Qty"
                Return "الكمية"

            Case "MinQty"
                Return "أقل كمية"

            Case "SellingPrice"
                Return "سعر المبيع"

            Case "PurchasingPrice"
                Return "سعر الشراء"

            Case "PurchasingPriceUSD"
                Return "سعر الشراء $"

            Case "PurchasingPriceLL"
                Return "سعر الشراء ل.ل"

            Case "InventoryNote"
                Return "ملاحظات"

            Case "TotalPurchasingPriceLL"
                Return "مجموع الشراء ل.ل"

            Case "TotalPurchasingPriceUSD"
                Return "مجموع الشراء $"

            Case "Barcode"
                Return "الباركود"

            Case "LastPurchasingPrice"
                Return "أخر سعر شراء"

            Case "LastUpdatePriceDate"
                Return "تعديل سعر الشراء"

            Case "SellInvoicePriceNum"
                Return "رقم الفاتورة"

            Case "ItemLatinName", "CustomerLatinName", "LatinName", "VendorLatinName"
                Return "الإسم اللاتيني"

                'Form Groups
            Case "GroupName"
                Return "إسم المجموعة"

            Case "GroupDescription"
                Return "ملاحظات"

            Case "GroupID"
                Return "كود المجموعة"

            Case "NotesType", "NotesTypeName"
                Return "نوع السند"

                'Form Customers
            Case "CustomerName"
                Return "إسم الزبون"

            Case "CustomerTitle", "VendorTitle", "Title"
                Return "اللقب"

            Case "CustomerAddress", "VendorAddress"
                Return "العنوان"

            Case "CustomerPhone", "VendorPhone"
                Return "الهاتف"

            Case "CustomerTown", "VendorTown"
                Return "البلدة"

            Case "VendorName"
                Return "إسم المورد"

            Case "VendorCompany"
                Return "الشركة"

            Case "AmountEuality"
                Return "المبلغ"

                'All Form
            Case "CreatedDate"
                Return "تاريخ الإنشاء"

            Case "ModifiedDate"
                Return "تاريخ التعديل"

                'Sales Invoices
            Case "Delete"
                Return "X"

            Case "CurrencySymb"
                Return "الرمز"

            Case "Currency"
                Return "العملة"

            Case "CurrencyVal"
                Return "قيمة الصرف"

            Case "DollarRate"
                Return "سعر الصرف"

            Case "SellPurchaseDifference"
                Return "ربح / خسارة"

            Case "PurchaseTotalDue"
                Return "صافي الشراء"

            Case "HyperInvID", "InvID", "TrsID", "InventoryID"
                Return "الرقم"

            Case "Discount", "ItemDiscount"
                Return "الخصم"

            Case "CellPhone"
                Return "الخليوي"

            Case "NotesID"
                Return "رقم السند"

            Case "CheckNum"
                Return "رقم الشيك"

            Case "BankName"
                Return "البنك"

            Case "AfterDiscount", "TotalDue"
                Return "الصافي"

            Case "AvailableQty"
                Return "الكمية المتاحة"

            Case "Description"
                Return "البيان"

            Case "Type", "AccountTypeN", "TypeName"
                Return "النوع"

            Case "PaymentType", "PaymentTypeName"
                Return "طريقة الدفع"

            Case "DueDate"
                Return "التاريخ"

            Case "SalesProfitByQty"
                Return "الربح"

            Case "SubTotal", "BeforeDiscount"
                Return "المجموع"

            Case "SubTotal.LL"
                Return "المجموع ل.ل"

            Case "SubTotal.$"
                Return "المجموع $"

            Case "TotalDue.LL"
                Return "صافي ل.ل"

            Case "TotalDue.$"
                Return "صافي $"

            Case "Status", "StatusName"
                Return "الحالة"

            Case "SanadStatusName", "SanadStatus"
                Return "حالة السند"

                'Currency
            Case "CurrName"
                Return "إسم العملة"

            Case "Symb"
                Return "رمز العملة"

            Case "InvoiceCurrencySymb"
                Return "عملة الفاتورة"

            Case "PartName"
                Return "جزء العملة"

            Case "PartPrecision"
                Return "دقة الجزء"

            Case "CurrencyVal"
                Return "قيمة الصرف"

            Case "ReferID", "Refer"
                Return "رقم المرجع"

            Case "Cus/Ven"
                Return "زبون / مورد"

            Case "AccountNumber"
                Return "رقم الحساب"


            Case "OnHim"
                Return "عليه"

            Case "ForHim"
                Return "له"

            Case "AccountName"
                Return "الإسم"

            Case "Balance"
                Return "الرصيد"

            Case "Count"
                Return "العدد"

            Case "StartDate"
                Return "من"

            Case "EndDate"
                Return "إلى"

            Case "OldSellingPrice", "OldPurchasingPrice"
                Return "السعر القديم"

            Case "FullName"
                Return "الإسم الثلاثي"

            Case "Username"
                Return "إسم المستخدم"

            Case "Form"
                Return "البطاقة"

            Case "UserType"
                Return "نوع المستخدم"

            Case "AllowAdd"
                Return "الإضافة"

            Case "AllowEdit"
                Return "التعديل"

            Case "AllowDelete"
                Return "الحذف"

            Case "AllowPosted"
                Return "الترحيل"

                 'Items Sales Daily Win
            Case "TotalPurchasingPrice"
                Return "مجموع الشراء"

            Case "TotalSellingPrice"
                Return "مجموع المبيع"

            Case "TotalSellingPrice"
                Return "مجموع المبيع"

            Case "TotalDueSellingPrice"
                Return "صافي المبيع"

            Case "InvoiceNumber"
                Return "رقم الفاتورة"

            Case Else
                Return ColName
        End Select

    End Function

    Function ChangeColNameToEnglish(ByVal ColName As String) As String
        Select Case ColName
            'Form Items:
            Case "ID", "Item_id", "ItemID", "CustomerID", "VendorID", "CurrencyID", "GroupID", "TrsID", "UserID"
                Return "Code"

            Case "Item_name"
                Return "Item Name"

            Case "Qty"
                Return "Qty"

            Case "SellingPrice"
                Return "Selling Price"

            Case "PurchasingPrice"
                Return "Purchasing Price"

            Case "Barcode"
                Return "Barcode"

            Case "PurchasingPriceUSD"
                Return "Purchasing Price $"

            Case "PurchasingPriceLL"
                Return "Purchasing Price L.L"

            Case "InventoryNote"
                Return "Note"

            Case "TotalPurchasingPriceLL"
                Return "Total Price L.L"

            Case "LastPurchasingPrice"
                Return "Last Purchasing Price"

            Case "LastUpdatePriceDate"
                Return "Updated Price"

            Case "SellInvoicePriceNum"
                Return "Invoice Number"

            Case "ItemLatinName", "CustomerLatinName", "LatinName", "VendorLatinName"
                Return "Latin Name"

                'Form Groups
            Case "GroupName"
                Return "Group Name"

            Case "GroupDescription"
                Return "Description"

                'Form Customers
            Case "CustomerName"
                Return "Cust Name"

            Case "CustomerTitle", "VendorTitle", "Title"
                Return "Title"

            Case "CustomerAddress", "VendorAddress"
                Return "Address"


            Case "CustomerPhone", "VendorPhone"
                Return "Phone"

            Case "CustomerTown", "VendorTown"
                Return "Town"

            Case "VendorName"
                Return "Ven Name"

            Case "VendorCompany"
                Return "Company"


                'All Form
            Case "CreatedDate"
                Return "Created Date"

            Case "ModifiedDate"
                Return "Modified Date"

                 'Sales Invoices
            Case "Delete"
                Return "X"

            Case "HyperInvID"
                Return "InvID"

            Case "SellPurchaseDifference"
                Return "Profit/Loss"

            Case "PurchaseTotalDue"
                Return "Purchase Total"

            Case "Discount"
                Return "Discount"

            Case "ItemDiscount"
                Return "Discount"

            Case "BeforeDiscount"
                Return "Total"

            Case "CellPhone"
                Return "Cell Phone"


            Case "AfterDiscount"
                Return "Net"

            Case "AvailableQty"
                Return "Available Qty"

            Case "Description"
                Return "Description"

            Case "InvID", "InventoryID"
                Return "Inv No."

            Case "Type"
                Return "Type"

            Case "PaymentType", "PaymentTypeName"
                Return "Payment Type"

            Case "DueDate"
                Return "Due Date"

            Case "SalesProfitByQty"
                Return "Profit By Qty"

            Case "SubTotal"
                Return "SubTotal"

            Case "SubTotal.LL"
                Return "SubTotal LL"

            Case "SubTotal.$"
                Return "SubTotal $"

            Case "TotalDue.LL"
                Return "TotalDue LL"

            Case "TotalDue.$"
                Return "TotalDue $"

            Case "TotalDue"
                Return "Total Due"

            Case "Status", "StatusName"
                Return "Status"

                'Currency
            Case "CurrName"
                Return "Cur. Name"

            Case "CurrencyVal"
                Return "Cur. Rate"
            Case "DollarRate"
                Return "Dollar Rate"

            Case "Symb"
                Return "Symbol"

            Case "InvoiceCurrencySymb"
                Return "Currency"

            Case "PartName"
                Return "Part Name"

            Case "PartPrecision"
                Return "Part Precision"

            Case "ReferID", "Refer"
                Return "Reference No."

            Case "Cus/Ven"
                Return "Customer/Vendor"

            Case "AccountNumber"
                Return "Account NO."

            Case "LatinDescription"
                Return "Description"

            Case "OnHim"
                Return "On Him"

            Case "ForHim"
                Return "For Him"

            Case "AccountName"
                Return "Name"

            Case "AccountTypeN", "TypeName"
                Return "Type"

            Case "OldSellingPrice"
                Return "Old Price"

            Case "Count"
                Return "Count"

            Case "StartDate"
                Return "From"

            Case "EndDate"
                Return "To"

            Case "FullName"
                Return "Full Name"

            Case "AllowAdd"
                Return "Add"

            Case "AllowEdit"
                Return "Edit"

            Case "AllowDelete"
                Return "Delete"

            Case "AllowPosted"
                Return "Posted"

                'Items Sales Daily Win
            Case "TotalPurchasingPrice"
                Return "Total Purchasing Price"

            Case Else
                Return ColName
        End Select

    End Function

    Public Sub OpenReport(ByVal RptName As String, ByVal Param() As String)
        Dim FrmOpenReport As New ShowReport With {
            .RptName = RptName,
            .AllParamter = GetParameterRports(Param)
        }
        FrmOpenReport.Show()
    End Sub

    Function GetParameterRports(ByVal Param() As String) As Parameter()
        Dim parametercount As Integer = Param.Count - 1
        Dim OneRptParameter As Parameter
        Dim ReturnRptParameter(parametercount) As Parameter
        Dim i As Integer = 0
        Dim ParameterName As String
        Dim ParameterValue As Object
        For Each pa In Param
            Dim PR() As String
            PR = pa.Split(",")
            ParameterName = PR(0).Trim
            ParameterValue = PR(1).Trim
            OneRptParameter = New Parameter(ParameterName, ParameterValue)
            ReturnRptParameter(i) = OneRptParameter
            i += 1
        Next
        Return ReturnRptParameter
    End Function

    Public Sub MessageShowInfo(ByVal msg As String, Optional error_fl As Boolean = False)
        Dim msgshow As New HEMessage(msg, OkOrYes:="Ok", error_fl)
        ' msgshow.btnyes.rowspan = New Point(msgshow.Size.Width / 2 - msgshow.btnyes.Size.Width / 2, msgshow.btnyes.Location.Y)
        msgshow.Btnno.Visible = False
        msgshow.ShowDialog()
    End Sub

    Function MessageShowAsk(ByVal msg As String) As DialogResult
        Dim msgshow As New HEMessage(msg, OkOrYes:="Yes")
        Return msgshow.ShowDialog()
    End Function


    Function Evalisinteger(ByVal txt As String) As Boolean
        Dim Value As Integer
        ' is there an (integer) NUMBER in the textbox?
        If Integer.TryParse(txt, Value) Then
            Return True
        Else
            Return False
        End If
        Return False
    End Function

    Function Evalquote(ByVal texttoeval As String) As String
        If texttoeval.Contains("'") Then
            texttoeval = texttoeval.Replace("'", "")
        End If
        If texttoeval.Contains(",") Then
            texttoeval = texttoeval.Replace(",", "")
        End If
        Evalquote = texttoeval
    End Function

    Public Sub LogError(ex As Exception)
        Dim message As String = String.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        message += Environment.NewLine
        message += "-----------------------------------------------------------"
        message += Environment.NewLine
        message += String.Format("Message: {0}", ex.Message)
        message += Environment.NewLine
        message += String.Format("StackTrace: {0}", ex.StackTrace)
        message += Environment.NewLine
        message += String.Format("Source: {0}", ex.Source)
        message += Environment.NewLine
        message += String.Format("TargetSite: {0}", ex.TargetSite.ToString())
        message += Environment.NewLine
        message += "-----------------------------------------------------------"
        message += Environment.NewLine
        Dim path As String = Application.StartupPath & "/ErrorLog.txt"
        Using writer As New StreamWriter(path, True)
            writer.WriteLine(message)
            writer.Close()
        End Using
        MessageShowInfo(Con.Msg_An_Error_Occured)
        'ProgramHasError = True
        'ProgramHasErrorMsg = Con.Msg_Db_NotConnected
    End Sub

    Public Sub LogMessage(msg As String)
        Dim message As String = String.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
        message += Environment.NewLine
        message += "-----------------------------------------------------------"
        message += Environment.NewLine
        message += "Message: " & msg
        message += Environment.NewLine
        message += "-----------------------------------------------------------"
        message += Environment.NewLine
        Dim path As String = Application.StartupPath & "/ErrorLog.txt"
        Using writer As New StreamWriter(path, True)
            writer.WriteLine(message)
            writer.Close()
        End Using
    End Sub

    Function Encode(ByVal data As String) As String
        Try
            Dim bykey As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(LoStrId.Password_Encryption)
            Dim byiv As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(LoStrId.Password_Encryption)
            Dim cryptoprovider As DESCryptoServiceProvider = New DESCryptoServiceProvider()
            Dim ms As MemoryStream = New MemoryStream
            Dim cst As CryptoStream = New CryptoStream(ms, cryptoprovider.CreateEncryptor(bykey, byiv), CryptoStreamMode.Write)
            Dim sw As StreamWriter = New StreamWriter(cst)
            sw.Write(data)
            sw.Flush()
            cst.FlushFinalBlock()
            sw.Flush()
            Dim buffer As Byte() = ms.GetBuffer
            Dim bufferlength As Integer = ms.Length
            cryptoprovider = Nothing
            ms.Dispose()
            cst.Dispose()
            sw.Dispose()
            Return Convert.ToBase64String(buffer, 0, bufferlength)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Function Decode(ByVal data As String) As String
        Dim bykey As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(LoStrId.Password_Encryption)
        Dim byiv As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(LoStrId.Password_Encryption)
        Dim byenc As Byte()
        Try
            byenc = Convert.FromBase64String(data)
            Dim cryptoprovider As DESCryptoServiceProvider = New DESCryptoServiceProvider()
            Dim ms As MemoryStream = New MemoryStream(byenc)
            Dim cst As CryptoStream = New CryptoStream(ms, cryptoprovider.CreateDecryptor(bykey, byiv), CryptoStreamMode.Read)
            Dim sr As StreamReader = New StreamReader(cst)
            Return sr.ReadToEnd()
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Function ImageToBase64(image As Image, format As ImageFormat) As String
        Dim ms As New MemoryStream
        image.Save(ms, format)
        Dim imagebyte() As Byte = ms.ToArray
        Dim base64 As String = Convert.ToBase64String(imagebyte)
        Return base64
    End Function
    Function Base64ToImage(base64String As String) As Image

        Try
            Dim imagebyte() As Byte = Convert.FromBase64String(base64String)
            Dim ms As New MemoryStream(imagebyte, 0, imagebyte.Length)
            ms.Write(imagebyte, 0, imagebyte.Length)
            Dim img As Image = Image.FromStream(ms, True)
            Return img
        Catch ex As Exception
        End Try
    End Function
End Module
