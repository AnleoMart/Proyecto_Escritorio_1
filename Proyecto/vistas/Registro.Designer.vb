﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.emailReg = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EntrarReg = New System.Windows.Forms.Button()
        Me.contrasena = New System.Windows.Forms.Label()
        Me.nameUser = New System.Windows.Forms.Label()
        Me.ContrasenaReg = New System.Windows.Forms.TextBox()
        Me.nombreReg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(790, 336)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 36)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Email"
        '
        'emailReg
        '
        Me.emailReg.Location = New System.Drawing.Point(798, 375)
        Me.emailReg.Margin = New System.Windows.Forms.Padding(4)
        Me.emailReg.Name = "emailReg"
        Me.emailReg.Size = New System.Drawing.Size(399, 22)
        Me.emailReg.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(255, 247)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 322)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'EntrarReg
        '
        Me.EntrarReg.Location = New System.Drawing.Point(936, 650)
        Me.EntrarReg.Margin = New System.Windows.Forms.Padding(4)
        Me.EntrarReg.Name = "EntrarReg"
        Me.EntrarReg.Size = New System.Drawing.Size(125, 28)
        Me.EntrarReg.TabIndex = 22
        Me.EntrarReg.Text = "Registrar"
        Me.EntrarReg.UseVisualStyleBackColor = True
        '
        'contrasena
        '
        Me.contrasena.AutoSize = True
        Me.contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contrasena.Location = New System.Drawing.Point(786, 454)
        Me.contrasena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.contrasena.Name = "contrasena"
        Me.contrasena.Size = New System.Drawing.Size(168, 36)
        Me.contrasena.TabIndex = 21
        Me.contrasena.Text = "Contraseña"
        '
        'nameUser
        '
        Me.nameUser.AutoSize = True
        Me.nameUser.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameUser.Location = New System.Drawing.Point(793, 247)
        Me.nameUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameUser.Name = "nameUser"
        Me.nameUser.Size = New System.Drawing.Size(121, 38)
        Me.nameUser.TabIndex = 20
        Me.nameUser.Text = "Nombre"
        Me.nameUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContrasenaReg
        '
        Me.ContrasenaReg.Location = New System.Drawing.Point(795, 493)
        Me.ContrasenaReg.Margin = New System.Windows.Forms.Padding(4)
        Me.ContrasenaReg.Name = "ContrasenaReg"
        Me.ContrasenaReg.Size = New System.Drawing.Size(403, 22)
        Me.ContrasenaReg.TabIndex = 19
        '
        'nombreReg
        '
        Me.nombreReg.Location = New System.Drawing.Point(801, 288)
        Me.nombreReg.Margin = New System.Windows.Forms.Padding(4)
        Me.nombreReg.Name = "nombreReg"
        Me.nombreReg.Size = New System.Drawing.Size(403, 22)
        Me.nombreReg.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(789, 533)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 36)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Confirmar contraseña"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(798, 572)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(403, 22)
        Me.TextBox1.TabIndex = 27
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1559, 932)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.emailReg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EntrarReg)
        Me.Controls.Add(Me.contrasena)
        Me.Controls.Add(Me.nameUser)
        Me.Controls.Add(Me.ContrasenaReg)
        Me.Controls.Add(Me.nombreReg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents emailReg As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EntrarReg As Button
    Friend WithEvents contrasena As Label
    Friend WithEvents nameUser As Label
    Friend WithEvents ContrasenaReg As TextBox
    Friend WithEvents nombreReg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class