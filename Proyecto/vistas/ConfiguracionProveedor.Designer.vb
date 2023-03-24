<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguracionProveedor
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
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMsgNombre = New System.Windows.Forms.Label()
        Me.lblMsgDireccion = New System.Windows.Forms.Label()
        Me.lblMsgTelefono = New System.Windows.Forms.Label()
        Me.lblMsgCiudad = New System.Windows.Forms.Label()
        Me.lblMsgCategoria = New System.Windows.Forms.Label()
        Me.lblMsgDescripcion = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(517, 255)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(510, 22)
        Me.txtCategoria.TabIndex = 12
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(517, 209)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(510, 22)
        Me.txtCiudad.TabIndex = 11
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(517, 23)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.ReadOnly = True
        Me.txtNit.Size = New System.Drawing.Size(510, 22)
        Me.txtNit.TabIndex = 10
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(517, 162)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(510, 22)
        Me.txtTelefono.TabIndex = 9
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(517, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(510, 22)
        Me.txtNombre.TabIndex = 7
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(739, 500)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(309, 54)
        Me.btnEliminar.TabIndex = 15
        Me.btnEliminar.Text = "Eliminar proveedor"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(71, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 54)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(517, 115)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(510, 22)
        Me.txtDireccion.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Controls.Add(Me.lblMsgDescripcion)
        Me.Panel3.Controls.Add(Me.lblMsgCategoria)
        Me.Panel3.Controls.Add(Me.lblMsgCiudad)
        Me.Panel3.Controls.Add(Me.lblMsgTelefono)
        Me.Panel3.Controls.Add(Me.lblMsgDireccion)
        Me.Panel3.Controls.Add(Me.lblMsgNombre)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.txtDescripcion)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.txtCategoria)
        Me.Panel3.Controls.Add(Me.txtCiudad)
        Me.Panel3.Controls.Add(Me.txtNit)
        Me.Panel3.Controls.Add(Me.txtTelefono)
        Me.Panel3.Controls.Add(Me.txtDireccion)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(76, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1052, 469)
        Me.Panel3.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(71, 415)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(309, 33)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Volver"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(517, 304)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(510, 96)
        Me.txtDescripcion.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(24, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label9.Size = New System.Drawing.Size(453, 30)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Descripcion"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 3, 10, 0)
        Me.Label2.Size = New System.Drawing.Size(453, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(24, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label8.Size = New System.Drawing.Size(453, 30)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label4.Size = New System.Drawing.Size(453, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label7.Size = New System.Drawing.Size(453, 30)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Ciudad"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label5.Size = New System.Drawing.Size(453, 30)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "telefono"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label6.Size = New System.Drawing.Size(453, 30)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "NIT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 101)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 43)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Informacion"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnEliminar)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(65, 223)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1185, 579)
        Me.Panel2.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(287, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 0)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SlateGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 8, 5, 5)
        Me.Label1.Size = New System.Drawing.Size(237, 45)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Editar Proveedor"
        '
        'lblMsgNombre
        '
        Me.lblMsgNombre.AutoSize = True
        Me.lblMsgNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgNombre.Location = New System.Drawing.Point(542, 96)
        Me.lblMsgNombre.Name = "lblMsgNombre"
        Me.lblMsgNombre.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgNombre.TabIndex = 38
        Me.lblMsgNombre.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgNombre.Visible = False
        '
        'lblMsgDireccion
        '
        Me.lblMsgDireccion.AutoSize = True
        Me.lblMsgDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgDireccion.Location = New System.Drawing.Point(542, 140)
        Me.lblMsgDireccion.Name = "lblMsgDireccion"
        Me.lblMsgDireccion.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgDireccion.TabIndex = 39
        Me.lblMsgDireccion.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgDireccion.Visible = False
        '
        'lblMsgTelefono
        '
        Me.lblMsgTelefono.AutoSize = True
        Me.lblMsgTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgTelefono.Location = New System.Drawing.Point(542, 187)
        Me.lblMsgTelefono.Name = "lblMsgTelefono"
        Me.lblMsgTelefono.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgTelefono.TabIndex = 40
        Me.lblMsgTelefono.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgTelefono.Visible = False
        '
        'lblMsgCiudad
        '
        Me.lblMsgCiudad.AutoSize = True
        Me.lblMsgCiudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgCiudad.Location = New System.Drawing.Point(542, 234)
        Me.lblMsgCiudad.Name = "lblMsgCiudad"
        Me.lblMsgCiudad.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgCiudad.TabIndex = 41
        Me.lblMsgCiudad.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgCiudad.Visible = False
        '
        'lblMsgCategoria
        '
        Me.lblMsgCategoria.AutoSize = True
        Me.lblMsgCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgCategoria.Location = New System.Drawing.Point(542, 280)
        Me.lblMsgCategoria.Name = "lblMsgCategoria"
        Me.lblMsgCategoria.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgCategoria.TabIndex = 42
        Me.lblMsgCategoria.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgCategoria.Visible = False
        '
        'lblMsgDescripcion
        '
        Me.lblMsgDescripcion.AutoSize = True
        Me.lblMsgDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgDescripcion.Location = New System.Drawing.Point(542, 403)
        Me.lblMsgDescripcion.Name = "lblMsgDescripcion"
        Me.lblMsgDescripcion.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgDescripcion.TabIndex = 43
        Me.lblMsgDescripcion.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgDescripcion.Visible = False
        '
        'ConfiguracionProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1306, 829)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConfiguracionProveedor"
        Me.Text = "ConfiguracionProveedor"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNit As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents lblMsgDescripcion As Label
    Friend WithEvents lblMsgCategoria As Label
    Friend WithEvents lblMsgCiudad As Label
    Friend WithEvents lblMsgTelefono As Label
    Friend WithEvents lblMsgDireccion As Label
    Friend WithEvents lblMsgNombre As Label
End Class
