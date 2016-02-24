<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepreciation))
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpDepreciationType = New System.Windows.Forms.GroupBox()
        Me.radDoubleDeclining = New System.Windows.Forms.RadioButton()
        Me.radStraightLine = New System.Windows.Forms.RadioButton()
        Me.lblSelectItem = New System.Windows.Forms.Label()
        Me.cboInventoryId = New System.Windows.Forms.ComboBox()
        Me.btnCalculateDepreciation = New System.Windows.Forms.Button()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lstYear = New System.Windows.Forms.ListBox()
        Me.lblPresentValue = New System.Windows.Forms.Label()
        Me.lblYearDepreciation = New System.Windows.Forms.Label()
        Me.lblTotalDepreciation = New System.Windows.Forms.Label()
        Me.lstPresentValue = New System.Windows.Forms.ListBox()
        Me.lstYearDepreciation = New System.Windows.Forms.ListBox()
        Me.lstTotalDepreciation = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picLightSpan = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grpDepreciationType.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLightSpan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplay, Me.mnuClear, Me.ToolStripMenuItem1})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(165, 22)
        Me.mnuDisplay.Text = "Display Inventory"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(165, 22)
        Me.mnuClear.Text = "Clear"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem1.Text = "Exit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(564, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(49, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Light Span Computers Inventory"
        '
        'grpDepreciationType
        '
        Me.grpDepreciationType.Controls.Add(Me.radDoubleDeclining)
        Me.grpDepreciationType.Controls.Add(Me.radStraightLine)
        Me.grpDepreciationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDepreciationType.ForeColor = System.Drawing.Color.Gray
        Me.grpDepreciationType.Location = New System.Drawing.Point(287, 73)
        Me.grpDepreciationType.Name = "grpDepreciationType"
        Me.grpDepreciationType.Size = New System.Drawing.Size(228, 89)
        Me.grpDepreciationType.TabIndex = 2
        Me.grpDepreciationType.TabStop = False
        Me.grpDepreciationType.Text = "Select Depreciation Method:"
        '
        'radDoubleDeclining
        '
        Me.radDoubleDeclining.AutoSize = True
        Me.radDoubleDeclining.Location = New System.Drawing.Point(22, 49)
        Me.radDoubleDeclining.Name = "radDoubleDeclining"
        Me.radDoubleDeclining.Size = New System.Drawing.Size(207, 20)
        Me.radDoubleDeclining.TabIndex = 1
        Me.radDoubleDeclining.TabStop = True
        Me.radDoubleDeclining.Text = "Double-Declining Balance"
        Me.radDoubleDeclining.UseVisualStyleBackColor = True
        '
        'radStraightLine
        '
        Me.radStraightLine.AutoSize = True
        Me.radStraightLine.Location = New System.Drawing.Point(22, 22)
        Me.radStraightLine.Name = "radStraightLine"
        Me.radStraightLine.Size = New System.Drawing.Size(113, 20)
        Me.radStraightLine.TabIndex = 0
        Me.radStraightLine.TabStop = True
        Me.radStraightLine.Text = "Straight-Line"
        Me.radStraightLine.UseVisualStyleBackColor = True
        '
        'lblSelectItem
        '
        Me.lblSelectItem.AutoSize = True
        Me.lblSelectItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectItem.ForeColor = System.Drawing.Color.Gray
        Me.lblSelectItem.Location = New System.Drawing.Point(79, 73)
        Me.lblSelectItem.Name = "lblSelectItem"
        Me.lblSelectItem.Size = New System.Drawing.Size(156, 16)
        Me.lblSelectItem.TabIndex = 3
        Me.lblSelectItem.Text = "Select Inventory Item:"
        '
        'cboInventoryId
        '
        Me.cboInventoryId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboInventoryId.ForeColor = System.Drawing.Color.Gray
        Me.cboInventoryId.FormattingEnabled = True
        Me.cboInventoryId.Location = New System.Drawing.Point(94, 92)
        Me.cboInventoryId.Name = "cboInventoryId"
        Me.cboInventoryId.Size = New System.Drawing.Size(121, 24)
        Me.cboInventoryId.TabIndex = 4
        '
        'btnCalculateDepreciation
        '
        Me.btnCalculateDepreciation.BackColor = System.Drawing.Color.Gray
        Me.btnCalculateDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculateDepreciation.ForeColor = System.Drawing.Color.White
        Me.btnCalculateDepreciation.Location = New System.Drawing.Point(194, 168)
        Me.btnCalculateDepreciation.Name = "btnCalculateDepreciation"
        Me.btnCalculateDepreciation.Size = New System.Drawing.Size(177, 33)
        Me.btnCalculateDepreciation.TabIndex = 5
        Me.btnCalculateDepreciation.Text = "Calculate Depression"
        Me.btnCalculateDepreciation.UseVisualStyleBackColor = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItem.ForeColor = System.Drawing.Color.Gray
        Me.lblItem.Location = New System.Drawing.Point(143, 213)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(278, 16)
        Me.lblItem.TabIndex = 6
        Me.lblItem.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.lblItem.Visible = False
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.Gray
        Me.lblQuantity.Location = New System.Drawing.Point(238, 229)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(89, 16)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "XXXXXXXXX"
        Me.lblQuantity.Visible = False
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.ForeColor = System.Drawing.Color.Gray
        Me.lblYear.Location = New System.Drawing.Point(80, 264)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(65, 32)
        Me.lblYear.TabIndex = 8
        Me.lblYear.Text = "Present " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Year"
        Me.lblYear.Visible = False
        '
        'lstYear
        '
        Me.lstYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstYear.ForeColor = System.Drawing.Color.Gray
        Me.lstYear.FormattingEnabled = True
        Me.lstYear.ItemHeight = 16
        Me.lstYear.Location = New System.Drawing.Point(80, 299)
        Me.lstYear.Name = "lstYear"
        Me.lstYear.Size = New System.Drawing.Size(88, 84)
        Me.lstYear.TabIndex = 9
        Me.lstYear.Visible = False
        '
        'lblPresentValue
        '
        Me.lblPresentValue.AutoSize = True
        Me.lblPresentValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPresentValue.ForeColor = System.Drawing.Color.Gray
        Me.lblPresentValue.Location = New System.Drawing.Point(181, 264)
        Me.lblPresentValue.Name = "lblPresentValue"
        Me.lblPresentValue.Size = New System.Drawing.Size(65, 32)
        Me.lblPresentValue.TabIndex = 10
        Me.lblPresentValue.Text = "Present " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Value"
        Me.lblPresentValue.Visible = False
        '
        'lblYearDepreciation
        '
        Me.lblYearDepreciation.AutoSize = True
        Me.lblYearDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lblYearDepreciation.Location = New System.Drawing.Point(285, 264)
        Me.lblYearDepreciation.Name = "lblYearDepreciation"
        Me.lblYearDepreciation.Size = New System.Drawing.Size(97, 32)
        Me.lblYearDepreciation.TabIndex = 11
        Me.lblYearDepreciation.Text = "Year" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depreciation"
        Me.lblYearDepreciation.Visible = False
        '
        'lblTotalDepreciation
        '
        Me.lblTotalDepreciation.AutoSize = True
        Me.lblTotalDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lblTotalDepreciation.Location = New System.Drawing.Point(388, 264)
        Me.lblTotalDepreciation.Name = "lblTotalDepreciation"
        Me.lblTotalDepreciation.Size = New System.Drawing.Size(97, 32)
        Me.lblTotalDepreciation.TabIndex = 12
        Me.lblTotalDepreciation.Text = "Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Depreciation"
        Me.lblTotalDepreciation.Visible = False
        '
        'lstPresentValue
        '
        Me.lstPresentValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPresentValue.ForeColor = System.Drawing.Color.Gray
        Me.lstPresentValue.FormattingEnabled = True
        Me.lstPresentValue.ItemHeight = 16
        Me.lstPresentValue.Location = New System.Drawing.Point(184, 299)
        Me.lstPresentValue.Name = "lstPresentValue"
        Me.lstPresentValue.Size = New System.Drawing.Size(88, 84)
        Me.lstPresentValue.TabIndex = 13
        Me.lstPresentValue.Visible = False
        '
        'lstYearDepreciation
        '
        Me.lstYearDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstYearDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lstYearDepreciation.FormattingEnabled = True
        Me.lstYearDepreciation.ItemHeight = 16
        Me.lstYearDepreciation.Location = New System.Drawing.Point(288, 299)
        Me.lstYearDepreciation.Name = "lstYearDepreciation"
        Me.lstYearDepreciation.Size = New System.Drawing.Size(88, 84)
        Me.lstYearDepreciation.TabIndex = 14
        Me.lstYearDepreciation.Visible = False
        '
        'lstTotalDepreciation
        '
        Me.lstTotalDepreciation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTotalDepreciation.ForeColor = System.Drawing.Color.Gray
        Me.lstTotalDepreciation.FormattingEnabled = True
        Me.lstTotalDepreciation.ItemHeight = 16
        Me.lstTotalDepreciation.Location = New System.Drawing.Point(392, 299)
        Me.lstTotalDepreciation.Name = "lstTotalDepreciation"
        Me.lstTotalDepreciation.Size = New System.Drawing.Size(88, 84)
        Me.lstTotalDepreciation.TabIndex = 15
        Me.lstTotalDepreciation.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(798, -119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(564, 61112)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'picLightSpan
        '
        Me.picLightSpan.Image = CType(resources.GetObject("picLightSpan.Image"), System.Drawing.Image)
        Me.picLightSpan.Location = New System.Drawing.Point(0, 385)
        Me.picLightSpan.Name = "picLightSpan"
        Me.picLightSpan.Size = New System.Drawing.Size(564, 112)
        Me.picLightSpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLightSpan.TabIndex = 17
        Me.picLightSpan.TabStop = False
        '
        'frmDepreciation
        '
        Me.AcceptButton = Me.btnCalculateDepreciation
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 498)
        Me.Controls.Add(Me.picLightSpan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstTotalDepreciation)
        Me.Controls.Add(Me.lstYearDepreciation)
        Me.Controls.Add(Me.lstPresentValue)
        Me.Controls.Add(Me.lblTotalDepreciation)
        Me.Controls.Add(Me.lblYearDepreciation)
        Me.Controls.Add(Me.lblPresentValue)
        Me.Controls.Add(Me.lstYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.btnCalculateDepreciation)
        Me.Controls.Add(Me.cboInventoryId)
        Me.Controls.Add(Me.lblSelectItem)
        Me.Controls.Add(Me.grpDepreciationType)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDepreciation"
        Me.Text = "Compute Depreciation by Method"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpDepreciationType.ResumeLayout(False)
        Me.grpDepreciationType.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLightSpan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDisplay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpDepreciationType As System.Windows.Forms.GroupBox
    Friend WithEvents radDoubleDeclining As System.Windows.Forms.RadioButton
    Friend WithEvents radStraightLine As System.Windows.Forms.RadioButton
    Friend WithEvents lblSelectItem As System.Windows.Forms.Label
    Friend WithEvents cboInventoryId As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalculateDepreciation As System.Windows.Forms.Button
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lstYear As System.Windows.Forms.ListBox
    Friend WithEvents lblPresentValue As System.Windows.Forms.Label
    Friend WithEvents lblYearDepreciation As System.Windows.Forms.Label
    Friend WithEvents lblTotalDepreciation As System.Windows.Forms.Label
    Friend WithEvents lstPresentValue As System.Windows.Forms.ListBox
    Friend WithEvents lstYearDepreciation As System.Windows.Forms.ListBox
    Friend WithEvents lstTotalDepreciation As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picLightSpan As System.Windows.Forms.PictureBox

End Class
