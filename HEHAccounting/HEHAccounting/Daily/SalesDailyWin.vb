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

        InitiateDatePicker()
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

    Private Sub InitiateDatePicker()
        InitiateDateTimePicker(MskTxtInvDateFrom, DateSerial(2020, 1, 1), True, True)
        InitiateDateTimePicker(MskTxtInvDateTo, DateSerial(2020, 1, 1), True, True)
    End Sub
    Private Sub FillDropList()

        LoadPaymentTypesDropDown(DropPaymentType)

        Initiatedropdownlist(Me.DropPaymentType, False)
    End Sub

    Public Sub RefrechGrid()
        Dim Param(2) As String
        Param(0) = "@tFromDate , " & IIf(Me.MskTxtInvDateFrom.Checked, Me.MskTxtInvDateFrom.Value, "")
        Param(1) = "@tTODate , " & IIf(Me.MskTxtInvDateTo.Checked, Me.MskTxtInvDateTo.Value, "")
        Param(2) = "@sPaymentType , " & IIf(Me.DropPaymentType.SelectedIndex <> -1, Me.DropPaymentType.SelectedValue, "0")
        FillGridViewProcedureWithParameters(Me.GridDaily, "GetSalesOrdersDailyWin", Param)

        'Always hidden
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("PaymentType").Index, False)

        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("TotalDueLL").Index, BoolShowSalesWinColTotalDueLL)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("TotalDueUSD").Index, BoolShowSalesWinColTotalDueUSD)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("DiscountLL").Index, BoolShowSalesWinColDiscountLL)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("DiscountUSD").Index, BoolShowSalesWinColDiscountUSD)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("SubTotalLL").Index, BoolShowSalesWinColSubTotalLL)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("SubTotalUSD").Index, BoolShowSalesWinColSubTotalUSD)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("PurchaseTotalDueLL").Index, BoolShowSalesWinColSubTotalPurchasingLL)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("PurchaseTotalDueUSD").Index, BoolShowSalesWinColSubTotalPurchasingUSD)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("SellPurchaseDifferenceLL").Index, BoolShowSalesWinColColProfitLL)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("SellPurchaseDifferenceUSD").Index, BoolShowSalesWinColColProfitUSD)
        HideShowColummn(Me.GridDaily, Me.GridDaily.Columns("DollarRate").Index, BoolShowSalesWinColCurrencyRate)

    End Sub

    Private Sub RefrechWithFilterGrid()
        RefrechGrid()

        Me.GridDaily.FilterDescriptors.Clear()
        If Me.TxtCustomer.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridDaily, "CustomerName", Me.TxtCustomer.Text, FilterOperator.Contains)
        End If

    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        Me.BtnFiltering.Text = LoStrId.LblFiltering
        Me.BtnRefrech.Text = LoStrId.LblRefrech
        Me.BtnReset.Text = LoStrId.LblReset
        Me.BtnRefrech.Text = LoStrId.LblRefrech
        Me.Text = LoStrId.lblSalesProfit
        Me.LblCustomerName.Text = LoStrId.lblCustomer
        Me.LblPaymentType.Text = LoStrId.LblPayment
        Me.LblFrom.Text = LoStrId.LblFrom
        Me.LblTo.Text = LoStrId.LblTo

        ChangeTextButtonToRight(Me.TxtCustomer, TxtCustomerBtn)
    End Sub

    Sub AutoComplete()
        Me.TxtCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtCustomer.AutoCompleteCustomSource = CustomerNameAuto
        Me.TxtCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub


    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        RefrechWithFilterGrid()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.MskTxtInvDateFrom.Value = Date.Now
        Me.MskTxtInvDateTo.Value = Date.Now
        Me.DropPaymentType.SelectedIndex = -1
        Me.TxtCustomer.Clear()
        RefrechGrid()
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechWithFilterGrid()
    End Sub

    Private Sub TimerFrm_Tick(sender As Object, e As EventArgs) Handles TimerFrm.Tick
        RefrechWithFilterGrid()
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

            If e.Column.Name = "SubTotalLL" Or e.Column.Name = "DiscountLL" Or e.Column.Name = "TotalDueLL" Or e.Column.Name = "PurchaseTotalDueLL" Or e.Column.Name = "SellPurchaseDifferenceLL" Or e.Column.Name = "DollarRate" Then
                e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, 0, False, False)
            End If

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

        ElseIf e.CellElement.ColumnInfo.Name = "Type" Then
            If e.Row.Cells("PaymentType").Value = "D" Then
                e.CellElement.DrawFill = True
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                e.CellElement.BackColor = Color.Red
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            End If
        End If

        If e.Column.Name = "SubTotalLL" Or e.Column.Name = "DiscountLL" Or e.Column.Name = "TotalDueLL" Or e.Column.Name = "PurchaseTotalDueLL" Or e.Column.Name = "SellPurchaseDifferenceLL" Or e.Column.Name = "DollarRate" Then
            e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, 0, False, False)
        End If

    End Sub

    Private Sub LblPaymentType_Click(sender As Object, e As EventArgs) Handles LblPaymentType.Click
        Me.DropPaymentType.SelectedIndex = -1
    End Sub

    Private Sub LblCustomerName_Click(sender As Object, e As EventArgs) Handles LblCustomerName.Click

    End Sub
End Class
