﻿Public Class BuscarUsuarios
    Private Sub BuscarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contrUser As New ControladorDistribuidor
        contrUser.buscarUsuario(DgConsultaUsuarios)
    End Sub

    Private Sub DgConsultaUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgConsultaUsuarios.CellClick
        Dim id As Integer = DgConsultaUsuarios.CurrentRow.Cells(0).Value
        Dim EditarPerfil As New EditarPerfil(id)
        EditarPerfil.MdiParent = Form1
        EditarPerfil.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        EditarPerfil.Left = 0
        EditarPerfil.Top = 0
        EditarPerfil.Show()
        Me.Hide()
    End Sub


End Class