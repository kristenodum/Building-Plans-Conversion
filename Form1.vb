Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'Declaration section
        Dim intNumber As Integer = 0
        Dim decTotal As Decimal
        Dim decInch As Decimal = 0.0245D
        Dim decMeter As Decimal = 39.3701D

        lblAnswer.Visible = True

        If IsNumeric(txtValue.Text) Then
            intNumber = Convert.ToInt32(txtValue.Text)
            If intNumber > 0 Then
                If radInchMet.Checked Then
                    decTotal = (intNumber * decInch)
                    lblAnswer.Text = intNumber & " inches " & decTotal & " meters "
                ElseIf radMetInch.Checked Then
                    decTotal = (intNumber * decMeter)
                    lblAnswer.Text = intNumber & " meters " & decTotal & " inches "

                End If

            Else
                'Display error message if user entered a negative number 
                MsgBox("Enter a positive number ", , "Invalid number error")

            End If
        Else
            'Display error message if user entered a nonnumeric value 
            MsgBox("Enter a reasonable number ", , "Invalid Entry error")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtValue.Clear()
        radInchMet.Checked = True
        radMetInch.Checked = False
        txtValue.Focus()
        lblAnswer.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
