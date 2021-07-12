<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataTahun
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.group_DataThn = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_DataTahun = New System.Windows.Forms.DataGridView()
        Me.txt_CariDataThn = New System.Windows.Forms.TextBox()
        Me.grupInformasiTahun = New System.Windows.Forms.GroupBox()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.lbl_Keterangan = New System.Windows.Forms.Label()
        Me.cmb_StatusAktif = New System.Windows.Forms.ComboBox()
        Me.lbl_StatusAktif = New System.Windows.Forms.Label()
        Me.txt_Tahun = New System.Windows.Forms.TextBox()
        Me.lbl_Tahun = New System.Windows.Forms.Label()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.group_DataThn.SuspendLayout()
        CType(Me.dgv_DataTahun, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupInformasiTahun.SuspendLayout()
        Me.grupBtn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 65)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Form untuk menambah, mengubah, dan menghapus data tahun aktif"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(10, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Tahunan"
        '
        'group_DataThn
        '
        Me.group_DataThn.Controls.Add(Me.lbl_JumData)
        Me.group_DataThn.Controls.Add(Me.dgv_DataTahun)
        Me.group_DataThn.Controls.Add(Me.txt_CariDataThn)
        Me.group_DataThn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.group_DataThn.Location = New System.Drawing.Point(12, 69)
        Me.group_DataThn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataThn.Name = "group_DataThn"
        Me.group_DataThn.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataThn.Size = New System.Drawing.Size(309, 287)
        Me.group_DataThn.TabIndex = 4
        Me.group_DataThn.TabStop = False
        Me.group_DataThn.Text = "Data Tahun"
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_JumData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData.Location = New System.Drawing.Point(14, 258)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData.TabIndex = 7
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'dgv_DataTahun
        '
        Me.dgv_DataTahun.AllowUserToAddRows = False
        Me.dgv_DataTahun.AllowUserToDeleteRows = False
        Me.dgv_DataTahun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataTahun.Location = New System.Drawing.Point(14, 51)
        Me.dgv_DataTahun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_DataTahun.Name = "dgv_DataTahun"
        Me.dgv_DataTahun.ReadOnly = True
        Me.dgv_DataTahun.RowHeadersWidth = 51
        Me.dgv_DataTahun.RowTemplate.Height = 29
        Me.dgv_DataTahun.Size = New System.Drawing.Size(273, 200)
        Me.dgv_DataTahun.TabIndex = 6
        '
        'txt_CariDataThn
        '
        Me.txt_CariDataThn.Location = New System.Drawing.Point(14, 20)
        Me.txt_CariDataThn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_CariDataThn.Name = "txt_CariDataThn"
        Me.txt_CariDataThn.Size = New System.Drawing.Size(274, 23)
        Me.txt_CariDataThn.TabIndex = 5
        '
        'grupInformasiTahun
        '
        Me.grupInformasiTahun.Controls.Add(Me.btnBatal)
        Me.grupInformasiTahun.Controls.Add(Me.btnSimpan)
        Me.grupInformasiTahun.Controls.Add(Me.lbl_Keterangan)
        Me.grupInformasiTahun.Controls.Add(Me.cmb_StatusAktif)
        Me.grupInformasiTahun.Controls.Add(Me.lbl_StatusAktif)
        Me.grupInformasiTahun.Controls.Add(Me.txt_Tahun)
        Me.grupInformasiTahun.Controls.Add(Me.lbl_Tahun)
        Me.grupInformasiTahun.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.grupInformasiTahun.Location = New System.Drawing.Point(326, 69)
        Me.grupInformasiTahun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grupInformasiTahun.Name = "grupInformasiTahun"
        Me.grupInformasiTahun.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grupInformasiTahun.Size = New System.Drawing.Size(379, 287)
        Me.grupInformasiTahun.TabIndex = 5
        Me.grupInformasiTahun.TabStop = False
        Me.grupInformasiTahun.Text = "Informasi"
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(175, 79)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 32)
        Me.btnBatal.TabIndex = 10
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(94, 79)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 32)
        Me.btnSimpan.TabIndex = 9
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'lbl_Keterangan
        '
        Me.lbl_Keterangan.AutoSize = True
        Me.lbl_Keterangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_Keterangan.Location = New System.Drawing.Point(6, 258)
        Me.lbl_Keterangan.Name = "lbl_Keterangan"
        Me.lbl_Keterangan.Size = New System.Drawing.Size(98, 15)
        Me.lbl_Keterangan.TabIndex = 8
        Me.lbl_Keterangan.Text = "Tahun 2018 Aktif"
        '
        'cmb_StatusAktif
        '
        Me.cmb_StatusAktif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_StatusAktif.FormattingEnabled = True
        Me.cmb_StatusAktif.Items.AddRange(New Object() {"AKTIF", "NON-AKTIF"})
        Me.cmb_StatusAktif.Location = New System.Drawing.Point(94, 48)
        Me.cmb_StatusAktif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_StatusAktif.Name = "cmb_StatusAktif"
        Me.cmb_StatusAktif.Size = New System.Drawing.Size(133, 21)
        Me.cmb_StatusAktif.TabIndex = 3
        '
        'lbl_StatusAktif
        '
        Me.lbl_StatusAktif.AutoSize = True
        Me.lbl_StatusAktif.Location = New System.Drawing.Point(6, 51)
        Me.lbl_StatusAktif.Name = "lbl_StatusAktif"
        Me.lbl_StatusAktif.Size = New System.Drawing.Size(66, 15)
        Me.lbl_StatusAktif.TabIndex = 2
        Me.lbl_StatusAktif.Text = "Status Aktif"
        '
        'txt_Tahun
        '
        Me.txt_Tahun.Location = New System.Drawing.Point(94, 21)
        Me.txt_Tahun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Tahun.Name = "txt_Tahun"
        Me.txt_Tahun.Size = New System.Drawing.Size(110, 20)
        Me.txt_Tahun.TabIndex = 1
        '
        'lbl_Tahun
        '
        Me.lbl_Tahun.AutoSize = True
        Me.lbl_Tahun.Location = New System.Drawing.Point(6, 21)
        Me.lbl_Tahun.Name = "lbl_Tahun"
        Me.lbl_Tahun.Size = New System.Drawing.Size(42, 15)
        Me.lbl_Tahun.TabIndex = 0
        Me.lbl_Tahun.Text = "Tahun"
        '
        'grupBtn
        '
        Me.grupBtn.Controls.Add(Me.btnKeluar)
        Me.grupBtn.Controls.Add(Me.btnHapus)
        Me.grupBtn.Controls.Add(Me.btnUbah)
        Me.grupBtn.Controls.Add(Me.btnTambah)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Location = New System.Drawing.Point(0, 355)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Size = New System.Drawing.Size(722, 67)
        Me.grupBtn.TabIndex = 6
        Me.grupBtn.TabStop = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(630, 19)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 31)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(177, 20)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 31)
        Me.btnHapus.TabIndex = 2
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(96, 20)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 31)
        Me.btnUbah.TabIndex = 1
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(15, 20)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 31)
        Me.btnTambah.TabIndex = 0
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'FormDataTahun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 422)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.grupInformasiTahun)
        Me.Controls.Add(Me.group_DataThn)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDataTahun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_DataThn.ResumeLayout(False)
        Me.group_DataThn.PerformLayout()
        CType(Me.dgv_DataTahun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupInformasiTahun.ResumeLayout(False)
        Me.grupInformasiTahun.PerformLayout()
        Me.grupBtn.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents group_DataThn As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_DataTahun As DataGridView
    Friend WithEvents txt_CariDataThn As TextBox
    Friend WithEvents grupInformasiTahun As GroupBox
    Friend WithEvents lbl_Keterangan As Label
    Friend WithEvents cmb_StatusAktif As ComboBox
    Friend WithEvents lbl_StatusAktif As Label
    Friend WithEvents txt_Tahun As TextBox
    Friend WithEvents lbl_Tahun As Label
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
End Class
