Imports Telerik.WinControls.Data

Public Class ProgramLog
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
    End Sub
    Private Sub LOG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrechGrid()
        InitiateGrid(Me.GridLogs)
        FormClear()
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        Me.LblFrom.Text = LoStrId.LblFrom
        Me.LblTo.Text = LoStrId.LblTo

        Me.BtnFiltering.Text = LoStrId.LblFiltering
        Me.BtnReset.Text = LoStrId.LblReset
        'IN Load to check Sales or purchases
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        Me.GridLogs.FilterDescriptors.Clear()

        If CheckDateFrom.Checked Then
            FilterGrid(Me.GridLogs, "CreatedDate", Me.MskTxtInvDateFrom.Value, FilterOperator.IsGreaterThanOrEqualTo)
        End If
        If CheckDateTo.Checked Then
            FilterGrid(Me.GridLogs, "CreatedDate", Me.MskTxtInvDateTo.Value, FilterOperator.IsLessThanOrEqualTo)
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        FormClear()
        RefrechGrid()
    End Sub
    Private Sub FormClear()
        Me.CheckDateTo.Checked = False
        Me.CheckDateFrom.Checked = False
        Me.MskTxtInvDateFrom.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0)
    End Sub

    Private Sub RefrechGrid()
        FillGridViewProcedure(Me.GridLogs, "SelectProgramLogs")

    End Sub

    Private Sub CheckDateFrom_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDateFrom.ToggleStateChanged
        Me.MskTxtInvDateFrom.Enabled = Me.CheckDateFrom.Checked
    End Sub

    Private Sub CheckDateTo_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDateTo.ToggleStateChanged
        Me.MskTxtInvDateTo.Enabled = Me.CheckDateTo.Checked
    End Sub

    Private Sub BtnRefrech_Click(sender As Object, e As EventArgs) Handles BtnRefrech.Click
        RefrechGrid()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.GridLogs.ChildRows.Count > 0 Then
            If MessageShowAsk(Con.Ask_Delete) = DialogResult.Yes Then
                Dim Param(0) As String
                Param(0) = "@iLogID , " & Me.GridLogs.CurrentRow.Cells("ID").Value.ToString
                ExecuteProcedureWithParameters("DeleteLogByID", Param)
                RefrechGrid()
            End If
        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        If MessageShowAsk(Con.Ask_Delete) = DialogResult.Yes Then
            For Each row In GridLogs.Rows
                If row.Index <> -1 Then
                    Dim Param(0) As String
                    Param(0) = "@iLogID , " & row.Cells("ID").Value.ToString
                    ExecuteProcedureWithParameters("DeleteLogByID", Param)
                End If
            Next
            RefrechGrid()
        End If
    End Sub
End Class
