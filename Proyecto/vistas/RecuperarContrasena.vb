Public Class RecuperarContrasena
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

        Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = "Inicio_sesion").SingleOrDefault()
        If fr Is Nothing Then

            Dim Inicio_sesion As New Inicio_sesion
            Inicio_sesion.MdiParent = Form1
            Inicio_sesion.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
            Inicio_sesion.Left = 0
            Inicio_sesion.Top = 0
            Inicio_sesion.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtCorreo_Click(sender As Object, e As EventArgs) Handles txtCorreo.Click
        txtCorreo.Text = ""
    End Sub

    Private Sub txtCorreo_LostFocus(sender As Object, e As EventArgs) Handles txtCorreo.LostFocus
        If txtCorreo.Text = "" Then
            txtCorreo.Text = "Ingresa tu correo "
        End If

    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged

    End Sub
End Class