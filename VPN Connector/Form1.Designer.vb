<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.BlackShadesNetForm1 = New VPN_Connector.BlackShadesNetForm()
        Me.DeimosButton1 = New VPN_Connector.DeimosButton()
        Me.DeimosTabControl1 = New VPN_Connector.DeimosTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.ts = New VPN_Connector.DeimosTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeimosLabel4 = New VPN_Connector.DeimosLabel()
        Me.dcnct = New VPN_Connector.DeimosButton()
        Me.cnct = New VPN_Connector.DeimosButton()
        Me.Password = New VPN_Connector.DeimosLabel()
        Me.Username = New VPN_Connector.DeimosLabel()
        Me.DeimosLabel2 = New VPN_Connector.DeimosLabel()
        Me.DeimosLabel1 = New VPN_Connector.DeimosLabel()
        Me.pswrd = New VPN_Connector.BlackShadesNetTextBox()
        Me.usrname = New VPN_Connector.BlackShadesNetTextBox()
        Me.host = New VPN_Connector.BlackShadesNetTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox11 = New VPN_Connector.BlackShadesNetRichTextBox()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BlackShadesNetForm1.SuspendLayout()
        Me.DeimosTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Thread"
        Me.PerformanceCounter1.CounterName = "% Processor Time"
        Me.PerformanceCounter1.InstanceName = "Idle/0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'BlackShadesNetForm1
        '
        Me.BlackShadesNetForm1.CloseButtonExitsApp = False
        Me.BlackShadesNetForm1.Controls.Add(Me.DeimosButton1)
        Me.BlackShadesNetForm1.Controls.Add(Me.DeimosTabControl1)
        Me.BlackShadesNetForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlackShadesNetForm1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BlackShadesNetForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.BlackShadesNetForm1.Location = New System.Drawing.Point(0, 0)
        Me.BlackShadesNetForm1.MinimizeButton = True
        Me.BlackShadesNetForm1.Name = "BlackShadesNetForm1"
        Me.BlackShadesNetForm1.Size = New System.Drawing.Size(321, 456)
        Me.BlackShadesNetForm1.TabIndex = 0
        Me.BlackShadesNetForm1.Text = "VPN CONNECTOR BY MONSTERMC"
        '
        'DeimosButton1
        '
        Me.DeimosButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.DeimosButton1.DrawRigid = False
        Me.DeimosButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeimosButton1.Location = New System.Drawing.Point(481, 3)
        Me.DeimosButton1.Name = "DeimosButton1"
        Me.DeimosButton1.Size = New System.Drawing.Size(25, 13)
        Me.DeimosButton1.TabIndex = 9
        Me.DeimosButton1.Text = "?"
        '
        'DeimosTabControl1
        '
        Me.DeimosTabControl1.BGColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DeimosTabControl1.Controls.Add(Me.TabPage1)
        Me.DeimosTabControl1.Controls.Add(Me.TabPage2)
        Me.DeimosTabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeimosTabControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.DeimosTabControl1.ItemSize = New System.Drawing.Size(0, 25)
        Me.DeimosTabControl1.Location = New System.Drawing.Point(3, 22)
        Me.DeimosTabControl1.Name = "DeimosTabControl1"
        Me.DeimosTabControl1.Padding = New System.Drawing.Point(13, 0)
        Me.DeimosTabControl1.SelectedIndex = 0
        Me.DeimosTabControl1.Size = New System.Drawing.Size(316, 429)
        Me.DeimosTabControl1.TabIndex = 2
        Me.DeimosTabControl1.TabRectOffset = 2
        Me.DeimosTabControl1.TabRectRoundness = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Controls.Add(Me.ts)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ProgressBar1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.DeimosLabel4)
        Me.TabPage1.Controls.Add(Me.dcnct)
        Me.TabPage1.Controls.Add(Me.cnct)
        Me.TabPage1.Controls.Add(Me.Password)
        Me.TabPage1.Controls.Add(Me.Username)
        Me.TabPage1.Controls.Add(Me.DeimosLabel2)
        Me.TabPage1.Controls.Add(Me.DeimosLabel1)
        Me.TabPage1.Controls.Add(Me.pswrd)
        Me.TabPage1.Controls.Add(Me.usrname)
        Me.TabPage1.Controls.Add(Me.host)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(308, 396)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "VPN 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 19)
        Me.Label4.TabIndex = 16
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(319, 86)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(170, 223)
        Me.WebBrowser1.TabIndex = 11
        Me.WebBrowser1.Visible = False
        '
        'ts
        '
        Me.ts.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ts.DrawRigid = False
        Me.ts.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.ts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.ts.IsMultiline = True
        Me.ts.Location = New System.Drawing.Point(11, 298)
        Me.ts.MaxCharacters = 30000
        Me.ts.Name = "ts"
        Me.ts.Size = New System.Drawing.Size(271, 28)
        Me.ts.TabIndex = 15
        Me.ts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ts.TextboxColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ts.TxtReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(163, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Please Wait"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(30, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "connecting ..."
        Me.Label2.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(114, 232)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(57, 13)
        Me.ProgressBar1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "0%"
        '
        'DeimosLabel4
        '
        Me.DeimosLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.DeimosLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeimosLabel4.Location = New System.Drawing.Point(114, 215)
        Me.DeimosLabel4.Name = "DeimosLabel4"
        Me.DeimosLabel4.Size = New System.Drawing.Size(39, 12)
        Me.DeimosLabel4.TabIndex = 10
        Me.DeimosLabel4.Text = "CPU"
        '
        'dcnct
        '
        Me.dcnct.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.dcnct.DrawRigid = False
        Me.dcnct.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dcnct.Location = New System.Drawing.Point(184, 215)
        Me.dcnct.Name = "dcnct"
        Me.dcnct.Size = New System.Drawing.Size(98, 35)
        Me.dcnct.TabIndex = 8
        Me.dcnct.Text = "Disconnect"
        '
        'cnct
        '
        Me.cnct.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.cnct.DrawRigid = False
        Me.cnct.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cnct.Location = New System.Drawing.Point(2, 213)
        Me.cnct.Name = "cnct"
        Me.cnct.Size = New System.Drawing.Size(98, 35)
        Me.cnct.TabIndex = 7
        Me.cnct.Text = "Connect"
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Password.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Password.Location = New System.Drawing.Point(2, 153)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(73, 15)
        Me.Password.TabIndex = 6
        Me.Password.Text = "Password"
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Username.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Username.Location = New System.Drawing.Point(2, 86)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(82, 15)
        Me.Username.TabIndex = 5
        Me.Username.Text = "Username:"
        '
        'DeimosLabel2
        '
        Me.DeimosLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.DeimosLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeimosLabel2.Location = New System.Drawing.Point(63, 6)
        Me.DeimosLabel2.Name = "DeimosLabel2"
        Me.DeimosLabel2.Size = New System.Drawing.Size(173, 14)
        Me.DeimosLabel2.TabIndex = 4
        Me.DeimosLabel2.Text = "PPTP VPN CONNECTOR"
        '
        'DeimosLabel1
        '
        Me.DeimosLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.DeimosLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DeimosLabel1.Location = New System.Drawing.Point(2, 25)
        Me.DeimosLabel1.Name = "DeimosLabel1"
        Me.DeimosLabel1.Size = New System.Drawing.Size(61, 15)
        Me.DeimosLabel1.TabIndex = 3
        Me.DeimosLabel1.Text = "Host:"
        '
        'pswrd
        '
        Me.pswrd.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pswrd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.pswrd.Location = New System.Drawing.Point(4, 171)
        Me.pswrd.MaxLength = 32767
        Me.pswrd.Name = "pswrd"
        Me.pswrd.Size = New System.Drawing.Size(276, 29)
        Me.pswrd.TabIndex = 2
        Me.pswrd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.pswrd.UseSystemPasswordChar = False
        Me.pswrd.Visible = False
        '
        'usrname
        '
        Me.usrname.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.usrname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.usrname.Location = New System.Drawing.Point(4, 107)
        Me.usrname.MaxLength = 32767
        Me.usrname.Name = "usrname"
        Me.usrname.Size = New System.Drawing.Size(276, 29)
        Me.usrname.TabIndex = 1
        Me.usrname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.usrname.UseSystemPasswordChar = False
        Me.usrname.Visible = False
        '
        'host
        '
        Me.host.AllowDrop = True
        Me.host.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.host.Enabled = False
        Me.host.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.host.Location = New System.Drawing.Point(4, 46)
        Me.host.MaxLength = 32767
        Me.host.Name = "host"
        Me.host.Size = New System.Drawing.Size(276, 29)
        Me.host.TabIndex = 0
        Me.host.Text = "pptp.ipjetable.net"
        Me.host.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.host.UseSystemPasswordChar = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.TextBox11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(308, 396)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "INFO"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.TextBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TextBox11.Location = New System.Drawing.Point(3, 3)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(302, 390)
        Me.TextBox11.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 456)
        Me.Controls.Add(Me.BlackShadesNetForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "VPN CONNECTOR BY MONSTERMC"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BlackShadesNetForm1.ResumeLayout(False)
        Me.DeimosTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BlackShadesNetForm1 As VPN_Connector.BlackShadesNetForm
    Friend WithEvents DeimosTabControl1 As VPN_Connector.DeimosTabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Password As VPN_Connector.DeimosLabel
    Friend WithEvents Username As VPN_Connector.DeimosLabel
    Friend WithEvents DeimosLabel2 As VPN_Connector.DeimosLabel
    Friend WithEvents DeimosLabel1 As VPN_Connector.DeimosLabel
    Friend WithEvents pswrd As VPN_Connector.BlackShadesNetTextBox
    Friend WithEvents usrname As VPN_Connector.BlackShadesNetTextBox
    Friend WithEvents host As VPN_Connector.BlackShadesNetTextBox
    Friend WithEvents dcnct As VPN_Connector.DeimosButton
    Friend WithEvents cnct As VPN_Connector.DeimosButton
    Friend WithEvents TextBox11 As VPN_Connector.BlackShadesNetRichTextBox
    Friend WithEvents DeimosButton1 As VPN_Connector.DeimosButton
    Friend WithEvents DeimosLabel4 As VPN_Connector.DeimosLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PerformanceCounter1 As System.Diagnostics.PerformanceCounter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ts As VPN_Connector.DeimosTextbox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
