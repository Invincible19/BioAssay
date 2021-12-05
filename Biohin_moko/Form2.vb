Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept letters only!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Guna2TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept letters only!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Guna2TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox3.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept letters only!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    
    Private Sub Guna2TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept numbers only!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Guna2TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox5.KeyPress
        If Guna2TextBox5.Text.Length >= 11 Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MsgBox("This field will accept limit numbers only", MsgBoxStyle.Exclamation)
            End If

        End If

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept numbers only!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Guna2TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox6.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept letters only!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Guna2TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox8.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MsgBox("This field will accept numbers only!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class