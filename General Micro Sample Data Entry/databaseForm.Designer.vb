<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class databaseForm
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
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.backupDBTabPage = New System.Windows.Forms.TabPage()
        Me.backupNowButton = New System.Windows.Forms.Button()
        Me.saveDBBackupInformationButton = New System.Windows.Forms.Button()
        Me.getDBPathButton = New System.Windows.Forms.Button()
        Me.backupDBLocationTextBox = New System.Windows.Forms.TextBox()
        Me.backupLocationLabel = New System.Windows.Forms.Label()
        Me.backupAtLabel = New System.Windows.Forms.Label()
        Me.backupWhenLabel = New System.Windows.Forms.Label()
        Me.backupTimeDBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.backupDaysCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.restoreDBTabPage = New System.Windows.Forms.TabPage()
        Me.restoreDBStatusTextLabel = New System.Windows.Forms.Label()
        Me.restoreDBStatusLabel = New System.Windows.Forms.Label()
        Me.restoreProgressLabel = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.restoreDBButton = New System.Windows.Forms.Button()
        Me.browseDBRestoreButton = New System.Windows.Forms.Button()
        Me.restoreDBBackupTextBox = New System.Windows.Forms.TextBox()
        Me.restoreDBBackupLabel = New System.Windows.Forms.Label()
        Me.connectDBTabPage = New System.Windows.Forms.TabPage()
        Me.saveDBConnectionButton = New System.Windows.Forms.Button()
        Me.browseDBConnectionButton = New System.Windows.Forms.Button()
        Me.DBConnectionTextBox = New System.Windows.Forms.TextBox()
        Me.DBConnectionLabel = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.mainTabControl.SuspendLayout()
        Me.backupDBTabPage.SuspendLayout()
        Me.restoreDBTabPage.SuspendLayout()
        Me.connectDBTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Controls.Add(Me.backupDBTabPage)
        Me.mainTabControl.Controls.Add(Me.restoreDBTabPage)
        Me.mainTabControl.Controls.Add(Me.connectDBTabPage)
        Me.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTabControl.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainTabControl.Location = New System.Drawing.Point(0, 0)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.Padding = New System.Drawing.Point(20, 10)
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(558, 465)
        Me.mainTabControl.TabIndex = 28
        '
        'backupDBTabPage
        '
        Me.backupDBTabPage.Controls.Add(Me.backupNowButton)
        Me.backupDBTabPage.Controls.Add(Me.saveDBBackupInformationButton)
        Me.backupDBTabPage.Controls.Add(Me.getDBPathButton)
        Me.backupDBTabPage.Controls.Add(Me.backupDBLocationTextBox)
        Me.backupDBTabPage.Controls.Add(Me.backupLocationLabel)
        Me.backupDBTabPage.Controls.Add(Me.backupAtLabel)
        Me.backupDBTabPage.Controls.Add(Me.backupWhenLabel)
        Me.backupDBTabPage.Controls.Add(Me.backupTimeDBDateTimePicker)
        Me.backupDBTabPage.Controls.Add(Me.backupDaysCheckedListBox)
        Me.backupDBTabPage.Location = New System.Drawing.Point(4, 52)
        Me.backupDBTabPage.Name = "backupDBTabPage"
        Me.backupDBTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.backupDBTabPage.Size = New System.Drawing.Size(550, 409)
        Me.backupDBTabPage.TabIndex = 0
        Me.backupDBTabPage.Text = "Backup"
        Me.backupDBTabPage.UseVisualStyleBackColor = True
        '
        'backupNowButton
        '
        Me.backupNowButton.Location = New System.Drawing.Point(263, 359)
        Me.backupNowButton.Name = "backupNowButton"
        Me.backupNowButton.Size = New System.Drawing.Size(146, 37)
        Me.backupNowButton.TabIndex = 8
        Me.backupNowButton.Text = "Backup Now"
        Me.backupNowButton.UseVisualStyleBackColor = True
        '
        'saveDBBackupInformationButton
        '
        Me.saveDBBackupInformationButton.Location = New System.Drawing.Point(426, 359)
        Me.saveDBBackupInformationButton.Name = "saveDBBackupInformationButton"
        Me.saveDBBackupInformationButton.Size = New System.Drawing.Size(107, 37)
        Me.saveDBBackupInformationButton.TabIndex = 7
        Me.saveDBBackupInformationButton.Text = "Save"
        Me.saveDBBackupInformationButton.UseVisualStyleBackColor = True
        '
        'getDBPathButton
        '
        Me.getDBPathButton.Location = New System.Drawing.Point(426, 295)
        Me.getDBPathButton.Name = "getDBPathButton"
        Me.getDBPathButton.Size = New System.Drawing.Size(107, 37)
        Me.getDBPathButton.TabIndex = 6
        Me.getDBPathButton.Text = "Browse"
        Me.getDBPathButton.UseVisualStyleBackColor = True
        '
        'backupDBLocationTextBox
        '
        Me.backupDBLocationTextBox.Location = New System.Drawing.Point(13, 295)
        Me.backupDBLocationTextBox.Name = "backupDBLocationTextBox"
        Me.backupDBLocationTextBox.Size = New System.Drawing.Size(407, 37)
        Me.backupDBLocationTextBox.TabIndex = 5
        '
        'backupLocationLabel
        '
        Me.backupLocationLabel.AutoSize = True
        Me.backupLocationLabel.Location = New System.Drawing.Point(8, 263)
        Me.backupLocationLabel.Name = "backupLocationLabel"
        Me.backupLocationLabel.Size = New System.Drawing.Size(272, 29)
        Me.backupLocationLabel.TabIndex = 4
        Me.backupLocationLabel.Text = "Select the backup location"
        '
        'backupAtLabel
        '
        Me.backupAtLabel.AutoSize = True
        Me.backupAtLabel.Location = New System.Drawing.Point(8, 120)
        Me.backupAtLabel.Name = "backupAtLabel"
        Me.backupAtLabel.Size = New System.Drawing.Size(39, 29)
        Me.backupAtLabel.TabIndex = 3
        Me.backupAtLabel.Text = "at:"
        '
        'backupWhenLabel
        '
        Me.backupWhenLabel.AutoSize = True
        Me.backupWhenLabel.Location = New System.Drawing.Point(8, 19)
        Me.backupWhenLabel.Name = "backupWhenLabel"
        Me.backupWhenLabel.Size = New System.Drawing.Size(249, 29)
        Me.backupWhenLabel.TabIndex = 2
        Me.backupWhenLabel.Text = "Backup will occur every:"
        '
        'backupTimeDBDateTimePicker
        '
        Me.backupTimeDBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.backupTimeDBDateTimePicker.Location = New System.Drawing.Point(53, 116)
        Me.backupTimeDBDateTimePicker.Name = "backupTimeDBDateTimePicker"
        Me.backupTimeDBDateTimePicker.Size = New System.Drawing.Size(162, 37)
        Me.backupTimeDBDateTimePicker.TabIndex = 1
        '
        'backupDaysCheckedListBox
        '
        Me.backupDaysCheckedListBox.FormattingEnabled = True
        Me.backupDaysCheckedListBox.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.backupDaysCheckedListBox.Location = New System.Drawing.Point(263, 19)
        Me.backupDaysCheckedListBox.Name = "backupDaysCheckedListBox"
        Me.backupDaysCheckedListBox.Size = New System.Drawing.Size(146, 228)
        Me.backupDaysCheckedListBox.TabIndex = 0
        '
        'restoreDBTabPage
        '
        Me.restoreDBTabPage.Controls.Add(Me.restoreDBStatusTextLabel)
        Me.restoreDBTabPage.Controls.Add(Me.restoreDBStatusLabel)
        Me.restoreDBTabPage.Controls.Add(Me.restoreProgressLabel)
        Me.restoreDBTabPage.Controls.Add(Me.ProgressBar1)
        Me.restoreDBTabPage.Controls.Add(Me.restoreDBButton)
        Me.restoreDBTabPage.Controls.Add(Me.browseDBRestoreButton)
        Me.restoreDBTabPage.Controls.Add(Me.restoreDBBackupTextBox)
        Me.restoreDBTabPage.Controls.Add(Me.restoreDBBackupLabel)
        Me.restoreDBTabPage.Location = New System.Drawing.Point(4, 52)
        Me.restoreDBTabPage.Name = "restoreDBTabPage"
        Me.restoreDBTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.restoreDBTabPage.Size = New System.Drawing.Size(550, 409)
        Me.restoreDBTabPage.TabIndex = 1
        Me.restoreDBTabPage.Text = "Restore"
        Me.restoreDBTabPage.UseVisualStyleBackColor = True
        '
        'restoreDBStatusTextLabel
        '
        Me.restoreDBStatusTextLabel.AutoSize = True
        Me.restoreDBStatusTextLabel.Location = New System.Drawing.Point(260, 202)
        Me.restoreDBStatusTextLabel.Name = "restoreDBStatusTextLabel"
        Me.restoreDBStatusTextLabel.Size = New System.Drawing.Size(74, 29)
        Me.restoreDBStatusTextLabel.TabIndex = 15
        Me.restoreDBStatusTextLabel.Text = "Ready"
        '
        'restoreDBStatusLabel
        '
        Me.restoreDBStatusLabel.AutoSize = True
        Me.restoreDBStatusLabel.Location = New System.Drawing.Point(3, 202)
        Me.restoreDBStatusLabel.Name = "restoreDBStatusLabel"
        Me.restoreDBStatusLabel.Size = New System.Drawing.Size(251, 29)
        Me.restoreDBStatusLabel.TabIndex = 14
        Me.restoreDBStatusLabel.Text = "Database restore status:"
        '
        'restoreProgressLabel
        '
        Me.restoreProgressLabel.AutoSize = True
        Me.restoreProgressLabel.Location = New System.Drawing.Point(3, 132)
        Me.restoreProgressLabel.Name = "restoreProgressLabel"
        Me.restoreProgressLabel.Size = New System.Drawing.Size(275, 29)
        Me.restoreProgressLabel.TabIndex = 13
        Me.restoreProgressLabel.Text = "Database restore progress:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 164)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(407, 23)
        Me.ProgressBar1.TabIndex = 12
        '
        'restoreDBButton
        '
        Me.restoreDBButton.Location = New System.Drawing.Point(421, 364)
        Me.restoreDBButton.Name = "restoreDBButton"
        Me.restoreDBButton.Size = New System.Drawing.Size(107, 37)
        Me.restoreDBButton.TabIndex = 11
        Me.restoreDBButton.Text = "Restore"
        Me.restoreDBButton.UseVisualStyleBackColor = True
        '
        'browseDBRestoreButton
        '
        Me.browseDBRestoreButton.Location = New System.Drawing.Point(426, 47)
        Me.browseDBRestoreButton.Name = "browseDBRestoreButton"
        Me.browseDBRestoreButton.Size = New System.Drawing.Size(107, 37)
        Me.browseDBRestoreButton.TabIndex = 10
        Me.browseDBRestoreButton.Text = "Browse"
        Me.browseDBRestoreButton.UseVisualStyleBackColor = True
        '
        'restoreDBBackupTextBox
        '
        Me.restoreDBBackupTextBox.Location = New System.Drawing.Point(13, 47)
        Me.restoreDBBackupTextBox.Name = "restoreDBBackupTextBox"
        Me.restoreDBBackupTextBox.Size = New System.Drawing.Size(407, 37)
        Me.restoreDBBackupTextBox.TabIndex = 9
        '
        'restoreDBBackupLabel
        '
        Me.restoreDBBackupLabel.AutoSize = True
        Me.restoreDBBackupLabel.Location = New System.Drawing.Point(8, 15)
        Me.restoreDBBackupLabel.Name = "restoreDBBackupLabel"
        Me.restoreDBBackupLabel.Size = New System.Drawing.Size(288, 29)
        Me.restoreDBBackupLabel.TabIndex = 8
        Me.restoreDBBackupLabel.Text = "Select the backup to restore"
        '
        'connectDBTabPage
        '
        Me.connectDBTabPage.Controls.Add(Me.saveDBConnectionButton)
        Me.connectDBTabPage.Controls.Add(Me.browseDBConnectionButton)
        Me.connectDBTabPage.Controls.Add(Me.DBConnectionTextBox)
        Me.connectDBTabPage.Controls.Add(Me.DBConnectionLabel)
        Me.connectDBTabPage.Location = New System.Drawing.Point(4, 52)
        Me.connectDBTabPage.Name = "connectDBTabPage"
        Me.connectDBTabPage.Size = New System.Drawing.Size(550, 409)
        Me.connectDBTabPage.TabIndex = 2
        Me.connectDBTabPage.Text = "Connection"
        Me.connectDBTabPage.UseVisualStyleBackColor = True
        '
        'saveDBConnectionButton
        '
        Me.saveDBConnectionButton.Location = New System.Drawing.Point(426, 364)
        Me.saveDBConnectionButton.Name = "saveDBConnectionButton"
        Me.saveDBConnectionButton.Size = New System.Drawing.Size(107, 37)
        Me.saveDBConnectionButton.TabIndex = 14
        Me.saveDBConnectionButton.Text = "Save"
        Me.saveDBConnectionButton.UseVisualStyleBackColor = True
        '
        'browseDBConnectionButton
        '
        Me.browseDBConnectionButton.Location = New System.Drawing.Point(426, 47)
        Me.browseDBConnectionButton.Name = "browseDBConnectionButton"
        Me.browseDBConnectionButton.Size = New System.Drawing.Size(107, 37)
        Me.browseDBConnectionButton.TabIndex = 13
        Me.browseDBConnectionButton.Text = "Browse"
        Me.browseDBConnectionButton.UseVisualStyleBackColor = True
        '
        'DBConnectionTextBox
        '
        Me.DBConnectionTextBox.Location = New System.Drawing.Point(13, 47)
        Me.DBConnectionTextBox.Name = "DBConnectionTextBox"
        Me.DBConnectionTextBox.Size = New System.Drawing.Size(407, 37)
        Me.DBConnectionTextBox.TabIndex = 12
        '
        'DBConnectionLabel
        '
        Me.DBConnectionLabel.AutoSize = True
        Me.DBConnectionLabel.Location = New System.Drawing.Point(8, 15)
        Me.DBConnectionLabel.Name = "DBConnectionLabel"
        Me.DBConnectionLabel.Size = New System.Drawing.Size(255, 29)
        Me.DBConnectionLabel.TabIndex = 11
        Me.DBConnectionLabel.Text = "Connect to the database"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'databaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(558, 465)
        Me.Controls.Add(Me.mainTabControl)
        Me.Name = "databaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "databaseForm"
        Me.mainTabControl.ResumeLayout(False)
        Me.backupDBTabPage.ResumeLayout(False)
        Me.backupDBTabPage.PerformLayout()
        Me.restoreDBTabPage.ResumeLayout(False)
        Me.restoreDBTabPage.PerformLayout()
        Me.connectDBTabPage.ResumeLayout(False)
        Me.connectDBTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents backupDBTabPage As TabPage
    Friend WithEvents getDBPathButton As Button
    Friend WithEvents backupDBLocationTextBox As TextBox
    Friend WithEvents backupLocationLabel As Label
    Friend WithEvents backupAtLabel As Label
    Friend WithEvents backupWhenLabel As Label
    Friend WithEvents backupTimeDBDateTimePicker As DateTimePicker
    Friend WithEvents backupDaysCheckedListBox As CheckedListBox
    Friend WithEvents restoreDBTabPage As TabPage
    Friend WithEvents connectDBTabPage As TabPage
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents saveDBBackupInformationButton As Button
    Friend WithEvents backupNowButton As Button
    Friend WithEvents restoreDBStatusTextLabel As Label
    Friend WithEvents restoreDBStatusLabel As Label
    Friend WithEvents restoreProgressLabel As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents restoreDBButton As Button
    Friend WithEvents browseDBRestoreButton As Button
    Friend WithEvents restoreDBBackupTextBox As TextBox
    Friend WithEvents restoreDBBackupLabel As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents saveDBConnectionButton As Button
    Friend WithEvents browseDBConnectionButton As Button
    Friend WithEvents DBConnectionTextBox As TextBox
    Friend WithEvents DBConnectionLabel As Label
End Class
