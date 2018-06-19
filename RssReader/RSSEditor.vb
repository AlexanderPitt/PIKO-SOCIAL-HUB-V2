Public Class RSSEditor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
    End Sub

    Private Sub RSSEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On ecrit les URL dans la ListView à partir du Fichier
        Dim swr As New System.IO.StreamReader("C:\Users\All Users\Piko Software\Piko Social Hub\Piko_URls.txt")


        Do Until swr.Peek = -1
            Dim Ligne As String
            Ligne = swr.ReadLine()

            Me.ListBox1RssList.Items.Add(Ligne)
        Loop
        Me.ListBox1RssList.Text = ListBox1RssList.ToString

        swr.Close()
    End Sub

    Private Sub ButUpdateListBoxViewFinal_Click(sender As Object, e As EventArgs) Handles ButUpdateListBoxRSSEDIT.Click
        If ListBox1RssList.Items.Count > 0 Then
            ListBox1RssList.Items(ListBox1RssList.SelectedIndex) = RichTextBox1RssEdit.Text

        Else
        End If
    End Sub


   


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSaveRssList.Click
        
        Dim sw As New System.IO.StreamWriter("C:\Users\All Users\Piko Software\Piko Social Hub\Piko_URls.txt")

        For Each element As Object In Me.ListBox1RssList.Items

      

            sw.WriteLine(element.ToString)
        Next



        sw.Close()
        sw.Dispose()
        MessageBox.Show("Rss List saved                          .")
    End Sub

   
    

    Private Sub ListViewRSSEditor_SelectedIndexChanged(sender As Object, e As EventArgs)
        RichTextBox1RssEdit.Clear()

        '  RichTextBox1RssEdit.Text = Me.ListViewRSSEditor.SelectedItems.Items(0).Subitems(1).Text
        ' RichTextBox1RssEdit.Text = Me.ListViewRSSEditor.SelectedItems.Item.text
    End Sub

    Private Sub ListBox1RssList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1RssList.SelectedIndexChanged
        RichTextBox1RssEdit.Text = Me.ListBox1RssList.Text

    End Sub

    Private Sub ButAddListBoxRSSEDIT_Click(sender As Object, e As EventArgs) Handles ButAddListBoxRSSEDIT.Click
        If ListBox1RssList.Items.Count > 0 Then
            ListBox1RssList.Items.Add(RichTextBox1RssEdit.Text)

        Else
        End If
    End Sub

    Private Sub ButremoveListBoxRSSEDIT_Click(sender As Object, e As EventArgs) Handles ButremoveListBoxRSSEDIT.Click
        ListBox1RssList.Items.Remove(ListBox1RssList.SelectedItem)
        Me.RichTextBox1RssEdit.Clear()
    End Sub
End Class