Public Class Form1
    Dim A As Decimal ' Define variables as Decimal
    Dim B As Decimal
    Dim C As Decimal
    Dim D As Decimal
    Dim X1 As Decimal
    Dim X2 As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBoxA.Text) = True Then ' Check if A is numeric
            A = TextBoxA.Text ' If A is numeric, parse Textbox A to the variable
            If IsNumeric(TextBoxB.Text) = True Then 'If A is numeric, then check B
                B = TextBoxB.Text ' Again, variable parsing
                If IsNumeric(TextBoxC.Text) = True Then ' IF B is numeric, check C
                    C = TextBoxC.Text ' And again
                End If
            End If
        End If
        D = B ^ 2 - 4 * A * C ' Calculate D
        TextBoxD.Text = D ' Parse the D var to the textbox

        If D < 0 Then ' Check D smaller then 0, if yes, give an error
            TextBoxX1.Text = "Error"
            TextBoxX2.Text = "D<0, cant solve"
        ElseIf D = 0 Then ' Check if D is 0
            X1 = -B / 2 * A ' Calculate X1
            TextBoxX1.Text = X1 ' Parse X1 to the textbox
            TextBoxX2.Text = ""
        Else
            X1 = (-B + Math.Sqrt(D)) / (2 * A) ' Calculate the X-es
            X2 = (-B - Math.Sqrt(D)) / (2 * A)
            TextBoxX1.Text = X1 ' Parse the X-es to textboxes
            TextBoxX2.Text = X2
        End If
    End Sub
End Class
