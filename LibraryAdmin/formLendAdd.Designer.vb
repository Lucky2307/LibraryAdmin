<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLendAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLendAdd))
        Me.memberDatagrid = New System.Windows.Forms.DataGridView()
        Me.bookDatagrid = New System.Windows.Forms.DataGridView()
        Me.memberNameSearchTextbox = New System.Windows.Forms.TextBox()
        Me.bookTitleSearchTextbox = New System.Windows.Forms.TextBox()
        Me.bookSearchButton = New System.Windows.Forms.Button()
        Me.selectedBookListbox = New System.Windows.Forms.ListBox()
        Me.confirmButton = New System.Windows.Forms.Button()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.memberSearchButton = New System.Windows.Forms.Button()
        Me.intervalNumupdown = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.memberDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bookDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.intervalNumupdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'memberDatagrid
        '
        Me.memberDatagrid.AllowUserToAddRows = False
        Me.memberDatagrid.AllowUserToDeleteRows = False
        Me.memberDatagrid.AllowUserToResizeRows = False
        Me.memberDatagrid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.memberDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.memberDatagrid.Location = New System.Drawing.Point(12, 78)
        Me.memberDatagrid.MultiSelect = False
        Me.memberDatagrid.Name = "memberDatagrid"
        Me.memberDatagrid.ReadOnly = True
        Me.memberDatagrid.RowHeadersVisible = False
        Me.memberDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.memberDatagrid.Size = New System.Drawing.Size(233, 355)
        Me.memberDatagrid.TabIndex = 2
        '
        'bookDatagrid
        '
        Me.bookDatagrid.AllowUserToAddRows = False
        Me.bookDatagrid.AllowUserToDeleteRows = False
        Me.bookDatagrid.AllowUserToResizeRows = False
        Me.bookDatagrid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bookDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bookDatagrid.Location = New System.Drawing.Point(282, 78)
        Me.bookDatagrid.MultiSelect = False
        Me.bookDatagrid.Name = "bookDatagrid"
        Me.bookDatagrid.ReadOnly = True
        Me.bookDatagrid.RowHeadersVisible = False
        Me.bookDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.bookDatagrid.Size = New System.Drawing.Size(233, 355)
        Me.bookDatagrid.TabIndex = 3
        '
        'memberNameSearchTextbox
        '
        Me.memberNameSearchTextbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.memberNameSearchTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.memberNameSearchTextbox.Location = New System.Drawing.Point(12, 46)
        Me.memberNameSearchTextbox.Name = "memberNameSearchTextbox"
        Me.memberNameSearchTextbox.Size = New System.Drawing.Size(194, 26)
        Me.memberNameSearchTextbox.TabIndex = 4
        '
        'bookTitleSearchTextbox
        '
        Me.bookTitleSearchTextbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bookTitleSearchTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.bookTitleSearchTextbox.Location = New System.Drawing.Point(282, 46)
        Me.bookTitleSearchTextbox.Name = "bookTitleSearchTextbox"
        Me.bookTitleSearchTextbox.Size = New System.Drawing.Size(194, 26)
        Me.bookTitleSearchTextbox.TabIndex = 5
        '
        'bookSearchButton
        '
        Me.bookSearchButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bookSearchButton.BackgroundImage = Global.LibraryAdmin.My.Resources.Resources.search
        Me.bookSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bookSearchButton.FlatAppearance.BorderSize = 0
        Me.bookSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bookSearchButton.Location = New System.Drawing.Point(482, 47)
        Me.bookSearchButton.Name = "bookSearchButton"
        Me.bookSearchButton.Size = New System.Drawing.Size(33, 26)
        Me.bookSearchButton.TabIndex = 7
        Me.bookSearchButton.UseVisualStyleBackColor = True
        '
        'selectedBookListbox
        '
        Me.selectedBookListbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.selectedBookListbox.FormattingEnabled = True
        Me.selectedBookListbox.Location = New System.Drawing.Point(605, 78)
        Me.selectedBookListbox.Name = "selectedBookListbox"
        Me.selectedBookListbox.Size = New System.Drawing.Size(264, 316)
        Me.selectedBookListbox.TabIndex = 8
        '
        'confirmButton
        '
        Me.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.confirmButton.Location = New System.Drawing.Point(781, 457)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(86, 37)
        Me.confirmButton.TabIndex = 11
        Me.confirmButton.Text = "Confirm"
        Me.confirmButton.UseVisualStyleBackColor = True
        '
        'cancelButton
        '
        Me.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cancelButton.Location = New System.Drawing.Point(678, 457)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(86, 37)
        Me.cancelButton.TabIndex = 12
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.removeButton.BackgroundImage = Global.LibraryAdmin.My.Resources.Resources.remove
        Me.removeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.removeButton.FlatAppearance.BorderSize = 0
        Me.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeButton.Location = New System.Drawing.Point(546, 227)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(42, 36)
        Me.removeButton.TabIndex = 10
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.addButton.BackgroundImage = Global.LibraryAdmin.My.Resources.Resources.add
        Me.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addButton.FlatAppearance.BorderSize = 0
        Me.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addButton.Location = New System.Drawing.Point(546, 175)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(42, 36)
        Me.addButton.TabIndex = 9
        Me.addButton.UseVisualStyleBackColor = True
        '
        'memberSearchButton
        '
        Me.memberSearchButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.memberSearchButton.BackgroundImage = Global.LibraryAdmin.My.Resources.Resources.search
        Me.memberSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.memberSearchButton.FlatAppearance.BorderSize = 0
        Me.memberSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.memberSearchButton.Location = New System.Drawing.Point(212, 46)
        Me.memberSearchButton.Name = "memberSearchButton"
        Me.memberSearchButton.Size = New System.Drawing.Size(33, 26)
        Me.memberSearchButton.TabIndex = 6
        Me.memberSearchButton.UseVisualStyleBackColor = True
        '
        'intervalNumupdown
        '
        Me.intervalNumupdown.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.intervalNumupdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.intervalNumupdown.Location = New System.Drawing.Point(646, 404)
        Me.intervalNumupdown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.intervalNumupdown.Name = "intervalNumupdown"
        Me.intervalNumupdown.Size = New System.Drawing.Size(154, 29)
        Me.intervalNumupdown.TabIndex = 13
        Me.intervalNumupdown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(601, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "For"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(806, 406)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "day(s)"
        '
        'formLendAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 506)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.intervalNumupdown)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.confirmButton)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.selectedBookListbox)
        Me.Controls.Add(Me.bookSearchButton)
        Me.Controls.Add(Me.memberSearchButton)
        Me.Controls.Add(Me.bookTitleSearchTextbox)
        Me.Controls.Add(Me.memberNameSearchTextbox)
        Me.Controls.Add(Me.bookDatagrid)
        Me.Controls.Add(Me.memberDatagrid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formLendAdd"
        Me.Text = "Borrow Books"
        CType(Me.memberDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bookDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.intervalNumupdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents memberDatagrid As DataGridView
    Friend WithEvents bookDatagrid As DataGridView
    Friend WithEvents memberNameSearchTextbox As TextBox
    Friend WithEvents bookTitleSearchTextbox As TextBox
    Friend WithEvents memberSearchButton As Button
    Friend WithEvents bookSearchButton As Button
    Friend WithEvents selectedBookListbox As ListBox
    Friend WithEvents addButton As Button
    Friend WithEvents removeButton As Button
    Friend WithEvents confirmButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents intervalNumupdown As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
