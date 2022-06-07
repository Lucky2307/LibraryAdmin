Imports System.Configuration
Public Class formLendReturn
    Private Sub formLendReturn_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sel = LibraryAdminFunctions.dbCaller(FormLend.memberDatagrid)(0)
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
            bookCheckedlist.DataSource = memberSource
            bookCheckedlist.ValueMember = "title"
            odbcConn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub selectAllButton_Click(sender As Object, e As EventArgs) Handles selectAllButton.Click
        For i As Integer = 0 To bookCheckedlist.Items.Count - 1
            bookCheckedlist.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub deselectAllButton_Click(sender As Object, e As EventArgs) Handles deselectAllButton.Click
        For i As Integer = 0 To bookCheckedlist.Items.Count - 1
            bookCheckedlist.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        For i = 0 To bookCheckedlist.Items.Count - 1

            If bookCheckedlist.GetItemChecked(i) Then
                Dim Item As DataRowView = bookCheckedlist.Items(i)
                Dim sel = LibraryAdminFunctions.dbCaller(FormLend.memberDatagrid)(0)
                LibraryAdminFunctions.dbReturnLendedBook(sel(0), Item.Row(0))
            End If
        Next
        Me.Close()
        FormLend.fillList(FormLend.bookListview, FormLend.memberDatagrid)
        LibraryAdminFunctions.lendGridFiller(FormLend.memberDatagrid)
    End Sub
End Class