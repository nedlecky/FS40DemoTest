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
        Me.SuspendLayout()
        '
        'ZebraIPTxt
        '
        Me.ZebraIPTxt.Location = New System.Drawing.Point(122, 39)
        Me.ZebraIPTxt.Name = "ZebraIPTxt"
        Me.ZebraIPTxt.Size = New System.Drawing.Size(100, 23)
        Me.ZebraIPTxt.TabIndex = 0
        Me.ZebraIPTxt.Text = "192.168.0.41"
        '
        'ConnectBtn
        '
        Me.ConnectBtn.Location = New System.Drawing.Point(32, 38)
        Me.ConnectBtn.Name = "ConnectBtn"
        Me.ConnectBtn.Size = New System.Drawing.Size(75, 23)
        Me.ConnectBtn.TabIndex = 1
        Me.ConnectBtn.Text = "Connect"
        Me.ConnectBtn.UseVisualStyleBackColor = True
        '
        'DisconnectBtn
        '
        Me.DisconnectBtn.Location = New System.Drawing.Point(32, 67)
        Me.DisconnectBtn.Name = "DisconnectBtn"
        Me.DisconnectBtn.Size = New System.Drawing.Size(75, 23)
        Me.DisconnectBtn.TabIndex = 2
        Me.DisconnectBtn.Text = "Disconnect"
        Me.DisconnectBtn.UseVisualStyleBackColor = True
        '
        'ConsoleRTB
        '
        Me.ConsoleRTB.Location = New System.Drawing.Point(12, 684)
        Me.ConsoleRTB.Name = "ConsoleRTB"
        Me.ConsoleRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.ConsoleRTB.Size = New System.Drawing.Size(1357, 199)
        Me.ConsoleRTB.TabIndex = 3
        Me.ConsoleRTB.Text = ""
        '
        'FS40ResultRTB
        '
        Me.FS40ResultRTB.Location = New System.Drawing.Point(376, 465)
        Me.FS40ResultRTB.Name = "FS40ResultRTB"
        Me.FS40ResultRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.FS40ResultRTB.Size = New System.Drawing.Size(993, 213)
        Me.FS40ResultRTB.TabIndex = 4
        Me.FS40ResultRTB.Text = ""
        '
        'FS40AsciiRTB
        '
        Me.FS40AsciiRTB.Location = New System.Drawing.Point(376, 247)
        Me.FS40AsciiRTB.Name = "FS40AsciiRTB"
        Me.FS40AsciiRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.FS40AsciiRTB.Size = New System.Drawing.Size(993, 212)
        Me.FS40AsciiRTB.TabIndex = 5
        Me.FS40AsciiRTB.Text = ""
        '
        'FS40ControlRTB
        '
        Me.FS40ControlRTB.Location = New System.Drawing.Point(376, 29)
        Me.FS40ControlRTB.Name = "FS40ControlRTB"
        Me.FS40ControlRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.FS40ControlRTB.Size = New System.Drawing.Size(993, 212)
        Me.FS40ControlRTB.TabIndex = 6
        Me.FS40ControlRTB.Text = ""
        '
        'ClearOutputsBtn
        '
        Me.ClearOutputsBtn.Location = New System.Drawing.Point(295, 610)
        Me.ClearOutputsBtn.Name = "ClearOutputsBtn"
        Me.ClearOutputsBtn.Size = New System.Drawing.Size(75, 68)
        Me.ClearOutputsBtn.TabIndex = 7
        Me.ClearOutputsBtn.Text = "Clear Output Windows"
        Me.ClearOutputsBtn.UseVisualStyleBackColor = True
        '
        'CleanupBtn
        '
        Me.CleanupBtn.Location = New System.Drawing.Point(147, 610)
        Me.CleanupBtn.Name = "CleanupBtn"
        Me.CleanupBtn.Size = New System.Drawing.Size(75, 68)
        Me.CleanupBtn.TabIndex = 8
        Me.CleanupBtn.Text = "Cleanup"
        Me.CleanupBtn.UseVisualStyleBackColor = True
        '
        'DequeueBtn
        '
        Me.DequeueBtn.Location = New System.Drawing.Point(12, 610)
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
        Me.TriggerBtn.Location = New System.Drawing.Point(295, 53)
        Me.TriggerBtn.Name = "TriggerBtn"
        Me.TriggerBtn.Size = New System.Drawing.Size(75, 23)
        Me.TriggerBtn.TabIndex = 10
        Me.TriggerBtn.Text = "Trigger"
        Me.TriggerBtn.UseVisualStyleBackColor = True
        '
        'AsciiSendBtn
        '
        Me.AsciiSendBtn.Location = New System.Drawing.Point(248, 268)
        Me.AsciiSendBtn.Name = "AsciiSendBtn"
        Me.AsciiSendBtn.Size = New System.Drawing.Size(122, 23)
        Me.AsciiSendBtn.TabIndex = 11
        Me.AsciiSendBtn.Text = "Send"
        Me.AsciiSendBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ASCII"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 465)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Result"
        '
        'AsciiCommandTxt
        '
        Me.AsciiCommandTxt.Location = New System.Drawing.Point(248, 297)
        Me.AsciiCommandTxt.Name = "AsciiCommandTxt"
        Me.AsciiCommandTxt.Size = New System.Drawing.Size(122, 23)
        Me.AsciiCommandTxt.TabIndex = 15
        Me.AsciiCommandTxt.Text = "getresultimage"
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 895)
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
End Class
