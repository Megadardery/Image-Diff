Public Class frmMain

    Private Sub btnBrowseInput_Click(sender As Object, e As EventArgs) Handles btnBrowseInput.Click
        FileLoader.FileName = ""
        FileLoader.Multiselect = True
        If FileLoader.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtInput.Text = Join(FileLoader.FileNames, "|")
        End If
    End Sub

    Private Sub btnBrowseComparison_Click(sender As Object, e As EventArgs) Handles btnBrowseComparison.Click
        FileLoader.FileName = ""
        FileLoader.Multiselect = False
        If FileLoader.ShowDialog = Windows.Forms.DialogResult.OK Then txtComparison.Text = FileLoader.FileName
    End Sub

    Private Sub txtInput_DragDrop(sender As TextBox, e As DragEventArgs) Handles txtInput.DragDrop, txtComparison.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            If sender.Name = "txtInput" Then txtInput.Text = Join(MyFiles, "|") Else txtComparison.Text = MyFiles(0)
        End If
    End Sub

    Private Sub txts_DragEnter(sender As Object, e As DragEventArgs) Handles txtInput.DragEnter, txtComparison.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub txts_TextChanged(sender As TextBox, e As EventArgs) Handles txtInput.TextChanged, txtOutput.TextChanged, txtComparison.TextChanged
        sender.Text = LTrim(sender.Text)
        If txtInput.Text <> "" And txtComparison.Text <> "" And (txtOutput.Text <> "") Then btnStart.Enabled = True Else btnStart.Enabled = False
        ToolTip1.SetToolTip(sender, sender.Text)
    End Sub

    Private Sub btnBrowseOutput_Click(sender As Object, e As EventArgs) Handles btnBrowseOutput.Click

        Dim dialog As New FolderBrowserDialog With {.Description = "Choose the location to output files:", .ShowNewFolderButton = True}
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtOutput.Text = dialog.SelectedPath
        End If

    End Sub

    Dim ComparisonColor As Color = Color.Transparent

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ComparisonColor = Color.Transparent

        For Each x As String In Split(txtInput.Text, "|")
            If Not IO.File.Exists(x) Then
                MessageBox.Show("""" & x & """" & vbCrLf & "This file which you have entered as an input file does not exist, please check the file and try again.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next


        If txtComparison.Text(0) = "#" Then
            Try
                ComparisonColor = System.Drawing.ColorTranslator.FromHtml(txtComparison.Text)
            Catch ex As Exception
                MessageBox.Show("""" & txtComparison.Text & """" & vbCrLf & "The color value you entered as the comparison is not valid.", "Invalid Color", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

        ElseIf Not IO.File.Exists(txtComparison.Text) Then
            MessageBox.Show("""" & txtComparison.Text & """" & vbCrLf & "This file which you have entered as the comparison image does not exist, please check the file and try again.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If
        If txtOutput.Text.Trim.ToLower <> "(same as input)" Then
            If IO.Path.GetPathRoot(txtOutput.Text) = "" Then
                MessageBox.Show("""" & txtOutput.Text & """" & vbCrLf & "This folder which you have entered as the output location is not valid, please check the location and try again.", "Path is not valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        End If

        If BackgroundWorker1.IsBusy = False Then
            btnStart.Enabled = False
            BackgroundWorker1.RunWorkerAsync()
        End If


    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim CompareImage As Boolean
        CompareImage = (ComparisonColor = Color.Transparent)

        Dim Input() As String = Split(txtInput.Text, "|")
        Dim Comparison As String = txtComparison.Text
        Dim SemiMask As Bitmap
        Dim OutputIdentical As Boolean = rdbIdentical.Checked
        Dim OutputPath As String = txtOutput.Text
        Dim Tolerance As Integer = numTolerance.Value * numTolerance.Value
        Dim SetAsMask As Boolean = chkMask.Checked
        Dim UseSemiMask As Boolean = False
        Dim ComparisonImage As Bitmap
        If CompareImage Then  ComparisonImage = New Bitmap(Comparison)

        If txtSemiMask.Text <> "(none)" Then
            If IO.File.Exists(txtSemiMask.Text) Then
                SemiMask = New Bitmap(txtSemiMask.Text)
                UseSemiMask = True
            Else
                log("The Semi-Mask was not able to be loaded. Please check the file and try again.")
                Throw New Exception
            End If
        End If

        Dim output As Bitmap
        Dim counter As Integer = 0
        Dim n As Integer = -1
        For Each File As String In Input
            Dim CurrentImage As Bitmap
            Try
                n += 1
                'Inital background
                CurrentImage = New Bitmap(File)
                log("Image #" & n + 1 & " was loaded.")
                output = New Bitmap(CurrentImage.Width, CurrentImage.Height)

                If CompareImage Then
                    If CurrentImage.Width <> ComparisonImage.Width OrElse CurrentImage.Height <> ComparisonImage.Height Then
                        log("!!!Image #" & n + 1 & " does not match the comparison image size. Skipped!!!")
                        Continue For
                    End If
                End If

                Using gfx As Graphics = Graphics.FromImage(output)
                    gfx.FillRectangle(New SolidBrush(If(SetAsMask, Color.Black, Color.Transparent)), 0, 0, CurrentImage.Width, CurrentImage.Height)
                End Using
                log("The image is being proccessed.")
                For x As Integer = 0 To CurrentImage.Width - 1
                    For y As Integer = 0 To CurrentImage.Height - 1
                        Dim inputColor As Color = CurrentImage.GetPixel(x, y)
                        Dim bgColor As Color
                        If UseSemiMask AndAlso SemiMask.GetPixel(x, y) <> Color.White Then
                            output.SetPixel(x, y, Color.FromArgb(128, Math.Min(2 * inputColor.R - bgColor.R, 255), Math.Min(2 * inputColor.G - bgColor.G, 255), Math.Min(2 * inputColor.B - bgColor.B, 255)))
                        Else
                            If CompareImage Then : bgColor = ComparisonImage.GetPixel(x, y)
                            Else : bgColor = ComparisonColor
                            End If

                            If differ(inputColor, bgColor, Tolerance, OutputIdentical) Then
                                output.SetPixel(x, y, If(SetAsMask, Color.White, inputColor))
                            End If
                        End If
                        counter += 1
                        If counter Mod 10 = 0 Then BackgroundWorker1.ReportProgress((counter / (CurrentImage.Width * CurrentImage.Height) + n) / Input.Length * 100)
                    Next
                Next
                counter = 0
                If OutputPath = "" Then
                    output.Save(IO.Path.Combine(IO.Path.GetDirectoryName(File), IO.Path.GetFileNameWithoutExtension(File) & "_output.png"), Imaging.ImageFormat.Png)
                Else
                    output.Save(IO.Path.Combine(OutputPath, IO.Path.GetFileNameWithoutExtension(File) & "_output.png"), Imaging.ImageFormat.Png)
                End If
                log("Image #" & n + 1 & " has been outputted successfully.")
            Finally
                CurrentImage.Dispose()
                output.Dispose()
            End Try
        Next
        If CompareImage Then ComparisonImage.Dispose()
        resetlog()
        BackgroundWorker1.ReportProgress(Progress.Maximum)
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Select Case e.ProgressPercentage
            Case Is >= 100
                Progress.Value = Progress.Maximum
            Case Is <= 0
                Progress.Value = 0
            Case Else
                Progress.Value = e.ProgressPercentage
        End Select
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Error IsNot Nothing Then
            MsgBox("One of the input files' size is not equal to the comparison image size. Please check the files and try again.", MsgBoxStyle.Exclamation)
        Else
            Dim Flasher As New WindowFlasher(Me.Handle)
            Flasher.FlashWindow()
            MessageBox.Show("All the files were created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Progress.Value = 0
        btnStart.Enabled = True
    End Sub

    Private Sub txtOutput_Enter(sender As Object, e As EventArgs) Handles txtOutput.Enter
        If txtOutput.Text.Trim = "(same as input)" Then txtOutput.Clear()
    End Sub
    Private Sub txtOutput_Leave(sender As Object, e As EventArgs) Handles txtOutput.Leave
        If txtOutput.Text.Trim = "" Or txtOutput.Text.Trim.ToLower = "(same as input)" Then txtOutput.Text = "(same as input)"
    End Sub

    Private Sub txtSemiMask_Enter(sender As Object, e As EventArgs) Handles txtSemiMask.Enter
        If txtSemiMask.Text.Trim = "(none)" Then txtSemiMask.Clear()
    End Sub
    Private Sub txtSemiMask_Leave(sender As Object, e As EventArgs) Handles txtSemiMask.Leave
        If txtSemiMask.Text.Trim = "" Or txtSemiMask.Text.Trim.ToLower = "(none)" Then txtSemiMask.Text = "(none)"
    End Sub
End Class