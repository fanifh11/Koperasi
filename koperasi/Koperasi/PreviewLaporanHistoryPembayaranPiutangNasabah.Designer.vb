<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreviewLaporanHistoryPembayaranPiutangNasabah
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.QTagihanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.koperasiDataSet = New Koperasi.koperasiDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.QTagihanTableAdapter = New Koperasi.koperasiDataSetTableAdapters.QTagihanTableAdapter()
        CType(Me.QTagihanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.koperasiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QTagihanBindingSource
        '
        Me.QTagihanBindingSource.DataMember = "QTagihan"
        Me.QTagihanBindingSource.DataSource = Me.koperasiDataSet
        '
        'koperasiDataSet
        '
        Me.koperasiDataSet.DataSetName = "koperasiDataSet"
        Me.koperasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapWidth = 98
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.QTagihanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Koperasi.LaporanHistoryPembayaranPiutangNasabah.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(644, 461)
        Me.ReportViewer1.TabIndex = 0
        '
        'QTagihanTableAdapter
        '
        Me.QTagihanTableAdapter.ClearBeforeFill = True
        '
        'PreviewLaporanHistoryPembayaranPiutangNasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 461)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "PreviewLaporanHistoryPembayaranPiutangNasabah"
        Me.Text = "PreviewLaporanHistoryPembayaranPiutangNasabah"
        CType(Me.QTagihanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.koperasiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents QTagihanBindingSource As BindingSource
    Friend WithEvents koperasiDataSet As koperasiDataSet
    Friend WithEvents QTagihanTableAdapter As koperasiDataSetTableAdapters.QTagihanTableAdapter
End Class
