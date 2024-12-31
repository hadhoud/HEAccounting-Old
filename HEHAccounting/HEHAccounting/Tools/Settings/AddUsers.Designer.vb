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
        Me.btnNewUser = New Telerik.WinControls.UI.RadButton()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.TblUserDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.DropUserType = New Telerik.WinControls.UI.RadDropDownList()
        Me.LblUserType = New System.Windows.Forms.Label()
        Me.TxtNewUserID = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtFullName = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtUserName = New Telerik.WinControls.UI.RadTextBox()
        Me.LblUserID = New System.Windows.Forms.Label()
        Me.LblFullName = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblPermissions = New System.Windows.Forms.Label()
        Me.chkShowHomeForm = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkShowDashboardForm = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkShowSalesDailyWin = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkShowItemsSalesWinReport = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkShowProfitsTextInScreen = New Telerik.WinControls.UI.RadCheckBox()
        Me.chkShowPurchasingPriceInProg = New Telerik.WinControls.UI.RadCheckBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.BtnSave = New Telerik.WinControls.UI.RadButton()
        Me.chkShowJemliSellingPriceInProg = New Telerik.WinControls.UI.RadCheckBox()
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
        CType(Me.btnNewUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblUserDetails.SuspendLayout()
        CType(Me.DropUserType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNewUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFullName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.chkShowHomeForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowDashboardForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowSalesDailyWin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowItemsSalesWinReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowProfitsTextInScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowPurchasingPriceInProg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkShowJemliSellingPriceInProg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.62806!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.37194!))
        Me.TableLayoutPanel1.Controls.Add(Me.TblGridPermissions, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TblGridUsers, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.20428!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.79572!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(899, 422)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TblGridPermissions
        '
        Me.TblGridPermissions.ColumnCount = 1
        Me.TblGridPermissions.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblGridPermissions.Controls.Add(Me.GridPermissions, 0, 1)
        Me.TblGridPermissions.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TblGridPermissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblGridPermissions.Location = New System.Drawing.Point(1, 145)
        Me.TblGridPermissions.Margin = New System.Windows.Forms.Padding(0)
        Me.TblGridPermissions.Name = "TblGridPermissions"
        Me.TblGridPermissions.RowCount = 2
        Me.TblGridPermissions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.08197!))
        Me.TblGridPermissions.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.91803!))
        Me.TblGridPermissions.Size = New System.Drawing.Size(604, 276)
        Me.TblGridPermissions.TabIndex = 3
        '
        'GridPermissions
        '
        Me.GridPermissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPermissions.Location = New System.Drawing.Point(3, 58)
        '
        '
        '
        Me.GridPermissions.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridPermissions.Name = "GridPermissions"
        Me.GridPermissions.Size = New System.Drawing.Size(598, 215)
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(598, 49)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'BtnDeselectAll
        '
        Me.BtnDeselectAll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeselectAll.Image = Global.HEHAccounting.My.Resources.Resources.Deselect
        Me.BtnDeselectAll.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnDeselectAll.Location = New System.Drawing.Point(363, 3)
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
        Me.BtnSelectAll.Location = New System.Drawing.Point(482, 3)
        Me.BtnSelectAll.Name = "BtnSelectAll"
        Me.BtnSelectAll.Size = New System.Drawing.Size(113, 36)
        Me.BtnSelectAll.TabIndex = 1
        Me.BtnSelectAll.Tag = ""
        Me.BtnSelectAll.Text = "تحديد الجميع"
        Me.BtnSelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TblGridUsers
        '
        Me.TblGridUsers.ColumnCount = 3
        Me.TableLayoutPanel1.SetColumnSpan(Me.TblGridUsers, 2)
        Me.TblGridUsers.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249.0!))
        Me.TblGridUsers.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblGridUsers.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.TblGridUsers.Controls.Add(Me.GridUsers, 1, 0)
        Me.TblGridUsers.Controls.Add(Me.TblUserCommand, 2, 0)
        Me.TblGridUsers.Controls.Add(Me.TblUserDetails, 0, 0)
        Me.TblGridUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblGridUsers.Location = New System.Drawing.Point(1, 1)
        Me.TblGridUsers.Margin = New System.Windows.Forms.Padding(0)
        Me.TblGridUsers.Name = "TblGridUsers"
        Me.TblGridUsers.RowCount = 1
        Me.TblGridUsers.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblGridUsers.Size = New System.Drawing.Size(897, 143)
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
        Me.GridUsers.Size = New System.Drawing.Size(529, 137)
        Me.GridUsers.TabIndex = 1
        '
        'TblUserCommand
        '
        Me.TblUserCommand.ColumnCount = 1
        Me.TblUserCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TblUserCommand.Controls.Add(Me.btnNewUser, 0, 0)
        Me.TblUserCommand.Controls.Add(Me.BtnDelete, 0, 2)
        Me.TblUserCommand.Controls.Add(Me.BtnEdit, 0, 1)
        Me.TblUserCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblUserCommand.Location = New System.Drawing.Point(3, 3)
        Me.TblUserCommand.Name = "TblUserCommand"
        Me.TblUserCommand.RowCount = 3
        Me.TblUserCommand.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TblUserCommand.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TblUserCommand.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblUserCommand.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TblUserCommand.Size = New System.Drawing.Size(107, 137)
        Me.TblUserCommand.TabIndex = 2
        '
        'btnNewUser
        '
        Me.btnNewUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewUser.Image = Global.HEHAccounting.My.Resources.Resources.page_white_add
        Me.btnNewUser.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNewUser.Location = New System.Drawing.Point(0, 3)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(104, 38)
        Me.btnNewUser.TabIndex = 5
        Me.btnNewUser.Text = "جديد"
        Me.btnNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(0, 91)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(104, 38)
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.HEHAccounting.My.Resources.Resources.feedback
        Me.BtnEdit.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(0, 47)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(104, 38)
        Me.BtnEdit.TabIndex = 3
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.TblUserDetails.Location = New System.Drawing.Point(651, 3)
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
        Me.TblUserDetails.Size = New System.Drawing.Size(243, 137)
        Me.TblUserDetails.TabIndex = 5
        '
        'DropUserType
        '
        Me.DropUserType.BackColor = System.Drawing.Color.White
        Me.DropUserType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropUserType.DropDownAnimationEnabled = True
        Me.DropUserType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropUserType.Location = New System.Drawing.Point(3, 101)
        Me.DropUserType.MaxLength = 65535
        Me.DropUserType.Name = "DropUserType"
        Me.DropUserType.Size = New System.Drawing.Size(150, 24)
        Me.DropUserType.TabIndex = 24
        Me.DropUserType.ThemeName = "Office2010Blue"
        '
        'LblUserType
        '
        Me.LblUserType.AutoSize = True
        Me.LblUserType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUserType.Location = New System.Drawing.Point(159, 98)
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
        Me.TxtNewUserID.Location = New System.Drawing.Point(3, 11)
        Me.TxtNewUserID.Name = "TxtNewUserID"
        Me.TxtNewUserID.ShortcutsEnabled = False
        Me.TxtNewUserID.Size = New System.Drawing.Size(150, 24)
        Me.TxtNewUserID.TabIndex = 6
        Me.TxtNewUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNewUserID.ThemeName = "Office2010Blue"
        '
        'TxtFullName
        '
        Me.TxtFullName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFullName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFullName.Location = New System.Drawing.Point(3, 41)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.ShortcutsEnabled = False
        Me.TxtFullName.ShowClearButton = True
        Me.TxtFullName.Size = New System.Drawing.Size(150, 24)
        Me.TxtFullName.TabIndex = 7
        Me.TxtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtFullName.ThemeName = "Office2010Blue"
        '
        'TxtUserName
        '
        Me.TxtUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.Location = New System.Drawing.Point(3, 71)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.ShortcutsEnabled = False
        Me.TxtUserName.ShowClearButton = True
        Me.TxtUserName.Size = New System.Drawing.Size(150, 24)
        Me.TxtUserName.TabIndex = 8
        Me.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtUserName.ThemeName = "Office2010Blue"
        '
        'LblUserID
        '
        Me.LblUserID.AutoSize = True
        Me.LblUserID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblUserID.Location = New System.Drawing.Point(159, 8)
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
        Me.LblFullName.Location = New System.Drawing.Point(159, 38)
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
        Me.LblUserName.Location = New System.Drawing.Point(159, 68)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(81, 30)
        Me.LblUserName.TabIndex = 22
        Me.LblUserName.Text = "إسم المستخدم"
        Me.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lblPermissions)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowHomeForm)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowDashboardForm)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowSalesDailyWin)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowItemsSalesWinReport)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowProfitsTextInScreen)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowPurchasingPriceInProg)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowJemliSellingPriceInProg)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(609, 148)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(286, 270)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'lblPermissions
        '
        Me.lblPermissions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPermissions.Location = New System.Drawing.Point(-24, 0)
        Me.lblPermissions.Name = "lblPermissions"
        Me.lblPermissions.Size = New System.Drawing.Size(307, 23)
        Me.lblPermissions.TabIndex = 47
        Me.lblPermissions.Text = "الصلاحيات"
        Me.lblPermissions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkShowHomeForm
        '
        Me.chkShowHomeForm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowHomeForm.Location = New System.Drawing.Point(147, 26)
        Me.chkShowHomeForm.Name = "chkShowHomeForm"
        Me.chkShowHomeForm.Size = New System.Drawing.Size(136, 22)
        Me.chkShowHomeForm.TabIndex = 9
        Me.chkShowHomeForm.Text = "إظهار شاشة الرئيسية"
        Me.chkShowHomeForm.ThemeName = "Office2010Blue"
        '
        'chkShowDashboardForm
        '
        Me.chkShowDashboardForm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowDashboardForm.Location = New System.Drawing.Point(143, 54)
        Me.chkShowDashboardForm.Name = "chkShowDashboardForm"
        Me.chkShowDashboardForm.Size = New System.Drawing.Size(140, 22)
        Me.chkShowDashboardForm.TabIndex = 7
        Me.chkShowDashboardForm.Text = "إظهار شاشة التحليلات"
        Me.chkShowDashboardForm.ThemeName = "Office2010Blue"
        '
        'chkShowSalesDailyWin
        '
        Me.chkShowSalesDailyWin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowSalesDailyWin.Location = New System.Drawing.Point(115, 82)
        Me.chkShowSalesDailyWin.Name = "chkShowSalesDailyWin"
        Me.chkShowSalesDailyWin.Size = New System.Drawing.Size(168, 22)
        Me.chkShowSalesDailyWin.TabIndex = 48
        Me.chkShowSalesDailyWin.Text = "إظهار شاشة أرباح المبيعات"
        Me.chkShowSalesDailyWin.ThemeName = "Office2010Blue"
        '
        'chkShowItemsSalesWinReport
        '
        Me.chkShowItemsSalesWinReport.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowItemsSalesWinReport.Location = New System.Drawing.Point(81, 110)
        Me.chkShowItemsSalesWinReport.Name = "chkShowItemsSalesWinReport"
        Me.chkShowItemsSalesWinReport.Size = New System.Drawing.Size(202, 22)
        Me.chkShowItemsSalesWinReport.TabIndex = 9
        Me.chkShowItemsSalesWinReport.Text = "إظهار شاشة أرباح أصناف مبيعات"
        Me.chkShowItemsSalesWinReport.ThemeName = "Office2010Blue"
        '
        'chkShowProfitsTextInScreen
        '
        Me.chkShowProfitsTextInScreen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowProfitsTextInScreen.Location = New System.Drawing.Point(99, 138)
        Me.chkShowProfitsTextInScreen.Name = "chkShowProfitsTextInScreen"
        Me.chkShowProfitsTextInScreen.Size = New System.Drawing.Size(184, 22)
        Me.chkShowProfitsTextInScreen.TabIndex = 10
        Me.chkShowProfitsTextInScreen.Text = "إظهار مربع الربح في الشاشات"
        Me.chkShowProfitsTextInScreen.ThemeName = "Office2010Blue"
        '
        'chkShowPurchasingPriceInProg
        '
        Me.chkShowPurchasingPriceInProg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowPurchasingPriceInProg.Location = New System.Drawing.Point(95, 166)
        Me.chkShowPurchasingPriceInProg.Name = "chkShowPurchasingPriceInProg"
        Me.chkShowPurchasingPriceInProg.Size = New System.Drawing.Size(188, 22)
        Me.chkShowPurchasingPriceInProg.TabIndex = 8
        Me.chkShowPurchasingPriceInProg.Text = "إظهار سعر الشراء في الشاشات"
        Me.chkShowPurchasingPriceInProg.ThemeName = "Office2010Blue"
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(899, 45)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(343, 3)
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
        Me.BtnSave.Location = New System.Drawing.Point(453, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(103, 36)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Tag = "Save"
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'chkShowJemliSellingPriceInProg
        '
        Me.chkShowJemliSellingPriceInProg.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShowJemliSellingPriceInProg.Location = New System.Drawing.Point(67, 194)
        Me.chkShowJemliSellingPriceInProg.Name = "chkShowJemliSellingPriceInProg"
        Me.chkShowJemliSellingPriceInProg.Size = New System.Drawing.Size(216, 22)
        Me.chkShowJemliSellingPriceInProg.TabIndex = 49
        Me.chkShowJemliSellingPriceInProg.Text = "إظهار مربع سعر الجملة في الشاشات"
        Me.chkShowJemliSellingPriceInProg.ThemeName = "Office2010Blue"
        '
        'AddUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 467)
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
        CType(Me.btnNewUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblUserDetails.ResumeLayout(False)
        Me.TblUserDetails.PerformLayout()
        CType(Me.DropUserType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNewUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFullName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUserName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.chkShowHomeForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowDashboardForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowSalesDailyWin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowItemsSalesWinReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowProfitsTextInScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowPurchasingPriceInProg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkShowJemliSellingPriceInProg, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblPermissions As Label
    Friend WithEvents chkShowDashboardForm As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkShowPurchasingPriceInProg As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents btnNewUser As Telerik.WinControls.UI.RadButton
    Friend WithEvents chkShowHomeForm As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkShowItemsSalesWinReport As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkShowSalesDailyWin As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkShowProfitsTextInScreen As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents chkShowJemliSellingPriceInProg As Telerik.WinControls.UI.RadCheckBox
End Class

