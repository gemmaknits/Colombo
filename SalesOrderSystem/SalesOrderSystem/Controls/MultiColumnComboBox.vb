Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms

Namespace Controls

    '--------------------------------------------------------------------------
    ' Compatibility stubs — replicate Syncfusion types used in calling code
    '--------------------------------------------------------------------------

    ''' <summary>Drop-in stub for Syncfusion.Windows.Forms.Tools.MouseClickCancelEventArgs</summary>
    Public Class MouseClickCancelEventArgs
        Inherits EventArgs
        Public Property Cancel As Boolean
    End Class

    ''' <summary>Drop-in stub for Syncfusion.Windows.Forms.Grid.GridFontInfo</summary>
    Public Class GridFontInfo
        Private _font As Font
        Public Sub New(font As Font)
            _font = font
        End Sub
        Public ReadOnly Property Font As Font
            Get
                Return _font
            End Get
        End Property
    End Class

    ''' <summary>Drop-in stub for Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs</summary>
    Public Class GridQueryCellInfoEventArgs
        Inherits EventArgs
        Private _rowIndex As Integer
        Private _colIndex As Integer
        Private _style As GridCellStyleInfo
        Public Sub New(row As Integer, col As Integer)
            _rowIndex = row
            _colIndex = col
            _style = New GridCellStyleInfo()
        End Sub
        Public ReadOnly Property RowIndex As Integer
            Get
                Return _rowIndex
            End Get
        End Property
        Public ReadOnly Property ColIndex As Integer
            Get
                Return _colIndex
            End Get
        End Property
        Public ReadOnly Property Style As GridCellStyleInfo
            Get
                Return _style
            End Get
        End Property
    End Class

    Public Class GridCellStyleInfo
        Public Property Font As GridFontInfo
        Public Property Text As String
    End Class

    '--------------------------------------------------------------------------
    ' Model access hierarchy — replicates .ListBox.Grid.Model.Cols / Model(r,c)
    '--------------------------------------------------------------------------

    ''' <summary>Holds a single cell value. Used by Model(row, col).CellValue.</summary>
    Public Class GridCellInfo
        Private _cellValue As Object
        Public Sub New(value As Object)
            _cellValue = value
        End Sub
        Public ReadOnly Property CellValue As Object
            Get
                Return _cellValue
            End Get
        End Property
    End Class

    ''' <summary>Tracks which columns (1-based) are hidden in the dropdown grid.</summary>
    Public Class ColsAccessor
        Private ReadOnly _hidden As New Dictionary(Of Integer, Boolean)()

        Default Public Property Hidden(index As Integer) As Boolean
            Get
                Dim v As Boolean = False
                Return _hidden.TryGetValue(index, v) AndAlso v
            End Get
            Set(value As Boolean)
                _hidden(index) = value
            End Set
        End Property

        Public Function GetHiddenIndices() As List(Of Integer)
            Dim result As New List(Of Integer)()
            For Each kv In _hidden
                If kv.Value Then result.Add(kv.Key)
            Next
            Return result
        End Function
    End Class

    ''' <summary>
    ''' Central model shared by both ListBox and GridListBox accessors.
    ''' </summary>
    Public Class GridModelAccessor
        Private _dataViewProvider As Func(Of DataView)
        Private ReadOnly _cols As New ColsAccessor()

        Public Sub New(dataViewProvider As Func(Of DataView))
            _dataViewProvider = dataViewProvider
        End Sub

        Public ReadOnly Property Cols As ColsAccessor
            Get
                Return _cols
            End Get
        End Property

        ''' <summary>
        ''' 1-based row/col access. Row 1 = first data row.
        ''' Replicates: Model(SelectedIndex + 1, 3).CellValue
        ''' </summary>
        Default Public ReadOnly Property Item(row As Integer, col As Integer) As GridCellInfo
            Get
                Dim dv As DataView = _dataViewProvider()
                If dv Is Nothing OrElse row <= 0 OrElse row > dv.Count Then
                    Return New GridCellInfo(Nothing)
                End If
                Dim zeroCol As Integer = col - 1
                Dim dataRow As DataRowView = dv(row - 1)
                If zeroCol < 0 OrElse zeroCol >= dataRow.Row.Table.Columns.Count Then
                    Return New GridCellInfo(Nothing)
                End If
                Return New GridCellInfo(dataRow(zeroCol))
            End Get
        End Property

        ''' <summary>
        ''' Same as Model(row, colIndex), but by the underlying DataTable's column
        ''' name instead of a positional index -- e.g. Model(SelectedIndex + 1,
        ''' "customer_id") instead of a magic number that silently breaks if the
        ''' source stored proc's column order ever changes. -- John 01/10/2026
        ''' </summary>
        Default Public ReadOnly Property Item(row As Integer, columnName As String) As GridCellInfo
            Get
                Dim dv As DataView = _dataViewProvider()
                If dv Is Nothing OrElse row <= 0 OrElse row > dv.Count Then
                    Return New GridCellInfo(Nothing)
                End If
                Dim dataRow As DataRowView = dv(row - 1)
                If Not dataRow.Row.Table.Columns.Contains(columnName) Then
                    Return New GridCellInfo(Nothing)
                End If
                Return New GridCellInfo(dataRow(columnName))
            End Get
        End Property

        Public Event QueryCellInfo As EventHandler(Of GridQueryCellInfoEventArgs)

        Friend Sub RaiseQueryCellInfo(e As GridQueryCellInfoEventArgs)
            RaiseEvent QueryCellInfo(Me, e)
        End Sub
    End Class

    ''' <summary>Intermediate accessor: .Grid.Model</summary>
    Public Class GridAccessor
        Private _model As GridModelAccessor
        Public Sub New(sharedModel As GridModelAccessor)
            _model = sharedModel
        End Sub
        Public ReadOnly Property Model As GridModelAccessor
            Get
                Return _model
            End Get
        End Property
    End Class

    ''' <summary>
    ''' Drop-in replacement for Syncfusion GridListBox.
    ''' Accessed via: TryCast(mcbo.ListControl, GridListBox)
    ''' </summary>
    Public Class GridListBox
        Private _grid As GridAccessor
        Public Sub New(sharedModel As GridModelAccessor)
            _grid = New GridAccessor(sharedModel)
        End Sub
        Public ReadOnly Property Grid As GridAccessor
            Get
                Return _grid
            End Get
        End Property
    End Class

    ''' <summary>Accessor for mcbo.ListBox.Grid.Model</summary>
    Public Class ListBoxAccessor
        Private _grid As GridAccessor
        Public Sub New(sharedModel As GridModelAccessor)
            _grid = New GridAccessor(sharedModel)
        End Sub
        Public ReadOnly Property Grid As GridAccessor
            Get
                Return _grid
            End Get
        End Property
    End Class

    '--------------------------------------------------------------------------
    ' Main control
    '--------------------------------------------------------------------------

    ''' <summary>
    ''' Drop-in replacement for Syncfusion.Windows.Forms.Tools.MultiColumnComboBox.
    ''' Provides the same public API so existing code only needs to remove
    ''' Syncfusion imports and replace them with SalesOrderSystem.Controls.
    ''' </summary>
    Public Class MultiColumnComboBox
        Inherits UserControl
        Implements ISupportInitialize

        Private ReadOnly _txtDisplay As New TextBox()
        Private ReadOnly _btnDrop As New Button()
        Private _popup As Form
        Private _dgv As DataGridView

        Private _dataTable As DataTable          ' underlying unfiltered table (for Model(r,c) access)
        Private _originalDataSource As Object   ' BindingSource / DataView / DataTable as originally set
        Private _displayMember As String
        Private _valueMember As String
        Private _selectedIndex As Integer = -1

        ' Type-to-filter support -- John 18/09/2026
        Private _allowTypeFilter As Boolean = False
        Private _suppressTextChanged As Boolean = False
        Private _popupBaseFilter As String = ""
        Private _hookedOwnerForm As Form
        Private _clickAwayFilter As ClickAwayMessageFilter

        Private ReadOnly _sharedModel As GridModelAccessor
        Private ReadOnly _listBoxAcc As ListBoxAccessor
        Private ReadOnly _gridListBox As GridListBox

        ' Syncfusion styling stubs — accepted but ignored at runtime
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property BeforeTouchSize As Size
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property MetroColor As Color
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property ScrollMetroColorTable As Object
        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property MultiColumn As Boolean

        ''' <summary>
        ''' Opt-in: when True, the display textbox becomes typable and the dropdown
        ''' list filters to rows whose DisplayMember contains the typed text.
        ''' Default False preserves the original click-to-select-only behavior.
        ''' -- John 18/09/2026
        ''' </summary>
        Public Property AllowTypeFilter As Boolean
            Get
                Return _allowTypeFilter
            End Get
            Set(value As Boolean)
                _allowTypeFilter = value
                _txtDisplay.ReadOnly = Not value
            End Set
        End Property

        Public Event SelectedIndexChanged As EventHandler
        Public Event SelectedValueChanged As EventHandler
        ''' <summary>Fired when user selects an item (replaces Syncfusion DropDownCloseOnClick)</summary>
        Public Event DropDownCloseOnClick As EventHandler(Of MouseClickCancelEventArgs)

        Public Sub New()
            ' Use New DataView(_dataTable) — NOT _dataTable.DefaultView — because
            ' BindingSource.Filter modifies DefaultView.RowFilter in-place, which
            ' would make Model(row, col) see a filtered (shorter) view and return
            ' Nothing for rows that exist in the underlying table.
            _sharedModel = New GridModelAccessor(Function() If(_dataTable IsNot Nothing, New DataView(_dataTable), Nothing))
            _listBoxAcc = New ListBoxAccessor(_sharedModel)
            _gridListBox = New GridListBox(_sharedModel)
            BuildUI()
        End Sub

        Private Sub BuildUI()
            Me.SuspendLayout()

            With _txtDisplay
                .ReadOnly = True
                .Dock = DockStyle.Fill
                .BorderStyle = BorderStyle.None
                .BackColor = SystemColors.Window
                .Font = New Font("Segoe UI", 9)
            End With
            AddHandler _txtDisplay.Click, AddressOf OnTextClick
            AddHandler _txtDisplay.KeyDown, AddressOf OnTextKeyDown
            AddHandler _txtDisplay.TextChanged, AddressOf OnDisplayTextChanged ' John 18/09/2026
            AddHandler _txtDisplay.Leave, AddressOf OnEditControlLeave ' John 18/09/2026

            With _btnDrop
                .Dock = DockStyle.Right
                .Width = 18
                .Text = "6"  ' Wingdings down-arrow
                .Font = New Font("Wingdings", 7)
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .Cursor = Cursors.Default
                .TabStop = False
            End With
            AddHandler _btnDrop.Click, AddressOf OnButtonClick
            AddHandler _btnDrop.Leave, AddressOf OnEditControlLeave ' John 18/09/2026

            Me.BorderStyle = BorderStyle.FixedSingle
            Me.Controls.Add(_txtDisplay)
            Me.Controls.Add(_btnDrop)
            Me.Height = 21
            Me.ResumeLayout(False)
        End Sub

        '------------------------------------------------------------------ '
        ' Data-binding
        '------------------------------------------------------------------ '

        Public Property DataSource As Object
            Get
                Return _originalDataSource
            End Get
            Set(value As Object)
                _originalDataSource = value
                ' Also extract the unfiltered DataTable for Model(row,col) index lookups
                If TypeOf value Is DataTable Then
                    _dataTable = DirectCast(value, DataTable)
                ElseIf TypeOf value Is DataView Then
                    _dataTable = DirectCast(value, DataView).Table
                ElseIf TypeOf value Is BindingSource Then
                    Dim bs = DirectCast(value, BindingSource)
                    If TypeOf bs.DataSource Is DataTable Then
                        _dataTable = DirectCast(bs.DataSource, DataTable)
                    ElseIf TypeOf bs.DataSource Is DataView Then
                        _dataTable = DirectCast(bs.DataSource, DataView).Table
                    End If
                Else
                    _dataTable = Nothing
                End If
            End Set
        End Property

        Public Property DisplayMember As String
            Get
                Return _displayMember
            End Get
            Set(value As String)
                _displayMember = value
            End Set
        End Property

        Public Property ValueMember As String
            Get
                Return _valueMember
            End Get
            Set(value As String)
                _valueMember = value
            End Set
        End Property

        '------------------------------------------------------------------ '
        ' Selection
        '------------------------------------------------------------------ '

        Public Property SelectedIndex As Integer
            Get
                Return _selectedIndex
            End Get
            Set(value As Integer)
                If _dataTable Is Nothing Then
                    _selectedIndex = -1
                    SetDisplayText("")
                    Return
                End If
                _selectedIndex = value
                If value >= 0 AndAlso value < _dataTable.Rows.Count AndAlso Not String.IsNullOrEmpty(_displayMember) Then
                    SetDisplayText(_dataTable.Rows(value)(_displayMember).ToString())
                Else
                    _selectedIndex = -1
                    SetDisplayText("")
                End If
            End Set
        End Property

        Public Property SelectedValue As Object
            Get
                If _selectedIndex < 0 OrElse _dataTable Is Nothing OrElse String.IsNullOrEmpty(_valueMember) Then
                    Return Nothing
                End If
                If _selectedIndex >= _dataTable.Rows.Count Then Return Nothing
                Return _dataTable.Rows(_selectedIndex)(_valueMember)
            End Get
            Set(value As Object)
                _selectedIndex = -1
                SetDisplayText("")
                If value Is Nothing OrElse _dataTable Is Nothing OrElse String.IsNullOrEmpty(_valueMember) Then Return

                Dim searchStr As String = value.ToString().Trim()
                For i As Integer = 0 To _dataTable.Rows.Count - 1
                    If _dataTable.Rows(i)(_valueMember).ToString().Trim() = searchStr Then
                        _selectedIndex = i
                        If Not String.IsNullOrEmpty(_displayMember) Then
                            SetDisplayText(_dataTable.Rows(i)(_displayMember).ToString())
                        End If
                        Return
                    End If
                Next
            End Set
        End Property

        Public Overrides Property Text As String
            Get
                If _txtDisplay Is Nothing Then Return MyBase.Text
                Return _txtDisplay.Text
            End Get
            Set(value As String)
                MyBase.Text = value
                If _txtDisplay Is Nothing Then Return
                SetDisplayText(value)
                If String.IsNullOrEmpty(value) Then _selectedIndex = -1
            End Set
        End Property

        ''' <summary>Sets the display textbox's text programmatically without
        ''' triggering the type-to-filter TextChanged handler. -- John 18/09/2026</summary>
        Private Sub SetDisplayText(value As String)
            _suppressTextChanged = True
            Try
                _txtDisplay.Text = value
            Finally
                _suppressTextChanged = False
            End Try
        End Sub

        '------------------------------------------------------------------ '
        ' Syncfusion-compatible accessors
        '------------------------------------------------------------------ '

        Public ReadOnly Property ListBox As ListBoxAccessor
            Get
                Return _listBoxAcc
            End Get
        End Property

        ''' <summary>
        ''' Returns the shared GridListBox.
        ''' Usage (unchanged from Syncfusion):
        '''   TryCast(mcbo.ListControl, GridListBox).Grid.Model.QueryCellInfo
        ''' </summary>
        Public ReadOnly Property ListControl As Object
            Get
                Return _gridListBox
            End Get
        End Property

        '------------------------------------------------------------------ '
        ' Dropdown
        '------------------------------------------------------------------ '

        Private Sub OnButtonClick(s As Object, e As EventArgs)
            ToggleDropDown()
        End Sub

        Private Sub OnTextClick(s As Object, e As EventArgs)
            If _allowTypeFilter Then
                ' Editable text: a click while the list is already open just places
                ' the caret for typing -- don't toggle it closed. -- John 18/09/2026
                If _popup Is Nothing OrElse _popup.IsDisposed Then
                    OpenPopup()
                End If
                Return
            End If
            ToggleDropDown()
        End Sub

        Private Sub OnTextKeyDown(s As Object, e As KeyEventArgs)
            If _allowTypeFilter Then
                Select Case e.KeyCode
                    Case Keys.F4
                        ToggleDropDown()
                        e.Handled = True
                    Case Keys.Enter
                        If _popup IsNot Nothing AndAlso Not _popup.IsDisposed AndAlso _dgv IsNot Nothing AndAlso _dgv.Rows.Count > 0 Then
                            CommitSelection(0)
                            ClosePopup()
                            e.Handled = True
                        End If
                    Case Keys.Escape
                        If _popup IsNot Nothing AndAlso Not _popup.IsDisposed Then
                            ClosePopup()
                            RestoreDisplayFromSelection()
                            e.Handled = True
                        End If
                End Select
                Return ' let normal characters, Backspace, Delete, arrows, etc. edit the text
            End If

            If e.KeyCode = Keys.F4 OrElse e.KeyCode = Keys.Space Then
                ToggleDropDown()
                e.Handled = True
            End If
        End Sub

        ''' <summary>Type-to-filter: refilters the open dropdown as the user types.
        ''' -- John 18/09/2026</summary>
        Private Sub OnDisplayTextChanged(s As Object, e As EventArgs)
            If Not _allowTypeFilter OrElse _suppressTextChanged Then Return
            _selectedIndex = -1
            If _popup Is Nothing OrElse _popup.IsDisposed Then
                OpenPopup()
            End If
            ApplyTypeFilter(_txtDisplay.Text)
            If Not _txtDisplay.Focused Then _txtDisplay.Focus() ' John 18/09/2026
        End Sub

        ''' <summary>Closes the dropdown once focus has left both the combo box and
        ''' the popup (deferred so a click on a popup row is processed first).
        ''' -- John 18/09/2026</summary>
        Private Sub OnEditControlLeave(s As Object, e As EventArgs)
            If Not _allowTypeFilter Then Return
            Dim popupRef As Form = _popup
            Me.BeginInvoke(New MethodInvoker(Sub()
                If popupRef IsNot Nothing AndAlso Not popupRef.IsDisposed Then
                    If Not popupRef.ContainsFocus AndAlso Not Me.ContainsFocus Then
                        ClosePopup()
                    End If
                End If
            End Sub))
        End Sub

        ''' <summary>Called for every application-wide mouse-down while a type-filter
        ''' popup is open. Closes it if the click landed outside both the combo box
        ''' and the popup -- covers clicks on non-focusable controls (Label, Panel,
        ''' blank tab area) that would never raise a Leave event. -- John 18/09/2026</summary>
        Private Sub OnAnyMouseDown()
            If _popup Is Nothing OrElse _popup.IsDisposed Then Return
            Dim pt As Point = Control.MousePosition
            Dim overCombo As Boolean = Me.IsHandleCreated AndAlso Me.RectangleToScreen(Me.ClientRectangle).Contains(pt)
            Dim overPopup As Boolean = _popup.Bounds.Contains(pt)
            If Not overCombo AndAlso Not overPopup Then
                ClosePopup()
            End If
        End Sub

        Private Sub RestoreDisplayFromSelection()
            Dim text As String = ""
            If _selectedIndex >= 0 AndAlso _dataTable IsNot Nothing AndAlso _selectedIndex < _dataTable.Rows.Count AndAlso Not String.IsNullOrEmpty(_displayMember) Then
                text = _dataTable.Rows(_selectedIndex)(_displayMember).ToString()
            End If
            SetDisplayText(text)
        End Sub

        Private Sub ToggleDropDown()
            If _popup IsNot Nothing AndAlso Not _popup.IsDisposed Then
                ClosePopup()
            Else
                OpenPopup()
            End If
        End Sub

        Private Sub OpenPopup()
            If _dataTable Is Nothing Then Return

            _dgv = New DataGridView()
            With _dgv
                .Dock = DockStyle.Fill
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .MultiSelect = False
                .RowHeadersVisible = False
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .BorderStyle = BorderStyle.None
                .BackgroundColor = SystemColors.Window
                .Font = New Font("Segoe UI", 9)
                .EnableHeadersVisualStyles = False
            End With
            _dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            _dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 153, 255)
            _dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            _dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255)
            _dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 248, 255)

            ' Type-filter popups must not steal keyboard focus from the textbox while
            ' the user is typing, so they use a non-activating window. -- John 18/09/2026
            If _allowTypeFilter Then
                _popup = New NonActivatingPopup()
            Else
                _popup = New Form()
            End If
            With _popup
                .FormBorderStyle = FormBorderStyle.None
                .ShowInTaskbar = False
                .StartPosition = FormStartPosition.Manual
                .TopMost = True
            End With
            _popup.Controls.Add(_dgv)

            ' Build a DataView that respects the current BindingSource filter/sort
            ' WITHOUT binding the DGV directly to the BindingSource (which would let
            ' DGV manage currency on the shared BindingSource and corrupt _selectedIndex).
            Dim bindView As DataView = Nothing
            If TypeOf _originalDataSource Is BindingSource Then
                Dim bs = DirectCast(_originalDataSource, BindingSource)
                Dim srcTable As DataTable = Nothing
                Dim baseFilter As String = ""
                Dim baseSort As String = ""
                If TypeOf bs.DataSource Is DataTable Then
                    srcTable = DirectCast(bs.DataSource, DataTable)
                    baseFilter = If(bs.Filter, "")
                    baseSort = If(bs.Sort, "")
                ElseIf TypeOf bs.DataSource Is DataView Then
                    Dim dv2 = DirectCast(bs.DataSource, DataView)
                    srcTable = dv2.Table
                    baseFilter = If(Not String.IsNullOrEmpty(bs.Filter), bs.Filter, If(dv2.RowFilter, ""))
                    baseSort = If(Not String.IsNullOrEmpty(bs.Sort), bs.Sort, If(dv2.Sort, ""))
                End If
                If srcTable IsNot Nothing Then
                    bindView = New DataView(srcTable, baseFilter, baseSort, DataViewRowState.CurrentRows)
                End If
            ElseIf TypeOf _originalDataSource Is DataView Then
                bindView = DirectCast(_originalDataSource, DataView)
            End If
            If bindView Is Nothing Then
                bindView = If(_dataTable IsNot Nothing, _dataTable.DefaultView, Nothing)
            End If
            _dgv.DataSource = bindView
            _popupBaseFilter = If(bindView IsNot Nothing, bindView.RowFilter, "") ' John 18/09/2026

            ' Apply hidden columns (1-based index)
            For Each col As DataGridViewColumn In _dgv.Columns
                If _sharedModel.Cols.Hidden(col.Index + 1) Then
                    col.Visible = False
                End If
            Next

            ' Apply custom header text from QueryCellInfo handlers
            For Each col As DataGridViewColumn In _dgv.Columns
                Dim args As New GridQueryCellInfoEventArgs(0, col.Index + 1)
                _sharedModel.RaiseQueryCellInfo(args)
                If Not String.IsNullOrEmpty(args.Style.Text) Then
                    col.HeaderText = args.Style.Text
                End If
                If args.Style.Font IsNot Nothing Then
                    col.HeaderCell.Style.Font = args.Style.Font.Font
                End If
            Next

            ' --- Measure popup size after DataGridView has processed columns ---
            ' Show popup off-screen first so DGV can calculate column widths
            _popup.Location = New Point(-9999, -9999)
            _popup.Size = New Size(800, 400)
            _popup.Show(Me.FindForm())

            UpdatePopupSize()

            ' Scroll to the currently selected row.
            ' Because the DGV may be showing a filtered view, we match by ValueMember
            ' rather than relying on _selectedIndex (which is the unfiltered row index).
            If _selectedIndex >= 0 AndAlso _dataTable IsNot Nothing AndAlso Not String.IsNullOrEmpty(_valueMember) Then
                Dim currentVal As String = _dataTable.Rows(_selectedIndex)(_valueMember).ToString().Trim()
                Dim hasValCol As Boolean = _dgv.Columns.Contains(_valueMember)
                For Each dgvRow As DataGridViewRow In _dgv.Rows
                    If hasValCol Then
                        Dim cellVal = dgvRow.Cells(_valueMember).Value
                        If cellVal IsNot Nothing AndAlso cellVal.ToString().Trim() = currentVal Then
                            dgvRow.Selected = True
                            _dgv.FirstDisplayedScrollingRowIndex = dgvRow.Index
                            Exit For
                        End If
                    End If
                Next
            End If

            AddHandler _dgv.CellClick, AddressOf OnDgvCellClick
            AddHandler _dgv.KeyDown, AddressOf OnDgvKeyDown

            If _allowTypeFilter Then
                ' Do NOT hook _popup.Deactivate here: reclaiming focus for the textbox
                ' below activates the owner form, which -- if the popup picked up any
                ' transient activation when shown, despite the no-activate flags --
                ' would fire Deactivate and immediately close the popup we just opened.
                ' Closing on click-away is instead handled by:
                '  - OnEditControlLeave (Leave on the textbox/button), and
                '  - the owning form's Deactivate, as a fallback for e.g. Alt+Tab, and
                '  - a global mouse-down watcher below, since a click on a non-focusable
                '    control (a Label, a blank tab area, ...) never fires Leave at all.
                ' -- John 18/09/2026
                _hookedOwnerForm = Me.FindForm()
                If _hookedOwnerForm IsNot Nothing Then AddHandler _hookedOwnerForm.Deactivate, AddressOf OnPopupDeactivate

                If _clickAwayFilter Is Nothing Then
                    _clickAwayFilter = New ClickAwayMessageFilter(AddressOf OnAnyMouseDown)
                    Application.AddMessageFilter(_clickAwayFilter)
                End If

                ' Showing the popup Form assigns it an ActiveControl (the grid, being
                ' its only child) and calls SetFocus on it internally -- this happens
                ' even though the popup window itself never activates, because it's an
                ' explicit managed focus call, not OS click/activation. Reclaim focus
                ' so typed keystrokes keep landing in the textbox. -- John 18/09/2026
                _txtDisplay.Focus()
            Else
                AddHandler _popup.Deactivate, AddressOf OnPopupDeactivate
                _dgv.Focus()
            End If
        End Sub

        ''' <summary>Recomputes popup width/height/position from the DataGridView's
        ''' current (possibly filtered) rows. Called on open and after each
        ''' type-to-filter keystroke. -- John 18/09/2026</summary>
        Private Sub UpdatePopupSize()
            If _popup Is Nothing OrElse _popup.IsDisposed OrElse _dgv Is Nothing Then Return

            ' Force DGV to measure column widths with real data
            _dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)

            ' Sum visible column widths to get total content width
            Dim totalColW As Integer = 0
            For Each col As DataGridViewColumn In _dgv.Columns
                If col.Visible Then totalColW += col.Width
            Next
            ' Add scrollbar width margin
            totalColW += SystemInformation.VerticalScrollBarWidth + 4

            ' Calculate height: header + data rows (max 12 visible rows) + scrollbar allowance
            Dim rowH As Integer = _dgv.RowTemplate.Height
            Dim headerH As Integer = _dgv.ColumnHeadersHeight
            Dim rowCount As Integer = _dgv.Rows.Count
            Dim maxRows As Integer = Math.Min(rowCount, 12)
            Dim dataH As Integer = maxRows * rowH
            Dim hasScroll As Boolean = (rowCount > 12)
            Dim scrollH As Integer = If(hasScroll, SystemInformation.HorizontalScrollBarHeight, 0)
            Dim popupH As Integer = headerH + dataH + scrollH + 4
            If rowCount = 0 Then popupH = headerH + rowH + 4

            ' Width: at least as wide as the control, at most screen width - margin
            Dim screenPt As Point = Me.PointToScreen(New Point(0, Me.Height))
            Dim screenW As Integer = Screen.FromControl(Me).WorkingArea.Width
            Dim screenH As Integer = Screen.FromControl(Me).WorkingArea.Bottom
            Dim popupW As Integer = Math.Min(Math.Max(Me.Width, totalColW), screenW - screenPt.X - 4)

            ' Flip up if not enough space below
            Dim popupY As Integer = screenPt.Y
            If popupY + popupH > screenH Then
                Dim abovePt As Point = Me.PointToScreen(New Point(0, 0))
                popupY = abovePt.Y - popupH
                If popupY < 0 Then popupY = 0
            End If

            _popup.Location = New Point(screenPt.X, popupY)
            _popup.Size = New Size(popupW, popupH)
        End Sub

        ''' <summary>Refilters the popup grid to rows whose DisplayMember starts with
        ''' the typed text (not "contains anywhere"), layered on top of whatever base
        ''' BindingSource filter was active when the popup opened (e.g. Ship-To
        ''' filtered by Bill-To). -- John 18/09/2026</summary>
        Private Sub ApplyTypeFilter(typedText As String)
            If _dgv Is Nothing OrElse _dgv.IsDisposed Then Return
            Dim dv As DataView = TryCast(_dgv.DataSource, DataView)
            If dv Is Nothing Then Return

            Dim filterExpr As String = _popupBaseFilter
            Dim trimmedText As String = If(typedText, "").Trim()
            If trimmedText <> "" AndAlso Not String.IsNullOrEmpty(_displayMember) AndAlso dv.Table.Columns.Contains(_displayMember) Then
                Dim likeExpr As String = "[" & _displayMember & "] LIKE '" & EscapeLikeValue(trimmedText) & "%'"
                filterExpr = If(String.IsNullOrEmpty(filterExpr), likeExpr, "(" & filterExpr & ") AND (" & likeExpr & ")")
            End If

            Try
                dv.RowFilter = filterExpr
            Catch
                ' Malformed filter expression (unusual characters) -- keep prior filter
            End Try

            UpdatePopupSize()
        End Sub

        Private Function EscapeLikeValue(s As String) As String
            Dim result As String = s.Replace("[", "[[]")
            result = result.Replace("*", "[*]").Replace("%", "[%]")
            result = result.Replace("'", "''")
            Return result
        End Function

        Private Sub ClosePopup()
            If _popup Is Nothing OrElse _popup.IsDisposed Then Return
            RemoveHandler _popup.Deactivate, AddressOf OnPopupDeactivate
            If _hookedOwnerForm IsNot Nothing Then
                RemoveHandler _hookedOwnerForm.Deactivate, AddressOf OnPopupDeactivate
                _hookedOwnerForm = Nothing
            End If
            If _clickAwayFilter IsNot Nothing Then
                Application.RemoveMessageFilter(_clickAwayFilter)
                _clickAwayFilter = Nothing
            End If
            _popup.Close()
            _popup.Dispose()
            _popup = Nothing
        End Sub

        Private Sub OnDgvCellClick(s As Object, e As DataGridViewCellEventArgs)
            If e.RowIndex >= 0 Then
                CommitSelection(e.RowIndex)
                ClosePopup()
            End If
        End Sub

        Private Sub OnDgvKeyDown(s As Object, e As KeyEventArgs)
            Select Case e.KeyCode
                Case Keys.Enter
                    If _dgv.CurrentRow IsNot Nothing Then
                        CommitSelection(_dgv.CurrentRow.Index)
                        ClosePopup()
                        e.Handled = True
                    End If
                Case Keys.Escape
                    ClosePopup()
                    e.Handled = True
            End Select
        End Sub

        Private Sub OnPopupDeactivate(s As Object, e As EventArgs)
            ClosePopup()
        End Sub

        Private Sub CommitSelection(rowIndex As Integer)
            If _dgv Is Nothing OrElse rowIndex < 0 OrElse rowIndex >= _dgv.Rows.Count Then Return

            ' Read display text and value directly from the DGV row.
            Dim displayVal As String = ""
            Dim valueVal As Object = Nothing

            If Not String.IsNullOrEmpty(_displayMember) AndAlso _dgv.Columns.Contains(_displayMember) Then
                Dim raw = _dgv.Rows(rowIndex).Cells(_displayMember).Value
                If raw IsNot Nothing Then displayVal = raw.ToString()
            End If
            If Not String.IsNullOrEmpty(_valueMember) AndAlso _dgv.Columns.Contains(_valueMember) Then
                valueVal = _dgv.Rows(rowIndex).Cells(_valueMember).Value
            End If

            SetDisplayText(displayVal)

            ' Map back to the row index in the unfiltered DataTable so that
            ' Model(SelectedIndex + 1, col) lookups continue to work correctly.
            _selectedIndex = -1
            If _dataTable IsNot Nothing AndAlso valueVal IsNot Nothing AndAlso Not String.IsNullOrEmpty(_valueMember) Then
                Dim searchStr As String = valueVal.ToString().Trim()
                For i As Integer = 0 To _dataTable.Rows.Count - 1
                    If _dataTable.Rows(i)(_valueMember).ToString().Trim() = searchStr Then
                        _selectedIndex = i
                        Exit For
                    End If
                Next
            End If

            RaiseEvent SelectedIndexChanged(Me, EventArgs.Empty)
            RaiseEvent SelectedValueChanged(Me, EventArgs.Empty)
            RaiseEvent DropDownCloseOnClick(Me, New MouseClickCancelEventArgs())
        End Sub

        '------------------------------------------------------------------ '
        ' ISupportInitialize
        '------------------------------------------------------------------ '

        Public Sub BeginInit() Implements ISupportInitialize.BeginInit
        End Sub

        Public Sub EndInit() Implements ISupportInitialize.EndInit
        End Sub

        '------------------------------------------------------------------ '
        ' Cleanup
        '------------------------------------------------------------------ '
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing Then
                ClosePopup()
            End If
            MyBase.Dispose(disposing)
        End Sub

        ''' <summary>
        ''' Popup window that displays without becoming the active window, so showing
        ''' or refiltering it never steals keyboard focus away from the combo box's
        ''' textbox while the user is typing. Selection is still made by mouse click
        ''' (DataGridView handles its own clicks regardless of window activation) or
        ''' by Enter/Escape typed into the textbox. -- John 18/09/2026
        ''' </summary>
        Private Class NonActivatingPopup
            Inherits Form

            Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
                Get
                    Return True
                End Get
            End Property

            Protected Overrides ReadOnly Property CreateParams As CreateParams
                Get
                    Const WS_EX_NOACTIVATE As Integer = &H8000000
                    Dim cp As CreateParams = MyBase.CreateParams
                    cp.ExStyle = cp.ExStyle Or WS_EX_NOACTIVATE
                    Return cp
                End Get
            End Property
        End Class

        ''' <summary>
        ''' Application-wide mouse-down watcher used while a type-filter popup is
        ''' open, so clicking anywhere that isn't the combo box or its popup closes
        ''' the list -- including clicks on non-focusable controls (Label, Panel,
        ''' blank tab area) that never raise a Leave event on the textbox.
        ''' -- John 18/09/2026
        ''' </summary>
        Private Class ClickAwayMessageFilter
            Implements IMessageFilter

            Private Const WM_LBUTTONDOWN As Integer = &H201
            Private Const WM_RBUTTONDOWN As Integer = &H204
            Private Const WM_MBUTTONDOWN As Integer = &H207
            Private Const WM_NCLBUTTONDOWN As Integer = &HA1
            Private Const WM_NCRBUTTONDOWN As Integer = &HA4

            Private ReadOnly _onOutsideClick As Action

            Public Sub New(onOutsideClick As Action)
                _onOutsideClick = onOutsideClick
            End Sub

            Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
                Select Case m.Msg
                    Case WM_LBUTTONDOWN, WM_RBUTTONDOWN, WM_MBUTTONDOWN, WM_NCLBUTTONDOWN, WM_NCRBUTTONDOWN
                        _onOutsideClick()
                End Select
                Return False ' never swallow the message -- only observe it
            End Function
        End Class

    End Class

End Namespace
