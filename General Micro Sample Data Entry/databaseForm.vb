Imports System.Text

Public Class databaseForm
    Private Sub getDBPathButton_Click(sender As Object, e As EventArgs) Handles getDBPathButton.Click

        'Get the backup database Location by browsing for the folder and saving in settings
        Dim fb As FolderBrowserDialog = New FolderBrowserDialog()
        fb.RootFolder = "L:\eRecords\Microbiology\General Micro Lab\Automation Database\Backups"

        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            backupDBLocationTextBox.Text = fb.SelectedPath
        End If

    End Sub

    Private Sub saveDBBackupInformationButton_Click(sender As Object, e As EventArgs) Handles saveDBBackupInformationButton.Click
        My.Settings.backupDBLocation = backupDBLocationTextBox.Text
        My.Settings.backupDBTime = backupTimeDBDateTimePicker.Value
    End Sub

    Private Sub backupNowButton_Click(sender As Object, e As EventArgs) Handles backupNowButton.Click
        'Perform a backup now
    End Sub

    Private Sub browseDBRestoreButton_Click(sender As Object, e As EventArgs) Handles browseDBRestoreButton.Click

        'Get the Sample Prep File Location by browsing for file and saving in settings
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "L:\eRecords\Microbiology\General Micro Lab\Automation Database\Backups"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            restoreDBBackupTextBox.Text = fd.FileName
        End If

    End Sub

    Private Sub backupDaysCheckedListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles backupDaysCheckedListBox.SelectedIndexChanged
        'Get which days are checked
    End Sub
End Class