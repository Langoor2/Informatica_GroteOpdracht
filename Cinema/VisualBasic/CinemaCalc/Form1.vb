Public Class Form1
    Dim ppl As Decimal ' Defining variables as decimal
    Dim money As Decimal
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If IsNumeric(TextBox1.Text) Then ' Check if numeric
            ppl = TextBox1.Text ' Write the textbox to a varible
            If ppl < 0 Then ' Check if there isn't a negative number of people
                TextBox2.Text = "Error"
            ElseIf ppl < 10 And ppl > 0 Then ' Check if there are less then 10 people, but more then 0 
                money = 8 * ppl
            ElseIf ppl < 20 And ppl > 10 Or ppl = 10 Then ' Check if there are less then 20 people, but more or equal to 10
                money = (8 - (8 / 100 * 15)) * ppl
            ElseIf ppl = 20 Or ppl > 20 Then ' Check if there are 20 or more people
                money = (8 - (8 / 100 * 30)) * ppl
            ElseIf ppl = 0 Then 'Check if there is one people
                money = 0
            End If
        Else
            TextBox2.Text = "Error" ' Give an error if the value isn't a number
        End If
        TextBox2.Text = money ' Write the variable to a textbox
    End Sub
End Class
