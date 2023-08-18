Public Class Web_Scraper
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblWeb.Click

    End Sub

    Private Sub Web_Scraper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        trmSplash.Enabled = True
        trmSplash.Start()
        trmSplash.Interval = 10
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblScraper.Click

    End Sub
    Private Sub Web_Scraper_Click(sender As Object, e As EventArgs) Handles Me.Click
        FrmWebScraper.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles trmSplash.Tick
        pbarLoad.Increment(1)
        lblPercentage.Text = pbarLoad.Value
        If (pbarLoad.Value = 100) Then
            trmSplash.Stop()
            FrmWebScraper.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblAnktvvk.Click

    End Sub
End Class