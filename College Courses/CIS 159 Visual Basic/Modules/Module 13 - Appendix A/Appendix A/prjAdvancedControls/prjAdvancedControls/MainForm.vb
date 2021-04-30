Public Class MainForm

    Dim decTreatmentCost As Decimal
    Dim strFirstName As String
    Dim strLastName As String

    
    Private Sub radDisease_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDisease.CheckedChanged
        grpDiseaseSymptoms.Visible = True
        grpInjurySymptoms.Visible = False
    End Sub

    Private Sub radInjury_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radInjury.CheckedChanged
        grpDiseaseSymptoms.Visible = False
        grpInjurySymptoms.Visible = True
    End Sub

    Private Sub radBoth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBoth.CheckedChanged
        grpDiseaseSymptoms.Visible = True
        grpInjurySymptoms.Visible = True
    End Sub


    Private Sub btnAdmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmit.Click
        Try
            ValidateTab()

            Try

            Catch ex As Exception

            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function ValidateTab() As Boolean

        If txtFirstName.Text = String.Empty Then
            txtFirstName.Text = "Please enter a first name."
            Return False
        End If

        If txtLastName.Text = String.Empty Then
            txtLastName.Text = "Please enter a last name."
            Return False
        End If

        Return True
    End Function

End Class
