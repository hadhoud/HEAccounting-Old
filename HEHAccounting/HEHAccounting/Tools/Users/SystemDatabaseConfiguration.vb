Public Class SystemDatabaseConfiguration
    Private formText As String = ""
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSaveAndNew_Click(sender As Object, e As EventArgs) Handles BtnSaveAndNew.Click
        If txtServerName.Text.Length = 0 Or TxtDBName.Text.Length = 0 Then
            MessageShowInfo(Con.Msg_Enter_All_Fields)
            Exit Sub
        Else
            If isDbWindowsAuth.Checked = False Then
                If TxtDBUserName.Text.Length = 0 Or TxtDBPassword.Text.Length = 0 Then
                    MessageShowInfo(Con.Msg_System_Config_Enter_User_And_Pass)
                    Exit Sub
                End If
            End If
        End If
        saveDBxmlConfiguration()
        readConfigurationXmlFile()
    End Sub

    Private Sub SystemDatabaseConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formText = Me.Text
        showdbConfiguration()
    End Sub
    Private Sub isDbWindowsAuth_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles isDbWindowsAuth.ToggleStateChanged
        If isDbWindowsAuth.Checked = False Then
            Me.TxtDBUserName.Enabled = True
            Me.TxtDBPassword.Enabled = True
        Else
            Me.TxtDBUserName.Enabled = False
            Me.TxtDBPassword.Enabled = False
            Me.TxtDBUserName.Clear()
            Me.TxtDBPassword.Clear()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Me.TxtDBPassword.PasswordChar = vbNullChar Then
            Me.TxtDBPassword.PasswordChar = "*"c
        Else
            Me.TxtDBPassword.PasswordChar = String.Empty
        End If
    End Sub

    Private Sub btnRefreshConfig_Click(sender As Object, e As EventArgs) Handles btnRefreshConfig.Click
        readConfigurationXmlFile()
        showdbConfiguration()
    End Sub

    Private Sub showdbConfiguration()
        Me.TxtDBName.Text = dbDatabaseName
        Me.TxtDBUserName.Text = dbUserName
        Me.txtServerName.Text = dbServerName
        Me.TxtDBPassword.Text = Decode(dbPassword)
        If dbConnectionType.ToLower() = "windows" Then
            Me.isDbWindowsAuth.Checked = True
        Else
            Me.isDbWindowsAuth.Checked = False
        End If
    End Sub

    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        Me.btnTestConnection.Enabled = False
        Me.Text = formText + "-" + IIf(CheckConnection(), "Connected", "Disconnected")
        Me.btnTestConnection.Enabled = True
    End Sub

    Sub saveDBxmlConfiguration()
        Dim xmlFilePath As String = "dbConfig.xml"

        ' Load the XML file
        Dim xdoc As XDocument = XDocument.Load(xmlFilePath)

        ' Find the item with id="1" and modify its value
        Dim itemToEdit = xdoc.Descendants("item").FirstOrDefault(Function(i) i.Attribute("name")?.Value = "dbConnection")
        If itemToEdit IsNot Nothing Then

            ' Modify the servername
            Dim servernameElement = itemToEdit.Element("servername")
            If servernameElement IsNot Nothing Then
                servernameElement.Value = txtServerName.Text
            End If

            ' Modify the DatabaseName
            Dim dbnameElement = itemToEdit.Element("dbname")
            If dbnameElement IsNot Nothing Then
                dbnameElement.Value = TxtDBName.Text
            End If

            ' Modify the UserName
            Dim usernameElement = itemToEdit.Element("username")
            If usernameElement IsNot Nothing Then
                usernameElement.Value = TxtDBUserName.Text
            End If

            ' Modify the Password
            Dim PasswordElement = itemToEdit.Element("password")
            If PasswordElement IsNot Nothing Then
                PasswordElement.Value = Encode(TxtDBPassword.Text)
            End If

            ' Modify the Connection Type
            Dim ConnectionTypeElement = itemToEdit.Element("connectiontype")
            If isDbWindowsAuth.Checked = False Then
                If ConnectionTypeElement IsNot Nothing Then
                    ConnectionTypeElement.Value = "SQLServer"
                End If
            Else
                If ConnectionTypeElement IsNot Nothing Then
                    ConnectionTypeElement.Value = "Windows"
                End If
            End If

            ' Save the changes to the XML file
            xdoc.Save(xmlFilePath)
        End If
    End Sub
End Class
