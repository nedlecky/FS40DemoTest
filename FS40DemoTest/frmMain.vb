Imports Microsoft.Win32

Public Class MainFrm
    'IP Info
    '   FS40 Comm Setup for TensorID
    '       Ethernet Port on Dell PC assigned to FS40   192.168.30.30  255.255.255.0  GW 192.168.30.1
    '       FS40                                        192.168.30.31  255.255.255.0  GW 192.168.30.1
    '   FS40 Comm Setup for Ned's Lab
    '       Ned's Laptop                                192.168.0.252  255.255.255.0  GW 192.168.0.200
    '       FS40                                        192.168.0.41   255.255.255.0  GW 192.168.0.200
    Dim counter As Int32 = 0

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPersistent()

        ConnectBtn.Select()
    End Sub
    Private Sub MainFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SavePersistent()
    End Sub

    Private Function GetAppNameKey() As RegistryKey
        Dim SoftwareKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software", True)
        Dim TensorIDKey As RegistryKey = SoftwareKey.CreateSubKey("TensorID")
        Return TensorIDKey.CreateSubKey("FS40DemoTest")
    End Function
    Private Sub SavePersistent()
        Dim AppNameKey As RegistryKey = GetAppNameKey()

        AppNameKey.SetValue("ZebraIPTxt.Text", ZebraIPTxt.Text)
    End Sub
    Private Sub LoadPersistent()
        Dim AppNameKey As RegistryKey = GetAppNameKey()

        ZebraIPTxt.Text = AppNameKey.GetValue("ZebraIPTxt.Text", "192.168.0.41")
    End Sub

    Private Sub PrintRTB(rtb As RichTextBox, message As String)
        rtb.Text += message + Environment.NewLine
        rtb.SelectionStart = rtb.Text.Length
        rtb.ScrollToCaret()
    End Sub

    Private Sub PrintConsole(message As String)
        PrintRTB(ConsoleRTB, message)
    End Sub

    Private Sub ConnectBtn_Click(sender As Object, e As EventArgs) Handles ConnectBtn.Click
        PrintConsole("ConnectBtn_Click")

        counter = counter + 1

        PrintRTB(FS40ControlRTB, $"Control {counter}")
        PrintRTB(FS40AsciiRTB, $"Ascii {counter}")
        PrintRTB(FS40ResultRTB, $"Result {counter}")

    End Sub

    Private Sub DisconnectBtn_Click(sender As Object, e As EventArgs) Handles DisconnectBtn.Click
        PrintConsole("DisconnectBtn_Click")

    End Sub

    Private Sub ClearOutputsBtn_Click(sender As Object, e As EventArgs) Handles ClearOutputsBtn.Click
        ConsoleRTB.Clear()
        FS40ControlRTB.Clear()
        FS40AsciiRTB.Clear()
        FS40ResultRTB.Clear()
    End Sub

End Class
