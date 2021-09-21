Public Class PreviewFormPinjam

    Public idpinjam As String = ""

    Private Sub PreviewFormPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select idpinjam, besarpinjam, jumlahangsuran, diterima, asuransi, administrasi, idanggota, 
        anggota, jenisanggota, jk, tempatlahir, to_char(tanggallahir, 'DD-MM-YYYY') as tanggallahir, noktp, alamat, notelp, pekerjaan, status, namasaudara, 
        hpsaudara, to_char(tahunmasuk, 'DD-MM-YYYY') as tahunmasuk from qpinjam where idpinjam = '" & idpinjam & "'"
        Dim sqlidentitas As String = "select * from tblidentitas where idkoperasi = 1"
        Dim t As New Terbilang()
        t.Text = getValue(sql, "besarpinjam").ToString
        ReportViewer1.Reset()
ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
Me.WindowState = FormWindowState.Maximized
        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.CetakKwitansiPinjaman.rdlc"
        addLogoRDLC(ReportViewer1)
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CType(getData(sql), DataTable)))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kodepinjam", getValue(sql, "idpinjam").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("banyaknyauang", t.Text))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("opr", "admin"))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kode", getValue(sql, "idanggota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("nama", getValue(sql, "anggota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("jenisnasabah", getValue(sql, "jenisanggota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("jeniskelamin", getValue(sql, "jk").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("tempatlahir", getValue(sql, "tempatlahir").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("tanggallahir", getValue(sql, "tanggallahir").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("noktp", getValue(sql, "noktp").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("alamat", getValue(sql, "alamat").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("telp", getValue(sql, "notelp").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("pekerjaan", getValue(sql, "pekerjaan").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("status", getValue(sql, "status").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namasaudara", getValue(sql, "namasaudara").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("telpsaudara", getValue(sql, "hpsaudara").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("tanggaldaftar", getValue(sql, "tahunmasuk").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namakoperasi", getValue(sqlidentitas, "namakoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("alamatkoperasi", getValue(sqlidentitas, "alamatkoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kota", getValue(sqlidentitas, "kota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("notelp", getValue(sqlidentitas, "notelp").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("bendahara", getValue(sqlidentitas, "bendahara").ToString))
        ReportViewer1.RefreshReport()
    End Sub
End Class