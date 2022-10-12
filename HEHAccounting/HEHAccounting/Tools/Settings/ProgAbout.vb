Public Class ProgAbout
    Private Sub ProgAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Version.Text = System.String.Format(Me.Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    End Sub
End Class
