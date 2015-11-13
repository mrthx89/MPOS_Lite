Namespace View
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frmLogin
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
            Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
            Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
            Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
            Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'MetroTextBox1
            '
            Me.MetroTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall
            Me.MetroTextBox1.Lines = New String(-1) {}
            Me.MetroTextBox1.Location = New System.Drawing.Point(180, 63)
            Me.MetroTextBox1.MaxLength = 32767
            Me.MetroTextBox1.Name = "MetroTextBox1"
            Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.MetroTextBox1.PromptText = "Isikan Kode User Anda"
            Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.MetroTextBox1.SelectedText = ""
            Me.MetroTextBox1.Size = New System.Drawing.Size(227, 30)
            Me.MetroTextBox1.TabIndex = 0
            Me.MetroTextBox1.UseSelectable = True
            '
            'MetroTextBox2
            '
            Me.MetroTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall
            Me.MetroTextBox2.Lines = New String(-1) {}
            Me.MetroTextBox2.Location = New System.Drawing.Point(180, 99)
            Me.MetroTextBox2.MaxLength = 32767
            Me.MetroTextBox2.Name = "MetroTextBox2"
            Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
            Me.MetroTextBox2.PromptText = "Isikan Password User Anda"
            Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.MetroTextBox2.SelectedText = ""
            Me.MetroTextBox2.Size = New System.Drawing.Size(227, 30)
            Me.MetroTextBox2.TabIndex = 1
            Me.MetroTextBox2.UseSelectable = True
            '
            'MetroButton1
            '
            Me.MetroButton1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroButton1.Location = New System.Drawing.Point(201, 135)
            Me.MetroButton1.Name = "MetroButton1"
            Me.MetroButton1.Size = New System.Drawing.Size(100, 30)
            Me.MetroButton1.TabIndex = 2
            Me.MetroButton1.Text = "Login"
            Me.MetroButton1.UseSelectable = True
            '
            'MetroButton2
            '
            Me.MetroButton2.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.MetroButton2.Location = New System.Drawing.Point(307, 135)
            Me.MetroButton2.Name = "MetroButton2"
            Me.MetroButton2.Size = New System.Drawing.Size(100, 30)
            Me.MetroButton2.TabIndex = 3
            Me.MetroButton2.Text = "Cancel"
            Me.MetroButton2.UseSelectable = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.PictureBox1.Image = Global.MPOS.Lite.My.Resources.Resources.employees_key
            Me.PictureBox1.Location = New System.Drawing.Point(79, 63)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(95, 102)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 4
            Me.PictureBox1.TabStop = False
            '
            'frmLogin
            '
            Me.ClientSize = New System.Drawing.Size(486, 185)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.MetroButton2)
            Me.Controls.Add(Me.MetroButton1)
            Me.Controls.Add(Me.MetroTextBox2)
            Me.Controls.Add(Me.MetroTextBox1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Movable = False
            Me.Name = "frmLogin"
            Me.Resizable = False
            Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Login Please ..."
            Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
        Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
        Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
        Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

    End Class
End Namespace