<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mediaQCForm
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
        Me.mediaSelectLabel = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.selectLotNumberLabel = New System.Windows.Forms.Label()
        Me.mediaSearchButton = New System.Windows.Forms.Button()
        Me.mediaClearButton = New System.Windows.Forms.Button()
        Me.mediaSaveButton = New System.Windows.Forms.Button()
        Me.filterListLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mediaSelectLabel
        '
        Me.mediaSelectLabel.AutoSize = True
        Me.mediaSelectLabel.Location = New System.Drawing.Point(7, 60)
        Me.mediaSelectLabel.Name = "mediaSelectLabel"
        Me.mediaSelectLabel.Size = New System.Drawing.Size(121, 26)
        Me.mediaSelectLabel.TabIndex = 0
        Me.mediaSelectLabel.Text = "Select media"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 90)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 34)
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(12, 170)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 34)
        Me.ComboBox2.TabIndex = 3
        '
        'selectLotNumberLabel
        '
        Me.selectLotNumberLabel.AutoSize = True
        Me.selectLotNumberLabel.Location = New System.Drawing.Point(7, 140)
        Me.selectLotNumberLabel.Name = "selectLotNumberLabel"
        Me.selectLotNumberLabel.Size = New System.Drawing.Size(163, 26)
        Me.selectLotNumberLabel.TabIndex = 2
        Me.selectLotNumberLabel.Text = "Select lot number"
        '
        'mediaSearchButton
        '
        Me.mediaSearchButton.Location = New System.Drawing.Point(132, 220)
        Me.mediaSearchButton.Name = "mediaSearchButton"
        Me.mediaSearchButton.Size = New System.Drawing.Size(80, 35)
        Me.mediaSearchButton.TabIndex = 4
        Me.mediaSearchButton.Text = "Search"
        Me.mediaSearchButton.UseVisualStyleBackColor = True
        '
        'mediaClearButton
        '
        Me.mediaClearButton.Location = New System.Drawing.Point(12, 220)
        Me.mediaClearButton.Name = "mediaClearButton"
        Me.mediaClearButton.Size = New System.Drawing.Size(80, 35)
        Me.mediaClearButton.TabIndex = 5
        Me.mediaClearButton.Text = "Clear"
        Me.mediaClearButton.UseVisualStyleBackColor = True
        '
        'mediaSaveButton
        '
        Me.mediaSaveButton.Location = New System.Drawing.Point(12, 286)
        Me.mediaSaveButton.Name = "mediaSaveButton"
        Me.mediaSaveButton.Size = New System.Drawing.Size(200, 35)
        Me.mediaSaveButton.TabIndex = 6
        Me.mediaSaveButton.Text = "Save Changes"
        Me.mediaSaveButton.UseVisualStyleBackColor = True
        '
        'filterListLabel
        '
        Me.filterListLabel.AutoSize = True
        Me.filterListLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterListLabel.Location = New System.Drawing.Point(19, 15)
        Me.filterListLabel.Name = "filterListLabel"
        Me.filterListLabel.Size = New System.Drawing.Size(179, 26)
        Me.filterListLabel.TabIndex = 7
        Me.filterListLabel.Text = "Filter Media QC List"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(223, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(720, 345)
        Me.DataGridView1.TabIndex = 8
        '
        'mediaQCForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(943, 345)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.filterListLabel)
        Me.Controls.Add(Me.mediaSaveButton)
        Me.Controls.Add(Me.mediaClearButton)
        Me.Controls.Add(Me.mediaSearchButton)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.selectLotNumberLabel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.mediaSelectLabel)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "mediaQCForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Media QC Results"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mediaSelectLabel As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents selectLotNumberLabel As Label
    Friend WithEvents mediaSearchButton As Button
    Friend WithEvents mediaClearButton As Button
    Friend WithEvents mediaSaveButton As Button
    Friend WithEvents filterListLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
