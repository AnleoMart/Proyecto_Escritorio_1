<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearArticulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearArticulo))
        Me.btnEliminarArt = New System.Windows.Forms.Button()
        Me.btnGuardarArt = New System.Windows.Forms.Button()
        Me.picBoxAdjuntarArt = New System.Windows.Forms.PictureBox()
        Me.txtDescripArt = New System.Windows.Forms.TextBox()
        Me.LabDescripArt = New System.Windows.Forms.Label()
        Me.panelInfoArt = New System.Windows.Forms.Panel()
        Me.MCFechaVencimiento = New System.Windows.Forms.MonthCalendar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBProveedor = New System.Windows.Forms.ComboBox()
        Me.txtBodega = New System.Windows.Forms.TextBox()
        Me.LabArticuloArt = New System.Windows.Forms.Label()
        Me.txtCantidadArt = New System.Windows.Forms.TextBox()
        Me.txtCodigoArt = New System.Windows.Forms.TextBox()
        Me.txtNombreArt = New System.Windows.Forms.TextBox()
        Me.LabCantidadArt = New System.Windows.Forms.Label()
        Me.LabFechaVArt = New System.Windows.Forms.Label()
        Me.LabCodigoArt = New System.Windows.Forms.Label()
        Me.LabNombreArt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.picBoxAdjuntarArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInfoArt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEliminarArt
        '
        Me.btnEliminarArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarArt.Location = New System.Drawing.Point(682, 499)
        Me.btnEliminarArt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminarArt.Name = "btnEliminarArt"
        Me.btnEliminarArt.Size = New System.Drawing.Size(151, 30)
        Me.btnEliminarArt.TabIndex = 21
        Me.btnEliminarArt.Text = "cancelar"
        Me.btnEliminarArt.UseVisualStyleBackColor = True
        '
        'btnGuardarArt
        '
        Me.btnGuardarArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarArt.Location = New System.Drawing.Point(514, 499)
        Me.btnGuardarArt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarArt.Name = "btnGuardarArt"
        Me.btnGuardarArt.Size = New System.Drawing.Size(151, 30)
        Me.btnGuardarArt.TabIndex = 20
        Me.btnGuardarArt.Text = "Guardar "
        Me.btnGuardarArt.UseVisualStyleBackColor = True
        '
        'picBoxAdjuntarArt
        '
        Me.picBoxAdjuntarArt.BackColor = System.Drawing.Color.White
        Me.picBoxAdjuntarArt.Image = CType(resources.GetObject("picBoxAdjuntarArt.Image"), System.Drawing.Image)
        Me.picBoxAdjuntarArt.Location = New System.Drawing.Point(797, 360)
        Me.picBoxAdjuntarArt.Margin = New System.Windows.Forms.Padding(4)
        Me.picBoxAdjuntarArt.Name = "picBoxAdjuntarArt"
        Me.picBoxAdjuntarArt.Size = New System.Drawing.Size(36, 32)
        Me.picBoxAdjuntarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoxAdjuntarArt.TabIndex = 19
        Me.picBoxAdjuntarArt.TabStop = False
        '
        'txtDescripArt
        '
        Me.txtDescripArt.Location = New System.Drawing.Point(156, 351)
        Me.txtDescripArt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripArt.Multiline = True
        Me.txtDescripArt.Name = "txtDescripArt"
        Me.txtDescripArt.Size = New System.Drawing.Size(688, 114)
        Me.txtDescripArt.TabIndex = 18
        '
        'LabDescripArt
        '
        Me.LabDescripArt.AutoSize = True
        Me.LabDescripArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabDescripArt.Location = New System.Drawing.Point(130, 327)
        Me.LabDescripArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabDescripArt.Name = "LabDescripArt"
        Me.LabDescripArt.Size = New System.Drawing.Size(85, 20)
        Me.LabDescripArt.TabIndex = 17
        Me.LabDescripArt.Text = "Descripcion"
        '
        'panelInfoArt
        '
        Me.panelInfoArt.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.panelInfoArt.Controls.Add(Me.picBoxAdjuntarArt)
        Me.panelInfoArt.Controls.Add(Me.btnEliminarArt)
        Me.panelInfoArt.Controls.Add(Me.MCFechaVencimiento)
        Me.panelInfoArt.Controls.Add(Me.btnGuardarArt)
        Me.panelInfoArt.Controls.Add(Me.Label2)
        Me.panelInfoArt.Controls.Add(Me.CBProveedor)
        Me.panelInfoArt.Controls.Add(Me.txtDescripArt)
        Me.panelInfoArt.Controls.Add(Me.txtBodega)
        Me.panelInfoArt.Controls.Add(Me.LabDescripArt)
        Me.panelInfoArt.Controls.Add(Me.LabArticuloArt)
        Me.panelInfoArt.Controls.Add(Me.txtCantidadArt)
        Me.panelInfoArt.Controls.Add(Me.txtCodigoArt)
        Me.panelInfoArt.Controls.Add(Me.txtNombreArt)
        Me.panelInfoArt.Controls.Add(Me.LabCantidadArt)
        Me.panelInfoArt.Controls.Add(Me.LabFechaVArt)
        Me.panelInfoArt.Controls.Add(Me.LabCodigoArt)
        Me.panelInfoArt.Controls.Add(Me.LabNombreArt)
        Me.panelInfoArt.Location = New System.Drawing.Point(177, 167)
        Me.panelInfoArt.Margin = New System.Windows.Forms.Padding(4)
        Me.panelInfoArt.Name = "panelInfoArt"
        Me.panelInfoArt.Size = New System.Drawing.Size(945, 557)
        Me.panelInfoArt.TabIndex = 16
        '
        'MCFechaVencimiento
        '
        Me.MCFechaVencimiento.Location = New System.Drawing.Point(563, 84)
        Me.MCFechaVencimiento.Name = "MCFechaVencimiento"
        Me.MCFechaVencimiento.ShowToday = False
        Me.MCFechaVencimiento.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 271)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Proveedor"
        '
        'CBProveedor
        '
        Me.CBProveedor.FormattingEnabled = True
        Me.CBProveedor.Location = New System.Drawing.Point(203, 267)
        Me.CBProveedor.Name = "CBProveedor"
        Me.CBProveedor.Size = New System.Drawing.Size(259, 24)
        Me.CBProveedor.TabIndex = 10
        '
        'txtBodega
        '
        Me.txtBodega.Location = New System.Drawing.Point(203, 159)
        Me.txtBodega.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBodega.Name = "txtBodega"
        Me.txtBodega.Size = New System.Drawing.Size(259, 22)
        Me.txtBodega.TabIndex = 9
        '
        'LabArticuloArt
        '
        Me.LabArticuloArt.AutoSize = True
        Me.LabArticuloArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabArticuloArt.Location = New System.Drawing.Point(130, 163)
        Me.LabArticuloArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabArticuloArt.Name = "LabArticuloArt"
        Me.LabArticuloArt.Size = New System.Drawing.Size(58, 20)
        Me.LabArticuloArt.TabIndex = 8
        Me.LabArticuloArt.Text = "Bodega"
        '
        'txtCantidadArt
        '
        Me.txtCantidadArt.Location = New System.Drawing.Point(203, 216)
        Me.txtCantidadArt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadArt.Name = "txtCantidadArt"
        Me.txtCantidadArt.Size = New System.Drawing.Size(259, 22)
        Me.txtCantidadArt.TabIndex = 7
        '
        'txtCodigoArt
        '
        Me.txtCodigoArt.Location = New System.Drawing.Point(203, 102)
        Me.txtCodigoArt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoArt.Name = "txtCodigoArt"
        Me.txtCodigoArt.Size = New System.Drawing.Size(259, 22)
        Me.txtCodigoArt.TabIndex = 5
        '
        'txtNombreArt
        '
        Me.txtNombreArt.Location = New System.Drawing.Point(203, 41)
        Me.txtNombreArt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreArt.Name = "txtNombreArt"
        Me.txtNombreArt.Size = New System.Drawing.Size(259, 22)
        Me.txtNombreArt.TabIndex = 4
        '
        'LabCantidadArt
        '
        Me.LabCantidadArt.AutoSize = True
        Me.LabCantidadArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCantidadArt.Location = New System.Drawing.Point(127, 217)
        Me.LabCantidadArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabCantidadArt.Name = "LabCantidadArt"
        Me.LabCantidadArt.Size = New System.Drawing.Size(67, 20)
        Me.LabCantidadArt.TabIndex = 3
        Me.LabCantidadArt.Text = "Cantidad"
        '
        'LabFechaVArt
        '
        Me.LabFechaVArt.AutoSize = True
        Me.LabFechaVArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabFechaVArt.Location = New System.Drawing.Point(559, 64)
        Me.LabFechaVArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabFechaVArt.Name = "LabFechaVArt"
        Me.LabFechaVArt.Size = New System.Drawing.Size(132, 20)
        Me.LabFechaVArt.TabIndex = 2
        Me.LabFechaVArt.Text = "Fecha Vencimiento"
        '
        'LabCodigoArt
        '
        Me.LabCodigoArt.AutoSize = True
        Me.LabCodigoArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabCodigoArt.Location = New System.Drawing.Point(127, 102)
        Me.LabCodigoArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabCodigoArt.Name = "LabCodigoArt"
        Me.LabCodigoArt.Size = New System.Drawing.Size(54, 20)
        Me.LabCodigoArt.TabIndex = 1
        Me.LabCodigoArt.Text = "Codigo"
        '
        'LabNombreArt
        '
        Me.LabNombreArt.AutoSize = True
        Me.LabNombreArt.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNombreArt.Location = New System.Drawing.Point(127, 41)
        Me.LabNombreArt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNombreArt.Name = "LabNombreArt"
        Me.LabNombreArt.Size = New System.Drawing.Size(59, 20)
        Me.LabNombreArt.TabIndex = 0
        Me.LabNombreArt.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(542, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 32)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Crear Articulo"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(102, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1102, 706)
        Me.Panel2.TabIndex = 22
        '
        'CrearArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1306, 829)
        Me.Controls.Add(Me.panelInfoArt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CrearArticulo"
        Me.Text = "crearArticulo"
        CType(Me.picBoxAdjuntarArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInfoArt.ResumeLayout(False)
        Me.panelInfoArt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminarArt As Button
    Friend WithEvents btnGuardarArt As Button
    Friend WithEvents picBoxAdjuntarArt As PictureBox
    Friend WithEvents txtDescripArt As TextBox
    Friend WithEvents LabDescripArt As Label
    Friend WithEvents panelInfoArt As Panel
    Friend WithEvents txtBodega As TextBox
    Friend WithEvents LabArticuloArt As Label
    Friend WithEvents txtCantidadArt As TextBox
    Friend WithEvents txtCodigoArt As TextBox
    Friend WithEvents txtNombreArt As TextBox
    Friend WithEvents LabCantidadArt As Label
    Friend WithEvents LabFechaVArt As Label
    Friend WithEvents LabCodigoArt As Label
    Friend WithEvents LabNombreArt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBProveedor As ComboBox
    Friend WithEvents MCFechaVencimiento As MonthCalendar
    Friend WithEvents Panel2 As Panel
End Class
