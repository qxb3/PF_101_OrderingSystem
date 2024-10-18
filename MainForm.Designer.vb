<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Panel1 = New Panel()
        btn_addtpcart = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        pic_keyboard = New PictureBox()
        atc_keyboard = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        Panel10 = New Panel()
        Label18 = New Label()
        pic_ram = New PictureBox()
        atc_ram = New Button()
        Label19 = New Label()
        Panel9 = New Panel()
        Label16 = New Label()
        pic_webcam = New PictureBox()
        Label17 = New Label()
        atc_webcam = New Button()
        Panel8 = New Panel()
        Label14 = New Label()
        pic_headphone = New PictureBox()
        atc_headphone = New Button()
        Label15 = New Label()
        Panel7 = New Panel()
        Label12 = New Label()
        pic_harddrive = New PictureBox()
        Label13 = New Label()
        atc_harddrive = New Button()
        Panel6 = New Panel()
        Label10 = New Label()
        pic_usb = New PictureBox()
        atc_usb = New Button()
        Label11 = New Label()
        Panel5 = New Panel()
        Label8 = New Label()
        pic_hdmi = New PictureBox()
        Label9 = New Label()
        atc_hdmi = New Button()
        Panel3 = New Panel()
        Label6 = New Label()
        pic_mouse = New PictureBox()
        atc_mouse = New Button()
        Label7 = New Label()
        Panel4 = New Panel()
        Label4 = New Label()
        pic_monitor = New PictureBox()
        Label5 = New Label()
        atc_monitor = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(pic_keyboard, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        Panel10.SuspendLayout()
        CType(pic_ram, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        CType(pic_webcam, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(pic_headphone, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(pic_harddrive, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(pic_usb, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(pic_hdmi, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(pic_mouse, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(pic_monitor, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SpringGreen
        Panel1.Controls.Add(btn_addtpcart)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(904, 55)
        Panel1.TabIndex = 0
        ' 
        ' btn_addtpcart
        ' 
        btn_addtpcart.BackColor = Color.White
        btn_addtpcart.Cursor = Cursors.Hand
        btn_addtpcart.FlatStyle = FlatStyle.Flat
        btn_addtpcart.Font = New Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_addtpcart.ForeColor = Color.Black
        btn_addtpcart.Location = New Point(814, 11)
        btn_addtpcart.Name = "btn_addtpcart"
        btn_addtpcart.Size = New Size(75, 34)
        btn_addtpcart.TabIndex = 1
        btn_addtpcart.Text = "CART"
        btn_addtpcart.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(11, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 24)
        Label1.TabIndex = 0
        Label1.Text = "Computer Store"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(pic_keyboard)
        Panel2.Controls.Add(atc_keyboard)
        Panel2.Location = New Point(3, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(275, 130)
        Panel2.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(146, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 18)
        Label3.TabIndex = 5
        Label3.Text = "₱ 780.00"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(146, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 19)
        Label2.TabIndex = 4
        Label2.Text = "• Keyboard"
        ' 
        ' pic_keyboard
        ' 
        pic_keyboard.BackColor = Color.Transparent
        pic_keyboard.Image = CType(resources.GetObject("pic_keyboard.Image"), Image)
        pic_keyboard.ImageLocation = ""
        pic_keyboard.Location = New Point(10, 12)
        pic_keyboard.Name = "pic_keyboard"
        pic_keyboard.Size = New Size(119, 108)
        pic_keyboard.SizeMode = PictureBoxSizeMode.Zoom
        pic_keyboard.TabIndex = 3
        pic_keyboard.TabStop = False
        ' 
        ' atc_keyboard
        ' 
        atc_keyboard.BackColor = Color.White
        atc_keyboard.Cursor = Cursors.Hand
        atc_keyboard.FlatStyle = FlatStyle.Flat
        atc_keyboard.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        atc_keyboard.Location = New Point(155, 86)
        atc_keyboard.Name = "atc_keyboard"
        atc_keyboard.Size = New Size(108, 34)
        atc_keyboard.TabIndex = 2
        atc_keyboard.Text = "Add To Cart"
        atc_keyboard.UseVisualStyleBackColor = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 47.2580643F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 52.7419357F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 285F))
        TableLayoutPanel1.Controls.Add(Panel10, 2, 2)
        TableLayoutPanel1.Controls.Add(Panel9, 1, 2)
        TableLayoutPanel1.Controls.Add(Panel8, 0, 2)
        TableLayoutPanel1.Controls.Add(Panel7, 2, 1)
        TableLayoutPanel1.Controls.Add(Panel6, 1, 1)
        TableLayoutPanel1.Controls.Add(Panel5, 0, 1)
        TableLayoutPanel1.Controls.Add(Panel2, 0, 0)
        TableLayoutPanel1.Controls.Add(Panel3, 2, 0)
        TableLayoutPanel1.Controls.Add(Panel4, 1, 0)
        TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize
        TableLayoutPanel1.Location = New Point(12, 70)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 140F))
        TableLayoutPanel1.Size = New Size(881, 412)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.White
        Panel10.Controls.Add(Label18)
        Panel10.Controls.Add(pic_ram)
        Panel10.Controls.Add(atc_ram)
        Panel10.Controls.Add(Label19)
        Panel10.Location = New Point(598, 275)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(280, 134)
        Panel10.TabIndex = 8
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Consolas", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(149, 52)
        Label18.Name = "Label18"
        Label18.Size = New Size(72, 18)
        Label18.TabIndex = 21
        Label18.Text = "₱ 580.00"
        ' 
        ' pic_ram
        ' 
        pic_ram.BackColor = Color.Transparent
        pic_ram.Image = CType(resources.GetObject("pic_ram.Image"), Image)
        pic_ram.ImageLocation = ""
        pic_ram.Location = New Point(22, 21)
        pic_ram.Name = "pic_ram"
        pic_ram.Size = New Size(116, 98)
        pic_ram.SizeMode = PictureBoxSizeMode.Zoom
        pic_ram.TabIndex = 19
        pic_ram.TabStop = False
        ' 
        ' atc_ram
        ' 
        atc_ram.BackColor = Color.White
        atc_ram.Cursor = Cursors.Hand
        atc_ram.FlatStyle = FlatStyle.Flat
        atc_ram.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        atc_ram.Location = New Point(158, 91)
        atc_ram.Name = "atc_ram"
        atc_ram.Size = New Size(108, 34)
        atc_ram.TabIndex = 18
        atc_ram.Text = "Add To Cart"
        atc_ram.UseVisualStyleBackColor = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(149, 27)
        Label19.Name = "Label19"
        Label19.Size = New Size(54, 19)
        Label19.TabIndex = 20
        Label19.Text = "• RAM"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.White
        Panel9.Controls.Add(Label16)
        Panel9.Controls.Add(pic_webcam)
        Panel9.Controls.Add(Label17)
        Panel9.Controls.Add(atc_webcam)
        Panel9.Location = New Point(284, 275)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(308, 134)
        Panel9.TabIndex = 7
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Consolas", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(160, 47)
        Label16.Name = "Label16"
        Label16.Size = New Size(72, 18)
        Label16.TabIndex = 17
        Label16.Text = "₱ 450.00"
        ' 
        ' pic_webcam
        ' 
        pic_webcam.BackColor = Color.Transparent
        pic_webcam.Image = CType(resources.GetObject("pic_webcam.Image"), Image)
        pic_webcam.ImageLocation = ""
        pic_webcam.Location = New Point(22, 16)
        pic_webcam.Name = "pic_webcam"
        pic_webcam.Size = New Size(126, 103)
        pic_webcam.SizeMode = PictureBoxSizeMode.Zoom
        pic_webcam.TabIndex = 15
        pic_webcam.TabStop = False
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(160, 22)
        Label17.Name = "Label17"
        Label17.Size = New Size(81, 19)
        Label17.TabIndex = 16
        Label17.Text = "• Webcam"
        ' 
        ' atc_webcam
        ' 
        atc_webcam.BackColor = Color.White
        atc_webcam.Cursor = Cursors.Hand
        atc_webcam.FlatStyle = FlatStyle.Flat
        atc_webcam.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        atc_webcam.Location = New Point(169, 86)
        atc_webcam.Name = "atc_webcam"
        atc_webcam.Size = New Size(108, 34)
        atc_webcam.TabIndex = 14
        atc_webcam.Text = "Add To Cart"
        atc_webcam.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(Label14)
        Panel8.Controls.Add(pic_headphone)
        Panel8.Controls.Add(atc_headphone)
        Panel8.Controls.Add(Label15)
        Panel8.Location = New Point(3, 275)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(275, 134)
        Panel8.TabIndex = 6
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Consolas", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(138, 47)
        Label14.Name = "Label14"
        Label14.Size = New Size(72, 18)
        Label14.TabIndex = 13
        Label14.Text = "₱ 120.00"
        ' 
        ' pic_headphone
        ' 
        pic_headphone.BackColor = Color.Transparent
        pic_headphone.Image = CType(resources.GetObject("pic_headphone.Image"), Image)
        pic_headphone.ImageLocation = ""
        pic_headphone.Location = New Point(12, 22)
        pic_headphone.Name = "pic_headphone"
        pic_headphone.Size = New Size(109, 98)
        pic_headphone.SizeMode = PictureBoxSizeMode.Zoom
        pic_headphone.TabIndex = 11
        pic_headphone.TabStop = False
        ' 
        ' atc_headphone
        ' 
        atc_headphone.BackColor = Color.White
        atc_headphone.Cursor = Cursors.Hand
        atc_headphone.FlatStyle = FlatStyle.Flat
        atc_headphone.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        atc_headphone.Location = New Point(147, 86)
        atc_headphone.Name = "atc_headphone"
        atc_headphone.Size = New Size(108, 34)
        atc_headphone.TabIndex = 10
        atc_headphone.Text = "Add To Cart"
        atc_headphone.UseVisualStyleBackColor = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(138, 22)
        Label15.Name = "Label15"
        Label15.Size = New Size(108, 19)
        Label15.TabIndex = 12
        Label15.Text = "• Headphone"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.White
        Panel7.Controls.Add(Label12)
        Panel7.Controls.Add(pic_harddrive)
        Panel7.Controls.Add(Label13)
        Panel7.Controls.Add(atc_harddrive)
        Panel7.Location = New Point(598, 139)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(280, 130)
        Panel7.TabIndex = 5
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Consolas", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(149, 47)
        Label12.Name = "Label12"
        Label12.Size = New Size(72, 18)
        Label12.TabIndex = 17
        Label12.Text = "₱ 600.00"
        ' 
        ' pic_harddrive
        ' 
        pic_harddrive.BackColor = Color.Transparent
        pic_harddrive.Image = CType(resources.GetObject("pic_harddrive.Image"), Image)
        pic_harddrive.ImageLocation = ""
        pic_harddrive.Location = New Point(22, 16)
        pic_harddrive.Name = "pic_harddrive"
        pic_harddrive.Size = New Size(116, 98)
        pic_harddrive.SizeMode = PictureBoxSizeMode.Zoom
        pic_harddrive.TabIndex = 15
        pic_harddrive.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(149, 22)
        Label13.Name = "Label13"
        Label13.Size = New Size(117, 19)
        Label13.TabIndex = 16
        Label13.Text = "• Hard Drive"
        ' 
        ' atc_harddrive
        ' 
        atc_harddrive.BackColor = Color.White
        atc_harddrive.Cursor = Cursors.Hand
        atc_harddrive.FlatStyle = FlatStyle.Flat
        atc_harddrive.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        atc_harddrive.Location = New Point(158, 86)
        atc_harddrive.Name = "atc_harddrive"
        atc_harddrive.Size = New Size(108, 34)
        atc_harddrive.TabIndex = 14
        atc_harddrive.Text = "Add To Cart"
        atc_harddrive.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(pic_usb)
        Panel6.Controls.Add(atc_usb)
        Panel6.Controls.Add(Label11)
        Panel6.Location = New Point(284, 139)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(308, 130)
        Panel6.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(164, 46)
        Label10.Name = "Label10"
        Label10.Size = New Size(72, 18)
        Label10.TabIndex = 13
        Label10.Text = "₱ 120.00"
        ' 
        ' pic_usb
        ' 
        pic_usb.BackColor = Color.Transparent
        pic_usb.Image = CType(resources.GetObject("pic_usb.Image"), Image)
        pic_usb.ImageLocation = ""
        pic_usb.Location = New Point(32, 16)
        pic_usb.Name = "pic_usb"
        pic_usb.Size = New Size(109, 98)
        pic_usb.SizeMode = PictureBoxSizeMode.Zoom
        pic_usb.TabIndex = 11
        pic_usb.TabStop = False
        ' 
        ' atc_usb
        ' 
        atc_usb.BackColor = Color.White
        atc_usb.Cursor = Cursors.Hand
        atc_usb.FlatStyle = FlatStyle.Flat
        atc_usb.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        atc_usb.Location = New Point(173, 85)
        atc_usb.Name = "atc_usb"
        atc_usb.Size = New Size(108, 34)
        atc_usb.TabIndex = 10
        atc_usb.Text = "Add To Cart"
        atc_usb.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(164, 21)
        Label11.Name = "Label11"
        Label11.Size = New Size(108, 19)
        Label11.TabIndex = 12
        Label11.Text = "• USB Stick"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Label8)
        Panel5.Controls.Add(pic_hdmi)
        Panel5.Controls.Add(Label9)
        Panel5.Controls.Add(atc_hdmi)
        Panel5.Location = New Point(3, 139)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(275, 130)
        Panel5.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Consolas", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(146, 46)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 18)
        Label8.TabIndex = 9
        Label8.Text = "₱ 230.00"
        ' 
        ' pic_hdmi
        ' 
        pic_hdmi.BackColor = Color.Transparent
        pic_hdmi.Image = CType(resources.GetObject("pic_hdmi.Image"), Image)
        pic_hdmi.ImageLocation = ""
        pic_hdmi.Location = New Point(18, 16)
        pic_hdmi.Name = "pic_hdmi"
        pic_hdmi.Size = New Size(109, 98)
        pic_hdmi.SizeMode = PictureBoxSizeMode.Zoom
        pic_hdmi.TabIndex = 7
        pic_hdmi.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(146, 21)
        Label9.Name = "Label9"
        Label9.Size = New Size(117, 19)
        Label9.TabIndex = 8
        Label9.Text = "• HDMI Cable"
        ' 
        ' atc_hdmi
        ' 
        atc_hdmi.BackColor = Color.White
        atc_hdmi.Cursor = Cursors.Hand
        atc_hdmi.FlatStyle = FlatStyle.Flat
        atc_hdmi.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        atc_hdmi.Location = New Point(155, 85)
        atc_hdmi.Name = "atc_hdmi"
        atc_hdmi.Size = New Size(108, 34)
        atc_hdmi.TabIndex = 6
        atc_hdmi.Text = "Add To Cart"
        atc_hdmi.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(pic_mouse)
        Panel3.Controls.Add(atc_mouse)
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(598, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(280, 130)
        Panel3.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Consolas", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(149, 47)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 18)
        Label6.TabIndex = 13
        Label6.Text = "₱ 560.00"
        ' 
        ' pic_mouse
        ' 
        pic_mouse.BackColor = Color.Transparent
        pic_mouse.Image = CType(resources.GetObject("pic_mouse.Image"), Image)
        pic_mouse.ImageLocation = ""
        pic_mouse.Location = New Point(22, 16)
        pic_mouse.Name = "pic_mouse"
        pic_mouse.Size = New Size(116, 98)
        pic_mouse.SizeMode = PictureBoxSizeMode.Zoom
        pic_mouse.TabIndex = 11
        pic_mouse.TabStop = False
        ' 
        ' atc_mouse
        ' 
        atc_mouse.BackColor = Color.White
        atc_mouse.Cursor = Cursors.Hand
        atc_mouse.FlatStyle = FlatStyle.Flat
        atc_mouse.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        atc_mouse.Location = New Point(158, 86)
        atc_mouse.Name = "atc_mouse"
        atc_mouse.Size = New Size(108, 34)
        atc_mouse.TabIndex = 10
        atc_mouse.Text = "Add To Cart"
        atc_mouse.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(149, 22)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 19)
        Label7.TabIndex = 12
        Label7.Text = "• Mouse"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(pic_monitor)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(atc_monitor)
        Panel4.Location = New Point(284, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(308, 130)
        Panel4.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Consolas", 11.25F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(166, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 18)
        Label4.TabIndex = 9
        Label4.Text = "₱ 3,500.00"
        ' 
        ' pic_monitor
        ' 
        pic_monitor.BackColor = Color.Transparent
        pic_monitor.Image = CType(resources.GetObject("pic_monitor.Image"), Image)
        pic_monitor.ImageLocation = ""
        pic_monitor.Location = New Point(28, 5)
        pic_monitor.Name = "pic_monitor"
        pic_monitor.Size = New Size(130, 120)
        pic_monitor.SizeMode = PictureBoxSizeMode.Zoom
        pic_monitor.TabIndex = 7
        pic_monitor.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(166, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 19)
        Label5.TabIndex = 8
        Label5.Text = "• Monitor"
        ' 
        ' atc_monitor
        ' 
        atc_monitor.BackColor = Color.White
        atc_monitor.Cursor = Cursors.Hand
        atc_monitor.FlatStyle = FlatStyle.Flat
        atc_monitor.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        atc_monitor.Location = New Point(175, 86)
        atc_monitor.Name = "atc_monitor"
        atc_monitor.Size = New Size(108, 34)
        atc_monitor.TabIndex = 6
        atc_monitor.Text = "Add To Cart"
        atc_monitor.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(905, 498)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Computer Store"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(pic_keyboard, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        CType(pic_ram, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(pic_webcam, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(pic_headphone, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(pic_harddrive, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(pic_usb, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(pic_hdmi, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(pic_mouse, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(pic_monitor, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_addtpcart As Button
    Friend WithEvents atc_keyboard As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents pic_keyboard As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pic_monitor As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents atc_monitor As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents pic_mouse As PictureBox
    Friend WithEvents atc_mouse As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents pic_hdmi As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents atc_hdmi As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents pic_usb As PictureBox
    Friend WithEvents atc_usb As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents pic_harddrive As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents atc_harddrive As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents pic_headphone As PictureBox
    Friend WithEvents atc_headphone As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents pic_webcam As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents atc_webcam As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents pic_ram As PictureBox
    Friend WithEvents atc_ram As Button
    Friend WithEvents Label19 As Label

End Class
