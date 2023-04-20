Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class Accounts
    Public GetAccountPopup As Boolean = False
    Public GetAccountNum As String = ""
    Public GetAccountName As String = ""
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()

    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.BtnAdd.Text = LoStrId.LblAdd
        Me.BtnClose.Text = LoStrId.LblClose
        Me.Text = LoStrId.LblCurrencies
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim FrmAddAccounts As New AddGeneralAccounts
        FrmAddAccounts.ShowDialog()
        RefrechGrid()
    End Sub

    Public Sub RefrechGrid()
        Me.GridAccounts.DataSource = Nothing
        If Me.BtnAccWithBalance.IsChecked = True Then
            Dim Param(1) As String
            Param(0) = "@IAllAccounts , 0"
            Param(1) = "@ICurrencyID , " & ProgramFormCurrency
            FillGridViewProcedureWithParameters(Me.GridAccounts, "SelectAccounts", Param)
            HideShowColummn(Me.GridAccounts, Me.GridAccounts.Columns("Balance").Index, False)
        Else
            Dim Param(1) As String
            Param(0) = "@IAllAccounts , 1"
            Param(1) = "@ICurrencyID , " & ProgramFormCurrency
            FillGridViewProcedureWithParameters(Me.GridAccounts, "SelectAccounts", Param)
        End If
        InitiateGrid(Me.GridAccounts)
        HideShowColummn(Me.GridAccounts, Me.GridAccounts.Columns("AccountLatinName").Index, False)
        HideShowColummn(Me.GridAccounts, Me.GridAccounts.Columns("AccountType").Index, False)
        Search()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Me.GridAccounts.Rows.Count > 0 Then
            If Me.GridAccounts.CurrentRow.Cells("AccountType").Value.ToString <> "CUST" And
                    Me.GridAccounts.CurrentRow.Cells("AccountType").Value.ToString <> "VEN" Then
                Dim FrmAddAccounts As New AddGeneralAccounts
                FrmAddAccounts.BoolForEdit = True
                FrmAddAccounts.Row = Me.GridAccounts.CurrentRow
                FrmAddAccounts.ShowDialog()
                RefrechGrid()
            ElseIf Me.GridAccounts.CurrentRow.Cells("AccountType").Value.ToString = "CUST" Then
                MessageShowInfo(Con.Msg_Cust_Updated_From_Customer_Form)
            ElseIf Me.GridAccounts.CurrentRow.Cells("AccountType").Value.ToString = "VEN" Then
                MessageShowInfo(Con.Msg_Ven_Updated_From_Vendor_Form)
            End If
        End If
    End Sub

    Private Sub BtnAccWithBalance_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles BtnAccWithBalance.ToggleStateChanged
        RefrechGrid()

    End Sub

    Private Sub GridAccounts_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles GridAccounts.CellDoubleClick
        If GetAccountPopup Then
            If Me.GridAccounts.ChildRows.Count <> 0 And TryCast(sender, GridDataCellElement) IsNot Nothing Then
                GetAccountNum = Me.GridAccounts.CurrentRow.Cells("AccountNumber").Value.ToString '  
                GetAccountName = Me.GridAccounts.CurrentRow.Cells("AccountName").Value.ToString '  
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Search()
    End Sub
    Private Sub Search()
        Me.GridAccounts.FilterDescriptors.Clear()
        FilterGrid(Me.GridAccounts, "AccountName", Me.TxtAccName.Text, FilterOperator.Contains)
        FilterGrid(Me.GridAccounts, "AccountNumber", Me.TxtAccNum.Text, FilterOperator.Contains)

    End Sub
End Class
