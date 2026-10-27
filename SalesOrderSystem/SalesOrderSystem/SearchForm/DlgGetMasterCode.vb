Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Text

Public Class DlgGetMasterCode
    'Form Parameter

#Region "Properties"
    'For returnCMR_Number
    Private _CmrHeaderId As Integer = 0
    Private _CmrNumber As String = 0

    'For return SourceDesignNo
    Private _SourceDesignNo As String = ""
    Private _RollNo As String = ""
    Private _MtlSubinvId As Integer = 0
    Private _CurStockBalance As Double = 0

    'For returnSoNo
    Private _SoNo As String = ""
    Private _SampleOrder As String = ""

    'For returnDesign
    Private _DesignNO As String = ""
    Private _RefDesNo As String = ""
    Private _Compo As String = ""
    Private _MaterialWidth As Double = 0
    Private _FinishedWidth As Double = 0 'Sitthana 20230506
    Private _FinishedWidthMin As Double = 0
    Private _FinishedWidthMax As Double = 0
    Private _FinishedWeight As Double = 0 'Sitthana 20230506
    Private _FinishedWeightMin As Double = 0
    Private _FinishedWeightMax As Double = 0
    Private _FinishedYield As Double = 0

    'For returnMasDyeFinFormula, returnDesign
    Private _FinId As Integer = 0
    Private _FinDescp As String = ""

    'For returnEndBuyer
    Private _EndBuyerId As String
    Private _EndBuyerName As String

    'For return DinNo
    Private _DinNo As String

    '--- Get And Set Data -- For returnCMR_Number
    Public Property pCmrHeaderId As String
        Get
            pCmrHeaderId = _CmrHeaderId
        End Get
        Set(ByVal Newvalue As String)
            _CmrHeaderId = Newvalue
        End Set
    End Property
    Public Property pCmrNumber As String
        Get
            pCmrNumber = _CmrNumber
        End Get
        Set(ByVal Newvalue As String)
            _CmrNumber = Newvalue
        End Set
    End Property

    '--- Get And Set Data -- For return SourceDesignNo
    Public Property pSourceDesignNo As String
        Get
            pSourceDesignNo = _SourceDesignNo
        End Get
        Set(ByVal Newvalue As String)
            _SourceDesignNo = Newvalue
        End Set
    End Property
    Public Property pRollNo As String
        Get
            pRollNo = _RollNo
        End Get
        Set(ByVal Newvalue As String)
            _RollNo = Newvalue
        End Set
    End Property
    Public Property pMtlSubinvId As String
        Get
            pMtlSubinvId = _MtlSubinvId
        End Get
        Set(ByVal Newvalue As String)
            _MtlSubinvId = Newvalue
        End Set
    End Property
    Public Property pCurStockBalance As Double
        Get
            pCurStockBalance = _CurStockBalance
        End Get
        Set(ByVal Newvalue As Double)
            _CurStockBalance = Newvalue
        End Set
    End Property

    '--- Get And Set Data -- For returnSoNo
    Public Property pSoNo As String
        Get
            pSoNo = _SoNo
        End Get
        Set(ByVal Newvalue As String)
            _SoNo = Newvalue
        End Set
    End Property
    Public Property pSampleOrder As String
        Get
            pSampleOrder = _SampleOrder
        End Get
        Set(ByVal Newvalue As String)
            _SampleOrder = Newvalue
        End Set
    End Property

    '--- Get And Set Data -- For returnDesign
    Public Property pDesignNO As String
        Get
            pDesignNO = _DesignNO
        End Get
        Set(ByVal Newvalue As String)
            _DesignNO = Newvalue
        End Set
    End Property
    Public Property pRefDesNo As String
        Get
            pRefDesNo = _RefDesNo
        End Get
        Set(ByVal Newvalue As String)
            _RefDesNo = Newvalue
        End Set
    End Property
    Public Property pCompo As String
        Get
            pCompo = _Compo
        End Get
        Set(ByVal Newvalue As String)
            _Compo = Newvalue
        End Set
    End Property
    Public Property pMaterialWidth As String
        Get
            pMaterialWidth = _MaterialWidth
        End Get
        Set(ByVal Newvalue As String)
            _MaterialWidth = Newvalue
        End Set
    End Property
    Public Property pFinishedWidth As String
        Get
            pFinishedWidth = _FinishedWidth
        End Get
        Set(ByVal Newvalue As String)
            _FinishedWidth = Newvalue
        End Set
    End Property
    Public Property pFinishedWidthMin As String
        Get
            pFinishedWidthMin = _FinishedWidthMin
        End Get
        Set(ByVal Newvalue As String)
            _FinishedWidthMin = Newvalue
        End Set
    End Property
    Public Property pFinishedWidthMax As String
        Get
            pFinishedWidthMax = _FinishedWidthMax
        End Get
        Set(ByVal Newvalue As String)
            _FinishedWidthMax = Newvalue
        End Set
    End Property
    Public Property pFinishedWeight As String
        Get
            pFinishedWeight = _FinishedWeight
        End Get
        Set(ByVal Newvalue As String)
            _FinishedWeight = Newvalue
        End Set
    End Property
    Public Property pFinishedWeightMin As String
        Get
            pFinishedWeightMin = _FinishedWeightMin
        End Get
        Set(ByVal Newvalue As String)
            _FinishedWeightMin = Newvalue
        End Set
    End Property
    Public Property pFinishedWeightMax As String
        Get
            pFinishedWeightMax = _FinishedWeightMax
        End Get
        Set(ByVal Newvalue As String)
            _FinishedWeightMax = Newvalue
        End Set
    End Property
    Public Property pFinishedYield As String
        Get
            pFinishedYield = _FinishedYield
        End Get
        Set(ByVal Newvalue As String)
            _FinishedYield = Newvalue
        End Set
    End Property
    '--- Get And Set Data -- For returnMasDyeFinFormula, returnDesign
    Public Property pFinId As String
        Get
            pFinId = _FinId
        End Get
        Set(ByVal Newvalue As String)
            _FinId = Newvalue
        End Set
    End Property
    Public Property pFinDescp As String
        Get
            pFinDescp = _FinDescp
        End Get
        Set(ByVal Newvalue As String)
            _FinDescp = Newvalue
        End Set
    End Property

    '--- Get And Set Data -- For returnEndBuyer
    Public Property pEndBuyerId As String
        Get
            pEndBuyerId = _EndBuyerId
        End Get
        Set(ByVal Newvalue As String)
            _EndBuyerId = Newvalue
        End Set
    End Property
    Public Property pEndBuyerName As String
        Get
            pEndBuyerName = _EndBuyerName
        End Get
        Set(ByVal Newvalue As String)
            _EndBuyerName = Newvalue
        End Set
    End Property
    '---
    '--- Get And Set Data -- For returnCMR_Number
    Public Property pDinNo As String
        Get
            pDinNo = _DinNo
        End Get
        Set(ByVal Newvalue As String)
            _DinNo = Newvalue
        End Set
    End Property
