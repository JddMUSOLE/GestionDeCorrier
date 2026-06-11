Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    Dim cmd As New SqlCommand
    Dim Dread As SqlDataReader
    Dim req As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Sub Clear()
        TxtMat.Clear()
        TxtPassWord.Clear()
        TxtMat.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                req = "SELECT * FROM Login WHERE MatriculeUser='" & TxtMat.Text & "' AND MotDePasse='" & TxtPassWord.Text & "'"
                cmd = New SqlCommand(req, con)
                Dread = cmd.ExecuteReader()
                If (Dread.Read) Then
                    userMat = TxtMat.Text.Trim()
                    Dim MN As New MenuPrincipal()
                    MN.Show()
                    Me.Hide()
                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Connexion: " & ex.Message)
        End Try
    End Sub



    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        con.Close()
        Application.Exit()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        con.Close()
        Application.Exit()
    End Sub
End Class
