Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Globalization

Public Class formJobOrderforYarn
	Public loginEmpcd
	Private connStr As New classConnection
	Dim ds As New DataSet
	Dim dtJob As New DataTable

	Private dts As DataTable
	Private dt As DataTable
	Private Clsconfig As New clsConfig

	Private Sub GenGrid()
		Dg_jobYarndet.DataSource = Nothing
		Dg_jobYarndet.AutoGenerateColumns = False
		dtJob = New DataTable
		dtJob.Columns.Add("itcd", GetType(String))
		dtJob.Columns.Add("grade", GetType(String))
		dtJob.Columns.Add("boxno", GetType(String))
		dtJob.Columns.Add("spools", GetType(String))
		dtJob.Columns.Add("kg_gr", GetType(String))
		dtJob.Columns.Add("kg_nt", GetType(String))
		dtJob.Columns.Add("lotno_our", GetType(String))
		Dg_jobYarndet.DataSource = dtJob
	End Sub

	Private Sub AddRowToGrid(ByVal dtSource As DataTable)
		Dim dr As Data.DataRow
		Dim i As Integer = 0
		Dim j As Integer = 0
		If Not dtSource Is Nothing Then
			If dtSource.Rows.Count > 0 Then
				For i = 0 To dtSource.Rows.Count - 1
					dr = dtJob.Rows.Add
					For j = 0 To dtJob.Columns.Count - 1
						dr(j) = dtSource.Rows(i).Item(j)
					Next
				Next
			End If
		End If
		Dg_jobYarndet.Refresh()
	End Sub

	Private Sub formJobOrderforYarn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		DgYarnIn.AutoGenerateColumns = False
		Call GenGrid()
		FuncDiscbSupplier()
		Funcdiscbjbotype()
		FuncDisColor()
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
            getYarnStock()
        End If
    End Sub

    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        If AscW(e.KeyChar) = 13 Then
            getYarnStock()
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
                    dsRow("itcd") = Me.DgYarnIn.Rows(i).Cells("cboitcd").Value.ToString
                    dsRow("grade") = Me.DgYarnIn.Rows(i).Cells("grade").Value.ToString
                    dsRow("boxno") = Me.DgYarnIn.Rows(i).Cells("boxno1").Value.ToString
                    dsRow("spools") = Me.DgYarnIn.Rows(i).Cells("spools").Value.ToString
                    dsRow("kg_gr") = Me.DgYarnIn.Rows(i).Cells("kg_gr").Value.ToString
                    dsRow("kg_nt") = Me.DgYarnIn.Rows(i).Cells("kg_nt").Value.ToString
                    dsRow("lotno_our") = Me.DgYarnIn.Rows(i).Cells("lotno_our").Value.ToString
                    dsset.Tables(0).Rows.Add(dsRow)
                End If
            Next
        End If
        dt = dsset.Tables(0)

        'Me.Dg_jobYarndet.DataSource = dt
        Call AddRowToGrid(dt)
        compareTwoGrids()
        cal()
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
                dsRow("itcd") = Me.DgYarnIn.Rows(i).Cells("cboitcd").Value.ToString
                dsRow("grade") = Me.DgYarnIn.Rows(i).Cells("grade").Value.ToString
                dsRow("boxno") = Me.DgYarnIn.Rows(i).Cells("boxno1").Value.ToString
                dsRow("spools") = Me.DgYarnIn.Rows(i).Cells("spools").Value.ToString
                dsRow("kg_gr") = Me.DgYarnIn.Rows(i).Cells("kg_gr").Value.ToString
                dsRow("kg_nt") = Me.DgYarnIn.Rows(i).Cells("kg_nt").Value.ToString
                dsRow("lotno_our") = Me.DgYarnIn.Rows(i).Cells("lotno_our").Value.ToString
                dsset.Tables(0).Rows.Add(dsRow)

            Next
        End If
        dt = dsset.Tables(0)


        'Me.Dg_jobYarndet.DataSource = dt
        Call AddRowToGrid(dt)
        dts.Rows.Clear()
        cal()
    End Sub

    Private Sub BtnBackOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackOne.Click
        Dim i As Integer
        For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2
            If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
                Me.Dg_jobYarndet.Rows.RemoveAt(i)
            End If
        Next
        getYarnStock()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim config As New clsConfig
        config.ChangeCulture()

        Dim i As Integer = 0
        Dim InsertYarn As New InsertYarn
        Dim isvalid As Boolean
        Dim tbl_job As New tbl_job
        'cal()
        Try

            tbl_job.jobdt = Me.txtjobdt.Value.ToString("yyy/MM/dd")
            tbl_job.suppcd = Me.CbSuppcd.SelectedValue
            'tbl_job.reqno =As String
            tbl_job.jobtype = Me.Cbjobtype.SelectedValue
            tbl_job.kono = Me.textKono.Text.ToUpper.Trim
            tbl_job.jobitcd = textNewItcd.Text
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
                    'If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
                    dsRow = dsTable.NewRow
                    dsRow("itcd") = Me.Dg_jobYarndet.Rows(i).Cells(1).Value.ToString
                    dsRow("grade") = Me.Dg_jobYarndet.Rows(i).Cells(2).Value.ToString
                    dsRow("boxno") = Me.Dg_jobYarndet.Rows(i).Cells(3).Value.ToString
                    dsRow("spools") = Me.Dg_jobYarndet.Rows(i).Cells(4).Value.ToString
                    dsRow("kg_gr") = Me.Dg_jobYarndet.Rows(i).Cells(5).Value.ToString
                    dsRow("kg_nt") = Me.Dg_jobYarndet.Rows(i).Cells(6).Value.ToString
                    dsRow("lotno_our") = Me.Dg_jobYarndet.Rows(i).Cells(7).Value.ToString
                    dsset.Tables(0).Rows.Add(dsRow)
                    'End If
                Next
            End If

            Dim dr As DataRow

            Dim dgroupdts As DataTable
            '			dgroupdts = GroupbyItcdofdts(dsset.Tables(0))
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
                tbl_job.tbl_job_det(j).qty = dr.Item("kg_nt")   'As Double
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
                'If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
                ReDim Preserve tbl_job.tbl_job_det_yarn(k)
                tbl_job.tbl_job_det_yarn(k) = New tbl_job_det_yarn
                'tbl_job.tbl_job_det_yarn(i).id_job_det_yarn = Me.Dg_jobYarndet.Rows(i).Cells("").Value.ToString	'As Integer
                'tbl_job.tbl_job_det_yarn(i).id_job_det = Me.Dg_jobYarndet.Rows(i).Cells("").Value.ToString 'As Integer
                'tbl_job.tbl_job_det_yarn(i).lotno_sup = Me.Dg_jobYarndet.Rows(i).Cells("").Value.ToString		'As String
                'tbl_job.tbl_job_det_yarn(i).lotno_our = Me.Dg_jobYarndet.Rows(i).Cells("").Value.ToString	'As String
                tbl_job.tbl_job_det_yarn(k).itcd = Me.Dg_jobYarndet.Rows(i).Cells(1).Value.ToString 'As String
                tbl_job.tbl_job_det_yarn(k).boxno = Me.Dg_jobYarndet.Rows(i).Cells(3).Value.ToString    'As String
                tbl_job.tbl_job_det_yarn(k).spools = Me.Dg_jobYarndet.Rows(i).Cells(4).Value.ToString   'As Double
                tbl_job.tbl_job_det_yarn(k).kg_gr = Me.Dg_jobYarndet.Rows(i).Cells(5).Value.ToString    'As Double
                tbl_job.tbl_job_det_yarn(k).kg_nt = Me.Dg_jobYarndet.Rows(i).Cells(6).Value.ToString    'As Double
                '         tbl_job.tbl_job_det_yarn(i).tstamp = Clsconfig.ConvertFormatDateTostring(Today.Date) 'string to datetime
                k = k + 1
                'End If
            Next
            Dim sgn As String = ""
            Dim msgerr As String = ""
            isvalid = InsertYarn.InsertJobOrderforYarn(tbl_job, sgn, msgerr, Me.loginEmpcd)
            If isvalid = True Then
                txtjobno.Text = sgn
                MsgBox("Success")
                dts.Rows.Clear()
                dt.Rows.Clear()
                dtJob.Rows.Clear()
            Else
                MsgBox(msgerr)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        getYarnStock()
    End Sub

    Function GroupbyItcdofdts(ByVal dttt As DataTable) As DataTable
        Dim i As Integer
        Dim lastitcd As String
        Dim sum As Double
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
            Return Nothing
        End If
    End Function

    Private Sub BtnY_IN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnY_IN.Click
        Dim selectedYin As String
        Dim formSearchYin As New formSearchYarn
        selectedYin = formSearchYin.getYarnno()
        If selectedYin <> "" Then
            Me.txtY_IN.Text = selectedYin
        End If
        Me.RdoY_IN.Checked = True
        Me.txtStock.Text = ""
        getYarnStock()
    End Sub

    Private Sub Btn_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Stock.Click
        Dim selectedItcd As String
        Dim formSearchItemCodeFromBalance As New formSearchItemCodeFromBalance
        selectedItcd = formSearchItemCodeFromBalance.getItemcode("ALL")
        If selectedItcd <> "" Then
            Me.txtStock.Text = selectedItcd
        End If
        Me.RdoStock.Checked = True
        Me.txtY_IN.Text = ""

        getYarnStock()
    End Sub

    Private Sub compareTwoGrids()
        Dim i As Integer
        Dim j As Integer
        'For i = 0 To Me.DgYarnIn.Rows.Count - 2
        For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2
            j = 0
            Do While Me.DgYarnIn.Rows.Count - 2 >= 0 And j <= Me.DgYarnIn.Rows.Count - 2
                If Me.DgYarnIn.Rows(j).Cells("boxno1").Value.ToString.Trim = Me.Dg_jobYarndet.Rows(i).Cells("boxno2").Value.ToString.Trim Then
                    Dim dgvRow As New DataGridViewRow
                    dgvRow = Me.DgYarnIn.Rows(j)
                    Me.DgYarnIn.Rows.Remove(dgvRow)
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

    Private Sub Total_DgjobYarn()
        'Dim i As Integer
        'For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2

        'Next
    End Sub

    Private Sub Btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprint.Click
        Dim str As String
        str = ""
        ds.Clear()
        str = "select * from v_job_yarn  " & _
          "where jobno = '" & Me.txtjobno.Text & "' "

        Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        myda.Fill(ds, "TblDatajobyarn")
        If ds.Tables("TblDatajobyarn").Rows.Count > 0 Then
            Dim frmreport As New FormRptJobOrderforYarn
            Dim obj As New RptJobOrderforYarn
            obj.SetDataSource(ds.Tables("TblDatajobyarn"))

            frmreport.CrystalReportViewer1.ReportSource = obj

            frmreport.ShowDialog()
        End If
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub Dg_jobYarndet_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dg_jobYarndet.CellValidated
        Dim sumgross As Double
        Dim sumnet As Double
        Dim sumspools As Double
        Dim sumbox As Integer

        Dim i As Integer
        Dim j As Integer = 0
        Dim boxno As Integer
        Dim kg_gr As Double
        Dim kg_nt As Double
        Dim spools As Double

        Try
            Dim countGrid As Integer
            countGrid = Me.Dg_jobYarndet.Rows.Count
            For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2
                'If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
                j = j + 1
                spools = Clsconfig.IsValidDouble(Me.Dg_jobYarndet.Rows(i).Cells(4).Value)
                kg_gr = Clsconfig.IsValidDouble(Me.Dg_jobYarndet.Rows(i).Cells(5).Value)
                kg_nt = Clsconfig.IsValidDouble(Me.Dg_jobYarndet.Rows(i).Cells(6).Value)
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub cal()
        Dim sumgross As Double
        Dim sumnet As Double
        Dim sumspools As Double
        Dim sumbox As Integer

        Dim i As Integer
        Dim j As Integer = 0
        Dim boxno As Integer
        Dim kg_gr As Double
        Dim kg_nt As Double
        Dim spools As Double

        Try
            Dim countGrid As Integer
            countGrid = Me.Dg_jobYarndet.Rows.Count
            For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2
                'If Me.Dg_jobYarndet.Rows(i).Cells(0).Value = True Then
                j = j + 1
                spools = Clsconfig.IsValidDouble(Me.Dg_jobYarndet.Rows(i).Cells("colSpools").Value)
                kg_gr = Clsconfig.IsValidDouble(Me.Dg_jobYarndet.Rows(i).Cells("colKg_gr").Value)
                kg_nt = Clsconfig.IsValidDouble(Me.Dg_jobYarndet.Rows(i).Cells("colKg_nt").Value)
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub textKono_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles textKono.Validated
        Validate_kono()
    End Sub

    Private Sub Cbjobtype_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbjobtype.Validated
        If Cbjobtype.SelectedValue.ToString.Trim = "KNITTING" Then
            Me.textKono.Enabled = True
        Else
            Me.textKono.Enabled = False
            Me.textKono.Text = ""
        End If
        Validate_kono()
    End Sub

    Private Sub Validate_kono()
        Dim cmdKo As New SqlCommand
        Dim m_Kono As String = Me.textKono.Text
        Dim m_Kono_Found As String
        Dim cn As New SqlConnection
        cn.ConnectionString = connStr.connection
        cmdKo.Connection = cn
        cn.Open()
        cmdKo.CommandText = "Select Kono from Ko where kono = '" & m_Kono & "'"
        m_Kono_Found = cmdKo.ExecuteScalar
        If Not m_Kono_Found = m_Kono Then
            If Cbjobtype.SelectedValue.ToString.Trim = "KNITTING" Then
                Me.ErrorProvider1.SetError(Me.textKono, "Enter a valid K/O")
                cn.Close()
                Exit Sub
            End If
        End If
        Me.ErrorProvider1.Clear()
        cn.Close()
    End Sub

    Private Sub Cbjobtype_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Cbjobtype.Validating
        If Cbjobtype.SelectedValue.ToString.Trim = "KNITTING" Then
            Me.textKono.Enabled = True
        Else
            Me.textKono.Enabled = False
            Me.textKono.Text = ""
        End If
        Validate_kono()
    End Sub

    Private Sub getYarnStock()
        Dim msgerr As String = ""
        Dim getDataYarn As New GetDataYarn
        Try
            'dts.Clear()
            dts = getDataYarn.GetYarnInno(Me.txtY_IN.Text, Me.txtStock.Text, msgerr)

            dts.DefaultView.Sort = "itcd asc"
            If Not IsNothing(dts) Then
                Me.DgYarnIn.DataSource = dts
                'Me.Dg_jobYarndet.DataSource = ""
            Else
                Me.DgYarnIn.DataSource = dts
                'Me.Dg_jobYarndet.DataSource = ""
                MsgBox("Can not found")
            End If
            compareTwoGrids()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnSearchKI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchKI.Click
        Dim formSearchKi As New formSearchKO
        Dim selectedKono As String
        selectedKono = formSearchKO.getKono
        If selectedKono <> "" Then
            Me.textKono.Text = selectedKono
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
        Dg_jobYarndet.Refresh()
    End Sub

    Private Sub txtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStock.TextChanged

    End Sub

    Private Sub txtY_IN_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtY_IN.KeyUp

    End Sub

    Private Sub txtY_IN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtY_IN.TextChanged

    End Sub

    Private Sub RdoStock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoStock.CheckedChanged
        If Me.RdoStock.Checked Then
            txtY_IN.Text = ""
        End If
    End Sub

    Private Sub RdoY_IN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdoY_IN.CheckedChanged
        If Me.RdoY_IN.Checked Then
            txtStock.Text = ""
        End If
    End Sub
End Class
