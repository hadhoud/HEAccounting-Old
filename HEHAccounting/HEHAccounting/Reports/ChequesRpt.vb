Imports Telerik.WinControls.UI

Public Class ChequesRpt
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        FillDropList()
    End Sub
    Private Sub ChequesRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefrechGrid()
        InitiateGrid(Me.GridCheques, Grouping:=True)
        FormClear()
    End Sub
    Private Sub FillDropList()
        Dim item As New RadListDataItem With {
            .Text = Con.Collected,
            .Value = CheckStatus.Collected
        }
        Me.DropCheckStatus.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.NotCollected,
            .Value = CheckStatus.NotCollected
        }
        Me.DropCheckStatus.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.Returned,
            .Value = CheckStatus.Returned
        }
        Me.DropCheckStatus.Items.Add(item)


        Dim ItemUpdatedStatus As New RadListDataItem With {
            .Text = Con.Collected,
            .Value = CheckStatus.Collected
        }
        Me.DropCheckUpdatedStatus.Items.Add(ItemUpdatedStatus)

        ItemUpdatedStatus = New RadListDataItem With {
            .Text = Con.NotCollected,
            .Value = CheckStatus.NotCollected
        }
        Me.DropCheckUpdatedStatus.Items.Add(ItemUpdatedStatus)

        ItemUpdatedStatus = New RadListDataItem With {
            .Text = Con.Returned,
            .Value = CheckStatus.Returned
        }
        Me.DropCheckUpdatedStatus.Items.Add(ItemUpdatedStatus)
        Initiatedropdownlist(Me.DropCheckStatus, False)
        Initiatedropdownlist(Me.DropCheckUpdatedStatus, False)
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

    Private Sub RefrechGrid()
        Dim Param(2) As String
        If Me.CheckDateFrom.Checked Then
            Param(0) = "@TDateFrom , " & Me.MskTxtInvDateFrom.Value
        Else
            Param(0) = "@TDateFrom , 1991-01-01"
        End If
        If Me.CheckDateTo.Checked Then
            Param(1) = "@TDateTo , " & Me.MskTxtInvDateTo.Value
        Else
            Param(1) = "@TDateTo , 1992-02-02"
        End If
        If Me.DropCheckStatus.SelectedIndex <> -1 Then
            Param(2) = "@IStatus , " & Me.DropCheckStatus.SelectedValue
        Else
            Param(2) = "@IStatus , 0"
        End If
        FillGridViewProcedureWithParameters(Me.GridCheques, "SelectCheques", Param)
        HideShowColummn(Me.GridCheques, Me.GridCheques.Columns("NotesType").Index, False)
        HideShowColummn(Me.GridCheques, Me.GridCheques.Columns("Status").Index, False)
        HideShowColummn(Me.GridCheques, Me.GridCheques.Columns("CheckID").Index, False)
        HideShowColummn(Me.GridCheques, Me.GridCheques.Columns("SanadStatus").Index, False)
    End Sub
    Private Sub FormClear()
        Me.CheckDateTo.Checked = False
        Me.CheckDateFrom.Checked = False
        Me.MskTxtInvDateFrom.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0)
        Me.DropCheckStatus.SelectedIndex = -1
        Me.DropCheckUpdatedStatus.SelectedValue = CheckStatus.NotCollected
    End Sub

    Private Sub CheckDateFrom_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDateFrom.ToggleStateChanged
        Me.MskTxtInvDateFrom.Enabled = Me.CheckDateFrom.Checked
    End Sub

    Private Sub CheckDateTo_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDateTo.ToggleStateChanged
        Me.MskTxtInvDateTo.Enabled = Me.CheckDateTo.Checked
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        RefrechGrid()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        FormClear()
        RefrechGrid()
    End Sub

    Private Sub BtnUpdateStatus_Click(sender As Object, e As EventArgs) Handles BtnUpdateStatus.Click
        If Me.GridCheques.Rows.Count > 0 And Me.GridCheques.SelectedRows.Count > 0 Then
            If Me.GridCheques.CurrentRow.Cells("SanadStatus").Value = Status.Posted Then
                If MessageShowAsk(Con.Ask_Edit) = DialogResult.Yes Then
                    Dim Param(2) As String
                    Param(0) = "@ICheckID , " & Me.GridCheques.CurrentRow.Cells("CheckID").Value
                    Param(1) = "@IStatus  ," & Me.DropCheckUpdatedStatus.SelectedValue
                    Param(2) = "@IUserID , " & UserID
                    ExecuteProcedureWithParameters("UpdateCheckStatus", Param)
                    RefrechGrid()
                End If
            Else
                MessageShowInfo(Con.Msg_Notes_Status_ISUnposted)
            End If
        End If
    End Sub
End Class
