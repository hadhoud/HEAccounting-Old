<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewPurchaseInvoice
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
        Dim GridViewSummaryItem7 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem8 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem9 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TLPSOHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtCurrencyVal = New Telerik.WinControls.UI.RadTextBox()
        Me.BtnGetCurrencyVal = New Telerik.WinControls.UI.RadButton()
        Me.TxtInvoiceReference = New Telerik.WinControls.UI.RadTextBox()
        Me.LblInvID = New System.Windows.Forms.Label()
        Me.LblDueTotal = New System.Windows.Forms.Label()
        Me.LblDiscount = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioPurchases = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadioReturns = New Telerik.WinControls.UI.RadRadioButton()
        Me.LblInvSubTotal = New System.Windows.Forms.Label()
        Me.LblInvVendor = New System.Windows.Forms.Label()
        Me.LblInvDate = New System.Windows.Forms.Label()
        Me.LblInvType = New System.Windows.Forms.Label()
        Me.TxtInvID = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtVendor = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.TxtVendorBtn = New Telerik.WinControls.UI.RadButtonElement()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.DropStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.TxtSubTotal = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtTotalDue = New Telerik.WinControls.UI.RadTextBox()
        Me.LblPaymentType = New System.Windows.Forms.Label()
        Me.TxtDiscount = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.MskTxtInvDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioDebt = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadioCash = New Telerik.WinControls.UI.RadRadioButton()
        Me.LblDropCurrency = New System.Windows.Forms.Label()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.LblCurrValue = New System.Windows.Forms.Label()
        Me.LblReference = New System.Windows.Forms.Label()
        Me.LblPaid = New System.Windows.Forms.Label()
        Me.TLPHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.LblItemName = New System.Windows.Forms.Label()
        Me.TxtItemBarcode = New Telerik.WinControls.UI.RadTextBox()
        Me.LblItemID = New System.Windows.Forms.Label()
        Me.LblBarcode = New System.Windows.Forms.Label()
        Me.TxtItemid = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtItemName = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.ATxtItemNameBtn = New Telerik.WinControls.UI.RadButtonElement()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.TLPCommand = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        Me.BtnPrint = New Telerik.WinControls.UI.RadButton()
        Me.GridInvItem = New Telerik.WinControls.UI.RadGridView()
        Me.ToolTipVendor = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDollarRate = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TLPSOHeader.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.TxtCurrencyVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnGetCurrencyVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInvoiceReference, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.RadioPurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioReturns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTotalDue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtInvDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.RadioDebt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPHeader.SuspendLayout()
        CType(Me.TxtItemBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPCommand.SuspendLayout()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridInvItem.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDollarRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TLPSOHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TLPHeader, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TLPCommand, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GridInvItem, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1064, 482)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TLPSOHeader
        '
        Me.TLPSOHeader.AutoSize = True
        Me.TLPSOHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TLPSOHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TLPSOHeader.ColumnCount = 2
        Me.TLPSOHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPSOHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPSOHeader.Controls.Add(Me.TableLayoutPanel4, 1, 2)
        Me.TLPSOHeader.Controls.Add(Me.TxtInvoiceReference, 1, 4)
        Me.TLPSOHeader.Controls.Add(Me.LblInvID, 0, 3)
        Me.TLPSOHeader.Controls.Add(Me.LblDueTotal, 0, 11)
        Me.TLPSOHeader.Controls.Add(Me.LblDiscount, 0, 10)
        Me.TLPSOHeader.Controls.Add(Me.TableLayoutPanel3, 1, 5)
        Me.TLPSOHeader.Controls.Add(Me.LblInvSubTotal, 0, 9)
        Me.TLPSOHeader.Controls.Add(Me.LblInvVendor, 0, 7)
        Me.TLPSOHeader.Controls.Add(Me.LblInvDate, 0, 6)
        Me.TLPSOHeader.Controls.Add(Me.LblInvType, 0, 5)
        Me.TLPSOHeader.Controls.Add(Me.TxtInvID, 1, 3)
        Me.TLPSOHeader.Controls.Add(Me.TxtVendor, 1, 7)
        Me.TLPSOHeader.Controls.Add(Me.LblStatus, 0, 8)
        Me.TLPSOHeader.Controls.Add(Me.DropStatus, 1, 8)
        Me.TLPSOHeader.Controls.Add(Me.TxtSubTotal, 1, 9)
        Me.TLPSOHeader.Controls.Add(Me.TxtTotalDue, 1, 11)
        Me.TLPSOHeader.Controls.Add(Me.LblPaymentType, 0, 13)
        Me.TLPSOHeader.Controls.Add(Me.TxtDiscount, 1, 10)
        Me.TLPSOHeader.Controls.Add(Me.MskTxtInvDate, 1, 6)
        Me.TLPSOHeader.Controls.Add(Me.TableLayoutPanel2, 1, 13)
        Me.TLPSOHeader.Controls.Add(Me.LblDropCurrency, 0, 1)
        Me.TLPSOHeader.Controls.Add(Me.DropCurrency, 1, 1)
        Me.TLPSOHeader.Controls.Add(Me.LblCurrValue, 0, 2)
        Me.TLPSOHeader.Controls.Add(Me.LblReference, 0, 4)
        Me.TLPSOHeader.Controls.Add(Me.LblPaid, 0, 14)
        Me.TLPSOHeader.Controls.Add(Me.TxtCurrencyVal, 1, 0)
        Me.TLPSOHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPSOHeader.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns
        Me.TLPSOHeader.Location = New System.Drawing.Point(822, 0)
        Me.TLPSOHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPSOHeader.Name = "TLPSOHeader"
        Me.TLPSOHeader.RowCount = 16
        Me.TableLayoutPanel1.SetRowSpan(Me.TLPSOHeader, 2)
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPSOHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TLPSOHeader.Size = New System.Drawing.Size(242, 433)
        Me.TLPSOHeader.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.txtDollarRate, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnGetCurrencyVal, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 47)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(159, 30)
        Me.TableLayoutPanel4.TabIndex = 44
        '
        'TxtCurrencyVal
        '
        Me.TxtCurrencyVal.AcceptsTab = True
        Me.TxtCurrencyVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCurrencyVal.Enabled = False
        Me.TxtCurrencyVal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCurrencyVal.HideSelection = False
        Me.TxtCurrencyVal.Location = New System.Drawing.Point(138, 3)
        Me.TxtCurrencyVal.MaxLength = 65535
        Me.TxtCurrencyVal.Name = "TxtCurrencyVal"
        Me.TxtCurrencyVal.Size = New System.Drawing.Size(18, 24)
        Me.TxtCurrencyVal.TabIndex = 5
        Me.TxtCurrencyVal.Tag = "1"
        Me.TxtCurrencyVal.Text = "1"
        Me.TxtCurrencyVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCurrencyVal.ThemeName = "Office2010Blue"
        Me.TxtCurrencyVal.Visible = False
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
        'TxtInvoiceReference
        '
        Me.TxtInvoiceReference.AcceptsTab = True
        Me.TxtInvoiceReference.BackColor = System.Drawing.Color.White
        Me.TxtInvoiceReference.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvoiceReference.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvoiceReference.HideSelection = False
        Me.TxtInvoiceReference.Location = New System.Drawing.Point(3, 113)
        Me.TxtInvoiceReference.MaxLength = 65535
        Me.TxtInvoiceReference.Name = "TxtInvoiceReference"
        Me.TxtInvoiceReference.Size = New System.Drawing.Size(153, 24)
        Me.TxtInvoiceReference.TabIndex = 23
        Me.TxtInvoiceReference.Tag = "1"
        Me.TxtInvoiceReference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInvoiceReference.ThemeName = "Office2010Blue"
        Me.TxtInvoiceReference.WordWrap = False
        '
        'LblInvID
        '
        Me.LblInvID.AutoSize = True
        Me.LblInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvID.Location = New System.Drawing.Point(162, 80)
        Me.LblInvID.Name = "LblInvID"
        Me.LblInvID.Size = New System.Drawing.Size(77, 30)
        Me.LblInvID.TabIndex = 0
        Me.LblInvID.Text = "رقم الفاتورة"
        Me.LblInvID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDueTotal
        '
        Me.LblDueTotal.AutoSize = True
        Me.LblDueTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDueTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDueTotal.Location = New System.Drawing.Point(162, 324)
        Me.LblDueTotal.Name = "LblDueTotal"
        Me.LblDueTotal.Size = New System.Drawing.Size(77, 30)
        Me.LblDueTotal.TabIndex = 7
        Me.LblDueTotal.Text = "الصافي"
        Me.LblDueTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDiscount
        '
        Me.LblDiscount.AutoSize = True
        Me.LblDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDiscount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDiscount.Location = New System.Drawing.Point(162, 294)
        Me.LblDiscount.Name = "LblDiscount"
        Me.LblDiscount.Size = New System.Drawing.Size(77, 30)
        Me.LblDiscount.TabIndex = 6
        Me.LblDiscount.Text = "الخصم"
        Me.LblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.RadioPurchases, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RadioReturns, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 143)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(153, 28)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'RadioPurchases
        '
        Me.RadioPurchases.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadioPurchases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioPurchases.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPurchases.Location = New System.Drawing.Point(100, 3)
        Me.RadioPurchases.Name = "RadioPurchases"
        Me.RadioPurchases.Size = New System.Drawing.Size(50, 22)
        Me.RadioPurchases.TabIndex = 0
        Me.RadioPurchases.Tag = "P"
        Me.RadioPurchases.Text = "شراء"
        Me.RadioPurchases.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioPurchases.ThemeName = "Office2010Blue"
        Me.RadioPurchases.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadioReturns
        '
        Me.RadioReturns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadioReturns.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioReturns.Location = New System.Drawing.Point(3, 3)
        Me.RadioReturns.Name = "RadioReturns"
        Me.RadioReturns.Size = New System.Drawing.Size(57, 22)
        Me.RadioReturns.TabIndex = 1
        Me.RadioReturns.TabStop = False
        Me.RadioReturns.Tag = ""
        Me.RadioReturns.Text = "مرتجع"
        Me.RadioReturns.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioReturns.ThemeName = "Office2010Blue"
        '
        'LblInvSubTotal
        '
        Me.LblInvSubTotal.AutoSize = True
        Me.LblInvSubTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvSubTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSubTotal.Location = New System.Drawing.Point(162, 264)
        Me.LblInvSubTotal.Name = "LblInvSubTotal"
        Me.LblInvSubTotal.Size = New System.Drawing.Size(77, 30)
        Me.LblInvSubTotal.TabIndex = 5
        Me.LblInvSubTotal.Text = "المجموع"
        Me.LblInvSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInvVendor
        '
        Me.LblInvVendor.AutoSize = True
        Me.LblInvVendor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvVendor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvVendor.Location = New System.Drawing.Point(162, 204)
        Me.LblInvVendor.Name = "LblInvVendor"
        Me.LblInvVendor.Size = New System.Drawing.Size(77, 30)
        Me.LblInvVendor.TabIndex = 3
        Me.LblInvVendor.Text = "المورد"
        Me.LblInvVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInvDate
        '
        Me.LblInvDate.AutoSize = True
        Me.LblInvDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvDate.Location = New System.Drawing.Point(162, 174)
        Me.LblInvDate.Name = "LblInvDate"
        Me.LblInvDate.Size = New System.Drawing.Size(77, 30)
        Me.LblInvDate.TabIndex = 2
        Me.LblInvDate.Text = "التاريخ"
        Me.LblInvDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInvType
        '
        Me.LblInvType.AutoSize = True
        Me.LblInvType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvType.Location = New System.Drawing.Point(162, 140)
        Me.LblInvType.Name = "LblInvType"
        Me.LblInvType.Size = New System.Drawing.Size(77, 34)
        Me.LblInvType.TabIndex = 1
        Me.LblInvType.Text = " نوع الفاتورة"
        Me.LblInvType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInvID
        '
        Me.TxtInvID.AcceptsTab = True
        Me.TxtInvID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvID.Enabled = False
        Me.TxtInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvID.HideSelection = False
        Me.TxtInvID.Location = New System.Drawing.Point(3, 83)
        Me.TxtInvID.MaxLength = 65535
        Me.TxtInvID.Name = "TxtInvID"
        Me.TxtInvID.ReadOnly = True
        Me.TxtInvID.Size = New System.Drawing.Size(153, 24)
        Me.TxtInvID.TabIndex = 9
        Me.TxtInvID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInvID.ThemeName = "Office2010Blue"
        Me.TxtInvID.WordWrap = False
        '
        'TxtVendor
        '
        Me.TxtVendor.AcceptsTab = True
        Me.TxtVendor.AutoSize = False
        Me.TxtVendor.BackColor = System.Drawing.Color.White
        Me.TxtVendor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtVendor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVendor.HideSelection = False
        Me.TxtVendor.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.TxtVendorBtn})
        Me.TxtVendor.Location = New System.Drawing.Point(3, 207)
        Me.TxtVendor.MaxLength = 65535
        Me.TxtVendor.Name = "TxtVendor"
        Me.TxtVendor.ShortcutsEnabled = False
        Me.TxtVendor.ShowClearButton = True
        Me.TxtVendor.Size = New System.Drawing.Size(153, 24)
        Me.TxtVendor.TabIndex = 12
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
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(162, 234)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(77, 30)
        Me.LblStatus.TabIndex = 4
        Me.LblStatus.Text = "الحالة"
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropStatus
        '
        Me.DropStatus.BackColor = System.Drawing.Color.White
        Me.DropStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropStatus.DropDownAnimationEnabled = True
        Me.DropStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropStatus.Location = New System.Drawing.Point(3, 237)
        Me.DropStatus.MaxLength = 65535
        Me.DropStatus.Name = "DropStatus"
        Me.DropStatus.Size = New System.Drawing.Size(153, 24)
        Me.DropStatus.TabIndex = 13
        Me.DropStatus.ThemeName = "Office2010Blue"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.AcceptsTab = True
        Me.TxtSubTotal.BackColor = System.Drawing.Color.White
        Me.TxtSubTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSubTotal.Enabled = False
        Me.TxtSubTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubTotal.HideSelection = False
        Me.TxtSubTotal.Location = New System.Drawing.Point(3, 267)
        Me.TxtSubTotal.MaxLength = 65535
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(153, 24)
        Me.TxtSubTotal.TabIndex = 14
        Me.TxtSubTotal.Text = "0"
        Me.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtSubTotal.ThemeName = "Office2010Blue"
        Me.TxtSubTotal.WordWrap = False
        '
        'TxtTotalDue
        '
        Me.TxtTotalDue.AcceptsTab = True
        Me.TxtTotalDue.BackColor = System.Drawing.Color.White
        Me.TxtTotalDue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTotalDue.Enabled = False
        Me.TxtTotalDue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalDue.HideSelection = False
        Me.TxtTotalDue.Location = New System.Drawing.Point(3, 327)
        Me.TxtTotalDue.MaxLength = 65535
        Me.TxtTotalDue.Name = "TxtTotalDue"
        Me.TxtTotalDue.Size = New System.Drawing.Size(153, 24)
        Me.TxtTotalDue.TabIndex = 16
        Me.TxtTotalDue.Text = "0"
        Me.TxtTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTotalDue.ThemeName = "Office2010Blue"
        Me.TxtTotalDue.WordWrap = False
        '
        'LblPaymentType
        '
        Me.LblPaymentType.AutoSize = True
        Me.LblPaymentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPaymentType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaymentType.Location = New System.Drawing.Point(162, 364)
        Me.LblPaymentType.Name = "LblPaymentType"
        Me.LblPaymentType.Size = New System.Drawing.Size(77, 34)
        Me.LblPaymentType.TabIndex = 8
        Me.LblPaymentType.Text = "الدفع"
        Me.LblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDiscount
        '
        Me.TxtDiscount.BackColor = System.Drawing.Color.White
        Me.TxtDiscount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDiscount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiscount.Location = New System.Drawing.Point(3, 297)
        Me.TxtDiscount.Mask = "G"
        Me.TxtDiscount.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.PromptChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.TxtDiscount.Size = New System.Drawing.Size(153, 24)
        Me.TxtDiscount.TabIndex = 15
        Me.TxtDiscount.TabStop = False
        Me.TxtDiscount.Text = "0"
        Me.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDiscount.ThemeName = "Office2010Blue"
        '
        'MskTxtInvDate
        '
        Me.MskTxtInvDate.BackColor = System.Drawing.Color.White
        Me.MskTxtInvDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtInvDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtInvDate.Location = New System.Drawing.Point(3, 177)
        Me.MskTxtInvDate.Mask = "dd/MM/yyyy"
        Me.MskTxtInvDate.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtInvDate.Name = "MskTxtInvDate"
        Me.MskTxtInvDate.Size = New System.Drawing.Size(153, 24)
        Me.MskTxtInvDate.TabIndex = 11
        Me.MskTxtInvDate.TabStop = False
        Me.MskTxtInvDate.Text = "01/01/2020"
        Me.MskTxtInvDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtInvDate.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RadioDebt, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioCash, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 367)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(153, 28)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'RadioDebt
        '
        Me.RadioDebt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RadioDebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioDebt.Location = New System.Drawing.Point(18, 3)
        Me.RadioDebt.Name = "RadioDebt"
        Me.RadioDebt.Size = New System.Drawing.Size(42, 22)
        Me.RadioDebt.TabIndex = 1
        Me.RadioDebt.TabStop = False
        Me.RadioDebt.Tag = "D"
        Me.RadioDebt.Text = "آجل"
        Me.RadioDebt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioDebt.ThemeName = "Office2010Blue"
        '
        'RadioCash
        '
        Me.RadioCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RadioCash.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadioCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioCash.Location = New System.Drawing.Point(95, 3)
        Me.RadioCash.Name = "RadioCash"
        Me.RadioCash.Size = New System.Drawing.Size(41, 22)
        Me.RadioCash.TabIndex = 0
        Me.RadioCash.Tag = "C"
        Me.RadioCash.Text = "نقدا"
        Me.RadioCash.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioCash.ThemeName = "Office2010Blue"
        Me.RadioCash.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'LblDropCurrency
        '
        Me.LblDropCurrency.AutoSize = True
        Me.LblDropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDropCurrency.Location = New System.Drawing.Point(162, 14)
        Me.LblDropCurrency.Name = "LblDropCurrency"
        Me.LblDropCurrency.Size = New System.Drawing.Size(77, 30)
        Me.LblDropCurrency.TabIndex = 18
        Me.LblDropCurrency.Text = "العملة"
        Me.LblDropCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropCurrency
        '
        Me.DropCurrency.BackColor = System.Drawing.Color.White
        Me.DropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropCurrency.DropDownAnimationEnabled = True
        Me.DropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrency.Location = New System.Drawing.Point(3, 17)
        Me.DropCurrency.MaxLength = 65535
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Size = New System.Drawing.Size(153, 24)
        Me.DropCurrency.TabIndex = 19
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'LblCurrValue
        '
        Me.LblCurrValue.AutoSize = True
        Me.LblCurrValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCurrValue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrValue.Location = New System.Drawing.Point(162, 44)
        Me.LblCurrValue.Name = "LblCurrValue"
        Me.LblCurrValue.Size = New System.Drawing.Size(77, 36)
        Me.LblCurrValue.TabIndex = 20
        Me.LblCurrValue.Text = "قيمة الصرف"
        Me.LblCurrValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblReference
        '
        Me.LblReference.AutoSize = True
        Me.LblReference.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblReference.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReference.Location = New System.Drawing.Point(162, 110)
        Me.LblReference.Name = "LblReference"
        Me.LblReference.Size = New System.Drawing.Size(77, 30)
        Me.LblReference.TabIndex = 22
        Me.LblReference.Text = "المرجع"
        Me.LblReference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPaid
        '
        Me.LblPaid.AutoSize = True
        Me.TLPSOHeader.SetColumnSpan(Me.LblPaid, 2)
        Me.LblPaid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPaid.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaid.ForeColor = System.Drawing.Color.Red
        Me.LblPaid.Location = New System.Drawing.Point(3, 398)
        Me.LblPaid.Name = "LblPaid"
        Me.LblPaid.Size = New System.Drawing.Size(236, 25)
        Me.LblPaid.TabIndex = 46
        Me.LblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TLPHeader
        '
        Me.TLPHeader.ColumnCount = 5
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLPHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 383.0!))
        Me.TLPHeader.Controls.Add(Me.LblItemName, 2, 0)
        Me.TLPHeader.Controls.Add(Me.TxtItemBarcode, 0, 1)
        Me.TLPHeader.Controls.Add(Me.LblItemID, 1, 0)
        Me.TLPHeader.Controls.Add(Me.LblBarcode, 0, 0)
        Me.TLPHeader.Controls.Add(Me.TxtItemid, 1, 1)
        Me.TLPHeader.Controls.Add(Me.TxtItemName, 2, 1)
        Me.TLPHeader.Controls.Add(Me.BtnAdd, 4, 0)
        Me.TLPHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.TLPHeader.Location = New System.Drawing.Point(5, 3)
        Me.TLPHeader.Name = "TLPHeader"
        Me.TLPHeader.RowCount = 2
        Me.TLPHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPHeader.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPHeader.Size = New System.Drawing.Size(814, 54)
        Me.TLPHeader.TabIndex = 2
        '
        'LblItemName
        '
        Me.LblItemName.AutoSize = True
        Me.LblItemName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemName.Location = New System.Drawing.Point(364, 0)
        Me.LblItemName.Name = "LblItemName"
        Me.LblItemName.Size = New System.Drawing.Size(145, 19)
        Me.LblItemName.TabIndex = 74
        Me.LblItemName.Text = "إسم الصنف"
        Me.LblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtItemBarcode
        '
        Me.TxtItemBarcode.AcceptsTab = True
        Me.TxtItemBarcode.BackColor = System.Drawing.Color.White
        Me.TxtItemBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemBarcode.HideSelection = False
        Me.TxtItemBarcode.Location = New System.Drawing.Point(666, 22)
        Me.TxtItemBarcode.MaxLength = 65535
        Me.TxtItemBarcode.Name = "TxtItemBarcode"
        Me.TxtItemBarcode.ShowClearButton = True
        Me.TxtItemBarcode.Size = New System.Drawing.Size(145, 24)
        Me.TxtItemBarcode.TabIndex = 0
        Me.TxtItemBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemBarcode.ThemeName = "Office2010Blue"
        Me.TxtItemBarcode.WordWrap = False
        '
        'LblItemID
        '
        Me.LblItemID.AutoSize = True
        Me.LblItemID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblItemID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblItemID.Location = New System.Drawing.Point(515, 0)
        Me.LblItemID.Name = "LblItemID"
        Me.LblItemID.Size = New System.Drawing.Size(145, 19)
        Me.LblItemID.TabIndex = 73
        Me.LblItemID.Text = "كود الصنف"
        Me.LblItemID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBarcode
        '
        Me.LblBarcode.AutoSize = True
        Me.LblBarcode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblBarcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBarcode.Location = New System.Drawing.Point(666, 0)
        Me.LblBarcode.Name = "LblBarcode"
        Me.LblBarcode.Size = New System.Drawing.Size(145, 19)
        Me.LblBarcode.TabIndex = 66
        Me.LblBarcode.Text = "الباركود"
        Me.LblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtItemid
        '
        Me.TxtItemid.AcceptsTab = True
        Me.TxtItemid.BackColor = System.Drawing.Color.White
        Me.TxtItemid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemid.HideSelection = False
        Me.TxtItemid.Location = New System.Drawing.Point(515, 22)
        Me.TxtItemid.Mask = "G"
        Me.TxtItemid.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtItemid.Name = "TxtItemid"
        Me.TxtItemid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtItemid.Size = New System.Drawing.Size(145, 24)
        Me.TxtItemid.TabIndex = 1
        Me.TxtItemid.TabStop = False
        Me.TxtItemid.Text = "0"
        Me.TxtItemid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemid.ThemeName = "Office2010Blue"
        '
        'TxtItemName
        '
        Me.TxtItemName.AcceptsTab = True
        Me.TxtItemName.BackColor = System.Drawing.Color.White
        Me.TxtItemName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItemName.HideSelection = False
        Me.TxtItemName.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.ATxtItemNameBtn})
        Me.TxtItemName.Location = New System.Drawing.Point(364, 22)
        Me.TxtItemName.MaxLength = 65535
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.ShowClearButton = True
        Me.TxtItemName.Size = New System.Drawing.Size(145, 24)
        Me.TxtItemName.TabIndex = 2
        Me.TxtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtItemName.ThemeName = "Office2010Blue"
        Me.TxtItemName.WordWrap = False
        '
        'ATxtItemNameBtn
        '
        Me.ATxtItemNameBtn.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.ATxtItemNameBtn.Image = Global.HEHAccounting.My.Resources.Resources.find
        Me.ATxtItemNameBtn.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.ATxtItemNameBtn.Name = "ATxtItemNameBtn"
        Me.ATxtItemNameBtn.SmallImage = Global.HEHAccounting.My.Resources.Resources.find
        Me.ATxtItemNameBtn.Text = ""
        Me.ATxtItemNameBtn.UseCompatibleTextRendering = False
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.HEHAccounting.My.Resources.Resources.Create
        Me.BtnAdd.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Location = New System.Drawing.Point(247, 8)
        Me.BtnAdd.Name = "BtnAdd"
        Me.TLPHeader.SetRowSpan(Me.BtnAdd, 2)
        Me.BtnAdd.Size = New System.Drawing.Size(91, 37)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Tag = "Save"
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'TLPCommand
        '
        Me.TLPCommand.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TLPCommand.ColumnCount = 2
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.Controls.Add(Me.BtnSaveAndNew, 0, 0)
        Me.TLPCommand.Controls.Add(Me.BtnPrint, 1, 0)
        Me.TLPCommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLPCommand.Location = New System.Drawing.Point(822, 433)
        Me.TLPCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPCommand.Name = "TLPCommand"
        Me.TLPCommand.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.TLPCommand.RowCount = 3
        Me.TableLayoutPanel1.SetRowSpan(Me.TLPCommand, 2)
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLPCommand.Size = New System.Drawing.Size(242, 49)
        Me.TLPCommand.TabIndex = 1
        '
        'BtnSaveAndNew
        '
        Me.BtnSaveAndNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSaveAndNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveAndNew.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSaveAndNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveAndNew.Location = New System.Drawing.Point(123, 3)
        Me.BtnSaveAndNew.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.BtnSaveAndNew.Name = "BtnSaveAndNew"
        Me.BtnSaveAndNew.Size = New System.Drawing.Size(104, 32)
        Me.BtnSaveAndNew.TabIndex = 1
        Me.BtnSaveAndNew.Tag = "Save"
        Me.BtnSaveAndNew.Text = "حفظ _ جديد"
        Me.BtnSaveAndNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Image = Global.HEHAccounting.My.Resources.Resources.print
        Me.BtnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPrint.Location = New System.Drawing.Point(9, 3)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(104, 33)
        Me.BtnPrint.TabIndex = 2
        Me.BtnPrint.Tag = "Print"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'GridInvItem
        '
        Me.GridInvItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridInvItem.Location = New System.Drawing.Point(5, 63)
        '
        '
        '
        GridViewSummaryItem7.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem7.AggregateExpression = Nothing
        GridViewSummaryItem7.FormatString = "{0}"
        GridViewSummaryItem7.Name = "SubTotal"
        GridViewSummaryItem8.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem8.AggregateExpression = Nothing
        GridViewSummaryItem8.FormatString = "{0}"
        GridViewSummaryItem8.Name = "ItemDiscount"
        GridViewSummaryItem9.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem9.AggregateExpression = Nothing
        GridViewSummaryItem9.FormatString = "{0}"
        GridViewSummaryItem9.Name = "TotalDue"
        Me.GridInvItem.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem7, GridViewSummaryItem8, GridViewSummaryItem9}))
        Me.GridInvItem.MasterTemplate.ViewDefinition = TableViewDefinition3
        Me.GridInvItem.Name = "GridInvItem"
        Me.GridInvItem.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell
        Me.TableLayoutPanel1.SetRowSpan(Me.GridInvItem, 3)
        Me.GridInvItem.Size = New System.Drawing.Size(814, 416)
        Me.GridInvItem.TabIndex = 4
        Me.GridInvItem.TabStop = False
        '
        'txtDollarRate
        '
        Me.txtDollarRate.AcceptsTab = True
        Me.txtDollarRate.AutoSize = False
        Me.txtDollarRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDollarRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDollarRate.Enabled = False
        Me.txtDollarRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDollarRate.HideSelection = False
        Me.txtDollarRate.Location = New System.Drawing.Point(35, 3)
        Me.txtDollarRate.MaxLength = 65535
        Me.txtDollarRate.Name = "txtDollarRate"
        Me.txtDollarRate.Size = New System.Drawing.Size(121, 24)
        Me.txtDollarRate.TabIndex = 7
        Me.txtDollarRate.Tag = "1"
        Me.txtDollarRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDollarRate.ThemeName = "Office2010Blue"
        Me.txtDollarRate.WordWrap = False
        '
        'AddNewPurchaseInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 482)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNewPurchaseInvoice"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "فاتورة شراء"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TLPSOHeader.ResumeLayout(False)
        Me.TLPSOHeader.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.TxtCurrencyVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnGetCurrencyVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInvoiceReference, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.RadioPurchases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioReturns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtVendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTotalDue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtInvDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.RadioDebt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPHeader.ResumeLayout(False)
        Me.TLPHeader.PerformLayout()
        CType(Me.TxtItemBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPCommand.ResumeLayout(False)
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInvItem.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridInvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDollarRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TLPSOHeader As TableLayoutPanel
    Friend WithEvents LblInvID As Label
    Friend WithEvents LblDueTotal As Label
    Friend WithEvents LblDiscount As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents RadioPurchases As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadioReturns As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents LblInvSubTotal As Label
    Friend WithEvents LblInvVendor As Label
    Friend WithEvents LblInvDate As Label
    Friend WithEvents LblInvType As Label
    Friend WithEvents TxtInvID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtVendor As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents TxtVendorBtn As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents LblStatus As Label
    Friend WithEvents DropStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TxtSubTotal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtTotalDue As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblPaymentType As Label
    Friend WithEvents TxtDiscount As Telerik.WinControls.UI.RadMaskedEditBox
    Private WithEvents MskTxtInvDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RadioDebt As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadioCash As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents LblDropCurrency As Label
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents LblCurrValue As Label
    Friend WithEvents TLPHeader As TableLayoutPanel
    Friend WithEvents LblItemName As Label
    Friend WithEvents TxtItemBarcode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblItemID As Label
    Friend WithEvents LblBarcode As Label
    Friend WithEvents TxtItemid As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtItemName As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents ATxtItemNameBtn As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents GridInvItem As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TxtInvoiceReference As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblReference As Label
    Friend WithEvents TLPCommand As TableLayoutPanel
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents ToolTipVendor As ToolTip
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TxtCurrencyVal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BtnGetCurrencyVal As Telerik.WinControls.UI.RadButton
    Friend WithEvents LblPaid As Label
    Friend WithEvents txtDollarRate As Telerik.WinControls.UI.RadTextBox
End Class

