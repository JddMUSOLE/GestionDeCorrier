<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectOrientation
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
        Label1 = New Label()
        TxtRef = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        dataGridCourierOrg = New DataGridView()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CType(dataGridCourierOrg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Titillium Web", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(7, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(1965, 92)
        Label1.TabIndex = 1
        Label1.Text = "LISTE DES COURRIERS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TxtRef
        ' 
        TxtRef.Font = New Font("Titillium Web", 9.899999F)
        TxtRef.Location = New Point(577, 103)
        TxtRef.Name = "TxtRef"
        TxtRef.Size = New Size(335, 58)
        TxtRef.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Titillium Web", 9.899999F)
        Label2.Location = New Point(275, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(308, 61)
        Label2.TabIndex = 5
        Label2.Text = "Référence courrier :"
        Label2.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(918, 97)
        Button1.Name = "Button1"
        Button1.Size = New Size(188, 64)
        Button1.TabIndex = 7
        Button1.Text = "Afficher"
        Button1.UseVisualStyleBackColor = True
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
        dataGridCourierOrg.Location = New Point(7, 187)
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
        dataGridCourierOrg.Size = New Size(1969, 1750)
        dataGridCourierOrg.TabIndex = 21
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1112, 97)
        Button2.Name = "Button2"
        Button2.Size = New Size(188, 64)
        Button2.TabIndex = 7
        Button2.Text = "Annuler"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(1306, 97)
        Button3.Name = "Button3"
        Button3.Size = New Size(188, 64)
        Button3.TabIndex = 7
        Button3.Text = "Retour"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Titillium Web", 9.899999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(1497, 96)
        Button4.Name = "Button4"
        Button4.Size = New Size(188, 64)
        Button4.TabIndex = 7
        Button4.Text = "Quittez"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' FormSelectOrientation
        ' 
        AutoScaleDimensions = New SizeF(17F, 41F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(1973, 1942)
        Controls.Add(dataGridCourierOrg)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TxtRef)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormSelectOrientation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormSelectOrientation"
        CType(dataGridCourierOrg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRef As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents dataGridCourierOrg As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
