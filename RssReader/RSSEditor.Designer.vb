<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RSSEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RSSEditor))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButremoveListBoxRSSEDIT = New System.Windows.Forms.Button()
        Me.ButAddListBoxRSSEDIT = New System.Windows.Forms.Button()
        Me.ButUpdateListBoxRSSEDIT = New System.Windows.Forms.Button()
        Me.RichTextBox1RssEdit = New System.Windows.Forms.RichTextBox()
        Me.ButtonSaveRssList = New System.Windows.Forms.Button()
        Me.ListBox1RssList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1255, 888)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 62)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButremoveListBoxRSSEDIT
        '
        Me.ButremoveListBoxRSSEDIT.Location = New System.Drawing.Point(333, 913)
        Me.ButremoveListBoxRSSEDIT.Margin = New System.Windows.Forms.Padding(6)
        Me.ButremoveListBoxRSSEDIT.Name = "ButremoveListBoxRSSEDIT"
        Me.ButremoveListBoxRSSEDIT.Size = New System.Drawing.Size(116, 37)
        Me.ButremoveListBoxRSSEDIT.TabIndex = 30
        Me.ButremoveListBoxRSSEDIT.Text = "Remove"
        Me.ButremoveListBoxRSSEDIT.UseVisualStyleBackColor = True
        '
        'ButAddListBoxRSSEDIT
        '
        Me.ButAddListBoxRSSEDIT.Location = New System.Drawing.Point(205, 913)
        Me.ButAddListBoxRSSEDIT.Margin = New System.Windows.Forms.Padding(6)
        Me.ButAddListBoxRSSEDIT.Name = "ButAddListBoxRSSEDIT"
        Me.ButAddListBoxRSSEDIT.Size = New System.Drawing.Size(116, 37)
        Me.ButAddListBoxRSSEDIT.TabIndex = 29
        Me.ButAddListBoxRSSEDIT.Text = "Add"
        Me.ButAddListBoxRSSEDIT.UseVisualStyleBackColor = True
        '
        'ButUpdateListBoxRSSEDIT
        '
        Me.ButUpdateListBoxRSSEDIT.Location = New System.Drawing.Point(75, 913)
        Me.ButUpdateListBoxRSSEDIT.Margin = New System.Windows.Forms.Padding(6)
        Me.ButUpdateListBoxRSSEDIT.Name = "ButUpdateListBoxRSSEDIT"
        Me.ButUpdateListBoxRSSEDIT.Size = New System.Drawing.Size(116, 37)
        Me.ButUpdateListBoxRSSEDIT.TabIndex = 28
        Me.ButUpdateListBoxRSSEDIT.Text = "Update"
        Me.ButUpdateListBoxRSSEDIT.UseVisualStyleBackColor = True
        '
        'RichTextBox1RssEdit
        '
        Me.RichTextBox1RssEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RichTextBox1RssEdit.Location = New System.Drawing.Point(75, 823)
        Me.RichTextBox1RssEdit.Multiline = False
        Me.RichTextBox1RssEdit.Name = "RichTextBox1RssEdit"
        Me.RichTextBox1RssEdit.Size = New System.Drawing.Size(1155, 62)
        Me.RichTextBox1RssEdit.TabIndex = 38
        Me.RichTextBox1RssEdit.Text = ""
        '
        'ButtonSaveRssList
        '
        Me.ButtonSaveRssList.Location = New System.Drawing.Point(1255, 807)
        Me.ButtonSaveRssList.Name = "ButtonSaveRssList"
        Me.ButtonSaveRssList.Size = New System.Drawing.Size(248, 62)
        Me.ButtonSaveRssList.TabIndex = 39
        Me.ButtonSaveRssList.Text = "Save RSS List"
        Me.ButtonSaveRssList.UseVisualStyleBackColor = True
        '
        'ListBox1RssList
        '
        Me.ListBox1RssList.FormattingEnabled = True
        Me.ListBox1RssList.ItemHeight = 25
        Me.ListBox1RssList.Location = New System.Drawing.Point(75, 38)
        Me.ListBox1RssList.Name = "ListBox1RssList"
        Me.ListBox1RssList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1RssList.Size = New System.Drawing.Size(1155, 779)
        Me.ListBox1RssList.TabIndex = 40
        '
        'RSSEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1546, 965)
        Me.Controls.Add(Me.ListBox1RssList)
        Me.Controls.Add(Me.ButtonSaveRssList)
        Me.Controls.Add(Me.RichTextBox1RssEdit)
        Me.Controls.Add(Me.ButremoveListBoxRSSEDIT)
        Me.Controls.Add(Me.ButAddListBoxRSSEDIT)
        Me.Controls.Add(Me.ButUpdateListBoxRSSEDIT)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RSSEditor"
        Me.Text = "RSS Feed List Editor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButremoveListBoxRSSEDIT As System.Windows.Forms.Button
    Friend WithEvents ButAddListBoxRSSEDIT As System.Windows.Forms.Button
    Friend WithEvents ButUpdateListBoxRSSEDIT As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1RssEdit As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonSaveRssList As System.Windows.Forms.Button
    Friend WithEvents ListBox1RssList As System.Windows.Forms.ListBox
End Class
