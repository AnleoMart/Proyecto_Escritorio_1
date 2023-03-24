<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModiProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModiProveedor))
        Me.btnGuardarProv = New System.Windows.Forms.Button()
        Me.picBoxAdjuntarArt = New System.Windows.Forms.PictureBox()
        Me.txtDescripProv = New System.Windows.Forms.TextBox()
        Me.LabDescripArt = New System.Windows.Forms.Label()
        Me.panelInfoArt = New System.Windows.Forms.Panel()
        Me.lblMsgDecripcion = New System.Windows.Forms.Label()
        Me.lblMsgCategoria = New System.Windows.Forms.Label()
        Me.lblMsgCiudad = New System.Windows.Forms.Label()
        Me.lblMsgNit = New System.Windows.Forms.Label()
        Me.lblMsgTelefono = New System.Windows.Forms.Label()
        Me.lblMsgDireccion = New System.Windows.Forms.Label()
        Me.lblMsgNombre = New System.Windows.Forms.Label()
        Me.txtCategProv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelProv = New System.Windows.Forms.TextBox()
        Me.LabArticuloArt = New System.Windows.Forms.Label()
        Me.txtCiudadProv = New System.Windows.Forms.TextBox()
        Me.txtNitProv = New System.Windows.Forms.TextBox()
        Me.txtDireccionProv = New System.Windows.Forms.TextBox()
        Me.txtNombreProv = New System.Windows.Forms.TextBox()
        Me.LabCantidadArt = New System.Windows.Forms.Label()
        Me.LabFechaVArt = New System.Windows.Forms.Label()
        Me.LabCodigoArt = New System.Windows.Forms.Label()
        Me.LabNombreArt = New System.Windows.Forms.Label()
        Me.crerProveedor = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.picBoxAdjuntarArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInfoArt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardarProv
        '
        Me.btnGuardarProv.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarProv.Location = New System.Drawing.Point(891, 635)
        Me.btnGuardarProv.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarProv.Name = "btnGuardarProv"
        Me.btnGuardarProv.Size = New System.Drawing.Size(151, 30)
        Me.btnGuardarProv.TabIndex = 27
        Me.btnGuardarProv.Text = "Guardar Campos"
        Me.btnGuardarProv.UseVisualStyleBackColor = True
        '
        'picBoxAdjuntarArt
        '
        Me.picBoxAdjuntarArt.BackColor = System.Drawing.Color.White
        Me.picBoxAdjuntarArt.Image = CType(resources.GetObject("picBoxAdjuntarArt.Image"), System.Drawing.Image)
        Me.picBoxAdjuntarArt.Location = New System.Drawing.Point(766, 338)
        Me.picBoxAdjuntarArt.Margin = New System.Windows.Forms.Padding(4)
        Me.picBoxAdjuntarArt.Name = "picBoxAdjuntarArt"
        Me.picBoxAdjuntarArt.Size = New System.Drawing.Size(36, 32)
        Me.picBoxAdjuntarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxAdjuntarArt.TabIndex = 26
        Me.picBoxAdjuntarArt.TabStop = False
        '
        'txtDescripProv
        '
        Me.txtDescripProv.Location = New System.Drawing.Point(114, 338)
        Me.txtDescripProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripProv.Multiline = True
        Me.txtDescripProv.Name = "txtDescripProv"
        Me.txtDescripProv.Size = New System.Drawing.Size(688, 114)
        Me.txtDescripProv.TabIndex = 7
        '
        'LabDescripArt
        '
        Me.LabDescripArt.AutoSize = True
        Me.LabDescripArt.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LabDescripArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDescripArt.Location = New System.Drawing.Point(296, 473)
        Me.LabDescripArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabDescripArt.Name = "LabDescripArt"
        Me.LabDescripArt.Size = New System.Drawing.Size(85, 20)
        Me.LabDescripArt.TabIndex = 24
        Me.LabDescripArt.Text = "Descripcion"
        '
        'panelInfoArt
        '
        Me.panelInfoArt.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.panelInfoArt.Controls.Add(Me.lblMsgDecripcion)
        Me.panelInfoArt.Controls.Add(Me.picBoxAdjuntarArt)
        Me.panelInfoArt.Controls.Add(Me.lblMsgCategoria)
        Me.panelInfoArt.Controls.Add(Me.txtDescripProv)
        Me.panelInfoArt.Controls.Add(Me.lblMsgCiudad)
        Me.panelInfoArt.Controls.Add(Me.lblMsgNit)
        Me.panelInfoArt.Controls.Add(Me.lblMsgTelefono)
        Me.panelInfoArt.Controls.Add(Me.lblMsgDireccion)
        Me.panelInfoArt.Controls.Add(Me.lblMsgNombre)
        Me.panelInfoArt.Controls.Add(Me.txtCategProv)
        Me.panelInfoArt.Controls.Add(Me.Label2)
        Me.panelInfoArt.Controls.Add(Me.txtTelProv)
        Me.panelInfoArt.Controls.Add(Me.LabArticuloArt)
        Me.panelInfoArt.Controls.Add(Me.txtCiudadProv)
        Me.panelInfoArt.Controls.Add(Me.txtNitProv)
        Me.panelInfoArt.Controls.Add(Me.txtDireccionProv)
        Me.panelInfoArt.Controls.Add(Me.txtNombreProv)
        Me.panelInfoArt.Controls.Add(Me.LabCantidadArt)
        Me.panelInfoArt.Controls.Add(Me.LabFechaVArt)
        Me.panelInfoArt.Controls.Add(Me.LabCodigoArt)
        Me.panelInfoArt.Controls.Add(Me.LabNombreArt)
        Me.panelInfoArt.Location = New System.Drawing.Point(227, 167)
        Me.panelInfoArt.Margin = New System.Windows.Forms.Padding(4)
        Me.panelInfoArt.Name = "panelInfoArt"
        Me.panelInfoArt.Size = New System.Drawing.Size(883, 521)
        Me.panelInfoArt.TabIndex = 23
        '
        'lblMsgDecripcion
        '
        Me.lblMsgDecripcion.AutoSize = True
        Me.lblMsgDecripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgDecripcion.Location = New System.Drawing.Point(253, 456)
        Me.lblMsgDecripcion.Name = "lblMsgDecripcion"
        Me.lblMsgDecripcion.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgDecripcion.TabIndex = 42
        Me.lblMsgDecripcion.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgDecripcion.Visible = False
        '
        'lblMsgCategoria
        '
        Me.lblMsgCategoria.AutoSize = True
        Me.lblMsgCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgCategoria.Location = New System.Drawing.Point(559, 193)
        Me.lblMsgCategoria.Name = "lblMsgCategoria"
        Me.lblMsgCategoria.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgCategoria.TabIndex = 41
        Me.lblMsgCategoria.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgCategoria.Visible = False
        '
        'lblMsgCiudad
        '
        Me.lblMsgCiudad.AutoSize = True
        Me.lblMsgCiudad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgCiudad.Location = New System.Drawing.Point(559, 136)
        Me.lblMsgCiudad.Name = "lblMsgCiudad"
        Me.lblMsgCiudad.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgCiudad.TabIndex = 40
        Me.lblMsgCiudad.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgCiudad.Visible = False
        '
        'lblMsgNit
        '
        Me.lblMsgNit.AutoSize = True
        Me.lblMsgNit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgNit.Location = New System.Drawing.Point(559, 75)
        Me.lblMsgNit.Name = "lblMsgNit"
        Me.lblMsgNit.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgNit.TabIndex = 39
        Me.lblMsgNit.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgNit.Visible = False
        '
        'lblMsgTelefono
        '
        Me.lblMsgTelefono.AutoSize = True
        Me.lblMsgTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgTelefono.Location = New System.Drawing.Point(140, 193)
        Me.lblMsgTelefono.Name = "lblMsgTelefono"
        Me.lblMsgTelefono.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgTelefono.TabIndex = 38
        Me.lblMsgTelefono.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgTelefono.Visible = False
        '
        'lblMsgDireccion
        '
        Me.lblMsgDireccion.AutoSize = True
        Me.lblMsgDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgDireccion.Location = New System.Drawing.Point(140, 136)
        Me.lblMsgDireccion.Name = "lblMsgDireccion"
        Me.lblMsgDireccion.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgDireccion.TabIndex = 37
        Me.lblMsgDireccion.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgDireccion.Visible = False
        '
        'lblMsgNombre
        '
        Me.lblMsgNombre.AutoSize = True
        Me.lblMsgNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgNombre.Location = New System.Drawing.Point(140, 75)
        Me.lblMsgNombre.Name = "lblMsgNombre"
        Me.lblMsgNombre.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgNombre.TabIndex = 36
        Me.lblMsgNombre.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgNombre.Visible = False
        '
        'txtCategProv
        '
        Me.txtCategProv.Location = New System.Drawing.Point(543, 167)
        Me.txtCategProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategProv.Name = "txtCategProv"
        Me.txtCategProv.Size = New System.Drawing.Size(259, 22)
        Me.txtCategProv.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(463, 168)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Categoria"
        '
        'txtTelProv
        '
        Me.txtTelProv.Location = New System.Drawing.Point(125, 167)
        Me.txtTelProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelProv.Name = "txtTelProv"
        Me.txtTelProv.Size = New System.Drawing.Size(259, 22)
        Me.txtTelProv.TabIndex = 3
        '
        'LabArticuloArt
        '
        Me.LabArticuloArt.AutoSize = True
        Me.LabArticuloArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabArticuloArt.Location = New System.Drawing.Point(58, 169)
        Me.LabArticuloArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabArticuloArt.Name = "LabArticuloArt"
        Me.LabArticuloArt.Size = New System.Drawing.Size(63, 20)
        Me.LabArticuloArt.TabIndex = 8
        Me.LabArticuloArt.Text = "telefono"
        '
        'txtCiudadProv
        '
        Me.txtCiudadProv.Location = New System.Drawing.Point(543, 110)
        Me.txtCiudadProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCiudadProv.Name = "txtCiudadProv"
        Me.txtCiudadProv.Size = New System.Drawing.Size(259, 22)
        Me.txtCiudadProv.TabIndex = 5
        '
        'txtNitProv
        '
        Me.txtNitProv.Location = New System.Drawing.Point(543, 47)
        Me.txtNitProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNitProv.Name = "txtNitProv"
        Me.txtNitProv.Size = New System.Drawing.Size(259, 22)
        Me.txtNitProv.TabIndex = 4
        '
        'txtDireccionProv
        '
        Me.txtDireccionProv.Location = New System.Drawing.Point(125, 110)
        Me.txtDireccionProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccionProv.Name = "txtDireccionProv"
        Me.txtDireccionProv.Size = New System.Drawing.Size(259, 22)
        Me.txtDireccionProv.TabIndex = 2
        '
        'txtNombreProv
        '
        Me.txtNombreProv.Location = New System.Drawing.Point(125, 49)
        Me.txtNombreProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreProv.Name = "txtNombreProv"
        Me.txtNombreProv.Size = New System.Drawing.Size(259, 22)
        Me.txtNombreProv.TabIndex = 1
        '
        'LabCantidadArt
        '
        Me.LabCantidadArt.AutoSize = True
        Me.LabCantidadArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCantidadArt.Location = New System.Drawing.Point(481, 112)
        Me.LabCantidadArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabCantidadArt.Name = "LabCantidadArt"
        Me.LabCantidadArt.Size = New System.Drawing.Size(54, 20)
        Me.LabCantidadArt.TabIndex = 3
        Me.LabCantidadArt.Text = "Ciudad"
        '
        'LabFechaVArt
        '
        Me.LabFechaVArt.AutoSize = True
        Me.LabFechaVArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabFechaVArt.Location = New System.Drawing.Point(504, 49)
        Me.LabFechaVArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabFechaVArt.Name = "LabFechaVArt"
        Me.LabFechaVArt.Size = New System.Drawing.Size(29, 20)
        Me.LabFechaVArt.TabIndex = 2
        Me.LabFechaVArt.Text = "NIT"
        '
        'LabCodigoArt
        '
        Me.LabCodigoArt.AutoSize = True
        Me.LabCodigoArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCodigoArt.Location = New System.Drawing.Point(51, 110)
        Me.LabCodigoArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabCodigoArt.Name = "LabCodigoArt"
        Me.LabCodigoArt.Size = New System.Drawing.Size(70, 20)
        Me.LabCodigoArt.TabIndex = 1
        Me.LabCodigoArt.Text = "Direccion"
        '
        'LabNombreArt
        '
        Me.LabNombreArt.AutoSize = True
        Me.LabNombreArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNombreArt.Location = New System.Drawing.Point(62, 48)
        Me.LabNombreArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNombreArt.Name = "LabNombreArt"
        Me.LabNombreArt.Size = New System.Drawing.Size(59, 20)
        Me.LabNombreArt.TabIndex = 0
        Me.LabNombreArt.Text = "Nombre"
        '
        'crerProveedor
        '
        Me.crerProveedor.AutoSize = True
        Me.crerProveedor.BackColor = System.Drawing.Color.White
        Me.crerProveedor.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crerProveedor.Location = New System.Drawing.Point(552, 114)
        Me.crerProveedor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.crerProveedor.Name = "crerProveedor"
        Me.crerProveedor.Size = New System.Drawing.Size(184, 32)
        Me.crerProveedor.TabIndex = 22
        Me.crerProveedor.Text = "Crear Proveedor"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(142, 70)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 683)
        Me.Panel1.TabIndex = 29
        '
        'ModiProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1307, 830)
        Me.Controls.Add(Me.btnGuardarProv)
        Me.Controls.Add(Me.LabDescripArt)
        Me.Controls.Add(Me.panelInfoArt)
        Me.Controls.Add(Me.crerProveedor)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ModiProveedor"
        Me.Text = "CrearProveedor"
        CType(Me.picBoxAdjuntarArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInfoArt.ResumeLayout(False)
        Me.panelInfoArt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardarProv As Button
    Friend WithEvents picBoxAdjuntarArt As PictureBox
    Friend WithEvents txtDescripProv As TextBox
    Friend WithEvents LabDescripArt As Label
    Friend WithEvents panelInfoArt As Panel
    Friend WithEvents txtTelProv As TextBox
    Friend WithEvents LabArticuloArt As Label
    Friend WithEvents txtCiudadProv As TextBox
    Friend WithEvents txtNitProv As TextBox
    Friend WithEvents txtDireccionProv As TextBox
    Friend WithEvents txtNombreProv As TextBox
    Friend WithEvents LabCantidadArt As Label
    Friend WithEvents LabFechaVArt As Label
    Friend WithEvents LabCodigoArt As Label
    Friend WithEvents LabNombreArt As Label
    Friend WithEvents crerProveedor As Label
    Friend WithEvents txtCategProv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMsgDecripcion As Label
    Friend WithEvents lblMsgCategoria As Label
    Friend WithEvents lblMsgCiudad As Label
    Friend WithEvents lblMsgNit As Label
    Friend WithEvents lblMsgTelefono As Label
    Friend WithEvents lblMsgDireccion As Label
    Friend WithEvents lblMsgNombre As Label
End Class
