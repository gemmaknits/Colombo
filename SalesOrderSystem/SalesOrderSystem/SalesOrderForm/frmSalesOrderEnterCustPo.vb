Public Class frmSalesOrderEnterCustPo
    Dim StrCustPo As String
    Dim StrSoNo As String
    Public Property pCustPo As String
        Get
            pCustPo = StrCustPo
        End Get
        Set(ByVal Newvalue As String)
            StrCustPo = Newvalue
        End Set
    End Property
    Public Property pSoNo As String
        Get
            pSoNo = StrSoNo
        End Get
        Set(ByVal Newvalue As String)
            StrSoNo = Newvalue
        End Set
    End Property

    Private Sub frmSalesOrderEnterCustPo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call GenAutoComplete()
        txtCustPo.Text = pCustPo
        txtCustPo.Select()

    End Sub

    Private Sub GenAutoComplete()

        Dim dtCustPo As DataTable = (New classSaleOrderEnterCustPo).GetCustPo()
        Dim rowCustPo As DataRow
        txtCustPo.AutoCompleteSource = AutoCompleteSource.None
        txtCustPo.AutoCompleteMode = AutoCompleteMode.None
        txtCustPo.AutoCompleteCustomSource.Clear()
        For Each rowCustPo In dtCustPo.Rows
            txtCustPo.AutoCompleteCustomSource.Add(rowCustPo.Item("custpo").ToString())
        Next
        txtCustPo.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtPoNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCustPo.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        ' If txtCustPo.Text.Trim.Length > 0 Then
        If (New classSaleOrderEnterCustPo).ValidateCustPo(StrSono:=pSoNo, StrCustPo:=txtCustPo.Text.Trim) Then
            pCustPo = txtCustPo.Text.Trim
        Else
            Dim StrSoNoExist As String = (New classSaleOrderEnterCustPo).GetSONoExist(StrSono:=pSoNo, StrCustPo:=txtCustPo.Text.Trim)
            MessageBox.Show("There is a duplicate Customer P/O with S/O No. " + StrSoNoExist, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
        ' End If
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtCustPo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCustPo.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If txtCustPo.Text.Trim.Length > 0 Then
            If (New classSaleOrderEnterCustPo).ValidateCustPo(StrSono:=pSoNo, StrCustPo:=txtCustPo.Text.Trim) Then
                pCustPo = txtCustPo.Text.Trim
            Else
                Dim StrSoNoExist As String = (New classSaleOrderEnterCustPo).GetSONoExist(StrSono:=pSoNo, StrCustPo:=txtCustPo.Text.Trim)
                MessageBox.Show("เลข P/O นี้ ตรวจพบ มีการทำ S/O แล้ว เลขที่ " + StrSoNoExist, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            'End If
            Me.Close()
        End If
    End Sub
End Class