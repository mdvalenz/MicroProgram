<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMediaQCForm
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
        Me.addMediaNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'addMediaNameLabel
        '
        Me.addMediaNameLabel.AutoSize = True
        Me.addMediaNameLabel.Location = New System.Drawing.Point(12, 22)
        Me.addMediaNameLabel.Name = "addMediaNameLabel"
        Me.addMediaNameLabel.Size = New System.Drawing.Size(122, 26)
        Me.addMediaNameLabel.TabIndex = 1
        Me.addMediaNameLabel.Text = "Media Name"
        '
        'addMediaQCForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1349, 958)
        Me.Controls.Add(Me.addMediaNameLabel)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "addMediaQCForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter Media QC Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addMediaNameLabel As Label
End Class
