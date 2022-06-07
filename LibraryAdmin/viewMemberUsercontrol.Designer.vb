<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewMemberUsercontrol
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addressTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.signupDateTextbox = New System.Windows.Forms.TextBox()
        Me.dobTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.memberNameTextbox = New System.Windows.Forms.TextBox()
        Me.memberPicturebox = New System.Windows.Forms.PictureBox()
        Me.AuthorTableAdapter1 = New LibraryAdmin.LibraryAdminDataSetTableAdapters.authorTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.phoneNumberTextbox = New System.Windows.Forms.TextBox()
        CType(Me.memberPicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(293, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Address:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'addressTextbox
        '
        Me.addressTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addressTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.addressTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.addressTextbox.Location = New System.Drawing.Point(364, 280)
        Me.addressTextbox.MinimumSize = New System.Drawing.Size(166, 83)
        Me.addressTextbox.Multiline = True
        Me.addressTextbox.Name = "addressTextbox"
        Me.addressTextbox.ReadOnly = True
        Me.addressTextbox.Size = New System.Drawing.Size(180, 83)
        Me.addressTextbox.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(260, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Sign up Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'signupDateTextbox
        '
        Me.signupDateTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signupDateTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.signupDateTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.signupDateTextbox.Location = New System.Drawing.Point(364, 224)
        Me.signupDateTextbox.Name = "signupDateTextbox"
        Me.signupDateTextbox.ReadOnly = True
        Me.signupDateTextbox.Size = New System.Drawing.Size(180, 22)
        Me.signupDateTextbox.TabIndex = 23
        '
        'dobTextbox
        '
        Me.dobTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dobTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dobTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dobTextbox.Location = New System.Drawing.Point(364, 196)
        Me.dobTextbox.Name = "dobTextbox"
        Me.dobTextbox.ReadOnly = True
        Me.dobTextbox.Size = New System.Drawing.Size(180, 22)
        Me.dobTextbox.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Date of Birth:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'memberNameTextbox
        '
        Me.memberNameTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memberNameTextbox.BackColor = System.Drawing.SystemColors.Control
        Me.memberNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.memberNameTextbox.Font = New System.Drawing.Font("Bebas", 36.0!)
        Me.memberNameTextbox.Location = New System.Drawing.Point(263, 60)
        Me.memberNameTextbox.Multiline = True
        Me.memberNameTextbox.Name = "memberNameTextbox"
        Me.memberNameTextbox.Size = New System.Drawing.Size(252, 131)
        Me.memberNameTextbox.TabIndex = 20
        Me.memberNameTextbox.Text = "Name"
        '
        'memberPicturebox
        '
        Me.memberPicturebox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.memberPicturebox.InitialImage = Global.LibraryAdmin.My.Resources.Resources.memberButton1
        Me.memberPicturebox.Location = New System.Drawing.Point(15, 60)
        Me.memberPicturebox.Name = "memberPicturebox"
        Me.memberPicturebox.Size = New System.Drawing.Size(223, 303)
        Me.memberPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.memberPicturebox.TabIndex = 19
        Me.memberPicturebox.TabStop = False
        '
        'AuthorTableAdapter1
        '
        Me.AuthorTableAdapter1.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(243, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Phone Number:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'phoneNumberTextbox
        '
        Me.phoneNumberTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.phoneNumberTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.phoneNumberTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.phoneNumberTextbox.Location = New System.Drawing.Point(364, 252)
        Me.phoneNumberTextbox.Name = "phoneNumberTextbox"
        Me.phoneNumberTextbox.ReadOnly = True
        Me.phoneNumberTextbox.Size = New System.Drawing.Size(180, 22)
        Me.phoneNumberTextbox.TabIndex = 28
        '
        'viewMemberUsercontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.phoneNumberTextbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addressTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.signupDateTextbox)
        Me.Controls.Add(Me.dobTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.memberNameTextbox)
        Me.Controls.Add(Me.memberPicturebox)
        Me.Name = "viewMemberUsercontrol"
        Me.Size = New System.Drawing.Size(558, 423)
        CType(Me.memberPicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents addressTextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents signupDateTextbox As TextBox
    Friend WithEvents dobTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents memberNameTextbox As TextBox
    Friend WithEvents memberPicturebox As PictureBox
    Friend WithEvents AuthorTableAdapter1 As LibraryAdminDataSetTableAdapters.authorTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents phoneNumberTextbox As TextBox
End Class
