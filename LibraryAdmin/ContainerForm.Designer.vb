<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContainerForm
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
        Me.containerMenustrip = New System.Windows.Forms.MenuStrip()
        Me.FormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.containerMenustrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'containerMenustrip
        '
        Me.containerMenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormsToolStripMenuItem})
        Me.containerMenustrip.Location = New System.Drawing.Point(0, 0)
        Me.containerMenustrip.Name = "containerMenustrip"
        Me.containerMenustrip.Size = New System.Drawing.Size(1143, 24)
        Me.containerMenustrip.TabIndex = 1
        Me.containerMenustrip.Text = "MenuStrip1"
        '
        'FormsToolStripMenuItem
        '
        Me.FormsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberToolStripMenuItem, Me.BookToolStripMenuItem, Me.LendToolStripMenuItem})
        Me.FormsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.FormsToolStripMenuItem.MergeIndex = 1
        Me.FormsToolStripMenuItem.Name = "FormsToolStripMenuItem"
        Me.FormsToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.FormsToolStripMenuItem.Text = "Forms"
        '
        'MemberToolStripMenuItem
        '
        Me.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem"
        Me.MemberToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MemberToolStripMenuItem.Text = "Member"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BookToolStripMenuItem.Text = "Book"
        '
        'LendToolStripMenuItem
        '
        Me.LendToolStripMenuItem.Name = "LendToolStripMenuItem"
        Me.LendToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LendToolStripMenuItem.Text = "Lend"
        '
        'ContainerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 620)
        Me.Controls.Add(Me.containerMenustrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.containerMenustrip
        Me.Name = "ContainerForm"
        Me.Text = "Library Admin Container"
        Me.containerMenustrip.ResumeLayout(False)
        Me.containerMenustrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents containerMenustrip As MenuStrip
    Friend WithEvents FormsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MemberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LendToolStripMenuItem As ToolStripMenuItem
End Class
