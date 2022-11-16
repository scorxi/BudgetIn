Imports System.Data.SqlClient

Public Class FormPlanning

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gambar = iconjadi.Image
        budget = TextBox1.Text
        isiTabel()


        Dim kat As String = Label3.Text
        Dim tangal As Date = Guna2DateTimePicker1.Text
        Dim jmlh As String = TextBox1.Text
        Dim ket As String = Guna2TextBox1.Text
        Dim query As String = "INSERT INTO Table_Planning1 VALUES (@Tanggal,@Kategori,@Jumlah,@Catatan)"
        Dim query2 As String = "INSERT INTO Table_Budget1 VALUES (@Tanggal,@Kategori,@Jumlah,@Catatan)"
        Using conTrans As SqlConnection = New SqlConnection("Data Source=HOME-PC;initial catalog=DB_BUDGETIN;integrated security=true")
            conTrans.Open()

            If kat = "Salary" Or kat = "Budgetin" Then

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
            Label3.Text = "Pick Category"
            Guna2DateTimePicker1.Text = ""
            TextBox1.Text = ""
            Guna2TextBox1.Text = ""
        End Using
        Dim conl As SqlConnection = New SqlConnection("Data Source=HOME-PC;initial catalog=DB_BUDGETIN;integrated security=true")
        conl.Open()
        Dim strs As String
        strs = "select SUM(Jumlah) from Table_Planning1"
        Dim cmds As New SqlCommand(strs, conl)

        Dim myreaders As SqlDataReader
        myreaders = cmds.ExecuteReader

        myreaders.Read()
        Label7.Text = Val(Label6.Text) - myreaders("")
        conl.Close()
        'TODO: This line of code loads data into the 'DB_BUDGETINDataSet3.Table_Planning1' table. You can move, or remove it, as needed.
        Me.Table_Planning1TableAdapter.Fill(Me.DB_BUDGETINDataSet3.Table_Planning1)

    End Sub

    Sub buatkolom()
        With lv.Columns
            .Add("Tanggal", 150, HorizontalAlignment.Center)
            .Add("Category", 90, HorizontalAlignment.Center)
            .Add("Harga", 100, HorizontalAlignment.Center)
            .Add("Catatan", 188, HorizontalAlignment.Center)

        End With
        lv.View = View.Details
        lv.GridLines = True
        lv.FullRowSelect = True
    End Sub

    Sub isiTabel()
        Dim isi As New ListViewItem
        isi.Text = Guna2DateTimePicker1.Text
        isi.SubItems.Add(Label3.Text)
        isi.SubItems.Add("Rp. " + TextBox1.Text)
        isi.SubItems.Add(Guna2TextBox1.Text)
        lv.Items.Add(isi)
    End Sub

    Private Sub FormPlanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_BUDGETINDataSet3.Table_Planning1' table. You can move, or remove it, as needed.
        Me.Table_Planning1TableAdapter.Fill(Me.DB_BUDGETINDataSet3.Table_Planning1)
        Dim conl As SqlConnection = New SqlConnection("Data Source=HOME-PC;initial catalog=DB_BUDGETIN;integrated security=true")
        conl.Open()
        Dim strin As String
        strin = "select SUM(Jumlah) from Table_Budget1"
        Dim cmdi As New SqlCommand(strin, conl)

        Dim myreaderi As SqlDataReader
        myreaderi = cmdi.ExecuteReader

        myreaderi.Read()
        Label6.Text = myreaderi("")
        conl.Close()

        conl.Open()
        Dim strs As String
        strs = "select SUM(Jumlah) from Table_Planning1"
        Dim cmds As New SqlCommand(strs, conl)

        Dim myreaders As SqlDataReader
        myreaders = cmds.ExecuteReader

        myreaders.Read()
        Label7.Text = Val(Label6.Text) - myreaders("")
        conl.Close()

        'TODO: This line of code loads data into the 'DB_BUDGETINDataSet3.Table_Planning1' table. You can move, or remove it, as needed.
        Me.Table_Planning1TableAdapter.Fill(Me.DB_BUDGETINDataSet3.Table_Planning1)

        buatkolom()

        'TODO: This line of code loads data into the 'DB_BUDGETINDataSet3.Table_Planning1' table. You can move, or remove it, as needed.
        Me.Table_Planning1TableAdapter.Fill(Me.DB_BUDGETINDataSet3.Table_Planning1)

    End Sub

    Private Sub lv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv.Click
        Guna2DateTimePicker1.Text = lv.SelectedItems(0).SubItems(0).Text
        Label3.Text = lv.SelectedItems(0).SubItems(1).Text
        TextBox1.Text = lv.SelectedItems(0).SubItems(2).Text
        Guna2TextBox1.Text = lv.SelectedItems(0).SubItems(3).Text
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Label3.Text = "Makanan"
        gamarButton(sender, e)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Label3.Text = "Mechanic"
        gamarButton(sender, e)
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs) Handles Guna2Button12.Click
        Label3.Text = "Olahraga"
        gamarButton(sender, e)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Label3.Text = "Chlotes"
        gamarButton(sender, e)
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Label3.Text = "Game"
        gamarButton(sender, e)
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Label3.Text = "Cosmetic"
        gamarButton(sender, e)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Label3.Text = "Pet"
        gamarButton(sender, e)
    End Sub

    Public gamar As Guna.UI2.WinForms.Guna2Button
    Public Sub gamarButton(senderBtn As Object, e As EventArgs)
        gamar = CType(senderBtn, Guna.UI2.WinForms.Guna2Button)
        'current from icon
        iconjadi.Image = gamar.Image
    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs) Handles Guna2Button13.Click
        Label3.Text = "Budgetin"
        gamarButton(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedItem As String
        Dim result As System.Windows.Forms.DialogResult

        selectedItem = DataGridView1.SelectedCells(3).Value.ToString

        result = MessageBox.Show("Yakin Planning " & selectedItem &
                                 " akan dihapus?", "Konfirmasi", MessageBoxButtons.OKCancel,
                                 MessageBoxIcon.Warning)

        If result = System.Windows.Forms.DialogResult.OK Then
            Table_Planning1TableAdapter.DQ(selectedItem)

            Me.Table_Planning1TableAdapter.Fill(Me.DB_BUDGETINDataSet3.Table_Planning1)
        End If

        'TODO: This line of code loads data into the 'DB_BUDGETINDataSet3.Table_Planning1' table. You can move, or remove it, as needed.
        Me.Table_Planning1TableAdapter.Fill(Me.DB_BUDGETINDataSet3.Table_Planning1)
    End Sub


End Class