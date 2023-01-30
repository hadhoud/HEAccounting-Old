Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Enumerations
Imports System.ComponentModel
Imports System.Resources.ResXFileRef
Imports Telerik.Charting
Imports System.Drawing.Drawing2D

Public Class DashboardForm
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        InitializePiePaymentTypeChart()
        InitializeBarPaymentValueChart()

        datatimer.Interval = TimerHomeForm * 60 * 1000
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.lblHome
    End Sub

    Private Sub PanelTimer_Tick(sender As Object, e As EventArgs) Handles PanelTimer.Tick
        Me.DashboardIemsPanel.Visible = True
        PanelTimer.Stop()
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelTimer.Start()
        FillData()
        datatimer.Start()
    End Sub

    Private Sub FillData()
        LoadDashboardMostSellingItem()
        LoadDashboardMostSellingCustomer()
        LoadDashboardTotalSales()
        LoadDashboardMostTotalPurchases()
        LoadDashboardSalesCount()
        LoadDashboardSalesWin()
        LoadPiePaymentTypeChartData()
        loadDataPaymentBarChart()
    End Sub


    Sub LoadDashboardMostSellingItem()
        Dim item_name As String = GetScalarProcedureWithoutParam("GetDashboardMostSellingItem")
        If item_name = "0" Then
            item_name = ""
        End If

        Me.DashMostSellingItem.HEFirstText = item_name
    End Sub

    Sub LoadDashboardMostSellingCustomer()
        Dim customer_name As String = GetScalarProcedureWithoutParam("GetDashboardMostSellingCustomer")
        If customer_name = "0" Then
            customer_name = ""
        End If

        Me.DashMostSellingCustomer.HEFirstText = customer_name
    End Sub

    Sub LoadDashboardTotalSales()
        Dim totalSales As String = GetScalarProcedureWithoutParam("GetDashboardTotalSales")
        If totalSales = "0" Then
            totalSales = ""
        End If

        Me.DashTotalSales.HEFirstText = totalSales
    End Sub

    Sub LoadDashboardMostTotalPurchases()
        Dim totalPurchases As String = GetScalarProcedureWithoutParam("GetDashboardTotalPurchases")
        If totalPurchases = "0" Then
            totalPurchases = ""
        End If

        Me.DashTotalPurchases.HEFirstText = totalPurchases

    End Sub

    Sub LoadDashboardSalesCount()
        Dim totalSales As String = GetScalarProcedureWithoutParam("GetDashboardSalesCount")
        If totalSales = "0" Then
            totalSales = ""
        End If

        Me.DashSalesCount.HEFirstText = totalSales

    End Sub

    Sub LoadDashboardSalesWin()
        Dim totalSalesWin As String = GetScalarProcedureWithoutParam("GetDashboardtotalSalesWin")
        If totalSalesWin = "0" Then
            totalSalesWin = ""
        End If

        Me.DashSalesWin.HEFirstText = totalSalesWin

    End Sub

    Function AddLinkLabel(ByVal Txt As String) As LinkLabel
        Dim LblLink As New LinkLabel
        LblLink.Dock = DockStyle.Top
        LblLink.AutoSize = False
        LblLink.Height = 30
        LblLink.TextAlign = ContentAlignment.MiddleLeft
        LblLink.Font = LinkLabelFont
        LblLink.ForeColor = Color.Black
        LblLink.LinkColor = Color.Black
        LblLink.VisitedLinkColor = Color.Black
        LblLink.ActiveLinkColor = Color.Black
        LblLink.Text = Txt
        LblLink.LinkBehavior = LinkBehavior.NeverUnderline
        Return LblLink
    End Function

    Private Sub InitializeBarPaymentValueChart()

        AddHandler Me.PieChartPaymentType.LabelFormatting, AddressOf LabelFormatting

        Me.chartPayemntValues.ShowTitle = False
        Me.chartPayemntValues.BackColor = Color.Transparent
        Me.chartPayemntValues.ChartElement.BorderColor = Color.Transparent
        Me.chartPayemntValues.ChartElement.TitleElement.Font = Appfont
        Me.chartPayemntValues.ChartElement.TitleElement.CustomFontSize = 10.0F
        Me.chartPayemntValues.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter
        Dim area As CartesianArea = Me.chartPayemntValues.GetArea(Of CartesianArea)()
        Me.chartPayemntValues.Area.View.Palette = KnownPalette.Rainbow
    End Sub

    Private Sub loadDataPaymentBarChart()
        Me.chartPayemntValues.Series.Clear()
        Me.chartPayemntValues.Axes.Clear()
        Me.chartPayemntValues.Annotations.Clear()
        RemoveHandler Me.chartPayemntValues.LabelFormatting, AddressOf chartPayemntValues_LabelFormatting
        AddHandler Me.chartPayemntValues.LabelFormatting, AddressOf chartPayemntValues_LabelFormatting

        Dim barSeries_Renamed As New BarSeries With {
            .ShowLabels = True
        }
        If radioSalesChart.IsChecked Then
            Me.chartPayemntValues.Area.View.Palette = KnownPalette.Rainbow
        Else
            Me.chartPayemntValues.Area.View.Palette = KnownPalette.Autumn
        End If


        Dim verticalMaxValue As Integer = 0
        Dim dt As DataTable = ExecuteQueryDatatable("GetDashboardTotalSalesByMonth")

        For Each ItemsRow As DataRow In dt.Rows
            If radioSalesChart.IsChecked Then
                barSeries_Renamed.DataPoints.Add(New CategoricalDataPoint(Convert.ToDouble(ItemsRow("fSOTotalDue").ToString), ItemsRow("iMonth")))
                If Convert.ToDouble(ItemsRow("fSOTotalDue").ToString) > verticalMaxValue Then
                    verticalMaxValue = Convert.ToDouble(ItemsRow("fSOTotalDue").ToString)
                End If
            Else
                barSeries_Renamed.DataPoints.Add(New CategoricalDataPoint(Convert.ToDouble(ItemsRow("fSOProftis").ToString), ItemsRow("iMonth")))
                If Convert.ToDouble(ItemsRow("fSOProftis").ToString) > verticalMaxValue Then
                    verticalMaxValue = Convert.ToDouble(ItemsRow("fSOProftis").ToString)
                End If
            End If

        Next
        Me.chartPayemntValues.Series.Add(barSeries_Renamed)
        barSeries_Renamed.VerticalAxis.ShowLabels = False
        Dim verticalAxis As LinearAxis = TryCast(barSeries_Renamed.VerticalAxis, LinearAxis)
        verticalAxis.BorderColor = Color.FromArgb(209, 209, 209)
        verticalAxis.Font = Appfont
        verticalAxis.CustomFontSize = 10.0F
        verticalAxis.Minimum = 0
        verticalAxis.Maximum = Math.Max(verticalMaxValue, 5)
        If radioSalesChart.IsChecked Then
            verticalAxis.Title = IIf(BoolLTRLanguage, LoStrId.str_latin_Sales_Total, LoStrId.str_Sales_Total)
        Else
            verticalAxis.Title = IIf(BoolLTRLanguage, LoStrId.str_latin_Proftis_Total, LoStrId.str_Sales_Profits)
        End If

        Dim horizontalAxis As CategoricalAxis = TryCast(barSeries_Renamed.HorizontalAxis, CategoricalAxis)
        horizontalAxis.LabelFitMode = AxisLabelFitMode.MultiLine
        horizontalAxis.GapLength = 0.58
        horizontalAxis.Font = Appfont
        horizontalAxis.CustomFontSize = 10.0F
        horizontalAxis.Title = "الشهر"
        horizontalAxis.BorderColor = Color.FromArgb(209, 209, 209)
        Me.chartPayemntValues.ChartElement.View.Margin = New Padding(0, 30, 0, 0)

        If verticalMaxValue > 0 Then
            Dim annotation1 As New CartesianGridLineAnnotation()
            annotation1.Axis = verticalAxis
            annotation1.Value = verticalMaxValue
            annotation1.BorderColor = Color.FromArgb(255, 145, 0)
            annotation1.BorderDashStyle = DashStyle.Solid
            annotation1.BorderWidth = 2
            Me.chartPayemntValues.Annotations.Add(annotation1)
        End If
        Me.chartPayemntValues.ChartElement.InvalidateMeasure(True)
        Me.chartPayemntValues.ChartElement.UpdateLayout()
        RemoveBorderFromAxis(verticalAxis, horizontalAxis)
    End Sub

    Private Sub RemoveBorderFromAxis(ByVal verticalAxis As LinearAxis, ByVal horizontalAxis As CategoricalAxis)
        For Each el As UIChartElement In verticalAxis.Children
            Dim label As AxisLabelElement = TryCast(el, AxisLabelElement)
            If label IsNot Nothing Then
                label.BorderWidth = 0
            End If
        Next el
        For Each el As UIChartElement In horizontalAxis.Children
            Dim label As AxisLabelElement = TryCast(el, AxisLabelElement)
            If label IsNot Nothing Then
                label.BorderWidth = 0
            End If
        Next el
    End Sub

    Private Sub chartPayemntValues_LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs)
        e.LabelElement.BackColor = Color.Transparent
        e.LabelElement.BorderColor = Color.Transparent
        e.LabelElement.Font = Appfont
    End Sub

    Private Sub InitializePiePaymentTypeChart()
        AddHandler Me.PieChartPaymentType.LabelFormatting, AddressOf LabelFormatting
        Me.PieChartPaymentType.Font = Appfont
        Me.PieChartPaymentType.ChartElement.BorderColor = Color.Transparent
        Me.PieChartPaymentType.BackColor = Color.Transparent
        Me.PieChartPaymentType.Area.View.Palette = New BookingTypesPalette()
        Me.PieChartPaymentType.ChartElement.Font = Appfont
        Me.PieChartPaymentType.ChartElement.View.Margin = New Padding(24)
        Me.PieChartPaymentType.ShowTitle = False
        Me.PieChartPaymentType.ChartElement.TitleElement.Margin = New Padding(0, 10, 0, 0)
        Me.PieChartPaymentType.ChartElement.TitleElement.Font = Appfont
        Me.PieChartPaymentType.ChartElement.TitleElement.TextAlignment = ContentAlignment.MiddleCenter
        Me.PieChartPaymentType.ChartElement.LegendElement.Font = Appfont
        Me.PieChartPaymentType.ChartElement.LegendElement.CustomFontSize = 14
        Me.PieChartPaymentType.ShowLegend = True
        Me.PieChartPaymentType.AreaType = ChartAreaType.Pie
    End Sub

    Private Sub LoadPiePaymentTypeChartData()
        Me.PieChartPaymentType.Series.Clear()
        Dim dt As DataTable = ExecuteQueryDatatable("GetDashboardPaymentTypeCount")
        Dim series As New PieSeries()
        'series.LabelsOffsetFromCenter = 0.7F
        series.LabelMode = PieLabelModes.Horizontal
        For Each ItemsRow As DataRow In dt.Rows
            Dim dataPoint As New PieDataPoint(ItemsRow("count"), ItemsRow("PaymentTypeName"))
            If dataPoint.Value > 0 Then
                series.DataPoints.Add(dataPoint)
            End If
        Next
        series.ShowLabels = True
        If series.DataPoints.Count > 0 Then
            Me.PieChartPaymentType.Series.Add(series)
        End If
        Me.PieChartPaymentType.ChartElement.InvalidateMeasure(True)
        Me.PieChartPaymentType.ChartElement.UpdateLayout()
        Me.PieChartPaymentType.ChartElement.Text = If(PieChartPaymentType.Series.Count > 0, "", "No available data")
    End Sub

    Private Sub LabelFormatting(ByVal sender As Object, ByVal e As ChartViewLabelFormattingEventArgs)
        Dim dp As PieDataPoint = TryCast(e.LabelElement.DataPoint, PieDataPoint)
        If dp IsNot Nothing Then
            Dim pieLabel As PieLabelElement = TryCast(e.LabelElement, PieLabelElement)

            'pieLabel.Text = dp.LegendTitle & " - " & "%" & dp.Percent
            pieLabel.BackColor = Color.Transparent
            pieLabel.BorderColor = pieLabel.DataPointElement.BackColor
            pieLabel.BorderGradientStyle = Telerik.WinControls.GradientStyles.Solid
            pieLabel.RadialOffset = 0
            pieLabel.LineSide = LineSide.Right
            pieLabel.Font = Appfont
            pieLabel.Padding = New Padding(0)
            If dp.Value = 0 Then
                pieLabel.IsVisible = False
            Else
                pieLabel.IsVisible = True
            End If
        End If

    End Sub

    Private Sub datatimer_Tick(sender As Object, e As EventArgs) Handles datatimer.Tick
        FillData()
    End Sub

    Private Sub radioSalesChart_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles radioSalesChart.ToggleStateChanged
        loadDataPaymentBarChart()
    End Sub

    Private Sub radioSalesProfitsChart_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles radioSalesProfitsChart.ToggleStateChanged
        loadDataPaymentBarChart()
    End Sub

End Class
Public Class BookingTypesPalette
    Inherits ChartPalette
    Public Shared converter As New ColorConverter()
    Public Sub New()
        Dim color1 As Color = CType(converter.ConvertFromString("#FF1171CA"), Color)
        Dim color2 As Color = CType(converter.ConvertFromString("#FF3294DA"), Color)
        Dim color3 As Color = CType(converter.ConvertFromString("#FFE03D0B"), Color)
        Dim color4 As Color = CType(converter.ConvertFromString("#FFF58E13"), Color)

        Me.GlobalEntries.Add(color1, color1)
        Me.GlobalEntries.Add(color3, color3)
        Me.GlobalEntries.Add(color4, color4)
        Me.GlobalEntries.Add(color2, color2)
    End Sub
End Class
Public Enum BookingStatus
    Reservation = 1
    Actual = 2
    Cancelled = 3
    CheckedOut = 4
    NoShow = 5
End Enum