Imports MySql.Data.MySqlClient
Imports System.IO
Public Class BackupnRestore

    Dim con As New MySqlConnection("server = localhost; uid = root; pwd=; database = clinic")
    Dim dt As New DataTable
    Dim cmd As String
    Dim dtSect As Integer
    Dim da As MySqlDataAdapter
    Dim Path As String
    Dim BackupPath As String
    Dim DatabaseName As String = "clinic " + Date.Now.ToString("dd-MM-yyyy HH-mm-ss")
    Sub Backup()
        Try
            If Not Directory.Exists(BackupPath) Then
                Directory.CreateDirectory(BackupPath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "-u root clinic -r """ & BackupPath & "" & DatabaseName & ".sql""")
        MsgBox("Backup Created Successfully!", MsgBoxStyle.Information, "Backup")
    End Sub

    Sub Restore()
        Dim myProcess As New Process()

        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.Start()
        Dim myStreamerWriter As StreamWriter = myProcess.StandardInput
        Dim myStreamerReader As StreamReader = myProcess.StandardOutput
        myStreamerWriter.WriteLine("mysql -u root sia < " & Path & "")
        myStreamerWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
    End Sub


    Public Sub koneksi()
        Try
            con.Open()
            con = New MySqlConnection("Server=" & Guna2TextBox1.Text & ";UserID=" & Guna2TextBox2.Text & ";Password=" & Guna2TextBox3.Text & ";")
            If con.State = ConnectionState.Closed Then

                con.Close()

            End If

        Catch ex As Exception
            MsgBox("Connection filed")

        End Try
    End Sub

    Private Sub Guna2GradientButton1_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        Try
            koneksi()
            cmd = "SELECT DISTINCT TABLE_SCHEMA FROM information_schema.TABLES"
            da = New MySqlDataAdapter(cmd, con)
            da.Fill(dt)
            dtSect = 0

            Guna2ComboBox1.Enabled = True
            Guna2ComboBox1.Items.Clear()
            Guna2ComboBox1.Items.Add("== Select database == ")

            While dtSect < dt.Rows.Count

                Guna2ComboBox1.Items.Add(dt.Rows(dtSect)(0).ToString())
                dtSect = dtSect + 1

            End While
            Guna2ComboBox1.SelectedIndex = 0
            Guna2GradientButton1.Enabled = False
            Guna2GradientButton2.Enabled = True
            Guna2GradientButton3.Enabled = True

            con.Clone()
            dt.Dispose()
            da.Dispose()

        Catch ex As Exception
            MsgBox("Connection filed")
        End Try

    End Sub

    Private Sub Guna2GradientButton2_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        FolderBrowserDialog1.ShowDialog()
        BackupPath = FolderBrowserDialog1.SelectedPath.ToString() + "\"
        Backup()
    End Sub

    Private Sub Guna2GradientButton3_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Path = OpenFileDialog1.FileName.ToString()
        Restore()
        MsgBox("Database Restoration Successfully!", MsgBoxStyle.Information, "Restore")
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class