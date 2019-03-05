Imports System.Data.OleDb

Public Class Main
    Private rowCounter As New Int16, dAdapter As New OleDbDataAdapter, dSet As DataSet = New DataSet
    Private dConnect As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\Resources\CAO.accdb")
    ' -- Note: You need Microsoft Access Engine 2010 to use OleDBCommand
    ' -> Instantiating my data adapter and data set


    Private Sub MyProject(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dConnect.Open()
        Catch ex As Exception
            MsgBox("Error. Couldn't connect to Access database.")
        End Try
        FillGrid()
        CreateTotalsColumn()
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


    'creating column
    'https://stackoverflow.com/questions/8730765/vb-net-adding-columns-to-datagridviews-in-a-list
    Private Sub CreateTotalsColumn()
        myGrid.Columns.Add("TotalPoints", "CAO Points")
        For i = 0 To (myGrid.Columns.Count - 1)
            myGrid.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        rowCounter = dSet.Tables("Results").Rows.Count
        myGrid.AutoResizeColumns()

        Dim grade As New Integer, points As New Double
        For row As Integer = 0 To rowCounter - 1
            points = 0
            For col As Integer = 3 To 11
                grade = myGrid.Rows(row).Cells(col).Value
                points += ConvertGrade(grade)
            Next
            myGrid.Rows(row).Cells(12).Value = points
        Next
    End Sub
    Public Function ConvertGrade(x As Integer) As Double
        Return If(x >= 80, 38.75,
               If(x >= 65 And x < 80, 32.5,
               If(x >= 50 And x < 65, 16.35, 0)))
    End Function
    '
    ' -> Adding new total column and adding values to new column
    ' -> Resizing all columns and updating row-counter


    Private Sub LoadInsertRecord(sender As Object, e As EventArgs) Handles InsertButton.Click, LoadButton.Click
        If CType(sender, Button).Name.ToString = "InsertButton" Then
            rowCounter += 1
            dAdapter.InsertCommand = New OleDbCommand("INSERT INTO People (PPSN, FirstName, Surname, 5N2928, 5N2929, 5N0548, 5N2434, 5N2927, 5N18396, 5N0783, 5N0690, 5N1356) Values ('" & rowCounter & "')", dConnect) ' & "', '" & txtFname.Text & "', '" & txtLname.Text & "', '" & txtAddress.Text & "', '" & txtAge.Text & "')", dConnect)
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