Namespace View
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmEntriKontak
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
            Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
            Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
            Me.cmdEdit = New MetroFramework.Controls.MetroButton()
            Me.cmdBaru = New MetroFramework.Controls.MetroButton()
            Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
            Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
            Me.SuspendLayout()
            '
            'MetroTextBox1
            '
            Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
            Me.MetroTextBox1.Lines = New String(-1) {}
            Me.MetroTextBox1.Location = New System.Drawing.Point(108, 63)
            Me.MetroTextBox1.MaxLength = 32767
            Me.MetroTextBox1.Name = "MetroTextBox1"
            Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.MetroTextBox1.PromptText = "Isikan Nama Kontak"
            Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.MetroTextBox1.SelectedText = ""
            Me.MetroTextBox1.Size = New System.Drawing.Size(263, 30)
            Me.MetroTextBox1.TabIndex = 1
            Me.MetroTextBox1.UseSelectable = True
            '
            'MetroTextBox2
            '
            Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall
            Me.MetroTextBox2.Lines = New String(-1) {}
            Me.MetroTextBox2.Location = New System.Drawing.Point(108, 99)
            Me.MetroTextBox2.MaxLength = 32767
            Me.MetroTextBox2.Name = "MetroTextBox2"
            Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.MetroTextBox2.PromptText = "Isikan Alamat Kontak"
            Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.MetroTextBox2.SelectedText = ""
            Me.MetroTextBox2.Size = New System.Drawing.Size(263, 30)
            Me.MetroTextBox2.TabIndex = 2
            Me.MetroTextBox2.UseSelectable = True
            '
            'cmdEdit
            '
            Me.cmdEdit.Location = New System.Drawing.Point(271, 136)
            Me.cmdEdit.Name = "cmdEdit"
            Me.cmdEdit.Size = New System.Drawing.Size(100, 25)
            Me.cmdEdit.TabIndex = 4
            Me.cmdEdit.Text = "Batal"
            Me.cmdEdit.UseSelectable = True
            '
            'cmdBaru
            '
            Me.cmdBaru.Location = New System.Drawing.Point(165, 136)
            Me.cmdBaru.Name = "cmdBaru"
            Me.cmdBaru.Size = New System.Drawing.Size(100, 25)
            Me.cmdBaru.TabIndex = 3
            Me.cmdBaru.Text = "Simpan"
            Me.cmdBaru.UseSelectable = True
            '
            'MetroLabel1
            '
            Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel1.Location = New System.Drawing.Point(23, 63)
            Me.MetroLabel1.Name = "MetroLabel1"
            Me.MetroLabel1.Size = New System.Drawing.Size(79, 30)
            Me.MetroLabel1.TabIndex = 5
            Me.MetroLabel1.Text = "Nama"
            Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MetroLabel2
            '
            Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.MetroLabel2.Location = New System.Drawing.Point(23, 99)
            Me.MetroLabel2.Name = "MetroLabel2"
            Me.MetroLabel2.Size = New System.Drawing.Size(79, 30)
            Me.MetroLabel2.TabIndex = 6
            Me.MetroLabel2.Text = "Alamat"
            Me.MetroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'frmEntriKontak
            '
            Me.ClientSize = New System.Drawing.Size(394, 184)
            Me.Controls.Add(Me.MetroLabel2)
            Me.Controls.Add(Me.MetroLabel1)
            Me.Controls.Add(Me.cmdEdit)
            Me.Controls.Add(Me.cmdBaru)
            Me.Controls.Add(Me.MetroTextBox2)
            Me.Controls.Add(Me.MetroTextBox1)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(394, 184)
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(394, 184)
            Me.Movable = False
            Me.Name = "frmEntriKontak"
            Me.Resizable = False
            Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Entri Kontak"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
        Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
        Friend WithEvents cmdEdit As MetroFramework.Controls.MetroButton
        Friend WithEvents cmdBaru As MetroFramework.Controls.MetroButton
        Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
        Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel

    End Class

End Namespace