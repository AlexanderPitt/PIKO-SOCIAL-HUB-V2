<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lstChannelElements = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListView1ChannelElements = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lstRssItems = New System.Windows.Forms.ListBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.txtUrl = New System.Windows.Forms.ComboBox()
        Me.ButSave1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxpathDest = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TextBoxRefresh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListViewBoxFinal = New System.Windows.Forms.ListView()
        Me.Col1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Col2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButUpdateListBoxViewFinal = New System.Windows.Forms.Button()
        Me.ButAddListBoxViewFinal = New System.Windows.Forms.Button()
        Me.ButremoveListBoxViewFinal = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ComboBox1ListTxtTemplate = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RichTextBox1FinalEdit = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RSSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenRSSListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ComboBoxSeparator = New System.Windows.Forms.ComboBox()
        Me.TextBoxSeparator = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabTxt = New System.Windows.Forms.TabPage()
        Me.LabelSeparateur = New System.Windows.Forms.Label()
        Me.TabBdd = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TextBoxRefresh2 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.BDDLOCATIONTEXTBOX = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabTxt.SuspendLayout()
        Me.TabBdd.SuspendLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "URL:"
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLoad.Location = New System.Drawing.Point(890, 134)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(6)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(174, 49)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load RSS"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'lstChannelElements
        '
        Me.lstChannelElements.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstChannelElements.FormattingEnabled = True
        Me.lstChannelElements.ItemHeight = 25
        Me.lstChannelElements.Location = New System.Drawing.Point(12, 56)
        Me.lstChannelElements.Margin = New System.Windows.Forms.Padding(6)
        Me.lstChannelElements.Name = "lstChannelElements"
        Me.lstChannelElements.Size = New System.Drawing.Size(992, 229)
        Me.lstChannelElements.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Channel Informations"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 294)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 25)
        Me.Label3.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(15, 212)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.TabControl1.MaximumSize = New System.Drawing.Size(1062, 2000)
        Me.TabControl1.MinimumSize = New System.Drawing.Size(1050, 1012)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1050, 1221)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.ListView1ChannelElements)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.lstChannelElements)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(8, 39)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(6)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(6)
        Me.TabPage1.Size = New System.Drawing.Size(1034, 1174)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListView1ChannelElements
        '
        Me.ListView1ChannelElements.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListView1ChannelElements.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1ChannelElements.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListView1ChannelElements.FullRowSelect = True
        Me.ListView1ChannelElements.Location = New System.Drawing.Point(10, 300)
        Me.ListView1ChannelElements.Margin = New System.Windows.Forms.Padding(6)
        Me.ListView1ChannelElements.Name = "ListView1ChannelElements"
        Me.ListView1ChannelElements.Size = New System.Drawing.Size(998, 862)
        Me.ListView1ChannelElements.SmallImageList = Me.ImageList1
        Me.ListView1ChannelElements.TabIndex = 11
        Me.ListView1ChannelElements.UseCompatibleStateImageBehavior = False
        Me.ListView1ChannelElements.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 38
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item"
        Me.ColumnHeader2.Width = 491
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "rss.png")
        Me.ImageList1.Images.SetKeyName(1, "human-user-icone-7988-128.png")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lstRssItems)
        Me.TabPage2.Controls.Add(Me.lblDescription)
        Me.TabPage2.Controls.Add(Me.lblTitle)
        Me.TabPage2.Controls.Add(Me.picImage)
        Me.TabPage2.Location = New System.Drawing.Point(8, 39)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(6)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(6)
        Me.TabPage2.Size = New System.Drawing.Size(1034, 1174)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Regular View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lstRssItems
        '
        Me.lstRssItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstRssItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.lstRssItems.FormattingEnabled = True
        Me.lstRssItems.Location = New System.Drawing.Point(6, 113)
        Me.lstRssItems.Margin = New System.Windows.Forms.Padding(6)
        Me.lstRssItems.Name = "lstRssItems"
        Me.lstRssItems.Size = New System.Drawing.Size(1354, 729)
        Me.lstRssItems.TabIndex = 4
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDescription.Location = New System.Drawing.Point(12, 69)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(26, 37)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = " "
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 23)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(31, 44)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = " "
        '
        'picImage
        '
        Me.picImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picImage.Location = New System.Drawing.Point(1182, 12)
        Me.picImage.Margin = New System.Windows.Forms.Padding(6)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(176, 60)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage.TabIndex = 3
        Me.picImage.TabStop = False
        '
        'txtUrl
        '
        Me.txtUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUrl.FormattingEnabled = True
        Me.txtUrl.Location = New System.Drawing.Point(33, 77)
        Me.txtUrl.Margin = New System.Windows.Forms.Padding(6)
        Me.txtUrl.MaximumSize = New System.Drawing.Size(790, 0)
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(790, 33)
        Me.txtUrl.TabIndex = 12
        '
        'ButSave1
        '
        Me.ButSave1.Location = New System.Drawing.Point(859, 249)
        Me.ButSave1.Margin = New System.Windows.Forms.Padding(6)
        Me.ButSave1.Name = "ButSave1"
        Me.ButSave1.Size = New System.Drawing.Size(182, 38)
        Me.ButSave1.TabIndex = 13
        Me.ButSave1.Text = "Save To Piko"
        Me.ButSave1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(26, 154)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(290, 29)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.Text = "Auto Save Incoming Feed"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'Timer4
        '
        Me.Timer4.Interval = 5000
        '
        'TextBoxpathDest
        '
        Me.TextBoxpathDest.Location = New System.Drawing.Point(26, 9)
        Me.TextBoxpathDest.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBoxpathDest.Name = "TextBoxpathDest"
        Me.TextBoxpathDest.Size = New System.Drawing.Size(872, 31)
        Me.TextBoxpathDest.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(921, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 38)
        Me.Button1.TabIndex = 17
        Me.Button1.Tag = "Select Ouput Folder"
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(350, 152)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(6)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(282, 90)
        Me.TrackBar1.TabIndex = 18
        Me.TrackBar1.Tag = "Allows to Select Refresh Frequency"
        '
        'TextBoxRefresh
        '
        Me.TextBoxRefresh.Location = New System.Drawing.Point(644, 152)
        Me.TextBoxRefresh.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBoxRefresh.Name = "TextBoxRefresh"
        Me.TextBoxRefresh.Size = New System.Drawing.Size(44, 31)
        Me.TextBoxRefresh.TabIndex = 19
        Me.TextBoxRefresh.Text = "1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(700, 152)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Minute(s)"
        '
        'ListViewBoxFinal
        '
        Me.ListViewBoxFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ListViewBoxFinal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Col1, Me.Col2})
        Me.ListViewBoxFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListViewBoxFinal.FullRowSelect = True
        Me.ListViewBoxFinal.HideSelection = False
        Me.ListViewBoxFinal.Location = New System.Drawing.Point(1192, 77)
        Me.ListViewBoxFinal.Margin = New System.Windows.Forms.Padding(6)
        Me.ListViewBoxFinal.Name = "ListViewBoxFinal"
        Me.ListViewBoxFinal.Size = New System.Drawing.Size(1066, 849)
        Me.ListViewBoxFinal.SmallImageList = Me.ImageList1
        Me.ListViewBoxFinal.TabIndex = 23
        Me.ListViewBoxFinal.UseCompatibleStateImageBehavior = False
        Me.ListViewBoxFinal.View = System.Windows.Forms.View.Details
        '
        'Col1
        '
        Me.Col1.Text = ""
        Me.Col1.Width = 38
        '
        'Col2
        '
        Me.Col2.Text = "Items to Send Manually"
        Me.Col2.Width = 491
        '
        'ButUpdateListBoxViewFinal
        '
        Me.ButUpdateListBoxViewFinal.Location = New System.Drawing.Point(1200, 1041)
        Me.ButUpdateListBoxViewFinal.Margin = New System.Windows.Forms.Padding(6)
        Me.ButUpdateListBoxViewFinal.Name = "ButUpdateListBoxViewFinal"
        Me.ButUpdateListBoxViewFinal.Size = New System.Drawing.Size(116, 37)
        Me.ButUpdateListBoxViewFinal.TabIndex = 25
        Me.ButUpdateListBoxViewFinal.Text = "Update"
        Me.ButUpdateListBoxViewFinal.UseVisualStyleBackColor = True
        '
        'ButAddListBoxViewFinal
        '
        Me.ButAddListBoxViewFinal.Location = New System.Drawing.Point(1342, 1041)
        Me.ButAddListBoxViewFinal.Margin = New System.Windows.Forms.Padding(6)
        Me.ButAddListBoxViewFinal.Name = "ButAddListBoxViewFinal"
        Me.ButAddListBoxViewFinal.Size = New System.Drawing.Size(116, 37)
        Me.ButAddListBoxViewFinal.TabIndex = 26
        Me.ButAddListBoxViewFinal.Text = "Add"
        Me.ButAddListBoxViewFinal.UseVisualStyleBackColor = True
        '
        'ButremoveListBoxViewFinal
        '
        Me.ButremoveListBoxViewFinal.Location = New System.Drawing.Point(1486, 1041)
        Me.ButremoveListBoxViewFinal.Margin = New System.Windows.Forms.Padding(6)
        Me.ButremoveListBoxViewFinal.Name = "ButremoveListBoxViewFinal"
        Me.ButremoveListBoxViewFinal.Size = New System.Drawing.Size(116, 37)
        Me.ButremoveListBoxViewFinal.TabIndex = 27
        Me.ButremoveListBoxViewFinal.Text = "Remove"
        Me.ButremoveListBoxViewFinal.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = Global.PikoSocialHub.My.Resources.Resources.IconeMoveDown
        Me.Button6.Location = New System.Drawing.Point(1076, 1041)
        Me.Button6.Margin = New System.Windows.Forms.Padding(6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 104)
        Me.Button6.TabIndex = 31
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = Global.PikoSocialHub.My.Resources.Resources.IconeMoveUp
        Me.Button5.Location = New System.Drawing.Point(1074, 302)
        Me.Button5.Margin = New System.Windows.Forms.Padding(6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 104)
        Me.Button5.TabIndex = 30
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.PikoSocialHub.My.Resources.Resources.IconeHautList
        Me.Button4.Location = New System.Drawing.Point(1076, 412)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 104)
        Me.Button4.TabIndex = 29
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.PikoSocialHub.My.Resources.Resources.IconeBasList
        Me.Button3.Location = New System.Drawing.Point(1075, 934)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 104)
        Me.Button3.TabIndex = 28
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = Global.PikoSocialHub.My.Resources.Resources.ArrowTRight2
        Me.Button2.Location = New System.Drawing.Point(1074, 656)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 104)
        Me.Button2.TabIndex = 22
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(26, 254)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(6)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(794, 33)
        Me.ProgressBar1.TabIndex = 32
        '
        'Timer2
        '
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(921, 48)
        Me.Button8.Margin = New System.Windows.Forms.Padding(6)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(120, 38)
        Me.Button8.TabIndex = 34
        Me.Button8.Text = "Refresh"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ComboBox1ListTxtTemplate
        '
        Me.ComboBox1ListTxtTemplate.FormattingEnabled = True
        Me.ComboBox1ListTxtTemplate.Location = New System.Drawing.Point(26, 48)
        Me.ComboBox1ListTxtTemplate.Margin = New System.Windows.Forms.Padding(6)
        Me.ComboBox1ListTxtTemplate.Name = "ComboBox1ListTxtTemplate"
        Me.ComboBox1ListTxtTemplate.Size = New System.Drawing.Size(872, 33)
        Me.ComboBox1ListTxtTemplate.TabIndex = 35
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'RichTextBox1FinalEdit
        '
        Me.RichTextBox1FinalEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RichTextBox1FinalEdit.Location = New System.Drawing.Point(1192, 952)
        Me.RichTextBox1FinalEdit.Name = "RichTextBox1FinalEdit"
        Me.RichTextBox1FinalEdit.Size = New System.Drawing.Size(1066, 62)
        Me.RichTextBox1FinalEdit.TabIndex = 37
        Me.RichTextBox1FinalEdit.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RSSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(2278, 40)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(151, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'RSSToolStripMenuItem
        '
        Me.RSSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenRSSListToolStripMenuItem})
        Me.RSSToolStripMenuItem.Name = "RSSToolStripMenuItem"
        Me.RSSToolStripMenuItem.Size = New System.Drawing.Size(67, 36)
        Me.RSSToolStripMenuItem.Text = "RSS"
        '
        'OpenRSSListToolStripMenuItem
        '
        Me.OpenRSSListToolStripMenuItem.Name = "OpenRSSListToolStripMenuItem"
        Me.OpenRSSListToolStripMenuItem.Size = New System.Drawing.Size(268, 38)
        Me.OpenRSSListToolStripMenuItem.Text = "Edit RSS List"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(890, 72)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(174, 48)
        Me.Button7.TabIndex = 39
        Me.Button7.Text = "Refresh List"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ComboBoxSeparator
        '
        Me.ComboBoxSeparator.FormattingEnabled = True
        Me.ComboBoxSeparator.Items.AddRange(New Object() {"  ", "   ❑   ", "   ●   ", "   ♦   "})
        Me.ComboBoxSeparator.Location = New System.Drawing.Point(451, 101)
        Me.ComboBoxSeparator.Name = "ComboBoxSeparator"
        Me.ComboBoxSeparator.Size = New System.Drawing.Size(181, 33)
        Me.ComboBoxSeparator.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.ComboBoxSeparator, "Separator between Items. Default (None)")
        '
        'TextBoxSeparator
        '
        Me.TextBoxSeparator.Location = New System.Drawing.Point(221, 101)
        Me.TextBoxSeparator.Name = "TextBoxSeparator"
        Me.TextBoxSeparator.Size = New System.Drawing.Size(181, 31)
        Me.TextBoxSeparator.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.TextBoxSeparator, "Separator between Items. Default (None)")
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"  ", "   ❑   ", "   ●   ", "   ♦   "})
        Me.ComboBox1.Location = New System.Drawing.Point(451, 99)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 33)
        Me.ComboBox1.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Separator between Items. Default (None)")
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(221, 99)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 31)
        Me.TextBox1.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Separator between Items. Default (None)")
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabTxt)
        Me.TabControl2.Controls.Add(Me.TabBdd)
        Me.TabControl2.Location = New System.Drawing.Point(1192, 1098)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1066, 343)
        Me.TabControl2.TabIndex = 45
        '
        'TabTxt
        '
        Me.TabTxt.Controls.Add(Me.LabelSeparateur)
        Me.TabTxt.Controls.Add(Me.ComboBoxSeparator)
        Me.TabTxt.Controls.Add(Me.TextBoxSeparator)
        Me.TabTxt.Controls.Add(Me.ButSave1)
        Me.TabTxt.Controls.Add(Me.ProgressBar1)
        Me.TabTxt.Controls.Add(Me.Label5)
        Me.TabTxt.Controls.Add(Me.TrackBar1)
        Me.TabTxt.Controls.Add(Me.TextBoxRefresh)
        Me.TabTxt.Controls.Add(Me.Button8)
        Me.TabTxt.Controls.Add(Me.ComboBox1ListTxtTemplate)
        Me.TabTxt.Controls.Add(Me.CheckBox1)
        Me.TabTxt.Controls.Add(Me.TextBoxpathDest)
        Me.TabTxt.Controls.Add(Me.Button1)
        Me.TabTxt.Location = New System.Drawing.Point(8, 39)
        Me.TabTxt.Name = "TabTxt"
        Me.TabTxt.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTxt.Size = New System.Drawing.Size(1050, 296)
        Me.TabTxt.TabIndex = 0
        Me.TabTxt.Text = "Export Texte Piko"
        Me.TabTxt.UseVisualStyleBackColor = True
        '
        'LabelSeparateur
        '
        Me.LabelSeparateur.AutoSize = True
        Me.LabelSeparateur.Location = New System.Drawing.Point(21, 104)
        Me.LabelSeparateur.Name = "LabelSeparateur"
        Me.LabelSeparateur.Size = New System.Drawing.Size(154, 25)
        Me.LabelSeparateur.TabIndex = 45
        Me.LabelSeparateur.Text = "Text Separator"
        '
        'TabBdd
        '
        Me.TabBdd.Controls.Add(Me.BDDLOCATIONTEXTBOX)
        Me.TabBdd.Controls.Add(Me.Label4)
        Me.TabBdd.Controls.Add(Me.ComboBox1)
        Me.TabBdd.Controls.Add(Me.TextBox1)
        Me.TabBdd.Controls.Add(Me.ProgressBar2)
        Me.TabBdd.Controls.Add(Me.Label6)
        Me.TabBdd.Controls.Add(Me.TrackBar2)
        Me.TabBdd.Controls.Add(Me.TextBoxRefresh2)
        Me.TabBdd.Controls.Add(Me.CheckBox2)
        Me.TabBdd.Controls.Add(Me.Button12)
        Me.TabBdd.Location = New System.Drawing.Point(8, 39)
        Me.TabBdd.Name = "TabBdd"
        Me.TabBdd.Padding = New System.Windows.Forms.Padding(3)
        Me.TabBdd.Size = New System.Drawing.Size(1050, 296)
        Me.TabBdd.TabIndex = 1
        Me.TabBdd.Text = "Export BDD GTB"
        Me.TabBdd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 25)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Text Separator"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(26, 252)
        Me.ProgressBar2.Margin = New System.Windows.Forms.Padding(6)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(794, 33)
        Me.ProgressBar2.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(700, 150)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 25)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Minute(s)"
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(350, 150)
        Me.TrackBar2.Margin = New System.Windows.Forms.Padding(6)
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(282, 90)
        Me.TrackBar2.TabIndex = 47
        Me.TrackBar2.Tag = "Allows to Select Refresh Frequency"
        '
        'TextBoxRefresh2
        '
        Me.TextBoxRefresh2.Location = New System.Drawing.Point(644, 150)
        Me.TextBoxRefresh2.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBoxRefresh2.Name = "TextBoxRefresh2"
        Me.TextBoxRefresh2.Size = New System.Drawing.Size(44, 31)
        Me.TextBoxRefresh2.TabIndex = 48
        Me.TextBoxRefresh2.Text = "1"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(26, 152)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(290, 29)
        Me.CheckBox2.TabIndex = 46
        Me.CheckBox2.Text = "Auto Save Incoming Feed"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(688, 11)
        Me.Button12.Margin = New System.Windows.Forms.Padding(6)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(339, 38)
        Me.Button12.TabIndex = 28
        Me.Button12.Text = "Save To GTB's DataBase"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'BDDLOCATIONTEXTBOX
        '
        Me.BDDLOCATIONTEXTBOX.Enabled = False
        Me.BDDLOCATIONTEXTBOX.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.BDDLOCATIONTEXTBOX.Location = New System.Drawing.Point(26, 15)
        Me.BDDLOCATIONTEXTBOX.Name = "BDDLOCATIONTEXTBOX"
        Me.BDDLOCATIONTEXTBOX.Size = New System.Drawing.Size(606, 31)
        Me.BDDLOCATIONTEXTBOX.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.BDDLOCATIONTEXTBOX, "Data Base Location")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(2278, 1461)
        Me.Controls.Add(Me.ButUpdateListBoxViewFinal)
        Me.Controls.Add(Me.ButAddListBoxViewFinal)
        Me.Controls.Add(Me.ButremoveListBoxViewFinal)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.RichTextBox1FinalEdit)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListViewBoxFinal)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtUrl)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "PIKO SOCIAL HUB V2.0"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabTxt.ResumeLayout(False)
        Me.TabTxt.PerformLayout()
        Me.TabBdd.ResumeLayout(False)
        Me.TabBdd.PerformLayout()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents lstChannelElements As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents txtUrl As System.Windows.Forms.ComboBox
    Friend WithEvents lstRssItems As System.Windows.Forms.ListBox
    Friend WithEvents ButSave1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents TextBoxpathDest As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents TextBoxRefresh As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListView1ChannelElements As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListViewBoxFinal As System.Windows.Forms.ListView
    Friend WithEvents Col1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Col2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ButUpdateListBoxViewFinal As System.Windows.Forms.Button
    Friend WithEvents ButAddListBoxViewFinal As System.Windows.Forms.Button
    Friend WithEvents ButremoveListBoxViewFinal As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1ListTxtTemplate As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RichTextBox1FinalEdit As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RSSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenRSSListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ComboBoxSeparator As ComboBox
    Friend WithEvents TextBoxSeparator As TextBox
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabTxt As TabPage
    Friend WithEvents TabBdd As TabPage
    Friend WithEvents LabelSeparateur As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label6 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TextBoxRefresh2 As TextBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents BDDLOCATIONTEXTBOX As TextBox
End Class
