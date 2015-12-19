' VQD === Very Quick & Dirty 


Public Class ParseData 'RS232

    ' Properties 
    Public Angle, WindSpeed, AirTemp, Dew_Point, Humidity, Pressure As Single


    Public Function reception_message(ByVal data As String) As Boolean

        'local private variables 
        Dim i, j
        Dim Checksum
        Dim Check
        Dim High
        Dim Low
        Dim Identity
        Dim Message

        Checksum = 0


        j = InStr(data, "*")

        For i = 2 To (j - 1)
            Checksum = Checksum Xor Asc(Mid(data, i, i))
        Next

        'Saisir les bytes du message correspondant au checksum envoyer par l'instrument
        High = Asc(Mid(data, Len(data) - 1, Len(data) - 1))
        Low = Asc(Mid(data, Len(data), Len(data)))

        'Extraction du checksum
        High = hextodec(Chr(High))
        Low = hextodec(Chr(Low))

        Check = 16 * High + Low


        If Check = Checksum Then

            'Le message ayant été transmis correctement, il est maintenant possible
            'de determiner quelle est le type de telegram

            Identity = Mid(data, 2, 5)

            Select Case Identity
                ' update the properties of the class
                Case "WIMWV"
                    Angle = Val(Mid(data, 8, 5))
                    WindSpeed = Val(Mid(data, 16, 5))
                Case "WIMTA"
                    AirTemp = Val(Mid(data, 8, 5))
                Case "WIMTS"
                    ' Soil Temperature
                Case "WIMHU"
                    Humidity = Val(Mid(data, 8, 5))
                    Dew_Point = Val(Mid(data, 15, 5))
                Case "WIMMB"
                    Pressure = Val(Mid(data, 10, 6))

                Case Else
                    Message = " Identification inexistante"
                    ''GoTo Erreur

            End Select

        End If

    End Function


    Private Function hextodec(ByVal ValeurHex As Object) As Object

        Select Case ValeurHex

            Case "0"
                hextodec = 0
            Case "1"
                hextodec = 1
            Case "2"
                hextodec = 2
            Case "3"
                hextodec = 3
            Case "4"
                hextodec = 4
            Case "5"
                hextodec = 5
            Case "6"
                hextodec = 6
            Case "7"
                hextodec = 7
            Case "8"
                hextodec = 8
            Case "9"
                hextodec = 9
            Case "A"
                hextodec = 10
            Case "B"
                hextodec = 11
            Case "C"
                hextodec = 12
            Case "D"
                hextodec = 13
            Case "E"
                hextodec = 14
            Case "F"
                hextodec = 15
            Case Else
                hextodec = 0
        End Select

    End Function

End Class