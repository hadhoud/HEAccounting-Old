<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Groups
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Groups))
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.GridGroups = New Telerik.WinControls.UI.RadGridView()
        Me.LblGroupName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtGroupName = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtGroupDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.LblNote = New System.Windows.Forms.Label()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.RadContextMenu1 = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.ConMnuEdit = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadContextMenuManager1 = New Telerik.WinControls.UI.RadContextMenuManager()
        CType(Me.GridGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridGroups.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtGroupName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtGroupDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridGroups
        '
        Me.GridGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGroups.Location = New System.Drawing.Point(0, 57)
        '
        '
        '
        Me.GridGroups.MasterTemplate.AllowCellContextMenu = False
        Me.GridGroups.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridGroups.Name = "GridGroups"
        Me.RadContextMenuManager1.SetRadContextMenu(Me.GridGroups, Me.RadContextMenu1)
        Me.GridGroups.Size = New System.Drawing.Size(619, 310)
        Me.GridGroups.TabIndex = 7
        '
        'LblGroupName
        '
        Me.LblGroupName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGroupName.Location = New System.Drawing.Point(474, 0)
        Me.LblGroupName.Name = "LblGroupName"
        Me.LblGroupName.Size = New System.Drawing.Size(142, 24)
        Me.LblGroupName.TabIndex = 65
        Me.LblGroupName.Text = "إسم المجوعة"
        Me.LblGroupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtGroupName, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtGroupDesc, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblNote, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblGroupName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAdd, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSearch, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(619, 57)
        Me.TableLayoutPanel1.TabIndex = 68
        '
        'TxtGroupName
        '
        Me.TxtGroupName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGroupName.Location = New System.Drawing.Point(463, 27)
        Me.TxtGroupName.Name = "TxtGroupName"
        Me.TxtGroupName.ShowClearButton = True
        Me.TxtGroupName.Size = New System.Drawing.Size(153, 24)
        Me.TxtGroupName.TabIndex = 0
        Me.TxtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtGroupName.ThemeName = "Office2010Blue"
        '
        'TxtGroupDesc
        '
        Me.TxtGroupDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtGroupDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGroupDesc.Location = New System.Drawing.Point(306, 27)
        Me.TxtGroupDesc.Name = "TxtGroupDesc"
        Me.TxtGroupDesc.ShowClearButton = True
        Me.TxtGroupDesc.Size = New System.Drawing.Size(151, 24)
        Me.TxtGroupDesc.TabIndex = 1
        Me.TxtGroupDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtGroupDesc.ThemeName = "Office2010Blue"
        '
        'LblNote
        '
        Me.LblNote.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNote.Location = New System.Drawing.Point(306, 0)
        Me.LblNote.Name = "LblNote"
        Me.LblNote.Size = New System.Drawing.Size(151, 24)
        Me.LblNote.TabIndex = 65
        Me.LblNote.Text = "ملاحظات"
        Me.LblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.HEHAccounting.My.Resources.Resources.Create
        Me.BtnAdd.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Location = New System.Drawing.Point(146, 10)
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
        Me.BtnSearch.Location = New System.Drawing.Point(53, 10)
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
        'Groups
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 367)
        Me.Controls.Add(Me.GridGroups)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Groups"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "المجموعات"
        Me.ThemeName = "Office2010Blue"
        CType(Me.GridGroups.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtGroupName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtGroupDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents GridGroups As Telerik.WinControls.UI.RadGridView
    Friend WithEvents LblGroupName As Label
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtGroupName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtGroupDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblNote As Label
    Friend WithEvents RadContextMenu1 As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents ConMnuEdit As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadContextMenuManager1 As Telerik.WinControls.UI.RadContextMenuManager
End Class

