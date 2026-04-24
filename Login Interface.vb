Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe


Public Class Form1
    ' Define the MySQL connection string

    ' Default placeholder texts
    Private Const usernamePlaceholder As String = "Enter Username"
    Private Const passwordPlaceholder As String = "Enter Password"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default placeholder text on form load
        SetPlaceholder(LoginTextUsername, "Enter Username")
        SetPlaceholder(LoginTextPassword, "Enter Password", True)

        ' Increase font size
        LoginTextUsername.Font = New Font("Serogue IU", 14, FontStyle.Regular)
        LoginTextPassword.Font = New Font("Serogue IU", 14, FontStyle.Regular)
        lblMessage.Font = New Font("Serogue IU", 12, FontStyle.Bold)
    End Sub

    ' Set placeholder for textboxes
    Private Sub SetPlaceholder(txt As TextBox, placeholder As String, Optional isPassword As Boolean = False)
        If String.IsNullOrEmpty(txt.Text) Then
            txt.Text = placeholder
            txt.ForeColor = Color.Gray
            If isPassword Then
                txt.PasswordChar = ControlChars.NullChar ' Show plain text when placeholder is active
            End If
        End If
    End Sub

    ' Remove placeholder when textbox gains focus
    Private Sub RemovePlaceholder(txt As TextBox, placeholder As String, Optional isPassword As Boolean = False)
        If txt.Text = placeholder Then
            txt.Text = ""
            txt.ForeColor = Color.Black
            If isPassword Then
                txt.UseSystemPasswordChar = True ' Enable password masking when user types
            End If
        End If
    End Sub

    ' Handle placeholders for username textbox
    Private Sub LoginTextUsername_Enter(sender As Object, e As EventArgs) Handles LoginTextUsername.Enter
        RemovePlaceholder(LoginTextUsername, usernamePlaceholder)
    End Sub

    Private Sub LoginTextUsername_Leave(sender As Object, e As EventArgs) Handles LoginTextUsername.Leave
        SetPlaceholder(LoginTextUsername, usernamePlaceholder)
    End Sub

    ' Handle placeholders for password textbox
    Private Sub LoginTextPassword_Enter(sender As Object, e As EventArgs) Handles LoginTextPassword.Enter
        RemovePlaceholder(LoginTextPassword, "Enter Password", True)
    End Sub

    Private Sub LoginTextPassword_Leave(sender As Object, e As EventArgs) Handles LoginTextPassword.Leave
        SetPlaceholder(LoginTextPassword, "Enter Password", True)
    End Sub

    ' Login button click event
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        ' Get input values
        Dim username As String = LoginTextUsername.Text
        Dim password As String = LoginTextPassword.Text

        ' Prevent placeholder text from being submitted
        If username = usernamePlaceholder OrElse password = passwordPlaceholder Then
            lblMessage.Text = "Please enter both username and password."
            lblMessage.ForeColor = Color.Red
            Exit Sub
        End If

        ' Ensure fields are not empty
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            lblMessage.Text = "Please enter both username and password."
            lblMessage.ForeColor = Color.Red
            Exit Sub
        End If

        ' Connect to MySQL database
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Console.WriteLine("Database connection opened.")

                ' Query to check user existence with hashed password
                Dim selectQuery As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = SHA2(@password, 256)"

                Using cmd As New MySqlCommand(selectQuery, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password) ' MySQL hashes this in the query

                    ' Execute query
                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Validate login
                    If result > 0 Then
                        lblMessage.Text = "Login successful!"
                        lblMessage.ForeColor = Color.Green
                        Dim mainForm As New MainInterface()
                        mainForm.Show()
                        Me.Hide()
                    Else
                        lblMessage.Text = "Invalid username or password."
                        lblMessage.ForeColor = Color.Red
                    End If
                End Using
            Catch ex As Exception
                lblMessage.Text = "Error: " & ex.Message
                Console.WriteLine(ex.Message)
                lblMessage.ForeColor = Color.Red
            Finally
                'conn.Close()
                Console.WriteLine("Database connection closed.")
            End Try
        End Using
    End Sub
End Class
