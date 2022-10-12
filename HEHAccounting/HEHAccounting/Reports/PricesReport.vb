Public Class PricesReport
    Public WhatType As String = "Sales"

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
    End Sub
    Private Sub PricesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = IIf(WhatType = "Sales", Con.SalesPriceHistory, Con.PurchasesPriceHistory)
        AutoComplete()
        RefrechGrid()
        Formclear()
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

    Private Sub RefrechGrid()
        Me.GridPrices.DataSource = Nothing
        Dim Param(4) As String
        If Me.TxtItemName.Text <> String.Empty Then
            Param(0) = "@CItemName , " & Me.TxtItemName.Text
        Else
            Param(0) = "@CItemName , " & Nothing
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
        If RadioEditedPrice.IsChecked = True Then
            Param(3) = "@CFromWhere , History"
        Else
            Param(3) = "@CFromWhere , INV"
        End If
        Param(4) = "@ICurrencyID ," & ReportFormCurrency
        If WhatType = "Sales" Then
            FillGridViewProcedureWithParameters(Me.GridPrices, "GetItemsSalesPrices", Param)
        Else
            FillGridViewProcedureWithParameters(Me.GridPrices, "GetItemsPurchasePrices", Param)
        End If
        InitiateGrid(Me.GridPrices)
    End Sub

    Sub AutoComplete()
        Me.TxtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtItemName.AutoCompleteCustomSource = ItemsNameAuto
        Me.TxtItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub TxtItemName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtItemName.Validating
        If Not ItemsNameAuto.Contains(Me.TxtItemName.Text.ToLower) Then
            Me.TxtItemName.Text = String.Empty
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Formclear()
        RefrechGrid()
    End Sub
    Private Sub Formclear()
        Me.TxtItemName.Text = String.Empty
        Me.CheckDateTo.Checked = False
        Me.CheckDateFrom.Checked = False
        Me.MskTxtInvDateFrom.Value = DateSerial(Year(Date.Now), Month(Date.Now), 1)
        Me.MskTxtInvDateTo.Value = DateSerial(Year(Date.Now), Month(Date.Now) + 1, 0)
    End Sub
    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        RefrechGrid()
    End Sub

    Private Sub RadioEditedPrice_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadioEditedPrice.ToggleStateChanged
        RefrechGrid()
    End Sub

    Private Sub RadioFromSalesInv_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadioFromSalesInv.ToggleStateChanged
        RefrechGrid()
    End Sub

    Private Sub TxtItemsBtn_Click(sender As Object, e As EventArgs) Handles TxtItemsBtn.Click
        Dim FrmGetItem As New ItemsPopup
        FrmGetItem.ShowDialog()
        If Not FrmGetItem.GetITemName.Length = 0 Then
            Me.TxtItemName.Text = FrmGetItem.GetITemName
        End If
    End Sub

    Private Sub CheckDateFrom_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDateFrom.ToggleStateChanged
        Me.MskTxtInvDateFrom.Enabled = CheckDateFrom.Checked
    End Sub

    Private Sub CheckDateTo_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckDateTo.ToggleStateChanged
        Me.MskTxtInvDateTo.Enabled = Me.CheckDateTo.Checked
    End Sub
End Class
