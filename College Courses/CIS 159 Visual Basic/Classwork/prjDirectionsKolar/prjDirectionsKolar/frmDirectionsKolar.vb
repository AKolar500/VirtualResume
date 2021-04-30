'Alex Kolar
'Showing the Directions to the Hotel

Public Class frmDirectionsKolar

    Private Sub btnDisplayDirections_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayDirections.Click
        'Display the direction label
        lblDirections.Visible = True
        btnHideDirections.Visible = True
        btnDisplayDirections.Visible = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'Close the window
        Me.Close()
    End Sub

    Private Sub btnHideDirections_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideDirections.Click
        lblDirections.Visible = False
        btnHideDirections.Visible = False
        btnDisplayDirections.Visible = True
    End Sub
End Class
