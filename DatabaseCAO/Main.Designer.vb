<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.myGrid = New System.Windows.Forms.DataGridView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.lblPPSN = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtPPSN = New System.Windows.Forms.TextBox()
        Me.lbl5N0783 = New System.Windows.Forms.Label()
        Me.lbl5N0690 = New System.Windows.Forms.Label()
        Me.lbl5N1356 = New System.Windows.Forms.Label()
        Me.lbl5N2434 = New System.Windows.Forms.Label()
        Me.lbl5N2927 = New System.Windows.Forms.Label()
        Me.lbl5N18396 = New System.Windows.Forms.Label()
        Me.lbl5N0548 = New System.Windows.Forms.Label()
        Me.lbl5N2929 = New System.Windows.Forms.Label()
        Me.lbl5N2928 = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txt5N2928 = New System.Windows.Forms.TextBox()
        Me.txt5N2929 = New System.Windows.Forms.TextBox()
        Me.txt5N0548 = New System.Windows.Forms.TextBox()
        Me.txt5N2434 = New System.Windows.Forms.TextBox()
        Me.txt5N2927 = New System.Windows.Forms.TextBox()
        Me.txt5N18396 = New System.Windows.Forms.TextBox()
        Me.txt5N0783 = New System.Windows.Forms.TextBox()
        Me.txt5N0690 = New System.Windows.Forms.TextBox()
        Me.txt5N1356 = New System.Windows.Forms.TextBox()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.chkPartialSearch = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmbPPSNList = New System.Windows.Forms.ComboBox()
        Me.btnShowCourses = New System.Windows.Forms.Button()
        Me.caoGrid = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.txtPoints = New System.Windows.Forms.TextBox()
        Me.lblPoints = New System.Windows.Forms.Label()
        CType(Me.myGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.caoGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'myGrid
        '
        Me.myGrid.AllowUserToAddRows = False
        Me.myGrid.AllowUserToDeleteRows = False
        Me.myGrid.AllowUserToResizeColumns = False
        Me.myGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.myGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.myGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.myGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.myGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.myGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.myGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.myGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.myGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.myGrid.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.myGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.myGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.myGrid.EnableHeadersVisualStyles = False
        Me.myGrid.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.myGrid.Location = New System.Drawing.Point(225, 22)
        Me.myGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.myGrid.MultiSelect = False
        Me.myGrid.Name = "myGrid"
        Me.myGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.myGrid.RowHeadersVisible = False
        Me.myGrid.RowHeadersWidth = 20
        Me.myGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.myGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.myGrid.Size = New System.Drawing.Size(738, 377)
        Me.myGrid.TabIndex = 0
        Me.myGrid.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.HotPink
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(16, 269)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 24)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.Color.Yellow
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnInsert.Location = New System.Drawing.Point(115, 269)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(87, 24)
        Me.btnInsert.TabIndex = 14
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        '
        'lblPPSN
        '
        Me.lblPPSN.AutoSize = True
        Me.lblPPSN.BackColor = System.Drawing.Color.AliceBlue
        Me.lblPPSN.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPSN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPPSN.Location = New System.Drawing.Point(60, 23)
        Me.lblPPSN.Name = "lblPPSN"
        Me.lblPPSN.Size = New System.Drawing.Size(35, 15)
        Me.lblPPSN.TabIndex = 7
        Me.lblPPSN.Text = "PPSN"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Lime
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(16, 329)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(87, 24)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtPPSN
        '
        Me.txtPPSN.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPSN.Location = New System.Drawing.Point(118, 20)
        Me.txtPPSN.MaxLength = 8
        Me.txtPPSN.Name = "txtPPSN"
        Me.txtPPSN.Size = New System.Drawing.Size(74, 23)
        Me.txtPPSN.TabIndex = 1
        Me.txtPPSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl5N0783
        '
        Me.lbl5N0783.AutoSize = True
        Me.lbl5N0783.BackColor = System.Drawing.Color.AliceBlue
        Me.lbl5N0783.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N0783.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5N0783.Location = New System.Drawing.Point(17, 203)
        Me.lbl5N0783.Name = "lbl5N0783"
        Me.lbl5N0783.Size = New System.Drawing.Size(50, 15)
        Me.lbl5N0783.TabIndex = 14
        Me.lbl5N0783.Text = "5N0783"
        '
        'lbl5N0690
        '
        Me.lbl5N0690.AutoSize = True
        Me.lbl5N0690.BackColor = System.Drawing.Color.AliceBlue
        Me.lbl5N0690.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N0690.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5N0690.Location = New System.Drawing.Point(116, 203)
        Me.lbl5N0690.Name = "lbl5N0690"
        Me.lbl5N0690.Size = New System.Drawing.Size(50, 15)
        Me.lbl5N0690.TabIndex = 15
        Me.lbl5N0690.Text = "5N0690"
        '
        'lbl5N1356
        '
        Me.lbl5N1356.AutoSize = True
        Me.lbl5N1356.BackColor = System.Drawing.Color.AliceBlue
        Me.lbl5N1356.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N1356.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5N1356.Location = New System.Drawing.Point(17, 232)
        Me.lbl5N1356.Name = "lbl5N1356"
        Me.lbl5N1356.Size = New System.Drawing.Size(50, 15)
        Me.lbl5N1356.TabIndex = 16
        Me.lbl5N1356.Text = "5N1356"
        '
        'lbl5N2434
        '
        Me.lbl5N2434.AutoSize = True
        Me.lbl5N2434.BackColor = System.Drawing.Color.AliceBlue
        Me.lbl5N2434.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N2434.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5N2434.Location = New System.Drawing.Point(116, 144)
        Me.lbl5N2434.Name = "lbl5N2434"
        Me.lbl5N2434.Size = New System.Drawing.Size(50, 15)
        Me.lbl5N2434.TabIndex = 17
        Me.lbl5N2434.Text = "5N2434"
        '
        'lbl5N2927
        '
        Me.lbl5N2927.AutoSize = True
        Me.lbl5N2927.BackColor = System.Drawing.Color.AliceBlue
        Me.lbl5N2927.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N2927.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5N2927.Location = New System.Drawing.Point(17, 172)
        Me.lbl5N2927.Name = "lbl5N2927"
        Me.lbl5N2927.Size = New System.Drawing.Size(50, 15)
        Me.lbl5N2927.TabIndex = 18
        Me.lbl5N2927.Text = "5N2927"
        '
        'lbl5N18396
        '
        Me.lbl5N18396.AutoSize = True
        Me.lbl5N18396.BackColor = System.Drawing.Color.AliceBlue
        Me.lbl5N18396.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N18396.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5N18396.Location = New System.Drawing.Point(116, 174)
        Me.lbl5N18396.Name = "lbl5N18396"
        Me.lbl5N18396.Size = New System.Drawing.Size(57, 15)
        Me.lbl5N18396.TabIndex = 19
        Me.lbl5N18396.Text = "5N18396"
        '
        'lbl5N0548
        '
        Me.lbl5N0548.AutoSize = True
        Me.lbl5N0548.BackColor = System.Drawing.Color.AliceBlue
        Me.lbl5N0548.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N0548.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5N0548.Location = New System.Drawing.Point(17, 144)
        Me.lbl5N0548.Name = "lbl5N0548"
        Me.lbl5N0548.Size = New System.Drawing.Size(50, 15)
        Me.lbl5N0548.TabIndex = 20
        Me.lbl5N0548.Text = "5N0548"
        '
        'lbl5N2929
        '
        Me.lbl5N2929.AutoSize = True
        Me.lbl5N2929.BackColor = System.Drawing.Color.AliceBlue
        Me.lbl5N2929.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N2929.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5N2929.Location = New System.Drawing.Point(116, 117)
        Me.lbl5N2929.Name = "lbl5N2929"
        Me.lbl5N2929.Size = New System.Drawing.Size(50, 15)
        Me.lbl5N2929.TabIndex = 21
        Me.lbl5N2929.Text = "5N2929"
        '
        'lbl5N2928
        '
        Me.lbl5N2928.AutoSize = True
        Me.lbl5N2928.BackColor = System.Drawing.Color.AliceBlue
        Me.lbl5N2928.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N2928.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl5N2928.Location = New System.Drawing.Point(17, 117)
        Me.lbl5N2928.Name = "lbl5N2928"
        Me.lbl5N2928.Size = New System.Drawing.Size(50, 15)
        Me.lbl5N2928.TabIndex = 22
        Me.lbl5N2928.Text = "5N2928"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.BackColor = System.Drawing.Color.AliceBlue
        Me.lblSurname.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSurname.Location = New System.Drawing.Point(34, 82)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(55, 15)
        Me.lblSurname.TabIndex = 23
        Me.lblSurname.Text = "Surname"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.BackColor = System.Drawing.Color.AliceBlue
        Me.lblForename.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblForename.Location = New System.Drawing.Point(34, 52)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(61, 15)
        Me.lblForename.TabIndex = 24
        Me.lblForename.Text = "Forename"
        '
        'txtForename
        '
        Me.txtForename.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtForename.Location = New System.Drawing.Point(118, 49)
        Me.txtForename.MaxLength = 30
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(74, 23)
        Me.txtForename.TabIndex = 2
        Me.txtForename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(118, 79)
        Me.txtSurname.MaxLength = 30
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(74, 23)
        Me.txtSurname.TabIndex = 3
        Me.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N2928
        '
        Me.txt5N2928.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N2928.Location = New System.Drawing.Point(74, 113)
        Me.txt5N2928.MaxLength = 3
        Me.txt5N2928.Name = "txt5N2928"
        Me.txt5N2928.Size = New System.Drawing.Size(27, 23)
        Me.txt5N2928.TabIndex = 4
        Me.txt5N2928.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N2929
        '
        Me.txt5N2929.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N2929.Location = New System.Drawing.Point(176, 114)
        Me.txt5N2929.MaxLength = 3
        Me.txt5N2929.Name = "txt5N2929"
        Me.txt5N2929.Size = New System.Drawing.Size(27, 23)
        Me.txt5N2929.TabIndex = 5
        Me.txt5N2929.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N0548
        '
        Me.txt5N0548.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N0548.Location = New System.Drawing.Point(74, 141)
        Me.txt5N0548.MaxLength = 3
        Me.txt5N0548.Name = "txt5N0548"
        Me.txt5N0548.Size = New System.Drawing.Size(27, 23)
        Me.txt5N0548.TabIndex = 6
        Me.txt5N0548.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N2434
        '
        Me.txt5N2434.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N2434.Location = New System.Drawing.Point(176, 142)
        Me.txt5N2434.MaxLength = 3
        Me.txt5N2434.Name = "txt5N2434"
        Me.txt5N2434.Size = New System.Drawing.Size(27, 23)
        Me.txt5N2434.TabIndex = 7
        Me.txt5N2434.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N2927
        '
        Me.txt5N2927.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N2927.Location = New System.Drawing.Point(74, 170)
        Me.txt5N2927.MaxLength = 3
        Me.txt5N2927.Name = "txt5N2927"
        Me.txt5N2927.Size = New System.Drawing.Size(27, 23)
        Me.txt5N2927.TabIndex = 8
        Me.txt5N2927.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N18396
        '
        Me.txt5N18396.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N18396.Location = New System.Drawing.Point(176, 171)
        Me.txt5N18396.MaxLength = 3
        Me.txt5N18396.Name = "txt5N18396"
        Me.txt5N18396.Size = New System.Drawing.Size(27, 23)
        Me.txt5N18396.TabIndex = 9
        Me.txt5N18396.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N0783
        '
        Me.txt5N0783.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N0783.Location = New System.Drawing.Point(74, 199)
        Me.txt5N0783.MaxLength = 3
        Me.txt5N0783.Name = "txt5N0783"
        Me.txt5N0783.Size = New System.Drawing.Size(27, 23)
        Me.txt5N0783.TabIndex = 10
        Me.txt5N0783.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N0690
        '
        Me.txt5N0690.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N0690.Location = New System.Drawing.Point(176, 200)
        Me.txt5N0690.MaxLength = 3
        Me.txt5N0690.Name = "txt5N0690"
        Me.txt5N0690.Size = New System.Drawing.Size(27, 23)
        Me.txt5N0690.TabIndex = 11
        Me.txt5N0690.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N1356
        '
        Me.txt5N1356.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N1356.Location = New System.Drawing.Point(74, 229)
        Me.txt5N1356.MaxLength = 3
        Me.txt5N1356.Name = "txt5N1356"
        Me.txt5N1356.Size = New System.Drawing.Size(27, 23)
        Me.txt5N1356.TabIndex = 12
        Me.txt5N1356.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModify.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btnModify.Location = New System.Drawing.Point(115, 329)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(87, 24)
        Me.btnModify.TabIndex = 16
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = False
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.Location = New System.Drawing.Point(115, 358)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(87, 23)
        Me.txtSearchBox.TabIndex = 29
        '
        'chkPartialSearch
        '
        Me.chkPartialSearch.AutoSize = True
        Me.chkPartialSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPartialSearch.Location = New System.Drawing.Point(9, 390)
        Me.chkPartialSearch.Name = "chkPartialSearch"
        Me.chkPartialSearch.Size = New System.Drawing.Size(103, 19)
        Me.chkPartialSearch.TabIndex = 28
        Me.chkPartialSearch.Text = "Partial Search"
        Me.chkPartialSearch.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Aqua
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnSearch.Location = New System.Drawing.Point(16, 358)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 24)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cmbPPSNList
        '
        Me.cmbPPSNList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPPSNList.DropDownHeight = 120
        Me.cmbPPSNList.FormattingEnabled = True
        Me.cmbPPSNList.IntegralHeight = False
        Me.cmbPPSNList.Location = New System.Drawing.Point(116, 387)
        Me.cmbPPSNList.Name = "cmbPPSNList"
        Me.cmbPPSNList.Size = New System.Drawing.Size(86, 21)
        Me.cmbPPSNList.TabIndex = 30
        '
        'btnShowCourses
        '
        Me.btnShowCourses.BackColor = System.Drawing.Color.Aquamarine
        Me.btnShowCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowCourses.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowCourses.ForeColor = System.Drawing.Color.Black
        Me.btnShowCourses.Location = New System.Drawing.Point(16, 299)
        Me.btnShowCourses.Name = "btnShowCourses"
        Me.btnShowCourses.Size = New System.Drawing.Size(187, 24)
        Me.btnShowCourses.TabIndex = 31
        Me.btnShowCourses.Text = "Eligible Courses"
        Me.btnShowCourses.UseVisualStyleBackColor = False
        '
        'caoGrid
        '
        Me.caoGrid.AllowUserToAddRows = False
        Me.caoGrid.AllowUserToDeleteRows = False
        Me.caoGrid.AllowUserToResizeColumns = False
        Me.caoGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.caoGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.caoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.caoGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.caoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.caoGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.caoGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.caoGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.caoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.caoGrid.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.caoGrid.DefaultCellStyle = DataGridViewCellStyle6
        Me.caoGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.caoGrid.EnableHeadersVisualStyles = False
        Me.caoGrid.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.caoGrid.Location = New System.Drawing.Point(225, 22)
        Me.caoGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.caoGrid.MultiSelect = False
        Me.caoGrid.Name = "caoGrid"
        Me.caoGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.caoGrid.RowHeadersVisible = False
        Me.caoGrid.RowHeadersWidth = 20
        Me.caoGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.caoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.caoGrid.Size = New System.Drawing.Size(489, 377)
        Me.caoGrid.TabIndex = 32
        Me.caoGrid.TabStop = False
        Me.caoGrid.Visible = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.HotPink
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(16, 312)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(187, 24)
        Me.btnBack.TabIndex = 33
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.Visible = False
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.Red
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.ForeColor = System.Drawing.SystemColors.Control
        Me.btnHelp.Location = New System.Drawing.Point(16, 14)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(29, 29)
        Me.btnHelp.TabIndex = 34
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'txtPoints
        '
        Me.txtPoints.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoints.Location = New System.Drawing.Point(159, 229)
        Me.txtPoints.MaxLength = 3
        Me.txtPoints.Name = "txtPoints"
        Me.txtPoints.ReadOnly = True
        Me.txtPoints.Size = New System.Drawing.Size(44, 23)
        Me.txtPoints.TabIndex = 35
        Me.txtPoints.TabStop = False
        Me.txtPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.BackColor = System.Drawing.Color.AliceBlue
        Me.lblPoints.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPoints.Location = New System.Drawing.Point(115, 233)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(42, 15)
        Me.lblPoints.TabIndex = 36
        Me.lblPoints.Text = "Points"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(980, 423)
        Me.Controls.Add(Me.txtPoints)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.caoGrid)
        Me.Controls.Add(Me.btnShowCourses)
        Me.Controls.Add(Me.cmbPPSNList)
        Me.Controls.Add(Me.txtSearchBox)
        Me.Controls.Add(Me.chkPartialSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txt5N1356)
        Me.Controls.Add(Me.txt5N0690)
        Me.Controls.Add(Me.txt5N0783)
        Me.Controls.Add(Me.txt5N18396)
        Me.Controls.Add(Me.txt5N2927)
        Me.Controls.Add(Me.txt5N2434)
        Me.Controls.Add(Me.txt5N0548)
        Me.Controls.Add(Me.txt5N2929)
        Me.Controls.Add(Me.txt5N2928)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtForename)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lbl5N2928)
        Me.Controls.Add(Me.lbl5N2929)
        Me.Controls.Add(Me.lbl5N0548)
        Me.Controls.Add(Me.lbl5N18396)
        Me.Controls.Add(Me.lbl5N2927)
        Me.Controls.Add(Me.lbl5N2434)
        Me.Controls.Add(Me.lbl5N1356)
        Me.Controls.Add(Me.lbl5N0690)
        Me.Controls.Add(Me.lbl5N0783)
        Me.Controls.Add(Me.txtPPSN)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.lblPPSN)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.myGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Project"
        CType(Me.myGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.caoGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents myGrid As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents lblPPSN As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtPPSN As TextBox
    Friend WithEvents lbl5N0783 As Label
    Friend WithEvents lbl5N0690 As Label
    Friend WithEvents lbl5N1356 As Label
    Friend WithEvents lbl5N2434 As Label
    Friend WithEvents lbl5N2927 As Label
    Friend WithEvents lbl5N18396 As Label
    Friend WithEvents lbl5N0548 As Label
    Friend WithEvents lbl5N2929 As Label
    Friend WithEvents lbl5N2928 As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblForename As Label
    Friend WithEvents txtForename As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txt5N2928 As TextBox
    Friend WithEvents txt5N2929 As TextBox
    Friend WithEvents txt5N0548 As TextBox
    Friend WithEvents txt5N2434 As TextBox
    Friend WithEvents txt5N2927 As TextBox
    Friend WithEvents txt5N18396 As TextBox
    Friend WithEvents txt5N0783 As TextBox
    Friend WithEvents txt5N0690 As TextBox
    Friend WithEvents txt5N1356 As TextBox
    Friend WithEvents btnModify As Button
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents chkPartialSearch As CheckBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbPPSNList As ComboBox
    Friend WithEvents btnShowCourses As Button
    Friend WithEvents caoGrid As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents txtPoints As TextBox
    Friend WithEvents lblPoints As Label
End Class
