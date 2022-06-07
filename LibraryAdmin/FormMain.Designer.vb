<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.footerProgressbar = New System.Windows.Forms.ToolStripProgressBar()
        Me.footerStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.footerProgramTimerLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dateStatuslabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainMenustrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.programTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.mainTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.borrowFormButton = New System.Windows.Forms.Button()
        Me.bookFormButton = New System.Windows.Forms.Button()
        Me.memberFormButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormContainerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusStrip.SuspendLayout()
        Me.mainMenustrip.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.footerProgressbar, Me.footerStatusLabel, Me.ToolStripStatusLabel1, Me.footerProgramTimerLabel, Me.dateStatuslabel})
        Me.statusStrip.Location = New System.Drawing.Point(0, 620)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(1008, 22)
        Me.statusStrip.TabIndex = 1
        Me.statusStrip.Text = "StatusStrip1"
        '
        'footerProgressbar
        '
        Me.footerProgressbar.Name = "footerProgressbar"
        Me.footerProgressbar.Size = New System.Drawing.Size(100, 16)
        '
        'footerStatusLabel
        '
        Me.footerStatusLabel.Name = "footerStatusLabel"
        Me.footerStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.footerStatusLabel.Text = "Status"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(691, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'footerProgramTimerLabel
        '
        Me.footerProgramTimerLabel.Name = "footerProgramTimerLabel"
        Me.footerProgramTimerLabel.Size = New System.Drawing.Size(161, 17)
        Me.footerProgramTimerLabel.Text = "Program has been active for: "
        '
        'dateStatuslabel
        '
        Me.dateStatuslabel.Name = "dateStatuslabel"
        Me.dateStatuslabel.Size = New System.Drawing.Size(0, 17)
        '
        'mainMenustrip
        '
        Me.mainMenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mainMenustrip.Location = New System.Drawing.Point(0, 0)
        Me.mainMenustrip.Name = "mainMenustrip"
        Me.mainMenustrip.Size = New System.Drawing.Size(1008, 24)
        Me.mainMenustrip.TabIndex = 2
        Me.mainMenustrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.MergeIndex = 0
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.MergeIndex = 2
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'programTimer
        '
        Me.programTimer.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(550, 74)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(312, 142)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Library Administration"
        Me.mainTooltip.SetToolTip(Me.TextBox1, "Hello!")
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(562, 194)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 13)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "ver 0.01a"
        '
        'mainTooltip
        '
        Me.mainTooltip.ToolTipTitle = "Tooltip"
        '
        'borrowFormButton
        '
        Me.borrowFormButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.borrowFormButton.BackColor = System.Drawing.Color.White
        Me.borrowFormButton.BackgroundImage = Global.LibraryAdmin.My.Resources.Resources.borrowButton4
        Me.borrowFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.borrowFormButton.FlatAppearance.BorderSize = 0
        Me.borrowFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.borrowFormButton.Location = New System.Drawing.Point(712, 347)
        Me.borrowFormButton.Name = "borrowFormButton"
        Me.borrowFormButton.Size = New System.Drawing.Size(200, 200)
        Me.borrowFormButton.TabIndex = 3
        Me.mainTooltip.SetToolTip(Me.borrowFormButton, "View, add, or return books")
        Me.borrowFormButton.UseVisualStyleBackColor = False
        '
        'bookFormButton
        '
        Me.bookFormButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bookFormButton.BackColor = System.Drawing.Color.White
        Me.bookFormButton.BackgroundImage = Global.LibraryAdmin.My.Resources.Resources.bookButton
        Me.bookFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bookFormButton.FlatAppearance.BorderSize = 0
        Me.bookFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bookFormButton.Location = New System.Drawing.Point(413, 347)
        Me.bookFormButton.Name = "bookFormButton"
        Me.bookFormButton.Size = New System.Drawing.Size(200, 200)
        Me.bookFormButton.TabIndex = 2
        Me.mainTooltip.SetToolTip(Me.bookFormButton, "View registered books in the library")
        Me.bookFormButton.UseVisualStyleBackColor = False
        '
        'memberFormButton
        '
        Me.memberFormButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.memberFormButton.BackColor = System.Drawing.Color.White
        Me.memberFormButton.BackgroundImage = Global.LibraryAdmin.My.Resources.Resources.memberButton1
        Me.memberFormButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.memberFormButton.FlatAppearance.BorderSize = 0
        Me.memberFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.memberFormButton.Location = New System.Drawing.Point(112, 347)
        Me.memberFormButton.Name = "memberFormButton"
        Me.memberFormButton.Size = New System.Drawing.Size(200, 200)
        Me.memberFormButton.TabIndex = 1
        Me.mainTooltip.SetToolTip(Me.memberFormButton, "View, add, edit, or delete library members")
        Me.memberFormButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.LibraryAdmin.My.Resources.Resources.iconfinder_bookshelf_1055107
        Me.PictureBox1.Location = New System.Drawing.Point(297, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 247)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormContainerToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'FormContainerToolStripMenuItem
        '
        Me.FormContainerToolStripMenuItem.Name = "FormContainerToolStripMenuItem"
        Me.FormContainerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FormContainerToolStripMenuItem.Text = "Form Container"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 642)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.borrowFormButton)
        Me.Controls.Add(Me.bookFormButton)
        Me.Controls.Add(Me.memberFormButton)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.mainMenustrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Library Administrator"
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.mainMenustrip.ResumeLayout(False)
        Me.mainMenustrip.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusStrip As StatusStrip
    Friend WithEvents mainMenustrip As MenuStrip
    Friend WithEvents footerProgressbar As ToolStripProgressBar
    Friend WithEvents footerStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents footerProgramTimerLabel As ToolStripStatusLabel
    Friend WithEvents programTimer As Timer
    Friend WithEvents memberFormButton As Button
    Friend WithEvents bookFormButton As Button
    Friend WithEvents borrowFormButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents dateStatuslabel As ToolStripStatusLabel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mainTooltip As ToolTip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormContainerToolStripMenuItem As ToolStripMenuItem
End Class
