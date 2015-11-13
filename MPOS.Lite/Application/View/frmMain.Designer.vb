Namespace View
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmMain
        Inherits MetroFramework.Forms.MetroForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
            Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
            Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
            Me.MetroToggleEditReport = New MetroFramework.Controls.MetroToggle()
            Me.cmdDark = New MetroFramework.Controls.MetroButton()
            Me.cmdLight = New MetroFramework.Controls.MetroButton()
            Me.MetroLabelUser = New MetroFramework.Controls.MetroLabel()
            Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
            Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
            Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
            Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
            Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
            Me.MetroTile6 = New MetroFramework.Controls.MetroTile()
            Me.MetroTile7 = New MetroFramework.Controls.MetroTile()
            Me.MetroTile8 = New MetroFramework.Controls.MetroTile()
            Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
            Me.MetroPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MetroPanel1
            '
            Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
            Me.MetroPanel1.Controls.Add(Me.MetroToggleEditReport)
            Me.MetroPanel1.Controls.Add(Me.cmdDark)
            Me.MetroPanel1.Controls.Add(Me.cmdLight)
            Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.MetroPanel1.HorizontalScrollbarBarColor = True
            Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
            Me.MetroPanel1.HorizontalScrollbarSize = 10
            Me.MetroPanel1.Location = New System.Drawing.Point(20, 489)
            Me.MetroPanel1.Name = "MetroPanel1"
            Me.MetroPanel1.Size = New System.Drawing.Size(877, 32)
            Me.MetroPanel1.TabIndex = 0
            Me.MetroPanel1.VerticalScrollbarBarColor = True
            Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
            Me.MetroPanel1.VerticalScrollbarSize = 10
            '
            'MetroLabel1
            '
            Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MetroLabel1.AutoSize = True
            Me.MetroLabel1.Location = New System.Drawing.Point(710, 9)
            Me.MetroLabel1.Name = "MetroLabel1"
            Me.MetroLabel1.Size = New System.Drawing.Size(76, 19)
            Me.MetroLabel1.TabIndex = 4
            Me.MetroLabel1.Text = "Edit Report"
            '
            'MetroToggleEditReport
            '
            Me.MetroToggleEditReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MetroToggleEditReport.AutoSize = True
            Me.MetroToggleEditReport.Location = New System.Drawing.Point(792, 11)
            Me.MetroToggleEditReport.Name = "MetroToggleEditReport"
            Me.MetroToggleEditReport.Size = New System.Drawing.Size(80, 17)
            Me.MetroToggleEditReport.TabIndex = 1
            Me.MetroToggleEditReport.Text = "Off"
            Me.MetroToggleEditReport.UseSelectable = True
            '
            'cmdDark
            '
            Me.cmdDark.Location = New System.Drawing.Point(109, 3)
            Me.cmdDark.Name = "cmdDark"
            Me.cmdDark.Size = New System.Drawing.Size(100, 25)
            Me.cmdDark.TabIndex = 3
            Me.cmdDark.Text = "Dark Style"
            Me.cmdDark.UseSelectable = True
            '
            'cmdLight
            '
            Me.cmdLight.Location = New System.Drawing.Point(3, 3)
            Me.cmdLight.Name = "cmdLight"
            Me.cmdLight.Size = New System.Drawing.Size(100, 25)
            Me.cmdLight.TabIndex = 2
            Me.cmdLight.Text = "Light Style"
            Me.cmdLight.UseSelectable = True
            '
            'MetroLabelUser
            '
            Me.MetroLabelUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.MetroLabelUser.Cursor = System.Windows.Forms.Cursors.Hand
            Me.MetroLabelUser.Location = New System.Drawing.Point(582, 35)
            Me.MetroLabelUser.Name = "MetroLabelUser"
            Me.MetroLabelUser.Size = New System.Drawing.Size(315, 23)
            Me.MetroLabelUser.TabIndex = 1
            Me.MetroLabelUser.Text = "User : (none)"
            Me.MetroLabelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'MetroTile1
            '
            Me.MetroTile1.ActiveControl = Nothing
            Me.MetroTile1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroTile1.BackColor = System.Drawing.Color.OrangeRed
            Me.MetroTile1.Enabled = False
            Me.MetroTile1.Location = New System.Drawing.Point(119, 102)
            Me.MetroTile1.Name = "MetroTile1"
            Me.MetroTile1.Size = New System.Drawing.Size(165, 165)
            Me.MetroTile1.TabIndex = 2
            Me.MetroTile1.Text = "Kontak"
            Me.MetroTile1.TileImage = Global.MPOS.Lite.My.Resources.Resources.address_book
            Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.MetroTile1.UseCustomBackColor = True
            Me.MetroTile1.UseSelectable = True
            Me.MetroTile1.UseTileImage = True
            '
            'MetroTile2
            '
            Me.MetroTile2.ActiveControl = Nothing
            Me.MetroTile2.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroTile2.BackColor = System.Drawing.Color.SaddleBrown
            Me.MetroTile2.Enabled = False
            Me.MetroTile2.Location = New System.Drawing.Point(290, 102)
            Me.MetroTile2.Name = "MetroTile2"
            Me.MetroTile2.Size = New System.Drawing.Size(165, 165)
            Me.MetroTile2.TabIndex = 3
            Me.MetroTile2.Text = "Barang"
            Me.MetroTile2.TileImage = Global.MPOS.Lite.My.Resources.Resources.shipment
            Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.MetroTile2.UseCustomBackColor = True
            Me.MetroTile2.UseSelectable = True
            Me.MetroTile2.UseTileImage = True
            '
            'MetroTile3
            '
            Me.MetroTile3.ActiveControl = Nothing
            Me.MetroTile3.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroTile3.BackColor = System.Drawing.Color.Blue
            Me.MetroTile3.Enabled = False
            Me.MetroTile3.Location = New System.Drawing.Point(461, 102)
            Me.MetroTile3.Name = "MetroTile3"
            Me.MetroTile3.Size = New System.Drawing.Size(165, 165)
            Me.MetroTile3.TabIndex = 4
            Me.MetroTile3.Text = "Stok Masuk"
            Me.MetroTile3.TileImage = Global.MPOS.Lite.My.Resources.Resources.factory_add
            Me.MetroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.MetroTile3.UseCustomBackColor = True
            Me.MetroTile3.UseSelectable = True
            Me.MetroTile3.UseTileImage = True
            '
            'MetroTile4
            '
            Me.MetroTile4.ActiveControl = Nothing
            Me.MetroTile4.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroTile4.BackColor = System.Drawing.Color.Orange
            Me.MetroTile4.Enabled = False
            Me.MetroTile4.Location = New System.Drawing.Point(632, 102)
            Me.MetroTile4.Name = "MetroTile4"
            Me.MetroTile4.Size = New System.Drawing.Size(165, 165)
            Me.MetroTile4.TabIndex = 5
            Me.MetroTile4.Text = "Penjualan"
            Me.MetroTile4.TileImage = Global.MPOS.Lite.My.Resources.Resources.graph_sales_coins
            Me.MetroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.MetroTile4.UseCustomBackColor = True
            Me.MetroTile4.UseSelectable = True
            Me.MetroTile4.UseTileImage = True
            '
            'MetroTile5
            '
            Me.MetroTile5.ActiveControl = Nothing
            Me.MetroTile5.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroTile5.BackColor = System.Drawing.Color.Coral
            Me.MetroTile5.Location = New System.Drawing.Point(632, 273)
            Me.MetroTile5.Name = "MetroTile5"
            Me.MetroTile5.Size = New System.Drawing.Size(165, 165)
            Me.MetroTile5.TabIndex = 9
            Me.MetroTile5.Text = "Login"
            Me.MetroTile5.TileImage = Global.MPOS.Lite.My.Resources.Resources.employees_key
            Me.MetroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.MetroTile5.UseCustomBackColor = True
            Me.MetroTile5.UseSelectable = True
            Me.MetroTile5.UseTileImage = True
            '
            'MetroTile6
            '
            Me.MetroTile6.ActiveControl = Nothing
            Me.MetroTile6.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroTile6.BackColor = System.Drawing.Color.Green
            Me.MetroTile6.Enabled = False
            Me.MetroTile6.Location = New System.Drawing.Point(461, 273)
            Me.MetroTile6.Name = "MetroTile6"
            Me.MetroTile6.Size = New System.Drawing.Size(165, 165)
            Me.MetroTile6.TabIndex = 8
            Me.MetroTile6.Text = "Laporan"
            Me.MetroTile6.TileImage = Global.MPOS.Lite.My.Resources.Resources.report_info
            Me.MetroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.MetroTile6.UseCustomBackColor = True
            Me.MetroTile6.UseSelectable = True
            Me.MetroTile6.UseTileImage = True
            '
            'MetroTile7
            '
            Me.MetroTile7.ActiveControl = Nothing
            Me.MetroTile7.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroTile7.BackColor = System.Drawing.Color.DarkBlue
            Me.MetroTile7.Enabled = False
            Me.MetroTile7.Location = New System.Drawing.Point(290, 273)
            Me.MetroTile7.Name = "MetroTile7"
            Me.MetroTile7.Size = New System.Drawing.Size(165, 165)
            Me.MetroTile7.TabIndex = 7
            Me.MetroTile7.Text = "Kartu Stok"
            Me.MetroTile7.TileImage = Global.MPOS.Lite.My.Resources.Resources.inventory_info
            Me.MetroTile7.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.MetroTile7.UseCustomBackColor = True
            Me.MetroTile7.UseSelectable = True
            Me.MetroTile7.UseTileImage = True
            '
            'MetroTile8
            '
            Me.MetroTile8.ActiveControl = Nothing
            Me.MetroTile8.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroTile8.BackColor = System.Drawing.Color.DarkRed
            Me.MetroTile8.Enabled = False
            Me.MetroTile8.Location = New System.Drawing.Point(119, 273)
            Me.MetroTile8.Name = "MetroTile8"
            Me.MetroTile8.Size = New System.Drawing.Size(165, 165)
            Me.MetroTile8.TabIndex = 6
            Me.MetroTile8.Text = "Pelunasan Piutang"
            Me.MetroTile8.TileImage = Global.MPOS.Lite.My.Resources.Resources.money_banknote
            Me.MetroTile8.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.MetroTile8.UseCustomBackColor = True
            Me.MetroTile8.UseSelectable = True
            Me.MetroTile8.UseTileImage = True
            '
            'MetroLabel2
            '
            Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.MetroLabel2.Location = New System.Drawing.Point(20, 470)
            Me.MetroLabel2.Name = "MetroLabel2"
            Me.MetroLabel2.Size = New System.Drawing.Size(877, 19)
            Me.MetroLabel2.TabIndex = 10
            Me.MetroLabel2.Text = "Developer By : Elliteserv"
            Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'frmMain
            '
            Me.BackImage = CType(resources.GetObject("$this.BackImage"), System.Drawing.Image)
            Me.BackImagePadding = New System.Windows.Forms.Padding(220, 10, 0, 0)
            Me.BackMaxSize = 50
            Me.ClientSize = New System.Drawing.Size(917, 541)
            Me.Controls.Add(Me.MetroLabel2)
            Me.Controls.Add(Me.MetroTile5)
            Me.Controls.Add(Me.MetroTile6)
            Me.Controls.Add(Me.MetroTile7)
            Me.Controls.Add(Me.MetroTile8)
            Me.Controls.Add(Me.MetroTile4)
            Me.Controls.Add(Me.MetroTile3)
            Me.Controls.Add(Me.MetroTile2)
            Me.Controls.Add(Me.MetroTile1)
            Me.Controls.Add(Me.MetroLabelUser)
            Me.Controls.Add(Me.MetroPanel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmMain"
            Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
            Me.Style = MetroFramework.MetroColorStyle.[Default]
            Me.Text = "MPOS Lite Ver 1.0"
            Me.Theme = MetroFramework.MetroThemeStyle.[Default]
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.MetroPanel1.ResumeLayout(False)
            Me.MetroPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
        Friend WithEvents cmdLight As MetroFramework.Controls.MetroButton
        Friend WithEvents cmdDark As MetroFramework.Controls.MetroButton
        Friend WithEvents MetroToggleEditReport As MetroFramework.Controls.MetroToggle
        Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabelUser As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
        Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
        Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
        Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
        Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
        Friend WithEvents MetroTile6 As MetroFramework.Controls.MetroTile
        Friend WithEvents MetroTile7 As MetroFramework.Controls.MetroTile
        Friend WithEvents MetroTile8 As MetroFramework.Controls.MetroTile
        Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel

    End Class
End Namespace