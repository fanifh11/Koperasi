<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBackupDatabase
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
        Me.btn_LokalisasiHasilBckup = New System.Windows.Forms.Button()
        Me.btn_Backup = New System.Windows.Forms.Button()
        Me.txt_LokaliasasiDB = New System.Windows.Forms.TextBox()
        Me.lbl_Subjudul = New System.Windows.Forms.Label()
        Me.lbl_Judul = New System.Windows.Forms.Label()
        Me.lbl_LokalisasiDB = New System.Windows.Forms.Label()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.grupBtn = New System.Windows.Forms.GroupBox()
        Me.group_LokalisasiDB = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grupBtn.SuspendLayout()
        Me.group_LokalisasiDB.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_LokalisasiHasilBckup
        '
        Me.btn_LokalisasiHasilBckup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_LokalisasiHasilBckup.Location = New System.Drawing.Point(320, 53)
        Me.btn_LokalisasiHasilBckup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_LokalisasiHasilBckup.Name = "btn_LokalisasiHasilBckup"
        Me.btn_LokalisasiHasilBckup.Size = New System.Drawing.Size(288, 26)
        Me.btn_LokalisasiHasilBckup.TabIndex = 7
        Me.btn_LokalisasiHasilBckup.Text = "Lokalisasi Hasil Backup"
        Me.btn_LokalisasiHasilBckup.UseVisualStyleBackColor = True
        '
        'btn_Backup
        '
        Me.btn_Backup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Backup.Location = New System.Drawing.Point(207, 53)
        Me.btn_Backup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Backup.Name = "btn_Backup"
        Me.btn_Backup.Size = New System.Drawing.Size(106, 26)
        Me.btn_Backup.TabIndex = 6
        Me.btn_Backup.Text = "Backup"
        Me.btn_Backup.UseVisualStyleBackColor = True
        '
        'txt_LokaliasasiDB
        '
        Me.txt_LokaliasasiDB.Location = New System.Drawing.Point(207, 23)
        Me.txt_LokaliasasiDB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_LokaliasasiDB.Name = "txt_LokaliasasiDB"
        Me.txt_LokaliasasiDB.Size = New System.Drawing.Size(491, 21)
        Me.txt_LokaliasasiDB.TabIndex = 5
        '
        'lbl_Subjudul
        '
        Me.lbl_Subjudul.AutoSize = True
        Me.lbl_Subjudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_Subjudul.ForeColor = System.Drawing.Color.White
        Me.lbl_Subjudul.Location = New System.Drawing.Point(25, 33)
        Me.lbl_Subjudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Subjudul.Name = "lbl_Subjudul"
        Me.lbl_Subjudul.Size = New System.Drawing.Size(313, 17)
        Me.lbl_Subjudul.TabIndex = 3
        Me.lbl_Subjudul.Text = "Menu ini digunakan untuk membackup database"
        '
        'lbl_Judul
        '
        Me.lbl_Judul.AutoSize = True
        Me.lbl_Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lbl_Judul.ForeColor = System.Drawing.Color.White
        Me.lbl_Judul.Location = New System.Drawing.Point(14, 8)
        Me.lbl_Judul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Judul.Name = "lbl_Judul"
        Me.lbl_Judul.Size = New System.Drawing.Size(152, 20)
        Me.lbl_Judul.TabIndex = 2
        Me.lbl_Judul.Text = "Backup Database"
        '
        'lbl_LokalisasiDB
        '
        Me.lbl_LokalisasiDB.AutoSize = True
        Me.lbl_LokalisasiDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.lbl_LokalisasiDB.Location = New System.Drawing.Point(32, 23)
        Me.lbl_LokalisasiDB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_LokalisasiDB.Name = "lbl_LokalisasiDB"
        Me.lbl_LokalisasiDB.Size = New System.Drawing.Size(118, 15)
        Me.lbl_LokalisasiDB.TabIndex = 4
        Me.lbl_LokalisasiDB.Text = "Lokalisasi Database"
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Keluar.Location = New System.Drawing.Point(640, 20)
        Me.btn_Keluar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(106, 26)
        Me.btn_Keluar.TabIndex = 8
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'grupBtn
        '
        Me.grupBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.grupBtn.Controls.Add(Me.btn_Keluar)
        Me.grupBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grupBtn.Location = New System.Drawing.Point(0, 187)
        Me.grupBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grupBtn.Name = "grupBtn"
        Me.grupBtn.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grupBtn.Size = New System.Drawing.Size(759, 56)
        Me.grupBtn.TabIndex = 11
        Me.grupBtn.TabStop = False
        '
        'group_LokalisasiDB
        '
        Me.group_LokalisasiDB.Controls.Add(Me.btn_LokalisasiHasilBckup)
        Me.group_LokalisasiDB.Controls.Add(Me.btn_Backup)
        Me.group_LokalisasiDB.Controls.Add(Me.txt_LokaliasasiDB)
        Me.group_LokalisasiDB.Controls.Add(Me.lbl_LokalisasiDB)
        Me.group_LokalisasiDB.Location = New System.Drawing.Point(14, 81)
        Me.group_LokalisasiDB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.group_LokalisasiDB.Name = "group_LokalisasiDB"
        Me.group_LokalisasiDB.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.group_LokalisasiDB.Size = New System.Drawing.Size(729, 98)
        Me.group_LokalisasiDB.TabIndex = 10
        Me.group_LokalisasiDB.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_Subjudul)
        Me.Panel1.Controls.Add(Me.lbl_Judul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 66)
        Me.Panel1.TabIndex = 9
        '
        'FormBackupDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 243)
        Me.Controls.Add(Me.grupBtn)
        Me.Controls.Add(Me.group_LokalisasiDB)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBackupDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.grupBtn.ResumeLayout(False)
        Me.group_LokalisasiDB.ResumeLayout(False)
        Me.group_LokalisasiDB.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_LokalisasiHasilBckup As Button
    Friend WithEvents btn_Backup As Button
    Friend WithEvents txt_LokaliasasiDB As TextBox
    Friend WithEvents lbl_Subjudul As Label
    Friend WithEvents lbl_Judul As Label
    Friend WithEvents lbl_LokalisasiDB As Label
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents grupBtn As GroupBox
    Friend WithEvents group_LokalisasiDB As GroupBox
    Friend WithEvents Panel1 As Panel
End Class
