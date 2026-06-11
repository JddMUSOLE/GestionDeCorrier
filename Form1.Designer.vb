<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TxtMat = New TextBox()
        TxtPassWord = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Titillium Web", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(6, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(585, 92)
        Label1.TabIndex = 0
        Label1.Text = "AUTHENTIFICATION"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Titillium Web", 9.899999F)
        Label2.Location = New Point(15, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(222, 61)
        Label2.TabIndex = 1
        Label2.Text = "Matricule :"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Titillium Web", 9.899999F)
        Label3.Location = New Point(14, 161)
        Label3.Name = "Label3"
        Label3.Size = New Size(223, 61)
        Label3.TabIndex = 1
        Label3.Text = "Mot de passe :"
        Label3.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' TxtMat
        ' 
        TxtMat.Font = New Font("Titillium Web", 9.899999F)
        TxtMat.Location = New Point(231, 103)
        TxtMat.Multiline = True
        TxtMat.Name = "TxtMat"
        TxtMat.Size = New Size(335, 61)
        TxtMat.TabIndex = 1
        ' 
        ' TxtPassWord
        ' 
        TxtPassWord.Font = New Font("Titillium Web", 9.899999F)
        TxtPassWord.Location = New Point(231, 167)
        TxtPassWord.Multiline = True
        TxtPassWord.Name = "TxtPassWord"
        TxtPassWord.PasswordChar = "*"c
        TxtPassWord.Size = New Size(335, 61)
        TxtPassWord.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(15, 242)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 64)
        Button1.TabIndex = 3
        Button1.Text = "Connexion"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(209, 242)
        Button2.Name = "Button2"
        Button2.Size = New Size(188, 64)
        Button2.TabIndex = 4
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(403, 242)
        Button3.Name = "Button3"
        Button3.Size = New Size(188, 64)
        Button3.TabIndex = 5
        Button3.Text = "Quitter"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(596, 318)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TxtPassWord)
        Controls.Add(TxtMat)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMat As TextBox
    Friend WithEvents TxtPassWord As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
