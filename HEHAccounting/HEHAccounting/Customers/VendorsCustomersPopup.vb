Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class VendorsCustomersPopup

    Public GetVendorCustomerName As String = ""

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        InitiateGrid(Me.GridVendorsCustomers)
    End Sub
    Private Sub GridCustomers_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles GridVendorsCustomers.CellDoubleClick
        If Me.GridVendorsCustomers.ChildRows.Count <> 0 And TryCast(sender, GridDataCellElement) IsNot Nothing Then
            GetVendorCustomerName = Me.GridVendorsCustomers.CurrentRow.Cells("Name").Value.ToString _
                            & "/" & Me.GridVendorsCustomers.CurrentRow.Cells("Title").Value.ToString _
                            & "/" & Me.GridVendorsCustomers.CurrentRow.Cells("ID").Value.ToString _
                             & "/" & Me.GridVendorsCustomers.CurrentRow.Cells("Type").Value.ToString
            Me.Close()
        End If
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.LblCustomerID.Text = LoStrId.LblCode
        Me.LblCustomerName.Text = LoStrId.LblName
        Me.BtnSearch.Text = LoStrId.LblFiltering
        Me.LblTitle.Text = LoStrId.LblTitle
        Me.BtnAdd.Text = LoStrId.LblAdd
        Me.LblTitle.Text = LoStrId.LblTitle
        Me.Text = LoStrId.lblCustomers
    End Sub

    Public Sub RefrechGrid()
        FillGridViewProcedure(Me.GridVendorsCustomers, "SelectVendorsCustomers")
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Me.GridVendorsCustomers.FilterDescriptors.Clear()
        If Me.TxtVendorCustomerCode.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridVendorsCustomers, "ID", Me.TxtVendorCustomerCode.Text, FilterOperator.Contains)
        End If
        If Me.TxtVendorCustomerName.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridVendorsCustomers, "Name", Me.TxtVendorCustomerName.Text, FilterOperator.Contains)
        End If
        If Me.TxtVendorCustomerTitle.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridVendorsCustomers, "Title", Me.TxtVendorCustomerTitle.Text, FilterOperator.Contains)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

    End Sub

    Private Sub TxtVendorCustomerName_TextChanged(sender As Object, e As EventArgs) Handles TxtVendorCustomerName.TextChanged
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub TxtVendorCustomerTitle_TextChanged(sender As Object, e As EventArgs) Handles TxtVendorCustomerTitle.TextChanged
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub TxtVendorCustomerCode_TextChanged(sender As Object, e As EventArgs) Handles TxtVendorCustomerCode.TextChanged
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub VendorsCustomersPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ClearButton As New Button
        Me.CancelButton = ClearButton
        AddHandler ClearButton.Click, AddressOf FormClear
    End Sub
    Private Sub FormClear()
        Me.TxtVendorCustomerCode.Clear()
        Me.TxtVendorCustomerName.Clear()
        Me.TxtVendorCustomerTitle.Clear()
        BtnSearch.PerformClick()
    End Sub
End Class
