<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sampleSelectionForm
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
        Me.projectDataIPDTabControl = New System.Windows.Forms.TabControl()
        Me.projectNumberPage = New System.Windows.Forms.TabPage()
        Me.importProjectNumbersIPDButton = New System.Windows.Forms.Button()
        Me.projectNumbersIPDDataGridView = New System.Windows.Forms.DataGridView()
        Me.projectNumbersTable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.projectNumbersIPDLabel = New System.Windows.Forms.Label()
        Me.SampleIDPage = New System.Windows.Forms.TabPage()
        Me.importSampleIDsIPDButton = New System.Windows.Forms.Button()
        Me.sampleIDsIPDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sampleIDsIPDLabel = New System.Windows.Forms.Label()
        Me.projectDataIPDTabControl.SuspendLayout()
        Me.projectNumberPage.SuspendLayout()
        CType(Me.projectNumbersIPDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SampleIDPage.SuspendLayout()
        CType(Me.sampleIDsIPDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'projectDataIPDTabControl
        '
        Me.projectDataIPDTabControl.Controls.Add(Me.projectNumberPage)
        Me.projectDataIPDTabControl.Controls.Add(Me.SampleIDPage)
        Me.projectDataIPDTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.projectDataIPDTabControl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectDataIPDTabControl.Location = New System.Drawing.Point(0, 0)
        Me.projectDataIPDTabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.projectDataIPDTabControl.Name = "projectDataIPDTabControl"
        Me.projectDataIPDTabControl.SelectedIndex = 0
        Me.projectDataIPDTabControl.Size = New System.Drawing.Size(326, 502)
        Me.projectDataIPDTabControl.TabIndex = 1
        Me.projectDataIPDTabControl.TabStop = False
        '
        'projectNumberPage
        '
        Me.projectNumberPage.Controls.Add(Me.importProjectNumbersIPDButton)
        Me.projectNumberPage.Controls.Add(Me.projectNumbersIPDDataGridView)
        Me.projectNumberPage.Controls.Add(Me.projectNumbersIPDLabel)
        Me.projectNumberPage.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectNumberPage.Location = New System.Drawing.Point(4, 28)
        Me.projectNumberPage.Margin = New System.Windows.Forms.Padding(4)
        Me.projectNumberPage.Name = "projectNumberPage"
        Me.projectNumberPage.Padding = New System.Windows.Forms.Padding(4)
        Me.projectNumberPage.Size = New System.Drawing.Size(318, 470)
        Me.projectNumberPage.TabIndex = 0
        Me.projectNumberPage.Text = "Project Number Entry"
        Me.projectNumberPage.UseVisualStyleBackColor = True
        '
        'importProjectNumbersIPDButton
        '
        Me.importProjectNumbersIPDButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.importProjectNumbersIPDButton.Location = New System.Drawing.Point(92, 413)
        Me.importProjectNumbersIPDButton.Name = "importProjectNumbersIPDButton"
        Me.importProjectNumbersIPDButton.Size = New System.Drawing.Size(130, 42)
        Me.importProjectNumbersIPDButton.TabIndex = 2
        Me.importProjectNumbersIPDButton.TabStop = False
        Me.importProjectNumbersIPDButton.Text = "Import"
        Me.importProjectNumbersIPDButton.UseVisualStyleBackColor = True
        '
        'projectNumbersIPDDataGridView
        '
        Me.projectNumbersIPDDataGridView.AllowUserToOrderColumns = True
        Me.projectNumbersIPDDataGridView.AllowUserToResizeColumns = False
        Me.projectNumbersIPDDataGridView.AllowUserToResizeRows = False
        Me.projectNumbersIPDDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.projectNumbersIPDDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.projectNumbersIPDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.projectNumbersIPDDataGridView.ColumnHeadersVisible = False
        Me.projectNumbersIPDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.projectNumbersTable})
        Me.projectNumbersIPDDataGridView.EnableHeadersVisualStyles = False
        Me.projectNumbersIPDDataGridView.Location = New System.Drawing.Point(57, 64)
        Me.projectNumbersIPDDataGridView.MultiSelect = False
        Me.projectNumbersIPDDataGridView.Name = "projectNumbersIPDDataGridView"
        Me.projectNumbersIPDDataGridView.RowHeadersVisible = False
        Me.projectNumbersIPDDataGridView.RowTemplate.Height = 30
        Me.projectNumbersIPDDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.projectNumbersIPDDataGridView.Size = New System.Drawing.Size(201, 336)
        Me.projectNumbersIPDDataGridView.TabIndex = 0
        '
        'projectNumbersTable
        '
        Me.projectNumbersTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.projectNumbersTable.Frozen = True
        Me.projectNumbersTable.HeaderText = "Project Numbers"
        Me.projectNumbersTable.MinimumWidth = 200
        Me.projectNumbersTable.Name = "projectNumbersTable"
        Me.projectNumbersTable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.projectNumbersTable.Width = 200
        '
        'projectNumbersIPDLabel
        '
        Me.projectNumbersIPDLabel.AutoSize = True
        Me.projectNumbersIPDLabel.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectNumbersIPDLabel.Location = New System.Drawing.Point(35, 23)
        Me.projectNumbersIPDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.projectNumbersIPDLabel.Name = "projectNumbersIPDLabel"
        Me.projectNumbersIPDLabel.Size = New System.Drawing.Size(249, 29)
        Me.projectNumbersIPDLabel.TabIndex = 0
        Me.projectNumbersIPDLabel.Text = "Enter Project Number(s)"
        Me.projectNumbersIPDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SampleIDPage
        '
        Me.SampleIDPage.Controls.Add(Me.importSampleIDsIPDButton)
        Me.SampleIDPage.Controls.Add(Me.sampleIDsIPDDataGridView)
        Me.SampleIDPage.Controls.Add(Me.sampleIDsIPDLabel)
        Me.SampleIDPage.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SampleIDPage.Location = New System.Drawing.Point(4, 28)
        Me.SampleIDPage.Margin = New System.Windows.Forms.Padding(4)
        Me.SampleIDPage.Name = "SampleIDPage"
        Me.SampleIDPage.Padding = New System.Windows.Forms.Padding(4)
        Me.SampleIDPage.Size = New System.Drawing.Size(318, 470)
        Me.SampleIDPage.TabIndex = 1
        Me.SampleIDPage.Text = "Sample Number Entry"
        Me.SampleIDPage.UseVisualStyleBackColor = True
        '
        'importSampleIDsIPDButton
        '
        Me.importSampleIDsIPDButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.importSampleIDsIPDButton.Location = New System.Drawing.Point(92, 413)
        Me.importSampleIDsIPDButton.Name = "importSampleIDsIPDButton"
        Me.importSampleIDsIPDButton.Size = New System.Drawing.Size(130, 42)
        Me.importSampleIDsIPDButton.TabIndex = 5
        Me.importSampleIDsIPDButton.Text = "Import"
        Me.importSampleIDsIPDButton.UseVisualStyleBackColor = True
        '
        'sampleIDsIPDDataGridView
        '
        Me.sampleIDsIPDDataGridView.AllowUserToOrderColumns = True
        Me.sampleIDsIPDDataGridView.AllowUserToResizeColumns = False
        Me.sampleIDsIPDDataGridView.AllowUserToResizeRows = False
        Me.sampleIDsIPDDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sampleIDsIPDDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.sampleIDsIPDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sampleIDsIPDDataGridView.ColumnHeadersVisible = False
        Me.sampleIDsIPDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.sampleIDsIPDDataGridView.EnableHeadersVisualStyles = False
        Me.sampleIDsIPDDataGridView.Location = New System.Drawing.Point(57, 64)
        Me.sampleIDsIPDDataGridView.MultiSelect = False
        Me.sampleIDsIPDDataGridView.Name = "sampleIDsIPDDataGridView"
        Me.sampleIDsIPDDataGridView.RowHeadersVisible = False
        Me.sampleIDsIPDDataGridView.RowTemplate.Height = 30
        Me.sampleIDsIPDDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sampleIDsIPDDataGridView.Size = New System.Drawing.Size(201, 336)
        Me.sampleIDsIPDDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sample IDs"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'sampleIDsIPDLabel
        '
        Me.sampleIDsIPDLabel.AutoSize = True
        Me.sampleIDsIPDLabel.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sampleIDsIPDLabel.Location = New System.Drawing.Point(33, 23)
        Me.sampleIDsIPDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sampleIDsIPDLabel.Name = "sampleIDsIPDLabel"
        Me.sampleIDsIPDLabel.Size = New System.Drawing.Size(253, 29)
        Me.sampleIDsIPDLabel.TabIndex = 3
        Me.sampleIDsIPDLabel.Text = "Enter Sample Number(s)"
        Me.sampleIDsIPDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sampleSelectionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(326, 502)
        Me.Controls.Add(Me.projectDataIPDTabControl)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "sampleSelectionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import Sample Data"
        Me.projectDataIPDTabControl.ResumeLayout(False)
        Me.projectNumberPage.ResumeLayout(False)
        Me.projectNumberPage.PerformLayout()
        CType(Me.projectNumbersIPDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SampleIDPage.ResumeLayout(False)
        Me.SampleIDPage.PerformLayout()
        CType(Me.sampleIDsIPDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents projectDataIPDTabControl As System.Windows.Forms.TabControl
    Friend WithEvents projectNumberPage As System.Windows.Forms.TabPage
    Friend WithEvents importProjectNumbersIPDButton As System.Windows.Forms.Button
    Friend WithEvents projectNumbersIPDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents projectNumbersTable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents projectNumbersIPDLabel As System.Windows.Forms.Label
    Friend WithEvents SampleIDPage As System.Windows.Forms.TabPage
    Friend WithEvents importSampleIDsIPDButton As System.Windows.Forms.Button
    Friend WithEvents sampleIDsIPDDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents sampleIDsIPDLabel As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
