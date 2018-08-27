
Imports System
Imports System.IO.Ports
Public Class Form1
    Dim comPORT As String
    Dim receivedData As String = ""
    Dim mouseisdownup As Boolean
    Dim mouseisdowndown As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next
    End Sub


    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub


    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
            If (comPORT <> "") Then
                Timer_LBL.Show()
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()
                connect_BTN.Text = "Dis-connect"
                Timer1.Enabled = True
                Timer_LBL.Text = "Timer: ON"
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            closeing()
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            Timer1.Enabled = False
            Timer_LBL.Text = "Timer: OFF"
        End If


    End Sub
    Private Sub closeing()
        SerialPort1.Write("0")
    End Sub

    Function ReceiveSerialData()
        Dim Incoming As String
        Try

            Incoming = SerialPort1.ReadExisting()
            SerialPort1.DiscardInBuffer()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function

    Private Sub verup()
        receivedData = ReceiveSerialData()
        vertlab.Text = receivedData
        SerialPort1.Write("2")

    End Sub
    Private Sub verdown()
        receivedData = ReceiveSerialData()
        vertlab.Text = receivedData
        SerialPort1.Write("3")
    End Sub
    Private Sub verleft()
        receivedData = ReceiveSerialData()
        Horzlab.Text = receivedData
        SerialPort1.Write("4")
    End Sub
    Private Sub verright()
        receivedData = ReceiveSerialData()
        Horzlab.Text = receivedData
        SerialPort1.Write("5")
    End Sub


    Private Sub downbtn_Click(sender As Object, e As EventArgs) Handles downbtn.Click
        verdown()
    End Sub

    Private Sub Upbtn_Click(sender As Object, e As EventArgs) Handles Upbtn.Click
        verup()
    End Sub

    Private Sub leftbtn_Click(sender As Object, e As EventArgs) Handles leftbtn.Click
        verleft()
    End Sub

    Private Sub rightbtn_Click(sender As Object, e As EventArgs) Handles rightbtn.Click
        verright()
    End Sub

    Private Sub autobtn_Click(sender As Object, e As EventArgs) Handles autobtn.Click

        SerialPort1.Write("1")

    End Sub
End Class
