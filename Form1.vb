Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strnamahari(6) As String
        Dim a As Integer

        strnamahari(0) = "ahad"
        strnamahari(1) = "isnin"
        strnamahari(2) = "selasa"
        strnamahari(3) = "rabu"
        strnamahari(4) = "khamis"
        strnamahari(5) = "jumaat"
        strnamahari(6) = "sabtu"
        Array.Reverse(strnamahari)

        For a = 0 To 6
            ListBox1.Items.Add(strnamahari(a))
        Next
    End Sub
End Class
