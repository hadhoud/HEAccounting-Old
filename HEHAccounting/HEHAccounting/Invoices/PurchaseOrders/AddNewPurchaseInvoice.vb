Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class AddNewPurchaseInvoice
    Public BoolForEdit As Boolean = False
    Public CannotEdit As Boolean = False
    Public InvID As String
    Dim EnterPressed As String
    Dim BoolForPrint As Boolean = False
    Dim VendorID As String
    Dim VendorTitle As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        ShowPermissions()
        FillGrid()

    End Sub

    Sub ShowPermissions()
        Me.LblBarcode.Visible = BoolShowBarcode
        Me.TxtItemBarcode.Visible = BoolShowBarcode
        Dim ItemsRow As DataRow = UserRolesdt.Select("KeyName = 'PO'").First
        If ItemsRow("AllowPosted").ToString <> True Then
            Me.DropStatus.SelectedValue = Status.UnPosted
            Me.DropStatus.Enabled = False
        Else
            Me.DropStatus.SelectedValue = DefaultPOStatus
        End If
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.lblPurchaseOrder
        Me.LblInvID.Text = LoStrId.LblInvID
        Me.LblInvType.Text = LoStrId.LblInvType
        Me.LblInvDate.Text = LoStrId.LblDate
        Me.LblDiscount.Text = LoStrId.LblDiscount
        Me.LblDueTotal.Text = LoStrId.LblDueTotal
        Me.LblInvVendor.Text = LoStrId.lblVendor
        Me.LblInvSubTotal.Text = LoStrId.LblSubTotal
        Me.LblPaymentType.Text = LoStrId.LblPayment
        Me.LblStatus.Text = LoStrId.LblStatus
        Me.LblItemID.Text = LoStrId.LblItemID
        Me.LblItemName.Text = LoStrId.LblItemName
        Me.LblBarcode.Text = LoStrId.LblBarcode
        Me.BtnAdd.Text = LoStrId.LblAdd
        Me.BtnSaveAndNew.Text = LoStrId.LblSaveNew
        Me.RadioCash.Text = LoStrId.LblCash
        Me.RadioDebt.Text = LoStrId.LblDebt
        Me.RadioPurchases.Text = LoStrId.LblPurchase
        Me.RadioReturns.Text = LoStrId.LblReturn
        Me.LblCurrValue.Text = LoStrId.LblCurrencyRate
        Me.LblDropCurrency.Text = LoStrId.LblCurrency
        Me.BtnPrint.Text = LoStrId.LblPrint
        Me.LblReference.Text = LoStrId.LblReference
        ChangeTextButtonToRight(Me.TxtItemName, Me.ATxtItemNameBtn)
        ChangeTextButtonToRight(Me.TxtVendor, TxtVendorBtn)

    End Sub

    Private Sub FillGrid()
        Dim QuantityCol As New GridViewDecimalColumn With {
            .Name = "Qty",
            .DecimalPlaces = 3,
            .Minimum = 0
        }

        Dim DeleteColumn As New GridViewCommandColumn With {
            .Name = "Delete",
            .Image = My.Resources._Erase,
            .ImageAlignment = ContentAlignment.MiddleCenter,
            .AutoEllipsis = True,
            .Width = 15
        }

        Dim DiscountCol As New GridViewDecimalColumn With {
            .Name = "ItemDiscount",
            .Minimum = 0,
            .DecimalPlaces = 3
        }


        Dim TotalBeforeDisc As New GridViewDecimalColumn With {
            .Name = "SubTotal",
            .ReadOnly = True,
            .Expression = "Qty * PurchasingPrice"
        }

        Dim TotalAfterDisc As New GridViewDecimalColumn With {
            .Name = "TotalDue",
            .ReadOnly = True,
            .Expression = "(Qty * PurchasingPrice) - ItemDiscount"
        }

        Dim ItemID As New GridViewTextBoxColumn With
            {
        .Name = "Item_id",
        .FieldName = "Item_id",
         .[ReadOnly] = True,
        .Width = 30
            }

        Dim ItemName As New GridViewTextBoxColumn With
            {
        .Name = "Item_name",
        .FieldName = "Item_name",
        .AutoSizeMode = BestFitColumnMode.DisplayedDataCells,
        .[ReadOnly] = True
          }

        Dim PurchasingPrice As New GridViewDecimalColumn With
            {
        .Name = "PurchasingPrice",
        .FieldName = "PurchasingPrice",
        .[ReadOnly] = False
                  }

        Dim SellingPrice As New GridViewDecimalColumn With
            {
        .Name = "SellingPrice",  'سعر البيع
        .FieldName = "SellingPrice",
        .[ReadOnly] = False,
        .Minimum = 0
                  }

        'Dim SellingPricePercent As New GridViewTextBoxColumn With
        '    {
        '.Name = "SellingPricePercent",
        '.FieldName = "SellingPricePercent",
        '.[ReadOnly] = True
        '  }

        Dim AvailableQty As New GridViewTextBoxColumn With
            {
        .Name = "AvailableQty",
        .FieldName = "Qty",
        .[ReadOnly] = True
          }

        Me.GridInvItem.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridInvItem.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom
        Me.GridInvItem.MasterTemplate.Columns.Add(ItemID)
        Me.GridInvItem.MasterTemplate.Columns.Add(ItemName)
        Me.GridInvItem.MasterTemplate.Columns.Add(PurchasingPrice)
        Me.GridInvItem.MasterTemplate.Columns.Add(SellingPrice)
        ' Me.GridInvItem.MasterTemplate.Columns.Add(SellingPricePercent)
        Me.GridInvItem.MasterTemplate.Columns.Add(AvailableQty)
        Me.GridInvItem.MasterTemplate.Columns.Add(QuantityCol)
        Me.GridInvItem.MasterTemplate.Columns.Add(TotalBeforeDisc)
        Me.GridInvItem.MasterTemplate.Columns.Add(DiscountCol)
        Me.GridInvItem.MasterTemplate.Columns.Add(TotalAfterDisc)
        Me.GridInvItem.MasterTemplate.Columns.Add(DeleteColumn)
        Me.GridInvItem.MasterTemplate.Columns.Add("IsAlertQtyOnBuy")

        AddHandler GridInvItem.CommandCellClick, AddressOf DeleteItem

        InitiateGrid(Me.GridInvItem, Editing:=True)
        'HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("SellingPricePercent").Index, False)
        HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("IsAlertQtyOnBuy").Index, False)

        HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("PurchasingPrice").Index, BoolShowAddPurchasesOrdersColPurchasePrice)
    End Sub

    Private Sub DeleteItem()
        If GridInvItem.Rows.Count > 0 Then
            Me.GridInvItem.CurrentRow.Delete()
        End If
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If Not (Me.TxtItemName.Text.Length = 0 And Me.TxtItemid.Text.Length = 0 And Me.TxtItemBarcode.Text.Length = 0) Then
            'ADD
            If EnterPressed = "ItemName" And Me.TxtItemName.Text.Trim <> String.Empty Then
                Dim Param(3) As String
                Param(0) = "@CBy , Name"
                Param(1) = "@CItemName , " & Evalquote(Me.TxtItemName.Text)
                Param(2) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                Param(3) = "@CurrencyVal , " & Me.txtDollarRate.Text
                AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsForOrders", Param))
                Me.TxtItemName.Text = ""

            ElseIf EnterPressed = "ItemID" And Me.TxtItemid.Text.Trim <> String.Empty Then
                Dim Param(3) As String
                Param(0) = "@CBy , ID"
                Param(1) = "@IItemID , " & Me.TxtItemid.Text
                Param(2) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                Param(3) = "@CurrencyVal , " & Me.txtDollarRate.Text
                AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsForOrders", Param))
                Me.TxtItemid.Text = ""

            ElseIf EnterPressed = "Barcode" And Me.TxtItemBarcode.Text.Trim <> String.Empty Then
                Dim Param(3) As String
                Param(0) = "@CBy , Barcode"
                Param(1) = "@CBarcode , " & Evalquote(Me.TxtItemBarcode.Text)
                Param(2) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                Param(3) = "@CurrencyVal , " & Me.txtDollarRate.Text
                AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsForOrders", Param))
                Me.TxtItemBarcode.Text = ""
            End If
        End If
    End Sub
    Public Sub AddItemToGrid(ByVal dt As DataTable)

        If dt.Rows.Count > 0 Then
            For Each row In GridInvItem.Rows
                If row.Cells("Item_id").Value.ToString = dt.Rows(0).Item("Item_id").ToString Then
                    row.Cells("Qty").Value = row.Cells("Qty").Value + 1
                    'MessageShowInfo(Con.Msg_Item_Has_Been_Added)
                    Exit Sub
                End If
            Next
            Dim rowInfo As New GridViewDataRowInfo(Me.GridInvItem.MasterView)
            'Dim CurrencyID = dt.Rows(0).Item("CurrencyID")
            rowInfo.Cells("Item_id").Value = dt.Rows(0).Item("Item_id").ToString
            rowInfo.Cells("Item_name").Value = dt.Rows(0).Item("Item_name").ToString
            rowInfo.Cells("PurchasingPrice").Value = dt.Rows(0).Item("PurchasingPrice").ToString
            rowInfo.Cells("SellingPrice").Value = dt.Rows(0).Item("SellingPrice").ToString
            'ElseIf CurrencyID = 1 Then   'L.L Default Currency
            '    rowInfo.Cells("PurchasingPrice").Value = (Math.Round(dt.Rows(0).Item("PurchasingPrice") / Me.TxtCurrencyVal.Text, 3, MidpointRounding.AwayFromZero)).ToString
            '    rowInfo.Cells("SellingPrice").Value = (Math.Round(dt.Rows(0).Item("SellingPrice") / Me.TxtCurrencyVal.Text, 3, MidpointRounding.AwayFromZero)).ToString
            'Else
            '    rowInfo.Cells("PurchasingPrice").Value = (Math.Round(dt.Rows(0).Item("PurchasingPrice") * Me.TxtCurrencyVal.Text, 3, MidpointRounding.AwayFromZero)).ToString
            '    rowInfo.Cells("SellingPrice").Value = (Math.Round(dt.Rows(0).Item("SellingPrice") * Me.TxtCurrencyVal.Text, 3, MidpointRounding.AwayFromZero)).ToString
            'End If

            'rowInfo.Cells("SellingPricePercent").Value = dt.Rows(0).Item("SellingPricePercent").ToString
            rowInfo.Cells("AvailableQty").Value = dt.Rows(0).Item("Qty").ToString
            rowInfo.Cells("Qty").Value = 1
            rowInfo.Cells("ItemDiscount").Value = "0"
            rowInfo.Cells("TotalDue").Value = "0"
            rowInfo.Cells("SubTotal").Value = "0"
            rowInfo.Cells("IsAlertQtyOnBuy").Value = dt.Rows(0).Item("IsAlertQtyOnBuy")
            GridInvItem.Rows.Add(rowInfo)

            Me.GridInvItem.Columns("Item_name").BestFit()
            Checkdata(rowInfo)
            Me.GridInvItem.Rows.Last.IsCurrent = True
            Me.GridInvItem.Columns("Qty").IsCurrent = True
            GridInvItem.Focus()
        Else
            MessageShowInfo(Con.Msg_Item_Not_Found)
        End If

    End Sub

    Private Sub AddNewPurchase_Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AutoComplete()
        FillDropList()
        If Not BoolForEdit Then
            FormClear()
        Else
            ShowEdit()
        End If
    End Sub
    Private Sub GetID()
        Dim Param(0) As String
        Param(0) = "@VTableName , PurchaseOrder"
        Me.TxtInvID.Text = GetScalarProcedure("GetID", Param)
    End Sub
    Private Sub FillDropList()
        Dim item As New RadListDataItem With {
            .Text = Con.Posted,
            .Value = Status.Posted
        }
        Me.DropStatus.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.UnPosted,
            .Value = Status.UnPosted
        }
        Me.DropStatus.Items.Add(item)

        Initiatedropdownlist(Me.DropStatus)

        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrency.DataSource = Currencydata
        Initiatedropdownlist(Me.DropCurrency)
        Me.DropCurrency.SelectedValue = ProgramFormCurrency

    End Sub
    Sub AutoComplete()

        Me.TxtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtItemName.AutoCompleteCustomSource = ItemsNameAuto
        Me.TxtItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Me.TxtVendor.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtVendor.AutoCompleteCustomSource = VendorNameAuto
        Me.TxtVendor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Public Sub ShowEdit()
        Dim Param(0) As String
        Param(0) = "@InvID  , " & InvID
        Dim DPurchaseOrderHeaders As DataTable = ExecuteProcedureDatatableWithParameters("SelectPurchasesOrdersJoinVendorByID", Param)
        Me.TxtInvID.Text = InvID
        Me.TxtVendor.Text = DPurchaseOrderHeaders.Rows(0).Item("VendorName").ToString
        VendorID = DPurchaseOrderHeaders.Rows(0).Item("VendorID").ToString
        Me.MskTxtInvDate.Text = DPurchaseOrderHeaders.Rows(0).Item("DueDate").ToString
        Me.TxtSubTotal.Text = DPurchaseOrderHeaders.Rows(0).Item("SubTotal").ToString
        Me.TxtTotalDue.Text = DPurchaseOrderHeaders.Rows(0).Item("TotalDue").ToString
        Me.RadioPurchases.IsChecked = IIf(DPurchaseOrderHeaders.Rows(0).Item("Type").ToString = "PO", True, False)
        Me.RadioReturns.IsChecked = IIf(DPurchaseOrderHeaders.Rows(0).Item("Type").ToString = "RPO", True, False)
        Me.RadioCash.IsChecked = IIf(DPurchaseOrderHeaders.Rows(0).Item("PaymentType").ToString = "C", True, False)
        Me.RadioDebt.IsChecked = IIf(DPurchaseOrderHeaders.Rows(0).Item("PaymentType").ToString = "D" Or DPurchaseOrderHeaders.Rows(0).Item("PaymentType").ToString = "PI", True, False)
        If DPurchaseOrderHeaders.Rows(0).Item("PaymentType").ToString = "PI" Then
            Me.LblPaid.Text = Con.Paid
        End If
        Me.DropStatus.SelectedValue = DPurchaseOrderHeaders.Rows(0).Item("Status").ToString
        Me.DropCurrency.SelectedValue = DPurchaseOrderHeaders.Rows(0).Item("CurrencyID")
        Me.TxtInvoiceReference.Text = DPurchaseOrderHeaders.Rows(0).Item("InvoiceNumber").ToString
        Me.TxtCurrencyVal.Text = DPurchaseOrderHeaders.Rows(0).Item("CurrencyVal").ToString
        Me.TxtCurrencyVal.Tag = DPurchaseOrderHeaders.Rows(0).Item("CurrencyRateID").ToString
        Me.txtDollarRate.Text = DPurchaseOrderHeaders.Rows(0).Item("fDollarRate_amt").ToString

        Me.TxtDiscount.Value = DPurchaseOrderHeaders.Rows(0).Item("Discount").ToString
        Dim DtPurchasesOrderDetailsItems As DataTable = ExecuteProcedureDatatableWithParameters("SelectPurchasesOrdersDetailsJoinItemsByID", Param)
        For i As Integer = 0 To DtPurchasesOrderDetailsItems.Rows.Count - 1
            Dim newrow As New GridViewDataRowInfo(Me.GridInvItem.MasterView)
            newrow.Cells("Item_id").Value = DtPurchasesOrderDetailsItems.Rows(i).Item("Item_id")
            newrow.Cells("Item_name").Value = DtPurchasesOrderDetailsItems.Rows(i).Item("Item_name")
            newrow.Cells("PurchasingPrice").Value = DtPurchasesOrderDetailsItems.Rows(i).Item("PurchasingPrice")
            newrow.Cells("SellingPrice").Value = DtPurchasesOrderDetailsItems.Rows(i).Item("SellingPrice")
            If Me.DropStatus.SelectedValue = Status.Posted Then
                newrow.Cells("AvailableQty").Value = DtPurchasesOrderDetailsItems.Rows(i).Item("AvailableQty")
            Else
                Dim ParamItem(3) As String
                ParamItem(0) = "@CBy , ID"
                ParamItem(1) = "@IItemID , " & newrow.Cells("Item_id").Value
                ParamItem(2) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                ParamItem(3) = "@CurrencyVal , " & Me.TxtCurrencyVal.Text
                Dim DtItem As DataTable = ExecuteProcedureDatatableWithParameters("SelectItemsForOrders", ParamItem)

                newrow.Cells("AvailableQty").Value = DtItem.Rows(0).Item("Qty")
            End If
            newrow.Cells("Qty").Value = DtPurchasesOrderDetailsItems.Rows(i).Item("Qty")
            newrow.Cells("SubTotal").Value = DtPurchasesOrderDetailsItems.Rows(i).Item("SubTotal")
            newrow.Cells("ItemDiscount").Value = DtPurchasesOrderDetailsItems.Rows(i).Item("ItemDiscount")
            newrow.Cells("TotalDue").Value = DtPurchasesOrderDetailsItems.Rows(i).Item("TotalDue")
            Me.GridInvItem.Rows.Add(newrow)
        Next
        If DropStatus.SelectedValue = Status.Posted Then
            EnableDisable(True)
            CannotEdit = True
        Else
            Me.BtnSaveAndNew.Tag = "Edit"
            Me.BtnSaveAndNew.Text = Con.Edit
            EnableDisable(False)
            CannotEdit = False
        End If
    End Sub

    Private Sub EnableDisable(Optional ByVal All As Boolean = False)
        If All Then
            Me.RadioPurchases.Enabled = Me.RadioPurchases.IsChecked
            Me.RadioReturns.Enabled = Me.RadioReturns.IsChecked
            Me.TxtVendor.Enabled = False
            Me.DropStatus.Enabled = False
            Me.MskTxtInvDate.Enabled = False
            Me.TxtDiscount.Enabled = False
            Me.RadioDebt.Enabled = Me.RadioDebt.IsChecked
            Me.RadioCash.Enabled = Me.RadioCash.IsChecked
            Me.GridInvItem.ReadOnly = True
            Me.TLPHeader.Enabled = False
            Me.BtnSaveAndNew.Enabled = False
            Me.TxtInvoiceReference.Enabled = False
            BtnGetCurrencyVal.Enabled = False
            HideShowColummn(Me.GridInvItem, Me.GridInvItem.Columns("Delete").Index, False)
        Else
            Me.TxtVendor.Enabled = False
        End If
    End Sub

    Sub Checkdata(ByVal row As GridViewDataRowInfo)
        If row.Cells("SubTotal").Value <> Nothing Then
            row.ErrorText = row.ErrorText.Replace(Con.Msg_Discount_Is_Greater_Than_Total_Price, String.Empty)
            If row.Cells("SubTotal").Value < row.Cells("ItemDiscount").Value Then
                'MessageShowInfo(con.Msg_Discount_Is_Greater_Than_Total_Price)
                row.ErrorText &= Con.Msg_Discount_Is_Greater_Than_Total_Price
            End If
        End If

        row.ErrorText = row.ErrorText.Replace(Con.Msg_Selling_Is_Smaller_Than_Purchasing_Price, String.Empty)
        If row.Cells("SellingPrice").Value < row.Cells("PurchasingPrice").Value Then
            'MessageShowInfo(con.Msg_Selling_Is_Smaller_Than_Purchasing_Price)
            row.ErrorText &= Con.Msg_Selling_Is_Smaller_Than_Purchasing_Price
        End If

    End Sub

    Private Sub GridInvItem_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles GridInvItem.CellEndEdit
        If Not CannotEdit Then
            Dim column As GridViewDataColumn = TryCast(e.Column, GridViewDataColumn)
            If TypeOf e.Row Is GridViewDataRowInfo AndAlso column IsNot Nothing Then

                If (column.Name = "ItemDiscount" Or column.Name = "SellingPrice" Or column.Name = "Qty") Then
                    If e.Row.Cells("SubTotal").Value <> Nothing Then
                        e.Row.ErrorText = e.Row.ErrorText.Replace(Con.Msg_Discount_Is_Greater_Than_Total_Price, String.Empty)
                        If e.Row.Cells("SubTotal").Value < e.Row.Cells("ItemDiscount").Value Then
                            'MessageShowInfo(con.Msg_Discount_Is_Greater_Than_Total_Price)
                            e.Row.ErrorText = e.Row.ErrorText & Con.Msg_Discount_Is_Greater_Than_Total_Price
                        End If
                    End If
                End If
                If column.Name = "SellingPrice" Or column.Name = "PurchasingPrice" Then
                    e.Row.ErrorText = e.Row.ErrorText.Replace(Con.Msg_Selling_Is_Smaller_Than_Purchasing_Price, String.Empty)
                    If e.Row.Cells("SellingPrice").Value < e.Row.Cells("PurchasingPrice").Value Then
                        'MessageShowInfo(con.Msg_Selling_Is_Smaller_Than_Purchasing_Price)
                        e.Row.ErrorText = e.Row.ErrorText & Con.Msg_Selling_Is_Smaller_Than_Purchasing_Price
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub GridInvItem_CellValidating(sender As Object, e As CellValidatingEventArgs) Handles GridInvItem.CellValidating
        Dim column As GridViewDataColumn = TryCast(e.Column, GridViewDataColumn)
        If Not CannotEdit Then
            If TypeOf e.Row Is GridViewDataRowInfo AndAlso column IsNot Nothing Then
                If column.Name = "Qty" Then
                    If e.Value = Nothing OrElse DirectCast(e.Value, Decimal) <= 0 Then
                        e.Cancel = True
                    End If
                ElseIf column.Name = "SellingPrice" Then
                    If e.Value Is Nothing OrElse e.Value <= 0 Then
                        e.Cancel = True
                    End If
                ElseIf column.Name = "PurchasingPrice" Then
                    If e.Value Is Nothing OrElse e.Value <= 0 Then
                        e.Cancel = True
                    End If
                ElseIf column.Name = "ItemDiscount" Then
                    If e.Value < 0 OrElse e.Value Is Nothing Then
                        e.Cancel = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub GridInvItem_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridInvItem.ViewCellFormatting
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

    Private Sub GridInvItem_CellEditorInitialized(sender As Object, e As GridViewCellEventArgs) Handles GridInvItem.CellEditorInitialized
        Dim spinEditor As GridSpinEditor = TryCast(Me.GridInvItem.ActiveEditor, GridSpinEditor)
        If spinEditor IsNot Nothing Then
            Dim element As RadSpinEditorElement = spinEditor.EditorElement
            element.ShowUpDownButtons = False
            element.TextAlignment = HorizontalAlignment.Center
        End If
    End Sub
    Private Function CheckRowsErrors() As Boolean

        For Each row In Me.GridInvItem.Rows
            If row.ErrorText <> String.Empty Then
                Return True
                Exit Function
            End If
        Next
        Return False
    End Function

    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If Me.GridInvItem.ChildRows.Count <> 0 Then
            If Me.TxtVendor.Text.Length <> 0 And Me.MskTxtInvDate.Text.Length <> 0 _
                And Me.DropStatus.SelectedIndex <> -1 Then
                If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                    If CheckRowsErrors() Then
                        If MessageShowAsk(Con.Ask_Grid_Has_Error) = DialogResult.No Then
                            Exit Sub
                        End If
                    End If

                    Dim Param(14) As String
                    Param(0) = "@TDueDate , " & Me.MskTxtInvDate.Value
                    Param(1) = "@IVendorID , " & VendorID
                    Param(2) = "@CPaymentType , " & IIf(Me.RadioCash.IsChecked, "C", "D")
                    Param(3) = "@CDescription , " & IIf(RadioPurchases.IsChecked, Con.PO_Description, Con.RPO_Description)
                    Param(4) = "@CType , " & IIf(Me.RadioPurchases.IsChecked, "PO", "RPO")
                    Param(5) = "@IStatus , " & Me.DropStatus.SelectedValue
                    Param(6) = "@FSubTotal , " & Me.TxtSubTotal.Text
                    Param(7) = "@FTotalDue , " & Me.TxtTotalDue.Text
                    Param(8) = "@ICurrencyRateID , " & Me.TxtCurrencyVal.Tag.ToString
                    Param(9) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                    Param(10) = "@fDollarRate_amt , " & Me.txtDollarRate.Text
                    Param(11) = "@CInvoiceNumber , " & Evalquote(Me.TxtInvoiceReference.Text)
                    Param(12) = "@FDiscount , " & Me.TxtDiscount.Text
                    Param(13) = "@IInvID , " & Me.TxtInvID.Text
                    Param(14) = "@IUserID , " & UserID

                    If BtnSaveAndNew.Tag = "Save" Then
                        ExecuteProcedureWithParameters("InsertNewPurchaseOrderHeader", Param)

                        InsertItemDetails()

                        Dim Rptparam(0) As String
                        Rptparam(0) = "InvID , " & Me.TxtInvID.Text
                        If Not BoolForPrint Then
                            If MessageShowAsk(Con.Ask_Do_You_Want_Print_Invoice) = DialogResult.Yes Then
                                OpenReport(Con.RptPurchaseOrder, Rptparam)
                            End If
                        Else
                            OpenReport(Con.RptPurchaseOrder, Rptparam)
                        End If
                        FormClear()
                        ToDoRefrech = True
                    ElseIf BtnSaveAndNew.Tag = "Edit" Then
                        Dim ParamDelete(0) As String
                        ParamDelete(0) = "@IInvID , " & Me.TxtInvID.Text
                        ExecuteProcedureWithParameters("UpdatePurchaseOrderHeader", Param)
                        ExecuteProcedureWithParameters("DeletePurchaseOrdersDetails", ParamDelete)
                        InsertItemDetails()
                        MessageShowInfo(Con.Msg_Invoice_Has_Been_Updated)
                        If DropStatus.SelectedValue = Status.Posted Then
                            EnableDisable(True)
                            CannotEdit = True
                        Else
                            EnableDisable(False)
                            CannotEdit = False
                        End If
                        ToDoRefrech = True
                    End If
                End If

            Else
                MessageShowInfo(Con.Msg_Enter_All_Fields)
            End If
        Else
            MessageShowInfo(Con.Msg_No_Items_Added)
        End If
    End Sub

    Private Sub InsertItemDetails()
        For i As Integer = 0 To GridInvItem.ChildRows.Count - 1
            Dim ParamDetails(12) As String
            ParamDetails(0) = "@TDueDate , " & Me.MskTxtInvDate.Value
            ParamDetails(1) = "@IItemID , " & Me.GridInvItem.Rows(i).Cells("Item_id").Value
            ParamDetails(2) = "@FSubTotal , " & Me.GridInvItem.Rows(i).Cells("SubTotal").Value
            ParamDetails(3) = "@FTotalDue , " & Me.GridInvItem.Rows(i).Cells("TotalDue").Value
            ParamDetails(4) = "@FItemDiscount , " & Me.GridInvItem.Rows(i).Cells("ItemDiscount").Value
            ParamDetails(5) = "@IInvID , " & Me.TxtInvID.Text
            ParamDetails(6) = "@FQty , " & Me.GridInvItem.Rows(i).Cells("Qty").Value
            ParamDetails(7) = "@FSellingPrice , " & Me.GridInvItem.Rows(i).Cells("SellingPrice").Value
            ParamDetails(8) = "@FPurchasingPrice , " & Me.GridInvItem.Rows(i).Cells("PurchasingPrice").Value
            ParamDetails(9) = "@FAvailableQty , " & Me.GridInvItem.Rows(i).Cells("AvailableQty").Value
            ParamDetails(10) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
            ParamDetails(11) = "@fDollarRate_amt , " & Me.txtDollarRate.Text
            ParamDetails(12) = "@IUserID , " & UserID
            ExecuteProcedureWithParameters("InsertNewPurchaseOrdersDetails", ParamDetails)
        Next
    End Sub
    Private Sub FormClear()
        GetID()
        Me.MskTxtInvDate.Value = Date.Now.Date
        Me.TxtVendor.Clear()
        ShowPermissions()
        Me.TxtDiscount.Value = 0
        Me.GridInvItem.Rows.Clear()
        Me.RadioCash.IsChecked = True
        Me.RadioPurchases.IsChecked = True
        Me.DropCurrency.SelectedValue = ProgramFormCurrency
        Me.txtDollarRate.Text = LastDollarCurrencyRate
        Me.MskTxtInvDate.Value = Date.Now.Date
        Me.TxtInvoiceReference.Text = String.Empty
        Me.TxtItemid.Focus()
    End Sub

    Private Sub GridInvItem_GroupSummaryEvaluate(sender As Object, e As GroupSummaryEvaluationEventArgs) Handles GridInvItem.GroupSummaryEvaluate
        If e.SummaryItem.Name = "TotalDue" Then
            ' e.FormatString = String.Format("There are {0} ships total.", e.Value)
            Me.TxtSubTotal.Text = IIf(e.Value = 0, "0", e.Value)
            Me.TxtTotalDue.Text = Me.TxtSubTotal.Text - Me.TxtDiscount.Value
        End If
        If Me.GridInvItem.ChildRows.Count > 0 Then
            Me.DropCurrency.Enabled = False
            Me.BtnGetCurrencyVal.Enabled=False
        Else
            Me.DropCurrency.Enabled = True
            Me.BtnGetCurrencyVal.Enabled = True
        End If
    End Sub

    Private Sub TxtItemName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtItemName.Validating
        If Not ItemsNameAuto.Contains(Me.TxtItemName.Text.ToLower) Then
            Me.TxtItemName.Text = String.Empty
        End If
    End Sub

    Private Sub TxtVendorBtn_Click(sender As Object, e As EventArgs) Handles TxtVendorBtn.Click
        Dim FrmGetVendors As New VendorsPopup
        FrmGetVendors.ShowDialog()
        Me.TxtVendor.Text = FrmGetVendors.GetVendorName
    End Sub

    Private Sub ATxtItemNameBtn_Click(sender As Object, e As EventArgs) Handles ATxtItemNameBtn.Click
        Dim FrmGetItem As New ItemsPopup
        FrmGetItem.ShowDialog()
        If Not FrmGetItem.GetITemName.Length = 0 Then
            Me.TxtItemName.Text = FrmGetItem.GetITemName
        End If
    End Sub

    Private Sub TxtVendor_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtVendor.Validating
        If Not VendorNameAuto.Contains(Me.TxtVendor.Text.ToLower) Then
            If Not VendorNameAuto.Contains(Me.TxtVendor.Text.ToLower & "/" & VendorTitle & "/" & VendorID) Then
                Me.TxtVendor.Text = String.Empty
                VendorID = String.Empty
                VendorTitle = String.Empty
            End If
        Else
            Dim VendorData() As String = Me.TxtVendor.Text.Split("/")
            VendorID = VendorData(2)
            Me.TxtVendor.Text = VendorData(0)
            VendorTitle = VendorData(1)
        End If
    End Sub

    Private Sub TxtItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "ItemName"
            BtnAdd.PerformClick()
        End If
    End Sub

    Private Sub TxtItemBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "Barcode"
            BtnAdd.PerformClick()
            Me.TxtItemBarcode.Focus()
        End If
    End Sub

    Private Sub TxtItemid_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemid.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "ItemID"
            BtnAdd.PerformClick()
        End If
    End Sub

    Private Sub TxtItemid_TextChanged(sender As Object, e As EventArgs) Handles TxtItemid.TextChanged
        EnterPressed = "ItemID"
    End Sub

    Private Sub TxtItemName_TextChanged(sender As Object, e As EventArgs) Handles TxtItemName.TextChanged
        EnterPressed = "ItemName"
    End Sub

    Private Sub TxtItemBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtItemBarcode.TextChanged
        EnterPressed = "Barcode"
    End Sub

    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles TxtDiscount.TextChanged
        Me.TxtTotalDue.Text = Me.TxtSubTotal.Text - Me.TxtDiscount.Value
    End Sub

    Private Sub DropStatus_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles DropStatus.SelectedIndexChanged

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If Me.BtnSaveAndNew.Enabled = False Then
            Dim Rptparam(0) As String
            Rptparam(0) = "InvID , " & Me.TxtInvID.Text
            OpenReport(Con.RptPurchaseOrder, Rptparam)
        Else
            BoolForPrint = True
            BtnSaveAndNew.PerformClick()
        End If

    End Sub

    Private Sub DropCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles DropCurrency.SelectedIndexChanged
        DropCurerncySelectedChange()
    End Sub
    Private Sub DropCurerncySelectedChange()
        If Me.DropCurrency.SelectedIndex <> -1 Then
            Dim CurrencyRow As DataRow = Currencydata.Select("CurrencyID = " & Me.DropCurrency.SelectedValue).First
            If Me.DropCurrency.SelectedValue.ToString = "1" Then
                Me.TxtCurrencyVal.Text = "1"
                Me.TxtCurrencyVal.Tag = "1"
                If CurrencyRow("CurrFloat").ToString = "-1" Then
                    Me.TxtDiscount.Mask = "F0"
                Else
                    Me.TxtDiscount.Mask = "F" & CurrencyRow("CurrFloat").ToString
                End If
            Else
                Me.TxtCurrencyVal.Text = CurrencyRow("CurrencyVal").ToString
                Me.TxtCurrencyVal.Tag = CurrencyRow("LastChangeID").ToString
                If CurrencyRow("CurrFloat").ToString = "-1" Then
                    Me.TxtDiscount.Mask = "F0"
                Else
                    Me.TxtDiscount.Mask = "F" & CurrencyRow("CurrFloat").ToString
                End If
            End If
        End If
    End Sub
    Private Sub TxtVendor_ToolTipTextNeeded(sender As Object, e As ToolTipTextNeededEventArgs) Handles TxtVendor.ToolTipTextNeeded
        e.ToolTipText = VendorTitle
    End Sub

    Private Sub BtnGetCurrencyVal_Click(sender As Object, e As EventArgs) Handles BtnGetCurrencyVal.Click
        If (Control.ModifierKeys = Keys.Control) And Me.DropCurrency.SelectedValue <> "1" Then
            Dim FrmAddCurrVal As New CurrencyRate
            FrmAddCurrVal.GetCurrencyRate = True
            FrmAddCurrVal.ShowDialog()
            If FrmAddCurrVal.GetCurrencyVal.Length <> 0 And FrmAddCurrVal.GetCurrencyRateID.Length <> 0 Then
                Me.TxtCurrencyVal.Text = FrmAddCurrVal.GetCurrencyVal
                Me.TxtCurrencyVal.Tag = FrmAddCurrVal.GetCurrencyRateID
                Me.txtDollarRate.Text = FrmAddCurrVal.GetCurrencyVal
            End If
        Else
            Me.txtDollarRate.Text = LastDollarCurrencyRate
            DropCurerncySelectedChange()
        End If
    End Sub

    Private Sub GridInvItem_KeyDown(sender As Object, e As KeyEventArgs) Handles GridInvItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim column As GridViewDataColumn = TryCast(sender.CurrentColumn, GridViewDataColumn)
            If column.Name = "Qty" And EnterPressed = "ItemName" Then
                TxtItemName.Focus()
            ElseIf column.Name = "Qty" And EnterPressed = "ItemID" Then
                TxtItemid.Focus()
            ElseIf column.Name = "Qty" And EnterPressed = "Barcode" Then
                TxtItemBarcode.Focus()
            End If
        End If
    End Sub
End Class

