<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpeningBalance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpeningBalance))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LblCurrencyVal = New System.Windows.Forms.Label()
        Me.LblCurrency = New System.Windows.Forms.Label()
        Me.DropCurrency = New Telerik.WinControls.UI.RadDropDownList()
        Me.TxtDebitOn = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtCreditFor = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.TxtAccounts = New Telerik.WinControls.UI.RadButtonTextBox()
        Me.TxtAccountsBtn = New Telerik.WinControls.UI.RadButtonElement()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAccName = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnSaveAndNew = New Telerik.WinControls.UI.RadButton()
        Me.BtnClose = New Telerik.WinControls.UI.RadButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TxtCurrencyVal = New Telerik.WinControls.UI.RadTextBox()
        Me.BtnGetCurrencyVal = New Telerik.WinControls.UI.RadButton()
        Me.txtDollarRateAmt = New Telerik.WinControls.UI.RadTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtDebitOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCreditFor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtAccName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.TxtCurrencyVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnGetCurrencyVal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDollarRateAmt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.LblCurrencyVal, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LblCurrency, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DropCurrency, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtDebitOn, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtCreditFor, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtAccounts, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LblUsername, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TxtAccName, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 1, 2)
        Me.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'LblCurrencyVal
        '
        resources.ApplyResources(Me.LblCurrencyVal, "LblCurrencyVal")
        Me.LblCurrencyVal.Name = "LblCurrencyVal"
        '
        'LblCurrency
        '
        resources.ApplyResources(Me.LblCurrency, "LblCurrency")
        Me.LblCurrency.Name = "LblCurrency"
        '
        'DropCurrency
        '
        Me.DropCurrency.BackColor = System.Drawing.Color.White
        Me.DropCurrency.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.DropCurrency, "DropCurrency")
        Me.DropCurrency.DropDownAnimationEnabled = True
        Me.DropCurrency.Name = "DropCurrency"
        Me.DropCurrency.Tag = ""
        Me.DropCurrency.ThemeName = "Office2010Blue"
        '
        'TxtDebitOn
        '
        Me.TxtDebitOn.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.TxtDebitOn, "TxtDebitOn")
        Me.TxtDebitOn.Name = "TxtDebitOn"
        Me.TxtDebitOn.TabStop = False
        Me.TxtDebitOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtDebitOn.ThemeName = "Office2010Blue"
        '
        'TxtCreditFor
        '
        Me.TxtCreditFor.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.TxtCreditFor, "TxtCreditFor")
        Me.TxtCreditFor.Name = "TxtCreditFor"
        Me.TxtCreditFor.TabStop = False
        Me.TxtCreditFor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCreditFor.ThemeName = "Office2010Blue"
        '
        'TxtAccounts
        '
        Me.TxtAccounts.AcceptsTab = True
        resources.ApplyResources(Me.TxtAccounts, "TxtAccounts")
        Me.TxtAccounts.BackColor = System.Drawing.Color.White
        Me.TxtAccounts.HideSelection = False
        Me.TxtAccounts.LeftButtonItems.AddRange(New Telerik.WinControls.RadItem() {Me.TxtAccountsBtn})
        Me.TxtAccounts.MaxLength = 65535
        Me.TxtAccounts.Name = "TxtAccounts"
        Me.TxtAccounts.ReadOnly = True
        Me.TxtAccounts.ShortcutsEnabled = False
        Me.TxtAccounts.ShowClearButton = True
        Me.TxtAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAccounts.ThemeName = "Office2010Blue"
        Me.TxtAccounts.WordWrap = False
        '
        'TxtAccountsBtn
        '
        Me.TxtAccountsBtn.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        Me.TxtAccountsBtn.Image = Global.HEHAccounting.My.Resources.Resources.find
        resources.ApplyResources(Me.TxtAccountsBtn, "TxtAccountsBtn")
        Me.TxtAccountsBtn.Name = "TxtAccountsBtn"
        Me.TxtAccountsBtn.SmallImage = Global.HEHAccounting.My.Resources.Resources.find
        Me.TxtAccountsBtn.UseCompatibleTextRendering = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'LblUsername
        '
        resources.ApplyResources(Me.LblUsername, "LblUsername")
        Me.LblUsername.Name = "LblUsername"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TxtAccName
        '
        Me.TxtAccName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.TxtAccName, "TxtAccName")
        Me.TxtAccName.Name = "TxtAccName"
        Me.TxtAccName.ShortcutsEnabled = False
        Me.TxtAccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtAccName.ThemeName = "Office2010Blue"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnSaveAndNew, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BtnClose, 1, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'BtnSaveAndNew
        '
        resources.ApplyResources(Me.BtnSaveAndNew, "BtnSaveAndNew")
        Me.BtnSaveAndNew.Image = Global.HEHAccounting.My.Resources.Resources.Save
        Me.BtnSaveAndNew.Name = "BtnSaveAndNew"
        Me.BtnSaveAndNew.Tag = "Save"
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.Image = Global.HEHAccounting.My.Resources.Resources.Close
        Me.BtnClose.Name = "BtnClose"
        '
        'TableLayoutPanel4
        '
        resources.ApplyResources(Me.TableLayoutPanel4, "TableLayoutPanel4")
        Me.TableLayoutPanel4.Controls.Add(Me.txtDollarRateAmt, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.BtnGetCurrencyVal, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TxtCurrencyVal, 0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        '
        'TxtCurrencyVal
        '
        Me.TxtCurrencyVal.AcceptsTab = True
        Me.TxtCurrencyVal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtCurrencyVal.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.TxtCurrencyVal, "TxtCurrencyVal")
        Me.TxtCurrencyVal.HideSelection = False
        Me.TxtCurrencyVal.MaxLength = 65535
        Me.TxtCurrencyVal.Name = "TxtCurrencyVal"
        Me.TxtCurrencyVal.Tag = "1"
        Me.TxtCurrencyVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCurrencyVal.ThemeName = "Office2010Blue"
        Me.TxtCurrencyVal.WordWrap = False
        '
        'BtnGetCurrencyVal
        '
        Me.BtnGetCurrencyVal.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.BtnGetCurrencyVal, "BtnGetCurrencyVal")
        Me.BtnGetCurrencyVal.Image = Global.HEHAccounting.My.Resources.Resources.search
        Me.BtnGetCurrencyVal.Name = "BtnGetCurrencyVal"
        '
        'txtDollarRateAmt
        '
        Me.txtDollarRateAmt.AcceptsTab = True
        Me.txtDollarRateAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDollarRateAmt.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.txtDollarRateAmt, "txtDollarRateAmt")
        Me.txtDollarRateAmt.HideSelection = False
        Me.txtDollarRateAmt.MaxLength = 65535
        Me.txtDollarRateAmt.Name = "txtDollarRateAmt"
        Me.txtDollarRateAmt.Tag = "1"
        Me.txtDollarRateAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDollarRateAmt.ThemeName = "Office2010Blue"
        Me.txtDollarRateAmt.WordWrap = False
        '
        'OpeningBalance
        '
        Me.AcceptButton = Me.BtnSaveAndNew
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpeningBalance"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.ThemeName = "Office2010Blue"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DropCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtDebitOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCreditFor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtAccName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BtnSaveAndNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.TxtCurrencyVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnGetCurrencyVal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDollarRateAmt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BtnSaveAndNew As Telerik.WinControls.UI.RadButton
    Friend WithEvents BtnClose As Telerik.WinControls.UI.RadButton
    Friend WithEvents TxtAccounts As Telerik.WinControls.UI.RadButtonTextBox
    Friend WithEvents TxtAccountsBtn As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents TxtAccName As Telerik.WinControls.UI.RadTextBox
    Private WithEvents TxtDebitOn As Telerik.WinControls.UI.RadMaskedEditBox
    Private WithEvents TxtCreditFor As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents DropCurrency As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TxtCurrencyVal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents BtnGetCurrencyVal As Telerik.WinControls.UI.RadButton
    Friend WithEvents LblCurrency As Label
    Friend WithEvents LblCurrencyVal As Label
    Friend WithEvents txtDollarRateAmt As Telerik.WinControls.UI.RadTextBox
End Class

