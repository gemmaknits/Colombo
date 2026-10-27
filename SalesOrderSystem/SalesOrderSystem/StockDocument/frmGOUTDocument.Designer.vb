<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGOUTDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGOUTDocument))
        Me.chkOutdt = New System.Windows.Forms.CheckBox()
        Me.chkOutno = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDINNOFR = New System.Windows.Forms.Label()
        Me.btnSearchOutnofr = New System.Windows.Forms.Button()
        Me.txtOUTNOFR = New System.Windows.Forms.TextBox()
        Me.btnSearchOutnoto = New System.Windows.Forms.Button()
        Me.lblDINNOTO = New System.Windows.Forms.Label()
        Me.txtOUTNOTO = New System.Windows.Forms.TextBox()
        Me.dtpoutdtfr = New System.Windows.Forms.DateTimePicker()
        Me.dtpoutdtto = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkOutdt
        '
        Me.chkOutdt.AutoSize = True
        Me.chkOutdt.Location = New System.Drawing.Point(6, 0)
        Me.chkOutdt.Name = "chkOutdt"
        Me.chkOutdt.Size = New System.Drawing.Size(103, 17)
        Me.chkOutdt.TabIndex = 215
        Me.chkOutdt.Text = "Greige Out Date"
        Me.chkOutdt.UseVisualStyleBackColor = True
        '
        'chkOutno
        '
        Me.chkOutno.AutoSize = True
        Me.chkOutno.Location = New System.Drawing.Point(0, 0)
        Me.chkOutno.Name = "chkOutno"
        Me.chkOutno.Size = New System.Drawing.Size(97, 17)
        Me.chkOutno.TabIndex = 211
        Me.chkOutno.Text = "Greige Out No."
        Me.chkOutno.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkOutno)
        Me.GroupBox1.Controls.Add(Me.lblDINNOFR)
        Me.GroupBox1.Controls.Add(Me.btnSearchOutnofr)
        Me.GroupBox1.Controls.Add(Me.txtOUTNOFR)
        Me.GroupBox1.Controls.Add(Me.btnSearchOutnoto)
        Me.GroupBox1.Controls.Add(Me.lblDINNOTO)
        Me.GroupBox1.Controls.Add(Me.txtOUTNOTO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 76)
        Me.GroupBox1.TabIndex = 218
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Greige Out No."
        '
        'lblDINNOFR
        '
        Me.lblDINNOFR.AutoSize = True
        Me.lblDINNOFR.Location = New System.Drawing.Point(12, 37)
        Me.lblDINNOFR.Name = "lblDINNOFR"
        Me.lblDINNOFR.Size = New System.Drawing.Size(30, 13)
        Me.lblDINNOFR.TabIndex = 206
        Me.lblDINNOFR.Text = "From"
        '
        'btnSearchOutnofr
        '
        Me.btnSearchOutnofr.Image = CType(resources.GetObject("btnSearchOutnofr.Image"), System.Drawing.Image)
        Me.btnSearchOutnofr.Location = New System.Drawing.Point(170, 32)
        Me.btnSearchOutnofr.Name = "btnSearchOutnofr"
        Me.btnSearchOutnofr.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutnofr.TabIndex = 207
        Me.btnSearchOutnofr.Text = "PackingList Dyes & Out"
        Me.btnSearchOutnofr.UseVisualStyleBackColor = True
        '
        'txtOUTNOFR
        '
        Me.txtOUTNOFR.Location = New System.Drawing.Point(57, 34)
        Me.txtOUTNOFR.Name = "txtOUTNOFR"
        Me.txtOUTNOFR.Size = New System.Drawing.Size(104, 20)
        Me.txtOUTNOFR.TabIndex = 204
        '
        'btnSearchOutnoto
        '
        Me.btnSearchOutnoto.Image = CType(resources.GetObject("btnSearchOutnoto.Image"), System.Drawing.Image)
        Me.btnSearchOutnoto.Location = New System.Drawing.Point(334, 31)
        Me.btnSearchOutnoto.Name = "btnSearchOutnoto"
        Me.btnSearchOutnoto.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutnoto.TabIndex = 210
        Me.btnSearchOutnoto.Text = "PackingList Dyes & Out"
        Me.btnSearchOutnoto.UseVisualStyleBackColor = True
        '
        'lblDINNOTO
        '
        Me.lblDINNOTO.AutoSize = True
        Me.lblDINNOTO.Location = New System.Drawing.Point(206, 41)
        Me.lblDINNOTO.Name = "lblDINNOTO"
        Me.lblDINNOTO.Size = New System.Drawing.Size(20, 13)
        Me.lblDINNOTO.TabIndex = 209
        Me.lblDINNOTO.Text = "To"
        '
        'txtOUTNOTO
        '
        Me.txtOUTNOTO.Location = New System.Drawing.Point(232, 34)
        Me.txtOUTNOTO.Name = "txtOUTNOTO"
        Me.txtOUTNOTO.Size = New System.Drawing.Size(96, 20)
        Me.txtOUTNOTO.TabIndex = 208
        '
        'dtpoutdtfr
        '
        Me.dtpoutdtfr.CustomFormat = "dd/MM/yyyy"
        Me.dtpoutdtfr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpoutdtfr.Location = New System.Drawing.Point(56, 28)
        Me.dtpoutdtfr.Name = "dtpoutdtfr"
        Me.dtpoutdtfr.Size = New System.Drawing.Size(104, 20)
        Me.dtpoutdtfr.TabIndex = 211
        Me.dtpoutdtfr.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'dtpoutdtto
        '
        Me.dtpoutdtto.CustomFormat = "dd/MM/yyyy"
        Me.dtpoutdtto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpoutdtto.Location = New System.Drawing.Point(231, 28)
        Me.dtpoutdtto.Name = "dtpoutdtto"
        Me.dtpoutdtto.Size = New System.Drawing.Size(96, 20)
        Me.dtpoutdtto.TabIndex = 212
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 213
        Me.Label2.Text = "From"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkOutdt)
        Me.GroupBox2.Controls.Add(Me.dtpoutdtfr)
        Me.GroupBox2.Controls.Add(Me.dtpoutdtto)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 70)
        Me.GroupBox2.TabIndex = 219
        Me.GroupBox2.TabStop = False
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
        'btnMinimized
        '
        Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
        Me.btnMinimized.Text = "Minimized"
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(434, 25)
        Me.ToolStrip1.TabIndex = 217
        '
        'frmGOUTDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 225)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmGOUTDocument"
        Me.Text = "GOUT Document"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkOutdt As CheckBox
    Friend WithEvents chkOutno As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDINNOFR As Label
    Friend WithEvents btnSearchOutnofr As Button
    Friend WithEvents txtOUTNOFR As TextBox
    Friend WithEvents btnSearchOutnoto As Button
    Friend WithEvents lblDINNOTO As Label
    Friend WithEvents txtOUTNOTO As TextBox
    Friend WithEvents dtpoutdtfr As DateTimePicker
    Friend WithEvents dtpoutdtto As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
End Class
