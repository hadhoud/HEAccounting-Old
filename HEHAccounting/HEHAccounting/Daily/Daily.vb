Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class Daily

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        TimerFrm.Interval = TimerDailyForm * 60 * 1000
        InitiateDatePicker()
        RefrechGrid()
        ShowGridSummaryRow()
        InitiateGrid(Me.GridDaily, Grouping:=True)
    End Sub
    Private Sub Daily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDropList()

        TimerFrm.Start()
    End Sub

    Private Sub InitiateDatePicker()
        InitiateDateTimePicker(MskTxtInvDateFrom, DateSerial(2020, 1, 1), True, True)
        InitiateDateTimePicker(MskTxtInvDateTo, DateSerial(2020, 1, 1), True, True)
    End Sub

    Private Sub FillDropList()
        'DropTrxType
        Dim item As New RadListDataItem With {
            .Text = Con.SalesOrder,
            .Value = AbbTransaction.SalesOrders
        }
        Me.DropTrxType.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.PurchaseOrder,
            .Value = AbbTransaction.PurchasesOrders
        }
        Me.DropTrxType.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.ReturnSales,
            .Value = AbbTransaction.ReturnSales
        }
        Me.DropTrxType.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.ReturnPurchases,
            .Value = AbbTransaction.ReturnPurchases
        }
        Me.DropTrxType.Items.Add(item)


        item = New RadListDataItem With {
            .Text = Con.NotesPay,
            .Value = AbbTransaction.NotesPay
        }
        Me.DropTrxType.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.NotesReceive,
            .Value = AbbTransaction.NotesReceive
        }
        Me.DropTrxType.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.GeneralNotesPay,
            .Value = AbbTransaction.GeneralNotesPay
        }
        Me.DropTrxType.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.GeneralNotesReceive,
            .Value = AbbTransaction.GeneralNotesReceive
        }
        Me.DropTrxType.Items.Add(item)


        'DropStatus
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

        Initiatedropdownlist(Me.DropStatus, False)
        Initiatedropdownlist(Me.DropTrxType, False)

    End Sub

    Private Sub ShowGridSummaryRow()
        GridViewAddSummaryRow(GridDaily, "TrsID", "{0}", GridAggregateFunction.Count)
        GridViewAddSummaryRow(GridDaily, "CreatedDate", "{0:dd/MM/yyyy}", GridAggregateFunction.Max)
        GridViewAddSummaryRow(GridDaily, "DueDate", "{0:dd/MM/yyyy}", GridAggregateFunction.Max)
    End Sub

    'Sub AutoComplete()
    '    Dim CustomerVendorAuto As New AutoCompleteStringCollection
    '    For Each Cus In CustomerNameAuto
    '        CustomerVendorAuto.Add(Cus)
    '    Next
    '    For Each Ven In VendorNameAuto
    '        CustomerVendorAuto.Add(Ven)
    '    Next
    '    Me.TxtCustomerVendor.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    Me.TxtCustomerVendor.AutoCompleteCustomSource = CustomerVendorAuto
    '    Me.TxtCustomerVendor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    'End Sub

    Public Sub RefrechGrid()
        Dim Param(1) As String
        Param(0) = "@tFromDate , " & IIf(Me.MskTxtInvDateFrom.Checked, Me.MskTxtInvDateFrom.Value, "")
        Param(1) = "@tTODate , " & IIf(Me.MskTxtInvDateTo.Checked, Me.MskTxtInvDateTo.Value, "")
        FillGridViewProcedureWithParameters(Me.GridDaily, "SelectDaily", Param)
        HideShowColummn(Me.GridDaily, IIf(BoolLTRLanguage, Me.GridDaily.Columns("Description").Index, Me.GridDaily.Columns("LatinDescription").Index), False)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("Refertype").Index, False)
    End Sub

    Private Sub RefrechDateGrid()
        RefrechGrid()
        Me.GridDaily.FilterDescriptors.Clear()
        If Me.TxtCustomerVendor.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridDaily, "CustomerName", Me.TxtCustomerVendor.Text, FilterOperator.Contains)
        End If

        If Me.DropTrxType.SelectedIndex <> -1 Then
            FilterGrid(Me.GridDaily, "Refertype", Me.DropTrxType.SelectedValue, FilterOperator.IsEqualTo)
        End If

        If Me.DropStatus.SelectedIndex <> -1 Then
            FilterGrid(Me.GridDaily, "Status", Me.DropStatus.SelectedValue, FilterOperator.IsEqualTo)
        End If
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        Me.BtnFiltering.Text = LoStrId.LblFiltering
        Me.BtnRefrech.Text = LoStrId.LblEdit
        Me.BtnOpen.Text = LoStrId.LblNew
        Me.BtnReset.Text = LoStrId.LblReset
        Me.BtnRefrech.Text = LoStrId.LblRefrech
        Me.Text = LoStrId.LblDaily
        Me.LblType.Text = LoStrId.LblType
        Me.LblCustomerVendor.Text = LoStrId.LblCustomerVendor
        Me.lblStatus.Text = LoStrId.LblStatus

    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        RefrechDateGrid()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.MskTxtInvDateFrom.Value = DateTime.Now
        Me.MskTxtInvDateTo.Value = DateTime.Now
        Me.TxtCustomerVendor.Clear()
        Me.DropTrxType.SelectedIndex = -1
        Me.DropStatus.SelectedIndex = -1
        RefrechDateGrid()
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechDateGrid()
    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        If Me.GridDaily.ChildRows.Count > 0 Then
            Dim ReferID As String
            Dim ReferType As String
            ReferID = Me.GridDaily.CurrentRow.Cells("ReferID").Value.ToString
            ReferType = Me.GridDaily.CurrentRow.Cells("ReferType").Value.ToString
            Dim Rindex As GridViewRowInfo = Me.GridDaily.CurrentRow
            Select Case ReferType
                Case AbbTransaction.SalesOrders, AbbTransaction.ReturnSales
                    Dim FrmShowSalesOrder As New AddNewSaleInvoice
                    FrmShowSalesOrder.BoolForEdit = True
                    FrmShowSalesOrder.InvID = ReferID
                    FrmShowSalesOrder.ShowDialog()
                    Exit Select
                Case AbbTransaction.PurchasesOrders, AbbTransaction.ReturnPurchases
                    Dim FrmShowPurchasesOrder As New AddNewPurchaseInvoice
                    FrmShowPurchasesOrder.BoolForEdit = True
                    FrmShowPurchasesOrder.InvID = ReferID
                    FrmShowPurchasesOrder.ShowDialog()
                    Exit Select
                Case AbbTransaction.NotesPay
                    Dim FrmShowNotesPay As New NotesPayable
                    FrmShowNotesPay.BoolForEdit = True
                    FrmShowNotesPay.NotesPayID = ReferID
                    FrmShowNotesPay.ShowDialog()
                    Exit Select
                Case AbbTransaction.NotesReceive
                    Dim FrmShowNotesReceive As New NoteReceive
                    FrmShowNotesReceive.BoolForEdit = True
                    FrmShowNotesReceive.NotesReceiveID = ReferID
                    FrmShowNotesReceive.ShowDialog()
                    Exit Select
                Case AbbTransaction.GeneralNotesPay, AbbTransaction.GeneralNotesReceive
                    Dim FrmShowGeneralNotes As New GeneralNotes
                    FrmShowGeneralNotes.BoolForEdit = True
                    FrmShowGeneralNotes.GeneralType = ReferType
                    FrmShowGeneralNotes.NotesID = ReferID
                    FrmShowGeneralNotes.ShowDialog()
                    Exit Select
            End Select
            If ToDoRefrech Then
                RefrechDateGrid()
                ToDoRefrech = False
            End If

        End If

    End Sub

    Private Sub TimerFrm_Tick(sender As Object, e As EventArgs) Handles TimerFrm.Tick
        RefrechDateGrid()
    End Sub

    Private Sub LblType_Click(sender As Object, e As EventArgs) Handles LblType.Click
        Me.DropTrxType.SelectedIndex = -1
    End Sub

    Private Sub LblCustomerVendor_Click(sender As Object, e As EventArgs) Handles LblCustomerVendor.Click
        Me.TxtCustomerVendor.Clear()
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click
        Me.DropStatus.SelectedIndex = -1
    End Sub

    Private Sub GridSalesOrders_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridDaily.ViewCellFormatting
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
