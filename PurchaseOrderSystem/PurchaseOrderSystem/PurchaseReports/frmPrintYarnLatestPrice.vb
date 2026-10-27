Public Class frmPrintYarnLatestPrice
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.cboSupplier.DataSource = objDB.GetSupplier
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.ValueMember = "suppcd"
        Me.cboSupplier.SelectedIndex = -1
    End Sub

    Private Sub GenGrid()
        Dim conn As New SqlClient.SqlConnection((New classConnection).connection)
        Dim comm As New SqlClient.SqlCommand("select cast('' as varchar(20)) as itcd", conn)
        Dim da As New SqlClient.SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        grdDesignNo.DataSource = dt
    End Sub

    Private Function GetITCD(ByVal dt As DataTable) As String
        Dim strITCD As String = ""
        Dim i As Integer = 0
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i)("itcd").ToString.Trim.Length > 0 Then strITCD = strITCD & dt.Rows(i)("itcd").ToString.Trim & ","
            Next
        End If
        Return strITCD
    End Function

    Private Sub PrintYarnLatestPrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpDateTo.Value = Now
        Call GenCombo()
        Call GenGrid()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call grdDesignNo.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Dim strITCD As String = ""
        Dim rptFileName As String = "rptYarnLatestPrice.rpt"

        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        strITCD = GetITCD(grdDesignNo.DataSource)

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@suppcd", clsConfig.IsNull(cboSupplier.SelectedValue, ""))
        rpt.SetParameterValue("@itcd_list", strITCD)

        frm.Title = "Yarn Latest Price"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class