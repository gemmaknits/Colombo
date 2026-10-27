Public Class frmSearchREQD
    Dim clsConfig As New clsConfig
    Dim strReqNo As String = ""
    Dim _StockType As String
    Dim strOutReqtyp As String = ""
    Dim blnOk As Boolean = False
    Dim oSearchREQD As New classSearchREQD
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
            pStockType = _StockType
        End Get
        Set(ByVal NewValue As String)
            _StockType = NewValue
        End Set
    End Property

    Public Property pOutReqTyp() As String
        Get
            pOutReqTyp = strOutReqtyp
        End Get
        Set(ByVal NewValue As String)
            strOutReqtyp = NewValue
        End Set
    End Property

    Public Property pblnOk As Boolean
        Get
            pblnOk = blnOk
        End Get
        Set(ByVal NewValue As Boolean)
            blnOk = NewValue
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
        ' Dim dt As DataTable
        '    dt = oSearchREQD.selectCustomersList
        Me.cboCustomer.DataSource = oSearchREQD.selectCustomersList
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
        dt = objDB.SearchOutReqNo(_StockType, txtReqNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim.ToUpper, clsConfig.IsNull(CboDoc_type.SelectedValue, strOutReqtyp))
        If dt.Rows.Count > 0 Then
            strReqNo = dt.Rows(0)("outreqno")
        End If
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub btnRefresh2_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh2.Click
        Call GenGrid()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs)
        Call GenGrid()
    End Sub

    Private Sub btnMinimized_Click_1(sender As System.Object, e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub grdReq_DoubleClick(sender As Object, e As System.EventArgs) Handles grdData.DoubleClick
        Call Getdata()

    End Sub

    Private Sub CboDoc_type_DropDownClosed(sender As Object, e As System.EventArgs) Handles CboDoc_type.DropDownClosed
        Call GenGrid()
    End Sub

    Private Sub txtReqNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtReqNo.KeyDown
        If Keys.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub btnExit_Click_1(sender As System.Object, e As System.EventArgs)
        blnOk = False
        Me.Close()
    End Sub

    Private Sub Getdata()
        If grdData.Rows.Count > 0 Then
            strReqNo = grdData.CurrentRow.Cells("outreqno").Value
            blnOk = True
        End If
        Me.Hide()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Call Getdata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
End Class