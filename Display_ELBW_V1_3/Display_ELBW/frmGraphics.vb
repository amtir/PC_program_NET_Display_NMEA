Imports System.Windows.Forms.DataVisualization.Charting


Public Class frmGraphics

    Private Sub frmGraphics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'GraphicsSettings(1, "Humidity", "Temperature")

    End Sub


    Public Sub GraphicsSettings(ByVal i As Integer, ByVal strName1 As String, ByVal strName2 As String)

        If i = 1 Then

            With Chart1
                ' Remove all series
                .Series.Clear()

                .Series.Add(strName1)
                .Series.Add(strName2)

                ' Set series chart type
                .Series(strName1).ChartType = SeriesChartType.Line
                .Series(strName2).ChartType = SeriesChartType.Spline

                .Series(strName2).Color = Color.Red
                .Series(strName1).Color = Color.Blue

                .Series(strName1).BorderWidth = 5
                .Series(strName2).BorderWidth = 5

                ' Set series axis type
                .Series(strName1).XAxisType = AxisType.Primary
                .Series(strName1).YAxisType = AxisType.Primary
                .Series(strName2).YAxisType = AxisType.Secondary

                ' Set the legend title text
                .Legends("Legend1").Title = strName1 & " & " & strName2 '& " - Weather Station ELBW"
                .Legends("Legend1").TitleFont = New Font("Times New Roman", 13, FontStyle.Bold)
                ' Set the legend title to Black
                .Legends("Legend1").TitleForeColor = Color.Black

                ' Set the alignment of the legend title
                .Legends("Legend1").TitleAlignment = StringAlignment.Center

                ' Set the title separator type
                .Legends("Legend1").TitleSeparator = LegendSeparatorStyle.GradientLine
                ' Set the color of the title separator
                .Legends("Legend1").Alignment = StringAlignment.Center
                .Legends("Legend1").TitleSeparatorColor = Color.Black

                .Legends("Legend1").BackColor = Color.FromKnownColor(KnownColor.Control)

                ' Set docking of the legend title
                .Legends("Legend1").Docking = Docking.Top

                ' Set  axis title
                .ChartAreas("ChartArea1").AxisX.Title = "Time [s]"
                ' Set Title font
                .ChartAreas("ChartArea1").AxisX.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
                ' Set Back Color
                .ChartAreas("ChartArea1").BackColor = Color.FromKnownColor(KnownColor.Control)

                ' Set Title color
                ' Chart1.ChartAreas("ChartArea1").AxisX.TitleForeColor = Color.Red
                ' Set  axis title
                .ChartAreas("ChartArea1").AxisY.Title = strName1 & " [%]"
                .ChartAreas("ChartArea1").AxisY.TitleForeColor = Color.Blue
                .ChartAreas("ChartArea1").AxisY.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
                ' Set  axis title
                .ChartAreas("ChartArea1").AxisY2.Title = strName2 & " [°C]"
                .ChartAreas("ChartArea1").AxisY2.TitleForeColor = Color.Red
                .ChartAreas("ChartArea1").AxisY2.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
            End With

        ElseIf (i = 2) Then

            With Chart2
                ' Remove all series
                .Series.Clear()

                .Series.Add(strName1)
                .Series.Add(strName2)

                ' Set series chart type
                .Series(strName1).ChartType = SeriesChartType.Line
                .Series(strName2).ChartType = SeriesChartType.Spline

                .Series(strName1).BorderWidth = 5
                .Series(strName2).BorderWidth = 5

                .Series(strName1).Color = Color.Orange
                .Series(strName2).Color = Color.Green

                ' Set series axis type
                .Series(strName1).XAxisType = AxisType.Primary
                .Series(strName1).YAxisType = AxisType.Primary
                .Series(strName2).YAxisType = AxisType.Secondary

                ' Set the legend title text
                .Legends("Legend1").Title = strName1 & " & " & strName2 '& " - Weather Station ELBW"
                .Legends("Legend1").TitleFont = New Font("Times New Roman", 13, FontStyle.Bold)
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
                .Legends("Legend1").Docking = Docking.Top

                ' Set  axis title
                .ChartAreas("ChartArea1").AxisX.Title = "Time [s]"
                ' Set Title font
                .ChartAreas("ChartArea1").AxisX.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)

                .ChartAreas("ChartArea1").BackColor = Color.FromKnownColor(KnownColor.Control)


                ' Set Title color
                ' Chart1.ChartAreas("ChartArea1").AxisX.TitleForeColor = Color.Red
                ' Set  axis title
                .ChartAreas("ChartArea1").AxisY.Title = strName1 & " [°]"
                .ChartAreas("ChartArea1").AxisY.TitleForeColor = Color.Orange
                .ChartAreas("ChartArea1").AxisY.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
                ' Set  axis title
                .ChartAreas("ChartArea1").AxisY2.Title = strName2 & " [m/s]"
                .ChartAreas("ChartArea1").AxisY2.TitleForeColor = Color.Green
                .ChartAreas("ChartArea1").AxisY2.TitleFont = New Font("Times New Roman", 12, FontStyle.Bold)
            End With
        End If


    End Sub

    Public Sub plot(ByVal AirTemp As Single, ByVal Humidity As Single, ByVal Angle As Single, ByVal WindSpeed As Single)
        ' Define some variables
        Dim numberOfPointsInChart As Integer = 60 '200
        'Static pointNumber As Integer

        Chart1.Series(0).Points.Add(Humidity)
        Chart1.Series(1).Points.Add(AirTemp)

        Chart2.Series(0).Points.Add(Angle)
        Chart2.Series(1).Points.Add(WindSpeed)

        ' Adjust Y & X axis scale
        Chart1.ResetAutoValues()
        Chart2.ResetAutoValues()

        '' Keep a constant number of points by removing them from the left
        While Chart1.Series(0).Points.Count > numberOfPointsInChart
            ' Remove data points on the left side
            Chart1.Series(0).Points.RemoveAt(0)
            Chart1.Series(1).Points.RemoveAt(0)
            Chart2.Series(0).Points.RemoveAt(0)
            Chart2.Series(1).Points.RemoveAt(0)

        End While

        ' Adjust X axis scale
        Chart1.ChartAreas("ChartArea1").AxisX.Minimum = 0
        Chart1.ChartAreas("ChartArea1").AxisX.Maximum = Chart1.ChartAreas("ChartArea1").AxisX.Minimum + numberOfPointsInChart + 1
        Chart2.ChartAreas("ChartArea1").AxisX.Minimum = 0
        Chart2.ChartAreas("ChartArea1").AxisX.Maximum = Chart1.ChartAreas("ChartArea1").AxisX.Minimum + numberOfPointsInChart + 1

        'pointNumber = pointNumber + 1

    End Sub

End Class