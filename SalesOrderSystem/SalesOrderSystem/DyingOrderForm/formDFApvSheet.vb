Public Class formDFApvSheet
    Private dfno1 As String
    Private color1 As String
    Private dtDfoItems As DataTable
    Private strEmpcd As String

    Public Property dfno() As String
        Get
            Return dfno1
        End Get
        Set(ByVal value As String)
            dfno1 = value
        End Set

    End Property
    Public Property color() As String
        Get
            Return color1
        End Get
        Set(ByVal value As String)
            color1 = value
        End Set
    End Property

    Private Sub formDFApvSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        generateCombo()
    End Sub
    Private Sub generateCombo()
        Dim objDB As New classMaster
        Dim objREQ As New classRequest
        Dim objDF As New classDFOrder

        cboDFNo.ComboBox.DataSource = objDF.DFLoad()
        cboDFNo.ComboBox.DisplayMember = "dfno"
        cboDFNo.ComboBox.ValueMember = "dfno"

        Me.comboColor.DataSource = objDB.GetColor
        Me.comboColor.DisplayMember = "col2"
        Me.comboColor.ValueMember = "col2"

        'getDforderItems()

    End Sub

    Private Sub comboColor_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboColor.DropDownClosed
        If comboColor.SelectedValue = "" Or Me.cboDFNo.Text = "" Then Exit Sub
        getDforderItems()
    End Sub

    Private Sub comboColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboColor.SelectedIndexChanged

    End Sub
    Private Sub getDforderItems()
        Dim objDF As New classDFOrder
        dfno1 = Me.cboDFNo.ComboBox.SelectedValue
        color1 = Me.comboColor.SelectedValue
        dtDfoItems = objDF.GetDFOrderItems(dfno1, color1)
        Me.dgvDfoitems.AutoGenerateColumns = False
        Me.dgvDfoitems.DataSource = dtDfoItems

    End Sub

    Private Sub comboColor_ValueMemberChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboColor.ValueMemberChanged

    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim objDF As New classDFOrder
        Dim Message As String
        Dim Success As Boolean
        Message = ""

        dtDfoItems = objDF.DforderApproveUpdate(dtDfoItems, Message, Success, strEmpcd)
        MsgBox(Message)
        If Success Then
            Me.dgvDfoitems.DataSource = dtDfoItems
        End If

    End Sub

    Private Sub dgvDfoitems_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvDfoitems.DefaultValuesNeeded
        e.Row.Cells("coldfno").Value = Me.cboDFNo.Text.Trim
        e.Row.Cells("col").Value = Me.comboColor.SelectedValue
    End Sub

    Private Sub cboDFNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDFNo.Click

    End Sub

    Private Sub cboDFNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDFNo.DropDownClosed
        Dim objDF As New classDFOrder
        Me.comboColor.DataSource = objDF.getDfColors(cboDFNo.Text)
        Me.comboColor.DisplayMember = "col"
        Me.comboColor.ValueMember = "col"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub
End Class