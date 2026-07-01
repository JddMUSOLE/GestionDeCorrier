Public Class MenuPrincipal



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CourrierEntr As New CourrierEntrant()
        CourrierEntr.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CourrierSort As New CourrierSortant()
        CourrierSort.Show()
        Me.Hide()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Application.Exit()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Login As New Login()
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FOS As New FordreServ()
        FOS.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Fis As New Finstruction()
        Fis.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim FSERCH As New FSelectRecherche()
        FSERCH.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim FetatCourrier As New FEtatCourrier()
        FetatCourrier.Show()
        Me.Hide()
    End Sub
End Class