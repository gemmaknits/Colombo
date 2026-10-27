Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class formJobOrderforYarn
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

	Private Sub formJobOrderforYarn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.DgYarnIn.AutoGenerateColumns = False
		Me.Dg_jobYarndet.AutoGenerateColumns = False
		funcdiscbsupplier()
		Funcdiscbjbotype()
		FuncdisColor()
	End Sub

	'------------------Getdata input to CbColors
	Private Sub FuncdisColor()
		Dim tblSupplier As New GetDataYarn
		Dim dtcol As New DataTable
		dtcol = tblSupplier.GetColor
		If Not IsNothing(dtcol) Then
			Me.Cbcolor.DataSource = dtcol
			Me.Cbcolor.DisplayMember = "colname"
			Me.Cbcolor.ValueMember = "col"
		End If
	End Sub

	'------------------Getdata input to CbSuppcd
	Private Sub funcdiscbsupplier()
		Dim tblSupplier As New GetDataYarn
		Dim dtsupplier As New DataTable
		dtsupplier = tblSupplier.GetSupplier
		If Not IsNothing(dtsupplier) Then
			Me.CbSuppcd.DataSource = dtsupplier
			Me.CbSuppcd.DisplayMember = "name"
			Me.CbSuppcd.ValueMember = "suppcd"
		End If
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
	End Sub

	Private Sub txtY_IN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtY_IN.KeyPress
		If AscW(e.KeyChar) = 13 Then
			Dim msgerr As String = ""
			Dim tblSupplier As New GetDataYarn
			'dts.Clear()
			Try
				dts = tblSupplier.GetYarnInno(Me.txtY_IN.Text, "", msgerr)
				dts.DefaultView.Sort = "itcd asc"
				If dts.Rows.Count > 0 Then
					Me.DgYarnIn.DataSource = dts
					Me.Dg_jobYarndet.DataSource = ""
				Else
					Me.DgYarnIn.DataSource = dts
					Me.Dg_jobYarndet.DataSource = ""
					MsgBox("Can not found")
				End If
			Catch ex As Exception
				MsgBox(ex.Message)
			End Try

		End If
	End Sub

	Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
		If AscW(e.KeyChar) = 13 Then
			Dim msgerr As String = ""
			Dim tblSupplier As New GetDataYarn
			Try
				'dts.Clear()
				dts = tblSupplier.GetYarnInno("", Me.txtStock.Text, msgerr)

				dts.DefaultView.Sort = "itcd asc"
				If Not IsNothing(dts) Then
					Me.DgYarnIn.DataSource = dts
					Me.Dg_jobYarndet.DataSource = ""
				Else
					Me.DgYarnIn.DataSource = dts
					Me.Dg_jobYarndet.DataSource = ""
					MsgBox("Can not found")
				End If
			Catch ex As Exception
				MsgBox(ex.Message)
			End Try
		End If
	End Sub

	Private Sub btnSendOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendOne.Click
		Dim i As Integer
		Dim dsTable As New DataTable
		Dim dsset As New DataSet
		Dim dsRow As DataRow
		'Dim dt As DataTable
		'dsset.Clear()
		dsTable = dsset.Tables.Add
		dsTable.Columns.Add("itcd", GetType(String))
		dsTable.Columns.Add("grade", GetType(String))
		dsTable.Columns.Add("boxno", GetType(String))
		dsTable.Columns.Add("spools", GetType(String))
		dsTable.Columns.Add("kg_gr", GetType(String))
		dsTable.Columns.Add("kg_nt", GetType(String))
		dsTable.Columns.Add("lotno_our", GetType(String))
		If Not IsNothing(dts) Then
			For i = 0 To Me.DgYarnIn.Rows.Count - 2
				If Me.DgYarnIn.Rows(i).Cells(0).Value = True Then
					dsRow = dsTable.NewRow
					dsRow("itcd") = Me.DgYarnIn.Rows(i).Cells(1).Value.ToString
					dsRow("grade") = Me.DgYarnIn.Rows(i).Cells(2).Value.ToString
					dsRow("boxno") = Me.DgYarnIn.Rows(i).Cells(3).Value.ToString
					dsRow("spools") = Me.DgYarnIn.Rows(i).Cells(4).Value.ToString
					dsRow("kg_gr") = Me.DgYarnIn.Rows(i).Cells(5).Value.ToString
					dsRow("kg_nt") = Me.DgYarnIn.Rows(i).Cells(6).Value.ToString
					dsRow("lotno_our") = Me.DgYarnIn.Rows(i).Cells(7).Value.ToString
					dsset.Tables(0).Rows.Add(dsRow)
				End If
			Next
		End If
		dt = dsset.Tables(0)

		Me.Dg_jobYarndet.DataSource = dt
		CompareChkboxbetween_yarnin_with_job_yarn_det()
	End Sub

	Private Sub BtnsendAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnsendAll.Click
		'Dim dt As DataTable
		Dim i As Integer
		Dim dsTable As New DataTable
		Dim dsset As New DataSet
		Dim dsRow As DataRow
		'Dim dt As DataTable
		'dsset.Clear()
		dsTable = dsset.Tables.Add
		dsTable.Columns.Add("itcd", GetType(String))
		dsTable.Columns.Add("grade", GetType(String))
		dsTable.Columns.Add("boxno", GetType(String))
		dsTable.Columns.Add("spools", GetType(String))
		dsTable.Columns.Add("kg_gr", GetType(String))
		dsTable.Columns.Add("kg_nt", GetType(String))
		dsTable.Columns.Add("lotno_our", GetType(String))
		If Not IsNothing(dts) Then
			For i = 0 To Me.DgYarnIn.Rows.Count - 2
				dsRow = dsTable.NewRow
				dsRow("itcd") = Me.DgYarnIn.Rows(i).Cells(1).Value.ToString
				dsRow("grade") = Me.DgYarnIn.Rows(i).Cells(2).Value.ToString
				dsRow("boxno") = Me.DgYarnIn.Rows(i).Cells(3).Value.ToString
				dsRow("spools") = Me.DgYarnIn.Rows(i).Cells(4).Value.ToString
				dsRow("kg_gr") = Me.DgYarnIn.Rows(i).Cells(5).Value.ToString
				dsRow("kg_nt") = Me.DgYarnIn.Rows(i).Cells(6).Value.ToString
				dsRow("lotno_our") = Me.DgYarnIn.Rows(i).Cells(7).Value.ToString
				dsset.Tables(0).Rows.Add(dsRow)

			Next
		End If
		dt = dsset.Tables(0)


		Me.Dg_jobYarndet.DataSource = dt
		CompareChkboxbetween_yarnin_with_job_yarn_det()
	End Sub

	Private Sub BtnBackOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackOne.Click
		Dim i As Integer
		Dim dsTable As New DataTable
		Dim dsset As New DataSet
		Dim dsRow As DataRow
		'Dim dt As DataTable
		'dsset.Clear()
		dsTable = dsset.Tables.Add
		dsTable.Columns.Add("itcd", GetType(String))
		dsTable.Columns.Add("grade", GetType(String))
		dsTable.Columns.Add("boxno", GetType(String))
		dsTable.Columns.Add("spools", GetType(String))
		dsTable.Columns.Add("kg_gr", GetType(String))
		dsTable.Columns.Add("kg_nt", GetType(String))
		dsTable.Columns.Add("lotno_our", GetType(String))

		For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2
			If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = False Then

				dsRow = dsTable.NewRow
				dsRow("itcd") = Me.Dg_jobYarndet.Rows(i).Cells(1).Value.ToString
				dsRow("grade") = Me.Dg_jobYarndet.Rows(i).Cells(2).Value.ToString
				dsRow("boxno") = Me.Dg_jobYarndet.Rows(i).Cells(3).Value.ToString
				dsRow("spools") = Me.Dg_jobYarndet.Rows(i).Cells(4).Value.ToString
				dsRow("kg_gr") = Me.Dg_jobYarndet.Rows(i).Cells(5).Value.ToString
				dsRow("kg_nt") = Me.Dg_jobYarndet.Rows(i).Cells(6).Value.ToString
				dsRow("lotno_our") = Me.Dg_jobYarndet.Rows(i).Cells(7).Value.ToString
				dsset.Tables(0).Rows.Add(dsRow)
			End If

		Next
		CompareChkboxbetween_yarnin_with_job_yarn_detbackone()
		Me.Dg_jobYarndet.DataSource = dsset.Tables(0)

	End Sub

	Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
		Dim i As Integer = 0
		Dim InsertYarn As New InsertYarn
		Dim isvalid As Boolean
		Dim tbl_job As New tbl_job
		Try

			tbl_job.jobdt = Me.txtjobdt.Value.ToString("yyy/MM/dd")
			tbl_job.suppcd = Me.CbSuppcd.SelectedValue
			'tbl_job.reqno =As String
			tbl_job.jobtype = Me.Cbjobtype.SelectedValue
			tbl_job.jobitcd = txtjbo.Text
			tbl_job.tubeqty = Val(Me.txtfspools.Text)
			tbl_job.tubekg = Val(Me.txtftube.Text)
			tbl_job.twists = Me.txtftpm.Text
			tbl_job.col = Me.Cbcolor.SelectedValue
			'tbl_job. splins= As String
			tbl_job.remark = Me.txtremark.Text
			'tbl_job. jobfor =As String
			tbl_job.import = 0
			'tbl_job. curr =As String
			'tbl_job. exrt =As Double
			'tbl_job. vat =As Double
			'tbl_job. vatamt= As Double
			'tbl_job. taxper =As Double
			'tbl_job. taxamt =As Double
			'tbl_job. freight =As Double
			'tbl_job. insurance= As Double
			'tbl_job. otheramt =As Double
			'tbl_job. other_text= As String
			'tbl_job. totamt =As Double
			tbl_job.cancel_status = 0

			Dim dsTable As New DataTable
			Dim dsset As New DataSet
			Dim dsRow As DataRow
			'Dim dt As DataTable
			'dsset.Clear()
			dsTable = dsset.Tables.Add
			dsTable.Columns.Add("itcd", GetType(String))
			dsTable.Columns.Add("grade", GetType(String))
			dsTable.Columns.Add("boxno", GetType(String))
			dsTable.Columns.Add("spools", GetType(String))
			dsTable.Columns.Add("kg_gr", GetType(String))
			dsTable.Columns.Add("kg_nt", GetType(String))
			dsTable.Columns.Add("lotno_our", GetType(String))
			If Not IsNothing(dts) Then
				For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2
					If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
						dsRow = dsTable.NewRow
						dsRow("itcd") = Me.Dg_jobYarndet.Rows(i).Cells(1).Value.ToString
						dsRow("grade") = Me.Dg_jobYarndet.Rows(i).Cells(2).Value.ToString
						dsRow("boxno") = Me.Dg_jobYarndet.Rows(i).Cells(3).Value.ToString
						dsRow("spools") = Me.Dg_jobYarndet.Rows(i).Cells(4).Value.ToString
						dsRow("kg_gr") = Me.Dg_jobYarndet.Rows(i).Cells(5).Value.ToString
						dsRow("kg_nt") = Me.Dg_jobYarndet.Rows(i).Cells(6).Value.ToString
						dsRow("lotno_our") = Me.Dg_jobYarndet.Rows(i).Cells(7).Value.ToString
						dsset.Tables(0).Rows.Add(dsRow)
					End If
				Next
			End If

			Dim dr As DataRow

			Dim dgroupdts As DataTable
			dgroupdts = GroupbyItcdofdts(dsset.Tables(0))
			'Me.Dg_jobYarndet.DataSource = dgroupdts
			Dim j As Integer = 0
			For Each dr In dgroupdts.Rows
				ReDim Preserve tbl_job.tbl_job_det(j)
				tbl_job.tbl_job_det(j) = New tbl_job_det
				'tbl_job.tbl_job_det(i).jobno =  'As String
				'tbl_job.tbl_job_det(i).id_jobdet = Clsconfig.IsValidinteger(0) 'As Integer
				'tbl_job.tbl_job_det(i).outno = "".ToString 'As String
				tbl_job.tbl_job_det(j).itcd = dr.Item("itcd") 'As String
				'tbl_job.tbl_job_det(i).itdesc = "".ToString	'As String
				tbl_job.tbl_job_det(j).qty = dr.Item("kg_nt")	'As Double
				'tbl_job.tbl_job_det(i).uom = "".ToString 'As String
				'tbl_job.tbl_job_det(i).price = Val(0) 'As Double
				'tbl_job.tbl_job_det(i).curr = "".ToString 'As String
				'tbl_job.tbl_job_det(i).exrt = Val(0) 'As Double
				'tbl_job.tbl_job_det(i).discper = Val(0)	'As Double
				'tbl_job.tbl_job_det(i).discamt = Val(0)	'As Double
				'tbl_job.tbl_job_det(i).lineamt = Val(0)	'As Double
				'tbl_job.tbl_job_det(i).remark = Val("")	'As String
				'tbl_job.tbl_job_det(i).closed = Clsconfig.IsValidBoolean(0)	'As Boolean
				j = j + 1
			Next
			Dim k As Integer = 0
			For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2
				If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
					ReDim Preserve tbl_job.tbl_job_det_yarn(k)
					tbl_job.tbl_job_det_yarn(k) = New tbl_job_det_yarn
					'tbl_job.tbl_job_det_yarn(i).id_job_det_yarn = Me.Dg_jobYarndet.Rows(i).Cells("").Value.ToString	'As Integer
					'tbl_job.tbl_job_det_yarn(i).id_job_det = Me.Dg_jobYarndet.Rows(i).Cells("").Value.ToString 'As Integer
					'tbl_job.tbl_job_det_yarn(i).lotno_sup = Me.Dg_jobYarndet.Rows(i).Cells("").Value.ToString		'As String
					'tbl_job.tbl_job_det_yarn(i).lotno_our = Me.Dg_jobYarndet.Rows(i).Cells("").Value.ToString	'As String
					tbl_job.tbl_job_det_yarn(k).itcd = Me.Dg_jobYarndet.Rows(i).Cells(1).Value.ToString	'As String
					tbl_job.tbl_job_det_yarn(k).boxno = Me.Dg_jobYarndet.Rows(i).Cells(3).Value.ToString	'As String
					tbl_job.tbl_job_det_yarn(k).spools = Me.Dg_jobYarndet.Rows(i).Cells(4).Value.ToString	'As Double
					tbl_job.tbl_job_det_yarn(k).kg_gr = Me.Dg_jobYarndet.Rows(i).Cells(5).Value.ToString	'As Double
					tbl_job.tbl_job_det_yarn(k).kg_nt = Me.Dg_jobYarndet.Rows(i).Cells(6).Value.ToString	'As Double
					'tbl_job.tbl_job_det_yarn(i).tstamp = Me.Dg_jobYarndet.Rows(i).Cells("").Value.ToString 'As DateTime
					k = k + 1
				End If
			Next
			Dim sgn As String = ""
			Dim msgerr As String = ""
			isvalid = InsertYarn.InsertJobOrderforYarn(tbl_job, sgn, msgerr)
			If isvalid = True Then
				txtjobno.Text = sgn
				MsgBox("Success")
			Else
				MsgBox(msgerr)
			End If

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub BtnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchItem.Click
		Dim GetDatayarn As New GetDataYarn
		Dim tbl_items As New tbl_Items
		Dim ds As New DataSet
		tbl_items.itcd = Me.txtjbo.Text
		ds = GetDatayarn.GetDataItem(tbl_items)
		If ds.Tables(0).Rows.Count > 0 Then
			'Me.txtfspools.Text = ds.Tables(0).Rows(0).Item("").ToString
			'Me.txtftube.Text = ds.Tables(0).Rows(0).Item("").ToString
			Me.txtftpm.Text = ds.Tables(0).Rows(0).Item("twists").ToString
			Me.Cbcolor.Text = ds.Tables(0).Rows(0).Item("col").ToString
		End If
	End Sub

	Private Sub BtnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackAll.Click
		Dim i As Integer
		Dim dsTable As New DataTable
		Dim dsset As New DataSet
		dsTable = dsset.Tables.Add
		dsTable.Columns.Add("itcd", GetType(String))
		dsTable.Columns.Add("grade", GetType(String))
		dsTable.Columns.Add("boxno", GetType(String))
		dsTable.Columns.Add("spools", GetType(String))
		dsTable.Columns.Add("kg_gr", GetType(String))
		dsTable.Columns.Add("kg_nt", GetType(String))
		dsTable.Columns.Add("lotno_our", GetType(String))
		Me.Dg_jobYarndet.DataSource = dsset.Tables(0)
		For i = 0 To Me.DgYarnIn.Rows.Count - 2
			Me.DgYarnIn.Rows(i).Cells(0).Value = False
		Next
		CompareChkboxbetween_yarnin_with_job_yarn_det()
		CompareChkboxbetween_yarnin_with_job_yarn_det()
	End Sub

	Function GroupbyItcdofdts(ByVal dttt As DataTable) As DataTable
		Dim i As Integer
		Dim lastitcd As String
		Dim sum As Double
		Dim dsTable As New DataTable
		Dim dsset As New DataSet
		Dim dsRow As DataRow
		'Dim dt As DataTable
		'dsset.Clear()
		dsTable = dsset.Tables.Add
		dsTable.Columns.Add("itcd", GetType(String))
		dsTable.Columns.Add("grade", GetType(String))
		dsTable.Columns.Add("boxno", GetType(String))
		dsTable.Columns.Add("spools", GetType(String))
		dsTable.Columns.Add("kg_gr", GetType(String))
		dsTable.Columns.Add("kg_nt", GetType(String))
		dsTable.Columns.Add("lotno_our", GetType(String))
		If dttt.Rows.Count > 0 Then
			lastitcd = dttt.Rows(0).Item("itcd").ToString.Trim

			For i = 0 To dttt.Rows.Count - 1
				If dttt.Rows(i).Item("itcd").ToString.Trim = lastitcd.Trim Then
					sum = sum + dttt.Rows(i).Item("kg_nt")
				Else
					dsRow = dsTable.NewRow
					dsRow("itcd") = lastitcd
					dsRow("kg_nt") = sum
					dsset.Tables(0).Rows.Add(dsRow)
					sum = 0
					lastitcd = dttt.Rows(i).Item("itcd").ToString.Trim
					sum = dttt.Rows(i).Item("kg_nt")
				End If

			Next
			dsRow = dsTable.NewRow
			dsRow("itcd") = lastitcd
			dsRow("kg_nt") = sum
			dsset.Tables(0).Rows.Add(dsRow)
			Return dsset.Tables(0)
		Else
            Return New DataTable()
		End If
	End Function

	Private Sub BtnY_IN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnY_IN.Click
		Dim msgerr As String = ""
		Dim tblSupplier As New GetDataYarn
		'dts.Clear()
		Try
			dts = tblSupplier.GetYarnInno(Me.txtY_IN.Text, "", msgerr)
			dts.DefaultView.Sort = "itcd asc"
			If dts.Rows.Count > 0 Then
				Me.DgYarnIn.DataSource = dts
				Me.Dg_jobYarndet.DataSource = ""
			Else
				Me.DgYarnIn.DataSource = dts
				Me.Dg_jobYarndet.DataSource = ""
				MsgBox("Can not found")
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub Btn_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Stock.Click
		Dim msgerr As String = ""
		Dim tblSupplier As New GetDataYarn
		Try
			'dts.Clear()
			dts = tblSupplier.GetYarnInno("", Me.txtStock.Text, msgerr)

			dts.DefaultView.Sort = "itcd asc"
			If Not IsNothing(dts) Then
				Me.DgYarnIn.DataSource = dts
				Me.Dg_jobYarndet.DataSource = ""
			Else
				Me.DgYarnIn.DataSource = dts
				Me.Dg_jobYarndet.DataSource = ""
				MsgBox("Can not found")
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

    Private Sub CompareChkboxbetween_yarnin_with_job_yarn_det()
        Dim i As Integer
        Dim j As Integer
        'For i = 0 To Me.DgYarnIn.Rows.Count - 2
        For j = 0 To Me.Dg_jobYarndet.Rows.Count - 2
            If Me.Dg_jobYarndet.Rows(j).Cells("DGV_select").Value = True Then 'old coding by ball is If Me.Dg_jobYarndet.Rows(j).Cells(3).Value = True Then
                For i = 0 To Me.DgYarnIn.Rows.Count - 2
                    If Me.DgYarnIn.Rows(i).Cells(3).Value.ToString.Trim = Me.Dg_jobYarndet.Rows(j).Cells(3).Value.ToString.Trim Then
                        Me.DgYarnIn.Rows(i).Cells(0).Value = True
                    End If
                Next
            End If

        Next
        'Next
    End Sub

    Private Sub CompareChkboxbetween_yarnin_with_job_yarn_detbackone()
        Dim i As Integer
        Dim j As Integer
        'For i = 0 To Me.DgYarnIn.Rows.Count - 2
        For j = 0 To Me.Dg_jobYarndet.Rows.Count - 2
            If Me.Dg_jobYarndet.Rows(j).Cells(0).Value = True Then
                For i = 0 To Me.DgYarnIn.Rows.Count - 2
                    If Me.Dg_jobYarndet.Rows(j).Cells(3).Value.ToString.Trim = Me.DgYarnIn.Rows(i).Cells(3).Value.ToString.Trim Then

                        Me.DgYarnIn.Rows(i).Cells(0).Value = False

                    End If
                Next
            End If
        Next
        'Next
    End Sub

    'Private Sub Total_DgjobYarn()
    '	Dim i As Integer
    '	For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2

    '	Next
    '   End Sub

    Private Function PrintReport(ByVal ds As DataSet) As Boolean
        Dim clsConn As New classConnection()
        Const rptFileName = "RptPurchaseOrderCreate.rpt"
        If Not Clsconfig.CheckReport(clsUser.ReportPath, rptFileName) Then Return False
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.SetDataSource(ds.Tables("Tblprint"))

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Purchase Order"
        'frm.CRViewer.LocalReport = rpt
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
        Return True
    End Function

	Private Sub Btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprint.Click
		Dim str As String
		str = ""
		ds.Clear()
		str = "select * from v_job_yarn  " & _
		  "where jobno = '" & Me.txtjobno.Text & "' "

		Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
		myda.Fill(ds, "TblDatajobyarn")
		If ds.Tables("TblDatajobyarn").Rows.Count > 0 Then
            'Dim frmreport As New FormRptJobOrderforYarn
            'Dim obj As New RptJobOrderforYarn
            'obj.SetDataSource(ds.Tables("TblDatajobyarn"))
            'frmReport.CrystalReportViewer1.ReportSource = obj
            'frmReport.ShowDialog()

            Dim clsConn As New classConnection()
            Const rptFileName = "rptJobOrderForYarn.rpt"
            If Not Clsconfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            Dim frm As New frmReport
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Me.Cursor = Cursors.WaitCursor

            rpt.Load(clsUser.ReportPath & rptFileName)
            'rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            'rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.SetDataSource(ds.Tables("TblDatajobyarn"))

            rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
            rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

            frm.Title = "Job Order For Yarn"
            frm.CRViewer.ReportSource = rpt
            frm.MdiParent = Me.ParentForm
            frm.Show()
            Me.Cursor = Cursors.Default
		End If
	End Sub

	Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
		End
	End Sub

	Private Sub Dg_jobYarndet_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_jobYarndet.CellValidated
		Dim sumgross As Double
		Dim sumnet As Double
		Dim sumspools As Double
		Dim sumbox As Integer

		Dim i As Integer
		Dim j As Integer = 0
        'Dim boxno As Integer
		Dim kg_gr As Double
		Dim kg_nt As Double
		Dim spools As Double

		Try
			Dim countGrid As Integer
			countGrid = Me.Dg_jobYarndet.Rows.Count
			For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2
				If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
					j = j + 1
					spools = Clsconfig.IsValidDouble(Me.Dg_jobYarndet.Rows(i).Cells(4).Value)
					kg_gr = Clsconfig.IsValidDouble(Me.Dg_jobYarndet.Rows(i).Cells(5).Value)
					kg_nt = Clsconfig.IsValidDouble(Me.Dg_jobYarndet.Rows(i).Cells(6).Value)
					sumgross = sumgross + kg_gr
					sumnet = sumnet + kg_nt
					sumspools = sumspools + spools
					sumbox = j
				End If
			Next
			Me.txtbox.Text = sumbox
			Me.txtspools.Text = sumspools
			Me.txtkg_gr.Text = sumgross
			Me.txtkg_nt.Text = sumnet
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub txtjbo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjbo.KeyPress
		If AscW(e.KeyChar) = 13 Then
			Dim GetDatayarn As New GetDataYarn
			Dim tbl_items As New tbl_Items
			Dim ds As New DataSet
			tbl_items.itcd = Me.txtjbo.Text
			ds = GetDatayarn.GetDataItem(tbl_items)
			If ds.Tables(0).Rows.Count > 0 Then
				'Me.txtfspools.Text = ds.Tables(0).Rows(0).Item("").ToString
				'Me.txtftube.Text = ds.Tables(0).Rows(0).Item("").ToString
				Me.txtftpm.Text = ds.Tables(0).Rows(0).Item("twists").ToString
				Me.Cbcolor.Text = ds.Tables(0).Rows(0).Item("col").ToString
			End If
		End If
	End Sub

    Private Sub DgYarnIn_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarnIn.CellContentClick

    End Sub
End Class