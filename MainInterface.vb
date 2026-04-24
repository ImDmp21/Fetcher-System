Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto
Imports System.Configuration
Imports System.Drawing.Drawing2D
Imports System.IO
Imports ZXing
Imports ZXing.Common
Imports ZXing.QrCode

Public Class MainInterface
    ' Database Connection
    Dim connection As New MySqlConnection(connectionString)

    ' Open Student Info Form
    Private Sub AddStudent_Click(sender As Object, e As EventArgs)
        Dim studentInfoForm As New StudentInfo()
        studentInfoForm.ShowDialog()
    End Sub

    ' Load Student Data
    Private Sub LoadStudents()
        Try
            ' Ensure connection is closed before opening
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim query As String = "SELECT id, name, lrn, grade_section, guardian_contact FROM students ORDER BY id DESC"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()

            connection.Open()
            adapter.Fill(table)
            connection.Close()

            MIDataTable.DataSource = table  ' Update DataGridView

        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message)
        End Try
    End Sub

    Private Function FindStudent()
        Dim query As String = "SELECT * FROM students WHERE id='" + hiddenID.Text + "';"
        Dim adapter As New MySqlDataAdapter(query, connection)
        Dim table As New DataTable()

        connection.Open()
        adapter.Fill(table)
        connection.Close()

        Console.WriteLine(table.Rows(0).Item("guardian_key"))
        Return table.Rows(0)
    End Function
    Private Sub UpdateStatus(status)
        Dim query As String = "UPDATE students SET status=@status WHERE id=@id"
        Dim cmd As New MySqlCommand(query, connection)

        ' Assign values
        cmd.Parameters.AddWithValue("@status", status)
        cmd.Parameters.AddWithValue("@id", hiddenID.Text)

        ' Execute query
        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()

    End Sub

    ' Load data when Main Interface opens
    Private Sub MainInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    Private Sub Student_onClick(sender As Object, e As EventArgs) Handles MIDataTable.CellClick
        Dim selectedRow = MIDataTable.SelectedRows


        For Each row As DataGridViewRow In selectedRow
            hiddenID.Text = row.Cells(0).Value.ToString
            MIName.Text = row.Cells(1).Value.ToString
            MILRN.Text = row.Cells(2).Value.ToString
            MIGrade.Text = row.Cells(3).Value.ToString
            MIGuardian.Text = row.Cells(4).Value.ToString
            'Console.WriteLine(row.Cells(0).Value.ToString)
        Next row
        Dim student = FindStudent()
        Console.WriteLine(student.Item("status"))
        If student.Item("status") = "out" Then
            ButtonOUT.Text = "In"
        Else
            ButtonOUT.Text = "Out"
        End If
    End Sub


    Private Sub MISearchBar_TextChanged(sender As Object, e As EventArgs) Handles MISearchBar.TextChanged
        Try
            ' Ensure connection is closed before opening
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            ' Prepare query
            Dim query As String = "SELECT * FROM students WHERE name LIKE @search OR lrn LIKE @search"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@search", "%" & MISearchBar.Text & "%")

            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            ' Open connection safely
            connection.Open()
            adapter.Fill(table)
            connection.Close()

            MIDataTable.DataSource = table  ' Update DataGridView

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Function ReadQRCode()
        Dim reader = New QRCodeReader()
        Dim fileName As String = Open_File()
        Try
            Dim MyBitmap As New Bitmap(fileName)
            Dim binaryBmp As New BinaryBitmap(New HybridBinarizer(New BitmapLuminanceSource(MyBitmap)))
            Dim result = reader.decode(binaryBmp)
            Return result
        Catch ex As Exception
            Console.WriteLine(ex)
            Return ""
        End Try


    End Function
    Public Shared Function GetArrayFromImage(image As Image) As Byte()
        If image IsNot Nothing Then
            Dim ic As New ImageConverter()
            Dim buffer As Byte() = DirectCast(ic.ConvertTo(image, GetType(Byte())), Byte())
            Return buffer
        Else
            Return Nothing
        End If
    End Function

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Dim StudentInfo As New StudentInfo()
        StudentInfo.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Region = New Region(path)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim StudentInfo As New StudentInfo()
        StudentInfo.Show()
        Me.Close()
    End Sub
    Private Function Open_File()
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = ""

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If
        Return strFileName
    End Function

    Private Sub ButtonOUT_Click(sender As Object, e As EventArgs) Handles ButtonOUT.Click
        Dim student = FindStudent()
        If student.Item("status") = "out" Then
            UpdateStatus("in")
        Else
            Dim uploadedQR = ReadQRCode()
            Dim qrString = uploadedQR.ToString()
            If qrString = student.Item("guardian_key") Then
                MessageBox.Show("Verified")
                UpdateStatus("out")

            Else
                MessageBox.Show("Unauthorized")
            End If
        End If


    End Sub
End Class


