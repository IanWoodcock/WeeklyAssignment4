Public Class Form1



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUserInput.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserInput.Text = ""
        lblTotalCost.Text = "$0.00"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Const cdecCostPerNight As Decimal = 79D
        Dim strUserInput As String
        Dim intUserInput As Integer
        Dim decCostOfStay As Decimal

        strUserInput = txtUserInput.Text
        intUserInput = Convert.ToInt32(strUserInput)
        decCostOfStay = intUserInput * cdecCostPerNight
        lblTotalCost.Text = decCostOfStay.ToString("C")

    End Sub

    Private Sub txtTotalCost_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblNumOfNights_Click(sender As Object, e As EventArgs) Handles lblNumOfNights.Click

    End Sub
End Class
