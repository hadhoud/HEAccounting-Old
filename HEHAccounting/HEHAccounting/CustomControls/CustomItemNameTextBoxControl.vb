Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts
Imports Telerik.WinControls.Paint
Imports Telerik.WinControls.Primitives
Imports Telerik.WinControls.TextPrimitiveUtils
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.ValueMapper

Public Class CustomItemNameTextBoxControl
    Inherits RadTextBoxControl

    Public Overrides Property ThemeClassName As String
        Get
            Return GetType(RadTextBoxControl).FullName
        End Get
        Set(value As String)
            MyBase.ThemeClassName = value
        End Set
    End Property

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
        button.UseCompatibleTextRendering = True

        Dim stackPanel As New StackLayoutElement()
        stackPanel.Orientation = Orientation.Horizontal
        stackPanel.Alignment = ContentAlignment.MiddleCenter
        stackPanel.FitToSizeMode = RadFitToSizeMode.FitToParentContent
        stackPanel.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        stackPanel.BackColor = Color.Transparent
        stackPanel.Children.Add(button)

        Dim tbItem As RadTextBoxControlElement = Me.TextBoxElement
        'Dim tbItem As RadTextBoxItem = Me.RadTextBox1.TextBoxElement.TextBoxItem
        Me.RootElement.Children.Remove(tbItem)

        Dim dockPanel As New DockLayoutPanel()
        dockPanel.Alignment = ContentAlignment.MiddleCenter
        dockPanel.UseCompatibleTextRendering = False
        dockPanel.Children.Add(stackPanel)
        dockPanel.Children.Add(tbItem)
        If BoolLTRLanguage Then
            DockLayoutPanel.SetDock(tbItem, Telerik.WinControls.Layouts.Dock.Left)
            DockLayoutPanel.SetDock(stackPanel, Telerik.WinControls.Layouts.Dock.Right)
        Else
            DockLayoutPanel.SetDock(tbItem, Telerik.WinControls.Layouts.Dock.Right)
            DockLayoutPanel.SetDock(stackPanel, Telerik.WinControls.Layouts.Dock.Left)
        End If
        Me.RootElement.Children.Add(dockPanel)
        tbItem.ViewElement.RightToLeft = True
        Me.TextBoxElement.DrawText = False
        Me.TextBoxElement.AutoCompleteDropDown.HorizontalAlignmentCorrectionMode = AlignmentCorrectionMode.SnapToOuterEdges
        Me.TextBoxElement.AutoCompleteDropDown.HorizontalPopupAlignment = HorizontalPopupAlignment.RightToRight

    End Sub

    Public Sub button_Click(sender As Object, e As EventArgs)

        Select Case Me.Tag

            Case FormPopupType.FrmGetItem
                Dim FrmGetItem As New ItemsPopup
                FrmGetItem.ShowDialog()
                If Not FrmGetItem.GetITemName.Length = 0 Then
                    Me.Text = FrmGetItem.GetITemName
                End If

            Case FormPopupType.FrmGetVendors
                Dim FrmGetVendors As New VendorsPopup
                FrmGetVendors.ShowDialog()
                If Not FrmGetVendors.GetVendorName.Length = 0 Then
                    Me.Text = FrmGetVendors.GetVendorName
                End If

            Case FormPopupType.FrmGetCustomers
                Dim FrmGetCustomer As New CustomerPopup
                FrmGetCustomer.ShowDialog()
                If Not FrmGetCustomer.GetCustomerName.Length = 0 Then
                    Me.Text = FrmGetCustomer.GetCustomerName
                End If

            Case FormPopupType.FrmGetVendorsCustomers
                Dim FrmGetVendorsCustomers As New VendorsCustomersPopup
                FrmGetVendorsCustomers.ShowDialog()
                If Not FrmGetVendorsCustomers.GetVendorCustomerName.Length = 0 Then
                    Me.Text = FrmGetVendorsCustomers.GetVendorCustomerName
                End If
        End Select
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
