<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmItemsCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemsCategory))
        Me.grdItemsProperties = New System.Windows.Forms.DataGridView()
        Me.cbolookuptype = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cbolookupvalue = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.chkitems_properties_enabled = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lblDesign_No = New System.Windows.Forms.Label()
        Me.txtItemCd = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.btnPrintItemCatgory1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrintItemCategory2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchItems = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpitcd = New System.Windows.Forms.DateTimePicker()
        Me.cboproperty = New System.Windows.Forms.ComboBox()
        Me.cboValue = New System.Windows.Forms.ComboBox()
        Me.lblProperty = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.cboitemsnature = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblItemsNature = New System.Windows.Forms.Label()
        Me.grdItemsCategory = New System.Windows.Forms.DataGridView()
        Me.items_category_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtDesigns = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboItemsCategorySet = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cboItemsCat = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cboItemssubcat = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cboItemsGroup = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cboItemsSub = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cboItemSubgroup2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cboItemsType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cboItemsSub2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.grdApplication = New System.Windows.Forms.DataGridView()
        Me.grdSPLFunction = New System.Windows.Forms.DataGridView()
        Me.grdSub = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupUsage = New System.Windows.Forms.GroupBox()
        Me.chkitem_disabled = New System.Windows.Forms.CheckBox()
        Me.txtdm_remark = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnGetMasterData = New System.Windows.Forms.Button()
        Me.Chk5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbolookuptype5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cbolookup_value_id5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.chk6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbolookuptype6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cbolookup_value_id6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.chk7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.cbolookuptype7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cbolookup_value_id7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.grdItemsProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdItemsCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdApplication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSPLFunction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdSub, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupUsage.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdItemsProperties
        '
        Me.grdItemsProperties.AllowUserToAddRows = False
        Me.grdItemsProperties.AllowUserToOrderColumns = True
        Me.grdItemsProperties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdItemsProperties.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdItemsProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdItemsProperties.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cbolookuptype, Me.cbolookupvalue, Me.chkitems_properties_enabled})
        Me.grdItemsProperties.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdItemsProperties.Location = New System.Drawing.Point(36, 312)
        Me.grdItemsProperties.Name = "grdItemsProperties"
        Me.grdItemsProperties.Size = New System.Drawing.Size(487, 314)
        Me.grdItemsProperties.TabIndex = 0
        '
        'cbolookuptype
        '
        Me.cbolookuptype.DataPropertyName = "lookup_id"
        Me.cbolookuptype.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbolookuptype.HeaderText = "PROPERTY"
        Me.cbolookuptype.Name = "cbolookuptype"
        Me.cbolookuptype.ReadOnly = True
        Me.cbolookuptype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbolookuptype.Width = 200
        '
        'cbolookupvalue
        '
        Me.cbolookupvalue.DataPropertyName = "lookup_value_id"
        Me.cbolookupvalue.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbolookupvalue.HeaderText = "VALUE"
        Me.cbolookupvalue.Items.AddRange(New Object() {"-"})
        Me.cbolookupvalue.Name = "cbolookupvalue"
        Me.cbolookupvalue.ReadOnly = True
        Me.cbolookupvalue.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbolookupvalue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbolookupvalue.Width = 150
        '
        'chkitems_properties_enabled
        '
        Me.chkitems_properties_enabled.DataPropertyName = "items_properties_enabled"
        Me.chkitems_properties_enabled.FalseValue = "False"
        Me.chkitems_properties_enabled.HeaderText = "ENABLED"
        Me.chkitems_properties_enabled.Name = "chkitems_properties_enabled"
        Me.chkitems_properties_enabled.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chkitems_properties_enabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chkitems_properties_enabled.TrueValue = "True"
        Me.chkitems_properties_enabled.Width = 60
        '
        'lblDesign_No
        '
        Me.lblDesign_No.AutoSize = True
        Me.lblDesign_No.Location = New System.Drawing.Point(21, 22)
        Me.lblDesign_No.Name = "lblDesign_No"
        Me.lblDesign_No.Size = New System.Drawing.Size(61, 13)
        Me.lblDesign_No.TabIndex = 2
        Me.lblDesign_No.Text = "Item Code :"
        '
        'txtItemCd
        '
        Me.txtItemCd.Location = New System.Drawing.Point(100, 19)
        Me.txtItemCd.Name = "txtItemCd"
        Me.txtItemCd.Size = New System.Drawing.Size(205, 20)
        Me.txtItemCd.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSave, Me.ToolStripSplitButton1, Me.ToolStripSeparator2, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1217, 25)
        Me.ToolStrip1.TabIndex = 38
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrintItemCatgory1, Me.btnPrintItemCategory2})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(64, 22)
        Me.ToolStripSplitButton1.Text = "Print"
        '
        'btnPrintItemCatgory1
        '
        Me.btnPrintItemCatgory1.Image = CType(resources.GetObject("btnPrintItemCatgory1.Image"), System.Drawing.Image)
        Me.btnPrintItemCatgory1.Name = "btnPrintItemCatgory1"
        Me.btnPrintItemCatgory1.Size = New System.Drawing.Size(158, 22)
        Me.btnPrintItemCatgory1.Text = "Item Category"
        '
        'btnPrintItemCategory2
        '
        Me.btnPrintItemCategory2.Name = "btnPrintItemCategory2"
        Me.btnPrintItemCategory2.Size = New System.Drawing.Size(158, 22)
        Me.btnPrintItemCategory2.Text = "Item Category 2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(516, 22)
        Me.ToolStripLabel1.Text = "***Record in Yellow Background , It means Record is new. (Default Value Still hav" &
    "e not data)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchItems)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpitcd)
        Me.GroupBox1.Controls.Add(Me.txtItemCd)
        Me.GroupBox1.Controls.Add(Me.lblDesign_No)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 83)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'btnSearchItems
        '
        Me.btnSearchItems.Image = CType(resources.GetObject("btnSearchItems.Image"), System.Drawing.Image)
        Me.btnSearchItems.Location = New System.Drawing.Point(311, 15)
        Me.btnSearchItems.Name = "btnSearchItems"
        Me.btnSearchItems.Size = New System.Drawing.Size(32, 24)
        Me.btnSearchItems.TabIndex = 49
        Me.btnSearchItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchItems.UseVisualStyleBackColor = True
        Me.btnSearchItems.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date :"
        '
        'dtpitcd
        '
        Me.dtpitcd.CustomFormat = ""
        Me.dtpitcd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpitcd.Location = New System.Drawing.Point(100, 52)
        Me.dtpitcd.Name = "dtpitcd"
        Me.dtpitcd.Size = New System.Drawing.Size(205, 20)
        Me.dtpitcd.TabIndex = 4
        '
        'cboproperty
        '
        Me.cboproperty.DisplayMember = "lookup_id"
        Me.cboproperty.FormattingEnabled = True
        Me.cboproperty.Location = New System.Drawing.Point(103, 239)
        Me.cboproperty.Name = "cboproperty"
        Me.cboproperty.Size = New System.Drawing.Size(263, 21)
        Me.cboproperty.TabIndex = 42
        Me.cboproperty.ValueMember = "lookup_id"
        '
        'cboValue
        '
        Me.cboValue.DisplayMember = "lookup_value_id"
        Me.cboValue.FormattingEnabled = True
        Me.cboValue.Location = New System.Drawing.Point(439, 239)
        Me.cboValue.Name = "cboValue"
        Me.cboValue.Size = New System.Drawing.Size(217, 21)
        Me.cboValue.TabIndex = 43
        Me.cboValue.ValueMember = "lookup_value_id"
        '
        'lblProperty
        '
        Me.lblProperty.AutoSize = True
        Me.lblProperty.Location = New System.Drawing.Point(45, 242)
        Me.lblProperty.Name = "lblProperty"
        Me.lblProperty.Size = New System.Drawing.Size(52, 13)
        Me.lblProperty.TabIndex = 44
        Me.lblProperty.Text = "Property :"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(385, 243)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(34, 13)
        Me.lblValue.TabIndex = 45
        Me.lblValue.Text = "Value"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(691, 239)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 23)
        Me.btnApply.TabIndex = 46
        Me.btnApply.Text = "APPLY"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'cboitemsnature
        '
        Me.cboitemsnature.FormattingEnabled = True
        Me.cboitemsnature.Location = New System.Drawing.Point(84, 22)
        Me.cboitemsnature.Name = "cboitemsnature"
        Me.cboitemsnature.Size = New System.Drawing.Size(159, 21)
        Me.cboitemsnature.TabIndex = 47
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblItemsNature)
        Me.GroupBox3.Controls.Add(Me.cboitemsnature)
        Me.GroupBox3.Location = New System.Drawing.Point(644, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 83)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        '
        'lblItemsNature
        '
        Me.lblItemsNature.AutoSize = True
        Me.lblItemsNature.Location = New System.Drawing.Point(11, 26)
        Me.lblItemsNature.Name = "lblItemsNature"
        Me.lblItemsNature.Size = New System.Drawing.Size(67, 13)
        Me.lblItemsNature.TabIndex = 48
        Me.lblItemsNature.Text = "Items Nature"
        '
        'grdItemsCategory
        '
        Me.grdItemsCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdItemsCategory.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdItemsCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdItemsCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.items_category_id, Me.txtDesigns, Me.cboItemsCategorySet, Me.cboItemsCat, Me.cboItemssubcat, Me.cboItemsGroup, Me.cboItemsSub, Me.cboItemSubgroup2, Me.cboItemsType, Me.cboItemsSub2})
        Me.grdItemsCategory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdItemsCategory.Location = New System.Drawing.Point(22, 117)
        Me.grdItemsCategory.Name = "grdItemsCategory"
        Me.grdItemsCategory.Size = New System.Drawing.Size(1183, 114)
        Me.grdItemsCategory.TabIndex = 50
        '
        'items_category_id
        '
        Me.items_category_id.DataPropertyName = "items_category_id"
        Me.items_category_id.HeaderText = "ID"
        Me.items_category_id.Name = "items_category_id"
        Me.items_category_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.items_category_id.Visible = False
        '
        'txtDesigns
        '
        Me.txtDesigns.DataPropertyName = "itcd"
        Me.txtDesigns.HeaderText = "ITCD"
        Me.txtDesigns.Name = "txtDesigns"
        Me.txtDesigns.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.txtDesigns.Visible = False
        '
        'cboItemsCategorySet
        '
        Me.cboItemsCategorySet.DataPropertyName = "items_category_set_id"
        Me.cboItemsCategorySet.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cboItemsCategorySet.HeaderText = "ITEMS CATEGORY"
        Me.cboItemsCategorySet.Name = "cboItemsCategorySet"
        Me.cboItemsCategorySet.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboItemsCategorySet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboItemsCategorySet.Width = 120
        '
        'cboItemsCat
        '
        Me.cboItemsCat.DataPropertyName = "itcatcd"
        Me.cboItemsCat.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cboItemsCat.HeaderText = "KNIT CATEGORY"
        Me.cboItemsCat.Name = "cboItemsCat"
        Me.cboItemsCat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboItemsCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboItemsCat.Width = 150
        '
        'cboItemssubcat
        '
        Me.cboItemssubcat.DataPropertyName = "itsubcatcd"
        Me.cboItemssubcat.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cboItemssubcat.HeaderText = "KNIT SUB"
        Me.cboItemssubcat.Name = "cboItemssubcat"
        Me.cboItemssubcat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboItemssubcat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboItemssubcat.Width = 120
        '
        'cboItemsGroup
        '
        Me.cboItemsGroup.DataPropertyName = "itgroupcd"
        Me.cboItemsGroup.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cboItemsGroup.HeaderText = "FABRIC GROUP"
        Me.cboItemsGroup.Name = "cboItemsGroup"
        Me.cboItemsGroup.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboItemsGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboItemsGroup.Width = 120
        '
        'cboItemsSub
        '
        Me.cboItemsSub.DataPropertyName = "itsubcd"
        Me.cboItemsSub.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cboItemsSub.HeaderText = "FABRIC SUB GROUP"
        Me.cboItemsSub.Name = "cboItemsSub"
        Me.cboItemsSub.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboItemsSub.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboItemsSub.Width = 120
        '
        'cboItemSubgroup2
        '
        Me.cboItemSubgroup2.DataPropertyName = "items_sub_group2_id"
        Me.cboItemSubgroup2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cboItemSubgroup2.HeaderText = "ITEM SUB GROUP 2"
        Me.cboItemSubgroup2.Name = "cboItemSubgroup2"
        Me.cboItemSubgroup2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboItemSubgroup2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cboItemsType
        '
        Me.cboItemsType.DataPropertyName = "ittypecd"
        Me.cboItemsType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cboItemsType.HeaderText = "FIBRE TYPE"
        Me.cboItemsType.Name = "cboItemsType"
        Me.cboItemsType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboItemsType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboItemsType.Width = 120
        '
        'cboItemsSub2
        '
        Me.cboItemsSub2.DataPropertyName = "itsubcd2"
        Me.cboItemsSub2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cboItemsSub2.HeaderText = "FIBRE SUB"
        Me.cboItemsSub2.Name = "cboItemsSub2"
        Me.cboItemsSub2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboItemsSub2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboItemsSub2.Width = 120
        '
        'grdApplication
        '
        Me.grdApplication.AllowUserToAddRows = False
        Me.grdApplication.AllowUserToDeleteRows = False
        Me.grdApplication.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdApplication.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdApplication.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chk5, Me.cbolookuptype5, Me.cbolookup_value_id5})
        Me.grdApplication.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdApplication.Location = New System.Drawing.Point(16, 27)
        Me.grdApplication.Name = "grdApplication"
        Me.grdApplication.ReadOnly = True
        Me.grdApplication.RowHeadersWidth = 4
        Me.grdApplication.Size = New System.Drawing.Size(176, 314)
        Me.grdApplication.TabIndex = 51
        '
        'grdSPLFunction
        '
        Me.grdSPLFunction.AllowUserToAddRows = False
        Me.grdSPLFunction.AllowUserToDeleteRows = False
        Me.grdSPLFunction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSPLFunction.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdSPLFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSPLFunction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk7, Me.cbolookuptype7, Me.cbolookup_value_id7})
        Me.grdSPLFunction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdSPLFunction.Location = New System.Drawing.Point(406, 27)
        Me.grdSPLFunction.Name = "grdSPLFunction"
        Me.grdSPLFunction.ReadOnly = True
        Me.grdSPLFunction.RowHeadersWidth = 4
        Me.grdSPLFunction.Size = New System.Drawing.Size(176, 314)
        Me.grdSPLFunction.TabIndex = 53
        '
        'grdSub
        '
        Me.grdSub.AllowUserToAddRows = False
        Me.grdSub.AllowUserToDeleteRows = False
        Me.grdSub.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSub.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSub.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chk6, Me.cbolookuptype6, Me.cbolookup_value_id6})
        Me.grdSub.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdSub.Location = New System.Drawing.Point(213, 27)
        Me.grdSub.Name = "grdSub"
        Me.grdSub.ReadOnly = True
        Me.grdSub.RowHeadersWidth = 4
        Me.grdSub.Size = New System.Drawing.Size(176, 314)
        Me.grdSub.TabIndex = 52
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(543, 329)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(49, 23)
        Me.btnAdd.TabIndex = 57
        Me.btnAdd.Text = "<"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupUsage
        '
        Me.GroupUsage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupUsage.Controls.Add(Me.grdSub)
        Me.GroupUsage.Controls.Add(Me.grdSPLFunction)
        Me.GroupUsage.Controls.Add(Me.grdApplication)
        Me.GroupUsage.Location = New System.Drawing.Point(607, 285)
        Me.GroupUsage.Name = "GroupUsage"
        Me.GroupUsage.Size = New System.Drawing.Size(598, 341)
        Me.GroupUsage.TabIndex = 58
        Me.GroupUsage.TabStop = False
        Me.GroupUsage.Text = "Usage"
        '
        'chkitem_disabled
        '
        Me.chkitem_disabled.AutoSize = True
        Me.chkitem_disabled.Location = New System.Drawing.Point(572, 43)
        Me.chkitem_disabled.Name = "chkitem_disabled"
        Me.chkitem_disabled.Size = New System.Drawing.Size(66, 17)
        Me.chkitem_disabled.TabIndex = 59
        Me.chkitem_disabled.Text = "Remove"
        Me.chkitem_disabled.UseVisualStyleBackColor = True
        '
        'txtdm_remark
        '
        Me.txtdm_remark.Location = New System.Drawing.Point(18, 18)
        Me.txtdm_remark.Multiline = True
        Me.txtdm_remark.Name = "txtdm_remark"
        Me.txtdm_remark.Size = New System.Drawing.Size(136, 50)
        Me.txtdm_remark.TabIndex = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdm_remark)
        Me.GroupBox2.Location = New System.Drawing.Point(388, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(170, 83)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Remark"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(572, 67)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(66, 20)
        Me.DateTimePicker1.TabIndex = 62
        Me.DateTimePicker1.Visible = False
        '
        'BtnGetMasterData
        '
        Me.BtnGetMasterData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGetMasterData.Location = New System.Drawing.Point(1087, 76)
        Me.BtnGetMasterData.Name = "BtnGetMasterData"
        Me.BtnGetMasterData.Size = New System.Drawing.Size(118, 35)
        Me.BtnGetMasterData.TabIndex = 74
        Me.BtnGetMasterData.Text = "Get Default Master Data"
        Me.BtnGetMasterData.UseVisualStyleBackColor = True
        '
        'Chk5
        '
        Me.Chk5.DataPropertyName = "sel"
        Me.Chk5.FalseValue = "FALSE"
        Me.Chk5.HeaderText = ""
        Me.Chk5.Name = "Chk5"
        Me.Chk5.ReadOnly = True
        Me.Chk5.TrueValue = "TRUE"
        Me.Chk5.Width = 20
        '
        'cbolookuptype5
        '
        Me.cbolookuptype5.DataPropertyName = "lookup_id"
        Me.cbolookuptype5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbolookuptype5.HeaderText = "Property"
        Me.cbolookuptype5.Name = "cbolookuptype5"
        Me.cbolookuptype5.ReadOnly = True
        Me.cbolookuptype5.Visible = False
        Me.cbolookuptype5.Width = 20
        '
        'cbolookup_value_id5
        '
        Me.cbolookup_value_id5.DataPropertyName = "lookup_value_id"
        Me.cbolookup_value_id5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbolookup_value_id5.HeaderText = "APPLICATION"
        Me.cbolookup_value_id5.Name = "cbolookup_value_id5"
        Me.cbolookup_value_id5.ReadOnly = True
        Me.cbolookup_value_id5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbolookup_value_id5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbolookup_value_id5.Width = 150
        '
        'chk6
        '
        Me.chk6.DataPropertyName = "sel"
        Me.chk6.FalseValue = "FALSE"
        Me.chk6.HeaderText = ""
        Me.chk6.Name = "chk6"
        Me.chk6.ReadOnly = True
        Me.chk6.TrueValue = "TRUE"
        Me.chk6.Width = 20
        '
        'cbolookuptype6
        '
        Me.cbolookuptype6.DataPropertyName = "lookup_id"
        Me.cbolookuptype6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbolookuptype6.HeaderText = "Property"
        Me.cbolookuptype6.Name = "cbolookuptype6"
        Me.cbolookuptype6.ReadOnly = True
        Me.cbolookuptype6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbolookuptype6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbolookuptype6.Visible = False
        Me.cbolookuptype6.Width = 20
        '
        'cbolookup_value_id6
        '
        Me.cbolookup_value_id6.DataPropertyName = "lookup_value_id"
        Me.cbolookup_value_id6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbolookup_value_id6.HeaderText = "SUB APPL"
        Me.cbolookup_value_id6.Name = "cbolookup_value_id6"
        Me.cbolookup_value_id6.ReadOnly = True
        Me.cbolookup_value_id6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbolookup_value_id6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbolookup_value_id6.Width = 150
        '
        'chk7
        '
        Me.chk7.DataPropertyName = "sel"
        Me.chk7.FalseValue = "FALSE"
        Me.chk7.HeaderText = ""
        Me.chk7.Name = "chk7"
        Me.chk7.ReadOnly = True
        Me.chk7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chk7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chk7.TrueValue = "TRUE"
        Me.chk7.Width = 20
        '
        'cbolookuptype7
        '
        Me.cbolookuptype7.DataPropertyName = "lookup_id"
        Me.cbolookuptype7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbolookuptype7.HeaderText = "Property"
        Me.cbolookuptype7.Name = "cbolookuptype7"
        Me.cbolookuptype7.ReadOnly = True
        Me.cbolookuptype7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbolookuptype7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbolookuptype7.Visible = False
        Me.cbolookuptype7.Width = 20
        '
        'cbolookup_value_id7
        '
        Me.cbolookup_value_id7.DataPropertyName = "lookup_value_id"
        Me.cbolookup_value_id7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbolookup_value_id7.HeaderText = "SPL.FUNTION"
        Me.cbolookup_value_id7.Name = "cbolookup_value_id7"
        Me.cbolookup_value_id7.ReadOnly = True
        Me.cbolookup_value_id7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbolookup_value_id7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbolookup_value_id7.Width = 150
        '
        'frmItemsCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 638)
        Me.Controls.Add(Me.BtnGetMasterData)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.chkitem_disabled)
        Me.Controls.Add(Me.GroupUsage)
        Me.Controls.Add(Me.grdItemsCategory)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblProperty)
        Me.Controls.Add(Me.cboValue)
        Me.Controls.Add(Me.cboproperty)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdItemsProperties)
        Me.Name = "frmItemsCategory"
        Me.Text = "INVENTORY CATEGORY"
        CType(Me.grdItemsProperties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grdItemsCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdApplication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSPLFunction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdSub, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupUsage.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdItemsProperties As System.Windows.Forms.DataGridView
    Friend WithEvents lblDesign_No As System.Windows.Forms.Label
    Friend WithEvents txtItemCd As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpitcd As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboproperty As System.Windows.Forms.ComboBox
    Friend WithEvents cboValue As System.Windows.Forms.ComboBox
    Friend WithEvents lblProperty As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents cboitemsnature As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblItemsNature As System.Windows.Forms.Label
    Friend WithEvents btnSearchItems As System.Windows.Forms.Button
    Friend WithEvents grdItemsCategory As System.Windows.Forms.DataGridView
    Friend WithEvents grdApplication As System.Windows.Forms.DataGridView
    Friend WithEvents grdSPLFunction As System.Windows.Forms.DataGridView
    Friend WithEvents cbolookuptype As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cbolookupvalue As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents chkitems_properties_enabled As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents grdSub As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupUsage As System.Windows.Forms.GroupBox
    Friend WithEvents chkitem_disabled As System.Windows.Forms.CheckBox
    Friend WithEvents txtdm_remark As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents items_category_id As DataGridViewTextBoxColumn
    Friend WithEvents txtDesigns As DataGridViewTextBoxColumn
    Friend WithEvents cboItemsCategorySet As DataGridViewComboBoxColumn
    Friend WithEvents cboItemsCat As DataGridViewComboBoxColumn
    Friend WithEvents cboItemssubcat As DataGridViewComboBoxColumn
    Friend WithEvents cboItemsGroup As DataGridViewComboBoxColumn
    Friend WithEvents cboItemsSub As DataGridViewComboBoxColumn
    Friend WithEvents cboItemSubgroup2 As DataGridViewComboBoxColumn
    Friend WithEvents cboItemsType As DataGridViewComboBoxColumn
    Friend WithEvents cboItemsSub2 As DataGridViewComboBoxColumn
    Friend WithEvents BtnGetMasterData As Button
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents btnPrintItemCatgory1 As ToolStripMenuItem
    Friend WithEvents btnPrintItemCategory2 As ToolStripMenuItem
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Chk5 As DataGridViewCheckBoxColumn
    Friend WithEvents cbolookuptype5 As DataGridViewComboBoxColumn
    Friend WithEvents cbolookup_value_id5 As DataGridViewComboBoxColumn
    Friend WithEvents chk7 As DataGridViewCheckBoxColumn
    Friend WithEvents cbolookuptype7 As DataGridViewComboBoxColumn
    Friend WithEvents cbolookup_value_id7 As DataGridViewComboBoxColumn
    Friend WithEvents chk6 As DataGridViewCheckBoxColumn
    Friend WithEvents cbolookuptype6 As DataGridViewComboBoxColumn
    Friend WithEvents cbolookup_value_id6 As DataGridViewComboBoxColumn
End Class
