<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourrierEntrantOrgExterne
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        BtnSelect = New Button()
        TxtOrganeExpd = New TextBox()
        Label11 = New Label()
        TxtObserv = New TextBox()
        Label8 = New Label()
        TxtDocScan = New TextBox()
        Label10 = New Label()
        GroupBox1 = New GroupBox()
        ComboCopieInfo = New ComboBox()
        TxtCopieInfo = New TextBox()
        Label9 = New Label()
        TxtDateRecept = New DateTimePicker()
        TxtDateDoc = New DateTimePicker()
        TxtNum = New TextBox()
        TxtRef = New TextBox()
        Label6 = New Label()
        TxtObjet = New TextBox()
        Label5 = New Label()
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
        GroupBox2.Controls.Add(BtnSelect)
        GroupBox2.Controls.Add(TxtOrganeExpd)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(TxtObserv)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(TxtDocScan)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Location = New Point(5, 551)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1803, 246)
        GroupBox2.TabIndex = 23
        GroupBox2.TabStop = False
        GroupBox2.Text = "Détails du courrier"
        ' 
        ' BtnSelect
        ' 
        BtnSelect.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSelect.Location = New Point(1555, 168)
        BtnSelect.Name = "BtnSelect"
        BtnSelect.Size = New Size(233, 60)
        BtnSelect.TabIndex = 6
        BtnSelect.Text = "Select"
        BtnSelect.UseVisualStyleBackColor = True
        ' 
        ' TxtOrganeExpd
        ' 
        TxtOrganeExpd.Font = New Font("Titillium Web", 9.899999F)
        TxtOrganeExpd.Location = New Point(323, 50)
        TxtOrganeExpd.Name = "TxtOrganeExpd"
        TxtOrganeExpd.Size = New Size(1466, 58)
        TxtOrganeExpd.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Titillium Web", 9.899999F)
        Label11.Location = New Point(16, 47)
        Label11.Name = "Label11"
        Label11.Size = New Size(307, 61)
        Label11.TabIndex = 16
        Label11.Text = "Organe Expéditeur :"
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtObserv
        ' 
        TxtObserv.Font = New Font("Titillium Web", 9.899999F)
        TxtObserv.Location = New Point(322, 110)
        TxtObserv.Name = "TxtObserv"
        TxtObserv.Size = New Size(1466, 58)
        TxtObserv.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Titillium Web", 9.899999F)
        Label8.Location = New Point(11, 98)
        Label8.Name = "Label8"
        Label8.Size = New Size(308, 61)
        Label8.TabIndex = 15
        Label8.Text = "Observation :"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtDocScan
        ' 
        TxtDocScan.Font = New Font("Titillium Web", 9.899999F)
        TxtDocScan.Location = New Point(322, 170)
        TxtDocScan.Name = "TxtDocScan"
        TxtDocScan.Size = New Size(1234, 58)
        TxtDocScan.TabIndex = 5
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Titillium Web", 9.899999F)
        Label10.Location = New Point(12, 159)
        Label10.Name = "Label10"
        Label10.Size = New Size(307, 61)
        Label10.TabIndex = 16
        Label10.Text = "Doc. scanné :"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboCopieInfo)
        GroupBox1.Controls.Add(TxtCopieInfo)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(TxtDateRecept)
        GroupBox1.Controls.Add(TxtDateDoc)
        GroupBox1.Controls.Add(TxtNum)
        GroupBox1.Controls.Add(TxtRef)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TxtObjet)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Titillium Web", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(7, 113)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1803, 426)
        GroupBox1.TabIndex = 22
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informations du courrier"
        ' 
        ' ComboCopieInfo
        ' 
        ComboCopieInfo.Font = New Font("Titillium Web", 9.899999F)
        ComboCopieInfo.FormattingEnabled = True
        ComboCopieInfo.Location = New Point(287, 355)
        ComboCopieInfo.Name = "ComboCopieInfo"
        ComboCopieInfo.Size = New Size(242, 58)
        ComboCopieInfo.TabIndex = 30
        ' 
        ' TxtCopieInfo
        ' 
        TxtCopieInfo.Font = New Font("Titillium Web", 9.899999F)
        TxtCopieInfo.Location = New Point(533, 355)
        TxtCopieInfo.Name = "TxtCopieInfo"
        TxtCopieInfo.Size = New Size(1252, 58)
        TxtCopieInfo.TabIndex = 31
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Titillium Web", 9.899999F)
        Label9.Location = New Point(9, 355)
        Label9.Name = "Label9"
        Label9.Size = New Size(280, 61)
        Label9.TabIndex = 32
        Label9.Text = "Copie Info. :"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtDateRecept
        ' 
        TxtDateRecept.Font = New Font("Titillium Web", 9.899999F)
        TxtDateRecept.Location = New Point(288, 294)
        TxtDateRecept.Name = "TxtDateRecept"
        TxtDateRecept.Size = New Size(500, 58)
        TxtDateRecept.TabIndex = 21
        ' 
        ' TxtDateDoc
        ' 
        TxtDateDoc.Font = New Font("Titillium Web", 9.899999F)
        TxtDateDoc.Location = New Point(288, 232)
        TxtDateDoc.Name = "TxtDateDoc"
        TxtDateDoc.Size = New Size(500, 58)
        TxtDateDoc.TabIndex = 20
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
        TxtRef.Location = New Point(289, 173)
        TxtRef.Name = "TxtRef"
        TxtRef.Size = New Size(713, 58)
        TxtRef.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Titillium Web", 9.899999F)
        Label6.Location = New Point(9, 287)
        Label6.Name = "Label6"
        Label6.Size = New Size(281, 61)
        Label6.TabIndex = 24
        Label6.Text = "Date de reception :"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtObjet
        ' 
        TxtObjet.Font = New Font("Titillium Web", 9.899999F)
        TxtObjet.Location = New Point(289, 111)
        TxtObjet.Name = "TxtObjet"
        TxtObjet.Size = New Size(1505, 58)
        TxtObjet.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Titillium Web", 9.899999F)
        Label5.Location = New Point(10, 226)
        Label5.Name = "Label5"
        Label5.Size = New Size(281, 61)
        Label5.TabIndex = 25
        Label5.Text = "Date courrier :"
        Label5.TextAlign = ContentAlignment.MiddleRight
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
        Label4.Location = New Point(11, 167)
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
        Label3.Location = New Point(13, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(281, 61)
        Label3.TabIndex = 27
        Label3.Text = "Objet :"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' BtnQuitter
        ' 
        BtnQuitter.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnQuitter.Location = New Point(1066, 814)
        BtnQuitter.Name = "BtnQuitter"
        BtnQuitter.Size = New Size(188, 105)
        BtnQuitter.TabIndex = 19
        BtnQuitter.Text = "Quitter"
        BtnQuitter.UseVisualStyleBackColor = True
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAnnuler.Location = New Point(688, 814)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(188, 105)
        BtnAnnuler.TabIndex = 18
        BtnAnnuler.Text = "Annuler"
        BtnAnnuler.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(877, 814)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 105)
        Button1.TabIndex = 16
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnEnregistrer
        ' 
        BtnEnregistrer.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnEnregistrer.Location = New Point(499, 814)
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Titillium Web", 8.099999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dataGridCourierOrg.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dataGridCourierOrg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Titillium Web", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dataGridCourierOrg.DefaultCellStyle = DataGridViewCellStyle2
        dataGridCourierOrg.Location = New Point(7, 942)
        dataGridCourierOrg.Name = "dataGridCourierOrg"
        dataGridCourierOrg.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Titillium Web", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dataGridCourierOrg.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dataGridCourierOrg.RowHeadersWidth = 102
        dataGridCourierOrg.Size = New Size(1803, 828)
        dataGridCourierOrg.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Titillium Web", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(7, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(1803, 93)
        Label1.TabIndex = 21
        Label1.Text = "COURRIERS ENTRANTS EXTERNE" & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' boiteDilogFichier
        ' 
        boiteDilogFichier.FileName = "OpenFileDialog1"
        ' 
        ' CourrierEntrantOrgExterne
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(1815, 1791)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(BtnQuitter)
        Controls.Add(BtnAnnuler)
        Controls.Add(Button1)
        Controls.Add(BtnEnregistrer)
        Controls.Add(dataGridCourierOrg)
        Controls.Add(Label1)
        Name = "CourrierEntrantOrgExterne"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CourrierEntrantOrgExterne"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dataGridCourierOrg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSelect As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtObserv As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDocScan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtDateRecept As DateTimePicker
    Friend WithEvents TxtDateDoc As DateTimePicker
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents TxtRef As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtObjet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents dataGridCourierOrg As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtOrganeExpd As TextBox
    Friend WithEvents boiteDilogFichier As OpenFileDialog
    Friend WithEvents ComboCopieInfo As ComboBox
    Friend WithEvents TxtCopieInfo As TextBox
    Friend WithEvents Label9 As Label
End Class
