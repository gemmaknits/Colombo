<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formYarnLocation
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formYarnLocation))
		Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
		Me.cboDocNo = New System.Windows.Forms.ToolStripComboBox
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.btnNew = New System.Windows.Forms.ToolStripButton
		Me.btnSave = New System.Windows.Forms.ToolStripButton
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.btnMinimized = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.grdYarnIN = New System.Windows.Forms.DataGridView
		Me.chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.boxno = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.lotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.spools = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.txtLogNo = New System.Windows.Forms.TextBox
		Me.txtLogDate = New System.Windows.Forms.TextBox
		Me.cboItemCode = New System.Windows.Forms.ComboBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.txtLocation = New System.Windows.Forms.TextBox
		Me.btnSelect = New System.Windows.Forms.Button
		Me.grdTransfer = New System.Windows.Forms.DataGridView
		Me.tr_chkSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn
		Me.tr_boxno = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.tr_boxno_s = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.colLotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.tr_loc = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.tr_spools = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.tr_kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.tr_kg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.tr_cart_tearwt = New System.Windows.Forms.DataGridViewTextBoxColumn
		Me.btnDeselect = New System.Windows.Forms.Button
		Me.btnLoad = New System.Windows.Forms.Button
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.dtpActualMoveDate = New System.Windows.Forms.DateTimePicker
		Me.dtpReceiveDate = New System.Windows.Forms.DateTimePicker
		Me.ToolStrip1.SuspendLayout()
		CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboDocNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(801, 25)
		Me.ToolStrip1.TabIndex = 38
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(45, 22)
		Me.ToolStripLabel1.Text = "Doc No."
		'
		'cboDocNo
		'
		Me.cboDocNo.Name = "cboDocNo"
		Me.cboDocNo.Size = New System.Drawing.Size(125, 25)
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
		'btnMinimized
		'
		Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
		Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.btnMinimized.Name = "btnMinimized"
		Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
		Me.btnMinimized.Text = "Minimized"
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
		'grdYarnIN
		'
		Me.grdYarnIN.AllowUserToAddRows = False
		Me.grdYarnIN.AllowUserToDeleteRows = False
		DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.grdYarnIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		Me.grdYarnIN.BackgroundColor = System.Drawing.Color.PeachPuff
		Me.grdYarnIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdYarnIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSelect, Me.boxno, Me.boxno_s, Me.lotno_our, Me.loc, Me.spools, Me.kg_gr, Me.kg_nt, Me.cart_tearwt})
		Me.grdYarnIN.Location = New System.Drawing.Point(8, 88)
		Me.grdYarnIN.Name = "grdYarnIN"
		Me.grdYarnIN.Size = New System.Drawing.Size(368, 400)
		Me.grdYarnIN.TabIndex = 39
		'
		'chkSelect
		'
		Me.chkSelect.DataPropertyName = "chkSelect"
		Me.chkSelect.HeaderText = ""
		Me.chkSelect.Name = "chkSelect"
		Me.chkSelect.Width = 25
		'
		'boxno
		'
		Me.boxno.DataPropertyName = "boxno"
		Me.boxno.HeaderText = "Internal box no. (auto)"
		Me.boxno.MaxInputLength = 15
		Me.boxno.Name = "boxno"
		Me.boxno.ReadOnly = True
		Me.boxno.Width = 75
		'
		'boxno_s
		'
		Me.boxno_s.DataPropertyName = "boxno_s"
		Me.boxno_s.HeaderText = "Supplier Box no."
		Me.boxno_s.MaxInputLength = 15
		Me.boxno_s.Name = "boxno_s"
		Me.boxno_s.ReadOnly = True
		Me.boxno_s.Width = 75
		'
		'lotno_our
		'
		Me.lotno_our.DataPropertyName = "lotno_our"
		Me.lotno_our.HeaderText = "Lot No."
		Me.lotno_our.Name = "lotno_our"
		Me.lotno_our.ReadOnly = True
		'
		'loc
		'
		Me.loc.DataPropertyName = "loc"
		Me.loc.HeaderText = "Location"
		Me.loc.Name = "loc"
		Me.loc.ReadOnly = True
		'
		'spools
		'
		Me.spools.DataPropertyName = "spools"
		Me.spools.HeaderText = "Tube /Spools"
		Me.spools.MaxInputLength = 15
		Me.spools.Name = "spools"
		Me.spools.ReadOnly = True
		Me.spools.Width = 50
		'
		'kg_gr
		'
		Me.kg_gr.DataPropertyName = "kg_gr"
		Me.kg_gr.HeaderText = "Gross weight{Kg}"
		Me.kg_gr.MaxInputLength = 15
		Me.kg_gr.Name = "kg_gr"
		Me.kg_gr.ReadOnly = True
		Me.kg_gr.Width = 75
		'
		'kg_nt
		'
		Me.kg_nt.DataPropertyName = "kg_nt"
		Me.kg_nt.HeaderText = "Net weight{Kg}"
		Me.kg_nt.MaxInputLength = 15
		Me.kg_nt.Name = "kg_nt"
		Me.kg_nt.ReadOnly = True
		Me.kg_nt.Width = 75
		'
		'cart_tearwt
		'
		Me.cart_tearwt.DataPropertyName = "cart_tearwt"
		Me.cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
		Me.cart_tearwt.MaxInputLength = 15
		Me.cart_tearwt.Name = "cart_tearwt"
		Me.cart_tearwt.ReadOnly = True
		Me.cart_tearwt.Width = 75
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(632, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(47, 13)
		Me.Label1.TabIndex = 41
		Me.Label1.Text = "Doc No."
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(632, 56)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(53, 13)
		Me.Label2.TabIndex = 42
		Me.Label2.Text = "Doc Date"
		'
		'txtLogNo
		'
		Me.txtLogNo.Location = New System.Drawing.Point(688, 32)
		Me.txtLogNo.Name = "txtLogNo"
		Me.txtLogNo.Size = New System.Drawing.Size(104, 20)
		Me.txtLogNo.TabIndex = 43
		'
		'txtLogDate
		'
		Me.txtLogDate.Enabled = False
		Me.txtLogDate.Location = New System.Drawing.Point(712, 56)
		Me.txtLogDate.Name = "txtLogDate"
		Me.txtLogDate.Size = New System.Drawing.Size(80, 20)
		Me.txtLogDate.TabIndex = 44
		'
		'cboItemCode
		'
		Me.cboItemCode.FormattingEnabled = True
		Me.cboItemCode.Location = New System.Drawing.Point(280, 32)
		Me.cboItemCode.Name = "cboItemCode"
		Me.cboItemCode.Size = New System.Drawing.Size(128, 21)
		Me.cboItemCode.TabIndex = 55
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(208, 32)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(55, 13)
		Me.Label3.TabIndex = 56
		Me.Label3.Text = "Item Code"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(208, 56)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(48, 13)
		Me.Label4.TabIndex = 57
		Me.Label4.Text = "Location"
		'
		'txtLocation
		'
		Me.txtLocation.Location = New System.Drawing.Point(280, 56)
		Me.txtLocation.Name = "txtLocation"
		Me.txtLocation.Size = New System.Drawing.Size(128, 20)
		Me.txtLocation.TabIndex = 59
		'
		'btnSelect
		'
		Me.btnSelect.Location = New System.Drawing.Point(384, 88)
		Me.btnSelect.Name = "btnSelect"
		Me.btnSelect.Size = New System.Drawing.Size(32, 32)
		Me.btnSelect.TabIndex = 60
		Me.btnSelect.Text = ">"
		Me.btnSelect.UseVisualStyleBackColor = True
		'
		'grdTransfer
		'
		Me.grdTransfer.AllowUserToAddRows = False
		Me.grdTransfer.AllowUserToDeleteRows = False
		DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.grdTransfer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
		Me.grdTransfer.BackgroundColor = System.Drawing.Color.PeachPuff
		Me.grdTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.grdTransfer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tr_chkSelect, Me.tr_boxno, Me.tr_boxno_s, Me.colLotno_our, Me.tr_loc, Me.tr_spools, Me.tr_kg_gr, Me.tr_kg_nt, Me.tr_cart_tearwt})
		Me.grdTransfer.Location = New System.Drawing.Point(424, 88)
		Me.grdTransfer.Name = "grdTransfer"
		Me.grdTransfer.Size = New System.Drawing.Size(368, 400)
		Me.grdTransfer.TabIndex = 61
		'
		'tr_chkSelect
		'
		Me.tr_chkSelect.DataPropertyName = "chkSelect"
		Me.tr_chkSelect.HeaderText = ""
		Me.tr_chkSelect.Name = "tr_chkSelect"
		Me.tr_chkSelect.Width = 25
		'
		'tr_boxno
		'
		Me.tr_boxno.DataPropertyName = "boxno"
		Me.tr_boxno.HeaderText = "Internal box no. (auto)"
		Me.tr_boxno.MaxInputLength = 15
		Me.tr_boxno.Name = "tr_boxno"
		Me.tr_boxno.ReadOnly = True
		Me.tr_boxno.Width = 75
		'
		'tr_boxno_s
		'
		Me.tr_boxno_s.DataPropertyName = "boxno_s"
		Me.tr_boxno_s.HeaderText = "Supplier Box no."
		Me.tr_boxno_s.MaxInputLength = 15
		Me.tr_boxno_s.Name = "tr_boxno_s"
		Me.tr_boxno_s.ReadOnly = True
		Me.tr_boxno_s.Width = 75
		'
		'colLotno_our
		'
		Me.colLotno_our.DataPropertyName = "lotno_our"
		Me.colLotno_our.HeaderText = "Lot No."
		Me.colLotno_our.Name = "colLotno_our"
		Me.colLotno_our.ReadOnly = True
		'
		'tr_loc
		'
		Me.tr_loc.DataPropertyName = "loc"
		Me.tr_loc.HeaderText = "Location"
		Me.tr_loc.Name = "tr_loc"
		Me.tr_loc.ReadOnly = True
		'
		'tr_spools
		'
		Me.tr_spools.DataPropertyName = "spools"
		Me.tr_spools.HeaderText = "Tube /Spools"
		Me.tr_spools.MaxInputLength = 15
		Me.tr_spools.Name = "tr_spools"
		Me.tr_spools.ReadOnly = True
		Me.tr_spools.Width = 50
		'
		'tr_kg_gr
		'
		Me.tr_kg_gr.DataPropertyName = "kg_gr"
		Me.tr_kg_gr.HeaderText = "Gross weight{Kg}"
		Me.tr_kg_gr.MaxInputLength = 15
		Me.tr_kg_gr.Name = "tr_kg_gr"
		Me.tr_kg_gr.ReadOnly = True
		Me.tr_kg_gr.Width = 75
		'
		'tr_kg_nt
		'
		Me.tr_kg_nt.DataPropertyName = "kg_nt"
		Me.tr_kg_nt.HeaderText = "Net weight{Kg}"
		Me.tr_kg_nt.MaxInputLength = 15
		Me.tr_kg_nt.Name = "tr_kg_nt"
		Me.tr_kg_nt.ReadOnly = True
		Me.tr_kg_nt.Width = 75
		'
		'tr_cart_tearwt
		'
		Me.tr_cart_tearwt.DataPropertyName = "cart_tearwt"
		Me.tr_cart_tearwt.HeaderText = "Box Tear Weight{Kg}"
		Me.tr_cart_tearwt.MaxInputLength = 15
		Me.tr_cart_tearwt.Name = "tr_cart_tearwt"
		Me.tr_cart_tearwt.ReadOnly = True
		Me.tr_cart_tearwt.Width = 75
		'
		'btnDeselect
		'
		Me.btnDeselect.Location = New System.Drawing.Point(384, 128)
		Me.btnDeselect.Name = "btnDeselect"
		Me.btnDeselect.Size = New System.Drawing.Size(32, 32)
		Me.btnDeselect.TabIndex = 62
		Me.btnDeselect.Text = "<"
		Me.btnDeselect.UseVisualStyleBackColor = True
		'
		'btnLoad
		'
		Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
		Me.btnLoad.Location = New System.Drawing.Point(416, 32)
		Me.btnLoad.Name = "btnLoad"
		Me.btnLoad.Size = New System.Drawing.Size(63, 24)
		Me.btnLoad.TabIndex = 63
		Me.btnLoad.Text = "Load"
		Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(8, 56)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(73, 13)
		Me.Label5.TabIndex = 65
		Me.Label5.Text = "Receive Date"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(8, 32)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(93, 13)
		Me.Label6.TabIndex = 64
		Me.Label6.Text = "Actual Move Date"
		'
		'dtpActualMoveDate
		'
		Me.dtpActualMoveDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpActualMoveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpActualMoveDate.Location = New System.Drawing.Point(112, 32)
		Me.dtpActualMoveDate.Name = "dtpActualMoveDate"
		Me.dtpActualMoveDate.Size = New System.Drawing.Size(88, 20)
		Me.dtpActualMoveDate.TabIndex = 66
		'
		'dtpReceiveDate
		'
		Me.dtpReceiveDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpReceiveDate.Location = New System.Drawing.Point(112, 56)
		Me.dtpReceiveDate.Name = "dtpReceiveDate"
		Me.dtpReceiveDate.Size = New System.Drawing.Size(88, 20)
		Me.dtpReceiveDate.TabIndex = 67
		'
		'formYarnLocation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(801, 497)
		Me.Controls.Add(Me.dtpReceiveDate)
		Me.Controls.Add(Me.dtpActualMoveDate)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.btnLoad)
		Me.Controls.Add(Me.btnDeselect)
		Me.Controls.Add(Me.grdTransfer)
		Me.Controls.Add(Me.btnSelect)
		Me.Controls.Add(Me.txtLocation)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.cboItemCode)
		Me.Controls.Add(Me.txtLogDate)
		Me.Controls.Add(Me.txtLogNo)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.grdYarnIN)
		Me.Controls.Add(Me.ToolStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "formYarnLocation"
		Me.Text = "Change Yarn Location"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		CType(Me.grdYarnIN, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdTransfer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboDocNo As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents grdYarnIN As System.Windows.Forms.DataGridView
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
	Friend WithEvents txtLogNo As System.Windows.Forms.TextBox
	Friend WithEvents txtLogDate As System.Windows.Forms.TextBox
	Friend WithEvents cboItemCode As System.Windows.Forms.ComboBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents txtLocation As System.Windows.Forms.TextBox
	Friend WithEvents btnSelect As System.Windows.Forms.Button
	Friend WithEvents grdTransfer As System.Windows.Forms.DataGridView
	Friend WithEvents btnDeselect As System.Windows.Forms.Button
	Friend WithEvents btnLoad As System.Windows.Forms.Button
	Friend WithEvents chkSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents boxno As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents boxno_s As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents lotno_our As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents loc As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents spools As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents kg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents kg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents cart_tearwt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents tr_chkSelect As System.Windows.Forms.DataGridViewCheckBoxColumn
	Friend WithEvents tr_boxno As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents tr_boxno_s As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents colLotno_our As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents tr_loc As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents tr_spools As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents tr_kg_gr As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents tr_kg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents tr_cart_tearwt As System.Windows.Forms.DataGridViewTextBoxColumn
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents dtpActualMoveDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpReceiveDate As System.Windows.Forms.DateTimePicker
End Class
