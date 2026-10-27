Public Class frmSearchREQD
    Dim clsConfig As New clsConfig
    Dim strReqNo As String = ""
    Dim strStockType As String = ""
    Dim strOutReqtyp As String = ""

    Public Property pReqNo() As String
        Get
            pReqNo = strReqNo
        End Get
        Set(ByVal NewValue As String)
            strReqNo = NewValue
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

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmSearchREQD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
        Call GenGrid()
    End Sub
    Private Sub GenCombo()
        Dim objDB As New classMaster
        Dim dt As DataTable
        dt = objDB.GetCustomer
        Me.cboCustomer.DataSource = dt
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"

        Me.CboDoc_type.DataSource = objDB.GetDocType
        Me.CboDoc_type.DisplayMember = "name"
        Me.CboDoc_type.ValueMember = "doctyp"
        Me.CboDoc_type.SelectedIndex = -1

    End Sub



    Private Sub GenGrid()
        Dim objDB As New classSearchREQD
        Dim dt As New DataTable
        dt = objDB.SearchOutReqNo(strStockType, txtReqNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim.ToUpper, clsConfig.IsNull(CboDoc_type.SelectedValue, strOutReqtyp))
        If dt.Rows.Count > 0 Then
            strReqNo = dt.Rows(0)("outreqno")
        End If
        grdReq.AutoGenerateColumns = False
        grdReq.DataSource = dt
    End Sub

    Private Sub btnRefresh2_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh2.Click
        Call GenGrid()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Call GenGrid()
    End Sub

    Private Sub btnMinimized_Click_1(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub grdReq_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdReq.CellContentClick

    End Sub

    Private Sub grdReq_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdReq.CellDoubleClick

    End Sub

    Private Sub grdReq_DoubleClick(sender As Object, e As System.EventArgs) Handles grdReq.DoubleClick
        If grdReq.Rows.Count > 0 Then strReqNo = grdReq.CurrentRow.Cells("outreqno").Value
        Me.Hide()
    End Sub

    Private Sub CboDoc_type_DropDownClosed(sender As Object, e As System.EventArgs) Handles CboDoc_type.DropDownClosed
        GenGrid()
    End Sub

    Private Sub CboDoc_type_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboDoc_type.SelectedIndexChanged

    End Sub

    Private Sub txtReqNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtReqNo.KeyDown
        If Keys.KeyCode = Keys.Enter Then
            GenGrid()
        End If
    End Sub

    Private Sub txtReqNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtReqNo.TextChanged

    End Sub
End Class