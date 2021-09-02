<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLihatTagihan
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
        Me.group_SimpananPokok = New System.Windows.Forms.GroupBox()
        Me.cmb_Pilihan = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_Cari = New System.Windows.Forms.TextBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_Data = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.btn_Cetak = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.group_SimpananPokok.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'group_SimpananPokok
        '
        Me.group_SimpananPokok.Controls.Add(Me.cmb_Pilihan)
        Me.group_SimpananPokok.Location = New System.Drawing.Point(9, 68)
        Me.group_SimpananPokok.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_SimpananPokok.Name = "group_SimpananPokok"
        Me.group_SimpananPokok.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.group_SimpananPokok.Size = New System.Drawing.Size(617, 61)
        Me.group_SimpananPokok.TabIndex = 1
        Me.group_SimpananPokok.TabStop = False
        Me.group_SimpananPokok.Text = "Simpanan Pokok"
        '
        'cmb_Pilihan
        '
        Me.cmb_Pilihan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Pilihan.FormattingEnabled = True
        Me.cmb_Pilihan.Items.AddRange(New Object() {"POKOK", "WAJIB", "SALDO AWAL"})
        Me.cmb_Pilihan.Location = New System.Drawing.Point(18, 26)
        Me.cmb_Pilihan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_Pilihan.Name = "cmb_Pilihan"
        Me.cmb_Pilihan.Size = New System.Drawing.Size(159, 21)
        Me.cmb_Pilihan.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_Cari)
        Me.GroupBox2.Controls.Add(Me.lbl_JumData)
        Me.GroupBox2.Controls.Add(Me.dgv_Data)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 133)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(610, 279)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'txt_Cari
        '
        Me.txt_Cari.Location = New System.Drawing.Point(13, 17)
        Me.txt_Cari.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Cari.Name = "txt_Cari"
        Me.txt_Cari.Size = New System.Drawing.Size(590, 21)
        Me.txt_Cari.TabIndex = 2
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData.Location = New System.Drawing.Point(10, 258)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData.TabIndex = 1
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'dgv_Data
        '
        Me.dgv_Data.AllowUserToAddRows = False
        Me.dgv_Data.AllowUserToDeleteRows = False
        Me.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Data.Location = New System.Drawing.Point(11, 45)
        Me.dgv_Data.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_Data.Name = "dgv_Data"
        Me.dgv_Data.ReadOnly = True
        Me.dgv_Data.RowHeadersWidth = 51
        Me.dgv_Data.RowTemplate.Height = 29
        Me.dgv_Data.Size = New System.Drawing.Size(591, 212)
        Me.dgv_Data.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.AutoSize = True
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btn_Keluar)
        Me.GroupBox3.Controls.Add(Me.btn_Cetak)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 423)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(635, 55)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Location = New System.Drawing.Point(550, 11)
        Me.btn_Keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(70, 27)
        Me.btn_Keluar.TabIndex = 3
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'btn_Cetak
        '
        Me.btn_Cetak.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btn_Cetak.Location = New System.Drawing.Point(9, 10)
        Me.btn_Cetak.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Cetak.Name = "btn_Cetak"
        Me.btn_Cetak.Size = New System.Drawing.Size(131, 27)
        Me.btn_Cetak.TabIndex = 2
        Me.btn_Cetak.Text = "Cetak Tagihan"
        Me.btn_Cetak.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(31, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Form ini digunakan untuk melihat tagihan Simp Pokok, Wajib,  Saldo Awal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Lihat Tagihan Simp Pokok, Wajib, Saldo Awal"
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
        Me.Panel1.Size = New System.Drawing.Size(635, 64)
        Me.Panel1.TabIndex = 0
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_Subjudul.Location = New System.Drawing.Point(34, 31)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(410, 15)
        Me.lbl_Subjudul.TabIndex = 11
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk melihat tagihan Simp Pokok, Wajib,  Saldo Awal"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.ForeColor = System.Drawing.Color.White
        Me.lbl_Judul.Location = New System.Drawing.Point(19, 11)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(370, 20)
        Me.lbl_Judul.TabIndex = 10
        Me.lbl_Judul.Text = "Lihat Tagihan Simp Pokok, Wajib, Saldo Awal"
        '
        'FormLihatTagihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 478)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.group_SimpananPokok)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLihatTagihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.group_SimpananPokok.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents group_SimpananPokok As GroupBox
    Friend WithEvents cmb_Pilihan As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_Data As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents btn_Cetak As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents txt_Cari As TextBox
End Class
