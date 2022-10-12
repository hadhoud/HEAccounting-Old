<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseOrderFrm))
        Dim TableViewDefinition5 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPrint = New Telerik.WinControls.UI.RadButton()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.BtnPayInvoice = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.DropStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.LblInvID = New System.Windows.Forms.Label()
        Me.LblVendor = New System.Windows.Forms.Label()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.LblPaymentType = New System.Windows.Forms.Label()
        Me.LblInvType = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioPurchase = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadioReturns = New Telerik.WinControls.UI.RadRadioButton()
        Me.MskTxtInvDateFrom = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.MskTxtInvDateTo = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.CheckDateFrom = New Telerik.WinControls.UI.RadCheckBox()
        Me.TxtVendor = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.TxtVendorBtn = New Telerik.WinControls.UI.RadButtonElement()
        Me.TxtInvID = New Telerik.WinControls.UI.RadTextBox()
        Me.CheckDateTo = New Telerik.WinControls.UI.RadCheckBox()
        Me.LblDropCurrency = New System.Windows.Forms.Label()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnNew = New Telerik.WinControls.UI.RadButton()
        Me.BtnEdit = New Telerik.WinControls.UI.RadButton()
        Me.BtnDelete = New Telerik.WinControls.UI.RadButton()
        Me.BtnRefrech = New Telerik.WinControls.UI.RadButton()
        Me.GridPurchaseOrders = New Telerik.WinControls.UI.RadGridView()
        Me.VendorTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.DropPaymentType = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPayInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DropStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.RadioPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioReturns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPurchaseOrders.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PnlOptions.Size = New System.Drawing.Size(255, 503)
        Me.PnlOptions.TabIndex = 4
        Me.PnlOptions.Tag = ""
        Me.PnlOptions.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnPrint, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnFiltering, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnReset, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnPayInvoice, 1, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 395)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(249, 89)
        Me.TableLayoutPanel3.TabIndex = 16
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPrint.Image = Global.HEHAccounting.My.Resources.Resources.print
        Me.BtnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.Location = New System.Drawing.Point(135, 50)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(104, 36)
        Me.BtnPrint.TabIndex = 17
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnFiltering
        '
        Me.BtnFiltering.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnFiltering.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnFiltering.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnFiltering.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnFiltering.Location = New System.Drawing.Point(135, 3)
        Me.BtnFiltering.Name = "BtnFiltering"
        Me.BtnFiltering.Size = New System.Drawing.Size(104, 36)
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
        Me.BtnReset.Location = New System.Drawing.Point(11, 3)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(104, 36)
        Me.BtnReset.TabIndex = 8
        Me.BtnReset.Text = "تصفير"
        Me.BtnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnPayInvoice
        '
        Me.BtnPayInvoice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnPayInvoice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnPayInvoice.Image = Global.HEHAccounting.My.Resources.Resources.money
        Me.BtnPayInvoice.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPayInvoice.Location = New System.Drawing.Point(11, 50)
        Me.BtnPayInvoice.Name = "BtnPayInvoice"
        Me.BtnPayInvoice.Size = New System.Drawing.Size(104, 36)
        Me.BtnPayInvoice.TabIndex = 20
        Me.BtnPayInvoice.Text = "تسديد"
        Me.BtnPayInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.LblStatus, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DropStatus, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblFrom, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvID, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblVendor, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTo, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LblPaymentType, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvType, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtInvDateFrom, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtInvDateTo, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckDateFrom, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtVendor, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtInvID, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckDateTo, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDropCurrency, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DropCurrency, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DropPaymentType, 1, 9)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 141)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 254)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(175, 5)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(71, 30)
        Me.LblStatus.TabIndex = 31
        Me.LblStatus.Text = "الحالة"
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropStatus
        '
        Me.DropStatus.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.DropStatus, 2)
        Me.DropStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropStatus.Location = New System.Drawing.Point(3, 8)
        Me.DropStatus.MaxLength = 65535
        Me.DropStatus.Name = "DropStatus"
        Me.DropStatus.Size = New System.Drawing.Size(166, 24)
        Me.DropStatus.TabIndex = 30
        Me.DropStatus.Tag = ""
        Me.DropStatus.ThemeName = "Office2010Blue"
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFrom.Location = New System.Drawing.Point(175, 159)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(71, 30)
        Me.LblFrom.TabIndex = 18
        Me.LblFrom.Text = "من"
        Me.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInvID
        '
        Me.LblInvID.AutoSize = True
        Me.LblInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvID.Location = New System.Drawing.Point(175, 99)
        Me.LblInvID.Name = "LblInvID"
        Me.LblInvID.Size = New System.Drawing.Size(71, 30)
        Me.LblInvID.TabIndex = 17
        Me.LblInvID.Text = "رقم الفاتورة"
        Me.LblInvID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVendor
        '
        Me.LblVendor.AutoSize = True
        Me.LblVendor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblVendor.Location = New System.Drawing.Point(175, 129)
        Me.LblVendor.Name = "LblVendor"
        Me.LblVendor.Size = New System.Drawing.Size(71, 30)
        Me.LblVendor.TabIndex = 17
        Me.LblVendor.Text = "المورد"
        Me.LblVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTo.Location = New System.Drawing.Point(175, 189)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(71, 30)
        Me.LblTo.TabIndex = 20
        Me.LblTo.Text = "إلى"
        Me.LblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPaymentType
        '
        Me.LblPaymentType.AutoSize = True
        Me.LblPaymentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPaymentType.Location = New System.Drawing.Point(175, 219)
        Me.LblPaymentType.Name = "LblPaymentType"
        Me.LblPaymentType.Size = New System.Drawing.Size(71, 30)
        Me.LblPaymentType.TabIndex = 21
        Me.LblPaymentType.Text = "الدفع"
        Me.LblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInvType
        '
        Me.LblInvType.AutoSize = True
        Me.LblInvType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvType.Location = New System.Drawing.Point(175, 65)
        Me.LblInvType.Name = "LblInvType"
        Me.LblInvType.Size = New System.Drawing.Size(71, 34)
        Me.LblInvType.TabIndex = 19
        Me.LblInvType.Text = "النوع"
        Me.LblInvType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel4, 2)
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.RadioPurchase, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.RadioReturns, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 68)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(166, 28)
        Me.TableLayoutPanel4.TabIndex = 17
        '
        'RadioPurchase
        '
        Me.RadioPurchase.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPurchase.Location = New System.Drawing.Point(113, 3)
        Me.RadioPurchase.Name = "RadioPurchase"
        Me.RadioPurchase.Size = New System.Drawing.Size(50, 22)
        Me.RadioPurchase.TabIndex = 0
        Me.RadioPurchase.TabStop = False
        Me.RadioPurchase.Tag = "P"
        Me.RadioPurchase.Text = "شراء"
        Me.RadioPurchase.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioPurchase.ThemeName = "Office2010Blue"
        '
        'RadioReturns
        '
        Me.RadioReturns.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RadioReturns.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioReturns.Location = New System.Drawing.Point(27, 3)
        Me.RadioReturns.Name = "RadioReturns"
        Me.RadioReturns.Size = New System.Drawing.Size(57, 22)
        Me.RadioReturns.TabIndex = 1
        Me.RadioReturns.TabStop = False
        Me.RadioReturns.Tag = "R"
        Me.RadioReturns.Text = "مرتجع"
        Me.RadioReturns.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioReturns.ThemeName = "Office2010Blue"
        '
        'MskTxtInvDateFrom
        '
        Me.MskTxtInvDateFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateFrom.Enabled = False
        Me.MskTxtInvDateFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtInvDateFrom.Location = New System.Drawing.Point(3, 162)
        Me.MskTxtInvDateFrom.Mask = "dd/MM/yyyy"
        Me.MskTxtInvDateFrom.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtInvDateFrom.Name = "MskTxtInvDateFrom"
        Me.MskTxtInvDateFrom.SelectedText = "01"
        Me.MskTxtInvDateFrom.SelectionLength = 2
        Me.MskTxtInvDateFrom.Size = New System.Drawing.Size(145, 24)
        Me.MskTxtInvDateFrom.TabIndex = 24
        Me.MskTxtInvDateFrom.TabStop = False
        Me.MskTxtInvDateFrom.Text = "01/01/2020"
        Me.MskTxtInvDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDateFrom.ThemeName = "Office2010Blue"
        '
        'MskTxtInvDateTo
        '
        Me.MskTxtInvDateTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDateTo.Enabled = False
        Me.MskTxtInvDateTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtInvDateTo.Location = New System.Drawing.Point(3, 192)
        Me.MskTxtInvDateTo.Mask = "dd/MM/yyyy"
        Me.MskTxtInvDateTo.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtInvDateTo.Name = "MskTxtInvDateTo"
        Me.MskTxtInvDateTo.SelectedText = "01"
        Me.MskTxtInvDateTo.SelectionLength = 2
        Me.MskTxtInvDateTo.Size = New System.Drawing.Size(145, 24)
        Me.MskTxtInvDateTo.TabIndex = 25
        Me.MskTxtInvDateTo.TabStop = False
        Me.MskTxtInvDateTo.Text = "01/01/2020"
        Me.MskTxtInvDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDateTo.ThemeName = "Office2010Blue"
        '
        'CheckDateFrom
        '
        Me.CheckDateFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckDateFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDateFrom.Location = New System.Drawing.Point(154, 166)
        Me.CheckDateFrom.Name = "CheckDateFrom"
        Me.CheckDateFrom.Size = New System.Drawing.Size(15, 15)
        Me.CheckDateFrom.TabIndex = 27
        Me.CheckDateFrom.ThemeName = "Office2010Blue"
        '
        'TxtVendor
        '
        Me.TxtVendor.AcceptsTab = True
        Me.TxtVendor.AutoSize = False
        Me.TableLayoutPanel1.SetColumnSpan(Me.TxtVendor, 2)
        Me.TxtVendor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtVendor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVendor.HideSelection = False
        Me.TxtVendor.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.TxtVendorBtn})
        Me.TxtVendor.Location = New System.Drawing.Point(3, 132)
        Me.TxtVendor.MaxLength = 65535
        Me.TxtVendor.Name = "TxtVendor"
        Me.TxtVendor.ShowClearButton = True
        Me.TxtVendor.Size = New System.Drawing.Size(166, 24)
        Me.TxtVendor.TabIndex = 17
        Me.TxtVendor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtVendor.ThemeName = "Office2010Blue"
        Me.TxtVendor.WordWrap = False
        '
        'TxtVendorBtn
        '
        Me.TxtVendorBtn.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.TxtVendorBtn.Image = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtVendorBtn.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.TxtVendorBtn.Name = "TxtVendorBtn"
        Me.TxtVendorBtn.SmallImage = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtVendorBtn.Text = ""
        Me.TxtVendorBtn.UseCompatibleTextRendering = False
        '
        'TxtInvID
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.TxtInvID, 2)
        Me.TxtInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvID.Location = New System.Drawing.Point(3, 102)
        Me.TxtInvID.Name = "TxtInvID"
        Me.TxtInvID.ShortcutsEnabled = False
        Me.TxtInvID.ShowClearButton = True
        Me.TxtInvID.Size = New System.Drawing.Size(166, 24)
        Me.TxtInvID.TabIndex = 4
        Me.TxtInvID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInvID.ThemeName = "Office2010Blue"
        '
        'CheckDateTo
        '
        Me.CheckDateTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckDateTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckDateTo.Location = New System.Drawing.Point(154, 196)
        Me.CheckDateTo.Name = "CheckDateTo"
        Me.CheckDateTo.Size = New System.Drawing.Size(15, 15)
        Me.CheckDateTo.TabIndex = 26
        Me.CheckDateTo.ThemeName = "Office2010Blue"
        '
        'LblDropCurrency
        '
        Me.LblDropCurrency.AutoSize = True
        Me.LblDropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDropCurrency.Location = New System.Drawing.Point(175, 35)
        Me.LblDropCurrency.Name = "LblDropCurrency"
        Me.LblDropCurrency.Size = New System.Drawing.Size(71, 30)
        Me.LblDropCurrency.TabIndex = 28
        Me.LblDropCurrency.Text = "العملة"
        Me.LblDropCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropCurrency
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DropCurrency, 2)
        Me.DropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrency.Location = New System.Drawing.Point(3, 38)
        Me.DropCurrency.MaxLength = 65535
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Size = New System.Drawing.Size(166, 24)
        Me.DropCurrency.TabIndex = 20
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BtnNew, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnEdit, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnDelete, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnRefrech, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
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
        Me.BtnDelete.Enabled = False
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
        'GridPurchaseOrders
        '
        Me.GridPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPurchaseOrders.Location = New System.Drawing.Point(255, 0)
        '
        '
        '
        Me.GridPurchaseOrders.MasterTemplate.ViewDefinition = TableViewDefinition5
        Me.GridPurchaseOrders.Name = "GridPurchaseOrders"
        Me.GridPurchaseOrders.Size = New System.Drawing.Size(380, 503)
        Me.GridPurchaseOrders.TabIndex = 5
        Me.GridPurchaseOrders.ThemeName = "Office2010Blue"
        '
        'DropPaymentType
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.DropPaymentType, 2)
        Me.DropPaymentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropPaymentType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropPaymentType.Location = New System.Drawing.Point(3, 222)
        Me.DropPaymentType.MaxLength = 65535
        Me.DropPaymentType.Name = "DropPaymentType"
        Me.DropPaymentType.Size = New System.Drawing.Size(166, 24)
        Me.DropPaymentType.TabIndex = 67
        Me.DropPaymentType.Tag = ""
        Me.DropPaymentType.ThemeName = "Office2010Blue"
        '
        'PurchaseOrderFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnReset
        Me.ClientSize = New System.Drawing.Size(635, 503)
        Me.Controls.Add(Me.GridPurchaseOrders)
        Me.Controls.Add(Me.PnlOptions)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PurchaseOrderFrm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.Tag = "PurchasesOrders"
        Me.Text = "فواتير مشتريات"
        Me.ThemeName = "Office2010Blue"
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPayInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DropStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.RadioPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioReturns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtVendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefrech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPurchaseOrders.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblFrom As Label
    Friend WithEvents LblInvID As Label
    Friend WithEvents LblVendor As Label
    Friend WithEvents LblTo As Label
    Friend WithEvents LblPaymentType As Label
    Friend WithEvents LblInvType As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents RadioPurchase As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadioReturns As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents MskTxtInvDateFrom As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents MskTxtInvDateTo As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents CheckDateFrom As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents TxtVendor As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents TxtVendorBtn As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents TxtInvID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents CheckDateTo As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents LblDropCurrency As Label
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnEdit As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnDelete As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnRefrech As Telerik.WinControls.UI.RadButton
    Friend WithEvents GridPurchaseOrders As Telerik.WinControls.UI.RadGridView
    Friend WithEvents VendorTooltip As ToolTip
    Friend WithEvents LblStatus As Label
    Friend WithEvents DropStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents BtnPayInvoice As Telerik.WinControls.UI.RadButton
    Friend WithEvents DropPaymentType As Telerik.WinControls.UI.RadDropDownList
End Class

