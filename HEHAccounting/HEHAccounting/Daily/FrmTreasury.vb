Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Telerik.WinControls.UI

Public Class FrmTreasury
    Private Sub FrmTreasury_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitiateDatePicker()
        FillDropCurrencyFromCurrencyData(Me.DropCurrency, "CurrencyID", True)
        Initiatedropdownlist(Me.DropCurrency, False)
        Me.DropCurrency.SelectedValue = ProgramFormCurrency
        FirstRunTimer.Enabled = True
    End Sub

    Private Sub InitiateDatePicker()
        InitiateDateTimePicker(DateTimePickerFrom, DateSerial(2020, 1, 1), True, False)
        InitiateDateTimePicker(DateTimePickerTo, DateSerial(2020, 1, 1), True, False)
    End Sub
    Private Sub FirstRunTimer_Tick(sender As Object, e As EventArgs) Handles FirstRunTimer.Tick
        FillSummaryInformation()
    End Sub

    Private Sub FillSummaryInformation()
        FirstRunTimer.Enabled = False
        Dim selected_Currecny As Integer = Me.DropCurrency.SelectedValue

        Dim Summarydt As New DataTable
        Dim param(3) As String
        param(0) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
        param(1) = "@tFromDate , " & Me.DateTimePickerFrom.Value
        param(2) = "@tTODate , " & Me.DateTimePickerTo.Value
        param(3) = "@iDollarRate_amt , " & LastDollarCurrencyRate

        Summarydt = ExecuteProcedureDatatableWithParameters("GetTreasuryFormData", param)

        ConvertMaskedTextToCurrency(TxtSOCash, Summarydt.Rows(0).Item("SOCach").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtSODebt, Summarydt.Rows(0).Item("SODebit").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtRSODebt, Summarydt.Rows(0).Item("RSODebit").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtRSOCash, Summarydt.Rows(0).Item("RSOCach").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtSO, Summarydt.Rows(0).Item("TotalSO").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtRSO, Summarydt.Rows(0).Item("TotalRSO").ToString, selected_Currecny)

        ConvertMaskedTextToCurrency(TxtPOCash, Summarydt.Rows(0).Item("POCach").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtPODebt, Summarydt.Rows(0).Item("PODebit").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtRPODebt, Summarydt.Rows(0).Item("RPODebit").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtRPOCash, Summarydt.Rows(0).Item("RPOCach").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtPO, Summarydt.Rows(0).Item("TotalPO").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtRPO, Summarydt.Rows(0).Item("TotalRPO").ToString, selected_Currecny)

        ConvertMaskedTextToCurrency(TxtNotePayCash, Summarydt.Rows(0).Item("NPCach").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtNotePayCheck, Summarydt.Rows(0).Item("NPCheck").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtNotePay, Summarydt.Rows(0).Item("TotalNP").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtNoteReceiveCash, Summarydt.Rows(0).Item("NRCach").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtNoteReceiveCheck, Summarydt.Rows(0).Item("NRCheck").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtNoteReceive, Summarydt.Rows(0).Item("TotalNR").ToString, selected_Currecny)

        ConvertMaskedTextToCurrency(TxtInCash, Summarydt.Rows(0).Item("IncomeCash").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtInDebt, Summarydt.Rows(0).Item("IncomeDebit").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtIN, Summarydt.Rows(0).Item("TotalIncome").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtOutCash, Summarydt.Rows(0).Item("OutcomeCash").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtOutDebt, Summarydt.Rows(0).Item("OutcomeDebit").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtOut, Summarydt.Rows(0).Item("TotalOutcome").ToString, selected_Currecny)

        ConvertMaskedTextToCurrency(txtSalesLL, Summarydt.Rows(0).Item("TotalSOLL").ToString, Currency.LebaneaseLire)
        ConvertMaskedTextToCurrency(txtSalesDollar, Summarydt.Rows(0).Item("TotalSOUSD").ToString, Currency.Dollar)
        ConvertMaskedTextToCurrency(txtSOPOLL, Summarydt.Rows(0).Item("TotalSOPOLL").ToString, Currency.LebaneaseLire)
        ConvertMaskedTextToCurrency(txtSOPODollar, Summarydt.Rows(0).Item("TotalSOPOUSD").ToString, Currency.Dollar)

        ConvertMaskedTextToCurrency(txtAllItemsPriceLL, Summarydt.Rows(0).Item("AllIemsPriceLL").ToString, Currency.LebaneaseLire)
        ConvertMaskedTextToCurrency(txtAllItemsPriceUSD, Summarydt.Rows(0).Item("AllIemsPriceUSD").ToString, Currency.Dollar)
        ConvertMaskedTextToCurrency(txtAllItemsPrice, Summarydt.Rows(0).Item("AllIemsPrice").ToString, selected_Currecny)

        ConvertMaskedTextToCurrency(txtSalesProfitLL, Summarydt.Rows(0).Item("SOProfitsLL").ToString, Currency.LebaneaseLire)
        ConvertMaskedTextToCurrency(txtSalesProfitDollar, Summarydt.Rows(0).Item("SOProfitsUSD").ToString, Currency.Dollar)

        txtSalesProfitPercent.Text = Summarydt.Rows(0).Item("SOProfitsPercent").ToString

        ConvertMaskedTextToCurrency(txtProfitsWithPaidNotes, Summarydt.Rows(0).Item("GeneralProfitsWithPaid").ToString, selected_Currecny)
        ConvertMaskedTextToCurrency(TxtGeneralProfits, Summarydt.Rows(0).Item("GeneralProfits").ToString, selected_Currecny)
        txtGeneralProfitPercent.Text = Summarydt.Rows(0).Item("GeneralProfitsPercent").ToString

        If Summarydt.Rows(0).Item("GeneralProfitsWithPaid").ToString.Contains("-") Then
            If selected_Currecny = 1 Then
                Me.txtProfitsWithPaidNotes.Text = Me.txtProfitsWithPaidNotes.Text.Remove(Me.txtProfitsWithPaidNotes.Text.IndexOf("-"), 1)
            End If
            Me.txtProfitsWithPaidNotes.BackColor = Color.Red
            Me.txtProfitsWithPaidNotes.ForeColor = Color.White
        Else
            Me.txtProfitsWithPaidNotes.BackColor = Color.Green
            Me.txtProfitsWithPaidNotes.ForeColor = Color.White

        End If
        If Summarydt.Rows(0).Item("GeneralProfits").ToString.Contains("-") Then
            If selected_Currecny = 1 Then
                Me.TxtGeneralProfits.Text = Me.TxtGeneralProfits.Text.Remove(Me.TxtGeneralProfits.Text.IndexOf("-"), 1)
            End If
            Me.TxtGeneralProfits.BackColor = Color.Red
            Me.TxtGeneralProfits.ForeColor = Color.White
        Else
            Me.TxtGeneralProfits.BackColor = Color.Green
            Me.TxtGeneralProfits.ForeColor = Color.White
        End If
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        FillSummaryInformation()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.DateTimePickerFrom.Value = DateTime.Now
        Me.DateTimePickerTo.Value = DateTime.Now
        Me.DropCurrency.SelectedValue = ProgramFormCurrency
        FillSummaryInformation()
    End Sub
End Class
