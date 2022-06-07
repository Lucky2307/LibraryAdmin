<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMemberUsercontrol
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addMemberNameTextbox = New System.Windows.Forms.TextBox()
        Me.addressTextbox = New System.Windows.Forms.TextBox()
        Me.genderGroupbox = New System.Windows.Forms.GroupBox()
        Me.femaleRadio = New System.Windows.Forms.RadioButton()
        Me.maleRadio = New System.Windows.Forms.RadioButton()
        Me.memberAddSubmitButton = New System.Windows.Forms.Button()
        Me.memberAddCancelButton = New System.Windows.Forms.Button()
        Me.termsCheckbox = New System.Windows.Forms.CheckBox()
        Me.termsLabel = New System.Windows.Forms.Label()
        Me.dobDatepicker = New System.Windows.Forms.DateTimePicker()
        Me.phoneNumberLabel = New System.Windows.Forms.Label()
        Me.phoneNumMaskedtextbox = New System.Windows.Forms.MaskedTextBox()
        Me.genderGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bebas", 48.0!)
        Me.Label1.Location = New System.Drawing.Point(76, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add new member"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(160, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(151, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(121, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date of Birth:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(145, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address:"
        '
        'addMemberNameTextbox
        '
        Me.addMemberNameTextbox.Font = New System.Drawing.Font("Agency FB", 12.0!)
        Me.addMemberNameTextbox.Location = New System.Drawing.Point(224, 78)
        Me.addMemberNameTextbox.Name = "addMemberNameTextbox"
        Me.addMemberNameTextbox.Size = New System.Drawing.Size(209, 26)
        Me.addMemberNameTextbox.TabIndex = 1
        '
        'addressTextbox
        '
        Me.addressTextbox.Font = New System.Drawing.Font("Agency FB", 12.0!)
        Me.addressTextbox.Location = New System.Drawing.Point(224, 166)
        Me.addressTextbox.Multiline = True
        Me.addressTextbox.Name = "addressTextbox"
        Me.addressTextbox.Size = New System.Drawing.Size(209, 88)
        Me.addressTextbox.TabIndex = 5
        '
        'genderGroupbox
        '
        Me.genderGroupbox.Controls.Add(Me.femaleRadio)
        Me.genderGroupbox.Controls.Add(Me.maleRadio)
        Me.genderGroupbox.Location = New System.Drawing.Point(224, 102)
        Me.genderGroupbox.Name = "genderGroupbox"
        Me.genderGroupbox.Size = New System.Drawing.Size(209, 32)
        Me.genderGroupbox.TabIndex = 9
        Me.genderGroupbox.TabStop = False
        '
        'femaleRadio
        '
        Me.femaleRadio.AutoSize = True
        Me.femaleRadio.Location = New System.Drawing.Point(123, 12)
        Me.femaleRadio.Name = "femaleRadio"
        Me.femaleRadio.Size = New System.Drawing.Size(59, 17)
        Me.femaleRadio.TabIndex = 3
        Me.femaleRadio.TabStop = True
        Me.femaleRadio.Text = "Female"
        Me.femaleRadio.UseVisualStyleBackColor = True
        '
        'maleRadio
        '
        Me.maleRadio.AutoSize = True
        Me.maleRadio.Location = New System.Drawing.Point(27, 12)
        Me.maleRadio.Name = "maleRadio"
        Me.maleRadio.Size = New System.Drawing.Size(48, 17)
        Me.maleRadio.TabIndex = 2
        Me.maleRadio.TabStop = True
        Me.maleRadio.Text = "Male"
        Me.maleRadio.UseVisualStyleBackColor = True
        '
        'memberAddSubmitButton
        '
        Me.memberAddSubmitButton.BackColor = System.Drawing.Color.White
        Me.memberAddSubmitButton.FlatAppearance.BorderSize = 3
        Me.memberAddSubmitButton.Font = New System.Drawing.Font("Bebas", 12.0!)
        Me.memberAddSubmitButton.Location = New System.Drawing.Point(294, 346)
        Me.memberAddSubmitButton.Name = "memberAddSubmitButton"
        Me.memberAddSubmitButton.Size = New System.Drawing.Size(112, 54)
        Me.memberAddSubmitButton.TabIndex = 10
        Me.memberAddSubmitButton.Text = "Submit"
        Me.memberAddSubmitButton.UseVisualStyleBackColor = False
        '
        'memberAddCancelButton
        '
        Me.memberAddCancelButton.BackColor = System.Drawing.Color.White
        Me.memberAddCancelButton.FlatAppearance.BorderSize = 3
        Me.memberAddCancelButton.Font = New System.Drawing.Font("Bebas", 12.0!)
        Me.memberAddCancelButton.Location = New System.Drawing.Point(161, 346)
        Me.memberAddCancelButton.Name = "memberAddCancelButton"
        Me.memberAddCancelButton.Size = New System.Drawing.Size(112, 54)
        Me.memberAddCancelButton.TabIndex = 9
        Me.memberAddCancelButton.Text = "Cancel"
        Me.memberAddCancelButton.UseVisualStyleBackColor = False
        '
        'termsCheckbox
        '
        Me.termsCheckbox.AutoSize = True
        Me.termsCheckbox.Location = New System.Drawing.Point(130, 312)
        Me.termsCheckbox.Name = "termsCheckbox"
        Me.termsCheckbox.Size = New System.Drawing.Size(221, 17)
        Me.termsCheckbox.TabIndex = 7
        Me.termsCheckbox.Text = "I have read, and agrees to LibraryAdmin's"
        Me.termsCheckbox.UseVisualStyleBackColor = True
        '
        'termsLabel
        '
        Me.termsLabel.AutoSize = True
        Me.termsLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.termsLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.termsLabel.Location = New System.Drawing.Point(344, 313)
        Me.termsLabel.Name = "termsLabel"
        Me.termsLabel.Size = New System.Drawing.Size(96, 13)
        Me.termsLabel.TabIndex = 8
        Me.termsLabel.Text = "Terms and Service"
        '
        'dobDatepicker
        '
        Me.dobDatepicker.Font = New System.Drawing.Font("Agency FB", 12.0!)
        Me.dobDatepicker.Location = New System.Drawing.Point(224, 135)
        Me.dobDatepicker.Name = "dobDatepicker"
        Me.dobDatepicker.Size = New System.Drawing.Size(209, 26)
        Me.dobDatepicker.TabIndex = 4
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.AutoSize = True
        Me.phoneNumberLabel.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.phoneNumberLabel.Location = New System.Drawing.Point(95, 263)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(99, 24)
        Me.phoneNumberLabel.TabIndex = 40
        Me.phoneNumberLabel.Text = "Phone Number:"
        Me.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'phoneNumMaskedtextbox
        '
        Me.phoneNumMaskedtextbox.AsciiOnly = True
        Me.phoneNumMaskedtextbox.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.phoneNumMaskedtextbox.Location = New System.Drawing.Point(224, 260)
        Me.phoneNumMaskedtextbox.Mask = "\0###########"
        Me.phoneNumMaskedtextbox.Name = "phoneNumMaskedtextbox"
        Me.phoneNumMaskedtextbox.Size = New System.Drawing.Size(209, 30)
        Me.phoneNumMaskedtextbox.TabIndex = 6
        '
        'addMemberUsercontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.phoneNumberLabel)
        Me.Controls.Add(Me.phoneNumMaskedtextbox)
        Me.Controls.Add(Me.dobDatepicker)
        Me.Controls.Add(Me.termsLabel)
        Me.Controls.Add(Me.termsCheckbox)
        Me.Controls.Add(Me.memberAddCancelButton)
        Me.Controls.Add(Me.memberAddSubmitButton)
        Me.Controls.Add(Me.addMemberNameTextbox)
        Me.Controls.Add(Me.genderGroupbox)
        Me.Controls.Add(Me.addressTextbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addMemberUsercontrol"
        Me.Size = New System.Drawing.Size(558, 423)
        Me.genderGroupbox.ResumeLayout(False)
        Me.genderGroupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents addMemberNameTextbox As TextBox
    Friend WithEvents addressTextbox As TextBox
    Friend WithEvents genderGroupbox As GroupBox
    Friend WithEvents femaleRadio As RadioButton
    Friend WithEvents maleRadio As RadioButton
    Friend WithEvents memberAddSubmitButton As Button
    Friend WithEvents memberAddCancelButton As Button
    Friend WithEvents termsCheckbox As CheckBox
    Friend WithEvents termsLabel As Label
    Friend WithEvents dobDatepicker As DateTimePicker
    Friend WithEvents phoneNumberLabel As Label
    Friend WithEvents phoneNumMaskedtextbox As MaskedTextBox
End Class
