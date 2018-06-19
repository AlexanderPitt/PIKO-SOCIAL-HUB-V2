Imports System.ComponentModel
Imports System.Xml

Namespace RSS

    ''' <summary>
    ''' Classe permettant de télécharger un flux RSS de façon asynchrone
    ''' </summary>
    ''' <remarks></remarks>
    Public Class RssReader

        ''' <summary>
        ''' Permet de connaitre l'avance du téléchargement du flux RSS
        ''' </summary>
        ''' <param name="Sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Public Event ProgressChanged(ByVal Sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        ''' <summary>
        ''' Signal la fin du téléchargement du flux
        ''' </summary>
        ''' <param name="Sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Public Event Completed(ByVal Sender As Object, ByVal e As CompletedEventArgs)

        ''' <summary>
        ''' Télécharge un flux RSS à partir de l'Uri spécifiée
        ''' </summary>
        ''' <param name="Uri">Adresse du flux</param>
        ''' <remarks></remarks>
        Public Sub Load(ByVal Uri As Uri)
            Me.Load(Uri, Nothing)
        End Sub
        ''' <summary>
        ''' Télécharge un flux RSS à partir de l'Uri spécifiée
        ''' </summary>
        ''' <param name="Uri">Adresse du flux</param>
        ''' <param name="UserState">Objet défini par l'utilisateur retourné à la fin de l'opération asynchrone </param>
        ''' <remarks></remarks>
        Public Sub Load(ByVal Uri As Uri, ByVal UserState As Object)
            If client IsNot Nothing Then Cancel()
            client = New Net.WebClient
            _UserState = UserState
            client.DownloadDataAsync(Uri, UserState)
        End Sub
        Private _UserState As Object
        ''' <summary>
        ''' Annule le téléchargement du flux
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Cancel()
            client.Dispose()
            client = Nothing
            Dim args As New CompletedEventArgs(Nothing, Nothing, True, _UserState)
            RaiseEvent Completed(Me, args)
        End Sub

        ''' <summary>
        ''' Détermine si un téléchargement est en cours
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property isBusy() As Boolean
            Get
                If client Is Nothing Then
                    Return False
                Else
                    Return client.IsBusy
                End If
            End Get
        End Property

        Private WithEvents client As Net.WebClient
        Private Sub client_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles client.DownloadProgressChanged
            RaiseEvent ProgressChanged(Me, e)
        End Sub
        Private Sub client_DownloadDataCompleted(ByVal sender As Object, ByVal e As System.Net.DownloadDataCompletedEventArgs) Handles client.DownloadDataCompleted
            client = Nothing
            Dim res As RssFeed = Nothing
            If e.Error Is Nothing And e.Cancelled = False Then
                ' Créer le RssFeed
                res = New RssFeed(e.Result)
            End If
            Dim args As New CompletedEventArgs(res, e.Error, e.Cancelled, e.UserState)
            RaiseEvent Completed(Me, args)
        End Sub

        Public Class CompletedEventArgs
            Inherits EventArgs

            Friend Sub New(ByVal Result As RssFeed, ByVal [Error] As Exception, ByVal Canceled As Boolean, ByVal UserState As Object)
                _Result = Result
                _Error = [Error]
                _Canceled = Canceled
                _UserState = UserState
            End Sub

            Public ReadOnly Property Result() As RssFeed
                Get
                    Return _Result
                End Get
            End Property
            Private _Result As RssFeed

            Public ReadOnly Property [Error]() As System.Exception
                Get
                    Return _Error
                End Get
            End Property
            Private _Error As Exception

            Public ReadOnly Property UserState() As Object
                Get
                    Return _UserState
                End Get
            End Property
            Private _UserState As Exception

            Public ReadOnly Property Canceled() As Boolean
                Get
                    Return _Canceled
                End Get
            End Property
            Private _Canceled As Boolean

        End Class
    End Class

    ''' <summary>
    ''' Représente un flux RSS
    ''' </summary>
    ''' <remarks></remarks>
    Public Class RssFeed


