<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanHistoriPembayaranPiutangNasabah
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
        Me.lbl_jumlah_data = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_bayar = New System.Windows.Forms.Label()
        Me.group_data_pembayaran = New System.Windows.Forms.GroupBox()
        Me.dgv_data_pembayaran = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.cmb_status_pembayaran = New System.Windows.Forms.ComboBox()
        Me.lbl_status_pembayaran = New System.Windows.Forms.Label()
        Me.lbl_sub_judul = New System.Windows.Forms.Label()
        Me.lbl_judul = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.group_data_pembayaran.SuspendLayout()
        CType(Me.dgv_data_pembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_jumlah_data
        '
        Me.lbl_jumlah_data.AutoSize = True
        Me.lbl_jumlah_data.Location = New System.Drawing.Point(4, 224)
        Me.lbl_jumlah_data.Name = "lbl_jumlah_data"
        Me.lbl_jumlah_data.Size = New System.Drawing.Size(81, 13)
        Me.lbl_jumlah_data.TabIndex = 2
        Me.lbl_jumlah_data.Text = "Jumlah Data : 3"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_keluar)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 410)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(657, 41)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(568, 12)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 0
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_bayar)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 371)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(657, 33)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'lbl_bayar
        '
        Me.lbl_bayar.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_bayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bayar.ForeColor = System.Drawing.Color.Red
        Me.lbl_bayar.Location = New System.Drawing.Point(3, 16)
        Me.lbl_bayar.Name = "lbl_bayar"
        Me.lbl_bayar.Size = New System.Drawing.Size(651, 17)
        Me.lbl_bayar.TabIndex = 0
        Me.lbl_bayar.Text = "Bayar :  0 Pokok : 0 Bunga : 0"
        Me.lbl_bayar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'group_data_pembayaran
        '
        Me.group_data_pembayaran.Controls.Add(Me.lbl_jumlah_data)
        Me.group_data_pembayaran.Controls.Add(Me.dgv_data_pembayaran)
        Me.group_data_pembayaran.Controls.Add(Me.txt_search)
        Me.group_data_pembayaran.Location = New System.Drawing.Point(6, 119)
        Me.group_data_pembayaran.Name = "group_data_pembayaran"
        Me.group_data_pembayaran.Size = New System.Drawing.Size(637, 246)
        Me.group_data_pembayaran.TabIndex = 23
        Me.group_data_pembayaran.TabStop = False
        Me.group_data_pembayaran.Text = "Data Pembayaran"
        '
        'dgv_data_pembayaran
        '
        Me.dgv_data_pembayaran.AllowUserToAddRows = False
        Me.dgv_data_pembayaran.AllowUserToDeleteRows = False
        Me.dgv_data_pembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_pembayaran.Location = New System.Drawing.Point(7, 48)
        Me.dgv_data_pembayaran.Name = "dgv_data_pembayaran"
        Me.dgv_data_pembayaran.ReadOnly = True
        Me.dgv_data_pembayaran.RowHeadersWidth = 51
        Me.dgv_data_pembayaran.Size = New System.Drawing.Size(624, 173)
        Me.dgv_data_pembayaran.TabIndex = 1
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(7, 20)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(624, 20)
        Me.txt_search.TabIndex = 0
        '
        'btn_cetak
        '
        Me.btn_cetak.Location = New System.Drawing.Point(556, 11)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(75, 23)
        Me.btn_cetak.TabIndex = 3
        Me.btn_cetak.Text = "Cetak"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.cmb_status_pembayaran)
        Me.GroupBox1.Controls.Add(Me.lbl_status_pembayaran)
        Me.GroupBox1.Controls.Add(Me.btn_cetak)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(637, 40)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(392, 11)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 23)
        Me.btn_refresh.TabIndex = 6
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'cmb_status_pembayaran
        '
        Me.cmb_status_pembayaran.FormattingEnabled = True
        Me.cmb_status_pembayaran.Items.AddRange(New Object() {"BELUM LUNAS", "SUDAH LUNAS", "SEMUA"})
        Me.cmb_status_pembayaran.Location = New System.Drawing.Point(115, 13)
        Me.cmb_status_pembayaran.Name = "cmb_status_pembayaran"
        Me.cmb_status_pembayaran.Size = New System.Drawing.Size(271, 21)
        Me.cmb_status_pembayaran.TabIndex = 5
        '
        'lbl_status_pembayaran
        '
        Me.lbl_status_pembayaran.AutoSize = True
        Me.lbl_status_pembayaran.Location = New System.Drawing.Point(10, 16)
        Me.lbl_status_pembayaran.Name = "lbl_status_pembayaran"
        Me.lbl_status_pembayaran.Size = New System.Drawing.Size(99, 13)
        Me.lbl_status_pembayaran.TabIndex = 4
        Me.lbl_status_pembayaran.Text = "Status Pembayaran"
        '
        'lbl_sub_judul
        '
        Me.lbl_sub_judul.AutoSize = True
        Me.lbl_sub_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sub_judul.Location = New System.Drawing.Point(25, 33)
        Me.lbl_sub_judul.Name = "lbl_sub_judul"
        Me.lbl_sub_judul.Size = New System.Drawing.Size(339, 13)
        Me.lbl_sub_judul.TabIndex = 2
        Me.lbl_sub_judul.Text = "Form ini digunakan untuk laporan Histori pembayaran piutang nasabah"
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_judul.Location = New System.Drawing.Point(13, 13)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(382, 20)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Laporan History Pembayaran Piutang Nasabah"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lbl_sub_judul)
        Me.Panel1.Controls.Add(Me.lbl_judul)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 60)
        Me.Panel1.TabIndex = 2
        '
        'LaporanHistoriPembayaranPiutangNasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.group_data_pembayaran)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LaporanHistoriPembayaranPiutangNasabah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.group_data_pembayaran.ResumeLayout(False)
        Me.group_data_pembayaran.PerformLayout()
        CType(Me.dgv_data_pembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_jumlah_data As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_keluar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_bayar As Label
    Friend WithEvents group_data_pembayaran As GroupBox
    Friend WithEvents dgv_data_pembayaran As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents btn_cetak As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_refresh As Button
    Friend WithEvents cmb_status_pembayaran As ComboBox
    Friend WithEvents lbl_status_pembayaran As Label
    Friend WithEvents lbl_sub_judul As Label
    Friend WithEvents lbl_judul As Label
    Friend WithEvents Panel1 As Panel
End Class
