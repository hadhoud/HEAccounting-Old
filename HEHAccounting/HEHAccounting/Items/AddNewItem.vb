Imports System.Drawing.Imaging
Imports Telerik.WinControls
Public Class AddNewItem

    Public BoolForEdit As Boolean = False
    Dim OldItemName As String
    Sub New()

        ' This call is required by the designer.
        ' This call is required by the designer.
        InitializeComponent()
        If BoolLTRLanguage Then
            ChangeToEng()
            'Else
            '    Me.MTxtItemPurchasingPrice.RightToLeft = RightToLeft.No
        End If
        FillDropList()
        ShowPermissions()
    End Sub
    Private Sub AddNewItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not BoolForEdit Then
            FormClear()
        End If
        AutoComplete()
        TxtItemBarcode.Focus()
    End Sub

    Private Sub FillDropList()
        Me.DropCurrency.ValueMember = "CurrencyID"
        Me.DropCurrency.DisplayMember = IIf(BoolLTRLanguage = True, "LatinName", "CurrName")
        Me.DropCurrency.DataSource = Currencydata
        Initiatedropdownlist(Me.DropCurrency, False)
    End Sub
    Sub ShowPermissions()
        Me.LblBarcode.Visible = BoolShowBarcode
        Me.TxtItemBarcode.Visible = BoolShowBarcode
        If Not BoolShowUnits Then
            Me.PageUnits.Item.Visibility = ElementVisibility.Collapsed
        End If
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.PageGeneral.Text = LoStrId.LblPageGeneral
        Me.PageOption.Text = LoStrId.LblPageOption
        Me.LblBarcode.Text = LoStrId.LblBarcode
        Me.LblItemID.Text = LoStrId.LblItemID
        Me.LblItemName.Text = LoStrId.LblItemName
        Me.LblGroupName.Text = LoStrId.LblGroup
        Me.BtnClose.Text = LoStrId.LblClose
        Me.BtnSaveAndNew.Text = LoStrId.LblSaveNew
        Me.LblPurchasingPrice.Text = LoStrId.LblPurchasingPrice
        Me.LblSellingPrice.Text = LoStrId.LblSellingPrice
        Me.LblQuantity.Text = LoStrId.LblQuantity
        Me.LblMinQty.Text = LoStrId.LblMinQuantity
        Me.LblCurrency.Text = LoStrId.LblCurrency
        Me.LblLatinName.Text = LoStrId.LblLatinName
        Me.ChkItemHasExpiredDt.Text = LoStrId.LblIsitemHasExpiredDate
        Me.ChkAlertBeforeExpiredDt.Text = LoStrId.LblAnalertbeforetheexpiration
        Me.ChkAlertMinQty.Text = LoStrId.LblAnalertInMinQty
        Me.ChkCheckQtyInSale.Text = LoStrId.LblAnalertInMinQtyInSell
        Me.Text = LoStrId.LblAddNewItem
        ChangeTextButtonToRight(Me.TxtGroupID, Me.TxtBtnGroupName)
    End Sub


    Sub AutoComplete()
        Me.TxtGroupID.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtGroupID.AutoCompleteCustomSource = GroupNameAuto
        Me.TxtGroupID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Public Sub ShowForEdit(ByVal dt As DataTable)
        If dt.Rows.Count > 0 Then
            Me.TxtItemid.Text = dt.Rows(0).Item("Item_id").ToString
            Me.TxtItemName.Text = dt.Rows(0).Item("Item_name").ToString
            OldItemName = Me.TxtItemName.Text.ToLower
            Me.TxtLatinName.Text = dt.Rows(0).Item("ItemLatinName").ToString
            Me.MTxtItemQty.Value = dt.Rows(0).Item("Qty").ToString
            Me.TxtItemBarcode.Text = dt.Rows(0).Item("Barcode").ToString
            Me.MTxtMinQty.Value = dt.Rows(0).Item("MinQty").ToString
            Me.DropCurrency.SelectedValue = dt.Rows(0).Item("CurrencyID")
            Me.MTxtItemSellingPrice.Value = dt.Rows(0).Item("SellingPrice")  'سعر البيع
            Me.MTxtItemPurchasingPrice.Value = dt.Rows(0).Item("PurchasingPrice")   'سعر الشراء
            Me.TxtGroupID.Text = dt.Rows(0).Item("GroupName").ToString
            If dt.Rows(0).Item("Picture").ToString.Length > 0 Then
                Me.PictureBox1.Image = Base64ToImage(dt.Rows(0).Item("Picture").ToString)
            End If
            Me.TxtUnitOne.Text = dt.Rows(0).Item("UnitOnee").ToString
            Me.TxtFactorOne.Value = dt.Rows(0).Item("FactorOne").ToString
            Me.TxtPriceOne.Value = dt.Rows(0).Item("SellingPriceOne").ToString
            Me.TxtUnitTwo.Text = dt.Rows(0).Item("UnitTwo").ToString
            Me.TxtFactorTwo.Value = dt.Rows(0).Item("FactorTwo").ToString
            Me.TxtPriceTwo.Value = dt.Rows(0).Item("SellingPriceTwo").ToString

            'Me.MskTxtExpiredDate.Value = dt.Rows(0).Item("ExpiredDate")
            ChkItemHasExpiredDt.Checked = IIf(dt.Rows(0).Item("IsHasExpiredDate") = False, False, True)
            ChkAlertBeforeExpiredDt.Checked = IIf(dt.Rows(0).Item("IsAlertExpiredDate") = False, False, True)
            ChkAlertMinQty.Checked = IIf(dt.Rows(0).Item("IsAlertMinQty") = False, False, True)
            ChkCheckQtyInSale.Checked = IIf(dt.Rows(0).Item("IsAlertQtyOnBuy") = False, False, True)
            Me.BtnSaveAndNew.Text = IIf(BoolLTRLanguage, LoStrId.LblEdit, "تعديل")
            Me.BtnSaveAndNew.Tag = "Edit"
            'Me.TxtItemName.Enabled = False
            'Me.MTxtItemQty.Enabled = False
        End If
    End Sub

    Private Function ItemBarCodeExist() As String
        If TxtItemBarcode.Text.Trim <> "" Then
            Dim Param(1) As String
            Param(0) = "@cBarcode , " & Me.TxtItemBarcode.Text
            If BtnSaveAndNew.Tag = "Save" Then
                Param(1) = "@iID , " & Nothing
            Else
                Param(1) = "@iID , " & Me.TxtItemid.Text
            End If
            Dim result = GetScalarProcedure("GetBarcodeRepetition", Param)
            If result = "0" Then
                Return ""
            Else
                Return result
            End If
        Else
            Return ""
        End If

    End Function

    Private Function NameRepetition() As Boolean
        Dim Param(2) As String
        Param(0) = "@VTableName , Items"
        Param(1) = "@CName , " & Me.TxtItemName.Text
        If BtnSaveAndNew.Tag = "Save" Then
            Param(2) = "@IID , " & Nothing
        Else
            Param(2) = "@IID , " & Me.TxtItemid.Text
        End If
        If GetScalarProcedure("GetNameRepetition", Param) = "0" Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        'selling price   سعر البيع
        ' PurchasingPrice سعر الشراء
        If Convert.ToDouble(Me.MTxtItemSellingPrice.Text) < Convert.ToDouble(Me.MTxtItemPurchasingPrice.Text) Then
            If MessageShowAsk(Con.Ask_Selling_Is_Smaller_Than_Purchasing_Price) = DialogResult.No Then
                Exit Sub
            End If
        End If
        If Me.TxtItemName.Text.Trim.Length <> 0 And Me.MTxtItemSellingPrice.Value <> "0" And
            Me.MTxtItemPurchasingPrice.Value <> "0" Then
            If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                Dim item_barcode_repititon_result = ItemBarCodeExist()
                If item_barcode_repititon_result <> "" Then
                    MessageShowInfo(Con.Msg_Items_Barcode_Already_Added & " (" & item_barcode_repititon_result & ")")
                    Exit Sub
                End If
                If NameRepetition() Then
                    MessageShowInfo(Con.Msg_Items_Already_Added)
                    Exit Sub
                End If
                Dim Param(21) As String
                Param(0) = "@CBarcode , " & Me.TxtItemBarcode.Text.Trim
                Param(1) = "@CItemName , " & Evalquote(Me.TxtItemName.Text)
                Param(2) = "@CItemLatinName , " & Evalquote(Me.TxtLatinName.Text)
                Param(3) = "@CGroupName , " & Evalquote(Me.TxtGroupID.Text)
                Param(4) = "@FPurchasingPrice , " & Me.MTxtItemPurchasingPrice.Value     ' سعر الشراء
                Param(5) = "@FSellingPrice , " & Me.MTxtItemSellingPrice.Value   ' سعر البيع
                Param(6) = "@ICurrencyID , " & Me.DropCurrency.SelectedValue
                Param(7) = "@FQty , " & Me.MTxtItemQty.Value
                Param(8) = "@FMinQty , " & Me.MTxtMinQty.Value
                Param(9) = "@BIsHasExpiredDate , " & IIf(ChkItemHasExpiredDt.Checked = True, True, False)
                Param(10) = "@BIsAlertExpiredDate , " & IIf(ChkAlertBeforeExpiredDt.Checked = True, True, False)
                Param(11) = "@BIsAlertMinQty , " & IIf(ChkAlertMinQty.Checked = True, True, False)
                Param(12) = "@BIsAlertQtyOnBuy , " & IIf(ChkCheckQtyInSale.Checked = True, True, False)
                Param(13) = "@CPicture , " & IIf(Me.TxtItemPicture.Text.Length > 0, ImageToBase64(PictureBox1.Image, ImageFormat.Png), Nothing)
                Param(14) = "@IItemID  , " & Me.TxtItemid.Text
                Param(15) = "@CUnitOne  , " & Evalquote(Me.TxtUnitOne.Text)
                Param(16) = "@CUnitTwo  , " & Evalquote(Me.TxtUnitTwo.Text)
                Param(17) = "@FFactorOne  , " & Me.TxtFactorOne.Value
                Param(18) = "@FFactorTwo  , " & Me.TxtFactorTwo.Value
                Param(19) = "@FSellingPriceOne  , " & Me.TxtPriceOne.Value
                Param(20) = "@FSellingPriceTwo  , " & Me.TxtPriceTwo.Value
                Param(21) = "@IUserID  , " & UserID
                If BtnSaveAndNew.Tag = "Save" Then
                    ExecuteProcedureWithParameters("InsertNewItem", Param)
                    ItemsNameAuto.Add(Me.TxtItemName.Text.ToLower)
                    FormClear()
                    ToDoRefrech = True
                ElseIf BtnSaveAndNew.Tag = "Edit" Then
                    ExecuteProcedureWithParameters("UpdateItem", Param)
                    ItemsNameAuto.Remove(OldItemName)
                    ItemsNameAuto.Add(Me.TxtItemName.Text.ToLower)
                    MessageShowInfo(Con.Msg_Item_Has_Been_Updated)
                    Me.AddNewPages.SelectedPage = Me.PageGeneral
                    ToDoRefrech = True
                End If
            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FormClear()
        Me.TxtItemName.Clear()
        Me.TxtLatinName.Clear()
        Me.TxtGroupID.Clear()
        Me.TxtItemBarcode.Clear()
        Me.MTxtItemPurchasingPrice.Value = 0
        Me.MTxtItemSellingPrice.Value = 0
        Me.MTxtItemQty.Value = 0
        Me.MTxtMinQty.Value = 0
        Me.TxtItemPicture.Clear()
        Me.PictureBox1.Image = My.Resources.photo
        Me.ChkCheckQtyInSale.Checked = False
        Me.ChkItemHasExpiredDt.Checked = False
        Me.ChkAlertMinQty.Checked = False
        Me.ChkAlertBeforeExpiredDt.Checked = False
        Me.AddNewPages.SelectedPage = Me.PageGeneral

        Me.TxtUnitOne.Text = String.Empty
        Me.TxtFactorTwo.Value = 0
        Me.TxtPriceOne.Value = 0
        Me.TxtUnitTwo.Text = String.Empty
        Me.TxtFactorTwo.Value = 0
        Me.TxtPriceTwo.Value = 0

        Me.TxtPriceTwo.Enabled = False
        Me.TxtFactorTwo.Enabled = False
        Me.TxtUnitTwo.Enabled = False

        Me.TxtPriceOne.Enabled = False
        Me.TxtFactorOne.Enabled = False
        Me.DropCurrency.SelectedValue = 1
        GetID()

        Me.TxtItemName.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.OpenFileDialog1.FileName = "Document"
        Me.OpenFileDialog1.Filter = "Bitmaps|*.JPG;*.jpeg;*.jpg;*.bmp" & "|Icons|*.ico" & "|All Files|*.*"
        Me.OpenFileDialog1.FilterIndex = 1
        Me.OpenFileDialog1.Multiselect = False
        If Me.OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName.ToString
            Me.TxtItemPicture.Text = OpenFileDialog1.FileName.ToString
        End If
    End Sub

    Private Sub GetID()
        Dim Param(0) As String
        Param(0) = "@VTableName , Items"
        Me.TxtItemid.Text = GetScalarProcedure("GetID", Param)
    End Sub

    Private Sub TxtBtnGroupName_Click_1(sender As Object, e As EventArgs) Handles TxtBtnGroupName.Click
        Dim FrmGetGroup As New Groups With {
            .FromAddNewItems = True
        }
        FrmGetGroup.ShowDialog()

        If Not FrmGetGroup.GetGroupName.Length = 0 Then
            GroupNameAuto.Add(FrmGetGroup.GetGroupName.ToLower)
            Me.TxtGroupID.Text = FrmGetGroup.GetGroupName
        End If
    End Sub

    Private Sub TxtGroupID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtGroupID.Validating
        If Not GroupNameAuto.Contains(Me.TxtGroupID.Text.ToLower) Then
            Me.TxtGroupID.Text = String.Empty
        End If
    End Sub



    Private Sub TxtFactorOne_ValueChanged(sender As Object, e As EventArgs) Handles TxtFactorOne.ValueChanged
        If Me.TxtFactorOne.Value <> 0 Then
            Me.TxtPriceOne.Enabled = True
        Else
            Me.TxtPriceOne.Value = 0
            Me.TxtPriceOne.Enabled = False

        End If
    End Sub


    Private Sub TxtUnitOne_TextChanged(sender As Object, e As EventArgs) Handles TxtUnitOne.TextChanged
        Me.LblPriceOne.Text = "سعر " & Me.TxtUnitOne.Text
        If Me.TxtUnitOne.Text.Trim = String.Empty Then
            Me.TxtFactorOne.Value = 0
            Me.TxtFactorOne.Enabled = False

        Else
            Me.TxtFactorOne.Enabled = True
        End If
    End Sub

    Private Sub TxtUnitTwo_TextChanged(sender As Object, e As EventArgs) Handles TxtUnitTwo.TextChanged
        Me.LblPriceTwo.Text = "سعر " & Me.TxtUnitTwo.Text
        If Me.TxtUnitTwo.Text.Trim = String.Empty Then
            Me.TxtFactorTwo.Value = 0
            Me.TxtFactorTwo.Enabled = False

        Else
            Me.TxtFactorTwo.Enabled = True
        End If
    End Sub

    Private Sub TxtPriceOne_ValueChanged(sender As Object, e As EventArgs) Handles TxtPriceOne.ValueChanged
        If Me.TxtPriceOne.Value = 0 Then
            Me.TxtUnitTwo.Text = String.Empty
            Me.TxtUnitTwo.Enabled = False

        Else
            Me.TxtUnitTwo.Enabled = True
        End If
    End Sub

    Private Sub TxtFactorTwo_TextChanged(sender As Object, e As EventArgs) Handles TxtFactorTwo.TextChanged
        If Me.TxtFactorTwo.Value <> 0 Then
            Me.TxtPriceTwo.Enabled = True
        Else
            Me.TxtPriceTwo.Value = 0
            Me.TxtPriceTwo.Enabled = False
        End If
    End Sub

    Private Sub DropCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles DropCurrency.SelectedIndexChanged
        If Me.DropCurrency.SelectedIndex <> -1 Then
            Dim CurrencyRow As DataRow = Currencydata.Select("CurrencyID = " & Me.DropCurrency.SelectedValue).First
            If Me.DropCurrency.SelectedValue.ToString = "1" Then
                If CurrencyRow("CurrFloat").ToString = "-1" Then
                    Me.MTxtItemPurchasingPrice.Mask = "F0"
                    Me.MTxtItemSellingPrice.Mask = "F0"
                    Me.TxtPriceOne.Mask = "F0"
                    Me.TxtPriceTwo.Mask = "F0"

                Else
                    Me.MTxtItemPurchasingPrice.Mask = "F" & CurrencyRow("CurrFloat").ToString
                    Me.MTxtItemSellingPrice.Mask = "F" & CurrencyRow("CurrFloat").ToString
                    Me.TxtPriceOne.Mask = "F" & CurrencyRow("CurrFloat").ToString
                    Me.TxtPriceTwo.Mask = "F" & CurrencyRow("CurrFloat").ToString
                End If

            Else
                If CurrencyRow("CurrFloat").ToString = "-1" Then
                    Me.MTxtItemPurchasingPrice.Mask = "F0"
                    Me.MTxtItemSellingPrice.Mask = "F0"
                    Me.TxtPriceOne.Mask = "F0"
                    Me.TxtPriceTwo.Mask = "F0"

                Else
                    Me.MTxtItemPurchasingPrice.Mask = "F" & CurrencyRow("CurrFloat").ToString
                    Me.MTxtItemSellingPrice.Mask = "F" & CurrencyRow("CurrFloat").ToString
                    Me.TxtPriceOne.Mask = "F" & CurrencyRow("CurrFloat").ToString
                    Me.TxtPriceTwo.Mask = "F" & CurrencyRow("CurrFloat").ToString
                End If
            End If
        End If
    End Sub

    Private Sub TxtItemBarcode_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtItemBarcode.KeyUp
        If e.KeyCode = Keys.Enter Then
            TxtItemName.Focus()
        End If
    End Sub
End Class
