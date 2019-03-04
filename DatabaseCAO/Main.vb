Imports System.Data.OleDb


' how to make vb.net scalable window https://www.techrepublic.com/article/manage-winform-controls-using-the-anchor-and-dock-properties/


Public Class Main

    Dim ColumnCount As New Int16
    Dim doColumn As New Int16
    Dim DAdapter As New OleDbDataAdapter
    Dim DSet As DataSet = New DataSet
    Dim DConnect As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Resources\CAO.accdb")
    '
    ' -> Instantiating my DataAdapter and DataSet


    Private Sub MyProject(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DConnect.Open()
        Catch ex As Exception
            MsgBox("Error. No connection.")
        End Try
        doColumn = 0
    End Sub
    '
    ' -> Opening my Database Connection ( > With a Try/Catch < )


    Private Sub FillTable()
        Dim tabname As String
        'tabname = "5M0536 Module Results"
        'github test
        DSet.Clear()
        DAdapter.SelectCommand = New OleDbCommand("Select * From [5M0536 Module Results]", DConnect)
        DAdapter.Fill(DSet, "Fill-People")
        MyGrid.DataSource = DSet.Tables("Fill-People")
        '
        ColumnCount = DSet.Tables("Fill-People").Rows.Count
        ' -> Getting value for count

        If doColumn = 0 Then AddColumn()
        doColumn += 1
    End Sub
    '
    ' -> Load Values into MyGrid

    Private Sub AddColumn()
        Dim col As New DataGridViewTextBoxColumn
        col.DataPropertyName = "colTotalPoints"
        col.HeaderText = "Total"
        col.Name = "TotalPoints"
        MyGrid.Columns.Add(col)



        'MyGrid.Rows(0).Cells(5).Value = 54
        '
        ' -> Adding value successfully

        ' Dim x As Integer
        ' x = MyGrid.Rows(yourRowIndex).Cells(yourColumnIndex).Value

    End Sub


    Private Sub LoadInsertRecord(sender As Object, e As EventArgs) Handles InsertButton.Click, LoadButton.Click
        If CType(sender, Button).Name.ToString = "InsertButton" Then
            ColumnCount += 1
            DAdapter.InsertCommand = New OleDbCommand("INSERT INTO People (PPSN, FirstName, Surname, 5N2928, 5N2929, 5N0548, 5N2434, 5N2927, 5N18396, 5N0783, 5N0690, 5N1356) Values ('" & ColumnCount & "', '" & txtFname.Text & "', '" & txtLname.Text & "', '" & txtAddress.Text & "', '" & txtAge.Text & "')", DConnect)
            DAdapter.InsertCommand.ExecuteNonQuery()
        End If
        FillTable()
        MyGrid.AutoResizeColumns()
    End Sub
    '
    ' -> Load / Insert New Record

    Private Sub ReadACell(sender As Object, e As EventArgs) Handles mybtn.Click
        ' Dim x As Integer
        ' MyGrid.Columns.Add("Column Name", "Column Heading")
        ' x = MyGrid.Rows(yourRowIndex).Cells(yourColumnIndex).Value
        ' x = MyGrid.Rows(1).Cells(0).Value
        'MsgBox(x)



        'MyGrid.Rows(0).Cells(5).Value = 54
        '
        ' - > Also adding cell successfully
    End Sub
    '
    ' -> How to read a single cell in DataGridView

    Private Sub MiscClick(sender As Object, e As EventArgs) Handles Newbut.Click
        Dim x As String
        Dim y As Integer
        y = MyGrid.CurrentRow.Index
        x = ""
        For Each dgvRow In MyGrid.SelectedRows
            x = dgvRow.Cells("PPSN").Value.ToString
        Next
        MsgBox(y)


    End Sub

    Private Sub MyGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MyGrid.CellContentClick

    End Sub
    '
    '   https://social.msdn.microsoft.com/Forums/windows/en-US/7ce81f9a-7047-444d-b75b-ef548b2ec635/datagridview-select-rows-and-retrieve-the-values-of-the-cells?forum=winformsdatacontrols
    '
    ' -> Returns value from NameID of the selected row
    ' -> Gets cell index
    ' -> https://www.daniweb.com/programming/software-development/threads/94061/get-the-selected-row-in-datagridview



    'https://social.msdn.microsoft.com/Forums/vstudio/en-US/0457f101-3caa-46a8-ba9e-dbd9e8bcc6a7/how-to-update-only-one-datagridview-column-from-database?forum=vbgeneral
    'write to column?

    'https://www.daniweb.com/programming/software-development/threads/369439/add-values-in-a-column-of-a-datagridview-in-vb-net
    'adding via SQL


    'creating column
    'https://stackoverflow.com/questions/8730765/vb-net-adding-columns-to-datagridviews-in-a-list


    'summin columns
    'https://stackoverflow.com/questions/16452036/using-vb-to-retrieve-the-sum-of-a-column-of-salaries-from-an-access-database



    'Total tutorial
    'https://stackoverflow.com/questions/20594071/how-can-you-add-a-column-in-datagridview-using-calculations-with-database-values


    'video tutorial
    'https://www.youtube.com/watch?v=7RqAmgv0J1I



    'how I can show the sum of in a datagridview column?
    'https://stackoverflow.com/questions/3779729/how-i-can-show-the-sum-of-in-a-datagridview-column



    'Selecting DataGridView

End Class