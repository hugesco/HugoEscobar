<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lista
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
        Me.btnsucur = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnempleado = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsucur
        '
        Me.btnsucur.Location = New System.Drawing.Point(36, 201)
        Me.btnsucur.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnsucur.Name = "btnsucur"
        Me.btnsucur.Size = New System.Drawing.Size(152, 175)
        Me.btnsucur.TabIndex = 0
        Me.btnsucur.Text = "Sucursales"
        Me.btnsucur.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(683, 151)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bowlby One SC", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(417, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Base de Datos"
        '
        'btnuser
        '
        Me.btnuser.Location = New System.Drawing.Point(257, 201)
        Me.btnuser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Size = New System.Drawing.Size(152, 175)
        Me.btnuser.TabIndex = 2
        Me.btnuser.Text = "Usuarios"
        Me.btnuser.UseVisualStyleBackColor = True
        '
        'btnempleado
        '
        Me.btnempleado.Location = New System.Drawing.Point(482, 201)
        Me.btnempleado.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnempleado.Name = "btnempleado"
        Me.btnempleado.Size = New System.Drawing.Size(152, 175)
        Me.btnempleado.TabIndex = 4
        Me.btnempleado.Text = "Empleados"
        Me.btnempleado.UseVisualStyleBackColor = True
        '
        'lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(674, 446)
        Me.Controls.Add(Me.btnempleado)
        Me.Controls.Add(Me.btnuser)
        Me.Controls.Add(Me.btnsucur)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Bowlby One SC", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "lista"
        Me.Text = "Listado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnsucur As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnuser As Button
    Friend WithEvents btnempleado As Button
End Class
