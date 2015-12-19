'----------------------------------------- 
' ELBW - Display - Weather station
'-----------------------------------------
' Abstract & Description: Software tool 
' for viewing the data in real time from
' the weather station on your PC.
'-----------------------------------------
' Programmer:  A. M. 
'-----------------------------------------
' Date of creation:  04/04/2010
'-----------------------------------------
Option Explicit On
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO

Public Class frmDisplay

    WithEvents dataDump As frmDump
    WithEvents graph As frmGraphics

    Structure dump_type
        Dim Enable As Boolean
        Dim HEX As Boolean
        Dim NMEA As Boolean
    End Structure

    Dim data_string, all_data, dummy As String
    Dim blGraphics As Boolean
    Public Angle, WindSpeed, AirTemp, Pressure, Humidity, Dew_Point As Single
    Dim dump As dump_type

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If all_data <> Nothing And dump.Enable = True And dump.NMEA = True Then
            dataDump.lbDump.Items.Add(Now)
            dataDump.lbDump.Items.Add(all_data.ToString)
            dataDump.lbDump.Items.Add("   ")
        End If

        If blGraphics = True Then
            graph.plot(AirTemp, Humidity, Angle, WindSpeed)
        End If

        Me.Chart1.Series("Wind").Points.Clear()
        Me.Chart1.Series("Wind").Points.AddXY(Angle, 5.5) ' WindSpeed) ' Set the radius to 5

        Me.lblWindDirection.Text = "Wind Direction: " & Angle.ToString("F2") & " [°]"
        Me.lblWindSpeed.Text = "Wind Speed"
        Me.lblWindSpeed1.Text = WindSpeed.ToString("F2") & " [m/s]"
        Me.lblPression.Text = "Pression:   " & Pressure.ToString("F2") & " [mbar]"
        Me.lblHumidity.Text = "Humidity:   " & Humidity.ToString("F2") & " [%]"
        Me.lblTemperature.Text = "Temperature:   " & AirTemp.ToString("F2") & " [°C]"
        Me.lblDewPoint.Text = "Dew Point:   " & Dew_Point.ToString("F2") & " [°C]"

        If dummy_flag Then
            ms.WriteLine(Now) '.ToString)
            ms.WriteLine(all_data) '.ToString)
            ' ms.Close()
            ' dummy_flag = False
        End If

    End Sub

    Private Sub frmDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        init_chart()
    End Sub

    Private Sub MenuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExit.Click
        End
    End Sub

    Private Sub MenuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAbout.Click
        AboutPC_Display.ShowDialog()
    End Sub

    Private Sub MenuConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuConnect.Click

        frmRS232.ShowDialog()

        slblStatusConnection.Image = System.Drawing.Bitmap.FromFile( _
        My.Application.Info.DirectoryPath & "\Icon_Photo\internetconnection.ico")
        slblStatusConnection.Text = "Status Connected"
        slblProtocol.Text = "Protocol NMEA"

    End Sub

    Private Sub MenuDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDisconnect.Click
        Me.SerialPort.Close()
        Timer1.Enabled = False
        MenuConnect.Enabled = True

        slblDate.Text = "Date and time"
        slblStatusConnection.Image = System.Drawing.Bitmap.FromFile( _
        My.Application.Info.DirectoryPath & "\Icon_Photo\lan disconnect.ico")
        slblStatusConnection.Text = "Connection status"
        slblProtocol.Text = "Protocol type"

    End Sub


    Private Sub comPort_DataReceived() Handles SerialPort.DataReceived

        Dim x, y, i As Integer
        Dim intNbMessage As Integer = 4
        Dim str_message(4) As String
        Dim RS_Parse As New ParseData

        If (Me.SerialPort.BytesToRead = 95) Then

            data_string = Me.SerialPort.ReadExisting
            all_data = data_string

            For i = 1 To intNbMessage
                x = InStr(1, data_string, "$")
                y = InStr(1, data_string, vbCrLf)

                If ((y - x) >= 16) Then
                    str_message(i) = Mid(data_string, x, y - 1)
                    RS_Parse.reception_message(str_message(i))
                End If

                If i < 4 Then
                    data_string = Mid(data_string, y + 2, Len(data_string))
                End If
            Next

            ' update values
            Angle = RS_Parse.Angle
            WindSpeed = RS_Parse.WindSpeed
            AirTemp = RS_Parse.AirTemp
            Pressure = RS_Parse.Pressure
            Humidity = RS_Parse.Humidity
            Dew_Point = RS_Parse.Dew_Point

            slblDate.Text = Date.Now.ToString("F")
        Else
            dummy = Me.SerialPort.ReadExisting
        End If

    End Sub

    Private Sub frmGraphics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graph.Load

        graph.GraphicsSettings(1, "Humidity", "Temperature")
        graph.GraphicsSettings(2, "Angle", "WindSpeed")

    End Sub

    Private Sub frmGraphics_closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graph.FormClosed

        blGraphics = False
        Me.MenuGraphics.Enabled = True

    End Sub

    Private Sub MenuGraphics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuGraphics.Click

        Me.MenuGraphics.Enabled = False

        blGraphics = True
        graph = New frmGraphics
        graph.GraphicsSettings(1, "Humidity", "Temperature")
        graph.Show()

    End Sub

    Private Sub ASCIIDumpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ASCIIDumpToolStripMenuItem.Click

        Me.ASCIIDumpToolStripMenuItem.Checked = True
        Me.ASCIIDumpToolStripMenuItem.Enabled = False

        dataDump = New frmDump
        dataDump.Text = "NMEA - ASCII Dump  o_O"

        dataDump.Show()
        dataDump.lbDump.Items.Clear()
        dump.Enable = True
        dump.NMEA = True
    End Sub

    Private Sub COM_DATA_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles dataDump.FormClosed
        Me.ASCIIDumpToolStripMenuItem.Checked = False
        Me.ASCIIDumpToolStripMenuItem.Enabled = True
        dump.Enable = False
        dump.NMEA = False

        If dummy_flag Then
            dummy_flag = False
            ms.Close()
        End If

    End Sub

    Private Sub init_chart()

        With Me.Chart1
            .Series.Clear()
            .Series.Add("Wind")
            ' Set polar chart type
            .Series("Wind").ChartType = SeriesChartType.Polar
            ' Set Back Color
            .ChartAreas("ChartArea1").BackColor = Color.FromKnownColor(KnownColor.Control)
            '' Set Axis Color
            '.ChartAreas("ChartArea1").AxisY.LineColor = Color.Red

            ' Set Axis Line Style
            Chart1.ChartAreas("ChartArea1").AxisY.LineDashStyle = ChartDashStyle.NotSet
            Chart1.ChartAreas("ChartArea1").AxisX.LineDashStyle = ChartDashStyle.NotSet
            ' Set Line Width
            '.ChartAreas("ChartArea1").AxisY.LineWidth = 3

            .ChartAreas("ChartArea1").AxisY.Minimum = 0
            .ChartAreas("ChartArea1").AxisY.Maximum = 6
            .ChartAreas("ChartArea1").AxisY.Interval = 1
            '.ChartAreas("ChartArea1").AxisY.Enabled = AxisEnabled.False

            ' Set the polar chart having the circles in light grey
            .ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.Blue 'Silver
            .ChartAreas("ChartArea1").AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot 'DashDot 'Solid
            .ChartAreas("ChartArea1").AxisX.MajorGrid.LineColor = Color.Blue 'Silver
            .ChartAreas("ChartArea1").AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot 'DashDot '.Solid
            .ChartAreas("ChartArea1").AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid
            .ChartAreas("ChartArea1").AxisY.MajorGrid.LineColor = Color.Black
            .ChartAreas("ChartArea1").AxisY.MajorGrid.Enabled = True ' = 0
            .ChartAreas("ChartArea1").AxisX.MajorGrid.Enabled = True

            .ChartAreas("ChartArea1").AxisX.LabelStyle.Font = New Font("Arial", 20)
            .ChartAreas("ChartArea1").AxisY.LabelStyle.Font = New Font("Arial", 20)
            .ChartAreas("ChartArea1").AxisY.LabelStyle.Font = New Font("Arial", 1)

            ' Set polar chart style (Line or Marker)
            .Series("Wind")("PolarDrawingStyle") = "Marker"
            ' Set bubble shape
            .Series("Wind").MarkerStyle = MarkerStyle.Circle 'Triangle 'Cross
            .Series("Wind").MarkerSize = 30 '15
            .Series("Wind").MarkerColor = Color.Red 'DarkRed
            .Series("Wind").MarkerBorderColor = Color.Blue
            .Series("Wind").MarkerBorderWidth = 5
            ' Set circular area drawing style (Circle or Polygon)
            .Series("Wind")("AreaDrawingStyle") = "Circle" '"Polygon"
            ' Set labels style (Auto, Horizontal, Circular or Radial)
            .Series("Wind")("CircularLabelsStyle") = "Horizontal"
            ' Set the legend title text
            .Legends("Legend1").Title = "Wind Speed [m/s] & Direction [°]"
            .Legends("Legend1").TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
            ' Set the legend title to Black
            .Legends("Legend1").TitleForeColor = Color.Black
            .Legends("Legend1").BackColor = Color.FromKnownColor(KnownColor.Control)
            ' Set the alignment of the legend title
            .Legends("Legend1").TitleAlignment = StringAlignment.Center
            ' Set the title separator type
            .Legends("Legend1").TitleSeparator = LegendSeparatorStyle.GradientLine
            ' Set the color of the title separator
            .Legends("Legend1").Alignment = StringAlignment.Center
            .Legends("Legend1").TitleSeparatorColor = Color.Black
            ' Set docking of the legend title
            .Legends("Legend1").Docking = Docking.Top 'Bottom
            .Legends("Legend1").Enabled = False
        End With

    End Sub

    Private Sub gbDisplay_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbDisplay.Enter

    End Sub
End Class

Public Module publicthings

    Public dummy_flag As Boolean
    Public ms As StreamWriter

End Module