Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class formJobOrderforYarnEdit
	Public loginEmpcd
    Private connStr As New classConnection
    Dim ds As New DataSet

    Private dts As DataTable
    Private dt As DataTable
    Private Clsconfig As New clsConfig
    Public strJob_no_search As String = ""
    Public numsofrow As Integer

    Private Sub formJobOrderforYarnEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Me.txtStock.Text = ""
            Dim msgerr As String = ""
            Dim tblSupplier As New GetDataYarn
            'dts.Clear()
            Try
                dts = tblSupplier.GetYarnInno(Me.txtY_IN.Text, "", 0, msgerr)
                dts.DefaultView.Sort = "itcd asc"
                If dts.Rows.Count > 0 Then
                    Me.DgYarnIn.DataSource = dts
                Else
                    Me.DgYarnIn.DataSource = dts
                    MsgBox("Can not found")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        If AscW(e.KeyChar) = 13 Then
            Me.txtY_IN.Text = ""
            Dim msgerr As String = ""
            Dim tblSupplier As New GetDataYarn
            Try
                'dts.Clear()
                dts = tblSupplier.GetYarnInno("", Me.txtStock.Text, 0, msgerr)

                dts.DefaultView.Sort = "itcd asc"
                If Not IsNothing(dts) Then
                    Me.DgYarnIn.DataSource = dts
                Else
                    Me.DgYarnIn.DataSource = dts
                    MsgBox("Can not found")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSendOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendOne.Click
        Dim i As Integer
        Dim j As Integer
        Dim flagcanselect_boxno As Boolean
        Dim strmsg As String = ""
        Dim strboxnoshow As String = ""
        Dim strboxnoselect As String = ""
        Try
            If Me.DgYarnIn.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
            For j = 0 To Me.DgYarnIn.Rows.Count - 2
                flagcanselect_boxno = False
                If Me.DgYarnIn.Rows(j).Cells("DGV_show").Value = True Then
                    strboxnoshow = Me.DgYarnIn.Rows(j).Cells("boxno").Value.ToString.Trim
                    If chkErrbutUse2(strmsg) = True Then
                        For i = 0 To ds.Tables("v_editJoboOrderForYarnEdit").Rows.Count - 1
                            strboxnoselect = ds.Tables("v_editJoboOrderForYarnEdit").Rows(i).Item("boxno").ToString.Trim
                            If strboxnoshow = strboxnoselect Then
                                flagcanselect_boxno = True
                                Exit For
                            End If
                        Next
                    Else
                        MsgBox("โปรแกรมนี้ใช้ในการแก้ไขจาก Jobno : กรุณาระบุ jobno : แล้วทำการค้นหาก่อนครับผม", MsgBoxStyle.Critical, "เกิดข้อผิดพลาดการใช้งาน")
                        Exit Sub
                    End If
                End If
                If flagcanselect_boxno = False And Me.DgYarnIn.Rows(j).Cells("DGV_show").Value = True Then
                    ds.Tables("v_editJoboOrderForYarnEdit").Rows.Add(Me.DgYarnIn.Rows(j).Cells("cboitcd").Value, Me.DgYarnIn.Rows(j).Cells("Grade").Value, Me.DgYarnIn.Rows(j).Cells("boxno").Value, Me.DgYarnIn.Rows(j).Cells("spools").Value, Me.DgYarnIn.Rows(j).Cells("kg_gr").Value, Me.DgYarnIn.Rows(j).Cells("kg_nt").Value, Me.DgYarnIn.Rows(j).Cells("Lotno_our").Value)
                End If
            Next
            cal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnsendAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnsendAll.Click
        Dim i As Integer
        Dim j As Integer
        Dim flagcanselect_boxno As Boolean
        Dim strmsg As String = ""
        Dim strboxnoshow As String = ""
        Dim strboxnoselect As String = ""
        Try
            If Me.DgYarnIn.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
            For j = 0 To Me.DgYarnIn.Rows.Count - 2
                flagcanselect_boxno = False
                strboxnoshow = Me.DgYarnIn.Rows(j).Cells("boxno").Value.ToString.Trim
                If chkErrbutUse2(strmsg) = True Then
                    For i = 0 To ds.Tables("v_editJoboOrderForYarnEdit").Rows.Count - 1
                        strboxnoselect = ds.Tables("v_editJoboOrderForYarnEdit").Rows(i).Item("boxno").ToString.Trim
                        If strboxnoshow = strboxnoselect Then
                            flagcanselect_boxno = True
                            Exit For
                        End If
                    Next
                Else
                    MsgBox("โปรแกรมนี้ใช้ในการแก้ไขจาก Jobno : กรุณาระบุ jobno : แล้วทำการค้นหาก่อนครับผม", MsgBoxStyle.Critical, "เกิดข้อผิดพลาดการใช้งาน")
                    Exit Sub
                End If

                If flagcanselect_boxno = False Then
                    ds.Tables("v_editJoboOrderForYarnEdit").Rows.Add(Me.DgYarnIn.Rows(j).Cells("cboitcd").Value, Me.DgYarnIn.Rows(j).Cells("Grade").Value, Me.DgYarnIn.Rows(j).Cells("boxno").Value, Me.DgYarnIn.Rows(j).Cells("spools").Value, Me.DgYarnIn.Rows(j).Cells("kg_gr").Value, Me.DgYarnIn.Rows(j).Cells("kg_nt").Value, Me.DgYarnIn.Rows(j).Cells("Lotno_our").Value)
                End If
            Next
            cal()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnBackOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackOne.Click
        Dim myrow As DataRow
        Dim strmsg As String = ""
        Dim i As Integer
        If Me.Dg_jobYarndet.Rows.Count = 1 Then Exit Sub
        Dim arrint(Me.Dg_jobYarndet.Rows.Count - 2) As Integer
        Try
            For i = Me.Dg_jobYarndet.Rows.Count - 2 To 0 Step -1
                If chkErrbutUse2(strmsg) = True Then
                    If Me.Dg_jobYarndet.Rows(i).Cells("DGV_select").Value = True Then
                        arrint(i) = 1
                        myrow = ds.Tables("v_editJoboOrderForYarnEdit").Rows(i)
                        ds.Tables("v_editJoboOrderForYarnEdit").Rows.Remove(myrow)
                        'i = i - 1
                    Else
                        arrint(i) = 0
                    End If
                End If
            Next
            'For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2
            '    If arrint(i) = 1 Then
            '        myrow = ds.Tables("v_editJoboOrderForYarnEdit").Rows(i)
            '        ds.Tables("v_editJoboOrderForYarnEdit").Rows.Remove(myrow)
            '    End If
            'Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

	Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
		Dim config As New clsConfig
		config.ChangeCulture()

		Dim strmsg As String = ""
		If chkErrbutUse2(strmsg) = True Then
		Else
			MsgBox("โปรแกรมนี้ใช้ในการแก้ไขจาก Jobno : กรุณาระบุ jobno :  แล้วทำการค้นหาก่อนครับผม", MsgBoxStyle.Critical, "เกิดข้อผิดพลาดการใช้งาน")
			Exit Sub
		End If
		Dim connstr As New classConnection
		Dim ds1 As New DataSet
		Dim i As Integer
		Dim Msgerr As String = ""
		Dim strupdate_det As String = ""
		Dim strupt As New StringBuilder
		'Dim connstr As New classConnection
		Dim conn As SqlConnection = New SqlConnection
        conn.ConnectionString = connstr.ConnectionString
        conn.Open()
        Dim tran As SqlTransaction
        Dim comm As SqlCommand = New SqlCommand
        tran = conn.BeginTransaction
        comm.Connection = conn
        comm.Transaction = tran
        Dim strsql1 As String = ""
        Dim jobdt As String = ""

        '--------------------
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "log_job"
        comm.Parameters.AddWithValue("@empcd", loginEmpcd)
        comm.Parameters.AddWithValue("@docno", Me.txtjobno.Text.Trim)
        comm.Parameters.AddWithValue("@action", "EDIT")
        comm.CommandType = CommandType.StoredProcedure
        comm.ExecuteNonQuery()
        comm.CommandType = CommandType.Text
        '--------------------

        Try
            If conversTimeToString(Me.txtjobdt.Value) <> "18000101" Then
                jobdt = conversTimeToString(Me.txtjobdt.Value)
            Else
                MsgBox("Can not converst datetime edit format time", MsgBoxStyle.Critical, "Error")
                tran.Rollback()
                Exit Sub
            End If
            strsql1 = "Update job "
            strsql1 = strsql1 & " SET jobdt='" & jobdt & "',"
            strsql1 = strsql1 & "suppcd='" & Me.CbSuppcd.SelectedValue.ToString.Trim & "',"
            strsql1 = strsql1 & "jobtype='" & Me.Cbjobtype.SelectedValue.ToString.Trim & "',"
            strsql1 = strsql1 & "kono='" & Me.textKono.Text.Trim & "',"
            strsql1 = strsql1 & "jobitcd='" & Me.txtjbo.Text.Trim & "',"
            strsql1 = strsql1 & "tubeqty='" & Me.txtfspools.Text.Trim & "',"
            strsql1 = strsql1 & "tubekg='" & Me.txtftube.Text.Trim & "',"
            strsql1 = strsql1 & "twists='" & Me.txtftpm.Text.Trim & "', "
            strsql1 = strsql1 & "col='" & Me.Cbcolor.SelectedValue.ToString.Trim & "',"
            strsql1 = strsql1 & "import='0', "
            strsql1 = strsql1 & "cancel_status='0'"
            strsql1 = strsql1 & " WHERE  jobno='" & Me.txtjobno.Text.Trim & "'"

            comm.CommandText = strsql1.ToString
            comm.ExecuteNonQuery()
            '*********************************************************
            'Dim strsql2 As String = ""
            '         strsql2 = "Update job_det set qty = '" & Me.txtkg_nt.Text.Trim & "' WHERE jobno='" & Me.txtjobno.Text.Trim & "'"
            'comm.CommandText = strsql2.ToString
            'comm.ExecuteNonQuery()
            '***********************************************************
            Dim flagcanselect_boxno As Boolean
            Dim strboxnoshow As String = ""
            Dim strboxnoselect As String = ""
            Dim strid_job_det As String = ""
            Dim strid_job_det_yarn As String = ""
            Dim strlotno_sup As String = ""
            Dim strlotno_our As String = ""
            Dim strsql3 As String = ""
            Dim strsqldel As String = ""
            Dim j As Integer
            For j = 0 To Me.Dg_jobYarndet.Rows.Count - 2
                flagcanselect_boxno = False
                strboxnoshow = Me.Dg_jobYarndet.Rows(j).Cells("clmboxno").Value.ToString.Trim
                If chkdatajobdet(strmsg) = True Then
                    For i = 0 To ds.Tables("v_dataJoboOrde").Rows.Count - 1
                        strboxnoselect = ds.Tables("v_dataJoboOrde").Rows(i).Item("boxno").ToString.Trim
                        strid_job_det = ds.Tables("v_dataJoboOrde").Rows(i).Item("id_job_det").ToString.Trim
                        strid_job_det_yarn = ds.Tables("v_dataJoboOrde").Rows(i).Item("id_job_det_yarn").ToString.Trim
                        strlotno_sup = ds.Tables("v_dataJoboOrde").Rows(i).Item("lotno_sup").ToString.Trim
                        strlotno_our = ds.Tables("v_dataJoboOrde").Rows(i).Item("lotno_our").ToString.Trim
                        If strboxnoshow = strboxnoselect Then
                            flagcanselect_boxno = True
                            Exit For
                        End If
                    Next
                Else
                    MsgBox("โปรแกรมนี้ใช้ในการแก้ไขจาก Jobno : กรุณาระบุ jobno : แล้วทำการค้นหาก่อนครับผม", MsgBoxStyle.Critical, "เกิดข้อผิดพลาดการใช้งาน")
                    tran.Rollback()
                    Exit Sub
                End If
                If flagcanselect_boxno = False Then ' check never has data
                    'CASe AddNew
                    'strid_job_det = ""strboxnoshow
                    strsql3 = "INSERT INTO job_det_yarn(id_job_det,lotno_sup,lotno_our,itcd,boxno,spools,kg_gr,kg_nt,tstamp)"
                    strsql3 = strsql3 & "VALUES( '" & strid_job_det & "', '',"
                    strsql3 = strsql3 & "'', "
                    strsql3 = strsql3 & "'" & Me.Dg_jobYarndet.Rows(j).Cells("clmitcd").Value.ToString.Trim & "', "
                    strsql3 = strsql3 & "'" & Me.Dg_jobYarndet.Rows(j).Cells("clmboxno").Value.ToString.Trim & "', "
                    strsql3 = strsql3 & "'" & Me.Dg_jobYarndet.Rows(j).Cells("clmspools").Value.ToString.Trim & "', "
                    strsql3 = strsql3 & "'" & Me.Dg_jobYarndet.Rows(j).Cells("clmkg_gr").Value.ToString.Trim & "', "
                    strsql3 = strsql3 & "'" & Me.Dg_jobYarndet.Rows(j).Cells("clmkg_nt").Value.ToString.Trim & "',  getdate())"
                Else
                    'CASE Edit
                    strsql3 = "Update job_det_yarn set "
                    'strsql3 = strsql3 & "lotno_sup ='" & strlotno_sup & "',"
                    'strsql3 = strsql3 & "lotno_our ='" & strlotno_our & "',"
                    strsql3 = strsql3 & "spools='" & Me.Dg_jobYarndet.Rows(j).Cells("clmspools").Value.ToString.Trim & "',"
                    strsql3 = strsql3 & "kg_gr='" & Me.Dg_jobYarndet.Rows(j).Cells("clmkg_gr").Value.ToString.Trim & "',"
                    strsql3 = strsql3 & "kg_nt='" & Me.Dg_jobYarndet.Rows(j).Cells("clmkg_nt").Value.ToString.Trim & "',"
                    strsql3 = strsql3 & "tstamp = getdate()  "
                    strsql3 = strsql3 & "where id_job_det_yarn = '" & strid_job_det_yarn & "' and id_job_det ='" & strid_job_det & "' and boxno ='" & strboxnoselect & "'"
                End If
                comm.CommandText = strsql3.ToString
                comm.ExecuteNonQuery()
            Next
            'CASE Delet row
            For j = 0 To ds.Tables("v_dataJoboOrde").Rows.Count - 1
                flagcanselect_boxno = False
                strboxnoshow = ds.Tables("v_dataJoboOrde").Rows(j).Item("boxno").ToString.Trim '
                strid_job_det = ds.Tables("v_dataJoboOrde").Rows(j).Item("id_job_det").ToString.Trim
                strid_job_det_yarn = ds.Tables("v_dataJoboOrde").Rows(j).Item("id_job_det_yarn").ToString.Trim
                If chkdatajobdet(strmsg) = True Then
                    For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2
                        strboxnoselect = Me.Dg_jobYarndet.Rows(i).Cells("clmboxno").Value.ToString.Trim
                        If strboxnoshow = strboxnoselect Then
                            flagcanselect_boxno = True
                            Exit For
                        End If
                    Next
                Else
                    MsgBox("โปรแกรมนี้ใช้ในการแก้ไขจาก Jobno : กรุณาระบุ jobno : แล้วทำการค้นหาก่อนครับผม", MsgBoxStyle.Critical, "เกิดข้อผิดพลาดการใช้งาน")
                    tran.Rollback()
                    Exit Sub
                End If
                If flagcanselect_boxno = False Then ' check never has data
                    strsqldel = "delete job_det_yarn where id_job_det_yarn = '" & strid_job_det_yarn & "'"
                    comm.CommandText = strsqldel.ToString
                    comm.ExecuteNonQuery()
                Else
                End If
            Next
            Me.Dg_jobYarndet.DataSource = ""
            ds.Tables("v_editJoboOrderForYarnEdit").Clear()
            ds.Tables("v_dataJoboOrde").Clear()
            MsgBox("Update " & Me.txtjobno.Text.Trim & " Success", MsgBoxStyle.Information, "Complete ")
            'Me.txtjobno.Text = ""
            cleartext()
            tran.Commit()
        Catch ex As Exception
            Msgerr = ex.Message
            MsgBox(Msgerr)
            tran.Rollback()
        Finally
            conn.Close()
        End Try
    End Sub
    Private Sub cleartext()
        Me.txtjobno.Text = ""
        Me.textKono.Text = ""
        Me.txtbox.Text = "0"
        Me.txtspools.Text = "0"
        Me.txtkg_gr.Text = "0"
        Me.txtkg_nt.Text = "0"
        Me.txtftpm.Text = ""
        Me.txtftube.Text = ""
        Me.txtfspools.Text = ""
        Me.txtjbo.Text = ""
        Me.Cbcolor.SelectedIndex = 0
        Me.Cbjobtype.SelectedIndex = 0
        Me.CbSuppcd.SelectedIndex = 0
        Me.txtjobdt.Value = Now
    End Sub

    Private Sub BtnSearchItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearchItem.Click
        Dim GetDatayarn As New GetDataYarn
        Dim tbl_items As New tbl_Items
        Dim ds As New DataSet
        tbl_items.itcd = Me.txtjbo.Text
        ds = GetDatayarn.GetDataItem(tbl_items)
        If ds.Tables(0).Rows.Count > 0 Then
            Me.txtftpm.Text = ds.Tables(0).Rows(0).Item("twists").ToString
            Me.Cbcolor.Text = ds.Tables(0).Rows(0).Item("col").ToString
        End If
    End Sub

    Private Sub BtnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBackAll.Click
        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        Dim strsql2 As String
        Dim strmsg As String = ""
        Try
            strsql2 = "select itcd,grade,boxno,spools,kg_gr,kg_nt,lotno_our from v_job_yarn where jobno = '^*^'"
            Dim da As New SqlDataAdapter(strsql2.ToString, connStr.ConnectionString)
            If chkErrbutUse(strmsg) = True Then
                ds.Tables("v_editJoboOrderForYarnEdit").Clear()
            End If
            da.Fill(ds, "v_editJoboOrderForYarnEdit")
            If ds.Tables("v_editJoboOrderForYarnEdit").Rows.Count > 0 Then
                dsTable = ds.Tables("v_editJoboOrderForYarnEdit")
                Me.Dg_jobYarndet.DataSource = dsTable
            Else
                Me.Dg_jobYarndet.DataSource = dsTable
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
            Return New DataTable()
        End If
    End Function

    Private Sub BtnY_IN_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtStock.Text = ""
        Dim msgerr As String = ""
        Dim tblSupplier As New GetDataYarn
        'dts.Clear()
        Try
            dts = tblSupplier.GetYarnInno(Me.txtY_IN.Text, "", 0, msgerr)
            dts.DefaultView.Sort = "itcd asc"
            If dts.Rows.Count > 0 Then
                Me.DgYarnIn.DataSource = dts
            Else
                Me.DgYarnIn.DataSource = dts
                MsgBox("Can not found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Stock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Stock.Click
        Me.txtY_IN.Text = ""
        Dim msgerr As String = ""
        Dim tblSupplier As New GetDataYarn
        Try
            'dts.Clear()
            dts = tblSupplier.GetYarnInno("", Me.txtStock.Text, 0, msgerr)

            dts.DefaultView.Sort = "itcd asc"
            If Not IsNothing(dts) Then
                Me.DgYarnIn.DataSource = dts
            Else
                Me.DgYarnIn.DataSource = dts
                MsgBox("Can not found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CompareChkboxbetween_yarnin_with_job_yarn_det()
        Dim i As Integer
        Dim j As Integer
        For j = 0 To Me.Dg_jobYarndet.Rows.Count - 2
            If Me.Dg_jobYarndet.Rows(j).Cells("DGV_select").Value = True Then 'old coding by ball is If Me.Dg_jobYarndet.Rows(j).Cells(3).Value = True Then
                For i = 0 To Me.DgYarnIn.Rows.Count - 2
                    If Me.DgYarnIn.Rows(i).Cells(3).Value.ToString.Trim = Me.Dg_jobYarndet.Rows(j).Cells(3).Value.ToString.Trim Then
                        Me.DgYarnIn.Rows(i).Cells(0).Value = True
                    End If
                Next
            End If

        Next
    End Sub

    Sub CompareChkboxbetween_yarnin_with_job_yarn_detbackone()
        Dim i As Integer
        Dim j As Integer
        For j = 0 To Me.Dg_jobYarndet.Rows.Count - 2
            If Me.Dg_jobYarndet.Rows(j).Cells(0).Value = True Then
                For i = 0 To Me.DgYarnIn.Rows.Count - 2
                    If Me.Dg_jobYarndet.Rows(j).Cells(3).Value.ToString.Trim = Me.DgYarnIn.Rows(i).Cells(3).Value.ToString.Trim Then

                        Me.DgYarnIn.Rows(i).Cells(0).Value = False

                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Total_DgjobYarn()
        Dim i As Integer
        For i = 0 To Me.Dg_jobYarndet.Rows.Count - 2

        Next
    End Sub

    Private Sub Btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprint.Click
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
        '    obj.Load(Clsconfig.ReportPath & rptFileName)
        '    'Dim obj As New RptJobOrderforYarn
        '    obj.SetDataSource(ds.Tables("TblDatajobyarn"))
        '    frmreport.CrystalReportViewer1.ReportSource = obj
        '    frmreport.ShowDialog()
        'End If

        Dim clsConn As New classConnection
        Dim rptFileName As String = "RptJobOrderforYarn.rpt"
        Dim frm As New frmReport

        If Not Clsconfig.CheckReport(Clsconfig.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(Clsconfig.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.DatabaseName, False)
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
        'Dim boxno As Integer
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

    Private Sub txtjbo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjbo.KeyPress
        If AscW(e.KeyChar) = 13 Then
            Dim GetDatayarn As New GetDataYarn
            Dim tbl_items As New tbl_Items
            Dim ds As New DataSet
            tbl_items.itcd = Me.txtjbo.Text
            ds = GetDatayarn.GetDataItem(tbl_items)
            If ds.Tables(0).Rows.Count > 0 Then
                Me.txtftpm.Text = ds.Tables(0).Rows(0).Item("twists").ToString
                Me.Cbcolor.Text = ds.Tables(0).Rows(0).Item("col").ToString
            End If
        End If
    End Sub

    Private Sub btnFindJob_no_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindJob_no.Click
        Dim selectedJobno As String
        Dim formSearchJobno As New formSearchJob
        selectedJobno = formSearchJob.getJobno
        If selectedJobno <> "" Then
            Me.txtjobno.Text = selectedJobno
        End If
        loadJobData()
    End Sub

    Private Function chkErrbutUse(ByVal strmsg As String) As Boolean
        Try
            ds.Tables("v_dataJoboOrde").Clear()
            chkErrbutUse = True
        Catch ex As Exception
            chkErrbutUse = False
            Exit Function
        End Try
    End Function
    Private Function chkdatajob(ByVal strmsg As String) As Boolean
        Try
            ds.Tables("v_dataJoboOrde").Clear()
            chkdatajob = True
        Catch ex As Exception
            chkdatajob = False
            Exit Function
        End Try
    End Function
    Private Function chkdatajobdet(ByVal strmsg As String) As Boolean
        Dim strtemp As String = ""
        Try
            strtemp = ds.Tables("v_dataJoboOrde").Rows(0).Item("boxno").ToString.Trim
            chkdatajobdet = True
        Catch ex As Exception
            chkdatajobdet = False
            Exit Function
        End Try
    End Function
    Private Function chkErrbutUse2(ByVal strmsg As String) As Boolean
        Dim strtempA As String = ""
        Try
            strtempA = ds.Tables("v_editJoboOrderForYarnEdit").Rows(0).Item("itcd").ToString
            chkErrbutUse2 = True
        Catch ex As Exception
            chkErrbutUse2 = False
            Exit Function
        End Try
    End Function

    Private Sub txtjobno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtjobno.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadJobData()
        End If
    End Sub

    Private Function conversTimeToString(ByVal timea As DateTime) As String
        Dim strdate As String = ""
        Dim strmonth As String = ""
        Dim stryear As String = ""
        Dim arrstr
        Dim arrstrconv

        Try
            arrstr = Split(timea.Date, "#", -1)
            arrstrconv = Split(arrstr(0).ToString.Trim, "/", -1)
            strdate = arrstrconv(0).ToString
            strmonth = arrstrconv(1).ToString
            stryear = arrstrconv(2).ToString
            If strdate <> "" And strmonth <> "" And stryear <> "" Then
                Return stryear & "-" & strmonth & "-" & strdate
            End If
        Catch ex As Exception
            Return "19000101"
        End Try

        Return "19000101"
    End Function

    Private Sub cal()
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
        cn.ConnectionString = connStr.ConnectionString
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

    Private Sub loadJobData()
        Dim dsTable As New DataTable
        Dim dsset As New DataSet
        Dim strsql2 As String
        Dim strmsg As String = ""
        Try
            strsql2 = "select itcd,grade,boxno,spools,kg_gr,kg_nt,lotno_our from v_job_yarn where jobno = '" & Me.txtjobno.Text.Trim & "'"
            Dim da As New SqlDataAdapter(strsql2.ToString, connStr.ConnectionString)
            If chkErrbutUse(strmsg) = True Then
                ds.Tables("v_editJoboOrderForYarnEdit").Clear()
            End If
            da.Fill(ds, "v_editJoboOrderForYarnEdit")
            '==================================================================================
            If strJob_no_search = "" Then
                strJob_no_search = Me.txtjobno.Text.Trim
                numsofrow = ds.Tables("v_editJoboOrderForYarnEdit").Rows.Count
            ElseIf strJob_no_search = Me.txtjobno.Text.Trim And numsofrow = Me.Dg_jobYarndet.RowCount - 2 Then 'ds.Tables("v_editJoboOrderForYarnEdit").Rows.Count Then
                Exit Sub
            ElseIf strJob_no_search <> Me.txtjobno.Text.Trim Then
                strJob_no_search = Me.txtjobno.Text.Trim
                numsofrow = ds.Tables("v_editJoboOrderForYarnEdit").Rows.Count
            ElseIf numsofrow <> ds.Tables("v_editJoboOrderForYarnEdit").Rows.Count Then
                numsofrow = ds.Tables("v_editJoboOrderForYarnEdit").Rows.Count
            End If
            '======================================================================================
            If ds.Tables("v_editJoboOrderForYarnEdit").Rows.Count > 0 Then
                dsTable = ds.Tables("v_editJoboOrderForYarnEdit")
                Me.Dg_jobYarndet.DataSource = dsTable
            Else
                Me.Dg_jobYarndet.DataSource = ""
                MsgBox("data not found kap pom !", MsgBoxStyle.Critical, "กรุณาตรวจสอบหมายเลข joborder")
            End If


            '************************************************************************
            Dim strsql3 As String = ""
            strsql3 = "select * from v_job_yarn where jobno = '" & Me.txtjobno.Text.Trim & "'"
            Dim da1 As New SqlDataAdapter(strsql3.ToString, connStr.ConnectionString)
            If chkdatajob(strmsg) = True Then
                ds.Tables("v_dataJoboOrde").Clear()
            End If
            da1.Fill(ds, "v_dataJoboOrde")
            If ds.Tables("v_dataJoboOrde").Rows.Count > 0 Then
                Me.txtjobdt.Value = ds.Tables("v_dataJoboOrde").Rows(0).Item("jobdt").ToString.Trim
                Me.CbSuppcd.SelectedValue = ds.Tables("v_dataJoboOrde").Rows(0).Item("suppcd").ToString.Trim
                Me.Cbjobtype.SelectedValue = ds.Tables("v_dataJoboOrde").Rows(0).Item("jobtype").ToString.Trim
                Me.textKono.Text = ds.Tables("v_dataJoboOrde").Rows(0).Item("kono").ToString.Trim
                Me.txtjbo.Text = ds.Tables("v_dataJoboOrde").Rows(0).Item("jobitcd").ToString.Trim
                Me.txtfspools.Text = ds.Tables("v_dataJoboOrde").Rows(0).Item("tubeqty").ToString.Trim
                Me.txtftube.Text = ds.Tables("v_dataJoboOrde").Rows(0).Item("tubekg").ToString.Trim
                Me.txtftpm.Text = ds.Tables("v_dataJoboOrde").Rows(0).Item("twists").ToString.Trim
                Me.Cbcolor.SelectedValue = ds.Tables("v_dataJoboOrde").Rows(0).Item("col").ToString.Trim
                Me.textStatus.Text = ds.Tables("v_dataJoboOrde").Rows(0).Item("present_status").ToString.Trim
                'Me.txtremark.Text = ds.Tables("v_dataJoboOrde").Rows(0).Item("remark").ToString.Trim
                If ds.Tables("v_dataJoboOrde").Rows(0).Item("present_status").ToString.Trim = "UN-APP" Then
                    Me.BtnSave.Enabled = True
                Else
                    Me.BtnSave.Enabled = False
                End If

            Else
                MsgBox("data not found kap pom !", MsgBoxStyle.Critical, "กรุณาตรวจสอบหมายเลข joborder")
            End If
            '************************************************************************
            cal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

	Private Sub txtjobno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjobno.TextChanged

	End Sub

	Private Sub txtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStock.TextChanged

	End Sub

    Private Sub btnSearchKI_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchKI.Click
        Dim formSearchKi As New formSearchKO
        Dim selectedKono As String
        selectedKono = formSearchKO.getKono
        If selectedKono <> "" Then
            Me.textKono.Text = selectedKono
        End If

    End Sub

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

    Private Sub getYarnStock()
        Dim msgerr As String = ""
        Dim getDataYarn As New GetDataYarn
        Try
            'dts.Clear()
            dts = getDataYarn.GetYarnInno(Me.txtY_IN.Text, Me.txtStock.Text, 0, msgerr)

            dts.DefaultView.Sort = "itcd asc"
            If Not IsNothing(dts) Then
                Me.DgYarnIn.DataSource = dts
                'Me.Dg_jobYarndet.DataSource = ""
            Else
                Me.DgYarnIn.DataSource = dts
                'Me.Dg_jobYarndet.DataSource = ""
                MsgBox("Can not found")
            End If
            '            compareTwoGrids()

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

                        'dtJob.Rows(i).Delete()

                    Next

                Loop
            End If
        End If
        Dg_jobYarndet.Refresh()
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