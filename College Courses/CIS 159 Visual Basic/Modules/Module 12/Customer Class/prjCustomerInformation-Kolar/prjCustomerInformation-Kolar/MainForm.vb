'Alex Kolar
'5/07/2013
'CIS159 Section 28998
'Derived Customer Class

Public Class MainForm

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim People As New Collection

        FirstName() = txtFirst.Text

        People.Add(FirstName)

    End Sub
End Class
