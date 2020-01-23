<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Restorefinal
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
        Me.isbn_tb = New System.Windows.Forms.TextBox()
        Me.indexno_tb = New System.Windows.Forms.TextBox()
        Me.issueid_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmd_change = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bookname_tb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.days_tb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fines_tb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.quantity_tb = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'isbn_tb
        '
        Me.isbn_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbn_tb.Location = New System.Drawing.Point(186, 169)
        Me.isbn_tb.MaxLength = 50
        Me.isbn_tb.Name = "isbn_tb"
        Me.isbn_tb.ReadOnly = True
        Me.isbn_tb.Size = New System.Drawing.Size(288, 31)
        Me.isbn_tb.TabIndex = 120
        '
        'indexno_tb
        '
        Me.indexno_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indexno_tb.Location = New System.Drawing.Point(186, 123)
        Me.indexno_tb.MaxLength = 50
        Me.indexno_tb.Name = "indexno_tb"
        Me.indexno_tb.ReadOnly = True
        Me.indexno_tb.Size = New System.Drawing.Size(288, 31)
        Me.indexno_tb.TabIndex = 119
        '
        'issueid_tb
        '
        Me.issueid_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issueid_tb.Location = New System.Drawing.Point(186, 77)
        Me.issueid_tb.MaxLength = 30
        Me.issueid_tb.Name = "issueid_tb"
        Me.issueid_tb.ReadOnly = True
        Me.issueid_tb.Size = New System.Drawing.Size(230, 31)
        Me.issueid_tb.TabIndex = 130
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 22)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 22)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "Index No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 22)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "Issue ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 50)
        Me.Panel1.TabIndex = 2
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
        Me.Button1.Location = New System.Drawing.Point(450, 6)
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
        Me.Label6.Size = New System.Drawing.Size(170, 27)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Restore Books"
        '
        'Cmd_change
        '
        Me.Cmd_change.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_change.BackColor = System.Drawing.Color.DodgerBlue
        Me.Cmd_change.FlatAppearance.BorderSize = 0
        Me.Cmd_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_change.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_change.ForeColor = System.Drawing.Color.White
        Me.Cmd_change.Location = New System.Drawing.Point(382, 423)
        Me.Cmd_change.Name = "Cmd_change"
        Me.Cmd_change.Size = New System.Drawing.Size(92, 34)
        Me.Cmd_change.TabIndex = 1
        Me.Cmd_change.Text = "RESTORE"
        Me.Cmd_change.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 22)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "Book Name"
        '
        'bookname_tb
        '
        Me.bookname_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookname_tb.Location = New System.Drawing.Point(186, 215)
        Me.bookname_tb.MaxLength = 50
        Me.bookname_tb.Name = "bookname_tb"
        Me.bookname_tb.ReadOnly = True
        Me.bookname_tb.Size = New System.Drawing.Size(288, 30)
        Me.bookname_tb.TabIndex = 120
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 22)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Extra Days"
        '
        'days_tb
        '
        Me.days_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.days_tb.Location = New System.Drawing.Point(186, 261)
        Me.days_tb.MaxLength = 50
        Me.days_tb.Name = "days_tb"
        Me.days_tb.ReadOnly = True
        Me.days_tb.Size = New System.Drawing.Size(122, 31)
        Me.days_tb.TabIndex = 120
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 22)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Fines"
        '
        'fines_tb
        '
        Me.fines_tb.Font = New System.Drawing.Font("Consolas", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fines_tb.Location = New System.Drawing.Point(186, 354)
        Me.fines_tb.MaxLength = 50
        Me.fines_tb.Name = "fines_tb"
        Me.fines_tb.ReadOnly = True
        Me.fines_tb.Size = New System.Drawing.Size(122, 46)
        Me.fines_tb.TabIndex = 120
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 22)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "Issued Book(s)"
        '
        'quantity_tb
        '
        Me.quantity_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_tb.Location = New System.Drawing.Point(186, 307)
        Me.quantity_tb.MaxLength = 50
        Me.quantity_tb.Name = "quantity_tb"
        Me.quantity_tb.ReadOnly = True
        Me.quantity_tb.Size = New System.Drawing.Size(122, 31)
        Me.quantity_tb.TabIndex = 120
        '
        'Restorefinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 480)
        Me.Controls.Add(Me.fines_tb)
        Me.Controls.Add(Me.quantity_tb)
        Me.Controls.Add(Me.days_tb)
        Me.Controls.Add(Me.bookname_tb)
        Me.Controls.Add(Me.isbn_tb)
        Me.Controls.Add(Me.indexno_tb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.issueid_tb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Cmd_change)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Restorefinal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restorefinal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents isbn_tb As TextBox
    Friend WithEvents indexno_tb As TextBox
    Friend WithEvents issueid_tb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Cmd_change As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents bookname_tb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents days_tb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents fines_tb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents quantity_tb As TextBox
End Class
