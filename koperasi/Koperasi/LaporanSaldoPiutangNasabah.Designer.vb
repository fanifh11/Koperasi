<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanSaldoPiutangNasabah
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_subjudul = New System.Windows.Forms.Label()
        Me.lbl_judul = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.dgv_data_saldo_piutang = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.group_data_saldo_piutang = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_saldo_pinjam = New System.Windows.Forms.Label()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_data_saldo_piutang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_data_saldo_piutang.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_jumlah_data
        '
        Me.lbl_jumlah_data.AutoSize = True
        Me.lbl_jumlah_data.Location = New System.Drawing.Point(4, 224)
        Me.lbl_jumlah_data.Name = "lbl_jumlah_data"
        Me.lbl_jumlah_data.Size = New System.Drawing.Size(81, 13)
        Me.lbl_jumlah_data.TabIndex = 2
        Me.lbl_jumlah_data.Text = "Jumlah Data : 5"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_subjudul)
        Me.Panel1.Controls.Add(Me.lbl_judul)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(471, 60)
        Me.Panel1.TabIndex = 31
        '
        'lbl_subjudul
        '
        Me.lbl_subjudul.AutoSize = True
        Me.lbl_subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_subjudul.Location = New System.Drawing.Point(25, 33)
        Me.lbl_subjudul.Name = "lbl_subjudul"
        Me.lbl_subjudul.Size = New System.Drawing.Size(268, 13)
        Me.lbl_subjudul.TabIndex = 2
        Me.lbl_subjudul.Text = "Form ini diguakan untuk laporan saldo piutang nasabah"
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_judul.ForeColor = System.Drawing.Color.White
        Me.lbl_judul.Location = New System.Drawing.Point(13, 13)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(268, 20)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Laporan Saldo Piutang Nasabah"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cetak)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 40)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'btn_cetak
        '
        Me.btn_cetak.Location = New System.Drawing.Point(6, 11)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(75, 23)
        Me.btn_cetak.TabIndex = 3
        Me.btn_cetak.Text = "Cetak"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'dgv_data_saldo_piutang
        '
        Me.dgv_data_saldo_piutang.AllowUserToAddRows = False
        Me.dgv_data_saldo_piutang.AllowUserToDeleteRows = False
        Me.dgv_data_saldo_piutang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_saldo_piutang.Location = New System.Drawing.Point(7, 48)
        Me.dgv_data_saldo_piutang.Name = "dgv_data_saldo_piutang"
        Me.dgv_data_saldo_piutang.ReadOnly = True
        Me.dgv_data_saldo_piutang.RowHeadersWidth = 51
        Me.dgv_data_saldo_piutang.Size = New System.Drawing.Size(442, 173)
        Me.dgv_data_saldo_piutang.TabIndex = 1
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(7, 20)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(442, 20)
        Me.txt_search.TabIndex = 0
        '
        'group_data_saldo_piutang
        '
        Me.group_data_saldo_piutang.Controls.Add(Me.lbl_jumlah_data)
        Me.group_data_saldo_piutang.Controls.Add(Me.dgv_data_saldo_piutang)
        Me.group_data_saldo_piutang.Controls.Add(Me.txt_search)
        Me.group_data_saldo_piutang.Location = New System.Drawing.Point(6, 119)
        Me.group_data_saldo_piutang.Name = "group_data_saldo_piutang"
        Me.group_data_saldo_piutang.Size = New System.Drawing.Size(455, 246)
        Me.group_data_saldo_piutang.TabIndex = 33
        Me.group_data_saldo_piutang.TabStop = False
        Me.group_data_saldo_piutang.Text = "Data Saldo Piutang"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_saldo_pinjam)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 371)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(471, 44)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        '
        'lbl_saldo_pinjam
        '
        Me.lbl_saldo_pinjam.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_saldo_pinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_saldo_pinjam.ForeColor = System.Drawing.Color.Red
        Me.lbl_saldo_pinjam.Location = New System.Drawing.Point(3, 16)
        Me.lbl_saldo_pinjam.Name = "lbl_saldo_pinjam"
        Me.lbl_saldo_pinjam.Size = New System.Drawing.Size(465, 19)
        Me.lbl_saldo_pinjam.TabIndex = 0
        Me.lbl_saldo_pinjam.Text = "Saldo Pinjam : 0"
        Me.lbl_saldo_pinjam.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(390, 12)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 0
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.btn_keluar)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 421)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(471, 43)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        '
        'LaporanSaldoPiutangNasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 463)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.group_data_saldo_piutang)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LaporanSaldoPiutangNasabah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_data_saldo_piutang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_data_saldo_piutang.ResumeLayout(False)
        Me.group_data_saldo_piutang.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_jumlah_data As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_subjudul As Label
    Friend WithEvents lbl_judul As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_cetak As Button
    Friend WithEvents dgv_data_saldo_piutang As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents group_data_saldo_piutang As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_keluar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lbl_saldo_pinjam As Label
End Class
