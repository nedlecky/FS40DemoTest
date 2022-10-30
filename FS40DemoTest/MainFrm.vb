Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles
Imports Microsoft.Win32

Public Class MainFrm
    'IP Info
    '   FS40 Comm Setup for TensorID
    '       Ethernet Port on Dell PC assigned to FS40   192.168.30.30  255.255.255.0  GW 192.168.30.1
    '       FS40                                        192.168.30.31  255.255.255.0  GW 192.168.30.1
    '   FS40 Comm Setup for Ned's Lab
    '       Ned's Laptop                                192.168.0.252  255.255.255.0  GW 192.168.0.200
    '       FS40                                        192.168.0.41   255.255.255.0  GW 192.168.0.200
    Dim fs40 As ucFS40Interface = Nothing
    Public printQueue As Queue = New Queue
    Dim resultCount As Integer = 0

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "FS40 Demo/Test Program"
        LoadPersistent()

        UpdateResultCount(0)

        ConnectBtn.Select()
        ConnectBtn_Click(Nothing, Nothing)
    End Sub
    Private Sub MainFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SavePersistent()
        DisconnectBtn_Click(Nothing, Nothing)
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
        Dim timestamp As String = Format(Now, "HH.mm.ss.fff ")
        rtb.Text += timestamp + message + Environment.NewLine

        Dim length As Integer = rtb.Text.Length
        If length > 10000 Then
            rtb.Text = rtb.Text.Substring(length - 5000, 5000)
        End If
        rtb.SelectionStart = rtb.Text.Length
        rtb.ScrollToCaret()
    End Sub

    Public Sub Print(message As String)
        PrintRTB(ConsoleRTB, message)
    End Sub
    Public Sub PrintControl(message As String)
        PrintRTB(FS40ControlRTB, message)
    End Sub
    Public Sub PrintAscii(message As String)
        PrintRTB(FS40AsciiRTB, message)
    End Sub
    Public Sub PrintResult(message As String)
        PrintRTB(FS40ResultRTB, message)
    End Sub

    Private Sub ConnectBtn_Click(sender As Object, e As EventArgs) Handles ConnectBtn.Click
        Print("ConnectBtn_Click")

        fs40 = New ucFS40Interface(Me)
        Dim ret As Int32 = fs40.Connect(ZebraIPTxt.Text)
        Print($"fs40.Connect({ZebraIPTxt.Text}) returns {ret}")

        ReceiveTmr.Interval = 50
        ReceiveTmr.Enabled = True
    End Sub

    Private Sub DisconnectBtn_Click(sender As Object, e As EventArgs) Handles DisconnectBtn.Click
        Print("DisconnectBtn_Click")

        ReceiveTmr.Enabled = False

        Dim ret As Int32 = 0
        If fs40 IsNot Nothing Then
            ret = fs40.Disconnect()
            Print($"fs40.Disconnect({ZebraIPTxt.Text}) returns {ret}")
            fs40.Dispose()
            fs40 = Nothing
        End If
    End Sub

    Private Sub TriggerBtn_Click(sender As Object, e As EventArgs) Handles TriggerBtn.Click
        fs40.SendControl("TRIGGER" + Chr(13) + Chr(10))
    End Sub
    Private Sub AsciiSendBtn_Click(sender As Object, e As EventArgs) Handles AsciiSendBtn.Click
        fs40.SendAscii(AsciiCommandTxt.Text + Chr(13) + Chr(10))

    End Sub

    Private Sub UpdateResultCount(i As Integer)
        resultCount = i
        ResultCountLbl.Text = i.ToString()
    End Sub
    Private Sub ClearOutputsBtn_Click(sender As Object, e As EventArgs) Handles ClearOutputsBtn.Click
        ConsoleRTB.Clear()
        FS40ControlRTB.Clear()
        FS40AsciiRTB.Clear()
        FS40ResultRTB.Clear()
        UpdateResultCount(0)
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

    Public Function ImageParse(fs40Return As String) As Image
        Dim retImage As Image = Nothing

        Dim lines() As String = fs40Return.Split(Chr(13))
        Print($"ImageParse sees {lines.Length} lines")
        If lines.Length < 4 Then
            Return Nothing
        End If

        Print($"line 1 is {lines(0).Trim()}")
        Print($"line 2 is {lines(1).Trim()}")
        Print($"line 3 starts {lines(2).Substring(0, 40).Trim()}")

        Dim line1 As String = lines(0).Trim()
        Dim line2 As String = lines(1).Trim()
        Dim line3 As String = lines(2).Trim()

        If line1 = "command:getresultimage,ok" Then
            Dim length As Integer = Convert.ToInt32(line2)
            Print($"length = {length} and line3.Length = {line3.Length}")
            If (length = line3.Length) Then
                Print("Looks like a valid Base64 image!")
                Dim bytes As Byte() = Convert.FromBase64String(line3)
                Dim ms As MemoryStream = New MemoryStream(bytes)
                Print($"bytes.Length = {bytes.Length}  ms.Length = {ms.Length}")
                Try
                    retImage = Image.FromStream(ms)
                    ViewerPictureBox.BackgroundImage = retImage
                Catch
                    Print("Image conversion FAILED")
                End Try
            End If
        End If

        Return retImage

    End Function
    Private Sub ReceiveTmr_Tick(sender As Object, e As EventArgs) Handles ReceiveTmr.Tick
        'Print("ReceiveTmr_Tick(...)")
        If fs40 Is Nothing Then
            Return
        End If


        If fs40.controlClient.Available > 0 Then
            Dim available As Integer = fs40.controlClient.Available
            Dim result As String = fs40.controlClient.Receive()
            Print($"Control received {available} bytes  {result}")
            PrintControl($"Received {available} bytes  {result}")
        End If
        If fs40.asciiClient.Available > 0 Then
            Dim available As Integer = fs40.asciiClient.Available
            Dim result = fs40.asciiClient.Receive()
            Print($"Ascii received {available} bytes  {result}")
            PrintAscii($"Received {available} bytes  {result}")

            ImageParse(result)
        End If
        If fs40.resultClient.Available > 0 Then
            Dim available As Integer = fs40.resultClient.Available
            Dim result As String = fs40.resultClient.Receive()
            UpdateResultCount(resultCount + 1)
            Print($"Result received {available} bytes  {result}")
            PrintResult($"Received {available} bytes  {result}")
        End If
    End Sub

End Class
