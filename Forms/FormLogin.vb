Imports System.Data.SqlClient
Imports System.Data

Public Class FormLogin
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        animation1.HideSync(p2)
        animation1.ShowSync(p3)
    End Sub

    Private Sub btnx_Click(sender As Object, e As EventArgs) Handles btnx.Click
        animation1.HideSync(p3)
        animation1.ShowSync(p2)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim conlogin As SqlConnection = New SqlConnection("Data Source=HOME-PC;initial catalog=DB_BUDGETIN;integrated security=true")
        Dim cmdlogin As SqlCommand = New SqlCommand("select * from Table_Login where UserName='" + tbUser.Text + "' and Password='" + tbpwd.Text + "'", conlogin)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmdlogin)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then
            Form2.btnDashboard.PerformClick()
            Form2.IconButton1.Hide()
            Form2.IconButton2.Show()

        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim username As String = Guna2TextBox2.Text
        Dim email As String = Guna2TextBox3.Text
        Dim pwd As String = Guna2TextBox4.Text

        Dim query As String = "INSERT INTO Table_Login VALUES (@UserName,@Password,@Email)"
        Using con As SqlConnection = New SqlConnection("Data Source=HOME-PC;initial catalog=DB_BUDGETIN;integrated security=true")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@UserName", username)
                cmd.Parameters.AddWithValue("@Password", pwd)
                cmd.Parameters.AddWithValue("@Email", email)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                Guna2TextBox2.Text = ""
                Guna2TextBox3.Text = ""
                Guna2TextBox4.Text = ""
                MessageBox.Show("Akun telah terdaftar silahkan Log in", "Register Akun", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Using
        End Using

    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover

        tbpwd.UseSystemPasswordChar = False
    End Sub

    Private Sub Guna2Button2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        tbpwd.UseSystemPasswordChar = True
    End Sub


End Class