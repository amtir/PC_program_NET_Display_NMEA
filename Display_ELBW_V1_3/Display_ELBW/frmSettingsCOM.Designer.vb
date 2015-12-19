<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsCOM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettingsCOM))
        Me.GBoxUart = New System.Windows.Forms.GroupBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblbProtocol = New System.Windows.Forms.Label
        Me.lblbFlowControl = New System.Windows.Forms.Label
        Me.lblStopBits = New System.Windows.Forms.Label
        Me.lblParity = New System.Windows.Forms.Label
        Me.lblBits = New System.Windows.Forms.Label
        Me.lblBaudRate = New System.Windows.Forms.Label
        Me.GBoxUart.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBoxUart
        '
        Me.GBoxUart.Controls.Add(Me.btnOK)
        Me.GBoxUart.Controls.Add(Me.lblbProtocol)
        Me.GBoxUart.Controls.Add(Me.lblbFlowControl)
        Me.GBoxUart.Controls.Add(Me.lblStopBits)
        Me.GBoxUart.Controls.Add(Me.lblParity)
        Me.GBoxUart.Controls.Add(Me.lblBits)
        Me.GBoxUart.Controls.Add(Me.lblBaudRate)
        Me.GBoxUart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxUart.Location = New System.Drawing.Point(12, 12)
        Me.GBoxUart.Name = "GBoxUart"
        Me.GBoxUart.Size = New System.Drawing.Size(369, 317)
        Me.GBoxUart.TabIndex = 1
        Me.GBoxUart.TabStop = False
        Me.GBoxUart.Text = "Serial Communication Settings :"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(139, 281)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(90, 28)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblbProtocol
        '
        Me.lblbProtocol.AutoSize = True
        Me.lblbProtocol.Location = New System.Drawing.Point(21, 47)
        Me.lblbProtocol.Name = "lblbProtocol"
        Me.lblbProtocol.Size = New System.Drawing.Size(79, 24)
        Me.lblbProtocol.TabIndex = 6
        Me.lblbProtocol.Text = "Protocol"
        '
        'lblbFlowControl
        '
        Me.lblbFlowControl.AutoSize = True
        Me.lblbFlowControl.Location = New System.Drawing.Point(21, 242)
        Me.lblbFlowControl.Name = "lblbFlowControl"
        Me.lblbFlowControl.Size = New System.Drawing.Size(126, 24)
        Me.lblbFlowControl.TabIndex = 5
        Me.lblbFlowControl.Text = "Flow Control :"
        '
        'lblStopBits
        '
        Me.lblStopBits.AutoSize = True
        Me.lblStopBits.Location = New System.Drawing.Point(21, 203)
        Me.lblStopBits.Name = "lblStopBits"
        Me.lblStopBits.Size = New System.Drawing.Size(92, 24)
        Me.lblStopBits.TabIndex = 4
        Me.lblStopBits.Text = "Stop Bits :"
        '
        'lblParity
        '
        Me.lblParity.AutoSize = True
        Me.lblParity.Location = New System.Drawing.Point(21, 164)
        Me.lblParity.Name = "lblParity"
        Me.lblParity.Size = New System.Drawing.Size(65, 24)
        Me.lblParity.TabIndex = 3
        Me.lblParity.Text = "Parity :"
        '
        'lblBits
        '
        Me.lblBits.AutoSize = True
        Me.lblBits.Location = New System.Drawing.Point(21, 125)
        Me.lblBits.Name = "lblBits"
        Me.lblBits.Size = New System.Drawing.Size(96, 24)
        Me.lblBits.TabIndex = 2
        Me.lblBits.Text = "Data Bits : "
        '
        'lblBaudRate
        '
        Me.lblBaudRate.AutoSize = True
        Me.lblBaudRate.Location = New System.Drawing.Point(21, 86)
        Me.lblBaudRate.Name = "lblBaudRate"
        Me.lblBaudRate.Size = New System.Drawing.Size(112, 24)
        Me.lblBaudRate.TabIndex = 1
        Me.lblBaudRate.Text = "Baud Rate : "
        '
        'frmSettingsCOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(393, 341)
        Me.Controls.Add(Me.GBoxUart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettingsCOM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COM?"
        Me.GBoxUart.ResumeLayout(False)
        Me.GBoxUart.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBoxUart As System.Windows.Forms.GroupBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblbProtocol As System.Windows.Forms.Label
    Friend WithEvents lblbFlowControl As System.Windows.Forms.Label
    Friend WithEvents lblStopBits As System.Windows.Forms.Label
    Friend WithEvents lblParity As System.Windows.Forms.Label
    Friend WithEvents lblBits As System.Windows.Forms.Label
    Friend WithEvents lblBaudRate As System.Windows.Forms.Label
End Class
