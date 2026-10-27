Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Class formSearchItemcode
    Dim conn As New SqlConnection
    Dim selectedItcd As String
    Public userAction As String
    Dim clsconfig As New clsConfig
    Dim itemNature As String
    Dim Stritnaturecd As String
    'Dim Stritcd As String

    Public Property p_itnaturecd() As String
        Get
            p_itnaturecd = Stritnaturecd
        End Get
        Set(ByVal NewValue As String)
            Stritnaturecd = NewValue
        End Set
    End Property

    Public Property p_Itcd() As String
        Get
            p_Itcd = selectedItcd
        End Get
        Set(ByVal NewValue As String)
            selectedItcd = NewValue
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

    Private Sub formSearchYarn_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not conn Is Nothing Then
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Dispose()
        End If
    End Sub

    Private Sub formSearchYarn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not InitConn() Then Me.Close()
        Call InitControl()

        Me.CenterToParent()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub InitControl()
        Call GetDataComboItemNature()
        Call getItemcode(Stritnaturecd:=p_itnaturecd)
    End Sub
    Private Sub GetDataComboItemNature()
        Dim getDatayarn As New GetDataYarn
        Dim dt As DataTable
        dt = getDatayarn.GetDataItemNature()
        Me.comboItemNature.DataSource = dt
        Me.comboItemNature.DisplayMember = "itnaturedesc"
        Me.comboItemNature.ValueMember = "itnaturecd"
        Me.comboItemNature.SelectedIndex = 0
    End Sub

    Private Sub dgYarn_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgYarn.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            selectedItcd = dgYarn.Rows(e.RowIndex).Cells("colitemcd").Value
            userAction = "OK"
            Me.Close()
        End If
        'selectedItcd = dgYarn.Rows(e.RowIndex).Cells("colitemcd").Value
        'userAction = "OK"
        'Me.Close()
    End Sub

    Public Function getItemcode(ByVal Stritnaturecd As String) As String
        InitConn()

        Dim strSql As New StringBuilder
        strSql.Clear()
        strSql.Append("select distinct itcd,itdesc,itdesc2,itdesc3,itdesct,itdesct2,itdesct3,itdesc_spec from v_items_des_mc")
        If Stritnaturecd.Trim <> "" Then
            strSql.Append(" where itnaturecd='")
            strSql.Append(Stritnaturecd.Trim & "'")
        End If
        strSql.Append(" order by itcd,itdesc")

        Dim da As New SqlDataAdapter(strSql.ToString, conn)
        Dim dtItems As New DataTable
        da.Fill(dtItems)
        If dtItems.Rows.Count > 0 Then selectedItcd = dtItems.Rows(0)("Itcd").ToString
        dgYarn.Visible = False
        dgYarn.DataSource = dtItems
        dgYarn.Refresh()
        dgYarn.Visible = True

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

        Call getItemcode(comboItemNature.SelectedValue.ToString.Trim)
    End Sub

    Private Sub dgYarn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgYarn.CellContentClick
        If e.RowIndex >= 0 Then
            selectedItcd = dgYarn.Rows(e.RowIndex).Cells("colitemcd").Value
            userAction = "OK"
            Me.Close()
        End If
    End Sub

    Private Sub comboItemNature_DropDownClosed(sender As Object, e As EventArgs) Handles comboItemNature.DropDownClosed
        Call getItemcode(comboItemNature.SelectedValue.ToString.Trim)
    End Sub

    Private Sub comboItemNature_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboItemNature.SelectedIndexChanged

    End Sub
End Class