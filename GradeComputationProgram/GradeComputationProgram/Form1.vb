Public Class Form1
    Dim prelim, midterm, finals, average As Double
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        prelim = txtPrelim.Text
        midterm = txtMidterm.Text
        finals = txtFinal.Text
        txtAverage.Text = (prelim + midterm + finals) / 3
        average = txtAverage.Text
        If (average) >= 97 And average <= 100 Then
            txtGPA.Text = "1.0"
            txtRemarks.Text = "Excellent"
        ElseIf (average) >= 94 And average <= 96 Then
            txtGPA.Text = "1.25"
            txtRemarks.Text = "Excellent"
        ElseIf (average) >= 91 And average < 94 Then
            txtGPA.Text = "1.50"
            txtRemarks.Text = "Very Good"
        ElseIf (average) >= 88 And average < 91 Then
            txtGPA.Text = "1.75"
            txtRemarks.Text = "Very Good"
        ElseIf (average) >= 85 And average < 88 Then
            txtGPA.Text = "2.0"
            txtRemarks.Text = "Good"
        ElseIf (average) >= 82 And average < 85 Then
            txtGPA.Text = "2.25"
            txtRemarks.Text = "Good"
        ElseIf (average) >= 79 And average < 82 Then
            txtGPA.Text = "2.50"
            txtRemarks.Text = "Satisfactory"
        ElseIf (average) >= 76 And average < 79 Then
            txtGPA.Text = "2.75"
            txtRemarks.Text = "Satisfactory"
        ElseIf (average) = 75 Then
            txtGPA.Text = "3.0"
            txtRemarks.Text = "Passing"
        ElseIf (average) < 74 Then
            txtGPA.Text = "5.0"
            txtRemarks.Text = "FAILED"
        End If

    End Sub
End Class
