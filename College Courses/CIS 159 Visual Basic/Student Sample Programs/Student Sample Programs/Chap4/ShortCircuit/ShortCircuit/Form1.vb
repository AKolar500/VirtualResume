Public Class Form1

    Private Function CheckValue(ByVal X As Double) As Boolean
        'Suppose this was a large, time-consuming function.
        MessageBox.Show("CheckValue(" & X & ") called")
        Return True
    End Function

    Private Sub btnOr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOr.Click
        'The OR operator does not perform short-circuit evaluation.

        Dim dblX As Double = 0.0

        If dblX = 0 Or CheckValue(dblX) Then
            lblResult.Text = "Expression is True"
        End If
    End Sub

    Private Sub btnAnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnd.Click
        'The And operator does not perform short-circuit evaluation.

        Dim dblX As Double = 0.0

        If dblX > 0 And CheckValue(dblX) Then
            lblResult.Text = "Expression is True"
        Else
            lblResult.Text = "Expression is False"
        End If
    End Sub

    Private Sub btnOrElse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrElse.Click
        'The OrElse operator performs short-circuit evaluation.

        Dim dblX As Double = 0.0

        If dblX = 0 OrElse CheckValue(dblX) Then
            lblResult.Text = "Expression is True"
        End If
    End Sub

    Private Sub btnAndAlso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAndAlso.Click
        'The AndAlso operator performs short-circuit evaluation.

        Dim dblX As Double = 0.0

        If dblX > 0 AndAlso CheckValue(dblX) Then
            lblResult.Text = "Expression is True"
        Else
            lblResult.Text = "Expression is False"
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
