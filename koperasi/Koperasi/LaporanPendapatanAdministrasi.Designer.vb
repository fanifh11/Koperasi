﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanPendapatanAdministrasi
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_total_administrasi = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.group_data_peminjaman = New System.Windows.Forms.GroupBox()
        Me.lbl_jumlah_data = New System.Windows.Forms.Label()
        Me.dgv_laporan_pendapatan_administrasi = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.dtp_sampai = New System.Windows.Forms.DateTimePicker()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.lbl_mulai = New System.Windows.Forms.Label()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.lbl_subjudul = New System.Windows.Forms.Label()
        Me.lbl_judul = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtp_mulai = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_sampai = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.group_data_peminjaman.SuspendLayout()
        CType(Me.dgv_laporan_pendapatan_administrasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_total_administrasi)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 457)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(628, 52)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'lbl_total_administrasi
        '
        Me.lbl_total_administrasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_total_administrasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_administrasi.ForeColor = System.Drawing.Color.Red
        Me.lbl_total_administrasi.Location = New System.Drawing.Point(4, 19)
        Me.lbl_total_administrasi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total_administrasi.Name = "lbl_total_administrasi"
        Me.lbl_total_administrasi.Size = New System.Drawing.Size(620, 29)
        Me.lbl_total_administrasi.TabIndex = 0
        Me.lbl_total_administrasi.Text = "Total Administrasi : 0"
        Me.lbl_total_administrasi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.btn_keluar)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 516)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(628, 50)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(520, 15)
        Me.btn_keluar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(100, 28)
        Me.btn_keluar.TabIndex = 0
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'group_data_peminjaman
        '
        Me.group_data_peminjaman.Controls.Add(Me.lbl_jumlah_data)
        Me.group_data_peminjaman.Controls.Add(Me.dgv_laporan_pendapatan_administrasi)
        Me.group_data_peminjaman.Controls.Add(Me.txt_search)
        Me.group_data_peminjaman.Location = New System.Drawing.Point(8, 146)
        Me.group_data_peminjaman.Margin = New System.Windows.Forms.Padding(4)
        Me.group_data_peminjaman.Name = "group_data_peminjaman"
        Me.group_data_peminjaman.Padding = New System.Windows.Forms.Padding(4)
        Me.group_data_peminjaman.Size = New System.Drawing.Size(607, 303)
        Me.group_data_peminjaman.TabIndex = 38
        Me.group_data_peminjaman.TabStop = False
        Me.group_data_peminjaman.Text = "Data Peminjaman"
        '
        'lbl_jumlah_data
        '
        Me.lbl_jumlah_data.AutoSize = True
        Me.lbl_jumlah_data.Location = New System.Drawing.Point(5, 276)
        Me.lbl_jumlah_data.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_jumlah_data.Name = "lbl_jumlah_data"
        Me.lbl_jumlah_data.Size = New System.Drawing.Size(107, 17)
        Me.lbl_jumlah_data.TabIndex = 2
        Me.lbl_jumlah_data.Text = "Jumlah Data : 0"
        '
        'dgv_laporan_pendapatan_administrasi
        '
        Me.dgv_laporan_pendapatan_administrasi.AllowUserToAddRows = False
        Me.dgv_laporan_pendapatan_administrasi.AllowUserToDeleteRows = False
        Me.dgv_laporan_pendapatan_administrasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_laporan_pendapatan_administrasi.Location = New System.Drawing.Point(9, 59)
        Me.dgv_laporan_pendapatan_administrasi.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_laporan_pendapatan_administrasi.Name = "dgv_laporan_pendapatan_administrasi"
        Me.dgv_laporan_pendapatan_administrasi.ReadOnly = True
        Me.dgv_laporan_pendapatan_administrasi.RowHeadersWidth = 51
        Me.dgv_laporan_pendapatan_administrasi.Size = New System.Drawing.Size(588, 213)
        Me.dgv_laporan_pendapatan_administrasi.TabIndex = 1
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(9, 25)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(587, 22)
        Me.txt_search.TabIndex = 0
        '
        'dtp_sampai
        '
        Me.dtp_sampai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_sampai.Location = New System.Drawing.Point(259, 14)
        Me.dtp_sampai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_sampai.Name = "dtp_sampai"
        Me.dtp_sampai.Size = New System.Drawing.Size(121, 22)
        Me.dtp_sampai.TabIndex = 9
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(389, 12)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(100, 28)
        Me.btn_refresh.TabIndex = 6
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'lbl_mulai
        '
        Me.lbl_mulai.AutoSize = True
        Me.lbl_mulai.Location = New System.Drawing.Point(13, 17)
        Me.lbl_mulai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mulai.Name = "lbl_mulai"
        Me.lbl_mulai.Size = New System.Drawing.Size(41, 17)
        Me.lbl_mulai.TabIndex = 4
        Me.lbl_mulai.Text = "Mulai"
        '
        'btn_cetak
        '
        Me.btn_cetak.Location = New System.Drawing.Point(497, 12)
        Me.btn_cetak.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(100, 28)
        Me.btn_cetak.TabIndex = 3
        Me.btn_cetak.Text = "Cetak"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'lbl_subjudul
        '
        Me.lbl_subjudul.AutoSize = True
        Me.lbl_subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subjudul.Location = New System.Drawing.Point(33, 41)
        Me.lbl_subjudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_subjudul.Name = "lbl_subjudul"
        Me.lbl_subjudul.Size = New System.Drawing.Size(441, 17)
        Me.lbl_subjudul.TabIndex = 2
        Me.lbl_subjudul.Text = "Form ini digunakan untuk laporan peminjaman atau piutang nasabah"
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_judul.Location = New System.Drawing.Point(17, 16)
        Me.lbl_judul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(337, 25)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Laporan Pendapatan Administrasi"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_subjudul)
        Me.Panel1.Controls.Add(Me.lbl_judul)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 74)
        Me.Panel1.TabIndex = 36
        '
        'dtp_mulai
        '
        Me.dtp_mulai.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_mulai.Location = New System.Drawing.Point(64, 14)
        Me.dtp_mulai.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_mulai.Name = "dtp_mulai"
        Me.dtp_mulai.Size = New System.Drawing.Size(121, 22)
        Me.dtp_mulai.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_sampai)
        Me.GroupBox1.Controls.Add(Me.lbl_sampai)
        Me.GroupBox1.Controls.Add(Me.dtp_mulai)
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.lbl_mulai)
        Me.GroupBox1.Controls.Add(Me.btn_cetak)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(607, 49)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'lbl_sampai
        '
        Me.lbl_sampai.AutoSize = True
        Me.lbl_sampai.Location = New System.Drawing.Point(195, 17)
        Me.lbl_sampai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sampai.Name = "lbl_sampai"
        Me.lbl_sampai.Size = New System.Drawing.Size(55, 17)
        Me.lbl_sampai.TabIndex = 8
        Me.lbl_sampai.Text = "Sampai"
        '
        'LaporanPendapatanAdministrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 565)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.group_data_peminjaman)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LaporanPendapatanAdministrasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.group_data_peminjaman.ResumeLayout(False)
        Me.group_data_peminjaman.PerformLayout()
        CType(Me.dgv_laporan_pendapatan_administrasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_total_administrasi As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_keluar As Button
    Friend WithEvents group_data_peminjaman As GroupBox
    Friend WithEvents lbl_jumlah_data As Label
    Friend WithEvents dgv_laporan_pendapatan_administrasi As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents dtp_sampai As DateTimePicker
    Friend WithEvents btn_refresh As Button
    Friend WithEvents lbl_mulai As Label
    Friend WithEvents btn_cetak As Button
    Friend WithEvents lbl_subjudul As Label
    Friend WithEvents lbl_judul As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtp_mulai As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_sampai As Label
End Class
