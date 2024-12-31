<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accounts))
        Me.GridAccounts = New Telerik.WinControls.UI.RadGridView()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtAccName = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtAccNum = New Telerik.WinControls.UI.RadTextBox()
        Me.LblAccNum = New System.Windows.Forms.Label()
        Me.LblِAccName = New System.Windows.Forms.Label()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.BtnAccWithBalance = New Telerik.WinControls.UI.RadToggleButton()
        CType(Me.GridAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAccounts.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.TxtAccName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAccNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAccWithBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridAccounts
        '
        Me.GridAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAccounts.Location = New System.Drawing.Point(3, 61)
        '
        '
        '
        Me.GridAccounts.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridAccounts.Name = "GridAccounts"
        Me.GridAccounts.Size = New System.Drawing.Size(655, 294)
        Me.GridAccounts.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GridAccounts, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(661, 409)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TxtAccName, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtAccNum, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LblAccNum, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LblِAccName, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSearch, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(655, 52)
        Me.TableLayoutPanel2.TabIndex = 69
        '
        'TxtAccName
        '
        Me.TxtAccName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccName.Location = New System.Drawing.Point(342, 27)
        Me.TxtAccName.Name = "TxtAccName"
        Me.TxtAccName.ShowClearButton = True
        Me.TxtAccName.Size = New System.Drawing.Size(153, 24)
        Me.TxtAccName.TabIndex = 0
        Me.TxtAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAccName.ThemeName = "Office2010Blue"
        '
        'TxtAccNum
        '
        Me.TxtAccNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAccNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccNum.Location = New System.Drawing.Point(501, 27)
        Me.TxtAccNum.Name = "TxtAccNum"
        Me.TxtAccNum.ShowClearButton = True
        Me.TxtAccNum.Size = New System.Drawing.Size(151, 24)
        Me.TxtAccNum.TabIndex = 1
        Me.TxtAccNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAccNum.ThemeName = "Office2010Blue"
        '
        'LblAccNum
        '
        Me.LblAccNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAccNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAccNum.Location = New System.Drawing.Point(501, 0)
        Me.LblAccNum.Name = "LblAccNum"
        Me.LblAccNum.Size = New System.Drawing.Size(151, 24)
        Me.LblAccNum.TabIndex = 65
        Me.LblAccNum.Text = "رقم الحساب"
        Me.LblAccNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblِAccName
        '
        Me.LblِAccName.AutoSize = True
        Me.LblِAccName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblِAccName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblِAccName.Location = New System.Drawing.Point(342, 0)
        Me.LblِAccName.Name = "LblِAccName"
        Me.LblِAccName.Size = New System.Drawing.Size(153, 24)
        Me.LblِAccName.TabIndex = 65
        Me.LblِAccName.Text = "إسم الحساب"
        Me.LblِAccName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSearch.Location = New System.Drawing.Point(23, 8)
        Me.BtnSearch.Name = "BtnSearch"
        Me.TableLayoutPanel2.SetRowSpan(Me.BtnSearch, 2)
        Me.BtnSearch.Size = New System.Drawing.Size(83, 36)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnClose, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnAdd, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnEdit, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnAccWithBalance, 2, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 361)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(655, 45)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(31, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(104, 36)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.HEHAccounting.My.Resources.Resources.Create
        Me.BtnAdd.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Location = New System.Drawing.Point(522, 3)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(104, 36)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Tag = "Save"
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.HEHAccounting.My.Resources.Resources.Modify
        Me.BtnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnEdit.Location = New System.Drawing.Point(359, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(104, 36)
        Me.BtnEdit.TabIndex = 38
        Me.BtnEdit.Tag = "Save"
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnAccWithBalance
        '
        Me.BtnAccWithBalance.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnAccWithBalance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAccWithBalance.Image = Global.HEHAccounting.My.Resources.Resources.my_invoices
        Me.BtnAccWithBalance.Location = New System.Drawing.Point(196, 3)
        Me.BtnAccWithBalance.Name = "BtnAccWithBalance"
        Me.BtnAccWithBalance.Size = New System.Drawing.Size(104, 36)
        Me.BtnAccWithBalance.TabIndex = 1
        Me.BtnAccWithBalance.Text = "الأرصدة"
        Me.BtnAccWithBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Accounts
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 409)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Accounts"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "الحسابات"
        Me.ThemeName = "Office2010Blue"
        CType(Me.GridAccounts.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.TxtAccName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAccNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAccWithBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridAccounts As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnAccWithBalance As Telerik.WinControls.UI.RadToggleButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TxtAccName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtAccNum As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblAccNum As Label
    Friend WithEvents LblِAccName As Label
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
End Class

