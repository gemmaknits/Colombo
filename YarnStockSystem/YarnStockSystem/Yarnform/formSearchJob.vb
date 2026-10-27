Imports System
Imports System.data
Imports System.Data.SqlClient
Imports System.Text

Public Class formSearchJob
    Dim oConn As New classConnection
    Dim conn As New SqlConnection
    Dim selectedPO As String
    Dim userAction As String
    Dim currentRow As Integer
    Dim bsSearchTable As New BindingSource 'Sitthana 20191129
    Dim blnOk As Boolean = False
    Dim JobNo As String
    Dim oconfig As New clsConfig
    Public Property pblnOk As Boolean
        Get
            pblnOk = blnOk
        End Get
        Set(ByVal NewValue As Boolean)
            blnOk = NewValue
        End Set
    End Property

    Public Property pJobNo() As String
        Get
            pJobNo = JobNo
        End Get
        Set(ByVal NewValue As String)
            JobNo = NewValue
        End Set
    End Property
    Private Function InitConn() As Boolean
        InitConn = False
        If Not conn Is Nothing Then conn = Nothing
        conn = New SqlConnection(oConn.Connection)
        If Not conn Is Nothing Then
            If conn.State = ConnectionState.Closed Then conn.Open()
            If conn.State = ConnectionState.Open Then InitConn = True
        End If
    End Function

    Private Sub formsearchJob_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not conn Is Nothing Then
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Dispose()
        End If
    End Sub

    Private Sub formsearchJob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not InitConn() Then Me.Close()
        'Me.ComboSupplier1.populateData(conn) 'Comment By Sitthana 20191129
        'Me.ComboSupplier1.SelectedValue = "NONE" 'Comment By Sitthana 20191129
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        showJobData()
    End Sub

    Private Sub dgPO_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentDoubleClick
        Call Getdata()
        'selectedPO = grdData.Rows(e.RowIndex).Cells("colPono").Value
        'userAction = "OK"
        'Me.Close()
    End Sub

    Public Function getJobno() As String
        Me.ShowDialog()
        If userAction = "OK" Then
            Return selectedPO
        Else
            Return ""
        End If
    End Function

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Call Getdata()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        userAction = "CANCEL"
        Me.Close()
    End Sub

    'Private Sub dgPO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick
    '    If e.RowIndex > 0 Then
    '        selectedPO = grdData.Rows(e.RowIndex).Cells("colPono").Value
    '    End If
    '    ' selectedPO = dgPO.Rows(e.RowIndex).Cells("colPono").Value
    'End Sub

    Private Sub dgPO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdData.KeyDown
        If e.KeyCode = 13 Then
            Call Getdata()
            'If currentRow >= 0 And currentRow < grdData.Rows.Count Then
            '    selectedPO = grdData.Rows(currentRow).Cells("colPono").Value
            'End If

            'userAction = "OK"
            'Me.Close()
        End If
    End Sub

    Private Sub dgPO_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.RowEnter
        currentRow = e.RowIndex
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        showJobData()
    End Sub
    Private Sub showJobData()
        Dim strSQL As New StringBuilder
        strSQL.Append("select distinct jobno,jobdt,jobtype,v_job.present_status,yo.outno,supname,v_job.suppcd ")
        strSQL.Append("from v_job left join yarn_out yo on v_job.jobno = yo.refdocno where cast(jobdt as date) between '")
        strSQL.Append(dtpDateFr.Value.ToString("yyyy-MM-dd"))
        strSQL.Append("' and '")
        strSQL.Append(dtpDateTo.Value.ToString("yyyy-MM-dd"))
        strSQL.Append("'")
        If txtSupplierCode.Text.Trim <> "" Then
            strSQL.Append(" and suppcd = '" & txtSupplierCode.Text.Trim & "'") 'Sitthana 20191129
        End If

        'If ComboSupplier1.SelectedValue.ToString.Trim.ToUpper <> "NONE" Then
        '    strSQL.Append(" and suppcd = '")
        '    strSQL.Append(ComboSupplier1.SelectedValue.ToString.Trim)
        '    strSQL.Append("'")
        'End If
        strSQL.Append(" order by jobno asc")
        Dim da As New SqlDataAdapter(strSQL.ToString, conn)
        Dim dtPO As New DataTable
        da.Fill(dtPO)
        If dtPO.Rows.Count > 0 Then selectedPO = dtPO.Rows(0)("jobno").ToString

        grdData.Visible = False
        grdData.AutoGenerateColumns = False
        bsSearchTable.DataSource = Nothing 'Sitthana 20191129
        'dgPO.DataSource = Nothing
        If dtPO.Rows.Count > 0 Then
            bsSearchTable.DataSource = dtPO
            grdData.DataSource = dtPO
            grdData.DataSource = bsSearchTable
            bsSearchTable.MoveFirst()
            'dgPO.Refresh()
            grdData.Visible = True
        End If

    End Sub
    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs) Handles btnSearchSupplier.Click
        Dim f As New Classes.formSearchSupplier
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(oConn.getSQLConnection)
        SearchResult = f.ShowSuppliers()
        f.Close()
        f.Dispose()
        drv = SearchResult.ResultRowView
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtSupplierCode.Text = drv.Item("suppcd")
            txtSupplierName.Text = drv.Item("name")
        End If
    End Sub
    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtWordFilter.Text.Trim
        FilterExp.Append(" jobno LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or supname LIKE '*" & SearchString & "*'")


        If SearchString <> "" Then
            bsSearchTable.Filter = FilterExp.ToString
        Else
            bsSearchTable.Filter = ""
        End If
    End Sub
    Private Sub Getdata()
        If grdData.Rows.Count > 0 Then
            pJobNo = oconfig.isnull(grdData.CurrentRow.Cells("colPono").Value, "")
            blnOk = True
        End If
        Me.Close()
    End Sub
End Class