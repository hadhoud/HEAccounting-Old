Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.WinForms.Documents.FormatProviders.Html.Parsing.Dom
Imports Telerik.WinForms.Documents.Model

Public Class AllNotes
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        '  AddLinkColumn()
        Me.GridNotes.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridNotes.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom
        InitiateGrid(Me.GridNotes, Grouping:=True)
        InitiateDatePicker()
        FillDropList()
        ShowPermissions()
    End Sub

    Sub ShowPermissions()
        Dim NRRow As DataRow = UserRolesdt.Select("KeyName = 'NR'").First
        Dim NPRow As DataRow = UserRolesdt.Select("KeyName = 'NP'").First
        Me.BtnDelete.Enabled = NRRow("AllowDelete") Or NPRow("AllowDelete")
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.LblSalesOrders
        Me.LblInvID.Text = LoStrId.LblNum
        Me.LblFrom.Text = LoStrId.LblFrom
        Me.LblTo.Text = LoStrId.LblTo
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

        FillGridViewProcedure(Me.GridNotes, "SelectAllNotes")
        'Always Hidden
        HideShowColummn(Me.GridNotes, Me.GridNotes.Columns("NotesType").Index, False)

        'FilterGrid(Me.GridNotes, "DueDate", DateSerial(Year(Date.Now), Month(Date.Now), DateAndTime.Day(Date.Now)), FilterOperator.IsEqualTo)
    End Sub

    Private Sub FillDropList()

    End Sub

    Private Sub AddLinkColumn()

    End Sub

    Sub AutoComplete()

    End Sub

    Private Sub AllNotesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoComplete()
        Me.MskTxtInvDateFrom.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now), DateAndTime.Day(Date.Now))
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        Me.GridNotes.FilterDescriptors.Clear()

        FilterGrid(Me.GridNotes, "NotesID", Me.TxtInvID.Text.Trim, FilterOperator.Contains)

        If MskTxtInvDateFrom.Checked Then
            FilterGrid(Me.GridNotes, "DueDate", Me.MskTxtInvDateFrom.Value, FilterOperator.IsGreaterThanOrEqualTo)
        End If
        If MskTxtInvDateTo.Checked Then
            FilterGrid(Me.GridNotes, "DueDate", Me.MskTxtInvDateTo.Value, FilterOperator.IsLessThanOrEqualTo)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.GridNotes.FilterDescriptors.Clear()
        Me.TxtInvID.Clear()
        Me.MskTxtInvDateFrom.Checked = False
        Me.MskTxtInvDateTo.Checked = False
        BtnFiltering.PerformClick()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs)

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
        'If Me.GridNotes.ChildRows.Count > 0 Then
        '    Dim InventoryID As String = Me.GridNotes.CurrentRow.Cells("InventoryID").Value
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

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim NRRow As DataRow = UserRolesdt.Select("KeyName = 'NR'").First
        Dim NPRow As DataRow = UserRolesdt.Select("KeyName = 'NP'").First


        If Me.GridNotes.ChildRows.Count > 0 Then
            Dim NotesID As Integer
            Dim NotesType As String
            NotesID = Me.GridNotes.CurrentRow.Cells("NotesID").Value
            NotesType = Me.GridNotes.CurrentRow.Cells("NotesType").Value.ToString
            If NotesType = AbbTransaction.NotesReceive Or NotesType = AbbTransaction.GeneralNotesReceive Then
                If NRRow("AllowDelete").ToString Then
                    If MessageShowAsk(Con.Ask_Delete) = DialogResult.Yes Then
                        Dim Param(2) As String
                        Param(0) = "@iNotesID , " & NotesID
                        Param(1) = "@cNotesType , " & NotesType
                        Param(2) = "@iUserID , " & UserID
                        ExecuteProcedureWithParameters("DeleteNote", Param)
                        RefrechGrid()
                    End If
                Else
                    MessageShowInfo(Con.Msg_NotesReceive_Cannot_Delete_Permission)
                End If
            ElseIf NotesType = AbbTransaction.NotesPay Or NotesType = AbbTransaction.GeneralNotesPay Then
                If NPRow("AllowDelete").ToString Then
                    If MessageShowAsk(Con.Ask_Delete) = DialogResult.Yes Then
                        Dim Param(2) As String
                        Param(0) = "@iNotesID , " & NotesID
                        Param(1) = "@cNotesType , " & NotesType
                        Param(2) = "@iUserID , " & UserID
                        ExecuteProcedureWithParameters("DeleteNote", Param)
                        RefrechGrid()
                    End If
                Else
                    MessageShowInfo(Con.Msg_NotesPay_Cannot_Delete_Permission)
                End If
            End If
        End If
    End Sub

    Private Sub GridNotes_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridNotes.ViewCellFormatting
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

    Private Sub GridNotes_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridNotes.CellFormatting

        If e.Column.Name = "TotalPurchasingPriceLL" Then
            e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, Currency.LebaneaseLire, False, False)
        ElseIf e.Column.Name = "TotalPurchasingPriceUSD" Then
            e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, Currency.Dollar, True, False)
        End If
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechGrid()
    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        If Me.GridNotes.ChildRows.Count > 0 Then
            Dim ReferID As String
            Dim ReferType As String
            ReferID = Me.GridNotes.CurrentRow.Cells("NotesID").Value.ToString
            ReferType = Me.GridNotes.CurrentRow.Cells("NotesType").Value.ToString
            Dim Rindex As GridViewRowInfo = Me.GridNotes.CurrentRow
            Select Case ReferType
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
        End If

    End Sub
End Class
