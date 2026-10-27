<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGreigeOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreigeOut))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outkg_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outmt_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outyd_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtDFNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRollNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRackNo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(817, 25)
        Me.ToolStrip1.TabIndex = 4
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripLabel1.Text = "G-Out No."
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
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
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
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.LinkColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripLabel2.Text = "Don't Show S/O Closed"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col, Me.roll_no_g, Me.roll_no_o, Me.loc, Me.design_no, Me.gwth, Me.outkg_g, Me.outmt_g, Me.outyd_g, Me.selected})
        Me.grdData.Location = New System.Drawing.Point(8, 72)
        Me.grdData.MultiSelect = False
        Me.grdData.Name = "grdData"
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(800, 336)
        Me.grdData.TabIndex = 3
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_g"
        Me.roll_no_g.HeaderText = "Roll No."
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
        'gwth
        '
        Me.gwth.DataPropertyName = "gwth"
        Me.gwth.HeaderText = "Gwht"
        Me.gwth.Name = "gwth"
        Me.gwth.ReadOnly = True
        Me.gwth.Width = 50
        '
        'outkg_g
        '
        Me.outkg_g.DataPropertyName = "outkg_g"
        Me.outkg_g.HeaderText = "Kgs."
        Me.outkg_g.Name = "outkg_g"
        Me.outkg_g.ReadOnly = True
        Me.outkg_g.Width = 50
        '
        'outmt_g
        '
        Me.outmt_g.DataPropertyName = "outmt_g"
        Me.outmt_g.HeaderText = "Mts."
        Me.outmt_g.Name = "outmt_g"
        Me.outmt_g.ReadOnly = True
        Me.outmt_g.Width = 50
        '
        'outyd_g
        '
        Me.outyd_g.DataPropertyName = "outyd_g"
        Me.outyd_g.HeaderText = "Yds."
        Me.outyd_g.Name = "outyd_g"
        Me.outyd_g.ReadOnly = True
        Me.outyd_g.Width = 50
        '
        'selected
        '
        Me.selected.DataPropertyName = "selected"
        Me.selected.HeaderText = "Selected"
        Me.selected.Name = "selected"
        Me.selected.ReadOnly = True
        Me.selected.Width = 55
        '
        'txtDFNo
        '
        Me.txtDFNo.Location = New System.Drawing.Point(232, 40)
        Me.txtDFNo.Name = "txtDFNo"
        Me.txtDFNo.Size = New System.Drawing.Size(112, 22)
        Me.txtDFNo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 283
        Me.Label3.Text = "D/F No. Barcode"
        '
        'txtRollNo
        '
        Me.txtRollNo.Location = New System.Drawing.Point(464, 40)
        Me.txtRollNo.Name = "txtRollNo"
        Me.txtRollNo.Size = New System.Drawing.Size(168, 22)
        Me.txtRollNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(360, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 285
        Me.Label1.Text = "Roll No. Barcode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(640, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 287
        Me.Label2.Text = "G-Out No."
        '
        'txtOutNo
        '
        Me.txtOutNo.Location = New System.Drawing.Point(704, 40)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(104, 22)
        Me.txtOutNo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("IDAutomationHC39M", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(648, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 24)
        Me.Label4.TabIndex = 288
        Me.Label4.Text = "*NEW*"
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(312, 440)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(29, 13)
        Me.Label33.TabIndex = 307
        Me.Label33.Text = "Mts."
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(312, 416)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(27, 13)
        Me.Label34.TabIndex = 306
        Me.Label34.Text = "Yds."
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(176, 416)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(32, 13)
        Me.Label30.TabIndex = 305
        Me.Label30.Text = "Rolls"
        '
        'txtUnselectedRolls
        '
        Me.txtUnselectedRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedRolls.Location = New System.Drawing.Point(104, 416)
        Me.txtUnselectedRolls.Name = "txtUnselectedRolls"
        Me.txtUnselectedRolls.ReadOnly = True
        Me.txtUnselectedRolls.Size = New System.Drawing.Size(64, 22)
        Me.txtUnselectedRolls.TabIndex = 304
        Me.txtUnselectedRolls.Tag = "0"
        Me.txtUnselectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnselectedMts
        '
        Me.txtUnselectedMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedMts.Location = New System.Drawing.Point(216, 440)
        Me.txtUnselectedMts.Name = "txtUnselectedMts"
        Me.txtUnselectedMts.ReadOnly = True
        Me.txtUnselectedMts.Size = New System.Drawing.Size(88, 22)
        Me.txtUnselectedMts.TabIndex = 303
        Me.txtUnselectedMts.Tag = "0.00"
        Me.txtUnselectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnselectedYds
        '
        Me.txtUnselectedYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedYds.Location = New System.Drawing.Point(216, 416)
        Me.txtUnselectedYds.Name = "txtUnselectedYds"
        Me.txtUnselectedYds.ReadOnly = True
        Me.txtUnselectedYds.Size = New System.Drawing.Size(88, 22)
        Me.txtUnselectedYds.TabIndex = 302
        Me.txtUnselectedYds.Tag = "0.00"
        Me.txtUnselectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(176, 440)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(28, 13)
        Me.Label31.TabIndex = 301
        Me.Label31.Text = "Kgs."
        '
        'txtUnselectedKgs
        '
        Me.txtUnselectedKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedKgs.Location = New System.Drawing.Point(104, 440)
        Me.txtUnselectedKgs.Name = "txtUnselectedKgs"
        Me.txtUnselectedKgs.ReadOnly = True
        Me.txtUnselectedKgs.Size = New System.Drawing.Size(64, 22)
        Me.txtUnselectedKgs.TabIndex = 299
        Me.txtUnselectedKgs.Tag = "0.00"
        Me.txtUnselectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(8, 416)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(96, 13)
        Me.Label32.TabIndex = 300
        Me.Label32.Text = "Total Un-selected"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(640, 416)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 13)
        Me.Label25.TabIndex = 298
        Me.Label25.Text = "Rolls"
        '
        'txtSelectedRolls
        '
        Me.txtSelectedRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedRolls.Location = New System.Drawing.Point(568, 416)
        Me.txtSelectedRolls.Name = "txtSelectedRolls"
        Me.txtSelectedRolls.ReadOnly = True
        Me.txtSelectedRolls.Size = New System.Drawing.Size(64, 22)
        Me.txtSelectedRolls.TabIndex = 297
        Me.txtSelectedRolls.Tag = "0"
        Me.txtSelectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(776, 440)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(29, 13)
        Me.Label24.TabIndex = 296
        Me.Label24.Text = "Mts."
        '
        'txtSelectedMts
        '
        Me.txtSelectedMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedMts.Location = New System.Drawing.Point(680, 440)
        Me.txtSelectedMts.Name = "txtSelectedMts"
        Me.txtSelectedMts.ReadOnly = True
        Me.txtSelectedMts.Size = New System.Drawing.Size(88, 22)
        Me.txtSelectedMts.TabIndex = 295
        Me.txtSelectedMts.Tag = "0.00"
        Me.txtSelectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(776, 416)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(27, 13)
        Me.Label23.TabIndex = 294
        Me.Label23.Text = "Yds."
        '
        'txtSelectedYds
        '
        Me.txtSelectedYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedYds.Location = New System.Drawing.Point(680, 416)
        Me.txtSelectedYds.Name = "txtSelectedYds"
        Me.txtSelectedYds.ReadOnly = True
        Me.txtSelectedYds.Size = New System.Drawing.Size(88, 22)
        Me.txtSelectedYds.TabIndex = 293
        Me.txtSelectedYds.Tag = "0.00"
        Me.txtSelectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(640, 440)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 13)
        Me.Label22.TabIndex = 292
        Me.Label22.Text = "Kgs."
        '
        'txtSelectedKgs
        '
        Me.txtSelectedKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedKgs.Location = New System.Drawing.Point(568, 440)
        Me.txtSelectedKgs.Name = "txtSelectedKgs"
        Me.txtSelectedKgs.ReadOnly = True
        Me.txtSelectedKgs.Size = New System.Drawing.Size(64, 22)
        Me.txtSelectedKgs.TabIndex = 290
        Me.txtSelectedKgs.Tag = "0.00"
        Me.txtSelectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(488, 416)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 291
        Me.Label21.Text = "Total Selected"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 308
        Me.Label5.Text = "Rack No."
        '
        'txtRackNo
        '
        Me.txtRackNo.Location = New System.Drawing.Point(64, 40)
        Me.txtRackNo.Name = "txtRackNo"
        Me.txtRackNo.Size = New System.Drawing.Size(56, 22)
        Me.txtRackNo.TabIndex = 0
        '
        'frmGreigeOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 465)
        Me.Controls.Add(Me.txtRackNo)
        Me.Controls.Add(Me.Label5)
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
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOutNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRollNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDFNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGreigeOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Greige Out"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents txtDFNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRollNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gwth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents outkg_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents outmt_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents outyd_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selected As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRackNo As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
