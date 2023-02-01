Public Class Form1

    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        Dim tnume1, tnume2, tnume3, highest As Integer
        tnume1 = tnum1.Text
        tnume2 = tnum2.Text
        tnume3 = tnum3.Text

        If tnume1 > tnume2 Then
            If tnume1 > tnume3 Then
                highest = tnume1
            Else
                highest = tnume3
            End If
        ElseIf tnume2 > tnume3 Then
            highest = tnume2
        Else
            highest = tnume3

        End If

        highestt.Text = highest


    End Sub
End Class
