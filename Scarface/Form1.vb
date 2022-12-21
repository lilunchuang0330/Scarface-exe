Imports System.Reflection.Emit

Public Class Form1

    Public ck1 As Boolean = False 'ck開頭的變數紀錄單一章節的通關情況
    Public ck2 As Boolean = False
    Public ck3 As Boolean = False
    Public ck4 As Boolean = False
    Public ck5 As Boolean = False
    Public ck6 As Boolean = False
    Public ck7 As Boolean = False
    Public ck8 As Boolean = False
    Public pass As Integer = 0 '紀錄總共過了幾關

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1_Timer()
    End Sub

    Private Sub Timer1_Timer()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If btnStart.ForeColor = ForeColor.Red Then
            btnStart.ForeColor = ForeColor.Black
        Else
            btnStart.ForeColor = ForeColor.Red
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If ck1 = True And pass = 1 Then
            CH2.Show()
            Me.Hide()
        Else
            CH1.Show()
            Me.Hide()
        End If


        If ck2 = True And pass = 2 Then
            CH3.Show()
            Me.Hide()
        End If

        If ck3 = True And pass = 3 Then
            CH4.Show()
            Me.Hide()
        End If

        If ck4 = True And pass = 4 Then
            CH5.Show()
            Me.Hide()
        End If

        If ck5 = True And pass = 5 Then
            CH6.Show()
            Me.Hide()
        End If

        If ck6 = True And pass = 6 Then
            CH7.Show()
            Me.Hide()
        End If

        If ck7 = True And pass = 7 Then
            CH8.Show()
            Me.Hide()
        End If

        If ck8 = True And pass = 8 Then
            CH1.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnCh1_Click(sender As Object, e As EventArgs) Handles btnCh1.Click
        CH1.Show()
        Me.Hide()
    End Sub
End Class
