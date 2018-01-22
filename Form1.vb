Imports System.IO
Imports System.Data.SQLite

Public Class Form1
    Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs) Handles btnBrowseImage.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "D:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Dim fs As FileStream = New FileStream(fd.FileName, FileMode.Open, FileAccess.Read)
            Dim br As BinaryReader = New BinaryReader(fs)
            Dim bm() As Byte = br.ReadBytes(fs.Length)

            br.Close()
            fs.Close()

            Dim photo() As Byte = bm
            sqlparam.Clear()
            AddParam("@Image", photo, DbType.Binary)
            executequery("INSERT INTO tblImages(Image) VALUES(@Image)", con)
        End If
    End Sub

    Private Sub btnRetrieveImage_Click(sender As Object, e As EventArgs) Handles btnRetrieveImage.Click
        sqlparam.Clear()
        AddParam("@ID", txtID.Text, DbType.Int32)
        PB.Image = Nothing
        cmd.Dispose()
        cmd = New SQLiteCommand("SELECT Image FROM tblImages WHERE ID = @ID", con)
        Try
            con.Close()
            con.Open()
            PopulateParam()
            reader = cmd.ExecuteReader
            While reader.Read
                PB.Image = BLOBtoImage(reader("Image"))
            End While
        Catch ex As Exception
        Finally
            con.Close()
            sqlparam.Clear()
        End Try
    End Sub

    Public Function BLOBtoImage(ByVal blob)
        Dim mStream As New MemoryStream
        Dim pData() As Byte = DirectCast(blob, Byte())
        mStream.Write(pData, 0, Convert.ToInt32(pData.Length))
        Dim bm As Bitmap = New Bitmap(mStream, False)
        mStream.Dispose()
        Return bm
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim curpath As String = Directory.GetCurrentDirectory
        Dim filename As String = "WIFIDB.db"
        Dim fullpath As String = Path.Combine(curpath, filename)

        Dim strcon As String = String.Format("Data Source = {0}", fullpath)
        con = New SQLiteConnection(strcon)
    End Sub
End Class
