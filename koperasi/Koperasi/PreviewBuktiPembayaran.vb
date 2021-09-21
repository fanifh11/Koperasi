Public Class PreviewBuktiPembayaran

    Public idtagihan As String = ""

    Private Sub PreviewBuktiPembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select idanggota, anggota, besarbayar, besarpokok, besarbunga, idtagihan, to_char(tglbayar, 'DD-MM-YYYY') as tglbayar, cicilanke, besarpinjam, saldopinjam from qtagihan where idtagihan = '" & idtagihan & "'"
        Dim sqlidentitas As String = "select * from tblidentitas where idkoperasi = 1"
        Dim t As New Terbilang()
        t.Text = getValue(sql, "besarbayar").ToString

        ReportViewer1.Reset()
ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
Me.WindowState = FormWindowState.Maximized

        ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.BuktiPembayaran.rdlc"

        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", CType(getData(sql), DataTable)))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kodeanggota", getValue(sql, "idanggota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namaanggota", getValue(sql, "anggota").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("terbilang", t.Text))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("kodebayar", getValue(sql, "idtagihan").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("tanggalbayar", getValue(sql, "tglbayar").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("opr", "admin"))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("namakoperasi", getValue(sqlidentitas, "namakoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("alamatkoperasi", getValue(sqlidentitas, "alamatkoperasi").ToString))
        ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("bendahara", getValue(sqlidentitas, "bendahara").ToString))
        ReportViewer1.RefreshReport()
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)


    End Sub
End Class