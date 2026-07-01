Public Class FSelectRecherche
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim MP As New MenuPrincipal()
        MP.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Frec As New Frecherche()
        Frec.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        con.Close()
        Application.Exit()
    End Sub
End Class