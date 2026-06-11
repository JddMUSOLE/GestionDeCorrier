<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forientation
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
        GroupBox2 = New GroupBox()
        TxtDateOrientation = New DateTimePicker()
        TxtDelai = New NumericUpDown()
        TxtSceOr = New ComboBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Label14 = New Label()
        BtnSelect = New Button()
        Label11 = New Label()
        Label10 = New Label()
        Label8 = New Label()
        GroupBox1 = New GroupBox()
        TxtEtat = New ComboBox()
        TxtAnnotation = New TextBox()
        Button1 = New Button()
        Label12 = New Label()
        Txtannexe = New TextBox()
        TxtDateExpd = New TextBox()
        TxtDateRecept = New TextBox()
        TxtDateDoc = New TextBox()
        TxtNum = New TextBox()
        Label13 = New Label()
        TxtRef = New TextBox()
        Label6 = New Label()
        TxtObjet = New TextBox()
        Label9 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        GroupBox2.SuspendLayout()
        CType(TxtDelai, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TxtDateOrientation)
        GroupBox2.Controls.Add(TxtDelai)
        GroupBox2.Controls.Add(TxtSceOr)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Controls.Add(Button3)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(BtnSelect)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Location = New Point(-5, 791)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1573, 325)
        GroupBox2.TabIndex = 26
        GroupBox2.TabStop = False
        GroupBox2.Text = "Détails du l'orientation"
        ' 
        ' TxtDateOrientation
        ' 
        TxtDateOrientation.Font = New Font("Titillium Web", 9.899999F)
        TxtDateOrientation.Location = New Point(322, 105)
        TxtDateOrientation.Name = "TxtDateOrientation"
        TxtDateOrientation.Size = New Size(500, 58)
        TxtDateOrientation.TabIndex = 27
        ' 
        ' TxtDelai
        ' 
        TxtDelai.Location = New Point(322, 165)
        TxtDelai.Name = "TxtDelai"
        TxtDelai.Size = New Size(157, 47)
        TxtDelai.TabIndex = 33
        ' 
        ' TxtSceOr
        ' 
        TxtSceOr.Font = New Font("Titillium Web", 9.899999F)
        TxtSceOr.FormattingEnabled = True
        TxtSceOr.Location = New Point(322, 46)
        TxtSceOr.Name = "TxtSceOr"
        TxtSceOr.Size = New Size(1232, 58)
        TxtSceOr.TabIndex = 32
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(1025, 218)
        Button4.Name = "Button4"
        Button4.Size = New Size(233, 60)
        Button4.TabIndex = 6
        Button4.Text = "Quitter"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(791, 218)
        Button3.Name = "Button3"
        Button3.Size = New Size(233, 60)
        Button3.TabIndex = 6
        Button3.Text = "Retour"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(557, 218)
        Button2.Name = "Button2"
        Button2.Size = New Size(233, 60)
        Button2.TabIndex = 6
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Titillium Web", 9.899999F)
        Label14.Location = New Point(16, 107)
        Label14.Name = "Label14"
        Label14.Size = New Size(307, 61)
        Label14.TabIndex = 16
        Label14.Text = "Date d'orientation :"
        Label14.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' BtnSelect
        ' 
        BtnSelect.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSelect.Location = New Point(322, 218)
        BtnSelect.Name = "BtnSelect"
        BtnSelect.Size = New Size(233, 60)
        BtnSelect.TabIndex = 6
        BtnSelect.Text = "Valider"
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
        Label11.Text = "Service traitant:"
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Titillium Web", 9.899999F)
        Label10.Location = New Point(480, 163)
        Label10.Name = "Label10"
        Label10.Size = New Size(107, 52)
        Label10.TabIndex = 15
        Label10.Text = "jours"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Titillium Web", 9.899999F)
        Label8.Location = New Point(11, 156)
        Label8.Name = "Label8"
        Label8.Size = New Size(308, 61)
        Label8.TabIndex = 15
        Label8.Text = "Délai du traitement:"
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TxtEtat)
        GroupBox1.Controls.Add(TxtAnnotation)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(Txtannexe)
        GroupBox1.Controls.Add(TxtDateExpd)
        GroupBox1.Controls.Add(TxtDateRecept)
        GroupBox1.Controls.Add(TxtDateDoc)
        GroupBox1.Controls.Add(TxtNum)
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(TxtRef)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TxtObjet)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Font = New Font("Titillium Web", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(-3, 110)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1571, 665)
        GroupBox1.TabIndex = 25
        GroupBox1.TabStop = False
        GroupBox1.Text = "Informations du courrier"
        ' 
        ' TxtEtat
        ' 
        TxtEtat.Font = New Font("Titillium Web", 9.899999F)
        TxtEtat.FormattingEnabled = True
        TxtEtat.Location = New Point(288, 406)
        TxtEtat.Name = "TxtEtat"
        TxtEtat.Size = New Size(500, 58)
        TxtEtat.TabIndex = 32
        ' 
        ' TxtAnnotation
        ' 
        TxtAnnotation.Font = New Font("Titillium Web", 9.899999F)
        TxtAnnotation.Location = New Point(288, 529)
        TxtAnnotation.Name = "TxtAnnotation"
        TxtAnnotation.Size = New Size(1264, 58)
        TxtAnnotation.TabIndex = 30
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1114, 589)
        Button1.Name = "Button1"
        Button1.Size = New Size(438, 60)
        Button1.TabIndex = 6
        Button1.Text = "Mettre à jour"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Titillium Web", 9.899999F)
        Label12.Location = New Point(8, 527)
        Label12.Name = "Label12"
        Label12.Size = New Size(280, 61)
        Label12.TabIndex = 31
        Label12.Text = "Annotation :"
        Label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Txtannexe
        ' 
        Txtannexe.Font = New Font("Titillium Web", 9.899999F)
        Txtannexe.Location = New Point(288, 467)
        Txtannexe.Name = "Txtannexe"
        Txtannexe.Size = New Size(1264, 58)
        Txtannexe.TabIndex = 23
        ' 
        ' TxtDateExpd
        ' 
        TxtDateExpd.Font = New Font("Titillium Web", 9.899999F)
        TxtDateExpd.Location = New Point(288, 347)
        TxtDateExpd.Name = "TxtDateExpd"
        TxtDateExpd.ReadOnly = True
        TxtDateExpd.Size = New Size(335, 58)
        TxtDateExpd.TabIndex = 17
        ' 
        ' TxtDateRecept
        ' 
        TxtDateRecept.Font = New Font("Titillium Web", 9.899999F)
        TxtDateRecept.Location = New Point(288, 287)
        TxtDateRecept.Name = "TxtDateRecept"
        TxtDateRecept.ReadOnly = True
        TxtDateRecept.Size = New Size(335, 58)
        TxtDateRecept.TabIndex = 17
        ' 
        ' TxtDateDoc
        ' 
        TxtDateDoc.Font = New Font("Titillium Web", 9.899999F)
        TxtDateDoc.Location = New Point(288, 228)
        TxtDateDoc.Name = "TxtDateDoc"
        TxtDateDoc.ReadOnly = True
        TxtDateDoc.Size = New Size(335, 58)
        TxtDateDoc.TabIndex = 17
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
        ' Label13
        ' 
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Titillium Web", 9.899999F)
        Label13.Location = New Point(9, 343)
        Label13.Name = "Label13"
        Label13.Size = New Size(281, 61)
        Label13.TabIndex = 24
        Label13.Text = "Date d'expédition :"
        Label13.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtRef
        ' 
        TxtRef.Font = New Font("Titillium Web", 9.899999F)
        TxtRef.Location = New Point(289, 170)
        TxtRef.Name = "TxtRef"
        TxtRef.Size = New Size(713, 58)
        TxtRef.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Titillium Web", 9.899999F)
        Label6.Location = New Point(9, 284)
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
        TxtObjet.Size = New Size(1265, 58)
        TxtObjet.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Titillium Web", 9.899999F)
        Label9.Location = New Point(8, 405)
        Label9.Name = "Label9"
        Label9.Size = New Size(280, 61)
        Label9.TabIndex = 28
        Label9.Text = "Etat :"
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Titillium Web", 9.899999F)
        Label5.Location = New Point(10, 223)
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
        Label7.Location = New Point(8, 465)
        Label7.Name = "Label7"
        Label7.Size = New Size(280, 61)
        Label7.TabIndex = 28
        Label7.Text = "Annexe :"
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
        Label4.Location = New Point(11, 164)
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
        ' Label1
        ' 
        Label1.Font = New Font("Titillium Web", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(-3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(1571, 93)
        Label1.TabIndex = 24
        Label1.Text = "ORIENTATION COURRIER" & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Forientation
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(1580, 1188)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "Forientation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Forientation"
        GroupBox2.ResumeLayout(False)
        CType(TxtDelai, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSelect As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txtannexe As TextBox
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
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtAnnotation As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtEtat As ComboBox
    Friend WithEvents TxtDelai As NumericUpDown
    Friend WithEvents TxtSceOr As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtDateExpd As TextBox
    Friend WithEvents TxtDateRecept As TextBox
    Friend WithEvents TxtDateDoc As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtDateOrientation As DateTimePicker
End Class
