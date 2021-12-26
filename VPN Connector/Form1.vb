Imports System.Net
Imports System.IO
Imports System.Threading
Imports System.Management





Public Class Form1
    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cnct.Click
        If CheckForInternetConnection() = True Then
            Dim mazen As New Thread(AddressOf connect)
            Label3.Text = "Please Wait"
            Label2.Text = "connecting"
            mazen.Start()
            Timer2.Start()
        Else
            MessageBox.Show("Please check your Internet connection", "Erorr")
        End If
    End Sub

    Private Sub dcnct_Click(sender As Object, e As EventArgs) Handles dcnct.Click

        Dim killer As New Thread(AddressOf disconnect)
        killer.Start()
        Label3.Visible = False
        Label2.Visible = False
        Label3.Text = "Please Wait"
        WebBrowser1.Refresh()
        Timer3.Start()

    End Sub
    Sub disconnect()
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"), "rasdial/d")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Hidden

        connect.Start()
        connect.WaitForExit()
        cnct.Enabled = True
        dcnct.Enabled = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.yougetsignal.com/tools/open-ports/")

        Dim MOS_PR As New ManagementObjectSearcher("SELECT * FROM Win32_Processor")
        Dim mo_PR As ManagementBaseObject
        For Each mo_PR In MOS_PR.Get()
            ts.Text = mo_PR("ProcessorId").ToString().Replace("F", "SS1-")

        Next
        Dim web As New WebClient
        Dim sss As String = web.DownloadString("https://dl.dropboxusercontent.com/ your link")
        '  MsgBox("Created by MONSTERMC")

        'الأخبار
        TextBox11.Text = web.DownloadString("https://dl.dropboxusercontent.com/ your link")
        'اليوزر نيم
        usrname.Text = web.DownloadString("https://dl.dropboxusercontent.com/ your link")
        'الباسورد
        pswrd.Text = web.DownloadString("https://dl.dropboxusercontent.com/ your link")
        If Not sss.Contains(ts.Text) Then
            cnct.Enabled = False
            dcnct.Enabled = False
            MessageBox.Show("Please Active :( ", "!!!!!!!!!!!!")
        Else
            ts.Text = "ACTIVE :) "
        End If
    End Sub

    Private Sub DeimosButton1_Click(sender As Object, e As EventArgs) Handles DeimosButton1.Click

        Process.Start("https://www.facebook.com/OfficialInternationalHacker")
        Process.Start("https://www.youtube.com/channel/UCLF-eRNc52VslhdctpHaAzg/videos")
    End Sub

    Private Sub BlackShadesNetForm1_Click(sender As Object, e As EventArgs) Handles BlackShadesNetForm1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim CPU As Integer = CDec(PerformanceCounter1.NextValue.ToString())
        CPU = 100 - CPU
        Label1.Text = CPU.ToString() & "%"
        On Error Resume Next
        ProgressBar1.Value = CPU.ToString
    End Sub
    Sub connect()

        If Not IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector") Then
            IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector")
        End If
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk"), "[VPN]" & vbNewLine & "MEDIA=rastapi" & vbNewLine & "Port=VPN2-0" & vbNewLine & "Device=WAN Miniport (IKEv2)" & vbNewLine & "DEVICE=vpn" & vbNewLine & "PhoneNumber=" & host.Text)
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"), "rasdial ""VPN"" " & usrname.Text & " " & pswrd.Text & " /phonebook:" & """" & System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk" & """")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        connect.Start()
        connect.WaitForExit()
        cnct.Enabled = False
        dcnct.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        On Error Resume Next
        Dim myProcesses() As Process
        myProcesses = Process.GetProcessesByName("cmd")
        If myProcesses.Count > 0 Then
            Label2.Visible = True
            Label3.Visible = True
        Else
            Timer3.Stop()
            WebBrowser1.Refresh()
            If WebBrowser1.Document.GetElementById("remoteAddress").GetAttribute("value").ToString = Label4.Text Then
                ' MessageBox.Show("try Again :(")
                cnct.Enabled = True
                Label3.Text = "try Again :("
                Label2.Text = ""
                Timer2.Stop()
            Else
                Label2.Visible = False
                Label3.Text = "Connected :) "
                Label4.Text = WebBrowser1.Document.GetElementById("remoteAddress").GetAttribute("value").ToString
                Timer2.Stop()
        End If

        End If




    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try

            Label4.Text = WebBrowser1.Document.GetElementById("remoteAddress").GetAttribute("value").ToString

        Catch
        End Try
    End Sub



    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
