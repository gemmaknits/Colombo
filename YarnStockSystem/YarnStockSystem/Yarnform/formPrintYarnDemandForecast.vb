Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class formPrintYarnDemandForecast
    Private clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    'Private Sub setupReport()
    '    Dim i As Integer
    '    Dim j As Integer
    '    If Me.dgselectItem.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
    '    j = 0
    '    Try
    '        For i = 0 To Me.dgselectItem.Rows.Count - 2
    '            If Me.dgselectItem.Rows(i).Cells("colselect").Value = True Then
    '                j = j + 1
    '            End If
    '        Next
    '    Catch ex As Exception

    '    End Try

    '    If j = 0 Then
    '        MsgBox("Please select atleast one item in the list")
    '        Exit Sub
    '    End If
    '    printReport()
    'End Sub

    'Private Sub selectAllItems()
    '    Dim i As Integer
    '    If Me.dgselectItem.Rows.Count = 1 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
    '    Try
    '        For i = 0 To Me.dgselectItem.Rows.Count - 2
    '            If Me.dgselectItem.Rows(i).Cells("colselect").Value = False Then Me.dgselectItem.Rows(i).Cells("colselect").Value = True
    '        Next
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub ShowError(ByVal ex As Exception)
        MessageBox.Show(ex.Source + " : " + ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub ClearAllItems()
        If dgselectItem.Rows.Count = 1 Then Exit Sub

        Dim i As Integer = 0

        Try
            For i = 0 To dgselectItem.Rows.Count - 2
                'If dgselectItem.Rows(i).Cells("colselect").Value = True Then
                Me.dgselectItem.Rows(i).Cells("colselect").Value = False
            Next
        Catch ex As Exception
            Call ShowError(ex)
        End Try
    End Sub

    Private Function GetSelectedItem() As String
        Dim itemsList As String = ""

        For I = 0 To Me.dgselectItem.Rows.Count - 2
            If Me.dgselectItem.Rows(I).Cells("colSelect").Value = True Then
                itemsList = itemsList & Me.dgselectItem.Rows(I).Cells("colitcd").Value.ToString.Trim & ","
            End If
        Next

        If itemsList.Length = 0 Then
            Return itemsList
        Else
            Return Mid(itemsList.ToString, 1, itemsList.Length - 1)
        End If
    End Function

    Private Sub PrintReport()
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = IIf(chkShowPO.Checked, "rptYarnDemand4.rpt", IIf(CheckBox1.Checked, "rptYarnDemandMinus.rpt", "rptYarnDemand.rpt"))
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        clsConfig.ChangeCulture()

        Dim clsConn As New classConnection
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strItemList As String = GetSelectedItem()

        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@itcd_list", strItemList)
        If chkShowPO.Checked Then rpt.SetParameterValue("@show_only_minus", chkShowPO.Checked)
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Yarn Demand Forecast"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BindGrid(Optional ByVal strItemCode As String = "")
        Dim ex As Exception = Nothing
        Dim dt As DataTable = (New classMaster()).GetYarnCode("", ex)

        If Not IsNothing(ex) Then
            Call ShowError(ex)
            Exit Sub
        End If

        If dt.Rows.Count > 0 Then
            dgselectItem.AutoGenerateColumns = False
            dgselectItem.DataSource = dt
        Else
            dgselectItem.DataSource = Nothing
        End If
    End Sub

    Private Sub formPrintYarnDemandForecast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'str.Append("select itcd,ltrim(rtrim((itcd)))+' - '+itdesc as itdesc from items group by itcd,itdesc order by itcd ")
        Call BindGrid()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call BindGrid(TextBox1.Text)
        End If
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        'selectAllItems()
        MessageBox.Show("If you want to show all items," & vbCrLf & "please select nothing (Clear all selected items).", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearAllItems()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Call setupReport()
        Call PrintReport()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class