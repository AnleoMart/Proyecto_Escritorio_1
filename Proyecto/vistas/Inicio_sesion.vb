Public Class Inicio_sesion
    Private Sub olvidoContraseña_Click(sender As Object, e As EventArgs) Handles olvidoContraseña.Click
        Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = "Registro").SingleOrDefault()
        If fr Is Nothing Then

            Dim RecuperarContrasena As New RecuperarContrasena
            RecuperarContrasena.MdiParent = Form1
            RecuperarContrasena.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
            RecuperarContrasena.Left = 0
            RecuperarContrasena.Top = 0
            RecuperarContrasena.Show()
            Me.Hide()
        End If


    End Sub
End Class