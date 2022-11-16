Imports System.Data.SqlClient
Imports System.Data
Public Class FormTransaction
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Label1.Text = "Makanan"
        gamarButton(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kategori = Label1.Text
        uang = TextBox1.Text
        catatan = TextBox2.Text
        tanggal = Date.Now.ToString("dd-MM-yyyy")
        tgl = Date.Now.ToString("dd-MM-yyyy")
        gambar = iconjadi.Image

        Dim kat As String = Label1.Text
        Dim tangal As Date = Guna2DateTimePicker1.Text
        Dim jmlh As String = TextBox1.Text
        Dim ket As String = TextBox2.Text
        Dim query As String = "INSERT INTO Table_Transaction VALUES (@Tanggal,@Kategori,@Jumlah,@Catatan)"
        Dim query2 As String = "INSERT INTO Table_Income1 VALUES (@Tanggal,@Kategori,@Jumlah,@Catatan)"
        Using conTrans As SqlConnection = New SqlConnection("Data Source=HOME-PC;initial catalog=DB_BUDGETIN;integrated security=true")
            conTrans.Open()

            If kat = "Salary" Or kat = "Budgeting" Then

                Using cmd As SqlCommand = New SqlCommand(query2, conTrans)
                    cmd.Parameters.AddWithValue("@Kategori", kat)
                    cmd.Parameters.AddWithValue("@Tanggal", tangal)
                    cmd.Parameters.AddWithValue("@Jumlah", jmlh)
                    cmd.Parameters.AddWithValue("@Catatan", ket)
                    cmd.ExecuteNonQuery()

                End Using

            Else

                Using cmd As SqlCommand = New SqlCommand(query, conTrans)
                            cmd.Parameters.AddWithValue("@Kategori", kat)
                            cmd.Parameters.AddWithValue("@Tanggal", tangal)
                            cmd.Parameters.AddWithValue("@Jumlah", jmlh)
                            cmd.Parameters.AddWithValue("@Catatan", ket)
                    cmd.ExecuteNonQuery()

                End Using


                End If

            conTrans.Close()
            Label1.Text = "Pick Category"
            Guna2DateTimePicker1.Text = ""
                TextBox1.Text = ""
                TextBox2.Text = ""
            MessageBox.Show("Transaksi Telah ditambahkan", "Transaction Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Label1.Text = "Pet"
        gamarButton(sender, e)

    End Sub


    Public gamar As Guna.UI2.WinForms.Guna2Button
    Public Sub gamarButton(senderBtn As Object, e As EventArgs)
        gamar = CType(senderBtn, Guna.UI2.WinForms.Guna2Button)
        'current from icon
        iconjadi.Image = gamar.Image
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Label1.Text = "Salary"
        gamarButton(sender, e)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Label1.Text = "Mechanic"
        gamarButton(sender, e)
    End Sub

    Private Sub FormTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class