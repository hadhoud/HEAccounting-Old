Imports Telerik.WinControls.UI

Public Class Inventory
    Dim EnterPressed As String
    Dim InventoryID As String
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        ShowPermissions()
        FillGrid()

    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormClear()
    End Sub
    Sub ShowPermissions()
        Me.LblBarcode.Visible = BoolShowBarcode
        Me.TxtItemBarcode.Visible = BoolShowBarcode
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.lblPurchaseOrder
        Me.LblItemID.Text = LoStrId.LblItemID
        Me.LblItemName.Text = LoStrId.LblItemName
        Me.LblBarcode.Text = LoStrId.LblBarcode
        Me.BtnAdd.Text = LoStrId.LblAdd
        Me.BtnSaveAndNew.Text = LoStrId.LblSaveNew
        ChangeTextButtonToRight(Me.TxtItemName, Me.ATxtItemNameBtn)
    End Sub
    Private Sub FillGrid()
        Dim QuantityCol As New GridViewDecimalColumn With {
            .Name = "Qty",
            .DecimalPlaces = 0
        }

        Dim DeleteColumn As New GridViewCommandColumn With {
            .Name = "Delete",
            .Image = My.Resources._Erase,
            .ImageAlignment = ContentAlignment.MiddleCenter,
            .AutoEllipsis = True,
            .Width = 15
        }

        Dim ItemID As New GridViewTextBoxColumn With
            {
        .Name = "Item_id",
        .FieldName = "Item_id",
         .[ReadOnly] = True,
        .Width = 30
            }

        Dim ItemName As New GridViewTextBoxColumn With
            {
        .Name = "Item_name",
        .FieldName = "Item_name",
        .[ReadOnly] = True
          }

        Dim AvailableQty As New GridViewTextBoxColumn With
            {
        .Name = "AvailableQty",
        .FieldName = "Qty",
        .[ReadOnly] = True
          }

        Me.GridInvItems.MasterTemplate.Columns.Add(ItemID)
        Me.GridInvItems.MasterTemplate.Columns.Add(ItemName)
        Me.GridInvItems.MasterTemplate.Columns.Add(AvailableQty)
        Me.GridInvItems.MasterTemplate.Columns.Add(QuantityCol)
        Me.GridInvItems.MasterTemplate.Columns.Add(DeleteColumn)
        Me.GridInvItems.MasterTemplate.Columns.Add("IsAlertQtyOnBuy")

        AddHandler GridInvItems.CommandCellClick, AddressOf DeleteItem

        InitiateGrid(Me.GridInvItems, Editing:=True)
        HideShowColummn(GridInvItems, Me.GridInvItems.Columns.Item("IsAlertQtyOnBuy").Index, False)

    End Sub
    Sub AutoComplete()

        Me.TxtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.TxtItemName.AutoCompleteCustomSource = ItemsNameAuto
        Me.TxtItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub GetID()
        Dim Param(0) As String
        Param(0) = "@VTableName , Inventory"
        InventoryID = GetScalarProcedure("GetID", Param)
    End Sub
    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If Me.GridInvItems.ChildRows.Count <> 0 Then
            If Me.MskTxtInvDate.Text.Length <> 0 Then
                If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then

                    If BtnSaveAndNew.Tag = "Save" Then
                        For i As Integer = 0 To GridInvItems.ChildRows.Count - 1
                            Dim Param(6) As String
                            Param(0) = "@IItemID , " & Me.GridInvItems.Rows(i).Cells("Item_id").Value
                            Param(1) = "@FAvailableQty , " & Me.GridInvItems.Rows(i).Cells("AvailableQty").Value
                            Param(2) = "@FQty , " & Me.GridInvItems.Rows(i).Cells("Qty").Value
                            Param(3) = "@CInventoryNote , " & Me.TxtDesc.Text
                            Param(4) = "@TDueDate , " & Me.MskTxtInvDate.Value
                            Param(5) = "@IInventoryID , " & InventoryID
                            Param(6) = "@IUserID , " & UserID
                            ExecuteProcedureWithParameters("InsertInventory", Param)
                        Next

                        'Dim Rptparam(0) As String
                        'Rptparam(0) = "InvID , " & Me.TxtInvID.Text
                        'If Not BoolForPrint Then
                        '    If MessageShowAsk(Con.Ask_Do_You_Want_Print_Invoice) = DialogResult.Yes Then
                        '        OpenReport(Con.RptPurchaseOrder, Rptparam)
                        '    End If
                        'Else
                        '    OpenReport(Con.RptPurchaseOrder, Rptparam)
                        'End If
                        FormClear()
                        'ElseIf BtnSaveAndNew.Tag = "Edit" Then
                        '    Dim ParamDelete(0) As String
                        '    ParamDelete(0) = "@IInvID , " & Me.TxtInvID.Text
                        '    ExecuteProcedureWithParameters("UpdatePurchaseOrderHeader", Param)
                        '    ExecuteProcedureWithParameters("DeletePurchaseOrdersDetails", ParamDelete)
                        '    InsertItemDetails()
                        '    MessageShowInfo(Con.Msg_Invoice_Has_Been_Updated)
                    End If
                End If
            Else
                MessageShowInfo(Con.Msg_Enter_All_Fields)
            End If
        Else
            MessageShowInfo(Con.Msg_No_Items_Added)
        End If
    End Sub

    Private Sub FormClear()
        Me.TxtDesc.Text = String.Empty
        Me.GridInvItems.Rows.Clear()
        Me.MskTxtInvDate.Value = Date.Now.Date
        Me.TxtItemBarcode.Focus()
        GetID()
    End Sub
    Private Sub ATxtItemNameBtn_Click(sender As Object, e As EventArgs) Handles ATxtItemNameBtn.Click
        Dim FrmGetItem As New ItemsPopup
        FrmGetItem.ShowDialog()
        If Not FrmGetItem.GetITemName.Length = 0 Then
            Me.TxtItemName.Text = FrmGetItem.GetITemName
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If Not (Me.TxtItemName.Text.Length = 0 And Me.TxtItemid.Text.Length = 0 And Me.TxtItemBarcode.Text.Length = 0) Then
            'ADD
            If EnterPressed = "ItemName" And Me.TxtItemName.Text.Trim <> String.Empty Then
                Dim Param(1) As String
                Param(0) = "@CBy , Name"
                Param(1) = "@CItemName , " & Evalquote(Me.TxtItemName.Text)
                AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsForInventory", Param))
                Me.TxtItemName.Text = ""

            ElseIf EnterPressed = "ItemID" And Me.TxtItemid.Text.Trim <> String.Empty Then
                Dim Param(1) As String
                Param(0) = "@CBy , ID"
                Param(1) = "@IItemID , " & Me.TxtItemid.Text
                AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsForInventory", Param))
                Me.TxtItemid.Text = ""

            ElseIf EnterPressed = "Barcode" And Me.TxtItemBarcode.Text.Trim <> String.Empty Then
                Dim Param(1) As String
                Param(0) = "@CBy , Barcode"
                Param(1) = "@CBarcode , " & Evalquote(Me.TxtItemBarcode.Text)
                AddItemToGrid(ExecuteProcedureDatatableWithParameters("SelectItemsForInventory", Param))
                Me.TxtItemBarcode.Text = ""
            End If
        End If
    End Sub

    Public Sub AddItemToGrid(ByVal dt As DataTable)

        If dt.Rows.Count > 0 Then
            For Each row In Me.GridInvItems.Rows
                If row.Cells("Item_id").Value.ToString = dt.Rows(0).Item("Item_id").ToString Then
                    MessageShowInfo(Con.Msg_Item_Has_Been_Added)
                    Exit Sub
                End If
            Next

            Dim rowInfo As New GridViewDataRowInfo(Me.GridInvItems.MasterView)
            rowInfo.Cells("Item_id").Value = dt.Rows(0).Item("Item_id").ToString
            rowInfo.Cells("Item_name").Value = dt.Rows(0).Item("Item_name").ToString
            rowInfo.Cells("AvailableQty").Value = dt.Rows(0).Item("Qty").ToString
            rowInfo.Cells("Qty").Value = 1
            rowInfo.Cells("IsAlertQtyOnBuy").Value = dt.Rows(0).Item("IsAlertQtyOnBuy")
            Me.GridInvItems.Rows.Add(rowInfo)
            Me.GridInvItems.Columns("Item_name").BestFit()
            '   Checkdata(rowInfo)
        End If

    End Sub

    Private Sub TxtItemBarcode_TextChanged(sender As Object, e As EventArgs) Handles TxtItemBarcode.TextChanged
        EnterPressed = "Barcode"
    End Sub

    Private Sub TxtItemid_TextChanged(sender As Object, e As EventArgs) Handles TxtItemid.TextChanged
        EnterPressed = "ItemID"
    End Sub

    Private Sub TxtItemName_TextChanged(sender As Object, e As EventArgs) Handles TxtItemName.TextChanged
        EnterPressed = "ItemName"
    End Sub

    Private Sub TxtItemBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "Barcode"
            BtnAdd.PerformClick()
        End If
    End Sub

    Private Sub TxtItemid_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemid.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "ItemID"
            BtnAdd.PerformClick()
        End If
    End Sub

    Private Sub TxtItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterPressed = "ItemName"
            BtnAdd.PerformClick()
        End If
    End Sub
    Private Sub DeleteItem()
        If GridInvItems.Rows.Count > 0 Then
            Me.GridInvItems.CurrentRow.Delete()
        End If
    End Sub
    Private Sub GridInvItems_CellEditorInitialized(sender As Object, e As GridViewCellEventArgs) Handles GridInvItems.CellEditorInitialized
        Dim spinEditor As GridSpinEditor = TryCast(Me.GridInvItems.ActiveEditor, GridSpinEditor)
        If spinEditor IsNot Nothing Then
            Dim element As RadSpinEditorElement = spinEditor.EditorElement
            element.ShowUpDownButtons = False
            element.TextAlignment = HorizontalAlignment.Center
        End If
    End Sub
End Class
