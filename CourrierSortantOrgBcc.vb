Imports System.IO
Imports System.Data.SqlClient

Imports System.Threading

Public Class CourrierSortantOrgBcc
    Dim cmd As New SqlCommand
    Dim Dread As SqlDataReader
    Dim req As String
    Dim tab As New DataTable()
    Dim CheminAcharger As String


    Sub formLoadFields()

        TxtObjet.Text = ""
        TxtRef.Text = ""
        TxtDateDoc.Value = DateTime.Now
        TxtDateExpd.Value = DateTime.Now
        ComboCopieInfo.Items.Clear()
        'TxtOrganeExpd.Items.Clear()
        TxtOrganeDest.Text = ""
        ComboCopieInfo.Text = ""
        'TxtOrganeExpd.Text = ""
        TxtOrganeDest.Text = ""
        TxtDir.Text = ""
        TxtAgentDest.Text = ""
        TxtCopieInfo.Text = ""
        TxtObserv.Text = ""
        TxtDocScan.Text = ""
        TxtAGTNoms.Text = ""
        TxtObjet.Focus()
        TxtObjet.Select()
    End Sub


    Sub fillGrid2()
        Try
            Dim TxtNum As String
            Dim txtObjet As String
            Dim TxtDateCourrier As String
            Dim TxtDateExpedition As String
            'Dim TxtorganExt As String
            Dim TxtorganDest As String
            Dim AgtDestinateur As String
            Dim RefCourrier As String
            dataGridCourierOrg.ColumnCount = 7
            dataGridCourierOrg.Columns(0).Name = "Numéro"
            dataGridCourierOrg.Columns(1).Name = "Objet"
            dataGridCourierOrg.Columns(2).Name = "Référence courrier"
            'dataGridCourierOrg.Columns(2).Name = "Organe expéditeur"
            dataGridCourierOrg.Columns(3).Name = "Organe destinataire"
            dataGridCourierOrg.Columns(4).Name = "Agent destinataire"
            dataGridCourierOrg.Columns(5).Name = "Date de courrier"
            dataGridCourierOrg.Columns(6).Name = "Date de reception"

            dataGridCourierOrg.Rows.Clear()

            dataGridCourierOrg.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dataGridCourierOrg.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dataGridCourierOrg.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter



            req = "SELECT * FROM DataSortantOrg"
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                req = "SELECT * FROM DataSortantOrg"
                cmd = New SqlCommand(req, con)
                Using Dread1 As SqlDataReader = cmd.ExecuteReader
                    While Dread1.Read()
                        TxtNum = Dread1("NumOrdDoc").ToString()
                        txtObjet = Dread1("ConcerneDoc").ToString()
                        'TxtorganExt = Dread1("OrganeExpediteur").ToString()
                        TxtorganDest = Dread1("AbrevDir").ToString()
                        AgtDestinateur = Dread1("MatriculeExpDestBCC").ToString()
                        RefCourrier = Dread1("RefDoc").ToString()
                        TxtDateCourrier = CDate(Dread1("DateDoc")).ToShortDateString
                        TxtDateExpedition = CDate(Dread1("DateExpedition")).ToShortDateString

                        dataGridCourierOrg.Rows.Add(TxtNum, txtObjet, RefCourrier, TxtorganDest, AgtDestinateur, TxtDateCourrier, TxtDateExpedition)
                    End While


                End Using
            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Chargement datagrid: " & ex.Message)
        End Try
    End Sub


    Sub TxtNumSequence()
        Try

            If (con.State = ConnectionState.Closed) Then
                con.Open()
                req = "SELECT NbrLigne FROM CompteurHistoriqueLigne"
                cmd = New SqlCommand(req, con)
                Dread = cmd.ExecuteReader()
                If (Dread.Read) Then
                    TxtNum.Text = "No." & Dread(0)
                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Numéro de séquence: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        con.Close()
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Csortant As New CourrierSortant()
        Csortant.Show()
        Me.Hide()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim cheminFichierOriginal As String = ""

        boiteDilogFichier.Title = "Sélectionnez votre courrier en PDF"
        boiteDilogFichier.Filter = "Fichiers PDF|*.pdf|Tous les fichiers|*.*"
        If boiteDilogFichier.ShowDialog() = 1 Then
            cheminFichierOriginal = boiteDilogFichier.FileName
            'TxtDocScan.Text = Path.GetFileNameWithoutExtension(cheminFichierOriginal)
            Dim dossierDestination As String = Application.StartupPath
            Dim nouveauNom As String = TxtObjet.Text.Trim() & ".pdf"
            Dim cheminFinal As String = Path.Combine(dossierDestination, nouveauNom)
            If File.Exists(cheminFinal) Then
                MessageBox.Show("Un fichier portant ce nom existe déjà dans le dossier de destination.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If TxtObjet.Text.Trim() = "" Then
                MessageBox.Show("Veuillez entrer un objet pour le courrier avant de sélectionner le fichier PDF.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            File.Move(cheminFichierOriginal, cheminFinal)
            CheminAcharger = cheminFinal
            TxtDocScan.Text = CheminAcharger
            MessageBox.Show("Le fichier a été renommé et déplacé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'TxtDocScan.Text = boiteDilogFichier.FileName

        End If
    End Sub

    Private Sub ComboCopieInfo_DropDown(sender As Object, e As EventArgs) Handles ComboCopieInfo.DropDown
        Try
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim req2 = "SELECT AbrevDir FROM  Direction"
                Dim cmd2 As New SqlCommand(req2, con)
                Using Dread2 As SqlDataReader = cmd2.ExecuteReader
                    ComboCopieInfo.Items.Clear()
                    While Dread2.Read()
                        ComboCopieInfo.Items.Add(Dread2(0).ToString())
                    End While
                End Using
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Chargement Copie info: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboCopieInfo_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboCopieInfo.SelectedValueChanged
        If String.IsNullOrEmpty(ComboCopieInfo.Text) Then

        ElseIf TxtCopieInfo.Text.Contains(ComboCopieInfo.Text) Then

        Else
            Dim chaineCI As String = TxtCopieInfo.Text.TrimStart(" "c, "/"c)
            chaineCI += " / " & ComboCopieInfo.Text
            TxtCopieInfo.Text = chaineCI.TrimStart(" "c, "/"c)

        End If
    End Sub

    Private Sub TxtOrganeDest_DropDown(sender As Object, e As EventArgs) Handles TxtOrganeDest.DropDown
        Try
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                Dim req2 = "SELECT DenominationOrgane FROM  Direction"
                Dim cmd2 As New SqlCommand(req2, con)
                Using Dread2 As SqlDataReader = cmd2.ExecuteReader
                    TxtOrganeDest.Items.Clear()
                    While Dread2.Read()
                        TxtOrganeDest.Items.Add(Dread2(0).ToString())
                    End While
                End Using

            End If

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Chargement Organe destinateur: " & ex.Message)
        End Try
    End Sub

    Private Sub TxtOrganeDest_SelectedValueChanged(sender As Object, e As EventArgs) Handles TxtOrganeDest.SelectedValueChanged
        Try

            If (con.State = ConnectionState.Closed) Then
                con.Open()
                'req = "SELECT CodeDirection,DenominationOrgane FROM Direction WHERE DenominationOrgane='" + TxtOrganeDest.Text + "'"
                req = "SELECT CodeDirection,DenominationOrgane FROM Direction WHERE DenominationOrgane=@OrganDest"
                cmd = New SqlCommand(req, con)
                cmd.Parameters.AddWithValue("@OrganDest", TxtOrganeDest.Text)
                Dread = cmd.ExecuteReader()
                If (Dread.Read) Then
                    If TxtOrganeDest.Text <> "" Then
                        codeOrganeDest = Dread("CodeDirection").ToString()
                    Else
                        codeOrganeDest = ""
                    End If


                End If
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Numéro de séquence: " & ex.Message)
        End Try
    End Sub

    Private Sub TxtAgentDest_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtAgentDest.KeyDown
        If e.KeyData = Keys.Enter Then
            Try

                If (con.State = ConnectionState.Closed) Then
                    con.Open()
                    req = "SELECT Noms,AbrevDir FROM Agent1 WHERE Matricule = @Noms"
                    cmd = New SqlCommand(req, con)
                    cmd.Parameters.AddWithValue("@Noms", TxtAgentDest.Text)
                    Dread = cmd.ExecuteReader()
                    If (Dread.Read) Then
                        TxtAGTNoms.Text = Dread(0)
                        TxtDir.Text = Dread(1)
                        TxtObserv.Focus()
                    Else
                        TxtAGTNoms.Text = ""
                        TxtDir.Text = ""
                        TxtAgentDest.Text = ""
                        MessageBox.Show("Ce matricule n'existe pas")
                        TxtAgentDest.Focus()
                    End If

                End If
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Numéro de séquence: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        formLoadFields()
        TxtNumSequence()
        fillGrid2()
    End Sub

    Private Sub CourrierSortantOrgBcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadFields()
        TxtNumSequence()
        fillGrid2()
    End Sub

    Private Sub BtnEnregistrer_Click(sender As Object, e As EventArgs) Handles BtnEnregistrer.Click
        Try

            If TxtObjet.Text = "" Or TxtRef.Text = "" Then
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

                formLoadFields()
                TxtNumSequence()
                fillGrid2()
                Exit Sub
            End If

            req = "INSERT INTO Document(NumOrdDoc,RefDoc,ConcerneDoc,DateDoc,DateExpedition,
                    CopieInfo,Emplacement,CodeTypeDoc,Observation,OrganeDestBCC,
                    MatriculeExpDestBCC,UserSecBCC) VALUES('" + TxtNum.Text.ToString.Trim + "','" + TxtRef.Text.ToString.Trim + "','" + TxtObjet.Text.ToString.Trim + "','" + TxtDateDoc.Value.Date + "',
                    '" + TxtDateExpd.Value.Date + "','" + TxtCopieInfo.Text.ToString.Trim + "','" + CheminAcharger + "','" + typeDocumentSortant + "','" + TxtObserv.Text.ToString.Trim + "','" + codeOrganeDest + "','" + TxtAgentDest.Text.ToString.Trim + "','" + userMat + "')"
            If (con.State = ConnectionState.Closed) Then
                con.Open()

                Using cmd3 = New SqlCommand(req, con)
                    cmd3.ExecuteNonQuery()
                    MessageBox.Show("Enregistrement effectué avec succès")


                End Using

            End If
            con.Close()

            formLoadFields()
            TxtNumSequence()
            fillGrid2()
        Catch ex As Exception
            MessageBox.Show("Enregistrement: " & ex.Message)
        End Try
    End Sub
End Class