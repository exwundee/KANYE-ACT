Class MainWindow
    Private Sub LstKayaks_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles lstKayaks.SelectionChanged
        imgRecKayak.Visibility = Visibility.Hidden
        imgRecTandem.Visibility = Visibility.Hidden
        imgSeaKayak.Visibility = Visibility.Hidden

        If lstKayaks.SelectedIndex = 0 Then
            imgRecKayak.Visibility = Visibility.Visible
        ElseIf lstKayaks.SelectedIndex = 1 Then
            imgRecTandem.Visibility = Visibility.Visible
        ElseIf lstKayaks.SelectedIndex = 2 Then
            imgSeaKayak.Visibility = Visibility.Visible
        End If
    End Sub
End Class
