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
        FillDropList()
        ShowPermissions()
    End Sub
    Sub ShowPermissions()
        Dim ItemsRow As DataRow = UserRolesdt.Select("KeyName = 'PO'").First
        Me.BtnNew.Enabled = (UserType = UserRole.Programmer Or ItemsRow("AllowAdd").ToString)
        Me.BtnEdit.Enabled = (UserType = UserRole.Programmer Or ItemsRow("AllowEdit").ToString)
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

        ChangeTextButtonToRight(Me.TxtVendor, TxtVendorBtn)

    End Sub

    Public Sub RefrechGrid()
        FillGridViewProcedure(Me.GridPurchaseOrders, "SelectPurchasesOrdersJoinVendor")
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns.Item("InvoiceNumber").Index, False)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("ReferType").Index, False)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("PaymentType").Index, False)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("status").Index, False)

        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("VendorTitle").Index, BoolShowPurchasesOrdersColVendorTitle)
        HideShowColummn(Me.GridPurchaseOrders, Me.GridPurchaseOrders.Columns("CurrencySymb").Index, BoolShowPurchasesOrdersColCurrencySymb)

        If BoolShowItemsInPOMainForm Then
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

        Me.DropCurrency.ValueMember = IIf(BoolLTRLanguage = True, "LatinSymb", "Symb")
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinSymb", "Symb")
        Me.DropCurrency.DataSource = Currencydata
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

        If CheckDateFrom.Checked Then
            FilterGrid(Me.GridPurchaseOrders, "DueDate", Me.MskTxtInvDateFrom.Value, FilterOperator.IsGreaterThanOrEqualTo)
        End If
        If CheckDateTo.Checked Then
            FilterGrid(Me.GridPurchaseOrders, "DueDate", Me.MskTxtInvDateTo.Value, FilterOperator.IsLessThanOrEqualTo)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.GridPurchaseOrders.FilterDescriptors.Clear()
        Me.TxtVendor.Clear()
        Me.TxtInvID.Clear()
        Me.DropPaymentType.SelectedIndex = -1
        'Me.RadioCash.CheckState = CheckState.Unchecked
        'Me.RadioDebt.CheckState = CheckState.Unchecked
        Me.RadioPurchase.CheckState = CheckState.Unchecked
        Me.RadioReturns.CheckState = CheckState.Unchecked
        Me.CheckDateFrom.Checked = False
        Me.CheckDateTo.Checked = False
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
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0)
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

    Private Sub CheckDateFrom_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CheckDateFrom.ToggleStateChanged
        Me.MskTxtInvDateFrom.Enabled = CheckDateFrom.Checked
    End Sub

    Private Sub CheckDateTo_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CheckDateTo.ToggleStateChanged
        Me.MskTxtInvDateTo.Enabled = CheckDateTo.Checked
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

    Private Sub TxtVendor_ToolTipTextNeeded(sender As Object, e As Telerik.WinControls.ToolTipTextNeededEventArgs) Handles TxtVendor.ToolTipTextNeeded
        e.ToolTipText = VendorTitle
    End Sub

    Private Sub BtnPayInvoice_Click(sender As Object, e As EventArgs) Handles BtnPayInvoice.Click
        If Me.GridPurchaseOrders.ChildRows.Count <> 0 And Me.GridPurchaseOrders.Rows.Count <> 0 _
            And Me.GridPurchaseOrders.SelectedRows.Count <> 0 Then
            If Me.GridPurchaseOrders.CurrentRow.HierarchyLevel = 0 Then
                If Me.GridPurchaseOrders.CurrentRow.Cells("Status").Value.ToString = Status.Posted Then
                    If Me.GridPurchaseOrders.CurrentRow.Cells("PaymentType").Value.ToString = "D" Then
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
                    If Me.GridPurchaseOrders.CurrentRow.ViewInfo.ParentRow.Cells("PaymentType").Value.ToString = "D" Then
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
End Class
