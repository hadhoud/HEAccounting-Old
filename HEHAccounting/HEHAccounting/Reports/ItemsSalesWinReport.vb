Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class ItemsSalesWinReport
    Dim CustomerID As String
    Dim CustomerTitle As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        TimerFrm.Interval = TimerDailyForm * 60 * 1000
        RefrechGrid()

        Me.GridDaily.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridDaily.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom

        InitiateGrid(Me.GridDaily, Grouping:=True)
    End Sub
    Private Sub Daily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoComplete()
        TimerFrm.Start()
    End Sub

    Public Sub RefrechGrid()
        Dim Param(0) As String
        Param(0) = "@TDailyDate , " & Date.Now.Date
        FillGridViewProcedureWithParameters(Me.GridDaily, "GetItemsSalesDailyWin", Param)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("PaymentType").Index, False)
    End Sub

    Private Sub RefrechDateGrid()
        Dim Param(0) As String
        If ChkAlldate.Checked = True Then
            Param(0) = "@TDailyDate , 1999-01-01"
            FillGridViewProcedureWithParameters(Me.GridDaily, "GetItemsSalesDailyWin", Param)
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
            FillGridViewProcedureWithParameters(Me.GridDaily, "GetItemsSalesDailyWin", Param)
            'HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("Refertype").Index, False)
        End If
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("PaymentType").Index, False)
        Me.GridDaily.FilterDescriptors.Clear()
        If Me.TxtItemName.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridDaily, "Item_name", Me.TxtItemName.Text, FilterOperator.Contains)
        End If
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        Me.BtnFiltering.Text = LoStrId.LblFiltering
        Me.BtnRefrech.Text = LoStrId.LblEdit
        Me.BtnReset.Text = LoStrId.LblReset
        Me.BtnRefrech.Text = LoStrId.LblRefrech
        Me.Text = LoStrId.LblDaiy
        ChangeTextButtonToRight(Me.TxtItemName, TxtItemsBtn)
    End Sub

    Sub AutoComplete()
        Me.TxtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtItemName.AutoCompleteCustomSource = ItemsNameAuto
        Me.TxtItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
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
        Me.TxtItemName.Clear()
        Me.ChkAlldate.Checked = False
        RefrechDateGrid()
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechDateGrid()
    End Sub

    Private Sub TimerFrm_Tick(sender As Object, e As EventArgs) Handles TimerFrm.Tick
        RefrechDateGrid()
    End Sub

    Private Sub TxtCustomerBtn_Click(sender As Object, e As EventArgs)
        Dim FrmGetCustomer As New CustomerPopup
        FrmGetCustomer.ShowDialog()

        If Not FrmGetCustomer.GetCustomerName.Length = 0 Then
            CustomerNameAuto.Add(FrmGetCustomer.GetCustomerName)
            Me.TxtItemName.Text = FrmGetCustomer.GetCustomerName
        End If
    End Sub

    Private Sub GridDaily_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridDaily.ViewCellFormatting
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

    Private Sub GridDaily_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridDaily.CellFormatting
        'If e.CellElement.ColumnInfo.Name = "SellPurchaseDifference" Then
        '    'e.CellElement.ForeColor = Color.Blue
        '    If e.CellElement.Value < 0 Then
        '        e.CellElement.DrawFill = True
        '        e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        '        e.CellElement.BackColor = Color.Red
        '    Else
        '        e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
        '        e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        '    End If
        'End If
        Dim column As GridViewDataColumn = TryCast(e.Column, GridViewDataColumn)
        If TypeOf e.Row Is GridViewDataRowInfo AndAlso column IsNot Nothing Then
            If column.Name = "PaymentTypeName" Then
                If e.Row.Cells("PaymentType").Value = "C" Then
                    e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                    e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                    e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                Else
                    e.CellElement.DrawFill = True
                    e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                    e.CellElement.BackColor = Color.Red
                End If
            ElseIf column.Name = "SellPurchaseDifference" Then
                If e.Row.Cells("SellPurchaseDifference").Value < 0 Then
                    e.CellElement.DrawFill = True
                    e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                    e.CellElement.BackColor = Color.Red
                Else
                    e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                    e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                    e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
                End If
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            End If
        End If
    End Sub

    Private Sub TxtItemsBtn_Click(sender As Object, e As EventArgs) Handles TxtItemsBtn.Click
        Dim FrmGetItem As New ItemsPopup
        FrmGetItem.ShowDialog()
        If Not FrmGetItem.GetITemName.Length = 0 Then
            Me.TxtItemName.Text = FrmGetItem.GetITemName
        End If
    End Sub
End Class
