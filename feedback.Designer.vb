<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfeedback
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
        Me.lblEnterfeedback = New System.Windows.Forms.Label()
        Me.txtFeedback = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterfeedback
        '
        Me.lblEnterfeedback.AutoSize = True
        Me.lblEnterfeedback.Location = New System.Drawing.Point(12, 31)
        Me.lblEnterfeedback.Name = "lblEnterfeedback"
        Me.lblEnterfeedback.Size = New System.Drawing.Size(77, 13)
        Me.lblEnterfeedback.TabIndex = 0
        Me.lblEnterfeedback.Text = "Enter Feeback"
        '
        'txtFeedback
        '
        Me.txtFeedback.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtFeedback.Location = New System.Drawing.Point(12, 57)
        Me.txtFeedback.Multiline = True
        Me.txtFeedback.Name = "txtFeedback"
        Me.txtFeedback.Size = New System.Drawing.Size(260, 104)
        Me.txtFeedback.TabIndex = 1
        Me.txtFeedback.Text = "Enter Feedback here"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.Control
        Me.btnSubmit.Location = New System.Drawing.Point(101, 187)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'frmfeedback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 234)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtFeedback)
        Me.Controls.Add(Me.lblEnterfeedback)
        Me.Name = "frmfeedback"
        Me.Text = "feedback"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnterfeedback As System.Windows.Forms.Label
    Friend WithEvents txtFeedback As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
End Class
