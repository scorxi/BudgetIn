Imports System.Data.SqlClient
Public Class FormDashboard
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Guna2Button1.Image = gambar
        Label1.Text = kategori
        Label2.Text = uang
        Label3.Text = catatan

        Dim conl As SqlConnection = New SqlConnection("Data Source=HOME-PC;initial catalog=DB_BUDGETIN;integrated security=true")
        conl.Open()

        Dim strsql As String
        strsql = "select format(Tanggal, 'dddd, MMMM, yyyy')as Tanggal,Kategori,Jumlah,Catatan from Table_Transaction where tanggal IN(select MAX(tanggal) from Table_Transaction)"
        Dim cmd As New SqlCommand(strsql, conl)

        Dim myreader As SqlDataReader
        myreader = cmd.ExecuteReader

        myreader.Read()
        Label12.Text = myreader("Tanggal")
        Label1.Text = myreader("Kategori")
        Label2.Text = "Rp. " & myreader("Jumlah")
        Label3.Text = myreader("Catatan")

        conl.Close()

        conl.Open()
        Dim strex As String
        strex = "select  SUM(Jumlah) from Table_Transaction"
        Dim cmdb As New SqlCommand(strex, conl)

        Dim myreaderb As SqlDataReader
        myreaderb = cmdb.ExecuteReader

        myreaderb.Read()
        TextBox4.Text = myreaderb("")


        conl.Close()

        conl.Open()
        Dim strin As String
        strin = "select SUM(Jumlah) from Table_Income1"
        Dim cmdi As New SqlCommand(strin, conl)

        Dim myreaderi As SqlDataReader
        myreaderi = cmdi.ExecuteReader

        myreaderi.Read()
        TextBox1.Text = myreaderi("")
        conl.Close()

        TextBox5.Text = Val(TextBox1.Text) - Val(TextBox4.Text)

        conl.Open()
        Dim strb As String
        strb = "select SUM(Jumlah) from Table_budget1"
        Dim cmdbu As New SqlCommand(strb, conl)

        Dim myreaderbu As SqlDataReader
        myreaderbu = cmdbu.ExecuteReader

        myreaderbu.Read()
        TextBox6.Text = myreaderbu("")
        conl.Close()

        conl.Open()
        Dim strs As String
        strs = "select SUM(Jumlah) from Table_Planning1"
        Dim cmds As New SqlCommand(strs, conl)

        Dim myreaders As SqlDataReader
        myreaders = cmds.ExecuteReader

        myreaders.Read()
        TextBox7.Text = Val(TextBox6.Text) - myreaders("")
        conl.Close()

    End Sub


End Class