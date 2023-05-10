<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VendorsCustomersPopup
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtVendorCustomerTitle = New Telerik.WinControls.UI.RadTextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtVendorCustomerCode = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtVendorCustomerName = New Telerik.WinControls.UI.RadTextBox()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.LblCustomerID = New System.Windows.Forms.Label()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.GridVendorsCustomers = New Telerik.WinControls.UI.RadGridView()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtVendorCustomerTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtVendorCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtVendorCustomerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVendorsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridVendorsCustomers.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.TxtVendorCustomerTitle, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTitle, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtVendorCustomerCode, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtVendorCustomerName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCustomerName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCustomerID, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnSearch, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnAdd, 6, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(595, 57)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TxtVendorCustomerTitle
        '
        Me.TxtVendorCustomerTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVendorCustomerTitle.Location = New System.Drawing.Point(190, 30)
        Me.TxtVendorCustomerTitle.Name = "TxtVendorCustomerTitle"
        Me.TxtVendorCustomerTitle.ShowClearButton = True
        Me.TxtVendorCustomerTitle.Size = New System.Drawing.Size(145, 24)
        Me.TxtVendorCustomerTitle.TabIndex = 2
        Me.TxtVendorCustomerTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtVendorCustomerTitle.ThemeName = "Office2010Blue"
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(190, 0)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(145, 27)
        Me.LblTitle.TabIndex = 70
        Me.LblTitle.Text = "اللقب"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtVendorCustomerCode
        '
        Me.TxtVendorCustomerCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVendorCustomerCode.Location = New System.Drawing.Point(492, 30)
        Me.TxtVendorCustomerCode.Name = "TxtVendorCustomerCode"
        Me.TxtVendorCustomerCode.ShowClearButton = True
        Me.TxtVendorCustomerCode.Size = New System.Drawing.Size(100, 24)
        Me.TxtVendorCustomerCode.TabIndex = 0
        Me.TxtVendorCustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtVendorCustomerCode.ThemeName = "Office2010Blue"
        '
        'TxtVendorCustomerName
        '
        Me.TxtVendorCustomerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVendorCustomerName.Location = New System.Drawing.Point(341, 30)
        Me.TxtVendorCustomerName.Name = "TxtVendorCustomerName"
        Me.TxtVendorCustomerName.ShowClearButton = True
        Me.TxtVendorCustomerName.Size = New System.Drawing.Size(145, 24)
        Me.TxtVendorCustomerName.TabIndex = 1
        Me.TxtVendorCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtVendorCustomerName.ThemeName = "Office2010Blue"
        '
        'LblCustomerName
        '
        Me.LblCustomerName.AutoSize = True
        Me.LblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCustomerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerName.Location = New System.Drawing.Point(341, 0)
        Me.LblCustomerName.Name = "LblCustomerName"
        Me.LblCustomerName.Size = New System.Drawing.Size(145, 27)
        Me.LblCustomerName.TabIndex = 65
        Me.LblCustomerName.Text = "الإسم"
        Me.LblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCustomerID
        '
        Me.LblCustomerID.AutoSize = True
        Me.LblCustomerID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LblCustomerID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomerID.Location = New System.Drawing.Point(492, 0)
        Me.LblCustomerID.Name = "LblCustomerID"
        Me.LblCustomerID.Size = New System.Drawing.Size(100, 27)
        Me.LblCustomerID.TabIndex = 65
        Me.LblCustomerID.Text = "الكود"
        Me.LblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnSearch.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnSearch.Location = New System.Drawing.Point(99, 10)
        Me.BtnSearch.Name = "BtnSearch"
        Me.TableLayoutPanel1.SetRowSpan(Me.BtnSearch, 2)
        Me.BtnSearch.Size = New System.Drawing.Size(75, 36)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'BtnAdd
        '
        Me.BtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Image = Global.HEHAccounting.My.Resources.Resources.Create
        Me.BtnAdd.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnAdd.Location = New System.Drawing.Point(11, 10)
        Me.BtnAdd.Name = "BtnAdd"
        Me.TableLayoutPanel1.SetRowSpan(Me.BtnAdd, 2)
        Me.BtnAdd.Size = New System.Drawing.Size(75, 36)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "إضافة"
        Me.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdd.Visible = False
        '
        'GridVendorsCustomers
        '
        Me.GridVendorsCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVendorsCustomers.Location = New System.Drawing.Point(0, 57)
        '
        '
        '
        Me.GridVendorsCustomers.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridVendorsCustomers.Name = "GridVendorsCustomers"
        Me.GridVendorsCustomers.Size = New System.Drawing.Size(595, 248)
        Me.GridVendorsCustomers.TabIndex = 2
        '
        'VendorsCustomersPopup
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 305)
        Me.Controls.Add(Me.GridVendorsCustomers)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VendorsCustomersPopup"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "موردين - زبائن"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtVendorCustomerTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtVendorCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtVendorCustomerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVendorsCustomers.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridVendorsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtVendorCustomerTitle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtVendorCustomerCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtVendorCustomerName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents LblCustomerID As Label
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents GridVendorsCustomers As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
End Class

