Imports System.Data.SqlClient
Public Class FormReport
    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = kategori

        Label2.Text = uang
        Label3.Text = catatan
        Label5.Text = tanggal

        Dim conl As SqlConnection = New SqlConnection("Data Source=HOME-PC;initial catalog=DB_BUDGETIN;integrated security=true")
        conl.Open()

        Dim strsql As String
        strsql = "select Kategori,Jumlah from Table_Transaction "
        Dim cmd As New SqlCommand(strsql, conl)

        Dim myreader As SqlDataReader
        myreader = cmd.ExecuteReader
        While myreader.Read()
            Dim kate As String = myreader("Kategori")
            Dim juml As String = myreader("Jumlah")
            Me.Chart1.Series("Rupiah").Points.AddXY(kate, juml)
        End While

        conl.Close()

        conl.Open()

        Dim strinc As String
        strinc = "select Kategori,Jumlah from Table_Income1 "
        Dim cmdic As New SqlCommand(strinc, conl)

        Dim myreaderic As SqlDataReader
        myreaderic = cmdic.ExecuteReader
        While myreaderic.Read()
            Dim kate As String = myreaderic("Kategori")
            Dim juml As String = myreaderic("Jumlah")
            Me.Chart2.Series("Rupiah").Points.AddXY(kate, juml)
        End While

        conl.Close()

        conl.Open()
        Dim strbln As String
        strbln = "select  format(Tanggal, 'MMMM') from Table_Transaction where tanggal IN(select MAX(tanggal) from Table_Transaction)"
        Dim cmdb As New SqlCommand(strbln, conl)

        Dim myreaderb As SqlDataReader
        myreaderb = cmdb.ExecuteReader

        myreaderb.Read()
        Label12.Text = myreaderb("")
        Label18.Text = myreaderb("")
        conl.Close()

        Guna2Button1.Image = gambar


        conl.Open()

        Dim strsq As String
        strsq = "select format(Tanggal, 'dddd, MMMM, yyyy') as Tanggal,Kategori,Jumlah,Catatan from Table_Transaction where tanggal IN(select MAX(tanggal) from Table_Transaction)"
        Dim cmdq As New SqlCommand(strsq, conl)

        Dim myreaderq As SqlDataReader
        myreaderq = cmdq.ExecuteReader

        myreaderq.Read()
        Label5.Text = myreaderq("Tanggal")
        Label1.Text = myreaderq("Kategori")
        Label2.Text = "Rp. " & myreaderq("Jumlah")
        Label3.Text = myreaderq("Catatan")

        conl.Close()

        conl.Open()
        Dim strex As String
        strex = "select  SUM(Jumlah) from Table_Transaction "
        Dim cmdx As New SqlCommand(strex, conl)

        Dim myreaderx As SqlDataReader
        myreaderx = cmdx.ExecuteReader

        myreaderx.Read()
        Label16.Text = myreaderx("")


        conl.Close()

        conl.Open()
        Dim strin As String
        strin = "select SUM(Jumlah) from Table_Income1"
        Dim cmdi As New SqlCommand(strin, conl)

        Dim myreaderi As SqlDataReader
        myreaderi = cmdi.ExecuteReader

        myreaderi.Read()
        Label17.Text = myreaderi("")
        conl.Close()

        Label13.Text = "Rp. " & Val(Label17.Text) - Val(Label16.Text)





    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub
End Class