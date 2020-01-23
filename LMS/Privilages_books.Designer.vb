<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Privilages_books
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.password_tb = New System.Windows.Forms.TextBox()
        Me.isbn_lbl = New System.Windows.Forms.Label()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 50)
        Me.Panel1.TabIndex = 85
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(365, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(46, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(272, 27)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Administrator Privilages"
        '
        'password_tb
        '
        Me.password_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.password_tb.Location = New System.Drawing.Point(24, 127)
        Me.password_tb.Name = "password_tb"
        Me.password_tb.Size = New System.Drawing.Size(367, 36)
        Me.password_tb.TabIndex = 86
        Me.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'isbn_lbl
        '
        Me.isbn_lbl.AutoSize = True
        Me.isbn_lbl.Location = New System.Drawing.Point(12, 71)
        Me.isbn_lbl.Name = "isbn_lbl"
        Me.isbn_lbl.Size = New System.Drawing.Size(0, 17)
        Me.isbn_lbl.TabIndex = 87
        Me.isbn_lbl.Visible = False
        '
        'username_tb
        '
        Me.username_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.username_tb.Location = New System.Drawing.Point(24, 71)
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(367, 36)
        Me.username_tb.TabIndex = 86
        Me.username_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Privilages_books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 187)
        Me.Controls.Add(Me.username_tb)
        Me.Controls.Add(Me.isbn_lbl)
        Me.Controls.Add(Me.password_tb)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Privilages_books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check_admin_books"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents password_tb As TextBox
    Friend WithEvents isbn_lbl As Label
    Friend WithEvents username_tb As TextBox
    Friend WithEvents Label6 As Label
End Class
