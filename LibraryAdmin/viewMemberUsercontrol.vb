Public Class viewMemberUsercontrol
    Dim imgParentDir As String = "C:\Users\alana\source\images\LibraryAdmin\"
    Function fill(sel)
        memberNameTextbox.Text = sel(1)
        memberPicturebox.Image = Image.FromFile(imgParentDir & "icons\" & sel(5) & ".png")
        dobTextbox.Text = sel(3)
        signupDateTextbox.Text = sel(4)
        addressTextbox.Text = sel(2)
        phoneNumberTextbox.Text = sel(6)
    End Function
End Class
