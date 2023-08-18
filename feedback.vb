Imports System.Data.OleDb
Public Class frmfeedback
    Dim con As New OleDbConnection
    Dim cmdInsert As New OleDbCommand
    Dim result As Integer

    Private Sub feedback_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        btnSubmit.Visible = True
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\feeback.accdb"
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Try

            con.Open()

            cmdInsert = New OleDbCommand("insert into Feedback values ('" & txtFeedback.Text & "')", con)

            result = cmdInsert.ExecuteNonQuery
            If result = 1 Then
                MessageBox.Show("Feedback submitted successfully.", "feedback", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error Occured.", "feedback", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try


    End Sub




    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtFeedback.MouseClick
        txtFeedback.Clear()
        txtFeedback.ForeColor = Color.Black
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFeedback.TextChanged

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btnSubmit.MouseEnter
        btnSubmit.BackColor = Color.SteelBlue
        btnSubmit.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btnSubmit.MouseLeave
        btnSubmit.BackColor = Color.Empty
        btnSubmit.ForeColor = Color.Black
    End Sub
End Class