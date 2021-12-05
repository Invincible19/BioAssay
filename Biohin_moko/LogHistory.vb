Imports MySql.Data.MySqlClient
Public Class LogHistory
    Dim str As String = "server=localhost;uid=root;pwd=;database=clinic;Convert Zero Datetime=True"
    Dim con As New MySqlConnection(Str)
    Dim cmd As New MySqlCommand
    Dim dbDataSet As New DataTable
    Public Sub log()

        Dim query As String = "select * from logtrail;"
        Dim adptr As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adptr.Fill(ds, "logtrail")
        Guna2DataGridView1.DataSource = ds.Tables("logtrail")
        con.Close()
    End Sub

    Private Sub LogHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        log()
    End Sub


    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Dashboard.Show()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
End Class