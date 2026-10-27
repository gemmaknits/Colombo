<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchDebitNote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchDebitNote))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDesign_no = New System.Windows.Forms.Label()
        Me.txtDesign_no = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateFr = New System.Windows.Forms.DateTimePicker()
        Me.txtInvNo = New System.Windows.Forms.TextBox()
        Me.btnRefresh2 = New System.Windows.Forms.Button()
        Me.grdInv = New System.Windows.Forms.DataGridView()
        Me.dbnote_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dbnote_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_dbnote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Design_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDesign_no)
        Me.GroupBox1.Controls.Add(Me.txtDesign_no)
        Me.GroupBox1.Controls.Add(Me.btnRefresh2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpDateTo)
        Me.GroupBox1.Controls.Add(Me.dtpDateFr)
        Me.GroupBox1.Controls.Add(Me.txtInvNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 99)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'lblDesign_no
        '
        Me.lblDesign_no.AutoSize = True
        Me.lblDesign_no.Location = New System.Drawing.Point(33, 72)
        Me.lblDesign_no.Name = "lblDesign_no"
        Me.lblDesign_no.Size = New System.Drawing.Size(63, 13)
        Me.lblDesign_no.TabIndex = 19
        Me.lblDesign_no.Text = "Design. No."
        '
        'txtDesign_no
        '
        Me.txtDesign_no.Location = New System.Drawing.Point(97, 69)
        Me.txtDesign_no.Name = "txtDesign_no"
        Me.txtDesign_no.Size = New System.Drawing.Size(88, 20)
        Me.txtDesign_no.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Inv. No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Inv. Date"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(233, 19)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateTo.TabIndex = 14
        '
        'dtpDateFr
        '
        Me.dtpDateFr.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFr.Location = New System.Drawing.Point(97, 19)
        Me.dtpDateFr.Name = "dtpDateFr"
        Me.dtpDateFr.Size = New System.Drawing.Size(88, 20)
        Me.dtpDateFr.TabIndex = 13
        Me.dtpDateFr.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'txtInvNo
        '
        Me.txtInvNo.Location = New System.Drawing.Point(97, 43)
        Me.txtInvNo.Name = "txtInvNo"
        Me.txtInvNo.Size = New System.Drawing.Size(88, 20)
        Me.txtInvNo.TabIndex = 10
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Image = CType(resources.GetObject("btnRefresh2.Image"), System.Drawing.Image)
        Me.btnRefresh2.Location = New System.Drawing.Point(377, 15)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh2.TabIndex = 20
        Me.btnRefresh2.Text = "&Refresh"
        Me.btnRefresh2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh2.UseVisualStyleBackColor = True
        '
        'grdInv
        '
        Me.grdInv.AllowUserToAddRows = False
        Me.grdInv.AllowUserToDeleteRows = False
        Me.grdInv.AllowUserToOrderColumns = True
        Me.grdInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dbnote_no, Me.dbnote_date, Me.custname, Me.id_dbnote, Me.Design_no})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdInv.DefaultCellStyle = DataGridViewCellStyle1
        Me.grdInv.Location = New System.Drawing.Point(12, 160)
        Me.grdInv.Name = "grdInv"
        Me.grdInv.ReadOnly = True
        Me.grdInv.Size = New System.Drawing.Size(466, 213)
        Me.grdInv.TabIndex = 21
        '
        'dbnote_no
        '
        Me.dbnote_no.DataPropertyName = "dbnote_no"
        Me.dbnote_no.HeaderText = "Debit Note. No."
        Me.dbnote_no.Name = "dbnote_no"
        Me.dbnote_no.ReadOnly = True
        Me.dbnote_no.Width = 85
        '
        'dbnote_date
        '
        Me.dbnote_date.DataPropertyName = "dbnote_date"
        Me.dbnote_date.HeaderText = "Debit Note Date"
        Me.dbnote_date.Name = "dbnote_date"
        Me.dbnote_date.ReadOnly = True
        Me.dbnote_date.Width = 85
        '
        'custname
        '
        Me.custname.DataPropertyName = "custname"
        Me.custname.HeaderText = "Customer"
        Me.custname.Name = "custname"
        Me.custname.ReadOnly = True
        Me.custname.Width = 150
        '
        'id_dbnote
        '
        Me.id_dbnote.DataPropertyName = "id_dbnote"
        Me.id_dbnote.HeaderText = "Inv. ID"
        Me.id_dbnote.Name = "id_dbnote"
        Me.id_dbnote.ReadOnly = True
        Me.id_dbnote.Visible = False
        '
        'Design_no
        '
        Me.Design_no.DataPropertyName = "Design_no"
        Me.Design_no.HeaderText = "Design_no"
        Me.Design_no.Name = "Design_no"
        Me.Design_no.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 103)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(266, 50)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(29, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(219, 22)
        Me.txtSearch.TabIndex = 0
        '
        'frmSearchDebitNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 396)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grdInv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSearchDebitNote"
        Me.Text = "Search Debit Note"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDesign_no As System.Windows.Forms.Label
    Friend WithEvents txtDesign_no As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateFr As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtInvNo As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh2 As System.Windows.Forms.Button
    Friend WithEvents grdInv As System.Windows.Forms.DataGridView
    Friend WithEvents dbnote_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dbnote_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents custname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_dbnote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Design_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSearch As TextBox
End Class
