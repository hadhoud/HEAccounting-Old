Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class DebitsCredits
    Public WhatToSelect As String = ""
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        FillDropList()
    End Sub
    Private Sub DebitsCredits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrency.DataSource = Currencydata
        Initiatedropdownlist(Me.DropCurrency, False)
        Me.DropCurrency.SelectedValue = ProgramFormCurrency

        RefrechGrid()
        InitiateGrid(Me.GridDebitsCredits)
    End Sub

    Private Sub FillDropList()

        'DropTrxType
        Dim item As New RadListDataItem With {
            .Text = Con.Creditors,
            .Value = CreditsDebits.Credits
        }
        Me.DropType.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.Debtors,
            .Value = CreditsDebits.Debts
        }
        Me.DropType.Items.Add(item)

        Initiatedropdownlist(Me.DropType, False)

    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        Me.BtnFiltering.Text = LoStrId.LblFiltering
        Me.BtnRefrech.Text = LoStrId.LblEdit
        Me.BtnAccRpt.Text = LoStrId.LblNew
        Me.BtnReset.Text = LoStrId.LblReset
        Me.BtnRefrech.Text = LoStrId.LblRefrech
        Me.Text = LoStrId.LblDebtorsCreditors
    End Sub

    Public Sub RefrechGrid()
        Dim Param(1) As String
        Param(0) = "@CWhatToSelect ," & WhatToSelect
        Param(1) = "@ICurrencyID ," & Me.DropCurrency.SelectedValue
        FillGridViewProcedureWithParameters(Me.GridDebitsCredits, "GetCreditDebitAccount", Param)
        'Always Hidden
        HideShowColummn(Me.GridDebitsCredits, Me.GridDebitsCredits.Columns("AccountType").Index, False)

        'HideShowColummn(Me.GridDebitsCredits, IIf(BoolLTRLanguage, Me.GridDebitsCredits.Columns("Description").Index, Me.GridDebitsCredits.Columns("LatinDescription").Index), False)
        'HideShowColummn(Me.GridDebitsCredits, Me.GridDebitsCredits.Columns("Refertype").Index, False)
    End Sub

    Private Sub FormClear()
        Me.DropCurrency.SelectedValue = ProgramFormCurrency
        Me.TxtAccName.Text = String.Empty
    End Sub

    Private Sub DropType_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles DropType.SelectedIndexChanged
        If DropType.SelectedIndex <> -1 Then
            WhatToSelect = Me.DropType.SelectedValue
            Me.Text = Me.DropType.Text.ToString
            RefrechGrid()
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        FormClear()
        Me.BtnFiltering.PerformClick()
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        'RefrechGrid()
        Me.GridDebitsCredits.FilterDescriptors.Clear()
        If Me.TxtAccName.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridDebitsCredits, "AccountName", Me.TxtAccName.Text.Trim, FilterOperator.Contains)
        End If
        If RadioCustVend.IsChecked Then
            FilterGrid(Me.GridDebitsCredits, "AccountType", Con.ACC_Cust_VEND, FilterOperator.IsEqualTo)
        End If
        If RadioAccGeneral.IsChecked Then
            FilterGrid(Me.GridDebitsCredits, "AccountType", Con.ACC_GENERAL, FilterOperator.IsEqualTo)
        End If
    End Sub

    Private Sub BtnAccRpt_Click(sender As Object, e As EventArgs) Handles BtnAccRpt.Click
        If Me.GridDebitsCredits.ChildRows.Count > 0 Then
            Dim FrmAccReport As New AccountsDetails
            FrmAccReport.TxtAccounts.Text = Me.GridDebitsCredits.CurrentRow.Cells("AccountNumber").Value.ToString
            FrmAccReport.BtnFiltering.PerformClick()
            FrmAccReport.ShowDialog()
        End If
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechGrid()
    End Sub

    Private Sub RadioCustVend_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadioCustVend.ToggleStateChanged
        BtnFiltering_Click(New Object, New EventArgs)
    End Sub

    Private Sub RadioAccGeneral_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadioAccGeneral.ToggleStateChanged
        BtnFiltering_Click(New Object, New EventArgs)
    End Sub

    Private Sub RadioAccAll_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadioAccAll.ToggleStateChanged
        BtnFiltering_Click(New Object, New EventArgs)
    End Sub

    Private Sub DropCurrency_SelectedIndexChanged(sender As Object, e As Data.PositionChangedEventArgs) Handles DropCurrency.SelectedIndexChanged
        RefrechGrid()
        'BtnFiltering_Click(New Object, New EventArgs)
    End Sub
End Class
