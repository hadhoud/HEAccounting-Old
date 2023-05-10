<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoicesDetails
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
        Dim GridViewSummaryItem1 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem2 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem3 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem4 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem5 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem6 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem7 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CustomTxtVendorCustomer = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.TxtVendorsCustomerBtn = New Telerik.WinControls.UI.RadButtonElement()
        Me.CustomTxtItemName = New HEHAccounting.CustomItemNameTextBoxControl()
        Me.LblCurrency = New System.Windows.Forms.Label()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.LblIemName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GridInvoicesDetails = New Telerik.WinControls.UI.RadGridView()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CustomTxtVendorCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInvoicesDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInvoicesDetails.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlOptions.Size = New System.Drawing.Size(255, 416)
        Me.PnlOptions.TabIndex = 5
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
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 371)
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
        Me.TableLayoutPanel1.Controls.Add(Me.CustomTxtVendorCustomer, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomTxtItemName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCurrency, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DropCurrency, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCustomerName, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblIemName, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 43)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 110)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'CustomTxtVendorCustomer
        '
        Me.CustomTxtVendorCustomer.AcceptsTab = True
        Me.CustomTxtVendorCustomer.AutoSize = False
        Me.CustomTxtVendorCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomTxtVendorCustomer.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomTxtVendorCustomer.HideSelection = False
        Me.CustomTxtVendorCustomer.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.TxtVendorsCustomerBtn})
        Me.CustomTxtVendorCustomer.Location = New System.Drawing.Point(3, 83)
        Me.CustomTxtVendorCustomer.MaxLength = 65535
        Me.CustomTxtVendorCustomer.Name = "CustomTxtVendorCustomer"
        Me.CustomTxtVendorCustomer.ShowClearButton = True
        Me.CustomTxtVendorCustomer.Size = New System.Drawing.Size(171, 24)
        Me.CustomTxtVendorCustomer.TabIndex = 20
        Me.CustomTxtVendorCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CustomTxtVendorCustomer.ThemeName = "Office2010Blue"
        Me.CustomTxtVendorCustomer.WordWrap = False
        '
        'TxtVendorsCustomerBtn
        '
        Me.TxtVendorsCustomerBtn.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.TxtVendorsCustomerBtn.Image = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtVendorsCustomerBtn.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TxtVendorsCustomerBtn.Name = "TxtVendorsCustomerBtn"
        Me.TxtVendorsCustomerBtn.SmallImage = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtVendorsCustomerBtn.Text = ""
        Me.TxtVendorsCustomerBtn.UseCompatibleTextRendering = False
        '
        'CustomTxtItemName
        '
        Me.CustomTxtItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomTxtItemName.Location = New System.Drawing.Point(3, 53)
        Me.CustomTxtItemName.Name = "CustomTxtItemName"
        Me.CustomTxtItemName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CustomTxtItemName.Size = New System.Drawing.Size(171, 24)
        Me.CustomTxtItemName.TabIndex = 21
        Me.CustomTxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCurrency
        '
        Me.LblCurrency.AutoSize = True
        Me.LblCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCurrency.Location = New System.Drawing.Point(180, 20)
        Me.LblCurrency.Name = "LblCurrency"
        Me.LblCurrency.Size = New System.Drawing.Size(66, 30)
        Me.LblCurrency.TabIndex = 41
        Me.LblCurrency.Text = "العملة"
        Me.LblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropCurrency
        '
        Me.DropCurrency.BackColor = System.Drawing.Color.White
        Me.DropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropCurrency.DropDownAnimationEnabled = True
        Me.DropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrency.Location = New System.Drawing.Point(3, 23)
        Me.DropCurrency.MaxLength = 65535
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Size = New System.Drawing.Size(171, 24)
        Me.DropCurrency.TabIndex = 42
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCustomerName.Location = New System.Drawing.Point(180, 80)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(66, 30)
        Me.LblCustomerName.TabIndex = 19
        Me.LblCustomerName.Text = "زبون/مورد"
        Me.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblIemName
        '
        Me.LblIemName.AutoSize = True
        Me.LblIemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblIemName.Location = New System.Drawing.Point(180, 50)
        Me.LblIemName.Name = "LblIemName"
        Me.LblIemName.Size = New System.Drawing.Size(66, 30)
        Me.LblIemName.TabIndex = 18
        Me.LblIemName.Text = "الصنف"
        Me.LblIemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(249, 40)
        Me.TableLayoutPanel2.TabIndex = 18
        '
        'GridInvoicesDetails
        '
        Me.GridInvoicesDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridInvoicesDetails.Location = New System.Drawing.Point(255, 0)
        '
        '
        '
        GridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count
        GridViewSummaryItem1.AggregateExpression = Nothing
        GridViewSummaryItem1.FormatString = "{0}"
        GridViewSummaryItem1.Name = "InvoiceNum"
        GridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem2.AggregateExpression = Nothing
        GridViewSummaryItem2.FormatString = "{0}"
        GridViewSummaryItem2.Name = "PurchasingPrice"
        GridViewSummaryItem3.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem3.AggregateExpression = Nothing
        GridViewSummaryItem3.FormatString = "{0}"
        GridViewSummaryItem3.Name = "SellingPrice"
        GridViewSummaryItem4.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem4.AggregateExpression = Nothing
        GridViewSummaryItem4.FormatString = "{0}"
        GridViewSummaryItem4.Name = "SubTotal"
        GridViewSummaryItem5.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem5.AggregateExpression = Nothing
        GridViewSummaryItem5.FormatString = "{0}"
        GridViewSummaryItem5.Name = "ItemDiscount"
        GridViewSummaryItem6.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem6.AggregateExpression = Nothing
        GridViewSummaryItem6.FormatString = "{0}"
        GridViewSummaryItem6.Name = "TotalDue"
        GridViewSummaryItem7.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem7.AggregateExpression = Nothing
        GridViewSummaryItem7.FormatString = "{0}"
        GridViewSummaryItem7.Name = "Qty"
        Me.GridInvoicesDetails.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem1, GridViewSummaryItem2, GridViewSummaryItem3, GridViewSummaryItem4, GridViewSummaryItem5, GridViewSummaryItem6, GridViewSummaryItem7}))
        Me.GridInvoicesDetails.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridInvoicesDetails.Name = "GridInvoicesDetails"
        Me.GridInvoicesDetails.Size = New System.Drawing.Size(432, 416)
        Me.GridInvoicesDetails.TabIndex = 6
        Me.GridInvoicesDetails.ThemeName = "Office2010Blue"
        '
        'InvoicesDetails
        '
        Me.AcceptButton = Me.BtnFiltering
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 416)
        Me.Controls.Add(Me.GridInvoicesDetails)
        Me.Controls.Add(Me.PnlOptions)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InvoicesDetails"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.Tag = "FrmInvoicesDetails"
        Me.Text = "فواتير تفصيلي"
        Me.ThemeName = "Office2010Blue"
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.CustomTxtVendorCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInvoicesDetails.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInvoicesDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents LblIemName As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents GridInvoicesDetails As Telerik.WinControls.UI.RadGridView
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents LblCurrency As Label
    Friend WithEvents CustomTxtItemName As CustomItemNameTextBoxControl
    Friend WithEvents CustomTxtVendorCustomer As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents TxtVendorsCustomerBtn As Telerik.WinControls.UI.RadButtonElement
End Class

