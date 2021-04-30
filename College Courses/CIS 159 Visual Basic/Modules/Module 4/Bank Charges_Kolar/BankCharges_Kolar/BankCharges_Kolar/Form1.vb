'Alex Kolar
'2/26/2013
'CIS159 Section 28998
'prjCharges

Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'Declare variables and constants
        Const RATE_1 As Decimal = 0.1
        Const RATE_2 As Decimal = 0.08
        Const RATE_3 As Decimal = 0.06
        Const RATE_4 As Decimal = 0.04
        Const INITIAL_ACCOUNT_COST As Decimal = 10

        Dim intNumberOfChecks As Integer

        Dim decCostOfEachCheck As Decimal
        Dim decMonthlyCostOfChecks As Decimal
        Dim decTotalAccountCost As Decimal

        Dim strSummary As String

        'Verify that the user put something into the input field
        If txtNumberOfChecks.Text IsNot "" Then

            'Verify that the user's number is a number
            If Integer.TryParse(txtNumberOfChecks.Text, intNumberOfChecks) Then

                'Verify that the user's number is positive
                If intNumberOfChecks >= 0 Then

                    'Determine the cost of each check.
                    If intNumberOfChecks <= 20 Then
                        decCostOfEachCheck = RATE_1
                    ElseIf intNumberOfChecks > 20 And intNumberOfChecks < 39 Then
                        decCostOfEachCheck = RATE_2
                    ElseIf intNumberOfChecks > 39 And intNumberOfChecks < 59 Then
                        decCostOfEachCheck = RATE_3
                    Else
                        decCostOfEachCheck = RATE_4
                    End If

                    'Calculate the total cost of checks
                    decMonthlyCostOfChecks = decCostOfEachCheck * intNumberOfChecks

                    'Calculate the total account cost
                    decTotalAccountCost = decMonthlyCostOfChecks + INITIAL_ACCOUNT_COST

                    'Finally, display the values in lblSummary
                    strSummary = ("Cost of each check: " + decCostOfEachCheck.ToString("c") + Environment.NewLine + "Total Cost of the account: " + decTotalAccountCost.ToString("c"))
                    lblSummary.Text = strSummary
                Else
                    MessageBox.Show("Number of Checks must be positive.")
                    txtNumberOfChecks.Focus()
                End If

            Else
                MessageBox.Show("Number of Checks must be a number.")
                txtNumberOfChecks.Focus()
            End If

        Else
            MessageBox.Show("Number of Checks cannot be blank.")
            txtNumberOfChecks.Focus()
        End If
    End Sub

    'Clear the values that need to be cleared.
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtNumberOfChecks.Text = ""
        lblSummary.Text = ""
        txtNumberOfChecks.Focus()
    End Sub

    'Close the form.
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
