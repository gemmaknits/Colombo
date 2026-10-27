Imports System.Data.SqlClient

Public Class frmJobOrderBarcode
    Dim strDocNo As String = ""
    Dim clsUser As New classUserInfo
    Dim oJobOrderBarcode As New classJobOrderBarcode
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub SummarizeData()
        Dim dt As DataTable = grdData.DataSource
        If dt.Rows.Count > 0 Then
            txtTotalBox.Text = dt.Rows.Count.ToString("#,###")

            Dim spools As Integer = 0
            Dim kg_gr As Double = 0
            Dim kg_nt As Double = 0

            For Each dr As DataRow In dt.Rows
                spools += CInt(dr("spools"))
                kg_gr += CDbl(dr("kg_gr"))
                kg_nt += CDbl(dr("kg_nt"))
            Next

            txtTotalSpool.Text = spools.ToString("#,###")
            txtTotalKgGr.Text = kg_gr.ToString("#,###.##")
            txtTotalKgNt.Text = kg_nt.ToString("#,###.##")
        End If
    End Sub

    Private Function GenPackingList() As Boolean
        Dim conn As SqlConnection = New classConnection().getSQLConnection()
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn) '= New SqlCommand("exec p_barcode_job_generate '" & cboDocType.SelectedValue.ToString() & "','" & dtpJobDate.Value.ToString("yyyyMMdd") & "','" & txtKONo.Text & "','" & txtRemark.Text & "','" & clsUser.UserID & "'", conn)

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_barcode_job_generate"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@jobtype", cboDocType.SelectedValue.ToString())
        comm.Parameters.AddWithValue("@jobdt", dtpJobDate.Value.ToString("yyyyMMdd"))
        comm.Parameters.AddWithValue("@kono", txtKONo.Text.Trim)
        comm.Parameters.AddWithValue("@remark", txtRemark.Text.Trim)
        comm.Parameters.AddWithValue("@suppcd", CboSuppcd.SelectedValue.ToString())
        comm.Parameters.AddWithValue("@logempcd", clsUser.UserID)


        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            tran.Rollback()
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
            Return False
        End Try

        If dt.Rows.Count = 0 Then Return False

        MessageBox.Show("Job No. = " & dt.Rows(0)("jobno").ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If dt.Rows(0)("jobno").ToString().Length > 0 Then strDocNo = dt.Rows(0)("jobno").ToString()

        tran.Commit()
        conn.Close()
        Return True
    End Function

    Private Function GetData(ByVal rollNo As String) As DataTable
        Dim conn As SqlConnection = New classConnection().getSQLConnection()
        Dim comm As SqlCommand = New SqlCommand("exec p_barcode_job_update '" & rollNo & "'", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return GetData("")
        End Try

        conn.Close()
        Return dt
    End Function

    Public Function GetCombo() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Clear()
        comm.CommandText = "p_combo_tran_type"
        comm.Parameters.AddWithValue("@logempcd", clsUser.UserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Private Sub frmJobOrderBarcode_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        InitControl()



    End Sub

    Private Sub InitControl()

        FuncDiscbSupplier()

        cboDocType.DataSource = GetCombo()
        cboDocType.DisplayMember = "tran_type"
        cboDocType.ValueMember = "tran_type"
        cboDocType.SelectedIndex = -1

        grdData.AutoGenerateColumns = False
        grdData.DataSource = GetData("")

        Call SummarizeData()


        dtpJobDate.Value = Now()
        txtBarcode.Focus()
    End Sub

    Private Sub FuncDiscbSupplier()
        Dim tblSupplier As New GetDataYarn
        Dim dtsupplier As New DataTable
        dtsupplier = tblSupplier.GetSupplier
        If Not IsNothing(dtsupplier) Then
            Me.CboSuppcd.DataSource = dtsupplier
            Me.CboSuppcd.DisplayMember = "name"
            Me.CboSuppcd.ValueMember = "suppcd"
            Me.CboSuppcd.SelectedValue = oJobOrderBarcode.GetDefaultSuppcd ' "024"
            Me.CboSuppcd.Enabled = False
        End If
    End Sub

    Private Sub frmJobOrderBarcode_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        txtBarcode.Focus()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If MessageBox.Show("Would you like to clear all data ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then grdData.DataSource = GetData("NEW")
        txtBarcode.Focus()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click


        If MessageBox.Show("Would you like to Generate Packing List ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Not CheckData() Then
                Exit Sub
            End If

            GenPackingList()
            grdData.DataSource = GetData("NEW")
        End If

        txtBarcode.Focus()
    End Sub
    Private Function CheckData() As Boolean
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(cboDocType.SelectedValue, "") = "" Then
            MessageBox.Show("ต้องเลือก Process", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf txtKONo.Text.Trim = "" Then
            MessageBox.Show("ต้องเลือก K/O No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "RptJobOrderforYarn.rpt"
        Dim frm As New frmReport

        If Not clsConfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@jobno", strDocNo)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Job Order Barcode"
        frm.Show()
        Me.Cursor = Cursors.Default
        txtBarcode.Focus()
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub btnSearchKI_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchKI.Click
        Dim formSearchKi As New formSearchKO
        Dim selectedKono As String
        selectedKono = formSearchKO.getKono
        If selectedKono <> "" Then
            Me.txtKONo.Text = selectedKono
        End If
    End Sub

    Private Sub txtBarcode_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim barcode As String = txtBarcode.Text.Trim
            txtBarcode.Text = ""
            txtBarcode.ReadOnly = True

            If barcode.Length = 0 Then GoTo ExitSub

            'Dim dt As DataTable = GetData(barcode)
            grdData.DataSource = GetData(barcode)
            'If dt.Rows.Count > 1 Then grdData.FirstDisplayedScrollingRowIndex = dt.Rows.Count - 1
            Call SummarizeData()

ExitSub:
            txtBarcode.ReadOnly = False
            txtBarcode.Focus()
        End If
    End Sub

    Private Sub grdData_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles grdData.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim dt As DataTable = grdData.DataSource
            If dt.Rows.Count > 0 Then
                If Val(grdData.CurrentRow.Cells("id").Value) > 0 Then
                    If MessageBox.Show("Would you like to remove item number " & grdData.CurrentRow.Cells("id").Value.ToString() & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        grdData.DataSource = GetData("DELETE " & grdData.CurrentRow.Cells("id").Value.ToString())
                        Call SummarizeData()
                    End If
                End If
            End If
        End If

        txtBarcode.Focus()
    End Sub

    Private Sub txtKONo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtKONo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtBarcode.Focus()
        End If
    End Sub
End Class