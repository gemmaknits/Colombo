Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classGridLayoutSettings 'John 27/10/2025

    Public Function selectGridLayoutSettings(pUserId As String, pGridName As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[dbo].[p_grid_layout_settings_select]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_user_id", pUserId)
        comm.Parameters.AddWithValue("@p_grid_name", pGridName)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function


    Public Function saveGridLayoutSettings(dtGridLayoutSettings As DataTable, ByRef pGridName As String, ByRef msgerr As String, ByVal logempcd As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        Dim dvGridLayoutSettings As New DataView(dtGridLayoutSettings)
        comm.CommandText = "[dbo].[p_grid_layout_settings_update]"
        For Each drvUpd As DataRowView In dvGridLayoutSettings
            With drvUpd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@p_user_grid_setting_id", .Item("user_grid_setting_id"))
                comm.Parameters.AddWithValue("@p_module_id", "SOS")
                comm.Parameters.AddWithValue("@p_user_id", logempcd)
                comm.Parameters.AddWithValue("@p_grid_name", pGridName)
                comm.Parameters.AddWithValue("@p_col_data_property", .Item("col_data_property"))
                comm.Parameters.AddWithValue("@p_col_name", .Item("column_name"))
                comm.Parameters.AddWithValue("@p_col_width", .Item("col_width"))

                Dim isVisible As Boolean = False
                If Not IsDBNull(.Item("col_visible")) Then
                    Dim val As String = .Item("col_visible").ToString().Trim().ToUpper()
                    isVisible = (val = "Y" OrElse val = "1" OrElse val = "TRUE")
                End If
                comm.Parameters.AddWithValue("@p_col_visible", If(isVisible, "Y", "N"))

                comm.Parameters.AddWithValue("@p_form_name", "Sale Order Form")
                comm.Parameters.AddWithValue("@p_log_empcd", logempcd)
            End With
            Dim sql As String = config.BuildSQL(comm)
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        Next

        tran.Commit()
        conn.Close()
        Return True
    End Function
End Class
