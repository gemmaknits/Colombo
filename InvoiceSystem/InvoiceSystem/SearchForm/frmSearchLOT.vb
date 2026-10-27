Public Class frmSearchLOT
    Dim StrLot As String
    Dim StrStockType As String = ""
    Dim strOutreqtyp As String = ""
    Dim clsconfig As New clsConfig

    Public Property pLOTNO As String
        Get
            pLOTNO = StrLot
        End Get
        Set(ByVal NewValue As String)
            StrLot = NewValue
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

    Private Sub frmSearchLOT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
        Call GenGrid()
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classSearchLOT
        Dim dt As New DataTable
        dt = objDB.SearchLOTNO(strStockType, txtDINNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim.ToUpper, clsConfig.IsNull(CboDoc_type.SelectedValue, strOutReqtyp))
        If dt.Rows.Count > 0 Then
            StrLot = dt.Rows(0)("lot")
        End If
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
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


    Private Sub grdReq_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        If grdData.Rows.Count > 0 Then StrLot = grdData.CurrentRow.Cells("lot").Value
        Me.Hide()
    End Sub

    Private Sub txtDINNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDINNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub


    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Call GenGrid()

    End Sub

    Private Sub btnRefresh2_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh2.Click
        Call GenGrid()
    End Sub
End Class