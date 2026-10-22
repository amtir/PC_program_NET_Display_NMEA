Public Class frmRS232

    Private Sub GBoxUart_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GBoxUart.Enter
        ComBoxCOMPort.SelectedIndex = 0
        ComBoxProtocol.SelectedIndex = 0
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        frmSettingsCOM.ShowDialog()
    End Sub

    Private Sub frmRS232_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class