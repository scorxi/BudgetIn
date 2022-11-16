<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSetting
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
        Dim Animation4 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSetting))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.tbcan = New System.Windows.Forms.TextBox()
        Me.tbwhat = New System.Windows.Forms.TextBox()
        Me.btncan = New FontAwesome.Sharp.IconButton()
        Me.btnwhat = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.animation2 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.IconButton6)
        Me.Panel2.Controls.Add(Me.IconButton2)
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Controls.Add(Me.tbcan)
        Me.Panel2.Controls.Add(Me.tbwhat)
        Me.Panel2.Controls.Add(Me.btncan)
        Me.Panel2.Controls.Add(Me.btnwhat)
        Me.animation2.SetDecoration(Me.Panel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(336, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 525)
        Me.Panel2.TabIndex = 52
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.animation2.SetDecoration(Me.TextBox5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox5.Location = New System.Drawing.Point(118, 479)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(370, 34)
        Me.TextBox5.TabIndex = 13
        Me.TextBox5.Text = " please choose the ""income"" tab next to the ""expense"" tab when you select categor" &
    "y for that transaction."
        Me.TextBox5.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.animation2.SetDecoration(Me.TextBox2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox2.Location = New System.Drawing.Point(118, 380)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(370, 36)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = " please choose the ""income"" tab next to the ""expense"" tab when you select categor" &
    "y for that transaction."
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.animation2.SetDecoration(Me.TextBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox1.Location = New System.Drawing.Point(118, 162)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(370, 39)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "Budget : a targeted limit for one specific wallet’s all categories or one specifi" &
    "c category."
        Me.TextBox1.Visible = False
        '
        'IconButton6
        '
        Me.animation2.SetDecoration(Me.IconButton6, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown
        Me.IconButton6.IconColor = System.Drawing.Color.Black
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.IconSize = 40
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(30, 89)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton6.Size = New System.Drawing.Size(305, 60)
        Me.IconButton6.TabIndex = 10
        Me.IconButton6.Text = "What is Budget ? How to use budget ?"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.animation2.SetDecoration(Me.IconButton2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 40
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(30, 422)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton2.Size = New System.Drawing.Size(305, 60)
        Me.IconButton2.TabIndex = 6
        Me.IconButton2.Text = "Create one category, available on all walet ?"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.animation2.SetDecoration(Me.IconButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(30, 314)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.IconButton1.Size = New System.Drawing.Size(305, 60)
        Me.IconButton1.TabIndex = 5
        Me.IconButton1.Text = "How to add an income transaction ?"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'tbcan
        '
        Me.tbcan.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tbcan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.animation2.SetDecoration(Me.tbcan, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbcan.Location = New System.Drawing.Point(118, 262)
        Me.tbcan.Multiline = True
        Me.tbcan.Name = "tbcan"
        Me.tbcan.Size = New System.Drawing.Size(370, 46)
        Me.tbcan.TabIndex = 4
        Me.tbcan.Text = "We can't support these options. Sorry for this inconvenience" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tbcan.Visible = False
        '
        'tbwhat
        '
        Me.tbwhat.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.tbwhat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.animation2.SetDecoration(Me.tbwhat, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.tbwhat.Location = New System.Drawing.Point(118, 65)
        Me.tbwhat.Multiline = True
        Me.tbwhat.Name = "tbwhat"
        Me.tbwhat.Size = New System.Drawing.Size(370, 31)
        Me.tbwhat.TabIndex = 4
        Me.tbwhat.Text = "if you love to acticvly control what's happening in your life and have total powe" &
    "r it, BudgetIn is one of the best tools that can bring you such power"
        Me.tbwhat.Visible = False
        '
        'btncan
        '
        Me.animation2.SetDecoration(Me.btncan, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btncan.FlatAppearance.BorderSize = 0
        Me.btncan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncan.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown
        Me.btncan.IconColor = System.Drawing.Color.Black
        Me.btncan.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btncan.IconSize = 40
        Me.btncan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncan.Location = New System.Drawing.Point(30, 200)
        Me.btncan.Name = "btncan"
        Me.btncan.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btncan.Size = New System.Drawing.Size(305, 60)
        Me.btncan.TabIndex = 3
        Me.btncan.Text = "Can i import CSV or excel files to Budgetin      " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btncan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btncan.UseVisualStyleBackColor = True
        '
        'btnwhat
        '
        Me.animation2.SetDecoration(Me.btnwhat, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnwhat.FlatAppearance.BorderSize = 0
        Me.btnwhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnwhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnwhat.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleDown
        Me.btnwhat.IconColor = System.Drawing.Color.Black
        Me.btnwhat.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnwhat.IconSize = 40
        Me.btnwhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnwhat.Location = New System.Drawing.Point(30, 0)
        Me.btnwhat.Name = "btnwhat"
        Me.btnwhat.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnwhat.Size = New System.Drawing.Size(305, 60)
        Me.btnwhat.TabIndex = 2
        Me.btnwhat.Text = "What is Budgetin ? What can I use it for?"
        Me.btnwhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnwhat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnwhat.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.animation2.SetDecoration(Me.Panel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(336, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 525)
        Me.Panel1.TabIndex = 53
        '
        'TextBox3
        '
        Me.animation2.SetDecoration(Me.TextBox3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox3.Location = New System.Drawing.Point(108, 65)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(199, 84)
        Me.TextBox3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.animation2.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Category"
        '
        'Button2
        '
        Me.animation2.SetDecoration(Me.Button2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Button2.Location = New System.Drawing.Point(232, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.animation2.SetDecoration(Me.TextBox4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TextBox4.Location = New System.Drawing.Point(108, 21)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 0
        '
        'imgHome
        '
        Me.animation2.SetDecoration(Me.imgHome, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.imgHome.Image = Global.uiuaa.My.Resources.Resources.Wallet_Cash_550px
        Me.imgHome.Location = New System.Drawing.Point(102, 42)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(123, 83)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 54
        Me.imgHome.TabStop = False
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.animation2.SetDecoration(Me.BunifuLabel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.MediumPurple
        Me.BunifuLabel1.Location = New System.Drawing.Point(113, 162)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(97, 32)
        Me.BunifuLabel1.TabIndex = 55
        Me.BunifuLabel1.Text = "BudgetIn"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.animation2.SetDecoration(Me.BunifuLabel2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BunifuLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.MediumPurple
        Me.BunifuLabel2.Location = New System.Drawing.Point(108, 227)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(102, 25)
        Me.BunifuLabel2.TabIndex = 56
        Me.BunifuLabel2.Text = "Version : 1.0"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'animation2
        '
        Me.animation2.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.animation2.DefaultAnimation = Animation4
        '
        'FormSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(868, 525)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.imgHome)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.animation2.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Name = "FormSetting"
        Me.Text = "FormSetting"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents btnwhat As FontAwesome.Sharp.IconButton
    Friend WithEvents animation2 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents tbwhat As TextBox
    Friend WithEvents btncan As FontAwesome.Sharp.IconButton
    Friend WithEvents tbcan As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBox5 As TextBox
End Class
