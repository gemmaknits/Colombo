Imports System.Windows.Forms

Public Class DlgGetMasterCode
    'Form Parameter
    Private DataForFind As String = ""
    Private dt As New DataTable

    'ToDo: Step 1
    'For Parameter
    '-- returnDesignBeam
    Private _DesignBeam As String = ""
    Private _DesignBeamDesc As String = ""

    '-- returnDesignBeam
    Private _DesignBobins As String = ""
    Private _DesignBobinsDesc As String = ""

    '-- returnArticleKnitting
    Private _ArticleKnitting As String = ""

    '-- returnDataForFindSystemLotNumber
    Private _SystemLotNumber As String = ""

    'For DataForFind
    Private Const DataForFindDesignBeam As String = "DesignBeam"
    Private Const DataForFindDesignBobins As String = "DesignBobins"
    Private Const DataForFindArticleKnitting As String = "ArticleKnitting"
    Private Const DataForFindSystemLotNumber As String = "SystemLotNumber"

    '--- Get And Set Data

    '--- Get And Set Data -- For returnDesignBeam
    'ToDo: Step 2
    Public Property pDesignBeam As String
        Get
            pDesignBeam = _DesignBeam
        End Get
        Set(ByVal Newvalue As String)
            _DesignBeam = Newvalue
        End Set
    End Property
    Public Property pDesignBeamDesc As String
        Get
            pDesignBeamDesc = _DesignBeamDesc
        End Get
        Set(ByVal Newvalue As String)
            _DesignBeamDesc = Newvalue
        End Set
    End Property

    Public Property pDesignBobins As String
        Get
            pDesignBobins = _DesignBobins
        End Get
        Set(ByVal Newvalue As String)
            _DesignBobins = Newvalue
        End Set
    End Property
    Public Property pDesignBobinsDesc As String
        Get
            pDesignBobinsDesc = _DesignBobinsDesc
        End Get
        Set(ByVal Newvalue As String)
            _DesignBobinsDesc = Newvalue
        End Set
    End Property
    Public Property pArticleKnitting As String
        Get
            pArticleKnitting = _ArticleKnitting
        End Get
        Set(ByVal Newvalue As String)
            _ArticleKnitting = Newvalue
        End Set
    End Property
    Public Property pSystemLotNumber As String
        Get
            pSystemLotNumber = _SystemLotNumber
        End Get
        Set(ByVal Newvalue As String)
            _SystemLotNumber = Newvalue
        End Set
    End Property

    'Program Start 
    Public Sub New(pDataForFind As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataForFind = pDataForFind
    End Sub


    Private Sub DlgGetMasterCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DataForFind.Trim = "" Then
            MessageBox.Show("โปรแกรมเมอร์ไม่ได้ระบุตารางที่จะให้แสดง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
        End If
        InitForm()
        CreateDGVHeader()
        getAndShowDataRec(DataForFind, _DesignBeam)
        txtSearch.Focus()
    End Sub
    Private Sub InitForm()
        Dim boundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim boundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim x As Integer = 0
        Dim y As Integer = 0

        'ToDo: Step 3
        Select Case DataForFind
            Case DataForFindDesignBeam
                Me.Width = 700
                Me.Height = 650
                Me.Text = "Design Beam"
            Case DataForFindDesignBobins
                Me.Width = 700
                Me.Height = 650
                Me.Text = "Design Robins"
            Case DataForFindArticleKnitting
                Me.Width = 700
                Me.Height = 650
                Me.Text = "Article Knitting"
            Case DataForFindSystemLotNumber
                Me.Width = 700
                Me.Height = 650
                Me.Text = "System Lot Number"
                Label5.Visible = False
                Label4.Visible = False
                txtDescription.Visible = False
        End Select
        x = boundWidth - Me.Width
        y = boundHeight - Me.Height
        Me.Location = New Point(x / 2, y / 2)
    End Sub
    '--- Create Grid Header
    Private Sub CreateDGVHeader()
        'ToDo: Step 4
        Select Case DataForFind
            Case DataForFindDesignBeam
                createDesignBeamGrd()
            Case DataForFindDesignBobins
                createDesignBobinsGrd()
            Case DataForFindArticleKnitting
                createArticleKnittingGrd()
            Case DataForFindSystemLotNumber
                createSystemLotNumberGrd()
        End Select
    End Sub
    Private Sub createDesignBeamGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("design_no", "Design Beam")
            .Columns.Add("design_desc", "Description")

            .Columns("Runno").Width = 30                   'ลำดับ
            .Columns("design_no").Width = 110              'Design Beam
            .Columns("design_desc").Width = 300            'Description

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("design_no").DataPropertyName = "design_no"
            .Columns("design_no").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("design_desc").DataPropertyName = "design_desc"

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    Private Sub createDesignBobinsGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("design_Bobins", "Design Bobin")
            .Columns.Add("design_Bobinsdesc", "Description")

            .Columns("Runno").Width = 30                   'ลำดับ
            .Columns("design_Bobins").Width = 100          'Design Bobin
            .Columns("design_Bobinsdesc").Width = 400      'Description

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("design_Bobins").DataPropertyName = "design_Bobins"
            .Columns("design_Bobins").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("design_Bobinsdesc").DataPropertyName = "design_Bobinsdesc"

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    Private Sub createArticleKnittingGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("design_cross", "Article Knitting")

            .Columns("Runno").Width = 30                   'ลำดับ
            .Columns("design_cross").Width = 150           'Article Knitting

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("design_cross").DataPropertyName = "design_cross"

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    Private Sub createSystemLotNumberGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("System_Lot_Number", "System Lot Number")

            .Columns("Runno").Width = 30                   'ลำดับ
            .Columns("System_Lot_Number").Width = 150           'Article Knitting

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("System_Lot_Number").DataPropertyName = "System_Lot_Number"

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    '--- Get Data Insert Into Grid
    Private Sub getAndShowDataRec(pValToFind As String, p_cmr_number As String)
        Dim objDB As New classProduction

        'ToDo: Step 5
        Select Case DataForFind
            Case DataForFindDesignBeam
                dt = objDB.comboKoDesignItems("WO", "")
            Case DataForFindDesignBobins
                dt = objDB.comboKoYarnchangeItems("WO", "")
            Case DataForFindArticleKnitting
                dt = objDB.comboKoDesignCross("WO", "")
            Case DataForFindSystemLotNumber
                dt = objDB.comboKoSystemLotNumber("WO", "")
        End Select

        If dt.Rows.Count > 0 Then
            grdData.AutoGenerateColumns = False
            grdData.DataSource = dt
            AssignRowNoToGrd
        Else
            grdData.DataSource = Nothing
        End If
    End Sub
    Private Sub AssignRowNoToGrd()
        With grdData
            If .Rows.Count > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i).Cells(0).Value = i + 1
                Next
            End If
        End With
    End Sub

    '--- Return Data 
    'ToDo: Step 6
    Private Sub returnDesignBeam()
        With grdData
            _DesignBeam = .Rows(.CurrentRow.Index).Cells("design_no").Value.ToString.Trim
            _DesignBeamDesc = .Rows(.CurrentRow.Index).Cells("design_desc").Value.ToString.Trim
        End With
    End Sub
    Private Sub returnDesignBobins()
        With grdData
            _DesignBobins = .Rows(.CurrentRow.Index).Cells("design_Bobins").Value.ToString.Trim
            _DesignBobinsDesc = .Rows(.CurrentRow.Index).Cells("design_Bobinsdesc").Value.ToString.Trim
        End With
    End Sub
    Private Sub returnArticleKnitting()
        With grdData
            _ArticleKnitting = .Rows(.CurrentRow.Index).Cells("design_cross").Value.ToString.Trim
        End With
    End Sub
    Private Sub returnSystemLotNumber()
        With grdData
            _SystemLotNumber = .Rows(.CurrentRow.Index).Cells("System_Lot_Number").Value.ToString.Trim
        End With
    End Sub


    'Find Data In Grd
    Public Function findRowIDGrd(BeginRowIdx As Integer, ColIdx As Integer, valToFind As String) As Boolean
        Dim RowId As Integer = -1

        Try
            With grdData
                If .Rows.Count > 0 And BeginRowIdx < .Rows.Count Then
                    Dim SearchWithinThis As String = ""
                    Dim i As Integer = 0
                    Dim J As Integer = 0

                    For i = BeginRowIdx + 1 To .Rows.Count
                        For J = 1 To .ColumnCount - 1
                            If IsNothing(.Rows(i).Cells(J).Value) = False Then
                                SearchWithinThis = .Rows(i).Cells(J).Value.ToString.ToUpper
                                If SearchWithinThis.IndexOf(valToFind.ToUpper) <> -1 Then
                                    RowId = i
                                    .CurrentCell = .Rows(RowId).Cells(J)
                                    .CurrentCell = .Rows(i).Cells(J)
                                    findRowIDGrd = True
                                    Exit Function
                                End If
                            End If
                        Next J
                    Next i
                End If
            End With
        Catch ex As Exception

        End Try

        findRowIDGrd = False
    End Function
    Private Sub MoveToFindValueCell()
        Try
            With grdData
                If .Rows.Count > 0 Then
                    Dim CurIdxRow As Integer = .CurrentRow.Index
                    Dim CurIdxCol As Integer = .CurrentCell.ColumnIndex
                    Dim FoundIdxRow As Integer = 0

                    If CurIdxCol = 0 Then CurIdxCol = 1
                    FoundIdxRow = findRowIDGrd(CurIdxRow, CurIdxCol, txtSearch.Text.Trim)

                    If FoundIdxRow >= 0 And CurIdxCol >= 0 Then
                        .CurrentCell = .Rows(FoundIdxRow).Cells(CurIdxCol)
                    End If
                End If

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = vbCr Then
            Try
                With grdData
                    If .Rows.Count > 0 Then
                        Dim CurIdxRow As Integer = .CurrentRow.Index
                        Dim CurIdxCol As Integer = .CurrentCell.ColumnIndex
                        Dim FoundIdxRow As Integer = 0

                        If CurIdxCol = 0 Then CurIdxCol = 1
                        'FoundIdxRow = findRowIDGrd(CurIdxRow, CurIdxCol, txtSearch.Text.Trim)

                        If findRowIDGrd(CurIdxRow, CurIdxCol, txtSearch.Text.Trim) = False Then
                            MessageBox.Show("ไม่พบข้อมูลที่ค้นหา", "รายงานผล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            '.CurrentCell = .Rows(FoundIdxRow).Cells(CurIdxCol)
                        End If
                    End If
                End With
            Catch ex As Exception

            End Try
        End If
    End Sub

    'ToDo: Step 7
    Private Sub ReturnSelectValueAndCloseDlg()
        If grdData.Rows.Count > 0 Then
            Select Case DataForFind
                Case DataForFindDesignBeam
                    returnDesignBeam()
                Case DataForFindDesignBobins
                    returnDesignBobins()
                Case DataForFindArticleKnitting
                    returnArticleKnitting()
                Case DataForFindSystemLotNumber
                    returnSystemLotNumber()
            End Select
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ReturnSelectValueAndCloseDlg()
    End Sub
    Private Sub grdData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        ReturnSelectValueAndCloseDlg()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MoveToFoundCol(pCurIdxRow As Integer, pCurIdxCol As Integer, ptxtSearch As String)
        Dim FoundIdxRow As Integer = 0

        FoundIdxRow = findRowIDGrd(pCurIdxRow, pCurIdxCol, ptxtSearch)

        If FoundIdxRow = -1 Then
            'MessageBox.Show("ไม่พบข้อมูลที่ค้นหา", "รายงานผล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            grdData.CurrentCell = grdData.Rows(FoundIdxRow).Cells(pCurIdxCol)
        End If
    End Sub
    Private Sub btnBeginFirstRecFind_Click(sender As Object, e As EventArgs) Handles btnBeginFirstRecFind.Click
        If grdData.Rows.Count > 0 Then
            MoveToFoundCol(0, 0, txtSearch.Text.Trim)
        End If
    End Sub
    Private Sub DataFilter(pCodeOrDescp As String)
        Dim dv As DataView = Nothing

        Select Case DataForFind
            Case DataForFindDesignBeam
                If txtWordFilter.Text.Trim = "" And txtDescription.Text.Trim = "" Then
                    dv = New DataView(dt)
                Else
                    If pCodeOrDescp = "Code" Then
                        dv = New DataView(dt, "design_no like  '%" & txtWordFilter.Text.Trim & "%' ", "design_no", DataViewRowState.CurrentRows)
                    Else
                        dv = New DataView(dt, "design_desc like  '%" & txtDescription.Text.Trim & "%' ", "design_desc", DataViewRowState.CurrentRows)
                    End If
                End If
            Case DataForFindDesignBobins
                If txtWordFilter.Text.Trim = "" And txtDescription.Text.Trim = "" Then
                    dv = New DataView(dt)
                Else
                    If pCodeOrDescp = "Code" Then
                        dv = New DataView(dt, "design_Bobins like  '%" & txtWordFilter.Text.Trim & "%' ", "design_Bobins", DataViewRowState.CurrentRows)
                    Else
                        dv = New DataView(dt, "design_Bobinsdesc like  '%" & txtDescription.Text.Trim & "%' ", "design_Bobinsdesc", DataViewRowState.CurrentRows)
                    End If

                End If
            Case DataForFindArticleKnitting
                If txtWordFilter.Text.Trim = "" Then
                    dv = New DataView(dt)
                Else
                    dv = New DataView(dt, "design_cross like  '%" & txtWordFilter.Text.Trim & "%' ", "design_cross  ", DataViewRowState.CurrentRows)
                End If
            Case DataForFindSystemLotNumber
                If txtWordFilter.Text.Trim = "" Then
                    dv = New DataView(dt)
                Else
                    dv = New DataView(dt, "System_Lot_Number like  '%" & txtWordFilter.Text.Trim & "%' ", "System_Lot_Number", DataViewRowState.CurrentRows)
                End If
        End Select

        grdData.DataSource = dv
    End Sub
    Private Sub txtWordFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtWordFilter.KeyDown
        If rbFillterWhenEnter.Checked Then
            If e.KeyValue = vbCr Then
                DataFilter("Code")
            End If
        End If
    End Sub

    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        If rbFillterWhenKey.Checked Then
            DataFilter("Code")
        End If
    End Sub

    Private Sub txtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescription.KeyDown
        'If rbFillterWhenKey.Checked Then
        '    DataFilter("Desp")
        'End If
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        If rbFillterWhenKey.Checked Then
            DataFilter("Desp")
        End If
    End Sub
End Class
