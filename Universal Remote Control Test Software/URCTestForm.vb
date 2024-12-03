'Zachary Christensen
'RCET Lab Project
'12/2/24
'Universal Remote control Test SoftwaRE
'GitHub:https://github.com/Minidude140/Universal-Remote-Control-Test-Software 

Option Explicit On
Option Strict On
Imports System.Threading
Public Class URCTestForm
    '*********************************************Global Variables******************************************
    Dim robotAddress As Integer
    Dim currentCommand As Integer
    Dim joystick1UD As Integer
    Dim joystick1LR As Integer
    Dim joystick2UD As Integer
    Dim joystick2LR As Integer
    Dim joystick3UD As Integer
    Dim Joystick3LR As Integer
    Dim buttonByte1 As Byte
    Dim buttonByte2 As Byte

    '**********************************************Custom Methods*******************************************
    ''' <summary>
    ''' Fill Combo Box With Available COM Ports
    ''' </summary>
    Sub PopulateCOMSelect()
        For Each portName In COMSerialPort.GetPortNames
            'add available Com Ports to combo box
            COMSelectToolStripComboBox.Items.Add(portName)
        Next
        'Select First Option
        COMSelectToolStripComboBox.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Open COM Channel and Enable COM Timer
    ''' </summary>
    Sub OpenCOM()
        COMSerialPort.PortName = CStr(COMSelectToolStripComboBox.SelectedItem)
        COMSerialPort.BaudRate = 115200
        Try
            'Open Com Port
            COMSerialPort.Open()
            'Enable COM Timer
            SerialCOMTimer.Enabled = True
            'Disable Com Connect.  Enable Com Disconnect
            ConnectCOMToolStripButton.Enabled = False
            DisconnetToolStripButton.Enabled = True
        Catch ex As Exception
            MsgBox("Sorry Selected COM could not be connected.")
        End Try
    End Sub

    ''' <summary>
    ''' Close COM Channel and Disable COM Timer
    ''' </summary>
    Sub CloseCOM()
        'Disable COM Timer
        SerialCOMTimer.Enabled = False
        'Close Serial Port
        COMSerialPort.Close()
        'Disable Disconnect Button.  Enable Connect Button
        ConnectCOMToolStripButton.Enabled = True
        DisconnetToolStripButton.Enabled = False
    End Sub

    ''' <summary>
    ''' Using Global Data Variables Updates Labels with Current Data Info
    ''' </summary>
    Sub UpdateDisplay()
        'Update Robot Address
        RobotAddressLabel.Text = CStr(robotAddress)
        'Update Joystick 1
        Joystick1UDLabel.Text = CStr(joystick1UD)
        Joystick1LRLabel.Text = CStr(joystick1LR)
        Joystick1UDTrackBar.Value = joystick1UD
        Joystick1LRTrackBar.Value = joystick1LR
        'Update Joystick 2
        Joystick2UDLabel.Text = CStr(joystick2UD)
        Joystick2LRLabel.Text = CStr(joystick2LR)
        Joystick2UDTrackBar.Value = joystick2UD
        Joystick2LRTrackBar.Value = joystick2LR
        'Update Joystick 3
        Joystick3UDLabel.Text = CStr(joystick3UD)
        Joystick3LRLabel.Text = CStr(Joystick3LR)
        Joystick3UDTrackBar.Value = joystick3UD
        Joystick3LRTrackBar.Value = Joystick3LR
        'Update Button Indicators
        TestButtons()
    End Sub

    ''' <summary>
    ''' Test a given byte at a given index return true if high.  Return False if low.
    ''' </summary>
    ''' <param name="data"></param>
    ''' <param name="index"></param>
    ''' <returns></returns>
    Function TestBit(data As Byte, index As Integer) As Boolean
        Dim testArray As New BitArray({data})
        If testArray(index) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Test the Button Data Bytes and Updates the Display With Buttons Pressed
    ''' </summary>
    Sub TestButtons()
        'Test Button 1
        If TestBit(buttonByte1, 0) = True Then
            Button1Indicator.BackColor = Color.GreenYellow
        Else
            Button1Indicator.BackColor = Color.Gray
        End If
        'Test Button 2

        'Test Button 3

        'Test Button 4

        'Test Left Bumper

        'Test Right Bumper

        'Test Joystick 1 Button

        'Test Joystick 2 Button

        'Test Joystick 3 Button

    End Sub

    '**********************************************Event Handlers*******************************************
    Private Sub URCTestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Fill Combo Box With Serial Options
        PopulateCOMSelect()
        'Disable Disconnect Button
        DisconnetToolStripButton.Enabled = False
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ConnectCOMToolStripButton_Click(sender As Object, e As EventArgs) Handles ConnectCOMToolStripButton.Click
        'Open COM port and Enable COM Timer
        OpenCOM()
    End Sub
    Private Sub DisconnetToolStripButton_Click(sender As Object, e As EventArgs) Handles DisconnetToolStripButton.Click
        'Close COM Channel and Disable Timer
        CloseCOM()
    End Sub

    Private Sub SerialCOMTimer_Tick(sender As Object, e As EventArgs) Handles SerialCOMTimer.Tick
        Try
            'create an array of bytes with the length of input data
            Dim data(COMSerialPort.BytesToRead) As Byte
            'Populate array with input data
            COMSerialPort.Read(data, 0, COMSerialPort.BytesToRead)
            If data(0) = &H24 Then
                'Handshake found connection success
                robotAddress = data(1)
                'Test Command Byte for Data Packet
                Select Case data(2)
                    Case = 74
                        'Command Byte is an ASCII J Save Joystick Data
                        'Save Joystick 1 Up Down Data
                        joystick1UD = data(3)
                        'Save Joystick 2 Up Down Data
                        joystick2UD = data(4)
                        'Save Joystick 1 Left Right Data
                        joystick1LR = data(5)
                    Case = 106
                        'Command Byte is an ASCII j save Joystick Data
                        'Save Joystick 2 Left Right Data
                        joystick2LR = data(3)
                        'Save Joystick 3 Up Down Data
                        joystick3UD = data(4)
                        'Save Joystick 3 Left Right Data
                        Joystick3LR = data(5)
                    Case = 66
                        'Command Byte is an ASCII B save Button Data
                        'Save Button Data Byte 1
                        buttonByte1 = data(3)
                        'Save Button Data Byte 2
                        buttonByte2 = data(4)
                    Case Else
                        'Command byte unknown
                End Select
            Else
                'Handshake not found disconnect
                'Clear RX Buffer
                COMSerialPort.DiscardInBuffer()
            End If
        Catch ex As Exception
            'Clear RX Buffer
            COMSerialPort.DiscardInBuffer()
            'Report Error to User
            MsgBox("Sorry a connection error occurred.  The COM Channel has been disconnected")
            MsgBox($"{ex.Message}")
        End Try
        'Clear RX Buffer
        COMSerialPort.DiscardInBuffer()
        UpdateDisplay()
    End Sub

End Class
