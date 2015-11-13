Imports MetroFramework
Imports MetroFramework.Forms

Namespace View
    Public Class frmDaftarPembelian
        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            SetSkin("")
            Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        End Sub

        Private BS As New BindingSource
        Dim rep As New Repository.Registry

        Private Sub SetSkin(ByVal Style As String)
            Repository.MySkin.Owner = Me
            Me.StyleManager = Repository.MySkin
            Me.Theme = Repository.MySkin.Theme
            Me.Style = Repository.MySkin.Style
            Repository.MySkin.Update()
            Me.Refresh()
        End Sub

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
            DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
            Dim Daftar As New List(Of Model.Pembelian)
            Dim ObjFilter As New List(Of Model.Filter)
            Try
                If txtCari.Text <> "" Then
                    ObjFilter.Add(New Model.Filter With {.Spliter = Model.Filter.iSpliter.Atau, .Kondisi = Model.Filter.iKondisi.Baik, .Kolom = "mPembelian.kode", .Value = "'%" & Repository.Utils.FixApostropi(txtCari.Text) & "%'"})
                End If
                Daftar = rep.ApplikasiServices.GetDaftarPembelian(ObjFilter)

                BS.DataSource = Daftar
                MetroGrid1.DataSource = BS
                MetroGrid1.Refresh()
            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, Repository.Public.NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub frmPembelian_Load(sender As Object, e As EventArgs) Handles Me.Load
            cmdRefresh.PerformClick()
        End Sub

        Private Sub cmdBaru_Click(sender As Object, e As EventArgs) Handles cmdBaru.Click
            'Dim x As New frmEntriPembelian
            'Dim Obj As New Model.Pembelian
            'Try
            '    If x.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            '        cmdRefresh.PerformClick()
            '    End If
            'Catch ex As Exception
            '    MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, Repository.Public.NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Finally
            '    x.Dispose()
            'End Try
        End Sub

        Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
            'Dim x As New frmEntriPembelian
            'Try
            '    x.ObjPembelianLama = BS.Current
            '    If x.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            '        cmdRefresh.PerformClick()
            '    End If
            'Catch ex As Exception
            '    MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, Repository.Public.NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Finally
            '    x.Dispose()
            'End Try
        End Sub

        Private Sub MetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellDoubleClick
            If e.RowIndex >= 1 Then
                cmdEdit.PerformClick()
            End If
        End Sub

        Private Sub cmdHapus_Click(sender As Object, e As EventArgs) Handles cmdHapus.Click
            'Try
            '    If BS.Count >= 1 AndAlso rep.ApplikasiServices.HapusDataPembelian(BS.Current) Then
            '        cmdRefresh.PerformClick()
            '    End If
            'Catch ex As Exception
            '    MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, Repository.Public.NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End Try
        End Sub
    End Class
End Namespace