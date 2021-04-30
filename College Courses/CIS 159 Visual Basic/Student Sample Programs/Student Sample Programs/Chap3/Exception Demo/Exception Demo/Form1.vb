Public Class Form1

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        ' Declare a variable to hold the user's salary.
        Dim decSalary As Decimal

        ' Get the user's input and convert it to a Decimal.
        decSalary = CDec(txtSalary.Text)

        ' Display the user's salary.
        MessageBox.Show("Your salary is " & decSalary.ToString("c"))
    End Sub
End Class
