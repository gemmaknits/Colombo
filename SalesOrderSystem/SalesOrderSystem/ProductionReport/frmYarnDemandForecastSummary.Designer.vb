<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYarnDemandForecastSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmYarnDemandForecastSummary))
        Me.chkMinus = New System.Windows.Forms.CheckBox()
        Me.OptREORDER = New System.Windows.Forms.RadioButton()
        Me.OptYarnDesc = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ddlSO = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ddlSupplier = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.OptSupp = New System.Windows.Forms.RadioButton()
        Me.ddlYarnCode = New System.Windows.Forms.ComboBox()
        Me.ddlKO = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ddlDesignNo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ddlMachineNo = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.optItcd = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkshow_only_demand_movement = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpdateto = New System.Windows.Forms.DateTimePicker()
        Me.dtpdatefr = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkShowNoDemand = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkMinus
        '
        Me.chkMinus.AutoSize = True
        Me.chkMinus.Location = New System.Drawing.Point(80, 176)
        Me.chkMinus.Name = "chkMinus"
        Me.chkMinus.Size = New System.Drawing.Size(152, 17)
        Me.chkMinus.TabIndex = 58
        Me.chkMinus.Text = "Show only shortage supply"
        Me.chkMinus.UseVisualStyleBackColor = True
        '
        'OptREORDER
        '
        Me.OptREORDER.AutoSize = True
        Me.OptREORDER.Location = New System.Drawing.Point(295, 24)
        Me.OptREORDER.Name = "OptREORDER"
        Me.OptREORDER.Size = New System.Drawing.Size(63, 17)
        Me.OptREORDER.TabIndex = 3
        Me.OptREORDER.TabStop = True
        Me.OptREORDER.Text = "Reorder"
        Me.OptREORDER.UseVisualStyleBackColor = True
        '
        'OptYarnDesc
        '
        Me.OptYarnDesc.AutoSize = True
        Me.OptYarnDesc.Location = New System.Drawing.Point(200, 24)
        Me.OptYarnDesc.Name = "OptYarnDesc"
        Me.OptYarnDesc.Size = New System.Drawing.Size(78, 17)
        Me.OptYarnDesc.TabIndex = 2
        Me.OptYarnDesc.TabStop = True
        Me.OptYarnDesc.Text = "Description"
        Me.OptYarnDesc.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "S/O No."
        '
        'ddlSO
        '
        Me.ddlSO.FormattingEnabled = True
        Me.ddlSO.Location = New System.Drawing.Point(80, 48)
        Me.ddlSO.Name = "ddlSO"
        Me.ddlSO.Size = New System.Drawing.Size(216, 21)
        Me.ddlSO.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Supplier"
        '
        'ddlSupplier
        '
        Me.ddlSupplier.FormattingEnabled = True
        Me.ddlSupplier.Location = New System.Drawing.Point(80, 144)
        Me.ddlSupplier.Name = "ddlSupplier"
        Me.ddlSupplier.Size = New System.Drawing.Size(216, 21)
        Me.ddlSupplier.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 13)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Yarn Code"
        '
        'OptSupp
        '
        Me.OptSupp.AutoSize = True
        Me.OptSupp.Location = New System.Drawing.Point(112, 24)
        Me.OptSupp.Name = "OptSupp"
        Me.OptSupp.Size = New System.Drawing.Size(63, 17)
        Me.OptSupp.TabIndex = 1
        Me.OptSupp.TabStop = True
        Me.OptSupp.Text = "Supplier"
        Me.OptSupp.UseVisualStyleBackColor = True
        '
        'ddlYarnCode
        '
        Me.ddlYarnCode.FormattingEnabled = True
        Me.ddlYarnCode.Location = New System.Drawing.Point(80, 120)
        Me.ddlYarnCode.Name = "ddlYarnCode"
        Me.ddlYarnCode.Size = New System.Drawing.Size(216, 21)
        Me.ddlYarnCode.TabIndex = 4
        '
        'ddlKO
        '
        Me.ddlKO.FormattingEnabled = True
        Me.ddlKO.Location = New System.Drawing.Point(80, 24)
        Me.ddlKO.Name = "ddlKO"
        Me.ddlKO.Size = New System.Drawing.Size(216, 21)
        Me.ddlKO.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Design No."
        '
        'ddlDesignNo
        '
        Me.ddlDesignNo.FormattingEnabled = True
        Me.ddlDesignNo.Location = New System.Drawing.Point(80, 72)
        Me.ddlDesignNo.Name = "ddlDesignNo"
        Me.ddlDesignNo.Size = New System.Drawing.Size(216, 21)
        Me.ddlDesignNo.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Machine No."
        '
        'ddlMachineNo
        '
        Me.ddlMachineNo.FormattingEnabled = True
        Me.ddlMachineNo.Location = New System.Drawing.Point(80, 96)
        Me.ddlMachineNo.Name = "ddlMachineNo"
        Me.ddlMachineNo.Size = New System.Drawing.Size(216, 21)
        Me.ddlMachineNo.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(410, 25)
        Me.ToolStrip1.TabIndex = 67
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "&Print"
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
        Me.btnExit.Text = "E&xit"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "K/O No."
        '
        'optItcd
        '
        Me.optItcd.AutoSize = True
        Me.optItcd.Checked = True
        Me.optItcd.Location = New System.Drawing.Point(16, 24)
        Me.optItcd.Name = "optItcd"
        Me.optItcd.Size = New System.Drawing.Size(73, 17)
        Me.optItcd.TabIndex = 0
        Me.optItcd.TabStop = True
        Me.optItcd.Text = "Item Code"
        Me.optItcd.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkshow_only_demand_movement)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.chkShowNoDemand)
        Me.GroupBox3.Controls.Add(Me.chkMinus)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.ddlSO)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ddlSupplier)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ddlYarnCode)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.ddlKO)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.ddlDesignNo)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.ddlMachineNo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(398, 367)
        Me.GroupBox3.TabIndex = 66
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Options"
        '
        'chkshow_only_demand_movement
        '
        Me.chkshow_only_demand_movement.AutoSize = True
        Me.chkshow_only_demand_movement.Location = New System.Drawing.Point(80, 223)
        Me.chkshow_only_demand_movement.Name = "chkshow_only_demand_movement"
        Me.chkshow_only_demand_movement.Size = New System.Drawing.Size(168, 17)
        Me.chkshow_only_demand_movement.TabIndex = 64
        Me.chkshow_only_demand_movement.Text = "Show only demand movement"
        Me.chkshow_only_demand_movement.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.dtpdateto)
        Me.GroupBox4.Controls.Add(Me.dtpdatefr)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 309)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(378, 47)
        Me.GroupBox4.TabIndex = 63
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Demand Movement "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(164, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "To."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Fr."
        '
        'dtpdateto
        '
        Me.dtpdateto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdateto.Location = New System.Drawing.Point(189, 19)
        Me.dtpdateto.Name = "dtpdateto"
        Me.dtpdateto.Size = New System.Drawing.Size(91, 20)
        Me.dtpdateto.TabIndex = 1
        '
        'dtpdatefr
        '
        Me.dtpdatefr.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpdatefr.Location = New System.Drawing.Point(32, 19)
        Me.dtpdatefr.Name = "dtpdatefr"
        Me.dtpdatefr.Size = New System.Drawing.Size(93, 20)
        Me.dtpdatefr.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.OptREORDER)
        Me.GroupBox6.Controls.Add(Me.OptYarnDesc)
        Me.GroupBox6.Controls.Add(Me.OptSupp)
        Me.GroupBox6.Controls.Add(Me.optItcd)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 246)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(378, 56)
        Me.GroupBox6.TabIndex = 60
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Sort By"
        '
        'chkShowNoDemand
        '
        Me.chkShowNoDemand.AutoSize = True
        Me.chkShowNoDemand.Location = New System.Drawing.Point(80, 200)
        Me.chkShowNoDemand.Name = "chkShowNoDemand"
        Me.chkShowNoDemand.Size = New System.Drawing.Size(158, 17)
        Me.chkShowNoDemand.TabIndex = 59
        Me.chkShowNoDemand.Text = "Show items without demand"
        Me.chkShowNoDemand.UseVisualStyleBackColor = True
        '
        'frmYarnDemandForecastSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 401)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmYarnDemandForecastSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yarn Demand Forecast Summary"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkMinus As System.Windows.Forms.CheckBox
    Friend WithEvents OptREORDER As System.Windows.Forms.RadioButton
    Friend WithEvents OptYarnDesc As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ddlSO As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ddlSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents OptSupp As System.Windows.Forms.RadioButton
    Friend WithEvents ddlYarnCode As System.Windows.Forms.ComboBox
    Friend WithEvents ddlKO As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ddlDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ddlMachineNo As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents optItcd As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkshow_only_demand_movement As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpdateto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdatefr As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkShowNoDemand As System.Windows.Forms.CheckBox
End Class