#Region " Contructeurs "

        Public Sub New(ByVal XmlDocument As Xml.XmlDocument)
            LoadXml(XmlDocument)
        End Sub
        Public Sub New(ByVal Stream As IO.Stream)
            Dim doc As New XmlDocument
            doc.Load(Stream)
            LoadXml(doc)
        End Sub
        Public Sub New(ByVal Datas() As Byte)
            Dim Stream As New IO.MemoryStream(Datas)
            Dim doc As New XmlDocument
            doc.Load(Stream)
            LoadXml(doc)
        End Sub

        Private Sub LoadXml(ByVal doc As Xml.XmlDocument)
            tags.Clear()
            If doc.DocumentElement.Name.ToLower = "rss" Then
                Dim version As String = doc.DocumentElement.GetAttribute("version")
                tags.Add(New RssTag("version", version))

                If version = "2.0" Then
                    Dim channel As XmlElement = doc.DocumentElement.GetElementsByTagName("channel")(0)
                    For Each elem As XmlElement In channel
                        If elem.Name.ToLower = "item" Then
                            ' Un item
                            _Items.Add(New RssItem(elem))
                        Else
                            ' Un tag du channel
                            LoadElem("", elem)
                        End If
                    Next
                End If
            End If
        End Sub
        Private Sub LoadElem(ByVal BaseName As String, ByVal Elem As XmlElement)
            For Each attr As XmlNode In Elem.Attributes
                tags.Add(New RssTag(BaseName & attr.Name, attr.InnerText))
            Next
            For Each subElem As XmlNode In Elem.ChildNodes
                If subElem.NodeType = XmlNodeType.Element Then
                    LoadElem(BaseName & Elem.Name & ".", subElem)
                Else
                    tags.Add(New RssTag(BaseName & Elem.Name, subElem.InnerText))
                End If
            Next
        End Sub

#End Region

#Region " Propriétés "

        ' All Tags
        Private tags As New List(Of RssTag)
        Private _Elements As New RssTagsCollection(tags)
        ''' <summary>
        ''' Liste de tous les éléments d'un flux. Accessible par index ou par nom
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property Elements() As RssTagsCollection
            Get
                Return _Elements
            End Get
        End Property

        ' Items
        Private _Items As New List(Of RssItem)
        Private _RoItems As New RssItemsCollection(_Items)
        ''' <summary>
        ''' Liste des items contenus dans ce flux.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property Items() As RssItemsCollection
            Get
                Return _RoItems
            End Get
        End Property

        ' Eléments principaux
        Public ReadOnly Property title() As String
            Get
                Return Elements.GetValueByName("title")
            End Get
        End Property
        Public ReadOnly Property link() As String
            Get
                Return Elements.GetValueByName("link")
            End Get
        End Property
        Public ReadOnly Property description() As String
            Get
                Return Elements.GetValueByName("description")
            End Get
        End Property
        Public ReadOnly Property language() As String
            Get
                Return Elements.GetValueByName("language")
            End Get
        End Property
        Public ReadOnly Property copyright() As String
            Get
                Return Elements.GetValueByName("copyright")
            End Get
        End Property
        Public ReadOnly Property managingEditor() As String
            Get
                Return Elements.GetValueByName("managingEditor")
            End Get
        End Property
        Public ReadOnly Property webMaster() As String
            Get
                Return Elements.GetValueByName("webMaster")
            End Get
        End Property
        Public ReadOnly Property pubDate() As String
            Get
                Return Elements.GetValueByName("pubDate")
            End Get
        End Property
        Public ReadOnly Property lastBuildDate() As String
            Get
                Return Elements.GetValueByName("lastBuildDate")
            End Get
        End Property
        Public ReadOnly Property category() As String
            Get
                Return Elements.GetValueByName("category")
            End Get
        End Property
        Public ReadOnly Property generator() As String
            Get
                Return Elements.GetValueByName("generator")
            End Get
        End Property
        Public ReadOnly Property docs() As String
            Get
                Return Elements.GetValueByName("docs")
            End Get
        End Property
        Public ReadOnly Property ttl() As String
            Get
                Return Elements.GetValueByName("ttl", "0")
            End Get
        End Property
        Public ReadOnly Property rating() As String
            Get
                Return Elements.GetValueByName("rating")
            End Get
        End Property
        Public ReadOnly Property skipHours() As String
            Get
                Return Elements.GetValueByName("skipHours")
            End Get
        End Property
        Public ReadOnly Property skipDays() As String
            Get
                Return Elements.GetValueByName("skipDays")
            End Get
        End Property

        Public ReadOnly Property imageTitle() As String
            Get
                Return Elements.GetValueByName("image.title")
            End Get
        End Property
        Public ReadOnly Property imageUrl() As String
            Get
                Return Elements.GetValueByName("image.url")
            End Get
        End Property
        Public ReadOnly Property imageLink() As String
            Get
                Return Elements.GetValueByName("image.link")
            End Get
        End Property
        Public ReadOnly Property imageWidth() As Integer
            Get
                Return Elements.GetValueByName("image.width", "0")
            End Get
        End Property
        Public ReadOnly Property imageHeight() As Integer
            Get
                Return Elements.GetValueByName("image.height", "0")
            End Get
        End Property
        Public ReadOnly Property imageDescription() As String
            Get
                Return Elements.GetValueByName("image.description")
            End Get
        End Property

