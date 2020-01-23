<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books_stockin
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Cmd_barcode = New System.Windows.Forms.Button()
        Me.Cmd_add_stock = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmd_close = New System.Windows.Forms.Button()
        Me.description_tb = New System.Windows.Forms.TextBox()
        Me.author_tb = New System.Windows.Forms.TextBox()
        Me.isbn_tb = New System.Windows.Forms.TextBox()
        Me.new_quantity_tb = New System.Windows.Forms.TextBox()
        Me.total_quantity_tb = New System.Windows.Forms.TextBox()
        Me.quantity_on_hand_tb = New System.Windows.Forms.TextBox()
        Me.publisher_tb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.name_tb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView_books_in = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.refno_tb = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_books_in, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmd_barcode
        '
        Me.Cmd_barcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_barcode.BackColor = System.Drawing.Color.DodgerBlue
        Me.Cmd_barcode.FlatAppearance.BorderSize = 0
        Me.Cmd_barcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_barcode.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_barcode.ForeColor = System.Drawing.Color.White
        Me.Cmd_barcode.Location = New System.Drawing.Point(379, 113)
        Me.Cmd_barcode.Name = "Cmd_barcode"
        Me.Cmd_barcode.Size = New System.Drawing.Size(92, 30)
        Me.Cmd_barcode.TabIndex = 0
        Me.Cmd_barcode.Text = "Choose"
        Me.Cmd_barcode.UseVisualStyleBackColor = False
        '
        'Cmd_add_stock
        '
        Me.Cmd_add_stock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_add_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_add_stock.FlatAppearance.BorderSize = 0
        Me.Cmd_add_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_add_stock.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_add_stock.ForeColor = System.Drawing.Color.White
        Me.Cmd_add_stock.Location = New System.Drawing.Point(776, 279)
        Me.Cmd_add_stock.Name = "Cmd_add_stock"
        Me.Cmd_add_stock.Size = New System.Drawing.Size(146, 32)
        Me.Cmd_add_stock.TabIndex = 3
        Me.Cmd_add_stock.Text = "Add Stock"
        Me.Cmd_add_stock.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Cmd_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1308, 45)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(587, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 30)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Books Stock In"
        '
        'Cmd_close
        '
        Me.Cmd_close.BackColor = System.Drawing.Color.OrangeRed
        Me.Cmd_close.FlatAppearance.BorderSize = 0
        Me.Cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_close.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_close.ForeColor = System.Drawing.Color.White
        Me.Cmd_close.Location = New System.Drawing.Point(1267, 6)
        Me.Cmd_close.Name = "Cmd_close"
        Me.Cmd_close.Size = New System.Drawing.Size(36, 33)
        Me.Cmd_close.TabIndex = 10
        Me.Cmd_close.Text = "X"
        Me.Cmd_close.UseVisualStyleBackColor = False
        '
        'description_tb
        '
        Me.description_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description_tb.Location = New System.Drawing.Point(152, 149)
        Me.description_tb.MaxLength = 100
        Me.description_tb.Multiline = True
        Me.description_tb.Name = "description_tb"
        Me.description_tb.Size = New System.Drawing.Size(319, 52)
        Me.description_tb.TabIndex = 1
        '
        'author_tb
        '
        Me.author_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author_tb.Location = New System.Drawing.Point(152, 279)
        Me.author_tb.MaxLength = 50
        Me.author_tb.Name = "author_tb"
        Me.author_tb.ReadOnly = True
        Me.author_tb.Size = New System.Drawing.Size(319, 30)
        Me.author_tb.TabIndex = 89
        '
        'isbn_tb
        '
        Me.isbn_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbn_tb.Location = New System.Drawing.Point(152, 113)
        Me.isbn_tb.MaxLength = 50
        Me.isbn_tb.Name = "isbn_tb"
        Me.isbn_tb.ReadOnly = True
        Me.isbn_tb.Size = New System.Drawing.Size(221, 31)
        Me.isbn_tb.TabIndex = 79
        '
        'new_quantity_tb
        '
        Me.new_quantity_tb.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_quantity_tb.Location = New System.Drawing.Point(776, 185)
        Me.new_quantity_tb.MaxLength = 50
        Me.new_quantity_tb.Name = "new_quantity_tb"
        Me.new_quantity_tb.Size = New System.Drawing.Size(146, 50)
        Me.new_quantity_tb.TabIndex = 2
        Me.new_quantity_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'total_quantity_tb
        '
        Me.total_quantity_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_quantity_tb.Location = New System.Drawing.Point(776, 242)
        Me.total_quantity_tb.MaxLength = 50
        Me.total_quantity_tb.Name = "total_quantity_tb"
        Me.total_quantity_tb.ReadOnly = True
        Me.total_quantity_tb.Size = New System.Drawing.Size(146, 31)
        Me.total_quantity_tb.TabIndex = 88
        Me.total_quantity_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'quantity_on_hand_tb
        '
        Me.quantity_on_hand_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_on_hand_tb.Location = New System.Drawing.Point(776, 149)
        Me.quantity_on_hand_tb.MaxLength = 50
        Me.quantity_on_hand_tb.Name = "quantity_on_hand_tb"
        Me.quantity_on_hand_tb.ReadOnly = True
        Me.quantity_on_hand_tb.Size = New System.Drawing.Size(146, 31)
        Me.quantity_on_hand_tb.TabIndex = 94
        Me.quantity_on_hand_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'publisher_tb
        '
        Me.publisher_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisher_tb.Location = New System.Drawing.Point(152, 243)
        Me.publisher_tb.MaxLength = 50
        Me.publisher_tb.Name = "publisher_tb"
        Me.publisher_tb.ReadOnly = True
        Me.publisher_tb.Size = New System.Drawing.Size(319, 30)
        Me.publisher_tb.TabIndex = 93
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 22)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Description"
        '
        'name_tb
        '
        Me.name_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_tb.Location = New System.Drawing.Point(152, 207)
        Me.name_tb.MaxLength = 50
        Me.name_tb.Name = "name_tb"
        Me.name_tb.ReadOnly = True
        Me.name_tb.Size = New System.Drawing.Size(319, 30)
        Me.name_tb.TabIndex = 90
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Proxima Nova Lt", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(577, 195)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 31)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "Quantity"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(579, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 22)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "Total Quantity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 22)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "ISBN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(579, 152)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 22)
        Me.Label11.TabIndex = 107
        Me.Label11.Text = "Quantity on Hand"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 22)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Author"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 22)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Publisher"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 22)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Name"
        '
        'DataGridView_books_in
        '
        Me.DataGridView_books_in.AllowUserToAddRows = False
        Me.DataGridView_books_in.AllowUserToDeleteRows = False
        Me.DataGridView_books_in.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DataGridView_books_in.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_books_in.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_books_in.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_books_in.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_books_in.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView_books_in.ColumnHeadersHeight = 60
        Me.DataGridView_books_in.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_books_in.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView_books_in.EnableHeadersVisualStyles = False
        Me.DataGridView_books_in.Location = New System.Drawing.Point(9, 338)
        Me.DataGridView_books_in.Name = "DataGridView_books_in"
        Me.DataGridView_books_in.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_books_in.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView_books_in.RowHeadersWidth = 60
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!)
        Me.DataGridView_books_in.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView_books_in.RowTemplate.Height = 30
        Me.DataGridView_books_in.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_books_in.Size = New System.Drawing.Size(1289, 402)
        Me.DataGridView_books_in.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 22)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Ref No"
        '
        'refno_tb
        '
        Me.refno_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refno_tb.Location = New System.Drawing.Point(152, 77)
        Me.refno_tb.MaxLength = 50
        Me.refno_tb.Name = "refno_tb"
        Me.refno_tb.ReadOnly = True
        Me.refno_tb.Size = New System.Drawing.Size(221, 31)
        Me.refno_tb.TabIndex = 79
        '
        'Books_stockin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 750)
        Me.Controls.Add(Me.Cmd_barcode)
        Me.Controls.Add(Me.Cmd_add_stock)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.description_tb)
        Me.Controls.Add(Me.author_tb)
        Me.Controls.Add(Me.refno_tb)
        Me.Controls.Add(Me.isbn_tb)
        Me.Controls.Add(Me.new_quantity_tb)
        Me.Controls.Add(Me.total_quantity_tb)
        Me.Controls.Add(Me.quantity_on_hand_tb)
        Me.Controls.Add(Me.publisher_tb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.name_tb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView_books_in)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Books_stockin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Books_stockin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_books_in, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmd_barcode As Button
    Friend WithEvents Cmd_add_stock As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Cmd_close As Button
    Friend WithEvents description_tb As TextBox
    Friend WithEvents author_tb As TextBox
    Friend WithEvents isbn_tb As TextBox
    Friend WithEvents new_quantity_tb As TextBox
    Friend WithEvents total_quantity_tb As TextBox
    Friend WithEvents quantity_on_hand_tb As TextBox
    Friend WithEvents publisher_tb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents name_tb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView_books_in As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents refno_tb As TextBox
End Class
