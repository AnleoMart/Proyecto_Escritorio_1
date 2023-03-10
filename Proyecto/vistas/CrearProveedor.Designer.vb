<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearProveedor))
        Me.btnEliminarArt = New System.Windows.Forms.Button()
        Me.btnGuardarArt = New System.Windows.Forms.Button()
        Me.picBoxAdjuntarArt = New System.Windows.Forms.PictureBox()
        Me.tboxDescripArt = New System.Windows.Forms.TextBox()
        Me.LabDescripArt = New System.Windows.Forms.Label()
        Me.panelInfoArt = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tboxAreaArt = New System.Windows.Forms.TextBox()
        Me.LabArticuloArt = New System.Windows.Forms.Label()
        Me.tboxCantidadArt = New System.Windows.Forms.TextBox()
        Me.tboxFechaVArt = New System.Windows.Forms.TextBox()
        Me.tboxCodigoArt = New System.Windows.Forms.TextBox()
        Me.tboxNombreArt = New System.Windows.Forms.TextBox()
        Me.LabCantidadArt = New System.Windows.Forms.Label()
        Me.LabFechaVArt = New System.Windows.Forms.Label()
        Me.LabCodigoArt = New System.Windows.Forms.Label()
        Me.LabNombreArt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picBoxAdjuntarArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInfoArt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEliminarArt
        '
        Me.btnEliminarArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarArt.Location = New System.Drawing.Point(740, 561)
        Me.btnEliminarArt.Name = "btnEliminarArt"
        Me.btnEliminarArt.Size = New System.Drawing.Size(113, 24)
        Me.btnEliminarArt.TabIndex = 28
        Me.btnEliminarArt.Text = "Eliminar"
        Me.btnEliminarArt.UseVisualStyleBackColor = True
        '
        'btnGuardarArt
        '
        Me.btnGuardarArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarArt.Location = New System.Drawing.Point(740, 531)
        Me.btnGuardarArt.Name = "btnGuardarArt"
        Me.btnGuardarArt.Size = New System.Drawing.Size(113, 24)
        Me.btnGuardarArt.TabIndex = 27
        Me.btnGuardarArt.Text = "Guardar Campos"
        Me.btnGuardarArt.UseVisualStyleBackColor = True
        '
        'picBoxAdjuntarArt
        '
        Me.picBoxAdjuntarArt.BackColor = System.Drawing.Color.White
        Me.picBoxAdjuntarArt.Image = CType(resources.GetObject("picBoxAdjuntarArt.Image"), System.Drawing.Image)
        Me.picBoxAdjuntarArt.Location = New System.Drawing.Point(818, 485)
        Me.picBoxAdjuntarArt.Name = "picBoxAdjuntarArt"
        Me.picBoxAdjuntarArt.Size = New System.Drawing.Size(27, 26)
        Me.picBoxAdjuntarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxAdjuntarArt.TabIndex = 26
        Me.picBoxAdjuntarArt.TabStop = False
        '
        'tboxDescripArt
        '
        Me.tboxDescripArt.Location = New System.Drawing.Point(336, 425)
        Me.tboxDescripArt.Multiline = True
        Me.tboxDescripArt.Name = "tboxDescripArt"
        Me.tboxDescripArt.Size = New System.Drawing.Size(517, 93)
        Me.tboxDescripArt.TabIndex = 25
        '
        'LabDescripArt
        '
        Me.LabDescripArt.AutoSize = True
        Me.LabDescripArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDescripArt.Location = New System.Drawing.Point(294, 400)
        Me.LabDescripArt.Name = "LabDescripArt"
        Me.LabDescripArt.Size = New System.Drawing.Size(66, 16)
        Me.LabDescripArt.TabIndex = 24
        Me.LabDescripArt.Text = "Descripcion"
        '
        'panelInfoArt
        '
        Me.panelInfoArt.BackColor = System.Drawing.Color.White
        Me.panelInfoArt.Controls.Add(Me.TextBox1)
        Me.panelInfoArt.Controls.Add(Me.Label2)
        Me.panelInfoArt.Controls.Add(Me.tboxAreaArt)
        Me.panelInfoArt.Controls.Add(Me.LabArticuloArt)
        Me.panelInfoArt.Controls.Add(Me.tboxCantidadArt)
        Me.panelInfoArt.Controls.Add(Me.tboxFechaVArt)
        Me.panelInfoArt.Controls.Add(Me.tboxCodigoArt)
        Me.panelInfoArt.Controls.Add(Me.tboxNombreArt)
        Me.panelInfoArt.Controls.Add(Me.LabCantidadArt)
        Me.panelInfoArt.Controls.Add(Me.LabFechaVArt)
        Me.panelInfoArt.Controls.Add(Me.LabCodigoArt)
        Me.panelInfoArt.Controls.Add(Me.LabNombreArt)
        Me.panelInfoArt.Location = New System.Drawing.Point(284, 152)
        Me.panelInfoArt.Name = "panelInfoArt"
        Me.panelInfoArt.Size = New System.Drawing.Size(587, 234)
        Me.panelInfoArt.TabIndex = 23
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(376, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Categoria"
        '
        'tboxAreaArt
        '
        Me.tboxAreaArt.Location = New System.Drawing.Point(62, 136)
        Me.tboxAreaArt.Name = "tboxAreaArt"
        Me.tboxAreaArt.Size = New System.Drawing.Size(195, 20)
        Me.tboxAreaArt.TabIndex = 9
        '
        'LabArticuloArt
        '
        Me.LabArticuloArt.AutoSize = True
        Me.LabArticuloArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabArticuloArt.Location = New System.Drawing.Point(14, 139)
        Me.LabArticuloArt.Name = "LabArticuloArt"
        Me.LabArticuloArt.Size = New System.Drawing.Size(50, 16)
        Me.LabArticuloArt.TabIndex = 8
        Me.LabArticuloArt.Text = "teledono"
        '
        'tboxCantidadArt
        '
        Me.tboxCantidadArt.Location = New System.Drawing.Point(376, 89)
        Me.tboxCantidadArt.Name = "tboxCantidadArt"
        Me.tboxCantidadArt.Size = New System.Drawing.Size(195, 20)
        Me.tboxCantidadArt.TabIndex = 7
        '
        'tboxFechaVArt
        '
        Me.tboxFechaVArt.Location = New System.Drawing.Point(376, 38)
        Me.tboxFechaVArt.Name = "tboxFechaVArt"
        Me.tboxFechaVArt.Size = New System.Drawing.Size(195, 20)
        Me.tboxFechaVArt.TabIndex = 6
        '
        'tboxCodigoArt
        '
        Me.tboxCodigoArt.Location = New System.Drawing.Point(62, 89)
        Me.tboxCodigoArt.Name = "tboxCodigoArt"
        Me.tboxCodigoArt.Size = New System.Drawing.Size(195, 20)
        Me.tboxCodigoArt.TabIndex = 5
        '
        'tboxNombreArt
        '
        Me.tboxNombreArt.Location = New System.Drawing.Point(62, 40)
        Me.tboxNombreArt.Name = "tboxNombreArt"
        Me.tboxNombreArt.Size = New System.Drawing.Size(195, 20)
        Me.tboxNombreArt.TabIndex = 4
        '
        'LabCantidadArt
        '
        Me.LabCantidadArt.AutoSize = True
        Me.LabCantidadArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCantidadArt.Location = New System.Drawing.Point(314, 90)
        Me.LabCantidadArt.Name = "LabCantidadArt"
        Me.LabCantidadArt.Size = New System.Drawing.Size(41, 16)
        Me.LabCantidadArt.TabIndex = 3
        Me.LabCantidadArt.Text = "Ciudad"
        '
        'LabFechaVArt
        '
        Me.LabFechaVArt.AutoSize = True
        Me.LabFechaVArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabFechaVArt.Location = New System.Drawing.Point(333, 40)
        Me.LabFechaVArt.Name = "LabFechaVArt"
        Me.LabFechaVArt.Size = New System.Drawing.Size(23, 16)
        Me.LabFechaVArt.TabIndex = 2
        Me.LabFechaVArt.Text = "NIT"
        '
        'LabCodigoArt
        '
        Me.LabCodigoArt.AutoSize = True
        Me.LabCodigoArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCodigoArt.Location = New System.Drawing.Point(12, 87)
        Me.LabCodigoArt.Name = "LabCodigoArt"
        Me.LabCodigoArt.Size = New System.Drawing.Size(55, 16)
        Me.LabCodigoArt.TabIndex = 1
        Me.LabCodigoArt.Text = "Direccion"
        '
        'LabNombreArt
        '
        Me.LabNombreArt.AutoSize = True
        Me.LabNombreArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNombreArt.Location = New System.Drawing.Point(12, 40)
        Me.LabNombreArt.Name = "LabNombreArt"
        Me.LabNombreArt.Size = New System.Drawing.Size(46, 16)
        Me.LabNombreArt.TabIndex = 0
        Me.LabNombreArt.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(486, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Crear Proveedor"
        '
        'CrearProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1154, 695)
        Me.Controls.Add(Me.btnEliminarArt)
        Me.Controls.Add(Me.btnGuardarArt)
        Me.Controls.Add(Me.picBoxAdjuntarArt)
        Me.Controls.Add(Me.tboxDescripArt)
        Me.Controls.Add(Me.LabDescripArt)
        Me.Controls.Add(Me.panelInfoArt)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CrearProveedor"
        Me.Text = "CrearProveedor"
        CType(Me.picBoxAdjuntarArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInfoArt.ResumeLayout(False)
        Me.panelInfoArt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminarArt As Button
    Friend WithEvents btnGuardarArt As Button
    Friend WithEvents picBoxAdjuntarArt As PictureBox
    Friend WithEvents tboxDescripArt As TextBox
    Friend WithEvents LabDescripArt As Label
    Friend WithEvents panelInfoArt As Panel
    Friend WithEvents tboxAreaArt As TextBox
    Friend WithEvents LabArticuloArt As Label
    Friend WithEvents tboxCantidadArt As TextBox
    Friend WithEvents tboxFechaVArt As TextBox
    Friend WithEvents tboxCodigoArt As TextBox
    Friend WithEvents tboxNombreArt As TextBox
    Friend WithEvents LabCantidadArt As Label
    Friend WithEvents LabFechaVArt As Label
    Friend WithEvents LabCodigoArt As Label
    Friend WithEvents LabNombreArt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
