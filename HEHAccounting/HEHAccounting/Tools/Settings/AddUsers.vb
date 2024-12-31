Imports Telerik.WinControls.UI
Imports Telerik.Windows.Documents.FormatProviders.OpenXml.Model

Public Class AddUsers
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If BoolLTRLanguage Then
            ChangeToEng()
        End If
        RefrechGrid()
        InitiateGrid(Me.GridUsers)
        FillGridPermissions()
        InitiateGrid(Me.GridPermissions, Editing:=True)
    End Sub
    Private Sub AddUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDropUserType()
        FormClear()
    End Sub

    Private Sub ChangeToEng()
        Me.RightToLeft = RightToLeft.No
        Me.Text = LoStrId.lblHome
    End Sub

    Public Sub RefrechGrid()
        Dim Param(0) As String
        Param(0) = "@IUserID , " & UserID
        FillGridViewProcedureWithParameters(Me.GridUsers, "SelectUsers", Param)
        'HideShowColummn(Me.GridDaily, IIf(BoolLTRLanguage, Me.GridDaily.Columns("Description").Index, Me.GridDaily.Columns("LatinDescription").Index), False)
        HideShowColummn(Me.GridUsers, Me.GridUsers.Columns("UserRole").Index, False)
    End Sub

    Private Sub FillDropUserType()

        Dim item As New RadListDataItem

        item = New RadListDataItem With {
            .Text = Con.Programmer,
            .Value = UserRole.Programmer
        }
        Me.DropUserType.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.Admin,
            .Value = UserRole.Admin
        }
        Me.DropUserType.Items.Add(item)

        item = New RadListDataItem With {
            .Text = Con.User,
            .Value = UserRole.User
        }
        Me.DropUserType.Items.Add(item)

        Initiatedropdownlist(Me.DropUserType)
    End Sub
    Private Sub FillGridPermissions()
        Dim AllowAdd As New GridViewCheckBoxColumn With
            {
        .Name = "AllowAdd",
        .FieldName = "AllowAdd",
        .NullValue = False
            }
        Dim AllowEdit As New GridViewCheckBoxColumn With
            {
        .Name = "AllowEdit",
        .FieldName = "AllowEdit",
        .NullValue = False
            }
        Dim AllowDelete As New GridViewCheckBoxColumn With
            {
        .Name = "AllowDelete",
        .FieldName = "AllowDelete",
        .NullValue = False
            }
        Dim AllowPosted As New GridViewCheckBoxColumn With
            {
        .Name = "AllowPosted",
        .FieldName = "AllowPosted",
        .NullValue = False
            }
        Dim Form As New GridViewTextBoxColumn With
            {
        .Name = "Form",
        .FieldName = "Form",
        .[ReadOnly] = True
          }
        Dim KeyName As New GridViewTextBoxColumn With
            {
        .Name = "KeyName",
        .FieldName = "KeyName",
        .[ReadOnly] = True
          }
        Me.GridPermissions.MasterTemplate.Columns.Add(Form)
        Me.GridPermissions.MasterTemplate.Columns.Add(KeyName)
        Me.GridPermissions.MasterTemplate.Columns.Add(AllowAdd)
        Me.GridPermissions.MasterTemplate.Columns.Add(AllowEdit)
        Me.GridPermissions.MasterTemplate.Columns.Add(AllowDelete)
        Me.GridPermissions.MasterTemplate.Columns.Add(AllowPosted)
        ExexuteGrid()
    End Sub
    Private Sub ExexuteGrid()
        FillGridViewProcedure(Me.GridPermissions, "SelectUsersRoleForms")
        HideShowColummn(Me.GridPermissions, Me.GridPermissions.Columns("KeyName").Index, False)
    End Sub
    Private Sub FormClear()
        Me.TxtFullName.Text = String.Empty
        Me.TxtUserName.Text = String.Empty
        Me.DropUserType.SelectedValue = UserRole.Admin
        Me.chkShowSalesDailyWin.Checked = False
        Me.chkShowHomeForm.Checked = False
        Me.chkShowDashboardForm.Checked = False
        Me.chkShowPurchasingPriceInProg.Checked = False
        Me.chkShowItemsSalesWinReport.Checked = False
        Me.chkShowProfitsTextInScreen.Checked = False
        Me.chkShowJemliSellingPriceInProg.Checked = False
        BtnDeselectAll.PerformClick()
        GetID()
    End Sub
    Private Sub GetID()
        Dim Param(0) As String
        Param(0) = "@VTableName , Users"
        Me.TxtNewUserID.Text = GetScalarProcedure("GetID", Param)
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Me.TxtUserName.Text.Length <> 0 And Me.TxtFullName.Text.Length <> 0 _
                And Me.DropUserType.SelectedIndex <> -1 Then
            If MessageShowAsk(IIf(BtnSave.Tag = "Edit", Con.Ask_Edit, Con.Ask_Add)) = DialogResult.Yes Then
                Dim Param(5) As String
                Param(0) = "@INewUserID , " & Me.TxtNewUserID.Text
                Param(1) = "@CFullName , " & Evalquote(Me.TxtFullName.Text)
                Param(2) = "@IUserType , " & Me.DropUserType.SelectedValue
                Param(3) = "@CUsername , " & Evalquote(Me.TxtUserName.Text)
                Param(4) = "@CPassword , " & Encode(Evalquote(Me.TxtUserName.Text))
                Param(5) = "@IUserID , " & UserID
                If NameRepetition() Then
                    MessageShowInfo(Con.Msg_Users_Already_Added)
                    Exit Sub
                End If
                If BtnSave.Tag = "Save" Then
                    ExecuteProcedureWithParameters("InsertUser", Param)
                    InsertUserRoles()
                    UpdateUserPermissions()
                    FormClear()
                    RefrechGrid()
                ElseIf BtnSave.Tag = "Edit" Then
                    ExecuteProcedureWithParameters("UpdateUser", Param)
                    Dim ParamDelete(0) As String
                    ParamDelete(0) = "@IUserID , " & Me.TxtNewUserID.Text
                    ExecuteProcedureWithParameters("DeleteUserRoles", ParamDelete)
                    InsertUserRoles()
                    UpdateUserPermissions()
                    FormClear()
                    RefrechGrid()
                    Me.BtnSave.Tag = "Save"
                    ExexuteGrid()
                    Home.ReloadUserRoles()
                End If
            End If

        Else
            MessageShowInfo(Con.Msg_Enter_All_Fields)
        End If

    End Sub
    Private Function NameRepetition() As Boolean
        If BtnSave.Tag = "Edit" Then
            Dim Param(2) As String
            Param(0) = "@VTableName , Users"
            Param(1) = "@CName , " & Evalquote(Me.TxtUserName.Text)
            Param(2) = "@IID , " & Me.TxtNewUserID.Text
            If GetScalarProcedure("GetNameRepetition", Param) = "0" Then
                Return False
            Else
                Return True
            End If
        Else
            Dim Param(1) As String
            Param(0) = "@VTableName , Users"
            Param(1) = "@CName , " & Evalquote(Me.TxtUserName.Text)
            If GetScalarProcedure("GetNameRepetition", Param) = "0" Then
                Return False
            Else
                Return True
            End If
        End If
    End Function
    Private Sub InsertUserRoles()
        For i As Integer = 0 To GridPermissions.ChildRows.Count - 1
            Dim ParamRoles(5) As String
            ParamRoles(0) = "@CForm , " & Me.GridPermissions.Rows(i).Cells("KeyName").Value
            ParamRoles(1) = "@BAllowAdd , " & IIf(Me.GridPermissions.Rows(i).Cells("AllowAdd").Value = Nothing, False, Me.GridPermissions.Rows(i).Cells("AllowAdd").Value)
            ParamRoles(2) = "@BAllowEdit , " & IIf(Me.GridPermissions.Rows(i).Cells("AllowEdit").Value = Nothing, False, Me.GridPermissions.Rows(i).Cells("AllowEdit").Value)
            ParamRoles(3) = "@BAllowDelete , " & IIf(Me.GridPermissions.Rows(i).Cells("AllowDelete").Value = Nothing, False, Me.GridPermissions.Rows(i).Cells("AllowDelete").Value)
            ParamRoles(4) = "@BAllowPosted , " & IIf(Me.GridPermissions.Rows(i).Cells("AllowPosted").Value = Nothing, False, Me.GridPermissions.Rows(i).Cells("AllowPosted").Value)
            ParamRoles(5) = "@IUserID , " & Me.TxtNewUserID.Text
            ExecuteProcedureWithParameters("InsertUserRoles", ParamRoles)
        Next
    End Sub

    Private Sub UpdateUserPermissions()
        Dim ParamPermissions(7) As String
        ParamPermissions(0) = "@bShowHomeScreenByUser , " & Me.chkShowHomeForm.Checked
        ParamPermissions(1) = "@bShowDashboardFormByUser , " & Me.chkShowDashboardForm.Checked
        ParamPermissions(2) = "@bShowPurchasingPriceInScreensByUser , " & Me.chkShowPurchasingPriceInProg.Checked
        ParamPermissions(3) = "@bShowSalesDailyWinScreenByUser , " & Me.chkShowSalesDailyWin.Checked
        ParamPermissions(4) = "@bShowItemsSalesWinReportScreenByUser , " & Me.chkShowItemsSalesWinReport.Checked
        ParamPermissions(5) = "@bShowProfitsTextInScreenByUser , " & Me.chkShowProfitsTextInScreen.Checked
        ParamPermissions(6) = "@bShowJemliSellingPriceInScreenByUser , " & Me.chkShowJemliSellingPriceInProg.Checked
        ParamPermissions(7) = "@IUserID , " & Me.TxtNewUserID.Text
        ExecuteProcedureWithParameters("UpdateUserPermissions", ParamPermissions)

    End Sub
    Private Sub BtnSelectAll_Click(sender As Object, e As EventArgs) Handles BtnSelectAll.Click
        For Each row In GridPermissions.Rows
            row.Cells("AllowAdd").Value = 1
            row.Cells("AllowEdit").Value = 1
            row.Cells("AllowDelete").Value = 1
            row.Cells("AllowPosted").Value = 1
        Next
    End Sub

    Private Sub BtnDeselectAll_Click(sender As Object, e As EventArgs) Handles BtnDeselectAll.Click
        For Each row In GridPermissions.Rows
            row.Cells("AllowAdd").Value = 0
            row.Cells("AllowEdit").Value = 0
            row.Cells("AllowDelete").Value = 0
            row.Cells("AllowPosted").Value = 0
        Next
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageShowAsk(Con.Ask_Delete) = DialogResult.Yes Then
            Dim UserR As String = Me.GridUsers.CurrentRow.Cells("UserRole").Value.ToString
            If UserR = UserRole.Programmer Then
                MessageShowInfo(Con.Msg_Cannot_Delete_User)
                Exit Sub
            End If
            Dim ParamDelete(0) As String
            ParamDelete(0) = "@IUserID , " & Me.GridUsers.CurrentRow.Cells("UserID").Value.ToString
            ExecuteProcedureWithParameters("Deleteuser", ParamDelete)
            RefrechGrid()
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Me.TxtNewUserID.Text = Me.GridUsers.CurrentRow.Cells("UserID").Value.ToString
        Me.TxtFullName.Text = Me.GridUsers.CurrentRow.Cells("FullName").Value.ToString
        Me.TxtUserName.Text = Me.GridUsers.CurrentRow.Cells("Username").Value.ToString
        Me.DropUserType.SelectedValue = Me.GridUsers.CurrentRow.Cells("UserRole").Value.ToString
        Me.BtnSave.Tag = "Edit"
        Dim ParamRoles(0) As String
        ParamRoles(0) = "@IUserID , " & Me.GridUsers.CurrentRow.Cells("UserID").Value.ToString
        ' Dim dtRoles As DataTable = ExecuteProcedureDatatableWithParameters("SelectUsersRoles", ParamRoles)
        FillGridViewProcedureWithParameters(Me.GridPermissions, "SelectUsersRoles", ParamRoles)
        HideShowColummn(Me.GridPermissions, Me.GridPermissions.Columns("KeyName").Index, False)
        FillPermissionsCheckboxList()
    End Sub

    Private Sub FillPermissionsCheckboxList()
        Dim Param(0) As String
        Param(0) = "@IUserID , " & Me.GridUsers.CurrentRow.Cells("UserID").Value.ToString
        Dim dtUserPermissions As DataTable = ExecuteProcedureDatatableWithParameters("SelectUserPermissions", Param)
        If dtUserPermissions.Rows.Count > 0 Then
            Me.chkShowHomeForm.Checked = dtUserPermissions.Rows(0).Item("bShowHomeScreenByUser")
            Me.chkShowSalesDailyWin.Checked = dtUserPermissions.Rows(0).Item("bShowSalesDailyWinScreenByUser")
            Me.chkShowDashboardForm.Checked = dtUserPermissions.Rows(0).Item("bShowDashboardFormByUser")
            Me.chkShowPurchasingPriceInProg.Checked = dtUserPermissions.Rows(0).Item("bShowPurchasingPriceInScreensByUser")
            Me.chkShowItemsSalesWinReport.Checked = dtUserPermissions.Rows(0).Item("bShowItemsSalesWinReportScreenByUser")
            Me.chkShowProfitsTextInScreen.Checked = dtUserPermissions.Rows(0).Item("bShowProfitsTextInScreenByUser")
            Me.chkShowJemliSellingPriceInProg.Checked = dtUserPermissions.Rows(0).Item("bShowJemliSellingPriceInScreenByUser")
        End If
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        FormClear()
        RefrechGrid()
        Me.BtnSave.Tag = "Save"
        ExexuteGrid()
        Home.ReloadUserRoles()
    End Sub
End Class
