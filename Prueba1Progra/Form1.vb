Public Class Form1
    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        txtColor.BackColor = Color.Red
    End Sub

    Private Sub txtBlue_Click(sender As Object, e As EventArgs) Handles txtBlue.Click
        txtColor.BackColor = Color.Blue
    End Sub

    Private Sub btnAmarillo_Click(sender As Object, e As EventArgs) Handles btnAmarillo.Click
        txtColor.BackColor = Color.Yellow
    End Sub

    Private Sub btnRosado_Click(sender As Object, e As EventArgs) Handles btnRosado.Click
        txtColor.BackColor = Color.Pink
    End Sub

    Private Sub btnMarrón_Click(sender As Object, e As EventArgs) Handles btnMarrón.Click
        txtColor.BackColor = Color.Brown
    End Sub
End Class
