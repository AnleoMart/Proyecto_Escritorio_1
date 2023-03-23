<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verArticulos
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgConsultaArticulos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCrearArticulo = New System.Windows.Forms.Button()
        CType(Me.DgConsultaArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(528, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 32)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Buscar Articulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 32)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Articulos"
        '
        'DgConsultaArticulos
        '
        Me.DgConsultaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgConsultaArticulos.Location = New System.Drawing.Point(72, 81)
        Me.DgConsultaArticulos.Name = "DgConsultaArticulos"
        Me.DgConsultaArticulos.RowHeadersWidth = 51
        Me.DgConsultaArticulos.RowTemplate.Height = 24
        Me.DgConsultaArticulos.Size = New System.Drawing.Size(992, 488)
        Me.DgConsultaArticulos.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCrearArticulo)
        Me.Panel1.Controls.Add(Me.DgConsultaArticulos)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(73, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 636)
        Me.Panel1.TabIndex = 0
        '
        'btnCrearArticulo
        '
        Me.btnCrearArticulo.Location = New System.Drawing.Point(918, 28)
        Me.btnCrearArticulo.Name = "btnCrearArticulo"
        Me.btnCrearArticulo.Size = New System.Drawing.Size(146, 41)
        Me.btnCrearArticulo.TabIndex = 17
        Me.btnCrearArticulo.Text = "Nuevo Articulo"
        Me.btnCrearArticulo.UseVisualStyleBackColor = True
        '
        'verArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1306, 829)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "verArticulos"
        Me.Text = "Buscar Articulos"
        CType(Me.DgConsultaArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DgConsultaArticulos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCrearArticulo As Button
End Class
