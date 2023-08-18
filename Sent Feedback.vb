Public Class Sent_Feedback
    Private Sub Sent_Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        frmfeedback.Show()
        Me.Close()

    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles btnFeedback.MouseEnter
        btnFeedback.BackColor = Color.SteelBlue
        btnFeedback.ForeColor = Color.White

    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles btnFeedback.MouseLeave
        btnFeedback.BackColor = Color.Empty
        btnFeedback.ForeColor = Color.Black

    End Sub



    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnOk.MouseLeave
        btnOk.BackColor = Color.Empty
        btnOk.ForeColor = Color.Black

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnOk.MouseEnter
        btnOk.BackColor = Color.SteelBlue
        btnOk.ForeColor = Color.White
    End Sub
End Class