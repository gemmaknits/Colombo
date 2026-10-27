<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmfindDesignFromYarn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfindDesignFromYarn))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnDeselectItemInGrdtemsCondition = New System.Windows.Forms.Button()
        Me.grdItemsCondition = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelectItemInGrdtemsCondition = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGrdItemsConditionFillter = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbQueryByYarn = New System.Windows.Forms.RadioButton()
        Me.rbQueryByBeam = New System.Windows.Forms.RadioButton()
        Me.rbQueryByDesigns = New System.Windows.Forms.RadioButton()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.rbApproved = New System.Windows.Forms.RadioButton()
        Me.rbApprovedWait = New System.Windows.Forms.RadioButton()
        Me.rbApprovedAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbActivedCancel = New System.Windows.Forms.RadioButton()
        Me.rbActived = New System.Windows.Forms.RadioButton()
        Me.rbActivedAll = New System.Windows.Forms.RadioButton()
        Me.btnFindData = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdDesignFromYarn = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtWordFilter = New System.Windows.Forms.TextBox()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ynchgcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd_show = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ryarn_itcd_Show = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.refdesno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_active = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_approved = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_usage_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ynperc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ycd_required_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ycd_uom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sup_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ryarn_itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ryarn_itdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ryarn_ynperc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ryarn_required_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.grdItemsCondition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdDesignFromYarn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1235, 25)
        Me.ToolStrip1.TabIndex = 202
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "&Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "E&xit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox10)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 590)
        Me.GroupBox1.TabIndex = 203
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condition"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnDeselectItemInGrdtemsCondition)
        Me.GroupBox5.Controls.Add(Me.grdItemsCondition)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.btnSelectItemInGrdtemsCondition)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txtGrdItemsConditionFillter)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 101)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(327, 483)
        Me.GroupBox5.TabIndex = 207
        Me.GroupBox5.TabStop = False
        '
        'btnDeselectItemInGrdtemsCondition
        '
        Me.btnDeselectItemInGrdtemsCondition.Location = New System.Drawing.Point(258, 18)
        Me.btnDeselectItemInGrdtemsCondition.Name = "btnDeselectItemInGrdtemsCondition"
        Me.btnDeselectItemInGrdtemsCondition.Size = New System.Drawing.Size(59, 21)
        Me.btnDeselectItemInGrdtemsCondition.TabIndex = 1
        Me.btnDeselectItemInGrdtemsCondition.Text = "Deselect"
        Me.btnDeselectItemInGrdtemsCondition.UseVisualStyleBackColor = True
        '
        'grdItemsCondition
        '
        Me.grdItemsCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdItemsCondition.Location = New System.Drawing.Point(7, 49)
        Me.grdItemsCondition.Name = "grdItemsCondition"
        Me.grdItemsCondition.Size = New System.Drawing.Size(311, 424)
        Me.grdItemsCondition.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'btnSelectItemInGrdtemsCondition
        '
        Me.btnSelectItemInGrdtemsCondition.Location = New System.Drawing.Point(197, 18)
        Me.btnSelectItemInGrdtemsCondition.Name = "btnSelectItemInGrdtemsCondition"
        Me.btnSelectItemInGrdtemsCondition.Size = New System.Drawing.Size(59, 21)
        Me.btnSelectItemInGrdtemsCondition.TabIndex = 0
        Me.btnSelectItemInGrdtemsCondition.Text = "Select All"
        Me.btnSelectItemInGrdtemsCondition.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Text"
        '
        'txtGrdItemsConditionFillter
        '
        Me.txtGrdItemsConditionFillter.Location = New System.Drawing.Point(86, 19)
        Me.txtGrdItemsConditionFillter.Name = "txtGrdItemsConditionFillter"
        Me.txtGrdItemsConditionFillter.Size = New System.Drawing.Size(100, 20)
        Me.txtGrdItemsConditionFillter.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rbQueryByYarn)
        Me.GroupBox6.Controls.Add(Me.rbQueryByBeam)
        Me.GroupBox6.Controls.Add(Me.rbQueryByDesigns)
        Me.GroupBox6.Location = New System.Drawing.Point(11, 14)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(109, 86)
        Me.GroupBox6.TabIndex = 27
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Query By"
        '
        'rbQueryByYarn
        '
        Me.rbQueryByYarn.AutoSize = True
        Me.rbQueryByYarn.Location = New System.Drawing.Point(22, 61)
        Me.rbQueryByYarn.Name = "rbQueryByYarn"
        Me.rbQueryByYarn.Size = New System.Drawing.Size(47, 17)
        Me.rbQueryByYarn.TabIndex = 8
        Me.rbQueryByYarn.TabStop = True
        Me.rbQueryByYarn.Text = "Yarn"
        Me.rbQueryByYarn.UseVisualStyleBackColor = True
        '
        'rbQueryByBeam
        '
        Me.rbQueryByBeam.AutoSize = True
        Me.rbQueryByBeam.Location = New System.Drawing.Point(22, 40)
        Me.rbQueryByBeam.Name = "rbQueryByBeam"
        Me.rbQueryByBeam.Size = New System.Drawing.Size(52, 17)
        Me.rbQueryByBeam.TabIndex = 7
        Me.rbQueryByBeam.TabStop = True
        Me.rbQueryByBeam.Text = "Beam"
        Me.rbQueryByBeam.UseVisualStyleBackColor = True
        '
        'rbQueryByDesigns
        '
        Me.rbQueryByDesigns.AutoSize = True
        Me.rbQueryByDesigns.Location = New System.Drawing.Point(22, 20)
        Me.rbQueryByDesigns.Name = "rbQueryByDesigns"
        Me.rbQueryByDesigns.Size = New System.Drawing.Size(75, 17)
        Me.rbQueryByDesigns.TabIndex = 6
        Me.rbQueryByDesigns.TabStop = True
        Me.rbQueryByDesigns.Text = "Design No"
        Me.rbQueryByDesigns.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.rbApproved)
        Me.GroupBox10.Controls.Add(Me.rbApprovedWait)
        Me.GroupBox10.Controls.Add(Me.rbApprovedAll)
        Me.GroupBox10.Location = New System.Drawing.Point(229, 14)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(109, 86)
        Me.GroupBox10.TabIndex = 26
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Approved"
        '
        'rbApproved
        '
        Me.rbApproved.AutoSize = True
        Me.rbApproved.Location = New System.Drawing.Point(13, 61)
        Me.rbApproved.Name = "rbApproved"
        Me.rbApproved.Size = New System.Drawing.Size(71, 17)
        Me.rbApproved.TabIndex = 2
        Me.rbApproved.Text = "Approved"
        Me.rbApproved.UseVisualStyleBackColor = True
        '
        'rbApprovedWait
        '
        Me.rbApprovedWait.AutoSize = True
        Me.rbApprovedWait.Location = New System.Drawing.Point(13, 40)
        Me.rbApprovedWait.Name = "rbApprovedWait"
        Me.rbApprovedWait.Size = New System.Drawing.Size(90, 17)
        Me.rbApprovedWait.TabIndex = 1
        Me.rbApprovedWait.Text = "Wait Approve"
        Me.rbApprovedWait.UseVisualStyleBackColor = True
        '
        'rbApprovedAll
        '
        Me.rbApprovedAll.AutoSize = True
        Me.rbApprovedAll.Checked = True
        Me.rbApprovedAll.Location = New System.Drawing.Point(13, 20)
        Me.rbApprovedAll.Name = "rbApprovedAll"
        Me.rbApprovedAll.Size = New System.Drawing.Size(36, 17)
        Me.rbApprovedAll.TabIndex = 0
        Me.rbApprovedAll.TabStop = True
        Me.rbApprovedAll.Text = "All"
        Me.rbApprovedAll.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbActivedCancel)
        Me.GroupBox4.Controls.Add(Me.rbActived)
        Me.GroupBox4.Controls.Add(Me.rbActivedAll)
        Me.GroupBox4.Location = New System.Drawing.Point(126, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(97, 86)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Actived"
        '
        'rbActivedCancel
        '
        Me.rbActivedCancel.AutoSize = True
        Me.rbActivedCancel.Location = New System.Drawing.Point(21, 61)
        Me.rbActivedCancel.Name = "rbActivedCancel"
        Me.rbActivedCancel.Size = New System.Drawing.Size(58, 17)
        Me.rbActivedCancel.TabIndex = 5
        Me.rbActivedCancel.Text = "Cancel"
        Me.rbActivedCancel.UseVisualStyleBackColor = True
        '
        'rbActived
        '
        Me.rbActived.AutoSize = True
        Me.rbActived.Location = New System.Drawing.Point(21, 40)
        Me.rbActived.Name = "rbActived"
        Me.rbActived.Size = New System.Drawing.Size(61, 17)
        Me.rbActived.TabIndex = 4
        Me.rbActived.Text = "Actived"
        Me.rbActived.UseVisualStyleBackColor = True
        '
        'rbActivedAll
        '
        Me.rbActivedAll.AutoSize = True
        Me.rbActivedAll.Checked = True
        Me.rbActivedAll.Location = New System.Drawing.Point(21, 20)
        Me.rbActivedAll.Name = "rbActivedAll"
        Me.rbActivedAll.Size = New System.Drawing.Size(36, 17)
        Me.rbActivedAll.TabIndex = 3
        Me.rbActivedAll.TabStop = True
        Me.rbActivedAll.Text = "All"
        Me.rbActivedAll.UseVisualStyleBackColor = True
        '
        'btnFindData
        '
        Me.btnFindData.Location = New System.Drawing.Point(368, 36)
        Me.btnFindData.Name = "btnFindData"
        Me.btnFindData.Size = New System.Drawing.Size(64, 23)
        Me.btnFindData.TabIndex = 204
        Me.btnFindData.Text = "Find"
        Me.btnFindData.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.grdDesignFromYarn)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(855, 531)
        Me.GroupBox2.TabIndex = 205
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'grdDesignFromYarn
        '
        Me.grdDesignFromYarn.AllowUserToAddRows = False
        Me.grdDesignFromYarn.AllowUserToDeleteRows = False
        Me.grdDesignFromYarn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDesignFromYarn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDesignFromYarn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Design_no, Me.ynchgcd, Me.itcd_show, Me.ryarn_itcd_Show, Me.refdesno, Me.compo, Me.bom_remarks, Me.remark, Me.bom_active, Me.bom_approved, Me.bom_usage_code, Me.itcd, Me.itdesc, Me.ynperc, Me.ycd_required_qty, Me.ycd_uom, Me.sup_name, Me.ryarn_itcd, Me.ryarn_itdesc, Me.ryarn_ynperc, Me.ryarn_required_qty})
        Me.grdDesignFromYarn.Location = New System.Drawing.Point(12, 19)
        Me.grdDesignFromYarn.Name = "grdDesignFromYarn"
        Me.grdDesignFromYarn.ReadOnly = True
        Me.grdDesignFromYarn.Size = New System.Drawing.Size(831, 500)
        Me.grdDesignFromYarn.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtWordFilter)
        Me.GroupBox3.Location = New System.Drawing.Point(463, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 49)
        Me.GroupBox3.TabIndex = 206
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Filter (กรองข้อมูล)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(113, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(10, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Enter Text"
        '
        'txtWordFilter
        '
        Me.txtWordFilter.Location = New System.Drawing.Point(129, 19)
        Me.txtWordFilter.Name = "txtWordFilter"
        Me.txtWordFilter.Size = New System.Drawing.Size(140, 20)
        Me.txtWordFilter.TabIndex = 0
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "Design_no"
        Me.Design_no.Frozen = True
        Me.Design_no.HeaderText = "Design No"
        Me.Design_no.Name = "Design_no"
        Me.Design_no.ReadOnly = True
        Me.Design_no.Width = 70
        '
        'ynchgcd
        '
        Me.ynchgcd.DataPropertyName = "ynchgcd"
        Me.ynchgcd.Frozen = True
        Me.ynchgcd.HeaderText = "Bom Code"
        Me.ynchgcd.Name = "ynchgcd"
        Me.ynchgcd.ReadOnly = True
        Me.ynchgcd.Width = 30
        '
        'itcd_show
        '
        Me.itcd_show.DataPropertyName = "itcd"
        Me.itcd_show.Frozen = True
        Me.itcd_show.HeaderText = "Bean Code"
        Me.itcd_show.Name = "itcd_show"
        Me.itcd_show.ReadOnly = True
        Me.itcd_show.Width = 80
        '
        'ryarn_itcd_Show
        '
        Me.ryarn_itcd_Show.DataPropertyName = "ryarn_itcd"
        Me.ryarn_itcd_Show.Frozen = True
        Me.ryarn_itcd_Show.HeaderText = "Yarn Code"
        Me.ryarn_itcd_Show.Name = "ryarn_itcd_Show"
        Me.ryarn_itcd_Show.ReadOnly = True
        Me.ryarn_itcd_Show.Width = 80
        '
        'refdesno
        '
        Me.refdesno.DataPropertyName = "refdesno"
        Me.refdesno.Frozen = True
        Me.refdesno.HeaderText = "Descption"
        Me.refdesno.Name = "refdesno"
        Me.refdesno.ReadOnly = True
        Me.refdesno.Width = 160
        '
        'compo
        '
        Me.compo.DataPropertyName = "compo"
        Me.compo.Frozen = True
        Me.compo.HeaderText = "compo"
        Me.compo.Name = "compo"
        Me.compo.ReadOnly = True
        Me.compo.Width = 120
        '
        'bom_remarks
        '
        Me.bom_remarks.DataPropertyName = "bom_remarks"
        Me.bom_remarks.HeaderText = "Bom Remark"
        Me.bom_remarks.Name = "bom_remarks"
        Me.bom_remarks.ReadOnly = True
        Me.bom_remarks.Width = 60
        '
        'remark
        '
        Me.remark.DataPropertyName = "remark"
        Me.remark.HeaderText = "Remark"
        Me.remark.Name = "remark"
        Me.remark.ReadOnly = True
        Me.remark.Width = 120
        '
        'bom_active
        '
        Me.bom_active.DataPropertyName = "bom_active"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Wingdings 2", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.bom_active.DefaultCellStyle = DataGridViewCellStyle1
        Me.bom_active.HeaderText = "Actived"
        Me.bom_active.Name = "bom_active"
        Me.bom_active.ReadOnly = True
        Me.bom_active.Width = 50
        '
        'bom_approved
        '
        Me.bom_approved.DataPropertyName = "bom_approved"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Wingdings 2", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.bom_approved.DefaultCellStyle = DataGridViewCellStyle2
        Me.bom_approved.HeaderText = "Approved"
        Me.bom_approved.Name = "bom_approved"
        Me.bom_approved.ReadOnly = True
        Me.bom_approved.Width = 50
        '
        'bom_usage_code
        '
        Me.bom_usage_code.DataPropertyName = "bom_usage_code"
        Me.bom_usage_code.HeaderText = "Usage"
        Me.bom_usage_code.Name = "bom_usage_code"
        Me.bom_usage_code.ReadOnly = True
        Me.bom_usage_code.Width = 50
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Beam Code"
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        Me.itcd.Width = 80
        '
        'itdesc
        '
        Me.itdesc.DataPropertyName = "itdesc"
        Me.itdesc.HeaderText = "Beam Descp"
        Me.itdesc.Name = "itdesc"
        Me.itdesc.ReadOnly = True
        Me.itdesc.Width = 160
        '
        'ynperc
        '
        Me.ynperc.DataPropertyName = "ynperc"
        Me.ynperc.HeaderText = "%"
        Me.ynperc.Name = "ynperc"
        Me.ynperc.ReadOnly = True
        Me.ynperc.Width = 40
        '
        'ycd_required_qty
        '
        Me.ycd_required_qty.DataPropertyName = "ycd_required_qty"
        Me.ycd_required_qty.HeaderText = "Req Qty"
        Me.ycd_required_qty.Name = "ycd_required_qty"
        Me.ycd_required_qty.ReadOnly = True
        Me.ycd_required_qty.Width = 60
        '
        'ycd_uom
        '
        Me.ycd_uom.DataPropertyName = "ycd_uom"
        Me.ycd_uom.HeaderText = "UOM"
        Me.ycd_uom.Name = "ycd_uom"
        Me.ycd_uom.ReadOnly = True
        Me.ycd_uom.Width = 40
        '
        'sup_name
        '
        Me.sup_name.DataPropertyName = "sup_name"
        Me.sup_name.HeaderText = "Supplier"
        Me.sup_name.Name = "sup_name"
        Me.sup_name.ReadOnly = True
        Me.sup_name.Width = 120
        '
        'ryarn_itcd
        '
        Me.ryarn_itcd.DataPropertyName = "ryarn_itcd"
        Me.ryarn_itcd.HeaderText = "Yarn Code"
        Me.ryarn_itcd.Name = "ryarn_itcd"
        Me.ryarn_itcd.ReadOnly = True
        Me.ryarn_itcd.Width = 80
        '
        'ryarn_itdesc
        '
        Me.ryarn_itdesc.DataPropertyName = "ryarn_itdesc"
        Me.ryarn_itdesc.HeaderText = "Yarn Description"
        Me.ryarn_itdesc.Name = "ryarn_itdesc"
        Me.ryarn_itdesc.ReadOnly = True
        Me.ryarn_itdesc.Width = 160
        '
        'ryarn_ynperc
        '
        Me.ryarn_ynperc.DataPropertyName = "ryarn_ynperc"
        Me.ryarn_ynperc.HeaderText = "Yarn (%)"
        Me.ryarn_ynperc.Name = "ryarn_ynperc"
        Me.ryarn_ynperc.ReadOnly = True
        Me.ryarn_ynperc.Width = 40
        '
        'ryarn_required_qty
        '
        Me.ryarn_required_qty.DataPropertyName = "ryarn_required_qty"
        Me.ryarn_required_qty.HeaderText = "Yarn Req Qty"
        Me.ryarn_required_qty.Name = "ryarn_required_qty"
        Me.ryarn_required_qty.ReadOnly = True
        Me.ryarn_required_qty.Width = 60
        '
        'frmfindDesignFromYarn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 628)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnFindData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmfindDesignFromYarn"
        Me.Text = "Find Design From Yarn"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.grdItemsCondition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdDesignFromYarn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnFindData As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtWordFilter As TextBox
    Friend WithEvents grdDesignFromYarn As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbActivedCancel As RadioButton
    Friend WithEvents rbActived As RadioButton
    Friend WithEvents rbActivedAll As RadioButton
    Friend WithEvents grdItemsCondition As DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rbQueryByYarn As RadioButton
    Friend WithEvents rbQueryByBeam As RadioButton
    Friend WithEvents rbQueryByDesigns As RadioButton
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents rbApproved As RadioButton
    Friend WithEvents rbApprovedWait As RadioButton
    Friend WithEvents rbApprovedAll As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnDeselectItemInGrdtemsCondition As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSelectItemInGrdtemsCondition As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGrdItemsConditionFillter As TextBox
    Friend WithEvents Design_no As DataGridViewTextBoxColumn
    Friend WithEvents ynchgcd As DataGridViewTextBoxColumn
    Friend WithEvents itcd_show As DataGridViewTextBoxColumn
    Friend WithEvents ryarn_itcd_Show As DataGridViewTextBoxColumn
    Friend WithEvents refdesno As DataGridViewTextBoxColumn
    Friend WithEvents compo As DataGridViewTextBoxColumn
    Friend WithEvents bom_remarks As DataGridViewTextBoxColumn
    Friend WithEvents remark As DataGridViewTextBoxColumn
    Friend WithEvents bom_active As DataGridViewTextBoxColumn
    Friend WithEvents bom_approved As DataGridViewTextBoxColumn
    Friend WithEvents bom_usage_code As DataGridViewTextBoxColumn
    Friend WithEvents itcd As DataGridViewTextBoxColumn
    Friend WithEvents itdesc As DataGridViewTextBoxColumn
    Friend WithEvents ynperc As DataGridViewTextBoxColumn
    Friend WithEvents ycd_required_qty As DataGridViewTextBoxColumn
    Friend WithEvents ycd_uom As DataGridViewTextBoxColumn
    Friend WithEvents sup_name As DataGridViewTextBoxColumn
    Friend WithEvents ryarn_itcd As DataGridViewTextBoxColumn
    Friend WithEvents ryarn_itdesc As DataGridViewTextBoxColumn
    Friend WithEvents ryarn_ynperc As DataGridViewTextBoxColumn
    Friend WithEvents ryarn_required_qty As DataGridViewTextBoxColumn
End Class
