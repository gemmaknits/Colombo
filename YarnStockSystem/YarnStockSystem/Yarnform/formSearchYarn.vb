Imports System
Imports System.data
Imports System.Data.SqlClient
Imports System.Text


Public Class formSearchYarn
    Dim classCn As New classConnection
    Dim oConn As New SqlConnection
    Dim selectedYarn As String
    Dim selecteditcd As String
    Dim userAction As String
    Dim bsSearchTable As New BindingSource 'Sitthana 20191129

    Public Property pUserAction As String
        Get
            pUserAction = userAction
        End Get
        Set(ByVal NewValue As String)
            userAction = NewValue
        End Set
    End Property

    Private Function InitConn() As Boolean
        InitConn = False
        If Not oConn Is Nothing Then oConn = Nothing
        oConn = New SqlConnection(classCn.Connection)
        If Not oConn Is Nothing Then
            If oConn.State = ConnectionState.Closed Then oConn.Open()
            If oConn.State = ConnectionState.Open Then InitConn = True
        End If
    End Function

    Private Sub formSearchYarn_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        If Not oConn Is Nothing Then
            If oConn.State = ConnectionState.Open Then oConn.Close()
            oConn.Dispose()
        End If
    End Sub

    Private Sub formSearchYarn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not InitConn() Then
            Me.Close()
        End If
        'Me.ComboSupplier1.populateData(conn)
        'Me.ComboSupplier1.SelectedValue = "NONE"
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call btnSearch_Click(sender, e)
    End Sub

    Private Sub dgYarn_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgYarn.CellContentDoubleClick
        'selectedYarn = dgYarn.Rows(e.RowIndex).Cells("colDocno").Value  'Comment By Sitthana 24/04/2018
        'selecteditcd = dgYarn.Rows(e.RowIndex).Cells("itcd").Value  'Comment By Sitthana 24/04/2018
        KeepSelectValueAndClose()  'Sitthana 24/04/2018
    End Sub
    Private Sub KeepSelectValueAndClose()
        'Sitthana 24/04/2018
        With dgYarn
            selectedYarn = dgYarn.Rows(.CurrentRow.Index).Cells("colDocno").Value
            selecteditcd = dgYarn.Rows(.CurrentRow.Index).Cells("itcd").Value
            userAction = "OK"
            Me.Close()
        End With
    End Sub
    Public Function getYarnno() As String
        Me.ShowDialog()
        If userAction = "OK" Then
            Return selectedYarn
        Else
            Return ""
        End If
    End Function
    Public Function getitcd() As String
        Me.ShowDialog()
        If userAction = "OK" Then
            Return selecteditcd
        Else
            Return ""
        End If
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'userAction = "OK" 'Comment by Sitthana 24/04/2018
        'Me.Close() 'Comment by Sitthana 24/04/2018
        ' KeepSelectValueAndClose()  'Sitthana 24/04/2018
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
        strSql.Append("convert(varchar(10),docdt,103) as docdt,")
        strSql.Append("docno,itcd,itdesc,supname,lotno_sup,sinvno,KONO,")
        strSql.Append("isnull(convert(varchar(10),sinvdt,103),'') as sinvdt ")
        strSql.Append("from v_yarn_in where convert(varchar(8),docdt,112) between '")
        strSql.Append(dtpDateFr.Value.ToString("yyyyMMdd"))
        strSql.Append("' and '")
        strSql.Append(dtpDateTo.Value.ToString("yyyyMMdd"))
        strSql.Append("'")
        If txtSupplierCode.Text.Trim <> "" Then
            strSql.Append(" and suppcd = '" & txtSupplierCode.Text.Trim & "'") 'Sitthana 20191129
        End If
        strSql.Append("group by docdt,docno,itcd,itdesc,supname,lotno_sup,sinvno,sinvdt,kono  order by docno")

        'If ComboSupplier1.SelectedValue.ToString.Trim.ToUpper <> "NONE" Then
        '    strSQL.Append(" and suppcd = '")
        '    strSQL.Append(ComboSupplier1.SelectedValue.ToString.Trim)
        '    strSQL.Append("'")
        'End If

        Dim da As New SqlDataAdapter(strSql.ToString, oConn)
        Dim dtYarn As New DataTable
        da.Fill(dtYarn)
        If dtYarn.Rows.Count > 0 Then
            selectedYarn = dtYarn.Rows(0)("docno").ToString
            'dgYarn.DataSource = dtYarn 'Copmment By Sitthana 20191130
            'dgYarn.Refresh() 'Copmment By Sitthana 20191130

            bsSearchTable.DataSource = dtYarn 'Sitthana 20191130
            dgYarn.DataSource = bsSearchTable 'Sitthana 20191130
            bsSearchTable.MoveFirst()
            dgYarn.Visible = True
        Else
            dgYarn.Visible = False
        End If
    End Sub

    Private Sub dgYarn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgYarn.CellContentClick
        If Not e.RowIndex > 0 Then Exit Sub
        selectedYarn = dgYarn.Rows(e.RowIndex).Cells("colDocno").Value
        selecteditcd = dgYarn.Rows(e.RowIndex).Cells("itcd").Value
    End Sub

    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs) Handles btnSearchSupplier.Click
        Dim f As New Classes.formSearchSupplier
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(classCn.getSQLConnection)
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
        FilterExp.Clear()
        FilterExp.Append(" itcd LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or itdesc LIKE '*" & SearchString & "*'")


        If SearchString <> "" Then
            bsSearchTable.Filter = FilterExp.ToString
        Else
            bsSearchTable.Filter = ""
        End If
    End Sub

    Private Sub dgYarn_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgYarn.CellDoubleClick
        If Not e.RowIndex > 0 Then Exit Sub
        selectedYarn = dgYarn.Rows(e.RowIndex).Cells("colDocno").Value
        selecteditcd = dgYarn.Rows(e.RowIndex).Cells("itcd").Value
        Me.Hide()
    End Sub
End Class