<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRS232
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRS232))
        Me.GBoxUart = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.ComBoxCOMPort = New System.Windows.Forms.ComboBox
        Me.lblCOMPort = New System.Windows.Forms.Label
        Me.lblbProtocol = New System.Windows.Forms.Label
        Me.ComBoxProtocol = New System.Windows.Forms.ComboBox
        Me.GBoxUart.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBoxUart
        '
        Me.GBoxUart.Controls.Add(Me.PictureBox1)
        Me.GBoxUart.Controls.Add(Me.btnCancel)
        Me.GBoxUart.Controls.Add(Me.btnOK)
        Me.GBoxUart.Controls.Add(Me.ComBoxCOMPort)
        Me.GBoxUart.Controls.Add(Me.lblCOMPort)
        Me.GBoxUart.Controls.Add(Me.lblbProtocol)
        Me.GBoxUart.Controls.Add(Me.ComBoxProtocol)
        Me.GBoxUart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxUart.Location = New System.Drawing.Point(12, 3)
        Me.GBoxUart.Name = "GBoxUart"
        Me.GBoxUart.Size = New System.Drawing.Size(404, 188)
        Me.GBoxUart.TabIndex = 0
        Me.GBoxUart.TabStop = False
        Me.GBoxUart.Text = "Serial Communication Settings :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(297, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(228, 154)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 28)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(86, 154)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 28)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'ComBoxCOMPort
        '
        Me.ComBoxCOMPort.FormattingEnabled = True
        Me.ComBoxCOMPort.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10"})
        Me.ComBoxCOMPort.Location = New System.Drawing.Point(137, 53)
        Me.ComBoxCOMPort.Name = "ComBoxCOMPort"
        Me.ComBoxCOMPort.Size = New System.Drawing.Size(114, 32)
        Me.ComBoxCOMPort.TabIndex = 8
        '
        'lblCOMPort
        '
        Me.lblCOMPort.AutoSize = True
        Me.lblCOMPort.Location = New System.Drawing.Point(26, 61)
        Me.lblCOMPort.Name = "lblCOMPort"
        Me.lblCOMPort.Size = New System.Drawing.Size(92, 24)
        Me.lblCOMPort.TabIndex = 7
        Me.lblCOMPort.Text = "COM Port"
        '
        'lblbProtocol
        '
        Me.lblbProtocol.AutoSize = True
        Me.lblbProtocol.Location = New System.Drawing.Point(26, 97)
        Me.lblbProtocol.Name = "lblbProtocol"
        Me.lblbProtocol.Size = New System.Drawing.Size(79, 24)
        Me.lblbProtocol.TabIndex = 6
        Me.lblbProtocol.Text = "Protocol"
        '
        'ComBoxProtocol
        '
        Me.ComBoxProtocol.FormattingEnabled = True
        Me.ComBoxProtocol.Items.AddRange(New Object() {"NMEA"})
        Me.ComBoxProtocol.Location = New System.Drawing.Point(137, 91)
        Me.ComBoxProtocol.Name = "ComBoxProtocol"
        Me.ComBoxProtocol.Size = New System.Drawing.Size(114, 32)
        Me.ComBoxProtocol.TabIndex = 0
        '
        'frmRS232
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 203)
        Me.Controls.Add(Me.GBoxUart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRS232"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RS485 or RS232 or USB to UART Bridge Virtual COM Port (VCP)"
        Me.GBoxUart.ResumeLayout(False)
        Me.GBoxUart.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBoxUart As System.Windows.Forms.GroupBox
    Friend WithEvents ComBoxProtocol As System.Windows.Forms.ComboBox
    Friend WithEvents lblCOMPort As System.Windows.Forms.Label
    Friend WithEvents lblbProtocol As System.Windows.Forms.Label
    Friend WithEvents ComBoxCOMPort As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
