<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengambilanSimpPokoknWajib
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_JumlahData = New System.Windows.Forms.Label()
        Me.dgv_DataAnggota = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_NominalUang = New System.Windows.Forms.Label()
        Me.group_InformasiAnggota = New System.Windows.Forms.GroupBox()
        Me.btn_Batal = New System.Windows.Forms.Button()
        Me.btn_Ambil = New System.Windows.Forms.Button()
        Me.dtp_TglAmbil = New System.Windows.Forms.DateTimePicker()
        Me.txt_Nama = New System.Windows.Forms.TextBox()
        Me.btn_CariAnggota = New System.Windows.Forms.Button()
        Me.txt_KodeAnggota = New System.Windows.Forms.TextBox()
        Me.lbl_TglAmbil = New System.Windows.Forms.Label()
        Me.lbl_Nama = New System.Windows.Forms.Label()
        Me.lbl_KodeAnggota = New System.Windows.Forms.Label()
        Me.groupBtn = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.btn_Tambah = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.group_InformasiAnggota.SuspendLayout()
        Me.groupBtn.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Form ini digunakan untuk pengambilan simpanan pokok dan wajib"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Pengambilan Simpanan Pokok dan Wajib"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_JumlahData)
        Me.GroupBox1.Controls.Add(Me.dgv_DataAnggota)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 380)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Anggota"
        '
        'lbl_JumlahData
        '
        Me.lbl_JumlahData.AutoSize = True
        Me.lbl_JumlahData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumlahData.Location = New System.Drawing.Point(9, 345)
        Me.lbl_JumlahData.Name = "lbl_JumlahData"
        Me.lbl_JumlahData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumlahData.TabIndex = 3
        Me.lbl_JumlahData.Text = "Jumlah Data : 0"
        '
        'dgv_DataAnggota
        '
        Me.dgv_DataAnggota.AllowUserToAddRows = False
        Me.dgv_DataAnggota.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota.Location = New System.Drawing.Point(12, 20)
        Me.dgv_DataAnggota.Name = "dgv_DataAnggota"
        Me.dgv_DataAnggota.ReadOnly = True
        Me.dgv_DataAnggota.RowHeadersWidth = 51
        Me.dgv_DataAnggota.RowTemplate.Height = 29
        Me.dgv_DataAnggota.Size = New System.Drawing.Size(337, 322)
        Me.dgv_DataAnggota.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbl_NominalUang)
        Me.Panel2.Location = New System.Drawing.Point(382, 89)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 77)
        Me.Panel2.TabIndex = 3
        '
        'lbl_NominalUang
        '
        Me.lbl_NominalUang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_NominalUang.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Italic)
        Me.lbl_NominalUang.ForeColor = System.Drawing.Color.Red
        Me.lbl_NominalUang.Location = New System.Drawing.Point(0, 0)
        Me.lbl_NominalUang.Name = "lbl_NominalUang"
        Me.lbl_NominalUang.Size = New System.Drawing.Size(481, 75)
        Me.lbl_NominalUang.TabIndex = 0
        Me.lbl_NominalUang.Text = "0"
        Me.lbl_NominalUang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'group_InformasiAnggota
        '
        Me.group_InformasiAnggota.Controls.Add(Me.btn_Batal)
        Me.group_InformasiAnggota.Controls.Add(Me.btn_Ambil)
        Me.group_InformasiAnggota.Controls.Add(Me.dtp_TglAmbil)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.btn_CariAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.txt_KodeAnggota)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_TglAmbil)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_Nama)
        Me.group_InformasiAnggota.Controls.Add(Me.lbl_KodeAnggota)
        Me.group_InformasiAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_InformasiAnggota.Location = New System.Drawing.Point(382, 172)
        Me.group_InformasiAnggota.Name = "group_InformasiAnggota"
        Me.group_InformasiAnggota.Size = New System.Drawing.Size(483, 288)
        Me.group_InformasiAnggota.TabIndex = 4
        Me.group_InformasiAnggota.TabStop = False
        Me.group_InformasiAnggota.Text = "Informasi Anggota"
        '
        'btn_Batal
        '
        Me.btn_Batal.Location = New System.Drawing.Point(243, 105)
        Me.btn_Batal.Name = "btn_Batal"
        Me.btn_Batal.Size = New System.Drawing.Size(94, 29)
        Me.btn_Batal.TabIndex = 13
        Me.btn_Batal.Text = "Batal"
        Me.btn_Batal.UseVisualStyleBackColor = True
        '
        'btn_Ambil
        '
        Me.btn_Ambil.Location = New System.Drawing.Point(143, 105)
        Me.btn_Ambil.Name = "btn_Ambil"
        Me.btn_Ambil.Size = New System.Drawing.Size(94, 29)
        Me.btn_Ambil.TabIndex = 12
        Me.btn_Ambil.Text = "Ambil"
        Me.btn_Ambil.UseVisualStyleBackColor = True
        '
        'dtp_TglAmbil
        '
        Me.dtp_TglAmbil.Location = New System.Drawing.Point(143, 79)
        Me.dtp_TglAmbil.Name = "dtp_TglAmbil"
        Me.dtp_TglAmbil.Size = New System.Drawing.Size(213, 20)
        Me.dtp_TglAmbil.TabIndex = 11
        '
        'txt_Nama
        '
        Me.txt_Nama.BackColor = System.Drawing.SystemColors.Window
        Me.txt_Nama.Location = New System.Drawing.Point(143, 53)
        Me.txt_Nama.Name = "txt_Nama"
        Me.txt_Nama.ReadOnly = True
        Me.txt_Nama.Size = New System.Drawing.Size(321, 20)
        Me.txt_Nama.TabIndex = 10
        '
        'btn_CariAnggota
        '
        Me.btn_CariAnggota.Location = New System.Drawing.Point(312, 24)
        Me.btn_CariAnggota.Name = "btn_CariAnggota"
        Me.btn_CariAnggota.Size = New System.Drawing.Size(106, 24)
        Me.btn_CariAnggota.TabIndex = 9
        Me.btn_CariAnggota.Text = "Cari Anggota"
        Me.btn_CariAnggota.UseVisualStyleBackColor = True
        '
        'txt_KodeAnggota
        '
        Me.txt_KodeAnggota.BackColor = System.Drawing.SystemColors.Window
        Me.txt_KodeAnggota.Location = New System.Drawing.Point(143, 27)
        Me.txt_KodeAnggota.Name = "txt_KodeAnggota"
        Me.txt_KodeAnggota.ReadOnly = True
        Me.txt_KodeAnggota.Size = New System.Drawing.Size(161, 20)
        Me.txt_KodeAnggota.TabIndex = 8
        '
        'lbl_TglAmbil
        '
        Me.lbl_TglAmbil.AutoSize = True
        Me.lbl_TglAmbil.Location = New System.Drawing.Point(15, 85)
        Me.lbl_TglAmbil.Name = "lbl_TglAmbil"
        Me.lbl_TglAmbil.Size = New System.Drawing.Size(86, 15)
        Me.lbl_TglAmbil.TabIndex = 7
        Me.lbl_TglAmbil.Text = "Tanggal Ambil"
        '
        'lbl_Nama
        '
        Me.lbl_Nama.AutoSize = True
        Me.lbl_Nama.Location = New System.Drawing.Point(15, 58)
        Me.lbl_Nama.Name = "lbl_Nama"
        Me.lbl_Nama.Size = New System.Drawing.Size(41, 15)
        Me.lbl_Nama.TabIndex = 6
        Me.lbl_Nama.Text = "Nama"
        '
        'lbl_KodeAnggota
        '
        Me.lbl_KodeAnggota.AutoSize = True
        Me.lbl_KodeAnggota.Location = New System.Drawing.Point(15, 30)
        Me.lbl_KodeAnggota.Name = "lbl_KodeAnggota"
        Me.lbl_KodeAnggota.Size = New System.Drawing.Size(84, 15)
        Me.lbl_KodeAnggota.TabIndex = 5
        Me.lbl_KodeAnggota.Text = "Kode Anggota"
        '
        'groupBtn
        '
        Me.groupBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.groupBtn.Controls.Add(Me.btn_Keluar)
        Me.groupBtn.Controls.Add(Me.btn_Tambah)
        Me.groupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.groupBtn.Location = New System.Drawing.Point(0, 466)
        Me.groupBtn.Name = "groupBtn"
        Me.groupBtn.Size = New System.Drawing.Size(874, 46)
        Me.groupBtn.TabIndex = 5
        Me.groupBtn.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Location = New System.Drawing.Point(771, 11)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(94, 29)
        Me.btn_Keluar.TabIndex = 7
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'btn_Tambah
        '
        Me.btn_Tambah.Location = New System.Drawing.Point(12, 11)
        Me.btn_Tambah.Name = "btn_Tambah"
        Me.btn_Tambah.Size = New System.Drawing.Size(94, 29)
        Me.btn_Tambah.TabIndex = 6
        Me.btn_Tambah.Text = "Tambah"
        Me.btn_Tambah.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 74)
        Me.Panel1.TabIndex = 0
        '
        'FormPengambilanSimpPokoknWajib
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 512)
        Me.Controls.Add(Me.groupBtn)
        Me.Controls.Add(Me.group_InformasiAnggota)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPengambilanSimpPokoknWajib"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.group_InformasiAnggota.ResumeLayout(False)
        Me.group_InformasiAnggota.PerformLayout()
        Me.groupBtn.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_JumlahData As Label
    Friend WithEvents dgv_DataAnggota As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_NominalUang As Label
    Friend WithEvents group_InformasiAnggota As GroupBox
    Friend WithEvents btn_Batal As Button
    Friend WithEvents btn_Ambil As Button
    Friend WithEvents dtp_TglAmbil As DateTimePicker
    Friend WithEvents txt_Nama As TextBox
    Friend WithEvents btn_CariAnggota As Button
    Friend WithEvents txt_KodeAnggota As TextBox
    Friend WithEvents lbl_TglAmbil As Label
    Friend WithEvents lbl_Nama As Label
    Friend WithEvents lbl_KodeAnggota As Label
    Friend WithEvents groupBtn As GroupBox
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents btn_Tambah As Button
    Friend WithEvents Panel1 As Panel
End Class
