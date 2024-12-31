Imports Telerik.WinControls.UI

Public Class ClsFieldsVisibleSetting
    Public bShowSalesOrdersColUsername As Boolean
    Public bShowPurchasesOrdersColUsername As Boolean

    Public Sub LoadCheckListFieldSetting(ByRef checkList As RadCheckedListBox)
        checkList.Items.Clear()
        Dim list As New List(Of FieldVisibleItem)
        list.Add(New FieldVisibleItem("Username", bShowSalesOrdersColUsername, "bShowSalesOrdersColUsername"))
        list.Add(New FieldVisibleItem("Username", bShowPurchasesOrdersColUsername, "bShowPurchasesOrdersColUsername"))
        'checkList.BeginInit()
        checkList.Items.Add(New ListViewDataItem("Username"))
        checkList.DisplayMember = "Text"
        checkList.CheckedMember = "Value"
        checkList.ValueMember = "Value"
        'checkList.EndInit()
    End Sub
End Class
Public Class FieldVisibleItem
    Public Value As Boolean
    Public Text As String
    Public Field As String

    Sub New(text As String, value As Boolean, field As String)
        Me.Value = value
        Me.Text = text
        Me.Field = field
    End Sub

End Class