Public Class Form1

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim decAnnualSalary As Decimal  ' Annual salary
        Dim intPayPeriods As Integer    ' Number of pay periods per year
        Dim decSalary As Decimal        ' Salary per pay period

        Try
            ' Get the annual salary and number of pay periods.
            decAnnualSalary = CDec(txtAnnualSalary.Text)
            intPayPeriods = CInt(txtPayPeriods.Text)

            ' Calculate the salary per pay period.
            decSalary = decAnnualSalary / intPayPeriods

            ' Display the salary per pay period.
            lblSalary.Text = decSalary.ToString("c")

        Catch ex As InvalidCastException
            ' An invalid value as entered.
            MessageBox.Show("Error: Input must be numeric.")

        Catch ex As DivideByZeroException
            ' 0 was entered for pay periods.
            MessageBox.Show("Error: Enter nonzero values.")
        End Try
    End Sub
End Class
