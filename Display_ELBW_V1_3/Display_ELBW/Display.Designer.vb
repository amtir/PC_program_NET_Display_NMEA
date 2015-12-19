<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplay
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisplay))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.MenuDisplay = New System.Windows.Forms.MenuStrip
        Me.MenuConnect = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuDisconnect = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuDumpData = New System.Windows.Forms.ToolStripMenuItem
        Me.ASCIIDumpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuGraphics = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.slblStatusConnection = New System.Windows.Forms.ToolStripStatusLabel
        Me.slblProtocol = New System.Windows.Forms.ToolStripStatusLabel
        Me.slblDate = New System.Windows.Forms.ToolStripStatusLabel
        Me.gbDisplay = New System.Windows.Forms.GroupBox
        Me.lblWindSpeed1 = New System.Windows.Forms.Label
        Me.lblWindSpeed = New System.Windows.Forms.Label
        Me.lblDewPoint = New System.Windows.Forms.Label
        Me.lblHumidity = New System.Windows.Forms.Label
        Me.lblPression = New System.Windows.Forms.Label
        Me.lblTemperature = New System.Windows.Forms.Label
        Me.lblWindDirection = New System.Windows.Forms.Label
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.MenuDisplay.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.gbDisplay.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'SerialPort
        '
        '
        'MenuDisplay
        '
        Me.MenuDisplay.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuConnect, Me.MenuDisconnect, Me.MenuDumpData, Me.MenuGraphics, Me.MenuExit, Me.ToolStripMenuItem1})
        Me.MenuDisplay.Location = New System.Drawing.Point(0, 0)
        Me.MenuDisplay.Name = "MenuDisplay"
        Me.MenuDisplay.Size = New System.Drawing.Size(990, 24)
        Me.MenuDisplay.TabIndex = 0
        Me.MenuDisplay.Text = "MenuStrip1"
        '
        'MenuConnect
        '
        Me.MenuConnect.Name = "MenuConnect"
        Me.MenuConnect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
        Me.MenuConnect.Size = New System.Drawing.Size(59, 20)
        Me.MenuConnect.Text = "&Connect"
        '
        'MenuDisconnect
        '
        Me.MenuDisconnect.Name = "MenuDisconnect"
        Me.MenuDisconnect.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[End]), System.Windows.Forms.Keys)
        Me.MenuDisconnect.Size = New System.Drawing.Size(71, 20)
        Me.MenuDisconnect.Text = "Disconnect"
        '
        'MenuDumpData
        '
        Me.MenuDumpData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ASCIIDumpToolStripMenuItem})
        Me.MenuDumpData.Name = "MenuDumpData"
        Me.MenuDumpData.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.MenuDumpData.Size = New System.Drawing.Size(75, 20)
        Me.MenuDumpData.Text = "&Dump_Data"
        '
        'ASCIIDumpToolStripMenuItem
        '
        Me.ASCIIDumpToolStripMenuItem.Name = "ASCIIDumpToolStripMenuItem"
        Me.ASCIIDumpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ASCIIDumpToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ASCIIDumpToolStripMenuItem.Text = "&ASCII Dump"
        '
        'MenuGraphics
        '
        Me.MenuGraphics.Name = "MenuGraphics"
        Me.MenuGraphics.Size = New System.Drawing.Size(60, 20)
        Me.MenuGraphics.Text = "&Graphics"
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(37, 20)
        Me.MenuExit.Text = "&Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAbout})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'MenuAbout
        '
        Me.MenuAbout.Name = "MenuAbout"
        Me.MenuAbout.Size = New System.Drawing.Size(114, 22)
        Me.MenuAbout.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.slblStatusConnection, Me.slblProtocol, Me.slblDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 669)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(990, 25)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'slblStatusConnection
        '
        Me.slblStatusConnection.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.slblStatusConnection.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.slblStatusConnection.Image = CType(resources.GetObject("slblStatusConnection.Image"), System.Drawing.Image)
        Me.slblStatusConnection.Name = "slblStatusConnection"
        Me.slblStatusConnection.Size = New System.Drawing.Size(325, 20)
        Me.slblStatusConnection.Spring = True
        Me.slblStatusConnection.Text = "Connection status"
        '
        'slblProtocol
        '
        Me.slblProtocol.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.slblProtocol.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.slblProtocol.Name = "slblProtocol"
        Me.slblProtocol.Size = New System.Drawing.Size(325, 20)
        Me.slblProtocol.Spring = True
        Me.slblProtocol.Text = "Protocol type"
        '
        'slblDate
        '
        Me.slblDate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.slblDate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.slblDate.Name = "slblDate"
        Me.slblDate.Size = New System.Drawing.Size(325, 20)
        Me.slblDate.Spring = True
        Me.slblDate.Text = "Date and time"
        '
        'gbDisplay
        '
        Me.gbDisplay.Controls.Add(Me.lblWindSpeed1)
        Me.gbDisplay.Controls.Add(Me.lblWindSpeed)
        Me.gbDisplay.Controls.Add(Me.lblDewPoint)
        Me.gbDisplay.Controls.Add(Me.lblHumidity)
        Me.gbDisplay.Controls.Add(Me.lblPression)
        Me.gbDisplay.Controls.Add(Me.lblTemperature)
        Me.gbDisplay.Controls.Add(Me.lblWindDirection)
        Me.gbDisplay.Controls.Add(Me.Chart1)
        Me.gbDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDisplay.Location = New System.Drawing.Point(16, 32)
        Me.gbDisplay.Name = "gbDisplay"
        Me.gbDisplay.Size = New System.Drawing.Size(962, 624)
        Me.gbDisplay.TabIndex = 2
        Me.gbDisplay.TabStop = False
        Me.gbDisplay.Text = "ELBW - Weather Station Display"
        '
        'lblWindSpeed1
        '
        Me.lblWindSpeed1.AutoSize = True
        Me.lblWindSpeed1.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindSpeed1.ForeColor = System.Drawing.Color.Red
        Me.lblWindSpeed1.Location = New System.Drawing.Point(552, 319)
        Me.lblWindSpeed1.Name = "lblWindSpeed1"
        Me.lblWindSpeed1.Size = New System.Drawing.Size(97, 35)
        Me.lblWindSpeed1.TabIndex = 9
        Me.lblWindSpeed1.Text = "00.00"
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindSpeed.ForeColor = System.Drawing.Color.Red
        Me.lblWindSpeed.Location = New System.Drawing.Point(544, 284)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(192, 35)
        Me.lblWindSpeed.TabIndex = 3
        Me.lblWindSpeed.Text = "Wind Speed"
        '
        'lblDewPoint
        '
        Me.lblDewPoint.AutoSize = True
        Me.lblDewPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDewPoint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDewPoint.Location = New System.Drawing.Point(16, 428)
        Me.lblDewPoint.Name = "lblDewPoint"
        Me.lblDewPoint.Size = New System.Drawing.Size(132, 29)
        Me.lblDewPoint.TabIndex = 8
        Me.lblDewPoint.Text = "Dew Point"
        '
        'lblHumidity
        '
        Me.lblHumidity.AutoSize = True
        Me.lblHumidity.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumidity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHumidity.Location = New System.Drawing.Point(16, 216)
        Me.lblHumidity.Name = "lblHumidity"
        Me.lblHumidity.Size = New System.Drawing.Size(114, 29)
        Me.lblHumidity.TabIndex = 7
        Me.lblHumidity.Text = "Humidity"
        '
        'lblPression
        '
        Me.lblPression.AutoSize = True
        Me.lblPression.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPression.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPression.Location = New System.Drawing.Point(16, 110)
        Me.lblPression.Name = "lblPression"
        Me.lblPression.Size = New System.Drawing.Size(116, 29)
        Me.lblPression.TabIndex = 6
        Me.lblPression.Text = "Pression"
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperature.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTemperature.Location = New System.Drawing.Point(16, 322)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(164, 29)
        Me.lblTemperature.TabIndex = 5
        Me.lblTemperature.Text = "Temperature"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWindDirection.ForeColor = System.Drawing.Color.Red
        Me.lblWindDirection.Location = New System.Drawing.Point(16, 534)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(229, 35)
        Me.lblWindDirection.TabIndex = 4
        Me.lblWindDirection.Text = "Wind Direction"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.SystemColors.Control
        Me.Chart1.BackImageTransparentColor = System.Drawing.Color.White
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(320, 37)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(636, 571)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'frmDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(990, 694)
        Me.Controls.Add(Me.gbDisplay)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuDisplay
        Me.MaximizeBox = False
        Me.Name = "frmDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Display - ELBW - Weather Station"
        Me.MenuDisplay.ResumeLayout(False)
        Me.MenuDisplay.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gbDisplay.ResumeLayout(False)
        Me.gbDisplay.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents MenuDisplay As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents slblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblStatusConnection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents slblProtocol As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuConnect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDisconnect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDumpData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASCIIDumpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuGraphics As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbDisplay As System.Windows.Forms.GroupBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblWindDirection As System.Windows.Forms.Label
    Friend WithEvents lblWindSpeed As System.Windows.Forms.Label
    Friend WithEvents lblDewPoint As System.Windows.Forms.Label
    Friend WithEvents lblHumidity As System.Windows.Forms.Label
    Friend WithEvents lblPression As System.Windows.Forms.Label
    Friend WithEvents lblTemperature As System.Windows.Forms.Label
    Friend WithEvents lblWindSpeed1 As System.Windows.Forms.Label

End Class
