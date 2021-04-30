'Alex Kolar
'1/24/2013
'CIS159 28998
'State Abbreviations

Public Class Form1
    'Each of these methods represent a button.
    Private Sub btnVirginia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVirginia.Click
        'Will display the state's abbreviation in the abbreviation label.
        lblAbbreviation.Text = "VA"
    End Sub

    Private Sub btnNorthCarolina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNorthCarolina.Click
        lblAbbreviation.Text = "NC"
    End Sub

    Private Sub btnSouthCarolina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSouthCarolina.Click
        lblAbbreviation.Text = "SC"
    End Sub

    Private Sub btnGeorgia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeorgia.Click
        lblAbbreviation.Text = "GA"
    End Sub

    Private Sub btnAlabama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlabama.Click
        lblAbbreviation.Text = "AL"
    End Sub

    Private Sub btnFlorida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlorida.Click
        lblAbbreviation.Text = "FL"
    End Sub
End Class
