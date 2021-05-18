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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.İdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlakaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RenkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AracturuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoyadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParkyeriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GiristarihiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GirissaatiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CikistarihiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CikissaatiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UcretDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GecmisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtoparkDataSet = New otopark.otoparkDataSet()
        Me.GecmisTableAdapter = New otopark.otoparkDataSetTableAdapters.gecmisTableAdapter()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GecmisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtoparkDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomDataGrid1
        '
        Me.BunifuCustomDataGrid1.AllowUserToAddRows = False
        Me.BunifuCustomDataGrid1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.İdDataGridViewTextBoxColumn, Me.PlakaDataGridViewTextBoxColumn, Me.MarkaDataGridViewTextBoxColumn, Me.ModelDataGridViewTextBoxColumn, Me.RenkDataGridViewTextBoxColumn, Me.AracturuDataGridViewTextBoxColumn, Me.TcDataGridViewTextBoxColumn, Me.AdDataGridViewTextBoxColumn, Me.SoyadDataGridViewTextBoxColumn, Me.TelefonDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.ParkyeriDataGridViewTextBoxColumn, Me.GiristarihiDataGridViewTextBoxColumn, Me.GirissaatiDataGridViewTextBoxColumn, Me.CikistarihiDataGridViewTextBoxColumn, Me.CikissaatiDataGridViewTextBoxColumn, Me.SureDataGridViewTextBoxColumn, Me.UcretDataGridViewTextBoxColumn})
        Me.BunifuCustomDataGrid1.DataSource = Me.GecmisBindingSource
        Me.BunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.ForestGreen
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Snow
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.ReadOnly = True
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.RowHeadersVisible = False
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(1008, 729)
        Me.BunifuCustomDataGrid1.TabIndex = 15
        '
        'İdDataGridViewTextBoxColumn
        '
        Me.İdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.İdDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.İdDataGridViewTextBoxColumn.HeaderText = "No"
        Me.İdDataGridViewTextBoxColumn.Name = "İdDataGridViewTextBoxColumn"
        Me.İdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlakaDataGridViewTextBoxColumn
        '
        Me.PlakaDataGridViewTextBoxColumn.DataPropertyName = "plaka"
        Me.PlakaDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.PlakaDataGridViewTextBoxColumn.HeaderText = "Plaka"
        Me.PlakaDataGridViewTextBoxColumn.Name = "PlakaDataGridViewTextBoxColumn"
        Me.PlakaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarkaDataGridViewTextBoxColumn
        '
        Me.MarkaDataGridViewTextBoxColumn.DataPropertyName = "marka"
        Me.MarkaDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.MarkaDataGridViewTextBoxColumn.HeaderText = "Marka"
        Me.MarkaDataGridViewTextBoxColumn.Name = "MarkaDataGridViewTextBoxColumn"
        Me.MarkaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModelDataGridViewTextBoxColumn
        '
        Me.ModelDataGridViewTextBoxColumn.DataPropertyName = "model"
        Me.ModelDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.ModelDataGridViewTextBoxColumn.HeaderText = "Model"
        Me.ModelDataGridViewTextBoxColumn.Name = "ModelDataGridViewTextBoxColumn"
        Me.ModelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RenkDataGridViewTextBoxColumn
        '
        Me.RenkDataGridViewTextBoxColumn.DataPropertyName = "renk"
        Me.RenkDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.RenkDataGridViewTextBoxColumn.HeaderText = "Renk"
        Me.RenkDataGridViewTextBoxColumn.Name = "RenkDataGridViewTextBoxColumn"
        Me.RenkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AracturuDataGridViewTextBoxColumn
        '
        Me.AracturuDataGridViewTextBoxColumn.DataPropertyName = "arac_turu"
        Me.AracturuDataGridViewTextBoxColumn.FillWeight = 130.0!
        Me.AracturuDataGridViewTextBoxColumn.HeaderText = "Araç tipi"
        Me.AracturuDataGridViewTextBoxColumn.Name = "AracturuDataGridViewTextBoxColumn"
        Me.AracturuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TcDataGridViewTextBoxColumn
        '
        Me.TcDataGridViewTextBoxColumn.DataPropertyName = "tc"
        Me.TcDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.TcDataGridViewTextBoxColumn.HeaderText = "TC"
        Me.TcDataGridViewTextBoxColumn.Name = "TcDataGridViewTextBoxColumn"
        Me.TcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdDataGridViewTextBoxColumn
        '
        Me.AdDataGridViewTextBoxColumn.DataPropertyName = "ad"
        Me.AdDataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.AdDataGridViewTextBoxColumn.HeaderText = "Ad"
        Me.AdDataGridViewTextBoxColumn.Name = "AdDataGridViewTextBoxColumn"
        Me.AdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SoyadDataGridViewTextBoxColumn
        '
        Me.SoyadDataGridViewTextBoxColumn.DataPropertyName = "soyad"
        Me.SoyadDataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.SoyadDataGridViewTextBoxColumn.HeaderText = "Soyad"
        Me.SoyadDataGridViewTextBoxColumn.Name = "SoyadDataGridViewTextBoxColumn"
        Me.SoyadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonDataGridViewTextBoxColumn
        '
        Me.TelefonDataGridViewTextBoxColumn.DataPropertyName = "telefon"
        Me.TelefonDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.TelefonDataGridViewTextBoxColumn.HeaderText = "Telefon"
        Me.TelefonDataGridViewTextBoxColumn.Name = "TelefonDataGridViewTextBoxColumn"
        Me.TelefonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ParkyeriDataGridViewTextBoxColumn
        '
        Me.ParkyeriDataGridViewTextBoxColumn.DataPropertyName = "park_yeri"
        Me.ParkyeriDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.ParkyeriDataGridViewTextBoxColumn.HeaderText = "Park yeri"
        Me.ParkyeriDataGridViewTextBoxColumn.Name = "ParkyeriDataGridViewTextBoxColumn"
        Me.ParkyeriDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GiristarihiDataGridViewTextBoxColumn
        '
        Me.GiristarihiDataGridViewTextBoxColumn.DataPropertyName = "giris_tarihi"
        Me.GiristarihiDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.GiristarihiDataGridViewTextBoxColumn.HeaderText = "Giriş tarihi"
        Me.GiristarihiDataGridViewTextBoxColumn.Name = "GiristarihiDataGridViewTextBoxColumn"
        Me.GiristarihiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GirissaatiDataGridViewTextBoxColumn
        '
        Me.GirissaatiDataGridViewTextBoxColumn.DataPropertyName = "giris_saati"
        Me.GirissaatiDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.GirissaatiDataGridViewTextBoxColumn.HeaderText = "Giriş saati"
        Me.GirissaatiDataGridViewTextBoxColumn.Name = "GirissaatiDataGridViewTextBoxColumn"
        Me.GirissaatiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CikistarihiDataGridViewTextBoxColumn
        '
        Me.CikistarihiDataGridViewTextBoxColumn.DataPropertyName = "cikis_tarihi"
        Me.CikistarihiDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.CikistarihiDataGridViewTextBoxColumn.HeaderText = "Çıkış tarihi"
        Me.CikistarihiDataGridViewTextBoxColumn.Name = "CikistarihiDataGridViewTextBoxColumn"
        Me.CikistarihiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CikissaatiDataGridViewTextBoxColumn
        '
        Me.CikissaatiDataGridViewTextBoxColumn.DataPropertyName = "cikis_saati"
        Me.CikissaatiDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.CikissaatiDataGridViewTextBoxColumn.HeaderText = "Çıkış saati"
        Me.CikissaatiDataGridViewTextBoxColumn.Name = "CikissaatiDataGridViewTextBoxColumn"
        Me.CikissaatiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SureDataGridViewTextBoxColumn
        '
        Me.SureDataGridViewTextBoxColumn.DataPropertyName = "sure"
        Me.SureDataGridViewTextBoxColumn.FillWeight = 145.0!
        Me.SureDataGridViewTextBoxColumn.HeaderText = "Süre"
        Me.SureDataGridViewTextBoxColumn.Name = "SureDataGridViewTextBoxColumn"
        Me.SureDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UcretDataGridViewTextBoxColumn
        '
        Me.UcretDataGridViewTextBoxColumn.DataPropertyName = "ucret"
        Me.UcretDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.UcretDataGridViewTextBoxColumn.HeaderText = "Ücret"
        Me.UcretDataGridViewTextBoxColumn.Name = "UcretDataGridViewTextBoxColumn"
        Me.UcretDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GecmisBindingSource
        '
        Me.GecmisBindingSource.DataMember = "gecmis"
        Me.GecmisBindingSource.DataSource = Me.OtoparkDataSet
        '
        'OtoparkDataSet
        '
        Me.OtoparkDataSet.DataSetName = "otoparkDataSet"
        Me.OtoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GecmisTableAdapter
        '
        Me.GecmisTableAdapter.ClearBeforeFill = True
        '
        'gecmis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Name = "gecmis"
        Me.Text = "GEÇMİŞ • OTOPARK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GecmisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtoparkDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents OtoparkDataSet As otopark.otoparkDataSet
    Friend WithEvents GecmisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GecmisTableAdapter As otopark.otoparkDataSetTableAdapters.gecmisTableAdapter
    Friend WithEvents İdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlakaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarkaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RenkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AracturuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SoyadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParkyeriDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GiristarihiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GirissaatiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CikistarihiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CikissaatiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UcretDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
