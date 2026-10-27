<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStockOnhand
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockOnhand))
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.optPrintOnly = New System.Windows.Forms.RadioButton()
        Me.optPrintAll = New System.Windows.Forms.RadioButton()
        Me.cboPrintOnly = New System.Windows.Forms.ComboBox()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grdDesignNo = New System.Windows.Forms.DataGridView()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.optPrintExcept = New System.Windows.Forms.RadioButton()
        Me.cboPrintExcept = New System.Windows.Forms.ComboBox()
        Me.gbSuppiler = New System.Windows.Forms.GroupBox()
        Me.gbReportType = New System.Windows.Forms.GroupBox()
        Me.optSumDesignAndColorAndSale = New System.Windows.Forms.RadioButton()
        Me.optSumDesignAndColorAndGINDate = New System.Windows.Forms.RadioButton()
        Me.optSumDesignAndColor = New System.Windows.Forms.RadioButton()
        Me.optSumRollDefectWithDesign = New System.Windows.Forms.RadioButton()
        Me.optSumRollDefect = New System.Windows.Forms.RadioButton()
        Me.optSumDesign = New System.Windows.Forms.RadioButton()
        Me.optSumRoll = New System.Windows.Forms.RadioButton()
        Me.optDetail = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.gbGreigeOption = New System.Windows.Forms.GroupBox()
        Me.optGreigeAll = New System.Windows.Forms.RadioButton()
        Me.optGreigeNonPreset = New System.Windows.Forms.RadioButton()
        Me.optGreigePreset = New System.Windows.Forms.RadioButton()
        Me.optStockD = New System.Windows.Forms.RadioButton()
        Me.optStockG = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFwth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbOrderFilter = New System.Windows.Forms.GroupBox()
        Me.optOrderFilterOTHER = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterAll = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterMTO = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterMTS = New System.Windows.Forms.RadioButton()
        Me.optOrderFilterDevl = New System.Windows.Forms.RadioButton()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblmtl_warehourse = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbStockReceviedDate = New System.Windows.Forms.GroupBox()
        Me.dtpStockYearFr = New System.Windows.Forms.DateTimePicker()
        Me.dtpStockYearTo = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtGradePrintOnly = New System.Windows.Forms.TextBox()
        Me.txtGradePrintExcept = New System.Windows.Forms.TextBox()
        Me.gbStockLocations = New System.Windows.Forms.GroupBox()
        Me.cboNewmtl_locations_id = New System.Windows.Forms.ComboBox()
        Me.gbCustomer = New System.Windows.Forms.GroupBox()
        Me.cboCustPrintExcept = New System.Windows.Forms.ComboBox()
        Me.optCustPrintExcept = New System.Windows.Forms.RadioButton()
        Me.optCustPrintOnly = New System.Windows.Forms.RadioButton()
        Me.optCustPrintAll = New System.Windows.Forms.RadioButton()
        Me.cboCustPrintOnly = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optPrintGradeOnly2 = New System.Windows.Forms.RadioButton()
        Me.optPrintGradeExcept2 = New System.Windows.Forms.RadioButton()
        Me.optPrintGradeExcept = New System.Windows.Forms.RadioButton()
        Me.optPrintGradeOnly = New System.Windows.Forms.RadioButton()
        Me.optPrintGradeAll = New System.Windows.Forms.RadioButton()
        Me.optStockGamma = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDesignNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSuppiler.SuspendLayout()
        Me.gbReportType.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbGreigeOption.SuspendLayout()
        Me.gbOrderFilter.SuspendLayout()
        Me.gbStockReceviedDate.SuspendLayout()
        Me.gbStockLocations.SuspendLayout()
        Me.gbCustomer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnExit.Text = "E&xit"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1028, 25)
        Me.ToolStrip1.TabIndex = 19
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "&Print"
        '
        'optPrintOnly
        '
        Me.optPrintOnly.AutoSize = True
        Me.optPrintOnly.Location = New System.Drawing.Point(16, 38)
        Me.optPrintOnly.Name = "optPrintOnly"
        Me.optPrintOnly.Size = New System.Drawing.Size(76, 17)
        Me.optPrintOnly.TabIndex = 9
        Me.optPrintOnly.Text = "Print Only"
        Me.optPrintOnly.UseVisualStyleBackColor = True
        '
        'optPrintAll
        '
        Me.optPrintAll.AutoSize = True
        Me.optPrintAll.Checked = True
        Me.optPrintAll.Location = New System.Drawing.Point(16, 16)
        Me.optPrintAll.Name = "optPrintAll"
        Me.optPrintAll.Size = New System.Drawing.Size(65, 17)
        Me.optPrintAll.TabIndex = 8
        Me.optPrintAll.TabStop = True
        Me.optPrintAll.Text = "Print All"
        Me.optPrintAll.UseVisualStyleBackColor = True
        '
        'cboPrintOnly
        '
        Me.cboPrintOnly.FormattingEnabled = True
        Me.cboPrintOnly.Location = New System.Drawing.Point(112, 38)
        Me.cboPrintOnly.Name = "cboPrintOnly"
        Me.cboPrintOnly.Size = New System.Drawing.Size(153, 21)
        Me.cboPrintOnly.TabIndex = 6
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Checked = False
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(201, 19)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.ShowCheckBox = True
        Me.dtpDateTo.Size = New System.Drawing.Size(103, 22)
        Me.dtpDateTo.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Enter Design No. :"
        '
        'grdDesignNo
        '
        Me.grdDesignNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdDesignNo.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDesignNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDesignNo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.design_no})
        Me.grdDesignNo.Location = New System.Drawing.Point(11, 51)
        Me.grdDesignNo.Name = "grdDesignNo"
        Me.grdDesignNo.Size = New System.Drawing.Size(267, 569)
        Me.grdDesignNo.TabIndex = 21
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No."
        Me.design_no.Name = "design_no"
        Me.design_no.Width = 200
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Location"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(106, 100)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(194, 22)
        Me.txtLocation.TabIndex = 23
        '
        'optPrintExcept
        '
        Me.optPrintExcept.AutoSize = True
        Me.optPrintExcept.Location = New System.Drawing.Point(16, 62)
        Me.optPrintExcept.Name = "optPrintExcept"
        Me.optPrintExcept.Size = New System.Drawing.Size(85, 17)
        Me.optPrintExcept.TabIndex = 24
        Me.optPrintExcept.Text = "Print Except"
        Me.optPrintExcept.UseVisualStyleBackColor = True
        '
        'cboPrintExcept
        '
        Me.cboPrintExcept.FormattingEnabled = True
        Me.cboPrintExcept.Location = New System.Drawing.Point(112, 62)
        Me.cboPrintExcept.Name = "cboPrintExcept"
        Me.cboPrintExcept.Size = New System.Drawing.Size(153, 21)
        Me.cboPrintExcept.TabIndex = 25
        '
        'gbSuppiler
        '
        Me.gbSuppiler.Controls.Add(Me.cboPrintExcept)
        Me.gbSuppiler.Controls.Add(Me.optPrintExcept)
        Me.gbSuppiler.Controls.Add(Me.optPrintOnly)
        Me.gbSuppiler.Controls.Add(Me.optPrintAll)
        Me.gbSuppiler.Controls.Add(Me.cboPrintOnly)
        Me.gbSuppiler.Location = New System.Drawing.Point(293, 521)
        Me.gbSuppiler.Name = "gbSuppiler"
        Me.gbSuppiler.Size = New System.Drawing.Size(343, 96)
        Me.gbSuppiler.TabIndex = 26
        Me.gbSuppiler.TabStop = False
        Me.gbSuppiler.Text = "Supplier"
        '
        'gbReportType
        '
        Me.gbReportType.Controls.Add(Me.optSumDesignAndColorAndSale)
        Me.gbReportType.Controls.Add(Me.optSumDesignAndColorAndGINDate)
        Me.gbReportType.Controls.Add(Me.optSumDesignAndColor)
        Me.gbReportType.Controls.Add(Me.optSumRollDefectWithDesign)
        Me.gbReportType.Controls.Add(Me.optSumRollDefect)
        Me.gbReportType.Controls.Add(Me.optSumDesign)
        Me.gbReportType.Controls.Add(Me.optSumRoll)
        Me.gbReportType.Controls.Add(Me.optDetail)
        Me.gbReportType.Location = New System.Drawing.Point(293, 419)
        Me.gbReportType.Name = "gbReportType"
        Me.gbReportType.Size = New System.Drawing.Size(689, 96)
        Me.gbReportType.TabIndex = 27
        Me.gbReportType.TabStop = False
        Me.gbReportType.Text = "Report Type"
        '
        'optSumDesignAndColorAndSale
        '
        Me.optSumDesignAndColorAndSale.AutoSize = True
        Me.optSumDesignAndColorAndSale.Location = New System.Drawing.Point(387, 73)
        Me.optSumDesignAndColorAndSale.Name = "optSumDesignAndColorAndSale"
        Me.optSumDesignAndColorAndSale.Size = New System.Drawing.Size(266, 17)
        Me.optSumDesignAndColorAndSale.TabIndex = 43
        Me.optSumDesignAndColorAndSale.Text = "Summary By Design And Color And Sale Person"
        Me.optSumDesignAndColorAndSale.UseVisualStyleBackColor = True
        Me.optSumDesignAndColorAndSale.Visible = False
        '
        'optSumDesignAndColorAndGINDate
        '
        Me.optSumDesignAndColorAndGINDate.AutoSize = True
        Me.optSumDesignAndColorAndGINDate.Location = New System.Drawing.Point(387, 54)
        Me.optSumDesignAndColorAndGINDate.Name = "optSumDesignAndColorAndGINDate"
        Me.optSumDesignAndColorAndGINDate.Size = New System.Drawing.Size(255, 17)
        Me.optSumDesignAndColorAndGINDate.TabIndex = 42
        Me.optSumDesignAndColorAndGINDate.Text = "Summary By Design And Color And G IN date"
        Me.optSumDesignAndColorAndGINDate.UseVisualStyleBackColor = True
        '
        'optSumDesignAndColor
        '
        Me.optSumDesignAndColor.AutoSize = True
        Me.optSumDesignAndColor.Location = New System.Drawing.Point(387, 34)
        Me.optSumDesignAndColor.Name = "optSumDesignAndColor"
        Me.optSumDesignAndColor.Size = New System.Drawing.Size(180, 17)
        Me.optSumDesignAndColor.TabIndex = 41
        Me.optSumDesignAndColor.Text = "Summary By Design And Color"
        Me.optSumDesignAndColor.UseVisualStyleBackColor = True
        '
        'optSumRollDefectWithDesign
        '
        Me.optSumRollDefectWithDesign.AutoSize = True
        Me.optSumRollDefectWithDesign.Location = New System.Drawing.Point(88, 34)
        Me.optSumRollDefectWithDesign.Name = "optSumRollDefectWithDesign"
        Me.optSumRollDefectWithDesign.Size = New System.Drawing.Size(242, 17)
        Me.optSumRollDefectWithDesign.TabIndex = 40
        Me.optSumRollDefectWithDesign.Text = "Summary By Roll && Defect (Design Header)"
        Me.optSumRollDefectWithDesign.UseVisualStyleBackColor = True
        '
        'optSumRollDefect
        '
        Me.optSumRollDefect.AutoSize = True
        Me.optSumRollDefect.Checked = True
        Me.optSumRollDefect.Location = New System.Drawing.Point(88, 16)
        Me.optSumRollDefect.Name = "optSumRollDefect"
        Me.optSumRollDefect.Size = New System.Drawing.Size(157, 17)
        Me.optSumRollDefect.TabIndex = 39
        Me.optSumRollDefect.TabStop = True
        Me.optSumRollDefect.Text = "Summary By Roll && Defect"
        Me.optSumRollDefect.UseVisualStyleBackColor = True
        '
        'optSumDesign
        '
        Me.optSumDesign.AutoSize = True
        Me.optSumDesign.Location = New System.Drawing.Point(386, 16)
        Me.optSumDesign.Name = "optSumDesign"
        Me.optSumDesign.Size = New System.Drawing.Size(125, 17)
        Me.optSumDesign.TabIndex = 24
        Me.optSumDesign.Text = "Summary By Design"
        Me.optSumDesign.UseVisualStyleBackColor = True
        '
        'optSumRoll
        '
        Me.optSumRoll.AutoSize = True
        Me.optSumRoll.Location = New System.Drawing.Point(259, 16)
        Me.optSumRoll.Name = "optSumRoll"
        Me.optSumRoll.Size = New System.Drawing.Size(109, 17)
        Me.optSumRoll.TabIndex = 9
        Me.optSumRoll.Text = "Summary By Roll"
        Me.optSumRoll.UseVisualStyleBackColor = True
        '
        'optDetail
        '
        Me.optDetail.AutoSize = True
        Me.optDetail.Location = New System.Drawing.Point(16, 16)
        Me.optDetail.Name = "optDetail"
        Me.optDetail.Size = New System.Drawing.Size(55, 17)
        Me.optDetail.TabIndex = 8
        Me.optDetail.Text = "Detail"
        Me.optDetail.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optStockGamma)
        Me.GroupBox3.Controls.Add(Me.gbGreigeOption)
        Me.GroupBox3.Controls.Add(Me.optStockD)
        Me.GroupBox3.Controls.Add(Me.optStockG)
        Me.GroupBox3.Location = New System.Drawing.Point(293, 286)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 128)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock Type"
        '
        'gbGreigeOption
        '
        Me.gbGreigeOption.Controls.Add(Me.optGreigeAll)
        Me.gbGreigeOption.Controls.Add(Me.optGreigeNonPreset)
        Me.gbGreigeOption.Controls.Add(Me.optGreigePreset)
        Me.gbGreigeOption.Location = New System.Drawing.Point(52, 41)
        Me.gbGreigeOption.Name = "gbGreigeOption"
        Me.gbGreigeOption.Size = New System.Drawing.Size(138, 75)
        Me.gbGreigeOption.TabIndex = 25
        Me.gbGreigeOption.TabStop = False
        Me.gbGreigeOption.Text = "Greige option"
        '
        'optGreigeAll
        '
        Me.optGreigeAll.AutoSize = True
        Me.optGreigeAll.Location = New System.Drawing.Point(24, 55)
        Me.optGreigeAll.Name = "optGreigeAll"
        Me.optGreigeAll.Size = New System.Drawing.Size(38, 17)
        Me.optGreigeAll.TabIndex = 27
        Me.optGreigeAll.Text = "All"
        Me.optGreigeAll.UseVisualStyleBackColor = True
        '
        'optGreigeNonPreset
        '
        Me.optGreigeNonPreset.AutoSize = True
        Me.optGreigeNonPreset.Checked = True
        Me.optGreigeNonPreset.Location = New System.Drawing.Point(24, 35)
        Me.optGreigeNonPreset.Name = "optGreigeNonPreset"
        Me.optGreigeNonPreset.Size = New System.Drawing.Size(107, 17)
        Me.optGreigeNonPreset.TabIndex = 26
        Me.optGreigeNonPreset.TabStop = True
        Me.optGreigeNonPreset.Text = "Non-Preset only"
        Me.optGreigeNonPreset.UseVisualStyleBackColor = True
        '
        'optGreigePreset
        '
        Me.optGreigePreset.AutoSize = True
        Me.optGreigePreset.Location = New System.Drawing.Point(24, 16)
        Me.optGreigePreset.Name = "optGreigePreset"
        Me.optGreigePreset.Size = New System.Drawing.Size(81, 17)
        Me.optGreigePreset.TabIndex = 25
        Me.optGreigePreset.Text = "Preset only"
        Me.optGreigePreset.UseVisualStyleBackColor = True
        '
        'optStockD
        '
        Me.optStockD.AutoSize = True
        Me.optStockD.Location = New System.Drawing.Point(189, 21)
        Me.optStockD.Name = "optStockD"
        Me.optStockD.Size = New System.Drawing.Size(64, 17)
        Me.optStockD.TabIndex = 9
        Me.optStockD.Text = "Stock D"
        Me.optStockD.UseVisualStyleBackColor = True
        '
        'optStockG
        '
        Me.optStockG.AutoSize = True
        Me.optStockG.Checked = True
        Me.optStockG.Location = New System.Drawing.Point(32, 21)
        Me.optStockG.Name = "optStockG"
        Me.optStockG.Size = New System.Drawing.Size(64, 17)
        Me.optStockG.TabIndex = 8
        Me.optStockG.TabStop = True
        Me.optStockG.Text = "Stock G"
        Me.optStockG.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Enter Fin Wth."
        Me.Label1.Visible = False
        '
        'txtFwth
        '
        Me.txtFwth.Location = New System.Drawing.Point(168, 29)
        Me.txtFwth.Name = "txtFwth"
        Me.txtFwth.Size = New System.Drawing.Size(46, 22)
        Me.txtFwth.TabIndex = 30
        Me.txtFwth.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "From"
        '
        'gbOrderFilter
        '
        Me.gbOrderFilter.Controls.Add(Me.optOrderFilterOTHER)
        Me.gbOrderFilter.Controls.Add(Me.optOrderFilterAll)
        Me.gbOrderFilter.Controls.Add(Me.optOrderFilterMTO)
        Me.gbOrderFilter.Controls.Add(Me.optOrderFilterMTS)
        Me.gbOrderFilter.Controls.Add(Me.optOrderFilterDevl)
        Me.gbOrderFilter.Location = New System.Drawing.Point(293, 120)
        Me.gbOrderFilter.Name = "gbOrderFilter"
        Me.gbOrderFilter.Size = New System.Drawing.Size(315, 159)
        Me.gbOrderFilter.TabIndex = 35
        Me.gbOrderFilter.TabStop = False
        Me.gbOrderFilter.Text = "Order filter"
        '
        'optOrderFilterOTHER
        '
        Me.optOrderFilterOTHER.AutoSize = True
        Me.optOrderFilterOTHER.Location = New System.Drawing.Point(30, 126)
        Me.optOrderFilterOTHER.Name = "optOrderFilterOTHER"
        Me.optOrderFilterOTHER.Size = New System.Drawing.Size(114, 17)
        Me.optOrderFilterOTHER.TabIndex = 30
        Me.optOrderFilterOTHER.Text = "Show Only Other"
        Me.optOrderFilterOTHER.UseVisualStyleBackColor = True
        '
        'optOrderFilterAll
        '
        Me.optOrderFilterAll.AutoSize = True
        Me.optOrderFilterAll.Checked = True
        Me.optOrderFilterAll.Location = New System.Drawing.Point(30, 26)
        Me.optOrderFilterAll.Name = "optOrderFilterAll"
        Me.optOrderFilterAll.Size = New System.Drawing.Size(73, 17)
        Me.optOrderFilterAll.TabIndex = 29
        Me.optOrderFilterAll.TabStop = True
        Me.optOrderFilterAll.Text = "Show All "
        Me.optOrderFilterAll.UseVisualStyleBackColor = True
        '
        'optOrderFilterMTO
        '
        Me.optOrderFilterMTO.AutoSize = True
        Me.optOrderFilterMTO.Location = New System.Drawing.Point(30, 101)
        Me.optOrderFilterMTO.Name = "optOrderFilterMTO"
        Me.optOrderFilterMTO.Size = New System.Drawing.Size(159, 17)
        Me.optOrderFilterMTO.TabIndex = 28
        Me.optOrderFilterMTO.Text = "Show Only Make-to-order"
        Me.optOrderFilterMTO.UseVisualStyleBackColor = True
        '
        'optOrderFilterMTS
        '
        Me.optOrderFilterMTS.AutoSize = True
        Me.optOrderFilterMTS.Location = New System.Drawing.Point(30, 76)
        Me.optOrderFilterMTS.Name = "optOrderFilterMTS"
        Me.optOrderFilterMTS.Size = New System.Drawing.Size(158, 17)
        Me.optOrderFilterMTS.TabIndex = 27
        Me.optOrderFilterMTS.Text = "Show Only Make-to-stock"
        Me.optOrderFilterMTS.UseVisualStyleBackColor = True
        '
        'optOrderFilterDevl
        '
        Me.optOrderFilterDevl.AutoSize = True
        Me.optOrderFilterDevl.Location = New System.Drawing.Point(30, 51)
        Me.optOrderFilterDevl.Name = "optOrderFilterDevl"
        Me.optOrderFilterDevl.Size = New System.Drawing.Size(149, 17)
        Me.optOrderFilterDevl.TabIndex = 26
        Me.optOrderFilterDevl.Text = "Show Only Devl, Sample"
        Me.optOrderFilterDevl.UseVisualStyleBackColor = True
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(107, 48)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(137, 21)
        Me.cbomtl_subinventory.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.cbomtl_subinventory, "ex. SAMPLE ROOM")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Sub inventory"
        '
        'lblmtl_warehourse
        '
        Me.lblmtl_warehourse.AutoSize = True
        Me.lblmtl_warehourse.Location = New System.Drawing.Point(31, 22)
        Me.lblmtl_warehourse.Name = "lblmtl_warehourse"
        Me.lblmtl_warehourse.Size = New System.Drawing.Size(70, 13)
        Me.lblmtl_warehourse.TabIndex = 47
        Me.lblmtl_warehourse.Text = "Warehourse"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(106, 22)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(138, 21)
        Me.cbomtl_warehouse.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.cbomtl_warehouse, "ex. ESH,GMK,GMK3,GMK4...")
        '
        'dtpDateFr
        '
        Me.dtpDateFr.Checked = False
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(51, 19)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.ShowCheckBox = True
        Me.dtpDateFr.Size = New System.Drawing.Size(103, 22)
        Me.dtpDateFr.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "To"
        '
        'gbStockReceviedDate
        '
        Me.gbStockReceviedDate.Controls.Add(Me.dtpStockYearFr)
        Me.gbStockReceviedDate.Controls.Add(Me.dtpStockYearTo)
        Me.gbStockReceviedDate.Controls.Add(Me.Label8)
        Me.gbStockReceviedDate.Controls.Add(Me.Label9)
        Me.gbStockReceviedDate.Controls.Add(Me.dtpDateFr)
        Me.gbStockReceviedDate.Controls.Add(Me.dtpDateTo)
        Me.gbStockReceviedDate.Controls.Add(Me.Label2)
        Me.gbStockReceviedDate.Controls.Add(Me.Label4)
        Me.gbStockReceviedDate.Location = New System.Drawing.Point(293, 46)
        Me.gbStockReceviedDate.Name = "gbStockReceviedDate"
        Me.gbStockReceviedDate.Size = New System.Drawing.Size(315, 70)
        Me.gbStockReceviedDate.TabIndex = 55
        Me.gbStockReceviedDate.TabStop = False
        Me.gbStockReceviedDate.Text = "Stock Recevied Date"
        '
        'dtpStockYearFr
        '
        Me.dtpStockYearFr.Checked = False
        Me.dtpStockYearFr.CustomFormat = "yyyy"
        Me.dtpStockYearFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStockYearFr.Location = New System.Drawing.Point(51, 44)
        Me.dtpStockYearFr.Name = "dtpStockYearFr"
        Me.dtpStockYearFr.ShowCheckBox = True
        Me.dtpStockYearFr.ShowUpDown = True
        Me.dtpStockYearFr.Size = New System.Drawing.Size(103, 22)
        Me.dtpStockYearFr.TabIndex = 56
        '
        'dtpStockYearTo
        '
        Me.dtpStockYearTo.Checked = False
        Me.dtpStockYearTo.CustomFormat = "yyyy"
        Me.dtpStockYearTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStockYearTo.Location = New System.Drawing.Point(201, 44)
        Me.dtpStockYearTo.Name = "dtpStockYearTo"
        Me.dtpStockYearTo.ShowCheckBox = True
        Me.dtpStockYearTo.ShowUpDown = True
        Me.dtpStockYearTo.Size = New System.Drawing.Size(103, 22)
        Me.dtpStockYearTo.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(175, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "To"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Age"
        '
        'txtGradePrintOnly
        '
        Me.txtGradePrintOnly.Location = New System.Drawing.Point(147, 36)
        Me.txtGradePrintOnly.Name = "txtGradePrintOnly"
        Me.txtGradePrintOnly.Size = New System.Drawing.Size(87, 22)
        Me.txtGradePrintOnly.TabIndex = 173
        Me.ToolTip1.SetToolTip(Me.txtGradePrintOnly, "ใส่ เกรดที่ต้องการ ถ้ามีมากกว่า 1 ให้ใส่ลูกน้ำตามด้วย เกรดอื่น เช่น ex. A,B,C..")
        '
        'txtGradePrintExcept
        '
        Me.txtGradePrintExcept.Location = New System.Drawing.Point(147, 59)
        Me.txtGradePrintExcept.Name = "txtGradePrintExcept"
        Me.txtGradePrintExcept.Size = New System.Drawing.Size(87, 22)
        Me.txtGradePrintExcept.TabIndex = 175
        Me.ToolTip1.SetToolTip(Me.txtGradePrintExcept, "ใส่ เกรดที่ต้องการ ถ้ามีมากกว่า 1 ให้ใส่ลูกน้ำตามด้วย เกรดอื่น เช่น ex. A,B,C..")
        '
        'gbStockLocations
        '
        Me.gbStockLocations.Controls.Add(Me.cboNewmtl_locations_id)
        Me.gbStockLocations.Controls.Add(Me.cbomtl_warehouse)
        Me.gbStockLocations.Controls.Add(Me.Label7)
        Me.gbStockLocations.Controls.Add(Me.cbomtl_subinventory)
        Me.gbStockLocations.Controls.Add(Me.txtLocation)
        Me.gbStockLocations.Controls.Add(Me.Label6)
        Me.gbStockLocations.Controls.Add(Me.lblmtl_warehourse)
        Me.gbStockLocations.Location = New System.Drawing.Point(614, 120)
        Me.gbStockLocations.Name = "gbStockLocations"
        Me.gbStockLocations.Size = New System.Drawing.Size(368, 159)
        Me.gbStockLocations.TabIndex = 56
        Me.gbStockLocations.TabStop = False
        Me.gbStockLocations.Text = "Filter for Stock"
        '
        'cboNewmtl_locations_id
        '
        Me.cboNewmtl_locations_id.FormattingEnabled = True
        Me.cboNewmtl_locations_id.Location = New System.Drawing.Point(106, 74)
        Me.cboNewmtl_locations_id.Name = "cboNewmtl_locations_id"
        Me.cboNewmtl_locations_id.Size = New System.Drawing.Size(140, 21)
        Me.cboNewmtl_locations_id.TabIndex = 52
        '
        'gbCustomer
        '
        Me.gbCustomer.Controls.Add(Me.cboCustPrintExcept)
        Me.gbCustomer.Controls.Add(Me.optCustPrintExcept)
        Me.gbCustomer.Controls.Add(Me.optCustPrintOnly)
        Me.gbCustomer.Controls.Add(Me.optCustPrintAll)
        Me.gbCustomer.Controls.Add(Me.cboCustPrintOnly)
        Me.gbCustomer.Location = New System.Drawing.Point(675, 521)
        Me.gbCustomer.Name = "gbCustomer"
        Me.gbCustomer.Size = New System.Drawing.Size(307, 96)
        Me.gbCustomer.TabIndex = 57
        Me.gbCustomer.TabStop = False
        Me.gbCustomer.Text = "Customer"
        '
        'cboCustPrintExcept
        '
        Me.cboCustPrintExcept.FormattingEnabled = True
        Me.cboCustPrintExcept.Location = New System.Drawing.Point(116, 64)
        Me.cboCustPrintExcept.Name = "cboCustPrintExcept"
        Me.cboCustPrintExcept.Size = New System.Drawing.Size(139, 21)
        Me.cboCustPrintExcept.TabIndex = 25
        '
        'optCustPrintExcept
        '
        Me.optCustPrintExcept.AutoSize = True
        Me.optCustPrintExcept.Location = New System.Drawing.Point(20, 64)
        Me.optCustPrintExcept.Name = "optCustPrintExcept"
        Me.optCustPrintExcept.Size = New System.Drawing.Size(85, 17)
        Me.optCustPrintExcept.TabIndex = 24
        Me.optCustPrintExcept.Text = "Print Except"
        Me.optCustPrintExcept.UseVisualStyleBackColor = True
        '
        'optCustPrintOnly
        '
        Me.optCustPrintOnly.AutoSize = True
        Me.optCustPrintOnly.Location = New System.Drawing.Point(20, 40)
        Me.optCustPrintOnly.Name = "optCustPrintOnly"
        Me.optCustPrintOnly.Size = New System.Drawing.Size(76, 17)
        Me.optCustPrintOnly.TabIndex = 9
        Me.optCustPrintOnly.Text = "Print Only"
        Me.optCustPrintOnly.UseVisualStyleBackColor = True
        '
        'optCustPrintAll
        '
        Me.optCustPrintAll.AutoSize = True
        Me.optCustPrintAll.Checked = True
        Me.optCustPrintAll.Location = New System.Drawing.Point(20, 16)
        Me.optCustPrintAll.Name = "optCustPrintAll"
        Me.optCustPrintAll.Size = New System.Drawing.Size(65, 17)
        Me.optCustPrintAll.TabIndex = 8
        Me.optCustPrintAll.TabStop = True
        Me.optCustPrintAll.Text = "Print All"
        Me.optCustPrintAll.UseVisualStyleBackColor = True
        '
        'cboCustPrintOnly
        '
        Me.cboCustPrintOnly.FormattingEnabled = True
        Me.cboCustPrintOnly.Location = New System.Drawing.Point(116, 40)
        Me.cboCustPrintOnly.Name = "cboCustPrintOnly"
        Me.cboCustPrintOnly.Size = New System.Drawing.Size(139, 21)
        Me.cboCustPrintOnly.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGradePrintOnly)
        Me.GroupBox1.Controls.Add(Me.optPrintGradeOnly2)
        Me.GroupBox1.Controls.Add(Me.optPrintGradeExcept2)
        Me.GroupBox1.Controls.Add(Me.txtGradePrintExcept)
        Me.GroupBox1.Controls.Add(Me.optPrintGradeExcept)
        Me.GroupBox1.Controls.Add(Me.optPrintGradeOnly)
        Me.GroupBox1.Controls.Add(Me.optPrintGradeAll)
        Me.GroupBox1.Location = New System.Drawing.Point(720, 286)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(262, 128)
        Me.GroupBox1.TabIndex = 184
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grade Option"
        '
        'optPrintGradeOnly2
        '
        Me.optPrintGradeOnly2.AutoSize = True
        Me.optPrintGradeOnly2.Location = New System.Drawing.Point(15, 82)
        Me.optPrintGradeOnly2.Name = "optPrintGradeOnly2"
        Me.optPrintGradeOnly2.Size = New System.Drawing.Size(114, 17)
        Me.optPrintGradeOnly2.TabIndex = 177
        Me.optPrintGradeOnly2.Text = "Print Only (2P,2G)"
        Me.optPrintGradeOnly2.UseVisualStyleBackColor = True
        '
        'optPrintGradeExcept2
        '
        Me.optPrintGradeExcept2.AutoSize = True
        Me.optPrintGradeExcept2.Location = New System.Drawing.Point(15, 105)
        Me.optPrintGradeExcept2.Name = "optPrintGradeExcept2"
        Me.optPrintGradeExcept2.Size = New System.Drawing.Size(123, 17)
        Me.optPrintGradeExcept2.TabIndex = 176
        Me.optPrintGradeExcept2.Text = "Print Except (2P,2G)"
        Me.optPrintGradeExcept2.UseVisualStyleBackColor = True
        '
        'optPrintGradeExcept
        '
        Me.optPrintGradeExcept.AutoSize = True
        Me.optPrintGradeExcept.Location = New System.Drawing.Point(15, 60)
        Me.optPrintGradeExcept.Name = "optPrintGradeExcept"
        Me.optPrintGradeExcept.Size = New System.Drawing.Size(85, 17)
        Me.optPrintGradeExcept.TabIndex = 27
        Me.optPrintGradeExcept.Text = "Print Except"
        Me.optPrintGradeExcept.UseVisualStyleBackColor = True
        '
        'optPrintGradeOnly
        '
        Me.optPrintGradeOnly.AutoSize = True
        Me.optPrintGradeOnly.Location = New System.Drawing.Point(15, 37)
        Me.optPrintGradeOnly.Name = "optPrintGradeOnly"
        Me.optPrintGradeOnly.Size = New System.Drawing.Size(76, 17)
        Me.optPrintGradeOnly.TabIndex = 26
        Me.optPrintGradeOnly.Text = "Print Only"
        Me.optPrintGradeOnly.UseVisualStyleBackColor = True
        '
        'optPrintGradeAll
        '
        Me.optPrintGradeAll.AutoSize = True
        Me.optPrintGradeAll.Checked = True
        Me.optPrintGradeAll.Location = New System.Drawing.Point(15, 15)
        Me.optPrintGradeAll.Name = "optPrintGradeAll"
        Me.optPrintGradeAll.Size = New System.Drawing.Size(65, 17)
        Me.optPrintGradeAll.TabIndex = 25
        Me.optPrintGradeAll.TabStop = True
        Me.optPrintGradeAll.Text = "Print All"
        Me.optPrintGradeAll.UseVisualStyleBackColor = True
        '
        'optStockGamma
        '
        Me.optStockGamma.AutoSize = True
        Me.optStockGamma.Location = New System.Drawing.Point(291, 21)
        Me.optStockGamma.Name = "optStockGamma"
        Me.optStockGamma.Size = New System.Drawing.Size(117, 17)
        Me.optStockGamma.TabIndex = 28
        Me.optStockGamma.Text = "Stock FG (Gamma)"
        Me.optStockGamma.UseVisualStyleBackColor = True
        '
        'frmStockOnhand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 623)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbCustomer)
        Me.Controls.Add(Me.gbStockLocations)
        Me.Controls.Add(Me.gbStockReceviedDate)
        Me.Controls.Add(Me.gbOrderFilter)
        Me.Controls.Add(Me.txtFwth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbReportType)
        Me.Controls.Add(Me.gbSuppiler)
        Me.Controls.Add(Me.grdDesignNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmStockOnhand"
        Me.Text = "Stock Onhand"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDesignNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSuppiler.ResumeLayout(False)
        Me.gbSuppiler.PerformLayout()
        Me.gbReportType.ResumeLayout(False)
        Me.gbReportType.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbGreigeOption.ResumeLayout(False)
        Me.gbGreigeOption.PerformLayout()
        Me.gbOrderFilter.ResumeLayout(False)
        Me.gbOrderFilter.PerformLayout()
        Me.gbStockReceviedDate.ResumeLayout(False)
        Me.gbStockReceviedDate.PerformLayout()
        Me.gbStockLocations.ResumeLayout(False)
        Me.gbStockLocations.PerformLayout()
        Me.gbCustomer.ResumeLayout(False)
        Me.gbCustomer.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents optPrintOnly As System.Windows.Forms.RadioButton
    Friend WithEvents optPrintAll As System.Windows.Forms.RadioButton
    Friend WithEvents cboPrintOnly As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grdDesignNo As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents optPrintExcept As System.Windows.Forms.RadioButton
    Friend WithEvents cboPrintExcept As System.Windows.Forms.ComboBox
    Friend WithEvents gbSuppiler As System.Windows.Forms.GroupBox
    Friend WithEvents gbReportType As System.Windows.Forms.GroupBox
    Friend WithEvents optSumDesign As System.Windows.Forms.RadioButton
    Friend WithEvents optSumRoll As System.Windows.Forms.RadioButton
    Friend WithEvents optDetail As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optStockD As System.Windows.Forms.RadioButton
    Friend WithEvents optStockG As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFwth As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbOrderFilter As System.Windows.Forms.GroupBox
    Friend WithEvents optOrderFilterAll As System.Windows.Forms.RadioButton
    Friend WithEvents optOrderFilterMTO As System.Windows.Forms.RadioButton
    Friend WithEvents optOrderFilterMTS As System.Windows.Forms.RadioButton
    Friend WithEvents optOrderFilterDevl As System.Windows.Forms.RadioButton
    Friend WithEvents gbGreigeOption As System.Windows.Forms.GroupBox
    Friend WithEvents optGreigeAll As System.Windows.Forms.RadioButton
    Friend WithEvents optGreigeNonPreset As System.Windows.Forms.RadioButton
    Friend WithEvents optGreigePreset As System.Windows.Forms.RadioButton
    Friend WithEvents optSumRollDefect As System.Windows.Forms.RadioButton
    Friend WithEvents optOrderFilterOTHER As System.Windows.Forms.RadioButton
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblmtl_warehourse As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateFr As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents gbStockReceviedDate As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents gbStockLocations As GroupBox
    Friend WithEvents optSumRollDefectWithDesign As RadioButton
    Friend WithEvents optSumDesignAndColor As RadioButton
    Friend WithEvents cboNewmtl_locations_id As ComboBox
    Friend WithEvents dtpStockYearFr As DateTimePicker
    Friend WithEvents dtpStockYearTo As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents gbCustomer As GroupBox
    Friend WithEvents cboCustPrintExcept As ComboBox
    Friend WithEvents optCustPrintExcept As RadioButton
    Friend WithEvents optCustPrintOnly As RadioButton
    Friend WithEvents optCustPrintAll As RadioButton
    Friend WithEvents cboCustPrintOnly As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtGradePrintOnly As TextBox
    Friend WithEvents optPrintGradeOnly2 As RadioButton
    Friend WithEvents optPrintGradeExcept2 As RadioButton
    Friend WithEvents txtGradePrintExcept As TextBox
    Friend WithEvents optPrintGradeExcept As RadioButton
    Friend WithEvents optPrintGradeOnly As RadioButton
    Friend WithEvents optPrintGradeAll As RadioButton
    Friend WithEvents optSumDesignAndColorAndGINDate As RadioButton
    Friend WithEvents optSumDesignAndColorAndSale As RadioButton
    Friend WithEvents optStockGamma As RadioButton
End Class
