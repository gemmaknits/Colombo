Imports System.Data.SqlClient

Public Class frmMachinesMaster
    'Writen By      : Sitthana Boonlom
    'Writen Date    : 20210817

#Region "Property"
    Dim oConn As New classConnection
    Private clsUser As classUserInfo
    Private _AllowNew As Boolean = True
    Private _AllowEdit As Boolean = True
    Private _AllowDelete As Boolean = True
    Private _AllowPrint As Boolean = True

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Public Property AllowNew As Boolean
        Get
            AllowNew = _AllowNew
        End Get
        Set(ByVal Newvalue As Boolean)
            _AllowNew = Newvalue
        End Set
    End Property
    Public Property AllowEdit As Boolean
        Get
            AllowEdit = _AllowEdit
        End Get
        Set(ByVal Newvalue As Boolean)
            _AllowEdit = Newvalue
        End Set
    End Property
    Public Property AllowDelete As Boolean
        Get
            AllowDelete = _AllowDelete
        End Get
        Set(ByVal Newvalue As Boolean)
            _AllowDelete = Newvalue
        End Set
    End Property
    Public Property AllowPrint As Boolean
        Get
            AllowPrint = _AllowPrint
        End Get
        Set(ByVal Newvalue As Boolean)
            _AllowPrint = Newvalue
        End Set
    End Property
#End Region


    '***** Local Variable
    Private clsMaster As New classMaster
    Private clsMasterUpdate As New classMasterUpdate
    'Private clsValidate As New ClassValidate
    'Private clsFormCode As New ClassFormCode
    Private dt As New DataTable
    Private bs As New BindingSource
    Private drv As DataRowView

    Private ErrMsg As String = ""


    Private Sub frmMachinesMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareComboBox()
        CreateNewBlankRowAndBinding()
    End Sub

    '***** Prepare Form
    Private Sub PrepareComboBox()
        'With cboActivityType
        '    .DataSource = clsMaster.getLookupValueByValueType("AR_REC_ACTIVITY", "N")
        '    .DisplayMember = "lookup_value"
        '    .ValueMember = "lookup_value_id"
        'End With
    End Sub

    '***** Close Form
    Private Sub tsmnExit_Click(sender As Object, e As EventArgs) Handles tsmnExit.Click
        Me.Close()
    End Sub


    '***  Manange Data
    Private Sub CreateNewBlankRowAndBinding()
        '  Dim row As DataRow

        'dt = clsMaster.getArActivity(-1) 'Wait 20210817 
        'row = dt.NewRow()

        ''For Entry Fields
        'row("ar_activity_id") = -1
        'row("activity_name") = ""
        'row("activity_description") = ""
        'row("activity_type_id") = -1
        'row("gl_account_id") = -1
        'row("activity_disabled") = 0


        'Create Row And Bind Data
        'dt.Rows.Add(row)
        'bindingData()
    End Sub
    Private Sub bindingData()
        ClearDataBindings()
        bs.DataSource = dt

        'Entry Object
        'txtARActivityId.DataBindings.Add(New Binding("text", bs, "ar_activity_id"))
        'cboActivityType.DataBindings.Add(New Binding("SelectedValue", bs, "activity_type_id"))
        'txtActivityName.DataBindings.Add(New Binding("text", bs, "activity_name"))
        'TxtActivityDescription.DataBindings.Add(New Binding("text", bs, "activity_description"))
        'chkActivityDisabled.DataBindings.Add(New Binding("Checked", bs, "activity_disabled"))

        'Display Only Object
        'txtGLAccountCode.DataBindings.Add(New Binding("text", bs, "gl_account_code"))
        'txtGLAccountName.DataBindings.Add(New Binding("text", bs, "gl_account_name"))
        'txtDisabledDate.DataBindings.Add(New Binding("text", bs, "disabled_date"))
    End Sub
    Private Sub ClearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            Call ClearControlBindings(obj)
        Next
    End Sub
    Private Sub ClearControlBindings(ByVal obj As Control)
        obj.DataBindings.Clear()
        If TypeOf obj Is TabControl Or TypeOf obj Is TabPage Or TypeOf obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                Call ClearControlBindings(obj2)
            Next
        End If
    End Sub



    '***** Browse Dialog
    Private Sub btnSearchMachine_Click(sender As Object, e As EventArgs) Handles btnSearchMachine.Click
        'Sitthana 20200901
        Dim f = New Classes.frmSearchMachine
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult

        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(oConn.getSQLConnection)
        f.logempcd = "Sitthana"

        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            MsgBox("machine " & drv.Item("mcno") & vbCr _
                 & drv.Item("mcdesc") & vbCr _
                 & drv.Item("mctyp") & vbCr _
                 & drv.Item("mcsize") & vbCr _
                 & drv.Item("mcmodel") & vbCr _
                 & drv.Item("mcserialno") & vbCr _
                 & drv.Item("gauge") & vbCr _
                 & drv.Item("diameter") & vbCr _
                 & drv.Item("boi") & vbCr
                   )
        End If
    End Sub



    '***** Create / Update Data
    Private Sub tsmnNew_Click(sender As Object, e As EventArgs) Handles tsmnNew.Click
        CreateNewBlankRowAndBinding()
    End Sub
    Private Sub tsmnSave_Click(sender As Object, e As EventArgs) Handles tsmnSave.Click
        bs.EndEdit()
        Me.Validate()

        Me.Cursor = Cursors.WaitCursor
        If MessageBox.Show("Are you sure to save data?", "System Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning
                            ) = vbOK Then
            If CheckData() Then
                If SaveData() Then
                    MessageBox.Show("Save Complete", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show(ErrMsg & vbCr & "Save Not Complete, Try again", "System Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                End If
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub


    '***** Save Data
    Private Function CheckData() As Boolean
        Dim ErrMsg As String = ""
        Dim i As Byte = 0

        'If txtTranType.Text.Trim = "" Then
        '    i += 1
        '    ErrMsg &= Chr(13) & Space(5) & i.ToString.Trim & ") " & "Tran Type don't empty"
        'End If
        'If txtActivityName.Text.Trim = "" Then
        '    i += 1
        '    ErrMsg &= Chr(13) & Space(5) & i.ToString.Trim & ") " & "Activity Name don't empty"
        'End If
        'If TxtActivityDescription.Text.Trim = "" Then
        '    i += 1
        '    ErrMsg &= Chr(13) & Space(5) & i.ToString.Trim & ") " & "Activity Description don't empty"
        'End If
        'If cboActivityType.SelectedIndex = -1 Then
        '    i += 1
        '    ErrMsg &= Chr(13) & Space(5) & i.ToString.Trim & ") " & "Activity Typen don't empty"
        'End If

        If ErrMsg.Trim = "" Then
            CheckData = True
        Else
            CheckData = False
            MessageBox.Show("ข้อผิดพลาด" & ErrMsg, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Return CheckData
    End Function
    Private Function SaveData()
        Dim SaveOk As Boolean = False
        Dim ArActivityId As Integer = 0
        'UpdateRowWithObjInform()
        'If clsMasterUpdate.updateArActivity(dt, clsUser.UserID, ArActivityId, ErrMsg) Then
        '    dt = clsMaster.getArActivity(ArActivityId)
        '    bindingData()
        '    SaveOk = True
        'Else
        '    SaveOk = False
        'End If
        Return SaveOk
    End Function


    '***** Print
    Private Sub tsmnPrint_Click(sender As Object, e As EventArgs) Handles tsmnPrint.Click

    End Sub


End Class