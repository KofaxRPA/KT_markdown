Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        If args.Length = 0 Then Console.WriteLine("give path to fpr file") : Exit Sub
        Dim fprFilename As String = args(0)
        If Not File.Exists(fprFilename) Then
            Console.WriteLine("Cannot find " & fprFilename)
            Exit Sub
        End If
        Dim xdoc As New XDoc(fprFilename)
        System.Console.Write(xdoc.Markdown)
    End Sub
End Module
