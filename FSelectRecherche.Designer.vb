<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FSelectRecherche
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
        Button6 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button7 = New Button()
        Button8 = New Button()
        SuspendLayout()
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(661, 237)
        Button6.Name = "Button6"
        Button6.Size = New Size(328, 112)
        Button6.TabIndex = 19
        Button6.Text = "A compléter"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(333, 237)
        Button5.Name = "Button5"
        Button5.Size = New Size(328, 112)
        Button5.TabIndex = 20
        Button5.Text = "Consultation par Dates du courrier"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(332, 124)
        Button3.Name = "Button3"
        Button3.Size = New Size(328, 112)
        Button3.TabIndex = 21
        Button3.Text = "Consultation par Référence du courrier"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(661, 124)
        Button4.Name = "Button4"
        Button4.Size = New Size(328, 112)
        Button4.TabIndex = 22
        Button4.Text = "Consultation par Numéro du courrier"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(3, 237)
        Button1.Name = "Button1"
        Button1.Size = New Size(328, 112)
        Button1.TabIndex = 23
        Button1.Text = "Consultation par Etat du courrier" & vbCrLf
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(4, 124)
        Button2.Name = "Button2"
        Button2.Size = New Size(328, 112)
        Button2.TabIndex = 24
        Button2.Text = "Consultation par Objet"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Titillium Web", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(983, 92)
        Label1.TabIndex = 18
        Label1.Text = "CONSULTATION COURRIER"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(144, 353)
        Button7.Name = "Button7"
        Button7.Size = New Size(328, 112)
        Button7.TabIndex = 20
        Button7.Text = "Retour"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(472, 353)
        Button8.Name = "Button8"
        Button8.Size = New Size(328, 112)
        Button8.TabIndex = 19
        Button8.Text = "Quitter"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' FSelectRecherche
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(994, 473)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Name = "FSelectRecherche"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FSelectRecherche"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
