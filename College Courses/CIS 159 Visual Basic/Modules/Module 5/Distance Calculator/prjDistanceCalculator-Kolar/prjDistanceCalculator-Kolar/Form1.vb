'Alex Kolar
'3/5/2013
'CIS159 Section 28998
'Distance Calculator

Public Class Form1
    'This method does all of the work on the application's side.
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Declare variables
        Dim intSpeed As String
        Dim intTime As String
        Dim decDistance As Decimal
        Dim dummyTime As Integer
        ' Dim strDisplay As String
        ' Dim NumericSpeed As Boolean
        ' Dim NumericTime As Boolean

        'Create the first input box
        intSpeed = InputBox("Enter the Speed (in miles-per-hour). No decimals.", "Give me the Speed")

        'Validate data
        If IsNumeric(intSpeed) Then
            ' NumericSpeed = True
            'Create the second input box
            intTime = InputBox("Enter the time you traveled (in hours). No decimals.", "Give me the Time")

            'Validate data
            If IsNumeric(intTime) Then
                'Display the starting values in the display.
                lstDisplay.Items.Add("Vehicle Speed: " + intSpeed + " MPH")
                lstDisplay.Items.Add("Time Traveled: " + intTime + " hours")
                lstDisplay.Items.Add("Hours" + vbTab + "Distance Traveled")
                lstDisplay.Items.Add("--------------------------------------------------")
                For dummyTime = 1 To CInt(intTime)
                    'exit the loop if dummyTime is equal to intTime
                    If dummyTime > CInt(intTime) Then
                        Exit For
                    End If

                    'multiply the base speed by the current time
                    decDistance = dummyTime * CInt(intSpeed)

                    'Create each repeating line of the display.
                    lstDisplay.Items.Add(CStr(dummyTime) + vbTab + vbTab + CStr(decDistance))
                Next
                'Create the last line of the display
                lstDisplay.Items.Add("--------------------------------------------------")
                lstDisplay.Items.Add("Total Distance: " + CStr(decDistance))
            Else
                MessageBox.Show("The Time is not an Integer.")
            End If

        Else
            MessageBox.Show("The Speed is not an Integer.")
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
