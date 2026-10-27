Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class formPrintBarcode
	Public loginEmpcd As String
	Private connStr As New classConnection
	Dim ds As New DataSet
	Private dts As DataTable
	Private dt As DataTable
	Private Clsconfig As New clsConfig
	Public flagsearch_Yarn_in As Boolean
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim i As Integer
        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        Dim strwheresql As String = ""
        Dim strBoxNo As String = ""
        Dim conn As New SqlConnection
        Dim comm As New SqlCommand
        'Dim tran As SqlTransaction
        'conn.ConnectionString = connStr.connection
        'conn.Open()
        'comm.Connection = conn
        'tran = conn.BeginTransaction
        'comm.Transaction = tran
        For i = 0 To Me.DgYarn_in.Rows.Count - 2
            If Me.DgYarn_in.Rows(i).Cells("DGV_select").Value = True Then
                'If flagsearch_Yarn_in = True Then
                '    strwheresql = strwheresql & "'" & Me.DgYarn_in.Rows(i).Cells("clmboxno").Value.ToString.Trim & "',"
                'Else
                '    strwheresql = strwheresql & "'" & Me.DgYarn_in.Rows(i).Cells("clmboxno").Value.ToString.Trim & "',"
                'End If

                strBoxNo &= Me.DgYarn_in.Rows(i).Cells("clmboxno").Value.ToString.Trim & ","
            End If
        Next

        'strwheresql = Mid(strwheresql.ToString, 1, strwheresql.Length - 1)
        strBoxNo = Mid(strBoxNo.ToString, 1, strBoxNo.Length - 1)

        '      Dim str As String
        '      str = ""
        '      ds.Clear()
        '      If flagsearch_Yarn_in = True Then
        '          str = "select * from v_YarnBalByBox_minus_job   " 'v_yarn_in
        '          str = str & "where docno = '" & Me.txtYarn_in_no.Text.Trim & "' and boxno in (" & strwheresql.ToString & ") "
        '      Else
        '          str = "select * from v_YarnBalByBox_minus_job   " 'v_yarn_in
        '          str = str & "where itcd = '" & Me.txtItcd_no.Text.Trim & "' and boxno in (" & strwheresql.ToString & ") "
        '      End If
        '      Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        '      myda.Fill(ds, "TblDatayarnin")
        '      If ds.Tables("TblDatayarnin").Rows.Count > 0 Then
        '          For i = 0 To ds.Tables("TblDatayarnin").Rows.Count - 1
        '              Try
        '                  comm.CommandType = CommandType.StoredProcedure
        '                  comm.CommandText = "sp_insert_action"
        '                  comm.Parameters.Clear()
        '                  comm.Parameters.AddWithValue("@empcd", loginEmpcd)
        '                  comm.Parameters.AddWithValue("@docno", ds.Tables("tblDataYarnin").Rows(i).Item("boxno").ToString)
        '                  comm.Parameters.AddWithValue("@workdt", Now().ToString("yyy/MM/dd"))
        '                  comm.Parameters.AddWithValue("@doctyp", "BAR-Y")
        '                  comm.Parameters.AddWithValue("@worktyp", "PRINT")
        '                  comm.CommandType = CommandType.StoredProcedure

        '                  comm.ExecuteNonQuery()

        '                  comm.CommandType = CommandType.Text
        '              Catch ex As Exception
        '                  MsgBox(ex.Message)
        '                  Exit Sub
        '              End Try
        '          Next
        'End If
        'If UCase(connStr.database) = "GEMMASOFT" Then
        '          Try
        '              If ds.Tables("TblDatayarnin").Rows.Count > 0 Then
        '                  Dim frmreport As New FormRptBarcode
        '                  Dim rptFileName As String = "RptYarnBarcode.rpt"
        '                  Dim obj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '                  obj.Load(clsuser.reportpath & rptFileName)
        '                  'Dim obj As New RptYarnBarcode
        '                  obj.SetDataSource(ds.Tables("TblDatayarnin"))
        '                  obj.PrintOptions.PrinterName = "SATO CL408e"
        '                  'obj.PrintOptions.PrinterName = "Datamax E-4203"
        '                  frmreport.CrystalReportViewer1.ReportSource = obj
        '                  frmreport.ShowDialog()
        '              End If
        '          Catch ex As Exception
        '              tran.Rollback()
        '              MsgBox(ex.Message)
        '              Exit Sub
        '          End Try
        '	tran.Commit()
        'Else
        '	' ------------------------------------ new method for Karisma
        '          Dim j As Integer
        '          Dim rpt() As CrystalDecisions.CrystalReports.Engine.ReportDocument
        '          Dim rptFileName As String = "RptYarnBarcode3"
        '          'Dim rpt() As RptYarnBarcode3
        '	Dim frm As New FormRptBarcode
        '	Dim param(4) As String
        '	'Dim paper As New System.Drawing.Printing.PaperSource

        '	i = 0
        '	j = 0
        '	If flagsearch_Yarn_in Then
        '		param(0) = txtYarn_in_no.Text.Trim
        '		param(1) = ""
        '	Else
        '		param(0) = ""
        '		param(1) = txtItcd_no.Text.Trim
        '	End If
        '	param(3) = loginEmpcd
        '	For i = 0 To DgYarn_in.Rows.Count - 2
        '		If DgYarn_in.Rows(i).Cells("DGV_select").Value Then
        '			ReDim Preserve rpt(j + 1)
        '                  'rpt(j) = New RptYarnBarcode3
        '                  rpt(j).Load(clsuser.reportpath & rptFileName)
        '			param(2) = DgYarn_in.Rows(i).Cells("clmboxno").Value.ToString.Trim
        '			rpt(j).DataSourceConnections.Item(0).SetConnection(connStr.servername, connStr.database, False)
        '			rpt(j).DataSourceConnections.Item(0).SetLogon(connStr.Userid, connStr.Password)
        '			rpt(j).VerifyDatabase()
        '			rpt(j).SetParameterValue("@docno", param(0))
        '			rpt(j).SetParameterValue("@itcd", param(1))
        '			rpt(j).SetParameterValue("@boxno", param(2))
        '			rpt(j).SetParameterValue("@empcd", param(3))
        '			Try
        '				rpt(j).PrintOptions.PrinterName = "Datamax E-4203"
        '				rpt(j).PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        '				rpt(j).PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto
        '				MsgBox("Going to print..", MsgBoxStyle.OkOnly, "Print")
        '				rpt(j).PrintToPrinter(1, True, 1, 1)
        '			Catch ex As Exception
        '				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        '				tran.Rollback()
        '				Exit Sub
        '			End Try
        '			rpt(j).Dispose()
        '			j += 1
        '		End If
        '	Next
        '	tran.Commit()
        'End If

        Dim clsConn As New classConnection
        Dim rptFileName As String = "RptYarnBarcode.rpt"
        ' If UCase(connStr.Database) = "GEMMASOFT" Then rptFileName = "RptYarnBarcode.rpt"
        Dim frm As New frmReport


        If Not Clsconfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()

        If flagsearch_Yarn_in = True Then
            rpt.SetParameterValue("@docno", txtYarn_in_no.Text.Trim)
            rpt.SetParameterValue("@itcd", "")
        Else
            rpt.SetParameterValue("@docno", "")
            rpt.SetParameterValue("@itcd", txtItcd_no.Text.Trim)
        End If

        rpt.SetParameterValue("@boxno", strBoxNo)

        'If UCase(connStr.database) = "GEMMASOFT" Then
        '    rpt.PrintOptions.PrinterName = "SATO CL408e"
        'Else
        '    rpt.PrintOptions.PrinterName = "Datamax E-4203"
        'End If
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Public Sub btnFindByYarnInClick()
		flagsearch_Yarn_in = True ' flag for report print select where(.......) 
		Me.txtItcd_no.Text = ""
		Dim msgerr As String = ""
		Dim tblSupplier As New GetDataYarn
		'dts.Clear()
		Try
			dts = tblSupplier.GetYarnInnoPrintBarcode(Me.txtYarn_in_no.Text, "", msgerr)
			dts.DefaultView.Sort = "itcd asc"
			If dts.Rows.Count > 0 Then
				Me.DgYarn_in.DataSource = dts
			Else
				Me.DgYarn_in.DataSource = dts
				MsgBox("Can not found")
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub formPrintBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

	End Sub
	Private Sub funcdiscbsupplier()
		Dim tblSupplier As New GetDataYarn
		Dim dtsupplier As New DataTable
		dtsupplier = tblSupplier.GetSupplier
		If Not IsNothing(dtsupplier) Then
		End If
	End Sub

	Private Sub txtYarn_in_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtYarn_in_no.KeyDown
		If e.KeyCode = Keys.Enter Then
			flagsearch_Yarn_in = True ' flag for report print select where(.......) 
			Me.txtItcd_no.Text = ""
			Dim msgerr As String = ""
			Dim tblSupplier As New GetDataYarn
			'dts.Clear()
			Try
				dts = tblSupplier.GetYarnInnoPrintBarcode(Me.txtYarn_in_no.Text, "", msgerr)
				dts.DefaultView.Sort = "itcd asc"
				If dts.Rows.Count > 0 Then
					Me.DgYarn_in.DataSource = dts
				Else
					Me.DgYarn_in.DataSource = dts
					MsgBox("Can not found")
				End If
			Catch ex As Exception
				MsgBox(ex.Message)
			End Try

		End If
	End Sub


	Private Sub txtYarn_in_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtYarn_in_no.TextChanged

	End Sub

	Private Sub txtItcd_no_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItcd_no.KeyDown
		If e.KeyCode = Keys.Enter Then
			flagsearch_Yarn_in = False ' flag for report print select where(.......) 
			Me.txtYarn_in_no.Text = ""
			Dim msgerr As String = ""
			Dim tblSupplier As New GetDataYarn
			Try
				'dts.Clear()
				dts = tblSupplier.GetYarnInnoPrintBarcode("", Me.txtItcd_no.Text, msgerr)

				dts.DefaultView.Sort = "itcd asc"
				If dts.Rows.Count > 0 Then
					Me.DgYarn_in.DataSource = dts
				Else
					Me.DgYarn_in.DataSource = dts
					MsgBox("Can not found")
				End If
			Catch ex As Exception
				MsgBox(ex.Message)
			End Try

		End If
	End Sub

	Public Sub SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Call btnSelectAll_Click(sender, e)
	End Sub

	Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
		Dim i As Integer
		If Me.DgYarn_in.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
		Try
			For i = 0 To Me.DgYarn_in.Rows.Count - 2
				If Me.DgYarn_in.Rows(i).Cells("DGV_select").Value = False Then Me.DgYarn_in.Rows(i).Cells("DGV_select").Value = True
			Next
		Catch ex As Exception

		End Try
	End Sub

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		Dim i As Integer
		If Me.DgYarn_in.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
		Try
			For i = 0 To Me.DgYarn_in.Rows.Count - 2
				If Me.DgYarn_in.Rows(i).Cells("DGV_select").Value = True Then Me.DgYarn_in.Rows(i).Cells("DGV_select").Value = False
			Next
		Catch ex As Exception

		End Try

	End Sub
    
    Private Sub Btnsearch_yarn_in_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsearch_yarn_in.Click
        Dim selectedYarn As String
        Dim formSearchyarn As New formSearchYarn
        selectedYarn = formSearchyarn.getYarnno()
        If selectedYarn <> "" Then
            Me.txtYarn_in_no.Text = selectedYarn
        End If
        btnFindByYarnInClick()
    End Sub
    Private Sub btnsearch_itcd()
        flagsearch_Yarn_in = False ' flag for report print select where(.......) 
        Me.txtYarn_in_no.Text = ""
        Dim msgerr As String = ""
        Dim tblSupplier As New GetDataYarn
        Try
            'dts.Clear()
            dts = tblSupplier.GetYarnInnoPrintBarcode("", Me.txtItcd_no.Text, msgerr)

            dts.DefaultView.Sort = "itcd asc"
            If dts.Rows.Count > 0 Then
                Me.DgYarn_in.DataSource = dts
            Else
                Me.DgYarn_in.DataSource = dts
                MsgBox("Can not found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtItcd_no_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItcd_no.TextChanged

    End Sub

    Private Sub Btnsearch_yarn_in_by_itcd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsearch_yarn_in_by_itcd.Click
        Dim selecteditcd As String
        Dim formSearchyarn As New formSearchYarn
        selecteditcd = formSearchyarn.getitcd()
        If selecteditcd <> "" Then
            Me.txtItcd_no.Text = selecteditcd
        End If
        btnsearch_itcd()
    End Sub
End Class