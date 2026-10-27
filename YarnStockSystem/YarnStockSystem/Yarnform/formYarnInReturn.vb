Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class formYarnInReturn
	Public formYarnIn
    'Public loginEmpcd
    Private Clsconfig As New clsConfig
    Private dsYarn_in_det As DataTable
    Private ds As New DataSet
    Private connStr As New classConnection
    Private saveItcd As String
    Dim currentSelectedItem As String
    Dim dtMtlWarehouse As New DataTable
    Dim bsMtlWarehouse As New BindingSource
    Dim dtMtlSubInventory As New DataTable
    Dim bsMtlSubInventory As New BindingSource
    Dim dtmtlLocations As New DataTable
    Dim bsMtlLocations As New BindingSource

    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property


    Private Sub formYarnInReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()
        InitObjRight()

        'dsYarn_in_det = createdatatable()
        'GetAllComboINGrid()
        'Me.grdYarnIN.AutoGenerateColumns = False
        ' GetAllComboINGrid()
        'insertcomboitemcode()
        'insertcomboCurrency()
        '		Me.DgYarn.Rows(0).Cells(0).Value = Me.txtitcd.Text
        'Me.DgYarn.DataSource = dsYarn_in_det

        'With Me.DgYarn
        '.Columns(0).DataPropertyName = "itcd"
        '.Columns(1).DataPropertyName = "docno"
        '.Columns(2).DataPropertyName = "grade"
        '.Columns(3).DataPropertyName = "boxno_s"
        '.Columns(4).DataPropertyName = "boxno"
        '.Columns(5).DataPropertyName = "spools"
        '.Columns(6).DataPropertyName = "kg_gr"
        '.Columns(7).DataPropertyName = "cart_tearwt"
        '.Columns(8).DataPropertyName = "kg_nt"
        '.Columns(9).DataPropertyName = "spools"
        '.Columns(10).DataPropertyName = "kg_gr"
        '.Columns(11).DataPropertyName = "cart_tearwt"
        '.Columns(12).DataPropertyName = "kg_nt"

        'End With

    End Sub
    Private Sub InitControl()
        Me.DgYarn.AutoGenerateColumns = False
        Call GetComBo()
        'insertcomboitemcode()
        ' insertcomboCurrency()
    End Sub
    Private Sub InitObjRight()
        If clsUser.UserID = "STOCK" Then
            txtJobno.ReadOnly = True
            txtJobno.BackColor = Color.LightGray
            txtKono.ReadOnly = True
            txtKono.BackColor = Color.LightGray
            txtDesignNo.ReadOnly = True
            txtDesignNo.BackColor = Color.LightGray
            cboYarnCode.Enabled = False
            btnChangeYarnCode.Enabled = False

            'btnSelectAll.Enabled = False 'Sitthana 20190903 Wait changed back
            btnSelectAll.Enabled = True 'Sitthana 20190903
            'btnClear.Enabled = False 'Sitthana 20190903 Wait changed back
            btnClear.Enabled = True 'Sitthana 20190903 Wait changed back

            txtSupp.ReadOnly = True
            'grpDocument.Enabled = False 'Sitthana 20190903 Wait changed back
            grpDocument.Enabled = True
            cbomtlWarehouse.Enabled = False
            cbomtlSubinventory.Enabled = False

            With DgYarn
                .Columns("cboitcd").ReadOnly = True
                .Columns("cboitcd").DefaultCellStyle.BackColor = Color.LightGray
                .Columns("Grade").ReadOnly = True
                .Columns("Grade").DefaultCellStyle.BackColor = Color.LightGray
                .Columns("boxno_s").ReadOnly = True
                .Columns("boxno_s").DefaultCellStyle.BackColor = Color.LightGray
                .Columns("boxno").ReadOnly = True
                .Columns("boxno").DefaultCellStyle.BackColor = Color.LightGray
                'Sitthana comment 20190903 temp after K.jiew come back , set back again
                '.Columns("spools").ReadOnly = True
                '.Columns("spools").DefaultCellStyle.BackColor = Color.LightGray
            End With
        End If
    End Sub
    Private Sub GetComBo()

        Dim objdb As New classMaster
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        tblItems.itcd = ""
        ds = getDatayarn.GetDataItem(tblItems)
        If Not IsNothing(ds) Then
            Me.cboitcd.DataSource = ds.Tables(0)
            Me.cboitcd.DisplayMember = "itdesc4"
            Me.cboitcd.ValueMember = "Itcd"

            Me.cboYarnCode.DataSource = ds.Tables(0)
            Me.cboYarnCode.DisplayMember = "itcd"
            Me.cboYarnCode.ValueMember = "itcd"
        End If

        'Dim tblItems As New tbl_Items
        'Dim getDatayarn As New GetDataYarn
        'Dim ds As New DataSet
        'ds = getDatayarn.GetDataCurrency()
        'If Not IsNothing(ds) Then
        'End If
        dtMtlWarehouse = (New classYarnInReturn).Combomtlwarehouse()
        bsMtlWarehouse.DataSource = dtMtlWarehouse
        cbomtlWarehouse.DataSource = bsMtlWarehouse.DataSource
        cbomtlWarehouse.DisplayMember = "warehouse_code"
        cbomtlWarehouse.ValueMember = "mtl_warehouse_id"

        dtMtlSubInventory = (New classYarnInReturn).ComboMtlsubinventory(0)
        bsMtlSubInventory.DataSource = dtMtlSubInventory
        cbomtlSubinventory.DataSource = bsMtlSubInventory.DataSource
        cbomtlSubinventory.DisplayMember = "subinventory_code"
        cbomtlSubinventory.ValueMember = "mtl_subinventory_id"

        dtmtlLocations = (New classYarnInReturn).Combomtllocations(INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        bsMtlLocations.DataSource = dtmtlLocations
        cbomtlLocations.DataSource = bsMtlLocations.DataSource
        cbomtlLocations.DisplayMember = "location_name"
        cbomtlLocations.ValueMember = "mtl_locations_id"


        'Call GetComboWarehouseinGrid()
        ' Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)
        ' Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=0, _
        '                                Int64mtl_subinventory_id:=0)
        'Call GetComboGradeOur()
        'dt = classYarnIn.GetDataGradeOUR()

        'Dim cbograde_ourColumn As New DataGridViewComboBoxColumn
        'cbograde_ourColumn = cbograde_our

        'cbograde_our.DataSource = (New classYarnIn).GetDataGradeOUR()
        'cbograde_our.DisplayMember = "grade_code"
        'cbograde_our.ValueMember = "grade_code"
        'Dim clsGetDatYarn As New GetDataYarn

        'Call GetComboWarehouseinGrid()
        ' Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=clsGetDatYarn.GetDefaultWareHouse(clsUser.UserID))
        'Call GetCombomtl_locationInGrid(4, 11)
    End Sub

    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster
        mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        mtl_warehouse_id.DisplayMember = "warehouse_name"
        mtl_warehouse_id.ValueMember = "mtl_warehouse_id"
    End Sub

    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster
        mtl_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        mtl_subinventory_id.DisplayMember = "subinventory_name"
        mtl_subinventory_id.ValueMember = "mtl_subinventory_id"
    End Sub

    Private Sub GetCombomtl_locationInGrid(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster
        mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        mtl_locations_id.DisplayMember = "location_name"
        mtl_locations_id.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub insertcomboCurrency()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        ds = getDatayarn.GetDataCurrency()
        If Not IsNothing(ds) Then
        End If
    End Sub


    Private Sub txtPO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tblPur As New tbl_Pur
        Dim arr_tblPurPur As New tbl_Pur
        Dim msgerr As String = ""
        Dim getDatayarn As New GetDataYarn
        Dim objarr_tblPur() As tbl_Pur
        Dim ds As New DataSet
        Dim objsupp As New GetDataYarn
        'Dim arr_tblPur() As Tbl_Pur
        Try
            objarr_tblPur = getDatayarn.checkPurno(arr_tblPurPur, msgerr)
            If Not IsNothing(objarr_tblPur) Then
            ElseIf IsNothing(objarr_tblPur) Then
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub insertcomboitemcode()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        tblItems.itcd = ""
        ds = getDatayarn.GetDataItem(tblItems)
        If Not IsNothing(ds) Then
            Me.cboitcd.DataSource = ds.Tables(0)
            Me.cboitcd.DisplayMember = "itdesc4"
            Me.cboitcd.ValueMember = "Itcd"

            Me.cboYarnCode.DataSource = ds.Tables(0)
            Me.cboYarnCode.DisplayMember = "itcd"
            Me.cboYarnCode.ValueMember = "itcd"
        End If
    End Sub

    Private Sub BtnYarnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnSave.Click
        Me.Validate()
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call InsertDataReturn()

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to start a new record?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If result <> DialogResult.Yes Then Exit Sub

        If DgYarn.DataSource IsNot Nothing Then
            DgYarn.DataSource = Nothing
        Else
            For i As Integer = DgYarn.Rows.Count - 1 To 0 Step -1
                If Not DgYarn.Rows(i).IsNewRow Then
                    DgYarn.Rows.RemoveAt(i)
                End If
            Next
        End If

        ds = New DataSet()
        txtDocno.Clear()
        txtyarn_out_no.Clear()
        txt_tran_type.Clear()
        txtJobno.Clear()
        txtKono.Clear()
        txtDesignNo.Clear()
        txtSupp.Clear()
        txtremark.Clear()
        txttotalgross.Text = "0"
        txttotalnet.Text = "0"
        txttotalboxes.Text = "0"
        txtTotalSpools.Text = "0"
        txtTotItemGW.Text = "0"
        txtTotItemNW.Text = "0"
        txtTotItemBox.Text = "0"
        txtTotItemSpools.Text = "0"
        dtpSinvdt.Checked = False
        DateYIN.Value = Date.Today
        ErrorProvider1.Clear()
        BtnYarnSave.Enabled = True
        txtyarn_out_no.Focus()
    End Sub


    Private Function CheckData() As Boolean

        If Not txtDocno.Text.Trim = "" Then
            MsgBox("Yarn-in-return is Already !!" & vbCrLf & "คุณทำ Yarn-In-return ไปแล้ว")
            ErrorProvider1.SetError(txtDocno, "คุณทำ Yarn-In-return ไปแล้ว")
            Return False
        End If
        '--============= Check Combo Box ============================
        If Clsconfig.IsNull(cbomtlWarehouse.SelectedValue, 0) = 0 Then
            MsgBox("WareHouse is incorrect, please select" & vbCrLf & "ต้องเลือก W/H ด้วยครับ")
            ErrorProvider1.SetError(cbomtlWarehouse, "ต้องเลือก W/H ด้วยครับ")
            Return False
        End If
        If Clsconfig.IsNull(cbomtlSubinventory.SelectedValue, 0) = 0 Then
            MsgBox("SubInventory is incorrect, please select" & vbCrLf & "ต้องเลือก Subinventory ด้วยครับ")
            ErrorProvider1.SetError(cbomtlSubinventory, "ต้องเลือก Sub Inventory ด้วยครับ")
            Return False
        End If
        If Clsconfig.IsNull(cbomtlLocations.SelectedValue, 0) = 0 Then
            MsgBox("Locations is incorrect, please select" & vbCrLf & "ต้องเลือก Locations ด้วยครับ (แนะนำให้เลือก N/A)")
            ErrorProvider1.SetError(cbomtlLocations, "ต้องเลือก Locations ด้วยครับ ((แนะนำให้เลือก N/A)")
            Return False
        End If

        '============= Check Slect row > 1 ===========================
        Dim i As Integer = 0
        For Each row As DataGridViewRow In DgYarn.Rows
            Dim chk As DataGridViewCheckBoxCell = row.Cells("DGV_select")
            If row.Cells("DGV_select").Value = True Then
                i = i + 1
            End If
        Next
        If i = 0 Then
            MsgBox("Must be select one box or more then")
            Return False
        End If

        If Me.txtyarn_out_no.Text = "" Then
            MsgBox("กรุณาระบุหมายเลข out no :", MsgBoxStyle.Information, "Pls Enter data out no")
            Return False
        End If

        If Not CheckActualConeWeight() Then MessageBox.Show("ถ้าไม่ได้ใส่ Actual Cone Weight โปรแกรมจะดึงข้อมูลจาก Net weight หารด้วย Spool ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'For i = 0 To Me.DgYarn.Rows.Count - 2 'DGV_select
        '    If Me.DgYarn.Rows(i).Cells("DGV_select").Value = True Then
        '        Return True
        '    End If
        'Next

        Return True
    End Function

    Private Sub InsertData()
        Dim InsertYarn As New InsertYarn
        Dim tblYarnin As New tbl_Yarn_in
        Dim i As Integer
        Dim Isvalid As Boolean
        Try
            'Insert tbl_Yarn_in
            tblYarnin.docdt = Me.DateYIN.Value.ToString("yyy/MM/dd")  'As string
            tblYarnin.tstamp = Clsconfig.ConvertFormatDateTostring(Today.Date) 'string
            'tblYarnin.tran_type = "" 'Integer
            tblYarnin.docapp = 1 'Boolean 1 or 0
            tblYarnin.cancel = 1 'Boolean 1 or 0
            'tblYarnin.outno = "" 'Integer
            tblYarnin.remark = Me.txtremark.Text.ToString.Trim  'Integer

            '///////////////////
            ' Insert tbl_Yarn_in_det
            For i = 0 To Me.DgYarn.Rows.Count - 2
                ReDim Preserve tblYarnin.tbl_Yarn_in_det(i)
                tblYarnin.tbl_Yarn_in_det(i) = New tbl_Yarn_in_det

                tblYarnin.tbl_Yarn_in_det(i).itcd = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("cboitcd").Value.ToString)
                tblYarnin.tbl_Yarn_in_det(i).grade = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells(2).Value.ToString)
                tblYarnin.tbl_Yarn_in_det(i).boxno_s = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells(3).Value.ToString)
                tblYarnin.tbl_Yarn_in_det(i).boxno = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells(4).Value.ToString).PadLeft(4, "0")
                tblYarnin.tbl_Yarn_in_det(i).spools = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells(5).Value)
                tblYarnin.tbl_Yarn_in_det(i).kg_gr = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells(6).Value)
                tblYarnin.tbl_Yarn_in_det(i).cart_tearwt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells(7).Value)
                tblYarnin.tbl_Yarn_in_det(i).kg_nt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells(8).Value)


                tblYarnin.tbl_Yarn_in_det(i).docno = 0 'Me.DgYarn.Rows(i).Cells("docno").Value.ToString
                tblYarnin.tbl_Yarn_in_det(i).boxno_o = 0 ' Me.DgYarn.Rows(i).Cells("boxno_o").Value.ToString
                tblYarnin.tbl_Yarn_in_det(i).spool_tearwt = 0 ' Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("spool_tearwt").Value)
                tblYarnin.tbl_Yarn_in_det(i).price = 0 'Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("price").Value)
                tblYarnin.tbl_Yarn_in_det(i).location = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("txtlocation").Value.ToString)
                tblYarnin.tbl_Yarn_in_det(i).box_remark = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("box_remark").Value.ToString)
                tblYarnin.tbl_Yarn_in_det(i).tstamp = Clsconfig.ConvertFormatDateTostring(Clsconfig.IsValidDate(Today.Date)) 'Clsconfig.ConvertFormatDateTostring(Clsconfig.IsValidDate(Me.DgYarn.Rows(i).Cells("tstamp").Value))

            Next
            Dim msgerr As String = ""
            Dim purno As String = ""
            Isvalid = InsertYarn.InsertYarnIn(tblYarnin, msgerr, purno, "")
            Dim a As String
            a = Me.txttotalnet.Text
            If Isvalid = True Then
                Me.txtDocno.Text = tblYarnin.docno
                MsgBox("Success")
            Else
                MsgBox(msgerr)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub InsertDataReturn()

        Dim config As New clsConfig
        config.ChangeCulture()

        Dim InsertYarn As New InsertYarn
        Dim tblYarnin As New tbl_Yarn_in
        'Dim i As Integer
        'Dim Isvalid As Boolean
        'Insert tbl_Yarn_in
        tblYarnin.docno = txtDocno.Text.Trim
        tblYarnin.docdt = Me.DateYIN.Value
        tblYarnin.outno = Me.txtyarn_out_no.Text.Trim  'Integer
        tblYarnin.tran_type = "RETURN" 'Integer
        tblYarnin.suppcd = ds.Tables("v_YarnInReturn").Rows(0).Item("suppcd").ToString.Trim
        tblYarnin.srefno = ds.Tables("v_YarnInReturn").Rows(0).Item("srefno").ToString.Trim
        tblYarnin.purno = ds.Tables("v_YarnInReturn").Rows(0).Item("purno").ToString.Trim
        tblYarnin.sinvno = ds.Tables("v_YarnInReturn").Rows(0).Item("sinvno").ToString.Trim

        If dtpSinvdt.Checked Then
            tblYarnin.sinvdt = dtpSinvdt.Value.ToString("dd/MM/yyyy")
        Else
            tblYarnin.sinvdt = Nothing
        End If

        tblYarnin.jobno = ds.Tables("v_YarnInReturn").Rows(0).Item("jobno").ToString.Trim
        tblYarnin.curr = ds.Tables("v_YarnInReturn").Rows(0).Item("curr").ToString.Trim
        If ds.Tables("v_YarnInReturn").Rows(0).Item("exrt").ToString.Trim & "" <> "" Then
            tblYarnin.exrt = ds.Tables("v_YarnInReturn").Rows(0).Item("exrt").ToString.Trim
        Else
            tblYarnin.exrt = 0
        End If
        If ds.Tables("v_YarnInReturn").Rows(0).Item("vat").ToString.Trim & "" <> "" Then
            tblYarnin.vat = ds.Tables("v_YarnInReturn").Rows(0).Item("vat").ToString.Trim
        Else
            tblYarnin.vat = 0
        End If
        If ds.Tables("v_YarnInReturn").Rows(0).Item("vatamt").ToString.Trim & "" <> "" Then
            tblYarnin.vatamt = ds.Tables("v_YarnInReturn").Rows(0).Item("vatamt").ToString.Trim
        Else
            tblYarnin.vatamt = 0
        End If
        If ds.Tables("v_YarnInReturn").Rows(0).Item("taxper").ToString.Trim & "" <> "" Then
            tblYarnin.taxper = ds.Tables("v_YarnInReturn").Rows(0).Item("taxper").ToString.Trim
        Else
            tblYarnin.taxper = 0
        End If
        If ds.Tables("v_YarnInReturn").Rows(0).Item("taxamt").ToString.Trim & "" <> "" Then
            tblYarnin.taxamt = ds.Tables("v_YarnInReturn").Rows(0).Item("taxamt").ToString.Trim
        Else
            tblYarnin.taxamt = 0
        End If
        If ds.Tables("v_YarnInReturn").Rows(0).Item("freight").ToString.Trim & "" <> "" Then
            tblYarnin.freight = ds.Tables("v_YarnInReturn").Rows(0).Item("freight").ToString.Trim
        Else
            tblYarnin.freight = 0
        End If
        If ds.Tables("v_YarnInReturn").Rows(0).Item("insurance").ToString.Trim & "" <> "" Then
            tblYarnin.insurance = ds.Tables("v_YarnInReturn").Rows(0).Item("insurance").ToString.Trim
        Else
            tblYarnin.insurance = 0
        End If
        If ds.Tables("v_YarnInReturn").Rows(0).Item("otheramt").ToString.Trim & "" <> "" Then
            tblYarnin.otheramt = ds.Tables("v_YarnInReturn").Rows(0).Item("otheramt").ToString.Trim
        Else
            tblYarnin.otheramt = 0
        End If
        tblYarnin.other_text = ds.Tables("v_YarnInReturn").Rows(0).Item("other_text").ToString.Trim
        If ds.Tables("v_YarnInReturn").Rows(0).Item("discamt").ToString.Trim & "" <> "" Then
            tblYarnin.discamt = ds.Tables("v_YarnInReturn").Rows(0).Item("discamt").ToString.Trim
        Else
            tblYarnin.discamt = 0
        End If
        If ds.Tables("v_YarnInReturn").Rows(0).Item("totamt").ToString.Trim & "" <> "" Then
            tblYarnin.totamt = ds.Tables("v_YarnInReturn").Rows(0).Item("totamt").ToString.Trim
        Else
            tblYarnin.totamt = 0
        End If
        tblYarnin.sinvno = Clsconfig.IsNull(txtSupp.Text.Trim, "") 'add by Neung 21/07/2015 (Eschler Needs them)
        'Sitthana 24/04/2018
        If dtpSinvdt.Checked Then
            tblYarnin.sinvdt = dtpSinvdt.Value
        Else
            tblYarnin.sinvdt = Nothing
        End If

        tblYarnin.lotno_sup = ds.Tables("v_YarnInReturn").Rows(0).Item("lotno_sup").ToString.Trim
        tblYarnin.lotno_our = ds.Tables("v_YarnInReturn").Rows(0).Item("lotno_our").ToString.Trim
        tblYarnin.docapp = 0 'Boolean 1 or 0
        tblYarnin.cancel = 0 'Boolean 1 or 0
        tblYarnin.remark = Me.txtremark.Text.ToString.Trim  'Integer
        tblYarnin.tstamp = Clsconfig.ConvertFormatDateTostring(Today.Date) 'string

        '///////////////////
        ' Insert tbl_Yarn_in_det

        Dim tran_no As Integer
        tran_no = 0
        For i = 0 To Me.DgYarn.Rows.Count - 2 'DGV_select
            If Me.DgYarn.Rows(i).Cells("DGV_select").Value = True Then
                ReDim Preserve tblYarnin.tbl_Yarn_in_det(tran_no)
                tblYarnin.tbl_Yarn_in_det(tran_no) = New tbl_Yarn_in_det
                If Clsconfig.IsValidBoolean(Me.DgYarn.Rows(i).Cells("colUsed").Value) = True Then
                    tblYarnin.tbl_Yarn_in_det(tran_no).Used = 1
                Else
                    tblYarnin.tbl_Yarn_in_det(tran_no).Used = 0
                End If
                tblYarnin.tbl_Yarn_in_det(tran_no).itcd = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("cboitcd").Value.ToString)
                tblYarnin.tbl_Yarn_in_det(tran_no).grade = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("Grade").Value.ToString)
                tblYarnin.tbl_Yarn_in_det(tran_no).boxno = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("boxno").Value.ToString).PadLeft(4, "0")
                tblYarnin.tbl_Yarn_in_det(tran_no).boxno_o = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("boxno").Value) '.ToString).PadLeft(4, "0") ' Me.DgYarn.Rows(i).Cells("boxno_o").Value.ToString
                tblYarnin.tbl_Yarn_in_det(tran_no).spools = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("spools").Value)
                tblYarnin.tbl_Yarn_in_det(tran_no).kg_gr = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_gr").Value)
                tblYarnin.tbl_Yarn_in_det(tran_no).cart_tearwt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_gr2").Value)
                tblYarnin.tbl_Yarn_in_det(tran_no).kg_nt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_nt").Value)
                tblYarnin.tbl_Yarn_in_det(tran_no).actual_cone_weight = Clsconfig.IsValidDecimal(Me.DgYarn.Rows(i).Cells("actual_cone_weight").Value)
                tblYarnin.tbl_Yarn_in_det(tran_no).boxno_s = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("boxno_s").Value.ToString)
                tblYarnin.tbl_Yarn_in_det(tran_no).tstamp = Clsconfig.ConvertFormatDateTostring(Clsconfig.IsValidDate(Today.Date)) 'Clsconfig.ConvertFormatDateTostring(Clsconfig.IsValidDate(Me.DgYarn.Rows(i).Cells("tstamp").Value))
                tblYarnin.tbl_Yarn_in_det(tran_no).location = cbomtlLocations.Text 'Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("txtlocation").Value.ToString)
                tblYarnin.tbl_Yarn_in_det(tran_no).box_remark = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("box_remark").Value.ToString) 'Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("box_remark").Value.ToString)
                tblYarnin.tbl_Yarn_in_det(tran_no).mtl_warehouse_id = cbomtlWarehouse.SelectedValue 'DgYarn.Rows(i).Cells("mtl_warehouse_id").Value
                tblYarnin.tbl_Yarn_in_det(tran_no).mtl_subinventory_id = cbomtlSubinventory.SelectedValue 'DgYarn.Rows(i).Cells("mtl_subinventory_id").Value
                tblYarnin.tbl_Yarn_in_det(tran_no).mtl_locations_id = cbomtlLocations.SelectedValue 'grdYarnIN.Rows(i).Cells("mtl_locations_id").Value
                tblYarnin.tbl_Yarn_in_det(tran_no).mfg_production_order_line_id = (New clsConfig).IsNull(Me.DgYarn.Rows(i).Cells("colMfgProductionOrderLineId").Value, Nothing)
                tblYarnin.tbl_Yarn_in_det(tran_no).id_yarn_out_det = (New clsConfig).IsNull(Me.DgYarn.Rows(i).Cells("colIdYarnOutDet").Value, Nothing)

                tran_no = tran_no + 1
            End If
        Next

        Dim msgerr As String = ""

        If InsertYarn.InsertYarnInReturn(tblYarnin, msgerr, clsUser.UserID) Then
            Me.txtDocno.Text = tblYarnin.docno
            MsgBox("Success")
        Else
            MsgBox(msgerr)
        End If

    End Sub

    Private Function CheckActualConeWeight() As Boolean
        Dim dt As DataTable = DgYarn.DataSource
        If DgYarn.Rows.Count > 1 Then
            For i = 0 To DgYarn.Rows.Count - 2
                If Clsconfig.IsNull(DgYarn.Rows(i).Cells("actual_cone_weight").Value, 0) = 0 Then
                    Return False
                    Exit Function
                End If
            Next
        End If
        Return True
    End Function


    Public Function DgYarn_validate_DGV_select() As Boolean
        For i = 0 To Me.DgYarn.Rows.Count - 2 'DGV_select
            If Me.DgYarn.Rows(i).Cells("DGV_select").Value = True Then
                Return True
                Exit Function
            Else
                Return False
            End If
        Next
    End Function

    Private Sub btnCopyCurRow_Click(sender As Object, e As EventArgs) Handles btnCopyCurRow.Click
        If DgYarn.DataSource Is Nothing Then Exit Sub

        Dim i As Integer = 0 ' e.RowIndex
        Dim copyItcd As String
        Dim copyBoxno As String
        Dim copyGrade As String
        Dim copyBoxno_s As String
        Dim newRow As DataRow
        'Dim copySpools As Integer
        'Dim copyBoxno_o As String
        'Dim copyKg_gr As Double
        'Dim copySpool_tearwt As Double
        'Dim copyCart_tearwt As Double
        'Dim copyKg_nt As Double

        i = DgYarn.CurrentRow.Index  'Sitthana 05/04/2018
        If i >= 0 Then
            copyItcd = DgYarn.Rows(i).Cells.Item("cboitcd").Value
            copyBoxno = DgYarn.Rows(i).Cells.Item("Boxno").Value
            copyGrade = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("Grade").Value.ToString)
            copyBoxno_s = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("boxno_s").Value.ToString)
            'copySpools = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("spools").Value)
            'copyKg_gr = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_gr").Value)
            'copyCart_tearwt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_gr2").Value)
            'copySpool_tearwt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("spool_tearwt").Value)
            'copyKg_nt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_nt").Value)
            'copyBoxno_s = Clsconfig.IsValidString(Me.grdYarnIN.Rows(i).Cells("boxno_s").Value.ToString)

            newRow = ds.Tables("v_YarnInReturn").NewRow
            newRow.Item("itcd") = copyItcd
            newRow.Item("boxno") = copyBoxno
            newRow.Item("boxno_s") = copyBoxno_s
            newRow.Item("grade") = copyGrade
            newRow.Item("Cart_tearwt") = 0 'Sitthana 05/04/2018  -> Set Default
            ds.Tables("v_YarnInReturn").Rows.Add(newRow)
        End If
    End Sub
    Private Sub DgYarn_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.CellDoubleClick


    End Sub
    Private Sub DgYarn_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.CellValidated
        Dim sumgross As Double
        Dim sumnet As Double
        Dim sumboxs As Integer
        Dim i As Integer
        'Dim currentRow As Integer
        'Dim currentCol As Integer
        Try
            Dim countGrid As Integer
            countGrid = Me.DgYarn.Rows.Count
            sumboxs = 0
            For i = 0 To Me.DgYarn.Rows.Count - 2
                Dim kg_gr As Double
                Dim kg_nt As Double
                If Me.DgYarn.Rows(i).Cells("DGV_select").Value = True Then
                    sumboxs = sumboxs + 1
                    If IsDBNull(Me.DgYarn.Rows(i).Cells("Kg_gr").Value) Then
                        kg_gr = 0
                    Else
                        kg_gr = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Kg_gr").Value)
                    End If

                    If IsDBNull(Me.DgYarn.Rows(i).Cells("Kg_nt").Value) Then
                        kg_nt = 0
                    Else
                        kg_nt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Kg_nt").Value)
                    End If
                    sumgross = sumgross + kg_gr
                    sumnet = sumnet + kg_nt
                End If
            Next
            Me.txttotalgross.Text = sumgross
            Me.txttotalnet.Text = sumnet
            txttotalboxes.Text = sumboxs
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DgYarn_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DgYarn.DefaultValuesNeeded
        e.Row.Cells("spools").Value = 0
        e.Row.Cells("Grade").Value = ""
        e.Row.Cells("boxno_s").Value = ""
        e.Row.Cells("boxno").Value = ""
        e.Row.Cells("kg_gr").Value = 0
        e.Row.Cells("kg_gr2").Value = 0
        e.Row.Cells("kg_nt").Value = 0
        e.Row.Cells("actual_cone_weight").Value = 0
        e.Row.Cells("cboItcd").Value = saveItcd


        '----------------- Inculde Default Warehouse And Inculde Subinventory 
        Dim objdb As New classMaster
        Dim dgvccrcv_warehouse_id As New DataGridViewComboBoxCell
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dgvccLocation As New DataGridViewComboBoxCell

        dgvccrcv_warehouse_id = e.Row.Cells("mtl_warehouse_id")
        dgvccSubInven = e.Row.Cells("mtl_subinventory_id")
        dgvccLocation = e.Row.Cells("mtl_locations_id")
        dgvccrcv_warehouse_id.Value = objdb.GetdefaultWarehouse(strUSerID:=clsUser.UserID)
        dgvccSubInven.DataSource = objdb.GetCombomtl_subinventory(e.Row.Cells("mtl_warehouse_id").Value)
        'dgvccSubInven.Value = objdb.Getdefaultmtlsubinventory(
        'dgvccLocation.DataSource = objdb.GetCombomtl_Locations(INt64mtl_warehouse_id:=dgvccrcv_warehouse_id.Value, Int64mtl_subinventory_id:=dgvccSubInven.Value, UserInfo:=clsUser)
        'dgvccLocation.Value = DBNull.Value
    End Sub

    Private Sub BtnYarnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnYarnPrintDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnPrintDoc.Click
        'Dim str As String
        'str = ""
        'ds.Clear()
        'str = "select * from v_yarn_in  " & _
        ' "where docno = '" & Me.lblYINno.Text & "'"

        'Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        'myda.Fill(ds, "TblDatayarnin")

        'Dim frmreport As New FormRptYarnIn
        'Dim rptFileName As String = "RptYarnIn.rpt"
        'Dim obj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'obj.Load(clsuser.reportpath & rptFileName)
        ''Dim obj As New RptYarnIn
        'obj.SetDataSource(ds.Tables("TblDatayarnin"))

        'frmreport.CrystalReportViewer1.ReportSource = obj

        'frmreport.ShowDialog()

        Dim clsConn As New classConnection
        Dim rptFileName As String = "RptYarnIn.rpt"
        Dim frm As New frmReport

        If Not Clsconfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtDocno.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4 '
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DgYarn_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DgYarn.RowsAdded
        'insertcomboitemcode()
    End Sub

    Private Sub DgYarn_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.RowValidated
        Dim currentRow As Integer
        currentRow = e.RowIndex
        saveItcd = Me.DgYarn.Rows(currentRow).Cells("cboItcd").Value
    End Sub

    Private Sub DgYarn_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DgYarn.UserAddedRow
        'Dim aa As String
        'aa = Me.DgYarn.Rows(0).Cells(0).Value.ToString()
        'e.Row.Cells(0).Value = Me.DgYarn.Rows(0).Cells(0).Value
    End Sub

    Private Sub cboitcd_Disposed(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Function chkErrbutUseYarnIn_table_havedata(ByVal strmsg As String) As Boolean
        If ds Is Nothing OrElse Not ds.Tables.Contains("v_YarnInReturn") Then
            Return False
        End If

        ds.Tables("v_YarnInReturn").Clear()
        Return True
    End Function

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        Dim i As Integer
        If Me.DgYarn.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        Try
            For i = 0 To Me.DgYarn.Rows.Count - 2
                If Me.DgYarn.Rows(i).Cells("DGV_select").Value = False Then Me.DgYarn.Rows(i).Cells("DGV_select").Value = True
            Next
        Catch ex As Exception

        End Try
        calculateTotal()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Dim i As Integer
        If Me.DgYarn.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        Try
            For i = 0 To Me.DgYarn.Rows.Count - 2
                Me.DgYarn.Rows(i).Cells("DGV_select").Value = False
            Next
            Me.txttotalgross.Text = 0
            Me.txttotalnet.Text = 0
            Me.txttotalboxes.Text = 0
        Catch ex As Exception

        End Try
        calculateTotal()
    End Sub
    Private Function conversTimeToString(ByVal timea As DateTime) As String
        Dim strdate As String = ""
        Dim strmonth As String = ""
        Dim stryear As String = ""
        Dim arrstr
        Dim arrstrconv
        Try
            arrstr = Split(timea.Date, "#", -1)
            arrstrconv = Split(arrstr(0).ToString.Trim, "/", -1)
            strdate = arrstrconv(0).ToString
            strmonth = arrstrconv(1).ToString
            stryear = arrstrconv(2).ToString
            If strdate <> "" And strmonth <> "" And stryear <> "" Then
                Return stryear & "-" & strmonth & "-" & strdate
            End If
        Catch ex As Exception
            Return "19000101"
        End Try
        Return "19000101"
    End Function

    Private Sub txtyarn_out_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtyarn_out_no.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Not CheckDataYarnOut() Then Exit Sub

            Call getYarnOutRecords()
        End If
    End Sub


    Private Sub getYarnOutRecords()
        Dim clsYarn As New GetDataYarn
        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        'Dim strsql2 As String
        Dim strmsg As String = ""

        ' If (New GetDataYarn).ValitateYarnOutAlreadyKOClosed(txtyarn_out_no.Text) Then
        'MessageBox.Show("ไม่สามารถ Return ได้ เนื่องจาก Production Order ถูก Closed ไปแล้ว", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
        'Exit Sub
        'End If

        Try
            'strsql2 = "select itcd,grade,boxno_s,boxno,spools,kg_gr,kg_nt,cart_tearwt,tran_type from v_yarn_out_return where outno = '" & Me.txtyarn_out_no.Text.Trim & "'"
            'strsql2 = "select * from v_yarn_out_return where outno = '" & Me.txtyarn_out_no.Text.Trim & "'"


            'Dim da As New SqlDataAdapter(strsql2.ToString, connStr.ConnectionString)
            'Dim ds As New DataSet


            If chkErrbutUseYarnIn_table_havedata(strmsg) = True Then
                ds.Tables("v_YarnInReturn").Clear()
            End If
            'da.Fill(ds, "v_YarnInReturn")
            ds = clsYarn.getYarnOut(txtyarn_out_no.Text.Trim)


            '==================================================================================           
            If ds.Tables("v_YarnInReturn").Rows.Count > 0 Then
                dsTable = ds.Tables("v_YarnInReturn")

                Me.DgYarn.AutoGenerateColumns = False
                Me.DgYarn.DataSource = dsTable

                Me.txt_tran_type.Text = ds.Tables("v_YarnInReturn").Rows(0).Item("tran_type").ToString.Trim

                Me.txtJobno.Text = ds.Tables("v_YarnInReturn").Rows(0).Item("RefDocNo").ToString.Trim
                Me.txtKono.Text = ds.Tables("v_YarnInReturn").Rows(0).Item("Kono").ToString.Trim
                Me.txtDesignNo.Text = ds.Tables("v_YarnInReturn").Rows(0).Item("Design_no").ToString.Trim

                'Add By Neung 21/07/2015 (Eschler needs them) sinvo and sinvdt
                Me.txtSupp.Text = ds.Tables("v_YarnInReturn").Rows(0).Item("sinvno").ToString.Trim

                'Begin : Sittana 20/04/2018
                If IsDate(ds.Tables("v_YarnInReturn").Rows(0).Item("sinvdt").ToString.Trim) Then
                    Me.dtpSinvdt.Value = ds.Tables("v_YarnInReturn").Rows(0).Item("sinvdt").ToString.Trim
                Else
                    dtpSinvdt.Checked = False
                End If
                'End  : Sittana 20/04/2018

                Me.cbomtlWarehouse.SelectedValue = ds.Tables("v_YarnInReturn").Rows(0).Item("mtl_warehouse_id")
                bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "'"
                Me.cbomtlSubinventory.SelectedValue = ds.Tables("v_YarnInReturn").Rows(0).Item("mtl_subinventory_id")
                bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"
                Me.cbomtlLocations.SelectedValue = ds.Tables("v_YarnInReturn").Rows(0).Item("mtl_locations_id")
            Else
                Me.DgYarn.DataSource = ""
                MsgBox("data not found kap pom !", MsgBoxStyle.Critical, "กรุณาตรวจสอบหมายเลข yarn_out no:")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnFindYarn_out_no_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindYarn_out_no.Click
        Dim selectedYarnOut As String
        Dim formSearchyarnOut As New formSearchYarnOut
        formSearchyarnOut.p_tran_type = ""
        selectedYarnOut = formSearchyarnOut.getYarnOutno
        If selectedYarnOut <> "" Then
            Me.txtyarn_out_no.Text = selectedYarnOut
        End If

        If Not CheckDataYarnOut() Then Exit Sub

        Call getYarnOutRecords()

        '-Begin Sitthana 20190905 Temp after k.jiew come back delete it
        If clsUser.UserID = "STOCK" Then
            If Me.txt_tran_type.Text.Trim = "KNITTING" Then
                BtnYarnSave.Enabled = False
            Else
                BtnYarnSave.Enabled = True
            End If
        End If
        '-End Sitthana 20190905 Temp after k.jiew come back delete it
    End Sub

    Private Function CheckDataYarnOut() As Boolean

        If (New classYarnInReturn).ValitateYarnOutAlreadyKOClosed(txtyarn_out_no.Text) Then
            MessageBox.Show("ไม่สามารถ Return ได้ เนื่องจาก Production Order ถูก Closed ไปแล้ว", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
            Return False
        End If

        Dim StrDocno As String = ""
        If (New classYarnInReturn).ValitateYarnOutAlreadyReturn(txtyarn_out_no.Text, StrDocno) Then
            MessageBox.Show("YO นี้เคยทำ Return ไปแล้ว No." + StrDocno, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
            'Return False
        End If


        Return True
    End Function

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub DgYarn_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.RowEnter
        currentSelectedItem = DgYarn.Rows(e.RowIndex).Cells("cboitcd").Value
        calculateItemTotal()
    End Sub
    Private Sub calculateTotal()
        Dim sumgross As Double
        Dim sumnet As Double
        Dim sumboxs As Integer
        Dim sumSpools As Integer
        Dim i As Integer
        Try
            Dim countGrid As Integer
            countGrid = Me.DgYarn.Rows.Count
            sumboxs = 0
            sumSpools = 0
            For i = 0 To Me.DgYarn.Rows.Count - 2
                Dim kg_gr As Double
                Dim kg_nt As Double
                Dim spools As Integer
                If Me.DgYarn.Rows(i).Cells("DGV_select").Value = True Then
                    sumboxs = sumboxs + 1
                    If IsDBNull(Me.DgYarn.Rows(i).Cells("Kg_gr").Value) Then
                        kg_gr = 0
                    Else
                        kg_gr = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Kg_gr").Value)
                    End If

                    If IsDBNull(Me.DgYarn.Rows(i).Cells("Kg_nt").Value) Then
                        kg_nt = 0
                    Else
                        kg_nt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Kg_nt").Value)
                    End If
                    If IsDBNull(Me.DgYarn.Rows(i).Cells("Spools").Value) Then
                        spools = 0
                    Else
                        spools = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Spools").Value)
                    End If
                    sumgross = sumgross + kg_gr
                    sumnet = sumnet + kg_nt
                    sumSpools = sumSpools + spools
                End If
            Next
            Me.txttotalgross.Text = sumgross
            Me.txttotalnet.Text = sumnet
            Me.txttotalboxes.Text = sumboxs
            Me.txtTotalSpools.Text = sumSpools
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub calculateItemTotal()
        Dim sumgross As Double
        Dim sumnet As Double
        Dim sumboxs As Integer
        Dim sumSpools As Integer
        Dim i As Integer
        Try
            Dim countGrid As Integer
            countGrid = Me.DgYarn.Rows.Count
            sumboxs = 0
            sumSpools = 0
            For i = 0 To Me.DgYarn.Rows.Count - 2
                Dim kg_gr As Double
                Dim kg_nt As Double
                Dim spools As Integer
                If Me.DgYarn.Rows(i).Cells("DGV_select").Value = True Then
                    If Me.DgYarn.Rows(i).Cells("cboitcd").Value = currentSelectedItem Then
                        sumboxs = sumboxs + 1
                        If IsDBNull(Me.DgYarn.Rows(i).Cells("Kg_gr").Value) Then
                            kg_gr = 0
                        Else
                            kg_gr = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Kg_gr").Value)
                        End If

                        If IsDBNull(Me.DgYarn.Rows(i).Cells("Kg_nt").Value) Then
                            kg_nt = 0
                        Else
                            kg_nt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Kg_nt").Value)
                        End If
                        If IsDBNull(Me.DgYarn.Rows(i).Cells("Spools").Value) Then
                            spools = 0
                        Else
                            spools = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Spools").Value)
                        End If
                        sumgross = sumgross + kg_gr
                        sumnet = sumnet + kg_nt
                        sumSpools = sumSpools + spools
                    End If
                End If
            Next
            Me.txtTotItemGW.Text = sumgross
            Me.txtTotItemNW.Text = sumnet
            Me.txtTotItemBox.Text = sumboxs
            Me.txtTotItemSpools.Text = sumSpools
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgYarn_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgYarn.CurrentCellDirtyStateChanged
        If DgYarn.IsCurrentCellDirty Then
            DgYarn.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub DgYarn_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.CellValueChanged
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        Calculateactual_cone_weight(sender:=sender, e:=e)
        calculateTotal()
        calculateItemTotal()
    End Sub

    Private Sub Calculateactual_cone_weight(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If DgYarn.DataSource Is Nothing Then Exit Sub
        Dim dt As DataTable = DgYarn.DataSource
        Dim i As Integer = CheckDelRow(dt)
        If CBool(chkAutoCalculate.Checked) Then
            If DgYarn.Columns(e.ColumnIndex).Name = "kg_nt" Then
                If Val(DgYarn.Rows(e.RowIndex).Cells("spools").Value) > 0 Then
                    DgYarn.Rows(e.RowIndex).Cells("actual_cone_weight").Value = _
               FormatNumber(DgYarn.Rows(e.RowIndex).Cells("kg_nt").Value / DgYarn.Rows(e.RowIndex).Cells("spools").Value, 2, TriState.False, TriState.False, TriState.False)
                Else
                    MessageBox.Show("Unit = 0 Please Check", "System Message")
                End If
                ' dt.Rows(e.RowIndex + i)("actual_cone_weight") = _
                'FormatNumber(dt.Rows(e.RowIndex + i)("kg_nt") / FormatNumber(dt.Rows(e.RowIndex + i)("spools"), 2, TriState.False, TriState.False, TriState.False))
            End If

        End If
        'DgYarn.Rows(e.RowIndex).Cells("actual_cone_weight").Value = _
        'DgYarn.Rows(e.RowIndex).Cells("kg_nt").Value / DgYarn.Rows(e.RowIndex).Cells("spools").Value

    End Sub
    Private Function CheckDelRow(ByVal dt As DataTable) As Integer
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState = DataRowState.Deleted Then j = j + 1
        Next
        Return j
    End Function

    Private Sub BtnYarnPrintBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnPrintBar.Click
        If Me.txtDocno.Text.Length > 5 Then
            Dim frm As New formPrintBarcode
            Dim stryarnin As String
            stryarnin = Me.txtDocno.Text.Trim
            frm.loginEmpcd = clsUser.UserID
            frm.txtYarn_in_no.Text = stryarnin.ToString.Trim
            frm.btnFindByYarnInClick()
            frm.SelectAll(sender, e)
            frm.UserInfo = UserInfo
            frm.MdiParent = Me.ParentForm
            frm.Show()
        End If
    End Sub

    Private Sub btnChangeYarnCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeYarnCode.Click
        If DgYarn.DataSource Is Nothing Then Exit Sub

        Dim dt As DataTable = DgYarn.DataSource
        Dim itcd As String = cboYarnCode.SelectedValue
        For i As Integer = 0 To dt.Rows.Count - 1
            dt.Rows(i)("itcd") = itcd
        Next
        DgYarn.Refresh()
    End Sub


    Private Sub txtyarn_out_no_TextChanged(sender As Object, e As EventArgs) Handles txtyarn_out_no.TextChanged

    End Sub

    Private Sub DgYarn_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgYarn.CellEndEdit

        Dim objdb As New classMaster


        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If DgYarn.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
            If Not IsDBNull(DgYarn.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(DgYarn.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = DgYarn.Rows(e.RowIndex).Cells("mtl_subinventory_id")

                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_name"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    'dgvccSubInven.Value = dtSubInven.Rows(0)("mtl_subinventory_id") 'Fix Error

                    Dim expression As String
                    expression = "subinventory_name like '%YARN STOCK%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception

                    'SetDefault
                    Dim expression As String
                    expression = "subinventory_name like '%YARN STOCK%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)

                    'dgvccSubInven.Value = foundRows(0)(0)
                    'dgvccSubInven.DataSource = dtSubInven
                    'dgvccSubInven.DisplayMember = "subinventory_name"
                    'dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    dgvccSubInven.Value = DBNull.Value
                    'dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If

        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt3 As New DataTable
        If DgYarn.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Or DgYarn.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(DgYarn.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) And Not IsDBNull(DgYarn.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value) Then
                dt3 = objdb.Combomtllocations(clsUser.UserID, DgYarn.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value, DgYarn.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value)
                dgvcc = DgYarn.Rows(e.RowIndex).Cells("mtl_locations_id")
                Try
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = dt3.Rows(0)("mtl_locations_id") 'Fix Error
                Catch ex As Exception
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = DBNull.Value
                End Try
            End If
        End If
    End Sub

    Private Sub cbomtlWarehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtlWarehouse.DropDownClosed
        bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "'"
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"

    End Sub

    Private Sub cbomtlSubinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtlSubinventory.DropDownClosed
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtlWarehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtlSubinventory.SelectedValue, 0) & "'"
    End Sub

    Private Sub btnGrossBoxWtPaste_Click(sender As Object, e As EventArgs) Handles btnGrossBoxWtPaste.Click
        Dim ErrMsg As String = ""

        With DgYarn
            Try
                If .Rows.Count = 1 Then
                    MessageBox.Show("ไม่มีข้อมูลใน Data Grid", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim LineNo As Byte = 0
                    If txtGrossBoxWt.Text.Trim = "" Then
                        LineNo += 1
                        If ErrMsg <> "" Then
                            ErrMsg &= vbCr
                        End If
                        ErrMsg &= Convert.ToString(LineNo) & ". คุณต้องป้อนข้อมูล Gross box weight (kg) ที่จะวางใน Data Grid ก่อนครับ"
                        txtGrossBoxWt.Focus()
                    End If
                    If txtGrossBoxWt.Text.Trim = "0" Then
                        LineNo += 1
                        If ErrMsg <> "" Then
                            ErrMsg &= vbCr
                        End If
                        ErrMsg = Convert.ToString(LineNo) & ". ข้อมูล Gross box weight (kg) ที่จะวางใน Data Grid ต้องมีค่ามากกว่า 0 ครับ"
                        'txtGrossBoxWt.Focus()
                    End If
                    If txtNetBoxWt.Text.Trim = "" Then
                        LineNo += 1
                        If ErrMsg <> "" Then
                            ErrMsg &= vbCr
                        End If
                        ErrMsg &= Convert.ToString(LineNo) & ". คุณต้องป้อนข้อมูล Net box weight (kg) ที่จะวางใน Data Grid ก่อนครับ"
                        txtNetBoxWt.Focus()
                    End If
                    If txtNetBoxWt.Text.Trim = "0" Then
                        LineNo += 1
                        If ErrMsg <> "" Then
                            ErrMsg &= vbCr
                        End If
                        ErrMsg &= Convert.ToString(LineNo) & ". ข้อมูล Net box weight (kg) ที่จะวางใน Data Grid ต้องมีค่ามากกว่า 0 ครับ"
                        txtNetBoxWt.Focus()
                    End If
                End If
                If ErrMsg <> "" Then
                    MessageBox.Show(ErrMsg, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                For i As Integer = 0 To .RowCount - 2
                    .Rows(i).Cells("kg_gr").Value = txtGrossBoxWt.Text.Trim
                    .Rows(i).Cells("kg_nt").Value = txtNetBoxWt.Text.Trim
                Next

            Catch ex As Exception
                MessageBox.Show("ข้อมูล ที่จะวางใน Data Grid ต้องเป็นตัวเลขเท่านั้น ครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtGrossBoxWt.Focus()
            End Try
        End With
    End Sub
    Private Function ChkIntKey(ByVal pKeyPress As String)
        Dim VL_ReturnValue As Boolean = False

        If Char.IsNumber(pKeyPress) Then
            VL_ReturnValue = True
        ElseIf Char.IsControl(pKeyPress) Then
            VL_ReturnValue = True
        ElseIf Asc(pKeyPress) = Asc(".") Then
            VL_ReturnValue = True
        Else
            VL_ReturnValue = False
            MessageBox.Show("ให้ป้อนตัวเลข 0 - 9 เท่านั้น", "ข้อความเตือนการป้อนข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return VL_ReturnValue
    End Function

    Private Sub txtGrossBoxWt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrossBoxWt.KeyPress
        If ChkIntKey(e.KeyChar) = False Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub txtNetBoxWt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNetBoxWt.KeyPress
        If ChkIntKey(e.KeyChar) = False Then
            e.KeyChar = Nothing
        End If
    End Sub


    Private Sub DgYarn_KeyDown(sender As Object, e As KeyEventArgs) Handles DgYarn.KeyDown
        With DgYarn
            If e.KeyCode = Keys.Enter Then
                Dim i As Integer = 0

                If .SelectedRows.Count = 0 Then
                    'Select Column
                    If .Columns(.SelectedCells(i).ColumnIndex).Name = "DGV_select" Then
                        For i = 0 To .SelectedCells.Count - 1
                            .SelectedCells(i).Value = Not CBool(.SelectedCells(i).Value)
                        Next
                    End If
                Else
                    'Select Row
                    For Each row As DataGridViewRow In .SelectedRows
                        i = row.Index
                        .Rows(i).Cells("DGV_select").Value = Not CBool(.Rows(i).Cells("DGV_select").Value)
                    Next
                End If
            End If
        End With
    End Sub

    Private Sub txtDocno_TextChanged(sender As Object, e As EventArgs) Handles txtDocno.TextChanged

    End Sub
End Class
