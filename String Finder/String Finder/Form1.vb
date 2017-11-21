Public Class Form1

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ' Variable Declartions
        Dim intStartIndex As Integer ' Starting index of the search
        Dim inFoundIndex As Integer  ' Index of the found substring

        ' Determine whether the starting index is numeric.
        If IsNumeric(txtStartIndex.Text) Then
            'Determine whether a string to search for was entered.
            If txtToFind.Text.Length > 0 Then
                ' Get the starting index for the search.
            End If

        End If


    End Sub
End Class
