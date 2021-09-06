<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuatBilling
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
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.btn_BuatBiling = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgv_DataAnggota2 = New System.Windows.Forms.DataGridView()
        Me.txt_CariDataAnggota2 = New System.Windows.Forms.TextBox()
        Me.lbl_JumData2 = New System.Windows.Forms.Label()
        Me.group_CariDataAnggota2 = New System.Windows.Forms.GroupBox()
        Me.btn_hapusSemua = New System.Windows.Forms.Button()
        Me.lbl_JumData1 = New System.Windows.Forms.Label()
        Me.dgv_DataAnggota1 = New System.Windows.Forms.DataGridView()
        Me.txt_CariDataAnggota1 = New System.Windows.Forms.TextBox()
        Me.group_CariDataAnggota1 = New System.Windows.Forms.GroupBox()
        Me.txt_BesarSimpanan = New System.Windows.Forms.TextBox()
        Me.lbl_BesarSimpanan = New System.Windows.Forms.Label()
        Me.txt_Tahun = New System.Windows.Forms.TextBox()
        Me.lbl_Tahun = New System.Windows.Forms.Label()
        Me.cmb_JenisSimpanan = New System.Windows.Forms.ComboBox()
        Me.group_JenisSimpanan = New System.Windows.Forms.GroupBox()
        Me.cmb_Bulan = New System.Windows.Forms.ComboBox()
        Me.lbl_Bulan = New System.Windows.Forms.Label()
        Me.cmb_JenisSimp = New System.Windows.Forms.ComboBox()
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_PilihSemua = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_DataAnggota2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_CariDataAnggota2.SuspendLayout()
        CType(Me.dgv_DataAnggota1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_CariDataAnggota1.SuspendLayout()
        Me.group_JenisSimpanan.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Keluar.Location = New System.Drawing.Point(694, 16)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(146, 26)
        Me.btn_Keluar.TabIndex = 16
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'btn_BuatBiling
        '
        Me.btn_BuatBiling.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_BuatBiling.Location = New System.Drawing.Point(19, 16)
        Me.btn_BuatBiling.Name = "btn_BuatBiling"
        Me.btn_BuatBiling.Size = New System.Drawing.Size(180, 26)
        Me.btn_BuatBiling.TabIndex = 15
        Me.btn_BuatBiling.Text = "Buat Billing"
        Me.btn_BuatBiling.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.btn_Keluar)
        Me.GroupBox4.Controls.Add(Me.btn_BuatBiling)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(0, 549)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(864, 48)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        '
        'dgv_DataAnggota2
        '
        Me.dgv_DataAnggota2.AllowUserToAddRows = False
        Me.dgv_DataAnggota2.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota2.Location = New System.Drawing.Point(16, 64)
        Me.dgv_DataAnggota2.Name = "dgv_DataAnggota2"
        Me.dgv_DataAnggota2.ReadOnly = True
        Me.dgv_DataAnggota2.RowHeadersWidth = 51
        Me.dgv_DataAnggota2.RowTemplate.Height = 29
        Me.dgv_DataAnggota2.Size = New System.Drawing.Size(351, 273)
        Me.dgv_DataAnggota2.TabIndex = 14
        '
        'txt_CariDataAnggota2
        '
        Me.txt_CariDataAnggota2.Location = New System.Drawing.Point(16, 24)
        Me.txt_CariDataAnggota2.Name = "txt_CariDataAnggota2"
        Me.txt_CariDataAnggota2.Size = New System.Drawing.Size(351, 20)
        Me.txt_CariDataAnggota2.TabIndex = 13
        '
        'lbl_JumData2
        '
        Me.lbl_JumData2.AutoSize = True
        Me.lbl_JumData2.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData2.Location = New System.Drawing.Point(13, 340)
        Me.lbl_JumData2.Name = "lbl_JumData2"
        Me.lbl_JumData2.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData2.TabIndex = 12
        Me.lbl_JumData2.Text = "Jumlah Data : 0"
        '
        'group_CariDataAnggota2
        '
        Me.group_CariDataAnggota2.Controls.Add(Me.dgv_DataAnggota2)
        Me.group_CariDataAnggota2.Controls.Add(Me.txt_CariDataAnggota2)
        Me.group_CariDataAnggota2.Controls.Add(Me.lbl_JumData2)
        Me.group_CariDataAnggota2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_CariDataAnggota2.Location = New System.Drawing.Point(473, 166)
        Me.group_CariDataAnggota2.Name = "group_CariDataAnggota2"
        Me.group_CariDataAnggota2.Size = New System.Drawing.Size(383, 380)
        Me.group_CariDataAnggota2.TabIndex = 18
        Me.group_CariDataAnggota2.TabStop = False
        Me.group_CariDataAnggota2.Text = "Cari Data Anggota"
        '
        'btn_hapusSemua
        '
        Me.btn_hapusSemua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_hapusSemua.Location = New System.Drawing.Point(9, 214)
        Me.btn_hapusSemua.Name = "btn_hapusSemua"
        Me.btn_hapusSemua.Size = New System.Drawing.Size(60, 31)
        Me.btn_hapusSemua.TabIndex = 16
        Me.btn_hapusSemua.Text = "<<"
        Me.btn_hapusSemua.UseVisualStyleBackColor = True
        '
        'lbl_JumData1
        '
        Me.lbl_JumData1.AutoSize = True
        Me.lbl_JumData1.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData1.Location = New System.Drawing.Point(6, 340)
        Me.lbl_JumData1.Name = "lbl_JumData1"
        Me.lbl_JumData1.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData1.TabIndex = 11
        Me.lbl_JumData1.Text = "Jumlah Data : 0"
        '
        'dgv_DataAnggota1
        '
        Me.dgv_DataAnggota1.AllowUserToAddRows = False
        Me.dgv_DataAnggota1.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota1.Location = New System.Drawing.Point(9, 64)
        Me.dgv_DataAnggota1.Name = "dgv_DataAnggota1"
        Me.dgv_DataAnggota1.ReadOnly = True
        Me.dgv_DataAnggota1.RowHeadersWidth = 51
        Me.dgv_DataAnggota1.RowTemplate.Height = 29
        Me.dgv_DataAnggota1.Size = New System.Drawing.Size(351, 273)
        Me.dgv_DataAnggota1.TabIndex = 5
        '
        'txt_CariDataAnggota1
        '
        Me.txt_CariDataAnggota1.Location = New System.Drawing.Point(6, 24)
        Me.txt_CariDataAnggota1.Name = "txt_CariDataAnggota1"
        Me.txt_CariDataAnggota1.Size = New System.Drawing.Size(350, 20)
        Me.txt_CariDataAnggota1.TabIndex = 5
        '
        'group_CariDataAnggota1
        '
        Me.group_CariDataAnggota1.Controls.Add(Me.lbl_JumData1)
        Me.group_CariDataAnggota1.Controls.Add(Me.dgv_DataAnggota1)
        Me.group_CariDataAnggota1.Controls.Add(Me.txt_CariDataAnggota1)
        Me.group_CariDataAnggota1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_CariDataAnggota1.Location = New System.Drawing.Point(19, 166)
        Me.group_CariDataAnggota1.Name = "group_CariDataAnggota1"
        Me.group_CariDataAnggota1.Size = New System.Drawing.Size(369, 380)
        Me.group_CariDataAnggota1.TabIndex = 13
        Me.group_CariDataAnggota1.TabStop = False
        Me.group_CariDataAnggota1.Text = "Cari Data Anggota"
        '
        'txt_BesarSimpanan
        '
        Me.txt_BesarSimpanan.Location = New System.Drawing.Point(637, 20)
        Me.txt_BesarSimpanan.Name = "txt_BesarSimpanan"
        Me.txt_BesarSimpanan.Size = New System.Drawing.Size(184, 20)
        Me.txt_BesarSimpanan.TabIndex = 3
        '
        'lbl_BesarSimpanan
        '
        Me.lbl_BesarSimpanan.AutoSize = True
        Me.lbl_BesarSimpanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.lbl_BesarSimpanan.Location = New System.Drawing.Point(505, 23)
        Me.lbl_BesarSimpanan.Name = "lbl_BesarSimpanan"
        Me.lbl_BesarSimpanan.Size = New System.Drawing.Size(99, 15)
        Me.lbl_BesarSimpanan.TabIndex = 2
        Me.lbl_BesarSimpanan.Text = "Besar Simpanan"
        '
        'txt_Tahun
        '
        Me.txt_Tahun.Location = New System.Drawing.Point(311, 23)
        Me.txt_Tahun.Name = "txt_Tahun"
        Me.txt_Tahun.ReadOnly = True
        Me.txt_Tahun.Size = New System.Drawing.Size(139, 20)
        Me.txt_Tahun.TabIndex = 2
        '
        'lbl_Tahun
        '
        Me.lbl_Tahun.AutoSize = True
        Me.lbl_Tahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.lbl_Tahun.Location = New System.Drawing.Point(257, 27)
        Me.lbl_Tahun.Name = "lbl_Tahun"
        Me.lbl_Tahun.Size = New System.Drawing.Size(42, 15)
        Me.lbl_Tahun.TabIndex = 1
        Me.lbl_Tahun.Text = "Tahun"
        '
        'cmb_JenisSimpanan
        '
        Me.cmb_JenisSimpanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JenisSimpanan.FormattingEnabled = True
        Me.cmb_JenisSimpanan.Items.AddRange(New Object() {"POKOK", "WAJIB", "SALDO AWAL"})
        Me.cmb_JenisSimpanan.Location = New System.Drawing.Point(12, 23)
        Me.cmb_JenisSimpanan.Name = "cmb_JenisSimpanan"
        Me.cmb_JenisSimpanan.Size = New System.Drawing.Size(213, 21)
        Me.cmb_JenisSimpanan.TabIndex = 0
        '
        'group_JenisSimpanan
        '
        Me.group_JenisSimpanan.Controls.Add(Me.cmb_Bulan)
        Me.group_JenisSimpanan.Controls.Add(Me.lbl_Bulan)
        Me.group_JenisSimpanan.Controls.Add(Me.cmb_JenisSimp)
        Me.group_JenisSimpanan.Controls.Add(Me.txt_BesarSimpanan)
        Me.group_JenisSimpanan.Controls.Add(Me.lbl_BesarSimpanan)
        Me.group_JenisSimpanan.Controls.Add(Me.txt_Tahun)
        Me.group_JenisSimpanan.Controls.Add(Me.lbl_Tahun)
        Me.group_JenisSimpanan.Controls.Add(Me.cmb_JenisSimpanan)
        Me.group_JenisSimpanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_JenisSimpanan.Location = New System.Drawing.Point(19, 73)
        Me.group_JenisSimpanan.Name = "group_JenisSimpanan"
        Me.group_JenisSimpanan.Size = New System.Drawing.Size(837, 87)
        Me.group_JenisSimpanan.TabIndex = 12
        Me.group_JenisSimpanan.TabStop = False
        Me.group_JenisSimpanan.Text = "Jenis Simpanan"
        '
        'cmb_Bulan
        '
        Me.cmb_Bulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Bulan.FormattingEnabled = True
        Me.cmb_Bulan.Items.AddRange(New Object() {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI ", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"})
        Me.cmb_Bulan.Location = New System.Drawing.Point(311, 53)
        Me.cmb_Bulan.Name = "cmb_Bulan"
        Me.cmb_Bulan.Size = New System.Drawing.Size(139, 21)
        Me.cmb_Bulan.TabIndex = 6
        Me.cmb_Bulan.Visible = False
        '
        'lbl_Bulan
        '
        Me.lbl_Bulan.AutoSize = True
        Me.lbl_Bulan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.lbl_Bulan.Location = New System.Drawing.Point(260, 56)
        Me.lbl_Bulan.Name = "lbl_Bulan"
        Me.lbl_Bulan.Size = New System.Drawing.Size(39, 15)
        Me.lbl_Bulan.TabIndex = 5
        Me.lbl_Bulan.Text = "Bulan"
        Me.lbl_Bulan.Visible = False
        '
        'cmb_JenisSimp
        '
        Me.cmb_JenisSimp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JenisSimp.FormattingEnabled = True
        Me.cmb_JenisSimp.Location = New System.Drawing.Point(12, 53)
        Me.cmb_JenisSimp.Name = "cmb_JenisSimp"
        Me.cmb_JenisSimp.Size = New System.Drawing.Size(213, 21)
        Me.cmb_JenisSimp.TabIndex = 4
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_Subjudul.Location = New System.Drawing.Point(39, 37)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(447, 15)
        Me.lbl_Subjudul.TabIndex = 7
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk membuat tagihan Simpanan Pokok, Wajib, Saldo Awal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Buat Tagihan Simpanan Pokok , Wajib, Saldo Awal"
        '
        'btn_PilihSemua
        '
        Me.btn_PilihSemua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_PilihSemua.Location = New System.Drawing.Point(9, 118)
        Me.btn_PilihSemua.Name = "btn_PilihSemua"
        Me.btn_PilihSemua.Size = New System.Drawing.Size(60, 31)
        Me.btn_PilihSemua.TabIndex = 14
        Me.btn_PilihSemua.Text = ">>"
        Me.btn_PilihSemua.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(864, 67)
        Me.Panel1.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_PilihSemua)
        Me.GroupBox1.Controls.Add(Me.btn_hapusSemua)
        Me.GroupBox1.Location = New System.Drawing.Point(392, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(75, 380)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'FormBuatBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 597)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.group_CariDataAnggota2)
        Me.Controls.Add(Me.group_CariDataAnggota1)
        Me.Controls.Add(Me.group_JenisSimpanan)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBuatBilling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgv_DataAnggota2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_CariDataAnggota2.ResumeLayout(False)
        Me.group_CariDataAnggota2.PerformLayout()
        CType(Me.dgv_DataAnggota1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_CariDataAnggota1.ResumeLayout(False)
        Me.group_CariDataAnggota1.PerformLayout()
        Me.group_JenisSimpanan.ResumeLayout(False)
        Me.group_JenisSimpanan.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Keluar As Button
    Friend WithEvents btn_BuatBiling As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgv_DataAnggota2 As DataGridView
    Friend WithEvents txt_CariDataAnggota2 As TextBox
    Friend WithEvents lbl_JumData2 As Label
    Friend WithEvents group_CariDataAnggota2 As GroupBox
    Friend WithEvents btn_hapusSemua As Button
    Friend WithEvents lbl_JumData1 As Label
    Friend WithEvents dgv_DataAnggota1 As DataGridView
    Friend WithEvents txt_CariDataAnggota1 As TextBox
    Friend WithEvents group_CariDataAnggota1 As GroupBox
    Friend WithEvents txt_BesarSimpanan As TextBox
    Friend WithEvents lbl_BesarSimpanan As Label
    Friend WithEvents txt_Tahun As TextBox
    Friend WithEvents lbl_Tahun As Label
    Friend WithEvents cmb_JenisSimpanan As ComboBox
    Friend WithEvents group_JenisSimpanan As GroupBox
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_PilihSemua As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_Bulan As ComboBox
    Friend WithEvents lbl_Bulan As Label
    Friend WithEvents cmb_JenisSimp As ComboBox
End Class
