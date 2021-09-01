Imports System.Globalization


Public Class FormIsiSimpananSukarela

    Public idsukarela As String
    Public bunga As Double
    Public saldoAsli As Double


    Sub startState()
        group_DataAnggota.Enabled = True
        grupBtn.Enabled = True
        group_InformasiAnggota.Enabled = False
        lbl_Saldo.Enabled = False

    End Sub
    Sub bukaForm()
        group_DataAnggota.Enabled = False
        group_InformasiAnggota.Enabled = True
        grupBtn.Enabled = False
        lbl_Saldo.Enabled = True

        clearForm(group_InformasiAnggota)
    End Sub

    Public Sub getBungaAndSaldo()

        Dim culuture As CultureInfo = CultureInfo.GetCultureInfo("id-ID")

        Dim sql As String =
            "select DATE_PART('day', now() - 
            (SELECT tbltransaksi.tgltransaksi from tbltransaksi where idsukarela = '" & idsukarela & "' order by idtransaksi desc limit 1)), 
            (SELECT tbltransaksi.saldo from tbltransaksi where idsukarela = '" & idsukarela & "' order by idtransaksi desc limit 1) saldo  "

        Dim saldo As String = getValue(sql, "saldo")
        Dim totalHari = 0

        If String.IsNullOrEmpty(saldo) Then
            saldo = "0"
        Else
            totalHari = Double.Parse(getValue(sql, "date_part"))
        End If

        lbl_Saldo.Text = numberFor(saldo)
        saldoAsli = saldo

        txt_Bunga.Text = Math.Round((((Double.Parse(saldo) * bunga) / 30) * totalHari))

    End Sub

    Sub kunciForm()
        group_DataAnggota.Enabled = True
        group_InformasiAnggota.Enabled = False
        grupBtn.Enabled = True
        lbl_Saldo.Enabled = False

        clearForm(group_InformasiAnggota)
    End Sub

    Sub showData()
        dgv_DataAnggota.DataSource = getData("select tgltransaksi,idanggota,anggota,kettransaksi,debet,kredit,saldo from qtransaksi")
        dgv_DataAnggota.Columns(0).HeaderText = "Tanggal Transaksi"
        dgv_DataAnggota.Columns(1).HeaderText = "ID Anggota"
        dgv_DataAnggota.Columns(2).HeaderText = "Nama Anggota"
        dgv_DataAnggota.Columns(3).HeaderText = "Keterangan Transaksi"
        dgv_DataAnggota.Columns(4).HeaderText = "Debet"
        dgv_DataAnggota.Columns(5).HeaderText = "Kredit"
        dgv_DataAnggota.Columns(6).HeaderText = "Saldo"

        dgv_DataAnggota.Columns(4).DefaultCellStyle.Format = "c0"
        dgv_DataAnggota.Columns(5).DefaultCellStyle.Format = "c0"
        dgv_DataAnggota.Columns(6).DefaultCellStyle.Format = "c0"

        lbl_JumData.Text = "Jumlah data : " & dgv_DataAnggota.Rows.Count
    End Sub

    Private Sub btn_Keluar_Click(sender As Object, e As EventArgs) Handles btn_Keluar.Click
        Me.Close()
    End Sub

    Private Sub FormIsiSimpananSukarela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startState()
        showData()

    End Sub

    Private Sub btn_Tambah_Click(sender As Object, e As EventArgs) Handles btn_Tambah.Click
        bukaForm()
    End Sub

    Private Sub btn_Bayar_Click(sender As Object, e As EventArgs) Handles btn_Bayar.Click

        If String.IsNullOrEmpty(txt_BesarSimpanan.Text) Then
            dialogError("Isi dulu isian pembayarannya!")
            lbl_Saldo.Text = 0
        Else
            Dim kodeAnggota As String = txt_KodeAnggota.Text
            Dim namaAnggota As String = txt_Nama.Text
            Dim ketTransaksi As String = txt_JenisSimpanan.Text
            Dim tglTransaksi As String = dtp_TglSimpanan.Value.ToString("yyyy-MM-dd")

            Dim besarSimpan As String = txt_BesarSimpanan.Text
            Dim bunga As String = txt_Bunga.Text
            Dim nocetak As Integer = getCount("select * from tbltransaksi where idsukarela = '" & idsukarela & "' ") + 1
            Dim ketkode As String = getValue("select ketjenis from tbljenis where jenissimpanan = '" & ketTransaksi & "' ", "ketjenis")

            If dialog("Apakah data yang anda masukkan sudah benar?") Then
                Dim faktur As String = Now.ToString("yyyyMMddHHmmss")
                Dim saldoAwal = saldoAsli + Double.Parse(besarSimpan)

                lbl_Saldo.Text = 0

                exc("insert into tbltransaksi 
                    (
                        fakturtransaksi,
                        idsukarela,
                        debet,
                        kredit,
                        tgltransaksi,
                        kettransaksi,
                        fb,
                        nocetak,
                        saldo,
                        ketkode,
                        flagpostingtransaksi
                    )values
                    (
                        '" & faktur & "',
                        '" & idsukarela & "',
                        0,
                        '" & besarSimpan & "',
                        '" & tglTransaksi & "',
                        '" & ketTransaksi & "',
                        0,
                        '" & nocetak & "',
                        '" & saldoAwal & "',
                        '" & ketkode & "',
                        0 
                    )
                    ")

                If bunga > 0 Then
                    Dim saldoAkhir = Double.Parse(bunga) + Double.Parse(saldoAwal)
                    Dim nocetakBunga = Double.Parse(nocetak) + 1

                    lbl_Saldo.Text = 0
                    exc("insert into tbltransaksi 
                    (
                        fakturtransaksi,
                        idsukarela,
                        debet,
                        kredit,
                        tgltransaksi,
                        kettransaksi,
                        fb,
                        nocetak,
                        saldo,
                        ketkode,
                        flagpostingtransaksi
                    )values
                    (
                        '" & faktur & "',
                        '" & idsukarela & "',
                        0,
                        '" & bunga & "',
                        '" & tglTransaksi & "',
                        'B',
                        0,
                        '" & nocetakBunga & "',
                        '" & saldoAkhir & "',
                        'B',
                        0 
                    )
                    ")
                End If
            End If
            dialogInfo("Pembayaran Sukses !")

        End If
        kunciForm()

    End Sub

    Private Sub btn_Batal_Click(sender As Object, e As EventArgs) Handles btn_Batal.Click
        kunciForm()
        lbl_Saldo.Text = "0"
    End Sub

    Private Sub btn_CariAnggota_Click(sender As Object, e As EventArgs) Handles btn_CariAnggota.Click

        Me.getBungaAndSaldo()


        FormCariAnggota.menu = "Isi simpanan sukarela"
        FormCariAnggota.ShowDialog()
        FormCariAnggota.Dispose()

    End Sub

    Private Sub txt_BesarSimpanan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BesarSimpanan.KeyPress
        onlyNumber(e)

    End Sub
End Class