<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Web_Scraper
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.lblScraper = New System.Windows.Forms.Label()
        Me.pbarLoad = New System.Windows.Forms.ProgressBar()
        Me.trmSplash = New System.Windows.Forms.Timer(Me.components)
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblLoad = New System.Windows.Forms.Label()
        Me.lblAnktvvk = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.picboxWscraper = New System.Windows.Forms.PictureBox()
        CType(Me.picboxWscraper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeb.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWeb.Location = New System.Drawing.Point(176, 74)
        Me.lblWeb.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(206, 115)
        Me.lblWeb.TabIndex = 0
        Me.lblWeb.Text = "Web "
        '
        'lblScraper
        '
        Me.lblScraper.AutoSize = True
        Me.lblScraper.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScraper.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblScraper.Location = New System.Drawing.Point(270, 172)
        Me.lblScraper.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblScraper.Name = "lblScraper"
        Me.lblScraper.Size = New System.Drawing.Size(346, 115)
        Me.lblScraper.TabIndex = 1
        Me.lblScraper.Text = "Scraper "
        '
        'pbarLoad
        '
        Me.pbarLoad.Enabled = False
        Me.pbarLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbarLoad.Location = New System.Drawing.Point(207, 344)
        Me.pbarLoad.Name = "pbarLoad"
        Me.pbarLoad.Size = New System.Drawing.Size(310, 27)
        Me.pbarLoad.TabIndex = 2
        '
        'trmSplash
        '
        Me.trmSplash.Enabled = True
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Font = New System.Drawing.Font("Bell MT", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPercentage.Location = New System.Drawing.Point(285, 301)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(48, 27)
        Me.lblPercentage.TabIndex = 3
        Me.lblPercentage.Text = "100"
        '
        'lblLoad
        '
        Me.lblLoad.AutoSize = True
        Me.lblLoad.Font = New System.Drawing.Font("Bell MT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLoad.Location = New System.Drawing.Point(328, 303)
        Me.lblLoad.Name = "lblLoad"
        Me.lblLoad.Size = New System.Drawing.Size(118, 25)
        Me.lblLoad.TabIndex = 4
        Me.lblLoad.Text = "% Loading..."
        '
        'lblAnktvvk
        '
        Me.lblAnktvvk.AutoSize = True
        Me.lblAnktvvk.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnktvvk.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAnktvvk.Location = New System.Drawing.Point(632, 441)
        Me.lblAnktvvk.Name = "lblAnktvvk"
        Me.lblAnktvvk.Size = New System.Drawing.Size(69, 18)
        Me.lblAnktvvk.TabIndex = 5
        Me.lblAnktvvk.Text = "AnktVvk"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblVersion.Location = New System.Drawing.Point(317, 389)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(83, 18)
        Me.lblVersion.TabIndex = 6
        Me.lblVersion.Text = "Version 0.0"
        '
        'picboxWscraper
        '
        Me.picboxWscraper.Image = Global.ProjectAnktVvk.My.Resources.Resources.f1__3_
        Me.picboxWscraper.Location = New System.Drawing.Point(142, 168)
        Me.picboxWscraper.Name = "picboxWscraper"
        Me.picboxWscraper.Size = New System.Drawing.Size(147, 148)
        Me.picboxWscraper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxWscraper.TabIndex = 7
        Me.picboxWscraper.TabStop = False
        '
        'Web_Scraper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(713, 468)
        Me.Controls.Add(Me.picboxWscraper)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblAnktvvk)
        Me.Controls.Add(Me.lblLoad)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.pbarLoad)
        Me.Controls.Add(Me.lblScraper)
        Me.Controls.Add(Me.lblWeb)
        Me.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Web_Scraper"
        Me.Text = "Web_Scraper"
        CType(Me.picboxWscraper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWeb As Label
    Friend WithEvents lblScraper As Label
    Friend WithEvents pbarLoad As ProgressBar
    Friend WithEvents trmSplash As Timer
    Friend WithEvents lblPercentage As Label
    Friend WithEvents lblLoad As Label
    Friend WithEvents lblAnktvvk As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents picboxWscraper As PictureBox
End Class
