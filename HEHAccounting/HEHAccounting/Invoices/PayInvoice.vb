Imports Telerik.WinControls.UI

Public Class PayInvoice
    Public InvNum As String = ""
    Public ReferType As String = ""
    Public ReferTypeName As String = ""
    Public BoolForShowInv As Boolean = False
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
    End Sub
    Private Sub PayInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDropList()
        txtDollarRate.Text = LastDollarCurrencyRate
        FormClear()

        If Not BoolForShowInv Then
            ' EnableDisable(True)
        Else
            ' EnableDisable(False)
            ShowInvoice()
        End If
    End Sub
    Private Sub ChangeToEng()
        RightToLeft = RightToLeft.No
        '  Text = LoStrId.lblPurchaseOrder
        LblInvID.Text = LoStrId.LblInvID
        LblInvDate.Text = LoStrId.LblDate
        LblDueTotal.Text = LoStrId.LblDueTotal
        BtnPay.Text = LoStrId.LblSaveNew
        BtnPrint.Text = LoStrId.LblPrint
    End Sub
    Private Sub FillDropList()
        DropCurrency.ValueMember = "CurrencyID"
        DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        DropCurrency.DataSource = Currencydata
        Initiatedropdownlist(DropCurrency)
        DropCurrency.SelectedValue = ProgramFormCurrency
    End Sub
    Public Sub ShowInvoice()
        Dim Param(1) As String
        Param(0) = "@IInvID  , " & InvNum
        Param(1) = "@CReferType  , " & ReferType
        Dim DtInv As DataTable = ExecuteProcedureDatatableWithParameters("SelectInvoiceToPay", Param)

        TxtInvID.Text = InvNum
        txtInvoiceCurrencySymb.Text = DtInv.Rows(0).Item("CurrencySymb").ToString
        ConvertMaskedTextToCurrency(txtInvTotalLL, DtInv.Rows(0).Item("TotalDueLL").ToString, Currencies.Currency.LebaneaseLire)
        txtInvTotalUSD.Text = DtInv.Rows(0).Item("TotalDueUSD").ToString

        ConvertMaskedTextToCurrency(txtInvPaymentTotalLL, DtInv.Rows(0).Item("TotalPaymentAmountLL").ToString, Currencies.Currency.LebaneaseLire)
        txtInvPaymentTotalUSD.Text = DtInv.Rows(0).Item("TotalPaymentAmountUSD").ToString
        TxtInvType.Text = ReferTypeName
    End Sub

    Private Sub FormClear()
        TxtInvID.Text = String.Empty
        TxtPaymentAmount.Text = "0"
        TxtInvType.Text = String.Empty
        MskTxtPayDate.Value = Date.Now.Date
    End Sub
    Private Sub EnableDisable(ByVal En As Boolean)
        TxtPaymentAmount.Enabled = En
        TxtInvID.Enabled = En
        TxtInvType.Enabled = En
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        If Val(TxtPaymentAmount.Text) > 0 And Val(txtDollarRate.Text) > 0 Then
            If MessageShowAsk(Con.Ask_Pay) = DialogResult.Yes Then
                Dim Param(8) As String
                Param(0) = "@iReferID  , " & TxtInvID.Text
                Param(1) = "@cReferType , " & ReferType
                Param(2) = "@tPaymentDate , " & MskTxtPayDate.Value
                Param(3) = "@fPaymentAmount, " & TxtPaymentAmount.Text
                Param(4) = "@cDescription, " & TxtDesc.Text
                Param(5) = "@fDollarRate_amt, " & txtDollarRate.Text
                Param(6) = "@iCurrencyID , " & Me.DropCurrency.SelectedValue
                Param(7) = "@bIsFullyPaid , " & IIf(chkInvoiceISCompletePaid.Checked, True, False)
                Param(8) = "@iUserID , " & UserID
                'Param(8) = "@iInvoiceTotalLL , " & Me.txtInvTotalLL.Text
                'Param(9) = "@iInvoiceTotalUSD , " & Me.txtInvTotalUSD.Text
                'Param(10) = "@iInvPaymentTotalLL , " & Me.txtInvPaymentTotalLL.Text
                'Param(11) = "@iInvPaymentTotalUSD , " & Me.txtInvPaymentTotalUSD.Text


                ExecuteProcedureWithParameters("PayInvoice", Param)
                Dim Rptparam(1) As String
                'Rptparam(0) = "NotesID , " & TxtCode.Text
                'If BoolLTRLanguage Then
                '    Rptparam(1) = "AmountWord , " & AmountInWords.AmountInWordsEn(TxtAmount.Text, CurrencyID:=DropCurrency.SelectedValue)
                'Else
                '    Rptparam(1) = "AmountWord , " & AmountInWords.AmountInWordsAr(TxtAmount.Text, CurrencyID:=DropCurrency.SelectedValue)
                'End If
                'If Not BoolForPrint Then
                '    If MessageShowAsk(Con.Ask_Do_You_Want_Print_Voucher) = DialogResult.Yes Then
                '        OpenReport(Con.RptNotesReceive, Rptparam)
                '    End If
                'Else
                '    OpenReport(Con.RptNotesReceive, Rptparam)
                'End If
                FormClear()
                ToDoRefrech = True
                Close()
            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

    End Sub

    Private Sub lblCurrencyRate_Click(sender As Object, e As EventArgs) Handles lblCurrencyRate.Click
        txtDollarRate.Enabled = Not txtDollarRate.Enabled
    End Sub
End Class
