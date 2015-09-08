<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dataSheetForm
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
        Me.dataSheetDataGridView = New System.Windows.Forms.DataGridView()
        Me.dataSheetSaveButton = New System.Windows.Forms.Button()
        Me.dataSheetTextLabel = New System.Windows.Forms.Label()
        CType(Me.dataSheetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataSheetDataGridView
        '
        Me.dataSheetDataGridView.AllowUserToAddRows = False
        Me.dataSheetDataGridView.AllowUserToDeleteRows = False
        Me.dataSheetDataGridView.AllowUserToOrderColumns = True
        Me.dataSheetDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataSheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataSheetDataGridView.Location = New System.Drawing.Point(12, 41)
        Me.dataSheetDataGridView.Name = "dataSheetDataGridView"
        Me.dataSheetDataGridView.ReadOnly = True
        Me.dataSheetDataGridView.Size = New System.Drawing.Size(888, 437)
        Me.dataSheetDataGridView.TabIndex = 0
        '
        'dataSheetSaveButton
        '
        Me.dataSheetSaveButton.Location = New System.Drawing.Point(740, 484)
        Me.dataSheetSaveButton.Name = "dataSheetSaveButton"
        Me.dataSheetSaveButton.Size = New System.Drawing.Size(160, 35)
        Me.dataSheetSaveButton.TabIndex = 10
        Me.dataSheetSaveButton.Text = "Save Changes"
        Me.dataSheetSaveButton.UseVisualStyleBackColor = True
        '
        'dataSheetTextLabel
        '
        Me.dataSheetTextLabel.AutoSize = True
        Me.dataSheetTextLabel.Location = New System.Drawing.Point(12, 9)
        Me.dataSheetTextLabel.Name = "dataSheetTextLabel"
        Me.dataSheetTextLabel.Size = New System.Drawing.Size(199, 26)
        Me.dataSheetTextLabel.TabIndex = 11
        Me.dataSheetTextLabel.Text = "Enter Sample Weights"
        '
        'dataSheetForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(912, 524)
        Me.Controls.Add(Me.dataSheetTextLabel)
        Me.Controls.Add(Me.dataSheetSaveButton)
        Me.Controls.Add(Me.dataSheetDataGridView)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "dataSheetForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sample Data Sheet"
        CType(Me.dataSheetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dataSheetDataGridView As DataGridView
    Friend WithEvents dataSheetSaveButton As Button
    Friend WithEvents dataSheetTextLabel As Label
End Class
