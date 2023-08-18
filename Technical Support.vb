Public Class Technical_Support
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.Show()
        Me.Close()
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnAbout.MouseEnter
        btnAbout.BackColor = Color.SteelBlue
        btnAbout.ForeColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles btnOk.MouseEnter
        btnOk.BackColor = Color.SteelBlue
        btnOk.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnAbout.MouseLeave
        btnAbout.BackColor = Color.Empty
        btnAbout.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnOk.MouseLeave
        btnOk.BackColor = Color.Empty
        btnOk.ForeColor = Color.Black
    End Sub
End Class