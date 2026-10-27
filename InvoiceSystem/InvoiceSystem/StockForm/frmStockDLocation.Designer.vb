<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockDLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockDLocation))
        Me.txtSeach = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optDFNo = New System.Windows.Forms.RadioButton()
        Me.optCol = New System.Windows.Forms.RadioButton()
        Me.optLotNo = New System.Windows.Forms.RadioButton()
        Me.optDesignNo = New System.Windows.Forms.RadioButton()
        Me.grdStockD = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.dinno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dindt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Roll_No_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rem_qc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdStockD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSeach
        '
        Me.txtSeach.Location = New System.Drawing.Point(33, 58)
        Me.txtSeach.Name = "txtSeach"
        Me.txtSeach.Size = New System.Drawing.Size(215, 20)
        Me.txtSeach.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optDFNo)
        Me.GroupBox1.Controls.Add(Me.optCol)
        Me.GroupBox1.Controls.Add(Me.optLotNo)
        Me.GroupBox1.Controls.Add(Me.optDesignNo)
        Me.GroupBox1.Controls.Add(Me.txtSeach)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'optDFNo
        '
        Me.optDFNo.AutoSize = True
        Me.optDFNo.Location = New System.Drawing.Point(367, 18)
        Me.optDFNo.Name = "optDFNo"
        Me.optDFNo.Size = New System.Drawing.Size(64, 17)
        Me.optDFNo.TabIndex = 8
        Me.optDFNo.TabStop = True
        Me.optDFNo.Text = "D/F No."
        Me.optDFNo.UseVisualStyleBackColor = True
        '
        'optCol
        '
        Me.optCol.AutoSize = True
        Me.optCol.Location = New System.Drawing.Point(244, 18)
        Me.optCol.Name = "optCol"
        Me.optCol.Size = New System.Drawing.Size(83, 17)
        Me.optCol.TabIndex = 7
        Me.optCol.TabStop = True
        Me.optCol.Text = "Colour Code"
        Me.optCol.UseVisualStyleBackColor = True
        '
        'optLotNo
        '
        Me.optLotNo.AutoSize = True
        Me.optLotNo.Location = New System.Drawing.Point(141, 18)
        Me.optLotNo.Name = "optLotNo"
        Me.optLotNo.Size = New System.Drawing.Size(60, 17)
        Me.optLotNo.TabIndex = 6
        Me.optLotNo.Text = "Lot No."
        Me.optLotNo.UseVisualStyleBackColor = True
        '
        'optDesignNo
        '
        Me.optDesignNo.AutoSize = True
        Me.optDesignNo.Checked = True
        Me.optDesignNo.Location = New System.Drawing.Point(33, 18)
        Me.optDesignNo.Name = "optDesignNo"
        Me.optDesignNo.Size = New System.Drawing.Size(78, 17)
        Me.optDesignNo.TabIndex = 5
        Me.optDesignNo.TabStop = True
        Me.optDesignNo.Text = "Design No."
        Me.optDesignNo.UseVisualStyleBackColor = True
        '
        'grdStockD
        '
        Me.grdStockD.AllowUserToAddRows = False
        Me.grdStockD.AllowUserToDeleteRows = False
        Me.grdStockD.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdStockD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStockD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dinno, Me.dindt, Me.Design_no, Me.lot, Me.col, Me.gr, Me.Roll_No_d, Me.Loc, Me.kg, Me.mts, Me.yds, Me.rem_qc})
        Me.grdStockD.Location = New System.Drawing.Point(43, 156)
        Me.grdStockD.Name = "grdStockD"
        Me.grdStockD.Size = New System.Drawing.Size(1138, 234)
        Me.grdStockD.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSave, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1186, 25)
        Me.ToolStrip1.TabIndex = 286
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
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "Exit"
        '
        'dinno
        '
        Me.dinno.DataPropertyName = "dinno"
        Me.dinno.HeaderText = "DIN No."
        Me.dinno.Name = "dinno"
        Me.dinno.ReadOnly = True
        '
        'dindt
        '
        Me.dindt.DataPropertyName = "dindt"
        Me.dindt.HeaderText = "DIN Date"
        Me.dindt.Name = "dindt"
        Me.dindt.ReadOnly = True
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "design_no"
        Me.Design_no.HeaderText = "Design No."
        Me.Design_no.Name = "Design_no"
        Me.Design_no.ReadOnly = True
        '
        'lot
        '
        Me.lot.DataPropertyName = "lot"
        Me.lot.HeaderText = "Lot No."
        Me.lot.Name = "lot"
        Me.lot.ReadOnly = True
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color Code"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        '
        'gr
        '
        Me.gr.DataPropertyName = "gr"
        Me.gr.HeaderText = "Grade"
        Me.gr.Name = "gr"
        Me.gr.Width = 40
        '
        'Roll_No_d
        '
        Me.Roll_No_d.DataPropertyName = "roll_no_d"
        Me.Roll_No_d.HeaderText = "Roll No D"
        Me.Roll_No_d.Name = "Roll_No_d"
        Me.Roll_No_d.ReadOnly = True
        '
        'Loc
        '
        Me.Loc.DataPropertyName = "loc"
        Me.Loc.HeaderText = "Loc"
        Me.Loc.Name = "Loc"
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        Me.kg.HeaderText = "kg"
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
        'rem_qc
        '
        Me.rem_qc.DataPropertyName = "rem_qc"
        Me.rem_qc.HeaderText = "Q/c Rem"
        Me.rem_qc.Name = "rem_qc"
        Me.rem_qc.Width = 200
        '
        'frmStockDLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 498)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdStockD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmStockDLocation"
        Me.Text = "Stock D Location"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdStockD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSeach As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grdStockD As System.Windows.Forms.DataGridView
    Friend WithEvents optDFNo As System.Windows.Forms.RadioButton
    Friend WithEvents optCol As System.Windows.Forms.RadioButton
    Friend WithEvents optLotNo As System.Windows.Forms.RadioButton
    Friend WithEvents optDesignNo As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents dinno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dindt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Roll_No_d As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mts As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yds As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rem_qc As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
