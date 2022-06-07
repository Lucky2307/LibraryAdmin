Public Class FormTOS
    Private Sub FormTOS_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.CenterToScreen()
        TermsAndServiceTree.ExpandAll()
    End Sub

    Dim node As String
    Dim nodeLast As String = ""
    Private Sub TermsAndServiceTree_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TermsAndServiceTree.AfterSelect
        If Not nodeLast = "" And Not TOSBrowser.Document.GetElementById(nodeLast) Is Nothing Then
            TOSBrowser.Document.GetElementById(nodeLast).Style = "color: black"
        End If
        node = TermsAndServiceTree.SelectedNode.Name.ToString
        If Not TOSBrowser.Document.GetElementById(node) = Nothing Then
            TOSBrowser.Document.GetElementById(node).ScrollIntoView(True)
            TOSBrowser.Document.GetElementById(node).Style = "color: blue"
        End If
        nodeLast = node
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Close()
    End Sub
End Class