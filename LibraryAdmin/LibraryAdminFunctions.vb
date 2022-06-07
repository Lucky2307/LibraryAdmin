Imports System.Configuration
Public Class LibraryAdminFunctions
    Shared Sub gridFiller(_grid)
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim memberDataSet As New DataTable
        Dim memberSource As New BindingSource
        Try
            odbcConn.Open()
            Dim query As String = "SELECT * from getmemberforgrid()"
            odbcDa.SelectCommand = New Odbc.OdbcCommand(query, odbcConn)
            odbcDa.Fill(memberDataSet)
            memberSource.DataSource = memberDataSet
            _grid.DataSource = memberSource
            odbcDa.Update(memberDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        _grid.Columns(0).Width = 30
    End Sub

    Shared Sub lendGridFiller(_grid)
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim memberDataSet As New DataTable
        Dim memberSource As New BindingSource
        Try
            odbcConn.Open()
            Dim query As String = "SELECT * from getmemberborrowforgrid()"
            odbcDa.SelectCommand = New Odbc.OdbcCommand(query, odbcConn)
            odbcDa.Fill(memberDataSet)
            memberSource.DataSource = memberDataSet
            _grid.DataSource = memberSource
            odbcDa.Update(memberDataSet)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        _grid.Columns(0).Width = 30
    End Sub

    Shared Function dbCaller(_grid) As DataRow() ' Return the data row selected row
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim memberDataset As New DataTable
        Dim memberDatasource As New BindingSource
        odbcConn.Open()
        Dim query As String = "SELECT * FROM ""member"""
        '1. member_id | 2. name | 3. address | 4. dob | 5. signupdate | 6. gender
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        odbcDa.SelectCommand = command
        odbcDa.Fill(memberDataset)
        memberDatasource.DataSource = memberDataset
        odbcDa.Update(memberDataset)
        'ODBC database connection n stuff
        Dim selectedRow = _grid.SelectedRows(0)
        Dim selectedId = selectedRow.Cells(0)
        Dim sel = memberDataset.Select("member_id = " & selectedId.Value)
        Return sel
    End Function
    'Table column value id

    Shared Sub dbDeleteMember(_id As String)
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim memberDataset As New DataTable
        Dim memberDatasource As New BindingSource
        odbcConn.Open()
        Dim query As String = "CALL deletemember(?)"
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        command.CommandType = CommandType.StoredProcedure
        Try
            command.Parameters.Add("id", Odbc.OdbcType.Int).Value = _id
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        odbcDa.SelectCommand = command
        odbcDa.Fill(memberDataset)
        memberDatasource.DataSource = memberDataset
        odbcDa.Update(memberDataset)
    End Sub

    Shared Sub dbAddMember(_name, _address, _dob, _gender, _phone_number)
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        Dim odbcDa As New Odbc.OdbcDataAdapter
        Dim memberDataset As New DataTable
        Dim memberDatasource As New BindingSource
        odbcConn.Open()
        Dim query As String = "CALL addmember(?, ?, ?, ?, ?)"
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        command.CommandType = CommandType.StoredProcedure
        Try
            command.Parameters.Add("name", Odbc.OdbcType.VarChar).Value = _name
            command.Parameters.Add("address", Odbc.OdbcType.VarChar).Value = _address
            command.Parameters.Add("dob", Odbc.OdbcType.Date).Value = _dob
            command.Parameters.Add("gender", Odbc.OdbcType.Char).Value = _gender
            command.Parameters.Add("phone_number", Odbc.OdbcType.Char).Value = _phone_number
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        gridFiller(FormMember.memberDatagrid)
        FormMember.viewUC.fill(LibraryAdminFunctions.dbCaller(FormMember.memberDatagrid)(0))
    End Sub

    Shared Sub dbUpdateMember(_id As String, _name As String, _address As String, _dob As Date, _gender As Char, _phone_number As String)
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        odbcConn.Open()
        Dim query As String = "CALL updatemember(?, ?, ?, ?, ?, ?)"
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        command.CommandType = CommandType.StoredProcedure
        Try
            command.Parameters.Add("name", Odbc.OdbcType.VarChar).Value = _name
            command.Parameters.Add("address", Odbc.OdbcType.VarChar).Value = _address
            command.Parameters.Add("dob", Odbc.OdbcType.Date).Value = _dob
            command.Parameters.Add("gender", Odbc.OdbcType.Char).Value = _gender
            command.Parameters.Add("id", Odbc.OdbcType.Int).Value = _id
            command.Parameters.Add("phone_number", Odbc.OdbcType.VarChar).Value = _phone_number
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        gridFiller(FormMember.memberDatagrid)
        FormMember.viewUC.fill(LibraryAdminFunctions.dbCaller(FormMember.memberDatagrid)(0))
    End Sub

    Shared Sub dbAddLendedBook(_id As String, _isbn As String, _interval As String)
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        odbcConn.Open()
        Dim query As String = "CALL addlendedbook(?, ?, ?)"
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        command.CommandType = CommandType.StoredProcedure
        Try
            command.Parameters.Add("id", Odbc.OdbcType.Int).Value = _id
            command.Parameters.Add("address", Odbc.OdbcType.VarChar).Value = _isbn
            command.Parameters.Add("address", Odbc.OdbcType.Int).Value = _interval
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        gridFiller(FormMember.memberDatagrid)
    End Sub

    Shared Sub dbReturnLendedBook(_id As String, _isbn As String)
        Dim odbcConn As New Odbc.OdbcConnection
        odbcConn.ConnectionString = ConfigurationManager.ConnectionStrings("LibraryAdminCS").ConnectionString
        odbcConn.Open()
        Dim query As String = "CALL returnlendedbook(?, ?)"
        Dim command As New Odbc.OdbcCommand(query, odbcConn)
        command.CommandType = CommandType.StoredProcedure
        Try
            command.Parameters.Add("id", Odbc.OdbcType.Int).Value = _id
            command.Parameters.Add("address", Odbc.OdbcType.VarChar).Value = _isbn
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        gridFiller(FormMember.memberDatagrid)
    End Sub
End Class
