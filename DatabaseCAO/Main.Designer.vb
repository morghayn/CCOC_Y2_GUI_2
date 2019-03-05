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
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.lblPPSN = New System.Windows.Forms.Label()
        Me.Newbut = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.myGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.myGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.myGrid.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.myGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.myGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.myGrid.EnableHeadersVisualStyles = False
        Me.myGrid.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.myGrid.Location = New System.Drawing.Point(6, 7)
        Me.myGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.myGrid.MultiSelect = False
        Me.myGrid.Name = "myGrid"
        Me.myGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.myGrid.RowHeadersVisible = False
        Me.myGrid.RowHeadersWidth = 20
        Me.myGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.myGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.myGrid.Size = New System.Drawing.Size(847, 313)
        Me.myGrid.TabIndex = 0
        Me.myGrid.TabStop = False
        '
        'LoadButton
        '
        Me.LoadButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LoadButton.FlatAppearance.BorderSize = 3
        Me.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LoadButton.Location = New System.Drawing.Point(604, 483)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(174, 67)
        Me.LoadButton.TabIndex = 1
        Me.LoadButton.Text = "LOAD"
        Me.LoadButton.UseVisualStyleBackColor = False
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.InsertButton.FlatAppearance.BorderSize = 3
        Me.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InsertButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.InsertButton.Location = New System.Drawing.Point(352, 483)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(149, 67)
        Me.InsertButton.TabIndex = 6
        Me.InsertButton.Text = "ADD"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'lblPPSN
        '
        Me.lblPPSN.AutoSize = True
        Me.lblPPSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPPSN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPPSN.Location = New System.Drawing.Point(47, 348)
        Me.lblPPSN.Name = "lblPPSN"
        Me.lblPPSN.Size = New System.Drawing.Size(73, 25)
        Me.lblPPSN.TabIndex = 7
        Me.lblPPSN.Text = "PPSN"
        '
        'Newbut
        '
        Me.Newbut.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Newbut.FlatAppearance.BorderSize = 3
        Me.Newbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Newbut.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Newbut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Newbut.Location = New System.Drawing.Point(39, 483)
        Me.Newbut.Name = "Newbut"
        Me.Newbut.Size = New System.Drawing.Size(150, 67)
        Me.Newbut.TabIndex = 12
        Me.Newbut.Text = "Misc"
        Me.Newbut.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(126, 346)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(74, 29)
        Me.TextBox1.TabIndex = 13
        '
        'lbl5N0783
        '
        Me.lbl5N0783.AutoSize = True
        Me.lbl5N0783.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N0783.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl5N0783.Location = New System.Drawing.Point(674, 346)
        Me.lbl5N0783.Name = "lbl5N0783"
        Me.lbl5N0783.Size = New System.Drawing.Size(93, 25)
        Me.lbl5N0783.TabIndex = 14
        Me.lbl5N0783.Text = "5N0783"
        '
        'lbl5N0690
        '
        Me.lbl5N0690.AutoSize = True
        Me.lbl5N0690.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N0690.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl5N0690.Location = New System.Drawing.Point(674, 390)
        Me.lbl5N0690.Name = "lbl5N0690"
        Me.lbl5N0690.Size = New System.Drawing.Size(93, 25)
        Me.lbl5N0690.TabIndex = 15
        Me.lbl5N0690.Text = "5N0690"
        '
        'lbl5N1356
        '
        Me.lbl5N1356.AutoSize = True
        Me.lbl5N1356.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N1356.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl5N1356.Location = New System.Drawing.Point(674, 430)
        Me.lbl5N1356.Name = "lbl5N1356"
        Me.lbl5N1356.Size = New System.Drawing.Size(93, 25)
        Me.lbl5N1356.TabIndex = 16
        Me.lbl5N1356.Text = "5N1356"
        '
        'lbl5N2434
        '
        Me.lbl5N2434.AutoSize = True
        Me.lbl5N2434.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N2434.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl5N2434.Location = New System.Drawing.Point(481, 346)
        Me.lbl5N2434.Name = "lbl5N2434"
        Me.lbl5N2434.Size = New System.Drawing.Size(93, 25)
        Me.lbl5N2434.TabIndex = 17
        Me.lbl5N2434.Text = "5N2434"
        '
        'lbl5N2927
        '
        Me.lbl5N2927.AutoSize = True
        Me.lbl5N2927.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N2927.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl5N2927.Location = New System.Drawing.Point(481, 390)
        Me.lbl5N2927.Name = "lbl5N2927"
        Me.lbl5N2927.Size = New System.Drawing.Size(93, 25)
        Me.lbl5N2927.TabIndex = 18
        Me.lbl5N2927.Text = "5N2927"
        '
        'lbl5N18396
        '
        Me.lbl5N18396.AutoSize = True
        Me.lbl5N18396.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N18396.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl5N18396.Location = New System.Drawing.Point(481, 430)
        Me.lbl5N18396.Name = "lbl5N18396"
        Me.lbl5N18396.Size = New System.Drawing.Size(106, 25)
        Me.lbl5N18396.TabIndex = 19
        Me.lbl5N18396.Text = "5N18396"
        '
        'lbl5N0548
        '
        Me.lbl5N0548.AutoSize = True
        Me.lbl5N0548.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N0548.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl5N0548.Location = New System.Drawing.Point(295, 430)
        Me.lbl5N0548.Name = "lbl5N0548"
        Me.lbl5N0548.Size = New System.Drawing.Size(93, 25)
        Me.lbl5N0548.TabIndex = 20
        Me.lbl5N0548.Text = "5N0548"
        '
        'lbl5N2929
        '
        Me.lbl5N2929.AutoSize = True
        Me.lbl5N2929.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N2929.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl5N2929.Location = New System.Drawing.Point(295, 390)
        Me.lbl5N2929.Name = "lbl5N2929"
        Me.lbl5N2929.Size = New System.Drawing.Size(93, 25)
        Me.lbl5N2929.TabIndex = 21
        Me.lbl5N2929.Text = "5N2929"
        '
        'lbl5N2928
        '
        Me.lbl5N2928.AutoSize = True
        Me.lbl5N2928.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5N2928.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl5N2928.Location = New System.Drawing.Point(295, 348)
        Me.lbl5N2928.Name = "lbl5N2928"
        Me.lbl5N2928.Size = New System.Drawing.Size(93, 25)
        Me.lbl5N2928.TabIndex = 22
        Me.lbl5N2928.Text = "5N2928"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSurname.Location = New System.Drawing.Point(47, 430)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(105, 25)
        Me.lblSurname.TabIndex = 23
        Me.lblSurname.Text = "Surname"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblForename.Location = New System.Drawing.Point(47, 390)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(117, 25)
        Me.lblForename.TabIndex = 24
        Me.lblForename.Text = "Forename"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(883, 578)
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
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Newbut)
        Me.Controls.Add(Me.lblPPSN)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.myGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Opacity = 0.97R
        Me.Text = "My Project"
        CType(Me.myGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents myGrid As DataGridView
    Friend WithEvents LoadButton As Button
    Friend WithEvents InsertButton As Button
    Friend WithEvents lblPPSN As Label
    Friend WithEvents Newbut As Button
    Friend WithEvents TextBox1 As TextBox
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
End Class
