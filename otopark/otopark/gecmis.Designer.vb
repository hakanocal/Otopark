<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gecmis
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCustomDataGrid1
        '
        Me.BunifuCustomDataGrid1.AllowUserToAddRows = False
        Me.BunifuCustomDataGrid1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.ForestGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Snow
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(0, 30)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.ReadOnly = True
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowHeadersVisible = False
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(565, 367)
        Me.BunifuCustomDataGrid1.TabIndex = 15
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.White
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro
        Me.GunaGroupBox1.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.DarkGray
        Me.GunaGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(565, 397)
        Me.GunaGroupBox1.TabIndex = 16
        Me.GunaGroupBox1.Text = "GEÇMİŞ"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'gecmis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 421)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Name = "gecmis"
        Me.Text = "gecmis"
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
End Class
