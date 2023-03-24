<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventory
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GridInvItems = New Telerik.WinControls.UI.RadGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        Me.TLPHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.TxtItemBarcode = New Telerik.WinControls.UI.RadTextBox()
        Me.LblItemID = New System.Windows.Forms.Label()
        Me.LblBarcode = New System.Windows.Forms.Label()
        Me.TxtItemid = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.CustomTxtItemName = New HEHAccounting.CustomItemNameTextBoxControl()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MskTxtInvDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.GridInvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInvItems.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPHeader.SuspendLayout()
        CType(Me.TxtItemBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.MskTxtInvDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GridInvItems, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TLPHeader, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(809, 505)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GridInvItems
        '
        Me.GridInvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridInvItems.Location = New System.Drawing.Point(3, 113)
        '
        '
        '
        GridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Count
        GridViewSummaryItem1.AggregateExpression = Nothing
        GridViewSummaryItem1.FormatString = "{0}"
        GridViewSummaryItem1.Name = "Item_id"
        GridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem2.AggregateExpression = Nothing
        GridViewSummaryItem2.FormatString = "{0}"
        GridViewSummaryItem2.Name = "TotalPurchasingPriceUSD"
        GridViewSummaryItem3.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem3.AggregateExpression = Nothing
        GridViewSummaryItem3.FormatString = "{0}"
        GridViewSummaryItem3.Name = "TotalPurchasingPriceLL"
        Me.GridInvItems.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem1, GridViewSummaryItem2, GridViewSummaryItem3}))
        Me.GridInvItems.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridInvItems.Name = "GridInvItems"
        Me.GridInvItems.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell
        Me.GridInvItems.Size = New System.Drawing.Size(803, 342)
        Me.GridInvItems.TabIndex = 6
        Me.GridInvItems.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnClose, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnSaveAndNew, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 461)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(803, 41)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(251, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(104, 35)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnSaveAndNew
        '
        Me.BtnSaveAndNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSaveAndNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveAndNew.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSaveAndNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveAndNew.Location = New System.Drawing.Point(451, 3)
        Me.BtnSaveAndNew.Name = "BtnSaveAndNew"
        Me.BtnSaveAndNew.Size = New System.Drawing.Size(104, 35)
        Me.BtnSaveAndNew.TabIndex = 0
        Me.BtnSaveAndNew.Tag = "Save"
        Me.BtnSaveAndNew.Text = "حفظ _ جديد"
        Me.BtnSaveAndNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TLPHeader
        '
        Me.TLPHeader.AutoSize = True
        Me.TLPHeader.ColumnCount = 5
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236.0!))
        Me.TLPHeader.Controls.Add(Me.LblItemName, 2, 0)
        Me.TLPHeader.Controls.Add(Me.TxtItemBarcode, 0, 1)
        Me.TLPHeader.Controls.Add(Me.LblItemID, 1, 0)
        Me.TLPHeader.Controls.Add(Me.LblBarcode, 0, 0)
        Me.TLPHeader.Controls.Add(Me.TxtItemid, 1, 1)
        Me.TLPHeader.Controls.Add(Me.BtnAdd, 3, 0)
        Me.TLPHeader.Controls.Add(Me.CustomTxtItemName, 2, 1)
        Me.TLPHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPHeader.Location = New System.Drawing.Point(3, 58)
        Me.TLPHeader.Name = "TLPHeader"
        Me.TLPHeader.RowCount = 2
        Me.TLPHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPHeader.Size = New System.Drawing.Size(803, 49)
        Me.TLPHeader.TabIndex = 3
        '
        'LblItemName
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemName.Location = New System.Drawing.Point(336, 0)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(162, 19)
        Me.LblItemName.TabIndex = 74
        Me.LblItemName.Text = "إسم الصنف"
        Me.LblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtItemBarcode
        '
        Me.TxtItemBarcode.AcceptsTab = True
        Me.TxtItemBarcode.BackColor = System.Drawing.Color.White
        Me.TxtItemBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemBarcode.HideSelection = False
        Me.TxtItemBarcode.Location = New System.Drawing.Point(655, 22)
        Me.TxtItemBarcode.MaxLength = 65535
        Me.TxtItemBarcode.Name = "TxtItemBarcode"
        Me.TxtItemBarcode.ShowClearButton = True
        Me.TxtItemBarcode.Size = New System.Drawing.Size(145, 24)
        Me.TxtItemBarcode.TabIndex = 0
        Me.TxtItemBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemBarcode.ThemeName = "Office2010Blue"
        Me.TxtItemBarcode.WordWrap = False
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblItemID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemID.Location = New System.Drawing.Point(504, 0)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(145, 19)
        Me.LblItemID.TabIndex = 73
        Me.LblItemID.Text = "كود الصنف"
        Me.LblItemID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBarcode
        '
        Me.LblBarcode.AutoSize = True
        Me.LblBarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarcode.Location = New System.Drawing.Point(655, 0)
        Me.LblBarcode.Name = "LblBarcode"
        Me.LblBarcode.Size = New System.Drawing.Size(145, 19)
        Me.LblBarcode.TabIndex = 66
        Me.LblBarcode.Text = "الباركود"
        Me.LblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtItemid
        '
        Me.TxtItemid.AcceptsTab = True
        Me.TxtItemid.BackColor = System.Drawing.Color.White
        Me.TxtItemid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemid.HideSelection = False
        Me.TxtItemid.Location = New System.Drawing.Point(504, 22)
        Me.TxtItemid.Mask = "G"
        Me.TxtItemid.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtItemid.Name = "TxtItemid"
        Me.TxtItemid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtItemid.Size = New System.Drawing.Size(145, 24)
        Me.TxtItemid.TabIndex = 1
        Me.TxtItemid.TabStop = False
        Me.TxtItemid.Text = "0"
        Me.TxtItemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemid.ThemeName = "Office2010Blue"
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.HEHAccounting.My.Resources.Resources.Create
        Me.BtnAdd.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Location = New System.Drawing.Point(239, 6)
        Me.BtnAdd.Name = "BtnAdd"
        Me.TLPHeader.SetRowSpan(Me.BtnAdd, 2)
        Me.BtnAdd.Size = New System.Drawing.Size(91, 37)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Tag = "Save"
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'CustomTxtItemName
        '
        Me.CustomTxtItemName.Location = New System.Drawing.Point(336, 22)
        Me.CustomTxtItemName.Name = "CustomTxtItemName"
        Me.CustomTxtItemName.Size = New System.Drawing.Size(162, 24)
        Me.CustomTxtItemName.TabIndex = 75
        Me.CustomTxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.87296!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.12704!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TxtSubTotal, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MskTxtInvDate, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtDesc, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(803, 49)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'MskTxtInvDate
        '
        Me.MskTxtInvDate.BackColor = System.Drawing.Color.White
        Me.MskTxtInvDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtInvDate.Location = New System.Drawing.Point(621, 22)
        Me.MskTxtInvDate.Mask = "dd/MM/yyyy"
        Me.MskTxtInvDate.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtInvDate.Name = "MskTxtInvDate"
        Me.MskTxtInvDate.SelectedText = "01"
        Me.MskTxtInvDate.SelectionLength = 2
        Me.MskTxtInvDate.Size = New System.Drawing.Size(179, 24)
        Me.MskTxtInvDate.TabIndex = 78
        Me.MskTxtInvDate.TabStop = False
        Me.MskTxtInvDate.Text = "01/01/2020"
        Me.MskTxtInvDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDate.ThemeName = "Office2010Blue"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(621, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 19)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "التاريخ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 19)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "ملاحظات"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDesc
        '
        Me.TxtDesc.AcceptsTab = True
        Me.TxtDesc.BackColor = System.Drawing.Color.White
        Me.TxtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.HideSelection = False
        Me.TxtDesc.Location = New System.Drawing.Point(115, 22)
        Me.TxtDesc.MaxLength = 65535
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.ShowClearButton = True
        Me.TxtDesc.Size = New System.Drawing.Size(500, 24)
        Me.TxtDesc.TabIndex = 75
        Me.TxtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDesc.ThemeName = "Office2010Blue"
        Me.TxtDesc.WordWrap = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "المجموع ل.ل"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.AcceptsTab = True
        Me.TxtSubTotal.BackColor = System.Drawing.Color.White
        Me.TxtSubTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSubTotal.Enabled = False
        Me.TxtSubTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubTotal.HideSelection = False
        Me.TxtSubTotal.Location = New System.Drawing.Point(22, 22)
        Me.TxtSubTotal.MaxLength = 65535
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(87, 24)
        Me.TxtSubTotal.TabIndex = 80
        Me.TxtSubTotal.Text = "0"
        Me.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtSubTotal.ThemeName = "Office2010Blue"
        Me.TxtSubTotal.Visible = False
        Me.TxtSubTotal.WordWrap = False
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 505)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Inventory"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "جرد أصناف"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.GridInvItems.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPHeader.ResumeLayout(False)
        Me.TLPHeader.PerformLayout()
        CType(Me.TxtItemBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomTxtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.MskTxtInvDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TLPHeader As TableLayoutPanel
    Friend WithEvents LblItemName As Label
    Friend WithEvents TxtItemBarcode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblItemID As Label
    Friend WithEvents LblBarcode As Label
    Friend WithEvents TxtItemid As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents GridInvItems As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Private WithEvents MskTxtInvDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents CustomTxtItemName As CustomItemNameTextBoxControl
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSubTotal As Telerik.WinControls.UI.RadTextBox
End Class

