Public Class frmDyingOrderClose
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo
	Dim blnCancel As Boolean = False

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Private Sub GenComboDFNo()
		Dim objDB As New classDFOrder
		cboDFNo.ComboBox.DataSource = objDB.DFLoad()
		cboDFNo.ComboBox.DisplayMember = "dfno"
		cboDFNo.ComboBox.ValueMember = "dfno"
	End Sub

	Private Sub BindGrid(ByVal dt As DataTable)
		grdDF.AutoGenerateColumns = False
		grdDF.DataSource = dt
		If dt.Rows.Count > 0 Then
			grdDF.ReadOnly = IIf(dt.Rows(0)("status").ToString.Trim = "C", True, False)
			lblCancelled.Visible = IIf(dt.Rows(0)("status").ToString.Trim = "C", True, False)
		End If
	End Sub

	Private Function IsDataChange() As Boolean
		Dim config As New clsConfig
		Dim result As Boolean = False
		Dim dt As New DataTable
		dt = grdDF.DataSource
		Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
		If dt Is Nothing Or dv.Count = 0 Then
			If grdDF.Rows.Count > 1 Then result = True
		Else
			Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
			If delRecs.Count > 0 Then result = True

			Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
			If updRecs.Count > 0 Then result = True

			Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
			If addRecs.Count > 0 Then result = True
		End If

		IsDataChange = result
	End Function

	Private Sub LoadData(ByVal DFNo As String)
		Dim objDB As New classDFOrder
		Dim dt As New DataTable
		dt = objDB.DFDetLoad(DFNo)
		Call BindGrid(dt)
	End Sub

	Private Function SaveData() As Boolean
		Dim config As New clsConfig
		Dim clsDF As New classDFOrder
		Dim msgerr As String = ""
		Dim dt As DataTable = grdDF.DataSource

		If clsDF.DFClose(dt, msgerr, clsUser.UserID) Then
			SaveData = True
		Else
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			SaveData = False
		End If
	End Function

	Private Sub frmDyingorderClose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call GenComboDFNo()
    End Sub

	Private Sub frmDyingorderClose_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		If IsDataChange() Then Call btnSave_Click(sender, e)
		e.Cancel = blnCancel
	End Sub

	Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
		Dim frm As New frmDyingOrderSearch
		frm.ShowDialog(Me)
		Me.Cursor = Cursors.WaitCursor
		If Not blnCancel Then cboDFNo.ComboBox.SelectedValue = frm.pDFNo
		Me.Cursor = Cursors.Default
		frm.Dispose()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		If Not grdDF.EndEdit() Then Exit Sub
        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
		If SaveData() Then LoadData(cboDFNo.ComboBox.SelectedValue.ToString.Trim)
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim strDFNo As String = clsConfig.IsNull(cboDFNo.ComboBox.SelectedValue, "").ToString.Trim
		If strDFNo.Length = 0 Then Exit Sub
		Const rptFileName = "rptDFOrder.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
		Me.Cursor = Cursors.WaitCursor
		logonInfo.ConnectionInfo.ServerName = clsConn.servername
		logonInfo.ConnectionInfo.DatabaseName = clsConn.database
		logonInfo.ConnectionInfo.IntegratedSecurity = False
		logonInfo.ConnectionInfo.UserID = clsConn.Userid
		logonInfo.ConnectionInfo.Password = clsConn.Password

		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
		rpt.VerifyDatabase()
		rpt.SetParameterValue("@dfno", strDFNo)
		rpt.SetParameterValue("@datefr", "")
		rpt.SetParameterValue("@dateto", "")
		rpt.SetParameterValue("@sono", "")
		rpt.SetParameterValue("@custcd", "")
		rpt.SetParameterValue("@dhcod", "")
		rpt.SetParameterValue("@design_no", "")
		rpt.SetParameterValue("@empcd", "")

		rpt.DataDefinition.ParameterFields("@dfno", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dfno").CurrentValues)
		rpt.DataDefinition.ParameterFields("@datefr", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@datefr").CurrentValues)
		rpt.DataDefinition.ParameterFields("@dateto", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dateto").CurrentValues)
		rpt.DataDefinition.ParameterFields("@sono", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@sono").CurrentValues)
		rpt.DataDefinition.ParameterFields("@custcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@custcd").CurrentValues)
		rpt.DataDefinition.ParameterFields("@dhcod", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dhcod").CurrentValues)
		rpt.DataDefinition.ParameterFields("@design_no", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@design_no").CurrentValues)
		rpt.DataDefinition.ParameterFields("@empcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@empcd").CurrentValues)

		frm.Title = "D/F Order"
		frm.CRViewer.ReportSource = rpt
		frm.MdiParent = Me.ParentForm
		frm.Show()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub cboDFNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDFNo.SelectedIndexChanged
		If clsConfig.IsNull(cboDFNo.ComboBox.SelectedValue.ToString, "").ToString.Trim.Length > 0 Then Call LoadData(clsConfig.IsNull(cboDFNo.ComboBox.SelectedValue, "").ToString.Trim)
	End Sub

	Private Sub grdDF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDF.KeyDown
		Dim i As Integer = 0
        If e.KeyCode = Keys.Enter Then
            'Sitthana changed from closed -> closedDry --> colclosed
            If grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "colclosed" Then
                For i = 0 To grdDF.SelectedCells.Count - 1
                    grdDF.SelectedCells(i).Value = Not CBool(grdDF.SelectedCells(i).Value)
                Next
            End If
        End If
    End Sub

    Private Sub cboDFNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDFNo.Click

    End Sub

    Private Sub grdDF_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDF.CellContentClick

    End Sub
End Class