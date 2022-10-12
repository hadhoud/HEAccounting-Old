<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShowReport
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShowReport))
        Me.RptViewer = New Telerik.ReportViewer.WinForms.ReportViewer()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RptViewer
        '
        Me.RptViewer.AccessibilityKeyMap = Nothing
        Me.RptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RptViewer.Location = New System.Drawing.Point(0, 0)
        Me.RptViewer.Name = "RptViewer"
        Me.RptViewer.ReportEngineConnection = ""
        Me.RptViewer.ShowDocumentMapButton = False
        Me.RptViewer.ShowHistoryButtons = False
        Me.RptViewer.ShowPageSetupButton = False
        Me.RptViewer.ShowParametersButton = False
        Me.RptViewer.ShowSearchButton = False
        Me.RptViewer.ShowStopButton = False
        Me.RptViewer.Size = New System.Drawing.Size(694, 446)
        Me.RptViewer.TabIndex = 0
        '
        'ShowReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 446)
        Me.Controls.Add(Me.RptViewer)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShowReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إظهار التقرير"
        Me.ThemeName = "Office2010Blue"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RptViewer As Telerik.ReportViewer.WinForms.ReportViewer
End Class

