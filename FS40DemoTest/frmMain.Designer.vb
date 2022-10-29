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
        Me.FS40IPTxt = New System.Windows.Forms.TextBox()
        Me.ConnectBtn = New System.Windows.Forms.Button()
        Me.DisconnectBtn = New System.Windows.Forms.Button()
        Me.ConsoleRTB = New System.Windows.Forms.RichTextBox()
        Me.FS40ResultRTB = New System.Windows.Forms.RichTextBox()
        Me.FS40AsciiRTB = New System.Windows.Forms.RichTextBox()
        Me.FS40ControlRTB = New System.Windows.Forms.RichTextBox()
        Me.ClearOutputsBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FS40IPTxt
        '
        Me.FS40IPTxt.Location = New System.Drawing.Point(122, 39)
        Me.FS40IPTxt.Name = "FS40IPTxt"
        Me.FS40IPTxt.Size = New System.Drawing.Size(100, 23)
        Me.FS40IPTxt.TabIndex = 0
        Me.FS40IPTxt.Text = "192.168.0.41"
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
        Me.ClearOutputsBtn.Location = New System.Drawing.Point(32, 135)
        Me.ClearOutputsBtn.Name = "ClearOutputsBtn"
        Me.ClearOutputsBtn.Size = New System.Drawing.Size(75, 68)
        Me.ClearOutputsBtn.TabIndex = 7
        Me.ClearOutputsBtn.Text = "Clear Output Windows"
        Me.ClearOutputsBtn.UseVisualStyleBackColor = True
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1381, 895)
        Me.Controls.Add(Me.ClearOutputsBtn)
        Me.Controls.Add(Me.FS40ControlRTB)
        Me.Controls.Add(Me.FS40AsciiRTB)
        Me.Controls.Add(Me.FS40ResultRTB)
        Me.Controls.Add(Me.ConsoleRTB)
        Me.Controls.Add(Me.DisconnectBtn)
        Me.Controls.Add(Me.ConnectBtn)
        Me.Controls.Add(Me.FS40IPTxt)
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FS40IPTxt As TextBox
    Friend WithEvents ConnectBtn As Button
    Friend WithEvents DisconnectBtn As Button
    Friend WithEvents ConsoleRTB As RichTextBox
    Friend WithEvents FS40ResultRTB As RichTextBox
    Friend WithEvents FS40AsciiRTB As RichTextBox
    Friend WithEvents FS40ControlRTB As RichTextBox
    Friend WithEvents ClearOutputsBtn As Button
End Class
