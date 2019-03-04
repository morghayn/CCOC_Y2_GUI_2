Imports System.Data.OleDb

' Github // Successfully hooked up and synced on my laptop && PC

Public Class Main

    Dim rowCounter As New Int16
    Dim dAdapter As New OleDbDataAdapter
    Dim dSet As DataSet = New DataSet
    Dim dConnect As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Resources\CAO.accdb")
    '
    ' -- Note: You need Microsoft Access Engine 2010 to use OleDBCommand
    ' -> Instantiating my data adapter and data set


    Private Sub MyProject(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dConnect.Open()
        Catch ex As Exception
            MsgBox("Error. Couldn't connect to Access database.")
        End Try
        FillGrid()
        AddColumn()
    End Sub
    '
    ' -> Opening my database connection (with try/catch)


    Private Sub FillGrid()
        dSet.Clear()
        dAdapter.SelectCommand = New OleDbCommand("Select * From [5M0536 Module Results]", dConnect)
        dAdapter.Fill(dSet, "Results")
        myGrid.DataSource = dSet.Tables("Results")
    End Sub
    '
    ' -> Filling my data adapter with imported data
    ' -> Setting myGrid with my data imported


    Private Sub AddColumn()
        myGrid.Columns.Add("TotalPoints", "Total")
        myGrid.AutoResizeColumns()
        rowCounter = dSet.Tables("Results").Rows.Count

        'Set Value of first cell in total column
        myGrid.Rows(0).Cells(12).Value = 54
    End Sub
    '
    ' -> Adding new total column and adding values to new column
    ' -> Resizing all columns and updating row-counter


    Private Sub LoadInsertRecord(sender As Object, e As EventArgs) Handles InsertButton.Click, LoadButton.Click
        If CType(sender, Button).Name.ToString = "InsertButton" Then
            rowCounter += 1
            dAdapter.InsertCommand = New OleDbCommand("INSERT INTO People (PPSN, FirstName, Surname, 5N2928, 5N2929, 5N0548, 5N2434, 5N2927, 5N18396, 5N0783, 5N0690, 5N1356) Values ('" & rowCounter & "', '" & txtFname.Text & "', '" & txtLname.Text & "', '" & txtAddress.Text & "', '" & txtAge.Text & "')", dConnect)
            dAdapter.InsertCommand.ExecuteNonQuery()
        End If
        FillGrid()
    End Sub
    '
    ' -> Load / Insert New Record


    Private Sub MiscClick(sender As Object, e As EventArgs) Handles Newbut.Click
        Dim x As String
        Dim y As Integer
        y = myGrid.CurrentRow.Index
        x = ""
        For Each dgvRow In myGrid.SelectedRows
            x = dgvRow.Cells("PPSN").Value.ToString
        Next
        MsgBox(y)
    End Sub


    '   Temporary links commented leading to resources for code used in my assignment
    '
    'write to column?
    'https://social.msdn.microsoft.com/Forums/vstudio/en-US/0457f101-3caa-46a8-ba9e-dbd9e8bcc6a7/how-to-update-only-one-datagridview-column-from-database?forum=vbgeneral

    'adding via SQL
    'https://www.daniweb.com/programming/software-development/threads/369439/add-values-in-a-column-of-a-datagridview-in-vb-net

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

    ' how to make vb.net scalable window 
    ' https://www.techrepublic.com/article/manage-winform-controls-using-the-anchor-And-dock-properties/

    ' -> Returns value from NameID of the selected row
    ' -> Gets cell index
    ' ->   https://social.msdn.microsoft.com/Forums/windows/en-US/7ce81f9a-7047-444d-b75b-ef548b2ec635/datagridview-select-rows-and-retrieve-the-values-of-the-cells?forum=winformsdatacontrols
    ' -> https://www.daniweb.com/programming/software-development/threads/94061/get-the-selected-row-in-datagridview

End Class