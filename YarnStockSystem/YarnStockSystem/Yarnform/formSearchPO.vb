Imports System
Imports System.data
Imports System.Data.SqlClient
Imports System.Text

Public Class formSearchPO
	Dim conn As New SqlConnection
	Dim selectedPO As String
    Dim userAction As String
    Dim currentRow As Integer

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

	Private Sub formSearchPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		If Not InitConn() Then Me.Close()
		Me.ComboSupplier1.populateData(conn)
		Me.ComboSupplier1.SelectedValue = "NONE"
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call btnSearch_Click(sender, e)
	End Sub

	Private Sub dgPO_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPO.CellContentDoubleClick
		selectedPO = dgPO.Rows(e.RowIndex).Cells(0).Value
		userAction = "OK"
		Me.Close()
	End Sub

	Public Function getPono() As String
		Me.ShowDialog()
		If userAction = "OK" Then
			Return selectedPO
		Else
			Return ""
		End If
	End Function

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
		userAction = "OK"
		Me.Close()
	End Sub

	Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
		userAction = "CANCEL"
		Me.Close()
	End Sub

	Private Sub dgPO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPO.CellContentClick
		selectedPO = dgPO.Rows(e.RowIndex).Cells(0).Value

	End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strSQL As New StringBuilder
        strSQL.Append("select distinct jobno,jobdt,supname,suppcd ")
        strSQL.Append("from v_pur where convert(varchar(8),jobdt,112) between '")
        strSQL.Append(dtpDateFr.Value.ToString("yyyyMMdd"))
        strSQL.Append("' and '")
        strSQL.Append(dtpDateTo.Value.ToString("yyyyMMdd"))
        strSQL.Append("'")
        If ComboSupplier1.SelectedValue.ToString.Trim.ToUpper <> "NONE" Then
            strSQL.Append(" and suppcd = '")
            strSQL.Append(ComboSupplier1.SelectedValue.ToString.Trim)
            strSQL.Append("'")
        End If
        Dim da As New SqlDataAdapter(strSQL.ToString, conn)
        Dim dtPO As New DataTable
        da.Fill(dtPO)
        If dtPO.Rows.Count > 0 Then selectedPO = dtPO.Rows(0)(0).ToString
        dgPO.Visible = False
        dgPO.DataSource = Nothing
        dgPO.DataSource = dtPO
        dgPO.Columns(3).Width = 0
        dgPO.Refresh()
        dgPO.Visible = True
    End Sub

    Private Sub dgPO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgPO.KeyDown

        If e.KeyCode = 13 Then
            If currentRow >= 0 And currentRow < dgPO.Rows.Count Then
                selectedPO = dgPO.Rows(currentRow).Cells(0).Value
            End If

            userAction = "OK"
            Me.Close()

        End If
    End Sub

    Private Sub dgPO_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPO.RowEnter
        currentRow = e.RowIndex
    End Sub
End Class