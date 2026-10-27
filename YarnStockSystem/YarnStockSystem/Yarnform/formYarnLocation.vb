Public Class formYarnLocation
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo

	Dim strDocNo As String = ""

	Dim _AllowEdit As Boolean = True
	Dim _AllowPrint As Boolean = True
	Dim _AllowNew As Boolean = True

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Public Property AllowEdit()
		Get
			Return _AllowEdit
		End Get
		Set(ByVal value)
			_AllowEdit = value
		End Set
	End Property

	Public Property AllowPrint()
		Get
			Return _AllowPrint
		End Get
		Set(ByVal value)
			_AllowPrint = value
		End Set
	End Property

	Public Property AllowNew()
		Get
			Return _AllowNew
		End Get
		Set(ByVal value)
			_AllowNew = value
		End Set
	End Property

	Private Property DocNo() As String
		Get
			DocNo = strDocNo
		End Get
		Set(ByVal NewValue As String)
			strDocNo = NewValue
		End Set
	End Property

	Private Sub SetControlValue(ByVal Obj As Control)
		If TypeOf Obj Is TextBox Then
			Obj.Text = Obj.Tag
		End If
		If TypeOf Obj Is DateTimePicker Then
			Dim dtp As DateTimePicker = Obj
			dtp.Value = Now
		End If
		If TypeOf Obj Is ComboBox Then
			Dim cbo As ComboBox = Obj
			cbo.SelectedIndex = -1
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

	Private Sub InitControl()
		Dim obj As Control
		For Each obj In Me.Controls
			Call SetControlValue(obj)
		Next
		Call EnabledControl(True)
		Call LoadDataLog("")
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

	Private Sub GenComboDocNo()
		Dim objDB As New GetDataYarn
		Me.cboDocNo.ComboBox.DataSource = objDB.getYarnLocationLogNo()
		Me.cboDocNo.ComboBox.DisplayMember = "logno"
		Me.cboDocNo.ComboBox.ValueMember = "logno"
		Me.cboDocNo.ComboBox.SelectedIndex = -1
	End Sub

	Private Sub GenComboItems()
		Dim objDB As New GetDataYarn
		Me.cboItemCode.DataSource = objDB.getItems()
		Me.cboItemCode.DisplayMember = "itcd"
		Me.cboItemCode.ValueMember = "itcd"
		Me.cboItemCode.SelectedIndex = 0
	End Sub

	Private Sub BindGrid(ByVal dt As DataTable)
		grdYarnIN.AutoGenerateColumns = False
		grdYarnIN.DataSource = dt
	End Sub

	Private Function IsDataChange(ByVal dt As DataTable) As Boolean
		'Dim dt As DataTable = (New GetDataYarn).getYarnLocationLog(strDocNo)
		Dim result As Boolean = False

		Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
		If delRecs.Count > 0 Then result = True

		Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
		If updRecs.Count > 0 Then result = True

		Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
		If addRecs.Count > 0 Then result = True

		IsDataChange = result
	End Function

	Private Sub LoadDataItem(ByVal strITCD As String)
		Dim dt As DataTable = (New GetDataYarn).getYarnIN(strITCD)
		grdYarnIN.AutoGenerateColumns = False
		grdYarnIN.DataSource = dt
	End Sub

	Private Sub LoadDataLog(ByVal strLogNoLoad As String)
		Dim dt As DataTable = (New GetDataYarn).getYarnLocationLog(strLogNoLoad)
		grdTransfer.AutoGenerateColumns = False
		grdTransfer.DataSource = dt
		If dt.Rows.Count > 0 Then
			strDocNo = strLogNoLoad
			txtLogNo.Text = strDocNo
			txtLogDate.Text = dt.Rows(0)("docdt2").ToString()
			txtLocation.Text = dt.Rows(0)("loc").ToString()
			dtpActualMoveDate.Value = CDate(dt.Rows(0)("actual_move_date2").ToString())
			dtpReceiveDate.Value = CDate(dt.Rows(0)("receive_date2").ToString())
			txtLocation.Enabled = False
		Else
			strDocNo = ""
			txtLogNo.Text = strDocNo
			txtLogDate.Text = ""
			txtLocation.Text = ""
			txtLocation.Enabled = True
		End If
	End Sub

	Private Function SaveData() As Boolean
		If AllowEdit Or AllowNew Then
			Dim clsYarn As New UpdateYarn
			Dim header As New classMasterUpdate.DM
			Dim msgerr As String = ""
			Dim dt As DataTable = grdTransfer.DataSource
			If strDocNo.Length > 0 Then
				If dt.Rows.Count > 0 Then
					If dt.Rows(0)("actual_move_date").ToString() <> dtpActualMoveDate.Value.ToString("yyyyMMdd") Or _
					dt.Rows(0)("receive_date").ToString() <> dtpReceiveDate.Value.ToString("yyyyMMdd") Or _
					dt.Rows(0)("loc").ToString() <> txtLocation.Text Then
						Call clsYarn.YarnLocationSaveHeader(strDocNo, txtLocation.Text, dtpActualMoveDate.Value.ToString("yyyyMMdd"), dtpReceiveDate.Value.ToString("yyyyMMdd"))
					End If
				End If
			End If

			Dim add As New DataView(dt, "", "", DataViewRowState.Added)
			Dim del As New DataView(dt, "", "", DataViewRowState.Deleted)

			If clsYarn.YarnLocationSave(add, del, msgerr, clsUser.UserID, strDocNo) Then
				MessageBox.Show("Data has been saved.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
				SaveData = True
				Call LoadDataLog(strDocNo)
				Call GenComboDocNo()
			Else
				MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
				SaveData = False
			End If
		Else
			MessageBox.Show("Permission denied", "Security message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
		End If
	End Function

	Private Function CheckGridYarnIN() As Boolean
		If grdYarnIN.DataSource Is Nothing Then Return False
		If grdYarnIN.Rows.Count = 0 Then Return False
		Dim i As Integer = 0
		For i = 0 To grdYarnIN.Rows.Count - 1
			If CBool(grdYarnIN.Rows(i).Cells("chkSelect").Value) Then Return True
		Next
		Return False
	End Function

	Private Sub AddRollNo()
		If grdYarnIN.Rows.Count > 0 Then
			Dim config As New clsConfig
			Dim dt As DataTable = grdYarnIN.DataSource
			Dim dt2 As DataTable = grdTransfer.DataSource
			Dim dr As DataRow
			Dim msg As String = ""
			Dim i As Integer = 0
			Dim j As Integer = 0
			For i = 0 To dt.Rows.Count - 1
				If CBool(dt.Rows(i)("chkSelect")) Then
					dr = dt2.NewRow
					For j = 0 To dt2.Columns.Count - 1
						dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
						If dt2.Columns(j).ColumnName.Trim = "loc" Then
							dr(dt2.Columns(j).ColumnName.Trim) = txtLocation.Text
						End If
					Next
					dt2.Rows.Add(dr)
				End If
			Next
			txtLocation.Enabled = False
		End If
	End Sub

	Private Function CheckGridTransfer() As Boolean
		If grdTransfer.DataSource Is Nothing Then Return False
		If grdTransfer.Rows.Count = 0 Then Return False
		Dim i As Integer = 0
		For i = 0 To grdTransfer.Rows.Count - 1
			If CBool(grdTransfer.Rows(i).Cells("tr_chkSelect").Value) Then Return True
		Next
		Return False
	End Function

	Private Sub DeleteRollNo()
		If grdTransfer.Rows.Count > 0 Then
			Dim i As Integer = 0
			Dim dt As DataTable = grdTransfer.DataSource
			Do While i < dt.Rows.Count
				If dt.Rows.Count = 0 Then Exit Do
				For i = 0 To dt.Rows.Count - 1
					If Not dt.Rows(i).RowState = DataRowState.Deleted Then
						If CBool(dt.Rows(i)("chkSelect")) Then
							dt.Rows(i).Delete()
							Exit For
						End If
					End If
				Next
			Loop
			If dt.Rows.Count = 0 Then txtLocation.Enabled = True
		End If
	End Sub

	Private Sub formYarnLocation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenComboDocNo()
		Call GenComboItems()
		Call InitControl()
		btnSave.Enabled = AllowEdit
	End Sub

	Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
		Call InitControl()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Call SaveData()
        End If
    End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		If strDocNo.Length = 0 Then Exit Sub
		Const rptFileName = "rptYarnLocationLog.rpt"
		If clsUser.ReportPath = "" Then clsUser.ReportPath = clsuser.reportpath
		If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
		Me.Cursor = Cursors.WaitCursor
		logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.Database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.UserName
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        'rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
		rpt.VerifyDatabase()
		rpt.SetParameterValue("@lognofr", strDocNo)
		rpt.SetParameterValue("@lognoto", strDocNo)

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Yarn Location Movement"
        'frm.CRViewer.DisplayGroupTree = False
		frm.CRViewer.ReportSource = rpt
		frm.MdiParent = Me.ParentForm
		frm.Show()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub cboDocNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocNo.DropDownClosed
		strDocNo = clsConfig.IsNull(cboDocNo.ComboBox.SelectedValue, "")
		If strDocNo.Length > 0 Then LoadDataLog(strDocNo)
	End Sub

	Private Sub grdYarnIN_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdYarnIN.KeyDown
		Dim i As Integer = 0
		If e.KeyCode = Keys.Enter Then
			If grdYarnIN.Columns(grdYarnIN.SelectedCells(i).ColumnIndex).Name = "chkSelect" Then
				For i = 0 To grdYarnIN.SelectedCells.Count - 1
					grdYarnIN.SelectedCells(i).Value = Not CBool(grdYarnIN.SelectedCells(i).Value)
				Next
			End If
		End If
	End Sub

	Private Sub grdTransfer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdTransfer.KeyDown
		Dim i As Integer = 0
		If e.KeyCode = Keys.Enter Then
			If grdTransfer.Columns(grdTransfer.SelectedCells(i).ColumnIndex).Name = "tr_chkSelect" Then
				For i = 0 To grdTransfer.SelectedCells.Count - 1
					grdTransfer.SelectedCells(i).Value = Not CBool(grdTransfer.SelectedCells(i).Value)
				Next
			End If
		End If
	End Sub

	Private Sub txtLogNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLogNo.KeyDown
		If e.KeyCode = Keys.Enter Then Call LoadDataLog(txtLogNo.Text)
	End Sub

	Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
		Dim strITCD As String = clsConfig.IsNull(cboItemCode.SelectedValue, "")
		If strITCD.Length > 0 Then LoadDataItem(strITCD)
	End Sub

	Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
		If Not CheckGridYarnIN() Then Exit Sub
        If MessageBox.Show("Would you like to add selected Roll No. from left grid to right grid ?" & vbCrLf & "คุณต้องการเพิ่มกล่องที่เลือกไว้ด้านซ้ายเพื่อนำไปใส่ในเอกสารด้านขวาใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If txtLocation.Text.Trim.Length = 0 Then
			MessageBox.Show("Please fill the new location to transfer." & vbCrLf & "คุณยังไม่ได้ใส่ Location ที่จะทำการย้ายไป", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			txtLocation.Focus()
		Else
			Call AddRollNo()
		End If
	End Sub

	Private Sub btnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeselect.Click
		If Not CheckGridTransfer() Then Exit Sub
        If MessageBox.Show("Would you like to delete selected Roll No. in right grid ?" & vbCrLf & "คุณต้องการลบกล่องที่เลือกไว้ในเอกสารในด้านขวาออกใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If grdTransfer.CurrentRow.Index >= 0 Then Call DeleteRollNo()
	End Sub
End Class