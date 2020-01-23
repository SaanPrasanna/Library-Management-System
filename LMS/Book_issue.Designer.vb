<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_issue
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.biid_tb = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView_bi = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Cmd_new = New System.Windows.Forms.Button()
        Me.Cmd_issuebook = New System.Windows.Forms.Button()
        Me.Cmd_selectmember = New System.Windows.Forms.Button()
        Me.Cmd_checkavailablebook = New System.Windows.Forms.Button()
        Me.Cmd_selectbook = New System.Windows.Forms.Button()
        Me.membername_tb = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView_bi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'biid_tb
        '
        Me.biid_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biid_tb.Location = New System.Drawing.Point(12, 52)
        Me.biid_tb.Name = "biid_tb"
        Me.biid_tb.ReadOnly = True
        Me.biid_tb.Size = New System.Drawing.Size(359, 31)
        Me.biid_tb.TabIndex = 102
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1307, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(566, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 30)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Books Issue"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1352, 45)
        Me.Panel1.TabIndex = 101
        '
        'DataGridView_bi
        '
        Me.DataGridView_bi.AllowUserToAddRows = False
        Me.DataGridView_bi.AllowUserToDeleteRows = False
        Me.DataGridView_bi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView_bi.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView_bi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView_bi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_bi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView_bi.ColumnHeadersHeight = 60
        Me.DataGridView_bi.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView_bi.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView_bi.EnableHeadersVisualStyles = False
        Me.DataGridView_bi.Location = New System.Drawing.Point(11, 90)
        Me.DataGridView_bi.Name = "DataGridView_bi"
        Me.DataGridView_bi.ReadOnly = True
        Me.DataGridView_bi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView_bi.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView_bi.RowHeadersWidth = 60
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 10.0!)
        Me.DataGridView_bi.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView_bi.RowTemplate.Height = 30
        Me.DataGridView_bi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_bi.Size = New System.Drawing.Size(972, 579)
        Me.DataGridView_bi.TabIndex = 104
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Controls.Add(Me.Cmd_new)
        Me.Panel2.Controls.Add(Me.Cmd_issuebook)
        Me.Panel2.Controls.Add(Me.Cmd_selectmember)
        Me.Panel2.Controls.Add(Me.Cmd_checkavailablebook)
        Me.Panel2.Controls.Add(Me.Cmd_selectbook)
        Me.Panel2.Location = New System.Drawing.Point(992, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(354, 579)
        Me.Panel2.TabIndex = 105
        '
        'Cmd_new
        '
        Me.Cmd_new.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_new.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Cmd_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Cmd_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_new.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_new.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Cmd_new.Location = New System.Drawing.Point(4, 4)
        Me.Cmd_new.Name = "Cmd_new"
        Me.Cmd_new.Size = New System.Drawing.Size(348, 62)
        Me.Cmd_new.TabIndex = 0
        Me.Cmd_new.Text = "{F1} New"
        Me.Cmd_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_new.UseVisualStyleBackColor = False
        '
        'Cmd_issuebook
        '
        Me.Cmd_issuebook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_issuebook.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_issuebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Cmd_issuebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Cmd_issuebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_issuebook.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_issuebook.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Cmd_issuebook.Location = New System.Drawing.Point(3, 268)
        Me.Cmd_issuebook.Name = "Cmd_issuebook"
        Me.Cmd_issuebook.Size = New System.Drawing.Size(348, 62)
        Me.Cmd_issuebook.TabIndex = 0
        Me.Cmd_issuebook.Text = "{F5} Issue Book"
        Me.Cmd_issuebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_issuebook.UseVisualStyleBackColor = False
        '
        'Cmd_selectmember
        '
        Me.Cmd_selectmember.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_selectmember.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_selectmember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Cmd_selectmember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Cmd_selectmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_selectmember.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_selectmember.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Cmd_selectmember.Location = New System.Drawing.Point(3, 136)
        Me.Cmd_selectmember.Name = "Cmd_selectmember"
        Me.Cmd_selectmember.Size = New System.Drawing.Size(348, 62)
        Me.Cmd_selectmember.TabIndex = 0
        Me.Cmd_selectmember.Text = "{F3} Select Member"
        Me.Cmd_selectmember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_selectmember.UseVisualStyleBackColor = False
        '
        'Cmd_checkavailablebook
        '
        Me.Cmd_checkavailablebook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_checkavailablebook.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_checkavailablebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Cmd_checkavailablebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Cmd_checkavailablebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_checkavailablebook.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_checkavailablebook.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Cmd_checkavailablebook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_checkavailablebook.Location = New System.Drawing.Point(3, 70)
        Me.Cmd_checkavailablebook.Name = "Cmd_checkavailablebook"
        Me.Cmd_checkavailablebook.Size = New System.Drawing.Size(348, 62)
        Me.Cmd_checkavailablebook.TabIndex = 0
        Me.Cmd_checkavailablebook.Text = "{F2} Check Available Book"
        Me.Cmd_checkavailablebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_checkavailablebook.UseVisualStyleBackColor = False
        '
        'Cmd_selectbook
        '
        Me.Cmd_selectbook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmd_selectbook.BackColor = System.Drawing.Color.SteelBlue
        Me.Cmd_selectbook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Cmd_selectbook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Cmd_selectbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_selectbook.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_selectbook.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Cmd_selectbook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_selectbook.Location = New System.Drawing.Point(4, 202)
        Me.Cmd_selectbook.Name = "Cmd_selectbook"
        Me.Cmd_selectbook.Size = New System.Drawing.Size(348, 62)
        Me.Cmd_selectbook.TabIndex = 0
        Me.Cmd_selectbook.Text = "{F4} Select Book"
        Me.Cmd_selectbook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_selectbook.UseVisualStyleBackColor = False
        '
        'membername_tb
        '
        Me.membername_tb.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.membername_tb.Location = New System.Drawing.Point(377, 51)
        Me.membername_tb.Name = "membername_tb"
        Me.membername_tb.ReadOnly = True
        Me.membername_tb.Size = New System.Drawing.Size(272, 31)
        Me.membername_tb.TabIndex = 102
        '
        'Book_issue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 678)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.membername_tb)
        Me.Controls.Add(Me.biid_tb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView_bi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Book_issue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book_issue"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView_bi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents biid_tb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView_bi As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Cmd_issuebook As Button
    Friend WithEvents Cmd_selectmember As Button
    Friend WithEvents Cmd_checkavailablebook As Button
    Friend WithEvents Cmd_selectbook As Button
    Friend WithEvents Cmd_new As Button
    Friend WithEvents membername_tb As TextBox
End Class
