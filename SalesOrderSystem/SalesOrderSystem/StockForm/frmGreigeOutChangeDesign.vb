Imports System.Data.SqlClient

Public Class frmGreigeOutChangeDesign
    Dim config As New clsConfig
    Dim clsUser As New classUserInfo
    Dim dbStockG As New classStockG
    Dim blnCancel As Boolean = False
    Dim dtGreigeDO As New DataTable
    Dim bsGreigeDO As New BindingSource
    Dim dtGreige As New DataTable
    Dim bsGreige As New BindingSource
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmGreigeChangeDesign_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call InitControl()
        Call InitDataBinding("")

        Call txtTranNoOld.Focus()

    End Sub

    Private Sub InitDataBinding(ByVal pOutno As String)

        dtGreigeDO = (New classGreigeOutChangeDesign).getData(pOutNo:=pOutno)
        bsGreigeDO.DataSource = dtGreigeDO
        grdDataGreigeDo.AutoGenerateColumns = False
        grdDataGreigeDo.DataSource = bsGreigeDO.DataSource

        Call BindingData() '

        dtGreige = (New classGreigeOutChangeDesign).getDataGreige(pTranNo:=txtTranNo.Text.Trim)
        bsGreige.DataSource = dtGreige
        grdDataGreige.AutoGenerateColumns = False
        grdDataGreige.DataSource = bsGreige.DataSource


    End Sub

    Private Sub BindingData()
        Call ClearDataBindings()

        txtTranNo.DataBindings.Add("text", bsGreigeDO, "tran_no")
        dtpOutDt.DataBindings.Add("text", bsGreigeDO, "outdt")
        txtPackNo.DataBindings.Add("text", bsGreigeDO, "packno")

        txtTranNoOld.DataBindings.Add("text", bsGreigeDO, "tran_no_old")
        If txtTranNoOld.Text.Length > 0 Then txtTranNoOld.Enabled = False
        txtDesignNoNew.DataBindings.Add("text", bsGreigeDO, "design_no_new")
        If txtDesignNoNew.Text.Length > 0 Then txtDesignNoNew.Enabled = False

    End Sub
    Public Sub ClearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            Call ClearControlBindings(obj)
        Next
    End Sub

    Private Sub ClearControlBindings(ByVal obj As Control)
        obj.DataBindings.Clear()
        If TypeOf obj Is TabControl Or TypeOf obj Is TabPage Or TypeOf obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                Call ClearControlBindings(obj2)
            Next
        End If

    End Sub


    Private Sub BindData(ByVal pOutNo As String)

        grdDataGreigeDo.AutoGenerateColumns = False
        grdDataGreigeDo.DataSource = (New classGreigeOutChangeDesign).getData(pOutNo)


    End Sub

    Private Sub BindDataText(ByVal dt As DataTable)

    End Sub
    Private Sub BindDataGreige(ByVal pTranNo As String)

        grdDataGreige.AutoGenerateColumns = False
        grdDataGreige.DataSource = (New classGreigeOutChangeDesign).getDataGreige(pTranNo)

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click

        Call InitControl()
        Call InitDataBinding("")
        Call txtTranNoOld.Focus()

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Me.Validate()

        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveData()

    End Sub
    Private Function CheckData() As Boolean

        If dtGreigeDO.Rows.Count = 0 Then
            MessageBox.Show("คุณยังไม่ได้ใส่ ข้อมูล Greige Out" + vbCrLf + vbCrLf + "Greige Out Data is missing", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If dtGreige.Rows.Count = 0 Then
            MessageBox.Show("คุณยังไม่ได้ใส่ ข้อมูล Greige IN" + vbCrLf + vbCrLf + "Greige IN Data is missing", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        For Each drGreige As DataRow In dtGreige.Rows
            If drGreige.RowState <> DataRowState.Deleted Then
                If (New clsConfig).IsNull(drGreige("design_no"), "") = "" Then
                    MessageBox.Show("คุณยังไม่ได้ใส่ ข้อมูล Design No (New)" + vbCrLf + vbCrLf + "Need Design No New Data", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If

                For Each drGreigeDO In dtGreigeDO.Rows
                    If drGreigeDO.RowState <> DataRowState.Deleted Then
                        If (New clsConfig).IsNull(drGreige("design_no"), "") = (New clsConfig).IsNull(drGreigeDO("design_no"), "") Then
                            MessageBox.Show("คุณยังไม่ได้ใส่ เปลี่ยน Design No (New)" + vbCrLf + vbCrLf + "Design No not Change", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If
                Next

                'If (New clsConfig).IsNull(drGreige("design_no"), "") = "" Then
                '    MessageBox.Show("คุณยังไม่ได้ใส่ ข้อมูล Design No (New)" + vbCrLf + vbCrLf + "Need Design No New Data", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                '    Return False
                'End If

            End If
        Next

        'For Each drv As DataGridViewRow In grdDataGreigeDo.Rows
        '    If (New clsConfig).IsNull(drv.Cells("design_no_new").Value, "") = "" Then
        '        MessageBox.Show("คุณยังไม่ได้ใส่ ข้อมูล Design No (New)" + vbCrLf + vbCrLf + "Need Design No New Data", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Return False
        '    End If
        'Next

        Return True
    End Function

    Private Function SaveData() As Boolean
        Dim OldTranNo As String = txtTranNoOld.Text.Trim
        Dim NewDesignNo As String = txtDesignNoNew.Text.Trim
        Dim NewOutno As String = txtOutNo.Text
        Dim NewGInNo As String = txtTranNo.Text
        Dim NewPackno As String = txtPackNo.Text
        Dim Message As String = ""

        If (New classGreigeOutChangeDesign).SaveGreigeChangeDesign(OldTranNo:=OldTranNo,
                                                                   NewDesignNo:=NewDesignNo,
                                                                logempcd:=clsUser.UserID,
                                                                    NewOutno:=NewOutno,
                                                                   Outdt:=dtpOutDt.Value,
                                                                   Packno:=NewPackno,
                                                                   NewTranNo:=NewGInNo,
                                                                dtGreigeDo:=dtGreigeDO,
                                                                   dtGreige:=dtGreige,
                                                     Message:=Message) Then
            MessageBox.Show("บันทักสำเร็จ " & vbCrLf &
                            "Out No. : " & NewOutno &
                            vbCrLf &
                            "G-IN No. : " & NewGInNo, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOutNo.Text = NewOutno
            txtTranNo.Text = NewGInNo
            Call InitDataBinding(txtOutNo.Text.Trim)
            Return True
        Else
            MessageBox.Show(Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs)
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub
        Const rptFileName = "rptGOUT.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New classConnection
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
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

    Private Sub btnPrint2_Click(sender As System.Object, e As System.EventArgs)
        If txtTranNo.Text.Trim.Length = 0 Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New classConnection
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trannofr", txtTranNo.Text.Trim)
        rpt.SetParameterValue("@trannoto", txtTranNo.Text.Trim)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige IN"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtGINNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTranNoOld.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not getGreigetoChangeDesignNo(txtTranNoOld.Text.Trim) Then
                txtTranNoOld.Enabled = True
                txtTranNoOld.Clear()
            Else
                txtTranNoOld.Enabled = False
            End If
        End If


    End Sub

    Private Function getGreigetoChangeDesignNo(ByVal pTranNo As String) As Boolean
        grdDataGreigeDo.AutoGenerateColumns = False

        Dim pErrMessage As String = ""
        Dim dtNew As DataTable = (New classGreigeOutChangeDesign).getGreigetoChangeDesignNo(pTranNo, pErrMessage)
        ' Dim dtOld As DataTable = grdDataGreigeDo.DataSource

        If (New clsConfig).IsNull(pErrMessage, "").Length > 0 Then
            MessageBox.Show(pErrMessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If dtNew.Rows.Count > 0 Then
            For Each drNew As DataRow In dtNew.Rows
                dtGreigeDO.ImportRow(drNew)
            Next
        End If

        If dtNew.Rows.Count > 0 Then
            For Each drNew As DataRow In dtNew.Rows
                drNew("roll_no") = ""
                dtGreige.ImportRow(drNew)
            Next
        End If


        Me.Validate()
        Return True
    End Function

    Private Function getNewDesign(ByVal pTranNo As String) As Boolean
        grdDataGreigeDo.AutoGenerateColumns = False

        Dim pErrMessage As String = ""
        Dim dtNew As DataTable = (New classGreigeOutChangeDesign).ValidateDesignNew(pTranNo, pErrMessage)
        'Dim dtOld As DataTable = grdDataGreigeDo.DataSource

        If (New clsConfig).IsNull(pErrMessage, "").Length > 0 Then
            MessageBox.Show(pErrMessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If dtNew.Rows.Count > 0 Then
            For Each drold As DataRow In dtGreige.Rows
                drold("design_no") = txtDesignNoNew.Text.Trim
            Next
        End If


        Me.Validate()
        Return True
    End Function

    Private Sub txtDesignNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDesignNoNew.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not getNewDesign(txtDesignNoNew.Text.Trim) Then
                txtDesignNoNew.Enabled = True
                txtDesignNoNew.Clear()
            Else
                txtDesignNoNew.Enabled = False
            End If
        End If
    End Sub

    Private Sub btncopyRoll_Click(sender As Object, e As EventArgs) Handles btncopyRoll.Click
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to copy Current Roll?" + vbCrLf + "คุณต้องการ ก๊อปปี้ ม้วนหรือไม่?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        Call GetcopyRollNo()

    End Sub

    Private Function GetcopyRollNo() As Boolean
        ' Dim dtc As DataTable = grdDataGreigeDo.DataSource
        Dim newrow As DataRow
        If grdDataGreigeDo.Rows.Count > 0 Then

            newrow = dtGreige.NewRow
            newrow.Item("tran_no") = grdDataGreige.CurrentRow.Cells("grdDataGreigeTranNo").Value
            'newrow.Item("roll_no") = grdDataGreige.CurrentRow.Cells("grdDataGreigeRollNo").Value
            newrow.Item("roll_no_g") = grdDataGreige.CurrentRow.Cells("grdDataGreigeRollNoG").Value
            newrow.Item("roll_no_o") = grdDataGreige.CurrentRow.Cells("grdDataGreigeRollNoO").Value
            newrow.Item("design_no") = grdDataGreige.CurrentRow.Cells("grdDataGreigeDesignNo").Value
            newrow.Item("kg") = grdDataGreige.CurrentRow.Cells("grdDataGreigekg").Value
            newrow.Item("mts") = grdDataGreige.CurrentRow.Cells("grdDataGreigemts").Value
            newrow.Item("yds") = grdDataGreige.CurrentRow.Cells("grdDataGreigeyds").Value


            dtGreige.Rows.Add(newrow)

            Return True


        End If

        Return False

    End Function

    Private Sub txtGOUTNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOutNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call InitDataBinding(txtOutNo.Text.Trim)
        End If
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()


    End Sub


    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag

        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
            dtp.Checked = False
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
            If chk.Name = "chkAutoCalculate" Then chk.Checked = True

        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next

    End Sub

    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DataGridView Then
            Dim grd As DataGridView = Obj
            grd.ReadOnly = Not blnEnabled
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If

    End Sub


    Private Sub SetErrorProvider()
        ErrorProvider1.Clear()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtTranNo_TextChanged(sender As Object, e As EventArgs) Handles txtTranNo.TextChanged

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to cancel document no. " & txtOutNo.Text.Trim & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataCancel() Then Exit Sub

        Dim message As String = ""


        If (New classGreigeOutChangeDesign).CancelGOut(pOutno:=txtOutNo.Text.Trim, pTranno:=txtTranNo.Text,
                                                       plogempcd:=clsUser.UserID, pMessage:=message) Then
            MessageBox.Show(txtOutNo.Text.Trim + " is already cancelled.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call InitControl()
            Call InitDataBinding("")
            Call txtTranNoOld.Focus()
        Else
            MessageBox.Show(message, "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Function CheckDataCancel() As Boolean
        If txtTranNoOld.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก D IN No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function

    Private Sub BtnPrintBarcode_Click(sender As Object, e As EventArgs)
        Dim clsconn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGreigeBarcode.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtTranNoOld.Text)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrintGOUT_Click(sender As Object, e As EventArgs) Handles btnPrintGOUT.Click
        If txtOutNo.Text.Trim.Length = 0 Then Exit Sub
        Const rptFileName = "rptGOUT.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New classConnection
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
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

    Private Sub btnPrintGIN_Click(sender As Object, e As EventArgs) Handles btnPrintGIN.Click
        If txtTranNo.Text.Trim.Length = 0 Then Exit Sub
        Const rptFileName = "rptGIN.rpt"
        Dim clsConfig As New clsConfig
        Dim clsConn As New classConnection
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@trannofr", txtTranNo.Text.Trim)
        rpt.SetParameterValue("@trannoto", txtTranNo.Text.Trim)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige IN"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintTagToolStripMenuItem.Click
        Dim clsconn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGreigeBarcode.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsconn.servername, clsconn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsconn.Userid, clsconn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtTranNo.Text)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

End Class