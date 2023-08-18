<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.picAbout = New System.Windows.Forms.PictureBox()
        Me.rtbAbout = New System.Windows.Forms.RichTextBox()
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnOK.Location = New System.Drawing.Point(455, 303)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'picAbout
        '
        Me.picAbout.Image = CType(resources.GetObject("picAbout.Image"), System.Drawing.Image)
        Me.picAbout.Location = New System.Drawing.Point(12, 12)
        Me.picAbout.Name = "picAbout"
        Me.picAbout.Size = New System.Drawing.Size(121, 274)
        Me.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picAbout.TabIndex = 2
        Me.picAbout.TabStop = False
        '
        'rtbAbout
        '
        Me.rtbAbout.BackColor = System.Drawing.SystemColors.Control
        Me.rtbAbout.Location = New System.Drawing.Point(141, 13)
        Me.rtbAbout.Name = "rtbAbout"
        Me.rtbAbout.ReadOnly = True
        Me.rtbAbout.Size = New System.Drawing.Size(389, 273)
        Me.rtbAbout.TabIndex = 3
        Me.rtbAbout.Text = resources.GetString("rtbAbout.Text")
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 338)
        Me.Controls.Add(Me.rtbAbout)
        Me.Controls.Add(Me.picAbout)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "About"
        Me.Text = "About Us"
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents picAbout As System.Windows.Forms.PictureBox
    Friend WithEvents rtbAbout As RichTextBox
End Class
