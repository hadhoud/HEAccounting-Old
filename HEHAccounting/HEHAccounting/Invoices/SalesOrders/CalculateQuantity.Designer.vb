<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalculateQuantity
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
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtQuantity = New Telerik.WinControls.UI.RadTextBox()
        Me.LblQuantity = New System.Windows.Forms.Label()
        Me.txtItemName = New Telerik.WinControls.UI.RadTextBox()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.LblSellingPrice = New System.Windows.Forms.Label()
        Me.LblPrice = New System.Windows.Forms.Label()
        Me.txtPaidPrice = New Telerik.WinControls.UI.RadTextBox()
        Me.txtSellingPrice = New Telerik.WinControls.UI.RadTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSellingRatio = New Telerik.WinControls.UI.RadTextBox()
        Me.TLPCommand = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnAddItem = New Telerik.WinControls.UI.RadButton()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaidPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSellingPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSellingRatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPCommand.SuspendLayout()
        CType(Me.BtnAddItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtQuantity, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblQuantity, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtItemName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblItemName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblSellingPrice, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblPrice, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPaidPrice, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSellingPrice, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSellingRatio, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(281, 161)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtQuantity
        '
        Me.txtQuantity.AcceptsTab = True
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtQuantity.Enabled = False
        Me.txtQuantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.HideSelection = False
        Me.txtQuantity.Location = New System.Drawing.Point(3, 123)
        Me.txtQuantity.MaxLength = 65535
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(164, 24)
        Me.txtQuantity.TabIndex = 20
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtQuantity.ThemeName = "Office2010Blue"
        Me.txtQuantity.WordWrap = False
        '
        'LblQuantity
        '
        Me.LblQuantity.AutoSize = True
        Me.LblQuantity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblQuantity.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantity.Location = New System.Drawing.Point(173, 120)
        Me.LblQuantity.Name = "LblQuantity"
        Me.LblQuantity.Size = New System.Drawing.Size(105, 30)
        Me.LblQuantity.TabIndex = 18
        Me.LblQuantity.Text = "الكمية"
        Me.LblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItemName
        '
        Me.txtItemName.AcceptsTab = True
        Me.txtItemName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtItemName.Enabled = False
        Me.txtItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.HideSelection = False
        Me.txtItemName.Location = New System.Drawing.Point(3, 3)
        Me.txtItemName.MaxLength = 65535
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.ReadOnly = True
        Me.txtItemName.Size = New System.Drawing.Size(164, 24)
        Me.txtItemName.TabIndex = 10
        Me.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtItemName.ThemeName = "Office2010Blue"
        Me.txtItemName.WordWrap = False
        '
        'LblItemName
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemName.Location = New System.Drawing.Point(173, 0)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(105, 30)
        Me.LblItemName.TabIndex = 11
        Me.LblItemName.Text = "إسم الصنف"
        Me.LblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSellingPrice
        '
        Me.LblSellingPrice.AutoSize = True
        Me.LblSellingPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblSellingPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSellingPrice.Location = New System.Drawing.Point(173, 30)
        Me.LblSellingPrice.Name = "LblSellingPrice"
        Me.LblSellingPrice.Size = New System.Drawing.Size(105, 30)
        Me.LblSellingPrice.TabIndex = 12
        Me.LblSellingPrice.Text = "سعر المبيع"
        Me.LblSellingPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPrice
        '
        Me.LblPrice.AutoSize = True
        Me.LblPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrice.Location = New System.Drawing.Point(173, 90)
        Me.LblPrice.Name = "LblPrice"
        Me.LblPrice.Size = New System.Drawing.Size(105, 30)
        Me.LblPrice.TabIndex = 14
        Me.LblPrice.Text = "السعر المطلوب"
        Me.LblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPaidPrice
        '
        Me.txtPaidPrice.AcceptsTab = True
        Me.txtPaidPrice.BackColor = System.Drawing.Color.White
        Me.txtPaidPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPaidPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaidPrice.HideSelection = False
        Me.txtPaidPrice.Location = New System.Drawing.Point(3, 93)
        Me.txtPaidPrice.MaxLength = 65535
        Me.txtPaidPrice.Name = "txtPaidPrice"
        Me.txtPaidPrice.Size = New System.Drawing.Size(164, 24)
        Me.txtPaidPrice.TabIndex = 17
        Me.txtPaidPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPaidPrice.ThemeName = "Office2010Blue"
        Me.txtPaidPrice.WordWrap = False
        '
        'txtSellingPrice
        '
        Me.txtSellingPrice.AcceptsTab = True
        Me.txtSellingPrice.BackColor = System.Drawing.Color.White
        Me.txtSellingPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSellingPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellingPrice.HideSelection = False
        Me.txtSellingPrice.Location = New System.Drawing.Point(3, 33)
        Me.txtSellingPrice.MaxLength = 65535
        Me.txtSellingPrice.Name = "txtSellingPrice"
        Me.txtSellingPrice.Size = New System.Drawing.Size(164, 24)
        Me.txtSellingPrice.TabIndex = 19
        Me.txtSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSellingPrice.ThemeName = "Office2010Blue"
        Me.txtSellingPrice.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "مقياس سعر المبيع"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSellingRatio
        '
        Me.txtSellingRatio.AcceptsTab = True
        Me.txtSellingRatio.BackColor = System.Drawing.Color.White
        Me.txtSellingRatio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSellingRatio.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellingRatio.HideSelection = False
        Me.txtSellingRatio.Location = New System.Drawing.Point(3, 63)
        Me.txtSellingRatio.MaxLength = 65535
        Me.txtSellingRatio.Name = "txtSellingRatio"
        Me.txtSellingRatio.Size = New System.Drawing.Size(164, 24)
        Me.txtSellingRatio.TabIndex = 22
        Me.txtSellingRatio.Text = "1"
        Me.txtSellingRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSellingRatio.ThemeName = "Office2010Blue"
        Me.txtSellingRatio.WordWrap = False
        '
        'TLPCommand
        '
        Me.TLPCommand.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TLPCommand.ColumnCount = 6
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPCommand.Controls.Add(Me.BtnAddItem, 3, 0)
        Me.TLPCommand.Controls.Add(Me.BtnClose, 4, 0)
        Me.TLPCommand.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLPCommand.Location = New System.Drawing.Point(0, 161)
        Me.TLPCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPCommand.Name = "TLPCommand"
        Me.TLPCommand.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.TLPCommand.RowCount = 1
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPCommand.Size = New System.Drawing.Size(281, 39)
        Me.TLPCommand.TabIndex = 7
        '
        'BtnAddItem
        '
        Me.BtnAddItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAddItem.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddItem.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAddItem.Location = New System.Drawing.Point(143, 3)
        Me.BtnAddItem.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.BtnAddItem.Name = "BtnAddItem"
        Me.BtnAddItem.Size = New System.Drawing.Size(100, 32)
        Me.BtnAddItem.TabIndex = 2
        Me.BtnAddItem.Tag = "Print"
        Me.BtnAddItem.Text = "إضافة"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(37, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 32)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'CalculateQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 200)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TLPCommand)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CalculateQuantity"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "حساب كمية"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaidPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSellingPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSellingRatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPCommand.ResumeLayout(False)
        CType(Me.BtnAddItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txtItemName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblItemName As Label
    Friend WithEvents LblSellingPrice As Label
    Friend WithEvents LblPrice As Label
    Friend WithEvents txtPaidPrice As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TLPCommand As TableLayoutPanel
    Friend WithEvents BtnAddItem As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents LblQuantity As Label
    Friend WithEvents txtSellingPrice As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtQuantity As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSellingRatio As Telerik.WinControls.UI.RadTextBox
End Class

