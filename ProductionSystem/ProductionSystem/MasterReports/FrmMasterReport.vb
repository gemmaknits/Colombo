Public Class FrmMasterReport
    'Writen By : Sitthana Boonlom 20200622
    Private clsConn As New classConnection
    Private clsConfig As New clsConfig
    Private clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private objDB As New classItemsCategory
    Private dt As New DataTable

    Private Sub FrmMasterReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initComboObj()

    End Sub
    Private Sub initComboObj()
        'Init each combo box
        Dim ForFilter As String = "Y"

        'Conditions
        With cboCategory
            .DataSource = objDB.getMasterItemsCategory("FABRIC", ForFilter)
            .DisplayMember = "itcatdesc"
            .ValueMember = "itcatcd"
            .SelectedIndex = .FindString("All")
        End With
        With cboSubCategory
            .DataSource = objDB.getMasterItemsSubcategory("FABRIC", ForFilter)
            .DisplayMember = "itsubcatdesc"
            .ValueMember = "itsubcatcd"
            .SelectedIndex = .FindString("All")
        End With
        With cboFabricGroup
            .DataSource = objDB.getMasterItemsGroup("FABRIC", ForFilter)
            .DisplayMember = "itgroupdesc"
            .ValueMember = "itgroupcd"
            .SelectedIndex = .FindString("All")
        End With
        With cboFabricSubGroup
            .DataSource = objDB.getMasterItemsSubgroup("FABRIC", ForFilter)
            .DisplayMember = "itsubdesc"
            .ValueMember = "itsubcd"
            .SelectedIndex = .FindString("All")
        End With

        'Properties
        With cboApplication
            .DataSource = objDB.getMasterLookupValueByValueType("DESIGN_APPL", ForFilter)
            .DisplayMember = "lookup_value"
            .ValueMember = "lookup_value_id"
            .SelectedIndex = .FindString("All")
        End With

        With cboSubApplication
            .DataSource = objDB.getMasterLookupValueByValueType("DESIGN_SUB_APPL", ForFilter)
            .DisplayMember = "lookup_value"
            .ValueMember = "lookup_value_id"
            .SelectedIndex = .FindString("All")
        End With

        With cboSpcialFunction
            .DataSource = objDB.getMasterLookupValueByValueType("DESIGN_SPL_FUNC", ForFilter)
            .DisplayMember = "lookup_value"
            .ValueMember = "lookup_value_id"
            .SelectedIndex = .FindString("All")
        End With

        'With cboDesignFamilyName
        '    .DataSource = objDB.getMasterLookupValueByValueType("FAMILY-NAME", ForFilter)
        '    .DisplayMember = "lookup_value"
        '    .ValueMember = "lookup_value_id"
        '    .SelectedIndex = .FindString("All")
        'End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        printReport()

    End Sub
    Private Sub printReport()
        Dim rptFileName = "rptDesignProperties.rpt"

        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub

        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        rpt.SetParameterValue("@p_app_name", cboApplication.Text.Trim)
        rpt.SetParameterValue("@p_subapp_name", cboSubApplication.Text.Trim)
        rpt.SetParameterValue("@p_spl_fnc_name", cboSpcialFunction.Text.Trim)
        rpt.SetParameterValue("@p_design_family", "") 'cboDesignFamilyName.Text.Trim)
        rpt.SetParameterValue("@p_compo", txtComposition.Text.Trim)
        rpt.SetParameterValue("@p_article", txtArticle.Text.Trim)
        rpt.SetParameterValue("@p_compo", txtComposition.Text.Trim)
        rpt.SetParameterValue("@p_category", cboCategory.SelectedValue)
        rpt.SetParameterValue("@p_subcategory", cboSubCategory.SelectedValue)
        rpt.SetParameterValue("@p_fabric_group", cboFabricGroup.SelectedValue)
        rpt.SetParameterValue("@p_fabric_subgroup", cboFabricSubGroup.SelectedValue)
        rpt.SetParameterValue("@p_design_date_from", IIf(dtpDesignDateFrom.Checked, dtpDesignDateFrom.Value, ""))
        rpt.SetParameterValue("@p_design_date_to", IIf(dtpDesignDateTo.Checked, dtpDesignDateTo.Value, ""))
        rpt.SetParameterValue("@p_fwth_from", txtWidthFrom.Text.Trim)
        rpt.SetParameterValue("@p_fwth_to", txtWidthTo.Text.Trim)
        rpt.SetParameterValue("@p_mtkg_from", txtWeightFrom.Text.Trim)
        rpt.SetParameterValue("@p_mtkg_to", txtWeightTo.Text.Trim)

        frm.Title = "Designs Master"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Dim resultdt As New DataTable
        resultdt = objDB.rep_designs_properties(cboApplication.Text.Trim, cboSubApplication.Text.Trim, cboSpcialFunction.Text.Trim _
                                              , txtComposition.Text.Trim, txtArticle.Text.Trim _
                                              , cboCategory.SelectedValue, cboSubCategory.SelectedValue _
                                              , cboFabricGroup.SelectedValue, cboFabricSubGroup.SelectedValue _
                                              , IIf(dtpDesignDateFrom.Checked, Format(dtpDesignDateFrom.Value, "yyyyMMdd"), "") _
                                              , IIf(dtpDesignDateTo.Checked, Format(dtpDesignDateTo.Value, "yyyyMMdd"), "") _
                                              , txtWidthFrom.Text.Trim, txtWidthTo.Text.Trim _
                                              , txtWeightFrom.Text.Trim, txtWeightTo.Text.Trim
                                                )
        grdResult.DataSource = Nothing
        If resultdt.Rows.Count > 0 Then
            grdResult.AutoGenerateColumns = False
            grdResult.DataSource = resultdt
        End If
    End Sub


End Class