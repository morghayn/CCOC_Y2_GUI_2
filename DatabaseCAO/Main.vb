Imports System.Data.OleDb

Public Class Main


    Private dAdapter As New OleDbDataAdapter, dSet As DataSet = New DataSet
    Private dConnect As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Resources\CAO.accdb")
    ' -- Note: You need Microsoft Access Engine 2010 to use OleDBCommand
    ' -> Instantiating my data adapter and data set


    Private Sub MyProject(sender As Object, e As EventArgs) Handles MyBase.Load
        caoGrid.Hide()
        btnBack.Hide()

        Try
            dConnect.Open()
            FillGrid()
            CreateTotalsColumn()
            For i = 1 To dSet.Tables("Results").Rows.Count - 1
                cmbPPSNList.Items.Add(myGrid.Rows(i).Cells(0).Value)
            Next
        Catch ex As Exception
            MsgBox("Error. Couldn't connect to Access database.")
        End Try

        ValidationHandlers()
    End Sub
    '
    ' -> Opening my database connection (with try/catch)


    Private Sub ValidationHandlers()
        AddHandler TextBoxList(0).KeyPress, AddressOf OnlyPPSN
        For i As Short = 1 To 2
            AddHandler TextBoxList(i).KeyPress, AddressOf OnlyLetters
        Next
        For i As Short = 3 To 11
            AddHandler TextBoxList(i).TextChanged, AddressOf IfGradeOver100
            AddHandler TextBoxList(i).KeyPress, AddressOf OnlyNumbers
        Next
    End Sub
    Private Sub OnlyPPSN(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If CType(sender, TextBox).TextLength < 7 Or String.IsNullOrEmpty(CType(sender, TextBox).Text) Then
            e.Handled = If(Asc(e.KeyChar) = 8, False,
                    If(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57, False, True))
        Else
            e.KeyChar = If(Asc(e.KeyChar) >= 97, Chr(Asc(e.KeyChar) - 32), e.KeyChar)
            e.Handled = If(Asc(e.KeyChar) = 8, False,
                        If(Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90, False, True))
        End If
    End Sub
    Private Sub OnlyNumbers(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        e.Handled = If(Asc(e.KeyChar) = 8, False,
                    If(Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57, False, True))
    End Sub
    Private Sub OnlyLetters(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        e.Handled = If(Asc(e.KeyChar) = 8, False,
                    If(Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90, False,
                    If(Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122, False, True)))
    End Sub
    Private Sub IfGradeOver100(sender As Object, e As EventArgs)
        CType(sender, TextBox).Text = If(CType(sender, TextBox).Text = "", 0, CType(sender, TextBox).Text)
        If CType(sender, TextBox).Text > 100 Then
            CType(sender, TextBox).Text = 100
        End If
    End Sub
    '
    ' -> Validating Boxes
    ' -> Getting Cell Index: https://www.daniweb.com/programming/software-development/threads/94061/get-the-selected-row-in-datagridview


    Private Sub FillGrid()
        dSet.Clear()
        dAdapter.SelectCommand = New OleDbCommand("Select * From [5M0536 Module Results]", dConnect)
        dAdapter.Fill(dSet, "Results")
        myGrid.DataSource = dSet.Tables("Results")
    End Sub
    '
    ' -> Filling my data adapter with imported data
    ' -> Setting myGrid with my data imported


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
    '
    ' -> Adding new total column and adding values to new column
    ' -> Resizing all columns and updating row-counter


    Private Sub Insert(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            Dim deletion As New DialogResult()
            deletion = MessageBox.Show("Do you want to insert the record?", "Insert Record",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If deletion = DialogResult.Yes Then
                dAdapter.InsertCommand = New OleDbCommand("INSERT INTO [5M0536 Module Results] Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)", dConnect)
                For i As Short = 0 To 11
                    dAdapter.InsertCommand.Parameters.AddWithValue(i, TextBoxList(i).Text)
                Next
                dAdapter.InsertCommand.ExecuteNonQuery()

                FillGrid()
                FillTotalsColumn()
            Else
                Return ' -> No action carried out!
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MessageBoxButtons.OKCancel)
            Return
        End Try
    End Sub


    Private Sub ModifyGrades(sender As Object, e As EventArgs) Handles btnModify.Click
        If AreFieldsSet() <> False Then
            Dim tempSQL As String = ""
            For i As Short = 0 To 8
                If i < 8 Then
                    tempSQL += ModuleList(i) & "='" & TextBoxList(i + 3).Text & "', "
                Else
                    tempSQL += ModuleList(i) & "='" & TextBoxList(i + 3).Text
                End If
            Next
            Dim SQLQuery As String = "UPDATE [5M0536 Module Results] set " & tempSQL & "' where PPSN='" & myGrid.CurrentRow.Cells(0).Value & "'"
            dAdapter.UpdateCommand = New OleDbCommand(SQLQuery, dConnect)
            dAdapter.UpdateCommand.ExecuteNonQuery()

            FillGrid()
            FillTotalsColumn()
        Else
            MsgBox("Error")
        End If
    End Sub


    Private Sub DeleteRecord(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim deletion As New DialogResult(), record As String = ""
            For i As Short = 0 To 2
                record += myGrid.CurrentRow.Cells(i).Value & " "
            Next
            deletion = MessageBox.Show("Do you want to permanently delete the record: " & vbNewLine & record, "Delete Record",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If deletion = DialogResult.Yes Then
                dAdapter.DeleteCommand = New OleDbCommand("DELETE FROM [5M0536 Module Results] where PPSN='" & myGrid.CurrentRow.Cells(0).Value & "'", dConnect)
                dAdapter.DeleteCommand.ExecuteNonQuery()
                FillGrid()
                FillTotalsColumn()
            Else
                Return ' -> No action carried out!
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString(), MessageBoxButtons.OKCancel)
            Return
        End Try
    End Sub
    '
    ' ->


    Private Sub Search(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim SQLQuery As String = "Select * from [5M0536 Module Results] where "
        Dim isLike As String = " like '%" & txtSearchBox.Text & "%'", isEquals As String = " = '" & txtSearchBox.Text & "'"
        Dim first As String = "PPSN", second As String = "FirstName", third As String = "Surname"

        If chkPartialSearch.Checked Then
            SQLQuery += first & isLike & " OR " & second & isLike & " OR " & third & isLike
        Else
            SQLQuery += first & isEquals & " OR " & second & isEquals & " OR " & third & isEquals
        End If
        dSet.Clear()
        dAdapter.SelectCommand = New OleDbCommand(SQLQuery, dConnect)
        dAdapter.Fill(dSet, "Results")
        myGrid.DataSource = dSet.Tables("Results")
        FillTotalsColumn()
    End Sub
    '
    ' ->


    Private Sub ClearReset(sender As Object, e As EventArgs) Handles btnClear.Click
        myGrid.Show()
        caoGrid.Hide()
        '
        FillGrid()
        FillTotalsColumn()
        myGrid.ClearSelection()
        '
        For i As Short = 0 To 11
            TextBoxList(i).Text = ""
        Next
    End Sub
    '
    ' -> Clears a search and displays all results from database


    Private Sub PPSNList(sender As Object, e As EventArgs) Handles cmbPPSNList.SelectedIndexChanged
        dSet.Clear()
        dAdapter.SelectCommand = New OleDbCommand("Select * from [5M0536 Module Results] where PPSN='" & cmbPPSNList.Text & "'", dConnect)
        dAdapter.Fill(dSet, "Results")
        myGrid.DataSource = dSet.Tables("Results")
        FillTotalsColumn()
    End Sub


    Private Sub ViewSingleStudent(sender As Object, e As EventArgs) Handles myGrid.Click, myGrid.KeyUp, myGrid.KeyDown, myGrid.CellValueChanged
        Dim selectedRow As Integer = myGrid.CurrentRow.Index
        For i As Short = 0 To 11
            TextBoxList(i).Text = myGrid.Rows(selectedRow).Cells(i).Value
        Next
    End Sub
    '
    ' -> Loads selected students data into the text boxes on the left side of the VB form


    Private Function RowCount() As String
        Return dSet.Tables("Results").Rows.Count
    End Function
    Private Function TextBoxList() As IEnumerable(Of TextBox)
        Return New List(Of TextBox) From {txtPPSN, txtForename, txtSurname, txt5N2928, txt5N2929, txt5N0548, txt5N2434, txt5N2927, txt5N18396, txt5N0783, txt5N0690, txt5N1356}
    End Function
    Private Function ModuleList() As IEnumerable(Of String)
        Return New List(Of String) From {"5N2928", "5N2929", "5N0548", "5N2434", "5N2927", "5N18396", "5N0783", "5N0690", "5N1356"}
    End Function
    Private Function ButtonList() As IEnumerable(Of Button)
        Return New List(Of Button) From {btnInsert, btnClear, btnShowCourses, btnDelete, btnModify, btnSearch}
    End Function

    Private Sub Back(sender As Object, e As EventArgs) Handles btnBack.Click
        Width = 980
        myGrid.Show()
        caoGrid.Hide()
        For Each butt In ButtonList()
            butt.Show()
        Next
        For Each box In TextBoxList()
            box.ReadOnly = False
        Next
        txtSearchBox.Show()
        chkPartialSearch.Show()
        cmbPPSNList.Show()
        btnClear.PerformClick()
        btnBack.Hide()
    End Sub

    Private Sub ViewButton(sender As Object, e As EventArgs) Handles btnShowCourses.Click
        If AreFieldsSet() <> False Then
            Dim points As Double = myGrid.CurrentRow.Cells(12).Value
            myGrid.Hide()
            caoGrid.Show()
            dSet.Clear()
            dAdapter.SelectCommand = New OleDbCommand("Select * FROM [CAO Points 2018] WHERE [Points] < " & points & "", dConnect)
            dAdapter.Fill(dSet, "CAO")
            caoGrid.DataSource = dSet.Tables("CAO")
            caoGrid.AutoResizeColumns()
            Width = 750
            For Each butt In ButtonList()
                butt.Hide()
            Next
            txtSearchBox.Hide()
            chkPartialSearch.Hide()
            cmbPPSNList.Hide()
            For Each box In TextBoxList()
                box.ReadOnly = True
            Next
            caoGrid.ClearSelection()
            btnBack.Show()
        End If
    End Sub

    Public Function AreFieldsSet() As Boolean
        If TextBoxList(0).TextLength <> 8 Then
            MsgBox("Valid PPSN, 7 Numbers followed by letter, must be present.")
            Return False
        End If
        For i As Short = 1 To 2
            If TextBoxList(i).TextLength < 2 Then
                MsgBox("Forename and Surname must be longer than 2 characters")
                Return False
            End If
        Next
        Return True
    End Function


End Class