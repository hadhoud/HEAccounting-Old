<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayInvoice
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
        Me.MskTxtPayDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtInvType = New Telerik.WinControls.UI.RadTextBox()
        Me.LblInvType = New System.Windows.Forms.Label()
        Me.TxtInvID = New Telerik.WinControls.UI.RadTextBox()
        Me.LblInvID = New System.Windows.Forms.Label()
        Me.LblInvDate = New System.Windows.Forms.Label()
        Me.MskTxtInvDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.LblDueTotal = New System.Windows.Forms.Label()
        Me.TxtTotalDue = New Telerik.WinControls.UI.RadTextBox()
        Me.TLPCommand = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPay = New Telerik.WinControls.UI.RadButton()
        Me.BtnPrint = New Telerik.WinControls.UI.RadButton()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.MskTxtPayDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInvType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotalDue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPCommand.SuspendLayout()
        CType(Me.BtnPay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtPayDate, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtInvType, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvType, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtInvID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvID, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvDate, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtInvDate, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDueTotal, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtTotalDue, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(338, 155)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'MskTxtPayDate
        '
        Me.MskTxtPayDate.BackColor = System.Drawing.Color.White
        Me.MskTxtPayDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtPayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtPayDate.Location = New System.Drawing.Point(3, 123)
        Me.MskTxtPayDate.Mask = "dd/MM/yyyy"
        Me.MskTxtPayDate.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtPayDate.Name = "MskTxtPayDate"
        Me.MskTxtPayDate.SelectedText = "01"
        Me.MskTxtPayDate.SelectionLength = 2
        Me.MskTxtPayDate.Size = New System.Drawing.Size(163, 24)
        Me.MskTxtPayDate.TabIndex = 23
        Me.MskTxtPayDate.TabStop = False
        Me.MskTxtPayDate.Text = "01/01/2020"
        Me.MskTxtPayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtPayDate.ThemeName = "Office2010Blue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(172, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 30)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "تاريخ التسديد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInvType
        '
        Me.TxtInvType.AcceptsTab = True
        Me.TxtInvType.BackColor = System.Drawing.Color.White
        Me.TxtInvType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvType.Enabled = False
        Me.TxtInvType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvType.HideSelection = False
        Me.TxtInvType.Location = New System.Drawing.Point(3, 93)
        Me.TxtInvType.MaxLength = 65535
        Me.TxtInvType.Name = "TxtInvType"
        Me.TxtInvType.ReadOnly = True
        Me.TxtInvType.Size = New System.Drawing.Size(163, 24)
        Me.TxtInvType.TabIndex = 21
        Me.TxtInvType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInvType.ThemeName = "Office2010Blue"
        Me.TxtInvType.WordWrap = False
        '
        'LblInvType
        '
        Me.LblInvType.AutoSize = True
        Me.LblInvType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvType.Location = New System.Drawing.Point(172, 90)
        Me.LblInvType.Name = "LblInvType"
        Me.LblInvType.Size = New System.Drawing.Size(163, 30)
        Me.LblInvType.TabIndex = 20
        Me.LblInvType.Text = "النوع"
        Me.LblInvType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInvID
        '
        Me.TxtInvID.AcceptsTab = True
        Me.TxtInvID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvID.Enabled = False
        Me.TxtInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvID.HideSelection = False
        Me.TxtInvID.Location = New System.Drawing.Point(3, 3)
        Me.TxtInvID.MaxLength = 65535
        Me.TxtInvID.Name = "TxtInvID"
        Me.TxtInvID.ReadOnly = True
        Me.TxtInvID.Size = New System.Drawing.Size(163, 24)
        Me.TxtInvID.TabIndex = 10
        Me.TxtInvID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInvID.ThemeName = "Office2010Blue"
        Me.TxtInvID.WordWrap = False
        '
        'LblInvID
        '
        Me.LblInvID.AutoSize = True
        Me.LblInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvID.Location = New System.Drawing.Point(172, 0)
        Me.LblInvID.Name = "LblInvID"
        Me.LblInvID.Size = New System.Drawing.Size(163, 30)
        Me.LblInvID.TabIndex = 11
        Me.LblInvID.Text = "رقم الفاتورة"
        Me.LblInvID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInvDate
        '
        Me.LblInvDate.AutoSize = True
        Me.LblInvDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvDate.Location = New System.Drawing.Point(172, 30)
        Me.LblInvDate.Name = "LblInvDate"
        Me.LblInvDate.Size = New System.Drawing.Size(163, 30)
        Me.LblInvDate.TabIndex = 12
        Me.LblInvDate.Text = "التاريخ"
        Me.LblInvDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MskTxtInvDate
        '
        Me.MskTxtInvDate.BackColor = System.Drawing.Color.White
        Me.MskTxtInvDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDate.Enabled = False
        Me.MskTxtInvDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtInvDate.Location = New System.Drawing.Point(3, 33)
        Me.MskTxtInvDate.Mask = "dd/MM/yyyy"
        Me.MskTxtInvDate.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtInvDate.Name = "MskTxtInvDate"
        Me.MskTxtInvDate.SelectedText = "01"
        Me.MskTxtInvDate.SelectionLength = 2
        Me.MskTxtInvDate.Size = New System.Drawing.Size(163, 24)
        Me.MskTxtInvDate.TabIndex = 13
        Me.MskTxtInvDate.TabStop = False
        Me.MskTxtInvDate.Text = "01/01/2020"
        Me.MskTxtInvDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDate.ThemeName = "Office2010Blue"
        '
        'LblDueTotal
        '
        Me.LblDueTotal.AutoSize = True
        Me.LblDueTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDueTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDueTotal.Location = New System.Drawing.Point(172, 60)
        Me.LblDueTotal.Name = "LblDueTotal"
        Me.LblDueTotal.Size = New System.Drawing.Size(163, 30)
        Me.LblDueTotal.TabIndex = 14
        Me.LblDueTotal.Text = "القيمة"
        Me.LblDueTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTotalDue
        '
        Me.TxtTotalDue.AcceptsTab = True
        Me.TxtTotalDue.BackColor = System.Drawing.Color.White
        Me.TxtTotalDue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTotalDue.Enabled = False
        Me.TxtTotalDue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalDue.HideSelection = False
        Me.TxtTotalDue.Location = New System.Drawing.Point(3, 63)
        Me.TxtTotalDue.MaxLength = 65535
        Me.TxtTotalDue.Name = "TxtTotalDue"
        Me.TxtTotalDue.Size = New System.Drawing.Size(163, 24)
        Me.TxtTotalDue.TabIndex = 17
        Me.TxtTotalDue.Text = "0"
        Me.TxtTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTotalDue.ThemeName = "Office2010Blue"
        Me.TxtTotalDue.WordWrap = False
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
        Me.TLPCommand.Controls.Add(Me.BtnPay, 1, 0)
        Me.TLPCommand.Controls.Add(Me.BtnPrint, 3, 0)
        Me.TLPCommand.Controls.Add(Me.BtnClose, 4, 0)
        Me.TLPCommand.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLPCommand.Location = New System.Drawing.Point(0, 155)
        Me.TLPCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPCommand.Name = "TLPCommand"
        Me.TLPCommand.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.TLPCommand.RowCount = 1
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPCommand.Size = New System.Drawing.Size(338, 39)
        Me.TLPCommand.TabIndex = 7
        '
        'BtnPay
        '
        Me.BtnPay.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnPay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPay.Image = Global.HEHAccounting.My.Resources.Resources.money
        Me.BtnPay.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPay.Location = New System.Drawing.Point(227, 3)
        Me.BtnPay.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(100, 32)
        Me.BtnPay.TabIndex = 1
        Me.BtnPay.Tag = "Save"
        Me.BtnPay.Text = "تسديد"
        Me.BtnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Image = Global.HEHAccounting.My.Resources.Resources.print
        Me.BtnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPrint.Location = New System.Drawing.Point(117, 3)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(100, 32)
        Me.BtnPrint.TabIndex = 2
        Me.BtnPrint.Tag = "Print"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(11, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 32)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'PayInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 194)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TLPCommand)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PayInvoice"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تسديد فاتورة"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.MskTxtPayDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInvType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotalDue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPCommand.ResumeLayout(False)
        CType(Me.BtnPay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtInvID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblInvID As Label
    Friend WithEvents LblInvDate As Label
    Private WithEvents MskTxtInvDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblDueTotal As Label
    Friend WithEvents TxtTotalDue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TLPCommand As TableLayoutPanel
    Friend WithEvents BtnPay As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtInvType As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblInvType As Label
    Private WithEvents MskTxtPayDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label1 As Label
End Class

