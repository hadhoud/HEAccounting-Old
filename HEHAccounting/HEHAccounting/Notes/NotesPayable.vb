Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI

Public Class NotesPayable
    Dim VendorID As String
    Dim VendorTitle As String
    Public BoolForEdit As Boolean = False
    Dim BoolForPrint As Boolean = False
    Public NotesPayID As String
    Dim InvoiceReference As String
    Dim EditCurrencyRateID As String
    Dim CheckID As String
    Dim CurrencyinitialState As String = "E"
    Dim CurrencyRound As Integer = 0
    Dim Desc As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        ' Add any initialization after the InitializeComponent() call.
        ' EnableDisable(False)
        FillDropList()
        ShowPermissions()
        Me.txtDollarRateAmt.Text = LastDollarCurrencyRate
    End Sub
    Sub ShowPermissions()
        Dim ItemsRow As DataRow = UserRolesdt.Select("KeyName = 'NP'").First
        If ItemsRow("AllowPosted").ToString <> True Then
            Me.DropStatus.SelectedValue = Status.UnPosted
            Me.DropStatus.Enabled = False
        Else
            Me.DropStatus.SelectedValue = DefaultNPStatus
        End If
    End Sub
    Private Sub FormClear()
        Me.TxtDueDate.Value = Date.Now.Date
        Me.DropCurrency.SelectedValue = 1
        Me.TxtVendor.Clear()
        Me.TxtAmount.Text = "0"
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
        Param(0) = "@VTableName , NotesPayable"
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
        Initiatedropdownlist(Me.DropCurrency, False)
    End Sub
    Private Sub NotesPayable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoComplete()
        If Not BoolForEdit Then
            FormClear()
        Else
            ShowEdit()
        End If
    End Sub
    Public Sub ShowEdit()
        Me.BtnSaveAndNew.Text = Con.Edit
        Me.BtnSaveAndNew.Tag = "Edit"
        Dim Param(0) As String
        Param(0) = "@NotesID  , " & NotesPayID
        Dim DtSalesOrderHeaders As DataTable = ExecuteProcedureDatatableWithParameters("SelectNotesPayByID", Param)
        Me.TxtCode.Text = NotesPayID
        Me.TxtVendor.Text = DtSalesOrderHeaders.Rows(0).Item("VendorName").ToString
        VendorID = DtSalesOrderHeaders.Rows(0).Item("VendorID").ToString
        VendorTitle = DtSalesOrderHeaders.Rows(0).Item("VendorTitle").ToString
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
        Me.TxtVendor.Enabled = False
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
        Me.Text = LoStrId.LblNotePayable
        Me.LblCode.Text = LoStrId.LblCode
        Me.LblDueDate.Text = LoStrId.LblDate
        Me.LblCurrency.Text = LoStrId.LblCurrency
        Me.LblCurrencyVal.Text = LoStrId.LblCurrencyRate
        Me.LblVendor.Text = LoStrId.lblVendor
        Me.LblValue.Text = LoStrId.lblValue
        Me.LblBalance.Text = LoStrId.lblBalance
        Me.LblEqualValue.Text = LoStrId.LblValueRate
        Me.LblPaymentType.Text = LoStrId.LblPayment
        Me.LblCheckNum.Text = LoStrId.LblCheckNumber
        Me.LblCheckDueDate.Text = LoStrId.LblDueDate
        Me.LblBankName.Text = LoStrId.LblBankName
        Me.LblCheckType.Text = LoStrId.LblCheckType
        Me.BtnSaveAndNew.Text = LoStrId.LblSaveNew
        Me.RadioCash.Text = LoStrId.LblCash
        Me.RadioCheck.Text = LoStrId.LblCheck
        Me.BtnPrint.Text = LoStrId.LblPrint
        Me.ChkAlert.Text = LoStrId.LblAlertOnCheckDueDate
        Me.LblDesc.Text = LoStrId.LblDescription
        Me.BtnClose.Text = LoStrId.LblClose
        ChangeTextButtonToRight(Me.TxtVendor, TxtVendorBtn)

    End Sub

    Sub AutoComplete()
        Me.TxtVendor.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtVendor.AutoCompleteCustomSource = VendorNameAuto
        Me.TxtVendor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub TxtVendorBtn_Click(sender As Object, e As EventArgs) Handles TxtVendorBtn.Click
        Dim FrmGetVendors As New VendorsPopup
        FrmGetVendors.ShowDialog()
        Me.TxtVendor.Text = FrmGetVendors.GetVendorName
    End Sub

    Private Sub RadioCheck_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadioCheck.ToggleStateChanged
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
            Me.TxtVendor.Enabled = False
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

    Private Sub RadioCash_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadioCash.ToggleStateChanged
        EnableDisable(False)
    End Sub

    Private Sub TxtVendor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtVendor.Validating
        If Not VendorNameAuto.Contains(Me.TxtVendor.Text.ToLower) Then
            If Not VendorNameAuto.Contains(Me.TxtVendor.Text.ToLower & "/" & VendorTitle & "/" & VendorID) Then
                Me.TxtVendor.Text = String.Empty
                VendorID = String.Empty
                VendorTitle = String.Empty
                Me.TxtAccBalance.Text = 0
                Me.LblBalance.Text = Con.Balance
            Else
                GetBalance()
            End If
        Else
            Dim VendorData() As String = Me.TxtVendor.Text.Split("/")
            VendorID = VendorData(2)
            Me.TxtVendor.Text = VendorData(0)
            VendorTitle = VendorData(1)
            GetBalance()
        End If
    End Sub
    Private Sub GetBalance()
        Dim Param(3) As String
        Param(0) = "@IVenCusID , " & VendorID
        Param(1) = "@CVenOrCus , V"
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

    Private Sub TxtVendor_ToolTipTextNeeded(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) Handles TxtVendor.ToolTipTextNeeded
        e.ToolTipText = VendorTitle
    End Sub

    Private Sub DropCurrency_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles DropCurrency.SelectedIndexChanged
        DropCurerncySelectedChange()
    End Sub
    Private Sub DropCurerncySelectedChange()
        If Me.DropCurrency.SelectedIndex <> -1 Then
            Dim CurrencyRow As DataRow = Currencydata.Select("CurrencyID = " & Me.DropCurrency.SelectedValue).First
            CurrencyinitialState = CurrencyRow("initialstate").ToString
            CurrencyRound = CurrencyRow("CurrFloat").ToString
            If CurrencyRound = -1 Then
                CurrencyRound = 0
                Me.TxtAmount.Mask = "F0"
                'Me.TxtEqualValue.Mask = "F0"
            Else
                Me.TxtAmount.Mask = "F" & CurrencyRound
                'Me.TxtEqualValue.Mask = "F" & CurrencyRound
            End If
            If Me.DropCurrency.SelectedValue.ToString = "1" Then
                Me.TxtCurrencyVal.Text = "1"
                Me.TxtCurrencyVal.Tag = "1"
            Else
                Me.TxtCurrencyVal.Text = CurrencyRow("CurrencyVal").ToString
                Me.TxtCurrencyVal.Tag = CurrencyRow("LastChangeID").ToString
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
            Me.TxtVendor.Text.Trim.Length = 0 Then
            Return False
        End If
        Return True
    End Function
    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If FormCheck() Then
            If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                Dim Param(14) As String
                Param(0) = "@INotesID  , " & Me.TxtCode.Text
                Param(1) = "@IVendorID , " & VendorID
                Param(2) = "@FAmount , " & Me.TxtAmount.Value
                Param(3) = "@FBalance, " & Me.TxtAccBalance.Text
                Param(4) = "@FAmountEuality , " & Me.TxtEqualValue.Text
                Param(5) = "@ICurrencyRateID , " & EditCurrencyRateID
                Param(6) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                Param(7) = "@fDollarRate_amt , " & txtDollarRateAmt.Text
                Param(8) = "@TDueDate , " & Me.TxtDueDate.Value
                Param(9) = "@CPaymentType , " & IIf(Me.RadioCash.IsChecked, "C", "Check")
                Param(10) = "@CDescription , " & Me.TxtDesc.Text
                Param(11) = "@ICheckID , " & IIf(Me.RadioCheck.IsChecked, CheckID, Nothing)
                Param(12) = "@IInvoiceReference , " & InvoiceReference
                Param(13) = "@IStatus , " & Me.DropStatus.SelectedValue
                Param(14) = "@IUserID , " & UserID
                If BtnSaveAndNew.Tag = "Save" Then
                    ExecuteProcedureWithParameters("InsertNotesPayable", Param)
                    If Me.RadioCheck.IsChecked Then
                        Dim ParamCheck(7) As String
                        ParamCheck(0) = "@ICheckID , " & CheckID
                        ParamCheck(1) = "@CCheckNum , " & Evalquote(Me.TxtCheckNum.Text)
                        ParamCheck(2) = "@CBankName , " & Evalquote(Me.TxtBankName.Text)
                        ParamCheck(3) = "@INotesID , " & Me.TxtCode.Text
                        ParamCheck(4) = "@TDueDate , " & Me.TxtCheckDueDate.Value
                        ParamCheck(5) = "@IStatus , " & Me.DropCheckStatus.SelectedValue
                        ParamCheck(6) = "@BAlert , " & Me.ChkAlert.Checked
                        ParamCheck(7) = "@CNoteType , NP"
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
                            OpenReport(Con.RptNotesPay, Rptparam)
                        End If
                    Else
                        OpenReport(Con.RptNotesPay, Rptparam)
                    End If
                    FormClear()
                    ToDoRefrech = True
                ElseIf BtnSaveAndNew.Tag = "Edit" Then
                    ExecuteProcedureWithParameters("UpdateNotesPayable", Param)
                    If Me.RadioCheck.IsChecked Then
                        Dim ParamCheck(7) As String
                        ParamCheck(0) = "@ICheckID , " & CheckID
                        ParamCheck(1) = "@CCheckNum , " & Evalquote(Me.TxtCheckNum.Text)
                        ParamCheck(2) = "@CBankName , " & Evalquote(Me.TxtBankName.Text)
                        ParamCheck(3) = "@INotesID , " & Me.TxtCode.Text
                        ParamCheck(4) = "@TDueDate , " & Me.TxtCheckDueDate.Value
                        ParamCheck(5) = "@IStatus , " & Me.DropCheckStatus.SelectedValue
                        ParamCheck(6) = "@BAlert , " & Me.ChkAlert.Checked
                        ParamCheck(7) = "@CNoteType , NP"
                        ExecuteProcedureWithParameters("UpdateCheck", ParamCheck)
                    End If
                    MessageShowInfo(Con.Msg_NotesPay_Has_Been_Updated)
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


    Private Sub TxtDesc_Click(sender As Object, e As EventArgs) Handles TxtDesc.Click
        'Me.TxtDesc.Text = GetDescription()
    End Sub

    'Private Function GetDescription() As String
    '    Desc = Con.WePaidToMr
    '    Desc &= Me.TxtVendor.Text & " "
    '    Desc &= VendorTitle & " "
    '    Desc &= Con.AmountOF
    '    Desc &= Me.TxtAmount.Value & " "
    '    Desc &= Me.DropCurrency.Text & " "
    '    Desc &= IIf(Me.RadioCash.IsChecked, Con.Cach, Con.ViaCheckNum)
    '    Desc &= IIf(Me.RadioCheck.IsChecked, CheckID, "")
    '    Desc &= IIf(InvoiceReference = String.Empty, "", Con.ForInvNum)
    '    Desc &= InvoiceReference
    '    Return Desc
    'End Function

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
                GetBalance()
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
            OpenReport(Con.RptNotesPay, Rptparam)
        Else
            BoolForPrint = True
            BtnSaveAndNew.PerformClick()
        End If
    End Sub
End Class
