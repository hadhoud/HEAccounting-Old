Imports System.ComponentModel
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI


Partial Friend Class Items
    Inherits Telerik.WinControls.UI.RadForm

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        SubscribeEvents()
        ShowPermissions()
        RefrechGrid()
        InitiateGrid(Me.GridItems, Grouping:=True)
    End Sub

    Sub ShowPermissions()
        Me.LblBarCode.Visible = BoolShowBarcode
        Me.TxtItemBarcode.Visible = BoolShowBarcode
        Dim ItemsRow As DataRow = UserRolesdt.Select("KeyName = 'ITS'").First
        Me.BtnNew.Enabled = ItemsRow("AllowAdd").ToString
        Me.BtnEdit.Enabled = ItemsRow("AllowEdit").ToString
        Me.BtnDelete.Enabled = ItemsRow("AllowDelete").ToString
        '  Me.BtnNew.Enabled = (UserType = UserRole.Programmer Or ItemsRow("AllowDelete").ToString)
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        Me.BtnFiltering.Text = LoStrId.LblFiltering
        Me.BtnEdit.Text = LoStrId.LblEdit
        Me.BtnNew.Text = LoStrId.LblNew
        Me.BtnReset.Text = LoStrId.LblReset
        Me.BtnRefrech.Text = LoStrId.LblRefrech
        Me.BtnDelete.Text = LoStrId.LblDelete
        Me.LblItemId.Text = LoStrId.LblItemID
        Me.LblItemName.Text = LoStrId.LblItemName
        Me.LblBarCode.Text = LoStrId.LblBarcode
        '  Me.LblItemId.TextAlignment = ContentAlignment.MiddleLeft
        'Me.LblItemName.TextAlignment = ContentAlignment.MiddleLeft
        ' Me.LblBarCode.TextAlignment = ContentAlignment.MiddleLeft
        Me.Text = LoStrId.LblItems
    End Sub

    Public Sub RefrechGrid()
        FillGridViewProcedure(Me.GridItems, "SelectItems")
        HideShowColummn(Me.GridItems, 1, BoolShowBarcode)
        HideShowColummn(Me.GridItems, Me.GridItems.Columns("PurchasingPrice").Index, BoolShowPurchasingPriceInScreensByUser)
    End Sub
    'Protected Overrides Sub OnLoad(e As EventArgs)
    '    If Not ProgramHasError Then
    '        MyBase.OnLoad(e)
    '    Else
    '        Me.BeginInvoke(New MethodInvoker(AddressOf CloseMe))
    '    End If
    'End Sub
    'Sub CloseME()
    '    Me.Close
    'End Sub
    Sub SubscribeEvents()
        AddHandler BtnNew.Click, AddressOf BtnNew_Click
        AddHandler BtnReset.Click, AddressOf BtnReset_Click
        AddHandler BtnRefrech.Click, AddressOf RefrechGrid
        AddHandler BtnFiltering.Click, AddressOf BtnFiltering_Click
        AddHandler BtnEdit.Click, AddressOf Edit
        AddHandler BtnDelete.Click, AddressOf DeleteItem

        AddHandler GridItems.ContextMenuOpening, AddressOf GridItems_ContextMenuOpening
    End Sub
    Private Sub BtnNew_Click(sender As Object, e As EventArgs)
        Dim FrmAddNewItem As New AddNewItem
        FrmAddNewItem.ShowDialog()
        If ToDoRefrech Then
            RefrechGrid()
            ToDoRefrech = False
        End If
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        Me.GridItems.FilterDescriptors.Clear()
        FilterGrid(Me.GridItems, "Item_name", Me.TxtItemName.Text.Trim, FilterOperator.Contains)
        FilterGrid(Me.GridItems, "Item_id", Me.TxtItemid.Text.Trim, FilterOperator.Contains)
        FilterGrid(Me.GridItems, "Barcode", Me.TxtItemBarcode.Text.Trim, FilterOperator.Contains)
        Me.TxtItemBarcode.Text = ""

        Dim tableElement As GridTableElement = Me.GridItems.CurrentView
        Dim row As GridViewRowInfo = Me.GridItems.CurrentRow

        If tableElement Is Nothing And row Is Nothing Then

        Else

            tableElement.ScrollToRow(row)
        End If
        'If Me.GridItems.Rows.Count = 0 Then
        '    Me.GridItems.ShowNoDataText = True
        'End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs)
        Me.GridItems.FilterDescriptors.Clear()
        Me.TxtItemBarcode.Clear()
        Me.TxtItemid.Clear()
        Me.TxtItemName.Clear()
        Me.TxtItemBarcode.Focus()
    End Sub

    Private Sub Edit()
        If Me.GridItems.ChildRows.Count > 0 Then
            Dim FrmAddNewItem As New AddNewItem
            Dim dt As New DataTable
            Dim Param(0) As String
            Param(0) = "@IITemID , " & Me.GridItems.CurrentRow.Cells(0).Value.ToString
            dt.BeginLoadData()
            dt = ExecuteProcedureDatatableWithParameters("SelectItemsByID", Param)
            dt.EndLoadData()
            FrmAddNewItem.ShowForEdit(dt)
            FrmAddNewItem.BoolForEdit = True
            FrmAddNewItem.ShowDialog()
            If ToDoRefrech Then
                RefrechGrid()
                ToDoRefrech = False
            End If
        End If
    End Sub

    Private Sub DeleteItem()
        If Me.GridItems.ChildRows.Count > 0 Then
            If MessageShowAsk(Con.Ask_Delete) = DialogResult.Yes Then
                Dim Param(0) As String
                Param(0) = "@iItemID , " & Me.GridItems.CurrentRow.Cells(0).Value.ToString
                ExecuteProcedureWithParameters("DeleteItemByID", Param)
                RefrechGrid()
            End If
        End If
    End Sub

    Private Sub GridItems_ContextMenuOpening(sender As Object, e As ContextMenuOpeningEventArgs)
        Dim i As Integer = 0
        Do While i < e.ContextMenu.Items.Count
            If e.ContextMenu.Items(i).Text = "Copy" Then
                e.ContextMenu.Items(i).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            End If
            e.ContextMenu.Items(i).Font = MenuFont
            i += 1
        Loop
        If e.ContextMenu.Items.Count = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub TxtItemName_TextChanged(sender As Object, e As EventArgs) Handles TxtItemName.TextChanged
        BtnFiltering_Click(sender, e)
    End Sub

    Private Sub TxtItemBarcode_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtItemBarcode_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtItemBarcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            BtnFiltering_Click(sender, e)
            Me.TxtItemBarcode.Focus()
        End If
    End Sub

    'Private Sub SetupAutoComplete(ByVal radAutoCompleteBox As RadAutoCompleteBox)
    '    AddHandler radAutoCompleteBox.Items.CollectionChanged, AddressOf OnItemsCollectionChanged
    '    radAutoCompleteBox.AutoCompleteDisplayMember = "Name"
    '    radAutoCompleteBox.AutoCompleteValueMember = "Email"
    '    AddHandler radAutoCompleteBox.ListElement.VisualItemFormatting, AddressOf OnListElementVisualItemFormatting
    '    radAutoCompleteBox.AutoCompleteDataSource = New BindingSource(Me.GetAutoCompleteDataSource(), String.Empty)
    '    radAutoCompleteBox.DropDownMaxSize = New Size(200, 0)
    '    Me.FillList(radAutoCompleteBox.Items)
    'End Sub

End Class
