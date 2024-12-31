Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class PurchaseOrderFrm

    Dim VendorID As String
    Dim VendorTitle As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()

        InitiateGrid(Me.GridPurchaseOrders, Grouping:=IIf(BoolShowItemsInPOMainForm, False, True))

        InitiateDatePicker()
        FillDropList()
        ShowPermissions()
        ShowGridSummaryRow()
    End Sub

    Private Sub InitiateDatePicker()
        InitiateDateTimePicker(MskTxtInvDateFrom, DateSerial(2020, 1, 1), True, False)
        InitiateDateTimePicker(MskTxtInvDateTo, DateSerial(2020, 1, 1), True, False)
    End Sub

    Private Sub ShowGridSummaryRow()
        GridViewAddSummaryRow(GridPurchaseOrders, "InvID", "{0}", GridAggregateFunction.Count)
        GridViewAddSummaryRow(GridPurchaseOrders, "SubTotalLL", "{0}", GridAggregateFunction.Sum)
        GridViewAddSummaryRow(GridPurchaseOrders, "TotalDueLL", "{0}", GridAggregateFunction.Sum)
        GridViewAddSummaryRow(GridPurchaseOrders, "DiscountLL", "{0}", GridAggregateFunction.Sum)
        GridViewAddSummaryRow(GridPurchaseOrders, "SubTotalUSD", "{0}", GridAggregateFunction.Sum)
        GridViewAddSummaryRow(GridPurchaseOrders, "TotalDueUSD", "{0}", GridAggregateFunction.Sum)
        GridViewAddSummaryRow(GridPurchaseOrders, "DiscountUSD", "{0}", GridAggregateFunction.Sum)
        GridViewAddSummaryRow(GridPurchaseOrders, "DollarRate", "{0}", GridAggregateFunction.Max)
    End Sub
    Sub ShowPermissions()
        Dim PORow As DataRow = UserRolesdt.Select("KeyName = 'PO'").First
        Me.BtnNew.Enabled = PORow("AllowAdd").ToString
        Me.BtnEdit.Enabled = PORow("AllowEdit").ToString
        Me.BtnDelete.Enabled = PORow("AllowDelete").ToString
        '  Me.BtnNew.Enabled = (UserType = UserRole.Programmer Or ItemsRow("AllowDelete").ToString)
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.lblPurchasesOrders
        Me.LblInvID.Text = LoStrId.LblNum
        Me.LblInvType.Text = LoStrId.LblType
        Me.LblDropCurrency.Text = LoStrId.LblCurrency
        Me.LblFrom.Text = LoStrId.LblFrom
        Me.LblTo.Text = LoStrId.LblTo
        Me.LblVendor.Text = LoStrId.lblVendor
        Me.LblPaymentType.Text = LoStrId.LblPayment
        Me.BtnNew.Text = LoStrId.LblNew
        Me.BtnEdit.Text = LoStrId.LblEdit
        Me.BtnDelete.Text = LoStrId.LblDelete
        Me.BtnRefrech.Text = LoStrId.LblRefrech
        Me.BtnReset.Text = LoStrId.LblReset
        Me.BtnFiltering.Text = LoStrId.LblFiltering
        'Me.RadioCash.Text = LoStrId.LblCash
        'Me.RadioDebt.Text = LoStrId.LblDebt
        Me.RadioPurchase.Text = LoStrId.LblPurchase
        Me.RadioReturns.Text = LoStrId.LblReturn
        Me.BtnPrint.Text = LoStrId.LblPrint
        Me.LblStatus.Text = LoStrId.LblStatus
        Me.BtnPayInvoice.Text = LoStrId.LblPay
        Me.btnAllPayments.Text = LoStrId.LblAllPayments
        ChangeTextButtonToRight(Me.TxtVendor, TxtVendorBtn)

    End Sub

    Public Sub RefrechGrid()

        Dim Param(1) As String
        Param(0) = "@iUserID , " & UserID
        Param(1) = "@iUserType , " & UserType

        FillGridViewProcedureWithParameters(Me.GridPurchaseOrders, "SelectPurchasesOrdersJoinVendor", Param)

        'Always Hidden
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns.Item("InvoiceNumber").Index, False)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("ReferType").Index, False)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("PaymentType").Index, False)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("status").Index, False)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("CurrencySymb").Index, False)
        '#End ---

        Dim checkIsAdmin As Boolean = (UserType = UserRole.Programmer Or UserType = UserRole.Admin)

        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("Username").Index, checkIsAdmin)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("VendorTitle").Index, BoolShowPurchaseOrdersColVendorTitle)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("SubTotalLL").Index, BoolShowPurchaseOrdersColSubTotalLL)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("SubTotalUSD").Index, BoolShowPurchaseOrdersColSubTotalUSD)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("DiscountLL").Index, BoolShowPurchaseOrdersColDiscountLL)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("DiscountUSD").Index, BoolShowPurchaseOrdersColDiscountUSD)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("TotalDueLL").Index, BoolShowPurchaseOrdersColTotalDueLL)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("TotalDueUSD").Index, BoolShowPurchaseOrdersColTotalDueUSD)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("DollarRate").Index, BoolShowPurchaseOrdersColCurrencyRate)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("StatusName").Index, BoolShowPurchaseOrdersColStatus)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("InvoiceCurrencySymb").Index, BoolShowPurchaseOrdersColCurrencySymb)

        If BoolShowItemsInPOMainForm Then
            ShowItemsInGrid()
        End If

        FilterGrid(Me.GridPurchaseOrders, "DueDate", DateSerial(Year(Date.Now), Month(Date.Now), DateAndTime.Day(Date.Now)), FilterOperator.IsEqualTo)
    End Sub
    Private Sub FillDropList()
        Dim Sitem As New RadListDataItem With {
            .Text = Con.Posted,
            .Value = Con.Posted
        }
        Me.DropStatus.Items.Add(Sitem)

        Sitem = New RadListDataItem With {
            .Text = Con.UnPosted,
            .Value = Con.UnPosted
        }
        Me.DropStatus.Items.Add(Sitem)

        LoadPaymentTypesDropDown(DropPaymentType)

        FillDropCurrencyFromCurrencyData(Me.DropCurrency, IIf(BoolLTRLanguage = True, "LatinSymb", "Symb"), True)
        Initiatedropdownlist(Me.DropCurrency)
        Initiatedropdownlist(Me.DropStatus, False)
        Initiatedropdownlist(Me.DropPaymentType, False)
    End Sub



    Sub AutoComplete()
        Me.TxtVendor.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtVendor.AutoCompleteCustomSource = VendorNameAuto
        Me.TxtVendor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Public Sub ShowItemsInGrid()

        Me.GridPurchaseOrders.MasterTemplate.Templates.Clear()
        Dim ChildTemplateItems As New GridViewTemplate With {
            .DataSource = ExecuteProcedureDatatable("SelectPurchasesOrdersDetailsJoinItems")
        }
        InitiateGridChild(ChildTemplateItems)
        HideShowColummnChild(ChildTemplateItems, ChildTemplateItems.Columns("InvID").Index, False)
        HideShowColummnChild(ChildTemplateItems, ChildTemplateItems.Columns("PurchasingPrice").Index, BoolShowPurchasingPriceInScreensByUser)
        Me.GridPurchaseOrders.MasterTemplate.Templates.Add(ChildTemplateItems)

        Dim relation As New GridViewRelation(Me.GridPurchaseOrders.MasterTemplate) With {
            .ChildTemplate = ChildTemplateItems,
            .RelationName = "POheaderPOdetailsItems"
        }
        relation.ParentColumnNames.Add("InvID")
        relation.ChildColumnNames.Add("InvID")
        Me.GridPurchaseOrders.Relations.Add(relation)
    End Sub
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Dim FrmAddNewPurchaseInvoice As New AddNewPurchaseInvoice
        FrmAddNewPurchaseInvoice.ShowDialog()
        If ToDoRefrech Then
            RefrechGrid()
            ToDoRefrech = False
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Me.GridPurchaseOrders.ChildRows.Count > 0 Then
            Dim InvID As String = Me.GridPurchaseOrders.CurrentRow.Cells("InvID").Value
            Dim FrmShowPurchaseOrder As New AddNewPurchaseInvoice With {
                .BoolForEdit = True,
                .InvID = InvID
            }
            FrmShowPurchaseOrder.ShowDialog()
            If ToDoRefrech Then
                RefrechGrid()
                ToDoRefrech = False
            End If
        End If
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechGrid()
        BtnFiltering_Click(New Object, New EventArgs)
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        Me.GridPurchaseOrders.FilterDescriptors.Clear()
        FilterGrid(Me.GridPurchaseOrders, "VendorName", Me.TxtVendor.Text, FilterOperator.Contains)
        If VendorTitle <> String.Empty Then
            FilterGrid(Me.GridPurchaseOrders, "VendorTitle", VendorTitle, FilterOperator.Contains)
        End If
        FilterGrid(Me.GridPurchaseOrders, "InvID", Me.TxtInvID.Text.Trim, FilterOperator.Contains)

        If RadioPurchase.IsChecked Then
            FilterGrid(Me.GridPurchaseOrders, "TypeName", Con.PurchaseOrder, FilterOperator.IsEqualTo)
        End If
        If RadioReturns.IsChecked Then
            FilterGrid(Me.GridPurchaseOrders, "TypeName", Con.ReturnPurchases, FilterOperator.IsEqualTo)
        End If

        If Me.DropCurrency.SelectedIndex <> -1 Then
            FilterGrid(Me.GridPurchaseOrders, "CurrencySymb", Me.DropCurrency.SelectedValue.ToString, FilterOperator.IsEqualTo)
        End If

        If Me.DropStatus.SelectedIndex <> -1 Then
            FilterGrid(Me.GridPurchaseOrders, "StatusName", Me.DropStatus.SelectedValue, FilterOperator.IsEqualTo)
        End If

        If Me.DropPaymentType.SelectedIndex <> -1 Then
            FilterGrid(Me.GridPurchaseOrders, "PaymentType", Me.DropPaymentType.SelectedValue, FilterOperator.IsEqualTo)
        End If

        'If RadioCash.IsChecked Then
        '    FilterGrid(Me.GridPurchaseOrders, "PaymentType", Con.Cash, FilterOperator.IsEqualTo)
        'End If
        'If RadioDebt.IsChecked Then
        '    FilterGrid(Me.GridPurchaseOrders, "PaymentType", Con.Debt, FilterOperator.IsEqualTo)
        'End If

        If MskTxtInvDateFrom.Checked Then
            FilterGrid(Me.GridPurchaseOrders, "DueDate", Me.MskTxtInvDateFrom.Value, FilterOperator.IsGreaterThanOrEqualTo)
        End If
        If MskTxtInvDateTo.Checked Then
            FilterGrid(Me.GridPurchaseOrders, "DueDate", Me.MskTxtInvDateTo.Value, FilterOperator.IsLessThanOrEqualTo)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.GridPurchaseOrders.FilterDescriptors.Clear()
        FilterGrid(Me.GridPurchaseOrders, "DueDate", DateSerial(Year(Date.Now), Month(Date.Now), 1), FilterOperator.IsEqualTo)
        Me.TxtVendor.Clear()
        Me.TxtInvID.Clear()
        Me.DropPaymentType.SelectedIndex = -1
        'Me.RadioCash.CheckState = CheckState.Unchecked
        'Me.RadioDebt.CheckState = CheckState.Unchecked
        Me.RadioPurchase.CheckState = CheckState.Unchecked
        Me.RadioReturns.CheckState = CheckState.Unchecked
        Me.MskTxtInvDateFrom.Checked = False
        Me.MskTxtInvDateTo.Checked = False
        Me.DropCurrency.SelectedIndex = -1
        Me.DropStatus.SelectedIndex = -1
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If Me.GridPurchaseOrders.ChildRows.Count <> 0 And Me.GridPurchaseOrders.Rows.Count <> 0 Then
            Dim param(0) As String
            param(0) = "InvID , " & Me.GridPurchaseOrders.CurrentRow.Cells("InvID").Value
            OpenReport(Con.RptPurchaseOrder, param)
        End If
    End Sub

    'Private Sub GridPurchaseOrders_HyperlinkOpening(sender As Object, e As HyperlinkOpeningEventArgs) Handles GridPurchaseOrders.HyperlinkOpening
    '    Dim InvID As String = e.Row.Cells("HyperInvID").Value
    '    Dim FrmShowPurchaseOrder As New AddNewPurchaseInvoice With {
    '        .BoolForEdit = True,
    '        .InvID = InvID
    '    }
    '    FrmShowPurchaseOrder.ShowDialog()
    'End Sub

    Private Sub TxtVendorBtn_Click(sender As Object, e As EventArgs) Handles TxtVendorBtn.Click
        Dim FrmGetVendors As New VendorsPopup
        FrmGetVendors.ShowDialog()
        Me.TxtVendor.Text = FrmGetVendors.GetVendorName
    End Sub

    Private Sub PurchaseOrderFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoComplete()
        Me.MskTxtInvDateFrom.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now), DateAndTime.Day(Date.Now))
    End Sub

    Private Sub TxtVendor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtVendor.Validating
        If Not VendorNameAuto.Contains(Me.TxtVendor.Text.ToLower) Then
            Me.TxtVendor.Text = String.Empty
            VendorID = String.Empty
            VendorTitle = String.Empty
        Else
            Dim VendorData() As String = Me.TxtVendor.Text.Split("/")
            VendorID = VendorData(2)
            Me.TxtVendor.Text = VendorData(0)
            VendorTitle = VendorData(1)
        End If
    End Sub

    Private Sub RadioPurchase_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadioPurchase.ToggleStateChanged
        BtnFiltering_Click(sender, args)
    End Sub

    Private Sub RadioReturns_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadioReturns.ToggleStateChanged
        BtnFiltering_Click(sender, args)
    End Sub

    Private Sub RadioCash_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
        BtnFiltering_Click(sender, args)
    End Sub

    Private Sub RadioDebt_ToggleStateChanged(sender As Object, args As StateChangedEventArgs)
        BtnFiltering_Click(sender, args)
    End Sub

    Private Sub TxtVendor_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtVendor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BtnFiltering.Select()
            Me.BtnFiltering.PerformClick()
        End If
    End Sub

    Private Sub TxtInvID_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtInvID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BtnFiltering.PerformClick()
        End If
    End Sub

    Private Sub DropCurrency_KeyDown(sender As Object, e As KeyEventArgs) Handles DropCurrency.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BtnFiltering.PerformClick()
        End If
    End Sub

    Private Sub MskTxtInvDateFrom_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.BtnFiltering.PerformClick()
        End If
    End Sub

    Private Sub MskTxtInvDateTo_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.BtnFiltering.PerformClick()
        End If
    End Sub

    Private Sub TxtVendor_ToolTipTextNeeded(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) Handles TxtVendor.ToolTipTextNeeded
        e.ToolTipText = VendorTitle
    End Sub

    Private Sub BtnPayInvoice_Click(sender As Object, e As EventArgs) Handles BtnPayInvoice.Click
        If Me.GridPurchaseOrders.ChildRows.Count <> 0 And Me.GridPurchaseOrders.Rows.Count <> 0 _
            And Me.GridPurchaseOrders.SelectedRows.Count <> 0 Then
            If Me.GridPurchaseOrders.CurrentRow.HierarchyLevel = 0 Then
                If Me.GridPurchaseOrders.CurrentRow.Cells("Status").Value.ToString = Status.Posted Then
                    If Me.GridPurchaseOrders.CurrentRow.Cells("PaymentType").Value.ToString = "D" _
                            Or Me.GridPurchaseOrders.CurrentRow.Cells("PaymentType").Value.ToString = "TA" Then
                        Dim FrmPayInvoice As New PayInvoice
                        FrmPayInvoice.BoolForShowInv = True
                        FrmPayInvoice.InvNum = Me.GridPurchaseOrders.CurrentRow.Cells("InvID").Value
                        FrmPayInvoice.ReferType = Me.GridPurchaseOrders.CurrentRow.Cells("ReferType").Value
                        FrmPayInvoice.ReferTypeName = Me.GridPurchaseOrders.CurrentRow.Cells("TypeName").Value
                        FrmPayInvoice.ShowDialog()
                        If ToDoRefrech Then
                            RefrechGrid()
                            ToDoRefrech = False
                        End If
                    Else
                        MessageShowInfo(Con.Msg_Is_Not_Debt_Invoice)
                    End If
                Else
                    MessageShowInfo(Con.Msg_Invoice_Status_ISUnposted)
                End If
            Else
                If Me.GridPurchaseOrders.CurrentRow.ViewInfo.ParentRow.Cells("Status").Value.ToString = Status.Posted Then
                    If Me.GridPurchaseOrders.CurrentRow.ViewInfo.ParentRow.Cells("PaymentType").Value.ToString = "D" _
                            Or Me.GridPurchaseOrders.CurrentRow.ViewInfo.ParentRow.Cells("PaymentType").Value.ToString = "TA" Then
                        Dim FrmPayInvoice As New PayInvoice
                        FrmPayInvoice.BoolForShowInv = True
                        FrmPayInvoice.InvNum = Me.GridPurchaseOrders.CurrentRow.ViewInfo.ParentRow.Cells("InvID").Value
                        FrmPayInvoice.ReferType = Me.GridPurchaseOrders.CurrentRow.ViewInfo.ParentRow.Cells("ReferType").Value
                        FrmPayInvoice.ReferTypeName = Me.GridPurchaseOrders.CurrentRow.ViewInfo.ParentRow.Cells("TypeName").Value
                        FrmPayInvoice.ShowDialog()
                        If ToDoRefrech Then
                            RefrechGrid()
                            ToDoRefrech = False
                        End If
                    Else
                        MessageShowInfo(Con.Msg_Is_Not_Debt_Invoice)
                    End If
                Else
                    MessageShowInfo(Con.Msg_Invoice_Status_ISUnposted)
                End If
            End If

        End If
    End Sub

    Private Sub LblPaymentType_Click(sender As Object, e As EventArgs) Handles LblPaymentType.Click
        Me.DropPaymentType.SelectedIndex = -1
    End Sub

    Private Sub LblDropCurrency_Click(sender As Object, e As EventArgs) Handles LblDropCurrency.Click
        Me.DropCurrency.SelectedIndex = -1
    End Sub

    Private Sub LblStatus_Click(sender As Object, e As EventArgs) Handles LblStatus.Click
        Me.DropStatus.SelectedIndex = -1
    End Sub

    Private Sub GridPurchaseOrders_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridPurchaseOrders.ViewCellFormatting
        If (e.CellElement.RowInfo.Group Is Nothing And TypeOf e.CellElement Is GridSummaryCellElement) Then
            e.CellElement.ForeColor = Color.Blue
            e.CellElement.RowElement.DrawFill = True
            e.CellElement.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.RowElement.BackColor = Color.FromArgb(239, 246, 255)

            If e.Column.Name = "SubTotalLL" Or e.Column.Name = "DiscountLL" Or e.Column.Name = "TotalDueLL" Or e.Column.Name = "DollarRate" Then
                e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Text, 0, False, False)
            End If
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
            e.CellElement.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        End If
    End Sub

    Private Sub GridPurchaseOrders_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridPurchaseOrders.CellFormatting
        If e.CellElement.ColumnInfo.Name = "PaymentTypeName" Then
            If e.Row.Cells("PaymentType").Value = "D" Then
                e.CellElement.DrawFill = True
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                e.CellElement.BackColor = Color.Red
            ElseIf e.Row.Cells("PaymentType").Value = "TA" Then
                e.CellElement.DrawFill = True
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                e.CellElement.BackColor = Color.Yellow
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            End If
        End If

        If (e.Column.Name = "SubTotalLL" Or e.Column.Name = "DiscountLL" Or e.Column.Name = "TotalDueLL" Or e.Column.Name = "DollarRate") _
            And e.CellElement.Text <> Nothing Then
            e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Text, 0, False, False)
        End If
    End Sub

    Private Sub btnAllPayments_Click(sender As Object, e As EventArgs) Handles btnAllPayments.Click
        If Me.GridPurchaseOrders.ChildRows.Count <> 0 And Me.GridPurchaseOrders.Rows.Count <> 0 _
