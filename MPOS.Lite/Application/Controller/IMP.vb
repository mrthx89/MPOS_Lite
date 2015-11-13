Imports MPOS.Lite.Model
Imports MPOS.Lite.Repository
Namespace Controller
    Public Class IMP
        Implements IRS

        Private Rep As New RepDatabase

        Public Function GetUserLogin(objUser As User) As UserLogin Implements IRS.GetUserLogin
            Return Rep.GetUserLogin(objUser)
        End Function

        Public Function GetDaftarKontak(objFilter As List(Of Filter)) As List(Of Kontak) Implements IRS.GetDaftarKontak
            Return Rep.GetDaftarKontak(objFilter)
        End Function

        Public Function SimpanDataKontak(IsEdit As Boolean, ByRef ObjKontak As Kontak) As Boolean Implements IRS.SimpanDataKontak
            Return Rep.SimpanDataKontak(IsEdit, ObjKontak)
        End Function

        Public Function GetDaftarBarang(objFilter As List(Of Filter)) As List(Of Barang) Implements IRS.GetDaftarBarang
            Return Rep.GetDaftarBarang(objFilter)
        End Function

        Public Function SimpanDataBarang(IsEdit As Boolean, ByRef ObjBarang As Barang) As Boolean Implements IRS.SimpanDataBarang
            Return Rep.SimpanDataBarang(IsEdit, ObjBarang)
        End Function

        Public Function HapusDataBarang(ObjBarang As Barang) As Boolean Implements IRS.HapusDataBarang
            Return Rep.HapusDataBarang(ObjBarang)
        End Function

        Public Function HapusDataKontak(ObjKontak As Kontak) As Boolean Implements IRS.HapusDataKontak
            Return Rep.HapusDataKontak(ObjKontak)
        End Function

        Public Function GetBarang(NoID As Integer) As Barang Implements IRS.GetBarang
            Return Rep.GetBarang(NoID)
        End Function

        Public Function GetDaftarPembelian(objFilter As List(Of Filter)) As List(Of Pembelian) Implements IRS.GetDaftarPembelian
            Return Rep.GetDaftarPembelian(objFilter)
        End Function
    End Class
End Namespace