Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TempC_TextChanged(sender As Object, e As EventArgs) Handles TempC.TextChanged
        If IsNumeric(TempC.Text) = True Then
            TempK.Text = TempC.Text + 237.15
            TempF.Text = (TempC.Text * 9 / 5) + 32
        Else
            TempK.Text = "ERROR"
            TempF.Text = TempK.Text
        End If
    End Sub
End Class
