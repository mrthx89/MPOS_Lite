Imports MPOS.Lite.Model

Namespace Controller
    Public Interface IRS
        Function GetUserLogin(ByVal objUser As User) As UserLogin
        Function GetDaftarKontak(ByVal objFilter As List(Of Filter)) As List(Of Kontak)
        Function SimpanDataKontak(ByVal IsEdit As Boolean, ByRef ObjKontak As Kontak) As Boolean
        Function HapusDataKontak(ByVal ObjKontak As Kontak) As Boolean
        Function GetDaftarBarang(ByVal objFilter As List(Of Filter)) As List(Of Barang)
        Function SimpanDataBarang(ByVal IsEdit As Boolean, ByRef ObjBarang As Barang) As Boolean
        Function HapusDataBarang(ByVal ObjBarang As Barang) As Boolean
        Function GetBarang(ByVal NoID As Integer) As Barang
        Function GetDaftarPembelian(ByVal objFilter As List(Of Filter)) As List(Of Pembelian)
    End Interface
End Namespace