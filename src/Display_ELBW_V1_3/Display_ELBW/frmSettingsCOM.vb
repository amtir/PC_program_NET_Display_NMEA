Public Class frmSettingsCOM

    Private Sub frmSettingsCOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = frmRS232.ComBoxCOMPort.Text
        Me.GBoxUart.Text = "Settings Serial " & frmRS232.ComBoxCOMPort.Text

        If frmRS232.ComBoxProtocol.SelectedIndex <> -1 Or frmRS232.ComBoxCOMPort.SelectedIndex <> -1 Then

            If frmRS232.ComBoxProtocol.SelectedItem = "NMEA" Then

                Me.lblbProtocol.Text = "Protocol :  NMEA (1Hz)"
                Me.lblBaudRate.Text = "Baud Rate :  4800 bits/s"
                Me.lblBits.Text = "Data Bits :  8 bits"
                Me.lblParity.Text = "Parity :    No Parity"
                Me.lblStopBits.Text = "Stop Bit :   1 (MARK)"
                Me.lblbFlowControl.Text = "Flow Control :   No Software handshake"

            ElseIf frmRS232.ComBoxProtocol.SelectedItem = "HEX" Then
                ' ---
            End If

        Else
            MsgBox("Check the COM Port or the protocol !!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        frmRS232.Close()
        Me.Close()
        frmDisplay.MenuConnect.Enabled = False

        frmDisplay.Timer1.Enabled = True

        init_Comm()

    End Sub

    Public Sub init_Comm()

        If frmRS232.ComBoxProtocol.SelectedItem = "NMEA" Then

            With frmDisplay.SerialPort

                .PortName = frmRS232.ComBoxCOMPort.Text
                .BaudRate = 4800
                .DataBits = 8
                .Parity = IO.Ports.Parity.None
                .StopBits = IO.Ports.StopBits.One
                .ReceivedBytesThreshold = 95
                If .IsOpen Then
                    .Close()
                    .Open()
                Else
                    .Open()
                End If

            End With

        End If

    End Sub

    Private Sub GBoxUart_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBoxUart.Enter

    End Sub
End Class

