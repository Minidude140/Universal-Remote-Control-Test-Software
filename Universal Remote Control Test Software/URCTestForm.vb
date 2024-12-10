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
    Dim buttonOnColor As Color
    Dim buttonOffColor As Color
    Dim joy1PosColor As Brush
    Dim joy2PosColor As Brush
    Dim joy3PosColor As Brush
    Public GrowlGreyLight As Color = Color.FromArgb(230, 231, 232)
    Public GrowlGreyMed As Color = Color.FromArgb(167, 167, 167)
    Public GrowlGrey As Color = Color.FromArgb(130, 130, 130)
    Public Roarange As Color = Color.FromArgb(244, 121, 32)

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
            'Update Status Strip Label
            COMStatusStripLabel.Text = "Connected to: " & COMSerialPort.PortName
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
        'Updated Status Strip Label
        COMStatusStripLabel.Text = "Not Connected"
    End Sub

    ''' <summary>
    ''' Using Global Data Variables Updates Labels with Current Data Info
    ''' </summary>
    Sub UpdateDisplay()
        'Update Robot Address
        RobotAddressDecLabel.Text = CStr(robotAddress)
        RobotAddressHexLabel.Text = CStr(Hex(robotAddress))
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
        'Draw Joystick 1 Display
        DrawJoystick1(joystick1LR, joystick1UD)
        'Draw Joystick 2 Display
        DrawJoystick2(joystick2LR, joystick2UD)
        'Draw Joystick 3 Display
        DrawJoystick3(Joystick3LR, joystick3UD)
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
            'Button is Pressed
            Button1Indicator.BackColor = buttonOnColor
        Else
            'Button is Not Pressed
            Button1Indicator.BackColor = buttonOffColor
        End If
        'Test Button 2
        If TestBit(buttonByte1, 1) = True Then
            'Button is Pressed
            Button2Indicator.BackColor = buttonOnColor
        Else
            'Button is Not Pressed
            Button2Indicator.BackColor = buttonOffColor
        End If
        'Test Button 3
        If TestBit(buttonByte1, 2) = True Then
            'Button is Pressed
            Button3Indicator.BackColor = buttonOnColor
        Else
            'Button is Not Pressed
            Button3Indicator.BackColor = buttonOffColor
        End If
        'Test Button 4
        If TestBit(buttonByte1, 3) = True Then
            'Button is Pressed
            Button4Indicator.BackColor = buttonOnColor
        Else
            'Button is Not Pressed
            Button4Indicator.BackColor = buttonOffColor
        End If
        'Test Left Bumper
        If TestBit(buttonByte1, 4) = True Then
            'Button is Pressed
            LeftBumperIndicatorButton.BackColor = buttonOnColor
        Else
            'Button is Not Pressed
            LeftBumperIndicatorButton.BackColor = buttonOffColor
        End If
        'Test Right Bumper
        If TestBit(buttonByte1, 5) = True Then
            'Button is Pressed
            RightBumperIndicatorButton.BackColor = buttonOnColor
        Else
            'Button is Not Pressed
            RightBumperIndicatorButton.BackColor = buttonOffColor
        End If
        'Test Joystick 1 Button
        If TestBit(buttonByte1, 6) = True Then
            'Button is Pressed
            Joystick1IndicatorButton.BackColor = buttonOnColor
        Else
            'Button is Not Pressed
            Joystick1IndicatorButton.BackColor = buttonOffColor
        End If
        'Test Joystick 2 Button
        If TestBit(buttonByte1, 7) = True Then
            'Button is Pressed
            Joystick2IndicatorButton.BackColor = buttonOnColor
        Else
            'Button is Not Pressed
            Joystick2IndicatorButton.BackColor = buttonOffColor
        End If
        'Test Joystick 3 Button
        If TestBit(buttonByte2, 0) = True Then
            'Button is Pressed
            Joystick3IndicatorButton.BackColor = buttonOnColor
        Else
            'Button is Not Pressed
            Joystick3IndicatorButton.BackColor = buttonOffColor
        End If
    End Sub

    ''' <summary>
    ''' Draws a Filled Ellipse Into Joystick 1 PictureBox.  Scaled to 255 Max Inputs
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    Sub DrawJoystick1(x As Integer, y As Integer)
        'Clear Last Dot
        Joystick1PictureBox.Refresh()
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = Joystick1PictureBox.CreateGraphics
        'initialize pen as color Black and pen size
        Dim pen As New Pen(Color.Black, 4)
        'Draw Border
        g.DrawRectangle(pen, 0, 0, Joystick1PictureBox.Width, Joystick1PictureBox.Height)
        'Scale to 255 Input Data
        Dim sX As Single = CSng(Joystick1PictureBox.Width / 255)
        Dim sY As Single = CSng(Joystick1PictureBox.Height / 255)
        g.ScaleTransform(sX, sY)
        'Draw Center Dot
        g.FillEllipse(joy1PosColor, ((255 - x) - 20), ((255 - y) - 20), 40, 40)
    End Sub

    ''' <summary>
    ''' Draws a Filled Ellipse Into Joystick 2 PictureBox.  Scaled to 255 Max Inputs
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    Sub DrawJoystick2(x As Integer, y As Integer)
        'Clear Last Dot
        Joystick2PictureBox.Refresh()
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = Joystick2PictureBox.CreateGraphics
        'initialize pen as color Black and pen size
        Dim pen As New Pen(Color.Black, 4)
        'Draw Border
        g.DrawRectangle(pen, 0, 0, Joystick2PictureBox.Width, Joystick2PictureBox.Height)
        'Scale to 255 Input Data
        Dim sX As Single = CSng(Joystick2PictureBox.Width / 255)
        Dim sY As Single = CSng(Joystick2PictureBox.Height / 255)
        g.ScaleTransform(sX, sY)
        'Draw Center Dot
        g.FillEllipse(joy2PosColor, ((255 - x) - 20), ((255 - y) - 20), 40, 40)
    End Sub

    ''' <summary>
    ''' Draws a Filled Ellipse Into Joystick 2 PictureBox.  Scaled to 255 Max Inputs
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    Sub DrawJoystick3(x As Integer, y As Integer)
        'Clear Last Dot
        Joystick3PictureBox.Refresh()
        'initialize graphics object and set drawing surface to picture box
        Dim g As Graphics = Joystick3PictureBox.CreateGraphics
        'initialize pen as color Black and pen size
        Dim pen As New Pen(Color.Black, 4)
        'Draw Border
        g.DrawRectangle(pen, 0, 0, Joystick3PictureBox.Width, Joystick3PictureBox.Height)
        'Scale to 255 Input Data
        Dim sX As Single = CSng(Joystick3PictureBox.Width / 255)
        Dim sY As Single = CSng(Joystick3PictureBox.Height / 255)
        g.ScaleTransform(sX, sY)
        'Draw Center Dot
        g.FillEllipse(joy3PosColor, ((255 - x) - 20), ((255 - y) - 20), 40, 40)
    End Sub

    '**********************************************Event Handlers*******************************************
    Private Sub URCTestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Fill Combo Box With Serial Options
        PopulateCOMSelect()
        'Disable Disconnect Button
        DisconnetToolStripButton.Enabled = False
        'Set Menu Strip Color
        MenuStrip.BackColor = GrowlGrey
        'Set Default Button Colors
        buttonOnColor = Roarange
        buttonOffColor = Color.Gray
        'Set Default Joystick Dot Colors
        Dim tempBrush As New SolidBrush(Roarange)
        joy1PosColor = tempBrush
        joy2PosColor = tempBrush
        joy3PosColor = tempBrush
        'Start With Each Joystick Axis at Half
        Joystick1LRTrackBar.Value = 128
        Joystick1UDTrackBar.Value = 128
        Joystick2LRTrackBar.Value = 128
        Joystick2UDTrackBar.Value = 128
        Joystick3LRTrackBar.Value = 128
        Joystick3UDTrackBar.Value = 128
        'Enable Start Up Timer for Drawing Box Borders (Need Delay For Picture Box to Initialize)
        StartUpTimer.Enabled = True
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ConnectCOMToolStripButton_Click(sender As Object, e As EventArgs) Handles ConnectCOMToolStripButton.Click,
                                                                                          ConnectMenuItem.Click
        'Open COM port and Enable COM Timer
        OpenCOM()
    End Sub
    Private Sub DisconnetToolStripButton_Click(sender As Object, e As EventArgs) Handles DisconnetToolStripButton.Click,
                                                                                         DisconnectMenuItem.Click
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
            MsgBox("Sorry a connection error has occurred.")
        End Try
        'Clear RX Buffer
        COMSerialPort.DiscardInBuffer()
        UpdateDisplay()
    End Sub

    Private Sub StartUpTimer_Tick(sender As Object, e As EventArgs) Handles StartUpTimer.Tick
        StartUpTimer.Enabled = False
        'Draw Border and Initial Center Dot On Picture Boxes
        DrawJoystick1(128, 128)
        DrawJoystick2(128, 128)
        DrawJoystick3(128, 128)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        URCAboutForm.Show()
    End Sub
    '************************Joystick GUI Controls*********************************************************
    'Joystick 1
    Private Sub ToggleLeftRightDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Joy1ToggleLeftRightDataMenuItem.Click
        If Joystick1LRLabel.Visible = True Then
            Joystick1LRLabel.Visible = False
        Else
            Joystick1LRLabel.Visible = True
        End If
    End Sub
    Private Sub ToggleLeftRightTrackBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Joy1ToggleLeftRightTrackBarMenuItem.Click
        If Joystick1LRTrackBar.Visible = True Then
            Joystick1LRTrackBar.Visible = False
        Else
            Joystick1LRTrackBar.Visible = True
        End If
    End Sub
    Private Sub ToggleUpDownDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Joy1ToggleUpDownDataMenuItem.Click
        If Joystick1UDLabel.Visible = True Then
            Joystick1UDLabel.Visible = False
        Else
            Joystick1UDLabel.Visible = True
        End If
    End Sub
    Private Sub ToggleUpDownTrackBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Joy1ToggleUpDownTrackBarMenuItem.Click
        If Joystick1UDTrackBar.Visible = True Then
            Joystick1UDTrackBar.Visible = False
        Else
            Joystick1UDTrackBar.Visible = True
        End If
    End Sub
    Private Sub TogglePositionGraphToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Joy1TogglePositionGraphMenuItem.Click
        If Joystick1PictureBox.Visible = True Then
            Joystick1PictureBox.Visible = False
        Else
            Joystick1PictureBox.Visible = True
            DrawJoystick1(128, 128)
        End If
    End Sub
    Private Sub Joy1ChangPositionDotColorMenuItem_Click(sender As Object, e As EventArgs) Handles Joy1ChangPositionDotColorMenuItem.Click
        ColorDialog.ShowDialog()
        Dim tempBrush As New SolidBrush(ColorDialog.Color)
        joy1PosColor = tempBrush
        DrawJoystick1(128, 128)
    End Sub
    Private Sub Joy1SetDefaultJoystickDisplayMenuItem_Click(sender As Object, e As EventArgs) Handles Joy1SetDefaultJoystickDisplayMenuItem.Click
        Dim tempBrush As New SolidBrush(Roarange)
        joy1PosColor = tempBrush
        Joystick1LRLabel.Visible = True
        Joystick1LRTrackBar.Visible = True
        Joystick1UDLabel.Visible = True
        Joystick1UDTrackBar.Visible = True
        Joystick1PictureBox.Visible = True
        DrawJoystick1(128, 128)
    End Sub
    'Joystick 2
    Private Sub Joy2ToggleLeftRightDataMenuItem_Click(sender As Object, e As EventArgs) Handles Joy2ToggleLeftRightDataMenuItem.Click
        If Joystick2LRLabel.Visible = True Then
            Joystick2LRLabel.Visible = False
        Else
            Joystick2LRLabel.Visible = True
        End If
    End Sub
    Private Sub Joy2ToggleLeftRightTrackBarMenuItem_Click(sender As Object, e As EventArgs) Handles Joy2ToggleLeftRightTrackBarMenuItem.Click
        If Joystick2LRTrackBar.Visible = True Then
            Joystick2LRTrackBar.Visible = False
        Else
            Joystick2LRTrackBar.Visible = True
        End If
    End Sub
    Private Sub Joy2ToggleUpDownDataMenuItem_Click(sender As Object, e As EventArgs) Handles Joy2ToggleUpDownDataMenuItem.Click
        If Joystick2UDLabel.Visible = True Then
            Joystick2UDLabel.Visible = False
        Else
            Joystick2UDLabel.Visible = True
        End If
    End Sub
    Private Sub Joy2ToggleUpDownTrackBarMenuItem_Click(sender As Object, e As EventArgs) Handles Joy2ToggleUpDownTrackBarMenuItem.Click
        If Joystick2UDTrackBar.Visible = True Then
            Joystick2UDTrackBar.Visible = False
        Else
            Joystick2UDTrackBar.Visible = True
        End If
    End Sub
    Private Sub Joy2TogglePositionGraphMenuItem_Click(sender As Object, e As EventArgs) Handles Joy2TogglePositionGraphMenuItem.Click
        If Joystick2PictureBox.Visible = True Then
            Joystick2PictureBox.Visible = False
        Else
            Joystick2PictureBox.Visible = True
            DrawJoystick2(128, 128)
        End If
    End Sub
    Private Sub Joy2ChangePositionDotColorMenuItem_Click(sender As Object, e As EventArgs) Handles Joy2ChangePositionDotColorMenuItem.Click
        ColorDialog.ShowDialog()
        Dim tempBrush As New SolidBrush(ColorDialog.Color)
        joy2PosColor = tempBrush
        DrawJoystick2(128, 128)
    End Sub
    Private Sub Joy2SetDefaultJoystickDisplayMenuItem_Click(sender As Object, e As EventArgs) Handles Joy2SetDefaultJoystickDisplayMenuItem.Click
        Dim tempBrush As New SolidBrush(Roarange)
        joy2PosColor = tempBrush
        Joystick2LRLabel.Visible = True
        Joystick2LRTrackBar.Visible = True
        Joystick2UDLabel.Visible = True
        Joystick2UDTrackBar.Visible = True
        Joystick2PictureBox.Visible = True
        DrawJoystick2(128, 128)
    End Sub
    'Joystick 3
    Private Sub Joy3ToggleLeftRightDataMenuItem_Click(sender As Object, e As EventArgs) Handles Joy3ToggleLeftRightDataMenuItem.Click
        If Joystick3LRLabel.Visible = True Then
            Joystick3LRLabel.Visible = False
        Else
            Joystick3LRLabel.Visible = True
        End If
    End Sub
    Private Sub Joy3ToggleLeftRightTrackBarMenuItem_Click(sender As Object, e As EventArgs) Handles Joy3ToggleLeftRightTrackBarMenuItem.Click
        If Joystick3LRTrackBar.Visible = True Then
            Joystick3LRTrackBar.Visible = False
        Else
            Joystick3LRTrackBar.Visible = True
        End If
    End Sub
    Private Sub Joy3ToggleUpDownDataMenuItem_Click(sender As Object, e As EventArgs) Handles Joy3ToggleUpDownDataMenuItem.Click
        If Joystick3UDLabel.Visible = True Then
            Joystick3UDLabel.Visible = False
        Else
            Joystick3UDLabel.Visible = True
        End If
    End Sub
    Private Sub Joy3ToggleUpDownTrackBarMenuItem_Click(sender As Object, e As EventArgs) Handles Joy3ToggleUpDownTrackBarMenuItem.Click
        If Joystick3UDTrackBar.Visible = True Then
            Joystick3UDTrackBar.Visible = False
        Else
            Joystick3UDTrackBar.Visible = True
        End If
    End Sub
    Private Sub Joy3TogglePositionGraphMenuItem_Click(sender As Object, e As EventArgs) Handles Joy3TogglePositionGraphMenuItem.Click
        If Joystick3PictureBox.Visible = True Then
            Joystick3PictureBox.Visible = False
        Else
            Joystick3PictureBox.Visible = True
            DrawJoystick3(128, 128)
        End If
    End Sub
    Private Sub Joy3ChangePositionDotColorMenuItem_Click(sender As Object, e As EventArgs) Handles Joy3ChangePositionDotColorMenuItem.Click
        ColorDialog.ShowDialog()
        Dim tempBrush As New SolidBrush(ColorDialog.Color)
        joy3PosColor = tempBrush
        DrawJoystick3(128, 128)
    End Sub
    Private Sub Joy3SetDefaultJoystickDisplayMenuItem_Click(sender As Object, e As EventArgs) Handles Joy3SetDefaultJoystickDisplayMenuItem.Click
        Dim tempBrush As New SolidBrush(Roarange)
        joy3PosColor = tempBrush
        Joystick3LRLabel.Visible = True
        Joystick3LRTrackBar.Visible = True
        Joystick3UDLabel.Visible = True
        Joystick3UDTrackBar.Visible = True
        Joystick3PictureBox.Visible = True
        DrawJoystick3(128, 128)
    End Sub

    '************************Change Button Colors*********************************************************
    Private Sub ChangeButtonOffColorMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeButtonOffColorMenuItem.Click
        ColorDialog.ShowDialog()
        buttonOffColor = ColorDialog.Color
        TestButtons()
    End Sub
    Private Sub ChangeButtonOnColorMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeButtonOnColorMenuItem.Click
        ColorDialog.ShowDialog()
        buttonOnColor = ColorDialog.Color
        TestButtons()
    End Sub
    Private Sub SetDefaultButtonColorsMenuItem_Click(sender As Object, e As EventArgs) Handles SetDefaultButtonColorsMenuItem.Click
        buttonOnColor = Roarange
        buttonOffColor = Color.Gray
        TestButtons()
    End Sub
    '************************Change Background Image*********************************************************
    Private Sub PCBBackgroundMenuItem_Click(sender As Object, e As EventArgs) Handles PCBBackgroundMenuItem.Click
        PCBBackgroundPictureBox.Visible = True
        CaseBackgroundPictureBox.Visible = False
        ISULogoPictureBox.Visible = False
    End Sub
    Private Sub NoneBackroundMenuItem_Click(sender As Object, e As EventArgs) Handles NoneBackroundMenuItem.Click
        PCBBackgroundPictureBox.Visible = False
        CaseBackgroundPictureBox.Visible = False
        ISULogoPictureBox.Visible = True
    End Sub
    Private Sub CaseBackgroundMenuItem_Click(sender As Object, e As EventArgs) Handles CaseBackgroundMenuItem.Click
        CaseBackgroundPictureBox.Visible = True
        PCBBackgroundPictureBox.Visible = False
        ISULogoPictureBox.Visible = False
    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        Dim currentTime As String
        currentTime = FormatDateTime(TimeOfDay)
        ClockStatusStripLabel.Text = currentTime
    End Sub

    Private Sub RefreshToolStripButton_Click(sender As Object, e As EventArgs) Handles RefreshToolStripButton.Click
        PopulateCOMSelect()
    End Sub
End Class
