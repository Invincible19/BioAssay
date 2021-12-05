Imports MySql.Data.MySqlClient
Public Class ManageAccount
    Dim str As String = "server=localhost;uid=root;pwd=;database=clinic;Convert Zero Datetime=True"
    Dim con As New MySqlConnection(str)
    Dim cmd As New MySqlCommand
    Dim id As Integer
    Dim dbDataSet As New DataTable
    Public Sub log()

        Dim query As String = "select FirstName, LastName, Username ,Password, Contact, Position from accounts"
        Dim adptr As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adptr.Fill(ds, "accounts")
        Guna2DataGridView1.DataSource = ds.Tables("accounts")
        con.Close()
    End Sub

    Private Sub ManageAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        log()

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Try
            If Guna2TextBox1.Text <> "" And Guna2TextBox2.Text <> "" Then
                Dim query As String = "INSERT INTO accounts (LastName, FirstName, Username, Password, Contact, Position) VALUES ('" & Guna2TextBox1.Text & "', '" & Guna2TextBox2.Text & "', '" & Guna2TextBox3.Text & "', '" & Guna2TextBox4.Text & "', '" & Guna2TextBox5.Text & "', '" & Guna2TextBox6.Text & "')"
                con.Open()
                cmd.CommandText = query
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Add Accounts Successfully")
                Guna2TextBox1.Text = ""
                Guna2TextBox2.Text = ""
                Guna2TextBox3.Text = ""
                Guna2TextBox4.Text = ""
                Guna2TextBox5.Text = ""
                Guna2TextBox6.Text = ""
                log()
            Else
                MessageBox.Show("Fill up the blanks")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            con.Dispose()
        End Try
    End Sub


    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        Dim query As String

        If MsgBox("Are you sure you want to remove employee?", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation) = MsgBoxResult.Ok Then

            Try
                con.Open()
                query = " delete from accounts where FirstName='" & Guna2TextBox1.Text & "'"
                cmd = New MySqlCommand(query, con)
                cmd.CommandText = query
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Successfully removed!", MsgBoxStyle.Information)

                log()


            Catch ex As Exception
                MsgBox(ex.Message)

            Finally
                con.Dispose()


            End Try
        End If

    End Sub



    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        Guna2TextBox1.Text = Guna2DataGridView1.Item("FirstName", Guna2DataGridView1.CurrentRow.Index).Value
        Guna2TextBox2.Text = Guna2DataGridView1.Item("LastName", Guna2DataGridView1.CurrentRow.Index).Value
        Guna2TextBox3.Text = Guna2DataGridView1.Item("Username", Guna2DataGridView1.CurrentRow.Index).Value
        Guna2TextBox4.Text = Guna2DataGridView1.Item("Password", Guna2DataGridView1.CurrentRow.Index).Value
        Guna2TextBox5.Text = Guna2DataGridView1.Item("Contact", Guna2DataGridView1.CurrentRow.Index).Value
        Guna2TextBox6.Text = Guna2DataGridView1.Item("Position", Guna2DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
        Guna2TextBox3.Text = ""
        Guna2TextBox4.Text = ""
        Guna2TextBox5.Text = ""
        Guna2TextBox6.Text = ""

    End Sub

    Private Sub Guna2GradientButton2_Click_1(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        If Guna2GradientButton2.Text = "EDIT" Then
            Guna2TextBox1.Enabled = True
            Guna2TextBox2.Enabled = True
            Guna2TextBox3.Enabled = True
            Guna2TextBox4.Enabled = True
            Guna2TextBox5.Enabled = True
            Guna2TextBox6.Enabled = True

            Guna2GradientButton2.Text = "UPDATE"
            Guna2GradientButton1.Enabled = False

        ElseIf Guna2GradientButton2.Text = "UPDATE" Then
            Dim query As String
            Try
                con.Open()
                query = "UPDATE accounts SET FirstName = '" & Guna2TextBox1.Text & "', LastName = '" & Guna2TextBox2.Text & "', Username = '" & Guna2TextBox3.Text & "', Password = '" & Guna2TextBox4.Text & "', Contact = '" & Guna2TextBox5.Text & "', Position = '" & Guna2TextBox6.Text & "' WHERE ID = '" & Guna2TextBox7.Text & "'"
                cmd = New MySqlCommand(query, con)
                cmd.ExecuteNonQuery()

                MsgBox("Successfully updated!", MsgBoxStyle.Information)
                Guna2TextBox1.Enabled = False
                Guna2TextBox2.Enabled = False
                Guna2TextBox3.Enabled = False
                Guna2TextBox4.Enabled = False
                Guna2TextBox5.Enabled = False
                Guna2TextBox6.Enabled = False

                Guna2GradientButton1.Enabled = True
                Guna2GradientButton2.Text = "EDIT"
            Catch ex As Exception
            Finally
                con.Dispose()
            End Try


        End If
    End Sub

    Private Sub Guna2TextBox5_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Fields only Accepts Numbers only")
        End If
    End Sub

End Class