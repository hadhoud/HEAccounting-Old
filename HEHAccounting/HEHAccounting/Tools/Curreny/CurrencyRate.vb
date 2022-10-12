Imports Telerik.WinControls.UI

Public Class CurrencyRate
    Public GetCurrencyRate As Boolean = False
    Public GetCurrencyVal As String = ""
    Public GetCurrencyRateID As String = ""
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        InitiateGrid(Me.GridCurrency)
        FillDropList()
    End Sub
    Private Sub CurrencyRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub FillDropList()

        Dim CurrencyRow As DataTable = Currencydata.Select("CurrencyID <> 1").CopyToDataTable

        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrency.DataSource = CurrencyRow
        Initiatedropdownlist(Me.DropCurrency, False)
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.BtnAdd.Text = LoStrId.LblAdd
        Me.Text = LoStrId.LblCurrenciesRate
    End Sub

    Public Sub RefrechGrid()
        FillGridViewProcedure(Me.GridCurrency, "SelectCurrenciesVal")
        HideShowColummn(Me.GridCurrency, IIf(BoolLTRLanguage, Me.GridCurrency.Columns("CurrName").Index, Me.GridCurrency.Columns("LatinName").Index), False)
        HideShowColummn(Me.GridCurrency, Me.GridCurrency.Columns("CurrencyID").Index, False)
        HideShowColummn(Me.GridCurrency, Me.GridCurrency.Columns("CurrencyRateID").Index, False)
        'HideShowColummn(Me.GridCurrency, IIf(BoolLTRLanguage, Me.GridCurrency.Columns("Symb").Index, Me.GridCurrency.Columns("LatinSymb").Index), False)
        'HideShowColummn(Me.GridCurrency, IIf(BoolLTRLanguage, Me.GridCurrency.Columns("Symb").Index, Me.GridCurrency.Columns("LatinSymb").Index), False)

    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If Me.DropCurrency.SelectedIndex <> -1 And Me.TxtCurrValue.Text <> "0" And Me.DropCurrency.SelectedValue <> "1" Then
            If MessageShowAsk(Con.Ask_Add) = DialogResult.Yes Then
                Dim Param(2) As String
                Param(0) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                Param(1) = "@FCurrencyValue , " & Me.TxtCurrValue.Value
                Param(2) = "@IUserID , " & UserID
                ExecuteProcedureWithParameters("InsertCurrencyVal", Param)
                RefrechGrid()
                Me.TxtCurrValue.Text = "0"
            End If
        End If
    End Sub

    Private Sub GridCurrency_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles GridCurrency.CellDoubleClick
        If GetCurrencyRate Then
            If Me.GridCurrency.ChildRows.Count <> 0 And TryCast(sender, GridDataCellElement) IsNot Nothing Then
                GetCurrencyVal = Me.GridCurrency.CurrentRow.Cells("CurrencyVal").Value.ToString '  
                GetCurrencyRateID = Me.GridCurrency.CurrentRow.Cells("CurrencyRateID").Value.ToString
                Me.Close()
            End If
        End If
    End Sub
End Class
