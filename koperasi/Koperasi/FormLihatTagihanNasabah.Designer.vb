<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLihatTagihanNasabah
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
        Me.dgv_data_tagihan = New System.Windows.Forms.DataGridView()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.group_data_tagihan = New System.Windows.Forms.GroupBox()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_cetak = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_data_tagihan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_data_tagihan.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_jumlah_data
        '
        Me.lbl_jumlah_data.AutoSize = True
        Me.lbl_jumlah_data.ForeColor = System.Drawing.Color.Red
        Me.lbl_jumlah_data.Location = New System.Drawing.Point(6, 287)
        Me.lbl_jumlah_data.Name = "lbl_jumlah_data"
        Me.lbl_jumlah_data.Size = New System.Drawing.Size(93, 15)
        Me.lbl_jumlah_data.TabIndex = 2
        Me.lbl_jumlah_data.Text = "Jumlah Data : 1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_subjudul)
        Me.Panel1.Controls.Add(Me.lbl_judul)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 60)
        Me.Panel1.TabIndex = 36
        '
        'lbl_subjudul
        '
        Me.lbl_subjudul.AutoSize = True
        Me.lbl_subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_subjudul.Location = New System.Drawing.Point(25, 33)
        Me.lbl_subjudul.Name = "lbl_subjudul"
        Me.lbl_subjudul.Size = New System.Drawing.Size(285, 15)
        Me.lbl_subjudul.TabIndex = 2
        Me.lbl_subjudul.Text = "Form ini digunakan untuk melihat tagihan nasabah"
        '
        'lbl_judul
        '
        Me.lbl_judul.AutoSize = True
        Me.lbl_judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_judul.ForeColor = System.Drawing.Color.White
        Me.lbl_judul.Location = New System.Drawing.Point(13, 13)
        Me.lbl_judul.Name = "lbl_judul"
        Me.lbl_judul.Size = New System.Drawing.Size(240, 20)
        Me.lbl_judul.TabIndex = 0
        Me.lbl_judul.Text = "Form Lihat Tagihan Nasabah"
        '
        'dgv_data_tagihan
        '
        Me.dgv_data_tagihan.AllowUserToAddRows = False
        Me.dgv_data_tagihan.AllowUserToDeleteRows = False
        Me.dgv_data_tagihan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_data_tagihan.Location = New System.Drawing.Point(7, 48)
        Me.dgv_data_tagihan.Name = "dgv_data_tagihan"
        Me.dgv_data_tagihan.ReadOnly = True
        Me.dgv_data_tagihan.RowHeadersWidth = 51
        Me.dgv_data_tagihan.Size = New System.Drawing.Size(528, 233)
        Me.dgv_data_tagihan.TabIndex = 1
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(7, 20)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(528, 20)
        Me.txt_search.TabIndex = 0
        '
        'group_data_tagihan
        '
        Me.group_data_tagihan.Controls.Add(Me.lbl_jumlah_data)
        Me.group_data_tagihan.Controls.Add(Me.dgv_data_tagihan)
        Me.group_data_tagihan.Controls.Add(Me.txt_search)
        Me.group_data_tagihan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_data_tagihan.Location = New System.Drawing.Point(6, 66)
        Me.group_data_tagihan.Name = "group_data_tagihan"
        Me.group_data_tagihan.Size = New System.Drawing.Size(546, 309)
        Me.group_data_tagihan.TabIndex = 38
        Me.group_data_tagihan.TabStop = False
        Me.group_data_tagihan.Text = "Data Tagihan"
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(472, 12)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 0
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.btn_cetak)
        Me.GroupBox4.Controls.Add(Me.btn_keluar)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 381)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(564, 41)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        '
        'btn_cetak
        '
        Me.btn_cetak.Location = New System.Drawing.Point(13, 12)
        Me.btn_cetak.Name = "btn_cetak"
        Me.btn_cetak.Size = New System.Drawing.Size(87, 23)
        Me.btn_cetak.TabIndex = 2
        Me.btn_cetak.Text = "Cetak Tagihan"
        Me.btn_cetak.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(106, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Hapus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormLihatTagihanNasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 422)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.group_data_tagihan)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLihatTagihanNasabah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_data_tagihan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_data_tagihan.ResumeLayout(False)
        Me.group_data_tagihan.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_jumlah_data As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_subjudul As Label
    Friend WithEvents lbl_judul As Label
    Friend WithEvents dgv_data_tagihan As DataGridView
    Friend WithEvents txt_search As TextBox
    Friend WithEvents group_data_tagihan As GroupBox
    Friend WithEvents btn_keluar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_cetak As Button
    Friend WithEvents Button1 As Button
End Class
