<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUsers
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUsers))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TblGridPermissions = New System.Windows.Forms.TableLayoutPanel()
        Me.GridPermissions = New Telerik.WinControls.UI.RadGridView()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnDeselectAll = New Telerik.WinControls.UI.RadButton()
        Me.BtnSelectAll = New Telerik.WinControls.UI.RadButton()
        Me.TblGridUsers = New System.Windows.Forms.TableLayoutPanel()
        Me.GridUsers = New Telerik.WinControls.UI.RadGridView()
        Me.TblUserCommand = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.TblUserDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.DropUserType = New Telerik.WinControls.UI.RadDropDownList()
        Me.LblUserType = New System.Windows.Forms.Label()
        Me.TxtNewUserID = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtFullName = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtUserName = New Telerik.WinControls.UI.RadTextBox()
        Me.LblUserID = New System.Windows.Forms.Label()
        Me.LblFullName = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.BtnSave = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TblGridPermissions.SuspendLayout()
        CType(Me.GridPermissions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPermissions.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnDeselectAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSelectAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblGridUsers.SuspendLayout()
        CType(Me.GridUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridUsers.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblUserCommand.SuspendLayout()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblUserDetails.SuspendLayout()
        CType(Me.DropUserType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNewUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFullName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.68506!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.31494!))
        Me.TableLayoutPanel1.Controls.Add(Me.TblGridPermissions, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TblGridUsers, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TblUserDetails, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.95023!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.04977!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(743, 422)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TblGridPermissions
        '
        Me.TblGridPermissions.ColumnCount = 1
        Me.TblGridPermissions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblGridPermissions.Controls.Add(Me.GridPermissions, 0, 1)
        Me.TblGridPermissions.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TblGridPermissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblGridPermissions.Location = New System.Drawing.Point(1, 173)
        Me.TblGridPermissions.Margin = New System.Windows.Forms.Padding(0)
        Me.TblGridPermissions.Name = "TblGridPermissions"
        Me.TblGridPermissions.RowCount = 2
        Me.TblGridPermissions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.08197!))
        Me.TblGridPermissions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.91803!))
        Me.TblGridPermissions.Size = New System.Drawing.Size(462, 248)
        Me.TblGridPermissions.TabIndex = 3
        '
        'GridPermissions
        '
        Me.GridPermissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPermissions.Location = New System.Drawing.Point(3, 52)
        '
        '
        '
        Me.GridPermissions.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridPermissions.Name = "GridPermissions"
        Me.GridPermissions.Size = New System.Drawing.Size(456, 193)
        Me.GridPermissions.TabIndex = 2
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.BtnDeselectAll, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnSelectAll, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(456, 43)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'BtnDeselectAll
        '
        Me.BtnDeselectAll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeselectAll.Image = Global.HEHAccounting.My.Resources.Resources.Deselect
        Me.BtnDeselectAll.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnDeselectAll.Location = New System.Drawing.Point(221, 3)
        Me.BtnDeselectAll.Name = "BtnDeselectAll"
        Me.BtnDeselectAll.Size = New System.Drawing.Size(113, 36)
        Me.BtnDeselectAll.TabIndex = 2
        Me.BtnDeselectAll.Tag = "Save"
        Me.BtnDeselectAll.Text = "إلغاء التحديد"
        Me.BtnDeselectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnSelectAll
        '
        Me.BtnSelectAll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelectAll.Image = Global.HEHAccounting.My.Resources.Resources._Select
        Me.BtnSelectAll.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSelectAll.Location = New System.Drawing.Point(340, 3)
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.Size = New System.Drawing.Size(113, 36)
        Me.BtnSelectAll.TabIndex = 1
        Me.BtnSelectAll.Tag = ""
        Me.BtnSelectAll.Text = "تحديد الجميع"
        Me.BtnSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TblGridUsers
        '
        Me.TblGridUsers.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TblGridUsers, 2)
        Me.TblGridUsers.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblGridUsers.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TblGridUsers.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TblGridUsers.Controls.Add(Me.GridUsers, 0, 0)
        Me.TblGridUsers.Controls.Add(Me.TblUserCommand, 1, 0)
        Me.TblGridUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblGridUsers.Location = New System.Drawing.Point(1, 1)
        Me.TblGridUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.TblGridUsers.Name = "TblGridUsers"
        Me.TblGridUsers.RowCount = 1
        Me.TblGridUsers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblGridUsers.Size = New System.Drawing.Size(741, 171)
        Me.TblGridUsers.TabIndex = 4
        '
        'GridUsers
        '
        Me.GridUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridUsers.Location = New System.Drawing.Point(116, 3)
        '
        '
        '
        Me.GridUsers.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.GridUsers.Name = "GridUsers"
        Me.GridUsers.Size = New System.Drawing.Size(622, 165)
        Me.GridUsers.TabIndex = 1
        '
        'TblUserCommand
        '
        Me.TblUserCommand.ColumnCount = 1
        Me.TblUserCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TblUserCommand.Controls.Add(Me.BtnEdit, 0, 0)
        Me.TblUserCommand.Controls.Add(Me.BtnDelete, 0, 1)
        Me.TblUserCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblUserCommand.Location = New System.Drawing.Point(3, 3)
        Me.TblUserCommand.Name = "TblUserCommand"
        Me.TblUserCommand.RowCount = 3
        Me.TblUserCommand.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TblUserCommand.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TblUserCommand.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblUserCommand.Size = New System.Drawing.Size(107, 165)
        Me.TblUserCommand.TabIndex = 2
        '
        'BtnEdit
        '
        Me.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.HEHAccounting.My.Resources.Resources.feedback
        Me.BtnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(0, 3)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(104, 38)
        Me.BtnEdit.TabIndex = 3
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnDelete
        '
        Me.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BtnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(0, 47)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(104, 38)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TblUserDetails
        '
        Me.TblUserDetails.ColumnCount = 2
        Me.TblUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblUserDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblUserDetails.Controls.Add(Me.DropUserType, 1, 6)
        Me.TblUserDetails.Controls.Add(Me.LblUserType, 0, 6)
        Me.TblUserDetails.Controls.Add(Me.TxtNewUserID, 1, 1)
        Me.TblUserDetails.Controls.Add(Me.TxtFullName, 1, 2)
        Me.TblUserDetails.Controls.Add(Me.TxtUserName, 1, 3)
        Me.TblUserDetails.Controls.Add(Me.LblUserID, 0, 1)
        Me.TblUserDetails.Controls.Add(Me.LblFullName, 0, 2)
        Me.TblUserDetails.Controls.Add(Me.LblUserName, 0, 3)
        Me.TblUserDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblUserDetails.Location = New System.Drawing.Point(467, 176)
        Me.TblUserDetails.Name = "TblUserDetails"
        Me.TblUserDetails.RowCount = 8
        Me.TblUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TblUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TblUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TblUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TblUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TblUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TblUserDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblUserDetails.Size = New System.Drawing.Size(272, 242)
        Me.TblUserDetails.TabIndex = 5
        '
        'DropUserType
        '
        Me.DropUserType.BackColor = System.Drawing.Color.White
        Me.DropUserType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropUserType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropUserType.Location = New System.Drawing.Point(3, 154)
        Me.DropUserType.MaxLength = 65535
        Me.DropUserType.Name = "DropUserType"
        Me.DropUserType.Size = New System.Drawing.Size(179, 24)
        Me.DropUserType.TabIndex = 24
        Me.DropUserType.ThemeName = "Office2010Blue"
        '
        'LblUserType
        '
        Me.LblUserType.AutoSize = True
        Me.LblUserType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUserType.Location = New System.Drawing.Point(188, 151)
        Me.LblUserType.Name = "LblUserType"
        Me.LblUserType.Size = New System.Drawing.Size(81, 30)
        Me.LblUserType.TabIndex = 23
        Me.LblUserType.Text = "نوع المستخدم"
        Me.LblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNewUserID
        '
        Me.TxtNewUserID.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNewUserID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNewUserID.Enabled = False
        Me.TxtNewUserID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNewUserID.Location = New System.Drawing.Point(3, 64)
        Me.TxtNewUserID.Name = "TxtNewUserID"
        Me.TxtNewUserID.ShortcutsEnabled = False
        Me.TxtNewUserID.Size = New System.Drawing.Size(179, 24)
        Me.TxtNewUserID.TabIndex = 6
        Me.TxtNewUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNewUserID.ThemeName = "Office2010Blue"
        '
        'TxtFullName
        '
        Me.TxtFullName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFullName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFullName.Location = New System.Drawing.Point(3, 94)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.ShortcutsEnabled = False
        Me.TxtFullName.ShowClearButton = True
        Me.TxtFullName.Size = New System.Drawing.Size(179, 24)
        Me.TxtFullName.TabIndex = 7
        Me.TxtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtFullName.ThemeName = "Office2010Blue"
        '
        'TxtUserName
        '
        Me.TxtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Location = New System.Drawing.Point(3, 124)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.ShortcutsEnabled = False
        Me.TxtUserName.ShowClearButton = True
        Me.TxtUserName.Size = New System.Drawing.Size(179, 24)
        Me.TxtUserName.TabIndex = 8
        Me.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtUserName.ThemeName = "Office2010Blue"
        '
        'LblUserID
        '
        Me.LblUserID.AutoSize = True
        Me.LblUserID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUserID.Location = New System.Drawing.Point(188, 61)
        Me.LblUserID.Name = "LblUserID"
        Me.LblUserID.Size = New System.Drawing.Size(81, 30)
        Me.LblUserID.TabIndex = 20
        Me.LblUserID.Text = "كود"
        Me.LblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFullName
        '
        Me.LblFullName.AutoSize = True
        Me.LblFullName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFullName.Location = New System.Drawing.Point(188, 91)
        Me.LblFullName.Name = "LblFullName"
        Me.LblFullName.Size = New System.Drawing.Size(81, 30)
        Me.LblFullName.TabIndex = 21
        Me.LblFullName.Text = "الإسم الثلاثي"
        Me.LblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUserName.Location = New System.Drawing.Point(188, 121)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(81, 30)
        Me.LblUserName.TabIndex = 22
        Me.LblUserName.Text = "إسم المستخدم"
        Me.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnClose, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSave, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 422)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(743, 45)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(265, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(104, 36)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSave.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSave.Location = New System.Drawing.Point(375, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(103, 36)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Tag = "Save"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'AddUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 467)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddUsers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "مستحدمين"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TblGridPermissions.ResumeLayout(False)
        CType(Me.GridPermissions.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPermissions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnDeselectAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSelectAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblGridUsers.ResumeLayout(False)
        CType(Me.GridUsers.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblUserCommand.ResumeLayout(False)
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblUserDetails.ResumeLayout(False)
        Me.TblUserDetails.PerformLayout()
        CType(Me.DropUserType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNewUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFullName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUserName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GridUsers As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSave As Telerik.WinControls.UI.RadButton
    Friend WithEvents GridPermissions As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TblGridPermissions As TableLayoutPanel
    Friend WithEvents TblGridUsers As TableLayoutPanel
    Friend WithEvents TblUserDetails As TableLayoutPanel
    Friend WithEvents TxtNewUserID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtFullName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtUserName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblUserID As Label
    Friend WithEvents LblFullName As Label
    Friend WithEvents LblUserName As Label
    Friend WithEvents LblUserType As Label
    Friend WithEvents DropUserType As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TblUserCommand As TableLayoutPanel
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnDeselectAll As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSelectAll As Telerik.WinControls.UI.RadButton
End Class

