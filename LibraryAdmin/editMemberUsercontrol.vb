Imports System.Configuration
Public Class editMemberUsercontrol
    Public Function fill(sel, selectedData)
        If selectedData = 0 Then
            MsgBox("Please select a member to edit")
            Exit Function
        End If
        memberEditNameTextbox.Text = sel(1)
        memberEditAddressTextbox.Text = sel(2)
        memberEditDobDatepicker.Value = sel(3)
        phoneNumMaskedtextbox.Text = sel(6)
        If sel(5) = "m" Then
            maleRadioButton.Checked = True
        Else
            femaleRadioButton.Checked = True
        End If
    End Function



    'Buttons
    Private Sub memberEditCancelButton_Click(sender As Object, e As EventArgs) Handles memberEditCancelButton.Click
        Me.Visible = False
    End Sub

    Private Sub memberEditSubmitButton_Click(sender As Object, e As EventArgs) Handles memberEditSubmitButton.Click
        Dim sel = LibraryAdminFunctions.dbCaller(FormMember.memberDatagrid)(0)
        Dim gender As Char
        If maleRadioButton.Checked Then
            gender = "m"
        Else
            gender = "f"
        End If
        LibraryAdminFunctions.dbUpdateMember(sel(0),
                       memberEditNameTextbox.Text,
                       memberEditAddressTextbox.Text,
                       memberEditDobDatepicker.Value,
                       gender,
                       phoneNumMaskedtextbox.Text)
        Me.Visible = False
    End Sub

End Class