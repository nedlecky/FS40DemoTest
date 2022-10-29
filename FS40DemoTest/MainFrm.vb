Imports System.Runtime.CompilerServices
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

    Dim fs40 As ucFS40Interface
    Public printQueue As Queue = New Queue

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

    Public Sub Print(message As String)
        PrintRTB(ConsoleRTB, message)
    End Sub

    Private Sub ConnectBtn_Click(sender As Object, e As EventArgs) Handles ConnectBtn.Click
        Print("ConnectBtn_Click")

        counter = counter + 1

        PrintRTB(FS40ControlRTB, $"Control {counter}")
        PrintRTB(FS40AsciiRTB, $"Ascii {counter}")
        PrintRTB(FS40ResultRTB, $"Result {counter}")

        fs40 = New ucFS40Interface(Me)
        Dim ret As Int32 = fs40.Connect(ZebraIPTxt.Text)
        Print($"fs40.Connect({ZebraIPTxt.Text}) returns {ret}")

        ReceiveTmr.Interval = 1000
        ReceiveTmr.Enabled = True

    End Sub

    Private Sub DisconnectBtn_Click(sender As Object, e As EventArgs) Handles DisconnectBtn.Click
        Print("DisconnectBtn_Click")

        ReceiveTmr.Enabled = True
        fs40.Poll()

        Dim ret As Int32 = fs40.Disconnect()
        Print($"fs40.Disconnect({ZebraIPTxt.Text}) returns {ret}")

        fs40.Dispose()
    End Sub

    Private Sub ClearOutputsBtn_Click(sender As Object, e As EventArgs) Handles ClearOutputsBtn.Click
        ConsoleRTB.Clear()
        FS40ControlRTB.Clear()
        FS40AsciiRTB.Clear()
        FS40ResultRTB.Clear()
    End Sub

    Private Sub CleanupBtn_Click(sender As Object, e As EventArgs) Handles CleanupBtn.Click
        Print("CleanupBtn_Click")

        GC.Collect()

    End Sub

    Private Sub DequeueBtn_Click(sender As Object, e As EventArgs) Handles DequeueBtn.Click
        While printQueue.Count > 0
            Print(printQueue.Dequeue)
        End While
    End Sub

    Private Sub ReceiveTmr_Tick(sender As Object, e As EventArgs) Handles ReceiveTmr.Tick
        Print("ReceiveTmr_Tick(...)")

        fs40.Poll()



    End Sub
End Class
