Public Class AjouterInt

    Private Sub Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Annuler.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ok.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub



    Private Sub AjouterInt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class