<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ItemsSalesWinReport
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
        Dim GridViewSummaryItem9 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem10 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem11 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem12 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem13 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem14 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem15 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem16 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DailyCalendar = New Telerik.WinControls.UI.RadCalendar()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.ChkAlldate = New Telerik.WinControls.UI.RadCheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRefrech = New Telerik.WinControls.UI.RadButton()
        Me.GridDaily = New Telerik.WinControls.UI.RadGridView()
        Me.TimerFrm = New System.Windows.Forms.Timer(Me.components)
        Me.TxtItemName = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.TxtItemsBtn = New Telerik.WinControls.UI.RadButtonElement()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DailyCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkAlldate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDaily.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlOptions
        '
        Me.PnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlOptions.Location = New System.Drawing.Point(0, 0)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(255, 497)
        Me.PnlOptions.TabIndex = 4
        Me.PnlOptions.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnFiltering, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnReset, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 345)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(249, 42)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'BtnFiltering
        '
        Me.BtnFiltering.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFiltering.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFiltering.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnFiltering.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltering.Location = New System.Drawing.Point(142, 3)
        Me.BtnFiltering.Name = "BtnFiltering"
        Me.BtnFiltering.Size = New System.Drawing.Size(90, 36)
        Me.BtnFiltering.TabIndex = 7
        Me.BtnFiltering.Text = "بحث"
        Me.BtnFiltering.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Image = Global.HEHAccounting.My.Resources.Resources.Redo
        Me.BtnReset.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnReset.Location = New System.Drawing.Point(18, 3)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(90, 36)
        Me.BtnReset.TabIndex = 8
        Me.BtnReset.Text = "تصفير"
        Me.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtItemName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DailyCalendar, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCustomerName, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ChkAlldate, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 92)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 253)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'DailyCalendar
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DailyCalendar, 2)
        Me.DailyCalendar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DailyCalendar.Location = New System.Drawing.Point(3, 93)
        Me.DailyCalendar.Name = "DailyCalendar"
        Me.DailyCalendar.Size = New System.Drawing.Size(243, 147)
        Me.DailyCalendar.TabIndex = 18
        Me.DailyCalendar.ThemeName = "Office2010Blue"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCustomerName.Location = New System.Drawing.Point(201, 20)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(45, 30)
        Me.LblCustomerName.TabIndex = 19
        Me.LblCustomerName.Text = "الصنف"
        Me.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkAlldate
        '
        Me.ChkAlldate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.ChkAlldate, 2)
        Me.ChkAlldate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAlldate.Location = New System.Drawing.Point(76, 59)
        Me.ChkAlldate.Name = "ChkAlldate"
        Me.ChkAlldate.Size = New System.Drawing.Size(97, 22)
        Me.ChkAlldate.TabIndex = 22
        Me.ChkAlldate.Text = "جميع التواريخ"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnRefrech, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(249, 89)
        Me.TableLayoutPanel2.TabIndex = 18
        '
        'BtnRefrech
        '
        Me.BtnRefrech.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRefrech.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefrech.Image = Global.HEHAccounting.My.Resources.Resources.Sync
        Me.BtnRefrech.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRefrech.Location = New System.Drawing.Point(18, 23)
        Me.BtnRefrech.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BtnRefrech.Name = "BtnRefrech"
        Me.BtnRefrech.Size = New System.Drawing.Size(90, 36)
        Me.BtnRefrech.TabIndex = 1
        Me.BtnRefrech.Text = "تحديث"
        Me.BtnRefrech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'GridDaily
        '
        Me.GridDaily.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDaily.Location = New System.Drawing.Point(255, 0)
        '
        '
        '
        Me.GridDaily.MasterTemplate.BottomPinnedRowsMode = Telerik.WinControls.UI.GridViewBottomPinnedRowsMode.Fixed
        GridViewSummaryItem9.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem9.AggregateExpression = Nothing
        GridViewSummaryItem9.FormatString = "{0}"
        GridViewSummaryItem9.Name = "PurchasingPrice"
        GridViewSummaryItem10.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem10.AggregateExpression = Nothing
        GridViewSummaryItem10.FormatString = "{0}"
        GridViewSummaryItem10.Name = "SellingPrice"
        GridViewSummaryItem11.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem11.AggregateExpression = Nothing
        GridViewSummaryItem11.FormatString = "{0}"
        GridViewSummaryItem11.Name = "TotalPurchasingPrice"
        GridViewSummaryItem12.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem12.AggregateExpression = Nothing
        GridViewSummaryItem12.FormatString = "{0}"
        GridViewSummaryItem12.Name = "TotalSellingPrice"
        GridViewSummaryItem13.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem13.AggregateExpression = Nothing
        GridViewSummaryItem13.FormatString = "{0}"
        GridViewSummaryItem13.Name = "ItemDiscount"
        GridViewSummaryItem14.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem14.AggregateExpression = Nothing
        GridViewSummaryItem14.FormatString = "{0}"
        GridViewSummaryItem14.Name = "TotalDueSellingPrice"
        GridViewSummaryItem15.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem15.AggregateExpression = Nothing
        GridViewSummaryItem15.FormatString = "{0}"
        GridViewSummaryItem15.Name = "SellPurchaseDifference"
        GridViewSummaryItem16.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem16.AggregateExpression = Nothing
        GridViewSummaryItem16.FormatString = "{0}"
        GridViewSummaryItem16.Name = "Qty"
        Me.GridDaily.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem9, GridViewSummaryItem10, GridViewSummaryItem11, GridViewSummaryItem12, GridViewSummaryItem13, GridViewSummaryItem14, GridViewSummaryItem15, GridViewSummaryItem16}))
        Me.GridDaily.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.GridDaily.Name = "GridDaily"
        Me.GridDaily.Size = New System.Drawing.Size(138, 497)
        Me.GridDaily.TabIndex = 5
        Me.GridDaily.ThemeName = "Office2010Blue"
        '
        'TimerFrm
        '
        '
        'TxtItemName
        '
        Me.TxtItemName.AcceptsTab = True
        Me.TxtItemName.BackColor = System.Drawing.Color.White
        Me.TxtItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.HideSelection = False
        Me.TxtItemName.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.TxtItemsBtn})
        Me.TxtItemName.Location = New System.Drawing.Point(3, 23)
        Me.TxtItemName.MaxLength = 65535
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.ShowClearButton = True
        Me.TxtItemName.Size = New System.Drawing.Size(192, 24)
        Me.TxtItemName.TabIndex = 40
        Me.TxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemName.ThemeName = "Office2010Blue"
        Me.TxtItemName.WordWrap = False
        '
        'TxtItemsBtn
        '
        Me.TxtItemsBtn.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.TxtItemsBtn.Image = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtItemsBtn.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TxtItemsBtn.Name = "TxtItemsBtn"
        Me.TxtItemsBtn.SmallImage = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtItemsBtn.Text = ""
        Me.TxtItemsBtn.UseCompatibleTextRendering = False
        '
        'ItemsSalesWinReport
        '
        Me.AcceptButton = Me.BtnFiltering
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 497)
        Me.Controls.Add(Me.GridDaily)
        Me.Controls.Add(Me.PnlOptions)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemsSalesWinReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Tag = "ItemsSalesDailyWinReport"
        Me.Text = "مبيعات أصناف"
        Me.ThemeName = "Office2010Blue"
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DailyCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkAlldate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDaily.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDaily, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents GridDaily As Telerik.WinControls.UI.RadGridView
    Friend WithEvents DailyCalendar As Telerik.WinControls.UI.RadCalendar
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnRefrech As Telerik.WinControls.UI.RadButton
    Friend WithEvents ChkAlldate As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents TimerFrm As Timer
    Friend WithEvents TxtItemName As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents TxtItemsBtn As Telerik.WinControls.UI.RadButtonElement
End Class

