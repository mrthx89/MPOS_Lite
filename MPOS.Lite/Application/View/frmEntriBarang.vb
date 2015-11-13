Imports MetroFramework
Imports MetroFramework.Forms
Imports MPOS.Lite.Repository.Public

Namespace View
    Public Class frmEntriBarang
        Public ObjBarangLama As New Model.Barang
        Dim rep As New Repository.Registry

        Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
            DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub cmdBaru_Click(sender As Object, e As EventArgs) Handles cmdBaru.Click
            Try
                If IsValidasi() Then
                    ObjBarangLama.Kode = txtKode.Text
                    ObjBarangLama.Nama = txtNama.Text
                    ObjBarangLama.Satuan = txtSatuan.Text
                    ObjBarangLama.HargaBeli = Val(txtHargaBeli.Text)
                    ObjBarangLama.HargaJual = Val(txtHargaBeli.Text)
                    ObjBarangLama.Stok = Val(txtStok.Text)
                    If rep.ApplikasiServices.SimpanDataBarang(IIf(ObjBarangLama.NoID >= 1, True, False), ObjBarangLama) Then
                        DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                End If
            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Function IsValidasi() As Boolean
            If txtKode.Text = "" Then
                MetroMessageBox.Show(Repository.Public.FormMain, "Kode masih kosong !", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtKode.Focus()
                Return False
                Exit Function
            End If
            If txtNama.Text = "" Then
                MetroMessageBox.Show(Repository.Public.FormMain, "Nama masih kosong !", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNama.Focus()
                Return False
                Exit Function
            End If
            If txtSatuan.Text = "" Then
                MetroMessageBox.Show(Repository.Public.FormMain, "Alamat masih kosong !", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSatuan.Focus()
                Return False
                Exit Function
            End If

            Return True
        End Function

        Private Sub frmEntriBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If ObjBarangLama Is Nothing Then
                ObjBarangLama = New Model.Barang
            ElseIf ObjBarangLama.NoID >= 1 Then 'Edit Data
                txtNama.Text = ObjBarangLama.Nama
                txtKode.Text = ObjBarangLama.Kode
                txtSatuan.Text = ObjBarangLama.Satuan
                txtHargaBeli.Text = ObjBarangLama.HargaBeli.ToString("n0")
                txtHargaJual.Text = ObjBarangLama.HargaJual.ToString("n0")
                txtStok.Text = ObjBarangLama.Stok.ToString("n0")
            End If
        End Sub

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            SetSkin("")
        End Sub

        Private Sub SetSkin(ByVal Style As String)
            Repository.MySkin.Owner = Me
            Me.StyleManager = Repository.MySkin
            Me.Theme = Repository.MySkin.Theme
            Me.Style = Repository.MySkin.Style
            Repository.MySkin.Update()
            Me.Refresh()
        End Sub

        Private Sub txtHargaBeli_Click(sender As Object, e As EventArgs) Handles txtHargaBeli.Click

        End Sub

        Private Sub txtNumeric_KeyDown(sender As Object, e As KeyEventArgs) Handles txtHargaBeli.KeyDown, txtHargaJual.KeyDown
            'If IsNumeric(txtHargaBeli.Text) = Format
        End Sub

        Private Sub txtNumeric_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHargaBeli.KeyPress, txtHargaJual.KeyPress
            If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
                MetroMessageBox.Show(Repository.Public.FormMain, "Please enter numbers only", NamaAplikasi, MessageBoxButtons.OK)
                e.Handled = True
            ElseIf IsNumeric(e.KeyChar) Then
                sender.Text = Val(sender.text.ToString.Replace(",", "").Replace(".", "") & e.KeyChar).ToString("n0")
                sender.Select(sender.Text.Length, 0)
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace