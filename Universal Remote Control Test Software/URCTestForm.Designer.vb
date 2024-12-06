<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class URCTestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.COMSelectToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConnectCOMToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisconnetToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.COMSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SerialCOMTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Joystick1UDLabel = New System.Windows.Forms.Label()
        Me.Joystick1LRLabel = New System.Windows.Forms.Label()
        Me.Joystick2LRLabel = New System.Windows.Forms.Label()
        Me.Joystick2UDLabel = New System.Windows.Forms.Label()
        Me.Joystick3LRLabel = New System.Windows.Forms.Label()
        Me.Joystick3UDLabel = New System.Windows.Forms.Label()
        Me.RobotAddressLabel = New System.Windows.Forms.Label()
        Me.Joystick1LRTrackBar = New System.Windows.Forms.TrackBar()
        Me.Joystick1UDTrackBar = New System.Windows.Forms.TrackBar()
        Me.Joystick2LRTrackBar = New System.Windows.Forms.TrackBar()
        Me.Joystick2UDTrackBar = New System.Windows.Forms.TrackBar()
        Me.Joystick3LRTrackBar = New System.Windows.Forms.TrackBar()
        Me.Joystick3UDTrackBar = New System.Windows.Forms.TrackBar()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.Joystick1Label = New System.Windows.Forms.Label()
        Me.Joystick2Label = New System.Windows.Forms.Label()
        Me.Joystick3Label = New System.Windows.Forms.Label()
        Me.Button1Indicator = New System.Windows.Forms.Button()
        Me.Button1Label = New System.Windows.Forms.Label()
        Me.Button2Label = New System.Windows.Forms.Label()
        Me.Button2Indicator = New System.Windows.Forms.Button()
        Me.Button3Label = New System.Windows.Forms.Label()
        Me.Button3Indicator = New System.Windows.Forms.Button()
        Me.Button4Label = New System.Windows.Forms.Label()
        Me.Button4Indicator = New System.Windows.Forms.Button()
        Me.LeftBumperLabel = New System.Windows.Forms.Label()
        Me.LeftBumperIndicatorButton = New System.Windows.Forms.Button()
        Me.RightBumperLabel = New System.Windows.Forms.Label()
        Me.RightBumperIndicatorButton = New System.Windows.Forms.Button()
        Me.Joystick1ButtonLabel = New System.Windows.Forms.Label()
        Me.Joystick1IndicatorButton = New System.Windows.Forms.Button()
        Me.Joystick2ButtonLabel = New System.Windows.Forms.Label()
        Me.Joystick2IndicatorButton = New System.Windows.Forms.Button()
        Me.Joystick3ButtonLabel = New System.Windows.Forms.Label()
        Me.Joystick3IndicatorButton = New System.Windows.Forms.Button()
        Me.Joystick1PictureBox = New System.Windows.Forms.PictureBox()
        Me.StartUpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Joystick2PictureBox = New System.Windows.Forms.PictureBox()
        Me.Joystick3PictureBox = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Joystick1LRTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick1UDTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick2LRTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick2UDTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick3LRTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick3UDTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMSelectToolStripComboBox, Me.ToolStripSeparator1, Me.ConnectCOMToolStripButton, Me.ToolStripSeparator2, Me.DisconnetToolStripButton, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(880, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'COMSelectToolStripComboBox
        '
        Me.COMSelectToolStripComboBox.Name = "COMSelectToolStripComboBox"
        Me.COMSelectToolStripComboBox.Size = New System.Drawing.Size(121, 28)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ConnectCOMToolStripButton
        '
        Me.ConnectCOMToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ConnectCOMToolStripButton.Image = Global.Universal_Remote_Control_Test_Software.My.Resources.Resources.icons8_usb_connector_30
        Me.ConnectCOMToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ConnectCOMToolStripButton.Name = "ConnectCOMToolStripButton"
        Me.ConnectCOMToolStripButton.Size = New System.Drawing.Size(29, 25)
        Me.ConnectCOMToolStripButton.Text = "ToolStripButton1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'DisconnetToolStripButton
        '
        Me.DisconnetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DisconnetToolStripButton.Image = Global.Universal_Remote_Control_Test_Software.My.Resources.Resources.icons8_disconnect_30
        Me.DisconnetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DisconnetToolStripButton.Name = "DisconnetToolStripButton"
        Me.DisconnetToolStripButton.Size = New System.Drawing.Size(29, 25)
        Me.DisconnetToolStripButton.Text = "ToolStripButton1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'COMSerialPort
        '
        Me.COMSerialPort.ReadTimeout = 250
        Me.COMSerialPort.WriteTimeout = 250
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(778, 501)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(90, 52)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SerialCOMTimer
        '
        '
        'Joystick1UDLabel
        '
        Me.Joystick1UDLabel.AutoSize = True
        Me.Joystick1UDLabel.Location = New System.Drawing.Point(371, 446)
        Me.Joystick1UDLabel.Name = "Joystick1UDLabel"
        Me.Joystick1UDLabel.Size = New System.Drawing.Size(94, 17)
        Me.Joystick1UDLabel.TabIndex = 2
        Me.Joystick1UDLabel.Text = "Joystick 1 UD"
        '
        'Joystick1LRLabel
        '
        Me.Joystick1LRLabel.AutoSize = True
        Me.Joystick1LRLabel.Location = New System.Drawing.Point(259, 353)
        Me.Joystick1LRLabel.Name = "Joystick1LRLabel"
        Me.Joystick1LRLabel.Size = New System.Drawing.Size(92, 17)
        Me.Joystick1LRLabel.TabIndex = 3
        Me.Joystick1LRLabel.Text = "Joystick 1 LR"
        Me.Joystick1LRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Joystick2LRLabel
        '
        Me.Joystick2LRLabel.AutoSize = True
        Me.Joystick2LRLabel.Location = New System.Drawing.Point(542, 357)
        Me.Joystick2LRLabel.Name = "Joystick2LRLabel"
        Me.Joystick2LRLabel.Size = New System.Drawing.Size(92, 17)
        Me.Joystick2LRLabel.TabIndex = 5
        Me.Joystick2LRLabel.Text = "Joystick 2 LR"
        Me.Joystick2LRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Joystick2UDLabel
        '
        Me.Joystick2UDLabel.AutoSize = True
        Me.Joystick2UDLabel.Location = New System.Drawing.Point(649, 451)
        Me.Joystick2UDLabel.Name = "Joystick2UDLabel"
        Me.Joystick2UDLabel.Size = New System.Drawing.Size(94, 17)
        Me.Joystick2UDLabel.TabIndex = 4
        Me.Joystick2UDLabel.Text = "Joystick 2 UD"
        '
        'Joystick3LRLabel
        '
        Me.Joystick3LRLabel.AutoSize = True
        Me.Joystick3LRLabel.Location = New System.Drawing.Point(666, 123)
        Me.Joystick3LRLabel.Name = "Joystick3LRLabel"
        Me.Joystick3LRLabel.Size = New System.Drawing.Size(92, 17)
        Me.Joystick3LRLabel.TabIndex = 7
        Me.Joystick3LRLabel.Text = "Joystick 3 LR"
        Me.Joystick3LRLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Joystick3UDLabel
        '
        Me.Joystick3UDLabel.AutoSize = True
        Me.Joystick3UDLabel.Location = New System.Drawing.Point(774, 220)
        Me.Joystick3UDLabel.Name = "Joystick3UDLabel"
        Me.Joystick3UDLabel.Size = New System.Drawing.Size(94, 17)
        Me.Joystick3UDLabel.TabIndex = 6
        Me.Joystick3UDLabel.Text = "Joystick 3 UD"
        '
        'RobotAddressLabel
        '
        Me.RobotAddressLabel.AutoSize = True
        Me.RobotAddressLabel.Location = New System.Drawing.Point(394, 52)
        Me.RobotAddressLabel.Name = "RobotAddressLabel"
        Me.RobotAddressLabel.Size = New System.Drawing.Size(102, 17)
        Me.RobotAddressLabel.TabIndex = 8
        Me.RobotAddressLabel.Text = "Robot Address"
        Me.RobotAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Joystick1LRTrackBar
        '
        Me.Joystick1LRTrackBar.Location = New System.Drawing.Point(225, 368)
        Me.Joystick1LRTrackBar.Maximum = 255
        Me.Joystick1LRTrackBar.Name = "Joystick1LRTrackBar"
        Me.Joystick1LRTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick1LRTrackBar.Size = New System.Drawing.Size(110, 56)
        Me.Joystick1LRTrackBar.TabIndex = 9
        Me.Joystick1LRTrackBar.TabStop = False
        '
        'Joystick1UDTrackBar
        '
        Me.Joystick1UDTrackBar.Location = New System.Drawing.Point(332, 404)
        Me.Joystick1UDTrackBar.Maximum = 255
        Me.Joystick1UDTrackBar.Name = "Joystick1UDTrackBar"
        Me.Joystick1UDTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Joystick1UDTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick1UDTrackBar.Size = New System.Drawing.Size(56, 110)
        Me.Joystick1UDTrackBar.TabIndex = 10
        Me.Joystick1UDTrackBar.TabStop = False
        Me.Joystick1UDTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Joystick2LRTrackBar
        '
        Me.Joystick2LRTrackBar.Location = New System.Drawing.Point(510, 373)
        Me.Joystick2LRTrackBar.Maximum = 255
        Me.Joystick2LRTrackBar.Name = "Joystick2LRTrackBar"
        Me.Joystick2LRTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick2LRTrackBar.Size = New System.Drawing.Size(110, 56)
        Me.Joystick2LRTrackBar.TabIndex = 11
        Me.Joystick2LRTrackBar.TabStop = False
        '
        'Joystick2UDTrackBar
        '
        Me.Joystick2UDTrackBar.Location = New System.Drawing.Point(613, 403)
        Me.Joystick2UDTrackBar.Maximum = 255
        Me.Joystick2UDTrackBar.Name = "Joystick2UDTrackBar"
        Me.Joystick2UDTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Joystick2UDTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick2UDTrackBar.Size = New System.Drawing.Size(56, 110)
        Me.Joystick2UDTrackBar.TabIndex = 12
        Me.Joystick2UDTrackBar.TabStop = False
        Me.Joystick2UDTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Joystick3LRTrackBar
        '
        Me.Joystick3LRTrackBar.Location = New System.Drawing.Point(635, 139)
        Me.Joystick3LRTrackBar.Maximum = 255
        Me.Joystick3LRTrackBar.Name = "Joystick3LRTrackBar"
        Me.Joystick3LRTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick3LRTrackBar.Size = New System.Drawing.Size(110, 56)
        Me.Joystick3LRTrackBar.TabIndex = 13
        Me.Joystick3LRTrackBar.TabStop = False
        '
        'Joystick3UDTrackBar
        '
        Me.Joystick3UDTrackBar.Location = New System.Drawing.Point(737, 173)
        Me.Joystick3UDTrackBar.Maximum = 255
        Me.Joystick3UDTrackBar.Name = "Joystick3UDTrackBar"
        Me.Joystick3UDTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Joystick3UDTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick3UDTrackBar.Size = New System.Drawing.Size(56, 110)
        Me.Joystick3UDTrackBar.TabIndex = 14
        Me.Joystick3UDTrackBar.TabStop = False
        Me.Joystick3UDTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.Location = New System.Drawing.Point(351, 30)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(120, 20)
        Me.AddressLabel.TabIndex = 15
        Me.AddressLabel.Text = "Robot Address"
        Me.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Joystick1Label
        '
        Me.Joystick1Label.AutoSize = True
        Me.Joystick1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Joystick1Label.Location = New System.Drawing.Point(230, 328)
        Me.Joystick1Label.Name = "Joystick1Label"
        Me.Joystick1Label.Size = New System.Drawing.Size(84, 20)
        Me.Joystick1Label.TabIndex = 16
        Me.Joystick1Label.Text = "Joystick 1"
        '
        'Joystick2Label
        '
        Me.Joystick2Label.AutoSize = True
        Me.Joystick2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Joystick2Label.Location = New System.Drawing.Point(510, 333)
        Me.Joystick2Label.Name = "Joystick2Label"
        Me.Joystick2Label.Size = New System.Drawing.Size(84, 20)
        Me.Joystick2Label.TabIndex = 17
        Me.Joystick2Label.Text = "Joystick 2"
        '
        'Joystick3Label
        '
        Me.Joystick3Label.AutoSize = True
        Me.Joystick3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Joystick3Label.Location = New System.Drawing.Point(634, 99)
        Me.Joystick3Label.Name = "Joystick3Label"
        Me.Joystick3Label.Size = New System.Drawing.Size(84, 20)
        Me.Joystick3Label.TabIndex = 18
        Me.Joystick3Label.Text = "Joystick 3"
        '
        'Button1Indicator
        '
        Me.Button1Indicator.BackColor = System.Drawing.Color.Gray
        Me.Button1Indicator.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1Indicator.Location = New System.Drawing.Point(158, 230)
        Me.Button1Indicator.Name = "Button1Indicator"
        Me.Button1Indicator.Size = New System.Drawing.Size(17, 19)
        Me.Button1Indicator.TabIndex = 19
        Me.Button1Indicator.UseVisualStyleBackColor = False
        '
        'Button1Label
        '
        Me.Button1Label.AutoSize = True
        Me.Button1Label.Location = New System.Drawing.Point(137, 252)
        Me.Button1Label.Name = "Button1Label"
        Me.Button1Label.Size = New System.Drawing.Size(61, 17)
        Me.Button1Label.TabIndex = 20
        Me.Button1Label.Text = "Button 1"
        '
        'Button2Label
        '
        Me.Button2Label.AutoSize = True
        Me.Button2Label.Location = New System.Drawing.Point(188, 208)
        Me.Button2Label.Name = "Button2Label"
        Me.Button2Label.Size = New System.Drawing.Size(61, 17)
        Me.Button2Label.TabIndex = 22
        Me.Button2Label.Text = "Button 2"
        '
        'Button2Indicator
        '
        Me.Button2Indicator.BackColor = System.Drawing.Color.Gray
        Me.Button2Indicator.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2Indicator.Location = New System.Drawing.Point(209, 186)
        Me.Button2Indicator.Name = "Button2Indicator"
        Me.Button2Indicator.Size = New System.Drawing.Size(17, 19)
        Me.Button2Indicator.TabIndex = 21
        Me.Button2Indicator.UseVisualStyleBackColor = False
        '
        'Button3Label
        '
        Me.Button3Label.AutoSize = True
        Me.Button3Label.Location = New System.Drawing.Point(91, 208)
        Me.Button3Label.Name = "Button3Label"
        Me.Button3Label.Size = New System.Drawing.Size(61, 17)
        Me.Button3Label.TabIndex = 24
        Me.Button3Label.Text = "Button 3"
        '
        'Button3Indicator
        '
        Me.Button3Indicator.BackColor = System.Drawing.Color.Gray
        Me.Button3Indicator.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3Indicator.Location = New System.Drawing.Point(112, 186)
        Me.Button3Indicator.Name = "Button3Indicator"
        Me.Button3Indicator.Size = New System.Drawing.Size(17, 19)
        Me.Button3Indicator.TabIndex = 23
        Me.Button3Indicator.UseVisualStyleBackColor = False
        '
        'Button4Label
        '
        Me.Button4Label.AutoSize = True
        Me.Button4Label.Location = New System.Drawing.Point(137, 161)
        Me.Button4Label.Name = "Button4Label"
        Me.Button4Label.Size = New System.Drawing.Size(61, 17)
        Me.Button4Label.TabIndex = 26
        Me.Button4Label.Text = "Button 4"
        '
        'Button4Indicator
        '
        Me.Button4Indicator.BackColor = System.Drawing.Color.Gray
        Me.Button4Indicator.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4Indicator.Location = New System.Drawing.Point(158, 139)
        Me.Button4Indicator.Name = "Button4Indicator"
        Me.Button4Indicator.Size = New System.Drawing.Size(17, 19)
        Me.Button4Indicator.TabIndex = 25
        Me.Button4Indicator.UseVisualStyleBackColor = False
        '
        'LeftBumperLabel
        '
        Me.LeftBumperLabel.AutoSize = True
        Me.LeftBumperLabel.Location = New System.Drawing.Point(34, 86)
        Me.LeftBumperLabel.Name = "LeftBumperLabel"
        Me.LeftBumperLabel.Size = New System.Drawing.Size(85, 17)
        Me.LeftBumperLabel.TabIndex = 28
        Me.LeftBumperLabel.Text = "Left Bumper"
        '
        'LeftBumperIndicatorButton
        '
        Me.LeftBumperIndicatorButton.BackColor = System.Drawing.Color.Gray
        Me.LeftBumperIndicatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LeftBumperIndicatorButton.Location = New System.Drawing.Point(65, 64)
        Me.LeftBumperIndicatorButton.Name = "LeftBumperIndicatorButton"
        Me.LeftBumperIndicatorButton.Size = New System.Drawing.Size(17, 19)
        Me.LeftBumperIndicatorButton.TabIndex = 27
        Me.LeftBumperIndicatorButton.UseVisualStyleBackColor = False
        '
        'RightBumperLabel
        '
        Me.RightBumperLabel.AutoSize = True
        Me.RightBumperLabel.Location = New System.Drawing.Point(777, 72)
        Me.RightBumperLabel.Name = "RightBumperLabel"
        Me.RightBumperLabel.Size = New System.Drawing.Size(94, 17)
        Me.RightBumperLabel.TabIndex = 30
        Me.RightBumperLabel.Text = "Right Bumper"
        '
        'RightBumperIndicatorButton
        '
        Me.RightBumperIndicatorButton.BackColor = System.Drawing.Color.Gray
        Me.RightBumperIndicatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RightBumperIndicatorButton.Location = New System.Drawing.Point(814, 50)
        Me.RightBumperIndicatorButton.Name = "RightBumperIndicatorButton"
        Me.RightBumperIndicatorButton.Size = New System.Drawing.Size(17, 19)
        Me.RightBumperIndicatorButton.TabIndex = 29
        Me.RightBumperIndicatorButton.UseVisualStyleBackColor = False
        '
        'Joystick1ButtonLabel
        '
        Me.Joystick1ButtonLabel.AutoSize = True
        Me.Joystick1ButtonLabel.Location = New System.Drawing.Point(236, 540)
        Me.Joystick1ButtonLabel.Name = "Joystick1ButtonLabel"
        Me.Joystick1ButtonLabel.Size = New System.Drawing.Size(115, 17)
        Me.Joystick1ButtonLabel.TabIndex = 32
        Me.Joystick1ButtonLabel.Text = "Joystick 1 Button"
        '
        'Joystick1IndicatorButton
        '
        Me.Joystick1IndicatorButton.BackColor = System.Drawing.Color.Gray
        Me.Joystick1IndicatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Joystick1IndicatorButton.Location = New System.Drawing.Point(273, 518)
        Me.Joystick1IndicatorButton.Name = "Joystick1IndicatorButton"
        Me.Joystick1IndicatorButton.Size = New System.Drawing.Size(17, 19)
        Me.Joystick1IndicatorButton.TabIndex = 31
        Me.Joystick1IndicatorButton.UseVisualStyleBackColor = False
        '
        'Joystick2ButtonLabel
        '
        Me.Joystick2ButtonLabel.AutoSize = True
        Me.Joystick2ButtonLabel.Location = New System.Drawing.Point(511, 540)
        Me.Joystick2ButtonLabel.Name = "Joystick2ButtonLabel"
        Me.Joystick2ButtonLabel.Size = New System.Drawing.Size(115, 17)
        Me.Joystick2ButtonLabel.TabIndex = 34
        Me.Joystick2ButtonLabel.Text = "Joystick 2 Button"
        '
        'Joystick2IndicatorButton
        '
        Me.Joystick2IndicatorButton.BackColor = System.Drawing.Color.Gray
        Me.Joystick2IndicatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Joystick2IndicatorButton.Location = New System.Drawing.Point(555, 518)
        Me.Joystick2IndicatorButton.Name = "Joystick2IndicatorButton"
        Me.Joystick2IndicatorButton.Size = New System.Drawing.Size(17, 19)
        Me.Joystick2IndicatorButton.TabIndex = 33
        Me.Joystick2IndicatorButton.UseVisualStyleBackColor = False
        '
        'Joystick3ButtonLabel
        '
        Me.Joystick3ButtonLabel.AutoSize = True
        Me.Joystick3ButtonLabel.Location = New System.Drawing.Point(635, 297)
        Me.Joystick3ButtonLabel.Name = "Joystick3ButtonLabel"
        Me.Joystick3ButtonLabel.Size = New System.Drawing.Size(115, 17)
        Me.Joystick3ButtonLabel.TabIndex = 36
        Me.Joystick3ButtonLabel.Text = "Joystick 3 Button"
        '
        'Joystick3IndicatorButton
        '
        Me.Joystick3IndicatorButton.BackColor = System.Drawing.Color.Gray
        Me.Joystick3IndicatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Joystick3IndicatorButton.Location = New System.Drawing.Point(678, 275)
        Me.Joystick3IndicatorButton.Name = "Joystick3IndicatorButton"
        Me.Joystick3IndicatorButton.Size = New System.Drawing.Size(17, 19)
        Me.Joystick3IndicatorButton.TabIndex = 35
        Me.Joystick3IndicatorButton.UseVisualStyleBackColor = False
        '
        'Joystick1PictureBox
        '
        Me.Joystick1PictureBox.Location = New System.Drawing.Point(234, 412)
        Me.Joystick1PictureBox.Name = "Joystick1PictureBox"
        Me.Joystick1PictureBox.Size = New System.Drawing.Size(85, 85)
        Me.Joystick1PictureBox.TabIndex = 37
        Me.Joystick1PictureBox.TabStop = False
        '
        'StartUpTimer
        '
        Me.StartUpTimer.Interval = 1
        '
        'Joystick2PictureBox
        '
        Me.Joystick2PictureBox.Location = New System.Drawing.Point(522, 412)
        Me.Joystick2PictureBox.Name = "Joystick2PictureBox"
        Me.Joystick2PictureBox.Size = New System.Drawing.Size(85, 85)
        Me.Joystick2PictureBox.TabIndex = 38
        Me.Joystick2PictureBox.TabStop = False
        '
        'Joystick3PictureBox
        '
        Me.Joystick3PictureBox.Location = New System.Drawing.Point(646, 184)
        Me.Joystick3PictureBox.Name = "Joystick3PictureBox"
        Me.Joystick3PictureBox.Size = New System.Drawing.Size(85, 85)
        Me.Joystick3PictureBox.TabIndex = 39
        Me.Joystick3PictureBox.TabStop = False
        '
        'URCTestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 565)
        Me.Controls.Add(Me.Joystick3PictureBox)
        Me.Controls.Add(Me.Joystick2PictureBox)
        Me.Controls.Add(Me.Joystick1PictureBox)
        Me.Controls.Add(Me.Joystick3ButtonLabel)
        Me.Controls.Add(Me.Joystick3IndicatorButton)
        Me.Controls.Add(Me.Joystick2ButtonLabel)
        Me.Controls.Add(Me.Joystick2IndicatorButton)
        Me.Controls.Add(Me.Joystick1ButtonLabel)
        Me.Controls.Add(Me.Joystick1IndicatorButton)
        Me.Controls.Add(Me.RightBumperLabel)
        Me.Controls.Add(Me.RightBumperIndicatorButton)
        Me.Controls.Add(Me.LeftBumperLabel)
        Me.Controls.Add(Me.LeftBumperIndicatorButton)
        Me.Controls.Add(Me.Button4Label)
        Me.Controls.Add(Me.Button4Indicator)
        Me.Controls.Add(Me.Button3Label)
        Me.Controls.Add(Me.Button3Indicator)
        Me.Controls.Add(Me.Button2Label)
        Me.Controls.Add(Me.Button2Indicator)
        Me.Controls.Add(Me.Button1Label)
        Me.Controls.Add(Me.Button1Indicator)
        Me.Controls.Add(Me.Joystick3Label)
        Me.Controls.Add(Me.Joystick2Label)
        Me.Controls.Add(Me.Joystick1Label)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.Joystick3UDLabel)
        Me.Controls.Add(Me.Joystick3UDTrackBar)
        Me.Controls.Add(Me.Joystick3LRTrackBar)
        Me.Controls.Add(Me.Joystick2UDLabel)
        Me.Controls.Add(Me.Joystick2UDTrackBar)
        Me.Controls.Add(Me.Joystick2LRTrackBar)
        Me.Controls.Add(Me.Joystick1UDLabel)
        Me.Controls.Add(Me.Joystick1UDTrackBar)
        Me.Controls.Add(Me.Joystick1LRTrackBar)
        Me.Controls.Add(Me.RobotAddressLabel)
        Me.Controls.Add(Me.Joystick3LRLabel)
        Me.Controls.Add(Me.Joystick2LRLabel)
        Me.Controls.Add(Me.Joystick1LRLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "URCTestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Universal Remote Controller Testing"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Joystick1LRTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick1UDTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick2LRTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick2UDTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick3LRTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick3UDTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents COMSelectToolStripComboBox As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ConnectCOMToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DisconnetToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents COMSerialPort As IO.Ports.SerialPort
    Friend WithEvents ExitButton As Button
    Friend WithEvents SerialCOMTimer As Timer
    Friend WithEvents Joystick1UDLabel As Label
    Friend WithEvents Joystick1LRLabel As Label
    Friend WithEvents Joystick2LRLabel As Label
    Friend WithEvents Joystick2UDLabel As Label
    Friend WithEvents Joystick3LRLabel As Label
    Friend WithEvents Joystick3UDLabel As Label
    Friend WithEvents RobotAddressLabel As Label
    Friend WithEvents Joystick1LRTrackBar As TrackBar
    Friend WithEvents Joystick1UDTrackBar As TrackBar
    Friend WithEvents Joystick2LRTrackBar As TrackBar
    Friend WithEvents Joystick2UDTrackBar As TrackBar
    Friend WithEvents Joystick3LRTrackBar As TrackBar
    Friend WithEvents Joystick3UDTrackBar As TrackBar
    Friend WithEvents AddressLabel As Label
    Friend WithEvents Joystick1Label As Label
    Friend WithEvents Joystick2Label As Label
    Friend WithEvents Joystick3Label As Label
    Friend WithEvents Button1Indicator As Button
    Friend WithEvents Button1Label As Label
    Friend WithEvents Button2Label As Label
    Friend WithEvents Button2Indicator As Button
    Friend WithEvents Button3Label As Label
    Friend WithEvents Button3Indicator As Button
    Friend WithEvents Button4Label As Label
    Friend WithEvents Button4Indicator As Button
    Friend WithEvents LeftBumperLabel As Label
    Friend WithEvents LeftBumperIndicatorButton As Button
    Friend WithEvents RightBumperLabel As Label
    Friend WithEvents RightBumperIndicatorButton As Button
    Friend WithEvents Joystick1ButtonLabel As Label
    Friend WithEvents Joystick1IndicatorButton As Button
    Friend WithEvents Joystick2ButtonLabel As Label
    Friend WithEvents Joystick2IndicatorButton As Button
    Friend WithEvents Joystick3ButtonLabel As Label
    Friend WithEvents Joystick3IndicatorButton As Button
    Friend WithEvents Joystick1PictureBox As PictureBox
    Friend WithEvents StartUpTimer As Timer
    Friend WithEvents Joystick2PictureBox As PictureBox
    Friend WithEvents Joystick3PictureBox As PictureBox
End Class
