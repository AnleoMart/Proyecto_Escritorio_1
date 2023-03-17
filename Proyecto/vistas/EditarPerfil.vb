Public Class EditarPerfil
    Private controllerUser As New ControladorUsuario
    Private usu As Usuario
    Private id As String
    Public Sub New(id As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.id = id
    End Sub
    Private Sub EditarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calendar.MaxDate = DateTime.Now
        'Dim contUsuario As New ControladorUsuario
        usu = controllerUser.cargarDatos(id)
        Console.WriteLine(usu.Id.ToString())
        txtCedula.Text = usu.Id.ToString()
        txtNombre.Text = usu.Nombre
        txtApellido.Text = usu.Apellido
        txtCorreo.Text = usu.Correo
        txtTelefono.Text = usu.Telefono
        calendar.SelectionStart = usu.FechaNacimiento
        calendar.SetSelectionRange(calendar.SelectionStart, calendar.SelectionStart)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If valCampos() Then
            If txtContraseña.Text = txtContraseña.Text Then
                If (controllerUser.modificarUsuario(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text, txtContraseña.Text, calendar.SelectionStart)) Then
                    MsgBox("Se han modificado los valores exitosamente", vbInformation, "modificacion exitosa")
                Else
                    MsgBox("Ha ocurrido un error, no se ha podido completar la modificacion", vbCritical, "Error")
                End If
            End If
        ElseIf txtContraseña.Text <> "" And txtContraseña.Text <> "" Then
            If txtContraseña.Text = txtContraseña.Text Then
                controllerUser.modificarUsuario(txtCorreo.Text, txtContraseña.Text)
            End If
        End If
    End Sub
    Public Function valCampos() As Boolean
        If txtApellido.Text <> "" And txtCedula.Text <> "" And txtContrasena2.Text <> "" And txtContraseña.Text <> "" And txtCorreo.Text <> "" And txtNombre.Text <> "" And txtTelefono.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pregunta As String = MsgBox("seguro desea eliminar esta cuenta?", vbYesNo + vbQuestion, "Eliminar cuenta")
        If pregunta = vbYes Then
            If controllerUser.modificarEstado(txtCedula.Text) And txtCedula.Text = Form1.idUuario Then
                Dim Inicio_sesion As New Inicio_sesion
                Inicio_sesion.MdiParent = Form1
                Inicio_sesion.StartPosition = FormStartPosition.Manual
                Inicio_sesion.Left = 0
                Inicio_sesion.Top = 0
                Inicio_sesion.Show()
                Me.Hide()
            End If
        End If

    End Sub
End Class