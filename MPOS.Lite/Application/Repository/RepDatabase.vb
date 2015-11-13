Imports MPOS.Lite.Model
Imports MySql.Data.MySqlClient
Imports MetroFramework.Forms
Imports MetroFramework

Namespace Repository
    Public Class RepDatabase
        Dim SQL As String = ""
        Dim strKonSQL As String = getKoneksiString()

        Public Function GetBarang(NoID As Integer) As Barang
            Dim con As New MySqlConnection
            Dim com As New MySqlCommand
            Dim sqlRD As MySqlDataReader = Nothing
            Dim Obj As New Model.Barang
            Dim tran As MySqlTransaction = Nothing
            Try
                con.ConnectionString = strKonSQL
                con.Open()
                com.Connection = con
                tran = con.BeginTransaction
                com.Transaction = tran

                SQL = "select * from mbarang where noid" & NoID
                com.CommandText = SQL
                com.Parameters.Clear()
                sqlRD = com.ExecuteReader
                If sqlRD.HasRows Then
                    sqlRD.Read()
                    Obj.NoID = Utils.NullToInt(sqlRD.Item("noid"))
                    Obj.Kode = Utils.NullToStr(sqlRD.Item("kode"))
                    Obj.Nama = Utils.NullToStr(sqlRD.Item("nama"))
                    Obj.Satuan = Utils.NullToStr(sqlRD.Item("satuan"))
                    Obj.HargaBeli = Utils.NullToDbl(sqlRD.Item("hargabeli"))
                    Obj.HargaJual = Utils.NullToDbl(sqlRD.Item("hargajual"))
                    Obj.Stok = Utils.NullToDbl(sqlRD.Item("stok"))
                Else
                    Obj = Nothing
                End If
                sqlRD.Close()

            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                If tran Is Nothing Then
                    tran.Rollback()
                    tran = Nothing
                End If
            Finally
                If tran Is Nothing Then
                    tran.Commit()
                    tran = Nothing
                End If
                com.Dispose()
                con.Close()
                con.Dispose()
            End Try
            Return Obj
        End Function

        Public Function GetUserLogin(objUser As User) As UserLogin
            Dim con As New MySqlConnection
            Dim com As New MySqlCommand
            Dim sqlRD As MySqlDataReader = Nothing
            Dim UserLogin As New Model.UserLogin
            Dim tran As MySqlTransaction = Nothing
            Try
                con.ConnectionString = strKonSQL
                con.Open()
                com.Connection = con
                tran = con.BeginTransaction
                com.Transaction = tran

                SQL = "select * from muser where kode=@Kode AND pwd=@Pwd"
                com.CommandText = SQL
                com.Parameters.Clear()
                com.Parameters.Add(New MySqlParameter("Kode", objUser.Kode))
                com.Parameters.Add(New MySqlParameter("Pwd", objUser.Pwd))
                sqlRD = com.ExecuteReader
                If sqlRD.HasRows Then
                    sqlRD.Read()
                    UserLogin.IDUser = Utils.NullToInt(sqlRD.Item("noid"))
                    UserLogin.NamaUser = Utils.NullToStr(sqlRD.Item("nama"))
                    UserLogin.IsLogin = True
                    UserLogin.IsEditReport = False
                Else
                    UserLogin = Nothing
                End If
                sqlRD.Close()

            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                If tran Is Nothing Then
                    tran.Rollback()
                    tran = Nothing
                End If
            Finally
                If tran Is Nothing Then
                    tran.Commit()
                    tran = Nothing
                End If
                com.Dispose()
                con.Close()
                con.Dispose()
            End Try
            Return UserLogin
        End Function

        Public Function GetDaftarPembelian(objFilter As List(Of Filter)) As List(Of Pembelian)
            Dim con As New MySqlConnection
            Dim com As New MySqlCommand
            Dim sqlRD As MySqlDataReader = Nothing
            Dim Obj As Pembelian, DaftarPembelian As New List(Of Pembelian)
            Dim tran As MySqlTransaction = Nothing
            Try
                con.ConnectionString = strKonSQL
                con.Open()
                com.Connection = con
                tran = con.BeginTransaction
                com.Transaction = tran

                SQL = "SELECT mbeli.noid, mbeli.kode, mbeli.tanggal, mbelid.idbarang," & vbCrLf & _
                      " mbelid.hargabeli, mbelid.qty, mbeli.total" & vbCrLf & _
                      " from mbeli" & vbCrLf & _
                      " inner join mbelid on mbeli.noid = mbelid.idbeli where 1=1 "
                If Not objFilter Is Nothing AndAlso objFilter.Count >= 1 Then
                    For i As Integer = 0 To objFilter.Count - 1
                        Select Case objFilter(i).Kondisi
                            Case Filter.iKondisi.Baik
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " LIKE " & objFilter(i).Value
                            Case Filter.iKondisi.Kurang
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " < " & objFilter(i).Value
                            Case Filter.iKondisi.KurangSama
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " <= " & objFilter(i).Value
                            Case Filter.iKondisi.Lebih
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " > " & objFilter(i).Value
                            Case Filter.iKondisi.LebihSama
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " >= " & objFilter(i).Value
                            Case Filter.iKondisi.Sama
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " = " & objFilter(i).Value
                        End Select
                    Next
                End If
                com.CommandText = SQL
                sqlRD = com.ExecuteReader
                While sqlRD.Read
                    Obj = New Model.Pembelian
                    Obj.NoID = Utils.NullToInt(sqlRD.Item("noid"))
                    Obj.Kode = Utils.NullToStr(sqlRD.Item("kode"))
                    Obj.Tanggal = Utils.NullToDate(sqlRD.Item("tanggal"))
                    Obj.Total = Utils.NullToDbl(sqlRD.Item("total"))
                    Obj.HargaBeli = Utils.NullToDbl(sqlRD.Item("hargabeli"))
                    Obj.Qty = Utils.NullToDbl(sqlRD.Item("qty"))
                    Obj.Barang = GetBarang(Utils.NullToInt(sqlRD.Item("idbarang")))
                    DaftarPembelian.Add(Obj)
                End While
                sqlRD.Close()

            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not tran Is Nothing Then
                    tran.Rollback()
                    tran = Nothing
                End If
            Finally
                If Not tran Is Nothing Then
                    tran.Commit()
                    tran = Nothing
                End If
                com.Dispose()
                con.Close()
                con.Dispose()
            End Try
            Return DaftarPembelian
        End Function

        Public Function GetDaftarKontak(objFilter As List(Of Filter)) As List(Of Kontak)
            Dim con As New MySqlConnection
            Dim com As New MySqlCommand
            Dim sqlRD As MySqlDataReader = Nothing
            Dim Obj As Kontak, DaftarKontak As New List(Of Kontak)
            Dim tran As MySqlTransaction = Nothing
            Try
                con.ConnectionString = strKonSQL
                con.Open()
                com.Connection = con
                tran = con.BeginTransaction
                com.Transaction = tran

                SQL = "select * from mkontak where 1=1 "
                If Not objFilter Is Nothing AndAlso objFilter.Count >= 1 Then
                    For i As Integer = 0 To objFilter.Count - 1
                        Select Case objFilter(i).Kondisi
                            Case Filter.iKondisi.Baik
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " LIKE " & objFilter(i).Value
                            Case Filter.iKondisi.Kurang
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " < " & objFilter(i).Value
                            Case Filter.iKondisi.KurangSama
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " <= " & objFilter(i).Value
                            Case Filter.iKondisi.Lebih
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " > " & objFilter(i).Value
                            Case Filter.iKondisi.LebihSama
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " >= " & objFilter(i).Value
                            Case Filter.iKondisi.Sama
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " = " & objFilter(i).Value
                        End Select
                    Next
                End If
                com.CommandText = SQL
                sqlRD = com.ExecuteReader
                While sqlRD.Read
                    Obj = New Model.Kontak
                    Obj.NoID = Utils.NullToInt(sqlRD.Item("noid"))
                    Obj.Nama = Utils.NullToStr(sqlRD.Item("nama"))
                    Obj.Alamat = Utils.NullToStr(sqlRD.Item("alamat"))
                    DaftarKontak.Add(Obj)
                End While
                sqlRD.Close()

            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not tran Is Nothing Then
                    tran.Rollback()
                    tran = Nothing
                End If
            Finally
                If Not tran Is Nothing Then
                    tran.Commit()
                    tran = Nothing
                End If
                com.Dispose()
                con.Close()
                con.Dispose()
            End Try
            Return DaftarKontak
        End Function

        Public Function GetDaftarBarang(objFilter As List(Of Filter)) As List(Of Barang)
            Dim con As New MySqlConnection
            Dim com As New MySqlCommand
            Dim sqlRD As MySqlDataReader = Nothing
            Dim Obj As Barang, DaftarBarang As New List(Of Barang)
            Dim tran As MySqlTransaction = Nothing
            Try
                con.ConnectionString = strKonSQL
                con.Open()
                com.Connection = con
                tran = con.BeginTransaction
                com.Transaction = tran

                SQL = "select * from mBarang where 1=1 "
                If Not objFilter Is Nothing AndAlso objFilter.Count >= 1 Then
                    For i As Integer = 0 To objFilter.Count - 1
                        Select Case objFilter(i).Kondisi
                            Case Filter.iKondisi.Baik
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " LIKE " & objFilter(i).Value
                            Case Filter.iKondisi.Kurang
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " < " & objFilter(i).Value
                            Case Filter.iKondisi.KurangSama
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " <= " & objFilter(i).Value
                            Case Filter.iKondisi.Lebih
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " > " & objFilter(i).Value
                            Case Filter.iKondisi.LebihSama
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " >= " & objFilter(i).Value
                            Case Filter.iKondisi.Sama
                                SQL &= IIf(objFilter(i).Spliter = Filter.iSpliter.Dan, " AND ", " OR ") & objFilter(i).Kolom & " = " & objFilter(i).Value
                        End Select
                    Next
                End If
                com.CommandText = SQL
                sqlRD = com.ExecuteReader
                While sqlRD.Read
                    Obj = New Model.Barang
                    Obj.NoID = Utils.NullToInt(sqlRD.Item("noid"))
                    Obj.Kode = Utils.NullToStr(sqlRD.Item("kode"))
                    Obj.Nama = Utils.NullToStr(sqlRD.Item("nama"))
                    Obj.Satuan = Utils.NullToStr(sqlRD.Item("satuan"))
                    Obj.HargaBeli = Utils.NullToDbl(sqlRD.Item("hargabeli"))
                    Obj.HargaJual = Utils.NullToDbl(sqlRD.Item("hargajual"))
                    Obj.Stok = Utils.NullToDbl(sqlRD.Item("stok"))
                    DaftarBarang.Add(Obj)
                End While
                sqlRD.Close()

            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not tran Is Nothing Then
                    tran.Rollback()
                    tran = Nothing
                End If
            Finally
                If Not tran Is Nothing Then
                    tran.Commit()
                    tran = Nothing
                End If
                com.Dispose()
                con.Close()
                con.Dispose()
            End Try
            Return DaftarBarang
        End Function

        Public Function SimpanDataKontak(ByVal IsEdit As Boolean, ByRef ObjKontak As Kontak) As Boolean
            Dim hasil As Boolean = False
            Dim con As New MySqlConnection
            Dim com As New MySqlCommand
            Dim tran As MySqlTransaction = Nothing
            Try
                con.ConnectionString = strKonSQL
                con.Open()
                com.Connection = con
                tran = con.BeginTransaction
                com.Transaction = tran

                If IsEdit Then
                    SQL = "UPDATE MKontak SET Nama=@Nama, Alamat=@Alamat WHERE NoID=" & ObjKontak.NoID
                    com.CommandText = SQL
                    com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("NoID", ObjKontak.NoID))
                    com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("Nama", ObjKontak.Nama))
                    com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("Alamat", ObjKontak.Alamat))
                Else
                    SQL = "select MAX(NoID) from mkontak "
                    com.CommandText = SQL
                    ObjKontak.NoID = Repository.Utils.NullToInt(com.ExecuteScalar()) + 1
                    SQL = "INSERT INTO MKontak (NoID, Nama, Alamat) Values (@NoID, @Nama, @Alamat)"
                    com.CommandText = SQL
                    com.Parameters.Clear()
                    com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("NoID", ObjKontak.NoID))
                    com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("Nama", ObjKontak.Nama))
                    com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("Alamat", ObjKontak.Alamat))
                End If
                If Repository.Utils.NullToInt(com.ExecuteNonQuery()) >= 1 Then
                    hasil = True
                Else
                    hasil = False
                End If
            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not tran Is Nothing Then
                    tran.Rollback()
                    tran = Nothing
                End If
            Finally
                If Not tran Is Nothing Then
                    tran.Commit()
                    tran = Nothing
                End If
                com.Dispose()
                con.Close()
                con.Dispose()
            End Try
            Return hasil
        End Function

        Public Function HapusDataKontak(ByVal ObjKontak As Kontak) As Boolean
            Dim hasil As Boolean = False
            Dim con As New MySqlConnection
            Dim com As New MySqlCommand
            Dim tran As MySqlTransaction = Nothing
            Try
                con.ConnectionString = strKonSQL
                con.Open()
                com.Connection = con
                tran = con.BeginTransaction
                com.Transaction = tran

                SQL = "SELECT COUNT(MJual.NoID) AS Jumlah FROM MJual WHERE MJual.IDKontak=" & ObjKontak.NoID
                com.CommandText = SQL
                If Utils.NullToLong(com.ExecuteScalar) = 0 Then
                    SQL = "DELETE FROM Mkontak WHERE NoID=" & ObjKontak.NoID
                    com.CommandText = SQL
                    com.ExecuteNonQuery()
                    MetroMessageBox.Show(Repository.Public.FormMain, "Master kontak berhasil dihapus.", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    hasil = True
                Else
                    MetroMessageBox.Show(Repository.Public.FormMain, "Master kontak tidak bisa dihapus karena sudah pernah ada ditransaksi.", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    hasil = False
                End If
            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not tran Is Nothing Then
                    tran.Rollback()
                    tran = Nothing
                End If
            Finally
                If Not tran Is Nothing Then
                    tran.Commit()
                    tran = Nothing
                End If
                com.Dispose()
                con.Close()
                con.Dispose()
            End Try
            Return hasil
        End Function

        Public Function SimpanDataBarang(ByVal IsEdit As Boolean, ByRef ObjBarang As Barang) As Boolean
            Dim hasil As Boolean = False
            Dim con As New MySqlConnection
            Dim com As New MySqlCommand
            Dim tran As MySqlTransaction = Nothing
            Try
                con.ConnectionString = strKonSQL
                con.Open()
                com.Connection = con
                tran = con.BeginTransaction
                com.Transaction = tran

                If IsEdit Then
                    SQL = "UPDATE MBarang SET kode=@Kode, nama=@Nama, satuan=@Satuan, hargabeli=@HargaBeli, hargajual=@HargaJual WHERE NoID=" & ObjBarang.NoID
                    com.CommandText = SQL
                    com.Parameters.Clear()
                Else
                    SQL = "select MAX(NoID) from mBarang "
                    com.CommandText = SQL
                    ObjBarang.NoID = Repository.Utils.NullToInt(com.ExecuteScalar()) + 1
                    ObjBarang.Stok = 0
                    SQL = "INSERT INTO MBarang (NoID, Kode, Nama, Satuan, HargaBeli, HargaJual, Stok) Values (@NoID, @Kode, @Nama, @Satuan, @HargaBeli, @HargaJual, @Stok)"
                    com.CommandText = SQL
                    com.Parameters.Clear()
                    com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("Stok", ObjBarang.Stok))
                End If
                com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("NoID", ObjBarang.NoID))
                com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("Kode", ObjBarang.Kode))
                com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("Nama", ObjBarang.Nama))
                com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("Satuan", ObjBarang.Satuan))
                com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("HargaBeli", ObjBarang.HargaBeli))
                com.Parameters.Add(New MySql.Data.MySqlClient.MySqlParameter("HargaJual", ObjBarang.HargaJual))

                If Repository.Utils.NullToInt(com.ExecuteNonQuery()) >= 1 Then
                    hasil = True
                Else
                    hasil = False
                End If
            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not tran Is Nothing Then
                    tran.Rollback()
                    tran = Nothing
                End If
            Finally
                If Not tran Is Nothing Then
                    tran.Commit()
                    tran = Nothing
                End If
                com.Dispose()
                con.Close()
                con.Dispose()
            End Try
            Return hasil
        End Function

        Public Function HapusDataBarang(ByVal ObjBarang As Barang) As Boolean
            Dim hasil As Boolean = False
            Dim con As New MySqlConnection
            Dim com As New MySqlCommand
            Dim tran As MySqlTransaction = Nothing
            Try
                con.ConnectionString = strKonSQL
                con.Open()
                com.Connection = con
                tran = con.BeginTransaction
                com.Transaction = tran

                SQL = "SELECT COUNT(MJualD.NoID) AS Jumlah FROM MJual INNER JOIN MJualD ON MJual.NoID=MJualD.IDJual WHERE MJualD.IDBarang=" & ObjBarang.NoID
                com.CommandText = SQL
                If Utils.NullToLong(com.ExecuteScalar) = 0 Then
                    SQL = "SELECT COUNT(MBeliD.NoID) AS Jumlah FROM MBeli INNER JOIN MBeliD ON MBeli.NoID=MBeliD.IDBeli WHERE MBeliD.IDBarang=" & ObjBarang.NoID
                    com.CommandText = SQL
                    If Utils.NullToLong(com.ExecuteScalar) = 0 Then
                        SQL = "DELETE FROM MBarang WHERE NoID=" & ObjBarang.NoID
                        com.CommandText = SQL
                        com.ExecuteNonQuery()
                        MetroMessageBox.Show(Repository.Public.FormMain, "Master Barang berhasil dihapus.", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        hasil = True
                    Else
                        MetroMessageBox.Show(Repository.Public.FormMain, "Master Barang tidak bisa dihapus karena sudah pernah ada ditransaksi.", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        hasil = False
                    End If
                Else
                    MetroMessageBox.Show(Repository.Public.FormMain, "Master Barang tidak bisa dihapus karena sudah pernah ada ditransaksi.", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    hasil = False
                End If
            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                If Not tran Is Nothing Then
                    tran.Rollback()
                    tran = Nothing
                End If
            Finally
                If Not tran Is Nothing Then
                    tran.Commit()
                    tran = Nothing
                End If
                com.Dispose()
                con.Close()
                con.Dispose()
            End Try
            Return hasil
        End Function
    End Class
End Namespace