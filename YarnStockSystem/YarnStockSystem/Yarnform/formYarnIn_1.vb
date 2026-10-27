Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class formYarnIn
	Public loginEmpcd
	Private Clsconfig As New clsConfig
	Private dsYarn_in_det As DataTable
	Private ds As New DataSet
	Private connStr As New classConnection
	Private saveItcd As String
	Private saveTube As String
	Private saveGross As String
	Private saveKG_net As String
	Private saveBoxTearWeight As String
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

	Private Sub formYarnIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitControl()
    End Sub

    Private Sub InitControl()
        Call GetAllComboINGrid()
        Dim clsGetDataYarn As New GetDataYarn

        Me.BtnYarnSave.Visible = True
        Me.btnNew.Visible = False
        Me.DgYarn.AutoGenerateColumns = False
        insertcomboitemcode()
        insertcomboCurrency()
        Me.BtnYarnSave.Visible = True
        Me.btnNew.Visible = False
        ds = clsGetDataYarn.GetDataSupplier()
        CbSupplier.DataSource = ds.Tables(0)

    End Sub

    Private Sub GetAllComboINGrid()
        Dim clsGetDatYarn As New GetDataYarn

        Call GetComboWarehouseinGrid()
        Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=clsGetDatYarn.GetDefaultWareHouse(clsUser.UserID))
        Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=4, Int64mtl_subinventory_id:=11)

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
			'Me.cboCurrency.DataSource = ds.Tables(0)
			'Me.cboCurrency.DisplayMember = "currname"
			'Me.cboCurrency.ValueMember = "curr"
		End If
	End Sub

	Private Sub insertcomboitemcode()
		Dim tblItems As New tbl_Items
		Dim getDatayarn As New GetDataYarn
		Dim ds As New DataSet
		tblItems.itcd = ""
		ds = getDatayarn.GetDataItem(tblItems)
		Me.txtitcd.Text = ds.Tables(0).Rows(0).Item("itcd").ToString
		If Not IsNothing(ds) Then
			Me.cboitcd.DataSource = ds.Tables(0)
			Me.cboitcd.DisplayMember = "itdesc"
			Me.cboitcd.ValueMember = "Itcd"
		End If
	End Sub

	Private Sub BtnYarnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnSave.Click
		If MsgBox("Are you sure to Save ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
			InsertData()
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

    Private Sub InsertData()

        'Fix User Not End Edit
        DgYarn.EndEdit(DataGridViewDataErrorContexts.Commit)
        DgYarn.CurrentCell = DgYarn.Rows(0).Cells(0)

        If Not CheckActualConeWeight() Then MessageBox.Show("ถ้าไม่ได้ใส่ Actual Cone Weight โปรแกรมจะดึงข้อมูลจาก Net weight หารด้วย Spool ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim i As Integer
        For i = 0 To DgYarn.Rows.Count - 2
            If Clsconfig.IsNull(Me.DgYarn.Rows(i).Cells("mtl_warehouse_id").Value, 0) = 0 Then
                MessageBox.Show("ต้องมี WareHouse ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

            End If

            If Me.DgYarn.Rows(i).Cells("cboITCD").Value.ToString.Substring(0, 3) = "YRA" And _
                Clsconfig.IsNull(Me.DgYarn.Rows(i).Cells("mtl_subinventory_id").Value, 0) = 0 Then
                MessageBox.Show("ต้องมี Subinventory  ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Next

        Dim config As New clsConfig
        config.ChangeCulture()

        Dim InsertYarn As New InsertYarn
        Dim tblYarnin As New tbl_Yarn_in
        'Dim i As Integer
        Dim Isvalid As Boolean
        If DgYarn.Rows.Count > 1 Then
            Try
                'Insert tbl_Yarn_in
                tblYarnin.docdt = Me.DateYIN.Value.ToString("yyyy/MM/dd")  'As string
                'tblyarnin.jobno 
                tblYarnin.purno = Me.txtPO.Text.Trim    'As String
                tblYarnin.sinvno = UCase(Me.txtSupp.Text.Trim)  'As String
                tblYarnin.sinvdt = Me.txtSupDt.Text.Trim    'As String
                tblYarnin.suppcd = Me.CbSupplier.SelectedValue 'As String
                tblYarnin.lotno_sup = UCase(Me.txtSupLot.Text.Trim)     ' As String
                tblYarnin.lotno_our = UCase(Me.txtSupLot.Text.Trim)
                tblYarnin.srefno = Me.txtSRefno.Text.Trim    'As String
                'tblYarnin.totkg = "" 'As Integer
                '			tblYarnin.curr = Me.cboCurrency.SelectedValue 'As String
                '			tblYarnin.exrt = Val(Me.txtrate.Text.Trim) 'As Integer
                '			tblYarnin.vat = Val(Me.txtVat.Text.Trim)   'As Integer
                '			tblYarnin.vatamt = Val(Me.txtVatAmount.Text.Trim)	'As Integer
                'tblYarnin.taxper = "" 'As Integer
                'tblYarnin.taxamt = "" 'As Integer
                '		tblYarnin.freight = Val(Me.txtFreight.Text.Trim)   'As Integer
                '		tblYarnin.insurance = Val(Me.txtInsurance.Text.Trim)   'As Integer
                '		tblYarnin.otheramt = Val(Me.txtAmt.Text.Trim)	'As Integer
                '		tblYarnin.other_text = Me.txtDetail.Text.Trim	 'String
                '		tblYarnin.discamt = Val(Me.txtDiscountamount.Text.Trim)	'Integer
                '		tblYarnin.totamt = Val(Me.txtTotalAmount.Text.Trim)	  'Integer
                tblYarnin.tstamp = Clsconfig.ConvertFormatDateTostring(Today.Date) 'string
                'tblYarnin.tran_type = "" 'Integer
                tblYarnin.docapp = 1 'Boolean 1 or 0
                tblYarnin.cancel = 0 'Boolean 1 or 0
                'tblYarnin.outno = "" 'Integer
                tblYarnin.remark = Me.txtremark.Text.ToString.Trim  'Integer

                '///////////////////
                ' Insert tbl_Yarn_in_det
                For i = 0 To Me.DgYarn.Rows.Count - 2
                    ReDim Preserve tblYarnin.tbl_Yarn_in_det(i)
                    tblYarnin.tbl_Yarn_in_det(i) = New tbl_Yarn_in_det
                    'If Not Me.DgYarn.Rows(i).Cells("colitcd") Is Nothing Then
                    If IsDBNull(Me.DgYarn.Rows(i).Cells("colitcd").Value) Then
                        MsgBox("Item code is incorrect, please check")
                        Exit Sub
                    End If
                    tblYarnin.tbl_Yarn_in_det(i).itcd = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("cboitcd").Value.ToString)
                    tblYarnin.tbl_Yarn_in_det(i).itcd = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("cboitcd").Value.ToString)
                    tblYarnin.tbl_Yarn_in_det(i).grade = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells(2).Value.ToString)
                    tblYarnin.tbl_Yarn_in_det(i).boxno_s = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells(3).Value.ToString)
                    'tblYarnin.tbl_Yarn_in_det(i).boxno = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells(4).Value.ToString).PadLeft(4, "0")
                    tblYarnin.tbl_Yarn_in_det(i).spools = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("spools").Value)
                    tblYarnin.tbl_Yarn_in_det(i).kg_gr = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_gr").Value)
                    tblYarnin.tbl_Yarn_in_det(i).cart_tearwt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("cart_tearwt").Value)
                    tblYarnin.tbl_Yarn_in_det(i).kg_nt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_nt").Value)
                    tblYarnin.tbl_Yarn_in_det(i).actual_cone_weight = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("actual_cone_weight").Value)

                    tblYarnin.tbl_Yarn_in_det(i).docno = 0 'Me.DgYarn.Rows(i).Cells("docno").Value.ToString
                    tblYarnin.tbl_Yarn_in_det(i).boxno_o = 0 ' Me.DgYarn.Rows(i).Cells("boxno_o").Value.ToString
                    tblYarnin.tbl_Yarn_in_det(i).lotno_sup = Me.txtSupLot.Text.Trim.ToString ' Me.DgYarn.Rows(i).Cells("boxno_o").Value.ToString
                    tblYarnin.tbl_Yarn_in_det(i).lotno_our = Me.txtSupLot.Text.Trim.ToString    ' Me.DgYarn.Rows(i).Cells("boxno_o").Value.ToString
                    tblYarnin.tbl_Yarn_in_det(i).spool_tearwt = 0 ' Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("spool_tearwt").Value)
                    tblYarnin.tbl_Yarn_in_det(i).price = 0 'Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("price").Value)
                    tblYarnin.tbl_Yarn_in_det(i).location = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("collocation").Value)
                    tblYarnin.tbl_Yarn_in_det(i).tstamp = Clsconfig.ConvertFormatDateTostring(Clsconfig.IsValidDate(Today.Date)) 'Clsconfig.ConvertFormatDateTostring(Clsconfig.IsValidDate(Me.DgYarn.Rows(i).Cells("tstamp").Value))
                    tblYarnin.tbl_Yarn_in_det(i).mtl_warehouse_id = DgYarn.Rows(i).Cells("mtl_warehouse_id").Value
                    tblYarnin.tbl_Yarn_in_det(i).mtl_subinventory_id = DgYarn.Rows(i).Cells("mtl_subinventory_id").Value
                    tblYarnin.tbl_Yarn_in_det(i).mtl_locations_id = DgYarn.Rows(i).Cells("mtl_locations_id").Value

                    'If Clsconfig.IsNull(DgYarn.Rows(i).Cells("mtl_warehouse_id").Value, 0) = 0 Or _
                    '    Clsconfig.IsNull(DgYarn.Rows(i).Cells("mtl_subinventory_id").Value, 0) = 0 Then
                    '    MsgBox("Please Enter Warehouse , Sub Inventory")
                    '    Exit Sub
                    'End If

                Next
                Dim msgerr As String = ""
                Dim docno As String = ""
                Isvalid = InsertYarn.InsertYarnIn(tblYarnin, msgerr, docno, Me.loginEmpcd)
                Dim a As String
                a = Me.txttotalnet.Text
                If Isvalid = True Then
                    Me.lblYINno.Text = docno
                    MsgBox("Success")
                    Me.btnNew.Visible = True
                    Me.BtnYarnSave.Visible = False
                Else
                    MsgBox(msgerr)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Yarn details not entered, data not saved")
        End If
    End Sub

    Private Sub BtnYarnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnExit.Click
        Me.Close()
    End Sub

	Private Sub BtnYarnPrintDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnPrintDoc.Click
        'Dim str As String
        'str = ""
        'ds.Clear()
        '      str = "select * from v_yarn_in " & _
        ' " where docno = '" & Me.lblYINno.Text & "' order by itcd,boxno_s"

        'Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        'myda.Fill(ds, "TblDatayarnin")

        '      Dim frmreport As New FormRptYarnIn
        '      Dim rptFileName As String = "RptYarnIn.rpt"
        '      Dim obj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '      obj.Load(clsuser.reportpath & rptFileName)
        '      'Dim obj As New RptYarnIn
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
        rpt.SetParameterValue("@docno", lblYINno.Text)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
	End Sub

	Private Sub DgYarn_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)
		'Dim aa As String
		'aa = Me.DgYarn.Rows(0).Cells(0).Value.ToString()
		'e.Row.Cells(0).Value = Me.DgYarn.Rows(0).Cells(0).Value
	End Sub
    Private Sub BtnYarnPrintBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnPrintBar.Click
        If Me.lblYINno.Text.Length > 5 Then
            Dim frm As New formPrintBarcode
            Dim arrlbl
            Dim stryarnin As String

            arrlbl = Split(Me.lblYINno.Text, ":", -1, 1)
            stryarnin = arrlbl(0)
            frm.loginEmpcd = clsUser.UserID
            frm.txtYarn_in_no.Text = stryarnin.ToString.Trim
            frm.btnFindByYarnInClick()
            frm.SelectAll(sender, e)
            frm.UserInfo = clsUser
            frm.MdiParent = Me.ParentForm
            frm.Show()
        End If
    End Sub

	Private Sub txtPO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPO.TextChanged
		Dim tblPur As New tbl_Pur
		Dim arr_tblPurPur As New tbl_Pur
		Dim msgerr As String = ""
		Dim getDatayarn As New GetDataYarn
		Dim objarr_tblPur() As tbl_Pur
		Dim ds As New DataSet
		Dim objsupp As New GetDataYarn
        Try
            arr_tblPurPur.purno = UCase(Me.txtPO.Text)
            objarr_tblPur = getDatayarn.checkPurno(arr_tblPurPur, msgerr)
            If Me.txtPO.Text.Trim = "" Then
                ds = objsupp.GetDataSupplier()
            Else
                ds = objsupp.GetPOSupplier(Me.txtPO.Text.Trim)
            End If
            If ds.Tables(0).Rows.Count = 0 Then
                ds = objsupp.GetDataSupplier()
            End If
            CbSupplier.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

                    dgvccSubInven.Value = foundRows(0)(0)
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

    Private Sub DgYarn_CellErrorTextNeeded(sender As Object, e As DataGridViewCellErrorTextNeededEventArgs) Handles DgYarn.CellErrorTextNeeded

    End Sub

	Private Sub DgYarn_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.CellValidated
		Dim currRow As Integer
		Dim currCol As Integer
		currRow = e.RowIndex
		currCol = e.ColumnIndex

		Try
			If currCol = DgYarn.Rows(currRow).Cells("colitcd").ColumnIndex Then
				DgYarn.Rows(currRow).Cells("cboitcd").Value = DgYarn.Rows(currRow).Cells("colitcd").Value
			End If
			If currCol = DgYarn.Rows(currRow).Cells("cboitcd").ColumnIndex Then
				DgYarn.Rows(currRow).Cells("colitcd").Value = DgYarn.Rows(currRow).Cells("cboitcd").Value
			End If
		Catch ex As Exception

		End Try
		calcTotal()

	End Sub

	Private Sub DgYarn_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DgYarn.DefaultValuesNeeded
		Me.txtitcd.Text = Me.DgYarn.Rows(0).Cells(0).Value
		'		e.Row.Cells(1).Value = Me.DgYarn.Rows(0).Cells(0).Value
		e.Row.Cells(2).Value = 0
		e.Row.Cells(3).Value = ""
		e.Row.Cells(4).Value = 0
		e.Row.Cells("colitcd").Value = saveItcd
		e.Row.Cells("spools").Value = saveTube
		e.Row.Cells("kg_nt").Value = saveKG_net
		e.Row.Cells("kg_gr").Value = saveGross
		e.Row.Cells("cart_tearwt").Value = saveBoxTearWeight
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

	Private Sub DgYarn_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.RowValidated
		Dim currentRow As Integer
		currentRow = e.RowIndex
		saveItcd = Me.DgYarn.Rows(currentRow).Cells("cboItcd").Value
		saveTube = Me.DgYarn.Rows(currentRow).Cells("spools").Value
		saveKG_net = Me.DgYarn.Rows(currentRow).Cells("kg_nt").Value
		saveBoxTearWeight = Me.DgYarn.Rows(currentRow).Cells("cart_tearwt").Value
        saveGross = Me.DgYarn.Rows(currentRow).Cells("kg_gr").Value
        calcTotal()
    End Sub
    Private Sub calcTotal()
        Dim sumTubes As Integer
        Dim sumgross As Double
        Dim sumnet As Double
        Dim i As Integer

        Try
            Dim countGrid As Integer
            countGrid = Me.DgYarn.Rows.Count
            For i = 0 To Me.DgYarn.Rows.Count - 2
                Dim kg_gr As Double
                Dim kg_nt As Double
                Dim tubes As Integer
                If IsDBNull(Me.DgYarn.Rows(i).Cells("spools").Value) Then
                    tubes = 0
                Else
                    tubes = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Spools").Value)
                End If

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
                sumTubes = sumTubes + tubes
            Next
            Me.txttotalgross.Text = sumgross
            Me.txttotalnet.Text = sumnet
            Me.textTotaltubes.Text = sumTubes
            txttotalboxes.Text = Me.DgYarn.RowCount - 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

	Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
		Me.btnNew.Visible = False
		Me.BtnYarnSave.Visible = True
		Me.DgYarn.Rows.Clear()
		Me.lblYINno.Text = ""
	End Sub

	Private Sub DgYarn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.CellContentClick

	End Sub

	Private Sub DgYarn_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DgYarn.DataError
		MsgBox("Item code is invalid")
		DgYarn.Rows(e.RowIndex).Cells("cboitcd").Value = Nothing
		e.ThrowException = False
		e.Cancel = True
	End Sub
End Class