Imports System.Net.Sockets
Imports System.Text

Public Class ucFS40Interface
    Dim myForm As MainFrm

    Dim controlClient As TcpClient
    Dim asciiClient As TcpClient
    Dim resultClient As TcpClient

    Public Sub New(form As MainFrm)
        myForm = form
        myForm.Print("ucFS40Interface::New(...)")

    End Sub

    Public Sub Dispose()
        myForm.Print("ucFS40Interface::Dispose()")

    End Sub
    Protected Overrides Sub Finalize()
        myForm.printQueue.Enqueue("ucFS40Interface::Finalize()")
        'myForm.Print("ucFS40Interface::Finalize()")

    End Sub

    Public Function Connect(connectIP As String) As Int32
        myForm.Print($"ucFS40Interface::Connect({connectIP})")

        Try
            controlClient = New TcpClient(connectIP, 107)
            asciiClient = New TcpClient(connectIP, 23)
            resultClient = New TcpClient(connectIP, 25250)
            myForm.Print("ucFS40Interface connected")
        Catch
            myForm.Print("ucFS40Interface connect FAILED")
            Return 1
        End Try




        ' Translate the passed message into ASCII and store it as a Byte array. 
        Dim data As [Byte]() = System.Text.Encoding.ASCII.GetBytes("TRIGGER\r\n")

        ' Get a client stream for reading and writing. 
        '  Stream stream = client.GetStream(); 
        Dim stream As NetworkStream = controlClient.GetStream()

        ' Send the message to the connected TcpServer. 
        stream.Write(data, 0, data.Length)


        Return 0
    End Function
    Public Function Disconnect() As Int32
        myForm.Print("ucFS40Interface::Disconnect()")
        controlClient.Dispose()
        asciiClient.Dispose()
        resultClient.Dispose()
        myForm.Print("ucFS40Interface::Disconnect() complete")
        Return 0
    End Function

    Public Sub Poll()
        Dim inputBuffer(128000) As Byte

        If controlClient.Available > 0 Then
            Dim stream As NetworkStream = controlClient.GetStream()
            stream.Read(inputBuffer, 0, inputBuffer.Length)
            myForm.Print(Encoding.UTF8.GetString(inputBuffer, 0, inputBuffer.Length))
        End If
        If asciiClient.Available > 0 Then
            Dim stream As NetworkStream = asciiClient.GetStream()
            stream.Read(inputBuffer, 0, inputBuffer.Length)
            myForm.Print(Encoding.UTF8.GetString(inputBuffer, 0, inputBuffer.Length))
        End If
        If resultClient.Available > 0 Then
            Dim stream As NetworkStream = resultClient.GetStream()
            stream.Read(inputBuffer, 0, inputBuffer.Length)
            myForm.Print(Encoding.UTF8.GetString(inputBuffer, 0, inputBuffer.Length))
        End If
    End Sub

End Class
