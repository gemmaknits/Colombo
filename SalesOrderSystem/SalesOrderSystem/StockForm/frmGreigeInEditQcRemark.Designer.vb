<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGreigeInEditQcRemark
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreigeInEditQcRemark))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTranType = New System.Windows.Forms.TextBox()
        Me.txtGINNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKoNo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGetGinNo = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.roll_no_o = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rem_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_greige = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1191, 25)
        Me.ToolStrip1.TabIndex = 286
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtKoNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDesignNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTranType)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 48)
        Me.GroupBox1.TabIndex = 287
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 308
        Me.Label4.Text = "Tran Type"
        '
        'txtTranType
        '
        Me.txtTranType.Location = New System.Drawing.Point(117, 19)
        Me.txtTranType.Name = "txtTranType"
        Me.txtTranType.ReadOnly = True
        Me.txtTranType.Size = New System.Drawing.Size(106, 20)
        Me.txtTranType.TabIndex = 307
        Me.txtTranType.TabStop = False
        Me.txtTranType.Tag = ""
        '
        'txtGINNo
        '
        Me.txtGINNo.Location = New System.Drawing.Point(117, 16)
        Me.txtGINNo.Name = "txtGINNo"
        Me.txtGINNo.ReadOnly = True
        Me.txtGINNo.Size = New System.Drawing.Size(106, 20)
        Me.txtGINNo.TabIndex = 306
        Me.txtGINNo.TabStop = False
        Me.txtGINNo.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 305
        Me.Label3.Text = "GIN No."
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgvData)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1167, 338)
        Me.GroupBox2.TabIndex = 288
        Me.GroupBox2.TabStop = False
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.design_no, Me.kono, Me.roll_no, Me.roll_no_o, Me.lot, Me.col, Me.kg_qc, Me.mts_qc, Me.yds_qc, Me.rem_qc, Me.id_greige})
        Me.dgvData.Location = New System.Drawing.Point(8, 17)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(1151, 313)
        Me.dgvData.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 310
        Me.Label1.Text = "Design No"
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(409, 19)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.ReadOnly = True
        Me.txtDesignNo.Size = New System.Drawing.Size(106, 20)
        Me.txtDesignNo.TabIndex = 309
        Me.txtDesignNo.TabStop = False
        Me.txtDesignNo.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(588, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 312
        Me.Label2.Text = "KO No"
        '
        'txtKoNo
        '
        Me.txtKoNo.Location = New System.Drawing.Point(667, 19)
        Me.txtKoNo.Name = "txtKoNo"
        Me.txtKoNo.ReadOnly = True
        Me.txtKoNo.Size = New System.Drawing.Size(106, 20)
        Me.txtKoNo.TabIndex = 311
        Me.txtKoNo.TabStop = False
        Me.txtKoNo.Tag = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtGINNo)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnGetGinNo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(277, 43)
        Me.GroupBox3.TabIndex = 307
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Greige In"
        '
        'btnGetGinNo
        '
        Me.btnGetGinNo.BackgroundImage = Global.SalesOrderSystem.My.Resources.Resources.Search_16x
        Me.btnGetGinNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGetGinNo.Location = New System.Drawing.Point(229, 15)
        Me.btnGetGinNo.Name = "btnGetGinNo"
        Me.btnGetGinNo.Size = New System.Drawing.Size(20, 22)
        Me.btnGetGinNo.TabIndex = 288
        Me.btnGetGinNo.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No"
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        Me.design_no.Width = 80
        '
        'kono
        '
        Me.kono.DataPropertyName = "kono"
        Me.kono.HeaderText = "Ko No"
        Me.kono.Name = "kono"
        Me.kono.ReadOnly = True
        Me.kono.Width = 80
        '
        'roll_no
        '
        Me.roll_no.DataPropertyName = "roll_no"
        Me.roll_no.HeaderText = "Roll No"
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
        Me.roll_no_o.Width = 125
        '
        'lot
        '
        Me.lot.DataPropertyName = "lot"
        Me.lot.HeaderText = "Lot"
        Me.lot.Name = "lot"
        Me.lot.ReadOnly = True
        Me.lot.Width = 80
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        Me.col.Width = 60
        '
        'kg_qc
        '
        Me.kg_qc.DataPropertyName = "kg_qc"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.kg_qc.DefaultCellStyle = DataGridViewCellStyle1
        Me.kg_qc.HeaderText = "Kg (QC)"
        Me.kg_qc.Name = "kg_qc"
        Me.kg_qc.ReadOnly = True
        Me.kg_qc.Width = 60
        '
        'mts_qc
        '
        Me.mts_qc.DataPropertyName = "mts_qc"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.mts_qc.DefaultCellStyle = DataGridViewCellStyle2
        Me.mts_qc.HeaderText = "Mts (QC)"
        Me.mts_qc.Name = "mts_qc"
        Me.mts_qc.ReadOnly = True
        Me.mts_qc.Width = 60
        '
        'yds_qc
        '
        Me.yds_qc.DataPropertyName = "yds_qc"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N4"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.yds_qc.DefaultCellStyle = DataGridViewCellStyle3
        Me.yds_qc.HeaderText = "Yds (QC)"
        Me.yds_qc.Name = "yds_qc"
        Me.yds_qc.ReadOnly = True
        Me.yds_qc.Width = 60
        '
        'rem_qc
        '
        Me.rem_qc.DataPropertyName = "rem_qc"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rem_qc.DefaultCellStyle = DataGridViewCellStyle4
        Me.rem_qc.HeaderText = "Remark (QC)"
        Me.rem_qc.Name = "rem_qc"
        Me.rem_qc.Width = 500
        '
        'id_greige
        '
        Me.id_greige.DataPropertyName = "id_greige"
        Me.id_greige.HeaderText = "id_greige"
        Me.id_greige.Name = "id_greige"
        Me.id_greige.Visible = False
        '
        'frmGreigeInEditQcRemark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 465)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmGreigeInEditQcRemark"
        Me.Text = "Greige In (Edit Qc Remark)"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGetGinNo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTranType As TextBox
    Friend WithEvents txtGINNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKoNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDesignNo As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents kono As DataGridViewTextBoxColumn
    Friend WithEvents roll_no As DataGridViewTextBoxColumn
    Friend WithEvents roll_no_o As DataGridViewTextBoxColumn
    Friend WithEvents lot As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents kg_qc As DataGridViewTextBoxColumn
    Friend WithEvents mts_qc As DataGridViewTextBoxColumn
    Friend WithEvents yds_qc As DataGridViewTextBoxColumn
    Friend WithEvents rem_qc As DataGridViewTextBoxColumn
    Friend WithEvents id_greige As DataGridViewTextBoxColumn
End Class
