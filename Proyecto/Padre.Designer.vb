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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.BarraPerfil = New System.Windows.Forms.Panel()
        Me.panelLateral.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelLateral
        '
        Me.panelLateral.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panelLateral.Controls.Add(Me.Button4)
        Me.panelLateral.Controls.Add(Me.Panel5)
        Me.panelLateral.Controls.Add(Me.Button3)
        Me.panelLateral.Controls.Add(Me.Panel4)
        Me.panelLateral.Controls.Add(Me.btnPerfil)
        Me.panelLateral.Controls.Add(Me.Panel2)
        Me.panelLateral.Controls.Add(Me.Logo)
        Me.panelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLateral.Location = New System.Drawing.Point(0, 35)
        Me.panelLateral.Name = "panelLateral"
        Me.panelLateral.Size = New System.Drawing.Size(199, 694)
        Me.panelLateral.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(10, 170)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(180, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Dashboard"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Turquoise
        Me.Panel5.Location = New System.Drawing.Point(4, 170)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 23)
        Me.Panel5.TabIndex = 6
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(10, 213)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Crear perfil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Turquoise
        Me.Panel4.Location = New System.Drawing.Point(4, 242)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 23)
        Me.Panel4.TabIndex = 4
        '
        'btnPerfil
        '
        Me.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPerfil.FlatAppearance.BorderSize = 0
        Me.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerfil.Location = New System.Drawing.Point(10, 242)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(180, 23)
        Me.btnPerfil.TabIndex = 1
        Me.btnPerfil.Text = "Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Turquoise
        Me.Panel2.Location = New System.Drawing.Point(4, 213)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 23)
        Me.Panel2.TabIndex = 2
        '
        'Logo
        '
        Me.Logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(10, 11)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(180, 140)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 0
        Me.Logo.TabStop = False
        '
        'BarraPerfil
        '
        Me.BarraPerfil.BackColor = System.Drawing.Color.Turquoise
        Me.BarraPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraPerfil.Location = New System.Drawing.Point(0, 0)
        Me.BarraPerfil.Name = "BarraPerfil"
        Me.BarraPerfil.Size = New System.Drawing.Size(1350, 35)
        Me.BarraPerfil.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.panelLateral)
        Me.Controls.Add(Me.BarraPerfil)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Inventarianding"
        Me.panelLateral.ResumeLayout(False)
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelLateral As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPerfil As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Logo As PictureBox
    Friend WithEvents BarraPerfil As Panel
End Class
