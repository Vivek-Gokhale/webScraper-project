Public Class About

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnOK_MouseEnter(sender As Object, e As EventArgs) Handles btnOK.MouseEnter
        btnOK.BackColor = Color.SteelBlue
        btnOK.ForeColor = Color.White
    End Sub

    Private Sub btnOK_MouseLeave(sender As Object, e As EventArgs) Handles btnOK.MouseLeave
        btnOK.BackColor = Color.Empty
        btnOK.ForeColor = Color.Black
    End Sub
End Class