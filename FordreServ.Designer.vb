<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FordreServ
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
        GroupBox1 = New GroupBox()
        ComboAutoSign = New ComboBox()
        TxtDateRecept = New DateTimePicker()
        TxtDateDoc = New DateTimePicker()
        TxtNum = New TextBox()
        TxtRef = New TextBox()
        Label6 = New Label()
        TxtObjet = New TextBox()
        Label5 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        dataGridCourierOrg = New DataGridView()
        BtnQuitter = New Button()
        BtnAnnuler = New Button()
        Button1 = New Button()
        BtnEnregistrer = New Button()
        BtnSelect = New Button()
        TxtDocScan = New TextBox()
        Label10 = New Label()
        boiteDilogFichier = New OpenFileDialog()
        GroupBox1.SuspendLayout()
        CType(dataGridCourierOrg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboAutoSign)
        GroupBox1.Controls.Add(TxtDateRecept)
        GroupBox1.Controls.Add(TxtDateDoc)
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
        GroupBox1.Location = New Point(13, 117)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1385, 502)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informations de l'ordre de service"
        ' 
        ' ComboAutoSign
        ' 
        ComboAutoSign.Font = New Font("Titillium Web", 9.899999F)
        ComboAutoSign.FormattingEnabled = True
        ComboAutoSign.Location = New Point(288, 365)
        ComboAutoSign.Name = "ComboAutoSign"
        ComboAutoSign.Size = New Size(1071, 58)
        ComboAutoSign.TabIndex = 22
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
        TxtRef.Size = New Size(499, 58)
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
        TxtObjet.Size = New Size(1070, 58)
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
        Label5.Text = "Date de l'OS :"
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
        Label7.Text = "Autorité sign. :"
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
        ' Label1
        ' 
        Label1.Font = New Font("Titillium Web", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(-2, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(1417, 78)
        Label1.TabIndex = 23
        Label1.Text = "ORDRE DE SERVICE"
        Label1.TextAlign = ContentAlignment.MiddleCenter
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
        dataGridCourierOrg.Location = New Point(13, 716)
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
        dataGridCourierOrg.Size = New Size(1391, 455)
        dataGridCourierOrg.TabIndex = 25
        ' 
        ' BtnQuitter
        ' 
        BtnQuitter.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnQuitter.Location = New Point(897, 631)
        BtnQuitter.Name = "BtnQuitter"
        BtnQuitter.Size = New Size(188, 64)
        BtnQuitter.TabIndex = 29
        BtnQuitter.Text = "Quitter"
        BtnQuitter.UseVisualStyleBackColor = True
        ' 
        ' BtnAnnuler
        ' 
        BtnAnnuler.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnAnnuler.Location = New Point(517, 631)
        BtnAnnuler.Name = "BtnAnnuler"
        BtnAnnuler.Size = New Size(188, 64)
        BtnAnnuler.TabIndex = 28
        BtnAnnuler.Text = "Annuler"
        BtnAnnuler.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(706, 631)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 64)
        Button1.TabIndex = 26
        Button1.Text = "Retour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnEnregistrer
        ' 
        BtnEnregistrer.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnEnregistrer.Location = New Point(328, 631)
        BtnEnregistrer.Name = "BtnEnregistrer"
        BtnEnregistrer.Size = New Size(188, 64)
        BtnEnregistrer.TabIndex = 27
        BtnEnregistrer.Text = "Enregistrer"
        BtnEnregistrer.UseVisualStyleBackColor = True
        ' 
        ' BtnSelect
        ' 
        BtnSelect.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSelect.Location = New Point(1133, 541)
        BtnSelect.Name = "BtnSelect"
        BtnSelect.Size = New Size(239, 59)
        BtnSelect.TabIndex = 31
        BtnSelect.Text = "Select"
        BtnSelect.UseVisualStyleBackColor = True
        ' 
        ' TxtDocScan
        ' 
        TxtDocScan.Font = New Font("Titillium Web", 9.899999F)
        TxtDocScan.Location = New Point(301, 542)
        TxtDocScan.Name = "TxtDocScan"
        TxtDocScan.Size = New Size(839, 58)
        TxtDocScan.TabIndex = 30
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Titillium Web", 9.899999F)
        Label10.Location = New Point(22, 536)
        Label10.Name = "Label10"
        Label10.Size = New Size(275, 61)
        Label10.TabIndex = 32
        Label10.Text = "Doc. scanné :"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' boiteDilogFichier
        ' 
        boiteDilogFichier.FileName = "OpenFileDialog1"
        ' 
        ' FordreServ
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(1416, 1183)
        Controls.Add(BtnSelect)
        Controls.Add(TxtDocScan)
        Controls.Add(Label10)
        Controls.Add(BtnQuitter)
        Controls.Add(BtnAnnuler)
        Controls.Add(Button1)
        Controls.Add(BtnEnregistrer)
        Controls.Add(dataGridCourierOrg)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "FordreServ"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FordreServ"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dataGridCourierOrg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboAutoSign As ComboBox
    Friend WithEvents TxtDateRecept As DateTimePicker
    Friend WithEvents TxtDateDoc As DateTimePicker
    Friend WithEvents TxtNum As TextBox
    Friend WithEvents TxtRef As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtObjet As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dataGridCourierOrg As DataGridView
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents BtnSelect As Button
    Friend WithEvents TxtDocScan As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents boiteDilogFichier As OpenFileDialog
End Class
