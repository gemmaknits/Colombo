<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductionPending
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionPending))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFindArticleKnitting = New System.Windows.Forms.Button()
        Me.btnPrnStockDesignBobins = New System.Windows.Forms.Button()
        Me.btnPrnStockDesignBeam = New System.Windows.Forms.Button()
        Me.btnFindDesignBobins = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnFindDesignBeam = New System.Windows.Forms.Button()
        Me.dtpWOEndDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpWOEndDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtpWOStartDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpWOStartDateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpKODtFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpKODtTo = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboMC = New System.Windows.Forms.ComboBox()
        Me.txtDesignBobins = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtArticleKnitting = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKINo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSONo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesignBeamDesc = New System.Windows.Forms.TextBox()
        Me.txtDesignBeam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtKONoTo = New System.Windows.Forms.TextBox()
        Me.txtKONoFrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbPendingKoStatus = New System.Windows.Forms.RadioButton()
        Me.rbOpenKoStatus = New System.Windows.Forms.RadioButton()
        Me.rbAllKoStatus = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbClosedKoStatus = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rbNonCancelKo = New System.Windows.Forms.RadioButton()
        Me.rbCancelKo = New System.Windows.Forms.RadioButton()
        Me.rbAllKoCancel = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cboSortBy = New System.Windows.Forms.ComboBox()
        Me.txtDesignBeamDescp = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(597, 25)
        Me.ToolStrip1.TabIndex = 34
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtDesignBeamDescp)
        Me.GroupBox1.Controls.Add(Me.btnFindArticleKnitting)
        Me.GroupBox1.Controls.Add(Me.btnPrnStockDesignBobins)
        Me.GroupBox1.Controls.Add(Me.btnPrnStockDesignBeam)
        Me.GroupBox1.Controls.Add(Me.btnFindDesignBobins)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.btnFindDesignBeam)
        Me.GroupBox1.Controls.Add(Me.dtpWOEndDateFrom)
        Me.GroupBox1.Controls.Add(Me.dtpWOEndDateTo)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.dtpWOStartDateFrom)
        Me.GroupBox1.Controls.Add(Me.dtpWOStartDateTo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.dtpKODtFrom)
        Me.GroupBox1.Controls.Add(Me.dtpKODtTo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboMC)
        Me.GroupBox1.Controls.Add(Me.txtDesignBobins)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtArticleKnitting)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtKINo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtSONo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDesignBeamDesc)
        Me.GroupBox1.Controls.Add(Me.txtDesignBeam)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtKONoTo)
        Me.GroupBox1.Controls.Add(Me.txtKONoFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 393)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condition"
        '
        'btnFindArticleKnitting
        '
        Me.btnFindArticleKnitting.Image = Global.ProductionSystem.My.Resources.Resources.Search_16x
        Me.btnFindArticleKnitting.Location = New System.Drawing.Point(268, 248)
        Me.btnFindArticleKnitting.Name = "btnFindArticleKnitting"
        Me.btnFindArticleKnitting.Size = New System.Drawing.Size(23, 21)
        Me.btnFindArticleKnitting.TabIndex = 52
        Me.btnFindArticleKnitting.UseVisualStyleBackColor = True
        '
        'btnPrnStockDesignBobins
        '
        Me.btnPrnStockDesignBobins.BackgroundImage = Global.ProductionSystem.My.Resources.Resources.btnPrint
        Me.btnPrnStockDesignBobins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrnStockDesignBobins.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrnStockDesignBobins.Location = New System.Drawing.Point(540, 178)
        Me.btnPrnStockDesignBobins.Name = "btnPrnStockDesignBobins"
        Me.btnPrnStockDesignBobins.Size = New System.Drawing.Size(23, 21)
        Me.btnPrnStockDesignBobins.TabIndex = 51
        Me.btnPrnStockDesignBobins.UseVisualStyleBackColor = True
        '
        'btnPrnStockDesignBeam
        '
        Me.btnPrnStockDesignBeam.BackgroundImage = Global.ProductionSystem.My.Resources.Resources.btnPrint
        Me.btnPrnStockDesignBeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrnStockDesignBeam.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrnStockDesignBeam.Location = New System.Drawing.Point(540, 133)
        Me.btnPrnStockDesignBeam.Name = "btnPrnStockDesignBeam"
        Me.btnPrnStockDesignBeam.Size = New System.Drawing.Size(23, 21)
        Me.btnPrnStockDesignBeam.TabIndex = 50
        Me.btnPrnStockDesignBeam.UseVisualStyleBackColor = True
        '
        'btnFindDesignBobins
        '
        Me.btnFindDesignBobins.Image = Global.ProductionSystem.My.Resources.Resources.Search_16x
        Me.btnFindDesignBobins.Location = New System.Drawing.Point(268, 179)
        Me.btnFindDesignBobins.Name = "btnFindDesignBobins"
        Me.btnFindDesignBobins.Size = New System.Drawing.Size(23, 21)
        Me.btnFindDesignBobins.TabIndex = 49
        Me.btnFindDesignBobins.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(294, 179)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(243, 20)
        Me.TextBox1.TabIndex = 48
        '
        'btnFindDesignBeam
        '
        Me.btnFindDesignBeam.Image = Global.ProductionSystem.My.Resources.Resources.Search_16x
        Me.btnFindDesignBeam.Location = New System.Drawing.Point(268, 133)
        Me.btnFindDesignBeam.Name = "btnFindDesignBeam"
        Me.btnFindDesignBeam.Size = New System.Drawing.Size(23, 21)
        Me.btnFindDesignBeam.TabIndex = 47
        Me.btnFindDesignBeam.UseVisualStyleBackColor = True
        '
        'dtpWOEndDateFrom
        '
        Me.dtpWOEndDateFrom.Checked = False
        Me.dtpWOEndDateFrom.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWOEndDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpWOEndDateFrom.Location = New System.Drawing.Point(179, 63)
        Me.dtpWOEndDateFrom.Name = "dtpWOEndDateFrom"
        Me.dtpWOEndDateFrom.ShowCheckBox = True
        Me.dtpWOEndDateFrom.Size = New System.Drawing.Size(99, 20)
        Me.dtpWOEndDateFrom.TabIndex = 46
        '
        'dtpWOEndDateTo
        '
        Me.dtpWOEndDateTo.Checked = False
        Me.dtpWOEndDateTo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWOEndDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpWOEndDateTo.Location = New System.Drawing.Point(329, 63)
        Me.dtpWOEndDateTo.Name = "dtpWOEndDateTo"
        Me.dtpWOEndDateTo.ShowCheckBox = True
        Me.dtpWOEndDateTo.Size = New System.Drawing.Size(102, 20)
        Me.dtpWOEndDateTo.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(303, 66)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "To"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(143, 66)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 13)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "From"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(42, 66)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 13)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "WO End Date"
        '
        'dtpWOStartDateFrom
        '
        Me.dtpWOStartDateFrom.Checked = False
        Me.dtpWOStartDateFrom.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWOStartDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpWOStartDateFrom.Location = New System.Drawing.Point(179, 40)
        Me.dtpWOStartDateFrom.Name = "dtpWOStartDateFrom"
        Me.dtpWOStartDateFrom.ShowCheckBox = True
        Me.dtpWOStartDateFrom.Size = New System.Drawing.Size(99, 20)
        Me.dtpWOStartDateFrom.TabIndex = 41
        '
        'dtpWOStartDateTo
        '
        Me.dtpWOStartDateTo.Checked = False
        Me.dtpWOStartDateTo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpWOStartDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpWOStartDateTo.Location = New System.Drawing.Point(329, 40)
        Me.dtpWOStartDateTo.Name = "dtpWOStartDateTo"
        Me.dtpWOStartDateTo.ShowCheckBox = True
        Me.dtpWOStartDateTo.Size = New System.Drawing.Size(102, 20)
        Me.dtpWOStartDateTo.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(303, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 13)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "To"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(143, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 13)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "From"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(42, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "WO Start Date"
        '
        'dtpKODtFrom
        '
        Me.dtpKODtFrom.Checked = False
        Me.dtpKODtFrom.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpKODtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpKODtFrom.Location = New System.Drawing.Point(179, 17)
        Me.dtpKODtFrom.Name = "dtpKODtFrom"
        Me.dtpKODtFrom.ShowCheckBox = True
        Me.dtpKODtFrom.Size = New System.Drawing.Size(99, 20)
        Me.dtpKODtFrom.TabIndex = 27
        '
        'dtpKODtTo
        '
        Me.dtpKODtTo.Checked = False
        Me.dtpKODtTo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpKODtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpKODtTo.Location = New System.Drawing.Point(329, 17)
        Me.dtpKODtTo.Name = "dtpKODtTo"
        Me.dtpKODtTo.ShowCheckBox = True
        Me.dtpKODtTo.Size = New System.Drawing.Size(102, 20)
        Me.dtpKODtTo.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(303, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "To"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(143, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "From"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(42, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "WO Date"
        '
        'cboMC
        '
        Me.cboMC.FormattingEnabled = True
        Me.cboMC.Location = New System.Drawing.Point(179, 110)
        Me.cboMC.Name = "cboMC"
        Me.cboMC.Size = New System.Drawing.Size(86, 21)
        Me.cboMC.TabIndex = 21
        '
        'txtDesignBobins
        '
        Me.txtDesignBobins.Location = New System.Drawing.Point(179, 179)
        Me.txtDesignBobins.Name = "txtDesignBobins"
        Me.txtDesignBobins.Size = New System.Drawing.Size(86, 20)
        Me.txtDesignBobins.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Design Bobins"
        '
        'txtArticleKnitting
        '
        Me.txtArticleKnitting.Location = New System.Drawing.Point(179, 248)
        Me.txtArticleKnitting.Name = "txtArticleKnitting"
        Me.txtArticleKnitting.Size = New System.Drawing.Size(86, 20)
        Me.txtArticleKnitting.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Article Knitting"
        '
        'txtKINo
        '
        Me.txtKINo.Location = New System.Drawing.Point(179, 225)
        Me.txtKINo.Name = "txtKINo"
        Me.txtKINo.Size = New System.Drawing.Size(86, 20)
        Me.txtKINo.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "KI No (Knitting)"
        '
        'txtSONo
        '
        Me.txtSONo.Location = New System.Drawing.Point(179, 202)
        Me.txtSONo.Name = "txtSONo"
        Me.txtSONo.Size = New System.Drawing.Size(86, 20)
        Me.txtSONo.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "SO No."
        '
        'txtDesignBeamDesc
        '
        Me.txtDesignBeamDesc.Location = New System.Drawing.Point(294, 133)
        Me.txtDesignBeamDesc.Name = "txtDesignBeamDesc"
        Me.txtDesignBeamDesc.ReadOnly = True
        Me.txtDesignBeamDesc.Size = New System.Drawing.Size(243, 20)
        Me.txtDesignBeamDesc.TabIndex = 8
        '
        'txtDesignBeam
        '
        Me.txtDesignBeam.Location = New System.Drawing.Point(179, 133)
        Me.txtDesignBeam.Name = "txtDesignBeam"
        Me.txtDesignBeam.Size = New System.Drawing.Size(86, 20)
        Me.txtDesignBeam.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Design Beam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "M/C"
        '
        'txtKONoTo
        '
        Me.txtKONoTo.Location = New System.Drawing.Point(329, 86)
        Me.txtKONoTo.Name = "txtKONoTo"
        Me.txtKONoTo.Size = New System.Drawing.Size(86, 20)
        Me.txtKONoTo.TabIndex = 4
        '
        'txtKONoFrom
        '
        Me.txtKONoFrom.Location = New System.Drawing.Point(179, 86)
        Me.txtKONoFrom.Name = "txtKONoFrom"
        Me.txtKONoFrom.Size = New System.Drawing.Size(86, 20)
        Me.txtKONoFrom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "From"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WO No."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbPendingKoStatus)
        Me.GroupBox2.Controls.Add(Me.rbOpenKoStatus)
        Me.GroupBox2.Controls.Add(Me.rbAllKoStatus)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.rbClosedKoStatus)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 268)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 38)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        '
        'rbPendingKoStatus
        '
        Me.rbPendingKoStatus.AutoSize = True
        Me.rbPendingKoStatus.Location = New System.Drawing.Point(325, 13)
        Me.rbPendingKoStatus.Name = "rbPendingKoStatus"
        Me.rbPendingKoStatus.Size = New System.Drawing.Size(64, 17)
        Me.rbPendingKoStatus.TabIndex = 19
        Me.rbPendingKoStatus.Text = "Pending"
        Me.rbPendingKoStatus.UseVisualStyleBackColor = True
        '
        'rbOpenKoStatus
        '
        Me.rbOpenKoStatus.AutoSize = True
        Me.rbOpenKoStatus.Checked = True
        Me.rbOpenKoStatus.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.rbOpenKoStatus.Location = New System.Drawing.Point(233, 13)
        Me.rbOpenKoStatus.Name = "rbOpenKoStatus"
        Me.rbOpenKoStatus.Size = New System.Drawing.Size(51, 17)
        Me.rbOpenKoStatus.TabIndex = 17
        Me.rbOpenKoStatus.TabStop = True
        Me.rbOpenKoStatus.Text = "Open"
        Me.rbOpenKoStatus.UseVisualStyleBackColor = True
        '
        'rbAllKoStatus
        '
        Me.rbAllKoStatus.AutoSize = True
        Me.rbAllKoStatus.Location = New System.Drawing.Point(146, 13)
        Me.rbAllKoStatus.Name = "rbAllKoStatus"
        Me.rbAllKoStatus.Size = New System.Drawing.Size(36, 17)
        Me.rbAllKoStatus.TabIndex = 16
        Me.rbAllKoStatus.Text = "All"
        Me.rbAllKoStatus.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "KO Status"
        '
        'rbClosedKoStatus
        '
        Me.rbClosedKoStatus.AutoSize = True
        Me.rbClosedKoStatus.Location = New System.Drawing.Point(431, 13)
        Me.rbClosedKoStatus.Name = "rbClosedKoStatus"
        Me.rbClosedKoStatus.Size = New System.Drawing.Size(57, 17)
        Me.rbClosedKoStatus.TabIndex = 18
        Me.rbClosedKoStatus.Text = "Closed"
        Me.rbClosedKoStatus.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.rbNonCancelKo)
        Me.GroupBox3.Controls.Add(Me.rbCancelKo)
        Me.GroupBox3.Controls.Add(Me.rbAllKoCancel)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(516, 38)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "KO Cancel"
        '
        'rbNonCancelKo
        '
        Me.rbNonCancelKo.AutoSize = True
        Me.rbNonCancelKo.Checked = True
        Me.rbNonCancelKo.Location = New System.Drawing.Point(373, 14)
        Me.rbNonCancelKo.Name = "rbNonCancelKo"
        Me.rbNonCancelKo.Size = New System.Drawing.Size(81, 17)
        Me.rbNonCancelKo.TabIndex = 31
        Me.rbNonCancelKo.TabStop = True
        Me.rbNonCancelKo.Text = "Non Cancel"
        Me.rbNonCancelKo.UseVisualStyleBackColor = True
        '
        'rbCancelKo
        '
        Me.rbCancelKo.AutoSize = True
        Me.rbCancelKo.Location = New System.Drawing.Point(255, 14)
        Me.rbCancelKo.Name = "rbCancelKo"
        Me.rbCancelKo.Size = New System.Drawing.Size(58, 17)
        Me.rbCancelKo.TabIndex = 30
        Me.rbCancelKo.Text = "Cancel"
        Me.rbCancelKo.UseVisualStyleBackColor = True
        '
        'rbAllKoCancel
        '
        Me.rbAllKoCancel.AutoSize = True
        Me.rbAllKoCancel.Location = New System.Drawing.Point(146, 14)
        Me.rbAllKoCancel.Name = "rbAllKoCancel"
        Me.rbAllKoCancel.Size = New System.Drawing.Size(36, 17)
        Me.rbAllKoCancel.TabIndex = 29
        Me.rbAllKoCancel.Text = "All"
        Me.rbAllKoCancel.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.cboSortBy)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 340)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(516, 46)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Sort By"
        '
        'cboSortBy
        '
        Me.cboSortBy.FormattingEnabled = True
        Me.cboSortBy.Location = New System.Drawing.Point(143, 16)
        Me.cboSortBy.Name = "cboSortBy"
        Me.cboSortBy.Size = New System.Drawing.Size(280, 21)
        Me.cboSortBy.TabIndex = 0
        '
        'txtDesignBeamDescp
        '
        Me.txtDesignBeamDescp.Location = New System.Drawing.Point(179, 156)
        Me.txtDesignBeamDescp.Name = "txtDesignBeamDescp"
        Me.txtDesignBeamDescp.Size = New System.Drawing.Size(358, 20)
        Me.txtDesignBeamDescp.TabIndex = 54
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(42, 159)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 13)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Design Beam Descp"
        '
        'frmProductionPending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 428)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmProductionPending"
        Me.Text = "Production Pending"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtKINo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSONo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDesignBeam As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtKONoTo As TextBox
    Friend WithEvents txtKONoFrom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbClosedKoStatus As RadioButton
    Friend WithEvents rbOpenKoStatus As RadioButton
    Friend WithEvents rbAllKoStatus As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents txtArticleKnitting As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDesignBobins As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboMC As ComboBox
    Friend WithEvents dtpKODtFrom As DateTimePicker
    Friend WithEvents dtpKODtTo As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents rbAllKoCancel As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents rbNonCancelKo As RadioButton
    Friend WithEvents rbCancelKo As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dtpWOEndDateFrom As DateTimePicker
    Friend WithEvents dtpWOEndDateTo As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents dtpWOStartDateFrom As DateTimePicker
    Friend WithEvents dtpWOStartDateTo As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents btnFindDesignBeam As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cboSortBy As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtDesignBeamDesc As TextBox
    Friend WithEvents btnFindDesignBobins As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnPrnStockDesignBeam As Button
    Friend WithEvents btnPrnStockDesignBobins As Button
    Friend WithEvents btnFindArticleKnitting As Button
    Friend WithEvents rbPendingKoStatus As RadioButton
    Friend WithEvents Label22 As Label
    Friend WithEvents txtDesignBeamDescp As TextBox
End Class
