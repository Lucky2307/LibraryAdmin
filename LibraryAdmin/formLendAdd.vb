Imports System.Configuration
Public Class formLendAdd
    Dim toLendISBNArray(10) As String
    Private Sub formLendAdd_Load(sender As Object, e As EventArgs) Handles Me.Load
        LibraryAdminFunctions.gridFiller(memberDatagrid)
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
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
            odbcConn.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Function dbCallerMember() As DataRow() ' Return the data row selected row
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim memberDataset As New DataTable
        Dim memberDatasource As New BindingSource
        odbcConn.Open()
        Dim query As String = "SELECT * FROM getmemberborrowforgrid()"
        '1. member_id | 2. name | 3. address | 4. dob | 5. signupdate | 6. gender
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        odbcDa.SelectCommand = command
        odbcDa.Fill(memberDataset)
        memberDatasource.DataSource = memberDataset
        odbcDa.Update(memberDataset)
        'ODBC database connection n stuff
        Dim selectedRow = memberDatagrid.SelectedRows(0)
        Dim selectedId = selectedRow.Cells(0)
        Dim sel = memberDataset.Select("ID = " & selectedId.Value)
        odbcConn.Close()
        Return sel
    End Function
    Function dbCaller() As DataRow() ' Return the data row selected row
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim authorDataset As New DataTable
        Dim authorDatasource As New BindingSource
        odbcConn.Open()
        Dim query As String = "SELECT * FROM book NATURAL JOIN author JOIN publisher ON book.publisher_id = publisher.publisher_id"
        '1. author_id | 2. book_isbn | 3. title | 4. page_count | 5. publisher_id | 6. position | 7. name(author) | 8. nationality | 9. dob | 10. publisher_id | 11. name (publisher) | 12. address | 13. founded_in
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        odbcDa.SelectCommand = command
        odbcDa.Fill(authorDataset)
        authorDatasource.DataSource = authorDataset
        odbcDa.Update(authorDataset)
        'ODBC database connection n stuff

        Dim selectedRow = bookDatagrid.SelectedRows(0)
        Dim selectedISBN = selectedRow.Cells(0)
        Dim sel = authorDataset.Select("book_isbn = " & selectedISBN.Value)
        odbcConn.Close()
        Return sel
    End Function

    Private Sub selectedBookListbox_MouseUp(sender As Object, e As MouseEventArgs) Handles selectedBookListbox.MouseUp

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim sel = dbCaller(0)
        If Not selectedBookListbox.Items.Contains(sel(2)) Then
            selectedBookListbox.Items.Add(sel(2))
            toLendISBNArray(selectedBookListbox.Items.Count - 1) = sel(1).ToString
        Else
            MsgBox("Book already in list")
        End If
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        Dim sel = LibraryAdminFunctions.dbCaller(memberDatagrid)(0)

        If selectedBookListbox.Items.Count = 0 Then
            MsgBox("No selected book")
        Else
            Dim index As Integer = 0
            For i As Integer = 0 To selectedBookListbox.Items.Count - 1
                While toLendISBNArray(index) Is Nothing
                    index += 1
                End While
                LibraryAdminFunctions.dbAddLendedBook(sel(0), toLendISBNArray(index).ToString, intervalNumupdown.Value)
                index += 1
            Next

        End If
        LibraryAdminFunctions.lendGridFiller(FormLend.memberDatagrid)
        Me.Close()

    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub removeButton_Click(sender As Object, e As EventArgs) Handles removeButton.Click
        If selectedBookListbox.SelectedIndex < 0 Then
            MsgBox("Please select a book from the list to remove")
            Exit Sub
        End If
        toLendISBNArray(selectedBookListbox.SelectedIndex) = Nothing
        selectedBookListbox.Items.RemoveAt(selectedBookListbox.SelectedIndex)
    End Sub

    Private Sub memberSearchButton_Click(sender As Object, e As EventArgs) Handles memberSearchButton.Click
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim memberDataset As New DataTable
        Dim memberDatasource As New BindingSource
        odbcConn.Open()
        Dim query As String = "SELECT * FROM getmemberforgrid() WHERE ""Name"" ILIKE '%" & memberNameSearchTextbox.Text & "%'"
        '1. member_id | 2. name | 3. address | 4. dob | 5. signupdate | 6. gender
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        odbcDa.SelectCommand = command
        odbcDa.Fill(memberDataset)
        memberDatasource.DataSource = memberDataset
        memberDatagrid.DataSource = memberDatasource
        odbcDa.Update(memberDataset)
        odbcConn.Close()
    End Sub

    Private Sub bookSearchButton_Click(sender As Object, e As EventArgs) Handles bookSearchButton.Click
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim bookDataSet As New DataTable
        Dim bookSource As New BindingSource
        Try
            odbcConn.Open()
            Dim query As String
            query = "SELECT book_isbn as ""ISBN"", title as ""Title"", ""name"" as ""Author"" FROM book, author WHERE book.author_id = author.author_id AND ""title"" ILIKE '%" & bookTitleSearchTextbox.Text & "%'"
            Dim command As New Odbc.OdbcCommand(query, odbcConn)
            odbcDa.SelectCommand = command
            odbcDa.Fill(bookDataSet)
            bookSource.DataSource = bookDataSet
            bookDatagrid.DataSource = bookSource
            odbcDa.Update(bookDataSet)
            odbcConn.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
End Class