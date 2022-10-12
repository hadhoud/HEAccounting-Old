Public Class FrmCurrency
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        InitiateGrid(Me.GridCurrency)
    End Sub
    Private Sub FrmCurrency_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.BtnAdd.Text = LoStrId.LblAdd
        Me.BtnClose.Text = LoStrId.LblClose
        Me.Text = LoStrId.LblCurrencies
    End Sub

    Public Sub RefrechGrid()
        FillGridViewProcedure(Me.GridCurrency, "SelectCurrencies")
        HideShowColummn(Me.GridCurrency, IIf(BoolLTRLanguage, Me.GridCurrency.Columns("CurrName").Index, Me.GridCurrency.Columns("LatinName").Index), False)
        HideShowColummn(Me.GridCurrency, IIf(BoolLTRLanguage, Me.GridCurrency.Columns("PartName").Index, Me.GridCurrency.Columns("LatinPartName").Index), False)
        HideShowColummn(Me.GridCurrency, IIf(BoolLTRLanguage, Me.GridCurrency.Columns("Symb").Index, Me.GridCurrency.Columns("LatinSymb").Index), False)
        HideShowColummn(Me.GridCurrency, Me.GridCurrency.Columns("LastChangeID").Index, False)
        HideShowColummn(Me.GridCurrency, Me.GridCurrency.Columns("Date").Index, False)
        HideShowColummn(Me.GridCurrency, Me.GridCurrency.Columns("LargerDate").Index, False)
    End Sub

    Private Sub GetID()
        'Dim Param(0) As String
        'Param(0) = "@VTableName , NotesReceive"
        'Me.TxtCode.Text = GetScalarProcedure("GetID", Param)
        'Dim ParamCheck(0) As String
        'ParamCheck(0) = "@VTableName , Cheques"
        'CheckID = GetScalarProcedure("GetID", ParamCheck)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim FrmAddCurrency As New AddNewCurrency
        FrmAddCurrency.ShowDialog()
        RefrechGrid()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class
