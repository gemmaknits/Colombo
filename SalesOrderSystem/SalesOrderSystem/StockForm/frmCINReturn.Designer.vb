<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCINReturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCINReturn))
        Me.btnChangeCurrRow = New System.Windows.Forms.Button()
        Me.gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSelectedKgs = New System.Windows.Forms.TextBox()
        Me.txtSelectedYds = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSelectedRolls = New System.Windows.Forms.TextBox()
        Me.txtSelectedMts = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbomtlWarehouse = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbomtlLocations = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbomtlSubinventory = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnChangeSelectedRows = New System.Windows.Forms.Button()
        Me.btnChangeAllRows = New System.Windows.Forms.Button()
        Me.btnCopyRoll = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtCinno = New System.Windows.Forms.TextBox()
        Me.dtpCINDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboCinNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsbDInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbDInTag = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsbMInDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnSearchOutNo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.grdStockD = New System.Windows.Forms.DataGridView()
        Me.selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_locations_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.sono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdStockD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChangeCurrRow
        '
        Me.btnChangeCurrRow.Location = New System.Drawing.Point(11, 18)
        Me.btnChangeCurrRow.Name = "btnChangeCurrRow"
        Me.btnChangeCurrRow.Size = New System.Drawing.Size(77, 25)
        Me.btnChangeCurrRow.TabIndex = 359
        Me.btnChangeCurrRow.Text = "Current Row"
        Me.btnChangeCurrRow.UseVisualStyleBackColor = True
        '
        'gr
        '
        Me.gr.DataPropertyName = "gr"
        Me.gr.HeaderText = "Grade"
        Me.gr.Name = "gr"
        Me.gr.Width = 40
        '
        'batch
        '
        Me.batch.DataPropertyName = "batch"
        Me.batch.HeaderText = "Batch"
        Me.batch.Name = "batch"
        Me.batch.Visible = False
        Me.batch.Width = 80
        '
        'fwth
        '
        Me.fwth.DataPropertyName = "fwth"
        Me.fwth.HeaderText = "Fwth"
        Me.fwth.Name = "fwth"
        Me.fwth.Width = 40
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        Me.kg.HeaderText = "Kg."
        Me.kg.Name = "kg"
        Me.kg.Width = 50
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.Width = 50
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        Me.yds.HeaderText = "Yds."
        Me.yds.Name = "yds"
        Me.yds.Width = 50
        '
        'mtkg
        '
        Me.mtkg.DataPropertyName = "mtkg"
        Me.mtkg.HeaderText = "mtkg(For Cal)"
        Me.mtkg.Name = "mtkg"
        Me.mtkg.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtSelectedKgs)
        Me.GroupBox2.Controls.Add(Me.txtSelectedYds)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtSelectedRolls)
        Me.GroupBox2.Controls.Add(Me.txtSelectedMts)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(204, 489)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(778, 51)
        Me.GroupBox2.TabIndex = 366
        Me.GroupBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(358, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 13)
        Me.Label15.TabIndex = 296
        Me.Label15.Text = "Kgs."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 13)
        Me.Label18.TabIndex = 293
        Me.Label18.Text = "Total Selected"
        '
        'txtSelectedKgs
        '
        Me.txtSelectedKgs.Location = New System.Drawing.Point(254, 16)
        Me.txtSelectedKgs.Name = "txtSelectedKgs"
        Me.txtSelectedKgs.ReadOnly = True
        Me.txtSelectedKgs.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedKgs.TabIndex = 295
        Me.txtSelectedKgs.Tag = "0.00"
        Me.txtSelectedKgs.Text = "0.00"
        Me.txtSelectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSelectedYds
        '
        Me.txtSelectedYds.Location = New System.Drawing.Point(404, 16)
        Me.txtSelectedYds.Name = "txtSelectedYds"
        Me.txtSelectedYds.ReadOnly = True
        Me.txtSelectedYds.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedYds.TabIndex = 297
        Me.txtSelectedYds.Tag = "0.00"
        Me.txtSelectedYds.Text = "0.00"
        Me.txtSelectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(206, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 294
        Me.Label17.Text = "Rolls"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(508, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 298
        Me.Label13.Text = "Yds."
        '
        'txtSelectedRolls
        '
        Me.txtSelectedRolls.Location = New System.Drawing.Point(102, 16)
        Me.txtSelectedRolls.Name = "txtSelectedRolls"
        Me.txtSelectedRolls.ReadOnly = True
        Me.txtSelectedRolls.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedRolls.TabIndex = 292
        Me.txtSelectedRolls.Tag = "0.00"
        Me.txtSelectedRolls.Text = "0.00"
        Me.txtSelectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSelectedMts
        '
        Me.txtSelectedMts.Location = New System.Drawing.Point(554, 16)
        Me.txtSelectedMts.Name = "txtSelectedMts"
        Me.txtSelectedMts.ReadOnly = True
        Me.txtSelectedMts.Size = New System.Drawing.Size(96, 20)
        Me.txtSelectedMts.TabIndex = 299
        Me.txtSelectedMts.Tag = "0.00"
        Me.txtSelectedMts.Text = "0.00"
        Me.txtSelectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(658, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 300
        Me.Label12.Text = "Mts."
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Cust. Color"
        Me.custcolor.Name = "custcolor"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.cbomtlWarehouse)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbomtlLocations)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cbomtlSubinventory)
        Me.GroupBox3.Location = New System.Drawing.Point(538, 34)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 105)
        Me.GroupBox3.TabIndex = 369
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock Locations"
        '
        'cbomtlWarehouse
        '
        Me.cbomtlWarehouse.FormattingEnabled = True
        Me.cbomtlWarehouse.Location = New System.Drawing.Point(82, 19)
        Me.cbomtlWarehouse.Name = "cbomtlWarehouse"
        Me.cbomtlWarehouse.Size = New System.Drawing.Size(134, 21)
        Me.cbomtlWarehouse.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 294
        Me.Label5.Text = "Location"
        '
        'cbomtlLocations
        '
        Me.cbomtlLocations.FormattingEnabled = True
        Me.cbomtlLocations.Location = New System.Drawing.Point(82, 73)
        Me.cbomtlLocations.Name = "cbomtlLocations"
        Me.cbomtlLocations.Size = New System.Drawing.Size(134, 21)
        Me.cbomtlLocations.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 295
        Me.Label6.Text = "Sub Inven"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 298
        Me.Label7.Text = "W/H"
        '
        'cbomtlSubinventory
        '
        Me.cbomtlSubinventory.FormattingEnabled = True
        Me.cbomtlSubinventory.Location = New System.Drawing.Point(82, 46)
        Me.cbomtlSubinventory.Name = "cbomtlSubinventory"
        Me.cbomtlSubinventory.Size = New System.Drawing.Size(134, 21)
        Me.cbomtlSubinventory.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(562, 548)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(414, 13)
        Me.Label4.TabIndex = 368
        Me.Label4.Text = "*** ถ้า S/O เป็นของ Wacoal Dominiican จะรันหมายเลข Roll No ของ Wacoal Dominican"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.btnChangeSelectedRows)
        Me.GroupBox5.Controls.Add(Me.btnChangeCurrRow)
        Me.GroupBox5.Controls.Add(Me.btnChangeAllRows)
        Me.GroupBox5.Location = New System.Drawing.Point(251, 89)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(281, 50)
        Me.GroupBox5.TabIndex = 373
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Change Sub Inven / Location"
        '
        'btnChangeSelectedRows
        '
        Me.btnChangeSelectedRows.Location = New System.Drawing.Point(177, 18)
        Me.btnChangeSelectedRows.Name = "btnChangeSelectedRows"
        Me.btnChangeSelectedRows.Size = New System.Drawing.Size(96, 25)
        Me.btnChangeSelectedRows.TabIndex = 361
        Me.btnChangeSelectedRows.Text = "Selected Rows"
        Me.btnChangeSelectedRows.UseVisualStyleBackColor = True
        '
        'btnChangeAllRows
        '
        Me.btnChangeAllRows.Location = New System.Drawing.Point(94, 18)
        Me.btnChangeAllRows.Name = "btnChangeAllRows"
        Me.btnChangeAllRows.Size = New System.Drawing.Size(77, 25)
        Me.btnChangeAllRows.TabIndex = 360
        Me.btnChangeAllRows.Text = "All Rows"
        Me.btnChangeAllRows.UseVisualStyleBackColor = True
        '
        'btnCopyRoll
        '
        Me.btnCopyRoll.Location = New System.Drawing.Point(105, 111)
        Me.btnCopyRoll.Name = "btnCopyRoll"
        Me.btnCopyRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnCopyRoll.TabIndex = 372
        Me.btnCopyRoll.Text = "Copy Roll"
        Me.btnCopyRoll.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(24, 111)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectAll.TabIndex = 371
        Me.btnSelectAll.Text = "Selected All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtCinno)
        Me.GroupBox4.Controls.Add(Me.dtpCINDate)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(773, 34)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(209, 76)
        Me.GroupBox4.TabIndex = 370
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Docment Info"
        '
        'txtCinno
        '
        Me.txtCinno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCinno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCinno.Location = New System.Drawing.Point(100, 19)
        Me.txtCinno.Name = "txtCinno"
        Me.txtCinno.ReadOnly = True
        Me.txtCinno.Size = New System.Drawing.Size(103, 20)
        Me.txtCinno.TabIndex = 300
        '
        'dtpCINDate
        '
        Me.dtpCINDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpCINDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCINDate.Location = New System.Drawing.Point(100, 45)
        Me.dtpCINDate.Name = "dtpCINDate"
        Me.dtpCINDate.Size = New System.Drawing.Size(103, 20)
        Me.dtpCINDate.TabIndex = 289
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 302
        Me.Label3.Text = "Doc Date"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 301
        Me.Label2.Text = "Doc No."
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color Code"
        Me.col.MaxInputLength = 10
        Me.col.Name = "col"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboCinNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.ToolStripDropDownButton1, Me.btnPrint, Me.btnCancel, Me.btnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(988, 25)
        Me.ToolStrip1.TabIndex = 363
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel1.Text = "Doc No."
        '
        'cboCinNo
        '
        Me.cboCinNo.Name = "cboCinNo"
        Me.cboCinNo.Size = New System.Drawing.Size(100, 25)
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
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbDInDocument, Me.tsbDInTag, Me.tsbMInDocument})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'tsbDInDocument
        '
        Me.tsbDInDocument.Name = "tsbDInDocument"
        Me.tsbDInDocument.Size = New System.Drawing.Size(161, 22)
        Me.tsbDInDocument.Text = "D-IN Document"
        '
        'tsbDInTag
        '
        Me.tsbDInTag.Name = "tsbDInTag"
        Me.tsbDInTag.Size = New System.Drawing.Size(161, 22)
        Me.tsbDInTag.Text = "D-IN Tag"
        '
        'tsbMInDocument
        '
        Me.tsbMInDocument.Name = "tsbMInDocument"
        Me.tsbMInDocument.Size = New System.Drawing.Size(161, 22)
        Me.tsbMInDocument.Text = "M-IN Document"
        Me.tsbMInDocument.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Visible = False
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(442, 22)
        Me.ToolStripLabel2.Text = "*** ถ้า S/O เป็นของ Wacoal Dominican จะรันหมายเลข Roll No ของ Wacoal Dominican"
        '
        'btnSearchOutNo
        '
        Me.btnSearchOutNo.Image = CType(resources.GetObject("btnSearchOutNo.Image"), System.Drawing.Image)
        Me.btnSearchOutNo.Location = New System.Drawing.Point(234, 34)
        Me.btnSearchOutNo.Name = "btnSearchOutNo"
        Me.btnSearchOutNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutNo.TabIndex = 299
        Me.btnSearchOutNo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CO No."
        '
        'txtOutNo
        '
        Me.txtOutNo.Location = New System.Drawing.Point(96, 34)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(132, 20)
        Me.txtOutNo.TabIndex = 0
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAutoCalculate.Location = New System.Drawing.Point(803, 107)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(173, 32)
        Me.chkAutoCalculate.TabIndex = 367
        Me.chkAutoCalculate.Text = "Auto Calculate Kgs. ,Yds. ,Mts."
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'grdStockD
        '
        Me.grdStockD.AllowUserToAddRows = False
        Me.grdStockD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdStockD.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdStockD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStockD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.selected, Me.mtl_warehouse_id, Me.mtl_subinventory_id, Me.mtl_locations_id, Me.sono, Me.lot, Me.Design_no, Me.roll_no_d, Me.roll_no_o, Me.col, Me.custcolor, Me.gr, Me.batch, Me.fwth, Me.kg, Me.mts, Me.yds, Me.mtkg})
        Me.grdStockD.Location = New System.Drawing.Point(31, 145)
        Me.grdStockD.Name = "grdStockD"
        Me.grdStockD.Size = New System.Drawing.Size(945, 338)
        Me.grdStockD.TabIndex = 365
        Me.grdStockD.TabStop = False
        '
        'selected
        '
        Me.selected.DataPropertyName = "selected"
        Me.selected.HeaderText = "Selected"
        Me.selected.Name = "selected"
        Me.selected.Width = 50
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.HeaderText = "W/H"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        Me.mtl_warehouse_id.ReadOnly = True
        Me.mtl_warehouse_id.Visible = False
        '
        'mtl_subinventory_id
        '
        Me.mtl_subinventory_id.DataPropertyName = "mtl_subinventory_id"
        Me.mtl_subinventory_id.HeaderText = "Sub"
        Me.mtl_subinventory_id.Name = "mtl_subinventory_id"
        Me.mtl_subinventory_id.Visible = False
        '
        'mtl_locations_id
        '
        Me.mtl_locations_id.DataPropertyName = "mtl_locations_id"
        Me.mtl_locations_id.HeaderText = "Loc"
        Me.mtl_locations_id.Name = "mtl_locations_id"
        Me.mtl_locations_id.Visible = False
        '
        'sono
        '
        Me.sono.DataPropertyName = "sono"
        Me.sono.HeaderText = "SO No."
        Me.sono.Name = "sono"
        '
        'lot
        '
        Me.lot.DataPropertyName = "lot"
        Me.lot.HeaderText = "Lot"
        Me.lot.Name = "lot"
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "Design_no"
        Me.Design_no.HeaderText = "Design No."
        Me.Design_no.Name = "Design_no"
        '
        'roll_no_d
        '
        Me.roll_no_d.DataPropertyName = "roll_no_d"
        Me.roll_no_d.HeaderText = "Roll No. Old"
        Me.roll_no_d.Name = "roll_no_d"
        '
        'frmCINReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 566)
        Me.Controls.Add(Me.btnSearchOutNo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtOutNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnCopyRoll)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.chkAutoCalculate)
        Me.Controls.Add(Me.grdStockD)
        Me.Name = "frmCINReturn"
        Me.Text = "CIN Return"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdStockD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChangeCurrRow As Button
    Friend WithEvents gr As DataGridViewTextBoxColumn
    Friend WithEvents batch As DataGridViewTextBoxColumn
    Friend WithEvents fwth As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents mts As DataGridViewTextBoxColumn
    Friend WithEvents yds As DataGridViewTextBoxColumn
    Friend WithEvents mtkg As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtSelectedKgs As TextBox
    Friend WithEvents txtSelectedYds As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtSelectedRolls As TextBox
    Friend WithEvents txtSelectedMts As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents custcolor As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbomtlWarehouse As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbomtlLocations As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbomtlSubinventory As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnChangeSelectedRows As Button
    Friend WithEvents btnChangeAllRows As Button
    Friend WithEvents btnCopyRoll As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtCinno As TextBox
    Friend WithEvents dtpCINDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cboCinNo As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents tsbDInDocument As ToolStripMenuItem
    Friend WithEvents tsbDInTag As ToolStripMenuItem
    Friend WithEvents tsbMInDocument As ToolStripMenuItem
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents btnSearchOutNo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOutNo As TextBox
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents chkAutoCalculate As CheckBox
    Friend WithEvents grdStockD As DataGridView
    Friend WithEvents selected As DataGridViewCheckBoxColumn
    Friend WithEvents mtl_warehouse_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_subinventory_id As DataGridViewComboBoxColumn
    Friend WithEvents mtl_locations_id As DataGridViewComboBoxColumn
    Friend WithEvents sono As DataGridViewTextBoxColumn
    Friend WithEvents lot As DataGridViewTextBoxColumn
    Friend WithEvents Design_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_d As DataGridViewTextBoxColumn
End Class
