<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        Me.ZebraIPTxt = New System.Windows.Forms.TextBox()
        Me.ConnectBtn = New System.Windows.Forms.Button()
        Me.DisconnectBtn = New System.Windows.Forms.Button()
        Me.ConsoleRTB = New System.Windows.Forms.RichTextBox()
        Me.FS40ResultRTB = New System.Windows.Forms.RichTextBox()
        Me.FS40AsciiRTB = New System.Windows.Forms.RichTextBox()
        Me.FS40ControlRTB = New System.Windows.Forms.RichTextBox()
        Me.ClearOutputsBtn = New System.Windows.Forms.Button()
        Me.CleanupBtn = New System.Windows.Forms.Button()
        Me.DequeueBtn = New System.Windows.Forms.Button()
        Me.ReceiveTmr = New System.Windows.Forms.Timer(Me.components)
        Me.TriggerBtn = New System.Windows.Forms.Button()
        Me.AsciiSendBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AsciiCommandTxt = New System.Windows.Forms.TextBox()
        Me.ViewerPictureBox = New System.Windows.Forms.PictureBox()
        Me.ResultCountLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.SendGetResultImageBtn = New System.Windows.Forms.Button()
        Me.SendGetImageBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SendMatchstringBtn = New System.Windows.Forms.Button()
        Me.SendAnyBtn = New System.Windows.Forms.Button()
        Me.MatchstringTxt = New System.Windows.Forms.TextBox()
        Me.SoftwareVersionLbl = New System.Windows.Forms.Label()
        CType(Me.ViewerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ZebraIPTxt
        '
        Me.ZebraIPTxt.Location = New System.Drawing.Point(761, 593)
        Me.ZebraIPTxt.Name = "ZebraIPTxt"
        Me.ZebraIPTxt.Size = New System.Drawing.Size(100, 23)
        Me.ZebraIPTxt.TabIndex = 0
        Me.ZebraIPTxt.Text = "192.168.0.41"
        '
        'ConnectBtn
        '
        Me.ConnectBtn.Location = New System.Drawing.Point(680, 569)
        Me.ConnectBtn.Name = "ConnectBtn"
        Me.ConnectBtn.Size = New System.Drawing.Size(75, 68)
        Me.ConnectBtn.TabIndex = 1
        Me.ConnectBtn.Text = "Connect"
        Me.ConnectBtn.UseVisualStyleBackColor = True
        '
        'DisconnectBtn
        '
        Me.DisconnectBtn.Location = New System.Drawing.Point(867, 569)
        Me.DisconnectBtn.Name = "DisconnectBtn"
        Me.DisconnectBtn.Size = New System.Drawing.Size(75, 68)
        Me.DisconnectBtn.TabIndex = 2
        Me.DisconnectBtn.Text = "Disconnect"
        Me.DisconnectBtn.UseVisualStyleBackColor = True
        '
        'ConsoleRTB
        '
        Me.ConsoleRTB.Location = New System.Drawing.Point(12, 718)
        Me.ConsoleRTB.Name = "ConsoleRTB"
        Me.ConsoleRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.ConsoleRTB.Size = New System.Drawing.Size(1357, 219)
        Me.ConsoleRTB.TabIndex = 3
        Me.ConsoleRTB.Text = ""
        '
        'FS40ResultRTB
        '
        Me.FS40ResultRTB.Location = New System.Drawing.Point(134, 532)
        Me.FS40ResultRTB.MaxLength = 1000000
        Me.FS40ResultRTB.Name = "FS40ResultRTB"
        Me.FS40ResultRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.FS40ResultRTB.Size = New System.Drawing.Size(540, 180)
        Me.FS40ResultRTB.TabIndex = 4
        Me.FS40ResultRTB.Text = ""
        '
        'FS40AsciiRTB
        '
        Me.FS40AsciiRTB.Location = New System.Drawing.Point(134, 306)
        Me.FS40AsciiRTB.MaxLength = 1000000
        Me.FS40AsciiRTB.Name = "FS40AsciiRTB"
        Me.FS40AsciiRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.FS40AsciiRTB.Size = New System.Drawing.Size(540, 220)
        Me.FS40AsciiRTB.TabIndex = 5
        Me.FS40AsciiRTB.Text = ""
        '
        'FS40ControlRTB
        '
        Me.FS40ControlRTB.Location = New System.Drawing.Point(134, 143)
        Me.FS40ControlRTB.MaxLength = 1000000
        Me.FS40ControlRTB.Name = "FS40ControlRTB"
        Me.FS40ControlRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.FS40ControlRTB.Size = New System.Drawing.Size(540, 134)
        Me.FS40ControlRTB.TabIndex = 6
        Me.FS40ControlRTB.Text = ""
        '
        'ClearOutputsBtn
        '
        Me.ClearOutputsBtn.Location = New System.Drawing.Point(12, 644)
        Me.ClearOutputsBtn.Name = "ClearOutputsBtn"
        Me.ClearOutputsBtn.Size = New System.Drawing.Size(116, 68)
        Me.ClearOutputsBtn.TabIndex = 7
        Me.ClearOutputsBtn.Text = "Clear Output Windows"
        Me.ClearOutputsBtn.UseVisualStyleBackColor = True
        '
        'CleanupBtn
        '
        Me.CleanupBtn.Location = New System.Drawing.Point(1213, 569)
        Me.CleanupBtn.Name = "CleanupBtn"
        Me.CleanupBtn.Size = New System.Drawing.Size(75, 68)
        Me.CleanupBtn.TabIndex = 8
        Me.CleanupBtn.Text = "Cleanup"
        Me.CleanupBtn.UseVisualStyleBackColor = True
        '
        'DequeueBtn
        '
        Me.DequeueBtn.Location = New System.Drawing.Point(1294, 569)
        Me.DequeueBtn.Name = "DequeueBtn"
        Me.DequeueBtn.Size = New System.Drawing.Size(75, 68)
        Me.DequeueBtn.TabIndex = 9
        Me.DequeueBtn.Text = "Dequeue"
        Me.DequeueBtn.UseVisualStyleBackColor = True
        '
        'ReceiveTmr
        '
        '
        'TriggerBtn
        '
        Me.TriggerBtn.Location = New System.Drawing.Point(6, 193)
        Me.TriggerBtn.Name = "TriggerBtn"
        Me.TriggerBtn.Size = New System.Drawing.Size(122, 27)
        Me.TriggerBtn.TabIndex = 10
        Me.TriggerBtn.Text = "Send TRIGGER"
        Me.TriggerBtn.UseVisualStyleBackColor = True
        '
        'AsciiSendBtn
        '
        Me.AsciiSendBtn.Location = New System.Drawing.Point(6, 334)
        Me.AsciiSendBtn.Name = "AsciiSendBtn"
        Me.AsciiSendBtn.Size = New System.Drawing.Size(122, 23)
        Me.AsciiSendBtn.TabIndex = 11
        Me.AsciiSendBtn.Text = "Send Text Below"
        Me.AsciiSendBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 49)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Control" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Port 107"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(6, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 52)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ASCII" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Port 23"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(6, 532)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 47)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Result" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Port 25250"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AsciiCommandTxt
        '
        Me.AsciiCommandTxt.Location = New System.Drawing.Point(6, 480)
        Me.AsciiCommandTxt.Name = "AsciiCommandTxt"
        Me.AsciiCommandTxt.Size = New System.Drawing.Size(122, 23)
        Me.AsciiCommandTxt.TabIndex = 15
        Me.AsciiCommandTxt.Text = "trigger"
        '
        'ViewerPictureBox
        '
        Me.ViewerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ViewerPictureBox.Location = New System.Drawing.Point(680, 143)
        Me.ViewerPictureBox.Name = "ViewerPictureBox"
        Me.ViewerPictureBox.Size = New System.Drawing.Size(689, 420)
        Me.ViewerPictureBox.TabIndex = 16
        Me.ViewerPictureBox.TabStop = False
        '
        'ResultCountLbl
        '
        Me.ResultCountLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ResultCountLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultCountLbl.Location = New System.Drawing.Point(38, 615)
        Me.ResultCountLbl.Name = "ResultCountLbl"
        Me.ResultCountLbl.Size = New System.Drawing.Size(63, 23)
        Me.ResultCountLbl.TabIndex = 17
        Me.ResultCountLbl.Text = "0"
        Me.ResultCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 579)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 36)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Result Count"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImage = CType(resources.GetObject("LogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(447, 125)
        Me.LogoPictureBox.TabIndex = 19
        Me.LogoPictureBox.TabStop = False
        '
        'SendGetResultImageBtn
        '
        Me.SendGetResultImageBtn.Location = New System.Drawing.Point(6, 363)
        Me.SendGetResultImageBtn.Name = "SendGetResultImageBtn"
        Me.SendGetResultImageBtn.Size = New System.Drawing.Size(122, 43)
        Me.SendGetResultImageBtn.TabIndex = 20
        Me.SendGetResultImageBtn.Text = "Send getresultimage"
        Me.SendGetResultImageBtn.UseVisualStyleBackColor = True
        '
        'SendGetImageBtn
        '
        Me.SendGetImageBtn.Location = New System.Drawing.Point(6, 406)
        Me.SendGetImageBtn.Name = "SendGetImageBtn"
        Me.SendGetImageBtn.Size = New System.Drawing.Size(122, 31)
        Me.SendGetImageBtn.TabIndex = 21
        Me.SendGetImageBtn.Text = "Send getimage"
        Me.SendGetImageBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(465, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(499, 65)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Zebra FS40 Camera Demo and Test Interface" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for VisualBasic .NET"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SendMatchstringBtn
        '
        Me.SendMatchstringBtn.Location = New System.Drawing.Point(6, 224)
        Me.SendMatchstringBtn.Name = "SendMatchstringBtn"
        Me.SendMatchstringBtn.Size = New System.Drawing.Size(122, 29)
        Me.SendMatchstringBtn.TabIndex = 23
        Me.SendMatchstringBtn.Text = "Set Matchstring"
        Me.SendMatchstringBtn.UseVisualStyleBackColor = True
        '
        'SendAnyBtn
        '
        Me.SendAnyBtn.Location = New System.Drawing.Point(6, 451)
        Me.SendAnyBtn.Name = "SendAnyBtn"
        Me.SendAnyBtn.Size = New System.Drawing.Size(122, 29)
        Me.SendAnyBtn.TabIndex = 24
        Me.SendAnyBtn.Text = "Send Below"
        Me.SendAnyBtn.UseVisualStyleBackColor = True
        '
        'MatchstringTxt
        '
        Me.MatchstringTxt.Location = New System.Drawing.Point(6, 254)
        Me.MatchstringTxt.Name = "MatchstringTxt"
        Me.MatchstringTxt.Size = New System.Drawing.Size(122, 23)
        Me.MatchstringTxt.TabIndex = 25
        Me.MatchstringTxt.Text = "024000013983"
        '
        'SoftwareVersionLbl
        '
        Me.SoftwareVersionLbl.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SoftwareVersionLbl.Location = New System.Drawing.Point(463, 68)
        Me.SoftwareVersionLbl.Name = "SoftwareVersionLbl"
        Me.SoftwareVersionLbl.Size = New System.Drawing.Size(499, 41)
        Me.SoftwareVersionLbl.TabIndex = 26
        Me.SoftwareVersionLbl.Text = "<softwareVersion>"
        Me.SoftwareVersionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 947)
        Me.Controls.Add(Me.SoftwareVersionLbl)
        Me.Controls.Add(Me.MatchstringTxt)
        Me.Controls.Add(Me.SendAnyBtn)
        Me.Controls.Add(Me.SendMatchstringBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SendGetImageBtn)
        Me.Controls.Add(Me.SendGetResultImageBtn)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ResultCountLbl)
        Me.Controls.Add(Me.ViewerPictureBox)
        Me.Controls.Add(Me.AsciiCommandTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AsciiSendBtn)
        Me.Controls.Add(Me.TriggerBtn)
        Me.Controls.Add(Me.DequeueBtn)
        Me.Controls.Add(Me.CleanupBtn)
        Me.Controls.Add(Me.ClearOutputsBtn)
        Me.Controls.Add(Me.FS40ControlRTB)
        Me.Controls.Add(Me.FS40AsciiRTB)
        Me.Controls.Add(Me.FS40ResultRTB)
        Me.Controls.Add(Me.ConsoleRTB)
        Me.Controls.Add(Me.DisconnectBtn)
        Me.Controls.Add(Me.ConnectBtn)
        Me.Controls.Add(Me.ZebraIPTxt)
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.ViewerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ZebraIPTxt As TextBox
    Friend WithEvents ConnectBtn As Button
    Friend WithEvents DisconnectBtn As Button
    Friend WithEvents ConsoleRTB As RichTextBox
    Friend WithEvents FS40ResultRTB As RichTextBox
    Friend WithEvents FS40AsciiRTB As RichTextBox
    Friend WithEvents FS40ControlRTB As RichTextBox
    Friend WithEvents ClearOutputsBtn As Button
    Friend WithEvents CleanupBtn As Button
    Friend WithEvents DequeueBtn As Button
    Friend WithEvents ReceiveTmr As Timer
    Friend WithEvents TriggerBtn As Button
    Friend WithEvents AsciiSendBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AsciiCommandTxt As TextBox
    Friend WithEvents ViewerPictureBox As PictureBox
    Friend WithEvents ResultCountLbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents SendGetResultImageBtn As Button
    Friend WithEvents SendGetImageBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents SendMatchstringBtn As Button
    Friend WithEvents SendAnyBtn As Button
    Friend WithEvents MatchstringTxt As TextBox
    Friend WithEvents SoftwareVersionLbl As Label
End Class
