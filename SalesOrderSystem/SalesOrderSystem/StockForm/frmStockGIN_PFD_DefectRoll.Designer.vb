<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGIN_PFD_DefectRoll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGIN_PFD_DefectRoll))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGInDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGINNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsbtnNewLine = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnEditLine = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDeleteLine = New System.Windows.Forms.ToolStripButton()
        Me.grdDefectRollGInPFD = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdRollGInPFD = New System.Windows.Forms.DataGridView()
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.length_start = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.length_end = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.length_defect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.grdDefectRollGInPFD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdRollGInPFD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGInDate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtGINNo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 84)
        Me.GroupBox1.TabIndex = 285
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "G-IN Document"
        '
        'txtGInDate
        '
        Me.txtGInDate.Location = New System.Drawing.Point(84, 48)
        Me.txtGInDate.Name = "txtGInDate"
        Me.txtGInDate.ReadOnly = True
        Me.txtGInDate.Size = New System.Drawing.Size(96, 20)
        Me.txtGInDate.TabIndex = 271
        Me.txtGInDate.TabStop = False
        Me.txtGInDate.Tag = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 270
        Me.Label4.Text = "GIN Date"
        '
        'txtGINNo
        '
        Me.txtGINNo.Location = New System.Drawing.Point(84, 24)
        Me.txtGINNo.Name = "txtGINNo"
        Me.txtGINNo.ReadOnly = True
        Me.txtGINNo.Size = New System.Drawing.Size(96, 20)
        Me.txtGINNo.TabIndex = 268
        Me.txtGINNo.TabStop = False
        Me.txtGINNo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 267
        Me.Label3.Text = "GIN No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnPrint, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1095, 25)
        Me.ToolStrip1.TabIndex = 286
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
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1081, 396)
        Me.GroupBox2.TabIndex = 287
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.MenuStrip1)
        Me.GroupBox4.Controls.Add(Me.grdDefectRollGInPFD)
        Me.GroupBox4.Location = New System.Drawing.Point(365, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(707, 373)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Defect Roll"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNewLine, Me.tsbtnEditLine, Me.tsbtnDeleteLine})
        Me.MenuStrip1.Location = New System.Drawing.Point(3, 16)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(701, 27)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsbtnNewLine
        '
        Me.tsbtnNewLine.BackgroundImage = Global.SalesOrderSystem.My.Resources.Resources.AddQuery_16x
        Me.tsbtnNewLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbtnNewLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnNewLine.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNewLine.Name = "tsbtnNewLine"
        Me.tsbtnNewLine.Size = New System.Drawing.Size(23, 20)
        Me.tsbtnNewLine.Text = "New Line"
        Me.tsbtnNewLine.ToolTipText = "Add New Transaction Line"
        '
        'tsbtnEditLine
        '
        Me.tsbtnEditLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEditLine.Image = Global.SalesOrderSystem.My.Resources.Resources.EditQuery_16x
        Me.tsbtnEditLine.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditLine.Name = "tsbtnEditLine"
        Me.tsbtnEditLine.Size = New System.Drawing.Size(23, 20)
        Me.tsbtnEditLine.Text = "EditLine"
        Me.tsbtnEditLine.ToolTipText = "Edit Transaction Line"
        '
        'tsbtnDeleteLine
        '
        Me.tsbtnDeleteLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnDeleteLine.Image = Global.SalesOrderSystem.My.Resources.Resources.DeleteQuery_16x
        Me.tsbtnDeleteLine.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDeleteLine.Name = "tsbtnDeleteLine"
        Me.tsbtnDeleteLine.Size = New System.Drawing.Size(23, 20)
        Me.tsbtnDeleteLine.Text = "Delete Line"
        Me.tsbtnDeleteLine.ToolTipText = "Delete Transaction Line"
        '
        'grdDefectRollGInPFD
        '
        Me.grdDefectRollGInPFD.AllowUserToAddRows = False
        Me.grdDefectRollGInPFD.AllowUserToDeleteRows = False
        Me.grdDefectRollGInPFD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDefectRollGInPFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDefectRollGInPFD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.defect_roll_no, Me.defect_code, Me.defect_name, Me.defect_details, Me.length_start, Me.length_end, Me.length_defect, Me.uom_id, Me.uom_name, Me.defect_remark})
        Me.grdDefectRollGInPFD.Location = New System.Drawing.Point(6, 50)
        Me.grdDefectRollGInPFD.Name = "grdDefectRollGInPFD"
        Me.grdDefectRollGInPFD.ReadOnly = True
        Me.grdDefectRollGInPFD.Size = New System.Drawing.Size(693, 314)
        Me.grdDefectRollGInPFD.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grdRollGInPFD)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 373)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Roll No"
        '
        'grdRollGInPFD
        '
        Me.grdRollGInPFD.AllowUserToAddRows = False
        Me.grdRollGInPFD.AllowUserToDeleteRows = False
        Me.grdRollGInPFD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRollGInPFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRollGInPFD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.roll_no, Me.roll_no_o, Me.mts})
        Me.grdRollGInPFD.Location = New System.Drawing.Point(7, 19)
        Me.grdRollGInPFD.Name = "grdRollGInPFD"
        Me.grdRollGInPFD.ReadOnly = True
        Me.grdRollGInPFD.Size = New System.Drawing.Size(337, 345)
        Me.grdRollGInPFD.TabIndex = 0
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "System Roll No."
        Me.roll_no.Name = "roll_no"
        Me.roll_no.ReadOnly = True
        Me.roll_no.Width = 90
        '
        'roll_no_o
        '
        Me.roll_no_o.DataPropertyName = "roll_no_o"
        Me.roll_no_o.HeaderText = "Factory Roll No."
        Me.roll_no_o.Name = "roll_no_o"
        Me.roll_no_o.ReadOnly = True
        Me.roll_no_o.Width = 120
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.mts.DefaultCellStyle = DataGridViewCellStyle1
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.ReadOnly = True
        Me.mts.Width = 80
        '
        'defect_roll_no
        '
        Me.defect_roll_no.DataPropertyName = "roll_no"
        Me.defect_roll_no.HeaderText = "Roll No."
        Me.defect_roll_no.Name = "defect_roll_no"
        Me.defect_roll_no.ReadOnly = True
        Me.defect_roll_no.Width = 60
        '
        'defect_code
        '
        Me.defect_code.DataPropertyName = "defect_code"
        Me.defect_code.HeaderText = "Defect Code"
        Me.defect_code.Name = "defect_code"
        Me.defect_code.ReadOnly = True
        Me.defect_code.Width = 50
        '
        'defect_name
        '
        Me.defect_name.DataPropertyName = "defect_name"
        Me.defect_name.HeaderText = "Defect Name"
        Me.defect_name.Name = "defect_name"
        Me.defect_name.ReadOnly = True
        Me.defect_name.Width = 120
        '
        'defect_details
        '
        Me.defect_details.DataPropertyName = "defect_details"
        Me.defect_details.HeaderText = "Defect Details"
        Me.defect_details.Name = "defect_details"
        Me.defect_details.ReadOnly = True
        Me.defect_details.Width = 80
        '
        'length_start
        '
        Me.length_start.DataPropertyName = "length_start"
        Me.length_start.HeaderText = "Position (Mts)"
        Me.length_start.Name = "length_start"
        Me.length_start.ReadOnly = True
        Me.length_start.Width = 60
        '
        'length_end
        '
        Me.length_end.DataPropertyName = "length_end"
        Me.length_end.HeaderText = "เมตรที่"
        Me.length_end.Name = "length_end"
        Me.length_end.ReadOnly = True
        Me.length_end.Visible = False
        Me.length_end.Width = 60
        '
        'length_defect
        '
        Me.length_defect.DataPropertyName = "length_defect"
        Me.length_defect.HeaderText = "Length (Cm.)"
        Me.length_defect.Name = "length_defect"
        Me.length_defect.ReadOnly = True
        Me.length_defect.Width = 60
        '
        'uom_id
        '
        Me.uom_id.DataPropertyName = "uom_id"
        Me.uom_id.HeaderText = "uom_id"
        Me.uom_id.Name = "uom_id"
        Me.uom_id.ReadOnly = True
        Me.uom_id.Visible = False
        Me.uom_id.Width = 10
        '
        'uom_name
        '
        Me.uom_name.DataPropertyName = "uom_name"
        Me.uom_name.HeaderText = "UOM"
        Me.uom_name.Name = "uom_name"
        Me.uom_name.ReadOnly = True
        Me.uom_name.Width = 70
        '
        'defect_remark
        '
        Me.defect_remark.DataPropertyName = "defect_remark"
        Me.defect_remark.HeaderText = "Defect  Rmark"
        Me.defect_remark.Name = "defect_remark"
        Me.defect_remark.ReadOnly = True
        Me.defect_remark.Width = 250
        '
        'frmStockGIN_PFD_DefectRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 519)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStockGIN_PFD_DefectRoll"
        Me.Text = "GIN Defect Roll"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.grdDefectRollGInPFD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdRollGInPFD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtGINNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGInDate As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents grdDefectRollGInPFD As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grdRollGInPFD As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsbtnNewLine As ToolStripButton
    Friend WithEvents tsbtnEditLine As ToolStripButton
    Friend WithEvents tsbtnDeleteLine As ToolStripButton
    Friend WithEvents roll_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents mts As DataGridViewTextBoxColumn
    Friend WithEvents defect_roll_no As DataGridViewTextBoxColumn
    Friend WithEvents defect_code As DataGridViewTextBoxColumn
    Friend WithEvents defect_name As DataGridViewTextBoxColumn
    Friend WithEvents defect_details As DataGridViewTextBoxColumn
    Friend WithEvents length_start As DataGridViewTextBoxColumn
    Friend WithEvents length_end As DataGridViewTextBoxColumn
    Friend WithEvents length_defect As DataGridViewTextBoxColumn
    Friend WithEvents uom_id As DataGridViewTextBoxColumn
    Friend WithEvents uom_name As DataGridViewTextBoxColumn
    Friend WithEvents defect_remark As DataGridViewTextBoxColumn
End Class
