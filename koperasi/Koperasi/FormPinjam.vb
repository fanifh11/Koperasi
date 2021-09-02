Public Class FormPinjam
    Public idanggota As String = "0"
    Public idpinjam As String = ""

    Dim selectKodePinjam As String = ""

    Sub lockForm()
        group_informasi_nasabah.Enabled = False
        group_informasi_peminjaman.Enabled = False
        btn_tambah.Enabled = True
        btn_keluar.Enabled = True

    End Sub

    Sub openForm()
        group_informasi_nasabah.Enabled = True
        group_informasi_peminjaman.Enabled = True
        btn_tambah.Enabled = False
        btn_keluar.Enabled = False

    End Sub

    Sub buatNilai0()
        txt_besar_pinjam.Text = 0
        txt_lama_pinjam.Text = 0
        txt_bunga.Text = 0
        txt_asuransi.Text = 0
        txt_administrasi.Text = 0
        txt_jumlah_diterima.Text = 0
        txt_angsuran_bunga.Text = 0
        txt_angsuran_pokok.Text = 0
        txt_jumlah_angsuran.Text = 0

    End Sub

    Sub kondisiBtnCetak()
        If String.IsNullOrEmpty(selectKodePinjam) Then
            btn_cetak_kwitansi.Enabled = False
        Else
            btn_cetak_kwitansi.Enabled = True
        End If
    End Sub

    Sub kondisiBtnHapus()
        If String.IsNullOrEmpty(selectKodePinjam) Then
            btn_hapus.Enabled = False
        Else
            btn_hapus.Enabled = True
        End If
    End Sub

    Dim metode As String = ""

    Sub showData()
        dgv_data_peminjaman.DataSource = getData("select idpinjam,idanggota,anggota,jenis,to_char(tglpinjam, 'DD-MM-YYYY') as tglpinjam,besarpinjam,lamapinjam,persenbunga,asuransi,administrasi,diterima,angsuranpokok,angsuranbunga,jumlahangsuran from qpinjam where idanggota='" & idanggota & "' and jenis ilike '%" & txt_search.Text & "%'  ")
        dgv_data_peminjaman.Columns(0).HeaderText = "Kode Pinjam"
        dgv_data_peminjaman.Columns(1).HeaderText = "Kode Anggota"
        dgv_data_peminjaman.Columns(2).HeaderText = "Nama"
        dgv_data_peminjaman.Columns(3).HeaderText = "Jenis Pinjam"
        dgv_data_peminjaman.Columns(4).HeaderText = "Tanggal Pinjam"
        dgv_data_peminjaman.Columns(5).HeaderText = "Besar Pinjam"
        dgv_data_peminjaman.Columns(6).HeaderText = "Lama Pinjam"
        dgv_data_peminjaman.Columns(7).HeaderText = "Persen Bunga"
        dgv_data_peminjaman.Columns(8).HeaderText = "Asuransi"
        dgv_data_peminjaman.Columns(9).HeaderText = "Administrasi"
        dgv_data_peminjaman.Columns(10).HeaderText = "Uang Diterima"
        dgv_data_peminjaman.Columns(11).HeaderText = "Angsuran Pokok"
        dgv_data_peminjaman.Columns(12).HeaderText = "Angsuran Bunga"
        dgv_data_peminjaman.Columns(13).HeaderText = "Jumlah Angsuran"

        dgv_data_peminjaman.Columns(5).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(8).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(9).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(10).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(11).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(12).DefaultCellStyle.Format = "c0"
        dgv_data_peminjaman.Columns(13).DefaultCellStyle.Format = "c0"

        lbl_jumlah_data.Text = "Jumlah Data : " & dgv_data_peminjaman.Rows.Count


    End Sub

    Public Sub hitungAngsuranPokok()
        Dim besarPinjam As Double = toDouble(txt_besar_pinjam.Text)
        Dim lamaPinjam As Double = toDouble(txt_lama_pinjam.Text)

        Dim besarBunga As Double = toDouble(txt_bunga.Text)
        Dim totalPokok As Double = toDouble(txt_angsuran_pokok.Text)


        If cmb_JenisBunga.SelectedIndex = 2 Then
            besarBunga = (besarBunga * 12) / 100
            lamaPinjam = toDouble(txt_lama_pinjam.Text)
            Dim a As Double = besarBunga / 12
            Dim b As Double = (1 / (1 + a)) ^ lamaPinjam

            Dim bunga As Double = a / (1 - b)
            Dim total As Double = Math.Ceiling(besarPinjam * bunga)

            total = (besarPinjam * besarBunga / 12) / (1 - 1 / (1 + besarBunga / 12) ^ lamaPinjam)

            txt_angsuran_pokok.Text = Math.Ceiling(total - toDouble(txt_angsuran_bunga.Text)).ToString

        ElseIf cmb_JenisBunga.SelectedIndex = 1 Then
            txt_angsuran_pokok.Text = Math.Ceiling(besarPinjam / lamaPinjam).ToString

        ElseIf cmb_JenisBunga.SelectedIndex = 0 Then
            txt_angsuran_pokok.Text = Math.Ceiling(besarPinjam / lamaPinjam).ToString
        End If


        hitungJumAngsuran()

    End Sub

    Sub hitungBunga()
        Dim besarPinjam As Double = toDouble(txt_besar_pinjam.Text)
        Dim besarBunga As Double = toDouble(txt_bunga.Text)
        Dim totalPokok As Double = toDouble(txt_angsuran_pokok.Text)

        txt_angsuran_bunga.Text = Math.Ceiling((besarPinjam * besarBunga) / 100).ToString
        hitungAngsuranPokok()

        hitungJumAngsuran()

    End Sub

    Sub hitungJumAngsuran()
        Dim jumAngsuranPokok As Double = toDouble(txt_angsuran_pokok.Text)
        Dim jumAngsuranBunga As Double = toDouble(txt_angsuran_bunga.Text)

        txt_jumlah_angsuran.Text = (jumAngsuranPokok + jumAngsuranBunga).ToString
    End Sub

    Sub jumUangDiterima()
        Dim besarPinjam As Double = toDouble(txt_besar_pinjam.Text)
        Dim biayaAsuransi As Double = toDouble(txt_asuransi.Text)
        Dim biayaAdministrasi As Double = toDouble(txt_administrasi.Text)

        txt_jumlah_diterima.Text = (besarPinjam - (biayaAdministrasi + biayaAsuransi)).ToString

    End Sub
    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        FormCariAnggota.menu = "Data Peminjam"
        FormCariAnggota.ShowDialog()
        FormCariAnggota.Dispose()

        showData()

    End Sub

    Private Sub FormPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_JenisBunga.SelectedIndex = 0
        buatNilai0()
        lockForm()

        kondisiBtnCetak()
        kondisiBtnHapus()
        txt_kode_pinjam.Text = Now.ToString("yyyyMMddHHmmss")
    End Sub
    Private Sub txt_besar_pinjam_TextChanged(sender As Object, e As EventArgs) Handles txt_besar_pinjam.TextChanged
        hitungAngsuranPokok()
        hitungBunga()
        jumUangDiterima()

    End Sub
    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click

        If adaKosong(group_informasi_nasabah) Then
            dialogError("Pilih data nasabah terlebih dahulu !")
            Return
        ElseIf txt_besar_pinjam.Text = "0" Or txt_lama_pinjam.Text = "0" Or txt_bunga.Text = "0" Then
            dialogError("Lengkapi form data peminjmanan nasabah terlebih dahulu !")
            Return
        ElseIf adaKosong(group_informasi_peminjaman) Then
            dialogError("Lengkapi form data peminjaman nasabah terlebih dahulu !")
        Else
            Dim kodeAnggota As String = txt_kode_nasabah.Text
            Dim kodePinjam As String = txt_kode_pinjam.Text
            Dim jenisPinjam As String = cmb_JenisBunga.Text
            Dim tglPinjam As String = dtp_tanggal_pinjam.Value
            Dim besarPinjam As String = txt_besar_pinjam.Text
            Dim lamaPinjam As String = txt_lama_pinjam.Text
            Dim persenBunga As String = txt_bunga.Text
            Dim asuransi As String = txt_asuransi.Text
            Dim administrasi As String = txt_administrasi.Text
            Dim diterima As String = txt_jumlah_diterima.Text

            Dim angsuranPokok As String = txt_angsuran_pokok.Text
            Dim angsuranBunga As String = txt_angsuran_bunga.Text
            Dim jumAngsuran As String = txt_jumlah_angsuran.Text

            If dialog("Apakah yakin untuk membuat pinjaman ?") Then
                If getCount("select idpinjam from tblpinjam where idpinjam = '" & kodePinjam & "' ") = 0 Then
                    exc("insert into tblpinjam 
                        (
                            idpinjam,
                            idanggota,
                            jenis,
                            tglpinjam,
                            besarpinjam,
                            lamapinjam,
                            persenbunga,
                            administrasi,
                            asuransi,
                            angsuranpokok,
                            angsuranbunga,
                            jumlahangsuran,
                            diterima,
                            bayarpokok,
                            bayarbunga,
                            saldopinjam,
                            statuspinjam,
                            flagpinjam,
                            addpinjam,
                            flagpostingpinjam
                        )values
                        (
                            '" & kodePinjam & "',
                            '" & kodeAnggota & "',
                            '" & jenisPinjam & "',
                            '" & tglPinjam & "',
                            '" & besarPinjam & "',
                            '" & lamaPinjam & "',
                            '" & persenBunga & "',
                            '" & administrasi & "',
                            '" & asuransi & "',
                            '" & angsuranPokok & "',
                            '" & angsuranBunga & "',
                            '" & jumAngsuran & "',
                            '" & diterima & "',
                            0,
                            0,
                            '" & besarPinjam & "',
                            0,
                            0,
                            'admin',
                            0
                        )
                    ")
                    dialogInfo("Input sukses")
                Else
                    dialogError("Ada duplikasi kode pinjam !")
                End If
            End If
            clearForm(group_informasi_peminjaman)
            clearForm(group_informasi_nasabah)
            txt_kode_pinjam.Text = Now.ToString("yyyyMMddHHmmss")
        End If
        showData()

    End Sub

    Private Sub txt_asuransi_TextChanged(sender As Object, e As EventArgs) Handles txt_asuransi.TextChanged
        jumUangDiterima()
    End Sub

    Private Sub txt_administrasi_TextChanged(sender As Object, e As EventArgs) Handles txt_administrasi.TextChanged
        jumUangDiterima()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        showData()

    End Sub

    Private Sub txt_lama_pinjam_TextChanged(sender As Object, e As EventArgs) Handles txt_lama_pinjam.TextChanged
        hitungAngsuranPokok()
    End Sub


    Private Sub txt_bunga_TextChanged(sender As Object, e As EventArgs) Handles txt_bunga.TextChanged
        If toDouble(txt_bunga.Text) > 100 Then
            dialogError("Persen Bunga Kelebihan !")
        Else
            hitungBunga()

        End If

    End Sub

    Private Sub cmb_JenisBunga_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_JenisBunga.SelectedIndexChanged
        If cmb_JenisBunga.SelectedIndex = 0 Then
            hitungAngsuranPokok()
            hitungBunga()
            hitungJumAngsuran()
        ElseIf cmb_JenisBunga.SelectedIndex = 1 Then
            hitungAngsuranPokok()
            hitungBunga()
            hitungJumAngsuran()
        ElseIf cmb_JenisBunga.SelectedIndex = 2 Then
            hitungAngsuranPokok()
            hitungBunga()
            hitungJumAngsuran()
        End If
    End Sub
    Private Sub txt_kode_pinjam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_kode_pinjam.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_besar_pinjam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_besar_pinjam.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_lama_pinjam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_lama_pinjam.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_bunga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bunga.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_angsuran_pokok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_angsuran_pokok.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_angsuran_bunga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_angsuran_bunga.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub txt_jumlah_angsuran_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jumlah_angsuran.KeyPress
        onlyNumber(e)

    End Sub

    Private Sub txt_asuransi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_asuransi.KeyPress
        onlyNumber(e)

    End Sub

    Private Sub txt_administrasi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_administrasi.KeyPress
        onlyNumber(e)

    End Sub

    Private Sub txt_jumlah_diterima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jumlah_diterima.KeyPress
        onlyNumber(e)
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click


        Dim selectIdPinjam As String = dgv_data_peminjaman.Rows(dgv_data_peminjaman.CurrentCell.RowIndex).Cells(0).Value.ToString

        If dialog("Apakah anda yakin untuk menghapus data ?") Then
            If getCount("select idpinjam from tbltagihan where idpinjam = '" & selectIdPinjam & "'") > 0 Then
                dialogError("Data tidak dapat di hapus dikarenakan pembayaran piutang nasabah masih ada")
                Return
            Else
                exc("delete from tblpinjam where idpinjam = '" & selectIdPinjam & "' ")
                Debug.WriteLine("delete from tblpinjam where idpinjam = '" & selectIdPinjam & "' ")

                dialogInfo("Hapus data nasabah berhasil !")
                showData()

            End If
        End If


    End Sub

    Private Sub btn_batal_Click(sender As Object, e As EventArgs) Handles btn_batal.Click
        lockForm()
        clearForm(group_informasi_nasabah)
        clearForm(group_informasi_peminjaman)
        dgv_data_peminjaman.DataSource = Nothing

        txt_kode_pinjam.Text = Now.ToString("yyyyMMddHHmmss")

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        openForm()
    End Sub

    Private Sub btn_cetak_kwitansi_Click(sender As Object, e As EventArgs) Handles btn_cetak_kwitansi.Click
        PreviewFormPinjam.idpinjam = dgv_data_peminjaman.Rows(dgv_data_peminjaman.CurrentCell.RowIndex).Cells(0).Value.ToString
        PreviewFormPinjam.ShowDialog()


    End Sub

    Private Sub dgv_data_peminjaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data_peminjaman.CellClick
        If (e.RowIndex >= 0) Then
            selectKodePinjam = dgv_data_peminjaman.Rows(e.RowIndex).Cells(0).Value
            idpinjam = selectKodePinjam

            kondisiBtnCetak()
            kondisiBtnHapus()
        End If
    End Sub
End Class