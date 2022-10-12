<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddNewCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewCustomer))
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        Me.AddNewPages = New Telerik.WinControls.UI.RadPageView()
        Me.PageGeneral = New Telerik.WinControls.UI.RadPageViewPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtTitle = New Telerik.WinControls.UI.RadTextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblCustomerID = New System.Windows.Forms.Label()
        Me.TxtCustomerCode = New Telerik.WinControls.UI.RadTextBox()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.TxtCustomerName = New Telerik.WinControls.UI.RadTextBox()
        Me.LblLatinName = New System.Windows.Forms.Label()
        Me.TxtCustomerLatin = New Telerik.WinControls.UI.RadTextBox()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.MTxtCustomerPhone = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LblTown = New System.Windows.Forms.Label()
        Me.TxtCustomerTown = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtCustomerAddress = New Telerik.WinControls.UI.RadTextBox()
        Me.MTxtCellPhone = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.LblCellPhone = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddNewPages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddNewPages.SuspendLayout()
        Me.PageGeneral.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomerLatin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MTxtCustomerPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomerTown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomerAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MTxtCellPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        'AddNewPages
        '
        Me.AddNewPages.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
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
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TxtTitle, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTitle, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCustomerID, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCustomerCode, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCustomerName, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCustomerName, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblLatinName, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCustomerLatin, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblPhone, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MTxtCustomerPhone, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LblAddress, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTown, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCustomerTown, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCustomerAddress, 4, 2)
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
        'TxtTitle
        '
        Me.TxtTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(227, 107)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.ShowClearButton = True
        Me.TxtTitle.Size = New System.Drawing.Size(144, 24)
        Me.TxtTitle.TabIndex = 3
        Me.TxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTitle.ThemeName = "Office2010Blue"
        '
        'LblTitle
        '
        Me.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(377, 104)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(92, 30)
        Me.LblTitle.TabIndex = 66
        Me.LblTitle.Text = "اللقب"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCustomerID
        '
        Me.LblCustomerID.AutoSize = True
        Me.LblCustomerID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCustomerID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerID.Location = New System.Drawing.Point(377, 14)
        Me.LblCustomerID.Name = "LblCustomerID"
        Me.LblCustomerID.Size = New System.Drawing.Size(92, 30)
        Me.LblCustomerID.TabIndex = 62
        Me.LblCustomerID.Text = "كود الزبون"
        Me.LblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCustomerCode
        '
        Me.TxtCustomerCode.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtCustomerCode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCustomerCode.Enabled = False
        Me.TxtCustomerCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerCode.Location = New System.Drawing.Point(227, 17)
        Me.TxtCustomerCode.Name = "TxtCustomerCode"
        Me.TxtCustomerCode.Size = New System.Drawing.Size(144, 24)
        Me.TxtCustomerCode.TabIndex = 0
        Me.TxtCustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCustomerCode.ThemeName = "Office2010Blue"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCustomerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerName.Location = New System.Drawing.Point(377, 44)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(92, 30)
        Me.LblCustomerName.TabIndex = 61
        Me.LblCustomerName.Text = "إسم الزبون"
        Me.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCustomerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(227, 47)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ShowClearButton = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(144, 24)
        Me.TxtCustomerName.TabIndex = 1
        Me.TxtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCustomerName.ThemeName = "Office2010Blue"
        '
        'LblLatinName
        '
        Me.LblLatinName.AutoSize = True
        Me.LblLatinName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblLatinName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLatinName.Location = New System.Drawing.Point(377, 74)
        Me.LblLatinName.Name = "LblLatinName"
        Me.LblLatinName.Size = New System.Drawing.Size(92, 30)
        Me.LblLatinName.TabIndex = 65
        Me.LblLatinName.Text = "الإسم اللاتيني"
        Me.LblLatinName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCustomerLatin
        '
        Me.TxtCustomerLatin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCustomerLatin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerLatin.Location = New System.Drawing.Point(227, 77)
        Me.TxtCustomerLatin.Name = "TxtCustomerLatin"
        Me.TxtCustomerLatin.ShowClearButton = True
        Me.TxtCustomerLatin.Size = New System.Drawing.Size(144, 24)
        Me.TxtCustomerLatin.TabIndex = 2
        Me.TxtCustomerLatin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCustomerLatin.ThemeName = "Office2010Blue"
        '
        'LblPhone
        '
        Me.LblPhone.AutoSize = True
        Me.LblPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhone.Location = New System.Drawing.Point(153, 74)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(50, 30)
        Me.LblPhone.TabIndex = 67
        Me.LblPhone.Text = "الهاتف"
        Me.LblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MTxtCustomerPhone
        '
        Me.MTxtCustomerPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MTxtCustomerPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MTxtCustomerPhone.Location = New System.Drawing.Point(3, 77)
        Me.MTxtCustomerPhone.Mask = "00-000000"
        Me.MTxtCustomerPhone.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.MTxtCustomerPhone.Name = "MTxtCustomerPhone"
        Me.MTxtCustomerPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MTxtCustomerPhone.ShortcutsEnabled = False
        Me.MTxtCustomerPhone.Size = New System.Drawing.Size(144, 24)
        Me.MTxtCustomerPhone.TabIndex = 6
        Me.MTxtCustomerPhone.TabStop = False
        Me.MTxtCustomerPhone.Text = "__-______"
        Me.MTxtCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MTxtCustomerPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MTxtCustomerPhone.ThemeName = "Office2010Blue"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblAddress.Location = New System.Drawing.Point(153, 44)
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
        Me.LblTown.Location = New System.Drawing.Point(153, 14)
        Me.LblTown.Name = "LblTown"
        Me.LblTown.Size = New System.Drawing.Size(50, 30)
        Me.LblTown.TabIndex = 80
        Me.LblTown.Text = "البلدة"
        Me.LblTown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCustomerTown
        '
        Me.TxtCustomerTown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCustomerTown.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerTown.Location = New System.Drawing.Point(3, 17)
        Me.TxtCustomerTown.Name = "TxtCustomerTown"
        Me.TxtCustomerTown.ShowClearButton = True
        Me.TxtCustomerTown.Size = New System.Drawing.Size(144, 24)
        Me.TxtCustomerTown.TabIndex = 4
        Me.TxtCustomerTown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCustomerTown.ThemeName = "Office2010Blue"
        '
        'TxtCustomerAddress
        '
        Me.TxtCustomerAddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtCustomerAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerAddress.Location = New System.Drawing.Point(3, 47)
        Me.TxtCustomerAddress.Name = "TxtCustomerAddress"
        Me.TxtCustomerAddress.ShowClearButton = True
        Me.TxtCustomerAddress.Size = New System.Drawing.Size(144, 24)
        Me.TxtCustomerAddress.TabIndex = 5
        Me.TxtCustomerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCustomerAddress.ThemeName = "Office2010Blue"
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
        Me.MTxtCellPhone.Size = New System.Drawing.Size(144, 24)
        Me.MTxtCellPhone.TabIndex = 92
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
        Me.LblCellPhone.Location = New System.Drawing.Point(153, 104)
        Me.LblCellPhone.Name = "LblCellPhone"
        Me.LblCellPhone.Size = New System.Drawing.Size(50, 30)
        Me.LblCellPhone.TabIndex = 93
        Me.LblCellPhone.Text = "الخليوي"
        Me.LblCellPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddNewCustomer
        '
        Me.AcceptButton = Me.BtnSaveAndNew
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(494, 283)
        Me.Controls.Add(Me.AddNewPages)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNewCustomer"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "إضافة زبون"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddNewPages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddNewPages.ResumeLayout(False)
        Me.PageGeneral.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomerLatin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MTxtCustomerPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomerTown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomerAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MTxtCellPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents AddNewPages As Telerik.WinControls.UI.RadPageView
    Friend WithEvents PageGeneral As Telerik.WinControls.UI.RadPageViewPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblCustomerID As Label
    Friend WithEvents TxtCustomerCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblTown As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents MTxtCustomerPhone As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents TxtCustomerTown As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtCustomerName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblLatinName As Label
    Friend WithEvents LblPhone As Label
    Friend WithEvents TxtCustomerLatin As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtCustomerAddress As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtTitle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents MTxtCellPhone As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents LblCellPhone As Label
End Class

