Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class AllInventory
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        '  AddLinkColumn()
        Me.GridInventory.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridInventory.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom
        InitiateGrid(Me.GridInventory, Grouping:=True)
        InitiateDatePicker()
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
        Me.LblFrom.Text = LoStrId.LblFrom
        Me.LblTo.Text = LoStrId.LblTo
        Me.BtnNew.Text = LoStrId.LblNew
        Me.BtnEdit.Text = LoStrId.LblEdit
        Me.BtnDelete.Text = LoStrId.LblDelete
        Me.BtnReset.Text = LoStrId.LblReset
        Me.BtnFiltering.Text = LoStrId.LblFiltering
        Me.BtnPrint.Text = LoStrId.LblPrint
    End Sub

    Private Sub InitiateDatePicker()
        InitiateDateTimePicker(MskTxtInvDateFrom, DateSerial(2020, 1, 1), True, False)
        InitiateDateTimePicker(MskTxtInvDateTo, DateSerial(2020, 1, 1), True, False)
    End Sub

    Public Sub RefrechGrid()

        FillGridViewProcedure(Me.GridInventory, "SelectAllInventory")
        'HideShowColummn(Me.GridInventory, Me.GridInventory.Columns("InvoiceCurrencySymb").Index, BoolShowSalesOrdersColCurrencySymb)

        'FilterGrid(Me.GridInventory, "DueDate", DateSerial(Year(Date.Now), Month(Date.Now), DateAndTime.Day(Date.Now)), FilterOperator.IsEqualTo)
    End Sub

    Private Sub FillDropList()

    End Sub

    Private Sub AddLinkColumn()
        'Dim column As New GridViewHyperlinkColumn With {
        '    .HyperlinkOpenAction = HyperlinkOpenAction.SingleClick,
        '    .FieldName = "InvID",
        '    .Name = "HyperInvID"
        '}
        'Me.GridInventory.Columns.Insert(0, column)
    End Sub

    Sub AutoComplete()

    End Sub

    Private Sub AllInventoryFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoComplete()
        Me.MskTxtInvDateFrom.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now), DateAndTime.Day(Date.Now))
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        Me.GridInventory.FilterDescriptors.Clear()

        FilterGrid(Me.GridInventory, "InventoryID", Me.TxtInvID.Text.Trim, FilterOperator.Contains)

        If MskTxtInvDateFrom.Checked Then
            FilterGrid(Me.GridInventory, "DueDate", Me.MskTxtInvDateFrom.Value, FilterOperator.IsGreaterThanOrEqualTo)
        End If
        If MskTxtInvDateTo.Checked Then
            FilterGrid(Me.GridInventory, "DueDate", Me.MskTxtInvDateTo.Value, FilterOperator.IsLessThanOrEqualTo)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.GridInventory.FilterDescriptors.Clear()
        Me.TxtInvID.Clear()
        Me.MskTxtInvDateFrom.Checked = False
        Me.MskTxtInvDateTo.Checked = False
        BtnFiltering.PerformClick()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Dim FrmItemsInventory As New Inventory
        FrmItemsInventory.ShowDialog()
        If ToDoRefrech Then
            RefrechGrid()
            BtnFiltering.PerformClick()
            ToDoRefrech = False
        End If
    End Sub

    Private Sub TxtInvID_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtInvID.KeyDown
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

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        'If Me.GridInventory.ChildRows.Count > 0 Then
        '    Dim InventoryID As String = Me.GridInventory.CurrentRow.Cells("InventoryID").Value
        '    Dim FrmShowSalesOrder As New AddNewSaleInvoice With {
        '        .BoolForEdit = True,
        '        .InvID = InventoryID
        '    }
        '    FrmShowSalesOrder.ShowDialog()
        '    If ToDoRefrech Then
        '        RefrechGrid()
        '        BtnFiltering.PerformClick()
        '        ToDoRefrech = False
        '    End If
        'End If
    End Sub

    Private Sub BtnPrintInvoice_Click(sender As Object, e As EventArgs) Handles BtnPrintInvoice.Click
        If Me.GridInventory.ChildRows.Count <> 0 And Me.GridInventory.Rows.Count <> 0 Then
            Dim param(0) As String
            param(0) = "InventoryID , " & Me.GridInventory.CurrentRow.Cells("InventoryID").Value
            '  OpenReport(Con.RptSalesOrder, param)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.GridInventory.ChildRows.Count > 0 Then
            Dim InventoryID As String = Me.GridInventory.CurrentRow.Cells("InventoryID").Value
            If MessageShowAsk(Con.Ask_Delete) = DialogResult.Yes Then
                Dim Param(1) As String
                Param(0) = "@IInventoryID , " & InventoryID
                Param(1) = "@IUserID , " & UserID
                ExecuteProcedureWithParameters("DeleteInventoryHeader", Param)
                RefrechGrid()
            End If
        End If


    End Sub

    Private Sub GridInventory_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridInventory.ViewCellFormatting
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
        If Not TypeOf e.CellElement Is GridDetailViewCellElement Then
            If e.Column.Name = "TotalPurchasingPriceLL" Then
                e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, Currency.LebaneaseLire, False, False)
            ElseIf e.Column.Name = "TotalPurchasingPriceUSD" Then
                e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, Currency.Dollar, True, False)
            End If
        End If

    End Sub

    Private Sub GridInventory_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridInventory.CellFormatting

        If e.Column.Name = "TotalPurchasingPriceLL" Then
            e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, Currency.LebaneaseLire, False, False)
        ElseIf e.Column.Name = "TotalPurchasingPriceUSD" Then
            e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, Currency.Dollar, True, False)
        End If
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechGrid()
    End Sub
End Class
