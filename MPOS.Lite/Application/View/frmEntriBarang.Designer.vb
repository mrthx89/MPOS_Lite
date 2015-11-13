Namespace View
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmEntriBarang
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
            Me.txtNama = New MetroFramework.Controls.MetroTextBox()
            Me.txtSatuan = New MetroFramework.Controls.MetroTextBox()
            Me.cmdEdit = New MetroFramework.Controls.MetroButton()
            Me.cmdBaru = New MetroFramework.Controls.MetroButton()
            Me.txtKode = New MetroFramework.Controls.MetroTextBox()
            Me.txtHargaJual = New MetroFramework.Controls.MetroTextBox()
            Me.txtHargaBeli = New MetroFramework.Controls.MetroTextBox()
            Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
            Me.txtStok = New MetroFramework.Controls.MetroTextBox()
            Me.SuspendLayout()
            '
            'txtNama
            '
            Me.txtNama.FontSize = MetroFramework.MetroTextBoxSize.Tall
            Me.txtNama.Lines = New String(-1) {}
            Me.txtNama.Location = New System.Drawing.Point(128, 96)
            Me.txtNama.MaxLength = 32767
            Me.txtNama.Name = "txtNama"
            Me.txtNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtNama.PromptText = "Isikan Nama Barang"
            Me.txtNama.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtNama.SelectedText = ""
            Me.txtNama.Size = New System.Drawing.Size(274, 30)
            Me.txtNama.TabIndex = 3
            Me.txtNama.UseSelectable = True
            '
            'txtSatuan
            '
            Me.txtSatuan.FontSize = MetroFramework.MetroTextBoxSize.Tall
            Me.txtSatuan.Lines = New String(-1) {}
            Me.txtSatuan.Location = New System.Drawing.Point(128, 132)
            Me.txtSatuan.MaxLength = 32767
            Me.txtSatuan.Name = "txtSatuan"
            Me.txtSatuan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtSatuan.PromptText = "Isikan Satuan Barang"
            Me.txtSatuan.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtSatuan.SelectedText = ""
            Me.txtSatuan.Size = New System.Drawing.Size(274, 30)
            Me.txtSatuan.TabIndex = 5
            Me.txtSatuan.UseSelectable = True
            '
            'cmdEdit
            '
            Me.cmdEdit.Location = New System.Drawing.Point(302, 305)
            Me.cmdEdit.Name = "cmdEdit"
            Me.cmdEdit.Size = New System.Drawing.Size(100, 25)
            Me.cmdEdit.TabIndex = 13
            Me.cmdEdit.Text = "Batal"
            Me.cmdEdit.UseSelectable = True
            '
            'cmdBaru
            '
            Me.cmdBaru.Location = New System.Drawing.Point(196, 305)
            Me.cmdBaru.Name = "cmdBaru"
            Me.cmdBaru.Size = New System.Drawing.Size(100, 25)
            Me.cmdBaru.TabIndex = 12
            Me.cmdBaru.Text = "Simpan"
            Me.cmdBaru.UseSelectable = True
            '
            'txtKode
            '
            Me.txtKode.FontSize = MetroFramework.MetroTextBoxSize.Tall
            Me.txtKode.Icon = Global.MPOS.Lite.My.Resources.Resources.barcode_ok
            Me.txtKode.Lines = New String(-1) {}
            Me.txtKode.Location = New System.Drawing.Point(128, 60)
            Me.txtKode.MaxLength = 32767
            Me.txtKode.Name = "txtKode"
            Me.txtKode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtKode.PromptText = "Scan Kode Barang"
            Me.txtKode.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtKode.SelectedText = ""
            Me.txtKode.Size = New System.Drawing.Size(274, 30)
            Me.txtKode.TabIndex = 1
            Me.txtKode.UseSelectable = True
            '
            'txtHargaJual
            '
            Me.txtHargaJual.FontSize = MetroFramework.MetroTextBoxSize.Tall
            Me.txtHargaJual.Lines = New String(-1) {}
            Me.txtHargaJual.Location = New System.Drawing.Point(128, 204)
            Me.txtHargaJual.MaxLength = 32767
            Me.txtHargaJual.Name = "txtHargaJual"
            Me.txtHargaJual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtHargaJual.PromptText = "0"
            Me.txtHargaJual.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtHargaJual.SelectedText = ""
            Me.txtHargaJual.Size = New System.Drawing.Size(274, 30)
            Me.txtHargaJual.TabIndex = 9
            Me.txtHargaJual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtHargaJual.UseSelectable = True
            '
            'txtHargaBeli
            '
            Me.txtHargaBeli.FontSize = MetroFramework.MetroTextBoxSize.Tall
            Me.txtHargaBeli.Lines = New String(-1) {}
            Me.txtHargaBeli.Location = New System.Drawing.Point(128, 168)
            Me.txtHargaBeli.MaxLength = 32767
            Me.txtHargaBeli.Name = "txtHargaBeli"
            Me.txtHargaBeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtHargaBeli.PromptText = "0"
            Me.txtHargaBeli.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtHargaBeli.SelectedText = ""
            Me.txtHargaBeli.Size = New System.Drawing.Size(274, 30)
            Me.txtHargaBeli.TabIndex = 7
            Me.txtHargaBeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtHargaBeli.UseSelectable = True
            '
            'MetroLabel1
            '
            Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
            Me.MetroLabel1.Name = "MetroLabel1"
            Me.MetroLabel1.Size = New System.Drawing.Size(99, 30)
            Me.MetroLabel1.TabIndex = 0
            Me.MetroLabel1.Text = "Kode"
            Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MetroLabel2
            '
            Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel2.Location = New System.Drawing.Point(23, 96)
            Me.MetroLabel2.Name = "MetroLabel2"
            Me.MetroLabel2.Size = New System.Drawing.Size(99, 30)
            Me.MetroLabel2.TabIndex = 2
            Me.MetroLabel2.Text = "Nama"
            Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MetroLabel3
            '
            Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel3.Location = New System.Drawing.Point(23, 132)
            Me.MetroLabel3.Name = "MetroLabel3"
            Me.MetroLabel3.Size = New System.Drawing.Size(99, 30)
            Me.MetroLabel3.TabIndex = 4
            Me.MetroLabel3.Text = "Satuan"
            Me.MetroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MetroLabel4
            '
            Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel4.Location = New System.Drawing.Point(23, 168)
            Me.MetroLabel4.Name = "MetroLabel4"
            Me.MetroLabel4.Size = New System.Drawing.Size(99, 30)
            Me.MetroLabel4.TabIndex = 6
            Me.MetroLabel4.Text = "Harga Beli"
            Me.MetroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MetroLabel5
            '
            Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel5.Location = New System.Drawing.Point(23, 204)
            Me.MetroLabel5.Name = "MetroLabel5"
            Me.MetroLabel5.Size = New System.Drawing.Size(99, 30)
            Me.MetroLabel5.TabIndex = 8
            Me.MetroLabel5.Text = "Harga Jual"
            Me.MetroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MetroLabel6
            '
            Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel6.Location = New System.Drawing.Point(23, 240)
            Me.MetroLabel6.Name = "MetroLabel6"
            Me.MetroLabel6.Size = New System.Drawing.Size(99, 30)
            Me.MetroLabel6.TabIndex = 10
            Me.MetroLabel6.Text = "Stok"
            Me.MetroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'txtStok
            '
            Me.txtStok.FontSize = MetroFramework.MetroTextBoxSize.Tall
            Me.txtStok.Lines = New String() {"0"}
            Me.txtStok.Location = New System.Drawing.Point(128, 240)
            Me.txtStok.MaxLength = 32767
            Me.txtStok.Name = "txtStok"
            Me.txtStok.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.txtStok.PromptText = "Isikan Satuan Barang"
            Me.txtStok.ReadOnly = True
            Me.txtStok.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.txtStok.SelectedText = ""
            Me.txtStok.Size = New System.Drawing.Size(274, 30)
            Me.txtStok.TabIndex = 11
            Me.txtStok.Text = "0"
            Me.txtStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
            Me.txtStok.UseSelectable = True
            '
            'frmEntriBarang
            '
            Me.ClientSize = New System.Drawing.Size(425, 353)
            Me.Controls.Add(Me.MetroLabel6)
            Me.Controls.Add(Me.txtStok)
            Me.Controls.Add(Me.MetroLabel5)
            Me.Controls.Add(Me.MetroLabel4)
            Me.Controls.Add(Me.MetroLabel3)
            Me.Controls.Add(Me.MetroLabel2)
            Me.Controls.Add(Me.MetroLabel1)
            Me.Controls.Add(Me.txtHargaJual)
            Me.Controls.Add(Me.txtHargaBeli)
            Me.Controls.Add(Me.txtKode)
            Me.Controls.Add(Me.cmdEdit)
            Me.Controls.Add(Me.cmdBaru)
            Me.Controls.Add(Me.txtSatuan)
            Me.Controls.Add(Me.txtNama)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(425, 353)
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(425, 353)
            Me.Movable = False
            Me.Name = "frmEntriBarang"
            Me.Resizable = False
            Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Entri Barang"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents txtNama As MetroFramework.Controls.MetroTextBox
        Friend WithEvents txtSatuan As MetroFramework.Controls.MetroTextBox
        Friend WithEvents cmdEdit As MetroFramework.Controls.MetroButton
        Friend WithEvents cmdBaru As MetroFramework.Controls.MetroButton
        Friend WithEvents txtKode As MetroFramework.Controls.MetroTextBox
        Friend WithEvents txtHargaJual As MetroFramework.Controls.MetroTextBox
        Friend WithEvents txtHargaBeli As MetroFramework.Controls.MetroTextBox
        Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
        Friend WithEvents txtStok As MetroFramework.Controls.MetroTextBox

    End Class

End Namespace