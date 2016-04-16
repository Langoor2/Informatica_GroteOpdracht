Public Class Form1
    Dim A As Decimal
    Dim B As Decimal
    Dim C As Decimal
    Dim D As Decimal
    Dim X1 As Decimal
    Dim X2 As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBoxA.Text) = True Then
            A = TextBoxA.Text
            If IsNumeric(TextBoxB.Text) = True Then
                B = TextBoxB.Text
                If IsNumeric(TextBoxC.Text) = True Then
                    C = TextBoxC.Text
                End If
            End If
        End If
        D = B ^ 2 - 4 * A * C
        TextBoxD.Text = D

        If D < 0 Then
            TextBoxX1.Text = "Error"
            TextBoxX2.Text = "D<0, cant solve"
        ElseIf D = 0 Then
            X1 = -B / 2 * A
            TextBoxX1.Text = X1
            TextBoxX2.Text = ""
        Else
            X1 = (-B + Math.Sqrt(D)) / (2 * A)
            X2 = (-B - Math.Sqrt(D)) / (2 * A)
            TextBoxX1.Text = X1
            TextBoxX2.Text = X2
        End If
    End Sub
End Class
