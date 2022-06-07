Public Class ContainerForm

    Private Sub MemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MemberToolStripMenuItem.Click
        FormMember.MdiParent = Me
        FormMember.Show()
    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        FormBook.MdiParent = Me
        FormBook.Show()
    End Sub

    Private Sub LendToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LendToolStripMenuItem.Click
        FormLend.MdiParent = Me
        FormLend.Show()
    End Sub
End Class