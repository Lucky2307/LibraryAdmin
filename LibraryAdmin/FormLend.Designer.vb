<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLend))
        Me.contextSplitter = New System.Windows.Forms.Splitter()
        Me.memberBorrowToolstrip = New System.Windows.Forms.ToolStrip()
        Me.addLendButton = New System.Windows.Forms.ToolStripButton()
        Me.memberDatagrid = New System.Windows.Forms.DataGridView()
        Me.bookListview = New System.Windows.Forms.ListView()
        Me.returnButton = New System.Windows.Forms.Button()
        Me.memberBorrowToolstrip.SuspendLayout()
        CType(Me.memberDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'contextSplitter
        '
        Me.contextSplitter.Dock = System.Windows.Forms.DockStyle.Right
        Me.contextSplitter.Location = New System.Drawing.Point(209, 0)
        Me.contextSplitter.Name = "contextSplitter"
        Me.contextSplitter.Size = New System.Drawing.Size(591, 450)
        Me.contextSplitter.TabIndex = 0
        Me.contextSplitter.TabStop = False
        '
        'memberBorrowToolstrip
        '
        Me.memberBorrowToolstrip.AutoSize = False
        Me.memberBorrowToolstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addLendButton})
        Me.memberBorrowToolstrip.Location = New System.Drawing.Point(0, 0)
        Me.memberBorrowToolstrip.Name = "memberBorrowToolstrip"
        Me.memberBorrowToolstrip.Size = New System.Drawing.Size(209, 25)
        Me.memberBorrowToolstrip.TabIndex = 1
        '
        'addLendButton
        '
        Me.addLendButton.Image = Global.LibraryAdmin.My.Resources.Resources.addButton
        Me.addLendButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.addLendButton.Name = "addLendButton"
        Me.addLendButton.Size = New System.Drawing.Size(49, 22)
        Me.addLendButton.Text = "Add"
        '
        'memberDatagrid
        '
        Me.memberDatagrid.AllowUserToAddRows = False
        Me.memberDatagrid.AllowUserToDeleteRows = False
        Me.memberDatagrid.AllowUserToResizeColumns = False
        Me.memberDatagrid.AllowUserToResizeRows = False
        Me.memberDatagrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.memberDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.memberDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.memberDatagrid.ColumnHeadersVisible = False
        Me.memberDatagrid.Location = New System.Drawing.Point(0, 28)
        Me.memberDatagrid.MultiSelect = False
        Me.memberDatagrid.Name = "memberDatagrid"
        Me.memberDatagrid.ReadOnly = True
        Me.memberDatagrid.RowHeadersVisible = False
        Me.memberDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.memberDatagrid.Size = New System.Drawing.Size(209, 422)
        Me.memberDatagrid.TabIndex = 2
        '
        'bookListview
        '
        Me.bookListview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookListview.HideSelection = False
        Me.bookListview.Location = New System.Drawing.Point(215, 28)
        Me.bookListview.Name = "bookListview"
        Me.bookListview.Size = New System.Drawing.Size(573, 370)
        Me.bookListview.TabIndex = 4
        Me.bookListview.UseCompatibleStateImageBehavior = False
        '
        'returnButton
        '
        Me.returnButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.returnButton.Location = New System.Drawing.Point(688, 409)
        Me.returnButton.Name = "returnButton"
        Me.returnButton.Size = New System.Drawing.Size(100, 33)
        Me.returnButton.TabIndex = 5
        Me.returnButton.Text = "Return Books"
        Me.returnButton.UseVisualStyleBackColor = True
        '
        'FormLend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.returnButton)
        Me.Controls.Add(Me.bookListview)
        Me.Controls.Add(Me.memberDatagrid)
        Me.Controls.Add(Me.memberBorrowToolstrip)
        Me.Controls.Add(Me.contextSplitter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLend"
        Me.Text = "Member Lend View"
        Me.memberBorrowToolstrip.ResumeLayout(False)
        Me.memberBorrowToolstrip.PerformLayout()
        CType(Me.memberDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents contextSplitter As Splitter
    Friend WithEvents memberBorrowToolstrip As ToolStrip
    Friend WithEvents addLendButton As ToolStripButton
    Friend WithEvents memberDatagrid As DataGridView
    Friend WithEvents bookListview As ListView
    Friend WithEvents returnButton As Button
End Class
