Imports System.Data.SqlClient
Public Class CDB
    Public Function OpenDB() As Boolean
        objSQLCommand = New SqlCommand
        Dim blnResult As Boolean
        If objSQKConn Is Nothing Then
            Try
                objSQKConn = New SqlConnection(gstrConn)
                objSQKConn.Open()
                blnResult = True

            Catch exOpenConnError As Exception
                MessageBox.Show("Cannot open database; " & exOpenConnError.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnResult = False

            End Try
        Else
            If objSQKConn.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If

        End If
        Return blnResult

    End Function
    Public Sub CloseDB()
        Try
            objSQKConn.Close()

        Catch ex As Exception
            MessageBox.Show("Error attempting to close database: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetDataReaderBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataReader
        If Not OpenDB() Then
            Return Nothing

        End If
        objSQLCommand = New SqlCommand(strSP, objSQKConn)
        objSQLCommand.CommandType = CommandType.StoredProcedure
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                objSQLCommand.Parameters.Add(p)
            Next
        End If
        Try
            Return objSQLCommand.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Failed to get datareader: " & ex.ToString, "Databse Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return Nothing

    End Function

    Public Function GetDataAdapterBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataAdapter
        objSQLCommand = New SqlCommand(strSP, objSQKConn)
        Dim sqlDA As SqlDataAdapter
        objSQLCommand.CommandType = CommandType.StoredProcedure
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                objSQLCommand.Parameters.Add(p)
            Next
        End If
        Try
            sqlDA = New SqlDataAdapter(objSQLCommand)
            Return sqlDA
        Catch ex As Exception
            MessageBox.Show("Failed to get data adapter: " & ex.ToString, "Databse Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return Nothing
    End Function

    Public Function ExecSP(ByVal strSP As String, ByRef params As ArrayList) As Integer
        If Not OpenDB() Then
            Return -1
        End If
        objSQLCommand = New SqlCommand(strSP, objSQKConn)
        Try
            If Not params Is Nothing Then
                For Each p As SqlParameter In params
                    objSQLCommand.Parameters.Add(p)
                Next
            End If
            Return objSQLCommand.ExecuteNonQuery

        Catch ex As Exception
            MessageBox.Show("Error executing SP: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
    Public Function GetSingleValueFromSP(ByVal strSP As String, ByRef params As ArrayList) As String
        Dim sqlDR As SqlDataReader = GetDataReaderBySP(strSP, params)
        Dim strResult As String
        If Not sqlDR Is Nothing Then
            If sqlDR.Read Then
                strResult = sqlDR.GetValue(0).ToString
                sqlDR.Close()
                Return strResult
            Else
                Return "-1"
            End If

        End If
        Return "-2"
    End Function
End Class
