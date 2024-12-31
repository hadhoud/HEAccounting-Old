Imports Telerik.WinControls.UI

Public Class InvoiceAttachments
    Public InvNum As String = ""
    Public InvoiceDescription As String = ""
    Public enableBtnSaveAttachments As Boolean = True
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
    End Sub
    Private Sub InvoiceAttachments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormClear()
    End Sub
    Private Sub ChangeToEng()
        RightToLeft = RightToLeft.No
        LblInvID.Text = LoStrId.LblInvID
        BtnSaveAttachments.Text = LoStrId.LblSaveNew
    End Sub
    Private Sub FormClear()
        TxtInvID.Text = InvNum
        TxtInvoiceDesc.Text = InvoiceDescription
        BtnSaveAttachments.Enabled = enableBtnSaveAttachments
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnSaveAttachments.Click
        InvoiceDescription = Me.TxtInvoiceDesc.Text.Trim()
    End Sub
End Class
