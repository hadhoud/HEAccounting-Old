Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.VirtualKeyboard

Public Class PriceEdit
    Dim EnterPressed As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        AutoComplete()
        FillDropList()
        FillGrid()
        FillTree()
    End Sub

    Sub AutoComplete()
        Me.CustomTxtItemName.Tag = FormPopupType.FrmGetItem
        Me.CustomTxtItemName.AutoCompleteDataSource = ItemsNameAuto
        Me.CustomTxtItemName.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub FillDropList()
        'Me.DropCurrency.ValueMember = "CurrencyID"
        'Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        'Me.DropCurrency.DataSource = Currencydata
        'Initiatedropdownlist(Me.DropCurrency)
        'Me.DropCurrency.SelectedValue = ProgramFormCurrency
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
            .[ReadOnly] = True,
            .Minimum = 0
        }

        Dim PurchasingPriceAfter As New GridViewDecimalColumn With
        {
            .Name = "PurchasingPriceAfter",
            .FieldName = "PurchasingPriceAfter",
            .Width = 60,
            .[ReadOnly] = True
        }

        Dim SellingPriceAfter As New GridViewDecimalColumn With
        {
            .Name = "SellingPriceAfter",  'سعر البيع
            .FieldName = "SellingPriceAfter",
            .[ReadOnly] = True,
            .Minimum = 0
        }

        Dim CurrencyID As New GridViewTextBoxColumn With
        {
            .Name = "CurrencyID",
            .FieldName = "CurrencyID",
            .[ReadOnly] = True
        }

        Dim DeleteColumn As New GridViewCommandColumn With {
            .Name = "Delete",
            .Image = My.Resources._Erase,
            .ImageAlignment = ContentAlignment.MiddleCenter,
            .AutoEllipsis = True,
            .Width = 15
        }

        Me.GridItemsGroups.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridItemsGroups.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom

        Me.GridItemsGroups.MasterTemplate.Columns.Add(ItemID)
        Me.GridItemsGroups.MasterTemplate.Columns.Add(ItemName)
        Me.GridItemsGroups.MasterTemplate.Columns.Add(PurchasingPrice)
        Me.GridItemsGroups.MasterTemplate.Columns.Add(PurchasingPriceAfter)
        Me.GridItemsGroups.MasterTemplate.Columns.Add(SellingPrice)
        Me.GridItemsGroups.MasterTemplate.Columns.Add(SellingPriceAfter)
        Me.GridItemsGroups.MasterTemplate.Columns.Add(CurrencyID)
        Me.GridItemsGroups.MasterTemplate.Columns.Add(DeleteColumn)

        'AddHandler GridItemsGroups.CommandCellClick, AddressOf DeleteItem

        InitiateGrid(Me.GridItemsGroups, Editing:=True)
        HideShowColummn(GridItemsGroups, Me.GridItemsGroups.Columns.Item("CurrencyID").Index, False)

    End Sub

    Private Sub GridItemsGroups_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles GridItemsGroups.CommandCellClick
        If (e.ColumnIndex = Me.GridItemsGroups.Columns.Item("Delete").Index) Then
            DeleteItem()
        End If
    End Sub
    Private Sub DeleteItem()
        If GridItemsGroups.Rows.Count > 0 Then
            Me.GridItemsGroups.CurrentRow.Delete()
        End If
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        Me.Text = LoStrId.LblItems
    End Sub
    Public Sub FillTree()
        FillTreeProcedure(Me.TreeGroups, "SelectGroups")
        Dim itemNodeAll As New RadTreeNode With
        {
         .Text = Con.Lbl_All,
        .Value = "90909090",
        .Name = "N1"
         }
        Dim itemNodeNotInGroup As New RadTreeNode With
        {
         .Text = Con.Lbl_NotInGroups,
         .Value = "90909091",
         .Name = "N2"
        }
        'For Each Nd In TreeGroups.Nodes
        '    Nd.Tag = Nd.Value
        'Next
        Me.TreeGroups.Nodes.Insert(0, itemNodeAll)
        Me.TreeGroups.Nodes.Insert(1, itemNodeNotInGroup)
        Me.TreeGroups.TopNode.Selected = True
        'RefrechGrid()
        'InitiateGrid(Me.GridItemsGroups, Grouping:=False)
        '  HideShowColummn(Me.GridItems, 1, False)
    End Sub
    Private Sub CustomTxtItemName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CustomTxtItemName.Validating
        If Not ItemsNameAuto.Contains(Me.CustomTxtItemName.Text.ToLower) Then
            Me.CustomTxtItemName.Text = String.Empty
        End If
    End Sub

    Private Sub CustomTxtItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomTxtItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "ItemName"
            btnAdd.PerformClick()
        End If
    End Sub

    Private Sub TxtItemid_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemid.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "ItemID"
            btnAdd.PerformClick()
        End If
    End Sub

    Private Sub TxtItemBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "Barcode"
            btnAdd.PerformClick()
            Me.TxtItemBarcode.Focus()
        End If
    End Sub

    Private Sub TxtGroupSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtGroupSearch.TextChanged
        Me.TreeGroups.FilterDescriptors.Clear()
        Dim filter As New FilterDescriptor With {
            .PropertyName = "GroupName",
            .Operator = FilterOperator.Contains,
            .Value = Me.TxtGroupSearch.Text
        }
        Me.TreeGroups.FilterDescriptors.Add(filter)
        If Me.TxtGroupSearch.Text.Length = 0 Then
            Me.TreeGroups.Nodes.Move(Me.TreeGroups.Nodes(Con.Lbl_All).Index, 0)
            Me.TreeGroups.Nodes.Move(Me.TreeGroups.Nodes(Con.Lbl_NotInGroups).Index, 1)
        End If
    End Sub

    Private Sub TxtItems_TextChanged(sender As Object, e As EventArgs)
        Me.GridItemsGroups.FilterDescriptors.Clear()
        '  FilterGrid(Me.GridItemsGroups, "Item_name", Me.TxtItems.Text, FilterOperator.Contains)
    End Sub

    Private Sub TreeGroups_NodeMouseClick(sender As Object, e As RadTreeViewEventArgs) Handles TreeGroups.NodeMouseDoubleClick
        AddItemsFromGroup()
    End Sub

    Public Sub AddItemsFromGroup()
        Dim Param(0) As String
        Param(0) = "@IGroupID , " & Me.TreeGroups.SelectedNode.Value
        AddMultiItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsByGroupsForEditPrices", Param))
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not (Me.CustomTxtItemName.Text.Length = 0 And Me.TxtItemid.Text.Length = 0 And Me.TxtItemBarcode.Text.Length = 0) Then
            'ADD
            If EnterPressed = "ItemName" And Me.CustomTxtItemName.Text.Trim <> String.Empty Then
                Dim Param(1) As String
                Param(0) = "@CBy , Name"
                Param(1) = "@CItemName , " & Evalquote(Me.CustomTxtItemName.Text)
                AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsForEditPrices", Param))
                Me.CustomTxtItemName.Text = ""

            ElseIf EnterPressed = "ItemID" And Me.TxtItemid.Text.Trim <> String.Empty Then
                Dim Param(1) As String
                Param(0) = "@CBy , ID"
                Param(1) = "@IItemID , " & Me.TxtItemid.Text
                AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsForEditPrices", Param))
                Me.TxtItemid.Text = ""

            ElseIf EnterPressed = "Barcode" And Me.TxtItemBarcode.Text.Trim <> String.Empty Then
                Dim Param(1) As String
                Param(0) = "@CBy , Barcode"
                Param(1) = "@CBarcode , " & Evalquote(Me.TxtItemBarcode.Text)
                AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsForEditPrices", Param))
                Me.TxtItemBarcode.Text = ""
            End If
        End If
    End Sub

    Public Sub AddItemToGrid(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            For Each row In GridItemsGroups.Rows
                If row.Cells("Item_id").Value.ToString = dt.Rows(0).Item("Item_id").ToString Then
                    MessageShowInfo(Con.Msg_Item_Has_Been_Added)
                    Me.GridItemsGroups.Rows.Item(row.Index).IsCurrent = True
                    Exit Sub
                End If
            Next
            Dim rowInfo As New GridViewDataRowInfo(Me.GridItemsGroups.MasterView)
            rowInfo.Cells("Item_id").Value = dt.Rows(0).Item("Item_id").ToString
            rowInfo.Cells("Item_name").Value = dt.Rows(0).Item("Item_name").ToString
            rowInfo.Cells("PurchasingPrice").Value = dt.Rows(0).Item("PurchasingPrice").ToString
            rowInfo.Cells("SellingPrice").Value = dt.Rows(0).Item("SellingPrice").ToString
            rowInfo.Cells("CurrencyID").Value = dt.Rows(0).Item("CurrencyID").ToString
            GridItemsGroups.Rows.Add(rowInfo)
            Me.GridItemsGroups.Columns("Item_name").BestFit()

            Me.GridItemsGroups.Rows.Last.IsCurrent = True
            If EnterPressed = "ItemName" Then
                Me.CustomTxtItemName.Focus()
            ElseIf EnterPressed = "ItemID" Then
                Me.TxtItemid.Focus()
            ElseIf EnterPressed = "Barcode" Then
                Me.TxtItemBarcode.Focus()
            End If
        Else
            MessageShowInfo(Con.Msg_Item_Not_Found)
        End If

    End Sub

    Public Sub AddMultiItemToGrid(ByVal dt_items As DataTable)
        Dim item_count As Integer = 0
        Dim item_already_added As Boolean = False

        If dt_items.Rows.Count > 0 Then
            For Each item In dt_items.Rows
                item_already_added = False
                For Each row In GridItemsGroups.Rows
                    If row.Cells("Item_id").Value.ToString = dt_items.Rows(item_count).Item("Item_id").ToString Then
                        item_already_added = True
                        Exit For
                    End If
                Next
                If Not item_already_added Then
                    Dim rowInfo As New GridViewDataRowInfo(Me.GridItemsGroups.MasterView)
                    rowInfo.Cells("Item_id").Value = dt_items.Rows(item_count).Item("Item_id").ToString
                    rowInfo.Cells("Item_name").Value = dt_items.Rows(item_count).Item("Item_name").ToString
                    rowInfo.Cells("PurchasingPrice").Value = dt_items.Rows(item_count).Item("PurchasingPrice").ToString
                    rowInfo.Cells("SellingPrice").Value = dt_items.Rows(item_count).Item("SellingPrice").ToString
                    rowInfo.Cells("CurrencyID").Value = dt_items.Rows(item_count).Item("CurrencyID").ToString
                    GridItemsGroups.Rows.Add(rowInfo)
                    Me.GridItemsGroups.Columns("Item_name").BestFit()
                    'Checkdata(rowInfo)
                    Me.GridItemsGroups.Rows.Last.IsCurrent = True
                    GridItemsGroups.Focus()
                End If
                item_count = item_count + 1
            Next
        Else
            MessageShowInfo(Con.Msg_Item_Not_Found)
        End If

    End Sub

    Private Sub GridItemsGroups_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridItemsGroups.ViewCellFormatting, GridItemsGroups.CellFormatting
        If (e.CellElement.RowInfo.Group Is Nothing And TypeOf e.CellElement Is GridSummaryCellElement) Then
            e.CellElement.ForeColor = Color.Blue
            e.CellElement.RowElement.DrawFill = True
            e.CellElement.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.RowElement.BackColor = Color.FromArgb(239, 246, 255)
        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
            e.CellElement.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            If e.Column.Name = "PurchasingPrice" Or e.Column.Name = "SellingPrice" Or e.Column.Name = "SellingPriceAfter" _
                Or e.Column.Name = "PurchasingPriceAfter" Then
                e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, IIf(e.Row.Cells("CurrencyID").Value.ToString() = "", Currency.noCurrency, e.Row.Cells("CurrencyID").Value), False)
            End If
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If CheckEditPrice() Then
            For Each row In GridItemsGroups.Rows
                row.Cells("SellingPriceAfter").Value = row.Cells("SellingPrice").Value
                row.Cells("PurchasingPriceAfter").Value = row.Cells("PurchasingPrice").Value
                If radioEditPercentage.IsChecked Then
                    If chkEditPurchasingPrice.Checked Then
                        row.Cells("PurchasingPriceAfter").Value = row.Cells("PurchasingPrice").Value + (row.Cells("PurchasingPrice").Value * (MskTextAmountPercent.Value / 100))
                    End If

                    If chkEditSellingPrice.Checked Then
                        row.Cells("SellingPriceAfter").Value = row.Cells("SellingPrice").Value + (row.Cells("SellingPrice").Value * (MskTextAmountPercent.Value / 100))
                    End If

                ElseIf radioEditAmount.IsChecked Then
                    If chkEditPurchasingPrice.Checked Then
                        row.Cells("PurchasingPriceAfter").Value = row.Cells("PurchasingPrice").Value + MskTextAmountPercent.Value
                    End If

                    If chkEditSellingPrice.Checked Then
                        row.Cells("SellingPriceAfter").Value = row.Cells("SellingPrice").Value + MskTextAmountPercent.Value
                    End If
                End If
            Next
        End If
    End Sub


    Public Function CheckEditPrice() As Boolean
        If (chkEditPurchasingPrice.Checked Or chkEditSellingPrice.Checked) And Val(MskTextAmountPercent.Text) <> 0 _
            And GridItemsGroups.Rows.Count > 0 Then
            CheckEditPrice = True
        Else
            CheckEditPrice = False
        End If

    End Function

    Private Sub BtnEditPrice_Click(sender As Object, e As EventArgs) Handles BtnEditPrice.Click
        If CheckEditPrice() Then
            btnCalculate.PerformClick()
            If MessageShowAsk(Con.Ask_Edit) = DialogResult.Yes Then
                For Each row In GridItemsGroups.Rows
                    Dim Param(6) As String
                    Param(0) = "@iItemID , " & row.Cells("Item_id").Value
                    Param(1) = "@fPurchasingPrice , " & row.Cells("PurchasingPrice").Value
                    Param(2) = "@fNewPurchasingPrice , " & row.Cells("PurchasingPriceAfter").Value
                    Param(3) = "@fSellingPrice , " & row.Cells("SellingPrice").Value
                    Param(4) = "@fNewSellingPrice , " & row.Cells("SellingPriceAfter").Value
                    Param(5) = "iCurrencyID , " & row.Cells("CurrencyID").Value
                    Param(6) = "@iUserID  , " & UserID
                    ExecuteProcedureWithParameters("UpdateItemPrice", Param)
                Next
                GridItemsGroups.Rows.Clear()
            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub
End Class