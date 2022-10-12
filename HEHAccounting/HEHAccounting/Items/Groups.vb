
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class Groups

    Dim OldGroupName As String
    Public GetGroupName As String = ""
    Public FromAddNewItems As Boolean = False
    Dim GetGroupID As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        InitiateGrid(Me.GridGroups)
        EventHandlers()
        ' Me.GridGroups.ShowFilteringRow = True
        ' Me.GridGroups.EnableFiltering = True
    End Sub

    Private Sub EventHandlers()
        AddHandler ConMnuEdit.Click, AddressOf GridEdit
    End Sub

    Private Sub GridEdit()
        Me.BtnAdd.Text = IIf(BoolLTRLanguage, LoStrId.LblEdit, "تعديل")
        Me.BtnAdd.Tag = "Edit"
        GetGroupID = Me.GridGroups.CurrentRow.Cells(0).Value.ToString
        Me.TxtGroupName.Text = Me.GridGroups.CurrentRow.Cells(1).Value.ToString
        OldGroupName = Me.TxtGroupName.Text
        Me.TxtGroupDesc.Text = Me.GridGroups.CurrentRow.Cells(2).Value.ToString
    End Sub
    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.LblGroupName.Text = LoStrId.LblGroupName
        Me.LblNote.Text = LoStrId.LblNote
        Me.BtnSearch.Text = LoStrId.LblFiltering
        Me.BtnAdd.Text = LoStrId.LblAdd
        Me.Text = LoStrId.LblGroups
        Me.ConMnuEdit.Text = LoStrId.LblEdit
    End Sub


    Public Sub RefrechGrid()
        FillGridViewProcedure(Me.GridGroups, "SelectGroups")
    End Sub


    Private Sub Groups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormClear()
    End Sub
    Private Sub GetID()
        Dim Param(0) As String
        Param(0) = "@VTableName , Groups"
        GetGroupID = GetScalarProcedure("GetID", Param)
    End Sub
    Private Function NameRepetition() As Boolean

        If BtnAdd.Tag = "Edit" Then
            Dim Param(2) As String
            Param(0) = "@VTableName , Groups"
            Param(1) = "@CName , " & Me.TxtGroupName.Text
            Param(2) = "@IID , " & GetGroupID
            If GetScalarProcedure("GetNameRepetition", Param) = "0" Then
                Return False
            Else
                Return True
            End If
        Else
            Dim Param(1) As String
            Param(0) = "@VTableName , Groups"
            Param(1) = "@CName , " & Me.TxtGroupName.Text
            If GetScalarProcedure("GetNameRepetition", Param) = "0" Then
                Return False
            Else
                Return True
            End If
        End If

    End Function

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If Me.TxtGroupName.Text.Trim.Length <> 0 Then
            If MessageShowAsk(IIf(BtnAdd.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                Dim Param(3) As String
                Param(0) = "@IGroupID , " & GetGroupID
                Param(1) = "@CGroupName , " & Evalquote(Me.TxtGroupName.Text)
                Param(2) = "@CGroupDescription , " & Evalquote(Me.TxtGroupDesc.Text)
                Param(3) = "@IUserID , " & UserID
                If NameRepetition() Then
                    MessageShowInfo(Con.Msg_Groups_Already_Added)
                    Exit Sub
                End If
                If BtnAdd.Tag = "Add" Then
                    ExecuteProcedureWithParameters("InsertNewGroup", Param)
                    GroupNameAuto.Add(Me.TxtGroupName.Text.ToLower)
                    FormClear()
                ElseIf BtnAdd.Tag = "Edit" Then
                    ExecuteProcedureWithParameters("UpdateGroup", Param)
                    GroupNameAuto.Remove(OldGroupName)
                    GroupNameAuto.Add(Me.TxtGroupName.Text.ToLower)
                    MessageShowInfo(Con.Msg_Group_Has_Been_Updated)
                    FormClear()
                End If
            End If
            RefrechGrid()
        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If
    End Sub

    Sub FormClear()
        Me.BtnAdd.Text = IIf(BoolLTRLanguage, LoStrId.LblAdd, "إضافة")
        Me.BtnAdd.Tag = "Add"
        Me.TxtGroupDesc.Clear()
        Me.TxtGroupName.Clear()
        GetID()
    End Sub

    Private Sub GridGroups_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles GridGroups.CellDoubleClick

        If Me.GridGroups.ChildRows.Count <> 0 And FromAddNewItems And TryCast(sender, GridDataCellElement) IsNot Nothing Then
            GetGroupName = Me.GridGroups.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Me.BtnAdd.Text = IIf(BoolLTRLanguage, LoStrId.LblAdd, "إضافة")
        Me.BtnAdd.Tag = "Add"
        GetID()
        Me.GridGroups.FilterDescriptors.Clear()
        FilterGrid(Me.GridGroups, "GroupName", Me.TxtGroupName.Text, FilterOperator.Contains)
        FilterGrid(Me.GridGroups, "GroupDescription", Me.TxtGroupDesc.Text, FilterOperator.Contains)
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        FormClear()
    End Sub
End Class
