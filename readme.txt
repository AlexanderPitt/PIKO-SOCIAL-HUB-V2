Lecteur rss en vb.net---------------------
Url     : http://codes-sources.commentcamarche.net/source/47187-lecteur-rss-en-vb-netAuteur  : Kevin.OryDate    : 07/08/2013
Licence :
=========

Ce document intitulé « Lecteur rss en vb.net » issu de CommentCaMarche
(codes-sources.commentcamarche.net) est mis à disposition sous les termes de
la licence Creative Commons. Vous pouvez copier, modifier des copies de cette
source, dans les conditions fixées par la licence, tant que cette note
apparaît clairement.

Description :
=============

Bonjour &agrave; tous,
<br />Je suis en train de d&eacute;velopper une applicat
ion pour laquelle j'ai d&eacute;cid&eacute; d'afficher des news sur la page d'ac
cueil, de la m&ecirc;me fa&ccedil;on que la page de d&eacute;marrage de Visual S
tudio.
<br />
<br />J'ai donc cr&eacute;er quelques classes permettant de t&ea
cute;l&eacute;charger puis de d&eacute;coder un flux RSS. N'ayant pas trouv&eacu
te; de classe toute faite en VB.NET permettant de d&eacute;coder un flux RSS, j'
ai donc d&eacute;cid&eacute; de vous la faire partager une fois cr&eacute;&eacut
e;.
<br />
<br />Esp&eacute;rant que ceci soit utile &agrave; certains...
<br
 /><a name='source-exemple'></a><h2> Source / Exemple : </h2>
<br /><pre class
='code' data-mode='basic'>
RssReader: Permet de télécharger un flux de façon as
ynchrone
RssFeed: Flux RSS décodé, contenant les propriété du flux (Titre, imag
e...) et une liste d'items
RssItem: Item d'un flux, contenant les propriété de 
l'item (titre, description, lien...)
RssTags: Nom/Valeur représentant un élémen
t XML. (permet d'accéder à tous les éléments du flux)
</pre>
<br /><a name='co
nclusion'></a><h2> Conclusion : </h2>
<br />Rien de bien compliqu&eacute;, j'a
i cr&eacute;&eacute; ce code en quelques heures seulement (cet apr&egrave;s midi
). Il semblerait qu'aucun probl&egrave;me ne survienne quel que soit le flux RSS
 charg&eacute;. En th&eacute;orie, il est compatible avec les flux RSS version 0
.92, 0.93 et 2.0, mais encore une fois, je n'ai pas tout test&eacute;.
<br />

<br />Sachez que la description d'un item d'un flux est souvent un texte contena
nt des tags html de ce genre l&agrave;:
<br />&quot;contre la ratification du t
rait&amp;eacute; de Lisbonne.&lt;img width='1' height='1' src='http://rss.feedsp
ortal.com/c/205/f/3050/s/15f09e1/mf.gif'&quot;
<br />Ceci est normal. A vous de
 d&eacute;coder (ou supprimer) ces tags pour afficher le texte de fa&ccedil;on c
orrect (ce n'est pas fait dans ma source)
