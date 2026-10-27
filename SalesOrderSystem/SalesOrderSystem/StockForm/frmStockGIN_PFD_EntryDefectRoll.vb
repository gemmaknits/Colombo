Public Class frmStockGIN_PFD_EntryDefectRoll
    Dim oConn As New classConnection
    'Parameter in form
    Private _TranNo As String
    Private _id_defect_roll As Integer
    Private _RollNo As String
    Private _NewRow As Boolean = False
    Private _RowNo As Integer = 0
    Private _dtDefectRoll As DataTable

    Public Property TranNo() As String
        Get
            TranNo = _TranNo
        End Get
        Set(ByVal NewValue As String)
            _TranNo = NewValue
        End Set
    End Property
    Public Property id_defect_roll() As Integer
        Get
            id_defect_roll = _id_defect_roll
        End Get
        Set(ByVal NewValue As Integer)
            _id_defect_roll = NewValue
        End Set
    End Property
    Public Property RollNo() As String
        Get
            RollNo = _RollNo
        End Get
        Set(ByVal NewValue As String)
            _RollNo = NewValue
        End Set
    End Property
    Public Property dtDefectRoll() As DataTable
        Get
            dtDefectRoll = _dtDefectRoll
        End Get
        Set(ByVal NewValue As DataTable)
            _dtDefectRoll = NewValue
        End Set
    End Property
    Public Property NewRow As Boolean
        Get
            NewRow = _NewRow
        End Get
        Set(ByVal Newvalue As Boolean)
            _NewRow = Newvalue
        End Set
    End Property
    Public Property RowNo As Integer
        Get
            RowNo = _RowNo
        End Get
        Set(ByVal Newvalue As Integer)
            _RowNo = Newvalue
        End Set
    End Property

    'Variable in form
    Private Const UomMtsId As Integer = 14
    Private UomId As Integer = 0

    Private Sub frmStockGIN_PFD_EntryDefectRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGINNo.Text = _TranNo
        txtRollNo.Text = _RollNo
        txtStockCode.Text = "G"

        If _NewRow Then
            'Case Create New And AssignValue To New Row

        Else
            'Case Edit Data
            If _RowNo >= 0 Then
                AssignDataValueToObj()
            End If
        End If
    End Sub
    Private Sub AssignDataValueToObj()
        With _dtDefectRoll
            txtDefectCode.Text = .Rows(_RowNo)("defect_code")
            txtDefectName.Text = .Rows(_RowNo)("defect_name")
            txtDefectDetails.Text = .Rows(_RowNo)("defect_details")
            txtLengthStart.Text = .Rows(_RowNo)("length_start")
            txtLengthDefect.Text = .Rows(_RowNo)("length_defect") * 100
            'txtu.Text = .Rows(_RowNo)("") 'UOM_ID
            txtDefectRemark.Text = .Rows(_RowNo)("defect_remark")
        End With
    End Sub
    Private Function ChkIntKey(ByVal PC_ChrValue As String)
        Dim NumberIntArray() As Integer = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim VL_ReturnValue As Boolean = False

        Select Case PC_ChrValue
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "."
                VL_ReturnValue = True
            Case vbBack, vbCr
                VL_ReturnValue = True
            Case Else
                VL_ReturnValue = False
                MessageBox.Show("ให้ป้อนตัวเลข 0 - 9 เท่านั้น", "ข้อความเตือนการป้อนข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        Return VL_ReturnValue
    End Function
    Private Sub txtDefectDetails_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDefectDetails.KeyPress
        If ChkIntKey(e.KeyChar) = False Then
            e.KeyChar = Nothing
        End If
    End Sub
    Private Sub txtLengthStart_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLengthStart.KeyPress
        If ChkIntKey(e.KeyChar) = False Then
            e.KeyChar = Nothing
        End If
    End Sub
    Private Sub txtLengthDefect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLengthDefect.KeyPress
        If ChkIntKey(e.KeyChar) = False Then
            e.KeyChar = Nothing
        End If
    End Sub
    Private Sub btnGetDefectCode_Click(sender As Object, e As EventArgs) Handles btnGetDefectCode.Click
        'Writen by : Sitthana 20190401
        Dim f As New Classes.frmSearchDefectCode
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use de    fault connection string inside the class or pass your connection object if need to use different from default.

        f.setConnectionString(oConn.getSQLConnection)
        f.OrderBy = "defect_code" '"defect_code", "defect_name"
        f.logempcd = "Sitthana"
        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()

        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtDefectCode.Text = drv.Item("defect_code")
            txtDefectName.Text = drv.Item("defect_name")
        End If
    End Sub

    Private Sub btnSelectUOM_Click(sender As Object, e As EventArgs)
        Dim f As New Classes.frmSearchUomByClass
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use de    fault connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(oConn.getSQLConnection)
        f.UomCode = "" '"defect_code", "defect_name"
        f.logempcd = "Sitthana"
        f.Close()
        f.Dispose()

        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            'txtUomName.Text = drv.Item("uom")
        End If
    End Sub
    Private Sub assignValToNewDataRow(pCurRow As DataRow)
        With _dtDefectRoll
            pCurRow("tran_no") = _TranNo
            pCurRow("roll_no") = _RollNo
            pCurRow("defect_code") = txtDefectCode.Text.Trim
            pCurRow("defect_name") = txtDefectName.Text.Trim
            pCurRow("defect_details") = txtDefectDetails.Text.Trim
            pCurRow("stock_code") = txtStockCode.Text.Trim
            pCurRow("length_start") = IIf(txtLengthStart.Text.Trim = "", 0, Convert.ToDouble(txtLengthStart.Text.Trim))
            pCurRow("length_end") = IIf(txtLengthStart.Text.Trim = "", 0, Convert.ToDouble(txtLengthStart.Text.Trim))
            pCurRow("length_defect") = IIf(txtLengthDefect.Text.Trim = "", 0, Convert.ToDouble(txtLengthDefect.Text.Trim)) / 100
            pCurRow("uom_id") = UomMtsId
            pCurRow("uom_name") = "Mts"
            pCurRow("defect_remark") = txtDefectRemark.Text.Trim
        End With
    End Sub

    'Create Or UpdateDataRow
    Private Sub UpdateCurDataRow()
        With _dtDefectRoll
            .Rows(_RowNo)("defect_code") = txtDefectCode.Text.Trim
            .Rows(_RowNo)("defect_details") = txtDefectDetails.Text.Trim
            .Rows(_RowNo)("length_start") = IIf(txtLengthStart.Text.Trim = "", 0, Convert.ToDouble(txtLengthStart.Text.Trim))
            .Rows(_RowNo)("length_end") = IIf(txtLengthStart.Text.Trim = "", 0, Convert.ToDouble(txtLengthStart.Text.Trim))
            .Rows(_RowNo)("length_defect") = IIf(txtLengthDefect.Text.Trim = "", 0, Convert.ToDouble(txtLengthDefect.Text.Trim)) / 100
            .Rows(_RowNo)("defect_remark") = txtDefectRemark.Text.Trim
        End With
    End Sub
    Private Sub CreateNewRec()
        Dim CurRow As DataRow

        With _dtDefectRoll    'change 
            CurRow = .NewRow()
            assignValToNewDataRow(CurRow)
            .Rows.Add(CurRow)
        End With
    End Sub
    Private Function CheckData() As Boolean
        Dim ErrMsg As String = ""
        Dim i As Byte = 0

        If txtDefectCode.Text.Trim = "" Then
            i += 1
            ErrMsg &= Chr(13) & Space(5) & i.ToString.Trim & ") " & "ยังไม่ได้ระบุ Defect Code"
        End If
        If txtDefectDetails.Text.Trim = "" Then
            i += 1
            ErrMsg &= Chr(13) & Space(5) & i.ToString.Trim & ") " & "ยังไม่ได้ระบุ จำนวนที่เกิด Defect"
        End If
        If txtLengthStart.Text.Trim = "" Then
            i += 1
            ErrMsg &= Chr(13) & Space(5) & i.ToString.Trim & ") " & "ยังไม่ได้ระบุ เมตรที่เกิด Defect"
        End If
        If txtLengthDefect.Text.Trim = "" Then
            i += 1
            ErrMsg &= Chr(13) & Space(5) & i.ToString.Trim & ") " & "ยังไม่ได้ระบุ ว่าส่วนที่เสีย ยาวกี่ เซนติเมตร"
        Else
            If Convert.ToDouble(txtLengthDefect.Text.Trim) = 0 Then
                i += 1
                ErrMsg &= Chr(13) & Space(5) & i.ToString.Trim & ") " & "ส่วนที่เสีย ต้องมากกว่า 0"
            ElseIf Convert.ToDouble(txtLengthDefect.Text.Trim) > 100 Then
                i += 1
                ErrMsg &= Chr(13) & Space(5) & i.ToString.Trim & ") " & "ส่วนที่เสียในช่วง 1 เมตร  ต้องไม่มากกว่า 100 เซนติเมตร"
            End If
        End If
        If ErrMsg.Trim = "" Then
            CheckData = True
        Else
            CheckData = False
            MessageBox.Show("ข้อผิดพลาด" & vbCr & ErrMsg, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return CheckData
    End Function
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Not CheckData() Then Exit Sub
        If _NewRow Then
            CreateNewRec()
        Else
            UpdateCurDataRow()
        End If
        dtDefectRoll = _dtDefectRoll
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MessageBox.Show("คุณยืนยันที่จะออกจากการ เพิ่ม/แก้ไขข้อมูล ใช่หรือไม่ ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = vbOK Then
            Me.Close()
        End If
    End Sub


End Class