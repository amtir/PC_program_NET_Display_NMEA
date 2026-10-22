<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDump
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDump))
        Me.lbDump = New System.Windows.Forms.ListBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.btFileSave = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lbDump
        '
        Me.lbDump.BackColor = System.Drawing.Color.Black
        Me.lbDump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbDump.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDump.ForeColor = System.Drawing.Color.Cyan
        Me.lbDump.FormattingEnabled = True
        Me.lbDump.HorizontalScrollbar = True
        Me.lbDump.ItemHeight = 16
        Me.lbDump.Location = New System.Drawing.Point(8, 16)
        Me.lbDump.Name = "lbDump"
        Me.lbDump.ScrollAlwaysVisible = True
        Me.lbDump.Size = New System.Drawing.Size(784, 354)
        Me.lbDump.TabIndex = 3
        '
        'btFileSave
        '
        Me.btFileSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFileSave.Location = New System.Drawing.Point(8, 384)
        Me.btFileSave.Name = "btFileSave"
        Me.btFileSave.Size = New System.Drawing.Size(168, 32)
        Me.btFileSave.TabIndex = 4
        Me.btFileSave.Text = "Save ASCII Dump"
        Me.btFileSave.UseVisualStyleBackColor = True
        '
        'frmDump
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 424)
        Me.Controls.Add(Me.btFileSave)
        Me.Controls.Add(Me.lbDump)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDump"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Dump"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbDump As System.Windows.Forms.ListBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btFileSave As System.Windows.Forms.Button
End Class
