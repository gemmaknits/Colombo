Imports System
Imports System.data
Imports System.Data.SqlClient
Imports System.Text

Public Class formSearchPO
    Dim conn As New SqlConnection
    Dim _SelectedPO As String
    Dim userAction As String
    Dim currentRow As Integer
    Dim dtSearchTable As New DataTable
    Dim bsSearchTable As BindingSource
    Dim oSearchPO As New classSearchPO
    Public Property puserAction As String
        Get
            puserAction = userAction
        End Get
        Set(ByVal NewValue As String)
            userAction = NewValue
        End Set
    End Property
    Public Property pSelectedPO As String
        Get
            pSelectedPO = _SelectedPO
        End Get
        Set(ByVal NewValue As String)
            _SelectedPO = NewValue
        End Set
    End Property

    Private Function InitConn() As Boolean
        Dim classCn As New classConnection
        InitConn = False
        If Not conn Is Nothing Then conn = Nothing
        conn = New SqlConnection(classCn.connection)
        If Not conn Is Nothing Then
            If conn.State = ConnectionState.Closed Then conn.Open()
            If conn.State = ConnectionState.Open Then InitConn = True
        End If
    End Function

    Private Sub formSearchPO_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not conn Is Nothing Then
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Dispose()
        End If
    End Sub

    Private Sub PopulateData(ByVal conn As SqlClient.SqlConnection)
        Dim dt As New DataTable
        dt = New classSearchPO().SelectSupplierList()
        cboSupplier.DataSource = dt
        cboSupplier.DisplayMember = "name"
        cboSupplier.ValueMember = "suppcd"
        'cboSupplier.SelectedIndex = -1
    End Sub

    Private Sub formSearchPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not InitConn() Then Me.Close()
        'Me.ComboSupplier1.populateData(conn)
        PopulateData(conn)
        ' Me.cboSupplier.SelectedValue = "" '"NONE"
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call btnSearch_Click(sender, e)
    End Sub

    Private Sub dgPO_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPO.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            pSelectedPO = dgvPO.Rows(e.RowIndex).Cells("colJobNo").Value
            userAction = "OK"
            Me.Close()
        End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If dgvPO.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a PO.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        pSelectedPO = dgvPO.CurrentRow.Cells("colJobNo").Value
        userAction = "OK"
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        userAction = "EXIT"
        Me.Close()
    End Sub

    Private Sub dgPO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPO.CellContentClick

        If e.RowIndex >= 0 Then
            pSelectedPO = dgvPO.Rows(e.RowIndex).Cells("colJobNo").Value
        End If


    End Sub

    Private Sub Getdata()
        Dim objDB As New classSearchPO
        Dim dt As New DataTable
        dtSearchTable = (New classSearchPO).SelectJobRecord(pSuppcd:=(New clsConfig).IsNull(cboSupplier.SelectedValue, ""),
                                                      pDateFr:=dtpDateFr.Value,
                                                      pDateTo:=dtpDateTo.Value,
                                                      pFilter:=txtWordFilter.Text)
        dgvPO.AutoGenerateColumns = False
        dgvPO.DataSource = dtSearchTable

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Call Getdata()
        ' drvs = CType(bsJob.Current, DataRowView)

        'Dim strSQL As New StringBuilder
        'strSQL.Append("select distinct jobno,jobdt,supname,suppcd ")
        'strSQL.Append("from v_pur where convert(varchar(8),jobdt,112) between '")
        'strSQL.Append(dtpDateFr.Value.ToString("yyyyMMdd"))
        'strSQL.Append("' and '")
        'strSQL.Append(dtpDateTo.Value.ToString("yyyyMMdd"))
        'strSQL.Append("'")
        'If ComboSupplier1.SelectedValue.ToString.Trim.ToUpper <> "NONE" Then
        '    strSQL.Append(" and suppcd = '")
        '    strSQL.Append(ComboSupplier1.SelectedValue.ToString.Trim)
        '    strSQL.Append("'")
        'End If
        'Dim da As New SqlDataAdapter(strSQL.ToString, conn)

        'da.Fill(dtSearchTable)
        'bsSearchTable.DataSource = dtSearchTable
        'If dtSearchTable.Rows.Count > 0 Then selectedPO = dtSearchTable.Rows(0)(0).ToString
        'dgPO.Visible = False
        'dgPO.DataSource = Nothing
        'dgPO.DataSource = dtSearchTable
        'dgPO.Columns(3).Width = 0
        'dgPO.Refresh()
        'dgPO.Visible = True
    End Sub

    Private Sub dgPO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvPO.KeyDown

        If e.KeyCode = 13 Then
            If currentRow >= 0 And currentRow < dgvPO.Rows.Count Then
                puserAction = dgvPO.Rows(currentRow).Cells("colJobNo").Value
            End If

            userAction = "OK"
            Me.Close()

        End If
    End Sub

    Private Sub dgPO_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPO.RowEnter
        currentRow = e.RowIndex
    End Sub

    Private Sub txtWordFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWordFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Getdata()
        End If
    End Sub
End Class