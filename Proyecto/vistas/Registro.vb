Public Class Registro


    Private Sub EntrarReg_Click(sender As Object, e As EventArgs) Handles EntrarReg.Click
        'Dim pass As String = valContraseñas(txtContrasena1.Text, txtContrasena2.Text)
        If valContraseñas(txtContrasena1.Text, txtContrasena2.Text) Then
            Dim contrlUsuario As New ControladorUsuario()
            If contrlUsuario.crearUsuario(txtDocumento.Text, txtNombre.Text, txtEmail.Text, txtContrasena1.Text) Then
                MsgBox("Su usuario se ha creado satisfactoriamente", vbInformation, "Registro Exitoso")
                If Form1.idUuario = 0 Then
                    Dim Inicio_sesion As New Inicio_sesion
                    Inicio_sesion.MdiParent = Form1
                    Inicio_sesion.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
                    Inicio_sesion.Left = 0
                    Inicio_sesion.Top = 0
                    Inicio_sesion.Show()
                    Me.Hide()
                Else
                    Dim BuscarUsuarios As New BuscarUsuarios
                    BuscarUsuarios.MdiParent = Form1
                    BuscarUsuarios.StartPosition = FormStartPosition.Manual
                    BuscarUsuarios.Left = 0
                    BuscarUsuarios.Top = 0
                    BuscarUsuarios.Show()
                    Me.Hide()
                End If

            Else
                MsgBox("No se ha podido crear su usuario", vbCritical, "Registro Fallido")
            End If
        Else
            MsgBox("las contraseñas ingresadas son diferentes, por favor verifique", vbCritical, "Error")
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