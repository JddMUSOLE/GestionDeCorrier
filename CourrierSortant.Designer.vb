<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourrierSortant
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
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(470, 237)
        Button6.Name = "Button6"
        Button6.Size = New Size(328, 112)
        Button6.TabIndex = 6
        Button6.Text = "Quitter"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(142, 237)
        Button5.Name = "Button5"
        Button5.Size = New Size(328, 112)
        Button5.TabIndex = 7
        Button5.Text = "Retour"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(658, 124)
        Button3.Name = "Button3"
        Button3.Size = New Size(328, 112)
        Button3.TabIndex = 8
        Button3.Text = "Courrier sortant organe externe"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(330, 124)
        Button2.Name = "Button2"
        Button2.Size = New Size(328, 112)
        Button2.TabIndex = 10
        Button2.Text = "Courriers sortant organe BCC"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(3, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(328, 112)
        Button1.TabIndex = 11
        Button1.Text = "Orientation DRH"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Titillium Web", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(983, 92)
        Label1.TabIndex = 5
        Label1.Text = "COURRIERS SORTANTS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CourrierSortant
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(993, 376)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "CourrierSortant"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CourrierSortant"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
