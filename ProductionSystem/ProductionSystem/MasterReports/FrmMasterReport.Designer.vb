<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterReport
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.grdResult = New System.Windows.Forms.DataGridView()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Article_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mtkg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APPL_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sub_Appl_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Spl_fnc_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_family_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itcatdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itsubcatdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itgroupdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itsubdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.designdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtWeightTo = New System.Windows.Forms.TextBox()
        Me.txtWeightFrom = New System.Windows.Forms.TextBox()
        Me.txtWidthTo = New System.Windows.Forms.TextBox()
        Me.txtWidthFrom = New System.Windows.Forms.TextBox()
        Me.cboFabricSubGroup = New System.Windows.Forms.ComboBox()
        Me.cboFabricGroup = New System.Windows.Forms.ComboBox()
        Me.dtpDesignDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesignDateTo = New System.Windows.Forms.DateTimePicker()
        Me.cboSubCategory = New System.Windows.Forms.ComboBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.txtArticle = New System.Windows.Forms.TextBox()
        Me.txtComposition = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cboSpcialFunction = New System.Windows.Forms.ComboBox()
        Me.cboSubApplication = New System.Windows.Forms.ComboBox()
        Me.cboApplication = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblFabricSubGroup = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblWeightTo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnPrint)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.btnQuery)
        Me.GroupBox3.Controls.Add(Me.grdResult)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 183)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1128, 360)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(481, 19)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(55, 22)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtFilter)
        Me.GroupBox4.Location = New System.Drawing.Point(87, 10)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 42)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filter"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(61, 14)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(228, 20)
        Me.txtFilter.TabIndex = 37
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(18, 19)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(55, 22)
        Me.btnQuery.TabIndex = 1
        Me.btnQuery.Text = "Query"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'grdResult
        '
        Me.grdResult.AllowUserToAddRows = False
        Me.grdResult.AllowUserToDeleteRows = False
        Me.grdResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Design_no, Me.Article_desc, Me.gwth, Me.Fwth, Me.mtkg, Me.APPL_NAME, Me.Sub_Appl_Name, Me.Spl_fnc_Name, Me.design_family_Name, Me.itcatdesc, Me.itsubcatdesc, Me.itgroupdesc, Me.itsubdesc, Me.designdt})
        Me.grdResult.Location = New System.Drawing.Point(16, 58)
        Me.grdResult.Name = "grdResult"
        Me.grdResult.ReadOnly = True
        Me.grdResult.Size = New System.Drawing.Size(1093, 293)
        Me.grdResult.TabIndex = 0
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "Design_no"
        Me.Design_no.HeaderText = "Design No"
        Me.Design_no.Name = "Design_no"
        Me.Design_no.ReadOnly = True
        '
        'Article_desc
        '
        Me.Article_desc.DataPropertyName = "Article_desc"
        Me.Article_desc.HeaderText = "Article Description"
        Me.Article_desc.Name = "Article_desc"
        Me.Article_desc.ReadOnly = True
        Me.Article_desc.Width = 250
        '
        'gwth
        '
        Me.gwth.DataPropertyName = "gwth"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.gwth.DefaultCellStyle = DataGridViewCellStyle1
        Me.gwth.HeaderText = "gwth"
        Me.gwth.Name = "gwth"
        Me.gwth.ReadOnly = True
        Me.gwth.Width = 50
        '
        'Fwth
        '
        Me.Fwth.DataPropertyName = "Fwth"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Fwth.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fwth.HeaderText = "Fwth"
        Me.Fwth.Name = "Fwth"
        Me.Fwth.ReadOnly = True
        Me.Fwth.Width = 50
        '
        'mtkg
        '
        Me.mtkg.DataPropertyName = "mtkg"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.mtkg.DefaultCellStyle = DataGridViewCellStyle3
        Me.mtkg.HeaderText = "mtkg"
        Me.mtkg.Name = "mtkg"
        Me.mtkg.ReadOnly = True
        Me.mtkg.Width = 50
        '
        'APPL_NAME
        '
        Me.APPL_NAME.DataPropertyName = "APPL_NAME"
        Me.APPL_NAME.HeaderText = "Application Name"
        Me.APPL_NAME.Name = "APPL_NAME"
        Me.APPL_NAME.ReadOnly = True
        Me.APPL_NAME.Width = 200
        '
        'Sub_Appl_Name
        '
        Me.Sub_Appl_Name.DataPropertyName = "Sub_Appl_Name"
        Me.Sub_Appl_Name.HeaderText = "Subapplication Name"
        Me.Sub_Appl_Name.Name = "Sub_Appl_Name"
        Me.Sub_Appl_Name.ReadOnly = True
        Me.Sub_Appl_Name.Width = 200
        '
        'Spl_fnc_Name
        '
        Me.Spl_fnc_Name.DataPropertyName = "Spl_fnc_Name"
        Me.Spl_fnc_Name.HeaderText = "Special Function Name"
        Me.Spl_fnc_Name.Name = "Spl_fnc_Name"
        Me.Spl_fnc_Name.ReadOnly = True
        Me.Spl_fnc_Name.Width = 200
        '
        'design_family_Name
        '
        Me.design_family_Name.DataPropertyName = "design_family_Name"
        Me.design_family_Name.HeaderText = "Design Family Name"
        Me.design_family_Name.Name = "design_family_Name"
        Me.design_family_Name.ReadOnly = True
        Me.design_family_Name.Width = 200
        '
        'itcatdesc
        '
        Me.itcatdesc.DataPropertyName = "itcatdesc"
        Me.itcatdesc.HeaderText = "Category"
        Me.itcatdesc.Name = "itcatdesc"
        Me.itcatdesc.ReadOnly = True
        Me.itcatdesc.Width = 80
        '
        'itsubcatdesc
        '
        Me.itsubcatdesc.DataPropertyName = "itsubcatdesc"
        Me.itsubcatdesc.HeaderText = "Sub Category"
        Me.itsubcatdesc.Name = "itsubcatdesc"
        Me.itsubcatdesc.ReadOnly = True
        Me.itsubcatdesc.Width = 120
        '
        'itgroupdesc
        '
        Me.itgroupdesc.DataPropertyName = "itgroupdesc"
        Me.itgroupdesc.HeaderText = "Fabric Group"
        Me.itgroupdesc.Name = "itgroupdesc"
        Me.itgroupdesc.ReadOnly = True
        Me.itgroupdesc.Width = 120
        '
        'itsubdesc
        '
        Me.itsubdesc.DataPropertyName = "itsubdesc"
        Me.itsubdesc.HeaderText = "Fabric Subgroup"
        Me.itsubdesc.Name = "itsubdesc"
        Me.itsubdesc.ReadOnly = True
        Me.itsubdesc.Width = 120
        '
        'designdt
        '
        Me.designdt.DataPropertyName = "designdt"
        Me.designdt.HeaderText = "Design Create Date"
        Me.designdt.Name = "designdt"
        Me.designdt.ReadOnly = True
        Me.designdt.Width = 80
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtWeightTo)
        Me.GroupBox5.Controls.Add(Me.txtWeightFrom)
        Me.GroupBox5.Controls.Add(Me.txtWidthTo)
        Me.GroupBox5.Controls.Add(Me.txtWidthFrom)
        Me.GroupBox5.Controls.Add(Me.cboFabricSubGroup)
        Me.GroupBox5.Controls.Add(Me.cboFabricGroup)
        Me.GroupBox5.Controls.Add(Me.dtpDesignDateFrom)
        Me.GroupBox5.Controls.Add(Me.dtpDesignDateTo)
        Me.GroupBox5.Controls.Add(Me.cboSubCategory)
        Me.GroupBox5.Controls.Add(Me.cboCategory)
        Me.GroupBox5.Controls.Add(Me.txtArticle)
        Me.GroupBox5.Controls.Add(Me.txtComposition)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Controls.Add(Me.lblFabricSubGroup)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.lblWeightTo)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(10, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1128, 175)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Conditions"
        '
        'txtWeightTo
        '
        Me.txtWeightTo.Location = New System.Drawing.Point(862, 92)
        Me.txtWeightTo.Name = "txtWeightTo"
        Me.txtWeightTo.Size = New System.Drawing.Size(93, 20)
        Me.txtWeightTo.TabIndex = 36
        '
        'txtWeightFrom
        '
        Me.txtWeightFrom.Location = New System.Drawing.Point(862, 67)
        Me.txtWeightFrom.Name = "txtWeightFrom"
        Me.txtWeightFrom.Size = New System.Drawing.Size(93, 20)
        Me.txtWeightFrom.TabIndex = 35
        '
        'txtWidthTo
        '
        Me.txtWidthTo.Location = New System.Drawing.Point(862, 43)
        Me.txtWidthTo.Name = "txtWidthTo"
        Me.txtWidthTo.Size = New System.Drawing.Size(93, 20)
        Me.txtWidthTo.TabIndex = 34
        '
        'txtWidthFrom
        '
        Me.txtWidthFrom.Location = New System.Drawing.Point(862, 19)
        Me.txtWidthFrom.Name = "txtWidthFrom"
        Me.txtWidthFrom.Size = New System.Drawing.Size(93, 20)
        Me.txtWidthFrom.TabIndex = 33
        '
        'cboFabricSubGroup
        '
        Me.cboFabricSubGroup.FormattingEnabled = True
        Me.cboFabricSubGroup.Location = New System.Drawing.Point(500, 92)
        Me.cboFabricSubGroup.Name = "cboFabricSubGroup"
        Me.cboFabricSubGroup.Size = New System.Drawing.Size(136, 21)
        Me.cboFabricSubGroup.TabIndex = 32
        '
        'cboFabricGroup
        '
        Me.cboFabricGroup.FormattingEnabled = True
        Me.cboFabricGroup.Location = New System.Drawing.Point(500, 67)
        Me.cboFabricGroup.Name = "cboFabricGroup"
        Me.cboFabricGroup.Size = New System.Drawing.Size(136, 21)
        Me.cboFabricGroup.TabIndex = 31
        '
        'dtpDesignDateFrom
        '
        Me.dtpDesignDateFrom.Checked = False
        Me.dtpDesignDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesignDateFrom.Location = New System.Drawing.Point(500, 19)
        Me.dtpDesignDateFrom.Name = "dtpDesignDateFrom"
        Me.dtpDesignDateFrom.ShowCheckBox = True
        Me.dtpDesignDateFrom.Size = New System.Drawing.Size(121, 20)
        Me.dtpDesignDateFrom.TabIndex = 30
        '
        'dtpDesignDateTo
        '
        Me.dtpDesignDateTo.Checked = False
        Me.dtpDesignDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesignDateTo.Location = New System.Drawing.Point(500, 43)
        Me.dtpDesignDateTo.Name = "dtpDesignDateTo"
        Me.dtpDesignDateTo.ShowCheckBox = True
        Me.dtpDesignDateTo.Size = New System.Drawing.Size(121, 20)
        Me.dtpDesignDateTo.TabIndex = 29
        '
        'cboSubCategory
        '
        Me.cboSubCategory.FormattingEnabled = True
        Me.cboSubCategory.Location = New System.Drawing.Point(144, 92)
        Me.cboSubCategory.Name = "cboSubCategory"
        Me.cboSubCategory.Size = New System.Drawing.Size(136, 21)
        Me.cboSubCategory.TabIndex = 28
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(144, 67)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(136, 21)
        Me.cboCategory.TabIndex = 27
        '
        'txtArticle
        '
        Me.txtArticle.Location = New System.Drawing.Point(144, 43)
        Me.txtArticle.Name = "txtArticle"
        Me.txtArticle.Size = New System.Drawing.Size(136, 20)
        Me.txtArticle.TabIndex = 26
        '
        'txtComposition
        '
        Me.txtComposition.Location = New System.Drawing.Point(144, 19)
        Me.txtComposition.Name = "txtComposition"
        Me.txtComposition.Size = New System.Drawing.Size(136, 20)
        Me.txtComposition.TabIndex = 25
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cboSpcialFunction)
        Me.GroupBox8.Controls.Add(Me.cboSubApplication)
        Me.GroupBox8.Controls.Add(Me.cboApplication)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Location = New System.Drawing.Point(13, 124)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1096, 42)
        Me.GroupBox8.TabIndex = 24
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "PROPERTIES"
        '
        'cboSpcialFunction
        '
        Me.cboSpcialFunction.FormattingEnabled = True
        Me.cboSpcialFunction.Location = New System.Drawing.Point(890, 15)
        Me.cboSpcialFunction.Name = "cboSpcialFunction"
        Me.cboSpcialFunction.Size = New System.Drawing.Size(170, 21)
        Me.cboSpcialFunction.TabIndex = 31
        '
        'cboSubApplication
        '
        Me.cboSubApplication.FormattingEnabled = True
        Me.cboSubApplication.Location = New System.Drawing.Point(487, 15)
        Me.cboSubApplication.Name = "cboSubApplication"
        Me.cboSubApplication.Size = New System.Drawing.Size(148, 21)
        Me.cboSubApplication.TabIndex = 30
        '
        'cboApplication
        '
        Me.cboApplication.FormattingEnabled = True
        Me.cboApplication.Location = New System.Drawing.Point(100, 15)
        Me.cboApplication.Name = "cboApplication"
        Me.cboApplication.Size = New System.Drawing.Size(136, 21)
        Me.cboApplication.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(797, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Spcial Function"
        Me.Label15.UseWaitCursor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "APPLICATION"
        Me.Label13.UseWaitCursor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(375, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "SUB APPLICATION"
        Me.Label14.UseWaitCursor = True
        '
        'lblFabricSubGroup
        '
        Me.lblFabricSubGroup.AutoSize = True
        Me.lblFabricSubGroup.Location = New System.Drawing.Point(363, 95)
        Me.lblFabricSubGroup.Name = "lblFabricSubGroup"
        Me.lblFabricSubGroup.Size = New System.Drawing.Size(112, 13)
        Me.lblFabricSubGroup.TabIndex = 22
        Me.lblFabricSubGroup.Text = "FABRIC SUB GROUP"
        Me.lblFabricSubGroup.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COMPOSITION"
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ARTICLE"
        Me.Label2.UseWaitCursor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(363, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "FABRIC GROUP"
        Me.Label11.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CATEGORY"
        Me.Label3.UseWaitCursor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "SUB CATEGORY"
        Me.Label10.UseWaitCursor = True
        '
        'lblWeightTo
        '
        Me.lblWeightTo.AutoSize = True
        Me.lblWeightTo.Location = New System.Drawing.Point(726, 95)
        Me.lblWeightTo.Name = "lblWeightTo"
        Me.lblWeightTo.Size = New System.Drawing.Size(98, 13)
        Me.lblWeightTo.TabIndex = 16
        Me.lblWeightTo.Text = "WEIGHT (GM)  TO"
        Me.lblWeightTo.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(363, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DESIGN DATE FROM"
        Me.Label4.UseWaitCursor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(726, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "WEIGHT (GM)  FROM"
        Me.Label8.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(363, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DESIGN DATE TO"
        Me.Label5.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(726, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "WIDTH (CM)  FROM"
        Me.Label6.UseWaitCursor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(726, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "WIDTH (CM)  TO"
        Me.Label7.UseWaitCursor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Design_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Design No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Article_desc"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Article Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "gwth"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "gwth"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fwth"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fwth"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "mtkg"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "mtkg"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "APPL_NAME"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Application Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 250
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Sub_Appl_Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Subapplication Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 250
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Spl_fnc_Name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Special Function Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 250
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "design_family_Name"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Design Family Name"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "itcatcd"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 60
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "itsubcatcd"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Sub Category"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 60
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "itgroupcd"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fabric Group"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 60
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "itsubcd"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Fabric Subgroup"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 60
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "designdt"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Design Create Date"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 80
        '
        'FrmMasterReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 554)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.DoubleBuffered = True
        Me.Name = "FrmMasterReport"
        Me.Text = "Design Master Report"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.grdResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grdResult As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnQuery As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblFabricSubGroup As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblWeightTo As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtComposition As TextBox
    Friend WithEvents cboSubCategory As ComboBox
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents txtArticle As TextBox
    Friend WithEvents dtpDesignDateFrom As DateTimePicker
    Friend WithEvents dtpDesignDateTo As DateTimePicker
    Friend WithEvents cboApplication As ComboBox
    Friend WithEvents txtWeightTo As TextBox
    Friend WithEvents txtWeightFrom As TextBox
    Friend WithEvents txtWidthTo As TextBox
    Friend WithEvents txtWidthFrom As TextBox
    Friend WithEvents cboFabricSubGroup As ComboBox
    Friend WithEvents cboFabricGroup As ComboBox
    Friend WithEvents cboSubApplication As ComboBox
    Friend WithEvents cboSpcialFunction As ComboBox
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Design_no As DataGridViewTextBoxColumn
    Friend WithEvents Article_desc As DataGridViewTextBoxColumn
    Friend WithEvents gwth As DataGridViewTextBoxColumn
    Friend WithEvents Fwth As DataGridViewTextBoxColumn
    Friend WithEvents mtkg As DataGridViewTextBoxColumn
    Friend WithEvents APPL_NAME As DataGridViewTextBoxColumn
    Friend WithEvents Sub_Appl_Name As DataGridViewTextBoxColumn
    Friend WithEvents Spl_fnc_Name As DataGridViewTextBoxColumn
    Friend WithEvents design_family_Name As DataGridViewTextBoxColumn
    Friend WithEvents itcatdesc As DataGridViewTextBoxColumn
    Friend WithEvents itsubcatdesc As DataGridViewTextBoxColumn
    Friend WithEvents itgroupdesc As DataGridViewTextBoxColumn
    Friend WithEvents itsubdesc As DataGridViewTextBoxColumn
    Friend WithEvents designdt As DataGridViewTextBoxColumn
End Class
