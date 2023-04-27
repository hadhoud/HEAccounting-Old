Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Cryptography
Imports Telerik.Reporting
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Module ControlsFunctions
    ReadOnly Db As New Database

    Public Sub InitiateTitleForm(ByVal Frm As RadForm, Optional ByVal TitleFlg As Boolean = False)
        Frm.FormElement.TitleBar.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        '  Frm.FormElement.TitleBar.TitlePrimitive.ForeColor = Color.White
        If TitleFlg Then
            If BoolLTRLanguage Then
                Frm.Text = LoStrId.LblLatinProgramName
            Else
                Frm.Text = LoStrId.LblProgramName
            End If
        End If
    End Sub

    Public Sub InitiateDateTimePicker(datePicker As RadDateTimePicker, minDate As Date, boolShowFooter As Boolean, isChecked As Boolean)
        datePicker.DateTimePickerElement.Calendar.HeaderNavigationMode = HeaderNavigationMode.Zoom
        datePicker.DateTimePickerElement.TextBoxElement.TextAlign = HorizontalAlignment.Center
        'datePicker.NullDate = Date.Today
        'datePicker.NullText = Date.Today
        'datePicker.NullableValue = Date.Today
        datePicker.MinDate = minDate
        datePicker.Value = Date.Today
        datePicker.Text = Date.Today
        datePicker.Checked = isChecked
        datePicker.DateTimePickerElement.Calendar.ShowFooter = boolShowFooter
    End Sub

    Public Sub InitiateGrid(ByVal grid As RadGridView, Optional ByVal Editing As Boolean = False, Optional ByVal Grouping As Boolean = False, Optional ByVal Bestfit As Boolean = False)
        grid.AllowAddNewRow = False
        grid.AllowEditRow = Editing
        grid.AllowDeleteRow = False
        grid.AllowCellContextMenu = False
        grid.AllowRowHeaderContextMenu = False
        grid.AllowColumnHeaderContextMenu = False
        grid.AllowColumnChooser = False
        grid.AllowColumnReorder = False
        grid.AllowRowResize = False
        grid.ClipboardCutMode = GridViewClipboardCutMode.Disable
        grid.ClipboardCopyMode = GridViewClipboardCopyMode.Disable
        grid.ClipboardPasteMode = GridViewClipboardPasteMode.Disable
        grid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grid.EnableGrouping = Grouping
        grid.RightToLeft = RightToLeft.Inherit
        grid.AutoSizeRows = False
        grid.TableElement.RowHeight = 35
        grid.TableElement.TableHeaderHeight = 35
        If BoolLTRLanguage Then
            grid.Font = New System.Drawing.Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point)
        Else
            grid.Font = New System.Drawing.Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point)
        End If

        For Each Col As GridViewDataColumn In grid.Columns
            Col.TextAlignment = ContentAlignment.MiddleCenter
            If BoolLTRLanguage Then
                Col.HeaderText = ChangeColNameToEnglish(Col.Name)
            Else
                Col.HeaderText = ChangeColNameToArabic(Col.Name)
            End If
            Col.AutoSizeMode = BestFitColumnMode.None
            Col.BestFit()
            If (Col.Name.ToLower.Contains("code") Or Col.Name.ToLower.Contains("id")) And Col.Name.ToLower <> "notesid" Then
                Col.AutoSizeMode = BestFitColumnMode.HeaderCells
                Col.BestFit()
                Col.Width = 45
            ElseIf Col.Name.Contains("Date") Then
                Col.FormatString = "{0:dd/MM/yyyy}"
                Col.AutoSizeMode = BestFitColumnMode.AllCells
                Col.BestFit()
            ElseIf Col.Name.Contains("date") Then
                Col.FormatString = "{0:dd/MM/yyyy}"
            End If
        Next

    End Sub

    Public Sub InitiateGridChild(ByVal grid As GridViewTemplate)
        grid.AllowAddNewRow = False
        grid.AllowEditRow = False
        grid.AllowDeleteRow = False
        grid.AllowCellContextMenu = False
        grid.AllowRowHeaderContextMenu = False
        grid.AllowColumnHeaderContextMenu = False
        grid.AllowColumnChooser = False
        grid.AllowColumnReorder = False
        grid.AllowRowResize = False
        grid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grid.EnableGrouping = False
        'grid.RightToLeft = RightToLeft.Inherit
        'grid.s = False
        'grid.TableElement.RowHeight = 35
        'grid.TableElement.TableHeaderHeight = 35
        'grid.Font = New Drawing.Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point)
        For Each Col As GridViewDataColumn In grid.Columns
            Col.TextAlignment = ContentAlignment.MiddleCenter
            If BoolLTRLanguage Then
                Col.HeaderText = ChangeColNameToEnglish(Col.Name)
            Else
                Col.HeaderText = ChangeColNameToArabic(Col.Name)
            End If
            If Col.Name.Contains("Date") Then
                Col.FormatString = "{0:dd/MM/yyyy}"
            End If
        Next

    End Sub

    Public Sub Initiatedropdownlist(ByVal dropddown As RadDropDownList, Optional ByVal SelectedindexZero As Boolean = True)
        dropddown.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        dropddown.RootElement.Alignment = ContentAlignment.MiddleCenter
        dropddown.DefaultItemsCountInDropDown = 9
        dropddown.ListElement.ItemHeight = 30
        dropddown.Font = Appfont
        For Each rad As RadListDataItem In dropddown.Items
            rad.Font = Appfont
            rad.TextAlignment = ContentAlignment.MiddleCenter
        Next
        If SelectedindexZero Then
            dropddown.SelectedIndex = -1
        End If
    End Sub

    Public Sub LoadPaymentTypesDropDown(ByVal dropddown As RadDropDownList)

        Dim PaymentTypeItem As New RadListDataItem With {
            .Text = Con.Cash,
            .Value = PaymentType.Cash
        }
        dropddown.Items.Add(PaymentTypeItem)

        PaymentTypeItem = New RadListDataItem With {
            .Text = Con.Debt,
            .Value = PaymentType.Debt
        }
        dropddown.Items.Add(PaymentTypeItem)

        PaymentTypeItem = New RadListDataItem With {
            .Text = Con.Paid,
            .Value = PaymentType.Paid
        }
        dropddown.Items.Add(PaymentTypeItem)

        PaymentTypeItem = New RadListDataItem With {
            .Text = Con.Taasit,
            .Value = PaymentType.Taasit
        }
        dropddown.Items.Add(PaymentTypeItem)

    End Sub
    Public Sub HideShowColummn(ByVal Grid As RadGridView, ByVal Index As Integer, ByVal IsVsible As Boolean)
        Grid.Columns(Index).IsVisible = IsVsible
    End Sub

    Public Sub HideShowColummnChild(ByVal Grid As GridViewTemplate, ByVal Index As Integer, ByVal IsvVsible As Boolean)
        Grid.Columns(Index).IsVisible = IsvVsible
    End Sub

    Public Sub FilterGrid(ByVal Grid As RadGridView, ByVal FilterPropertyName As String, ByVal FilterStr As String, ByVal Opera As Telerik.WinControls.Data.FilterOperator)
        Dim filter As New FilterDescriptor With {
            .PropertyName = FilterPropertyName,
            .Operator = Opera,
            .Value = FilterStr
        }
        '   filter.IsFilterEditor = True
        Grid.EnableFiltering = True
        Grid.ShowFilteringRow = False
        Grid.FilterDescriptors.Add(filter)
        If Grid.Rows.Count = 0 Then
            Grid.ShowNoDataText = True
        End If
    End Sub

    Function ChangeTextButtonToRight(ByVal BTnTextBox As RadButtonTextBox, ByVal BTnElement As RadButtonElement)
        BTnTextBox.LeftButtonItems.Remove(BTnElement)
        BTnTextBox.RightButtonItems.Add(BTnElement)
        Return True
    End Function

    Public Sub GridViewAddSummaryRow(gridView As RadGridView, name As String, format As String, aggregate As GridAggregateFunction)

        Dim GridViewSummaryItem1 As GridViewSummaryItem = New GridViewSummaryItem With {
            .Aggregate = aggregate,
            .AggregateExpression = Nothing,
            .FormatString = format,
            .Name = name
        }
        Dim rowItems As GridViewSummaryRowItem = New GridViewSummaryRowItem()

        If gridView.MasterView.SummaryRows.Count > 0 Then
            rowItems = gridView.MasterView.SummaryRows(0).SummaryRowItem
            rowItems.Add(GridViewSummaryItem1)
        Else
            rowItems.Add(GridViewSummaryItem1)
            gridView.MasterTemplate.SummaryRowsBottom.Add(rowItems)
            gridView.MasterTemplate.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
            gridView.BottomPinnedRowsMode = GridViewBottomPinnedRowsMode.Fixed
            gridView.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom
        End If
    End Sub

End Module
