Public Class Form1

    Private Sub btnDemo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDemo1.Click
        ' This event handler calls the DisplayValue procedure,
        ' passing 5 as an argument.
        DisplayValue(5)
    End Sub

    Private Sub btnDemo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDemo2.Click
        ' Call the DisplayValue procedure several times,
        ' passing different arguments each time.
        DisplayValue(5)
        DisplayValue(10)
        DisplayValue(2)
        DisplayValue(16)

        ' The value of an expression is passed to the
        ' DisplayValue procedure.
        DisplayValue(3 + 5)
    End Sub

    Private Sub btnDemo3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDemo3.Click
        ' Use a loop to call the DisplayValue procedure
        ' passing a variable as the argument.
        Dim intCount As Integer

        For intCount = 1 To 10
            DisplayValue(intCount)
        Next
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Sub DisplayValue(ByVal intNumber As Integer)
        ' This procedure displays a value in a message box.
        MessageBox.Show(intNumber.ToString())
    End Sub
End Class
