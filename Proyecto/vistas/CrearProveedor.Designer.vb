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
        Me.picBoxAdjuntarArt.Location = New System.Drawing.Point(995, 578)
        Me.picBoxAdjuntarArt.Margin = New System.Windows.Forms.Padding(4)
        Me.picBoxAdjuntarArt.Name = "picBoxAdjuntarArt"
        Me.picBoxAdjuntarArt.Size = New System.Drawing.Size(36, 32)
        Me.picBoxAdjuntarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxAdjuntarArt.TabIndex = 26
        Me.picBoxAdjuntarArt.TabStop = False
        '
        'txtDescripProv
        '
        Me.txtDescripProv.Location = New System.Drawing.Point(352, 505)
        Me.txtDescripProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripProv.Multiline = True
        Me.txtDescripProv.Name = "txtDescripProv"
        Me.txtDescripProv.Size = New System.Drawing.Size(688, 114)
        Me.txtDescripProv.TabIndex = 25
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
        'txtCategProv
        '
        Me.txtCategProv.Location = New System.Drawing.Point(543, 167)
        Me.txtCategProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategProv.Name = "txtCategProv"
        Me.txtCategProv.Size = New System.Drawing.Size(259, 22)
        Me.txtCategProv.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(461, 167)
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
        Me.txtTelProv.TabIndex = 9
        '
        'LabArticuloArt
        '
        Me.LabArticuloArt.AutoSize = True
        Me.LabArticuloArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabArticuloArt.Location = New System.Drawing.Point(61, 171)
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
        Me.txtCiudadProv.TabIndex = 7
        '
        'txtNitProv
        '
        Me.txtNitProv.Location = New System.Drawing.Point(543, 47)
        Me.txtNitProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNitProv.Name = "txtNitProv"
        Me.txtNitProv.Size = New System.Drawing.Size(259, 22)
        Me.txtNitProv.TabIndex = 6
        '
        'txtDireccionProv
        '
        Me.txtDireccionProv.Location = New System.Drawing.Point(125, 110)
        Me.txtDireccionProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccionProv.Name = "txtDireccionProv"
        Me.txtDireccionProv.Size = New System.Drawing.Size(259, 22)
        Me.txtDireccionProv.TabIndex = 5
        '
        'txtNombreProv
        '
        Me.txtNombreProv.Location = New System.Drawing.Point(125, 49)
        Me.txtNombreProv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreProv.Name = "txtNombreProv"
        Me.txtNombreProv.Size = New System.Drawing.Size(259, 22)
        Me.txtNombreProv.TabIndex = 4
        '
        'LabCantidadArt
        '
        Me.LabCantidadArt.AutoSize = True
        Me.LabCantidadArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCantidadArt.Location = New System.Drawing.Point(461, 111)
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
        Me.LabFechaVArt.Location = New System.Drawing.Point(486, 49)
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
        Me.LabCodigoArt.Location = New System.Drawing.Point(58, 107)
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
        Me.LabNombreArt.Location = New System.Drawing.Point(58, 49)
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
        Me.Controls.Add(Me.picBoxAdjuntarArt)
        Me.Controls.Add(Me.txtDescripProv)
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
End Class
