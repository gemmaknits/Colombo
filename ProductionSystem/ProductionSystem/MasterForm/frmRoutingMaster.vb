Public Class frmRoutingMaster
    Dim clsuser As New classUserInfo
    Dim dtMfgRoutingHeader As New DataTable
    Dim bsMfgRoutingHeader As New BindingSource
    Dim drvMfgRoutingHeader As DataRowView

    Dim dtMfgRoutingLine As New DataTable
    Dim bsMfgRoutingLine As New BindingSource
    Dim drvMfgRoutingLine As DataRowView
    Dim oconfig As New clsConfig

    'Events & Actions
    Dim _UserEvents As String 'New or Edit
    Dim _UserAction As String 'Ok or Exit
    Public Property pUserEvents As String
        Get
            pUserEvents = _UserEvents
        End Get
        Set(ByVal Newvalue As String)
            _UserEvents = Newvalue
        End Set
    End Property
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property

    Private Sub InitControl()
        Call genCboinGrid()
        Call initDataBindingRoutingHeader(Nothing)
        Call initDataBindingRoutingLine(Nothing)
    End Sub
    Private Sub genCboinGrid()

        Dim objdb As New classRoutingMaster
        Dim dt As New DataTable
        dt = objdb.Getoperations(0)
        cbomfg_operation_id.DataSource = dt
        cbomfg_operation_id.ValueMember = "mfg_operations_id"
        cbomfg_operation_id.DisplayMember = "operation_name"

    End Sub
    Private Sub initDataBindingRoutingLine(Optional ByVal pMfgRoutingHeaderId As Nullable(Of Integer) = Nothing)
        Dim objDB As New classRoutingMaster

        dtMfgRoutingLine = objDB.selectRoutingLinesList(pMfgRoutingHeaderId)
        bsMfgRoutingLine.DataSource = dtMfgRoutingLine
        bsMfgRoutingLine.MoveFirst()
        drvMfgRoutingLine = CType(bsMfgRoutingLine.Current, DataRowView)

        dgvsMfgRoutingLine.AutoGenerateColumns = False
        dgvsMfgRoutingLine.DataSource = bsMfgRoutingLine

    End Sub
    Private Sub clearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            clearControlBindings(obj)
        Next
    End Sub
    Private Sub clearControlBindings(ByVal obj As Control)
        obj.DataBindings.Clear()
        If TypeOf obj Is TabControl Or TypeOf obj Is TabPage Or TypeOf obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                clearControlBindings(obj2)
            Next
        End If
    End Sub
    Private Sub initDataBindingRoutingHeader(Optional ByVal pMfgRoutingHeaderId As Nullable(Of Integer) = Nothing)
        Dim objDB As New classRoutingMaster

        Select Case _UserEvents.ToString.Trim
            Case "NEW", "EDIT"
                dtMfgRoutingHeader = objDB.selectRoutingHeaderRecord(pMfgRoutingHeaderId)
                If dtMfgRoutingHeader.Rows.Count = 0 Then
                    Dim drMfgRoutingHeader As DataRow = dtMfgRoutingHeader.NewRow
                    drMfgRoutingHeader("routing_status") = "DRAFT"
                    dtMfgRoutingHeader.Rows.Add(drMfgRoutingHeader)
                End If
        End Select

        bsMfgRoutingHeader.DataSource = dtMfgRoutingHeader
        bsMfgRoutingHeader.MoveFirst()
        drvMfgRoutingHeader = CType(bsMfgRoutingHeader.Current, DataRowView)
        clearDataBindings()

        txtRoutingCode.DataBindings.Add("text", bsMfgRoutingHeader, "routing_code")
        txtRoutingDesc.DataBindings.Add("text", bsMfgRoutingHeader, "routing_name")
        txtRoutingStatus.DataBindings.Add("text", bsMfgRoutingHeader, "routing_status")


    End Sub


    Private Sub frmRoutingMaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call genCboinGrid()
        _UserEvents = "NEW"
        Call initDataBindingRoutingHeader(Nothing)
        Call initDataBindingRoutingLine(Nothing)
        '   btnNew_Click(sender, e)

        'InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        BFsave()
    End Sub
    Private Sub BFsave()
        If dgvsMfgRoutingLine.Focus Then
            txtRoutingCode.Focus()
            dgvsMfgRoutingLine.EndEdit() 'Add By Neung 20151211 Fix Bug User
        End If

        If dgvsMfgRoutingLine.Rows.Count = 0 Then
            If MessageBox.Show("ยังไม่ได้ใส่ Oper Code", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop) Then
                Exit Sub
            End If
        End If

        If Save() Then

        Else

        End If

    End Sub

    Public Function Save() As Boolean
        Dim classRoutingMaster As New classRoutingMaster
        Dim mfg_routing_header As New classRoutingMaster.mfg_routing_header
        Dim config As New clsConfig

        'dtmfg_rounting_header.Rows(0)("mfg_routing_header_id").ToString()
        drvMfgRoutingHeader = CType(bsMfgRoutingHeader.Current, DataRowView)

        mfg_routing_header.mfg_routing_header_id = oconfig.IsNull(drvMfgRoutingHeader.Row("mfg_routing_header_id"), Nothing)
        mfg_routing_header.routing_code = txtRoutingCode.Text.Trim
        mfg_routing_header.routing_name = txtRoutingDesc.Text.Trim
        mfg_routing_header.routing_status = txtRoutingStatus.Text.Trim
        mfg_routing_header.created_by = clsuser.UserID
        mfg_routing_header.creation_date = Now
        mfg_routing_header.last_modified_by = clsuser.UserID
        mfg_routing_header.last_modified_date = Now

        Dim dv_data_add As New DataView(dtMfgRoutingLine, "", "", DataViewRowState.Added)
        Dim dv_data_upd As New DataView(dtMfgRoutingLine, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_data_del As New DataView(dtMfgRoutingLine, "", "", DataViewRowState.Deleted)

        'Dim dv_data_add As New DataView(dgvsMfgRoutingLine.DataSource, "", "", DataViewRowState.Added)
        'Dim dv_data_upd As New DataView(dgvsMfgRoutingLine.DataSource, "", "", DataViewRowState.ModifiedCurrent)
        'Dim dv_data_del As New DataView(dgvsMfgRoutingLine.DataSource, "", "", DataViewRowState.Deleted)

        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Function

        If classRoutingMaster.Savedata(mfg_routing_header, dv_data_add, dv_data_upd, dv_data_del, clsuser) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Call initDataBindingRoutingHeader(mfg_routing_header.mfg_routing_header_id)
            Call initDataBindingRoutingLine(mfg_routing_header.mfg_routing_header_id)
            Save = True
        Else
            MessageBox.Show(mfg_routing_header.message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            'Loaddata(mfg_routing_header.mfg_routing_header_id, Nothing)
            Save = False
        End If



    End Function

    Private Sub grddata_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsMfgRoutingLine.CellContentClick

    End Sub

    Private Sub grddata_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvsMfgRoutingLine.CellValueChanged
        'Dim objdb As New classRoutingMaster

        'If grddata.Columns(e.ColumnIndex).Name = "cbomfg_operation_id" Then

        '    Dim dgvcc As New DataGridViewComboBoxCell
        '    dgvcc = grddata.Rows(e.RowIndex).Cells("cbooperation_name")

        '    Try
        '        dgvcc.Value = grddata.Rows(e.RowIndex).Cells("cbomfg_operation_id").Value
        '    Catch ex As Exception
        '        dgvcc.Value = Nothing
        '    End Try
        'End If

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click

        Call genCboinGrid()
        _UserEvents = "NEW"
        Call initDataBindingRoutingHeader(Nothing)
        Call initDataBindingRoutingLine(Nothing)
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSeacthRouting_Click(sender As Object, e As EventArgs) Handles btnSeacthRouting.Click
        Dim frm As New frmSearchMFGRouting
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor

        If frm.pUserAction = "OK" Then
            Dim pMfgRoutingHeaderId As Int64 = (frm.pMfgRoutingHearder.mfg_routing_header_id)
            _UserEvents = "EDIT"
            Call initDataBindingRoutingHeader(pMfgRoutingHeaderId)
            Call initDataBindingRoutingLine(pMfgRoutingHeaderId)
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub
End Class