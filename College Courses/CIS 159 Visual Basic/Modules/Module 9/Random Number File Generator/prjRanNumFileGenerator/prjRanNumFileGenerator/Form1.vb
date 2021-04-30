'Alex Kolar
'4/7/2013
'CIS159 Section 28998
'Random Number File Generator

Imports System.IO

Public Class Form1

    'Generate the numbers, then put them in a file that is viewable in the list box
    Private Sub btnGenerateNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateNumbers.Click
        'declare vars
        Dim numberFile As StreamWriter
        Dim randNumbers As Integer
        Dim rand As New Random

        'create the file
        numberFile = File.CreateText("RandomNumber.txt")

        'generate the numbers and write each as a new line in the file
        For iteration = 1 To 100
            randNumbers = rand.Next(1000) + 1
            numberFile.WriteLine(randNumbers)
        Next

        'store them in a new file named RandomNumber.txt
        numberFile.Close()

        'Direct the user to the file's location
        lblDirections.Visible = True
        btnGenerateNumbers.Enabled = False

    End Sub

    'Close the form
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
