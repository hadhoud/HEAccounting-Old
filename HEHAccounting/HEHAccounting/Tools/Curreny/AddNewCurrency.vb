Public Class AddNewCurrency
    Public BoolForEdit As Boolean = False
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
    End Sub

    Private Sub AddNewCurrency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not BoolForEdit Then
            FormClear()
        End If
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.BtnSaveAndNew.Text = LoStrId.LblSaveNew
        Me.BtnClose.Text = LoStrId.LblClose
        Me.Text = LoStrId.LblAddCurreny
    End Sub


    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Private Sub FormClear()
        Me.TxtCurrName.Clear()
        Me.TxtLatinName.Clear()
        Me.TxtCurrSym.Clear()
        Me.TxtLatinSymb.Clear()
        Me.UpDownFloat.Value = 0
        Me.RadioEqual.CheckState = CheckState.Checked
        Me.TxtPartDecisionValue.Value = 0
        Me.TxtPartLatinName.Clear()
        Me.TxtPartName.Clear()

        GetID()
    End Sub
    Private Sub GetID()
        Dim Param(0) As String
        Param(0) = "@VTableName , Currency"
        Me.TxtCode.Text = GetScalarProcedure("GetID", Param)
    End Sub
    Private Function FormCheck() As Boolean
        If Me.TxtCurrName.Text.Trim.Length = 0 Or Me.TxtCurrSym.Text.Trim.Length = 0 Or
            TxtPartName.Text.Trim.Length = 0 Or Me.TxtPartDecisionValue.Value = "0" Then
            Return False
        End If
        If BoolForcingEnterCurrencyNameLatin Then
            If Me.TxtLatinName.Text.Trim.Length = 0 Then
                Return False
            End If
        End If
        If BoolForcingEnterCurrencySymbLatin Then
            If Me.TxtLatinSymb.Text.Trim.Length = 0 Then
                Return False
            End If
        End If
        If BoolForcingEnterCurrencyPartLatin Then
            If Me.TxtPartLatinName.Text.Trim.Length = 0 Then
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If FormCheck() Then
            If MessageShowAsk(IIf(BtnSaveAndNew.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                Dim Param(9) As String
                Param(0) = "@ICurrencyID , " & Me.TxtCode.Text
                Param(1) = "@VName , " & Evalquote(Me.TxtCurrName.Text)
                Param(2) = "@VSymb , " & Evalquote(Me.TxtCurrSym.Text)
                Param(3) = "@VPartName , " & Evalquote(Me.TxtPartName.Text)
                Param(4) = "@FPartPrecision , " & Me.TxtPartDecisionValue.Value
                Param(5) = "@VLatinName , " & Evalquote(Me.TxtLatinName.Text)
                Param(6) = "@VLatinPartName , " & Evalquote(Me.TxtPartLatinName.Text)
                Param(7) = "@VLatinSymb , " & Evalquote(Me.TxtLatinSymb.Text)
                Param(8) = "@FCurrFloat , " & Me.UpDownFloat.Value
                If RadioEqual.IsChecked Then
                    Param(9) = "@CInitialState ,E"
                ElseIf Me.RadioLarge.IsChecked Then
                    Param(9) = "@CInitialState ,L"
                ElseIf Me.RadioSmall.IsChecked Then
                    Param(9) = "@CInitialState ,S"
                End If
                If BtnSaveAndNew.Tag = "Save" Then
                    ExecuteProcedureWithParameters("InsertNewCurrency", Param)
                    FormClear()
                    Home.ReloadCurrency()
                ElseIf BtnSaveAndNew.Tag = "Edit" Then
                    'ExecuteProcedureWithParameters("UpdateItem", Param)
                    'MessageShowInfo(Con.Msg_Item_Has_Been_Updated)
                    'Me.AddNewPages.SelectedPage = Me.PageGeneral

                End If
            End If
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub
End Class
