Imports System.Data.OleDb
Module modConnection

    Public cn As New OleDb.OleDbConnection
    Public cm As New OleDb.OleDbCommand
    Public dr As OleDbDataReader

    Public Sub connection()
        Dim bdd As String = "C:\Users\All Users\Piko Software\Piko Social Hub\GTB.MDB"
        cn = New OleDb.OleDbConnection
        With cn
            .ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & bdd
            .Open()
        End With
    End Sub
End Module
