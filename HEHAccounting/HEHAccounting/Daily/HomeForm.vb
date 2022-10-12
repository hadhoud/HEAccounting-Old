Public Class HomeForm
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If

        ' FillData()
        TTimer.Interval = TimerHomeForm * 60 * 1000
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.lblHome
    End Sub

    Private Sub FillData()
        FillSummary()
        FillCheques()
        FillItemsMinQty()
        FillShortcuts()
        FillAlertMessage()
        datatimer.Enabled = False
    End Sub

    Private Sub FillCheques()
        Dim Param(0) As String
        Param(0) = "@IChequesDay , " & ShowChequesDay
        Dim Chequesdt As New DataTable
        Chequesdt = ExecuteProcedureDatatableWithParameters("GetChequesAlert", Param)
        Me.RadCollapsibleCheques.Controls.Clear()
        Me.RadCollapsibleCheques.Height = 29
        Me.RadCollapsibleCheques.IsExpanded = True
        If Chequesdt.Rows.Count > 0 Then
            For Each Check In Chequesdt.Rows()
                Dim Chktxt As String
                Chktxt = " شيك رقم "
                Chktxt &= " - "
                Chktxt &= IIf(Check.Item("CheckNum").ToString().Trim = String.Empty, " لا يوجد رقم ", Check.Item("CheckNum").ToString())
                Chktxt &= " - "
                Chktxt &= " يستحق بتاريخ "
                Chktxt &= Format(Convert.ToDateTime(Check.Item("DueDate").ToString()), "dd-MM-yyyy")

                If Check.Item("Difference").ToString() = 0 Then
                    Chktxt &= " اليوم "
                ElseIf Check.Item("Difference").ToString() < 0 Then
                    Chktxt &= " قبل " & Check.Item("Difference") * -1 & " أيام "
                ElseIf Check.Item("Difference").ToString() > 0 Then
                    Chktxt &= " بعد " & Check.Item("Difference").ToString() & " أيام "
                End If

                Dim ChkLabel As LinkLabel = AddLinkLabel(Chktxt)
                ChkLabel.Location.X.Equals(Me.RadCollapsibleCheques.Width)
                Me.RadCollapsibleCheques.Controls.Add(ChkLabel)
                If Me.RadCollapsibleCheques.Height < (Me.PnlAllCollapse.Height / 5) Then
                    Me.RadCollapsibleCheques.Height += ChkLabel.Height
                End If
            Next
        Else
            Dim ChkLabel As LinkLabel = AddLinkLabel("لا يوجد شيكات مستحقة")
            ChkLabel.LinkColor = Color.Red
            Me.RadCollapsibleCheques.Controls.Add(ChkLabel)
            Me.RadCollapsibleCheques.Height += ChkLabel.Height
        End If
        Me.RadCollapsibleCheques.HeaderText = Con.PanelChequesDue & " - " & Chequesdt.Rows.Count
    End Sub

    Private Sub FillItemsMinQty()
        Dim ItemQtyAlertdt As New DataTable
        ItemQtyAlertdt = ExecuteProcedureDatatable("GetItemsMinQtyAlert")
        Me.RadCollapsibleItemsMinQty.Controls.Clear()
        Me.RadCollapsibleItemsMinQty.Height = 29
        Me.RadCollapsibleItemsMinQty.IsExpanded = True
        If ItemQtyAlertdt.Rows.Count > 0 Then
            For Each ItemQty In ItemQtyAlertdt.Rows()
                Dim ItemTxt As String
                ItemTxt = " كود الصنف "
                ItemTxt &= "-"
                ItemTxt &= ItemQty.Item("Item_id").ToString()
                ItemTxt &= "-"
                ItemTxt &= " إسم الصنف "
                ItemTxt &= "-"
                ItemTxt &= ItemQty.Item("Item_name").ToString()
                ItemTxt &= "-"
                ItemTxt &= " كمية الصنف "
                ItemTxt &= "  "
                ItemTxt &= ItemQty.Item("Qty").ToString()

                'If ItemQty.Item("Difference").ToString() = 0 Then
                '    ItemTxt &= " اليوم "
                'ElseIf Check.Item("Difference").ToString() < 0 Then
                '    ItemTxt &= " قبل " & ItemQty.Item("Difference") * -1 & " أيام "
                'ElseIf Check.Item("Difference").ToString() > 0 Then
                '    ItemTxt &= " بعد " & ItemQty.Item("Difference").ToString() & " أيام "
                'End If

                Dim ItemLabel As LinkLabel = AddLinkLabel(ItemTxt)
                ItemLabel.Location.X.Equals(Me.RadCollapsibleItemsMinQty.Width)
                Me.RadCollapsibleItemsMinQty.Controls.Add(ItemLabel)
                If Me.RadCollapsibleItemsMinQty.Height < (Me.PnlAllCollapse.Height / 5) Then
                    Me.RadCollapsibleItemsMinQty.Height += ItemLabel.Height
                End If
            Next

        Else
            Dim ItemLabel As LinkLabel = AddLinkLabel("لا يوجد أصناف قريبة من الحد الأدنى")
            ItemLabel.LinkColor = Color.Red
            Me.RadCollapsibleItemsMinQty.Controls.Add(ItemLabel)
            Me.RadCollapsibleItemsMinQty.Controls.Add(ItemLabel)
            Me.RadCollapsibleItemsMinQty.Height += ItemLabel.Height
        End If
        Me.RadCollapsibleItemsMinQty.HeaderText = Con.PanelQtyAlert & " - " & ItemQtyAlertdt.Rows.Count
    End Sub

    Private Sub FillShortcuts()
        'Dim Chequesdt As New DataTable
        'Chequesdt = ExecuteProcedureDatatable("GetChequesAlert")
        Me.RadCollapsibleShortcuts.Controls.Clear()
        Me.RadCollapsibleShortcuts.Height = 29
        Me.RadCollapsibleShortcuts.IsExpanded = True
        'If Chequesdt.Rows.Count > 0 Then
        '    For Each Check In Chequesdt.Rows()
        '        Dim Chktxt As String
        '        Chktxt = " شيك رقم "
        '        Chktxt &= Check.Item("CheckNum").ToString()
        '        Chktxt &= " يستحق بتاريخ "
        '        Chktxt &= Format(Convert.ToDateTime(Check.Item("DueDate").ToString()), "dd-MM-yyyy")

        '        If Check.Item("Difference").ToString() = 0 Then
        '            Chktxt &= " اليوم "
        '        ElseIf Check.Item("Difference").ToString() < 0 Then
        '            Chktxt &= " قبل " & Check.Item("Difference") * -1 & " أيام "
        '        ElseIf Check.Item("Difference").ToString() > 0 Then
        '            Chktxt &= " بعد " & Check.Item("Difference").ToString() & " أيام "
        '        End If

        '        Dim ChkLabel As LinkLabel = AddLinkLabel(Chktxt)
        '        ChkLabel.Location.X.Equals(Me.RadCollapsibleCheques.Width)
        '        Me.RadCollapsibleCheques.Controls.Add(ChkLabel)
        '        Me.RadCollapsibleCheques.Height += ChkLabel.Height
        '    Next
        '    Me.RadCollapsibleCheques.HeaderText &= "-" & Chequesdt.Rows.Count
        'Else
        Dim ShortcutLabel As LinkLabel = AddLinkLabel("لا يوجد إختصارات")
        ShortcutLabel.LinkColor = Color.Red
        Me.RadCollapsibleShortcuts.Controls.Add(ShortcutLabel)
        Me.RadCollapsibleShortcuts.Height += ShortcutLabel.Height
        'End If
    End Sub

    Private Sub FillAlertMessage()
        'Dim Chequesdt As New DataTable
        'Chequesdt = ExecuteProcedureDatatable("GetChequesAlert")
        Me.RadCollapsibleAlertMessage.Controls.Clear()
        Me.RadCollapsibleAlertMessage.Height = 29
        Me.RadCollapsibleAlertMessage.IsExpanded = True
        'If Chequesdt.Rows.Count > 0 Then
        '    For Each Check In Chequesdt.Rows()
        '        Dim Chktxt As String
        '        Chktxt = " شيك رقم "
        '        Chktxt &= Check.Item("CheckNum").ToString()
        '        Chktxt &= " يستحق بتاريخ "
        '        Chktxt &= Format(Convert.ToDateTime(Check.Item("DueDate").ToString()), "dd-MM-yyyy")

        '        If Check.Item("Difference").ToString() = 0 Then
        '            Chktxt &= " اليوم "
        '        ElseIf Check.Item("Difference").ToString() < 0 Then
        '            Chktxt &= " قبل " & Check.Item("Difference") * -1 & " أيام "
        '        ElseIf Check.Item("Difference").ToString() > 0 Then
        '            Chktxt &= " بعد " & Check.Item("Difference").ToString() & " أيام "
        '        End If

        '        Dim ChkLabel As LinkLabel = AddLinkLabel(Chktxt)
        '        ChkLabel.Location.X.Equals(Me.RadCollapsibleCheques.Width)
        '        Me.RadCollapsibleCheques.Controls.Add(ChkLabel)
        '        Me.RadCollapsibleCheques.Height += ChkLabel.Height
        '    Next
        '    Me.RadCollapsibleCheques.HeaderText &= "-" & Chequesdt.Rows.Count
        'Else
        Dim MessageLabel As LinkLabel = AddLinkLabel("لا يوجد رسائل")
        MessageLabel.LinkColor = Color.Red
        Me.RadCollapsibleAlertMessage.Controls.Add(MessageLabel)
        Me.RadCollapsibleAlertMessage.Height += MessageLabel.Height
        'End If
    End Sub
    Function AddLinkLabel(ByVal Txt As String) As LinkLabel
        Dim LblLink As New LinkLabel
        LblLink.Dock = DockStyle.Top
        LblLink.AutoSize = False
        LblLink.Height = 30
        LblLink.TextAlign = ContentAlignment.MiddleLeft
        LblLink.Font = LinkLabelFont
        LblLink.ForeColor = Color.Black
        LblLink.LinkColor = Color.Black
        LblLink.VisitedLinkColor = Color.Black
        LblLink.ActiveLinkColor = Color.Black
        LblLink.Text = Txt
        LblLink.LinkBehavior = LinkBehavior.NeverUnderline
        Return LblLink
    End Function
    Private Sub FillSummary()

        Dim Summarydt As New DataTable
        Dim param(0) As String
        param(0) = "@ICurrencyID , " & HomeFormCurrency
        Summarydt = ExecuteProcedureDatatableWithParameters("GetHomeSummarySOCach", param)
        Me.TxtSOCash.Text = Summarydt.Rows(0).Item("SOCach").ToString
        Me.TxtSODebt.Text = Summarydt.Rows(0).Item("SODebit").ToString
        Me.TxtRSODebt.Text = Summarydt.Rows(0).Item("RSODebit").ToString
        Me.TxtRSOCash.Text = Summarydt.Rows(0).Item("RSOCach").ToString
        Me.TxtSO.Text = Summarydt.Rows(0).Item("SO").ToString
        Me.TxtRSO.Text = Summarydt.Rows(0).Item("RSO").ToString

        Me.TxtPOCash.Text = Summarydt.Rows(0).Item("POCach").ToString
        Me.TxtPODebt.Text = Summarydt.Rows(0).Item("PODebit").ToString
        Me.TxtRPODebt.Text = Summarydt.Rows(0).Item("RPODebit").ToString
        Me.TxtRPOCash.Text = Summarydt.Rows(0).Item("RPOCach").ToString
        Me.TxtPO.Text = Summarydt.Rows(0).Item("PO").ToString
        Me.TxtRPO.Text = Summarydt.Rows(0).Item("RPO").ToString

        Me.TxtNotePayCash.Text = Summarydt.Rows(0).Item("NPCach").ToString
        Me.TxtNotePayCheck.Text = Summarydt.Rows(0).Item("NPCheck").ToString
        Me.TxtNotePay.Text = Summarydt.Rows(0).Item("NP").ToString
        Me.TxtNoteReceiveCash.Text = Summarydt.Rows(0).Item("NRCach").ToString
        Me.TxtNoteReceiveCheck.Text = Summarydt.Rows(0).Item("NRCheck").ToString
        Me.TxtNoteReceive.Text = Summarydt.Rows(0).Item("NR").ToString

        Me.TxtInCash.Text = Val(Me.TxtNoteReceiveCash.Text) + Val(Me.TxtNoteReceiveCheck.Text) + Val(Me.TxtSOCash.Text) + Val(Me.TxtRPOCash.Text)
        Me.TxtInDebt.Text = Val(Me.TxtSODebt.Text) + Val(Me.TxtRPODebt.Text)
        Me.TxtIN.Text = Val(Me.TxtInCash.Text) + Val(Me.TxtInDebt.Text)

        Me.TxtOutCash.Text = Val(Me.TxtNotePayCash.Text) + Val(Me.TxtNotePayCheck.Text) + Val(Me.TxtPOCash.Text) + Val(Me.TxtRSOCash.Text)
        Me.TxtOutDebt.Text = Val(Me.TxtPODebt.Text) + Val(Me.TxtRSODebt.Text)
        Me.TxtOut.Text = Val(Me.TxtOutCash.Text) + Val(Me.TxtOutDebt.Text)

        Me.TxtWinLoose.Text = Val(Me.TxtIN.Text) - Val(Me.TxtOut.Text)
        If Me.TxtWinLoose.Text.Contains("-") Then
            Me.TxtWinLoose.Text = Me.TxtWinLoose.Text.Remove(Me.TxtWinLoose.Text.IndexOf("-"), 1)
            Me.TxtWinLoose.BackColor = Color.Red
        Else
            Me.TxtWinLoose.BackColor = Color.Green
        End If
    End Sub

    Private Sub TTimer_Tick(sender As Object, e As EventArgs) Handles TTimer.Tick
        FillData()
    End Sub

    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TTimer.Start()
        datatimer.Enabled = True
    End Sub

    Private Sub datatimer_Tick(sender As Object, e As EventArgs) Handles datatimer.Tick
        FillData()
    End Sub

End Class
