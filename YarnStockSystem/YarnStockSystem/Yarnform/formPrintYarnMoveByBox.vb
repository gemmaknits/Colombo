Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class formPrintYarnMoveByBox
    Private connStr As New classConnection
    Dim ds As New DataSet
    Private dts As DataTable
    Private dt As DataTable
    Private Clsconfig As New clsConfig
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub formPrintYarnMoveByBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GenCombo()
        'select itcd,trim(itcd)+" - "+itdesc as itdesc from v_yarn_in_out_by_box
        Dim str As New StringBuilder
        Try
            str.Append("select itcd,itdesc itdesc1,itdesc2,itdesc3,itdesc_spec,itdesc_supp,ltrim(rtrim((itcd)))+' - '+itdesc_spec as itdesc,s.name as suppname ")
            str.Append("from items  ")
            str.Append("left join Suppliers s on s.suppcd = items.suppcd ")
            str.Append("where itnaturecd='YARNS' ")
            str.Append("group by itcd,itdesc_spec,itdesc,itdesc2,itdesc3,itdesc_spec,itdesc_supp,s.name ")
            str.Append("order by itcd ")
            Dim da As New SqlDataAdapter(str.ToString, connStr.Connection)
            da.Fill(ds, "v_yarn_in_out_by_box")
            If ds.Tables("v_yarn_in_out_by_box").Rows.Count > 0 Then
                dts = ds.Tables("v_yarn_in_out_by_box")
                Me.dgselectItem.AutoGenerateColumns = False
                Me.dgselectItem.DataSource = ds.Tables("v_yarn_in_out_by_box") 'dts
            Else
                'Me.dgselectItem.DataSource = ""
            End If
            selectAllItems()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
    End Sub
    Private Sub GenCombo()
        GetComboNewWarehouse()
        GetComboNewSubInventory(Int64mtl_warehouse_id:=Nothing)
        GetComboNewLocation(Int64mtl_warehouse_id:=Nothing, Int64mtl_subinventory_id:=Nothing) ''Sitthana 24/02/2018
        getComboItemGroup() 'Sitthana 20190511
        'GetComboNewLocation(Int64mtl_warehouse_id:=cboNewmtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=cboNewmtl_subinventory.SelectedValue, Int64mtl_locations_id:=cboNewmtl_locations.SelectedValue)
    End Sub
    Private Sub GetComboNewWarehouse()
        Dim objdb As New classMaster

        cboNewmtl_warehouse.DataSource = objdb.Combomtlwarehouse(strUSerID:=clsUser.UserID)
        cboNewmtl_warehouse.DisplayMember = "warehouse_code"
        cboNewmtl_warehouse.ValueMember = "mtl_warehouse_id"

        'SetdefaultWarehouse()

    End Sub

    Private Sub GetComboNewSubInventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster

        cboNewmtl_subinventory.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        cboNewmtl_subinventory.DisplayMember = "subinventory_code"
        cboNewmtl_subinventory.ValueMember = "mtl_subinventory_id"

        'Setdefaultsubinventory(dt:=cboNewmtl_subinventory.DataSource)

    End Sub

    Private Sub GetComboNewLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing _
                                    , Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing
                                    )
        'Sitthana 24/02/2018
        Dim objdb As New classMaster

        cboNewmtl_locations_id.DataSource = objdb.GetCombomtl_location(Int64mtl_warehouse_id, Int64mtl_subinventory_id)
        cboNewmtl_locations_id.DisplayMember = "location_name"
        cboNewmtl_locations_id.ValueMember = "mtl_locations_id"

        'Setdefaultsubinventory(dt:=cboNewmtl_subinventory.DataSource)

    End Sub
    Private Sub getComboItemGroup()
        '----------  Yarn group  ---------------
        'Sitthana 20190511 Copy from purchase system
        Dim objdb As New classMaster
        Dim dtyarngroup As DataTable
        dtyarngroup = objdb.getItemGroupData
        If Not IsNothing(dtyarngroup) Then
            Me.cbitgroupcd.DataSource = dtyarngroup
            Me.cbitgroupcd.DisplayMember = "itgroupdesc"
            Me.cbitgroupcd.ValueMember = "itgroupcd"
            cbitgroupcd.SelectedIndex = 0
        End If

    End Sub

    Private Sub SetdefaultWarehouse()
        Dim clsMaster As New classMaster
        'Dim dt As DataTable = clsMaster.GetdefaultWarehouse(strUSerID:=clsUser.UserID)
        cboNewmtl_warehouse.SelectedValue = clsMaster.GetdefaultWarehouse(strUSerID:=clsUser.UserID)
        'If dt.Rows.Count > 0 Then
        'cboNewmtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
        'End If

    End Sub

    Private Sub Setdefaultsubinventory(ByVal dt As DataTable)

        Dim expression As String
        expression = "subinventory_code like '%YARN%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)

        Try
            cboNewmtl_subinventory.SelectedValue = foundRows(0)(0)
        Catch ex As Exception
            cboNewmtl_subinventory.Text = ""
        End Try
        'cboNewmtl_subinventory.SelectedValue = foundRows(0)(0)

        'Dim clsMaster As New classMaster
        'Dim dt As DataTable = clsMaster.Getdefaultmtlsubinventory(clsUser.UserID)

        'If dt.Rows.Count > 0 Then
        '    cboNewmtl_subinventory.SelectedValue = dt.Rows(0)("mtl_subinventory_id")
        'End If

    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearAllItems()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        selectAllItems()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call printReport()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtlookup.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search(dts)
        End If
        'If e.KeyCode = Keys.Enter Then
        '    Dim str As New StringBuilder
        '    Try
        '        str.Append("select itcd,ltrim(rtrim((itcd)))+' - '+itdesc as itdesc from v_yarn_in_out_by_box group by itcd,itdesc order by itcd ")
        '        ds.Clear()
        '        Dim da As New SqlDataAdapter(str.ToString, connStr.ConnectionString)
        '        da.Fill(ds, "v_yarn_in_out_by_box")
        '        If ds.Tables("v_yarn_in_out_by_box").Rows.Count > 0 Then
        '            dts = ds.Tables("v_yarn_in_out_by_box")
        '            Me.dgselectItem.DataSource = ds.Tables("v_yarn_in_out_by_box") 'dts
        '        Else
        '            Me.dgselectItem.DataSource = ""
        '        End If
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
    End Sub
    Private Sub Search(ByVal dtResult As DataTable)
        Dim dvResult As DataView 'ตัวแปรเก็บผลลัพธ์
        Dim strFilter As String 'ตัวแปรเก็บเงื่อนไขค้นหา

        dvResult = New DataView(dtResult) 'นำข้อมูลจาก DataTable ที่ต้องการค้นหา มาไว้ใน DataView
        strFilter = "itcd like '%" & txtlookup.Text & "%'"
        strFilter &= " or itdesc like '%" & txtlookup.Text & "%'"
        strFilter &= " or itdesc1 like '%" & txtlookup.Text & "%'"
        strFilter &= " or itdesc2 like '%" & txtlookup.Text & "%'"
        strFilter &= " or itdesc3 like '%" & txtlookup.Text & "%'"
        strFilter &= " or itdesc_spec like '%" & txtlookup.Text & "%'"
        strFilter &= " or itdesc_supp like '%" & txtlookup.Text & "%'"
        strFilter &= " or suppname like '%" & txtlookup.Text & "%'"
        dvResult.RowFilter = strFilter 'ค้นหา

        dgselectItem.DataSource = dvResult 'นำผลลัพธ์ที่ค้นหาคืนสู่ DataGridView
    End Sub


    Private Sub printReport()
        Dim i As Integer
        Dim j As Integer
        Dim itemsList As String = ""
        'If Me.dgselectItem.Rows.Count = 0 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        j = 0
        Try
            For i = 0 To Me.dgselectItem.Rows.Count - 1
                If Me.dgselectItem.Rows(i).Cells("colselect").Value = True Then
                    j = j + 1
                End If
            Next
        Catch ex As Exception

        End Try

        For i = 0 To Me.dgselectItem.Rows.Count - 1
            If Me.dgselectItem.Rows(i).Cells("colSelect").Value = True Then
                itemsList = itemsList & Me.dgselectItem.Rows(i).Cells("colitcd").Value.ToString.Trim & ","
            End If
        Next

        If itemsList.Length > 1 Then itemsList = Mid(itemsList.ToString, 1, itemsList.Length - 1)

        If Me.optBalByBox.Checked Then
            printBalByBox(itemsList:=itemsList)
        ElseIf Me.optBalByBoxGrpByLocation.Checked Then
            printBalByBox(itemsList:=itemsList) 'Sitthana 20191209
        ElseIf Me.optBalByItcd.Checked Then
            'มีการแยก Report ใน Sub อีกที Neung 20260130
            If optBalShowBalanceMultiColumnSortByCode.Checked Or optBalShowBalanceMultiColumnSortByDescp.Checked Then 'Sitthana 20200320
                printBalanceByItcd(itemsList:=itemsList)
            Else
                printBalanceByItcd(itemsList:=itemsList)
            End If

        ElseIf Me.optBalByItcdUsage.Checked Then
            printBalanceByItcdUsage(itemsList:=itemsList)
        ElseIf Me.optBalByItcdSummary.Checked Then
            printBalanceByItcdSummary(itemsList:=itemsList)
        ElseIf Me.optBalByLoc.Checked Then
            printBalanceByLoc(itemsList:=itemsList)
        ElseIf Me.optBalByBoxWithMove.Checked Then
            printBalByBoxWithMove(itemsList:=itemsList)
        ElseIf Me.optMoveByItcd.Checked Then
            printMovementByItcd(itemsList:=itemsList)
        ElseIf Me.optMoveByBatch.Checked Then
            printMovementByBatch(itemsList:=itemsList)
        End If

    End Sub
    Private Sub printBalByBoxWithMove(ByVal itemsList As String)

        Dim config As New clsConfig
        Dim classCn As New classConnection
        'Dim itemsList As String
        'Dim I As Integer

        config.ChangeCulture()

        'itemsList = ""

        'For I = 0 To Me.dgselectItem.Rows.Count - 2
        '    If Me.dgselectItem.Rows(I).Cells("colSelect").Value = True Then
        '        'itemsList = itemsList & "'" & Me.dgselectItem.Rows(i).Cells("colitcd").Value.ToString.Trim & "',"
        '        itemsList = itemsList & Me.dgselectItem.Rows(I).Cells("colitcd").Value.ToString.Trim & ","
        '    End If
        'Next

        'If itemsList.Length > 1 Then itemsList = Mid(itemsList.ToString, 1, itemsList.Length - 1)

        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        'Dim rptFileName As String = "reportYarnInOutByBox.rpt"
        Dim rptFileName As String = "rptStockYOnhandMovementByBox.rpt" 'Add By Neung 25/07/2018
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsUser.ReportPath & rptFileName)
        'Dim rpt As New reportYarnInOutByBox

        rpt.DataSourceConnections.Item(0).SetConnection(classCn.ServerName, classCn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@itcd_list", itemsList)
        rpt.SetParameterValue("@datefr", IIf(dtpDateFr.Checked, CDate(dtpDateFr.Value.Date), CDate("01/01/1900"))) 'Add By Neung 25/07/2018
        rpt.SetParameterValue("@dateto", IIf(dtpDateTo.Checked, CDate(dtpDateTo.Value.Date), Now.Date)) 'Add By Neung 25/07/2018
        'rpt.SetParameterValue("@showbeforedate", IIf(dtpDateShowBF.Checked, dtpDateShowBF.Value, Now))
        'rpt.SetParameterValue("@showbeforedate", dtpDateTo.Value)
        rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        rpt.SetParameterValue("@p_itgroupcd", (New clsConfig).IsNull(cbitgroupcd.SelectedValue, Nothing)) 'Sitthana 20190511

        Dim frmreport As New formCRViewer
        frmreport.MdiParent = Me.MdiParent
        frmreport.CrystalReportViewer1.ReportSource = rpt
        frmreport.CrystalReportViewer1.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True

        frmreport.Show()
    End Sub
    'Private Sub printMovementByItcd(ByVal itemsList As String)

    '    Dim config As New clsConfig
    '    Dim classCn As New classConnection
    '    'Dim itemsList As String
    '    'Dim I As Integer

    '    config.ChangeCulture()

    '    'itemsList = ""

    '    'For I = 0 To Me.dgselectItem.Rows.Count - 1
    '    '    If Me.dgselectItem.Rows(I).Cells("colSelect").Value = True Then
    '    '        'itemsList = itemsList & "'" & Me.dgselectItem.Rows(i).Cells("colitcd").Value.ToString.Trim & "',"
    '    '        itemsList = itemsList & Me.dgselectItem.Rows(I).Cells("colitcd").Value.ToString.Trim & ","
    '    '    End If
    '    'Next

    '    'If itemsList.Length > 1 Then itemsList = Mid(itemsList.ToString, 1, itemsList.Length - 1)

    '    btnPrint.Enabled = False
    '    Me.Cursor = Cursors.WaitCursor
    '    Dim rptFileName As String = "rptStockYOnhandMovementByItcd.rpt" 'Add By Neung 25/07/2018
    '    'Dim rptFileName As String = "rptYarnMovementByITCD.rpt"
    '    'Dim rptFileName As String = IIf(optMoveByItcd.Checked, "rptYarnMovementByITCD.rpt", "rptYarnMovementByBatch.rpt")
    '    Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    rpt.Load(clsUser.ReportPath & rptFileName)
    '    'Dim rpt As New reportYarnInOutByItcd

    '    rpt.DataSourceConnections.Item(0).SetConnection(classCn.ServerName, classCn.Database, False)
    '    rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password)

    '    rpt.VerifyDatabase()
    '    rpt.SetParameterValue("@itcd_list", itemsList)
    '    rpt.SetParameterValue("@datefr", IIf(dtpDateFr.Checked, CDate(dtpDateFr.Value.Date), CDate("01/01/1900"))) 'Add By Neung 25/07/2018
    '    rpt.SetParameterValue("@dateto", IIf(dtpDateTo.Checked, CDate(dtpDateTo.Value.Date), Now.Date)) 'Add By Neung 25/07/2018
    '    'rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
    '    'rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
    '    'rpt.SetParameterValue("@showbeforedate", IIf(dtpDateShowBF.Checked, dtpDateShowBF.Value, Now))
    '    'rpt.SetParameterValue("@showbeforedate", dtpDateTo.Value)
    '    rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
    '    rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
    '    rpt.SetParameterValue("@p_itgroupcd", (New clsConfig).IsNull(cbitgroupcd.SelectedValue, "")) 'Sitthana 20190511

    '    Dim frmreport As New formCRViewer
    '    frmreport.Text = "Show movement by yarn code"
    '    frmreport.MdiParent = Me.MdiParent
    '    frmreport.CrystalReportViewer1.ReportSource = rpt
    '    frmreport.CrystalReportViewer1.Show()
    '    Me.Cursor = Cursors.Default
    '    btnPrint.Enabled = True
    '    frmreport.Show()
    'End Sub
    Private Sub printBalByBox(ByVal itemsList As String)

        Dim config As New clsConfig
        Dim classCn As New classConnection

        config.ChangeCulture()

        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        'Dim rptFileName As String = "reportYarnBalanceByBox.rpt"
        Dim rptFileName As String = "rptStockYOnhandBalanceByBox.rpt" 'add By Neung 20180726
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        'Sitthana 20191209
        If Me.optBalByBoxGrpByLocation.Checked Then
            rptFileName = "rptStockYOnhandBalanceByBoxByLoc.rpt"
        Else
            rptFileName = "rptStockYOnhandBalanceByBox.rpt" 'add By Neung 20180726
        End If
        rpt.Load(clsUser.ReportPath & rptFileName)
        'Dim rpt As New reportYarnBalanceByBox()

        rpt.DataSourceConnections.Item(0).SetConnection(classCn.ServerName, classCn.Database, False) 'Neung 20251023
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password) 'Neung 20251023

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@itcd_list", itemsList)
        rpt.SetParameterValue("@loc", txtLocation.Text.Trim) 'Sitthana 24/02/2018  -> Old data mtl_locations_id is null
        'rpt.SetParameterValue("@loc", textLoc.Text.Trim)
        rpt.SetParameterValue("@showbeforedate", IIf(dtpDateShowBF.Checked, dtpDateShowBF.Value.Date, Now.Date))
        rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_locations_id", (New clsConfig).IsNull(cboNewmtl_locations_id.SelectedValue, Nothing)) 'Sitthana 24/02/2018, 03/03/2018
        rpt.SetParameterValue("@p_itgroupcd", (New clsConfig).IsNull(cbitgroupcd.SelectedValue, "")) 'Sitthana 20190511

        Dim frmreport As New formCRViewer
        If rptFileName = "rptStockYOnhandBalanceByBoxByLoc.rpt" Then frmreport.Text = "Show balance by box (Location)" Else frmreport.Text = "Show balance by box"
        frmreport.MdiParent = Me.MdiParent
        frmreport.CrystalReportViewer1.ReportSource = rpt
        'frmreport.CrystalReportViewer1.Zoom(75)
        frmreport.CrystalReportViewer1.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
        frmreport.Show()
    End Sub

    Private Sub selectAllItems()
        Dim i As Integer
        If Me.dgselectItem.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        Try
            For i = 0 To Me.dgselectItem.Rows.Count - 1
                If Me.dgselectItem.Rows(i).Cells("colselect").Value = False Then Me.dgselectItem.Rows(i).Cells("colselect").Value = True
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub clearAllItems()
        Dim i As Integer
        If Me.dgselectItem.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        Try
            For i = 0 To Me.dgselectItem.Rows.Count - 1
                If Me.dgselectItem.Rows(i).Cells("colselect").Value = True Then Me.dgselectItem.Rows(i).Cells("colselect").Value = False
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub printMovementByItcd(ByVal itemsList As String)

        Dim config As New clsConfig
        Dim classCn As New classConnection
        'Dim itemsList As String
        'Dim I As Integer

        config.ChangeCulture()

        'itemsList = ""

        'For I = 0 To Me.dgselectItem.Rows.Count - 1
        '    If Me.dgselectItem.Rows(I).Cells("colSelect").Value = True Then
        '        'itemsList = itemsList & "'" & Me.dgselectItem.Rows(i).Cells("colitcd").Value.ToString.Trim & "',"
        '        itemsList = itemsList & Me.dgselectItem.Rows(I).Cells("colitcd").Value.ToString.Trim & ","
        '    End If
        'Next

        'If itemsList.Length > 1 Then itemsList = Mid(itemsList.ToString, 1, itemsList.Length - 1)

        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Dim rptFileName As String = "rptStockYOnhandMovementByItcd.rpt" 'Add By Neung 25/07/2018
        'Dim rptFileName As String = "rptYarnMovementByITCD.rpt"
        'Dim rptFileName As String = IIf(optMoveByItcd.Checked, "rptYarnMovementByITCD.rpt", "rptYarnMovementByBatch.rpt")
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsUser.ReportPath & rptFileName)
        'Dim rpt As New reportYarnInOutByItcd

        rpt.DataSourceConnections.Item(0).SetConnection(classCn.ServerName, classCn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@itcd_list", itemsList)
        rpt.SetParameterValue("@datefr", IIf(dtpDateFr.Checked, CDate(dtpDateFr.Value.Date), CDate("01/01/1900"))) 'Add By Neung 25/07/2018
        rpt.SetParameterValue("@dateto", IIf(dtpDateTo.Checked, CDate(dtpDateTo.Value.Date), Now.Date)) 'Add By Neung 25/07/2018
        'rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
        'rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        'rpt.SetParameterValue("@showbeforedate", IIf(dtpDateShowBF.Checked, dtpDateShowBF.Value, Now))
        'rpt.SetParameterValue("@showbeforedate", dtpDateTo.Value)
        rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        rpt.SetParameterValue("@p_itgroupcd", (New clsConfig).IsNull(cbitgroupcd.SelectedValue, "")) 'Sitthana 20190511

        Dim frmreport As New formCRViewer
        frmreport.Text = "Show movement by yarn code"
        frmreport.MdiParent = Me.MdiParent
        frmreport.CrystalReportViewer1.ReportSource = rpt
        frmreport.CrystalReportViewer1.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
        frmreport.Show()
    End Sub

    Private Sub printMovementByBatch(ByVal itemsList As String)

        Dim config As New clsConfig
        Dim classCn As New classConnection
        'Dim itemsList As String
        'Dim I As Integer

        config.ChangeCulture()

        'itemsList = ""

        'For I = 0 To Me.dgselectItem.Rows.Count - 1
        '    If Me.dgselectItem.Rows(I).Cells("colSelect").Value = True Then
        '        'itemsList = itemsList & "'" & Me.dgselectItem.Rows(i).Cells("colitcd").Value.ToString.Trim & "',"
        '        itemsList = itemsList & Me.dgselectItem.Rows(I).Cells("colitcd").Value.ToString.Trim & ","
        '    End If
        'Next

        'If itemsList.Length > 1 Then itemsList = Mid(itemsList.ToString, 1, itemsList.Length - 1)

        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        'Dim rptFileName As String = "rptYarnMovementByBatch.rpt"
        Dim rptFileName As String = "rptStockYOnhandMovementByBatch.rpt" 'add By Neung 20180726
        'Dim rptFileName As String = IIf(optMoveByItcd.Checked, "rptYarnMovementByITCD.rpt", "rptYarnMovementByBatch.rpt")
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsUser.ReportPath & rptFileName)
        'Dim rpt As New reportYarnInOutByItcd

        rpt.DataSourceConnections.Item(0).SetConnection(classCn.ServerName, classCn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@itcd_list", itemsList)
        rpt.SetParameterValue("@datefr", IIf(dtpDateFr.Checked, CDate(dtpDateFr.Value.Date), CDate("01/01/1900"))) 'Add By Neung 25/07/2018
        rpt.SetParameterValue("@dateto", IIf(dtpDateTo.Checked, CDate(dtpDateTo.Value.Date), Now.Date)) 'Add By Neung 25/07/2018
        'rpt.SetParameterValue("@showbeforedate", IIf(dtpDateShowBF.Checked, dtpDateShowBF.Value, Now))
        'rpt.SetParameterValue("@showbeforedate", dtpDateTo.Value)
        rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        rpt.SetParameterValue("@p_itgroupcd", (New clsConfig).IsNull(cbitgroupcd.SelectedValue, "")) 'Sitthana 20190511

        Dim frmreport As New formCRViewer
        frmreport.Text = "Show Balance by Itcd Batch"
        frmreport.MdiParent = Me.MdiParent
        frmreport.CrystalReportViewer1.ReportSource = rpt
        frmreport.CrystalReportViewer1.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
        frmreport.Show()
    End Sub

    Private Sub printBalanceByItcd(ByVal itemsList As String)

        Dim config As New clsConfig
        Dim classCn As New classConnection
        'Dim itemsList As String
        'Dim I As Integer

        config.ChangeCulture()

        'itemsList = ""

        'For I = 0 To Me.dgselectItem.Rows.Count - 1
        '    If Me.dgselectItem.Rows(I).Cells("colSelect").Value = True Then
        '        'itemsList = itemsList & "'" & Me.dgselectItem.Rows(i).Cells("colitcd").Value.ToString.Trim & "',"
        '        itemsList = itemsList & Me.dgselectItem.Rows(I).Cells("colitcd").Value.ToString.Trim & ","
        '    End If
        'Next

        'If itemsList.Length > 1 Then itemsList = Mid(itemsList.ToString, 1, itemsList.Length - 1)

        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        'Dim rptFileName As String = "reportYarnBalanceByItcd.rpt"
        Dim rptFileName As String = ""
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        'Sitthana 20200320 - Begin
        If optBalShowBalanceMultiColumnSortByCode.Checked Or optBalShowBalanceMultiColumnSortByDescp.Checked Then
            rptFileName = "rptStockYOnhandBalByItcdMultiCol.rpt"
        Else
            'optBalByItcd, optBalByItcdUsage, optBalByItcdSummary
            rptFileName = "rptStockYOnhandBalanceByItcd.rpt"
        End If
        'Sitthana 20200320 - End

        rpt.Load(clsUser.ReportPath & rptFileName)
        'Dim rpt As New reportYarnBalanceByItcd

        rpt.DataSourceConnections.Item(0).SetConnection(classCn.ServerName, classCn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@itcd_list", itemsList)
        rpt.SetParameterValue("@loc", txtLocation.Text.Trim) 'Sitthana 24/02/2018  -> Old data mtl_locations_id is null
        rpt.SetParameterValue("@showbeforedate", IIf(dtpDateShowBF.Checked, dtpDateShowBF.Value.Date, Now.Date))
        rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_locations_id", (New clsConfig).IsNull(cboNewmtl_locations_id.SelectedValue, Nothing)) 'Sitthana 24/02/2018, 03/03/2018 -> Cancel
        ' rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("itcd").CurrentValues)
        rpt.SetParameterValue("@p_itgroupcd", (New clsConfig).IsNull(cbitgroupcd.SelectedValue, "")) 'Sitthana 20190511

        If optBalShowBalanceMultiColumnSortByCode.Checked Then
            rpt.SetParameterValue("@p_SortBy", "CODE")
        ElseIf optBalShowBalanceMultiColumnSortByDescp.Checked Then
            rpt.SetParameterValue("@p_SortBy", "DESCP")
        End If

        Dim frmreport As New formCRViewer
        frmreport.Text = "Show Balance by Itcd"
        frmreport.MdiParent = Me.MdiParent
        frmreport.CrystalReportViewer1.ReportSource = rpt
        frmreport.CrystalReportViewer1.Zoom(75)
        frmreport.CrystalReportViewer1.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
        frmreport.Show()
    End Sub

    Private Sub printBalanceByItcdUsage(ByVal itemsList As String)

        Dim config As New clsConfig
        Dim classCn As New classConnection
        'Dim itemsList As String
        'Dim I As Integer

        config.ChangeCulture()

        'itemsList = ""

        'For I = 0 To Me.dgselectItem.Rows.Count - 1
        '    If Me.dgselectItem.Rows(I).Cells("colSelect").Value = True Then
        '        'itemsList = itemsList & "'" & Me.dgselectItem.Rows(i).Cells("colitcd").Value.ToString.Trim & "',"
        '        itemsList = itemsList & Me.dgselectItem.Rows(I).Cells("colitcd").Value.ToString.Trim & ","
        '    End If
        'Next

        'If itemsList.Length > 1 Then itemsList = Mid(itemsList.ToString, 1, itemsList.Length - 1)

        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        'Dim rptFileName As String = "reportYarnBalanceByItcdUsage.rpt"
        Dim rptFileName As String = "rptStockYOnhandBalanceByItcdUsage.rpt"
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsUser.ReportPath & rptFileName)
        'Dim rpt As New reportYarnBalanceByItcd

        rpt.DataSourceConnections.Item(0).SetConnection(classCn.ServerName, classCn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@itcd_list", itemsList)
        rpt.SetParameterValue("@loc", txtLocation.Text.Trim) 'Sitthana 24/02/2018  -> Old data mtl_locations_id is null
        rpt.SetParameterValue("@showbeforedate", IIf(dtpDateShowBF.Checked, dtpDateShowBF.Value.Date, Now.Date))
        rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_locations_id", (New clsConfig).IsNull(cboNewmtl_locations_id.SelectedValue, Nothing)) 'Sitthana 24/02/2018 03/03/2018 -> Cancel
        'rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("itcd").CurrentValues)
        rpt.SetParameterValue("@p_itgroupcd", (New clsConfig).IsNull(cbitgroupcd.SelectedValue, "")) 'Sitthana 20190511

        'rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("itcd").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.Database.Tables.Item("itcd"))
        'rpt.SetParameterValue("@p_item_code", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        'rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.Database.Tables.Item("itcd"))
        'rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("itcd").CurrentValues)
        'rpt.SetParameterValue("@p_item_code", rpt.Database.Tables.Item("itcd"), rpt.Subreports(0).Name.ToString())
        'ParameterFields
        Dim frmreport As New formCRViewer
        frmreport.Text = "Show Balance by Itcd Usage"
        frmreport.MdiParent = Me.MdiParent
        frmreport.CrystalReportViewer1.ReportSource = rpt
        frmreport.CrystalReportViewer1.Zoom(75)
        frmreport.CrystalReportViewer1.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
        frmreport.Show()
    End Sub
    Private Sub printBalanceByItcdSummary(ByVal itemsList As String)
        Dim config As New clsConfig
        Dim classCn As New classConnection
        config.ChangeCulture()
        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Dim rptFileName As String = "rptStockYOnhandBalanceByItcdSummary.rpt"
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(classCn.ServerName, classCn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@itcd_list", itemsList)
        rpt.SetParameterValue("@loc", txtLocation.Text.Trim) 'Sitthana 24/02/2018  -> Old data mtl_locations_id is null
        rpt.SetParameterValue("@showbeforedate", IIf(dtpDateShowBF.Checked, dtpDateShowBF.Value.Date, Now.Date))
        rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_locations_id", (New clsConfig).IsNull(cboNewmtl_locations_id.SelectedValue, Nothing)) 'Sitthana 24/02/2018, 03/03/2018 -> Cancel
        rpt.SetParameterValue("@p_itgroupcd", (New clsConfig).IsNull(cbitgroupcd.SelectedValue, "")) 'Sitthana 20190511

        Dim frmreport As New formCRViewer
        frmreport.Text = "Show Balance by yarn code Summary"
        frmreport.MdiParent = Me.MdiParent
        frmreport.CrystalReportViewer1.ReportSource = rpt
        frmreport.CrystalReportViewer1.Zoom(75)
        frmreport.CrystalReportViewer1.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
        frmreport.Show()

        'Dim frm As New frmReport
        'frm.Title = "Show Balance by yarn code Summary"
        'frm.CRViewer.ReportSource = rpt
        'frm.MdiParent = Me.ParentForm
        'frm.Show()
        'Me.Cursor = Cursors.Default
    End Sub
    Private Sub printBalanceByLoc(ByVal itemsList As String)

        Dim config As New clsConfig
        Dim classCn As New classConnection
        'Dim itemsList As String
        'Dim I As Integer

        config.ChangeCulture()

        'itemsList = ""

        'For I = 0 To Me.dgselectItem.Rows.Count - 1
        '    If Me.dgselectItem.Rows(I).Cells("colSelect").Value = True Then
        '        'itemsList = itemsList & "'" & Me.dgselectItem.Rows(i).Cells("colitcd").Value.ToString.Trim & "',"
        '        itemsList = itemsList & Me.dgselectItem.Rows(I).Cells("colitcd").Value.ToString.Trim & ","
        '    End If
        'Next

        'If itemsList.Length > 1 Then itemsList = Mid(itemsList.ToString, 1, itemsList.Length - 1)

        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        ' Dim rptFileName As String = "reportYarnBalanceByLoc.rpt"
        Dim rptFileName As String = "rptStockYOnhandBalanceByLoc.rpt"
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsUser.ReportPath & rptFileName)
        'Dim rpt As New reportYarnBalanceByItcd

        rpt.DataSourceConnections.Item(0).SetConnection(classCn.ServerName, classCn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@itcd_list", itemsList)
        rpt.SetParameterValue("@loc", txtLocation.Text.Trim) 'Sitthana 24/02/2018  -> Old data mtl_locations_id is null
        rpt.SetParameterValue("@showbeforedate", IIf(dtpDateShowBF.Checked, dtpDateShowBF.Value.Date, Now.Date))
        rpt.SetParameterValue("@mtl_warehouse_id", (New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_subinventory_id", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        rpt.SetParameterValue("@mtl_locations_id", (New clsConfig).IsNull(cboNewmtl_locations_id.SelectedValue, Nothing)) 'Sitthana 24/02/2018
        '  rpt.SetParameterValue("@p_itgroupcd", (New clsConfig).IsNull(cbitgroupcd.SelectedValue, "")) 'Sitthana 20190511

        'rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("itcd").CurrentValues)

        'rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("itcd").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.Database.Tables.Item("itcd"))
        'rpt.SetParameterValue("@p_item_code", (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing))
        'rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.Database.Tables.Item("itcd"))
        'rpt.DataDefinition.ParameterFields("@p_item_code", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("itcd").CurrentValues)
        'rpt.SetParameterValue("@p_item_code", rpt.Database.Tables.Item("itcd"), rpt.Subreports(0).Name.ToString())
        'ParameterFields
        Dim frmreport As New formCRViewer
        frmreport.Text = "Show Balance by Locations"
        frmreport.MdiParent = Me.MdiParent
        frmreport.CrystalReportViewer1.ReportSource = rpt
        frmreport.CrystalReportViewer1.Zoom(75)
        frmreport.CrystalReportViewer1.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
        frmreport.Show()
    End Sub

    Private Sub optBalByBox_CheckedChanged(sender As Object, e As EventArgs) Handles optBalByBox.CheckedChanged


        If optBalByBox.Checked Then
            optBalByBoxWithMove.Checked = False
            optMoveByItcd.Checked = False
            optMoveByBatch.Checked = False

            dtpDateShowBF.Checked = True
            dtpDateShowBF.Enabled = True
            dtpDateFr.Checked = False
            dtpDateFr.Enabled = False
            dtpDateTo.Checked = False
            dtpDateTo.Enabled = False
        End If

    End Sub

    Private Sub optBalByItcd_CheckedChanged(sender As Object, e As EventArgs) Handles optBalByItcd.CheckedChanged


        If optBalByItcd.Checked Then
            '  optBalShowBalanceMultiColumnSortByCode.Checked = True
            optBalByBoxWithMove.Checked = False
            optMoveByItcd.Checked = False
            optMoveByBatch.Checked = False

            dtpDateShowBF.Checked = True
            dtpDateShowBF.Enabled = True
            dtpDateFr.Checked = False
            dtpDateFr.Enabled = False
            dtpDateTo.Checked = False
            dtpDateTo.Enabled = False
        End If


        'dtpDateFr.Checked = False
        'dtpDateTo.Checked = False

        'dtpDateFr.Enabled = False
        'dtpDateTo.Enabled = False
    End Sub

    Private Sub optBalByBoxWithMove_CheckedChanged(sender As Object, e As EventArgs) Handles optBalByBoxWithMove.CheckedChanged

        If optBalByBoxWithMove.Checked Then
            optBalByBox.Checked = False
            optBalByBoxGrpByLocation.Checked = False
            optBalByItcd.Checked = False
            optBalShowBalanceMultiColumnSortByCode.Checked = False
            optBalShowBalanceMultiColumnSortByDescp.Checked = False
            optBalByItcdUsage.Checked = False
            optBalByItcdSummary.Checked = False
            optBalByLoc.Checked = False


            dtpDateShowBF.Checked = False
            dtpDateShowBF.Enabled = False
            dtpDateFr.Checked = True
            dtpDateFr.Enabled = True
            dtpDateTo.Checked = True
            dtpDateTo.Enabled = True
        End If


    End Sub

    Private Sub optMoveByItcd_CheckedChanged(sender As Object, e As EventArgs) Handles optMoveByItcd.CheckedChanged

        If optMoveByItcd.Checked Then
            optBalByBox.Checked = False
            optBalByBoxGrpByLocation.Checked = False
            optBalByItcd.Checked = False
            optBalShowBalanceMultiColumnSortByCode.Checked = False
            optBalShowBalanceMultiColumnSortByDescp.Checked = False
            optBalByItcdUsage.Checked = False
            optBalByItcdSummary.Checked = False
            optBalByLoc.Checked = False

            dtpDateShowBF.Checked = False
            dtpDateShowBF.Enabled = False
            dtpDateFr.Checked = True
            dtpDateFr.Enabled = True
            dtpDateTo.Checked = True
            dtpDateTo.Enabled = True
        End If


    End Sub

    Private Sub optMoveByBatch_CheckedChanged(sender As Object, e As EventArgs) Handles optMoveByBatch.CheckedChanged

        If optMoveByBatch.Checked Then
            optBalByBox.Checked = False
            optBalByBoxGrpByLocation.Checked = False
            optBalByItcd.Checked = False
            optBalShowBalanceMultiColumnSortByCode.Checked = False
            optBalShowBalanceMultiColumnSortByDescp.Checked = False
            optBalByItcdUsage.Checked = False
            optBalByItcdSummary.Checked = False
            optBalByLoc.Checked = False

            dtpDateShowBF.Checked = False
            dtpDateShowBF.Enabled = False
            dtpDateFr.Checked = True
            dtpDateFr.Enabled = True
            dtpDateTo.Checked = True
            dtpDateTo.Enabled = True
        End If


    End Sub

    Private Sub UncheckRecursive(ByVal element As Control)
        If TypeOf element Is CheckBox Then
            DirectCast(element, CheckBox).Checked = False
        Else
            For Each childElement In element.Controls
                Me.UncheckRecursive(childElement)
            Next
        End If
    End Sub

    Private Sub cboNewmtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboNewmtl_warehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing))
        'Call Setdefaultsubinventory(cboNewmtl_subinventory.DataSource)
    End Sub

    Private Sub cboNewmtl_subinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cboNewmtl_subinventory.DropDownClosed
        GetComboNewLocation((New clsConfig).IsNull(cboNewmtl_warehouse.SelectedValue, Nothing),
                           (New clsConfig).IsNull(cboNewmtl_subinventory.SelectedValue, Nothing)
                           )
        txtLocation.Text = ""
    End Sub

    Private Sub optBalByBoxWithMove_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles optBalByBoxWithMove.CheckedChanged
        'Dim ChkBox As CheckBox = Nothing
        ' to unchecked all 



        ' to checked all 
        'For Each xObject As Object In Me.GroupBox1.Controls
        '    If TypeOf xObject Is CheckBox Then
        '        ChkBox = xObject
        '        ChkBox.Checked = True
        '    End If
        'Next

    End Sub

    Private Sub optMoveByItcd_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles optMoveByItcd.CheckedChanged
        ' Dim ChkBox As CheckBox = Nothing
        ' to unchecked all 

    End Sub

    Private Sub optMoveByBatch_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles optMoveByBatch.CheckedChanged
        'Dim ChkBox As CheckBox = Nothing
        ' to unchecked all 

    End Sub

    Private Sub optBalByBox_Validated(sender As Object, e As System.EventArgs) Handles optBalByBox.Validated
        'If optBalByBox.Checked Then
        '    If optMoveByBatch.Checked Then
        '        optBalByBox.Checked = False
        '        optBalByItcd.Checked = False
        '    End If
        'End If
    End Sub

    Private Sub optBalByItcdUsage_CheckedChanged(sender As Object, e As EventArgs) Handles optBalByItcdUsage.CheckedChanged
        If optBalByItcdUsage.Checked Then
            optBalByBoxWithMove.Checked = False
            optMoveByItcd.Checked = False
            optMoveByBatch.Checked = False

            dtpDateShowBF.Checked = True
            dtpDateShowBF.Enabled = True
            dtpDateFr.Checked = False
            dtpDateFr.Enabled = False
            dtpDateTo.Checked = False
            dtpDateTo.Enabled = False
        End If

    End Sub

    Private Sub optBalByLocation_CheckedChanged(sender As Object, e As EventArgs) Handles optBalByLoc.CheckedChanged
        If optBalByLoc.Checked Then
            optBalByBoxWithMove.Checked = False
            optMoveByItcd.Checked = False
            optMoveByBatch.Checked = False

            dtpDateShowBF.Checked = True
            dtpDateShowBF.Enabled = True
            dtpDateFr.Checked = False
            dtpDateFr.Enabled = False
            dtpDateTo.Checked = False
            dtpDateTo.Enabled = False

        End If
    End Sub

    Private Sub cboNewmtl_locations_id_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNewmtl_locations_id.SelectedIndexChanged
        txtLocation.Text = cboNewmtl_locations_id.Text
    End Sub

    Private Sub txtlookup_TextChanged(sender As Object, e As EventArgs) Handles txtlookup.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub optBalByItcdSummary_CheckedChanged(sender As Object, e As EventArgs) Handles optBalByItcdSummary.CheckedChanged
        If optBalByItcdSummary.Checked Then
            optBalByBoxWithMove.Checked = False
            optMoveByItcd.Checked = False
            optMoveByBatch.Checked = False

            dtpDateShowBF.Checked = True
            dtpDateShowBF.Enabled = True
            dtpDateFr.Checked = False
            dtpDateFr.Enabled = False
            dtpDateTo.Checked = False
            dtpDateTo.Enabled = False
        End If
    End Sub

    Private Sub optBalByBoxGrpByLocation_CheckedChanged(sender As Object, e As EventArgs) Handles optBalByBoxGrpByLocation.CheckedChanged
        If optBalByBoxGrpByLocation.Checked Then
            optBalByBoxWithMove.Checked = False
            optMoveByItcd.Checked = False
            optMoveByBatch.Checked = False

            dtpDateShowBF.Checked = True
            dtpDateShowBF.Enabled = True
            dtpDateFr.Checked = False
            dtpDateFr.Enabled = False
            dtpDateTo.Checked = False
            dtpDateTo.Enabled = False
        End If
    End Sub
End Class