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
        Me.MyGrid = New System.Windows.Forms.DataGridView()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblSecondName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.mybtn = New System.Windows.Forms.Button()
        Me.Newbut = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.MyGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyGrid
        '
        Me.MyGrid.AllowUserToAddRows = False
        Me.MyGrid.AllowUserToDeleteRows = False
        Me.MyGrid.AllowUserToResizeColumns = False
        Me.MyGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.MyGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.MyGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.MyGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.MyGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.MyGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MyGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MyGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.MyGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.MyGrid.EnableHeadersVisualStyles = False
        Me.MyGrid.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.MyGrid.Location = New System.Drawing.Point(29, 42)
        Me.MyGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.MyGrid.MultiSelect = False
        Me.MyGrid.Name = "MyGrid"
        Me.MyGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.MyGrid.RowHeadersVisible = False
        Me.MyGrid.RowHeadersWidth = 20
        Me.MyGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MyGrid.Size = New System.Drawing.Size(931, 306)
        Me.MyGrid.TabIndex = 0
        '
        'LoadButton
        '
        Me.LoadButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LoadButton.FlatAppearance.BorderSize = 3
        Me.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LoadButton.Location = New System.Drawing.Point(776, 560)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(174, 67)
        Me.LoadButton.TabIndex = 1
        Me.LoadButton.Text = "LOAD"
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(308, 454)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(196, 29)
        Me.txtFname.TabIndex = 2
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(684, 456)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(196, 29)
        Me.txtLname.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(341, 501)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(196, 29)
        Me.txtAddress.TabIndex = 4
        '
        'txtAge
        '
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(602, 505)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(196, 29)
        Me.txtAge.TabIndex = 5
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.InsertButton.FlatAppearance.BorderSize = 3
        Me.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InsertButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.InsertButton.Location = New System.Drawing.Point(233, 560)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(149, 67)
        Me.InsertButton.TabIndex = 6
        Me.InsertButton.Text = "ADD"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblFirstName.Location = New System.Drawing.Point(176, 458)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(126, 25)
        Me.lblFirstName.TabIndex = 7
        Me.lblFirstName.Text = "First Name"
        '
        'lblSecondName
        '
        Me.lblSecondName.AutoSize = True
        Me.lblSecondName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSecondName.Location = New System.Drawing.Point(520, 458)
        Me.lblSecondName.Name = "lblSecondName"
        Me.lblSecondName.Size = New System.Drawing.Size(158, 25)
        Me.lblSecondName.TabIndex = 8
        Me.lblSecondName.Text = "Second Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAddress.Location = New System.Drawing.Point(228, 501)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(98, 25)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAge.Location = New System.Drawing.Point(543, 505)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(53, 25)
        Me.lblAge.TabIndex = 10
        Me.lblAge.Text = "Age"
        '
        'mybtn
        '
        Me.mybtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mybtn.FlatAppearance.BorderSize = 3
        Me.mybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mybtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mybtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.mybtn.Location = New System.Drawing.Point(442, 560)
        Me.mybtn.Name = "mybtn"
        Me.mybtn.Size = New System.Drawing.Size(285, 67)
        Me.mybtn.TabIndex = 11
        Me.mybtn.Text = "ReadCell"
        Me.mybtn.UseVisualStyleBackColor = False
        '
        'Newbut
        '
        Me.Newbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Newbut.FlatAppearance.BorderSize = 3
        Me.Newbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Newbut.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Newbut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Newbut.Location = New System.Drawing.Point(29, 560)
        Me.Newbut.Name = "Newbut"
        Me.Newbut.Size = New System.Drawing.Size(150, 67)
        Me.Newbut.TabIndex = 12
        Me.Newbut.Text = "Misc"
        Me.Newbut.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(116, 367)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 29)
        Me.TextBox1.TabIndex = 13
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1003, 643)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Newbut)
        Me.Controls.Add(Me.mybtn)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblSecondName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.MyGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Opacity = 0.97R
        Me.Text = "My Project"
        CType(Me.MyGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MyGrid As DataGridView
    Friend WithEvents LoadButton As Button
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents InsertButton As Button
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblSecondName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents mybtn As Button
    Friend WithEvents Newbut As Button
    Friend WithEvents TextBox1 As TextBox
End Class
