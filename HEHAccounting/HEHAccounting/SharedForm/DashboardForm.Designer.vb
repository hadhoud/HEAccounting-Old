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
        Me.DashSalesCount = New HEHAccounting.DashboardItem()
        Me.DashTotalSales = New HEHAccounting.DashboardItem()
        Me.DashTotalPurchases = New HEHAccounting.DashboardItem()
        Me.DashSalesWin = New HEHAccounting.DashboardItem()
        Me.chartPayemntValues = New Telerik.WinControls.UI.RadChartView()
        Me.PieChartPaymentType = New Telerik.WinControls.UI.RadChartView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.RadPanelPaymentTypeChart = New Telerik.WinControls.UI.RadPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DashboardIemsPanel.SuspendLayout()
        CType(Me.chartPayemntValues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PieChartPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.RadPanelPaymentTypeChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanelPaymentTypeChart.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
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
        Me.DashboardIemsPanel.Controls.Add(Me.DashSalesCount)
        Me.DashboardIemsPanel.Controls.Add(Me.DashTotalSales)
        Me.DashboardIemsPanel.Controls.Add(Me.DashTotalPurchases)
        Me.DashboardIemsPanel.Controls.Add(Me.DashSalesWin)
        Me.DashboardIemsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DashboardIemsPanel.Location = New System.Drawing.Point(0, 0)
        Me.DashboardIemsPanel.Name = "DashboardIemsPanel"
        Me.DashboardIemsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashboardIemsPanel.Size = New System.Drawing.Size(633, 192)
        Me.DashboardIemsPanel.TabIndex = 0
        Me.DashboardIemsPanel.Visible = False
        '
        'DashMostSellingItem
        '
        Me.DashMostSellingItem.HeaderText = "أكثر صنف مبيعا"
        Me.DashMostSellingItem.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DashMostSellingItem.HeaderTextFont = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashMostSellingItem.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashMostSellingItem.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashMostSellingItem.HEFirstText = "1"
        Me.DashMostSellingItem.HEFirstTextColor = System.Drawing.Color.BlanchedAlmond
        Me.DashMostSellingItem.HEFirstTextFont = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashMostSellingItem.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashMostSellingItem.HEImage = Global.HEHAccounting.My.Resources.Resources.Groups
        Me.DashMostSellingItem.Location = New System.Drawing.Point(425, 0)
        Me.DashMostSellingItem.Margin = New System.Windows.Forms.Padding(0)
        Me.DashMostSellingItem.Name = "DashMostSellingItem"
        Me.DashMostSellingItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashMostSellingItem.Size = New System.Drawing.Size(208, 94)
        Me.DashMostSellingItem.TabIndex = 9
        '
        'DashMostSellingCustomer
        '
        Me.DashMostSellingCustomer.HeaderText = "الزبون الأكثر شراءاً"
        Me.DashMostSellingCustomer.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DashMostSellingCustomer.HeaderTextFont = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashMostSellingCustomer.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashMostSellingCustomer.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashMostSellingCustomer.HEFirstText = "2"
        Me.DashMostSellingCustomer.HEFirstTextColor = System.Drawing.Color.BlanchedAlmond
        Me.DashMostSellingCustomer.HEFirstTextFont = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashMostSellingCustomer.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashMostSellingCustomer.HEImage = Global.HEHAccounting.My.Resources.Resources.Supplier
        Me.DashMostSellingCustomer.Location = New System.Drawing.Point(217, 0)
        Me.DashMostSellingCustomer.Margin = New System.Windows.Forms.Padding(0)
        Me.DashMostSellingCustomer.Name = "DashMostSellingCustomer"
        Me.DashMostSellingCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashMostSellingCustomer.Size = New System.Drawing.Size(208, 94)
        Me.DashMostSellingCustomer.TabIndex = 10
        '
        'DashSalesCount
        '
        Me.DashSalesCount.HeaderText = "فواتير المبيعات"
        Me.DashSalesCount.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DashSalesCount.HeaderTextFont = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashSalesCount.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashSalesCount.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashSalesCount.HEFirstText = "3"
        Me.DashSalesCount.HEFirstTextColor = System.Drawing.Color.BlanchedAlmond
        Me.DashSalesCount.HEFirstTextFont = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashSalesCount.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashSalesCount.HEImage = Global.HEHAccounting.My.Resources.Resources.List
        Me.DashSalesCount.Location = New System.Drawing.Point(9, 0)
        Me.DashSalesCount.Margin = New System.Windows.Forms.Padding(0)
        Me.DashSalesCount.Name = "DashSalesCount"
        Me.DashSalesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashSalesCount.Size = New System.Drawing.Size(208, 94)
        Me.DashSalesCount.TabIndex = 7
        '
        'DashTotalSales
        '
        Me.DashTotalSales.HeaderText = "إجمالي المبيعات"
        Me.DashTotalSales.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DashTotalSales.HeaderTextFont = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashTotalSales.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashTotalSales.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashTotalSales.HEFirstText = "4"
        Me.DashTotalSales.HEFirstTextColor = System.Drawing.Color.BlanchedAlmond
        Me.DashTotalSales.HEFirstTextFont = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashTotalSales.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashTotalSales.HEImage = Global.HEHAccounting.My.Resources.Resources.billing
        Me.DashTotalSales.Location = New System.Drawing.Point(425, 94)
        Me.DashTotalSales.Margin = New System.Windows.Forms.Padding(0)
        Me.DashTotalSales.Name = "DashTotalSales"
        Me.DashTotalSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashTotalSales.Size = New System.Drawing.Size(208, 94)
        Me.DashTotalSales.TabIndex = 8
        '
        'DashTotalPurchases
        '
        Me.DashTotalPurchases.HeaderText = "إجمالي الشراء"
        Me.DashTotalPurchases.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DashTotalPurchases.HeaderTextFont = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashTotalPurchases.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashTotalPurchases.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashTotalPurchases.HEFirstText = "5"
        Me.DashTotalPurchases.HEFirstTextColor = System.Drawing.Color.BlanchedAlmond
        Me.DashTotalPurchases.HEFirstTextFont = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashTotalPurchases.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashTotalPurchases.HEImage = Global.HEHAccounting.My.Resources.Resources.billing
        Me.DashTotalPurchases.Location = New System.Drawing.Point(217, 94)
        Me.DashTotalPurchases.Margin = New System.Windows.Forms.Padding(0)
        Me.DashTotalPurchases.Name = "DashTotalPurchases"
        Me.DashTotalPurchases.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashTotalPurchases.Size = New System.Drawing.Size(208, 94)
        Me.DashTotalPurchases.TabIndex = 4
        '
        'DashSalesWin
        '
        Me.DashSalesWin.HeaderText = "الأرباح مبيعات"
        Me.DashSalesWin.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DashSalesWin.HeaderTextFont = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashSalesWin.HEBackColor1 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashSalesWin.HEBackColor2 = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.DashSalesWin.HEFirstText = "6"
        Me.DashSalesWin.HEFirstTextColor = System.Drawing.Color.BlanchedAlmond
        Me.DashSalesWin.HEFirstTextFont = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashSalesWin.HEGradientAngle = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DashSalesWin.HEImage = Global.HEHAccounting.My.Resources.Resources.invoice
        Me.DashSalesWin.Location = New System.Drawing.Point(9, 94)
        Me.DashSalesWin.Margin = New System.Windows.Forms.Padding(0)
        Me.DashSalesWin.Name = "DashSalesWin"
        Me.DashSalesWin.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DashSalesWin.Size = New System.Drawing.Size(208, 94)
        Me.DashSalesWin.TabIndex = 6
        '
        'chartPayemntValues
        '
        Me.chartPayemntValues.AreaDesign = CartesianArea1
        Me.chartPayemntValues.BackColor = System.Drawing.Color.Transparent
        Me.chartPayemntValues.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartPayemntValues.Location = New System.Drawing.Point(2, 44)
        Me.chartPayemntValues.Name = "chartPayemntValues"
        Me.chartPayemntValues.ShowGrid = False
        Me.chartPayemntValues.Size = New System.Drawing.Size(659, 204)
        Me.chartPayemntValues.TabIndex = 2
        '
        'PieChartPaymentType
        '
        Me.PieChartPaymentType.AreaDesign = CartesianArea2
        Me.PieChartPaymentType.BackColor = System.Drawing.Color.Transparent
        Me.PieChartPaymentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PieChartPaymentType.Location = New System.Drawing.Point(5, 50)
        Me.PieChartPaymentType.Name = "PieChartPaymentType"
        '
        '
        '
        Me.PieChartPaymentType.RootElement.CustomFont = "None"
        Me.PieChartPaymentType.RootElement.CustomFontSize = 12.0!
        Me.PieChartPaymentType.ShowGrid = False
        Me.PieChartPaymentType.ShowLegend = True
        Me.PieChartPaymentType.ShowTitle = True
        Me.PieChartPaymentType.Size = New System.Drawing.Size(330, 131)
        Me.PieChartPaymentType.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 45)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "مبيعات طريقة الدفع"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(673, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(633, 452)
        Me.Panel2.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 192)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel7.Size = New System.Drawing.Size(633, 260)
        Me.Panel7.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DashboardIemsPanel)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(633, 192)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(673, 192)
        Me.Panel4.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RadPanel2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel5.Size = New System.Drawing.Size(327, 192)
        Me.Panel5.TabIndex = 0
        '
        'RadPanel2
        '
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel2.Location = New System.Drawing.Point(3, 3)
        Me.RadPanel2.Margin = New System.Windows.Forms.Padding(12)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.RadPanel2.Size = New System.Drawing.Size(321, 186)
        Me.RadPanel2.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.RadPanelPaymentTypeChart)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(327, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel6.Size = New System.Drawing.Size(346, 192)
        Me.Panel6.TabIndex = 3
        '
        'RadPanelPaymentTypeChart
        '
        Me.RadPanelPaymentTypeChart.Controls.Add(Me.PieChartPaymentType)
        Me.RadPanelPaymentTypeChart.Controls.Add(Me.Label1)
        Me.RadPanelPaymentTypeChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanelPaymentTypeChart.Location = New System.Drawing.Point(3, 3)
        Me.RadPanelPaymentTypeChart.Margin = New System.Windows.Forms.Padding(12)
        Me.RadPanelPaymentTypeChart.Name = "RadPanelPaymentTypeChart"
        Me.RadPanelPaymentTypeChart.Padding = New System.Windows.Forms.Padding(5)
        Me.RadPanelPaymentTypeChart.Size = New System.Drawing.Size(340, 186)
        Me.RadPanelPaymentTypeChart.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 192)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(673, 260)
        Me.Panel1.TabIndex = 8
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.chartPayemntValues)
        Me.RadPanel1.Controls.Add(Me.Label2)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(5, 5)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.RadPanel1.Size = New System.Drawing.Size(663, 250)
        Me.RadPanel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!)
        Me.Label2.Location = New System.Drawing.Point(2, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(659, 42)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "مؤشر المبيعات"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1306, 452)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DashboardForm"
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
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.RadPanelPaymentTypeChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanelPaymentTypeChart.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RadPanelPaymentTypeChart As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Panel5 As Panel
End Class

