<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashDrawers
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashDrawers))
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.GridCashDrawers = New Telerik.WinControls.UI.RadGridView()
        Me.LblDrawerName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtDrawerName = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtDrawerDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.LblDrawerDesc = New System.Windows.Forms.Label()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.RadContextMenu1 = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.ConMnuEdit = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadContextMenuManager1 = New Telerik.WinControls.UI.RadContextMenuManager()
        CType(Me.GridCashDrawers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCashDrawers.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtDrawerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDrawerDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridCashDrawers
        '
        Me.GridCashDrawers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCashDrawers.Location = New System.Drawing.Point(0, 57)
        '
        '
        '
        Me.GridCashDrawers.MasterTemplate.AllowCellContextMenu = False
        Me.GridCashDrawers.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridCashDrawers.Name = "GridCashDrawers"
        Me.RadContextMenuManager1.SetRadContextMenu(Me.GridCashDrawers, Me.RadContextMenu1)
        Me.GridCashDrawers.Size = New System.Drawing.Size(619, 310)
        Me.GridCashDrawers.TabIndex = 7
        '
        'LblDrawerName
        '
        Me.LblDrawerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDrawerName.Location = New System.Drawing.Point(474, 0)
        Me.LblDrawerName.Name = "LblDrawerName"
        Me.LblDrawerName.Size = New System.Drawing.Size(142, 24)
        Me.LblDrawerName.TabIndex = 65
        Me.LblDrawerName.Text = "إسم الصندوق"
        Me.LblDrawerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtDrawerName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtDrawerDesc, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDrawerDesc, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDrawerName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAdd, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSearch, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(619, 57)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'TxtDrawerName
        '
        Me.TxtDrawerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDrawerName.Location = New System.Drawing.Point(463, 27)
        Me.TxtDrawerName.Name = "TxtDrawerName"
        Me.TxtDrawerName.ShowClearButton = True
        Me.TxtDrawerName.Size = New System.Drawing.Size(153, 24)
        Me.TxtDrawerName.TabIndex = 0
        Me.TxtDrawerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDrawerName.ThemeName = "Office2010Blue"
        '
        'TxtDrawerDesc
        '
        Me.TxtDrawerDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDrawerDesc.Location = New System.Drawing.Point(306, 27)
        Me.TxtDrawerDesc.Name = "TxtDrawerDesc"
        Me.TxtDrawerDesc.ShowClearButton = True
        Me.TxtDrawerDesc.Size = New System.Drawing.Size(151, 24)
        Me.TxtDrawerDesc.TabIndex = 1
        Me.TxtDrawerDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDrawerDesc.ThemeName = "Office2010Blue"
        '
        'LblDrawerDesc
        '
        Me.LblDrawerDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDrawerDesc.Location = New System.Drawing.Point(306, 0)
        Me.LblDrawerDesc.Name = "LblDrawerDesc"
        Me.LblDrawerDesc.Size = New System.Drawing.Size(151, 24)
        Me.LblDrawerDesc.TabIndex = 65
        Me.LblDrawerDesc.Text = "ملاحظات"
        Me.LblDrawerDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.HEHAccounting.My.Resources.Resources.Create
        Me.BtnAdd.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Location = New System.Drawing.Point(136, 10)
        Me.BtnAdd.Name = "BtnAdd"
        Me.TableLayoutPanel1.SetRowSpan(Me.BtnAdd, 2)
        Me.BtnAdd.Size = New System.Drawing.Size(83, 36)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Tag = "Add"
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSearch.Location = New System.Drawing.Point(42, 10)
        Me.BtnSearch.Name = "BtnSearch"
        Me.TableLayoutPanel1.SetRowSpan(Me.BtnSearch, 2)
        Me.BtnSearch.Size = New System.Drawing.Size(83, 36)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RadContextMenu1
        '
        Me.RadContextMenu1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.ConMnuEdit})
        '
        'ConMnuEdit
        '
        Me.ConMnuEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConMnuEdit.Name = "ConMnuEdit"
        Me.ConMnuEdit.Text = "تعديل"
        '
        'CashDrawers
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 367)
        Me.Controls.Add(Me.GridCashDrawers)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CashDrawers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "الصناديق"
        Me.ThemeName = "Office2010Blue"
        CType(Me.GridCashDrawers.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCashDrawers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtDrawerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDrawerDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents GridCashDrawers As Telerik.WinControls.UI.RadGridView
    Friend WithEvents LblDrawerName As Label
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtDrawerName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtDrawerDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblDrawerDesc As Label
    Friend WithEvents RadContextMenu1 As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents ConMnuEdit As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadContextMenuManager1 As Telerik.WinControls.UI.RadContextMenuManager
End Class

