<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisplayInventory))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.picLightSpanComputers = New System.Windows.Forms.PictureBox()
        CType(Me.picLightSpanComputers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(27, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Light Span Computers Inventory"
        '
        'lstDisplay
        '
        Me.lstDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDisplay.ForeColor = System.Drawing.Color.Gray
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 20
        Me.lstDisplay.Location = New System.Drawing.Point(96, 42)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(177, 164)
        Me.lstDisplay.TabIndex = 1
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Gray
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(96, 212)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(177, 33)
        Me.btnReturn.TabIndex = 6
        Me.btnReturn.Text = "Return to Application"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'picLightSpanComputers
        '
        Me.picLightSpanComputers.Image = CType(resources.GetObject("picLightSpanComputers.Image"), System.Drawing.Image)
        Me.picLightSpanComputers.Location = New System.Drawing.Point(-2, 262)
        Me.picLightSpanComputers.Name = "picLightSpanComputers"
        Me.picLightSpanComputers.Size = New System.Drawing.Size(374, 120)
        Me.picLightSpanComputers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLightSpanComputers.TabIndex = 7
        Me.picLightSpanComputers.TabStop = False
        '
        'frmDisplayInventory
        '
        Me.AcceptButton = Me.btnReturn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(371, 381)
        Me.Controls.Add(Me.picLightSpanComputers)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDisplayInventory"
        Me.Text = "Sorted Inventory Listing"
        CType(Me.picLightSpanComputers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents picLightSpanComputers As System.Windows.Forms.PictureBox
End Class
