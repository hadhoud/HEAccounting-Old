
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class CashDrawers

    Public GetGroupName As String = ""
    Dim GetGroupID As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        InitiateGrid(Me.GridCashDrawers)
        EventHandlers()
        ' Me.GridGroups.ShowFilteringRow = True
        ' Me.GridGroups.EnableFiltering = True
    End Sub

    Private Sub EventHandlers()
        AddHandler ConMnuEdit.Click, AddressOf GridEdit
    End Sub

    Private Sub GridEdit()
        Dim FrmEditDrawer As New AddCashDrawer
        FrmEditDrawer.Row = Me.GridCashDrawers.CurrentRow
        FrmEditDrawer.BoolForEdit = True
        FrmEditDrawer.ShowDialog()
        RefrechGrid()
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.LblDrawerName.Text = LoStrId.LblGroupName
        Me.LblDrawerDesc.Text = LoStrId.LblNote
        Me.BtnSearch.Text = LoStrId.LblFiltering
        Me.BtnAdd.Text = LoStrId.LblAdd
        Me.Text = LoStrId.LblGroups
        Me.ConMnuEdit.Text = LoStrId.LblEdit
    End Sub


    Public Sub RefrechGrid()
        FillGridViewProcedure(Me.GridCashDrawers, "SelectCashDrawers")

        'Always hidden
        HideShowColummn(Me.GridCashDrawers, Me.GridCashDrawers.Columns("CurrencyID").Index, False)
    End Sub


    Private Sub Drawers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormClear()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Frm_AddDrawer As New AddCashDrawer
        Frm_AddDrawer.ShowDialog()
        RefrechGrid()
    End Sub

    Sub FormClear()
        Me.TxtDrawerDesc.Clear()
        Me.TxtDrawerName.Clear()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Me.GridCashDrawers.FilterDescriptors.Clear()
        If Me.TxtDrawerName.Text.Trim <> "" Then
            FilterGrid(Me.GridCashDrawers, "DrawerName", Me.TxtDrawerName.Text, FilterOperator.Contains)
        End If
        If Me.TxtDrawerDesc.Text.Trim <> "" Then
            FilterGrid(Me.GridCashDrawers, "DrawerDescription", Me.TxtDrawerDesc.Text, FilterOperator.Contains)
        End If


    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        FormClear()
    End Sub
End Class
