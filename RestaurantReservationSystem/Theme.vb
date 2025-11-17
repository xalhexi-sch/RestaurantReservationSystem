Imports System.Drawing
Imports System.Windows.Forms

Public Module Theme
    Public ReadOnly PastelPink As Color = Color.FromArgb(255, 223, 235)
    Public ReadOnly PastelPinkDark As Color = Color.FromArgb(255, 200, 220)
    Public ReadOnly PastelPinkAccent As Color = Color.FromArgb(255, 105, 180)

    Public Sub ApplyTheme(form As Form)
        If form Is Nothing Then Return

        form.BackColor = PastelPink

        For Each ctrl As Control In form.Controls
            ApplyThemeToControl(ctrl)
        Next
    End Sub

    Private Sub ApplyThemeToControl(ctrl As Control)
        If TypeOf ctrl Is Panel OrElse TypeOf ctrl Is GroupBox Then
            ctrl.BackColor = PastelPinkDark
        ElseIf TypeOf ctrl Is Button Then
            Dim btn = DirectCast(ctrl, Button)
            btn.BackColor = PastelPinkAccent
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.ForeColor = Color.White
        End If

        For Each child As Control In ctrl.Controls
            ApplyThemeToControl(child)
        Next
    End Sub
End Module
