Public Class frmDINRemark
    Dim clsconn As New classConnection
    Dim clsconfig As New clsConfig
    Dim clsuser As New classUserInfo
    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal Newvalue As classUserInfo)
            clsuser = Newvalue
        End Set
    End Property

    Private Sub frmDINRemark_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitControl()
    End Sub
    Private Sub InitControl()
        Call BindGrid(grdData, (New classStockD).GetRollNoD("", clsuser.UserID))
    End Sub
    Private Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
        grd.AutoGenerateColumns = False
        grd.DataSource = dt
      
    End Sub
    Private Sub txtRollnod_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtRollNoD.KeyDown
        If txtRollNoD.Text.Trim.Length = 0 Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            GetRollNoD(txtRollnod.Text.Trim)
       
        End If
    End Sub

    Private Function GetRollNoD(ByVal strRollNoD As String) As Boolean
        Dim dbStockD As New classStockD
        Dim dt As DataTable = dbStockD.GetRollNoD(strRollNoD, clsuser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindGrid(grdData, dt)

            'Call BinddataRollNoD(dt)
            'Call BindDataRollNoD(dt)

            Return True
        End If
        Return False
    End Function
    Private Sub BinddataRollNoD(ByVal dt As DataTable)
        Dim config As New clsConfig
        If txtRollNoD.Text = "" Then Exit Sub
        Dim k As Integer = 0

        grdData.AutoGenerateColumns = False
        If dt.Rows.Count > 0 Then
            Dim dt1 As DataTable = dt
            Dim dt2 As DataTable = grdData.DataSource

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1


                dr = dt2.NewRow

                For j = 0 To dt2.Columns.Count - 1

                    dr("dfno") = dt1.Rows(i)("dfno")
                    dr("design_no") = dt1.Rows(i)("design_no")
                    dr("gwth") = dt1.Rows(i)("gwth")
                    dr("fwth") = dt1.Rows(i)("fwth")
                    dr("col") = dt1.Rows(i)("col")
                    dr("gr") = dt1.Rows(i)("gr")
                    dr("custcolor") = dt1.Rows(i)("custcolor")
                    dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
                    dr("custcolor") = dt1.Rows(i)("custcolor")
                    dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                    dr("sonoid") = dt1.Rows(i)("sonoid")
                    dr("kg") = dt1.Rows(i)("kg")
                    dr("mts") = dt1.Rows(i)("mts")
                    dr("yds") = dt1.Rows(i)("yds")
                    dr("lot") = dt1.Rows(i)("lot")
                    ' dr("remark") = dt1.Rows(i)("remark")
                    dr("rem_qc") = dt1.Rows(i)("rem_qc")
                    ' dr("dono") = dt1.Rows(i)("dono")
                    ' dr("dodt") = dt1.Rows(i)("dodt")
                Next
                dt2.Rows.Add(dr)

            Next

        End If

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim RollNoD As String = txtRollNoD.Text.Trim

        If Me.txtRollNoD.Text = "" Then
            MsgBox("กรุณาระบุหมายเลข Roll No :", MsgBoxStyle.Information, "Pls Enter data Roll no")
            Exit Sub
        End If

        Try
            If MsgBox("Are you sure to Save ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If UpdateRollNoD(RollNoD) Then

                    Call GetRollNoD(clsconfig.IsNull(RollNoD, clsuser.UserID))

                End If

            End If
        Catch ex As Exception
            MsgBox("มีข้อผิดพลาดเกี่ยวกับการบันทึกข้อมูลครับ", MsgBoxStyle.Critical, "Insertdata Fail")
        End Try
    End Sub
    Private Function UpdateRollNoD(ByVal RollNoD As String) As Boolean
        Dim objDB As New classStockD
        Dim msgerr As String = ""
        Dim dt As DataTable = grdData.DataSource


        If objDB.RollNoDUpdate(dt, msgerr, clsuser.UserID, RollNoD) Then

            UpdateRollNoD = True
        Else
            UpdateRollNoD = False
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If

    End Function

    
    Private Sub btnSearchRollNoDNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchRollNoDNo.Click

    End Sub
End Class