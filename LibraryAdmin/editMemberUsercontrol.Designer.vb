<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editMemberUsercontrol
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.dobLabel = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.memberEditDobDatepicker = New System.Windows.Forms.DateTimePicker()
        Me.memberEditNameTextbox = New System.Windows.Forms.TextBox()
        Me.maleRadioButton = New System.Windows.Forms.RadioButton()
        Me.femaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.memberEditSubmitButton = New System.Windows.Forms.Button()
        Me.memberEditCancelButton = New System.Windows.Forms.Button()
        Me.genderGroupbox = New System.Windows.Forms.GroupBox()
        Me.genderLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.memberEditAddressTextbox = New System.Windows.Forms.TextBox()
        Me.phoneNumMaskedtextbox = New System.Windows.Forms.MaskedTextBox()
        Me.phoneNumberLabel = New System.Windows.Forms.Label()
        Me.genderGroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Bebas", 36.0!)
        Me.titleLabel.Location = New System.Drawing.Point(174, 18)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(243, 58)
        Me.titleLabel.TabIndex = 25
        Me.titleLabel.Text = "Edit member"
        '
        'dobLabel
        '
        Me.dobLabel.AutoSize = True
        Me.dobLabel.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.dobLabel.Location = New System.Drawing.Point(120, 119)
        Me.dobLabel.Name = "dobLabel"
        Me.dobLabel.Size = New System.Drawing.Size(85, 24)
        Me.dobLabel.TabIndex = 31
        Me.dobLabel.Text = "Date of Birth:"
        Me.dobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(159, 81)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(46, 24)
        Me.nameLabel.TabIndex = 30
        Me.nameLabel.Text = "Name:"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'memberEditDobDatepicker
        '
        Me.memberEditDobDatepicker.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.memberEditDobDatepicker.Location = New System.Drawing.Point(235, 115)
        Me.memberEditDobDatepicker.Name = "memberEditDobDatepicker"
        Me.memberEditDobDatepicker.Size = New System.Drawing.Size(209, 30)
        Me.memberEditDobDatepicker.TabIndex = 2
        '
        'memberEditNameTextbox
        '
        Me.memberEditNameTextbox.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.memberEditNameTextbox.Location = New System.Drawing.Point(235, 79)
        Me.memberEditNameTextbox.Name = "memberEditNameTextbox"
        Me.memberEditNameTextbox.Size = New System.Drawing.Size(209, 30)
        Me.memberEditNameTextbox.TabIndex = 1
        '
        'maleRadioButton
        '
        Me.maleRadioButton.AutoSize = True
        Me.maleRadioButton.Location = New System.Drawing.Point(40, 9)
        Me.maleRadioButton.Name = "maleRadioButton"
        Me.maleRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.maleRadioButton.TabIndex = 3
        Me.maleRadioButton.TabStop = True
        Me.maleRadioButton.Text = "Male"
        Me.maleRadioButton.UseVisualStyleBackColor = True
        '
        'femaleRadioButton
        '
        Me.femaleRadioButton.AutoSize = True
        Me.femaleRadioButton.Location = New System.Drawing.Point(125, 9)
        Me.femaleRadioButton.Name = "femaleRadioButton"
        Me.femaleRadioButton.Size = New System.Drawing.Size(59, 17)
        Me.femaleRadioButton.TabIndex = 4
        Me.femaleRadioButton.TabStop = True
        Me.femaleRadioButton.Text = "Female"
        Me.femaleRadioButton.UseVisualStyleBackColor = True
        '
        'memberEditSubmitButton
        '
        Me.memberEditSubmitButton.BackColor = System.Drawing.Color.White
        Me.memberEditSubmitButton.FlatAppearance.BorderSize = 3
        Me.memberEditSubmitButton.Font = New System.Drawing.Font("Bebas", 12.0!)
        Me.memberEditSubmitButton.Location = New System.Drawing.Point(307, 346)
        Me.memberEditSubmitButton.Name = "memberEditSubmitButton"
        Me.memberEditSubmitButton.Size = New System.Drawing.Size(112, 54)
        Me.memberEditSubmitButton.TabIndex = 8
        Me.memberEditSubmitButton.Text = "Submit"
        Me.memberEditSubmitButton.UseVisualStyleBackColor = False
        '
        'memberEditCancelButton
        '
        Me.memberEditCancelButton.BackColor = System.Drawing.Color.White
        Me.memberEditCancelButton.FlatAppearance.BorderSize = 3
        Me.memberEditCancelButton.Font = New System.Drawing.Font("Bebas", 12.0!)
        Me.memberEditCancelButton.Location = New System.Drawing.Point(162, 346)
        Me.memberEditCancelButton.Name = "memberEditCancelButton"
        Me.memberEditCancelButton.Size = New System.Drawing.Size(112, 54)
        Me.memberEditCancelButton.TabIndex = 7
        Me.memberEditCancelButton.Text = "Cancel"
        Me.memberEditCancelButton.UseVisualStyleBackColor = False
        '
        'genderGroupbox
        '
        Me.genderGroupbox.Controls.Add(Me.maleRadioButton)
        Me.genderGroupbox.Controls.Add(Me.femaleRadioButton)
        Me.genderGroupbox.Location = New System.Drawing.Point(235, 151)
        Me.genderGroupbox.Name = "genderGroupbox"
        Me.genderGroupbox.Size = New System.Drawing.Size(209, 30)
        Me.genderGroupbox.TabIndex = 34
        Me.genderGroupbox.TabStop = False
        '
        'genderLabel
        '
        Me.genderLabel.AutoSize = True
        Me.genderLabel.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.genderLabel.Location = New System.Drawing.Point(150, 153)
        Me.genderLabel.Name = "genderLabel"
        Me.genderLabel.Size = New System.Drawing.Size(55, 24)
        Me.genderLabel.TabIndex = 33
        Me.genderLabel.Text = "Gender:"
        Me.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.addressLabel.Location = New System.Drawing.Point(144, 189)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(61, 24)
        Me.addressLabel.TabIndex = 32
        Me.addressLabel.Text = "Address:"
        Me.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'memberEditAddressTextbox
        '
        Me.memberEditAddressTextbox.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.memberEditAddressTextbox.Location = New System.Drawing.Point(235, 187)
        Me.memberEditAddressTextbox.Multiline = True
        Me.memberEditAddressTextbox.Name = "memberEditAddressTextbox"
        Me.memberEditAddressTextbox.Size = New System.Drawing.Size(209, 100)
        Me.memberEditAddressTextbox.TabIndex = 5
        '
        'phoneNumMaskedtextbox
        '
        Me.phoneNumMaskedtextbox.AsciiOnly = True
        Me.phoneNumMaskedtextbox.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.phoneNumMaskedtextbox.Location = New System.Drawing.Point(235, 293)
        Me.phoneNumMaskedtextbox.Mask = "\0###########"
        Me.phoneNumMaskedtextbox.Name = "phoneNumMaskedtextbox"
        Me.phoneNumMaskedtextbox.Size = New System.Drawing.Size(209, 30)
        Me.phoneNumMaskedtextbox.TabIndex = 6
        '
        'phoneNumberLabel
        '
        Me.phoneNumberLabel.AutoSize = True
        Me.phoneNumberLabel.Font = New System.Drawing.Font("Agency FB", 14.25!)
        Me.phoneNumberLabel.Location = New System.Drawing.Point(106, 296)
        Me.phoneNumberLabel.Name = "phoneNumberLabel"
        Me.phoneNumberLabel.Size = New System.Drawing.Size(99, 24)
        Me.phoneNumberLabel.TabIndex = 38
        Me.phoneNumberLabel.Text = "Phone Number:"
        Me.phoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'editMemberUsercontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.phoneNumberLabel)
        Me.Controls.Add(Me.phoneNumMaskedtextbox)
        Me.Controls.Add(Me.dobLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.memberEditDobDatepicker)
        Me.Controls.Add(Me.memberEditNameTextbox)
        Me.Controls.Add(Me.memberEditSubmitButton)
        Me.Controls.Add(Me.memberEditCancelButton)
        Me.Controls.Add(Me.genderGroupbox)
        Me.Controls.Add(Me.genderLabel)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.memberEditAddressTextbox)
        Me.Controls.Add(Me.titleLabel)
        Me.Name = "editMemberUsercontrol"
        Me.Size = New System.Drawing.Size(576, 423)
        Me.genderGroupbox.ResumeLayout(False)
        Me.genderGroupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleLabel As Label
    Friend WithEvents dobLabel As Label
    Friend WithEvents nameLabel As Label
    Friend WithEvents memberEditDobDatepicker As DateTimePicker
    Friend WithEvents memberEditNameTextbox As TextBox
    Friend WithEvents maleRadioButton As RadioButton
    Friend WithEvents femaleRadioButton As RadioButton
    Friend WithEvents memberEditSubmitButton As Button
    Friend WithEvents memberEditCancelButton As Button
    Friend WithEvents genderGroupbox As GroupBox
    Friend WithEvents genderLabel As Label
    Friend WithEvents addressLabel As Label
    Friend WithEvents memberEditAddressTextbox As TextBox
    Friend WithEvents phoneNumMaskedtextbox As MaskedTextBox
    Friend WithEvents phoneNumberLabel As Label
End Class
