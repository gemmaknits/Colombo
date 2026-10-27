Public Class frmStockOnhand
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

        Me.cbomtl_warehouse.DataSource = objDB.Combomtlwarehouse(clsUser.UserID)
        Me.cbomtl_warehouse.DisplayMember = "warehouse_code"
        Me.cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        Me.cbomtl_warehouse.SelectedIndex = -1

        'Call GenCbosubInventory(Int64mtl_warehouse_id:=Nothing)

        Me.cboPrintOnly.DataSource = objDB.GetSupplier
		Me.cboPrintOnly.DisplayMember = "name"
		Me.cboPrintOnly.ValueMember = "suppcd"
		Me.cboPrintOnly.SelectedIndex = -1

		Me.cboPrintExcept.DataSource = objDB.GetSupplier
		Me.cboPrintExcept.DisplayMember = "name"
		Me.cboPrintExcept.ValueMember = "suppcd"
        Me.cboPrintExcept.SelectedIndex = -1


        Me.cboCustPrintOnly.DataSource = objDB.GetCustomer
        Me.cboCustPrintOnly.DisplayMember = "name"
        Me.cboCustPrintOnly.ValueMember = "custcd"
        Me.cboCustPrintOnly.SelectedIndex = -1

        Me.cboCustPrintExcept.DataSource = objDB.GetCustomer
        Me.cboCustPrintExcept.DisplayMember = "name"
        Me.cboCustPrintExcept.ValueMember = "custcd"
        Me.cboCustPrintExcept.SelectedIndex = -1
    End Sub

    Private Sub GenCbosubInventory(Int64mtl_warehouse_id As Int64)
        Dim objDB As New classMaster
        Me.cbomtl_subinventory.DataSource = objDB.ComboMtlsubinventory(Int64mtl_warehouse_id)
        Me.cbomtl_subinventory.DisplayMember = "subinventory_code"
        Me.cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        Me.cbomtl_subinventory.SelectedIndex = -1
    End Sub

	Private Sub GenGrid()
		Dim conn As New SqlClient.SqlConnection((New classConnection).connection)
		Dim comm As New SqlClient.SqlCommand("select cast('' as varchar(20)) as design_no", conn)
		Dim da As New SqlClient.SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		grdDesignNo.DataSource = dt
	End Sub

	Private Function GetDesignNo(ByVal dt As DataTable) As String
		Dim strDesignNo As String = ""
		Dim i As Integer = 0
		If dt.Rows.Count > 0 Then
			For i = 0 To dt.Rows.Count - 1
				If dt.Rows(i).RowState <> DataRowState.Deleted Then
					If dt.Rows(i)("design_no").ToString.Trim.Length > 0 Then strDesignNo = strDesignNo & dt.Rows(i)("design_no").ToString.Trim & ","
				End If
			Next
		End If
		Return strDesignNo
	End Function

	Private Sub frmSaleOrderInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Me.StartPosition = FormStartPosition.CenterScreen

        dtpDateFr.Value = CDate("01/01/1900")
        dtpDateTo.Value = Now
        dtpDateFr.Checked = True
        dtpDateTo.Checked = True
        Call GenCombo()
		Call GenGrid()
	End Sub

    Private Function getRptStockG()
        'Sitthana 20190511
        Dim RptName As String = ""
        If optDetail.Checked Then
            RptName = "rptStockGOnhand_detail_new.rpt"
        ElseIf optSumRollDefect.Checked Then
            RptName = "rptStockGOnhand_summary_defect_new.rpt" 'Insert By Neung 02/09/2015
        ElseIf optSumRoll.Checked Then
            RptName = "rptStockGOnhand_summary_new.rpt"
        ElseIf optSumDesign.Checked Then
            RptName = "rptStockGOnhand_exclusive_by_design_new.rpt" 'Design
            'RptName = "rptStockGOnhand_exclusive_new.rpt"
        ElseIf optSumRollDefectWithDesign.Checked Then
            RptName = "rptStockGOnhand_summary_defect_design_header_new.rpt" 'Insert By Neung 02/09/2015
        ElseIf optSumDesignAndColor.Checked Then
            RptName = "rptStockGOnhand_exclusive_by_design_new.rpt" 'Design and Color
            'RptName = "rptStockGOnhand_exclusive_new.rpt"
        ElseIf optSumDesignAndColorAndGINDate.Checked Then
            RptName = "rptStockGOnhand_exclusive_and_color_and_tran_dt.rpt" 'Design and Color and Tran_dt
        End If

        Return RptName
    End Function
    Private Function getRptStockD()
        'Sitthana 20190511
        Dim RptName As String = ""
        If optDetail.Checked Then
            RptName = "rptStockDOnhand_detail_new.rpt"
        ElseIf optSumRollDefect.Checked Then
            RptName = "rptStockDOnhand_summary_new.rpt"
        ElseIf optSumRoll.Checked Then
            RptName = "rptStockDOnhand_summary_new.rpt"
        ElseIf optSumDesign.Checked Then
            RptName = "rptStockDOnhand_exclusive_new.rpt"
        ElseIf optSumRollDefectWithDesign.Checked Then
            RptName = "rptStockDOnhand_summary_design_header_new.rpt"
        ElseIf optSumDesignAndColor.Checked Then
            RptName = "rptStockDOnhand_exclusive_by_design_new.rpt" 'Use For Audit 21/12/2015
        ElseIf optSumDesignAndColorAndGINDate.Checked Then
            RptName = "rptStockDOnhand_exclusive_by_design_and_color_and_tran_dt.rpt"
        ElseIf optSumDesignAndColorAndSale.Checked Then
            RptName = "rptStockDOnhand_exclusive_by_design_and_color_and_sale_person.rpt"
        End If
        Return RptName
    End Function

    Private Function getRptStockGamma()

        Dim RptName As String = "rptStockGammaOnhand_summary_new.rpt"

        Return RptName
    End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call grdDesignNo.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Dim strDesignNo As String = ""
        Dim rptFileName As String = ""
        Dim GreigePresetOption As String = "ALL"

        'Begin Sitthana 20190511
        If optStockG.Checked Then
            rptFileName = getRptStockG()
        ElseIf optStockD.Checked Then
            rptFileName = getRptStockD()
        ElseIf optStockGamma.Checked Then
            rptFileName = getRptStockGamma()
        End If
        '--- End Sitthana 20190511

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        strDesignNo = GetDesignNo(grdDesignNo.DataSource)
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        'rpt.VerifyDatabase() 'Test By Neung
        If optStockG.Checked Then
            If optPrintAll.Checked Then
                rpt.SetParameterValue("@suppcd_type", 0)
                rpt.SetParameterValue("@suppcd", "")
            ElseIf optPrintOnly.Checked Then
                rpt.SetParameterValue("@suppcd_type", 1)
                rpt.SetParameterValue("@suppcd", clsConfig.IsNull(cboPrintOnly.SelectedValue, ""))
            ElseIf optPrintExcept.Checked Then
                rpt.SetParameterValue("@suppcd_type", 2)
                rpt.SetParameterValue("@suppcd", clsConfig.IsNull(cboPrintExcept.SelectedValue, ""))
            End If
            rpt.SetParameterValue("@custype", "")
        ElseIf optStockD.Checked Then
            If optCustPrintAll.Checked Then
                rpt.SetParameterValue("@custcd_type", 0)
                rpt.SetParameterValue("@custcd", "")
            ElseIf optCustPrintOnly.Checked Then
                rpt.SetParameterValue("@custcd_type", 1)
                rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustPrintOnly.SelectedValue, ""))
            ElseIf optCustPrintOnly.Checked Then
                rpt.SetParameterValue("@custcd_type", 2)
                rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustPrintExcept.SelectedValue, ""))
            End If
        ElseIf optStockGamma.Checked Then
            If optCustPrintAll.Checked Then
                rpt.SetParameterValue("@custcd_type", 0)
                rpt.SetParameterValue("@custcd", "")

            ElseIf optCustPrintOnly.Checked Then
                rpt.SetParameterValue("@custcd_type", 1)
                rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustPrintOnly.SelectedValue, ""))
            ElseIf optCustPrintOnly.Checked Then
                rpt.SetParameterValue("@custcd_type", 2)
                rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustPrintExcept.SelectedValue, ""))
            End If
        End If

        rpt.SetParameterValue("@loc", txtLocation.Text.Trim)
        rpt.SetParameterValue("@design_no", strDesignNo)
        rpt.SetParameterValue("@datefr", IIf(dtpDateFr.Checked, dtpDateFr.Value.ToString("yyyyMMdd").Trim, "19000101"))
        'rpt.SetParameterValue("@datefr", "19000101")
        ' rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@dateto", IIf(dtpDateTo.Checked, dtpDateTo.Value.ToString("yyyyMMdd").Trim, Now.ToString("yyyyMMdd"))) 'as on date
        'rpt.SetParameterValue("@Grade", txtGrades.Text.Trim) 'Comment by Sitthana 20190531

        'Set @orderfilter
        If Me.optOrderFilterAll.Checked Then rpt.SetParameterValue("@orderfilter", "ALL")
        If Me.optOrderFilterDevl.Checked Then rpt.SetParameterValue("@orderfilter", "DEVL")
        If Me.optOrderFilterMTS.Checked Then rpt.SetParameterValue("@orderfilter", "MTS")
        If Me.optOrderFilterMTO.Checked Then rpt.SetParameterValue("@orderfilter", "MTO")
        If Me.optOrderFilterOTHER.Checked Then rpt.SetParameterValue("@orderfilter", "OTHER") 'S/O No. is Emply

        If optStockG.Checked Then
            GreigePresetOption = "ALL"
            If optGreigePreset.Checked Then GreigePresetOption = "PRESET"
            If optGreigeNonPreset.Checked Then GreigePresetOption = "NONPRESET"
            rpt.SetParameterValue("@GreigePresetOption", GreigePresetOption)
            rpt.SetParameterValue("@nob", 0)

            'rpt.SetParameterValue("@mtl_warehouse_id", clsConfig.IsNull(cbomtl_warehouse.SelectedValue, 0)) 'Default 0 for ALL
            rpt.SetParameterValue("@stockyear", IIf(dtpStockYearFr.Checked, dtpStockYearFr.Value, Nothing))
            rpt.SetParameterValue("@stockyear_to", IIf(dtpStockYearTo.Checked, dtpStockYearTo.Value, Nothing))
        ElseIf optStockD.Checked Then
            'Sitthana 20190511
            rpt.SetParameterValue("@mtl_subinventory_id", clsConfig.IsNull(cbomtl_subinventory.SelectedValue, 0))
        ElseIf optStockGamma.Checked Then
            rpt.SetParameterValue("@mtl_subinventory_id", clsConfig.IsNull(cbomtl_subinventory.SelectedValue, 0))

        End If
        'Sitthana Comment 20190511
        'If optStockD.Checked Then
        '    rpt.SetParameterValue("@mtl_subinventory_id", clsConfig.IsNull(cbomtl_subinventory.SelectedValue, 0))
        '    rpt.SetParameterValue("@mtl_subinventory_id", clsConfig.IsNull(cbomtl_subinventory.SelectedValue, 0))
        'End If

        rpt.SetParameterValue("@mtl_warehouse_id", clsConfig.IsNull(cbomtl_warehouse.SelectedValue, 0)) 'Not Yet

        'Beging Copy From GMK  Sitthana 20190531
        If optPrintGradeAll.Checked Then
            rpt.SetParameterValue("@grade_type", 0)
            rpt.SetParameterValue("@Grade", "")
        ElseIf optPrintGradeOnly.Checked Then
            rpt.SetParameterValue("@grade_type", 1)
            rpt.SetParameterValue("@Grade", txtGradePrintOnly.Text)
        ElseIf optPrintGradeExcept.Checked Then
            rpt.SetParameterValue("@grade_type", 2)
            rpt.SetParameterValue("@Grade", txtGradePrintExcept.Text)
        ElseIf optPrintGradeOnly2.Checked Then
            rpt.SetParameterValue("@grade_type", 3)
            rpt.SetParameterValue("@Grade", "2")
            'rpt.SetParameterValue("@Grade", "2 P,2G,2G1,2P,2P-,2P1")
        ElseIf optPrintGradeExcept2.Checked Then
            rpt.SetParameterValue("@grade_type", 4)
            rpt.SetParameterValue("@Grade", "2")
            'rpt.SetParameterValue("@Grade", "2 P,2G,2G1,2P,2P-,2P1")
        End If
        'End Copy From GMK  Sitthana 20190531

        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto
        'rpt.SetParameterValue("@mtl_subinventory_id", clsConfig.IsNull(cbomtl_subinventory.SelectedValue, DBNull.Value)) 'Not Yet
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait

        'Set Form Title
        If optStockG.Checked Then
            frm.Title = "Stock G Onhand"
        ElseIf optStockD.Checked Then
            frm.Title = "Stock D Onhand"
        ElseIf optStockGamma.Checked Then
            frm.Title = "Stock FG Gamma Onhand"
        End If

        'If optStockC.Checked Then frm.Title = "Stock C Onhand"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtFwth_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFwth.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim conn As New System.Data.SqlClient.SqlConnection((New classConnection).connection)
            Dim comm As New System.Data.SqlClient.SqlCommand("", conn)
            comm.CommandType = CommandType.StoredProcedure
            comm.CommandText = "p_designs_search_by_fwth"
            comm.Parameters.AddWithValue("@design_no", clsConfig.IsNull(grdDesignNo.Rows(0).Cells(0).Value, ""))
            comm.Parameters.AddWithValue("@fwth", txtFwth.Text.Trim)
            Dim da As New System.Data.SqlClient.SqlDataAdapter(comm)
            Dim dt As New DataTable
            da.Fill(dt)
            grdDesignNo.DataSource = dt
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optSumRollDefect.CheckedChanged

    End Sub

    Private Sub optSumDesign_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optSumDesign.CheckedChanged

    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_warehouse_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedValueChanged
        Dim dt As New DataTable

    End Sub

    Private Sub txtGrades_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        If dtpDateTo.Checked Then
            dtpDateFr.Checked = True
            'dtpDateShowBF.Checked = False

            'dtpStockYear_from.Checked = False
            'dtpStockYear_To.Checked = False
        Else
            dtpDateFr.Checked = False
        End If
    End Sub

    Private Sub dtpDateFr_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFr.ValueChanged
        If dtpDateFr.Checked Then
            dtpDateTo.Checked = True
            ' dtpDateShowBF.Checked = False

            'dtpStockYear_from.Checked = False
            'dtpStockYear_To.Checked = False
        Else
            dtpDateTo.Checked = False
        End If
    End Sub

    Private Sub optStockG_CheckedChanged(sender As Object, e As EventArgs) Handles optStockG.CheckedChanged
        If optStockG.Checked Then

            gbGreigeOption.Enabled = True

            dtpStockYearFr.Enabled = True
            dtpStockYearTo.Enabled = True

            gbSuppiler.Enabled = True
            gbCustomer.Enabled = False

            gbReportType.Enabled = True
            optSumDesignAndColorAndSale.Visible = False
            If optSumDesignAndColorAndSale.Checked Then optSumRollDefect.Checked = True
            optSumDesignAndColorAndGINDate.Text = "Summary By Design And Color And G-IN date"
        End If
    End Sub

    Private Sub optStockD_CheckedChanged(sender As Object, e As EventArgs) Handles optStockD.CheckedChanged
        If optStockD.Checked Then
            gbGreigeOption.Enabled = False
            dtpStockYearFr.Checked = False
            dtpStockYearFr.Checked = False
            dtpStockYearFr.Enabled = False
            dtpStockYearTo.Enabled = False

            gbSuppiler.Enabled = False
            gbCustomer.Enabled = True
            gbStockLocations.Enabled = True
            gbStockReceviedDate.Enabled = True
            gbOrderFilter.Enabled = True

            gbReportType.Enabled = True
            optSumDesignAndColorAndGINDate.Text = "Summary By Design And Color And D-IN date"
            optSumDesignAndColorAndSale.Visible = True
        End If
    End Sub

    Private Sub txtFwth_TextChanged(sender As Object, e As EventArgs) Handles txtFwth.TextChanged

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_warehouse.DropDownClosed
        GenCbosubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0))
        GetComboNewLocation((New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                         (New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing)
                         )
    End Sub

    Private Sub cbomtl_subinventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As EventArgs) Handles cbomtl_subinventory.DropDownClosed
        GetComboNewLocation((New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                          (New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing)
                          )
    End Sub


    Private Sub GetComboNewLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing _
                                    , Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing
                                    )
        'Sitthana 24/02/2018
        Dim objdb As New classMaster

        cboNewmtl_locations_id.DataSource = objdb.Combomtllocations(clsUser.UserID, Int64mtl_warehouse_id, Int64mtl_subinventory_id)
        cboNewmtl_locations_id.DisplayMember = "location_name"
        cboNewmtl_locations_id.ValueMember = "mtl_locations_id"

        'Setdefaultsubinventory(dt:=cboNewmtl_subinventory.DataSource)

    End Sub

    Private Sub dtpStockYearFr_ValueChanged(sender As Object, e As EventArgs) Handles dtpStockYearFr.ValueChanged
        If dtpStockYearTo.Value < dtpStockYearFr.Value Then
            dtpStockYearTo.Value = dtpStockYearFr.Value
        End If

        If dtpStockYearFr.Checked Then

            'dtpDatefr.Checked = False
            'dtpDateTo.Checked = False
            ' dtpDateShowBF.Checked = False

            dtpStockYearTo.Checked = True
        Else

            dtpStockYearTo.Checked = False
        End If
    End Sub

    Private Sub dtpStockYearTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpStockYearTo.ValueChanged
        If dtpStockYearTo.Checked Then

            ' dtpDatefr.Checked = False
            ' dtpDateTo.Checked = False
            ' dtpDateShowBF.Checked = False

            dtpStockYearFr.Checked = True
        Else
            dtpStockYearFr.Checked = False
        End If
    End Sub

    Private Sub optPrintOnly_CheckedChanged(sender As Object, e As EventArgs) Handles optPrintOnly.CheckedChanged

    End Sub

    Private Sub optPrintExcept_CheckedChanged(sender As Object, e As EventArgs) Handles optPrintExcept.CheckedChanged

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles gbStockLocations.Enter

    End Sub

    Private Sub optStockGamma_CheckedChanged(sender As Object, e As EventArgs) Handles optStockGamma.CheckedChanged
        If optStockGamma.Checked = True Then

            gbGreigeOption.Enabled = False

            dtpStockYearFr.Checked = False
            dtpStockYearFr.Checked = False
            dtpStockYearFr.Enabled = False
            dtpStockYearFr.Enabled = False

            gbSuppiler.Enabled = False
            gbCustomer.Enabled = True
            gbStockLocations.Enabled = False
            gbStockReceviedDate.Enabled = False
            gbOrderFilter.Enabled = False

            optSumRoll.Checked = True
            gbReportType.Enabled = False
            optSumRoll.Checked = True
            optDetail.Enabled = False
            optSumDesign.Enabled = False
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class