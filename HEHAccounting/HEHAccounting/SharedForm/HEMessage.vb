Public Class HEMessage
    Sub New(ByVal MessageStr As String, ByVal OkOrYes As String, Optional Error_fl As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()
        Me.lblmessage.Text = MessageStr
        If OkOrYes = "Ok" Then
            Me.Btnyes.Text = Con.Lbl_OK
        Else
            Me.Btnyes.Text = Con.Lbl_Yes
        End If
        Me.Btnno.Text = Con.Lbl_No
        If Error_fl Then
            Me.lblmessage.ForeColor = Color.Red
        End If
        If BoolLTRLanguage Then
            ChangeToEng()
        End If

    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
    End Sub
    Private Sub Btnyes_Click(sender As Object, e As EventArgs) Handles Btnyes.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub Btnno_Click(sender As Object, e As EventArgs) Handles Btnno.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub
    Private Sub HEMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitiateTitleForm(Me, True)
        If Me.Btnno.Visible = False Then
            Me.TableLayoutPanel1.SetColumnSpan(Me.Btnyes, 2)
        End If

    End Sub
End Class