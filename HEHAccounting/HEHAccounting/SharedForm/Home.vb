Public NotInheritable Class Home

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    Public FrmMainForm As MainForm
    Private Sub Home_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        Me.Version.Text = System.String.Format(Me.Version.Text, Con.Lbl_One_Version, Con.Lbl_Two_Version, Con.Lbl_Year_One_Version, Con.Lbl_Year_Two_Version)
        BackgroundWorker1.RunWorkerAsync()
        'FrmMainForm = New MainForm
        'FrmMainForm.Show()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Application.DoEvents()

        'Groups Data
        GroupNameAuto = New AutoCompleteStringCollection
        Dim dtGroupNameAuto As New DataTable
        dtGroupNameAuto.BeginLoadData()
        dtGroupNameAuto = ExecuteQueryDatatable("Select GroupName From Groups")
        dtGroupNameAuto.EndLoadData()
        For i As Integer = 0 To dtGroupNameAuto.Rows.Count - 1
            GroupNameAuto.Add(dtGroupNameAuto.Rows(i).Item(0).ToString.ToLower)
        Next

        'Customers Data
        CustomerNameAuto = New AutoCompleteStringCollection
        Dim dtCustomerNameAuto As New DataTable
        dtCustomerNameAuto.BeginLoadData()
        dtCustomerNameAuto = ExecuteProcedureDatatable("SelectCustomers")
        dtCustomerNameAuto.EndLoadData()
        For i As Integer = 0 To dtCustomerNameAuto.Rows.Count - 1
            ' CustomerNameAuto.Add(dtCustomerNameAuto.Rows(i).Item(0))
            CustomerNameAuto.Add(dtCustomerNameAuto.Rows(i).Item("CustomerName").ToString.ToLower _
                            & "/" & dtCustomerNameAuto.Rows(i).Item("CustomerTitle").ToString.ToLower _
                            & "/" & dtCustomerNameAuto.Rows(i).Item("CustomerID").ToString)
        Next

        'Items Data
        ItemsNameAuto = New AutoCompleteStringCollection
        Dim dt As New DataTable
        dt.BeginLoadData()
        dt = ExecuteProcedureDatatable("SelectItemName")
        dt.EndLoadData()
        For i As Integer = 0 To dt.Rows.Count - 1
            ItemsNameAuto.Add(dt.Rows(i).Item(0).ToString.ToLower)
        Next

        'Vendors Data
        Dim dtVendorNameAuto As New DataTable
        VendorNameAuto = New AutoCompleteStringCollection
        dtVendorNameAuto.BeginLoadData()
        dtVendorNameAuto = ExecuteProcedureDatatable("SelectVendors")
        dtVendorNameAuto.EndLoadData()
        For i As Integer = 0 To dtVendorNameAuto.Rows.Count - 1
            VendorNameAuto.Add(dtVendorNameAuto.Rows(i).Item("VendorName").ToString.ToLower _
                                & "/" & dtVendorNameAuto.Rows(i).Item("VendorTitle").ToString.ToLower _
                                & "/" & dtVendorNameAuto.Rows(i).Item("VendorID").ToString)
        Next


        'Vendors Customers Data
        Dim dtVendorsCustomersNameAuto As New DataTable
        VendorsCustomersAuto = New AutoCompleteStringCollection
        dtVendorsCustomersNameAuto.BeginLoadData()
        dtVendorsCustomersNameAuto = ExecuteProcedureDatatable("SelectVendorsCustomers")
        dtVendorsCustomersNameAuto.EndLoadData()
        For i As Integer = 0 To dtVendorsCustomersNameAuto.Rows.Count - 1
            VendorsCustomersAuto.Add(dtVendorsCustomersNameAuto.Rows(i).Item("Name").ToString.ToLower _
                                & "/" & dtVendorsCustomersNameAuto.Rows(i).Item("Title").ToString.ToLower _
                                & "/" & dtVendorsCustomersNameAuto.Rows(i).Item("ID").ToString _
                                 & "/" & dtVendorsCustomersNameAuto.Rows(i).Item("Type").ToString)
        Next

        ReloadCurrency()
        ReloadUserRoles()
        GetUserSettings()
        GetUserOptionPanelsSettings()
        GetUserFieldsSetting()
        GetAppSettings()
        GetCompanyInfo()
        FrmMainForm = New MainForm
        '  LogMessage("FrmMainForm6")
    End Sub

    Public Sub ReloadCurrency()
        'Currencydata
        Currencydata = Nothing
        Currencydata = New DataTable
        '   Currencydata.Clear()
        Currencydata = ExecuteProcedureDatatable("SelectCurrencies")
        'LogMessage("Currency1")
        LastDollarCurrencyRate = GetScalarProcedureWithoutParam("GetLastDollarRate")
    End Sub

    Public Sub ReloadUserRoles()
        UserRolesdt = Nothing
        UserRolesdt = New DataTable
        Dim param(0) As String
        param(0) = "@IUserID , " & UserID
        UserRolesdt = ExecuteProcedureDatatableWithParameters("SelectUsersRoles", param)
        'LogMessage("ReloadUserRoles2")
    End Sub

    Public Sub GetUserSettings()
        Dim Param(0) As String
        Param(0) = "@IUserID , " & UserID
        Dim UserSettingDt As DataTable = ExecuteProcedureDatatableWithParameters("SelectUserSettings", Param)
        If UserSettingDt.Rows.Count > 0 Then
            'Program General Setting
            BoolShowDailyPageWhenOpen = UserSettingDt.Rows(0).Item("SShowDailyPage")
            BoolShowProgramAlerts = UserSettingDt.Rows(0).Item("SShowProgramAlerts")
            TimerHomeForm = UserSettingDt.Rows(0).Item("SHomeTimer").ToString
            TimerDailyForm = UserSettingDt.Rows(0).Item("SDailyTimer").ToString
            ShowChequesDay = UserSettingDt.Rows(0).Item("SShowChequesDay").ToString
            ProgramFormCurrency = UserSettingDt.Rows(0).Item("SHomeFormCurrency").ToString

            'User Permissions:
            BoolShowHomeScreenByUser = UserSettingDt.Rows(0).Item("bShowHomeScreenByUser")
            'BoolShowPurchasingPriceInScreensByUser = UserSettingDt.Rows(0).Item("bShowHomeScreenByUser")
            BoolShowDashboardScreenByUser = UserSettingDt.Rows(0).Item("bShowDashboardFormByUser")
            BoolShowSalesDailyWinScreenByUser = UserSettingDt.Rows(0).Item("bShowSalesDailyWinScreenByUser")
            BoolShowPurchasingPriceInScreensByUser = UserSettingDt.Rows(0).Item("bShowPurchasingPriceInScreensByUser")
            BoolShowItemsSalesWinReportScreenByUser = UserSettingDt.Rows(0).Item("bShowItemsSalesWinReportScreenByUser")
            BoolShowProfitsTextInScreenByUser = UserSettingDt.Rows(0).Item("bShowProfitsTextInScreenByUser")

            'Customer Setting
            BoolAllowCustomerRepetition = UserSettingDt.Rows(0).Item("SAllowCustomerRepetition")
            BoolForcingEnterCustomerLatin = UserSettingDt.Rows(0).Item("SForcingEnterCustomerLatin")

            'Vendor Setting
            BoolAllowVendorRepetition = UserSettingDt.Rows(0).Item("SAllowVendorRepetition")
            BoolForcingEnterVendorLatin = UserSettingDt.Rows(0).Item("SForcingEnterVendorLatin")

            'Sale Order Setting
            BoolShowItemsInSOMainForm = UserSettingDt.Rows(0).Item("SShowItemsInSOMainForm")
            BoolShowSOAsWindow = UserSettingDt.Rows(0).Item("SShowSOAsWindow")
            DefaultSOStatus = UserSettingDt.Rows(0).Item("SSOStatus")
            iSalesOrderDefaultCustomerID = UserSettingDt.Rows(0).Item("iSODefaultCustomerID")
            BoolShowSalesOrdersPrintQuestionAfterSave = UserSettingDt.Rows(0).Item("bSalesOrdersShowPrintQuestionAfterSave")

            'Purchase Order Setting
            BoolShowItemsInPOMainForm = UserSettingDt.Rows(0).Item("SShowItemsInPOMainForm")
            BoolUpdateItemSellingPriceAfterPO = UserSettingDt.Rows(0).Item("SUpdateItemSellingPriceAfterPO")
            BoolUpdateItemPurchasingPriceAfterPO = UserSettingDt.Rows(0).Item("SUpdateItemPurchasingPriceAfterPO")
            DefaultPOStatus = UserSettingDt.Rows(0).Item("SPOStatus")
            'BoolShowAddPurchasesOrdersColPurchasePrice = UserSettingDt.Rows(0).Item("SAddPurchasesOrdersColPurchasePrice")

            'Notes Pay Setting
            DefaultNPStatus = UserSettingDt.Rows(0).Item("SNPStatus")

            'Notes Receive Setting
            DefaultNRStatus = UserSettingDt.Rows(0).Item("SNRStatus")

            'Curency Setting
            BoolForcingEnterCurrencyNameLatin = UserSettingDt.Rows(0).Item("SForcingEnterCurrencyNameLatin")
            BoolForcingEnterCurrencyPartLatin = UserSettingDt.Rows(0).Item("SForcingEnterCurrencyPartLatin")
            BoolForcingEnterCurrencySymbLatin = UserSettingDt.Rows(0).Item("SForcingEnterCurrencySymbLatin")

            'Report Setting
            ReportFormCurrency = UserSettingDt.Rows(0).Item("SReportFormCurrency").ToString

            BoolShowCurrencyRateInStatus = UserSettingDt.Rows(0).Item("bShowCurrencyRateInStatus")

            'LogMessage("GetUserSettings3")
        End If
    End Sub

    Public Sub GetUserOptionPanelsSettings()
        Dim Param(0) As String
        Param(0) = "@IUserID , " & UserID
        Dim UserOptionPanelsSettingDt As DataTable = ExecuteProcedureDatatableWithParameters("SelectUserOptionPanelsSettings", Param)
        If UserOptionPanelsSettingDt.Rows.Count > 0 Then
            'Option Panels Setting
            BoolOptionPanelTreasury = UserOptionPanelsSettingDt.Rows(0).Item("bTreasuryShow_fl")
            BoolOptionPanelDaily = UserOptionPanelsSettingDt.Rows(0).Item("bDailyShow_fl")
            BoolOptionPanelAnalysis = UserOptionPanelsSettingDt.Rows(0).Item("bAnalysisShow_fl")
            BoolOptionPanelSalesProfits = UserOptionPanelsSettingDt.Rows(0).Item("bSalesProfitsShow_fl")
            BoolOptionPanelItemsSalesProfits = UserOptionPanelsSettingDt.Rows(0).Item("bItemsSalesProfitsShow_fl")
            BoolOptionPanelItems = UserOptionPanelsSettingDt.Rows(0).Item("bItemsShow_fl")
            BoolOptionPanelCustomers = UserOptionPanelsSettingDt.Rows(0).Item("bCustomersShow_fl")
            BoolOptionPanelVendors = UserOptionPanelsSettingDt.Rows(0).Item("bVendorsShow_fl")
            BoolOptionPanelSalesOrders = UserOptionPanelsSettingDt.Rows(0).Item("bSalesOrdersShow_fl")
            BoolOptionPanelPurchasesOrders = UserOptionPanelsSettingDt.Rows(0).Item("bPurchasesOrdersShow_fl")
            BoolOptionPanelCreditorsDebitors = UserOptionPanelsSettingDt.Rows(0).Item("bCreditorsDebitorsShow_fl")
            BoolOptionPanelAllInventory = UserOptionPanelsSettingDt.Rows(0).Item("bAllInventoryShow_fl")
            BoolOptionPanelQuantityHistory = UserOptionPanelsSettingDt.Rows(0).Item("bQuantityHistoryShow_fl")
        End If
    End Sub

    Public Sub GetUserFieldsSetting()
        Dim Param(0) As String
        Param(0) = "@IUserID , " & UserID
        Dim UserFieldsSettingDt As DataTable = ExecuteProcedureDatatableWithParameters("SelectUserFieldsVisibleSettings", Param)
        If UserFieldsSettingDt.Rows.Count > 0 Then
            'Fields Visible settings
            BoolShowSalesOrdersColCustomerTitle = UserFieldsSettingDt.Rows(0).Item("bShowSalesOrdersColCustomerTitle")
            BoolShowSalesOrdersColTotalDueLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesOrdersColTotalDueLL")
            BoolShowSalesOrdersColTotalDueUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesOrdersColTotalDueUSD").ToString
            BoolShowSalesOrdersColDiscountLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesOrdersColDiscountLL").ToString
            BoolShowSalesOrdersColDiscountUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesOrdersColDiscountUSD").ToString
            BoolShowSalesOrdersColSubTotalLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesOrdersColSubTotalLL").ToString
            BoolShowSalesOrdersColSubTotalUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesOrdersColSubTotalUSD")
            BoolShowSalesOrdersColCurrencySymb = UserFieldsSettingDt.Rows(0).Item("bShowSalesOrdersColCurrencySymb").ToString
            BoolShowSalesOrdersColCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowSalesOrdersColCurrencyRate").ToString
            BoolShowSalesOrdersColStatus = UserFieldsSettingDt.Rows(0).Item("bShowSalesOrdersColStatus").ToString

            'Sales Win
            BoolShowSalesWinColTotalDueLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColTotalDueLL").ToString
            BoolShowSalesWinColTotalDueUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColTotalDueUSD").ToString
            BoolShowSalesWinColDiscountLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColDiscountLL").ToString
            BoolShowSalesWinColDiscountUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColDiscountUSD").ToString
            BoolShowSalesWinColSubTotalLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColSubTotalLL").ToString
            BoolShowSalesWinColSubTotalUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColSubTotalUSD").ToString
            BoolShowSalesWinColSubTotalPurchasingLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColSubTotalPurchasingLL").ToString
            BoolShowSalesWinColSubTotalPurchasingUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColSubTotalPurchasingUSD").ToString
            BoolShowSalesWinColColProfitLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColProfitLL").ToString
            BoolShowSalesWinColColProfitUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColProfitUSD").ToString
            BoolShowSalesWinColCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowSalesWinColCurrencyRate").ToString

            'sales Items Win
            BoolShowSalesItemsWinColPurchasingPriceLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColPurchasingPriceLL").ToString
            BoolShowSalesItemsWinColPurchasingPriceUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColPurchasingPriceUSD").ToString
            BoolShowSalesItemsWinColSellingPriceLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColSellingPriceLL").ToString
            BoolShowSalesItemsWinColSellingPriceUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColSellingPriceUSD").ToString
            BoolShowSalesItemsWinColTotalPurchasingPriceLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColTotalPurchasingPriceLL").ToString
            BoolShowSalesItemsWinColTotalPurchasingPriceUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColTotalPurchasingPriceUSD").ToString
            BoolShowSalesItemsWinColSubTotalSellingPriceLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColSubTotalSellingPriceLL").ToString
            BoolShowSalesItemsWinColSubTotalSellingPriceUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColSubTotalSellingPriceUSD").ToString
            BoolShowSalesItemsWinColDiscountLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColDiscountLL").ToString
            BoolShowSalesItemsWinColDiscountUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColDiscountUSD").ToString
            BoolShowSalesItemsWinColTotalDueSellingPriceLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColTotalDueSellingPriceLL").ToString
            BoolShowSalesItemsWinColTotalDueSellingPriceUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColTotalDueSellingPriceUSD").ToString
            BoolShowSalesItemsWinColSellPurchaseDifferenceLL = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColSellPurchaseDifferenceLL").ToString
            BoolShowSalesItemsWinColSellPurchaseDifferenceUSD = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColSellPurchaseDifferenceUSD").ToString
            BoolShowSalesItemsWinColCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowSalesItemsWinColCurrencyRate").ToString


            'Purchase Order
            BoolShowPurchaseOrdersColVendorTitle = UserFieldsSettingDt.Rows(0).Item("bShowPurchaseOrdersColVendorTitle").ToString
            BoolShowPurchaseOrdersColSubTotalLL = UserFieldsSettingDt.Rows(0).Item("bShowPurchaseOrdersColSubTotalLL").ToString
            BoolShowPurchaseOrdersColSubTotalUSD = UserFieldsSettingDt.Rows(0).Item("bShowPurchaseOrdersColSubTotalUSD").ToString
            BoolShowPurchaseOrdersColDiscountLL = UserFieldsSettingDt.Rows(0).Item("bShowPurchaseOrdersColDiscountLL").ToString
            BoolShowPurchaseOrdersColDiscountUSD = UserFieldsSettingDt.Rows(0).Item("bShowPurchaseOrdersColDiscountUSD").ToString
            BoolShowPurchaseOrdersColTotalDueLL = UserFieldsSettingDt.Rows(0).Item("bShowPurchaseOrdersColTotalDueLL").ToString
            BoolShowPurchaseOrdersColTotalDueUSD = UserFieldsSettingDt.Rows(0).Item("bShowPurchaseOrdersColTotalDueUSD").ToString
            BoolShowPurchaseOrdersColCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowPurchaseOrdersColCurrencyRate").ToString
            BoolShowPurchaseOrdersColStatus = UserFieldsSettingDt.Rows(0).Item("bShowPurchaseOrdersColStatus").ToString
            BoolShowPurchaseOrdersColCurrencySymb = UserFieldsSettingDt.Rows(0).Item("bShowPurchaseOrdersColCurrencySymb").ToString

            'Add Sales ORder
            BoolShowAddSalesOrdersColPurchasePrice = UserFieldsSettingDt.Rows(0).Item("bShowAddSalesOrdersColPurchasePrice")
            BoolShowAddSalesOrdersTextCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowAddSalesOrdersTextCurrencyRate")
            BoolShowAddSalesOrdersTextProftis = UserFieldsSettingDt.Rows(0).Item("bShowAddSalesOrdersTextProftis")

            'Add Purchase Order
            BoolShowAddPurchasesOrdersColPurchasePrice = UserFieldsSettingDt.Rows(0).Item("bShowAddPurchasesOrdersColPurchasePrice")
            BoolShowAddPurchasesOrdersTextCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowAddPurchasesOrdersTextCurrencyRate")

            'Invoice Sales order Report
            BoolShowInvSaleOrderSubTotalLL = UserFieldsSettingDt.Rows(0).Item("bShowInvSaleOrderSubTotalLL").ToString
            BoolShowInvSaleOrderDiscountLL = UserFieldsSettingDt.Rows(0).Item("bShowInvSaleOrderDiscountLL").ToString
            BoolShowInvSaleOrderTotalDueLL = UserFieldsSettingDt.Rows(0).Item("bShowInvSaleOrderTotalDueLL").ToString
            BoolShowInvSaleOrderSubTotalUSD = UserFieldsSettingDt.Rows(0).Item("bShowInvSaleOrderSubTotalUSD").ToString
            BoolShowInvSaleOrderDiscountUSD = UserFieldsSettingDt.Rows(0).Item("bShowInvSaleOrderDiscountUSD").ToString
            BoolShowInvSaleOrderTotalDueUSD = UserFieldsSettingDt.Rows(0).Item("bShowInvSaleOrderTotalDueUSD").ToString
            BoolShowInvSaleOrderCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowInvSaleOrderCurrencyRate").ToString
            BoolShowInvSaleOrderBalanceLL = UserFieldsSettingDt.Rows(0).Item("bShowInvSaleOrderBalanceLL").ToString
            BoolShowInvSaleOrderBalanceUSD = UserFieldsSettingDt.Rows(0).Item("bShowInvSaleOrderBalanceUSD").ToString

            'Customer Invoices Sales order Report
            BoolShowCustomerInvSalesOrdersTotalDueUSD = UserFieldsSettingDt.Rows(0).Item("bShowCustomerInvSaleOrderTotalDueUSD").ToString
            BoolShowCustomerInvSalesOrdersTotalDueLL = UserFieldsSettingDt.Rows(0).Item("bShowCustomerInvSaleOrderTotalDueLL").ToString
            BoolShowCustomerInvSalesOrdersCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowCustomerInvSaleOrderCurrencyRate").ToString

            'Account Details
            BoolShowAccountDetailsTextCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowAccountDetailsTextCurrencyRate")

            'Items Form
            BoolShowItemsFormColBarcode = UserFieldsSettingDt.Rows(0).Item("bShowItemsFormColBarcode")
            BoolShowItemsFormColLatinName = UserFieldsSettingDt.Rows(0).Item("bShowItemsFormColLatinName")

            'Notes Pay
            BoolShowNotePayTextCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowNotePayTextCurrencyRate")
            BoolShowNotePayTextAmountEquality = UserFieldsSettingDt.Rows(0).Item("bShowNotePayTextAmountEquality")

            'Notes Receive
            BoolShowNoteReceiveTextCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowNoteReceiveTextCurrencyRate")
            BoolShowNoteReceiveTextAmountEquality = UserFieldsSettingDt.Rows(0).Item("bShowNoteReceiveTextAmountEquality")

            'General Notes
            BoolShowGeneralNoteTextCurrencyRate = UserFieldsSettingDt.Rows(0).Item("bShowGeneralNoteTextCurrencyRate")
            BoolShowGeneralNoteTextAmountEquality = UserFieldsSettingDt.Rows(0).Item("bShowGeneralNoteTextAmountEquality")

        End If
    End Sub

    Public Sub GetAppSettings()

        Dim AppSettingDt As DataTable = ExecuteProcedureDatatable("SelectAppSettings")
        Con = New HEConstant
        If AppSettingDt IsNot Nothing Then
            If AppSettingDt.Rows.Count > 0 Then
                BoolShowBarcode = AppSettingDt.Rows(0).Item("ShowBarcode")
                Lang = AppSettingDt.Rows(0).Item("language").ToString
                BoolShowLang = AppSettingDt.Rows(0).Item("ShowLanguage")
                BoolLTRLanguage = AppSettingDt.Rows(0).Item("LTR")
                BoolShowUnits = AppSettingDt.Rows(0).Item("ShowUnits")
                BoolShowUsers = AppSettingDt.Rows(0).Item("ShowUsers")
                BoolShowSalesDailyWin = AppSettingDt.Rows(0).Item("bShowSalesDailyWinScreen")
                BoolShowDashboardForm = AppSettingDt.Rows(0).Item("bShowDashboardForm")
            End If
            'LogMessage("GetAppSettings4")
        Else
            BoolShowBarcode = False
            Lang = "Ar"
            BoolShowLang = False
            BoolLTRLanguage = False
            BoolShowUnits = False
            BoolShowUsers = False
            BoolShowSalesDailyWin = False
            BoolShowDashboardForm = False
        End If

    End Sub

    Private Sub GetCompanyInfo()
        Dim CompanyInfoDt As DataTable = ExecuteProcedureDatatable("SelectCompanyInfo")
        If CompanyInfoDt.Rows.Count > 0 Then
            CompanyInfoName = CompanyInfoDt.Rows(0).Item("CompanyName").ToString
            CompanyAddress = CompanyInfoDt.Rows(0).Item("Address").ToString
            CompanyLatinAddress = CompanyInfoDt.Rows(0).Item("LatinAddress").ToString
            CompanyPhone = CompanyInfoDt.Rows(0).Item("Phone").ToString
            CompanyCellPhone = CompanyInfoDt.Rows(0).Item("CellPhone").ToString
            CompanyLatinName = CompanyInfoDt.Rows(0).Item("LatinName").ToString
            CompanyEmail = CompanyInfoDt.Rows(0).Item("Email").ToString
            'LogMessage("GetCompanyInfo5")
        Else
            CompanyInfoName = ""
            CompanyLatinName = "AL Hadi Accounting"
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Hide()
        FrmMainForm.Show()
        Me.Close()
    End Sub
End Class
