Imports System.ComponentModel

Public Class RecuperarContrasena
    Private validacion As New Validaciones
    Private email As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cntrlUsuario As New ControladorUsuario
        If email And txtCorreo.Text <> "" Then
            cntrlUsuario.recuperarContraseña(txtCorreo.Text)
        Else
            MsgBox("Debe ingresar un correo valido primero", vbCritical, "Error")
        End If

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

        Dim Inicio_sesion As New Inicio_sesion
        Inicio_sesion.MdiParent = Form1
        Inicio_sesion.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        Inicio_sesion.Left = 0
        Inicio_sesion.Top = 0
        Inicio_sesion.Show()
        Me.Hide()
    End Sub

    Private Sub txtCorreo_Click(sender As Object, e As EventArgs) Handles txtCorreo.Click
        txtCorreo.Text = ""
    End Sub

    Private Sub txtCorreo_LostFocus(sender As Object, e As EventArgs) Handles txtCorreo.LostFocus
        If txtCorreo.Text = "" Then
            txtCorreo.Text = "Ingresa tu correo "
        End If

    End Sub

    Private Sub txtCorreo_Validating(sender As Object, e As CancelEventArgs) Handles txtCorreo.Validating
        If txtCorreo.Text <> "" Then
            If validacion.rxCorreo(txtCorreo.Text) Then
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
End Class