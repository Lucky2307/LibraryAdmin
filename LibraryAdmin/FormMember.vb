Imports LibraryAdmin
Public Class FormMember
    Dim imgParentDir As String = "C:\Users\alana\source\images\LibraryAdmin\"
    Private Sub FormMember_Load(sender As Object, e As EventArgs) Handles Me.Load
        LibraryAdminFunctions.gridFiller(memberDatagrid)
        'For Default view:
        Dim dummy As Object
        Dim dummye As DataGridViewCellMouseEventArgs
        memberDatagrid_CellMouseUp(dummy, dummye)
    End Sub
    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click, editContextmenustrip.Click
        editUC.fill(LibraryAdminFunctions.dbCaller(memberDatagrid)(0), memberDatagrid.SelectedRows.Count)
        editUC.Visible = True
        addUC.Visible = False
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click, AddToolStripMenuItem.Click
        addUC.Visible = True
        editUC.Visible = False
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click, DeleteToolStripMenuItem.Click
        Dim answer As Integer
        Dim sel = LibraryAdminFunctions.dbCaller(memberDatagrid)(0)
        answer = MsgBox("Are you sure you want to delete " & sel(1) & " membership?" & vbCrLf & "(Changes can not be undone)", vbQuestion + vbYesNo + vbDefaultButton2, "Confirm delete?")
        If answer = vbYes Then
            LibraryAdminFunctions.dbDeleteMember(sel(0))
            LibraryAdminFunctions.gridFiller(memberDatagrid)
        End If
    End Sub

    Private Sub memberDatagrid_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles memberDatagrid.CellMouseUp
        viewUC.fill(LibraryAdminFunctions.dbCaller(memberDatagrid)(0))
        editUC.Visible = False
        addUC.Visible = False
        GC.Collect()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ThisProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThisProgramToolStripMenuItem.Click
        MsgBox("LibraryAdmin, a basic library management software created by:" & vbCrLf & vbCrLf & "Fauzan Lucky Alana Iskandar " & vbCrLf & "(001201900048)")
    End Sub

    Private Sub editUC_Load(sender As Object, e As EventArgs) Handles editUC.Load

    End Sub
End Class