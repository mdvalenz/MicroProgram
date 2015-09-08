<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pathAnalysisForm
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
        Me.saveAndCloseButton = New System.Windows.Forms.Button()
        Me.prefixListEPLDataGridView = New System.Windows.Forms.DataGridView()
        Me.prefixList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pathAnalysisPALabel = New System.Windows.Forms.Label()
        CType(Me.prefixListEPLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'saveAndCloseButton
        '
        Me.saveAndCloseButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveAndCloseButton.Location = New System.Drawing.Point(112, 397)
        Me.saveAndCloseButton.Name = "saveAndCloseButton"
        Me.saveAndCloseButton.Size = New System.Drawing.Size(201, 42)
        Me.saveAndCloseButton.TabIndex = 11
        Me.saveAndCloseButton.TabStop = False
        Me.saveAndCloseButton.Text = "Save and Close"
        Me.saveAndCloseButton.UseVisualStyleBackColor = True
        '
        'prefixListEPLDataGridView
        '
        Me.prefixListEPLDataGridView.AllowUserToOrderColumns = True
        Me.prefixListEPLDataGridView.AllowUserToResizeColumns = False
        Me.prefixListEPLDataGridView.AllowUserToResizeRows = False
        Me.prefixListEPLDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.prefixListEPLDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.prefixListEPLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.prefixListEPLDataGridView.ColumnHeadersVisible = False
        Me.prefixListEPLDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.prefixList})
        Me.prefixListEPLDataGridView.EnableHeadersVisualStyles = False
        Me.prefixListEPLDataGridView.Location = New System.Drawing.Point(112, 56)
        Me.prefixListEPLDataGridView.MultiSelect = False
        Me.prefixListEPLDataGridView.Name = "prefixListEPLDataGridView"
        Me.prefixListEPLDataGridView.RowHeadersVisible = False
        Me.prefixListEPLDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.prefixListEPLDataGridView.RowTemplate.Height = 30
        Me.prefixListEPLDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.prefixListEPLDataGridView.Size = New System.Drawing.Size(201, 336)
        Me.prefixListEPLDataGridView.TabIndex = 9
        '
        'prefixList
        '
        Me.prefixList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.prefixList.Frozen = True
        Me.prefixList.HeaderText = "Prefixes"
        Me.prefixList.MinimumWidth = 200
        Me.prefixList.Name = "prefixList"
        Me.prefixList.Width = 200
        '
        'pathAnalysisPALabel
        '
        Me.pathAnalysisPALabel.AutoSize = True
        Me.pathAnalysisPALabel.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pathAnalysisPALabel.Location = New System.Drawing.Point(13, 9)
        Me.pathAnalysisPALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.pathAnalysisPALabel.Name = "pathAnalysisPALabel"
        Me.pathAnalysisPALabel.Size = New System.Drawing.Size(407, 29)
        Me.pathAnalysisPALabel.TabIndex = 10
        Me.pathAnalysisPALabel.Text = "Edit the analysis codes below as needed"
        Me.pathAnalysisPALabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pathAnalysisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 451)
        Me.Controls.Add(Me.saveAndCloseButton)
        Me.Controls.Add(Me.prefixListEPLDataGridView)
        Me.Controls.Add(Me.pathAnalysisPALabel)
        Me.Name = "pathAnalysisForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pathogen Analysis Codes"
        CType(Me.prefixListEPLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents saveAndCloseButton As Button
    Friend WithEvents prefixListEPLDataGridView As DataGridView
    Friend WithEvents prefixList As DataGridViewTextBoxColumn
    Friend WithEvents pathAnalysisPALabel As Label
End Class
