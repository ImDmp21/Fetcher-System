Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports QRCoder
Imports ZXing.QrCode
Imports Org.BouncyCastle.Asn1.Ocsp
Public Class StudentInfo
    'Establishing connection of database in phpmyadmin
    Dim connection As New MySqlConnection(connectionString)
    Private qrCodeGenerator As QRCodeGenerator = New QRCodeGenerator
    Private key
    Private Sub OpenConnection()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Database Connection Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CloseConnection()
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error closing connection: " & ex.Message)
        End Try
    End Sub

    'For Readability and Organized Inputting of Data
    Private Sub StudentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set placeholder text using Tag property
        SetPlaceholder(DisplayName, "Enter Student's Name")
        SetPlaceholder(DisplayLRN, "Enter LRN")
        SetPlaceholder(DisplayGrade, "Enter Grade/Section")
        SetPlaceholder(DisplayGuardian, "Enter Guardian's Contact")

        ' Make profile picture circular
        Dim path As New Drawing2D.GraphicsPath()
        path.AddEllipse(0, 0, PicProfile.Width, PicProfile.Height)
        PicProfile.Region = New Region(path)

        Me.KeyPreview = True
    End Sub
    Private Sub CenterPanel()
        If Panel1 IsNot Nothing Then ' Assuming you have a panel named Panel1
            Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
            Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
        End If
    End Sub


    Private Sub StudentInfo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.B AndAlso e.Alt Then
            Me.Close()
            MainInterface.Show()
        End If
    End Sub
    Private Sub SetPlaceholder(txt As TextBox, placeholder As String)
        txt.Tag = placeholder
        txt.Text = placeholder
        txt.ForeColor = Color.Gray
    End Sub

    Private Sub txt_Enter(sender As Object, e As EventArgs) Handles DisplayName.Enter, DisplayLRN.Enter, DisplayGrade.Enter, DisplayGuardian.Enter
        Dim txt As TextBox = CType(sender, TextBox)
        If txt.ForeColor = Color.Gray Then
            txt.Text = ""
            txt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_Leave(sender As Object, e As EventArgs) Handles DisplayName.Leave, DisplayLRN.Leave, DisplayGrade.Leave, DisplayGuardian.Leave
        Dim txt As TextBox = CType(sender, TextBox)
        If String.IsNullOrWhiteSpace(txt.Text) Then
            txt.Text = txt.Tag.ToString()
            txt.ForeColor = Color.Gray
        End If
    End Sub

    ' Uploading Student's Profile Picture
    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Dispose of the old image safely
                If PicProfile.Image IsNot Nothing Then
                    Dim oldImage As Image = PicProfile.Image
                    PicProfile.Image = Nothing
                    oldImage.Dispose()
                End If

                ' Load new image
                Using img As Image = Image.FromFile(openFileDialog.FileName)
                    PicProfile.Image = New Bitmap(img)
                End Using

            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub

    ' Saving Student's Info
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        ' Validate fields
        If DisplayName.Text.Trim() = "" Or DisplayLRN.Text.Trim() = "" Or DisplayGrade.Text.Trim() = "" Or DisplayGuardian.Text.Trim() = "" Then
            MessageBox.Show("Error: Please complete all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            OpenConnection()

            ' Prepare query
            Dim query As String = "INSERT INTO students (name, lrn, grade_section, guardian_contact, guardian_key, profile_pic, status) VALUES (@name, @lrn, @grade, @guardian, @key, @pic, @status)"
            Dim cmd As New MySqlCommand(query, connection)

            ' Assign values
            cmd.Parameters.AddWithValue("@name", DisplayName.Text)
            cmd.Parameters.AddWithValue("@lrn", DisplayLRN.Text)
            cmd.Parameters.AddWithValue("@grade", DisplayGrade.Text)
            cmd.Parameters.AddWithValue("@guardian", DisplayGuardian.Text)
            cmd.Parameters.AddWithValue("@key", key)
            cmd.Parameters.AddWithValue("@status", "out")
            ' Convert image to byte array
            If PicProfile.Image IsNot Nothing Then
                Dim ms As New System.IO.MemoryStream()
                PicProfile.Image.Save(ms, Imaging.ImageFormat.Png)
                cmd.Parameters.AddWithValue("@pic", ms.ToArray())
            Else
                cmd.Parameters.AddWithValue("@pic", DBNull.Value)
            End If

            ' Execute query
            cmd.ExecuteNonQuery()

            MessageBox.Show("Student information saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try

        Dim MainInterface As New MainInterface()
        MainInterface.Show()
        Me.Close()
    End Sub

    Private Sub PicProfile_Click(sender As Object, e As EventArgs) Handles PicProfile.Click

    End Sub

    Private Sub GenerateQR_Click(sender As Object, e As EventArgs) Handles GenerateQR.Click

        Dim qrCodeGenerator As QRCodeGenerator = New QRCodeGenerator()
        key = GenerateRandomNumber()
        Dim qrCodeData As QRCodeData = qrCodeGenerator.CreateQrCode(key, QRCodeGenerator.ECCLevel.H)
        Dim qrCode As QRCode = New QRCode(qrCodeData)
        Dim qrCodeImage As Bitmap = qrCode.GetGraphic(10)

        qrCodeImageBox.Image = qrCodeImage
        qrCodeImageBox.SizeMode = PictureBoxSizeMode.CenterImage

        Dim savePath As String = Save_Path()
        Dim qrFile As String = IO.Path.Combine(savePath, "qrCode.png")
        Console.WriteLine(qrFile)
        qrCodeImage.Save(qrFile)
        GenerateQR.Enabled = False
        ButtonSave.Enabled = True
    End Sub

    Private Function GenerateRandomNumber()
        Dim rnd As New Random()
        Dim key As String = ""
        Dim randomNum As Integer
        For index As Integer = 1 To 16
            randomNum = rnd.Next(0, 10)
            key += randomNum.ToString
        Next

        Return key
    End Function
    Private Function Save_Path()
        Dim fd As FolderBrowserDialog = New FolderBrowserDialog()
        Dim strFileName As String = ""



        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.SelectedPath
        End If
        Return strFileName
    End Function
End Class
