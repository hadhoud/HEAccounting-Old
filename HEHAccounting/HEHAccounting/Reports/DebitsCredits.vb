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
        Me.Text = LoStrId.LblDaiy
    End Sub

    Public Sub RefrechGrid()
        Dim Param(1) As String
        Param(0) = "@CWhatToSelect ," & WhatToSelect
        Param(1) = "@ICurrencyID ," & ReportFormCurrency
        FillGridViewProcedureWithParameters(Me.GridDebitsCredits, "GetCreditDebitAccount", Param)
        'HideShowColummn(Me.GridDebitsCredits, IIf(BoolLTRLanguage, Me.GridDebitsCredits.Columns("Description").Index, Me.GridDebitsCredits.Columns("LatinDescription").Index), False)
        'HideShowColummn(Me.GridDebitsCredits, Me.GridDebitsCredits.Columns("Refertype").Index, False)
    End Sub

    Private Sub FormClear()
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
        Me.GridDebitsCredits.FilterDescriptors.Clear()
        If Me.TxtAccName.Text.Trim.Length <> 0 Then
            FilterGrid(Me.GridDebitsCredits, "AccountName", Me.TxtAccName.Text.Trim, FilterOperator.Contains)
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
End Class
