Imports System
Imports System.data
Imports System.Data.SqlClient
Imports System.Text

Public Class formSearchItemCodeFromBalance
    Dim clsConfig As New clsConfig

    Dim conn As New SqlConnection
    'Dim selectedItcd As String
    Dim _userAction As String
    Dim itemNature As String
    Dim kono As String
    Dim dvItems As New DataView
    Dim strItnaturecd As String
    Dim _KoNo As String
    Dim bsSearchTable As New BindingSource 'Sitthana 20191129
    Dim _Itcd As String 'Sitthana 20191130
    Dim _MfgProductionOrderLinesId As Nullable(Of Int64)

    Public Property pUserAction As String
        Get
            pUserAction = _userAction
        End Get
        Set(ByVal newvalue As String)
            _userAction = newvalue
        End Set
    End Property

    Public Property pKoNo As String
        Get
            pKoNo = _KoNo
        End Get
        Set(ByVal NewValue As String)
            _KoNo = NewValue
        End Set
    End Property
    Public Property pItnaturecd As String
        Get
            pItnaturecd = strItnaturecd
        End Get
        Set(ByVal NewValue As String)
            strItnaturecd = NewValue
        End Set
    End Property
    Public Property pItcd As String
        Get
            pItcd = _Itcd
        End Get
        Set(ByVal NewValue As String)
            _Itcd = NewValue
        End Set
    End Property
    Public Property pMfgProductionOrderLinesId As Nullable(Of Int64)
        Get
            pMfgProductionOrderLinesId = _MfgProductionOrderLinesId
        End Get
        Set(ByVal NewValue As Nullable(Of Int64))
            _MfgProductionOrderLinesId = NewValue
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
        dgYarn.AutoGenerateColumns = False
        If Not InitConn() Then Me.Close()
        txtItcd.Text = pItcd
        txtKoNo.Text = pKoNo
        Call getItemcode() 'Sitthana 20191130
    End Sub

    Private Sub dgYarn_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgYarn.CellContentDoubleClick
        _Itcd = dgYarn.Rows(e.RowIndex).Cells("colitemcd").Value
        _MfgProductionOrderLinesId = (New clsConfig).IsNull(dgYarn.Rows(e.RowIndex).Cells("colMfgProductionOrderLinesId").Value, Nothing)
        _userAction = "OK"
        Me.Close()
    End Sub

    Public Function getItemcode() As String
        ' Call InitConn()

        Dim dtItems As New DataTable
        dtItems = (New classSearchYarnCodeFromBalance).GetYarnCodeFromKo(pitnaturecd:=pItnaturecd, pKono:=txtKoNo.Text,
                                                                        pItCd:=txtItcd.Text, StrFilter:=txtWordFilter.Text.Trim)

        bsSearchTable.DataSource = Nothing 'Sitthana 20191129
        If dtItems.Rows.Count > 0 Then
            'selectedItcd = dtItems.Rows(0)("Itcd").ToString
            _Itcd = dtItems.Rows(0)("Itcd").ToString 'Sitthana 20191130
            _MfgProductionOrderLinesId = (New clsConfig).IsNull(dtItems.Rows(0)("mfg_production_order_lines_id"), Nothing) 'Sitthana 20191210
            'dgYarn.DataSource = dvItems 'Comment By Sitthana 20191130
            bsSearchTable.DataSource = dtItems
            dgYarn.DataSource = bsSearchTable
            dgYarn.Refresh()
            'dgYarn.Visible = True
        Else
            'dgYarn.Visible = False
        End If

        'dvItems = New DataView(dtItems, "", "", DataViewRowState.CurrentRows) 'Sitthana 20191130

        'Me.ShowDialog() 'Comment By Sitthana 20191130
        If _userAction = "OK" Then
            Return _Itcd
        Else
            Return ""
        End If
    End Function
    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtWordFilter.Text.Trim
        FilterExp.Append(" itcd LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or itdesc2 LIKE '*" & SearchString & "*'")


        If SearchString <> "" Then
            bsSearchTable.Filter = FilterExp.ToString
        Else
            bsSearchTable.Filter = ""
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        _userAction = "OK"
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        _userAction = "CANCEL"
        Me.Close()
    End Sub

    Private Sub dgYarn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgYarn.CellContentClick
        If Not e.RowIndex > 0 Then
            Exit Sub
        End If
        _Itcd = dgYarn.Rows(e.RowIndex).Cells("colitemcd").Value
    End Sub

    Private Sub txtlookup_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItcd.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getItemcode()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call getItemcode()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbItcd.Click

    End Sub
End Class