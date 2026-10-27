Public Class frmLookup
       Dim clsuser As new classUserInfo
    Dim DTlookup_value As DataTable
    Dim dtLookupValueByType As DataTable
    Dim DesignApplicationId As Integer
    Private Const DesignAppl As Byte = 5
    Private Const DesignSubApplication As Byte = 6
    Private Const DesignSplFunction As Byte = 7
    Private Const PatternType As Byte = 25
    Private Const DesignFamilyName As Byte = 35
    Dim blnCancel As Boolean = False

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property
    Private Sub IntiControl()
        Dim objdb As New classItemsCategory
        DesignApplicationId = objdb.getLookupTypeId("DESIGN_APPL") 'Sitthana 20190212
        Call GenCBO()

        'GenGrid()
    End Sub
    Private Sub GenCBO()
        Dim objdb As New classItemsCategory

        '====================== Gen Combo Box========================================= 
        cboLookup_type.DataSource = objdb.GetLookUpType(0, clsuser.UserID)
        cboLookup_type.DisplayMember = "lookup_name"
        cboLookup_type.ValueMember = "lookup_id" 'Lookup_type_id
        'cboLookup_type.SelectedIndex = -1

        '=============================================================================
        InitComboLookupValueByType(DesignAppl) 'Sitthana 20190212
        'cboLookupValueByType.DataSource = objdb.GetLookUpType(DesignAppl, clsuser.UserID)
        'cboLookupValueByType.DisplayMember = "lookup_name"
        'cboLookupValueByType.ValueMember = "lookup_id" 'Lookup_type_id

    End Sub
    Private Sub InitComboLookupValueByType(pLookupId As Integer)
        'Sitthana 20190212
        Dim objdb As New classItemsCategory
        dtLookupValueByType = objdb.getLookupValueByType(pLookupId)
        Try
            If dtLookupValueByType IsNot Nothing Then
                cboLookupValueByType.DataSource = dtLookupValueByType
                cboLookupValueByType.DisplayMember = "lookup_value"
                cboLookupValueByType.ValueMember = "parent_lookup_value_id" 'Lookup_type_id, lookup_id
            Else
                cboLookupValueByType = Nothing
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub FilterData()
        Dim dt As DataTable = grdlookup_value.DataSource
        Dim dv As DataView
        dv = New DataView(dt, "" & "", "", DataViewRowState.CurrentRows)
        'dv = New DataView(dt, "type = 'business' ", "type Desc", DataViewRowState.CurrentRows)
        grdlookup_value.DataSource = dv
    End Sub

    Private Sub frmLookup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        IntiControl()
    End Sub

    Private Sub GenGrid()
        Dim classLookup As New classLookup
        Dim dt As New DataTable

        'If cboLookup_type.SelectedValue = DesignAppl Then
        '    grdlookup_value.Columns("cboLookupValueByType").Visible = False
        'Else
        '    grdlookup_value.Columns("cboLookupValueByType").Visible = True
        'End If
        '6 = , 7 = , 35 = 
        Select Case cboLookup_type.SelectedValue
            Case DesignSubApplication 'DesignAppl, DesignSubApplication, DesignSplFunction, PatternType, DesignFamilyName
                grdlookup_value.Columns("cboLookupValueByType").Visible = True
                Me.Width = 680 '460
            Case Else
                grdlookup_value.Columns("cboLookupValueByType").Visible = False
                Me.Width = 460 '680
        End Select
        'InitComboLookupValueByType(cboLookup_type.SelectedValue) 'Sitthana 20190212
        dt = classLookup.Getlookup_value(cboLookup_type.SelectedValue)

        BindDataGrid(dt)
    End Sub
    Private Function GetNewLookUp() As Boolean
        Dim dt As DataTable = grdlookup_value.DataSource

        Dim DrNewLoopUpValue As DataRow

        DrNewLoopUpValue = dt.NewRow
        DrNewLoopUpValue("active") = True

        dt.Rows.Add(DrNewLoopUpValue)

    End Function


    Private Sub BindDataGrid(ByVal dt As DataTable)
        grdlookup_value.AutoGenerateColumns = False

        grdlookup_value.DataSource = dt
    End Sub

    Private Sub cboproperty_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboLookup_type.DropDownClosed
        Call GenGrid()
    End Sub


    Private Sub cboproperty_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboLookup_type.SelectedIndexChanged
        Call GenGrid()
    End Sub

    Private Sub btnNewLookup_Click(sender As System.Object, e As System.EventArgs) Handles btnNewLookup.Click
        Call GetNewLookUp()
    End Sub


    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        If grdlookup_value.EditMode Then grdlookup_value.EndEdit()

        ''Comment by sitthana 20240201
        'Dim result As Windows.Forms.DialogResult
        'result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        'If result = Windows.Forms.DialogResult.Cancel Then blnCancel = True
        'If result <> Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveData()


    End Sub


    Private Sub AcceptOrReject(ByVal row As DataRow)
        ' Use a function to validate the row's values.
        ' If the function returns true, end the edit; 
        ' otherwise cancel it.
        If ValidateRow(row) Then
            row.EndEdit()
        Else
            row.CancelEdit()
        End If
    End Sub

    Private Function ValidateRow(ByVal row As DataRow) As Boolean
        Dim isValid As Boolean
        ' Insert code to validate the row values. 
        ' Set the isValid variable.
        ValidateRow = isValid
    End Function

    Private Function SaveData() As Boolean

        If Not grdlookup_value.DataSource Is Nothing Then
            If grdlookup_value.Rows.Count > 0 And grdlookup_value.Focused Then
                If grdlookup_value.CurrentCell.IsInEditMode Then
                    Dim cell As DataGridViewCell = grdlookup_value.CurrentCell
                    grdlookup_value.EndEdit(DataGridViewDataErrorContexts.Commit)
                    If Not grdlookup_value.CurrentCell.Value = grdlookup_value.Rows(0).Cells("active").Value Then
                        grdlookup_value.CurrentCell = grdlookup_value.Rows(0).Cells("active")
                    Else
                        grdlookup_value.CurrentCell = grdlookup_value.Rows(1).Cells("active")
                    End If
                    grdlookup_value.CurrentCell = cell
                End If
            End If
        End If

        Dim objdb As New classLookup

        Dim lookUp_value As New classLookup.Lookup_value

        lookUp_value.lookup_type_id = cboLookup_type.SelectedValue

        Dim dv_lookup As DataTable = grdlookup_value.DataSource
        ' Dim 

        Dim dv_Insert As New DataView(dv_lookup, "", "", DataViewRowState.Added)
        Dim dv_Update As New DataView(dv_lookup, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_Delete As New DataView(dv_lookup, "", "", DataViewRowState.Deleted)


        If objdb.Savedata(lookUp_value, dv_Insert, dv_Update, dv_Delete, clsuser:=clsuser) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            GenGrid()
            SaveData = True
        Else
            MessageBox.Show(lookUp_value.message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

            SaveData = False
        End If

    End Function

    Private Function CheckData() As Boolean
        Dim dt As New DataTable
        dt = grdlookup_value.DataSource
        If cboLookup_type.SelectedValue <> DesignApplicationId Then
            If dt.Rows.Count > 0 Then
                Select Case cboLookup_type.SelectedValue
                    Case DesignSubApplication 'DesignAppl, DesignSubApplication, DesignSplFunction, PatternType, DesignFamilyName
                        For Each dr As DataRow In dt.Rows
                            If dr.RowState = DataRowState.Added Or dr.RowState = DataRowState.Modified Then
                                If (New clsConfig).IsNull(dr("parent_lookup_value_id"), 0) = 0 Then
                                    MessageBox.Show("คุณต้องระบุ Application ด้วยครับ ถึงจะบันทึกได้" & vbCrLf & "Program Need Appilcation too (Please Enter)" _
                                                    , "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error
                                                    )
                                    Return False
                                    Exit Function
                                End If
                            End If
                        Next
                End Select

            End If
        End If

        Return True
    End Function

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call IntiControl()
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub grdlookup_value_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdlookup_value.CellContentClick

    End Sub

    Private Sub grdlookup_value_CellStyleContentChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellStyleContentChangedEventArgs) Handles grdlookup_value.CellStyleContentChanged

    End Sub

    Private Sub grdlookup_value_CellValidating(sender As Object, e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles grdlookup_value.CellValidating
        '  If grdlookup_value.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing Then
        ' Show the user a message
        'MessageBox.Show("You have left the cell empty")

        ' Fail validation (prevent them from leaving the cell)
        ' e.Cancel = True
        ' End If
    End Sub

    Private Sub grdlookup_value_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles grdlookup_value.CurrentCellDirtyStateChanged
       
    End Sub

    Private Sub DemonstrateRowState()
        Dim i As Integer

        ' Create a DataTable with one column.
        Dim dataTable As New DataTable("dataTable")
        Dim dataColumn As New DataColumn("dataColumn")
        dataTable.Columns.Add(dataColumn)

        ' Add ten rows.
        Dim dataRow As DataRow
        For i = 0 To 9
            dataRow = dataTable.NewRow()
            dataRow("dataColumn") = "item " + i.ToString()
            dataTable.Rows.Add(dataRow)
        Next i
        dataTable.AcceptChanges()

        ' Create a DataView with the table.
        Dim dataView As New DataView(dataTable)

        ' Change one row's value:
        dataTable.Rows(1)("dataColumn") = "Hello"

        ' Add one row:
        dataRow = dataTable.NewRow()
        dataRow("dataColumn") = "World"
        dataTable.Rows.Add(dataRow)

        ' Set the RowStateFilter to display only Added and modified rows.
        dataView.RowStateFilter = _
        DataViewRowState.Added Or DataViewRowState.ModifiedCurrent

        ' Print those rows. Output = "Hello" "World";
        PrintView(dataView, "ModifiedCurrent and Added")

        ' Set filter to display on originals of modified rows.
        dataView.RowStateFilter = DataViewRowState.ModifiedOriginal
        PrintView(dataView, "ModifiedOriginal")

        ' Delete three rows.
        dataTable.Rows(1).Delete()
        dataTable.Rows(2).Delete()
        dataTable.Rows(3).Delete()

        ' Set the RowStateFilter to display only Added and modified rows.
        dataView.RowStateFilter = DataViewRowState.Deleted
        PrintView(dataView, "Deleted")

        'Set filter to display only current.
        dataView.RowStateFilter = DataViewRowState.CurrentRows
        PrintView(dataView, "Current")

        ' Set filter to display only unchanged rows.
        dataView.RowStateFilter = DataViewRowState.Unchanged
        PrintView(dataView, "Unchanged")

        ' Set filter to display only original rows.
        dataView.RowStateFilter = DataViewRowState.OriginalRows
        PrintView(dataView, "OriginalRows")
    End Sub

    Private Sub PrintView(ByVal dataView As DataView, ByVal label As String)

        'Console.WriteLine(ControlChars.Cr + label)
        Dim i As Integer
        For i = 0 To dataView.Count - 1
            'Console.WriteLine(dataView(i)("dataColumn"))
            MessageBox.Show(dataView(i)("dataColumn"))
        Next i
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Call DemonstrateRowState()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Call GetNewLookUp()
    End Sub

    Private Sub grdlookup_value_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles grdlookup_value.DataError

    End Sub
End Class