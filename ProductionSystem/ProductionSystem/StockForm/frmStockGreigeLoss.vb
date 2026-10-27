Public Class frmStockGreigeLoss
       Dim clsuser As new classUserInfo
    Dim dtGreige As New DataTable
    Dim bsGreige As New BindingSource
    Dim drvGregie As DataRowView

    Dim dtGreigeLog As New DataTable
    Dim bsGregieLog As New BindingSource
    Dim drvGregieLog As DataRowView

    Dim dtGreigeLogDet As New DataTable
    Dim bsGregieLogDet As New BindingSource
    Dim drvGregieLogDet As DataRowView

    Dim blnCancel As Boolean = False
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property

    Private Sub frmStockGINDefect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitControl()
        Call GenComBo()
        Call InitDataBindingGreige(txtsystem_lot_number.Text.Trim)
        Call InitDataBindingGreigeLog()
        Call InitDataBindingGreigeLogDet()

        txtsystem_lot_number.Select()
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

        If Obj.Name = "btnApply" Then
            Obj.Enabled = blnEnabled
        End If


    End Sub


    Private Sub SetErrorProvider()
        ErrorProvider1.Clear()
    End Sub

    Private Sub GenComBo()

    End Sub
    Private Sub InitDataBindingGreige(ByVal pSystemLotNumber As String)

        dtGreige = (New classStockGreigeLoss).getGreige(pSystemLotNumber:=pSystemLotNumber)
        'If dtGreige Is Nothing Then Exit Sub 'ไม่เจอ ข้อมูล ให้ออก
        bsGreige.DataSource = dtGreige
        bsGreige.MoveFirst()
        drvGregie = CType(bsGreige.Current, DataRowView)

        Call BinddataGreige()
        txtsystem_lot_number.SelectAll()
    End Sub

    Private Sub InitDataBindingGreigeLog()

        dtGreigeLog = (New classStockGreigeLoss).getGreigeLog(pLogId:=txtLogId.Text)
        bsGregieLog.DataSource = dtGreigeLog
        bsGregieLog.MoveFirst()
        drvGregieLog = CType(bsGregieLog.Current, DataRowView)

        If drvGregieLog Is Nothing Then 'Auto Insert New Row If Not Data
            dtGreigeLog.Rows.Add(dtGreigeLog.NewRow())
            bsGregieLog.MoveFirst()
            drvGregieLog = CType(bsGregieLog.Current, DataRowView)
        End If

        Call BindDataGreigeLog()

    End Sub

    Private Sub InitDataBindingGreigeLogDet()
        dtGreigeLogDet = (New classStockGreigeLoss).getGreigeLogDet(pLogId:=txtLogId.Text)
        bsGregieLogDet.DataSource = dtGreigeLogDet
        bsGregieLogDet.MoveFirst()
        drvGregieLogDet = CType(bsGregieLogDet.Current, DataRowView)

        grdGregieLogDet.AutoGenerateColumns = False
        grdGregieLogDet.DataSource = bsGregieLogDet
        'Call BindDataGreigeLogDet()

    End Sub

    Private Sub BinddataGreige()
        Call ClearDataBindings()

        txtsystem_lot_number.DataBindings.Add("text", bsGreige, "system_lot_number")
        txtadjust_loss_kg.DataBindings.Add("text", bsGreige, "adjust_loss_kg")
        txtqc_loss_kg.DataBindings.Add("text", bsGreige, "qc_loss_kg")
        txtdyed_loss_kg.DataBindings.Add("text", bsGreige, "dyed_loss_kg")
        txtlab_loss_kg.DataBindings.Add("text", bsGreige, "lab_loss_kg")
        txtdefect_loss_kg.DataBindings.Add("text", bsGreige, "defect_loss_kg")

    End Sub
    Private Sub BindDataGreigeLog()
        Call ClearDataBindings()

        txtLogId.DataBindings.Add("text", bsGregieLog, "log_id")
        dtpLogDate.DataBindings.Add("text", bsGregieLog, "log_date")

    End Sub

    Private Sub BindDataGreigeLogDet()
        'Call ClearDataBindings()

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

    Private Sub txtsystem_lot_number_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsystem_lot_number.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call InitDataBindingGreige(pSystemLotNumber:=txtsystem_lot_number.Text.Trim)
            txtadjust_loss_kg.Focus()
        End If
    End Sub

    Private Sub txtLogId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLogId.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call InitDataBindingGreige(pSystemLotNumber:="")
            Call InitDataBindingGreigeLog()
            Call InitDataBindingGreigeLogDet()
            Call EnabledControl(False)
        End If
    End Sub

    Private Sub lblsystem_lot_number_Click(sender As Object, e As EventArgs) Handles lblsystem_lot_number.Click

    End Sub

    Private Sub txtsystem_lot_number_TextChanged(sender As Object, e As EventArgs) Handles txtsystem_lot_number.TextChanged

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Call ApplyData()
    End Sub

    Private Sub ApplyData()

        If Not CheckIsDupicateSystemRow(drvGregie) Then

            bsGreige.EndEdit()
            dtGreigeLogDet.ImportRow(drvGregie.Row)
            Call InitDataBindingGreige(pSystemLotNumber:="")
            txtsystem_lot_number.Focus()
        End If

    End Sub
    Private Function CheckIsDupicateSystemRow(ByVal drvGregieNew As DataRowView) As Boolean
        Dim result As Boolean = True

        For Each drv As DataRow In dtGreigeLogDet.Rows
            If drv("system_lot_number").Equals(drvGregieNew.Row("system_lot_number")) Then
                result = True
                Return result
            End If
        Next

        result = False
        Return result
    End Function

    Private Sub CalculateSumAndCount(ByVal grd As DataGridView)

        Dim Sum As Decimal
        Dim Count As Int64 = 0
        For Each dgvc As DataGridViewCell In grd.SelectedCells
            If VarType(dgvc.Value) = VariantType.Decimal Or VarType(dgvc.Value) = VariantType.Integer Or VarType(dgvc.Value) = VariantType.Double Then
                Sum = Sum + dgvc.Value
            End If
            Count = Count + 1
        Next

        lblSum.Text = Sum
        lblCount.Text = Count
    End Sub

    Private Sub grdGregieLogDet_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdGregieLogDet.CellMouseUp
        Call CalculateSumAndCount(grd:=grdGregieLogDet)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        blnCancel = False
        Dim result As DialogResult 'Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveData()
    End Sub

    Private Function SaveData() As Boolean
        Dim msgerr As String = ""
        bsGregieLog.EndEdit()
        bsGregieLogDet.EndEdit()

        If (New classStockGreigeLoss).SaveData(drvGreigeLog:=drvGregieLog, dtGreigeLogDet:=dtGreigeLogDet, Userinfo:=UserInfo, msgerr:=msgerr) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLogId.Text = drvGregieLog.Row("log_id").ToString
            ErrorProvider1.Clear()
            Call InitDataBindingGreige(pSystemLotNumber:="")
            Call InitDataBindingGreigeLog()
            Call InitDataBindingGreigeLogDet()
            Call EnabledControl(False)
            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If


    End Function

    Private Sub grdGregieLogDet_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdGregieLogDet.CellDoubleClick
        Dim currentColIndex As Integer = grdGregieLogDet.CurrentCell.ColumnIndex
        Dim currentColName As String = grdGregieLogDet.Columns(currentColIndex).Name
        Dim dgr As DataGridViewRow = grdGregieLogDet.CurrentRow
        If currentColName = "colAdjustLossKg" Then
            Dim frm As New formEnterNumber
            frm.ShowDialog(Me)
            If frm.pInt <> "" Then
                dgr.Cells("colAdjustLossKg").Value = frm.pInt
            End If
        End If
        If currentColName = "colQcLossKg" Then
            Dim frm As New formEnterNumber
            frm.ShowDialog(Me)
            If frm.pInt <> "" Then
                dgr.Cells("colQcLossKg").Value = frm.pInt
            End If
        End If
        If currentColName = "colDyedLossKg" Then
            Dim frm As New formEnterNumber
            frm.ShowDialog(Me)
            If frm.pInt <> "" Then
                dgr.Cells("colDyedLossKg").Value = frm.pInt
            End If
        End If
        If currentColName = "colLabLossKg" Then
            Dim frm As New formEnterNumber
            frm.ShowDialog(Me)
            If frm.pInt <> "" Then
                dgr.Cells("colLabLossKg").Value = frm.pInt
            End If
        End If
        If currentColName = "colDefectLossKg" Then
            Dim frm As New formEnterNumber
            frm.ShowDialog(Me)
            If frm.pInt <> "" Then
                dgr.Cells("colDefectLossKg").Value = frm.pInt
            End If
        End If
    End Sub

    Private Sub txtadjust_loss_kg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtadjust_loss_kg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ApplyData()
        End If
    End Sub

    Private Sub txtqc_loss_kg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqc_loss_kg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ApplyData()
        End If
    End Sub

    Private Sub txtdyed_loss_kg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdyed_loss_kg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ApplyData()
        End If
    End Sub

    Private Sub txtlab_loss_kg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtlab_loss_kg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ApplyData()
        End If
    End Sub

    Private Sub txtdefect_loss_kg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdefect_loss_kg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call ApplyData()
        End If
    End Sub

    Private Function CheckData() As Boolean
        Dim result As Boolean = True

        Return result
    End Function

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call InitControl()
        Call GenComBo()
        Call InitDataBindingGreige(txtsystem_lot_number.Text.Trim)
        Call InitDataBindingGreigeLog()
        Call InitDataBindingGreigeLogDet()
        ' bsGregieLog.AddNew()
        '  bsGregieLog.EndEdit()
        txtsystem_lot_number.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call PrintDocument()
    End Sub

    Private Sub PrintDocument()
        Dim clsConn As New classConnection
        Dim rptFileName As String = "rptGreigeLoss.rpt"

        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not (New clsConfig).CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@log_id", txtLogId.Text.Trim)

        frm.Title = "Gregie Loss"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class