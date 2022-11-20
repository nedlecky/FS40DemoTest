Imports System.Net.Sockets
Imports System.Text
Imports Microsoft.VisualBasic.Devices

Public Class TensorTcpClient
    Dim myForm As MainFrm
    Public client As TcpClient
    Public stream As NetworkStream
    Dim inputBuffer(128000) As Byte

    Public Sub New(form As MainFrm, hostname As String, port As Integer)
        myForm = form
        client = New TcpClient(hostname, port)
        stream = client.GetStream()
    End Sub
    Public Sub Dispose()
        myForm.Print("TensorTcpClient::Dispose()")

    End Sub
    Protected Overrides Sub Finalize()
        myForm.printQueue.Enqueue("TensorTcpClient::Finalize()")

    End Sub

    Public Function Send(message As String) As Integer
        Dim data As [Byte]() = System.Text.Encoding.ASCII.GetBytes(message)
        stream.Write(data, 0, data.Length)
        Return 0
    End Function
    Public Function Available() As Integer
        Return client.Available
    End Function
    Public Function Receive() As String
        Dim retString As String = ""
        REM TODO Should wait for the delimiter LF, CRLF, etc.
        While (Available() > 0)
            Dim length As Integer = stream.Read(inputBuffer, 0, inputBuffer.Length)
            retString += Encoding.UTF8.GetString(inputBuffer, 0, length)
        End While

        Return retString.Trim()
    End Function

End Class
Public Class ucFS40Interface
    Dim myForm As MainFrm

    Public controlClient As TensorTcpClient
    Public asciiClient As TensorTcpClient
    Public resultClient As TensorTcpClient

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
            controlClient = New TensorTcpClient(myForm, connectIP, 107)
            asciiClient = New TensorTcpClient(myForm, connectIP, 23)
            resultClient = New TensorTcpClient(myForm, connectIP, 25250)
            myForm.Print("ucFS40Interface connected")
        Catch
            myForm.Print("ucFS40Interface connect FAILED")
            Return 1
        End Try
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

    Public Function SendControl(message As String) As Integer
        myForm.Print($"==> Control {message.Trim()}")
        myForm.PrintControl($"==> {message.Trim()}")

        Return controlClient.Send(message)
    End Function
    Public Function SendAscii(message As String) As Integer
        myForm.Print($"==> Ascii {message.Trim()}")
        myForm.PrintAscii($"==> {message.Trim()}")
        Return asciiClient.Send(message)
    End Function



End Class
