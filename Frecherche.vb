
Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading
Public Class Frecherche
    Dim cmd As New SqlCommand
    Dim Dread As SqlDataReader
    Dim req As String
    Dim tab As New DataTable()
    Dim CheminAcharger As String


    Sub formLoadFields()
        TxtRef.Text = ""

        TxtRef.Focus()
        TxtRef.Select()
    End Sub
    Sub fillGrid2()
        Try
            Dim TxtNum As String
            Dim txtObjet As String
            Dim RefCourrier As String
            Dim TxtorganExped As String
            Dim TxtorganDest As String
            Dim TxtorganExt As String
            Dim AgtDestinateur As String
            Dim TxtDateCourrier As String
            Dim TxtDateReception As String
            Dim TxtDateExpedition As String
            Dim Etat As String
            Dim typeDoc As String
            dataGridCourierOrg.ColumnCount = 12
            dataGridCourierOrg.Columns(0).Name = "Numéro"
            dataGridCourierOrg.Columns(1).Name = "Objet"
            dataGridCourierOrg.Columns(2).Name = "Référence courrier"

            dataGridCourierOrg.Columns(3).Name = "Organe expéditeur"
            dataGridCourierOrg.Columns(4).Name = "Organe destinataire"
            dataGridCourierOrg.Columns(5).Name = "Organe Externe"
            dataGridCourierOrg.Columns(6).Name = "Agent destinataire"

            dataGridCourierOrg.Columns(7).Name = "Date de courrier"
            dataGridCourierOrg.Columns(8).Name = "Date de reception"
            dataGridCourierOrg.Columns(9).Name = "Date d'expédition"
            dataGridCourierOrg.Columns(10).Name = "Type Doc."
            dataGridCourierOrg.Columns(11).Name = "Etat"


            dataGridCourierOrg.Rows.Clear()

            dataGridCourierOrg.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dataGridCourierOrg.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dataGridCourierOrg.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter



            req = "SELECT * FROM DataGridSelect"
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                req = "SELECT * FROM DataGridSelect"
                cmd = New SqlCommand(req, con)
                Using Dread1 As SqlDataReader = cmd.ExecuteReader
                    While Dread1.Read()
                        TxtNum = Dread1("NumOrdDoc").ToString()
                        txtObjet = Dread1("ConcerneDoc").ToString()
                        TxtorganExped = Dread1("OrganeExp").ToString()
                        TxtorganExt = Dread1("OrganeExterne").ToString()
                        TxtorganDest = Dread1("OrganeDest").ToString()
                        AgtDestinateur = Dread1("MatriculeExpDestBCC").ToString()
                        RefCourrier = Dread1("RefDoc").ToString()
                        'TxtDateCourrier = CDate(Dread1("DateDoc")).ToShortDateString
                        'TxtDateReception = CDate(Dread1("DateReception")).ToShortDateString
                        'TxtDateExpedition = CDate(Dread1("DateExpedition")).ToShortDateString


                        TxtDateCourrier = If(IsDBNull(Dread1("DateDoc")), "", CDate(Dread1("DateDoc")).ToShortDateString())
                        TxtDateReception = If(IsDBNull(Dread1("DateReception")), "", CDate(Dread1("DateReception")).ToShortDateString())
                        TxtDateExpedition = If(IsDBNull(Dread1("DateExpedition")), "", CDate(Dread1("DateExpedition")).ToShortDateString())
                        Etat = Dread1("LibEtat1").ToString()
                        typeDoc = Dread1("DesiTypeDoc").ToString()
                        dataGridCourierOrg.Rows.Add(TxtNum, txtObjet, RefCourrier, TxtorganExped, TxtorganDest, TxtorganExt, AgtDestinateur, TxtDateCourrier, TxtDateReception, TxtDateExpedition, typeDoc, Etat)
                    End While


                End Using
            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Chargement datagrid: " & ex.Message)
        End Try
    End Sub

    Private Sub Frecherche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formLoadFields()

        fillGrid2()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        formLoadFields()

        fillGrid2()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con.Close()
        Application.Exit()
    End Sub

    Private Sub TxtRef_TextChanged(sender As Object, e As EventArgs) Handles TxtRef.TextChanged
        Try
            Dim TxtNum As String
            Dim txtObjet As String
            Dim RefCourrier As String
            Dim TxtorganExped As String
            Dim TxtorganDest As String
            Dim TxtorganExt As String
            Dim AgtDestinateur As String
            Dim TxtDateCourrier As String
            Dim TxtDateReception As String
            Dim TxtDateExpedition As String
            Dim Etat As String
            Dim typeDoc As String
            dataGridCourierOrg.ColumnCount = 12
            dataGridCourierOrg.Columns(0).Name = "Numéro"
            dataGridCourierOrg.Columns(1).Name = "Objet"
            dataGridCourierOrg.Columns(2).Name = "Référence courrier"

            dataGridCourierOrg.Columns(3).Name = "Organe expéditeur"
            dataGridCourierOrg.Columns(4).Name = "Organe destinataire"
            dataGridCourierOrg.Columns(5).Name = "Organe Externe"
            dataGridCourierOrg.Columns(6).Name = "Agent destinataire"

            dataGridCourierOrg.Columns(7).Name = "Date de courrier"
            dataGridCourierOrg.Columns(8).Name = "Date de reception"
            dataGridCourierOrg.Columns(9).Name = "Date d'expédition"
            dataGridCourierOrg.Columns(10).Name = "Type Doc."
            dataGridCourierOrg.Columns(11).Name = "Etat"


            dataGridCourierOrg.Rows.Clear()

            dataGridCourierOrg.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dataGridCourierOrg.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dataGridCourierOrg.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter



            'req = "SELECT * FROM DataGridSelect WHERE RefDoc=@Refnote"
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                req = "SELECT * FROM DataGridSelect WHERE ConcerneDoc Like @ConcerneDoc"
                cmd = New SqlCommand(req, con)
                cmd.Parameters.AddWithValue("@ConcerneDoc", "%" & TxtRef.Text.Trim & "%")
                Using Dread1 As SqlDataReader = cmd.ExecuteReader
                    While Dread1.Read()
                        TxtNum = Dread1("NumOrdDoc").ToString()
                        txtObjet = Dread1("ConcerneDoc").ToString()
                        TxtorganExped = Dread1("OrganeExp").ToString()
                        TxtorganExt = Dread1("OrganeExterne").ToString()
                        TxtorganDest = Dread1("OrganeDest").ToString()
                        AgtDestinateur = Dread1("MatriculeExpDestBCC").ToString()
                        RefCourrier = Dread1("RefDoc").ToString()
                        'TxtDateCourrier = CDate(Dread1("DateDoc")).ToShortDateString
                        'TxtDateReception = CDate(Dread1("DateReception")).ToShortDateString
                        'TxtDateExpedition = CDate(Dread1("DateExpedition")).ToShortDateString


                        TxtDateCourrier = If(IsDBNull(Dread1("DateDoc")), "", CDate(Dread1("DateDoc")).ToShortDateString()).ToString()
                        TxtDateReception = If(IsDBNull(Dread1("DateReception")), "", CDate(Dread1("DateReception")).ToShortDateString()).ToString()
                        TxtDateExpedition = If(IsDBNull(Dread1("DateExpedition")), "", CDate(Dread1("DateExpedition")).ToShortDateString()).ToString()
                        Etat = Dread1("LibEtat1").ToString()
                        typeDoc = Dread1("DesiTypeDoc").ToString()
                        dataGridCourierOrg.Rows.Add(TxtNum, txtObjet, RefCourrier, TxtorganExped, TxtorganDest, TxtorganExt, AgtDestinateur, TxtDateCourrier, TxtDateReception, TxtDateExpedition, typeDoc, Etat)
                    End While


                End Using
            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Chargement datagrid: " & ex.Message)
        End Try
    End Sub
    Dim UrlDoc As String
    Private Sub TxtRef_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtRef.KeyDown
        If e.KeyData = Keys.Enter Then
            Try

                If (con.State = ConnectionState.Closed) Then
                    con.Open()
                    req = "SELECT *, ISNULL(CONVERT(VARCHAR(10), DateReception, 103), '') AS DateRecptFrt, 
                            ISNULL(CONVERT(VARCHAR(10), DateDoc, 103), '') AS DateDocFrt,
                            ISNULL(CONVERT(VARCHAR(10), DateExpedition, 103), '') AS DateExpeditionFrt  FROM DataGridSelect WHERE ConcerneDoc = @RefDoc"
                    cmd = New SqlCommand(req, con)
                    cmd.Parameters.AddWithValue("@RefDoc", TxtRef.Text.Trim)
                    Dread = cmd.ExecuteReader()
                    If (Dread.Read) Then
                        concerne = Dread("ConcerneDoc").ToString
                        NumDocc = Dread("NumOrdDoc").ToString
                        RefDoc = Dread("RefDoc").ToString
                        DateDocument = Dread("DateDocFrt")
                        DateRecept = Dread("DateRecptFrt")
                        DateExped = Dread("DateExpeditionFrt")
                        Etat = Dread("LibEtat1").ToString
                        Annexe = Dread("Annexe").ToString
                        annotation = Dread("Annotation").ToString
                        UrlDoc = Dread("Emplacement").ToString
                        'A changer

                        'Dim FORT As New Forientation()
                        'FORT.Show()
                        'Me.Hide()

                    Else

                        MessageBox.Show("Cette référence est inexistante")
                        formLoadFields()

                        fillGrid2()

                    End If

                End If
                con.Close()
            Catch ex As Exception
                MessageBox.Show("Numéro de séquence: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Fselect As New FSelectRecherche()
        Fselect.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If (con.State = ConnectionState.Closed) Then
                con.Open()
                req = "SELECT Emplacement FROM Document WHERE RefDoc = @RefDoc"
                cmd = New SqlCommand(req, con)
                cmd.Parameters.AddWithValue("@RefDoc", RefDoc)
                Dread = cmd.ExecuteReader()
                If (Dread.Read) Then

                    UrlDoc = Dread("Emplacement").ToString
                    If Not String.IsNullOrEmpty(UrlDoc) Then
                        Try
                            ' 3. Configuration pour forcer Windows à utiliser le navigateur par défaut
                            Dim psi As New ProcessStartInfo()
                            psi.FileName = UrlDoc
                            psi.UseShellExecute = True ' Crucial sous .NET Core / .NET 5+

                            ' 4. Lancement du processus
                            Process.Start(psi)

                        Catch ex As Exception
                            ' En cas de problème (pas de connexion internet, URL malformée, etc.)
                            MessageBox.Show("Impossible d'ouvrir le fichier PDF : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try

                    Else
                        MessageBox.Show("Le lien du PDF est vide.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Else

                        MessageBox.Show("Cette référence est inexistante")
                    formLoadFields()

                    fillGrid2()

                End If

            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Numéro de séquence: " & ex.Message)
        End Try
    End Sub
End Class