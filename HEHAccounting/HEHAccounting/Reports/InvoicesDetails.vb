Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.FormatProviders.OpenXml.Model

Public Class InvoicesDetails

    Dim VendorCustomerID As String
    Dim VendorCustomerTitle As String
    Dim VendorCustomerType As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If

    End Sub
    Private Sub DebitsCredits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrency.DataSource = Currencydata
        Initiatedropdownlist(Me.DropCurrency, False)
        Me.DropCurrency.SelectedValue = ProgramFormCurrency

        AutoComplete()
        RefrechGrid()
        InitiateGrid(Me.GridInvoicesDetails)
        Me.GridInvoicesDetails.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
        GridInvoicesDetails.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom
    End Sub

    Sub AutoComplete()
        Me.CustomTxtItemName.Tag = FormPopupType.FrmGetItem
        Me.CustomTxtItemName.AutoCompleteDataSource = ItemsNameAuto
        Me.CustomTxtItemName.AutoCompleteMode = AutoCompleteMode.Suggest

        Me.CustomTxtVendorCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.CustomTxtVendorCustomer.AutoCompleteCustomSource = VendorsCustomersAuto
        Me.CustomTxtVendorCustomer.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub
    Private Sub TxtVendorsCustomeraBtn_Click(sender As Object, e As EventArgs) Handles TxtVendorsCustomerBtn.Click
        Dim FrmGetVendorsCustomersPopup As New VendorsCustomersPopup
        FrmGetVendorsCustomersPopup.ShowDialog()

        If Not FrmGetVendorsCustomersPopup.GetVendorCustomerName.Length = 0 Then
            CustomerNameAuto.Add(FrmGetVendorsCustomersPopup.GetVendorCustomerName.ToLower)
            Me.CustomTxtVendorCustomer.Text = FrmGetVendorsCustomersPopup.GetVendorCustomerName
        End If
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        Me.BtnFiltering.Text = LoStrId.LblFiltering
        Me.BtnReset.Text = LoStrId.LblReset
        Me.Text = LoStrId.LblDebtorsCreditors
    End Sub

    Public Sub RefrechGrid()
        Dim Param(3) As String
        Param(0) = "@cItemName ," & Evalquote(Me.CustomTxtItemName.Text)
        Param(1) = "@cCustVendName ," & CustomTxtVendorCustomer.Text
        Param(2) = "@cCustVend ," & VendorCustomerType
        Param(3) = "@iCurrencyID ," & Me.DropCurrency.SelectedValue
        FillGridViewProcedureWithParameters(Me.GridInvoicesDetails, "SelectInvoicesDetails", Param)

        'Always Hidden
        HideShowColummn(Me.GridInvoicesDetails, Me.GridInvoicesDetails.Columns("PaymentType").Index, False)

        'HideShowColummn(Me.GridDebitsCredits, IIf(BoolLTRLanguage, Me.GridDebitsCredits.Columns("Description").Index, Me.GridDebitsCredits.Columns("LatinDescription").Index), False)
        'HideShowColummn(Me.GridDebitsCredits, Me.GridDebitsCredits.Columns("Refertype").Index, False)
    End Sub


    Private Sub GridInvoicesDetails_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles GridInvoicesDetails.ViewCellFormatting
        If (e.CellElement.RowInfo.Group Is Nothing And TypeOf e.CellElement Is GridSummaryCellElement) Then
            e.CellElement.ForeColor = Color.Blue
            e.CellElement.RowElement.DrawFill = True
            e.CellElement.RowElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
            e.CellElement.RowElement.BackColor = Color.FromArgb(239, 246, 255)

            If Me.DropCurrency.SelectedValue = Currency.LebaneaseLire Then
                If e.Column.Name = "SubTotal" Or e.Column.Name = "PurchasingPrice" Or e.Column.Name = "SellingPrice" Or e.Column.Name = "ItemDiscount" Or e.Column.Name = "TotalDue" Or e.Column.Name = "DollarRate" Then
                    e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, Currency.LebaneaseLire, False, False)
                End If
            End If

        Else
            e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.CellElement.RowElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
            e.CellElement.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        End If
    End Sub
    Private Sub GridInvoicesDetails_CellFormatting(sender As Object, e As CellFormattingEventArgs)
        If e.CellElement.ColumnInfo.Name = "PaymentTypeName" Then
            If e.Row.Cells("PaymentType").Value = "D" Then
                e.CellElement.DrawFill = True
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                e.CellElement.BackColor = Color.Red
            ElseIf e.Row.Cells("PaymentType").Value = "TA" Then
                e.CellElement.DrawFill = True
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                e.CellElement.BackColor = Color.Yellow
            ElseIf e.Row.Cells("PaymentType").Value = "PI" Then
                e.CellElement.DrawFill = True
                e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
                e.CellElement.BackColor = Color.Green
            Else
                e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local)
                e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            End If
        End If

        If Me.DropCurrency.SelectedValue = Currency.LebaneaseLire Then
            If e.Column.Name = "SubTotal" Or e.Column.Name = "PurchasingPrice" Or e.Column.Name = "SellingPrice" Or e.Column.Name = "ItemDiscount" Or e.Column.Name = "TotalDue" Or e.Column.Name = "DollarRate" Then
                e.CellElement.Text = FormatGridColumnAsCurrency(e.CellElement.Value, Currency.LebaneaseLire, False, False)
            End If
        End If


    End Sub
    Private Sub FormClear()
        Me.DropCurrency.SelectedValue = ProgramFormCurrency
        Me.CustomTxtVendorCustomer.Text = String.Empty
        Me.CustomTxtItemName.Text = String.Empty
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        FormClear()
        RefrechGrid()
    End Sub

    Private Sub CustomTxtItemName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        If Not ItemsNameAuto.Contains(Me.CustomTxtItemName.Text.ToLower) Then
            Me.CustomTxtItemName.Text = String.Empty
        Else

        End If
    End Sub

    Private Sub CustomTxtVendorCustomer_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CustomTxtVendorCustomer.Validating
        If Not VendorsCustomersAuto.Contains(Me.CustomTxtVendorCustomer.Text.ToLower) Then
            If Not CustomerNameAuto.Contains(Me.CustomTxtVendorCustomer.Text.ToLower & "/" & VendorCustomerTitle & "/" & VendorCustomerID & "/" & VendorCustomerType) Then
                Me.CustomTxtVendorCustomer.Text = String.Empty
                VendorCustomerID = String.Empty
                VendorCustomerTitle = String.Empty
                VendorCustomerType = String.Empty
            End If
        Else
            Dim CustomerData() As String = Me.CustomTxtVendorCustomer.Text.Split("/")
            VendorCustomerID = CustomerData(2)
            Me.CustomTxtVendorCustomer.Text = CustomerData(0)
            VendorCustomerTitle = CustomerData(1)
            VendorCustomerType = CustomerData(3)
        End If
    End Sub
    Private Sub LblIemName_Click(sender As Object, e As EventArgs) Handles LblIemName.Click
        Me.CustomTxtItemName.Text = String.Empty
    End Sub

    Private Sub BtnFiltering_Click(sender As Object, e As EventArgs) Handles BtnFiltering.Click
        If VendorCustomerType <> "" Or Me.CustomTxtItemName.Text <> "" Then
            RefrechGrid()
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If

    End Sub

    Private Sub DropCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles DropCurrency.SelectedIndexChanged
        RefrechGrid()
        'BtnFiltering_Click(New Object, New EventArgs)
    End Sub

    Private Sub LblCustomerName_Click(sender As Object, e As EventArgs) Handles LblCustomerName.Click
        CustomTxtVendorCustomer.Text = String.Empty
    End Sub
End Class
