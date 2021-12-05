Imports MySql.Data.MySqlClient
Public Class Dashboard

    Public logintime01 As String
    'connection sa database'
    Dim str As String = "server = localhost; uid = root; pwd=; database = clinic; convert zero datetime=True"
    Dim con As New MySqlConnection(str)


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = Date.Now.ToString("dd-MMM-yyy")
        Label9.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub




    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Organizational_Chart.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        LogHistory.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        logintime01 = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim cmd As New MySqlCommand
        Dim Query1 As String = "select*from logtrail"
        Dim cmda As New MySqlCommand(Query1, con)
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Try
            cmda = con.CreateCommand()
            cmda.CommandText = "UPDATE `logtrail` SET logout=@logout where username=@Username and login=@login"
            cmda.Parameters.AddWithValue("@Username", LOGIN.Guna2TextBox1.Text)
            cmda.Parameters.AddWithValue("@login", LOGIN.logintime)
            cmda.Parameters.AddWithValue("@logout", logintime01)
            cmda.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        If MessageBox.Show("Do you want to LogOut?", "LogOut", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
            Me.Hide()
            LOGIN.Show()
            LOGIN.Guna2TextBox1.Clear()
            LOGIN.Guna2TextBox2.Clear()
            MsgBox("LogOut Successfully!", MsgBoxStyle.Information)
        End If
    End Sub

   
    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Settings.Show()
        Me.Hide()

    End Sub
End Class