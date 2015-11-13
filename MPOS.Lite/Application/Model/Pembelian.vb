Namespace Model
    Public Class Pembelian
        Private _Barang As Model.Barang

        Public Property NoID As Integer
        Public Property Kode As String
        Public Property Tanggal As Date
        Public Property Barang As Barang
            Get
                Return _Barang
            End Get
            Set(value As Barang)
                _Barang = value
            End Set
        End Property
        Public Property HargaBeli As Double
        Public Property Qty As Double
        Public Property Total As Double
        Public Property Satuan As String
            Get
                Return Barang.Satuan
            End Get
            Set(value As String)

            End Set
        End Property
        Public Property KodeBarang As String
            Get
                Return Barang.Kode
            End Get
            Set(value As String)

            End Set
        End Property
        Public Property NamaBarang As String
            Get
                Return Barang.Nama
            End Get
            Set(value As String)

            End Set
        End Property
    End Class
End Namespace