Imports Telerik.WinControls.Data

Public Class Vendors

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        InitiateGrid(Me.GridVendors, Grouping:=True)
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
        Me.LblVendorName.Text = LoStrId.LblName
        Me.LblLatinName.Text = LoStrId.LblLatinName
        Me.LblVendorCode.Text = LoStrId.LblCode
        Me.LblCompany.Text = LoStrId.LblCompany
        'Me.LblCustomerName.TextAlignment = ContentAlignment.MiddleLeft
        ' Me.LblLatinName.TextAlignment = ContentAlignment.MiddleLeft
        'Me.LblCustomerCode.TextAlignment = ContentAlignment.MiddleLeft
        Me.Text = LoStrId.lblVendors
    End Sub

    Public Sub RefrechGrid()
        FillGridViewProcedure(Me.GridVendors, "SelectVendors")
        '     HideShowColummn(Me.GridCustomers, 1, False)
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Dim FrmAddNewVendor As New AddNewVendor
        FrmAddNewVendor.ShowDialog()
        If ToDoRefrech Then
            RefrechGrid()
            ToDoRefrech = False
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Me.GridVendors.ChildRows.Count > 0 Then
            Dim FrmAddNewVendor As New AddNewVendor
            Dim dt As New DataTable
            Dim Param(0) As String
            Param(0) = "@IVendorID , " & Me.GridVendors.CurrentRow.Cells(0).Value.ToString
            dt.BeginLoadData()
            dt = ExecuteProcedureDatatableWithParameters("SelectVendorByID", Param)
            dt.EndLoadData()
            FrmAddNewVendor.ShowForEdit(dt)
            FrmAddNewVendor.BoolForEdit = True
            FrmAddNewVendor.ShowDialog()
            If ToDoRefrech Then
                RefrechGrid()
                ToDoRefrech = False
            End If
        End If
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechGrid()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        Me.GridVendors.FilterDescriptors.Clear()
        FilterGrid(Me.GridVendors, "VendorID", Me.TxtVendorCode.Text, FilterOperator.Contains)
        FilterGrid(Me.GridVendors, "VendorName", Me.TxtVendorName.Text, FilterOperator.Contains)
        FilterGrid(Me.GridVendors, "VendorLatinName", Me.TxtLatinName.Text, FilterOperator.Contains)
        FilterGrid(Me.GridVendors, "VendorCompany", Me.TxtCompany.Text, FilterOperator.Contains)
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.TxtVendorCode.Clear()
        Me.TxtVendorName.Clear()
        Me.TxtLatinName.Clear()
        Me.TxtCompany.Clear()
        Me.GridVendors.FilterDescriptors.Clear()
        Me.TxtVendorCode.Focus()
    End Sub

End Class
