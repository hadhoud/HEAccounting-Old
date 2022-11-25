Imports System.ComponentModel
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking
Imports Telerik.WinControls.UI.Localization
Public Class MainForm

    Dim Frmitems As Items
    Dim FrmCustomers As Customers
    Dim FrmVendors As Vendors
    Dim FrmSalesOrders As SalesOrderFrm
    Dim FrmPurchasesOrders As PurchaseOrderFrm
    Dim FrmDaily As Daily
    Dim FrmSalesDailyWin As SalesDailyWin
    Dim FrmHomeForm As HomeForm
    Dim FrmDebitsCredits As DebitsCredits
    Dim FrmAddNewSalesInvoices As AddNewSaleInvoice
    Dim FrmItemsSalesWinReport As ItemsSalesWinReport
    Dim FrmDashboard As DashboardForm

    Dim FrmToOpen As String
    Dim FrmOpenTimer As New Timer
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        If BoolLTRLanguage Then
            ChangeToEng()
        Else
            Me.Text = LoStrId.LblProgramName & " - " & CompanyInfoName
            RadDockLocalizationProvider.CurrentProvider = New ArabicRadDockLocalization
            RadGridLocalizationProvider.CurrentProvider = New ArabicRadGridLocalization
        End If
        SubscribeEvents()

        Me.WindowDock.RegisterService(1, New MyDragDropService())
        Me.WindowDock.RegisterService(ServiceConstants.ContextMenu, New MyContextMenuService())
        Me.IsMdiContainer = True
        Me.LblStatusUsername.Text = Username
        Me.StripLblDateNow.Text = Format(Date.Now.Date, "yyyy-MM-dd")
        ShowPermissions()
    End Sub
    Private Sub ShowPermissions()
        If UserType = UserRole.Programmer Then
            Me.RibBtnUsers.Visibility = ElementVisibility.Visible
            Me.RibBtnCurrencies.Visibility = ElementVisibility.Visible
            Me.RibBtnSalesWin.Visibility = ElementVisibility.Visible
            Me.RibButtonDashboard.Visibility = IIf(BoolShowDashboardForm, ElementVisibility.Visible, ElementVisibility.Collapsed)
            Me.stripLblDollarRateValue.Visibility = IIf(BoolShowCurrencyRateInStatus, ElementVisibility.Visible, ElementVisibility.Collapsed)
            Me.stripLblLastDollarRate.Visibility = IIf(BoolShowCurrencyRateInStatus, ElementVisibility.Visible, ElementVisibility.Collapsed)
        Else
            Me.RibBtnUsers.Visibility = IIf(BoolShowUsers, ElementVisibility.Visible, ElementVisibility.Collapsed)
            Me.RibBtnCurrencies.Visibility = IIf(BoolShowUsers, ElementVisibility.Visible, ElementVisibility.Collapsed)
            Me.RibBtnSalesWin.Visibility = IIf(BoolShowSalesDailyWin, ElementVisibility.Visible, ElementVisibility.Collapsed)
            Me.RibButtonDashboard.Visibility = IIf(BoolShowDashboardForm, ElementVisibility.Visible, ElementVisibility.Collapsed)
            Me.stripLblDollarRateValue.Visibility = IIf(BoolShowCurrencyRateInStatus, ElementVisibility.Visible, ElementVisibility.Collapsed)
            Me.stripLblLastDollarRate.Visibility = IIf(BoolShowCurrencyRateInStatus, ElementVisibility.Visible, ElementVisibility.Collapsed)

        End If
        Dim PORow As DataRow = UserRolesdt.Select("KeyName = 'PO'").First
        Me.RibBtnAddPurchaseInvoices.Enabled = (UserType = UserRole.Programmer Or PORow("AllowAdd").ToString)
        Dim SORow As DataRow = UserRolesdt.Select("KeyName = 'SO'").First
        Me.RibBtnAddSalesInvoices.Enabled = (UserType = UserRole.Programmer Or SORow("AllowAdd").ToString)
        Dim ItemsRow As DataRow = UserRolesdt.Select("KeyName = 'ITS'").First
        Me.RibBtnAddItem.Enabled = (UserType = UserRole.Programmer Or ItemsRow("AllowAdd").ToString)
        Dim NRRow As DataRow = UserRolesdt.Select("KeyName = 'NR'").First
        Me.RibBtnNotesReceive.Enabled = (UserType = UserRole.Programmer Or NRRow("AllowAdd").ToString)
        Dim NPRow As DataRow = UserRolesdt.Select("KeyName = 'NP'").First
        Me.RibBtnNotesPay.Enabled = (UserType = UserRole.Programmer Or NPRow("AllowAdd").ToString)
    End Sub
    Private Sub SubscribeShortcuts()
        '  Me.RibonbtnItems.Shortcuts.Add(New RadShortcut(Keys.Alt, Keys.A))
        Dim Param(0) As String
        Param(0) = "@IUserID , " & UserID
        Dim UserShortcuts As DataTable = ExecuteProcedureDatatableWithParameters("SelectShortcuts", Param)
        If UserShortcuts.Rows.Count > 0 Then
            For Each row In UserShortcuts.Rows
                Select Case row.item("NameValue").ToString
                    Case AbbForms.Items
                        Me.RibonbtnItems.Shortcuts.Add(GetShortcuts(row.item("ShortcutValue").ToString))
                    Case AbbForms.AddItems
                        Me.RibBtnAddItem.Shortcuts.Add(GetShortcuts(row.item("ShortcutValue").ToString))
                    Case AbbForms.GroupsTree
                        Me.RibBtnItemsTree.Shortcuts.Add(GetShortcuts(row.item("ShortcutValue").ToString))
                    Case AbbForms.AddGroups
                        Me.RibBtnGroups.Shortcuts.Add(GetShortcuts(row.item("ShortcutValue").ToString))
                    Case AbbForms.SalesOrders
                        Me.RibBtnSalesOrders.Shortcuts.Add(GetShortcuts(row.item("ShortcutValue").ToString))
                    Case AbbForms.AddSaleOrder
                        Me.RibBtnAddSalesInvoices.Shortcuts.Add(GetShortcuts(row.item("ShortcutValue").ToString))
                    Case AbbForms.PurchasesOrders
                        Me.RibBtnPurchaseOrders.Shortcuts.Add(GetShortcuts(row.item("ShortcutValue").ToString))
                    Case AbbForms.AddPurchaseOrder
                        Me.RibBtnAddPurchaseInvoices.Shortcuts.Add(GetShortcuts(row.item("ShortcutValue").ToString))
                    Case AbbForms.GeneralNotes
                        Me.GeneralNotesReceive.Shortcuts.Add(GetShortcuts(row.item("ShortcutValue").ToString))
                    Case Else

                End Select
            Next
        End If

    End Sub
    Private Function GetShortcuts(ByVal UShortcut As String) As RadShortcut
        Dim AllKey As String() = UShortcut.Split("+")
        Dim StrModifierKey As String = AllKey(0).ToString
        Dim KEyModifier As Keys
        Dim Cnt As Integer = AllKey.Count - 2
        Dim KeysParam As Keys
        Dim OneRadShortcut As RadShortcut
        Dim j As Integer = 0

        Select Case StrModifierKey
            Case "Control"
                KEyModifier = Keys.Control
            Case "Alt"
                KEyModifier = Keys.Alt
            Case "Shift"
                KEyModifier = Keys.Shift
            Case Else
                KEyModifier = Keys.Control
        End Select

        If AllKey(1).Length > 1 Then
            KeysParam = ReturnKeys(AllKey(1))
        Else
            Dim c As Char = Convert.ToChar(AllKey(1))
            KeysParam = CType(Asc(Char.ToUpper(c)), Keys)
        End If
        OneRadShortcut = New RadShortcut(KEyModifier, KeysParam)
        Return OneRadShortcut
    End Function
    Function ReturnKeys(ByVal Skey As String) As Keys
        Select Case Skey
            Case Keys.F1.ToString
                Return Keys.F1
                Exit Function
            Case Keys.F2.ToString
                Return Keys.F2
                Exit Function
            Case Keys.F3.ToString
                Return Keys.F3
                Exit Function
            Case Keys.F4.ToString
                Return Keys.F4
                Exit Function
            Case Keys.F5.ToString
                Return Keys.F5
                Exit Function
            Case Keys.F6.ToString
                Return Keys.F6
                Exit Function
            Case Keys.F7.ToString
                Return Keys.F7
                Exit Function
            Case Keys.F8.ToString
                Return Keys.F8
                Exit Function
            Case Keys.F9.ToString
                Return Keys.F9
                Exit Function
            Case Keys.F10.ToString
                Return Keys.F10
                Exit Function
            Case Keys.F11.ToString
                Return Keys.F11
                Exit Function
            Case Keys.F12.ToString
                Return Keys.F12
                Exit Function
            Case Keys.Add.ToString
                Return Keys.Add
                Exit Function
            Case Keys.Apps.ToString
                Return Keys.Apps
                Exit Function
            Case Keys.Attn.ToString
                Return Keys.Attn
                Exit Function
            Case Keys.Back.ToString
                Return Keys.Back
                Exit Function
            Case Keys.Capital.ToString
                Return Keys.Capital
                Exit Function
            Case Keys.CapsLock.ToString
                Return Keys.CapsLock
                Exit Function
            Case Keys.Crsel.ToString
                Return Keys.Crsel
                Exit Function
            Case Keys.Divide.ToString
                Return Keys.Divide
                Exit Function
            Case Keys.Down.ToString
                Return Keys.Down
                Exit Function
            Case Keys.End.ToString
                Return Keys.End
                Exit Function
            Case Keys.Enter.ToString
                Return Keys.Enter
                Exit Function
            Case Keys.EraseEof.ToString
                Return Keys.EraseEof
                Exit Function
            Case Keys.Escape.ToString
                Return Keys.Escape
                Exit Function
            Case Keys.Execute.ToString
                Return Keys.F2
                Exit Function
            Case Keys.Exsel.ToString
                Return Keys.Exsel
                Exit Function
            Case Keys.FinalMode.ToString
                Return Keys.FinalMode
                Exit Function
            Case Keys.HanguelMode.ToString
                Return Keys.HanguelMode
                Exit Function
            Case Keys.Home.ToString
                Return Keys.Home
                Exit Function
            Case Keys.Oem1.ToString
                Return Keys.Oem1
                Exit Function
            Case Keys.Oem102.ToString
                Return Keys.Oem102
                Exit Function
            Case Keys.Oem2.ToString
                Return Keys.Oem2
                Exit Function
            Case Keys.Oem3.ToString
                Return Keys.Oem3
                Exit Function
            Case Keys.Oem4.ToString
                Return Keys.Oem4
                Exit Function
            Case Keys.Oem5.ToString
                Return Keys.Oem5
                Exit Function
            Case Keys.Oem6.ToString
                Return Keys.Oem6
                Exit Function
            Case Keys.Oem7.ToString
                Return Keys.Oem7
                Exit Function
            Case Keys.Oem8.ToString
                Return Keys.Oem8
                Exit Function
            Case Keys.OemBackslash.ToString
                Return Keys.OemBackslash
                Exit Function
            Case Keys.OemClear.ToString
                Return Keys.OemClear
                Exit Function
            Case Keys.OemCloseBrackets.ToString
                Return Keys.OemCloseBrackets
                Exit Function
            Case Keys.Oemcomma.ToString
                Return Keys.Oemcomma
                Exit Function
            Case Keys.OemMinus.ToString
                Return Keys.OemMinus
                Exit Function
            Case Keys.OemOpenBrackets.ToString
                Return Keys.OemOpenBrackets
                Exit Function
            Case Keys.Oemplus.ToString
                Return Keys.Oemplus
                Exit Function
            Case Keys.OemSemicolon.ToString
                Return Keys.OemSemicolon
                Exit Function
            Case Keys.OemQuotes.ToString
                Return Keys.OemQuotes
                Exit Function
            Case Keys.Space.ToString
                Return Keys.Space
                Exit Function
            Case Keys.Tab.ToString
                Return Keys.Tab
                Exit Function
            Case Keys.Cancel.ToString
                Return Keys.Cancel
                Exit Function
            Case Keys.Insert.ToString
                Return Keys.Insert
                Exit Function
            Case Keys.Decimal.ToString
                Return Keys.Decimal
                Exit Function
            Case Keys.Delete.ToString
                Return Keys.Delete
                Exit Function
            Case Else
                Return Keys.F1
                Exit Function
        End Select
    End Function
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.LblLatinProgramName & " - " & CompanyLatinName
        Me.RibBtnClose.Text = LoStrId.LblClose
        Me.RibBtnNew.Text = LoStrId.LblNew
        Me.RibonbtnItems.Text = LoStrId.LblItems
        Me.RibBtnGroups.Text = LoStrId.LblGroups

        Me.RibBtnEdit.Text = LoStrId.LblEdit
        Me.RibBtnShowOption.Text = LoStrId.LblShow
        Me.RibBtnCustomers.Text = LoStrId.lblCustomers
        Me.RibBtnVendors.Text = LoStrId.lblVendors
        Me.RibBtnSalesOrders.Text = LoStrId.LblSalesOrders
        Me.RibBtnPurchaseOrders.Text = LoStrId.lblPurchasesOrders
        Me.RibBtnItemsTree.Text = LoStrId.LblItemTree
        Me.RibBtnAddItem.Text = LoStrId.LblAddItem
        Me.RibBtnAddSalesInvoices.Text = LoStrId.LblAddSO
        Me.RibBtnAddPurchaseInvoices.Text = LoStrId.LblAddPO
        Me.RibBtnNotesPay.Text = LoStrId.LblNotePayable
        Me.RibBtnNotesReceive.Text = LoStrId.LblNoteReceive

        'Tabs
        Me.RibbonTabHome.Text = LoStrId.lblHome

        'Groups
        Me.RibGFastLink.Text = LoStrId.LblQuicklinks
        Me.RibGroupLabelMostanad.Text = LoStrId.LblDocument
        Me.RibGOption.Text = LoStrId.LblPageOption
        Me.RibGForms.Text = LoStrId.LblForms
    End Sub

    Sub SubscribeEvents()
        AddHandler WindowDock.DockWindowAdded, AddressOf WindowDock_DockWindowAdded
        AddHandler WindowDock.ActiveWindowChanged, AddressOf WindowDock_ActiveWindowChanged
        AddHandler WindowDock.DockWindowClosing, AddressOf WindowDock_DockWindowClosing
        AddHandler RibBtnClose.Click, AddressOf RibBtnClose_Click
        AddHandler RibBtnNew.Click, AddressOf RibBtnNew_Click
        AddHandler RibBtnShowOption.Click, AddressOf RibBtnShowOption_Click
        AddHandler RibonbtnItems.Click, AddressOf RibonbtnItems_Click
        AddHandler RibBtnCustomers.Click, AddressOf RibBtnCustomers_Click
        AddHandler FrmOpenTimer.Tick, AddressOf FrmOpenTimerTick
        AddHandler GeneralNotesPayable.Click, AddressOf OpenGeneralNotesPayable
        AddHandler GeneralNotesReceive.Click, AddressOf OpenGeneralNotesReceive
        AddHandler RadMenuBackup.Click, AddressOf OpenBackupDbForm
        AddHandler RadMenuRestore.Click, AddressOf OpenRestoreDbForm
        FrmOpenTimer.Interval = 200
    End Sub

    Private Sub FrmOpenTimerTick(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        If FrmToOpen = "Items" Then
            If Frmitems Is Nothing Then
                Frmitems = New Items With {
                    .Height = WindowDock.Height,
                    .Width = WindowDock.Width,
                    .MdiParent = Me
                }
                Frmitems.Show()
            End If
            ActWindow(Frmitems)

        ElseIf FrmToOpen = "Customers" Then
            If FrmCustomers Is Nothing Then
                FrmCustomers = New Customers With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .MdiParent = Me
                }
                FrmCustomers.Show()
            End If
            ActWindow(FrmCustomers)

        ElseIf FrmToOpen = "Vendors" Then
            If FrmVendors Is Nothing Then
                FrmVendors = New Vendors With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .MdiParent = Me
                }
                FrmVendors.Show()
            End If
            ActWindow(FrmVendors)
        ElseIf FrmToOpen = "SalesOrders" Then
            If FrmSalesOrders Is Nothing Then
                FrmSalesOrders = New SalesOrderFrm With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .MdiParent = Me
                }
                FrmSalesOrders.Show()
            End If
            ActWindow(FrmSalesOrders)
        ElseIf FrmToOpen = "PurchasesOrders" Then
            If FrmPurchasesOrders Is Nothing Then
                FrmPurchasesOrders = New PurchaseOrderFrm With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .MdiParent = Me
                }
                FrmPurchasesOrders.Show()
            End If
            ActWindow(FrmPurchasesOrders)

        ElseIf FrmToOpen = "Daily" Then
            If FrmDaily Is Nothing Then
                FrmDaily = New Daily With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .MdiParent = Me
                }
                FrmDaily.Show()
                ActWindow(FrmDaily)
            End If
            ActWindow(FrmDaily)

        ElseIf FrmToOpen = "SalesDailyWin" Then
            If FrmSalesDailyWin Is Nothing Then
                FrmSalesDailyWin = New SalesDailyWin With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .MdiParent = Me
                }
                FrmSalesDailyWin.Show()
                ActWindow(FrmSalesDailyWin)
            End If

            ActWindow(FrmSalesDailyWin)
        ElseIf FrmToOpen = "HomeForm" Then
            If FrmHomeForm Is Nothing Then
                FrmHomeForm = New HomeForm With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .MdiParent = Me
                }
                FrmHomeForm.Show()
                ActWindow(FrmHomeForm)
            End If
            ActWindow(FrmHomeForm)

        ElseIf FrmToOpen = "AddNewSaleInvoice" Then
            If FrmAddNewSalesInvoices Is Nothing Then
                FrmAddNewSalesInvoices = New AddNewSaleInvoice With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None,
                    .MdiParent = Me
                }
                FrmAddNewSalesInvoices.Show()
            End If
            ActWindow(FrmAddNewSalesInvoices)

        ElseIf FrmToOpen = "Credits" Then
            If FrmDebitsCredits Is Nothing Then
                FrmDebitsCredits = New DebitsCredits With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .WhatToSelect = "CForHim",
                    .MdiParent = Me
                }
                FrmDebitsCredits.Show()
                ActWindow(FrmDebitsCredits)
            End If
            FrmDebitsCredits.DropType.SelectedValue = CreditsDebits.Credits
            FrmDebitsCredits.Text = Con.Creditors
            ActWindow(FrmDebitsCredits)

        ElseIf FrmToOpen = "Debits" Then
            If FrmDebitsCredits Is Nothing Then
                FrmDebitsCredits = New DebitsCredits With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                      .WhatToSelect = "DOnHim",
                    .MdiParent = Me
                }
                FrmDebitsCredits.Show()
                ActWindow(FrmDebitsCredits)
            End If
            FrmDebitsCredits.DropType.SelectedValue = CreditsDebits.Debts
            FrmDebitsCredits.Text = Con.Debtors
            ActWindow(FrmDebitsCredits)

        ElseIf FrmToOpen = "RPTItemsSalesWin" Then
            If FrmItemsSalesWinReport Is Nothing Then
                FrmItemsSalesWinReport = New ItemsSalesWinReport With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .MdiParent = Me
                }
                FrmItemsSalesWinReport.Show()
            End If
            ActWindow(FrmItemsSalesWinReport)


        ElseIf FrmToOpen = "FrmDashboard" Then
            If FrmDashboard Is Nothing Then
                FrmDashboard = New DashboardForm With {
                    .Width = WindowDock.Width,
                    .Height = WindowDock.Height,
                    .MdiParent = Me
                }
                FrmDashboard.Show()
                ActWindow(FrmDashboard)
            End If
            ActWindow(FrmDashboard)

        End If

        Me.Cursor = Cursors.Default
        FrmOpenTimer.Stop()
    End Sub
    Private Sub RibonbtnItems_Click(sender As Object, e As EventArgs)
        'If Frmitems Is Nothing Then
        '    Frmitems = New Items With {
        '        .Height = WindowDock.Height,
        '        .Width = WindowDock.Width,
        '        .MdiParent = Me
        '    }
        '    Frmitems.Show()
        'End If
        'ActWindow(Frmitems)
        FrmToOpen = "Items"
        FrmOpenTimer.Start()
    End Sub
    Private Sub OpenBackupDbForm()
        Dim FrmBackupDb As New BackupFrm
        FrmBackupDb.BackupOrRestore = "Backup"
        FrmBackupDb.ShowDialog()
    End Sub

    Private Sub OpenRestoreDbForm()
        Dim FrmBackupDb As New BackupFrm
        FrmBackupDb.BackupOrRestore = "Restore"
        FrmBackupDb.ShowDialog()
    End Sub

    Private Sub OpenGeneralNotesPayable()
        Dim FrmGeneralNotesPayable As New GeneralNotes
        FrmGeneralNotesPayable.GeneralType = "NGP"
        FrmGeneralNotesPayable.ShowDialog()
    End Sub

    Private Sub OpenGeneralNotesReceive()
        Dim FrmGeneralNotesReceive As New GeneralNotes
        FrmGeneralNotesReceive.GeneralType = "NGR"
        FrmGeneralNotesReceive.ShowDialog()
    End Sub

    Private Sub RibBtnCustomers_Click(sender As Object, e As EventArgs)
        'If FrmCustomers Is Nothing Then
        '    FrmCustomers = New Customers With {
        '        .Width = WindowDock.Width,
        '        .Height = WindowDock.Height,
        '        .MdiParent = Me
        '    }
        '    FrmCustomers.Show()
        'End If
        'ActWindow(FrmCustomers)
        FrmToOpen = "Customers"
        FrmOpenTimer.Start()
    End Sub

    Private Sub RibBtnVendors_Click(sender As Object, e As EventArgs) Handles RibBtnVendors.Click
        'If FrmVendors Is Nothing Then
        '    FrmVendors = New Vendors With {
        '        .Width = WindowDock.Width,
        '        .Height = WindowDock.Height,
        '        .MdiParent = Me
        '    }
        '    FrmVendors.Show()
        'End If
        'ActWindow(FrmVendors)

        FrmToOpen = "Vendors"
        FrmOpenTimer.Start()
    End Sub

    Private Sub RibBtnSalesOrders_Click(sender As Object, e As EventArgs) Handles RibBtnSalesOrders.Click
        'If FrmSalesOrders Is Nothing Then
        '    FrmSalesOrders = New SalesOrderFrm With {
        '        .Width = WindowDock.Width,
        '        .Height = WindowDock.Height,
        '        .MdiParent = Me
        '    }
        '    FrmSalesOrders.Show()
        'End If
        'ActWindow(FrmSalesOrders)
        FrmToOpen = "SalesOrders"
        FrmOpenTimer.Start()
    End Sub

    Private Sub RibBtnPurchaseOrders_Click(sender As Object, e As EventArgs) Handles RibBtnPurchaseOrders.Click
        'If FrmPurchasesOrders Is Nothing Then
        '    FrmPurchasesOrders = New PurchaseOrderFrm With {
        '        .Width = WindowDock.Width,
        '        .Height = WindowDock.Height,
        '        .MdiParent = Me
        '    }
        '    FrmPurchasesOrders.Show()
        'End If
        'ActWindow(FrmPurchasesOrders)
        FrmToOpen = "PurchasesOrders"
        FrmOpenTimer.Start()
    End Sub
    Private Sub RibBtnCreditsReport_Click(sender As Object, e As EventArgs) Handles RibBtnCreditsReport.Click
        FrmToOpen = "Credits"
        FrmOpenTimer.Start()
    End Sub

    Private Sub RibBtnDebitsReport_Click(sender As Object, e As EventArgs) Handles RibBtnDebitsReport.Click
        FrmToOpen = "Debits"
        FrmOpenTimer.Start()
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
        MyBase.OnLoad(e)
    End Sub
    Private Sub RibBtnClose_Click(sender As Object, e As EventArgs)
        If WindowDock.DockWindows.Count > 0 Then
            Me.WindowDock.ActiveWindow.Close()
        End If
    End Sub

    Private Sub RibBtnNew_Click(sender As Object, e As EventArgs)
        If Me.WindowDock.DockWindows.Count > 0 Then
            Select Case Me.WindowDock.ActiveWindow.Tag
                Case "Items"
                    Frmitems.BtnNew.PerformClick()
                    Exit Select
                Case "Customers"
                    FrmCustomers.BtnNew.PerformClick()
                    Exit Select
                Case "Vendors"
                    FrmVendors.BtnNew.PerformClick()
                    Exit Select
                Case "SalesOrders"
                    FrmSalesOrders.BtnNew.PerformClick()
                    Exit Select
                Case "PurchasesOrders"
                    FrmPurchasesOrders.BtnNew.PerformClick()
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub RibBtnShowOption_Click(sender As Object, e As EventArgs)
        If WindowDock.DockWindows.Count > 0 Then
            Dim ActWindow As HostWindow = Me.WindowDock.ActiveWindow
            Dim Vis As Boolean
            If Me.RibBtnShowOption.ToggleState = Enumerations.ToggleState.On Then
                Vis = False
            Else
                Vis = True
            End If
            Select Case ActWindow.Content.Tag
                Case "Items"
                    Frmitems.PnlOptions.Visible = Vis
                    Exit Select
                Case "Customers"
                    FrmCustomers.PnlOptions.Visible = Vis
                    Exit Select
                Case "Vendors"
                    FrmVendors.PnlOptions.Visible = Vis
                    Exit Select
                Case "SalesOrders"
                    FrmSalesOrders.PnlOptions.Visible = Vis
                    Exit Select
                Case "PurchasesOrders"
                    FrmPurchasesOrders.PnlOptions.Visible = Vis
                    Exit Select
                Case "Daily"
                    FrmDaily.PnlOptions.Visible = Vis
                    Exit Select
                Case "SalesDailyWin"
                    FrmSalesDailyWin.PnlOptions.Visible = Vis
                    Exit Select
                Case "DebitsCredits"
                    FrmDebitsCredits.PnlOptions.Visible = Vis
                    Exit Select
                Case "ItemsSalesDailyWinReport"
                    FrmItemsSalesWinReport.PnlOptions.Visible = Vis
                    Exit Select

                Case "FrmDashboard"
                    'FrmDashboard.PnlOptions.Visible = Vis
                    Exit Select
            End Select
        End If
    End Sub


    Private Sub WindowDock_DockWindowClosing(sender As Object, e As DockWindowCancelEventArgs)
        Select Case e.NewWindow.Tag
            Case "Items"
                Frmitems = Nothing
                Exit Select
            Case "Customers"
                FrmCustomers = Nothing
                Exit Select
            Case "Vendors"
                FrmVendors = Nothing
            Case "SalesOrders"
                FrmSalesOrders = Nothing
                Exit Select
            Case "PurchasesOrders"
                FrmPurchasesOrders = Nothing
                Exit Select
            Case "Daily"
                FrmDaily = Nothing
                Exit Select
            Case "SalesDailyWin"
                FrmSalesDailyWin = Nothing
                Exit Select
            Case "HomeForm"
                FrmHomeForm = Nothing
                Exit Select
            Case "AddNewSaleInvoice"
                FrmAddNewSalesInvoices = Nothing
                Exit Select
            Case "DebitsCredits"
                FrmDebitsCredits = Nothing
                Exit Select
            Case "ItemsSalesDailyWinReport"
                FrmItemsSalesWinReport = Nothing
                Exit Select
            Case "FrmDashboard"
                FrmDashboard = Nothing
                Exit Select
        End Select
    End Sub
    Private Sub ActWindow(Frm As Form)
        Me.WindowDock.ActivateMdiChild(Frm)
        EnableDocumentBtn()
    End Sub

    Private Sub WindowDock_DockWindowAdded(sender As Object, e As DockWindowEventArgs)
        e.DockWindow.TabStripItem.Font = New Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point)
        e.DockWindow.Tag = DirectCast(e.DockWindow, Telerik.WinControls.UI.Docking.HostWindow).MdiChild.Tag.ToString
    End Sub

    Private Sub WindowDock_ActiveWindowChanged(sender As Object, e As DockWindowEventArgs)
        For Each w In Me.WindowDock.DockWindows
            w.TabStripItem.ForeColor = Color.Black
        Next
        EnableDocumentBtn()
    End Sub

    Private Sub EnableDocumentBtn()
        If WindowDock.DockWindows.DocumentWindows.Count > 0 Then
            ' e.DockWindow.TabStripItem.ForeColor = Color.Blue
            Select Case Me.WindowDock.ActiveWindow.Tag
                Case "Items"
                    If Frmitems IsNot Nothing Then
                        Me.RibBtnNew.Enabled = Frmitems.BtnNew.Enabled
                        Me.RibBtnEdit.Enabled = Frmitems.BtnEdit.Enabled
                        Me.RibBtnShowOption.IsChecked = Frmitems.PnlOptions.Visible
                    End If
                    Exit Select
                Case "Customers"
                    If FrmCustomers IsNot Nothing Then
                        Me.RibBtnNew.Enabled = FrmCustomers.BtnNew.Enabled
                        Me.RibBtnShowOption.IsChecked = FrmCustomers.PnlOptions.Visible
                        Me.RibBtnEdit.Enabled = FrmCustomers.BtnEdit.Enabled
                    End If
                    Exit Select
                Case "Vendors"
                    If FrmVendors IsNot Nothing Then
                        Me.RibBtnNew.Enabled = FrmVendors.BtnNew.Enabled
                        Me.RibBtnShowOption.IsChecked = FrmVendors.PnlOptions.Visible
                        Me.RibBtnEdit.Enabled = FrmVendors.BtnEdit.Enabled
                    End If
                    Exit Select
                Case "SalesOrders"
                    If FrmSalesOrders IsNot Nothing Then
                        Me.RibBtnNew.Enabled = FrmSalesOrders.BtnNew.Enabled
                        Me.RibBtnShowOption.IsChecked = FrmSalesOrders.PnlOptions.Visible
                        Me.RibBtnEdit.Enabled = FrmSalesOrders.BtnEdit.Enabled
                    End If
                    Exit Select
                Case "PurchasesOrders"
                    If FrmPurchasesOrders IsNot Nothing Then
                        Me.RibBtnNew.Enabled = FrmPurchasesOrders.BtnNew.Enabled
                        Me.RibBtnShowOption.IsChecked = FrmPurchasesOrders.PnlOptions.Visible
                        Me.RibBtnEdit.Enabled = FrmPurchasesOrders.BtnEdit.Enabled
                    End If
                    Exit Select
                Case "Daily"
                    If FrmDaily IsNot Nothing Then
                        Me.RibBtnEdit.Enabled = FrmDaily.BtnOpen.Enabled
                        Me.RibBtnNew.Enabled = False
                        Me.RibBtnShowOption.IsChecked = FrmDaily.PnlOptions.Visible
                    End If
                    Exit Select
                Case "SalesDailyWin"
                    If FrmSalesDailyWin IsNot Nothing Then
                        Me.RibBtnNew.Enabled = False
                        Me.RibBtnShowOption.IsChecked = FrmSalesDailyWin.PnlOptions.Visible
                    End If
                    Exit Select
                Case "HomeForm"
                    If FrmHomeForm IsNot Nothing Then
                        Me.RibBtnEdit.Enabled = False
                        Me.RibBtnNew.Enabled = False
                        Me.RibBtnShowOption.IsChecked = False
                    End If
                    Exit Select
                Case "AddNewSaleInvoice"
                    If FrmAddNewSalesInvoices IsNot Nothing Then
                        Me.RibBtnEdit.Enabled = False
                        Me.RibBtnNew.Enabled = False
                        Me.RibBtnShowOption.IsChecked = False
                    End If
                    Exit Select
                Case "DebitsCredits"
                    If FrmDebitsCredits IsNot Nothing Then
                        Me.RibBtnEdit.Enabled = False
                        Me.RibBtnNew.Enabled = False
                        Me.RibBtnShowOption.IsChecked = FrmDebitsCredits.PnlOptions.Visible
                    End If
                    Exit Select
                Case "ItemsSalesDailyWinReport"
                    If FrmItemsSalesWinReport IsNot Nothing Then
                        Me.RibBtnEdit.Enabled = False
                        Me.RibBtnNew.Enabled = False
                        Me.RibBtnShowOption.IsChecked = FrmItemsSalesWinReport.PnlOptions.Visible
                    End If
                    Exit Select
                Case "FrmDashboard"
                    If FrmDashboard IsNot Nothing Then
                        Me.RibBtnEdit.Enabled = False
                        Me.RibBtnNew.Enabled = False
                        'Me.RibBtnShowOption.IsChecked = FrmDashboard.PnlOptions.Visible
                    End If
                    Exit Select
            End Select
        End If
    End Sub


    Private Sub RibBtnGroups_Click(sender As Object, e As EventArgs) Handles RibBtnGroups.Click
        Dim FrmGroups As New Groups()
        FrmGroups.ShowDialog(Me)
    End Sub


    Private Sub RibBtnEdit_Click(sender As Object, e As EventArgs) Handles RibBtnEdit.Click
        If Me.WindowDock.DockWindows.Count > 0 Then
            Select Case Me.WindowDock.ActiveWindow.Tag
                Case "Items"
                    Frmitems.BtnEdit.PerformClick()
                    Exit Select
                Case "Customers"
                    FrmCustomers.BtnEdit.PerformClick()
                    Exit Select
                Case "Vendors"
                    FrmVendors.BtnEdit.PerformClick()
                    Exit Select
                Case "SalesOrders"
                    FrmSalesOrders.BtnEdit.PerformClick()
                    Exit Select
                Case "PurchasesOrders"
                    FrmPurchasesOrders.BtnEdit.PerformClick()
                    Exit Select
                Case "Daily"
                    FrmDaily.BtnOpen.PerformClick()
                    Exit Select
            End Select
        End If
    End Sub

    Private Sub RadButtonElement2_Click(sender As Object, e As EventArgs)

        Dim param(0) As String
        param(0) = "@lang , " & IIf(BoolLTRLanguage = True, "Ar", "En")
        ExecuteProcedureWithParameters("UpdateLanguage", param)
        BoolLTRLanguage = Not BoolLTRLanguage
    End Sub

    Private Sub RibBtnAddItem_Click(sender As Object, e As EventArgs) Handles RibBtnAddItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim FrmAddNewITem As New AddNewItem
        FrmAddNewITem.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibBtnItemsTree_Click(sender As Object, e As EventArgs) Handles RibBtnItemsTree.Click
        Me.Cursor = Cursors.WaitCursor
        Dim FrmItemsTree As New ItemTree
        FrmItemsTree.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibBtnAddSalesInvoices_Click(sender As Object, e As EventArgs) Handles RibBtnAddSalesInvoices.Click
        Me.Cursor = Cursors.WaitCursor
        If BoolShowSOAsWindow Then
            FrmToOpen = "AddNewSaleInvoice"
            FrmOpenTimer.Start()
        Else
            Dim FrmAddNewSalesInvoice As New AddNewSaleInvoice
            FrmAddNewSalesInvoice.ShowDialog()
        End If


        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageShowAsk(Con.Ask_Do_You_Want_Exit) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub RibBtnAddPurchaseInvoices_Click(sender As Object, e As EventArgs) Handles RibBtnAddPurchaseInvoices.Click
        Me.Cursor = Cursors.WaitCursor
        Dim FrmAddNewPurchaseInvoices As New AddNewPurchaseInvoice
        FrmAddNewPurchaseInvoices.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibBtnNotesPay_Click(sender As Object, e As EventArgs) Handles RibBtnNotesPay.Click
        Me.Cursor = Cursors.WaitCursor
        Dim FrmNotesPay As New NotesPayable
        FrmNotesPay.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibBtnNotesReceive_Click(sender As Object, e As EventArgs) Handles RibBtnNotesReceive.Click
        Me.Cursor = Cursors.WaitCursor
        Dim FrmNotesReceive As New NoteReceive
        FrmNotesReceive.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibBtnDaily_Click(sender As Object, e As EventArgs) Handles RibBtnDaily.Click

        FrmToOpen = "Daily"
        FrmOpenTimer.Start()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SubscribeShortcuts()
        Me.stripLblDollarRateValue.Text = LastDollarCurrencyRate
        If BoolShowDailyPageWhenOpen Then
            FrmToOpen = "Daily"
            FrmOpenTimer.Start()
        End If
    End Sub
    Private Sub RibBtnHomeForm_Click(sender As Object, e As EventArgs) Handles RibBtnHomeForm.Click
        FrmToOpen = "HomeForm"
        FrmOpenTimer.Start()
    End Sub
    Private Sub RibBtnUserSettings_Click(sender As Object, e As EventArgs) Handles RibBtnUserSettings.Click
        Dim FrmUserSettings As New UserSettings
        FrmUserSettings.ShowDialog()
        Home.GetUserSettings()
    End Sub

    Private Sub RibBtnCurrencies_Click(sender As Object, e As EventArgs) Handles RibBtnCurrencies.Click
        Dim FrmCurrencies As New FrmCurrency
        FrmCurrencies.ShowDialog()
    End Sub

    Private Sub RibBtnExit_Click(sender As Object, e As EventArgs) Handles RibBtnExit.Click
        Me.Close()
    End Sub


    Private Sub RibBtnCurrRate_Click(sender As Object, e As EventArgs) Handles RibBtnCurrRate.Click
        Dim FrmAddCurrRate As New CurrencyRate
        FrmAddCurrRate.ShowDialog()
        Home.ReloadCurrency()
        Me.stripLblDollarRateValue.Text = LastDollarCurrencyRate
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub RibBtnAddAccount_Click(sender As Object, e As EventArgs) Handles RibBtnAddAccount.Click
        Dim FrmAddAccount As New AddGeneralAccounts
        FrmAddAccount.ShowDialog()
    End Sub

    Private Sub RibBtnAccounts_Click(sender As Object, e As EventArgs) Handles RibBtnAccounts.Click
        Dim FrmAccounts As New Accounts
        FrmAccounts.ShowDialog()
    End Sub

    Private Sub RibBtnAccountReport_Click(sender As Object, e As EventArgs) Handles RibBtnAccountReport.Click
        Dim FrmAccountDetails As New AccountsDetails
        FrmAccountDetails.ShowDialog()
    End Sub

    Private Sub RibBtnChangePass_Click(sender As Object, e As EventArgs) Handles RibBtnChangePass.Click
        Dim FrmChangePassword As New ChangePassword
        FrmChangePassword.ShowDialog()
    End Sub
    Private Sub RibBtnOpenningBalance_Click(sender As Object, e As EventArgs) Handles RibBtnOpenningBalance.Click
        Dim FrmOP As New OpeningBalance
        FrmOP.ShowDialog()
    End Sub

    Private Sub RibBtnItemMostSell_Click(sender As Object, e As EventArgs) Handles RibBtnItemMostSell.Click
        Me.Cursor = Cursors.WaitCursor
        Dim FrmMostSell As New ItemsSell
        FrmMostSell.WhatType = "Sales"
        FrmMostSell.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibBtnItemPurchase_Click(sender As Object, e As EventArgs) Handles RibBtnItemPurchase.Click
        Me.Cursor = Cursors.WaitCursor
        Dim FrmMostSell As New ItemsSell
        FrmMostSell.WhatType = "Purchases"
        FrmMostSell.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibBtnPurchasePrices_Click(sender As Object, e As EventArgs) Handles RibBtnPurchasePrices.Click
        Me.Cursor = Cursors.WaitCursor
        Dim FrmPurchasePrices As New PricesReport
        FrmPurchasePrices.WhatType = "Purchases"
        FrmPurchasePrices.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibBtnSalesPrices_Click(sender As Object, e As EventArgs) Handles RibBtnSalesPrices.Click
        Me.Cursor = Cursors.WaitCursor
        Dim FrmSalesPrices As New PricesReport
        FrmSalesPrices.WhatType = "Sales"
        FrmSalesPrices.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibBtnQuantity_Click(sender As Object, e As EventArgs) Handles RibBtnQuantity.Click
        Me.Cursor = Cursors.WaitCursor
        Dim FrmQuantityHistory As New QuantityHistory
        FrmQuantityHistory.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RibBtnUsers_Click(sender As Object, e As EventArgs) Handles RibBtnUsers.Click
        Dim FrmUsers As New AddUsers
        FrmUsers.ShowDialog()
    End Sub

    Private Sub RibBtnUserInfo_Click(sender As Object, e As EventArgs) Handles RibBtnUserInfo.Click
        Dim FrmCompanyinfo As New CompanyInfo
        FrmCompanyinfo.ShowDialog()
    End Sub

    Private Sub RibBtnAbout_Click(sender As Object, e As EventArgs) Handles RibBtnAbout.Click
        Dim FrmAbout As New ProgAbout
        FrmAbout.ShowDialog()
    End Sub

    Private Sub RibBtnItemsInventory_Click(sender As Object, e As EventArgs) Handles RibBtnItemsInventory.Click
        Dim FrmItemsInventory As New Inventory
        FrmItemsInventory.ShowDialog()
    End Sub

    Private Sub RibBtnInventoryItems_Click(sender As Object, e As EventArgs) Handles RibBtnInventoryItems.Click
        Dim FrmInventoryItems As New InventoryItems
        FrmInventoryItems.ShowDialog()
    End Sub

    Private Sub RibBtnRptCheques_Click(sender As Object, e As EventArgs) Handles RibBtnRptCheques.Click
        Dim FrmCheques As New ChequesRpt
        FrmCheques.ShowDialog()
    End Sub

    Private Sub RibBtnSalesWin_Click(sender As Object, e As EventArgs) Handles RibBtnSalesWin.Click
        FrmToOpen = "SalesDailyWin"
        FrmOpenTimer.Start()
    End Sub

    Private Sub RibBtnItemsSalesWin_Click(sender As Object, e As EventArgs) Handles RibBtnItemsSalesWin.Click
        FrmToOpen = "RPTItemsSalesWin"
        FrmOpenTimer.Start()
    End Sub

    Private Sub RibButtonDashboard_Click(sender As Object, e As EventArgs) Handles RibButtonDashboard.Click
        FrmToOpen = "FrmDashboard"
        FrmOpenTimer.Start()
    End Sub

    'Private Sub RibBtnDashboard_Click(sender As Object, e As EventArgs)
    '    FrmToOpen = "FrmDashboard"
    '    FrmOpenTimer.Start()
    'End Sub

End Class
Public Class MyDragDropService
    Inherits DragDropService
    Public ShouldShowGuides As Boolean = False
    Protected Overrides Sub Drag(mousePos As Point)
        If (ShouldShowGuides) Then
            MyBase.Drag(mousePos)
        Else
        End If
    End Sub
End Class

Public Class MyContextMenuService
    Inherits ContextMenuService
    Protected Overrides Sub DisplayMenuCore(menuOwner As RadElement, items As List(Of RadMenuItemBase), screenPos As Point)
        For Each Mn In items
            If Mn.Text = "HiddenMenu" Or Mn.Text = "New Vertical Tab Group" Or Mn.Text = "New Horizontal Tab Group" Or Mn.Text = "" Then
                Mn.Visibility = ElementVisibility.Collapsed
            Else
                Mn.Font = MenuFont
            End If
        Next
        MyBase.DisplayMenuCore(menuOwner, items, screenPos)
    End Sub
End Class
