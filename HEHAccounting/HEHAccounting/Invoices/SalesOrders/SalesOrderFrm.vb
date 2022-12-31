Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class SalesOrderFrm
    Dim CustomerID As String
    Dim CustomerTitle As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        '  AddLinkColumn()
        Me.GridSalesOrders.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridSalesOrders.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom
        InitiateGrid(Me.GridSalesOrders, Grouping:=IIf(BoolShowItemsInSOMainForm, False, True))
        FillDropList()
        ShowPermissions()
    End Sub

    Sub ShowPermissions()
        Dim SORow As DataRow = UserRolesdt.Select("KeyName = 'SO'").First
        Me.BtnNew.Enabled = SORow("AllowAdd").ToString
        Me.BtnEdit.Enabled = SORow("AllowEdit").ToString
        Me.BtnDelete.Enabled = SORow("AllowDelete").ToString
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.LblSalesOrders
        Me.LblInvID.Text = LoStrId.LblNum
        Me.LblDropCurrency.Text = LoStrId.LblCurrency
        Me.LblInvType.Text = LoStrId.LblType
        Me.LblFrom.Text = LoStrId.LblFrom
        Me.LblTo.Text = LoStrId.LblTo
        Me.LblCustomer.Text = LoStrId.lblCustomer
        Me.LblPaymentType.Text = LoStrId.LblPayment
        Me.BtnNew.Text = LoStrId.LblNew
        Me.BtnEdit.Text = LoStrId.LblEdit
        Me.BtnDelete.Text = LoStrId.LblDelete
        Me.BtnRefrech.Text = LoStrId.LblRefrech
        Me.BtnReset.Text = LoStrId.LblReset
        Me.BtnFiltering.Text = LoStrId.LblFiltering
        'Me.RadioCash.Text = LoStrId.LblCash
        'Me.RadioDebt.Text = LoStrId.LblDebt
        Me.RadioSales.Text = LoStrId.LblSales
        Me.RadioReturns.Text = LoStrId.LblReturn
        Me.BtnPrint.Text = LoStrId.LblPrint
        Me.LblStatus.Text = LoStrId.LblStatus
        ChangeTextButtonToRight(Me.TxtCustomer, TxtCustomerBtn)

    End Sub

    Public Sub RefrechGrid()

        FillGridViewProcedure(Me.GridSalesOrders, "SelectSalesOrdersJoinCustomers")
        HideShowColummn(Me.GridSalesOrders, Me.GridSalesOrders.Columns("ReferType").Index, False)
        HideShowColummn(Me.GridSalesOrders, Me.GridSalesOrders.Columns("PaymentType").Index, False)
        HideShowColummn(Me.GridSalesOrders, Me.GridSalesOrders.Columns("status").Index, False)

        HideShowColummn(Me.GridSalesOrders, Me.GridSalesOrders.Columns("CurrencyVal").Index, False)

        HideShowColummn(Me.GridSalesOrders, Me.GridSalesOrders.Columns("CustomerTitle").Index, BoolShowSalesOrdersColCustomerTitle)

        HideShowColummn(Me.GridSalesOrders, Me.GridSalesOrders.Columns("CurrencySymb").Index, False)
        HideShowColummn(Me.GridSalesOrders, Me.GridSalesOrders.Columns("InvoiceCurrencySymb").Index, BoolShowSalesOrdersColCurrencySymb)
        If BoolShowItemsInSOMainForm Then
            ShowItemsInGrid()
        End If
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


        Dim PaymentTypeItem As New RadListDataItem With {
            .Text = Con.Cash,
            .Value = PaymentType.Cash
        }
        Me.DropPaymentType.Items.Add(PaymentTypeItem)

        PaymentTypeItem = New RadListDataItem With {
            .Text = Con.Debt,
            .Value = PaymentType.Debt
        }
        Me.DropPaymentType.Items.Add(PaymentTypeItem)

        PaymentTypeItem = New RadListDataItem With {
            .Text = Con.Paid,
            .Value = PaymentType.Paid
        }
        Me.DropPaymentType.Items.Add(PaymentTypeItem)

        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinSymb", "Symb")
        Me.DropCurrency.DataSource = Currencydata

        Initiatedropdownlist(Me.DropCurrency)
        Initiatedropdownlist(Me.DropStatus, False)
        Initiatedropdownlist(Me.DropPaymentType, False)
    End Sub

    Private Sub AddLinkColumn()
        'Dim column As New GridViewHyperlinkColumn With {
        '    .HyperlinkOpenAction = HyperlinkOpenAction.SingleClick,
        '    .FieldName = "InvID",
        '    .Name = "HyperInvID"
        '}
        'Me.GridSalesOrders.Columns.Insert(0, column)
    End Sub
    Public Sub ShowItemsInGrid()

        Me.GridSalesOrders.MasterTemplate.Templates.Clear()
        Dim ChildTemplateItems As New GridViewTemplate With {
            .DataSource = ExecuteProcedureDatatable("SelectSalesOrdersDetailsJoinItems")
        }
        InitiateGridChild(ChildTemplateItems)
        HideShowColummnChild(ChildTemplateItems, ChildTemplateItems.Columns("InvID").Index, False)
        HideShowColummnChild(ChildTemplateItems, ChildTemplateItems.Columns("PurchasingPrice").Index, BoolShowPurchasingPriceInScreensByUser)
        Me.GridSalesOrders.MasterTemplate.Templates.Add(ChildTemplateItems)

        Dim relation As New GridViewRelation(Me.GridSalesOrders.MasterTemplate) With {
            .ChildTemplate = ChildTemplateItems,
            .RelationName = "SoheaderSodetailsItems"
        }
        relation.ParentColumnNames.Add("InvID")
        relation.ChildColumnNames.Add("InvID")
        Me.GridSalesOrders.Relations.Add(relation)
    End Sub
    Private Sub TxtCustomerBtn_Click(sender As Object, e As EventArgs) Handles TxtCustomerBtn.Click
        Dim FrmGetCustomer As New CustomerPopup
        FrmGetCustomer.ShowDialog()

        If Not FrmGetCustomer.GetCustomerName.Length = 0 Then
            CustomerNameAuto.Add(FrmGetCustomer.GetCustomerName)
            Me.TxtCustomer.Text = FrmGetCustomer.GetCustomerName
        End If

    End Sub

    Sub AutoComplete()
        Me.TxtCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtCustomer.AutoCompleteCustomSource = CustomerNameAuto
        Me.TxtCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub TxtCustomer_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtCustomer.Validating
        If Not CustomerNameAuto.Contains(Me.TxtCustomer.Text.ToLower) Then
            Me.TxtCustomer.Text = String.Empty
            CustomerID = String.Empty
            CustomerTitle = String.Empty
        Else
            Dim CustomerData() As String = Me.TxtCustomer.Text.Split("/")
            CustomerID = CustomerData(2)
            Me.TxtCustomer.Text = CustomerData(0)
            CustomerTitle = CustomerData(1)
        End If
    End Sub

    Private Sub SalesOrderFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoComplete()
        '   LoadFirst()
        Me.MskTxtInvDateFrom.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0)
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        Me.GridSalesOrders.FilterDescriptors.Clear()

        FilterGrid(Me.GridSalesOrders, "CustomerName", Me.TxtCustomer.Text, FilterOperator.Contains)

        If CustomerTitle <> String.Empty Then
            FilterGrid(Me.GridSalesOrders, "CustomerTitle", CustomerTitle, FilterOperator.Contains)
        End If

        FilterGrid(Me.GridSalesOrders, "InvID", Me.TxtInvID.Text.Trim, FilterOperator.Contains)

        If RadioSales.IsChecked Then
            FilterGrid(Me.GridSalesOrders, "TypeName", Con.SalesOrder, FilterOperator.IsEqualTo)
        End If
        If RadioReturns.IsChecked Then
            FilterGrid(Me.GridSalesOrders, "TypeName", Con.ReturnSales, FilterOperator.IsEqualTo)
        End If

        If Me.DropCurrency.SelectedIndex <> -1 Then
            FilterGrid(Me.GridSalesOrders, "CurrencySymb", Me.DropCurrency.Text.ToString, FilterOperator.IsEqualTo)
        End If

        If Me.DropStatus.SelectedIndex <> -1 Then
            FilterGrid(Me.GridSalesOrders, "StatusName", Me.DropStatus.SelectedValue, FilterOperator.IsEqualTo)
        End If

        If Me.DropPaymentType.SelectedIndex <> -1 Then
            FilterGrid(Me.GridSalesOrders, "PaymentType", Me.DropPaymentType.SelectedValue, FilterOperator.IsEqualTo)
        End If

        'If RadioDebt.IsChecked Then
        '    FilterGrid(Me.GridSalesOrders, "PaymentTypeName", Con.Debt, FilterOperator.IsEqualTo)
        'End If

        If CheckDateFrom.Checked Then
            FilterGrid(Me.GridSalesOrders, "DueDate", Me.MskTxtInvDateFrom.Value, FilterOperator.IsGreaterThanOrEqualTo)
        End If
        If CheckDateTo.Checked Then
            FilterGrid(Me.GridSalesOrders, "DueDate", Me.MskTxtInvDateTo.Value, FilterOperator.IsLessThanOrEqualTo)
        End If
    End Sub

    Private Sub CheckDateFrom_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CheckDateFrom.ToggleStateChanged
        Me.MskTxtInvDateFrom.Enabled = CheckDateFrom.Checked
    End Sub

    Private Sub CheckDateTo_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CheckDateTo.ToggleStateChanged
        Me.MskTxtInvDateTo.Enabled = CheckDateTo.Checked
    End Sub

    Private Sub RadioSales_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadioSales.ToggleStateChanged
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

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.GridSalesOrders.FilterDescriptors.Clear()
        Me.TxtCustomer.Clear()
        Me.TxtInvID.Clear()
        Me.DropPaymentType.SelectedIndex = -1
        'Me.RadioCash.CheckState = CheckState.Unchecked
        'Me.RadioDebt.CheckState = CheckState.Unchecked
        Me.RadioSales.CheckState = CheckState.Unchecked
        Me.RadioReturns.CheckState = CheckState.Unchecked
        Me.CheckDateFrom.Checked = False
        Me.CheckDateTo.Checked = False
        Me.DropCurrency.SelectedIndex = -1
        Me.DropStatus.SelectedIndex = -1
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechGrid()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Dim FrmAddNewSaleInvoice As New AddNewSaleInvoice
        FrmAddNewSaleInvoice.ShowDialog()
        If ToDoRefrech Then
            RefrechGrid()
            ToDoRefrech = False
        End If
    End Sub

    'Private Sub GridSalesOrders_HyperlinkOpening(sender As Object, e As HyperlinkOpeningEventArgs) Handles GridSalesOrders.HyperlinkOpening
    '    Dim InvID As String = e.Row.Cells("HyperInvID").Value
    '    Dim FrmEditSaleOrder As New AddNewSaleInvoice With {
    '        .BoolForEdit = True,
    '        .InvID = InvID
    '    }
    '    FrmEditSaleOrder.ShowDialog()
    'End Sub



    Private Sub DropCurrency_KeyDown(sender As Object, e As KeyEventArgs) Handles DropCurrency.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BtnFiltering.PerformClick()
        End If
    End Sub

    Private Sub TxtInvID_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtInvID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BtnFiltering.PerformClick()
        End If
    End Sub

    Private Sub TxtCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BtnFiltering.Select()
            Me.BtnFiltering.PerformClick()
        End If
    End Sub

    Private Sub MskTxtInvDateFrom_KeyDown(sender As Object, e As KeyEventArgs) Handles MskTxtInvDateFrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BtnFiltering.PerformClick()
        End If
    End Sub

    Private Sub MskTxtInvDateTo_KeyDown(sender As Object, e As KeyEventArgs) Handles MskTxtInvDateTo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.BtnFiltering.PerformClick()
        End If
    End Sub

    Private Sub TxtCustomer_ToolTipTextNeeded(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) Handles TxtCustomer.ToolTipTextNeeded
        e.ToolTipText = CustomerTitle
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Me.GridSalesOrders.ChildRows.Count > 0 Then
            Dim InvID As String = Me.GridSalesOrders.CurrentRow.Cells("InvID").Value
            Dim FrmShowSalesOrder As New AddNewSaleInvoice With {
                .BoolForEdit = True,
                .InvID = InvID
            }
            FrmShowSalesOrder.ShowDialog()
            If ToDoRefrech Then
                RefrechGrid()
                ToDoRefrech = False
            End If
        End If
    End Sub

    Private Sub BtnPayInvoice_Click(sender As Object, e As EventArgs) Handles BtnPayInvoice.Click
        If Me.GridSalesOrders.ChildRows.Count <> 0 And Me.GridSalesOrders.Rows.Count <> 0 _
            And Me.GridSalesOrders.SelectedRows.Count <> 0 Then
            If Me.GridSalesOrders.CurrentRow.HierarchyLevel = 0 Then
                If Me.GridSalesOrders.CurrentRow.Cells("Status").Value.ToString = Status.Posted Then
                    If Me.GridSalesOrders.CurrentRow.Cells("PaymentType").Value.ToString = "D" Then
                        Dim FrmPayInvoice As New PayInvoice
                        FrmPayInvoice.BoolForShowInv = True
                        FrmPayInvoice.InvNum = Me.GridSalesOrders.CurrentRow.Cells("InvID").Value
                        FrmPayInvoice.ReferType = Me.GridSalesOrders.CurrentRow.Cells("ReferType").Value
                        FrmPayInvoice.ReferTypeName = Me.GridSalesOrders.CurrentRow.Cells("TypeName").Value
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
                If Me.GridSalesOrders.CurrentRow.ViewInfo.ParentRow.Cells("Status").Value.ToString = Status.Posted Then
                    If Me.GridSalesOrders.CurrentRow.ViewInfo.ParentRow.Cells("PaymentType").Value.ToString = "D" Then
                        Dim FrmPayInvoice As New PayInvoice
                        FrmPayInvoice.BoolForShowInv = True
                        FrmPayInvoice.InvNum = Me.GridSalesOrders.CurrentRow.ViewInfo.ParentRow.Cells("InvID").Value
                        FrmPayInvoice.ReferType = Me.GridSalesOrders.CurrentRow.ViewInfo.ParentRow.Cells("ReferType").Value
                        FrmPayInvoice.ReferTypeName = Me.GridSalesOrders.CurrentRow.ViewInfo.ParentRow.Cells("TypeName").Value
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

    Private Sub BtnPrintInvoice_Click(sender As Object, e As EventArgs) Handles BtnPrintInvoice.Click
        If Me.GridSalesOrders.ChildRows.Count <> 0 And Me.GridSalesOrders.Rows.Count <> 0 Then
            Dim param(0) As String
            param(0) = "InvID , " & Me.GridSalesOrders.CurrentRow.Cells("InvID").Value
            OpenReport(Con.RptSalesOrder, param)
        End If
    End Sub

    Private Sub BtnInvoicesReport_Click(sender As Object, e As EventArgs) Handles BtnInvoicesReport.Click
        If Me.TxtCustomer.Text.Trim.Length <> 0 Then
            BtnFiltering.PerformClick()
            If Me.GridSalesOrders.ChildRows.Count <> 0 And Me.GridSalesOrders.Rows.Count <> 0 Then
                Dim param(6) As String
                param(0) = "ICustomerID , " & CustomerID
                If Me.DropCurrency.SelectedIndex <> -1 Then
                    param(1) = "ICurrencyID , " & Me.DropCurrency.SelectedValue
                Else
                    param(1) = "ICurrencyID , 0"
                End If
                If Me.CheckDateFrom.Checked Then
                    param(2) = "TDateFrom , " & Me.MskTxtInvDateFrom.Value
                Else
                    param(2) = "TDateFrom , 1991-01-01"
                End If
                If Me.CheckDateTo.Checked Then
                    param(3) = "TDateTO , " & Me.MskTxtInvDateTo.Value
                Else
                    param(3) = "TDateTO , 1992-02-02"

                End If
                If Me.DropPaymentType.SelectedIndex <> -1 Then
                    param(4) = "CPaymentType , " & Me.DropPaymentType.SelectedValue
                Else
                    param(4) = "CPaymentType , Nothing"
                End If
                If Me.RadioSales.IsChecked Then
                    param(5) = "CType , " & Me.RadioSales.Tag
                ElseIf Me.RadioReturns.IsChecked Then
                    param(5) = "CType , " & Me.RadioReturns.Tag
                Else
                    param(5) = "CType ,Nothing "
                End If

                If Me.TxtInvID.Text.Trim.Length <> 0 Then
                    param(6) = "IInvID , " & Me.TxtInvID.Text
                Else
                    param(6) = "IInvID , 0"
                End If

                OpenReport(Con.RptSOCustomers, param)
            End If
        Else
            MessageShowInfo(Con.Msg_Choose_a_Customer)
        End If
    End Sub

    Private Sub LblInvType_Click(sender As Object, e As EventArgs) Handles LblInvType.Click
        Me.RadioReturns.CheckState = CheckState.Unchecked
        Me.RadioSales.CheckState = CheckState.Unchecked
    End Sub

    Private Sub LblCustomer_Click(sender As Object, e As EventArgs) Handles LblCustomer.Click
        Me.TxtCustomer.Text = String.Empty
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.GridSalesOrders.ChildRows.Count > 0 Then
            Dim poppassword As New PasswordPopup()
            Dim InvID As String = Me.GridSalesOrders.CurrentRow.Cells("InvID").Value
            If MessageShowAsk(Con.Ask_Delete) = DialogResult.Yes Then
                If poppassword.ShowDialog = DialogResult.Yes Then
                    If MessageShowAsk(Con.Ask_Delete_Confirm) = DialogResult.Yes Then
                        Dim Param(1) As String
                        Param(0) = "@IInvID , " & InvID
                        Param(1) = "@IUserID , " & UserID
                        ExecuteProcedureWithParameters("DeleteSalesOrdersHeader", Param)
                        RefrechGrid()
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub GridSalesOrders_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridSalesOrders.ViewCellFormatting
        If (e.CellElement.RowInfo.Group Is Nothing And TypeOf e.CellElement Is GridSummaryCellElement) Then
            e.CellElement.ForeColor = Color.Blue
            e.CellElement.RowElement.DrawFill = True
            e.CellElement.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.RowElement.BackColor = Color.FromArgb(239, 246, 255)
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
            e.CellElement.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        End If
    End Sub

End Class
