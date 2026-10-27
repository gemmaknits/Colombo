<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKOClosed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKOClosed))
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKoNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMcNo = New System.Windows.Forms.TextBox()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.optKODate = New System.Windows.Forms.RadioButton()
        Me.optClosedDate = New System.Windows.Forms.RadioButton()
        Me.optUnclosed = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkWarping = New System.Windows.Forms.RadioButton()
        Me.chkKnitting = New System.Windows.Forms.RadioButton()
        Me.chkActual = New System.Windows.Forms.CheckBox()
        Me.GrpSortBy = New System.Windows.Forms.GroupBox()
        Me.rdGrpByKO = New System.Windows.Forms.RadioButton()
        Me.rdGrpByOrder = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpSortBy.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "E&xit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "Design No."
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "&Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(93, 120)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(128, 22)
        Me.txtDesignNo.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(491, 25)
        Me.ToolStrip1.TabIndex = 5
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(376, 15)
        Me.ToolStripLabel1.Text = "***Please Verify the Accuracy of BOM and Actual Cone Weight*****"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 209
        Me.Label2.Text = "Production No."
        '
        'txtKoNo
        '
        Me.txtKoNo.Location = New System.Drawing.Point(93, 96)
        Me.txtKoNo.Name = "txtKoNo"
        Me.txtKoNo.Size = New System.Drawing.Size(128, 22)
        Me.txtKoNo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = "Machine No."
        '
        'txtMcNo
        '
        Me.txtMcNo.Location = New System.Drawing.Point(93, 144)
        Me.txtMcNo.Name = "txtMcNo"
        Me.txtMcNo.Size = New System.Drawing.Size(128, 22)
        Me.txtMcNo.TabIndex = 4
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(93, 63)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(104, 22)
        Me.dtpDateFr.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 214
        Me.Label6.Text = "From"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 216
        Me.Label5.Text = "To"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(261, 63)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(104, 22)
        Me.dtpDateTo.TabIndex = 1
        '
        'optKODate
        '
        Me.optKODate.AutoSize = True
        Me.optKODate.Location = New System.Drawing.Point(177, 33)
        Me.optKODate.Name = "optKODate"
        Me.optKODate.Size = New System.Drawing.Size(109, 17)
        Me.optKODate.TabIndex = 217
        Me.optKODate.Text = "Production Date"
        Me.optKODate.UseVisualStyleBackColor = True
        '
        'optClosedDate
        '
        Me.optClosedDate.AutoSize = True
        Me.optClosedDate.Checked = True
        Me.optClosedDate.Location = New System.Drawing.Point(66, 33)
        Me.optClosedDate.Name = "optClosedDate"
        Me.optClosedDate.Size = New System.Drawing.Size(87, 17)
        Me.optClosedDate.TabIndex = 218
        Me.optClosedDate.TabStop = True
        Me.optClosedDate.Text = "Closed Date"
        Me.optClosedDate.UseVisualStyleBackColor = True
        '
        'optUnclosed
        '
        Me.optUnclosed.AutoSize = True
        Me.optUnclosed.Location = New System.Drawing.Point(321, 33)
        Me.optUnclosed.Name = "optUnclosed"
        Me.optUnclosed.Size = New System.Drawing.Size(73, 17)
        Me.optUnclosed.TabIndex = 219
        Me.optUnclosed.Text = "Unclosed"
        Me.optUnclosed.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkWarping)
        Me.GroupBox1.Controls.Add(Me.chkKnitting)
        Me.GroupBox1.Location = New System.Drawing.Point(230, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(109, 76)
        Me.GroupBox1.TabIndex = 220
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Type"
        '
        'ChkWarping
        '
        Me.ChkWarping.AutoSize = True
        Me.ChkWarping.Location = New System.Drawing.Point(21, 46)
        Me.ChkWarping.Name = "ChkWarping"
        Me.ChkWarping.Size = New System.Drawing.Size(70, 17)
        Me.ChkWarping.TabIndex = 1
        Me.ChkWarping.Text = "Warping"
        Me.ChkWarping.UseVisualStyleBackColor = True
        '
        'chkKnitting
        '
        Me.chkKnitting.AutoSize = True
        Me.chkKnitting.Checked = True
        Me.chkKnitting.Location = New System.Drawing.Point(21, 23)
        Me.chkKnitting.Name = "chkKnitting"
        Me.chkKnitting.Size = New System.Drawing.Size(66, 17)
        Me.chkKnitting.TabIndex = 0
        Me.chkKnitting.TabStop = True
        Me.chkKnitting.Text = "Knitting"
        Me.chkKnitting.UseVisualStyleBackColor = True
        '
        'chkActual
        '
        Me.chkActual.AutoSize = True
        Me.chkActual.Location = New System.Drawing.Point(230, 175)
        Me.chkActual.Name = "chkActual"
        Me.chkActual.Size = New System.Drawing.Size(197, 17)
        Me.chkActual.TabIndex = 221
        Me.chkActual.Text = "Actual Data (Actual Cone Weight)"
        Me.chkActual.UseVisualStyleBackColor = True
        '
        'GrpSortBy
        '
        Me.GrpSortBy.Controls.Add(Me.rdGrpByKO)
        Me.GrpSortBy.Controls.Add(Me.rdGrpByOrder)
        Me.GrpSortBy.Location = New System.Drawing.Point(349, 88)
        Me.GrpSortBy.Name = "GrpSortBy"
        Me.GrpSortBy.Size = New System.Drawing.Size(129, 75)
        Me.GrpSortBy.TabIndex = 222
        Me.GrpSortBy.TabStop = False
        Me.GrpSortBy.Text = "Group / Sort"
        '
        'rdGrpByKO
        '
        Me.rdGrpByKO.AutoSize = True
        Me.rdGrpByKO.Location = New System.Drawing.Point(20, 46)
        Me.rdGrpByKO.Name = "rdGrpByKO"
        Me.rdGrpByKO.Size = New System.Drawing.Size(92, 17)
        Me.rdGrpByKO.TabIndex = 1
        Me.rdGrpByKO.Text = "Sort By KO/KI"
        Me.rdGrpByKO.UseVisualStyleBackColor = True
        '
        'rdGrpByOrder
        '
        Me.rdGrpByOrder.AutoSize = True
        Me.rdGrpByOrder.Checked = True
        Me.rdGrpByOrder.Location = New System.Drawing.Point(20, 23)
        Me.rdGrpByOrder.Name = "rdGrpByOrder"
        Me.rdGrpByOrder.Size = New System.Drawing.Size(106, 17)
        Me.rdGrpByOrder.TabIndex = 0
        Me.rdGrpByOrder.TabStop = True
        Me.rdGrpByOrder.Text = "Group By Order"
        Me.rdGrpByOrder.UseVisualStyleBackColor = True
        '
        'frmKOClosed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 207)
        Me.Controls.Add(Me.GrpSortBy)
        Me.Controls.Add(Me.chkActual)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.optUnclosed)
        Me.Controls.Add(Me.optClosedDate)
        Me.Controls.Add(Me.optKODate)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpDateFr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMcNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKoNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDesignNo)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKOClosed"
        Me.Text = "K/O & W/O Closed Report"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpSortBy.ResumeLayout(False)
        Me.GrpSortBy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDesignNo As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKoNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMcNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents optKODate As System.Windows.Forms.RadioButton
    Friend WithEvents optClosedDate As System.Windows.Forms.RadioButton
    Friend WithEvents optUnclosed As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkWarping As System.Windows.Forms.RadioButton
    Friend WithEvents chkKnitting As System.Windows.Forms.RadioButton
    Friend WithEvents chkActual As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GrpSortBy As GroupBox
    Friend WithEvents rdGrpByKO As RadioButton
    Friend WithEvents rdGrpByOrder As RadioButton
End Class
