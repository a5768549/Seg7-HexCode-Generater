Imports System.IO
Imports System.Text

Public Class Form1
    Dim Seg1_Value, Seg2_Value, Seg3_Value, Seg4_Value As Integer

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tmp1(), tmp2(), tmp3(), tmp4() As String
        Show_Seg1.Text = "0x" & Conversion.Hex(Seg1_Value).ToString
        Show_Seg2.Text = "0x" & Conversion.Hex(Seg2_Value).ToString
        Show_Seg3.Text = "0x" & Conversion.Hex(Seg3_Value).ToString
        Show_Seg4.Text = "0x" & Conversion.Hex(Seg4_Value).ToString
        tmp1 = Show_Seg1.Text.Split("x")
        tmp2 = Show_Seg2.Text.Split("x")
        tmp3 = Show_Seg3.Text.Split("x")
        tmp4 = Show_Seg4.Text.Split("x")
        If Len(tmp1(1)) <> 2 Then
            Show_Seg1.Text = "0x0" & tmp1(1)
        End If
        If Len(tmp2(1)) <> 2 Then
            Show_Seg2.Text = "0x0" & tmp2(1)
        End If
        If Len(tmp3(1)) <> 2 Then
            Show_Seg3.Text = "0x0" & tmp3(1)
        End If
        If Len(tmp4(1)) <> 2 Then
            Show_Seg4.Text = "0x0" & tmp4(1)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(Show_Seg1.Text & "," & Show_Seg2.Text & "," & Show_Seg3.Text & "," & Show_Seg4.Text)
        Create_File()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Items.Count - 1 >= 0 Then
            ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
        End If
        Create_File()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(FolderBrowserDialog1.SelectedPath & "\Special_Seg.h", TextBox1.Text, True)
        End If
    End Sub

    Private Sub Seg_A_Click(sender As Object, e As EventArgs) Handles Seg1_A.Click, Seg2_A.Click, Seg3_A.Click, Seg4_A.Click
        Dim Name As String = sender.name
        Dim Value As Integer = &H1
        Select Case Name
            Case "Seg1_A"
                If Seg1_A.BackColor = Me.BackColor Then
                    Seg1_Value = Seg1_Value + Value : Seg1_A.BackColor = Color.Red
                ElseIf Seg1_A.BackColor = Color.Red Then
                    Seg1_Value = Seg1_Value - Value : Seg1_A.BackColor = Me.BackColor
                End If
            Case "Seg2_A"
                If Seg2_A.BackColor = Me.BackColor Then
                    Seg2_Value = Seg2_Value + Value : Seg2_A.BackColor = Color.Red
                ElseIf Seg2_A.BackColor = Color.Red Then
                    Seg2_Value = Seg2_Value - Value : Seg2_A.BackColor = Me.BackColor
                End If
            Case "Seg3_A"
                If Seg3_A.BackColor = Me.BackColor Then
                    Seg3_Value = Seg3_Value + Value : Seg3_A.BackColor = Color.Red
                ElseIf Seg3_A.BackColor = Color.Red Then
                    Seg3_Value = Seg3_Value - Value : Seg3_A.BackColor = Me.BackColor
                End If
            Case "Seg4_A"
                If Seg4_A.BackColor = Me.BackColor Then
                    Seg4_Value = Seg4_Value + Value : Seg4_A.BackColor = Color.Red
                ElseIf Seg4_A.BackColor = Color.Red Then
                    Seg4_Value = Seg4_Value - Value : Seg4_A.BackColor = Me.BackColor
                End If
        End Select
    End Sub

    Private Sub Seg_B_Click(sender As Object, e As EventArgs) Handles Seg1_B.Click, Seg2_B.Click, Seg3_B.Click, Seg4_B.Click
        Dim Name As String = sender.name
        Dim Value As Integer = &H2
        Select Case Name
            Case "Seg1_B"
                If Seg1_B.BackColor = Me.BackColor Then
                    Seg1_Value = Seg1_Value + Value : Seg1_B.BackColor = Color.Red
                ElseIf Seg1_B.BackColor = Color.Red Then
                    Seg1_Value = Seg1_Value - Value : Seg1_B.BackColor = Me.BackColor
                End If
            Case "Seg2_B"
                If Seg2_B.BackColor = Me.BackColor Then
                    Seg2_Value = Seg2_Value + Value : Seg2_B.BackColor = Color.Red
                ElseIf Seg2_B.BackColor = Color.Red Then
                    Seg2_Value = Seg2_Value - Value : Seg2_B.BackColor = Me.BackColor
                End If
            Case "Seg3_B"
                If Seg3_B.BackColor = Me.BackColor Then
                    Seg3_Value = Seg3_Value + Value : Seg3_B.BackColor = Color.Red
                ElseIf Seg3_B.BackColor = Color.Red Then
                    Seg3_Value = Seg3_Value - Value : Seg3_B.BackColor = Me.BackColor
                End If
            Case "Seg4_B"
                If Seg4_B.BackColor = Me.BackColor Then
                    Seg4_Value = Seg4_Value + Value : Seg4_B.BackColor = Color.Red
                ElseIf Seg4_B.BackColor = Color.Red Then
                    Seg4_Value = Seg4_Value - Value : Seg4_B.BackColor = Me.BackColor
                End If
        End Select
    End Sub
    Private Sub Seg_C_Click(sender As Object, e As EventArgs) Handles Seg1_C.Click, Seg2_C.Click, Seg3_C.Click, Seg4_C.Click
        Dim Name As String = sender.name
        Dim Value As Integer = &H4
        Select Case Name
            Case "Seg1_C"
                If Seg1_C.BackColor = Me.BackColor Then
                    Seg1_Value = Seg1_Value + Value : Seg1_C.BackColor = Color.Red
                ElseIf Seg1_C.BackColor = Color.Red Then
                    Seg1_Value = Seg1_Value - Value : Seg1_C.BackColor = Me.BackColor
                End If
            Case "Seg2_C"
                If Seg2_C.BackColor = Me.BackColor Then
                    Seg2_Value = Seg2_Value + Value : Seg2_C.BackColor = Color.Red
                ElseIf Seg2_C.BackColor = Color.Red Then
                    Seg2_Value = Seg2_Value - Value : Seg2_C.BackColor = Me.BackColor
                End If
            Case "Seg3_C"
                If Seg3_C.BackColor = Me.BackColor Then
                    Seg3_Value = Seg3_Value + Value : Seg3_C.BackColor = Color.Red
                ElseIf Seg3_C.BackColor = Color.Red Then
                    Seg3_Value = Seg3_Value - Value : Seg3_C.BackColor = Me.BackColor
                End If
            Case "Seg4_C"
                If Seg4_C.BackColor = Me.BackColor Then
                    Seg4_Value = Seg4_Value + Value : Seg4_C.BackColor = Color.Red
                ElseIf Seg4_C.BackColor = Color.Red Then
                    Seg4_Value = Seg4_Value - Value : Seg4_C.BackColor = Me.BackColor
                End If
        End Select
    End Sub

    Private Sub Seg_D_Click(sender As Object, e As EventArgs) Handles Seg1_D.Click, Seg2_D.Click, Seg3_D.Click, Seg4_D.Click
        Dim Name As String = sender.name
        Dim Value As Integer = &H8
        Select Case Name
            Case "Seg1_D"
                If Seg1_D.BackColor = Me.BackColor Then
                    Seg1_Value = Seg1_Value + Value : Seg1_D.BackColor = Color.Red
                ElseIf Seg1_D.BackColor = Color.Red Then
                    Seg1_Value = Seg1_Value - Value : Seg1_D.BackColor = Me.BackColor
                End If
            Case "Seg2_D"
                If Seg2_D.BackColor = Me.BackColor Then
                    Seg2_Value = Seg2_Value + Value : Seg2_D.BackColor = Color.Red
                ElseIf Seg2_D.BackColor = Color.Red Then
                    Seg2_Value = Seg2_Value - Value : Seg2_D.BackColor = Me.BackColor
                End If
            Case "Seg3_D"
                If Seg3_D.BackColor = Me.BackColor Then
                    Seg3_Value = Seg3_Value + Value : Seg3_D.BackColor = Color.Red
                ElseIf Seg3_D.BackColor = Color.Red Then
                    Seg3_Value = Seg3_Value - Value : Seg3_D.BackColor = Me.BackColor
                End If
            Case "Seg4_D"
                If Seg4_D.BackColor = Me.BackColor Then
                    Seg4_Value = Seg4_Value + Value : Seg4_D.BackColor = Color.Red
                ElseIf Seg4_D.BackColor = Color.Red Then
                    Seg4_Value = Seg4_Value - Value : Seg4_D.BackColor = Me.BackColor
                End If
        End Select
    End Sub

    Private Sub Seg_E_Click(sender As Object, e As EventArgs) Handles Seg1_E.Click, Seg2_E.Click, Seg3_E.Click, Seg4_E.Click
        Dim Name As String = sender.name
        Dim Value As Integer = &H10
        Select Case Name
            Case "Seg1_E"
                If Seg1_E.BackColor = Me.BackColor Then
                    Seg1_Value = Seg1_Value + Value : Seg1_E.BackColor = Color.Red
                ElseIf Seg1_E.BackColor = Color.Red Then
                    Seg1_Value = Seg1_Value - Value : Seg1_E.BackColor = Me.BackColor
                End If
            Case "Seg2_E"
                If Seg2_E.BackColor = Me.BackColor Then
                    Seg2_Value = Seg2_Value + Value : Seg2_E.BackColor = Color.Red
                ElseIf Seg2_E.BackColor = Color.Red Then
                    Seg2_Value = Seg2_Value - Value : Seg2_E.BackColor = Me.BackColor
                End If
            Case "Seg3_E"
                If Seg3_E.BackColor = Me.BackColor Then
                    Seg3_Value = Seg3_Value + Value : Seg3_E.BackColor = Color.Red
                ElseIf Seg3_E.BackColor = Color.Red Then
                    Seg3_Value = Seg3_Value - Value : Seg3_E.BackColor = Me.BackColor
                End If
            Case "Seg4_E"
                If Seg4_E.BackColor = Me.BackColor Then
                    Seg4_Value = Seg4_Value + Value : Seg4_E.BackColor = Color.Red
                ElseIf Seg4_E.BackColor = Color.Red Then
                    Seg4_Value = Seg4_Value - Value : Seg4_E.BackColor = Me.BackColor
                End If
        End Select
    End Sub

    Private Sub Seg_F_Click(sender As Object, e As EventArgs) Handles Seg1_F.Click, Seg2_F.Click, Seg3_F.Click, Seg4_F.Click
        Dim Name As String = sender.name
        Dim Value As Integer = &H20
        Select Case Name
            Case "Seg1_F"
                If Seg1_F.BackColor = Me.BackColor Then
                    Seg1_Value = Seg1_Value + Value : Seg1_F.BackColor = Color.Red
                ElseIf Seg1_F.BackColor = Color.Red Then
                    Seg1_Value = Seg1_Value - Value : Seg1_F.BackColor = Me.BackColor
                End If
            Case "Seg2_F"
                If Seg2_F.BackColor = Me.BackColor Then
                    Seg2_Value = Seg2_Value + Value : Seg2_F.BackColor = Color.Red
                ElseIf Seg2_F.BackColor = Color.Red Then
                    Seg2_Value = Seg2_Value - Value : Seg2_F.BackColor = Me.BackColor
                End If
            Case "Seg3_F"
                If Seg3_F.BackColor = Me.BackColor Then
                    Seg3_Value = Seg3_Value + Value : Seg3_F.BackColor = Color.Red
                ElseIf Seg3_F.BackColor = Color.Red Then
                    Seg3_Value = Seg3_Value - Value : Seg3_F.BackColor = Me.BackColor
                End If
            Case "Seg4_F"
                If Seg4_F.BackColor = Me.BackColor Then
                    Seg4_Value = Seg4_Value + Value : Seg4_F.BackColor = Color.Red
                ElseIf Seg4_F.BackColor = Color.Red Then
                    Seg4_Value = Seg4_Value - Value : Seg4_F.BackColor = Me.BackColor
                End If
        End Select
    End Sub

    Sub Create_File()
        Dim tmp As String
        tmp = "#Define X " & ListBox1.Items.Count & vbCrLf
        tmp &= "int Special_Seg[" & "X" & "][4] = " & vbCrLf & "{" & vbCrLf
        For i = 0 To ListBox1.Items.Count - 1
            tmp &= "{" & ListBox1.Items(i) & "}," & vbCrLf
        Next
        tmp = tmp.Remove(Len(tmp) - 2)
        tmp &= vbCrLf & "};"
        TextBox1.Text = tmp
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Create_File()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Seg1_A.BackColor = Me.BackColor
        Seg1_B.BackColor = Me.BackColor
        Seg1_C.BackColor = Me.BackColor
        Seg1_D.BackColor = Me.BackColor
        Seg1_E.BackColor = Me.BackColor
        Seg1_F.BackColor = Me.BackColor
        Seg1_G.BackColor = Me.BackColor
        Seg1_H.BackColor = Me.BackColor
        Seg2_A.BackColor = Me.BackColor
        Seg2_B.BackColor = Me.BackColor
        Seg2_C.BackColor = Me.BackColor
        Seg2_D.BackColor = Me.BackColor
        Seg2_E.BackColor = Me.BackColor
        Seg2_F.BackColor = Me.BackColor
        Seg2_G.BackColor = Me.BackColor
        Seg2_H.BackColor = Me.BackColor
        Seg3_A.BackColor = Me.BackColor
        Seg3_B.BackColor = Me.BackColor
        Seg3_C.BackColor = Me.BackColor
        Seg3_D.BackColor = Me.BackColor
        Seg3_E.BackColor = Me.BackColor
        Seg3_F.BackColor = Me.BackColor
        Seg3_G.BackColor = Me.BackColor
        Seg3_H.BackColor = Me.BackColor
        Seg4_A.BackColor = Me.BackColor
        Seg4_B.BackColor = Me.BackColor
        Seg4_C.BackColor = Me.BackColor
        Seg4_D.BackColor = Me.BackColor
        Seg4_E.BackColor = Me.BackColor
        Seg4_F.BackColor = Me.BackColor
        Seg4_G.BackColor = Me.BackColor
        Seg4_H.BackColor = Me.BackColor
        Seg1_Value = &H0
        Seg2_Value = &H0
        Seg3_Value = &H0
        Seg4_Value = &H0
    End Sub

    Private Sub Seg_G_Click(sender As Object, e As EventArgs) Handles Seg1_G.Click, Seg2_G.Click, Seg3_G.Click, Seg4_G.Click
        Dim Name As String = sender.name
        Dim Value As Integer = &H40
        Select Case Name
            Case "Seg1_G"
                If Seg1_G.BackColor = Me.BackColor Then
                    Seg1_Value = Seg1_Value + Value : Seg1_G.BackColor = Color.Red
                ElseIf Seg1_G.BackColor = Color.Red Then
                    Seg1_Value = Seg1_Value - Value : Seg1_G.BackColor = Me.BackColor
                End If
            Case "Seg2_G"
                If Seg2_G.BackColor = Me.BackColor Then
                    Seg2_Value = Seg2_Value + Value : Seg2_G.BackColor = Color.Red
                ElseIf Seg2_G.BackColor = Color.Red Then
                    Seg2_Value = Seg2_Value - Value : Seg2_G.BackColor = Me.BackColor
                End If
            Case "Seg3_G"
                If Seg3_G.BackColor = Me.BackColor Then
                    Seg3_Value = Seg3_Value + Value : Seg3_G.BackColor = Color.Red
                ElseIf Seg3_G.BackColor = Color.Red Then
                    Seg3_Value = Seg3_Value - Value : Seg3_G.BackColor = Me.BackColor
                End If
            Case "Seg4_G"
                If Seg4_G.BackColor = Me.BackColor Then
                    Seg4_Value = Seg4_Value + Value : Seg4_G.BackColor = Color.Red
                ElseIf Seg4_G.BackColor = Color.Red Then
                    Seg4_Value = Seg4_Value - Value : Seg4_G.BackColor = Me.BackColor
                End If
        End Select
    End Sub

    Private Sub Seg_H_Click(sender As Object, e As EventArgs) Handles Seg1_H.Click, Seg2_H.Click, Seg3_H.Click, Seg4_H.Click
        Dim Name As String = sender.name
        Dim Value As Integer = &H80
        Select Case Name
            Case "Seg1_H"
                If Seg1_H.BackColor = Me.BackColor Then
                    Seg1_Value = Seg1_Value + Value : Seg1_H.BackColor = Color.Red
                ElseIf Seg1_H.BackColor = Color.Red Then
                    Seg1_Value = Seg1_Value - Value : Seg1_H.BackColor = Me.BackColor
                End If
            Case "Seg2_H"
                If Seg2_H.BackColor = Me.BackColor Then
                    Seg2_Value = Seg2_Value + Value : Seg2_H.BackColor = Color.Red
                ElseIf Seg2_H.BackColor = Color.Red Then
                    Seg2_Value = Seg2_Value - Value : Seg2_H.BackColor = Me.BackColor
                End If
            Case "Seg3_H"
                If Seg3_H.BackColor = Me.BackColor Then
                    Seg3_Value = Seg3_Value + Value : Seg3_H.BackColor = Color.Red
                ElseIf Seg3_H.BackColor = Color.Red Then
                    Seg3_Value = Seg3_Value - Value : Seg3_H.BackColor = Me.BackColor
                End If
            Case "Seg4_H"
                If Seg4_H.BackColor = Me.BackColor Then
                    Seg4_Value = Seg4_Value + Value : Seg4_H.BackColor = Color.Red
                ElseIf Seg4_H.BackColor = Color.Red Then
                    Seg4_Value = Seg4_Value - Value : Seg4_H.BackColor = Me.BackColor
                End If
        End Select
    End Sub

    Private Sub Seg_All_Click(sender As Object, e As EventArgs) Handles Seg1_All.Click, Seg2_All.Click, Seg3_All.Click, Seg4_All.Click
        Dim Name As String = sender.name
        Dim all As Integer = &HFF
        Dim clear As Integer = &H0
        Select Case Name
            Case "Seg1_All"
                If Seg1_All.BackColor = Me.BackColor Then
                    Seg1_Value = all : Seg1_All.BackColor = Color.Red
                    Seg1_A.BackColor = Color.Red
                    Seg1_B.BackColor = Color.Red
                    Seg1_C.BackColor = Color.Red
                    Seg1_D.BackColor = Color.Red
                    Seg1_E.BackColor = Color.Red
                    Seg1_F.BackColor = Color.Red
                    Seg1_G.BackColor = Color.Red
                    Seg1_H.BackColor = Color.Red
                ElseIf Seg1_All.BackColor = Color.Red Then
                    Seg1_Value = clear : Seg1_All.BackColor = Me.BackColor
                    Seg1_A.BackColor = Me.BackColor
                    Seg1_B.BackColor = Me.BackColor
                    Seg1_C.BackColor = Me.BackColor
                    Seg1_D.BackColor = Me.BackColor
                    Seg1_E.BackColor = Me.BackColor
                    Seg1_F.BackColor = Me.BackColor
                    Seg1_G.BackColor = Me.BackColor
                    Seg1_H.BackColor = Me.BackColor
                End If
            Case "Seg2_All"
                If Seg2_All.BackColor = Me.BackColor Then
                    Seg2_Value = all : Seg2_All.BackColor = Color.Red
                    Seg2_A.BackColor = Color.Red
                    Seg2_B.BackColor = Color.Red
                    Seg2_C.BackColor = Color.Red
                    Seg2_D.BackColor = Color.Red
                    Seg2_E.BackColor = Color.Red
                    Seg2_F.BackColor = Color.Red
                    Seg2_G.BackColor = Color.Red
                    Seg2_H.BackColor = Color.Red
                ElseIf Seg2_All.BackColor = Color.Red Then
                    Seg2_Value = clear : Seg2_All.BackColor = Me.BackColor
                    Seg2_A.BackColor = Me.BackColor
                    Seg2_B.BackColor = Me.BackColor
                    Seg2_C.BackColor = Me.BackColor
                    Seg2_D.BackColor = Me.BackColor
                    Seg2_E.BackColor = Me.BackColor
                    Seg2_F.BackColor = Me.BackColor
                    Seg2_G.BackColor = Me.BackColor
                    Seg2_H.BackColor = Me.BackColor
                End If
            Case "Seg3_All"
                If Seg3_All.BackColor = Me.BackColor Then
                    Seg3_Value = all : Seg3_All.BackColor = Color.Red
                    Seg3_A.BackColor = Color.Red
                    Seg3_B.BackColor = Color.Red
                    Seg3_C.BackColor = Color.Red
                    Seg3_D.BackColor = Color.Red
                    Seg3_E.BackColor = Color.Red
                    Seg3_F.BackColor = Color.Red
                    Seg3_G.BackColor = Color.Red
                    Seg3_H.BackColor = Color.Red
                ElseIf Seg3_All.BackColor = Color.Red Then
                    Seg3_Value = clear : Seg3_All.BackColor = Me.BackColor
                    Seg3_A.BackColor = Me.BackColor
                    Seg3_B.BackColor = Me.BackColor
                    Seg3_C.BackColor = Me.BackColor
                    Seg3_D.BackColor = Me.BackColor
                    Seg3_E.BackColor = Me.BackColor
                    Seg3_F.BackColor = Me.BackColor
                    Seg3_G.BackColor = Me.BackColor
                    Seg3_H.BackColor = Me.BackColor
                End If
            Case "Seg4_All"
                If Seg4_All.BackColor = Me.BackColor Then
                    Seg4_Value = all : Seg4_All.BackColor = Color.Red
                    Seg4_A.BackColor = Color.Red
                    Seg4_B.BackColor = Color.Red
                    Seg4_C.BackColor = Color.Red
                    Seg4_D.BackColor = Color.Red
                    Seg4_E.BackColor = Color.Red
                    Seg4_F.BackColor = Color.Red
                    Seg4_G.BackColor = Color.Red
                    Seg4_H.BackColor = Color.Red
                ElseIf Seg4_All.BackColor = Color.Red Then
                    Seg4_Value = clear : Seg4_All.BackColor = Me.BackColor
                    Seg4_A.BackColor = Me.BackColor
                    Seg4_B.BackColor = Me.BackColor
                    Seg4_C.BackColor = Me.BackColor
                    Seg4_D.BackColor = Me.BackColor
                    Seg4_E.BackColor = Me.BackColor
                    Seg4_F.BackColor = Me.BackColor
                    Seg4_G.BackColor = Me.BackColor
                    Seg4_H.BackColor = Me.BackColor
                End If
        End Select
    End Sub
End Class
