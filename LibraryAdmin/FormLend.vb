Imports System.Configuration
Public Class FormLend
    Private Sub memberDatagrid_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles memberDatagrid.CellMouseUp
        GC.Collect()
        fillList(bookListview, memberDatagrid)
        resizeColumn()
    End Sub
    Shared Function fillList(bookListview, memberDatagrid)
        bookListview.Clear()
        Dim sel = LibraryAdminFunctions.dbCaller(memberDatagrid)(0)
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim memberDataSet As New DataTable
        Dim memberSource As New BindingSource
        odbcConn.Open()
        Dim query As String = "SELECT * FROM getborrowedbook(?)"
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        Try
            command.Parameters.Add("id", Odbc.OdbcType.Int).Value = sel(0)
            command.ExecuteNonQuery()
            odbcDa.SelectCommand = command
            odbcDa.Fill(memberDataSet)
            memberSource.DataSource = memberDataSet
            odbcDa.Update(memberDataSet)
            For i As Integer = 0 To memberDataSet.Columns.Count - 1
                bookListview.Columns.Add(memberDataSet.Columns(i).ColumnName.ToString)
            Next
            Dim collection(100) As String
            For i As Integer = 0 To memberDataSet.Rows.Count - 1
                For j As Integer = 0 To memberDataSet.Columns.Count - 1
                    collection(j) = memberDataSet.Rows(i)(j).ToString
                Next
                bookListview.Items.Add(New ListViewItem(collection))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        odbcConn.Close()
    End Function
    Private Sub FormLend_Load(sender As Object, e As EventArgs) Handles Me.Load
        bookListview.View = View.Details
        LibraryAdminFunctions.lendGridFiller(memberDatagrid)
        Me.CenterToScreen()
        Dim dummy As Object
        Dim dummye As DataGridViewCellMouseEventArgs
        memberDatagrid_CellMouseUp(dummy, dummye)
    End Sub

    Private Sub bookListview_Resize(sender As Object, e As EventArgs) Handles bookListview.Resize
        resizeColumn()
    End Sub

    Function resizeColumn()
        For i As Integer = 0 To bookListview.Columns.Count - 1
            bookListview.Columns(i).Width = bookListview.Width / 4
        Next
    End Function

    Private Sub addLendButton_Click(sender As Object, e As EventArgs) Handles addLendButton.Click
        formLendAdd.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles returnButton.Click
        formLendReturn.Show()
    End Sub
End Class