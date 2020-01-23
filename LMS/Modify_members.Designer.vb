<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Modify_members
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
        Me.Cmd_modify = New System.Windows.Forms.Button()
        Me.category_cb = New System.Windows.Forms.ComboBox()
        Me.address_tb = New System.Windows.Forms.TextBox()
        Me.renew_tb = New System.Windows.Forms.TextBox()
        Me.fee_tb = New System.Windows.Forms.TextBox()
        Me.email_tb = New System.Windows.Forms.TextBox()
        Me.lname_tb = New System.Windows.Forms.TextBox()
        Me.fname_tb = New System.Windows.Forms.TextBox()
        Me.index_tb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cmd_change = New System.Windows.Forms.Button()
        Me.category_tb = New System.Windows.Forms.TextBox()
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
        Me.Panel1.Size = New System.Drawing.Size(466, 50)
        Me.Panel1.TabIndex = 96
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
        Me.Button1.Location = New System.Drawing.Point(416, 6)
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
        Me.Label6.Location = New System.Drawing.Point(128, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 30)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Modify Members"
        '
        'Cmd_modify
        '
        Me.Cmd_modify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_modify.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_modify.FlatAppearance.BorderSize = 0
        Me.Cmd_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_modify.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_modify.ForeColor = System.Drawing.Color.White
        Me.Cmd_modify.Location = New System.Drawing.Point(350, 483)
        Me.Cmd_modify.Name = "Cmd_modify"
        Me.Cmd_modify.Size = New System.Drawing.Size(91, 34)
        Me.Cmd_modify.TabIndex = 5
        Me.Cmd_modify.Text = "MODIFY"
        Me.Cmd_modify.UseVisualStyleBackColor = False
        '
        'category_cb
        '
        Me.category_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.category_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.category_cb.FormattingEnabled = True
        Me.category_cb.Items.AddRange(New Object() {"Student", "Others"})
        Me.category_cb.Location = New System.Drawing.Point(148, 330)
        Me.category_cb.Name = "category_cb"
        Me.category_cb.Size = New System.Drawing.Size(196, 33)
        Me.category_cb.TabIndex = 4
        Me.category_cb.Visible = False
        '
        'address_tb
        '
        Me.address_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_tb.Location = New System.Drawing.Point(148, 213)
        Me.address_tb.MaxLength = 50
        Me.address_tb.Multiline = True
        Me.address_tb.Name = "address_tb"
        Me.address_tb.Size = New System.Drawing.Size(288, 57)
        Me.address_tb.TabIndex = 2
        '
        'renew_tb
        '
        Me.renew_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.renew_tb.Location = New System.Drawing.Point(148, 378)
        Me.renew_tb.MaxLength = 70
        Me.renew_tb.Name = "renew_tb"
        Me.renew_tb.ReadOnly = True
        Me.renew_tb.Size = New System.Drawing.Size(288, 32)
        Me.renew_tb.TabIndex = 106
        '
        'fee_tb
        '
        Me.fee_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fee_tb.Location = New System.Drawing.Point(182, 423)
        Me.fee_tb.MaxLength = 70
        Me.fee_tb.Name = "fee_tb"
        Me.fee_tb.ReadOnly = True
        Me.fee_tb.Size = New System.Drawing.Size(254, 32)
        Me.fee_tb.TabIndex = 107
        '
        'email_tb
        '
        Me.email_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_tb.Location = New System.Drawing.Point(148, 285)
        Me.email_tb.MaxLength = 70
        Me.email_tb.Name = "email_tb"
        Me.email_tb.Size = New System.Drawing.Size(288, 32)
        Me.email_tb.TabIndex = 3
        '
        'lname_tb
        '
        Me.lname_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname_tb.Location = New System.Drawing.Point(148, 168)
        Me.lname_tb.MaxLength = 50
        Me.lname_tb.Name = "lname_tb"
        Me.lname_tb.Size = New System.Drawing.Size(288, 32)
        Me.lname_tb.TabIndex = 1
        '
        'fname_tb
        '
        Me.fname_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname_tb.Location = New System.Drawing.Point(148, 123)
        Me.fname_tb.MaxLength = 50
        Me.fname_tb.Name = "fname_tb"
        Me.fname_tb.Size = New System.Drawing.Size(288, 32)
        Me.fname_tb.TabIndex = 0
        '
        'index_tb
        '
        Me.index_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.index_tb.Location = New System.Drawing.Point(148, 77)
        Me.index_tb.MaxLength = 30
        Me.index_tb.Name = "index_tb"
        Me.index_tb.ReadOnly = True
        Me.index_tb.Size = New System.Drawing.Size(223, 31)
        Me.index_tb.TabIndex = 109
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 381)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 24)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "Renew Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 24)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(143, 424)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 27)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Rs. "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 426)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 24)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "Fee"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Category"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 24)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "E-Mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "First Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 24)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "Index No"
        '
        'Cmd_change
        '
        Me.Cmd_change.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_change.BackColor = System.Drawing.Color.DodgerBlue
        Me.Cmd_change.FlatAppearance.BorderSize = 0
        Me.Cmd_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_change.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_change.ForeColor = System.Drawing.Color.White
        Me.Cmd_change.Location = New System.Drawing.Point(350, 329)
        Me.Cmd_change.Name = "Cmd_change"
        Me.Cmd_change.Size = New System.Drawing.Size(86, 34)
        Me.Cmd_change.TabIndex = 5
        Me.Cmd_change.Text = "CHANGE"
        Me.Cmd_change.UseVisualStyleBackColor = False
        '
        'category_tb
        '
        Me.category_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_tb.Location = New System.Drawing.Point(148, 332)
        Me.category_tb.MaxLength = 70
        Me.category_tb.Name = "category_tb"
        Me.category_tb.ReadOnly = True
        Me.category_tb.Size = New System.Drawing.Size(196, 32)
        Me.category_tb.TabIndex = 3
        '
        'Modify_members
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 528)
        Me.Controls.Add(Me.address_tb)
        Me.Controls.Add(Me.renew_tb)
        Me.Controls.Add(Me.fee_tb)
        Me.Controls.Add(Me.email_tb)
        Me.Controls.Add(Me.lname_tb)
        Me.Controls.Add(Me.fname_tb)
        Me.Controls.Add(Me.index_tb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Cmd_change)
        Me.Controls.Add(Me.Cmd_modify)
        Me.Controls.Add(Me.category_tb)
        Me.Controls.Add(Me.category_cb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Modify_members"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify_members"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Cmd_modify As Button
    Friend WithEvents category_cb As ComboBox
    Friend WithEvents address_tb As TextBox
    Friend WithEvents renew_tb As TextBox
    Friend WithEvents fee_tb As TextBox
    Friend WithEvents email_tb As TextBox
    Friend WithEvents lname_tb As TextBox
    Friend WithEvents fname_tb As TextBox
    Friend WithEvents index_tb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Cmd_change As Button
    Friend WithEvents category_tb As TextBox
End Class
