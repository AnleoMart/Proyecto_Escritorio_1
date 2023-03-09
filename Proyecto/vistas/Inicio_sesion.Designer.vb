<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio_sesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio_sesion))
        Me.olvidoContraseña = New System.Windows.Forms.Label()
        Me.EntrarReg = New System.Windows.Forms.Button()
        Me.txtContrasenaInSes = New System.Windows.Forms.Label()
        Me.txtNameUserInSes = New System.Windows.Forms.Label()
        Me.ContrasenaInSes = New System.Windows.Forms.TextBox()
        Me.nombreInSes = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'olvidoContraseña
        '
        Me.olvidoContraseña.AutoSize = True
        Me.olvidoContraseña.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvidoContraseña.Location = New System.Drawing.Point(733, 387)
        Me.olvidoContraseña.Name = "olvidoContraseña"
        Me.olvidoContraseña.Size = New System.Drawing.Size(131, 18)
        Me.olvidoContraseña.TabIndex = 27
        Me.olvidoContraseña.Text = "Olvide la contraseña"
        '
        'EntrarReg
        '
        Me.EntrarReg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EntrarReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.EntrarReg.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntrarReg.Location = New System.Drawing.Point(658, 464)
        Me.EntrarReg.Name = "EntrarReg"
        Me.EntrarReg.Size = New System.Drawing.Size(114, 40)
        Me.EntrarReg.TabIndex = 26
        Me.EntrarReg.Text = "Entrar"
        Me.EntrarReg.UseVisualStyleBackColor = True
        '
        'txtContrasenaInSes
        '
        Me.txtContrasenaInSes.AutoSize = True
        Me.txtContrasenaInSes.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenaInSes.Location = New System.Drawing.Point(555, 322)
        Me.txtContrasenaInSes.Name = "txtContrasenaInSes"
        Me.txtContrasenaInSes.Size = New System.Drawing.Size(142, 30)
        Me.txtContrasenaInSes.TabIndex = 25
        Me.txtContrasenaInSes.Text = "Contraseña"
        '
        'txtNameUserInSes
        '
        Me.txtNameUserInSes.AutoSize = True
        Me.txtNameUserInSes.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameUserInSes.Location = New System.Drawing.Point(555, 213)
        Me.txtNameUserInSes.Name = "txtNameUserInSes"
        Me.txtNameUserInSes.Size = New System.Drawing.Size(102, 30)
        Me.txtNameUserInSes.TabIndex = 24
        Me.txtNameUserInSes.Text = "Nombre"
        Me.txtNameUserInSes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContrasenaInSes
        '
        Me.ContrasenaInSes.Location = New System.Drawing.Point(561, 364)
        Me.ContrasenaInSes.Name = "ContrasenaInSes"
        Me.ContrasenaInSes.Size = New System.Drawing.Size(310, 20)
        Me.ContrasenaInSes.TabIndex = 23
        '
        'nombreInSes
        '
        Me.nombreInSes.Location = New System.Drawing.Point(561, 247)
        Me.nombreInSes.Name = "nombreInSes"
        Me.nombreInSes.Size = New System.Drawing.Size(310, 20)
        Me.nombreInSes.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(155, 214)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'Inicio_sesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1132, 682)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.olvidoContraseña)
        Me.Controls.Add(Me.EntrarReg)
        Me.Controls.Add(Me.txtContrasenaInSes)
        Me.Controls.Add(Me.txtNameUserInSes)
        Me.Controls.Add(Me.ContrasenaInSes)
        Me.Controls.Add(Me.nombreInSes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inicio_sesion"
        Me.Text = "Inicio_sesion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents olvidoContraseña As Label
    Friend WithEvents EntrarReg As Button
    Friend WithEvents txtContrasenaInSes As Label
    Friend WithEvents txtNameUserInSes As Label
    Friend WithEvents ContrasenaInSes As TextBox
    Friend WithEvents nombreInSes As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
