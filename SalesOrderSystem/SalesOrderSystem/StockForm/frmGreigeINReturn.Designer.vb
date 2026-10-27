<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGreigeINReturn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreigeINReturn))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtSourceRefNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.tran_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_greige_do = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outkg_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outmt_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outyd_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtUnselectedRolls = New System.Windows.Forms.TextBox()
        Me.txtUnselectedMts = New System.Windows.Forms.TextBox()
        Me.txtUnselectedYds = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtUnselectedKgs = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSelectedRolls = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSelectedMts = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSelectedYds = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSelectedKgs = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtGinno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbomtl_locations = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.BtnPrintBarcode = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpGINDate = New System.Windows.Forms.DateTimePicker()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbGInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbGInTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.ToolStripDropDownButton1, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(818, 25)
        Me.ToolStrip1.TabIndex = 4
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel1.Text = "G-IN No."
        '
        'cboDocNo
        '
        Me.cboDocNo.Name = "cboDocNo"
        Me.cboDocNo.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'txtSourceRefNo
        '
        Me.txtSourceRefNo.Location = New System.Drawing.Point(80, 79)
        Me.txtSourceRefNo.Name = "txtSourceRefNo"
        Me.txtSourceRefNo.Size = New System.Drawing.Size(224, 22)
        Me.txtSourceRefNo.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 312
        Me.Label5.Text = "Ref No."
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeight = 30
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tran_no, Me.id_greige_do, Me.roll_no, Me.roll_no_g, Me.roll_no_o, Me.loc, Me.design_no, Me.grade, Me.outkg_g, Me.outmt_g, Me.outyd_g, Me.selected})
        Me.grdData.Location = New System.Drawing.Point(8, 143)
        Me.grdData.MultiSelect = False
        Me.grdData.Name = "grdData"
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(801, 249)
        Me.grdData.TabIndex = 3
        '
        'tran_no
        '
        Me.tran_no.DataPropertyName = "tran_no"
        Me.tran_no.HeaderText = "GIN No."
        Me.tran_no.Name = "tran_no"
        Me.tran_no.Visible = False
        '
        'id_greige_do
        '
        Me.id_greige_do.DataPropertyName = "id_greige_do"
        Me.id_greige_do.HeaderText = "ID Greige DO"
        Me.id_greige_do.Name = "id_greige_do"
        Me.id_greige_do.ReadOnly = True
        Me.id_greige_do.Visible = False
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "Roll No."
        Me.roll_no.Name = "roll_no"
        Me.roll_no.ReadOnly = True
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_g"
        Me.roll_no_g.HeaderText = "Roll No. (Greige)"
        Me.roll_no_g.Name = "roll_no_g"
        Me.roll_no_g.ReadOnly = True
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        Me.roll_no_o.ReadOnly = True
        Me.roll_no_o.Width = 120
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Location"
        Me.loc.Name = "loc"
        Me.loc.ReadOnly = True
        Me.loc.Width = 55
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        '
        'grade
        '
        Me.grade.DataPropertyName = "grade"
        Me.grade.HeaderText = "Grade"
        Me.grade.Name = "grade"
        Me.grade.ReadOnly = True
        Me.grade.Width = 50
        '
        'outkg_g
        '
        Me.outkg_g.DataPropertyName = "outkg_g"
        Me.outkg_g.HeaderText = "Kgs."
        Me.outkg_g.Name = "outkg_g"
        Me.outkg_g.Width = 50
        '
        'outmt_g
        '
        Me.outmt_g.DataPropertyName = "outmt_g"
        Me.outmt_g.HeaderText = "Mts."
        Me.outmt_g.Name = "outmt_g"
        Me.outmt_g.Width = 50
        '
        'outyd_g
        '
        Me.outyd_g.DataPropertyName = "outyd_g"
        Me.outyd_g.HeaderText = "Yds."
        Me.outyd_g.Name = "outyd_g"
        Me.outyd_g.Width = 50
        '
        'selected
        '
        Me.selected.DataPropertyName = "selected"
        Me.selected.HeaderText = "Selected"
        Me.selected.Name = "selected"
        Me.selected.Width = 55
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(312, 424)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(29, 13)
        Me.Label33.TabIndex = 331
        Me.Label33.Text = "Mts."
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(312, 400)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(27, 13)
        Me.Label34.TabIndex = 330
        Me.Label34.Text = "Yds."
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(176, 400)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(32, 13)
        Me.Label30.TabIndex = 329
        Me.Label30.Text = "Rolls"
        '
        'txtUnselectedRolls
        '
        Me.txtUnselectedRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedRolls.Location = New System.Drawing.Point(104, 400)
        Me.txtUnselectedRolls.Name = "txtUnselectedRolls"
        Me.txtUnselectedRolls.ReadOnly = True
        Me.txtUnselectedRolls.Size = New System.Drawing.Size(64, 22)
        Me.txtUnselectedRolls.TabIndex = 328
        Me.txtUnselectedRolls.Tag = "0"
        Me.txtUnselectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnselectedMts
        '
        Me.txtUnselectedMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedMts.Location = New System.Drawing.Point(216, 424)
        Me.txtUnselectedMts.Name = "txtUnselectedMts"
        Me.txtUnselectedMts.ReadOnly = True
        Me.txtUnselectedMts.Size = New System.Drawing.Size(88, 22)
        Me.txtUnselectedMts.TabIndex = 327
        Me.txtUnselectedMts.Tag = "0.00"
        Me.txtUnselectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnselectedYds
        '
        Me.txtUnselectedYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedYds.Location = New System.Drawing.Point(216, 400)
        Me.txtUnselectedYds.Name = "txtUnselectedYds"
        Me.txtUnselectedYds.ReadOnly = True
        Me.txtUnselectedYds.Size = New System.Drawing.Size(88, 22)
        Me.txtUnselectedYds.TabIndex = 326
        Me.txtUnselectedYds.Tag = "0.00"
        Me.txtUnselectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(176, 424)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(28, 13)
        Me.Label31.TabIndex = 325
        Me.Label31.Text = "Kgs."
        '
        'txtUnselectedKgs
        '
        Me.txtUnselectedKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedKgs.Location = New System.Drawing.Point(104, 424)
        Me.txtUnselectedKgs.Name = "txtUnselectedKgs"
        Me.txtUnselectedKgs.ReadOnly = True
        Me.txtUnselectedKgs.Size = New System.Drawing.Size(64, 22)
        Me.txtUnselectedKgs.TabIndex = 323
        Me.txtUnselectedKgs.Tag = "0.00"
        Me.txtUnselectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(8, 400)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(96, 13)
        Me.Label32.TabIndex = 324
        Me.Label32.Text = "Total Un-selected"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(536, 400)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 13)
        Me.Label25.TabIndex = 322
        Me.Label25.Text = "Rolls"
        '
        'txtSelectedRolls
        '
        Me.txtSelectedRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedRolls.Location = New System.Drawing.Point(464, 400)
        Me.txtSelectedRolls.Name = "txtSelectedRolls"
        Me.txtSelectedRolls.ReadOnly = True
        Me.txtSelectedRolls.Size = New System.Drawing.Size(64, 22)
        Me.txtSelectedRolls.TabIndex = 321
        Me.txtSelectedRolls.Tag = "0"
        Me.txtSelectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(672, 424)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(29, 13)
        Me.Label24.TabIndex = 320
        Me.Label24.Text = "Mts."
        '
        'txtSelectedMts
        '
        Me.txtSelectedMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedMts.Location = New System.Drawing.Point(576, 424)
        Me.txtSelectedMts.Name = "txtSelectedMts"
        Me.txtSelectedMts.ReadOnly = True
        Me.txtSelectedMts.Size = New System.Drawing.Size(88, 22)
        Me.txtSelectedMts.TabIndex = 319
        Me.txtSelectedMts.Tag = "0.00"
        Me.txtSelectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(672, 400)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 13)
        Me.Label23.TabIndex = 318
        Me.Label23.Text = "Yds."
        '
        'txtSelectedYds
        '
        Me.txtSelectedYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedYds.Location = New System.Drawing.Point(576, 400)
        Me.txtSelectedYds.Name = "txtSelectedYds"
        Me.txtSelectedYds.ReadOnly = True
        Me.txtSelectedYds.Size = New System.Drawing.Size(88, 22)
        Me.txtSelectedYds.TabIndex = 317
        Me.txtSelectedYds.Tag = "0.00"
        Me.txtSelectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(536, 424)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 13)
        Me.Label22.TabIndex = 316
        Me.Label22.Text = "Kgs."
        '
        'txtSelectedKgs
        '
        Me.txtSelectedKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedKgs.Location = New System.Drawing.Point(464, 424)
        Me.txtSelectedKgs.Name = "txtSelectedKgs"
        Me.txtSelectedKgs.ReadOnly = True
        Me.txtSelectedKgs.Size = New System.Drawing.Size(64, 22)
        Me.txtSelectedKgs.TabIndex = 314
        Me.txtSelectedKgs.Tag = "0.00"
        Me.txtSelectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(384, 400)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 315
        Me.Label21.Text = "Total Selected"
        '
        'txtGinno
        '
        Me.txtGinno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGinno.Location = New System.Drawing.Point(705, 40)
        Me.txtGinno.Name = "txtGinno"
        Me.txtGinno.ReadOnly = True
        Me.txtGinno.Size = New System.Drawing.Size(104, 22)
        Me.txtGinno.TabIndex = 332
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(641, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 333
        Me.Label2.Text = "G-IN No."
        '
        'txtOutNo
        '
        Me.txtOutNo.Location = New System.Drawing.Point(80, 40)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(96, 22)
        Me.txtOutNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 335
        Me.Label1.Text = "G-OUT No."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cbomtl_locations)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbomtl_subinventory)
        Me.GroupBox1.Location = New System.Drawing.Point(422, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 99)
        Me.GroupBox1.TabIndex = 337
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock Locations"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(198, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 303
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(198, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 302
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(198, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(11, 13)
        Me.Label14.TabIndex = 301
        Me.Label14.Text = "*"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(82, 19)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(110, 21)
        Me.cbomtl_warehouse.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 294
        Me.Label13.Text = "Location"
        '
        'cbomtl_locations
        '
        Me.cbomtl_locations.FormattingEnabled = True
        Me.cbomtl_locations.Location = New System.Drawing.Point(82, 73)
        Me.cbomtl_locations.Name = "cbomtl_locations"
        Me.cbomtl_locations.Size = New System.Drawing.Size(110, 21)
        Me.cbomtl_locations.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 295
        Me.Label12.Text = "Sub Inven"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 298
        Me.Label11.Text = "W/H"
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(82, 46)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(110, 21)
        Me.cbomtl_subinventory.TabIndex = 3
        '
        'BtnCopy
        '
        Me.BtnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCopy.Image = CType(resources.GetObject("BtnCopy.Image"), System.Drawing.Image)
        Me.BtnCopy.Location = New System.Drawing.Point(721, 114)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(88, 23)
        Me.BtnCopy.TabIndex = 338
        Me.BtnCopy.Text = "Copy Roll"
        Me.BtnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCopy.UseVisualStyleBackColor = False
        '
        'BtnPrintBarcode
        '
        Me.BtnPrintBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintBarcode.BackColor = System.Drawing.SystemColors.Control
        Me.BtnPrintBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.BtnPrintBarcode.Image = CType(resources.GetObject("BtnPrintBarcode.Image"), System.Drawing.Image)
        Me.BtnPrintBarcode.Location = New System.Drawing.Point(721, 89)
        Me.BtnPrintBarcode.Name = "BtnPrintBarcode"
        Me.BtnPrintBarcode.Size = New System.Drawing.Size(88, 25)
        Me.BtnPrintBarcode.TabIndex = 339
        Me.BtnPrintBarcode.Text = "Print Tag"
        Me.BtnPrintBarcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrintBarcode.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(641, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 341
        Me.Label3.Text = "Date"
        '
        'dtpGINDate
        '
        Me.dtpGINDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpGINDate.Enabled = False
        Me.dtpGINDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGINDate.Location = New System.Drawing.Point(705, 67)
        Me.dtpGINDate.Name = "dtpGINDate"
        Me.dtpGINDate.Size = New System.Drawing.Size(104, 22)
        Me.dtpGINDate.TabIndex = 340
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGInDocument, Me.tsbGInTag})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'tsbGInDocument
        '
        Me.tsbGInDocument.Name = "tsbGInDocument"
        Me.tsbGInDocument.Size = New System.Drawing.Size(168, 22)
        Me.tsbGInDocument.Text = "G-IN DOCUMENT"
        '
        'tsbGInTag
        '
        Me.tsbGInTag.Name = "tsbGInTag"
        Me.tsbGInTag.Size = New System.Drawing.Size(168, 22)
        Me.tsbGInTag.Text = "G-IN Tag"
        '
        'frmGreigeINReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 457)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpGINDate)
        Me.Controls.Add(Me.BtnPrintBarcode)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtOutNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGinno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtUnselectedRolls)
        Me.Controls.Add(Me.txtUnselectedMts)
        Me.Controls.Add(Me.txtUnselectedYds)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtUnselectedKgs)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtSelectedRolls)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtSelectedMts)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtSelectedYds)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtSelectedKgs)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.txtSourceRefNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGreigeINReturn"
        Me.Text = "Greige IN Return"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSourceRefNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtUnselectedRolls As System.Windows.Forms.TextBox
    Friend WithEvents txtUnselectedMts As System.Windows.Forms.TextBox
    Friend WithEvents txtUnselectedYds As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtUnselectedKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedMts As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedYds As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtGinno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbomtl_locations As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCopy As Button
    Friend WithEvents BtnPrintBarcode As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpGINDate As DateTimePicker
    Friend WithEvents tran_no As DataGridViewTextBoxColumn
    Friend WithEvents id_greige_do As DataGridViewTextBoxColumn
    Friend WithEvents roll_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_g As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents loc As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents grade As DataGridViewTextBoxColumn
    Friend WithEvents outkg_g As DataGridViewTextBoxColumn
    Friend WithEvents outmt_g As DataGridViewTextBoxColumn
    Friend WithEvents outyd_g As DataGridViewTextBoxColumn
    Friend WithEvents selected As DataGridViewCheckBoxColumn
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents tsbGInDocument As ToolStripMenuItem
    Friend WithEvents tsbGInTag As ToolStripMenuItem
End Class
