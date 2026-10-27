Public Class frmStockDLocation
    Dim clsconn As New classConnection
    Dim clsconfig As New clsConfig
    Dim clsuser As New classUserInfo

    Dim DbStockDLocation As New classStockDLocation

    Dim StrDesign_No As String
    Dim StrLot As String
    Dim StrCol As String
    Dim StrDfNo As String
    Public Property Userinfo() As classUserInfo
        Get
            Userinfo = clsuser
        End Get
        Set(ByVal Newvalue As classUserInfo)
            clsuser = Newvalue
        End Set
    End Property
    Private Sub frmStockDLocation_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSeach_GotFocus(sender As Object, e As System.EventArgs) Handles txtSeach.GotFocus
        If txtSeach.Text <> "" Then
            txtSeach.Text = ""
        End If
    End Sub

    Private Sub txtSeach_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSeach.KeyDown

        If e.KeyCode = Keys.Enter Then
            Call Checkopt()
            GetStockDItem(StrDesign_No, StrLot, StrCol, StrDfNo)

        End If
    End Sub
    Public Sub Checkopt()
        If optDesignNo.Checked Then
            StrDesign_No = txtSeach.Text.Trim
            StrLot = ""
            StrCol = ""
            StrDfNo = ""
        ElseIf optLotNo.Checked Then
            StrLot = txtSeach.Text.Trim
            StrDesign_No = ""
            StrCol = ""
            StrDfNo = ""
        ElseIf optCol.Checked Then
            StrCol = txtSeach.Text.Trim
            StrDesign_No = ""
            StrLot = ""
            StrDfNo = ""

        ElseIf optDFNo.Checked Then
            StrDfNo = txtSeach.Text.Trim
            StrDesign_No = ""
            StrLot = ""
            StrCol = ""

        End If

    End Sub

    Private Function GetStockDItem(ByRef StrDesign_No As String, ByRef Strlot As String, ByRef StrCol As String, ByRef StrDfNo As String) As Boolean
        Dim dt As DataTable = DbStockDLocation.GetStockDLocation(StrDesign_No, Strlot, StrCol, StrDfNo)
        If dt.Rows.Count > 0 Then
            Call BinddataStockD(dt)

        End If

    End Function
    Private Sub BinddataStockD(ByRef dt As DataTable)
        grdStockD.AutoGenerateColumns = False
        grdStockD.DataSource = dt
    End Sub

    Private Sub txtSeach_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtSeach.KeyPress

    End Sub




    Private Sub txtSeach_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSeach.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If MsgBox("จะทำการบันทึกใช่หรือไม่", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If UpdateStockD() Then

                    MsgBox("บันทึกสำเร็จ", MsgBoxStyle.OkOnly)
                    Call Checkopt()
                    GetStockDItem(StrDesign_No, StrLot, StrCol, StrDfNo)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("มีข้อผิดพลาดขณะบันทึกข้อมูลครับ")
        End Try
    End Sub
    Private Function UpdateStockD() As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objdb As New classStockDLocation
        Dim msgerr As String = ""


        Dim dt As DataTable = grdStockD.DataSource

        Dim dv_dtc_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dt, "", "", DataViewRowState.Deleted)

        If objdb.UpdateStockD(dv_dtc_upd, msgerr, clsuser.UserID) Then
            UpdateStockD = True

        Else
            UpdateStockD = False

        End If



    End Function

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub optLotNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optLotNo.CheckedChanged
        If optLotNo.Checked = True Then
            Checkopt()
            txtSeach.Text = "Please Enter Lot No."
        End If
    End Sub

    Private Sub optDesignNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optDesignNo.CheckedChanged
        If optDesignNo.Checked = True Then
            Checkopt()
            txtSeach.Text = "Please Enter Design No."
        End If
    End Sub

    Private Sub optCol_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optCol.CheckedChanged
        If optCol.Checked = True Then
            Checkopt()
            txtSeach.Text = "Please Enter Color No."
        End If
    End Sub

    Private Sub optDFNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optDFNo.CheckedChanged
        If optDFNo.Checked = True Then
            Checkopt()
            txtSeach.Text = "Please Enter D/F No."
        End If
    End Sub

    Private Sub CheckEditRows()

        Dim dtc As New DataTable
        dtc = grdStockD.DataSource
        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        For i = 0 To dtc.Rows.Count - 1
            If dtc.Rows(i).RowState = DataRowState.Modified Then

                'dblGrossAmt = dblGrossAmt + Math.Round(config.IsNull(dtc.Rows(i)("qty"), 0) * config.IsNull(dtc.Rows(i)("uprice"), 0), 2)
                'dblOldAmt = Math.Round(config.IsNull(dtc.Rows(i)("oldamt"), 0), 2)
            End If
        Next

    End Sub

 

    Private Sub grdStockD_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockD.CellEndEdit
        'CheckEditRows()
    End Sub
End Class