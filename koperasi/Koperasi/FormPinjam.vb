Public Class FormPinjam
    Public idanggota As String = "0"
    Public idpinjam As String = ""

    Dim selectKodePinjam As String = ""

    Sub lockForm()
        group_informasi_nasabah.Enabled = False
        group_informasi_peminjaman.Enabled = False
        btn_tambah.Enabled = True
        btn_keluar.Enabled = True
        TabControl1.Enabled = False
        TabControl1.SelectedIndex = 0
        btn_simpan.Enabled = False
        btn_batal.Enabled = False
    End Sub



    Sub generateTagihan(idpinjam As String)
        If cbGenerate.Checked Then
            Dim dataTagihan As New DataTable
            Select Case cmb_JenisBunga.SelectedIndex
                Case 0
                    dataTagihan = tagihanFlat(idpinjam)
                Case 1
                    dataTagihan = tagihanEfektif(idpinjam)
                Case 2
                    dataTagihan = tagihanAnuitas(idpinjam)
            End Select
            dgv_data_peminjaman.DataSource = dataTagihan
            insertTagihan(dataTagihan, idpinjam)
        End If
    End Sub


    Function insertTagihan(dt As DataTable, idpinjam As String)
        For Each tagihan As DataRow In dt.Rows
            Dim idTagihan As String = Now.ToString("yyyyMMddHHmmss") & Strings.Left(System.Guid.NewGuid.ToString(), 4)
            Dim kodeTagihan As String = Now.ToString("yyyyMMdd-HHmmss") & Strings.Left(System.Guid.NewGuid.ToString(), 2)
            exc("insert into tbltagihan
                (
                    idtagihan,
                    idpinjam,
                    tgltagihan,
                    tglbayar,
                    totalpokok,
                    totalangsur,
                    totalbunga,
                    cicilanke,
                    flagtagihan,
                    kodetagihan,
                    addtagihan,
                    flagpostingtagihan
                )values
                (
                    '" & idTagihan & "',
                    '" & idpinjam & "',
                    '" & tagihan.Item("tgltagihan") & "',
                    now(),
                    '" & tagihan.Item("totalpokok") & "',
                    '" & tagihan.Item("totalangsur") & "',
                    '" & tagihan.Item("totalbunga") & "',
                    '" & tagihan.Item("cicilanke") & "',
                    0,
                    '" & kodeTagihan & "',
                    'admin',
                    0
                )
            
            ")
        Next
    End Function

    Function tagihanFlat(idpinjam As String) As DataTable
        'Masukkan datatable 
        Dim result As DataTable = getData("SELECT tgltagihan,cicilanke,totalpokok,totalbunga,totalangsur FROM tbltagihan where idtagihan is null and idpinjam is null")
        Dim dataHutang As DataTable = getData($"SELECT besarpinjam,lamapinjam,persenbunga,angsuranpokok,angsuranbunga, tglpinjam FROM tblpinjam where idpinjam='{idpinjam}'")
        Dim sampai As Integer = dataHutang.Rows(0).Item("lamapinjam")
        Dim tanggalPinjam As Date = Date.Parse(dataHutang.Rows(0).Item("tglpinjam").ToString)
        For cicilanKe As Integer = 1 To sampai
            tanggalPinjam = tanggalPinjam.AddMonths(1)
            Dim rowBaru As DataRow = result.NewRow()
            rowBaru.Item("cicilanke") = cicilanKe
            rowBaru.Item("totalpokok") = dataHutang.Rows(0).Item("angsuranpokok")
            rowBaru.Item("totalbunga") = dataHutang.Rows(0).Item("angsuranbunga")
            rowBaru.Item("totalangsur") = dataHutang.Rows(0).Item("angsuranbunga") + dataHutang.Rows(0).Item("angsuranpokok")
            Dim tahun As String = tanggalPinjam.Year.ToString
            Dim bulan As String = If(tanggalPinjam.Month < 10, $"0{tanggalPinjam.Month.ToString}", tanggalPinjam.Month.ToString)
            Dim hari As String = If(tanggalPinjam.Day < 10, $"0{tanggalPinjam.Day.ToString}", tanggalPinjam.Day.ToString)
            rowBaru.Item("tgltagihan") = $"{tahun}-{bulan}-{hari}"
            result.Rows.Add(rowBaru)
        Next

        Return result
    End Function


    Function tagihanEfektif(idpinjam As String) As DataTable
        'Masukkan datatable 
        Dim result As DataTable = getData("SELECT tgltagihan,cicilanke,totalpokok,totalbunga,totalangsur FROM tbltagihan where idtagihan is null and idpinjam is null")
        Dim dataHutang As DataTable = getData($"SELECT besarpinjam, persenbunga,lamapinjam,persenbunga,angsuranpokok,angsuranbunga, tglpinjam FROM tblpinjam where idpinjam='{idpinjam}'")
        Dim sampai As Integer = dataHutang.Rows(0).Item("lamapinjam")
        Dim besarPinjam As Double = toDouble(dataHutang.Rows(0).Item("besarpinjam").ToString)
        Dim tanggalPinjam As Date = Date.Parse(dataHutang.Rows(0).Item("tglpinjam").ToString)
        For cicilanKe As Integer = 1 To sampai
            tanggalPinjam = tanggalPinjam.AddMonths(1)
            Dim rowBaru As DataRow = result.NewRow()
            rowBaru.Item("cicilanke") = cicilanKe
            rowBaru.Item("totalpokok") = dataHutang.Rows(0).Item("angsuranpokok")
            rowBaru.Item("totalbunga") = Math.Ceiling(besarPinjam * toDouble(dataHutang.Rows(0).Item("persenbunga")) / 100)
            rowBaru.Item("totalangsur") = rowBaru.Item("totalbunga") + rowBaru.Item("totalpokok")
            besarPinjam = besarPinjam - rowBaru.Item("totalpokok")
            Dim tahun As String = tanggalPinjam.Year.ToString
            Dim bulan As String = If(tanggalPinjam.Month < 10, $"0{tanggalPinjam.Month.ToString}", tanggalPinjam.Month.ToString)
            Dim hari As String = If(tanggalPinjam.Day < 10, $"0{tanggalPinjam.Day.ToString}", tanggalPinjam.Day.ToString)
            rowBaru.Item("tgltagihan") = $"{tahun}-{bulan}-{hari}"
            result.Rows.Add(rowBaru)
        Next
        Return result
    End Function



    Function tagihanAnuitas(idpinjam As String) As DataTable
        'Masukkan datatable 
        Dim result As DataTable = getData("SELECT tgltagihan,cicilanke,totalpokok,totalbunga,totalangsur FROM tbltagihan where idtagihan is null and idpinjam is null")
        Dim dataHutang As DataTable = getData($"SELECT besarpinjam,jumlahangsuran, persenbunga,lamapinjam,persenbunga,angsuranpokok,angsuranbunga, tglpinjam FROM tblpinjam where idpinjam='{idpinjam}'")
        Dim sampai As Integer = dataHutang.Rows(0).Item("lamapinjam")
        Dim besarPinjam As Double = toDouble(dataHutang.Rows(0).Item("besarpinjam").ToString)
        Dim tanggalPinjam As Date = Date.Parse(dataHutang.Rows(0).Item("tglpinjam").ToString)
        For cicilanKe As Integer = 1 To sampai
            tanggalPinjam = tanggalPinjam.AddMonths(1)
            Dim rowBaru As DataRow = result.NewRow()
            rowBaru.Item("cicilanke") = cicilanKe

            rowBaru.Item("totalbunga") = Math.Ceiling(besarPinjam * toDouble(dataHutang.Rows(0).Item("persenbunga")) / 100)
            rowBaru.Item("totalpokok") = toDouble(dataHutang.Rows(0).Item("jumlahangsuran")) - rowBaru.Item("totalbunga")
            rowBaru.Item("totalangsur") = rowBaru.Item("totalbunga") + rowBaru.Item("totalpokok")
            besarPinjam = besarPinjam - rowBaru.Item("totalpokok")
            Dim tahun As String = tanggalPinjam.Year.ToString
            Dim bulan As String = If(tanggalPinjam.Month < 10, $"0{tanggalPinjam.Month.ToString}", tanggalPinjam.Month.ToString)
            Dim hari As String = If(tanggalPinjam.Day < 10, $"0{tanggalPinjam.Day.ToString}", tanggalPinjam.Day.ToString)
            rowBaru.Item("tgltagihan") = $"{tahun}-{bulan}-{hari}"
            result.Rows.Add(rowBaru)
        Next
        Return result
    End Function

    Sub openForm()
        group_informasi_nasabah.Enabled = True
        group_informasi_peminjaman.Enabled = True
        btn_tambah.Enabled = False
        btn_keluar.Enabled = False
        TabControl1.Enabled = True
        TabControl1.SelectedIndex = 0

        resetJaminanBPKB()
        resetJaminanSHM()
        tbDenda.Text = "0"
        btn_simpan.Enabled = True
        btn_batal.Enabled = True
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
            btnShm.Enabled = False
            btnBPKB.Enabled = False
            btnSuratPerjanjian.Enabled = False
            btnAngsuran.Enabled = False
        Else
            btn_cetak_kwitansi.Enabled = True
            btnShm.Enabled = True
            btnBPKB.Enabled = True
            btnSuratPerjanjian.Enabled = True
            btnAngsuran.Enabled = True
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
        dgv_data_peminjaman.DataSource = getData("select idpinjam,idanggota,anggota,jenis, to_date(to_char(tglpinjam, 'dd-MM-yyyy'),'dd-MM-yyyy') as tglpinjam,besarpinjam,lamapinjam,persenbunga,asuransi,administrasi,diterima,angsuranpokok,angsuranbunga,jumlahangsuran,alamat, dendapersen as Denda
        from qpinjam where (tglpinjam between '" & Now().ToString("yyyy-MM-dd") & " 00:00' and '" & Now().ToString("yyyy-MM-dd") & " 23:59')  and jenis ilike '%" & txt_search.Text & "%'  ")
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
        dgv_data_peminjaman.Columns(14).Visible = False

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

        Dim besarPinjam As Double = toDouble(unnumberFormat(txt_besar_pinjam.Text))
        Dim lamaPinjam As Double = toDouble(txt_lama_pinjam.Text)

        Dim besarBunga As Double = toDouble((txt_bunga.Text))

        Dim totalPokok As Double = toDouble(unnumberFormat(txt_angsuran_pokok.Text))


        If cmb_JenisBunga.SelectedIndex = 2 Then
            besarBunga = (besarBunga * 12) / 100
            lamaPinjam = toDouble(txt_lama_pinjam.Text)
            Dim a As Double = besarBunga / 12
            Dim b As Double = (1 / (1 + a)) ^ lamaPinjam

            Dim bunga As Double = a / (1 - b)
            Dim total As Double = Math.Ceiling(besarPinjam * bunga)

            total = (besarPinjam * besarBunga / 12) / (1 - 1 / (1 + besarBunga / 12) ^ lamaPinjam)

            txt_angsuran_pokok.Text = numberFormat(Math.Ceiling(total - toDouble(unnumberFormat(txt_angsuran_bunga.Text))).ToString)

        ElseIf cmb_JenisBunga.SelectedIndex = 1 Then
            txt_angsuran_pokok.Text = numberFormat(Math.Ceiling(besarPinjam / lamaPinjam).ToString)

        ElseIf cmb_JenisBunga.SelectedIndex = 0 Then
            txt_angsuran_pokok.Text = numberFormat(Math.Ceiling(besarPinjam / lamaPinjam).ToString)
        End If


        hitungJumAngsuran()

    End Sub

    Sub hitungBunga()
        Dim besarPinjam As Double = toDouble(unnumberFormat(txt_besar_pinjam.Text))
        Dim besarBunga As Double = toDouble((txt_bunga.Text))
        Dim totalPokok As Double = toDouble(unnumberFormat(txt_angsuran_pokok.Text))

        txt_angsuran_bunga.Text = numberFormat(Math.Ceiling((besarPinjam * besarBunga) / 100).ToString)
        hitungAngsuranPokok()

        hitungJumAngsuran()

    End Sub

    Sub hitungJumAngsuran()
        Dim jumAngsuranPokok As Double = toDouble(unnumberFormat(txt_angsuran_pokok.Text))
        Dim jumAngsuranBunga As Double = toDouble(unnumberFormat(txt_angsuran_bunga.Text))

        txt_jumlah_angsuran.Text = numberFormat((jumAngsuranPokok + jumAngsuranBunga).ToString)
    End Sub

    Sub jumUangDiterima()
        Dim besarPinjam As Double = toDouble(unnumberFormat(txt_besar_pinjam.Text))
        Dim biayaAsuransi As Double = toDouble(unnumberFormat(txt_asuransi.Text))
        Dim biayaAdministrasi As Double = toDouble(unnumberFormat(txt_administrasi.Text))

        txt_jumlah_diterima.Text = numberFormat((besarPinjam - (biayaAdministrasi + biayaAsuransi)).ToString)

    End Sub
    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Me.Close()
    End Sub

    Private Sub btn_cari_Click(sender As Object, e As EventArgs) Handles btn_cari.Click
        FormCariAnggota.menu = "Data Peminjam"
        FormCariAnggota.ShowDialog()
        FormCariAnggota.Dispose()
    End Sub

    Private Sub FormPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_JenisBunga.SelectedIndex = 0
        buatNilai0()
        lockForm()

        kondisiBtnCetak()
        kondisiBtnHapus()
        showData()

        txt_kode_pinjam.Text = Now.ToString("yyyyMMddHHmmss")
    End Sub
    Private Sub txt_besar_pinjam_TextChanged(sender As Object, e As EventArgs) Handles txt_besar_pinjam.TextChanged
        hitungAngsuranPokok()
        hitungBunga()
        jumUangDiterima()

    End Sub

    Sub simpanJaminan(idpinjam As String)
        simpanJaminanBPKB(idpinjam)
        simpanJaminanSHM(idpinjam)
    End Sub

    Sub resetJaminanBPKB()
        cbJenis.SelectedIndex = 0
        For Each tb As Control In tabBPKB.Controls
            If TypeOf tb Is TextBox And Not tb.Name = "tbMaksKredit" Then
                CType(tb, TextBox).Text = ""
            End If
        Next

        tbMaksKredit.Text = "0"
    End Sub


    Sub resetJaminanSHM()
        For Each tb As Control In tabSHM.Controls
            If TypeOf tb Is TextBox Then
                CType(tb, TextBox).Text = ""
            End If
        Next
    End Sub

    Sub simpanJaminanSHM(idpinjam As String)
        Dim noSHM As String = tbShm.Text
        Dim atasNama As String = tbANSHM.Text
        Dim saksi1 As String = tbSaksi1.Text
        Dim saksi2 As String = tbSaksi2.Text
        Dim saksi3 As String = tbSaksi3.Text
        Dim hari As String = tbHariShm.Text

        Dim dataJaminan As String() = {noSHM, atasNama, saksi1, saksi2, saksi3, hari, idpinjam}
        Dim sqlJaminan As String = $"INSERT INTO tbljaminanshm 
        (noshm, atasnama, saksi1, saksi2, saksi3, hari, idpinjam) 
        VALUES('{noSHM}', '{atasNama}', '{saksi1}', '{saksi2}', '{saksi3}', '{hari}', '{idpinjam}');"

        exc(sqlJaminan)

        resetJaminanSHM()

    End Sub

    Sub simpanJaminanBPKB(idpinjam As String)
        Dim jenisKendaraan As String = cbJenis.Text
        Dim noBPKB As String = tbBPKB.Text
        Dim noMesin As String = tbNoMesin.Text
        Dim noRangka As String = tbNoRangka.Text
        Dim noPolisi As String = tbNoPol.Text
        Dim namaPemilik As String = tbPemilik.Text
        Dim alamatPemilik As String = tbAlamatPemilik.Text
        Dim merk As String = tbMerk.Text
        Dim tglAkhirSTNK As String = dtStnk.Value.ToString("yyyy-MM-dd")
        Dim warna As String = tbWarna.Text
        Dim tahun As String = tbTahun.Text
        Dim besarCc As String = tbCC.Text
        Dim maxKredit As String = unnumberFormat(tbMaksKredit.Text)

        Dim sqlJaminan As String = $"INSERT INTO tbljaminankendaraan 
        (jeniskendaraan, nopol, merk, nobpkb, nomesin, norangka, tglstnk, warna, 
        besarcc, tahunbuat, pemilik, alamatpemilik, maxkredit, idpinjam) 
        VALUES('{jenisKendaraan}','{noPolisi}','{merk}','{noBPKB}','{noMesin}','{noRangka}','{tglAkhirSTNK}','{warna}','{besarCc}','{tahun}','{namaPemilik}','{alamat}','{maxKredit}','{idpinjam}');"

        exc(sqlJaminan)


        resetJaminanBPKB()

    End Sub



    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click

        If adaKosong(group_informasi_nasabah) Then
            dialogError("Pilih data nasabah terlebih dahulu !")
            Return
        ElseIf Not Double.TryParse(txt_bunga.Text, 0) Then
            dialogError("Masukan bunga dengan benar")
            Return
        ElseIf Not Double.TryParse(tbDenda.Text, 0) Then
            dialogError("Masukan denda dengan benar")
            Return
        ElseIf toDouble(tbDenda.Text) > 100 Or toDouble(tbDenda.Text) < 0 Then
            dialogError("Masukan denda dengan benar")
            Return
        ElseIf txt_besar_pinjam.Text = "0" Or txt_lama_pinjam.Text = "0" Or txt_bunga.Text = "0" Then
            dialogError("Lengkapi form data peminjmanan nasabah terlebih dahulu !")
            Return
        ElseIf adaKosong(group_informasi_peminjaman) Then
            dialogError("Lengkapi form data peminjaman nasabah terlebih dahulu !")
            Return
        ElseIf txt_jumlah_diterima.Text < 0 Then
            dialogError("Harap cek kembali transaksi anda !")
            Return

        Else
            Dim kodeAnggota As String = txt_kode_nasabah.Text
            Dim kodePinjam As String = txt_kode_pinjam.Text
            Dim jenisPinjam As String = cmb_JenisBunga.Text
            Dim tglPinjam As String = dtp_tanggal_pinjam.Value
            Dim besarPinjam As String = unnumberFormat(txt_besar_pinjam.Text)
            Dim lamaPinjam As String = txt_lama_pinjam.Text
            Dim persenBunga As String = txt_bunga.Text.Replace(",", ".")
            Dim asuransi As String = unnumberFormat(txt_asuransi.Text)
            Dim administrasi As String = unnumberFormat(txt_administrasi.Text)
            Dim diterima As String = unnumberFormat(txt_jumlah_diterima.Text)

            Dim angsuranPokok As String = unnumberformat(txt_angsuran_pokok.Text)
            Dim angsuranBunga As String = unnumberformat(txt_angsuran_bunga.Text)
            Dim jumAngsuran As String = unnumberFormat(txt_jumlah_angsuran.Text)
            Dim dendaPersen As String = tbDenda.Text.Replace(",", ".")
            Dim generate As String = If(cbGenerate.Checked, "1", "0")
            If dialog("Apakah yakin untuk membuat pinjaman ?") Then
                If getCount("select idpinjam from tblpinjam where idpinjam = '" & kodePinjam & "' ") = 0 Then
                    If exc("insert into tblpinjam 
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
                            flagpostingpinjam,
                            flaggenerated,
                            dendapersen
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
                            0,
                            '" & generate & "',
                            '" & dendaPersen & "'
                        )
                    ") Then
                        simpanJaminan(kodePinjam)
                        generateTagihan(kodePinjam)
                    End If
                    dialogInfo("Input sukses")

                Else
                    dialogError("Ada duplikasi kode pinjam !")
                End If
            End If
            lockForm()
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

    Private Sub txt_bunga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bunga.KeyPress, tbDenda.KeyPress
        onlyNumberWithComma(e)
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

        txt_kode_pinjam.Text = Now.ToString("yyyyMMddHHmmss")

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        openForm()


        clearForm(group_informasi_nasabah)
        clearForm(group_informasi_peminjaman)
        tbDenda.Text = "0"
        If btn_tambah.Enabled = False Then
            dgv_data_peminjaman.Enabled = True
            btn_cetak_kwitansi.Enabled = False
        Else
            dgv_data_peminjaman.Enabled = True
            btn_cetak_kwitansi.Enabled = False
        End If

        If String.IsNullOrEmpty(txt_kode_pinjam.Text) Then
            txt_kode_pinjam.Text = Now.ToString("yyyyMMddHHmmss")
        End If
    End Sub

    Private Sub btn_cetak_kwitansi_Click(sender As Object, e As EventArgs) Handles btn_cetak_kwitansi.Click
        PreviewFormPinjam.idpinjam = dgv_data_peminjaman.Rows(dgv_data_peminjaman.CurrentCell.RowIndex).Cells(0).Value.ToString
        PreviewFormPinjam.ShowDialog()


    End Sub

    Private Sub dgv_data_peminjaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_data_peminjaman.CellClick
        If btn_tambah.Enabled = True Then
            If (e.RowIndex >= 0) Then
                selectKodePinjam = dgv_data_peminjaman.Rows(e.RowIndex).Cells(0).Value
                idpinjam = selectKodePinjam

                kondisiBtnCetak()

                Me.txt_kode_nasabah.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(1).Value
                Me.txt_nama.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(2).Value
                Me.txt_alamat.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(14).Value

                Me.txt_kode_pinjam.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(0).Value
                Me.dtp_tanggal_pinjam.Value = dgv_data_peminjaman.Rows(e.RowIndex).Cells(4).Value
                Me.cmb_JenisBunga.SelectedItem = dgv_data_peminjaman.Rows(e.RowIndex).Cells(3).Value
                Me.txt_besar_pinjam.Text = numberFormat(dgv_data_peminjaman.Rows(e.RowIndex).Cells(5).Value)
                Me.txt_lama_pinjam.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(6).Value
                Me.txt_bunga.Text = dgv_data_peminjaman.Rows(e.RowIndex).Cells(7).Value
                Me.txt_asuransi.Text = numberFormat(dgv_data_peminjaman.Rows(e.RowIndex).Cells(8).Value)
                Me.txt_administrasi.Text = numberFormat(dgv_data_peminjaman.Rows(e.RowIndex).Cells(9).Value)
                Me.txt_jumlah_diterima.Text = numberFormat(dgv_data_peminjaman.Rows(e.RowIndex).Cells(10).Value)

                Me.txt_angsuran_pokok.Text = numberFormat(dgv_data_peminjaman.Rows(e.RowIndex).Cells(11).Value)
                Me.txt_angsuran_bunga.Text = numberFormat(dgv_data_peminjaman.Rows(e.RowIndex).Cells(12).Value)
                Me.txt_jumlah_angsuran.Text = numberFormat(dgv_data_peminjaman.Rows(e.RowIndex).Cells(13).Value)

                Me.tbDenda.Text = (dgv_data_peminjaman.Rows(e.RowIndex).Cells(15).Value)
                kondisiBtnHapus()
            End If
        Else
            btn_cetak_kwitansi.Enabled = False
        End If

    End Sub

    Dim checkJual2 As Boolean = True
    Private Sub TBJual2_TextChanged(sender As Object, e As EventArgs) Handles txt_administrasi.TextChanged, txt_besar_pinjam.TextChanged, txt_asuransi.TextChanged, tbMaksKredit.TextChanged
        Try
            If checkJual2 Then
                checkJual2 = False
                sender.Text = numberFormat(unnumberFormat(sender.Text))
                sender.SelectionStart = Len(sender.text)
                sender.SelectionLength = 0
                checkJual2 = True
            End If
        Catch ex As Exception
            checkJual2 = True
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSuratPerjanjian.Click
        PreviewSuratPerjanjian.idpinjam = dgv_data_peminjaman.Rows(dgv_data_peminjaman.CurrentCell.RowIndex).Cells(0).Value.ToString
        PreviewSuratPerjanjian.ShowDialog()
        PreviewSuratPerjanjian.Dispose()
    End Sub

    Private Sub btnShm_Click(sender As Object, e As EventArgs) Handles btnShm.Click
        PreviewSuratPerjanjianSHM.idpinjam = dgv_data_peminjaman.Rows(dgv_data_peminjaman.CurrentCell.RowIndex).Cells(0).Value.ToString
        PreviewSuratPerjanjianSHM.ShowDialog()
        PreviewSuratPerjanjianSHM.Dispose()
    End Sub

    Private Sub btnBPKB_Click(sender As Object, e As EventArgs) Handles btnBPKB.Click
        PreviewSuratPerjanjianBPKB.idpinjam = dgv_data_peminjaman.Rows(dgv_data_peminjaman.CurrentCell.RowIndex).Cells(0).Value.ToString
        PreviewSuratPerjanjianBPKB.ShowDialog()
        PreviewSuratPerjanjianBPKB.Dispose()
    End Sub

    Private Sub btnAngsuran_Click(sender As Object, e As EventArgs) Handles btnAngsuran.Click
        Dim idpinjam = dgv_data_peminjaman.Rows(dgv_data_peminjaman.CurrentCell.RowIndex).Cells(0).Value.ToString
        Dim sql = "select jenis from tblpinjam where idpinjam ='" & idpinjam & "'"

        Dim dataTagihan As New DataTable
        Select Case getValue(sql, "jenis")
            Case "FLAT"
                dataTagihan = tagihanFlat(idpinjam)
            Case "EFEKTIF"
                dataTagihan = tagihanEfektif(idpinjam)
            Case "ANUITAS"
                dataTagihan = tagihanAnuitas(idpinjam)
        End Select
        PreviewSuratAngsuran.tagihan = dataTagihan
        PreviewSuratAngsuran.idpinjam = idpinjam
        PreviewSuratAngsuran.ShowDialog()
        PreviewSuratAngsuran.Dispose()
    End Sub
End Class