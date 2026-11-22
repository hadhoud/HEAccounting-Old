
Imports Telerik.Reporting
Imports Telerik.Reporting.Barcode
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Barcode
Imports Telerik.WinControls.VirtualKeyboard

Public Class ManageExcelReports

    Public lblBarcodeStartingNumCickCount As Integer = 0
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If

        FillGrid()

        FillDropList()
        ShowPermissions()
    End Sub

    Sub ShowPermissions()
        'Dim NRRow As DataRow = UserRolesdt.Select("KeyName = 'NR'").First
        'Dim NPRow As DataRow = UserRolesdt.Select("KeyName = 'NP'").First
        'Me.BtnDelete.Enabled = NRRow("AllowDelete") Or NPRow("AllowDelete")
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.LblSalesOrders
        Me.LblInvID.Text = LoStrId.LblNum
        Me.BtnEdit.Text = LoStrId.LblEdit
        Me.BtnClearGrid.Text = LoStrId.LblReset
        Me.BtnPrint.Text = LoStrId.LblPrint
    End Sub

    Private Sub FillDropList()

        Me.DropReportType.ValueMember = IIf(BoolLTRLanguage = True, "ENReportName", "ArReportName")
        Me.DropReportType.DisplayMember = IIf(BoolLTRLanguage = True, "ENReportName", "ArReportName")
        Me.DropReportType.DataSource = ExecuteProcedureDatatable("GetGeneralExcelReportsName")
        Initiatedropdownlist(Me.DropReportType)
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

        Dim ItemBarcode As New GridViewTextBoxColumn With
        {
            .Name = "Barcode",
            .FieldName = "Barcode",
            .Width = 150,
            .[ReadOnly] = True,
            .MinWidth = 150
        }

        Dim SellingPrice As New GridViewDecimalColumn With
        {
            .Name = "SellingPrice",  'سعر البيع
            .FieldName = "SellingPrice",
            .[ReadOnly] = True,
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
            .Name = "Barcode_Qty",
            .DecimalPlaces = 0,
            .Minimum = 0,
            .Width = 80
        }


        Dim DeleteColumn As New GridViewCommandColumn With {
            .Name = "Delete",
            .Image = My.Resources._Erase,
            .ImageAlignment = ContentAlignment.MiddleCenter,
            .AutoEllipsis = True,
            .Width = 35,
            .AllowResize = False,
            .MaxWidth = 35,
            .MinWidth = 35
        }

        'Currency_symb
        Dim CurrencySymbol As New GridViewTextBoxColumn With
        {
            .Name = "Currency_symb",
            .FieldName = "Currency_symb",
            .Width = 100,
            .[ReadOnly] = True,
            .IsVisible = False
        }

        Me.GridFiledsExcelCells.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridFiledsExcelCells.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom

        Me.GridFiledsExcelCells.MasterTemplate.Columns.Add(ItemID)
        Me.GridFiledsExcelCells.MasterTemplate.Columns.Add(ItemName)
        Me.GridFiledsExcelCells.MasterTemplate.Columns.Add(ItemBarcode)
        Me.GridFiledsExcelCells.MasterTemplate.Columns.Add(SellingPrice)
        Me.GridFiledsExcelCells.MasterTemplate.Columns.Add(RefreshPriceColumn)
        Me.GridFiledsExcelCells.MasterTemplate.Columns.Add(AvailableQty)
        Me.GridFiledsExcelCells.MasterTemplate.Columns.Add(QuantityCol)
        Me.GridFiledsExcelCells.MasterTemplate.Columns.Add(DeleteColumn)
        Me.GridFiledsExcelCells.MasterTemplate.Columns.Add(CurrencySymbol)
        InitiateGrid(Me.GridFiledsExcelCells, Editing:=True)
    End Sub

    Private Sub BtnClearGrid_Click(sender As Object, e As EventArgs) Handles BtnClearGrid.Click
        If GridFiledsExcelCells.Rows.Count > 0 Then
            GridFiledsExcelCells.Rows.Clear()
        End If
    End Sub

    Private Sub BtnImportItemsWithoutBarCode_Click(sender As Object, e As EventArgs)

        'Get All items without barcodes
        BtnClearGrid.PerformClick()
        Dim dt_items_without_barcode As New DataTable
        dt_items_without_barcode = ExecuteProcedureDatatable("GetItemsWithNoBarcode")
        If dt_items_without_barcode.Rows.Count > 0 Then
            For Each row In dt_items_without_barcode.Rows
                Dim rowInfo As New GridViewDataRowInfo(Me.GridFiledsExcelCells.MasterView)
                rowInfo.Cells("Item_id").Value = row.Item("Item_id").ToString
                rowInfo.Cells("Item_name").Value = row.Item("Item_name").ToString
                rowInfo.Cells("Barcode").Value = row.Item("Barcode").ToString
                rowInfo.Cells("SellingPrice").Value = row.Item("SellingPrice").ToString
                rowInfo.Cells("AvailableQty").Value = row.Item("Qty").ToString
                rowInfo.Cells("Barcode_Qty").Value = IIf(row.Item("Qty") <= 0, 1, row.Item("Qty"))
                rowInfo.Cells("Currency_symb").Value = row.Item("Currency_symb").ToString
                GridFiledsExcelCells.Rows.Add(rowInfo)
            Next
        End If

        InitiateGrid(Me.GridFiledsExcelCells, Editing:=True)

    End Sub

    Public Sub AddItemToGrid(ByVal dt As DataTable)

        If dt.Rows.Count > 0 Then
            For Each row In GridFiledsExcelCells.Rows
                If row.Cells("Item_id").Value.ToString = dt.Rows(0).Item("Item_id").ToString Then
                    MessageShowInfo(Con.Msg_Item_Has_Been_Added)
                    Exit Sub
                End If
            Next
            Dim rowInfo As New GridViewDataRowInfo(Me.GridFiledsExcelCells.MasterView)
            rowInfo.Cells("Item_id").Value = dt.Rows(0).Item("Item_id").ToString
            rowInfo.Cells("Item_name").Value = dt.Rows(0).Item("Item_name").ToString
            rowInfo.Cells("Barcode").Value = dt.Rows(0).Item("Barcode").ToString
            rowInfo.Cells("SellingPrice").Value = dt.Rows(0).Item("SellingPrice").ToString
            rowInfo.Cells("AvailableQty").Value = dt.Rows(0).Item("Qty").ToString
            rowInfo.Cells("Barcode_Qty").Value = IIf(dt.Rows(0).Item("Qty") <= 0, 1, dt.Rows(0).Item("Qty"))
            rowInfo.Cells("Currency_symb").Value = dt.Rows(0).Item("Currency_symb").ToString
            GridFiledsExcelCells.Rows.Add(rowInfo)
            Me.GridFiledsExcelCells.Columns("Item_name").BestFit()
            Me.GridFiledsExcelCells.Rows.Last.IsCurrent = True
            Me.GridFiledsExcelCells.Columns("Barcode_Qty").IsCurrent = True
            GridFiledsExcelCells.Focus()
        Else
            MessageShowInfo(Con.Msg_Item_Not_Found)
        End If

    End Sub

    Private Sub GridItems_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles GridFiledsExcelCells.CommandCellClick
        If (e.ColumnIndex = Me.GridFiledsExcelCells.Columns.Item("Delete").Index) Then

            DeleteItem()
        End If
    End Sub

    Private Sub GridInvItem_CellEditorInitialized(sender As Object, e As GridViewCellEventArgs) Handles GridFiledsExcelCells.CellEditorInitialized
        Dim spinEditor As GridSpinEditor = TryCast(Me.GridFiledsExcelCells.ActiveEditor, GridSpinEditor)
        If spinEditor IsNot Nothing Then
            Dim element As RadSpinEditorElement = spinEditor.EditorElement
            element.ShowUpDownButtons = False
            element.TextAlignment = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub DeleteItem()
        If GridFiledsExcelCells.Rows.Count > 0 Then
            Me.GridFiledsExcelCells.CurrentRow.Delete()
        End If
    End Sub

    Private Sub saveItemIntoDraftTable()
        If GridFiledsExcelCells.Rows.Count > 0 Then
            Dim Param(6) As String
            For Each row In GridFiledsExcelCells.Rows
                Dim count_barcode As Integer = row.Cells("Barcode_Qty").Value
                Dim i As Integer = 0
                For i = 0 To count_barcode - 1
                    Param(0) = "@IItemID  , " & row.Cells("Item_id").Value.ToString()
                    Param(1) = "@CItemName , " & row.Cells("Item_name").Value.ToString()
                    Param(2) = "@FSellingPrice , " & row.Cells("SellingPrice").Value.ToString()
                    Param(3) = "@CCurrency_symb , " & row.Cells("Currency_symb").Value.ToString()
                    Param(4) = "@IBarcode_Qty , " & row.Cells("Barcode_Qty").Value.ToString()
                    Param(5) = "@CBarcode , " & row.Cells("Barcode").Value.ToString()
                    Param(6) = "@IUserID  , " & UserID
                    ExecuteProcedureWithParameters("InsertDraftBarcodeItem", Param)
                Next i
            Next
        End If
    End Sub
End Class
