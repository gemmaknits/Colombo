Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class frmYarnDemandHistory

    Dim clsUser As New classUserInfo
    Dim dbStockG As New classStockG

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private connStr As New classConnection
    Dim ds As New DataSet
    Private dts As DataTable
    Private dt As DataTable
    Private Clsconfig As New clsConfig
    Private Sub frmYarnDemandHistory_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim str As New StringBuilder
        Try
            str.Append("select itcd,ltrim(rtrim((itcd)))+' - '+itdesc as itdesc from items  where itnaturecd='YARNS' group by itcd,itdesc order by itcd ")
            Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
            da.Fill(ds, "v_yarn_in_out_by_box")

            'Me.dgselectItem.DataSource = Nothing

            If ds.Tables("v_yarn_in_out_by_box").Rows.Count > 0 Then
                Me.dgselectItem.DataSource = Nothing
                dts = ds.Tables("v_yarn_in_out_by_box")
                Me.dgselectItem.AutoGenerateColumns = False
                Me.dgselectItem.DataSource = ds.Tables("v_yarn_in_out_by_box") 'dts
            Else
                'Me.dgselectItem.DataSource = ""
            End If
            'selectAllItems()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dtpDateFr.Value = Now 'DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
    End Sub

    Private Sub txtlookup_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtlookup.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim str As New StringBuilder
            Try
                ds.Clear()
                str.Append("select itcd,ltrim(rtrim((itcd)))+' - '+itdesc as itdesc from items where '" & txtlookup.Text.Trim & "' = '' and itnaturecd='YARNS' or " & "  itcd like '%" & txtlookup.Text.Trim & "%' or itdesc LIKE '%" & Me.txtlookup.Text.Trim & "%' and itnaturecd='YARNS' group by itcd,itdesc order by itcd")   'where itnaturecd='YARNS' group by itcd,itdesc order by itcd ")
                Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
                da.Fill(ds, "v_yarn_in_out_by_box")

                'Me.dgselectItem.DataSource = Nothing

                If ds.Tables("v_yarn_in_out_by_box").Rows.Count > 0 Then
                    dts = ds.Tables("v_yarn_in_out_by_box")
                    'Me.dgselectItem.DataSource = Nothing
                    Me.dgselectItem.AutoGenerateColumns = False
                    Me.dgselectItem.DataSource = ds.Tables("v_yarn_in_out_by_box") 'dts
                Else
                    'Me.dgselectItem.DataSource = ""
                End If
                'selectAllItems()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub


    Private Sub txtlookup_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtlookup.TextChanged

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim i As Integer
        Dim j As Integer
        If Me.dgselectItem.Rows.Count = 1 Then Exit Sub
        j = 0
        Try
            For i = 0 To Me.dgselectItem.Rows.Count - 1
                If Me.dgselectItem.Rows(i).Cells("colselect").Value = True Then
                    j = j + 1
                End If
            Next
        Catch ex As Exception

        End Try

        Dim config As New clsConfig
        Dim clsConn As New classConnection
        Dim itemsList As String

        config.ChangeCulture()

        itemsList = ""

        For i = 0 To Me.dgselectItem.Rows.Count - 1
            If Me.dgselectItem.Rows(i).Cells("colSelect").Value = True Then
                itemsList = itemsList & Me.dgselectItem.Rows(i).Cells("itcd").Value.ToString.Trim & ","
            End If
        Next

        Const rptFileName = "rptYarnDemandHistory.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not Clsconfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        'rpt.VerifyDatabase()
        rpt.SetParameterValue("@itcd_list", Clsconfig.IsNull(itemsList, ""))
        rpt.SetParameterValue("@datefr", dtpDateFr.Value)
        rpt.SetParameterValue("@dateto", dtpDateTo.Value)

        rpt.DataDefinition.ParameterFields("@itcd_list", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@itcd_list").CurrentValues)
        rpt.DataDefinition.ParameterFields("@datefr", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@datefr").CurrentValues)
        rpt.DataDefinition.ParameterFields("@dateto", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dateto").CurrentValues)

        frm.Title = "Yarn Demand History"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub selectAllItems()
        Dim i As Integer
        If Me.dgselectItem.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        Try
            For i = 0 To Me.dgselectItem.Rows.Count - 1
                If Me.dgselectItem.Rows(i).Cells("colselect").Value = False Then Me.dgselectItem.Rows(i).Cells("colselect").Value = True
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clearAllItems()
        Dim i As Integer
        If Me.dgselectItem.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        Try
            For i = 0 To Me.dgselectItem.Rows.Count - 1
                If Me.dgselectItem.Rows(i).Cells("colselect").Value = True Then Me.dgselectItem.Rows(i).Cells("colselect").Value = False
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSelectAll_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectAll.Click
        Call selectAllItems()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        Call clearAllItems()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class