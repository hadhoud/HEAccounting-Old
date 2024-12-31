<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddCashDrawer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCashDrawer))
        Me.LblCurrency = New System.Windows.Forms.Label()
        Me.LblDrawerNote = New System.Windows.Forms.Label()
        Me.LblDrawerName = New System.Windows.Forms.Label()
        Me.TxtDrawerName = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtItemPicture = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtDrawerCode = New Telerik.WinControls.UI.RadTextBox()
        Me.LblDrawerID = New System.Windows.Forms.Label()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.TxtDesc = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.TxtDrawerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TxtDrawerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCurrency
        '
        Me.LblCurrency.AutoSize = True
        Me.LblCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrency.Location = New System.Drawing.Point(201, 65)
        Me.LblCurrency.Name = "LblCurrency"
        Me.LblCurrency.Size = New System.Drawing.Size(151, 30)
        Me.LblCurrency.TabIndex = 71
        Me.LblCurrency.Text = "العملة"
        Me.LblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDrawerNote
        '
        Me.LblDrawerNote.AutoSize = True
        Me.LblDrawerNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDrawerNote.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDrawerNote.Location = New System.Drawing.Point(201, 95)
        Me.LblDrawerNote.Name = "LblDrawerNote"
        Me.LblDrawerNote.Size = New System.Drawing.Size(151, 120)
        Me.LblDrawerNote.TabIndex = 73
        Me.LblDrawerNote.Text = "ملاحظات"
        Me.LblDrawerNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDrawerName
        '
        Me.LblDrawerName.AutoSize = True
        Me.LblDrawerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDrawerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDrawerName.Location = New System.Drawing.Point(201, 35)
        Me.LblDrawerName.Name = "LblDrawerName"
        Me.LblDrawerName.Size = New System.Drawing.Size(151, 30)
        Me.LblDrawerName.TabIndex = 72
        Me.LblDrawerName.Text = "إسم الصندوق"
        Me.LblDrawerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDrawerName
        '
        Me.TxtDrawerName.BackColor = System.Drawing.Color.Transparent
        Me.TxtDrawerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDrawerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDrawerName.Location = New System.Drawing.Point(3, 38)
        Me.TxtDrawerName.Name = "TxtDrawerName"
        Me.TxtDrawerName.Size = New System.Drawing.Size(192, 24)
        Me.TxtDrawerName.TabIndex = 2
        Me.TxtDrawerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDrawerName.ThemeName = "Office2010Blue"
        '
        'TxtItemPicture
        '
        Me.TxtItemPicture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemPicture.Location = New System.Drawing.Point(351, 3)
        Me.TxtItemPicture.Name = "TxtItemPicture"
        Me.TxtItemPicture.ShowClearButton = True
        Me.TxtItemPicture.Size = New System.Drawing.Size(1, 5)
        Me.TxtItemPicture.TabIndex = 37
        Me.TxtItemPicture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemPicture.ThemeName = "Office2010Blue"
        Me.TxtItemPicture.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(361, 268)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.BtnClose, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnSaveAndNew, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TxtItemPicture, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 224)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(355, 41)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(35, 3)
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
        Me.BtnSaveAndNew.Location = New System.Drawing.Point(210, 3)
        Me.BtnSaveAndNew.Name = "BtnSaveAndNew"
        Me.BtnSaveAndNew.Size = New System.Drawing.Size(102, 35)
        Me.BtnSaveAndNew.TabIndex = 0
        Me.BtnSaveAndNew.Tag = "Save"
        Me.BtnSaveAndNew.Text = "حفظ _ جديد"
        Me.BtnSaveAndNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556!))
        Me.TableLayoutPanel2.Controls.Add(Me.TxtDrawerCode, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LblDrawerID, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DropCurrency, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtDesc, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.LblCurrency, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LblDrawerNote, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.LblDrawerName, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtDrawerName, 1, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(355, 215)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TxtDrawerCode
        '
        Me.TxtDrawerCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtDrawerCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDrawerCode.Enabled = False
        Me.TxtDrawerCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDrawerCode.Location = New System.Drawing.Point(3, 8)
        Me.TxtDrawerCode.Name = "TxtDrawerCode"
        Me.TxtDrawerCode.Size = New System.Drawing.Size(192, 24)
        Me.TxtDrawerCode.TabIndex = 2
        Me.TxtDrawerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDrawerCode.ThemeName = "Office2010Blue"
        Me.TxtDrawerCode.Visible = False
        '
        'LblDrawerID
        '
        Me.LblDrawerID.AutoSize = True
        Me.LblDrawerID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDrawerID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDrawerID.Location = New System.Drawing.Point(201, 5)
        Me.LblDrawerID.Name = "LblDrawerID"
        Me.LblDrawerID.Size = New System.Drawing.Size(151, 30)
        Me.LblDrawerID.TabIndex = 76
        Me.LblDrawerID.Text = "الرقم"
        Me.LblDrawerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblDrawerID.Visible = False
        '
        'DropCurrency
        '
        Me.DropCurrency.BackColor = System.Drawing.Color.White
        Me.DropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropCurrency.DropDownAnimationEnabled = True
        Me.DropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrency.Location = New System.Drawing.Point(3, 68)
        Me.DropCurrency.MaxLength = 65535
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Size = New System.Drawing.Size(192, 24)
        Me.DropCurrency.TabIndex = 75
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'TxtDesc
        '
        Me.TxtDesc.BackColor = System.Drawing.Color.White
        Me.TxtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(3, 98)
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        '
        '
        '
        Me.TxtDesc.RootElement.StretchVertically = True
        Me.TxtDesc.Size = New System.Drawing.Size(192, 114)
        Me.TxtDesc.TabIndex = 74
        Me.TxtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDesc.ThemeName = "Office2010Blue"
        '
        'AddCashDrawer
        '
        Me.AcceptButton = Me.BtnSaveAndNew
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 268)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddCashDrawer"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إضافة صندوق"
        Me.ThemeName = "Office2010Blue"
        CType(Me.TxtDrawerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.TxtDrawerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblCurrency As Label
    Friend WithEvents LblDrawerNote As Label
    Friend WithEvents LblDrawerName As Label
    Friend WithEvents TxtDrawerName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtItemPicture As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TxtDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents LblDrawerID As Label
    Friend WithEvents TxtDrawerCode As Telerik.WinControls.UI.RadTextBox
End Class

