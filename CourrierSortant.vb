Public Class CourrierSortant
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim MN As New MenuPrincipal()
        MN.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CsortantOrg As New CourrierSortantOrgBcc()
        CsortantOrg.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim CSortantSceDRh As New CourrierSortantSceDRH()
        CSortantSceDRh.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Fsect As New FormSelectOrientation()
        Fsect.Show()
        Me.Hide()
    End Sub
End Class