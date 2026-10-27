Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class frmSearchPO2
    Dim strPOno As String = ""
    Dim userAction As String = ""
    Public Property pPONo() As String
        Get
            pPONo = strPOno
        End Get
        Set(ByVal Newvalue As String)
            strPOno = Newvalue
        End Set

        
    End Property
    Private Sub GenGrid()
        Dim Config As New clsConfig
        Dim ObjDB As New classPurchase
        Dim dt As New DataTable
        dt = ObjDB.POLoad(txtPONo.Text.Trim.ToUpper, dtpDateFr.Value.ToString("yyyyMMdd"), dtpDateTo.Value.ToString("yyyyMMdd"), Config.IsNull(CBOSupplier1.SelectedValue, "").ToString.Trim)
        If dt.Rows.Count > 0 Then
            strPOno = dt.Rows(0)("jobno")
        End If
        dgPO.AutoGenerateColumns = False
        dgPO.DataSource = dt

    End Sub
    Private Sub GenCombo()
        Dim objDB As New classMaster
        Me.CBOSupplier1.DataSource = objDB.GetSupplier1
        Me.CBOSupplier1.DisplayMember = "name"
        Me.CBOSupplier1.ValueMember = "suppcd"
        Me.CBOSupplier1.SelectedValue = ""

    End Sub

    
    Private Sub frmSearchPO2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Year, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
        Call GenGrid()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        userAction = "OK"
        Me.Close()
    End Sub
End Class