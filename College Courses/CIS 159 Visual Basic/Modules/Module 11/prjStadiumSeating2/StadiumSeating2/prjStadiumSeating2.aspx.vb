'Alex Kolar
'4/23/2013
'CIS159 Section 28998
'Stadium Seating 2

Partial Class prjStadiumSeating2
    Inherits System.Web.UI.Page

    'Declare constants
    Const CLASS_A As Decimal = 15
    Const CLASS_B As Decimal = 12
    Const CLASS_C As Decimal = 9

    Protected Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Try
            'Declare variables.
            Dim decClassA As Decimal
            Dim decClassB As Decimal
            Dim decClassC As Decimal
            Dim decTotalRevenue As Decimal

            Dim totClassA As Decimal
            Dim totClassB As Decimal
            Dim totClassC As Decimal

            'Convert the Text properties of the text boxes into variables.
            decClassA = txtClassA.Text
            decClassB = txtClassB.Text
            decClassC = txtClassC.Text

            'Calculate the total cost for each class. Then convert them to currency strings
            totClassA = decClassA * CLASS_A
            lblClassA.Text = totClassA.ToString("c")

            totClassB = decClassB * CLASS_B
            lblClassB.Text = totClassB.ToString("c")

            totClassC = decClassC * CLASS_C
            lblClassC.Text = totClassC.ToString("c")

            'Calculate and display the total revenue.
            decTotalRevenue = totClassA + totClassB + totClassC
            lblTotal.Text = decTotalRevenue.ToString("c")
        Catch
            'Error message
            lblError.Text = "All input must be valid numeric values."
        End Try
    End Sub

    Protected Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear the text boxes.
        txtClassA.Text = ""
        txtClassB.Text = ""
        txtClassC.Text = ""

        'Clear the labels.
        lblClassA.Text = ""
        lblClassB.Text = ""
        lblClassC.Text = ""
        lblTotal.Text = ""

        'Place the cursor on txtClassA
        txtClassA.Focus()
    End Sub
End Class
