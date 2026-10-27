<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGreigeOutFromRequest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreigeOutFromRequest))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSelectedRolls = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSelectedMts = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSelectedYds = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSelectedKgs = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
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
        Me.txtReqNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearchREQG = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(584, 416)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 13)
        Me.Label25.TabIndex = 327
        Me.Label25.Text = "Rolls"
        '
        'txtSelectedRolls
        '
        Me.txtSelectedRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedRolls.Location = New System.Drawing.Point(512, 416)
        Me.txtSelectedRolls.Name = "txtSelectedRolls"
        Me.txtSelectedRolls.ReadOnly = True
        Me.txtSelectedRolls.Size = New System.Drawing.Size(64, 20)
        Me.txtSelectedRolls.TabIndex = 326
        Me.txtSelectedRolls.Tag = "0"
        Me.txtSelectedRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(720, 440)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 13)
        Me.Label24.TabIndex = 325
        Me.Label24.Text = "Mts."
        '
        'txtSelectedMts
        '
        Me.txtSelectedMts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedMts.Location = New System.Drawing.Point(624, 440)
        Me.txtSelectedMts.Name = "txtSelectedMts"
        Me.txtSelectedMts.ReadOnly = True
        Me.txtSelectedMts.Size = New System.Drawing.Size(88, 20)
        Me.txtSelectedMts.TabIndex = 324
        Me.txtSelectedMts.Tag = "0.00"
        Me.txtSelectedMts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(720, 416)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(28, 13)
        Me.Label23.TabIndex = 323
        Me.Label23.Text = "Yds."
        '
        'txtSelectedYds
        '
        Me.txtSelectedYds.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedYds.Location = New System.Drawing.Point(624, 416)
        Me.txtSelectedYds.Name = "txtSelectedYds"
        Me.txtSelectedYds.ReadOnly = True
        Me.txtSelectedYds.Size = New System.Drawing.Size(88, 20)
        Me.txtSelectedYds.TabIndex = 322
        Me.txtSelectedYds.Tag = "0.00"
        Me.txtSelectedYds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(584, 440)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(28, 13)
        Me.Label22.TabIndex = 321
        Me.Label22.Text = "Kgs."
        '
        'txtSelectedKgs
        '
        Me.txtSelectedKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedKgs.Location = New System.Drawing.Point(512, 440)
        Me.txtSelectedKgs.Name = "txtSelectedKgs"
        Me.txtSelectedKgs.ReadOnly = True
        Me.txtSelectedKgs.Size = New System.Drawing.Size(64, 20)
        Me.txtSelectedKgs.TabIndex = 319
        Me.txtSelectedKgs.Tag = "0.00"
        Me.txtSelectedKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(464, 416)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 13)
        Me.Label21.TabIndex = 320
        Me.Label21.Text = "Total"
        '
        'txtOutNo
        '
        Me.txtOutNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutNo.Location = New System.Drawing.Point(648, 40)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(104, 20)
        Me.txtOutNo.TabIndex = 312
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(584, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 317
        Me.Label2.Text = "G-Out No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(762, 25)
        Me.ToolStrip1.TabIndex = 314
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
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col, Me.roll_no_g, Me.roll_no_o, Me.loc, Me.design_no, Me.gwth, Me.outkg_g, Me.outmt_g, Me.outyd_g})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.Location = New System.Drawing.Point(8, 72)
        Me.grdData.MultiSelect = False
        Me.grdData.Name = "grdData"
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(744, 336)
        Me.grdData.TabIndex = 313
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
        'txtReqNo
        '
        Me.txtReqNo.Location = New System.Drawing.Point(96, 40)
        Me.txtReqNo.Name = "txtReqNo"
        Me.txtReqNo.Size = New System.Drawing.Size(112, 20)
        Me.txtReqNo.TabIndex = 310
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 315
        Me.Label3.Text = "Request No."
        '
        'btnSearchREQG
        '
        Me.btnSearchREQG.Image = CType(resources.GetObject("btnSearchREQG.Image"), System.Drawing.Image)
        Me.btnSearchREQG.Location = New System.Drawing.Point(214, 38)
        Me.btnSearchREQG.Name = "btnSearchREQG"
        Me.btnSearchREQG.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchREQG.TabIndex = 328
        Me.btnSearchREQG.UseVisualStyleBackColor = True
        '
        'frmGreigeOutFromRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 473)
        Me.Controls.Add(Me.btnSearchREQG)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtSelectedRolls)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtSelectedMts)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtSelectedYds)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtSelectedKgs)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtOutNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.txtReqNo)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGreigeOutFromRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Greige Out From Request"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedMts As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedYds As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents txtReqNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gwth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents outkg_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents outmt_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents outyd_g As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearchREQG As System.Windows.Forms.Button
End Class
