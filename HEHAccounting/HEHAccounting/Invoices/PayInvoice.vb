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
        FormClear()
        If Not BoolForShowInv Then
            EnableDisable(True)
        Else
            EnableDisable(False)
            ShowInvoice()
        End If
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        '  Me.Text = LoStrId.lblPurchaseOrder
        Me.LblInvID.Text = LoStrId.LblInvID
        Me.LblInvDate.Text = LoStrId.LblDate
        Me.LblDueTotal.Text = LoStrId.LblDueTotal
        Me.BtnPay.Text = LoStrId.LblSaveNew
        Me.BtnPrint.Text = LoStrId.LblPrint
    End Sub

    Public Sub ShowInvoice()
        Dim Param(1) As String
        Param(0) = "@IInvID  , " & InvNum
        Param(1) = "@CReferType  , " & ReferType
        Dim DtInv As DataTable = ExecuteProcedureDatatableWithParameters("SelectInvoiceToPay", Param)

        Me.TxtInvID.Text = InvNum
        Me.TxtTotalDue.Text = DtInv.Rows(0).Item("TotalDue").ToString
        Me.MskTxtInvDate.Text = DtInv.Rows(0).Item("DueDate").ToString
        Me.TxtInvType.Text = ReferTypeName
    End Sub

    Private Sub FormClear()
        Me.MskTxtInvDate.Value = Date.Now.Date
        Me.TxtInvID.Text = String.Empty
        Me.TxtTotalDue.Text = "0"
        Me.TxtInvType.Text = String.Empty
        Me.MskTxtPayDate.Value = Date.Now.Date
    End Sub
    Private Sub EnableDisable(ByVal En As Boolean)
        Me.TxtTotalDue.Enabled = En
        Me.TxtInvID.Enabled = En
        Me.MskTxtInvDate.Enabled = En
        Me.TxtInvType.Enabled = En
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        If MessageShowAsk(Con.Ask_Pay) = DialogResult.Yes Then
            Dim Param(3) As String
            Param(0) = "@IReferID  , " & Me.TxtInvID.Text
            Param(1) = "@CReferType , " & ReferType
            Param(2) = "@TDueDate , " & Me.MskTxtPayDate.Value
            Param(3) = "@FTotalDue, " & Me.TxtTotalDue.Text
            ExecuteProcedureWithParameters("PayInvoice", Param)
            Dim Rptparam(1) As String
            'Rptparam(0) = "NotesID , " & Me.TxtCode.Text
            'If BoolLTRLanguage Then
            '    Rptparam(1) = "AmountWord , " & AmountInWords.AmountInWordsEn(Me.TxtAmount.Text, CurrencyID:=Me.DropCurrency.SelectedValue)
            'Else
            '    Rptparam(1) = "AmountWord , " & AmountInWords.AmountInWordsAr(Me.TxtAmount.Text, CurrencyID:=Me.DropCurrency.SelectedValue)
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
            Me.Close()
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

    End Sub
End Class
