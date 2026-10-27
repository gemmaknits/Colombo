Public Class frmSearchKO
    Dim clsuser As New classUserInfo
    Dim strKONo As String = ""
    Dim int64ProductionOrderId As Int64
    Dim blnOk As Boolean = False
    Private oSearchKO As New classSearchKo
    Dim oConfig As New clsConfig

    Private _ProductionOrderTypeId As Nullable(Of Int64) = 0 'WONO KONO etc.
    Public Property pProductionOrderTypeId As Nullable(Of Int64)
        Get
            pProductionOrderTypeId = _ProductionOrderTypeId
        End Get
        Set(ByVal NewValue As Nullable(Of Int64))
            _ProductionOrderTypeId = NewValue
        End Set
    End Property

    Public Property pKono() As String
        Get
            pKono = strKONo
        End Get
        Set(ByVal NewValue As String)
            strKONo = NewValue
        End Set
    End Property
    Public Property pProductionOrderId As Int64
        Get
            pProductionOrderId = int64ProductionOrderId
        End Get
        Set(ByVal Newvalue As Int64)
            int64ProductionOrderId = Newvalue
        End Set
    End Property

    Public Property UserInfo() As classUserInfo 'Add by Neung 20151208
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
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
    Private Sub genCbo()
        Dim objdb As New classMaster

        Me.cboSup.DataSource = oSearchKO.selectSupplierList
        Me.cboSup.DisplayMember = "name"
        Me.cboSup.ValueMember = "suppcd"
        Me.cboSup.SelectedValue = -1

        Me.cboProdType.DataSource = oSearchKO.selectProductionTypeLookUpList
        Me.cboProdType.DisplayMember = "lookup_value"
        Me.cboProdType.ValueMember = "lookup_value_id"

    End Sub
    Private Sub GenCboInGrid()
        '   Dim objdb As New classMaster
        grd_cbosup.DataSource = oSearchKO.selectSupplierList
        grd_cbosup.DisplayMember = "name"
        grd_cbosup.ValueMember = "suppcd"
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSearchKo
        Dim dt As New DataTable

        ' _ProductionOrderTypeId = oConfig.isnull(cboProdType.SelectedValue, 0)
        dt = objDB.SearchKo(strKONo,
                            dtpDateFr.Value.ToString("yyyyMMdd"),
                            dtpDateTo.Value.ToString("yyyyMMdd"),
                            oConfig.IsNull(cboSup.SelectedValue, "").ToString.Trim.ToUpper,
                            txtDesignNo.Text,
                            oConfig.IsNull(cboProdType.SelectedValue, 0))

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub frmSearchKO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call genCbo()
        Call GenCboInGrid()
        If oConfig.IsNull(_ProductionOrderTypeId, 0) > 0 Then
            cboProdType.SelectedValue = _ProductionOrderTypeId
        End If
        Call GenGrid()

    End Sub

    Private Sub grdData_DoubleClick(sender As Object, e As System.EventArgs) Handles grdData.DoubleClick
        Call Getdata()
        ' If grdData.Rows.Count > 0 Then strKONo = grdData.CurrentRow.Cells("kono").Value
        ' Me.Hide()
    End Sub


    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        blnOk = False
        Me.Close()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        Call Getdata()
    End Sub

    Private Sub Getdata()
        If grdData.Rows.Count > 0 Then
            strKONo = grdData.CurrentRow.Cells("kono").Value
            int64ProductionOrderId = grdData.CurrentRow.Cells("ProductionOrderId").Value
            blnOk = True
        End If
        Me.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call GenGrid()
    End Sub

    Private Sub cboSup_DropDownClosed(sender As Object, e As EventArgs) Handles cboSup.DropDownClosed
        Call GenGrid()
    End Sub

    Private Sub txtDesignNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDesignNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub grdData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub
End Class