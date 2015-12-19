Imports System.IO
Public Class frmDump


    Private Sub btFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFileSave.Click

        Dim myStream As Stream


        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "txt files (*.txt)|*.txt" '|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = saveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                ' Code to write the stream goes here.
                myStream.Close()
                ms = New StreamWriter(saveFileDialog1.FileName)
                dummy_flag = True
                btFileSave.Enabled = False
            End If
        End If

    End Sub

    Private Sub frmDump_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class