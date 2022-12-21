Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class CH1

    Dim page As Integer = 1
    Dim g1 As Boolean = False
    Dim g2 As Boolean = False
    Private Sub CH1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        picBack.Enabled = False
        btnRef.Visible = False
        btnAcc.Visible = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Label1.Text - 1
        If Label1.Text = 0 Then
            Timer1.Enabled = False
            PictureBox1.Visible = False
            picBack.Visible = True
            picBack.Enabled = True
            picBack.BackgroundImage = My.Resources._001
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            page = 2
        End If
    End Sub

    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        If page = 2 Then
            picBack.BackgroundImage = My.Resources._2
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            page = 3

        ElseIf page = 3 Then
            CH1game_1.Show()
            Me.Hide()
            picBack.BackgroundImage = My.Resources._3
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            page = 4
        ElseIf page = 4 Then
            picBack.BackgroundImage = My.Resources._4
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            page = 5
        ElseIf page = 5 Then
            picBack.BackgroundImage = My.Resources._5
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            page = 6

        ElseIf page = 6 Then
            picBack.BackgroundImage = My.Resources._6
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            btnAcc.Visible = True
            btnRef.Visible = True
            page = 7
        ElseIf page = 8 Then
            btnAcc.Visible = False
            btnRef.Visible = False
            picBack.BackgroundImage = My.Resources._9
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            page = 9
        ElseIf page = 9 Then
            btnAcc.Visible = False
            btnRef.Visible = False
            picBack.BackgroundImage = My.Resources._10
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            page = 10
        ElseIf page = 10 Then
            picBack.BackgroundImage = My.Resources._6
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            MsgBox("請重新選擇!")
            btnAcc.Visible = True
            btnRef.Visible = True
            page = 7
        ElseIf g2 = True Then
            CH1game_2.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub btnAcc_Click(sender As Object, e As EventArgs) Handles btnAcc.Click
        If page = 7 Then
            btnAcc.Visible = False
            btnRef.Visible = False
            picBack.BackgroundImage = My.Resources._7
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            g2 = True
        End If
    End Sub

    Private Sub btnRef_Click(sender As Object, e As EventArgs) Handles btnRef.Click
        If page = 7 Then
            btnAcc.Visible = False
            btnRef.Visible = False
            picBack.BackgroundImage = My.Resources._8
            picBack.BackgroundImageLayout = BackgroundImageLayout.Stretch
            page = 8
        End If
    End Sub
End Class