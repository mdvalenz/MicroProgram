Public Class MainForm

    Private Sub importSamplesSDEButton_Click(sender As Object, e As EventArgs) Handles importSamplesSDEButton.Click

        'Change form text
        sampleSelectionForm.Text = "Import Sample Data"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Import"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Import"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub authorizedPersonnelSDEButton_Click(sender As Object, e As EventArgs) Handles authorizedPersonnelSDEButton.Click
        authorizedPersonsForm.ShowDialog()
    End Sub

    Private Sub weighSamplesSDEButton_Click(sender As Object, e As EventArgs) Handles weighSamplesSDEButton.Click

        'Change form text
        sampleSelectionForm.Text = "Weigh Samples"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Continue"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Continue"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub incubateSamplesSDEButton_Click(sender As Object, e As EventArgs) Handles incubateSamplesSDEButton.Click

        'Change form text
        sampleSelectionForm.Text = "Incubate Samples"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Continue"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Continue"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub pullSamplesSDEButton_Click(sender As Object, e As EventArgs) Handles pullSamplesSDEButton.Click

        'Change form text
        sampleSelectionForm.Text = "Pull Samples"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Continue"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Continue"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub enterResultsSDEButton_Click(sender As Object, e As EventArgs) Handles enterResultsSDEButton.Click

        'Change form text
        sampleSelectionForm.Text = "Enter Results"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Continue"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Continue"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub incubateMPNSamplesSDEButton_Click(sender As Object, e As EventArgs) Handles incubateMPNSamplesSDEButton.Click

        'Change form text
        sampleSelectionForm.Text = "Incubate MPNs"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Continue"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Continue"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub pullMPNSamplesSDEButton_Click(sender As Object, e As EventArgs) Handles pullMPNSamplesSDEButton.Click
        'Change form text
        sampleSelectionForm.Text = "Pull MPNs"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Continue"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Continue"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub enterMPNResultsSDEButton_Click(sender As Object, e As EventArgs) Handles enterMPNResultsSDEButton.Click
        'Change form text
        sampleSelectionForm.Text = "Enter MPN Results"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Continue"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Continue"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub incubateConfirmationsSDEButton_Click(sender As Object, e As EventArgs) Handles incubateConfirmationsSDEButton.Click
        'Change form text
        sampleSelectionForm.Text = "Incubate Confirmations"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Continue"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Continue"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub pullConfirmationsSDEButton_Click(sender As Object, e As EventArgs) Handles pullConfirmationsSDEButton.Click
        'Change form text
        sampleSelectionForm.Text = "Pull Confirmations"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Continue"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Continue"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub enterConfirmationResultsSDEButton_Click(sender As Object, e As EventArgs) Handles enterConfirmationResultsSDEButton.Click
        'Change form text
        sampleSelectionForm.Text = "Enter Confirmation Results"
        My.Settings.buttonSelection = sampleSelectionForm.Text
        sampleSelectionForm.importProjectNumbersIPDButton.Text = "Continue"
        sampleSelectionForm.importSampleIDsIPDButton.Text = "Continue"
        sampleSelectionForm.projectNumberPage.Focus()
        sampleSelectionForm.projectNumbersIPDDataGridView.Focus()

        sampleSelectionForm.ShowDialog()

    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseToolStripMenuItem.Click
        databaseForm.ShowDialog()
    End Sub

    Private Sub pathListButton_Click(sender As Object, e As EventArgs) Handles pathListButton.Click
        pathAnalysisForm.ShowDialog()
    End Sub

    Private Sub editPrefixListSDEButton_Click(sender As Object, e As EventArgs) Handles editPrefixListSDEButton.Click
        prefixListForm.ShowDialog()
    End Sub

    Private Sub mediaQCButton_Click(sender As Object, e As EventArgs) Handles mediaQCButton.Click
        mediaQCForm.Show()
    End Sub

End Class
