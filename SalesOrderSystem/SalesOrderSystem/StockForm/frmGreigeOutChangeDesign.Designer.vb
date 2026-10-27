<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGreigeOutChangeDesign
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGreigeOutChangeDesign))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnPrintGOUT = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrintGIN = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtTranNoOld = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesignNoNew = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTranNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPackNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpOutDt = New System.Windows.Forms.DateTimePicker()
        Me.grdDataGreigeDo = New System.Windows.Forms.DataGridView()
        Me.TranNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollNoG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RollNoO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btncopyRoll = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grdDataGreige = New System.Windows.Forms.DataGridView()
        Me.grdDataGreigeTranNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataGreigeRollNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataGreigeRollNoG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataGreigeRollNoO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataGreigeDesignNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataGreigeKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataGreigeBarWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataGreigeMts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdDataGreigeYds = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdDataGreigeDo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grdDataGreige, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnCancel, Me.ToolStripDropDownButton1, Me.btnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(918, 25)
        Me.ToolStrip1.TabIndex = 5
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
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrintGOUT, Me.btnPrintGIN, Me.PrintTagToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Print"
        '
        'btnPrintGOUT
        '
        Me.btnPrintGOUT.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.btnPrintGOUT.Name = "btnPrintGOUT"
        Me.btnPrintGOUT.Size = New System.Drawing.Size(139, 22)
        Me.btnPrintGOUT.Text = "Print G-OUT"
        '
        'btnPrintGIN
        '
        Me.btnPrintGIN.Image = Global.SalesOrderSystem.My.Resources.Resources.Print_16x
        Me.btnPrintGIN.Name = "btnPrintGIN"
        Me.btnPrintGIN.Size = New System.Drawing.Size(139, 22)
        Me.btnPrintGIN.Text = "Print G-IN"
        '
        'PrintTagToolStripMenuItem
        '
        Me.PrintTagToolStripMenuItem.Image = Global.SalesOrderSystem.My.Resources.Resources.Tag_16x
        Me.PrintTagToolStripMenuItem.Name = "PrintTagToolStripMenuItem"
        Me.PrintTagToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PrintTagToolStripMenuItem.Text = "Print Tag"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(323, 22)
        Me.ToolStripLabel1.Text = "***โปรแกรม จะสร้าง GIN ให้อัตโนมัติ : Automatic GIN Create"
        '
        'txtTranNoOld
        '
        Me.txtTranNoOld.Location = New System.Drawing.Point(123, 28)
        Me.txtTranNoOld.Name = "txtTranNoOld"
        Me.txtTranNoOld.Size = New System.Drawing.Size(104, 22)
        Me.txtTranNoOld.TabIndex = 288
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 289
        Me.Label2.Text = "G-IN No."
        '
        'txtDesignNoNew
        '
        Me.txtDesignNoNew.Location = New System.Drawing.Point(123, 56)
        Me.txtDesignNoNew.Name = "txtDesignNoNew"
        Me.txtDesignNoNew.Size = New System.Drawing.Size(104, 22)
        Me.txtDesignNoNew.TabIndex = 290
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 291
        Me.Label1.Text = "New Design No."
        '
        'txtOutNo
        '
        Me.txtOutNo.Location = New System.Drawing.Point(102, 21)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(104, 22)
        Me.txtOutNo.TabIndex = 292
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 293
        Me.Label3.Text = "New G-OUT No."
        '
        'txtTranNo
        '
        Me.txtTranNo.Location = New System.Drawing.Point(102, 103)
        Me.txtTranNo.Name = "txtTranNo"
        Me.txtTranNo.ReadOnly = True
        Me.txtTranNo.Size = New System.Drawing.Size(104, 22)
        Me.txtTranNo.TabIndex = 294
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 295
        Me.Label4.Text = "New G-IN No."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPackNo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.dtpOutDt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTranNo)
        Me.GroupBox1.Controls.Add(Me.txtOutNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(677, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 144)
        Me.GroupBox1.TabIndex = 296
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documents"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 299
        Me.Label10.Text = "New Pack No."
        '
        'txtPackNo
        '
        Me.txtPackNo.Location = New System.Drawing.Point(102, 76)
        Me.txtPackNo.Name = "txtPackNo"
        Me.txtPackNo.ReadOnly = True
        Me.txtPackNo.Size = New System.Drawing.Size(104, 22)
        Me.txtPackNo.TabIndex = 298
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 297
        Me.Label9.Text = "Date"
        '
        'dtpOutDt
        '
        Me.dtpOutDt.CustomFormat = "dd/MM/yyyy"
        Me.dtpOutDt.Enabled = False
        Me.dtpOutDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOutDt.Location = New System.Drawing.Point(102, 48)
        Me.dtpOutDt.Name = "dtpOutDt"
        Me.dtpOutDt.Size = New System.Drawing.Size(104, 22)
        Me.dtpOutDt.TabIndex = 296
        '
        'grdDataGreigeDo
        '
        Me.grdDataGreigeDo.AllowUserToAddRows = False
        Me.grdDataGreigeDo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDataGreigeDo.ColumnHeadersHeight = 40
        Me.grdDataGreigeDo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TranNo, Me.RollNoG, Me.RollNoO, Me.DesignNo, Me.kg, Me.mts, Me.yds})
        Me.grdDataGreigeDo.Location = New System.Drawing.Point(3, 21)
        Me.grdDataGreigeDo.Name = "grdDataGreigeDo"
        Me.grdDataGreigeDo.Size = New System.Drawing.Size(847, 127)
        Me.grdDataGreigeDo.TabIndex = 297
        '
        'TranNo
        '
        Me.TranNo.DataPropertyName = "tran_no"
        Me.TranNo.HeaderText = "GIN No."
        Me.TranNo.Name = "TranNo"
        Me.TranNo.ReadOnly = True
        Me.TranNo.Visible = False
        '
        'RollNoG
        '
        Me.RollNoG.DataPropertyName = "roll_no_g"
        Me.RollNoG.HeaderText = "Roll No"
        Me.RollNoG.Name = "RollNoG"
        Me.RollNoG.ReadOnly = True
        '
        'RollNoO
        '
        Me.RollNoO.DataPropertyName = "roll_no_o"
        Me.RollNoO.HeaderText = "Factory Roll No"
        Me.RollNoO.Name = "RollNoO"
        Me.RollNoO.ReadOnly = True
        '
        'DesignNo
        '
        Me.DesignNo.DataPropertyName = "design_no"
        Me.DesignNo.HeaderText = "Design No (Original)"
        Me.DesignNo.Name = "DesignNo"
        Me.DesignNo.ReadOnly = True
        '
        'kg
        '
        Me.kg.DataPropertyName = "kg"
        Me.kg.HeaderText = "Kg"
        Me.kg.Name = "kg"
        Me.kg.ReadOnly = True
        Me.kg.Width = 50
        '
        'mts
        '
        Me.mts.DataPropertyName = "mts"
        Me.mts.HeaderText = "Mts"
        Me.mts.Name = "mts"
        Me.mts.ReadOnly = True
        Me.mts.Width = 50
        '
        'yds
        '
        Me.yds.DataPropertyName = "yds"
        Me.yds.HeaderText = "Yds"
        Me.yds.Name = "yds"
        Me.yds.ReadOnly = True
        Me.yds.Width = 50
        '
        'btncopyRoll
        '
        Me.btncopyRoll.Image = Global.SalesOrderSystem.My.Resources.Resources.Copy_16x
        Me.btncopyRoll.Location = New System.Drawing.Point(63, 5)
        Me.btncopyRoll.Name = "btncopyRoll"
        Me.btncopyRoll.Size = New System.Drawing.Size(80, 23)
        Me.btncopyRoll.TabIndex = 331
        Me.btncopyRoll.Text = "Copy Roll"
        Me.btncopyRoll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncopyRoll.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(26, 172)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(870, 342)
        Me.TabControl1.TabIndex = 332
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(862, 316)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View / Edit"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grdDataGreigeDo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdDataGreige)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btncopyRoll)
        Me.SplitContainer1.Size = New System.Drawing.Size(856, 310)
        Me.SplitContainer1.SplitterDistance = 154
        Me.SplitContainer1.TabIndex = 335
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 299
        Me.Label5.Text = "Gregie Out"
        '
        'grdDataGreige
        '
        Me.grdDataGreige.AllowUserToAddRows = False
        Me.grdDataGreige.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDataGreige.ColumnHeadersHeight = 40
        Me.grdDataGreige.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdDataGreigeTranNo, Me.grdDataGreigeRollNo, Me.grdDataGreigeRollNoG, Me.grdDataGreigeRollNoO, Me.grdDataGreigeDesignNo, Me.grdDataGreigeKg, Me.grdDataGreigeBarWeight, Me.grdDataGreigeMts, Me.grdDataGreigeYds})
        Me.grdDataGreige.Location = New System.Drawing.Point(6, 33)
        Me.grdDataGreige.Name = "grdDataGreige"
        Me.grdDataGreige.Size = New System.Drawing.Size(844, 113)
        Me.grdDataGreige.TabIndex = 298
        '
        'grdDataGreigeTranNo
        '
        Me.grdDataGreigeTranNo.DataPropertyName = "tran_no"
        Me.grdDataGreigeTranNo.HeaderText = "GIN No."
        Me.grdDataGreigeTranNo.Name = "grdDataGreigeTranNo"
        Me.grdDataGreigeTranNo.ReadOnly = True
        Me.grdDataGreigeTranNo.Visible = False
        '
        'grdDataGreigeRollNo
        '
        Me.grdDataGreigeRollNo.DataPropertyName = "roll_no"
        Me.grdDataGreigeRollNo.HeaderText = "Roll No"
        Me.grdDataGreigeRollNo.Name = "grdDataGreigeRollNo"
        Me.grdDataGreigeRollNo.ReadOnly = True
        '
        'grdDataGreigeRollNoG
        '
        Me.grdDataGreigeRollNoG.DataPropertyName = "roll_no_g"
        Me.grdDataGreigeRollNoG.HeaderText = "Roll No G"
        Me.grdDataGreigeRollNoG.Name = "grdDataGreigeRollNoG"
        Me.grdDataGreigeRollNoG.ReadOnly = True
        Me.grdDataGreigeRollNoG.Visible = False
        '
        'grdDataGreigeRollNoO
        '
        Me.grdDataGreigeRollNoO.DataPropertyName = "roll_no_o"
        Me.grdDataGreigeRollNoO.HeaderText = "Factory Roll No"
        Me.grdDataGreigeRollNoO.Name = "grdDataGreigeRollNoO"
        Me.grdDataGreigeRollNoO.ReadOnly = True
        '
        'grdDataGreigeDesignNo
        '
        Me.grdDataGreigeDesignNo.DataPropertyName = "design_no"
        Me.grdDataGreigeDesignNo.HeaderText = "Design No (New)"
        Me.grdDataGreigeDesignNo.Name = "grdDataGreigeDesignNo"
        Me.grdDataGreigeDesignNo.ReadOnly = True
        '
        'grdDataGreigeKg
        '
        Me.grdDataGreigeKg.DataPropertyName = "kg_qc"
        Me.grdDataGreigeKg.HeaderText = "Kg (Weight)"
        Me.grdDataGreigeKg.Name = "grdDataGreigeKg"
        Me.grdDataGreigeKg.Width = 50
        '
        'grdDataGreigeBarWeight
        '
        Me.grdDataGreigeBarWeight.DataPropertyName = "bar_weight"
        Me.grdDataGreigeBarWeight.HeaderText = "Bar Weight"
        Me.grdDataGreigeBarWeight.Name = "grdDataGreigeBarWeight"
        '
        'grdDataGreigeMts
        '
        Me.grdDataGreigeMts.DataPropertyName = "mts_qc"
        Me.grdDataGreigeMts.HeaderText = "Mts"
        Me.grdDataGreigeMts.Name = "grdDataGreigeMts"
        Me.grdDataGreigeMts.Width = 50
        '
        'grdDataGreigeYds
        '
        Me.grdDataGreigeYds.DataPropertyName = "yds_qc"
        Me.grdDataGreigeYds.HeaderText = "Yds"
        Me.grdDataGreigeYds.Name = "grdDataGreigeYds"
        Me.grdDataGreigeYds.Width = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 300
        Me.Label6.Text = "Gregie IN"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(233, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(165, 13)
        Me.Label7.TabIndex = 333
        Me.Label7.Text = "*** Enter GIN No Ex GI2020192"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(233, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 13)
        Me.Label8.TabIndex = 334
        Me.Label8.Text = "*** Enter Design No Ex. 20455"
        '
        'frmGreigeOutChangeDesign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 526)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtTranNoOld)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDesignNoNew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGreigeOutChangeDesign"
        Me.Text = "Greige Out - Change Design"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdDataGreigeDo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grdDataGreige, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtTranNoOld As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDesignNoNew As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTranNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdDataGreigeDo As DataGridView
    Friend WithEvents btncopyRoll As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents grdDataGreige As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TranNo As DataGridViewTextBoxColumn
    Friend WithEvents RollNoG As DataGridViewTextBoxColumn
    Friend WithEvents RollNoO As DataGridViewTextBoxColumn
    Friend WithEvents DesignNo As DataGridViewTextBoxColumn
    Friend WithEvents kg As DataGridViewTextBoxColumn
    Friend WithEvents mts As DataGridViewTextBoxColumn
    Friend WithEvents yds As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpOutDt As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPackNo As TextBox
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents btnPrintGOUT As ToolStripMenuItem
    Friend WithEvents btnPrintGIN As ToolStripMenuItem
    Friend WithEvents PrintTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grdDataGreigeTranNo As DataGridViewTextBoxColumn
    Friend WithEvents grdDataGreigeRollNo As DataGridViewTextBoxColumn
    Friend WithEvents grdDataGreigeRollNoG As DataGridViewTextBoxColumn
    Friend WithEvents grdDataGreigeRollNoO As DataGridViewTextBoxColumn
    Friend WithEvents grdDataGreigeDesignNo As DataGridViewTextBoxColumn
    Friend WithEvents grdDataGreigeKg As DataGridViewTextBoxColumn
    Friend WithEvents grdDataGreigeBarWeight As DataGridViewTextBoxColumn
    Friend WithEvents grdDataGreigeMts As DataGridViewTextBoxColumn
    Friend WithEvents grdDataGreigeYds As DataGridViewTextBoxColumn
End Class
