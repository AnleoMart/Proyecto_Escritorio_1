<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.olvidoContraseña = New System.Windows.Forms.Label()
        Me.EntrarReg = New System.Windows.Forms.Button()
        Me.contrasena = New System.Windows.Forms.Label()
        Me.nameUser = New System.Windows.Forms.Label()
        Me.ContrasenaReg = New System.Windows.Forms.TextBox()
        Me.nombreReg = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(594, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 29)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Email"
        '
        'emailReg
        '
        Me.emailReg.Location = New System.Drawing.Point(600, 387)
        Me.emailReg.Name = "emailReg"
        Me.emailReg.Size = New System.Drawing.Size(300, 20)
        Me.emailReg.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(191, 201)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'olvidoContraseña
        '
        Me.olvidoContraseña.AutoSize = True
        Me.olvidoContraseña.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvidoContraseña.Location = New System.Drawing.Point(769, 410)
        Me.olvidoContraseña.Name = "olvidoContraseña"
        Me.olvidoContraseña.Size = New System.Drawing.Size(131, 18)
        Me.olvidoContraseña.TabIndex = 23
        Me.olvidoContraseña.Text = "Olvide la contraseña"
        '
        'EntrarReg
        '
        Me.EntrarReg.Location = New System.Drawing.Point(696, 447)
        Me.EntrarReg.Name = "EntrarReg"
        Me.EntrarReg.Size = New System.Drawing.Size(94, 23)
        Me.EntrarReg.TabIndex = 22
        Me.EntrarReg.Text = "Entrar"
        Me.EntrarReg.UseVisualStyleBackColor = True
        '
        'contrasena
        '
        Me.contrasena.AutoSize = True
        Me.contrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contrasena.Location = New System.Drawing.Point(594, 280)
        Me.contrasena.Name = "contrasena"
        Me.contrasena.Size = New System.Drawing.Size(136, 29)
        Me.contrasena.TabIndex = 21
        Me.contrasena.Text = "Contraseña"
        '
        'nameUser
        '
        Me.nameUser.AutoSize = True
        Me.nameUser.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameUser.Location = New System.Drawing.Point(595, 201)
        Me.nameUser.Name = "nameUser"
        Me.nameUser.Size = New System.Drawing.Size(96, 30)
        Me.nameUser.TabIndex = 20
        Me.nameUser.Text = "Nombre"
        Me.nameUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContrasenaReg
        '
        Me.ContrasenaReg.Location = New System.Drawing.Point(601, 312)
        Me.ContrasenaReg.Name = "ContrasenaReg"
        Me.ContrasenaReg.Size = New System.Drawing.Size(303, 20)
        Me.ContrasenaReg.TabIndex = 19
        '
        'nombreReg
        '
        Me.nombreReg.Location = New System.Drawing.Point(601, 234)
        Me.nombreReg.Name = "nombreReg"
        Me.nombreReg.Size = New System.Drawing.Size(303, 20)
        Me.nombreReg.TabIndex = 18
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1167, 733)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.emailReg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.olvidoContraseña)
        Me.Controls.Add(Me.EntrarReg)
        Me.Controls.Add(Me.contrasena)
        Me.Controls.Add(Me.nameUser)
        Me.Controls.Add(Me.ContrasenaReg)
        Me.Controls.Add(Me.nombreReg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents emailReg As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents olvidoContraseña As Label
    Friend WithEvents EntrarReg As Button
    Friend WithEvents contrasena As Label
    Friend WithEvents nameUser As Label
    Friend WithEvents ContrasenaReg As TextBox
    Friend WithEvents nombreReg As TextBox
End Class
