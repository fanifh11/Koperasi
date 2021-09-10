Public Class FormKoreksiPinjamorPiutangNasabah

    Dim idpinjam As String
    Dim cekSeparator As Boolean = True
    Private Sub textChanged_moneySeparator(sender As Object, e As EventArgs) Handles txt_BesarPinjam.TextChanged, txt_Asuransi.TextChanged, txt_Administrasi.TextChanged, txt_UangDiterima.TextChanged,
            txt_AngsuranBunga.TextChanged, txt_AngsuranPokok.TextChanged, txt_JumAngsuran.TextChanged
        Try
            If cekSeparator Then
                cekSeparator = False
                sender.Text = numberFormat(unnumberFormat(sender.Text))
                sender.SelectionStart = Len(sender.text)
                sender.SelectionLength = 0
                cekSeparator = True
            End If
        Catch ex As Exception
            cekSeparator = True
        End Try

    End Sub


    Sub hitungAngsuranPokok()
        Dim besarPinjam As Double = toDouble(unnumberFormat(txt_BesarPinjam.Text))
        Dim lamaPinjam As Double = toDouble(txt_LamaPinjam.Text)

        txt_AngsuranPokok.Text = numberFormat(Math.Ceiling(besarPinjam / lamaPinjam)).ToString

        hitungJumlahAngsuran()
    End Sub

    Sub hitungBunga()
        Dim besarPinjam As Double = toDouble(unnumberFormat(txt_BesarPinjam.Text))
        Dim persenBunga As Double = toDouble(txt_Bunga.Text)

        txt_AngsuranBunga.Text = numberFormat(Math.Ceiling((besarPinjam * persenBunga) / 100)).ToString

        hitungJumlahAngsuran()

    End Sub

    Sub hitungJumlahAngsuran()
        Dim jumAngsuranPokok As Double = toDouble(unnumberFormat(txt_AngsuranPokok.Text))
        Dim jumAngsuranBunga As Double = toDouble(txt_AngsuranBunga.Text)

        txt_JumAngsuran.Text = numberFormat(Math.Ceiling(jumAngsuranBunga + jumAngsuranPokok)).ToString

    End Sub

    Sub jumlahUangDiterima()
        Dim besarPinjam As Double = toDouble(unnumberFormat(txt_BesarPinjam.Text))
        Dim biayaAsuransi As Double = toDouble(unnumberFormat(txt_Asuransi.Text))
        Dim biayaAdministrasi As Double = toDouble(unnumberFormat(txt_Administrasi.Text))

        txt_UangDiterima.Text = numberFormat(besarPinjam - (biayaAdministrasi + biayaAsuransi)).ToString

    End Sub

    Sub showData()
        dgv_DataPeminjaman.DataSource = getData("select distinct idanggota,anggota,alamat,jenis,idpinjam,tglpinjam,besarpinjam,lamapinjam,persenbunga,asuransi,administrasi,diterima,angsuranpokok,angsuranbunga,jumlahangsuran from qtagihan where flagtagihan = 1 and anggota ilike '%" & txt_CariData.Text & "%' and tglpinjam <= '" & dtp_Pinjam.Value.ToString("yyyyMMdd") & "' ")
        dgv_DataPeminjaman.Columns(0).HeaderText = "Kode Anggota"
        dgv_DataPeminjaman.Columns(1).HeaderText = "Nama"
        dgv_DataPeminjaman.Columns(2).Visible = False
        dgv_DataPeminjaman.Columns(3).HeaderText = "Jenis Pinjam"
        dgv_DataPeminjaman.Columns(4).HeaderText = "Kode Pinjam"
        dgv_DataPeminjaman.Columns(5).HeaderText = "Tanggal Pinjam"
        dgv_DataPeminjaman.Columns(6).HeaderText = "Besar Pinjam"
        dgv_DataPeminjaman.Columns(7).HeaderText = "Lama Pinjam"
        dgv_DataPeminjaman.Columns(8).HeaderText = "Persen Bunga"
        dgv_DataPeminjaman.Columns(9).HeaderText = "Asuransi"
        dgv_DataPeminjaman.Columns(10).HeaderText = "Administrasi"
        dgv_DataPeminjaman.Columns(11).HeaderText = "Uang Diterima"
        dgv_DataPeminjaman.Columns(12).HeaderText = "Angsuran Pokok"
        dgv_DataPeminjaman.Columns(13).HeaderText = "Angsuran Bunga"
        dgv_DataPeminjaman.Columns(14).HeaderText = "Jumlah Angsuran"

        dgv_DataPeminjaman.Columns(6).DefaultCellStyle.Format = "c0"
        dgv_DataPeminjaman.Columns(9).DefaultCellStyle.Format = "c0"
        dgv_DataPeminjaman.Columns(10).DefaultCellStyle.Format = "c0"
        dgv_DataPeminjaman.Columns(11).DefaultCellStyle.Format = "c0"
        dgv_DataPeminjaman.Columns(12).DefaultCellStyle.Format = "c0"
        dgv_DataPeminjaman.Columns(13).DefaultCellStyle.Format = "c0"
        dgv_DataPeminjaman.Columns(14).DefaultCellStyle.Format = "c0"

        lbl_JumData.Text = "Jumlah Data : " & dgv_DataPeminjaman.Rows.Count
    End Sub
    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormKoreksiPinjamorPiutangNasabah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showData()
        cmb_Jenis.SelectedIndex = 1

    End Sub

    Private Sub dgv_DataPeminjaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_DataPeminjaman.CellClick
        If e.RowIndex >= 0 Then

            Me.idpinjam = dgv_DataPeminjaman.Rows(e.RowIndex).Cells(4).Value

            Me.txt_KodeNasabah.Text = dgv_DataPeminjaman.Rows(e.RowIndex).Cells(0).Value
            Me.txt_Nama.Text = dgv_DataPeminjaman.Rows(e.RowIndex).Cells(1).Value
            Me.txt_Alamat.Text = dgv_DataPeminjaman.Rows(e.RowIndex).Cells(2).Value
            Me.cmb_Jenis.Text = dgv_DataPeminjaman.Rows(e.RowIndex).Cells(3).Value

            Me.txt_KodePinjam.Text = dgv_DataPeminjaman.Rows(e.RowIndex).Cells(4).Value
            Me.dtp_TglPinjam2.Value = dgv_DataPeminjaman.Rows(e.RowIndex).Cells(5).Value
            Me.txt_BesarPinjam.Text = numberFormat(dgv_DataPeminjaman.Rows(e.RowIndex).Cells(6).Value)
            Me.txt_LamaPinjam.Text = dgv_DataPeminjaman.Rows(e.RowIndex).Cells(7).Value
            Me.txt_Bunga.Text = dgv_DataPeminjaman.Rows(e.RowIndex).Cells(8).Value

            Me.txt_Asuransi.Text = numberFormat(dgv_DataPeminjaman.Rows(e.RowIndex).Cells(9).Value)
            Me.txt_Administrasi.Text = numberFormat(dgv_DataPeminjaman.Rows(e.RowIndex).Cells(10).Value)
            Me.txt_UangDiterima.Text = numberFormat(dgv_DataPeminjaman.Rows(e.RowIndex).Cells(11).Value)
            Me.txt_AngsuranPokok.Text = numberFormat(dgv_DataPeminjaman.Rows(e.RowIndex).Cells(12).Value)
            Me.txt_AngsuranBunga.Text = numberFormat(dgv_DataPeminjaman.Rows(e.RowIndex).Cells(13).Value)
            Me.txt_JumAngsuran.Text = numberFormat(dgv_DataPeminjaman.Rows(e.RowIndex).Cells(14).Value)


        End If
    End Sub

    Private Sub btn_Simpan_Click(sender As Object, e As EventArgs) Handles btn_Simpan.Click
        If Modul.adaKosong(group_InfoPeminjaman) Then
            dialogError("Form Isian Anda masih ada yang kosong, harap diisi dengan lengkap!")
        Else
            Dim kodeAnggota As String = txt_KodeNasabah.Text
            Dim kodePinjam As String = txt_KodePinjam.Text
            Dim jenisPinjam As String = cmb_Jenis.Text
            Dim tglPinjam As String = dtp_TglPinjam2.Value
            Dim besarPinjam As String = unnumberFormat(txt_BesarPinjam.Text)
            Dim lamaPinjam As String = txt_LamaPinjam.Text
            Dim persenBunga As String = txt_Bunga.Text
            Dim asuransi As String = unnumberFormat(txt_Asuransi.Text)
            Dim administrasi As String = unnumberFormat(txt_Administrasi.Text)
            Dim diterima As String = unnumberFormat(txt_UangDiterima.Text)

            Dim angsuranPokok As String = unnumberFormat(txt_AngsuranPokok.Text)
            Dim angsuranBunga As String = unnumberFormat(txt_AngsuranBunga.Text)
            Dim jumAngsuran As String = unnumberFormat(txt_JumAngsuran.Text)


            If dialog("Apakah yakin untuk mengubah data pinjaman ?") Then
                Debug.WriteLine("select idpinjam from tblpinjam where idpinjam != '" & kodePinjam & "' and idpinjam = '" & idpinjam & "'  ")
                If getCount("select idpinjam from tblpinjam where idpinjam != '" & kodePinjam & "'  and idpinjam = '" & idpinjam & "' ") = 0 Then

                    exc("delete from tbltagihan where idpinjam = '" & idpinjam & "' ")

                    exc("delete from tblpinjam where idpinjam = '" & idpinjam & "'  ")

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
            clearForm(group_InfoPeminjaman)
            clearForm(group_InfoNasabah)

        End If

    End Sub


    Private Sub txt_BesarPinjam_TextChanged(sender As Object, e As EventArgs) Handles txt_BesarPinjam.TextChanged
        hitungAngsuranPokok()
        hitungBunga()
        jumlahUangDiterima()

    End Sub

    Private Sub txt_LamaPinjam_TextChanged(sender As Object, e As EventArgs) Handles txt_LamaPinjam.TextChanged
        hitungAngsuranPokok()

    End Sub

    Private Sub txt_Bunga_TextChanged(sender As Object, e As EventArgs) Handles txt_Bunga.TextChanged
        hitungBunga()

    End Sub

    Private Sub txt_Asuransi_TextChanged(sender As Object, e As EventArgs) Handles txt_Asuransi.TextChanged
        jumlahUangDiterima()

    End Sub

    Private Sub txt_Administrasi_TextChanged(sender As Object, e As EventArgs) Handles txt_Administrasi.TextChanged
        jumlahUangDiterima()

    End Sub

    Private Sub txt_BesarPinjam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_LamaPinjam.KeyPress, txt_Bunga.KeyPress, txt_BesarPinjam.KeyPress, txt_Asuransi.KeyPress, txt_Administrasi.KeyPress
        onlyNumber(e)

    End Sub

    Private Sub txt_CariData_TextChanged(sender As Object, e As EventArgs) Handles txt_CariData.TextChanged
        showData()

    End Sub

    Private Sub btn_Batal_Click(sender As Object, e As EventArgs) Handles btn_Batal.Click
        clearForm(group_InfoNasabah)
        clearForm(group_InfoPeminjaman)
    End Sub

    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        showData()

    End Sub
End Class