<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class authorizedPersonsForm
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
        Me.nameAPLabel = New System.Windows.Forms.Label()
        Me.selectNameAPComboBox = New System.Windows.Forms.ComboBox()
        Me.resetFormAPButton = New System.Windows.Forms.Button()
        Me.saveChangesAPButton = New System.Windows.Forms.Button()
        Me.closeAPButton = New System.Windows.Forms.Button()
        Me.clearFormAPButton = New System.Windows.Forms.Button()
        Me.firstNameAPTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameAPTextBox2 = New System.Windows.Forms.TextBox()
        Me.userNameAPTextBox = New System.Windows.Forms.TextBox()
        Me.adminAPCheckBox = New System.Windows.Forms.CheckBox()
        Me.emailAPTextBox = New System.Windows.Forms.TextBox()
        Me.emailSuffixAPLabel = New System.Windows.Forms.Label()
        Me.departmentAPTextBox = New System.Windows.Forms.TextBox()
        Me.prefixCodesAPCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.firstReviewAPLabel = New System.Windows.Forms.Label()
        Me.firstReviewerCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameAPLabel
        '
        Me.nameAPLabel.AutoSize = True
        Me.nameAPLabel.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameAPLabel.Location = New System.Drawing.Point(12, 58)
        Me.nameAPLabel.Name = "nameAPLabel"
        Me.nameAPLabel.Size = New System.Drawing.Size(641, 29)
        Me.nameAPLabel.TabIndex = 0
        Me.nameAPLabel.Text = "Please select a name to edit or type below to create a new entry"
        '
        'selectNameAPComboBox
        '
        Me.selectNameAPComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.selectNameAPComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.selectNameAPComboBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectNameAPComboBox.FormattingEnabled = True
        Me.selectNameAPComboBox.Items.AddRange(New Object() {"Mario Valenzuela", "Christine Willmore", "Bob Takens"})
        Me.selectNameAPComboBox.Location = New System.Drawing.Point(17, 17)
        Me.selectNameAPComboBox.Name = "selectNameAPComboBox"
        Me.selectNameAPComboBox.Size = New System.Drawing.Size(278, 34)
        Me.selectNameAPComboBox.TabIndex = 1
        '
        'resetFormAPButton
        '
        Me.resetFormAPButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetFormAPButton.Location = New System.Drawing.Point(301, 10)
        Me.resetFormAPButton.Name = "resetFormAPButton"
        Me.resetFormAPButton.Size = New System.Drawing.Size(172, 43)
        Me.resetFormAPButton.TabIndex = 2
        Me.resetFormAPButton.Text = "Reset Form "
        Me.resetFormAPButton.UseVisualStyleBackColor = True
        '
        'saveChangesAPButton
        '
        Me.saveChangesAPButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveChangesAPButton.Location = New System.Drawing.Point(245, 408)
        Me.saveChangesAPButton.Name = "saveChangesAPButton"
        Me.saveChangesAPButton.Size = New System.Drawing.Size(172, 43)
        Me.saveChangesAPButton.TabIndex = 3
        Me.saveChangesAPButton.Text = "Save Changes"
        Me.saveChangesAPButton.UseVisualStyleBackColor = True
        '
        'closeAPButton
        '
        Me.closeAPButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeAPButton.Location = New System.Drawing.Point(423, 408)
        Me.closeAPButton.Name = "closeAPButton"
        Me.closeAPButton.Size = New System.Drawing.Size(172, 43)
        Me.closeAPButton.TabIndex = 4
        Me.closeAPButton.Text = "Close"
        Me.closeAPButton.UseVisualStyleBackColor = True
        '
        'clearFormAPButton
        '
        Me.clearFormAPButton.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearFormAPButton.Location = New System.Drawing.Point(67, 408)
        Me.clearFormAPButton.Name = "clearFormAPButton"
        Me.clearFormAPButton.Size = New System.Drawing.Size(172, 43)
        Me.clearFormAPButton.TabIndex = 5
        Me.clearFormAPButton.Text = "Clear Form"
        Me.clearFormAPButton.UseVisualStyleBackColor = True
        '
        'firstNameAPTextBox
        '
        Me.firstNameAPTextBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNameAPTextBox.Location = New System.Drawing.Point(17, 116)
        Me.firstNameAPTextBox.Name = "firstNameAPTextBox"
        Me.firstNameAPTextBox.Size = New System.Drawing.Size(200, 33)
        Me.firstNameAPTextBox.TabIndex = 6
        Me.firstNameAPTextBox.Text = "First Name"
        Me.firstNameAPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lastNameAPTextBox2
        '
        Me.lastNameAPTextBox2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNameAPTextBox2.Location = New System.Drawing.Point(230, 116)
        Me.lastNameAPTextBox2.Name = "lastNameAPTextBox2"
        Me.lastNameAPTextBox2.Size = New System.Drawing.Size(200, 33)
        Me.lastNameAPTextBox2.TabIndex = 7
        Me.lastNameAPTextBox2.Text = "Last Name"
        Me.lastNameAPTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userNameAPTextBox
        '
        Me.userNameAPTextBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userNameAPTextBox.Location = New System.Drawing.Point(444, 116)
        Me.userNameAPTextBox.Name = "userNameAPTextBox"
        Me.userNameAPTextBox.Size = New System.Drawing.Size(200, 33)
        Me.userNameAPTextBox.TabIndex = 8
        Me.userNameAPTextBox.Text = "User Name"
        Me.userNameAPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'adminAPCheckBox
        '
        Me.adminAPCheckBox.AutoSize = True
        Me.adminAPCheckBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminAPCheckBox.Location = New System.Drawing.Point(425, 207)
        Me.adminAPCheckBox.Name = "adminAPCheckBox"
        Me.adminAPCheckBox.Size = New System.Drawing.Size(227, 30)
        Me.adminAPCheckBox.TabIndex = 9
        Me.adminAPCheckBox.Text = "Program Administrator"
        Me.adminAPCheckBox.UseVisualStyleBackColor = True
        '
        'emailAPTextBox
        '
        Me.emailAPTextBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailAPTextBox.Location = New System.Drawing.Point(17, 168)
        Me.emailAPTextBox.Name = "emailAPTextBox"
        Me.emailAPTextBox.Size = New System.Drawing.Size(200, 33)
        Me.emailAPTextBox.TabIndex = 10
        Me.emailAPTextBox.Text = "E-Mail"
        Me.emailAPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'emailSuffixAPLabel
        '
        Me.emailSuffixAPLabel.AutoSize = True
        Me.emailSuffixAPLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailSuffixAPLabel.Location = New System.Drawing.Point(223, 171)
        Me.emailSuffixAPLabel.Name = "emailSuffixAPLabel"
        Me.emailSuffixAPLabel.Size = New System.Drawing.Size(137, 26)
        Me.emailSuffixAPLabel.TabIndex = 11
        Me.emailSuffixAPLabel.Text = "@TheNFL.com"
        '
        'departmentAPTextBox
        '
        Me.departmentAPTextBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentAPTextBox.Location = New System.Drawing.Point(444, 168)
        Me.departmentAPTextBox.Name = "departmentAPTextBox"
        Me.departmentAPTextBox.Size = New System.Drawing.Size(200, 33)
        Me.departmentAPTextBox.TabIndex = 12
        Me.departmentAPTextBox.Text = "Department"
        Me.departmentAPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'prefixCodesAPCheckedListBox
        '
        Me.prefixCodesAPCheckedListBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prefixCodesAPCheckedListBox.FormattingEnabled = True
        Me.prefixCodesAPCheckedListBox.Location = New System.Drawing.Point(445, 16)
        Me.prefixCodesAPCheckedListBox.Name = "prefixCodesAPCheckedListBox"
        Me.prefixCodesAPCheckedListBox.Size = New System.Drawing.Size(186, 144)
        Me.prefixCodesAPCheckedListBox.TabIndex = 13
        '
        'firstReviewAPLabel
        '
        Me.firstReviewAPLabel.AutoSize = True
        Me.firstReviewAPLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstReviewAPLabel.Location = New System.Drawing.Point(0, 16)
        Me.firstReviewAPLabel.Name = "firstReviewAPLabel"
        Me.firstReviewAPLabel.Size = New System.Drawing.Size(446, 26)
        Me.firstReviewAPLabel.TabIndex = 14
        Me.firstReviewAPLabel.Text = "1st Review Authorization for the following prefixes:"
        '
        'firstReviewerCheckBox
        '
        Me.firstReviewerCheckBox.AutoSize = True
        Me.firstReviewerCheckBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstReviewerCheckBox.Location = New System.Drawing.Point(17, 207)
        Me.firstReviewerCheckBox.Name = "firstReviewerCheckBox"
        Me.firstReviewerCheckBox.Size = New System.Drawing.Size(139, 30)
        Me.firstReviewerCheckBox.TabIndex = 16
        Me.firstReviewerCheckBox.Text = "1st Reviewer"
        Me.firstReviewerCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.prefixCodesAPCheckedListBox)
        Me.GroupBox1.Controls.Add(Me.firstReviewAPLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 170)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'authorizedPersonsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 459)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.adminAPCheckBox)
        Me.Controls.Add(Me.firstReviewerCheckBox)
        Me.Controls.Add(Me.departmentAPTextBox)
        Me.Controls.Add(Me.emailSuffixAPLabel)
        Me.Controls.Add(Me.emailAPTextBox)
        Me.Controls.Add(Me.userNameAPTextBox)
        Me.Controls.Add(Me.lastNameAPTextBox2)
        Me.Controls.Add(Me.firstNameAPTextBox)
        Me.Controls.Add(Me.clearFormAPButton)
        Me.Controls.Add(Me.closeAPButton)
        Me.Controls.Add(Me.saveChangesAPButton)
        Me.Controls.Add(Me.resetFormAPButton)
        Me.Controls.Add(Me.selectNameAPComboBox)
        Me.Controls.Add(Me.nameAPLabel)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "authorizedPersonsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Authorized Personnel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameAPLabel As System.Windows.Forms.Label
    Friend WithEvents selectNameAPComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents resetFormAPButton As System.Windows.Forms.Button
    Friend WithEvents saveChangesAPButton As System.Windows.Forms.Button
    Friend WithEvents closeAPButton As System.Windows.Forms.Button
    Friend WithEvents clearFormAPButton As System.Windows.Forms.Button
    Friend WithEvents firstNameAPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lastNameAPTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents userNameAPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents adminAPCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents emailAPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents emailSuffixAPLabel As System.Windows.Forms.Label
    Friend WithEvents departmentAPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents prefixCodesAPCheckedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents firstReviewAPLabel As System.Windows.Forms.Label
    Friend WithEvents firstReviewerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
