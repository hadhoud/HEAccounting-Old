Imports System.ComponentModel

Public Class DashboardItem
    Private _panelBodyColor1 As Color = Color.FromArgb(124, 185, 232)
    Private _panelBodyColor2 As Color = Color.FromArgb(49, 140, 231)
    Private _headerText As String = "Header"
    Private _contentFirstText As String = "FirstContent"
    Private _headerTextFont As Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Private _contentFirstTextFont As Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Private _headerTextColor As Color = Color.Black
    Private _contentFirstTextColor As Color = Color.Black
    Private _imageItem As Image
    Private _contentGradientAngle As Decimal = 100.0!

    Public Property HEImage() As Image
        Get
            Return _imageItem
        End Get
        Set(ByVal value As Image)
            _imageItem = value
            imgItem.Image = _imageItem
        End Set
    End Property

    Public Property HEBackColor1() As Color
        Get
            Return _panelBodyColor1
        End Get
        Set(ByVal value As Color)
            _panelBodyColor1 = value
            CType(Me.ContentPanel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = _panelBodyColor1
        End Set
    End Property

    Public Property HEBackColor2() As Color
        Get
            Return _panelBodyColor2
        End Get
        Set(ByVal value As Color)
            _panelBodyColor2 = value
            CType(Me.ContentPanel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = _panelBodyColor2
        End Set
    End Property

    Public Property HeaderTextColor() As Color
        Get
            Return _headerTextColor
        End Get
        Set(ByVal value As Color)
            _headerTextColor = value
            lblHeader.ForeColor = _headerTextColor
        End Set
    End Property

    Public Property HeaderText() As String
        Get
            Return _headerText
        End Get
        Set(ByVal value As String)
            _headerText = value
            lblHeader.Text = _headerText
        End Set
    End Property

    Public Property HeaderTextFont() As Font
        Get
            Return _headerTextFont
        End Get
        Set(ByVal value As Font)
            _headerTextFont = value
            lblHeader.Font = _headerTextFont
        End Set
    End Property
    Public Property HEFirstText() As String
        Get
            Return _contentFirstText
        End Get
        Set(ByVal value As String)
            _contentFirstText = value
            lblFirstText.Text = _contentFirstText
        End Set
    End Property

    Public Property HEFirstTextFont() As Font
        Get
            Return _contentFirstTextFont
        End Get
        Set(ByVal value As Font)
            _contentFirstTextFont = value
            lblFirstText.Font = _contentFirstTextFont
        End Set

    End Property
    Public Property HEFirstTextColor() As Color
        Get
            Return _contentFirstTextColor
        End Get
        Set(ByVal value As Color)
            _contentFirstTextColor = value
            lblFirstText.ForeColor = _contentFirstTextColor
        End Set

    End Property

    Public Property HEGradientAngle() As Decimal
        Get
            Return _contentGradientAngle
        End Get
        Set(ByVal value As Decimal)
            _contentGradientAngle = value
            CType(Me.ContentPanel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).GradientAngle = _contentGradientAngle
        End Set
    End Property

End Class