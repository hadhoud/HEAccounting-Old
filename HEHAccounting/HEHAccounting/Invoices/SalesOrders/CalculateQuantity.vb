Public Class CalculateQuantity
    Public SellingPrice As Decimal = 0
    Public CalculatedQuantity As Decimal = 0
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No

    End Sub

    Public Sub ShowItemPrice(item_name As String, SellingPrice As Decimal)
        txtItemName.Text = item_name
        txtSellingPrice.Text = SellingPrice
    End Sub

    Private Sub FormClear()

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        If Val(txtQuantity.Text) <> 0 And Val(txtSellingPrice.Text) <> 0 Then
            SellingPrice = Me.txtSellingPrice.Text
            CalculatedQuantity = Me.txtQuantity.Text
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = DialogResult.Cancel
        End If

    End Sub

    Private Sub txtSellingPrice_TextChanged(sender As Object, e As EventArgs) Handles txtSellingPrice.TextChanged
        CalculatePaidPriceQuantity()
    End Sub

    Private Sub txtSellingRatio_TextChanged(sender As Object, e As EventArgs) Handles txtSellingRatio.TextChanged
        CalculatePaidPriceQuantity()
    End Sub

    Private Sub txtPaidPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPaidPrice.TextChanged
        CalculatePaidPriceQuantity()
    End Sub

    Private Sub CalculatePaidPriceQuantity()
        If txtSellingPrice.Text <> "" And txtSellingRatio.Text <> "" And txtSellingRatio.Text <> "0" _
    And txtPaidPrice.Text <> "" And txtPaidPrice.Text <> "0" Then
            Me.txtQuantity.Text = Math.Round((txtPaidPrice.Text * txtSellingRatio.Text) / txtSellingPrice.Text, 3)
        Else
            Me.txtQuantity.Text = ""
        End If
    End Sub


End Class
