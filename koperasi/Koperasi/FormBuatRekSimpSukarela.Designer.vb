<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBuatRekSimpSukarela
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
        Me.btn_BuatRekening = New System.Windows.Forms.Button()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgv_DataAnggota2 = New System.Windows.Forms.DataGridView()
        Me.lbl_JumData2 = New System.Windows.Forms.Label()
        Me.txt_CariDataAnggota2 = New System.Windows.Forms.TextBox()
        Me.group_CariDataAnggota2 = New System.Windows.Forms.GroupBox()
        Me.btn_Last = New System.Windows.Forms.Button()
        Me.btn_First = New System.Windows.Forms.Button()
        Me.txt_CariDataAnggota = New System.Windows.Forms.TextBox()
        Me.dgv_DataAnggota = New System.Windows.Forms.DataGridView()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.group_CariDataAnggota = New System.Windows.Forms.GroupBox()
        Me.cmb_JenisSimpanan = New System.Windows.Forms.ComboBox()
        Me.lbl_Bunga = New System.Windows.Forms.Label()
        Me.txt_Bunga = New System.Windows.Forms.TextBox()
        Me.group_JenisSimpanan = New System.Windows.Forms.GroupBox()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_DataAnggota2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_CariDataAnggota2.SuspendLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_CariDataAnggota.SuspendLayout()
        Me.group_JenisSimpanan.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_BuatRekening
        '
        Me.btn_BuatRekening.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_BuatRekening.Location = New System.Drawing.Point(6, 23)
        Me.btn_BuatRekening.Name = "btn_BuatRekening"
        Me.btn_BuatRekening.Size = New System.Drawing.Size(164, 27)
        Me.btn_BuatRekening.TabIndex = 2
        Me.btn_BuatRekening.Text = "Buat Rekening"
        Me.btn_BuatRekening.UseVisualStyleBackColor = True
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Keluar.Location = New System.Drawing.Point(738, 17)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(164, 27)
        Me.btn_Keluar.TabIndex = 3
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.btn_Keluar)
        Me.GroupBox4.Controls.Add(Me.btn_BuatRekening)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Location = New System.Drawing.Point(0, 534)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(934, 56)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'dgv_DataAnggota2
        '
        Me.dgv_DataAnggota2.AllowUserToAddRows = False
        Me.dgv_DataAnggota2.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota2.Location = New System.Drawing.Point(15, 61)
        Me.dgv_DataAnggota2.Name = "dgv_DataAnggota2"
        Me.dgv_DataAnggota2.ReadOnly = True
        Me.dgv_DataAnggota2.RowHeadersWidth = 51
        Me.dgv_DataAnggota2.RowTemplate.Height = 29
        Me.dgv_DataAnggota2.Size = New System.Drawing.Size(373, 246)
        Me.dgv_DataAnggota2.TabIndex = 10
        '
        'lbl_JumData2
        '
        Me.lbl_JumData2.AutoSize = True
        Me.lbl_JumData2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.lbl_JumData2.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData2.Location = New System.Drawing.Point(12, 318)
        Me.lbl_JumData2.Name = "lbl_JumData2"
        Me.lbl_JumData2.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData2.TabIndex = 12
        Me.lbl_JumData2.Text = "Jumlah Data : 0"
        '
        'txt_CariDataAnggota2
        '
        Me.txt_CariDataAnggota2.Location = New System.Drawing.Point(15, 26)
        Me.txt_CariDataAnggota2.Name = "txt_CariDataAnggota2"
        Me.txt_CariDataAnggota2.Size = New System.Drawing.Size(374, 20)
        Me.txt_CariDataAnggota2.TabIndex = 13
        '
        'group_CariDataAnggota2
        '
        Me.group_CariDataAnggota2.Controls.Add(Me.txt_CariDataAnggota2)
        Me.group_CariDataAnggota2.Controls.Add(Me.lbl_JumData2)
        Me.group_CariDataAnggota2.Controls.Add(Me.dgv_DataAnggota2)
        Me.group_CariDataAnggota2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_CariDataAnggota2.Location = New System.Drawing.Point(516, 172)
        Me.group_CariDataAnggota2.Name = "group_CariDataAnggota2"
        Me.group_CariDataAnggota2.Size = New System.Drawing.Size(403, 348)
        Me.group_CariDataAnggota2.TabIndex = 20
        Me.group_CariDataAnggota2.TabStop = False
        Me.group_CariDataAnggota2.Text = "Cari Data Anggota"
        '
        'btn_Last
        '
        Me.btn_Last.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Last.Location = New System.Drawing.Point(428, 281)
        Me.btn_Last.Name = "btn_Last"
        Me.btn_Last.Size = New System.Drawing.Size(77, 54)
        Me.btn_Last.TabIndex = 16
        Me.btn_Last.Text = ">>"
        Me.btn_Last.UseVisualStyleBackColor = True
        '
        'btn_First
        '
        Me.btn_First.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_First.Location = New System.Drawing.Point(428, 341)
        Me.btn_First.Name = "btn_First"
        Me.btn_First.Size = New System.Drawing.Size(77, 54)
        Me.btn_First.TabIndex = 18
        Me.btn_First.Text = "<<"
        Me.btn_First.UseVisualStyleBackColor = True
        '
        'txt_CariDataAnggota
        '
        Me.txt_CariDataAnggota.Location = New System.Drawing.Point(12, 26)
        Me.txt_CariDataAnggota.Name = "txt_CariDataAnggota"
        Me.txt_CariDataAnggota.Size = New System.Drawing.Size(374, 20)
        Me.txt_CariDataAnggota.TabIndex = 0
        '
        'dgv_DataAnggota
        '
        Me.dgv_DataAnggota.AllowUserToAddRows = False
        Me.dgv_DataAnggota.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota.Location = New System.Drawing.Point(12, 61)
        Me.dgv_DataAnggota.Name = "dgv_DataAnggota"
        Me.dgv_DataAnggota.ReadOnly = True
        Me.dgv_DataAnggota.RowHeadersWidth = 51
        Me.dgv_DataAnggota.RowTemplate.Height = 29
        Me.dgv_DataAnggota.Size = New System.Drawing.Size(373, 246)
        Me.dgv_DataAnggota.TabIndex = 1
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.lbl_JumData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData.Location = New System.Drawing.Point(12, 318)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData.TabIndex = 2
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'group_CariDataAnggota
        '
        Me.group_CariDataAnggota.Controls.Add(Me.lbl_JumData)
        Me.group_CariDataAnggota.Controls.Add(Me.dgv_DataAnggota)
        Me.group_CariDataAnggota.Controls.Add(Me.txt_CariDataAnggota)
        Me.group_CariDataAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_CariDataAnggota.Location = New System.Drawing.Point(16, 172)
        Me.group_CariDataAnggota.Name = "group_CariDataAnggota"
        Me.group_CariDataAnggota.Size = New System.Drawing.Size(403, 348)
        Me.group_CariDataAnggota.TabIndex = 15
        Me.group_CariDataAnggota.TabStop = False
        Me.group_CariDataAnggota.Text = "Cari Data Anggota"
        '
        'cmb_JenisSimpanan
        '
        Me.cmb_JenisSimpanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JenisSimpanan.FormattingEnabled = True
        Me.cmb_JenisSimpanan.Location = New System.Drawing.Point(5, 25)
        Me.cmb_JenisSimpanan.Name = "cmb_JenisSimpanan"
        Me.cmb_JenisSimpanan.Size = New System.Drawing.Size(415, 21)
        Me.cmb_JenisSimpanan.TabIndex = 0
        '
        'lbl_Bunga
        '
        Me.lbl_Bunga.AutoSize = True
        Me.lbl_Bunga.Location = New System.Drawing.Point(522, 25)
        Me.lbl_Bunga.Name = "lbl_Bunga"
        Me.lbl_Bunga.Size = New System.Drawing.Size(43, 15)
        Me.lbl_Bunga.TabIndex = 1
        Me.lbl_Bunga.Text = "Bunga"
        '
        'txt_Bunga
        '
        Me.txt_Bunga.Location = New System.Drawing.Point(572, 25)
        Me.txt_Bunga.Name = "txt_Bunga"
        Me.txt_Bunga.Size = New System.Drawing.Size(136, 20)
        Me.txt_Bunga.TabIndex = 2
        '
        'group_JenisSimpanan
        '
        Me.group_JenisSimpanan.Controls.Add(Me.txt_Bunga)
        Me.group_JenisSimpanan.Controls.Add(Me.lbl_Bunga)
        Me.group_JenisSimpanan.Controls.Add(Me.cmb_JenisSimpanan)
        Me.group_JenisSimpanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_JenisSimpanan.Location = New System.Drawing.Point(11, 100)
        Me.group_JenisSimpanan.Name = "group_JenisSimpanan"
        Me.group_JenisSimpanan.Size = New System.Drawing.Size(905, 66)
        Me.group_JenisSimpanan.TabIndex = 14
        Me.group_JenisSimpanan.TabStop = False
        Me.group_JenisSimpanan.Text = "Jenis Simpanan"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.Location = New System.Drawing.Point(11, 19)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(335, 20)
        Me.lbl_Judul.TabIndex = 12
        Me.lbl_Judul.Text = "Form Buat Rekening Simpanan Sukarela"
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.Location = New System.Drawing.Point(26, 42)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(320, 15)
        Me.lbl_Subjudul.TabIndex = 13
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk pembuatan simpanan sukarela"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 78)
        Me.Panel1.TabIndex = 0
        '
        'FormBuatRekSimpSukarela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 590)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.group_CariDataAnggota2)
        Me.Controls.Add(Me.btn_First)
        Me.Controls.Add(Me.btn_Last)
        Me.Controls.Add(Me.group_CariDataAnggota)
        Me.Controls.Add(Me.group_JenisSimpanan)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBuatRekSimpSukarela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgv_DataAnggota2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_CariDataAnggota2.ResumeLayout(False)
        Me.group_CariDataAnggota2.PerformLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_CariDataAnggota.ResumeLayout(False)
        Me.group_CariDataAnggota.PerformLayout()
        Me.group_JenisSimpanan.ResumeLayout(False)
        Me.group_JenisSimpanan.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_BuatRekening As Button
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgv_DataAnggota2 As DataGridView
    Friend WithEvents lbl_JumData2 As Label
    Friend WithEvents txt_CariDataAnggota2 As TextBox
    Friend WithEvents group_CariDataAnggota2 As GroupBox
    Friend WithEvents btn_Last As Button
    Friend WithEvents btn_First As Button
    Friend WithEvents txt_CariDataAnggota As TextBox
    Friend WithEvents dgv_DataAnggota As DataGridView
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents group_CariDataAnggota As GroupBox
    Friend WithEvents cmb_JenisSimpanan As ComboBox
    Friend WithEvents lbl_Bunga As Label
    Friend WithEvents txt_Bunga As TextBox
    Friend WithEvents group_JenisSimpanan As GroupBox
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents Panel1 As Panel
End Class
