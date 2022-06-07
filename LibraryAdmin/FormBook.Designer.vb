<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBook
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBook))
        Me.footerStatus = New System.Windows.Forms.StatusStrip()
        Me.footerProgressbar = New System.Windows.Forms.ToolStripProgressBar()
        Me.footerStatuslabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainSplitcontainer = New System.Windows.Forms.SplitContainer()
        Me.bookDatagrid = New System.Windows.Forms.DataGridView()
        Me.bookDetailTabcontrol = New System.Windows.Forms.TabControl()
        Me.bookDetailTab = New System.Windows.Forms.TabPage()
        Me.searchGroupbox = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.shopLink = New System.Windows.Forms.LinkLabel()
        Me.bookSearchButton = New System.Windows.Forms.Button()
        Me.bookSearchCombobox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bookPositionTextbox = New System.Windows.Forms.TextBox()
        Me.bookPublisherTextbox = New System.Windows.Forms.TextBox()
        Me.bookAuthorTextbox = New System.Windows.Forms.TextBox()
        Me.bookPagecountTextbox = New System.Windows.Forms.TextBox()
        Me.bookIsbnTextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bookTextbox = New System.Windows.Forms.TextBox()
        Me.bookPicturebox = New System.Windows.Forms.PictureBox()
        Me.authorDetailTab = New System.Windows.Forms.TabPage()
        Me.authorPictureNextButton = New System.Windows.Forms.Button()
        Me.authorPicturePreviousButton = New System.Windows.Forms.Button()
        Me.authorDobTextbox = New System.Windows.Forms.TextBox()
        Me.authorNationalityTextbox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.authorTextbox = New System.Windows.Forms.TextBox()
        Me.authorPicturebox = New System.Windows.Forms.PictureBox()
        Me.publisherDetailTab = New System.Windows.Forms.TabPage()
        Me.searchPublisehrLink = New System.Windows.Forms.LinkLabel()
        Me.publisherAddressTextbox = New System.Windows.Forms.TextBox()
        Me.publisherYearTextbox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.publisherTextbox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.publisherPicturebox = New System.Windows.Forms.PictureBox()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryAdminDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryAdminDataSet = New LibraryAdmin.LibraryAdminDataSet()
        Me.bookStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TermsOfServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookTableAdapter = New LibraryAdmin.LibraryAdminDataSetTableAdapters.bookTableAdapter()
        Me.authorImagelist = New System.Windows.Forms.ImageList(Me.components)
        Me.footerStatus.SuspendLayout()
        CType(Me.mainSplitcontainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainSplitcontainer.Panel1.SuspendLayout()
        Me.mainSplitcontainer.Panel2.SuspendLayout()
        Me.mainSplitcontainer.SuspendLayout()
        CType(Me.bookDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bookDetailTabcontrol.SuspendLayout()
        Me.bookDetailTab.SuspendLayout()
        Me.searchGroupbox.SuspendLayout()
        CType(Me.bookPicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.authorDetailTab.SuspendLayout()
        CType(Me.authorPicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.publisherDetailTab.SuspendLayout()
        CType(Me.publisherPicturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryAdminDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryAdminDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bookStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'footerStatus
        '
        Me.footerStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.footerProgressbar, Me.footerStatuslabel})
        Me.footerStatus.Location = New System.Drawing.Point(0, 439)
        Me.footerStatus.Name = "footerStatus"
        Me.footerStatus.Size = New System.Drawing.Size(1034, 22)
        Me.footerStatus.TabIndex = 1
        Me.footerStatus.Text = "StatusStrip1"
        '
        'footerProgressbar
        '
        Me.footerProgressbar.Name = "footerProgressbar"
        Me.footerProgressbar.Size = New System.Drawing.Size(100, 16)
        Me.footerProgressbar.Step = 50
        '
        'footerStatuslabel
        '
        Me.footerStatuslabel.Name = "footerStatuslabel"
        Me.footerStatuslabel.Size = New System.Drawing.Size(39, 17)
        Me.footerStatuslabel.Text = "Status"
        '
        'mainSplitcontainer
        '
        Me.mainSplitcontainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainSplitcontainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.mainSplitcontainer.IsSplitterFixed = True
        Me.mainSplitcontainer.Location = New System.Drawing.Point(0, 24)
        Me.mainSplitcontainer.Name = "mainSplitcontainer"
        '
        'mainSplitcontainer.Panel1
        '
        Me.mainSplitcontainer.Panel1.Controls.Add(Me.bookDatagrid)
        '
        'mainSplitcontainer.Panel2
        '
        Me.mainSplitcontainer.Panel2.Controls.Add(Me.bookDetailTabcontrol)
        Me.mainSplitcontainer.Size = New System.Drawing.Size(1034, 415)
        Me.mainSplitcontainer.SplitterDistance = 398
        Me.mainSplitcontainer.TabIndex = 2
        '
        'bookDatagrid
        '
        Me.bookDatagrid.AllowUserToAddRows = False
        Me.bookDatagrid.AllowUserToDeleteRows = False
        Me.bookDatagrid.AllowUserToResizeColumns = False
        Me.bookDatagrid.AllowUserToResizeRows = False
        Me.bookDatagrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bookDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bookDatagrid.Location = New System.Drawing.Point(12, 7)
        Me.bookDatagrid.Name = "bookDatagrid"
        Me.bookDatagrid.ReadOnly = True
        Me.bookDatagrid.RowHeadersVisible = False
        Me.bookDatagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.bookDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.bookDatagrid.Size = New System.Drawing.Size(383, 404)
        Me.bookDatagrid.TabIndex = 1
        '
        'bookDetailTabcontrol
        '
        Me.bookDetailTabcontrol.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookDetailTabcontrol.Controls.Add(Me.bookDetailTab)
        Me.bookDetailTabcontrol.Controls.Add(Me.authorDetailTab)
        Me.bookDetailTabcontrol.Controls.Add(Me.publisherDetailTab)
        Me.bookDetailTabcontrol.Location = New System.Drawing.Point(6, 7)
        Me.bookDetailTabcontrol.Name = "bookDetailTabcontrol"
        Me.bookDetailTabcontrol.SelectedIndex = 0
        Me.bookDetailTabcontrol.Size = New System.Drawing.Size(626, 404)
        Me.bookDetailTabcontrol.TabIndex = 0
        '
        'bookDetailTab
        '
        Me.bookDetailTab.Controls.Add(Me.searchGroupbox)
        Me.bookDetailTab.Controls.Add(Me.bookPositionTextbox)
        Me.bookDetailTab.Controls.Add(Me.bookPublisherTextbox)
        Me.bookDetailTab.Controls.Add(Me.bookAuthorTextbox)
        Me.bookDetailTab.Controls.Add(Me.bookPagecountTextbox)
        Me.bookDetailTab.Controls.Add(Me.bookIsbnTextbox)
        Me.bookDetailTab.Controls.Add(Me.Label5)
        Me.bookDetailTab.Controls.Add(Me.Label4)
        Me.bookDetailTab.Controls.Add(Me.Label3)
        Me.bookDetailTab.Controls.Add(Me.Label2)
        Me.bookDetailTab.Controls.Add(Me.Label1)
        Me.bookDetailTab.Controls.Add(Me.bookTextbox)
        Me.bookDetailTab.Controls.Add(Me.bookPicturebox)
        Me.bookDetailTab.Font = New System.Drawing.Font("Candara", 12.0!)
        Me.bookDetailTab.Location = New System.Drawing.Point(4, 22)
        Me.bookDetailTab.Name = "bookDetailTab"
        Me.bookDetailTab.Padding = New System.Windows.Forms.Padding(3)
        Me.bookDetailTab.Size = New System.Drawing.Size(618, 378)
        Me.bookDetailTab.TabIndex = 0
        Me.bookDetailTab.Text = "Book"
        Me.bookDetailTab.UseVisualStyleBackColor = True
        '
        'searchGroupbox
        '
        Me.searchGroupbox.Controls.Add(Me.Label7)
        Me.searchGroupbox.Controls.Add(Me.shopLink)
        Me.searchGroupbox.Controls.Add(Me.bookSearchButton)
        Me.searchGroupbox.Controls.Add(Me.bookSearchCombobox)
        Me.searchGroupbox.Controls.Add(Me.Label6)
        Me.searchGroupbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.searchGroupbox.Location = New System.Drawing.Point(313, 240)
        Me.searchGroupbox.Name = "searchGroupbox"
        Me.searchGroupbox.Size = New System.Drawing.Size(294, 131)
        Me.searchGroupbox.TabIndex = 12
        Me.searchGroupbox.TabStop = False
        Me.searchGroupbox.Text = "Search for this book online"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "for this book online."
        '
        'shopLink
        '
        Me.shopLink.AutoSize = True
        Me.shopLink.Location = New System.Drawing.Point(6, 100)
        Me.shopLink.Name = "shopLink"
        Me.shopLink.Size = New System.Drawing.Size(46, 21)
        Me.shopLink.TabIndex = 3
        Me.shopLink.TabStop = True
        Me.shopLink.Text = "Shop"
        '
        'bookSearchButton
        '
        Me.bookSearchButton.Location = New System.Drawing.Point(177, 68)
        Me.bookSearchButton.Name = "bookSearchButton"
        Me.bookSearchButton.Size = New System.Drawing.Size(99, 26)
        Me.bookSearchButton.TabIndex = 2
        Me.bookSearchButton.Text = "Search"
        Me.bookSearchButton.UseVisualStyleBackColor = True
        '
        'bookSearchCombobox
        '
        Me.bookSearchCombobox.FormattingEnabled = True
        Me.bookSearchCombobox.Items.AddRange(New Object() {"Google", "Openlibrary", "Amazon"})
        Me.bookSearchCombobox.Location = New System.Drawing.Point(177, 31)
        Me.bookSearchCombobox.Name = "bookSearchCombobox"
        Me.bookSearchCombobox.Size = New System.Drawing.Size(99, 29)
        Me.bookSearchCombobox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(171, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Search for this book on"
        '
        'bookPositionTextbox
        '
        Me.bookPositionTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookPositionTextbox.BackColor = System.Drawing.Color.White
        Me.bookPositionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bookPositionTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.bookPositionTextbox.Location = New System.Drawing.Point(416, 216)
        Me.bookPositionTextbox.Name = "bookPositionTextbox"
        Me.bookPositionTextbox.ReadOnly = True
        Me.bookPositionTextbox.Size = New System.Drawing.Size(178, 22)
        Me.bookPositionTextbox.TabIndex = 11
        '
        'bookPublisherTextbox
        '
        Me.bookPublisherTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookPublisherTextbox.BackColor = System.Drawing.Color.White
        Me.bookPublisherTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bookPublisherTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.bookPublisherTextbox.Location = New System.Drawing.Point(416, 188)
        Me.bookPublisherTextbox.Name = "bookPublisherTextbox"
        Me.bookPublisherTextbox.ReadOnly = True
        Me.bookPublisherTextbox.Size = New System.Drawing.Size(178, 22)
        Me.bookPublisherTextbox.TabIndex = 10
        '
        'bookAuthorTextbox
        '
        Me.bookAuthorTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookAuthorTextbox.BackColor = System.Drawing.Color.White
        Me.bookAuthorTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bookAuthorTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.bookAuthorTextbox.Location = New System.Drawing.Point(416, 160)
        Me.bookAuthorTextbox.Name = "bookAuthorTextbox"
        Me.bookAuthorTextbox.ReadOnly = True
        Me.bookAuthorTextbox.Size = New System.Drawing.Size(178, 22)
        Me.bookAuthorTextbox.TabIndex = 9
        '
        'bookPagecountTextbox
        '
        Me.bookPagecountTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookPagecountTextbox.BackColor = System.Drawing.Color.White
        Me.bookPagecountTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bookPagecountTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.bookPagecountTextbox.Location = New System.Drawing.Point(416, 132)
        Me.bookPagecountTextbox.Name = "bookPagecountTextbox"
        Me.bookPagecountTextbox.ReadOnly = True
        Me.bookPagecountTextbox.Size = New System.Drawing.Size(178, 22)
        Me.bookPagecountTextbox.TabIndex = 8
        '
        'bookIsbnTextbox
        '
        Me.bookIsbnTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bookIsbnTextbox.BackColor = System.Drawing.Color.White
        Me.bookIsbnTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bookIsbnTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.bookIsbnTextbox.Location = New System.Drawing.Point(416, 104)
        Me.bookIsbnTextbox.Name = "bookIsbnTextbox"
        Me.bookIsbnTextbox.ReadOnly = True
        Me.bookIsbnTextbox.Size = New System.Drawing.Size(178, 22)
        Me.bookIsbnTextbox.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(302, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Book position:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(332, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Publisher:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(349, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Author:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(321, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Page count:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ISBN:"
        '
        'bookTextbox
        '
        Me.bookTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bookTextbox.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookTextbox.Location = New System.Drawing.Point(302, 6)
        Me.bookTextbox.Multiline = True
        Me.bookTextbox.Name = "bookTextbox"
        Me.bookTextbox.Size = New System.Drawing.Size(305, 92)
        Me.bookTextbox.TabIndex = 1
        Me.bookTextbox.Text = "Select a book from the table to view details"
        '
        'bookPicturebox
        '
        Me.bookPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bookPicturebox.Location = New System.Drawing.Point(6, 6)
        Me.bookPicturebox.Name = "bookPicturebox"
        Me.bookPicturebox.Size = New System.Drawing.Size(290, 366)
        Me.bookPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bookPicturebox.TabIndex = 0
        Me.bookPicturebox.TabStop = False
        '
        'authorDetailTab
        '
        Me.authorDetailTab.Controls.Add(Me.authorPictureNextButton)
        Me.authorDetailTab.Controls.Add(Me.authorPicturePreviousButton)
        Me.authorDetailTab.Controls.Add(Me.authorDobTextbox)
        Me.authorDetailTab.Controls.Add(Me.authorNationalityTextbox)
        Me.authorDetailTab.Controls.Add(Me.Label9)
        Me.authorDetailTab.Controls.Add(Me.Label8)
        Me.authorDetailTab.Controls.Add(Me.authorTextbox)
        Me.authorDetailTab.Controls.Add(Me.authorPicturebox)
        Me.authorDetailTab.Location = New System.Drawing.Point(4, 22)
        Me.authorDetailTab.Name = "authorDetailTab"
        Me.authorDetailTab.Padding = New System.Windows.Forms.Padding(3)
        Me.authorDetailTab.Size = New System.Drawing.Size(618, 378)
        Me.authorDetailTab.TabIndex = 1
        Me.authorDetailTab.Text = "Author"
        Me.authorDetailTab.UseVisualStyleBackColor = True
        '
        'authorPictureNextButton
        '
        Me.authorPictureNextButton.Location = New System.Drawing.Point(242, 350)
        Me.authorPictureNextButton.Name = "authorPictureNextButton"
        Me.authorPictureNextButton.Size = New System.Drawing.Size(48, 25)
        Me.authorPictureNextButton.TabIndex = 7
        Me.authorPictureNextButton.Text = ">"
        Me.authorPictureNextButton.UseVisualStyleBackColor = True
        '
        'authorPicturePreviousButton
        '
        Me.authorPicturePreviousButton.Location = New System.Drawing.Point(12, 350)
        Me.authorPicturePreviousButton.Name = "authorPicturePreviousButton"
        Me.authorPicturePreviousButton.Size = New System.Drawing.Size(48, 25)
        Me.authorPicturePreviousButton.TabIndex = 6
        Me.authorPicturePreviousButton.Text = "<"
        Me.authorPicturePreviousButton.UseVisualStyleBackColor = True
        '
        'authorDobTextbox
        '
        Me.authorDobTextbox.BackColor = System.Drawing.Color.White
        Me.authorDobTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.authorDobTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.authorDobTextbox.Location = New System.Drawing.Point(429, 147)
        Me.authorDobTextbox.Name = "authorDobTextbox"
        Me.authorDobTextbox.ReadOnly = True
        Me.authorDobTextbox.Size = New System.Drawing.Size(181, 22)
        Me.authorDobTextbox.TabIndex = 5
        '
        'authorNationalityTextbox
        '
        Me.authorNationalityTextbox.BackColor = System.Drawing.Color.White
        Me.authorNationalityTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.authorNationalityTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.authorNationalityTextbox.Location = New System.Drawing.Point(429, 113)
        Me.authorNationalityTextbox.Name = "authorNationalityTextbox"
        Me.authorNationalityTextbox.ReadOnly = True
        Me.authorNationalityTextbox.Size = New System.Drawing.Size(181, 22)
        Me.authorNationalityTextbox.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(296, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 21)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Date of Birth:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(307, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Nationality:"
        '
        'authorTextbox
        '
        Me.authorTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.authorTextbox.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.authorTextbox.Location = New System.Drawing.Point(295, 15)
        Me.authorTextbox.Multiline = True
        Me.authorTextbox.Name = "authorTextbox"
        Me.authorTextbox.Size = New System.Drawing.Size(265, 78)
        Me.authorTextbox.TabIndex = 1
        Me.authorTextbox.Text = "Select a book from the table"
        '
        'authorPicturebox
        '
        Me.authorPicturebox.Location = New System.Drawing.Point(12, 15)
        Me.authorPicturebox.Name = "authorPicturebox"
        Me.authorPicturebox.Size = New System.Drawing.Size(278, 333)
        Me.authorPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.authorPicturebox.TabIndex = 0
        Me.authorPicturebox.TabStop = False
        '
        'publisherDetailTab
        '
        Me.publisherDetailTab.Controls.Add(Me.searchPublisehrLink)
        Me.publisherDetailTab.Controls.Add(Me.publisherAddressTextbox)
        Me.publisherDetailTab.Controls.Add(Me.publisherYearTextbox)
        Me.publisherDetailTab.Controls.Add(Me.Label11)
        Me.publisherDetailTab.Controls.Add(Me.publisherTextbox)
        Me.publisherDetailTab.Controls.Add(Me.Label10)
        Me.publisherDetailTab.Controls.Add(Me.publisherPicturebox)
        Me.publisherDetailTab.Location = New System.Drawing.Point(4, 22)
        Me.publisherDetailTab.Name = "publisherDetailTab"
        Me.publisherDetailTab.Size = New System.Drawing.Size(618, 378)
        Me.publisherDetailTab.TabIndex = 2
        Me.publisherDetailTab.Text = "Publisher"
        Me.publisherDetailTab.UseVisualStyleBackColor = True
        '
        'searchPublisehrLink
        '
        Me.searchPublisehrLink.AutoSize = True
        Me.searchPublisehrLink.Location = New System.Drawing.Point(17, 317)
        Me.searchPublisehrLink.Name = "searchPublisehrLink"
        Me.searchPublisehrLink.Size = New System.Drawing.Size(78, 13)
        Me.searchPublisehrLink.TabIndex = 6
        Me.searchPublisehrLink.TabStop = True
        Me.searchPublisehrLink.Text = "(Search online)"
        '
        'publisherAddressTextbox
        '
        Me.publisherAddressTextbox.BackColor = System.Drawing.Color.White
        Me.publisherAddressTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.publisherAddressTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.publisherAddressTextbox.Location = New System.Drawing.Point(101, 296)
        Me.publisherAddressTextbox.Multiline = True
        Me.publisherAddressTextbox.Name = "publisherAddressTextbox"
        Me.publisherAddressTextbox.Size = New System.Drawing.Size(491, 45)
        Me.publisherAddressTextbox.TabIndex = 5
        '
        'publisherYearTextbox
        '
        Me.publisherYearTextbox.BackColor = System.Drawing.Color.White
        Me.publisherYearTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.publisherYearTextbox.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.publisherYearTextbox.Location = New System.Drawing.Point(101, 268)
        Me.publisherYearTextbox.Name = "publisherYearTextbox"
        Me.publisherYearTextbox.Size = New System.Drawing.Size(100, 22)
        Me.publisherYearTextbox.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(25, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 21)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Address: "
        '
        'publisherTextbox
        '
        Me.publisherTextbox.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.publisherTextbox.Location = New System.Drawing.Point(339, 39)
        Me.publisherTextbox.Multiline = True
        Me.publisherTextbox.Name = "publisherTextbox"
        Me.publisherTextbox.Size = New System.Drawing.Size(253, 181)
        Me.publisherTextbox.TabIndex = 2
        Me.publisherTextbox.Text = "Select a book from the table"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(3, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 21)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Founded in: "
        '
        'publisherPicturebox
        '
        Me.publisherPicturebox.Location = New System.Drawing.Point(25, 3)
        Me.publisherPicturebox.Name = "publisherPicturebox"
        Me.publisherPicturebox.Size = New System.Drawing.Size(308, 237)
        Me.publisherPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.publisherPicturebox.TabIndex = 0
        Me.publisherPicturebox.TabStop = False
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "book"
        Me.BookBindingSource.DataSource = Me.LibraryAdminDataSetBindingSource
        '
        'LibraryAdminDataSetBindingSource
        '
        Me.LibraryAdminDataSetBindingSource.DataSource = Me.LibraryAdminDataSet
        Me.LibraryAdminDataSetBindingSource.Position = 0
        '
        'LibraryAdminDataSet
        '
        Me.LibraryAdminDataSet.DataSetName = "LibraryAdminDataSet"
        Me.LibraryAdminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bookStrip
        '
        Me.bookStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.bookStrip.Location = New System.Drawing.Point(0, 0)
        Me.bookStrip.Name = "bookStrip"
        Me.bookStrip.Size = New System.Drawing.Size(1034, 24)
        Me.bookStrip.TabIndex = 3
        Me.bookStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.TermsOfServiceToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TermsOfServiceToolStripMenuItem
        '
        Me.TermsOfServiceToolStripMenuItem.Name = "TermsOfServiceToolStripMenuItem"
        Me.TermsOfServiceToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.TermsOfServiceToolStripMenuItem.Text = "Terms of Service"
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'authorImagelist
        '
        Me.authorImagelist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.authorImagelist.ImageSize = New System.Drawing.Size(225, 225)
        Me.authorImagelist.TransparentColor = System.Drawing.Color.Transparent
        '
        'FormBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 461)
        Me.Controls.Add(Me.mainSplitcontainer)
        Me.Controls.Add(Me.footerStatus)
        Me.Controls.Add(Me.bookStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.bookStrip
        Me.MinimumSize = New System.Drawing.Size(1000, 500)
        Me.Name = "FormBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Viewer"
        Me.footerStatus.ResumeLayout(False)
        Me.footerStatus.PerformLayout()
        Me.mainSplitcontainer.Panel1.ResumeLayout(False)
        Me.mainSplitcontainer.Panel2.ResumeLayout(False)
        CType(Me.mainSplitcontainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainSplitcontainer.ResumeLayout(False)
        CType(Me.bookDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bookDetailTabcontrol.ResumeLayout(False)
        Me.bookDetailTab.ResumeLayout(False)
        Me.bookDetailTab.PerformLayout()
        Me.searchGroupbox.ResumeLayout(False)
        Me.searchGroupbox.PerformLayout()
        CType(Me.bookPicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.authorDetailTab.ResumeLayout(False)
        Me.authorDetailTab.PerformLayout()
        CType(Me.authorPicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.publisherDetailTab.ResumeLayout(False)
        Me.publisherDetailTab.PerformLayout()
        CType(Me.publisherPicturebox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryAdminDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryAdminDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bookStrip.ResumeLayout(False)
        Me.bookStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents footerStatus As StatusStrip
    Friend WithEvents mainSplitcontainer As SplitContainer
    Friend WithEvents footerProgressbar As ToolStripProgressBar
    Friend WithEvents footerStatuslabel As ToolStripStatusLabel
    Friend WithEvents bookDatagrid As DataGridView
    Friend WithEvents bookDetailTabcontrol As TabControl
    Friend WithEvents bookDetailTab As TabPage
    Friend WithEvents authorDetailTab As TabPage
    Friend WithEvents publisherDetailTab As TabPage
    Friend WithEvents bookStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibraryAdminDataSetBindingSource As BindingSource
    Friend WithEvents LibraryAdminDataSet As LibraryAdminDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As LibraryAdminDataSetTableAdapters.bookTableAdapter
    Friend WithEvents bookTextbox As TextBox
    Friend WithEvents bookPicturebox As PictureBox
    Friend WithEvents authorTextbox As TextBox
    Friend WithEvents authorPicturebox As PictureBox
    Friend WithEvents bookPositionTextbox As TextBox
    Friend WithEvents bookPublisherTextbox As TextBox
    Friend WithEvents bookAuthorTextbox As TextBox
    Friend WithEvents bookPagecountTextbox As TextBox
    Friend WithEvents bookIsbnTextbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents searchGroupbox As GroupBox
    Friend WithEvents bookSearchCombobox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents shopLink As LinkLabel
    Friend WithEvents bookSearchButton As Button
    Friend WithEvents authorDobTextbox As TextBox
    Friend WithEvents authorNationalityTextbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents publisherAddressTextbox As TextBox
    Friend WithEvents publisherYearTextbox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents publisherTextbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents publisherPicturebox As PictureBox
    Friend WithEvents searchPublisehrLink As LinkLabel
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents authorPictureNextButton As Button
    Friend WithEvents authorPicturePreviousButton As Button
    Friend WithEvents authorImagelist As ImageList
    Friend WithEvents TermsOfServiceToolStripMenuItem As ToolStripMenuItem
End Class
