<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.chkPartialSearch = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmbProductNumbers = New System.Windows.Forms.ComboBox()
        CType(Me.myGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.myGrid.Location = New System.Drawing.Point(230, 24)
        Me.myGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.myGrid.MultiSelect = False
        Me.myGrid.Name = "myGrid"
        Me.myGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.myGrid.RowHeadersVisible = False
        Me.myGrid.RowHeadersWidth = 20
        Me.myGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.myGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.myGrid.Size = New System.Drawing.Size(718, 377)
        Me.myGrid.TabIndex = 0
        Me.myGrid.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.HotPink
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(161, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(51, 24)
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
        Me.btnInsert.Location = New System.Drawing.Point(131, 293)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(61, 24)
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
        Me.lblPPSN.Location = New System.Drawing.Point(34, 23)
        Me.lblPPSN.Name = "lblPPSN"
        Me.lblPPSN.Size = New System.Drawing.Size(35, 15)
        Me.lblPPSN.TabIndex = 7
        Me.lblPPSN.Text = "PPSN"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.SlateBlue
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(131, 328)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(61, 24)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtPPSN
        '
        Me.txtPPSN.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPPSN.Location = New System.Drawing.Point(118, 20)
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
        Me.lbl5N0783.Location = New System.Drawing.Point(19, 223)
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
        Me.lbl5N0690.Location = New System.Drawing.Point(115, 223)
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
        Me.lbl5N1356.Location = New System.Drawing.Point(19, 255)
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
        Me.lbl5N2434.Location = New System.Drawing.Point(115, 156)
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
        Me.lbl5N2927.Location = New System.Drawing.Point(19, 188)
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
        Me.lbl5N18396.Location = New System.Drawing.Point(115, 188)
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
        Me.lbl5N0548.Location = New System.Drawing.Point(19, 156)
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
        Me.lbl5N2929.Location = New System.Drawing.Point(115, 123)
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
        Me.lbl5N2928.Location = New System.Drawing.Point(19, 123)
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
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(74, 23)
        Me.txtForename.TabIndex = 2
        Me.txtForename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(118, 79)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(74, 23)
        Me.txtSurname.TabIndex = 3
        Me.txtSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N2928
        '
        Me.txt5N2928.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N2928.Location = New System.Drawing.Point(76, 120)
        Me.txt5N2928.MaxLength = 3
        Me.txt5N2928.Name = "txt5N2928"
        Me.txt5N2928.Size = New System.Drawing.Size(27, 23)
        Me.txt5N2928.TabIndex = 4
        Me.txt5N2928.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N2929
        '
        Me.txt5N2929.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N2929.Location = New System.Drawing.Point(177, 120)
        Me.txt5N2929.MaxLength = 3
        Me.txt5N2929.Name = "txt5N2929"
        Me.txt5N2929.Size = New System.Drawing.Size(27, 23)
        Me.txt5N2929.TabIndex = 5
        Me.txt5N2929.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N0548
        '
        Me.txt5N0548.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N0548.Location = New System.Drawing.Point(76, 153)
        Me.txt5N0548.MaxLength = 3
        Me.txt5N0548.Name = "txt5N0548"
        Me.txt5N0548.Size = New System.Drawing.Size(27, 23)
        Me.txt5N0548.TabIndex = 6
        Me.txt5N0548.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N2434
        '
        Me.txt5N2434.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N2434.Location = New System.Drawing.Point(177, 153)
        Me.txt5N2434.MaxLength = 3
        Me.txt5N2434.Name = "txt5N2434"
        Me.txt5N2434.Size = New System.Drawing.Size(27, 23)
        Me.txt5N2434.TabIndex = 7
        Me.txt5N2434.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N2927
        '
        Me.txt5N2927.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N2927.Location = New System.Drawing.Point(76, 185)
        Me.txt5N2927.MaxLength = 3
        Me.txt5N2927.Name = "txt5N2927"
        Me.txt5N2927.Size = New System.Drawing.Size(27, 23)
        Me.txt5N2927.TabIndex = 8
        Me.txt5N2927.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N18396
        '
        Me.txt5N18396.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N18396.Location = New System.Drawing.Point(177, 185)
        Me.txt5N18396.MaxLength = 3
        Me.txt5N18396.Name = "txt5N18396"
        Me.txt5N18396.Size = New System.Drawing.Size(27, 23)
        Me.txt5N18396.TabIndex = 9
        Me.txt5N18396.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N0783
        '
        Me.txt5N0783.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N0783.Location = New System.Drawing.Point(76, 219)
        Me.txt5N0783.MaxLength = 3
        Me.txt5N0783.Name = "txt5N0783"
        Me.txt5N0783.Size = New System.Drawing.Size(27, 23)
        Me.txt5N0783.TabIndex = 10
        Me.txt5N0783.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N0690
        '
        Me.txt5N0690.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N0690.Location = New System.Drawing.Point(177, 220)
        Me.txt5N0690.MaxLength = 3
        Me.txt5N0690.Name = "txt5N0690"
        Me.txt5N0690.Size = New System.Drawing.Size(27, 23)
        Me.txt5N0690.TabIndex = 11
        Me.txt5N0690.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt5N1356
        '
        Me.txt5N1356.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5N1356.Location = New System.Drawing.Point(76, 253)
        Me.txt5N1356.MaxLength = 3
        Me.txt5N1356.Name = "txt5N1356"
        Me.txt5N1356.Size = New System.Drawing.Size(27, 23)
        Me.txt5N1356.TabIndex = 12
        Me.txt5N1356.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Chartreuse
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnView.Location = New System.Drawing.Point(28, 293)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(61, 24)
        Me.btnView.TabIndex = 13
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.Window
        Me.btnUpdate.Location = New System.Drawing.Point(28, 328)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(61, 24)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.Location = New System.Drawing.Point(79, 368)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(76, 23)
        Me.txtSearchBox.TabIndex = 29
        '
        'chkPartialSearch
        '
        Me.chkPartialSearch.AutoSize = True
        Me.chkPartialSearch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPartialSearch.Location = New System.Drawing.Point(62, 395)
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
        Me.btnSearch.Location = New System.Drawing.Point(12, 367)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(61, 24)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cmbProductNumbers
        '
        Me.cmbProductNumbers.FormattingEnabled = True
        Me.cmbProductNumbers.Location = New System.Drawing.Point(118, 255)
        Me.cmbProductNumbers.Name = "cmbProductNumbers"
        Me.cmbProductNumbers.Size = New System.Drawing.Size(86, 21)
        Me.cmbProductNumbers.TabIndex = 30
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 424)
        Me.Controls.Add(Me.cmbProductNumbers)
        Me.Controls.Add(Me.txtSearchBox)
        Me.Controls.Add(Me.chkPartialSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnView)
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
        Me.Controls.Add(Me.btnUpdate)
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
        Me.Name = "Main"
        Me.Opacity = 0.95R
        Me.Text = "My Project"
        CType(Me.myGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnView As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents chkPartialSearch As CheckBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents cmbProductNumbers As ComboBox
End Class
