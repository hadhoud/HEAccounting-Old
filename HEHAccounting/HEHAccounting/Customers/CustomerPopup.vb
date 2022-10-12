Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class CustomerPopup

    Public GetCustomerName As String = ""

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        InitiateGrid(Me.GridCustomers)
    End Sub
    Private Sub GridCustomers_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles GridCustomers.CellDoubleClick
        If Me.GridCustomers.ChildRows.Count <> 0 And TryCast(sender, GridDataCellElement) IsNot Nothing Then
            GetCustomerName = Me.GridCustomers.CurrentRow.Cells("CustomerName").Value.ToString _
                            & "/" & Me.GridCustomers.CurrentRow.Cells("CustomerTitle").Value.ToString _
                            & "/" & Me.GridCustomers.CurrentRow.Cells("CustomerID").Value.ToString
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
        FillGridViewProcedure(Me.GridCustomers, "SelectCustomers")
        HideShowColummn(Me.GridCustomers, Me.GridCustomers.Columns("CustomerAddress").Index, False)
        HideShowColummn(Me.GridCustomers, Me.GridCustomers.Columns("CustomerTown").Index, False)
        HideShowColummn(Me.GridCustomers, Me.GridCustomers.Columns("CreatedDate").Index, False)
        HideShowColummn(Me.GridCustomers, Me.GridCustomers.Columns("ModifiedDate").Index, False)
        HideShowColummn(Me.GridCustomers, Me.GridCustomers.Columns("CellPhone").Index, False)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Me.GridCustomers.FilterDescriptors.Clear()
        If Me.TxtCustomerCode.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridCustomers, "CustomerID", Me.TxtCustomerCode.Text, FilterOperator.Contains)
        End If
        If Me.TxtCustomerName.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridCustomers, "CustomerName", Me.TxtCustomerName.Text, FilterOperator.Contains)
        End If
        If Me.TxtTitle.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridCustomers, "CustomerTitle", Me.TxtTitle.Text, FilterOperator.Contains)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim FrmAddNewCustomer As New AddNewCustomer
        FrmAddNewCustomer.ShowDialog()
        RefrechGrid()
    End Sub

    Private Sub TxtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles TxtCustomerName.TextChanged
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub TxtTitle_TextChanged(sender As Object, e As EventArgs) Handles TxtTitle.TextChanged
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub TxtCustomerCode_TextChanged(sender As Object, e As EventArgs) Handles TxtCustomerCode.TextChanged
        BtnSearch_Click(sender, e)
    End Sub

    Private Sub CustomerPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ClearButton As New Button
        Me.CancelButton = ClearButton
        AddHandler ClearButton.Click, AddressOf FormClear
    End Sub
    Private Sub FormClear()
        Me.TxtCustomerCode.Clear()
        Me.TxtCustomerName.Clear()
        Me.TxtTitle.Clear()
        BtnSearch.PerformClick()
    End Sub
End Class
