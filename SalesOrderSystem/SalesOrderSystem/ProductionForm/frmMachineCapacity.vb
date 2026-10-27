Public Class frmMachineCapacity
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub GenCombo()
        Dim objDB As New classMaster

        ddlMachineDesign.ComboBox.DataSource = objDB.comboMachineDesign(clsUser.UserID)
        ddlMachineDesign.ComboBox.DisplayMember = "mcno_design"
        ddlMachineDesign.ComboBox.ValueMember = "mcno_design"
        ddlMachineDesign.ComboBox.SelectedIndex = -1

        'ddlMachineNo.DataSource = objDB.comboMachine(clsUser.UserID)
        'ddlMachineNo.DisplayMember = "mcno"
        'ddlMachineNo.ValueMember = "mcno"
        'ddlMachineNo.SelectedIndex = -1

        'ddlMachineNo.DataSource = objDB.comboDesignGroup(clsUser.UserID)
        'ddlMachineNo.DisplayMember = "design_group"
        'ddlMachineNo.ValueMember = "design_group"
        'ddlMachineNo.SelectedIndex = -1
    End Sub

    Private Sub LoadData(ByVal strMCNo As String, strDesignGroup As String)
        If strMCNo.Trim.Length = 0 Then Exit Sub
        Dim objDB As New classProduction
        Dim dt As New DataTable
        dt = objDB.MachineCapacitySelect(strMCNo, strDesignGroup)
        txtMachineNo.Text = strMCNo
        txtDesignGroup.Text = strDesignGroup
        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub frmMachineCapacity_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call GenCombo()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim objDB As New classProduction
            If objDB.MachineCapacityUpdate(grdData.DataSource) Then
                MessageBox.Show("Update Completed.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error : Cannot save data.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptMachineCapacity.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        frm.Title = "Machine Capacity"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit now ?", "System Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub ddlMachineDesign_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles ddlMachineDesign.DropDownClosed
        If clsConfig.IsNull(ddlMachineDesign.ComboBox.SelectedValue, "") = "" Then Exit Sub
        Dim strData As New List(Of String)()
        strData.Add(ddlMachineDesign.ComboBox.SelectedValue.ToString().Split("/")(0).Trim())
        strData.Add(ddlMachineDesign.ComboBox.SelectedValue.ToString().Split("/")(1).Trim())
        Call LoadData(strData(0), strData(1))
    End Sub
End Class