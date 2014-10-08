Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click

        Dim year As Double = 2014
        Dim pop As Double = 7000.0

        Do While pop > 6

            year -= 50
            pop = pop / 2

        Loop
        MessageBox.Show("The answer is " & year)

    End Sub
End Class
