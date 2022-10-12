Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Cryptography
Imports Telerik.Reporting
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

'RadRibbonBar1.LocalizationSettings.ShowQuickAccessMenuBelowItemText = "ENG Show below the ribbon"
'RadRibbonBar1.LocalizationSettings.MinimizeRibbonItemText = "ENG Minimize the ribbon"
'RadRibbonBar1.LocalizationSettings.ShowQuickAccessMenuAboveItemText = "ENG Show above the ribbon"
'RadRibbonBar1.LocalizationSettings.MaximizeRibbonItemText = "ENG Maximize the ribbon"
'RadRibbonBar1.LocalizationSettings.LayoutModeText = "Simplified Ribbon"
Module Functions
    ReadOnly Db As New Database
    Enum Status
        'Order current status. Posted = 1 morhal ;UnPosted = 2 Not Morahal;
        Posted = 1
        UnPosted = 2
    End Enum
    Structure PaymentType
        'Order current status. Posted = 1 morhal ;UnPosted = 2 Not Morahal;
        Const Cash = "C"
        Const Debt = "D"
        Const Paid = "PI"
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
    Function ChangeTextButtonToRight(ByVal BTnTextBox As RadButtonTextBox, ByVal BTnElement As RadButtonElement)
        BTnTextBox.LeftButtonItems.Remove(BTnElement)
        BTnTextBox.RightButtonItems.Add(BTnElement)
        Return True
    End Function
    Public Sub UpdateLang(ByVal Lang As String)
        Dim param(1) As String
        param(0) = "@lang , " & Lang
        param(1) = "@LTR , " & IIf(Lang = "Ar", False, True)
        ExecuteProcedureWithParameters("UpdateLanguage", param)
        Home.GetAppSettings()
    End Sub
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
                Return "سعر البيع"

            Case "PurchasingPrice"
                Return "سعر الشراء"

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

            Case "CurrencyVal"
                Return "قيمة الصرف"

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

            Case "SubTotal", "BeforeDiscount"
                Return "المجموع"


            Case "Status", "StatusName"
                Return "الحالة"

            Case "SanadStatusName", "SanadStatus"
                Return "حالة السند"

                'Currency
            Case "CurrName"
                Return "إسم العملة"

            Case "Symb"
                Return "رمز العملة"

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

            Case "SubTotal"
                Return "SubTotal"

            Case "TotalDue"
                Return "Total Due"

            Case "Status"
                Return "Status"

                'Currency
            Case "CurrName"
                Return "Cur. Name"

            Case "CurrencyVal"
                Return "Cur. Rate"

            Case "Symb"
                Return "Symbol"

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

    Public Sub InitiateTitleForm(ByVal Frm As RadForm, Optional ByVal TitleFlg As Boolean = False)
        Frm.FormElement.TitleBar.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        '  Frm.FormElement.TitleBar.TitlePrimitive.ForeColor = Color.White
        If TitleFlg Then
            If BoolLTRLanguage Then
                Frm.Text = LoStrId.LblLatinProgramName
            Else
                Frm.Text = LoStrId.LblProgramName
            End If
        End If
    End Sub


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

    Public Sub InitiateGrid(ByVal grid As RadGridView, Optional ByVal Editing As Boolean = False, Optional ByVal Grouping As Boolean = False, Optional ByVal Bestfit As Boolean = False)
        grid.AllowAddNewRow = False
        grid.AllowEditRow = Editing
        grid.AllowDeleteRow = False
        grid.AllowCellContextMenu = False
        grid.AllowRowHeaderContextMenu = False
        grid.AllowColumnHeaderContextMenu = False
        grid.AllowColumnChooser = False
        grid.AllowColumnReorder = False
        grid.AllowRowResize = False
        grid.ClipboardCutMode = GridViewClipboardCutMode.Disable
        grid.ClipboardCopyMode = GridViewClipboardCopyMode.Disable
        grid.ClipboardPasteMode = GridViewClipboardPasteMode.Disable
        grid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grid.EnableGrouping = Grouping
        grid.RightToLeft = RightToLeft.Inherit
        grid.AutoSizeRows = False
        grid.TableElement.RowHeight = 35
        grid.TableElement.TableHeaderHeight = 35
        grid.Font = New System.Drawing.Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point)
        For Each Col As GridViewDataColumn In grid.Columns
            Col.TextAlignment = ContentAlignment.MiddleCenter
            If BoolLTRLanguage Then
                Col.HeaderText = ChangeColNameToEnglish(Col.Name)
            Else
                Col.HeaderText = ChangeColNameToArabic(Col.Name)
            End If
            Col.AutoSizeMode = BestFitColumnMode.None
            Col.BestFit()
            If (Col.Name.ToLower.Contains("code") Or Col.Name.ToLower.Contains("id")) And Col.Name.ToLower <> "notesid" Then
                Col.AutoSizeMode = BestFitColumnMode.HeaderCells
                Col.BestFit()
                Col.Width = 45
            ElseIf Col.Name.Contains("Date") Then
                Col.FormatString = "{0:dd/MM/yyyy}"
                Col.AutoSizeMode = BestFitColumnMode.AllCells
                Col.BestFit()
            End If
        Next

    End Sub

    Public Sub InitiateGridChild(ByVal grid As GridViewTemplate)
        grid.AllowAddNewRow = False
        grid.AllowEditRow = False
        grid.AllowDeleteRow = False
        grid.AllowCellContextMenu = False
        grid.AllowRowHeaderContextMenu = False
        grid.AllowColumnHeaderContextMenu = False
        grid.AllowColumnChooser = False
        grid.AllowColumnReorder = False
        grid.AllowRowResize = False
        grid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grid.EnableGrouping = False
        'grid.RightToLeft = RightToLeft.Inherit
        'grid.s = False
        'grid.TableElement.RowHeight = 35
        'grid.TableElement.TableHeaderHeight = 35
        'grid.Font = New Drawing.Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point)
        For Each Col As GridViewDataColumn In grid.Columns
            Col.TextAlignment = ContentAlignment.MiddleCenter
            If BoolLTRLanguage Then
                Col.HeaderText = ChangeColNameToEnglish(Col.Name)
            Else
                Col.HeaderText = ChangeColNameToArabic(Col.Name)
            End If
            If Col.Name.Contains("Date") Then
                Col.FormatString = "{0:dd/MM/yyyy}"
            End If
        Next

    End Sub
    Public Sub Initiatedropdownlist(ByVal dropddown As RadDropDownList, Optional ByVal SelectedindexZero As Boolean = True)
        dropddown.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        dropddown.RootElement.Alignment = ContentAlignment.MiddleCenter
        dropddown.DefaultItemsCountInDropDown = 9
        dropddown.ListElement.ItemHeight = 30
        dropddown.Font = Appfont
        For Each rad As RadListDataItem In dropddown.Items
            rad.Font = Appfont
            rad.TextAlignment = ContentAlignment.MiddleCenter
        Next
        If SelectedindexZero Then
            dropddown.SelectedIndex = -1
        End If
    End Sub

    Public Sub HideShowColummn(ByVal Grid As RadGridView, ByVal Index As Integer, ByVal IsVsible As Boolean)
        Grid.Columns(Index).IsVisible = IsVsible
    End Sub

    Public Sub HideShowColummnChild(ByVal Grid As GridViewTemplate, ByVal Index As Integer, ByVal IsvVsible As Boolean)
        Grid.Columns(Index).IsVisible = IsvVsible
    End Sub
    Public Sub FillGridViewProcedure(ByVal Grid As RadGridView, ByVal ProcedureName As String)
        Grid.MasterTemplate.BeginUpdate()
        Grid.MasterTemplate.DataSource = Db.SelectProcedureDataTable(ProcedureName)
        Grid.MasterTemplate.EndUpdate()
    End Sub

    Public Sub FillTreeProcedure(ByVal MTree As RadTreeView, ByVal ProcedureName As String)
        MTree.BeginUpdate()
        MTree.DataSource = Db.SelectProcedureDataTable(ProcedureName)
        MTree.ValueMember = "GroupID"
        MTree.DisplayMember = "GroupName"
        MTree.EndUpdate()
    End Sub

    Public Sub FillGridViewQuery(ByVal Grid As RadGridView, ByVal Query As String)
        Grid.BeginUpdate()
        Grid.DataSource = Db.SelectQueryDatatable(Query)
        Grid.EndUpdate()
    End Sub

    Public Sub FilterGrid(ByVal Grid As RadGridView, ByVal FilterPropertyName As String, ByVal FilterStr As String, ByVal Opera As Telerik.WinControls.Data.FilterOperator)
        Dim filter As New FilterDescriptor With {
            .PropertyName = FilterPropertyName,
            .Operator = Opera,
            .Value = FilterStr
        }
        '   filter.IsFilterEditor = True
        Grid.EnableFiltering = True
        Grid.ShowFilteringRow = False
        Grid.FilterDescriptors.Add(filter)
        If Grid.Rows.Count = 0 Then
            Grid.ShowNoDataText = True
        End If
    End Sub

    Public Sub FillGridViewProcedureWithParameters(ByVal Grid As RadGridView, ByVal ProcedureName As String, ByVal Param() As String)
        Grid.MasterTemplate.BeginUpdate()
        Grid.MasterTemplate.DataSource = Db.SelectProcedureDataTableWithParam(ProcedureName, GetSqlParameter(Param))
        Grid.MasterTemplate.EndUpdate()
    End Sub

    Public Sub ExecuteProcedureWithParameters(ByVal ProcedureName As String, ByVal Param() As String)
        Db.ExecuteProcedureWithParam(ProcedureName, GetSqlParameter(Param))
    End Sub
    Public Sub ExecuteQuerySQL(ByVal Query As String)
        Db.ExecuteQuery(Query)
    End Sub
    Function ExecuteQueryDatatable(ByVal Query As String) As DataTable
        Return Db.SelectQueryDatatable(Query)
    End Function
    Function GetSqlParameter(ByVal Param() As String) As SqlParameter()
        Dim TypeChar As String
        Dim parametercount As Integer = Param.Count - 1
        Dim OneSqlParameter As SqlParameter
        Dim ReturnSqlParameter(parametercount) As SqlParameter
        Dim i As Integer = 0
        Dim ParameterName As String
        Dim ParameterValue As String
        For Each pa In Param
            Dim PR() As String
            PR = pa.Split(",")
            ParameterName = PR(0).Trim
            ParameterValue = PR(1).Trim
            TypeChar = ParameterName.Substring(1, 1)

            Select Case TypeChar

                Case "I" 'Integer
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.Int)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = Integer.Parse(ParameterValue)
                    End If
                    Exit Select

                Case "F" 'Float
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.Float)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = Double.Parse(ParameterValue)
                    End If
                    Exit Select

                Case "B" 'Bit
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.Bit) With {
                        .Value = Convert.ToBoolean(ParameterValue)
                    }
                    Exit Select

                Case "D"
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.Decimal)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = Decimal.Parse(ParameterValue)
                    End If
                    Exit Select

                Case "T"
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.DateTime)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = Convert.ToDateTime(ParameterValue)
                    End If
                    Exit Select

                Case "C"
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.NVarChar)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = ParameterValue
                    End If
                    Exit Select

                Case "V"
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.NVarChar)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = ParameterValue
                    End If
                    Exit Select

                Case Else
                    OneSqlParameter = New SqlParameter(ParameterName, SqlDbType.Char)
                    If ParameterValue = "" Then
                        OneSqlParameter.Value = DBNull.Value
                    Else
                        OneSqlParameter.Value = ParameterValue
                    End If
                    Exit Select

            End Select

            ReturnSqlParameter(i) = OneSqlParameter
            i += 1
        Next

        Return ReturnSqlParameter

    End Function

    Function GetValueQuery(ByVal Query As String) As String
        Return Db.GetScalarQuery(Query)
    End Function

    Function GetScalarProcedure(ByVal Procedure As String, ByVal Param() As String) As String
        Return Db.GetScalarProcedureWithParam(Procedure, GetSqlParameter(Param))
    End Function
    Function ExecuteProcedureDatatableWithParameters(ByVal Procedure As String, ByVal Param() As String) As DataTable
        Return Db.SelectProcedureDataTableWithParam(Procedure, GetSqlParameter(Param))
    End Function

    Function ExecuteProcedureDatatable(ByVal Procedure As String) As DataTable
        Return Db.SelectProcedureDataTable(Procedure)
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
