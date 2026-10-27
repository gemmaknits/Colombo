Imports System.Data.SqlClient

Public Class frmStockDClearanceSale
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
        Dim comm As SqlCommand = New SqlCommand("exec p_clearance_sale_d_update '" & rollNo & "'", conn)
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

    Private Function GenPackingList(ByRef StockDClearanceSale_Header As classStockDClearanceSale.StockDClearanceSale_Header) As Boolean
        Dim conn As SqlConnection = New classConnection().getSQLConnection()
        conn.Open()
        'Dim comm As SqlCommand = New SqlCommand("exec p_clearance_sale_d_packing '" & cboCustomer.SelectedValue.ToString() & "','" & clsUser.UserID & "'", conn)
        Dim comm As SqlCommand = New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_clearance_sale_d_packing"
        comm.Parameters.AddWithValue("@custcd", cboCustomer.SelectedValue.ToString())
        comm.Parameters.AddWithValue("@logempcd", clsUser.UserID)
        comm.Parameters.AddWithValue("@docdt", dtpDocDate.Value.Date)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try


            da.Fill(dt)
        Catch ex As Exception

            StockDClearanceSale_Header.Message = ex.Message
            tran.Rollback()
            conn.Close()
            'MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        If dt.Rows.Count = 0 Then Return False
        strDocNo = dt.Rows(0)("packno").ToString()

        StockDClearanceSale_Header.sono = dt.Rows(0)("sono").ToString()
        StockDClearanceSale_Header.outno = dt.Rows(0)("outno").ToString()
        StockDClearanceSale_Header.packno = dt.Rows(0)("packno").ToString()

        tran.Commit()
        conn.Close()
        
        'MessageBox.Show("S/O No. = " & dt.Rows(0)("sono").ToString() & vbCrLf & _
        '                "Pack No. = " & dt.Rows(0)("packno").ToString() & vbCrLf & _
        '               "D-OUT No. = " & dt.Rows(0)("outno").ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return True
    End Function

    'Private Function GenPackingList() As Boolean
    '    Dim conn As SqlConnection = New classConnection().getSQLConnection()
    '    Dim comm As SqlCommand = New SqlCommand("exec p_clearance_sale_d_packing '" & cboCustomer.SelectedValue.ToString() & "','" & clsUser.UserID & "'", conn)
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable

    '    Try
    '        da.Fill(dt)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End Try

    '    If dt.Rows.Count = 0 Then Return False

    '    MessageBox.Show("S/O No. = " & dt.Rows(0)("sono").ToString() & vbCrLf & _
    '                    "Pack No. = " & dt.Rows(0)("packno").ToString() & vbCrLf & _
    '                    "D-OUT No. = " & dt.Rows(0)("outno").ToString(), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    strDocNo = dt.Rows(0)("packno").ToString()

    '    conn.Close()
    '    Return True
    'End Function

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

    Private Sub frmStockDClearanceSale_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grdData.AutoGenerateColumns = False
        grdData.DataSource = GetData("")

        cboCustomer.DataSource = GetCustomerCombo()
        cboCustomer.DisplayMember = "name"
        cboCustomer.ValueMember = "custcd"
        cboCustomer.SelectedIndex = -1

        txtBarcode.Focus()
    End Sub

    Private Sub frmStockDClearanceSale_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        txtBarcode.Focus()
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        If MessageBox.Show("Would you like to clear all data ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then grdData.DataSource = GetData("NEW")
        txtBarcode.Focus()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Dim StockDClearanceSale_Header As New classStockDClearanceSale.StockDClearanceSale_Header

        If cboCustomer.SelectedIndex = -1 Then
            MessageBox.Show("โปรดเลือก Cutomer ", "System Message ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboCustomer.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Would you like to Generate Packing List ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If GenPackingList(StockDClearanceSale_Header) Then
                MessageBox.Show("S/O No. = " & StockDClearanceSale_Header.sono & vbCrLf & _
                        "Pack No. = " & StockDClearanceSale_Header.packno & vbCrLf & _
                        "D-OUT No. = " & StockDClearanceSale_Header.outno, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                grdData.DataSource = GetData("NEW")
            Else
                MessageBox.Show(StockDClearanceSale_Header.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If

        txtBarcode.Focus()
        'If MessageBox.Show("Would you like to Generate Packing List ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '    GenPackingList()
        '    grdData.DataSource = GetData("NEW")
        'End If

        'txtBarcode.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "rptClearanceSaleD.rpt"
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
End Class