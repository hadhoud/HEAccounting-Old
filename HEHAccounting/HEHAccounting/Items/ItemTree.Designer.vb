<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemTree
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
        Me.components = New System.ComponentModel.Container()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.TreeGroups = New Telerik.WinControls.UI.RadTreeView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtItems = New Telerik.WinControls.UI.RadTextBox()
        Me.GridItemsGroups = New Telerik.WinControls.UI.RadGridView()
        Me.TxtGroupSearch = New Telerik.WinControls.UI.RadTextBox()
        Me.RadContextMenuManager1 = New Telerik.WinControls.UI.RadContextMenuManager()
        Me.ContextGrid = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        CType(Me.TreeGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridItemsGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridItemsGroups.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtGroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeGroups
        '
        Me.TreeGroups.AllowAdd = True
        Me.TreeGroups.AllowDragDrop = True
        Me.TreeGroups.AllowDrop = True
        Me.TreeGroups.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeGroups.Cursor = System.Windows.Forms.Cursors.Default
        Me.TreeGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeGroups.DropHintColor = System.Drawing.Color.Yellow
        Me.TreeGroups.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeGroups.ForeColor = System.Drawing.Color.Black
        Me.TreeGroups.ItemHeight = 30
        Me.TreeGroups.LineColor = System.Drawing.Color.DarkOrange
        Me.TreeGroups.Location = New System.Drawing.Point(434, 33)
        Me.TreeGroups.Name = "TreeGroups"
        Me.TreeGroups.ShowDragHint = False
        Me.TreeGroups.ShowDropHint = False
        Me.TreeGroups.ShowExpandCollapse = False
        Me.TreeGroups.ShowLines = True
        Me.TreeGroups.Size = New System.Drawing.Size(200, 417)
        Me.TreeGroups.SpacingBetweenNodes = 4
        Me.TreeGroups.TabIndex = 0
        Me.TreeGroups.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TreeGroups, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtItems, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtGroupSearch, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GridItemsGroups, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(637, 453)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TxtItems
        '
        Me.TxtItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtItems.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItems.Location = New System.Drawing.Point(3, 3)
        Me.TxtItems.Name = "TxtItems"
        Me.TxtItems.Size = New System.Drawing.Size(425, 24)
        Me.TxtItems.TabIndex = 3
        Me.TxtItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GridItemsGroups
        '
        Me.GridItemsGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItemsGroups.Location = New System.Drawing.Point(3, 33)
        '
        '
        '
        Me.GridItemsGroups.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.GridItemsGroups.Name = "GridItemsGroups"
        Me.GridItemsGroups.Size = New System.Drawing.Size(425, 417)
        Me.GridItemsGroups.TabIndex = 1
        '
        'TxtGroupSearch
        '
        Me.TxtGroupSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtGroupSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGroupSearch.Location = New System.Drawing.Point(434, 3)
        Me.TxtGroupSearch.Name = "TxtGroupSearch"
        Me.TxtGroupSearch.Size = New System.Drawing.Size(200, 24)
        Me.TxtGroupSearch.TabIndex = 2
        Me.TxtGroupSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ItemTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 453)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ItemTree"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "دليل الأصناف"
        Me.ThemeName = "Office2010Blue"
        CType(Me.TreeGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridItemsGroups.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridItemsGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtGroupSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeGroups As Telerik.WinControls.UI.RadTreeView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GridItemsGroups As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadContextMenuManager1 As Telerik.WinControls.UI.RadContextMenuManager
    Friend WithEvents ContextGrid As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents TxtItems As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtGroupSearch As Telerik.WinControls.UI.RadTextBox
End Class

