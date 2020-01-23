<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Issue_popup
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
        Me.pcs_temp = New System.Windows.Forms.Label()
        Me.item_tb = New System.Windows.Forms.TextBox()
        Me.Cmd_down = New System.Windows.Forms.Button()
        Me.Cmd_up = New System.Windows.Forms.Button()
        Me.quantity_lbl = New System.Windows.Forms.Label()
        Me.isbn_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pcs_temp
        '
        Me.pcs_temp.AutoSize = True
        Me.pcs_temp.Location = New System.Drawing.Point(38, 90)
        Me.pcs_temp.Name = "pcs_temp"
        Me.pcs_temp.Size = New System.Drawing.Size(0, 17)
        Me.pcs_temp.TabIndex = 9
        Me.pcs_temp.Visible = False
        '
        'item_tb
        '
        Me.item_tb.Font = New System.Drawing.Font("Proxima Nova Alt Rg", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.item_tb.ForeColor = System.Drawing.Color.Black
        Me.item_tb.Location = New System.Drawing.Point(7, 90)
        Me.item_tb.MaxLength = 3
        Me.item_tb.Name = "item_tb"
        Me.item_tb.Size = New System.Drawing.Size(156, 100)
        Me.item_tb.TabIndex = 6
        Me.item_tb.Text = "1"
        Me.item_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cmd_down
        '
        Me.Cmd_down.BackColor = System.Drawing.Color.Orange
        Me.Cmd_down.FlatAppearance.BorderSize = 0
        Me.Cmd_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_down.Image = Global.LMS.My.Resources.Resources.minus_sign_inside_a_black_circle__1_
        Me.Cmd_down.Location = New System.Drawing.Point(7, 196)
        Me.Cmd_down.Name = "Cmd_down"
        Me.Cmd_down.Size = New System.Drawing.Size(156, 79)
        Me.Cmd_down.TabIndex = 8
        Me.Cmd_down.UseVisualStyleBackColor = False
        '
        'Cmd_up
        '
        Me.Cmd_up.BackColor = System.Drawing.Color.DodgerBlue
        Me.Cmd_up.FlatAppearance.BorderSize = 0
        Me.Cmd_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_up.Image = Global.LMS.My.Resources.Resources.plus_sign_in_a_black_circle
        Me.Cmd_up.Location = New System.Drawing.Point(7, 5)
        Me.Cmd_up.Name = "Cmd_up"
        Me.Cmd_up.Size = New System.Drawing.Size(156, 79)
        Me.Cmd_up.TabIndex = 7
        Me.Cmd_up.UseVisualStyleBackColor = False
        '
        'quantity_lbl
        '
        Me.quantity_lbl.AutoSize = True
        Me.quantity_lbl.Location = New System.Drawing.Point(144, 86)
        Me.quantity_lbl.Name = "quantity_lbl"
        Me.quantity_lbl.Size = New System.Drawing.Size(13, 17)
        Me.quantity_lbl.TabIndex = 10
        Me.quantity_lbl.Text = "*"
        Me.quantity_lbl.Visible = False
        '
        'isbn_lbl
        '
        Me.isbn_lbl.AutoSize = True
        Me.isbn_lbl.Location = New System.Drawing.Point(144, 103)
        Me.isbn_lbl.Name = "isbn_lbl"
        Me.isbn_lbl.Size = New System.Drawing.Size(13, 17)
        Me.isbn_lbl.TabIndex = 10
        Me.isbn_lbl.Text = "*"
        Me.isbn_lbl.Visible = False
        '
        'Issue_popup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(170, 280)
        Me.Controls.Add(Me.isbn_lbl)
        Me.Controls.Add(Me.quantity_lbl)
        Me.Controls.Add(Me.pcs_temp)
        Me.Controls.Add(Me.Cmd_down)
        Me.Controls.Add(Me.Cmd_up)
        Me.Controls.Add(Me.item_tb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Issue_popup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Issue_popup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcs_temp As Label
    Friend WithEvents Cmd_down As Button
    Friend WithEvents Cmd_up As Button
    Friend WithEvents item_tb As TextBox
    Friend WithEvents quantity_lbl As Label
    Friend WithEvents isbn_lbl As Label
End Class
