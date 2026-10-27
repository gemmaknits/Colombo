<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchDyedRoll
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtWordFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.roll_no_d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dinno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.refdesno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.compo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custcolor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gmpersqm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fwth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESIGN_APPL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Treatment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtWordFilter)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 52)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filler"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'txtWordFilter
        '
        Me.txtWordFilter.Location = New System.Drawing.Point(105, 19)
        Me.txtWordFilter.Name = "txtWordFilter"
        Me.txtWordFilter.Size = New System.Drawing.Size(152, 20)
        Me.txtWordFilter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Wording"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdData)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(923, 345)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.roll_no_d, Me.dinno, Me.design_no, Me.refdesno, Me.compo, Me.col, Me.custcolor, Me.gmpersqm, Me.Fwth, Me.DESIGN_APPL, Me.Treatment})
        Me.grdData.Location = New System.Drawing.Point(17, 19)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.Size = New System.Drawing.Size(888, 317)
        Me.grdData.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(779, 421)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(860, 421)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'roll_no_d
        '
        Me.roll_no_d.DataPropertyName = "roll_no_d"
        Me.roll_no_d.HeaderText = "Roll No"
        Me.roll_no_d.Name = "roll_no_d"
        Me.roll_no_d.ReadOnly = True
        Me.roll_no_d.Width = 80
        '
        'dinno
        '
        Me.dinno.DataPropertyName = "dinno"
        Me.dinno.HeaderText = "Dyed In"
        Me.dinno.Name = "dinno"
        Me.dinno.ReadOnly = True
        Me.dinno.Width = 80
        '
        'design_no
        '
        Me.design_no.DataPropertyName = "design_no"
        Me.design_no.HeaderText = "Design No"
        Me.design_no.Name = "design_no"
        Me.design_no.ReadOnly = True
        Me.design_no.Width = 80
        '
        'refdesno
        '
        Me.refdesno.DataPropertyName = "refdesno"
        Me.refdesno.HeaderText = "Description"
        Me.refdesno.Name = "refdesno"
        Me.refdesno.ReadOnly = True
        Me.refdesno.Width = 150
        '
        'compo
        '
        Me.compo.DataPropertyName = "compo"
        Me.compo.HeaderText = "Compo"
        Me.compo.Name = "compo"
        Me.compo.ReadOnly = True
        Me.compo.Width = 150
        '
        'col
        '
        Me.col.DataPropertyName = "col"
        Me.col.HeaderText = "Color"
        Me.col.Name = "col"
        Me.col.ReadOnly = True
        '
        'custcolor
        '
        Me.custcolor.DataPropertyName = "custcolor"
        Me.custcolor.HeaderText = "Cust Color"
        Me.custcolor.Name = "custcolor"
        Me.custcolor.ReadOnly = True
        '
        'gmpersqm
        '
        Me.gmpersqm.DataPropertyName = "gmpersqm"
        Me.gmpersqm.HeaderText = "Weight"
        Me.gmpersqm.Name = "gmpersqm"
        Me.gmpersqm.ReadOnly = True
        Me.gmpersqm.Width = 60
        '
        'Fwth
        '
        Me.Fwth.DataPropertyName = "Fwth"
        Me.Fwth.HeaderText = "Width"
        Me.Fwth.Name = "Fwth"
        Me.Fwth.ReadOnly = True
        Me.Fwth.Width = 60
        '
        'DESIGN_APPL
        '
        Me.DESIGN_APPL.DataPropertyName = "DESIGN_APPL"
        Me.DESIGN_APPL.HeaderText = "Design App"
        Me.DESIGN_APPL.Name = "DESIGN_APPL"
        Me.DESIGN_APPL.ReadOnly = True
        '
        'Treatment
        '
        Me.Treatment.DataPropertyName = "Treatment"
        Me.Treatment.HeaderText = "Treatment"
        Me.Treatment.Name = "Treatment"
        Me.Treatment.ReadOnly = True
        Me.Treatment.Width = 200
        '
        'frmSearchDyedRoll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 456)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSearchDyedRoll"
        Me.Text = "Search Dyed Roll"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtWordFilter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grdData As DataGridView
    Friend WithEvents btnOk As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents roll_no_d As DataGridViewTextBoxColumn
    Friend WithEvents dinno As DataGridViewTextBoxColumn
    Friend WithEvents design_no As DataGridViewTextBoxColumn
    Friend WithEvents refdesno As DataGridViewTextBoxColumn
    Friend WithEvents compo As DataGridViewTextBoxColumn
    Friend WithEvents col As DataGridViewTextBoxColumn
    Friend WithEvents custcolor As DataGridViewTextBoxColumn
    Friend WithEvents gmpersqm As DataGridViewTextBoxColumn
    Friend WithEvents Fwth As DataGridViewTextBoxColumn
    Friend WithEvents DESIGN_APPL As DataGridViewTextBoxColumn
    Friend WithEvents Treatment As DataGridViewTextBoxColumn
End Class
