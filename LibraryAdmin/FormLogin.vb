Public Class FormLogin
    Dim tempUser As String = "lucky"
    Public Property loginStatus As Boolean = False
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
        Me.BringToFront
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        If (userTextbox.Text = "") Then
            MsgBox("Please input a username")
        ElseIf passwordTextbox.Text = "" Then
            MsgBox("Please input password")
        ElseIf userTextbox.Text = tempUser And passwordTextbox.Text = tempUser Then
            loginStatus = True
            Close()
        Else
            MsgBox("Wrong password or username")
        End If
    End Sub
End Class