Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class formYarnInPurchaseFromSupplier
    'Public loginEmpcd As String
    Dim clsYarn As New GetDataYarn
    Dim clsMaster As New classMaster
    Dim clsConfig As New clsConfig
    Dim jobID As Long = 0
    Dim jobQty As Single = 0
    Dim netKg As Single = 0
    Dim docno As String = ""
    Dim Stritcd As String = ""
    Dim clsUser As New classUserInfo

    Dim dtMtlWarehouse As New DataTable
    Dim bsMtlWarehouse As New BindingSource
    Dim dtMtlSubInventory As New DataTable
    Dim bsMtlSubInventory As New BindingSource
    Dim dtmtlLocations As New DataTable
    Dim bsMtlLocations As New BindingSource

    Dim dtYarnIn As New DataTable
    Dim bsYarnIn As New BindingSource
    Dim drvYarnIn As DataRowView

    Dim dtYarnInDet As New DataTable
    Dim bsYarnInDet As New BindingSource
    Dim drvYarnInDet As DataRowView

    Dim dtDoutBarcodeNew As New DataTable
    Dim bsDoutBarcodeNew As New BindingSource

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub InitControl()
        docno = ""
        txtDocNo.Text = ""
        txtPONo.Text = ""
        txtInterfaceYarnOutno.Text = ""
        dtpDocDate.Value = Now
        cboSupplier.SelectedValue = ""
        txtSuppInvNo.Text = ""
        txtSuppLot.Text = ""
        dtpSinvdt.Text = ""
        txtSuppRefNo.Text = ""
        txtRemark.Text = ""

        txtTotalBoxes.Text = ""
        txtTotalTubes.Text = ""
        txtTotalGrossWeight.Text = ""
        txtTotalNetWeight.Text = ""
        txtInterfaceYarnOutno.ReadOnly = False

        Dim sender As New System.Object
        Dim e As New System.EventArgs

        Call GenCombo()

        Call GenComboGradeOur()

        Call LoadDataJOB(txtPONo.Text.Trim)

        Call LoadDataYarn(txtDocNo.Text.Trim)


    End Sub


    'Private Sub genComboLoc()
    '    Dim clsmaster As New classMaster
    '    Dim dt As DataTable = clsMaster.GetWareHouse


    '    loc.DataSource = dt
    '    loc.ValueMember = "loc"
    '    loc.DisplayMember = "loc"


    '    'mtl_warehouse.DataSource = clsmaster.Combomtlwarehouse(clsUser.UserID)
    '    'mtl_warehouse.DisplayMember = "warehouse_name"
    '    'mtl_warehouse.ValueMember = "mtl_warehouse_id"


    '    'mtl_Location.DataSource = clsmaster.Combomtllocations(Int64mtl_warehouse_id:=0, strUSerID:=clsUser.UserID)
    '    'mtl_Location.DisplayMember = "location_name"
    '    'mtl_Location.ValueMember = "mtl_locations_id"


    'End Sub
    Private Sub genComboLocByYarnInDet()

        Dim clsYarnIN As New classYarnIn
        Dim dt As DataTable = clsYarnIN.GetLocationByYarnInDet

        'loc.DataSource = dt
        'loc.ValueMember = "loc"
        ' loc.DisplayMember = "loc"

    End Sub
    Private Sub GenCombo()


        cbomtl_warehouse.DataSource = (New classMaster).Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

        cbomtl_subinventory.DataSource = (New classMaster).GetCombomtl_subinventory(0)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        cbomtl_subinventory.SelectedIndex = -1

        cbomtl_locations.DataSource = (New classMaster).Combomtllocations(strUSerID:=clsUser.UserID,
                                         INt64mtl_warehouse_id:=0,
                                         Int64mtl_subinventory_id:=0)
        cbomtl_locations.DisplayMember = "location_name"
        cbomtl_locations.ValueMember = "mtl_locations_id"
        cbomtl_locations.SelectedIndex = -1


        'Call GetComboNewWarehouse()
        'Call GetComboNewSubInventory(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue)
        'Call GetComboLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue,
        '                     Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue,
        '                     Int64mtl_locations_id:=cbomtl_locations.SelectedValue)

        'Call GetComboWarehouseinGrid()
        'Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=objdb.GetdefaultWarehouse(strUSerID:=UserInfo.UserID))
        'Call GetCombomtl_locationInGrid(Int64mtl_warehouse_id:=objdb.GetdefaultWarehouse(strUSerID:=UserInfo.UserID), _
        '                                 Int64mtl_subinventory_id:=0)



        Dim dt As DataTable = clsYarn.GetSupplier()
        cboSupplier.DataSource = dt
        cboSupplier.DisplayMember = "name"
        cboSupplier.ValueMember = "suppcd"
        cboSupplier.SelectedIndex = 0

        dt = clsYarn.getItems()
        cboITCD.DataSource = dt
        cboITCD.DisplayMember = "itcd_desc"
        cboITCD.ValueMember = "itcd"
    End Sub

    Private Sub GetComboNewWarehouse()
        Dim objdb As New classMaster

        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

        cbomtl_warehouse.SelectedValue = objdb.GetdefaultWarehouse(strUSerID:=clsUser.UserID)

    End Sub

    Private Sub GetComboNewSubInventory(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.GetCombomtl_subinventory((New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"
        cbomtl_subinventory.SelectedIndex = -1

        Dim dt As DataTable = cbomtl_subinventory.DataSource
        If dt.Rows.Count > 0 Then
            Call Setdefaultsubinventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))
        End If
        'Setdefaultsubinventory(cboNewmtl_subinventory.DataSource)
    End Sub

    Private Sub GetComboLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing,
                                 Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing,
                                 Optional ByVal Int64mtl_locations_id As Nullable(Of Int64) = Nothing)
        Dim objdb As New classMaster
        cbomtl_locations.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID,
                                         INt64mtl_warehouse_id:=(New clsConfig).IsNull(Int64mtl_warehouse_id, Nothing),
                                         Int64mtl_subinventory_id:=(New clsConfig).IsNull(Int64mtl_subinventory_id, Nothing))

        cbomtl_locations.DisplayMember = "location_name"
        cbomtl_locations.ValueMember = "mtl_locations_id"
        cbomtl_locations.SelectedIndex = -1

        Dim dt As DataTable = cbomtl_locations.DataSource
        If dt.Rows.Count > 0 Then
            Call SetDefaultLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                                    Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
        End If
    End Sub

    'Private Sub SetdefaultWarehouse()
    '    Dim clsMaster As New classMaster
    '    Dim dt As DataTable = clsMaster.GetdefaultWarehouse(clsUser.UserID)

    '    If dt.Rows.Count > 0 Then
    '        cboNewmtl_warehouse.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
    '    End If

    'End Sub

    Private Sub Setdefaultsubinventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing)
        Dim clsMaster As New classMaster

        If cbomtl_subinventory.Items.Count > 0 And Not Int64mtl_warehouse_id Is Nothing Then
            'Sitthana 09/05/2018 Change from YARN to ESH_YS000
            'cbomtl_subinventory.SelectedValue = clsMaster.GetdefaultSubinventory(Int64mtl_warehouse_id, Strsubinventory_code:="YARN", strUSerID:=clsUser.UserID)
            Dim Strsubinventory_code As String = ""
            Select Case Int64mtl_warehouse_id
                Case 4 'Eschler
                    Strsubinventory_code = "ESH_YS000"
                Case 5 'S&T
                    Exit Sub
                Case Else
                    Strsubinventory_code = "YARN"
            End Select
            cbomtl_subinventory.SelectedValue = clsMaster.GetdefaultSubinventory(Int64mtl_warehouse_id _
                                                                               , Strsubinventory_code:=Strsubinventory_code _
                                                                               , strUSerID:=clsUser.UserID
                                                                               )
        End If

    End Sub

    Private Sub SetDefaultLocation(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing, Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing)
        Dim clsMaster As New classMaster
        Dim dt As DataTable = clsMaster.Getdefaultlocations(Int64mtl_warehouse_id:=Int64mtl_warehouse_id,
                                                            Int64mtl_subinventory_id:=Int64mtl_subinventory_id,
                                                            Strlocation_name:="N/A",
                                                            strUSerID:=clsUser.UserID)
        If dt.Rows.Count > 0 Then
            cbomtl_locations.SelectedValue = dt.Rows(0)("mtl_locations_id")
        End If


    End Sub
    Private Sub GetComboWarehouseinGrid()
        Dim objdb As New classMaster
        mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
        mtl_warehouse_id.DisplayMember = "warehouse_name"
        mtl_warehouse_id.ValueMember = "mtl_warehouse_id"



    End Sub

    Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster
        mtl_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
        mtl_subinventory_id.DisplayMember = "subinventory_name"
        mtl_subinventory_id.ValueMember = "mtl_subinventory_id"
    End Sub

    Private Sub GetCombomtl_locationInGrid(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster
        mtl_locations_id.DataSource = objdb.Combomtllocations(strUSerID:=clsUser.UserID _
                             , INt64mtl_warehouse_id:=Int64mtl_warehouse_id _
                             , Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        mtl_locations_id.DisplayMember = "location_name"
        mtl_locations_id.ValueMember = "mtl_locations_id"
    End Sub

    Private Sub LoadDataJOB(ByVal jobno As String)
        Dim dt As DataTable

        If txtPONo.Text.Trim = ("FREE SAMPLE") Or txtPONo.Text.Trim = ("FREE OF CHARGE") Or txtPONo.Text.Trim = ("ADJUST IN") Then
            dt = clsYarn.getJobFree(jobno)
        Else
            dt = clsYarn.getJob(jobno)
        End If

        grdPO.AutoGenerateColumns = False
        grdPO.DataSource = dt

        If dt.Rows.Count > 0 Then
            jobID = clsConfig.IsNull(dt.Rows(0).Item("id_jobdet"), 0)
            cboSupplier.SelectedValue = clsConfig.IsNull(dt.Rows(0).Item("suppcd"), "006")
        End If

    End Sub

    Private Sub LoadDataYarn(ByVal docno As String)

        dtYarnInDet = (New classYarnInPurchaseFromSupplier).GetDataYarnIn(docno, "")
        bsYarnInDet.DataSource = dtYarnInDet

        grdYarnIN.AutoGenerateColumns = False
        grdYarnIN.DataSource = dtYarnInDet 'bsYarnInDet

        If dtYarnInDet.Rows.Count > 0 Then


            cbomtl_warehouse.SelectedValue = dtYarnInDet.Rows(0)("mtl_warehouse_id")
            Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(dtYarnInDet.Rows(0)("mtl_warehouse_id"), Nothing))
            cbomtl_subinventory.SelectedValue = dtYarnInDet.Rows(0)("mtl_subinventory_id")
            Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(dtYarnInDet.Rows(0)("mtl_warehouse_id"), Nothing),
                                  Int64mtl_subinventory_id:=(New clsConfig).IsNull(dtYarnInDet.Rows(0)("mtl_subinventory_id"), Nothing))
            cbomtl_locations.SelectedValue = dtYarnInDet.Rows(0)("mtl_locations_id")

            Me.docno = docno
            txtDocNo.Text = docno.Trim

            Call LoadDataJOB(clsConfig.IsNull(dtYarnInDet.Rows(0)("purno"), ""))

            Call SumGrid(dtYarnInDet)
            Call BindDataText(dtYarnInDet)

        End If
    End Sub

    Private Function AddNewBox() As Boolean
        If grdPO.Rows.Count = 0 Then
            Return False
            Exit Function
        End If
        If grdPO.CurrentRow.Cells("colID").Value Is DBNull.Value Then
            Return False
            Exit Function
        End If


        Dim dtc As New DataTable
        dtc = grdYarnIN.DataSource


        Dim newRow As DataRow
        Dim Int32id_jobdet As Nullable(Of Int32)
        Dim strItcd As String

        Int32id_jobdet = grdPO.CurrentRow.Cells("colID").Value
        strItcd = grdPO.CurrentRow.Cells("itcd").Value

        'grdPO.CurrentRow.Cells("colID").Value

        newRow = dtc.NewRow

        If grdPO.Rows.Count > 0 Then
            newRow.Item("id_jobdet") = Int32id_jobdet
            newRow.Item("itcd") = strItcd
            newRow.Item("grade_our") = "BF"
        End If


        dtc.Rows.Add(newRow)


        SumGrid(grdYarnIN.DataSource)


    End Function

    Private Sub AddBoxFromSupplier()

        If dtDoutBarcodeNew.Rows.Count = 0 Then
            MessageBox.Show("ยังไม่ได้เลือก Yarn Out No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If grdPO.Rows.Count = 0 Then
            MessageBox.Show("ยังไม่ได้เลือก P/O Line.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim dtDoutNew As DataTable = grdYarnIN.DataSource
        If dtDoutBarcodeNew.Rows.Count > 0 And grdPO.Rows.Count > 0 Then
            Dim config As New clsConfig
            'Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0

            'bsDoutBarcodeNew.DataSource = dtDoutBarcodeNew
            If grdPO.CurrentRow.Cells("suppitcd").Value.ToString.Trim.Length > 0 Then
                bsDoutBarcodeNew.Filter = "suppitcd = '" & (New clsConfig).IsNull(grdPO.CurrentRow.Cells("suppitcd").Value, "") & "'"
            End If
            ' bsDoutBarcodeNew.Filter = "suppitcd = '" & (New clsConfig).IsNull(grdPO.CurrentRow.Cells("suppitcd").Value, "") & "'"

            Dim dv As DataView = CType(bsDoutBarcodeNew.List, DataView)
            Dim dtnew = dv.ToTable()
            For Each drNew As DataRow In dtDoutBarcodeNew.Rows
                drNew.Item("itcd") = grdPO.CurrentRow.Cells("itcd").Value
                drNew.Item("id_jobdet") = grdPO.CurrentRow.Cells("colID").Value
                dtDoutNew.ImportRow(drNew)

            Next

            grdYarnIN.Refresh()
            Call SumGrid(grdYarnIN.DataSource)
        End If

    End Sub

    Private Function CheckDuplicate(ByVal strRollNo As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("outno").ToString.Trim = strRollNo Then Return True
                End If
            Next
        End If
        Return False
    End Function


    Private Function GetNewYarnInDet() As Boolean

        Dim dtc As DataTable = grdYarnIN.DataSource

        Dim newRow As DataRow


        'newRow("mtl_warehouse_id") = clsConfig.IsNull(dtc.Rows(0)("mtl_warehouse_id"), DBNull.Value)
        'newRow("mtl_locations_id") = clsConfig.IsNull(dtc.Rows(0)("mtl_locations_id"), DBNull.Value)


        newRow = dtc.NewRow


        dtc.Rows.Add(newRow)


        SumGrid(grdYarnIN.DataSource)

    End Function

    Private Sub mDGV_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs)
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim cell As DataGridViewComboBoxCell = TryCast(dgv.CurrentCell, DataGridViewComboBoxCell)

        If cell IsNot Nothing AndAlso Not cell.Items.Contains(e.FormattedValue) Then

            ' Insert the new value into position 0
            ' in the item collection of the cell
            cell.Items.Insert(0, e.FormattedValue)
            ' When setting the Value of the cell, the  
            ' string is not shown until it has been
            ' comitted. The code below will make sure 
            ' it is committed directly.
            If dgv.IsCurrentCellDirty Then
                ' Ensure the inserted value will 
                ' be shown directly.
                ' First tell the DataGridView to commit 
                ' itself using the Commit context...
                dgv.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
            ' ...then set the Value that needs 
            ' to be committed in order to be displayed directly.
            cell.Value = cell.Items(0)
        End If
    End Sub

    Private Sub BindDataText(ByVal dt As DataTable)
        dtpDocDate.Value = CDate(dt.Rows(0)("docdt2"))
        txtPONo.Text = clsConfig.IsNull(dt.Rows(0)("purno"), "")
        cboSupplier.SelectedValue = dt.Rows(0)("suppcd")
        txtSuppInvNo.Text = clsConfig.IsNull(dt.Rows(0)("sinvno"), "")
        dtpSinvdt.Text = clsConfig.IsNull(dt.Rows(0)("sinvdt"), Now)
        txtSuppLot.Text = clsConfig.IsNull(dt.Rows(0)("lotno_sup"), "")
        txtSuppRefNo.Text = clsConfig.IsNull(dt.Rows(0)("srefno"), "")
        txtRemark.Text = clsConfig.IsNull(dt.Rows(0)("remark"), "")
    End Sub

    Private Sub SumGrid(ByVal dt As DataTable)
        Dim spools As Single = 0
        Dim kg_gr As Single = 0
        Dim kg_nt As Single = 0
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    'dblKgs = dblKgs + config.IsNull(grdData.Rows(i).Cells("kg").Value, 0)
                    If dt.Rows(i).RowState = DataRowState.Added Or dt.Rows(i).RowState = DataRowState.Modified Then
                        spools = spools + Val(clsConfig.IsNull(dt.Rows(i).Item("spools"), 0))
                        kg_gr = kg_gr + Val(clsConfig.IsNull(dt.Rows(i).Item("kg_gr"), 0))
                        kg_nt = kg_nt + Val(clsConfig.IsNull(dt.Rows(i).Item("kg_nt"), 0))
                    End If


                Next
                txtTotalBoxes.Text = FormatNumber(dt.Rows.Count, 0, TriState.False, TriState.False, TriState.False)
                txtTotalTubes.Text = FormatNumber(spools, 0, TriState.False, TriState.False, TriState.False)
                txtTotalGrossWeight.Text = FormatNumber(kg_gr, 2, TriState.False, TriState.False, TriState.False)
                txtTotalNetWeight.Text = FormatNumber(kg_nt, 2, TriState.False, TriState.False, TriState.False)
                netKg = kg_nt
            End If
        End If
    End Sub

    Private Sub SaveDataYarn()
        Dim StrMessage As String = ""
        Dim dtYarnIn As DataTable = grdYarnIN.DataSource
        Dim config As New clsConfig
        Dim YarnInHeder As New classYarnInPurchaseFromSupplier.YarnINHeader

        'comm.Parameters.AddWithValue("@docno", clsConfig.IsNull(dt.Rows(0)("docno"), ""))
        'comm.Parameters.AddWithValue("@docdt", clsConfig.IsNull(dt.Rows(0)("docdt2"), "19000101"))
        'comm.Parameters.AddWithValue("@purno", clsConfig.IsNull(dt.Rows(0)("purno"), ""))
        'comm.Parameters.AddWithValue("@sinvno", clsConfig.IsNull(dt.Rows(0)("sinvno"), ""))
        'comm.Parameters.AddWithValue("@sinvdt", clsConfig.IsNull(dt.Rows(0)("sinvdt"), ""))
        'comm.Parameters.AddWithValue("@suppcd", clsConfig.IsNull(dt.Rows(0)("suppcd"), ""))
        'comm.Parameters.AddWithValue("@lotno_sup", clsConfig.IsNull(dt.Rows(0)("lotno_sup"), ""))
        'comm.Parameters.AddWithValue("@lotno_our", clsConfig.IsNull(dt.Rows(0)("lotno_our"), ""))
        'comm.Parameters.AddWithValue("@srefno", clsConfig.IsNull(dt.Rows(0)("srefno"), ""))
        'comm.Parameters.AddWithValue("@tran_type", clsConfig.IsNull(dt.Rows(0)("tran_type"), ""))
        'comm.Parameters.AddWithValue("@remark", clsConfig.IsNull(dt.Rows(0)("remark"), ""))
        'comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)

        If dtYarnIn.Rows.Count > 0 Then
            For i = 0 To dtYarnIn.Rows.Count - 1
                If dtYarnIn.Rows(i).RowState <> DataRowState.Deleted Then
                    If config.IsNull(dtYarnIn.Rows(i)("docdt2"), "01/01/1900") <> dtpDocDate.Value.ToString("dd/MM/yyyy") Then dtYarnIn.Rows(i)("docdt2") = dtpDocDate.Value.ToString("dd/MM/yyyy")
                    If config.IsNull(dtYarnIn.Rows(i)("purno"), "") <> txtPONo.Text Then dtYarnIn.Rows(i)("purno") = txtPONo.Text
                    If config.IsNull(dtYarnIn.Rows(i)("suppcd"), "") <> cboSupplier.SelectedValue Then dtYarnIn.Rows(i)("suppcd") = cboSupplier.SelectedValue
                    If config.IsNull(dtYarnIn.Rows(i)("sinvno"), "") <> txtSuppInvNo.Text Then dtYarnIn.Rows(i)("sinvno") = txtSuppInvNo.Text
                    If config.IsNull(dtYarnIn.Rows(i)("sinvdt"), "01/01/1900") <> dtpSinvdt.Value.ToString("dd/MM/yyyy") Then dtYarnIn.Rows(i)("sinvdt") = dtpSinvdt.Value.ToString("dd/MM/yyyy")

                    If config.IsNull(dtYarnIn.Rows(i)("lotno_sup"), "") <> txtSuppLot.Text Then dtYarnIn.Rows(i)("lotno_sup") = txtSuppLot.Text

                    If config.IsNull(dtYarnIn.Rows(i)("srefno"), "") <> txtSuppRefNo.Text Then dtYarnIn.Rows(i)("srefno") = txtSuppRefNo.Text
                    If config.IsNull(dtYarnIn.Rows(i)("remark"), "") <> txtRemark.Text Then dtYarnIn.Rows(i)("remark") = txtRemark.Text
                    If config.IsNull(dtYarnIn.Rows(i)("tran_type"), "") <> "PURCHASE" Then dtYarnIn.Rows(i)("tran_type") = "PURCHASE"
                    If config.IsNull(dtYarnIn.Rows(i)("mtl_warehouse_id"), 0) <> cbomtl_warehouse.SelectedValue Then dtYarnIn.Rows(i)("mtl_warehouse_id") = cbomtl_warehouse.SelectedValue
                    If config.IsNull(dtYarnIn.Rows(i)("mtl_subinventory_id"), 0) <> cbomtl_subinventory.SelectedValue Then dtYarnIn.Rows(i)("mtl_subinventory_id") = cbomtl_subinventory.SelectedValue
                    If config.IsNull(dtYarnIn.Rows(i)("mtl_locations_id"), 0) <> cbomtl_locations.SelectedValue Then dtYarnIn.Rows(i)("mtl_locations_id") = cbomtl_locations.SelectedValue
                    If config.IsNull(dtYarnIn.Rows(i)("loc"), "") <> cbomtl_locations.Text Then dtYarnIn.Rows(i)("loc") = cbomtl_locations.Text
                End If
            Next

            If (New classYarnInPurchaseFromSupplier).UpdateYarnIN2(dtYarnIn, clsUser.UserID, docno, StrMessage) Then
                MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ErrorProvider1.Clear()
                Call LoadDataYarn(docno)
            Else
                MessageBox.Show(StrMessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            'End If
        End If
    End Sub

    Private Function CheckData() As Boolean
        Dim clsconfig As New clsConfig
        If clsconfig.IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก WareHouse")
            ErrorProvider1.SetError(cbomtl_warehouse, "คุณยังไม่ไดเลือก WareHouse")
            CheckData = False
            Exit Function
        End If

        If Val(cbomtl_subinventory.SelectedValue) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Subinventory")
            ErrorProvider1.SetError(cbomtl_subinventory, "คุณยังไม่ได้เลือก Subinventory")
            CheckData = False
            Exit Function
        End If

        If clsconfig.IsNull(cbomtl_locations.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ไดเลือก Location")
            ErrorProvider1.SetError(cbomtl_locations, "คุณยังไม่ได้เลือก Locations")
            CheckData = False
            Exit Function
        End If

        CheckData = True
    End Function

    Private Sub formYarnIN_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()

    End Sub


    Private Sub GenComboGradeOur()
        Dim classYarnIn As New classYarnIn
        Dim clsmaster As New classMaster

        Dim dt As New DataTable
        Dim dtWH As New DataTable
        Dim dtLoc As New DataTable

        dt = classYarnIn.GetDataGradeOUR()
        dtWH = clsmaster.Combomtlwarehouse(clsUser.UserID)
        dtLoc = clsmaster.Combomtllocations(INt64mtl_warehouse_id:=0, strUSerID:=clsUser.UserID)

        Dim cbograde_ourColumn As New DataGridViewComboBoxColumn
        Dim cbomtl_warehouseColumn As New DataGridViewComboBoxColumn
        Dim cbomtl_LocationColumn As New DataGridViewComboBoxColumn

        cbograde_ourColumn = cbograde_our

        cbograde_ourColumn.DataSource = dt
        cbograde_ourColumn.DisplayMember = "grade_code"
        cbograde_ourColumn.ValueMember = "grade_code"

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
        'txtDocNo.Text = ""
        'Call LoadDataYarn("")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        grdYarnIN.EndEdit(DataGridViewDataErrorContexts.Commit)
        grdYarnIN.CurrentCell = grdYarnIN.Rows(0).Cells(0)

        Dim result As DialogResult
        result = MessageBox.Show("Would you Like To save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveDataYarn()
    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim clsConn As New classConnection
        Dim rptFileName As String = "rptYarnIn.rpt"
        Dim frm As New frmReport

        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtDocNo.Text)

        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrintBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintBarcode.Click
        If docno.Length = 0 Then Exit Sub
        Dim frm As New formPrintBarcode

        frm.loginEmpcd = clsUser.UserID
        frm.UserInfo = clsUser
        frm.Show()

        frm.txtYarn_in_no.Text = docno

        frm.btnFindByYarnInClick()
        frm.SelectAll(sender, e)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPONo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPONo.KeyDown
        If e.KeyCode = Keys.Enter Then LoadDataJOB(txtPONo.Text.Trim)
    End Sub

    Private Sub txtDocNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDocNo.KeyDown
        If e.KeyCode = Keys.Enter Then LoadDataYarn(txtDocNo.Text.Trim)
    End Sub

    Private Sub grdPO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If grdPO.Rows.Count > 0 Then
            jobID = grdPO.Rows(e.RowIndex).Cells("colID").Value
            Stritcd = grdPO.Rows(e.RowIndex).Cells("itcd").Value

        End If

    End Sub

    Private Sub grdYarnIN_CausesValidationChanged(sender As Object, e As System.EventArgs) Handles grdYarnIN.CausesValidationChanged

    End Sub



    Private Sub grdYarnIN_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles grdYarnIN.DefaultValuesNeeded
        'If grdYarnIN.Rows.Count > 1 And e.Row.Index > 0 Then

        '    Try
        '        e.Row.Cells("cboitcd").Value = grdPO.CurrentRow.Cells("itcd").Value
        '        e.Row.Cells("grade").Value = grdYarnIN.Item("grade", e.Row.Index - 1).Value
        '        e.Row.Cells("cbograde_our").Value = grdYarnIN.Item("cbograde_our", e.Row.Index - 1).Value 'Add By Neung
        '        e.Row.Cells("spools").Value = grdYarnIN.Item("spools", e.Row.Index - 1).Value
        '        e.Row.Cells("kg_gr").Value = grdYarnIN.Item("kg_gr", e.Row.Index - 1).Value
        '        e.Row.Cells("kg_nt").Value = grdYarnIN.Item("kg_nt", e.Row.Index - 1).Value
        '        e.Row.Cells("cart_tearwt").Value = grdYarnIN.Item("cart_tearwt", e.Row.Index - 1).Value
        '        e.Row.Cells("loc").Value = grdYarnIN.Item("loc", e.Row.Index - 1).Value
        '        e.Row.Cells("mtl_warehouse_id").Value = grdYarnIN.Item("mtl_warehouse_id", e.Row.Index - 1).Value 'Add By Neung
        '        e.Row.Cells("mtl_locations_id").Value = grdYarnIN.Item("mtl_locations_id", e.Row.Index - 1).Value 'Add By Neung
        '    Catch ex As Exception

        '    End Try

        'End If

        'If grdPO.Rows.Count > 0 Then
        '    e.Row.Cells("id_jobdet").Value = grdPO.CurrentRow.Cells("colID").Value

        'End If

    End Sub



    Private Sub grdYarnIN_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnIN.RowLeave
        If Not grdYarnIN.DataSource Is Nothing Then
            If grdYarnIN.Rows.Count > 1 Then
                If grdYarnIN.CurrentCell.IsInEditMode Then
                    Dim cell As DataGridViewCell = grdYarnIN.CurrentCell
                    If grdYarnIN.EndEdit(DataGridViewDataErrorContexts.Commit) Then
                        grdYarnIN.CurrentCell = grdYarnIN.Rows(0).Cells(0)
                        grdYarnIN.CurrentCell = cell
                    Else
                        grdYarnIN.CancelEdit()
                    End If
                End If
            End If
        End If
        Call SumGrid(grdYarnIN.DataSource)
    End Sub

    Private Sub grdPO_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPO.CellContentDoubleClick
        Call AddNewBox()
    End Sub

    Private Sub grdPO_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPO.RowEnter


    End Sub

    Private Sub grdPO_CellEnter(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPO.CellEnter


    End Sub



    Private Sub grdYarnIN_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnIN.CellEndEdit
        SumGrid(grdYarnIN.DataSource)

    End Sub

    Private Sub grdPO_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPO.CellContentClick

    End Sub

    Private Sub txtPONo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPONo.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        'Call AddNewBox()

        Call AddBoxFromSupplier()
    End Sub

    Private Sub grdYarnIN_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnIN.CellContentClick

    End Sub

    Private Sub btnDel_Click(sender As System.Object, e As System.EventArgs) Handles btnDel.Click
        Dim result As DialogResult
        result = MessageBox.Show("Would You Like To Delete New Box ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.No Then Exit Sub
        RemoveNewBox()
    End Sub
    Private Sub RemoveNewBox()

        For Each row As DataGridViewRow In grdYarnIN.SelectedRows
            grdYarnIN.Rows.Remove(row)
        Next
    End Sub

    Private Function GetCopyStep(ByVal Qty As Integer) As Boolean
        Dim objdb As New classMaster
        Dim dtc As DataTable = grdYarnIN.DataSource


        Dim newRow As DataRow
        If grdYarnIN.Rows.Count > 0 Then
            For i = 1 To Qty

                newRow = dtc.NewRow

                newRow.Item("itcd") = grdYarnIN.CurrentRow.Cells("cboITCD").Value
                newRow.Item("grade") = grdYarnIN.CurrentRow.Cells("grade").Value
                newRow.Item("grade_our") = grdYarnIN.CurrentRow.Cells("cbograde_our").Value
                newRow.Item("boxno_s") = grdYarnIN.CurrentRow.Cells("boxno_s").Value
                newRow.Item("spools") = grdYarnIN.CurrentRow.Cells("spools").Value
                newRow.Item("kg_gr") = grdYarnIN.CurrentRow.Cells("kg_gr").Value
                newRow.Item("kg_nt") = grdYarnIN.CurrentRow.Cells("kg_nt").Value
                newRow.Item("cart_tearwt") = grdYarnIN.CurrentRow.Cells("cart_tearwt").Value
                newRow.Item("boxno") = grdYarnIN.CurrentRow.Cells("boxno").Value
                newRow.Item("loc") = grdYarnIN.CurrentRow.Cells("loc").Value
                newRow.Item("mtl_warehouse_id") = clsConfig.IsNull(grdYarnIN.CurrentRow.Cells("mtl_warehouse_id").Value, DBNull.Value)

                'Dim dt = New DataTable
                'dt = objdb.GetCombomtl_subinventory(clsConfig.IsNull(grdYarnIN.CurrentRow.Cells("mtl_warehouse_id").Value, 1))
                'newRow.Item("mtl_subinventory_id") = dt.NewRow

                newRow.Item("mtl_subinventory_id") = clsConfig.IsNull(grdYarnIN.CurrentRow.Cells("mtl_subinventory_id").Value, DBNull.Value)
                newRow.Item("mtl_locations_id") = clsConfig.IsNull(grdYarnIN.CurrentRow.Cells("mtl_locations_id").Value, DBNull.Value)
                newRow.Item("loc_sub") = grdYarnIN.CurrentRow.Cells("loc_sub").Value
                newRow.Item("id_jobdet") = grdYarnIN.CurrentRow.Cells("id_jobdet").Value
                newRow.Item("box_remark") = grdYarnIN.CurrentRow.Cells("box_remark").Value


                dtc.Rows.Add(newRow)

            Next

            Return True
        End If

        Return False

    End Function

    Private Sub grdYarnIN_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles grdYarnIN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call GetCopyStep(1)
        End If
    End Sub

    Private Sub txtDocNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDocNo.TextChanged

    End Sub


    Private Sub grdYarnIN_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnIN.CellValueChanged


    End Sub

    Private Sub grdYarnIN_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnIN.CellClick
        'grdYarnIN.BeginEdit(True)
        'If grdYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse").Selected = True Then

        '    'DirectCast(grdYarnIN.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
        '    Dim dgvcc As New DataGridViewComboBoxCell

        '    dgvcc = grdYarnIN.Rows(e.RowIndex).Cells("mtl_Location")


        '    dgvcc.DataSource = clsMaster.CombomtllocationsByWarehouse_id(Int64mtl_warehouse_id:=grdYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse").Value, strUSerID:=clsUser.UserID)
        '    dgvcc.DisplayMember = "location_name"
        '    dgvcc.ValueMember = "mtl_locations_id"
        '    DirectCast(grdYarnIN.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
        'End If

        'If grdYarnIN.Columns(e.ColumnIndex).Name = "mtl_warehouse" Then


        '    Dim dgvcc As New DataGridViewComboBoxCell

        '    dgvcc = grdYarnIN.Rows(e.RowIndex).Cells("mtl_Location")


        '    dgvcc.DataSource = clsMaster.Combomtllocations(Int64mtl_warehouse_id:=grdYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse").Value, strUSerID:=clsUser.UserID)
        '    dgvcc.DisplayMember = "location_name"
        '    dgvcc.ValueMember = "mtl_locations_id"

        'End If
    End Sub

    Private Sub grdYarnIN_CellValidated(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdYarnIN.CellValidated
        'Auto
        Dim objdb As New classMaster
        Dim dgvccSubInven As New DataGridViewComboBoxCell
        Dim dtSubInven As New DataTable
        If grdYarnIN.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
            If Not IsDBNull(grdYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
                dtSubInven = objdb.GetCombomtl_subinventory(grdYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
                dgvccSubInven = grdYarnIN.Rows(e.RowIndex).Cells("mtl_subinventory_id")

                Try
                    dgvccSubInven.DataSource = dtSubInven
                    dgvccSubInven.DisplayMember = "subinventory_code"
                    dgvccSubInven.ValueMember = "mtl_subinventory_id"
                    'dgvccSubInven.Value = dtSubInven.Rows(0)("mtl_subinventory_id") 'Fix Error

                    Dim expression As String
                    expression = "subinventory_code Like '%YARN%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)
                    dgvccSubInven.Value = foundRows(0)("mtl_subinventory_id")
                Catch ex As Exception

                    'SetDefault
                    Dim expression As String
                    expression = "subinventory_code like '%YARN%'"
                    Dim foundRows() As DataRow
                    foundRows = dtSubInven.Select(expression)

                    'dgvccSubInven.Value = foundRows(0)(0)
                    dgvccSubInven.Value = DBNull.Value
                End Try
            End If
        End If

        Dim dgvcc As New DataGridViewComboBoxCell
        Dim dt3 As New DataTable
        If grdYarnIN.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Or grdYarnIN.Columns(e.ColumnIndex).Name = "mtl_subinventory_id" Then
            If Not IsDBNull(grdYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) And Not IsDBNull(grdYarnIN.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value) Then
                dt3 = objdb.Combomtllocations(clsUser.UserID, grdYarnIN.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value, grdYarnIN.Rows(e.RowIndex).Cells("mtl_subinventory_id").Value)
                dgvcc = grdYarnIN.Rows(e.RowIndex).Cells("mtl_locations_id")
                Try
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    'dgvcc.Value = dt3.Rows(0)("mtl_locations_id") 'Fix Error
                    'dgvcc.Value = grdYarnIN.Rows(e.RowIndex).Cells("mtl_locations_id").Value
                    dgvcc.Value = DBNull.Value 'K Suresh Need Default Value = Null
                Catch ex As Exception
                    dgvcc.DataSource = dt3
                    dgvcc.DisplayMember = "location_name"
                    dgvcc.ValueMember = "mtl_locations_id"
                    dgvcc.Value = DBNull.Value
                End Try
            End If
        End If
    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_subinventory.DropDownClosed
        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                        Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
    End Sub

    Private Sub cboNewmtl_subinventory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))

        Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                         Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
    End Sub


    Private Sub txtyarn_out_no_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtInterfaceYarnOutno.KeyDown

        If Not txtInterfaceYarnOutno.Text.Trim.Length > 0 Then Exit Sub

        If e.KeyCode = Keys.Enter Then

            dtDoutBarcodeNew = (New classYarnInPurchaseFromSupplier).GetDataYarnOutFromSupplier(StrOutNo:=txtInterfaceYarnOutno.Text.Trim)
            bsDoutBarcodeNew.DataSource = dtDoutBarcodeNew
            bsDoutBarcodeNew.MoveFirst()
            If dtDoutBarcodeNew.Rows.Count > 0 Then
                txtInterfaceYarnOutno.ReadOnly = True
                cboSupplier.SelectedValue = dtDoutBarcodeNew.Rows(0)("suppcd")
                txtSuppLot.Text = (New clsConfig).IsNull(dtDoutBarcodeNew.Rows(0)("lotno_sup"), "")
                txtSuppInvNo.Text = (New clsConfig).IsNull(dtDoutBarcodeNew.Rows(0)("sinvno"), "")
                dtpSinvdt.Text = (New clsConfig).IsNull(dtDoutBarcodeNew.Rows(0)("sinvdt"), "")
                txtRemark.Text = (New clsConfig).IsNull(dtDoutBarcodeNew.Rows(0)("remark"), "")
                'Begin By Sitthana 09/05/2018
                Dim firstPost As Byte = 0
                Dim endPost As Byte = 0
                firstPost = InStr(txtRemark.Text.ToUpper, "PO-")
                If firstPost > 1 Then
                    endPost = InStr(firstPost, txtRemark.Text, " ")
                    Select Case endPost
                        Case 0
                            txtPONo.Text = Mid(txtRemark.Text.ToUpper, firstPost, 9)
                        Case > 0
                            txtPONo.Text = Mid(txtRemark.Text.ToUpper, firstPost, endPost - 1)
                    End Select
                End If

                cbomtl_warehouse.SelectedValue = 4
                Call GetComboNewSubInventory(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing))

                Call GetComboLocation(Int64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, Nothing),
                         Int64mtl_subinventory_id:=(New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, Nothing))
                'End  Modify By Sitthana 09/05/2018

                txtPONo.Focus()

            End If
        End If
    End Sub

    Private Sub txtInterfaceYarnOutno_TextChanged(sender As Object, e As EventArgs) Handles txtInterfaceYarnOutno.TextChanged

    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Dim userMsg As String
        userMsg = Microsoft.VisualBasic.InputBox("How many Boxes do you need to copy?" & vbCrLf & "ต้องการ Copy เพิ่มกี่กล่อง?",
                                                 "System Message", "1")

        If IsNumeric(userMsg) Then
            Call GetCopyStep(userMsg)
        End If

    End Sub
End Class