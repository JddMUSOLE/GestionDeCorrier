<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourrierEntrant
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
        Button2 = New Button()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(659, 237)
        Button6.Name = "Button6"
        Button6.Size = New Size(328, 112)
        Button6.TabIndex = 13
        Button6.Text = "Quitter"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(331, 237)
        Button5.Name = "Button5"
        Button5.Size = New Size(328, 112)
        Button5.TabIndex = 14
        Button5.Text = "Retour"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(330, 124)
        Button3.Name = "Button3"
        Button3.Size = New Size(328, 112)
        Button3.TabIndex = 15
        Button3.Text = "Courrier entrant Agent BCC"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(659, 124)
        Button4.Name = "Button4"
        Button4.Size = New Size(328, 112)
        Button4.TabIndex = 16
        Button4.Text = "Courrier entrant Externe"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(2, 124)
        Button2.Name = "Button2"
        Button2.Size = New Size(328, 112)
        Button2.TabIndex = 17
        Button2.Text = "Courriers entrant organe BCC"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Titillium Web", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(983, 92)
        Label1.TabIndex = 12
        Label1.Text = "COURRIERS ENTRANTS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1, 237)
        Button1.Name = "Button1"
        Button1.Size = New Size(328, 112)
        Button1.TabIndex = 17
        Button1.Text = "Courriers entrant Service DRH" & vbCrLf
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CourrierEntrant
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(991, 361)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Name = "CourrierEntrant"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CourrierEntrant"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
