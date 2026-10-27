Imports System.Data.SqlClient

Public Class frmStockGClearanceSale
    Dim clsUser As New classUserInfo
    Dim strDocNo As String = ""

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Function GetData(ByVal rollNo As String) As DataTable
        Dim conn As SqlConnection = New classConnection().getSQLConnection()
        Dim comm As SqlCommand = New SqlCommand("exec p_clearance_sale_g_update '" & rollNo & "'", conn)
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

    Private Function GenPackingList() As Boolean
        Dim conn As SqlConnection = New classConnection().getSQLConnection()
        Dim comm As SqlCommand = New SqlCommand("exec p_clearance_sale_g_packing '" & cboCustomer.SelectedValue.ToString() & "','" & clsUser.UserID & "'", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        If dt.Rows.Count = 0 Then Return False

        MessageBox.Show("S/O No. = " & dt.Rows(0)("sono").ToString() & vbCrLf & _
                        "Pack No. = " & dt.Rows(0)("packno").ToString() & vbCrLf & _
                        "G-OUT No. = " & dt.Rows(0)("outno").ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        strDocNo = dt.Rows(0)("packno").ToString()

        conn.Close()
        Return True
    End Function

    Public Function GetCustomerCombo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_customer"
        comm.Parameters.AddWithValue("@logempcd", clsUser.UserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Private Sub frmStockGClearanceSale_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grdData.AutoGenerateColumns = False
        grdData.DataSource = GetData("")

        cboCustomer.DataSource = GetCustomerCombo()
        cboCustomer.DisplayMember = "name"
        cboCustomer.ValueMember = "custcd"
        cboCustomer.SelectedIndex = -1

        txtBarcode.Focus()
    End Sub

    Private Sub frmStockGClearanceSale_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        txtBarcode.Focus()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If MessageBox.Show("Would you like to clear all data ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then grdData.DataSource = GetData("NEW")
        txtBarcode.Focus()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to Generate Packing List ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            GenPackingList()
            grdData.DataSource = GetData("NEW")
        End If

        txtBarcode.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "rptClearanceSaleG.rpt"
        Dim frm As New frmReport

        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@packno", strDocNo)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Clearance Sale"
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

    Private Sub txtBarcode_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim barcode As String = txtBarcode.Text.Trim
            txtBarcode.Text = ""
            txtBarcode.ReadOnly = True

            If barcode.Length = 0 Then GoTo ExitSub

            'Dim dt As DataTable = GetData(barcode)
            grdData.DataSource = GetData(barcode)
            'If dt.Rows.Count > 1 Then grdData.FirstDisplayedScrollingRowIndex = dt.Rows.Count - 1

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
                    End If
                End If
            End If
        End If

        txtBarcode.Focus()
    End Sub

    Private Sub txtBarcode_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub
End Class