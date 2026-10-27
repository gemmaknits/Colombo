Public Class frmSearchGIN
    Dim clsConfig As New clsConfig
    Dim strTranNo As String
    Dim strGINNo As String = ""
    Dim strStockType As String = ""
    Dim strDONo As String = ""
    Dim strOutReqtyp As String = ""

    Public Property pTranNo As String
        Get
            pTranNo = strTranNo
        End Get
        Set(ByVal NewValue As String)
            strTranNo = NewValue
        End Set
    End Property

    Public Property pGINno As String
        Get
            pGINno = strGINNo
        End Get
        Set(ByVal NewValue As String)
            strGINNo = NewValue
        End Set
    End Property
    Public Property pStockType() As String
        Get
            pStockType = strStockType
        End Get
        Set(ByVal NewValue As String)
            strStockType = NewValue
        End Set
    End Property

    Public Property pOutReqTyp() As String
        Get
            pOutReqTyp = strOutReqTyp
        End Get
        Set(ByVal NewValue As String)
            strOutReqTyp = NewValue
        End Set
    End Property

    Private Sub frmSearchGIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call Gencbo()
        Call Gengrd()
    End Sub
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Gencbo()
        Dim objdb As New classMaster
        Dim dt As DataTable
        dt = objdb.GetCustomer
        Me.cbocustomer.DataSource = dt
        Me.cbocustomer.DisplayMember = "name"
        Me.cbocustomer.ValueMember = "custcd"

        Me.CboDoc_type.DataSource = objdb.GetDocType
        Me.CboDoc_type.DisplayMember = "name"
        Me.CboDoc_type.ValueMember = "doctyp"
        Me.CboDoc_type.SelectedIndex = -1

    End Sub
    Private Sub Gengrd()
        Dim objdb As New classSearchGIN    'classSearchGIN
        ' Dim objdb As New classStockG
        Dim dt As DataTable
        dt = objdb.SearchGINNo(strStockType, txtTranNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cbocustomer.SelectedValue, "").ToString.Trim.ToUpper, clsConfig.IsNull(CboDoc_type.SelectedValue, strOutReqtyp), txtSourceRefno.Text)
        'dt = objdb.GetGINNoByDate(txtDOno.Text.Trim.ToUpper, strStockType, txtGinNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cbocustomer.SelectedValue, "").ToString.Trim.ToUpper)
        If dt.Rows.Count > 0 Then
            strGINNo = dt.Rows(0)("tran_no")

        End If
        grdGIN.AutoGenerateColumns = False
        grdGIN.DataSource = dt

    End Sub

    Private Sub grdDINno_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdGIN.CellDoubleClick
        If grdGIN.Rows.Count > 0 Then strGINNo = grdGIN.CurrentRow.Cells("tran_no").Value
        Me.Hide()
    End Sub

    Private Sub btnRefresh2_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh2.Click
        Call Gengrd()

    End Sub
End Class