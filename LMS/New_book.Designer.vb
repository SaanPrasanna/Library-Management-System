﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class New_book
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.category_tb = New System.Windows.Forms.TextBox()
        Me.author_tb = New System.Windows.Forms.TextBox()
        Me.publisher_tb = New System.Windows.Forms.TextBox()
        Me.bn_tb = New System.Windows.Forms.TextBox()
        Me.isbn_tb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_add = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 50)
        Me.Panel1.TabIndex = 6
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
        Me.Button1.Location = New System.Drawing.Point(426, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(26, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 30)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "New Book"
        '
        'category_tb
        '
        Me.category_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_tb.Location = New System.Drawing.Point(154, 262)
        Me.category_tb.MaxLength = 50
        Me.category_tb.Name = "category_tb"
        Me.category_tb.Size = New System.Drawing.Size(138, 30)
        Me.category_tb.TabIndex = 4
        '
        'author_tb
        '
        Me.author_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author_tb.Location = New System.Drawing.Point(154, 217)
        Me.author_tb.MaxLength = 100
        Me.author_tb.Name = "author_tb"
        Me.author_tb.Size = New System.Drawing.Size(288, 30)
        Me.author_tb.TabIndex = 3
        '
        'publisher_tb
        '
        Me.publisher_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisher_tb.Location = New System.Drawing.Point(154, 172)
        Me.publisher_tb.MaxLength = 100
        Me.publisher_tb.Name = "publisher_tb"
        Me.publisher_tb.Size = New System.Drawing.Size(288, 30)
        Me.publisher_tb.TabIndex = 2
        '
        'bn_tb
        '
        Me.bn_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bn_tb.Location = New System.Drawing.Point(154, 127)
        Me.bn_tb.MaxLength = 70
        Me.bn_tb.Name = "bn_tb"
        Me.bn_tb.Size = New System.Drawing.Size(288, 30)
        Me.bn_tb.TabIndex = 1
        '
        'isbn_tb
        '
        Me.isbn_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbn_tb.Location = New System.Drawing.Point(154, 82)
        Me.isbn_tb.MaxLength = 30
        Me.isbn_tb.Name = "isbn_tb"
        Me.isbn_tb.Size = New System.Drawing.Size(223, 30)
        Me.isbn_tb.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Author"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Publisher"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Book Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ISBN"
        '
        'cmd_add
        '
        Me.cmd_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmd_add.FlatAppearance.BorderSize = 0
        Me.cmd_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_add.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_add.ForeColor = System.Drawing.Color.White
        Me.cmd_add.Location = New System.Drawing.Point(357, 314)
        Me.cmd_add.Name = "cmd_add"
        Me.cmd_add.Size = New System.Drawing.Size(91, 34)
        Me.cmd_add.TabIndex = 5
        Me.cmd_add.Text = "ADD"
        Me.cmd_add.UseVisualStyleBackColor = False
        '
        'New_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 370)
        Me.Controls.Add(Me.cmd_add)
        Me.Controls.Add(Me.category_tb)
        Me.Controls.Add(Me.author_tb)
        Me.Controls.Add(Me.publisher_tb)
        Me.Controls.Add(Me.bn_tb)
        Me.Controls.Add(Me.isbn_tb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "New_book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New_book"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents category_tb As TextBox
    Friend WithEvents author_tb As TextBox
    Friend WithEvents publisher_tb As TextBox
    Friend WithEvents bn_tb As TextBox
    Friend WithEvents isbn_tb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmd_add As Button
End Class