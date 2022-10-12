<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewVendor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewVendor))
        Me.AddNewPages = New Telerik.WinControls.UI.RadPageView()
        Me.PageGeneral = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblVendorID = New System.Windows.Forms.Label()
        Me.TxtVendorCode = New Telerik.WinControls.UI.RadTextBox()
        Me.LblVendorName = New System.Windows.Forms.Label()
        Me.TxtVendorName = New Telerik.WinControls.UI.RadTextBox()
        Me.LblLatinName = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.MTxtPhone = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LblTown = New System.Windows.Forms.Label()
        Me.TxtTown = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtAddress = New Telerik.WinControls.UI.RadTextBox()
        Me.LblVendorCompany = New System.Windows.Forms.Label()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtCompany = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtTitle = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtVendorLatin = New Telerik.WinControls.UI.RadTextBox()
        Me.MTxtCellPhone = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.LblCellPhone = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        CType(Me.AddNewPages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddNewPages.SuspendLayout()
        Me.PageGeneral.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtVendorCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtVendorName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MTxtPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtVendorLatin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MTxtCellPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddNewPages
        '
        Me.AddNewPages.Controls.Add(Me.PageGeneral)
        Me.AddNewPages.DefaultPage = Me.PageGeneral
        Me.AddNewPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddNewPages.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewPages.Location = New System.Drawing.Point(0, 0)
        Me.AddNewPages.Name = "AddNewPages"
        Me.AddNewPages.PageBackColor = System.Drawing.Color.White
        Me.AddNewPages.SelectedPage = Me.PageGeneral
        Me.AddNewPages.Size = New System.Drawing.Size(494, 238)
        Me.AddNewPages.TabIndex = 0
        Me.AddNewPages.ThemeName = "Windows7"
        CType(Me.AddNewPages.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).StripButtons = Telerik.WinControls.UI.StripViewButtons.None
        CType(Me.AddNewPages.GetChildAt(0), Telerik.WinControls.UI.RadPageViewStripElement).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.FillHeight
        CType(Me.AddNewPages.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.RadPageViewContentAreaElement).BackColor = System.Drawing.Color.White
        '
        'PageGeneral
        '
        Me.PageGeneral.Controls.Add(Me.TableLayoutPanel1)
        Me.PageGeneral.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PageGeneral.ItemSize = New System.Drawing.SizeF(49.0!, 34.0!)
        Me.PageGeneral.Location = New System.Drawing.Point(11, 43)
        Me.PageGeneral.Name = "PageGeneral"
        Me.PageGeneral.Size = New System.Drawing.Size(472, 184)
        Me.PageGeneral.Text = "عام"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LblVendorID, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtVendorCode, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblVendorName, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtVendorName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblLatinName, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblPhone, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MTxtPhone, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblAddress, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTown, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtTown, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtAddress, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblVendorCompany, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTitle, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCompany, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtTitle, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtVendorLatin, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MTxtCellPhone, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCellPhone, 3, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(472, 184)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LblVendorID
        '
        Me.LblVendorID.AutoSize = True
        Me.LblVendorID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblVendorID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVendorID.Location = New System.Drawing.Point(390, 14)
        Me.LblVendorID.Name = "LblVendorID"
        Me.LblVendorID.Size = New System.Drawing.Size(79, 30)
        Me.LblVendorID.TabIndex = 62
        Me.LblVendorID.Text = "كود المورد"
        Me.LblVendorID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtVendorCode
        '
        Me.TxtVendorCode.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtVendorCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtVendorCode.Enabled = False
        Me.TxtVendorCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVendorCode.Location = New System.Drawing.Point(237, 17)
        Me.TxtVendorCode.Name = "TxtVendorCode"
        Me.TxtVendorCode.Size = New System.Drawing.Size(147, 24)
        Me.TxtVendorCode.TabIndex = 0
        Me.TxtVendorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtVendorCode.ThemeName = "Office2010Blue"
        '
        'LblVendorName
        '
        Me.LblVendorName.AutoSize = True
        Me.LblVendorName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblVendorName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVendorName.Location = New System.Drawing.Point(390, 44)
        Me.LblVendorName.Name = "LblVendorName"
        Me.LblVendorName.Size = New System.Drawing.Size(79, 30)
        Me.LblVendorName.TabIndex = 61
        Me.LblVendorName.Text = "إسم المورد"
        Me.LblVendorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtVendorName
        '
        Me.TxtVendorName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtVendorName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVendorName.Location = New System.Drawing.Point(237, 47)
        Me.TxtVendorName.Name = "TxtVendorName"
        Me.TxtVendorName.ShowClearButton = True
        Me.TxtVendorName.Size = New System.Drawing.Size(147, 24)
        Me.TxtVendorName.TabIndex = 1
        Me.TxtVendorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtVendorName.ThemeName = "Office2010Blue"
        '
        'LblLatinName
        '
        Me.LblLatinName.AutoSize = True
        Me.LblLatinName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblLatinName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLatinName.Location = New System.Drawing.Point(390, 74)
        Me.LblLatinName.Name = "LblLatinName"
        Me.LblLatinName.Size = New System.Drawing.Size(79, 30)
        Me.LblLatinName.TabIndex = 65
        Me.LblLatinName.Text = "الإسم اللاتيني"
        Me.LblLatinName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhone.Location = New System.Drawing.Point(156, 74)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(50, 30)
        Me.LblPhone.TabIndex = 67
        Me.LblPhone.Text = "الهاتف"
        Me.LblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MTxtPhone
        '
        Me.MTxtPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MTxtPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtPhone.Location = New System.Drawing.Point(3, 77)
        Me.MTxtPhone.Mask = "00-000000"
        Me.MTxtPhone.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.MTxtPhone.Name = "MTxtPhone"
        Me.MTxtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MTxtPhone.Size = New System.Drawing.Size(147, 24)
        Me.MTxtPhone.TabIndex = 7
        Me.MTxtPhone.TabStop = False
        Me.MTxtPhone.Text = "__-______"
        Me.MTxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MTxtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MTxtPhone.ThemeName = "Office2010Blue"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblAddress.Location = New System.Drawing.Point(156, 44)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(50, 30)
        Me.LblAddress.TabIndex = 66
        Me.LblAddress.Text = "العنوان"
        Me.LblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblAddress.UseCompatibleTextRendering = True
        '
        'LblTown
        '
        Me.LblTown.AutoSize = True
        Me.LblTown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTown.Location = New System.Drawing.Point(156, 14)
        Me.LblTown.Name = "LblTown"
        Me.LblTown.Size = New System.Drawing.Size(50, 30)
        Me.LblTown.TabIndex = 80
        Me.LblTown.Text = "البلدة"
        Me.LblTown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtTown
        '
        Me.TxtTown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTown.Location = New System.Drawing.Point(3, 17)
        Me.TxtTown.Name = "TxtTown"
        Me.TxtTown.ShowClearButton = True
        Me.TxtTown.Size = New System.Drawing.Size(147, 24)
        Me.TxtTown.TabIndex = 5
        Me.TxtTown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTown.ThemeName = "Office2010Blue"
        '
        'TxtAddress
        '
        Me.TxtAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(3, 47)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.ShowClearButton = True
        Me.TxtAddress.Size = New System.Drawing.Size(147, 24)
        Me.TxtAddress.TabIndex = 6
        Me.TxtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAddress.ThemeName = "Office2010Blue"
        '
        'LblVendorCompany
        '
        Me.LblVendorCompany.AutoSize = True
        Me.LblVendorCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblVendorCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblVendorCompany.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVendorCompany.Location = New System.Drawing.Point(390, 134)
        Me.LblVendorCompany.Name = "LblVendorCompany"
        Me.LblVendorCompany.Size = New System.Drawing.Size(79, 30)
        Me.LblVendorCompany.TabIndex = 87
        Me.LblVendorCompany.Text = "الشركة"
        Me.LblVendorCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(390, 104)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(79, 30)
        Me.LblTitle.TabIndex = 89
        Me.LblTitle.Text = "اللقب"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCompany
        '
        Me.TxtCompany.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCompany.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCompany.Location = New System.Drawing.Point(237, 137)
        Me.TxtCompany.Name = "TxtCompany"
        Me.TxtCompany.ShowClearButton = True
        Me.TxtCompany.Size = New System.Drawing.Size(147, 24)
        Me.TxtCompany.TabIndex = 4
        Me.TxtCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCompany.ThemeName = "Office2010Blue"
        '
        'TxtTitle
        '
        Me.TxtTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(237, 107)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.ShowClearButton = True
        Me.TxtTitle.Size = New System.Drawing.Size(147, 24)
        Me.TxtTitle.TabIndex = 3
        Me.TxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTitle.ThemeName = "Office2010Blue"
        '
        'TxtVendorLatin
        '
        Me.TxtVendorLatin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtVendorLatin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVendorLatin.Location = New System.Drawing.Point(237, 77)
        Me.TxtVendorLatin.Name = "TxtVendorLatin"
        Me.TxtVendorLatin.ShowClearButton = True
        Me.TxtVendorLatin.Size = New System.Drawing.Size(147, 24)
        Me.TxtVendorLatin.TabIndex = 2
        Me.TxtVendorLatin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtVendorLatin.ThemeName = "Office2010Blue"
        '
        'MTxtCellPhone
        '
        Me.MTxtCellPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MTxtCellPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtCellPhone.Location = New System.Drawing.Point(3, 107)
        Me.MTxtCellPhone.Mask = "00-000000"
        Me.MTxtCellPhone.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.MTxtCellPhone.Name = "MTxtCellPhone"
        Me.MTxtCellPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MTxtCellPhone.ShortcutsEnabled = False
        Me.MTxtCellPhone.Size = New System.Drawing.Size(147, 24)
        Me.MTxtCellPhone.TabIndex = 8
        Me.MTxtCellPhone.TabStop = False
        Me.MTxtCellPhone.Text = "__-______"
        Me.MTxtCellPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MTxtCellPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MTxtCellPhone.ThemeName = "Office2010Blue"
        '
        'LblCellPhone
        '
        Me.LblCellPhone.AutoSize = True
        Me.LblCellPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCellPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCellPhone.Location = New System.Drawing.Point(156, 104)
        Me.LblCellPhone.Name = "LblCellPhone"
        Me.LblCellPhone.Size = New System.Drawing.Size(50, 30)
        Me.LblCellPhone.TabIndex = 91
        Me.LblCellPhone.Text = "الخليوي"
        Me.LblCellPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BtnClose, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.BtnSaveAndNew, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 238)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(494, 45)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnClose.Location = New System.Drawing.Point(141, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(104, 36)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "إغلاق"
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnSaveAndNew
        '
        Me.BtnSaveAndNew.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnSaveAndNew.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveAndNew.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSaveAndNew.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSaveAndNew.Location = New System.Drawing.Point(253, 3)
        Me.BtnSaveAndNew.Name = "BtnSaveAndNew"
        Me.BtnSaveAndNew.Size = New System.Drawing.Size(102, 36)
        Me.BtnSaveAndNew.TabIndex = 0
        Me.BtnSaveAndNew.Tag = "Save"
        Me.BtnSaveAndNew.Text = "حفظ _ جديد"
        Me.BtnSaveAndNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'AddNewVendor
        '
        Me.AcceptButton = Me.BtnSaveAndNew
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(494, 283)
        Me.Controls.Add(Me.AddNewPages)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNewVendor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إضافة مورد"
        Me.ThemeName = "Office2010Blue"
        CType(Me.AddNewPages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddNewPages.ResumeLayout(False)
        Me.PageGeneral.ResumeLayout(False)
        Me.PageGeneral.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtVendorCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtVendorName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MTxtPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtVendorLatin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MTxtCellPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddNewPages As Telerik.WinControls.UI.RadPageView
    Friend WithEvents PageGeneral As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblVendorID As Label
    Friend WithEvents TxtVendorCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblVendorName As Label
    Friend WithEvents TxtVendorName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblLatinName As Label
    Friend WithEvents TxtVendorLatin As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblPhone As Label
    Friend WithEvents MTxtPhone As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblTown As Label
    Friend WithEvents TxtTown As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtAddress As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtCompany As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblVendorCompany As Label
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtTitle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents MTxtCellPhone As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblCellPhone As Label
End Class

