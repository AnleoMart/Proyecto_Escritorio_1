Public Class Inicio_sesion
    Private Sub olvidoContraseña_Click(sender As Object, e As EventArgs) Handles olvidoContraseña.Click
        Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = "Registro").SingleOrDefault()
        If fr Is Nothing Then

            Dim registro As New Registro
            registro.MdiParent = Form1
            registro.Show()
            Me.Hide()
        End If
        'Registro.Show()
        'Me.Hide()



    End Sub
End Class