Imports System.Text
Public Class frmSearchPackingListD
    Dim clsConfig As New clsConfig
    Dim strPackNo As String = ""
    Dim blnok As Boolean = False
    Private bsSearchTable As New BindingSource
    Dim _StockType As String
    Public Property pStockType As String
        Get
            pStockType = _StockType
        End Get
        Set(ByVal Newvalue As String)
            _StockType = Newvalue
        End Set
    End Property

    Public Property pPackno As String
        Get
            pPackno = strPackNo.ToUpper
        End Get
        Set(ByVal NewValue As String)
            strPackNo = NewValue
        End Set
    End Property

    Public Property pblnOk As Boolean
        Get
            pblnOk = blnok
        End Get
        Set(ByVal NewValue As Boolean)
            blnok = NewValue
        End Set
    End Property

    Private Sub GenCombo()
        'Dim objDB As New classMaster
        'Dim dt As DataTable
        'dt = objDB.GetCustomer
        'Me.cbocustomer.DataSource = dt
        'Me.cbocustomer.DisplayMember = "name"
        'Me.cbocustomer.ValueMember = "custcd"
    End Sub
    Private Sub GenGrid()
        Dim objDB As New classPackingListD
        Dim dt As New DataTable
        strPackNo = txtPackNo.Text.Trim.ToUpper
        dt = objDB.SearchPackno(_StockType, strPackNo, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd") _
                              , txtCustCode.Text.Trim.ToUpper) 'Sitthana 20201128
        If dt.Rows.Count > 0 Then
            strPackNo = dt.Rows(0)("packno")
        End If
        grdData.AutoGenerateColumns = False
        bsSearchTable.DataSource = dt
        grdData.DataSource = bsSearchTable
    End Sub

    Private Sub frmSearchPackingListD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
        Call GenGrid()
        txtPackNo.SelectAll()
    End Sub

    Private Sub btnRefresh2_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh2.Click
        Call GenGrid()
    End Sub

    Private Sub cbocustomer_DropDownClosed(sender As Object, e As System.EventArgs)
        Call GenGrid()
    End Sub

    Private Sub dtpDateFr_LostFocus(sender As Object, e As System.EventArgs) Handles dtpDateFr.LostFocus
        Call GenGrid()
    End Sub

    Private Sub dtpDateTo_LostFocus(sender As Object, e As System.EventArgs) Handles dtpDateTo.LostFocus
        Call GenGrid()
    End Sub

    Private Sub grdPackinglistD_CellDoubleClick(sender As Object, e As System.EventArgs) Handles grdData.CellDoubleClick
        Call Getdata()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs)
        Call GenGrid()
    End Sub

    Private Sub Getdata()
        If grdData.Rows.Count > 0 Then
            strPackNo = grdData.CurrentRow.Cells("grdPackinglistD_packno").Value
            blnok = True
        End If
        Me.Hide()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Call Getdata()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub txtPackNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPackNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub dtpDateFr_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpDateFr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub dtpDateTo_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpDateTo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub cbocustomer_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Dim f As New Classes.formSearchCustomer
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        Dim oConn As New classConnection
        f.setConnectionString(oConn.getSQLConnection)
        f.deptcd = ""
        f.logempcd = (New classUserInfo).UserName
        f.customerName = ""
        SearchResult = f.ShowCustomers
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtCustCode.Text = drv.Item("custcd")
            txtCustName.Text = drv.Item("name")
        End If
    End Sub
    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtWordFilter.Text.Trim
        FilterExp.Clear()
        FilterExp.Append(" packno LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or OutNo LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or custname LIKE '*" & SearchString & "*'")

        If SearchString <> "" Then
            bsSearchTable.Filter = FilterExp.ToString
        Else
            bsSearchTable.Filter = ""
        End If
    End Sub
End Class