#End Region

#Region "Constant Variable"
    'For DataForFind
    Private Const DataForFindCmrNumber As String = "Cmr_Number"
    Private Const DataForFindCmrRevisionHistory As String = "Cmr_RevisionHistory"
    Private Const DataForFindSONo As String = "SONo"
    Private Const DataForFindMasDyeFinFormula As String = "MasDyeFinFormula"
    Private Const DataForFindDesign As String = "Design"
    Private Const DataForFindEndBuyer As String = "EndBuyer"
    Private Const DataForFindDinNo As String = "DinNo"
    Private Const DataForFindRollNo As String = "RollNo"
    Private Const DataForFindPreviousCMRNO As String = "PreviousCMRNO"
#End Region


    Private dt As New DataTable
    Private bsSearchTable As New BindingSource
    Private DataForFind As String = ""

    '--- Get And Set Data

    Public Sub New(pDataForFind As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataForFind = pDataForFind
    End Sub




    Private Sub DlgGetMasterCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DataForFind.Trim = "" Then
            MessageBox.Show("โปรแกรมเมอร์ไม่ได้ระบุตารางที่จะให้แสดง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Me.Close()
        End If
        InitForm()
        CreateDGVHeader()
        getAndShowDataRec(DataForFind, _CmrNumber)
        txtWordFilter.Focus()
    End Sub

    Private Sub InitForm()
        Dim boundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim boundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim x As Integer = 0
        Dim y As Integer = 0

        Select Case DataForFind
            Case DataForFindCmrNumber, DataForFindPreviousCMRNO
                Me.Width = 1240
                Me.Height = 650
                Me.Text = "CMR Header"
            Case DataForFindCmrRevisionHistory
                Me.Width = 1240
                Me.Height = 650
                Me.Text = "CMR Header Log"
            Case DataForFindSONo
                Me.Width = 540
                Me.Text = "CO No."
            Case DataForFindMasDyeFinFormula
                Me.Width = 810
                Me.Text = "Master Dye Finished"
            Case DataForFindDesign
                Me.Width = 1050
                Me.Text = "Design"
            Case DataForFindEndBuyer
                Me.Width = 450
                Me.Text = "End Buyer"
            Case DataForFindDinNo
                Me.Width = 450
                Me.Text = "Din No"
            Case DataForFindRollNo
                Me.Width = 800
                Me.Height = 650
                Me.Text = "Sample Stock Balance"
        End Select
        x = boundWidth - Me.Width
        y = boundHeight - Me.Height
        Me.Location = New Point(x / 2, y / 2)
    End Sub

    '--- Create Grid Header
    Private Sub CreateDGVHeader()
        Select Case DataForFind
            Case DataForFindCmrNumber, DataForFindPreviousCMRNO
                createCmr_NumberGrd()
            Case DataForFindCmrRevisionHistory
                createCmr_RevisionHistoryGrd()
            Case DataForFindSONo
                createSoNoGrd()
            Case DataForFindMasDyeFinFormula
                createMasDyeFinFormulaGrd()
            Case DataForFindDesign
                createDesignGrd()
            Case DataForFindEndBuyer
                createEndBuyerGrd()
            Case DataForFindDinNo
                createDinNoGrd()
            Case DataForFindRollNo
                createRollNOGrd()
        End Select
    End Sub
    Private Sub createCmr_NumberGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("cmr_number", "CMR Number")
            .Columns.Add("relab_count", "Relab No")
            .Columns.Add("cmr_revision_number", "Revision No")
            .Columns.Add("cmr_date", "CMR Date")
            .Columns.Add("need_by_date", "Need Date")
            .Columns.Add("item_code", "Design NO")
            .Columns.Add("item_name", "Article")
            .Columns.Add("Garment_type", "Garment Type") 'Sitthana 20230824
            .Columns.Add("endbuyername", "End Buyer")
            .Columns.Add("color_name", "Color")  'Sitthana 20230829
            .Columns.Add("createdby", "Create By")
            .Columns.Add("customer_name", "Vendor")
            .Columns.Add("cmr_closed", "Closed")
            .Columns.Add("cmr_closed_date", "Closed Date")
            .Columns.Add("cmr_header_id", "CMR Header ID")
            .Columns.Add("cmr_date_sort", "CMR Date For Sort") 'Sitthana 20230824

            .Columns("Runno").Width = 30                    'ลำดับ
            .Columns("cmr_number").Width = 140              'CMR Number
            .Columns("relab_count").Width = 50              'Relab No.
            .Columns("cmr_revision_number").Width = 50      'Revision No.
            .Columns("cmr_date").Width = 80                 'CMR Date
            .Columns("need_by_date").Width = 80             'Need Date
            .Columns("item_code").Width = 110               'Design NO
            .Columns("item_name").Width = 200               'Article
            .Columns("Garment_type").Width = 120            'Garment_type 'Sitthana 20230824
            .Columns("endbuyername").Width = 120            'End Buyer
            .Columns("color_name").Width = 250              'color_name  'Sitthana 20230829
            .Columns("createdby").Width = 90                'Create By
            .Columns("customer_name").Width = 120           'Customer Name
            .Columns("cmr_closed").Width = 50               'Closed
            .Columns("cmr_closed_date").Width = 80          'Closed Date
            .Columns("cmr_header_id").Width = 0             'CMR Number
            .Columns("cmr_date_sort").Width = 0             'CMR Number

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cmr_number").DataPropertyName = "cmr_number"
            .Columns("cmr_number").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("relab_count").DataPropertyName = "relab_count"
            .Columns("relab_count").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cmr_revision_number").DataPropertyName = "cmr_revision_number"
            .Columns("cmr_revision_number").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cmr_date").DataPropertyName = "cmr_date"
            .Columns("cmr_date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("need_by_date").DataPropertyName = "need_by_date"
            .Columns("need_by_date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("item_code").DataPropertyName = "item_code"
            .Columns("item_name").DataPropertyName = "item_name"
            .Columns("Garment_type").DataPropertyName = "Garment_type" 'Sitthana 20230824
            .Columns("endbuyername").DataPropertyName = "endbuyername"
            .Columns("color_name").DataPropertyName = "color_name" 'Sitthana 20230829
            .Columns("createdby").DataPropertyName = "createdby"
            .Columns("customer_name").DataPropertyName = "customer_name"
            .Columns("cmr_closed").DataPropertyName = "cmr_closed"
            .Columns("cmr_closed").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cmr_closed_date").DataPropertyName = "cmr_closed_date"
            .Columns("cmr_closed_date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cmr_header_id").DataPropertyName = "cmr_header_id"
            .Columns("cmr_date_sort").DataPropertyName = "cmr_date_sort" 'Sitthana 20230824

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    Private Sub createCmr_RevisionHistoryGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("cmr_header_id", "CMR Header ID")
            .Columns.Add("cmr_number", "CMR Number")
            .Columns.Add("relab_count", "Relab No")
            .Columns.Add("cmr_revision_number", "Revision No")
            .Columns.Add("cmr_date", "CMR Date")
            .Columns.Add("cmr_revision_cause", "Revision Cause")
            .Columns.Add("item_code", "Design NO")
            .Columns.Add("item_name", "Article")
            .Columns.Add("endbuyername", "End Buyer")
            .Columns.Add("createdby", "Create By")
            .Columns.Add("customer_name", "Vendor")
            .Columns.Add("cmr_closed", "Closed")
            .Columns.Add("cmr_closed_date", "Closed Date")

            .Columns("Runno").Width = 30                    'ลำดับ
            .Columns("cmr_header_id").Width = 0             'CMR Number
            .Columns("cmr_number").Width = 90               'CMR Number
            .Columns("relab_count").Width = 50              'Relab No.
            .Columns("cmr_revision_number").Width = 50      'Revision No.
            .Columns("cmr_date").Width = 80                 'CMR Date
            .Columns("cmr_revision_cause").Width = 350      'Revision Cause
            .Columns("item_code").Width = 110               'Design NO
            .Columns("item_name").Width = 200               'Article
            .Columns("endbuyername").Width = 160            'End Buyer
            .Columns("createdby").Width = 90                'Create By
            .Columns("customer_name").Width = 120           'Customer Name
            .Columns("cmr_closed").Width = 50               'Closed
            .Columns("cmr_closed_date").Width = 80          'Closed Date

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("cmr_header_id").DataPropertyName = "cmr_header_id"
            .Columns("cmr_number").DataPropertyName = "cmr_number"
            .Columns("cmr_number").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("relab_count").DataPropertyName = "relab_count"
            .Columns("relab_count").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cmr_revision_number").DataPropertyName = "cmr_revision_number"
            .Columns("cmr_revision_number").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cmr_date").DataPropertyName = "cmr_date"
            .Columns("cmr_date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cmr_revision_cause").DataPropertyName = "cmr_revision_cause"
            .Columns("item_code").DataPropertyName = "item_code"
            .Columns("item_name").DataPropertyName = "item_name"
            .Columns("endbuyername").DataPropertyName = "endbuyername"
            .Columns("createdby").DataPropertyName = "createdby"
            .Columns("customer_name").DataPropertyName = "customer_name"
            .Columns("cmr_closed").DataPropertyName = "cmr_closed"
            .Columns("cmr_closed").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cmr_closed_date").DataPropertyName = "cmr_closed_date"
            .Columns("cmr_closed_date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    Private Sub createSoNoGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("sono", "SO Number")
            .Columns.Add("sodt", "SO Date")
            .Columns.Add("custpo", "Customer PO")
            .Columns.Add("empname", "Sales Name")
            .Columns.Add("sample_order", "Sample Order")

            .Columns("Runno").Width = 30              'ลำดับ
            .Columns("sono").Width = 100              'SO Number
            .Columns("sodt").Width = 80               'SO Date
            .Columns("custpo").Width = 90              'SO Number
            .Columns("empname").Width = 80               'SO Date
            .Columns("sample_order").Width = 50       'Sample Order

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("sono").DataPropertyName = "sono"
            .Columns("sodt").DataPropertyName = "sodt"
            .Columns("custpo").DataPropertyName = "custpo"
            .Columns("empname").DataPropertyName = "empname"
            .Columns("sample_order").DataPropertyName = "sample_order"
            .Columns("sample_order").DefaultCellStyle.Font = New Font("Wingdings 2", 10)
            .Columns("sample_order").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    Private Sub createMasDyeFinFormulaGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("FinId", "Code")
            .Columns.Add("FinDescp", "Description (E)")
            .Columns.Add("name_th", "Description (T)")

            .Columns("Runno").Width = 30                    'ลำดับ
            .Columns("FinId").Width = 80                    'Code
            .Columns("FinDescp").Width = 250                'Description (E) 
            .Columns("name_th").Width = 250                 'Description (T)

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("FinId").DataPropertyName = "FinId"
            .Columns("FinDescp").DataPropertyName = "FinDescp"
            .Columns("name_th").DataPropertyName = "name_th"

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    Private Sub createDesignGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("Design_no", "Material Code")
            .Columns.Add("RefDesNo", "Article")
            .Columns.Add("compo", "Material Name")
            .Columns.Add("MaterialWidth", "Material Width (cm.)")
            .Columns.Add("FinishedWidth", "Finished Width (cm.)")
            .Columns.Add("FinishedWidthMin", "Finished Width Min (cm.)")
            .Columns.Add("FinishedWidthMax", "Finished Width Max (cm.)")
            .Columns.Add("FinishedWeight", "Finished Weight (g/m2)")
            .Columns.Add("FinishedWeightMin", "Finished Weight Min (g/m2)")
            .Columns.Add("FinishedWeightMax", "Finished Weight Max (g/m2)")
            .Columns.Add("FinishedYield", "Finished Yield (m/kgs.)")
            .Columns.Add("FinId", "Code")
            .Columns.Add("FinDescp", "Description (E)")

            .Columns("Runno").Width = 40                    'ลำดับ
            .Columns("Design_no").Width = 90                'Material Code
            .Columns("RefDesNo").Width = 150                'Article
            .Columns("compo").Width = 250                   'Material Name 
            .Columns("MaterialWidth").Width = 50            'Material Width (cm.)
            .Columns("FinishedWidth").Width = 50            'Finished Width (cm.)
            .Columns("FinishedWidthMin").Width = 50         'Finished Width Min (cm.)
            .Columns("FinishedWidthMax").Width = 50         'Finished Width Max (cm.)
            .Columns("FinishedWeight").Width = 50           'Finished Weight (g/m2)
            .Columns("FinishedWeightMin").Width = 50        'Finished Weight Min (g/m2)
            .Columns("FinishedWeightMax").Width = 50        'Finished Weight Max (g/m2)
            .Columns("FinishedYield").Width = 50            'Finished Yield (m/kgs.) 
            .Columns("FinId").Width = 80                    'Code
            .Columns("FinDescp").Width = 250                'Description (E) 

            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("MaterialWidth").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("FinishedWidth").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("FinishedWidthMin").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("FinishedWidthMax").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("FinishedWeight").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("FinishedWeightMin").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("FinishedWeightMax").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("FinishedYield").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Design_no").DataPropertyName = "Design_no"
            .Columns("RefDesNo").DataPropertyName = "RefDesNo"
            .Columns("compo").DataPropertyName = "compo"
            .Columns("MaterialWidth").DataPropertyName = "MaterialWidth"
            .Columns("FinishedWidth").DataPropertyName = "FinishedWidth"
            .Columns("FinishedWidthMin").DataPropertyName = "FinishedWidthMin"
            .Columns("FinishedWidthMax").DataPropertyName = "FinishedWidthMax"
            .Columns("FinishedWeight").DataPropertyName = "FinishedWeight"
            .Columns("FinishedWeightMin").DataPropertyName = "FinishedWeightMin"
            .Columns("FinishedWeightMax").DataPropertyName = "FinishedWeightMax"
            .Columns("FinishedYield").DataPropertyName = "FinishedYield"
            .Columns("FinId").DataPropertyName = "FinId"
            .Columns("FinDescp").DataPropertyName = "FinDescp"

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    Private Sub createEndBuyerGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("endbuyerid", "End Buyer ID")
            .Columns.Add("endbuyername", "End Buyer Name")

            .Columns("Runno").Width = 40                    'ลำดับ
            .Columns("endbuyerid").Width = 50               'End Buyer ID
            .Columns("endbuyername").Width = 250            'End Buyer Name

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("endbuyerid").DataPropertyName = "endbuyerid"
            .Columns("endbuyername").DataPropertyName = "endbuyername"

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    Private Sub createDinNoGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("dinno", "Din No")
            .Columns.Add("dindt", "Date")

            .Columns("Runno").Width = 40                    'ลำดับ
            .Columns("dinno").Width = 90               'End Buyer ID
            .Columns("dindt").Width = 90             'End Buyer Name

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("Runno").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("dinno").DataPropertyName = "dinno"
            .Columns("dindt").DataPropertyName = "dindt"

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub
    Private Sub createRollNOGrd()
        With grdData
            .Columns.Clear()
            .Columns.Add("Runno", "ลำดับ")
            .Columns.Add("design_no", "Design No")
            .Columns.Add("roll_no_d", "Roll No")
            .Columns.Add("roll_no_o", "Factory Roll")
            .Columns.Add("lot", "Lot No")
            .Columns.Add("bal_mts", "MTS")
            .Columns.Add("bal_yds", "YDS")
            .Columns.Add("mtkg", "MT/KG")
            .Columns.Add("bal_kg", "KG")

            .Columns("Runno").Width = 30                    'ลำดับ
            .Columns("design_no").Width = 90                'Design No
            .Columns("roll_no_d").Width = 90                'Roll No
            .Columns("roll_no_o").Width = 90                'Factory Roll
            .Columns("lot").Width = 80                      'Lot No
            .Columns("bal_mts").Width = 60                  'MTS
            .Columns("bal_yds").Width = 60                  'YDS
            .Columns("mtkg").Width = 60                     'MT/KG
            .Columns("bal_kg").Width = 60                   'KG

            .Columns("Runno").DataPropertyName = "Runno"
            .Columns("design_no").DataPropertyName = "design_no"
            .Columns("design_no").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("roll_no_d").DataPropertyName = "roll_no_d"
            .Columns("roll_no_d").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("roll_no_o").DataPropertyName = "roll_no_o"
            .Columns("roll_no_o").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("lot").DataPropertyName = "lot"
            .Columns("lot").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("bal_mts").DataPropertyName = "bal_mts"
            .Columns("bal_mts").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("bal_yds").DataPropertyName = "bal_yds"
            .Columns("bal_yds").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("mtkg").DataPropertyName = "mtkg"
            .Columns("mtkg").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("bal_kg").DataPropertyName = "bal_kg"
            .Columns("bal_kg").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("bal_mts").DataPropertyName = "bal_mts"
            .Columns("bal_mts").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
    End Sub

    '--- Get Data Insert Into Grid
    Private Sub getAndShowDataRec(pValToFind As String, p_cmr_number As String)
        Dim objDB As New ClassCMR
        'Dim cmd As New SqlCommand("", SqlConn) 'Sitthana 20210615
        'Dim da As New SqlDataAdapter(cmd) 'Sitthana 20210615

        Select Case DataForFind
            Case DataForFindCmrNumber, DataForFindPreviousCMRNO
                dt = objDB.getCMRNumberData(p_cmr_number)
            Case DataForFindCmrRevisionHistory
                dt = objDB.getCMRRevisionHistoryData(p_cmr_number)
            Case DataForFindSONo
                Dim objSODB As New classSalesOrder
                dt = objSODB.getSoData("")
            Case DataForFindMasDyeFinFormula
                dt = objDB.getMasDyeFinFormulaData("")
            Case DataForFindDesign
                dt = objDB.getDesignData("")
            Case DataForFindEndBuyer
                dt = objDB.getEndBuyerData(0)
            Case DataForFindDinNo
                dt = objDB.getDinNoData("")
            Case DataForFindRollNo
                dt = objDB.getRollData(_RollNo, _DesignNO, _MtlSubinvId)
        End Select

        With grdData
            If dt.Rows.Count > 0 Then
                bsSearchTable.DataSource = dt 'Sitthana 20210615
                .AutoGenerateColumns = False
                .DataSource = bsSearchTable
                AssignRowNoToGrd()
                bsSearchTable.MoveFirst() 'Sitthana 20210615
            Else
                grdData.DataSource = Nothing
            End If
        End With

    End Sub
    Private Sub AssignRowNoToGrd()
        With grdData
            If .Rows.Count > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(i).Cells(0).Value = i + 1
                Next
            End If
        End With
    End Sub
    '--- Return Data 
    Private Sub returnCMR_Number()
        With grdData
            _CmrHeaderId = .Rows(.CurrentRow.Index).Cells("cmr_header_id").Value.ToString.Trim
            _CmrNumber = .Rows(.CurrentRow.Index).Cells("cmr_number").Value.ToString.Trim
        End With
    End Sub
    Private Sub returnRollNo()
        With grdData
            _RollNo = .Rows(.CurrentRow.Index).Cells("roll_no_d").Value.ToString.Trim
            _SourceDesignNo = .Rows(.CurrentRow.Index).Cells("Design_no").Value.ToString.Trim
            _CurStockBalance = .Rows(.CurrentRow.Index).Cells("bal_mts").Value.ToString.Trim
        End With
    End Sub
    Private Sub returnSoNo()
        With grdData
            _SoNo = .Rows(.CurrentRow.Index).Cells("SoNO").Value.ToString.Trim
            _SampleOrder = .Rows(.CurrentRow.Index).Cells("sample_order").Value.ToString.Trim
        End With
    End Sub
    Private Sub returnMasDyeFinFormula()
        With grdData
            _FinId = .Rows(.CurrentRow.Index).Cells("FinId").Value.ToString.Trim
            _FinDescp = .Rows(.CurrentRow.Index).Cells("FinDescp").Value.ToString.Trim
        End With
    End Sub
    Private Function ChangeBlankTosStrZero(p_value As String)
        Dim ValueReturn As String = ""
        If p_value = "" Then
            ValueReturn = "0"
        Else
            ValueReturn = p_value
        End If
        Return ValueReturn
    End Function
    Private Sub returnDesign()
        With grdData
            _DesignNO = .Rows(.CurrentRow.Index).Cells("Design_no").Value.ToString.Trim
            _RefDesNo = .Rows(.CurrentRow.Index).Cells("RefDesNo").Value.ToString.Trim
            _Compo = .Rows(.CurrentRow.Index).Cells("Compo").Value.ToString.Trim
            _MaterialWidth = ChangeBlankTosStrZero(.Rows(.CurrentRow.Index).Cells("MaterialWidth").Value.ToString.Trim)

            _FinishedWidth = ChangeBlankTosStrZero(.Rows(.CurrentRow.Index).Cells("FinishedWidth").Value.ToString.Trim)  'Sitthana 20230506
            _FinishedWidthMin = ChangeBlankTosStrZero(.Rows(.CurrentRow.Index).Cells("FinishedWidthMin").Value.ToString.Trim)
            _FinishedWidthMax = ChangeBlankTosStrZero(.Rows(.CurrentRow.Index).Cells("FinishedWidthMax").Value.ToString.Trim)
            _FinishedWeight = ChangeBlankTosStrZero(.Rows(.CurrentRow.Index).Cells("FinishedWeight").Value.ToString.Trim)  'Sitthana 20230506
            _FinishedWeightMin = ChangeBlankTosStrZero(.Rows(.CurrentRow.Index).Cells("FinishedWeightMin").Value.ToString.Trim)
            _FinishedWeightMax = ChangeBlankTosStrZero(.Rows(.CurrentRow.Index).Cells("FinishedWeightMax").Value.ToString.Trim)
            _FinishedYield = ChangeBlankTosStrZero(.Rows(.CurrentRow.Index).Cells("FinishedYield").Value.ToString.Trim)
            _FinId = .Rows(.CurrentRow.Index).Cells("FinId").Value.ToString.Trim
            _FinDescp = .Rows(.CurrentRow.Index).Cells("FinDescp").Value.ToString.Trim
        End With
    End Sub
    Private Sub returnEndBuyer()
        With grdData
            _EndBuyerId = .Rows(.CurrentRow.Index).Cells("endbuyerid").Value.ToString.Trim
            _EndBuyerName = .Rows(.CurrentRow.Index).Cells("endbuyername").Value.ToString.Trim
        End With
    End Sub
    Private Sub returnDinNo()
        With grdData
            _DinNo = .Rows(.CurrentRow.Index).Cells("dinno").Value.ToString.Trim
        End With
    End Sub
    Public Function findRowIDGrd(BeginRowIdx As Integer, ColIdx As Integer, valToFind As String) As Boolean
        Dim RowId As Integer = -1

        Try
            With grdData
                If .Rows.Count > 0 And BeginRowIdx < .Rows.Count Then
                    Dim SearchWithinThis As String = ""
                    Dim i As Integer = 0
                    Dim J As Integer = 0

                    For i = BeginRowIdx + 1 To .Rows.Count
                        For J = 1 To .ColumnCount - 1
                            If IsNothing(.Rows(i).Cells(J).Value) = False Then
                                SearchWithinThis = .Rows(i).Cells(J).Value.ToString.ToUpper
                                If SearchWithinThis.IndexOf(valToFind.ToUpper) <> -1 Then
                                    RowId = i
                                    .CurrentCell = .Rows(RowId).Cells(J)
                                    .CurrentCell = .Rows(i).Cells(J)
                                    findRowIDGrd = True
                                    Exit Function
                                End If
                            End If
                        Next J
                    Next i
                End If
            End With
        Catch ex As Exception

        End Try

        findRowIDGrd = False
    End Function
    Private Sub MoveToFindValueCell()
        Try
            With grdData
                If .Rows.Count > 0 Then
                    Dim CurIdxRow As Integer = .CurrentRow.Index
                    Dim CurIdxCol As Integer = .CurrentCell.ColumnIndex
                    Dim FoundIdxRow As Integer = 0

                    If CurIdxCol = 0 Then CurIdxCol = 1
                    FoundIdxRow = findRowIDGrd(CurIdxRow, CurIdxCol, txtWordFilter.Text.Trim)

                    If FoundIdxRow >= 0 And CurIdxCol >= 0 Then
                        .CurrentCell = .Rows(FoundIdxRow).Cells(CurIdxCol)
                    End If
                End If

            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtWordFilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWordFilter.KeyPress
        If e.KeyChar = vbCr Then
            Try
                With grdData
                    If .Rows.Count > 0 Then
                        Dim CurIdxRow As Integer = .CurrentRow.Index
                        Dim CurIdxCol As Integer = .CurrentCell.ColumnIndex
                        Dim FoundIdxRow As Integer = 0

                        If CurIdxCol = 0 Then CurIdxCol = 1
                        'FoundIdxRow = findRowIDGrd(CurIdxRow, CurIdxCol, txtSearch.Text.Trim)

                        If findRowIDGrd(CurIdxRow, CurIdxCol, txtWordFilter.Text.Trim) = False Then
                            MessageBox.Show("ไม่พบข้อมูลที่ค้นหา", "รายงานผล", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            '.CurrentCell = .Rows(FoundIdxRow).Cells(CurIdxCol)
                        End If
                    End If
                End With
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub txtWordFilter_TextChanged(sender As Object, e As EventArgs) Handles txtWordFilter.TextChanged
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtWordFilter.Text.Trim


        Select Case DataForFind
            Case DataForFindCmrNumber
                FilterExp.Append(" cmr_number LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or item_code LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or color_name LIKE '*" & SearchString & "*'") 'Sitthana 20230829
                FilterExp.Append(" or endbuyername LIKE '*" & SearchString & "*'") 'Neung 20260313 'endbuyername 'Garment_type
                FilterExp.Append(" or Garment_type LIKE '*" & SearchString & "*'") 'Neung 20260313 'endbuyername 'Garment_type
            Case DataForFindCmrRevisionHistory
                FilterExp.Append(" cmr_number LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or item_code LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or item_name LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or endbuyername LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or customer LIKE '*" & SearchString & "*'")
            Case DataForFindPreviousCMRNO
                FilterExp.Append(" cmr_number LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or item_code LIKE '*" & SearchString & "*'")
            Case DataForFindSONo
                FilterExp.Append(" sono LIKE '*" & SearchString & "*'")
            Case DataForFindMasDyeFinFormula
                FilterExp.Append(" FinDescp LIKE '*" & SearchString & "*'")
            Case DataForFindDesign
                FilterExp.Append(" Design_no LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or RefDesNo LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or compo LIKE '*" & SearchString & "*'")
            Case DataForFindEndBuyer
                FilterExp.Append(" endbuyername LIKE '*" & SearchString & "*'")
            Case DataForFindDinNo
                FilterExp.Append(" dinno LIKE '*" & SearchString & "*'")
            Case DataForFindRollNo
                FilterExp.Append(" Design_no LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or roll_no_d LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or roll_no_o LIKE '*" & SearchString & "*'")
                FilterExp.Append(" or lot LIKE '*" & SearchString & "*'")
        End Select


        If SearchString <> "" Then
            bsSearchTable.Filter = FilterExp.ToString
        Else
            bsSearchTable.Filter = ""
        End If
    End Sub
    Private Sub ReturnSelectValueAndCloseDlg()
        If grdData.Rows.Count > 0 Then
            Select Case DataForFind
                Case DataForFindCmrNumber, DataForFindCmrRevisionHistory, DataForFindPreviousCMRNO
                    returnCMR_Number()
                Case DataForFindSONo
                    returnSoNo()
                Case DataForFindMasDyeFinFormula
                    returnMasDyeFinFormula()
                Case DataForFindDesign
                    returnDesign()
                Case DataForFindEndBuyer
                    returnEndBuyer()
                Case DataForFindDinNo
                    returnDinNo()
                Case DataForFindRollNo
                    returnRollNo()
            End Select
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ReturnSelectValueAndCloseDlg()
    End Sub
    Private Sub grdData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellDoubleClick
        ReturnSelectValueAndCloseDlg()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


End Class
