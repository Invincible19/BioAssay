
Imports MySql.Data.MySqlClient

Public Class LOGIN

    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Dim counter As Integer
    Dim Timer As Integer
    Dim dt As New DataTable
    Public logintime
    Dim str As String = "server = localhost; uid = root; pwd=; database = clinic;"
    Dim con As New MySqlConnection(Str)

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        counter = 0
        Timer = 30
        Timer2.Interval = 1000
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd-MMM-yyy")
        Label3.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub


    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim Query1 As String = "select*from logtrail"
        Dim cmda As New MySqlCommand(Query1, con)
        logintime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim logout As String = ""

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Dim adapter = New MySqlDataAdapter("Select * from accounts where Username = '" & Guna2TextBox1.Text & "' AND Password= '" & Guna2TextBox2.Text & "'", con)
        dt = New DataTable
        adapter.Fill(dt)

        If Guna2TextBox1.Text = "" And Guna2TextBox2.Text = "" Then
            MessageBox.Show("Please Fill Up all the Fields!", "Fill Up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf dt.Rows.Count() <= 0 Then
            MessageBox.Show("Invalid Username/Password.", "INVALID LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
            counter = counter + 1
            Guna2TextBox1.Clear()
            Guna2TextBox2.Clear()

            If counter = 3 Then
                MessageBox.Show("Trial limits exceed, Please wait for a few seconds to login again,Thank You!.", "Relogin Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Timer2.Start()
                Return
            End If
        Else
            Dim temp As String
            Dim cmd = New MySqlCommand("Select Position from accounts where Username= '" & Guna2TextBox1.Text & "' AND Password = '" & Guna2TextBox2.Text & "'", con)
            temp = Convert.ToString(cmd.ExecuteScalar())

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Try
                cmda = con.CreateCommand()
                cmda.CommandText = "insert into logtrail(log_no,Username,login,Position)values(@log_no,@Username,@login,@Position)"
                cmda.Parameters.AddWithValue("@log_no", "")
                cmda.Parameters.AddWithValue("@Username", Guna2TextBox1.Text)
                cmda.Parameters.AddWithValue("@login", logintime)
                cmda.Parameters.AddWithValue("Position", temp)
                cmda.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
            End Try

            If temp = "Staff" Then
                MessageBox.Show("Log-In As Staff!", "STAFF", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Dashboard.Show()
                Dashboard.Guna2Button8.Enabled = False
                Dashboard.Guna2Button5.Enabled = False

            ElseIf temp = "Admin" Then
                MessageBox.Show("Log-In As Administrator!", "ADMINISTRATOR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide()
                Dashboard.Show()
                
            End If
        End If
        con.Close()
    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Guna2TextBox1_Enter(sender As Object, e As EventArgs) Handles Guna2TextBox1.Enter

        If Guna2TextBox1.Text = "Enter Your Username" Then
            Guna2TextBox1.Text = ""
            Guna2TextBox1.ForeColor = Color.Black

        End If
    End Sub
    Private Sub Guna2TextBox1_Leave(sender As Object, e As EventArgs) Handles Guna2TextBox1.Leave
        If Guna2TextBox1.Text = "" Then
            Guna2TextBox1.Text = "Enter Your Username"
            Guna2TextBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub Guna2TextBox2_Enter(sender As Object, e As EventArgs) Handles Guna2TextBox2.Enter
        If Guna2TextBox2.Text = "Enter Your Password" Then
            Guna2TextBox2.Text = ""
            Guna2TextBox2.PasswordChar = "*"
            Guna2TextBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Guna2TextBox2_Leave(sender As Object, e As EventArgs) Handles Guna2TextBox2.Leave
        If Guna2TextBox2.Text = "Enter Your Password" Then
            Guna2TextBox2.Text = ""
            Guna2TextBox2.PasswordChar = "*"
            Guna2TextBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Guna2TextBox2.UseSystemPasswordChar = False
        Else
            Guna2TextBox2.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer = Timer - 1
        If Timer <> 0 Then
            Guna2TextBox2.Text = "Wait for 30 seconds"
            Guna2TextBox1.Text = "Wait for 30 seconds"
            Guna2GradientButton1.Text = "Disabled (" & Timer & ")"
            Guna2TextBox1.Enabled = False
            Guna2TextBox2.Enabled = False
            Guna2GradientButton1.Enabled = False

        Else
            Timer2.Stop()
            Timer = 15
            counter = 0
            Guna2TextBox2.Text = ""
            Guna2TextBox1.Text = ""
            Guna2GradientButton1.Text = "Log-in"
            Guna2TextBox2.Enabled = True
            Guna2TextBox1.Enabled = True
            Guna2GradientButton1.Enabled = True
        End If
    End Sub

End Class
