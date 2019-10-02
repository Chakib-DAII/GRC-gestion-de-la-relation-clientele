Public Class auth

    Private Sub connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connect.Click
        Try
            Dim nr As GRCDataSet.CompteRow = Me.GRCDataSet.Compte.ElementAt(Me.CompteBindingSource.Position)
            If Me.Logint.Text().Equals(nr.LoginUser) Then
                If Me.Mpasst.Text().Equals(nr.MPassUser) Then
                    Me.Hide()
                    principal.Show()
                Else
                    Me.Logint.Text = ""
                    Me.Mpasst.Text = ""
                    MsgBox("mot de passe incorrecte", vbOK, "erreur")
                End If
            Else
                Me.Logint.Text = ""
                Me.Mpasst.Text = ""
                MsgBox("login incorrecte", vbOK, "erreur")
            End If



        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub

    Private Sub auth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GRCDataSet.Compte' table. You can move, or remove it, as needed.
        Me.CompteTableAdapter.Fill(Me.GRCDataSet.Compte)
        Me.CenterToScreen()

    End Sub

End Class