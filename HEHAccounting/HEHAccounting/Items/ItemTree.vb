Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class ItemTree
  
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        Dim svc As RadDragDropService = Me.GridItemsGroups.GridViewElement.GetService(Of RadDragDropService)()
        AddHandler svc.PreviewDragStart, AddressOf Svc_PreviewDragStart
        AddHandler svc.PreviewDragDrop, AddressOf Svc_PreviewDragDrop
        AddHandler svc.PreviewDragOver, AddressOf Svc_PreviewDragOver
        Dim gridBehavior = TryCast(Me.GridItemsGroups.GridBehavior, BaseGridBehavior)
        gridBehavior.RegisterBehavior(GetType(GridViewDataRowInfo), New RowSelectionGridBehavior())

        FillTree()
    End Sub

    Private Sub Svc_PreviewDragStart(ByVal sender As Object, ByVal e As PreviewDragStartEventArgs)
        e.CanStart = True
    End Sub

    Private Sub Svc_PreviewDragOver(ByVal sender As Object, ByVal e As RadDragOverEventArgs)
        If TypeOf e.DragInstance Is GridDataRowElement Then
            e.CanDrop = TypeOf e.HitTarget Is GridDataRowElement OrElse
                     TypeOf e.HitTarget Is GridTableElement OrElse
                     TypeOf e.HitTarget Is GridSummaryRowElement OrElse
                     TypeOf e.HitTarget Is RadTreeViewElement OrElse
                      TypeOf e.HitTarget Is TreeNodeElement
        End If
    End Sub

    'gather drag/source grid and target/destination information and initiate the move of selected rows
    Private Sub Svc_PreviewDragDrop(ByVal sender As Object, ByVal e As RadDropEventArgs)
        Dim rowElement = TryCast(e.DragInstance, GridDataRowElement)
        If rowElement Is Nothing Then
            Return
        End If
        e.Handled = True
        Dim dropTarget = TryCast(e.HitTarget, RadItem)
        Dim targetGrid = TryCast(dropTarget, TreeNodeElement)
        If targetGrid Is Nothing Then
            Return
        End If
        e.Handled = True
        Me.TreeGroups.AutoScroll = True
        Dim GroupText As String = targetGrid.ContentElement.Text
        Dim ItemCode As String = rowElement.RowInfo.Cells(0).Value.ToString
        Dim ItemName As String = rowElement.RowInfo.Cells(1).Value.ToString
        Dim GroupId As String = Me.TreeGroups.Nodes.Item(GroupText).Value
        If GroupText = Con.Lbl_All Or GroupText = Me.TreeGroups.SelectedNode.Text.ToString Then
            MessageShowInfo(Con.Msg_You_Cannot_Move_This_Item_To_This_Group)
        Else
            If MessageShowAsk(Con.Ask_Are_You_Sure_You_Want_To_Move_Item & ItemName _
                              & Con.Ask_To_Group & GroupText & " )") = DialogResult.Yes Then
                Dim Param(1) As String
                Param(0) = "@IGroupID , " & GroupId
                Param(1) = "@IItemCode , " & ItemCode
                ExecuteProcedureWithParameters("UpdateGroupForItem", Param)
                Me.TreeGroups.Nodes.Item(GroupText).Selected = True
                RefrechGrid()
            End If
        End If
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        Me.Text = LoStrId.LblItems
    End Sub
    Public Sub RefrechGrid()
        Dim Param(0) As String
        Param(0) = "@IGroupID , " & Me.TreeGroups.SelectedNode.Value
        FillGridViewProcedureWithParameters(GridItemsGroups, "SelectItemsByGroups", Param)
    End Sub
    Public Sub FillTree()
        FillTreeProcedure(Me.TreeGroups, "SelectGroups")
        Dim itemNodeAll As New RadTreeNode With
        {
         .Text = Con.Lbl_All,
        .Value = "90909090",
        .Name = "N1"
         }
        Dim itemNodeNotInGroup As New RadTreeNode With
        {
         .Text = Con.Lbl_NotInGroups,
         .Value = "90909091",
         .Name = "N2"
        }
        'For Each Nd In TreeGroups.Nodes
        '    Nd.Tag = Nd.Value
        'Next
        Me.TreeGroups.Nodes.Insert(0, itemNodeAll)
        Me.TreeGroups.Nodes.Insert(1, itemNodeNotInGroup)
        Me.TreeGroups.TopNode.Selected = True
        RefrechGrid()
        InitiateGrid(Me.GridItemsGroups, Grouping:=False)
        '  HideShowColummn(Me.GridItems, 1, False)
    End Sub

    Private Sub TreeGroups_NodeMouseClick(sender As Object, e As RadTreeViewEventArgs) Handles TreeGroups.NodeMouseClick
        RefrechGrid()
    End Sub

    Private Sub TxtGroupSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtGroupSearch.TextChanged
        Me.TreeGroups.FilterDescriptors.Clear()
        Dim filter As New FilterDescriptor With {
            .PropertyName = "GroupName",
            .Operator = FilterOperator.Contains,
            .Value = Me.TxtGroupSearch.Text
        }
        Me.TreeGroups.FilterDescriptors.Add(filter)
        If Me.TxtGroupSearch.Text.Length = 0 Then
            Me.TreeGroups.Nodes.Move(Me.TreeGroups.Nodes(Con.Lbl_All).Index, 0)
            Me.TreeGroups.Nodes.Move(Me.TreeGroups.Nodes(Con.Lbl_NotInGroups).Index, 1)
        End If
    End Sub

    Private Sub TxtItems_TextChanged(sender As Object, e As EventArgs) Handles TxtItems.TextChanged
        Me.GridItemsGroups.FilterDescriptors.Clear()
        FilterGrid(Me.GridItemsGroups, "Item_name", Me.TxtItems.Text, FilterOperator.Contains)
    End Sub
End Class

'initiates drag and drop service for clicked rows
Public Class RowSelectionGridBehavior
    Inherits GridDataRowBehavior
    Protected Overrides Function OnMouseDownLeft(ByVal e As MouseEventArgs) As Boolean
        Dim row As GridDataRowElement = TryCast(Me.GetRowAtPoint(e.Location), GridDataRowElement)
        If Not row Is Nothing Then
            Dim svc As RadGridViewDragDropService = Me.GridViewElement.GetService(Of RadGridViewDragDropService)()
            svc.AllowAutoScrollColumnsWhileDragging = False
            svc.AllowAutoScrollRowsWhileDragging = False
            svc.Start(row)
        End If
        Return MyBase.OnMouseDownLeft(e)
    End Function
End Class