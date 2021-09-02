<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaranSimpKolektif
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.group_DataAnggota = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_DataAnggota = New System.Windows.Forms.DataGridView()
        Me.txt_CariDataAnggota = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_PembayaranKolektif = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.group_DataAnggota.SuspendLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 73)
        Me.Panel1.TabIndex = 0
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_Subjudul.Location = New System.Drawing.Point(28, 37)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(459, 15)
        Me.lbl_Subjudul.TabIndex = 11
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk pembayaran simpan pokok wajib anggota secara kolektif"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.ForeColor = System.Drawing.Color.White
        Me.lbl_Judul.Location = New System.Drawing.Point(14, 17)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(258, 20)
        Me.lbl_Judul.TabIndex = 10
        Me.lbl_Judul.Text = "Pembayaran Simpanan Kolektif"
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Location = New System.Drawing.Point(858, 15)
        Me.btn_Keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(82, 22)
        Me.btn_Keluar.TabIndex = 2
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'group_DataAnggota
        '
        Me.group_DataAnggota.Controls.Add(Me.lbl_JumData)
        Me.group_DataAnggota.Controls.Add(Me.dgv_DataAnggota)
        Me.group_DataAnggota.Controls.Add(Me.txt_CariDataAnggota)
        Me.group_DataAnggota.ForeColor = System.Drawing.Color.Black
        Me.group_DataAnggota.Location = New System.Drawing.Point(18, 77)
        Me.group_DataAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataAnggota.Name = "group_DataAnggota"
        Me.group_DataAnggota.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataAnggota.Size = New System.Drawing.Size(922, 362)
        Me.group_DataAnggota.TabIndex = 3
        Me.group_DataAnggota.TabStop = False
        Me.group_DataAnggota.Text = "Cari Data Anggota"
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData.Location = New System.Drawing.Point(6, 332)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData.TabIndex = 2
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'dgv_DataAnggota
        '
        Me.dgv_DataAnggota.AllowUserToAddRows = False
        Me.dgv_DataAnggota.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota.Location = New System.Drawing.Point(13, 47)
        Me.dgv_DataAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_DataAnggota.Name = "dgv_DataAnggota"
        Me.dgv_DataAnggota.ReadOnly = True
        Me.dgv_DataAnggota.RowHeadersWidth = 51
        Me.dgv_DataAnggota.RowTemplate.Height = 29
        Me.dgv_DataAnggota.Size = New System.Drawing.Size(893, 279)
        Me.dgv_DataAnggota.TabIndex = 1
        '
        'txt_CariDataAnggota
        '
        Me.txt_CariDataAnggota.Location = New System.Drawing.Point(13, 20)
        Me.txt_CariDataAnggota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_CariDataAnggota.Name = "txt_CariDataAnggota"
        Me.txt_CariDataAnggota.Size = New System.Drawing.Size(893, 21)
        Me.txt_CariDataAnggota.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btn_PembayaranKolektif)
        Me.GroupBox2.Controls.Add(Me.btn_Keluar)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 443)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(948, 46)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'btn_PembayaranKolektif
        '
        Me.btn_PembayaranKolektif.Location = New System.Drawing.Point(10, 15)
        Me.btn_PembayaranKolektif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_PembayaranKolektif.Name = "btn_PembayaranKolektif"
        Me.btn_PembayaranKolektif.Size = New System.Drawing.Size(161, 22)
        Me.btn_PembayaranKolektif.TabIndex = 3
        Me.btn_PembayaranKolektif.Text = "Pembayaran Kolektif"
        Me.btn_PembayaranKolektif.UseVisualStyleBackColor = True
        '
        'FormPembayaranSimpKolektif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 489)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.group_DataAnggota)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPembayaranSimpKolektif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_DataAnggota.ResumeLayout(False)
        Me.group_DataAnggota.PerformLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents group_DataAnggota As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_DataAnggota As DataGridView
    Friend WithEvents txt_CariDataAnggota As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_PembayaranKolektif As Button
End Class
