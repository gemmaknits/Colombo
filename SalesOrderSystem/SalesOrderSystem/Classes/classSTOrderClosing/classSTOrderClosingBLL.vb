Imports System.Data.SqlClient

Public Class STOrderClosingSaveResult
    Public Property Success As Boolean
    Public Property Message As String
End Class

Public Class classSTOrderClosingBLL
    Public Function Load_STOrderClosing(ByVal designNo As String,
                                        ByVal customerName As String,
                                        ByVal stNo As String,
                                        ByVal closingStatus As String,
                                        ByVal salesPersonCode As String,
                                        ByVal sourceConnection As SqlConnection) As DataTable
        Return FillTable("[SO].[p_so_stclose_pkg_stlist_open_select]",
                         sourceConnection,
                         New SqlParameter("@p_design_no", DbValue(designNo)),
                         New SqlParameter("@p_customer_name", DbValue(customerName)),
                         New SqlParameter("@p_stno", DbValue(stNo)),
                         New SqlParameter("@p_sales_person_code", DbValue(salesPersonCode)),
                         New SqlParameter("@p_closing_status", closingStatus.Trim()))
    End Function

    Public Function Load_Knitting(ByVal soNo As String,
                                  ByVal sourceConnection As SqlConnection) As DataTable
        Return FillTable("[SO].[p_so_stclose_pkg_ko_for_st_select]",
                         sourceConnection,
                         New SqlParameter("@p_sono", DbValue(soNo)))
    End Function

    Public Function Load_GREIGE_OH(ByVal soNo As String,
                                   ByVal sourceConnection As SqlConnection) As DataTable
        Return FillTable("[SO].[p_so_stclose_pkg_st_onhand_select]",
                         sourceConnection,
                         New SqlParameter("@p_sono", DbValue(soNo)))
    End Function

    Public Function Load_SOApplied(ByVal soLineId As String,
                                   ByVal sourceConnection As SqlConnection) As DataTable
        Return FillTable("[SO].[p_so_stclose_pkg_reserve_to_st]",
                         sourceConnection,
                         New SqlParameter("@p_so_line_id", DbValue(soLineId)))
    End Function

    Public Function saveDBX(ByVal changedRows As DataTable,
                            ByVal sourceConnection As SqlConnection) As STOrderClosingSaveResult
        Dim result As New STOrderClosingSaveResult()

        Try
            ValidateConnection(sourceConnection)
            Using connection As New SqlConnection(sourceConnection.ConnectionString)
                connection.Open()
                Using transaction As SqlTransaction = connection.BeginTransaction()
                    Try
                        For Each row As DataRow In changedRows.Rows
                            Using command As New SqlCommand("[SO].[p_so_stclose_pkg_close_st_order]", connection, transaction)
                                command.CommandType = CommandType.StoredProcedure
                                command.CommandTimeout = 300

                                Dim soLineId As Object = -1
                                If Not row.IsNull("so_line_id") AndAlso
                                   row("so_line_id").ToString().Trim() <> "" AndAlso
                                   row("so_line_id").ToString().Trim() <> "-1" Then
                                    soLineId = row("so_line_id")
                                End If

                                command.Parameters.AddWithValue("@p_so_line_id", soLineId)
                                command.Parameters.AddWithValue("@p_closed", row("closed"))
                                command.ExecuteNonQuery()
                            End Using
                        Next

                        transaction.Commit()
                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            result.Success = True
            result.Message = ""
        Catch ex As Exception
            result.Success = False
            result.Message = ex.Message
        End Try

        Return result
    End Function

    Private Function FillTable(ByVal procedureName As String,
                               ByVal sourceConnection As SqlConnection,
                               ParamArray parameters() As SqlParameter) As DataTable
        ValidateConnection(sourceConnection)
        Dim table As New DataTable()

        Using connection As New SqlConnection(sourceConnection.ConnectionString)
            Using command As New SqlCommand(procedureName, connection)
                command.CommandType = CommandType.StoredProcedure
                command.CommandTimeout = 300
                command.Parameters.AddRange(parameters)

                Using adapter As New SqlDataAdapter(command)
                    adapter.Fill(table)
                End Using
            End Using
        End Using

        Return table
    End Function

    Private Shared Function DbValue(ByVal value As String) As Object
        If String.IsNullOrWhiteSpace(value) Then Return DBNull.Value
        Return value.Trim()
    End Function

    Private Shared Sub ValidateConnection(ByVal connection As SqlConnection)
        If connection Is Nothing OrElse String.IsNullOrWhiteSpace(connection.ConnectionString) Then
            Throw New InvalidOperationException("Database connection is not configured.")
        End If
    End Sub
End Class
