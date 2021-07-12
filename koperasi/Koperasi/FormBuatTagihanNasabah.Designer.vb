<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuatTagihanNasabah
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
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_subjudul = New System.Windows.Forms.Label()
        Me.lbl_judul = New System.Windows.Forms.Label()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.btn_lihat_tagihan = New System.Windows.Forms.Button()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.group_data_peminjaman = New System.Windows.Forms.GroupBox()
        Me.lbl_Jumlah = New System.Windows.Forms.Label()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.lbl_jumlah_data = New System.Windows.Forms.Label()
        Me.dgv_data_peminjaman = New System.Windows.Forms.DataGridView()
        Me.group_data_peminjaman2 = New System.Windows.Forms.GroupBox()
        Me.lbl_Jumlah2 = New System.Windows.Forms.Label()
        Me.txt_search2 = New System.Windows.Forms.TextBox()
        Me.lvl_jumlah_data2 = New System.Windows.Forms.Label()
        Me.dgv_data_peminjaman2 = New System.Windows.Forms.DataGridView()
        Me.grupOperation = New System.Windows.Forms.GroupBox()
        Me.btn_first = New System.Windows.Forms.Button()
        Me.btn_last = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.grupBtn.SuspendLayout()
        Me.group_data_peminjaman.SuspendLayout()
        CType(Me.dgv_data_peminjaman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_data_peminjaman2.SuspendLayout()
        CType(Me.dgv_data_peminjaman2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupOperation.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(611, 10)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 0
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.lbl_subjudul)
        Me.Panel1.Controls.Add(Me.lbl_judul)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 60)
        Me.Panel1.TabIndex = 61
        '
        'lbl_subjudul
        '
        Me.lbl_subjudul.AutoSize = True
        Me.lbl_subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subjudul.Location = New System.Drawing.Point(25, 33)
        Me.lbl_subjudul.Name = "lbl_subjudul"
        Me.lbl_subjudul.Size = New System.Drawing.Size(310, 15)
        Me.lbl_subjudul.TabIndex = 2
        Me.lbl_subjudul.Text = "Form ini digunakan untuk memproses tagihan nasabah"
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_judul.Location = New System.Drawing.Point(13, 13)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(238, 20)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Form Buat Tagihan Nasabah"
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(307, 12)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(75, 23)
        Me.btn_proses.TabIndex = 3
        Me.btn_proses.Text = "Proses Tagihan"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'btn_lihat_tagihan
        '
        Me.btn_lihat_tagihan.Location = New System.Drawing.Point(6, 10)
        Me.btn_lihat_tagihan.Name = "btn_lihat_tagihan"
        Me.btn_lihat_tagihan.Size = New System.Drawing.Size(93, 23)
        Me.btn_lihat_tagihan.TabIndex = 1
        Me.btn_lihat_tagihan.Text = "Lihat Tagihan"
        Me.btn_lihat_tagihan.UseVisualStyleBackColor = True
        '
        'grupBtn
        '
        Me.grupBtn.Controls.Add(Me.btn_proses)
        Me.grupBtn.Controls.Add(Me.btn_lihat_tagihan)
        Me.grupBtn.Controls.Add(Me.btn_keluar)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupBtn.Location = New System.Drawing.Point(0, 425)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Size = New System.Drawing.Size(692, 46)
        Me.grupBtn.TabIndex = 63
        Me.grupBtn.TabStop = False
        '
        'group_data_peminjaman
        '
        Me.group_data_peminjaman.Controls.Add(Me.lbl_Jumlah)
        Me.group_data_peminjaman.Controls.Add(Me.txt_search)
        Me.group_data_peminjaman.Controls.Add(Me.lbl_jumlah_data)
        Me.group_data_peminjaman.Controls.Add(Me.dgv_data_peminjaman)
        Me.group_data_peminjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_data_peminjaman.Location = New System.Drawing.Point(6, 66)
        Me.group_data_peminjaman.Name = "group_data_peminjaman"
        Me.group_data_peminjaman.Size = New System.Drawing.Size(304, 358)
        Me.group_data_peminjaman.TabIndex = 62
        Me.group_data_peminjaman.TabStop = False
        Me.group_data_peminjaman.Text = "Data Peminjaman"
        '
        'lbl_Jumlah
        '
        Me.lbl_Jumlah.AutoSize = True
        Me.lbl_Jumlah.ForeColor = System.Drawing.Color.Red
        Me.lbl_Jumlah.Location = New System.Drawing.Point(6, 334)
        Me.lbl_Jumlah.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Jumlah.Name = "lbl_Jumlah"
        Me.lbl_Jumlah.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Jumlah.TabIndex = 4
        Me.lbl_Jumlah.Text = "Jumlah Data "
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(6, 19)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(292, 20)
        Me.txt_search.TabIndex = 3
        '
        'lbl_jumlah_data
        '
        Me.lbl_jumlah_data.AutoSize = True
        Me.lbl_jumlah_data.Location = New System.Drawing.Point(6, 376)
        Me.lbl_jumlah_data.Name = "lbl_jumlah_data"
        Me.lbl_jumlah_data.Size = New System.Drawing.Size(93, 15)
        Me.lbl_jumlah_data.TabIndex = 2
        Me.lbl_jumlah_data.Text = "Jumlah Data : 5"
        '
        'dgv_data_peminjaman
        '
        Me.dgv_data_peminjaman.AllowUserToAddRows = False
        Me.dgv_data_peminjaman.AllowUserToDeleteRows = False
        Me.dgv_data_peminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_peminjaman.Location = New System.Drawing.Point(6, 46)
        Me.dgv_data_peminjaman.Name = "dgv_data_peminjaman"
        Me.dgv_data_peminjaman.ReadOnly = True
        Me.dgv_data_peminjaman.RowHeadersWidth = 51
        Me.dgv_data_peminjaman.Size = New System.Drawing.Size(292, 281)
        Me.dgv_data_peminjaman.TabIndex = 1
        '
        'group_data_peminjaman2
        '
        Me.group_data_peminjaman2.Controls.Add(Me.lbl_Jumlah2)
        Me.group_data_peminjaman2.Controls.Add(Me.txt_search2)
        Me.group_data_peminjaman2.Controls.Add(Me.lvl_jumlah_data2)
        Me.group_data_peminjaman2.Controls.Add(Me.dgv_data_peminjaman2)
        Me.group_data_peminjaman2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_data_peminjaman2.Location = New System.Drawing.Point(377, 66)
        Me.group_data_peminjaman2.Name = "group_data_peminjaman2"
        Me.group_data_peminjaman2.Size = New System.Drawing.Size(304, 358)
        Me.group_data_peminjaman2.TabIndex = 63
        Me.group_data_peminjaman2.TabStop = False
        Me.group_data_peminjaman2.Text = "Data Peminjaman"
        '
        'lbl_Jumlah2
        '
        Me.lbl_Jumlah2.AutoSize = True
        Me.lbl_Jumlah2.ForeColor = System.Drawing.Color.Red
        Me.lbl_Jumlah2.Location = New System.Drawing.Point(6, 334)
        Me.lbl_Jumlah2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Jumlah2.Name = "lbl_Jumlah2"
        Me.lbl_Jumlah2.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Jumlah2.TabIndex = 5
        Me.lbl_Jumlah2.Text = "Jumlah Data "
        '
        'txt_search2
        '
        Me.txt_search2.Location = New System.Drawing.Point(6, 19)
        Me.txt_search2.Name = "txt_search2"
        Me.txt_search2.Size = New System.Drawing.Size(292, 20)
        Me.txt_search2.TabIndex = 3
        '
        'lvl_jumlah_data2
        '
        Me.lvl_jumlah_data2.AutoSize = True
        Me.lvl_jumlah_data2.Location = New System.Drawing.Point(6, 376)
        Me.lvl_jumlah_data2.Name = "lvl_jumlah_data2"
        Me.lvl_jumlah_data2.Size = New System.Drawing.Size(93, 15)
        Me.lvl_jumlah_data2.TabIndex = 2
        Me.lvl_jumlah_data2.Text = "Jumlah Data : 0"
        '
        'dgv_data_peminjaman2
        '
        Me.dgv_data_peminjaman2.AllowUserToAddRows = False
        Me.dgv_data_peminjaman2.AllowUserToDeleteRows = False
        Me.dgv_data_peminjaman2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_peminjaman2.Location = New System.Drawing.Point(6, 46)
        Me.dgv_data_peminjaman2.Name = "dgv_data_peminjaman2"
        Me.dgv_data_peminjaman2.ReadOnly = True
        Me.dgv_data_peminjaman2.RowHeadersWidth = 51
        Me.dgv_data_peminjaman2.Size = New System.Drawing.Size(292, 281)
        Me.dgv_data_peminjaman2.TabIndex = 1
        '
        'grupOperation
        '
        Me.grupOperation.Controls.Add(Me.btn_first)
        Me.grupOperation.Controls.Add(Me.btn_last)
        Me.grupOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupOperation.Location = New System.Drawing.Point(316, 67)
        Me.grupOperation.Name = "grupOperation"
        Me.grupOperation.Size = New System.Drawing.Size(55, 358)
        Me.grupOperation.TabIndex = 64
        Me.grupOperation.TabStop = False
        '
        'btn_first
        '
        Me.btn_first.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.Location = New System.Drawing.Point(6, 186)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(43, 23)
        Me.btn_first.TabIndex = 3
        Me.btn_first.Text = "<<"
        Me.btn_first.UseVisualStyleBackColor = True
        '
        'btn_last
        '
        Me.btn_last.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.Location = New System.Drawing.Point(6, 145)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(43, 23)
        Me.btn_last.TabIndex = 1
        Me.btn_last.Text = ">>"
        Me.btn_last.UseVisualStyleBackColor = True
        '
        'FormBuatTagihanNasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 471)
        Me.Controls.Add(Me.grupOperation)
        Me.Controls.Add(Me.group_data_peminjaman2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.group_data_peminjaman)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBuatTagihanNasabah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grupBtn.ResumeLayout(False)
        Me.group_data_peminjaman.ResumeLayout(False)
        Me.group_data_peminjaman.PerformLayout()
        CType(Me.dgv_data_peminjaman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_data_peminjaman2.ResumeLayout(False)
        Me.group_data_peminjaman2.PerformLayout()
        CType(Me.dgv_data_peminjaman2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupOperation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_keluar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_subjudul As Label
    Friend WithEvents lbl_judul As Label
    Friend WithEvents btn_proses As Button
    Friend WithEvents btn_lihat_tagihan As Button
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents group_data_peminjaman As GroupBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents lbl_jumlah_data As Label
    Friend WithEvents dgv_data_peminjaman As DataGridView
    Friend WithEvents group_data_peminjaman2 As GroupBox
    Friend WithEvents txt_search2 As TextBox
    Friend WithEvents lvl_jumlah_data2 As Label
    Friend WithEvents dgv_data_peminjaman2 As DataGridView
    Friend WithEvents grupOperation As GroupBox
    Friend WithEvents btn_first As Button
    Friend WithEvents btn_last As Button
    Friend WithEvents lbl_Jumlah As Label
    Friend WithEvents lbl_Jumlah2 As Label
End Class
