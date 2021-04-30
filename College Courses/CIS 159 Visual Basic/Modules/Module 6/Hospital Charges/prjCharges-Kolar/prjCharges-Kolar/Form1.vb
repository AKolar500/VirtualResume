'Alex Kolar
'3/19/2013
'CIS159 Section 28998
'Hospital Charges

Public Class Form1
    'Declare variables
    Dim intLengthOfStay As Integer
    Dim decMedication As Decimal
    Dim decSurgery As Decimal
    Dim decLabFees As Decimal
    Dim decPhysical As Decimal

    'Function-specific variables
    Dim decMiscellaneous As Decimal
    Dim decStayerLength As Decimal
    Dim decTotalCharges As Decimal

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'validate data with if statements

        If Integer.TryParse(txtStay.Text, intLengthOfStay) Then

            If Decimal.TryParse(txtMedication.Text, decMedication) Then

                If Decimal.TryParse(txtSurgery.Text, decSurgery) Then

                    If Decimal.TryParse(txtLabFees.Text, decLabFees) Then

                        If Decimal.TryParse(txtPhysical.Text, decPhysical) Then
                            'call the staycharges function
                            decStayerLength = CalcStayCharges(intStayLength:=intLengthOfStay)
                            'call the misccharges function
                            decMiscellaneous = CalcMiscCharges(decMeds:=decMedication, decSurgical:=decSurgery,
                                                               decLabs:=decLabFees, decPhysico:=decPhysical)
                            'call the totalcharges function
                            decTotalCharges = CalcTotalCharges(decStays:=decStayerLength, decMiscey:=decMiscellaneous)
                            'convert the totalcharges into a currency string
                            lblTotalCost.Text = decTotalCharges.ToString("c")
                        Else
                            MessageBox.Show("Physical is not acceptable.")
                            txtPhysical.Focus()
                        End If

                    Else
                        MessageBox.Show("Lab Fees is not acceptable.")
                        txtLabFees.Focus()
                    End If

                Else
                    MessageBox.Show("Surgery is not acceptable.")
                    txtSurgery.Focus()
                End If

            Else
                MessageBox.Show("Medication is not acceptable.")
                txtMedication.Focus()
            End If

        Else
            MessageBox.Show("Length of Stay is not an integer.")
            txtStay.Focus()
        End If

    End Sub

    'This function calculates the cost of lodging at the hospital
    Function CalcStayCharges(ByVal intStayLength As Integer) As Decimal

        'multiply the staylength by 350
        decStayerLength = intLengthOfStay * 350

        'return cost of lodging
        Return decStayerLength
    End Function

    'This function adds the remaining charges together
    Function CalcMiscCharges(ByVal decMeds As Decimal, ByVal decSurgical As Decimal, ByVal decLabs As Decimal,
                             ByVal decPhysico As Decimal) As Decimal
        'Add the miscellaneous charges
        decMiscellaneous = decMedication + decSurgery + decLabFees + decPhysical

        'return the miscellaneous charges
        Return decMiscellaneous
    End Function

    Function CalcTotalCharges(ByVal decStays As Decimal, ByVal decMiscey As Decimal) As Decimal
        'add the initial totals together
        decTotalCharges = decMiscellaneous + decStayerLength

        'return the total cost of the stay
        Return decTotalCharges
    End Function

    'Clears all fields
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear the fields
        txtStay.Text = ""
        txtMedication.Text = ""
        txtSurgery.Text = ""
        txtLabFees.Text = ""
        txtPhysical.Text = ""
        lblTotalCost.Text = ""

        'place the cursor in the first field
        txtStay.Focus()
    End Sub

    'Closes the form
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
