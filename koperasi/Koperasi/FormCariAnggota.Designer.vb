<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCariAnggota
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.group_CariDataAnggota = New System.Windows.Forms.GroupBox()
        Me.lbl_JumData = New System.Windows.Forms.Label()
        Me.dgv_DataAnggota = New System.Windows.Forms.DataGridView()
        Me.txt_CariDataAnggota = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.group_CariDataAnggota.SuspendLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 60)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(26, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Form ini digunakan untuk mencari Anggota"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.Location = New System.Drawing.Point(14, 12)
        Me.lbl_Judul.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(114, 20)
        Me.lbl_Judul.TabIndex = 8
        Me.lbl_Judul.Text = "Cari Anggota"
        '
        'group_CariDataAnggota
        '
        Me.group_CariDataAnggota.Controls.Add(Me.lbl_JumData)
        Me.group_CariDataAnggota.Controls.Add(Me.dgv_DataAnggota)
        Me.group_CariDataAnggota.Controls.Add(Me.txt_CariDataAnggota)
        Me.group_CariDataAnggota.ForeColor = System.Drawing.Color.Black
        Me.group_CariDataAnggota.Location = New System.Drawing.Point(9, 64)
        Me.group_CariDataAnggota.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.group_CariDataAnggota.Name = "group_CariDataAnggota"
        Me.group_CariDataAnggota.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.group_CariDataAnggota.Size = New System.Drawing.Size(790, 320)
        Me.group_CariDataAnggota.TabIndex = 1
        Me.group_CariDataAnggota.TabStop = False
        Me.group_CariDataAnggota.Text = "Cari Data Anggota"
        '
        'lbl_JumData
        '
        Me.lbl_JumData.AutoSize = True
        Me.lbl_JumData.ForeColor = System.Drawing.Color.Red
        Me.lbl_JumData.Location = New System.Drawing.Point(4, 306)
        Me.lbl_JumData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_JumData.Name = "lbl_JumData"
        Me.lbl_JumData.Size = New System.Drawing.Size(81, 13)
        Me.lbl_JumData.TabIndex = 2
        Me.lbl_JumData.Text = "Jumlah Data : 0"
        '
        'dgv_DataAnggota
        '
        Me.dgv_DataAnggota.AllowUserToAddRows = False
        Me.dgv_DataAnggota.AllowUserToDeleteRows = False
        Me.dgv_DataAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_DataAnggota.Location = New System.Drawing.Point(3, 45)
        Me.dgv_DataAnggota.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dgv_DataAnggota.Name = "dgv_DataAnggota"
        Me.dgv_DataAnggota.ReadOnly = True
        Me.dgv_DataAnggota.RowHeadersWidth = 51
        Me.dgv_DataAnggota.RowTemplate.Height = 29
        Me.dgv_DataAnggota.Size = New System.Drawing.Size(782, 242)
        Me.dgv_DataAnggota.TabIndex = 1
        '
        'txt_CariDataAnggota
        '
        Me.txt_CariDataAnggota.Location = New System.Drawing.Point(4, 17)
        Me.txt_CariDataAnggota.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txt_CariDataAnggota.Name = "txt_CariDataAnggota"
        Me.txt_CariDataAnggota.Size = New System.Drawing.Size(782, 20)
        Me.txt_CariDataAnggota.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_Keluar)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 386)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.GroupBox2.Size = New System.Drawing.Size(808, 43)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btn_Keluar.Location = New System.Drawing.Point(724, 12)
        Me.btn_Keluar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(70, 27)
        Me.btn_Keluar.TabIndex = 0
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'FormCariAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 429)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.group_CariDataAnggota)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCariAnggota"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.group_CariDataAnggota.ResumeLayout(False)
        Me.group_CariDataAnggota.PerformLayout()
        CType(Me.dgv_DataAnggota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents group_CariDataAnggota As GroupBox
    Friend WithEvents lbl_JumData As Label
    Friend WithEvents dgv_DataAnggota As DataGridView
    Friend WithEvents txt_CariDataAnggota As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_Keluar As Button
End Class
