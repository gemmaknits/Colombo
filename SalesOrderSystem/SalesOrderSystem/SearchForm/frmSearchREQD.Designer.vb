<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchREQD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchREQD))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.outreqno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outreqdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.outreqtypname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LbDoctype = New System.Windows.Forms.Label()
        Me.btnok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboDoc_type = New System.Windows.Forms.ComboBox()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.txtReqNo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(414, 439)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 23)
        Me.btnExit.TabIndex = 46
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.AllowUserToOrderColumns = True
        Me.grdData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdData.ColumnHeadersHeight = 30
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.outreqno, Me.outreqdt, Me.outreqtypname, Me.custname})
        Me.grdData.Location = New System.Drawing.Point(28, 152)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.Size = New System.Drawing.Size(480, 281)
        Me.grdData.TabIndex = 44
        '
        'outreqno
        '
        Me.outreqno.DataPropertyName = "outreqno"
        Me.outreqno.HeaderText = "Req. No."
        Me.outreqno.Name = "outreqno"
        Me.outreqno.ReadOnly = True
        Me.outreqno.Width = 80
        '
        'outreqdt
        '
        Me.outreqdt.DataPropertyName = "outreqdt2"
        Me.outreqdt.HeaderText = "Req. Date"
        Me.outreqdt.Name = "outreqdt"
        Me.outreqdt.ReadOnly = True
        Me.outreqdt.Width = 80
        '
        'outreqtypname
        '
        Me.outreqtypname.DataPropertyName = "outreqtypname"
        Me.outreqtypname.HeaderText = "Type"
        Me.outreqtypname.Name = "outreqtypname"
        Me.outreqtypname.ReadOnly = True
        Me.outreqtypname.Width = 70
        '
        'custname
        '
        Me.custname.DataPropertyName = "custname"
        Me.custname.HeaderText = "Customer"
        Me.custname.Name = "custname"
        Me.custname.ReadOnly = True
        Me.custname.Width = 200
        '
        'LbDoctype
        '
        Me.LbDoctype.AutoSize = True
        Me.LbDoctype.Location = New System.Drawing.Point(12, 105)
        Me.LbDoctype.Name = "LbDoctype"
        Me.LbDoctype.Size = New System.Drawing.Size(104, 13)
        Me.LbDoctype.TabIndex = 72
        Me.LbDoctype.Text = "Fabric delivery for :"
        '
        'btnok
        '
        Me.btnok.Location = New System.Drawing.Point(318, 439)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(90, 23)
        Me.btnok.TabIndex = 45
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Customer"
        '
        'CboDoc_type
        '
        Me.CboDoc_type.FormattingEnabled = True
        Me.CboDoc_type.Location = New System.Drawing.Point(114, 101)
        Me.CboDoc_type.Name = "CboDoc_type"
        Me.CboDoc_type.Size = New System.Drawing.Size(121, 21)
        Me.CboDoc_type.TabIndex = 71
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
        Me.btnRefresh2.Location = New System.Drawing.Point(386, 19)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh2.TabIndex = 38
        Me.btnRefresh2.Text = "&Refresh"
        Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(114, 16)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(224, 21)
        Me.cboCustomer.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Req No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "To"
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(114, 51)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateFr.TabIndex = 13
        '
        'txtReqNo
        '
        Me.txtReqNo.Location = New System.Drawing.Point(114, 75)
        Me.txtReqNo.Name = "txtReqNo"
        Me.txtReqNo.Size = New System.Drawing.Size(88, 22)
        Me.txtReqNo.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LbDoctype)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CboDoc_type)
        Me.GroupBox1.Controls.Add(Me.btnRefresh2)
        Me.GroupBox1.Controls.Add(Me.cboCustomer)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.txtReqNo)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 138)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Req Date"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(250, 51)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 22)
        Me.dtpDateTo.TabIndex = 14
        '
        'frmSearchREQD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 470)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmSearchREQD"
        Me.Text = "Search Request Dyed"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents grdData As DataGridView
    Friend WithEvents outreqno As DataGridViewTextBoxColumn
    Friend WithEvents outreqdt As DataGridViewTextBoxColumn
    Friend WithEvents outreqtypname As DataGridViewTextBoxColumn
    Friend WithEvents custname As DataGridViewTextBoxColumn
    Friend WithEvents LbDoctype As Label
    Friend WithEvents btnok As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CboDoc_type As ComboBox
    Friend WithEvents btnRefresh2 As Button
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDateFr As DateTimePicker
    Friend WithEvents txtReqNo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDateTo As DateTimePicker
End Class
