<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompositionGroup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompositionGroup))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNameEn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPolymerPercentMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPolymerPercentMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKnittingLoss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMoistureLoss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOilLoss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty1Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty1Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty1Loss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty2Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty2Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty2Loss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty3Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty3Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty3Loss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty4Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty4Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty4Loss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty5Min = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty5Max = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty5Loss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(888, 25)
        Me.ToolStrip1.TabIndex = 20
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(325, 22)
        Me.ToolStripLabel1.Text = "ข้อมูลที่ใส่ลงไปแล้วห้ามลบทุกกรณี หากต้องการลบบอก Programmer"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdData.ColumnHeadersHeight = 30
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colCode, Me.colNameEn, Me.colPolymerPercentMin, Me.colPolymerPercentMax, Me.colKnittingLoss, Me.colMoistureLoss, Me.colOilLoss, Me.colQty1Min, Me.colQty1Max, Me.colQty1Loss, Me.colQty2Min, Me.colQty2Max, Me.colQty2Loss, Me.colQty3Min, Me.colQty3Max, Me.colQty3Loss, Me.colQty4Min, Me.colQty4Max, Me.colQty4Loss, Me.colQty5Min, Me.colQty5Max, Me.colQty5Loss})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.Location = New System.Drawing.Point(0, 25)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(888, 487)
        Me.grdData.TabIndex = 21
        '
        'colID
        '
        Me.colID.DataPropertyName = "id"
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'colCode
        '
        Me.colCode.DataPropertyName = "code"
        Me.colCode.HeaderText = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.ReadOnly = True
        '
        'colNameEn
        '
        Me.colNameEn.DataPropertyName = "name_en"
        Me.colNameEn.HeaderText = "Name (EN)"
        Me.colNameEn.Name = "colNameEn"
        Me.colNameEn.ReadOnly = True
        '
        'colPolymerPercentMin
        '
        Me.colPolymerPercentMin.DataPropertyName = "polymer_percent_min"
        Me.colPolymerPercentMin.HeaderText = "Polymer Min"
        Me.colPolymerPercentMin.Name = "colPolymerPercentMin"
        Me.colPolymerPercentMin.ReadOnly = True
        '
        'colPolymerPercentMax
        '
        Me.colPolymerPercentMax.DataPropertyName = "polymer_percent_max"
        Me.colPolymerPercentMax.HeaderText = "Polymer Max"
        Me.colPolymerPercentMax.Name = "colPolymerPercentMax"
        Me.colPolymerPercentMax.ReadOnly = True
        '
        'colKnittingLoss
        '
        Me.colKnittingLoss.DataPropertyName = "knitting_loss"
        Me.colKnittingLoss.HeaderText = "Knitting Loss"
        Me.colKnittingLoss.Name = "colKnittingLoss"
        Me.colKnittingLoss.ReadOnly = True
        '
        'colMoistureLoss
        '
        Me.colMoistureLoss.DataPropertyName = "moisture_loss"
        Me.colMoistureLoss.HeaderText = "Moist Loss"
        Me.colMoistureLoss.Name = "colMoistureLoss"
        Me.colMoistureLoss.ReadOnly = True
        '
        'colOilLoss
        '
        Me.colOilLoss.DataPropertyName = "oil_loss"
        Me.colOilLoss.HeaderText = "PU Oil Loss"
        Me.colOilLoss.Name = "colOilLoss"
        Me.colOilLoss.ReadOnly = True
        '
        'colQty1Min
        '
        Me.colQty1Min.DataPropertyName = "qty1_min"
        Me.colQty1Min.HeaderText = "Qty 1 Min"
        Me.colQty1Min.Name = "colQty1Min"
        Me.colQty1Min.ReadOnly = True
        '
        'colQty1Max
        '
        Me.colQty1Max.DataPropertyName = "qty1_max"
        Me.colQty1Max.HeaderText = "Qty 1 Max"
        Me.colQty1Max.Name = "colQty1Max"
        Me.colQty1Max.ReadOnly = True
        '
        'colQty1Loss
        '
        Me.colQty1Loss.DataPropertyName = "qty1_loss"
        Me.colQty1Loss.HeaderText = "Qty 1 Loss"
        Me.colQty1Loss.Name = "colQty1Loss"
        Me.colQty1Loss.ReadOnly = True
        '
        'colQty2Min
        '
        Me.colQty2Min.DataPropertyName = "qty2_min"
        Me.colQty2Min.HeaderText = "Qty 2 Min"
        Me.colQty2Min.Name = "colQty2Min"
        Me.colQty2Min.ReadOnly = True
        '
        'colQty2Max
        '
        Me.colQty2Max.DataPropertyName = "qty2_max"
        Me.colQty2Max.HeaderText = "Qty 2 Max"
        Me.colQty2Max.Name = "colQty2Max"
        Me.colQty2Max.ReadOnly = True
        '
        'colQty2Loss
        '
        Me.colQty2Loss.DataPropertyName = "qty2_loss"
        Me.colQty2Loss.HeaderText = "Qty 2 Loss"
        Me.colQty2Loss.Name = "colQty2Loss"
        Me.colQty2Loss.ReadOnly = True
        '
        'colQty3Min
        '
        Me.colQty3Min.DataPropertyName = "qty3_min"
        Me.colQty3Min.HeaderText = "Qty 3 Min"
        Me.colQty3Min.Name = "colQty3Min"
        Me.colQty3Min.ReadOnly = True
        '
        'colQty3Max
        '
        Me.colQty3Max.DataPropertyName = "qty3_max"
        Me.colQty3Max.HeaderText = "Qty 3 Max"
        Me.colQty3Max.Name = "colQty3Max"
        Me.colQty3Max.ReadOnly = True
        '
        'colQty3Loss
        '
        Me.colQty3Loss.DataPropertyName = "qty3_loss"
        Me.colQty3Loss.HeaderText = "Qty 3 Loss"
        Me.colQty3Loss.Name = "colQty3Loss"
        Me.colQty3Loss.ReadOnly = True
        '
        'colQty4Min
        '
        Me.colQty4Min.DataPropertyName = "qty4_min"
        Me.colQty4Min.HeaderText = "Qty 4 Min"
        Me.colQty4Min.Name = "colQty4Min"
        Me.colQty4Min.ReadOnly = True
        '
        'colQty4Max
        '
        Me.colQty4Max.DataPropertyName = "qty4_max"
        Me.colQty4Max.HeaderText = "Qty 4 Max"
        Me.colQty4Max.Name = "colQty4Max"
        Me.colQty4Max.ReadOnly = True
        '
        'colQty4Loss
        '
        Me.colQty4Loss.DataPropertyName = "qty4_loss"
        Me.colQty4Loss.HeaderText = "Qty 4 Loss"
        Me.colQty4Loss.Name = "colQty4Loss"
        Me.colQty4Loss.ReadOnly = True
        '
        'colQty5Min
        '
        Me.colQty5Min.DataPropertyName = "qty5_min"
        Me.colQty5Min.HeaderText = "Qty 5 Min"
        Me.colQty5Min.Name = "colQty5Min"
        Me.colQty5Min.ReadOnly = True
        '
        'colQty5Max
        '
        Me.colQty5Max.DataPropertyName = "qty5_max"
        Me.colQty5Max.HeaderText = "Qty 5 Max"
        Me.colQty5Max.Name = "colQty5Max"
        Me.colQty5Max.ReadOnly = True
        '
        'colQty5Loss
        '
        Me.colQty5Loss.DataPropertyName = "qty5_loss"
        Me.colQty5Loss.HeaderText = "Qty 5 Loss"
        Me.colQty5Loss.Name = "colQty5Loss"
        Me.colQty5Loss.ReadOnly = True
        '
        'frmCompositionGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 512)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmCompositionGroup"
        Me.Text = "Composition Group Master"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNameEn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPolymerPercentMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPolymerPercentMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKnittingLoss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMoistureLoss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOilLoss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty1Min As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty1Max As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty1Loss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty2Min As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty2Max As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty2Loss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty3Min As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty3Max As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty3Loss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty4Min As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty4Max As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty4Loss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty5Min As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty5Max As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty5Loss As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
