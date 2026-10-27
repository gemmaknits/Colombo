Imports System.Windows.Forms

Public Class DlgGetMasterCode
    'Form Parameter
    Private DataForFind As String = ""


    'For returnCMR_Number
    Private CustCd As String = ""
    Private CustName As String = ""

    '--- Get And Set Data
    '--- Get And Set Data -- For return Customer
    Public Property pCustCd As String
        Get
            pCustCd = CustCd
        End Get
        Set(ByVal Newvalue As String)
            CustCd = Newvalue
        End Set
    End Property
    Public Property pCustName As String
        Get
            pCustName = CustName
        End Get
        Set(ByVal Newvalue As String)
            CustName = Newvalue
        End Set
    End Property

    '--- Get And Set Data -- For returnSoNo

    '--- Get And Set Data -- For returnDesign


    '--- Get And Set Data -- For returnMasDyeFinFormula, returnDesign


    '--- Get And Set Data -- For returnEndBuyer

    '---

    Public Sub New(p_DataForFind As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataForFind = p_DataForFind
    End Sub


    Private Sub DlgGetMasterCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DataForFind.Trim = "" Then
            MessageBox.Show("โปรแกรมเมอร์ไม่ได้ระบุตารางที่จะให้แสดง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
        End If
        InitForm()
        CreateDGVHeader()
        getAndShowDataRec(DataForFind)
        txtSearch.Focus()
    End Sub
    Private Sub InitForm()
        Dim boundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim boundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim x As Integer = 0
        Dim y As Integer = 0

        Select Case DataForFind.ToUpper
            Case "Customer".ToUpper
                Me.Width = 450
                Me.Height = 650
                Me.Text = "Customer Header"
        End Select
        x = boundWidth - Me.Width
        y = boundHeight - Me.Height
        Me.Location = New Point(x / 2, y / 2)
    End Sub
    '--- Create Grid Header
    Private Sub CreateDGVHeader()
        Select Case DataForFind.ToUpper
            Case "Customer".ToUpper
                createCustomerGrd()
        End Select
    End Sub
    Private Sub createCustomerGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("custcd", "Customer Code")
            .Columns.Add("name", "Customer name")

            .Columns("Runno").Width = 30                'ลำดับ
            .Columns("custcd").Width = 60               'Customer Code
            .Columns("name").Width = 250                'Customer name

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("custcd").DataPropertyName = "custcd"
            .Columns("custcd").DataPropertyName = "custcd"
            .Columns("custcd").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("name").DataPropertyName = "name"
            .Columns("name").DataPropertyName = "name"

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub


    '--- Get Data Insert Into Grid
    Private Sub getAndShowDataRec(DataForFind As String)
        Dim objDB As New classMaster
        Dim dt As New DataTable

        Select Case DataForFind.ToUpper
            Case "Customer".ToUpper
                dt = objDB.GetCustomer(custcd)
        End Select

        If dt.Rows.Count > 0 Then
            grdData.AutoGenerateColumns = False
            grdData.DataSource = dt
        Else
            grdData.DataSource = Nothing
        End If
    End Sub

    '--- Return Data 
    Private Sub returnCustomer()
        With grdData
            custcd = .Rows(.CurrentRow.Index).Cells("custcd").Value.ToString.Trim
            custName = .Rows(.CurrentRow.Index).Cells("name").Value.ToString.Trim
        End With
    End Sub


    Private Function ChangeBlankTosStrZero(p_value As String)
        Dim ValueReturn As String = ""
        If p_value = "" Then
            ValueReturn = "0"
        Else
            ValueReturn = p_value
        End If
        Return ValueReturn
    End Function


    Public Function findRowIDGrd(BeginRowIdx As Integer, ColIdx As Integer, valToFind As String) As Integer
        Dim RowId As Integer = -1

        Try
            With grdData
                If .Rows.Count > 0 And BeginRowIdx < .Rows.Count Then
                    Dim SearchWithinThis As String = ""
                    For i As Integer = BeginRowIdx + 1 To .Rows.Count - 1
                        For j As Integer = 1 To grdData.ColumnCount - 1
                            SearchWithinThis = grdData.Rows(i).Cells(j).Value.ToString.ToUpper
                            If SearchWithinThis.IndexOf(valToFind.ToUpper) <> -1 Then
                                RowId = i
                                .CurrentCell = .Rows(RowId).Cells(j)
                                Exit For
                            End If
                        Next

                        'If valToFind.ToUpper Like (.Rows(i).Cells(ColIdx).Value.ToString.ToUpper) Then
                        '    RowId = i
                        '    .CurrentCell = .Rows(RowId).Cells(ColIdx)
                        '    Exit For
                        'End If
                    Next
                End If
            End With
        Catch ex As Exception

        End Try

        findRowIDGrd = RowId
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
                        FoundIdxRow = findRowIDGrd(CurIdxRow, CurIdxCol, txtSearch.Text.Trim)

                        If FoundIdxRow = -1 Then
                            MessageBox.Show("ไม่พบข้อมูลที่ค้นหา", "รายงานผล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            .CurrentCell = .Rows(FoundIdxRow).Cells(CurIdxCol)
                        End If
                    End If
                End With
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub ReturnSelectValueAndCloseDlg()
        If grdData.Rows.Count > 0 Then
            Select Case DataForFind.ToUpper
                Case "CUSTOMER".ToUpper
                    returnCustomer()
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


End Class
