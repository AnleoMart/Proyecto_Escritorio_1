<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigurarArticulo
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
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtBodega = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MCFechaVencimietto = New System.Windows.Forms.MonthCalendar()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMsgCodigo = New System.Windows.Forms.Label()
        Me.lblMsgNombre = New System.Windows.Forms.Label()
        Me.lblMsgBodega = New System.Windows.Forms.Label()
        Me.lblMsgCantidad = New System.Windows.Forms.Label()
        Me.lblMsgDecripcion = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(502, 154)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(420, 22)
        Me.txtcantidad.TabIndex = 12
        '
        'txtBodega
        '
        Me.txtBodega.Location = New System.Drawing.Point(502, 101)
        Me.txtBodega.Name = "txtBodega"
        Me.txtBodega.Size = New System.Drawing.Size(420, 22)
        Me.txtBodega.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(502, 55)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(420, 22)
        Me.txtNombre.TabIndex = 8
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(502, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(420, 22)
        Me.txtCodigo.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(687, 562)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(309, 54)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Eliminar articulo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(9, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label9.Size = New System.Drawing.Size(453, 30)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Descripcion"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Controls.Add(Me.lblMsgDecripcion)
        Me.Panel3.Controls.Add(Me.lblMsgCantidad)
        Me.Panel3.Controls.Add(Me.lblMsgBodega)
        Me.Panel3.Controls.Add(Me.lblMsgNombre)
        Me.Panel3.Controls.Add(Me.lblMsgCodigo)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.MCFechaVencimietto)
        Me.Panel3.Controls.Add(Me.txtDescripcion)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.txtcantidad)
        Me.Panel3.Controls.Add(Me.txtBodega)
        Me.Panel3.Controls.Add(Me.txtNombre)
        Me.Panel3.Controls.Add(Me.txtCodigo)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(74, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1029, 509)
        Me.Panel3.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(24, 452)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(309, 29)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Volver"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MCFechaVencimietto
        '
        Me.MCFechaVencimietto.Location = New System.Drawing.Point(565, 276)
        Me.MCFechaVencimietto.Name = "MCFechaVencimietto"
        Me.MCFechaVencimietto.ShowToday = False
        Me.MCFechaVencimietto.TabIndex = 19
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(14, 235)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(448, 129)
        Me.txtDescripcion.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 54)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 3, 10, 0)
        Me.Label2.Size = New System.Drawing.Size(453, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label8.Size = New System.Drawing.Size(453, 30)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label4.Size = New System.Drawing.Size(453, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(497, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label5.Size = New System.Drawing.Size(453, 30)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha de vencimiento"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(5, 3, 20, 0)
        Me.Label6.Size = New System.Drawing.Size(453, 30)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Bodega"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(56, 162)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1191, 640)
        Me.Panel2.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SlateGray
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 8, 5, 5)
        Me.Label1.Size = New System.Drawing.Size(202, 45)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Editar Articulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 43)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Informacion"
        '
        'lblMsgCodigo
        '
        Me.lblMsgCodigo.AutoSize = True
        Me.lblMsgCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgCodigo.Location = New System.Drawing.Point(526, 36)
        Me.lblMsgCodigo.Name = "lblMsgCodigo"
        Me.lblMsgCodigo.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgCodigo.TabIndex = 36
        Me.lblMsgCodigo.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgCodigo.Visible = False
        '
        'lblMsgNombre
        '
        Me.lblMsgNombre.AutoSize = True
        Me.lblMsgNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgNombre.Location = New System.Drawing.Point(526, 82)
        Me.lblMsgNombre.Name = "lblMsgNombre"
        Me.lblMsgNombre.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgNombre.TabIndex = 37
        Me.lblMsgNombre.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgNombre.Visible = False
        '
        'lblMsgBodega
        '
        Me.lblMsgBodega.AutoSize = True
        Me.lblMsgBodega.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgBodega.Location = New System.Drawing.Point(526, 126)
        Me.lblMsgBodega.Name = "lblMsgBodega"
        Me.lblMsgBodega.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgBodega.TabIndex = 38
        Me.lblMsgBodega.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgBodega.Visible = False
        '
        'lblMsgCantidad
        '
        Me.lblMsgCantidad.AutoSize = True
        Me.lblMsgCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgCantidad.Location = New System.Drawing.Point(526, 179)
        Me.lblMsgCantidad.Name = "lblMsgCantidad"
        Me.lblMsgCantidad.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgCantidad.TabIndex = 39
        Me.lblMsgCantidad.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgCantidad.Visible = False
        '
        'lblMsgDecripcion
        '
        Me.lblMsgDecripcion.AutoSize = True
        Me.lblMsgDecripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMsgDecripcion.Location = New System.Drawing.Point(21, 367)
        Me.lblMsgDecripcion.Name = "lblMsgDecripcion"
        Me.lblMsgDecripcion.Size = New System.Drawing.Size(369, 16)
        Me.lblMsgDecripcion.TabIndex = 40
        Me.lblMsgDecripcion.Text = " letras de la ""a"" a la ""z"" minusculas o mayusculas, y espacios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMsgDecripcion.Visible = False
        '
        'ConfigurarArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1306, 829)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConfigurarArticulo"
        Me.Text = "ConfigurarArticulo"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtBodega As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents MCFechaVencimietto As MonthCalendar
    Friend WithEvents Button3 As Button
    Friend WithEvents lblMsgCantidad As Label
    Friend WithEvents lblMsgBodega As Label
    Friend WithEvents lblMsgNombre As Label
    Friend WithEvents lblMsgCodigo As Label
    Friend WithEvents lblMsgDecripcion As Label
End Class
