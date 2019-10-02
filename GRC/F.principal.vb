Public Class principal

    Private Sub principal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        auth.Close()
        My.Computer.FileSystem.DeleteFile("C:\Users\Chakib\Documents\Visual Studio 2010\Projects\GRC\GRC\GRC.mdb")
        My.Computer.FileSystem.CopyFile("C:\Users\Chakib\Documents\Visual Studio 2010\Projects\GRC\GRC\bin\Debug\GRC.mdb", "C:\Users\Chakib\Documents\Visual Studio 2010\Projects\GRC\GRC\GRC.mdb")
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GRCDataSet.CoordonnéesElectroniques' table. You can move, or remove it, as needed.
        Me.CoordonnéesElectroniquesTableAdapter.Fill(Me.GRCDataSet.CoordonnéesElectroniques)
        'TODO: This line of code loads data into the 'GRCDataSet.CoordonnéesTelephoniques' table. You can move, or remove it, as needed.
        Me.CoordonnéesTelephoniquesTableAdapter.Fill(Me.GRCDataSet.CoordonnéesTelephoniques)
        'TODO: This line of code loads data into the 'GRCDataSet.CoordonnéesPostal' table. You can move, or remove it, as needed.
        Me.CoordonnéesPostalTableAdapter.Fill(Me.GRCDataSet.CoordonnéesPostal)
        'TODO: This line of code loads data into the 'GRCDataSet.Produit' table. You can move, or remove it, as needed.
        Me.ProduitTableAdapter.Fill(Me.GRCDataSet.Produit)
        'TODO: This line of code loads data into the 'GRCDataSet.Commande' table. You can move, or remove it, as needed.
        Me.CommandeTableAdapter.Fill(Me.GRCDataSet.Commande)
        'TODO: This line of code loads data into the 'GRCDataSet.Interessement' table. You can move, or remove it, as needed.
        Me.InteressementTableAdapter.Fill(Me.GRCDataSet.Interessement)
        'TODO: This line of code loads data into the 'GRCDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.GRCDataSet.Client)
        Me.CenterToScreen()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterCl.Click
        Try
        Dim frm As New Client
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim nr As GRCDataSet.ClientRow = Me.GRCDataSet.Client.NewClientRow
            nr.IdCL = frm.Cin.Text
            nr.NomCl = frm.Nom.Text
            nr.NbCl = CInt(Int(frm.NBEn.Text))
            nr.NatureCl = "Particulier"
            nr.DateCl = frm.DateNaiss.Text.ToString
            nr.TypeCl = frm.typecl.Text
            nr.NiveauCl = "Nouveau"
            nr.MoyCommPréféréCl = frm.CommPref.Text
            Me.GRCDataSet.Client.AddClientRow(nr)
            Me.ClientTableAdapter.Update(nr)
            Me.GRCDataSet.Client.AcceptChanges()
            Me.ClientTableAdapter.Fill(Me.GRCDataSet.Client)

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try


    End Sub
    Private Sub ModifierCl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierCl.Click
        Try
            If Me.ClientBindingSource.Current IsNot Nothing Then
                Dim nr As GRCDataSet.ClientRow = Me.GRCDataSet.Client.ElementAt(Me.ClientBindingSource.Position)
                If nr.NatureCl.Equals("Particulier") Then
                    Dim frm As New FmodifierClient
                    frm.Cin.Text = nr.IdCL
                    frm.Nom.Text = nr.NomCl
                    frm.NBEn.Text = nr.NbCl
                    frm.DateNaiss.Text = nr.DateCl
                    frm.typecl.Text = nr.TypeCl
                    frm.CommPref.Text = nr.MoyCommPréféréCl
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        nr.IdCL = frm.Cin.Text
                        nr.NomCl = frm.Nom.Text
                        nr.NbCl = CInt(Int(frm.NBEn.Text))
                        nr.DateCl = frm.DateNaiss.Text.ToString
                        nr.TypeCl = frm.typecl.Text
                        nr.MoyCommPréféréCl = frm.CommPref.Text
                        Me.ClientTableAdapter.Update(nr)
                        Me.GRCDataSet.Client.AcceptChanges()
                        Me.ClientTableAdapter.Fill(Me.GRCDataSet.Client)
                    End If
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub
    Private Sub SupprimerCl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerCl.Click
        If Me.ClientBindingSource.Current IsNot Nothing Then
            Dim nr As GRCDataSet.ClientRow = Me.GRCDataSet.Client.ElementAt(Me.ClientBindingSource.Position)
            If nr.NatureCl.Equals("Particulier") Then
                If MsgBox("Proceder à la confirmation de la suppression", vbOKCancel, "Confirmation") = vbOK Then
                    ' Me.ClientTableAdapter.Delete(nr.IdCL)
                    Me.GRCDataSet.Client.RemoveClientRow(nr)
                    Me.GRCDataSet.Client.AcceptChanges()
                End If
            End If
        End If

    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub AjouterEntr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterEntr.Click
        Try
            Dim frm As New FajouterEntreprise
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim nr As GRCDataSet.ClientRow = Me.GRCDataSet.Client.NewClientRow
                nr.IdCL = frm.Cin.Text
                nr.NomCl = frm.Nom.Text
                nr.NbCl = CInt(Int(frm.NBEn.Text))
                nr.NatureCl = "Entreprise"
                nr.DateCl = frm.DateNaiss.Text.ToString
                nr.TypeCl = frm.typecl.Text
                nr.NiveauCl = "Nouveau"
                nr.MoyCommPréféréCl = frm.CommPref.Text
                Me.GRCDataSet.Client.AddClientRow(nr)
                Me.ClientTableAdapter.Update(nr)
                Me.GRCDataSet.Client.AcceptChanges()
                Me.ClientTableAdapter.Fill(Me.GRCDataSet.Client)

            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub


 
    Private Sub ModifierEntr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierEntr.Click
        Try
            If Me.ClientBindingSource.Current IsNot Nothing Then
                Dim nr As GRCDataSet.ClientRow = Me.GRCDataSet.Client.ElementAt(Me.ClientBindingSource.Position)
                If nr.NatureCl.Equals("Entreprise") Then
                    Dim frm As New FmodifierEntreprise
                    frm.Cin.Text = nr.IdCL
                    frm.Nom.Text = nr.NomCl
                    frm.NBEn.Text = nr.NbCl
                    frm.DateNaiss.Text = nr.DateCl
                    frm.typecl.Text = nr.TypeCl
                    frm.CommPref.Text = nr.MoyCommPréféréCl
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        nr.IdCL = frm.Cin.Text
                        nr.NomCl = frm.Nom.Text
                        nr.NbCl = CInt(Int(frm.NBEn.Text))
                        nr.DateCl = frm.DateNaiss.Text.ToString
                        nr.TypeCl = frm.typecl.Text
                        nr.MoyCommPréféréCl = frm.CommPref.Text
                        Me.ClientTableAdapter.Update(nr)
                        Me.GRCDataSet.Client.AcceptChanges()
                        Me.ClientTableAdapter.Fill(Me.GRCDataSet.Client)

                    End If
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub

    Private Sub SupprimerEntr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerEntr.Click
        If Me.ClientBindingSource.Current IsNot Nothing Then
            Dim nr As GRCDataSet.ClientRow = Me.GRCDataSet.Client.ElementAt(Me.ClientBindingSource.Position)
            If nr.NatureCl.Equals("Entreprise") Then
                If MsgBox("Proceder à la confirmation de la suppression", vbOKCancel, "Confirmation") = vbOK Then
                    ' Me.ClientTableAdapter.Delete(nr.IdCL)
                    Me.GRCDataSet.Client.RemoveClientRow(nr)
                    Me.GRCDataSet.Client.AcceptChanges()
                End If
            End If
        End If
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim frm As New FajouterPostal
            If Me.ClientBindingSource.Current IsNot Nothing Then
                Dim nr1 As GRCDataSet.ClientRow = Me.GRCDataSet.Client.ElementAt(Me.ClientBindingSource.Position)
                frm.Cin.Text = nr1.IdCL
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim nr As GRCDataSet.CoordonnéesPostalRow = Me.GRCDataSet.CoordonnéesPostal.NewCoordonnéesPostalRow
                        nr.IdCL = frm.Cin.Text
                        nr.CodeP = frm.codeP.Text
                        nr.Rue = frm.rue.Text
                        nr.Ville = frm.ville.Text
                        nr.Région = frm.region.Text
                        nr.Pays = frm.pays.Text
                        Me.GRCDataSet.CoordonnéesPostal.AddCoordonnéesPostalRow(nr)
                        Me.CoordonnéesPostalTableAdapter.Update(nr)
                        Me.GRCDataSet.CoordonnéesPostal.AcceptChanges()
                        Me.CoordonnéesPostalTableAdapter.Fill(Me.GRCDataSet.CoordonnéesPostal)
                    End If
                End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim frm As New FmodifierPostal
            If Me.ClientBindingSource.Current IsNot Nothing Then
                If Me.ClientCoordonnéesPostalBindingSource.Current IsNot Nothing Then
                    Dim nr As GRCDataSet.CoordonnéesPostalRow = Me.GRCDataSet.CoordonnéesPostal.ElementAt(Me.ClientCoordonnéesPostalBindingSource.Position)
                    frm.Cin.Text = nr.IdCL
                    frm.codeP.Text = nr.CodeP
                    frm.rue.Text = nr.Rue
                    frm.ville.Text = nr.Ville
                    frm.region.Text = nr.Région
                    frm.pays.Text = nr.Pays
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        nr.IdCL = frm.Cin.Text
                        nr.CodeP = frm.codeP.Text
                        nr.Rue = frm.rue.Text
                        nr.Ville = frm.ville.Text
                        nr.Région = frm.region.Text
                        nr.Pays = frm.pays.Text
                        Me.CoordonnéesPostalTableAdapter.Update(nr)
                        Me.GRCDataSet.CoordonnéesPostal.AcceptChanges()
                        Me.CoordonnéesPostalTableAdapter.Fill(Me.GRCDataSet.CoordonnéesPostal)
                    End If
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.ClientBindingSource.Current IsNot Nothing Then
            If Me.ClientCoordonnéesPostalBindingSource.Current IsNot Nothing Then
                Dim nr As GRCDataSet.CoordonnéesPostalRow = Me.GRCDataSet.CoordonnéesPostal.ElementAt(Me.ClientCoordonnéesPostalBindingSource.Position)
                If MsgBox("Proceder à la confirmation de la suppression", vbOKCancel, "Confirmation") = vbOK Then
                    ' Me.ClientTableAdapter.Delete(nr.IdCL)
                    Me.GRCDataSet.CoordonnéesPostal.RemoveCoordonnéesPostalRow(nr)
                    Me.GRCDataSet.Client.AcceptChanges()
                End If
            End If
        End If
    End Sub
    Private Sub AjouterInter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterInter.Click
        Try
            Dim frm As New AjouterInt
            If Me.ClientBindingSource.Current IsNot Nothing Then
                Dim nr1 As GRCDataSet.ClientRow = Me.GRCDataSet.Client.ElementAt(Me.ClientBindingSource.Position)
                frm.Cin.Text = nr1.IdCL
                If nr1.TypeCl.Equals("Prospect") Then
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Dim nr As GRCDataSet.InteressementRow = Me.GRCDataSet.Interessement.NewInteressementRow
                        nr.IdCl = frm.Cin.Text
                        nr.IdPr = frm.Code.Text
                        nr.NiveauI = frm.Niveau.Text
                        Me.GRCDataSet.Interessement.AddInteressementRow(nr)
                        Me.InteressementTableAdapter.Update(nr)
                        Me.GRCDataSet.Interessement.AcceptChanges()
                        Me.InteressementTableAdapter.Fill(Me.GRCDataSet.Interessement)
                    End If
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub
    Private Sub ModifierInter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierInter.Click
        Try
            Dim frm As New FmodifierInt
            If Me.ClientBindingSource.Current IsNot Nothing Then
                If Me.ClientInteressementBindingSource.Current IsNot Nothing Then
                    Dim nr1 As GRCDataSet.ClientRow = Me.GRCDataSet.Client.ElementAt(Me.ClientBindingSource.Position)
                    frm.Cin.Text = nr1.IdCL
                    Dim nr2 As GRCDataSet.InteressementRow = Me.GRCDataSet.Interessement.ElementAt(Me.ClientInteressementBindingSource.Position)
                    frm.Code.Text = nr2.IdPr
                    If nr1.TypeCl.Equals("Prospect") Then
                        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                            nr2.IdCl = frm.Cin.Text
                            nr2.IdPr = frm.Code.Text
                            nr2.NiveauI = frm.Niveau.Text
                            Me.InteressementTableAdapter.Update(nr2)
                            Me.GRCDataSet.Interessement.AcceptChanges()
                            Me.InteressementTableAdapter.Fill(Me.GRCDataSet.Interessement)
                        End If
                    End If
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub
    Private Sub SupprimerInter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupprimerInter.Click
        If Me.ClientInteressementBindingSource.Current IsNot Nothing Then
            Dim nr As GRCDataSet.InteressementRow = Me.GRCDataSet.Interessement.ElementAt(Me.ClientInteressementBindingSource.Position)
                If MsgBox("Proceder à la confirmation de la suppression", vbOKCancel, "Confirmation") = vbOK Then
                    ' Me.ClientTableAdapter.Delete(nr.IdCL)
                Me.GRCDataSet.Interessement.RemoveInteressementRow(nr)
                Me.GRCDataSet.Interessement.AcceptChanges()
                End If
            End If
    End Sub

    Private Sub tousB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tousB.Click
        Try
            Me.ClientTableAdapter.Fill(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Nouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nouveau.Click
        Try
            Me.ClientTableAdapter.FillByNouveau(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Ancien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ancien.Click
        Try
            Me.ClientTableAdapter.FillByAncien(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ReelB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReelB.Click
        Try
            Me.ClientTableAdapter.FillByRéel(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Fidel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fidel.Click
        Try
            Me.ClientTableAdapter.FillByFidel(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ParticulierB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParticulierB.Click
        Try
            Me.ClientTableAdapter.FillByParticulier(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ProspectB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProspectB.Click
        Try
            Me.ClientTableAdapter.FillByProspect(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EntrepriseB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntrepriseB.Click
        Try
            Me.ClientTableAdapter.FillByEntreprise(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillByProspectToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.ClientTableAdapter.FillByProspect(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByRéelToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.ClientTableAdapter.FillByRéel(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByProspectToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.ClientTableAdapter.FillByProspect(Me.GRCDataSet.Client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim frm As New FajouterTel
            If Me.ClientBindingSource.Current IsNot Nothing Then
                Dim nr1 As GRCDataSet.ClientRow = Me.GRCDataSet.Client.ElementAt(Me.ClientBindingSource.Position)
                frm.Cin.Text = nr1.IdCL
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim nr As GRCDataSet.CoordonnéesTelephoniquesRow = Me.GRCDataSet.CoordonnéesTelephoniques.NewCoordonnéesTelephoniquesRow
                    nr.IdCL = frm.Cin.Text
                    nr.NumT = frm.numero.Text
                    nr.TypeT = frm.type.Text
                    nr.NatureT = frm.nature.Text
                    nr.CategorieT = frm.categorie.Text
                    nr.PrioritéT = CInt(Int(frm.priorité.Text))
                    Me.GRCDataSet.CoordonnéesTelephoniques.AddCoordonnéesTelephoniquesRow(nr)
                    Me.CoordonnéesTelephoniquesTableAdapter.Update(nr)
                    Me.GRCDataSet.CoordonnéesTelephoniques.AcceptChanges()
                    Me.CoordonnéesTelephoniquesTableAdapter.Fill(Me.GRCDataSet.CoordonnéesTelephoniques)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub

   
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim frm As New FmodifierTel
            If Me.ClientBindingSource.Current IsNot Nothing Then
                If Me.ClientCoordonnéesTelephoniquesBindingSource.Current IsNot Nothing Then
                    Dim nr As GRCDataSet.CoordonnéesTelephoniquesRow = Me.GRCDataSet.CoordonnéesTelephoniques(Me.ClientCoordonnéesTelephoniquesBindingSource.Position)
                    frm.Cin.Text = nr.IdCL
                    frm.numero.Text = nr.NumT
                    frm.type.Text = nr.TypeT
                    frm.nature.Text = nr.NatureT
                    frm.categorie.Text = nr.CategorieT
                    frm.priorité.Text = nr.PrioritéT
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        nr.IdCL = frm.Cin.Text
                        nr.NumT = frm.numero.Text
                        nr.TypeT = frm.type.Text
                        nr.NatureT = frm.nature.Text
                        nr.CategorieT = frm.categorie.Text
                        nr.PrioritéT = CInt(Int(frm.priorité.Text))
                        Me.CoordonnéesTelephoniquesTableAdapter.Update(nr)
                        Me.GRCDataSet.CoordonnéesTelephoniques.AcceptChanges()
                        Me.CoordonnéesTelephoniquesTableAdapter.Fill(Me.GRCDataSet.CoordonnéesTelephoniques)
                    End If
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.ClientBindingSource.Current IsNot Nothing Then
            If Me.ClientCoordonnéesTelephoniquesBindingSource.Current IsNot Nothing Then
                Dim nr As GRCDataSet.CoordonnéesTelephoniquesRow = Me.GRCDataSet.CoordonnéesTelephoniques(Me.ClientCoordonnéesTelephoniquesBindingSource.Position)
                If MsgBox("Proceder à la confirmation de la suppression", vbOKCancel, "Confirmation") = vbOK Then
                    ' Me.ClientTableAdapter.Delete(nr.IdCL)
                    Me.GRCDataSet.CoordonnéesTelephoniques.RemoveCoordonnéesTelephoniquesRow(nr)
                    Me.GRCDataSet.CoordonnéesTelephoniques.AcceptChanges()
                End If
            End If
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim frm As New FajouterElec
            If Me.ClientBindingSource.Current IsNot Nothing Then
                Dim nr1 As GRCDataSet.ClientRow = Me.GRCDataSet.Client.ElementAt(Me.ClientBindingSource.Position)
                frm.Cin.Text = nr1.IdCL
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim nr As GRCDataSet.CoordonnéesElectroniquesRow = Me.GRCDataSet.CoordonnéesElectroniques.NewCoordonnéesElectroniquesRow
                    nr.IdCL = frm.Cin.Text
                    nr._E_mail = frm.Email.Text
                    nr.TypeE = frm.typem.Text
                    Me.GRCDataSet.CoordonnéesElectroniques.AddCoordonnéesElectroniquesRow(nr)
                    Me.CoordonnéesElectroniquesTableAdapter.Update(nr)
                    Me.GRCDataSet.CoordonnéesElectroniques.AcceptChanges()
                    Me.CoordonnéesElectroniquesTableAdapter.Fill(Me.GRCDataSet.CoordonnéesElectroniques)
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Try
            Dim frm As New FmodifierElec
            If Me.ClientBindingSource.Current IsNot Nothing Then
                If Me.ClientCoordonnéesElectroniquesBindingSource.Current IsNot Nothing Then
                    Dim nr As GRCDataSet.CoordonnéesElectroniquesRow = Me.GRCDataSet.CoordonnéesElectroniques(Me.ClientCoordonnéesElectroniquesBindingSource.Position)
                    frm.Cin.Text = nr.IdCL
                    frm.email.Text = nr._E_mail
                    frm.typem.Text = nr.TypeE
                    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                        nr.IdCL = frm.Cin.Text
                        nr._E_mail = frm.email.Text
                        nr.TypeE = frm.typem.Text
                        Me.CoordonnéesElectroniquesTableAdapter.Update(nr)
                        Me.GRCDataSet.CoordonnéesElectroniques.AcceptChanges()
                        Me.CoordonnéesElectroniquesTableAdapter.Fill(Me.GRCDataSet.CoordonnéesElectroniques)
                    End If
                End If
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show("erreur de saisie :" + ex.Message, "erreur")
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Me.ClientBindingSource.Current IsNot Nothing Then
            If Me.ClientCoordonnéesElectroniquesBindingSource.Current IsNot Nothing Then
                Dim nr As GRCDataSet.CoordonnéesElectroniquesRow = Me.GRCDataSet.CoordonnéesElectroniques(Me.ClientCoordonnéesElectroniquesBindingSource.Position)
                If MsgBox("Proceder à la confirmation de la suppression", vbOKCancel, "Confirmation") = vbOK Then
                    ' Me.ClientTableAdapter.Delete(nr.IdCL)
                    Me.GRCDataSet.CoordonnéesElectroniques.RemoveCoordonnéesElectroniquesRow(nr)
                    Me.GRCDataSet.CoordonnéesElectroniques.AcceptChanges()
                End If
            End If
        End If
    End Sub
End Class
