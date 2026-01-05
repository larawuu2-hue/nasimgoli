Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DialogResult = ColorDialog1.ShowDialog()
        If DialogResult = DialogResult.OK Then

        End If
        Button1.BackColor = ColorDialog1.Color
    End Sub
End Class
