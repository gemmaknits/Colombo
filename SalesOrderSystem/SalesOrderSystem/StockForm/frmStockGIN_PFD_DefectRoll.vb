Imports System.Text

Public Class frmStockGIN_PFD_DefectRoll
    'Parameter
    Private clsUser As New classUserInfo
    Private _TranNo As String
    Private _TranDt As String

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Public Property TranNo() As String
        Get
            TranNo = _TranNo
        End Get
        Set(ByVal NewValue As String)
            _TranNo = NewValue
        End Set
    End Property
    Public Property TranDt() As String
        Get
            TranDt = _TranDt
        End Get
        Set(ByVal NewValue As String)
            _TranDt = NewValue
        End Set
    End Property


    'Local Variable
    Private objDB As New classStockG
    Private dtGIn As DataTable
    Private dtDefectRoll As DataTable
    Private bsSearchTable As New BindingSource

    Private Sub frmStockDefectRollGIN_PFD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGINNo.Text = _TranNo
        txtGInDate.Text = _TranDt

        '1. Get All Roll Data to show in left datagrid
        getGreigeRollData()
        If dtGIn.Rows.Count > 0 Then
            '2. Get All Defect Roll to datatable
            With grdRollGInPFD
                getDefectRollData()
            End With
        Else
            grdDefectRollGInPFD.Rows.Clear() 'Clear right datagrid
        End If
    End Sub
    Private Sub getGreigeRollData()
        dtGIn = objDB.getGreigeRollData(_TranNo, "preset")
        If dtGIn.Rows.Count > 0 Then
            With grdRollGInPFD
                .AutoGenerateColumns = False
                .DataSource = dtGIn
            End With
        End If
    End Sub
    Private Sub fillerDefectRollData(pRollNo As String)
        Dim FilterExp As New StringBuilder

        FilterExp.Append("roll_no = '" & pRollNo & "'")
        bsSearchTable.Filter = FilterExp.ToString
    End Sub
    Private Sub getDefectRollData()
        dtDefectRoll = objDB.getGreigeRollDefectData(_TranNo, "")
        'If dtDefectRoll.Rows.Count > 0 Then
        With grdDefectRollGInPFD
                .AutoGenerateColumns = False

                bsSearchTable.DataSource = dtDefectRoll
                .DataSource = bsSearchTable
                bsSearchTable.MoveFirst()
            End With
            With grdRollGInPFD
                fillerDefectRollData(.Rows(.CurrentRow.Index).Cells("roll_no").Value) 'Show Defect of current Roll No
            End With
        'End If
    End Sub
    Private Sub grdRollGInPFD_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdRollGInPFD.CellClick
        With grdRollGInPFD
            If .RowCount > 0 Then
                fillerDefectRollData(.Rows(.CurrentRow.Index).Cells("roll_no").Value)
            End If
        End With
    End Sub

    Private Function getRowNo()
        Dim RowNO As Integer = 0
        With dtDefectRoll
            For i As Integer = 0 To dtDefectRoll.Rows.Count

            Next
        End With
        Return RowNO
    End Function
    Private Sub tsbtnNewLine_Click(sender As Object, e As EventArgs) Handles tsbtnNewLine.Click
        Dim OfrmStockGIN_PFD_EntryDefectRoll As New frmStockGIN_PFD_EntryDefectRoll

        With grdRollGInPFD
            If .RowCount > 0 Then

                OfrmStockGIN_PFD_EntryDefectRoll.NewRow = True
                OfrmStockGIN_PFD_EntryDefectRoll.TranNo = txtGINNo.Text.Trim
                OfrmStockGIN_PFD_EntryDefectRoll.RollNo = .Rows(.CurrentRow.Index).Cells("roll_no").Value
                OfrmStockGIN_PFD_EntryDefectRoll.dtDefectRoll = dtDefectRoll
                With dtDefectRoll
                    If .Rows.Count > 0 Then
                        OfrmStockGIN_PFD_EntryDefectRoll.RowNo = dtDefectRoll.Rows.Count
                    Else
                        OfrmStockGIN_PFD_EntryDefectRoll.RowNo = 0
                    End If
                End With

                OfrmStockGIN_PFD_EntryDefectRoll.ShowDialog()
            End If
        End With
    End Sub

    Private Sub tsbtnEditLine_Click(sender As Object, e As EventArgs) Handles tsbtnEditLine.Click
        With grdRollGInPFD
            If .RowCount > 0 Then
                Dim OfrmStockGIN_PFD_EntryDefectRoll As New frmStockGIN_PFD_EntryDefectRoll
                OfrmStockGIN_PFD_EntryDefectRoll.NewRow = False
                OfrmStockGIN_PFD_EntryDefectRoll.RowNo = .CurrentRow.Index
                OfrmStockGIN_PFD_EntryDefectRoll.TranNo = txtGINNo.Text.Trim
                OfrmStockGIN_PFD_EntryDefectRoll.RollNo = .Rows(.CurrentRow.Index).Cells("roll_no").Value
                OfrmStockGIN_PFD_EntryDefectRoll.dtDefectRoll = dtDefectRoll
                OfrmStockGIN_PFD_EntryDefectRoll.ShowDialog()
            End If
        End With
    End Sub

    Private Sub tsbtnDeleteLine_Click(sender As Object, e As EventArgs) Handles tsbtnDeleteLine.Click
        If dtDefectRoll.Rows.Count > 0 Then
            If MessageBox.Show("คุณ ยืนยันที่จะลบข้อมูล รายการนี้ใช่หรือไม่ ?", "ยืนยันการลบข้อมูล" _
                               , MessageBoxButtons.OKCancel, MessageBoxIcon.Question _
                               , MessageBoxDefaultButton.Button2
                                ) = vbOK Then
                Dim CurRow As DataRow
                CurRow = dtDefectRoll.Rows(grdDefectRollGInPFD.CurrentRow.Index)
                dtDefectRoll.Rows.Remove(CurRow)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim oClassStockG As New classStockG
        Dim ErrMsg As String = ""

        If dtDefectRoll.Rows.Count = 0 Then
            MessageBox.Show("คุณต้องสร้างรายการก่อนครับ", "ข้อผิดพลาด" _
                            , MessageBoxButtons.OK, MessageBoxIcon.Error
                            )
        Else
            If MessageBox.Show("คืนยืนยันที่จะสร้าง Defect ใช่หรือไม่ ?" _
                          , "ยืนยันการสร้าง Defect " _
                          , MessageBoxButtons.OKCancel _
                          , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
                           ) = vbOK Then
                'Dim dv_add As New DataView(grdDefectRollGInPFD.DataSource, "", "", DataViewRowState.Added)
                ' Dim dv_upd As New DataView(grdDefectRollGInPFD.DataSource, "", "", DataViewRowState.ModifiedCurrent)
                'Dim dv_del As New DataView(grdDefectRollGInPFD.DataSource, "", "", DataViewRowState.Deleted)

                If oClassStockG.updateGreigeDefectRoll(dtDefectRoll, ErrMsg) Then
                    MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้วครับ", "ผลการบันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ ให้คุณลองบันทึกอีกครั้งครับ" & vbCr & ErrMsg _
                                  , "ผลการบันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class