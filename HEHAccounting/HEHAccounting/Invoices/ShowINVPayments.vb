Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class ShowINVPayments
    Public InvNum As Integer
    Public ReferType As String

    Sub New(gInvNum, gReferType)

        InvNum = gInvNum
        ReferType = gReferType
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If

        InitiateDatePicker()
        RefrechGrid()

        Me.GridPayments.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridPayments.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom

        InitiateGrid(Me.GridPayments, Grouping:=True)
        FillDropList()
    End Sub


    Private Sub InitiateDatePicker()
        InitiateDateTimePicker(MskTxtInvDateFrom, DateSerial(2020, 1, 1), True, True)
        InitiateDateTimePicker(MskTxtInvDateTo, DateSerial(2020, 1, 1), True, True)
    End Sub
    Private Sub FillDropList()

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

        Initiatedropdownlist(Me.DropPaymentType, False)
    End Sub

    Public Sub RefrechGrid()
        Dim Param(1) As String
        Param(0) = "@iInvID , " & InvNum
        Param(1) = "@cReferType	, " & ReferType
        FillGridViewProcedureWithParameters(Me.GridPayments, "GetInvoiceAllPayments", Param)

        'Always hidden
        HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("DollarRate").Index, False)

        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("TotalDueLL").Index, BoolShowSalesWinColTotalDueLL)
        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("TotalDueUSD").Index, BoolShowSalesWinColTotalDueUSD)
        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("DiscountLL").Index, BoolShowSalesWinColDiscountLL)
        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("DiscountUSD").Index, BoolShowSalesWinColDiscountUSD)
        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("SubTotalLL").Index, BoolShowSalesWinColSubTotalLL)
        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("SubTotalUSD").Index, BoolShowSalesWinColSubTotalUSD)
        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("PurchaseTotalDueLL").Index, BoolShowSalesWinColSubTotalPurchasingLL)
        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("PurchaseTotalDueUSD").Index, BoolShowSalesWinColSubTotalPurchasingUSD)
        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("SellPurchaseDifferenceLL").Index, BoolShowSalesWinColColProfitLL)
        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("SellPurchaseDifferenceUSD").Index, BoolShowSalesWinColColProfitUSD)
        'HideShowColummn(Me.GridPayments, Me.GridPayments.Columns("DollarRate").Index, BoolShowSalesWinColCurrencyRate)

    End Sub

    Private Sub RefrechWithFilterGrid()
        RefrechGrid()

        Me.GridPayments.FilterDescriptors.Clear()
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
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        RefrechWithFilterGrid()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.MskTxtInvDateFrom.Value = Date.Now
        Me.MskTxtInvDateTo.Value = Date.Now
        Me.DropPaymentType.SelectedIndex = -1
        RefrechGrid()
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechWithFilterGrid()
    End Sub

    Private Sub GridPayments_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridPayments.ViewCellFormatting
        If (e.CellElement.RowInfo.Group Is Nothing And TypeOf e.CellElement Is GridSummaryCellElement) Then
            e.CellElement.ForeColor = Color.Blue
            e.CellElement.RowElement.DrawFill = True
            e.CellElement.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.RowElement.BackColor = Color.FromArgb(239, 246, 255)

            If e.Column.Name = "PaymentAmountLL" Or e.Column.Name = "DollarRate" Then
                e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, 0, False, False)
            End If

        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
            e.CellElement.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        End If
    End Sub

    Private Sub GridPayments_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridPayments.CellFormatting

        If e.Column.Name = "PaymentAmountLL" Or e.Column.Name = "DollarRate" Then
            e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, 0, False, False)
        End If

    End Sub

    Private Sub LblPaymentType_Click(sender As Object, e As EventArgs) Handles LblPaymentType.Click
        Me.DropPaymentType.SelectedIndex = -1
    End Sub

    Private Sub ShowINVPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
