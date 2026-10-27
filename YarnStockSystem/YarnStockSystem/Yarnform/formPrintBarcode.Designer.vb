<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrintBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPrintBarcode))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btnsearch_yarn_in_by_itcd = New System.Windows.Forms.Button()
        Me.Btnsearch_yarn_in = New System.Windows.Forms.Button()
        Me.txtItcd_no = New System.Windows.Forms.TextBox()
        Me.txtYarn_in_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgYarn_in = New System.Windows.Forms.DataGridView()
        Me.DGV_Select = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.clmdocno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmitcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmboxno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmkg_nt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.lblSystemComment = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgYarn_in, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btnsearch_yarn_in_by_itcd)
        Me.GroupBox1.Controls.Add(Me.Btnsearch_yarn_in)
        Me.GroupBox1.Controls.Add(Me.txtItcd_no)
        Me.GroupBox1.Controls.Add(Me.txtYarn_in_no)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source Data"
        '
        'Btnsearch_yarn_in_by_itcd
        '
        Me.Btnsearch_yarn_in_by_itcd.Image = CType(resources.GetObject("Btnsearch_yarn_in_by_itcd.Image"), System.Drawing.Image)
        Me.Btnsearch_yarn_in_by_itcd.Location = New System.Drawing.Point(333, 52)
        Me.Btnsearch_yarn_in_by_itcd.Name = "Btnsearch_yarn_in_by_itcd"
        Me.Btnsearch_yarn_in_by_itcd.Size = New System.Drawing.Size(27, 23)
        Me.Btnsearch_yarn_in_by_itcd.TabIndex = 8
        Me.Btnsearch_yarn_in_by_itcd.UseVisualStyleBackColor = True
        '
        'Btnsearch_yarn_in
        '
        Me.Btnsearch_yarn_in.Image = CType(resources.GetObject("Btnsearch_yarn_in.Image"), System.Drawing.Image)
        Me.Btnsearch_yarn_in.Location = New System.Drawing.Point(333, 23)
        Me.Btnsearch_yarn_in.Name = "Btnsearch_yarn_in"
        Me.Btnsearch_yarn_in.Size = New System.Drawing.Size(27, 23)
        Me.Btnsearch_yarn_in.TabIndex = 7
        Me.Btnsearch_yarn_in.UseVisualStyleBackColor = True
        '
        'txtItcd_no
        '
        Me.txtItcd_no.Location = New System.Drawing.Point(127, 55)
        Me.txtItcd_no.Name = "txtItcd_no"
        Me.txtItcd_no.Size = New System.Drawing.Size(199, 20)
        Me.txtItcd_no.TabIndex = 6
        '
        'txtYarn_in_no
        '
        Me.txtYarn_in_no.Location = New System.Drawing.Point(127, 25)
        Me.txtYarn_in_no.Name = "txtYarn_in_no"
        Me.txtYarn_in_no.Size = New System.Drawing.Size(199, 20)
        Me.txtYarn_in_no.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Yarn code No :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Yarn-In No :"
        '
        'DgYarn_in
        '
        Me.DgYarn_in.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.DgYarn_in.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgYarn_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgYarn_in.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Select, Me.clmdocno, Me.clmitcd, Me.clmboxno, Me.clmkg_nt})
        Me.DgYarn_in.Location = New System.Drawing.Point(12, 146)
        Me.DgYarn_in.Name = "DgYarn_in"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DgYarn_in.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgYarn_in.Size = New System.Drawing.Size(602, 487)
        Me.DgYarn_in.TabIndex = 141
        '
        'DGV_Select
        '
        Me.DGV_Select.HeaderText = "*"
        Me.DGV_Select.Name = "DGV_Select"
        Me.DGV_Select.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGV_Select.Width = 25
        '
        'clmdocno
        '
        Me.clmdocno.DataPropertyName = "docno"
        Me.clmdocno.HeaderText = "Yarn-in No :"
        Me.clmdocno.Name = "clmdocno"
        Me.clmdocno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.clmdocno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.clmdocno.Width = 150
        '
        'clmitcd
        '
        Me.clmitcd.DataPropertyName = "itcd"
        Me.clmitcd.HeaderText = "Yarn-code No :"
        Me.clmitcd.Name = "clmitcd"
        Me.clmitcd.Width = 150
        '
        'clmboxno
        '
        Me.clmboxno.DataPropertyName = "boxno"
        Me.clmboxno.HeaderText = "Box No :"
        Me.clmboxno.Name = "clmboxno"
        Me.clmboxno.Width = 120
        '
        'clmkg_nt
        '
        Me.clmkg_nt.DataPropertyName = "kg_nt"
        Me.clmkg_nt.HeaderText = "Kgs"
        Me.clmkg_nt.Name = "clmkg_nt"
        Me.clmkg_nt.Width = 80
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnExit.Location = New System.Drawing.Point(544, 639)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 40)
        Me.btnExit.TabIndex = 143
        Me.btnExit.Text = "Exit"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnPrint.Location = New System.Drawing.Point(483, 639)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(55, 40)
        Me.btnPrint.TabIndex = 142
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(124, 116)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 24)
        Me.btnClear.TabIndex = 145
        Me.btnClear.Text = "Clear all"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectAll.Location = New System.Drawing.Point(12, 116)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(106, 24)
        Me.btnSelectAll.TabIndex = 144
        Me.btnSelectAll.Text = "SelectAll"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'lblSystemComment
        '
        Me.lblSystemComment.AutoSize = True
        Me.lblSystemComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSystemComment.ForeColor = System.Drawing.Color.Red
        Me.lblSystemComment.Location = New System.Drawing.Point(265, 122)
        Me.lblSystemComment.Name = "lblSystemComment"
        Me.lblSystemComment.Size = New System.Drawing.Size(270, 13)
        Me.lblSystemComment.TabIndex = 146
        Me.lblSystemComment.Text = "***โปรแกรมจะดึงข้อมูลตาม Yarn Stock Balance"
        '
        'formPrintBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 693)
        Me.Controls.Add(Me.lblSystemComment)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.DgYarn_in)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "formPrintBarcode"
        Me.Text = "PrintBarcode"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgYarn_in, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DgYarn_in As System.Windows.Forms.DataGridView
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents DGV_Select As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents clmdocno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmitcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmboxno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmkg_nt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtItcd_no As System.Windows.Forms.TextBox
    Friend WithEvents txtYarn_in_no As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents Btnsearch_yarn_in As System.Windows.Forms.Button
    Friend WithEvents Btnsearch_yarn_in_by_itcd As System.Windows.Forms.Button
    Friend WithEvents lblSystemComment As System.Windows.Forms.Label
End Class
