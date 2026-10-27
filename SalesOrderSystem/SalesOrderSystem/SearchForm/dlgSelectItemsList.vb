Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Text

Public Class dlgSearchItemsList
    'Wrten By       : Sitthana Boonlom
    'Writen Date    : 27/11/2021

#Region "Property"
    Private _logempcd As String = ""
    Private _DesignNoList As String = ""

    Public Property logempcd As String
        Get
            logempcd = _logempcd
        End Get
        Set(ByVal Newvalue As String)
            _logempcd = Newvalue
        End Set
    End Property
    Public Property DesignNoList As String
        Get
            DesignNoList = _DesignNoList
        End Get
        Set(ByVal Newvalue As String)
            _DesignNoList = Newvalue
        End Set
    End Property

#End Region

#Region "Local Variable"
    Private clsMaster As New classMaster
    Private clsConfig As New clsConfig

    Private dt As New DataTable
    Private bsSearchTable As New BindingSource
#End Region


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        selectRowDataAndReturn()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dlgSearchItemsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        statusUser.Text = _logempcd
    End Sub

    Public Function ShowFrm() As String
        Dim classCn As New classConnection

        getAndBindingData()

        Me.ShowDialog()
        Return _DesignNoList
    End Function

    Private Sub getAndBindingData()
        dt = clsMaster.getSearchDesignData("")
        bsSearchTable.DataSource = dt

        With grdData
            .AutoGenerateColumns = False
            .DataSource = bsSearchTable
            bsSearchTable.MoveFirst()
        End With
    End Sub

    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtWordFilter.Text.Trim
        FilterExp.Append(" Design_no LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or refdesno LIKE '*" & SearchString & "*'")

        If SearchString <> "" Then
            bsSearchTable.Filter = FilterExp.ToString
        Else
            bsSearchTable.Filter = ""
        End If
    End Sub
    Private Sub grdData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        selectRowDataAndReturn()
    End Sub
    Private Sub selectRowDataAndReturn()
        With dt
            If .Rows.Count > 0 Then
                Dim i As Integer = 0

                _DesignNoList = ""
                For i = 0 To .Rows.Count - 1
                    If clsConfig.IsNull(dt.Rows(i)("Selected"), 0) = 1 Then
                        If _DesignNoList.Trim <> "" Then
                            _DesignNoList &= ", "
                        End If
                        _DesignNoList &= clsConfig.IsNull(dt.Rows(i)("design_no"), 0).ToString.Trim
                    End If
                Next
                If _DesignNoList.Trim = "" Then
                    MessageBox.Show("คุณต้องเลือกรายการก่อนครับ", "Programmer Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Me.Close()
                End If
            Else
                MessageBox.Show("ไม่มีข้อมูลให้เลือก", "Programmer Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End With
    End Sub
End Class
