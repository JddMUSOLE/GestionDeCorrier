Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading
Public Class Forientation
    Dim cmd As New SqlCommand
    Dim Dread As SqlDataReader
    Dim req As String
    Dim tab As New DataTable()
    Dim CheminAcharger As String
    Sub FormLoad()

        TxtDelai.Value = TxtDelai.Minimum
        TxtSceOr.Text = ""

        TxtObjet.Text = concerne
        TxtNum.Text = NumDocc
        TxtRef.Text = RefDoc
        TxtDateDoc.Text = DateDocument
        TxtDateRecept.Text = DateRecept
        TxtDateExpd.Text = DateExped
        Txtannexe.Text = Annexe
        TxtAnnotation.Text = annotation
        TxtEtat.Text = Etat


    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con.Close()
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Fselect As New FormSelectOrientation()
        Fselect.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormLoad()
    End Sub

    Private Sub Forientation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Private Sub TxtEtat_DropDown(sender As Object, e As EventArgs) Handles TxtEtat.DropDown
        Try
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim req2 = "SELECT LibEtat FROM  Etat"
                Dim cmd2 As New SqlCommand(req2, con)
                Using Dread2 As SqlDataReader = cmd2.ExecuteReader
                    TxtEtat.Items.Clear()
                    While Dread2.Read()
                        TxtEtat.Items.Add(Dread2(0).ToString())
                    End While
                End Using

            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Chargement Organe Expéditeur: " & ex.Message)
        End Try
    End Sub

    Private Sub TxtEtat_SelectedValueChanged(sender As Object, e As EventArgs) Handles TxtEtat.SelectedValueChanged
        Try

            If (con.State = ConnectionState.Closed) Then
                con.Open()

                req = "SELECT CodeEtat,LibEtat FROM Etat WHERE LibEtat=@LibEtat"
                cmd = New SqlCommand(req, con)
                cmd.Parameters.AddWithValue("@LibEtat", TxtEtat.Text)
                Dread = cmd.ExecuteReader()
                If (Dread.Read) Then
                    CodeEtatCharge = Dread("CodeEtat").ToString()

                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Numéro de l Etat: " & ex.Message)
        End Try
    End Sub

    Private Sub TxtSceOr_DropDown(sender As Object, e As EventArgs) Handles TxtSceOr.DropDown
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
                Dim req2 = "SELECT LibService FROM Service"
                Dim cmd2 As New SqlCommand(req2, con)
                Using Dread2 = cmd2.ExecuteReader
                    TxtSceOr.Items.Clear()

                    While Dread2.Read
                        TxtSceOr.Items.Add(Dread2("LibService").ToString)
                    End While
                End Using

            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Chargement Service Expéditeur: " & ex.Message)
        End Try
    End Sub
    Dim CodeServiceOrientation As String

    Private Sub TxtSceOr_SelectedValueChanged(sender As Object, e As EventArgs) Handles TxtSceOr.SelectedValueChanged
        Try

            If (con.State = ConnectionState.Closed) Then
                con.Open()
                'req = "SELECT CodeService,LibService FROM Service WHERE LibService='" + TxtOrganeExpd.Text + "'"
                req = "SELECT CodeService,LibService FROM Service WHERE LibService=@OrganExp"
                cmd = New SqlCommand(req, con)
                cmd.Parameters.AddWithValue("@OrganExp", TxtSceOr.Text)
                Dread = cmd.ExecuteReader()
                If (Dread.Read) Then
                    SceOrienter = Dread("CodeService").ToString()
                    'MessageBox.Show("Code service expéditeur: " & SceOrienter)
                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Selection valeur: " & ex.Message)
        End Try




        'Try

        '    If con.State = ConnectionState.Closed Then
        '        con.Open()
        '        'req = "SELECT CodeService,LibService FROM Service WHERE LibService='" + TxtOrganeExpd.Text + "'"
        '        req = "SELECT CodeService FROM Service WHERE LibService=@OrganExp"
        '        cmd = New SqlCommand(req, con)
        '        cmd.Parameters.AddWithValue("@OrganExp", TxtSceOr.Text)
        '        Dread = cmd.ExecuteReader
        '        If Dread.Read Then
        '            CodeServiceOrientation = Dread(0).ToString

        '            MessageBox.Show("Code service expéditeur: " & CodeService)
        '        End If
        '    End If
        '    con.Close()
        'Catch ex As Exception
        '    MessageBox.Show("Selection valeur: " & ex.Message)
        'End Try
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Try

            If TxtSceOr.Text = "" Or TxtEtat.Text = "" Then
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

                FormLoad()
                Exit Sub
            End If

            'req = "INSERT INTO Orientation(CodeSce,RefDoc,DateOrientation,DelaiTrait) VALUES ('" + CodeServiceOrientation.ToString() + "','" + TxtRef.Text.ToString + "','" + TxtDateOrientation.Value.Date + "','" + TxtDelai.Value + "')"
            Dim req As String = "INSERT INTO Orientation (CodeSce, RefDoc, DateOrientation, DelaiTrait) " &
                    "VALUES (@CodeSce1, @RefDoc, @DateOrientation, @DelaiTrait)"
            If (con.State = ConnectionState.Closed) Then
                con.Open()

                Using cmd3 = New SqlCommand(req, con)

                    cmd3.Parameters.AddWithValue("@CodeSce1", SceOrienter)
                    cmd3.Parameters.AddWithValue("@RefDoc", TxtRef.Text.Trim())
                    cmd3.Parameters.AddWithValue("@DateOrientation", TxtDateOrientation.Value.Date)
                    cmd3.Parameters.AddWithValue("@DelaiTrait", TxtDelai.Value)


                    cmd3.ExecuteNonQuery()
                    MessageBox.Show("Enregistrement effectué avec succès")


                End Using

            End If
            con.Close()
            FormLoad()
            'formLoadFields()
            'TxtNumSequence()
            'fillGrid2()
        Catch ex As Exception
            MessageBox.Show("Enregistrement: " & ex.Message)
        End Try
    End Sub
End Class