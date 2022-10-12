<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerPopup
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
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtTitle = New Telerik.WinControls.UI.RadTextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.TxtCustomerCode = New Telerik.WinControls.UI.RadTextBox()
        Me.TxtCustomerName = New Telerik.WinControls.UI.RadTextBox()
        Me.LblCustomerName = New System.Windows.Forms.Label()
        Me.LblCustomerID = New System.Windows.Forms.Label()
        Me.BtnSearch = New Telerik.WinControls.UI.RadButton()
        Me.BtnAdd = New Telerik.WinControls.UI.RadButton()
        Me.GridCustomers = New Telerik.WinControls.UI.RadGridView()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TxtTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCustomerName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridCustomers.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Controls.Add(Me.TxtTitle, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LblTitle, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCustomerCode, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCustomerName, 1, 1)
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
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(190, 30)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.ShowClearButton = True
        Me.TxtTitle.Size = New System.Drawing.Size(145, 24)
        Me.TxtTitle.TabIndex = 2
        Me.TxtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtTitle.ThemeName = "Office2010Blue"
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
        'TxtCustomerCode
        '
        Me.TxtCustomerCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerCode.Location = New System.Drawing.Point(492, 30)
        Me.TxtCustomerCode.Name = "TxtCustomerCode"
        Me.TxtCustomerCode.ShowClearButton = True
        Me.TxtCustomerCode.Size = New System.Drawing.Size(100, 24)
        Me.TxtCustomerCode.TabIndex = 0
        Me.TxtCustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCustomerCode.ThemeName = "Office2010Blue"
        '
        'TxtCustomerName
        '
        Me.TxtCustomerName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCustomerName.Location = New System.Drawing.Point(341, 30)
        Me.TxtCustomerName.Name = "TxtCustomerName"
        Me.TxtCustomerName.ShowClearButton = True
        Me.TxtCustomerName.Size = New System.Drawing.Size(145, 24)
        Me.TxtCustomerName.TabIndex = 1
        Me.TxtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCustomerName.ThemeName = "Office2010Blue"
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
        '
        'GridCustomers
        '
        Me.GridCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCustomers.Location = New System.Drawing.Point(0, 57)
        '
        '
        '
        Me.GridCustomers.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GridCustomers.Name = "GridCustomers"
        Me.GridCustomers.Size = New System.Drawing.Size(595, 248)
        Me.GridCustomers.TabIndex = 2
        '
        'CustomerPopup
        '
        Me.AcceptButton = Me.BtnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 305)
        Me.Controls.Add(Me.GridCustomers)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerPopup"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "الزبائن"
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.TxtTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCustomerName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCustomers.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtTitle As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents TxtCustomerCode As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TxtCustomerName As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents LblCustomerID As Label
    Friend WithEvents BtnSearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnAdd As Telerik.WinControls.UI.RadButton
    Friend WithEvents GridCustomers As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
End Class

