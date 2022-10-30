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
        Me.ViewerPictureBox = New System.Windows.Forms.PictureBox()
        Me.ResultCountLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.ViewerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ZebraIPTxt
        '
        Me.ZebraIPTxt.Location = New System.Drawing.Point(93, 12)
        Me.ZebraIPTxt.Name = "ZebraIPTxt"
        Me.ZebraIPTxt.Size = New System.Drawing.Size(100, 23)
        Me.ZebraIPTxt.TabIndex = 0
        Me.ZebraIPTxt.Text = "192.168.0.41"
        '
        'ConnectBtn
        '
        Me.ConnectBtn.Location = New System.Drawing.Point(12, 12)
        Me.ConnectBtn.Name = "ConnectBtn"
        Me.ConnectBtn.Size = New System.Drawing.Size(75, 23)
        Me.ConnectBtn.TabIndex = 1
        Me.ConnectBtn.Text = "Connect"
        Me.ConnectBtn.UseVisualStyleBackColor = True
        '
        'DisconnectBtn
        '
        Me.DisconnectBtn.Location = New System.Drawing.Point(12, 39)
        Me.DisconnectBtn.Name = "DisconnectBtn"
        Me.DisconnectBtn.Size = New System.Drawing.Size(75, 23)
        Me.DisconnectBtn.TabIndex = 2
        Me.DisconnectBtn.Text = "Disconnect"
        Me.DisconnectBtn.UseVisualStyleBackColor = True
        '
        'ConsoleRTB
        '
        Me.ConsoleRTB.Location = New System.Drawing.Point(12, 643)
        Me.ConsoleRTB.Name = "ConsoleRTB"
        Me.ConsoleRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.ConsoleRTB.Size = New System.Drawing.Size(1357, 219)
        Me.ConsoleRTB.TabIndex = 3
        Me.ConsoleRTB.Text = ""
        '
        'FS40ResultRTB
        '
        Me.FS40ResultRTB.Location = New System.Drawing.Point(134, 424)
        Me.FS40ResultRTB.MaxLength = 1000000
        Me.FS40ResultRTB.Name = "FS40ResultRTB"
        Me.FS40ResultRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.FS40ResultRTB.Size = New System.Drawing.Size(540, 213)
        Me.FS40ResultRTB.TabIndex = 4
        Me.FS40ResultRTB.Text = ""
        '
        'FS40AsciiRTB
        '
        Me.FS40AsciiRTB.Location = New System.Drawing.Point(134, 206)
        Me.FS40AsciiRTB.MaxLength = 1000000
        Me.FS40AsciiRTB.Name = "FS40AsciiRTB"
        Me.FS40AsciiRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.FS40AsciiRTB.Size = New System.Drawing.Size(540, 212)
        Me.FS40AsciiRTB.TabIndex = 5
        Me.FS40AsciiRTB.Text = ""
        '
        'FS40ControlRTB
        '
        Me.FS40ControlRTB.Location = New System.Drawing.Point(134, 75)
        Me.FS40ControlRTB.MaxLength = 1000000
        Me.FS40ControlRTB.Name = "FS40ControlRTB"
        Me.FS40ControlRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.FS40ControlRTB.Size = New System.Drawing.Size(540, 125)
        Me.FS40ControlRTB.TabIndex = 6
        Me.FS40ControlRTB.Text = ""
        '
        'ClearOutputsBtn
        '
        Me.ClearOutputsBtn.Location = New System.Drawing.Point(12, 569)
        Me.ClearOutputsBtn.Name = "ClearOutputsBtn"
        Me.ClearOutputsBtn.Size = New System.Drawing.Size(75, 68)
        Me.ClearOutputsBtn.TabIndex = 7
        Me.ClearOutputsBtn.Text = "Clear Output Windows"
        Me.ClearOutputsBtn.UseVisualStyleBackColor = True
        '
        'CleanupBtn
        '
        Me.CleanupBtn.Location = New System.Drawing.Point(718, 569)
        Me.CleanupBtn.Name = "CleanupBtn"
        Me.CleanupBtn.Size = New System.Drawing.Size(75, 68)
        Me.CleanupBtn.TabIndex = 8
        Me.CleanupBtn.Text = "Cleanup"
        Me.CleanupBtn.UseVisualStyleBackColor = True
        '
        'DequeueBtn
        '
        Me.DequeueBtn.Location = New System.Drawing.Point(799, 569)
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
        Me.TriggerBtn.Location = New System.Drawing.Point(53, 99)
        Me.TriggerBtn.Name = "TriggerBtn"
        Me.TriggerBtn.Size = New System.Drawing.Size(75, 23)
        Me.TriggerBtn.TabIndex = 10
        Me.TriggerBtn.Text = "Trigger"
        Me.TriggerBtn.UseVisualStyleBackColor = True
        '
        'AsciiSendBtn
        '
        Me.AsciiSendBtn.Location = New System.Drawing.Point(6, 227)
        Me.AsciiSendBtn.Name = "AsciiSendBtn"
        Me.AsciiSendBtn.Size = New System.Drawing.Size(122, 23)
        Me.AsciiSendBtn.TabIndex = 11
        Me.AsciiSendBtn.Text = "Send"
        Me.AsciiSendBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(63, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Control"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(75, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ASCII"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(71, 424)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Result"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AsciiCommandTxt
        '
        Me.AsciiCommandTxt.Location = New System.Drawing.Point(6, 256)
        Me.AsciiCommandTxt.Name = "AsciiCommandTxt"
        Me.AsciiCommandTxt.Size = New System.Drawing.Size(122, 23)
        Me.AsciiCommandTxt.TabIndex = 15
        Me.AsciiCommandTxt.Text = "getresultimage"
        '
        'ViewerPictureBox
        '
        Me.ViewerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewerPictureBox.Location = New System.Drawing.Point(703, 9)
        Me.ViewerPictureBox.Name = "ViewerPictureBox"
        Me.ViewerPictureBox.Size = New System.Drawing.Size(666, 409)
        Me.ViewerPictureBox.TabIndex = 16
        Me.ViewerPictureBox.TabStop = False
        '
        'ResultCountLbl
        '
        Me.ResultCountLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ResultCountLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ResultCountLbl.Location = New System.Drawing.Point(38, 502)
        Me.ResultCountLbl.Name = "ResultCountLbl"
        Me.ResultCountLbl.Size = New System.Drawing.Size(63, 23)
        Me.ResultCountLbl.TabIndex = 17
        Me.ResultCountLbl.Text = "0"
        Me.ResultCountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(38, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 52)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Result" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Count"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 895)
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
End Class
