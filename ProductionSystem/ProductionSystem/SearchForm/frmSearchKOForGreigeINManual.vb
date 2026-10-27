Public Class frmSearchKOForGreigeINManual
    Dim clsuser As New classUserInfo
    Dim strKONo As String = ""

    Public Property pKono() As String
        Get
            pKono = strKONo
        End Get
        Set(ByVal NewValue As String)
            strKONo = NewValue
        End Set
    End Property

    Public Property UserInfo() As classUserInfo 'Add by Neung 20151208
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub genCbo()
        Dim objdb As New classMaster

        Me.cboSup.DataSource = objdb.GetSupplier
        Me.cboSup.DisplayMember = "name"
        Me.cboSup.ValueMember = "suppcd"
        Me.cboSup.SelectedValue = -1

    End Sub
    Private Sub GenCboInGrid()
        Dim objdb As New classMaster
        grd_cbosup.DataSource = objdb.GetSupplier
        grd_cbosup.DisplayMember = "name"
        grd_cbosup.ValueMember = "suppcd"
    End Sub

    Private Sub GenGrid()
        Dim objDB As New classStockGIN_KOManual
        Dim dt As New DataTable
        Dim clsConfig As New clsConfig
        'strKONo = txtKONo.Text.Trim.ToUpper
        dt = objDB.GetGINKOManualSearchKO(strKONo, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cboSup.SelectedValue, "").ToString.Trim.ToUpper, txtDesignNo.Text)
        If dt.Rows.Count > 0 Then
            strKONo = dt.Rows(0)("kono")
        End If
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub frmSearchKO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call genCbo()
        Call GenCboInGrid()
        Call GenGrid()

    End Sub

    Private Sub grdData_DoubleClick(sender As Object, e As System.EventArgs) Handles grdData.DoubleClick
        If grdData.Rows.Count > 0 Then strKONo = grdData.CurrentRow.Cells("kono").Value
        Me.Hide()
    End Sub


    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        strKONo = ""
        Me.Hide()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If grdData.Rows.Count > 0 Then strKONo = grdData.CurrentRow.Cells("kono").Value
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


End Class