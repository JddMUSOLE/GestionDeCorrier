<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourrierServiceDRH
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        TxtAgentDest = New TextBox()
        BtnSelect = New Button()
        Label11 = New Label()
        Label13 = New Label()
        TxtOrganeDest = New ComboBox()
        Label12 = New Label()
        TxtOrganeExpd = New ComboBox()
        TxtAGTNoms = New TextBox()
        TxtObserv = New TextBox()
        Label8 = New Label()
        TxtDocScan = New TextBox()
        Label10 = New Label()
        GroupBox1 = New GroupBox()
        ComboCopieInfo = New ComboBox()
        TxtDateRecept = New DateTimePicker()
        TxtDateDoc = New DateTimePicker()
        TxtCopieInfo = New TextBox()
        TxtNum = New TextBox()
        TxtRef = New TextBox()
        Label6 = New Label()
        TxtObjet = New TextBox()
        Label5 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        BtnQuitter = New Button()
        BtnAnnuler = New Button()
        Button1 = New Button()
        BtnEnregistrer = New Button()
        dataGridCourierOrg = New DataGridView()
        Label1 = New Label()
        boiteDilogFichier = New OpenFileDialog()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(dataGridCourierOrg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TxtAgentDest)
        GroupBox2.Controls.Add(BtnSelect)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(TxtOrganeDest)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Controls.Add(TxtOrganeExpd)
        GroupBox2.Controls.Add(TxtAGTNoms)
        GroupBox2.Controls.Add(TxtObserv)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(TxtDocScan)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Location = New Point(2, 595)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1803, 383)
        GroupBox2.TabIndex = 23
        GroupBox2.TabStop = False
        GroupBox2.Text = "Détails du courrier"
        ' 
        ' TxtAgentDest
        ' 
        TxtAgentDest.Font = New Font("Titillium Web", 9.899999F)
        TxtAgentDest.Location = New Point(324, 168)
        TxtAgentDest.Name = "TxtAgentDest"
        TxtAgentDest.Size = New Size(256, 58)
        TxtAgentDest.TabIndex = 17
        ' 
        ' BtnSelect
        ' 
        BtnSelect.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSelect.Location = New Point(1555, 287)
        BtnSelect.Name = "BtnSelect"
        BtnSelect.Size = New Size(233, 60)
        BtnSelect.TabIndex = 6
        BtnSelect.Text = "Select"
        BtnSelect.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Titillium Web", 9.899999F)
        Label11.Location = New Point(16, 47)
        Label11.Name = "Label11"
        Label11.Size = New Size(307, 61)
        Label11.TabIndex = 16
        Label11.Text = "Service Expéditeur :"
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Titillium Web", 9.899999F)
        Label13.Location = New Point(0, 108)
        Label13.Name = "Label13"
        Label13.Size = New Size(324, 61)
        Label13.TabIndex = 15
        Label13.Text = "Organe destinataire :"
        Label13.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtOrganeDest
        ' 
        TxtOrganeDest.Font = New Font("Titillium Web", 9.899999F)
        TxtOrganeDest.FormattingEnabled = True
        TxtOrganeDest.Location = New Point(323, 108)
        TxtOrganeDest.Name = "TxtOrganeDest"
        TxtOrganeDest.Size = New Size(1465, 58)
        TxtOrganeDest.TabIndex = 1
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Titillium Web", 9.899999F)
        Label12.Location = New Point(13, 163)
        Label12.Name = "Label12"
        Label12.Size = New Size(308, 61)
        Label12.TabIndex = 15
        Label12.Text = "Agent destinataire :"
        Label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtOrganeExpd
        ' 
        TxtOrganeExpd.Font = New Font("Titillium Web", 9.899999F)
        TxtOrganeExpd.FormattingEnabled = True
        TxtOrganeExpd.Location = New Point(321, 50)
        TxtOrganeExpd.Name = "TxtOrganeExpd"
        TxtOrganeExpd.Size = New Size(1467, 58)
        TxtOrganeExpd.TabIndex = 0
        ' 
        ' TxtAGTNoms
        ' 
        TxtAGTNoms.Font = New Font("Titillium Web", 9.899999F)
        TxtAGTNoms.Location = New Point(583, 168)
        TxtAGTNoms.Name = "TxtAGTNoms"
        TxtAGTNoms.Size = New Size(1205, 58)
        TxtAGTNoms.TabIndex = 4
        ' 
        ' TxtObserv
        ' 
        TxtObserv.Font = New Font("Titillium Web", 9.899999F)
        TxtObserv.Location = New Point(321, 229)
        TxtObserv.Name = "TxtObserv"
        TxtObserv.Size = New Size(1467, 58)
        TxtObserv.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Titillium Web", 9.899999F)
        Label8.Location = New Point(11, 217)
        Label8.Name = "Label8"
        Label8.Size = New Size(308, 61)
        Label8.TabIndex = 15
        Label8.Text = "Observation :"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtDocScan
        ' 
        TxtDocScan.Font = New Font("Titillium Web", 9.899999F)
        TxtDocScan.Location = New Point(322, 289)
        TxtDocScan.Name = "TxtDocScan"
        TxtDocScan.Size = New Size(1234, 58)
        TxtDocScan.TabIndex = 5
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Titillium Web", 9.899999F)
        Label10.Location = New Point(12, 278)
        Label10.Name = "Label10"
        Label10.Size = New Size(307, 61)
        Label10.TabIndex = 16
        Label10.Text = "Doc. scanné :"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboCopieInfo)
        GroupBox1.Controls.Add(TxtDateRecept)
        GroupBox1.Controls.Add(TxtDateDoc)
        GroupBox1.Controls.Add(TxtCopieInfo)
        GroupBox1.Controls.Add(TxtNum)
        GroupBox1.Controls.Add(TxtRef)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TxtObjet)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Titillium Web", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(4, 110)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1803, 455)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informations du courrier"
        ' 
        ' ComboCopieInfo
        ' 
        ComboCopieInfo.Font = New Font("Titillium Web", 9.899999F)
        ComboCopieInfo.FormattingEnabled = True
        ComboCopieInfo.Location = New Point(288, 365)
        ComboCopieInfo.Name = "ComboCopieInfo"
        ComboCopieInfo.Size = New Size(242, 58)
        ComboCopieInfo.TabIndex = 22
        ' 
        ' TxtDateRecept
        ' 
        TxtDateRecept.Font = New Font("Titillium Web", 9.899999F)
        TxtDateRecept.Location = New Point(288, 306)
        TxtDateRecept.Name = "TxtDateRecept"
        TxtDateRecept.Size = New Size(500, 58)
        TxtDateRecept.TabIndex = 21
        ' 
        ' TxtDateDoc
        ' 
        TxtDateDoc.Font = New Font("Titillium Web", 9.899999F)
        TxtDateDoc.Location = New Point(288, 244)
        TxtDateDoc.Name = "TxtDateDoc"
        TxtDateDoc.Size = New Size(500, 58)
        TxtDateDoc.TabIndex = 20
        ' 
        ' TxtCopieInfo
        ' 
        TxtCopieInfo.Font = New Font("Titillium Web", 9.899999F)
        TxtCopieInfo.Location = New Point(534, 365)
        TxtCopieInfo.Name = "TxtCopieInfo"
        TxtCopieInfo.Size = New Size(1252, 58)
        TxtCopieInfo.TabIndex = 23
        ' 
        ' TxtNum
        ' 
        TxtNum.Font = New Font("Titillium Web", 9.899999F)
        TxtNum.Location = New Point(290, 51)
        TxtNum.Name = "TxtNum"
        TxtNum.ReadOnly = True
        TxtNum.Size = New Size(335, 58)
        TxtNum.TabIndex = 17
        ' 
        ' TxtRef
        ' 
        TxtRef.Font = New Font("Titillium Web", 9.899999F)
        TxtRef.Location = New Point(289, 180)
        TxtRef.Name = "TxtRef"
        TxtRef.Size = New Size(713, 58)
        TxtRef.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Titillium Web", 9.899999F)
        Label6.Location = New Point(9, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(281, 61)
        Label6.TabIndex = 24
        Label6.Text = "Date de reception :"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtObjet
        ' 
        TxtObjet.Font = New Font("Titillium Web", 9.899999F)
        TxtObjet.Location = New Point(289, 115)
        TxtObjet.Name = "TxtObjet"
        TxtObjet.Size = New Size(1505, 58)
        TxtObjet.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Titillium Web", 9.899999F)
        Label5.Location = New Point(10, 238)
        Label5.Name = "Label5"
        Label5.Size = New Size(281, 61)
        Label5.TabIndex = 25
        Label5.Text = "Date courrier :"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Titillium Web", 9.899999F)
        Label7.Location = New Point(10, 365)
        Label7.Name = "Label7"
        Label7.Size = New Size(280, 61)
        Label7.TabIndex = 28
        Label7.Text = "Copie Info. :"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Titillium Web", 9.899999F)
        Label2.Location = New Point(14, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(280, 61)
        Label2.TabIndex = 29
        Label2.Text = "Numéro :"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Titillium Web", 9.899999F)
        Label4.Location = New Point(11, 174)
        Label4.Name = "Label4"
        Label4.Size = New Size(281, 61)
        Label4.TabIndex = 26
        Label4.Text = "Référence :"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Titillium Web", 9.899999F)
        Label3.Location = New Point(13, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(281, 61)
        Label3.TabIndex = 27
        Label3.Text = "Objet :"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' BtnQuitter
        ' 
        BtnQuitter.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnQuitter.Location = New Point(1065, 989)
        BtnQuitter.Name = "BtnQuitter"
        BtnQuitter.Size = New Size(188, 105)
        BtnQuitter.TabIndex = 19
        BtnQuitter.Text = "Quitter"
        BtnQuitter.UseVisualStyleBackColor = True
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAnnuler.Location = New Point(685, 989)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(188, 105)
        BtnAnnuler.TabIndex = 18
        BtnAnnuler.Text = "Annuler"
        BtnAnnuler.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(874, 989)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 105)
        Button1.TabIndex = 16
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnEnregistrer
        ' 
        BtnEnregistrer.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnEnregistrer.Location = New Point(495, 989)
        BtnEnregistrer.Name = "BtnEnregistrer"
        BtnEnregistrer.Size = New Size(188, 105)
        BtnEnregistrer.TabIndex = 17
        BtnEnregistrer.Text = "Enregistrer"
        BtnEnregistrer.UseVisualStyleBackColor = True
        ' 
        ' dataGridCourierOrg
        ' 
        dataGridCourierOrg.AllowUserToAddRows = False
        dataGridCourierOrg.AllowUserToDeleteRows = False
        dataGridCourierOrg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Titillium Web", 8.099999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dataGridCourierOrg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dataGridCourierOrg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Titillium Web", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dataGridCourierOrg.DefaultCellStyle = DataGridViewCellStyle5
        dataGridCourierOrg.Location = New Point(4, 1109)
        dataGridCourierOrg.Name = "dataGridCourierOrg"
        dataGridCourierOrg.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Titillium Web", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dataGridCourierOrg.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dataGridCourierOrg.RowHeadersWidth = 102
        dataGridCourierOrg.Size = New Size(1803, 658)
        dataGridCourierOrg.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Titillium Web", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(4, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(1803, 93)
        Label1.TabIndex = 21
        Label1.Text = "COURRIERS ENTRANTS SERVICE DRH" & vbCrLf & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' boiteDilogFichier
        ' 
        boiteDilogFichier.FileName = "OpenFileDialog1"
        ' 
        ' CourrierServiceDRH
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(1812, 1801)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(BtnQuitter)
        Controls.Add(BtnAnnuler)
        Controls.Add(Button1)
        Controls.Add(BtnEnregistrer)
        Controls.Add(dataGridCourierOrg)
        Controls.Add(Label1)
        Name = "CourrierServiceDRH"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CourrierServiceDRH"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dataGridCourierOrg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtAgentDest As TextBox
    Friend WithEvents BtnSelect As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtOrganeDest As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtOrganeExpd As ComboBox
    Friend WithEvents TxtAGTNoms As TextBox
    Friend WithEvents TxtObserv As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDocScan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboCopieInfo As ComboBox
    Friend WithEvents TxtDateRecept As DateTimePicker
    Friend WithEvents TxtDateDoc As DateTimePicker
    Friend WithEvents TxtCopieInfo As TextBox
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents TxtRef As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtObjet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents dataGridCourierOrg As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents boiteDilogFichier As OpenFileDialog
End Class
