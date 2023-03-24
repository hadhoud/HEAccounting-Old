<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTreasury
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
        Me.PnlOptions = New Telerik.WinControls.UI.RadPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.LblDropCurrency = New System.Windows.Forms.Label()
        Me.DateTimePickerFrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.DateTimePickerTo = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.LblFrom = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnFiltering = New Telerik.WinControls.UI.RadButton()
        Me.BtnReset = New Telerik.WinControls.UI.RadButton()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.TxtSO = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtSOCash = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtSODebt = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.lblCashSales = New System.Windows.Forms.Label()
        Me.lblDebtSales = New System.Windows.Forms.Label()
        Me.lblReturnSalesCash = New System.Windows.Forms.Label()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblReturnSalesDebt = New System.Windows.Forms.Label()
        Me.TxtRSOCash = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtRSO = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtRSODebt = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.lblReturnSales = New System.Windows.Forms.Label()
        Me.tblFirst = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtRPO = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtRPODebt = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtRPOCash = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtPO = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtPOCash = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.lblReturnPurchases = New System.Windows.Forms.Label()
        Me.TxtPODebt = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.lblReturnPurchasesDebt = New System.Windows.Forms.Label()
        Me.lblPurchases = New System.Windows.Forms.Label()
        Me.lblReturnPurchasesCash = New System.Windows.Forms.Label()
        Me.lblPurchasesCash = New System.Windows.Forms.Label()
        Me.lblPurchasesDebt = New System.Windows.Forms.Label()
        Me.LblSalesSummary = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlThird = New System.Windows.Forms.Panel()
        Me.tblThird = New System.Windows.Forms.TableLayoutPanel()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtSOPODollar = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.txtGeneralProfitPercent = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtGeneralProfits = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProfitsWithPaidNotes = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSalesProfitPercent = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSalesProfitDollar = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalesProfitLL = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LblAllItemsPricesLL = New System.Windows.Forms.Label()
        Me.txtAllItemsPriceLL = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.LblAllItemsPricesUSD = New System.Windows.Forms.Label()
        Me.txtAllItemsPriceUSD = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSOPOLL = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSalesDollar = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSalesLL = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.pnlFirst = New System.Windows.Forms.Panel()
        Me.pnlSecond = New System.Windows.Forms.Panel()
        Me.tblSecond = New System.Windows.Forms.TableLayoutPanel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtNotePay = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtNotePayCheck = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtOutDebt = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtNotePayCash = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtOutCash = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtOut = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtIN = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtInDebt = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtNoteReceiveCash = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNoteReceive = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtNoteReceiveCheck = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtInCash = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.FirstRunTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtAllItemsPrice = New Telerik.WinControls.UI.RadMaskedEditBox()
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlOptions.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimePickerFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTimePickerTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSOCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSODebt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRSOCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRSO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRSODebt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblFirst.SuspendLayout()
        CType(Me.TxtRPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRPODebt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtRPOCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPOCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPODebt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.pnlThird.SuspendLayout()
        Me.tblThird.SuspendLayout()
        CType(Me.txtSOPODollar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGeneralProfitPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtGeneralProfits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProfitsWithPaidNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalesProfitPercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalesProfitDollar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalesProfitLL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllItemsPriceLL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllItemsPriceUSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSOPOLL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalesDollar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalesLL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFirst.SuspendLayout()
        Me.pnlSecond.SuspendLayout()
        Me.tblSecond.SuspendLayout()
        CType(Me.TxtNotePay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNotePayCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOutDebt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNotePayCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOutCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInDebt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNoteReceiveCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNoteReceive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNoteReceiveCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtInCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAllItemsPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlOptions
        '
        Me.PnlOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlOptions.Controls.Add(Me.TableLayoutPanel3)
        Me.PnlOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlOptions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PnlOptions.Location = New System.Drawing.Point(945, 3)
        Me.PnlOptions.Name = "PnlOptions"
        Me.PnlOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlOptions.Size = New System.Drawing.Size(255, 487)
        Me.PnlOptions.TabIndex = 4
        Me.PnlOptions.Tag = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DropCurrency, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblDropCurrency, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePickerFrom, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DateTimePickerTo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblFrom, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(249, 110)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'DropCurrency
        '
        Me.DropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DropCurrency.DropDownAnimationEnabled = True
        Me.DropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropCurrency.Location = New System.Drawing.Point(3, 23)
        Me.DropCurrency.MaxLength = 65535
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Size = New System.Drawing.Size(169, 24)
        Me.DropCurrency.TabIndex = 29
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'LblDropCurrency
        '
        Me.LblDropCurrency.AutoSize = True
        Me.LblDropCurrency.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblDropCurrency.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDropCurrency.Location = New System.Drawing.Point(178, 20)
        Me.LblDropCurrency.Name = "LblDropCurrency"
        Me.LblDropCurrency.Size = New System.Drawing.Size(68, 30)
        Me.LblDropCurrency.TabIndex = 29
        Me.LblDropCurrency.Text = "العملة"
        Me.LblDropCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerFrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(3, 53)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(169, 24)
        Me.DateTimePickerFrom.TabIndex = 29
        Me.DateTimePickerFrom.TabStop = False
        Me.DateTimePickerFrom.Text = "11/01/2023"
        Me.DateTimePickerFrom.ThemeName = "Office2010Blue"
        Me.DateTimePickerFrom.Value = New Date(2023, 1, 11, 0, 0, 0, 0)
        CType(Me.DateTimePickerFrom.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).Shape = Nothing
        CType(Me.DateTimePickerFrom.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).RightToLeft = True
        CType(Me.DateTimePickerFrom.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.DateTimePickerFrom.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.DateTimePickerFrom.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "11/01/2023"
        CType(Me.DateTimePickerFrom.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerTo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTo.Location = New System.Drawing.Point(3, 83)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(169, 24)
        Me.DateTimePickerTo.TabIndex = 30
        Me.DateTimePickerTo.TabStop = False
        Me.DateTimePickerTo.Text = "01/11/2023"
        Me.DateTimePickerTo.ThemeName = "Office2010Blue"
        Me.DateTimePickerTo.Value = New Date(2023, 11, 1, 0, 0, 0, 0)
        CType(Me.DateTimePickerTo.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).Shape = Nothing
        CType(Me.DateTimePickerTo.GetChildAt(0), Telerik.WinControls.UI.RadDateTimePickerElement).RightToLeft = True
        CType(Me.DateTimePickerTo.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.DateTimePickerTo.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadCheckBoxElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.DateTimePickerTo.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Text = "01/11/2023"
        CType(Me.DateTimePickerTo.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadMaskedEditBoxElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTo.Location = New System.Drawing.Point(178, 80)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(68, 30)
        Me.LblTo.TabIndex = 20
        Me.LblTo.Text = "إلى"
        Me.LblTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFrom
        '
        Me.LblFrom.AutoSize = True
        Me.LblFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblFrom.Location = New System.Drawing.Point(178, 50)
        Me.LblFrom.Name = "LblFrom"
        Me.LblFrom.Size = New System.Drawing.Size(68, 30)
        Me.LblFrom.TabIndex = 18
        Me.LblFrom.Text = "من"
        Me.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnFiltering, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnReset, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 442)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(249, 42)
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
        'TxtSO
        '
        Me.TxtSO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtSO.Location = New System.Drawing.Point(21, 92)
        Me.TxtSO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtSO.Name = "TxtSO"
        Me.TxtSO.ReadOnly = True
        Me.TxtSO.ShortcutsEnabled = False
        Me.TxtSO.Size = New System.Drawing.Size(128, 24)
        Me.TxtSO.TabIndex = 68
        Me.TxtSO.TabStop = False
        Me.TxtSO.Text = "0"
        Me.TxtSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtSO.ThemeName = "Office2010Blue"
        '
        'TxtSOCash
        '
        Me.TxtSOCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSOCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSOCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtSOCash.Location = New System.Drawing.Point(21, 32)
        Me.TxtSOCash.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtSOCash.Name = "TxtSOCash"
        Me.TxtSOCash.ReadOnly = True
        Me.TxtSOCash.ShortcutsEnabled = False
        Me.TxtSOCash.Size = New System.Drawing.Size(128, 24)
        Me.TxtSOCash.TabIndex = 58
        Me.TxtSOCash.TabStop = False
        Me.TxtSOCash.Text = "0"
        Me.TxtSOCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtSOCash.ThemeName = "Office2010Blue"
        '
        'TxtSODebt
        '
        Me.TxtSODebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSODebt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtSODebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtSODebt.Location = New System.Drawing.Point(21, 62)
        Me.TxtSODebt.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtSODebt.Name = "TxtSODebt"
        Me.TxtSODebt.ReadOnly = True
        Me.TxtSODebt.ShortcutsEnabled = False
        Me.TxtSODebt.Size = New System.Drawing.Size(128, 24)
        Me.TxtSODebt.TabIndex = 60
        Me.TxtSODebt.TabStop = False
        Me.TxtSODebt.Text = "0"
        Me.TxtSODebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtSODebt.ThemeName = "Office2010Blue"
        '
        'lblCashSales
        '
        Me.lblCashSales.AutoSize = True
        Me.lblCashSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCashSales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCashSales.Location = New System.Drawing.Point(155, 29)
        Me.lblCashSales.Name = "lblCashSales"
        Me.lblCashSales.Size = New System.Drawing.Size(132, 30)
        Me.lblCashSales.TabIndex = 57
        Me.lblCashSales.Text = "مبيعات نقدا"
        Me.lblCashSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblDebtSales
        '
        Me.lblDebtSales.AutoSize = True
        Me.lblDebtSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDebtSales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblDebtSales.Location = New System.Drawing.Point(155, 59)
        Me.lblDebtSales.Name = "lblDebtSales"
        Me.lblDebtSales.Size = New System.Drawing.Size(132, 30)
        Me.lblDebtSales.TabIndex = 59
        Me.lblDebtSales.Text = "مبيعات آجل"
        Me.lblDebtSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReturnSalesCash
        '
        Me.lblReturnSalesCash.AutoSize = True
        Me.lblReturnSalesCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReturnSalesCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblReturnSalesCash.Location = New System.Drawing.Point(155, 119)
        Me.lblReturnSalesCash.Name = "lblReturnSalesCash"
        Me.lblReturnSalesCash.Size = New System.Drawing.Size(132, 30)
        Me.lblReturnSalesCash.TabIndex = 61
        Me.lblReturnSalesCash.Text = "مرتجع مبيعات نقدا"
        Me.lblReturnSalesCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblSales.Location = New System.Drawing.Point(155, 89)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(132, 30)
        Me.lblSales.TabIndex = 67
        Me.lblSales.Text = "مبيعات"
        Me.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReturnSalesDebt
        '
        Me.lblReturnSalesDebt.AutoSize = True
        Me.lblReturnSalesDebt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReturnSalesDebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblReturnSalesDebt.Location = New System.Drawing.Point(155, 149)
        Me.lblReturnSalesDebt.Name = "lblReturnSalesDebt"
        Me.lblReturnSalesDebt.Size = New System.Drawing.Size(132, 30)
        Me.lblReturnSalesDebt.TabIndex = 65
        Me.lblReturnSalesDebt.Text = "مرتجع مبيعات آجل"
        Me.lblReturnSalesDebt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtRSOCash
        '
        Me.TxtRSOCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRSOCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtRSOCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtRSOCash.Location = New System.Drawing.Point(21, 122)
        Me.TxtRSOCash.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtRSOCash.Name = "TxtRSOCash"
        Me.TxtRSOCash.ReadOnly = True
        Me.TxtRSOCash.ShortcutsEnabled = False
        Me.TxtRSOCash.Size = New System.Drawing.Size(128, 24)
        Me.TxtRSOCash.TabIndex = 62
        Me.TxtRSOCash.TabStop = False
        Me.TxtRSOCash.Text = "0"
        Me.TxtRSOCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtRSOCash.ThemeName = "Office2010Blue"
        '
        'TxtRSO
        '
        Me.TxtRSO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRSO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtRSO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtRSO.Location = New System.Drawing.Point(21, 182)
        Me.TxtRSO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtRSO.Name = "TxtRSO"
        Me.TxtRSO.ReadOnly = True
        '
        '
        '
        Me.TxtRSO.RootElement.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtRSO.ShortcutsEnabled = False
        Me.TxtRSO.Size = New System.Drawing.Size(128, 24)
        Me.TxtRSO.TabIndex = 70
        Me.TxtRSO.TabStop = False
        Me.TxtRSO.Text = "0"
        Me.TxtRSO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtRSO.ThemeName = "Office2010Blue"
        '
        'TxtRSODebt
        '
        Me.TxtRSODebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRSODebt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtRSODebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtRSODebt.Location = New System.Drawing.Point(21, 152)
        Me.TxtRSODebt.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtRSODebt.Name = "TxtRSODebt"
        Me.TxtRSODebt.ReadOnly = True
        Me.TxtRSODebt.ShortcutsEnabled = False
        Me.TxtRSODebt.Size = New System.Drawing.Size(128, 24)
        Me.TxtRSODebt.TabIndex = 66
        Me.TxtRSODebt.TabStop = False
        Me.TxtRSODebt.Text = "0"
        Me.TxtRSODebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtRSODebt.ThemeName = "Office2010Blue"
        '
        'lblReturnSales
        '
        Me.lblReturnSales.AutoSize = True
        Me.lblReturnSales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReturnSales.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblReturnSales.Location = New System.Drawing.Point(155, 179)
        Me.lblReturnSales.Name = "lblReturnSales"
        Me.lblReturnSales.Size = New System.Drawing.Size(132, 30)
        Me.lblReturnSales.TabIndex = 69
        Me.lblReturnSales.Text = "مرتجع مبيعات"
        Me.lblReturnSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tblFirst
        '
        Me.tblFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblFirst.ColumnCount = 4
        Me.tblFirst.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblFirst.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblFirst.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblFirst.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblFirst.Controls.Add(Me.TxtRPO, 2, 18)
        Me.tblFirst.Controls.Add(Me.TxtRPODebt, 2, 17)
        Me.tblFirst.Controls.Add(Me.TxtRPOCash, 2, 16)
        Me.tblFirst.Controls.Add(Me.TxtPO, 2, 15)
        Me.tblFirst.Controls.Add(Me.TxtPOCash, 2, 13)
        Me.tblFirst.Controls.Add(Me.TxtRSO, 2, 8)
        Me.tblFirst.Controls.Add(Me.lblReturnPurchases, 1, 18)
        Me.tblFirst.Controls.Add(Me.TxtRSOCash, 2, 6)
        Me.tblFirst.Controls.Add(Me.TxtPODebt, 2, 14)
        Me.tblFirst.Controls.Add(Me.TxtRSODebt, 2, 7)
        Me.tblFirst.Controls.Add(Me.lblReturnPurchasesDebt, 1, 17)
        Me.tblFirst.Controls.Add(Me.lblPurchases, 1, 15)
        Me.tblFirst.Controls.Add(Me.TxtSO, 2, 5)
        Me.tblFirst.Controls.Add(Me.lblReturnPurchasesCash, 1, 16)
        Me.tblFirst.Controls.Add(Me.lblCashSales, 1, 3)
        Me.tblFirst.Controls.Add(Me.TxtSODebt, 2, 4)
        Me.tblFirst.Controls.Add(Me.TxtSOCash, 2, 3)
        Me.tblFirst.Controls.Add(Me.lblPurchasesCash, 1, 13)
        Me.tblFirst.Controls.Add(Me.lblPurchasesDebt, 1, 14)
        Me.tblFirst.Controls.Add(Me.lblDebtSales, 1, 4)
        Me.tblFirst.Controls.Add(Me.lblSales, 1, 5)
        Me.tblFirst.Controls.Add(Me.lblReturnSalesDebt, 1, 7)
        Me.tblFirst.Controls.Add(Me.lblReturnSalesCash, 1, 6)
        Me.tblFirst.Controls.Add(Me.lblReturnSales, 1, 8)
        Me.tblFirst.Controls.Add(Me.LblSalesSummary, 1, 1)
        Me.tblFirst.Controls.Add(Me.Label25, 1, 10)
        Me.tblFirst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblFirst.Location = New System.Drawing.Point(0, 0)
        Me.tblFirst.Name = "tblFirst"
        Me.tblFirst.RowCount = 20
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblFirst.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tblFirst.Size = New System.Drawing.Size(306, 485)
        Me.tblFirst.TabIndex = 79
        '
        'TxtRPO
        '
        Me.TxtRPO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtRPO.EnableTheming = False
        Me.TxtRPO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtRPO.Location = New System.Drawing.Point(21, 381)
        Me.TxtRPO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtRPO.Name = "TxtRPO"
        Me.TxtRPO.ReadOnly = True
        Me.TxtRPO.ShortcutsEnabled = False
        Me.TxtRPO.Size = New System.Drawing.Size(128, 24)
        Me.TxtRPO.TabIndex = 94
        Me.TxtRPO.TabStop = False
        Me.TxtRPO.Text = "0"
        Me.TxtRPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtRPO.ThemeName = "Office2010Blue"
        '
        'TxtRPODebt
        '
        Me.TxtRPODebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRPODebt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtRPODebt.EnableTheming = False
        Me.TxtRPODebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtRPODebt.Location = New System.Drawing.Point(21, 351)
        Me.TxtRPODebt.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtRPODebt.Name = "TxtRPODebt"
        Me.TxtRPODebt.ReadOnly = True
        Me.TxtRPODebt.ShortcutsEnabled = False
        Me.TxtRPODebt.Size = New System.Drawing.Size(128, 24)
        Me.TxtRPODebt.TabIndex = 90
        Me.TxtRPODebt.TabStop = False
        Me.TxtRPODebt.Text = "0"
        Me.TxtRPODebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtRPODebt.ThemeName = "Office2010Blue"
        '
        'TxtRPOCash
        '
        Me.TxtRPOCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtRPOCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtRPOCash.EnableTheming = False
        Me.TxtRPOCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtRPOCash.Location = New System.Drawing.Point(21, 321)
        Me.TxtRPOCash.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtRPOCash.Name = "TxtRPOCash"
        Me.TxtRPOCash.ReadOnly = True
        Me.TxtRPOCash.ShortcutsEnabled = False
        Me.TxtRPOCash.Size = New System.Drawing.Size(128, 24)
        Me.TxtRPOCash.TabIndex = 88
        Me.TxtRPOCash.TabStop = False
        Me.TxtRPOCash.Text = "0"
        Me.TxtRPOCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtRPOCash.ThemeName = "Office2010Blue"
        '
        'TxtPO
        '
        Me.TxtPO.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPO.EnableTheming = False
        Me.TxtPO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtPO.Location = New System.Drawing.Point(21, 291)
        Me.TxtPO.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtPO.Name = "TxtPO"
        Me.TxtPO.ReadOnly = True
        Me.TxtPO.ShortcutsEnabled = False
        Me.TxtPO.Size = New System.Drawing.Size(128, 24)
        Me.TxtPO.TabIndex = 92
        Me.TxtPO.TabStop = False
        Me.TxtPO.Text = "0"
        Me.TxtPO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPO.ThemeName = "Office2010Blue"
        '
        'TxtPOCash
        '
        Me.TxtPOCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPOCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPOCash.EnableTheming = False
        Me.TxtPOCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtPOCash.Location = New System.Drawing.Point(21, 231)
        Me.TxtPOCash.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtPOCash.Name = "TxtPOCash"
        Me.TxtPOCash.ReadOnly = True
        Me.TxtPOCash.ShortcutsEnabled = False
        Me.TxtPOCash.Size = New System.Drawing.Size(128, 24)
        Me.TxtPOCash.TabIndex = 84
        Me.TxtPOCash.TabStop = False
        Me.TxtPOCash.Text = "0"
        Me.TxtPOCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPOCash.ThemeName = "Office2010Blue"
        '
        'lblReturnPurchases
        '
        Me.lblReturnPurchases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReturnPurchases.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblReturnPurchases.Location = New System.Drawing.Point(155, 378)
        Me.lblReturnPurchases.Name = "lblReturnPurchases"
        Me.lblReturnPurchases.Size = New System.Drawing.Size(132, 30)
        Me.lblReturnPurchases.TabIndex = 93
        Me.lblReturnPurchases.Text = "مرتجع مشتريات"
        Me.lblReturnPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtPODebt
        '
        Me.TxtPODebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPODebt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtPODebt.EnableTheming = False
        Me.TxtPODebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtPODebt.Location = New System.Drawing.Point(21, 261)
        Me.TxtPODebt.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtPODebt.Name = "TxtPODebt"
        Me.TxtPODebt.ReadOnly = True
        Me.TxtPODebt.ShortcutsEnabled = False
        Me.TxtPODebt.Size = New System.Drawing.Size(128, 24)
        Me.TxtPODebt.TabIndex = 86
        Me.TxtPODebt.TabStop = False
        Me.TxtPODebt.Text = "0"
        Me.TxtPODebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtPODebt.ThemeName = "Office2010Blue"
        '
        'lblReturnPurchasesDebt
        '
        Me.lblReturnPurchasesDebt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReturnPurchasesDebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblReturnPurchasesDebt.Location = New System.Drawing.Point(155, 348)
        Me.lblReturnPurchasesDebt.Name = "lblReturnPurchasesDebt"
        Me.lblReturnPurchasesDebt.Size = New System.Drawing.Size(132, 30)
        Me.lblReturnPurchasesDebt.TabIndex = 89
        Me.lblReturnPurchasesDebt.Text = "مرتجع مشتريات آجل"
        Me.lblReturnPurchasesDebt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPurchases
        '
        Me.lblPurchases.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPurchases.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPurchases.Location = New System.Drawing.Point(155, 288)
        Me.lblPurchases.Name = "lblPurchases"
        Me.lblPurchases.Size = New System.Drawing.Size(132, 30)
        Me.lblPurchases.TabIndex = 91
        Me.lblPurchases.Text = "مشتريات"
        Me.lblPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReturnPurchasesCash
        '
        Me.lblReturnPurchasesCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReturnPurchasesCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblReturnPurchasesCash.Location = New System.Drawing.Point(155, 318)
        Me.lblReturnPurchasesCash.Name = "lblReturnPurchasesCash"
        Me.lblReturnPurchasesCash.Size = New System.Drawing.Size(132, 30)
        Me.lblReturnPurchasesCash.TabIndex = 87
        Me.lblReturnPurchasesCash.Text = "مرتجع مشتريات نقدا"
        Me.lblReturnPurchasesCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPurchasesCash
        '
        Me.lblPurchasesCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPurchasesCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPurchasesCash.Location = New System.Drawing.Point(155, 228)
        Me.lblPurchasesCash.Name = "lblPurchasesCash"
        Me.lblPurchasesCash.Size = New System.Drawing.Size(132, 30)
        Me.lblPurchasesCash.TabIndex = 83
        Me.lblPurchasesCash.Text = "مشتريات نقدا"
        Me.lblPurchasesCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPurchasesDebt
        '
        Me.lblPurchasesDebt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPurchasesDebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPurchasesDebt.Location = New System.Drawing.Point(155, 258)
        Me.lblPurchasesDebt.Name = "lblPurchasesDebt"
        Me.lblPurchasesDebt.Size = New System.Drawing.Size(132, 30)
        Me.lblPurchasesDebt.TabIndex = 85
        Me.lblPurchasesDebt.Text = "مشتريات آجل"
        Me.lblPurchasesDebt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblSalesSummary
        '
        Me.LblSalesSummary.AutoSize = True
        Me.tblFirst.SetColumnSpan(Me.LblSalesSummary, 2)
        Me.LblSalesSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblSalesSummary.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblSalesSummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.LblSalesSummary.Location = New System.Drawing.Point(21, 5)
        Me.LblSalesSummary.Name = "LblSalesSummary"
        Me.LblSalesSummary.Size = New System.Drawing.Size(266, 19)
        Me.LblSalesSummary.TabIndex = 29
        Me.LblSalesSummary.Text = "مبيعات"
        Me.LblSalesSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.tblFirst.SetColumnSpan(Me.Label25, 2)
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(21, 209)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(266, 19)
        Me.Label25.TabIndex = 103
        Me.Label25.Text = "مشتريات"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.pnlThird, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.pnlFirst, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.pnlSecond, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PnlOptions, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1203, 493)
        Me.TableLayoutPanel4.TabIndex = 80
        '
        'pnlThird
        '
        Me.pnlThird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlThird.Controls.Add(Me.tblThird)
        Me.pnlThird.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlThird.Location = New System.Drawing.Point(3, 3)
        Me.pnlThird.Name = "pnlThird"
        Me.pnlThird.Size = New System.Drawing.Size(308, 487)
        Me.pnlThird.TabIndex = 29
        '
        'tblThird
        '
        Me.tblThird.ColumnCount = 4
        Me.tblThird.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblThird.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblThird.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblThird.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblThird.Controls.Add(Me.Label28, 1, 10)
        Me.tblThird.Controls.Add(Me.txtSOPODollar, 2, 6)
        Me.tblThird.Controls.Add(Me.txtGeneralProfitPercent, 2, 17)
        Me.tblThird.Controls.Add(Me.Label13, 1, 16)
        Me.tblThird.Controls.Add(Me.TxtGeneralProfits, 2, 16)
        Me.tblThird.Controls.Add(Me.Label7, 1, 15)
        Me.tblThird.Controls.Add(Me.txtProfitsWithPaidNotes, 2, 15)
        Me.tblThird.Controls.Add(Me.Label21, 1, 14)
        Me.tblThird.Controls.Add(Me.txtSalesProfitPercent, 2, 14)
        Me.tblThird.Controls.Add(Me.Label6, 1, 13)
        Me.tblThird.Controls.Add(Me.txtSalesProfitDollar, 2, 13)
        Me.tblThird.Controls.Add(Me.Label2, 1, 12)
        Me.tblThird.Controls.Add(Me.txtSalesProfitLL, 2, 12)
        Me.tblThird.Controls.Add(Me.Label23, 1, 17)
        Me.tblThird.Controls.Add(Me.LblAllItemsPricesLL, 1, 7)
        Me.tblThird.Controls.Add(Me.txtAllItemsPriceLL, 2, 7)
        Me.tblThird.Controls.Add(Me.LblAllItemsPricesUSD, 1, 8)
        Me.tblThird.Controls.Add(Me.txtAllItemsPriceUSD, 2, 8)
        Me.tblThird.Controls.Add(Me.Label5, 1, 4)
        Me.tblThird.Controls.Add(Me.Label1, 1, 5)
        Me.tblThird.Controls.Add(Me.txtSOPOLL, 2, 5)
        Me.tblThird.Controls.Add(Me.Label3, 1, 3)
        Me.tblThird.Controls.Add(Me.txtSalesDollar, 2, 4)
        Me.tblThird.Controls.Add(Me.Label24, 1, 6)
        Me.tblThird.Controls.Add(Me.txtSalesLL, 2, 3)
        Me.tblThird.Controls.Add(Me.Label29, 1, 1)
        Me.tblThird.Controls.Add(Me.Label20, 1, 9)
        Me.tblThird.Controls.Add(Me.txtAllItemsPrice, 2, 9)
        Me.tblThird.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblThird.Location = New System.Drawing.Point(0, 0)
        Me.tblThird.Name = "tblThird"
        Me.tblThird.RowCount = 19
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblThird.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tblThird.Size = New System.Drawing.Size(306, 485)
        Me.tblThird.TabIndex = 81
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.tblThird.SetColumnSpan(Me.Label28, 3)
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(3, 239)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(285, 19)
        Me.Label28.TabIndex = 105
        Me.Label28.Text = "أرباح"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSOPODollar
        '
        Me.txtSOPODollar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSOPODollar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSOPODollar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSOPODollar.ForeColor = System.Drawing.Color.Black
        Me.txtSOPODollar.Location = New System.Drawing.Point(20, 122)
        Me.txtSOPODollar.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtSOPODollar.Name = "txtSOPODollar"
        Me.txtSOPODollar.ReadOnly = True
        Me.txtSOPODollar.ShortcutsEnabled = False
        Me.txtSOPODollar.Size = New System.Drawing.Size(118, 24)
        Me.txtSOPODollar.TabIndex = 93
        Me.txtSOPODollar.TabStop = False
        Me.txtSOPODollar.Text = "0"
        Me.txtSOPODollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSOPODollar.ThemeName = "Office2010Blue"
        '
        'txtGeneralProfitPercent
        '
        Me.txtGeneralProfitPercent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGeneralProfitPercent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGeneralProfitPercent.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtGeneralProfitPercent.ForeColor = System.Drawing.Color.Black
        Me.txtGeneralProfitPercent.Location = New System.Drawing.Point(20, 411)
        Me.txtGeneralProfitPercent.Mask = "p2"
        Me.txtGeneralProfitPercent.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtGeneralProfitPercent.Name = "txtGeneralProfitPercent"
        Me.txtGeneralProfitPercent.ReadOnly = True
        Me.txtGeneralProfitPercent.ShortcutsEnabled = False
        Me.txtGeneralProfitPercent.Size = New System.Drawing.Size(118, 24)
        Me.txtGeneralProfitPercent.TabIndex = 85
        Me.txtGeneralProfitPercent.TabStop = False
        Me.txtGeneralProfitPercent.Text = "0.00%"
        Me.txtGeneralProfitPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGeneralProfitPercent.ThemeName = "Office2010Blue"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(144, 378)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 30)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "أرباح / خسارة عام"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtGeneralProfits
        '
        Me.TxtGeneralProfits.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtGeneralProfits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtGeneralProfits.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtGeneralProfits.ForeColor = System.Drawing.Color.Black
        Me.TxtGeneralProfits.Location = New System.Drawing.Point(20, 381)
        Me.TxtGeneralProfits.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtGeneralProfits.Name = "TxtGeneralProfits"
        Me.TxtGeneralProfits.ReadOnly = True
        Me.TxtGeneralProfits.ShortcutsEnabled = False
        Me.TxtGeneralProfits.Size = New System.Drawing.Size(118, 24)
        Me.TxtGeneralProfits.TabIndex = 84
        Me.TxtGeneralProfits.TabStop = False
        Me.TxtGeneralProfits.Text = "0"
        Me.TxtGeneralProfits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtGeneralProfits.ThemeName = "Office2010Blue"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(144, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 30)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "أرباح المبيعات - الصرف"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProfitsWithPaidNotes
        '
        Me.txtProfitsWithPaidNotes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProfitsWithPaidNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtProfitsWithPaidNotes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtProfitsWithPaidNotes.ForeColor = System.Drawing.Color.Black
        Me.txtProfitsWithPaidNotes.Location = New System.Drawing.Point(20, 351)
        Me.txtProfitsWithPaidNotes.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtProfitsWithPaidNotes.Name = "txtProfitsWithPaidNotes"
        Me.txtProfitsWithPaidNotes.ReadOnly = True
        Me.txtProfitsWithPaidNotes.ShortcutsEnabled = False
        Me.txtProfitsWithPaidNotes.Size = New System.Drawing.Size(118, 24)
        Me.txtProfitsWithPaidNotes.TabIndex = 92
        Me.txtProfitsWithPaidNotes.TabStop = False
        Me.txtProfitsWithPaidNotes.Text = "0"
        Me.txtProfitsWithPaidNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtProfitsWithPaidNotes.ThemeName = "Office2010Blue"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(144, 318)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(144, 30)
        Me.Label21.TabIndex = 94
        Me.Label21.Text = "نسبة أرباح المبيعات %"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalesProfitPercent
        '
        Me.txtSalesProfitPercent.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSalesProfitPercent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSalesProfitPercent.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSalesProfitPercent.ForeColor = System.Drawing.Color.Black
        Me.txtSalesProfitPercent.Location = New System.Drawing.Point(20, 321)
        Me.txtSalesProfitPercent.Mask = "p2"
        Me.txtSalesProfitPercent.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtSalesProfitPercent.Name = "txtSalesProfitPercent"
        Me.txtSalesProfitPercent.ReadOnly = True
        Me.txtSalesProfitPercent.ShortcutsEnabled = False
        Me.txtSalesProfitPercent.Size = New System.Drawing.Size(118, 24)
        Me.txtSalesProfitPercent.TabIndex = 93
        Me.txtSalesProfitPercent.TabStop = False
        Me.txtSalesProfitPercent.Text = "0.00%"
        Me.txtSalesProfitPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSalesProfitPercent.ThemeName = "Office2010Blue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(144, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 30)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "أرباح المبيعات $"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalesProfitDollar
        '
        Me.txtSalesProfitDollar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSalesProfitDollar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSalesProfitDollar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSalesProfitDollar.ForeColor = System.Drawing.Color.Black
        Me.txtSalesProfitDollar.Location = New System.Drawing.Point(20, 291)
        Me.txtSalesProfitDollar.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtSalesProfitDollar.Name = "txtSalesProfitDollar"
        Me.txtSalesProfitDollar.ReadOnly = True
        Me.txtSalesProfitDollar.ShortcutsEnabled = False
        Me.txtSalesProfitDollar.Size = New System.Drawing.Size(118, 24)
        Me.txtSalesProfitDollar.TabIndex = 92
        Me.txtSalesProfitDollar.TabStop = False
        Me.txtSalesProfitDollar.Text = "0"
        Me.txtSalesProfitDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSalesProfitDollar.ThemeName = "Office2010Blue"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(144, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 30)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "أرباح المبيعات ل.ل"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalesProfitLL
        '
        Me.txtSalesProfitLL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSalesProfitLL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSalesProfitLL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSalesProfitLL.ForeColor = System.Drawing.Color.Black
        Me.txtSalesProfitLL.Location = New System.Drawing.Point(20, 261)
        Me.txtSalesProfitLL.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtSalesProfitLL.Name = "txtSalesProfitLL"
        Me.txtSalesProfitLL.ReadOnly = True
        Me.txtSalesProfitLL.ShortcutsEnabled = False
        Me.txtSalesProfitLL.Size = New System.Drawing.Size(118, 24)
        Me.txtSalesProfitLL.TabIndex = 92
        Me.txtSalesProfitLL.TabStop = False
        Me.txtSalesProfitLL.Text = "0"
        Me.txtSalesProfitLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSalesProfitLL.ThemeName = "Office2010Blue"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.Location = New System.Drawing.Point(144, 408)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(144, 30)
        Me.Label23.TabIndex = 96
        Me.Label23.Text = "نسبة الأرباح عام %"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblAllItemsPricesLL
        '
        Me.LblAllItemsPricesLL.AutoSize = True
        Me.LblAllItemsPricesLL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAllItemsPricesLL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblAllItemsPricesLL.Location = New System.Drawing.Point(144, 149)
        Me.LblAllItemsPricesLL.Name = "LblAllItemsPricesLL"
        Me.LblAllItemsPricesLL.Size = New System.Drawing.Size(144, 30)
        Me.LblAllItemsPricesLL.TabIndex = 95
        Me.LblAllItemsPricesLL.Text = "رأس مال أصناف ل.ل"
        Me.LblAllItemsPricesLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAllItemsPriceLL
        '
        Me.txtAllItemsPriceLL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAllItemsPriceLL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAllItemsPriceLL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAllItemsPriceLL.ForeColor = System.Drawing.Color.Black
        Me.txtAllItemsPriceLL.Location = New System.Drawing.Point(20, 152)
        Me.txtAllItemsPriceLL.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtAllItemsPriceLL.Name = "txtAllItemsPriceLL"
        Me.txtAllItemsPriceLL.ReadOnly = True
        Me.txtAllItemsPriceLL.ShortcutsEnabled = False
        Me.txtAllItemsPriceLL.Size = New System.Drawing.Size(118, 24)
        Me.txtAllItemsPriceLL.TabIndex = 94
        Me.txtAllItemsPriceLL.TabStop = False
        Me.txtAllItemsPriceLL.Text = "0"
        Me.txtAllItemsPriceLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAllItemsPriceLL.ThemeName = "Office2010Blue"
        '
        'LblAllItemsPricesUSD
        '
        Me.LblAllItemsPricesUSD.AutoSize = True
        Me.LblAllItemsPricesUSD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAllItemsPricesUSD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblAllItemsPricesUSD.Location = New System.Drawing.Point(144, 179)
        Me.LblAllItemsPricesUSD.Name = "LblAllItemsPricesUSD"
        Me.LblAllItemsPricesUSD.Size = New System.Drawing.Size(144, 30)
        Me.LblAllItemsPricesUSD.TabIndex = 93
        Me.LblAllItemsPricesUSD.Text = "رأس مال أصناف $"
        Me.LblAllItemsPricesUSD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAllItemsPriceUSD
        '
        Me.txtAllItemsPriceUSD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAllItemsPriceUSD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAllItemsPriceUSD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAllItemsPriceUSD.ForeColor = System.Drawing.Color.Black
        Me.txtAllItemsPriceUSD.Location = New System.Drawing.Point(20, 182)
        Me.txtAllItemsPriceUSD.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtAllItemsPriceUSD.Name = "txtAllItemsPriceUSD"
        Me.txtAllItemsPriceUSD.ReadOnly = True
        Me.txtAllItemsPriceUSD.ShortcutsEnabled = False
        Me.txtAllItemsPriceUSD.Size = New System.Drawing.Size(118, 24)
        Me.txtAllItemsPriceUSD.TabIndex = 93
        Me.txtAllItemsPriceUSD.TabStop = False
        Me.txtAllItemsPriceUSD.Text = "0"
        Me.txtAllItemsPriceUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAllItemsPriceUSD.ThemeName = "Office2010Blue"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(144, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 30)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "مبيعات $"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(144, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 30)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "مشتريات من المبيعات ل.ل"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSOPOLL
        '
        Me.txtSOPOLL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSOPOLL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSOPOLL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSOPOLL.ForeColor = System.Drawing.Color.Black
        Me.txtSOPOLL.Location = New System.Drawing.Point(20, 92)
        Me.txtSOPOLL.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtSOPOLL.Name = "txtSOPOLL"
        Me.txtSOPOLL.ReadOnly = True
        Me.txtSOPOLL.ShortcutsEnabled = False
        Me.txtSOPOLL.Size = New System.Drawing.Size(118, 24)
        Me.txtSOPOLL.TabIndex = 92
        Me.txtSOPOLL.TabStop = False
        Me.txtSOPOLL.Text = "0"
        Me.txtSOPOLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSOPOLL.ThemeName = "Office2010Blue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(144, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 30)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "مبيعات ل.ل"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalesDollar
        '
        Me.txtSalesDollar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSalesDollar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSalesDollar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSalesDollar.ForeColor = System.Drawing.Color.Black
        Me.txtSalesDollar.Location = New System.Drawing.Point(20, 62)
        Me.txtSalesDollar.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtSalesDollar.Name = "txtSalesDollar"
        Me.txtSalesDollar.ReadOnly = True
        Me.txtSalesDollar.ShortcutsEnabled = False
        Me.txtSalesDollar.Size = New System.Drawing.Size(118, 24)
        Me.txtSalesDollar.TabIndex = 92
        Me.txtSalesDollar.TabStop = False
        Me.txtSalesDollar.Text = "0"
        Me.txtSalesDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSalesDollar.ThemeName = "Office2010Blue"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(144, 119)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(144, 30)
        Me.Label24.TabIndex = 97
        Me.Label24.Text = "مشتريات من المبيعات $"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalesLL
        '
        Me.txtSalesLL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSalesLL.Culture = New System.Globalization.CultureInfo("ar-LB")
        Me.txtSalesLL.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtSalesLL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSalesLL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSalesLL.Location = New System.Drawing.Point(20, 32)
        Me.txtSalesLL.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtSalesLL.Name = "txtSalesLL"
        Me.txtSalesLL.ReadOnly = True
        Me.txtSalesLL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSalesLL.Size = New System.Drawing.Size(118, 24)
        Me.txtSalesLL.TabIndex = 102
        Me.txtSalesLL.TabStop = False
        Me.txtSalesLL.Text = "0"
        Me.txtSalesLL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.tblThird.SetColumnSpan(Me.Label29, 3)
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(3, 5)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(285, 19)
        Me.Label29.TabIndex = 106
        Me.Label29.Text = "إجماليات"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFirst
        '
        Me.pnlFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFirst.Controls.Add(Me.tblFirst)
        Me.pnlFirst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFirst.Location = New System.Drawing.Point(631, 3)
        Me.pnlFirst.Name = "pnlFirst"
        Me.pnlFirst.Size = New System.Drawing.Size(308, 487)
        Me.pnlFirst.TabIndex = 29
        '
        'pnlSecond
        '
        Me.pnlSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSecond.Controls.Add(Me.tblSecond)
        Me.pnlSecond.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSecond.Location = New System.Drawing.Point(317, 3)
        Me.pnlSecond.Name = "pnlSecond"
        Me.pnlSecond.Size = New System.Drawing.Size(308, 487)
        Me.pnlSecond.TabIndex = 29
        '
        'tblSecond
        '
        Me.tblSecond.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tblSecond.ColumnCount = 4
        Me.tblSecond.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblSecond.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSecond.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblSecond.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tblSecond.Controls.Add(Me.Label27, 1, 1)
        Me.tblSecond.Controls.Add(Me.Label26, 1, 10)
        Me.tblSecond.Controls.Add(Me.TxtNotePay, 2, 8)
        Me.tblSecond.Controls.Add(Me.TxtNotePayCheck, 2, 7)
        Me.tblSecond.Controls.Add(Me.TxtOutDebt, 2, 16)
        Me.tblSecond.Controls.Add(Me.TxtNotePayCash, 2, 6)
        Me.tblSecond.Controls.Add(Me.TxtOutCash, 2, 15)
        Me.tblSecond.Controls.Add(Me.TxtOut, 2, 17)
        Me.tblSecond.Controls.Add(Me.TxtIN, 2, 14)
        Me.tblSecond.Controls.Add(Me.Label19, 1, 6)
        Me.tblSecond.Controls.Add(Me.TxtInDebt, 2, 13)
        Me.tblSecond.Controls.Add(Me.TxtNoteReceiveCash, 2, 3)
        Me.tblSecond.Controls.Add(Me.Label4, 1, 17)
        Me.tblSecond.Controls.Add(Me.TxtNoteReceive, 2, 5)
        Me.tblSecond.Controls.Add(Me.Label15, 1, 3)
        Me.tblSecond.Controls.Add(Me.TxtNoteReceiveCheck, 2, 4)
        Me.tblSecond.Controls.Add(Me.Label12, 1, 16)
        Me.tblSecond.Controls.Add(Me.Label18, 1, 4)
        Me.tblSecond.Controls.Add(Me.Label8, 1, 15)
        Me.tblSecond.Controls.Add(Me.Label16, 1, 7)
        Me.tblSecond.Controls.Add(Me.Label14, 1, 5)
        Me.tblSecond.Controls.Add(Me.Label17, 1, 8)
        Me.tblSecond.Controls.Add(Me.Label9, 1, 14)
        Me.tblSecond.Controls.Add(Me.Label11, 1, 13)
        Me.tblSecond.Controls.Add(Me.Label10, 1, 12)
        Me.tblSecond.Controls.Add(Me.TxtInCash, 2, 12)
        Me.tblSecond.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblSecond.Location = New System.Drawing.Point(0, 0)
        Me.tblSecond.Name = "tblSecond"
        Me.tblSecond.RowCount = 19
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSecond.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tblSecond.Size = New System.Drawing.Size(306, 485)
        Me.tblSecond.TabIndex = 81
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.tblSecond.SetColumnSpan(Me.Label27, 2)
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(21, 5)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(266, 19)
        Me.Label27.TabIndex = 105
        Me.Label27.Text = "سندات"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.tblSecond.SetColumnSpan(Me.Label26, 2)
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(21, 214)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(266, 19)
        Me.Label26.TabIndex = 104
        Me.Label26.Text = "واردات - صادرات"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNotePay
        '
        Me.TxtNotePay.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNotePay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNotePay.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtNotePay.Location = New System.Drawing.Point(21, 182)
        Me.TxtNotePay.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtNotePay.Name = "TxtNotePay"
        Me.TxtNotePay.ReadOnly = True
        Me.TxtNotePay.ShortcutsEnabled = False
        Me.TxtNotePay.Size = New System.Drawing.Size(128, 24)
        Me.TxtNotePay.TabIndex = 91
        Me.TxtNotePay.TabStop = False
        Me.TxtNotePay.Text = "0"
        Me.TxtNotePay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNotePay.ThemeName = "Office2010Blue"
        '
        'TxtNotePayCheck
        '
        Me.TxtNotePayCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNotePayCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNotePayCheck.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtNotePayCheck.Location = New System.Drawing.Point(21, 152)
        Me.TxtNotePayCheck.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtNotePayCheck.Name = "TxtNotePayCheck"
        Me.TxtNotePayCheck.ReadOnly = True
        Me.TxtNotePayCheck.ShortcutsEnabled = False
        Me.TxtNotePayCheck.Size = New System.Drawing.Size(128, 24)
        Me.TxtNotePayCheck.TabIndex = 89
        Me.TxtNotePayCheck.TabStop = False
        Me.TxtNotePayCheck.Text = "0"
        Me.TxtNotePayCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNotePayCheck.ThemeName = "Office2010Blue"
        '
        'TxtOutDebt
        '
        Me.TxtOutDebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtOutDebt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtOutDebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtOutDebt.ForeColor = System.Drawing.Color.Black
        Me.TxtOutDebt.Location = New System.Drawing.Point(21, 356)
        Me.TxtOutDebt.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtOutDebt.Name = "TxtOutDebt"
        Me.TxtOutDebt.ReadOnly = True
        Me.TxtOutDebt.ShortcutsEnabled = False
        Me.TxtOutDebt.Size = New System.Drawing.Size(128, 24)
        Me.TxtOutDebt.TabIndex = 80
        Me.TxtOutDebt.TabStop = False
        Me.TxtOutDebt.Text = "0"
        Me.TxtOutDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtOutDebt.ThemeName = "Office2010Blue"
        '
        'TxtNotePayCash
        '
        Me.TxtNotePayCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNotePayCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNotePayCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtNotePayCash.Location = New System.Drawing.Point(21, 122)
        Me.TxtNotePayCash.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtNotePayCash.Name = "TxtNotePayCash"
        Me.TxtNotePayCash.ReadOnly = True
        Me.TxtNotePayCash.ShortcutsEnabled = False
        Me.TxtNotePayCash.Size = New System.Drawing.Size(128, 24)
        Me.TxtNotePayCash.TabIndex = 93
        Me.TxtNotePayCash.TabStop = False
        Me.TxtNotePayCash.Text = "0"
        Me.TxtNotePayCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNotePayCash.ThemeName = "Office2010Blue"
        '
        'TxtOutCash
        '
        Me.TxtOutCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtOutCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtOutCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtOutCash.ForeColor = System.Drawing.Color.Black
        Me.TxtOutCash.Location = New System.Drawing.Point(21, 326)
        Me.TxtOutCash.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtOutCash.Name = "TxtOutCash"
        Me.TxtOutCash.ReadOnly = True
        Me.TxtOutCash.ShortcutsEnabled = False
        Me.TxtOutCash.Size = New System.Drawing.Size(128, 24)
        Me.TxtOutCash.TabIndex = 78
        Me.TxtOutCash.TabStop = False
        Me.TxtOutCash.Text = "0"
        Me.TxtOutCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtOutCash.ThemeName = "Office2010Blue"
        '
        'TxtOut
        '
        Me.TxtOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtOut.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtOut.ForeColor = System.Drawing.Color.Black
        Me.TxtOut.Location = New System.Drawing.Point(21, 386)
        Me.TxtOut.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.ReadOnly = True
        Me.TxtOut.ShortcutsEnabled = False
        Me.TxtOut.Size = New System.Drawing.Size(128, 24)
        Me.TxtOut.TabIndex = 82
        Me.TxtOut.TabStop = False
        Me.TxtOut.Text = "0"
        Me.TxtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtOut.ThemeName = "Office2010Blue"
        '
        'TxtIN
        '
        Me.TxtIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtIN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtIN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtIN.ForeColor = System.Drawing.Color.Black
        Me.TxtIN.Location = New System.Drawing.Point(21, 296)
        Me.TxtIN.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtIN.Name = "TxtIN"
        Me.TxtIN.ReadOnly = True
        Me.TxtIN.ShortcutsEnabled = False
        Me.TxtIN.Size = New System.Drawing.Size(128, 24)
        Me.TxtIN.TabIndex = 76
        Me.TxtIN.TabStop = False
        Me.TxtIN.Text = "0"
        Me.TxtIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtIN.ThemeName = "Office2010Blue"
        '
        'Label19
        '
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(155, 119)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(132, 30)
        Me.Label19.TabIndex = 92
        Me.Label19.Text = "صرف نقدا"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInDebt
        '
        Me.TxtInDebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInDebt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInDebt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtInDebt.ForeColor = System.Drawing.Color.Black
        Me.TxtInDebt.Location = New System.Drawing.Point(21, 266)
        Me.TxtInDebt.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtInDebt.Name = "TxtInDebt"
        Me.TxtInDebt.ReadOnly = True
        Me.TxtInDebt.ShortcutsEnabled = False
        Me.TxtInDebt.Size = New System.Drawing.Size(128, 24)
        Me.TxtInDebt.TabIndex = 74
        Me.TxtInDebt.TabStop = False
        Me.TxtInDebt.Text = "0"
        Me.TxtInDebt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInDebt.ThemeName = "Office2010Blue"
        '
        'TxtNoteReceiveCash
        '
        Me.TxtNoteReceiveCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNoteReceiveCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNoteReceiveCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtNoteReceiveCash.Location = New System.Drawing.Point(21, 32)
        Me.TxtNoteReceiveCash.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtNoteReceiveCash.Name = "TxtNoteReceiveCash"
        Me.TxtNoteReceiveCash.ReadOnly = True
        Me.TxtNoteReceiveCash.ShortcutsEnabled = False
        Me.TxtNoteReceiveCash.Size = New System.Drawing.Size(128, 24)
        Me.TxtNoteReceiveCash.TabIndex = 83
        Me.TxtNoteReceiveCash.TabStop = False
        Me.TxtNoteReceiveCash.Text = "0"
        Me.TxtNoteReceiveCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNoteReceiveCash.ThemeName = "Office2010Blue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(155, 383)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 30)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "صادرات"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNoteReceive
        '
        Me.TxtNoteReceive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNoteReceive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNoteReceive.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtNoteReceive.Location = New System.Drawing.Point(21, 92)
        Me.TxtNoteReceive.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtNoteReceive.Name = "TxtNoteReceive"
        Me.TxtNoteReceive.ReadOnly = True
        Me.TxtNoteReceive.ShortcutsEnabled = False
        Me.TxtNoteReceive.Size = New System.Drawing.Size(128, 24)
        Me.TxtNoteReceive.TabIndex = 87
        Me.TxtNoteReceive.TabStop = False
        Me.TxtNoteReceive.Text = "0"
        Me.TxtNoteReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNoteReceive.ThemeName = "Office2010Blue"
        '
        'Label15
        '
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(155, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(132, 30)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "قبض نقدا"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNoteReceiveCheck
        '
        Me.TxtNoteReceiveCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtNoteReceiveCheck.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNoteReceiveCheck.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtNoteReceiveCheck.Location = New System.Drawing.Point(21, 62)
        Me.TxtNoteReceiveCheck.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtNoteReceiveCheck.Name = "TxtNoteReceiveCheck"
        Me.TxtNoteReceiveCheck.ReadOnly = True
        Me.TxtNoteReceiveCheck.ShortcutsEnabled = False
        Me.TxtNoteReceiveCheck.Size = New System.Drawing.Size(128, 24)
        Me.TxtNoteReceiveCheck.TabIndex = 85
        Me.TxtNoteReceiveCheck.TabStop = False
        Me.TxtNoteReceiveCheck.Text = "0"
        Me.TxtNoteReceiveCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtNoteReceiveCheck.ThemeName = "Office2010Blue"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(155, 353)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 30)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "صادرات آجل"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(155, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 30)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "قبض شيك"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(155, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 30)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "صادرات نقدا"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(155, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 30)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "صرف شيك"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(155, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(132, 30)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "قبض"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(155, 179)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(132, 30)
        Me.Label17.TabIndex = 90
        Me.Label17.Text = "صرف"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(155, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 30)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "واردات"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(155, 263)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 30)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "واردات آجل"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(155, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 30)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "واردات نقدا"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtInCash
        '
        Me.TxtInCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtInCash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInCash.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TxtInCash.ForeColor = System.Drawing.Color.Black
        Me.TxtInCash.Location = New System.Drawing.Point(21, 236)
        Me.TxtInCash.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.TxtInCash.Name = "TxtInCash"
        Me.TxtInCash.ReadOnly = True
        Me.TxtInCash.ShortcutsEnabled = False
        Me.TxtInCash.Size = New System.Drawing.Size(128, 24)
        Me.TxtInCash.TabIndex = 72
        Me.TxtInCash.TabStop = False
        Me.TxtInCash.Text = "0"
        Me.TxtInCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtInCash.ThemeName = "Office2010Blue"
        '
        'FirstRunTimer
        '
        Me.FirstRunTimer.Interval = 200
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(144, 209)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 30)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "رأس مال أصناف"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAllItemsPrice
        '
        Me.txtAllItemsPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAllItemsPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAllItemsPrice.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAllItemsPrice.ForeColor = System.Drawing.Color.Black
        Me.txtAllItemsPrice.Location = New System.Drawing.Point(20, 212)
        Me.txtAllItemsPrice.MaskType = Telerik.WinControls.UI.MaskType.Numeric
        Me.txtAllItemsPrice.Name = "txtAllItemsPrice"
        Me.txtAllItemsPrice.ReadOnly = True
        Me.txtAllItemsPrice.ShortcutsEnabled = False
        Me.txtAllItemsPrice.Size = New System.Drawing.Size(118, 24)
        Me.txtAllItemsPrice.TabIndex = 108
        Me.txtAllItemsPrice.TabStop = False
        Me.txtAllItemsPrice.Text = "0"
        Me.txtAllItemsPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAllItemsPrice.ThemeName = "Office2010Blue"
        '
        'FrmTreasury
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 493)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Name = "FrmTreasury"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Tag = "FrmTreasury"
        Me.Text = "الرئيسية"
        Me.ThemeName = "Office2010Blue"
        CType(Me.PnlOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlOptions.ResumeLayout(False)
        Me.PnlOptions.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimePickerFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTimePickerTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSOCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSODebt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRSOCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRSO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRSODebt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblFirst.ResumeLayout(False)
        Me.tblFirst.PerformLayout()
        CType(Me.TxtRPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRPODebt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtRPOCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPOCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPODebt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.pnlThird.ResumeLayout(False)
        Me.tblThird.ResumeLayout(False)
        Me.tblThird.PerformLayout()
        CType(Me.txtSOPODollar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGeneralProfitPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtGeneralProfits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProfitsWithPaidNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalesProfitPercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalesProfitDollar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalesProfitLL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllItemsPriceLL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllItemsPriceUSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSOPOLL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalesDollar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalesLL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFirst.ResumeLayout(False)
        Me.pnlSecond.ResumeLayout(False)
        Me.tblSecond.ResumeLayout(False)
        Me.tblSecond.PerformLayout()
        CType(Me.TxtNotePay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNotePayCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOutDebt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNotePayCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOutCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInDebt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNoteReceiveCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNoteReceive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNoteReceiveCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtInCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAllItemsPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlOptions As Telerik.WinControls.UI.RadPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnFiltering As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnReset As Telerik.WinControls.UI.RadButton
    Friend WithEvents LblTo As Label
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents LblFrom As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtSO As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtSOCash As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtSODebt As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents lblCashSales As Label
    Friend WithEvents lblDebtSales As Label
    Friend WithEvents lblReturnSalesCash As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lblReturnSalesDebt As Label
    Friend WithEvents TxtRSOCash As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtRSO As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtRSODebt As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents lblReturnSales As Label
    Friend WithEvents tblFirst As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TxtPOCash As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents lblReturnPurchases As Label
    Friend WithEvents TxtPO As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents lblPurchases As Label
    Friend WithEvents lblReturnPurchasesDebt As Label
    Friend WithEvents TxtRPOCash As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents lblReturnPurchasesCash As Label
    Friend WithEvents lblPurchasesCash As Label
    Friend WithEvents TxtRPODebt As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents lblPurchasesDebt As Label
    Friend WithEvents TxtRPO As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtPODebt As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents tblSecond As TableLayoutPanel
    Friend WithEvents TxtNotePay As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtNotePayCheck As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtNotePayCash As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtNoteReceiveCash As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtNoteReceive As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtNoteReceiveCheck As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents tblThird As TableLayoutPanel
    Friend WithEvents TxtGeneralProfits As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtOutDebt As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtOutCash As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtOut As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtIN As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents TxtInDebt As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtInCash As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProfitsWithPaidNotes As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtSalesProfitDollar As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtSalesProfitLL As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtSOPOLL As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtSalesDollar As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LblAllItemsPricesUSD As Label
    Friend WithEvents txtAllItemsPriceLL As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtAllItemsPriceUSD As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblAllItemsPricesLL As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtSalesProfitPercent As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents txtGeneralProfitPercent As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtSOPODollar As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label24 As Label
    Friend WithEvents pnlSecond As Panel
    Friend WithEvents pnlFirst As Panel
    Friend WithEvents pnlThird As Panel
    Friend WithEvents FirstRunTimer As Timer
    Friend WithEvents txtSalesLL As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblSalesSummary As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents DateTimePickerFrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents DateTimePickerTo As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents LblDropCurrency As Label
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Label20 As Label
    Friend WithEvents txtAllItemsPrice As Telerik.WinControls.UI.RadMaskedEditBox
End Class

