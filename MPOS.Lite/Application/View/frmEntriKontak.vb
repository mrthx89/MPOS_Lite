Imports MetroFramework
Imports MetroFramework.Forms
Imports MPOS.Lite.Repository.Public

Namespace View
    Public Class frmEntriKontak
        Public ObjKontakLama As New Model.Kontak
        Dim rep As New Repository.Registry

        Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
            DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub cmdBaru_Click(sender As Object, e As EventArgs) Handles cmdBaru.Click
            Try
                If IsValidasi() Then
                    ObjKontakLama.Nama = MetroTextBox1.Text
                    ObjKontakLama.Alamat = MetroTextBox2.Text
                    If rep.ApplikasiServices.SimpanDataKontak(IIf(ObjKontakLama.NoID >= 1, True, False), ObjKontakLama) Then
                        DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                End If
            Catch ex As Exception
                MetroMessageBox.Show(Repository.Public.FormMain, "Error : " & ex.Message, NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Function IsValidasi() As Boolean
            If MetroTextBox1.Text = "" Then
                MetroMessageBox.Show(Repository.Public.FormMain, "Nama masih kosong !", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                MetroTextBox1.Focus()
                Return False
                Exit Function
            End If
            If MetroTextBox2.Text = "" Then
                MetroMessageBox.Show(Repository.Public.FormMain, "Alamat masih kosong !", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Error)
                MetroTextBox2.Focus()
                Return False
                Exit Function
            End If

            Return True
        End Function

        Private Sub frmEntriKontak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If ObjKontakLama Is Nothing Then
                ObjKontakLama = New Model.Kontak
            ElseIf ObjKontakLama.NoID >= 1 Then 'Edit Data
                MetroTextBox1.Text = ObjKontakLama.Nama
                MetroTextBox2.Text = ObjKontakLama.Alamat
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
    End Class
End Namespace