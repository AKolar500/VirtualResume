Public Class Form1

    Private Sub btnCheckQual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckQual.Click

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ' Clear the TextBoxes and the Label
        txtSalary.Clear()
        txtYearsOnJob.Clear()
        lblMessage.Text = String.Empty

        ' Give the focus to txtSalary
        txtSalary.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
