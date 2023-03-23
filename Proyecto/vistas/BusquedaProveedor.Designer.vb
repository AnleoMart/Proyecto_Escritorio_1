<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaProveedor
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGDistribuidor = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCrearProveedor = New System.Windows.Forms.Button()
        Me.nit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DGDistribuidor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(512, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 32)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Buscar Distribuidor"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCrearProveedor)
        Me.Panel1.Controls.Add(Me.DGDistribuidor)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(68, 94)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1150, 669)
        Me.Panel1.TabIndex = 17
        '
        'DGDistribuidor
        '
        Me.DGDistribuidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDistribuidor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nit, Me.nombre, Me.direccion, Me.ciudad, Me.categoria, Me.telefono, Me.descripcion})
        Me.DGDistribuidor.Location = New System.Drawing.Point(88, 94)
        Me.DGDistribuidor.Name = "DGDistribuidor"
        Me.DGDistribuidor.RowHeadersWidth = 51
        Me.DGDistribuidor.RowTemplate.Height = 24
        Me.DGDistribuidor.Size = New System.Drawing.Size(992, 537)
        Me.DGDistribuidor.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 32)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Buscar"
        '
        'btnCrearProveedor
        '
        Me.btnCrearProveedor.Location = New System.Drawing.Point(934, 25)
        Me.btnCrearProveedor.Name = "btnCrearProveedor"
        Me.btnCrearProveedor.Size = New System.Drawing.Size(146, 41)
        Me.btnCrearProveedor.TabIndex = 24
        Me.btnCrearProveedor.Text = "Nuevo Ditribuidor"
        Me.btnCrearProveedor.UseVisualStyleBackColor = True
        '
        'nit
        '
        Me.nit.DataPropertyName = "nit"
        Me.nit.HeaderText = "nit"
        Me.nit.MinimumWidth = 6
        Me.nit.Name = "nit"
        Me.nit.Width = 125
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "nombre"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 125
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "direccion"
        Me.direccion.MinimumWidth = 6
        Me.direccion.Name = "direccion"
        Me.direccion.Width = 125
        '
        'ciudad
        '
        Me.ciudad.DataPropertyName = "ciudad"
        Me.ciudad.HeaderText = "ciudad"
        Me.ciudad.MinimumWidth = 6
        Me.ciudad.Name = "ciudad"
        Me.ciudad.Width = 125
        '
        'categoria
        '
        Me.categoria.DataPropertyName = "categoria"
        Me.categoria.HeaderText = "categoria"
        Me.categoria.MinimumWidth = 6
        Me.categoria.Name = "categoria"
        Me.categoria.Width = 125
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "telefono"
        Me.telefono.MinimumWidth = 6
        Me.telefono.Name = "telefono"
        Me.telefono.Width = 125
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.MinimumWidth = 6
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 125
        '
        'BusquedaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1306, 829)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BusquedaProveedor"
        Me.Text = "BusquedaProveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGDistribuidor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DGDistribuidor As DataGridView
    Friend WithEvents btnCrearProveedor As Button
    Friend WithEvents nit As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents ciudad As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
End Class
