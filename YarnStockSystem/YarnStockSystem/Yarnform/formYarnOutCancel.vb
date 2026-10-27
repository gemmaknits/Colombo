Imports System.Data
Imports System.Data.SqlClient
Imports System.Text


Public Class formYarnOutCancel
    Private Clsconfig As New clsConfig
    Private dsYarn_in_det As New DataTable
    Private da As New SqlDataAdapter
    Private ds As New DataSet
    Private connStr As New classConnection
    Private dt As New DataTable
    Private dtJob As New DataTable
    Private oldRefDocno As String
    Private clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub formYarnOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DgYarnOut.AutoGenerateColumns = False
        insertcombotrantype()
        insertcomboitemcode()
    End Sub

    Private Sub insertcombotrantype()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim dt As New DataTable
        dt = getDatayarn.GetDataTrantype()
        If Not IsNothing(dt) Then
            Me.CbTrantype.DataSource = dt
            Me.CbTrantype.DisplayMember = "tran_desc"
            Me.CbTrantype.ValueMember = "tran_type"
        End If
    End Sub

    Private Sub insertcomboitemcode()
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        tblItems.itcd = ""
        ds = getDatayarn.GetDataItem(tblItems)
        If Not IsNothing(ds) Then
            Me.DgCombobox.DataSource = ds.Tables(0)
            Me.DgCombobox.DisplayMember = "itdesc"
            Me.DgCombobox.ValueMember = "Itcd"

        End If
    End Sub


    Private Sub totalsum()
        Dim sumgross As Double
        Dim sumnet As Double
        Dim i As Integer
        Try
            Dim countGrid As Integer
            countGrid = Me.DgYarnOut.Rows.Count
            For i = 0 To Me.DgYarnOut.Rows.Count - 2
                Dim kg_gr As Double
                Dim kg_nt As Double

                If IsDBNull(Me.DgYarnOut.Rows(i).Cells("kg_gr").Value) Then
                    kg_gr = 0
                Else
                    kg_gr = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("kg_gr").Value)
                End If

                If IsDBNull(Me.DgYarnOut.Rows(i).Cells("kg_nt").Value) Then
                    kg_nt = 0
                Else
                    kg_nt = Clsconfig.IsValidDouble(Me.DgYarnOut.Rows(i).Cells("kg_nt").Value)
                End If

                sumgross = sumgross + kg_gr
                sumnet = sumnet + kg_nt
            Next
            Me.txttotalgross.Text = sumgross
            Me.txttotalnet.Text = sumnet
            txttotalboxes.Text = Me.DgYarnOut.RowCount - 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Call CancelYarnOut()
    End Sub


    Private Sub txtYOUT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYOUT.KeyPress
        If AscW(e.KeyChar) = 13 Then
            If txtYOUT.Text.Trim.Length > 8 Then loadDataYarnOut()
        End If
    End Sub

    Private Sub loadDataYarnOut()
        Dim Getdatayarnout As New GetDataYarn
        Dim msgerr As String = ""
        Dim dtt As New DataTable
        dtt = Getdatayarnout.GetData_YarnOut(Me.txtYOUT.Text.Trim, da, msgerr)
        dt.Dispose()
        dt = New DataTable
        dt = Getdatayarnout.GetData_YarnOutdet(Me.txtYOUT.Text, da, msgerr)
        Me.DgYarnOut.DataSource = dt
        If dt.Rows.Count > 0 Then
            Me.textYoutDate.Text = dtt.Rows(0).Item("outdt").ToString

            txtsupplier.Text = Getdatayarnout.GetData_NameSuppliers(dtt.Rows(0).Item("suppcd").ToString, msgerr)
            CbTrantype.SelectedValue = dtt.Rows(0).Item("tran_type").ToString
            Me.textStatus.Text = dtt.Rows(0).Item("present_status").ToString
            totalsum()
        End If

    End Sub

    Private Sub btnSearchYout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchYout.Click
        Dim selectedYarnOut As String
        Dim formSearchyarnOut As New formSearchYarnOut
        selectedYarnOut = formSearchyarnOut.getYarnOutno
        If selectedYarnOut <> "" Then
            Me.txtYOUT.Text = selectedYarnOut
        End If
        loadDataYarnOut()
    End Sub

    Private Sub CancelYarnOut()
        Dim cmdCancelJob As New SqlCommand
        Dim connClass As New classConnection
        Dim cn As New SqlConnection
        Dim tran As SqlTransaction
        Dim response As Integer
        cn.ConnectionString = connClass.Connection
        cn.Open()
        tran = cn.BeginTransaction

        response = MsgBox("Are you sure to Cancel this yarn out document?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Delete Job")
        If response = MsgBoxResult.Yes Then
            cmdCancelJob.CommandType = CommandType.StoredProcedure
            cmdCancelJob.CommandText = "p_yarn_out_Cancel"
            cmdCancelJob.Parameters.AddWithValue("@outno", Me.txtYOUT.Text.Trim)
            cmdCancelJob.Parameters.AddWithValue("@log_empcd", clsUser.UserID)

            cmdCancelJob.Connection = cn
            cmdCancelJob.Transaction = tran

            Try
                cmdCancelJob.ExecuteNonQuery()
                tran.Commit()
                loadDataYarnOut()
                MsgBox("Yarn out Cancelled succesfully")
            Catch ex As Exception
                tran.Rollback()
                MsgBox(ex.Message.ToString)
            Finally
                cn.Close()
            End Try
        End If
    End Sub

    Private Sub btnPrintYarnout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintYarnout.Click
        Dim clsYarnOutBarCode As New classYarnOutBarcode
        Dim rptFileName As String
        rptFileName = "RptYarnOut.rpt"

        Dim dt As DataTable = clsYarnOutBarCode.GetYOutByJob(strJobNo:="", strOutno:=txtYOUT.Text.Trim, strlogempcd:=clsUser.UserID)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("tran_type").ToString.Trim = "WARPING" Then
                rptFileName = "RptYarnOut.rpt"
            ElseIf dt.Rows(0)("tran_type").ToString.Trim = "KNITTING" Then
                rptFileName = "RptYarnOutKnitting.rpt"
            Else
                rptFileName = "RptYarnOut.rpt"
            End If
        End If

        Dim clsConn As New classConnection
        'Dim rptFileName As String = "RptYarnOut.rpt"
        Dim frm As New frmReport

        If Not Clsconfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@outno", txtYOUT.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn OUT"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class