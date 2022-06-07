Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        programTimer.Start()
        Me.CenterToScreen()
        'FormLogin.ShowDialog()
        'If Not FormLogin.loginStatus Then
        '    Close()
        'End If
    End Sub

    Dim programTimerText As Int64 = 0
    Private Sub programTimer_Tick(sender As Object, e As EventArgs) Handles programTimer.Tick
        programTimerText += 1
        footerProgramTimerLabel.Text = "Program has been active for: " & programTimerText.ToString & " seconds"
        dateStatuslabel.Text = Date.Now
    End Sub

    Private Sub bookFormButton_Click(sender As Object, e As EventArgs) Handles bookFormButton.Click
        FormBook.Show()
        footerProgressbar.Value = 50
        While FormBook.programLaunced = False
            footerStatusLabel.Text = "Launching book form"
        End While
        footerStatusLabel.Text = "Book form launched"
        footerProgressbar.Value = 100
    End Sub

    Private Sub memberFormButton_Click(sender As Object, e As EventArgs) Handles memberFormButton.Click
        FormMember.Show()
        footerProgressbar.Value = 50
        While FormBook.programLaunced = False
            footerStatusLabel.Text = "Launching member form"
        End While
        footerStatusLabel.Text = "Member form launched"
        footerProgressbar.Value = 100
    End Sub

    Private Sub borrowFormButton_Click(sender As Object, e As EventArgs) Handles borrowFormButton.Click
        FormLend.Show()
        footerProgressbar.Value = 50
        While FormBook.programLaunced = False
            footerStatusLabel.Text = "Launching borrow form"
        End While
        footerStatusLabel.Text = "Borrow form launched"
        footerProgressbar.Value = 100
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("LibraryAdmin, a basic library management software created by:" & vbCrLf & vbCrLf & "Fauzan Lucky Alana Iskandar " & vbCrLf & "(001201900048)")
    End Sub

    Private Sub FormContainerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormContainerToolStripMenuItem.Click
        ContainerForm.Show()
    End Sub
End Class