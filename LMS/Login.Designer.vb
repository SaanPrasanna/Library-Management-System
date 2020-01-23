<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Cmd_exit = New System.Windows.Forms.Button()
        Me.Cmd_login = New System.Windows.Forms.Button()
        Me.Username_tb = New System.Windows.Forms.TextBox()
        Me.Password_tb = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 46)
        Me.Panel1.TabIndex = 0
        '
        'Cmd_exit
        '
        Me.Cmd_exit.BackColor = System.Drawing.Color.OrangeRed
        Me.Cmd_exit.FlatAppearance.BorderSize = 0
        Me.Cmd_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.Cmd_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_exit.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_exit.Location = New System.Drawing.Point(338, 163)
        Me.Cmd_exit.Name = "Cmd_exit"
        Me.Cmd_exit.Size = New System.Drawing.Size(130, 42)
        Me.Cmd_exit.TabIndex = 3
        Me.Cmd_exit.Text = "Exit"
        Me.Cmd_exit.UseVisualStyleBackColor = False
        '
        'Cmd_login
        '
        Me.Cmd_login.BackColor = System.Drawing.Color.LimeGreen
        Me.Cmd_login.FlatAppearance.BorderSize = 0
        Me.Cmd_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_login.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Cmd_login.Location = New System.Drawing.Point(190, 163)
        Me.Cmd_login.Name = "Cmd_login"
        Me.Cmd_login.Size = New System.Drawing.Size(130, 42)
        Me.Cmd_login.TabIndex = 2
        Me.Cmd_login.Text = "Log In"
        Me.Cmd_login.UseVisualStyleBackColor = False
        '
        'Username_tb
        '
        Me.Username_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Username_tb.Location = New System.Drawing.Point(190, 75)
        Me.Username_tb.Name = "Username_tb"
        Me.Username_tb.Size = New System.Drawing.Size(278, 30)
        Me.Username_tb.TabIndex = 0
        Me.Username_tb.Text = "Enter Username"
        Me.Username_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Password_tb
        '
        Me.Password_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Password_tb.Location = New System.Drawing.Point(190, 115)
        Me.Password_tb.Name = "Password_tb"
        Me.Password_tb.Size = New System.Drawing.Size(278, 30)
        Me.Password_tb.TabIndex = 1
        Me.Password_tb.Text = "Enter Password"
        Me.Password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LMS.My.Resources.Resources.login
        Me.PictureBox1.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 219)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Password_tb)
        Me.Controls.Add(Me.Username_tb)
        Me.Controls.Add(Me.Cmd_login)
        Me.Controls.Add(Me.Cmd_exit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cmd_exit As Button
    Friend WithEvents Cmd_login As Button
    Friend WithEvents Username_tb As TextBox
    Friend WithEvents Password_tb As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
