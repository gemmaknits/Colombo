<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplier))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboSuppCD = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.cboPayType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTHName = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPaymentTerms = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtTHAddr3 = New System.Windows.Forms.TextBox()
        Me.txtTHAddr2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTHAddr1 = New System.Windows.Forms.TextBox()
        Me.cboCountry = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtENAddr3 = New System.Windows.Forms.TextBox()
        Me.txtENAddr2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtENAddr1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtENName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSuppCD = New System.Windows.Forms.TextBox()
        Me.chkInternal = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboSuppCD, Me.ToolStripSeparator1, Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(465, 25)
        Me.ToolStrip1.TabIndex = 18
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(85, 22)
        Me.ToolStripLabel1.Text = "Supplier Name"
        '
        'cboSuppCD
        '
        Me.cboSuppCD.Name = "cboSuppCD"
        Me.cboSuppCD.Size = New System.Drawing.Size(200, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Save"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
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
        Me.btnExit.Text = "Exit"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(232, 296)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "Contact"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(280, 296)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(176, 20)
        Me.txtContact.TabIndex = 63
        '
        'cboPayType
        '
        Me.cboPayType.FormattingEnabled = True
        Me.cboPayType.Location = New System.Drawing.Point(88, 344)
        Me.cboPayType.Name = "cboPayType"
        Me.cboPayType.Size = New System.Drawing.Size(128, 21)
        Me.cboPayType.TabIndex = 64
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 344)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Pay Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(160, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Days"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Credit"
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(88, 296)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(72, 20)
        Me.txtCredit.TabIndex = 62
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Name (Thai)"
        '
        'txtTHName
        '
        Me.txtTHName.Location = New System.Drawing.Point(88, 152)
        Me.txtTHName.Name = "txtTHName"
        Me.txtTHName.Size = New System.Drawing.Size(368, 20)
        Me.txtTHName.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Payment Term"
        '
        'txtPaymentTerms
        '
        Me.txtPaymentTerms.Location = New System.Drawing.Point(88, 320)
        Me.txtPaymentTerms.Name = "txtPaymentTerms"
        Me.txtPaymentTerms.Size = New System.Drawing.Size(368, 20)
        Me.txtPaymentTerms.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(232, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "E-Mail"
        '
        'txtEMail
        '
        Me.txtEMail.Location = New System.Drawing.Point(280, 248)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(176, 20)
        Me.txtEMail.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(232, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Fax."
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(280, 272)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(176, 20)
        Me.txtFax.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Tel."
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(88, 272)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(128, 20)
        Me.txtTel.TabIndex = 60
        '
        'txtTHAddr3
        '
        Me.txtTHAddr3.Location = New System.Drawing.Point(88, 224)
        Me.txtTHAddr3.Name = "txtTHAddr3"
        Me.txtTHAddr3.Size = New System.Drawing.Size(368, 20)
        Me.txtTHAddr3.TabIndex = 57
        '
        'txtTHAddr2
        '
        Me.txtTHAddr2.Location = New System.Drawing.Point(88, 200)
        Me.txtTHAddr2.Name = "txtTHAddr2"
        Me.txtTHAddr2.Size = New System.Drawing.Size(368, 20)
        Me.txtTHAddr2.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Address (Thai)"
        '
        'txtTHAddr1
        '
        Me.txtTHAddr1.Location = New System.Drawing.Point(88, 176)
        Me.txtTHAddr1.Name = "txtTHAddr1"
        Me.txtTHAddr1.Size = New System.Drawing.Size(368, 20)
        Me.txtTHAddr1.TabIndex = 55
        '
        'cboCountry
        '
        Me.cboCountry.FormattingEnabled = True
        Me.cboCountry.Location = New System.Drawing.Point(88, 248)
        Me.cboCountry.Name = "cboCountry"
        Me.cboCountry.Size = New System.Drawing.Size(128, 21)
        Me.cboCountry.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Country"
        '
        'txtENAddr3
        '
        Me.txtENAddr3.Location = New System.Drawing.Point(88, 128)
        Me.txtENAddr3.Name = "txtENAddr3"
        Me.txtENAddr3.Size = New System.Drawing.Size(368, 20)
        Me.txtENAddr3.TabIndex = 53
        '
        'txtENAddr2
        '
        Me.txtENAddr2.Location = New System.Drawing.Point(88, 104)
        Me.txtENAddr2.Name = "txtENAddr2"
        Me.txtENAddr2.Size = New System.Drawing.Size(368, 20)
        Me.txtENAddr2.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Address (Eng)"
        '
        'txtENAddr1
        '
        Me.txtENAddr1.Location = New System.Drawing.Point(88, 80)
        Me.txtENAddr1.Name = "txtENAddr1"
        Me.txtENAddr1.Size = New System.Drawing.Size(368, 20)
        Me.txtENAddr1.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Name (Eng)"
        '
        'txtENName
        '
        Me.txtENName.Location = New System.Drawing.Point(88, 56)
        Me.txtENName.Name = "txtENName"
        Me.txtENName.Size = New System.Drawing.Size(368, 20)
        Me.txtENName.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Supplier Code"
        '
        'txtSuppCD
        '
        Me.txtSuppCD.Location = New System.Drawing.Point(88, 32)
        Me.txtSuppCD.Name = "txtSuppCD"
        Me.txtSuppCD.Size = New System.Drawing.Size(104, 20)
        Me.txtSuppCD.TabIndex = 48
        '
        'chkInternal
        '
        Me.chkInternal.AutoSize = True
        Me.chkInternal.Location = New System.Drawing.Point(392, 32)
        Me.chkInternal.Name = "chkInternal"
        Me.chkInternal.Size = New System.Drawing.Size(61, 17)
        Me.chkInternal.TabIndex = 66
        Me.chkInternal.Text = "Internal"
        Me.chkInternal.UseVisualStyleBackColor = True
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 377)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.chkInternal)
        Me.Controls.Add(Me.cboPayType)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTHName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPaymentTerms)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEMail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtTHAddr3)
        Me.Controls.Add(Me.txtTHAddr2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTHAddr1)
        Me.Controls.Add(Me.cboCountry)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtENAddr3)
        Me.Controls.Add(Me.txtENAddr2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtENAddr1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtENName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSuppCD)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSupplier"
        Me.Text = "Supplier Master"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboSuppCD As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents cboPayType As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTHName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentTerms As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEMail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtTHAddr3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTHAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTHAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents cboCountry As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtENAddr3 As System.Windows.Forms.TextBox
    Friend WithEvents txtENAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtENAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtENName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSuppCD As System.Windows.Forms.TextBox
    Friend WithEvents chkInternal As System.Windows.Forms.CheckBox
End Class
