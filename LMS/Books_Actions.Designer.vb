<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Books_Actions
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.searchbox_tb = New System.Windows.Forms.TextBox()
        Me.Cmd_save = New System.Windows.Forms.Button()
        Me.action_cb = New System.Windows.Forms.ComboBox()
        Me.reason_tb = New System.Windows.Forms.TextBox()
        Me.quantity_tb = New System.Windows.Forms.TextBox()
        Me.category_tb = New System.Windows.Forms.TextBox()
        Me.aq_tb = New System.Windows.Forms.TextBox()
        Me.tq_tb = New System.Windows.Forms.TextBox()
        Me.author_tb = New System.Windows.Forms.TextBox()
        Me.publisher_tb = New System.Windows.Forms.TextBox()
        Me.isnb_tb = New System.Windows.Forms.TextBox()
        Me.bookname_tb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView_ba = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_ba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchbox_tb
        '
        Me.searchbox_tb.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbox_tb.Location = New System.Drawing.Point(12, 59)
        Me.searchbox_tb.Name = "searchbox_tb"
        Me.searchbox_tb.Size = New System.Drawing.Size(359, 27)
        Me.searchbox_tb.TabIndex = 4
        Me.searchbox_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cmd_save
        '
        Me.Cmd_save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Cmd_save.BackColor = System.Drawing.Color.DodgerBlue
        Me.Cmd_save.FlatAppearance.BorderSize = 0
        Me.Cmd_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_save.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_save.ForeColor = System.Drawing.Color.White
        Me.Cmd_save.Location = New System.Drawing.Point(1212, 597)
        Me.Cmd_save.Name = "Cmd_save"
        Me.Cmd_save.Size = New System.Drawing.Size(91, 34)
        Me.Cmd_save.TabIndex = 2
        Me.Cmd_save.Text = "SAVE"
        Me.Cmd_save.UseVisualStyleBackColor = False
        '
        'action_cb
        '
        Me.action_cb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.action_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.action_cb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.action_cb.FormattingEnabled = True
        Me.action_cb.Items.AddRange(New Object() {"Added", "Removed"})
        Me.action_cb.Location = New System.Drawing.Point(1046, 422)
        Me.action_cb.Name = "action_cb"
        Me.action_cb.Size = New System.Drawing.Size(211, 30)
        Me.action_cb.TabIndex = 74
        '
        'reason_tb
        '
        Me.reason_tb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.reason_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reason_tb.Location = New System.Drawing.Point(1046, 467)
        Me.reason_tb.MaxLength = 100
        Me.reason_tb.Multiline = True
        Me.reason_tb.Name = "reason_tb"
        Me.reason_tb.Size = New System.Drawing.Size(257, 47)
        Me.reason_tb.TabIndex = 1
        '
        'quantity_tb
        '
        Me.quantity_tb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.quantity_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_tb.Location = New System.Drawing.Point(1046, 324)
        Me.quantity_tb.MaxLength = 50
        Me.quantity_tb.Name = "quantity_tb"
        Me.quantity_tb.ReadOnly = True
        Me.quantity_tb.Size = New System.Drawing.Size(257, 31)
        Me.quantity_tb.TabIndex = 85
        '
        'category_tb
        '
        Me.category_tb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.category_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_tb.Location = New System.Drawing.Point(1046, 279)
        Me.category_tb.MaxLength = 50
        Me.category_tb.Name = "category_tb"
        Me.category_tb.ReadOnly = True
        Me.category_tb.Size = New System.Drawing.Size(257, 30)
        Me.category_tb.TabIndex = 84
        '
        'aq_tb
        '
        Me.aq_tb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.aq_tb.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aq_tb.Location = New System.Drawing.Point(1046, 370)
        Me.aq_tb.MaxLength = 50
        Me.aq_tb.Name = "aq_tb"
        Me.aq_tb.Size = New System.Drawing.Size(257, 37)
        Me.aq_tb.TabIndex = 0
        '
        'tq_tb
        '
        Me.tq_tb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tq_tb.Font = New System.Drawing.Font("Consolas", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tq_tb.Location = New System.Drawing.Point(1046, 529)
        Me.tq_tb.MaxLength = 50
        Me.tq_tb.Name = "tq_tb"
        Me.tq_tb.ReadOnly = True
        Me.tq_tb.Size = New System.Drawing.Size(143, 47)
        Me.tq_tb.TabIndex = 81
        Me.tq_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'author_tb
        '
        Me.author_tb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.author_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author_tb.Location = New System.Drawing.Point(1046, 234)
        Me.author_tb.MaxLength = 50
        Me.author_tb.Name = "author_tb"
        Me.author_tb.ReadOnly = True
        Me.author_tb.Size = New System.Drawing.Size(257, 30)
        Me.author_tb.TabIndex = 83
        '
        'publisher_tb
        '
        Me.publisher_tb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.publisher_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisher_tb.Location = New System.Drawing.Point(1046, 189)
        Me.publisher_tb.MaxLength = 50
        Me.publisher_tb.Name = "publisher_tb"
        Me.publisher_tb.ReadOnly = True
        Me.publisher_tb.Size = New System.Drawing.Size(257, 30)
        Me.publisher_tb.TabIndex = 82
        '
        'isnb_tb
        '
        Me.isnb_tb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.isnb_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isnb_tb.Location = New System.Drawing.Point(1046, 98)
        Me.isnb_tb.MaxLength = 50
        Me.isnb_tb.Name = "isnb_tb"
        Me.isnb_tb.ReadOnly = True
        Me.isnb_tb.Size = New System.Drawing.Size(211, 31)
        Me.isnb_tb.TabIndex = 80
        '
        'bookname_tb
        '
        Me.bookname_tb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bookname_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookname_tb.Location = New System.Drawing.Point(1046, 144)
        Me.bookname_tb.MaxLength = 50
        Me.bookname_tb.Name = "bookname_tb"
        Me.bookname_tb.ReadOnly = True
        Me.bookname_tb.Size = New System.Drawing.Size(211, 30)
        Me.bookname_tb.TabIndex = 79
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(912, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Quantity"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(912, 475)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 19)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Reason"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(912, 428)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 19)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Action"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(912, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 19)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Category"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(912, 381)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 19)
        Me.Label11.TabIndex = 89
        Me.Label11.Text = "Adjust Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(912, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Author"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(912, 540)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 19)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Total Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(912, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "ISBN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(912, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 19)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Publisher"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1278, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(912, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 19)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Book Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1320, 45)
        Me.Panel1.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(566, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 30)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Books Actions"
        '
        'DataGridView_ba
        '
        Me.DataGridView_ba.AllowUserToAddRows = False
        Me.DataGridView_ba.AllowUserToDeleteRows = False
        Me.DataGridView_ba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_ba.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_ba.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_ba.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_ba.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_ba.ColumnHeadersHeight = 60
        Me.DataGridView_ba.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_ba.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_ba.EnableHeadersVisualStyles = False
        Me.DataGridView_ba.Location = New System.Drawing.Point(11, 98)
        Me.DataGridView_ba.Name = "DataGridView_ba"
        Me.DataGridView_ba.ReadOnly = True
        Me.DataGridView_ba.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_ba.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_ba.RowHeadersWidth = 60
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!)
        Me.DataGridView_ba.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_ba.RowTemplate.Height = 30
        Me.DataGridView_ba.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_ba.Size = New System.Drawing.Size(883, 533)
        Me.DataGridView_ba.TabIndex = 78
        '
        'Books_Actions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 642)
        Me.Controls.Add(Me.searchbox_tb)
        Me.Controls.Add(Me.Cmd_save)
        Me.Controls.Add(Me.action_cb)
        Me.Controls.Add(Me.reason_tb)
        Me.Controls.Add(Me.quantity_tb)
        Me.Controls.Add(Me.category_tb)
        Me.Controls.Add(Me.aq_tb)
        Me.Controls.Add(Me.tq_tb)
        Me.Controls.Add(Me.author_tb)
        Me.Controls.Add(Me.publisher_tb)
        Me.Controls.Add(Me.isnb_tb)
        Me.Controls.Add(Me.bookname_tb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView_ba)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Books_Actions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Books_Actions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_ba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchbox_tb As TextBox
    Friend WithEvents Cmd_save As Button
    Friend WithEvents action_cb As ComboBox
    Friend WithEvents reason_tb As TextBox
    Friend WithEvents quantity_tb As TextBox
    Friend WithEvents category_tb As TextBox
    Friend WithEvents aq_tb As TextBox
    Friend WithEvents tq_tb As TextBox
    Friend WithEvents author_tb As TextBox
    Friend WithEvents publisher_tb As TextBox
    Friend WithEvents isnb_tb As TextBox
    Friend WithEvents bookname_tb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView_ba As DataGridView
    Friend WithEvents Label7 As Label
End Class
