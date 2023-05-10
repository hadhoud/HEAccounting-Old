
Public Class AccountsDetails
    Dim BoolSearchIsClicked As Boolean = False
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        ShowPermissions()
        FillDropList()
        SubscribeEvents()
    End Sub
    Private Sub SubscribeEvents()
        AddHandler Me.RadConOpen.Click, AddressOf ShowCard
    End Sub

    Sub ShowPermissions()
        tblCurrencyRow.Visible = BoolShowAccountDetailsTextCurrencyRate
        LblCurrencyVal.Visible = BoolShowAccountDetailsTextCurrencyRate
    End Sub

    Private Sub ShowCard()
        If Me.GridAccountsDetails.ChildRows.Count > 0 Then
            Dim ReferID As String
            Dim ReferType As String
            ReferID = Me.GridAccountsDetails.CurrentRow.Cells("Refer").Value.ToString
            ReferType = Me.GridAccountsDetails.CurrentRow.Cells("ReferType").Value.ToString
            Select Case ReferType.Trim
                Case AbbTransaction.SalesOrders, AbbTransaction.ReturnSales
                    Dim FrmShowSalesOrder As New AddNewSaleInvoice
                    FrmShowSalesOrder.BoolForEdit = True
                    FrmShowSalesOrder.InvID = ReferID
                    FrmShowSalesOrder.ShowDialog()
                    Exit Select
                Case AbbTransaction.PurchasesOrders, AbbTransaction.ReturnPurchases
                    Dim FrmShowPurchasesOrder As New AddNewPurchaseInvoice
                    FrmShowPurchasesOrder.BoolForEdit = True
                    FrmShowPurchasesOrder.InvID = ReferID
                    FrmShowPurchasesOrder.ShowDialog()
                    Exit Select
                Case AbbTransaction.NotesPay
                    Dim FrmShowNotesPay As New NotesPayable
                    FrmShowNotesPay.BoolForEdit = True
                    FrmShowNotesPay.NotesPayID = ReferID
                    FrmShowNotesPay.ShowDialog()
                    Exit Select
                Case AbbTransaction.NotesReceive
                    Dim FrmShowNotesReceive As New NoteReceive
                    FrmShowNotesReceive.BoolForEdit = True
                    FrmShowNotesReceive.NotesReceiveID = ReferID
                    FrmShowNotesReceive.ShowDialog()
                    Exit Select
                Case AbbTransaction.GeneralNotesPay, AbbTransaction.GeneralNotesReceive
                    Dim FrmShowGeneralNotes As New GeneralNotes
                    FrmShowGeneralNotes.BoolForEdit = True
                    FrmShowGeneralNotes.GeneralType = ReferType
                    FrmShowGeneralNotes.NotesID = ReferID
                    FrmShowGeneralNotes.ShowDialog()
                    Exit Select
            End Select
        End If
    End Sub
    Private Sub FillDropList()
        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrency.DataSource = Currencydata
        Initiatedropdownlist(Me.DropCurrency, False)
        Me.DropCurrency.SelectedValue = ProgramFormCurrency
    End Sub
    Private Sub AccountsDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtDollarRate.Text = LastDollarCurrencyRate
        Me.MskTxtInvDateFrom.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0)
    End Sub


    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        'Me.BtnAdd.Text = LoStrId.LblAdd
        'Me.BtnClose.Text = LoStrId.LblClose
        Me.Text = LoStrId.LblCurrencies
    End Sub

    Public Sub RefrechGrid()
        If Me.GridAccountsDetails.Visible = False Then
            Me.GridAccountsDetails.Visible = True
        End If
        Me.GridAccountsDetails.DataSource = Nothing
        Dim Param(4) As String
        Param(0) = "@CAccountNumber , " & Me.TxtAccounts.Text
        If CheckDetailsWithCurrency.Checked = True Then
            Param(1) = "@ICurrencyID , 0"
        Else
            Param(1) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
        End If

        If CheckDetailsWithCurrency.Checked = True Then
            Param(4) = "@ICurrencyRateID , " & Nothing
        Else
            Param(4) = "@ICurrencyRateID , " & Me.TxtCurrencyVal.Tag
        End If

        If CheckDateFrom.Checked = True Then
            Param(2) = "@TDateFrom , " & Me.MskTxtInvDateFrom.Value
        Else
            Param(2) = "@TDateFrom , 1991-01-01"
        End If
        If CheckDateTo.Checked = True Then
            Param(3) = "@TDateTo , " & Me.MskTxtInvDateTo.Value
        Else
            Param(3) = "@TDateTo , 1992-02-02"
        End If

        FillGridViewProcedureWithParameters(Me.GridAccountsDetails, "SelectAccountsReports", Param)
        InitiateGrid(Me.GridAccountsDetails)
        HideShowColummn(Me.GridAccountsDetails, Me.GridAccountsDetails.Columns("ReferType").Index, False)
        HideShowColummn(Me.GridAccountsDetails, Me.GridAccountsDetails.Columns("AccountNumber").Index, False)
        HideShowColummn(Me.GridAccountsDetails, Me.GridAccountsDetails.Columns("AccountName").Index, False)
        HideShowColummn(Me.GridAccountsDetails, Me.GridAccountsDetails.Columns("AccountLatinName").Index, False)
        HideShowColummn(Me.GridAccountsDetails, Me.GridAccountsDetails.Columns("CurrencyVal").Index, BoolShowAccountDetailsTextCurrencyRate)

        If Me.CheckDetailsWithCurrency.Checked = False Then
            Dim DtSum As DataTable = ExecuteProcedureDatatableWithParameters("SelectAccountDetailsSum", Param)
            Me.TxtForHim.Text = DtSum.Rows(0).Item("ForHim").ToString
            Me.TxtOnHim.Text = DtSum.Rows(0).Item("OnHim").ToString
            Me.TxtAccBalance.Text = DtSum.Rows(0).Item("Balance").ToString
            HideShowColummn(Me.GridAccountsDetails, Me.GridAccountsDetails.Columns("CurrName").Index, False)
            HideShowColummn(Me.GridAccountsDetails, Me.GridAccountsDetails.Columns("CurrencyVal").Index, False)
        Else
            Me.TxtForHim.Text = String.Empty
            Me.TxtOnHim.Text = String.Empty
            Me.TxtAccBalance.Text = String.Empty
        End If
        CheckCreditOrDebit()
    End Sub
    Private Sub CheckCreditOrDebit()
        If Me.TxtAccBalance.Text.Length <> 0 Then
            If Me.TxtAccBalance.Text.Contains("-") Then
                Me.LblCorD.BackColor = Color.Green
                Me.LblCorD.Text = Con.Credit
            ElseIf Me.TxtAccBalance.Text = 0 Then
                Me.LblCorD.BackColor = Color.Transparent
                Me.LblCorD.Text = String.Empty
            Else
                Me.LblCorD.BackColor = Color.Red
                Me.LblCorD.Text = Con.Debit
            End If
        Else
            Me.LblCorD.BackColor = Color.Transparent
            Me.LblCorD.Text = String.Empty
        End If
    End Sub

    Private Sub TxtAccountsBtn_Click(sender As Object, e As EventArgs) Handles TxtAccountsBtn.Click
        Dim FrmGetAccounts As New Accounts
        FrmGetAccounts.GetAccountPopup = True
        FrmGetAccounts.ShowDialog()
        If FrmGetAccounts.GetAccountNum.Length <> 0 And FrmGetAccounts.GetAccountName.Length <> 0 Then
            Me.TxtAccounts.Text = FrmGetAccounts.GetAccountNum
            BoolSearchIsClicked = False
        End If
    End Sub

    Private Sub CheckDateFrom_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDateFrom.ToggleStateChanged
        If Me.CheckDateFrom.Checked = True Then
            Me.MskTxtInvDateFrom.Enabled = True
        Else
            Me.MskTxtInvDateFrom.Enabled = False
        End If
        BoolSearchIsClicked = False
    End Sub

    Private Sub CheckDateTo_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDateTo.ToggleStateChanged
        If Me.CheckDateTo.Checked = True Then
            Me.MskTxtInvDateTo.Enabled = True
        Else
            Me.MskTxtInvDateTo.Enabled = False
        End If
        BoolSearchIsClicked = False
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        If Me.TxtAccounts.Text.Trim.Length <> 0 And Me.DropCurrency.SelectedIndex <> -1 Then
            RefrechGrid()
            BoolSearchIsClicked = True
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.txtDollarRate.Text = LastDollarCurrencyRate
        Me.TxtAccounts.Text = String.Empty
        Me.CheckDateFrom.Checked = False
        Me.CheckDateTo.Checked = False
        Me.MskTxtInvDateFrom.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0)
        Me.LblCorD.BackColor = Color.Transparent
        Me.TxtForHim.Text = String.Empty
        Me.TxtOnHim.Text = String.Empty
        Me.TxtAccBalance.Text = String.Empty
        Me.LblCorD.Text = String.Empty
        Me.CheckDetailsWithCurrency.Checked = False
        Me.DropCurrency.SelectedValue = 1
        Me.GridAccountsDetails.DataSource = Nothing
        Me.GridAccountsDetails.Visible = False
        BoolSearchIsClicked = False
    End Sub

    Private Sub CheckDetailsWithCurrency_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDetailsWithCurrency.ToggleStateChanged
        If CheckDetailsWithCurrency.Checked = True Then
            Me.DropCurrency.Enabled = False
            Me.BtnGetCurrencyVal.Enabled = False
        Else
            Me.DropCurrency.Enabled = True
            Me.BtnGetCurrencyVal.Enabled = True
        End If
        BoolSearchIsClicked = False
    End Sub

    Private Sub DropCurrency_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles DropCurrency.SelectedIndexChanged
        DropCurerncySelectedChange()
    End Sub

    Private Sub DropCurerncySelectedChange()
        If Me.DropCurrency.SelectedIndex <> -1 Then
            If Me.DropCurrency.SelectedValue.ToString = "1" Then
                Me.TxtCurrencyVal.Text = "1"
                Me.TxtCurrencyVal.Tag = "1"
            Else
                Dim CurrencyRow As DataRow = Currencydata.Select("CurrencyID = " & Me.DropCurrency.SelectedValue).First
                Me.TxtCurrencyVal.Text = CurrencyRow("CurrencyVal").ToString
                Me.TxtCurrencyVal.Tag = CurrencyRow("LastChangeID").ToString
            End If
        End If
        BoolSearchIsClicked = False
    End Sub

    Private Sub BtnGetCurrencyVal_Click(sender As Object, e As EventArgs) Handles BtnGetCurrencyVal.Click
        If (Control.ModifierKeys = Keys.Control) And Me.DropCurrency.SelectedValue <> "1" Then
            Dim FrmAddCurrVal As New CurrencyRate
            FrmAddCurrVal.GetCurrencyRate = True
            FrmAddCurrVal.ShowDialog()
            If FrmAddCurrVal.GetCurrencyVal.Length <> 0 And FrmAddCurrVal.GetCurrencyRateID.Length <> 0 Then
                Me.TxtCurrencyVal.Text = FrmAddCurrVal.GetCurrencyVal
                Me.TxtCurrencyVal.Tag = FrmAddCurrVal.GetCurrencyRateID
            End If
        Else
            DropCurerncySelectedChange()
        End If
        BoolSearchIsClicked = False
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If Me.TxtAccounts.Text.Trim.Length = 0 Then
            MessageShowInfo(Con.Msg_Enter_All_Fields)
            Exit Sub
        End If
        If Not BoolSearchIsClicked Then
            MessageShowInfo(Con.Msg_Press_Search_Button)
            Exit Sub
        End If
        If Me.GridAccountsDetails.ChildRows.Count = 0 Then
            MessageShowInfo(Con.Msg_No_Trx_on_Accounts)
            Exit Sub
        End If
        Dim Balance As String
        If Me.TxtAccBalance.Text.Contains("-") Then
            Balance = Me.TxtAccBalance.Text.Replace("-", "")
        Else
            Balance = IIf(Me.TxtAccBalance.Text.Trim.Length = 0, "0", Me.TxtAccBalance.Text)
        End If

        Dim param(5) As String
        param(0) = "AccountNumber , " & Me.TxtAccounts.Text
        If CheckDateFrom.Checked = True Then
            param(1) = "DateFrom , " & Me.MskTxtInvDateFrom.Value
        Else
            param(1) = "DateFrom , 1991-01-01"
        End If
        If CheckDateTo.Checked = True Then
            param(2) = "DateTO , " & Me.MskTxtInvDateTo.Value
        Else
            param(2) = "DateTO , 1992-02-02"
        End If
        If CheckDetailsWithCurrency.Checked = True Then
            param(3) = "CurrencyID , 0"
            param(4) = "CurrencyRateID , 0"
            param(5) = "BalanceW , 0"
            OpenReport(Con.RptAccReportsCurrency, param)
        Else
            param(3) = "CurrencyID , " & Me.DropCurrency.SelectedValue
            param(4) = "CurrencyRateID , " & Me.TxtCurrencyVal.Tag
            If BoolLTRLanguage Then
                param(5) = "BalanceW , " & AmountInWords.AmountInWordsEn(Balance, CurrencyID:=Me.DropCurrency.SelectedValue)
            Else
                param(5) = "BalanceW , " & AmountInWords.AmountInWordsAr(Convert.ToDouble(Balance), Me.DropCurrency.SelectedValue)
            End If
            OpenReport(Con.RptAccReports, param)
        End If

    End Sub
End Class
