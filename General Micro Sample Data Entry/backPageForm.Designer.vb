<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backPageForm
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
        Me.sampleNumberSTLabel = New System.Windows.Forms.Label()
        Me.projectNumberSTLabel = New System.Windows.Forms.Label()
        Me.sampleNumbersSTCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.mediaSaveButton = New System.Windows.Forms.Button()
        Me.projectNumberSTListBox = New System.Windows.Forms.ListBox()
        Me.dateReceivedTextLabel = New System.Windows.Forms.Label()
        Me.dateReceivedLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.enterResultsButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sampleNumberSTLabel
        '
        Me.sampleNumberSTLabel.AutoSize = True
        Me.sampleNumberSTLabel.Location = New System.Drawing.Point(12, 213)
        Me.sampleNumberSTLabel.Name = "sampleNumberSTLabel"
        Me.sampleNumberSTLabel.Size = New System.Drawing.Size(158, 26)
        Me.sampleNumberSTLabel.TabIndex = 6
        Me.sampleNumberSTLabel.Text = "Sample Numbers"
        '
        'projectNumberSTLabel
        '
        Me.projectNumberSTLabel.AutoSize = True
        Me.projectNumberSTLabel.Location = New System.Drawing.Point(12, 9)
        Me.projectNumberSTLabel.Name = "projectNumberSTLabel"
        Me.projectNumberSTLabel.Size = New System.Drawing.Size(155, 26)
        Me.projectNumberSTLabel.TabIndex = 4
        Me.projectNumberSTLabel.Text = "Project Numbers"
        '
        'sampleNumbersSTCheckedListBox
        '
        Me.sampleNumbersSTCheckedListBox.FormattingEnabled = True
        Me.sampleNumbersSTCheckedListBox.Location = New System.Drawing.Point(17, 242)
        Me.sampleNumbersSTCheckedListBox.Name = "sampleNumbersSTCheckedListBox"
        Me.sampleNumbersSTCheckedListBox.Size = New System.Drawing.Size(160, 172)
        Me.sampleNumbersSTCheckedListBox.TabIndex = 8
        '
        'mediaSaveButton
        '
        Me.mediaSaveButton.Location = New System.Drawing.Point(17, 430)
        Me.mediaSaveButton.Name = "mediaSaveButton"
        Me.mediaSaveButton.Size = New System.Drawing.Size(160, 35)
        Me.mediaSaveButton.TabIndex = 9
        Me.mediaSaveButton.Text = "Save Changes"
        Me.mediaSaveButton.UseVisualStyleBackColor = True
        '
        'projectNumberSTListBox
        '
        Me.projectNumberSTListBox.FormattingEnabled = True
        Me.projectNumberSTListBox.ItemHeight = 26
        Me.projectNumberSTListBox.Location = New System.Drawing.Point(17, 38)
        Me.projectNumberSTListBox.Name = "projectNumberSTListBox"
        Me.projectNumberSTListBox.Size = New System.Drawing.Size(160, 160)
        Me.projectNumberSTListBox.TabIndex = 10
        '
        'dateReceivedTextLabel
        '
        Me.dateReceivedTextLabel.AutoSize = True
        Me.dateReceivedTextLabel.Location = New System.Drawing.Point(190, 9)
        Me.dateReceivedTextLabel.Name = "dateReceivedTextLabel"
        Me.dateReceivedTextLabel.Size = New System.Drawing.Size(138, 26)
        Me.dateReceivedTextLabel.TabIndex = 11
        Me.dateReceivedTextLabel.Text = "Date Received:"
        '
        'dateReceivedLabel
        '
        Me.dateReceivedLabel.AutoSize = True
        Me.dateReceivedLabel.Location = New System.Drawing.Point(334, 9)
        Me.dateReceivedLabel.Name = "dateReceivedLabel"
        Me.dateReceivedLabel.Size = New System.Drawing.Size(68, 26)
        Me.dateReceivedLabel.TabIndex = 12
        Me.dateReceivedLabel.Text = "Label1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(195, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(720, 468)
        Me.DataGridView1.TabIndex = 13
        '
        'enterResultsButton
        '
        Me.enterResultsButton.Location = New System.Drawing.Point(17, 471)
        Me.enterResultsButton.Name = "enterResultsButton"
        Me.enterResultsButton.Size = New System.Drawing.Size(160, 35)
        Me.enterResultsButton.TabIndex = 14
        Me.enterResultsButton.Text = "Enter Results"
        Me.enterResultsButton.UseVisualStyleBackColor = True
        '
        'backPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(927, 518)
        Me.Controls.Add(Me.enterResultsButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dateReceivedLabel)
        Me.Controls.Add(Me.dateReceivedTextLabel)
        Me.Controls.Add(Me.projectNumberSTListBox)
        Me.Controls.Add(Me.mediaSaveButton)
        Me.Controls.Add(Me.sampleNumbersSTCheckedListBox)
        Me.Controls.Add(Me.sampleNumberSTLabel)
        Me.Controls.Add(Me.projectNumberSTLabel)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "backPageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sample Tracking"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sampleNumberSTLabel As Label
    Friend WithEvents projectNumberSTLabel As Label
    Friend WithEvents sampleNumbersSTCheckedListBox As CheckedListBox
    Friend WithEvents mediaSaveButton As Button
    Friend WithEvents projectNumberSTListBox As ListBox
    Friend WithEvents dateReceivedTextLabel As Label
    Friend WithEvents dateReceivedLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents enterResultsButton As Button
End Class
