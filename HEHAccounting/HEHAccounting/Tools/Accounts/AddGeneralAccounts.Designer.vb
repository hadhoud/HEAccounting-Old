<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddGeneralAccounts
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddGeneralAccounts))
        Me.TxtCode = New Telerik.WinControls.UI.RadTextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblLatinName = New System.Windows.Forms.Label()
        Me.LblCurSymb = New System.Windows.Forms.Label()
        Me.TxtLatinName = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtAccName = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtAccNum = New Telerik.WinControls.UI.RadTextBox()
        Me.LblCode = New System.Windows.Forms.Label()
        Me.TxtItemPicture = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.TxtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLatinName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAccName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAccNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCode
        '
        Me.TxtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCode.Enabled = False
        Me.TxtCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCode.Location = New System.Drawing.Point(3, 3)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(156, 24)
        Me.TxtCode.TabIndex = 1
        Me.TxtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCode.ThemeName = "Office2010Blue"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(165, 60)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(122, 30)
        Me.LblName.TabIndex = 71
        Me.LblName.Text = "إسم الحساب"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblLatinName
        '
        Me.LblLatinName.AutoSize = True
        Me.LblLatinName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblLatinName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLatinName.Location = New System.Drawing.Point(165, 90)
        Me.LblLatinName.Name = "LblLatinName"
        Me.LblLatinName.Size = New System.Drawing.Size(122, 30)
        Me.LblLatinName.TabIndex = 73
        Me.LblLatinName.Text = "الإسم اللاتيني"
        Me.LblLatinName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCurSymb
        '
        Me.LblCurSymb.AutoSize = True
        Me.LblCurSymb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCurSymb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurSymb.Location = New System.Drawing.Point(165, 30)
        Me.LblCurSymb.Name = "LblCurSymb"
        Me.LblCurSymb.Size = New System.Drawing.Size(122, 30)
        Me.LblCurSymb.TabIndex = 72
        Me.LblCurSymb.Text = "رقم الحساب"
        Me.LblCurSymb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtLatinName
        '
        Me.TxtLatinName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtLatinName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLatinName.Location = New System.Drawing.Point(3, 93)
        Me.TxtLatinName.Name = "TxtLatinName"
        Me.TxtLatinName.ShowClearButton = True
        Me.TxtLatinName.Size = New System.Drawing.Size(156, 24)
        Me.TxtLatinName.TabIndex = 4
        Me.TxtLatinName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtLatinName.ThemeName = "Office2010Blue"
        '
        'TxtAccName
        '
        Me.TxtAccName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAccName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccName.Location = New System.Drawing.Point(3, 63)
        Me.TxtAccName.Name = "TxtAccName"
        Me.TxtAccName.ShowClearButton = True
        Me.TxtAccName.Size = New System.Drawing.Size(156, 24)
        Me.TxtAccName.TabIndex = 3
        Me.TxtAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAccName.ThemeName = "Office2010Blue"
        '
        'TxtAccNum
        '
        Me.TxtAccNum.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAccNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAccNum.Enabled = False
        Me.TxtAccNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccNum.Location = New System.Drawing.Point(3, 33)
        Me.TxtAccNum.Name = "TxtAccNum"
        Me.TxtAccNum.Size = New System.Drawing.Size(156, 24)
        Me.TxtAccNum.TabIndex = 2
        Me.TxtAccNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAccNum.ThemeName = "Office2010Blue"
        '
        'LblCode
        '
        Me.LblCode.AutoSize = True
        Me.LblCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode.Location = New System.Drawing.Point(165, 0)
        Me.LblCode.Name = "LblCode"
        Me.LblCode.Size = New System.Drawing.Size(122, 30)
        Me.LblCode.TabIndex = 84
        Me.LblCode.Text = "كود"
        Me.LblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtItemPicture
        '
        Me.TxtItemPicture.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemPicture.Location = New System.Drawing.Point(286, 3)
        Me.TxtItemPicture.Name = "TxtItemPicture"
        Me.TxtItemPicture.ShowClearButton = True
        Me.TxtItemPicture.Size = New System.Drawing.Size(1, 24)
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(296, 182)
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 138)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(290, 41)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(20, 3)
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
        Me.BtnSaveAndNew.Location = New System.Drawing.Point(162, 3)
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
        Me.TableLayoutPanel2.Controls.Add(Me.TxtCode, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LblName, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LblLatinName, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LblCurSymb, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtLatinName, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtAccName, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtAccNum, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LblCode, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(290, 129)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'AddGeneralAccounts
        '
        Me.AcceptButton = Me.BtnSaveAndNew
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 182)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddGeneralAccounts"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إضافة حساب"
        Me.ThemeName = "Office2010Blue"
        CType(Me.TxtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLatinName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAccName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAccNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblName As Label
    Friend WithEvents LblLatinName As Label
    Friend WithEvents LblCurSymb As Label
    Friend WithEvents TxtLatinName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtAccName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtAccNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblCode As Label
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtItemPicture As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class

