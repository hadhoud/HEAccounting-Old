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
        dtGroupNameAuto = ExecuteQueryDatatable("Select [GroupName] From [Groups]")
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

        ReloadCurrency()
        ReloadUserRoles()
        GetUserSettings()
        GetUserOptionPanelsSettings()
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
            HomeFormCurrency = UserSettingDt.Rows(0).Item("SHomeFormCurrency").ToString

            'User Permissions:
            BoolShowHomeScreenByUser = UserSettingDt.Rows(0).Item("bShowHomeScreenByUser")
            BoolShowPurchasingPriceInScreensByUser = UserSettingDt.Rows(0).Item("bShowHomeScreenByUser")
            BoolShowDashboardScreenByUser = UserSettingDt.Rows(0).Item("bShowDashboardFormByUser")
            BoolShowSalesDailyWinScreenByUser = UserSettingDt.Rows(0).Item("bShowSalesDailyWinScreenByUser")
            BoolShowPurchasingPriceInScreensByUser = UserSettingDt.Rows(0).Item("bShowPurchasingPriceInScreensByUser")
            BoolShowItemsSalesWinReportScreenByUser = UserSettingDt.Rows(0).Item("bShowItemsSalesWinReportScreenByUser")


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
            BoolShowAddSalesOrdersColPurchasePrice = UserSettingDt.Rows(0).Item("SAddSalesOrdersColPurchasePrice")
            BoolShowSalesOrdersColCustomerTitle = UserSettingDt.Rows(0).Item("SSalesOrdersColCustomerTitle")
            BoolShowSalesOrdersColCurrencySymb = UserSettingDt.Rows(0).Item("SSalesOrdersColCurrencySymb")
            iSalesOrderDefaultCustomerID = UserSettingDt.Rows(0).Item("iSODefaultCustomerID")
            BoolShowSalesOrdersPrintQuestionAfterSave = UserSettingDt.Rows(0).Item("bSalesOrdersShowPrintQuestionAfterSave")

            'Purchase Order Setting
            BoolShowItemsInPOMainForm = UserSettingDt.Rows(0).Item("SShowItemsInPOMainForm")
            BoolUpdateItemSellingPriceAfterPO = UserSettingDt.Rows(0).Item("SUpdateItemSellingPriceAfterPO")
            BoolUpdateItemPurchasingPriceAfterPO = UserSettingDt.Rows(0).Item("SUpdateItemPurchasingPriceAfterPO")
            DefaultPOStatus = UserSettingDt.Rows(0).Item("SPOStatus")
            BoolShowAddPurchasesOrdersColPurchasePrice = UserSettingDt.Rows(0).Item("SAddPurchasesOrdersColPurchasePrice")
            BoolShowPurchasesOrdersColVendorTitle = UserSettingDt.Rows(0).Item("SPurchasesOrdersColVendorTitle")
            BoolShowPurchasesOrdersColCurrencySymb = UserSettingDt.Rows(0).Item("SPurchasesOrdersColCurrencySymb")

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
                BoolShowCurrencyRateInStatus = AppSettingDt.Rows(0).Item("bShowCurrencyRateInStatus")
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
            BoolShowCurrencyRateInStatus = False
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
