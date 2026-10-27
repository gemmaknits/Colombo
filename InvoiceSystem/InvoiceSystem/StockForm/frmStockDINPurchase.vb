Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class frmStockDINPurchase
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    'Dim clsStockG As New classStockG
    Dim clsStockDIN_POManual As New classStockDINPurchase

    Dim blnCancel As Boolean = False

    Dim StrDinno As String = ""
    Dim dt As DataTable
    Dim ds As DataSet
    Dim jobID As Long = 0

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub frmStockDINPurchase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call InitControl()

    End Sub



    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click

        Call InitControl()
    End Sub
    Private Sub InitControl()

        txtDINNo.Text = ""
        dtpDINDate.Value = Today

        txtPONo.Text = ""

        Call GenCombo()
        Call GenComboDINNo()
        ' Call GenCboSuppliers()
        Call GenSoNoInGridData()
        Call GenSoNoIDInGridData()

        grdPO.AutoGenerateColumns = False
        grdPO.DataSource = (New GetDataYarn).getJob("")

        ErrorProvider1.Clear()

        StrDinno = ""

        txtRemark.Text = ""
        txtPONo.Text = ""

        Call BindGrid(grdData, (New classStockDINPurchase).GetDINPurchase("0", clsUser.UserID))
        'txtDFNo.Text = ""
        txtPONo.Focus()
        'txtColNo.Focus()
    End Sub

    Private Sub GenCombo()
        col.DataSource = (New classMaster).GetColor()
        col.DisplayMember = "col"
        col.ValueMember = "col"

        cboSupplier.DataSource = (New classMaster).GetSupplier
        cboSupplier.DisplayMember = "name"
        cboSupplier.ValueMember = "suppcd"
        ' cboSupplier.SelectedIndex = 1

        cbomtl_warehouse.DataSource = (New classMaster).Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

        cbomtl_subinventory.DataSource = Nothing
        cbomtl_subinventory.SelectedIndex = -1
        cbomtl_Location.DataSource = Nothing
        cbomtl_Location.SelectedIndex = -1

    End Sub
    Private Sub SetFixFormattDate()
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-GB") ' United Kingdom
        'System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US") ' USA
        'System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("th-TH") ' Thai
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture


    End Sub

    Private Sub GenComboDINNo()
        Dim objDB As New classStockDINPurchase
        cboDinNo.ComboBox.DataSource = objDB.GetDINPurchaseNo()
        cboDinNo.ComboBox.DisplayMember = "dinno"
        cboDinNo.ComboBox.ValueMember = "dinno"

    End Sub
    Private Sub GenCboSuppliers()
        Dim objDB As New classStockDINPurchase
        dhcod.DataSource = objDB.GetSupplier
        dhcod.DisplayMember = "name"
        dhcod.ValueMember = "dhcod"
    End Sub
    Private Sub GenSoNoInGridData()
        Dim Objdb As New classStockDINPurchase

    End Sub
    Private Sub GenSoNoIDInGridData()
        Dim objDB As New classStockDINPurchase
        Dim config As New clsConfig


    End Sub
    Private Sub GenCboSoNoID()
        Dim objDB As New classStockDINPurchase
        Dim dt As DataTable = grdData.DataSource
        Dim i As Integer
        For i = 0 To grdData.RowCount + 1

        Next

    End Sub


    Private Sub GenGrdDataCboSoNo()
        Dim objDB As New classSalesOrder
        'Me.sono.DataSource = objDB.SOLoad(txtSoNo.Text.Trim.ToUpper, "", "", "")
        'Me.sono.DisplayMember = "sono"
        'Me.sono.ValueMember = "sono"
    End Sub

    Private Sub GenGrdDataCboSoNoID()
        Dim objDB As New classStockDINPurchase
        ' Me.sonoid.DataSource = objDB.GetSoNoId("", "", clsUser.UserID)
        'Me.sonoid.DisplayMember = "sonoid"
        'Me.sonoid.ValueMember = "sonoid"
    End Sub
    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt



        SumGrdData()
    End Sub

    'Private Sub BindDataText(ByVal dt As DataTable)
    '    Dim clsconfig As New clsConfig
    '    If dt.Rows.Count > 0 Then
    '        txtDINNo.Text = clsconfig.IsNull(dt.Rows(0)("dinno"), "")
    '        cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")

    '        cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
    '        cbomtl_Location.SelectedValue = dt.Rows(0)("mtl_location")
    '    Else
    '        txtDINNo.Text = ""

    '        cbomtl_warehouse.SelectedIndex = -1
    '        cbomtl_subinventory.SelectedIndex = -1
    '        cbomtl_Location.SelectedIndex = -1
    '    End If

    'End Sub
    Private Sub SumGrdData()

        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblMts As Double = 0
        Dim dblYds As Double = 0

        Dim netwt As Double = 0.0
        Dim anetwt As Double = 0.0
        Dim CartMts As Double = 0.0
        Dim CartYds As Double = 0.0
        Dim totalroll As Double = 0

        For j = 0 To grdData.Rows.Count - 1
            'grdData.Rows(i).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(i).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)
            grdData.Rows(j).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(j).Cells("mts").Value, 0) / 0.9144, 2, TriState.False, TriState.False, TriState.True)
        Next




        For i = 0 To grdData.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdData.Rows(i).Cells("kg").Value, 0)
            dblMts = dblMts + config.IsNull(grdData.Rows(i).Cells("mts").Value, 0)
            dblYds = dblYds + config.IsNull(grdData.Rows(i).Cells("yds").Value, 0)
        Next

        txtTotalRolls.Text = FormatNumber(grdData.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

    End Sub

    'Private Sub btnSearchColNo_Click(sender As System.Object, e As System.EventArgs)
    '    Dim frm As New frmSearchColNo
    '    frm.ShowDialog(Me)
    '    'txtColNo.Text = (frm.pColNo.Trim)
    '    Me.Cursor = Cursors.WaitCursor
    '    'If Not blnCancel Then GetColNo(txtColNo.Text)
    '    Me.Cursor = Cursors.Default
    '    frm.Dispose()

    '    Call GenGrdDataCboSoNo()
    'End Sub
    Private Function GetColNo(ByVal strColNo As String) As Boolean

        If strColNo = "" Then Exit Function
        Dim dt As DataTable = clsStockDIN_POManual.GetColItem(strColNo, clsUser.UserID)

        If dt.Rows.Count > 0 Then
            'Call BinddataDF(dt)
            Call BindDataColItem(dt)
            'Call BindDataText(dt)

            Return True
        End If
        Return False
    End Function
    Private Sub BindDataColItem(ByVal dt As DataTable)
        Dim config As New clsConfig
        'If txtColNo.Text = "" Then Exit Sub
        Dim k As Integer = 0

        grdData.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdData.DataSource

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1

                'If dt1.Rows(i)("dfno") = dt2.Rows(i)("dfno") Then Exit Sub

                dr = dt2.NewRow

                'For j = 0 To dt2.Columns.Count - 1
                dr("dinno") = dt1.Rows(i)("dinno")
                dr("dindt") = dt1.Rows(i)("dindt")
                dr("doctyp") = dt1.Rows(i)("doctyp")
                dr("dhcod") = dt1.Rows(i)("dhcod")
                dr("dhdono") = dt1.Rows(i)("dhdono")
                dr("dhdodt") = dt1.Rows(i)("dhdodt")
                dr("dfno") = dt1.Rows(i)("dfno")
                dr("dono") = dt1.Rows(i)("dono")
                dr("dodt") = dt1.Rows(i)("dodt")
                dr("design_no") = dt1.Rows(i)("design_no")
                dr("gwth") = dt1.Rows(i)("gwth")
                dr("fwth") = dt1.Rows(i)("fwth")
                dr("lot") = dt1.Rows(i)("lot")
                dr("yr") = dt1.Rows(i)("yr")
                dr("sh") = dt1.Rows(i)("sh")
                dr("col") = dt1.Rows(i)("col")
                dr("gr") = dt1.Rows(i)("gr")
                dr("mtkg") = dt1.Rows(i)("mtkg")
                dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
                dr("roll_no_g") = dt1.Rows(i)("roll_no_g")
                dr("kg") = dt1.Rows(i)("kg")
                dr("mts") = dt1.Rows(i)("mts")
                dr("yds") = dt1.Rows(i)("yds")
                dr("sono") = dt1.Rows(i)("sono")
                dr("nob") = dt1.Rows(i)("nob")
                dr("typ") = dt1.Rows(i)("typ")
                dr("status") = dt1.Rows(i)("status")
                dr("outreqno") = dt1.Rows(i)("outreqno")
                dr("outreqdt") = dt1.Rows(i)("outreqdt")
                dr("mts_g") = dt1.Rows(i)("mts_g")
                dr("yds_g") = dt1.Rows(i)("yds_g")
                dr("allowmt") = dt1.Rows(i)("allowmt")
                dr("sonoid") = dt1.Rows(i)("sonoid")
                dr("lotbatno") = dt1.Rows(i)("lotbatno")
                dr("sel") = dt1.Rows(i)("sel")
                dr("loc") = dt1.Rows(i)("loc")
                dr("cost") = dt1.Rows(i)("cost")
                dr("batch") = dt1.Rows(i)("batch")
                dr("custcolor") = dt1.Rows(i)("custcolor")
                dr("fload") = dt1.Rows(i)("fload")
                dr("dinno1") = dt1.Rows(i)("dinno1")
                dr("dinnot") = dt1.Rows(i)("dinnot")
                dr("cost_d") = dt1.Rows(i)("cost_d")
                dr("unit") = dt1.Rows(i)("unit")
                dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                dr("roll_no_p") = dt1.Rows(i)("roll_no_p")
                dr("roll_no_f") = dt1.Rows(i)("roll_no_f")
                dr("rem_qc") = dt1.Rows(i)("rem_qc")
                dr("job_line_id") = dt1.Rows(i)("job_line_id")
                dr("fabric_cost") = dt1.Rows(i)("fabric_cost")
                dr("process_cost") = dt1.Rows(i)("process_cost")
                dr("process_loss_perc") = dt1.Rows(i)("process_loss_perc")
                dr("other_cost") = dt1.Rows(i)("other_cost")
                dr("cost_per_unit") = dt1.Rows(i)("cost_per_unit")

                'Next
                dt2.Rows.Add(dr)


            Next


            'txtDINNo.Text = dt.Rows(0)("")
        End If

        SumGrdData()

        'Dim config As New clsConfig
        'Dim i As Integer = 0
        'Dim j As Integer = 0

        'grdData.AutoGenerateColumns = False
        'grdData.DataSource = dt

        'txtDFNo.Text = dt.Rows(0)("dfno").ToString.Trim()
        'txtBillNo.Text = dt.Rows(0)("dono").ToString.Trim()
        'txtLotNo.Text = dt.Rows(0)("lot").ToString()
        'txtRemark.Text = dt.Rows(0)("rem_qc").ToString()

    End Sub
    Private Sub cboDinNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDinNo.Click

    End Sub

    Private Sub cboDinNo_DragLeave(sender As Object, e As EventArgs) Handles cboDinNo.DragLeave

    End Sub

    Private Sub cboDinNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboDinNo.DropDownClosed
        If clsConfig.IsNull(cboDinNo.ComboBox.SelectedValue, "").ToString.Length = 0 Then Exit Sub
        Call getDINPurchase(clsConfig.IsNull(cboDinNo.ComboBox.SelectedValue, "").ToString)



    End Sub
    Function getDINPurchase(ByRef strDINNO As String) As Boolean

        Dim dt As DataTable = clsStockDIN_POManual.GetDINPurchase(strDINNO, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            'Dev By Neung 26/03/2015
            Call BindData(dt)
            'Call BindDataText(dt)

            Return True
        End If
        Return False

    End Function
    Private Sub BindData(ByVal dt As DataTable)
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt

        txtDINNo.Text = dt.Rows(0)("dinno").ToString.Trim()
        dtpDINDate.Value = CDate(dt.Rows(0)("dindt").ToString)

        txtPONo.Text = dt.Rows(0)("purno").ToString.Trim()

        cboSupplier.SelectedValue = dt.Rows(0)("suppcd").ToString.Trim()
        txtSuppInvNo.Text = dt.Rows(0)("sinvno").ToString.Trim()

        If (New clsConfig).IsNull(dt.Rows(0)("sinvdt"), CDate("01/01/1900")) = CDate("01/01/1900") Then
            dtpsinvdt.Value = CDate("01/01/1900")
            dtpsinvdt.Checked = False
        Else
            dtpsinvdt.Value = dt.Rows(0)("sinvdt")
            dtpsinvdt.Checked = True
        End If

        txtSuppLot.Text = dt.Rows(0)("lotno_sup").ToString.Trim
        txtSuppRefNo.Text = dt.Rows(0)("srefno").ToString.Trim

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                cbomtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
                Call GetComboNewSubInventory(Int64mtl_warehouse_id:=dt.Rows(0)("mtl_warehouse_id"))
                cbomtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
                Call GetComboLocation(Int64mtl_warehouse_id:=dt.Rows(0)("mtl_warehouse_id"), Int64mtl_subinventory_id:=dt.Rows(0)("mtl_subinventory_id"))
            End If
        End If

        txtRemark.Text = dt.Rows(0)("rem_qc")


        SumGrdData()

    End Sub

    Private Sub GetComboNewSubInventory(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.GetCombomtl_subinventory(cbomtl_warehouse.SelectedValue)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        'Dim clsconfig As New clsConfig
        'If clsconfig.IsNull(cbomtl_subinventory.SelectedValue, 0) = 0 Then SetDefaultSubInventory(cbomtl_subinventory.DataSource)

    End Sub

    Private Sub Setdefaultsubinventory(ByVal dt As DataTable)
        Dim expression As String
        expression = "subinventory_code like '%DYED%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)
        cbomtl_subinventory.SelectedValue = foundRows(0)("mtl_subinventory_id")
    End Sub

    Private Sub GetComboLocation(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster
        cbomtl_location.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        cbomtl_location.DisplayMember = "location_name"
        cbomtl_location.ValueMember = "mtl_locations_id"
        Dim clsconfig As New clsConfig
        'If clsconfig.IsNull(cbomtl_location.SelectedValue, 0) = 0 Then SetDefaultLocation(cbomtl_location.DataSource)
        'SetDefaultLocation(cbomtl_location.DataSource)
    End Sub

    Private Sub SetDefaultLocation(ByVal dt As DataTable)
        Dim expression As String
        expression = "location_name like '%N/A%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        cbomtl_Location.SelectedValue = foundRows(0)(0)

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Call SaveDinPurchaseBF()

    End Sub

    Private Sub SaveDinPurchaseBF()

        grdData.EndEdit(DataGridViewDataErrorContexts.Commit) 'Fix Bug User
        grdData.CurrentCell = grdData.Rows(0).Cells("lot") 'Fix Bug User

        If Not CheckData() Then Exit Sub

        blnCancel = False
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        Call SaveDINPurchase()
        'If SaveDINPurchase() Then
        '    Call GenComboDINNo()
        '    Call getDINPurchase(clsconfig.IsNull(StrDinno, ""))

        'End If

    End Sub

    Private Function CheckData() As Boolean
        If clsconfig.IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก WareHouse")
            ErrorProvider1.SetError(cbomtl_warehouse, "คุณยังไม่ไดเลือก WareHouse")
            CheckData = False
            Exit Function
        End If

        If Val(cbomtl_subinventory.SelectedValue) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Subinventory")
            ErrorProvider1.SetError(cbomtl_subinventory, "คุณยังไม่ได้เลือก Subinventory")
            CheckData = False
            Exit Function
        End If

        If clsconfig.IsNull(cbomtl_Location.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก Location")
            ErrorProvider1.SetError(cbomtl_Location, "คุณยังไม่ได้เลือก Locations")
            CheckData = False
            Exit Function
        End If

        CheckData = True
    End Function
    Private Function SaveDINPurchase() As Boolean



        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockDINPurchase
        Dim Din_header As New classStockDINPurchase.Strolls_DHeader
        Dim msgerr As String = ""
        Dim DINNo As String = StrDinno

        dt = grdData.DataSource

        Din_header.h01_dinno = Me.txtDINNo.Text.Trim
        Din_header.h02_dindt = Me.dtpDINDate.Value
        Din_header.h03_doctyp = config.IsNull(dt.Rows(0)("doctyp"), "P")
        Din_header.h04_dhcod = config.IsNull(dt.Rows(0)("dhcod"), Nothing)
        Din_header.h05_dhdono = config.IsNull(dt.Rows(0)("dhdono"), Nothing)
        Din_header.h06_dhdodt = config.IsNull(dt.Rows(0)("dhdodt"), Nothing)
        Din_header.h07_dfno = config.IsNull(dt.Rows(0)("dfno"), Nothing)
        Din_header.h08_dono = config.IsNull(dt.Rows.Item(0)("dono"), Nothing)
        Din_header.h09_dodt = config.IsNull(dt.Rows.Item(0)("dodt"), Nothing)
        Din_header.h10_design_no = config.IsNull(dt.Rows.Item(0)("design_no"), Nothing)
        Din_header.h11_Gwth = config.IsNull(dt.Rows.Item(0)("Gwth"), Nothing)
        Din_header.h12_fwth = config.IsNull(dt.Rows.Item(0)("fwth"), Nothing)
        Din_header.h13_lot = config.IsNull(dt.Rows.Item(0)("lot"), Nothing)
        Din_header.h14_yr = config.IsNull(dt.Rows.Item(0)("yr"), Nothing)
        Din_header.h15_sh = config.IsNull(dt.Rows.Item(0)("sh"), Nothing)
        Din_header.h16_col = config.IsNull(dt.Rows.Item(0)("col"), Nothing)
        Din_header.h17_Gr = config.IsNull(dt.Rows.Item(0)("Gr"), Nothing)
        Din_header.h18_mtkg = config.IsNull(dt.Rows.Item(0)("mtkg"), Nothing)
        Din_header.h19_roll_no_d = config.IsNull(dt.Rows.Item(0)("roll_no_d"), Nothing)
        Din_header.h20_roll_no_g = config.IsNull(dt.Rows.Item(0)("roll_no_g"), Nothing)
        Din_header.h21_kg = config.IsNull(dt.Rows.Item(0)("kg"), Nothing)
        Din_header.h22_mts = config.IsNull(dt.Rows.Item(0)("mts"), Nothing)
        Din_header.h23_yds = config.IsNull(dt.Rows.Item(0)("yds"), Nothing)
        Din_header.h24_sono = config.IsNull(dt.Rows.Item(0)("sono"), Nothing)
        Din_header.h25_nob = config.IsNull(dt.Rows.Item(0)("nob"), Nothing)
        Din_header.h26_typ = config.IsNull(dt.Rows.Item(0)("typ"), Nothing)
        Din_header.h27_status = config.IsNull(dt.Rows.Item(0)("status"), Nothing)
        Din_header.h28_outreqno = config.IsNull(dt.Rows.Item(0)("outreqno"), Nothing)
        Din_header.h29_outreqdt = config.IsNull(dt.Rows.Item(0)("outreqdt"), Nothing)
        Din_header.h30_mts_g = config.IsNull(dt.Rows.Item(0)("mts_g"), Nothing)
        Din_header.h31_yds_g = config.IsNull(dt.Rows.Item(0)("yds_g"), Nothing)
        Din_header.h32_allowmt = config.IsNull(dt.Rows.Item(0)("allowmt"), Nothing)
        Din_header.h33_sonoid = config.IsNull(dt.Rows.Item(0)("sonoid"), Nothing)
        Din_header.h34_lotbatno = config.IsNull(dt.Rows.Item(0)("lotbatno"), Nothing)
        Din_header.h35_sel = config.IsNull(dt.Rows.Item(0)("sel"), Nothing)
        Din_header.h36_loc = config.IsNull(dt.Rows.Item(0)("loc"), "NEW")
        Din_header.h37_cost = config.IsNull(dt.Rows.Item(0)("cost"), Nothing)
        Din_header.h38_batch = config.IsNull(dt.Rows.Item(0)("batch"), Nothing)
        Din_header.h39_custcolor = config.IsNull(dt.Rows.Item(0)("custcolor"), Nothing)
        Din_header.h40_fload = config.IsNull(dt.Rows.Item(0)("fload"), Nothing)
        'Din_header.h41_cancel = config.IsNull(dt.Rows.Item(0)("cancel"), Nothing)
        Din_header.h42_dinno1 = config.IsNull(dt.Rows.Item(0)("dinno1"), Nothing)
        Din_header.h43_dinnot = config.IsNull(dt.Rows.Item(0)("dinnot"), Nothing)
        Din_header.h44_cost_d = config.IsNull(dt.Rows.Item(0)("cost_d"), Nothing)
        Din_header.h45_unit = config.IsNull(dt.Rows.Item(0)("unit"), "K")
        Din_header.h46_roll_no_o = config.IsNull(dt.Rows.Item(0)("roll_no_o"), Nothing)
        Din_header.h47_roll_no_p = config.IsNull(dt.Rows.Item(0)("roll_no_p"), Nothing)
        Din_header.h48_roll_no_f = config.IsNull(dt.Rows.Item(0)("roll_no_f"), Nothing)
        Din_header.h49_rem_qc = config.IsNull(dt.Rows.Item(0)("rem_qc"), Nothing)
        Din_header.h50_job_line_id = config.IsNull(dt.Rows.Item(0)("job_line_id"), Nothing)
        Din_header.h51_fabric_cost = config.IsNull(dt.Rows.Item(0)("fabric_cost"), Nothing)
        Din_header.h52_process_cost = config.IsNull(dt.Rows.Item(0)("process_cost"), Nothing)
        Din_header.h53_process_loss_perc = config.IsNull(dt.Rows.Item(0)("process_loss_perc"), Nothing)
        Din_header.h54_other_cost = config.IsNull(dt.Rows.Item(0)("other_cost"), Nothing)
        Din_header.h55_cost_per_unit = config.IsNull(dt.Rows.Item(0)("cost_per_unit"), Nothing)

        Din_header.h56_mtl_warehouse_id = cbomtl_warehouse.SelectedValue
        Din_header.h57_mtl_subinventory_id = cbomtl_subinventory.SelectedValue
        Din_header.h58_mtl_locations_id = cbomtl_Location.SelectedValue


        'For i = 0 To grdData.Rows.Count - 1
        '    grdData.Rows(i).Cells("loc").Value = cbomtl_Location.SelectedText
        'Next

        Dim dtc As DataTable = grdData.DataSource

        For i = 0 To dtc.Rows.Count - 1
            If dtc.Rows(i).RowState = DataRowState.Added Or dtc.Rows(i).RowState = DataRowState.Modified Then
                dtc.Rows(i)("suppcd") = cboSupplier.SelectedValue
                dtc.Rows(i)("sinvno") = txtSuppInvNo.Text.Trim
                dtc.Rows(i)("sinvdt") = IIf(dtpsinvdt.Checked, dtpsinvdt.Value, DBNull.Value)
                dtc.Rows(i)("lotno_sup") = txtSuppLot.Text.Trim
                dtc.Rows(i)("srefno") = txtSuppRefNo.Text.Trim

                dtc.Rows(i)("mtl_warehouse_id") = cbomtl_warehouse.SelectedValue
                dtc.Rows(i)("mtl_subinventory_id") = cbomtl_subinventory.SelectedValue
                dtc.Rows(i)("mtl_locations_id") = cbomtl_Location.SelectedValue
                dtc.Rows(i)("loc") = cbomtl_Location.Text
                'grdData.Rows(i).Cells("mtl_warehouse_id").Value = cbomtl_warehouse.SelectedValue
                'grdData.Rows(i).Cells("mtl_subinventory_id").Value = cbomtl_subinventory.SelectedValue
                'grdData.Rows(i).Cells("mtl_locations_id").Value = cbomtl_Location.SelectedValue
                'grdData.Rows(i).Cells("loc").Value = cbomtl_Location.SelectedText

            End If
        Next

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        

        If objDB.DinPurchaseSave(Din_header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, DINNo) Then
            StrDinno = DINNo
            Call GenComboDINNo()
            Call GenCombo()
            Call getDINPurchase(clsConfig.IsNull(StrDinno, ""))

            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveDINPurchase = True

        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveDINPurchase = False
        End If




    End Function

    Private Sub txtColNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

            'Start ValidateCol 
            Dim col As String = ""
            ' col = txtColNo.Text
            If col = "" Then Exit Sub
            If Validate_Col(col) Then

                'GetColNo
                'If Not blnCancel Then GetColNo(txtColNo.Text)
            Else
                MessageBox.Show("Col. Item : " & col & "............   It's Not Valid!!")
                Exit Sub
            End If
            'End ValidateCol 


        End If
    End Sub

    Private Sub txtColNo_LostFocus(sender As Object, e As System.EventArgs)
        'Call Check_Col()

    End Sub

    Private Sub Check_Col()

        Dim col As String = ""
        'col = txtColNo.Text
        If col = "" Then Exit Sub
        If Not Validate_Col(col) Then
            MessageBox.Show("Col. Item : " & col & "............   It's Not Valid!!")
            Exit Sub
        End If

    End Sub
    Private Function Validate_Col(ByRef col As String) As Boolean
        Dim objdb As New classStockDINPurchase
        Dim dt As DataTable = objdb.ValidateCol(col, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            Return False

        End If
        Return True

    End Function


    Private Sub txtColNo_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Function GetCopyRoll() As Boolean

        Dim dtc As DataTable = grdData.DataSource

        'Dim strRollNoD As String = ""
        Dim strDinno As String = ""
        Dim strSonoid As String = ""
        Dim strDesign_no As String = ""
        Dim strGwth As String = ""
        Dim strFwth As String = ""
        Dim strcol As String = ""
        Dim strcustcolor As String = ""
        Dim strgr As String = ""
        Dim strRollNoO As String = ""
        Dim strkg As String = ""
        Dim strmts As String = ""
        Dim stryds As String = ""
        Dim strRollNoF As String = ""
        Dim strRollNoD As String = ""

        Dim newRow As DataRow
        If grdData.Rows.Count > 0 Then

            newRow = dtc.NewRow

            newRow.Item("dhcod") = grdData.CurrentRow.Cells("dhcod").Value
            newRow.Item("sonoid") = grdData.CurrentRow.Cells("sonoid").Value
            newRow.Item("Design_no") = grdData.CurrentRow.Cells("Design_no").Value
            newRow.Item("gwth") = grdData.CurrentRow.Cells("gwth").Value
            newRow.Item("fwth") = grdData.CurrentRow.Cells("fwth").Value
            newRow.Item("col") = grdData.CurrentRow.Cells("col").Value
            newRow.Item("custcolor") = grdData.CurrentRow.Cells("custcolor").Value
            newRow.Item("gr") = grdData.CurrentRow.Cells("gr").Value
            newRow.Item("roll_no_o") = grdData.CurrentRow.Cells("roll_no_o").Value
            newRow.Item("roll_no_d") = "NEW"
            newRow.Item("kg") = grdData.CurrentRow.Cells("kg").Value
            newRow.Item("mts") = grdData.CurrentRow.Cells("mts").Value
            newRow.Item("yds") = grdData.CurrentRow.Cells("yds").Value
            newRow.Item("roll_no_f") = grdData.CurrentRow.Cells("roll_no_f").Value

            dtc.Rows.Add(newRow)

            Return True
        End If

        Return False

    End Function
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        BFCancelDIN()
    End Sub
    Private Sub BFCancelDIN()
        If strDinno = "" Then strDinno = txtDINNo.Text.Trim.ToUpper
        If strDinno.Length = 0 Then Exit Sub
        If grdData.DataSource Is Nothing Then Exit Sub
        If grdData.DataSource Is Nothing Then Exit Sub
        If grdData.Rows.Count = 0 Then Exit Sub
        If grdData.Rows.Count = 0 Then Exit Sub


        If blnCancel Then Exit Sub

        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub


        If CancelDIN() Then
            MessageBox.Show("DIN NO." & vbCrLf & strDinno & "is Cancel", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Call InitControl()
            Call GenComboDINNo()
            'lblCancelled.Visible = True
        End If

    End Sub
    Private Function CancelDIN() As Boolean
        Dim confid As New clsConfig

        Dim obidb As New classStockD
        Dim DINHeader As New classStockD.Strolls_DHeader
        Dim msgerr As String = ""

        Dim DINNo As String = strDinno

        DINHeader.h01_dinno = Me.txtDINNo.Text.Trim
        DINHeader.h02_dindt = Me.dtpDINDate.Value
        DINHeader.h03_doctyp = "D"
        'Din_header.h04_dhcod = ""
        'Din_header.h05_dhdono = Me.txtBillNo.Text.Trim
        'Din_header.h06_dhdodt = Me.dtpdodt.Value
        'DINHeader.h07_dfno = Me.txtDFNo.Text.Trim
        'DINHeader.h08_dono = Me.txtBillNo.Text.Trim
        ' DINHeader.h09_dodt = dtpdodt.Value
        'Din_header.h10_design_no = ds.Tables("v_strolls_d").Rows(0).Item("design_no").ToString.Trim
        'DINHeader.h13_lot = txtLotNo.Text.Trim
        'Din_header.h14_yr = ""
        'Din_header.h15_sh = ""
        'Din_header.h16_col = ""
        'Din_header.h17_Gr = ""
        'Din_header.h18_mtkg = 0
        'Din_header.h19_roll_no_d


        Dim dtp As DataTable = grdData.DataSource
        'Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        'Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        If obidb.DINcancel(DINHeader, msgerr, dtp, clsUser.UserID) Then
            CancelDIN = True
        Else
            CancelDIN = False
        End If

    End Function
    Private Sub btncopy_Click(sender As System.Object, e As System.EventArgs) Handles btncopy.Click
        Call GetCopyRoll()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptDINManual.rpt"
        
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinno", txtDINNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Purchase Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmStockDINPurchase_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to close ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick

    End Sub

    Private Sub grdData_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit
        Dim obj As New classMaster
        Dim clsStockD As New classStockDINPurchase
        Dim config As New clsConfig
        Dim designNo As String
        'Dim SoNo As String = ""
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

        If grdData.Columns(e.ColumnIndex).Name = "design_no" Then
            designNo = grdData.Rows(e.RowIndex).Cells("design_no").Value
            grdData.Rows(e.RowIndex).Cells("Fwth").Value = obj.GetFWth(designNo)

            ' get article no. and show in grid
        End If

        'If grdData.Columns(e.ColumnIndex).Name = "sono" Then
        '    SoNo = grdData.Rows(e.RowIndex).Cells("sono").Value

        'End If


        CalGrdData()

    End Sub

    Private Sub grdData_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEnter

    End Sub

    Private Sub grdData_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellValueChanged


    End Sub
    Private Sub CalGrdDataYDS()

        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblMts As Double = 0
        Dim dblYds As Double = 0

        Dim netwt As Double = 0.0
        Dim anetwt As Double = 0.0
        Dim CartMts As Double = 0.0
        Dim CartYds As Double = 0.0
        Dim totalroll As Double = 0

        For j = 0 To grdData.Rows.Count - 1
            'grdData.Rows(i).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(i).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)
            grdData.Rows(j).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(j).Cells("mts").Value, 0) / 0.9144, 2, TriState.False, TriState.False, TriState.True)
        Next


        For i = 0 To grdData.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdData.Rows(i).Cells("kg").Value, 0)
            dblMts = dblMts + config.IsNull(grdData.Rows(i).Cells("mts").Value, 0)
            dblYds = dblYds + config.IsNull(grdData.Rows(i).Cells("yds").Value, 0)
        Next

        txtTotalRolls.Text = FormatNumber(grdData.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

    End Sub

    Private Sub CalGrdDataMTS()

        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblMts As Double = 0
        Dim dblYds As Double = 0

        Dim netwt As Double = 0.0
        Dim anetwt As Double = 0.0
        Dim CartMts As Double = 0.0
        Dim CartYds As Double = 0.0
        Dim totalroll As Double = 0

        For j = 0 To grdData.Rows.Count - 1
            'grdData.Rows(i).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(i).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)
            grdData.Rows(j).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(j).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)
        Next


        For i = 0 To grdData.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdData.Rows(i).Cells("kg").Value, 0)
            dblMts = dblMts + config.IsNull(grdData.Rows(i).Cells("mts").Value, 0)
            dblYds = dblYds + config.IsNull(grdData.Rows(i).Cells("yds").Value, 0)
        Next

        txtTotalRolls.Text = FormatNumber(grdData.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)

    End Sub

    Private Sub CalGrdData()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblMts As Double = 0
        Dim dblYds As Double = 0

        Dim netwt As Double = 0.0
        Dim anetwt As Double = 0.0
        Dim CartMts As Double = 0.0
        Dim CartYds As Double = 0.0
        Dim totalroll As Double = 0

        For i = 0 To grdData.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdData.Rows(i).Cells("kg").Value, 0)
            dblMts = dblMts + config.IsNull(grdData.Rows(i).Cells("mts").Value, 0)
            dblYds = dblYds + config.IsNull(grdData.Rows(i).Cells("yds").Value, 0)
        Next

        txtTotalRolls.Text = FormatNumber(grdData.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)
    End Sub

    Private Sub btnChangeLocation_Click(sender As System.Object, e As System.EventArgs)
        If txtDINNo.Text.Trim = "" Then Exit Sub

        Dim frm As New frmDyedTransfer
        frm.UserInfo = clsUser
        frm.p_dinno = txtDINNo.Text.Trim
        frm.ShowDialog(Me)
        'Call btnNew_Click(sender, e)
        Me.Cursor = Cursors.WaitCursor

        'If Not blnCancel Then LoadData(frm.pSoNo)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub


    Private Sub btnSearchOutNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutNo.Click
        Dim frm As New frmSearchPO
        frm.ShowDialog(Me)
        txtPONo.Text = frm.pPono
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadDataJOB(txtPONo.Text.Trim)
        'If Not blnCancel Then getPO(txtPONo.Text)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub


    Private Sub LoadDataJOB(ByVal jobno As String)
        Dim dt As DataTable
        Dim clsyarn As New GetDataYarn
        If txtPONo.Text = ("FREE SAMPLE") Or txtPONo.Text = ("FREE OF CHARGE") Then
            'grdYarnIN.Columns(1).ReadOnly = False
            dt = clsYarn.getJobFree(jobno)
        Else
            dt = clsYarn.getJob(jobno)
        End If

        If dt.Rows.Count > 0 Then
            grdPO.AutoGenerateColumns = False
            grdPO.DataSource = dt
            jobID = clsConfig.IsNull(dt.Rows(0).Item("id_jobdet"), 0)

            cboSupplier.SelectedValue = dt.Rows(0).Item("suppcd")

        End If

        'GridView1.Columns(3).Visible = True

    End Sub

    Private Sub txtPONo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPONo.KeyDown
        If e.KeyCode = Keys.Enter Then LoadDataJOB(txtPONo.Text.Trim)
    End Sub

    Private Sub txtPONo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPONo.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Call AddNewBox()
    End Sub


    Private Function AddNewBox() As Boolean
        If grdPO.Rows.Count = 0 Then
            Return False
            Exit Function
        End If
        If grdPO.CurrentRow.Cells("colID").Value Is DBNull.Value Then
            Return False
            Exit Function
        End If


        Dim dtc As New DataTable
        dtc = grdData.DataSource


        Dim newRow As DataRow
        Dim Int32id_jobdet As Nullable(Of Int32)
        Dim strItcd As String
        Dim strjob_line_id As String

        Int32id_jobdet = grdPO.CurrentRow.Cells("colID").Value
        strItcd = grdPO.CurrentRow.Cells("itcd").Value
        strjob_line_id = grdPO.CurrentRow.Cells("po_job_line_id").Value
        newRow = dtc.NewRow

        If grdPO.Rows.Count > 0 Then
            newRow.Item("job_line_id") = strjob_line_id
            newRow.Item("id_jobdet") = Int32id_jobdet
            newRow.Item("design_no") = strItcd

        End If


        dtc.Rows.Add(newRow)


        'SumGrid(grdYarnIN.DataSource)


    End Function

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue)
        Call Setdefaultsubinventory(cbomtl_subinventory.DataSource)
        Call GetComboLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue)
        Call SetDefaultLocation(cbomtl_Location.DataSource)
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue)
        Call SetDefaultLocation(cbomtl_Location.DataSource)
    End Sub

    Private Sub cbomtl_subinventory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub
End Class