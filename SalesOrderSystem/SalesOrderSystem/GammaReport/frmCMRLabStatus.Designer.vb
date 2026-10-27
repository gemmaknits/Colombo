<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCMRLabStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCMRLabStatus))
        Me.dgvCMRLabStatus = New System.Windows.Forms.DataGridView()
        Me.colCMRNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCMRDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCMRRec = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEndBuyerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCMRHeaderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCMRLinesId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLineNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApprovedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colShadeApproved = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLabf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colShade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colColRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFirstSendDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRejectDate1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComment1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSendDateAfterRej1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRejectDate2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComment2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSendDateAfterRej2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRejectDate3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComment3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSendDateAfterRej3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRejectDate4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComment4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSendDateAfterRej4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRejectDate5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComment5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSendDateAfterRej5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRejectDate6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComment6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSendDateAfterRej6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExportExcel = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.dtpCMRDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpCMRDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCMRStatus = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslblTotalRowDataGrid = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        CType(Me.dgvCMRLabStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCMRLabStatus
        '
        Me.dgvCMRLabStatus.AllowUserToAddRows = False
        Me.dgvCMRLabStatus.AllowUserToDeleteRows = False
        Me.dgvCMRLabStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCMRLabStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCMRLabStatus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCMRNumber, Me.colCMRDate, Me.colCMRRec, Me.colEndBuyerName, Me.colCMRHeaderId, Me.colCMRLinesId, Me.colLineNum, Me.colColorName, Me.colApprovedDate, Me.colShadeApproved, Me.colColCode, Me.colLabf, Me.colShade, Me.colId, Me.colSta, Me.colComment, Me.colColRef, Me.colPta, Me.colAppDate, Me.colFirstSendDate, Me.colRejectDate1, Me.colComment1, Me.colSendDateAfterRej1, Me.colRejectDate2, Me.colComment2, Me.colSendDateAfterRej2, Me.colRejectDate3, Me.colComment3, Me.colSendDateAfterRej3, Me.colRejectDate4, Me.colComment4, Me.colSendDateAfterRej4, Me.colRejectDate5, Me.colComment5, Me.colSendDateAfterRej5, Me.colRejectDate6, Me.colComment6, Me.colSendDateAfterRej6})
        Me.dgvCMRLabStatus.Location = New System.Drawing.Point(12, 135)
        Me.dgvCMRLabStatus.Name = "dgvCMRLabStatus"
        Me.dgvCMRLabStatus.ReadOnly = True
        Me.dgvCMRLabStatus.Size = New System.Drawing.Size(1282, 447)
        Me.dgvCMRLabStatus.TabIndex = 0
        '
        'colCMRNumber
        '
        Me.colCMRNumber.DataPropertyName = "cmr_number"
        Me.colCMRNumber.HeaderText = "CMR No."
        Me.colCMRNumber.Name = "colCMRNumber"
        Me.colCMRNumber.ReadOnly = True
        '
        'colCMRDate
        '
        Me.colCMRDate.DataPropertyName = "cmr_date"
        Me.colCMRDate.HeaderText = "CMR Date"
        Me.colCMRDate.Name = "colCMRDate"
        Me.colCMRDate.ReadOnly = True
        '
        'colCMRRec
        '
        Me.colCMRRec.DataPropertyName = "cmrrec"
        Me.colCMRRec.HeaderText = "CMR Rec"
        Me.colCMRRec.Name = "colCMRRec"
        Me.colCMRRec.ReadOnly = True
        '
        'colEndBuyerName
        '
        Me.colEndBuyerName.DataPropertyName = "end_buyer_name"
        Me.colEndBuyerName.HeaderText = "End Buyer Name"
        Me.colEndBuyerName.Name = "colEndBuyerName"
        Me.colEndBuyerName.ReadOnly = True
        '
        'colCMRHeaderId
        '
        Me.colCMRHeaderId.DataPropertyName = "cmr_header_id"
        Me.colCMRHeaderId.HeaderText = "CMR Header ID"
        Me.colCMRHeaderId.Name = "colCMRHeaderId"
        Me.colCMRHeaderId.ReadOnly = True
        Me.colCMRHeaderId.Visible = False
        '
        'colCMRLinesId
        '
        Me.colCMRLinesId.DataPropertyName = "cmr_lines_id"
        Me.colCMRLinesId.HeaderText = "CMR Lines ID"
        Me.colCMRLinesId.Name = "colCMRLinesId"
        Me.colCMRLinesId.ReadOnly = True
        Me.colCMRLinesId.Visible = False
        '
        'colLineNum
        '
        Me.colLineNum.DataPropertyName = "line_num"
        Me.colLineNum.HeaderText = "Line Num"
        Me.colLineNum.Name = "colLineNum"
        Me.colLineNum.ReadOnly = True
        Me.colLineNum.Visible = False
        '
        'colColorName
        '
        Me.colColorName.DataPropertyName = "color_name"
        Me.colColorName.HeaderText = "Color Name"
        Me.colColorName.Name = "colColorName"
        Me.colColorName.ReadOnly = True
        '
        'colApprovedDate
        '
        Me.colApprovedDate.DataPropertyName = "approved_date"
        Me.colApprovedDate.HeaderText = "Approved Date"
        Me.colApprovedDate.Name = "colApprovedDate"
        Me.colApprovedDate.ReadOnly = True
        '
        'colShadeApproved
        '
        Me.colShadeApproved.DataPropertyName = "shade_approved"
        Me.colShadeApproved.HeaderText = "Shade Approved"
        Me.colShadeApproved.Name = "colShadeApproved"
        Me.colShadeApproved.ReadOnly = True
        '
        'colColCode
        '
        Me.colColCode.DataPropertyName = "colcode"
        Me.colColCode.HeaderText = "Col Code"
        Me.colColCode.Name = "colColCode"
        Me.colColCode.ReadOnly = True
        '
        'colLabf
        '
        Me.colLabf.DataPropertyName = "labf"
        Me.colLabf.HeaderText = "Lab F"
        Me.colLabf.Name = "colLabf"
        Me.colLabf.ReadOnly = True
        '
        'colShade
        '
        Me.colShade.DataPropertyName = "shade"
        Me.colShade.HeaderText = "Shade"
        Me.colShade.Name = "colShade"
        Me.colShade.ReadOnly = True
        '
        'colId
        '
        Me.colId.DataPropertyName = "id"
        Me.colId.HeaderText = "Id"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        Me.colId.Visible = False
        '
        'colSta
        '
        Me.colSta.DataPropertyName = "sta"
        Me.colSta.HeaderText = "Status"
        Me.colSta.Name = "colSta"
        Me.colSta.ReadOnly = True
        '
        'colComment
        '
        Me.colComment.DataPropertyName = "comment"
        Me.colComment.HeaderText = "Comment"
        Me.colComment.Name = "colComment"
        Me.colComment.ReadOnly = True
        '
        'colColRef
        '
        Me.colColRef.DataPropertyName = "colref"
        Me.colColRef.HeaderText = "Col Ref"
        Me.colColRef.Name = "colColRef"
        Me.colColRef.ReadOnly = True
        '
        'colPta
        '
        Me.colPta.DataPropertyName = "pa"
        Me.colPta.HeaderText = "PTA"
        Me.colPta.Name = "colPta"
        Me.colPta.ReadOnly = True
        '
        'colAppDate
        '
        Me.colAppDate.DataPropertyName = "AppDate"
        Me.colAppDate.HeaderText = "App Date"
        Me.colAppDate.Name = "colAppDate"
        Me.colAppDate.ReadOnly = True
        '
        'colFirstSendDate
        '
        Me.colFirstSendDate.DataPropertyName = "first_send_date"
        Me.colFirstSendDate.HeaderText = "First Send Date"
        Me.colFirstSendDate.Name = "colFirstSendDate"
        Me.colFirstSendDate.ReadOnly = True
        '
        'colRejectDate1
        '
        Me.colRejectDate1.DataPropertyName = "rej_date1"
        Me.colRejectDate1.HeaderText = "Reject Date 1"
        Me.colRejectDate1.Name = "colRejectDate1"
        Me.colRejectDate1.ReadOnly = True
        '
        'colComment1
        '
        Me.colComment1.DataPropertyName = "Comment1"
        Me.colComment1.HeaderText = "Comment 1"
        Me.colComment1.Name = "colComment1"
        Me.colComment1.ReadOnly = True
        '
        'colSendDateAfterRej1
        '
        Me.colSendDateAfterRej1.DataPropertyName = "Send_date1"
        Me.colSendDateAfterRej1.HeaderText = "Send Date After Rej 1"
        Me.colSendDateAfterRej1.Name = "colSendDateAfterRej1"
        Me.colSendDateAfterRej1.ReadOnly = True
        '
        'colRejectDate2
        '
        Me.colRejectDate2.DataPropertyName = "rej_date2"
        Me.colRejectDate2.HeaderText = "Reject Date 2"
        Me.colRejectDate2.Name = "colRejectDate2"
        Me.colRejectDate2.ReadOnly = True
        '
        'colComment2
        '
        Me.colComment2.DataPropertyName = "Comment2"
        Me.colComment2.HeaderText = "Comment 2"
        Me.colComment2.Name = "colComment2"
        Me.colComment2.ReadOnly = True
        '
        'colSendDateAfterRej2
        '
        Me.colSendDateAfterRej2.DataPropertyName = "Send_date2"
        Me.colSendDateAfterRej2.HeaderText = "Send Date After Rej 2"
        Me.colSendDateAfterRej2.Name = "colSendDateAfterRej2"
        Me.colSendDateAfterRej2.ReadOnly = True
        '
        'colRejectDate3
        '
        Me.colRejectDate3.DataPropertyName = "rej_date3"
        Me.colRejectDate3.HeaderText = "Reject Date 3"
        Me.colRejectDate3.Name = "colRejectDate3"
        Me.colRejectDate3.ReadOnly = True
        '
        'colComment3
        '
        Me.colComment3.DataPropertyName = "Comment3"
        Me.colComment3.HeaderText = "Comment 3"
        Me.colComment3.Name = "colComment3"
        Me.colComment3.ReadOnly = True
        '
        'colSendDateAfterRej3
        '
        Me.colSendDateAfterRej3.DataPropertyName = "Send_date3"
        Me.colSendDateAfterRej3.HeaderText = "Send Date After Rej 3"
        Me.colSendDateAfterRej3.Name = "colSendDateAfterRej3"
        Me.colSendDateAfterRej3.ReadOnly = True
        '
        'colRejectDate4
        '
        Me.colRejectDate4.DataPropertyName = "rej_date4"
        Me.colRejectDate4.HeaderText = "Reject Date 4"
        Me.colRejectDate4.Name = "colRejectDate4"
        Me.colRejectDate4.ReadOnly = True
        '
        'colComment4
        '
        Me.colComment4.DataPropertyName = "Comment4"
        Me.colComment4.HeaderText = "Comment 4"
        Me.colComment4.Name = "colComment4"
        Me.colComment4.ReadOnly = True
        '
        'colSendDateAfterRej4
        '
        Me.colSendDateAfterRej4.DataPropertyName = "Send_date4"
        Me.colSendDateAfterRej4.HeaderText = "Send Date After Rej 4"
        Me.colSendDateAfterRej4.Name = "colSendDateAfterRej4"
        Me.colSendDateAfterRej4.ReadOnly = True
        '
        'colRejectDate5
        '
        Me.colRejectDate5.DataPropertyName = "rej_date5"
        Me.colRejectDate5.HeaderText = "Reject Date 5"
        Me.colRejectDate5.Name = "colRejectDate5"
        Me.colRejectDate5.ReadOnly = True
        '
        'colComment5
        '
        Me.colComment5.DataPropertyName = "Comment5"
        Me.colComment5.HeaderText = "Comment 5"
        Me.colComment5.Name = "colComment5"
        Me.colComment5.ReadOnly = True
        '
        'colSendDateAfterRej5
        '
        Me.colSendDateAfterRej5.DataPropertyName = "Send_date5"
        Me.colSendDateAfterRej5.HeaderText = "Send Date After Rej 5"
        Me.colSendDateAfterRej5.Name = "colSendDateAfterRej5"
        Me.colSendDateAfterRej5.ReadOnly = True
        '
        'colRejectDate6
        '
        Me.colRejectDate6.DataPropertyName = "rej_date6"
        Me.colRejectDate6.HeaderText = "Reject Date 6"
        Me.colRejectDate6.Name = "colRejectDate6"
        Me.colRejectDate6.ReadOnly = True
        '
        'colComment6
        '
        Me.colComment6.DataPropertyName = "Comment6"
        Me.colComment6.HeaderText = "Comment 6"
        Me.colComment6.Name = "colComment6"
        Me.colComment6.ReadOnly = True
        '
        'colSendDateAfterRej6
        '
        Me.colSendDateAfterRej6.DataPropertyName = "Send_date6"
        Me.colSendDateAfterRej6.HeaderText = "Send Date After Rej 6"
        Me.colSendDateAfterRej6.Name = "colSendDateAfterRej6"
        Me.colSendDateAfterRej6.ReadOnly = True
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportExcel.Image = Global.SalesOrderSystem.My.Resources.Resources.ExcelWorksheetView_16x
        Me.btnExportExcel.Location = New System.Drawing.Point(459, 106)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(60, 23)
        Me.btnExportExcel.TabIndex = 2
        Me.btnExportExcel.Text = "Excel"
        Me.btnExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExportExcel.UseVisualStyleBackColor = True
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Image = Global.SalesOrderSystem.My.Resources.Resources.Filter_16x
        Me.btnFilter.Location = New System.Drawing.Point(220, 27)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(63, 23)
        Me.btnFilter.TabIndex = 1
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'dtpCMRDateTo
        '
        Me.dtpCMRDateTo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCMRDateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCMRDateTo.Location = New System.Drawing.Point(93, 54)
        Me.dtpCMRDateTo.Name = "dtpCMRDateTo"
        Me.dtpCMRDateTo.Size = New System.Drawing.Size(121, 22)
        Me.dtpCMRDateTo.TabIndex = 36
        '
        'dtpCMRDateFrom
        '
        Me.dtpCMRDateFrom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCMRDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCMRDateFrom.Location = New System.Drawing.Point(93, 28)
        Me.dtpCMRDateFrom.Name = "dtpCMRDateFrom"
        Me.dtpCMRDateFrom.Size = New System.Drawing.Size(121, 22)
        Me.dtpCMRDateFrom.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Date From :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Date To :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Status :"
        '
        'cboCMRStatus
        '
        Me.cboCMRStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCMRStatus.FormattingEnabled = True
        Me.cboCMRStatus.Location = New System.Drawing.Point(93, 80)
        Me.cboCMRStatus.Name = "cboCMRStatus"
        Me.cboCMRStatus.Size = New System.Drawing.Size(121, 21)
        Me.cboCMRStatus.TabIndex = 40
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1306, 25)
        Me.ToolStrip1.TabIndex = 41
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.tslblTotalRowDataGrid})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 585)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1306, 22)
        Me.StatusStrip1.TabIndex = 42
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel1.Text = "Total:"
        '
        'tslblTotalRowDataGrid
        '
        Me.tslblTotalRowDataGrid.Name = "tslblTotalRowDataGrid"
        Me.tslblTotalRowDataGrid.Size = New System.Drawing.Size(0, 17)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Filter :"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(93, 107)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(360, 22)
        Me.txtFilter.TabIndex = 45
        '
        'frmCMRLabStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1306, 607)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cboCMRStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpCMRDateTo)
        Me.Controls.Add(Me.dtpCMRDateFrom)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.dgvCMRLabStatus)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmCMRLabStatus"
        Me.Text = "CMR Lab Status"
        CType(Me.dgvCMRLabStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCMRLabStatus As DataGridView
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnExportExcel As Button
    Friend WithEvents dtpCMRDateTo As DateTimePicker
    Friend WithEvents dtpCMRDateFrom As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCMRStatus As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tslblTotalRowDataGrid As ToolStripStatusLabel
    Friend WithEvents colCMRNumber As DataGridViewTextBoxColumn
    Friend WithEvents colCMRDate As DataGridViewTextBoxColumn
    Friend WithEvents colCMRRec As DataGridViewTextBoxColumn
    Friend WithEvents colEndBuyerName As DataGridViewTextBoxColumn
    Friend WithEvents colCMRHeaderId As DataGridViewTextBoxColumn
    Friend WithEvents colCMRLinesId As DataGridViewTextBoxColumn
    Friend WithEvents colLineNum As DataGridViewTextBoxColumn
    Friend WithEvents colColorName As DataGridViewTextBoxColumn
    Friend WithEvents colApprovedDate As DataGridViewTextBoxColumn
    Friend WithEvents colShadeApproved As DataGridViewTextBoxColumn
    Friend WithEvents colColCode As DataGridViewTextBoxColumn
    Friend WithEvents colLabf As DataGridViewTextBoxColumn
    Friend WithEvents colShade As DataGridViewTextBoxColumn
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colSta As DataGridViewTextBoxColumn
    Friend WithEvents colComment As DataGridViewTextBoxColumn
    Friend WithEvents colColRef As DataGridViewTextBoxColumn
    Friend WithEvents colPta As DataGridViewTextBoxColumn
    Friend WithEvents colAppDate As DataGridViewTextBoxColumn
    Friend WithEvents colFirstSendDate As DataGridViewTextBoxColumn
    Friend WithEvents colRejectDate1 As DataGridViewTextBoxColumn
    Friend WithEvents colComment1 As DataGridViewTextBoxColumn
    Friend WithEvents colSendDateAfterRej1 As DataGridViewTextBoxColumn
    Friend WithEvents colRejectDate2 As DataGridViewTextBoxColumn
    Friend WithEvents colComment2 As DataGridViewTextBoxColumn
    Friend WithEvents colSendDateAfterRej2 As DataGridViewTextBoxColumn
    Friend WithEvents colRejectDate3 As DataGridViewTextBoxColumn
    Friend WithEvents colComment3 As DataGridViewTextBoxColumn
    Friend WithEvents colSendDateAfterRej3 As DataGridViewTextBoxColumn
    Friend WithEvents colRejectDate4 As DataGridViewTextBoxColumn
    Friend WithEvents colComment4 As DataGridViewTextBoxColumn
    Friend WithEvents colSendDateAfterRej4 As DataGridViewTextBoxColumn
    Friend WithEvents colRejectDate5 As DataGridViewTextBoxColumn
    Friend WithEvents colComment5 As DataGridViewTextBoxColumn
    Friend WithEvents colSendDateAfterRej5 As DataGridViewTextBoxColumn
    Friend WithEvents colRejectDate6 As DataGridViewTextBoxColumn
    Friend WithEvents colComment6 As DataGridViewTextBoxColumn
    Friend WithEvents colSendDateAfterRej6 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFilter As TextBox
End Class
