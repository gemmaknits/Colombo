Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class formYarnScrap
    Private dtKoYarn As DataTable
    Private dtItems As DataTable
    Dim clsUser As New classUserInfo
    Dim scAutoComplete As New AutoCompleteStringCollection

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub formYarnScrap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InitControl()
    End Sub

    Private Sub InitControl()
        Call GetKoNoAutoComplete()

        dtpscrap_date.Value = Now

        txtKono.AutoCompleteMode = AutoCompleteMode.Suggest
        txtKono.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtKono.AutoCompleteCustomSource = scAutoComplete


    End Sub

    Private Sub btnSearchKI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchKI.Click
        Dim formSearchKi As New formSearchKO
        Dim selectedKono As String
        selectedKono = formSearchKO.getKono

        If selectedKono <> "" Then
            Me.txtKono.Text = selectedKono
            getKOYarnDetails(selectedKono)
        End If
    End Sub

    Private Sub buildItemCombo(ByVal parKono)
        Dim tblItems As New tbl_Items
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        tblItems.itcd = ""

        Dim a As New DataGridViewComboBoxColumn
        'a = cboitcd
        ds = getDatayarn.getItemDataFromKI(parKono)
        If Not IsNothing(ds) Then
            'If Not dtKoYarn Is Nothing Then
            'dtKoYarn.Clear()
            'End If
            dtItems = ds.Tables(0)
            Me.cboitcd.DataSource = dtItems
            Me.cboitcd.DisplayMember = "itdesc2"
            Me.cboitcd.ValueMember = "Itcd"

            txtDesignNo.Text = dtItems.Rows(0)("design_no") 'Get Design No
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim scrap_uom As String
        Dim classUpdateYarn As New UpdateYarn
        Dim msgErr As String

        Dim resultSave As DialogResult
        resultSave = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If resultSave = DialogResult.Cancel Then Exit Sub
        If resultSave <> DialogResult.Yes Then Exit Sub

        Dim result As Boolean
        scrap_uom = "KGS"
        
        If Not CheckData() Then Exit Sub

        Dim dtc As DataTable = dgvYarnScrap.DataSource

        'For Each dtrow As DataRow
        'For i = 0 To dtc.Rows.Count - 1
        '    If dtc.Rows(i).RowState = DataRowState.Modified Or dtc.Rows(i).RowState = DataRowState.Added Then
        '        dtc.Rows(i)("scrap_date") = dtpscrap_date.Value
        '    End If
        'Next


        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        msgErr = ""
        result = classUpdateYarn.updateKoYarn(dv_dtc_add:=dv_dtc_add, _
                                              dv_dtc_upd:=dv_dtc_upd, _
                                              dv_dtc_del:=dv_dtc_del, _
                                              msgErr:=msgErr,
                                              USERID:=clsUser.UserID)
        If result = False Then
            MessageBox.Show(msgErr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

        Else
            MessageBox.Show("Changes were saved successfully", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            'MsgBox("Changes were saved successfully")
            Call getKOYarnDetails(txtKono.Text)
        End If
        'Me.Close()
    End Sub

    Private Function CheckData() As Boolean

        For i = 0 To dgvYarnScrap.Rows.Count - 2
            If Not Validate_ItemsInKO(StrKono:=txtKono.Text, Stritcd:=dgvYarnScrap.Rows(i).Cells("cboItcd").Value) Then
                MessageBox.Show("ไม่พบ Demand ของ " & (New clsConfig).IsNull(dgvYarnScrap.Rows(i).Cells("cboItcd").Value, "") & "ใน Production Order No. " & txtKono.Text _
                                , "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                CheckData = False
                Exit Function
            End If

        Next
        CheckData = True

    End Function

    Private Function Validate_ItemsInKO(Optional ByVal StrKono As String = "", Optional ByVal Stritcd As String = "") As Boolean
        Dim objdb As New GetDataYarn
        Dim dt As DataTable = objdb.Validate_ItemsInKO(StrKono, Stritcd, clsUser.UserID)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Items Code .: " & Stritcd & "............   is not in " & StrKono, "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub getKOYarnDetails(ByVal parKono As String)
        Dim getDatayarn As New GetDataYarn
        Dim ds As New DataSet
        Dim dt As New DataTable
        buildItemCombo("")
        ds = getDatayarn.getKOYarnDetails(parKono, paramscrap_date:=dtpscrap_date.Value)
        dt = ds.Tables(0)

        dgvYarnScrap.AutoGenerateColumns = False
        Me.dgvYarnScrap.DataSource = dt
        If dt.Rows.Count > 0 Then
            'txtDesignNo.Text = dt.Rows(0)("design_no") Disible Use Orther
            'dtpscrap_date.Value = dt.Rows(0)("scrap_date")

            If (New clsConfig).IsNull(dt.Rows(0)("scrap_date"), CDate("01/01/1900")) = CDate("01/01/1900") Then
                dtpscrap_date.Value = CDate("01/01/1900")
                dtpscrap_date.Checked = False
            Else
                dtpscrap_date.Value = dt.Rows(0)("scrap_date")
                dtpscrap_date.Checked = True
            End If

        End If
        buildItemCombo(parKono)
    End Sub

    Private Sub txtKono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKono.KeyDown
        If e.KeyCode = Keys.Enter Then
            getKOYarnDetails(txtKono.Text.Trim)
        End If
    End Sub

    Private Sub textKono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKono.KeyPress
        'If AscW(e.KeyChar) = Keys.Enter Or AscW(e.KeyChar) = Keys.Tab Then
        '    getKOYarnDetails(Me.txtKono.Text.Trim)
        'End If
    End Sub


    Private Sub textKono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKono.TextChanged
        'getKOYarnDetails(Me.textKono.Text.Trim)
    End Sub

    Private Sub dgvYarnScrap_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvYarnScrap.CellContentClick

    End Sub

    Private Sub dgvYarnScrap_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvYarnScrap.DefaultValuesNeeded
        e.Row.Cells("colkono").Value = Me.txtKono.Text.Trim
        e.Row.Cells("scrap_date").Value = DateTime.Now
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        For Each row As DataGridViewRow In dgvYarnScrap.SelectedRows
            dgvYarnScrap.Rows.Remove(row)
        Next
    End Sub

    Private Sub dtpscrap_date_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpscrap_date.KeyDown
        Dim selectedKono As String = txtKono.Text.Trim

        If e.KeyCode = Keys.Enter Then
            If selectedKono <> "" Then
                Me.txtKono.Text = selectedKono
                getKOYarnDetails(selectedKono)
            End If
        End If
    End Sub

    Private Sub dtpscrap_date_ValueChanged(sender As Object, e As EventArgs) Handles dtpscrap_date.ValueChanged

    End Sub


    Private Sub GetKoNoAutoComplete()
        Dim connStr As New classConnection
        Dim conn As New SqlConnection(connStr.Connection())
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        'Dim ds As New DataSet
        Dim cmd As New SqlCommand("select distinct kono from ko_yarn order by kono desc", conn)
        Dim dr As SqlDataReader
        conn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            scAutoComplete.Add(dr.GetString(0))
        Loop
        conn.Close()
    End Sub
End Class