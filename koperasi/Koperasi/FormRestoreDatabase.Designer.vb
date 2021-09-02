<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRestoreDatabase
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Cari = New System.Windows.Forms.Button()
        Me.txt_LokalisasiDB = New System.Windows.Forms.TextBox()
        Me.lbl_LokalisasiDB = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Keluar = New System.Windows.Forms.Button()
        Me.btn_Restore = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 65)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(22, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Menu ini digunakan untuk merestore database"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Restore Database"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Cari)
        Me.GroupBox1.Controls.Add(Me.txt_LokalisasiDB)
        Me.GroupBox1.Controls.Add(Me.lbl_LokalisasiDB)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 70)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(810, 56)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btn_Cari
        '
        Me.btn_Cari.Location = New System.Drawing.Point(711, 21)
        Me.btn_Cari.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Cari.Name = "btn_Cari"
        Me.btn_Cari.Size = New System.Drawing.Size(82, 22)
        Me.btn_Cari.TabIndex = 9
        Me.btn_Cari.Text = "Cari"
        Me.btn_Cari.UseVisualStyleBackColor = True
        '
        'txt_LokalisasiDB
        '
        Me.txt_LokalisasiDB.Location = New System.Drawing.Point(150, 20)
        Me.txt_LokalisasiDB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_LokalisasiDB.Name = "txt_LokalisasiDB"
        Me.txt_LokalisasiDB.Size = New System.Drawing.Size(543, 20)
        Me.txt_LokalisasiDB.TabIndex = 8
        '
        'lbl_LokalisasiDB
        '
        Me.lbl_LokalisasiDB.AutoSize = True
        Me.lbl_LokalisasiDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.lbl_LokalisasiDB.Location = New System.Drawing.Point(12, 23)
        Me.lbl_LokalisasiDB.Name = "lbl_LokalisasiDB"
        Me.lbl_LokalisasiDB.Size = New System.Drawing.Size(118, 15)
        Me.lbl_LokalisasiDB.TabIndex = 7
        Me.lbl_LokalisasiDB.Text = "Lokalisasi Database"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btn_Keluar)
        Me.GroupBox2.Controls.Add(Me.btn_Restore)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 145)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(831, 51)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'btn_Keluar
        '
        Me.btn_Keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!)
        Me.btn_Keluar.Location = New System.Drawing.Point(721, 14)
        Me.btn_Keluar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Keluar.Name = "btn_Keluar"
        Me.btn_Keluar.Size = New System.Drawing.Size(82, 29)
        Me.btn_Keluar.TabIndex = 1
        Me.btn_Keluar.Text = "Keluar"
        Me.btn_Keluar.UseVisualStyleBackColor = True
        '
        'btn_Restore
        '
        Me.btn_Restore.Location = New System.Drawing.Point(10, 16)
        Me.btn_Restore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Restore.Name = "btn_Restore"
        Me.btn_Restore.Size = New System.Drawing.Size(82, 29)
        Me.btn_Restore.TabIndex = 0
        Me.btn_Restore.Text = "Restore"
        Me.btn_Restore.UseVisualStyleBackColor = True
        '
        'FormRestoreDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 196)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormRestoreDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Cari As Button
    Friend WithEvents txt_LokalisasiDB As TextBox
    Friend WithEvents lbl_LokalisasiDB As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_Keluar As Button
    Friend WithEvents btn_Restore As Button
End Class
