Public Class CourrierEntrant
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim MN As New MenuPrincipal()
        MN.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim courrierEntrantOrg As New CourrierEntrantOrg()
        courrierEntrantOrg.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim courrierEntrantAgt As New CourrierEntrantAgent()
        courrierEntrantAgt.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim courrierEntrantOrgExterne As New CourrierEntrantOrgExterne()
        courrierEntrantOrgExterne.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CourrierSceDrh As New CourrierServiceDRH()
        CourrierSceDrh.Show()
        Me.Hide()
    End Sub
End Class