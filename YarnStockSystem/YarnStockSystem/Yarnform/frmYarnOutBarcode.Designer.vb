<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnOutBarcode
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnOutBarcode))
        Me.txtRackNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblUnselectedKg_gr = New System.Windows.Forms.Label()
        Me.lblUnselectedSpools = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtUnselectedBoxs = New System.Windows.Forms.TextBox()
        Me.txtUnselectedkg_gr = New System.Windows.Forms.TextBox()
        Me.txtUnselectedSpools = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtUnselectedkg_nt = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSelectedBoxs = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtSelectedkg_gr = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSelectedSpools = New System.Windows.Forms.TextBox()
        Me.lblkg_nt = New System.Windows.Forms.Label()
        Me.txtSelectedkg_nt = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOutNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxNo = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.txtJobno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.itcd = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_cone_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMfgProductionOrderLineId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selected = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRackNo
        '
        Me.txtRackNo.Location = New System.Drawing.Point(64, 37)
        Me.txtRackNo.Name = "txtRackNo"
        Me.txtRackNo.Size = New System.Drawing.Size(56, 22)
        Me.txtRackNo.TabIndex = 310
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 337
        Me.Label5.Text = "Rack No."
        '
        'lblUnselectedKg_gr
        '
        Me.lblUnselectedKg_gr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUnselectedKg_gr.AutoSize = True
        Me.lblUnselectedKg_gr.Location = New System.Drawing.Point(312, 428)
        Me.lblUnselectedKg_gr.Name = "lblUnselectedKg_gr"
        Me.lblUnselectedKg_gr.Size = New System.Drawing.Size(36, 13)
        Me.lblUnselectedKg_gr.TabIndex = 336
        Me.lblUnselectedKg_gr.Text = "Gross"
        '
        'lblUnselectedSpools
        '
        Me.lblUnselectedSpools.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUnselectedSpools.AutoSize = True
        Me.lblUnselectedSpools.Location = New System.Drawing.Point(312, 404)
        Me.lblUnselectedSpools.Name = "lblUnselectedSpools"
        Me.lblUnselectedSpools.Size = New System.Drawing.Size(42, 13)
        Me.lblUnselectedSpools.TabIndex = 335
        Me.lblUnselectedSpools.Text = "Spools"
        '
        'Label30
        '
        Me.Label30.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(176, 404)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(31, 13)
        Me.Label30.TabIndex = 334
        Me.Label30.Text = "Boxs"
        '
        'txtUnselectedBoxs
        '
        Me.txtUnselectedBoxs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedBoxs.Location = New System.Drawing.Point(104, 404)
        Me.txtUnselectedBoxs.Name = "txtUnselectedBoxs"
        Me.txtUnselectedBoxs.ReadOnly = True
        Me.txtUnselectedBoxs.Size = New System.Drawing.Size(64, 22)
        Me.txtUnselectedBoxs.TabIndex = 333
        Me.txtUnselectedBoxs.Tag = "0"
        Me.txtUnselectedBoxs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnselectedkg_gr
        '
        Me.txtUnselectedkg_gr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedkg_gr.Location = New System.Drawing.Point(216, 428)
        Me.txtUnselectedkg_gr.Name = "txtUnselectedkg_gr"
        Me.txtUnselectedkg_gr.ReadOnly = True
        Me.txtUnselectedkg_gr.Size = New System.Drawing.Size(88, 22)
        Me.txtUnselectedkg_gr.TabIndex = 332
        Me.txtUnselectedkg_gr.Tag = "0.00"
        Me.txtUnselectedkg_gr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnselectedSpools
        '
        Me.txtUnselectedSpools.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedSpools.Location = New System.Drawing.Point(216, 404)
        Me.txtUnselectedSpools.Name = "txtUnselectedSpools"
        Me.txtUnselectedSpools.ReadOnly = True
        Me.txtUnselectedSpools.Size = New System.Drawing.Size(88, 22)
        Me.txtUnselectedSpools.TabIndex = 331
        Me.txtUnselectedSpools.Tag = "0.00"
        Me.txtUnselectedSpools.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(176, 428)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(25, 13)
        Me.Label31.TabIndex = 330
        Me.Label31.Text = "Net"
        '
        'txtUnselectedkg_nt
        '
        Me.txtUnselectedkg_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUnselectedkg_nt.Location = New System.Drawing.Point(104, 428)
        Me.txtUnselectedkg_nt.Name = "txtUnselectedkg_nt"
        Me.txtUnselectedkg_nt.ReadOnly = True
        Me.txtUnselectedkg_nt.Size = New System.Drawing.Size(64, 22)
        Me.txtUnselectedkg_nt.TabIndex = 328
        Me.txtUnselectedkg_nt.Tag = "0.00"
        Me.txtUnselectedkg_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(8, 404)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(96, 13)
        Me.Label32.TabIndex = 329
        Me.Label32.Text = "Total Un-selected"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(865, 404)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 13)
        Me.Label25.TabIndex = 327
        Me.Label25.Text = "Boxs"
        '
        'txtSelectedBoxs
        '
        Me.txtSelectedBoxs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedBoxs.Location = New System.Drawing.Point(793, 404)
        Me.txtSelectedBoxs.Name = "txtSelectedBoxs"
        Me.txtSelectedBoxs.ReadOnly = True
        Me.txtSelectedBoxs.Size = New System.Drawing.Size(64, 22)
        Me.txtSelectedBoxs.TabIndex = 326
        Me.txtSelectedBoxs.Tag = "0"
        Me.txtSelectedBoxs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(1001, 428)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 13)
        Me.Label24.TabIndex = 325
        Me.Label24.Text = "Gross"
        '
        'txtSelectedkg_gr
        '
        Me.txtSelectedkg_gr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedkg_gr.Location = New System.Drawing.Point(905, 428)
        Me.txtSelectedkg_gr.Name = "txtSelectedkg_gr"
        Me.txtSelectedkg_gr.ReadOnly = True
        Me.txtSelectedkg_gr.Size = New System.Drawing.Size(88, 22)
        Me.txtSelectedkg_gr.TabIndex = 324
        Me.txtSelectedkg_gr.Tag = "0.00"
        Me.txtSelectedkg_gr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(1001, 404)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 13)
        Me.Label23.TabIndex = 323
        Me.Label23.Text = "Spools"
        '
        'txtSelectedSpools
        '
        Me.txtSelectedSpools.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedSpools.Location = New System.Drawing.Point(905, 404)
        Me.txtSelectedSpools.Name = "txtSelectedSpools"
        Me.txtSelectedSpools.ReadOnly = True
        Me.txtSelectedSpools.Size = New System.Drawing.Size(88, 22)
        Me.txtSelectedSpools.TabIndex = 322
        Me.txtSelectedSpools.Tag = "0.00"
        Me.txtSelectedSpools.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblkg_nt
        '
        Me.lblkg_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblkg_nt.AutoSize = True
        Me.lblkg_nt.Location = New System.Drawing.Point(865, 428)
        Me.lblkg_nt.Name = "lblkg_nt"
        Me.lblkg_nt.Size = New System.Drawing.Size(25, 13)
        Me.lblkg_nt.TabIndex = 321
        Me.lblkg_nt.Text = "Net"
        '
        'txtSelectedkg_nt
        '
        Me.txtSelectedkg_nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSelectedkg_nt.Location = New System.Drawing.Point(793, 428)
        Me.txtSelectedkg_nt.Name = "txtSelectedkg_nt"
        Me.txtSelectedkg_nt.ReadOnly = True
        Me.txtSelectedkg_nt.Size = New System.Drawing.Size(64, 22)
        Me.txtSelectedkg_nt.TabIndex = 319
        Me.txtSelectedkg_nt.Tag = "0.00"
        Me.txtSelectedkg_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(713, 404)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 320
        Me.Label21.Text = "Total Selected"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("IDAutomationHC39M", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(728, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 24)
        Me.Label4.TabIndex = 318
        Me.Label4.Text = "*NEW*"
        '
        'txtOutNo
        '
        Me.txtOutNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutNo.Location = New System.Drawing.Point(940, 37)
        Me.txtOutNo.Name = "txtOutNo"
        Me.txtOutNo.Size = New System.Drawing.Size(104, 22)
        Me.txtOutNo.TabIndex = 312
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(886, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 317
        Me.Label2.Text = "Y-Out No."
        '
        'txtBoxNo
        '
        Me.txtBoxNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBoxNo.Location = New System.Drawing.Point(710, 37)
        Me.txtBoxNo.Name = "txtBoxNo"
        Me.txtBoxNo.Size = New System.Drawing.Size(168, 22)
        Me.txtBoxNo.TabIndex = 311
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(606, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 316
        Me.Label1.Text = "Box No. Barcode"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
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
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itcd, Me.Grade, Me.boxno_s, Me.boxno, Me.spools, Me.kg_gr, Me.cart_tearwt, Me.kg_nt, Me.actual_cone_weight, Me.loc, Me.GB, Me.colMfgProductionOrderLineId, Me.selected})
        Me.grdData.Location = New System.Drawing.Point(8, 69)
        Me.grdData.MultiSelect = False
        Me.grdData.Name = "grdData"
        Me.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdData.Size = New System.Drawing.Size(1036, 283)
        Me.grdData.TabIndex = 313
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel1.Text = "Y-Out No."
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
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
        'txtJobno
        '
        Me.txtJobno.Location = New System.Drawing.Point(232, 37)
        Me.txtJobno.Name = "txtJobno"
        Me.txtJobno.Size = New System.Drawing.Size(112, 22)
        Me.txtJobno.TabIndex = 309
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(128, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 315
        Me.Label3.Text = "Job No. Barcode"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1056, 25)
        Me.ToolStrip1.TabIndex = 314
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(150, 22)
        Me.ToolStripLabel2.Text = "Only 1 Job No. / 1 Out No."
        '
        'lblCancelled
        '
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(602, 1)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(131, 24)
        Me.lblCancelled.TabIndex = 338
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCancelled.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 340
        Me.Label8.Text = "Remark :"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(64, 358)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(980, 40)
        Me.txtRemark.TabIndex = 339
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Yarns"
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        Me.itcd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.itcd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.itcd.Width = 200
        '
        'Grade
        '
        Me.Grade.DataPropertyName = "Grade"
        Me.Grade.HeaderText = "Grade"
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        Me.Grade.Width = 50
        '
        'boxno_s
        '
        Me.boxno_s.DataPropertyName = "boxno_s"
        Me.boxno_s.HeaderText = "Supplier Box no."
        Me.boxno_s.Name = "boxno_s"
        Me.boxno_s.ReadOnly = True
        '
        'boxno
        '
        Me.boxno.DataPropertyName = "boxno"
        Me.boxno.HeaderText = "Internal Box no."
        Me.boxno.Name = "boxno"
        Me.boxno.ReadOnly = True
        Me.boxno.Width = 120
        '
        'spools
        '
        Me.spools.DataPropertyName = "spools"
        Me.spools.HeaderText = "Tube/ spools"
        Me.spools.Name = "spools"
        Me.spools.ReadOnly = True
        Me.spools.Width = 50
        '
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        Me.kg_gr.HeaderText = "Gross Weight{Kg}"
        Me.kg_gr.Name = "kg_gr"
        Me.kg_gr.ReadOnly = True
        Me.kg_gr.Width = 50
        '
        'cart_tearwt
        '
        Me.cart_tearwt.DataPropertyName = "cart_tearwt"
        Me.cart_tearwt.HeaderText = "Tear Weight{Kg}"
        Me.cart_tearwt.Name = "cart_tearwt"
        Me.cart_tearwt.ReadOnly = True
        Me.cart_tearwt.Width = 50
        '
        'kg_nt
        '
        Me.kg_nt.DataPropertyName = "kg_nt"
        Me.kg_nt.HeaderText = "Net weight{Kg}"
        Me.kg_nt.Name = "kg_nt"
        Me.kg_nt.ReadOnly = True
        Me.kg_nt.Width = 50
        '
        'actual_cone_weight
        '
        Me.actual_cone_weight.DataPropertyName = "actual_cone_weight"
        Me.actual_cone_weight.HeaderText = "Actual Cone Weight{Kg}"
        Me.actual_cone_weight.Name = "actual_cone_weight"
        Me.actual_cone_weight.ReadOnly = True
        Me.actual_cone_weight.Width = 60
        '
        'loc
        '
        Me.loc.DataPropertyName = "loc"
        Me.loc.HeaderText = "Loc"
        Me.loc.Name = "loc"
        Me.loc.ReadOnly = True
        Me.loc.Width = 55
        '
        'GB
        '
        Me.GB.DataPropertyName = "gb"
        Me.GB.HeaderText = "GB"
        Me.GB.Name = "GB"
        Me.GB.ReadOnly = True
        Me.GB.Width = 50
        '
        'colMfgProductionOrderLineId
        '
        Me.colMfgProductionOrderLineId.DataPropertyName = "mfg_production_order_line_id"
        Me.colMfgProductionOrderLineId.HeaderText = "Prod Line ID"
        Me.colMfgProductionOrderLineId.Name = "colMfgProductionOrderLineId"
        Me.colMfgProductionOrderLineId.ReadOnly = True
        Me.colMfgProductionOrderLineId.Width = 80
        '
        'selected
        '
        Me.selected.DataPropertyName = "selected"
        Me.selected.HeaderText = "Selected"
        Me.selected.Name = "selected"
        Me.selected.ReadOnly = True
        Me.selected.Width = 55
        '
        'frmYarnOutBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 456)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.lblCancelled)
        Me.Controls.Add(Me.txtRackNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblUnselectedKg_gr)
        Me.Controls.Add(Me.lblUnselectedSpools)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtUnselectedBoxs)
        Me.Controls.Add(Me.txtUnselectedkg_gr)
        Me.Controls.Add(Me.txtUnselectedSpools)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtUnselectedkg_nt)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtSelectedBoxs)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtSelectedkg_gr)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtSelectedSpools)
        Me.Controls.Add(Me.lblkg_nt)
        Me.Controls.Add(Me.txtSelectedkg_nt)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOutNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBoxNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.txtJobno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmYarnOutBarcode"
        Me.Text = "Yarn Out Barcode"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRackNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblUnselectedKg_gr As System.Windows.Forms.Label
    Friend WithEvents lblUnselectedSpools As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtUnselectedBoxs As System.Windows.Forms.TextBox
    Friend WithEvents txtUnselectedkg_gr As System.Windows.Forms.TextBox
    Friend WithEvents txtUnselectedSpools As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtUnselectedkg_nt As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedBoxs As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedkg_gr As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtSelectedSpools As System.Windows.Forms.TextBox
    Friend WithEvents lblkg_nt As System.Windows.Forms.Label
    Friend WithEvents txtSelectedkg_nt As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOutNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBoxNo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtJobno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents lblCancelled As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents itcd As DataGridViewComboBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
    Friend WithEvents boxno_s As DataGridViewTextBoxColumn
    Friend WithEvents boxno As DataGridViewTextBoxColumn
    Friend WithEvents spools As DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As DataGridViewTextBoxColumn
    Friend WithEvents cart_tearwt As DataGridViewTextBoxColumn
    Friend WithEvents kg_nt As DataGridViewTextBoxColumn
    Friend WithEvents actual_cone_weight As DataGridViewTextBoxColumn
    Friend WithEvents loc As DataGridViewTextBoxColumn
    Friend WithEvents GB As DataGridViewTextBoxColumn
    Friend WithEvents colMfgProductionOrderLineId As DataGridViewTextBoxColumn
    Friend WithEvents selected As DataGridViewCheckBoxColumn
End Class
