<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockDIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockDIN))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dtpDINDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDINNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDFNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLotNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.sonoid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalRolls = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTotalYds = New System.Windows.Forms.TextBox()
        Me.txtTotalMts = New System.Windows.Forms.TextBox()
        Me.txtTotalKgs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(890, 25)
        Me.ToolStrip1.TabIndex = 140
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "DIN No."
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
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Save"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
        '
        'btnCancel
        '
        Me.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(23, 22)
        Me.btnCancel.Text = "Cancel Document"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "Exit"
        '
        'dtpDINDate
        '
        Me.dtpDINDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDINDate.Enabled = False
        Me.dtpDINDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDINDate.Location = New System.Drawing.Point(176, 40)
        Me.dtpDINDate.Name = "dtpDINDate"
        Me.dtpDINDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpDINDate.TabIndex = 269
        Me.dtpDINDate.TabStop = False
        '
        'txtDINNo
        '
        Me.txtDINNo.Location = New System.Drawing.Point(64, 40)
        Me.txtDINNo.Name = "txtDINNo"
        Me.txtDINNo.ReadOnly = True
        Me.txtDINNo.Size = New System.Drawing.Size(96, 20)
        Me.txtDINNo.TabIndex = 268
        Me.txtDINNo.TabStop = False
        Me.txtDINNo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 267
        Me.Label3.Text = "DIN No."
        '
        'txtDFNo
        '
        Me.txtDFNo.Location = New System.Drawing.Point(344, 40)
        Me.txtDFNo.Name = "txtDFNo"
        Me.txtDFNo.ReadOnly = True
        Me.txtDFNo.Size = New System.Drawing.Size(96, 20)
        Me.txtDFNo.TabIndex = 272
        Me.txtDFNo.TabStop = False
        Me.txtDFNo.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 271
        Me.Label1.Text = "DF No."
        '
        'txtLotNo
        '
        Me.txtLotNo.Location = New System.Drawing.Point(504, 40)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.ReadOnly = True
        Me.txtLotNo.Size = New System.Drawing.Size(96, 20)
        Me.txtLotNo.TabIndex = 278
        Me.txtLotNo.TabStop = False
        Me.txtLotNo.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(456, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 277
        Me.Label5.Text = "Lot No."
        '
        'txtBillNo
        '
        Me.txtBillNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBillNo.Location = New System.Drawing.Point(664, 40)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(104, 22)
        Me.txtBillNo.TabIndex = 0
        Me.txtBillNo.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(616, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Bill No."
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sonoid, Me.design_no, Me.fwth, Me.col, Me.custcolor, Me.gr, Me.roll_no_g, Me.roll_no_d, Me.roll_no_o, Me.kg, Me.mts, Me.yds})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.Location = New System.Drawing.Point(8, 68)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(870, 371)
        Me.grdData.TabIndex = 281
        Me.grdData.TabStop = False
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O No. ID"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.ReadOnly = True
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        '
        'fwth
        '
        Me.fwth.DataPropertyName = "fwth"
        Me.fwth.HeaderText = "Fwth"
        Me.fwth.Name = "fwth"
        Me.fwth.ReadOnly = True
        Me.fwth.Width = 50
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        Me.col.Width = 75
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Customer Color"
        Me.custcolor.Name = "custcolor"
        Me.custcolor.ReadOnly = True
        '
        'gr
        '
        Me.gr.DataPropertyName = "gr"
        Me.gr.HeaderText = "Gr"
        Me.gr.Name = "gr"
        Me.gr.ReadOnly = True
        Me.gr.Width = 25
        '
        'roll_no_g
        '
        Me.roll_no_g.DataPropertyName = "roll_no_g"
        Me.roll_no_g.HeaderText = "Roll (Greige)"
        Me.roll_no_g.Name = "roll_no_g"
        Me.roll_no_g.ReadOnly = True
        Me.roll_no_g.Width = 50
        '
        'roll_no_d
        '
        Me.roll_no_d.DataPropertyName = "roll_no_d"
        Me.roll_no_d.HeaderText = "Roll No. (Dyed)"
        Me.roll_no_d.Name = "roll_no_d"
        Me.roll_no_d.ReadOnly = True
        Me.roll_no_d.Width = 75
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        Me.roll_no_o.ReadOnly = True
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        Me.kg.HeaderText = "Kgs."
        Me.kg.Name = "kg"
        Me.kg.ReadOnly = True
        Me.kg.Width = 50
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.ReadOnly = True
        Me.mts.Width = 50
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        Me.yds.HeaderText = "Yds."
        Me.yds.Name = "yds"
        Me.yds.ReadOnly = True
        Me.yds.Width = 50
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(64, 482)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.Size = New System.Drawing.Size(704, 20)
        Me.txtRemark.TabIndex = 283
        Me.txtRemark.TabStop = False
        Me.txtRemark.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 482)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 282
        Me.Label2.Text = "Remark"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(743, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 292
        Me.Label4.Text = "Yds"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(607, 447)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 291
        Me.Label7.Text = "Mts"
        '
        'txtTotalRolls
        '
        Me.txtTotalRolls.Location = New System.Drawing.Point(220, 446)
        Me.txtTotalRolls.Name = "txtTotalRolls"
        Me.txtTotalRolls.ReadOnly = True
        Me.txtTotalRolls.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalRolls.TabIndex = 284
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(469, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 290
        Me.Label8.Text = "Kgs"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(327, 448)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 289
        Me.Label9.Text = "Rolls"
        '
        'txtTotalYds
        '
        Me.txtTotalYds.Location = New System.Drawing.Point(637, 445)
        Me.txtTotalYds.Name = "txtTotalYds"
        Me.txtTotalYds.ReadOnly = True
        Me.txtTotalYds.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalYds.TabIndex = 288
        '
        'txtTotalMts
        '
        Me.txtTotalMts.Location = New System.Drawing.Point(500, 446)
        Me.txtTotalMts.Name = "txtTotalMts"
        Me.txtTotalMts.ReadOnly = True
        Me.txtTotalMts.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalMts.TabIndex = 287
        '
        'txtTotalKgs
        '
        Me.txtTotalKgs.Location = New System.Drawing.Point(363, 446)
        Me.txtTotalKgs.Name = "txtTotalKgs"
        Me.txtTotalKgs.ReadOnly = True
        Me.txtTotalKgs.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalKgs.TabIndex = 286
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(183, 449)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 285
        Me.Label10.Text = "Total"
        '
        'frmStockDIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 514)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalRolls)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTotalYds)
        Me.Controls.Add(Me.txtTotalMts)
        Me.Controls.Add(Me.txtTotalKgs)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.txtBillNo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLotNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDFNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDINDate)
        Me.Controls.Add(Me.txtDINNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockDIN"
        Me.Text = "D-IN From Gamma"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dtpDINDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDINNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDFNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalYds As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalMts As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents sonoid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fwth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custcolor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yds As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
