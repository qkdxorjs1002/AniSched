<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.끝내기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.속성ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.정보ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.편집ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.투명도ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.적용ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.알림ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TESTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.최소화ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.닫기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.맨앞에위치ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 24)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(304, 357)
        Me.WebBrowser1.TabIndex = 12
        Me.WebBrowser1.TabStop = False
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(251, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "일요일"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "월요일"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "화요일"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "수요일"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "목요일"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(251, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "금요일"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(251, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "토요일"
        Me.Label7.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "아이콘을 클릭하여 열기"
        Me.NotifyIcon1.BalloonTipTitle = "여기에 있어요!"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "애니편성표"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.끝내기ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(111, 26)
        '
        '끝내기ToolStripMenuItem
        '
        Me.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem"
        Me.끝내기ToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.끝내기ToolStripMenuItem.Text = "끝내기"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Timer4
        '
        Me.Timer4.Interval = 10
        '
        'Timer5
        '
        Me.Timer5.Interval = 10
        '
        'Timer6
        '
        Me.Timer6.Interval = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.속성ToolStripMenuItem, Me.편집ToolStripMenuItem, Me.최소화ToolStripMenuItem, Me.닫기ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(304, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '속성ToolStripMenuItem
        '
        Me.속성ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.정보ToolStripMenuItem})
        Me.속성ToolStripMenuItem.Name = "속성ToolStripMenuItem"
        Me.속성ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.속성ToolStripMenuItem.Text = "속성"
        '
        '정보ToolStripMenuItem
        '
        Me.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem"
        Me.정보ToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.정보ToolStripMenuItem.Text = "정보"
        '
        '편집ToolStripMenuItem
        '
        Me.편집ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.투명도ToolStripMenuItem, Me.알림ToolStripMenuItem, Me.TESTToolStripMenuItem, Me.맨앞에위치ToolStripMenuItem})
        Me.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem"
        Me.편집ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.편집ToolStripMenuItem.Text = "편집"
        '
        '투명도ToolStripMenuItem
        '
        Me.투명도ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.적용ToolStripMenuItem})
        Me.투명도ToolStripMenuItem.Name = "투명도ToolStripMenuItem"
        Me.투명도ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.투명도ToolStripMenuItem.Text = "투명도"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "0.0 ~ 1.0"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '적용ToolStripMenuItem
        '
        Me.적용ToolStripMenuItem.Name = "적용ToolStripMenuItem"
        Me.적용ToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.적용ToolStripMenuItem.Text = "적용"
        '
        '알림ToolStripMenuItem
        '
        Me.알림ToolStripMenuItem.Name = "알림ToolStripMenuItem"
        Me.알림ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.알림ToolStripMenuItem.Text = "알림"
        '
        'TESTToolStripMenuItem
        '
        Me.TESTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlertToolStripMenuItem, Me.BlinkToolStripMenuItem})
        Me.TESTToolStripMenuItem.Name = "TESTToolStripMenuItem"
        Me.TESTToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TESTToolStripMenuItem.Text = "TEST"
        '
        'AlertToolStripMenuItem
        '
        Me.AlertToolStripMenuItem.Name = "AlertToolStripMenuItem"
        Me.AlertToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.AlertToolStripMenuItem.Text = "Alert"
        '
        'BlinkToolStripMenuItem
        '
        Me.BlinkToolStripMenuItem.CheckOnClick = True
        Me.BlinkToolStripMenuItem.Name = "BlinkToolStripMenuItem"
        Me.BlinkToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.BlinkToolStripMenuItem.Text = "Blink"
        '
        '최소화ToolStripMenuItem
        '
        Me.최소화ToolStripMenuItem.CheckOnClick = True
        Me.최소화ToolStripMenuItem.Name = "최소화ToolStripMenuItem"
        Me.최소화ToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.최소화ToolStripMenuItem.Text = "최소화"
        '
        '닫기ToolStripMenuItem
        '
        Me.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem"
        Me.닫기ToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.닫기ToolStripMenuItem.Text = "닫기"
        '
        '맨앞에위치ToolStripMenuItem
        '
        Me.맨앞에위치ToolStripMenuItem.CheckOnClick = True
        Me.맨앞에위치ToolStripMenuItem.Name = "맨앞에위치ToolStripMenuItem"
        Me.맨앞에위치ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.맨앞에위치ToolStripMenuItem.Text = "맨앞에 위치"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(304, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "애니편성표"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 끝내기ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 속성ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 정보ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 편집ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 투명도ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 알림ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TESTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 최소화ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 닫기ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents 적용ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 맨앞에위치ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
