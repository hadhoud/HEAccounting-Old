Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class VendorsPopup

    Public GetVendorName As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        InitiateGrid(Me.GridVendors, Bestfit:=True)
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddNewVendor.ShowDialog()
        RefrechGrid()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Me.GridVendors.FilterDescriptors.Clear()
        If Me.TxtCode.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridVendors, "VendorID", Me.TxtCode.Text, FilterOperator.Contains)
        End If
        If Me.TxtName.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridVendors, "VendorName", Me.TxtName.Text, FilterOperator.Contains)
        End If
        If Me.TxtTitle.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridVendors, "VendorTitle", Me.TxtTitle.Text, FilterOperator.Contains)
        End If

    End Sub

    Private Sub VendorsPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ClearButton As New Button
        Me.CancelButton = ClearButton
        AddHandler ClearButton.Click, AddressOf FormClear
    End Sub

    Private Sub FormClear()
        Me.TxtTitle.Clear()
        Me.TxtName.Clear()
        Me.TxtCode.Clear()
        BtnSearch.PerformClick()
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.LblCode.Text = LoStrId.LblCode
        Me.LblName.Text = LoStrId.LblName
        Me.BtnSearch.Text = LoStrId.LblFiltering
        Me.LblTitle.Text = LoStrId.LblTitle
        Me.BtnAdd.Text = LoStrId.LblAdd
        Me.Text = LoStrId.lblVendors
    End Sub
    Public Sub RefrechGrid()
        FillGridViewProcedure(Me.GridVendors, "SelectVendors")
        HideShowColummn(Me.GridVendors, Me.GridVendors.Columns("VendorAddress").Index, False)
        '  HideShowColummn(Me.GridVendors, Me.GridVendors.Columns("VendorTown").Index, False)
        HideShowColummn(Me.GridVendors, Me.GridVendors.Columns("CreatedDate").Index, False)
        HideShowColummn(Me.GridVendors, Me.GridVendors.Columns("ModifiedDate").Index, False)
        HideShowColummn(Me.GridVendors, Me.GridVendors.Columns("CellPhone").Index, False)
    End Sub

    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub TxtTitle_TextChanged(sender As Object, e As EventArgs) Handles TxtTitle.TextChanged
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub TxtCode_TextChanged(sender As Object, e As EventArgs) Handles TxtCode.TextChanged
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub GridVendors_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles GridVendors.CellDoubleClick
        If Me.GridVendors.ChildRows.Count <> 0 And TryCast(sender, GridDataCellElement) IsNot Nothing Then
            GetVendorName = Me.GridVendors.CurrentRow.Cells("VendorName").Value.ToString _
                            & "/" & Me.GridVendors.CurrentRow.Cells("VendorTitle").Value.ToString _
                            & "/" & Me.GridVendors.CurrentRow.Cells("VendorID").Value.ToString

            Me.Close()
        End If
    End Sub
End Class
