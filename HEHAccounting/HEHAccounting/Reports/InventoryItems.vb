Public Class InventoryItems
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
    End Sub
    Private Sub InventoryItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoComplete()
        RefrechGrid()
        InitiateGrid(Me.GridInventoryItems, Grouping:=True)
        FormClear()
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        Me.LblFrom.Text = LoStrId.LblFrom
        Me.LblTo.Text = LoStrId.LblTo
        Me.LblItemName.Text = LoStrId.LblItemName
        Me.BtnFiltering.Text = LoStrId.LblFiltering
        Me.BtnReset.Text = LoStrId.LblReset
        'IN Load to check Sales or purchases
    End Sub

    Sub AutoComplete()
        Me.TxtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtItemName.AutoCompleteCustomSource = ItemsNameAuto
        Me.TxtItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        RefrechGrid()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        FormClear()
        RefrechGrid()
    End Sub
    Private Sub FormClear()
        Me.TxtItemName.Text = String.Empty
        Me.CheckDateTo.Checked = False
        Me.CheckDateFrom.Checked = False
        Me.MskTxtInvDateFrom.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0)
    End Sub

    Private Sub RefrechGrid()
        Dim Param(2) As String
        If Me.TxtItemName.Text <> String.Empty Then
            Param(0) = "@CItemName , " & Me.TxtItemName.Text
        Else
            Param(0) = "@CItemName , Nothing "
        End If
        If Me.CheckDateFrom.Checked Then
            Param(1) = "@TDateFrom , " & Me.MskTxtInvDateFrom.Value
        Else
            Param(1) = "@TDateFrom , 1991-01-01"
        End If
        If Me.CheckDateTo.Checked Then
            Param(2) = "@TDateTo , " & Me.MskTxtInvDateTo.Value
        Else
            Param(2) = "@TDateTo , 1992-02-02"
        End If
        FillGridViewProcedureWithParameters(Me.GridInventoryItems, "SelectInventoryItems", Param)

    End Sub

    Private Sub TxtItemName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtItemName.Validating
        If Not ItemsNameAuto.Contains(Me.TxtItemName.Text.ToLower) Then
            Me.TxtItemName.Text = String.Empty
        End If
    End Sub

    Private Sub TxtItemsBtn_Click(sender As Object, e As EventArgs) Handles TxtItemsBtn.Click
        Dim FrmGetItem As New ItemsPopup
        FrmGetItem.ShowDialog()
        If Not FrmGetItem.GetITemName.Length = 0 Then
            Me.TxtItemName.Text = FrmGetItem.GetITemName
        End If
    End Sub

    Private Sub CheckDateFrom_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDateFrom.ToggleStateChanged
        Me.MskTxtInvDateFrom.Enabled = Me.CheckDateFrom.Checked
    End Sub

    Private Sub CheckDateTo_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDateTo.ToggleStateChanged
        Me.MskTxtInvDateTo.Enabled = Me.CheckDateTo.Checked
    End Sub
End Class
