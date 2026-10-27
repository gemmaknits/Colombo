Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Globalization


Imports System.Linq
Imports System.Linq.Enumerable
Imports System.Linq.Expressions
Imports System.Linq.Queryable

Public Class formJobOrderYarnNewEdit
    Private oConn As New classConnection
    Private oConfig As New clsConfig
    Private clsUserInfo As New classUserInfo
    Private clsMaster As New classMaster

    Dim ds As New DataSet
    Dim dtJob As New DataTable
    Dim formMode As String
    Private dtYarnIn As DataTable
    Private dt As DataTable
    Dim currentItcdSelected As Object
    Private MtlWarehouseId As Integer 'Sitthana 20191129
    Private MtlSubinventoryId As Integer 'Sitthana 20191129
    Private selectedItcd As String
    Private selectedMfgProductionOrderLinesId As Nullable(Of Int64)
    Dim blnCancel As Boolean = False
    Private clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub GenGrid()
        DgJobYarndet.DataSource = Nothing
        DgJobYarndet.AutoGenerateColumns = False
        dtJob = New DataTable
        dtJob.Columns.Add("itcd", GetType(String))
        dtJob.Columns.Add("grade", GetType(String))
        dtJob.Columns.Add("boxno", GetType(String))
        dtJob.Columns.Add("spools", GetType(Double))
        dtJob.Columns.Add("kg_gr", GetType(Double))
        dtJob.Columns.Add("kg_nt", GetType(Double))
        dtJob.Columns.Add("actual_cone_weight", GetType(Decimal))
        dtJob.Columns.Add("lotno_our", GetType(String))
        dtJob.Columns.Add("gb", GetType(String))
        dtJob.Columns.Add("id_job_det", GetType(Int64))
        dtJob.Columns.Add("mfg_production_order_line_id", GetType(Int64))
        DgJobYarndet.DataSource = dtJob
    End Sub

    Private Sub AddRowToGrid(ByVal dtSource As DataTable)
        Dim dr As Data.DataRow
        Dim i As Integer = 0
        Dim j As Integer = 0
        If Not dtSource Is Nothing Then
            If dtSource.Rows.Count > 0 Then
                For i = 0 To dtSource.Rows.Count - 1
                    dr = dtJob.Rows.Add
                    dr("mfg_production_order_line_id") = dtSource.Rows(i)("mfg_production_order_line_id")
                    dr("itcd") = dtSource.Rows(i)("itcd")
                    dr("grade") = dtSource.Rows(i)("grade")
                    dr("boxno") = dtSource.Rows(i)("boxno")
                    dr("spools") = dtSource.Rows(i)("spools")
                    dr("kg_gr") = dtSource.Rows(i)("kg_gr")
                    dr("kg_nt") = dtSource.Rows(i)("kg_nt")
                    dr("lotno_our") = dtSource.Rows(i)("lotno_our")
                    dr("gb") = dtSource.Rows(i)("gb")
                    dr("actual_cone_weight") = dtSource.Rows(i)("actual_cone_weight")
                    dr("id_job_det") = dtSource.Rows(i)("id_job_det")
                Next
            End If
        End If
        DgJobYarndet.Refresh()
    End Sub

    Private Sub formJobOrderforYarn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()
        rdStock.Checked = True
    End Sub

    Private Sub intTxtSerarch()
        'Sitthana 20191129
        txtSupplierCode.Text = ""
        txtSupplierName.Text = ""
        txtWarehouseCode.Text = ""
        'txtWarehouseName.Text = ""
        txtSubinventoryCode.Text = ""
        'txtSubinventoryName.Text = ""
        txtSoNo.Text = ""
        txtSoNoId.Text = ""
        ' txtDesignNo.Text = ""
        txtKono.Text = ""
        txtYIn.Text = ""
        txtItcd.Text = ""
        Cbjobtype.SelectedIndex = -1

    End Sub
    Private Sub SetControlValue(ByVal Obj As Control)

        If TypeOf Obj Is TextBox Then

            If Obj.Tag = "str" Or Obj.Tag = "" Then Obj.Text = ""
            If Obj.Tag = "int" Then Obj.Text = "0.00"

        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
        End If

        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj

            If Obj.Name = "cboPackAfterBulkApp" Then
                cbo.SelectedValue = 0
            ElseIf Obj.Name = "cboMtl_warehouse" Then
                cbo.SelectedIndex = -1
            ElseIf Obj.Name = "cbofulfilment_type" Then
                cbo.SelectedIndex = -1

            Else


                cbo.SelectedValue = vbNull
            End If
        End If

        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If

        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub
    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DataGridView Then
            Dim grd As DataGridView = Obj
            grd.ReadOnly = Not blnEnabled
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If
    End Sub
    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)

        Dim cn As New SqlConnection(oConn.Connection)

        'Begin Comment By Sitthana 20191129
        'Call GenCombo()
        'Call GetComboSoNo()
        'cboSoNo.Enabled = True
        'Call GetComboSoNoID(StrSoNo:=cboSoNo.SelectedValue)
        'CboSoNoId.Enabled = True
        'CboSoNoId.SelectedIndex = -1
        'CboSoNoId.Text = ""
        'End Comment By Sitthana 20191129

        intTxtSerarch() 'Sitthana 20191129

        DgYarnIn.AutoGenerateColumns = False
        DgYarnIn.DataSource = Nothing 'Sitthana 20191130
        dgJobDet.AutoGenerateColumns = False
        dgJobDet.DataSource = Nothing
        Call GenGrid()
        FuncDiscbSupplier()
        Funcdiscbjbotype()
        FuncDisColor()

        currentItcdSelected = ""

        setFormMode("NEW")

        dtpjobdt.Value = Now
        Call GenAutoComplete()
        Cbjobtype.Select()
    End Sub

    Private Sub GenAutoComplete()

        Dim dtKO As DataTable = (New classJobOrderYarn).GetKoNo
        Dim rowKO As DataRow
        txtKono.AutoCompleteSource = AutoCompleteSource.None
        txtKono.AutoCompleteMode = AutoCompleteMode.None
        txtKono.AutoCompleteCustomSource.Clear()
        For Each rowKO In dtKO.Rows
            txtKono.AutoCompleteCustomSource.Add(rowKO.Item("kono").ToString())
        Next
        txtKono.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtKono.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        Dim dtItems As DataTable = (New classJobOrderYarn).GetItcd
        Dim rowItems As DataRow
        txtItcd.AutoCompleteSource = AutoCompleteSource.None
        txtItcd.AutoCompleteMode = AutoCompleteMode.None
        txtItcd.AutoCompleteCustomSource.Clear()
        For Each rowItems In dtItems.Rows
            txtItcd.AutoCompleteCustomSource.Add(rowItems.Item("itcd").ToString())
        Next
        txtItcd.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtItcd.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    Private Sub GenCombo()
        'Comment By Sitthana 20191129

        'Call GetComboNewWarehouse()
        'Call GetComboNewSubInventory(Int64mtl_warehouse_id:=cboNewmtl_warehouse.SelectedValue)
    End Sub
    'Private Sub GetComboSoNo()

    '    Me.cboSoNo.DataSource = (New classMaster).GetSoNo
    '    Me.cboSoNo.DisplayMember = "sono2"
    '    Me.cboSoNo.ValueMember = "sono2"
    '    Me.cboSoNo.SelectedIndex = -1
    'End Sub

    'Private Sub GetComboSoNoID(ByVal StrSoNo As String)
    '    'Comment By Sitthana 20191129
    'Me.CboSoNoId.DataSource = (New classMaster).combosono(StrSono:=StrSoNo)
    '    Me.CboSoNoId.DisplayMember = "design_no"
    '    Me.CboSoNoId.ValueMember = "sonoid"

    '    'SearchSOID(CboSoNoId.DataSource)

    'End Sub

    'Private Sub SearchSOID(ByVal dtResult As DataTable)
    'Comment By Sitthana 20191129
    '    Dim dvResult As DataView 'ตัวแปรเก็บผลลัพธ์
    '    Dim strFilter As String 'ตัวแปรเก็บเงื่อนไขค้นหา

    '    dvResult = New DataView(dtResult) 'นำข้อมูลจาก DataTable ที่ต้องการค้นหา มาไว้ใน DataView
    '    'dvResult = New DataTable(dtResult) 'นำข้อมูลจาก DataTable ที่ต้องการค้นหา มาไว้ใน DataView

    '    'dt.Select(dtResult)
    '    strFilter = "sono like '%" & cboSoNo.SelectedValue & "%'"

    '    dvResult.RowFilter = strFilter 'ค้นหา


    '    CboSoNoId.DataSource = dvResult 'นำผลลัพธ์ที่ค้นหาคืนสู่ DataGridView
    'End Sub
    Private Sub GetComboNewWarehouse()
        'Comment By Sitthana 20191129
        'Dim objdb As New classMaster

        'cboNewmtl_warehouse.DataSource = objdb.Combomtlwarehouse(strUSerID:="")
        'cboNewmtl_warehouse.DisplayMember = "warehouse_code"
        'cboNewmtl_warehouse.ValueMember = "mtl_warehouse_id"

        'SetdefaultWarehouse()

    End Sub

    Private Sub GetComboNewSubInventory(ByVal Int64mtl_warehouse_id As Int64)
        'Comment By Sitthana 20191129
        'Dim objdb As New classMaster

        'cbomtl_subinventory.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        'cbomtl_subinventory.DisplayMember = "subinventory_code"
        'cbomtl_subinventory.ValueMember = "mtl_subinventory_id"

        ''Setdefaultsubinventory(dt:=cbomtl_subinventory.DataSource)

    End Sub
    Private Sub Setdefaultsubinventory(ByVal dt As DataTable)
        'Comment By Sitthana 20191129
        'Dim expression As String
        'expression = "subinventory_name like '%YARN STOCK%'"
        'Dim foundRows() As DataRow
        'foundRows = dt.Select(expression)

        'Try
        '    cbomtl_subinventory.SelectedValue = foundRows(0)(0)
        'Catch ex As Exception
        '    cbomtl_subinventory.Text = ""
        'End Try
    End Sub


    Private Sub SetdefaultWarehouse()
        'Comment By Sitthana 20191129
        'Dim clsMaster As New classMaster

        'cboNewmtl_warehouse.SelectedValue = clsMaster.GetdefaultWarehouse(strUSerID:="")
    End Sub

    '------------------Getdata input to CbColors
    Private Sub FuncDisColor()
        Dim tblSupplier As New GetDataYarn
        Dim dtcol As New DataTable
        dtcol = tblSupplier.GetColor
        If Not IsNothing(dtcol) Then
            Me.Cbcolor.DataSource = dtcol
            Me.Cbcolor.DisplayMember = "colname"
            Me.Cbcolor.ValueMember = "col"
        End If
        Me.Cbcolor.SelectedValue = "NONE"
    End Sub

    '------------------Getdata input to CbSuppcd
    Private Sub FuncDiscbSupplier()
        'Comment By Sitthana 20191129
        'Dim tblSupplier As New GetDataYarn
        'Dim dtsupplier As New DataTable
        'dtsupplier = tblSupplier.GetSupplier
        'If Not IsNothing(dtsupplier) Then
        '    Me.CbSuppcd.DataSource = dtsupplier
        '    Me.CbSuppcd.DisplayMember = "name"
        '    Me.CbSuppcd.ValueMember = "suppcd"
        'End If
    End Sub

    '------------------Getdata input to Cbjobtype
    Private Sub Funcdiscbjbotype()
        Dim tblSupplier As New GetDataYarn
        Dim dt As New DataTable
        dt = tblSupplier.Getjobtype
        If Not IsNothing(dt) Then
            Me.Cbjobtype.DataSource = dt
            Me.Cbjobtype.DisplayMember = "tran_desc"
            Me.Cbjobtype.ValueMember = "tran_type"
        End If
        Cbjobtype.SelectedIndex = -1

    End Sub

    Private Sub txtYIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYIn.KeyPress
        If e.KeyChar = vbCr Then
            getYarnStock()
        End If
    End Sub

    ' Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
    'If e.KeyChar = vbCr Then
    '    selectedItcd = txtStock.Text
    '    Dim TranType() As String = {"WARPING", "KNITTING"}
    '    'selectedMfgProductionOrderLinesId = frm.pMfgProductionOrderLinesId
    '    If Cbjobtype.SelectedValue.ToString.Trim.Equals("WARPING") Or Cbjobtype.SelectedValue.ToString.Trim.Equals("KNITTING") Then
    '        If txtKono.Text.Trim = "" Then
    '            MessageBox.Show("คุณต้องเลือก เลขที่ Prod No. ก่อนครับ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Else
    '            Call getYarnStock()
    '        End If
    '    Else
    '        Call getYarnStock()
    '    End If 'Sitthaan 20191210

    'End If
    'End Sub

    Private Function CheckTranType(ByVal _jobType As String) As Boolean
        Dim TranType() As String = {"WARPING", "KNITTING"}


    End Function

    Private Sub btnSendOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendOne.Click
        Dim i As Integer
        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        Dim dsRow As DataRow
        'Dim dt As DataTable
        'dsset.Clear()
        dsTable = dsset.Tables.Add
        dsTable.Columns.Add("mfg_production_order_line_id", GetType(Int64))
        dsTable.Columns.Add("itcd", GetType(String))
        dsTable.Columns.Add("grade", GetType(String))
        dsTable.Columns.Add("boxno", GetType(String))
        dsTable.Columns.Add("spools", GetType(String))
        dsTable.Columns.Add("kg_gr", GetType(Double))
        dsTable.Columns.Add("kg_nt", GetType(Double))
        dsTable.Columns.Add("lotno_our", GetType(String))
        dsTable.Columns.Add("gb", GetType(String))
        dsTable.Columns.Add("actual_cone_weight", GetType(Decimal)) 'Neung 20260515 String -> Decimal
        dsTable.Columns.Add("id_job_det", GetType(String))
        If Not IsNothing(dtYarnIn) Then
            For i = 0 To Me.DgYarnIn.Rows.Count - 1
                If Me.DgYarnIn.Rows(i).Cells(0).Value = True Then
                    If Not CheckDupicarte(Me.DgYarnIn.Rows(i).Cells("colDgYarnInboxno").Value.ToString, DgJobYarndet.DataSource) Then Exit Sub
                    dsRow = dsTable.NewRow
                    dsRow("mfg_production_order_line_id") = (New clsConfig).IsNull(Me.DgYarnIn.Rows(i).Cells("colDgYarnInMfgProductionOrderLinesId").Value, DBNull.Value)
                    dsRow("itcd") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInItcd").Value.ToString
                    dsRow("grade") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInGrade").Value.ToString
                    dsRow("boxno") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInboxno").Value.ToString
                    dsRow("spools") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInSpools").Value.ToString
                    dsRow("kg_gr") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInKgGr").Value '.ToString
                    dsRow("kg_nt") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInKgNt").Value '.ToString
                    dsRow("lotno_our") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInLotnoOur").Value.ToString
                    dsRow("gb") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInGB").Value.ToString
                    dsRow("actual_cone_weight") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInActualConeWeight").Value '.ToString
                    dsRow("id_job_det") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInIdJobDet").Value.ToString
                    dsset.Tables(0).Rows.Add(dsRow)
                End If
            Next
        End If
        dt = dsset.Tables(0)

        'Me.Dg_jobYarndet.DataSource = dt
        Call AddRowToGrid(dt)
        Call compareTwoGrids()
        calculateSelected()
        calculateSelection()
        Call GenDgvGroup()
    End Sub

    Private Function CheckDupicarte(ByVal StrBoxno As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("boxno").ToString.Trim = StrBoxno.Trim Then
                        MessageBox.Show("ไม่สามารถเลือกกล่องเดียวกันได้", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                End If
            Next
        End If

        Return True
    End Function

    Private Sub BtnsendAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnsendAll.Click
        'Dim dt As DataTable
        Dim i As Integer
        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        Dim dsRow As DataRow
        'Dim dt As DataTable
        'dsset.Clear()
        dsTable = dsset.Tables.Add
        dsTable.Columns.Add("mfg_production_order_line_id", GetType(Int64))
        dsTable.Columns.Add("itcd", GetType(String))
        dsTable.Columns.Add("grade", GetType(String))
        dsTable.Columns.Add("boxno", GetType(String))
        dsTable.Columns.Add("spools", GetType(String))
        dsTable.Columns.Add("kg_gr", GetType(Double))
        dsTable.Columns.Add("kg_nt", GetType(Double))
        dsTable.Columns.Add("lotno_our", GetType(String))
        dsTable.Columns.Add("gb", GetType(String))
        dsTable.Columns.Add("actual_cone_weight", GetType(Decimal))
        dsTable.Columns.Add("id_job_det", GetType(String))
        If Not IsNothing(dtYarnIn) Then
            For i = 0 To Me.DgYarnIn.Rows.Count - 1
                If Not CheckDupicarte(Me.DgYarnIn.Rows(i).Cells("colDgYarnInboxno").Value.ToString, DgJobYarndet.DataSource) Then Exit Sub
                dsRow = dsTable.NewRow
                dsRow("mfg_production_order_line_id") = (New clsConfig).IsNull(Me.DgYarnIn.Rows(i).Cells("colDgYarnInMfgProductionOrderLinesId").Value, DBNull.Value)
                dsRow("itcd") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInItcd").Value.ToString
                dsRow("grade") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInGrade").Value.ToString
                dsRow("boxno") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInboxno").Value.ToString
                dsRow("spools") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInSpools").Value.ToString
                dsRow("kg_gr") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInKgGr").Value.ToString
                dsRow("kg_nt") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInKgNt").Value.ToString
                dsRow("lotno_our") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInLotnoOur").Value.ToString
                dsRow("gb") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInGB").Value.ToString
                dsRow("actual_cone_weight") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInActualConeWeight").Value '.ToString
                dsRow("id_job_det") = Me.DgYarnIn.Rows(i).Cells("colDgYarnInIdJobDet").Value.ToString
                dsset.Tables(0).Rows.Add(dsRow)

            Next
        End If
        dt = dsset.Tables(0)


        'Me.Dg_jobYarndet.DataSource = dt
        Call AddRowToGrid(dt)
        dtYarnIn.Rows.Clear()
        calculateSelected()

        Call GenDgvGroup()
    End Sub

    Private Sub BtnBackOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackOne.Click
        Dim i As Integer
        'For i = 0 To Me.Dg_jobYarndet.Rows.Count - 1
        '    If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
        '        Me.Dg_jobYarndet.Rows.RemoveAt(i)
        '    End If
        'Next
        'Sitthana 19/04/2018
        With DgJobYarndet
            For i = .Rows.Count - 1 To 0 Step -1
                If .Rows(i).Cells(0).Value = True Then
                    .Rows.RemoveAt(i)
                End If
            Next
        End With

        Call getYarnStock()
        Call FilterYarnStock(dtYarnIn)
        Call GenDgvGroup()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If formMode = "NEW" Then
            saveNewJob()
        Else
            updateJob()
        End If

        Exit Sub
    End Sub

    Private Sub BtnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchItem.Click
        Dim selectedItcd As String
        Dim formSearchItemCode As New formSearchItemcode
        selectedItcd = formSearchItemCode.getItemcode("ALL")
        If selectedItcd <> "" Then
            Me.textNewItcd.Text = selectedItcd
        End If
    End Sub

    Private Sub BtnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackAll.Click
        dtJob.Rows.Clear()
        Call getYarnStock()
        Call FilterYarnStock(dtYarnIn)
        Call GenDgvGroup()
    End Sub

    Function GroupbyItcdofdts(ByVal dttt As DataTable) As DataTable
        Dim i As Integer
        Dim lastitcd As String
        Dim lastid_job_det As Int32 = 0
        Dim lastMfgProductionOrderLineId As Nullable(Of Int64)
        Dim sum As Double
        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        Dim dsRow As DataRow

        dsTable = dsset.Tables.Add
        dsTable.Columns.Add("id_job_det", GetType(Int32)) '--Check Again
        dsTable.Columns.Add("itcd", GetType(String))
        dsTable.Columns.Add("grade", GetType(String))
        dsTable.Columns.Add("boxno", GetType(String))
        dsTable.Columns.Add("spools", GetType(String))
        dsTable.Columns.Add("kg_gr", GetType(String))
        dsTable.Columns.Add("kg_nt", GetType(String))
        dsTable.Columns.Add("lotno_our", GetType(String))
        dsTable.Columns.Add("gb", GetType(String))
        dsTable.Columns.Add("mfg_production_order_line_id", GetType(Int64))
        If dttt.Rows.Count > 0 Then
            lastitcd = dttt.Rows(0).Item("itcd").ToString.Trim
            lastMfgProductionOrderLineId = (New clsConfig).IsNull(dttt.Rows(0).Item("mfg_production_order_line_id"), Nothing)
            'itcd = 1
            'Proid = 1
            For i = 0 To dttt.Rows.Count - 1
                If dttt.Rows(i).Item("itcd").ToString.Trim = lastitcd.Trim Then
                    'itcd = 1
                    'Proid = 1
                    'sum = 1
                    sum = sum + dttt.Rows(i).Item("kg_nt")
                Else
                    dsRow = dsTable.NewRow
                    dsRow("itcd") = lastitcd
                    dsRow("mfg_production_order_line_id") = (New clsConfig).IsNull(lastMfgProductionOrderLineId, DBNull.Value)
                    dsRow("kg_nt") = sum
                    dsset.Tables(0).Rows.Add(dsRow)
                    sum = 0
                    lastitcd = dttt.Rows(i).Item("itcd").ToString.Trim
                    lastMfgProductionOrderLineId = (New clsConfig).IsNull(dttt.Rows(i).Item("mfg_production_order_line_id"), Nothing)
                    sum = dttt.Rows(i).Item("kg_nt")
                End If
            Next
            dsRow = dsTable.NewRow
            dsRow("mfg_production_order_line_id") = (New clsConfig).IsNull(lastMfgProductionOrderLineId, DBNull.Value)
            dsRow("itcd") = lastitcd
            dsRow("kg_nt") = sum
            dsset.Tables(0).Rows.Add(dsRow)
            Return dsset.Tables(0)
        Else
            Return Nothing
        End If
    End Function




    Private Sub btnYIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYIn.Click
        If Cbjobtype.SelectedValue.ToString.Trim = "WARPING" Or Cbjobtype.SelectedValue.ToString.Trim = "KNITTING" Then
            If txtKono.Text.Trim = "" Then
                MessageBox.Show("คุณต้องเลือก เลขที่ Prod No. ก่อนครับ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim selectedYin As String
                Dim formSearchYin As New formSearchYarn
                selectedYin = formSearchYin.getYarnno()
                If selectedYin <> "" Then
                    Me.txtYIn.Text = selectedYin
                    Call getYarnStock()
                End If
                'Me.rdoY_IN.Checked = True 'Comment By Sitthana 20191130
                'Me.txtStock.Text = "" 'Comment By Sitthana 20191130
            End If
        Else

        End If  'Sitthana 20191210

    End Sub

    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click

        If Not CheckDataStock() Then Exit Sub

        Dim frm As New formSearchItemCodeFromBalance
        frm.pKoNo = txtKono.Text.Trim
        frm.pItnaturecd = "ALL"
        frm.pItcd = txtItcd.Text.Trim  'Sitthana 20200131
        frm.ShowDialog()
        If frm.pUserAction = "OK" Then
            Me.txtItcd.Text = frm.pItcd
            selectedItcd = frm.pItcd
            selectedMfgProductionOrderLinesId = frm.pMfgProductionOrderLinesId
            Call getYarnStock()
            Call FilterYarnStock(dtYarnIn)
        End If


    End Sub

    Private Function CheckDataStock() As Boolean
        If (New clsConfig).IsNull(Cbjobtype.SelectedValue, "").ToString.Trim = "" Then
            MessageBox.Show("คุณต้องใส่ เลือก Process ก่อนครับ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If ((New clsConfig).IsNull(Cbjobtype.SelectedValue, "").ToString.Trim = "WARPING" Or (New clsConfig).IsNull(Cbjobtype.SelectedValue, "").ToString.Trim = "KNITTING") And
            txtKono.Text.Trim = "" Then
            MessageBox.Show("คุณต้องใส่ เลขที่ Prod No. ก่อนครับ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub compareTwoGrids()
        Dim i As Integer
        Dim j As Integer

        For i = 0 To Me.DgJobYarndet.Rows.Count - 1
            j = 0
            Do While Me.DgYarnIn.Rows.Count - 1 >= 0 And j <= Me.DgYarnIn.Rows.Count - 1
                If Me.DgYarnIn.Rows(j).Cells("colDgYarnInboxno").Value.ToString.Trim = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetBoxno").Value.ToString.Trim Then
                    Dim dgvRow As New DataGridViewRow
                    dgvRow = Me.DgYarnIn.Rows(j)
                    Me.DgYarnIn.Rows(j).Cells("colDgYarnInSpools").Value = Me.DgYarnIn.Rows(j).Cells("colDgYarnInSpools").Value - Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetSpools").Value
                    Me.DgYarnIn.Rows(j).Cells("colDgYarnInKgNt").Value = Me.DgYarnIn.Rows(j).Cells("colDgYarnInKgNt").Value - Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgNt").Value
                    If Me.DgYarnIn.Rows(j).Cells("colDgYarnInSpools").Value <= 0 Then
                        Me.DgYarnIn.Rows.Remove(dgvRow)
                    End If
                    j = j + 1
                Else
                    j = j + 1
                End If
            Loop
        Next
    End Sub

    Private Sub compareTwoGridsbackone()
        Dim i As Integer
        Dim j As Integer
        'For i = 0 To Me.DgYarnIn.Rows.Count - 2
        For j = 0 To Me.DgJobYarndet.Rows.Count - 1
            If Me.DgJobYarndet.Rows(j).Cells(0).Value = True Then
                For i = 0 To Me.DgYarnIn.Rows.Count - 1
                    If Me.DgJobYarndet.Rows(j).Cells("colDgJobYarndetBoxno").Value.ToString.Trim = Me.DgYarnIn.Rows(i).Cells("colDgYarnInboxno").Value.ToString.Trim Then

                        Me.DgYarnIn.Rows(i).Cells(0).Value = False

                    End If
                Next
            End If
        Next
        'Next
    End Sub

    Private Sub Total_DgjobYarn()
        'Dim i As Integer
        'For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2

        'Next
    End Sub

    Private Sub Btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        printForm()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub textNewitcd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textNewItcd.KeyPress
        If AscW(e.KeyChar) = 13 Then
            Dim GetDatayarn As New GetDataYarn
            Dim tbl_items As New tbl_Items
            Dim ds As New DataSet
            tbl_items.itcd = Me.textNewItcd.Text
            ds = GetDatayarn.GetDataItem(tbl_items)
            If ds.Tables(0).Rows.Count > 0 Then
                'Me.txtfspools.Text = ds.Tables(0).Rows(0).Item("").ToString
                'Me.txtftube.Text = ds.Tables(0).Rows(0).Item("").ToString
                Me.txtftpm.Text = ds.Tables(0).Rows(0).Item("twists").ToString
                Me.Cbcolor.Text = ds.Tables(0).Rows(0).Item("col").ToString
            End If
        End If
    End Sub

    Private Sub calculateSelected()
        Dim sumgross As Double
        Dim sumnet As Double
        Dim sumspools As Double
        Dim sumbox As Integer

        Dim i As Integer
        Dim j As Integer = 0
        Dim kg_gr As Double
        Dim kg_nt As Double
        Dim spools As Double

        ' Try
        Dim countGrid As Integer
        countGrid = Me.DgJobYarndet.Rows.Count
        For i = 0 To Me.DgJobYarndet.Rows.Count - 1
            'If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
            j = j + 1
            spools = oConfig.IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetSpools").Value, 0.00)
            kg_gr = oConfig.IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgGr").Value, 0.00)
            kg_nt = oConfig.IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgNt").Value, 0.00)
            sumgross = sumgross + kg_gr
            sumnet = sumnet + kg_nt
            sumspools = sumspools + spools
            sumbox = j
            'End If
        Next
        Me.txtbox.Text = sumbox
        Me.txtspools.Text = sumspools
        Me.txtkg_gr.Text = sumgross
        Me.txtkg_nt.Text = sumnet
        '  Catch ex As Exception
        ' MsgBox(ex.Message)
        '  End Try
    End Sub

    Private Sub textKono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKono.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getProductionItem()
            If txtjobno.Text.Trim <> "" Then
                If (New classJobOrderYarn).ValidateChangedKoNo(pJobNo:=txtjobno.Text.Trim, pKono:=txtKono.Text.Trim, logempcd:=clsUserInfo.UserID) Then
                    Dim result As DialogResult
                    result = MessageBox.Show("คุณกำลัง เปลี่ยน K/O No. " & vbCrLf & "โปรแกรมจะดึง GB No. และ Production Order Line ID ตามบอมใน K/I ให้อัตโนมัติ ",
                       "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
                    Me.ErrorProvider1.SetError(Me.txtKono, "คุณกำลังแก้ไข K/O No.")
                    Call ChangeProductionOrderLineID()
                End If
            End If
        End If
    End Sub

    Private Sub txtKono_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKono.Validated
        If (New clsConfig).IsNull(Cbjobtype.SelectedValue, "").ToString.Trim = "KNITTING" Or (New clsConfig).IsNull(Cbjobtype.SelectedValue, "").ToString.Trim = "WARPING" Then
            If Not txtKono.Text.Trim = "" Then
                Call ValidateKono()
            End If
            Call getProductionItem()
            If txtjobno.Text.Trim <> "" Then
                If (New classJobOrderYarn).ValidateChangedKoNo(pJobNo:=txtjobno.Text.Trim, pKono:=txtKono.Text.Trim, logempcd:=clsUserInfo.UserID) Then
                    Dim result As DialogResult
                    result = MessageBox.Show("คุณกำลัง เปลี่ยน K/O No. " & vbCrLf & "โปรแกรมจะดึง GB No. และ Production Order Line ID ตามบอมใน K/I ให้อัตโนมัติ ",
                       "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
                    Me.ErrorProvider1.SetError(Me.txtKono, "คุณกำลังแก้ไข K/O No.")
                    Call ChangeProductionOrderLineID()
                End If
            End If
        Else
            Me.ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub ChangeProductionOrderLineID()

        For i = 0 To DgJobYarndet.Rows.Count - 1
            DgJobYarndet.Rows(i).Cells("colDgJobYarndetMfgProductionOrderLinesId").Value = (New clsConfig).IsNull((New classJobOrderYarn).GetProductionOrderLineId(pKoNo:=txtKono.Text.Trim, pItcd:=DgJobYarndet.Rows(i).Cells("colDgJobYarndetItcd").Value), DBNull.Value)
            DgJobYarndet.Rows(i).Cells("colDgJobYarndetGb").Value = (New clsConfig).IsNull((New classJobOrderYarn).GetGBNo(pKoNo:=txtKono.Text.Trim, pItcd:=DgJobYarndet.Rows(i).Cells("colDgJobYarndetItcd").Value), DBNull.Value)
        Next

        ' DgJobYarndet.EndEdit()
        '  DgJobYarndet.Refresh()
        Call GenDgvGroup()
    End Sub

    Private Sub Cbjobtype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbjobtype.Validated

    End Sub

    Private Function ValidateKono() As Boolean
        'If txtKono.Text = "" Then Return False
        Dim cmdKo As New SqlCommand
        Dim m_Kono As String = Me.txtKono.Text
        Dim m_Kono_Found As String
        Dim cn As New SqlConnection
        cn.ConnectionString = oConn.Connection
        cmdKo.Connection = cn
        cn.Open()
        cmdKo.CommandText = "Select Kono from Ko where kono = '" & m_Kono & "'"
        m_Kono_Found = cmdKo.ExecuteScalar
        If (New clsConfig).IsNull(m_Kono_Found, "") = "" Then
            'Sitthana 20191204
            MessageBox.Show("ไม่พบเลขที่ KO No " & m_Kono.Trim.ToUpper, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.ErrorProvider1.SetError(Me.txtKono, "Enter a valid K/O")
            txtKono.Text = ""
            cn.Close()
            Exit Function
            Return False
        End If

        Me.ErrorProvider1.Clear()
        cn.Close()

        Return True
    End Function


    Private Sub getYarnStock()
        Dim msgerr As String = ""
        Dim getDataYarn As New classJobOrderYarn

        If Me.txtItcd.Text.Trim <> "" Or txtYIn.Text.Trim <> "" Then
            dtYarnIn = getDataYarn.GetYarnBalance(Me.txtYIn.Text.Trim, Me.txtItcd.Text.Trim, txtKono.Text.Trim, selectedMfgProductionOrderLinesId, msgerr)

            dtYarnIn.DefaultView.Sort = "itcd asc"
            If Not IsNothing(dtYarnIn) Then
                Me.DgYarnIn.DataSource = dtYarnIn
            Else
                Me.DgYarnIn.DataSource = dtYarnIn
                MsgBox("Can not found")
            End If
            Call compareTwoGrids()
        End If


    End Sub

    Private Function CheckItemsCode() As Boolean

        If Not (New classJobOrderYarn).ValidateItems(txtKono.Text.Trim, txtItcd.Text.Trim, clsUserInfo.UserID) Then
            Return False
        End If


        Return True
    End Function

    Private Function CheckItemsCountMoreThenOne() As Integer

        Return (New classJobOrderYarn).ItemsCount(txtKono.Text.Trim, txtItcd.Text.Trim, clsUserInfo.UserID)
    End Function


    Private Sub btnSearchKI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchKI.Click
        Dim formSearchKi As New formSearchKO
        Dim selectedKono As String
        selectedKono = formSearchKi.getKono
        If formSearchKi.pUserAction = "OK" Then
            Me.txtKono.Text = selectedKono.Trim
            Call ValidateKono()
            Call getProductionItem()
            If (New classJobOrderYarn).ValidateChangedKoNo(pJobNo:=txtjobno.Text.Trim, pKono:=txtKono.Text.Trim, logempcd:=clsUserInfo.UserID) Then
                Dim result As DialogResult
                result = MessageBox.Show("คุณกำลัง เปลี่ยน K/O No. " & vbCrLf & "โปรแกรมจะดึง GB No. และ Production Order Line ID ตามบอมใน K/I ให้อัตโนมัติ ",
                   "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
                Call ChangeProductionOrderLineID()
            End If
        End If

    End Sub
    Private Sub getProductionItem()
        Dim objGetDataYarn As New GetDataYarn
        Dim dt As DataTable
        ' Dim txtkono As String = ""
        Dim txtkono = Me.txtKono.Text
        'Validate_kono()
        dt = objGetDataYarn.getProductionItem(txtkono)
        If dt.Rows.Count > 0 Then
            textNewItcd.Text = dt.Rows(0)("design_no")
            If (New clsConfig).IsNull(Cbjobtype.SelectedValue, "") = "" Then Cbjobtype.SelectedValue = dt.Rows(0)("tran_type")
            'Else
            ' MsgBox("Prod no. is not found", MsgBoxStyle.OkOnly, "Search")

        End If
    End Sub
    Private Sub removeRowFromGrid(ByVal dtSource As DataTable)
        Dim i As Integer = 0
        If Not dtSource Is Nothing Then
            If dtSource.Rows.Count > 0 Then
                i = 0
                Do While dtSource.Rows.Count > 0
                    For i = 0 To dtSource.Rows.Count - 1
                        dtJob.Rows(i).Delete()
                    Next
                Loop
            End If
        End If
        DgJobYarndet.Refresh()
    End Sub

    Private Sub rdStock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdStock.CheckedChanged
        If Me.rdStock.Checked Then
            txtYIn.Text = ""
            txtYIn.ReadOnly = True
            btnYIn.Enabled = False
            txtItcd.ReadOnly = False
            btnStock.Enabled = True
        End If
    End Sub

    Private Sub rdYIn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdYIn.CheckedChanged
        If Me.rdYIn.Checked Then
            txtItcd.Text = ""
            txtYIn.ReadOnly = False
            btnYIn.Enabled = True
            txtItcd.ReadOnly = True
            btnStock.Enabled = False
        End If
    End Sub

    Private Sub btnFindJob_no_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindJob_no.Click

        Call showSearchForm()

    End Sub

    Private Sub loadJobData()
        Dim dsset As New DataSet
        setFormMode("EDIT")

        dtJob = ds.Tables("job")
        Me.DgJobYarndet.DataSource = dtJob
        Call DisableControl()

        Call fetchJobData()

    End Sub
    Private Sub EnableControl()
        'BtnSave.Enabled = True
    End Sub
    Private Sub DisableControl()
        Cbjobtype.Enabled = False
        '  BtnSave.Enabled = False
    End Sub

    Private Function validJobno() As Boolean
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter(cmd)

        cn.ConnectionString = oConn.Connection
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_job_exists"
        cmd.Parameters.AddWithValue("@jobno", Me.txtjobno.Text.Trim)

        Try
            cmd.ExecuteNonQuery()
            cn.Close()
            validJobno = True
        Catch ex As Exception
            validJobno = False
        End Try


    End Function

    Private Function ValidateJobno(ByRef pMessage As String) As Boolean
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter(cmd)

        cn.ConnectionString = oConn.Connection
        cn.Open()
        cmd.Connection = cn
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "P_JOBORDER_YARN_PKG_validate_jobno"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@jobno", Me.txtjobno.Text.Trim)
        cmd.Parameters.Add("@p_jobno_exists", SqlDbType.Bit)
        cmd.Parameters("@p_jobno_exists").Direction = ParameterDirection.Output
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            cn.Close()
        Catch ex As Exception
            pMessage = ex.Message
            cn.Close()
        End Try

        ValidateJobno = cmd.Parameters("@p_jobno_exists").Value
        'Return comm.Parameters("@gb").Value
    End Function
    Private Sub fetchJobData()
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection
        cn.ConnectionString = oConn.Connection
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "p_job_select"

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@jobno", Me.txtjobno.Text.Trim)
        Dim da As New SqlDataAdapter(cmd)
        If Not ds.Tables("job") Is Nothing Then
            ds.Tables("job").Clear()
        End If
        da.Fill(ds, "job")

        Me.dtpjobdt.Value = ds.Tables("job").Rows(0).Item("jobdt").ToString.Trim
        txtSupplierCode.Text = ds.Tables("job").Rows(0).Item("suppcd").ToString.Trim
        txtSupplierName.Text = clsMaster.GetSupplier(txtSupplierCode.Text.Trim).Rows(0)("name")
        Me.Cbjobtype.SelectedValue = ds.Tables("job").Rows(0).Item("jobtype").ToString.Trim
        Me.txtKono.Text = ds.Tables("job").Rows(0).Item("kono").ToString.Trim
        Me.textNewItcd.Text = ds.Tables("job").Rows(0).Item("jobitcd").ToString.Trim
        Me.txtfspools.Text = ds.Tables("job").Rows(0).Item("tubeqty").ToString.Trim
        Me.txtftube.Text = ds.Tables("job").Rows(0).Item("tubekg").ToString.Trim
        Me.txtftpm.Text = ds.Tables("job").Rows(0).Item("twists").ToString.Trim
        Me.Cbcolor.SelectedValue = ds.Tables("job").Rows(0).Item("col").ToString.Trim
        Me.txtStatus.Text = ds.Tables("job").Rows(0).Item("present_status").ToString.Trim
        Me.txtremark.Text = ds.Tables("job").Rows(0).Item("rem").ToString.Trim

        If ds.Tables("job").Rows(0).Item("present_status").ToString.Trim = "CANCELLED" Then
            Me.toolStripBtnSave.Enabled = False
            Me.btnApprove.Enabled = False
            txtRemApprove.Enabled = False
        ElseIf ds.Tables("job").Rows(0).Item("present_status").ToString.Trim = "UN-APP" Then
            'Or ds.Tables("job").Rows(0).Item("present_status").ToString.Trim = "APPROVED" Then
            Me.toolStripBtnSave.Enabled = True
            Me.btnApprove.Enabled = True
            Me.txtRemApprove.Enabled = True
        ElseIf ds.Tables("job").Rows(0).Item("present_status").ToString.Trim = "APPROVED" Then
            Me.toolStripBtnSave.Enabled = True
            Me.btnApprove.Enabled = False
            Me.txtRemApprove.Enabled = False
        End If

        fetchJobDetailData()
        fetchJobDetailYarnData()
        calculateSelected()
    End Sub
    Private Sub fetchJobDetailData()
        Dim dtJobdet As DataTable = (New classJobOrderYarn).GetJobDet(Me.txtjobno.Text.Trim)
        dgJobDet.AutoGenerateColumns = False
        dgJobDet.DataSource = dtJobdet

    End Sub
    Private Sub fetchJobDetailYarnData()
        '************************************************************************
        Dim strsql3 As String = ""
        strsql3 = "select * from v_job_yarn where jobno = '" & Me.txtjobno.Text.Trim & "'"
        Dim da1 As New SqlDataAdapter(strsql3.ToString, oConn.Connection)
        If Not ds.Tables("jobdet") Is Nothing Then
            If ds.Tables("jobdet").Rows.Count > 0 Then
                ds.Tables("jobdet").Clear()
            End If
        End If
        da1.Fill(ds, "JobDet")

        If Not ds.Tables("jobdet") Is Nothing Then
            If ds.Tables("jobdet").Rows.Count > 0 Then
                txtSoNo.Text = ds.Tables("jobdet").Rows(0).Item("sono").ToString.Trim
                txtSoNoId.Text = ds.Tables("jobdet").Rows(0).Item("sonoid").ToString.Trim
                txtItcd.Text = ds.Tables("jobdet").Rows(0).Item("itcd").ToString.Trim
            End If
        End If

        dtJob = ds.Tables("JobDet")
        Me.DgJobYarndet.DataSource = dtJob

        calculateSelected()

    End Sub
    Private Sub calculateSelection()
        Dim sumgross As Double = 0.00
        Dim sumnet As Double = 0.00
        Dim sumspools As Double = 0.00
        Dim sumbox As Integer = 0.00

        Dim i As Integer
        Dim j As Integer = 0
        Dim kg_gr As Double = 0.00
        Dim kg_nt As Double = 0.00
        Dim spools As Double = 0.00

        ' Try
        Dim countGrid As Integer
        countGrid = Me.DgYarnIn.Rows.Count
        For i = 0 To Me.DgYarnIn.Rows.Count - 1

            If Me.DgYarnIn.Rows(i).Cells("DGV_show").Value = True Then
                j = j + 1
                spools = oConfig.IsValidDouble(Me.DgYarnIn.Rows(i).Cells("colDgYarnInSpools").Value)
                kg_gr = oConfig.IsValidDouble(Me.DgYarnIn.Rows(i).Cells("colDgYarnInKgGr").Value)
                kg_nt = oConfig.IsValidDouble(Me.DgYarnIn.Rows(i).Cells("colDgYarnInKgNt").Value)
                sumgross = sumgross + kg_gr
                sumnet = sumnet + kg_nt
                sumspools = sumspools + spools
                sumbox = j

            End If
        Next

        Me.textBoxSel.Text = sumbox
        Me.textSpoolsSel.Text = sumspools
        Me.textKg_GrSel.Text = sumgross
        Me.textKg_NtSel.Text = sumnet

        '  Catch ex As Exception
        '  MsgBox(ex.Message)
        '  End Try
    End Sub

    Private Sub DgYarnIn_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarnIn.CellValueChanged
        calculateSelection()
        calculateActualConeWeight(e)
    End Sub
    Private Sub calculateActualConeWeight(ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        'If DgYarnIn.Rows(e.RowIndex).Cells Then

    End Sub


    Private Sub DgYarnIn_CurrentCellDirtyStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgYarnIn.CurrentCellDirtyStateChanged
        If DgYarnIn.IsCurrentCellDirty Then
            DgYarnIn.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub Dg_jobYarndet_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgJobYarndet.CellValueChanged
        If DgJobYarndet.Rows.Count = 0 Then Exit Sub
        Dim currentColIndex As Integer = DgJobYarndet.CurrentCell.ColumnIndex
        Dim currentColName As String = DgJobYarndet.Columns(currentColIndex).Name
        Dim dgr As DataGridViewRow = DgJobYarndet.CurrentRow
        If currentColName = "colDgJobYarndetKgNt" Or currentColName = "colDgJobYarndetLotnoOur" Then
            Call compareTwoGrids()
            Call calculateSelected()
            Call calculateSelection()
            'Call calculateSelectedItem()
            Call getYarnStock()
            Call GenDgvGroup()
        End If

    End Sub
    Private Sub saveNewJob()
        Dim config As New clsConfig
        config.ChangeCulture()

        Dim i As Integer = 0
        Dim InsertYarn As New InsertYarn
        ' Dim isvalid As Boolean
        Dim tbl_job As New tbl_job
        'calculateSelected()
        ' Try

        tbl_job.jobdt = Me.dtpjobdt.Value.ToString("yyy/MM/dd")
        tbl_job.suppcd = txtSupplierCode.Text.Trim 'Sitthana 20191129
        tbl_job.jobtype = Me.Cbjobtype.SelectedValue
        tbl_job.kono = Me.txtKono.Text.ToUpper.Trim
        tbl_job.jobitcd = textNewItcd.Text
        tbl_job.tubeqty = Val(Me.txtfspools.Text)
        tbl_job.tubekg = Val(Me.txtftube.Text)
        tbl_job.twists = Me.txtftpm.Text
        tbl_job.col = Me.Cbcolor.SelectedValue
        tbl_job.remark = Me.txtremark.Text
        tbl_job.import = 0
        tbl_job.cancel_status = 0
        tbl_job.empcd = clsUser.UserID

        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        Dim dsRow As DataRow
        'Dim dt As DataTable
        'dsset.Clear()
        dsTable = dsset.Tables.Add
        dsTable.Columns.Add("mfg_production_order_line_id", GetType(Int64))
        dsTable.Columns.Add("itcd", GetType(String))
        dsTable.Columns.Add("grade", GetType(String))
        dsTable.Columns.Add("boxno", GetType(String))
        dsTable.Columns.Add("spools", GetType(String))
        dsTable.Columns.Add("kg_gr", GetType(Double))
        dsTable.Columns.Add("kg_nt", GetType(Double))
        dsTable.Columns.Add("actual_cone_weight", GetType(Decimal))
        dsTable.Columns.Add("lotno_our", GetType(String))
        dsTable.Columns.Add("gb", GetType(String))
        If Not IsNothing(dtYarnIn) Then
            For i = 0 To Me.DgJobYarndet.Rows.Count - 1
                'If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
                dsRow = dsTable.NewRow
                dsRow("mfg_production_order_line_id") = (New clsConfig).IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetMfgProductionOrderLinesId").Value, DBNull.Value) '.ToString
                dsRow("itcd") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetitcd").Value.ToString
                dsRow("grade") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetGrade").Value.ToString
                dsRow("boxno") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetboxno").Value.ToString
                dsRow("spools") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetSpools").Value.ToString
                dsRow("kg_gr") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgGr").Value.ToString
                dsRow("kg_nt") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgNt").Value.ToString
                dsRow("actual_cone_weight") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetActualConeWeight").Value
                dsRow("lotno_our") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetLotnoOur").Value
                dsRow("gb") = oConfig.IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetGb").Value, "")
                dsset.Tables(0).Rows.Add(dsRow)
                'End If
            Next
        End If

        Dim j As Integer = 0
        Dim dtJobDet As DataTable = dgJobDet.DataSource
        For Each dr In dtJobDet.Rows
            ReDim Preserve tbl_job.tbl_job_det(j)
            tbl_job.tbl_job_det(j) = New tbl_job_det

            tbl_job.tbl_job_det(j).itcd = dr.Item("itcd") 'As String
            tbl_job.tbl_job_det(j).qty = dr.Item("qty")   'As Double
            tbl_job.tbl_job_det(j).sono = txtSoNo.Text.Trim 'Sitthana 20191129
            tbl_job.tbl_job_det(j).sonoid = txtSoNoId.Text.Trim 'Sitthana 20191129
            tbl_job.tbl_job_det(j).mfg_production_order_line_id = (New clsConfig).IsNull(dr.Item("mfg_production_order_line_id"), Nothing)
            j = j + 1
        Next

        Dim k As Integer = 0
        For i = 0 To Me.DgJobYarndet.Rows.Count - 1
            'If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
            ReDim Preserve tbl_job.tbl_job_det_yarn(k)
            tbl_job.tbl_job_det_yarn(k) = New tbl_job_det_yarn
            tbl_job.tbl_job_det_yarn(k).itcd = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetItcd").Value.ToString 'As String
            tbl_job.tbl_job_det_yarn(k).boxno = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetBoxno").Value.ToString    'As String
            tbl_job.tbl_job_det_yarn(k).spools = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetSpools").Value.ToString   'As Double
            tbl_job.tbl_job_det_yarn(k).kg_gr = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgGr").Value.ToString    'As Double
            tbl_job.tbl_job_det_yarn(k).kg_nt = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgNt").Value.ToString    'As Double
            tbl_job.tbl_job_det_yarn(k).actual_cone_weight = oConfig.IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetActualConeWeight").Value, 0)
            tbl_job.tbl_job_det_yarn(k).lotno_our = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetLotnoOur").Value.ToString
            tbl_job.tbl_job_det_yarn(k).gb = oConfig.IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetGb").Value, "")
            tbl_job.tbl_job_det_yarn(k).sono = txtSoNo.Text.Trim
            tbl_job.tbl_job_det_yarn(k).sonoid = txtSoNoId.Text.Trim
            tbl_job.tbl_job_det_yarn(k).mfg_production_order_line_id = (New clsConfig).IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetMfgProductionOrderLinesId").Value, Nothing)
            k = k + 1
            'End If
        Next

        Dim msgerr As String = ""
        If InsertYarn.InsertJobOrderforYarnNew(tbl_job, msgerr, clsUser.UserID) Then
            txtjobno.Text = tbl_job.jobno
            MessageBox.Show("Save Completed" & vbCrLf & tbl_job.jobno, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call loadJobData()
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Function CHECKDATA() As Boolean
        Dim ErrMsg As String = ""


        If (New clsConfig).IsNull(Cbjobtype.SelectedValue, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose Process !!" & vbCrLf & "คุณ ต้อง เลือก Process", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return False
        End If

        If (New clsConfig).IsNull(Cbjobtype.SelectedValue, "").ToString.Trim = "SALES" Then
            'Check Only type = "Sales"
            'If (New clsConfig).IsNull(cboSoNo.SelectedValue, "").ToString.Trim = "" Then
            '    MessageBox.Show("Please choose Sales Order No.!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    ErrorProvider1.SetError(cboSoNo, "Please choose Sales Order No.!!")
            '    CHECKDATA = False
            '    Exit Function
            'End If
            If txtSoNo.Text.Trim = "" Then
                ErrMsg = "Please choose Sales Order No."
                MessageBox.Show("Please choose Sales Order No.!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                ErrorProvider1.SetError(txtSoNo, "Please choose Sales Order No.!!")
                Return False
                'Exit Function
            End If

            For Each row As DataGridViewRow In DgJobYarndet.Rows

                If Not row.Cells("colDgJobYarndetItcd").Value.ToString.Trim = txtItcd.Text.Trim Then
                    If ErrMsg.Trim <> "" Then
                        ErrMsg &= vbCr
                    End If
                    ErrMsg &= "Line " & row.ToString & "). S/O Item Incorrect"
                    ErrorProvider1.SetError(txtSoNoId, "S/O Item Incorrect!!")
                    Return False
                End If
            Next
        End If

        If txtSupplierCode.Text.Trim = "" Then
            If ErrMsg.Trim <> "" Then
                ErrMsg &= vbCr
            End If
            ErrMsg &= "Supplier Code don't blank"
            ErrorProvider1.SetError(txtSupplierCode, "Supplier Code don't blank")
            Return False
        End If

        If ErrMsg.Trim <> "" Then
            MessageBox.Show("ข้อผิดพลาด" & vbCr & ErrMsg, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        'CHECKDATA = True 'Comment By Sitthana 20191223
        ' Return CHECKDATA 'Sitthana 20191223
        Return True
    End Function
    Private Function updateJob() As Boolean
        Dim config As New clsConfig
        Dim m_jobno As String
        Dim m_jobdt As Date
        Dim m_suppcd As String
        Dim m_kono As String
        Dim m_jobtype As String
        Dim m_jobitcd As String
        Dim m_tubeqty As Integer
        Dim m_tubekg As Decimal
        Dim m_twists As String
        Dim m_col As String
        Dim m_remark As String
        'Dim tbl_job As New tbl_job

        'tbl_job.empcd = loginEmpcd

        config.ChangeCulture()

        '-------
        m_jobno = Me.txtjobno.Text.Trim
        m_jobdt = IIf(IsDate(dtpjobdt.Text), CDate(dtpjobdt.Text), Today())
        m_suppcd = txtSupplierCode.Text.Trim 'Sitthana 20191129
        m_jobtype = Me.Cbjobtype.SelectedValue
        m_kono = Me.txtKono.Text.ToUpper.Trim
        m_jobitcd = textNewItcd.Text
        m_tubeqty = Val(Me.txtfspools.Text)
        m_tubekg = Val(Me.txtftube.Text)
        m_twists = Me.txtftpm.Text
        m_col = Me.Cbcolor.SelectedValue
        m_remark = Me.txtremark.Text

        '--------

        Dim deletedRecs As New DataView(dtJob, "", "", DataViewRowState.Deleted)
        Dim modifiedRecs As New DataView(dtJob, "", "", DataViewRowState.ModifiedCurrent)
        Dim newRecs As New DataView(dtJob, "", "", DataViewRowState.Added)

        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter(cmd)
        Dim classCn As New classConnection
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim tran As SqlTransaction
        Dim row As DataRowView

        cn.ConnectionString = classCn.Connection
        cn.Open()
        cmd.Connection = cn
        tran = cn.BeginTransaction
        cmd.Transaction = tran

        ' update job header table
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "P_JOBORDER_YARN_PKG_update_job"
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@jobno", m_jobno)
        cmd.Parameters.AddWithValue("@jobdt", m_jobdt)
        cmd.Parameters.AddWithValue("@suppcd", m_suppcd)
        cmd.Parameters.AddWithValue("@kono", m_kono)
        cmd.Parameters.AddWithValue("@jobtype", m_jobtype)
        cmd.Parameters.AddWithValue("@jobitcd", m_jobitcd)
        cmd.Parameters.AddWithValue("@tubeqty", m_tubeqty)
        cmd.Parameters.AddWithValue("@tubekg", m_tubekg)
        cmd.Parameters.AddWithValue("@twists", m_twists)
        cmd.Parameters.AddWithValue("@col", m_col)
        cmd.Parameters.AddWithValue("@rem", m_remark)
        cmd.Parameters.AddWithValue("@log_empcd", clsUser.UserID)

        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            tran.Rollback()
            MsgBox(ex.Message.ToString)
            cn.Close()
            Return False
        End Try

        '---------------   Incruse Insert & Update Job Det ------------
        Dim tbl_job As New tbl_job
        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        Dim dsRow As DataRow

        dsTable = dsset.Tables.Add
        dsTable.Columns.Add("itcd", GetType(String))
        dsTable.Columns.Add("grade", GetType(String))
        dsTable.Columns.Add("boxno", GetType(String))
        dsTable.Columns.Add("spools", GetType(String))
        dsTable.Columns.Add("kg_gr", GetType(String))
        dsTable.Columns.Add("kg_nt", GetType(String))
        dsTable.Columns.Add("actual_cone_weight", GetType(Decimal))
        dsTable.Columns.Add("lotno_our", GetType(String))
        dsTable.Columns.Add("gb", GetType(String))
        dsTable.Columns.Add("id_job_det", GetType(Int64))
        dsTable.Columns.Add("mfg_production_order_line_id", GetType(Int64))
        'If Not IsNothing(dts) Then
        For i = 0 To Me.DgJobYarndet.Rows.Count - 1
            dsRow = dsTable.NewRow
            dsRow("itcd") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetItcd").Value.ToString
            dsRow("grade") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetGrade").Value.ToString
            dsRow("boxno") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetBoxno").Value.ToString
            dsRow("spools") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetSpools").Value.ToString
            dsRow("kg_gr") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgGr").Value.ToString
            dsRow("kg_nt") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgNt").Value.ToString
            dsRow("actual_cone_weight") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetActualConeWeight").Value '.ToString
            dsRow("lotno_our") = Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetLotnoOur").Value.ToString
            dsRow("gb") = oConfig.IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetGb").Value, "")
            dsRow("id_job_det") = (New clsConfig).IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetIdJobDet").Value, 0)
            dsRow("mfg_production_order_line_id") = (New clsConfig).IsNull(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetMfgProductionOrderLinesId").Value, DBNull.Value)
            dsset.Tables(0).Rows.Add(dsRow)
        Next

        Dim j As Integer = 0
        Dim dtJobDet As DataTable = dgJobDet.DataSource
        For Each dr In dtJobDet.Rows
            ReDim Preserve tbl_job.tbl_job_det(j)
            tbl_job.tbl_job_det(j) = New tbl_job_det
            tbl_job.tbl_job_det(j).jobno = txtjobno.Text.Trim 'JB2002017
            tbl_job.tbl_job_det(j).id_jobdet = (New clsConfig).IsNull(dr.Item("id_jobdet"), 0) '73734
            tbl_job.tbl_job_det(j).itcd = dr.Item("itcd") 'As String
            tbl_job.tbl_job_det(j).qty = dr.Item("qty")   'As Double
            tbl_job.tbl_job_det(j).sono = txtSoNo.Text.Trim 'Sitthana 20191129
            tbl_job.tbl_job_det(j).sonoid = txtSoNoId.Text.Trim 'Sitthana 20191129
            tbl_job.tbl_job_det(j).mfg_production_order_line_id = (New clsConfig).IsNull(dr.Item("mfg_production_order_line_id"), Nothing)
            j = j + 1
        Next

        'Update and Insert 
        For Each tbl_job_det In tbl_job.tbl_job_det
            With tbl_job_det
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "P_JOBORDER_YARN_PKG_update_job_det" 'Insert And Update
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@jobno", .jobno.Trim)
                cmd.Parameters.AddWithValue("@id_jobdet", (New clsConfig).IsNull(.id_jobdet, 0))
                cmd.Parameters.AddWithValue("@itcd", .itcd.Trim)
                cmd.Parameters.AddWithValue("@qty", .qty)
                cmd.Parameters.AddWithValue("@sono", .sono.Trim)
                cmd.Parameters.AddWithValue("@sonoid", .sonoid.Trim)
                cmd.Parameters.AddWithValue("@mfg_production_order_line_id", (New clsConfig).IsNull(.mfg_production_order_line_id, DBNull.Value))

                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    tran.Rollback()
                    MsgBox(ex.Message.ToString)
                    cn.Close()
                    Return False
                End Try

                '  drJobdet("id_jobdet") = dt.Rows(0)("id_jobdet")
                tbl_job_det.id_jobdet = dt.Rows(0)("id_jobdet")
                ' tbl_job_det.mfg_production_order_line_id = dt.Rows(0)("mfg_production_order_line_id")

            End With
        Next


        For Each row In deletedRecs
            'Try
            Dim m_id_job_det_yarn As String
            Dim m_id_job_det As String
            m_id_job_det_yarn = row.Item("id_job_det_yarn")
            m_id_job_det = row.Item("id_job_det")
            cmd.CommandText = "P_JOBORDER_YARN_PKG_delete_job_det_yarn"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("id_job_det_yarn", m_id_job_det_yarn)
            cmd.Parameters.AddWithValue("id_job_det", m_id_job_det)

            da = New SqlDataAdapter(cmd)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                tran.Rollback()
                MsgBox(ex.Message.ToString)
                cn.Close()
                Return False
            End Try
            'delete records
        Next

        '=================================== Disible By Neung 20200817 ==================================
        'For Each row In modifiedRecs
        '    Dim m_id_job_det_yarn As Integer
        '    Dim m_id_job_det As Integer
        '    Dim m_spools As String
        '    Dim m_kg_gr As Decimal
        '    Dim m_kg_nt As Decimal
        '    Dim m_actual_cone_weight As Nullable(Of Decimal)
        '    Dim m_gb As String
        '    Dim m_lotno_our As String
        '    Dim m_sono As String
        '    Dim m_sonoid As String
        '    Dim m_mfg_production_order_line_id As Nullable(Of Int64)

        '    m_id_job_det_yarn = row("id_job_det_yarn")
        '    m_id_job_det = row("id_job_det")
        '    m_spools = row("spools")
        '    m_kg_gr = row("kg_gr")
        '    m_kg_nt = row("kg_nt")
        '    m_actual_cone_weight = row("actual_cone_weight")
        '    m_lotno_our = row("lotno_our")
        '    m_gb = row("gb")
        '    m_sono = (New clsConfig).IsNull(row("sono"), Nothing)
        '    m_sonoid = (New clsConfig).IsNull(row("sonoid"), Nothing)
        '    m_mfg_production_order_line_id = (New clsConfig).IsNull(row("mfg_production_order_line_id"), Nothing)

        '    cmd.CommandText = "P_JOBORDER_YARN_PKG_update_job_det_yarn"
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Clear()
        '    cmd.Parameters.AddWithValue("@id_job_det_yarn", (New clsConfig).IsNull(m_id_job_det_yarn, DBNull.Value))
        '    cmd.Parameters.AddWithValue("@id_job_det", (New clsConfig).IsNull(m_id_job_det, DBNull.Value))
        '    cmd.Parameters.AddWithValue("@spools", m_spools)
        '    cmd.Parameters.AddWithValue("@kg_gr", m_kg_gr)
        '    cmd.Parameters.AddWithValue("@kg_nt", m_kg_nt)
        '    cmd.Parameters.AddWithValue("@actual_cone_weight", m_actual_cone_weight)
        '    cmd.Parameters.AddWithValue("@lotno_our", m_lotno_our)
        '    cmd.Parameters.AddWithValue("@gb", m_gb)
        '    cmd.Parameters.AddWithValue("@sono", m_sono)
        '    cmd.Parameters.AddWithValue("@sonoid", m_sonoid)
        '    cmd.Parameters.AddWithValue("@mfg_production_order_line_id", (New clsConfig).IsNull(m_mfg_production_order_line_id, DBNull.Value))
        '    da = New SqlDataAdapter(cmd)
        '    dt = New DataTable
        '    Try
        '        da.Fill(dt)
        '    Catch ex As Exception
        '        tran.Rollback()
        '        MsgBox(ex.Message.ToString)
        '        cn.Close()
        '        Return False
        '    End Try
        'Next


        'For Each row In newRecs
        '    Dim m_id_jobdet As String
        '    Dim m_itcd As String
        '    Dim m_boxno As String
        '    Dim m_spools As Integer
        '    Dim m_kg_gr As Decimal
        '    Dim m_kg_nt As Decimal
        '    Dim m_actual_cone_weight As Nullable(Of Decimal)
        '    Dim m_lotno_our As String
        '    Dim m_gb As String
        '    Dim m_sono As String
        '    Dim m_sonoid As String
        '    Dim m_mfg_production_order_line_id As Nullable(Of Int64)

        '    m_jobno = Me.txtjobno.Text.Trim
        '    m_id_jobdet = row("id_job_det")
        '    m_itcd = row("itcd")
        '    m_boxno = row("boxno")
        '    m_spools = row("spools")
        '    m_kg_gr = row("kg_gr")
        '    m_kg_nt = row("kg_nt")
        '    m_actual_cone_weight = row("actual_cone_weight")
        '    m_lotno_our = row("lotno_our")
        '    m_gb = row("gb")
        '    m_sono = (New clsConfig).IsNull(row("sono"), Nothing)
        '    m_sonoid = (New clsConfig).IsNull(row("sonoid"), Nothing)
        '    m_mfg_production_order_line_id = (New clsConfig).IsNull(row("mfg_production_order_line_id"), Nothing)

        '    For Each tbl_job_det In tbl_job.tbl_job_det
        '        With tbl_job_det
        '            If tbl_job_det.itcd = m_itcd Then
        '                If tbl_job_det.mfg_production_order_line_id = m_mfg_production_order_line_id Then
        '                    cmd.CommandText = "P_JOBORDER_YARN_PKG_insert_job_det_yarn"
        '                    cmd.CommandType = CommandType.StoredProcedure
        '                    cmd.Parameters.Clear()
        '                    cmd.Parameters.AddWithValue("@id_job_det", tbl_job_det.id_jobdet) '
        '                    cmd.Parameters.AddWithValue("@itcd", m_itcd) '
        '                    cmd.Parameters.AddWithValue("@boxno", m_boxno) '
        '                    cmd.Parameters.AddWithValue("@spools", m_spools) '
        '                    cmd.Parameters.AddWithValue("@kg_gr", m_kg_gr) '
        '                    cmd.Parameters.AddWithValue("@kg_nt", m_kg_nt) '
        '                    cmd.Parameters.AddWithValue("@actual_cone_weight", m_actual_cone_weight) '
        '                    cmd.Parameters.AddWithValue("@lotno_our", m_lotno_our) '
        '                    cmd.Parameters.AddWithValue("@gb", m_gb) '
        '                    cmd.Parameters.AddWithValue("@sono", m_sono) '
        '                    cmd.Parameters.AddWithValue("@sonoid", m_sonoid) '
        '                    cmd.Parameters.AddWithValue("@mfg_production_order_line_id", (New clsConfig).IsNull(m_mfg_production_order_line_id, DBNull.Value)) '

        '                    da = New SqlDataAdapter(cmd)
        '                    dt = New DataTable
        '                    Try
        '                        da.Fill(dt)
        '                    Catch ex As Exception
        '                        tran.Rollback()
        '                        MsgBox(ex.Message.ToString)
        '                        cn.Close()
        '                        Return False
        '                    End Try
        '                End If
        '            End If
        '        End With
        '    Next
        'Next

        '=================================== Add By Neung 20200817 ==================================
        For Each dr As DataRow In dtJob.Rows
            If dr.RowState <> DataRowState.Deleted Then
                cmd.CommandText = "P_JOBORDER_YARN_PKG_update_job_det_yarn"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id_job_det_yarn", dr("id_job_det_yarn"))
                cmd.Parameters.AddWithValue("@id_job_det", dr("id_job_det"))
                cmd.Parameters.AddWithValue("@itcd", dr("itcd"))
                cmd.Parameters.AddWithValue("@boxno", dr("boxno"))
                cmd.Parameters.AddWithValue("@spools", dr("spools"))
                cmd.Parameters.AddWithValue("@kg_gr", dr("kg_gr"))
                cmd.Parameters.AddWithValue("@kg_nt", dr("kg_nt"))
                cmd.Parameters.AddWithValue("@actual_cone_weight", dr("actual_cone_weight"))
                cmd.Parameters.AddWithValue("@lotno_our", dr("lotno_our"))
                cmd.Parameters.AddWithValue("@gb", dr("gb"))
                cmd.Parameters.AddWithValue("@sono", dr("sono"))
                cmd.Parameters.AddWithValue("@sonoid", dr("sonoid"))
                cmd.Parameters.AddWithValue("@mfg_production_order_line_id", dr("mfg_production_order_line_id"))
                da = New SqlDataAdapter(cmd)
                dt = New DataTable
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    tran.Rollback()
                    MsgBox(ex.Message.ToString)
                    cn.Close()
                    Return False
                End Try
            End If
        Next

        '=================================== Add By Neung 20191216 Log ควร เก็บหลังจาก Update แล้ว ==========
        cmd.CommandText = "log_job"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@empcd", clsUser.UserID)
        cmd.Parameters.AddWithValue("@docno", m_jobno)
        cmd.Parameters.AddWithValue("@action", "UPD")

        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            tran.Rollback()
            MsgBox(ex.Message.ToString)
            cn.Close()
            Return False
        End Try

        tran.Commit()
        cn.Close()
        MessageBox.Show("Save Completed" & vbCrLf & tbl_job.jobno, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return True
    End Function

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        setFormMode("NEW")

    End Sub


    Private Sub calculateSelectedItem()

        Dim sumgross As Double = 0.00
        Dim sumnet As Double = 0.00
        Dim sumspools As Double = 0.00
        Dim sumbox As Integer = 0.00

        Dim i As Integer
        Dim j As Integer = 0
        Dim kg_gr As Double = 0.00
        Dim kg_nt As Double = 0.00
        Dim spools As Double = 0.00

        If Not DgJobYarndet.Rows.Count > 0 Then
            currentItcdSelected = (New clsConfig).IsNull(DgJobYarndet.CurrentRow.Cells("colDgJobYarndetItcd").Value, Nothing)
            gbItemsCodeSelect.Text = "Total Item:" + currentItcdSelected + "Selected"

            If Not IsDBNull(currentItcdSelected) Then
                'Try
                Dim countGrid As Integer
                countGrid = Me.DgJobYarndet.Rows.Count
                For i = 0 To Me.DgJobYarndet.Rows.Count - 1
                    'If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then

                    If Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetItcd").Value = currentItcdSelected Then
                        j = j + 1
                        spools = oConfig.IsValidDouble(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetSpools").Value)
                        kg_gr = oConfig.IsValidDouble(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgGr").Value)
                        kg_nt = oConfig.IsValidDouble(Me.DgJobYarndet.Rows(i).Cells("colDgJobYarndetKgNt").Value)
                        sumgross = sumgross + kg_gr
                        sumnet = sumnet + kg_nt
                        sumspools = sumspools + spools
                        sumbox = j
                    End If
                Next
            End If
        End If

        Me.txtTotItemBox.Text = sumbox
        Me.txtTotItemSpools.Text = sumspools
        Me.txtTotItemGW.Text = sumgross
        Me.txtTotItemNW.Text = sumnet
    End Sub


    Private Sub Dg_jobYarndet_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgJobYarndet.RowEnter

        currentItcdSelected = DgJobYarndet.Rows(e.RowIndex).Cells("colDgJobYarndetItcd").Value 'Disible By Neung 20191206
        calculateSelectedItem()
    End Sub

    Private Sub setFormMode(ByVal p_formMode As String)
        If p_formMode = "NEW" Then
            formMode = "NEW" ' class level variable
            Me.Text = "JOB ORDER FOR YARN (NEW)"
            ' Me.txtjobno.ReadOnly = True
            'Me.toolStripBtnNew.Enabled = False
            Me.toolStripBtnSave.Enabled = True
            If Me.DgJobYarndet.Rows.Count > 1 Then
                dtJob.Rows.Clear()
            End If
            'Me.txtjobno.Text = "NEW"
            Cbcolor.Text = "No Color"
            ErrorProvider1.Clear()
        End If
        If p_formMode = "EDIT" Then
            formMode = "EDIT" 'class level variable
            Me.Text = "JOB ORDER FOR YARN (EDIT)"
            Me.txtjobno.ReadOnly = False
            'Me.toolStripBtnNew.Enabled = True
            'Me.toolStripBtnSave.Enabled = False
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub toolStripMain_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles toolStripMain.ItemClicked

    End Sub

    Private Sub toolStripBtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripBtnNew.Click
        Call InitControl()

        'setFormMode("NEW")
    End Sub
    Private Sub showSearchForm()
        Dim frm As New formSearchJob
        frm.ShowDialog()
        Me.Cursor = Cursors.WaitCursor
        If frm.pblnOk = True Then
            Me.txtjobno.Text = frm.pJobNo
            Call intTxtSerarch()
            Call loadJobData() 'Neung 20260129 Test 
            If oConfig.IsNull(UserInfo.UserID, "").ToString.ToUpper = "STOCK" Then
                toolStripBtnSave.Enabled = False
            End If
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub toolStripBtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripBtnSearch.Click
        Call showSearchForm()
    End Sub

    Private Sub toolStripBtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripBtnSave.Click
        Me.Validate()

        blnCancel = False
        Dim result As DialogResult
        result = MessageBox.Show("Would you like to Save Job ?" & vbCrLf,
                       "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CHECKDATA() Then Exit Sub

        If formMode = "NEW" Then
            Call saveNewJob()
        Else
            If (New clsConfig).UserAccess(clsUser.UserID, "SY0126", "EDIT") Then
                Call updateJob()
            Else
                MessageBox.Show("คุณไม่มีสิทธิ์ในการแก้ไข", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub printForm()
        'Dim str As String
        'str = ""
        'ds.Clear()
        'str = "select * from v_job_yarn  " & _
        '  "where jobno = '" & Me.txtjobno.Text & "' "

        'Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        'myda.Fill(ds, "TblDatajobyarn")
        'If ds.Tables("TblDatajobyarn").Rows.Count > 0 Then
        '    Dim frmreport As New FormRptJobOrderforYarn
        '    Dim rptFileName As String = "RptJobOrderforYarn.rpt"
        '    Dim obj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '    obj.Load(clsuser.reportpath & rptFileName)
        '    'Dim obj As New RptJobOrderforYarn
        '    obj.SetDataSource(ds.Tables("TblDatajobyarn"))

        '    frmreport.CrystalReportViewer1.ReportSource = obj

        '    frmreport.ShowDialog()
        'End If

        Dim clsConn As New classConnection
        Dim rptFileName As String = "RptJobOrderforYarn.rpt"
        Dim frm As New frmReport

        If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@jobno", txtjobno.Text)

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

    Private Sub toolStripBtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripBtnPrint.Click
        printForm()
    End Sub

    Private Sub toolStripBtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Feature not available here, Go to Cancel menu", MsgBoxStyle.Information, "Cancel job")
    End Sub

    Private Sub toolStripBtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolStripBtnExit.Click
        Me.Close()
    End Sub

    Private Sub txtjobno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjobno.TextChanged

    End Sub

    Private Sub txtjobno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtjobno.Validated
        ' loadJobData()
    End Sub

    '  Private Sub textKono_TextChanged(sender As Object, e As EventArgs) Handles txtKono.TextChanged

    ' Call getProductionItem()

    ' End Sub

    Private Sub Cbjobtype_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cbjobtype.SelectedIndexChanged

    End Sub

    Private Sub DgYarnInSelectAll()
        Dim i As Integer
        Dim count As Integer
        count = Me.DgYarnIn.Rows.Count - 1
        For i = 0 To count
            Me.DgYarnIn.Rows(i).Cells("DGV_show").Value = True
        Next
    End Sub

    Private Sub DgYarnInClearAll()
        Dim i As Integer
        Dim count As Integer
        count = Me.DgYarnIn.Rows.Count - 1
        For i = 0 To count
            Me.DgYarnIn.Rows(i).Cells("DGV_show").Value = False
        Next
    End Sub

    Private Sub Dg_jobYarndetSelectALL()
        Dim i As Integer
        Dim count As Integer
        count = Me.DgJobYarndet.Rows.Count - 1
        For i = 0 To count
            Me.DgJobYarndet.Rows(i).Cells("DGV_select").Value = True
        Next
    End Sub

    Private Sub Dg_jobYarndetClearALL()
        Dim i As Integer
        Dim count As Integer
        count = Me.DgJobYarndet.Rows.Count - 1
        For i = 0 To count
            Me.DgJobYarndet.Rows(i).Cells("DGV_select").Value = False
        Next
    End Sub

    Private Sub btnYarnInSelectALL_Click(sender As System.Object, e As System.EventArgs) Handles btnYarnInSelectALL.Click
        DgYarnInSelectAll()
    End Sub

    Private Sub btnYarnInClearALL_Click(sender As System.Object, e As System.EventArgs) Handles btnYarnInClearALL.Click
        DgYarnInClearAll()
    End Sub

    Private Sub BtnDg_jobYarndetClearALL_Click(sender As System.Object, e As System.EventArgs) Handles BtnDg_jobYarndetClearALL.Click
        Dg_jobYarndetClearALL()
    End Sub

    Private Sub btnDg_jobYarndetSelectALL_Click(sender As System.Object, e As System.EventArgs) Handles btnDg_jobYarndetSelectALL.Click
        Dg_jobYarndetSelectALL()
    End Sub

    Private Sub buttonApprove_Click(sender As System.Object, e As System.EventArgs)
        Call ApproveJob()
    End Sub

    Private Sub ApproveJob()
        Dim cmdApproveJob As New SqlCommand
        Dim connClass As New classConnection
        Dim cn As New SqlConnection
        Dim tran As SqlTransaction
        Dim response As Integer
        cn.ConnectionString = connClass.Connection
        cn.Open()
        tran = cn.BeginTransaction

        response = MsgBox("Are you sure to approve this job?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Job")
        If response = MsgBoxResult.Yes Then
            cmdApproveJob.CommandType = CommandType.StoredProcedure
            cmdApproveJob.CommandText = "p_job_approve"
            cmdApproveJob.Parameters.AddWithValue("@jobno", Me.txtjobno.Text.Trim)
            cmdApproveJob.Parameters.AddWithValue("@rem_app", Me.txtRemApprove.Text.Trim)
            cmdApproveJob.Parameters.AddWithValue("@log_empcd", clsUser.UserID)

            cmdApproveJob.Connection = cn
            cmdApproveJob.Transaction = tran

            Try
                cmdApproveJob.ExecuteNonQuery()
                MsgBox("Job order approved succesfully")
            Catch ex As Exception
                tran.Rollback()
                cn.Close()
                MsgBox(ex)
            Finally
                cn.Close()
            End Try

            tran.Commit()
            cn.Close()
        End If
    End Sub

    Private Sub cboNewmtl_subinventory_DropDownClosed(sender As Object, e As EventArgs)
        'Comment By Sitthana 20191129
        'Call Search(dts)
    End Sub
    Private Sub FilterYarnStock(ByVal dtResult As DataTable)
        'Comment By Sitthana 20191129
        Dim dvResult As DataView 'ตัวแปรเก็บผลลัพธ์
        Dim strFilter As String 'ตัวแปรเก็บเงื่อนไขค้นหา

        dvResult = New DataView(dtResult) 'นำข้อมูลจาก DataTable ที่ต้องการค้นหา มาไว้ใน DataVieW
        strFilter = "(mtl_warehouse_id = '" & (New clsConfig).IsNull(MtlWarehouseId, 0) & "'" & " or " & (New clsConfig).IsNull(MtlWarehouseId, 0) & "= 0)"
        strFilter += " and (mtl_subinventory_id = '" & (New clsConfig).IsNull(MtlSubinventoryId, 0) & "'" & " or " & (New clsConfig).IsNull(MtlSubinventoryId, 0) & "= 0)"
        dvResult.RowFilter = strFilter 'ค้นหา

        DgYarnIn.DataSource = dvResult 'นำผลลัพธ์ที่ค้นหาคืนสู่ DataGridView
        DgYarnIn.Refresh()
    End Sub



    Private Sub cboNewmtl_warehouse_DropDownClosed(sender As Object, e As EventArgs)
        'Comment By Sitthana 20191129
        'Call GetComboNewSubInventory(Int64mtl_warehouse_id:=cboNewmtl_warehouse.SelectedValue)
        'If Not cbomtl_subinventory.DataSource Is Nothing Then Search(dts)
    End Sub

    Private Sub cbomtl_subinventory_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboNewmtl_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub cboSoNo_DropDownClosed(sender As Object, e As EventArgs)
    '    'Comment By Sitthana 20191129
    '    If Not cboSoNo.DataSource Is Nothing Then GetComboSoNoID(StrSoNo:=(New clsConfig).IsNull(cboSoNo.SelectedValue, ""))
    'End Sub

    Private Sub DgYarnIn_KeyDown(sender As Object, e As KeyEventArgs) Handles DgYarnIn.KeyDown
        'Dim i As Integer = 0
        'If e.KeyCode = Keys.Enter Then
        '    If DgYarnIn.Columns(DgYarnIn.SelectedCells(i).ColumnIndex).Name = "DGV_show" Then
        '        For i = 0 To DgYarnIn.SelectedCells.Count - 1
        '            DgYarnIn.SelectedCells(i).Value = Not CBool(DgYarnIn.SelectedCells(i).Value)
        '        Next
        '    End If
        'End If
        With DgYarnIn
            If e.KeyCode = Keys.Enter Then
                Dim i As Integer = 0

                If .SelectedRows.Count = 0 Then
                    'Select Column
                    If .Columns(.SelectedCells(i).ColumnIndex).Name = "DGV_show" Then
                        For i = 0 To .SelectedCells.Count - 1
                            .SelectedCells(i).Value = Not CBool(.SelectedCells(i).Value)
                        Next
                    End If
                Else
                    'Select Row
                    For Each row As DataGridViewRow In .SelectedRows
                        i = row.Index
                        .Rows(i).Cells("DGV_show").Value = Not CBool(.Rows(i).Cells("DGV_show").Value)
                    Next
                End If
            End If
        End With
    End Sub

    Private Sub Dg_jobYarndet_KeyDown(sender As Object, e As KeyEventArgs) Handles DgJobYarndet.KeyDown
        'Dim i As Integer = 0
        'If e.KeyCode = Keys.Enter Then
        '    If Dg_jobYarndet.Columns(Dg_jobYarndet.SelectedCells(i).ColumnIndex).Name = "DGV_select" Then
        '        For i = 0 To Dg_jobYarndet.SelectedCells.Count - 1
        '            Dg_jobYarndet.SelectedCells(i).Value = Not CBool(Dg_jobYarndet.SelectedCells(i).Value)
        '        Next
        '    End If
        'End If

        With DgJobYarndet
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

    Private Sub txtjobno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtjobno.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim pMessage As String = ""
            If Not ValidateJobno(pMessage) Then
                MessageBox.Show("ไม่พบ Job No: " + txtjobno.Text.Trim, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button3)
                Call InitControl()
                Exit Sub
            End If

            Call loadJobData()
            'Use Temp after k.jiew come back remove Sitthana 20190903
            If oConfig.IsNull(clsUser.UserID, "").ToString.ToUpper = "STOCK" Then
                toolStripBtnSave.Enabled = False
            End If

            'Call GenDgvGroup()
        End If
    End Sub



    Private Sub btnSearchWareHouse_Click(sender As Object, e As EventArgs) Handles btnSearchWareHouse.Click
        'Writen by : Sitthana 20191129
        Dim f As New Classes.frmSearchMtlWareHouse
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use de    fault connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(oConn.getSQLConnection)
        'f.MtlWarehouseId = 6
        'f.MtlWarehouseCd = "GMK3"
        'f.MtlWarehouseName = "GMK3"
        f.logempcd = clsUserInfo.UserName
        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            MtlWarehouseId = drv.Item("mtl_warehouse_id")
            txtWarehouseCode.Text = drv.Item("warehouse_code")
            'txtWarehouseName.Text = drv.Item("warehouse_name")
            Call FilterYarnStock(dtYarnIn)
        End If
    End Sub

    Private Sub btnSearchSubinventory_Click(sender As Object, e As EventArgs) Handles btnSearchSubinventory.Click
        'Writen by : Sitthana 20191129
        Dim f As New Classes.frmSearchSubinventory
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use de    fault connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(oConn.getSQLConnection)
        f.MtlWarehouseId = MtlWarehouseId
        f.MtlWarehouseCd = txtWarehouseCode.Text.Trim
        '  f.MtlWarehouseName = txtWarehouseName.Text.Trim
        f.logempcd = clsUserInfo.UserName
        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            MtlSubinventoryId = drv.Item("mtl_subinventory_id")
            txtSubinventoryCode.Text = drv.Item("subinventory_code")
            'txtSubinventoryName.Text = drv.Item("subinventory_name")
            Call FilterYarnStock(dtYarnIn)
        End If
    End Sub

    Private Sub btnSearchSupplier_Click(sender As Object, e As EventArgs) Handles btnSearchSupplier.Click
        Dim f As New Classes.formSearchSupplier
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(oConn.getSQLConnection)

        SearchResult = f.ShowSuppliers()
        f.Close()
        f.Dispose()
        drv = SearchResult.ResultRowView
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtSupplierCode.Text = drv.Item("suppcd")
            txtSupplierName.Text = drv.Item("name")
        End If
    End Sub

    Private Sub btnSearchSoNo_Click(sender As Object, e As EventArgs) Handles btnSearchSoNo.Click
        'Writen by : Sitthana 20191129
        Dim f As New Classes.frmSearchSoNo
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(oConn.getSQLConnection)
        'f.CompanyId = 1
        'f.CompanyDesc = "GMK"
        f.logempcd = clsUserInfo.UserName
        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtSoNo.Text = drv.Item("sono")
        End If
    End Sub

    Private Sub btnSearchSOLine_Click(sender As Object, e As EventArgs) Handles btnSearchSOLine.Click
        'Writen by : Sitthana 20191129

        If txtSoNo.Text.Trim = "" Then
            MessageBox.Show("คุณต้องเลือก SO No ก่อนครับ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim f As New Classes.frmSearchSoNoLine
            Dim drv As DataRowView
            Dim SearchResult As New Classes.SearchFormResult
            ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
            f.setConnectionString(oConn.getSQLConnection)
            f.sonoinline = txtSoNo.Text.Trim
            f.logempcd = clsUserInfo.UserID
            SearchResult = f.ShowFrm
            f.Close()
            f.Dispose()
            If SearchResult.ButtonClicked = "OK" Then
                drv = SearchResult.ResultRowView
                txtSoNoId.Text = drv.Item("sonoid")
                txtItcd.Text = drv.Item("design_no")
                Call getYarnStock()
            End If
        End If
    End Sub

    Private Sub DgJobYarndet_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgJobYarndet.CellDoubleClick
        Dim currentColIndex As Integer = DgJobYarndet.CurrentCell.ColumnIndex
        Dim currentColName As String = DgJobYarndet.Columns(currentColIndex).Name
        Dim dgr As DataGridViewRow = DgJobYarndet.CurrentRow
        If currentColName = "colDgJobYarndetGb" Or currentColName = "colDgJobYarndetMfgProductionOrderLinesId" Then
            Dim frmSelectItems As New formJobOrderYarnNewEditSelectProductionLine

            frmSelectItems.pKoNo = txtKono.Text.Trim
            frmSelectItems.ShowDialog(Me)
            If frmSelectItems.pblnOk = True Then
                dgr.Cells("colDgJobYarndetGb").Value = frmSelectItems.pGb
                dgr.Cells("colDgJobYarndetMfgProductionOrderLinesId").Value = frmSelectItems.pMfgProductionOrderLineID

                Call GenDgvGroup()
            End If

        End If
    End Sub

    Private Sub txtStock_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItcd.KeyDown
        If e.KeyCode = Keys.Enter Then
            selectedItcd = txtItcd.Text

            If Not CheckDataStock() Then Exit Sub

            If Cbjobtype.SelectedValue.ToString.Trim.Equals("WARPING") Or Cbjobtype.SelectedValue.ToString.Trim.Equals("KNITTING") Then
                If txtKono.Text.Trim = "" Then
                    MessageBox.Show("คุณต้องเลือก เลขที่ Prod No. ก่อนครับ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    If Not CheckItemsCode() Then
                        MessageBox.Show("ไม่พบ Item Code นี้ในบอม" & "Prod No: " & txtKono.Text.Trim & vbCrLf & vbCrLf & "Item No not exists in Prod N: " & txtKono.Text.Trim, "System Message")
                        Exit Sub
                    End If
                    If CheckItemsCountMoreThenOne() > 1 Then
                        Call btnStock_Click(sender, e)
                        Exit Sub
                    End If
                    Call getYarnStock()
                End If
            Else
                Call getYarnStock()
            End If 'Sitthaan 20191210
        End If
    End Sub

    Private Sub formJobOrderYarnNewEdit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If txtjobno.Text.Trim <> "NEW" Then Call toolStripBtnSave_Click(sender, e)
        e.Cancel = blnCancel
    End Sub




    Function GroupByMultiple(ByVal i_sGroupByColumns As String(), ByVal i_sAggregateColumn As String, ByVal i_dSourceTable As DataTable) As DataTable

        Dim dv As New DataView(i_dSourceTable)
        Dim dtGroup As DataTable = dv.ToTable(True, i_sGroupByColumns)

        dtGroup.Columns.Add("Count", GetType(Integer))

        Dim sCondition As String
        For Each dr As DataRow In dtGroup.Rows
            sCondition = ""

            For I = 0 To i_sGroupByColumns.Length - 1
                sCondition &= i_sGroupByColumns(I) & " = '" & dr(i_sGroupByColumns(I)) & "' "
                If I < i_sGroupByColumns.Length - 1 Then sCondition &= " AND "
            Next

            dr("Count") = i_dSourceTable.Compute("Count(" & i_sAggregateColumn & ")", sCondition)
        Next

        Return dtGroup
    End Function

    Private Sub btnGroupby_Click(sender As Object, e As EventArgs)
        dgJobDet.AutoGenerateColumns = False
        'dgvGroup.DataSource = GroupBy("itcd", "mfg_production_order_line_id", "boxno", "kg_nt", DgJobYarndet.DataSource)
        '  dgvGroup.DataSource = GroupByNew("itcd", "mfg_production_order_line_id", "boxno", "kg_nt", DgJobYarndet.DataSource)
        'dgvGroup.DataSource = (New classJobOrderYarn).GetJobDetGroup(DgJobYarndet.DataSource)
        dgJobDet.DataSource = GroupByNew(DgJobYarndet.DataSource)
        dgJobDet.Refresh()
    End Sub

    Function GroupByNew(ByVal i_dSourceTable As DataTable) As DataTable

        Dim dtJobYarnDet As New DataTable '= DgJobYarndet.DataSource

        dtJobYarnDet.Columns.Add("id_job_det", GetType(Int32))
        dtJobYarnDet.Columns.Add("lotno_our", GetType(String))
        dtJobYarnDet.Columns.Add("itcd", GetType(String))
        dtJobYarnDet.Columns.Add("boxno", GetType(String))
        dtJobYarnDet.Columns.Add("spools", GetType(String))
        dtJobYarnDet.Columns.Add("kg_gr", GetType(Double))
        dtJobYarnDet.Columns.Add("kg_nt", GetType(Double))
        dtJobYarnDet.Columns.Add("gb", GetType(String))
        dtJobYarnDet.Columns.Add("actual_cone_weight", GetType(Decimal))
        dtJobYarnDet.Columns.Add("mfg_production_order_line_id", GetType(Int64))

        Dim drJobYarnDet As DataRow
        Dim dt As DataTable = DgJobYarndet.DataSource
        For Each dr As DataRow In dt.Rows
            If dr.RowState <> DataRowState.Deleted Then
                drJobYarnDet = dtJobYarnDet.NewRow
                drJobYarnDet("id_job_det") = dr("id_job_det")
                drJobYarnDet("lotno_our") = dr("lotno_our")
                drJobYarnDet("itcd") = dr("itcd")
                drJobYarnDet("boxno") = dr("boxno")
                drJobYarnDet("spools") = dr("spools")
                drJobYarnDet("kg_gr") = dr("kg_gr")
                drJobYarnDet("kg_nt") = dr("kg_nt")
                drJobYarnDet("gb") = dr("gb")
                drJobYarnDet("actual_cone_weight") = dr("actual_cone_weight")
                drJobYarnDet("mfg_production_order_line_id") = dr("mfg_production_order_line_id")
                dtJobYarnDet.Rows.Add(drJobYarnDet)
            End If
            'dtJobYarnDet.ImportRow(dr)
        Next

        Dim dtGroup As DataTable = (New classJobOrderYarn).GetJobDetGroup(dtJobYarnDet)


        Return dtGroup
    End Function

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Call ApproveJob()
    End Sub



    Private Sub GenDgvGroup()
        dgJobDet.AutoGenerateColumns = False
        dgJobDet.DataSource = GroupByNew(DgJobYarndet.DataSource)
        dgJobDet.Refresh()
    End Sub

    Private Sub DgJobYarndet_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgJobYarndet.CellClick
        Dim currentColIndex As Integer = DgJobYarndet.CurrentCell.ColumnIndex
        Dim currentColName As String = DgJobYarndet.Columns(currentColIndex).Name
        Dim dgr As DataGridViewRow = DgJobYarndet.CurrentRow

        Call calculatesummaryByItemsSelected((New clsConfig).IsNull(dgr.Cells("colDgJobYarndetItcd").Value, ""))

    End Sub

    Private Sub calculatesummaryByItemsSelected(ByVal stritcd As String)

        gbItemsCodeSelect.Text = "Total Selected Item Code :" + stritcd.Trim
        'getting distinct values for group column
        ' Dim dtGroup As DataTable = dv.ToTable(True, New String() {stritcd})
        Dim dt As DataTable = (DgJobYarndet.DataSource)
        Dim sumKgNt As Decimal = 0.00
        Dim sumKgGr As Decimal = 0.00
        Dim sumSpools As Decimal = 0.00
        Dim CountBox As Decimal = 0.00

        sumKgNt = (New clsConfig).IsNull(dt.Compute("sum(kg_nt)", "itcd = " & "'" & stritcd & "'"), 0.00) 'dt.compute("ทำอะไรเช่น sum, count","เงื่อนไข")
        sumKgGr = (New clsConfig).IsNull(dt.Compute("sum(kg_gr)", "itcd = " & "'" & stritcd & "'"), 0.00) 'dt.compute("ทำอะไรเช่น sum, count","เงื่อนไข")
        sumSpools = (New clsConfig).IsNull(dt.Compute("sum(spools)", "itcd = " & "'" & stritcd & "'"), 0.00) 'dt.compute("ทำอะไรเช่น sum, count","เงื่อนไข")
        CountBox = (New clsConfig).IsNull(dt.Compute("count(boxno)", "itcd = " & "'" & stritcd & "'"), 0.00) 'dt.compute("ทำอะไรเช่น sum, count","เงื่อนไข")

        txtTotItemNW.Text = sumKgNt
        txtTotItemGW.Text = sumKgGr
        txtTotItemSpools.Text = sumSpools
        txtTotItemBox.Text = CountBox
    End Sub

    Private Function GroupBy(ByVal i_sGroupByColumn1 As String, ByVal i_sGroupByColumn2 As String, ByVal i_sAggregateColumn As String, ByVal i_sSummaryColumn As String, ByVal i_dSourceTable As DataTable) As DataTable
        Dim dv As New DataView(i_dSourceTable)

        'getting distinct values for group column
        Dim dtGroup As DataTable = dv.ToTable(True, New String() {i_sGroupByColumn1})

        'adding column for the row count , Sum
        dtGroup.Columns.Add("Count", GetType(Integer))

        'looping thru distinct values for the group, counting , Summary
        For Each dr As DataRow In dtGroup.Rows
            dr("Count") = i_dSourceTable.Compute("Count(" & i_sAggregateColumn & ")", i_sGroupByColumn1 & " = '" & dr(i_sGroupByColumn1) & "'")
        Next
        dtGroup.Columns.Add("Qty", GetType(Double))
        For Each dr As DataRow In dtGroup.Rows
            dr("Qty") = i_dSourceTable.Compute("Sum(" & i_sSummaryColumn & ")", i_sGroupByColumn1 & " = '" & dr(i_sGroupByColumn1) & "'")
        Next
        'returning grouped/counted result
        Return dtGroup
    End Function
End Class
