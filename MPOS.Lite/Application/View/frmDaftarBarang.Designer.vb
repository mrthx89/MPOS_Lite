Namespace View
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDaftarBarang
        Inherits MetroFramework.Forms.MetroForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
            Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
            Me.cmdHapus = New MetroFramework.Controls.MetroButton()
            Me.cmdEdit = New MetroFramework.Controls.MetroButton()
            Me.cmdBaru = New MetroFramework.Controls.MetroButton()
            Me.cmdRefresh = New MetroFramework.Controls.MetroButton()
            Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
            Me.txtCari = New MetroFramework.Controls.MetroTextBox()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MetroPanel1.SuspendLayout()
            Me.MetroPanel2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'MetroGrid1
            '
            Me.MetroGrid1.AllowUserToAddRows = False
            Me.MetroGrid1.AllowUserToDeleteRows = False
            Me.MetroGrid1.AllowUserToResizeRows = False
            Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
            Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.MetroGrid1.ColumnHeadersHeight = 30
            Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.MetroGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
            DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle6
            Me.MetroGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetroGrid1.EnableHeadersVisualStyles = False
            Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.MetroGrid1.Location = New System.Drawing.Point(20, 94)
            Me.MetroGrid1.Name = "MetroGrid1"
            Me.MetroGrid1.ReadOnly = True
            Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
            DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
            Me.MetroGrid1.RowHeadersVisible = False
            Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
            Me.MetroGrid1.RowTemplate.Height = 30
            Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.MetroGrid1.Size = New System.Drawing.Size(910, 254)
            Me.MetroGrid1.TabIndex = 1
            '
            'Column1
            '
            Me.Column1.DataPropertyName = "NoID"
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle2.Format = "N0"
            DataGridViewCellStyle2.NullValue = "0"
            Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
            Me.Column1.HeaderText = "No"
            Me.Column1.Name = "Column1"
            Me.Column1.ReadOnly = True
            Me.Column1.Visible = False
            Me.Column1.Width = 60
            '
            'Column2
            '
            Me.Column2.DataPropertyName = "Kode"
            Me.Column2.HeaderText = "Kode"
            Me.Column2.Name = "Column2"
            Me.Column2.ReadOnly = True
            Me.Column2.Width = 150
            '
            'Column3
            '
            Me.Column3.DataPropertyName = "Nama"
            Me.Column3.HeaderText = "Nama"
            Me.Column3.Name = "Column3"
            Me.Column3.ReadOnly = True
            Me.Column3.Width = 200
            '
            'Column4
            '
            Me.Column4.DataPropertyName = "Satuan"
            Me.Column4.HeaderText = "Satuan"
            Me.Column4.Name = "Column4"
            Me.Column4.ReadOnly = True
            Me.Column4.Width = 70
            '
            'Column5
            '
            Me.Column5.DataPropertyName = "HargaBeli"
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle3.Format = "N0"
            DataGridViewCellStyle3.NullValue = "0"
            Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
            Me.Column5.HeaderText = "Harga Beli"
            Me.Column5.Name = "Column5"
            Me.Column5.ReadOnly = True
            Me.Column5.Width = 150
            '
            'Column6
            '
            Me.Column6.DataPropertyName = "HargaJual"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle4.Format = "N0"
            DataGridViewCellStyle4.NullValue = "0"
            Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
            Me.Column6.HeaderText = "Harga Jual"
            Me.Column6.Name = "Column6"
            Me.Column6.ReadOnly = True
            Me.Column6.Width = 150
            '
            'Column7
            '
            Me.Column7.DataPropertyName = "Stok"
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
            DataGridViewCellStyle5.Format = "N0"
            DataGridViewCellStyle5.NullValue = "0"
            Me.Column7.DefaultCellStyle = DataGridViewCellStyle5
            Me.Column7.HeaderText = "Stok"
            Me.Column7.Name = "Column7"
            Me.Column7.ReadOnly = True
            Me.Column7.Width = 70
            '
            'MetroPanel1
            '
            Me.MetroPanel1.Controls.Add(Me.cmdHapus)
            Me.MetroPanel1.Controls.Add(Me.cmdEdit)
            Me.MetroPanel1.Controls.Add(Me.cmdBaru)
            Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.MetroPanel1.HorizontalScrollbarBarColor = True
            Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
            Me.MetroPanel1.HorizontalScrollbarSize = 10
            Me.MetroPanel1.Location = New System.Drawing.Point(20, 348)
            Me.MetroPanel1.Name = "MetroPanel1"
            Me.MetroPanel1.Size = New System.Drawing.Size(910, 32)
            Me.MetroPanel1.TabIndex = 2
            Me.MetroPanel1.VerticalScrollbarBarColor = True
            Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
            Me.MetroPanel1.VerticalScrollbarSize = 10
            '
            'cmdHapus
            '
            Me.cmdHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmdHapus.Location = New System.Drawing.Point(807, 3)
            Me.cmdHapus.Name = "cmdHapus"
            Me.cmdHapus.Size = New System.Drawing.Size(100, 25)
            Me.cmdHapus.TabIndex = 2
            Me.cmdHapus.Text = "Hapus"
            Me.cmdHapus.UseSelectable = True
            '
            'cmdEdit
            '
            Me.cmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmdEdit.Location = New System.Drawing.Point(701, 3)
            Me.cmdEdit.Name = "cmdEdit"
            Me.cmdEdit.Size = New System.Drawing.Size(100, 25)
            Me.cmdEdit.TabIndex = 1
            Me.cmdEdit.Text = "Edit"
            Me.cmdEdit.UseSelectable = True
            '
            'cmdBaru
            '
            Me.cmdBaru.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmdBaru.Location = New System.Drawing.Point(595, 3)
            Me.cmdBaru.Name = "cmdBaru"
            Me.cmdBaru.Size = New System.Drawing.Size(100, 25)
            Me.cmdBaru.TabIndex = 0
            Me.cmdBaru.Text = "Baru"
            Me.cmdBaru.UseSelectable = True
            '
            'cmdRefresh
            '
            Me.cmdRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cmdRefresh.Location = New System.Drawing.Point(807, 3)
            Me.cmdRefresh.Name = "cmdRefresh"
            Me.cmdRefresh.Size = New System.Drawing.Size(100, 25)
            Me.cmdRefresh.TabIndex = 1
            Me.cmdRefresh.Text = "Refresh"
            Me.cmdRefresh.UseSelectable = True
            '
            'MetroPanel2
            '
            Me.MetroPanel2.Controls.Add(Me.txtCari)
            Me.MetroPanel2.Controls.Add(Me.cmdRefresh)
            Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.MetroPanel2.HorizontalScrollbarBarColor = True
            Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
            Me.MetroPanel2.HorizontalScrollbarSize = 10
            Me.MetroPanel2.Location = New System.Drawing.Point(20, 60)
            Me.MetroPanel2.Name = "MetroPanel2"
            Me.MetroPanel2.Size = New System.Drawing.Size(910, 34)
            Me.MetroPanel2.TabIndex = 0
            Me.MetroPanel2.VerticalScrollbarBarColor = True
            Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
            Me.MetroPanel2.VerticalScrollbarSize = 10
            '
            'txtCari
            '
            Me.txtCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtCari.FontSize = MetroFramework.MetroTextBoxSize.Medium
            Me.txtCari.Icon = Global.MPOS.Lite.My.Resources.Resources.find
            Me.txtCari.Lines = New String(-1) {}
            Me.txtCari.Location = New System.Drawing.Point(595, 3)
            Me.txtCari.MaxLength = 32767
            Me.txtCari.Name = "txtCari"
            Me.txtCari.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtCari.PromptText = "Cari"
            Me.txtCari.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtCari.SelectedText = ""
            Me.txtCari.Size = New System.Drawing.Size(213, 25)
            Me.txtCari.TabIndex = 0
            Me.txtCari.UseSelectable = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.PictureBox1.Image = Global.MPOS.Lite.My.Resources.Resources.nav_blue_left
            Me.PictureBox1.Location = New System.Drawing.Point(20, 14)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(50, 40)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 0
            Me.PictureBox1.TabStop = False
            '
            'frmBarang
            '
            Me.BackImagePadding = New System.Windows.Forms.Padding(5, 20, 0, 0)
            Me.ClientSize = New System.Drawing.Size(950, 400)
            Me.Controls.Add(Me.MetroGrid1)
            Me.Controls.Add(Me.MetroPanel2)
            Me.Controls.Add(Me.MetroPanel1)
            Me.Controls.Add(Me.PictureBox1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Movable = False
            Me.Name = "frmBarang"
            Me.Resizable = False
            Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
            Me.ShowInTaskbar = False
            Me.Text = "Daftar Master Barang"
            Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Right
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MetroPanel1.ResumeLayout(False)
            Me.MetroPanel2.ResumeLayout(False)
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
        Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
        Friend WithEvents cmdEdit As MetroFramework.Controls.MetroButton
        Friend WithEvents cmdBaru As MetroFramework.Controls.MetroButton
        Friend WithEvents cmdHapus As MetroFramework.Controls.MetroButton
        Friend WithEvents cmdRefresh As MetroFramework.Controls.MetroButton
        Friend WithEvents txtCari As MetroFramework.Controls.MetroTextBox
        Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
        Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace