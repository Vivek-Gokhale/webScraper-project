<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sent_Feedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sent_Feedback))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnFeedback = New System.Windows.Forms.Button()
        Me.rtbSentfeedback = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.Control
        Me.btnOk.Location = New System.Drawing.Point(314, 170)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 39)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnFeedback
        '
        Me.btnFeedback.BackColor = System.Drawing.SystemColors.Control
        Me.btnFeedback.Location = New System.Drawing.Point(25, 172)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(121, 39)
        Me.btnFeedback.TabIndex = 2
        Me.btnFeedback.Text = "Feedback Form"
        Me.btnFeedback.UseVisualStyleBackColor = False
        '
        'rtbSentfeedback
        '
        Me.rtbSentfeedback.BackColor = System.Drawing.SystemColors.Control
        Me.rtbSentfeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbSentfeedback.Location = New System.Drawing.Point(10, 8)
        Me.rtbSentfeedback.Name = "rtbSentfeedback"
        Me.rtbSentfeedback.Size = New System.Drawing.Size(445, 150)
        Me.rtbSentfeedback.TabIndex = 3
        Me.rtbSentfeedback.Text = resources.GetString("rtbSentfeedback.Text")
        '
        'Sent_Feedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 245)
        Me.Controls.Add(Me.rtbSentfeedback)
        Me.Controls.Add(Me.btnFeedback)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "Sent_Feedback"
        Me.Text = "Sent_Feedback"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As Button
    Friend WithEvents btnFeedback As Button
    Friend WithEvents rtbSentfeedback As RichTextBox
End Class
