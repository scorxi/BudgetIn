<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPlanning
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.iconjadi = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TablePlanning1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_BUDGETINDataSet3 = New uiuaa.DB_BUDGETINDataSet3()
        Me.lv = New System.Windows.Forms.ListView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Guna2Button17 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button15 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button14 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button13 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button12 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button11 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button10 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button9 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button8 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.DB_CONTOHDataSet5 = New uiuaa.DB_CONTOHDataSet5()
        Me.TBLPLANBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_PLANTableAdapter = New uiuaa.DB_CONTOHDataSet5TableAdapters.TBL_PLANTableAdapter()
        Me.TBLPLANBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table_Planning1TableAdapter = New uiuaa.DB_BUDGETINDataSet3TableAdapters.Table_Planning1TableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablePlanning1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_BUDGETINDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_CONTOHDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPLANBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPLANBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Expenses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label2.Location = New System.Drawing.Point(218, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Income"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.iconjadi)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.lv)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Guna2TextBox1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(314, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 525)
        Me.Panel2.TabIndex = 51
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(435, 499)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label7.Location = New System.Drawing.Point(402, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 25)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Income"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label6.Location = New System.Drawing.Point(127, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 25)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Income"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label5.Location = New System.Drawing.Point(307, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 25)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Sisa : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.MediumPurple
        Me.Label4.Location = New System.Drawing.Point(23, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 25)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Budget : "
        '
        'iconjadi
        '
        Me.iconjadi.Animated = True
        Me.iconjadi.CheckedState.Parent = Me.iconjadi
        Me.iconjadi.CustomImages.Parent = Me.iconjadi
        Me.iconjadi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.iconjadi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.iconjadi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.iconjadi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.iconjadi.DisabledState.Parent = Me.iconjadi
        Me.iconjadi.FillColor = System.Drawing.Color.Transparent
        Me.iconjadi.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.iconjadi.ForeColor = System.Drawing.Color.White
        Me.iconjadi.HoverState.Parent = Me.iconjadi
        Me.iconjadi.ImageSize = New System.Drawing.Size(30, 30)
        Me.iconjadi.Location = New System.Drawing.Point(10, 12)
        Me.iconjadi.Name = "iconjadi"
        Me.iconjadi.ShadowDecoration.Parent = Me.iconjadi
        Me.iconjadi.Size = New System.Drawing.Size(44, 47)
        Me.iconjadi.TabIndex = 37
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TanggalDataGridViewTextBoxColumn, Me.Kategori, Me.Jumlah, Me.CatatanDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TablePlanning1BindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(10, 196)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(532, 302)
        Me.DataGridView1.TabIndex = 18
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        Me.TanggalDataGridViewTextBoxColumn.Width = 123
        '
        'Kategori
        '
        Me.Kategori.DataPropertyName = "Kategori"
        Me.Kategori.HeaderText = "Kategori"
        Me.Kategori.Name = "Kategori"
        Me.Kategori.Width = 120
        '
        'Jumlah
        '
        Me.Jumlah.DataPropertyName = "Jumlah"
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Width = 120
        '
        'CatatanDataGridViewTextBoxColumn
        '
        Me.CatatanDataGridViewTextBoxColumn.DataPropertyName = "Catatan"
        Me.CatatanDataGridViewTextBoxColumn.HeaderText = "Catatan"
        Me.CatatanDataGridViewTextBoxColumn.Name = "CatatanDataGridViewTextBoxColumn"
        Me.CatatanDataGridViewTextBoxColumn.Width = 121
        '
        'TablePlanning1BindingSource
        '
        Me.TablePlanning1BindingSource.DataMember = "Table_Planning1"
        Me.TablePlanning1BindingSource.DataSource = Me.DB_BUDGETINDataSet3
        '
        'DB_BUDGETINDataSet3
        '
        Me.DB_BUDGETINDataSet3.DataSetName = "DB_BUDGETINDataSet3"
        Me.DB_BUDGETINDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lv
        '
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(10, 196)
        Me.lv.Name = "lv"
        Me.lv.Size = New System.Drawing.Size(532, 259)
        Me.lv.TabIndex = 17
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.RoyalBlue
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(3, 127)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(545, 10)
        Me.TextBox3.TabIndex = 16
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.CheckedState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.HoverState.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(205, 12)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.ShadowDecoration.Parent = Me.Guna2DateTimePicker1
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(200, 36)
        Me.Guna2DateTimePicker1.TabIndex = 6
        Me.Guna2DateTimePicker1.Value = New Date(2021, 9, 26, 11, 57, 51, 975)
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(206, 65)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Catatan"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(199, 54)
        Me.Guna2TextBox1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.DefaultText = ""
        Me.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.DisabledState.Parent = Me.TextBox1
        Me.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.FocusedState.Parent = Me.TextBox1
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.HoverState.Parent = Me.TextBox1
        Me.TextBox1.Location = New System.Drawing.Point(38, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.PlaceholderText = "uang"
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.ShadowDecoration.Parent = Me.TextBox1
        Me.TextBox1.Size = New System.Drawing.Size(156, 32)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pick Category"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(435, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sumbit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Guna2Button17
        '
        Me.Guna2Button17.Animated = True
        Me.Guna2Button17.CheckedState.Parent = Me.Guna2Button17
        Me.Guna2Button17.CustomImages.Parent = Me.Guna2Button17
        Me.Guna2Button17.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button17.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button17.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button17.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button17.DisabledState.Parent = Me.Guna2Button17
        Me.Guna2Button17.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button17.ForeColor = System.Drawing.Color.White
        Me.Guna2Button17.HoverState.Parent = Me.Guna2Button17
        Me.Guna2Button17.Image = Global.uiuaa.My.Resources.Resources.icons8_traditional_school_bus
        Me.Guna2Button17.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button17.Location = New System.Drawing.Point(142, 355)
        Me.Guna2Button17.Name = "Guna2Button17"
        Me.Guna2Button17.ShadowDecoration.Parent = Me.Guna2Button17
        Me.Guna2Button17.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button17.TabIndex = 50
        '
        'Guna2Button15
        '
        Me.Guna2Button15.Animated = True
        Me.Guna2Button15.CheckedState.Parent = Me.Guna2Button15
        Me.Guna2Button15.CustomImages.Parent = Me.Guna2Button15
        Me.Guna2Button15.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button15.DisabledState.Parent = Me.Guna2Button15
        Me.Guna2Button15.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button15.ForeColor = System.Drawing.Color.White
        Me.Guna2Button15.HoverState.Parent = Me.Guna2Button15
        Me.Guna2Button15.Image = Global.uiuaa.My.Resources.Resources.icons8_stocks_growth
        Me.Guna2Button15.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button15.Location = New System.Drawing.Point(17, 249)
        Me.Guna2Button15.Name = "Guna2Button15"
        Me.Guna2Button15.ShadowDecoration.Parent = Me.Guna2Button15
        Me.Guna2Button15.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button15.TabIndex = 49
        '
        'Guna2Button14
        '
        Me.Guna2Button14.Animated = True
        Me.Guna2Button14.CheckedState.Parent = Me.Guna2Button14
        Me.Guna2Button14.CustomImages.Parent = Me.Guna2Button14
        Me.Guna2Button14.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button14.DisabledState.Parent = Me.Guna2Button14
        Me.Guna2Button14.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button14.ForeColor = System.Drawing.Color.White
        Me.Guna2Button14.HoverState.Parent = Me.Guna2Button14
        Me.Guna2Button14.Image = Global.uiuaa.My.Resources.Resources.icons8_stethoscope
        Me.Guna2Button14.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button14.Location = New System.Drawing.Point(142, 249)
        Me.Guna2Button14.Name = "Guna2Button14"
        Me.Guna2Button14.ShadowDecoration.Parent = Me.Guna2Button14
        Me.Guna2Button14.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button14.TabIndex = 48
        '
        'Guna2Button13
        '
        Me.Guna2Button13.Animated = True
        Me.Guna2Button13.CheckedState.Parent = Me.Guna2Button13
        Me.Guna2Button13.CustomImages.Parent = Me.Guna2Button13
        Me.Guna2Button13.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button13.DisabledState.Parent = Me.Guna2Button13
        Me.Guna2Button13.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button13.ForeColor = System.Drawing.Color.White
        Me.Guna2Button13.HoverState.Parent = Me.Guna2Button13
        Me.Guna2Button13.Image = Global.uiuaa.My.Resources.Resources.icons8_money_circulation
        Me.Guna2Button13.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button13.Location = New System.Drawing.Point(241, 143)
        Me.Guna2Button13.Name = "Guna2Button13"
        Me.Guna2Button13.ShadowDecoration.Parent = Me.Guna2Button13
        Me.Guna2Button13.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button13.TabIndex = 47
        '
        'Guna2Button12
        '
        Me.Guna2Button12.Animated = True
        Me.Guna2Button12.CheckedState.Parent = Me.Guna2Button12
        Me.Guna2Button12.CustomImages.Parent = Me.Guna2Button12
        Me.Guna2Button12.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button12.DisabledState.Parent = Me.Guna2Button12
        Me.Guna2Button12.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button12.ForeColor = System.Drawing.Color.White
        Me.Guna2Button12.HoverState.Parent = Me.Guna2Button12
        Me.Guna2Button12.Image = Global.uiuaa.My.Resources.Resources.icons8_ping_pong
        Me.Guna2Button12.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button12.Location = New System.Drawing.Point(142, 37)
        Me.Guna2Button12.Name = "Guna2Button12"
        Me.Guna2Button12.ShadowDecoration.Parent = Me.Guna2Button12
        Me.Guna2Button12.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button12.TabIndex = 46
        '
        'Guna2Button11
        '
        Me.Guna2Button11.Animated = True
        Me.Guna2Button11.CheckedState.Parent = Me.Guna2Button11
        Me.Guna2Button11.CustomImages.Parent = Me.Guna2Button11
        Me.Guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button11.DisabledState.Parent = Me.Guna2Button11
        Me.Guna2Button11.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button11.ForeColor = System.Drawing.Color.White
        Me.Guna2Button11.HoverState.Parent = Me.Guna2Button11
        Me.Guna2Button11.Image = Global.uiuaa.My.Resources.Resources.icons8_receive_cash
        Me.Guna2Button11.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button11.Location = New System.Drawing.Point(142, 143)
        Me.Guna2Button11.Name = "Guna2Button11"
        Me.Guna2Button11.ShadowDecoration.Parent = Me.Guna2Button11
        Me.Guna2Button11.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button11.TabIndex = 45
        '
        'Guna2Button10
        '
        Me.Guna2Button10.Animated = True
        Me.Guna2Button10.CheckedState.Parent = Me.Guna2Button10
        Me.Guna2Button10.CustomImages.Parent = Me.Guna2Button10
        Me.Guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button10.DisabledState.Parent = Me.Guna2Button10
        Me.Guna2Button10.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button10.ForeColor = System.Drawing.Color.White
        Me.Guna2Button10.HoverState.Parent = Me.Guna2Button10
        Me.Guna2Button10.Image = Global.uiuaa.My.Resources.Resources.icons8_stack_of_money
        Me.Guna2Button10.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button10.Location = New System.Drawing.Point(241, 37)
        Me.Guna2Button10.Name = "Guna2Button10"
        Me.Guna2Button10.ShadowDecoration.Parent = Me.Guna2Button10
        Me.Guna2Button10.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button10.TabIndex = 44
        '
        'Guna2Button9
        '
        Me.Guna2Button9.Animated = True
        Me.Guna2Button9.CheckedState.Parent = Me.Guna2Button9
        Me.Guna2Button9.CustomImages.Parent = Me.Guna2Button9
        Me.Guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button9.DisabledState.Parent = Me.Guna2Button9
        Me.Guna2Button9.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button9.ForeColor = System.Drawing.Color.White
        Me.Guna2Button9.HoverState.Parent = Me.Guna2Button9
        Me.Guna2Button9.Image = Global.uiuaa.My.Resources.Resources.icons8_game_controller
        Me.Guna2Button9.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button9.Location = New System.Drawing.Point(17, 355)
        Me.Guna2Button9.Name = "Guna2Button9"
        Me.Guna2Button9.ShadowDecoration.Parent = Me.Guna2Button9
        Me.Guna2Button9.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button9.TabIndex = 43
        '
        'Guna2Button8
        '
        Me.Guna2Button8.Animated = True
        Me.Guna2Button8.CheckedState.Parent = Me.Guna2Button8
        Me.Guna2Button8.CustomImages.Parent = Me.Guna2Button8
        Me.Guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button8.DisabledState.Parent = Me.Guna2Button8
        Me.Guna2Button8.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button8.ForeColor = System.Drawing.Color.White
        Me.Guna2Button8.HoverState.Parent = Me.Guna2Button8
        Me.Guna2Button8.Image = Global.uiuaa.My.Resources.Resources.icons8_graduation_cap
        Me.Guna2Button8.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button8.Location = New System.Drawing.Point(73, 408)
        Me.Guna2Button8.Name = "Guna2Button8"
        Me.Guna2Button8.ShadowDecoration.Parent = Me.Guna2Button8
        Me.Guna2Button8.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button8.TabIndex = 42
        '
        'Guna2Button7
        '
        Me.Guna2Button7.Animated = True
        Me.Guna2Button7.CheckedState.Parent = Me.Guna2Button7
        Me.Guna2Button7.CustomImages.Parent = Me.Guna2Button7
        Me.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button7.DisabledState.Parent = Me.Guna2Button7
        Me.Guna2Button7.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button7.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.HoverState.Parent = Me.Guna2Button7
        Me.Guna2Button7.Image = Global.uiuaa.My.Resources.Resources.icons8_makeup
        Me.Guna2Button7.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button7.Location = New System.Drawing.Point(17, 461)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.ShadowDecoration.Parent = Me.Guna2Button7
        Me.Guna2Button7.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button7.TabIndex = 41
        '
        'Guna2Button6
        '
        Me.Guna2Button6.Animated = True
        Me.Guna2Button6.CheckedState.Parent = Me.Guna2Button6
        Me.Guna2Button6.CustomImages.Parent = Me.Guna2Button6
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.DisabledState.Parent = Me.Guna2Button6
        Me.Guna2Button6.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.HoverState.Parent = Me.Guna2Button6
        Me.Guna2Button6.Image = Global.uiuaa.My.Resources.Resources.icons8_wrench
        Me.Guna2Button6.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button6.Location = New System.Drawing.Point(73, 90)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.ShadowDecoration.Parent = Me.Guna2Button6
        Me.Guna2Button6.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button6.TabIndex = 40
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Animated = True
        Me.Guna2Button5.CheckedState.Parent = Me.Guna2Button5
        Me.Guna2Button5.CustomImages.Parent = Me.Guna2Button5
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.DisabledState.Parent = Me.Guna2Button5
        Me.Guna2Button5.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.White
        Me.Guna2Button5.HoverState.Parent = Me.Guna2Button5
        Me.Guna2Button5.Image = Global.uiuaa.My.Resources.Resources.icons8_transaction_list
        Me.Guna2Button5.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button5.Location = New System.Drawing.Point(17, 143)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.ShadowDecoration.Parent = Me.Guna2Button5
        Me.Guna2Button5.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button5.TabIndex = 39
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.DisabledState.Parent = Me.Guna2Button4
        Me.Guna2Button4.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Image = Global.uiuaa.My.Resources.Resources.icons8_clothes
        Me.Guna2Button4.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button4.Location = New System.Drawing.Point(73, 196)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button4.TabIndex = 38
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.DisabledState.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Image = Global.uiuaa.My.Resources.Resources.icons8_box
        Me.Guna2Button3.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button3.Location = New System.Drawing.Point(142, 461)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button3.TabIndex = 37
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.DisabledState.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Image = Global.uiuaa.My.Resources.Resources.icons8_dog_sit
        Me.Guna2Button2.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button2.Location = New System.Drawing.Point(73, 303)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button2.TabIndex = 36
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.uiuaa.My.Resources.Resources.icons8_restaurant_32
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button1.Location = New System.Drawing.Point(17, 37)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(44, 47)
        Me.Guna2Button1.TabIndex = 35
        '
        'DB_CONTOHDataSet5
        '
        Me.DB_CONTOHDataSet5.DataSetName = "DB_CONTOHDataSet5"
        Me.DB_CONTOHDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLPLANBindingSource
        '
        Me.TBLPLANBindingSource.DataMember = "TBL_PLAN"
        Me.TBLPLANBindingSource.DataSource = Me.DB_CONTOHDataSet5
        '
        'TBL_PLANTableAdapter
        '
        Me.TBL_PLANTableAdapter.ClearBeforeFill = True
        '
        'TBLPLANBindingSource1
        '
        Me.TBLPLANBindingSource1.DataMember = "TBL_PLAN"
        Me.TBLPLANBindingSource1.DataSource = Me.DB_CONTOHDataSet5
        '
        'Table_Planning1TableAdapter
        '
        Me.Table_Planning1TableAdapter.ClearBeforeFill = True
        '
        'FormPlanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(868, 525)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guna2Button17)
        Me.Controls.Add(Me.Guna2Button15)
        Me.Controls.Add(Me.Guna2Button14)
        Me.Controls.Add(Me.Guna2Button13)
        Me.Controls.Add(Me.Guna2Button12)
        Me.Controls.Add(Me.Guna2Button11)
        Me.Controls.Add(Me.Guna2Button10)
        Me.Controls.Add(Me.Guna2Button9)
        Me.Controls.Add(Me.Guna2Button8)
        Me.Controls.Add(Me.Guna2Button7)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.Guna2Button5)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPlanning"
        Me.Text = "FormPlanning"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablePlanning1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_BUDGETINDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_CONTOHDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPLANBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPLANBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button17 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button15 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button14 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button13 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button12 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button11 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button10 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button9 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lv As ListView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents iconjadi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DB_CONTOHDataSet5 As DB_CONTOHDataSet5
    Friend WithEvents TBLPLANBindingSource As BindingSource
    Friend WithEvents TBL_PLANTableAdapter As DB_CONTOHDataSet5TableAdapters.TBL_PLANTableAdapter
    Friend WithEvents TBLPLANBindingSource1 As BindingSource
    Friend WithEvents DB_BUDGETINDataSet3 As DB_BUDGETINDataSet3
    Friend WithEvents TablePlanning1BindingSource As BindingSource
    Friend WithEvents Table_Planning1TableAdapter As DB_BUDGETINDataSet3TableAdapters.Table_Planning1TableAdapter
    Friend WithEvents TanggalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Kategori As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents CatatanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
