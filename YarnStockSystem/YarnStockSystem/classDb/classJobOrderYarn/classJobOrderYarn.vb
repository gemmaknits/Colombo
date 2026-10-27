Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classJobOrderYarn
    Public Function GetJobDet(ByVal pJobNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_PKG_select_job_det"
        comm.Parameters.AddWithValue("@jobno", pJobNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()  'Sitthana 20190325
            Return dt
        End Try

        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetJobDetGroup(ByVal dtJobDetYarn As DataTable) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_PKG_get_job_det_group"
        comm.Parameters.AddWithValue("@t_job_det_yarn", dtJobDetYarn)
        ' comm.ExecuteNonQuery()

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()  'Sitthana 20190325
            Return dt
        End Try
        ' da.Fill(dt)
        ' conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetKoNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_PKG_select_kono"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetItcd() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_PKG_select_itcd"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ValidateItems(ByVal pKono As String, ByVal pItcd As String, ByVal logempcd As String) As Boolean
        Dim PitcdExsits As Boolean
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_PKG_validate_itcd"
        comm.Parameters.AddWithValue("@kono", pKono)
        comm.Parameters.AddWithValue("@itcd", pItcd)
        comm.Parameters.Add("@pitcd_exsits", SqlDbType.Bit)
        comm.Parameters("@pitcd_exsits").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        PitcdExsits = comm.Parameters("@pitcd_exsits").Value
        Return PitcdExsits
    End Function

    Public Function ItemsCount(ByVal pKono As String, ByVal pItcd As String, ByVal logempcd As String) As Integer
        Dim PitcdCount As Integer
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_PKG_select_itcd_count"
        comm.Parameters.AddWithValue("@kono", pKono)
        comm.Parameters.AddWithValue("@itcd", pItcd)
        comm.Parameters.Add("@pitcd_count", SqlDbType.Int)
        comm.Parameters("@pitcd_count").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        PitcdCount = comm.Parameters("@pitcd_count").Value
        Return PitcdCount
    End Function
    Public Function ValidateChangedKoNo(ByVal pJobNo As String, ByVal pKono As String, ByVal logempcd As String) As Boolean
        Dim pKoNoChanged As Boolean
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_PKG_validate_changed_kono"
        comm.Parameters.AddWithValue("@jobno", pJobNo)
        comm.Parameters.AddWithValue("@kono", pKono)
        comm.Parameters.Add("@pkono_changed", SqlDbType.Bit)
        comm.Parameters("@pkono_changed").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        pKoNoChanged = comm.Parameters("@pkono_changed").Value
        Return pKoNoChanged
    End Function

    Public Function GetYarnBalance(ByVal YarnIn As String, ByVal Itemcode As String, ByVal pKoNo As String,
                                ByVal pMfgProductionOrderLineId As Nullable(Of Int64), ByRef Msgerr As String) As DataTable
        If YarnIn = "" And Itemcode = "" Then MessageBox.Show("Yarn IN No. or Item Code is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        Dim conn As New SqlConnection((New classConnection).Connection())
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_PKG_select_yarn_balance"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@docno", YarnIn.Trim)
        comm.Parameters.AddWithValue("@itcd", Itemcode.Trim)
        comm.Parameters.AddWithValue("@kono", pKoNo.Trim)
        comm.Parameters.AddWithValue("@mfg_production_order_line_id", pMfgProductionOrderLineId)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet

        Try
            da.Fill(ds, "v_YarnBalByBox")
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Msgerr = ex.Message
        End Try

        Return ds.Tables("v_YarnBalByBox")
    End Function

    Public Function GetProductionOrderLineId(ByVal pKoNo As String, ByVal pItcd As String) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_PKG_get_mfg_production_order_line_id"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@kono", pKoNo)
        comm.Parameters.AddWithValue("@itcd", pItcd)
        comm.Parameters.Add("@pmfg_production_order_line_id", SqlDbType.BigInt)
        comm.Parameters("@pmfg_production_order_line_id").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        GetProductionOrderLineId = (New clsConfig).IsNull(comm.Parameters("@pmfg_production_order_line_id").Value, Nothing)
    End Function

    Public Function GetGBNo(ByVal pKoNo As String, ByVal pItcd As String) As String
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_PKG_get_gb"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@kono", pKoNo)
        comm.Parameters.AddWithValue("@itcd", pItcd)
        comm.Parameters.Add("@gb", SqlDbType.Char, 10)
        comm.Parameters("@gb").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        GetGBNo = (New clsConfig).IsNull(comm.Parameters("@gb").Value, String.Empty)
    End Function
End Class
