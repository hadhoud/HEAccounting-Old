Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.UI

Public Class CustomItemNameTextBoxControl
    Inherits RadTextBoxControl

    Protected Overrides Function CreateTextBoxElement() As RadTextBoxControlElement
        Return New CustomTextBoxControlElement()
    End Function

    Protected Overrides Sub CreateChildItems(parent As RadElement)
        MyBase.CreateChildItems(parent)
        Dim button As New RadButtonElement()
        AddHandler button.Click, AddressOf button_Click
        button.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
        button.Image = Global.HEHAccounting.My.Resources.Resources.find
        button.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        button.FitToSizeMode = RadFitToSizeMode.FitToParentContent
        button.SmallImage = Global.HEHAccounting.My.Resources.Resources.find
        button.Text = ""
        button.UseCompatibleTextRendering = False

        Dim stackPanel As New StackLayoutElement()
        stackPanel.Orientation = Orientation.Horizontal
        stackPanel.Alignment = ContentAlignment.MiddleCenter
        stackPanel.FitToSizeMode = RadFitToSizeMode.FitToParentContent
        stackPanel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        stackPanel.BackColor = Color.Transparent
        stackPanel.Children.Add(button)

        Dim tbItem As RadTextBoxControlElement = Me.TextBoxElement
        Me.RootElement.Children.Remove(tbItem)

        Dim dockPanel As New DockLayoutPanel()
        dockPanel.Children.Add(stackPanel)
        dockPanel.Children.Add(tbItem)
        DockLayoutPanel.SetDock(tbItem, Telerik.WinControls.Layouts.Dock.Right)
        DockLayoutPanel.SetDock(stackPanel, Telerik.WinControls.Layouts.Dock.Left)
        Me.RootElement.Children.Add(dockPanel)
        Me.TextBoxElement.AutoCompleteDropDown.HorizontalAlignmentCorrectionMode = AlignmentCorrectionMode.SnapToOuterEdges
        Me.TextBoxElement.AutoCompleteDropDown.HorizontalPopupAlignment = HorizontalPopupAlignment.RightToRight
    End Sub

    Public Sub button_Click(sender As Object, e As EventArgs)
        Dim FrmGetItem As New ItemsPopup
        FrmGetItem.ShowDialog()

        If Not FrmGetItem.GetITemName.Length = 0 Then
            Me.Text = FrmGetItem.GetITemName
        End If
    End Sub
End Class

Public Class CustomTextBoxControlElement
    Inherits RadTextBoxControlElement

    Protected Overrides ReadOnly Property ThemeEffectiveType As Type
        Get
            Return GetType(RadTextBoxControlElement)
        End Get
    End Property


    Protected Overrides Function CreateListElement() As RadTextBoxListElement
        Return New CustomTextBoxListElement()
    End Function
End Class

Public Class CustomTextBoxListElement
    Inherits RadTextBoxListElement

    Protected Overrides Function AutoCompleteFilterOverride(ByVal item As RadListDataItem) As Boolean
        Dim itemText As String = (If(item.Text, String.Empty)).ToUpperInvariant()
        Return itemText.Contains(Me.PatternText.ToUpperInvariant())
    End Function
End Class
