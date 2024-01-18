Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaration of variables'
        Dim height, weight, bmi As Double
        weight = Val(TextBox1.Text)
        height = Val(TextBox2.Text)

        bmi = weight / (height) ^ 2 'BMI Formula

        TextBox3.Text = bmi

        If bmi < 18 Then
            TextBox4.Text = "You are underweight"
        ElseIf 18 <= bmi And bmi < 26 Then
            TextBox4.Text = "You are normal weight"
        Else
            TextBox4.Text = "You are overweight"
        End If
    End Sub

    Private Sub BMICalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
