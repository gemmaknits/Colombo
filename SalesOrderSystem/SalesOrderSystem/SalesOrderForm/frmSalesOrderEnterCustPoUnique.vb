Public Class frmSalesOrderEnterCustPoUnique
    Dim StrCustPoUnique As String
    Dim StrSoNo As String
    Dim blnCancel As Boolean = False
    Public Property pCustPoUnique As String
        Get
            pCustPoUnique = StrCustPoUnique
        End Get
        Set(ByVal Newvalue As String)
            StrCustPoUnique = Newvalue
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
    Public Property pblnCancel As Boolean
        Get
            pblnCancel = blnCancel
        End Get
        Set(ByVal newValue As Boolean)
            blnCancel = newValue
        End Set
    End Property

    Private Sub frmSalesOrderEnterCustPo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call GenAutoComplete()
        txtCustPoUnique.Text = pCustPoUnique
        txtCustPoUnique.Select()

    End Sub

    Private Sub GenAutoComplete()

        Dim dtCustPoUnique As DataTable = (New classSaleOrderEnterCustPoUnique).GetCustPoUnique()
        Dim rowCustPoUnique As DataRow
        txtCustPoUnique.AutoCompleteSource = AutoCompleteSource.None
        txtCustPoUnique.AutoCompleteMode = AutoCompleteMode.None
        txtCustPoUnique.AutoCompleteCustomSource.Clear()
        For Each rowCustPoUnique In dtCustPoUnique.Rows
            txtCustPoUnique.AutoCompleteCustomSource.Add(rowCustPoUnique.Item("custpo_unique").ToString())
        Next
        txtCustPoUnique.AutoCompleteSource = AutoCompleteSource.CustomSource
        'txtPoNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCustPoUnique.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

        Call CheckCustPOUnique()

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        pblnCancel = True
        Me.Close()
    End Sub

    Private Sub txtCustPo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCustPoUnique.KeyDown
        If e.KeyCode = Keys.Enter Then

            Call CheckCustPOUnique()

        End If
    End Sub

    Private Sub CheckCustPOUnique()
        If txtCustPoUnique.Text.Trim = "" Then
            pCustPoUnique = txtCustPoUnique.Text.Trim
            pblnCancel = False
            Me.Close()
            Exit Sub
        End If

        If (New classSaleOrderEnterCustPoUnique).ValidateCustPoUnique(StrSono:=pSoNo, StrCustPoUnique:=txtCustPoUnique.Text.Trim) Then
            pCustPoUnique = txtCustPoUnique.Text.Trim
            pblnCancel = False
        Else
            Dim StrSoNoExist As String = (New classSaleOrderEnterCustPoUnique).GetSONoExist(StrSono:=pSoNo, StrCustPoUnique:=txtCustPoUnique.Text.Trim)
            MessageBox.Show("เลข P/O นี้ ตรวจพบ มีการทำ S/O แล้ว เลขที่ " + StrSoNoExist, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            pblnCancel = True
        End If
        Me.Close()
    End Sub
End Class