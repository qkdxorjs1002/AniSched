Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''''''''''''''''''''''''''''
        '''''''''''Initial'''''''''''
        '''''''''''''''''''''''''''''

        '사용자설정 불러오기
        BlinkToolStripMenuItem.Checked = My.Settings.form_blink
        최소화ToolStripMenuItem.Checked = My.Settings.keep_tray
        Me.TopMost = My.Settings.form_front

        '폼 투명도 적용
        'If 0.0 < ToolStripTextBox1.Text <= 1.0 Then
        '   Me.Opacity = My.Settings.form_opacity
        'Else
        '   Me.Opacity = 1.0
        'End If

        '사용자설정 반영
        If 최소화ToolStripMenuItem.Checked = True Then
            Timer3.Enabled = True
        End If
        If BlinkToolStripMenuItem.Checked = True Then
            Timer5.Enabled = True
        End If

        '시작시 요일 확인
        If Today.DayOfWeek = DayOfWeek.Sunday Then
            Label1.Visible = True
        ElseIf Today.DayOfWeek = DayOfWeek.Monday Then
            Label2.Visible = True
        ElseIf Today.DayOfWeek = DayOfWeek.Tuesday Then
            Label3.Visible = True
        ElseIf Today.DayOfWeek = DayOfWeek.Wednesday Then
            Label4.Visible = True
        ElseIf Today.DayOfWeek = DayOfWeek.Thursday Then
            Label5.Visible = True
        ElseIf Today.DayOfWeek = DayOfWeek.Friday Then
            Label6.Visible = True
        ElseIf Today.DayOfWeek = DayOfWeek.Saturday Then
            Label7.Visible = True
        End If

        '시작시 편성표 로드
        WebBrowser1.DocumentText = _
        "<html><body>" & _
        "<div id=if style='position:absolute;left:0px;top:-28px'><script src='http://widgetprovider.daum.net/view?url=http://widgetcfs1.daum.net/xml/20/widget/2009/10/15/02/50/4ad60f4c5197a_579.xml&up_docBg=%23FFFFFF&up_docLine=%23EEEEEE&up_docSelBg=%23EEEEEE&up_docSelTx=%23495F90&up_docTx=%23333333&up_mdTx=%23EEEEEE&up_mdSelBg=%23555555&up_mdSelTx=%23FFFFFF&up_mdBg=%23f766a7&&width=304&height=385&widgetId=625&scrap=1' type='text/javascript'></script>" & _
        "</body></html>"

        Dim pid As Integer = Process.GetCurrentProcess.Id
        AppActivate(pid)
        If My.Settings.form_front = False Then
            Me.TopLevel = True
        End If
    End Sub

    Private Sub 정보ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 정보ToolStripMenuItem.Click
        MessageBox.Show("ⓒ2014 Novang. page from anissia", "정보")        '프로그램 정보
    End Sub

    Private Sub 알림ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 알림ToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Timer4.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Today.DayOfWeek = DayOfWeek.Sunday Then      '1분 간격 요일 새로고침
            Label1.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
        ElseIf Today.DayOfWeek = DayOfWeek.Monday Then
            Label2.Visible = True
            Label1.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
        ElseIf Today.DayOfWeek = DayOfWeek.Tuesday Then
            Label3.Visible = True
            Label2.Visible = False
            Label1.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
        ElseIf Today.DayOfWeek = DayOfWeek.Wednesday Then
            Label4.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label1.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
        ElseIf Today.DayOfWeek = DayOfWeek.Thursday Then
            Label5.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label1.Visible = False
            Label6.Visible = False
            Label7.Visible = False
        ElseIf Today.DayOfWeek = DayOfWeek.Friday Then
            Label6.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label1.Visible = False
            Label7.Visible = False
        ElseIf Today.DayOfWeek = DayOfWeek.Saturday Then
            Label7.Visible = True
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label1.Visible = False
        End If
    End Sub

    Private Sub 닫기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 닫기ToolStripMenuItem.Click
        BlinkToolStripMenuItem.Checked = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity < 0.1 Then
            'My.Settings.form_opacity = Me.Opacity
            My.Settings.form_blink = BlinkToolStripMenuItem.Checked
            My.Settings.keep_tray = 최소화ToolStripMenuItem.Checked
            My.Settings.form_front = Me.TopMost
            My.Settings.Save()
            Form3.Close()
            Me.Close()
        End If
    End Sub

    Private Sub 끝내기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 끝내기ToolStripMenuItem.Click
        'My.Settings.form_opacity = Me.Opacity
        My.Settings.form_blink = BlinkToolStripMenuItem.Checked
        My.Settings.keep_tray = 최소화ToolStripMenuItem.Checked
        My.Settings.form_front = Me.TopMost
        My.Settings.Save()
        Form3.Close()
        Me.Close()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity < 0.1 Then
            Me.Hide() '폼숨김
            NotifyIcon1.Visible = True    '트레이보이기
            NotifyIcon1.ShowBalloonTip(5000)
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Me.Opacity = Me.Opacity + 0.1
        If Me.Opacity > 0.9 Then
            Me.Show() '폼보이기
            NotifyIcon1.Visible = False    '트레이숨기기
            Timer4.Enabled = False
            최소화ToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub BlinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlinkToolStripMenuItem.Click
        If BlinkToolStripMenuItem.Checked = True Then
            Timer5.Enabled = True
        Else
            Timer5.Enabled = False
            Timer6.Enabled = False
            Me.Opacity = 1.0
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity = 0.0 Then
            Timer5.Enabled = False
            Timer6.Enabled = True
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Me.Opacity = Me.Opacity + 0.1
        If Me.Opacity = 1.0 Then
            Timer6.Enabled = False
            Timer5.Enabled = True
        End If
    End Sub

    Private Sub AlertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlertToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.alert, AudioPlayMode.Background)
    End Sub

    Private Sub 최소화ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 최소화ToolStripMenuItem.Click
        If 최소화ToolStripMenuItem.Checked = True Then
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub 적용ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 적용ToolStripMenuItem.Click
        If 0.0 <= ToolStripTextBox1.Text <= 1.0 Then
            Me.Opacity = ToolStripTextBox1.Text
        End If
    End Sub

    Private Sub 맨앞에위치ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 맨앞에위치ToolStripMenuItem.Click
        If 맨앞에위치ToolStripMenuItem.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub
End Class
