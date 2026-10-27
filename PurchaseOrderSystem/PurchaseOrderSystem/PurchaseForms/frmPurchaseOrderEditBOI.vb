Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class frmPurchaseOrderEditBOI
    Private config As New clsConfig
    Private clsUser As New classUserInfo
    Private clsConn As New classConnection
    Private connStr As New classConnection

    Private ds As New DataSet
    Private dts As New DataTable
    Private dt As New DataTable
    Dim dst2 As DataTable

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmPurchaseOrderEditBOI_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitControl
    End Sub
    Private Sub InitControl()
        txtPurno.Text = ""
        BtnYarnSave.Enabled = True
        BtnYarnExit.Enabled = True
    End Sub

    Private Sub buttonSearchPO_Click(sender As Object, e As EventArgs) Handles buttonSearchPO.Click
        Call loadSearchPO()
    End Sub
    Private Sub loadSearchPO()
        Dim formSearchPO As New formSearchPO
        formSearchPO.ShowDialog()

        If formSearchPO.puserAction = "OK" Then
            Me.txtPurno.Text = formSearchPO.pSelectedPO
            Call showPOData()
        End If
    End Sub
    Private Function chkErrbutUseClearTable(ByVal strmsg As String) As Boolean
        Try
            ds.Tables("v_pur").Clear()
            chkErrbutUseClearTable = True
        Catch ex As Exception
            chkErrbutUseClearTable = False
            Exit Function
        End Try
    End Function
    Private Function chkErrbutUseClearTableDet(ByVal strmsg As String) As Boolean
        Try
            ds.Tables("v_purdet").Clear()
            chkErrbutUseClearTableDet = True
        Catch ex As Exception
            chkErrbutUseClearTableDet = False
            Exit Function
        End Try
    End Function
    Private Sub showPOData()
        Dim dsset As New DataSet
        Dim strsqlpo As String
        Dim strsqlpodet As String
        Dim strmsg As String = ""

        Try

            strsqlpo = "exec p_po_select '" & Me.txtPurno.Text.Trim & "'"
            Dim da As New SqlDataAdapter(strsqlpo.ToString, connStr.connection)

            strsqlpodet = "exec p_po_det_select '" & Me.txtPurno.Text.Trim & "'"
            Dim daDet As New SqlDataAdapter(strsqlpodet.ToString, connStr.connection)

            If ds.Tables.Count > 0 Then
                If chkErrbutUseClearTable(strmsg) = True Then
                    ds.Tables("v_pur").Clear()
                End If

                If chkErrbutUseClearTableDet(strmsg) = True Then
                    ds.Tables("v_purdet").Clear()
                End If
            End If

            da.Fill(ds, "v_pur")
            daDet.Fill(ds, "v_purdet")

            '==================================================================================
            If ds.Tables("v_pur").Rows.Count > 0 Then
                'PO Head
                Me.DateYIN.Value = ds.Tables("v_pur").Rows(0).Item("jobdt").ToString.Trim
                Me.txtSupQuoteNo.Text = ds.Tables("v_pur").Rows(0).Item("supquoteno").ToString.Trim
                txtEmp.Text = ds.Tables("v_pur").Rows(0).Item("Empcd").ToString
                txtDept.Text = ds.Tables("v_pur").Rows(0).Item("deptcd").ToString

                'Supplier
                txtSupplier.Text = ds.Tables("v_pur").Rows(0).Item("suppcd").ToString
                Me.txtShipterms.Text = ds.Tables("v_pur").Rows(0).Item("shipterms")

                'BOI
                txtBenefit.Text = ds.Tables("v_pur").Rows(0).Item("benefit").ToString.Trim
                txtBenefitAmount.Text = ds.Tables("v_pur").Rows(0).Item("benefit_amount").ToString.Trim
            Else
                'MsgBox("data not found kap pom !", MsgBoxStyle.Critical, "กรุณาตรวจสอบหมายเลข PO no :")
            End If

            'If ds.Tables("v_purdet").Rows.Count > 0 Then

            dst2 = ds.Tables("v_purdet")
            Me.DgYarn.AutoGenerateColumns = False
            Me.DgYarn.DataSource = dst2

        Catch ex As Exception

            'MsgBox(ex.Message)
        End Try


    End Sub

    Private Function CheckData() As Boolean
        Dim result As Boolean = True
        If txtPurno.Text.Trim = "" Then
            MessageBox.Show("ให้คุณป้อนข้อมูล Purchase no ก่อนครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        If txtBenefit.Text.Trim = "" Then
            MessageBox.Show("ให้คุณป้อนข้อมูล Benefit ก่อนครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            result = False
        End If
        Return result
    End Function
    Private Sub BtnYarnSave_Click(sender As Object, e As EventArgs) Handles BtnYarnSave.Click
        If Not CheckData() Then
            Exit Sub
        End If
        Dim classPurchase As New classPurchase
        Dim Isvalid As Boolean
        Dim msgerr As String = ""
        Isvalid = classPurchase.updatePurchaseOrderBOI(txtPurno.Text.Trim, txtBenefit.Text.Trim, msgerr, clsUser.UserID)
        If Isvalid = True Then
            MessageBox.Show("Last update successful")
            Me.showPOData()
        Else
            MsgBox(msgerr)
        End If
    End Sub

    Private Sub BtnYarnExit_Click(sender As Object, e As EventArgs) Handles BtnYarnExit.Click
        Me.Close()
    End Sub
End Class