<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceAttachments
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
        Me.TxtInvoiceDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtInvID = New Telerik.WinControls.UI.RadTextBox()
        Me.LblInvID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TLPCommand = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSaveAttachments = New Telerik.WinControls.UI.RadButton()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtInvoiceDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPCommand.SuspendLayout()
        CType(Me.BtnSaveAttachments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 382.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtInvoiceDesc, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtInvID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvID, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(633, 192)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TxtInvoiceDesc
        '
        Me.TxtInvoiceDesc.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.TxtInvoiceDesc, 2)
        Me.TxtInvoiceDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvoiceDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvoiceDesc.Location = New System.Drawing.Point(23, 33)
        Me.TxtInvoiceDesc.Multiline = True
        Me.TxtInvoiceDesc.Name = "TxtInvoiceDesc"
        '
        '
        '
        Me.TxtInvoiceDesc.RootElement.StretchVertically = True
        Me.TxtInvoiceDesc.Size = New System.Drawing.Size(530, 138)
        Me.TxtInvoiceDesc.TabIndex = 40
        Me.TxtInvoiceDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInvoiceDesc.ThemeName = "Office2010Blue"
        '
        'TxtInvID
        '
        Me.TxtInvID.AcceptsTab = True
        Me.TxtInvID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvID.Enabled = False
        Me.TxtInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvID.HideSelection = False
        Me.TxtInvID.Location = New System.Drawing.Point(405, 3)
        Me.TxtInvID.MaxLength = 65535
        Me.TxtInvID.Name = "TxtInvID"
        Me.TxtInvID.ReadOnly = True
        Me.TxtInvID.Size = New System.Drawing.Size(148, 24)
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
        Me.LblInvID.Location = New System.Drawing.Point(559, 0)
        Me.LblInvID.Name = "LblInvID"
        Me.LblInvID.Size = New System.Drawing.Size(71, 30)
        Me.LblInvID.TabIndex = 11
        Me.LblInvID.Text = "رقم الفاتورة"
        Me.LblInvID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(559, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 144)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ملاحظات"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TLPCommand.Controls.Add(Me.BtnSaveAttachments, 1, 0)
        Me.TLPCommand.Controls.Add(Me.BtnClose, 4, 0)
        Me.TLPCommand.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLPCommand.Location = New System.Drawing.Point(0, 192)
        Me.TLPCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPCommand.Name = "TLPCommand"
        Me.TLPCommand.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.TLPCommand.RowCount = 1
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPCommand.Size = New System.Drawing.Size(633, 39)
        Me.TLPCommand.TabIndex = 7
        '
        'BtnSaveAttachments
        '
        Me.BtnSaveAttachments.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSaveAttachments.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnSaveAttachments.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveAttachments.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSaveAttachments.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveAttachments.Location = New System.Drawing.Point(321, 3)
        Me.BtnSaveAttachments.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.BtnSaveAttachments.Name = "BtnSaveAttachments"
        Me.BtnSaveAttachments.Size = New System.Drawing.Size(100, 32)
        Me.BtnSaveAttachments.TabIndex = 1
        Me.BtnSaveAttachments.Tag = "Save"
        Me.BtnSaveAttachments.Text = "حفظ"
        Me.BtnSaveAttachments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(213, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 32)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'InvoiceAttachments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 231)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TLPCommand)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InvoiceAttachments"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "مرفقات"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtInvoiceDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPCommand.ResumeLayout(False)
        CType(Me.BtnSaveAttachments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtInvID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblInvID As Label
    Friend WithEvents TLPCommand As TableLayoutPanel
    Friend WithEvents BtnSaveAttachments As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtInvoiceDesc As Telerik.WinControls.UI.RadTextBox
End Class

