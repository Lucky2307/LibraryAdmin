Imports System.Threading

Public Class FormTermsandService
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.CenterToScreen()
        TermsAndServiceTree.ExpandAll()
    End Sub

    Dim node As String
    Dim nodeLast As String = ""
    Private Sub TermsAndServiceTree_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TermsAndServiceTree.AfterSelect
        If Not nodeLast = "" And Not Browser.Document.GetElementById(nodeLast) Is Nothing Then
            Browser.Document.GetElementById(nodeLast).Style = "color: black"
        End If
        node = TermsAndServiceTree.SelectedNode.Name.ToString
        If Not Browser.Document.GetElementById(node) = Nothing Then
            Browser.Document.GetElementById(node).ScrollIntoView(True)
            Browser.Document.GetElementById(node).Style = "color: blue"
        End If
        nodeLast = node
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Close()
    End Sub
End Class
