<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_user
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
        Me.address_tb = New System.Windows.Forms.TextBox()
        Me.tp_tb = New System.Windows.Forms.TextBox()
        Me.lname_tb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.type_cb = New System.Windows.Forms.ComboBox()
        Me.fname_tb = New System.Windows.Forms.TextBox()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmd_modify = New System.Windows.Forms.Button()
        Me.pw_tb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cpw_tb = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'address_tb
        '
        Me.address_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_tb.Location = New System.Drawing.Point(210, 287)
        Me.address_tb.MaxLength = 150
        Me.address_tb.Multiline = True
        Me.address_tb.Name = "address_tb"
        Me.address_tb.Size = New System.Drawing.Size(288, 57)
        Me.address_tb.TabIndex = 5
        '
        'tp_tb
        '
        Me.tp_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp_tb.Location = New System.Drawing.Point(210, 356)
        Me.tp_tb.MaxLength = 10
        Me.tp_tb.Name = "tp_tb"
        Me.tp_tb.Size = New System.Drawing.Size(288, 30)
        Me.tp_tb.TabIndex = 6
        '
        'lname_tb
        '
        Me.lname_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname_tb.Location = New System.Drawing.Point(210, 245)
        Me.lname_tb.MaxLength = 50
        Me.lname_tb.Name = "lname_tb"
        Me.lname_tb.Size = New System.Drawing.Size(288, 30)
        Me.lname_tb.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 22)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "TP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 22)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Last Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 22)
        Me.Label7.TabIndex = 148
        Me.Label7.Text = "First Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 50)
        Me.Panel1.TabIndex = 9
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
        Me.Button1.Location = New System.Drawing.Point(479, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(203, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 27)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Add User"
        '
        'type_cb
        '
        Me.type_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.type_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.type_cb.FormattingEnabled = True
        Me.type_cb.Items.AddRange(New Object() {"admin", "moderator"})
        Me.type_cb.Location = New System.Drawing.Point(210, 398)
        Me.type_cb.Name = "type_cb"
        Me.type_cb.Size = New System.Drawing.Size(288, 33)
        Me.type_cb.TabIndex = 7
        '
        'fname_tb
        '
        Me.fname_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname_tb.Location = New System.Drawing.Point(210, 203)
        Me.fname_tb.MaxLength = 50
        Me.fname_tb.Name = "fname_tb"
        Me.fname_tb.Size = New System.Drawing.Size(288, 30)
        Me.fname_tb.TabIndex = 3
        '
        'username_tb
        '
        Me.username_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_tb.Location = New System.Drawing.Point(210, 76)
        Me.username_tb.MaxLength = 50
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(288, 31)
        Me.username_tb.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 403)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 22)
        Me.Label9.TabIndex = 153
        Me.Label9.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 22)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "Username"
        '
        'Cmd_modify
        '
        Me.Cmd_modify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_modify.BackColor = System.Drawing.Color.LimeGreen
        Me.Cmd_modify.FlatAppearance.BorderSize = 0
        Me.Cmd_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_modify.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_modify.ForeColor = System.Drawing.Color.White
        Me.Cmd_modify.Location = New System.Drawing.Point(406, 454)
        Me.Cmd_modify.Name = "Cmd_modify"
        Me.Cmd_modify.Size = New System.Drawing.Size(91, 34)
        Me.Cmd_modify.TabIndex = 8
        Me.Cmd_modify.Text = "ADD"
        Me.Cmd_modify.UseVisualStyleBackColor = False
        '
        'pw_tb
        '
        Me.pw_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pw_tb.Location = New System.Drawing.Point(209, 119)
        Me.pw_tb.MaxLength = 50
        Me.pw_tb.Name = "pw_tb"
        Me.pw_tb.Size = New System.Drawing.Size(288, 30)
        Me.pw_tb.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 22)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 22)
        Me.Label8.TabIndex = 149
        Me.Label8.Text = "Password Again"
        '
        'cpw_tb
        '
        Me.cpw_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpw_tb.Location = New System.Drawing.Point(209, 161)
        Me.cpw_tb.MaxLength = 50
        Me.cpw_tb.Name = "cpw_tb"
        Me.cpw_tb.Size = New System.Drawing.Size(288, 30)
        Me.cpw_tb.TabIndex = 2
        '
        'New_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 513)
        Me.Controls.Add(Me.address_tb)
        Me.Controls.Add(Me.tp_tb)
        Me.Controls.Add(Me.cpw_tb)
        Me.Controls.Add(Me.lname_tb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pw_tb)
        Me.Controls.Add(Me.type_cb)
        Me.Controls.Add(Me.fname_tb)
        Me.Controls.Add(Me.username_tb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmd_modify)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "New_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New_user"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents address_tb As TextBox
    Friend WithEvents tp_tb As TextBox
    Friend WithEvents lname_tb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents type_cb As ComboBox
    Friend WithEvents fname_tb As TextBox
    Friend WithEvents username_tb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmd_modify As Button
    Friend WithEvents pw_tb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cpw_tb As TextBox
End Class
