Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class UserSettings

    Dim SODefaultCustomerID As String
    Dim SODefaultCustomerTitle As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        If BoolLTRLanguage Then
            ChangeToEng()
        End If

        ' Add any initialization after the InitializeComponent() call.
        RefrechGrid()
        InitiateGrid(Me.GridShortcuts)
        FillDropDown()
        ShowPermissions()
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.BtnClose.Text = LoStrId.LblClose
        Me.BtnSave.Text = LoStrId.LblSave

    End Sub
    Sub ShowPermissions()
        If UserType <> UserRole.Programmer Then
            Me.PageProgrammer.Item.Visibility = ElementVisibility.Collapsed
        End If
    End Sub
    Public Sub RefrechGrid()
        Dim Param(0) As String
        Param(0) = "@IUserID , " & UserID
        FillGridViewProcedureWithParameters(GridShortcuts, "SelectShortcuts", Param)
        HideShowColummn(Me.GridShortcuts, Me.GridShortcuts.Columns("UserID").Index, False)
        HideShowColummn(Me.GridShortcuts, Me.GridShortcuts.Columns("NameValue").Index, False)
        HideShowColummn(Me.GridShortcuts, IIf(BoolLTRLanguage, Me.GridShortcuts.Columns("Name").Index, Me.GridShortcuts.Columns("LatinName").Index), False)
    End Sub
    Private Sub FillDropDown()
        Dim Langitem As New RadListDataItem With {
           .Text = LoStrId.LangEn,
           .Value = LoStrId.LangEn
       }
        Me.DropLang.Items.Add(Langitem)

        Langitem = New RadListDataItem With {
            .Text = LoStrId.LangAr,
            .Value = LoStrId.LangAr
        }
        Me.DropLang.Items.Add(Langitem)

        Initiatedropdownlist(Me.DropLang, False)
        Me.DropLang.SelectedValue = Lang

        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrency.DataSource = Currencydata

        Dim CurrencydataReport As New BindingSource()
        CurrencydataReport.DataSource = Currencydata

        Me.DropCurrenyReport.ValueMember = "CurrencyID"
        Me.DropCurrenyReport.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrenyReport.DataSource = CurrencydataReport
        Initiatedropdownlist(Me.DropCurrency, False)
        Initiatedropdownlist(Me.DropCurrenyReport, False)

        'Sales ORder Status
        Dim SOStatusitem As New RadListDataItem With {
            .Text = Con.Posted,
            .Value = Status.Posted
        }
        Me.DropSOStatus.Items.Add(SOStatusitem)

        SOStatusitem = New RadListDataItem With {
            .Text = Con.UnPosted,
            .Value = Status.UnPosted
        }
        Me.DropSOStatus.Items.Add(SOStatusitem)

        Initiatedropdownlist(Me.DropSOStatus, False)

        'Purchase ORder Status
        Dim POStatusitem As New RadListDataItem With {
            .Text = Con.Posted,
            .Value = Status.Posted
        }
        Me.DropPOStatus.Items.Add(POStatusitem)

        POStatusitem = New RadListDataItem With {
            .Text = Con.UnPosted,
            .Value = Status.UnPosted
        }
        Me.DropPOStatus.Items.Add(POStatusitem)

        Initiatedropdownlist(Me.DropPOStatus, False)

        'Notes Receive Status
        Dim NRStatusitem As New RadListDataItem With {
            .Text = Con.Posted,
            .Value = Status.Posted
        }
        Me.DropNRStatus.Items.Add(NRStatusitem)

        NRStatusitem = New RadListDataItem With {
            .Text = Con.UnPosted,
            .Value = Status.UnPosted
        }
        Me.DropNRStatus.Items.Add(NRStatusitem)

        Initiatedropdownlist(Me.DropNRStatus, False)


        'Notes Pay Status
        Dim NPStatusitem As New RadListDataItem With {
            .Text = Con.Posted,
            .Value = Status.Posted
        }
        Me.DropNPStatus.Items.Add(NPStatusitem)

        NPStatusitem = New RadListDataItem With {
            .Text = Con.UnPosted,
            .Value = Status.UnPosted
        }
        Me.DropNPStatus.Items.Add(NPStatusitem)

        Initiatedropdownlist(Me.DropNPStatus, False)
    End Sub
    Private Sub UserSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Program General Setting
        Me.ChkShowDailyPageWhenOpen.Checked = BoolShowDailyPageWhenOpen
        Me.ChkShowProgramAlerts.Checked = BoolShowProgramAlerts
        Me.TimerHome.Value = TimerHomeForm
        Me.TimerDaily.Value = TimerDailyForm
        Me.NumChequesDay.Value = ShowChequesDay
        Me.DropCurrency.SelectedValue = ProgramFormCurrency

        'Customer Setting
        Me.ChkAllowCustomerRepetition.Checked = BoolAllowCustomerRepetition
        Me.ChkForcingEnterCustomerLatin.Checked = BoolForcingEnterCustomerLatin

        'Vendor Setting
        Me.ChkAllowVendorRepetition.Checked = BoolAllowVendorRepetition
        Me.ChkForcingEnterVendorLatin.Checked = BoolForcingEnterVendorLatin

        'Sale Order Setting
        Me.ChkShowItemsInSOMainForm.Checked = BoolShowItemsInSOMainForm
        Me.ChkShowSOInWindow.Checked = BoolShowSOAsWindow
        Me.DropSOStatus.SelectedValue = DefaultSOStatus

        Me.chkSOShowPrintQuestionAfterSave.Checked = BoolShowSalesOrdersPrintQuestionAfterSave
        LoadSODefaultCustomer()

        'Purchase Order Setting
        Me.ChkShowItemsInPOMainForm.Checked = BoolShowItemsInPOMainForm
        Me.ChkUpdateItemPurchasingPriceAfterPO.Checked = BoolUpdateItemPurchasingPriceAfterPO
        Me.ChkUpdateItemSellingPriceAfterPO.Checked = BoolUpdateItemSellingPriceAfterPO
        Me.DropPOStatus.SelectedValue = DefaultPOStatus

        'Me.ChkPurchasesOrdersColVendorTitle.Checked = BoolShowPurchasesOrdersColVendorTitle
        'Me.ChkPurchasesOrdersColCurrencySymb.Checked = BoolShowPurchasesOrdersColCurrencySymb
        'Me.chkAddPurchasesOrdersColPurchasePrice.Checked = BoolShowAddPurchasesOrdersColPurchasePrice


        'Notes Pay Setting
        Me.DropNPStatus.SelectedValue = DefaultNPStatus

        'Notes Receive Setting
        Me.DropNRStatus.SelectedValue = DefaultNRStatus


        'Report Setting
        Me.DropCurrenyReport.SelectedValue = ReportFormCurrency

        'AppSettings 
        Me.ChkShowBarcode.Checked = BoolShowBarcode
        Me.ChkShowUsers.Checked = BoolShowUsers
        Me.ChkShowItemsUnits.Checked = BoolShowUnits
        Me.ChkShowLang.Checked = BoolShowLang
        Me.chkShowSalesDailyWin.Checked = BoolShowSalesDailyWin
        Me.chkShowDashboardForm.Checked = BoolShowDashboardForm
        Me.chkShowCurrencyRateInStatus.Checked = BoolShowCurrencyRateInStatus

        Me.TxtSODefaultCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtSODefaultCustomer.AutoCompleteCustomSource = CustomerNameAuto
        Me.TxtSODefaultCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        'Option Panel Settings
        Me.chkOptionTreasury.Checked = BoolOptionPanelTreasury
        Me.chkOptionDaily.Checked = BoolOptionPanelDaily
        Me.chkOptionAnalysis.Checked = BoolOptionPanelAnalysis
        Me.chkOptionSalesProfits.Checked = BoolOptionPanelSalesProfits
        Me.chkOptionItemsSalesProfits.Checked = BoolOptionPanelItemsSalesProfits
        Me.chkOptionItems.Checked = BoolOptionPanelItems
        Me.chkOptionCustomers.Checked = BoolOptionPanelCustomers
        Me.chkOptionVendors.Checked = BoolOptionPanelVendors
        Me.chkOptionSalesOrders.Checked = BoolOptionPanelSalesOrders
        Me.chkOptionPurchasesOrders.Checked = BoolOptionPanelPurchasesOrders
        Me.chkOptionCreditorsDebitors.Checked = BoolOptionPanelCreditorsDebitors
        Me.chkOptionAllInventory.Checked = BoolOptionPanelAllInventory
        Me.chkOptionQuantityHistory.Checked = BoolOptionPanelQuantityHistory
    End Sub

    Private Sub GridShortcuts_KeyDown(sender As Object, e As KeyEventArgs) Handles GridShortcuts.KeyDown
        If e.Modifiers <> Keys.None And e.KeyCode <> Keys.ControlKey And e.KeyCode <> Keys.ShiftKey And e.KeyCode <> Keys.Menu Then
            Dim kc = New KeysConverter()
            Me.GridShortcuts.CurrentRow.Cells("ShortcutValue").Value = e.Modifiers.ToString & "+" & kc.ConvertToString(e.KeyCode)
        End If
    End Sub

    Private Sub UpdateUserShortcuts()
        For Each Row In Me.GridShortcuts.Rows
            Dim Param(2) As String
            Param(0) = "@CShortcutValue , " & Row.Cells("ShortcutValue").Value.ToString
            Param(1) = "@CNameValue , " & Row.Cells("NameValue").Value.ToString
            Param(2) = "@IUserID , " & UserID
            ExecuteProcedureWithParameters("UpdateUserShortcuts", Param)
        Next
    End Sub

    Private Sub UpdateUserOptionsPanelSetting()
        Dim Param(13) As String
        Param(0) = "@bTreasuryShow_fl , " & chkOptionTreasury.Checked
        Param(1) = "@bDailyShow_fl , " & chkOptionDaily.Checked
        Param(2) = "@bAnalysisShow_fl , " & chkOptionAnalysis.Checked
        Param(3) = "@bSalesProfitsShow_fl , " & chkOptionSalesProfits.Checked
        Param(4) = "@bItemsSalesProfitsShow_fl , " & chkOptionItemsSalesProfits.Checked
        Param(5) = "@bItemsShow_fl , " & chkOptionItems.Checked
        Param(6) = "@bCustomersShow_fl , " & chkOptionCustomers.Checked
        Param(7) = "@bVendorsShow_fl , " & chkOptionVendors.Checked
        Param(8) = "@bSalesOrdersShow_fl , " & chkOptionSalesOrders.Checked
        Param(9) = "@bPurchasesOrdersShow_fl , " & chkOptionPurchasesOrders.Checked
        Param(10) = "@bCreditorsDebitorsShow_fl , " & chkOptionCreditorsDebitors.Checked
        Param(11) = "@bAllInventoryShow_fl , " & chkOptionAllInventory.Checked
        Param(12) = "@bQuantityHistoryShow_fl , " & chkOptionQuantityHistory.Checked

        Param(13) = "@IUserID , " & UserID
        ExecuteProcedureWithParameters("UpdateUserDefaultOptionPanelsSetting", Param)
    End Sub

    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If MessageShowAsk(Con.Ask_Edit) = DialogResult.Yes Then
            Dim Param(23) As String
            Param(0) = "@BSShowDailyPage , " & IIf(ChkShowDailyPageWhenOpen.Checked = True, True, False)
            Param(1) = "@BSShowProgramAlerts , " & IIf(ChkShowProgramAlerts.Checked = True, True, False)
            Param(2) = "@BSAllowCustomerRepetition , " & IIf(ChkAllowCustomerRepetition.Checked = True, True, False)
            Param(3) = "@BSForcingEnterCustomerLatin , " & IIf(ChkForcingEnterCustomerLatin.Checked = True, True, False)
            Param(4) = "@BSAllowVendorRepetition , " & IIf(ChkAllowVendorRepetition.Checked = True, True, False)
            Param(5) = "@BSForcingEnterVendorLatin , " & IIf(ChkForcingEnterVendorLatin.Checked = True, True, False)
            Param(6) = "@BSShowItemsInSOMainForm , " & IIf(ChkShowItemsInSOMainForm.Checked = True, True, False)
            Param(7) = "@BSShowItemsInPOMainForm , " & IIf(ChkShowItemsInPOMainForm.Checked = True, True, False)
            Param(8) = "@BSUpdateItemSellingPriceAfterPO , " & IIf(ChkUpdateItemSellingPriceAfterPO.Checked = True, True, False)
            Param(9) = "@BSUpdateItemPurchasingPriceAfterPO , " & IIf(ChkUpdateItemPurchasingPriceAfterPO.Checked = True, True, False)
            Param(10) = "@HomeTimer , " & Me.TimerHome.Value
            Param(11) = "@DailyTimer , " & Me.TimerDaily.Value
            Param(12) = "@HomeFormCurrency , " & Me.DropCurrency.SelectedValue
            Param(13) = "@ReportFormCurrency , " & Me.DropCurrenyReport.SelectedValue
            Param(14) = "@BSShowSOAsWindow , " & IIf(ChkShowSOInWindow.Checked = True, True, False)
            Param(15) = "@ISShowChequesDay , " & Me.NumChequesDay.Value
            Param(16) = "@ISSOStatus , " & IIf(Me.DropSOStatus.SelectedValue <> Nothing, Me.DropSOStatus.SelectedValue, 1)
            Param(17) = "@ISPOStatus , " & IIf(Me.DropPOStatus.SelectedValue <> Nothing, Me.DropPOStatus.SelectedValue, 1)
            Param(18) = "@ISNPStatus , " & IIf(Me.DropNPStatus.SelectedValue <> Nothing, Me.DropNPStatus.SelectedValue, 1)
            Param(19) = "@ISNRStatus , " & IIf(Me.DropNRStatus.SelectedValue <> Nothing, Me.DropNRStatus.SelectedValue, 1)

            'Param(20) = "@BSAddSalesOrdersColPurchasePrice , " & IIf(chkAddSalesOrdersColPurchasePrice.Checked = True, True, False)
            ''Param(21) = "@BSAddPurchasesOrdersColPurchasePrice , " & IIf(chkAddPurchasesOrdersColPurchasePrice.Checked = True, True, False)
            'Param(22) = "@BSSalesOrdersColCustomerTitle , " & IIf(ChkSalesOrdersColCustomerTitle.Checked = True, True, False)
            ' Param(23) = "@BSSalesOrdersColCurrencySymb , " & IIf(ChkSalesOrdersColCurrencySymb.Checked = True, True, False)
            ' Param(24) = "@BSPurchasesOrdersColVendorTitle , " & IIf(ChkPurchasesOrdersColVendorTitle.Checked = True, True, False)
            'Param(25) = "@BSPurchasesOrdersColCurrencySymb , " & IIf(ChkPurchasesOrdersColCurrencySymb.Checked = True, True, False)

            Param(20) = "@iSODefaultCustomerID , " & IIf(SODefaultCustomerID = String.Empty, 0, SODefaultCustomerID)
            Param(21) = "@bSOShowPrintQuestionAfterSave , " & IIf(chkSOShowPrintQuestionAfterSave.Checked = True, True, False)
            Param(22) = "@bShowCurrencyRateInStatus , " & IIf(chkShowCurrencyRateInStatus.Checked = True, True, False)

            Param(23) = "@IUserID , " & UserID
            ExecuteProcedureWithParameters("UpdateUserSettings", Param)
            UpdateUserShortcuts()
            UpdateUserOptionsPanelSetting()
            If UserType = UserRole.Programmer Then
                UpdateAppSettings()
            End If
        End If
    End Sub

    Private Sub UpdateAppSettings()
        Dim Param(7) As String
        Param(0) = "@Clang , " & Me.DropLang.SelectedValue.ToString
        Param(1) = "@BShowBarcode , " & IIf(ChkShowBarcode.Checked = True, True, False)
        Param(2) = "@BShowLanguage , " & IIf(ChkShowLang.Checked = True, True, False)
        Param(3) = "@BShowUsers , " & IIf(ChkShowUsers.Checked = True, True, False)
        Param(4) = "@BLTR , " & IIf(Me.DropLang.SelectedValue = LoStrId.LangAr, False, True)
        Param(5) = "@BShowUnits , " & IIf(ChkShowItemsUnits.Checked = True, True, False)
        Param(6) = "@bShowSalesDailyWin , " & IIf(chkShowSalesDailyWin.Checked = True, True, False)
        Param(7) = "@bShowDashboardForm , " & IIf(chkShowDashboardForm.Checked = True, True, False)

        ExecuteProcedureWithParameters("UpdateAppSettings", Param)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub TxtSODefaultCustomer_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtSODefaultCustomer.Validating
        If Not CustomerNameAuto.Contains(Me.TxtSODefaultCustomer.Text.ToLower) Then
            If Not CustomerNameAuto.Contains(Me.TxtSODefaultCustomer.Text.ToLower & "/" & SODefaultCustomerTitle & "/" & SODefaultCustomerID) Then
                Me.TxtSODefaultCustomer.Text = String.Empty
                SODefaultCustomerID = String.Empty
                SODefaultCustomerTitle = String.Empty
            End If
        Else
            Dim CustomerData() As String = Me.TxtSODefaultCustomer.Text.Split("/")
            SODefaultCustomerID = CustomerData(2)
            Me.TxtSODefaultCustomer.Text = CustomerData(0)
            SODefaultCustomerTitle = CustomerData(1)
        End If
    End Sub

    Private Sub LoadSODefaultCustomer()
        For Each customer In CustomerNameAuto
            Dim CustomerData() As String = customer.Split("/")
            If iSalesOrderDefaultCustomerID.ToString() = CustomerData(2) Then
                Me.TxtSODefaultCustomer.Text = CustomerData(0)
                SODefaultCustomerID = iSalesOrderDefaultCustomerID
            End If
        Next
    End Sub

    Private Sub TxtSODefaultCustomerBtn_Click(sender As Object, e As EventArgs) Handles TxtCustomerBtn.Click
        Dim FrmGetCustomer As New CustomerPopup
        FrmGetCustomer.ShowDialog()
        If Not FrmGetCustomer.GetCustomerName.Length = 0 Then
            CustomerNameAuto.Add(FrmGetCustomer.GetCustomerName.ToLower)
            Me.TxtSODefaultCustomer.Text = FrmGetCustomer.GetCustomerName
        End If
    End Sub

    Private Sub TxtSODefaultCustomer_ToolTipTextNeeded(sender As Object, e As ToolTipTextNeededEventArgs) Handles TxtSODefaultCustomer.ToolTipTextNeeded
        e.ToolTipText = SODefaultCustomerTitle
    End Sub

End Class
