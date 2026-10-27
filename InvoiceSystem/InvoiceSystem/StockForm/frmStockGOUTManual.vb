Public Class frmStockGOUTManual
    Dim clsuser As New classUserInfo
    Dim dbStockG As New classStockG
    Dim StrOutno As String
    Public Property Userinfo As classUserInfo

        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property


    Private Sub GenCboDocno()
        Dim dt As DataTable = dbStockG.GetComboGOut()
        cboDocNo.ComboBox.DataSource = dt
        cboDocNo.ComboBox.DisplayMember = "outno"
        cboDocNo.ComboBox.ValueMember = "outno"
        cboDocNo.ComboBox.SelectedIndex = -1
    End Sub

    Private Sub frmStockGOUTManual_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()
       
    End Sub
    Private Sub InitControl()
        clearGrdData("0")
        clearCboDocNo()
        clearCboDocType()
        txtDesignNo.Text = ""
        txtOutNo.Text = ""
    End Sub
    Private Sub clearCboDocType()
        Call GenCboDoctype()
    End Sub
    Private Sub clearCboDocno()
        Call GenCboDocno()
    End Sub
    Private Sub clearGrdData(ByRef StrOutno As String)
        Dim objdb As New classStockG
        grdData.AutoGenerateColumns = False
        grdData.DataSource = objdb.GetGOut(StrOutno, clsuser.UserID)

    End Sub




    Private Sub GenCboDoctype()
        Dim objDB As New classMaster

        CboDoc_type.DataSource = objDB.GetDocType
        CboDoc_type.DisplayMember = "name"
        CboDoc_type.ValueMember = "doctyp"
        CboDoc_type.SelectedValue = -1


    End Sub

    Private Sub cboDocNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboDocNo.DropDownClosed
        StrOutno = Trim(New clsConfig().IsNull(cboDocNo.ComboBox.SelectedValue, ""))

        If StrOutno.Length > 0 Then
            Call GetGOut(StrOutno)
            'Call DisableControl()
            Call CalculateTotal()
        End If
    End Sub

    Private Function GetGOut(ByVal strGOutNo As String) As Boolean
        Dim dt As DataTable = dbStockG.GetGOut(strGOutNo, clsuser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            Return True
        End If
        Return False
    End Function

    Private Sub BindData(ByVal dt As DataTable)
        txtOutNo.Text = dt.Rows(0)("outno").ToString.Trim
        txtDesignNo.Text = dt.Rows(0)("design_no").ToString.Trim
        CboDoc_type.SelectedValue = (dt.Rows(0)("outreqtyp").ToString)

        grdData.AutoGenerateColumns = False
        grdData.DataSource = dt
    End Sub

    Private Sub txtDesignNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDesignNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If GetGOutByDesign(txtDesignNo.Text.Trim) Then
                'Call DisableControl()
                Call CalculateTotal()
            Else
                'Call InitControl()
            End If
        End If
    End Sub
    Private Sub CalculateTotal()
        Dim dt As DataTable = grdData.DataSource

        Dim unselectedRolls As Integer = 0
        Dim unselectedKgs As Single = 0
        Dim unselectedMts As Single = 0
        Dim unselectedYds As Single = 0

        Dim selectedRolls As Single = 0
        Dim selectedKgs As Single = 0
        Dim selectedMts As Single = 0
        Dim selectedYds As Single = 0

        If Not dt Is Nothing Then
            For Each dr As DataRow In dt.Rows
                If dr("selected") = 0 Then
                    unselectedRolls += 1
                    unselectedKgs += dr("outkg_g")
                    unselectedMts += dr("outmt_g")
                    unselectedYds += dr("outyd_g")
                Else
                    selectedRolls += 1
                    selectedKgs += dr("outkg_g")
                    selectedMts += dr("outmt_g")
                    selectedYds += dr("outyd_g")
                End If
            Next
        End If

        txtUnselectedRolls.Text = unselectedRolls.ToString
        txtUnselectedKgs.Text = unselectedKgs.ToString
        txtUnselectedMts.Text = unselectedMts.ToString
        txtUnselectedYds.Text = unselectedYds.ToString

        txtSelectedRolls.Text = selectedRolls.ToString
        txtSelectedKgs.Text = selectedKgs.ToString
        txtSelectedMts.Text = selectedMts.ToString
        txtSelectedYds.Text = selectedYds.ToString
    End Sub
    Private Function GetGOutByDesign(ByVal strDesignNo As String) As Boolean
        Dim dt As DataTable = dbStockG.GetGOutByDesign(strDesignNo, clsuser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
            Return True
        End If
        Return False
    End Function
    Private Sub txtDesignNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDesignNo.TextChanged

    End Sub

    Private Sub txtRollNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRollNo.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If txtRollNo.Text = "NEW" Then
                Call btnNew_Click(sender, e)
                Exit Sub
            End If

            If txtOutNo.Text.Trim.Length = 0 Then Call FindRollNo(txtRollNo.Text)

            txtRollNo.Text = ""
            txtRollNo.Focus()
        End If
    End Sub
    Private Function FindRollNo(strRollNo As String)
        Dim dt As DataTable = grdData.DataSource

        For Each dr As DataRow In dt.Rows
            If strRollNo.Equals(dr("roll_no_g").ToString().Trim) Or strRollNo.Equals(dr("roll_no_o").ToString().Trim) Then
                dr("selected") = 1
                Call CalculateTotal()
                Return True
            End If
        Next

        Return False
    End Function
    Private Sub txtRollNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRollNo.TextChanged

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub
    Private Function FindMissingRollNo() As SelectedRollNo
        Dim dt As DataTable = grdData.DataSource
        Dim strRollNo As String = ""
        Dim found As Integer = 0

        For Each dr As DataRow In dt.Rows
            If dr("selected") = 0 Then
                strRollNo = dr("roll_no_g").ToString()
            Else
                found += 1
            End If
        Next

        If found = 0 Then Return SelectedRollNo.NoSelection
        If strRollNo.Length > 0 Then Return SelectedRollNo.PartialSelection
        Return SelectedRollNo.SelectAll
    End Function
    Private Enum SelectedRollNo
        NoSelection = 0
        PartialSelection = 1
        SelectAll = 2
    End Enum
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If CboDoc_type.Text = "" Then
                MsgBox("Please select Fabric delivery", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            Dim findResult As SelectedRollNo = FindMissingRollNo()
           
            Dim Doc_type As String = CboDoc_type.SelectedValue

            Dim objdb As New classStockG
            Dim dt As DataTable = grdData.DataSource


            Dim dt2 As DataTable
            dt2 = objdb.GetGOut("0", clsuser.UserID)

            grdData.AutoGenerateColumns = False
            If dt.Rows.Count > 0 Then
                Dim dt1 As DataTable = grdData.DataSource


                Dim dr As DataRow

                Dim msg As String = ""
                Dim i As Integer = 0
                Dim j As Integer = 0
                For i = 0 To dt.Rows.Count - 1
                    If (dt1.Rows(i)("selected").ToString) = True Then


                        dr = dt2.NewRow



                        For j = 0 To dt2.Columns.Count - 1
                            dr("design_no") = dt1.Rows(i)("design_no")
                            dr("gwth") = dt1.Rows(i)("gwth")
                            dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                            dr("roll_no_g") = dt1.Rows(i)("roll_no_g")
                            dr("col") = dt1.Rows(i)("col")
                            dr("loc") = dt1.Rows(i)("loc")
                            dr("outkg_g") = dt1.Rows(i)("outkg_g")
                            dr("outmt_g") = dt1.Rows(i)("outmt_g")
                            dr("outyd_g") = dt1.Rows(i)("outyd_g")
                            dr("gwth") = dt1.Rows(i)("gwth")
                            dr("gwth") = dt1.Rows(i)("gwth")
                            dr("grade") = dt1.Rows(i)("grade")
                            dr("outreqtyp") = Doc_type
                        Next
                        dt2.Rows.Add(dr)
                    End If
                Next

        End If
















        Try
                If dbStockG.SaveGOutManual(StrOutno, dt2, "", clsuser.UserID) Then
                    Call GenCboDocno()
                    Call InitControl()
                    cboDocNo.ComboBox.SelectedIndex = 0
                    Call cboDocNo_DropDownClosed(sender, e)
                    'txtOutNo.Text = StrOutno
                    Call GetGOut(StrOutno)
                    MessageBox.Show("Save Completed.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Data cannot be saved.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try





        End If







    End Sub

    Private Sub cboDocNo_Click(sender As System.Object, e As System.EventArgs) Handles cboDocNo.Click

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'MessageBox.Show("Access Denied.", "System Messaage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub
        Const rptFileName = "rptGOUTByDesign.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New classConnection
        
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@outnofr", txtOutNo.Text.Trim)
        rpt.SetParameterValue("@outnoto", txtOutNo.Text.Trim)
        rpt.SetParameterValue("@outdtfr", "")
        rpt.SetParameterValue("@outdtto", "")

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Out"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub

        If MessageBox.Show("Would you like to cancel G-Out No." + txtOutNo.Text.Trim + " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If dbStockG.CancelGOut(txtOutNo.Text.Trim, clsuser.UserID) Then
                MessageBox.Show(txtOutNo.Text.Trim + " is already cancelled.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class