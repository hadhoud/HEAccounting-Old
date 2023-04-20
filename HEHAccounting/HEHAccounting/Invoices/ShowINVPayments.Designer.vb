<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShowINVPayments
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MskTxtInvDateTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.MskTxtInvDateFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.LblPaymentType = New System.Windows.Forms.Label()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.DropPaymentType = New Telerik.WinControls.UI.RadDropDownList()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnRefrech = New Telerik.WinControls.UI.RadButton()
        Me.GridPayments = New Telerik.WinControls.UI.RadGridView()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPayments.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
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
        Me.PnlOptions.Location = New System.Drawing.Point(554, 3)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(255, 486)
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
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 441)
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
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtInvDateTo, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtInvDateFrom, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCustomerName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblPaymentType, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblFrom, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTo, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DropPaymentType, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 92)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 156)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'MskTxtInvDateTo
        '
        Me.MskTxtInvDateTo.CustomFormat = "dd/MM/yyyy"
        Me.MskTxtInvDateTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MskTxtInvDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MskTxtInvDateTo.Location = New System.Drawing.Point(124, 106)
        Me.MskTxtInvDateTo.Name = "MskTxtInvDateTo"
        Me.MskTxtInvDateTo.ShowCheckBox = True
        Me.MskTxtInvDateTo.Size = New System.Drawing.Size(45, 24)
        Me.MskTxtInvDateTo.TabIndex = 21
        Me.MskTxtInvDateTo.TabStop = False
        Me.MskTxtInvDateTo.Text = "04/08/2023"
        Me.MskTxtInvDateTo.ThemeName = "Office2010Blue"
        Me.MskTxtInvDateTo.Value = New Date(2023, 8, 4, 0, 0, 0, 0)
        CType(Me.MskTxtInvDateTo.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).RightToLeft = True
        CType(Me.MskTxtInvDateTo.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "04/08/2023"
        '
        'MskTxtInvDateFrom
        '
        Me.MskTxtInvDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.MskTxtInvDateFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MskTxtInvDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MskTxtInvDateFrom.Location = New System.Drawing.Point(3, 76)
        Me.MskTxtInvDateFrom.Name = "MskTxtInvDateFrom"
        Me.MskTxtInvDateFrom.ShowCheckBox = True
        Me.MskTxtInvDateFrom.Size = New System.Drawing.Size(166, 24)
        Me.MskTxtInvDateFrom.TabIndex = 22
        Me.MskTxtInvDateFrom.TabStop = False
        Me.MskTxtInvDateFrom.Text = "04/08/2023"
        Me.MskTxtInvDateFrom.ThemeName = "Office2010Blue"
        Me.MskTxtInvDateFrom.Value = New Date(2023, 8, 4, 0, 0, 0, 0)
        CType(Me.MskTxtInvDateFrom.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).RightToLeft = True
        CType(Me.MskTxtInvDateFrom.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "04/08/2023"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCustomerName.Location = New System.Drawing.Point(175, 24)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(71, 19)
        Me.LblCustomerName.TabIndex = 19
        Me.LblCustomerName.Text = "الزبون"
        Me.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPaymentType
        '
        Me.LblPaymentType.Location = New System.Drawing.Point(175, 43)
        Me.LblPaymentType.Name = "LblPaymentType"
        Me.LblPaymentType.Size = New System.Drawing.Size(71, 30)
        Me.LblPaymentType.TabIndex = 68
        Me.LblPaymentType.Text = "الدفع"
        Me.LblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFrom.Location = New System.Drawing.Point(175, 73)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(71, 30)
        Me.LblFrom.TabIndex = 69
        Me.LblFrom.Text = "من"
        Me.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTo.Location = New System.Drawing.Point(175, 103)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(71, 30)
        Me.LblTo.TabIndex = 70
        Me.LblTo.Text = "إلى"
        Me.LblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropPaymentType
        '
        Me.DropPaymentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropPaymentType.DropDownAnimationEnabled = True
        Me.DropPaymentType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropPaymentType.Location = New System.Drawing.Point(3, 46)
        Me.DropPaymentType.MaxLength = 65535
        Me.DropPaymentType.Name = "DropPaymentType"
        Me.DropPaymentType.Size = New System.Drawing.Size(166, 24)
        Me.DropPaymentType.TabIndex = 67
        Me.DropPaymentType.Tag = ""
        Me.DropPaymentType.ThemeName = "Office2010Blue"
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
        Me.BtnRefrech.Visible = False
        '
        'GridPayments
        '
        Me.GridPayments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPayments.Location = New System.Drawing.Point(3, 3)
        '
        '
        '
        Me.GridPayments.MasterTemplate.BottomPinnedRowsMode = Telerik.WinControls.UI.GridViewBottomPinnedRowsMode.Fixed
        GridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem1.AggregateExpression = Nothing
        GridViewSummaryItem1.FormatString = "{0}"
        GridViewSummaryItem1.Name = "PaymentAmountLL"
        GridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem2.AggregateExpression = Nothing
        GridViewSummaryItem2.FormatString = "{0}"
        GridViewSummaryItem2.Name = "PaymentAmountUSD"
        GridViewSummaryItem3.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count
        GridViewSummaryItem3.AggregateExpression = Nothing
        GridViewSummaryItem3.FormatString = "{0}"
        GridViewSummaryItem3.Name = "InvID"
        GridViewSummaryItem4.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Max
        GridViewSummaryItem4.AggregateExpression = Nothing
        GridViewSummaryItem4.FormatString = "{0}"
        GridViewSummaryItem4.Name = "DollarRate"
        Me.GridPayments.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem1, GridViewSummaryItem2, GridViewSummaryItem3, GridViewSummaryItem4}))
        Me.GridPayments.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridPayments.Name = "GridPayments"
        Me.GridPayments.Size = New System.Drawing.Size(545, 486)
        Me.GridPayments.TabIndex = 5
        Me.GridPayments.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.PnlOptions, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GridPayments, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(812, 492)
        Me.TableLayoutPanel4.TabIndex = 6
        '
        'ShowINVPayments
        '
        Me.AcceptButton = Me.BtnFiltering
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 492)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ShowINVPayments"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "SalesDailyWin"
        Me.Text = "الدفعات"
        Me.ThemeName = "Office2010Blue"
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPayments.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents GridPayments As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnRefrech As Telerik.WinControls.UI.RadButton
    Friend WithEvents DropPaymentType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents LblPaymentType As Label
    Friend WithEvents LblFrom As Label
    Friend WithEvents LblTo As Label
    Friend WithEvents MskTxtInvDateTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents MskTxtInvDateFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
End Class

