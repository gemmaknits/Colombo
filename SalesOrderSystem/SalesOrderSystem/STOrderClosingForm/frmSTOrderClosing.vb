Imports System.Data.SqlClient

Public Class frmSTOrderClosing
    'Modify By      : Sitthana Boonlom
    'Date Modify    : 18/10/2022

#Region "Properties"
    Public SqlConn As New SqlConnection
    Public UserInfo As New classUserInfo

    Public Sub setConnectionString(Optional ByVal cn As SqlConnection = Nothing)
        If cn Is Nothing Then
            Dim clsConn As New ClassConnection
            Me.SqlConn = clsConn.getSQLConnection
        Else
            Me.SqlConn = cn
        End If
    End Sub
#End Region

    Private clsValidation As New clsConfig
    Private clsSTOrderClosingBLL As New classSTOrderClosingBLL

    Public dtSTOrderClosing As DataTable
    Public bsSTOrderClosing As BindingSource
    Private Initializing As Boolean = True

    Private BalLessThanZero As New DataGridViewCellStyle
    Private BalOk As New DataGridViewCellStyle

    Private Sub frmSTOrderClosing_Load(sender As Object, e As EventArgs) Handles Me.Load
        If String.IsNullOrWhiteSpace(SqlConn.ConnectionString) Then
            SqlConn = (New classConnection).getSQLConnection()
        End If

        tsslDataBaseName.Text = "Database Name: " & SqlConn.Database
        intProperties()
        initCombo()
        LoadSTOrderClosing()
    End Sub

    Private Sub intProperties()
        With BalLessThanZero
            .BackColor = Color.Red
            .SelectionBackColor = Color.Red
        End With

        With BalOk
            .BackColor = Color.Transparent
            .SelectionBackColor = Color.Transparent
        End With
    End Sub
    Private Sub initCombo()
        'The legacy combo opens and closes the connection passed to it. After the
        'first open, SqlConnection hides the password from ConnectionString, so
        'later BLL calls cannot safely clone that same connection.
        Using comboConnection As New SqlConnection(SqlConn.ConnectionString)
            ComboSalesPerson1.populateData(comboConnection)
        End Using
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        LoadSTOrderClosing()
    End Sub

    Private Sub LoadSTOrderClosing()
        Dim designno As String = txtArticle.Text
        ' If designno.ToString().Trim() <> "" Then
        Dim closingorder As String = String.Empty
        Dim salesPersonCode As String

        If chkOpen.Checked Then
            closingorder = "OPEN"
        ElseIf chkClose.Checked Then
            closingorder = "CLOSED"
        End If
        If chkClose.Checked Then
            closingorder = "CLOSED"
        ElseIf chkAll.Checked Then
            closingorder = "ALL"
        End If

        If ComboSalesPerson1.SelectedValue Is Nothing OrElse IsDBNull(ComboSalesPerson1.SelectedValue) Then
            salesPersonCode = ""
        Else
            salesPersonCode = ComboSalesPerson1.SelectedValue.ToString()
        End If
        dtSTOrderClosing = clsSTOrderClosingBLL.Load_STOrderClosing(designno, txtCustmer.Text, txtSTNO.Text _
                                                                  , closingorder, salesPersonCode, SqlConn
                                                                    )
        bsSTOrderClosing = New BindingSource()
        dgvSTClose.AutoGenerateColumns = False
        bsSTOrderClosing.DataSource = dtSTOrderClosing
        dgvSTClose.DataSource = bsSTOrderClosing
        dgvSTClose.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvSTClose.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvSTClose.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvSTClose.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv_STClose.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv_STClose.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv_STClose.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv_STClose.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv_STClose.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgv_STClose.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        initdgvSTCloseCellFormat() 'Sitthana 20230328

        If dtSTOrderClosing.Rows.Count > 0 Then


            Dim sono As String = dtSTOrderClosing.Rows(0).Item("sono")
            Dim dt_knitting As DataTable
            dt_knitting = clsSTOrderClosingBLL.Load_Knitting(sono, SqlConn)
            dgvKnitting.AutoGenerateColumns = False
            dgvKnitting.DataSource = dt_knitting

            dgvKnitting.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvKnitting.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvKnitting.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvKnitting.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Dim solineid As String = dtSTOrderClosing.Rows(0).Item("so_line_id")
            Dim dt_SOApplied As DataTable
            dt_SOApplied = clsSTOrderClosingBLL.Load_SOApplied(solineid, SqlConn)
            dgvSOApplied.AutoGenerateColumns = False
            dgvSOApplied.DataSource = dt_SOApplied

            Dim dt_GREIGE As DataTable
            dt_GREIGE = clsSTOrderClosingBLL.Load_GREIGE_OH(sono, SqlConn)
            dgvGreige.AutoGenerateColumns = False
            dgvGreige.DataSource = dt_GREIGE
        Else
            Dim sono As String = ""
            Dim dt_knitting As DataTable
            dt_knitting = clsSTOrderClosingBLL.Load_Knitting(sono, SqlConn)
            dgvKnitting.AutoGenerateColumns = False
            dgvKnitting.DataSource = dt_knitting

            dgvKnitting.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvKnitting.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvKnitting.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvKnitting.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            Dim solineid As String = ""
            Dim dt_SOApplied As DataTable
            dt_SOApplied = clsSTOrderClosingBLL.Load_SOApplied(solineid, SqlConn)
            dgvSOApplied.AutoGenerateColumns = False
            dgvSOApplied.DataSource = dt_SOApplied

            Dim dt_GREIGE As DataTable
            dt_GREIGE = clsSTOrderClosingBLL.Load_GREIGE_OH(sono, SqlConn)
            dgvGreige.AutoGenerateColumns = False
            dgvGreige.DataSource = dt_GREIGE
        End If
        ' End If
    End Sub

    Private Sub initdgvSTCloseCellFormat()
        With dgvSTClose
            For i As Integer = 0 To .Rows.Count - 1
                If clsValidation.IsNull(dgvSTClose.Rows(i).Cells("KI_BAL").Value, "").ToString.Trim = "" Then
                    .Item("KI_BAL", i).Style = BalOk
                Else
                    If clsValidation.IsNull(dgvSTClose.Rows(i).Cells("KI_BAL").Value, 0) < 0 Then
                        .Item("KI_BAL", i).Style = BalLessThanZero
                    Else
                        .Item("KI_BAL", i).Style = BalOk
                    End If
                End If

                If clsValidation.IsNull(.Rows(i).Cells("st_bal_kg").Value, "").ToString.Trim = "" Then
                    .Item("st_bal_kg", i).Style = BalOk
                Else
                    If clsValidation.IsNull(dgvSTClose.Rows(i).Cells("st_bal_kg").Value, 0) < 0 Then
                        .Item("st_bal_kg", i).Style = BalLessThanZero
                    Else
                        .Item("st_bal_kg", i).Style = BalOk
                    End If
                End If
            Next
        End With
    End Sub

    Private Sub chkOpen_CheckedChanged(sender As Object, e As EventArgs) Handles chkOpen.Click
        chkOpen.Checked = True
        chkClose.Checked = False
        chkAll.Checked = False
    End Sub

    Private Sub chkClose_CheckedChanged(sender As Object, e As EventArgs) Handles chkClose.Click
        chkClose.Checked = True
        chkOpen.Checked = False
        chkAll.Checked = False
    End Sub

    Private Sub chkAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAll.Click
        chkAll.Checked = True
        chkClose.Checked = False
        chkOpen.Checked = False
    End Sub
    Public Sub New()
        InitializeComponent()
        Initializing = False
    End Sub
    Private Sub dgv_STClose_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSTClose.CellClick
        Try
            If Initializing Then Return
            If e.RowIndex = -1 Then Exit Sub
            ' If e.ColumnIndex = 11 Then
            ' MessageBox.Show(e.RowIndex)
            ' MessageBox.Show(dt_STOrderClosing.Rows.Count)
            If (e.RowIndex = dtSTOrderClosing.Rows.Count) Then
                Dim drv As DataRowView
                drv = bsSTOrderClosing.Current
                ' Dim sono As String = drv.Item("sono")
                Dim dt_knitting As DataTable
                dt_knitting = clsSTOrderClosingBLL.Load_Knitting("", SqlConn)
                dgvKnitting.AutoGenerateColumns = False
                dgvKnitting.DataSource = dt_knitting

                dgvKnitting.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvKnitting.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvKnitting.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvKnitting.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                'Dim solineid As String = drv.Item("so_line_id")
                Dim dt_SOApplied As DataTable
                dt_SOApplied = clsSTOrderClosingBLL.Load_SOApplied("", SqlConn)
                dgvSOApplied.AutoGenerateColumns = False
                dgvSOApplied.DataSource = dt_SOApplied

                Dim dt_GREIGE As DataTable
                dt_GREIGE = clsSTOrderClosingBLL.Load_GREIGE_OH("", SqlConn)
                dgvGreige.AutoGenerateColumns = False
                dgvGreige.DataSource = dt_GREIGE
            Else

                Dim drv As DataRowView
                drv = bsSTOrderClosing.Current
                Dim sono As String = drv.Item("sono")
                Dim dt_knitting As DataTable
                dt_knitting = clsSTOrderClosingBLL.Load_Knitting(sono, SqlConn)
                dgvKnitting.AutoGenerateColumns = False
                dgvKnitting.DataSource = dt_knitting

                dgvKnitting.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvKnitting.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvKnitting.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                dgvKnitting.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                Dim solineid As String = drv.Item("so_line_id")
                Dim dt_SOApplied As DataTable
                dt_SOApplied = clsSTOrderClosingBLL.Load_SOApplied(solineid, SqlConn)
                dgvSOApplied.AutoGenerateColumns = False
                dgvSOApplied.DataSource = dt_SOApplied

                Dim dt_GREIGE As DataTable
                dt_GREIGE = clsSTOrderClosingBLL.Load_GREIGE_OH(sono, SqlConn)
                dgvGreige.AutoGenerateColumns = False
                dgvGreige.DataSource = dt_GREIGE
            End If
            '
            ' MessageBox.Show("Selected Values  " & sono)
            'End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub dgv_STClose_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSTClose.KeyDown
        LoadKnitting_Greige()
    End Sub
    Private Sub dgv_STClose_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvSTClose.KeyUp
        LoadKnitting_Greige()
    End Sub
    Private Sub LoadKnitting_Greige()
        Try
            If Initializing Then Return
            ' If e.ColumnIndex = 11 Then
            Dim drv As DataRowView
            drv = bsSTOrderClosing.Current
            Dim sono As String = drv.Item("sono")
            Dim dt_knitting As DataTable
            dt_knitting = clsSTOrderClosingBLL.Load_Knitting(sono, SqlConn)
            dgvKnitting.AutoGenerateColumns = False
            dgvKnitting.DataSource = dt_knitting

            dgvKnitting.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvKnitting.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvKnitting.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvKnitting.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


            Dim dt_GREIGE As DataTable
            dt_GREIGE = clsSTOrderClosingBLL.Load_GREIGE_OH(sono, SqlConn)
            dgvGreige.AutoGenerateColumns = False
            dgvGreige.DataSource = dt_GREIGE


            Dim solineid As String = drv.Item("so_line_id")
            Dim dt_SOApplied As DataTable
            dt_SOApplied = clsSTOrderClosingBLL.Load_SOApplied(solineid, SqlConn)
            dgvSOApplied.AutoGenerateColumns = False
            dgvSOApplied.DataSource = dt_SOApplied
            '
            ' MessageBox.Show("Selected Values  " & sono)
            'End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub dgv_dgv_STClose_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgvSTClose.DataError
        If StrComp(e.Exception.Message, "Input string was not in a correct format.") = 0 Then
            MessageBox.Show("Please Enter a numeric Value")
            'This will change the number back to original
            dgvSTClose.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = " "

            MessageBox.Show("Error happened " _
                    & e.Context.ToString())
            If (e.Context = DataGridViewDataErrorContexts.Commit) _
                Then
                MessageBox.Show("Commit error")
            End If
            If (e.Context = DataGridViewDataErrorContexts _
                .CurrentCellChange) Then
                MessageBox.Show("Cell change")
            End If
            If (e.Context = DataGridViewDataErrorContexts.Parsing) _
                Then
                MessageBox.Show("parsing error")
            End If
            If (e.Context =
                DataGridViewDataErrorContexts.LeaveControl) Then
                MessageBox.Show("leave control error")
            End If

            If (TypeOf (e.Exception) Is ConstraintException) Then
                Dim view As DataGridView = CType(sender, DataGridView)
                view.Rows(e.RowIndex).ErrorText = "an error"
                view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                    .ErrorText = "an error"
                e.ThrowException = False
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim obj_STClosingSave As New classSTOrderClosingBLL
        Dim result As STOrderClosingSaveResult
        Try
            ' Cursor = Cursors.WaitCursor
            If bsSTOrderClosing IsNot Nothing Then
                bsSTOrderClosing.EndEdit()
                dgvSTClose.EndEdit()
                Dim changedrecords As DataTable = dtSTOrderClosing.GetChanges()
                ' Dim addedrecords As DataTable = dt_STOrderClosing.GetChanges(DataRowState.Added)
                If changedrecords IsNot Nothing Then
                    If changedrecords.Rows.Count > 0 Then
                        result = obj_STClosingSave.saveDBX(changedrecords, SqlConn)
                    Else
                        ToolStripProgressBar1.Visible = True
                        ToolStripStatusLabel1.Visible = True
                        ToolStripStatusLabel1.Text = "No Modified records"
                        Exit Sub
                    End If
                Else
                    ToolStripStatusLabel1.Visible = True
                    ToolStripStatusLabel1.Text = "No Modified records"
                    Exit Sub
                    'Else
                    '    ToolStripProgressBar1.Visible = True
                    '    ToolStripStatusLabel1.Visible = True
                    '    ToolStripStatusLabel1.Text = "No Modified records"
                    '    'Exit Sub
                End If
                ' Cursor = Cursors.Default

                If result.Success = False Then
                    MsgBox("Operation failed due to following error:" + Chr(13) + result.Message)
                Else
                    ToolStripProgressBar1.Visible = True
                    ToolStripStatusLabel1.Visible = True
                    ToolStripStatusLabel1.Text = "Saved Succesfully"
                    Cursor = Cursors.Default
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        ' Cursor = Cursors.Default
    End Sub

    Private Sub txtDesignNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtArticle.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cursor = Cursors.WaitCursor
            LoadSTOrderClosing()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub txtCustmer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustmer.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cursor = Cursors.WaitCursor
            LoadSTOrderClosing()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub txtSTNO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSTNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cursor = Cursors.WaitCursor
            LoadSTOrderClosing()
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    'Print
    Private Sub tsmnKnittingOrder_Click(sender As Object, e As EventArgs) Handles tsmnKnittingOrder.Click
        'Sitthana 20210526
        If dgvSTClose.Rows.Count > 0 Then
            printReport("rptKOForST.rpt", "KO By ST", "")
        End If
    End Sub
    Private Sub tsmnSOAppliedBySTNo_Click(sender As Object, e As EventArgs) Handles tsmnSOAppliedBySTNo.Click
        If dgvSTClose.Rows.Count > 0 Then
            printReport("rptSOForST.rpt", "SO Applied", "STNO")
        End If
    End Sub

    Private Sub tsmnSOAppliedByDesignNo_Click(sender As Object, e As EventArgs) Handles tsmnSOAppliedByDesignNo.Click
        If dgvSTClose.Rows.Count > 0 Then
            printReport("rptSOForST.rpt", "SO Applied", "DESIGN")
        End If
    End Sub
    Private Sub tsmnSOAppliedBySales_Click(sender As Object, e As EventArgs) Handles tsmnSOAppliedBySales.Click
        If dgvSTClose.Rows.Count > 0 Then
            printReport("rptSOForST.rpt", "SO Applied", "SALES")
        End If
    End Sub
    Private Sub printReport(pReportName As String, pTitle As String, pFilterBy As String)
        'Writen By : Sitthana 202105026

        If IsNothing(bsSTOrderClosing) Then
            MessageBox.Show("You must Click Find First", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim clsuser As classUserInfo = Me.UserInfo
        'Dim clsConnection As New ClassConnection
        Dim clsConfig As New clsConfig

        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If String.IsNullOrWhiteSpace(clsuser.ReportPath) Then
            MessageBox.Show("Report path is not configured.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not clsuser.ReportPath.EndsWith("\") Then clsuser.ReportPath &= "\"

        If Not clsConfig.CheckReport(clsuser.ReportPath, pReportName) Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        ''Set rpt
        'With rpt
        '    rpt.Load(clsuser.ReportPath & pReportName)
        '    .DataSourceConnections.Item(0).SetConnection(clsConnection.servername, clsConnection.database, False)
        '    .DataSourceConnections.Item(0).SetLogon(clsConnection.Userid, clsConnection.Password)
        '    .VerifyDatabase()

        '    'Sent Report Parameter Value
        '    Dim drv As DataRowView
        '    drv = bsSTOrderClosing.Current
        '    Dim sono As String = drv.Item("sono")
        '    Dim solineid As String = drv.Item("so_line_id")
        '    If pReportName = "rptKOForST.rpt" Then
        '        .SetParameterValue("@p_sono", sono) 'drv.Item("sono")) 'dgvSTClose.Rows(dgvSTClose.CurrentRow.Index).Cells("sono").Value.ToString.Trim)

        '    ElseIf pReportName = "rptSOForST.rpt" Then
        '        'Dim drv As DataRowView
        '        ' drv = bsSTOrderClosing.Current
        '        '.SetParameterValue("@p_design_no", dgvSTClose.Rows(dgvSTClose.CurrentRow.Index).Cells("DESIGN_NO").Value)
        '        '.SetParameterValue("@p_ref_so_line_id", dgvSTClose.Rows(dgvSTClose.CurrentRow.Index).Cells("so_line_id").Value)
        '        .SetParameterValue("@p_so_line_id", solineid) 'drv.Item("so_line_id")) 'dgvSTClose.Rows(dgvSTClose.CurrentRow.Index).Cells("so_line_id").Value)
        '    End If
        'End With

        ''Set Form
        'With frm
        '    .Title = pTitle
        '    .MdiParent = Me.ParentForm
        '    .CRViewer.ReportSource = rpt
        '    .Show()
        'End With


        Dim drv As DataRowView
        drv = bsSTOrderClosing.Current
        Dim nsono As String = drv.Item("sono")
        Dim nsolineid As String = drv.Item("so_line_id")

        rpt.Load(clsuser.ReportPath & pReportName)
        Dim connectionInfo As New SqlConnectionStringBuilder(SqlConn.ConnectionString)
        rpt.DataSourceConnections.Item(0).SetConnection(connectionInfo.DataSource, connectionInfo.InitialCatalog, False)
        rpt.DataSourceConnections.Item(0).SetLogon(connectionInfo.UserID, connectionInfo.Password)
        rpt.VerifyDatabase()

        If pReportName = "rptKOForST.rpt" Then
            rpt.SetParameterValue("@p_sono", nsono)
        Else
            Select Case pFilterBy.ToUpper.Trim
                Case "STNO"
                    rpt.SetParameterValue("@p_so_line_id", nsolineid)
                    rpt.SetParameterValue("@p_design_no", "")
                    'rpt.SetParameterValue("@p_sales_person_code", "")
                Case "DESIGN"
                    rpt.SetParameterValue("@p_so_line_id", 0)
                    rpt.SetParameterValue("@p_design_no", txtArticle.Text.Trim)
                    'rpt.SetParameterValue("@p_sales_person_code", "")
                Case "SALES"
                    rpt.SetParameterValue("@p_so_line_id", 0)
                    rpt.SetParameterValue("@p_design_no", "")
                    'rpt.SetParameterValue("@p_sales_person_code", ComboSalesPerson1.SelectedValue)
                Case Else
                    rpt.SetParameterValue("@p_so_line_id", nsolineid)
                    rpt.SetParameterValue("@p_design_no", txtArticle.Text.Trim)
                    'rpt.SetParameterValue("@p_sales_person_code", ComboSalesPerson1.SelectedValue)
            End Select
            If pFilterBy.ToUpper = "DESIGN" Then
            Else
            End If 'Sitthana add pFilterBy 20210827
            If chkClose.Checked Then
                rpt.SetParameterValue("@p_Order_Status", "CLOSED")
            ElseIf chkOpen.Checked Then
                rpt.SetParameterValue("@p_Order_Status", "OPEN")
            Else
                rpt.SetParameterValue("@p_Order_Status", "ALL")
            End If
        End If

        frm.Title = pTitle
        frm.CRViewer.ReportSource = rpt
        'frm.MdiParent = Me.ParentForm
        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub

End Class
