<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.imgItem = New Telerik.WinControls.UI.RadPictureBox()
        Me.lblFirstText = New Telerik.WinControls.UI.RadLabel()
        Me.lblHeader = New Telerik.WinControls.UI.RadLabel()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.ContentPanel = New Telerik.WinControls.UI.RadPanel()
        Me.RoundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.imgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblFirstText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContentPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContentPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'imgItem
        '
        Me.imgItem.BackColor = System.Drawing.Color.Transparent
        Me.imgItem.Dock = System.Windows.Forms.DockStyle.Left
        Me.imgItem.Image = Global.HEHAccounting.My.Resources.Resources.cost
        Me.imgItem.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.imgItem.ImageLayout = Telerik.WinControls.UI.RadImageLayout.FitIntoBounds
        Me.imgItem.Location = New System.Drawing.Point(0, 0)
        Me.imgItem.Name = "imgItem"
        Me.imgItem.Size = New System.Drawing.Size(61, 48)
        Me.imgItem.TabIndex = 2
        '
        'lblFirstText
        '
        Me.lblFirstText.AutoSize = False
        Me.lblFirstText.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFirstText.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstText.ForeColor = System.Drawing.Color.Black
        Me.lblFirstText.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFirstText.Location = New System.Drawing.Point(3, 51)
        Me.lblFirstText.Name = "lblFirstText"
        Me.lblFirstText.Size = New System.Drawing.Size(260, 55)
        Me.lblFirstText.TabIndex = 1
        Me.lblFirstText.Text = "qwe"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = False
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeader.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Black
        Me.lblHeader.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.lblHeader.Location = New System.Drawing.Point(61, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(199, 48)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "header"
        '
        'ContentPanel
        '
        Me.ContentPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ContentPanel.Controls.Add(Me.lblFirstText)
        Me.ContentPanel.Controls.Add(Me.Panel2)
        Me.ContentPanel.Location = New System.Drawing.Point(3, 3)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.ContentPanel.Size = New System.Drawing.Size(266, 109)
        Me.ContentPanel.TabIndex = 4
        CType(Me.ContentPanel.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = ""
        CType(Me.ContentPanel.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Padding = New System.Windows.Forms.Padding(3)
        CType(Me.ContentPanel.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Shape = Me.RoundRectShape1
        CType(Me.ContentPanel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.ContentPanel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 2
        CType(Me.ContentPanel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientStyle = Telerik.WinControls.GradientStyles.Linear
        CType(Me.ContentPanel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = 100.0!
        CType(Me.ContentPanel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage = 0.8!
        CType(Me.ContentPanel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientPercentage2 = 0.2!
        CType(Me.ContentPanel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(231, Byte), Integer))
        CType(Me.ContentPanel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.Transparent
        CType(Me.ContentPanel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
        CType(Me.ContentPanel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Enabled = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.lblHeader)
        Me.Panel2.Controls.Add(Me.imgItem)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 48)
        Me.Panel2.TabIndex = 4
        '
        'DashboardItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ContentPanel)
        Me.Name = "DashboardItem"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(272, 115)
        CType(Me.imgItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblFirstText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContentPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContentPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHeader As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblFirstText As Telerik.WinControls.UI.RadLabel
    Friend WithEvents imgItem As Telerik.WinControls.UI.RadPictureBox
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents ContentPanel As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RoundRectShape1 As Telerik.WinControls.RoundRectShape
    Friend WithEvents Panel2 As Panel
End Class
