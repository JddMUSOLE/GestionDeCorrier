Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading
Public Class FEtatCourrier
    Dim cmd As New SqlCommand
    Dim Dread As SqlDataReader
    Dim req As String
    Dim tab As New DataTable()
    Sub fillGrid2()
        Try
            Dim TxtNum As String
            Dim txtObjet As String
            Dim TxtDateCourrier As String
            Dim TxtDateReception As String
            'Dim TxtorganExt As String
            Dim TxtorganDest As String
            Dim AgtDestinateur As String
            Dim RefCourrier As String
            dataGridCourierOrg.ColumnCount = 8
            dataGridCourierOrg.Columns(0).Name = "Numéro"
            dataGridCourierOrg.Columns(1).Name = "Référence courrier"
            dataGridCourierOrg.Columns(2).Name = "Objet"
            dataGridCourierOrg.Columns(3).Name = "Date de courrier"
            dataGridCourierOrg.Columns(4).Name = "Date d'orientation"
            dataGridCourierOrg.Columns(5).Name = "Délai d'orientation"
            dataGridCourierOrg.Columns(6).Name = "Etat du courrier"
            dataGridCourierOrg.Columns(7).Name = "Délai de retard"
            'dataGridCourierOrg.Columns(2).Name = "Organe expéditeur"

            'dataGridCourierOrg.Columns(2).Name = "Organe destinataire"
            'dataGridCourierOrg.Columns(3).Name = "Agent Expéditeur"

            dataGridCourierOrg.Rows.Clear()

            dataGridCourierOrg.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            dataGridCourierOrg.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dataGridCourierOrg.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dataGridCourierOrg.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter



            req = "SELECT * FROM DatagridV1"
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                req = "SELECT * FROM DatagridV1"
                cmd = New SqlCommand(req, con)
                Using Dread1 As SqlDataReader = cmd.ExecuteReader
                    While Dread1.Read()
                        TxtNum = Dread1("NumOrdDoc").ToString()
                        txtObjet = Dread1("ConcerneDoc").ToString()
                        'TxtorganExt = Dread1("OrganeExpediteur").ToString()
                        TxtorganDest = Dread1("OrganeDestinataire").ToString()
                        AgtDestinateur = Dread1("MatriculeExpDestBCC").ToString()
                        RefCourrier = Dread1("RefDoc").ToString()
                        TxtDateCourrier = CDate(Dread1("DateDoc")).ToShortDateString
                        TxtDateReception = CDate(Dread1("DateReception")).ToShortDateString

                        dataGridCourierOrg.Rows.Add(TxtNum, txtObjet, TxtorganDest, AgtDestinateur, RefCourrier, TxtDateCourrier, TxtDateReception)
                    End While


                End Using
            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Chargement datagrid: " & ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con.Close()
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MP As New MenuPrincipal()
        MP.Show()
        Me.Hide()
    End Sub


End Class