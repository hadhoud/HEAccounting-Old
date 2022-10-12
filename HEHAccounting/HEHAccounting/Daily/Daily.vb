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
        RefrechGrid()
        InitiateGrid(Me.GridDaily, Grouping:=True)
    End Sub
    Private Sub Daily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDropList()
        TimerFrm.Start()
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
        Dim Param(0) As String
        Param(0) = "@TDailyDate , " & Date.Now.Date
        FillGridViewProcedureWithParameters(Me.GridDaily, "SelectDaily", Param)
        HideShowColummn(Me.GridDaily, IIf(BoolLTRLanguage, Me.GridDaily.Columns("Description").Index, Me.GridDaily.Columns("LatinDescription").Index), False)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("Refertype").Index, False)
    End Sub

    Private Sub RefrechDateGrid()
        Dim Param(0) As String
        If ChkAlldate.Checked = True Then
            Param(0) = "@TDailyDate , 1999-01-01"
            FillGridViewProcedureWithParameters(Me.GridDaily, "SelectDaily", Param)
        Else
            Me.DailyCalendar.SelectedDate = DateTime.MinValue
            Dim selDate As DateTime = Me.DailyCalendar.FocusedDate
            Dim mouseLoc As Point = Me.DailyCalendar.PointToClient(Cursor.Position)
            Dim selElement As RadElement = Me.DailyCalendar.ElementTree.GetElementAtPoint(mouseLoc)
            If selElement IsNot Nothing And TypeOf CType(selElement, CalendarCellElement) Is CalendarCellElement Then
                Dim selCell As CalendarCellElement = CType(selElement, CalendarCellElement)
                selDate = selCell.Date
                Param(0) = "@TDailyDate , " & selDate
            Else
                Param(0) = "@TDailyDate , " & Date.Now.Date
            End If
            FillGridViewProcedureWithParameters(Me.GridDaily, "SelectDaily", Param)
            HideShowColummn(Me.GridDaily, IIf(BoolLTRLanguage, Me.GridDaily.Columns("Description").Index, Me.GridDaily.Columns("LatinDescription").Index), False)
            HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("Refertype").Index, False)
        End If
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
        Me.Text = LoStrId.LblDaiy
    End Sub


    Private Sub DailyCalendar_SelectionChanged(sender As Object, e As EventArgs) Handles DailyCalendar.SelectionChanged
        RefrechDateGrid()
    End Sub

    Private Sub ChkAlldate_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles ChkAlldate.ToggleStateChanged
        If ChkAlldate.Checked = True Then
            Me.DailyCalendar.Enabled = False
        Else
            Me.DailyCalendar.Enabled = True
        End If
        RefrechDateGrid()
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        RefrechDateGrid()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.DailyCalendar.SelectedDate = DateTime.MinValue
        Me.TxtCustomerVendor.Clear()
        Me.DropTrxType.SelectedIndex = -1
        Me.ChkAlldate.Checked = False
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
End Class
