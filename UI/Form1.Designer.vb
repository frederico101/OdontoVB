<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lab_nome = New System.Windows.Forms.Label()
        Me.btn_click = New System.Windows.Forms.Button()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lab_nome
        '
        Me.lab_nome.AutoSize = True
        Me.lab_nome.Location = New System.Drawing.Point(64, 21)
        Me.lab_nome.Name = "lab_nome"
        Me.lab_nome.Size = New System.Drawing.Size(35, 13)
        Me.lab_nome.TabIndex = 0
        Me.lab_nome.Text = "Nome"
        '
        'btn_click
        '
        Me.btn_click.Location = New System.Drawing.Point(92, 63)
        Me.btn_click.Name = "btn_click"
        Me.btn_click.Size = New System.Drawing.Size(75, 23)
        Me.btn_click.TabIndex = 1
        Me.btn_click.Text = "Click"
        Me.btn_click.UseVisualStyleBackColor = True
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(67, 37)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(100, 20)
        Me.txt_nome.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_click)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.lab_nome)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lab_nome As Label
    Friend WithEvents btn_click As Button
    Friend WithEvents txt_nome As TextBox
End Class