#End Region

    End Class

    ''' <summary>
    ''' Item contenu dans un flux RSS
    ''' </summary>
    ''' <remarks></remarks>
    Public Class RssItem

#Region " Contructeur "

        Public Sub New(ByVal XmlElement As Xml.XmlElement)
            For Each subElem As XmlNode In XmlElement.ChildNodes
                LoadElem("", subElem)
            Next
        End Sub


        Private Sub LoadElem(ByVal BaseName As String, ByVal Elem As XmlElement)
            For Each attr As XmlNode In Elem.Attributes
                tags.Add(New RssTag(BaseName & attr.Name, attr.InnerText))
            Next
            For Each subElem As XmlNode In Elem.ChildNodes
                If subElem.NodeType = XmlNodeType.Element Then
                    LoadElem(BaseName & Elem.Name & ".", subElem)
                Else
                    tags.Add(New RssTag(BaseName & Elem.Name, subElem.InnerText))
                End If
            Next
        End Sub


#End Region

#Region " Propriétés "

        Private tags As New List(Of RssTag)
        Private _Elements As New RssTagsCollection(tags)
        ''' <summary>
        ''' Liste de tous les éléments d'un item. Accessible par index ou par nom
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property Elements() As RssTagsCollection
            Get
                Return _Elements
            End Get
        End Property


        Public ReadOnly Property title() As String
            Get
                Return _Elements.GetValueByName("title")
            End Get
        End Property
        Public ReadOnly Property description() As String
            Get
                Return Elements.GetValueByName("description")
            End Get
        End Property
        Public ReadOnly Property link() As String
            Get
                Return _Elements.GetValueByName("link")
            End Get
        End Property
        Public ReadOnly Property author() As String
            Get
                Return Elements.GetValueByName("author")
            End Get
        End Property
        Public ReadOnly Property category() As String
            Get
                Return Elements.GetValueByName("category")
            End Get
        End Property
        Public ReadOnly Property comments() As String
            Get
                Return Elements.GetValueByName("comments")
            End Get
        End Property
        Public ReadOnly Property enclosure() As String
            Get
                Return Elements.GetValueByName("enclosure")
            End Get
        End Property
        Public ReadOnly Property guid() As String
            Get
                Return Elements.GetValueByName("guid")
            End Get
        End Property
        Public ReadOnly Property pubDate() As String
            Get
                Return Elements.GetValueByName("pubDate")
            End Get
        End Property
        Public ReadOnly Property source() As String
            Get
                Return Elements.GetValueByName("source")
            End Get
        End Property
#End Region

    End Class
    Public Class RssItemsCollection
        Inherits Collections.ObjectModel.ReadOnlyCollection(Of RssItem)

        Public Sub New(ByVal BaseList As List(Of RssItem))
            MyBase.New(BaseList)
        End Sub
    End Class

    ''' <summary>
    ''' Elément (propriété) d'un flux ou d'un item RSS
    ''' </summary>
    ''' <remarks></remarks>
    Public Class RssTag

        Public Sub New(ByVal Name As String, ByVal Value As String)
            _Name = Name
            _Value = Value
        End Sub

        Private _Name As String
        Private _Value As String

        Public ReadOnly Property Name() As String
            Get
                Return _Name
            End Get
        End Property
        Public ReadOnly Property Value() As String
            Get
                Return _Value
            End Get
        End Property

    End Class
    Public Class RssTagsCollection
        Inherits Collections.ObjectModel.ReadOnlyCollection(Of RssTag)

        Public Sub New(ByVal BaseList As List(Of RssTag))
            MyBase.New(BaseList)
        End Sub

        Public Function GetTagByName(ByVal TagName As String) As RssTag
            For Each It As RssTag In Me
                If It.Name.ToLower = TagName.ToLower Then Return It
            Next
            Return Nothing
        End Function
        Public Function GetValueByName(ByVal TagName As String, ByVal DefaultValue As String) As String
            For Each It As RssTag In Me
                If It.Name.ToLower = TagName.ToLower Then Return It.Value
            Next
            Return DefaultValue
        End Function
        Public Function GetValueByName(ByVal TagName As String) As String
            For Each It As RssTag In Me
                If It.Name.ToLower = TagName.ToLower Then Return It.Value
            Next
            Return ""
        End Function
    End Class

End Namespace

