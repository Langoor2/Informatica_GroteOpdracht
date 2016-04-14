Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TempC.Text = "Kevin" Then
            TempF.Text = "Lichaamstemperatuur"
            TempK.Text = "Lichaamstemperatuur"
        ElseIf TempC.Text = "Laura" Then
            TempF.Text = "Lauw"
            TempK.Text = "Lauw"
        Else
            TempK.Text = TempC.Text + 273.15
            TempF.Text = (9 * TempC.Text / 5) + 32
        End If
    End Sub
End Class
