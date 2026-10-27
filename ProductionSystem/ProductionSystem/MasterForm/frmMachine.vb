Public Class frmMachine
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Dim blnCancel As Boolean = False
    Dim dtMachines As New DataTable
    Dim bsMachines As New BindingSource
    Dim drvMachines As DataRowView

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub LoadData()
        Dim objDB As New classMaster

        dtMachines = objDB.GetMachineMaster(clsUser.UserID)
        For Each dc As DataColumn In dtMachines.Columns
            Select Case dc.ColumnName
                Case "active"
                    dc.DefaultValue = True
                Case "mtl_warehouse_id"
                    dc.DefaultValue = 4
                Case "warehouse_code"
                    dc.DefaultValue = "COLOMBO"
            End Select
        Next
        bsMachines.DataSource = dtMachines

        bsMachines.MoveFirst()
        dgvMachines.AutoGenerateColumns = False
        dgvMachines.DataSource = bsMachines
        ' If dt.Rows.Count > 0 Then

        '  Call BindGrid(dt)
        ' End If
    End Sub

    Private Sub SaveData()
        Dim objDB As New classMasterUpdate
        Dim errmsg As String = ""

        'If dgvMachines.CurrentCell.IsInEditMode Then
        '    Dim cell As DataGridViewCell = dgvMachines.CurrentCell
        '    dgvMachines.EndEdit(DataGridViewDataErrorContexts.Commit)
        '    dgvMachines.CurrentCell = dgvMachines.Rows(0).Cells(0)
        '    dgvMachines.CurrentCell = cell
        'End If

        If objDB.MachineSave(dtMachines, clsUser.UserID, errmsg) Then
            Call LoadData()
        Else
            MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub frmMachine_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call LoadData()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        bsMachines.EndEdit()

        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub
        ' If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        Call SaveData()
        'End If


    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        MessageBox.Show("Under Construction", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub grdData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMachines.CellDoubleClick
        Dim currentColIndex As Integer = dgvMachines.CurrentCell.ColumnIndex
        Dim currentColName As String = dgvMachines.Columns(currentColIndex).Name
        Dim dgr As DataGridViewRow = dgvMachines.CurrentRow
        If currentColName = "colMtlWarehouseId" Or currentColName = "colWarehouseCode" Then
            Dim frmSelectMtlWareHouse As New frmSelectMtlWareHouse
            frmSelectMtlWareHouse.ShowDialog(Me)
            If frmSelectMtlWareHouse.pblnOk = True Then
                dgr.Cells("colMtlWarehouseId").Value = frmSelectMtlWareHouse.pMtlwarehouseid
                dgr.Cells("colWareHouseCode").Value = frmSelectMtlWareHouse.pWarehouseCode
                ' dgr.Cells("colSourceSubinventoryId").Value = DBNull.Value
                ' dgr.Cells("colSourceSubInventoryCode").Value = DBNull.Value
            End If
        End If
    End Sub
End Class