<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountsDetails
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountsDetails))
        Me.GridAccountsDetails = New Telerik.WinControls.UI.RadGridView()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtAccBalance = New Telerik.WinControls.UI.RadTextBox()
        Me.LblAccBalance = New System.Windows.Forms.Label()
        Me.LblOnHim = New System.Windows.Forms.Label()
        Me.LblForHim = New System.Windows.Forms.Label()
        Me.TxtForHim = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtOnHim = New Telerik.WinControls.UI.RadTextBox()
        Me.LblCorD = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New Telerik.WinControls.UI.RadButton()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtCurrencyVal = New Telerik.WinControls.UI.RadTextBox()
        Me.BtnGetCurrencyVal = New Telerik.WinControls.UI.RadButton()
        Me.LblCurrencyVal = New System.Windows.Forms.Label()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.LblAccounts = New System.Windows.Forms.Label()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.TxtAccounts = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.TxtAccountsBtn = New Telerik.WinControls.UI.RadButtonElement()
        Me.LblCurrency = New System.Windows.Forms.Label()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MskTxtInvDateFrom = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.CheckDateFrom = New Telerik.WinControls.UI.RadCheckBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.MskTxtInvDateTo = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.CheckDateTo = New Telerik.WinControls.UI.RadCheckBox()
        Me.CheckDetailsWithCurrency = New Telerik.WinControls.UI.RadCheckBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContextGrid = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.RadConOpen = New Telerik.WinControls.UI.RadMenuItem()
        Me.ContextManagerGrid = New Telerik.WinControls.UI.RadContextMenuManager()
        CType(Me.GridAccountsDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridAccountsDetails.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.TxtAccBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtForHim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOnHim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.TxtCurrencyVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnGetCurrencyVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDetailsWithCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridAccountsDetails
        '
        Me.GridAccountsDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAccountsDetails.Location = New System.Drawing.Point(5, 5)
        '
        '
        '
        Me.GridAccountsDetails.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridAccountsDetails.Name = "GridAccountsDetails"
        Me.ContextManagerGrid.SetRadContextMenu(Me.GridAccountsDetails, Me.ContextGrid)
        Me.GridAccountsDetails.Size = New System.Drawing.Size(848, 462)
        Me.GridAccountsDetails.TabIndex = 2
        Me.GridAccountsDetails.Visible = False
        '
        'PnlOptions
        '
        Me.PnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel6)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlOptions.Location = New System.Drawing.Point(861, 5)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(237, 462)
        Me.PnlOptions.TabIndex = 3
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.AutoSize = True
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.TxtAccBalance, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.LblAccBalance, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.LblOnHim, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.LblForHim, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TxtForHim, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.TxtOnHim, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.LblCorD, 0, 4)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 305)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 6
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(231, 130)
        Me.TableLayoutPanel6.TabIndex = 17
        '
        'TxtAccBalance
        '
        Me.TxtAccBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAccBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAccBalance.Enabled = False
        Me.TxtAccBalance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccBalance.HideSelection = False
        Me.TxtAccBalance.Location = New System.Drawing.Point(3, 68)
        Me.TxtAccBalance.MaxLength = 65535
        Me.TxtAccBalance.Name = "TxtAccBalance"
        Me.TxtAccBalance.Size = New System.Drawing.Size(174, 24)
        Me.TxtAccBalance.TabIndex = 29
        Me.TxtAccBalance.Tag = "1"
        Me.TxtAccBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAccBalance.ThemeName = "Office2010Blue"
        Me.TxtAccBalance.WordWrap = False
        '
        'LblAccBalance
        '
        Me.LblAccBalance.AutoSize = True
        Me.LblAccBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAccBalance.Location = New System.Drawing.Point(183, 65)
        Me.LblAccBalance.Name = "LblAccBalance"
        Me.LblAccBalance.Size = New System.Drawing.Size(45, 30)
        Me.LblAccBalance.TabIndex = 21
        Me.LblAccBalance.Text = "الرصيد"
        Me.LblAccBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblOnHim
        '
        Me.LblOnHim.AutoSize = True
        Me.LblOnHim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblOnHim.Location = New System.Drawing.Point(183, 35)
        Me.LblOnHim.Name = "LblOnHim"
        Me.LblOnHim.Size = New System.Drawing.Size(45, 30)
        Me.LblOnHim.TabIndex = 20
        Me.LblOnHim.Text = "عليه"
        Me.LblOnHim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblForHim
        '
        Me.LblForHim.AutoSize = True
        Me.LblForHim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblForHim.Location = New System.Drawing.Point(183, 5)
        Me.LblForHim.Name = "LblForHim"
        Me.LblForHim.Size = New System.Drawing.Size(45, 30)
        Me.LblForHim.TabIndex = 19
        Me.LblForHim.Text = "له"
        Me.LblForHim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtForHim
        '
        Me.TxtForHim.AcceptsTab = True
        Me.TxtForHim.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtForHim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtForHim.Enabled = False
        Me.TxtForHim.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtForHim.HideSelection = False
        Me.TxtForHim.Location = New System.Drawing.Point(3, 8)
        Me.TxtForHim.MaxLength = 65535
        Me.TxtForHim.Name = "TxtForHim"
        Me.TxtForHim.Size = New System.Drawing.Size(174, 24)
        Me.TxtForHim.TabIndex = 27
        Me.TxtForHim.Tag = "1"
        Me.TxtForHim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtForHim.ThemeName = "Office2010Blue"
        Me.TxtForHim.WordWrap = False
        '
        'TxtOnHim
        '
        Me.TxtOnHim.AcceptsTab = True
        Me.TxtOnHim.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtOnHim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtOnHim.Enabled = False
        Me.TxtOnHim.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOnHim.HideSelection = False
        Me.TxtOnHim.Location = New System.Drawing.Point(3, 38)
        Me.TxtOnHim.MaxLength = 65535
        Me.TxtOnHim.Name = "TxtOnHim"
        Me.TxtOnHim.Size = New System.Drawing.Size(174, 24)
        Me.TxtOnHim.TabIndex = 28
        Me.TxtOnHim.Tag = "1"
        Me.TxtOnHim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtOnHim.ThemeName = "Office2010Blue"
        Me.TxtOnHim.WordWrap = False
        '
        'LblCorD
        '
        Me.LblCorD.AutoSize = True
        Me.LblCorD.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel6.SetColumnSpan(Me.LblCorD, 2)
        Me.LblCorD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCorD.ForeColor = System.Drawing.Color.White
        Me.LblCorD.Location = New System.Drawing.Point(3, 95)
        Me.LblCorD.Name = "LblCorD"
        Me.LblCorD.Size = New System.Drawing.Size(225, 35)
        Me.LblCorD.TabIndex = 30
        Me.LblCorD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnPrint, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnFiltering, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnReset, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 221)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(231, 84)
        Me.TableLayoutPanel3.TabIndex = 16
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Image = Global.HEHAccounting.My.Resources.Resources.print
        Me.BtnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPrint.Location = New System.Drawing.Point(128, 45)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(90, 36)
        Me.BtnPrint.TabIndex = 17
        Me.BtnPrint.Tag = "Print"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnFiltering
        '
        Me.BtnFiltering.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFiltering.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFiltering.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnFiltering.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltering.Location = New System.Drawing.Point(129, 3)
        Me.BtnFiltering.Name = "BtnFiltering"
        Me.BtnFiltering.Size = New System.Drawing.Size(90, 36)
        Me.BtnFiltering.TabIndex = 16
        Me.BtnFiltering.Text = "بحث"
        Me.BtnFiltering.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnReset
        '
        Me.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnReset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.Image = Global.HEHAccounting.My.Resources.Resources.Redo
        Me.BtnReset.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnReset.Location = New System.Drawing.Point(13, 3)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(90, 36)
        Me.BtnReset.TabIndex = 8
        Me.BtnReset.Text = "تصفير"
        Me.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCurrencyVal, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTo, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LblAccounts, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblFrom, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtAccounts, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCurrency, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DropCurrency, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckDetailsWithCurrency, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(231, 218)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.AutoSize = True
        Me.TableLayoutPanel7.ColumnCount = 2
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel7.Controls.Add(Me.TxtCurrencyVal, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.BtnGetCurrencyVal, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 78)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(176, 30)
        Me.TableLayoutPanel7.TabIndex = 47
        '
        'TxtCurrencyVal
        '
        Me.TxtCurrencyVal.AcceptsTab = True
        Me.TxtCurrencyVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCurrencyVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCurrencyVal.Enabled = False
        Me.TxtCurrencyVal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurrencyVal.HideSelection = False
        Me.TxtCurrencyVal.Location = New System.Drawing.Point(35, 3)
        Me.TxtCurrencyVal.MaxLength = 65535
        Me.TxtCurrencyVal.Name = "TxtCurrencyVal"
        Me.TxtCurrencyVal.Size = New System.Drawing.Size(138, 24)
        Me.TxtCurrencyVal.TabIndex = 5
        Me.TxtCurrencyVal.Tag = "1"
        Me.TxtCurrencyVal.Text = "1"
        Me.TxtCurrencyVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCurrencyVal.ThemeName = "Office2010Blue"
        Me.TxtCurrencyVal.WordWrap = False
        '
        'BtnGetCurrencyVal
        '
        Me.BtnGetCurrencyVal.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.BtnGetCurrencyVal.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnGetCurrencyVal.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnGetCurrencyVal.Location = New System.Drawing.Point(3, 3)
        Me.BtnGetCurrencyVal.Name = "BtnGetCurrencyVal"
        Me.BtnGetCurrencyVal.Size = New System.Drawing.Size(26, 24)
        Me.BtnGetCurrencyVal.TabIndex = 6
        Me.BtnGetCurrencyVal.Text = "RadButton1"
        '
        'LblCurrencyVal
        '
        Me.LblCurrencyVal.AutoSize = True
        Me.LblCurrencyVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCurrencyVal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrencyVal.Location = New System.Drawing.Point(179, 75)
        Me.LblCurrencyVal.Name = "LblCurrencyVal"
        Me.LblCurrencyVal.Size = New System.Drawing.Size(49, 36)
        Me.LblCurrencyVal.TabIndex = 31
        Me.LblCurrencyVal.Text = "الصرف"
        Me.LblCurrencyVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTo.Location = New System.Drawing.Point(179, 175)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(49, 36)
        Me.LblTo.TabIndex = 18
        Me.LblTo.Text = "إلى"
        Me.LblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAccounts
        '
        Me.LblAccounts.AutoSize = True
        Me.LblAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAccounts.Location = New System.Drawing.Point(179, 15)
        Me.LblAccounts.Name = "LblAccounts"
        Me.LblAccounts.Size = New System.Drawing.Size(49, 30)
        Me.LblAccounts.TabIndex = 17
        Me.LblAccounts.Text = "الحساب"
        Me.LblAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFrom.Location = New System.Drawing.Point(179, 139)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(49, 36)
        Me.LblFrom.TabIndex = 17
        Me.LblFrom.Text = "من"
        Me.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtAccounts
        '
        Me.TxtAccounts.AcceptsTab = True
        Me.TxtAccounts.AutoSize = False
        Me.TxtAccounts.BackColor = System.Drawing.Color.White
        Me.TxtAccounts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAccounts.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccounts.HideSelection = False
        Me.TxtAccounts.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.TxtAccountsBtn})
        Me.TxtAccounts.Location = New System.Drawing.Point(3, 18)
        Me.TxtAccounts.MaxLength = 65535
        Me.TxtAccounts.Name = "TxtAccounts"
        Me.TxtAccounts.ReadOnly = True
        Me.TxtAccounts.ShortcutsEnabled = False
        Me.TxtAccounts.ShowClearButton = True
        Me.TxtAccounts.Size = New System.Drawing.Size(170, 24)
        Me.TxtAccounts.TabIndex = 39
        Me.TxtAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAccounts.ThemeName = "Office2010Blue"
        Me.TxtAccounts.WordWrap = False
        '
        'TxtAccountsBtn
        '
        Me.TxtAccountsBtn.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.TxtAccountsBtn.Image = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtAccountsBtn.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TxtAccountsBtn.Name = "TxtAccountsBtn"
        Me.TxtAccountsBtn.SmallImage = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtAccountsBtn.Text = ""
        Me.TxtAccountsBtn.UseCompatibleTextRendering = False
        '
        'LblCurrency
        '
        Me.LblCurrency.AutoSize = True
        Me.LblCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCurrency.Location = New System.Drawing.Point(179, 45)
        Me.LblCurrency.Name = "LblCurrency"
        Me.LblCurrency.Size = New System.Drawing.Size(49, 30)
        Me.LblCurrency.TabIndex = 40
        Me.LblCurrency.Text = "العملة"
        Me.LblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropCurrency
        '
        Me.DropCurrency.BackColor = System.Drawing.Color.White
        Me.DropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrency.Location = New System.Drawing.Point(3, 48)
        Me.DropCurrency.MaxLength = 65535
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Size = New System.Drawing.Size(170, 24)
        Me.DropCurrency.TabIndex = 41
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MskTxtInvDateFrom, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CheckDateFrom, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 142)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(170, 30)
        Me.TableLayoutPanel2.TabIndex = 42
        '
        'MskTxtInvDateFrom
        '
        Me.MskTxtInvDateFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateFrom.Enabled = False
        Me.MskTxtInvDateFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtInvDateFrom.Location = New System.Drawing.Point(3, 3)
        Me.MskTxtInvDateFrom.Mask = "dd/MM/yyyy"
        Me.MskTxtInvDateFrom.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtInvDateFrom.Name = "MskTxtInvDateFrom"
        Me.MskTxtInvDateFrom.Size = New System.Drawing.Size(143, 24)
        Me.MskTxtInvDateFrom.TabIndex = 25
        Me.MskTxtInvDateFrom.TabStop = False
        Me.MskTxtInvDateFrom.Text = "01/01/2020"
        Me.MskTxtInvDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDateFrom.ThemeName = "Office2010Blue"
        '
        'CheckDateFrom
        '
        Me.CheckDateFrom.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckDateFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDateFrom.Location = New System.Drawing.Point(152, 7)
        Me.CheckDateFrom.Name = "CheckDateFrom"
        Me.CheckDateFrom.Size = New System.Drawing.Size(15, 15)
        Me.CheckDateFrom.TabIndex = 44
        Me.CheckDateFrom.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.MskTxtInvDateTo, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.CheckDateTo, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 178)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(170, 30)
        Me.TableLayoutPanel5.TabIndex = 43
        '
        'MskTxtInvDateTo
        '
        Me.MskTxtInvDateTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateTo.Enabled = False
        Me.MskTxtInvDateTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtInvDateTo.Location = New System.Drawing.Point(3, 3)
        Me.MskTxtInvDateTo.Mask = "dd/MM/yyyy"
        Me.MskTxtInvDateTo.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtInvDateTo.Name = "MskTxtInvDateTo"
        Me.MskTxtInvDateTo.SelectedText = "01"
        Me.MskTxtInvDateTo.SelectionLength = 2
        Me.MskTxtInvDateTo.Size = New System.Drawing.Size(143, 24)
        Me.MskTxtInvDateTo.TabIndex = 44
        Me.MskTxtInvDateTo.TabStop = False
        Me.MskTxtInvDateTo.Text = "01/01/2020"
        Me.MskTxtInvDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDateTo.ThemeName = "Office2010Blue"
        '
        'CheckDateTo
        '
        Me.CheckDateTo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckDateTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDateTo.Location = New System.Drawing.Point(152, 7)
        Me.CheckDateTo.Name = "CheckDateTo"
        Me.CheckDateTo.Size = New System.Drawing.Size(15, 15)
        Me.CheckDateTo.TabIndex = 45
        Me.CheckDateTo.ThemeName = "Office2010Blue"
        '
        'CheckDetailsWithCurrency
        '
        Me.CheckDetailsWithCurrency.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.CheckDetailsWithCurrency, 2)
        Me.CheckDetailsWithCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDetailsWithCurrency.Location = New System.Drawing.Point(50, 114)
        Me.CheckDetailsWithCurrency.Name = "CheckDetailsWithCurrency"
        Me.CheckDetailsWithCurrency.Size = New System.Drawing.Size(131, 22)
        Me.CheckDetailsWithCurrency.TabIndex = 46
        Me.CheckDetailsWithCurrency.Text = "تفصيلي حسب العملة"
        Me.CheckDetailsWithCurrency.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckDetailsWithCurrency.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.PnlOptions, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GridAccountsDetails, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1103, 472)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'ContextGrid
        '
        Me.ContextGrid.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadConOpen})
        Me.ContextGrid.ThemeName = "Office2010Blue"
        '
        'RadConOpen
        '
        Me.RadConOpen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadConOpen.Name = "RadConOpen"
        Me.RadConOpen.PopupDirection = Telerik.WinControls.UI.RadDirection.Right
        Me.RadConOpen.RightToLeft = True
        Me.RadConOpen.Text = "معاينة"
        '
        'AccountsDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 472)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccountsDetails"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "كشف حساب"
        Me.ThemeName = "Office2010Blue"
        CType(Me.GridAccountsDetails.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridAccountsDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.TxtAccBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtForHim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOnHim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.TxtCurrencyVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnGetCurrencyVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDetailsWithCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridAccountsDetails As Telerik.WinControls.UI.RadGridView
    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblTo As Label
    Friend WithEvents LblAccounts As Label
    Friend WithEvents LblFrom As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TxtAccounts As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents TxtAccountsBtn As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents LblCurrency As Label
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents MskTxtInvDateFrom As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents CheckDateFrom As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents CheckDateTo As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents MskTxtInvDateTo As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents LblAccBalance As Label
    Friend WithEvents LblOnHim As Label
    Friend WithEvents LblForHim As Label
    Friend WithEvents TxtAccBalance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtForHim As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtOnHim As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblCorD As Label
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents CheckDetailsWithCurrency As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents LblCurrencyVal As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TxtCurrencyVal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BtnGetCurrencyVal As Telerik.WinControls.UI.RadButton
    Friend WithEvents ContextManagerGrid As Telerik.WinControls.UI.RadContextMenuManager
    Friend WithEvents ContextGrid As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents RadConOpen As Telerik.WinControls.UI.RadMenuItem
End Class

