Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        Label10.Text = 0.4
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Timer2.Interval = 2000 Then
            Timer2.Interval = 10
        End If
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity < 0.1 Then
            Timer2.Enabled = False
            Form1.Show()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.MouseDoubleClick
        Timer2.Enabled = False
        Dim reset_title As String = "경고"
        Dim reset_message As String = "설정을 초기화 하시겠습니까?"
        Dim reset = MessageBox.Show(reset_message, reset_title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (reset = Windows.Forms.DialogResult.Yes) Then
            My.Settings.Reset()
            Timer2.Enabled = True
        Else
            Timer2.Enabled = True
        End If
    End Sub
End Class