Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class formSearchYarnCode
    Dim conn As New SqlConnection
    Dim selectedItcd As String
    Dim userAction As String
    Dim itemNature As String

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

    Private Sub formSearchYarn_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not conn Is Nothing Then
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Dispose()
        End If
    End Sub

    Private Sub formSearchYarnCode_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not InitConn() Then Me.Close()
    End Sub

    Private Sub dgYarn_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgYarn.CellContentDoubleClick
        selectedItcd = dgYarn.Rows(e.RowIndex).Cells("colitemcd").Value
        userAction = "OK"
        Me.Close()
    End Sub
    Public Function getItemcode(ByVal p_itemNature As String) As String
        InitConn()
        itemNature = p_itemNature
        Dim strSql As New StringBuilder
        strSql.Append("select distinct itcd,itdesc,itdesc2,itdesc3,itdesc_spec from items")
        If itemNature = "ALL" Then
            strSql.Append(" where itnaturecd='")
            strSql.Append(itemNature & "'")
        End If
        'strSql.Append("order by itdesc")

        Dim da As New SqlDataAdapter(strSql.ToString, conn)
        Dim dtItems As New DataTable
        da.Fill(dtItems)
        If dtItems.Rows.Count > 0 Then selectedItcd = dtItems.Rows(0)("Itcd").ToString
        dgYarn.Visible = False
        dgYarn.DataSource = dtItems
        dgYarn.Refresh()
        dgYarn.Visible = True

        Me.ShowDialog()
        If userAction = "OK" Then
            Return selectedItcd
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
        strSql.Append("select distinct itcd,itdesc from items where itnaturecd='YARNS'")
        If itemNature <> "ALL" Then
            strSql.Append(" where itnaturecd='")
            strSql.Append(itemNature & "'")
        End If
        strSql.Append("order by itdesc")

        Dim da As New SqlDataAdapter(strSql.ToString, conn)
        Dim dtItems As New DataTable
        da.Fill(dtItems)
        If dtItems.Rows.Count > 0 Then selectedItcd = dtItems.Rows(0)("Itcd").ToString
        dgYarn.Visible = False
        dgYarn.DataSource = dtItems
        dgYarn.Refresh()
        dgYarn.Visible = True
    End Sub
    Private Sub dgYarn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgYarn.CellContentClick
        ' If dgYarn.Rows(e.RowIndex).Cells("colitemcd").Value = "" Then
        'Exit Sub
        ' Else
        selectedItcd = dgYarn.Rows(e.RowIndex).Cells("colitemcd").Value
        ' End If

    End Sub

End Class