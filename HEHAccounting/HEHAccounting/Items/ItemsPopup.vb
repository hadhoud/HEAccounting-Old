Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.VirtualKeyboard

Public Class ItemsPopup

    Public GetITemName As String = ""
    Public NoBarcodeItems As Boolean = False

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        ShowPermissions()
        RefrechGrid()
        InitiateGrid(Me.GridItems)

    End Sub

    Sub New(NoBarcode As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        ShowPermissions()
        NoBarcodeItems = NoBarcode
        RefrechGrid()
        InitiateGrid(Me.GridItems)

    End Sub

    Sub ShowPermissions()
        Me.LblBarcode.Visible = BoolShowBarcode
        Me.TxtBarcode.Visible = BoolShowBarcode
    End Sub

    Public Sub RefrechGrid()
        Dim Param(0) As String
        Param(0) = "@BNoBarcodeItems  , " & NoBarcodeItems
        FillGridViewProcedureWithParameters(Me.GridItems, "SelectItems", Param)

        HideShowColummn(Me.GridItems, Me.GridItems.Columns("Qty").Index, False)
        HideShowColummn(Me.GridItems, Me.GridItems.Columns("Barcode").Index, BoolShowBarcode)
        HideShowColummn(Me.GridItems, Me.GridItems.Columns("MinQty").Index, False)
        HideShowColummn(Me.GridItems, Me.GridItems.Columns("PurchasingPrice").Index, False)
        HideShowColummn(Me.GridItems, Me.GridItems.Columns("SellingPrice").Index, False)
    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Me.GridItems.FilterDescriptors.Clear()
        FilterGrid(Me.GridItems, "Item_id", Me.TxtItemID.Text, FilterOperator.Contains)
        FilterGrid(Me.GridItems, "Barcode", Me.TxtBarcode.Text, FilterOperator.Contains)
        FilterGrid(Me.GridItems, "Item_name", Me.TxtItemName.Text, FilterOperator.Contains)
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.LblBarcode.Text = LoStrId.LblBarcode
        Me.LblItemName.Text = LoStrId.LblItemName
        Me.BtnSearch.Text = LoStrId.LblFiltering
        Me.LblItemID.Text = LoStrId.LblItemID
        Me.BtnAdd.Text = LoStrId.LblAdd
        Me.Text = LoStrId.LblItems
    End Sub

    Private Sub GridItems_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles GridItems.CellDoubleClick
        If Me.GridItems.ChildRows.Count <> 0 And TryCast(sender, GridDataCellElement) IsNot Nothing Then
            GetITemName = Me.GridItems.CurrentRow.Cells("Item_name").Value.ToString
            Me.Close()
        End If
    End Sub

    Private Sub TxtItemName_TextChanged(sender As Object, e As EventArgs) Handles TxtItemName.TextChanged
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim FrmAddNewItem As New AddNewItem
        FrmAddNewItem.ShowDialog()
        RefrechGrid()
    End Sub

    Private Sub ItemsPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ClearButton As New Button
        Me.CancelButton = ClearButton
        AddHandler ClearButton.Click, AddressOf FormClear
    End Sub
    Private Sub FormClear()
        Me.TxtBarcode.Clear()
        Me.TxtItemID.Clear()
        Me.TxtItemName.Clear()
        BtnSearch_Click(New Object, New EventArgs)
    End Sub

    Private Sub TxtItemID_TextChanged(sender As Object, e As EventArgs) Handles TxtItemID.TextChanged
        BtnSearch_Click(sender, e)
    End Sub
End Class
