<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panelLateral = New System.Windows.Forms.Panel()
        Me.PanelIs = New System.Windows.Forms.Panel()
        Me.btnInicioSesion = New System.Windows.Forms.Button()
        Me.PanelCP = New System.Windows.Forms.Panel()
        Me.BtnCrearPerfil = New System.Windows.Forms.Button()
        Me.PanelCS = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.BarraPerfil = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.panelLateral.SuspendLayout()
        Me.PanelCS.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraPerfil.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelLateral
        '
        Me.panelLateral.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panelLateral.Controls.Add(Me.Panel1)
        Me.panelLateral.Controls.Add(Me.btnCrearUsuario)
        Me.panelLateral.Controls.Add(Me.PanelIs)
        Me.panelLateral.Controls.Add(Me.btnInicioSesion)
        Me.panelLateral.Controls.Add(Me.PanelCP)
        Me.panelLateral.Controls.Add(Me.BtnCrearPerfil)
        Me.panelLateral.Controls.Add(Me.PanelCS)
        Me.panelLateral.Controls.Add(Me.btnCerrarSesion)
        Me.panelLateral.Controls.Add(Me.Panel4)
        Me.panelLateral.Controls.Add(Me.btnPerfil)
        Me.panelLateral.Controls.Add(Me.Logo)
        Me.panelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLateral.Location = New System.Drawing.Point(0, 43)
        Me.panelLateral.Margin = New System.Windows.Forms.Padding(4)
        Me.panelLateral.Name = "panelLateral"
        Me.panelLateral.Size = New System.Drawing.Size(265, 910)
        Me.panelLateral.TabIndex = 7
        '
        'PanelIs
        '
        Me.PanelIs.BackColor = System.Drawing.Color.Turquoise
        Me.PanelIs.Location = New System.Drawing.Point(5, 730)
        Me.PanelIs.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelIs.Name = "PanelIs"
        Me.PanelIs.Size = New System.Drawing.Size(7, 28)
        Me.PanelIs.TabIndex = 12
        '
        'btnInicioSesion
        '
        Me.btnInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInicioSesion.FlatAppearance.BorderSize = 0
        Me.btnInicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicioSesion.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicioSesion.ForeColor = System.Drawing.Color.White
        Me.btnInicioSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicioSesion.Location = New System.Drawing.Point(13, 730)
        Me.btnInicioSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInicioSesion.Name = "btnInicioSesion"
        Me.btnInicioSesion.Size = New System.Drawing.Size(240, 28)
        Me.btnInicioSesion.TabIndex = 11
        Me.btnInicioSesion.Text = "Iniciar Sesion"
        Me.btnInicioSesion.UseVisualStyleBackColor = False
        Me.btnInicioSesion.Visible = False
        '
        'PanelCP
        '
        Me.PanelCP.BackColor = System.Drawing.Color.Turquoise
        Me.PanelCP.Location = New System.Drawing.Point(5, 766)
        Me.PanelCP.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCP.Name = "PanelCP"
        Me.PanelCP.Size = New System.Drawing.Size(7, 28)
        Me.PanelCP.TabIndex = 10
        '
        'BtnCrearPerfil
        '
        Me.BtnCrearPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCrearPerfil.FlatAppearance.BorderSize = 0
        Me.BtnCrearPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCrearPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearPerfil.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCrearPerfil.ForeColor = System.Drawing.Color.White
        Me.BtnCrearPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCrearPerfil.Location = New System.Drawing.Point(13, 766)
        Me.BtnCrearPerfil.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCrearPerfil.Name = "BtnCrearPerfil"
        Me.BtnCrearPerfil.Size = New System.Drawing.Size(240, 28)
        Me.BtnCrearPerfil.TabIndex = 9
        Me.BtnCrearPerfil.Text = "Crear perfil"
        Me.BtnCrearPerfil.UseVisualStyleBackColor = False
        '
        'PanelCS
        '
        Me.PanelCS.BackColor = System.Drawing.Color.Turquoise
        Me.PanelCS.Controls.Add(Me.Panel3)
        Me.PanelCS.Location = New System.Drawing.Point(5, 802)
        Me.PanelCS.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelCS.Name = "PanelCS"
        Me.PanelCS.Size = New System.Drawing.Size(7, 28)
        Me.PanelCS.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Turquoise
        Me.Panel3.Location = New System.Drawing.Point(-121, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(7, 28)
        Me.Panel3.TabIndex = 10
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.FlatAppearance.BorderSize = 0
        Me.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarSesion.Location = New System.Drawing.Point(13, 802)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(240, 28)
        Me.btnCerrarSesion.TabIndex = 7
        Me.btnCerrarSesion.Text = "Cerrar sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Turquoise
        Me.Panel4.Location = New System.Drawing.Point(5, 245)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(7, 28)
        Me.Panel4.TabIndex = 4
        '
        'btnPerfil
        '
        Me.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPerfil.FlatAppearance.BorderSize = 0
        Me.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerfil.ForeColor = System.Drawing.Color.White
        Me.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerfil.Location = New System.Drawing.Point(13, 245)
        Me.btnPerfil.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(240, 28)
        Me.btnPerfil.TabIndex = 1
        Me.btnPerfil.Text = "Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'Logo
        '
        Me.Logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(13, 41)
        Me.Logo.Margin = New System.Windows.Forms.Padding(4)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(240, 172)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'BarraPerfil
        '
        Me.BarraPerfil.BackColor = System.Drawing.Color.Turquoise
        Me.BarraPerfil.Controls.Add(Me.Panel7)
        Me.BarraPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraPerfil.Location = New System.Drawing.Point(0, 0)
        Me.BarraPerfil.Margin = New System.Windows.Forms.Padding(4)
        Me.BarraPerfil.Name = "BarraPerfil"
        Me.BarraPerfil.Size = New System.Drawing.Size(1581, 43)
        Me.BarraPerfil.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Location = New System.Drawing.Point(272, 43)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 100)
        Me.Panel7.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Location = New System.Drawing.Point(5, 281)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(7, 28)
        Me.Panel1.TabIndex = 14
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearUsuario.FlatAppearance.BorderSize = 0
        Me.btnCrearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearUsuario.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearUsuario.ForeColor = System.Drawing.Color.White
        Me.btnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrearUsuario.Location = New System.Drawing.Point(13, 281)
        Me.btnCrearUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(240, 28)
        Me.btnCrearUsuario.TabIndex = 13
        Me.btnCrearUsuario.Text = "Crear usuario"
        Me.btnCrearUsuario.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1581, 953)
        Me.Controls.Add(Me.panelLateral)
        Me.Controls.Add(Me.BarraPerfil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Inventarianding"
        Me.panelLateral.ResumeLayout(False)
        Me.PanelCS.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraPerfil.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelLateral As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPerfil As Button
    Friend WithEvents Logo As PictureBox
    Friend WithEvents BarraPerfil As Panel
    Friend WithEvents PanelCP As Panel
    Friend WithEvents BtnCrearPerfil As Button
    Friend WithEvents PanelCS As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PanelIs As Panel
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCrearUsuario As Button
End Class
