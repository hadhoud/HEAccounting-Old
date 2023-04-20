<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CartesianArea1 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
        Dim CartesianArea2 As Telerik.WinControls.UI.CartesianArea = New Telerik.WinControls.UI.CartesianArea()
        Me.PanelTimer = New System.Windows.Forms.Timer(Me.components)
        Me.datatimer = New System.Windows.Forms.Timer(Me.components)
        Me.DashboardIemsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.DashMostSellingItem = New HEHAccounting.DashboardItem()
        Me.DashMostSellingCustomer = New HEHAccounting.DashboardItem()
        Me.DashTotalPurchases = New HEHAccounting.DashboardItem()
        Me.DashSalesCount = New HEHAccounting.DashboardItem()
        Me.DashTotalSales = New HEHAccounting.DashboardItem()
        Me.DashSalesWin = New HEHAccounting.DashboardItem()
        Me.chartPayemntValues = New Telerik.WinControls.UI.RadChartView()
        Me.PieChartPaymentType = New Telerik.WinControls.UI.RadChartView()
        Me.lblPaymentType = New System.Windows.Forms.Label()
        Me.lblSalesChart = New System.Windows.Forms.Label()
        Me.tblMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tblLeftTopChart = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlPaymentTypeChart = New Telerik.WinControls.UI.RadPanel()
        Me.pnlMultiSalesChart = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.radioSalesChart = New Telerik.WinControls.UI.RadRadioButton()
        Me.radioSalesProfitsChart = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.DashboardIemsPanel.SuspendLayout()
        CType(Me.chartPayemntValues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PieChartPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblMain.SuspendLayout()
        Me.tblLeftTopChart.SuspendLayout()
        CType(Me.pnlPaymentTypeChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPaymentTypeChart.SuspendLayout()
        CType(Me.pnlMultiSalesChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMultiSalesChart.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.radioSalesChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radioSalesProfitsChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTimer
        '
        '
        'datatimer
        '
        Me.datatimer.Interval = 200
        '
        'DashboardIemsPanel
        '
        Me.DashboardIemsPanel.Controls.Add(Me.DashMostSellingItem)
        Me.DashboardIemsPanel.Controls.Add(Me.DashMostSellingCustomer)
        Me.DashboardIemsPanel.Controls.Add(Me.DashTotalPurchases)
        Me.DashboardIemsPanel.Controls.Add(Me.DashSalesCount)
        Me.DashboardIemsPanel.Controls.Add(Me.DashTotalSales)
        Me.DashboardIemsPanel.Controls.Add(Me.DashSalesWin)
        Me.DashboardIemsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardIemsPanel.Location = New System.Drawing.Point(2, 2)
        Me.DashboardIemsPanel.Name = "DashboardIemsPanel"
        Me.DashboardIemsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashboardIemsPanel.Size = New System.Drawing.Size(652, 372)
        Me.DashboardIemsPanel.TabIndex = 0
        Me.DashboardIemsPanel.Visible = False
        '
        'DashMostSellingItem
        '
        Me.DashMostSellingItem.HeaderText = "أكثر صنف مبيعا"
        Me.DashMostSellingItem.HeaderTextColor = System.Drawing.Color.White
        Me.DashMostSellingItem.HeaderTextFont = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashMostSellingItem.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashMostSellingItem.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashMostSellingItem.HEFirstText = "1"
        Me.DashMostSellingItem.HEFirstTextColor = System.Drawing.Color.PeachPuff
        Me.DashMostSellingItem.HEFirstTextFont = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.DashMostSellingItem.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashMostSellingItem.HEImage = Global.HEHAccounting.My.Resources.Resources.Groups
        Me.DashMostSellingItem.Location = New System.Drawing.Point(446, 0)
        Me.DashMostSellingItem.Margin = New System.Windows.Forms.Padding(0)
        Me.DashMostSellingItem.Name = "DashMostSellingItem"
        Me.DashMostSellingItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashMostSellingItem.Size = New System.Drawing.Size(206, 101)
        Me.DashMostSellingItem.TabIndex = 9
        '
        'DashMostSellingCustomer
        '
        Me.DashMostSellingCustomer.HeaderText = "الزبون الأكثر شراءاً"
        Me.DashMostSellingCustomer.HeaderTextColor = System.Drawing.Color.White
        Me.DashMostSellingCustomer.HeaderTextFont = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashMostSellingCustomer.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashMostSellingCustomer.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashMostSellingCustomer.HEFirstText = "2"
        Me.DashMostSellingCustomer.HEFirstTextColor = System.Drawing.Color.PeachPuff
        Me.DashMostSellingCustomer.HEFirstTextFont = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.DashMostSellingCustomer.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashMostSellingCustomer.HEImage = Global.HEHAccounting.My.Resources.Resources.Supplier
        Me.DashMostSellingCustomer.Location = New System.Drawing.Point(238, 0)
        Me.DashMostSellingCustomer.Margin = New System.Windows.Forms.Padding(0)
        Me.DashMostSellingCustomer.Name = "DashMostSellingCustomer"
        Me.DashMostSellingCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashMostSellingCustomer.Size = New System.Drawing.Size(208, 94)
        Me.DashMostSellingCustomer.TabIndex = 10
        '
        'DashTotalPurchases
        '
        Me.DashTotalPurchases.HeaderText = "إجمالي الشراء"
        Me.DashTotalPurchases.HeaderTextColor = System.Drawing.Color.White
        Me.DashTotalPurchases.HeaderTextFont = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.DashTotalPurchases.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashTotalPurchases.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashTotalPurchases.HEFirstText = "5"
        Me.DashTotalPurchases.HEFirstTextColor = System.Drawing.Color.PeachPuff
        Me.DashTotalPurchases.HEFirstTextFont = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.DashTotalPurchases.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashTotalPurchases.HEImage = Global.HEHAccounting.My.Resources.Resources.billing
        Me.DashTotalPurchases.Location = New System.Drawing.Point(30, 0)
        Me.DashTotalPurchases.Margin = New System.Windows.Forms.Padding(0)
        Me.DashTotalPurchases.Name = "DashTotalPurchases"
        Me.DashTotalPurchases.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashTotalPurchases.Size = New System.Drawing.Size(208, 94)
        Me.DashTotalPurchases.TabIndex = 4
        '
        'DashSalesCount
        '
        Me.DashSalesCount.HeaderText = "فواتير المبيعات"
        Me.DashSalesCount.HeaderTextColor = System.Drawing.Color.White
        Me.DashSalesCount.HeaderTextFont = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.DashSalesCount.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashSalesCount.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashSalesCount.HEFirstText = "3"
        Me.DashSalesCount.HEFirstTextColor = System.Drawing.Color.PeachPuff
        Me.DashSalesCount.HEFirstTextFont = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.DashSalesCount.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashSalesCount.HEImage = Global.HEHAccounting.My.Resources.Resources.List
        Me.DashSalesCount.Location = New System.Drawing.Point(444, 101)
        Me.DashSalesCount.Margin = New System.Windows.Forms.Padding(0)
        Me.DashSalesCount.Name = "DashSalesCount"
        Me.DashSalesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashSalesCount.Size = New System.Drawing.Size(208, 92)
        Me.DashSalesCount.TabIndex = 7
        '
        'DashTotalSales
        '
        Me.DashTotalSales.HeaderText = "إجمالي المبيعات"
        Me.DashTotalSales.HeaderTextColor = System.Drawing.Color.White
        Me.DashTotalSales.HeaderTextFont = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.DashTotalSales.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashTotalSales.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashTotalSales.HEFirstText = "4"
        Me.DashTotalSales.HEFirstTextColor = System.Drawing.Color.PeachPuff
        Me.DashTotalSales.HEFirstTextFont = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.DashTotalSales.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashTotalSales.HEImage = Global.HEHAccounting.My.Resources.Resources.billing
        Me.DashTotalSales.Location = New System.Drawing.Point(236, 101)
        Me.DashTotalSales.Margin = New System.Windows.Forms.Padding(0)
        Me.DashTotalSales.Name = "DashTotalSales"
        Me.DashTotalSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashTotalSales.Size = New System.Drawing.Size(208, 92)
        Me.DashTotalSales.TabIndex = 8
        '
        'DashSalesWin
        '
        Me.DashSalesWin.HeaderText = "أرباح المبيعات"
        Me.DashSalesWin.HeaderTextColor = System.Drawing.Color.White
        Me.DashSalesWin.HeaderTextFont = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.DashSalesWin.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashSalesWin.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashSalesWin.HEFirstText = "6"
        Me.DashSalesWin.HEFirstTextColor = System.Drawing.Color.PeachPuff
        Me.DashSalesWin.HEFirstTextFont = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.DashSalesWin.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashSalesWin.HEImage = Global.HEHAccounting.My.Resources.Resources.invoice
        Me.DashSalesWin.Location = New System.Drawing.Point(28, 101)
        Me.DashSalesWin.Margin = New System.Windows.Forms.Padding(0)
        Me.DashSalesWin.Name = "DashSalesWin"
        Me.DashSalesWin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashSalesWin.Size = New System.Drawing.Size(208, 92)
        Me.DashSalesWin.TabIndex = 6
        '
        'chartPayemntValues
        '
        Me.chartPayemntValues.AreaDesign = CartesianArea1
        Me.chartPayemntValues.BackColor = System.Drawing.Color.Transparent
        Me.chartPayemntValues.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartPayemntValues.Location = New System.Drawing.Point(2, 2)
        Me.chartPayemntValues.Name = "chartPayemntValues"
        Me.chartPayemntValues.ShowGrid = False
        Me.chartPayemntValues.Size = New System.Drawing.Size(469, 189)
        Me.chartPayemntValues.TabIndex = 2
        CType(Me.chartPayemntValues.GetChildAt(0), Telerik.WinControls.UI.RadChartElement).BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        '
        'PieChartPaymentType
        '
        Me.PieChartPaymentType.AreaDesign = CartesianArea2
        Me.PieChartPaymentType.BackColor = System.Drawing.Color.Transparent
        Me.PieChartPaymentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PieChartPaymentType.Location = New System.Drawing.Point(3, 45)
        Me.PieChartPaymentType.Name = "PieChartPaymentType"
        '
        '
        '
        Me.PieChartPaymentType.RootElement.CustomFont = "None"
        Me.PieChartPaymentType.RootElement.CustomFontSize = 12.0!
        Me.PieChartPaymentType.ShowGrid = False
        Me.PieChartPaymentType.ShowLegend = True
        Me.PieChartPaymentType.ShowTitle = True
        Me.PieChartPaymentType.Size = New System.Drawing.Size(285, 123)
        Me.PieChartPaymentType.TabIndex = 1
        '
        'lblPaymentType
        '
        Me.lblPaymentType.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPaymentType.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblPaymentType.Location = New System.Drawing.Point(3, 3)
        Me.lblPaymentType.Name = "lblPaymentType"
        Me.lblPaymentType.Size = New System.Drawing.Size(285, 42)
        Me.lblPaymentType.TabIndex = 8
        Me.lblPaymentType.Text = "مبيعات طريقة الدفع"
        Me.lblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalesChart
        '
        Me.lblSalesChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSalesChart.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesChart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.lblSalesChart.Location = New System.Drawing.Point(3, 0)
        Me.lblSalesChart.Name = "lblSalesChart"
        Me.lblSalesChart.Size = New System.Drawing.Size(115, 26)
        Me.lblSalesChart.TabIndex = 10
        Me.lblSalesChart.Text = "مؤشر المبيعات"
        Me.lblSalesChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblMain
        '
        Me.tblMain.ColumnCount = 3
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.45642!))
        Me.tblMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54358!))
        Me.tblMain.Controls.Add(Me.tblLeftTopChart, 2, 0)
        Me.tblMain.Controls.Add(Me.pnlMultiSalesChart, 2, 1)
        Me.tblMain.Controls.Add(Me.RadPanel1, 1, 0)
        Me.tblMain.Controls.Add(Me.PnlOptions, 0, 0)
        Me.tblMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblMain.Location = New System.Drawing.Point(0, 0)
        Me.tblMain.Name = "tblMain"
        Me.tblMain.RowCount = 2
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.90576!))
        Me.tblMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.09424!))
        Me.tblMain.Size = New System.Drawing.Size(1273, 382)
        Me.tblMain.TabIndex = 11
        '
        'tblLeftTopChart
        '
        Me.tblLeftTopChart.ColumnCount = 2
        Me.tblLeftTopChart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLeftTopChart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLeftTopChart.Controls.Add(Me.pnlPaymentTypeChart, 0, 0)
        Me.tblLeftTopChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblLeftTopChart.Location = New System.Drawing.Point(3, 3)
        Me.tblLeftTopChart.Name = "tblLeftTopChart"
        Me.tblLeftTopChart.RowCount = 1
        Me.tblLeftTopChart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLeftTopChart.Size = New System.Drawing.Size(594, 177)
        Me.tblLeftTopChart.TabIndex = 9
        '
        'pnlPaymentTypeChart
        '
        Me.pnlPaymentTypeChart.Controls.Add(Me.PieChartPaymentType)
        Me.pnlPaymentTypeChart.Controls.Add(Me.lblPaymentType)
        Me.pnlPaymentTypeChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPaymentTypeChart.Location = New System.Drawing.Point(300, 3)
        Me.pnlPaymentTypeChart.Name = "pnlPaymentTypeChart"
        Me.pnlPaymentTypeChart.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlPaymentTypeChart.Size = New System.Drawing.Size(291, 171)
        Me.pnlPaymentTypeChart.TabIndex = 11
        '
        'pnlMultiSalesChart
        '
        Me.pnlMultiSalesChart.Controls.Add(Me.chartPayemntValues)
        Me.pnlMultiSalesChart.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlMultiSalesChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMultiSalesChart.Location = New System.Drawing.Point(3, 186)
        Me.pnlMultiSalesChart.Name = "pnlMultiSalesChart"
        Me.pnlMultiSalesChart.Padding = New System.Windows.Forms.Padding(2)
        Me.pnlMultiSalesChart.Size = New System.Drawing.Size(594, 193)
        Me.pnlMultiSalesChart.TabIndex = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblSalesChart, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.radioSalesChart, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.radioSalesProfitsChart, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(471, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(121, 189)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'radioSalesChart
        '
        Me.radioSalesChart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.radioSalesChart.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioSalesChart.Location = New System.Drawing.Point(60, 29)
        Me.radioSalesChart.Name = "radioSalesChart"
        Me.radioSalesChart.Size = New System.Drawing.Size(58, 22)
        Me.radioSalesChart.TabIndex = 11
        Me.radioSalesChart.Text = "مبيعات"
        Me.radioSalesChart.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.radioSalesChart.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'radioSalesProfitsChart
        '
        Me.radioSalesProfitsChart.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioSalesProfitsChart.Location = New System.Drawing.Point(20, 57)
        Me.radioSalesProfitsChart.Name = "radioSalesProfitsChart"
        Me.radioSalesProfitsChart.Size = New System.Drawing.Size(98, 22)
        Me.radioSalesProfitsChart.TabIndex = 12
        Me.radioSalesProfitsChart.TabStop = False
        Me.radioSalesProfitsChart.Text = "أرباح المبيعات"
        Me.radioSalesProfitsChart.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.DashboardIemsPanel)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(603, 3)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Padding = New System.Windows.Forms.Padding(2)
        '
        '
        '
        Me.RadPanel1.RootElement.EnableBorderHighlight = False
        Me.tblMain.SetRowSpan(Me.RadPanel1, 2)
        Me.RadPanel1.Size = New System.Drawing.Size(656, 376)
        Me.RadPanel1.TabIndex = 11
        '
        'PnlOptions
        '
        Me.PnlOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOptions.Location = New System.Drawing.Point(1265, 3)
        Me.PnlOptions.Name = "PnlOptions"
        Me.tblMain.SetRowSpan(Me.PnlOptions, 2)
        Me.PnlOptions.Size = New System.Drawing.Size(5, 376)
        Me.PnlOptions.TabIndex = 12
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1273, 382)
        Me.Controls.Add(Me.tblMain)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DashboardForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.Tag = "FrmDashboard"
        Me.Text = "تحليلات"
        Me.ThemeName = "ControlDefault"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.DashboardIemsPanel.ResumeLayout(False)
        CType(Me.chartPayemntValues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PieChartPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblMain.ResumeLayout(False)
        Me.tblLeftTopChart.ResumeLayout(False)
        CType(Me.pnlPaymentTypeChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPaymentTypeChart.ResumeLayout(False)
        CType(Me.pnlMultiSalesChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMultiSalesChart.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.radioSalesChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radioSalesProfitsChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTimer As Timer
    Friend WithEvents datatimer As Timer
    Friend WithEvents DashboardIemsPanel As FlowLayoutPanel
    Friend WithEvents DashTotalPurchases As DashboardItem
    Friend WithEvents DashSalesWin As DashboardItem
    Friend WithEvents DashSalesCount As DashboardItem
    Friend WithEvents DashTotalSales As DashboardItem
    Friend WithEvents DashMostSellingItem As DashboardItem
    Friend WithEvents DashMostSellingCustomer As DashboardItem
    Friend WithEvents PieChartPaymentType As Telerik.WinControls.UI.RadChartView
    Friend WithEvents chartPayemntValues As Telerik.WinControls.UI.RadChartView
    Friend WithEvents lblPaymentType As Label
    Friend WithEvents lblSalesChart As Label
    Friend WithEvents tblMain As TableLayoutPanel
    Friend WithEvents tblLeftTopChart As TableLayoutPanel
    Friend WithEvents pnlMultiSalesChart As Telerik.WinControls.UI.RadPanel
    Friend WithEvents pnlPaymentTypeChart As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents radioSalesChart As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents radioSalesProfitsChart As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
End Class

