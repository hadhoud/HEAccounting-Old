'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Friend Class Items


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
    Private components As System.ComponentModel.IContainer = Nothing

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items))
        Me.GridItems = New Telerik.WinControls.UI.RadGridView()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.LblBarCode = New System.Windows.Forms.Label()
        Me.TxtItemName = New Telerik.WinControls.UI.RadTextBox()
        Me.LblItemId = New System.Windows.Forms.Label()
        Me.TxtItemBarcode = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtItemid = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnNew = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.BtnRefrech = New Telerik.WinControls.UI.RadButton()
        CType(Me.GridItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridItems.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridItems
        '
        Me.GridItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridItems.Location = New System.Drawing.Point(255, 0)
        '
        '
        '
        Me.GridItems.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridItems.Name = "GridItems"
        Me.GridItems.Size = New System.Drawing.Size(80, 515)
        Me.GridItems.TabIndex = 11
        Me.GridItems.ThemeName = "Office2010Blue"
        '
        'PnlOptions
        '
        Me.PnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel2)
        Me.PnlOptions.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlOptions.Location = New System.Drawing.Point(0, 0)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(255, 515)
        Me.PnlOptions.TabIndex = 2
        Me.PnlOptions.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnFiltering, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnReset, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 271)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(249, 53)
        Me.TableLayoutPanel3.TabIndex = 16
        '
        'BtnFiltering
        '
        Me.BtnFiltering.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFiltering.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFiltering.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnFiltering.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltering.Location = New System.Drawing.Point(142, 3)
        Me.BtnFiltering.Name = "BtnFiltering"
        Me.BtnFiltering.Size = New System.Drawing.Size(90, 36)
        Me.BtnFiltering.TabIndex = 16
        Me.BtnFiltering.Text = "بحث"
        Me.BtnFiltering.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Image = Global.HEHAccounting.My.Resources.Resources.Redo
        Me.BtnReset.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnReset.Location = New System.Drawing.Point(18, 3)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(90, 36)
        Me.BtnReset.TabIndex = 8
        Me.BtnReset.Text = "تصفير"
        Me.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.LblItemName, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblBarCode, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtItemName, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblItemId, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtItemBarcode, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtItemid, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 141)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 130)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'LblItemName
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblItemName.Location = New System.Drawing.Point(177, 80)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(69, 30)
        Me.LblItemName.TabIndex = 18
        Me.LblItemName.Text = "إسم الصنف"
        Me.LblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBarCode
        '
        Me.LblBarCode.AutoSize = True
        Me.LblBarCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblBarCode.Location = New System.Drawing.Point(177, 20)
        Me.LblBarCode.Name = "LblBarCode"
        Me.LblBarCode.Size = New System.Drawing.Size(69, 30)
        Me.LblBarCode.TabIndex = 17
        Me.LblBarCode.Text = "الباركود"
        Me.LblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtItemName
        '
        Me.TxtItemName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.Location = New System.Drawing.Point(3, 83)
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.ShowClearButton = True
        Me.TxtItemName.Size = New System.Drawing.Size(168, 24)
        Me.TxtItemName.TabIndex = 6
        Me.TxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemName.ThemeName = "Office2010Blue"
        '
        'LblItemId
        '
        Me.LblItemId.AutoSize = True
        Me.LblItemId.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblItemId.Location = New System.Drawing.Point(177, 50)
        Me.LblItemId.Name = "LblItemId"
        Me.LblItemId.Size = New System.Drawing.Size(69, 30)
        Me.LblItemId.TabIndex = 17
        Me.LblItemId.Text = "كود الصنف"
        Me.LblItemId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtItemBarcode
        '
        Me.TxtItemBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtItemBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemBarcode.Location = New System.Drawing.Point(3, 23)
        Me.TxtItemBarcode.Name = "TxtItemBarcode"
        Me.TxtItemBarcode.ShowClearButton = True
        Me.TxtItemBarcode.Size = New System.Drawing.Size(168, 24)
        Me.TxtItemBarcode.TabIndex = 4
        Me.TxtItemBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemBarcode.ThemeName = "Office2010Blue"
        '
        'TxtItemid
        '
        Me.TxtItemid.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtItemid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemid.Location = New System.Drawing.Point(3, 53)
        Me.TxtItemid.Name = "TxtItemid"
        Me.TxtItemid.ShowClearButton = True
        Me.TxtItemid.Size = New System.Drawing.Size(168, 24)
        Me.TxtItemid.TabIndex = 5
        Me.TxtItemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemid.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnNew, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnEdit, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnDelete, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnRefrech, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(249, 138)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.Image = Global.HEHAccounting.My.Resources.Resources.Creates
        Me.BtnNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(142, 23)
        Me.BtnNew.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(90, 36)
        Me.BtnNew.TabIndex = 0
        Me.BtnNew.Text = "جديد"
        Me.BtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.HEHAccounting.My.Resources.Resources.feedback
        Me.BtnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(18, 23)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(90, 36)
        Me.BtnEdit.TabIndex = 1
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(142, 79)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(90, 36)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnRefrech
        '
        Me.BtnRefrech.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRefrech.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRefrech.Image = Global.HEHAccounting.My.Resources.Resources.Sync
        Me.BtnRefrech.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnRefrech.Location = New System.Drawing.Point(18, 79)
        Me.BtnRefrech.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.BtnRefrech.Name = "BtnRefrech"
        Me.BtnRefrech.Size = New System.Drawing.Size(90, 36)
        Me.BtnRefrech.TabIndex = 3
        Me.BtnRefrech.Text = "تحديث"
        Me.BtnRefrech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Items
        '
        Me.AcceptButton = Me.BtnFiltering
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.BtnReset
        Me.ClientSize = New System.Drawing.Size(335, 515)
        Me.Controls.Add(Me.GridItems)
        Me.Controls.Add(Me.PnlOptions)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Items"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Tag = "Items"
        Me.Text = "الأصناف"
        CType(Me.GridItems.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend GridItems As Telerik.WinControls.UI.RadGridView
    Friend PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TxtItemName As Telerik.WinControls.UI.RadTextBox
    Friend TxtItemid As Telerik.WinControls.UI.RadTextBox
    Friend BtnDelete As Telerik.WinControls.UI.RadButton
    Friend BtnEdit As Telerik.WinControls.UI.RadButton
    Friend BtnNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnRefrech As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LblItemName As Label
    Friend WithEvents LblItemId As Label
    Friend WithEvents LblBarCode As Label
    Friend WithEvents TxtItemBarcode As Telerik.WinControls.UI.RadTextBox
End Class

