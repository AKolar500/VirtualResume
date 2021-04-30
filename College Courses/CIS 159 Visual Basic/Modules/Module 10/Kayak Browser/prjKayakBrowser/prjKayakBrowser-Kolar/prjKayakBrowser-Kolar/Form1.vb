'Alex Kolar
'4/18/2013 Redone on 4/22/2013
'CIS159 Section 28998
'Kayak Browser

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KayaksDataSet.Kayak_Types' table. You can move, or remove it, as needed.
        Me.Kayak_TypesTableAdapter.Fill(Me.KayaksDataSet.Kayak_Types)

    End Sub

    Private Sub lstTypes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTypes.SelectedIndexChanged
        lblDescription.Text = lstTypes.SelectedValue.ToString()
    End Sub
End Class
