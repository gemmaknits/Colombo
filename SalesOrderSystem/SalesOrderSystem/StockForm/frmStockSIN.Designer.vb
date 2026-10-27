<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockSIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockSIN))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboSINNO = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpSINDate = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSINNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboDesignNo = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.optGre = New System.Windows.Forms.RadioButton()
        Me.optDye = New System.Windows.Forms.RadioButton()
        Me.optCut = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.grdStockS = New System.Windows.Forms.DataGridView()
        Me.col = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sonoid = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.roll_no_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboGwth = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboDocType = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdStockS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboSINNO, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(737, 25)
        Me.ToolStrip1.TabIndex = 139
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripLabel1.Text = "SIN No."
        '
        'cboSINNO
        '
        Me.cboSINNO.Name = "cboSINNO"
        Me.cboSINNO.Size = New System.Drawing.Size(100, 25)
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(560, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 266
        Me.Label15.Text = "SIN Date"
        '
        'dtpSINDate
        '
        Me.dtpSINDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpSINDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSINDate.Location = New System.Drawing.Point(632, 56)
        Me.dtpSINDate.Name = "dtpSINDate"
        Me.dtpSINDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpSINDate.TabIndex = 265
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 312)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 259
        Me.Label12.Text = "Remark"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(64, 312)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(664, 20)
        Me.txtRemark.TabIndex = 258
        Me.txtRemark.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(464, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 238
        Me.Label2.Text = "Gwth"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 236
        Me.Label1.Text = "Fabric Type"
        '
        'txtSINNo
        '
        Me.txtSINNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSINNo.Location = New System.Drawing.Point(632, 32)
        Me.txtSINNo.Name = "txtSINNo"
        Me.txtSINNo.Size = New System.Drawing.Size(96, 22)
        Me.txtSINNo.TabIndex = 235
        Me.txtSINNo.Tag = ""
        Me.txtSINNo.Text = "SO07060000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(560, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 233
        Me.Label3.Text = "SIN No."
        '
        'cboDesignNo
        '
        Me.cboDesignNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDesignNo.FormattingEnabled = True
        Me.cboDesignNo.Location = New System.Drawing.Point(352, 56)
        Me.cboDesignNo.Name = "cboDesignNo"
        Me.cboDesignNo.Size = New System.Drawing.Size(104, 21)
        Me.cboDesignNo.TabIndex = 267
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(8, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(510, 17)
        Me.Label16.TabIndex = 268
        Me.Label16.Text = "*** หน้านี้ใช้เฉพาะกรณีที่ต้องการนำผ้าที่หาที่มาไม่ได้มาเข้าระบบ (Scrap Return)"
        '
        'optGre
        '
        Me.optGre.AutoSize = True
        Me.optGre.Checked = True
        Me.optGre.Location = New System.Drawing.Point(80, 56)
        Me.optGre.Name = "optGre"
        Me.optGre.Size = New System.Drawing.Size(56, 17)
        Me.optGre.TabIndex = 269
        Me.optGre.TabStop = True
        Me.optGre.Text = "Greige"
        Me.optGre.UseVisualStyleBackColor = True
        '
        'optDye
        '
        Me.optDye.AutoSize = True
        Me.optDye.Location = New System.Drawing.Point(144, 56)
        Me.optDye.Name = "optDye"
        Me.optDye.Size = New System.Drawing.Size(50, 17)
        Me.optDye.TabIndex = 270
        Me.optDye.Text = "Dyed"
        Me.optDye.UseVisualStyleBackColor = True
        '
        'optCut
        '
        Me.optCut.AutoSize = True
        Me.optCut.Location = New System.Drawing.Point(208, 56)
        Me.optCut.Name = "optCut"
        Me.optCut.Size = New System.Drawing.Size(56, 17)
        Me.optCut.TabIndex = 271
        Me.optCut.TabStop = True
        Me.optCut.Text = "Cutted"
        Me.optCut.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(288, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 272
        Me.Label17.Text = "Design No."
        '
        'grdStockS
        '
        Me.grdStockS.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdStockS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdStockS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col, Me.custcolor, Me.loc, Me.lot, Me.batch, Me.gr, Me.nob, Me.kg, Me.yds, Me.mts, Me.sonoid, Me.roll_no_d})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdStockS.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdStockS.Location = New System.Drawing.Point(8, 88)
        Me.grdStockS.Name = "grdStockS"
        Me.grdStockS.Size = New System.Drawing.Size(720, 216)
        Me.grdStockS.TabIndex = 275
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.Width = 50
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Customer Color"
        Me.custcolor.Name = "custcolor"
        Me.custcolor.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.custcolor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.custcolor.Width = 65
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Location"
        Me.loc.Name = "loc"
        Me.loc.Width = 50
        '
        'lot
        '
        Me.lot.DataPropertyName = "lot"
        Me.lot.HeaderText = "Lot#"
        Me.lot.Name = "lot"
        Me.lot.Width = 50
        '
        'batch
        '
        Me.batch.DataPropertyName = "batch"
        Me.batch.HeaderText = "Batch"
        Me.batch.Name = "batch"
        Me.batch.Width = 50
        '
        'gr
        '
        Me.gr.DataPropertyName = "gr"
        Me.gr.HeaderText = "Gr"
        Me.gr.Name = "gr"
        Me.gr.Width = 25
        '
        'nob
        '
        Me.nob.DataPropertyName = "nob"
        Me.nob.HeaderText = "Nob"
        Me.nob.Name = "nob"
        Me.nob.Width = 35
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        Me.kg.HeaderText = "Kgs."
        Me.kg.Name = "kg"
        Me.kg.Width = 50
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        Me.yds.HeaderText = "Yds."
        Me.yds.Name = "yds"
        Me.yds.Width = 50
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        Me.mts.HeaderText = "Mts."
        Me.mts.Name = "mts"
        Me.mts.Width = 50
        '
        'sonoid
        '
        Me.sonoid.DataPropertyName = "sonoid"
        Me.sonoid.HeaderText = "S/O No. ID"
        Me.sonoid.Name = "sonoid"
        Me.sonoid.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sonoid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.sonoid.Width = 200
        '
        'roll_no_d
        '
        Me.roll_no_d.DataPropertyName = "roll_no_d"
        Me.roll_no_d.HeaderText = "Roll No."
        Me.roll_no_d.Name = "roll_no_d"
        Me.roll_no_d.Visible = False
        '
        'cboGwth
        '
        Me.cboGwth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGwth.FormattingEnabled = True
        Me.cboGwth.Location = New System.Drawing.Point(504, 56)
        Me.cboGwth.Name = "cboGwth"
        Me.cboGwth.Size = New System.Drawing.Size(48, 21)
        Me.cboGwth.TabIndex = 276
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 13)
        Me.Label4.TabIndex = 277
        Me.Label4.Text = "Automatically Generate Stock Out For"
        '
        'cboDocType
        '
        Me.cboDocType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDocType.FormattingEnabled = True
        Me.cboDocType.Location = New System.Drawing.Point(200, 336)
        Me.cboDocType.Name = "cboDocType"
        Me.cboDocType.Size = New System.Drawing.Size(216, 21)
        Me.cboDocType.TabIndex = 278
        '
        'frmStockSIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 369)
        Me.Controls.Add(Me.cboDocType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboGwth)
        Me.Controls.Add(Me.grdStockS)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.optCut)
        Me.Controls.Add(Me.optDye)
        Me.Controls.Add(Me.optGre)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cboDesignNo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtpSINDate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSINNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStockSIN"
        Me.Text = "Sample IN (Special Case : When can't identify source)"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdStockS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboSINNO As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents Label15 As System.Windows.Forms.Label
	Friend WithEvents dtpSINDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents txtRemark As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtSINNo As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents optGre As System.Windows.Forms.RadioButton
	Friend WithEvents optDye As System.Windows.Forms.RadioButton
	Friend WithEvents optCut As System.Windows.Forms.RadioButton
	Friend WithEvents Label17 As System.Windows.Forms.Label
	Friend WithEvents grdStockS As System.Windows.Forms.DataGridView
	Friend WithEvents cboGwth As System.Windows.Forms.ComboBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents cboDocType As System.Windows.Forms.ComboBox
	Friend WithEvents col As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents custcolor As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents loc As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents lot As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents batch As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents gr As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents nob As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents kg As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents yds As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents mts As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents sonoid As System.Windows.Forms.DataGridViewComboBoxColumn
	Friend WithEvents roll_no_d As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
