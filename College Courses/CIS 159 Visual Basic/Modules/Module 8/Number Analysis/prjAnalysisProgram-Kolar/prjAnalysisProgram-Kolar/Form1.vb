'Alex Kolar
'3/30/2013
'CIS159 Section 28998
'Number Analysis Program

Public Class Form1

    'Allows the user to enter the values, and calculates the desired data
    Private Sub btnEnterNumbers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterNumbers.Click
        'declare vars
        Dim aryNumbers(9) As Decimal
        Dim decDeterminate As Decimal
        Dim strUserInput As String
        Dim decLowest As Decimal
        Dim decHighest As Decimal
        Dim decSum As Decimal
        Dim decAverage As Decimal

        'display input box
        For intDisplayInput = 0 To 9
            strUserInput = InputBox("Enter a number.", "Provide a Value", "5")
            aryNumbers(intDisplayInput) = CDec(strUserInput)

            'find the sum of all numbers in the array
            For intTotalCount = 0 To (aryNumbers.Length - 1)
                decSum += aryNumbers(intTotalCount)
            Next

            'find the average of all numbers in the array
            decAverage = decSum / aryNumbers.Length

        Next

        'create the variable to be used by both the lowest loop and the highest loop
        decDeterminate = aryNumbers(0)

        'find the lowest number in the array
        For intLowestCount = 1 To (aryNumbers.Length - 1)

            If aryNumbers(intLowestCount) < decDeterminate Then
                decLowest = aryNumbers(intLowestCount)
            End If

        Next

        'find the highest number in the array
        For intHighestCount = 1 To (aryNumbers.Length - 1)

            If aryNumbers(intHighestCount) > decDeterminate Then
                decHighest = aryNumbers(intHighestCount)
            End If

        Next

        'display all necessary values in the appropriate text boxes
        lblLowest.Text = decLowest.ToString()
        lblHighest.Text = decHighest.ToString()
        lblTotal.Text = decSum.ToString()
        lblAverage.Text = decAverage.ToString()

    End Sub

    'Resets all values in the labels
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblLowest.Text = ""
        lblHighest.Text = ""
        lblTotal.Text = ""
        lblAverage.Text = ""
    End Sub

    'Close/Exit the form
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
