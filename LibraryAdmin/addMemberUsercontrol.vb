Imports System.Configuration
Public Class addMemberUsercontrol
    Private Sub termsLabel_Click(sender As Object, e As EventArgs) Handles termsLabel.Click
        FormTOS.Show()
    End Sub

    Function validateForm()
        If addMemberNameTextbox.Text = "" Then
            MsgBox("Please input a name")
        ElseIf maleRadio.Checked = False And femaleRadio.Checked = False Then
            MsgBox("Please choose gender")
        ElseIf Date.Now.Subtract(dobDatepicker.Value).Days \ 365 < 17 Then
            MsgBox("You must atleast be 17 years old to sign up")
        ElseIf addressTextbox.Text = "" Then
            MsgBox("Please input an address")
        ElseIf termsCheckbox.Checked = False Then
            MsgBox("You must agree to our terms and service to sign up")
        ElseIf phoneNumMaskedtextbox.Text.Length < 12 Then
            MsgBox("Please input proper phone number")
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub memberAddCancelButton_Click(sender As Object, e As EventArgs) Handles memberAddCancelButton.Click
        FormMember.addUC.Visible = False
    End Sub


    Private Sub memberAddSubmitButton_Click(sender As Object, e As EventArgs) Handles memberAddSubmitButton.Click
        If validateForm() Then
            Dim gender
            If maleRadio.Checked = True Then
                gender = "m"
            Else
                gender = "f"
            End If
            LibraryAdminFunctions.dbAddMember(addMemberNameTextbox.Text, addressTextbox.Text, dobDatepicker.Value, gender, phoneNumMaskedtextbox.Text)
            MsgBox("Successfully added new member")
            FormMember.addUC.Visible = False
        End If
    End Sub

    Private Sub addMemberUsercontrol_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        addMemberNameTextbox.Clear()
        maleRadio.Checked = False
        femaleRadio.Checked = False
        addressTextbox.Clear()
        dobDatepicker.Value = Today
        termsCheckbox.Checked = False
    End Sub
End Class
