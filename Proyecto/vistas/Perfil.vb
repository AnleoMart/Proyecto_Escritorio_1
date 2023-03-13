Public Class Perfil
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim EditarPerfil As New EditarPerfil
        EditarPerfil.MdiParent = Me
        'EditarPerfil.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        'EditarPerfil.Left = 0
        'EditarPerfil.Top = 0

        EditarPerfil.TopLevel = False 'Establece TopLevel a False para indicar que el formulario no es independiente
        EditarPerfil.FormBorderStyle = FormBorderStyle.None 'Establece BorderStyle a None para eliminar los bordes del formulario
        EditarPerfil.Dock = DockStyle.Fill 'Establece Dock a Fill para hacer que el formulario hijo ocupe todo el espacio disponible en el formulario padre
        'Form1.Controls.Add(EditarPerfil)
        EditarPerfil.Show()
    End Sub

    Private Sub usuarioPerfil_Click(sender As Object, e As EventArgs) Handles usuarioPerfil.Click

    End Sub
End Class