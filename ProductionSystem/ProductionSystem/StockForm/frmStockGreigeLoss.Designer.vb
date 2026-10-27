<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGreigeLoss
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGreigeLoss))
        Me.gbSystemRoll = New System.Windows.Forms.GroupBox()
        Me.lblsystem_lot_number = New System.Windows.Forms.Label()
        Me.txtsystem_lot_number = New System.Windows.Forms.TextBox()
        Me.txtdefect_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbldefect_loss_kg = New System.Windows.Forms.Label()
        Me.txtlab_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbllab_loss_kg = New System.Windows.Forms.Label()
        Me.txtdyed_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbldyed_loss_kg = New System.Windows.Forms.Label()
        Me.txtqc_loss_kg = New System.Windows.Forms.TextBox()
        Me.lblqc_loss_kg = New System.Windows.Forms.Label()
        Me.lbladjust_loss_kg = New System.Windows.Forms.Label()
        Me.txtadjust_loss_kg = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grdGregieLogDet = New System.Windows.Forms.DataGridView()
        Me.colRollNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAdjustLossKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQcLossKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDyedLossKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabLossKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDefectLossKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLogId = New System.Windows.Forms.TextBox()
        Me.dtpLogDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.lblSum = New System.Windows.Forms.ToolStripLabel()
        Me.lblTitleSum = New System.Windows.Forms.ToolStripLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripLabel()
        Me.lblCountHeader = New System.Windows.Forms.ToolStripLabel()
        Me.gbSystemRoll.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGregieLogDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbSystemRoll
        '
        Me.gbSystemRoll.Controls.Add(Me.lblsystem_lot_number)
        Me.gbSystemRoll.Controls.Add(Me.txtsystem_lot_number)
        Me.gbSystemRoll.Location = New System.Drawing.Point(12, 28)
        Me.gbSystemRoll.Name = "gbSystemRoll"
        Me.gbSystemRoll.Size = New System.Drawing.Size(244, 104)
        Me.gbSystemRoll.TabIndex = 524
        Me.gbSystemRoll.TabStop = False
        Me.gbSystemRoll.Text = "Scan Barcode"
        '
        'lblsystem_lot_number
        '
        Me.lblsystem_lot_number.AutoSize = True
        Me.lblsystem_lot_number.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsystem_lot_number.Location = New System.Drawing.Point(84, 10)
        Me.lblsystem_lot_number.Name = "lblsystem_lot_number"
        Me.lblsystem_lot_number.Size = New System.Drawing.Size(87, 30)
        Me.lblsystem_lot_number.TabIndex = 45
        Me.lblsystem_lot_number.Text = "Roll No."
        '
        'txtsystem_lot_number
        '
        Me.txtsystem_lot_number.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsystem_lot_number.Location = New System.Drawing.Point(36, 43)
        Me.txtsystem_lot_number.MaxLength = 20
        Me.txtsystem_lot_number.Name = "txtsystem_lot_number"
        Me.txtsystem_lot_number.Size = New System.Drawing.Size(169, 46)
        Me.txtsystem_lot_number.TabIndex = 1
        Me.txtsystem_lot_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdefect_loss_kg
        '
        Me.txtdefect_loss_kg.Location = New System.Drawing.Point(567, 34)
        Me.txtdefect_loss_kg.Name = "txtdefect_loss_kg"
        Me.txtdefect_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtdefect_loss_kg.TabIndex = 6
        Me.txtdefect_loss_kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbldefect_loss_kg
        '
        Me.lbldefect_loss_kg.AutoSize = True
        Me.lbldefect_loss_kg.Location = New System.Drawing.Point(583, 18)
        Me.lbldefect_loss_kg.Name = "lbldefect_loss_kg"
        Me.lbldefect_loss_kg.Size = New System.Drawing.Size(95, 13)
        Me.lbldefect_loss_kg.TabIndex = 590
        Me.lbldefect_loss_kg.Text = "Defect Loss (Kgs.)"
        '
        'txtlab_loss_kg
        '
        Me.txtlab_loss_kg.Location = New System.Drawing.Point(435, 34)
        Me.txtlab_loss_kg.Name = "txtlab_loss_kg"
        Me.txtlab_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtlab_loss_kg.TabIndex = 5
        Me.txtlab_loss_kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbllab_loss_kg
        '
        Me.lbllab_loss_kg.AutoSize = True
        Me.lbllab_loss_kg.Location = New System.Drawing.Point(458, 18)
        Me.lbllab_loss_kg.Name = "lbllab_loss_kg"
        Me.lbllab_loss_kg.Size = New System.Drawing.Size(80, 13)
        Me.lbllab_loss_kg.TabIndex = 589
        Me.lbllab_loss_kg.Text = "Lab Loss (Kgs.)"
        '
        'txtdyed_loss_kg
        '
        Me.txtdyed_loss_kg.Location = New System.Drawing.Point(304, 34)
        Me.txtdyed_loss_kg.Name = "txtdyed_loss_kg"
        Me.txtdyed_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtdyed_loss_kg.TabIndex = 4
        Me.txtdyed_loss_kg.Tag = ""
        Me.txtdyed_loss_kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbldyed_loss_kg
        '
        Me.lbldyed_loss_kg.AutoSize = True
        Me.lbldyed_loss_kg.Location = New System.Drawing.Point(314, 18)
        Me.lbldyed_loss_kg.Name = "lbldyed_loss_kg"
        Me.lbldyed_loss_kg.Size = New System.Drawing.Size(104, 13)
        Me.lbldyed_loss_kg.TabIndex = 588
        Me.lbldyed_loss_kg.Text = "Dye Test Loss (Kgs.)"
        '
        'txtqc_loss_kg
        '
        Me.txtqc_loss_kg.Location = New System.Drawing.Point(163, 34)
        Me.txtqc_loss_kg.Name = "txtqc_loss_kg"
        Me.txtqc_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtqc_loss_kg.TabIndex = 3
        Me.txtqc_loss_kg.Tag = ""
        Me.txtqc_loss_kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblqc_loss_kg
        '
        Me.lblqc_loss_kg.AutoSize = True
        Me.lblqc_loss_kg.Location = New System.Drawing.Point(181, 18)
        Me.lblqc_loss_kg.Name = "lblqc_loss_kg"
        Me.lblqc_loss_kg.Size = New System.Drawing.Size(77, 13)
        Me.lblqc_loss_kg.TabIndex = 587
        Me.lblqc_loss_kg.Text = "QC Loss (Kgs.)"
        '
        'lbladjust_loss_kg
        '
        Me.lbladjust_loss_kg.AutoSize = True
        Me.lbladjust_loss_kg.Location = New System.Drawing.Point(33, 18)
        Me.lbladjust_loss_kg.Name = "lbladjust_loss_kg"
        Me.lbladjust_loss_kg.Size = New System.Drawing.Size(100, 13)
        Me.lbladjust_loss_kg.TabIndex = 586
        Me.lbladjust_loss_kg.Text = "Process Loss (Kgs.)"
        '
        'txtadjust_loss_kg
        '
        Me.txtadjust_loss_kg.Location = New System.Drawing.Point(23, 34)
        Me.txtadjust_loss_kg.Name = "txtadjust_loss_kg"
        Me.txtadjust_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtadjust_loss_kg.TabIndex = 2
        Me.txtadjust_loss_kg.Tag = ""
        Me.txtadjust_loss_kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnApply)
        Me.GroupBox1.Controls.Add(Me.lbladjust_loss_kg)
        Me.GroupBox1.Controls.Add(Me.txtdefect_loss_kg)
        Me.GroupBox1.Controls.Add(Me.txtadjust_loss_kg)
        Me.GroupBox1.Controls.Add(Me.lbldefect_loss_kg)
        Me.GroupBox1.Controls.Add(Me.lblqc_loss_kg)
        Me.GroupBox1.Controls.Add(Me.txtlab_loss_kg)
        Me.GroupBox1.Controls.Add(Me.txtqc_loss_kg)
        Me.GroupBox1.Controls.Add(Me.lbllab_loss_kg)
        Me.GroupBox1.Controls.Add(Me.lbldyed_loss_kg)
        Me.GroupBox1.Controls.Add(Me.txtdyed_loss_kg)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 75)
        Me.GroupBox1.TabIndex = 591
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Defect Detail"
        '
        'btnApply
        '
        Me.btnApply.Image = Global.ProductionSystem.My.Resources.Resources.ApplyCodeChanges_16x
        Me.btnApply.Location = New System.Drawing.Point(705, 21)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 48)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Apply"
        Me.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(867, 25)
        Me.ToolStrip1.TabIndex = 592
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
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'grdGregieLogDet
        '
        Me.grdGregieLogDet.AllowUserToAddRows = False
        Me.grdGregieLogDet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdGregieLogDet.ColumnHeadersHeight = 40
        Me.grdGregieLogDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdGregieLogDet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRollNo, Me.colAdjustLossKg, Me.colQcLossKg, Me.colDyedLossKg, Me.colLabLossKg, Me.colDefectLossKg})
        Me.grdGregieLogDet.Location = New System.Drawing.Point(12, 236)
        Me.grdGregieLogDet.Name = "grdGregieLogDet"
        Me.grdGregieLogDet.Size = New System.Drawing.Size(835, 215)
        Me.grdGregieLogDet.TabIndex = 593
        '
        'colRollNo
        '
        Me.colRollNo.DataPropertyName = "system_lot_number"
        Me.colRollNo.HeaderText = "Roll No"
        Me.colRollNo.Name = "colRollNo"
        Me.colRollNo.ReadOnly = True
        '
        'colAdjustLossKg
        '
        Me.colAdjustLossKg.DataPropertyName = "adjust_loss_kg"
        Me.colAdjustLossKg.HeaderText = "Process Loss"
        Me.colAdjustLossKg.Name = "colAdjustLossKg"
        Me.colAdjustLossKg.ReadOnly = True
        '
        'colQcLossKg
        '
        Me.colQcLossKg.DataPropertyName = "qc_loss_kg"
        Me.colQcLossKg.HeaderText = "QC Loss Kg"
        Me.colQcLossKg.Name = "colQcLossKg"
        Me.colQcLossKg.ReadOnly = True
        '
        'colDyedLossKg
        '
        Me.colDyedLossKg.DataPropertyName = "dyed_loss_kg"
        Me.colDyedLossKg.HeaderText = "Dyed Loss Kg"
        Me.colDyedLossKg.Name = "colDyedLossKg"
        Me.colDyedLossKg.ReadOnly = True
        '
        'colLabLossKg
        '
        Me.colLabLossKg.DataPropertyName = "lab_loss_kg"
        Me.colLabLossKg.HeaderText = "Lab Loss Kg"
        Me.colLabLossKg.Name = "colLabLossKg"
        Me.colLabLossKg.ReadOnly = True
        '
        'colDefectLossKg
        '
        Me.colDefectLossKg.DataPropertyName = "defect_loss_kg"
        Me.colDefectLossKg.HeaderText = "Defect Loss Kg"
        Me.colDefectLossKg.Name = "colDefectLossKg"
        Me.colDefectLossKg.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(687, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 594
        Me.Label1.Text = "Log ID"
        '
        'txtLogId
        '
        Me.txtLogId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLogId.Location = New System.Drawing.Point(747, 43)
        Me.txtLogId.Name = "txtLogId"
        Me.txtLogId.Size = New System.Drawing.Size(100, 22)
        Me.txtLogId.TabIndex = 8
        '
        'dtpLogDate
        '
        Me.dtpLogDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpLogDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpLogDate.Enabled = False
        Me.dtpLogDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLogDate.Location = New System.Drawing.Point(746, 79)
        Me.dtpLogDate.Name = "dtpLogDate"
        Me.dtpLogDate.Size = New System.Drawing.Size(100, 22)
        Me.dtpLogDate.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(687, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 597
        Me.Label2.Text = "Log Date"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSum, Me.lblTitleSum, Me.lblCount, Me.lblCountHeader})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 464)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(867, 25)
        Me.ToolStrip2.TabIndex = 598
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'lblSum
        '
        Me.lblSum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(13, 22)
        Me.lblSum.Text = "0"
        '
        'lblTitleSum
        '
        Me.lblTitleSum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTitleSum.Name = "lblTitleSum"
        Me.lblTitleSum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitleSum.Size = New System.Drawing.Size(40, 22)
        Me.lblTitleSum.Text = " Sum :"
        '
        'lblCount
        '
        Me.lblCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(13, 22)
        Me.lblCount.Text = "0"
        '
        'lblCountHeader
        '
        Me.lblCountHeader.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblCountHeader.Name = "lblCountHeader"
        Me.lblCountHeader.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountHeader.Size = New System.Drawing.Size(43, 22)
        Me.lblCountHeader.Text = "Count:"
        '
        'frmStockGreigeLoss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 489)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpLogDate)
        Me.Controls.Add(Me.txtLogId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdGregieLogDet)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbSystemRoll)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmStockGreigeLoss"
        Me.Text = "Stock GIN Loss"
        Me.gbSystemRoll.ResumeLayout(False)
        Me.gbSystemRoll.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGregieLogDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbSystemRoll As GroupBox
    Friend WithEvents lblsystem_lot_number As Label
    Friend WithEvents txtsystem_lot_number As TextBox
    Friend WithEvents txtdefect_loss_kg As TextBox
    Friend WithEvents lbldefect_loss_kg As Label
    Friend WithEvents txtlab_loss_kg As TextBox
    Friend WithEvents lbllab_loss_kg As Label
    Friend WithEvents txtdyed_loss_kg As TextBox
    Friend WithEvents lbldyed_loss_kg As Label
    Friend WithEvents txtqc_loss_kg As TextBox
    Friend WithEvents lblqc_loss_kg As Label
    Friend WithEvents lbladjust_loss_kg As Label
    Friend WithEvents txtadjust_loss_kg As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpLogDate As DateTimePicker
    Friend WithEvents txtLogId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grdGregieLogDet As DataGridView
    Friend WithEvents btnApply As Button
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents lblSum As ToolStripLabel
    Friend WithEvents lblTitleSum As ToolStripLabel
    Friend WithEvents lblCount As ToolStripLabel
    Friend WithEvents lblCountHeader As ToolStripLabel
    Friend WithEvents colRollNo As DataGridViewTextBoxColumn
    Friend WithEvents colAdjustLossKg As DataGridViewTextBoxColumn
    Friend WithEvents colQcLossKg As DataGridViewTextBoxColumn
    Friend WithEvents colDyedLossKg As DataGridViewTextBoxColumn
    Friend WithEvents colLabLossKg As DataGridViewTextBoxColumn
    Friend WithEvents colDefectLossKg As DataGridViewTextBoxColumn
End Class
