Imports System
Imports System.data
Imports System.Data.SqlClient
Imports System.Text

Public Class formSearchSO
	Dim conn As New SqlConnection
	Dim selectedSO As String
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

	Private Sub formSearchSO_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
		If Not conn Is Nothing Then
			If conn.State = ConnectionState.Open Then conn.Close()
			conn.Dispose()
		End If
    End Sub

    Private Sub PopulateData(ByVal conn As SqlClient.SqlConnection)
        Dim dt As New DataTable
        dt = New classMaster().GetSupplier()
        ComboSupplier1.DataSource = dt
        ComboSupplier1.DisplayMember = "name"
        ComboSupplier1.ValueMember = "suppcd"
        ComboSupplier1.SelectedIndex = -1
    End Sub

	Private Sub formSearchSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		If Not InitConn() Then Me.Close()
        'Me.ComboSupplier1.populateData(conn)
        PopulateData(conn)
		Me.ComboSupplier1.SelectedValue = "NONE"
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call btnSearch_Click(sender, e)
	End Sub

	Private Sub dgSO_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSO.CellContentDoubleClick
		selectedSO = dgSO.Rows(currentRow).Cells("colSono").Value
		userAction = "OK"
		Me.Close()
	End Sub

	Public Function getSOno() As String
		Me.ShowDialog()
		If userAction = "OK" Then
			Return selectedSO
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

	Private Sub dgSO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSO.CellContentClick
		selectedSO = dgSO.Rows(currentRow).Cells("colSono").Value

	End Sub

	Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim strSQL As New StringBuilder
		strSQL.Append("select distinct sodt,sono,cust ")
		strSQL.Append("from v_so where convert(varchar(8),sodt,112) between '")
		strSQL.Append(dtpDateFr.Value.ToString("yyyyMMdd"))
		strSQL.Append("' and '")
		strSQL.Append(dtpDateTo.Value.ToString("yyyyMMdd"))
		strSQL.Append("'")
		Dim da As New SqlDataAdapter(strSQL.ToString, conn)
		Dim dtSO As New DataTable
		da.Fill(dtSO)
		If dtSO.Rows.Count > 0 Then selectedSO = dtSO.Rows(0)(0).ToString
		dgSO.Visible = False
		dgSO.DataSource = Nothing
		dgSO.DataSource = dtSO
		dgSO.Refresh()
		dgSO.Visible = True
	End Sub

	Private Sub dgSO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgSO.KeyDown

		If e.KeyCode = 13 Then
			If currentRow >= 0 And currentRow < dgSO.Rows.Count Then
				selectedSO = dgSO.Rows(currentRow).Cells("colSono").Value
			End If

			userAction = "OK"
			Me.Close()

		End If
	End Sub

	Private Sub dgSO_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSO.RowEnter
		currentRow = e.RowIndex
	End Sub
End Class