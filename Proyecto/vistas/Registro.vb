Public Class Registro
    Private Sub olvidoContraseña_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub contrasena_Click(sender As Object, e As EventArgs) Handles contrasena.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub EntrarReg_Click(sender As Object, e As EventArgs) Handles EntrarReg.Click
        Dim pass As String = valContraseñas(txtContrasena1.Text, txtContrasena2.Text)
        Dim contrlUsuario As New ControladorUsuario()
        If contrlUsuario.crearUsuario(txtDocumento.Text, txtNombre.Text, txtEmail.Text, pass) Then
            MsgBox("Su usuario se ha creado satisfactoriamente", vbInformation, "Registro Exitoso")

        Else
            MsgBox("No se ha podido crear su usuario", vbCritical, "Registro Fallido")
        End If

    End Sub
    Public Function valContraseñas(contra1 As String, contra2 As String) As Boolean
        If contra1 = contra2 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class