Public Class frmProductOperation

#Region "Properties"
    Dim oConn As New classConnection
    Private clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
#End Region
    Private dtKo As New DataTable
    Private dtBom As New DataTable
    Private clsProduction As New classProduction

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        MsgBox("Up")
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        MsgBox("Down")
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        MsgBox("Left")
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        MsgBox("Right")
    End Sub

    Private Sub btnGetKINo_Click(sender As Object, e As EventArgs) Handles btnGetKINo.Click
        'Sitthana 20210723
        Dim f = New Classes.frmSearchKOByDocType
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult

        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        Me.Cursor = Cursors.WaitCursor

        f.setConnectionString(oConn.getSQLConnection)
        f.KODocType = "KI"
        f.KOClosed = 0
        f.logempcd = ""

        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()

        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtKONo.Text = drv.Item("kono")
            txtCustName.Text = drv.Item("cust_name")

            dtKo = clsProduction.getKO(txtKONo.Text.Trim, clsUser.UserID)
            If dtKo.Rows.Count > 0 Then
                txtDesignNo.Text = dtKo.Rows(0)("design_no")
                txtSoNo.Text = dtKo.Rows(0)("sono")
                txtMcNo.Text = dtKo.Rows(0)("mcno")
                txtRemark.Text = "Special Instruction : " & dtKo.Rows(0)("remark")
                txtQty.Text = dtKo.Rows(0)("qty")
                txtRPM.Text = ""
                txtDailyCapacityKg.Text = dtKo.Rows(0)("daily_capacity_kg")
                txtKStartDt.Text = dtKo.Rows(0)("kstartdt")
                txtKEndDt.Text = dtKo.Rows(0)("kenddt")
                txtMrpQty.Text = dtKo.Rows(0)("mrp_qty")

                dtBom = clsProduction.getMfgProductionOrderLine(txtKONo.Text.Trim, clsUser.UserID)
                If dtBom.Rows.Count > 0 Then
                    txtItemDesc1.Text = dtBom.Rows(1)("itdesc")
                    txtBomPerc1.Text = dtBom.Rows(1)("bom_perc")
                    If dtBom.Rows.Count >= 3 Then
                        txtItemDesc2.Text = dtBom.Rows(2)("itdesc")
                        txtBomPerc2.Text = dtBom.Rows(2)("bom_perc")
                        If dtBom.Rows.Count >= 4 Then
                            txtItemDesc3.Text = dtBom.Rows(3)("itdesc")
                            txtBomPerc3.Text = dtBom.Rows(3)("bom_perc")
                        Else
                            txtItemDesc3.Text = ""
                            txtBomPerc3.Text = ""
                        End If
                    Else
                        txtItemDesc2.Text = ""
                        txtBomPerc2.Text = ""
                    End If
                End If
            End If


            'If txtMcNo.Text.Trim <> "" Then
            '    dtMcNo = clsProduction.getMachineInfo(txtMcNo.Text.Trim)
            '    If dtMcNo.Rows.Count > 0 Then
            '        txtRPM.Text = dtMcNo.Rows(0)("rpm")
            '        txtKgPerDay.Text = dtMcNo.Rows(0)("kg_per_day")
            '    Else
            '        txtRPM.Text = ""
            '        txtKgPerDay.Text = 0
            '    End If
            'End If
        End If


        Me.Cursor = Cursors.Arrow
    End Sub
End Class