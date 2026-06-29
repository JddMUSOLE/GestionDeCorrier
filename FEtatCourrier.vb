Imports System.Data.SqlClient
Imports System.IO
Imports System.Threading
Public Class FEtatCourrier
    Dim cmd As New SqlCommand
    Dim Dread As SqlDataReader
    Dim req As String
    Dim tab As New DataTable()
    Dim RefSelectionner As String

    Sub initialForm()
        TxtObjetComp.Text = ""
        TxtObjetComp.Focus()
        TxtObjetComp.Select()
    End Sub
    Sub fillGrid2()
        Try
            Dim TxtNum As String
            Dim TxtRefDoc As String
            Dim txtObjet As String
            Dim TxtDateCourrier As String

            'Dim TxtorganExt As String
            Dim DateOrientation As String
            Dim DelaiOrientation As String
            Dim EtatCourrier As String
            Dim DelaiRetard As String


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



            req = "SELECT * FROM VEtatCourrier"
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                req = "SELECT * FROM VEtatCourrier"
                cmd = New SqlCommand(req, con)
                Using Dread1 As SqlDataReader = cmd.ExecuteReader
                    While Dread1.Read()
                        TxtNum = Dread1("NumOrdDoc").ToString()
                        TxtRefDoc = Dread1("RefDoc").ToString()
                        txtObjet = Dread1("ConcerneDoc").ToString()
                        TxtDateCourrier = CDate(Dread1("DateDoc")).ToShortDateString
                        DateOrientation = CDate(Dread1("DateOrientation")).ToShortDateString
                        'TxtorganExt = Dread1("OrganeExpediteur").ToString()
                        DelaiOrientation = Dread1("DelaiTrait").ToString()
                        EtatCourrier = Dread1("LibEtat").ToString()
                        DelaiRetard = Dread1("retardjours").ToString()
                        'retard = CInt(Dread1("retardjours"))

                        dataGridCourierOrg.Rows.Add(TxtNum, TxtRefDoc, txtObjet, TxtDateCourrier, DateOrientation, DelaiOrientation, EtatCourrier, DelaiRetard)


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

    Private Sub FEtatCourrier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillGrid2()
        initialForm()
    End Sub

    Private Sub TxtObjet_TextChanged(sender As Object, e As EventArgs) Handles TxtObjetComp.TextChanged
        Try
            Dim TxtNum As String
            Dim TxtRefDoc As String
            Dim txtObjet As String
            Dim TxtDateCourrier As String

            'Dim TxtorganExt As String
            Dim DateOrientation As String
            Dim DelaiOrientation As String
            Dim EtatCourrier As String
            Dim DelaiRetard As String


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



            req = "SELECT * FROM VEtatCourrier"
            If (con.State = ConnectionState.Closed) Then
                con.Open()
                req = "SELECT * FROM VEtatCourrier WHERE ConcerneDoc LIKE @Concern"
                cmd = New SqlCommand(req, con)
                cmd.Parameters.AddWithValue("@Concern", "%" & TxtObjetComp.Text.Trim & "%")
                Using Dread1 As SqlDataReader = cmd.ExecuteReader
                    While Dread1.Read()
                        TxtNum = Dread1("NumOrdDoc").ToString()
                        TxtRefDoc = Dread1("RefDoc").ToString()
                        txtObjet = Dread1("ConcerneDoc").ToString()
                        TxtDateCourrier = CDate(Dread1("DateDoc")).ToShortDateString
                        DateOrientation = CDate(Dread1("DateOrientation")).ToShortDateString
                        'TxtorganExt = Dread1("OrganeExpediteur").ToString()
                        DelaiOrientation = Dread1("DelaiTrait").ToString()
                        EtatCourrier = Dread1("LibEtat").ToString()
                        DelaiRetard = Dread1("retardjours").ToString()



                        dataGridCourierOrg.Rows.Add(TxtNum, TxtRefDoc, txtObjet, TxtDateCourrier, DateOrientation, DelaiOrientation, EtatCourrier, DelaiRetard)
                    End While


                End Using
            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show("Chargement datagrid: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fillGrid2()
        initialForm()
    End Sub

    Private Sub dataGridCourierOrg_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dataGridCourierOrg.CellFormatting
        If dataGridCourierOrg.Columns(e.ColumnIndex).Name = "Délai de retard" Then
            If e.Value IsNot Nothing Then
                Dim row As DataGridViewRow = dataGridCourierOrg.Rows(e.RowIndex)
                If (CInt(e.Value) > 0) Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                    row.DefaultCellStyle.ForeColor = Color.Black ' Pour que le texte reste lisible'
                ElseIf (CInt(e.Value) = 0) Then
                    row.DefaultCellStyle.BackColor = Color.Beige
                    row.DefaultCellStyle.ForeColor = Color.Black ' 
                ElseIf (CInt(e.Value) < 0) And (CInt(e.Value) > -10) Then
                    row.DefaultCellStyle.BackColor = Color.Salmon
                    row.DefaultCellStyle.ForeColor = Color.Black ' 
                ElseIf (CInt(e.Value) <= -10) Then
                    row.DefaultCellStyle.BackColor = Color.Red
                    row.DefaultCellStyle.ForeColor = Color.Black ' 

                End If

            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RefSelectionner Is Nothing Or RefSelectionner <> "") Then

            Try

                req = "UPDATE Document SET CodeEtat=@CodeEtat WHERE RefDoc=@RefDoc"
                If (con.State = ConnectionState.Closed) Then
                    con.Open()
                    Using cmd3 = New SqlCommand(req, con)
                        cmd3.Parameters.AddWithValue("@CodeEtat", "0003")
                        'cmd3.Parameters.AddWithValue("@Annotation", TxtAnnotation.Text)
                        'cmd3.Parameters.AddWithValue("@Annexe", Txtannexe.Text)
                        cmd3.Parameters.AddWithValue("@RefDoc", RefSelectionner)
                        cmd3.ExecuteNonQuery()
                        MessageBox.Show("Courrier traité")

                    End Using
                    con.Close()
                End If


                'TxtAnnotation.Text = ""
                'Txtannexe.Text = ""
                'TxtEtat.Text = ""

                fillGrid2()
                initialForm()

            Catch ex As Exception
                MessageBox.Show("Enregistrement: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Selectionner d'abord une ligne")
            TxtObjetComp.Focus()
            TxtObjetComp.SelectAll()
        End If
    End Sub

    Private Sub dataGridCourierOrg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridCourierOrg.CellClick
        If e.RowIndex >= 0 Then
            Dim ValSelct As DataGridViewCell = dataGridCourierOrg.Rows(e.RowIndex).Cells(1)
            If ValSelct.Value IsNot Nothing Then
                RefSelectionner = ValSelct.Value.ToString

            Else
                RefSelectionner = ""
            End If
        End If
    End Sub
End Class