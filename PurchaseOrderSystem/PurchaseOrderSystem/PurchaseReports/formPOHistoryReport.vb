Public Class formPOHistoryReport
    Dim suppcd As String
    Dim fromDate As String
    Dim toDate As String
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub formPOHistoryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        populateComboSupplier()

        Me.dtpDateFr.Value = Date.Now.AddDays(-180)
        Me.dtpDateTo.Value = Date.Now
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        printReport()
    End Sub

    Private Sub PopulateData(ByVal conn As SqlClient.SqlConnection)
        'Comment BySitthana 20191128
        'Dim dt As New DataTable
        'dt = New classMaster().GetSupplier()
        'ComboSupplier1.DataSource = dt
        'ComboSupplier1.DisplayMember = "name"
        'ComboSupplier1.ValueMember = "suppcd"
        'ComboSupplier1.SelectedIndex = -1

        Dim dt2 As New DataTable
        dt2 = New classMaster().GetSo_Type(Strorder_type:="ALL")
        ComboSaleOrderType1.DataSource = dt2
        ComboSaleOrderType1.DisplayMember = "type_name"
        ComboSaleOrderType1.ValueMember = "order_type"
        ComboSaleOrderType1.SelectedIndex = -1

    End Sub

    Private Sub populateComboSupplier()
        Dim classcn As New classConnection
        Dim cn As New SqlClient.SqlConnection
        cn.ConnectionString = classcn.connection
        'Me.ComboSupplier1.populateData(cn)
        PopulateData(cn)
    End Sub
    Private Sub populateItemsGrid(Optional ByVal pSuppcd As String = "")
        Dim dt As New DataTable
        Dim obj As New GetDataYarn
        dt = obj.GetSupplierItems(pSuppcd)
        Me.dgselectItem.AutoGenerateColumns = False
        Me.dgselectItem.DataSource = dt

    End Sub

    Private Sub printReport()
        Dim config As New clsConfig
        Dim classCn As New classConnection
        Dim itemsList As String = ""
        Dim source As String
        Dim poclosestatus As String

        If Me.optImport.Checked = True Then
            source = "IMPORT"
        Else
            source = "LOCAL"
        End If

        poclosestatus = "ALL"

        If Me.optClosed.Checked = True Then
            poclosestatus = "CLOSED"
        End If

        If Me.optUnclosed.Checked = True Then
            poclosestatus = "NOT CLOSED"
        End If

        For i As Integer = 0 To Me.dgselectItem.Rows.Count - 2
            If Me.dgselectItem.Rows(i).Cells("colSelect").Value = True _
            And Me.dgselectItem.Rows(i).Cells("colitcd").Value.ToString.Trim.Length > 0 _
            And itemsList.Length < 8000 Then
                itemsList &= Me.dgselectItem.Rows(i).Cells("colitcd").Value.ToString.Trim & ","
            End If
        Next

        If itemsList <> "" Then
            itemsList = itemsList.Substring(1, itemsList.Length - 1)
        End If

        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        Dim clsConfig As New clsConfig
        Const rptFileName = "rptPurchase_history.rpt"
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'If Not clsConfig.CheckReport(clsConfig.ReportPath, rptFileName) Then
        '    rpt = New rptPurchase_history
        'Else
        '    rpt.Load(clsConfig.ReportPath & rptFileName)
        'End If

        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(classCn.servername, classCn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.Userid, classCn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@fromDate", fromDate)
        rpt.SetParameterValue("@toDate", toDate)
        rpt.SetParameterValue("@suppcd", suppcd)
        rpt.SetParameterValue("@itcd_list", itemsList)
        rpt.SetParameterValue("@source", source)
        rpt.SetParameterValue("@poclosestatus", poclosestatus)
        If optPrintAll.Checked Then
            rpt.SetParameterValue("@sell_back_to_vendor_type", 0)
            rpt.SetParameterValue("@sell_back_to_vendor", 0)
        ElseIf optPrintOnly.Checked Then
            rpt.SetParameterValue("@sell_back_to_vendor_type", 1)
            rpt.SetParameterValue("@sell_back_to_vendor", 1)
        ElseIf optPrintExcept.Checked Then
            rpt.SetParameterValue("@sell_back_to_vendor_type", 2)
            rpt.SetParameterValue("@sell_back_to_vendor", 0)
        End If

        ' rpt.SetParameterValue("@sell_back_to_vendor", chksell_back_to_vender2.Checked)
        rpt.SetParameterValue("@order_type", clsConfig.IsNull(ComboSaleOrderType1.SelectedValue, ""))
        rpt.SetParameterValue("@is_yarn", IIf(optYarns.Checked, 1, 0))

        Dim frmreport As New frmReport
        frmreport.CRViewer.ReportSource = rpt
        frmreport.MdiParent = Me.MdiParent
        frmreport.CRViewer.Zoom(100)
        frmreport.CRViewer.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
        frmreport.Show()
    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        selectAll()
    End Sub

    Private Sub cboSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub ComboSupplier1_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim clsconfig As New clsConfig
    '    suppcd = clsconfig.IsNull(ComboSupplier1.SelectedValue, "").ToString.Trim

    '    If Me.checkAllSuppliers.Checked = True Then
    '        populateItemsGrid("")
    '    Else
    '        populateItemsGrid(suppcd)
    '    End If
    '    selectAll()

    'End Sub

    Private Sub ComboSupplier1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dtpDateFr_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateFr.ValueChanged
        fromDate = dtpDateFr.Value.ToString("yyyyMMdd")
    End Sub

    Private Sub dtpDateTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateTo.ValueChanged
        toDate = dtpDateTo.Value.ToString("yyyyMMdd")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearAll()
    End Sub
    Private Sub selectAll()
        Dim i As Integer
        For i = 0 To Me.dgselectItem.Rows.Count - 2
            With Me.dgselectItem
                .Rows(i).Cells("colSelect").Value = True
            End With
        Next
    End Sub
    Private Sub clearAll()
        Dim i As Integer
        For i = 0 To Me.dgselectItem.Rows.Count - 2
            With Me.dgselectItem
                .Rows(i).Cells("colSelect").Value = False
            End With
        Next
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtItmFind_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItmFind.KeyPress
        'Sitthana 18/08/2018
        If e.KeyChar = vbCr Then
            With dgselectItem
                If .Rows.Count > 0 Then
                    Dim CurRowId As Integer = .CurrentRow.Index
                    Dim CurColId As Integer = .CurrentCell.ColumnIndex
                    Dim SearchWithinThis As String = ""

                    If CurColId = 0 Then CurColId = 1
                    Try
                        For i As Integer = CurRowId + 1 To .Rows.Count - 1
                            SearchWithinThis = .Rows(i).Cells(CurColId).Value.ToString.ToUpper
                            If SearchWithinThis.IndexOf(txtItmFind.Text.ToUpper) <> -1 Then
                                .CurrentCell = .Rows(i).Cells(CurColId)
                                Exit For
                            End If
                        Next
                        If .CurrentRow.Index = 0 Then
                            SearchWithinThis = .Rows(.CurrentRow.Index).Cells(CurColId).Value.ToString.ToUpper
                            If SearchWithinThis.IndexOf(txtItmFind.Text.ToUpper) = -1 Then
                                MessageBox.Show("ไม่พบข้อมูล Item Code ที่คุณต้องการหา", "รายงานผลการค้นหาข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            SearchWithinThis = .Rows(.CurrentRow.Index).Cells(CurColId).Value.ToString.ToUpper
                            If SearchWithinThis.IndexOf(txtItmFind.Text.ToUpper) = -1 Then
                                MessageBox.Show("ไม่พบข้อมูล Item Code ที่คุณต้องการหา", "รายงานผลการค้นหาข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

            End With
        End If
    End Sub

    Private Sub checkAllSuppliers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkAllSuppliers.CheckedChanged
        'send blank space as parameter for supp code to get item codes for all suppliers
        If Me.checkAllSuppliers.Checked = True Then
            'Me.ComboSupplier1.Enabled = False
            Me.suppcd = ""
            populateItemsGrid("")
        Else
            'Me.ComboSupplier1.Enabled = True
            'Me.suppcd = Me.ComboSupplier1.SelectedValue
            suppcd = txtSuppCd.Text.Trim
            populateItemsGrid(suppcd)
        End If
        'selectAll()
    End Sub
    Private Sub btnSelectSupplier_Click(sender As Object, e As EventArgs) Handles btnSelectSupplier.Click
        'Sitthana 20191128
        Dim f As New Classes.formSearchSupplier
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(Nothing)
        SearchResult = f.ShowSuppliers()
        f.Close()
        f.Dispose()
        drv = SearchResult.ResultRowView
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            suppcd = drv.Item("suppcd").ToString.Trim
            txtSuppCd.Text = suppcd
            txtSuppName.Text = drv.Item("name").ToString.Trim

            If Me.checkAllSuppliers.Checked = True Then
                checkAllSuppliers.Checked = False
                populateItemsGrid("")
            Else
                populateItemsGrid(suppcd)
            End If
            selectAll()
        End If
    End Sub
End Class