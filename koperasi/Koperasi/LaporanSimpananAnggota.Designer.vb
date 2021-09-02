<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanSimpananAnggota
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.lbl_subjudul = New System.Windows.Forms.Label()
        Me.lbl_judul = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_jumlah_data = New System.Windows.Forms.Label()
        Me.lbl_mulai = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.dtp_sampai = New System.Windows.Forms.DateTimePicker()
        Me.lbl_sampai = New System.Windows.Forms.Label()
        Me.dtp_mulai = New System.Windows.Forms.DateTimePicker()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.group_simpanan_pokok = New System.Windows.Forms.GroupBox()
        Me.cmb_simpanan_pokok = New System.Windows.Forms.ComboBox()
        Me.group_data_simpanan = New System.Windows.Forms.GroupBox()
        Me.dgv_data_simpanan = New System.Windows.Forms.DataGridView()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.group_simpanan_pokok.SuspendLayout()
        Me.group_data_simpanan.SuspendLayout()
        CType(Me.dgv_data_simpanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.btn_cetak)
        Me.GroupBox4.Controls.Add(Me.btn_keluar)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 413)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(525, 40)
        Me.GroupBox4.TabIndex = 45
        Me.GroupBox4.TabStop = False
        '
        'btn_cetak
        '
        Me.btn_cetak.Location = New System.Drawing.Point(6, 12)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(75, 23)
        Me.btn_cetak.TabIndex = 46
        Me.btn_cetak.Text = "Cetak"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(444, 12)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 0
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'lbl_subjudul
        '
        Me.lbl_subjudul.AutoSize = True
        Me.lbl_subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_subjudul.Location = New System.Drawing.Point(25, 33)
        Me.lbl_subjudul.Name = "lbl_subjudul"
        Me.lbl_subjudul.Size = New System.Drawing.Size(255, 13)
        Me.lbl_subjudul.TabIndex = 2
        Me.lbl_subjudul.Text = "Form ini digunakan untuk laporan simpanan Anggota"
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_judul.ForeColor = System.Drawing.Color.White
        Me.lbl_judul.Location = New System.Drawing.Point(13, 13)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(233, 20)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Laporan Simpanan Anggota"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_subjudul)
        Me.Panel1.Controls.Add(Me.lbl_judul)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(525, 60)
        Me.Panel1.TabIndex = 41
        '
        'lbl_jumlah_data
        '
        Me.lbl_jumlah_data.AutoSize = True
        Me.lbl_jumlah_data.Location = New System.Drawing.Point(6, 263)
        Me.lbl_jumlah_data.Name = "lbl_jumlah_data"
        Me.lbl_jumlah_data.Size = New System.Drawing.Size(81, 13)
        Me.lbl_jumlah_data.TabIndex = 2
        Me.lbl_jumlah_data.Text = "Jumlah Data : 0"
        '
        'lbl_mulai
        '
        Me.lbl_mulai.AutoSize = True
        Me.lbl_mulai.Location = New System.Drawing.Point(133, 19)
        Me.lbl_mulai.Name = "lbl_mulai"
        Me.lbl_mulai.Size = New System.Drawing.Size(32, 13)
        Me.lbl_mulai.TabIndex = 4
        Me.lbl_mulai.Text = "Mulai"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(7, 20)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(499, 20)
        Me.txt_search.TabIndex = 0
        '
        'dtp_sampai
        '
        Me.dtp_sampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_sampai.Location = New System.Drawing.Point(317, 19)
        Me.dtp_sampai.Name = "dtp_sampai"
        Me.dtp_sampai.Size = New System.Drawing.Size(92, 20)
        Me.dtp_sampai.TabIndex = 9
        '
        'lbl_sampai
        '
        Me.lbl_sampai.AutoSize = True
        Me.lbl_sampai.Location = New System.Drawing.Point(269, 19)
        Me.lbl_sampai.Name = "lbl_sampai"
        Me.lbl_sampai.Size = New System.Drawing.Size(42, 13)
        Me.lbl_sampai.TabIndex = 8
        Me.lbl_sampai.Text = "Sampai"
        '
        'dtp_mulai
        '
        Me.dtp_mulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_mulai.Location = New System.Drawing.Point(171, 19)
        Me.dtp_mulai.Name = "dtp_mulai"
        Me.dtp_mulai.Size = New System.Drawing.Size(92, 20)
        Me.dtp_mulai.TabIndex = 7
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(415, 19)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 23)
        Me.btn_refresh.TabIndex = 6
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'group_simpanan_pokok
        '
        Me.group_simpanan_pokok.Controls.Add(Me.cmb_simpanan_pokok)
        Me.group_simpanan_pokok.Controls.Add(Me.dtp_sampai)
        Me.group_simpanan_pokok.Controls.Add(Me.lbl_sampai)
        Me.group_simpanan_pokok.Controls.Add(Me.dtp_mulai)
        Me.group_simpanan_pokok.Controls.Add(Me.btn_refresh)
        Me.group_simpanan_pokok.Controls.Add(Me.lbl_mulai)
        Me.group_simpanan_pokok.Location = New System.Drawing.Point(6, 66)
        Me.group_simpanan_pokok.Name = "group_simpanan_pokok"
        Me.group_simpanan_pokok.Size = New System.Drawing.Size(512, 50)
        Me.group_simpanan_pokok.TabIndex = 42
        Me.group_simpanan_pokok.TabStop = False
        Me.group_simpanan_pokok.Text = "Simpanan Pokok"
        '
        'cmb_simpanan_pokok
        '
        Me.cmb_simpanan_pokok.FormattingEnabled = True
        Me.cmb_simpanan_pokok.Items.AddRange(New Object() {"POKOK", "WAJIB", "SALDO AWAL"})
        Me.cmb_simpanan_pokok.Location = New System.Drawing.Point(7, 19)
        Me.cmb_simpanan_pokok.Name = "cmb_simpanan_pokok"
        Me.cmb_simpanan_pokok.Size = New System.Drawing.Size(121, 21)
        Me.cmb_simpanan_pokok.TabIndex = 10
        '
        'group_data_simpanan
        '
        Me.group_data_simpanan.Controls.Add(Me.lbl_jumlah_data)
        Me.group_data_simpanan.Controls.Add(Me.dgv_data_simpanan)
        Me.group_data_simpanan.Controls.Add(Me.txt_search)
        Me.group_data_simpanan.Location = New System.Drawing.Point(6, 122)
        Me.group_data_simpanan.Name = "group_data_simpanan"
        Me.group_data_simpanan.Size = New System.Drawing.Size(512, 285)
        Me.group_data_simpanan.TabIndex = 43
        Me.group_data_simpanan.TabStop = False
        Me.group_data_simpanan.Text = "Data Simpanan"
        '
        'dgv_data_simpanan
        '
        Me.dgv_data_simpanan.AllowUserToAddRows = False
        Me.dgv_data_simpanan.AllowUserToDeleteRows = False
        Me.dgv_data_simpanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_simpanan.Location = New System.Drawing.Point(7, 48)
        Me.dgv_data_simpanan.Name = "dgv_data_simpanan"
        Me.dgv_data_simpanan.ReadOnly = True
        Me.dgv_data_simpanan.RowHeadersWidth = 51
        Me.dgv_data_simpanan.Size = New System.Drawing.Size(499, 212)
        Me.dgv_data_simpanan.TabIndex = 1
        '
        'LaporanSimpananAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 453)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.group_simpanan_pokok)
        Me.Controls.Add(Me.group_data_simpanan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LaporanSimpananAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_simpanan_pokok.ResumeLayout(False)
        Me.group_simpanan_pokok.PerformLayout()
        Me.group_data_simpanan.ResumeLayout(False)
        Me.group_data_simpanan.PerformLayout()
        CType(Me.dgv_data_simpanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_keluar As Button
    Friend WithEvents lbl_subjudul As Label
    Friend WithEvents lbl_judul As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_jumlah_data As Label
    Friend WithEvents lbl_mulai As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents dtp_sampai As DateTimePicker
    Friend WithEvents lbl_sampai As Label
    Friend WithEvents dtp_mulai As DateTimePicker
    Friend WithEvents btn_refresh As Button
    Friend WithEvents group_simpanan_pokok As GroupBox
    Friend WithEvents group_data_simpanan As GroupBox
    Friend WithEvents dgv_data_simpanan As DataGridView
    Friend WithEvents cmb_simpanan_pokok As ComboBox
    Friend WithEvents btn_cetak As Button
End Class
