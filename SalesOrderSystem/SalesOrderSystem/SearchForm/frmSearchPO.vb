Public Class frmSearchPO
    Dim clsuser As New classUserInfo
    Dim strPONo As String
    Dim blnok As Boolean = False

    Public Property pPono() As String
        Get
            pPONo = strPONo
        End Get
        Set(ByVal NewValue As String)
            strPONo = NewValue
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
        Dim objDB As New classSeachPO
        Dim dt As New DataTable
        Dim clsConfig As New clsConfig

        dt = objDB.GetGINPOManualSearchPO(strPONo, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), clsConfig.IsNull(cboSup.SelectedValue, "").ToString.Trim.ToUpper)

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub



    Private Sub frmSearchPO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call genCbo()
        Call GenCBOINGrid()
        Call GenGrid()

    End Sub

    Private Sub grdData_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        Call Getdata() 'If grdData.Rows.Count > 0 Then strPONo = grdData.CurrentRow.Cells("jobno").Value
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Call GenGrid()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        ' If grdData.Rows.Count > 0 Then strPONo = strPONo = grdData.CurrentRow.Cells("jobno").Value 'Convert.ToString(Me.grdData.SelectedRows)
        Call Getdata()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        blnok = False
        Me.Close()
    End Sub

    Private Sub txtPONO_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPONO.KeyPress
        If Keys.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    Private Sub Getdata()
        If grdData.Rows.Count > 0 Then
            strPONo = grdData.CurrentRow.Cells("jobno").Value
            blnok = True
        End If

        Me.Hide()
    End Sub

End Class