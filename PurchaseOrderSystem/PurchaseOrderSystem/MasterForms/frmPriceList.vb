Imports System.Data.SqlClient

Public Class frmPriceList
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim blnCancel As Boolean
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Function SaveData(ByVal dt As DataTable, ByVal logempcd As String, ByVal isSaveAll As Boolean) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_designs_price_update"
        ProgressBar1.Value = 0
        Dim i As Integer = 0

        conn.Open()
        Me.Cursor = Cursors.WaitCursor

        If isSaveAll Then
            ProgressBar1.Maximum = dt.Rows.Count
            For Each dr As DataRow In dt.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id", Val(dr("id")))
                comm.Parameters.AddWithValue("@period", dr("period").ToString.Trim)
                comm.Parameters.AddWithValue("@design_no", dr("design_no").ToString.Trim)
                comm.Parameters.AddWithValue("@minimum_order", Val(dr("minimum_order")))
                comm.Parameters.AddWithValue("@cpu", Val(dr("cpu")))
                comm.Parameters.AddWithValue("@minimum_ppu", Val(dr("minimum_ppu")))
                comm.Parameters.AddWithValue("@maximum_ppu", Val(dr("maximum_ppu")))
                comm.Parameters.AddWithValue("@discount1_kg", Val(dr("discount1_kg")))
                comm.Parameters.AddWithValue("@discount1_percent", Val(dr("discount1_percent")))
                comm.Parameters.AddWithValue("@discount2_kg", Val(dr("discount2_kg")))
                comm.Parameters.AddWithValue("@discount2_percent", Val(dr("discount2_percent")))
                comm.Parameters.AddWithValue("@discount3_kg", Val(dr("discount3_kg")))
                comm.Parameters.AddWithValue("@discount3_percent", Val(dr("discount3_percent")))
                comm.Parameters.AddWithValue("@strategy", dr("strategy").ToString.Trim)
                comm.Parameters.AddWithValue("@create_by", dr("create_by").ToString.Trim)
                comm.Parameters.AddWithValue("@create_date", dr("create_date").ToString.Trim)
                comm.Parameters.AddWithValue("@create_time", dr("create_time").ToString.Trim)
                comm.Parameters.AddWithValue("@logempcd", logempcd)
                comm.ExecuteNonQuery()
                i += 1
                'ProgressBar1.Value = i
                ProgressBar1.Increment(1)
                UpdateLabel()
            Next
        Else
            Dim dv As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
            ProgressBar1.Maximum = dv.Count
            If dv.Count > 0 Then
                For i = 0 To dv.Count - 1
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@id", Val(dv(i)("id")))
                    comm.Parameters.AddWithValue("@period", dv(i)("period").ToString.Trim)
                    comm.Parameters.AddWithValue("@design_no", dv(i)("design_no").ToString.Trim)
                    comm.Parameters.AddWithValue("@minimum_order", Val(dv(i)("minimum_order")))
                    comm.Parameters.AddWithValue("@cpu", Val(dv(i)("cpu")))
                    comm.Parameters.AddWithValue("@minimum_ppu", Val(dv(i)("minimum_ppu")))
                    comm.Parameters.AddWithValue("@maximum_ppu", Val(dv(i)("maximum_ppu")))
                    comm.Parameters.AddWithValue("@discount1_kg", Val(dv(i)("discount1_kg")))
                    comm.Parameters.AddWithValue("@discount1_percent", Val(dv(i)("discount1_percent")))
                    comm.Parameters.AddWithValue("@discount2_kg", Val(dv(i)("discount2_kg")))
                    comm.Parameters.AddWithValue("@discount2_percent", Val(dv(i)("discount2_percent")))
                    comm.Parameters.AddWithValue("@discount3_kg", Val(dv(i)("discount3_kg")))
                    comm.Parameters.AddWithValue("@discount3_percent", Val(dv(i)("discount3_percent")))
                    comm.Parameters.AddWithValue("@strategy", dv(i)("strategy").ToString.Trim)
                    comm.Parameters.AddWithValue("@create_by", dv(i)("create_by").ToString.Trim)
                    comm.Parameters.AddWithValue("@create_date", dv(i)("create_date").ToString.Trim)
                    comm.Parameters.AddWithValue("@create_time", dv(i)("create_time").ToString.Trim)
                    comm.Parameters.AddWithValue("@logempcd", logempcd)
                    comm.ExecuteNonQuery()
                    'ProgressBar1.Value = i + 1
                    ProgressBar1.Increment(1)
                    UpdateLabel()
                Next
            End If
        End If

        conn.Close()
        Me.Cursor = Cursors.Default

        Return True
    End Function

    Private Sub UpdateLabel()
        Dim myString As String = (ProgressBar1.Value * 100) / ProgressBar1.Maximum
        myString &= " %"
        Dim canvas As Graphics = Me.ProgressBar1.CreateGraphics
        canvas.DrawString(myString, New Font("Verdana", 8, FontStyle.Bold), New SolidBrush(Color.Black), 290, 4)
        canvas.Dispose()
    End Sub

    Private Sub frmPriceList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpPeriod.Value = Now
    End Sub

    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        Dim obj As New classMaster()
        Dim dt As DataTable = obj.CopyDesignPrice(dtpPeriod.Value.AddMonths(-1).ToString("yyyyMM"), dtpPeriod.Value.ToString("yyyyMM"), clsUser.UserID)
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Exit Sub
        Dim isSaveAll As Boolean = IIf(MessageBox.Show("Would you like to save only modified data ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes, False, True)

        If SaveData(grdData.DataSource, clsUser.UserID, isSaveAll) Then
            MessageBox.Show("Save Completed.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSearch_Click(sender, e)
        Else
            MessageBox.Show("Save Failed.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptPriceList.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@period", dtpPeriod.Value.ToString("yyyyMM"))
        rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))

        frm.Title = "Price List"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim obj As New classMaster()
        Dim dt As DataTable = obj.GetDesignPrice(dtpPeriod.Value.ToString("yyyyMM"), clsUser.UserID)
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub
End Class