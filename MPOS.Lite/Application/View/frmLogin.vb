Imports MPOS.Lite.Repository

Namespace View
    Public Class frmLogin
        Private Rep As New MPOS.Lite.Repository.Registry

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            SetSkin("")
            Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        End Sub

        Private Sub SetSkin(ByVal Style As String)
            Repository.MySkin.Owner = Me
            Me.StyleManager = Repository.MySkin
            Me.Theme = Repository.MySkin.Theme
            Me.Style = Repository.MySkin.Style
            Repository.MySkin.Update()
            Me.Refresh()
        End Sub

        Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
            Me.Close()
            DialogResult = Windows.Forms.DialogResult.Cancel
        End Sub

        Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
            If MetroTextBox1.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Repository.Public.FormMain, "Kode user masih kosong! ", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroTextBox1.Focus()
                Exit Sub
            End If
            If MetroTextBox2.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Repository.Public.FormMain, "Password user masih kosong! ", NamaAplikasi, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                MetroTextBox2.Focus()
                Exit Sub
            End If

            Dim User As New Model.User
            User.Kode = MetroTextBox1.Text
            User.Pwd = MetroTextBox2.Text
            Public_User = Rep.ApplikasiServices.GetUserLogin(User)
            If Not Public_User Is Nothing Then
                DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                Public_User = New Model.UserLogin
            End If
        End Sub
    End Class
End Namespace