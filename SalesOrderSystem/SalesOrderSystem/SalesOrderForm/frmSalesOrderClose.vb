Public Class frmSalesOrderClose
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

	Private Sub GenComboSoNo()
		Dim objDB As New classSalesOrder
        cboSoNo.ComboBox.DataSource = objDB.SOLoad(strUserID:=clsUser.UserID)
		cboSoNo.ComboBox.DisplayMember = "sono2"
        cboSoNo.ComboBox.ValueMember = "sono2"

        cboSoNo.ComboBox.SelectedIndex = -1  '0 Sitthana 20200123
    End Sub

	Private Sub BindGrid(ByVal dt As DataTable)
		grdSalesOrder.AutoGenerateColumns = False
		grdSalesOrder.DataSource = dt
		If dt.Rows.Count > 0 Then
			grdSalesOrder.ReadOnly = CBool(dt.Rows(0)("cancel_status"))
			lblCancelled.Visible = CBool(dt.Rows(0)("cancel_status"))
		End If
	End Sub

	Private Function IsDataChange() As Boolean
		Dim config As New clsConfig
		Dim result As Boolean = False
		Dim dt As New DataTable
        dt = grdSalesOrder.DataSource
        If dt Is Nothing = False Then
            Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
            If dt Is Nothing Or dv.Count = 0 Then
                If grdSalesOrder.Rows.Count > 1 Then result = True
            Else
                Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
                If delRecs.Count > 0 Then result = True

                Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
                If updRecs.Count > 0 Then result = True

                Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
                If addRecs.Count > 0 Then result = True
            End If
        End If


        IsDataChange = result
	End Function

	Private Sub LoadData(ByVal SoNo As String)
		Dim objDB As New classSalesOrder
		Dim dt As New DataTable
		dt = objDB.SODetLoad(SoNo)
		Call BindGrid(dt)
	End Sub

	Private Function SaveData() As Boolean
		Dim config As New clsConfig
		Dim clsSO As New classSalesOrder
		Dim msgerr As String = ""
		Dim dt As DataTable = grdSalesOrder.DataSource

		If clsSO.SOClose(dt, msgerr, clsUser.UserID) Then
			SaveData = True
		Else
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			SaveData = False
		End If
	End Function

	Private Sub frmSalesOrderClose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenComboSoNo()
	End Sub

	Private Sub frmSalesOrderClose_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		If IsDataChange() Then Call btnSave_Click(sender, e)
		e.Cancel = blnCancel
	End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New frmSalesOrderSearch
        frm.UserInfo = clsUser
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        If frm.pblnOk = True Then
            If Not blnCancel Then cboSoNo.ComboBox.SelectedValue = frm.pSoNo
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()

        'Dim frm As New frmSalesOrderSearch
        'frm.UserInfo = clsUser
        'frm.ShowDialog(Me)
        'Me.Cursor = Cursors.WaitCursor
        'If Not blnCancel Then cboSoNo.ComboBox.SelectedValue = frm.pSoNo
        'Me.Cursor = Cursors.Default
        'frm.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		If Not grdSalesOrder.EndEdit() Then Exit Sub
		blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
		If SaveData() Then LoadData(cboSoNo.ComboBox.SelectedValue.ToString.Trim)
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim strSoNo As String = clsConfig.IsNull(cboSoNo.ComboBox.SelectedValue, "")
		If strSoNo.Length = 0 Then Exit Sub
		Const rptFileName = "rptSO.rpt"
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
		rpt.SetParameterValue("@sono", strSoNo)
		rpt.SetParameterValue("@datefr", "")
		rpt.SetParameterValue("@dateto", "")
		rpt.SetParameterValue("@custcd", "")

		rpt.DataDefinition.ParameterFields("@sono", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@sono").CurrentValues)
		rpt.DataDefinition.ParameterFields("@datefr", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@datefr").CurrentValues)
		rpt.DataDefinition.ParameterFields("@dateto", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dateto").CurrentValues)
		rpt.DataDefinition.ParameterFields("@custcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@custcd").CurrentValues)

		frm.Title = "Sales Order"
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

    Private Sub cboSoNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSoNo.SelectedIndexChanged
        If cboSoNo.SelectedIndex <> -1 Then
            If clsConfig.IsNull(cboSoNo.ComboBox.SelectedValue, "").ToString.Trim.Length > 0 Then Call LoadData(clsConfig.IsNull(cboSoNo.ComboBox.SelectedValue, "").ToString.Trim)
        End If


    End Sub

    Private Sub grdSalesOrder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdSalesOrder.KeyDown
		Dim i As Integer = 0
		If e.KeyCode = Keys.Enter Then
			If grdSalesOrder.Columns(grdSalesOrder.SelectedCells(i).ColumnIndex).Name = "closed" Then
				For i = 0 To grdSalesOrder.SelectedCells.Count - 1
					grdSalesOrder.SelectedCells(i).Value = Not CBool(grdSalesOrder.SelectedCells(i).Value)
				Next
			End If
		End If
	End Sub

    Private Sub cboSoNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSoNo.Click

    End Sub
End Class