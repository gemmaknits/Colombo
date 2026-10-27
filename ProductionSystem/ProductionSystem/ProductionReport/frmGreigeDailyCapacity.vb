Public Class frmGreigeDailyCapacity
    Dim clsUser As New classUserInfo
    Dim clsConn As New classConnection

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmGreigeDailyCapacity_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        'dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateFr.Value = Now
        dtpDateTo.Value = Now

        AddSelectAllCheckBox(dgselectItem)

        Call GenCbo()
        Call GenGrid()


    End Sub

    


    Private Sub GenGrid()
        Dim objdb As New classMaster


        dgselectItem.AutoGenerateColumns = False
        dgselectItem.DataSource = objdb.gridMachine(txtFilter.Text.Trim, clsUser.UserID)


    End Sub

    Private Sub GenCbo()
        Dim objdb As New classMaster
        'Dim dt As DataTable = objdb.comboMachine(clsUser.UserID)
        'Me.cbomc.DataSource = objdb.comboMachine(clsUser.UserID)
        'Me.cbomc.DisplayMember = "mcno"
        'Me.cbomc.ValueMember = "mcno"
        'Me.cbomc.SelectedIndex = 0

        Me.cboDesignNo.DataSource = objdb.GetDesign("")
        Me.cboDesignNo.DisplayMember = "design_no"
        Me.cboDesignNo.ValueMember = "design_no"
        Me.cboDesignNo.SelectedIndex = -1

        Me.CboKoNo.DataSource = objdb.comboKO(clsUser.UserID)
        Me.CboKoNo.DisplayMember = "kono"
        Me.CboKoNo.ValueMember = "kono"
        Me.CboKoNo.SelectedIndex = -1

        Me.cboCustomer.DataSource = objdb.GetCustomer
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"

        'Me.cboDesignNo.DataSource = objdb.comboGreigeDesign(clsUser.UserID)
        'Me.cboDesignNo.DisplayMember = "itcd2"
        'Me.cboDesignNo.ValueMember = "itcd"
        'Me.cboDesignNo.SelectedIndex = 0



    End Sub

    Private Sub selectAllItems()
        Dim i As Integer
        If Me.dgselectItem.Rows.Count = 0 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        Try
            For i = 0 To Me.dgselectItem.Rows.Count - 1
                If Me.dgselectItem.Rows(i).Cells("colselect").Value = False Then Me.dgselectItem.Rows(i).Cells("colselect").Value = True
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub clearAllItems()
        Dim i As Integer
        If Me.dgselectItem.Rows.Count = 0 Then Exit Sub 'And Me.DgYarn_in.Rows(1).Cells(1).ToString = ""
        Try
            For i = 0 To Me.dgselectItem.Rows.Count - 1
                If Me.dgselectItem.Rows(i).Cells("colselect").Value = True Then Me.dgselectItem.Rows(i).Cells("colselect").Value = False
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim i As Integer
        Dim j As Integer
        If Me.dgselectItem.Rows.Count = 0 Then Exit Sub
        j = 0
        Try
            For i = 0 To Me.dgselectItem.Rows.Count - 1
                If Me.dgselectItem.Rows(i).Cells("colselect").Value = True Then
                    j = j + 1
                End If
            Next
        Catch ex As Exception

        End Try
        Dim mcnoList As String = String.Empty
        'Dim I As Integer

        'config.ChangeCulture()

        'mcnoList = ""

        For i = 0 To Me.dgselectItem.Rows.Count - 1
            If Me.dgselectItem.Rows(i).Cells("colSelect").Value = True Then
                mcnoList = mcnoList & Me.dgselectItem.Rows(i).Cells("mcno").Value.ToString.Trim & ","
            End If
        Next

        If mcnoList.Length > 1 Then mcnoList = Mid(mcnoList.ToString, 1, mcnoList.Length - 1)



        Dim rptFilename As String = "rptGreigeDailyCapacity.rpt"
        If OptStable.Checked Then
            rptFilename = "rptGreigeDailyCapacity.rpt"
        ElseIf optBeta.Checked Then
            rptFilename = "rptGreigeDailyCapacityBeta.rpt"
        End If
        Dim clsConfig As New clsConfig


        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFilename) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFilename)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@mcno", "")
        rpt.SetParameterValue("@mcnoList", mcnoList)
        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@design_no", cboDesignNo.Text)
        rpt.SetParameterValue("@kono", CboKoNo.Text)
        rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        'rpt.SetParameterValue("@time_type", IIf(OptOnTime.Checked, 2, IIf(OptWaitTime.Checked, 1, 3)))
        'rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))

        frm.Title = "Greige Daily Capacity Report"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSelectAll_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectAll.Click
        selectAllItems()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        clearAllItems()
    End Sub

    Private Sub txtFilter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GenGrid()
        End If
    End Sub

    '==================== Funtion Select ========================================
    Private _IsSelectAllChecked As Boolean

    Private Sub AddSelectAllCheckBox(ByVal theDataGridView As DataGridView)
        Dim cbx As New CheckBox
        cbx.Name = "SelectAll"
        'The box size
        cbx.Size = New Size(14, 14)

        Dim rect As Rectangle
        rect = theDataGridView.GetCellDisplayRectangle(0, -1, True)
        'Put CheckBox in the middle-center of the column header.
        cbx.Location = New System.Drawing.Point(rect.Location.X + ((rect.Width - cbx.Width) / 2), rect.Location.Y + ((rect.Height - cbx.Height) / 2))
        cbx.BackColor = Color.White
        theDataGridView.Controls.Add(cbx)

        'Handle header CheckBox check/uncheck function
        AddHandler cbx.Click, AddressOf HeaderCheckBox_Click
        'When any CheckBox value in the DataGridViewRows changed,
        'check/uncheck the header CheckBox accordingly.

        'AddHandler theDataGridView.CellValueChanged, AddressOf DataGridView_CellChecked

        'This event handler is necessary to commit new CheckBox cell value right after
        'user clicks the CheckBox.
        'Without it, CellValueChanged event occurs until the CheckBox cell lose focus
        'which means the header CheckBox won't display corresponding checked state instantly when user
        'clicks any one of the CheckBoxes.
        'AddHandler theDataGridView.CurrentCellDirtyStateChanged, AddressOf DataGridView_CurrentCellDirtyStateChanged
    End Sub
    Private Sub HeaderCheckBox_Click(ByVal sender As Object, ByVal e As EventArgs)


        Me._IsSelectAllChecked = True

        Dim cbx As CheckBox
        cbx = DirectCast(sender, CheckBox)
        Dim theDataGridView As DataGridView = cbx.Parent

        For Each row As DataGridViewRow In theDataGridView.Rows
            row.Cells(0).Value = cbx.Checked
        Next

        theDataGridView.EndEdit()

        Me._IsSelectAllChecked = False
    End Sub

    Private Sub DataGridView_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim dataGridView As DataGridView = DirectCast(sender, DataGridView)
        If Not Me._IsSelectAllChecked Then
            If dataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                DirectCast(dataGridView.Controls.Item("SelectAll"), CheckBox).Checked = False
            Else
                Dim isAllChecked As Boolean = True
                For Each row As DataGridViewRow In dataGridView.Rows
                    If row.Cells(0).Value = False Then
                        isAllChecked = False

                        Exit For
                    End If
                  
                Next


                DirectCast(dataGridView.Controls.Item("SelectAll"), CheckBox).Checked = isAllChecked
            End If

        End If
    End Sub

    'The CurrentCellDirtyStateChanged event happens after user change the cell value,
    'before the cell lose focus and CellValueChanged event.
    Private Sub DataGridView_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dataGridView As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf dataGridView.CurrentCell Is DataGridViewCheckBoxCell Then
            'When the value changed cell is DataGridViewCheckBoxCell, commit the change
            'to invoke the CellValueChanged event.
            dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    '=========================================================================

End Class