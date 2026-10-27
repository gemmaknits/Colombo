Public Class frmEndBuyers
    Dim dtEndBuyers As DataTable
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub frmEndBuyers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()

    End Sub

    Private Sub InitControl()
        Dim objdb As New classMaster

        Call GenComBo()

        dtEndBuyers = objdb.GetEndBuyersByID(strEndBuyerCD:=Nothing, Int64EndBuyerid:=0)

        If dtEndBuyers.Rows.Count > 0 Then
            txtendbuyerid.Text = dtEndBuyers.Rows(0)("endbuyerid")
            txtendbuyercd.Text = dtEndBuyers.Rows(0)("endbuyercd")
            txtendbuyername.Text = dtEndBuyers.Rows(0)("endbuyername")

            cboEndBuyers.ComboBox.Text = dtEndBuyers.Rows(0)("endbuyername")
        Else
            txtendbuyerid.Text = 0
            txtendbuyercd.Text = ""
            txtendbuyername.Text = ""

            cboEndBuyers.SelectedIndex = -1
        End If

        ' txtendbuyerid.Text = 0
        ' txtendbuyercd.Text = ""
        ' txtendbuyername.Text = ""

    End Sub


    Private Sub GenComBo()
        Dim objdb As New classMaster

        Me.cboEndBuyers.ComboBox.DataSource = objdb.GetEndBuyers()
        Me.cboEndBuyers.ComboBox.DisplayMember = "endbuyername"
        Me.cboEndBuyers.ComboBox.ValueMember = "endbuyerid"

    End Sub

    Private Sub cboEndBuyers_Click(sender As System.Object, e As System.EventArgs) Handles cboEndBuyers.Click

    End Sub

    Private Sub cboEndBuyers_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboEndBuyers.DropDownClosed
        LoadData("", cboEndBuyers.ComboBox.SelectedValue)
    End Sub
    Private Function LoadData(Optional ByRef strEndBuyerCD As String = "", Optional ByRef endbuyerid As Int64 = 0) As Boolean
        Dim objdb As New classMaster
        dtEndBuyers = objdb.GetEndBuyersByID(strEndBuyerCD:="", Int64EndBuyerid:=endbuyerid)

        If dtEndBuyers.Rows.Count > 0 Then

            Call Binddata(dt:=dtEndBuyers)
            Return True
        Else

        End If
    End Function

    Private Sub Binddata(ByVal dt As DataTable)
        txtendbuyerid.Text = dt.Rows(0)("endbuyerid")
        txtendbuyercd.Text = dt.Rows(0)("endbuyercd")
        txtendbuyername.Text = dt.Rows(0)("endbuyername")
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        BFSaveData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BFSaveData()

        If txtendbuyercd.Text.Trim.Length = 0 Or txtendbuyername.Text.Trim.Length = 0 Then
            MessageBox.Show("Please Enter EndBuyer Code", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If

        Call SaveData()
    End Sub


    Private Function SaveData() As Boolean
        Dim objdb As New classMasterUpdate
        Dim endbuyers As New classMasterUpdate.endbuyers

        'IIf(txtendbuyerid.Text.Trim = "", endbuyers.endbuyerid Is Nothing, endbuyers.endbuyerid = txtendbuyerid.Text)
        endbuyers.endbuyerid = CInt(txtendbuyerid.Text.Trim)
        endbuyers.endbuyercd = txtendbuyercd.Text.Trim
        endbuyers.endbuyername = txtendbuyername.Text.Trim

        endbuyers.Message = String.Empty

        EditRow()
        NewRows()

        Dim dv_add As New DataView(dtEndBuyers, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dtEndBuyers, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dtEndBuyers, "", "", DataViewRowState.Deleted)


        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would You Like To Save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

        If result <> DialogResult.Yes Then Exit Function

        If objdb.EndBuyerSave(dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del, EndBuyers:=endbuyers) Then
            MessageBox.Show("Save is Complete!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            LoadData(strEndBuyerCD:=Nothing, endbuyerid:=endbuyers.endbuyerid)
            SaveData = True
        Else
            MessageBox.Show(endbuyers.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If



    End Function

    Private Sub NewRows()
        If dtEndBuyers.Rows.Count = 0 Then
            Dim NewRow As DataRow
            NewRow = dtEndBuyers.NewRow
            NewRow.Item("endbuyerid") = txtendbuyerid.Text.Trim
            NewRow.Item("endbuyercd") = txtendbuyercd.Text.Trim
            NewRow.Item("endbuyername") = txtendbuyername.Text.Trim
            dtEndBuyers.Rows.Add(NewRow)
        End If
    End Sub
    Private Sub EditRow()
        If dtEndBuyers.Rows.Count > 0 Then
            'dtEndBuyers.Rows(0)("endbuyerid") = CInt(txtendbuyerid.Text.Trim)
            dtEndBuyers.Rows(0)("endbuyercd") = txtendbuyercd.Text.Trim
            dtEndBuyers.Rows(0)("endbuyername") = txtendbuyername.Text.Trim
        End If
    End Sub

    Private Sub lblendbuyerid_Click(sender As Object, e As EventArgs) Handles lblendbuyerid.Click

    End Sub

    Private Sub txtendbuyerid_TextChanged(sender As Object, e As EventArgs) Handles txtendbuyerid.TextChanged

    End Sub
End Class