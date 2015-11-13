Namespace Model
    Public Class Filter
        Public Enum iKondisi
            Lebih = 0
            LebihSama = 1
            Kurang = 2
            KurangSama = 3
            Sama = 4
            Baik = 5
        End Enum
        Public Enum iSpliter
            Atau = 0
            Dan = 1
        End Enum
        Public Property Spliter As iSpliter
        Public Property Kondisi As iKondisi
        Public Property Kolom As String
        Public Property Value As String
    End Class
End Namespace
