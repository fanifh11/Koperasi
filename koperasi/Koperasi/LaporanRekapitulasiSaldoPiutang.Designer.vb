<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanRekapitulasiSaldoPiutang
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
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.group_DataPembayaran = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_DataPembayaran = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Cetak = New System.Windows.Forms.Button()
        Me.btn_Proses = New System.Windows.Forms.Button()
        Me.dtp_TglRekap = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Sampai = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_Detail = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.RibbonLabel1 = New System.Windows.Forms.RibbonLabel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        Me.group_DataPembayaran.SuspendLayout()
        CType(Me.dgv_DataPembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Text = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 68)
        Me.Panel1.TabIndex = 0
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_Subjudul.Location = New System.Drawing.Point(38, 34)
        Me.lbl_Subjudul.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(337, 15)
        Me.lbl_Subjudul.TabIndex = 1
        Me.lbl_Subjudul.Text = "Form ini  digunakan untuk laporan rekapitulasi saldo piutang"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Judul.ForeColor = System.Drawing.Color.White
        Me.lbl_Judul.Location = New System.Drawing.Point(19, 11)
        Me.lbl_Judul.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(296, 20)
        Me.lbl_Judul.TabIndex = 0
        Me.lbl_Judul.Text = "Laporan Rekapitulasi Saldo Piutang"
        '
        'group_DataPembayaran
        '
        Me.group_DataPembayaran.Controls.Add(Me.lbl_JumData)
        Me.group_DataPembayaran.Controls.Add(Me.dgv_DataPembayaran)
        Me.group_DataPembayaran.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_DataPembayaran.Location = New System.Drawing.Point(10, 131)
        Me.group_DataPembayaran.Margin = New System.Windows.Forms.Padding(2)
        Me.group_DataPembayaran.Name = "group_DataPembayaran"
        Me.group_DataPembayaran.Padding = New System.Windows.Forms.Padding(2)
        Me.group_DataPembayaran.Size = New System.Drawing.Size(677, 367)
        Me.group_DataPembayaran.TabIndex = 1
        Me.group_DataPembayaran.TabStop = False
        Me.group_DataPembayaran.Text = "Data Pembayaran"
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.Location = New System.Drawing.Point(13, 337)
        Me.lbl_JumData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData.TabIndex = 1
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'dgv_DataPembayaran
        '
        Me.dgv_DataPembayaran.AllowUserToAddRows = False
        Me.dgv_DataPembayaran.AllowUserToDeleteRows = False
        Me.dgv_DataPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataPembayaran.Location = New System.Drawing.Point(13, 26)
        Me.dgv_DataPembayaran.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_DataPembayaran.Name = "dgv_DataPembayaran"
        Me.dgv_DataPembayaran.ReadOnly = True
        Me.dgv_DataPembayaran.RowHeadersWidth = 51
        Me.dgv_DataPembayaran.RowTemplate.Height = 24
        Me.dgv_DataPembayaran.Size = New System.Drawing.Size(652, 300)
        Me.dgv_DataPembayaran.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_Cetak)
        Me.GroupBox2.Controls.Add(Me.btn_Proses)
        Me.GroupBox2.Controls.Add(Me.dtp_TglRekap)
        Me.GroupBox2.Controls.Add(Me.lbl_Sampai)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 74)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(677, 52)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btn_Cetak
        '
        Me.btn_Cetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cetak.Location = New System.Drawing.Point(589, 15)
        Me.btn_Cetak.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Cetak.Name = "btn_Cetak"
        Me.btn_Cetak.Size = New System.Drawing.Size(76, 25)
        Me.btn_Cetak.TabIndex = 3
        Me.btn_Cetak.Text = "Cetak"
        Me.btn_Cetak.UseVisualStyleBackColor = True
        '
        'btn_Proses
        '
        Me.btn_Proses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Proses.Location = New System.Drawing.Point(508, 15)
        Me.btn_Proses.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Proses.Name = "btn_Proses"
        Me.btn_Proses.Size = New System.Drawing.Size(76, 25)
        Me.btn_Proses.TabIndex = 2
        Me.btn_Proses.Text = "Proses"
        Me.btn_Proses.UseVisualStyleBackColor = True
        '
        'dtp_TglRekap
        '
        Me.dtp_TglRekap.Location = New System.Drawing.Point(68, 18)
        Me.dtp_TglRekap.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_TglRekap.Name = "dtp_TglRekap"
        Me.dtp_TglRekap.Size = New System.Drawing.Size(186, 20)
        Me.dtp_TglRekap.TabIndex = 1
        '
        'lbl_Sampai
        '
        Me.lbl_Sampai.AutoSize = True
        Me.lbl_Sampai.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Sampai.Location = New System.Drawing.Point(13, 18)
        Me.lbl_Sampai.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Sampai.Name = "lbl_Sampai"
        Me.lbl_Sampai.Size = New System.Drawing.Size(50, 15)
        Me.lbl_Sampai.TabIndex = 0
        Me.lbl_Sampai.Text = "Sampai"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lbl_Detail)
        Me.Panel3.Location = New System.Drawing.Point(0, 502)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(697, 45)
        Me.Panel3.TabIndex = 5
        '
        'lbl_Detail
        '
        Me.lbl_Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Detail.ForeColor = System.Drawing.Color.Red
        Me.lbl_Detail.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Detail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Detail.Name = "lbl_Detail"
        Me.lbl_Detail.Size = New System.Drawing.Size(693, 41)
        Me.lbl_Detail.TabIndex = 0
        Me.lbl_Detail.Text = "Pinjam : 0 Bayar : 0 Sisa : 0"
        Me.lbl_Detail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.btn_Keluar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 553)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(696, 43)
        Me.Panel4.TabIndex = 6
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Keluar.Location = New System.Drawing.Point(606, 6)
        Me.btn_Keluar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(82, 29)
        Me.btn_Keluar.TabIndex = 0
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'RibbonLabel1
        '
        Me.RibbonLabel1.Name = "RibbonLabel1"
        '
        'LaporanRekapitulasiSaldoPiutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 596)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.group_DataPembayaran)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LaporanRekapitulasiSaldoPiutang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_DataPembayaran.ResumeLayout(False)
        Me.group_DataPembayaran.PerformLayout()
        CType(Me.dgv_DataPembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents group_DataPembayaran As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_DataPembayaran As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_Cetak As Button
    Friend WithEvents btn_Proses As Button
    Friend WithEvents dtp_TglRekap As DateTimePicker
    Friend WithEvents lbl_Sampai As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_Detail As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RibbonLabel1 As RibbonLabel
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
