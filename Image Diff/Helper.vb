Module Helper
    Function differ(input As Color, compare As Color, tolerance As Integer, identical As Boolean) As Boolean
        Dim InputR As Short = input.R
        Dim InputG As Short = input.G
        Dim InputB As Short = input.B

        Dim bgR As Short = compare.R
        Dim bgG As Short = compare.G
        Dim bgB As Short = compare.B

        Dim DiffR As Double = (InputR - bgR) * 0.299
        Dim DiffG As Double = (InputG - bgG) * 0.587
        Dim DiffB As Double = (InputB - bgB) * 0.114
        Dim Diff As Double = DiffR * DiffR + DiffG * DiffG + DiffB * DiffB

        Return (identical And Diff <= tolerance) Or (Not identical And Diff > tolerance)
    End Function

    Public LogText As String = ""

    Sub log(text As String)
        LogText = LogText & text & Environment.NewLine
    End Sub
    Sub resetlog()
        LogText = ""
    End Sub
End Module
