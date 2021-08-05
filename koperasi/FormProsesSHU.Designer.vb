<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProsesSHU
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
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grup_Menu = New System.Windows.Forms.GroupBox()
        Me.btn_Cetak = New System.Windows.Forms.Button()
        Me.btn_Proses = New System.Windows.Forms.Button()
        Me.txt_Tahun = New System.Windows.Forms.TextBox()
        Me.lbl_Tahun = New System.Windows.Forms.Label()
        Me.txt_SHU = New System.Windows.Forms.TextBox()
        Me.lbl_SHU = New System.Windows.Forms.Label()
        Me.group_DataSimpanan = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_DataSimpanan = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.grup_Menu.SuspendLayout()
        Me.group_DataSimpanan.SuspendLayout()
        CType(Me.dgv_DataSimpanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.Location = New System.Drawing.Point(35, 34)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(387, 15)
        Me.lbl_Subjudul.TabIndex = 19
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk proses perhitungan Sisa Hasil Usaha [SHU]"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.Location = New System.Drawing.Point(19, 14)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(259, 20)
        Me.lbl_Judul.TabIndex = 18
        Me.lbl_Judul.Text = "Proses SHU [Sisa Hasil Usaha]"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.lbl_Subjudul)
        Me.Panel2.Controls.Add(Me.lbl_Judul)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1013, 67)
        Me.Panel2.TabIndex = 7
        '
        'grup_Menu
        '
        Me.grup_Menu.Controls.Add(Me.btn_Cetak)
        Me.grup_Menu.Controls.Add(Me.btn_Proses)
        Me.grup_Menu.Controls.Add(Me.txt_Tahun)
        Me.grup_Menu.Controls.Add(Me.lbl_Tahun)
        Me.grup_Menu.Controls.Add(Me.txt_SHU)
        Me.grup_Menu.Controls.Add(Me.lbl_SHU)
        Me.grup_Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.grup_Menu.Location = New System.Drawing.Point(11, 71)
        Me.grup_Menu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grup_Menu.Name = "grup_Menu"
        Me.grup_Menu.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grup_Menu.Size = New System.Drawing.Size(991, 43)
        Me.grup_Menu.TabIndex = 8
        Me.grup_Menu.TabStop = False
        '
        'btn_Cetak
        '
        Me.btn_Cetak.Location = New System.Drawing.Point(636, 14)
        Me.btn_Cetak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Cetak.Name = "btn_Cetak"
        Me.btn_Cetak.Size = New System.Drawing.Size(82, 22)
        Me.btn_Cetak.TabIndex = 10
        Me.btn_Cetak.Text = "Cetak"
        Me.btn_Cetak.UseVisualStyleBackColor = True
        '
        'btn_Proses
        '
        Me.btn_Proses.Location = New System.Drawing.Point(537, 14)
        Me.btn_Proses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Proses.Name = "btn_Proses"
        Me.btn_Proses.Size = New System.Drawing.Size(82, 22)
        Me.btn_Proses.TabIndex = 9
        Me.btn_Proses.Text = "Proses"
        Me.btn_Proses.UseVisualStyleBackColor = True
        '
        'txt_Tahun
        '
        Me.txt_Tahun.Location = New System.Drawing.Point(371, 15)
        Me.txt_Tahun.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Tahun.Name = "txt_Tahun"
        Me.txt_Tahun.ReadOnly = True
        Me.txt_Tahun.Size = New System.Drawing.Size(149, 20)
        Me.txt_Tahun.TabIndex = 11
        '
        'lbl_Tahun
        '
        Me.lbl_Tahun.AutoSize = True
        Me.lbl_Tahun.Location = New System.Drawing.Point(325, 17)
        Me.lbl_Tahun.Name = "lbl_Tahun"
        Me.lbl_Tahun.Size = New System.Drawing.Size(42, 15)
        Me.lbl_Tahun.TabIndex = 10
        Me.lbl_Tahun.Text = "Tahun"
        '
        'txt_SHU
        '
        Me.txt_SHU.Location = New System.Drawing.Point(46, 15)
        Me.txt_SHU.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_SHU.Name = "txt_SHU"
        Me.txt_SHU.Size = New System.Drawing.Size(224, 20)
        Me.txt_SHU.TabIndex = 10
        '
        'lbl_SHU
        '
        Me.lbl_SHU.AutoSize = True
        Me.lbl_SHU.Location = New System.Drawing.Point(8, 17)
        Me.lbl_SHU.Name = "lbl_SHU"
        Me.lbl_SHU.Size = New System.Drawing.Size(33, 15)
        Me.lbl_SHU.TabIndex = 9
        Me.lbl_SHU.Text = "SHU"
        '
        'group_DataSimpanan
        '
        Me.group_DataSimpanan.Controls.Add(Me.lbl_JumData)
        Me.group_DataSimpanan.Controls.Add(Me.dgv_DataSimpanan)
        Me.group_DataSimpanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_DataSimpanan.Location = New System.Drawing.Point(12, 118)
        Me.group_DataSimpanan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataSimpanan.Name = "group_DataSimpanan"
        Me.group_DataSimpanan.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_DataSimpanan.Size = New System.Drawing.Size(991, 361)
        Me.group_DataSimpanan.TabIndex = 9
        Me.group_DataSimpanan.TabStop = False
        Me.group_DataSimpanan.Text = "Data Simpanan"
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.Location = New System.Drawing.Point(8, 338)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData.TabIndex = 1
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'dgv_DataSimpanan
        '
        Me.dgv_DataSimpanan.AllowUserToAddRows = False
        Me.dgv_DataSimpanan.AllowUserToDeleteRows = False
        Me.dgv_DataSimpanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataSimpanan.Location = New System.Drawing.Point(6, 20)
        Me.dgv_DataSimpanan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_DataSimpanan.Name = "dgv_DataSimpanan"
        Me.dgv_DataSimpanan.ReadOnly = True
        Me.dgv_DataSimpanan.RowHeadersWidth = 51
        Me.dgv_DataSimpanan.RowTemplate.Height = 29
        Me.dgv_DataSimpanan.Size = New System.Drawing.Size(980, 310)
        Me.dgv_DataSimpanan.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Location = New System.Drawing.Point(0, 496)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1013, 22)
        Me.Panel1.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_Keluar)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 528)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(1013, 38)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Location = New System.Drawing.Point(921, 12)
        Me.btn_Keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(82, 22)
        Me.btn_Keluar.TabIndex = 12
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'FormProsesSHU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 566)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.group_DataSimpanan)
        Me.Controls.Add(Me.grup_Menu)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormProsesSHU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.grup_Menu.ResumeLayout(False)
        Me.grup_Menu.PerformLayout()
        Me.group_DataSimpanan.ResumeLayout(False)
        Me.group_DataSimpanan.PerformLayout()
        CType(Me.dgv_DataSimpanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grup_Menu As GroupBox
    Friend WithEvents btn_Cetak As Button
    Friend WithEvents btn_Proses As Button
    Friend WithEvents txt_Tahun As TextBox
    Friend WithEvents lbl_Tahun As Label
    Friend WithEvents txt_SHU As TextBox
    Friend WithEvents lbl_SHU As Label
    Friend WithEvents group_DataSimpanan As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_DataSimpanan As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_Keluar As Button
End Class
