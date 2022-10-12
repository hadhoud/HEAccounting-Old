Imports Telerik.WinControls.Data

Public Class Customers

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        InitiateGrid(Me.GridCustomers, Grouping:=True)
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
        Me.LblCustomerName.Text = LoStrId.LblName
        Me.LblLatinName.Text = LoStrId.LblLatinName
        Me.LblCustomerCode.Text = LoStrId.LblCode
        'Me.LblCustomerName.TextAlignment = ContentAlignment.MiddleLeft
        ' Me.LblLatinName.TextAlignment = ContentAlignment.MiddleLeft
        'Me.LblCustomerCode.TextAlignment = ContentAlignment.MiddleLeft
        Me.Text = LoStrId.lblCustomers
    End Sub

    Public Sub RefrechGrid()
        FillGridViewProcedure(Me.GridCustomers, "SelectCustomers")
        '     HideShowColummn(Me.GridCustomers, 1, False)
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechGrid()
    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Dim FrmAddNewCustomer As New AddNewCustomer
        FrmAddNewCustomer.ShowDialog()
        If ToDoRefrech Then
            RefrechGrid()
            ToDoRefrech = False
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Me.GridCustomers.ChildRows.Count > 0 Then
            Dim FrmAddNewCustomer As New AddNewCustomer
            Dim dt As New DataTable
            Dim Param(0) As String
            Param(0) = "@ICustomerID , " & Me.GridCustomers.CurrentRow.Cells(0).Value.ToString
            dt.BeginLoadData()
            dt = ExecuteProcedureDatatableWithParameters("SelectCustomerByID", Param)
            dt.EndLoadData()
            FrmAddNewCustomer.ShowForEdit(dt)
            FrmAddNewCustomer.BoolForEdit = True
            FrmAddNewCustomer.ShowDialog()
            If ToDoRefrech Then
                RefrechGrid()
                ToDoRefrech = False
            End If
        End If
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        Me.GridCustomers.FilterDescriptors.Clear()
        FilterGrid(Me.GridCustomers, "CustomerName", Me.TxtCustomerName.Text, FilterOperator.Contains)
        FilterGrid(Me.GridCustomers, "CustomerID", Me.TxtCustomerCode.Text, FilterOperator.Contains)
        FilterGrid(Me.GridCustomers, "CustomerLatinName", Me.TxtLatinName.Text, FilterOperator.Contains)
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Me.TxtCustomerCode.Clear()
        Me.TxtCustomerName.Clear()
        Me.TxtLatinName.Clear()
        Me.GridCustomers.FilterDescriptors.Clear()
        Me.TxtCustomerCode.Focus()
    End Sub
End Class
