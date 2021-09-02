<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPerhitungaBungaSimpSukarela
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_TglHitung = New System.Windows.Forms.DateTimePicker()
        Me.lbl_TglHitung = New System.Windows.Forms.Label()
        Me.group_PilihData = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_PilihData = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.btn_Hitung = New System.Windows.Forms.Button()
        Me.group_DataTerpilih = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData2 = New System.Windows.Forms.Label()
        Me.dgv_DataTerpilih = New System.Windows.Forms.DataGridView()
        Me.btn_PindahSemua = New System.Windows.Forms.Button()
        Me.btn_KembalikaSemua = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.group_PilihData.SuspendLayout()
        CType(Me.dgv_PilihData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.group_DataTerpilih.SuspendLayout()
        CType(Me.dgv_DataTerpilih, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(895, 75)
        Me.Panel1.TabIndex = 0
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_Subjudul.Location = New System.Drawing.Point(29, 40)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(361, 15)
        Me.lbl_Subjudul.TabIndex = 13
        Me.lbl_Subjudul.Text = "Form ini digunakan untuk perhitungan bunga simpanan sukarela"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.ForeColor = System.Drawing.Color.White
        Me.lbl_Judul.Location = New System.Drawing.Point(12, 20)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(284, 20)
        Me.lbl_Judul.TabIndex = 12
        Me.lbl_Judul.Text = "Perhitungan Bunga Simp Sukarela"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_TglHitung)
        Me.GroupBox1.Controls.Add(Me.lbl_TglHitung)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 81)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'dtp_TglHitung
        '
        Me.dtp_TglHitung.Location = New System.Drawing.Point(132, 30)
        Me.dtp_TglHitung.Name = "dtp_TglHitung"
        Me.dtp_TglHitung.Size = New System.Drawing.Size(279, 21)
        Me.dtp_TglHitung.TabIndex = 1
        '
        'lbl_TglHitung
        '
        Me.lbl_TglHitung.AutoSize = True
        Me.lbl_TglHitung.Location = New System.Drawing.Point(16, 30)
        Me.lbl_TglHitung.Name = "lbl_TglHitung"
        Me.lbl_TglHitung.Size = New System.Drawing.Size(91, 15)
        Me.lbl_TglHitung.TabIndex = 0
        Me.lbl_TglHitung.Text = "Tanggal Hitung"
        '
        'group_PilihData
        '
        Me.group_PilihData.Controls.Add(Me.lbl_JumData)
        Me.group_PilihData.Controls.Add(Me.dgv_PilihData)
        Me.group_PilihData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_PilihData.Location = New System.Drawing.Point(12, 168)
        Me.group_PilihData.Name = "group_PilihData"
        Me.group_PilihData.Size = New System.Drawing.Size(393, 357)
        Me.group_PilihData.TabIndex = 2
        Me.group_PilihData.TabStop = False
        Me.group_PilihData.Text = "Pilih Data"
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.Location = New System.Drawing.Point(17, 330)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData.TabIndex = 1
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'dgv_PilihData
        '
        Me.dgv_PilihData.AllowUserToAddRows = False
        Me.dgv_PilihData.AllowUserToDeleteRows = False
        Me.dgv_PilihData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_PilihData.Location = New System.Drawing.Point(17, 23)
        Me.dgv_PilihData.Name = "dgv_PilihData"
        Me.dgv_PilihData.ReadOnly = True
        Me.dgv_PilihData.RowHeadersWidth = 51
        Me.dgv_PilihData.RowTemplate.Height = 29
        Me.dgv_PilihData.Size = New System.Drawing.Size(360, 304)
        Me.dgv_PilihData.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.btn_Keluar)
        Me.GroupBox3.Controls.Add(Me.btn_Hitung)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 531)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(895, 56)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Location = New System.Drawing.Point(789, 15)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(94, 29)
        Me.btn_Keluar.TabIndex = 1
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'btn_Hitung
        '
        Me.btn_Hitung.Location = New System.Drawing.Point(16, 15)
        Me.btn_Hitung.Name = "btn_Hitung"
        Me.btn_Hitung.Size = New System.Drawing.Size(94, 29)
        Me.btn_Hitung.TabIndex = 0
        Me.btn_Hitung.Text = "Hitung"
        Me.btn_Hitung.UseVisualStyleBackColor = True
        '
        'group_DataTerpilih
        '
        Me.group_DataTerpilih.Controls.Add(Me.lbl_JumData2)
        Me.group_DataTerpilih.Controls.Add(Me.dgv_DataTerpilih)
        Me.group_DataTerpilih.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.group_DataTerpilih.Location = New System.Drawing.Point(490, 168)
        Me.group_DataTerpilih.Name = "group_DataTerpilih"
        Me.group_DataTerpilih.Size = New System.Drawing.Size(393, 357)
        Me.group_DataTerpilih.TabIndex = 4
        Me.group_DataTerpilih.TabStop = False
        Me.group_DataTerpilih.Text = "Data Terpilih"
        '
        'lbl_JumData2
        '
        Me.lbl_JumData2.AutoSize = True
        Me.lbl_JumData2.Location = New System.Drawing.Point(17, 330)
        Me.lbl_JumData2.Name = "lbl_JumData2"
        Me.lbl_JumData2.Size = New System.Drawing.Size(93, 15)
        Me.lbl_JumData2.TabIndex = 1
        Me.lbl_JumData2.Text = "Jumlah Data : 0"
        '
        'dgv_DataTerpilih
        '
        Me.dgv_DataTerpilih.AllowUserToAddRows = False
        Me.dgv_DataTerpilih.AllowUserToDeleteRows = False
        Me.dgv_DataTerpilih.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataTerpilih.Location = New System.Drawing.Point(17, 23)
        Me.dgv_DataTerpilih.Name = "dgv_DataTerpilih"
        Me.dgv_DataTerpilih.ReadOnly = True
        Me.dgv_DataTerpilih.RowHeadersWidth = 51
        Me.dgv_DataTerpilih.RowTemplate.Height = 29
        Me.dgv_DataTerpilih.Size = New System.Drawing.Size(360, 304)
        Me.dgv_DataTerpilih.TabIndex = 0
        '
        'btn_PindahSemua
        '
        Me.btn_PindahSemua.Location = New System.Drawing.Point(410, 293)
        Me.btn_PindahSemua.Name = "btn_PindahSemua"
        Me.btn_PindahSemua.Size = New System.Drawing.Size(75, 33)
        Me.btn_PindahSemua.TabIndex = 5
        Me.btn_PindahSemua.Text = ">>"
        Me.btn_PindahSemua.UseVisualStyleBackColor = True
        '
        'btn_KembalikaSemua
        '
        Me.btn_KembalikaSemua.Location = New System.Drawing.Point(410, 360)
        Me.btn_KembalikaSemua.Name = "btn_KembalikaSemua"
        Me.btn_KembalikaSemua.Size = New System.Drawing.Size(75, 33)
        Me.btn_KembalikaSemua.TabIndex = 6
        Me.btn_KembalikaSemua.Text = "<<"
        Me.btn_KembalikaSemua.UseVisualStyleBackColor = True
        '
        'FormPerhitungaBungaSimpSukarela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 587)
        Me.Controls.Add(Me.btn_KembalikaSemua)
        Me.Controls.Add(Me.btn_PindahSemua)
        Me.Controls.Add(Me.group_DataTerpilih)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.group_PilihData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPerhitungaBungaSimpSukarela"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.group_PilihData.ResumeLayout(False)
        Me.group_PilihData.PerformLayout()
        CType(Me.dgv_PilihData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.group_DataTerpilih.ResumeLayout(False)
        Me.group_DataTerpilih.PerformLayout()
        CType(Me.dgv_DataTerpilih, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lbl_TglHitung As Label
    Friend WithEvents group_PilihData As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_PilihData As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents btn_Hitung As Button
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents dtp_TglHitung As DateTimePicker
    Friend WithEvents group_DataTerpilih As GroupBox
    Friend WithEvents lbl_JumData2 As Label
    Friend WithEvents dgv_DataTerpilih As DataGridView
    Friend WithEvents btn_PindahSemua As Button
    Friend WithEvents btn_KembalikaSemua As Button
End Class
