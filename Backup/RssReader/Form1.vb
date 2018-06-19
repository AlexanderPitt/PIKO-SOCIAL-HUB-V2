Public Class Form1
    Private WithEvents RssReader As RSS.RssReader
    Private RssFeed As RSS.RssFeed

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        Try

            ' Affichage
            lblTitle.Text = ""
            lblDescription.Text = ""
            picImage.Image = Nothing
            lstRssItems.Items.Clear()

            ' Téléchargement du flux
            RssReader = New RSS.RssReader
            RssReader.Load(New Uri(txtURL.Text))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Reader_Completed(ByVal Sender As Object, ByVal e As RSS.RssReader.CompletedEventArgs) Handles RssReader.Completed
        RssFeed = e.Result
        'RssFeed.LoadImage()

        ' Affichage des résultats
        ShowDetailed()
        ShowJoli()
    End Sub

#Region " Detailed "

    Private Sub ShowDetailed()
        Me.lstChannelElements.Items.Clear()
        Me.lstItems.Items.Clear()
        For Each Tag As RSS.RssTag In RssFeed.Elements
            Me.lstChannelElements.Items.Add(Tag.Name & " = " & Tag.Value)
        Next
        For Each item As RSS.RssItem In RssFeed.Items
            Me.lstItems.Items.Add(item.title)
        Next
    End Sub


    Private Sub lstItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstItems.SelectedIndexChanged
        If lstItems.SelectedIndex >= 0 Then
            lstItemElements.Items.Clear()
            For Each Tag As RSS.RssTag In RssFeed.Items(lstItems.SelectedIndex).Elements
                Me.lstItemElements.Items.Add(Tag.Name & " = " & Tag.Value)
            Next
        End If
    End Sub

#End Region

#Region " Joli "

    Private Sub ShowJoli()
        lblTitle.Text = RssFeed.title
        lblDescription.Text = RssFeed.description
        picImage.Visible = False
        picImage.LoadAsync(RssFeed.imageUrl)

        For Each item As RSS.RssItem In RssFeed.Items
            lstRssItems.Items.Add(item)
        Next
    End Sub

    Private Sub picImage_LoadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles picImage.LoadCompleted
        picImage.Visible = True
    End Sub

    Private Sub lstRssItems_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles lstRssItems.MeasureItem
        e.ItemWidth = lstRssItems.Width
        Dim rssItem As RSS.RssItem = RssFeed.Items(e.Index)
        Dim DescrHeight As Integer = e.Graphics.MeasureString(rssItem.description, DescrFont, e.ItemWidth - 20).Height
        e.ItemHeight = 20 + DescrHeight
    End Sub
    Private Sub lstRssItems_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles lstRssItems.DrawItem
        Dim item As RSS.RssItem = RssFeed.Items(e.Index)
        ' Titre
        Dim titleRect As New Rectangle(0, e.Bounds.Top, e.Bounds.Width, 20)
        Dim TitleBrush As New Drawing2D.LinearGradientBrush(titleRect, Color.LightBlue, Color.Blue, Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(TitleBrush, titleRect)
        e.Graphics.DrawString(item.title, TitleFont, Brushes.White, titleRect)

        Dim DescrRect As New Rectangle(10, e.Bounds.Top + 20, e.Bounds.Width - 20, e.Bounds.Height - 20)
        e.Graphics.DrawString(item.description, DescrFont, Brushes.Black, DescrRect)
    End Sub
    Private TitleFont As New Font("Verdana", 10, FontStyle.Bold)
    Private DescrFont As New Font("Verdana", 10, FontStyle.Regular)
#End Region

   
End Class
