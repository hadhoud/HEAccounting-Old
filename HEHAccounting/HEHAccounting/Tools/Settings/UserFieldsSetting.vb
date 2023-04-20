Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class UserFieldsSetting
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        If BoolLTRLanguage Then
            ChangeToEng()
        End If

    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.BtnClose.Text = LoStrId.LblClose
        Me.BtnSave.Text = LoStrId.LblSave

    End Sub

    Private Sub UserSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkShowAddSalesOrdersColPurchasePrice.Visible = BoolShowPurchasingPriceInScreensByUser

        'Sales Orders
        ChkShowSalesOrdersColCustomerTitle.Checked = BoolShowSalesOrdersColCustomerTitle
        ChkShowSalesOrdersColTotalDueLL.Checked = BoolShowSalesOrdersColTotalDueLL
        ChkShowSalesOrdersColTotalDueUSD.Checked = BoolShowSalesOrdersColTotalDueUSD
        ChkShowSalesOrdersColDiscountLL.Checked = BoolShowSalesOrdersColDiscountLL
        ChkShowSalesOrdersColDiscountUSD.Checked = BoolShowSalesOrdersColDiscountUSD
        ChkShowSalesOrdersColSubTotalLL.Checked = BoolShowSalesOrdersColSubTotalLL
        ChkShowSalesOrdersColSubTotalUSD.Checked = BoolShowSalesOrdersColSubTotalUSD
        ChkShowSalesOrdersColCurrencySymb.Checked = BoolShowSalesOrdersColCurrencySymb
        ChkShowSalesOrdersColCurrencyRate.Checked = BoolShowSalesOrdersColCurrencyRate
        ChkShowSalesOrdersColStatus.Checked = BoolShowSalesOrdersColStatus

        'sales win
        ChkShowSalesWinColSubTotalLL.Checked = BoolShowSalesWinColSubTotalLL
        ChkShowSalesWinColSubTotalUSD.Checked = BoolShowSalesWinColSubTotalUSD
        ChkShowSalesWindColDiscountLL.Checked = BoolShowSalesWinColDiscountLL
        ChkShowSalesWindColDiscountUSD.Checked = BoolShowSalesWinColDiscountUSD
        ChkShowSalesWinColTotalDueLL.Checked = BoolShowSalesWinColTotalDueLL
        ChkShowSalesWinColTotalDueUSD.Checked = BoolShowSalesWinColTotalDueUSD
        ChkShowSalesWinColSubTotalPurchasingLL.Checked = BoolShowSalesWinColSubTotalPurchasingLL
        ChkShowSalesWinColSubTotalPurchasingUSD.Checked = BoolShowSalesWinColSubTotalPurchasingUSD
        ChkShowSalesWinColProfitLL.Checked = BoolShowSalesWinColColProfitLL
        ChkShowSalesWinColProfitUSD.Checked = BoolShowSalesWinColColProfitUSD
        ChkShowSalesWinColCurrencyRate.Checked = BoolShowSalesWinColCurrencyRate

        'Sales ITems Win
        ChkShowSalesItemsWinColPurchasingPriceLL.Checked = BoolShowSalesItemsWinColPurchasingPriceLL
        ChkShowSalesItemsWinColPurchasingPriceUSD.Checked = BoolShowSalesItemsWinColPurchasingPriceUSD
        ChkShowSalesItemsWinColSellingPriceLL.Checked = BoolShowSalesItemsWinColSellingPriceLL
        chkShowSalesItemsWinColSellingPriceUSD.Checked = BoolShowSalesItemsWinColSellingPriceUSD
        chkShowSalesItemsWinColTotalPurchasingPriceLL.Checked = BoolShowSalesItemsWinColTotalPurchasingPriceLL
        ChkShowSalesItemsWinColTotalPurchasingPriceUSD.Checked = BoolShowSalesItemsWinColTotalPurchasingPriceUSD
        chkShowSalesItemsWinColSubTotalSellingPriceLL.Checked = BoolShowSalesItemsWinColSubTotalSellingPriceLL
        chkShowSalesItemsWinColSubTotalSellingPriceUSD.Checked = BoolShowSalesItemsWinColSubTotalSellingPriceUSD
        chkShowSalesItemsWinColDiscountLL.Checked = BoolShowSalesItemsWinColDiscountLL
        chkShowSalesItemsWinColDiscountUSD.Checked = BoolShowSalesItemsWinColDiscountUSD
        chkShowSalesItemsWinColCurrencyRate.Checked = BoolShowSalesItemsWinColCurrencyRate
        chkShowSalesItemsWinColTotalDueSellingPriceLL.Checked = BoolShowSalesItemsWinColTotalDueSellingPriceLL
        chkShowSalesItemsWinColTotalDueSellingPriceUSD.Checked = BoolShowSalesItemsWinColTotalDueSellingPriceUSD
        chkShowSalesItemsWinColSellPurchaseDifferenceLL.Checked = BoolShowSalesItemsWinColSellPurchaseDifferenceLL
        chkShowSalesItemsWinColSellPurchaseDifferenceUSD.Checked = BoolShowSalesItemsWinColSellPurchaseDifferenceUSD

        'Purchase Order
        ChkPurchaseOrdersColVendorTitle.Checked = BoolShowPurchaseOrdersColVendorTitle
        chkShowPurchaseOrdersColSubTotalLL.Checked = BoolShowPurchaseOrdersColSubTotalLL
        chkShowPurchaseOrdersColSubTotalUSD.Checked = BoolShowPurchaseOrdersColSubTotalUSD
        chkShowPurchaseOrdersColDiscountLL.Checked = BoolShowPurchaseOrdersColDiscountLL
        chkShowPurchaseOrdersColDiscountUSD.Checked = BoolShowPurchaseOrdersColDiscountUSD
        chkShowPurchaseOrdersColTotalDueLL.Checked = BoolShowPurchaseOrdersColTotalDueLL
        chkShowPurchaseOrdersColTotalDueUSD.Checked = BoolShowPurchaseOrdersColTotalDueUSD
        chkShowPurchaseOrdersColCurrencyRate.Checked = BoolShowPurchaseOrdersColCurrencyRate
        chkShowPurchaseOrdersColStatus.Checked = BoolShowPurchaseOrdersColStatus
        ChkPurchaseOrdersColCurrencySymb.Checked = BoolShowPurchaseOrdersColCurrencySymb

        'Add Sales Orders
        chkShowAddSalesOrdersColPurchasePrice.Checked = BoolShowAddSalesOrdersColPurchasePrice

        'Purchase Order Setting
        chkAddPurchasesOrdersColPurchasePrice.Checked = BoolShowAddPurchasesOrdersColPurchasePrice

        'Invoice Sales order
        chkShowInvSaleOrderSubTotalLL.Checked = BoolShowInvSaleOrderSubTotalLL
        chkShowInvSaleOrderDiscountLL.Checked = BoolShowInvSaleOrderDiscountLL
        chkShowInvSaleOrderTotalDueLL.Checked = BoolShowInvSaleOrderTotalDueLL
        chkShowInvSaleOrderSubTotalUSD.Checked = BoolShowInvSaleOrderSubTotalUSD
        chkShowInvSaleOrderDiscountUSD.Checked = BoolShowInvSaleOrderDiscountUSD
        chkShowInvSaleOrderTotalDueUSD.Checked = BoolShowInvSaleOrderTotalDueUSD
        chkShowInvSaleOrderCurrencyRate.Checked = BoolShowInvSaleOrderCurrencyRate
        chkShowInvSaleOrderBalanceLL.Checked = BoolShowInvSaleOrderBalanceLL
        chkShowInvSaleOrderBalanceUSD.Checked = BoolShowInvSaleOrderBalanceUSD

        'Customer Invoices Sales order Report
        chkShowCustomerInvSaleOrderSubTotalUSD.Checked = BoolShowCustomerInvSalesOrdersTotalDueUSD
        chkShowCustomerInvSaleOrderSubTotalLL.Checked = BoolShowCustomerInvSalesOrdersTotalDueLL
        chkShowCustomerInvSaleOrderCurrencyRate.Checked = BoolShowCustomerInvSalesOrdersCurrencyRate

    End Sub

    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If MessageShowAsk(Con.Ask_Edit) = DialogResult.Yes Then
            Dim Param(60) As String

            'Sales Order
            Param(0) = "@bShowSalesOrdersColCustomerTitle , " & IIf(ChkShowSalesOrdersColCustomerTitle.Checked = True, True, False)
            Param(1) = "@bShowSalesOrdersColTotalDueLL , " & IIf(ChkShowSalesOrdersColTotalDueLL.Checked = True, True, False)
            Param(2) = "@bShowSalesOrdersColTotalDueUSD , " & IIf(ChkShowSalesOrdersColTotalDueUSD.Checked = True, True, False)
            Param(3) = "@bShowSalesOrdersColDiscountLL , " & IIf(ChkShowSalesOrdersColDiscountLL.Checked = True, True, False)
            Param(4) = "@bShowSalesOrdersColDiscountUSD , " & IIf(ChkShowSalesOrdersColDiscountUSD.Checked = True, True, False)
            Param(5) = "@bShowSalesOrdersColSubTotalLL , " & IIf(ChkShowSalesOrdersColSubTotalLL.Checked = True, True, False)
            Param(6) = "@bShowSalesOrdersColSubTotalUSD , " & IIf(ChkShowSalesOrdersColSubTotalUSD.Checked = True, True, False)
            Param(7) = "@bShowSalesOrdersColCurrencySymb , " & IIf(ChkShowSalesOrdersColCurrencySymb.Checked = True, True, False)
            Param(8) = "@bShowSalesOrdersColCurrencyRate , " & IIf(ChkShowSalesOrdersColCurrencyRate.Checked = True, True, False)
            Param(9) = "@bShowSalesOrdersColStatus , " & IIf(ChkShowSalesOrdersColStatus.Checked = True, True, False)

            'Sales Daily Profits
            Param(10) = "@bShowSalesWinColSubTotalLL, " & IIf(ChkShowSalesWinColSubTotalLL.Checked = True, True, False)
            Param(11) = "@bShowSalesWinColSubTotalUSD , " & IIf(ChkShowSalesWinColSubTotalUSD.Checked = True, True, False)
            Param(12) = "@bShowSalesWinColDiscountLL , " & IIf(ChkShowSalesWindColDiscountLL.Checked = True, True, False)
            Param(13) = "@bShowSalesWinColDiscountUSD , " & IIf(ChkShowSalesWindColDiscountUSD.Checked = True, True, False)
            Param(14) = "@bShowSalesWinColTotalDueLL , " & IIf(ChkShowSalesWinColTotalDueLL.Checked = True, True, False)
            Param(15) = "@bShowSalesWinColTotalDueUSD , " & IIf(ChkShowSalesWinColTotalDueUSD.Checked = True, True, False)
            Param(16) = "@bShowSalesWinColSubTotalPurchasingLL , " & IIf(ChkShowSalesWinColSubTotalPurchasingLL.Checked = True, True, False)
            Param(17) = "@bShowSalesWinColSubTotalPurchasingUSD , " & IIf(ChkShowSalesWinColSubTotalPurchasingUSD.Checked = True, True, False)
            Param(18) = "@bShowSalesWinColProfitLL , " & IIf(ChkShowSalesWinColProfitLL.Checked = True, True, False)
            Param(19) = "@bShowSalesWinColProfitUSD , " & IIf(ChkShowSalesWinColProfitUSD.Checked = True, True, False)
            Param(20) = "@bShowSalesWinColCurrencyRate , " & IIf(ChkShowSalesWinColCurrencyRate.Checked = True, True, False)

            'Sales Items Profits
            Param(21) = "@bShowSalesItemsWinColPurchasingPriceLL, " & IIf(ChkShowSalesItemsWinColPurchasingPriceLL.Checked = True, True, False)
            Param(22) = "@bShowSalesItemsWinColPurchasingPriceUSD , " & IIf(ChkShowSalesItemsWinColPurchasingPriceUSD.Checked = True, True, False)
            Param(23) = "@bShowSalesItemsWinColSellingPriceLL , " & IIf(ChkShowSalesItemsWinColSellingPriceLL.Checked = True, True, False)
            Param(24) = "@bShowSalesItemsWinColSellingPriceUSD , " & IIf(chkShowSalesItemsWinColSellingPriceUSD.Checked = True, True, False)
            Param(25) = "@bShowSalesItemsWinColTotalPurchasingPriceLL , " & IIf(chkShowSalesItemsWinColTotalPurchasingPriceLL.Checked = True, True, False)
            Param(26) = "@bShowSalesItemsWinColTotalPurchasingPriceUSD , " & IIf(ChkShowSalesItemsWinColTotalPurchasingPriceUSD.Checked = True, True, False)
            Param(27) = "@bShowSalesItemsWinColSubTotalSellingPriceLL , " & IIf(chkShowSalesItemsWinColSubTotalSellingPriceLL.Checked = True, True, False)
            Param(28) = "@bShowSalesItemsWinColSubTotalSellingPriceUSD , " & IIf(chkShowSalesItemsWinColSubTotalSellingPriceUSD.Checked = True, True, False)
            Param(29) = "@bShowSalesItemsWinColDiscountLL , " & IIf(chkShowSalesItemsWinColDiscountLL.Checked = True, True, False)
            Param(30) = "@bShowSalesItemsWinColDiscountUSD , " & IIf(chkShowSalesItemsWinColDiscountUSD.Checked = True, True, False)
            Param(31) = "@bShowSalesItemsWinColCurrencyRate , " & IIf(chkShowSalesItemsWinColCurrencyRate.Checked = True, True, False)
            Param(32) = "@bShowSalesItemsWinColTotalDueSellingPriceLL , " & IIf(chkShowSalesItemsWinColTotalDueSellingPriceLL.Checked = True, True, False)
            Param(33) = "@bShowSalesItemsWinColTotalDueSellingPriceUSD , " & IIf(chkShowSalesItemsWinColTotalDueSellingPriceUSD.Checked = True, True, False)
            Param(34) = "@bShowSalesItemsWinColSellPurchaseDifferenceLL , " & IIf(chkShowSalesItemsWinColSellPurchaseDifferenceLL.Checked = True, True, False)
            Param(35) = "@bShowSalesItemsWinColSellPurchaseDifferenceUSD , " & IIf(chkShowSalesItemsWinColSellPurchaseDifferenceUSD.Checked = True, True, False)

            'Purchase Orders
            Param(36) = "@bShowPurchaseOrdersColVendorTitle , " & IIf(ChkPurchaseOrdersColVendorTitle.Checked = True, True, False)
            Param(37) = "@bShowPurchaseOrdersColSubTotalLL , " & IIf(chkShowPurchaseOrdersColSubTotalLL.Checked = True, True, False)
            Param(38) = "@bShowPurchaseOrdersColSubTotalUSD , " & IIf(chkShowPurchaseOrdersColSubTotalUSD.Checked = True, True, False)
            Param(39) = "@bShowPurchaseOrdersColDiscountLL , " & IIf(chkShowPurchaseOrdersColDiscountLL.Checked = True, True, False)
            Param(40) = "@bShowPurchaseOrdersColDiscountUSD , " & IIf(chkShowPurchaseOrdersColDiscountUSD.Checked = True, True, False)
            Param(41) = "@bShowPurchaseOrdersColTotalDueLL , " & IIf(chkShowPurchaseOrdersColTotalDueLL.Checked = True, True, False)
            Param(42) = "@bShowPurchaseOrdersColTotalDueUSD , " & IIf(chkShowPurchaseOrdersColTotalDueUSD.Checked = True, True, False)
            Param(43) = "@bShowPurchaseOrdersColCurrencyRate , " & IIf(chkShowPurchaseOrdersColCurrencyRate.Checked = True, True, False)
            Param(44) = "@bShowPurchaseOrdersColStatus , " & IIf(chkShowPurchaseOrdersColStatus.Checked = True, True, False)
            Param(45) = "@bShowPurchaseOrdersColCurrencySymb , " & IIf(ChkPurchaseOrdersColCurrencySymb.Checked = True, True, False)

            'add sales Orders
            Param(46) = "@bShowAddSalesOrdersColPurchasePrice , " & IIf(chkShowAddSalesOrdersColPurchasePrice.Checked = True, True, False)

            'add Purchase Orders
            Param(47) = "@bShowAddPurchasesOrdersColPurchasePrice , " & IIf(chkAddPurchasesOrdersColPurchasePrice.Checked = True, True, False)

            'Invoice Sales order Report
            Param(48) = "@bShowInvSaleOrderSubTotalLL , " & IIf(chkShowInvSaleOrderSubTotalLL.Checked = True, True, False)
            Param(49) = "@bShowInvSaleOrderDiscountLL , " & IIf(chkShowInvSaleOrderDiscountLL.Checked = True, True, False)
            Param(50) = "@bShowInvSaleOrderTotalDueLL , " & IIf(chkShowInvSaleOrderTotalDueLL.Checked = True, True, False)
            Param(51) = "@bShowInvSaleOrderSubTotalUSD , " & IIf(chkShowInvSaleOrderSubTotalUSD.Checked = True, True, False)
            Param(52) = "@bShowInvSaleOrderDiscountUSD , " & IIf(chkShowInvSaleOrderDiscountUSD.Checked = True, True, False)
            Param(53) = "@bShowInvSaleOrderTotalDueUSD , " & IIf(chkShowInvSaleOrderTotalDueUSD.Checked = True, True, False)
            Param(54) = "@bShowInvSaleOrderCurrencyRate , " & IIf(chkShowInvSaleOrderCurrencyRate.Checked = True, True, False)
            Param(55) = "@bShowInvSaleOrderBalanceLL , " & IIf(chkShowInvSaleOrderBalanceLL.Checked = True, True, False)
            Param(56) = "@bShowInvSaleOrderBalanceUSD , " & IIf(chkShowInvSaleOrderBalanceUSD.Checked = True, True, False)

            'Customer Invoices Sales order Report
            Param(57) = "@bShowCustomerInvSalesOrdersTotalDueUSD, " & IIf(chkShowCustomerInvSaleOrderSubTotalUSD.Checked = True, True, False)
            Param(58) = "@bShowCustomerInvSalesOrdersTotalDueLL , " & IIf(chkShowCustomerInvSaleOrderSubTotalLL.Checked = True, True, False)
            Param(59) = "@bShowCustomerInvSalesOrdersCurrencyRate, " & IIf(chkShowCustomerInvSaleOrderCurrencyRate.Checked = True, True, False)

            Param(60) = "@IUserID , " & UserID
            ExecuteProcedureWithParameters("UpdateUserFieldsSetting", Param)
        End If
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class
