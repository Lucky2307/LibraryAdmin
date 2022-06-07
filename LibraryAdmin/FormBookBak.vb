Public Class FormBook
    Dim imgParentDir As String = "C:\Users\alana\source\images\LibraryAdmin\"
    Dim imgAuthorPicture As String
    Dim imgAuthorPictureIndex As Int16 = 1
    Public Sub FormBook_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = "Driver={PostgreSQL ANSI};database=LibraryAdmin;server=127.0.0.1;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;User ID=postgres;password=DPCdemo2307"
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim bookDataSet As New DataTable
        Dim bookSource As New BindingSource
        Try
            odbcConn.Open()
            Dim query As String
            query = "SELECT book_isbn as ""ISBN"", title as ""Title"", ""name"" as ""Author"" FROM book, author WHERE book.author_id = author.author_id"
            Dim command As New Odbc.OdbcCommand(query, odbcConn)
            odbcDa.SelectCommand = command
            odbcDa.Fill(bookDataSet)
            bookSource.DataSource = bookDataSet
            bookDatagrid.DataSource = bookSource
            odbcDa.Update(bookDataSet)
        Catch ex As Exception
            MsgBox(ex)
        End Try
        bookDatagrid.Columns(1).Width = 180
    End Sub

    Function dbCaller() As DataRow() ' Return the data row selected row
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = "Driver={PostgreSQL ANSI};database=LibraryAdmin;server=127.0.0.1;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;User ID=postgres;password=DPCdemo2307"
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim authorDataset As New DataTable
        Dim authorDatasource As New BindingSource
        odbcConn.Open()
        footerStatuslabel.Text = "Connecting to database"
        Dim query As String = "SELECT * FROM book NATURAL JOIN author JOIN publisher ON book.publisher_id = publisher.publisher_id"
        '1. author_id | 2. book_isbn | 3. title | 4. page_count | 5. publisher_id | 6. position | 7. name(author) | 8. nationality | 9. dob | 10. publisher_id | 11. name (publisher) | 12. address | 13. founded_in
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        odbcDa.SelectCommand = command
        odbcDa.Fill(authorDataset)
        footerStatuslabel.Text = "Filling database"
        authorDatasource.DataSource = authorDataset
        odbcDa.Update(authorDataset)
        'ODBC database connection n stuff

        Dim selectedRow = bookDatagrid.SelectedRows(0)
        Dim selectedISBN = selectedRow.Cells(0)
        bookPicturebox.Image = Image.FromFile(imgParentDir & selectedISBN.Value & ".jpg")
        bookTextbox.Text = selectedRow.Cells(1).Value
        Dim sel = authorDataset.Select("book_isbn = " & selectedISBN.Value)
        Return sel
    End Function

    Private Sub GridClickButtonHandler(sender As Object, e As DataGridViewCellMouseEventArgs) Handles bookDatagrid.CellMouseClick
        Dim sel = dbCaller()

        'Clearing and adding new images based on the selected row
        authorImagelist.Images.Clear()
        GC.Collect() 'Clears up memory

        Dim count As Int16 = 1
        While System.IO.File.Exists(imgParentDir & "Author\" & sel(0)(0) & "\" & count & ".jpg")
            authorImagelist.Images.Add(Image.FromFile(imgParentDir & "Author\" & sel(0)(0) & "\" & count & ".jpg"))
            authorImagelist.Images.SetKeyName(count - 1, count.ToString)
            count += 1
        End While

        'Sel is as a pointer to selected isbn row, use sel(0)(columnIndex) to get value
        'BOOK TAB
        footerStatuslabel.Text = "Filling book tab"
        bookIsbnTextbox.Text = sel(0)(1).ToString
        bookPagecountTextbox.Text = sel(0)(3)
        bookAuthorTextbox.Text = sel(0)(6)
        bookPublisherTextbox.Text = sel(0)(10)
        bookPositionTextbox.Text = sel(0)(5)

        'AUTHOR TAB
        footerStatuslabel.Text = "Filling author tab"
        authorPicturebox.Image = authorImagelist.Images("1")
        authorTextbox.Text = sel(0)(6)
        authorNationalityTextbox.Text = sel(0)(7)
        authorDobTextbox.Text = sel(0)(8)

        'PUBLISHER TAB
        publisherPicturebox.Image = Image.FromFile(imgParentDir & "Publisher\" & sel(0)(0) & ".jpg")
        publisherTextbox.Text = sel(0)(10)
        publisherYearTextbox.Text = sel(0)(12)
        publisherAddressTextbox.Text = sel(0)(11)
        footerStatuslabel.Text = "Idle"
    End Sub

    Private Sub bookSearchButton_Click(sender As Object, e As EventArgs) Handles bookSearchButton.Click
        If bookSearchCombobox.Text Is "" Then
            MsgBox("Please input something in the search box")
        ElseIf bookSearchCombobox.Text = "Google" Then
            Process.Start("https://www.google.co.id/search?q=" & bookTextbox.Text & " Book")
        ElseIf bookSearchCombobox.Text = "Openlibrary" Then
            Process.Start("https://www.openlibrary.org/isbn/" & bookIsbnTextbox.Text)
        ElseIf bookSearchCombobox.Text = "Amazon" Then
            Process.Start("https://www.amazon.com/s?k=" & bookIsbnTextbox.Text)
        Else
            Process.Start("https://www.google.co.id/search?q=" & bookTextbox.Text & " " & bookSearchCombobox.Text)
        End If
    End Sub

    Private Sub shopLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles shopLink.LinkClicked
        Process.Start("https://www.google.co.id/search?q=" & bookTextbox.Text & "&source=lmns&tbm=shop")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.google.co.id/search?q=" & publisherTextbox.Text & " HQ")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("LibraryAdmin, a basic library management software created by:" & vbCrLf & vbCrLf & "Fauzan Lucky Alana Iskandar " & vbCrLf & "(001201900048)")
    End Sub

    Private Sub authorPictureNextButton_Click(sender As Object, e As EventArgs) Handles authorPictureNextButton.Click
        If imgAuthorPictureIndex < authorImagelist.Images.Count Then
            imgAuthorPictureIndex += 1
        Else
            imgAuthorPictureIndex = 1
        End If
        authorPicturebox.Image = authorImagelist.Images(imgAuthorPictureIndex.ToString)
    End Sub
End Class