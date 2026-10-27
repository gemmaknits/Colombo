<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabApvSheet
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLabApvSheet))
		Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
		Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
		Me.cboSheetID = New System.Windows.Forms.ToolStripComboBox
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
		Me.btnNew = New System.Windows.Forms.ToolStripButton
		Me.btnSave = New System.Windows.Forms.ToolStripButton
		Me.btnPrint = New System.Windows.Forms.ToolStripButton
		Me.btnCancel = New System.Windows.Forms.ToolStripButton
		Me.btnExit = New System.Windows.Forms.ToolStripButton
		Me.txtDesignNo = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.txtLabNo = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.txtGwth = New System.Windows.Forms.TextBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.txtColor = New System.Windows.Forms.TextBox
		Me.cboSoNoID = New System.Windows.Forms.ComboBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.cboCustomer = New System.Windows.Forms.ComboBox
		Me.txtAttention = New System.Windows.Forms.TextBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.chkLabDip = New System.Windows.Forms.CheckBox
		Me.chkShipping = New System.Windows.Forms.CheckBox
		Me.chkFinishing = New System.Windows.Forms.CheckBox
		Me.GroupBox1 = New System.Windows.Forms.GroupBox
		Me.Label8 = New System.Windows.Forms.Label
		Me.txtLotNo = New System.Windows.Forms.TextBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.txtLotQty = New System.Windows.Forms.TextBox
		Me.cboLotUOM = New System.Windows.Forms.ComboBox
		Me.cboBatchUOM = New System.Windows.Forms.ComboBox
		Me.Label10 = New System.Windows.Forms.Label
		Me.txtBatchQty = New System.Windows.Forms.TextBox
		Me.Label11 = New System.Windows.Forms.Label
		Me.txtBatch = New System.Windows.Forms.TextBox
		Me.Label12 = New System.Windows.Forms.Label
		Me.txtRemark = New System.Windows.Forms.TextBox
		Me.Label13 = New System.Windows.Forms.Label
		Me.txtShade1 = New System.Windows.Forms.TextBox
		Me.Label14 = New System.Windows.Forms.Label
		Me.txtShade2 = New System.Windows.Forms.TextBox
		Me.GroupBox2 = New System.Windows.Forms.GroupBox
		Me.dtpSheetDate = New System.Windows.Forms.DateTimePicker
		Me.Label15 = New System.Windows.Forms.Label
		Me.ToolStrip1.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'ToolStrip1
		'
		Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboSheetID, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit})
		Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
		Me.ToolStrip1.Name = "ToolStrip1"
		Me.ToolStrip1.Size = New System.Drawing.Size(521, 25)
		Me.ToolStrip1.TabIndex = 138
		'
		'ToolStripLabel1
		'
		Me.ToolStripLabel1.Name = "ToolStripLabel1"
		Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 22)
		Me.ToolStripLabel1.Text = "Sheet No."
		'
		'cboSheetID
		'
		Me.cboSheetID.Name = "cboSheetID"
		Me.cboSheetID.Size = New System.Drawing.Size(75, 25)
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
		'txtDesignNo
		'
		Me.txtDesignNo.Location = New System.Drawing.Point(232, 32)
		Me.txtDesignNo.Name = "txtDesignNo"
		Me.txtDesignNo.Size = New System.Drawing.Size(128, 20)
		Me.txtDesignNo.TabIndex = 197
		Me.txtDesignNo.Tag = ""
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(8, 32)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(45, 13)
		Me.Label3.TabIndex = 196
		Me.Label3.Text = "Lab No."
		'
		'txtLabNo
		'
		Me.txtLabNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
		Me.txtLabNo.Location = New System.Drawing.Point(64, 32)
		Me.txtLabNo.Name = "txtLabNo"
		Me.txtLabNo.Size = New System.Drawing.Size(96, 22)
		Me.txtLabNo.TabIndex = 198
		Me.txtLabNo.Tag = ""
		Me.txtLabNo.Text = "SO07060000"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(168, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(60, 13)
		Me.Label1.TabIndex = 199
		Me.Label1.Text = "Design No."
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(408, 32)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(32, 13)
		Me.Label2.TabIndex = 201
		Me.Label2.Text = "Gwth"
		'
		'txtGwth
		'
		Me.txtGwth.Location = New System.Drawing.Point(456, 32)
		Me.txtGwth.Name = "txtGwth"
		Me.txtGwth.Size = New System.Drawing.Size(56, 20)
		Me.txtGwth.TabIndex = 200
		Me.txtGwth.Tag = ""
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(192, 56)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(31, 13)
		Me.Label4.TabIndex = 203
		Me.Label4.Text = "Color"
		'
		'txtColor
		'
		Me.txtColor.Location = New System.Drawing.Point(232, 56)
		Me.txtColor.Name = "txtColor"
		Me.txtColor.Size = New System.Drawing.Size(280, 20)
		Me.txtColor.TabIndex = 202
		Me.txtColor.Tag = ""
		'
		'cboSoNoID
		'
		Me.cboSoNoID.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboSoNoID.FormattingEnabled = True
		Me.cboSoNoID.Location = New System.Drawing.Point(64, 96)
		Me.cboSoNoID.Name = "cboSoNoID"
		Me.cboSoNoID.Size = New System.Drawing.Size(264, 22)
		Me.cboSoNoID.TabIndex = 204
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(8, 96)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(47, 13)
		Me.Label5.TabIndex = 205
		Me.Label5.Text = "S/O No."
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(8, 120)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(51, 13)
		Me.Label6.TabIndex = 207
		Me.Label6.Text = "Customer"
		'
		'cboCustomer
		'
		Me.cboCustomer.FormattingEnabled = True
		Me.cboCustomer.Location = New System.Drawing.Point(64, 120)
		Me.cboCustomer.Name = "cboCustomer"
		Me.cboCustomer.Size = New System.Drawing.Size(264, 21)
		Me.cboCustomer.TabIndex = 206
		'
		'txtAttention
		'
		Me.txtAttention.Location = New System.Drawing.Point(392, 120)
		Me.txtAttention.Name = "txtAttention"
		Me.txtAttention.Size = New System.Drawing.Size(120, 20)
		Me.txtAttention.TabIndex = 208
		Me.txtAttention.Tag = ""
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(336, 120)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(49, 13)
		Me.Label7.TabIndex = 209
		Me.Label7.Text = "Attention"
		'
		'chkLabDip
		'
		Me.chkLabDip.AutoSize = True
		Me.chkLabDip.Checked = True
		Me.chkLabDip.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkLabDip.Location = New System.Drawing.Point(8, 24)
		Me.chkLabDip.Name = "chkLabDip"
		Me.chkLabDip.Size = New System.Drawing.Size(96, 17)
		Me.chkLabDip.TabIndex = 210
		Me.chkLabDip.Text = "Color - Lab Dip"
		Me.chkLabDip.UseVisualStyleBackColor = True
		'
		'chkShipping
		'
		Me.chkShipping.AutoSize = True
		Me.chkShipping.Location = New System.Drawing.Point(8, 48)
		Me.chkShipping.Name = "chkShipping"
		Me.chkShipping.Size = New System.Drawing.Size(138, 17)
		Me.chkShipping.TabIndex = 211
		Me.chkShipping.Text = "Color - Shipping Sample"
		Me.chkShipping.UseVisualStyleBackColor = True
		'
		'chkFinishing
		'
		Me.chkFinishing.AutoSize = True
		Me.chkFinishing.Location = New System.Drawing.Point(8, 72)
		Me.chkFinishing.Name = "chkFinishing"
		Me.chkFinishing.Size = New System.Drawing.Size(150, 17)
		Me.chkFinishing.TabIndex = 212
		Me.chkFinishing.Text = "Quality-Finishing/Handfeel"
		Me.chkFinishing.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.chkLabDip)
		Me.GroupBox1.Controls.Add(Me.chkFinishing)
		Me.GroupBox1.Controls.Add(Me.chkShipping)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 152)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(160, 104)
		Me.GroupBox1.TabIndex = 213
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Approval Issue"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(176, 152)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(42, 13)
		Me.Label8.TabIndex = 215
		Me.Label8.Text = "Lot No."
		'
		'txtLotNo
		'
		Me.txtLotNo.Location = New System.Drawing.Point(232, 152)
		Me.txtLotNo.Name = "txtLotNo"
		Me.txtLotNo.Size = New System.Drawing.Size(56, 20)
		Me.txtLotNo.TabIndex = 214
		Me.txtLotNo.Tag = ""
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(296, 152)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(44, 13)
		Me.Label9.TabIndex = 217
		Me.Label9.Text = "Lot Qty."
		'
		'txtLotQty
		'
		Me.txtLotQty.Location = New System.Drawing.Point(360, 152)
		Me.txtLotQty.Name = "txtLotQty"
		Me.txtLotQty.Size = New System.Drawing.Size(80, 20)
		Me.txtLotQty.TabIndex = 216
		Me.txtLotQty.Tag = ""
		'
		'cboLotUOM
		'
		Me.cboLotUOM.FormattingEnabled = True
		Me.cboLotUOM.Location = New System.Drawing.Point(448, 152)
		Me.cboLotUOM.Name = "cboLotUOM"
		Me.cboLotUOM.Size = New System.Drawing.Size(64, 21)
		Me.cboLotUOM.TabIndex = 218
		'
		'cboBatchUOM
		'
		Me.cboBatchUOM.FormattingEnabled = True
		Me.cboBatchUOM.Location = New System.Drawing.Point(448, 176)
		Me.cboBatchUOM.Name = "cboBatchUOM"
		Me.cboBatchUOM.Size = New System.Drawing.Size(64, 21)
		Me.cboBatchUOM.TabIndex = 223
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(296, 176)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(57, 13)
		Me.Label10.TabIndex = 222
		Me.Label10.Text = "Batch Qty."
		'
		'txtBatchQty
		'
		Me.txtBatchQty.Location = New System.Drawing.Point(360, 176)
		Me.txtBatchQty.Name = "txtBatchQty"
		Me.txtBatchQty.Size = New System.Drawing.Size(80, 20)
		Me.txtBatchQty.TabIndex = 221
		Me.txtBatchQty.Tag = ""
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(176, 176)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(35, 13)
		Me.Label11.TabIndex = 220
		Me.Label11.Text = "Batch"
		'
		'txtBatch
		'
		Me.txtBatch.Location = New System.Drawing.Point(232, 176)
		Me.txtBatch.Name = "txtBatch"
		Me.txtBatch.Size = New System.Drawing.Size(56, 20)
		Me.txtBatch.TabIndex = 219
		Me.txtBatch.Tag = ""
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(176, 200)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(44, 13)
		Me.Label12.TabIndex = 225
		Me.Label12.Text = "Remark"
		'
		'txtRemark
		'
		Me.txtRemark.Location = New System.Drawing.Point(232, 200)
		Me.txtRemark.Name = "txtRemark"
		Me.txtRemark.Size = New System.Drawing.Size(280, 20)
		Me.txtRemark.TabIndex = 224
		Me.txtRemark.Tag = ""
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(176, 224)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(51, 13)
		Me.Label13.TabIndex = 227
		Me.Label13.Text = "Shade#1"
		'
		'txtShade1
		'
		Me.txtShade1.Location = New System.Drawing.Point(232, 224)
		Me.txtShade1.Name = "txtShade1"
		Me.txtShade1.Size = New System.Drawing.Size(104, 20)
		Me.txtShade1.TabIndex = 226
		Me.txtShade1.Tag = ""
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(352, 224)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(51, 13)
		Me.Label14.TabIndex = 229
		Me.Label14.Text = "Shade#2"
		'
		'txtShade2
		'
		Me.txtShade2.Location = New System.Drawing.Point(408, 224)
		Me.txtShade2.Name = "txtShade2"
		Me.txtShade2.Size = New System.Drawing.Size(104, 20)
		Me.txtShade2.TabIndex = 228
		Me.txtShade2.Tag = ""
		'
		'GroupBox2
		'
		Me.GroupBox2.Location = New System.Drawing.Point(8, 80)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(504, 8)
		Me.GroupBox2.TabIndex = 230
		Me.GroupBox2.TabStop = False
		'
		'dtpSheetDate
		'
		Me.dtpSheetDate.CustomFormat = "dd/MM/yyyy"
		Me.dtpSheetDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpSheetDate.Location = New System.Drawing.Point(416, 96)
		Me.dtpSheetDate.Name = "dtpSheetDate"
		Me.dtpSheetDate.Size = New System.Drawing.Size(96, 20)
		Me.dtpSheetDate.TabIndex = 231
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(336, 96)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(61, 13)
		Me.Label15.TabIndex = 232
		Me.Label15.Text = "Sheet Date"
		'
		'frmLabApvSheet
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(521, 265)
		Me.Controls.Add(Me.Label15)
		Me.Controls.Add(Me.dtpSheetDate)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.Label14)
		Me.Controls.Add(Me.txtShade2)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.txtShade1)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.txtRemark)
		Me.Controls.Add(Me.cboBatchUOM)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.txtBatchQty)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.txtBatch)
		Me.Controls.Add(Me.cboLotUOM)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.txtLotQty)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.txtLotNo)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.txtAttention)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.cboCustomer)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.cboSoNoID)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtColor)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtGwth)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtLabNo)
		Me.Controls.Add(Me.txtDesignNo)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.ToolStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmLabApvSheet"
		Me.Text = "Lab Approval Sheet"
		Me.ToolStrip1.ResumeLayout(False)
		Me.ToolStrip1.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
	Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
	Friend WithEvents cboSheetID As System.Windows.Forms.ToolStripComboBox
	Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
	Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
	Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents txtLabNo As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents txtGwth As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents txtColor As System.Windows.Forms.TextBox
	Friend WithEvents cboSoNoID As System.Windows.Forms.ComboBox
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
	Friend WithEvents txtAttention As System.Windows.Forms.TextBox
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents chkLabDip As System.Windows.Forms.CheckBox
	Friend WithEvents chkShipping As System.Windows.Forms.CheckBox
	Friend WithEvents chkFinishing As System.Windows.Forms.CheckBox
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents txtLotNo As System.Windows.Forms.TextBox
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents txtLotQty As System.Windows.Forms.TextBox
	Friend WithEvents cboLotUOM As System.Windows.Forms.ComboBox
	Friend WithEvents cboBatchUOM As System.Windows.Forms.ComboBox
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents txtBatchQty As System.Windows.Forms.TextBox
	Friend WithEvents Label11 As System.Windows.Forms.Label
	Friend WithEvents txtBatch As System.Windows.Forms.TextBox
	Friend WithEvents Label12 As System.Windows.Forms.Label
	Friend WithEvents txtRemark As System.Windows.Forms.TextBox
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents txtShade1 As System.Windows.Forms.TextBox
	Friend WithEvents Label14 As System.Windows.Forms.Label
	Friend WithEvents txtShade2 As System.Windows.Forms.TextBox
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents dtpSheetDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
