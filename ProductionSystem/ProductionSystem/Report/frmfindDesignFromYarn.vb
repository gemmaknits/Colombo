Imports System.Data.SqlClient
Imports System.Text

Public Class frmfindDesignFromYarn
    Dim clsConn As New classConnection
       Dim clsuser As new classUserInfo
    Dim clsConfig As New clsConfig

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    'Local Variable
    Private objDB As New classProduction
    Private dtDesigns As New DataTable
    Private dtBeamYarn As New DataTable
    Private dtRawYarn As New DataTable

    Private bsDesigns As New BindingSource
    Private bsBeamYarn As New BindingSource
    Private bsRawYarn As New BindingSource
    Private bsBom As New BindingSource

    Private ItcdList As String = ""
    Private ActivedValue As String
    Private ApprovedValue As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmfindDesignFromYarn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rbQueryByDesigns_Click(sender As Object, e As EventArgs) Handles rbQueryByDesigns.Click
        'If dtDesigns.Rows.Count <= 0 Then
        dtDesigns = objDB.selectDesignNo()
        'End If
        grdItemsCondition.DataSource = Nothing
        If dtDesigns.Rows.Count > 0 Then
            createDesignGridHeader()
            grdItemsCondition.AutoGenerateColumns = False
            bsDesigns.DataSource = Nothing
            bsDesigns.DataSource = dtDesigns
            grdItemsCondition.DataSource = bsDesigns
            bsDesigns.MoveFirst()

            bsBom.DataSource = Nothing 'Clear grdDesignFromYarn
        End If
    End Sub
    Private Sub rbQueryByBeam_Click(sender As Object, e As EventArgs) Handles rbQueryByBeam.Click
        'If dtBeamYarn.Rows.Count <= 0 Then
        dtBeamYarn = objDB.selectItemByItGrp("YARNS", "BYARN")
        'End If
        grdItemsCondition.DataSource = Nothing
        If dtBeamYarn.Rows.Count > 0 Then
            createYarnGridHeader()
            grdItemsCondition.AutoGenerateColumns = False
            bsBeamYarn.DataSource = dtBeamYarn
            grdItemsCondition.DataSource = bsBeamYarn
            bsBeamYarn.MoveFirst()

            bsBom.DataSource = Nothing 'Clear grdDesignFromYarn
        End If
    End Sub
    Private Sub rbQueryByYarn_Click(sender As Object, e As EventArgs) Handles rbQueryByYarn.Click
        'If dtRawYarn.Rows.Count <= 0 Then
        dtRawYarn = objDB.selectItemByItGrp("YARNS", "RYARN")
        'End If
        grdItemsCondition.DataSource = Nothing
        If dtRawYarn.Rows.Count > 0 Then
            createYarnGridHeader()
            grdItemsCondition.AutoGenerateColumns = False
            bsRawYarn.DataSource = dtRawYarn
            grdItemsCondition.DataSource = bsRawYarn
            bsRawYarn.MoveFirst()

            bsBom.DataSource = Nothing 'Clear grdDesignFromYarn
        End If
    End Sub
    Private Sub txtGrdItemsConditionFillter_TextChanged(sender As Object, e As EventArgs) Handles txtGrdItemsConditionFillter.TextChanged
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtGrdItemsConditionFillter.Text.Trim

        If rbQueryByDesigns.Checked Then
            FilterExp.Append(" Design_no LIKE '*" & SearchString & "*'")
            FilterExp.Append(" or refdesno LIKE '*" & SearchString & "*'")
            FilterExp.Append(" or compo LIKE '*" & SearchString & "*'")
        Else
            FilterExp.Append(" itcd LIKE '*" & SearchString & "*'")
            FilterExp.Append(" or itdesc_spec LIKE '*" & SearchString & "*'")
            FilterExp.Append(" or itdesc_supp LIKE '*" & SearchString & "*'")
        End If

        If SearchString <> "" Then
            If rbQueryByDesigns.Checked Then
                bsDesigns.Filter = FilterExp.ToString
            ElseIf rbQueryByBeam.Checked Then
                bsBeamYarn.Filter = FilterExp.ToString
            Else
                bsRawYarn.Filter = FilterExp.ToString
            End If
        Else
            If rbQueryByDesigns.Checked Then
                bsDesigns.Filter = ""
            ElseIf rbQueryByBeam.Checked Then
                bsBeamYarn.Filter = ""
            Else
                bsRawYarn.Filter = ""
            End If
        End If
    End Sub

    '#region Create DGVHeader
    Private Sub createDesignGridHeader()
        With grdItemsCondition
            Dim cbCol As New DataGridViewCheckBoxColumn
            cbCol.Name = "Select"
            cbCol.HeaderText = "Select"
            cbCol.Width = 30
            cbCol.ReadOnly = False

            .Columns.Clear()
            .Columns.Add(cbCol)
            .Columns.Add("design_no", "Design No")
            .Columns.Add("refdesno", "Descsiption")
            .Columns.Add("compo", "Compo")

            .Columns("design_no").Width = 90          'Design No
            .Columns("refdesno").Width = 150          'Descsiption
            .Columns("compo").Width = 100             'Compo

            .Columns("design_no").DataPropertyName = "design_no"
            .Columns("refdesno").DataPropertyName = "refdesno"
            .Columns("compo").DataPropertyName = "compo"

            .Columns("design_no").ReadOnly = True
            .Columns("refdesno").ReadOnly = True
            .Columns("compo").ReadOnly = True

            .Columns("design_no").Frozen = True

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub
    Private Sub createYarnGridHeader()
        With grdItemsCondition
            Dim cbCol As New DataGridViewCheckBoxColumn
            cbCol.Name = "Select"
            cbCol.HeaderText = "Select"
            cbCol.Width = 30
            cbCol.ReadOnly = False

            .Columns.Clear()
            .Columns.Add(cbCol)
            .Columns.Add("itcd", "Item Code")
            .Columns.Add("itdesc_spec", "Description")
            .Columns.Add("itdesc_supp", "Supplier Desciption")
            .Columns.Add("uom_name", "UOM")
            .Columns.Add("itgroupcd", "Item Group")

            .Columns("itcd").Width = 70             'Item Code
            .Columns("itdesc_spec").Width = 150     'Description
            .Columns("itdesc_supp").Width = 100     'Supplier Description
            .Columns("uom_name").Width = 60         'UOM
            .Columns("itgroupcd").Width = 50        'Item Group

            .Columns("itcd").DataPropertyName = "itcd"
            .Columns("itdesc_spec").DataPropertyName = "itdesc_spec"
            .Columns("itdesc_supp").DataPropertyName = "itdesc_supp"
            .Columns("uom_name").DataPropertyName = "uom_name"
            .Columns("itgroupcd").DataPropertyName = "itgroupcd"

            .Columns("itcd").ReadOnly = True
            .Columns("itdesc_spec").ReadOnly = True
            .Columns("itdesc_supp").ReadOnly = True
            .Columns("uom_name").ReadOnly = True
            .Columns("itgroupcd").ReadOnly = True

            .Columns("itcd").Frozen = True

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            '.ReadOnly = True
        End With
    End Sub

    Private Sub getYarnCodeDescpAndAssignValueToText(objYarnCode As Object, objYarnDescp As Object)
        'Sitthana 20191109
        Dim f As New Classes.formSearchItemcode
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult

        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(clsConn.getSQLConnection)
        f.ItemNatureCD = "YARNS"

        SearchResult = f.ShowItems
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            If IsNothing(SearchResult.ResultRowView) Then
                MessageBox.Show("Not select data", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                objYarnCode.Text = drv.Item("itcd")
                objYarnDescp.Text = drv.Item("itdesc")
                'MsgBox("Design_no" & drv.Item("item_id") & vbCr _
                '                & drv.Item("itcd") & vbCr _
                '                & drv.Item("itdesc") & vbCr _
                '                & drv.Item("itdesc2") & vbCr _
                '                & drv.Item("itdesc3") & vbCr _
                '                & drv.Item("itdesc_supp") & vbCr
                '                  )

            End If
        End If
    End Sub

    Private Sub LoadDesignFromYarnData()
        Dim dt As New DataTable

        getParameterValue()
        If rbQueryByDesigns.Checked Then
            dt = objDB.selectDesignByDesignNo(ItcdList _
                                            , ActivedValue _
                                            , ApprovedValue
                                              )
        ElseIf rbQueryByBeam.Checked Then
            dt = objDB.selectDesignByBeam(ItcdList _
                                        , ActivedValue _
                                        , ApprovedValue
                                          )
        Else
            dt = objDB.selectDesignByYarn(ItcdList _
                                        , ActivedValue _
                                        , ApprovedValue
                                          )
        End If

        If dt.Rows.Count > 0 Then
            bsBom.DataSource = dt
            grdDesignFromYarn.AutoGenerateColumns = False
            grdDesignFromYarn.DataSource = bsBom
            bsBom.MoveFirst()
            'grdDesignFromYarn.DataSource = dt
        Else
            dt = Nothing
        End If
    End Sub
    Private Sub btnFindData_Click(sender As Object, e As EventArgs) Handles btnFindData.Click
        grdDesignFromYarn.DataSource = Nothing
        LoadDesignFromYarnData()
    End Sub

    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtWordFilter.Text.Trim
        FilterExp.Append(" Design_no LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or ynchgcd LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or refdesno LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or compo LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or bom_remarks LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or remark LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or itcd LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or itdesc LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or itcd LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or sup_name LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or ryarn_itcd LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or ryarn_itdesc LIKE '*" & SearchString & "*'")

        If SearchString <> "" Then
            bsBom.Filter = FilterExp.ToString
        Else
            bsBom.Filter = ""
        End If
    End Sub

    '#Print Region
    Private Sub getParameterValue()
        With grdItemsCondition
            ItcdList = ""
            For i As Integer = 0 To .Rows.Count - 1
                If .Rows(i).Cells(0).Value = True Then
                    ItcdList &= "," & .Rows(i).Cells(1).Value 'Column design_no or itcd
                End If
            Next
            If ItcdList.Trim <> "" Then
                ItcdList = Mid(ItcdList, 2, Len(ItcdList) - 1)
            End If
        End With

        If rbActived.Checked Then
            ActivedValue = "Y"
        ElseIf rbActivedCancel.Checked Then
            ActivedValue = "N"
        Else
            ActivedValue = ""
        End If
        If rbApproved.Checked Then
            ApprovedValue = "Y"
        ElseIf rbApprovedWait.Checked Then
            ApprovedValue = "N"
        Else
            ApprovedValue = ""
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim rptFileName As String = ""
        If rbQueryByDesigns.Checked Then
            rptFileName = "rptFindDesignFromDesignNo.rpt"
        ElseIf rbQueryByBeam.Checked Then
            rptFileName = "rptFindDesignFromBeam.rpt"
        Else
            rptFileName = "rptFindDesignFromYarn.rpt"
        End If

        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
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

        getParameterValue()
        rpt.SetParameterValue("@p_itcd_list", ItcdList.Trim)
        rpt.SetParameterValue("@p_bom_usage_code", "")
        rpt.SetParameterValue("@p_actived", ActivedValue)
        rpt.SetParameterValue("@p_approved", ApprovedValue)

        frm.Title = "Find Design From Yarn Report"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.CRViewer.ShowRefreshButton = True
        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSelectItemInGrdtemsCondition_Click(sender As Object, e As EventArgs) Handles btnSelectItemInGrdtemsCondition.Click
        With grdItemsCondition
            If .Rows.Count > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i).Cells(0).Value = True
                Next
            End If
        End With
    End Sub

    Private Sub btnDeselectItemInGrdtemsCondition_Click(sender As Object, e As EventArgs) Handles btnDeselectItemInGrdtemsCondition.Click
        With grdItemsCondition
            If .Rows.Count > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i).Cells(0).Value = False
                Next
            End If
        End With
    End Sub

End Class