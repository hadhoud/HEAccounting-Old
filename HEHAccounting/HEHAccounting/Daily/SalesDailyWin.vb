Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class SalesDailyWin
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
        FillDropList()
    End Sub
    Private Sub Daily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoComplete()
        TimerFrm.Start()
    End Sub

    Private Sub FillDropList()
        'Dim Sitem As New RadListDataItem With {
        '    .Text = Con.Posted,
        '    .Value = Con.Posted
        '}
        'Me.DropStatus.Items.Add(Sitem)

        'Sitem = New RadListDataItem With {
        '    .Text = Con.UnPosted,
        '    .Value = Con.UnPosted
        '}
        'Me.DropStatus.Items.Add(Sitem)


        Dim PaymentTypeItem As New RadListDataItem With {
            .Text = Con.Cash,
            .Value = PaymentType.Cash
        }
        Me.DropPaymentType.Items.Add(PaymentTypeItem)

        PaymentTypeItem = New RadListDataItem With {
            .Text = Con.Debt,
            .Value = PaymentType.Debt
        }
        Me.DropPaymentType.Items.Add(PaymentTypeItem)

        PaymentTypeItem = New RadListDataItem With {
            .Text = Con.Paid,
            .Value = PaymentType.Paid
        }
        Me.DropPaymentType.Items.Add(PaymentTypeItem)

        'Me.DropCurrency.ValueMember = "CurrencyID"
        'Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinSymb", "Symb")
        'Me.DropCurrency.DataSource = Currencydata

        'Initiatedropdownlist(Me.DropCurrency)
        'Initiatedropdownlist(Me.DropStatus, False)
        Initiatedropdownlist(Me.DropPaymentType, False)
    End Sub
    Public Sub RefrechGrid()
        Dim Param(1) As String
        Param(0) = "@TDailyDate , " & Date.Now.Date
        Param(1) = "@sPaymentType , 0"
        FillGridViewProcedureWithParameters(Me.GridDaily, "GetSalesOrdersDailyWin", Param)
        'HideShowColummn(Me.GridDaily, IIf(BoolLTRLanguage, Me.GridDaily.Columns("Description").Index, Me.GridDaily.Columns("LatinDescription").Index), False)
        'HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("Refertype").Index, False)
    End Sub

    Private Sub RefrechDateGrid()
        Dim Param(1) As String
        If ChkAlldate.Checked = True Then
            Param(0) = "@TDailyDate , 1999-01-01"
            Param(1) = "@sPaymentType , " & IIf(Me.DropPaymentType.SelectedIndex <> -1, Me.DropPaymentType.SelectedValue, "0")
            FillGridViewProcedureWithParameters(Me.GridDaily, "GetSalesOrdersDailyWin", Param)
        Else
            Me.DailyCalendar.SelectedDate = DateTime.MinValue
            Param(0) = "@TDailyDate , " & Me.DailyCalendar.FocusedDate.Date
            Param(1) = "@sPaymentType , " & IIf(Me.DropPaymentType.SelectedIndex <> -1, Me.DropPaymentType.SelectedValue, "0")
            FillGridViewProcedureWithParameters(Me.GridDaily, "GetSalesOrdersDailyWin", Param)
            'HideShowColummn(Me.GridDaily, IIf(BoolLTRLanguage, Me.GridDaily.Columns("Description").Index, Me.GridDaily.Columns("LatinDescription").Index), False)
            'HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("Refertype").Index, False)
        End If

        Me.GridDaily.FilterDescriptors.Clear()
        If Me.TxtCustomer.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridDaily, "CustomerName", Me.TxtCustomer.Text, FilterOperator.Contains)
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
        ChangeTextButtonToRight(Me.TxtCustomer, TxtCustomerBtn)
    End Sub

    Sub AutoComplete()
        Me.TxtCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtCustomer.AutoCompleteCustomSource = CustomerNameAuto
        Me.TxtCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend
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
        Me.DropPaymentType.SelectedIndex = -1
        Me.TxtCustomer.Clear()
        Me.ChkAlldate.Checked = False
        RefrechDateGrid()
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechDateGrid()
    End Sub

    Private Sub TimerFrm_Tick(sender As Object, e As EventArgs) Handles TimerFrm.Tick
        RefrechDateGrid()
    End Sub

    Private Sub TxtCustomerBtn_Click(sender As Object, e As EventArgs) Handles TxtCustomerBtn.Click
        Dim FrmGetCustomer As New CustomerPopup
        FrmGetCustomer.ShowDialog()

        If Not FrmGetCustomer.GetCustomerName.Length = 0 Then
            CustomerNameAuto.Add(FrmGetCustomer.GetCustomerName)
            Me.TxtCustomer.Text = FrmGetCustomer.GetCustomerName
        End If
    End Sub
    Private Sub TxtCustomer_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtCustomer.Validating
        If Not CustomerNameAuto.Contains(Me.TxtCustomer.Text.ToLower) Then
            Me.TxtCustomer.Text = String.Empty
            CustomerID = String.Empty
            CustomerTitle = String.Empty
        Else
            Dim CustomerData() As String = Me.TxtCustomer.Text.Split("/")
            CustomerID = CustomerData(2)
            Me.TxtCustomer.Text = CustomerData(0)
            CustomerTitle = CustomerData(1)
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
        If e.CellElement.ColumnInfo.Name = "SellPurchaseDifference" Then
            'e.CellElement.ForeColor = Color.Blue
            If e.CellElement.Value < 0 Then
                e.CellElement.DrawFill = True
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                e.CellElement.BackColor = Color.Red
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            End If
        End If
    End Sub

    Private Sub LblPaymentType_Click(sender As Object, e As EventArgs) Handles LblPaymentType.Click
        Me.DropPaymentType.SelectedIndex = -1
    End Sub

    Private Sub LblCustomerName_Click(sender As Object, e As EventArgs) Handles LblCustomerName.Click

    End Sub
End Class
