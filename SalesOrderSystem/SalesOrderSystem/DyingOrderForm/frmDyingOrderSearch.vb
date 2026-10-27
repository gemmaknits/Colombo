Public Class frmDyingOrderSearch
	Dim strDFNo As String = ""
    Dim clsuser As New classUserInfo 'Add By Neung 20151208
    Dim dts As New DataTable
    Dim bts As New BindingSource
    Public Property pDFNo() As String
		Get
			pDFNo = strDFNo
		End Get
		Set(ByVal NewValue As String)
			strDFNo = NewValue
		End Set
	End Property

    Public Property Userinfo() As classUserInfo 'Add By Neung 20151208
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property

    'Private Sub GenCombo()
    '	Dim objDB As New classMaster

    '	Me.cboCustomer.DataSource = objDB.GetCustomer
    '	Me.cboCustomer.DisplayMember = "name"
    '	Me.cboCustomer.ValueMember = "custcd"
    '	Me.cboCustomer.SelectedValue = ""

    '	Me.cboDesignNo.DataSource = objDB.GetDesign
    '	Me.cboDesignNo.DisplayMember = "design_no"
    '	Me.cboDesignNo.ValueMember = "design_no"
    '	Me.cboDesignNo.SelectedValue = ""

    '	Me.cboDyedHouse.DataSource = objDB.GetDyedHouse
    '	Me.cboDyedHouse.DisplayMember = "name"
    '	Me.cboDyedHouse.ValueMember = "suppcd2"
    '	Me.cboDyedHouse.SelectedValue = ""

    '	Me.cboSoNo.DataSource = objDB.GetSoNo
    '	Me.cboSoNo.DisplayMember = "sono2"
    '	Me.cboSoNo.ValueMember = "sono2"
    '	Me.cboSoNo.SelectedValue = ""

    '	Me.cboEmpCD.DataSource = objDB.GetEmp
    '	Me.cboEmpCD.DisplayMember = "empname"
    '	Me.cboEmpCD.ValueMember = "empcd2"
    '	Me.cboEmpCD.SelectedValue = ""
    'End Sub

    Private Sub GenGrid()
		Dim config As New clsConfig
        Dim objDB As New classSearchDFOrder
        'Dim dt As New DataTable
        'dt = objDB.SearchDFOrder(txtDFNo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), config.IsNull(cboSoNo.SelectedValue, "").ToString.Trim, config.IsNull(cboCustomer.SelectedValue, "").ToString.Trim, config.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim, config.IsNull(cboDesignNo.SelectedValue, "").ToString.Trim, config.IsNull(cboEmpCD.SelectedValue, "").ToString.Trim)
        dts = objDB.SearchDFOrder()
        If dts.Rows.Count > 0 Then
            strDFNo = dts.Rows(0)("DFNo")
        End If
        grdDF.AutoGenerateColumns = False
        grdDF.DataSource = dts

        Call Search(dtResult:=dts)
    End Sub

	Private Sub frmDyingOrderSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        'dtpDateTo.Value = Now
        'Call GenCombo()
        Call GenGrid()
	End Sub

	Private Sub frmDyingOrderSearch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		e.Cancel = True
		Me.Hide()
	End Sub

	Private Sub grdInv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDF.DoubleClick
		If grdDF.Rows.Count > 0 Then strDFNo = grdDF.CurrentRow.Cells("DFNo").Value
		Me.Hide()
	End Sub

	Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
		Call GenGrid()
	End Sub

	Private Sub btnRefresh2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh2.Click
		Call GenGrid()
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Hide()
	End Sub

    Private Sub dtpDateFr_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub cboDesignNo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub txtlookup_TextChanged(sender As Object, e As EventArgs) Handles txtlookup.TextChanged

    End Sub

    Private Sub txtlookup_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlookup.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Search(dtResult:=dts)
        End If
    End Sub

    Private Sub Search(ByVal dtResult As DataTable)
        Dim dvResult As DataView 'ตัวแปรเก็บผลลัพธ์
        Dim strFilter As String 'ตัวแปรเก็บเงื่อนไขค้นหา

        dvResult = New DataView(dtResult) 'นำข้อมูลจาก DataTable ที่ต้องการค้นหา มาไว้ใน DataView
        strFilter = "design_no like '%" & txtlookup.Text & "%'"
        strFilter &= " or design_no_fg like '%" & txtlookup.Text & "%'"
        strFilter &= " or sono like '%" & txtlookup.Text & "%'"
        strFilter &= " or custname like '%" & txtlookup.Text & "%'"
        strFilter &= " or dhname like '%" & txtlookup.Text & "%'"
        strFilter &= " or dfno like '%" & txtlookup.Text & "%'"
        strFilter &= " or dfdt2 like '%" & txtlookup.Text & "%'"
        strFilter &= " or empname like '%" & txtlookup.Text & "%'"
        strFilter &= " or outno like '%" & txtlookup.Text & "%'"
        dvResult.RowFilter = strFilter 'ค้นหา

        grdDF.DataSource = dvResult 'นำผลลัพธ์ที่ค้นหาคืนสู่ DataGridView
    End Sub
End Class