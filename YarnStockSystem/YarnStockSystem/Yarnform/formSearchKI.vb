Imports System
Imports System.data
Imports System.Data.SqlClient
Imports System.Text


Public Class formSearchKO
	Dim conn As New SqlConnection
	Dim SelectedKO As String
    Dim _userAction As String
    Dim bsSearchTable As New BindingSource 'Sitthana 20191129

    Public Property pUserAction As String
        Get
            pUserAction = _userAction
        End Get
        Set(ByVal newvalue As String)
            _userAction = newvalue
        End Set
    End Property

    Private Function InitConn() As Boolean
        Dim classCn As New classConnection
        InitConn = False
        If Not conn Is Nothing Then conn = Nothing
        conn = New SqlConnection(classCn.Connection)
        If Not conn Is Nothing Then
            If conn.State = ConnectionState.Closed Then conn.Open()
            If conn.State = ConnectionState.Open Then InitConn = True
        End If
    End Function

    Private Sub formSearchKo_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not conn Is Nothing Then
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Dispose()
        End If
    End Sub

    Private Sub formSearchKo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not InitConn() Then Me.Close()
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call fetchKoData()
    End Sub

    Private Sub dgKo_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgKo.CellContentDoubleClick
        'selectedKo = dgKo.Rows(e.RowIndex).Cells("colDocno").Value
        '  userAction = "OK"
        ' Me.Close()
    End Sub

    Public Function getKono() As String
        Me.ShowDialog()
        If _userAction = "OK" Then
            SelectedKO = dgKo.CurrentRow.Cells("colDocno").Value
            Return SelectedKO
        Else
            Return ""
        End If
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        _userAction = "OK"
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        _userAction = "CANCEL"
        Me.Close()
    End Sub


    Private Sub dgKo_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgKo.CellContentClick
        'If e.RowIndex > 0 Then SelectedKO = dgKo.Rows(e.RowIndex).Cells("colDocno").Value
        'userAction = "OK"
        'Me.Close()
    End Sub
    Private Sub fetchKoData()
        Dim strSql As New StringBuilder
        Dim cmd As New SqlCommand
        Dim classCn As New classConnection
        Dim cn As New SqlConnection
        cn.ConnectionString = classCn.Connection
        cmd.Connection = cn
        cmd.CommandText = "p_ko_yarn_select"
        cmd.Parameters.AddWithValue("kono", "")
        cmd.Parameters.AddWithValue("design_no", "")

        cmd.Parameters.AddWithValue("kodtfr", Me.dtpDateFr.Value.ToString("yyyyMMdd"))
        cmd.Parameters.AddWithValue("kodtto", Me.dtpDateTo.Value.ToString("yyyyMMdd"))
        cmd.Parameters.AddWithValue("kotype", "")
        cmd.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(cmd)
        Dim dtKo As New DataTable
        da.Fill(dtKo)
        If dtKo.Rows.Count > 0 Then SelectedKO = dtKo.Rows(0)("kono").ToString
        dgKo.Visible = False
        bsSearchTable.DataSource = dtKo 'Sitthana 20191129
        dgKo.DataSource = bsSearchTable 'Sitthana 20191129
        bsSearchTable.MoveFirst() 'Sitthana 20191129
        'dgKo.DataSource = dtKo 'Comment by Sitthana 20191129
        dgKo.Refresh()
        dgKo.Visible = True

    End Sub

    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtWordFilter.Text.Trim
        FilterExp.Append(" kono LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or design_no LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or design_no LIKE '*" & SearchString & "*'")


        If SearchString <> "" Then
            bsSearchTable.Filter = FilterExp.ToString
        Else
            bsSearchTable.Filter = ""
        End If
    End Sub
    Private Sub btnShowKoData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowKoData.Click
        fetchKoData()
    End Sub

    Private Sub dgKo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKo.CellDoubleClick
        SelectedKO = dgKo.Rows(e.RowIndex).Cells("colDocno").Value
        _userAction = "OK"
        Me.Close()
    End Sub
End Class