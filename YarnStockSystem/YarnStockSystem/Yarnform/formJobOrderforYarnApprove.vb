Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class formJobOrderforYarnApprove
    Public loginEmpcd
    Private clsConn As New ClassConnection
    'Private connStr As New classConnection
    Dim ds As New DataSet

    Private dts As DataTable
	Private dt As DataTable
	Private Clsconfig As New clsConfig
	Public strJob_no_search As String = ""
	Public numsofrow As Integer
    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub formJobOrderforYarnEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
	Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonApprove.Click
		ApproveJob()
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
        '          Dim frmreport As New FormRptJobOrderforYarn
        '          Dim rptFileName As String = "RptJobOrderforYarn.rpt"
        '          Dim obj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '          obj.Load(clsuser.reportpath & rptFileName)
        '          'Dim obj As New RptJobOrderforYarn
        '	obj.SetDataSource(ds.Tables("TblDatajobyarn"))
        '	frmreport.CrystalReportViewer1.ReportSource = obj
        '	frmreport.ShowDialog()
        'End If

        Dim rptFileName As String = "RptJobOrderforYarn.rpt"
        Dim frm As New frmReport

        If Not Clsconfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.Database, False)
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

	Private Sub btnFindJob_no_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindJob_no.Click
		Dim dsTable As New DataTable
		Dim dsset As New DataSet
		Dim strsql2 As String
		Dim strmsg As String = ""
		Try
			strsql2 = "select itcd,grade,boxno,spools,kg_gr,kg_nt,lotno_our from v_job_yarn where jobno = '" & Me.txtjobno.Text.Trim & "'"
            Dim da As New SqlDataAdapter(strsql2.ToString, clsConn.Connection)
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
            Dim da1 As New SqlDataAdapter(strsql3.ToString, clsConn.Connection)
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
                'Me.txtremark.Text = ds.Tables("v_dataJoboOrde").Rows(0).Item("remark").ToString.Trim

            Else
                MsgBox("data not found kap pom !", MsgBoxStyle.Critical, "กรุณาตรวจสอบหมายเลข joborder")
            End If
            '************************************************************************
            cal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            Dim dsTable As New DataTable
            Dim dsset As New DataSet
            Dim strsql2 As String
            Dim strmsg As String = ""
            Try
                strsql2 = "select itcd,grade,boxno,spools,kg_gr,kg_nt,lotno_our from v_job_yarn where jobno = '" & Me.txtjobno.Text.Trim & "'"
                Dim da As New SqlDataAdapter(strsql2.ToString, clsConn.Connection)
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
                Dim da1 As New SqlDataAdapter(strsql3.ToString, clsConn.Connection)
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

                    'Me.txtremark.Text = ds.Tables("v_dataJoboOrde").Rows(0).Item("remark").ToString.Trim

                Else
                    MsgBox("data not found kap pom !", MsgBoxStyle.Critical, "กรุณาตรวจสอบหมายเลข joborder")
                End If
                '************************************************************************
                cal()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

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
        cn.ConnectionString = clsConn.Connection
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

    Private Sub ApproveJob()
        Dim cmdApproveJob As New SqlCommand
        Dim connClass As New classConnection
        Dim cn As New SqlConnection
        Dim tran As SqlTransaction
        Dim response As Integer
        cn.ConnectionString = connClass.Connection
        cn.Open()
        tran = cn.BeginTransaction

        response = MsgBox("Are you sure to approve this job?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Job")
        If response = MsgBoxResult.Yes Then
            cmdApproveJob.CommandType = CommandType.StoredProcedure
            cmdApproveJob.CommandText = "p_job_approve"
            cmdApproveJob.Parameters.AddWithValue("@jobno", Me.txtjobno.Text.Trim)
            cmdApproveJob.Parameters.AddWithValue("@rem_app", Me.textRemApprove.Text.Trim)
            cmdApproveJob.Parameters.AddWithValue("@log_empcd", loginEmpcd)

            cmdApproveJob.Connection = cn
            cmdApproveJob.Transaction = tran

            Try
                cmdApproveJob.ExecuteNonQuery()
                tran.Commit()
                MsgBox("Job order approved succesfully")
            Catch ex As Exception
                tran.Rollback()
                MsgBox(ex)
            Finally
                cn.Close()
            End Try
        End If
    End Sub

	Private Sub txtjbo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjbo.TextChanged

	End Sub

    Private Sub btnSelectAll_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectAll.Click
        Dim i As Integer = 0
        If Dg_jobYarndet.Rows.Count = 0 Then Exit Sub
        Try
            For i = 0 To Dg_jobYarndet.Rows.Count - 2
                If Dg_jobYarndet.Rows(i).Cells("DGV_select").Value = False Then Dg_jobYarndet.Rows(i).Cells("DGV_select").Value = True
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Dim i As Integer = 0
        If Dg_jobYarndet.Rows.Count = 0 Then Exit Sub
        Try
            For i = 0 To Dg_jobYarndet.Rows.Count - 2
                If Dg_jobYarndet.Rows(i).Cells("DGV_select").Value = True Then Dg_jobYarndet.Rows(i).Cells("DGV_select").Value = False
            Next

        Catch ex As Exception

        End Try
    End Sub
End Class