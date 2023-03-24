Imports System.Globalization
Imports Telerik.Reporting
Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI

Public Class AddNewSaleInvoice
    Dim EnterPressed As String
    Public BoolForEdit As Boolean = False
    Public InvID As String
    Dim BoolForPrint As Boolean = False
    Dim CustomerID As String
    Dim CustomerTitle As String
    Dim oldstatus As Integer
    Dim boolTimerStarted As Boolean = False
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        TimerPurchasePrice.Interval = 1500
        ShowPermissions()
        FillGrid()


    End Sub
    Sub ShowPermissions()
        Me.LblBarcode.Visible = BoolShowBarcode
        Me.TxtItemBarcode.Visible = BoolShowBarcode
        Dim ItemsRow As DataRow = UserRolesdt.Select("KeyName = 'SO'").First
        If ItemsRow("AllowPosted").ToString <> True Then
            Me.DropStatus.SelectedValue = Status.UnPosted
            Me.DropStatus.Enabled = False
        Else
            Me.DropStatus.SelectedValue = DefaultPOStatus
        End If
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.LblSaleOrder
        Me.LblInvID.Text = LoStrId.LblInvID
        Me.LblInvType.Text = LoStrId.LblInvType
        Me.LblInvDate.Text = LoStrId.LblDate
        Me.LblDiscount.Text = LoStrId.LblDiscount
        Me.LblDueTotal.Text = LoStrId.LblDueTotal
        Me.LblInvCustomer.Text = LoStrId.lblCustomer
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
        Me.RadioSales.Text = LoStrId.LblSales
        Me.RadioReturns.Text = LoStrId.LblReturn
        Me.LblCurrValue.Text = LoStrId.LblCurrencyRate
        Me.LblDropCurrency.Text = LoStrId.LblCurrency
        Me.BtnPrint.Text = LoStrId.LblPrint
        Me.lblProfit.Text = LoStrId.lblProfit
        'ChangeTextButtonToRight(Me.TxtItemName, Me.ATxtItemNameBtn)
        ChangeTextButtonToRight(Me.TxtCustomer, TxtCustomerBtn)

    End Sub

    Private Sub AddNewSaleInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Param(0) = "@VTableName , SalesOrder"
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

    End Sub
    Sub AutoComplete()
        Me.CustomTxtItemName.AutoCompleteDataSource = ItemsNameAuto
        Me.CustomTxtItemName.AutoCompleteMode = AutoCompleteMode.Suggest

        Me.TxtCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtCustomer.AutoCompleteCustomSource = CustomerNameAuto
        Me.TxtCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Public Sub ShowEdit()

        HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("Refresh").Index, False)

        Dim Param(0) As String
        Param(0) = "@InvID  , " & InvID
        Dim DtSalesOrderHeaders As DataTable = ExecuteProcedureDatatableWithParameters("SelectSalesOrdersJoinCustomersByID", Param)
        If DtSalesOrderHeaders.Rows.Count > 0 Then
            Me.TxtInvID.Text = InvID
            Me.TxtCustomer.Text = DtSalesOrderHeaders.Rows(0).Item("CustomerName").ToString
            CustomerID = DtSalesOrderHeaders.Rows(0).Item("CustomerID").ToString
            Me.MskTxtInvDate.Text = DtSalesOrderHeaders.Rows(0).Item("DueDate").ToString
            Me.TxtSubTotal.Text = DtSalesOrderHeaders.Rows(0).Item("SubTotal").ToString

            Me.TxtTotalDue.Text = DtSalesOrderHeaders.Rows(0).Item("TotalDue").ToString
            FillTotalDueBig()

            Me.RadioSales.IsChecked = IIf(DtSalesOrderHeaders.Rows(0).Item("Type").ToString = "SO", True, False)
            Me.RadioReturns.IsChecked = IIf(DtSalesOrderHeaders.Rows(0).Item("Type").ToString = "RSO", True, False)
            Me.RadioCash.IsChecked = IIf(DtSalesOrderHeaders.Rows(0).Item("PaymentType").ToString = "C", True, False)
            Me.RadioDebt.IsChecked = IIf(DtSalesOrderHeaders.Rows(0).Item("PaymentType").ToString = "D" Or DtSalesOrderHeaders.Rows(0).Item("PaymentType").ToString = "PI", True, False)
            If DtSalesOrderHeaders.Rows(0).Item("PaymentType").ToString = "PI" Then
                Me.LblPaid.Text = Con.Paid
            End If
            Me.DropStatus.SelectedValue = DtSalesOrderHeaders.Rows(0).Item("Status").ToString
            oldstatus = Me.DropStatus.SelectedValue

            Me.txtDollarRate.Text = DtSalesOrderHeaders.Rows(0).Item("fDollarRate_amt").ToString
            Me.DropCurrency.SelectedValue = DtSalesOrderHeaders.Rows(0).Item("CurrencyID")
            Me.TxtCurrencyVal.Text = DtSalesOrderHeaders.Rows(0).Item("CurrencyVal").ToString
            Me.TxtCurrencyVal.Tag = DtSalesOrderHeaders.Rows(0).Item("CurrencyRateID").ToString

            Me.TxtDiscount.Value = DtSalesOrderHeaders.Rows(0).Item("Discount").ToString
            Dim DtSalesOrderDetailsItems As DataTable = ExecuteProcedureDatatableWithParameters("SelectSalesOrdersDetailsJoinItemsByID", Param)
            For i As Integer = 0 To DtSalesOrderDetailsItems.Rows.Count - 1
                '  Me.GridInvItem.Rows.Add(DtSalesOrderDetailsItems.Rows(i).ItemArray)
                Dim newrow As New GridViewDataRowInfo(Me.GridInvItem.MasterView)
                newrow.Cells("Item_id").Value = DtSalesOrderDetailsItems.Rows(i).Item("Item_id")
                newrow.Cells("Item_name").Value = DtSalesOrderDetailsItems.Rows(i).Item("Item_name")
                newrow.Cells("PurchasingPrice").Value = DtSalesOrderDetailsItems.Rows(i).Item("PurchasingPrice")
                newrow.Cells("SellingPrice").Value = DtSalesOrderDetailsItems.Rows(i).Item("SellingPrice")


                'If Me.DropStatus.SelectedValue = Status.Posted Then
                '    newrow.Cells("AvailableQty").Value = DtSalesOrderDetailsItems.Rows(i).Item("AvailableQty")
                'Else
                Dim ParamItem(3) As String
                ParamItem(0) = "@CBy , ID"
                ParamItem(1) = "@IItemID , " & newrow.Cells("Item_id").Value
                ParamItem(2) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                ParamItem(3) = "@CurrencyVal , " & Me.txtDollarRate.Text
                Dim DtItem As DataTable = ExecuteProcedureDatatableWithParameters("SelectItemsForOrders", ParamItem)

                newrow.Cells("AvailableQty").Value = DtItem.Rows(0).Item("Qty")
                'End If


                newrow.Cells("Qty").Value = DtSalesOrderDetailsItems.Rows(i).Item("Qty")
                newrow.Cells("SubTotal").Value = DtSalesOrderDetailsItems.Rows(i).Item("SubTotal")
                newrow.Cells("ItemDiscount").Value = DtSalesOrderDetailsItems.Rows(i).Item("ItemDiscount")
                newrow.Cells("TotalDue").Value = DtSalesOrderDetailsItems.Rows(i).Item("TotalDue")
                Me.GridInvItem.Rows.Add(newrow)
            Next
        End If
        If DropStatus.SelectedValue = Status.Posted Then
            EnableDisable(True)

        Else
            EnableDisable(False)

        End If
        Me.BtnSaveAndNew.Tag = "Edit"
        Me.BtnSaveAndNew.Text = Con.Edit
    End Sub

    Private Sub EnableDisable(Optional ByVal All As Boolean = False)
        If All Then
            Me.RadioSales.Enabled = Me.RadioSales.IsChecked
            Me.RadioReturns.Enabled = Me.RadioReturns.IsChecked
            Me.DropStatus.Enabled = False
            Me.TxtCustomer.Enabled = False
        Else
            Me.TxtCustomer.Enabled = False

        End If
    End Sub

    Private Sub FillGrid()

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
            .Width = 100,
            .[ReadOnly] = True
        }

        Dim PurchasingPrice As New GridViewDecimalColumn With
        {
            .Name = "PurchasingPrice",
            .FieldName = "PurchasingPrice",
            .Width = 60,
            .[ReadOnly] = True
        }

        Dim SellingPrice As New GridViewDecimalColumn With
        {
            .Name = "SellingPrice",  'سعر البيع
            .FieldName = "SellingPrice",
            .[ReadOnly] = False,
            .Minimum = 0
        }

        Dim RefreshPriceColumn As New GridViewCommandColumn With {
            .Name = "Refresh",
            .HeaderText = "",
            .Image = My.Resources.Refresh16,
            .ImageAlignment = ContentAlignment.MiddleCenter,
            .AutoEllipsis = True,
            .Width = 35,
            .IsVisible = False
        }

        Dim AvailableQty As New GridViewTextBoxColumn With
        {
            .Name = "AvailableQty",
            .FieldName = "Qty",
            .[ReadOnly] = True
        }

        Dim QuantityCol As New GridViewDecimalColumn With {
            .Name = "Qty",
            .DecimalPlaces = 4,
            .Minimum = 0
        }

        Dim SalesProfitByQty As New GridViewDecimalColumn With {
            .Name = "SalesProfitByQty",
            .ReadOnly = True,
            .Expression = "(SellingPrice - PurchasingPrice) * Qty"
        }


        Dim TotalBeforeDisc As New GridViewDecimalColumn With {
            .Name = "SubTotal",
            .ReadOnly = True,
            .Expression = "Qty * SellingPrice"
        }

        Dim DiscountCol As New GridViewDecimalColumn With {
            .Name = "ItemDiscount",
            .DecimalPlaces = 3,
            .Minimum = 0
        }

        Dim TotalAfterDisc As New GridViewDecimalColumn With {
            .Name = "TotalDue",
            .ReadOnly = True,
            .Expression = "(Qty * SellingPrice) - ItemDiscount"
        }

        Dim DeleteColumn As New GridViewCommandColumn With {
            .Name = "Delete",
            .Image = My.Resources._Erase,
            .ImageAlignment = ContentAlignment.MiddleCenter,
            .AutoEllipsis = True,
            .Width = 15
        }

        Me.GridInvItem.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridInvItem.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom

        Me.GridInvItem.MasterTemplate.Columns.Add(ItemID)
        Me.GridInvItem.MasterTemplate.Columns.Add(ItemName)
        Me.GridInvItem.MasterTemplate.Columns.Add(PurchasingPrice)
        Me.GridInvItem.MasterTemplate.Columns.Add(SellingPrice)
        Me.GridInvItem.MasterTemplate.Columns.Add(RefreshPriceColumn)
        Me.GridInvItem.MasterTemplate.Columns.Add(AvailableQty)
        Me.GridInvItem.MasterTemplate.Columns.Add(QuantityCol)
        Me.GridInvItem.MasterTemplate.Columns.Add(SalesProfitByQty)
        Me.GridInvItem.MasterTemplate.Columns.Add(TotalBeforeDisc)
        Me.GridInvItem.MasterTemplate.Columns.Add(DiscountCol)
        Me.GridInvItem.MasterTemplate.Columns.Add(TotalAfterDisc)
        Me.GridInvItem.MasterTemplate.Columns.Add(DeleteColumn)
        Me.GridInvItem.MasterTemplate.Columns.Add("IsAlertQtyOnBuy")
        'Me.GridInvItem.MasterTemplate.Columns.Add("SpecialOfferID")

        'AddHandler GridInvItem.CommandCellClick, AddressOf DeleteItem

        InitiateGrid(Me.GridInvItem, Editing:=True)
        'HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("SellingPricePercent").Index, False)
        HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("IsAlertQtyOnBuy").Index, False)
        ' HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("SpecialOfferID").Index, False)
        HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("PurchasingPrice").Index, BoolShowPurchasingPriceInScreensByUser And BoolShowAddSalesOrdersColPurchasePrice)
    End Sub

    Private Sub GridInvItem_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles GridInvItem.CommandCellClick
        If (e.ColumnIndex = Me.GridInvItem.Columns.Item("Refresh").Index) Then

            RefreshLastItemsPrice()
        Else
            DeleteItem()
        End If
    End Sub

    Private Sub RefreshLastItemsPrice()
        Dim dtItem As New DataTable

        Dim Param(3) As String
        Param(0) = "@CBy , ID"
        Param(1) = "@IItemID , " & Me.GridInvItem.CurrentRow.Cells.Item("Item_id").Value
        Param(2) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
        Param(3) = "@CurrencyVal , " & Me.txtDollarRate.Text
        dtItem = ExecuteProcedureDatatableWithParameters("SelectItemsForOrders", Param)

        If dtItem.Rows.Count > 0 Then

            Me.GridInvItem.CurrentRow.Cells.Item("PurchasingPrice").Value = dtItem.Rows(0).Item("PurchasingPrice").ToString
            Me.GridInvItem.CurrentRow.Cells.Item("SellingPrice").Value = dtItem.Rows(0).Item("SellingPrice").ToString
            Me.GridInvItem.CurrentRow.Cells.Item("AvailableQty").Value = dtItem.Rows(0).Item("Qty").ToString
            Me.GridInvItem.CurrentRow.Cells.Item("IsAlertQtyOnBuy").Value = dtItem.Rows(0).Item("IsAlertQtyOnBuy").ToString
            GridInvItem.Focus()
        End If

    End Sub

    Private Sub DeleteItem()
        If GridInvItem.Rows.Count > 0 Then
            Me.GridInvItem.CurrentRow.Delete()
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If Not (Me.CustomTxtItemName.Text.Length = 0 And Me.TxtItemid.Text.Length = 0 And Me.TxtItemBarcode.Text.Length = 0) Then
            'ADD
            If EnterPressed = "ItemName" And Me.CustomTxtItemName.Text.Trim <> String.Empty Then
                Dim Param(3) As String
                Param(0) = "@CBy , Name"
                Param(1) = "@CItemName , " & Evalquote(Me.CustomTxtItemName.Text)
                Param(2) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                Param(3) = "@CurrencyVal , " & Me.txtDollarRate.Text
                AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsForOrders", Param))
                Me.CustomTxtItemName.Text = ""

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
                    Me.GridInvItem.Rows.Item(row.Index).IsCurrent = True
                    ' Me.GridInvItem.Rows.
                    Exit Sub
                End If
            Next
            Dim rowInfo As New GridViewDataRowInfo(Me.GridInvItem.MasterView)
            rowInfo.Cells("Item_id").Value = dt.Rows(0).Item("Item_id").ToString
            rowInfo.Cells("Item_name").Value = dt.Rows(0).Item("Item_name").ToString
            rowInfo.Cells("PurchasingPrice").Value = dt.Rows(0).Item("PurchasingPrice").ToString
            rowInfo.Cells("SellingPrice").Value = dt.Rows(0).Item("SellingPrice").ToString
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

    Private Sub CustomTxtItemName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CustomTxtItemName.Validating
        If Not ItemsNameAuto.Contains(Me.CustomTxtItemName.Text.ToLower) Then
            Me.CustomTxtItemName.Text = String.Empty
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
    Private Sub GridInvItem_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridInvItem.ViewCellFormatting, GridInvItem.CellFormatting
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

        If e.Column.Name = "PurchasingPrice" Or e.Column.Name = "SellingPrice" Or e.Column.Name = "SalesProfitByQty" _
                Or e.Column.Name = "ItemDiscount" Or e.Column.Name = "TotalDue" Or e.Column.Name = "SubTotal" Then
            e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, Me.DropCurrency.SelectedValue, False)
        End If
    End Sub

    Private Sub GridInvItem_CellValidating(sender As Object, e As CellValidatingEventArgs) Handles GridInvItem.CellValidating
        Dim column As GridViewDataColumn = TryCast(e.Column, GridViewDataColumn)
        If TypeOf e.Row Is GridViewDataRowInfo AndAlso column IsNot Nothing Then
            If column.Name = "Qty" Then
                If e.Value = Nothing OrElse DirectCast(e.Value, Decimal) <= 0 Then
                    e.Cancel = True
                End If
            ElseIf column.Name = "SellingPrice" Then
                If e.Value = Nothing OrElse e.Value <= 0 Then
                    e.Cancel = True
                End If
            ElseIf column.Name = "ItemDiscount" Then
                If e.Value < 0 OrElse e.Value Is Nothing Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Sub Checkdata(ByVal row As GridViewDataRowInfo)
        row.ErrorText = row.ErrorText.Replace(Con.Msg_Qty_Must_Be_Smaller_Than_Available_Quantity, String.Empty)
        If row.Cells("IsAlertQtyOnBuy").Value = "True" And row.Cells("Qty").Value > row.Cells("AvailableQty").Value And Me.RadioSales.IsChecked Then
            row.ErrorText &= Con.Msg_Qty_Must_Be_Smaller_Than_Available_Quantity
            MessageShowInfo(Con.Msg_Qty_Must_Be_Smaller_Than_Available_Quantity)
        End If

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
        Dim column As GridViewDataColumn = TryCast(e.Column, GridViewDataColumn)
        If TypeOf e.Row Is GridViewDataRowInfo AndAlso column IsNot Nothing Then
            If column.Name = "Qty" Then
                e.Row.ErrorText = e.Row.ErrorText.Replace(Con.Msg_Qty_Must_Be_Smaller_Than_Available_Quantity, String.Empty)
                If e.Row.Cells("IsAlertQtyOnBuy").Value = "True" And e.Value > e.Row.Cells("AvailableQty").Value And Me.RadioSales.IsChecked Then
                    e.Row.ErrorText = e.Row.ErrorText & Con.Msg_Qty_Must_Be_Smaller_Than_Available_Quantity
                    MessageShowInfo(Con.Msg_Qty_Must_Be_Smaller_Than_Available_Quantity)
                End If
            End If
            If (column.Name = "ItemDiscount" Or column.Name = "SellingPrice" Or column.Name = "Qty") Then
                If e.Row.Cells("SubTotal").Value <> Nothing Then
                    e.Row.ErrorText = e.Row.ErrorText.Replace(Con.Msg_Discount_Is_Greater_Than_Total_Price, String.Empty)
                    If e.Row.Cells("SubTotal").Value < e.Row.Cells("ItemDiscount").Value Then
                        'MessageShowInfo(con.Msg_Discount_Is_Greater_Than_Total_Price)
                        e.Row.ErrorText = e.Row.ErrorText & Con.Msg_Discount_Is_Greater_Than_Total_Price
                    End If
                End If
            End If
            If column.Name = "SellingPrice" Then
                e.Row.ErrorText = e.Row.ErrorText.Replace(Con.Msg_Selling_Is_Smaller_Than_Purchasing_Price, String.Empty)
                If e.Row.Cells("SellingPrice").Value < e.Row.Cells("PurchasingPrice").Value Then
                    'MessageShowInfo(con.Msg_Selling_Is_Smaller_Than_Purchasing_Price)
                    e.Row.ErrorText = e.Row.ErrorText & Con.Msg_Selling_Is_Smaller_Than_Purchasing_Price
                End If
            End If
        End If

    End Sub

    Private Sub TxtCustomerBtn_Click(sender As Object, e As EventArgs) Handles TxtCustomerBtn.Click
        Dim FrmGetCustomer As New CustomerPopup
        FrmGetCustomer.ShowDialog()
        ' AutoComplete()

        If Not FrmGetCustomer.GetCustomerName.Length = 0 Then
            CustomerNameAuto.Add(FrmGetCustomer.GetCustomerName.ToLower)
            Me.TxtCustomer.Text = FrmGetCustomer.GetCustomerName
        End If
    End Sub

    Private Sub TxtCustomer_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtCustomer.Validating
        If Not CustomerNameAuto.Contains(Me.TxtCustomer.Text.ToLower) Then
            If Not CustomerNameAuto.Contains(Me.TxtCustomer.Text.ToLower & "/" & CustomerTitle & "/" & CustomerID) Then
                Me.TxtCustomer.Text = String.Empty
                CustomerID = String.Empty
                CustomerTitle = String.Empty
            End If
        Else
            Dim CustomerData() As String = Me.TxtCustomer.Text.Split("/")
            CustomerID = CustomerData(2)
            Me.TxtCustomer.Text = CustomerData(0)
            CustomerTitle = CustomerData(1)
        End If
    End Sub

    Private Sub CustomTxtItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomTxtItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "ItemName"
            BtnAdd.PerformClick()
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
            If Me.TxtCustomer.Text.Length <> 0 And CustomerID <> String.Empty And Me.MskTxtInvDate.Text.Length <> 0 _
                And Me.DropStatus.SelectedIndex <> -1 Then
                If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                    If CheckRowsErrors() Then
                        If MessageShowAsk(Con.Ask_Grid_Has_Error) = DialogResult.No Then
                            Exit Sub
                        End If
                    End If

                    Dim Param(14) As String
                    Param(0) = "@TDueDate , " & Me.MskTxtInvDate.Value
                    Param(1) = "@ICustomerID , " & CustomerID
                    Param(2) = "@CPaymentType , " & IIf(Me.RadioCash.IsChecked, "C", "D")
                    Param(3) = "@CDescription , " & IIf(RadioSales.IsChecked, Con.SO_Description, Con.RSO_Description)
                    Param(4) = "@CType , " & IIf(Me.RadioSales.IsChecked, "SO", "RSO")
                    Param(5) = "@IStatus , " & Me.DropStatus.SelectedValue
                    Param(6) = "@FSubTotal , " & Me.TxtSubTotal.Text
                    Param(7) = "@FTotalDue , " & Me.TxtTotalDue.Text
                    Param(8) = "@ICurrencyRateID , " & Me.TxtCurrencyVal.Tag.ToString
                    Param(9) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                    Param(10) = "@fDollarRate_amt , " & Me.txtDollarRate.Text
                    Param(11) = "@ISpecialOfferSOID , " & 0
                    Param(12) = "@FDiscount , " & Me.TxtDiscount.Text
                    Param(13) = "@IInvID , " & Me.TxtInvID.Text
                    Param(14) = "@IUserID , " & UserID

                    If BtnSaveAndNew.Tag = "Save" Then
                        ExecuteProcedureWithParameters("InsertNewSalesOrderHeader", Param)
                        InsertItemDetails()

                        Dim Rptparam(1) As String
                        Rptparam(0) = "InvID , " & Me.TxtInvID.Text
                        Rptparam(1) = "WaterMark , " & CompanyLatinName
                        If Not BoolForPrint Then
                            If BoolShowSalesOrdersPrintQuestionAfterSave Then
                                If MessageShowAsk(Con.Ask_Do_You_Want_Print_Invoice) = DialogResult.Yes Then
                                    OpenReport(Con.RptSalesOrder, Rptparam)
                                End If
                            End If
                        Else
                            OpenReport(Con.RptSalesOrder, Rptparam)
                        End If
                        FormClear()
                        ToDoRefrech = True
                    ElseIf BtnSaveAndNew.Tag = "Edit" Then
                        Dim ParamDelete(1) As String
                        ParamDelete(0) = "@IInvID , " & Me.TxtInvID.Text
                        ParamDelete(1) = "@IOldStatus , " & oldstatus
                        ExecuteProcedureWithParameters("UpdateSalesOrdersHeader", Param)
                        ExecuteProcedureWithParameters("DeleteSalesOrdersDetails", ParamDelete)
                        InsertItemDetails()
                        MessageShowInfo(Con.Msg_Invoice_Has_Been_Updated)
                        If DropStatus.SelectedValue = Status.Posted Then
                            EnableDisable(True)
                        Else
                            EnableDisable(False)
                        End If
                        ToDoRefrech = True
                        Dim Rptparam(1) As String
                        Rptparam(0) = "InvID , " & Me.TxtInvID.Text
                        Rptparam(1) = "WaterMark , " & CompanyLatinName
                        If Not BoolForPrint Then
                            If BoolShowSalesOrdersPrintQuestionAfterSave Then
                                If MessageShowAsk(Con.Ask_Do_You_Want_Print_Invoice) = DialogResult.Yes Then
                                    OpenReport(Con.RptSalesOrder, Rptparam)
                                End If
                            End If
                        Else
                            OpenReport(Con.RptSalesOrder, Rptparam)
                        End If
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
            ParamDetails(10) = "@ISpecialOfferItemID , " & 0
            ParamDetails(11) = "@ILineID , " & i + 1
            ParamDetails(12) = "@IUserID , " & UserID
            ExecuteProcedureWithParameters("InsertNewSalesOrdersDetails", ParamDetails)
        Next
    End Sub

    Private Sub FormClear()
        GetID()
        Me.MskTxtInvDate.Value = Date.Now.Date
        Me.TxtCustomer.Clear()
        ShowPermissions()
        Me.TxtDiscount.Value = 0
        Me.GridInvItem.Rows.Clear()
        Me.RadioCash.IsChecked = True
        Me.RadioSales.IsChecked = True
        Me.DropCurrency.SelectedValue = 1
        Me.RadioCurrencyLebanease.CheckState = CheckState.Checked
        Me.txtDollarRate.Text = LastDollarCurrencyRate
        Me.MskTxtInvDate.Focus()
        LoadSODefaultCustomer()
    End Sub

    Private Sub LoadSODefaultCustomer()
        For Each customer In CustomerNameAuto
            Dim CustomerData() As String = customer.Split("/")
            If iSalesOrderDefaultCustomerID.ToString() = CustomerData(2) Then
                Me.TxtCustomer.Text = CustomerData(0)
                CustomerTitle = CustomerData(1)
                CustomerID = iSalesOrderDefaultCustomerID
            End If
        Next
    End Sub

    Private Sub GridInvItem_GroupSummaryEvaluate(sender As Object, e As GroupSummaryEvaluationEventArgs) Handles GridInvItem.GroupSummaryEvaluate
        If e.SummaryItem.Name = "TotalDue" Then
            ' e.FormatString = String.Format("There are {0} ships total.", e.Value)
            Me.TxtSubTotal.Text = IIf(e.Value = 0, "0", e.Value)
            Me.TxtTotalDue.Text = Me.TxtSubTotal.Text - Me.TxtDiscount.Value
            FillTotalDueBig()
        End If

        If Me.GridInvItem.ChildRows.Count > 0 Then
            'Me.DropCurrency.Enabled = False
            'Me.BtnGetCurrencyVal.Enabled = False
        Else
            Me.DropCurrency.Enabled = True
            Me.BtnGetCurrencyVal.Enabled = True
        End If
        CalculateProfit()
    End Sub

    Private Sub TxtItemid_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemid.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "ItemID"
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

    Private Sub TxtItemid_TextChanged(sender As Object, e As EventArgs) Handles TxtItemid.TextChanged
        EnterPressed = "ItemID"
    End Sub

    Private Sub TxtItemBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtItemBarcode.TextChanged
        EnterPressed = "Barcode"
    End Sub

    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles TxtDiscount.TextChanged
        Me.TxtTotalDue.Text = Me.TxtSubTotal.Text - Me.TxtDiscount.Value
        FillTotalDueBig()
        CalculateProfit()
    End Sub

    Private Sub DropCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles DropCurrency.SelectedIndexChanged
        DropCurerncySelectedChange()
    End Sub

    Private Sub DropCurerncySelectedChange()
        If Me.DropCurrency.SelectedIndex <> -1 Then
            Dim CurrencyRow As DataRow = Currencydata.Select("CurrencyID = " & Me.DropCurrency.SelectedValue).First
            Dim currentInvoiceDiscount As String = Me.TxtDiscount.Text
            If Me.DropCurrency.SelectedValue.ToString = "1" Then
                Me.TxtCurrencyVal.Text = "1"
                Me.TxtCurrencyVal.Tag = "1"
                Me.TxtDiscount.Mask = "F0"

                Dim colSubTotal As GridViewDecimalColumn = Me.GridInvItem.Columns("SubTotal")
                colSubTotal.Expression = "ROUND(Qty * SellingPrice)"
                colSubTotal.DecimalPlaces = 0

                Dim colTotalDue As GridViewDecimalColumn = Me.GridInvItem.Columns("TotalDue")
                colTotalDue.Expression = "ROUND((Qty * SellingPrice) - ItemDiscount)"
                colTotalDue.DecimalPlaces = 0

                Dim colSalesProfitByQty As GridViewDecimalColumn = Me.GridInvItem.Columns("SalesProfitByQty")
                colSalesProfitByQty.Expression = "ROUND((SellingPrice - PurchasingPrice) * Qty)"
                colSalesProfitByQty.DecimalPlaces = 0

            Else
                Me.TxtCurrencyVal.Text = CurrencyRow("CurrencyVal").ToString
                Me.TxtCurrencyVal.Tag = CurrencyRow("LastChangeID").ToString
                If CurrencyRow("CurrFloat").ToString = "-1" Then
                    Me.TxtDiscount.Mask = "F0"
                Else
                    Me.TxtDiscount.Mask = "F" & CurrencyRow("CurrFloat").ToString
                End If

                Dim colSubTotal As GridViewDecimalColumn = Me.GridInvItem.Columns("SubTotal")
                colSubTotal.Expression = "(Qty * SellingPrice)"
                colSubTotal.DecimalPlaces = 3
                Dim colTotalDue As GridViewDecimalColumn = Me.GridInvItem.Columns("TotalDue")
                colTotalDue.Expression = "(Qty * SellingPrice) - ItemDiscount"
                colTotalDue.DecimalPlaces = 3

                Dim colSalesProfitByQty As GridViewDecimalColumn = Me.GridInvItem.Columns("SalesProfitByQty")
                colSalesProfitByQty.Expression = "(SellingPrice - PurchasingPrice) * Qty"
                colSalesProfitByQty.DecimalPlaces = 3

            End If
            ChangeAllPriceAccordingToCurreny(currentInvoiceDiscount)
            FillTotalDueBig()
        End If
    End Sub

    Private Sub CalculateProfit()
        Dim PurchasingPriceTotalDue As Decimal = 0

        If Me.GridInvItem.ChildRows.Count <> 0 And Me.DropCurrency.SelectedIndex <> -1 Then
            For i As Integer = 0 To GridInvItem.ChildRows.Count - 1
                PurchasingPriceTotalDue += Me.GridInvItem.Rows(i).Cells("PurchasingPrice").Value * Me.GridInvItem.Rows(i).Cells("Qty").Value
            Next
            If Me.DropCurrency.SelectedIndex <> -1 Then
                If Me.DropCurrency.SelectedValue.ToString = "1" Then
                    Me.TxtProfit.Text = Math.Round(Me.TxtTotalDue.Text - PurchasingPriceTotalDue, 0)
                Else
                    Me.TxtProfit.Text = Math.Round(Me.TxtTotalDue.Text - PurchasingPriceTotalDue, 3)
                End If
            End If
        Else
            Me.TxtProfit.Text = 0
        End If
    End Sub

    Private Sub ChangeAllPriceAccordingToCurreny(ByVal currentInvoiceDiscount As String)
        If Me.GridInvItem.ChildRows.Count <> 0 And Me.DropCurrency.SelectedIndex <> -1 Then
            Dim CurrencyRow As DataRow = Currencydata.Select("CurrencyID = " & Me.DropCurrency.SelectedValue).First

            For i As Integer = 0 To GridInvItem.ChildRows.Count - 1
                If Me.DropCurrency.SelectedValue.ToString = "1" Then
                    Me.GridInvItem.Rows(i).Cells("SellingPrice").Value = Math.Round(Me.GridInvItem.Rows(i).Cells("SellingPrice").Value * Me.txtDollarRate.Text, 0)
                    Me.GridInvItem.Rows(i).Cells("PurchasingPrice").Value = Math.Round(Me.GridInvItem.Rows(i).Cells("PurchasingPrice").Value * Me.txtDollarRate.Text, 0)
                    Me.GridInvItem.Rows(i).Cells("ItemDiscount").Value = Math.Round(Me.GridInvItem.Rows(i).Cells("ItemDiscount").Value * Me.txtDollarRate.Text, 0)
                    Me.TxtDiscount.Text = Math.Round(currentInvoiceDiscount * Me.txtDollarRate.Text, 0)
                Else
                    Dim currRound As Integer = CurrencyRow("CurrFloat")
                    Me.GridInvItem.Rows(i).Cells("SellingPrice").Value = Math.Round(Me.GridInvItem.Rows(i).Cells("SellingPrice").Value / Me.txtDollarRate.Text, currRound)
                    Me.GridInvItem.Rows(i).Cells("PurchasingPrice").Value = Math.Round(Me.GridInvItem.Rows(i).Cells("PurchasingPrice").Value / Me.txtDollarRate.Text, currRound)
                    Me.GridInvItem.Rows(i).Cells("ItemDiscount").Value = Math.Round(Me.GridInvItem.Rows(i).Cells("ItemDiscount").Value / Me.txtDollarRate.Text, currRound)
                    Me.TxtDiscount.Text = Math.Round(currentInvoiceDiscount / Me.txtDollarRate.Text, currRound)
                End If

            Next
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        If Me.BtnSaveAndNew.Enabled = False Then
            Dim Rptparam(1) As String
            Rptparam(0) = "InvID , " & Me.TxtInvID.Text
            Rptparam(1) = "WaterMark , " & CompanyLatinName
            OpenReport(Con.RptSalesOrder, Rptparam)
        Else
            BoolForPrint = True
            BtnSaveAndNew.PerformClick()
        End If
    End Sub

    Private Sub CustomTxtItemName_TextChanged(sender As Object, e As EventArgs) Handles CustomTxtItemName.TextChanged
        EnterPressed = "ItemName"
    End Sub
    Private Sub TxtCustomer_ToolTipTextNeeded(sender As Object, e As ToolTipTextNeededEventArgs) Handles TxtCustomer.ToolTipTextNeeded
        e.ToolTipText = CustomerTitle
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
            'DropCurerncySelectedChange()
        End If
    End Sub

    Private Sub GridInvItem_KeyDown(sender As Object, e As KeyEventArgs) Handles GridInvItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim column As GridViewDataColumn = TryCast(sender.CurrentColumn, GridViewDataColumn)
            If column.Name = "Qty" And EnterPressed = "ItemName" Then
                CustomTxtItemName.Focus()
            ElseIf column.Name = "Qty" And EnterPressed = "ItemID" Then
                TxtItemid.Focus()
            ElseIf column.Name = "Qty" And EnterPressed = "Barcode" Then
                TxtItemBarcode.Focus()
            End If
            'ElseIf e.KeyCode = Keys.F9 Then
            '    If BoolShowPurchasingPriceInScreensByUser Then
            '        HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("PurchasingPrice").Index, Not Me.GridInvItem.Columns.Item("PurchasingPrice").IsVisible)
            '        Me.GridInvItem.Columns.Item("PurchasingPrice").Width = 90
            '    End If
        End If
    End Sub

    Private Sub GridInvItem_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles GridInvItem.CellDoubleClick
        Dim column As GridViewDataColumn = TryCast(e.Column, GridViewDataColumn)
        If TypeOf e.Row Is GridViewDataRowInfo AndAlso column IsNot Nothing Then
            If column.Name = "Item_name" Then
                If BoolShowPurchasingPriceInScreensByUser Then
                    Dim purchase_price = e.Row.Cells("PurchasingPrice").Value
                    If Me.DropCurrency.SelectedValue = 1 Then
                        lblItemPurchasePriceLira.Text = purchase_price & " ل.ل"
                        lblItemPurchasePriceDollar.Text = (purchase_price / Me.txtDollarRate.Text) & " $"
                    Else
                        lblItemPurchasePriceDollar.Text = purchase_price & " $"
                        lblItemPurchasePriceLira.Text = (purchase_price * Me.txtDollarRate.Text) & " ل.ل"
                    End If
                    If Not boolTimerStarted Then
                        TimerPurchasePrice.Start()
                    End If
                End If
            ElseIf column.Name = "SubTotal" Then
                Dim formCalculateQuantity As CalculateQuantity = New CalculateQuantity
                formCalculateQuantity.ShowItemPrice(Me.GridInvItem.CurrentRow.Cells("item_name").Value, Me.GridInvItem.CurrentRow.Cells("SellingPrice").Value)
                If formCalculateQuantity.ShowDialog() = DialogResult.OK Then
                    Me.GridInvItem.CurrentRow.Cells("Qty").Value = formCalculateQuantity.CalculatedQuantity
                    Me.GridInvItem.CurrentRow.Cells("SellingPrice").Value = formCalculateQuantity.SellingPrice
                End If
            End If
        End If
    End Sub

    Private Sub TimerPurchasePrice_Tick(sender As Object, e As EventArgs) Handles TimerPurchasePrice.Tick
        Me.lblItemPurchasePriceLira.Text = ""
        Me.lblItemPurchasePriceDollar.Text = ""
        TimerPurchasePrice.Stop()
        boolTimerStarted = False
    End Sub

    Private Sub lblProfit_Click(sender As Object, e As EventArgs) Handles lblProfit.Click
        Me.TxtProfit.Visible = Not Me.TxtProfit.Visible
    End Sub

    Private Sub RadioCurrencyLebanease_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadioCurrencyLebanease.ToggleStateChanged
        FillTotalDueBig()
    End Sub

    Private Sub RadioCurrencyDollar_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadioCurrencyDollar.ToggleStateChanged
        FillTotalDueBig()
    End Sub

    Private Sub FillTotalDueBig()
        If RadioCurrencyLebanease.IsChecked Then
            Me.txtTotalDueBig.Culture = New System.Globalization.CultureInfo("ar-LB")
            If Me.DropCurrency.SelectedIndex <> -1 Then
                If Me.DropCurrency.SelectedValue.ToString = "1" Then
                    Me.txtTotalDueBig.Text = Me.TxtTotalDue.Text
                Else
                    Me.txtTotalDueBig.Text = Math.Round(Me.TxtTotalDue.Text * Val(Me.txtDollarRate.Text), 0)
                End If
            End If
        ElseIf RadioCurrencyDollar.IsChecked Then
            Me.txtTotalDueBig.Culture = New System.Globalization.CultureInfo("en-US")
            If Me.DropCurrency.SelectedIndex <> -1 Then
                If Me.DropCurrency.SelectedValue.ToString = "1" Then
                    Me.txtTotalDueBig.Text = Math.Round(Me.TxtTotalDue.Text / Me.txtDollarRate.Text, 3)
                Else
                    Me.txtTotalDueBig.Text = Me.TxtTotalDue.Text
                End If
            End If
        End If
    End Sub

    Private Sub AddNewSaleInvoice_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F9 Then
            If BoolShowPurchasingPriceInScreensByUser Then
                HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("PurchasingPrice").Index, Not Me.GridInvItem.Columns.Item("PurchasingPrice").IsVisible)
                Me.GridInvItem.Columns.Item("PurchasingPrice").Width = 90
            End If
        ElseIf e.KeyCode = Keys.F10 Then
            HideShowColummn(GridInvItem, Me.GridInvItem.Columns.Item("SalesProfitByQty").Index, Not Me.GridInvItem.Columns.Item("SalesProfitByQty").IsVisible)
            Me.GridInvItem.Columns.Item("SalesProfitByQty").Width = 90
        End If

    End Sub

    Private Sub LblCurrValue_Click(sender As Object, e As EventArgs) Handles LblCurrValue.Click
        tblCurrencyRow.Visible = Not tblCurrencyRow.Visible
    End Sub
End Class
