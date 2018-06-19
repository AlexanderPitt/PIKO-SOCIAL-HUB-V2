Imports System.IO
Module CompactBDD
    Sub Main()
        Try


            Dim File_Path, compact_file As String
            'Original file path that u want to compact
            File_Path = AppDomain.CurrentDomain.BaseDirectory & "C:\Users\All Users\Piko Software\Piko Social Hub\GTB.MDB"
            'compact file path, a temp file
            compact_file = AppDomain.CurrentDomain.BaseDirectory & "C:\Users\All Users\Piko Software\Piko Social Hub\GTBTEMP.MDB"
            'First check the file u want to compact exists or not


            Dim je As New JRO.JetEngine
            ' Make sure that a file doesn't exist with the name of
            ' the compacted database.
            If Dir() "C:\Users\All Users\Piko Software\Piko Social Hub\GTBTEMP.MDB"  <> "" Then Kill _
      "C:\Users\All Users\Piko Software\Piko Social Hub\GTBTEMP.MDB"

   ' Compacts and encrypts version Northwind database.
                je.CompactDatabase _
   "Provider=Microsoft.Jet.OLEDB.4.0;" &
      "Data Source=C:\Users\All Users\Piko Software\Piko Social Hub\GTB.MDB",
   "Provider=Microsoft.Jet.OLEDB.4.0;" &
      "Data Source=C:\Users\All Users\Piko Software\Piko Social Hub\GTBTEMP.MDB"

                End If



            'restore the original file from the compacted file
            If File.Exists(compact_file) Then
                File.Delete(File_Path)
                File.Move(compact_file, File_Path)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
Public Class Form1
    Private WithEvents RssReader As RSS.RssReader
    Private RssFeed As RSS.RssFeed
    Dim bdd As String = "C:\Users\All Users\Piko Software\Piko Social Hub\GTB.MDB"



    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        Try

            ' Affichage
            lblTitle.Text = ""
            lblDescription.Text = ""
            picImage.Image = Nothing
            lstRssItems.Items.Clear()

            ' Téléchargement du flux
            RssReader = New RSS.RssReader
            RssReader.Load(New Uri(txtUrl.Text))

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
        Dim arr As String() = New String(2) {}
        Dim itm As ListViewItem
        Me.lstChannelElements.Items.Clear()
        Me.ListView1ChannelElements.Items.Clear()
        For Each Tag As RSS.RssTag In RssFeed.Elements
            Me.lstChannelElements.Items.Add(Tag.Name & " = " & Tag.Value)

        Next
        For Each item As RSS.RssItem In RssFeed.Items
            '  Me.lstItems.Items.Add(item.title)

            arr(0) = ("")
            arr(1) = (item.title)
            itm = New ListViewItem(arr)

            Me.ListView1ChannelElements.Items.Add(itm)

            itm.ImageIndex = 0
        Next

    End Sub

    Private Sub ListView1ChannelElements_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1ChannelElements.SelectedIndexChanged
        ' Private Sub lstItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstItems.SelectedIndexChanged
        '   If lstItems.SelectedIndex >= 0 Then
        '       lstItemElements.Items.Clear()
        '       For Each Tag As RSS.RssTag In RssFeed.Items(lstItems.SelectedIndex).Elements
        '           Me.lstItemElements.Items.Add(Tag.Name & " = " & Tag.Value)
        '      Next
        '  End If
        ' End Sub
    End Sub





#End Region

