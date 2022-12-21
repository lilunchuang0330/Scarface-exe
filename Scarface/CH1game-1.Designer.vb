<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CH1game_1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnG1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnG1
        '
        Me.btnG1.Location = New System.Drawing.Point(258, 178)
        Me.btnG1.Name = "btnG1"
        Me.btnG1.Size = New System.Drawing.Size(212, 126)
        Me.btnG1.TabIndex = 0
        Me.btnG1.Text = "go back CH1"
        Me.btnG1.UseVisualStyleBackColor = True
        '
        'CH1game_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnG1)
        Me.Name = "CH1game_1"
        Me.Text = "CH1game_1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnG1 As Button
End Class
