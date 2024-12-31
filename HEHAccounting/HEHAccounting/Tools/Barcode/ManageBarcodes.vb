
Imports Telerik.Reporting
Imports Telerik.Reporting.Barcode
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Barcode
Imports Telerik.WinControls.VirtualKeyboard

Public Class ManageBarcodes

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

    Sub AutoComplete()
        Me.CustomTxtItemName.Tag = FormPopupType.FrmGetItemNoBarcode
        Me.CustomTxtItemName.AutoCompleteDataSource = ItemsNameAuto
        Me.CustomTxtItemName.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub FillDropList()
        Dim item As New RadListDataItem With {
            .Text = Con.Lbl_UPCA,
            .Value = SymbologyType.UPCA
        }
        Me.DropBarcodeType.Items.Add(item)

        item = New RadListDataItem With {
             .Text = Con.Lbl_UPCE,
            .Value = SymbologyType.UPCE
        }
        Me.DropBarcodeType.Items.Add(item)

        Initiatedropdownlist(Me.DropBarcodeType, False)
        Me.DropBarcodeType.SelectedValue = SymbologyType.UPCA
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

        Me.GridItems.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridItems.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom

        Me.GridItems.MasterTemplate.Columns.Add(ItemID)
        Me.GridItems.MasterTemplate.Columns.Add(ItemName)
        Me.GridItems.MasterTemplate.Columns.Add(ItemBarcode)
        Me.GridItems.MasterTemplate.Columns.Add(SellingPrice)
        Me.GridItems.MasterTemplate.Columns.Add(RefreshPriceColumn)
        Me.GridItems.MasterTemplate.Columns.Add(AvailableQty)
        Me.GridItems.MasterTemplate.Columns.Add(QuantityCol)
        Me.GridItems.MasterTemplate.Columns.Add(DeleteColumn)
        Me.GridItems.MasterTemplate.Columns.Add(CurrencySymbol)
        InitiateGrid(Me.GridItems, Editing:=True)
    End Sub


    Private Sub ManageBarcodes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoComplete()
        Me.TxtBarCodeStartNumber.Value = BarcodeInitialStartingNumber
        Me.TxtBarCodeStartNumber.Text = BarcodeInitialStartingNumber
    End Sub

    Private Sub BtnClearGrid_Click(sender As Object, e As EventArgs) Handles BtnClearGrid.Click
        If GridItems.Rows.Count > 0 Then
            GridItems.Rows.Clear()
        End If
    End Sub

    Private Sub BtnImportItemsWithoutBarCode_Click(sender As Object, e As EventArgs) Handles BtnImportItemsWithoutBarCode.Click

        'Get All items without barcodes
        BtnClearGrid.PerformClick()
        Dim dt_items_without_barcode As New DataTable
        dt_items_without_barcode = ExecuteProcedureDatatable("GetItemsWithNoBarcode")
        If dt_items_without_barcode.Rows.Count > 0 Then
            For Each row In dt_items_without_barcode.Rows
                Dim rowInfo As New GridViewDataRowInfo(Me.GridItems.MasterView)
                rowInfo.Cells("Item_id").Value = row.Item("Item_id").ToString
                rowInfo.Cells("Item_name").Value = row.Item("Item_name").ToString
                rowInfo.Cells("Barcode").Value = row.Item("Barcode").ToString
                rowInfo.Cells("SellingPrice").Value = row.Item("SellingPrice").ToString
                rowInfo.Cells("AvailableQty").Value = row.Item("Qty").ToString
                rowInfo.Cells("Barcode_Qty").Value = IIf(row.Item("Qty") <= 0, 1, row.Item("Qty"))
                rowInfo.Cells("Currency_symb").Value = row.Item("Currency_symb").ToString
                GridItems.Rows.Add(rowInfo)
            Next
        End If

        InitiateGrid(Me.GridItems, Editing:=True)

    End Sub

    Private Sub BtnRefreshBarcodeProp_Click(sender As Object, e As EventArgs) Handles BtnRefreshBarcodeProp.Click
        'refresh barcode viewer
        If showBarcodeView() Then
            fillBarcodeInGrid()
        End If
    End Sub

    Private Sub CustomTxtItemName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CustomTxtItemName.Validating
        If Not ItemsNameAuto.Contains(Me.CustomTxtItemName.Text.ToLower) Then
            Me.CustomTxtItemName.Text = String.Empty
        End If
    End Sub

    Private Sub CustomTxtItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomTxtItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not (Me.CustomTxtItemName.Text.Length = 0) Then
                'ADD
                If Me.CustomTxtItemName.Text.Trim <> String.Empty Then
                    Dim Param(0) As String
                    Param(0) = "@CItemName , " & Evalquote(Me.CustomTxtItemName.Text)
                    AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectNoBarcodeItemForDesignBarcode", Param))
                    Me.CustomTxtItemName.Text = ""
                End If
            End If
        End If
    End Sub

    Public Sub AddItemToGrid(ByVal dt As DataTable)

        If dt.Rows.Count > 0 Then
            For Each row In GridItems.Rows
                If row.Cells("Item_id").Value.ToString = dt.Rows(0).Item("Item_id").ToString Then
                    MessageShowInfo(Con.Msg_Item_Has_Been_Added)
                    Exit Sub
                End If
            Next
            Dim rowInfo As New GridViewDataRowInfo(Me.GridItems.MasterView)
            rowInfo.Cells("Item_id").Value = dt.Rows(0).Item("Item_id").ToString
            rowInfo.Cells("Item_name").Value = dt.Rows(0).Item("Item_name").ToString
            rowInfo.Cells("Barcode").Value = dt.Rows(0).Item("Barcode").ToString
            rowInfo.Cells("SellingPrice").Value = dt.Rows(0).Item("SellingPrice").ToString
            rowInfo.Cells("AvailableQty").Value = dt.Rows(0).Item("Qty").ToString
            rowInfo.Cells("Barcode_Qty").Value = IIf(dt.Rows(0).Item("Qty") <= 0, 1, dt.Rows(0).Item("Qty"))
            rowInfo.Cells("Currency_symb").Value = dt.Rows(0).Item("Currency_symb").ToString
            GridItems.Rows.Add(rowInfo)
            Me.GridItems.Columns("Item_name").BestFit()
            Me.GridItems.Rows.Last.IsCurrent = True
            Me.GridItems.Columns("Barcode_Qty").IsCurrent = True
            GridItems.Focus()
        Else
            MessageShowInfo(Con.Msg_Item_Not_Found)
        End If

    End Sub

    Private Function showBarcodeView()
        If Me.DropBarcodeType.SelectedValue = SymbologyType.UPCA And Me.TxtBarCodeStartNumber.Text.Length <> 11 Then
            MessageShowInfo(Con.Msg_UPCA_Type_Allow_11_Number)
            Return False
        ElseIf Me.DropBarcodeType.SelectedValue = SymbologyType.UPCE And Me.TxtBarCodeStartNumber.Text.Length <> 13 Then
            MessageShowInfo(Con.Msg_UPCE_Type_Allow_13_Number)
            Return False
        End If

        Select Case Me.DropBarcodeType.SelectedValue
            Case SymbologyType.UPCA
                Dim Upca_type As New UPCA With {
                    .CodeTextSpacing = 0R,
                    .TextAlign = StringAlignment.Far,
                    .LineAlign = StringAlignment.Far,
                    .SizingMode = Telerik.WinControls.UI.Barcode.SizingMode.Snap,
                    .ShowText = True,
                    .AutoChecksum = True
                }
                Me.BarcodeItemView.Symbology = Upca_type
                Me.BarcodeItemView.Value = TxtBarCodeStartNumber.Text
            Case SymbologyType.UPCE
                Dim Upce_type As UPCE = New UPCE With {
                    .CodeTextSpacing = 0R,
                    .TextAlign = StringAlignment.Far,
                    .LineAlign = StringAlignment.Far,
                    .SizingMode = Telerik.WinControls.UI.Barcode.SizingMode.Snap,
                    .ShowText = True,
                    .AutoChecksum = True
                }
                Me.BarcodeItemView.Symbology = Upce_type
                Me.BarcodeItemView.Value = TxtBarCodeStartNumber.Text
        End Select
        Return True
    End Function

    Private Shared Charset As IList(Of Char)

    Private Shared Function GetChecksum(value As String, first As Integer, second As Integer, modulo As Integer) As Char
        Charset = New List(Of Char) From {"0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c}
        Dim num As Integer = 0
        Dim num2 As Integer = first

        For num3 As Integer = value.Length - 1 To 0 Step -1
            Dim num4 As Integer = Charset.IndexOf(value(num3))
            num += num4 * num2
            num2 = If(num2 <> first, first, second)
        Next

        num = num Mod modulo
        If num <> 0 Then
            num = modulo - num
        End If

        Return Charset(num)
    End Function

    Private Sub fillBarcodeInGrid()
        If GridItems.Rows.Count > 0 Then
            For Each row In GridItems.Rows
                row.Cells("Barcode").Value = (Me.TxtBarCodeStartNumber.Value + 1) & GetChecksum(Me.TxtBarCodeStartNumber.Value + 1, 3, 1, 10)
                Me.TxtBarCodeStartNumber.Value = Me.TxtBarCodeStartNumber.Value + 1
            Next
        End If
        showBarcodeView()
    End Sub

    Private Sub GridItems_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles GridItems.CommandCellClick
        If (e.ColumnIndex = Me.GridItems.Columns.Item("Delete").Index) Then

            DeleteItem()
        End If
    End Sub

    Private Sub GridInvItem_CellEditorInitialized(sender As Object, e As GridViewCellEventArgs) Handles GridItems.CellEditorInitialized
        Dim spinEditor As GridSpinEditor = TryCast(Me.GridItems.ActiveEditor, GridSpinEditor)
        If spinEditor IsNot Nothing Then
            Dim element As RadSpinEditorElement = spinEditor.EditorElement
            element.ShowUpDownButtons = False
            element.TextAlignment = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub DeleteItem()
        If GridItems.Rows.Count > 0 Then
            Me.GridItems.CurrentRow.Delete()
        End If
    End Sub

    Private Sub BtnResetBarcodeProp_Click(sender As Object, e As EventArgs) Handles BtnResetBarcodeProp.Click
        If GridItems.Rows.Count > 0 Then
            For Each row In GridItems.Rows
                row.Cells("Barcode").Value = ""
            Next
        End If
        Me.TxtBarCodeStartNumber.Value = BarcodeInitialStartingNumber
        showBarcodeView()
    End Sub

    Private Sub BtnPrintBarcodeFormtec1056_Click(sender As Object, e As EventArgs) Handles BtnPrintBarcodeFormtec1056.Click

        'delete old items from draft tables 
        ExecuteQuerySQL("DELETE  FROM Draft_Barcode_Items")
        'insert all item into draft tables 
        saveItemIntoDraftTable()

        'print 
        Dim Rptparam(3) As String
        Rptparam(0) = "ShowCompanyName , " & Me.ChkShowCompanyName.Checked
        Rptparam(1) = "CompanyName , " & CompanyLatinName
        Rptparam(2) = "ShowItemCode , " & Me.ChkShowItemCode.Checked
        Rptparam(3) = "ShowItemPrice , " & Me.ChkShowItemPrice.Checked
        OpenReport(Con.RptBarcodeFormtecA4_1056, Rptparam)
    End Sub

    Private Sub saveItemIntoDraftTable()
        If GridItems.Rows.Count > 0 Then
            Dim Param(6) As String
            For Each row In GridItems.Rows
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

    Private Sub BtnSaveBarcodes_Click(sender As Object, e As EventArgs) Handles BtnSaveBarcodes.Click
        If GridItems.Rows.Count > 0 Then
            If MessageShowAsk(Con.Ask_Edit) = DialogResult.Yes Then
                Dim Param(2) As String
                For Each row In GridItems.Rows
                    If row.Cells("Barcode").Value.ToString() <> "" Then
                        Param(0) = "@IItemID  , " & row.Cells("Item_id").Value.ToString()
                        Param(1) = "@CBarcode , " & row.Cells("Barcode").Value.ToString()
                        Param(2) = "@IUserID  , " & UserID
                        ExecuteProcedureWithParameters("UpdateItemBarcode", Param)
                    End If
                Next
                ExecuteQuerySQL("UPDATE AppSettings SET BarcodeInitialNumber = '" & Me.TxtBarCodeStartNumber.Value & "'")
                GridItems.Rows.Clear()
            End If
        End If
    End Sub

    Private Sub lblBarcodeStartingNumber_Click(sender As Object, e As EventArgs) Handles lblBarcodeStartingNumber.Click
        If (Control.ModifierKeys = System.Windows.Forms.Keys.Control) Then
            lblBarcodeStartingNumCickCount = lblBarcodeStartingNumCickCount + 1
            If lblBarcodeStartingNumCickCount = 3 Then
                Me.TxtBarCodeStartNumber.Enabled = True
                lblBarcodeStartingNumCickCount = 0
            Else
                Me.TxtBarCodeStartNumber.Enabled = False
            End If
        End If
    End Sub
End Class
