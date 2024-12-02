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
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Joystick1LRTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick1UDTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick2LRTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick2UDTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick3LRTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Joystick3UDTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMSelectToolStripComboBox, Me.ToolStripSeparator1, Me.ConnectCOMToolStripButton, Me.ToolStripSeparator2, Me.DisconnetToolStripButton, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 28)
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
        Me.ExitButton.Location = New System.Drawing.Point(694, 387)
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
        Me.Joystick1UDLabel.Location = New System.Drawing.Point(255, 341)
        Me.Joystick1UDLabel.Name = "Joystick1UDLabel"
        Me.Joystick1UDLabel.Size = New System.Drawing.Size(94, 17)
        Me.Joystick1UDLabel.TabIndex = 2
        Me.Joystick1UDLabel.Text = "Joystick 1 UD"
        '
        'Joystick1LRLabel
        '
        Me.Joystick1LRLabel.AutoSize = True
        Me.Joystick1LRLabel.Location = New System.Drawing.Point(115, 243)
        Me.Joystick1LRLabel.Name = "Joystick1LRLabel"
        Me.Joystick1LRLabel.Size = New System.Drawing.Size(92, 17)
        Me.Joystick1LRLabel.TabIndex = 3
        Me.Joystick1LRLabel.Text = "Joystick 1 LR"
        '
        'Joystick2LRLabel
        '
        Me.Joystick2LRLabel.AutoSize = True
        Me.Joystick2LRLabel.Location = New System.Drawing.Point(453, 243)
        Me.Joystick2LRLabel.Name = "Joystick2LRLabel"
        Me.Joystick2LRLabel.Size = New System.Drawing.Size(92, 17)
        Me.Joystick2LRLabel.TabIndex = 5
        Me.Joystick2LRLabel.Text = "Joystick 2 LR"
        '
        'Joystick2UDLabel
        '
        Me.Joystick2UDLabel.AutoSize = True
        Me.Joystick2UDLabel.Location = New System.Drawing.Point(591, 341)
        Me.Joystick2UDLabel.Name = "Joystick2UDLabel"
        Me.Joystick2UDLabel.Size = New System.Drawing.Size(94, 17)
        Me.Joystick2UDLabel.TabIndex = 4
        Me.Joystick2UDLabel.Text = "Joystick 2 UD"
        '
        'Joystick3LRLabel
        '
        Me.Joystick3LRLabel.AutoSize = True
        Me.Joystick3LRLabel.Location = New System.Drawing.Point(554, 65)
        Me.Joystick3LRLabel.Name = "Joystick3LRLabel"
        Me.Joystick3LRLabel.Size = New System.Drawing.Size(92, 17)
        Me.Joystick3LRLabel.TabIndex = 7
        Me.Joystick3LRLabel.Text = "Joystick 3 LR"
        '
        'Joystick3UDLabel
        '
        Me.Joystick3UDLabel.AutoSize = True
        Me.Joystick3UDLabel.Location = New System.Drawing.Point(693, 166)
        Me.Joystick3UDLabel.Name = "Joystick3UDLabel"
        Me.Joystick3UDLabel.Size = New System.Drawing.Size(94, 17)
        Me.Joystick3UDLabel.TabIndex = 6
        Me.Joystick3UDLabel.Text = "Joystick 3 UD"
        '
        'RobotAddressLabel
        '
        Me.RobotAddressLabel.AutoSize = True
        Me.RobotAddressLabel.Location = New System.Drawing.Point(365, 50)
        Me.RobotAddressLabel.Name = "RobotAddressLabel"
        Me.RobotAddressLabel.Size = New System.Drawing.Size(95, 17)
        Me.RobotAddressLabel.TabIndex = 8
        Me.RobotAddressLabel.Text = "Robot Addres"
        '
        'Joystick1LRTrackBar
        '
        Me.Joystick1LRTrackBar.Location = New System.Drawing.Point(109, 263)
        Me.Joystick1LRTrackBar.Maximum = 255
        Me.Joystick1LRTrackBar.Name = "Joystick1LRTrackBar"
        Me.Joystick1LRTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick1LRTrackBar.Size = New System.Drawing.Size(101, 56)
        Me.Joystick1LRTrackBar.TabIndex = 9
        Me.Joystick1LRTrackBar.TabStop = False
        '
        'Joystick1UDTrackBar
        '
        Me.Joystick1UDTrackBar.Location = New System.Drawing.Point(216, 302)
        Me.Joystick1UDTrackBar.Maximum = 255
        Me.Joystick1UDTrackBar.Name = "Joystick1UDTrackBar"
        Me.Joystick1UDTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Joystick1UDTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick1UDTrackBar.Size = New System.Drawing.Size(56, 101)
        Me.Joystick1UDTrackBar.TabIndex = 10
        Me.Joystick1UDTrackBar.TabStop = False
        Me.Joystick1UDTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Joystick2LRTrackBar
        '
        Me.Joystick2LRTrackBar.Location = New System.Drawing.Point(448, 263)
        Me.Joystick2LRTrackBar.Maximum = 255
        Me.Joystick2LRTrackBar.Name = "Joystick2LRTrackBar"
        Me.Joystick2LRTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick2LRTrackBar.Size = New System.Drawing.Size(101, 56)
        Me.Joystick2LRTrackBar.TabIndex = 11
        Me.Joystick2LRTrackBar.TabStop = False
        '
        'Joystick2UDTrackBar
        '
        Me.Joystick2UDTrackBar.Location = New System.Drawing.Point(555, 302)
        Me.Joystick2UDTrackBar.Maximum = 255
        Me.Joystick2UDTrackBar.Name = "Joystick2UDTrackBar"
        Me.Joystick2UDTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Joystick2UDTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick2UDTrackBar.Size = New System.Drawing.Size(56, 101)
        Me.Joystick2UDTrackBar.TabIndex = 12
        Me.Joystick2UDTrackBar.TabStop = False
        Me.Joystick2UDTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'Joystick3LRTrackBar
        '
        Me.Joystick3LRTrackBar.Location = New System.Drawing.Point(549, 85)
        Me.Joystick3LRTrackBar.Maximum = 255
        Me.Joystick3LRTrackBar.Name = "Joystick3LRTrackBar"
        Me.Joystick3LRTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick3LRTrackBar.Size = New System.Drawing.Size(101, 56)
        Me.Joystick3LRTrackBar.TabIndex = 13
        Me.Joystick3LRTrackBar.TabStop = False
        '
        'Joystick3UDTrackBar
        '
        Me.Joystick3UDTrackBar.Location = New System.Drawing.Point(656, 124)
        Me.Joystick3UDTrackBar.Maximum = 255
        Me.Joystick3UDTrackBar.Name = "Joystick3UDTrackBar"
        Me.Joystick3UDTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.Joystick3UDTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Joystick3UDTrackBar.Size = New System.Drawing.Size(56, 101)
        Me.Joystick3UDTrackBar.TabIndex = 14
        Me.Joystick3UDTrackBar.TabStop = False
        Me.Joystick3UDTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'URCTestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Name = "URCTestForm"
        Me.Text = "Universal Remote Controller Testing"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Joystick1LRTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick1UDTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick2LRTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick2UDTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick3LRTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Joystick3UDTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
