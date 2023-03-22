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
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EntrarReg = New System.Windows.Forms.Button()
        Me.contrasena = New System.Windows.Forms.Label()
        Me.nameUser = New System.Windows.Forms.Label()
        Me.txtContrasena1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContrasena2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(613, 372)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 36)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(620, 412)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(399, 22)
        Me.txtEmail.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(137, 219)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(409, 322)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'EntrarReg
        '
        Me.EntrarReg.Location = New System.Drawing.Point(764, 686)
        Me.EntrarReg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.contrasena.Location = New System.Drawing.Point(613, 489)
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
        Me.nameUser.Location = New System.Drawing.Point(613, 282)
        Me.nameUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameUser.Name = "nameUser"
        Me.nameUser.Size = New System.Drawing.Size(121, 38)
        Me.nameUser.TabIndex = 20
        Me.nameUser.Text = "Nombre"
        Me.nameUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtContrasena1
        '
        Me.txtContrasena1.Location = New System.Drawing.Point(620, 529)
        Me.txtContrasena1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContrasena1.Name = "txtContrasena1"
        Me.txtContrasena1.Size = New System.Drawing.Size(403, 22)
        Me.txtContrasena1.TabIndex = 19
        Me.txtContrasena1.UseSystemPasswordChar = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(620, 324)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(403, 22)
        Me.txtNombre.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(613, 569)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 36)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Confirmar contraseña"
        '
        'txtContrasena2
        '
        Me.txtContrasena2.Location = New System.Drawing.Point(620, 608)
        Me.txtContrasena2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContrasena2.Name = "txtContrasena2"
        Me.txtContrasena2.Size = New System.Drawing.Size(403, 22)
        Me.txtContrasena2.TabIndex = 27
        Me.txtContrasena2.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(613, 196)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(335, 38)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Documento de identidad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(620, 238)
        Me.txtDocumento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(403, 22)
        Me.txtDocumento.TabIndex = 29
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1307, 830)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtContrasena2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EntrarReg)
        Me.Controls.Add(Me.contrasena)
        Me.Controls.Add(Me.nameUser)
        Me.Controls.Add(Me.txtContrasena1)
        Me.Controls.Add(Me.txtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EntrarReg As Button
    Friend WithEvents contrasena As Label
    Friend WithEvents nameUser As Label
    Friend WithEvents txtContrasena1 As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContrasena2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDocumento As TextBox
End Class
