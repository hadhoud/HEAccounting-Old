Imports Telerik.WinControls.UI

Public Class NoteReceive
    Dim CustomerID As String
    Dim CustomerTitle As String
    Public BoolForEdit As Boolean = False
    Dim BoolForPrint As Boolean = False
    Public NotesReceiveID As String
    Dim InvoiceReference As String
    Dim EditCurrencyRateID As String
    Dim CheckID As String
    Dim CurrencyinitialState As String = "E"
    Dim CurrencyRound As Integer = "0"
    Dim Desc As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        EnableDisable(False)
        FillDropList()
        ShowPermissions()
        Me.txtDollarRateAmt.Text = LastDollarCurrencyRate
    End Sub
    Private Sub NoteReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoComplete()
        If Not BoolForEdit Then
            FormClear()
        Else
            ShowEdit()
        End If
    End Sub
    Sub ShowPermissions()
        Dim ItemsRow As DataRow = UserRolesdt.Select("KeyName = 'NR'").First
        If ItemsRow("AllowPosted").ToString <> True Then
            Me.DropStatus.SelectedValue = Status.UnPosted
            Me.DropStatus.Enabled = False
        Else
            Me.DropStatus.SelectedValue = DefaultNRStatus
        End If
    End Sub

    Private Sub FormClear()
        Me.TxtDueDate.Value = Date.Now.Date
        Me.DropCurrency.SelectedValue = 1
        Me.TxtCustomer.Clear()
        Me.TxtAmount.Value = 0
        Me.TxtEqualValue.Text = "0"
        RadioCash.CheckState = CheckState.Checked
        Me.TxtAccBalance.Text = 0
        Me.LblBalance.Text = Con.Balance
        ShowPermissions()
        Me.TxtCheckNum.Text = String.Empty
        Me.TxtCheckDueDate.Value = Date.Now.Date
        Me.TxtBankName.Text = String.Empty
        Me.TxtDesc.Text = String.Empty
        Me.DropCheckStatus.SelectedValue = CheckStatus.NotCollected
        Me.ChkAlert.CheckState = CheckState.Checked
        BoolForPrint = False
        GetID()
    End Sub
    Private Sub GetID()
        Dim Param(0) As String
        Param(0) = "@VTableName , NotesReceive"
        Me.TxtCode.Text = GetScalarProcedure("GetID", Param)
        Dim ParamCheck(0) As String
        ParamCheck(0) = "@VTableName , Cheques"
        CheckID = GetScalarProcedure("GetID", ParamCheck)
    End Sub

    Private Sub FillDropList()
        Dim item As New RadListDataItem With {
            .Text = Con.Collected,
            .Value = CheckStatus.Collected
        }
        Me.DropCheckStatus.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.NotCollected,
            .Value = CheckStatus.NotCollected
        }
        Me.DropCheckStatus.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.Returned,
            .Value = CheckStatus.Returned
        }
        Me.DropCheckStatus.Items.Add(item)

        Dim Sitem As New RadListDataItem With {
            .Text = Con.Posted,
            .Value = Status.Posted
        }
        Me.DropStatus.Items.Add(Sitem)

        Sitem = New RadListDataItem With {
            .Text = Con.UnPosted,
            .Value = Status.UnPosted
        }
        Me.DropStatus.Items.Add(Sitem)

        Initiatedropdownlist(Me.DropCheckStatus, False)
        Initiatedropdownlist(Me.DropStatus, False)

        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrency.DataSource = Currencydata
        Initiatedropdownlist(Me.DropCurrency)
    End Sub

    Public Sub ShowEdit()
        Me.BtnSaveAndNew.Text = Con.Edit
        Me.BtnSaveAndNew.Tag = "Edit"
        Dim Param(0) As String
        Param(0) = "@NotesID  , " & NotesReceiveID
        Dim DtSalesOrderHeaders As DataTable = ExecuteProcedureDatatableWithParameters("SelectNotesReceiveByID", Param)
        Me.TxtCode.Text = NotesReceiveID
        Me.TxtCustomer.Text = DtSalesOrderHeaders.Rows(0).Item("CustomerName").ToString
        CustomerID = DtSalesOrderHeaders.Rows(0).Item("CustomerID").ToString
        CustomerTitle = DtSalesOrderHeaders.Rows(0).Item("CustomerTitle").ToString
        Me.TxtDueDate.Text = DtSalesOrderHeaders.Rows(0).Item("DueDate").ToString
        Me.TxtDesc.Text = DtSalesOrderHeaders.Rows(0).Item("Description").ToString
        Me.RadioCash.CheckState = IIf(DtSalesOrderHeaders.Rows(0).Item("PaymentType").ToString = "C", CheckState.Checked, CheckState.Unchecked)
        Me.RadioCheck.CheckState = IIf(DtSalesOrderHeaders.Rows(0).Item("PaymentType").ToString = "Check", CheckState.Checked, CheckState.Unchecked)
        Me.DropCurrency.SelectedValue = DtSalesOrderHeaders.Rows(0).Item("CurrencyID")
        Me.DropStatus.SelectedValue = DtSalesOrderHeaders.Rows(0).Item("Status")
        Me.TxtCurrencyVal.Text = DtSalesOrderHeaders.Rows(0).Item("CurrencyVal").ToString
        Me.TxtAccBalance.Text = DtSalesOrderHeaders.Rows(0).Item("Balance").ToString
        Me.TxtAmount.Value = DtSalesOrderHeaders.Rows(0).Item("Amount").ToString
        Me.TxtEqualValue.Text = DtSalesOrderHeaders.Rows(0).Item("AmountEuality").ToString
        EditCurrencyRateID = DtSalesOrderHeaders.Rows(0).Item("CurrencyRID").ToString
        Me.TxtCustomer.Enabled = False
        If RadioCheck.IsChecked Then
            CheckID = DtSalesOrderHeaders.Rows(0).Item("CheckID").ToString
            Me.TxtCheckNum.Text = DtSalesOrderHeaders.Rows(0).Item("CheckNum").ToString
            Me.TxtCheckDueDate.Text = DtSalesOrderHeaders.Rows(0).Item("ChDueDate").ToString
            Me.TxtBankName.Text = DtSalesOrderHeaders.Rows(0).Item("BankName").ToString
            Me.DropCheckStatus.SelectedValue = DtSalesOrderHeaders.Rows(0).Item("ChStatus")
            Me.ChkAlert.CheckState = IIf(DtSalesOrderHeaders.Rows(0).Item("Alert") = "1", CheckState.Checked, CheckState.Unchecked)
            RadioCash.Enabled = False
            EnableDisable(True)
        Else
            RadioCheck.Enabled = False
            EnableDisable(False)
        End If
        If DropStatus.SelectedValue = Status.Posted Then
            EnableDisable(False, True)
        Else
            GetBalance()
        End If

    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.LblNoteReceive
        Me.LblCode.Text = LoStrId.LblCode
        Me.LblDueDate.Text = LoStrId.LblDate
        Me.LblCurrency.Text = LoStrId.LblCurrency
        Me.LblCurrencyVal.Text = LoStrId.LblCurrencyRate
        Me.LblCustomer.Text = LoStrId.lblCustomer
        Me.LblBalance.Text = LoStrId.lblBalance
        Me.LblValue.Text = LoStrId.lblValue
        Me.LblEqualValue.Text = LoStrId.LblValueRate
        Me.LblPaymentType.Text = LoStrId.LblPayment
        Me.LblCheckNum.Text = LoStrId.LblCheckNumber
        Me.LblCheckDueDate.Text = LoStrId.LblDueDate
        Me.LblBankName.Text = LoStrId.LblBankName
        Me.LblCheckType.Text = LoStrId.LblCheckType
        Me.BtnSaveAndNew.Text = LoStrId.LblSaveNew
        Me.BtnClose.Text = LoStrId.LblClose
        Me.RadioCash.Text = LoStrId.LblCash
        Me.RadioCheck.Text = LoStrId.LblCheck
        Me.BtnPrint.Text = LoStrId.LblPrint
        Me.ChkAlert.Text = LoStrId.LblAlertOnCheckDueDate
        Me.LblDesc.Text = LoStrId.LblDescription
        ChangeTextButtonToRight(Me.TxtCustomer, Me.TxtCustomerBtn)
    End Sub
    Sub AutoComplete()
        Me.TxtCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtCustomer.AutoCompleteCustomSource = CustomerNameAuto
        Me.TxtCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub TxtCustomerBtn_Click(sender As Object, e As EventArgs) Handles TxtCustomerBtn.Click
        Dim FrmGetCustomer As New CustomerPopup
        FrmGetCustomer.ShowDialog()
        Me.TxtCustomer.Text = FrmGetCustomer.GetCustomerName
    End Sub

    Private Sub RadioCheck_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadioCheck.ToggleStateChanged
        EnableDisable(True)
    End Sub
    Private Sub EnableDisable(ByVal En As Boolean, Optional ByVal All As Boolean = False)
        Me.TxtCheckNum.Enabled = En
        Me.TxtCheckDueDate.Enabled = En
        Me.TxtBankName.Enabled = En
        Me.DropCheckStatus.Enabled = En
        Me.ChkAlert.Enabled = En
        If All Then
            Me.DropStatus.Enabled = False
            Me.TxtDueDate.Enabled = False
            Me.DropCurrency.Enabled = False
            Me.TxtCustomer.Enabled = False
            Me.TxtAmount.Enabled = False
            Me.TxtDesc.Enabled = False
            Me.RadioCash.Enabled = False
            Me.RadioCheck.Enabled = False
            Me.TxtDesc.Enabled = False
            Me.BtnSaveAndNew.Enabled = False
            Me.BtnInvAttach.Enabled = False
            Me.BtnGetCurrencyVal.Enabled = False
        Else
            Me.TxtDesc.Enabled = True
        End If
    End Sub

    Private Sub RadioCash_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadioCash.ToggleStateChanged
        EnableDisable(False)
    End Sub

    Private Sub TxtCustomer_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtCustomer.Validating
        If Not CustomerNameAuto.Contains(Me.TxtCustomer.Text.ToLower) Then
            If Not CustomerNameAuto.Contains(Me.TxtCustomer.Text.ToLower & "/" & CustomerTitle & "/" & CustomerID) Then
                Me.TxtCustomer.Text = String.Empty
                CustomerID = String.Empty
                CustomerTitle = String.Empty
                Me.TxtAccBalance.Text = 0
                Me.LblBalance.Text = Con.Balance
            Else
                GetBalance()
            End If
        Else
            Dim VendorData() As String = Me.TxtCustomer.Text.Split("/")
            CustomerID = VendorData(2)
            Me.TxtCustomer.Text = VendorData(0)
            CustomerTitle = VendorData(1)
            GetBalance()
        End If
    End Sub
    Private Sub GetBalance()
        Dim Param(3) As String
        Param(0) = "@IVenCusID , " & CustomerID
        Param(1) = "@CVenOrCus , C"
        Param(2) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
        Param(3) = "@CurrencyVal , " & Me.TxtCurrencyVal.Text
        Dim Balance As String = GetScalarProcedure("SelectBalanceByAccount", Param)
        Me.TxtAccBalance.Text = Balance
        If Me.TxtAccBalance.Text.Contains("-") Then
            Me.LblBalance.Text = Con.ForHim
            Me.TxtAccBalance.Text = Me.TxtAccBalance.Text.Remove(Me.TxtAccBalance.Text.IndexOf("-"), 1)
        ElseIf Me.TxtAccBalance.Text = "0" Then
            Me.LblBalance.Text = Con.Balance
        Else
            Me.LblBalance.Text = Con.OnHim
        End If

    End Sub
    Private Sub DropCurrency_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles DropCurrency.SelectedIndexChanged
        DropCurerncySelectedChange()
    End Sub

    Private Sub DropCurerncySelectedChange()
        If Me.DropCurrency.SelectedIndex <> -1 Then
            Dim CurrencyRow As DataRow = Currencydata.Select("CurrencyID = " & Me.DropCurrency.SelectedValue).First
            CurrencyinitialState = CurrencyRow("initialstate").ToString
            CurrencyRound = CurrencyRow("CurrFloat").ToString
            If Me.DropCurrency.SelectedValue.ToString = "1" Then
                Me.TxtCurrencyVal.Text = "1"
                Me.TxtCurrencyVal.Tag = "1"
            Else
                Me.TxtCurrencyVal.Text = CurrencyRow("CurrencyVal").ToString
                Me.TxtCurrencyVal.Tag = CurrencyRow("LastChangeID").ToString
            End If
            If CurrencyRound = "-1" Then
                Me.TxtAmount.Mask = "F0"
                Me.TxtEqualValue.Mask = "F0"
            Else
                Me.TxtAmount.Mask = "F" & CurrencyRound
                Me.TxtEqualValue.Mask = "F" & CurrencyRound
            End If
            EditCurrencyRateID = Me.TxtCurrencyVal.Tag
            If CurrencyinitialState = "S" Then
                Me.TxtEqualValue.Text = Math.Round(Me.TxtAmount.Value / Me.TxtCurrencyVal.Text, 3)
            Else
                Me.TxtEqualValue.Text = Math.Round(Me.TxtAmount.Value * Me.TxtCurrencyVal.Text, 3)
            End If
        End If
        GetBalance()
    End Sub

    Private Function FormCheck() As Boolean
        If Me.TxtCode.Text.Length = 0 Or Me.TxtAmount.Value = 0 Or Me.TxtEqualValue.Text = 0 Or
            Me.TxtCustomer.Text.Trim.Length = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If FormCheck() Then
            If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                Dim Param(14) As String
                Param(0) = "@INotesID  , " & Me.TxtCode.Text
                Param(1) = "@ICustomerID , " & CustomerID
                Param(2) = "@FAmount , " & Me.TxtAmount.Value
                Param(3) = "@FBalance, " & Me.TxtAccBalance.Text
                Param(4) = "@FAmountEuality , " & Me.TxtEqualValue.Text
                Param(5) = "@ICurrencyRateID , " & EditCurrencyRateID
                Param(6) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                Param(7) = "@fDollarRate_amt , " & txtDollarRateAmt.Text
                Param(8) = "@TDueDate , " & Me.TxtDueDate.Value
                Param(9) = "@CPaymentType , " & IIf(Me.RadioCash.IsChecked, "C", "Check")
                Param(10) = "@CDescription , " & Evalquote(Me.TxtDesc.Text)
                Param(11) = "@ICheckID , " & IIf(Me.RadioCheck.IsChecked, CheckID, Nothing)
                Param(12) = "@IInvoiceReference , " & InvoiceReference
                Param(13) = "@IStatus , " & Me.DropStatus.SelectedValue
                Param(14) = "@IUserID , " & UserID
                If BtnSaveAndNew.Tag = "Save" Then
                    ExecuteProcedureWithParameters("InsertNotesReceive", Param)
                    If Me.RadioCheck.IsChecked Then
                        Dim ParamCheck(7) As String
                        ParamCheck(0) = "@ICheckID , " & CheckID
                        ParamCheck(1) = "@CCheckNum , " & Evalquote(Me.TxtCheckNum.Text)
                        ParamCheck(2) = "@CBankName , " & Evalquote(Me.TxtBankName.Text)
                        ParamCheck(3) = "@INotesID , " & Me.TxtCode.Text
                        ParamCheck(4) = "@TDueDate , " & Me.TxtCheckDueDate.Value
                        ParamCheck(5) = "@IStatus , " & Me.DropCheckStatus.SelectedValue
                        ParamCheck(6) = "@BAlert , " & Me.ChkAlert.Checked
                        ParamCheck(7) = "@CNoteType , NR"
                        ExecuteProcedureWithParameters("InsertCheck", ParamCheck)
                    End If
                    Dim Rptparam(1) As String
                    Rptparam(0) = "NotesID , " & Me.TxtCode.Text
                    If BoolLTRLanguage Then
                        Rptparam(1) = "AmountWord , " & AmountInWords.AmountInWordsEn(Me.TxtAmount.Text, CurrencyID:=Me.DropCurrency.SelectedValue)
                    Else
                        Rptparam(1) = "AmountWord , " & AmountInWords.AmountInWordsAr(Me.TxtAmount.Text, CurrencyID:=Me.DropCurrency.SelectedValue)
                    End If
                    If Not BoolForPrint Then
                        If MessageShowAsk(Con.Ask_Do_You_Want_Print_Voucher) = DialogResult.Yes Then
                            OpenReport(Con.RptNotesReceive, Rptparam)
                        End If
                    Else
                        OpenReport(Con.RptNotesReceive, Rptparam)
                    End If
                    FormClear()
                    ToDoRefrech = True
                ElseIf BtnSaveAndNew.Tag = "Edit" Then
                    ExecuteProcedureWithParameters("UpdateNotesReceive", Param)
                    If Me.RadioCheck.IsChecked Then
                        Dim ParamCheck(7) As String
                        ParamCheck(0) = "@ICheckID , " & CheckID
                        ParamCheck(1) = "@CCheckNum , " & Evalquote(Me.TxtCheckNum.Text)
                        ParamCheck(2) = "@CBankName , " & Evalquote(Me.TxtBankName.Text)
                        ParamCheck(3) = "@INotesID , " & Me.TxtCode.Text
                        ParamCheck(4) = "@TDueDate , " & Me.TxtCheckDueDate.Value
                        ParamCheck(5) = "@IStatus , " & Me.DropCheckStatus.SelectedValue
                        ParamCheck(6) = "@BAlert , " & Me.ChkAlert.Checked
                        ParamCheck(7) = "@CNoteType , NR"
                        ExecuteProcedureWithParameters("UpdateCheck", ParamCheck)
                    End If
                    MessageShowInfo(Con.Msg_NotesReceive_Has_Been_Updated)
                    If Me.DropStatus.SelectedValue = Status.Posted Then
                        EnableDisable(False, True)
                    End If
                    ToDoRefrech = True
                End If
            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub
    'Private Function GetDescription() As String
    '    Desc = Me.TxtDesc.Text
    '    'Desc = Con.WeReceivedFromMr
    '    'Desc &= Me.TxtCustomer.Text & " "
    '    'Desc &= CustomerTitle & " "
    '    'Desc &= Con.AmountOF
    '    'Desc &= Me.TxtAmount.Value & " "
    '    'Desc &= Me.DropCurrency.Text & " "
    '    'Desc &= IIf(Me.RadioCash.IsChecked, Con.Cach, Con.ViaCheckNum)
    '    'Desc &= IIf(Me.RadioCheck.IsChecked, CheckID, "")
    '    'Desc &= IIf(InvoiceReference = String.Empty, "", Con.ForInvNum)
    '    'Desc &= InvoiceReference
    '    Return Desc
    'End Function

    Private Sub TxtCustomer_ToolTipTextNeeded(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) Handles TxtCustomer.ToolTipTextNeeded
        e.ToolTipText = CustomerTitle
    End Sub

    'Private Sub TxtDesc_Click(sender As Object, e As EventArgs) Handles TxtDesc.Click
    '    Me.TxtDesc.Text = GetDescription()
    'End Sub

    Private Sub TxtAmount_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtAmount.Validating
        If Me.TxtCurrencyVal.Text <> String.Empty And Me.TxtAmount.Value <> String.Empty Then
            If CurrencyinitialState = "S" Then
                Me.TxtEqualValue.Text = Math.Round(Me.TxtAmount.Value / Me.TxtCurrencyVal.Text, 3)
            Else
                Me.TxtEqualValue.Text = Math.Round(Me.TxtAmount.Value * Me.TxtCurrencyVal.Text, 3)
            End If
        End If
        'Me.TxtDesc.Text = GetDescription()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnGetCurrencyVal_Click(sender As Object, e As EventArgs) Handles BtnGetCurrencyVal.Click
        If (Control.ModifierKeys = Keys.Control) And Me.DropCurrency.SelectedValue <> "1" Then
            Dim FrmAddCurrVal As New CurrencyRate
            FrmAddCurrVal.GetCurrencyRate = True
            FrmAddCurrVal.ShowDialog()
            If FrmAddCurrVal.GetCurrencyVal.Length <> 0 And FrmAddCurrVal.GetCurrencyRateID.Length <> 0 Then
                Me.TxtCurrencyVal.Text = FrmAddCurrVal.GetCurrencyVal
                EditCurrencyRateID = FrmAddCurrVal.GetCurrencyRateID
            End If
        Else
            DropCurerncySelectedChange()
        End If
    End Sub


    Private Sub TxtCurrencyVal_TextChanged(sender As Object, e As EventArgs) Handles TxtCurrencyVal.TextChanged
        If Me.TxtCurrencyVal.Text <> String.Empty And Me.TxtAmount.Value <> String.Empty Then
            If CurrencyinitialState = "S" Then
                Me.TxtEqualValue.Text = Math.Round(Me.TxtAmount.Value / Me.TxtCurrencyVal.Text, 3)
            Else
                Me.TxtEqualValue.Text = Math.Round(Me.TxtAmount.Value * Me.TxtCurrencyVal.Text, 3)
            End If
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If Me.BtnSaveAndNew.Tag = "Edit" Then
            Dim Rptparam(1) As String
            Rptparam(0) = "NotesID , " & Me.TxtCode.Text
            If BoolLTRLanguage Then
                Rptparam(1) = "AmountWord , " & AmountInWords.AmountInWordsEn(Me.TxtAmount.Text, CurrencyID:=Me.DropCurrency.SelectedValue)
            Else
                Rptparam(1) = "AmountWord , " & AmountInWords.AmountInWordsAr(Me.TxtAmount.Text, CurrencyID:=Me.DropCurrency.SelectedValue)
            End If
            OpenReport(Con.RptNotesReceive, Rptparam)
        Else
            BoolForPrint = True
            BtnSaveAndNew.PerformClick()
        End If
    End Sub
End Class
