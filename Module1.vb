Imports System.IO
Imports System.Data.SQLite

Module Module1
    Public con As New SQLiteConnection(strcon)
    Public ad As New SQLiteDataAdapter
    Public ds As New DataSet
    Public dv As New DataView
    Public cmd As New SQLiteCommand
    Public sqlparam As New List(Of SQLiteParameter)
    Public newparam As New SQLiteParameter
    Public reader As SQLiteDataReader

    Public dirpath As String = Directory.GetCurrentDirectory
    Public filename As String = "WIFIDB.db"
    Public fullpath As String = Path.Combine(dirpath, filename)

    Public strcon As String = String.Format("Data Source = {0}", fullpath)

    Public Sub executequery(ByVal cmdtext As String, ByVal conn As SQLiteConnection)
        conn.Close()

        cmd = New SQLiteCommand
        With cmd
            .Connection = conn
            .CommandText = cmdtext
            .CommandType = CommandType.Text
        End With

        PopulateParam()

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        cmd.Dispose()
        sqlparam.Clear()
    End Sub

    Public Sub execadapter(ByVal strqry As String, ByVal conn As SQLiteConnection, ByVal strtable As String)
        ad.Dispose()
        ds.Dispose()
        dv.Dispose()
        cmd.Dispose()

        cmd = New SQLiteCommand(strqry, conn)

        PopulateParam()

        ad = New SQLiteDataAdapter(cmd)
        ds = New DataSet
        ad.Fill(ds, strtable)
        dv = New DataView(ds.Tables(strtable))

        sqlparam.Clear()
    End Sub

    Public Sub AddParam(ByVal pName As String, ByVal pValue As Object, Optional ByVal pDataType As DbType = DbType.String)
        newparam = New SQLiteParameter With {.ParameterName = pName, .Value = pValue, .DbType = pDataType}
        sqlparam.Add(newparam)
    End Sub

    Public Sub PopulateParam()
        For Each p As SQLiteParameter In sqlparam
            cmd.Parameters.Add(p)
            cmd.Parameters(p.ParameterName).Value = p.Value
        Next
    End Sub
End Module
