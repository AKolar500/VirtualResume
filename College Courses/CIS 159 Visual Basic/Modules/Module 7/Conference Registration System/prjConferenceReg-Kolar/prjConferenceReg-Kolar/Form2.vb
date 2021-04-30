Public Class Form2


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'declare vars
        Dim decSelectedWorkshop As Decimal
        Dim decConference As Decimal

        'conference options
        If chkRegistration.Checked Then
            decConference += 895
        Else
            MessageBox.Show("You forgot to register for the conference.")
        End If

        If chkOpeningNight.Checked Then
            decConference += 30
        End If

        'workshops
        If lstWorkshops.SelectedIndex = 0 Then
            decSelectedWorkshop = 295
        End If
        If lstWorkshops.SelectedIndex = 1 Then
            decSelectedWorkshop = 295
        End If
        If lstWorkshops.SelectedIndex = 2 Then
            decSelectedWorkshop = 395
        End If
        If lstWorkshops.SelectedIndex = 3 Then
            decSelectedWorkshop = 395
        End If

        decTotalCost = decConference + decSelectedWorkshop

        'finally, close the form
        Me.Close()

    End Sub
End Class