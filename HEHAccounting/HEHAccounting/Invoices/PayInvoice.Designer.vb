<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayInvoice
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
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtInvoiceCurrencySymb = New Telerik.WinControls.UI.RadTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.LblDesc = New System.Windows.Forms.Label()
        Me.lblCurrencyRate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtInvID = New Telerik.WinControls.UI.RadTextBox()
        Me.LblInvID = New System.Windows.Forms.Label()
        Me.TxtInvType = New Telerik.WinControls.UI.RadTextBox()
        Me.LblInvType = New System.Windows.Forms.Label()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.LblDueTotal = New System.Windows.Forms.Label()
        Me.LblInvDate = New System.Windows.Forms.Label()
        Me.MskTxtPayDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.txtDollarRate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtPaymentAmount = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInvPaymentTotalUSD = New Telerik.WinControls.UI.RadTextBox()
        Me.txtInvPaymentTotalLL = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.txtInvTotalUSD = New Telerik.WinControls.UI.RadTextBox()
        Me.txtInvTotalLL = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.chkInvoiceISCompletePaid = New Telerik.WinControls.UI.RadCheckBox()
        Me.TLPCommand = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPay = New Telerik.WinControls.UI.RadButton()
        Me.BtnPrint = New Telerik.WinControls.UI.RadButton()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtInvoiceCurrencySymb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInvType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MskTxtPayDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDollarRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPaymentAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvPaymentTotalUSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvPaymentTotalLL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvTotalUSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvTotalLL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkInvoiceISCompletePaid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPCommand.SuspendLayout()
        CType(Me.BtnPay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.91409!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.14089!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.94502!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtInvoiceCurrencySymb, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtDesc, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDesc, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCurrencyRate, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtInvID, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvID, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtInvType, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvType, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DropCurrency, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDueTotal, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblInvDate, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MskTxtPayDate, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDollarRate, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtPaymentAmount, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtInvPaymentTotalUSD, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtInvPaymentTotalLL, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtInvTotalUSD, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtInvTotalLL, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkInvoiceISCompletePaid, 3, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(635, 230)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtInvoiceCurrencySymb
        '
        Me.txtInvoiceCurrencySymb.AcceptsTab = True
        Me.txtInvoiceCurrencySymb.BackColor = System.Drawing.Color.White
        Me.txtInvoiceCurrencySymb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInvoiceCurrencySymb.Enabled = False
        Me.txtInvoiceCurrencySymb.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceCurrencySymb.HideSelection = False
        Me.txtInvoiceCurrencySymb.Location = New System.Drawing.Point(339, 63)
        Me.txtInvoiceCurrencySymb.MaxLength = 65535
        Me.txtInvoiceCurrencySymb.Name = "txtInvoiceCurrencySymb"
        Me.txtInvoiceCurrencySymb.ReadOnly = True
        Me.txtInvoiceCurrencySymb.Size = New System.Drawing.Size(174, 24)
        Me.txtInvoiceCurrencySymb.TabIndex = 41
        Me.txtInvoiceCurrencySymb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInvoiceCurrencySymb.ThemeName = "Office2010Blue"
        Me.txtInvoiceCurrencySymb.WordWrap = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(519, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 30)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "عملة الفاتورة"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDesc
        '
        Me.TxtDesc.BackColor = System.Drawing.Color.White
        Me.TxtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(3, 123)
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        '
        '
        '
        Me.TxtDesc.RootElement.StretchVertically = True
        Me.TableLayoutPanel1.SetRowSpan(Me.TxtDesc, 2)
        Me.TxtDesc.Size = New System.Drawing.Size(180, 54)
        Me.TxtDesc.TabIndex = 39
        Me.TxtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDesc.ThemeName = "Office2010Blue"
        '
        'LblDesc
        '
        Me.LblDesc.AutoSize = True
        Me.LblDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesc.Location = New System.Drawing.Point(189, 120)
        Me.LblDesc.Name = "LblDesc"
        Me.TableLayoutPanel1.SetRowSpan(Me.LblDesc, 3)
        Me.LblDesc.Size = New System.Drawing.Size(144, 90)
        Me.LblDesc.TabIndex = 38
        Me.LblDesc.Text = "ملاحظات"
        Me.LblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurrencyRate
        '
        Me.lblCurrencyRate.AutoSize = True
        Me.lblCurrencyRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCurrencyRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrencyRate.Location = New System.Drawing.Point(189, 30)
        Me.lblCurrencyRate.Name = "lblCurrencyRate"
        Me.lblCurrencyRate.Size = New System.Drawing.Size(144, 30)
        Me.lblCurrencyRate.TabIndex = 30
        Me.lblCurrencyRate.Text = "سعر الصرف"
        Me.lblCurrencyRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(189, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 30)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "العملة"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInvID
        '
        Me.TxtInvID.AcceptsTab = True
        Me.TxtInvID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvID.Enabled = False
        Me.TxtInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvID.HideSelection = False
        Me.TxtInvID.Location = New System.Drawing.Point(339, 3)
        Me.TxtInvID.MaxLength = 65535
        Me.TxtInvID.Name = "TxtInvID"
        Me.TxtInvID.ReadOnly = True
        Me.TxtInvID.Size = New System.Drawing.Size(174, 24)
        Me.TxtInvID.TabIndex = 10
        Me.TxtInvID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInvID.ThemeName = "Office2010Blue"
        Me.TxtInvID.WordWrap = False
        '
        'LblInvID
        '
        Me.LblInvID.AutoSize = True
        Me.LblInvID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvID.Location = New System.Drawing.Point(519, 0)
        Me.LblInvID.Name = "LblInvID"
        Me.LblInvID.Size = New System.Drawing.Size(113, 30)
        Me.LblInvID.TabIndex = 11
        Me.LblInvID.Text = "رقم الفاتورة"
        Me.LblInvID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInvType
        '
        Me.TxtInvType.AcceptsTab = True
        Me.TxtInvType.BackColor = System.Drawing.Color.White
        Me.TxtInvType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInvType.Enabled = False
        Me.TxtInvType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvType.HideSelection = False
        Me.TxtInvType.Location = New System.Drawing.Point(339, 33)
        Me.TxtInvType.MaxLength = 65535
        Me.TxtInvType.Name = "TxtInvType"
        Me.TxtInvType.ReadOnly = True
        Me.TxtInvType.Size = New System.Drawing.Size(174, 24)
        Me.TxtInvType.TabIndex = 21
        Me.TxtInvType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInvType.ThemeName = "Office2010Blue"
        Me.TxtInvType.WordWrap = False
        '
        'LblInvType
        '
        Me.LblInvType.AutoSize = True
        Me.LblInvType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvType.Location = New System.Drawing.Point(519, 30)
        Me.LblInvType.Name = "LblInvType"
        Me.LblInvType.Size = New System.Drawing.Size(113, 30)
        Me.LblInvType.TabIndex = 20
        Me.LblInvType.Text = "النوع"
        Me.LblInvType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropCurrency
        '
        Me.DropCurrency.BackColor = System.Drawing.Color.White
        Me.DropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropCurrency.DropDownAnimationEnabled = True
        Me.DropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrency.Location = New System.Drawing.Point(3, 3)
        Me.DropCurrency.MaxLength = 65535
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Size = New System.Drawing.Size(180, 24)
        Me.DropCurrency.TabIndex = 24
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'LblDueTotal
        '
        Me.LblDueTotal.AutoSize = True
        Me.LblDueTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDueTotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDueTotal.Location = New System.Drawing.Point(189, 60)
        Me.LblDueTotal.Name = "LblDueTotal"
        Me.LblDueTotal.Size = New System.Drawing.Size(144, 30)
        Me.LblDueTotal.TabIndex = 14
        Me.LblDueTotal.Text = "المبلغ المسدد"
        Me.LblDueTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblInvDate
        '
        Me.LblInvDate.AutoSize = True
        Me.LblInvDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblInvDate.Location = New System.Drawing.Point(189, 90)
        Me.LblInvDate.Name = "LblInvDate"
        Me.LblInvDate.Size = New System.Drawing.Size(144, 30)
        Me.LblInvDate.TabIndex = 22
        Me.LblInvDate.Text = "تاريخ التسديد"
        Me.LblInvDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MskTxtPayDate
        '
        Me.MskTxtPayDate.BackColor = System.Drawing.Color.White
        Me.MskTxtPayDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MskTxtPayDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskTxtPayDate.Location = New System.Drawing.Point(3, 93)
        Me.MskTxtPayDate.Mask = "dd/MM/yyyy"
        Me.MskTxtPayDate.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.MskTxtPayDate.Name = "MskTxtPayDate"
        Me.MskTxtPayDate.SelectedText = "01"
        Me.MskTxtPayDate.SelectionLength = 2
        Me.MskTxtPayDate.Size = New System.Drawing.Size(180, 24)
        Me.MskTxtPayDate.TabIndex = 23
        Me.MskTxtPayDate.TabStop = False
        Me.MskTxtPayDate.Text = "01/01/2020"
        Me.MskTxtPayDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MskTxtPayDate.ThemeName = "Office2010Blue"
        '
        'txtDollarRate
        '
        Me.txtDollarRate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDollarRate.Enabled = False
        Me.txtDollarRate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDollarRate.Location = New System.Drawing.Point(3, 33)
        Me.txtDollarRate.Mask = "F0"
        Me.txtDollarRate.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtDollarRate.Name = "txtDollarRate"
        Me.txtDollarRate.NullText = "1"
        Me.txtDollarRate.Size = New System.Drawing.Size(180, 24)
        Me.txtDollarRate.TabIndex = 36
        Me.txtDollarRate.TabStop = False
        Me.txtDollarRate.Text = "0"
        Me.txtDollarRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDollarRate.ThemeName = "Office2010Blue"
        '
        'TxtPaymentAmount
        '
        Me.TxtPaymentAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPaymentAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtPaymentAmount.Location = New System.Drawing.Point(3, 63)
        Me.TxtPaymentAmount.Mask = "F3"
        Me.TxtPaymentAmount.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtPaymentAmount.Name = "TxtPaymentAmount"
        Me.TxtPaymentAmount.NullText = "1"
        Me.TxtPaymentAmount.PromptChar = Global.Microsoft.VisualBasic.ChrW(46)
        Me.TxtPaymentAmount.Size = New System.Drawing.Size(180, 24)
        Me.TxtPaymentAmount.TabIndex = 37
        Me.TxtPaymentAmount.TabStop = False
        Me.TxtPaymentAmount.Text = "0.000"
        Me.TxtPaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPaymentAmount.ThemeName = "Office2010Blue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(519, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 30)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "مجموع الدفعات $"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(519, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 30)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "مجموع الدفعات ل.ل"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(519, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 30)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "مجموع الفاتورة $"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 30)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "مجموع الفاتورة ل.ل"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInvPaymentTotalUSD
        '
        Me.txtInvPaymentTotalUSD.AcceptsTab = True
        Me.txtInvPaymentTotalUSD.BackColor = System.Drawing.Color.White
        Me.txtInvPaymentTotalUSD.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtInvPaymentTotalUSD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInvPaymentTotalUSD.Enabled = False
        Me.txtInvPaymentTotalUSD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvPaymentTotalUSD.HideSelection = False
        Me.txtInvPaymentTotalUSD.Location = New System.Drawing.Point(339, 183)
        Me.txtInvPaymentTotalUSD.MaxLength = 65535
        Me.txtInvPaymentTotalUSD.Name = "txtInvPaymentTotalUSD"
        Me.txtInvPaymentTotalUSD.ReadOnly = True
        Me.txtInvPaymentTotalUSD.Size = New System.Drawing.Size(174, 24)
        Me.txtInvPaymentTotalUSD.TabIndex = 35
        Me.txtInvPaymentTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInvPaymentTotalUSD.ThemeName = "Office2010Blue"
        Me.txtInvPaymentTotalUSD.WordWrap = False
        '
        'txtInvPaymentTotalLL
        '
        Me.txtInvPaymentTotalLL.AcceptsTab = True
        Me.txtInvPaymentTotalLL.BackColor = System.Drawing.Color.White
        Me.txtInvPaymentTotalLL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInvPaymentTotalLL.Enabled = False
        Me.txtInvPaymentTotalLL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvPaymentTotalLL.HideSelection = False
        Me.txtInvPaymentTotalLL.Location = New System.Drawing.Point(339, 153)
        Me.txtInvPaymentTotalLL.Name = "txtInvPaymentTotalLL"
        Me.txtInvPaymentTotalLL.ReadOnly = True
        Me.txtInvPaymentTotalLL.Size = New System.Drawing.Size(174, 24)
        Me.txtInvPaymentTotalLL.TabIndex = 34
        Me.txtInvPaymentTotalLL.TabStop = False
        Me.txtInvPaymentTotalLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInvPaymentTotalLL.ThemeName = "Office2010Blue"
        '
        'txtInvTotalUSD
        '
        Me.txtInvTotalUSD.AcceptsTab = True
        Me.txtInvTotalUSD.BackColor = System.Drawing.Color.White
        Me.txtInvTotalUSD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInvTotalUSD.Enabled = False
        Me.txtInvTotalUSD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvTotalUSD.HideSelection = False
        Me.txtInvTotalUSD.Location = New System.Drawing.Point(339, 123)
        Me.txtInvTotalUSD.MaxLength = 65535
        Me.txtInvTotalUSD.Name = "txtInvTotalUSD"
        Me.txtInvTotalUSD.ReadOnly = True
        Me.txtInvTotalUSD.Size = New System.Drawing.Size(174, 24)
        Me.txtInvTotalUSD.TabIndex = 28
        Me.txtInvTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInvTotalUSD.ThemeName = "Office2010Blue"
        Me.txtInvTotalUSD.WordWrap = False
        '
        'txtInvTotalLL
        '
        Me.txtInvTotalLL.AcceptsTab = True
        Me.txtInvTotalLL.BackColor = System.Drawing.Color.White
        Me.txtInvTotalLL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtInvTotalLL.Enabled = False
        Me.txtInvTotalLL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvTotalLL.HideSelection = False
        Me.txtInvTotalLL.Location = New System.Drawing.Point(339, 93)
        Me.txtInvTotalLL.Name = "txtInvTotalLL"
        Me.txtInvTotalLL.ReadOnly = True
        Me.txtInvTotalLL.Size = New System.Drawing.Size(174, 24)
        Me.txtInvTotalLL.TabIndex = 27
        Me.txtInvTotalLL.TabStop = False
        Me.txtInvTotalLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInvTotalLL.ThemeName = "Office2010Blue"
        '
        'chkInvoiceISCompletePaid
        '
        Me.chkInvoiceISCompletePaid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkInvoiceISCompletePaid.Location = New System.Drawing.Point(43, 183)
        Me.chkInvoiceISCompletePaid.Name = "chkInvoiceISCompletePaid"
        Me.chkInvoiceISCompletePaid.Size = New System.Drawing.Size(140, 22)
        Me.chkInvoiceISCompletePaid.TabIndex = 42
        Me.chkInvoiceISCompletePaid.Text = "تم تسديد كامل الفاتورة"
        '
        'TLPCommand
        '
        Me.TLPCommand.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TLPCommand.ColumnCount = 6
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLPCommand.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TLPCommand.Controls.Add(Me.BtnPay, 1, 0)
        Me.TLPCommand.Controls.Add(Me.BtnPrint, 3, 0)
        Me.TLPCommand.Controls.Add(Me.BtnClose, 4, 0)
        Me.TLPCommand.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLPCommand.Location = New System.Drawing.Point(0, 230)
        Me.TLPCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPCommand.Name = "TLPCommand"
        Me.TLPCommand.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.TLPCommand.RowCount = 1
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPCommand.Size = New System.Drawing.Size(635, 39)
        Me.TLPCommand.TabIndex = 7
        '
        'BtnPay
        '
        Me.BtnPay.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnPay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPay.Image = Global.HEHAccounting.My.Resources.Resources.money
        Me.BtnPay.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPay.Location = New System.Drawing.Point(376, 3)
        Me.BtnPay.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(100, 32)
        Me.BtnPay.TabIndex = 1
        Me.BtnPay.Tag = "Save"
        Me.BtnPay.Text = "تسديد"
        Me.BtnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnPrint.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Image = Global.HEHAccounting.My.Resources.Resources.print
        Me.BtnPrint.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPrint.Location = New System.Drawing.Point(266, 3)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(100, 32)
        Me.BtnPrint.TabIndex = 2
        Me.BtnPrint.Tag = "Print"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrint.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(160, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 32)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'PayInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 269)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TLPCommand)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PayInvoice"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تسديد فاتورة"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txtInvoiceCurrencySymb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInvID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInvType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MskTxtPayDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDollarRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPaymentAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvPaymentTotalUSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvPaymentTotalLL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvTotalUSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvTotalLL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkInvoiceISCompletePaid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPCommand.ResumeLayout(False)
        CType(Me.BtnPay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtInvID As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblInvID As Label
    Friend WithEvents LblDueTotal As Label
    Friend WithEvents TLPCommand As TableLayoutPanel
    Friend WithEvents BtnPay As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtInvType As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblInvType As Label
    Private WithEvents MskTxtPayDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblInvDate As Label
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInvTotalLL As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtInvTotalUSD As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCurrencyRate As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInvPaymentTotalLL As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtInvPaymentTotalUSD As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtDollarRate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtPaymentAmount As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblDesc As Label
    Friend WithEvents TxtDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txtInvoiceCurrencySymb As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkInvoiceISCompletePaid As Telerik.WinControls.UI.RadCheckBox
End Class