#Region " Joli "

    Private Sub ShowJoli()
        lblTitle.Text = RssFeed.title
        lblDescription.Text = RssFeed.description
        picImage.Visible = False
        If RssFeed.imageUrl IsNot "" Then picImage.LoadAsync(RssFeed.imageUrl)

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




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButSave1.Click

        Dim pathclear As String = (TextBoxpathDest.Text)

        File.Delete(pathclear & ComboBox1ListTxtTemplate.Text)

        System.IO.File.WriteAllText(pathclear & ComboBox1ListTxtTemplate.Text, "")
        Dim path As String = (TextBoxpathDest.Text) + "\"
        Dim sw As New System.IO.StreamWriter(path & ComboBox1ListTxtTemplate.Text, True, System.Text.Encoding.UTF8)

        Dim liste As ListView.ListViewItemCollection = ListViewBoxFinal.Items
        For Each item As ListViewItem In liste

            sw.WriteLine(item.SubItems(1).Text + (TextBoxSeparator.Text))
        Next



        sw.Close()
        sw.Dispose()
        MessageBox.Show("Text for Template Saved                          .")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Timer1.Interval = (TrackBar1.Value + (1 * 60000))
            Timer1.Enabled = True
            Timer2.Interval = (TrackBar1.Value + (1 * 600))
            Timer2.Enabled = True



            btnLoad.PerformClick()

            Dim pathclear As String = (TextBoxpathDest.Text)
            File.Delete(pathclear & ComboBox1ListTxtTemplate.Text)
            System.IO.File.WriteAllText(pathclear & ComboBox1ListTxtTemplate.Text, "")
            Dim path As String = (TextBoxpathDest.Text) + "\"
            Dim sw As New System.IO.StreamWriter(path & ComboBox1ListTxtTemplate.Text, True, System.Text.Encoding.UTF8)

            Dim liste As ListView.ListViewItemCollection = ListView1ChannelElements.Items
            For Each item As ListViewItem In liste

                sw.WriteLine(item.SubItems(1).Text)
            Next

            sw.Close()
            sw.Dispose()




        End If

        If CheckBox1.Checked = False Then Timer1.Enabled = False
        If CheckBox1.Checked = False Then Timer2.Enabled = False
        If CheckBox1.Checked = False Then ProgressBar1.Value = 0

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        btnLoad.PerformClick()

        Dim pathclear As String = (TextBoxpathDest.Text)
        System.IO.File.WriteAllText(pathclear & ComboBox1ListTxtTemplate.Text, "")
        Dim path As String = (TextBoxpathDest.Text) + "\"
        Dim sw As New System.IO.StreamWriter(path & ComboBox1ListTxtTemplate.Text, True, System.Text.Encoding.UTF8)

        Dim liste As ListView.ListViewItemCollection = ListView1ChannelElements.Items
        For Each item As ListViewItem In liste

            sw.WriteLine(item.SubItems(1).Text)
        Next

        sw.Close()
        sw.Dispose()
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick


        btnLoad.PerformClick()

        'enregistrement auto dans la base de données.
        Try

            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                '.CommandText = "INSERT INTO tblStudent (Snum,Sname)VALUES "
                .CommandText = "DELETE * from tblGTB"
                cm.ExecuteNonQuery()
                '(Snum,Sname)VALUES" & valeurs.TrimEnd(",")

                Dim liste As ListView.ListViewItemCollection = ListView1ChannelElements.Items
                Dim valeurs = ""
                Dim Compteur = 0
                For Each item As ListViewItem In liste
                    Compteur = Compteur + 1
                    .CommandText = "INSERT INTO tblGTB (ID,Label)VALUES" & "(" & Compteur & ",'" & item.SubItems(1).Text.Replace("'", "''") & "')".TrimEnd(",")
                    cm.ExecuteNonQuery()
                    'valeurs = valeurs & "(" & Compteur & ",'" & item.SubItems(1).Text.Replace("'", "''") & "')," & Environment.NewLine

                Next

                'MsgBox("Record saved.", MsgBoxStyle.Information)

                Exit Sub
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.Description = "Please Select the Folder where you want to record your File"
        ' FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim selected_folder As String = FolderBrowserDialog1.SelectedPath
            TextBoxpathDest.Text = selected_folder
            MsgBox("Vous avez sélectionné le dossier : " & IO.Path.GetFileName(selected_folder))
        Else
            ' Si l'utilisateur n'a pas sélectionné de dossier, on lui affiche un avertissement
            MsgBox("Aucun dossier n'a été sélectionné", MsgBoxStyle.Exclamation, "Aucun dossier sélectionné")

        End If

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ' Timer1.Interval = 1 + (TrackBar1.Value * (1000 * 60))
        TextBoxRefresh.Text = TrackBar1.Value + 1
    End Sub
    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        ' Timer1.Interval = 1 + (TrackBar1.Value * (1000 * 60))
        TextBoxRefresh.Text = TrackBar2.Value + 1
    End Sub

    Private Sub TextBoxRefresh_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRefresh.TextChanged
        Timer1.Interval = TextBoxRefresh.Text * (1000 * 60) + 60000
    End Sub
    Private Sub TextBoxRefresh2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRefresh2.TextChanged
        Timer3.Interval = TextBoxRefresh2.Text * (1000 * 60) + 60000
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For Each ChannelItemElements As ListViewItem In Me.ListView1ChannelElements.SelectedItems
            Me.ListViewBoxFinal.Items.Add(ChannelItemElements.Clone)



            Me.ListView1ChannelElements.Items.Remove(ListView1ChannelElements.SelectedItems.Item(0))
        Next




    End Sub


    Private Sub ListViewBoxFinal_Click(sender As Object, e As EventArgs) Handles ListViewBoxFinal.Click
        'TextBoxEditFinal.Clear()
        RichTextBox1FinalEdit.Clear()
        'TextBoxEditFinal.Text = Me.ListViewBoxFinal.SelectedItems.Item(0).SubItems(1).Text
        RichTextBox1FinalEdit.Text = Me.ListViewBoxFinal.SelectedItems.Item(0).SubItems(1).Text

    End Sub

    Private Sub ButUpdateListBoxViewFinal_Click(sender As Object, e As EventArgs) Handles ButUpdateListBoxViewFinal.Click

        If ListViewBoxFinal.Items.Count > 0 Then
            ListViewBoxFinal.SelectedItems(0).SubItems(1).Text = RichTextBox1FinalEdit.Text
            ' ListViewBoxFinal.SelectedItems(0).SubItems(1).Text = TextBoxEditFinal.Text
        Else
        End If

    End Sub

    Private Sub ButAddListBoxViewFinal_Click(sender As Object, e As EventArgs) Handles ButAddListBoxViewFinal.Click

        Dim arr1 As String() = New String(2) {}
        Dim itm2 As ListViewItem


        ' arr1(0) = ("Prout")
        ' arr1(1) = (TextBoxEditFinal.Text)
        arr1(1) = (RichTextBox1FinalEdit.Text)
        itm2 = New ListViewItem(arr1)

        Me.ListViewBoxFinal.Items.Add(itm2)
        itm2.ImageIndex = 1


        ' ListViewBoxFinal.Items.Insert(0, 1, "Toto")
    End Sub


    Private Sub ButremoveListBoxViewFinal_Click(sender As Object, e As EventArgs) Handles ButremoveListBoxViewFinal.Click
        For Each LiveboxFinalElements As ListViewItem In Me.ListViewBoxFinal.SelectedItems


            Me.ListViewBoxFinal.Items.Remove(ListViewBoxFinal.SelectedItems.Item(0))
        Next

        'Me.ListViewBoxFinal.Items.Remove(ListViewBoxFinal.SelectedItems.Item(0))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim i, j As Integer
        Dim Cache As String
        Dim SelIdx As Integer
        Dim LstCount As Integer = ListViewBoxFinal.Items.Count
        Dim LstSelCount As Integer = ListViewBoxFinal.SelectedItems.Count - 1
        Dim rSelIdx(LstSelCount, 0) As String
        Dim BottDiff As Integer = ListViewBoxFinal.SelectedItems(ListViewBoxFinal.SelectedItems.Count - 1).Index
        Dim k As Integer = 0
        i = LstSelCount
        'On récupère tous les id dans un tableau pour les traités dans l'ordre inverse (du dernier au premier)
        For Each SelItem As ListViewItem In ListViewBoxFinal.SelectedItems
            rSelIdx(i, 0) = CStr(CInt(SelItem.Index))
            i -= 1
        Next
        For j = 0 To LstSelCount
            SelIdx = CInt(rSelIdx(j, 0))
            'Si on ne sait pas/plus le descendre on s'arrête
            If SelIdx = ListViewBoxFinal.Items.Count - 1 Then
                ListViewBoxFinal.Refresh()
                ListViewBoxFinal.Focus()
                Exit Sub
            End If
            k += 1
            'On inverse l'item/le subitem du dessous par celui du dessus
            For i = 0 To ListViewBoxFinal.Items(SelIdx).SubItems.Count - 1
                Cache = ListViewBoxFinal.Items(LstCount - k).SubItems(i).Text
                ListViewBoxFinal.Items(LstCount - k).SubItems(i).Text = ListViewBoxFinal.Items(SelIdx).SubItems(i).Text
                'On remonte tous les items en dessous de l'item en cours de traitement
                For l As Integer = SelIdx To LstCount - (k + 1)
                    ListViewBoxFinal.Items(l).SubItems(i).Text = ListViewBoxFinal.Items(l + 1).SubItems(i).Text
                Next
                ListViewBoxFinal.Items(LstCount - (k + 1)).SubItems(i).Text = Cache
            Next
            'On inverse la sélection
            ListViewBoxFinal.Items(ListViewBoxFinal.Items.Count - k).Selected = True
            ListViewBoxFinal.Items(SelIdx).Selected = False
        Next
        ListViewBoxFinal.Refresh()
        ListViewBoxFinal.Focus()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer
        Dim Cache As String
        Dim SelIdx As Integer
        Dim TopDiff As Integer = ListViewBoxFinal.SelectedItems(0).Index
        Dim k As Integer = 1
        'On traite tous les items sélectionné
        For Each SelItem As ListViewItem In ListViewBoxFinal.SelectedItems
            'On récupère l'id de l'item en cours de traitement
            SelIdx = SelItem.Index
            'Si on ne sait pas/plus le monter on s'arrête
            If SelIdx = 0 Then
                ListViewBoxFinal.Refresh()
                ListViewBoxFinal.Focus()
                Exit Sub
            End If
            k += 1
            'On inverse l'item/le subitem du dessus par celui du dessous  
            For i = 0 To ListViewBoxFinal.Items(SelIdx).SubItems.Count - 1
                Cache = ListViewBoxFinal.Items(SelIdx - TopDiff).SubItems(i).Text
                ListViewBoxFinal.Items(SelIdx - TopDiff).SubItems(i).Text = ListViewBoxFinal.Items(SelIdx).SubItems(i).Text
                'On descend tous les items au-dessus de l'item en cours de traitement
                For j As Integer = SelIdx To k Step -1
                    ListViewBoxFinal.Items(j).SubItems(i).Text = ListViewBoxFinal.Items(j - 1).SubItems(i).Text
                Next
                ListViewBoxFinal.Items(SelIdx - TopDiff + 1).SubItems(i).Text = Cache
            Next
            'On inverse la sélection
            ListViewBoxFinal.Items(SelIdx - TopDiff).Selected = True
            ListViewBoxFinal.Items(SelIdx).Selected = False
        Next
        ListViewBoxFinal.Refresh()
        ListViewBoxFinal.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim i As Integer
        Dim Cache As String
        Dim SelIdx As Integer
        'On traite tous les items sélectionné
        For Each SelItem As ListViewItem In ListViewBoxFinal.SelectedItems
            'On récupère l'id de l'item en cours de traitement
            SelIdx = SelItem.Index
            'Si on ne sait pas/plus le monter on s'arrête
            If SelIdx = 0 Then
                ListViewBoxFinal.Refresh()
                ListViewBoxFinal.Focus()
                Exit Sub
            End If
            'On inverse l'item/le subitem du dessus par celui du dessous  
            For i = 0 To ListViewBoxFinal.Items(SelIdx).SubItems.Count - 1
                Cache = ListViewBoxFinal.Items(SelIdx - 1).SubItems(i).Text
                ListViewBoxFinal.Items(SelIdx - 1).SubItems(i).Text = ListViewBoxFinal.Items(SelIdx).SubItems(i).Text
                ListViewBoxFinal.Items(SelIdx).SubItems(i).Text = Cache
            Next
            'On inverse la sélection
            ListViewBoxFinal.Items(SelIdx - 1).Selected = True
            ListViewBoxFinal.Items(SelIdx).Selected = False
        Next
        'On refresh et on rend le focus
        ListViewBoxFinal.Refresh()
        ListViewBoxFinal.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim i, j As Integer
        Dim Cache As String
        Dim SelIdx As Integer
        Dim LstCount As Integer = ListViewBoxFinal.SelectedItems.Count - 1
        Dim rSelIdx(LstCount, 0) As String
        i = LstCount
        'On récupère tous les id dans un tableau pour les traités dans l'ordre inverse (du dernier au premier)
        For Each SelItem As ListViewItem In ListViewBoxFinal.SelectedItems
            rSelIdx(i, 0) = CStr(CInt(SelItem.Index))
            i -= 1
        Next
        For j = 0 To LstCount
            SelIdx = CInt(rSelIdx(j, 0))
            'Si on ne sait pas/plus le descendre on s'arrête
            If SelIdx = ListViewBoxFinal.Items.Count - 1 Then
                ListViewBoxFinal.Refresh()
                ListViewBoxFinal.Focus()
                Exit Sub
            End If
            'On inverse l'item/le subitem du dessous par celui du dessus
            For i = 0 To ListViewBoxFinal.Items(SelIdx).SubItems.Count - 1
                Cache = ListViewBoxFinal.Items(SelIdx + 1).SubItems(i).Text
                ListViewBoxFinal.Items(SelIdx + 1).SubItems(i).Text = ListViewBoxFinal.Items(SelIdx).SubItems(i).Text
                ListViewBoxFinal.Items(SelIdx).SubItems(i).Text = Cache
            Next
            'On inverse la sélection
            ListViewBoxFinal.Items(SelIdx + 1).Selected = True
            ListViewBoxFinal.Items(SelIdx).Selected = False
        Next
        ListViewBoxFinal.Refresh()
        ListViewBoxFinal.Focus()
    End Sub




    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Value += 1
        'TextBox1.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = 0

        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        ProgressBar2.Value += 1
        'TextBox1.Text = ProgressBar1.Value & "%"
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            ProgressBar2.Value = 0

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'On se connecte à la Base de Données Acces modconnection.vb
        Call connection()
        'On ecrit les URL dans la Combo à partir du Fichier
        Dim swr As New System.IO.StreamReader("C:\Users\All Users\Piko Software\Piko Social Hub\Piko_URls.txt")


        Do Until swr.Peek = -1
            Dim Ligne As String
            Ligne = swr.ReadLine()
            Me.txtUrl.Items.Add(Ligne)
        Loop
        If Me.txtUrl.Items.Count > 0 Then
            Me.txtUrl.Text = txtUrl.Items(0)
        End If

        swr.Close()

        'On Remplit le path pour les templates en lisant le fichier Ini

        Dim TextBoxpathDestVar = RecupereCleFichierIni("PathTemplates") 'on cherche la valeur de var1
        TextBoxpathDest.Text = (TextBoxpathDestVar) ' on affiche la valeur de var1 

        'On remplit la Combo avec les Fichiers Texte
        Dim dirComboText As New DirectoryInfo(TextBoxpathDestVar)

        ComboBox1ListTxtTemplate.DataSource = dirComboText.GetFiles("*.txt")

        'On remplit la combo de la base de données avec sa localisation
        BDDLOCATIONTEXTBOX.Text = bdd

    End Sub


    Function RecupereCleFichierIni(ByVal Cle As String) As String

        For Each Ligne As String In File.ReadAllLines("C:\ProgramData\Piko Software\Video Server\VidServ.ini")
            'Découpe la ligne au niveau de "=" (s'il existe),
            'compare la premiere partie de la ligne (soit la clé)
            If Ligne.Split("=")(0) = Cle Then
                'Recupère la seconde partie de la ligne (soit la valeur)
                Return Ligne.Split("=")(1)
            End If
        Next
        'Sinon ne retourne rien
        Return ""

    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim TextBoxpathDestVar = RecupereCleFichierIni("PathTemplates") 'on cherche la valeur de var1
        Dim dirComboText As New DirectoryInfo(TextBoxpathDestVar)

        ComboBox1ListTxtTemplate.DataSource = dirComboText.GetFiles("*.txt")
    End Sub

  

    Private Sub ListViewBoxFinal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewBoxFinal.SelectedIndexChanged

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub FacebookToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OpenRSSListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenRSSListToolStripMenuItem.Click
        RSSEditor.Show()
    End Sub


    Private Sub ComboBox1ListTxtTemplate_selectindexchanged(sender As Object, e As EventArgs) Handles ComboBox1ListTxtTemplate.SelectedIndexChanged
        Me.ListViewBoxFinal.Items.Clear() 'je vide ma Listview



        Dim swr2 As New System.IO.StreamReader(TextBoxpathDest.Text + ComboBox1ListTxtTemplate.SelectedItem.ToString) 'je récupére le nom de fichier dans la Combo

        Dim arr1 As String() = New String(2) {} ' je Crrée un Array pour gérer les Items et Subtitems
        Dim itm2 As ListViewItem


        Do Until swr2.Peek = -1
            Dim Ligne As String ' Je définier la varibale Ligne

            Ligne = swr2.ReadLine() 'Je lis la ligne
            arr1(1) = (Ligne)
            itm2 = New ListViewItem(arr1)
            Me.ListViewBoxFinal.Items.Add(itm2)
            itm2.ImageIndex = 1

            ' Me.ListViewBoxFinal.Items.Add(Ligne)
        Loop

        swr2.Close()

        


    End Sub

    Private Sub SaveRSSListToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtUrl.Items.Clear()
        'On ecrit les URL dans la Combo à partir du Fichier
        Dim swr As New System.IO.StreamReader("C:\Users\All Users\Piko Software\Piko Social Hub\Piko_URls.txt")


        Do Until swr.Peek = -1
            Dim Ligne As String
            Ligne = swr.ReadLine()
            Me.txtUrl.Items.Add(Ligne)
        Loop
        If Me.txtUrl.Items.Count > 0 Then
            Me.txtUrl.Text = txtUrl.Items(0)
        End If

        swr.Close()

        'On Remplit le path pour les templates en lisant le fichier Ini

        Dim TextBoxpathDestVar = RecupereCleFichierIni("PathTemplates") 'on cherche la valeur de var1
        TextBoxpathDest.Text = (TextBoxpathDestVar) ' on affiche la valeur de var1 

        'On remplit la Combo avec les Fichiers Texte
        Dim dirComboText As New DirectoryInfo(TextBoxpathDestVar)

        ComboBox1ListTxtTemplate.DataSource = dirComboText.GetFiles("*.txt")
    End Sub

    Private Sub ComboBoxSeparator_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSeparator.SelectedIndexChanged
        TextBoxSeparator.Text = ComboBoxSeparator.Text
    End Sub







    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click



        'Nouveau Code pour Base de données
        Try

            cm = New OleDb.OleDbCommand
            With cm
                .Connection = cn
                .CommandType = CommandType.Text
                '.CommandText = "INSERT INTO tblStudent (Snum,Sname)VALUES "
                .CommandText = "DELETE * from tblGTB"
                cm.ExecuteNonQuery()
                '(Snum,Sname)VALUES" & valeurs.TrimEnd(",")

                Dim liste As ListView.ListViewItemCollection = ListViewBoxFinal.Items
                Dim valeurs = ""
                Dim Compteur = 0
                For Each item As ListViewItem In liste
                    Compteur = Compteur + 1
                    .CommandText = "INSERT INTO tblGTB (ID,Label)VALUES" & "(" & Compteur & ",'" & item.SubItems(1).Text.Replace("'", "''") & "')".TrimEnd(",")
                    cm.ExecuteNonQuery()
                    'valeurs = valeurs & "(" & Compteur & ",'" & item.SubItems(1).Text.Replace("'", "''") & "')," & Environment.NewLine

                Next

                MsgBox("Record saved.", MsgBoxStyle.Information)

                Exit Sub
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Timer3.Interval = (TrackBar2.Value + (1 * 60000))
            Timer3.Enabled = True
            Timer4.Interval = (TrackBar2.Value + (1 * 600))
            Timer4.Enabled = True



            btnLoad.PerformClick()

            'enregistrement auto dans la base de données.
            Try

                cm = New OleDb.OleDbCommand
                With cm
                    .Connection = cn
                    .CommandType = CommandType.Text
                    '.CommandText = "INSERT INTO tblStudent (Snum,Sname)VALUES "
                    .CommandText = "DELETE * from tblGTB"
                    cm.ExecuteNonQuery()
                    '(Snum,Sname)VALUES" & valeurs.TrimEnd(",")

                    Dim liste As ListView.ListViewItemCollection = ListView1ChannelElements.Items
                    Dim valeurs = ""
                    Dim Compteur = 0
                    For Each item As ListViewItem In liste
                        Compteur = Compteur + 1
                        .CommandText = "INSERT INTO tblGTB (ID,Label)VALUES" & "(" & Compteur & ",'" & item.SubItems(1).Text.Replace("'", "''") & "')".TrimEnd(",")
                        cm.ExecuteNonQuery()
                        'valeurs = valeurs & "(" & Compteur & ",'" & item.SubItems(1).Text.Replace("'", "''") & "')," & Environment.NewLine

                    Next

                    'MsgBox("Record saved.", MsgBoxStyle.Information)

                    Exit Sub
                End With
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try


        End If

        If CheckBox2.Checked = False Then Timer3.Enabled = False
        If CheckBox2.Checked = False Then Timer4.Enabled = False
        If CheckBox2.Checked = False Then ProgressBar2.Value = 0
    End Sub


End Class


