﻿Public Class FajouterEntreprise

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Annulercl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Annulercl.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub FajouterEntreprise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class