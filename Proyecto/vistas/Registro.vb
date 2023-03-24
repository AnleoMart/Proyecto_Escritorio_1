Imports System.ComponentModel

Public Class Registro
    Private validacion As New Validaciones
    Private nom, pass, doc, email As Boolean

    Private Sub EntrarReg_Click(sender As Object, e As EventArgs) Handles EntrarReg.Click
        'Dim pass As String = valContraseñas(txtContrasena1.Text, txtContrasena2.Text)

        If valContraseñas(txtContrasena1.Text, txtContrasena2.Text) Then
            If nom And pass And doc And email Then
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
                MsgBox("Todos los capos deben estar aceptados", vbCritical, "Registro Fallido")
            End If
        Else
            MsgBox("las contraseñas ingresadas son diferentes, por favor verifique", vbCritical, "Error")
        End If


    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.Text <> "" Then
            If validacion.rxNombre(txtNombre.Text) Then
                lblMsgNombre.ForeColor = Color.Green
                lblMsgNombre.Text = "aceptado"
                lblMsgNombre.Visible = True
                nom = True
            Else
                lblMsgNombre.ForeColor = Color.Red
                lblMsgNombre.Text = "letras de la 'a' a la 'z' minusculas o mayusculas, y espacios"
                lblMsgNombre.Visible = True
                nom = False
            End If
        Else
            lblMsgNombre.Visible = False
            nom = False
        End If

    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As CancelEventArgs) Handles txtEmail.Validating
        If txtEmail.Text <> "" Then
            If validacion.rxCorreo(txtEmail.Text) Then
                lblMsgCorreo.ForeColor = Color.Green
                lblMsgCorreo.Text = "aceptado"
                lblMsgCorreo.Visible = True
                email = True
            Else
                lblMsgCorreo.ForeColor = Color.Red
                lblMsgCorreo.Text = "Correo no aceptado, por fvor verificar"
                lblMsgCorreo.Visible = True
                email = False
            End If
        Else
            lblMsgCorreo.Visible = False
            email = False
        End If
    End Sub

    Private Sub txtDocumento_Validating(sender As Object, e As CancelEventArgs) Handles txtDocumento.Validating
        If txtDocumento.Text <> "" Then
            If validacion.rxDocumentoId(txtDocumento.Text) Then
                lblMsgDoc.ForeColor = Color.Green
                lblMsgDoc.Text = "aceptado"
                lblMsgDoc.Visible = True
                doc = True
            Else
                lblMsgDoc.ForeColor = Color.Red
                lblMsgDoc.Text = "numeros de al 1 al 9, maximo 15 caracteres"
                lblMsgDoc.Visible = True
                doc = False
            End If
        Else
            lblMsgDoc.Visible = False
            doc = False
        End If
    End Sub



    Private Sub txtContrasena1_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasena1.Validating
        If txtContrasena1.Text <> "" Then
            If validacion.rxContraseña(txtContrasena1.Text) Then
                lblMsgContraseña.ForeColor = Color.Green
                lblMsgContraseña.Text = "aceptado"
                lblMsgContraseña.Visible = True

            Else
                lblMsgContraseña.ForeColor = Color.Red
                lblMsgContraseña.Text = "max 20 caracteres sin espacios en blanco"
                lblMsgContraseña.Visible = True

            End If
        Else
            lblMsgContraseña.Visible = False
        End If
    End Sub

    Private Sub txtContrasena2_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasena2.Validating
        If txtContrasena2.Text <> "" Then
            If validacion.rxContraseña(txtContrasena2.Text) Then
                If txtContrasena2.Text <> txtContrasena1.Text Then
                    lblMsgcontraseña2.ForeColor = Color.Orange
                    lblMsgcontraseña2.Text = "las contraseñas no coinciden"
                    lblMsgcontraseña2.Visible = True
                Else
                    lblMsgcontraseña2.ForeColor = Color.Green
                    lblMsgcontraseña2.Text = "aceptado"
                    lblMsgcontraseña2.Visible = True

                End If
            Else
                lblMsgcontraseña2.ForeColor = Color.Red
                lblMsgcontraseña2.Text = "max 20 caracteres sin espacios en blanco"
                lblMsgcontraseña2.Visible = True
            End If
        Else
            lblMsgcontraseña2.Visible = False
        End If
    End Sub

    Public Function valContraseñas(contra1 As String, contra2 As String) As Boolean
        If (contra1 = contra2) And lblMsgcontraseña2.ForeColor = Color.Green And lblMsgContraseña.ForeColor = Color.Green Then
            pass = True
            Return True
        Else
            pass = False
            Return False
        End If
    End Function


End Class