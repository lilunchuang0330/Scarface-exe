<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CH1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CH1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.btnAcc = New System.Windows.Forms.Button()
        Me.btnRef = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "3"
        Me.Label1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Scarface.My.Resources.Resources.leadingAnmi
        Me.PictureBox1.Location = New System.Drawing.Point(0, -3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1200, 725)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'picBack
        '
        Me.picBack.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBack.BackgroundImage = Global.Scarface.My.Resources.Resources._6
        Me.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBack.Location = New System.Drawing.Point(0, -3)
        Me.picBack.Margin = New System.Windows.Forms.Padding(2)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(1155, 674)
        Me.picBack.TabIndex = 2
        Me.picBack.TabStop = False
        Me.picBack.Visible = False
        '
        'btnAcc
        '
        Me.btnAcc.BackColor = System.Drawing.Color.DarkGray
        Me.btnAcc.Font = New System.Drawing.Font("微軟正黑體", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnAcc.ForeColor = System.Drawing.Color.Black
        Me.btnAcc.Location = New System.Drawing.Point(122, 338)
        Me.btnAcc.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAcc.Name = "btnAcc"
        Me.btnAcc.Size = New System.Drawing.Size(425, 79)
        Me.btnAcc.TabIndex = 3
        Me.btnAcc.Text = "接受任務"
        Me.btnAcc.UseVisualStyleBackColor = False
        '
        'btnRef
        '
        Me.btnRef.BackColor = System.Drawing.Color.DarkGray
        Me.btnRef.Font = New System.Drawing.Font("微軟正黑體", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnRef.ForeColor = System.Drawing.Color.Black
        Me.btnRef.Location = New System.Drawing.Point(601, 338)
        Me.btnRef.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(425, 79)
        Me.btnRef.TabIndex = 4
        Me.btnRef.Text = "拒絕任務"
        Me.btnRef.UseVisualStyleBackColor = False
        '
        'CH1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1155, 676)
        Me.Controls.Add(Me.btnAcc)
        Me.Controls.Add(Me.btnRef)
        Me.Controls.Add(Me.picBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "CH1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scarface"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picBack As PictureBox
    Friend WithEvents btnAcc As Button
    Friend WithEvents btnRef As Button
End Class
