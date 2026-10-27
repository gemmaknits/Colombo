<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formYarnMaster
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formYarnMaster))
        Me.txtyarncode = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.txtdesc2 = New System.Windows.Forms.TextBox()
        Me.txtdesct2 = New System.Windows.Forms.TextBox()
        Me.txtdesct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDescSupp = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDescSpec = New System.Windows.Forms.TextBox()
        Me.buttonGenDesc = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDesc3 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbeam_length = New System.Windows.Forms.TextBox()
        Me.lblBeamLength = New System.Windows.Forms.Label()
        Me.txtbeams_per_set = New System.Windows.Forms.TextBox()
        Me.txtwarped_ends = New System.Windows.Forms.TextBox()
        Me.lblbeams_per_set = New System.Windows.Forms.Label()
        Me.lblwarped_ends = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txttwists = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbsuppcd = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbitcatcd = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbitsubcatcd = New System.Windows.Forms.ComboBox()
        Me.cbitsubcd2 = New System.Windows.Forms.ComboBox()
        Me.cbitsubcd = New System.Windows.Forms.ComboBox()
        Me.cboItTypeCd = New System.Windows.Forms.ComboBox()
        Me.cboItgroupcd = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfilament = New System.Windows.Forms.TextBox()
        Me.txtcount = New System.Windows.Forms.TextBox()
        Me.tooltipbuttonGenDesc = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cboItems = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cboUom2 = New System.Windows.Forms.ComboBox()
        Me.txtMaxQty = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtUprice_std = New System.Windows.Forms.TextBox()
        Me.txtReorderQTY = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboReorderUOM = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtsafety_stock = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtlead_time = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ErrorReorderUOM = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnfrmItemsCategory = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnSearchItem = New System.Windows.Forms.Button()
        Me.txtItemId = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorReorderUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtyarncode
        '
        Me.txtyarncode.BackColor = System.Drawing.Color.Gold
        Me.txtyarncode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyarncode.Location = New System.Drawing.Point(155, 61)
        Me.txtyarncode.Name = "txtyarncode"
        Me.txtyarncode.Size = New System.Drawing.Size(107, 20)
        Me.txtyarncode.TabIndex = 0
        '
        'txtdesc
        '
        Me.txtdesc.BackColor = System.Drawing.Color.Gold
        Me.txtdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc.Location = New System.Drawing.Point(136, 24)
        Me.txtdesc.Multiline = True
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(408, 42)
        Me.txtdesc.TabIndex = 0
        '
        'txtdesc2
        '
        Me.txtdesc2.BackColor = System.Drawing.Color.Gold
        Me.txtdesc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesc2.Location = New System.Drawing.Point(136, 72)
        Me.txtdesc2.Name = "txtdesc2"
        Me.txtdesc2.Size = New System.Drawing.Size(408, 20)
        Me.txtdesc2.TabIndex = 1
        '
        'txtdesct2
        '
        Me.txtdesct2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesct2.Location = New System.Drawing.Point(136, 193)
        Me.txtdesct2.Name = "txtdesct2"
        Me.txtdesct2.Size = New System.Drawing.Size(408, 20)
        Me.txtdesct2.TabIndex = 6
        '
        'txtdesct
        '
        Me.txtdesct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdesct.Location = New System.Drawing.Point(136, 169)
        Me.txtdesct.Name = "txtdesct"
        Me.txtdesct.Size = New System.Drawing.Size(408, 20)
        Me.txtdesct.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Yarn code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Description 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Description 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Description (Thai) 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Description (Thai) 1:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtDescSupp)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtDescSpec)
        Me.GroupBox1.Controls.Add(Me.buttonGenDesc)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtDesc3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtdesct2)
        Me.GroupBox1.Controls.Add(Me.txtdesct)
        Me.GroupBox1.Controls.Add(Me.txtdesc2)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 232)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Description:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 143)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 13)
        Me.Label22.TabIndex = 74
        Me.Label22.Text = "Description Supplier:"
        '
        'txtDescSupp
        '
        Me.txtDescSupp.BackColor = System.Drawing.Color.Gold
        Me.txtDescSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescSupp.Location = New System.Drawing.Point(136, 143)
        Me.txtDescSupp.Name = "txtDescSupp"
        Me.txtDescSupp.Size = New System.Drawing.Size(408, 20)
        Me.txtDescSupp.TabIndex = 4
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(24, 120)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "Description 4:"
        '
        'txtDescSpec
        '
        Me.txtDescSpec.BackColor = System.Drawing.Color.Gold
        Me.txtDescSpec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescSpec.Location = New System.Drawing.Point(136, 120)
        Me.txtDescSpec.Name = "txtDescSpec"
        Me.txtDescSpec.Size = New System.Drawing.Size(408, 20)
        Me.txtDescSpec.TabIndex = 3
        '
        'buttonGenDesc
        '
        Me.buttonGenDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonGenDesc.Image = CType(resources.GetObject("buttonGenDesc.Image"), System.Drawing.Image)
        Me.buttonGenDesc.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.buttonGenDesc.Location = New System.Drawing.Point(552, 24)
        Me.buttonGenDesc.Name = "buttonGenDesc"
        Me.buttonGenDesc.Size = New System.Drawing.Size(30, 28)
        Me.buttonGenDesc.TabIndex = 70
        Me.buttonGenDesc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.buttonGenDesc.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Description 3:"
        '
        'txtDesc3
        '
        Me.txtDesc3.BackColor = System.Drawing.Color.Gold
        Me.txtDesc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc3.Location = New System.Drawing.Point(136, 96)
        Me.txtDesc3.Name = "txtDesc3"
        Me.txtDesc3.Size = New System.Drawing.Size(408, 20)
        Me.txtDesc3.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbeam_length)
        Me.GroupBox2.Controls.Add(Me.lblBeamLength)
        Me.GroupBox2.Controls.Add(Me.txtbeams_per_set)
        Me.GroupBox2.Controls.Add(Me.txtwarped_ends)
        Me.GroupBox2.Controls.Add(Me.lblbeams_per_set)
        Me.GroupBox2.Controls.Add(Me.lblwarped_ends)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txttwists)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cbsuppcd)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cbitcatcd)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbitsubcatcd)
        Me.GroupBox2.Controls.Add(Me.cbitsubcd2)
        Me.GroupBox2.Controls.Add(Me.cbitsubcd)
        Me.GroupBox2.Controls.Add(Me.cboItTypeCd)
        Me.GroupBox2.Controls.Add(Me.cboItgroupcd)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtfilament)
        Me.GroupBox2.Controls.Add(Me.txtcount)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 341)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Yarn details"
        '
        'txtbeam_length
        '
        Me.txtbeam_length.Location = New System.Drawing.Point(136, 267)
        Me.txtbeam_length.Name = "txtbeam_length"
        Me.txtbeam_length.Size = New System.Drawing.Size(100, 22)
        Me.txtbeam_length.TabIndex = 75
        '
        'lblBeamLength
        '
        Me.lblBeamLength.AutoSize = True
        Me.lblBeamLength.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeamLength.Location = New System.Drawing.Point(24, 271)
        Me.lblBeamLength.Name = "lblBeamLength"
        Me.lblBeamLength.Size = New System.Drawing.Size(74, 13)
        Me.lblBeamLength.TabIndex = 74
        Me.lblBeamLength.Text = "Beam Length"
        '
        'txtbeams_per_set
        '
        Me.txtbeams_per_set.Location = New System.Drawing.Point(136, 316)
        Me.txtbeams_per_set.Name = "txtbeams_per_set"
        Me.txtbeams_per_set.Size = New System.Drawing.Size(64, 22)
        Me.txtbeams_per_set.TabIndex = 73
        '
        'txtwarped_ends
        '
        Me.txtwarped_ends.Location = New System.Drawing.Point(136, 293)
        Me.txtwarped_ends.Name = "txtwarped_ends"
        Me.txtwarped_ends.Size = New System.Drawing.Size(64, 22)
        Me.txtwarped_ends.TabIndex = 72
        '
        'lblbeams_per_set
        '
        Me.lblbeams_per_set.AutoSize = True
        Me.lblbeams_per_set.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbeams_per_set.Location = New System.Drawing.Point(24, 321)
        Me.lblbeams_per_set.Name = "lblbeams_per_set"
        Me.lblbeams_per_set.Size = New System.Drawing.Size(61, 13)
        Me.lblbeams_per_set.TabIndex = 71
        Me.lblbeams_per_set.Text = "Beam / Set"
        '
        'lblwarped_ends
        '
        Me.lblwarped_ends.AutoSize = True
        Me.lblwarped_ends.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwarped_ends.Location = New System.Drawing.Point(24, 296)
        Me.lblwarped_ends.Name = "lblwarped_ends"
        Me.lblwarped_ends.Size = New System.Drawing.Size(58, 13)
        Me.lblwarped_ends.TabIndex = 70
        Me.lblwarped_ends.Text = "Warp End"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "No. of yarn:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttwists
        '
        Me.txttwists.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttwists.Location = New System.Drawing.Point(136, 144)
        Me.txttwists.Name = "txttwists"
        Me.txttwists.Size = New System.Drawing.Size(100, 20)
        Me.txttwists.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(24, 240)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 67
        Me.Label14.Text = "Supplier:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbsuppcd
        '
        Me.cbsuppcd.BackColor = System.Drawing.Color.Gold
        Me.cbsuppcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbsuppcd.FormattingEnabled = True
        Me.cbsuppcd.Location = New System.Drawing.Point(136, 240)
        Me.cbsuppcd.Name = "cbsuppcd"
        Me.cbsuppcd.Size = New System.Drawing.Size(194, 21)
        Me.cbsuppcd.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Function:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Twist type:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbitcatcd
        '
        Me.cbitcatcd.BackColor = System.Drawing.Color.Gold
        Me.cbitcatcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbitcatcd.FormattingEnabled = True
        Me.cbitcatcd.Location = New System.Drawing.Point(136, 192)
        Me.cbitcatcd.Name = "cbitcatcd"
        Me.cbitcatcd.Size = New System.Drawing.Size(194, 21)
        Me.cbitcatcd.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Lustre:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Yarn form:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Yarn type:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Yarn group:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbitsubcatcd
        '
        Me.cbitsubcatcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbitsubcatcd.FormattingEnabled = True
        Me.cbitsubcatcd.Location = New System.Drawing.Point(136, 216)
        Me.cbitsubcatcd.Name = "cbitsubcatcd"
        Me.cbitsubcatcd.Size = New System.Drawing.Size(194, 21)
        Me.cbitsubcatcd.TabIndex = 8
        '
        'cbitsubcd2
        '
        Me.cbitsubcd2.BackColor = System.Drawing.Color.Gold
        Me.cbitsubcd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbitsubcd2.FormattingEnabled = True
        Me.cbitsubcd2.Location = New System.Drawing.Point(136, 168)
        Me.cbitsubcd2.Name = "cbitsubcd2"
        Me.cbitsubcd2.Size = New System.Drawing.Size(194, 21)
        Me.cbitsubcd2.TabIndex = 6
        '
        'cbitsubcd
        '
        Me.cbitsubcd.BackColor = System.Drawing.Color.Gold
        Me.cbitsubcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbitsubcd.FormattingEnabled = True
        Me.cbitsubcd.Location = New System.Drawing.Point(136, 72)
        Me.cbitsubcd.Name = "cbitsubcd"
        Me.cbitsubcd.Size = New System.Drawing.Size(194, 21)
        Me.cbitsubcd.TabIndex = 2
        '
        'cboItTypeCd
        '
        Me.cboItTypeCd.BackColor = System.Drawing.Color.Gold
        Me.cboItTypeCd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItTypeCd.FormattingEnabled = True
        Me.cboItTypeCd.Location = New System.Drawing.Point(136, 48)
        Me.cboItTypeCd.Name = "cboItTypeCd"
        Me.cboItTypeCd.Size = New System.Drawing.Size(194, 21)
        Me.cboItTypeCd.TabIndex = 1
        '
        'cboItgroupcd
        '
        Me.cboItgroupcd.BackColor = System.Drawing.Color.Gold
        Me.cboItgroupcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboItgroupcd.FormattingEnabled = True
        Me.cboItgroupcd.Location = New System.Drawing.Point(136, 24)
        Me.cboItgroupcd.Name = "cboItgroupcd"
        Me.cboItgroupcd.Size = New System.Drawing.Size(194, 21)
        Me.cboItgroupcd.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Filament:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Yarn count/Dinear:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtfilament
        '
        Me.txtfilament.BackColor = System.Drawing.Color.Gold
        Me.txtfilament.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfilament.Location = New System.Drawing.Point(136, 120)
        Me.txtfilament.Name = "txtfilament"
        Me.txtfilament.Size = New System.Drawing.Size(100, 20)
        Me.txtfilament.TabIndex = 4
        '
        'txtcount
        '
        Me.txtcount.BackColor = System.Drawing.Color.Gold
        Me.txtcount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcount.Location = New System.Drawing.Point(136, 96)
        Me.txtcount.Name = "txtcount"
        Me.txtcount.Size = New System.Drawing.Size(100, 20)
        Me.txtcount.TabIndex = 3
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cboItems
        '
        Me.cboItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItems.FormattingEnabled = True
        Me.cboItems.Location = New System.Drawing.Point(155, 37)
        Me.cboItems.Name = "cboItems"
        Me.cboItems.Size = New System.Drawing.Size(408, 21)
        Me.cboItems.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Choose from list:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(291, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(183, 13)
        Me.Label18.TabIndex = 72
        Me.Label18.Text = "<-To modify please enter the code"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.cboUom2)
        Me.GroupBox3.Controls.Add(Me.txtMaxQty)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtUprice_std)
        Me.GroupBox3.Controls.Add(Me.txtReorderQTY)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.cboReorderUOM)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(393, 325)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 164)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stock Level Control"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(11, 96)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(122, 13)
        Me.Label28.TabIndex = 79
        Me.Label28.Text = "Unit of Mesurement2 :"
        '
        'cboUom2
        '
        Me.cboUom2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUom2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUom2.FormattingEnabled = True
        Me.cboUom2.Location = New System.Drawing.Point(140, 93)
        Me.cboUom2.Name = "cboUom2"
        Me.cboUom2.Size = New System.Drawing.Size(84, 21)
        Me.cboUom2.TabIndex = 78
        '
        'txtMaxQty
        '
        Me.txtMaxQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxQty.Location = New System.Drawing.Point(140, 48)
        Me.txtMaxQty.Name = "txtMaxQty"
        Me.txtMaxQty.Size = New System.Drawing.Size(84, 20)
        Me.txtMaxQty.TabIndex = 1
        Me.txtMaxQty.Text = "0"
        Me.txtMaxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(11, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 13)
        Me.Label24.TabIndex = 70
        Me.Label24.Text = "Maximum Quantity :"
        '
        'txtUprice_std
        '
        Me.txtUprice_std.BackColor = System.Drawing.Color.Gold
        Me.txtUprice_std.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUprice_std.Location = New System.Drawing.Point(140, 120)
        Me.txtUprice_std.Name = "txtUprice_std"
        Me.txtUprice_std.Size = New System.Drawing.Size(84, 20)
        Me.txtUprice_std.TabIndex = 4
        '
        'txtReorderQTY
        '
        Me.txtReorderQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReorderQTY.Location = New System.Drawing.Point(140, 24)
        Me.txtReorderQTY.Name = "txtReorderQTY"
        Me.txtReorderQTY.Size = New System.Drawing.Size(84, 20)
        Me.txtReorderQTY.TabIndex = 0
        Me.txtReorderQTY.Text = "0"
        Me.txtReorderQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(11, 123)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(122, 13)
        Me.Label23.TabIndex = 77
        Me.Label23.Text = "Standard Price Per Kg :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 13)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Minimum Quantity :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 13)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "Unit of Mesurement :"
        '
        'cboReorderUOM
        '
        Me.cboReorderUOM.BackColor = System.Drawing.Color.Gold
        Me.cboReorderUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReorderUOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboReorderUOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReorderUOM.FormattingEnabled = True
        Me.cboReorderUOM.Location = New System.Drawing.Point(140, 72)
        Me.cboReorderUOM.Name = "cboReorderUOM"
        Me.cboReorderUOM.Size = New System.Drawing.Size(86, 21)
        Me.cboReorderUOM.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtsafety_stock)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.txtlead_time)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(639, 322)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 107)
        Me.GroupBox4.TabIndex = 82
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reorder Point"
        '
        'txtsafety_stock
        '
        Me.txtsafety_stock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtsafety_stock.Location = New System.Drawing.Point(116, 47)
        Me.txtsafety_stock.Name = "txtsafety_stock"
        Me.txtsafety_stock.Size = New System.Drawing.Size(78, 20)
        Me.txtsafety_stock.TabIndex = 82
        Me.txtsafety_stock.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 50)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 13)
        Me.Label26.TabIndex = 81
        Me.Label26.Text = "Safety Stock (Day)"
        '
        'txtlead_time
        '
        Me.txtlead_time.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtlead_time.Location = New System.Drawing.Point(116, 21)
        Me.txtlead_time.Name = "txtlead_time"
        Me.txtlead_time.Size = New System.Drawing.Size(78, 20)
        Me.txtlead_time.TabIndex = 80
        Me.txtlead_time.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(85, 13)
        Me.Label25.TabIndex = 79
        Me.Label25.Text = "Lead Time (Day)"
        '
        'ErrorReorderUOM
        '
        Me.ErrorReorderUOM.ContainerControl = Me
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.tsbtnSave, Me.tsbtnDelete, Me.tsbtnfrmItemsCategory, Me.tsbtnMinimized, Me.tsbtnExit, Me.ToolStripSeparator2, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(851, 25)
        Me.ToolStrip1.TabIndex = 83
        '
        'tsbtnNew
        '
        Me.tsbtnNew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnNew.Image = CType(resources.GetObject("tsbtnNew.Image"), System.Drawing.Image)
        Me.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNew.Name = "tsbtnNew"
        Me.tsbtnNew.Size = New System.Drawing.Size(50, 22)
        Me.tsbtnNew.Text = "New"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"), System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(50, 22)
        Me.tsbtnSave.Text = "Save"
        '
        'tsbtnDelete
        '
        Me.tsbtnDelete.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Cancel_16x
        Me.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDelete.Name = "tsbtnDelete"
        Me.tsbtnDelete.Size = New System.Drawing.Size(60, 22)
        Me.tsbtnDelete.Text = "Delete"
        '
        'tsbtnfrmItemsCategory
        '
        Me.tsbtnfrmItemsCategory.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnfrmItemsCategory.Image = CType(resources.GetObject("tsbtnfrmItemsCategory.Image"), System.Drawing.Image)
        Me.tsbtnfrmItemsCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnfrmItemsCategory.Name = "tsbtnfrmItemsCategory"
        Me.tsbtnfrmItemsCategory.Size = New System.Drawing.Size(124, 22)
        Me.tsbtnfrmItemsCategory.Text = "Inventory Category"
        '
        'tsbtnMinimized
        '
        Me.tsbtnMinimized.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnMinimized.Image = CType(resources.GetObject("tsbtnMinimized.Image"), System.Drawing.Image)
        Me.tsbtnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnMinimized.Name = "tsbtnMinimized"
        Me.tsbtnMinimized.Size = New System.Drawing.Size(80, 22)
        Me.tsbtnMinimized.Text = "Minimized"
        '
        'tsbtnExit
        '
        Me.tsbtnExit.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnExit.Image = CType(resources.GetObject("tsbtnExit.Image"), System.Drawing.Image)
        Me.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExit.Name = "tsbtnExit"
        Me.tsbtnExit.Size = New System.Drawing.Size(45, 22)
        Me.tsbtnExit.Text = "Exit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(329, 22)
        Me.ToolStripLabel2.Text = "*** หากต้องการลบ Yarn Master ต้องบอก Programmer เท่านั้น"
        '
        'btnSearchItem
        '
        Me.btnSearchItem.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Search_16x
        Me.btnSearchItem.Location = New System.Drawing.Point(268, 61)
        Me.btnSearchItem.Name = "btnSearchItem"
        Me.btnSearchItem.Size = New System.Drawing.Size(27, 22)
        Me.btnSearchItem.TabIndex = 74
        Me.btnSearchItem.UseVisualStyleBackColor = True
        '
        'txtItemId
        '
        Me.txtItemId.Enabled = False
        Me.txtItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemId.Location = New System.Drawing.Point(732, 64)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.ReadOnly = True
        Me.txtItemId.Size = New System.Drawing.Size(107, 20)
        Me.txtItemId.TabIndex = 85
        Me.txtItemId.TabStop = False
        Me.txtItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(684, 67)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(42, 13)
        Me.Label29.TabIndex = 84
        Me.Label29.Text = "Item Id"
        '
        'formYarnMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 675)
        Me.Controls.Add(Me.txtItemId)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnSearchItem)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cboItems)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtyarncode)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formYarnMaster"
        Me.Text = "Yarn Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrorReorderUOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtyarncode As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtdesc2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdesct2 As System.Windows.Forms.TextBox
    Friend WithEvents txtdesct As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txttwists As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbsuppcd As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbitcatcd As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbitsubcatcd As System.Windows.Forms.ComboBox
    Friend WithEvents cbitsubcd2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbitsubcd As System.Windows.Forms.ComboBox
    Friend WithEvents cboItTypeCd As System.Windows.Forms.ComboBox
    Friend WithEvents cboItgroupcd As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtfilament As System.Windows.Forms.TextBox
    Friend WithEvents txtcount As System.Windows.Forms.TextBox
    Friend WithEvents buttonGenDesc As System.Windows.Forms.Button
    Friend WithEvents tooltipbuttonGenDesc As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDesc3 As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cboItems As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReorderQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboReorderUOM As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtDescSpec As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchItem As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtDescSupp As System.Windows.Forms.TextBox
    Friend WithEvents txtUprice_std As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtMaxQty As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtbeams_per_set As System.Windows.Forms.TextBox
    Friend WithEvents txtwarped_ends As System.Windows.Forms.TextBox
    Friend WithEvents lblbeams_per_set As System.Windows.Forms.Label
    Friend WithEvents lblwarped_ends As System.Windows.Forms.Label
    Friend WithEvents txtbeam_length As System.Windows.Forms.TextBox
    Friend WithEvents lblBeamLength As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsafety_stock As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtlead_time As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ErrorReorderUOM As ErrorProvider
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbtnNew As ToolStripButton
    Friend WithEvents tsbtnSave As ToolStripButton
    Friend WithEvents tsbtnfrmItemsCategory As ToolStripButton
    Friend WithEvents tsbtnMinimized As ToolStripButton
    Friend WithEvents tsbtnExit As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Label28 As Label
    Friend WithEvents cboUom2 As ComboBox
    Friend WithEvents tsbtnDelete As ToolStripButton
    Friend WithEvents txtItemId As TextBox
    Friend WithEvents Label29 As Label
End Class
