Imports System.ComponentModel

Public Class Form1
    Private Function a() As Boolean
        ' Get our process name.
        Dim my_proc As Process = Process.GetCurrentProcess
        Dim my_name As String = my_proc.ProcessName

        ' Get information about processes with this name.
        Dim procs() As Process =
        Process.GetProcessesByName(my_name)

        ' If there is only one, it's us.
        If procs.Length = 1 Then Return False

        ' If there is more than one process,
        ' see if one has a StartTime before ours.
        Dim i As Integer
        For i = 0 To procs.Length - 1
            If procs(i).StartTime < my_proc.StartTime Then _
            Return True
        Next i

        ' If we get here, we were first.
        Return False
    End Function

    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("..\Release\alarm.wav")
    End Sub
    'Sub nhackhoidong()
    '    My.Computer.Audio.Play("..\Debug\timeol.wav", AudioPlayMode.WaitToComplete)
    'End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim comapre As String = "6:00:00 AM" ' bat dau ca 1
            Dim comapre1 As String = "10:30:00 AM" ' bat dau an com ca hc
            Dim compare2 As String = "11:00:00 AM" ' bat dau an com ca 1
            Dim compare9 As String = "11:30:00 AM" ' bat dau an com ca 1
            Dim compare3 As String = "12:00:00 AM" ' bat dau an com ca HC
            Dim compare4 As String = "2:00:00 PM" ' bat dau ca 2
            Dim compare5 As String = "5:30:00 PM" ' Ket thuc ca 1
            Dim compare6 As String = "6:00:00 PM" ' Ket thuc hanh chinh
            Dim compare7 As String = "6:30:00 PM" ' An com ca 2
            Dim compare8 As String = "10:00:00 PM" ' Ket thuc ca 2

            If comapre = DateTime.Now.ToString("h:mm:ss tt") Then
                PlayBackgroundSoundFile()
            End If
            If comapre1 = DateTime.Now.ToString("h:mm:ss tt") Then
                PlayBackgroundSoundFile()
            End If
            If compare2 = DateTime.Now.ToString("h:mm:ss tt") Then
                PlayBackgroundSoundFile()
            End If
            If compare9 = DateTime.Now.ToString("h:mm:ss tt") Then
                PlayBackgroundSoundFile()
            End If
            If compare3 = DateTime.Now.ToString("h:mm:ss tt") Then
                PlayBackgroundSoundFile()
            End If
            If compare4 = DateTime.Now.ToString("h:mm:ss tt") Then
                PlayBackgroundSoundFile()
            End If
            If compare5 = DateTime.Now.ToString("h:mm:ss tt") Then
                PlayBackgroundSoundFile()
            End If
            If compare6 = DateTime.Now.ToString("h:mm:ss tt") Then
                PlayBackgroundSoundFile()
            End If
            If compare7 = DateTime.Now.ToString("h:mm:ss tt") Then
                PlayBackgroundSoundFile()
            End If
            If compare8 = DateTime.Now.ToString("h:mm:ss tt") Then
                PlayBackgroundSoundFile()
            End If

            Label2.Text = Format(Today)
            Label3.Text = Format(Now, "hh:mm:ss.fff tt")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        'Label2.Text = TimeOfDay.ToString("h:mm:ss:ff tt")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If a() Then
            MessageBox.Show(
                "Ứng dụng đã được bật",
                "Ứng dụng đang chạy",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            Me.Close()
        End If
        'nhackhoidong()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://newsystemvietnam.com")
    End Sub



    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim d As DialogResult

        d = MsgBox("Bạn thực sự muốn thoát", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Thông báo")
        If d = Windows.Forms.DialogResult.Yes Then
            Application.ExitThread()
        Else
            e.Cancel = True
        End If
    End Sub



    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Minimized Then
            ShowInTaskbar = False
            NotifyIcon1.Visible = True
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            NotifyIcon1.BalloonTipText = "Chương trình sẽ chạy ẩn tại đây, để mở lại nhấn đúp chuột vào biểu tượng"
            NotifyIcon1.BalloonTipTitle = "Chuông báo ca"
            NotifyIcon1.ShowBalloonTip(50000)

        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        ShowInTaskbar = True
        NotifyIcon1.Visible = False
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
        Try
            Process.Start("https://newsystemvietnam.com")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
