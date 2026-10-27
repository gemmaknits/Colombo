Public Class frmYarnINYarnLocationsGMK
    Dim clsUser As New classUserInfo

    Dim dtYarnInDet As New DataTable
    Dim bsYarnInDet As New BindingSource
    Dim DrvYarnInDet As DataRowView

    Dim dtYarnLocationsGMK As New DataTable
    Dim bsYarnLocationsGMK As New BindingSource
    Dim drvYarnLocationsGMK As DataRowView

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property
    Private Sub frmYarnINTransferGMK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()
        Call GenCombo()

        Call InitDataBidingYarnIn(pDocno:="")
        txtInterfaceYarnLogno.Focus()
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()

        cboMtlWarehouse.Enabled = False
        cboMtlSubInventory.Enabled = False
        cboMtlLocations.Enabled = False
        cboSupplier.Enabled = False
        txtsinvno.Enabled = False
        dtpsinvdt.Enabled = False
        txtlotnosup.Enabled = False
        txtsrefno.Enabled = False
    End Sub

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag

        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
            dtp.Checked = False
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
            If chk.Name = "chkAutoCalculate" Then chk.Checked = True

        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next


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

    Private Sub SetErrorProvider()
        ErrorProvider1.Clear()
    End Sub

    Private Sub SetToolTips()

    End Sub

    Private Sub GenCombo()

        cboMtlWarehouse.DataSource = (New classMaster).Combomtlwarehouse(clsuser.UserID)
        cboMtlWarehouse.DisplayMember = "warehouse_code"
        cboMtlWarehouse.ValueMember = "mtl_warehouse_id"
        cboMtlWarehouse.SelectedIndex = -1

        cboMtlSubInventory.DataSource = (New classMaster).GetCombomtl_subinventory(0)
        cboMtlSubInventory.DisplayMember = "subinventory_code"
        cboMtlSubInventory.ValueMember = "mtl_subinventory_id"
        cboMtlSubInventory.SelectedIndex = -1

        cboMtlLocations.DataSource = (New classMaster).Combomtllocations(strUSerID:=clsuser.UserID,
                                         INt64mtl_warehouse_id:=0,
                                         Int64mtl_subinventory_id:=0)
        cboMtlLocations.DisplayMember = "location_name"
        cboMtlLocations.ValueMember = "mtl_locations_id"
        cboMtlLocations.SelectedIndex = -1

        cboSupplier.DataSource = (New GetDataYarn).GetSupplier()
        cboSupplier.DisplayMember = "name"
        cboSupplier.ValueMember = "suppcd"
        cboSupplier.SelectedIndex = 0

        ' colitcd.DataSource = (New GetDataYarn).getItems()
        'colitcd.DisplayMember = "itcd_desc"
        'colitcd.ValueMember = "itcd"
    End Sub

    Private Sub BtnSearchYL_Click(sender As Object, e As EventArgs) Handles BtnSearchYL.Click
        Dim frm As New frmSearchYarnTransferLocationsGMK
        frm.ShowDialog(Me)
        txtInterfaceYarnLogno.Text = frm.pLogNo
        Me.Cursor = Cursors.WaitCursor
        If txtInterfaceYarnLogno.Text.Trim <> "" Then
            Dim pDocNo As String
            pDocNo = (New classYarnINYarnLocationsGMK).GetDocNoByLogNo(pLogNo:=txtInterfaceYarnLogno.Text.Trim, StrUserID:=UserInfo.UserID)
            If Not pDocNo.Trim.Length > 0 Then
                Call InitDataBidingYarnIn(pDocno:="")
                Call BindYarnLocationsGMK()
                'txtInterfaceYarnLogno.Text = ""
                txtInterfaceYarnLogno.Focus()
            Else
                txtDocNo.Text = pDocNo
                bsYarnInDet.EndEdit()
                Call InitDataBidingYarnIn(pDocno:=txtDocNo.Text.Trim)
            End If
        End If

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub BindYarnLocationsGMK()
        bsYarnInDet.EndEdit()
        Dim StrError As String = ""
        dtYarnLocationsGMK = (New classYarnINYarnLocationsGMK).GetYarnLocationsGMK(pLogNo:=txtInterfaceYarnLogno.Text.Trim, Strmsgerr:=StrError)
        If StrError.Length > 0 Then
            MessageBox.Show(StrError, "SyStem Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        bsYarnLocationsGMK.DataSource = dtYarnLocationsGMK
        bsYarnLocationsGMK.MoveFirst()

        'Dim dr As DataRow
        'For RowNo = 0 To dtYarnLocationsGMK.Rows.Count - 1
        '    dr = dtYarnInDet.NewRow
        '    For ColNo = 0 To dtYarnInDet.Columns.Count - 1
        '        For Each column As DataColumn In dtYarnInDet.Columns
        '            dr(dtYarnInDet.Columns(ColNo).ColumnName) = dtYarnLocationsGMK.Rows(RowNo)(dtYarnInDet.Columns(ColNo).ColumnName)
        '        Next
        '    Next
        'Next

        For Each drYarnLocationsGMK In dtYarnLocationsGMK.Select("interface_yarn_logno = '" & txtInterfaceYarnLogno.Text.Trim & "'")
            dtYarnInDet.ImportRow(drYarnLocationsGMK)
        Next drYarnLocationsGMK

        bsYarnInDet.EndEdit()

        grdYarnIN.Refresh()

        Call BinddataYarnINTransfer()
        ' bsYarnInDet.MoveFirst() 'Sitthana 20190821

    End Sub

    Private Sub InitDataBidingYarnIn(ByVal pDocno As String)
        dtYarnInDet = (New classYarnINYarnLocationsGMK).GetYarnIn(pDocno:=pDocno)
        bsYarnInDet.DataSource = dtYarnInDet
        bsYarnInDet.MoveFirst()

        'bsYarnInDet.Position = bsYarnInDet.Find("step_status", DBNull.Value)
        'bsYarnInDet.EndEdit()

        DrvYarnInDet = CType(bsYarnInDet.Current, DataRowView)

        grdYarnIN.AutoGenerateColumns = False
        grdYarnIN.DataSource = bsYarnInDet.DataSource

        Call BinddataYarnINTransfer()
    End Sub

    Private Sub BinddataYarnINTransfer()
        Call ClearDataBindings()

        cboMtlWarehouse.DataBindings.Add("selectedvalue", bsYarnInDet, "mtl_warehouse_id")
        cboMtlSubInventory.DataBindings.Add("selectedvalue", bsYarnInDet, "mtl_subinventory_id")
        cboMtlLocations.DataBindings.Add("selectedvalue", bsYarnInDet, "mtl_locations_id")
        cboSupplier.DataBindings.Add("selectedvalue", bsYarnInDet, "suppcd")
        txtsinvno.DataBindings.Add("text", bsYarnInDet, "sinvno")
        dtpsinvdt.DataBindings.Add("text", bsYarnInDet, "sinvdt")
        txtlotnosup.DataBindings.Add("text", bsYarnInDet, "lotno_sup")
        txtsrefno.DataBindings.Add("text", bsYarnInDet, "srefno")
        Call SumGrid(dtYarnInDet)
    End Sub

    Public Sub ClearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            Call ClearControlBindings(obj)
        Next
    End Sub

    Private Sub ClearControlBindings(ByVal obj As Control)
        obj.DataBindings.Clear()
        If TypeOf obj Is TabControl Or TypeOf obj Is TabPage Or TypeOf obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                Call ClearControlBindings(obj2)
            Next
        End If

    End Sub

    Private Sub txtDocNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call InitDataBidingYarnIn(pDocno:=txtDocNo.Text.Trim)
        End If
    End Sub

    Private Sub SumGrid(ByVal dt As DataTable)

        Dim spools As Single = 0
        Dim kg_gr As Single = 0
        Dim kg_nt As Single = 0
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).RowState <> DataRowState.Deleted Then
                        'If CBool((New clsConfig).IsNull(dt.Rows(i)("sel"), False)) Then
                        spools = spools + Val((New clsConfig).IsNull(dt.Rows(i).Item("spools"), 0))
                            kg_gr = kg_gr + Val((New clsConfig).IsNull(dt.Rows(i).Item("kg_gr"), 0))
                            kg_nt = kg_nt + Val((New clsConfig).IsNull(dt.Rows(i).Item("kg_nt"), 0))
                        ' End If
                    End If


                Next

                txtTotalBoxes.Text = FormatNumber(dt.Rows.Count, 0, TriState.False, TriState.False, TriState.False)
                txtTotalTubes.Text = FormatNumber(spools, 0, TriState.False, TriState.False, TriState.False)
                txtTotalGrossWeight.Text = FormatNumber(kg_gr, 2, TriState.False, TriState.False, TriState.False)
                txtTotalNetWeight.Text = FormatNumber(kg_nt, 2, TriState.False, TriState.False, TriState.False)
                'netKg = kg_nt
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        bsYarnInDet.EndEdit()

        Dim result As DialogResult
        result = MessageBox.Show("Would you Like To save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveData()
    End Sub

    Private Function SaveData() As Boolean
        Dim objdbYarnIN As New classYarnINYarnLocationsGMK.YarnIn

        Dim Message As String = ""
        objdbYarnIN.Docno = txtDocNo.Text
        objdbYarnIN.Docdt = dtpDocDate.Value
        objdbYarnIN.Purno = ""
        objdbYarnIN.sinvno = (New clsConfig).IsNull(dtYarnInDet.Rows(0)("sinvno"), String.Empty)
        objdbYarnIN.sinvdt = dtpsinvdt.Value 'dtYarnInDet.Rows(0)("sinvdt")
        objdbYarnIN.suppcd = (New clsConfig).IsNull(dtYarnInDet.Rows(0)("suppcd"), String.Empty)
        objdbYarnIN.lotnoSup = (New clsConfig).IsNull(dtYarnInDet.Rows(0)("lotno_sup"), String.Empty)
        objdbYarnIN.lotnoOur = (New clsConfig).IsNull(dtYarnInDet.Rows(0)("lotno_our"), String.Empty)
        objdbYarnIN.srefno = (New clsConfig).IsNull(dtYarnInDet.Rows(0)("srefno"), String.Empty)
        objdbYarnIN.Trantype = "TRANSFER"


        If (New classYarnINYarnLocationsGMK).YarnINSave(objdbYarnIN, dtYarnInDet, Message, UserInfo.UserID) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ErrorProvider1.Clear()
            txtDocNo.Text = objdbYarnIN.Docno
            Call InitDataBidingYarnIn(txtDocNo.Text.Trim)
            txtInterfaceYarnLogno.Text = ""
            txtInterfaceYarnLogno.Focus()
            Return True
        Else
            MessageBox.Show(Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

    End Function
    Private Function CheckData() As Boolean
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(cboMtlWarehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก WareHouse")
            ErrorProvider1.SetError(cboMtlWarehouse, "คุณยังไม่ไดเลือก WareHouse")
            CheckData = False
            Exit Function
        End If

        If Val(cboMtlSubInventory.SelectedValue) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Subinventory")
            ErrorProvider1.SetError(cboMtlSubInventory, "คุณยังไม่ได้เลือก Subinventory")
            CheckData = False
            Exit Function
        End If

        If clsconfig.IsNull(cboMtlLocations.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก Location")
            ErrorProvider1.SetError(cboMtlLocations, "คุณยังไม่ได้เลือก Locations")
            CheckData = False
            Exit Function
        End If

        CheckData = True
    End Function



    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()
        Call GenCombo()

        Call InitDataBidingYarnIn(pDocno:="")
        txtInterfaceYarnLogno.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim clsConn As New classConnection
        Dim rptFileName As String = "rptYarnIn.rpt"
        Dim frm As New frmReport

        If Not (New clsConfig).CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtDocNo.Text)

        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrintBarcode_Click(sender As Object, e As EventArgs) Handles btnPrintBarcode.Click
        If txtDocNo.Text.Length = 0 Then Exit Sub
        Dim frm As New formPrintBarcode

        frm.loginEmpcd = clsUser.UserID
        frm.UserInfo = clsUser
        frm.Show()

        frm.txtYarn_in_no.Text = txtDocNo.Text.Trim

        frm.btnFindByYarnInClick()
        frm.SelectAll(sender, e)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub txtInterfaceYarnLogno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInterfaceYarnLogno.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtInterfaceYarnLogno.Text.Trim <> "" Then
                Dim pDocNo As String
                pDocNo = (New classYarnINYarnLocationsGMK).GetDocNoByLogNo(pLogNo:=txtInterfaceYarnLogno.Text.Trim, StrUserID:=UserInfo.UserID)
                If Not pDocNo.Trim.Length > 0 Then
                    Call BindYarnLocationsGMK()
                    txtInterfaceYarnLogno.Focus()
                Else
                    txtDocNo.Text = pDocNo
                    bsYarnInDet.EndEdit()
                    Call InitDataBidingYarnIn(pDocno:=txtDocNo.Text.Trim)
                End If
            End If

        End If
    End Sub
End Class