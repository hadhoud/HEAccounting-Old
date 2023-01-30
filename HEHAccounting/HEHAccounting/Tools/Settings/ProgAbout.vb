Public Class ProgAbout
    Private Sub ProgAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Version.Text = System.String.Format(Me.Version.Text, Con.Lbl_One_Version, Con.Lbl_Two_Version, Con.Lbl_Year_One_Version, Con.Lbl_Year_Two_Version)
    End Sub
End Class
