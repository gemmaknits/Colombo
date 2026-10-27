Public Class frmCartons
    Dim clsuser As New classUserInfo


    Public Property Userinfo() As classUserInfo 'Add By Neung 20151208
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal newvalue As classUserInfo)
            clsuser = newvalue
        End Set
    End Property

    Private Sub Loaddata()
        Dim objdb As New classMaster
        Dim dt As DataTable
        dt = objdb.Getcartons

        grdCartons.AutoGenerateColumns = False
        grdCartons.DataSource = dt

    End Sub
    Private Sub frmCartons_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Call Loaddata()

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Dim strDimension As String = InputBox("จะใส่ Dimension ใหม่ให้ดู Dimension เก่าก่อนว่ามีหรือไม่" & vbCrLf & "ถ้าไม่มีก็ใส่รหัสสีลงช่องข้างล่างเลย" & vbCrLf & "รหัสสีมีได้สูงสุด 10 ตัวเท่านั้น" & vbCrLf & "( ให้ใช้เครื่องหมาย + แทน / )", "System Message", "").Trim.ToUpper
        If strDimension.Trim.Length = 0 Then Exit Sub
        Dim dt As DataTable = grdCartons.DataSource
        Dim i As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("dimension").ToString.Trim.ToUpper = strDimension Then
                MessageBox.Show("Dimension " & strDimension.Trim & " มีอยู่แล้วในระบบ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
        Next

        Dim dr As DataRow = dt.NewRow()
        'dr("id") = Nothing
        dr("dimension") = strDimension
        dr("width") = 0
        dr("length") = 0
        dr("height") = 0
        dr("capacity") = 0
        dr("weight") = 0

        dt.Rows.Add(dr)
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If SaveData() Then

        End If
    End Sub

    Private Function SaveData() As Boolean
        Dim objdb As New classMasterUpdate
        Dim dt As DataTable = grdCartons.DataSource
        Dim cartons As New classMasterUpdate.cartons

        cartons.h01_id = Nothing


        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)


        If objdb.CartonsSave(cartons, dv_add, dv_upd, dv_del) Then

            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Call Loaddata()
            SaveData = True
        Else
            MessageBox.Show("บันทึกไม่สำเร็จ" + cartons.h08_Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If




    End Function
End Class