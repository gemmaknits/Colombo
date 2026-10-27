
Public Class frmOperationsMaster
       Dim clsuser As new classUserInfo
    Dim dtmfg_operations As DataTable

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property

    Private Sub InitControl()
        Loaddata(0)

    End Sub
    Private Sub Loaddata(ByVal Intmfg_operations_id As Nullable(Of Integer))
        Dim objDB As New classOperations

        dtmfg_operations = Nothing
        dtmfg_operations = objDB.Getoperations(Intmfg_operations_id)

        grddata.AutoGenerateColumns = False
        grddata.DataSource = dtmfg_operations

        cbomfg_operations_id.DataSource = grddata.DataSource
        cbomfg_operations_id.ValueMember = "mfg_operations_id"
        cbomfg_operations_id.DisplayMember = "operation_code"

        cbooperation_name.DataSource = grddata.DataSource
        cbooperation_name.ValueMember = "mfg_operations_id"
        cbooperation_name.DisplayMember = "operation_name"
        'Binddata(dtmfg_operations)

    End Sub

    Private Sub Binddata(ByVal dtmfg_operations As DataTable)
        Dim config As New clsConfig

        If dtmfg_operations.Rows.Count > 0 Then
            grddata.AutoGenerateColumns = False
            grddata.DataSource = dtmfg_operations

            cbomfg_operations_id.DataSource = dtmfg_operations
            cbomfg_operations_id.ValueMember = "mfg_operations_id"
            cbomfg_operations_id.DisplayMember = "mfg_operations_id"

            cbooperation_name.DataSource = dtmfg_operations
            cbooperation_name.ValueMember = "operation_name"
            cbooperation_name.DisplayMember = "mfg_operations_id"

        Else


        End If


    End Sub

    Private Sub frmOperationsMaster_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControl()
    End Sub


    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = System.Windows.Forms.DialogResult.No Then Exit Sub
        If SaveData() Then

            Call Loaddata(0)
        Else

        End If
    End Sub

    Public Function SaveData() As Boolean
        Dim config As New clsConfig
        Dim objdb As New classOperations
        Dim mfg_operationsHeader As New classOperations.mfg_operationsHeader


        'Call Updatetextbox(txtRemark.Text, dtdoc_attachments)


        Dim dtv_add As New DataView(dtmfg_operations, "", "", DataViewRowState.Added)
        Dim dtv_upd As New DataView(dtmfg_operations, "", "", DataViewRowState.ModifiedCurrent)
        Dim dtv_del As New DataView(dtmfg_operations, "", "", DataViewRowState.Deleted)

        'PhotoHeader.id = dtPhoto.Rows(RowsNo)("id")
        'PhotoHeader.docno = dtPhoto.Rows(RowsNo)("docno")
        ' PhotoHeader.source_doc_type = Strsource_doc_number
        'PhotoHeader.filepath = dtPhoto.Rows(RowsNo)("filepath")
        'PhotoHeader.filename = dtPhoto.Rows(RowsNo)("filename")
        'PhotoHeader.filetype = dtPhoto.Rows(RowsNo)("filetype")
        'PhotoHeader.filetype = dt.Rows(RowsNo)("filetype")
        'PhotoHeader.remark = txtRemark.Text.Trim
        ' PhotoHeader.image = txtImage.Text.Trim

        mfg_operationsHeader.message = ""

        If objdb.SaveOperationsMaster(mfg_operationsHeader, dtmfg_operations, dtv_add, dtv_upd, dtv_del, clsuser) Then
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Return True
        Else
            MessageBox.Show("Save is not Complete! : บันทึกไม่สำเร็จ! " & mfg_operationsHeader.message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If


    End Function

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class