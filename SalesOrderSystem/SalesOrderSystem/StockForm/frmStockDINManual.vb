Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class frmStockDINManual
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim blnLocked As Boolean = False
    Dim blnCancel As Boolean = False
    ' Dim dbPackingListD As New class
    Dim dbStockD As New classStockD

    Dim strlot As String = ""
    Dim StrRollNog As String = ""
    Dim strRollNoD As String = ""
    Dim strDinno As String = ""
    Dim strsono As String = ""
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

    Dim newRow As DataRow
    Private ds As New DataSet
    Private connStr As New classConnection
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub frmStockDINManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call GenComboDINNo()
        Call GenCombo()
        Call GentextAutoComplate()
        Call InitControl()
    End Sub

    Private Sub GentextAutoComplate()
        Dim dtDF As DataTable = (New classDINManual).GetDForderNo
        Dim rowDf As DataRow
        txtDFNo.AutoCompleteSource = AutoCompleteSource.None
        txtDFNo.AutoCompleteMode = AutoCompleteMode.None
        txtDFNo.AutoCompleteCustomSource.Clear()
        For Each rowDf In dtDf.Rows
            txtDFNo.AutoCompleteCustomSource.Add(rowDf.Item("dfno").ToString())
        Next
        txtDFNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtDFNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub
    Private Sub GenCombo()

        ' cboDyedHouse.DataSource = (New classMaster).GetSupplier
        '  cboDyedHouse.DisplayMember = "name"
        ' cboDyedHouse.ValueMember = "suppcd"

        Me.cboDyedHouse.DataSource = (New classMaster).GetDyedHouse
        Me.cboDyedHouse.DisplayMember = "name"
        Me.cboDyedHouse.ValueMember = "suppcd2"
        Me.cboDyedHouse.SelectedIndex = -1
    End Sub
    Private Sub GenComboDINNo()
        Dim objDB As New classStockD
        cboDinNo.ComboBox.DataSource = objDB.GetDINmanualNo()
        cboDinNo.ComboBox.DisplayMember = "dinno"
        cboDinNo.ComboBox.ValueMember = "dinno"

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click

        Me.WindowState = FormWindowState.Maximized

        Call GenComboDINNo()
        Call GenCombo()
        Call GentextAutoComplate()
        Call InitControl()
    End Sub
    Private Sub InitControl()
        txtDINNo.Text = ""
        dtpDINDate.Value = Today
        txtDFNo.Text = ""
        txtLotNo.Text = ""
        txtBillNo.Text = ""
        txtRemark.Text = ""
        Call BindGrid(grdData, (New classStockD).GetDIN("0", "", "", clsUser.UserID))
        'txtDFNo.Text = ""
        txtDFNo.Focus()
    End Sub
    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
        'Dim dsEmp As New DataSet
        'dsEmp = getemp.GetEmpData
        'dtEmp = dsEmp.Tables.Add("Emp")
        'dsEmp.Tables.Add(dtEmp)

        ' txtLotNo.DataBindings.Add("Text", grd.DataSource, "FirstName")
        'txtLotNo.DataBindings.Add("lot", grd.DataSource, "lot")
        'myTextBox.DataBindings.Add("Text", myDataTable, "Name")
        SumGrdData()
    End Sub

    Private Sub cboDinNo_DropDown(sender As Object, e As System.EventArgs) Handles cboDinNo.DropDown

    End Sub
    Private Sub cboDinNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDinNo.DropDownClosed
        If clsConfig.IsNull(cboDinNo.ComboBox.SelectedValue, "").ToString.Length = 0 Then Exit Sub
        Call GetDIN(clsConfig.IsNull(cboDinNo.ComboBox.SelectedValue, ""))
        'Call LoadData(clsConfig.IsNull(cboDinNo.ComboBox.SelectedValue, ""))
    End Sub

    Private Sub LoadData(ByVal dinno As String)
        Dim objDB As New classStockD
        Dim dt As New DataTable
        dt = objDB.GetDINManual(dinno, clsUser.UserID)
        'Call InitControl()

        If dt.Rows.Count > 0 Then Call Binddata(dt)
        Call BindGrid(grdData, dt)
    End Sub
    Private Sub LoadDataDF(ByVal dfno As String)
        Dim objDB As New classStockD
        Dim dt As New DataTable
        dt = objDB.GetDForder(dfno, clsUser.UserID)
        'Call InitControl()
        If dt.Rows.Count > 0 Then Call BinddataText(dt)
        Call BindGridDF(grdData, dt)
    End Sub
    Private Sub BindGridDF(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
    End Sub
    Private Sub Binddata(ByVal dt As DataTable)
        Dim config As New clsConfig

        'config.IsNull(dt.Rows(0)("dodt"), Now)
        txtDINNo.Text = config.IsNull(dt.Rows(0)("dinno"), "")
        dtpDINDate.Value = CDate(config.IsNull(dt.Rows(0)("dindt"), ""))
        txtDFNo.Text = dt.Rows(0)("dfno")
        txtLotNo.Text = dt.Rows(0)("lot")
        txtBillNo.Text = dt.Rows(0)("dono")
        txtRemark.Text = dt.Rows(0)("rem_qc")
        cboDyedHouse.SelectedValue = dt.Rows(0)("dhcod")
        ' txttest.DataBindings.Add("dinno", dt, "dinno")

    End Sub
    Private Sub BinddataText(ByVal dt As DataTable)
        ' txtDINNo.Text = dt.Rows(0)("dinno")
        ' dtpDINDate.Value = CDate(dt.Rows(0)("dindt"))
        txtDFNo.Text = dt.Rows(0)("dfno")
        txtLotNo.Text = dt.Rows(0)("lot").ToString.Trim

        txtBillNo.Text = dt.Rows(0)("dono")
        txtRemark.Text = dt.Rows(0)("rem_qc")
        cboDyedHouse.SelectedValue = dt.Rows(0)("dhcod")

    End Sub

    Private Sub txtDFNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDFNo.KeyDown
        If txtDFNo.Text.Trim.Length = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            Call GetDForder(txtDFNo.Text.Trim)
        End If
    End Sub
    Private Function GetDForder(ByVal strDfNo As String) As Boolean
        Dim StrError As String = ""
        Dim dt As DataTable = dbStockD.GetDForder_Items(strDfNo, clsUser.UserID, StrError)

        If StrError.Length > 0 Then
            MessageBox.Show(StrError, "SyStem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

        If dt.Rows.Count > 0 Then
            'If grdData.Rows.Count > 0 Then grdData.Rows.Clear()

            Call BinddataText(dt)
            Call BindDataGrid(dt)

            Return True
        End If
        Return False
    End Function
    'Private Sub BindDataGrid(ByVal dt As DataTable)
    '    Dim config As New clsConfig
    '    If txtDFNo.Text = "" Then Exit Sub
    '    Dim k As Integer = 0

    '    grdData.AutoGenerateColumns = False
    '    If dt.Rows.Count > 0 Then
    '        Dim dtDF As DataTable = dt
    '        Dim dtDIN As DataTable = grdData.DataSource

    '        Dim dr As DataRow

    '        Dim msg As String = ""
    '        Dim RowNo As Integer = 0
    '        Dim ColNo As Integer = 0
    '        For RowNo = 0 To dtDF.Rows.Count - 1
    '            dr = dtDIN.NewRow
    '            For ColNo = 0 To dtDIN.Columns.Count - 1
    '                For Each dc As DataColumn In dtDIN.Columns
    '                    ' dr(dc.ColumnName) = dtDF.Rows(RowNo)(dc.ColumnName)
    '                    dr(dtDIN.Columns(ColNo).ColumnName) = dtDF.Rows(0)(dtDIN.Columns(ColNo).ColumnName)
    '                Next
    '            Next
    '            dtDIN.Rows.Add(dr)
    '        Next

    '    End If

    '    Call SumGrdData()

    'End Sub
    Private Sub BindDataGrid(ByVal dt As DataTable)

        If txtDFNo.Text = "" Then Exit Sub

        grdData.AutoGenerateColumns = False

        If dt.Rows.Count > 0 Then
            Dim dtDF As DataTable = dt
            Dim dtDIN As DataTable = CType(grdData.DataSource, DataTable)

            For RowNo As Integer = 0 To dtDF.Rows.Count - 1
                Dim dr As DataRow = dtDIN.NewRow()

                For Each column As DataColumn In dtDIN.Columns
                    If dtDF.Columns.Contains(column.ColumnName) Then
                        dr(column.ColumnName) = dtDF.Rows(RowNo)(column.ColumnName)
                    End If
                Next

                dtDIN.Rows.Add(dr)
            Next
        End If

        Call SumGrdData()

    End Sub
    Function getDIN(ByRef strDINNO As String) As Boolean

        Dim dt As DataTable = dbStockD.GetDINManual(strDINNO, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            'Dev By Neung 26/03/2015
            Call BindDINManual(dt)
            Call BindDataGridDIN(dt)
            Return True
        End If
        Return False

    End Function
    Private Sub BindDataGridDIN(ByVal dt As DataTable)
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub
    Private Sub BindDINManual(ByVal dt As DataTable)
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0

        'grdData.AutoGenerateColumns = False
        'grdData.DataSource = dt

        txtDFNo.Text = dt.Rows(0)("dfno").ToString.Trim()
        cboDyedHouse.SelectedValue = dt.Rows(0)("dhcod").ToString.Trim()
        txtBillNo.Text = dt.Rows(0)("dono").ToString.Trim()
        txtDINNo.Text = dt.Rows(0)("dinno").ToString.Trim()

        txtLotNo.Text = dt.Rows(0)("lot").ToString.Trim()
        dtpDINDate.Value = CDate(dt.Rows(0)("dindt").ToString)
        dtpdodt.Value = config.IsNull(dt.Rows(0)("dodt"), Now)
        txtRemark.Text = dt.Rows(0)("rem_qc")

        'Dim dtt As DataTable = grdData.DataSource
        ' txttest.DataBindings.Add("", dt, "lot")
        SumGrdData()

    End Sub
    Private Sub getDIN2(ByRef strDINNO As String)
        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        'Dim strsql2 As String
        Dim strmsg As String = ""

        Try
            Dim conn As New SqlConnection((New classConnection).connection)
            Dim comm As New SqlCommand("", conn)
            comm.CommandType = CommandType.StoredProcedure
            comm.CommandText = "p_strolls_d_in_manual_select"
            comm.Parameters.AddWithValue("@dinno", strDINNO)
            comm.Parameters.AddWithValue("@logempcd", clsUser.UserID)

            Dim da As New SqlDataAdapter(comm)
            If chkErrbutUseDforder_table_havedata(strmsg) = True Then
                ds.Tables("v_Strolls_d").Clear()
            End If
            da.Fill(ds, "v_strolls_d")


            '==================================================================================           
            If ds.Tables("v_strolls_d").Rows.Count > 0 Then
                dsTable = ds.Tables("v_strolls_d")
                Me.grdData.DataSource = dsTable
                Me.txtDFNo.Text = ds.Tables("v_strolls_d").Rows(0).Item("dfno").ToString.Trim
                Me.txtDINNo.Text = ds.Tables("v_strolls_d").Rows(0).Item("dinno").ToString.Trim
                Me.txtBillNo.Text = ds.Tables("v_strolls_d").Rows(0).Item("dono").ToString.Trim
                Me.txtLotNo.Text = ds.Tables("v_strolls_d").Rows(0).Item("lot").ToString.Trim

            Else
                Me.grdData.DataSource = ""
                MsgBox("ไม่พบข้อมูล !", MsgBoxStyle.Critical, "กรุณาตรวจสอบหมายเลข DFOrder no:")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub getDFOrder2(ByRef strDfNo As String)
        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        'Dim strsql2 As String
        Dim strmsg As String = ""

        Try
            Dim conn As New SqlConnection((New classConnection).connection)
            Dim comm As New SqlCommand("", conn)
            comm.CommandType = CommandType.StoredProcedure
            comm.CommandText = "p_strolls_d_in_manual_dforder_select"
            comm.Parameters.AddWithValue("@dfno", strDfNo)
            comm.Parameters.AddWithValue("@logempcd", clsUser.UserID)

            Dim da As New SqlDataAdapter(comm)
            'strsql2 = "select dfi.dfno as dfno,dfi.design_no_fg as design_no,d.Fwth as fwth,dfi.col as col,dfi.custcolor as custcolor,isnull(g.grade,'') as gr,'' as roll_no_d,dfi.roll_no_o as roll_no_o,dfi.sonoid as sonoid,dfi.qc_kg as kg,dfi.qc_mts as mts,dfi.qc_yds as yds,dfi.lot as lot from dforder_items dfi left join dforder df on df.dfno = dfi.dfno left join designs d on d.Design_no = dfi.design_no_fg left join Greige g on g.roll_no_o = dfi.roll_no_o where dfi.dfno = '" & Me.txtDFNo.Text.Trim & "'"
            'Dim da As New SqlDataAdapter(strsql2.ToString, connStr.ConnectionString)
            If chkErrbutUseDforder_table_havedata(strmsg) = True Then
                ds.Tables("v_Strolls_d").Clear()
            End If
            da.Fill(ds, "v_strolls_d")


            '==================================================================================           
            If ds.Tables("v_strolls_d").Rows.Count > 0 Then
                dsTable = ds.Tables("v_strolls_d")
                Me.grdData.DataSource = dsTable
                Me.txtDFNo.Text = ds.Tables("v_strolls_d").Rows(0).Item("dfno").ToString.Trim

                Me.txtLotNo.Text = ds.Tables("v_strolls_d").Rows(0).Item("lot").ToString.Trim
                Me.txtRemark.Text = ds.Tables("v_strolls_d").Rows(0).Item("remark").ToString.Trim
            Else
                Me.grdData.DataSource = ""
                MsgBox("ไม่พบข้อมูล !", MsgBoxStyle.Critical, "กรุณาตรวจสอบหมายเลข DFOrder no:")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Function chkErrbutUseDforder_table_havedata(ByVal strmsg As String) As Boolean
        Try
            ds.Tables("v_Strolls_d").Clear()
            chkErrbutUseDforder_table_havedata = True
        Catch ex As Exception
            chkErrbutUseDforder_table_havedata = False
            Exit Function
        End Try
    End Function

    Private Sub txtDFNo_QueryContinueDrag(sender As Object, e As System.Windows.Forms.QueryContinueDragEventArgs) Handles txtDFNo.QueryContinueDrag

    End Sub

    Private Sub txtDFNo_Resize(sender As Object, e As System.EventArgs) Handles txtDFNo.Resize

    End Sub

    Private Sub txtDFNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDFNo.TextChanged

    End Sub

    Private Sub cboDinNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDinNo.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs)
        'Dim strsonoip As String

        Call GetCopyRoll(strRollNoD)

    End Sub
    Private Function GetCopyRoll(ByVal StrRollNod As String) As Boolean
        Dim clsconfig As New clsConfig
        Dim dtc As DataTable = grdData.DataSource
        If grdData.Rows.Count > 0 Then
            'strlot = grdData.CurrentRow.Cells("lot").Value
            'strsono = clsconfig.IsNull(grdData.CurrentRow.Cells("sono").Value, "")
            'strSonoid = clsconfig.IsNull(grdData.CurrentRow.Cells("sonoid").Value, "")
            'strDesign_no = grdData.CurrentRow.Cells("Design_no").Value
            'strGwth = grdData.CurrentRow.Cells("gwth").Value
            'strFwth = grdData.CurrentRow.Cells("fwth").Value
            'strcol = grdData.CurrentRow.Cells("col").Value
            'strcustcolor = grdData.CurrentRow.Cells("custcolor").Value
            'strgr = grdData.CurrentRow.Cells("gr").Value
            'StrRollNog = grdData.CurrentRow.Cells("roll_no_g").Value
            'StrRollNod = grdData.CurrentRow.Cells("roll_no_d").Value
            'strRollNoO = grdData.CurrentRow.Cells("roll_no_o").Value
            'strkg = grdData.CurrentRow.Cells("kg").Value
            'strmts = grdData.CurrentRow.Cells("mts").Value
            'stryds = grdData.CurrentRow.Cells("yds").Value
            'strRollNoF = grdData.CurrentRow.Cells("roll_no_f").Value

            newRow = dtc.NewRow

            newRow.Item("lot") = grdData.CurrentRow.Cells("lot").Value
            newRow.Item("sono") = clsconfig.IsNull(grdData.CurrentRow.Cells("sono").Value, "")
            newRow.Item("sonoid") = clsconfig.IsNull(grdData.CurrentRow.Cells("sonoid").Value, "")
            newRow.Item("Design_no") = grdData.CurrentRow.Cells("Design_no").Value
            newRow.Item("gwth") = grdData.CurrentRow.Cells("gwth").Value
            newRow.Item("fwth") = grdData.CurrentRow.Cells("fwth").Value
            newRow.Item("col") = grdData.CurrentRow.Cells("col").Value
            newRow.Item("custcolor") = grdData.CurrentRow.Cells("custcolor").Value
            newRow.Item("gr") = grdData.CurrentRow.Cells("gr").Value
            newRow.Item("roll_no_o") = grdData.CurrentRow.Cells("roll_no_o").Value
            newRow.Item("roll_no_g") = grdData.CurrentRow.Cells("roll_no_g").Value
            newRow.Item("roll_no_d") = "NEW"
            newRow.Item("kg") = grdData.CurrentRow.Cells("kg").Value
            newRow.Item("mts") = grdData.CurrentRow.Cells("mts").Value
            newRow.Item("yds") = grdData.CurrentRow.Cells("yds").Value
            newRow.Item("roll_no_f") = grdData.CurrentRow.Cells("roll_no_f").Value

            'newRow.Item("lot") = strlot
            'newRow.Item("sono") = strsono
            'newRow.Item("sonoid") = strSonoid
            'newRow.Item("Design_no") = strDesign_no
            'newRow.Item("gwth") = strGwth
            'newRow.Item("fwth") = strFwth
            'newRow.Item("col") = strcol
            'newRow.Item("custcolor") = strcustcolor
            'newRow.Item("gr") = strgr
            'newRow.Item("roll_no_o") = strRollNoO
            'newRow.Item("roll_no_g") = strRollNoG
            'newRow.Item("roll_no_d") = "NEW"
            'newRow.Item("kg") = strkg
            'newRow.Item("mts") = strmts
            'newRow.Item("yds") = stryds
            'newRow.Item("roll_no_f") = strRollNoF
            dtc.Rows.Add(newRow)

            Return True
        End If

        Return False

        'If GetCopyRoll(StrRollNod) Then

        'End If
        ''Dim i As Integer = e.RowIndex
        'Dim copyItcd As String
        'Dim copyBoxno As String
        'Dim copyGrade As String
        'Dim copyBoxno_s As String
        'Dim newRow As DataRow

        'Dim dt As DataTable = dbStockD.GetStrollsD(StrRollNod, "")
        'If dt.Rows.Count > 0 Then
        '    Call BindDataREQG(dt)
        '    txtReqNo.Text = dt.Rows(0)("outreqno").ToString()

        '    'CboCartonsNo.DataSource = dt
        '    ' CboCartonsNo.DisplayMember = "custcd"
        '    ' CboCartonsNo.DisplayMember = "custname"
        '    txtcustomer.Text = dt.Rows(0)("custname").ToString()
        '    CboDoc_type.SelectedValue = dt.Rows(0)("outreqtyp").ToString()
        '    Return True
        'End If
        'Return False
    End Function
    Private Sub DgYarn_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) 'Handles DgYarn.CellDoubleClick
        'If DgYarn.DataSource Is Nothing Then Exit Sub

        'Dim i As Integer = e.RowIndex
        'Dim copyItcd As String
        'Dim copyBoxno As String
        'Dim copyGrade As String
        'Dim copyBoxno_s As String
        'Dim newRow As DataRow
        ''Dim copySpools As Integer
        ''Dim copyBoxno_o As String
        ''Dim copyKg_gr As Double
        ''Dim copySpool_tearwt As Double
        ''Dim copyCart_tearwt As Double
        ''Dim copyKg_nt As Double

        'copyItcd = DgYarn.Rows(i).Cells.Item("sonoid").Value
        'copyBoxno = DgYarn.Rows(i).Cells.Item("Boxno").Value
        'copygrade = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("Grade").Value.ToString)
        'copyBoxno_s = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("boxno_s").Value)
        ''copySpools = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("spools").Value)
        ''copyKg_gr = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_gr").Value)
        ''copyCart_tearwt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_gr2").Value)
        ''copySpool_tearwt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("spool_tearwt").Value)
        ''copyKg_nt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("kg_nt").Value)
        'copyBoxno_s = Clsconfig.IsValidString(Me.DgYarn.Rows(i).Cells("boxno_s").Value.ToString)

        'newRow = ds.Tables("v_YarnInReturn").NewRow
        'newRow.Item("itcd") = copyItcd
        'newRow.Item("boxno") = copyBoxno
        'newRow.Item("grade") = copyGrade
        'ds.Tables("v_YarnInReturn").Rows.Add(newRow)

    End Sub


    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmStockDINManual_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to close ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub grdData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellContentClick
        'grdData.SelectedRows
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not Checkdata Then Exit Sub

        If SaveDIN() Then

            ErrorProvider1.Clear()
            Call GenComboDINNo()
            Call GenCombo()
            Call GentextAutoComplate()
            Call getDIN(clsConfig.IsNull(strDinno, ""))

        End If
        '
    End Sub

    Private Function Checkdata() As Boolean
        Dim result As Boolean = True

        If Not (New classDINManual).ValidateDFNO(txtDFNo.Text.Trim) Then
            MessageBox.Show("D/F no ไม่ถูกต้อง", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(txtDFNo, "D/F no ไม่ถูกต้อง")
            result = False
        End If

        Return result
    End Function



    Private Function SaveDIN() As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockD
        Dim Din_header As New classStockD.Strolls_DHeader
        Dim msgerr As String = ""
        Dim DINNo As String = strDinno


        Din_header.h01_dinno = Me.txtDINNo.Text.Trim
        Din_header.h02_dindt = Me.dtpDINDate.Value
        Din_header.h03_doctyp = "D"
        Din_header.h04_dhcod = cboDyedHouse.SelectedValue
        Din_header.h05_dhdono = Me.txtBillNo.Text.Trim
        Din_header.h06_dhdodt = Me.dtpdodt.Value
        Din_header.h07_dfno = Me.txtDFNo.Text.Trim
        Din_header.h08_dono = Me.txtBillNo.Text.Trim
        'If txtBillNo.Text.Trim = "" Then Din_header.h09_dodt = ""
        'If txtBillNo.Text.Trim <> "" Then Din_header.h09_dodt = dtpdodt.Value
        Din_header.h09_dodt = Me.dtpdodt.Value
        'Din_header.h10_design_no = ds.Tables("v_strolls_d").Rows(0).Item("design_no").ToString.Trim
        Din_header.h13_lot = txtLotNo.Text.Trim

        'Din_header.h14_yr = ""
        'Din_header.h15_sh = ""
        'Din_header.h16_col = ""
        'Din_header.h17_Gr = ""
        'Din_header.h18_mtkg = 0
        'Din_header.h19_roll_no_d
        Din_header.h34_lotbatno = txtLotNo.Text.Trim
        Din_header.h36_loc = "NEW"
        Din_header.h38_batch = txtLotNo.Text.Trim
        Din_header.h45_unit = "K"


        Dim dtc As DataTable = grdData.DataSource


        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        '----------------------------------------- Auto Set Bill No. Disible
        If Not txtBillNo.Text.Trim = "DI14OPBAL" Then
            For Each dr As DataRow In dtc.Rows
                'If Not dr("dono").ToString().Trim.Equals(txtBillNo.Text.Trim) Then
                '    dr.Item("dono") = txtBillNo.Text.Trim
                'End If

            Next
        End If
        '-------------------------------------------



        If objDB.Dinsave(Din_header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsUser.UserID, DINNo) Then
            strDinno = DINNo
            MessageBox.Show("บันทึกสำเร็จ!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveDIN = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveDIN = False
        End If

    End Function

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to cancel document no. " & txtDINNo.Text & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Dim message As String = ""
        If (New classStock).CancelDIN(txtDINNo.Text, clsUser.UserID, message) Then
            MessageBox.Show("ยกเลิกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            btnNew_Click(sender, e)
        Else
            MessageBox.Show(message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

        'BFCancelDIN()
    End Sub

    Private Function CheckDataCancel() As Boolean
        If txtDINNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก D IN No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function
    Private Sub BFCancelDIN()
        If strDinno = "" Then strDinno = txtDINNo.Text.Trim.ToUpper
        If strDinno.Length = 0 Then Exit Sub
        If grdData.DataSource Is Nothing Then Exit Sub
        If grdData.DataSource Is Nothing Then Exit Sub
        If grdData.Rows.Count = 0 Then Exit Sub
        If grdData.Rows.Count = 0 Then Exit Sub


        If blnCancel Then Exit Sub
        'If lblCancelled.Visible Then
        '    MessageBox.Show("This document is already cancelled." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End If
        'Dim obj As New classPackingListG
        'If obj.IsAlreadyGOUT(strPacking_no) = True Then
        '    MessageBox.Show("This document is already GOUT." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End If
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
        DINHeader.h07_dfno = Me.txtDFNo.Text.Trim
        DINHeader.h08_dono = Me.txtBillNo.Text.Trim
        DINHeader.h09_dodt = dtpdodt.Value
        'Din_header.h10_design_no = ds.Tables("v_strolls_d").Rows(0).Item("design_no").ToString.Trim
        DINHeader.h13_lot = txtLotNo.Text.Trim
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
            MessageBox.Show("Cancel is Complete! : ยกเลิกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            CancelDIN = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            CancelDIN = False
        End If

    End Function

    Private Sub CalGrdData(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
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
        If grdData.Columns(e.ColumnIndex).Name = "mts" Then
            'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)
            grdData.Rows(e.RowIndex).Cells("yds").Value = config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0) / 0.9144
            'grdData.Rows(e.RowIndex).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("mts").Value, 0) / 0.9144, 4, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)

        End If

        If grdData.Columns(e.ColumnIndex).Name = "yds" Then
            'grdData.Rows(e.RowIndex).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144, 2, TriState.False, TriState.False, TriState.True)
            grdData.Rows(e.RowIndex).Cells("mts").Value = config.IsNull(grdData.Rows(e.RowIndex).Cells("yds").Value, 0) * 0.9144
        End If

        'For j = 0 To grdData.Rows.Count - 1
        'grdData.Rows(i).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(i).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)

        'grdData.Rows(j).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(j).Cells("mts").Value, 0) / 0.9144, 2, TriState.False, TriState.False, TriState.True)
        'Next
    End Sub
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

        'For j = 0 To grdData.Rows.Count - 1
        'grdData.Rows(i).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(i).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)

        'grdData.Rows(j).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(j).Cells("mts").Value, 0) / 0.9144, 2, TriState.False, TriState.False, TriState.True)
        'Next


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

    Private Sub btnSearchDFNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchDFNo.Click
        Dim frm As New frmDyingOrderSearch
        frm.ShowDialog(Me)
        txtDFNo.Text = (frm.pDFNo)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then GetDForder(txtDFNo.Text)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs)
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptDINManual.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
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
        'rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinno", txtDINNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grdData_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdData.CellEndEdit
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdData.Columns(e.ColumnIndex).Name = "kg" Or
         grdData.Columns(e.ColumnIndex).Name = "yds" Or
         grdData.Columns(e.ColumnIndex).Name = "mts" Then
            If CBool(chkAutoCalculate.Checked) Then
                Dim dt As DataTable = grdData.DataSource
                Dim i As Integer = CheckDelRow(dt)
                If grdData.Columns(e.ColumnIndex).Name = "kg" Then
                    dt.Rows(e.RowIndex + i)("yds") = FormatNumber(dt.Rows(e.RowIndex + i)("kg") * dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
                    dt.Rows(e.RowIndex + i)("mts") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdData.Columns(e.ColumnIndex).Name = "yds" Then
                    If Val(dt.Rows(e.RowIndex + i)("ydkg")) > 0 Then dt.Rows(e.RowIndex + i)("kg") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") / dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
                    dt.Rows(e.RowIndex + i)("mts") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdData.Columns(e.ColumnIndex).Name = "mts" Then
                    dt.Rows(e.RowIndex + i)("yds") = FormatNumber(dt.Rows(e.RowIndex + i)("mts") / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    If Val(dt.Rows(e.RowIndex + i)("ydkg")) > 0 Then dt.Rows(e.RowIndex + i)("kg") = FormatNumber(dt.Rows(e.RowIndex + i)("yds") / dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
                End If
            End If

        End If

        Call SumGrdData()

    End Sub

    Private Function CheckDelRow(ByVal dt As DataTable) As Integer 'Add By Neung 20151222
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState = DataRowState.Deleted Then j = j + 1
        Next
        Return j
    End Function

    Private Sub GenYds()
        Dim config As New clsConfig

        For j = 0 To grdData.Rows.Count - 1
            'grdData.Rows(j).Cells("mts").Value = FormatNumber(config.IsNull(grdData.Rows(j).Cells("mts").Value, 0), 2, TriState.False, TriState.False, TriState.True)

            'grdData.Rows(j).Cells("mts").Value = config.IsNull(grdData.Rows(j).Cells("yds").Value, 0) * 0.9144
            grdData.Rows(j).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(j).Cells("mts").Value, 0) / 0.9144, 2, TriState.False, TriState.False, TriState.True)
        Next

    End Sub
    Private Sub GenMts()
        Dim config As New clsConfig

        For j = 0 To grdData.Rows.Count - 1
            grdData.Rows(j).Cells("mts").Value = config.IsNull(grdData.Rows(j).Cells("yds").Value, 0) * 0.9144

            'grdData.Rows(j).Cells("yds").Value = FormatNumber(config.IsNull(grdData.Rows(j).Cells("mts").Value, 0) / 0.9144, 2, TriState.False, TriState.False, TriState.True)
        Next



    End Sub

    Private Sub btnGenYds_Click(sender As System.Object, e As System.EventArgs)
        GenYds()
    End Sub

    Private Sub btnGenMts_Click(sender As System.Object, e As System.EventArgs)
        GenMts()
    End Sub

    Private Sub btnSearchDoNo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCopyRoll_Click(sender As Object, e As EventArgs) Handles BtnCopyRoll.Click
        Call GetCopyRoll(strRollNoD)
    End Sub

    Private Sub tsbDInTag_Click(sender As Object, e As EventArgs) Handles tsbDInTag.Click

    End Sub
    Private Sub PrintReport(pReportName As String)
        Dim clsConfig As New clsConfig
        'Dim rptFileName = "rptStockDBarcode.rpt" 'Sitthana 20210118
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, pReportName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & pReportName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        'rpt.VerifyDatabase()
        'With grdData
        ' If .Rows.Count > 0 Then
        rpt.SetParameterValue("@roll_no", txtDINNo.Text.Trim) '.Rows(.CurrentRow.Index).Cells("roll_no_d").Value)
        rpt.SetParameterValue("@loc", "") '.Rows(.CurrentRow.Index).Cells("loc").Value)
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)
        '   Else
        '    MessageBox.Show("ไม่มีข้อมูลใน grid", "Mistake (ข้อผิดพลาด)", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Exit Sub
        'End If
        'End With

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub tsmnDINTagStandard_Click(sender As Object, e As EventArgs) Handles tsmnDINTagStandard.Click
        PrintReport("rptStockDBarcode.rpt")
    End Sub

    Private Sub tsmnDINTagSTG_Click(sender As Object, e As EventArgs) Handles tsmnDINTagSTG.Click
        PrintReport("rptStockDStgBarcode.rpt")
    End Sub

    Private Sub tsmnDINTagPTIndonesiaWacoal_Click(sender As Object, e As EventArgs) Handles tsmnDINTagPTIndonesiaWacoal.Click
        PrintReport("rptStockDPTIndoWacoalBarcode.rpt")
    End Sub

    Private Sub tsbDInDocument_Click(sender As Object, e As EventArgs) Handles tsbDInDocument.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptDIN.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
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
        'rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinnofr", txtDINNo.Text.Trim)
        rpt.SetParameterValue("@dinnoto", txtDINNo.Text.Trim)
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbHInDocument_Click(sender As Object, e As EventArgs) Handles tsbMInDocument.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptMin.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
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
        'rpt.VerifyDatabase()
        rpt.SetParameterValue("@dinno", txtDINNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "MIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cboDinNo_DropDownStyleChanged(sender As Object, e As EventArgs) Handles cboDinNo.DropDownStyleChanged

    End Sub


End Class