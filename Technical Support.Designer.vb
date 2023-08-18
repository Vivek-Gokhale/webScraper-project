<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Technical_Support
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Technical_Support))
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.rtbTecsupport = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.SystemColors.Control
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(40, 205)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(108, 41)
        Me.btnAbout.TabIndex = 1
        Me.btnAbout.Text = "About Us"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.Control
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(337, 203)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(97, 41)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'rtbTecsupport
        '
        Me.rtbTecsupport.BackColor = System.Drawing.SystemColors.Control
        Me.rtbTecsupport.Location = New System.Drawing.Point(9, 10)
        Me.rtbTecsupport.Name = "rtbTecsupport"
        Me.rtbTecsupport.Size = New System.Drawing.Size(490, 160)
        Me.rtbTecsupport.TabIndex = 3
        Me.rtbTecsupport.Text = resources.GetString("rtbTecsupport.Text")
        '
        'Technical_Support
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 285)
        Me.Controls.Add(Me.rtbTecsupport)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnAbout)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Technical_Support"
        Me.Text = "Technical_Support"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents rtbTecsupport As RichTextBox
End Class
