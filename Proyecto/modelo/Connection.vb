Imports MySqlConnector

Module Connection



    Dim con As String = "server=localhost; Port=3306;database=inventario; user id=root;password=;"
    'Dim con As String = "server=35.198.37.23; Port=3306;database=inventario; user id=ue;password=12345;"
    'Dim con As String = "server=inventario-server.database.windows.net; Port=3306;database=inventario; user id=alphagroup;password=2023Uniempresarial" '
    Public MysqlConex As MySqlConnection = New MySqlConnection(con)
    'Abrir Conexión'
    Sub openConn()
        Try
            If MysqlConex.State = 0 Then
                MysqlConex.Open()
                ' MsgBox("Hay Conexión")
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Sub closeConn()
        MysqlConex.Close()
    End Sub

End Module
