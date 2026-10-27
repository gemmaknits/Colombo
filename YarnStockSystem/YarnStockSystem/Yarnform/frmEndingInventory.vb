Imports System.Data.SqlClient

Public Class frmEndingInventory
    Private clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private dt As DataTable


    Private Sub GenNewTable()
        dt = New DataTable("p_yarn_balance")
        dt.Columns.Add("id", GetType(Integer))
        dt.Columns.Add("paramLoc", GetType(String))
        dt.Columns.Add("itcd", GetType(String))
        dt.Columns.Add("docno", GetType(String))
        dt.Columns.Add("docdt", GetType(String))
        dt.Columns.Add("boxno_s", GetType(String))
        dt.Columns.Add("boxno", GetType(String))
        dt.Columns.Add("spools", GetType(Integer))
        dt.Columns.Add("kg_nt", GetType(Single))
        dt.Columns.Add("lotno_our", GetType(String))
        dt.Columns.Add("spools_out", GetType(Integer))
        dt.Columns.Add("kg_nt_out", GetType(Single))
        dt.Columns.Add("supname", GetType(String))
        dt.Columns.Add("coname", GetType(String))
        dt.Columns.Add("itdesc2", GetType(String))
        dt.Columns.Add("balance_spools", GetType(Integer))
        dt.Columns.Add("balance", GetType(Single))
        dt.Columns.Add("loc", GetType(String))
        dt.Columns.Add("grade", GetType(String))
        dt.Columns.Add("box_remark", GetType(String))
    End Sub

    Private Function GetBoxDescription(ByVal boxno As String) As DataRow
        Dim conn As SqlConnection = New classConnection().getSQLConnection()
        Dim comm As SqlCommand = New SqlCommand("exec p_search_yarn_boxno '" & boxno & "'", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim dt2 As New DataTable
        Dim dr As DataRow = dt.NewRow()

        Try
            da.Fill(dt2)

            If dt2.Rows.Count > 0 Then
                dr("id") = dt.Rows.Count + 1
                dr("paramLoc") = "Ending Inventory"
                dr("itcd") = dt2.Rows(0)("itcd").ToString()
                dr("docno") = dt2.Rows(0)("docno").ToString()
                dr("docdt") = dt2.Rows(0)("docdt").ToString()
                dr("boxno_s") = dt2.Rows(0)("boxno_s").ToString()
                dr("boxno") = dt2.Rows(0)("boxno").ToString()
                dr("spools") = Val(dt2.Rows(0)("spools").ToString())
                dr("kg_nt") = Val(dt2.Rows(0)("kg_nt").ToString())
                dr("lotno_our") = dt2.Rows(0)("lotno_our").ToString()
                dr("spools_out") = Val(dt2.Rows(0)("spools_out").ToString())
                dr("kg_nt_out") = Val(dt2.Rows(0)("kg_nt_out").ToString())
                dr("supname") = dt2.Rows(0)("supname").ToString()
                dr("coname") = dt2.Rows(0)("coname").ToString()
                dr("itdesc2") = dt2.Rows(0)("itdesc2").ToString()
                dr("balance_spools") = Val(dt2.Rows(0)("balance_spools").ToString())
                dr("balance") = Val(dt2.Rows(0)("balance").ToString())
                dr("loc") = dt2.Rows(0)("loc").ToString()
                dr("grade") = dt2.Rows(0)("grade").ToString()
                dr("box_remark") = dt2.Rows(0)("box_remark").ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dr
    End Function

    Private Sub frmEndingInventory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnNew_Click(sender, e)

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt

        txtBoxNo.Focus()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call GenNewTable()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "reportYarnBalanceByBox.rpt"
        Dim frm As New frmReport

        If Not clsConfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
        'rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        'rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        'rpt.VerifyDatabase()
        'rpt.SetParameterValue("@docno", txtDocNo.Text)

        Dim ds As New DataSet
        ds.Tables.Add(dt)
        rpt.SetDataSource(ds)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn Balance By Box"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub txtBoxNo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBoxNo.KeyDown
        If e.KeyCode = Keys.Enter Then

            If txtBoxNo.Text.Trim.Length = 0 Then Exit Sub

            Dim dr As DataRow = GetBoxDescription(txtBoxNo.Text.Trim)
            'If dr("id").ToString().Equals("0") Then 
            dt.Rows.Add(dr)
            If dt.Rows.Count > 1 Then grdData.FirstDisplayedScrollingRowIndex = dt.Rows.Count - 1

            txtBoxNo.Text = ""
            txtBoxNo.Focus()
        End If
    End Sub
End Class