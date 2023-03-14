<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarPerfil
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.calendar = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtContrasena2 = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(298, 153)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(99, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1102, 676)
        Me.Panel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(682, 597)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(309, 54)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Eliminar usuario"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Controls.Add(Me.txtCedula)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.calendar)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.txtTelefono)
        Me.Panel3.Controls.Add(Me.txtCorreo)
        Me.Panel3.Controls.Add(Me.txtContrasena2)
        Me.Panel3.Controls.Add(Me.txtContraseña)
        Me.Panel3.Controls.Add(Me.txtApellido)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(83, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(918, 554)
        Me.Panel3.TabIndex = 7
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(504, 44)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.ReadOnly = True
        Me.txtCedula.Size = New System.Drawing.Size(346, 22)
        Me.txtCedula.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(11, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(5, 3, 10, 0)
        Me.Label10.Size = New System.Drawing.Size(453, 30)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "N° Identificacion"
        '
        'calendar
        '
        Me.calendar.Location = New System.Drawing.Point(504, 333)
        Me.calendar.MaxDate = New Date(2023, 3, 10, 0, 0, 0, 0)
        Me.calendar.Name = "calendar"
        Me.calendar.ShowToday = False
        Me.calendar.ShowTodayCircle = False
        Me.calendar.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 54)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(504, 292)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(346, 22)
        Me.txtTelefono.TabIndex = 12
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(504, 252)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ReadOnly = True
        Me.txtCorreo.Size = New System.Drawing.Size(346, 22)
        Me.txtCorreo.TabIndex = 11
        '
        'txtContrasena2
        '
        Me.txtContrasena2.Location = New System.Drawing.Point(504, 211)
        Me.txtContrasena2.Name = "txtContrasena2"
        Me.txtContrasena2.Size = New System.Drawing.Size(346, 22)
        Me.txtContrasena2.TabIndex = 10
        Me.txtContrasena2.UseSystemPasswordChar = True
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(504, 172)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(346, 22)
        Me.txtContraseña.TabIndex = 9
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(504, 131)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(346, 22)
        Me.txtApellido.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(504, 88)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(346, 22)
        Me.txtNombre.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(11, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label9.Size = New System.Drawing.Size(453, 30)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Fecha de nacimiento"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 3, 10, 0)
        Me.Label2.Size = New System.Drawing.Size(453, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombres"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label8.Size = New System.Drawing.Size(453, 30)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(11, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label4.Size = New System.Drawing.Size(453, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Apellidos"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(11, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label7.Size = New System.Drawing.Size(453, 30)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Correo"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label5.Size = New System.Drawing.Size(453, 30)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Contraseña"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label6.Size = New System.Drawing.Size(453, 30)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Confirme su contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 43)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Informacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SlateGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 8, 5, 5)
        Me.Label1.Size = New System.Drawing.Size(172, 45)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Editar Perfil"
        '
        'EditarPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1306, 829)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditarPerfil"
        Me.Text = "Editar Perfil"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtContrasena2 As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents calendar As MonthCalendar
End Class