And Me.GridPurchaseOrders.SelectedRows.Count <> 0 Then
            If Me.GridPurchaseOrders.CurrentRow.HierarchyLevel = 0 Then
                If Me.GridPurchaseOrders.CurrentRow.Cells("Status").Value.ToString = Status.Posted Then
                    If Me.GridPurchaseOrders.CurrentRow.Cells("PaymentType").Value.ToString = "PI" _
                            Or Me.GridPurchaseOrders.CurrentRow.Cells("PaymentType").Value.ToString = "TA" Then
                        Dim InvNum As Integer = Me.GridPurchaseOrders.CurrentRow.Cells("InvID").Value
                        Dim ReferType As String = Me.GridPurchaseOrders.CurrentRow.Cells("ReferType").Value
                        Dim FrmPOAllPayments As New ShowINVPayments(InvNum, ReferType)
                        FrmPOAllPayments.ShowDialog()
                    Else
                        MessageShowInfo(Con.Msg_INV_Do_Not_Have_Payments)
                    End If
                Else
                    MessageShowInfo(Con.Msg_Invoice_Status_ISUnposted)
                End If
            Else
                If Me.GridPurchaseOrders.CurrentRow.ViewInfo.ParentRow.Cells("Status").Value.ToString = Status.Posted Then
                    If Me.GridPurchaseOrders.CurrentRow.ViewInfo.ParentRow.Cells("PaymentType").Value.ToString = "PI" _
                            Or Me.GridPurchaseOrders.CurrentRow.ViewInfo.ParentRow.Cells("PaymentType").Value.ToString = "TA" Then
                        Dim InvNum As Integer = Me.GridPurchaseOrders.CurrentRow.Cells("InvID").Value
                        Dim ReferType As String = Me.GridPurchaseOrders.CurrentRow.Cells("ReferType").Value
                        Dim FrmPOAllPayments As New ShowINVPayments(InvNum, ReferType)
                        FrmPOAllPayments.ShowDialog()
                    Else
                        MessageShowInfo(Con.Msg_INV_Do_Not_Have_Payments)
                    End If
                Else
                    MessageShowInfo(Con.Msg_Invoice_Status_ISUnposted)
                End If
            End If
        End If
    End Sub

End Class
