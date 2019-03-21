Imports System.Data.OleDb

Public Class Main
    Private dAdapter As New OleDbDataAdapter, dSet As DataSet = New DataSet, rowSelected As Short
    Private dConnect As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Resources\CAO.accdb")
    ' -- Note: You need Microsoft Access Engine 2010 to use OleDBCommand
    ' -> Instantiating my data adapter and data set


    Private Sub MyProject(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dConnect.Open()
            FillGrid()
            CreateTotalsColumn()
        Catch ex As Exception
            MsgBox("Error. Couldn't connect to Access database.")
        End Try
        AddValidationHandlers()
        PPSNCombo()
        btnClear.PerformClick()
    End Sub
    '
    ' -> Opening my database connection, filling text boxes with the first record, adding data validation to grade boxes and filling the ppsn combo-box


    Private Sub FillGrid()
        dSet.Clear()
        dAdapter.SelectCommand = New OleDbCommand("Select * From [5M0536 Module Results]", dConnect)
        dAdapter.Fill(dSet, "Results")
        myGrid.DataSource = dSet.Tables("Results")
    End Sub
    Private Sub CreateTotalsColumn()
        myGrid.Columns.Add("TotalPoints", "CAO Points")
        For i = 0 To (myGrid.Columns.Count - 1)
            myGrid.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
        myGrid.AutoResizeColumns()
        FillTotalsColumn()
    End Sub
    Public Sub FillTotalsColumn()
        Dim grade As New Integer, points As New Double
        For row As Integer = 0 To RowCount() - 1
            points = 0
            For col As Integer = 3 To 11
                grade = myGrid.Rows(row).Cells(col).Value
                points += If(grade >= 80, 38.75,
                          If(grade >= 65 And grade < 80, 32.5,
                          If(grade >= 50 And grade < 65, 16.35, 0)))
            Next
            myGrid.Rows(row).Cells(12).Value = points
        Next
    End Sub
    Private Sub RefreshGrid(x As Short)
        If x = 0 Then ' Used by Clear, Delete, Reset, Modify, ToggleGrid
            FillGrid()
            PPSNCombo()
            FillTotalsColumn()
            ImportStudentData()
            myGrid.Rows(rowSelected).Selected = True
            myGrid.CurrentCell = myGrid.Item(1, rowSelected)
        End If

        If x = 1 Or x = 2 Then ' Used by PPSN Search (as 1) and Used by Search (as 2)
            dAdapter.Fill(dSet, "Results")
            myGrid.DataSource = dSet.Tables("Results")
            If x = 2 And Not myGrid.RowCount > 0 Then
                MessageBox.Show("No records available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FillGrid()
                btnClear.PerformClick()
            End If
            FillTotalsColumn()
            If x = 1 Then ImportStudentData()
        End If
    End Sub
    Private Sub GridModified(sender As Object, e As EventArgs) Handles myGrid.Click, myGrid.KeyUp, myGrid.KeyDown
        If myGrid.RowCount > 0 Then
            rowSelected = myGrid.CurrentRow.Index
            ImportStudentData()
        End If
    End Sub
    '
    ' -> FillGrid() == Fills my grid by selecting the entire [5M0536 Module Results] table from the Access database
    ' -> CreateTotalsColumn() && FillTotalsColumn() == Both used in conjuction to adding and filling the totals column
    ' -> RefreshGrid() == Refreshes the datagrid


    Private Sub ImportStudentData()
        For i As Short = 0 To 11
            TextBoxList(i).Text = myGrid.Rows(rowSelected).Cells(i).Value
        Next
        txtPoints.Text = myGrid.Rows(rowSelected).Cells(12).Value
        For i As Short = 0 To 2
            ButtonList(i).Enabled = True
        Next
    End Sub
    '
    ' -> Fills PPSN, Forename, Surname, Grades and Total Points box with student data when a selection is made on the DataGrid.


    Private Sub Insert(sender As Object, e As EventArgs) Handles btnInsert.Click
        If Not txtPPSN.TextLength = 8 Then
            MessageBox.Show("PPSN must be 7 numbers followed by a letter.", "PPSN Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            dAdapter.InsertCommand = New OleDbCommand("INSERT INTO [5M0536 Module Results] Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)", dConnect)
            For i As Short = 0 To 11
                dAdapter.InsertCommand.Parameters.AddWithValue(i, TextBoxList(i).Text)
            Next
            dAdapter.InsertCommand.ExecuteNonQuery()
            RefreshGrid(0)
        Catch ex As Exception
            MessageBox.Show("Either the PPSN, Forename or Surname is invalid.", "Insert Error.",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '
    ' -> Insert record sub, utilizes error handling


    Private Sub ModifyGrades(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim tempSQL As String = ""
        For i As Short = 0 To 8
            tempSQL += If(i < 8, ModuleList(i) & "='" & TextBoxList(i + 3).Text & "', ", ModuleList(i) & "='" & TextBoxList(i + 3).Text)
        Next
        dAdapter.UpdateCommand = New OleDbCommand("UPDATE [5M0536 Module Results] set " & tempSQL & "' where PPSN='" & myGrid.CurrentRow.Cells(0).Value & "'", dConnect)
        dAdapter.UpdateCommand.ExecuteNonQuery()
        RefreshGrid(0)
    End Sub
    '
    ' -> Algorithm for modifying grades


    Private Sub DeleteRecord(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim deleteYesNo As New DialogResult(), record As String = txtPPSN.Text & " " & txtForename.Text & " " & txtSurname.Text
        deleteYesNo = MessageBox.Show("Do you want to permanently delete the record: " & vbNewLine & record, "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If deleteYesNo = DialogResult.Yes Then
            dAdapter.DeleteCommand = New OleDbCommand("DELETE FROM [5M0536 Module Results] where PPSN='" & myGrid.CurrentRow.Cells(0).Value & "'", dConnect)
            dAdapter.DeleteCommand.ExecuteNonQuery()
            If myGrid.CurrentRow.Index = myGrid.RowCount - 1 Then rowSelected -= 1
            If myGrid.RowCount = 1 Then
                FillGrid()
                btnClear.PerformClick()
                Exit Sub
            End If
            RefreshGrid(0)
        End If
    End Sub
    '
    ' -> Algorithm for deleting records


    Private Sub Search(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim myQuery = If(chkPartialSearch.Checked, " like '%" & txtSearchBox.Text & "%'", " = '" & txtSearchBox.Text & "'")
        Dim mySearch = ("Select * from [5M0536 Module Results] where " + "PPSN") & myQuery & " OR " & "FirstName" & myQuery & " OR " & "Surname" & myQuery
        dAdapter.SelectCommand = New OleDbCommand(mySearch, dConnect)
        dSet.Clear()
        RefreshGrid(2)
    End Sub
    '
    ' -> Searches (full or partial) for records via a SQL 'like' or 'equal' query for the ppsn, forename or surname columns


    Private Sub ClearReset(sender As Object, e As EventArgs) Handles btnClear.Click
        myGrid.ClearSelection()
        For i As Short = 0 To 12
            TextBoxList(i).Text = ""
        Next
        For i As Short = 0 To 2
            ButtonList(i).Enabled = False
        Next
    End Sub
    '
    ' -> Clears / Resets all selections and text boxes in the program


    Private Sub ToggleGrid(sender As Object, e As EventArgs) Handles btnShowCourses.Click, btnBack.Click
        Dim Button As String = CType(sender, Button).Name.ToString, points As Double

        Dim y As Boolean = If(Button = "btnShowCourses", 1, 0)
        caoGrid.Visible = y
        btnBack.Visible = y
        For Each box In TextBoxList()
            box.ReadOnly = y
        Next

        Dim x As Boolean = If(Button = "btnShowCourses", 0, 1)
        If x = 0 Then points = myGrid.CurrentRow.Cells(12).Value
        If x = 0 Then rowSelected = myGrid.CurrentRow.Index
        Width = If(x = 0, 750, 1000)
        For Each buttons In ButtonList()
            buttons.Visible = x
        Next
        myGrid.Visible = x
        txtSearchBox.Visible = x
        chkPartialSearch.Visible = x
        cmbPPSNList.Visible = x

        If x = 0 Then
            dAdapter.SelectCommand = New OleDbCommand("Select * FROM [CAO Points 2018] WHERE [Points] < " & points & "", dConnect)
            dAdapter.Fill(dSet, "CAO")
            caoGrid.DataSource = dSet.Tables("CAO")
            caoGrid.AutoResizeColumns()
        Else
            RefreshGrid(0)
        End If
    End Sub
    '
    ' -> Shows or hides the CAO table, along with buttons that are unneeded - this sub is dependent on whoever the Button sender is.


    Private Sub PPSNCombo()
        cmbPPSNList.Items.Clear()
        For i = 1 To dSet.Tables("Results").Rows.Count - 1
            cmbPPSNList.Items.Add(myGrid.Rows(i).Cells(0).Value)
        Next
    End Sub
    Private Sub PPSNList(sender As Object, e As EventArgs) Handles cmbPPSNList.SelectedIndexChanged
        dSet.Clear()
        dAdapter.SelectCommand = New OleDbCommand("Select * from [5M0536 Module Results] where PPSN='" & cmbPPSNList.Text & "'", dConnect)
        rowSelected = 0
        RefreshGrid(1)
    End Sub
    '
    ' -> Fills my combo-box with all PPSN numbers on the grid. The end-user can use this combo-box to search for a user entry.


    Private Sub AddValidationHandlers()
        For i As Short = 3 To 11 ' -> Assigning constraints to the grade boxes
            AddHandler TextBoxList(i).TextChanged, AddressOf IfGradeOver100
            AddHandler TextBoxList(i).KeyPress, AddressOf OnlyNumbers
        Next
    End Sub
    Private Sub OnlyPPSN(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtPPSN.KeyPress
        If CType(sender, TextBox).TextLength < 7 Or String.IsNullOrEmpty(CType(sender, TextBox).Text) Then
            e.Handled = If(Asc(e.KeyChar) = 8, False,
                    If(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57, False, True))
        ElseIf CType(sender, TextBox).SelectionStart = 7 Then
            e.KeyChar = If(Asc(e.KeyChar) >= 97, Chr(Asc(e.KeyChar) - 32), e.KeyChar)
            e.Handled = If(Asc(e.KeyChar) = 8, False,
                        If(Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90, False, True))
        Else
            e.Handled = If(Asc(e.KeyChar) = 8, False,
               If(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57, False, True))
        End If
    End Sub
    Private Sub OnlyLetters(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtForename.KeyPress, txtSurname.KeyPress
        e.Handled = If(Asc(e.KeyChar) = 8, False,
                    If(Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90, False,
                    If(Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122, False, True)))
    End Sub
    Private Sub OnlyNumbers(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        e.Handled = If(Asc(e.KeyChar) = 8, False,
                    If(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57, False, True))
    End Sub
    Private Sub IfGradeOver100(sender As Object, e As EventArgs)
        CType(sender, TextBox).Text = If(CType(sender, TextBox).Text = "", 0, CType(sender, TextBox).Text)
        If CType(sender, TextBox).Text > 100 Then
            CType(sender, TextBox).Text = 100
        End If
    End Sub
    '
    ' -> Data validating and constraining all editable text boxes. 


    Private Function RowCount() As String
        Return dSet.Tables("Results").Rows.Count
    End Function
    Private Function TextBoxList() As IEnumerable(Of TextBox)
        Return New List(Of TextBox) From {txtPPSN, txtForename, txtSurname, txt5N2928, txt5N2929, txt5N0548, txt5N2434, txt5N2927, txt5N18396, txt5N0783, txt5N0690, txt5N1356, txtPoints}
    End Function
    Private Function ModuleList() As IEnumerable(Of String)
        Return New List(Of String) From {"5N2928", "5N2929", "5N0548", "5N2434", "5N2927", "5N18396", "5N0783", "5N0690", "5N1356"}
    End Function
    Private Function ButtonList() As IEnumerable(Of Button)
        Return New List(Of Button) From {btnShowCourses, btnDelete, btnModify, btnInsert, btnClear, btnSearch}
    End Function
    '
    ' -> These functions are used to recycle and compress my code by holding variables and objects which I access several times through the project.


    Private Sub HelpMenu(sender As Object, e As EventArgs) Handles btnHelp.Click
        Dim helpOne As String = "(1) To view all results:" & vbNewLine & "Simply load the program." & vbNewLine & "If you're viewing the CAO table for a student click back"
        Dim helpTwo As String = "(2) To view a single student:" & vbNewLine & "Highlight the student on the table by clicking their row."
        Dim helpThree As String = "(3) Search for a student:" & vbNewLine & "Input search phrase into the search box then click search." & vbNewLine & "To do a partial search, simply click the partial search check box."
        Dim helpFour As String = "(4) Insert a new student:" & vbNewLine & "Click the clear button to clear all textboxes." & vbNewLine & "Then click 'insert' after entering valid data for the entry."
        Dim helpFive As String = "(5) Modify student marks:" & vbNewLine & "View a single student, see help (2). Change desired result boxes. Then click the modify button."
        MsgBox(helpOne & vbNewLine & vbNewLine & helpTwo & vbNewLine & vbNewLine & helpThree & vbNewLine & vbNewLine & helpFour & vbNewLine & vbNewLine & helpFive)
    End Sub
    '
    ' -> Prints a help box via a MsgBox, the help instructions brief the end-user on how to operate each of the program's functionality


End Class