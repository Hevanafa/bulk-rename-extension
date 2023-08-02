Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        e.Effect = IIf(e.Data.GetDataPresent(DataFormats.FileDrop), DragDropEffects.Copy, DragDropEffects.None)
    End Sub

    Dim files As New List(Of Object)

    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim candidates$() = e.Data.GetData(DataFormats.FileDrop)
        Dim skipped% = 0

        For Each file In candidates
            If Not files.Contains(file) Then
                files.Add(file)
                lsbFiles.Items.Add(file)
            Else
                skipped += 1
            End If
        Next

        ' lsbFiles.Refresh()
        ' lsbFiles.Update()

        checkemptylist

        If skipped > 0 Then
            MessageBox.Show($"Skipped { skipped } files due to already added.")
        End If

    End Sub

    Sub CheckEmptyList()
        lblHint.Visible = files.Count = 0
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' lsbFiles.DataSource = files
    End Sub

    Private Sub lsbFiles_KeyDown(sender As Object, e As KeyEventArgs) Handles lsbFiles.KeyDown
        If e.KeyCode = Keys.Delete And lsbFiles.SelectedIndex >= 0 Then
            files.RemoveAt(lsbFiles.SelectedIndex)
            lsbFiles.Items.RemoveAt(lsbFiles.SelectedIndex)
            checkemptylist
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim new_extension$ = txbNewExtension.Text.Trim

        If new_extension = "" AndAlso
            MessageBox.Show(
                "New extension is empty, your files will lose the extensions. Continue?",
                "Empty Extension",
                MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub

        If Not new_extension.StartsWith(".") Then
            new_extension = "." + new_extension
        Else
            ' handle many dots
            new_extension = Regex.Replace(new_extension, "\.+", ".")
        End If

        Dim skipped% = 0

        For Each f In files
            Try
                Dim new_filename$ = f.Replace(Path.GetExtension(f), new_extension)
                File.Move(f, new_filename)
            Catch ex As Exception
                skipped += 1
            End Try
        Next

        If MessageBox.Show(
            $"Renamed { files.Count } files." & vbCrLf &
            IIf(skipped > 0, $"Skipped { skipped } files." + vbCrLf, "") &
            "Clear list?", "Success", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            files.Clear()
            lsbFiles.Items.Clear()

            CheckEmptyList()
        End If
    End Sub

End Class
