Imports System.ComponentModel.DataAnnotations
Imports System.Drawing.Printing
Imports System.Globalization
Imports Telerik.Reporting
Imports Telerik.Reporting.Processing
Imports Telerik.WinControls.UI

Public Class ShowReport

    Public RptName As String
    Public AllParamter As Telerik.Reporting.Parameter()

    Private ReadOnly MInstanceReport As InstanceReportSource = New InstanceReportSource()
    Private ReadOnly MReportBook As ReportBook = New ReportBook()
    Private ReadOnly MUriReportSource As UriReportSource = New UriReportSource()


    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
    End Sub
    Sub AddSources()
        MUriReportSource.Uri = Application.StartupPath.ToString & "\Reports\" & RptName & ".trdp"
        MReportBook.ReportSources.Add(MUriReportSource)

        MInstanceReport.ReportDocument = MReportBook
        Me.RptViewer.ReportSource = MInstanceReport
        Me.RptViewer.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
        Me.RptViewer.ShowPrintPreviewButton = False
    End Sub
    Public Sub AddParameters()
        For Each Par In AllParamter
            MInstanceReport.Parameters.Add(Par)
        Next
    End Sub
    Public Sub RefrechReport()
        RptViewer.RefreshReport()
    End Sub

    Public Sub PrintReport()
        AddSources()
        AddParameters()
        ' RefrechReport()
        Dim processor As ReportProcessor = New ReportProcessor()
        Dim Controller As System.Drawing.Printing.PrintController = New System.Drawing.Printing.StandardPrintController()
        processor.PrintController = Controller
        Dim printerSettings As System.Drawing.Printing.PrinterSettings = New System.Drawing.Printing.PrinterSettings()

        printerSettings.PrinterName = "GP-80160(Cut) Series"
        printerSettings.Copies = 1
        printerSettings.Collate = False
        'Dim repSource As Telerik.Reporting.InstanceReportSource = MInstanceReport

        Dim culture = New CultureInfo("ar-LB")
        If BoolLTRLanguage = True Then
            culture.NumberFormat.CurrencySymbol = "L.L"
        Else
            culture.NumberFormat.CurrencySymbol = "ل.ل"
        End If



        processor.PrintReport(MInstanceReport, printerSettings)
        'Me.RptViewer.PrintReport()
    End Sub
    Private Sub ShowReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddSources()
        AddParameters()
        RefrechReport()
        'Dim typeReportSource = New Telerik.Reporting.TypeReportSource()
        'typeReportSource.TypeName = "HEHAccounting.SalesOrders, HEHAccounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
        'Me.RptViewer.ReportSource = typeReportSource
        'RptViewer.RefreshReport()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.RptViewer.PrintReport()
    End Sub
End Class
