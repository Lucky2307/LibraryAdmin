<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLendReturn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLendReturn))
        Me.bookCheckedlist = New System.Windows.Forms.CheckedListBox()
        Me.selectAllButton = New System.Windows.Forms.Button()
        Me.deselectAllButton = New System.Windows.Forms.Button()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bookCheckedlist
        '
        Me.bookCheckedlist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bookCheckedlist.FormattingEnabled = True
        Me.bookCheckedlist.Location = New System.Drawing.Point(43, 44)
        Me.bookCheckedlist.Name = "bookCheckedlist"
        Me.bookCheckedlist.Size = New System.Drawing.Size(361, 364)
        Me.bookCheckedlist.TabIndex = 0
        '
        'selectAllButton
        '
        Me.selectAllButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.selectAllButton.Location = New System.Drawing.Point(436, 68)
        Me.selectAllButton.Name = "selectAllButton"
        Me.selectAllButton.Size = New System.Drawing.Size(76, 32)
        Me.selectAllButton.TabIndex = 1
        Me.selectAllButton.Text = "Select All"
        Me.selectAllButton.UseVisualStyleBackColor = True
        '
        'deselectAllButton
        '
        Me.deselectAllButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.deselectAllButton.Location = New System.Drawing.Point(436, 106)
        Me.deselectAllButton.Name = "deselectAllButton"
        Me.deselectAllButton.Size = New System.Drawing.Size(76, 32)
        Me.deselectAllButton.TabIndex = 2
        Me.deselectAllButton.Text = "Deselect All"
        Me.deselectAllButton.UseVisualStyleBackColor = True
        '
        'confirmButton
        '
        Me.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.confirmButton.Location = New System.Drawing.Point(436, 346)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(76, 62)
        Me.confirmButton.TabIndex = 3
        Me.confirmButton.Text = "Confirm Return"
        Me.confirmButton.UseVisualStyleBackColor = True
        '
        'formLendReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 450)
        Me.Controls.Add(Me.confirmButton)
        Me.Controls.Add(Me.deselectAllButton)
        Me.Controls.Add(Me.selectAllButton)
        Me.Controls.Add(Me.bookCheckedlist)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formLendReturn"
        Me.Text = "Return Books"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bookCheckedlist As CheckedListBox
    Friend WithEvents selectAllButton As Button
    Friend WithEvents deselectAllButton As Button
    Friend WithEvents confirmButton As Button
End Class
