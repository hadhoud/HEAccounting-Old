<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NotesPayable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotesPayable))
        Me.TlpFill = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtCurrencyVal = New Telerik.WinControls.UI.RadTextBox()
        Me.BtnGetCurrencyVal = New Telerik.WinControls.UI.RadButton()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.DropStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.TxtAmount = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtVendor = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.TxtVendorBtn = New Telerik.WinControls.UI.RadButtonElement()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadioCheck = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadioCash = New Telerik.WinControls.UI.RadRadioButton()
        Me.LblEqualValue = New System.Windows.Forms.Label()
        Me.LblPaymentType = New System.Windows.Forms.Label()
        Me.TxtAccBalance = New Telerik.WinControls.UI.RadTextBox()
        Me.LblValue = New System.Windows.Forms.Label()
        Me.LblBalance = New System.Windows.Forms.Label()
        Me.LblVendor = New System.Windows.Forms.Label()
        Me.LblCurrencyVal = New System.Windows.Forms.Label()
        Me.LblCurrency = New System.Windows.Forms.Label()
        Me.LblDueDate = New System.Windows.Forms.Label()
        Me.LblCode = New System.Windows.Forms.Label()
        Me.TxtCode = New Telerik.WinControls.UI.RadTextBox()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.TxtDueDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtEqualValue = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TlpCheck = New System.Windows.Forms.TableLayoutPanel()
        Me.DropCheckStatus = New Telerik.WinControls.UI.RadDropDownList()
        Me.TxtDesc = New Telerik.WinControls.UI.RadTextBox()
        Me.LblDesc = New System.Windows.Forms.Label()
        Me.LblCheckType = New System.Windows.Forms.Label()
        Me.LblBankName = New System.Windows.Forms.Label()
        Me.LblCheckDueDate = New System.Windows.Forms.Label()
        Me.LblCheckNum = New System.Windows.Forms.Label()
        Me.TxtCheckNum = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtCheckDueDate = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtBankName = New Telerik.WinControls.UI.RadTextBox()
        Me.ChkAlert = New Telerik.WinControls.UI.RadCheckBox()
        Me.TLPCommand = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        Me.BtnPrint = New Telerik.WinControls.UI.RadButton()
        Me.BtnInvAttach = New Telerik.WinControls.UI.RadButton()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.VendorTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TlpFill.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.TxtCurrencyVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnGetCurrencyVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.RadioCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadioCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAccBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtEqualValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlpCheck.SuspendLayout()
        CType(Me.DropCheckStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCheckNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCheckDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBankName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLPCommand.SuspendLayout()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnInvAttach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TlpFill
        '
        Me.TlpFill.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TlpFill.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TlpFill.ColumnCount = 2
        Me.TlpFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpFill.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpFill.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TlpFill.Controls.Add(Me.TlpCheck, 1, 0)
        Me.TlpFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpFill.Location = New System.Drawing.Point(0, 0)
        Me.TlpFill.Name = "TlpFill"
        Me.TlpFill.RowCount = 1
        Me.TlpFill.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpFill.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 312.0!))
        Me.TlpFill.Size = New System.Drawing.Size(549, 314)
        Me.TlpFill.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LblStatus, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DropStatus, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtAmount, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtVendor, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.LblEqualValue, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.LblPaymentType, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtAccBalance, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.LblValue, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.LblBalance, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.LblVendor, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.LblCurrencyVal, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LblCurrency, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LblDueDate, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LblCode, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtCode, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DropCurrency, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtDueDate, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TxtEqualValue, 1, 8)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(279, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 10
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(265, 304)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.TxtCurrencyVal, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnGetCurrencyVal, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 123)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(184, 30)
        Me.TableLayoutPanel4.TabIndex = 44
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
        Me.TxtCurrencyVal.Size = New System.Drawing.Size(146, 24)
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
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Location = New System.Drawing.Point(187, 30)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(75, 30)
        Me.LblStatus.TabIndex = 41
        Me.LblStatus.Text = "الحالة"
        Me.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DropStatus
        '
        Me.DropStatus.BackColor = System.Drawing.Color.White
        Me.DropStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropStatus.Location = New System.Drawing.Point(3, 33)
        Me.DropStatus.MaxLength = 65535
        Me.DropStatus.Name = "DropStatus"
        Me.DropStatus.Size = New System.Drawing.Size(178, 24)
        Me.DropStatus.TabIndex = 1
        Me.DropStatus.Tag = ""
        Me.DropStatus.ThemeName = "Office2010Blue"
        '
        'TxtAmount
        '
        Me.TxtAmount.BackColor = System.Drawing.Color.White
        Me.TxtAmount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAmount.Location = New System.Drawing.Point(3, 219)
        Me.TxtAmount.Mask = "G"
        Me.TxtAmount.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(178, 24)
        Me.TxtAmount.TabIndex = 7
        Me.TxtAmount.TabStop = False
        Me.TxtAmount.Text = "0"
        Me.TxtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAmount.ThemeName = "Office2010Blue"
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
        Me.TxtVendor.Location = New System.Drawing.Point(3, 159)
        Me.TxtVendor.MaxLength = 65535
        Me.TxtVendor.Name = "TxtVendor"
        Me.TxtVendor.ShortcutsEnabled = False
        Me.TxtVendor.ShowClearButton = True
        Me.TxtVendor.Size = New System.Drawing.Size(178, 24)
        Me.TxtVendor.TabIndex = 5
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
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.RadioCheck, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RadioCash, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 279)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(178, 28)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'RadioCheck
        '
        Me.RadioCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RadioCheck.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioCheck.Location = New System.Drawing.Point(22, 3)
        Me.RadioCheck.Name = "RadioCheck"
        Me.RadioCheck.Size = New System.Drawing.Size(45, 22)
        Me.RadioCheck.TabIndex = 1
        Me.RadioCheck.TabStop = False
        Me.RadioCheck.Tag = "Ch"
        Me.RadioCheck.Text = "شيك"
        Me.RadioCheck.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioCheck.ThemeName = "Office2010Blue"
        '
        'RadioCash
        '
        Me.RadioCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RadioCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioCash.Location = New System.Drawing.Point(113, 3)
        Me.RadioCash.Name = "RadioCash"
        Me.RadioCash.Size = New System.Drawing.Size(41, 22)
        Me.RadioCash.TabIndex = 0
        Me.RadioCash.TabStop = False
        Me.RadioCash.Tag = "C"
        Me.RadioCash.Text = "نقدا"
        Me.RadioCash.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioCash.ThemeName = "Office2010Blue"
        '
        'LblEqualValue
        '
        Me.LblEqualValue.AutoSize = True
        Me.LblEqualValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblEqualValue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEqualValue.Location = New System.Drawing.Point(187, 246)
        Me.LblEqualValue.Name = "LblEqualValue"
        Me.LblEqualValue.Size = New System.Drawing.Size(75, 30)
        Me.LblEqualValue.TabIndex = 35
        Me.LblEqualValue.Text = "تعادل القيمة"
        Me.LblEqualValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPaymentType
        '
        Me.LblPaymentType.AutoSize = True
        Me.LblPaymentType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPaymentType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaymentType.Location = New System.Drawing.Point(187, 276)
        Me.LblPaymentType.Name = "LblPaymentType"
        Me.LblPaymentType.Size = New System.Drawing.Size(75, 34)
        Me.LblPaymentType.TabIndex = 24
        Me.LblPaymentType.Text = "طريقة الدفع"
        Me.LblPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtAccBalance
        '
        Me.TxtAccBalance.AcceptsTab = True
        Me.TxtAccBalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtAccBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAccBalance.Enabled = False
        Me.TxtAccBalance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAccBalance.HideSelection = False
        Me.TxtAccBalance.Location = New System.Drawing.Point(3, 189)
        Me.TxtAccBalance.MaxLength = 65535
        Me.TxtAccBalance.Name = "TxtAccBalance"
        Me.TxtAccBalance.Size = New System.Drawing.Size(178, 24)
        Me.TxtAccBalance.TabIndex = 6
        Me.TxtAccBalance.Tag = "1"
        Me.TxtAccBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAccBalance.ThemeName = "Office2010Blue"
        Me.TxtAccBalance.WordWrap = False
        '
        'LblValue
        '
        Me.LblValue.AutoSize = True
        Me.LblValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblValue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValue.Location = New System.Drawing.Point(187, 216)
        Me.LblValue.Name = "LblValue"
        Me.LblValue.Size = New System.Drawing.Size(75, 30)
        Me.LblValue.TabIndex = 33
        Me.LblValue.Text = "القيمة"
        Me.LblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBalance
        '
        Me.LblBalance.AutoSize = True
        Me.LblBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblBalance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalance.Location = New System.Drawing.Point(187, 186)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(75, 30)
        Me.LblBalance.TabIndex = 32
        Me.LblBalance.Text = "الرصيد"
        Me.LblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblVendor
        '
        Me.LblVendor.AutoSize = True
        Me.LblVendor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblVendor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVendor.Location = New System.Drawing.Point(187, 156)
        Me.LblVendor.Name = "LblVendor"
        Me.LblVendor.Size = New System.Drawing.Size(75, 30)
        Me.LblVendor.TabIndex = 31
        Me.LblVendor.Text = "المورد"
        Me.LblVendor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCurrencyVal
        '
        Me.LblCurrencyVal.AutoSize = True
        Me.LblCurrencyVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCurrencyVal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrencyVal.Location = New System.Drawing.Point(187, 120)
        Me.LblCurrencyVal.Name = "LblCurrencyVal"
        Me.LblCurrencyVal.Size = New System.Drawing.Size(75, 36)
        Me.LblCurrencyVal.TabIndex = 30
        Me.LblCurrencyVal.Text = "قيمة الصرف"
        Me.LblCurrencyVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCurrency
        '
        Me.LblCurrency.AutoSize = True
        Me.LblCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrency.Location = New System.Drawing.Point(187, 90)
        Me.LblCurrency.Name = "LblCurrency"
        Me.LblCurrency.Size = New System.Drawing.Size(75, 30)
        Me.LblCurrency.TabIndex = 29
        Me.LblCurrency.Text = "العملة"
        Me.LblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDueDate
        '
        Me.LblDueDate.AutoSize = True
        Me.LblDueDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDueDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDueDate.Location = New System.Drawing.Point(187, 60)
        Me.LblDueDate.Name = "LblDueDate"
        Me.LblDueDate.Size = New System.Drawing.Size(75, 30)
        Me.LblDueDate.TabIndex = 28
        Me.LblDueDate.Text = "التاريخ"
        Me.LblDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCode
        '
        Me.LblCode.AutoSize = True
        Me.LblCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode.Location = New System.Drawing.Point(187, 0)
        Me.LblCode.Name = "LblCode"
        Me.LblCode.Size = New System.Drawing.Size(75, 30)
        Me.LblCode.TabIndex = 27
        Me.LblCode.Text = "رقم السند"
        Me.LblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCode
        '
        Me.TxtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCode.Enabled = False
        Me.TxtCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCode.Location = New System.Drawing.Point(3, 3)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(178, 24)
        Me.TxtCode.TabIndex = 0
        Me.TxtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCode.ThemeName = "Office2010Blue"
        '
        'DropCurrency
        '
        Me.DropCurrency.BackColor = System.Drawing.Color.White
        Me.DropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrency.Location = New System.Drawing.Point(3, 93)
        Me.DropCurrency.MaxLength = 65535
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Size = New System.Drawing.Size(178, 24)
        Me.DropCurrency.TabIndex = 3
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'TxtDueDate
        '
        Me.TxtDueDate.BackColor = System.Drawing.Color.White
        Me.TxtDueDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDueDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDueDate.Location = New System.Drawing.Point(3, 63)
        Me.TxtDueDate.Mask = "dd/MM/yyyy"
        Me.TxtDueDate.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.TxtDueDate.Name = "TxtDueDate"
        Me.TxtDueDate.Size = New System.Drawing.Size(178, 24)
        Me.TxtDueDate.TabIndex = 2
        Me.TxtDueDate.TabStop = False
        Me.TxtDueDate.Text = "01/01/2020"
        Me.TxtDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDueDate.ThemeName = "Office2010Blue"
        '
        'TxtEqualValue
        '
        Me.TxtEqualValue.AcceptsTab = True
        Me.TxtEqualValue.BackColor = System.Drawing.Color.White
        Me.TxtEqualValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtEqualValue.Enabled = False
        Me.TxtEqualValue.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEqualValue.HideSelection = False
        Me.TxtEqualValue.Location = New System.Drawing.Point(3, 249)
        Me.TxtEqualValue.Name = "TxtEqualValue"
        Me.TxtEqualValue.Size = New System.Drawing.Size(178, 24)
        Me.TxtEqualValue.TabIndex = 8
        Me.TxtEqualValue.TabStop = False
        Me.TxtEqualValue.Text = "0"
        Me.TxtEqualValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtEqualValue.ThemeName = "Office2010Blue"
        '
        'TlpCheck
        '
        Me.TlpCheck.ColumnCount = 2
        Me.TlpCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpCheck.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpCheck.Controls.Add(Me.DropCheckStatus, 1, 3)
        Me.TlpCheck.Controls.Add(Me.TxtDesc, 1, 5)
        Me.TlpCheck.Controls.Add(Me.LblDesc, 0, 5)
        Me.TlpCheck.Controls.Add(Me.LblCheckType, 0, 3)
        Me.TlpCheck.Controls.Add(Me.LblBankName, 0, 2)
        Me.TlpCheck.Controls.Add(Me.LblCheckDueDate, 0, 1)
        Me.TlpCheck.Controls.Add(Me.LblCheckNum, 0, 0)
        Me.TlpCheck.Controls.Add(Me.TxtCheckNum, 1, 0)
        Me.TlpCheck.Controls.Add(Me.TxtCheckDueDate, 1, 1)
        Me.TlpCheck.Controls.Add(Me.TxtBankName, 1, 2)
        Me.TlpCheck.Controls.Add(Me.ChkAlert, 0, 4)
        Me.TlpCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpCheck.Location = New System.Drawing.Point(5, 5)
        Me.TlpCheck.Name = "TlpCheck"
        Me.TlpCheck.RowCount = 6
        Me.TlpCheck.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpCheck.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpCheck.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpCheck.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpCheck.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpCheck.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TlpCheck.Size = New System.Drawing.Size(266, 304)
        Me.TlpCheck.TabIndex = 1
        '
        'DropCheckStatus
        '
        Me.DropCheckStatus.BackColor = System.Drawing.Color.White
        Me.DropCheckStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropCheckStatus.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCheckStatus.Location = New System.Drawing.Point(3, 93)
        Me.DropCheckStatus.MaxLength = 65535
        Me.DropCheckStatus.Name = "DropCheckStatus"
        Me.DropCheckStatus.Size = New System.Drawing.Size(160, 24)
        Me.DropCheckStatus.TabIndex = 3
        Me.DropCheckStatus.Tag = ""
        Me.DropCheckStatus.ThemeName = "Office2010Blue"
        '
        'TxtDesc
        '
        Me.TxtDesc.BackColor = System.Drawing.Color.White
        Me.TxtDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(3, 151)
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        '
        '
        '
        Me.TxtDesc.RootElement.StretchVertically = True
        Me.TxtDesc.Size = New System.Drawing.Size(160, 150)
        Me.TxtDesc.TabIndex = 5
        Me.TxtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDesc.ThemeName = "Office2010Blue"
        '
        'LblDesc
        '
        Me.LblDesc.AutoSize = True
        Me.LblDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesc.Location = New System.Drawing.Point(169, 148)
        Me.LblDesc.Name = "LblDesc"
        Me.LblDesc.Size = New System.Drawing.Size(94, 156)
        Me.LblDesc.TabIndex = 34
        Me.LblDesc.Text = "البيان"
        Me.LblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCheckType
        '
        Me.LblCheckType.AutoSize = True
        Me.LblCheckType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCheckType.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCheckType.Location = New System.Drawing.Point(169, 90)
        Me.LblCheckType.Name = "LblCheckType"
        Me.LblCheckType.Size = New System.Drawing.Size(94, 30)
        Me.LblCheckType.TabIndex = 30
        Me.LblCheckType.Text = "حالة الشيك"
        Me.LblCheckType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBankName
        '
        Me.LblBankName.AutoSize = True
        Me.LblBankName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblBankName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBankName.Location = New System.Drawing.Point(169, 60)
        Me.LblBankName.Name = "LblBankName"
        Me.LblBankName.Size = New System.Drawing.Size(94, 30)
        Me.LblBankName.TabIndex = 29
        Me.LblBankName.Text = "إسم البنك"
        Me.LblBankName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCheckDueDate
        '
        Me.LblCheckDueDate.AutoSize = True
        Me.LblCheckDueDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCheckDueDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCheckDueDate.Location = New System.Drawing.Point(169, 30)
        Me.LblCheckDueDate.Name = "LblCheckDueDate"
        Me.LblCheckDueDate.Size = New System.Drawing.Size(94, 30)
        Me.LblCheckDueDate.TabIndex = 28
        Me.LblCheckDueDate.Text = "تاريخ الإستحقاق"
        Me.LblCheckDueDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCheckNum
        '
        Me.LblCheckNum.AutoSize = True
        Me.LblCheckNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCheckNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCheckNum.Location = New System.Drawing.Point(169, 0)
        Me.LblCheckNum.Name = "LblCheckNum"
        Me.LblCheckNum.Size = New System.Drawing.Size(94, 30)
        Me.LblCheckNum.TabIndex = 27
        Me.LblCheckNum.Text = "رقم الشيك"
        Me.LblCheckNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCheckNum
        '
        Me.TxtCheckNum.BackColor = System.Drawing.Color.White
        Me.TxtCheckNum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCheckNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCheckNum.Location = New System.Drawing.Point(3, 3)
        Me.TxtCheckNum.Name = "TxtCheckNum"
        Me.TxtCheckNum.ShowClearButton = True
        Me.TxtCheckNum.Size = New System.Drawing.Size(160, 24)
        Me.TxtCheckNum.TabIndex = 0
        Me.TxtCheckNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCheckNum.ThemeName = "Office2010Blue"
        '
        'TxtCheckDueDate
        '
        Me.TxtCheckDueDate.BackColor = System.Drawing.Color.White
        Me.TxtCheckDueDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCheckDueDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCheckDueDate.Location = New System.Drawing.Point(3, 33)
        Me.TxtCheckDueDate.Mask = "dd/MM/yyyy"
        Me.TxtCheckDueDate.MaskType = Telerik.WinControls.UI.MaskType.DateTime
        Me.TxtCheckDueDate.Name = "TxtCheckDueDate"
        Me.TxtCheckDueDate.Size = New System.Drawing.Size(160, 24)
        Me.TxtCheckDueDate.TabIndex = 1
        Me.TxtCheckDueDate.TabStop = False
        Me.TxtCheckDueDate.Text = "01/01/2020"
        Me.TxtCheckDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCheckDueDate.ThemeName = "Office2010Blue"
        '
        'TxtBankName
        '
        Me.TxtBankName.BackColor = System.Drawing.Color.White
        Me.TxtBankName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtBankName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBankName.Location = New System.Drawing.Point(3, 63)
        Me.TxtBankName.Name = "TxtBankName"
        Me.TxtBankName.ShowClearButton = True
        Me.TxtBankName.Size = New System.Drawing.Size(160, 24)
        Me.TxtBankName.TabIndex = 2
        Me.TxtBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBankName.ThemeName = "Office2010Blue"
        '
        'ChkAlert
        '
        Me.ChkAlert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.TlpCheck.SetColumnSpan(Me.ChkAlert, 2)
        Me.ChkAlert.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAlert.Location = New System.Drawing.Point(53, 123)
        Me.ChkAlert.Name = "ChkAlert"
        Me.ChkAlert.Size = New System.Drawing.Size(161, 22)
        Me.ChkAlert.TabIndex = 4
        Me.ChkAlert.Text = "تنبيه عند تاريخ الإستحقاق"
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
        Me.TLPCommand.Controls.Add(Me.BtnSaveAndNew, 1, 0)
        Me.TLPCommand.Controls.Add(Me.BtnPrint, 3, 0)
        Me.TLPCommand.Controls.Add(Me.BtnInvAttach, 2, 0)
        Me.TLPCommand.Controls.Add(Me.BtnClose, 4, 0)
        Me.TLPCommand.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TLPCommand.Location = New System.Drawing.Point(0, 314)
        Me.TLPCommand.Margin = New System.Windows.Forms.Padding(0)
        Me.TLPCommand.Name = "TLPCommand"
        Me.TLPCommand.Padding = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.TLPCommand.RowCount = 1
        Me.TLPCommand.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TLPCommand.Size = New System.Drawing.Size(549, 39)
        Me.TLPCommand.TabIndex = 1
        '
        'BtnSaveAndNew
        '
        Me.BtnSaveAndNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSaveAndNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveAndNew.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSaveAndNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveAndNew.Location = New System.Drawing.Point(396, 3)
        Me.BtnSaveAndNew.Margin = New System.Windows.Forms.Padding(3, 3, 5, 3)
        Me.BtnSaveAndNew.Name = "BtnSaveAndNew"
        Me.BtnSaveAndNew.Size = New System.Drawing.Size(104, 32)
        Me.BtnSaveAndNew.TabIndex = 0
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
        Me.BtnPrint.Location = New System.Drawing.Point(160, 3)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(104, 32)
        Me.BtnPrint.TabIndex = 2
        Me.BtnPrint.Tag = "Print"
        Me.BtnPrint.Text = "طباعة"
        Me.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnInvAttach
        '
        Me.BtnInvAttach.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnInvAttach.Enabled = False
        Me.BtnInvAttach.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvAttach.Image = Global.HEHAccounting.My.Resources.Resources.print
        Me.BtnInvAttach.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnInvAttach.Location = New System.Drawing.Point(272, 3)
        Me.BtnInvAttach.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.BtnInvAttach.Name = "BtnInvAttach"
        Me.BtnInvAttach.Size = New System.Drawing.Size(114, 33)
        Me.BtnInvAttach.TabIndex = 1
        Me.BtnInvAttach.Tag = "InvAttach"
        Me.BtnInvAttach.Text = "إقتران بفاتورة"
        Me.BtnInvAttach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(50, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(104, 32)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'NotesPayable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 353)
        Me.Controls.Add(Me.TlpFill)
        Me.Controls.Add(Me.TLPCommand)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NotesPayable"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "سند صرف"
        Me.ThemeName = "Office2010Blue"
        Me.TlpFill.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.TxtCurrencyVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnGetCurrencyVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtVendor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.RadioCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadioCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAccBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtEqualValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlpCheck.ResumeLayout(False)
        Me.TlpCheck.PerformLayout()
        CType(Me.DropCheckStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCheckNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCheckDueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBankName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkAlert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLPCommand.ResumeLayout(False)
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnInvAttach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TlpFill As TableLayoutPanel
    Friend WithEvents TxtCode As Telerik.WinControls.UI.RadTextBox
    Private WithEvents TxtDueDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TLPCommand As TableLayoutPanel
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LblValue As Label
    Friend WithEvents LblBalance As Label
    Friend WithEvents LblVendor As Label
    Friend WithEvents LblCurrencyVal As Label
    Friend WithEvents LblCurrency As Label
    Friend WithEvents LblDueDate As Label
    Friend WithEvents LblCode As Label
    Friend WithEvents LblEqualValue As Label
    Friend WithEvents TxtAccBalance As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtEqualValue As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TlpCheck As TableLayoutPanel
    Friend WithEvents LblCheckType As Label
    Friend WithEvents LblBankName As Label
    Friend WithEvents LblCheckDueDate As Label
    Friend WithEvents LblCheckNum As Label
    Friend WithEvents TxtCheckNum As Telerik.WinControls.UI.RadTextBox
    Private WithEvents TxtCheckDueDate As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblPaymentType As Label
    Friend WithEvents LblDesc As Label
    Friend WithEvents TxtBankName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BtnPrint As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnInvAttach As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents RadioCheck As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadioCash As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents TxtDesc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtVendor As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents TxtVendorBtn As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents VendorTooltip As ToolTip
    Private WithEvents TxtAmount As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents DropCheckStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ChkAlert As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents LblStatus As Label
    Friend WithEvents DropStatus As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TxtCurrencyVal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BtnGetCurrencyVal As Telerik.WinControls.UI.RadButton
End Class

