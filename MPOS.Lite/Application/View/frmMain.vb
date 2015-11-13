Imports MetroFramework.Forms
Imports MPOS.Lite.Repository
Imports MPOS.Lite.Model

Namespace View
    Public Class frmMain
        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            'Set Default
            FormMain = Me
            SetSkin("")
        End Sub

        Private Sub SetSkin(ByVal Style As String)
            If Style = "" Then
                Repository.MySkin.Theme = MetroFramework.MetroThemeStyle.Dark
                Repository.MySkin.Style = MetroFramework.MetroColorStyle.Orange
            Else
                If Style.ToUpper = "Light".ToUpper Then
                    Repository.MySkin.Theme = MetroFramework.MetroThemeStyle.Light
                    Repository.MySkin.Style = MetroFramework.MetroColorStyle.Purple
                Else
                    Repository.MySkin.Theme = MetroFramework.MetroThemeStyle.Dark
                    Repository.MySkin.Style = MetroFramework.MetroColorStyle.Orange
                End If
            End If
            Repository.MySkin.Owner = Me
            Me.StyleManager = Repository.MySkin
            Me.Theme = Repository.MySkin.Theme
            Me.Style = Repository.MySkin.Style
            Repository.MySkin.Update()
            MetroPanel1.Visible = False
            Me.Refresh()
        End Sub

        Private Sub frmMain_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
            If e.Button = Windows.Forms.MouseButtons.Left Then
                MetroPanel1.Visible = Not MetroPanel1.Visible
            End If
        End Sub

        Private Sub cmdLight_Click(sender As Object, e As EventArgs) Handles cmdLight.Click
            SetSkin("Light")
        End Sub

        Private Sub cmdDark_Click(sender As Object, e As EventArgs) Handles cmdDark.Click
            SetSkin("Dark")
        End Sub

        Private Sub MetroToggleEditReport_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggleEditReport.CheckedChanged
            Repository.Public_User.IsEditReport = MetroToggleEditReport.Checked
            MetroPanel1.Visible = Not MetroPanel1.Visible
        End Sub

        Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
            If Not Repository.Public_User.IsLogin Then
                Dim x As New frmLogin
                If x.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    MetroTile5.Text = "Logout"
                    MetroTile5.TileImage = My.Resources.employees_lock
                    MetroLabelUser.Text = "User : " & Public_User.NamaUser
                    MetroToggleEditReport.Checked = Public_User.IsEditReport

                End If
                x.Dispose()
            Else
                MetroTile5.Text = "Login"
                MetroTile5.TileImage = My.Resources.employees_key
                MetroLabelUser.Text = "User : (none)"
                Repository.Public_User.IDUser = -1
                Repository.Public_User.NamaUser = ""
                Repository.Public_User.IsLogin = False
            End If
            TampilkanMenu()
        End Sub

        Private Sub TampilkanMenu()
            'Belum ada BackEnd jadi Tampilkan Penuh
            MetroTile1.Enabled = Public_User.IsLogin
            MetroTile2.Enabled = Public_User.IsLogin
            MetroTile3.Enabled = Public_User.IsLogin
            MetroTile4.Enabled = Public_User.IsLogin
            MetroTile6.Enabled = Public_User.IsLogin
            MetroTile7.Enabled = Public_User.IsLogin
            MetroTile8.Enabled = Public_User.IsLogin
        End Sub

        Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            MetroTile5.PerformClick()
        End Sub

        Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
            Dim x As New frmDaftarKontak
            x.ShowDialog(Me)
            x.Dispose()
        End Sub

        Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
            Dim x As New frmDaftarBarang
            x.ShowDialog(Me)
            x.Dispose()
        End Sub

        Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
            Dim x As New frmDaftarPembelian
            x.ShowDialog(Me)
            x.Dispose()
        End Sub
    End Class
End Namespace