Public Class OpeningBalance
    Dim CurrencyRound As Integer = "0"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If Me.TxtCreditFor.Text <> "0" Or Me.TxtDebitOn.Text <> "0" And
        Me.TxtAccName.Text <> String.Empty Then
            If MessageShowAsk(Con.Ask_Add) = DialogResult.Yes Then
                Dim Param(5) As String
                Param(0) = "@CAccountNumber , " & Me.TxtAccounts.Text
                Param(1) = "@FForHim  ," & Me.TxtCreditFor.Text
                Param(2) = "@FOnHim   , " & Me.TxtDebitOn.Text
                Param(3) = "@IUserID , " & UserID
                Param(4) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                Param(5) = "@FCurrencyVal , " & Me.TxtCurrencyVal.Text
                ExecuteProcedureWithParameters("InsertBaLancedAccount", Param)
                FormClear()
            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub
    Private Sub DropCurerncySelectedChange()
        If Me.DropCurrency.SelectedIndex <> -1 Then
            Dim CurrencyRow As DataRow = Currencydata.Select("CurrencyID = " & Me.DropCurrency.SelectedValue).First
            'CurrencyinitialState = CurrencyRow("initialstate").ToString
            CurrencyRound = CurrencyRow("CurrFloat").ToString
            If Me.DropCurrency.SelectedValue.ToString = "1" Then
                Me.TxtCurrencyVal.Text = "1"
                Me.TxtCurrencyVal.Tag = "1"
            Else
                Me.TxtCurrencyVal.Text = CurrencyRow("CurrencyVal").ToString
                Me.TxtCurrencyVal.Tag = CurrencyRow("LastChangeID").ToString
            End If
            If CurrencyRound = "-1" Then
                Me.TxtCreditFor.Mask = "F0"
                Me.TxtDebitOn.Mask = "F0"
            Else
                Me.TxtCreditFor.Mask = "F" & CurrencyRound
                Me.TxtDebitOn.Mask = "F" & CurrencyRound
            End If
            GetBalance()
        End If
    End Sub
    Private Sub FillDropList()
        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrency.DataSource = Currencydata
        Initiatedropdownlist(Me.DropCurrency, False)
    End Sub
    Private Sub FormClear()
        Me.TxtAccName.Text = String.Empty
        Me.TxtAccounts.Text = String.Empty
        Me.TxtCreditFor.Text = "0"
        Me.TxtDebitOn.Text = "0"
    End Sub
    Private Sub GetBalance()
        Dim Param(3) As String
        Param(0) = "@CAccountNumber , " & Me.TxtAccounts.Text
        Param(1) = "@CWhatToSelect , OP"
        Param(2) = "@ICurrencyID ," & Me.DropCurrency.SelectedValue
        Param(3) = "@FCurrencyVal ," & Me.TxtCurrencyVal.Text
        Dim CreditDebit As DataTable = ExecuteProcedureDatatableWithParameters("GetCreditDebitAccount", Param)
        Me.TxtCreditFor.Text = "0"
        Me.TxtDebitOn.Text = "0"
        Dim Credit As String = CreditDebit.Rows(0).Item("Credit").ToString
        Dim Debit As String = CreditDebit.Rows(0).Item("Debit").ToString
        Me.TxtCreditFor.Text = Credit
        Me.TxtDebitOn.Text = Debit
    End Sub

    Private Sub TxtAccountsBtn_Click(sender As Object, e As EventArgs) Handles TxtAccountsBtn.Click
        Dim FrmGetAccounts As New Accounts
        FrmGetAccounts.GetAccountPopup = True
        FrmGetAccounts.ShowDialog()
        If FrmGetAccounts.GetAccountNum.Length <> 0 And FrmGetAccounts.GetAccountName.Length <> 0 Then
            Me.TxtAccounts.Text = FrmGetAccounts.GetAccountNum
            'AccountName = FrmGetAccounts.GetAccountName
            Me.TxtAccName.Text = FrmGetAccounts.GetAccountName
            GetBalance()
        End If
    End Sub

    Private Sub TxtCreditFor_TextChanged(sender As Object, e As EventArgs) Handles TxtCreditFor.TextChanged
        If Me.TxtCreditFor.Text <> "0" Then
            Me.TxtDebitOn.Text = "0"
        End If
    End Sub

    Private Sub TxtDebitOn_TextChanged(sender As Object, e As EventArgs) Handles TxtDebitOn.TextChanged
        If Me.TxtDebitOn.Text <> "0" Then
            Me.TxtCreditFor.Text = "0"
        End If
    End Sub

    Private Sub OpeningBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDropList()
    End Sub

    Private Sub DropCurrency_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles DropCurrency.SelectedIndexChanged
        DropCurerncySelectedChange()
    End Sub

    Private Sub BtnGetCurrencyVal_Click(sender As Object, e As EventArgs) Handles BtnGetCurrencyVal.Click
        If (Control.ModifierKeys = Keys.Control) And Me.DropCurrency.SelectedValue <> "1" Then
            Dim FrmAddCurrVal As New CurrencyRate
            FrmAddCurrVal.GetCurrencyRate = True
            FrmAddCurrVal.ShowDialog()
            If FrmAddCurrVal.GetCurrencyVal.Length <> 0 And FrmAddCurrVal.GetCurrencyRateID.Length <> 0 Then
                Me.TxtCurrencyVal.Text = FrmAddCurrVal.GetCurrencyVal
                'EditCurrencyRateID = FrmAddCurrVal.GetCurrencyRateID
                GetBalance()
            End If
        Else
            DropCurerncySelectedChange()
        End If
    End Sub
End Class
