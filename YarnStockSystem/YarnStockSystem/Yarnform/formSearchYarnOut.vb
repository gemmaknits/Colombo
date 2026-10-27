Imports System
Imports System.data
Imports System.Data.SqlClient
Imports System.Text


Public Class formSearchYarnOut
	Dim conn As New SqlConnection
	Dim SelectedYarnOut As String
    Dim userAction As String
    Dim StrTran_Type As String = ""

    Public Property p_tran_type As String
        Get
            p_tran_type = StrTran_Type
        End Get
        Set(ByVal NewValue As String)
            StrTran_Type = NewValue
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

	Private Sub formSearchYarn_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
		If Not conn Is Nothing Then
			If conn.State = ConnectionState.Open Then conn.Close()
			conn.Dispose()
		End If
	End Sub

	Private Sub formSearchYarn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		If Not InitConn() Then Me.Close()
		dtpDateFr.Value = DateAdd(DateInterval.Month, -2, Now)
		dtpDateTo.Value = Now
		Call btnSearch_Click(sender, e)
	End Sub

	Private Sub dgYarn_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgYarn.CellContentDoubleClick
        'If e.RowIndex > -1 Then
        SelectedYarnOut = dgYarn.Rows(e.RowIndex).Cells("colDocno").Value
        'Else
        ' SelectedYarnOut = ""
        ' End If
        userAction = "OK"
        Me.Close()
	End Sub

	Public Function getYarnOutno() As String
		Me.ShowDialog()
		If userAction = "OK" Then
			Return SelectedYarnOut
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

	Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
		Dim strSql As New StringBuilder
		strSql.Append("select distinct ")
		strSql.Append("convert(varchar(10),outdt,103) as outdt,")
        strSql.Append("outno,tran_type,kono ")
		strSql.Append("from yarn_out where convert(varchar(8),outdt,112) between '")
		strSql.Append(dtpDateFr.Value.ToString("yyyyMMdd"))
		strSql.Append("' and '")
		strSql.Append(dtpDateTo.Value.ToString("yyyyMMdd"))
		strSql.Append("'")
		strSql.Append("order by outno")
		Dim da As New SqlDataAdapter(strSql.ToString, conn)
		Dim dtYarn As New DataTable
		da.Fill(dtYarn)
		If dtYarn.Rows.Count > 0 Then SelectedYarnOut = dtYarn.Rows(0)("outno").ToString
		dgYarn.Visible = False
		dgYarn.DataSource = dtYarn
		dgYarn.Refresh()
        dgYarn.Visible = True

        Call Search(dtResult:=dgYarn.DataSource)
    End Sub

    Private Sub Search(ByVal dtResult As DataTable)
        Dim dvResult As DataView 'ตัวแปรเก็บผลลัพธ์
        Dim strFilter As String 'ตัวแปรเก็บเงื่อนไขค้นหา

        dvResult = New DataView(dtResult) 'นำข้อมูลจาก DataTable ที่ต้องการค้นหา มาไว้ใน DataView
        If p_tran_type.ToString.Trim.Length > 0 Then
            strFilter = "tran_type like '%" & p_tran_type & "%'"
        Else
            strFilter = ""
        End If

        dvResult.RowFilter = strFilter 'ค้นหา

        dgYarn.DataSource = dvResult 'นำผลลัพธ์ที่ค้นหาคืนสู่ DataGridView
    End Sub

	Private Sub dgYarn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgYarn.CellContentClick
        If Not e.RowIndex > -1 Then Exit Sub
        SelectedYarnOut = dgYarn.Rows(e.RowIndex).Cells("colDocno").Value
	End Sub
End Class