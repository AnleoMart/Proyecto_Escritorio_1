Imports MySqlConnector

Module Connection

    'mysql://b7e0edce9d2e7b:b6a5b7e2@us-cdbr-east-06.cleardb.net/heroku_18d10db9bfa40d6?reconnect=true

    'Dim con As String = "server=localhost; Port=3306;database=inventario; user id=root;password=;"
    'Dim con As String = "server=35.198.37.23; Port=3306;database=inventario; user id=ue;password=12345;"
    'Dim con As String = "server=inventario-server.database.windows.net; Port=3306;database=inventario; user id=alphagroup;password=2023Uniempresarial" '
    Dim con As String = "server=us-cdbr-east-06.cleardb.net; Port=3306;database=heroku_18d10db9bfa40d6; user id=b7e0edce9d2e7b;password=b6a5b7e2;"
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
