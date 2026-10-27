<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDyedOutFromRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDyedOutFromRequest))
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.CboDoc_type = New System.Windows.Forms.ComboBox()
        Me.btnSearchREQD = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnSearchOutno = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReqNo = New System.Windows.Forms.TextBox()
        Me.txtcustomer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        Me.txtTotalKgs = New System.Windows.Forms.TextBox()
        Me.BtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblOutdt = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DtpOutdt = New System.Windows.Forms.DateTimePicker()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.grdDataPackingList_cartno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outkg_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outmt_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_outyd_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataPackingList_fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbDoctype
        '
        Me.LbDoctype.AutoSize = True
        Me.LbDoctype.Location = New System.Drawing.Point(299, 26)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(96, 13)
        Me.LbDoctype.TabIndex = 70
        Me.LbDoctype.Text = "Fabric delivery for :"
        '
        'CboDoc_type
        '
        Me.CboDoc_type.FormattingEnabled = True
        Me.CboDoc_type.Location = New System.Drawing.Point(401, 22)
        Me.CboDoc_type.Name = "CboDoc_type"
        Me.CboDoc_type.Size = New System.Drawing.Size(121, 21)
        Me.CboDoc_type.TabIndex = 69
        '
        'btnSearchREQD
        '
        Me.btnSearchREQD.Image = CType(resources.GetObject("btnSearchREQD.Image"), System.Drawing.Image)
        Me.btnSearchREQD.Location = New System.Drawing.Point(206, 21)
        Me.btnSearchREQD.Name = "btnSearchREQD"
        Me.btnSearchREQD.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchREQD.TabIndex = 64
        Me.btnSearchREQD.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(45, 22)
        Me.BtnExit.Text = "Exit"
        '
        'btnSearchOutno
        '
        Me.btnSearchOutno.Image = CType(resources.GetObject("btnSearchOutno.Image"), System.Drawing.Image)
        Me.btnSearchOutno.Location = New System.Drawing.Point(213, 21)
        Me.btnSearchOutno.Name = "btnSearchOutno"
        Me.btnSearchOutno.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutno.TabIndex = 112
        Me.btnSearchOutno.Text = "PackingList Dyes & Out"
        Me.btnSearchOutno.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.LbDoctype)
        Me.GroupBox2.Controls.Add(Me.txtReqNo)
        Me.GroupBox2.Controls.Add(Me.CboDoc_type)
        Me.GroupBox2.Controls.Add(Me.btnSearchREQD)
        Me.GroupBox2.Controls.Add(Me.txtcustomer)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 85)
        Me.GroupBox2.TabIndex = 115
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Source Detail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Request No."
        '
        'txtReqNo
        '
        Me.txtReqNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtReqNo.Location = New System.Drawing.Point(81, 23)
        Me.txtReqNo.Name = "txtReqNo"
        Me.txtReqNo.Size = New System.Drawing.Size(119, 20)
        Me.txtReqNo.TabIndex = 44
        '
        'txtcustomer
        '
        Me.txtcustomer.Location = New System.Drawing.Point(81, 55)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.ReadOnly = True
        Me.txtcustomer.Size = New System.Drawing.Size(269, 20)
        Me.txtcustomer.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Customer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(936, 596)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Yds"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(662, 595)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Kgs"
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Location = New System.Drawing.Point(830, 592)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalYds.TabIndex = 103
        '
        'txtTotalKgs
        '
        Me.txtTotalKgs.Location = New System.Drawing.Point(556, 593)
        Me.txtTotalKgs.Name = "txtTotalKgs"
        Me.txtTotalKgs.ReadOnly = True
        Me.txtTotalKgs.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalKgs.TabIndex = 101
        '
        'BtnPrint
        '
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(52, 22)
        Me.BtnPrint.Text = "Print"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblOutdt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnSearchOutno)
        Me.GroupBox1.Controls.Add(Me.DtpOutdt)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Controls.Add(Me.lblCancelled)
        Me.GroupBox1.Location = New System.Drawing.Point(707, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 102)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DO Detail"
        '
        'lblOutdt
        '
        Me.lblOutdt.AutoSize = True
        Me.lblOutdt.Location = New System.Drawing.Point(16, 56)
        Me.lblOutdt.Name = "lblOutdt"
        Me.lblOutdt.Size = New System.Drawing.Size(49, 13)
        Me.lblOutdt.TabIndex = 39
        Me.lblOutdt.Text = "DO Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "DO No."
        '
        'DtpOutdt
        '
        Me.DtpOutdt.CustomFormat = "dd/MM/yyyy"
        Me.DtpOutdt.Enabled = False
        Me.DtpOutdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpOutdt.Location = New System.Drawing.Point(90, 53)
        Me.DtpOutdt.Name = "DtpOutdt"
        Me.DtpOutdt.Size = New System.Drawing.Size(117, 20)
        Me.DtpOutdt.TabIndex = 38
        '
        'txtOutNo
        '
        Me.txtOutNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtOutNo.Location = New System.Drawing.Point(90, 23)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(117, 20)
        Me.txtOutNo.TabIndex = 36
        '
        'lblCancelled
        '
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(51, 72)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(192, 24)
        Me.lblCancelled.TabIndex = 114
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.Visible = False
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Location = New System.Drawing.Point(693, 593)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMts.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(376, 596)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Total"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataPackingList_cartno, Me.grdDataPackingList_lot, Me.grdDataPackingList_custcolor, Me.grdDataPackingList_roll_no_g, Me.grdDataPackingList_roll_no_o, Me.grdDataPackingList_grade, Me.grdDataPackingList_design_no, Me.grdDataPackingList_col, Me.grdDataPackingList_outkg_g, Me.grdDataPackingList_outmt_g, Me.grdDataPackingList_outyd_g, Me.grdDataPackingList_fwth})
        Me.grdData.Location = New System.Drawing.Point(12, 136)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(953, 443)
        Me.grdData.TabIndex = 98
        '
        'grdDataPackingList_cartno
        '
        Me.grdDataPackingList_cartno.DataPropertyName = "cartno"
        Me.grdDataPackingList_cartno.HeaderText = "Carton No."
        Me.grdDataPackingList_cartno.Name = "grdDataPackingList_cartno"
        Me.grdDataPackingList_cartno.Width = 40
        '
        'grdDataPackingList_lot
        '
        Me.grdDataPackingList_lot.DataPropertyName = "lot"
        Me.grdDataPackingList_lot.HeaderText = "Lot"
        Me.grdDataPackingList_lot.Name = "grdDataPackingList_lot"
        '
        'grdDataPackingList_custcolor
        '
        Me.grdDataPackingList_custcolor.DataPropertyName = "custcolor"
        Me.grdDataPackingList_custcolor.HeaderText = "Custcolor"
        Me.grdDataPackingList_custcolor.Name = "grdDataPackingList_custcolor"
        '
        'grdDataPackingList_roll_no_g
        '
        Me.grdDataPackingList_roll_no_g.DataPropertyName = "roll_no_d"
        Me.grdDataPackingList_roll_no_g.HeaderText = "Roll No. (D)"
        Me.grdDataPackingList_roll_no_g.Name = "grdDataPackingList_roll_no_g"
        Me.grdDataPackingList_roll_no_g.ReadOnly = True
        Me.grdDataPackingList_roll_no_g.Width = 110
        '
        'grdDataPackingList_roll_no_o
        '
        Me.grdDataPackingList_roll_no_o.DataPropertyName = "roll_no_o"
        Me.grdDataPackingList_roll_no_o.HeaderText = "Roll No. (Factory)"
        Me.grdDataPackingList_roll_no_o.Name = "grdDataPackingList_roll_no_o"
        Me.grdDataPackingList_roll_no_o.ReadOnly = True
        Me.grdDataPackingList_roll_no_o.Width = 120
        '
        'grdDataPackingList_grade
        '
        Me.grdDataPackingList_grade.DataPropertyName = "grade"
        Me.grdDataPackingList_grade.HeaderText = "Grade"
        Me.grdDataPackingList_grade.Name = "grdDataPackingList_grade"
        Me.grdDataPackingList_grade.Width = 40
        '
        'grdDataPackingList_design_no
        '
        Me.grdDataPackingList_design_no.DataPropertyName = "design_no"
        Me.grdDataPackingList_design_no.HeaderText = "design_no"
        Me.grdDataPackingList_design_no.Name = "grdDataPackingList_design_no"
        Me.grdDataPackingList_design_no.Width = 90
        '
        'grdDataPackingList_col
        '
        Me.grdDataPackingList_col.DataPropertyName = "col"
        Me.grdDataPackingList_col.HeaderText = "Col"
        Me.grdDataPackingList_col.Name = "grdDataPackingList_col"
        Me.grdDataPackingList_col.Width = 80
        '
        'grdDataPackingList_outkg_g
        '
        Me.grdDataPackingList_outkg_g.DataPropertyName = "outkg_g"
        Me.grdDataPackingList_outkg_g.HeaderText = "Kgs"
        Me.grdDataPackingList_outkg_g.Name = "grdDataPackingList_outkg_g"
        Me.grdDataPackingList_outkg_g.Width = 60
        '
        'grdDataPackingList_outmt_g
        '
        Me.grdDataPackingList_outmt_g.DataPropertyName = "outmt_g"
        Me.grdDataPackingList_outmt_g.HeaderText = "Mts"
        Me.grdDataPackingList_outmt_g.Name = "grdDataPackingList_outmt_g"
        Me.grdDataPackingList_outmt_g.Width = 60
        '
        'grdDataPackingList_outyd_g
        '
        Me.grdDataPackingList_outyd_g.DataPropertyName = "outyd_g"
        Me.grdDataPackingList_outyd_g.HeaderText = "Yds"
        Me.grdDataPackingList_outyd_g.Name = "grdDataPackingList_outyd_g"
        Me.grdDataPackingList_outyd_g.Width = 60
        '
        'grdDataPackingList_fwth
        '
        Me.grdDataPackingList_fwth.DataPropertyName = "Fwth"
        Me.grdDataPackingList_fwth.HeaderText = "Fwth"
        Me.grdDataPackingList_fwth.Name = "grdDataPackingList_fwth"
        Me.grdDataPackingList_fwth.Width = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(800, 594)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Mts"
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(63, 22)
        Me.BtnCancel.Text = "Cancel"
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(51, 22)
        Me.BtnSave.Text = "Save"
        '
        'txtTotalRolls
        '
        Me.txtTotalRolls.Location = New System.Drawing.Point(413, 593)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalRolls.TabIndex = 99
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(520, 595)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Rolls"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.btnNew, Me.BtnSave, Me.BtnPrint, Me.BtnCancel, Me.BtnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(984, 25)
        Me.ToolStrip1.TabIndex = 97
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.LinkColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(135, 22)
        Me.ToolStripLabel2.Text = "Don't Show S/O Closed"
        '
        'frmDyedOutFromRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 637)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalYds)
        Me.Controls.Add(Me.txtTotalKgs)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTotalMts)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalRolls)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmDyedOutFromRequest"
        Me.Text = "Dyed Out From Request"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbDoctype As System.Windows.Forms.Label
    Friend WithEvents CboDoc_type As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearchREQD As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearchOutno As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReqNo As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotalYds As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKgs As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblOutdt As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DtpOutdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalMts As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents grdDataPackingList_cartno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_lot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_custcolor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_roll_no_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outkg_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outmt_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_outyd_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdDataPackingList_fwth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCancelled As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTotalRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
