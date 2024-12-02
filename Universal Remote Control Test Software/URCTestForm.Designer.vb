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
        Me.ToolStrip1.SuspendLayout()
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
        Me.Joystick1UDLabel.Location = New System.Drawing.Point(242, 302)
        Me.Joystick1UDLabel.Name = "Joystick1UDLabel"
        Me.Joystick1UDLabel.Size = New System.Drawing.Size(51, 17)
        Me.Joystick1UDLabel.TabIndex = 2
        Me.Joystick1UDLabel.Text = "Label1"
        '
        'Joystick1LRLabel
        '
        Me.Joystick1LRLabel.AutoSize = True
        Me.Joystick1LRLabel.Location = New System.Drawing.Point(177, 247)
        Me.Joystick1LRLabel.Name = "Joystick1LRLabel"
        Me.Joystick1LRLabel.Size = New System.Drawing.Size(51, 17)
        Me.Joystick1LRLabel.TabIndex = 3
        Me.Joystick1LRLabel.Text = "Label1"
        '
        'Joystick2LRLabel
        '
        Me.Joystick2LRLabel.AutoSize = True
        Me.Joystick2LRLabel.Location = New System.Drawing.Point(504, 247)
        Me.Joystick2LRLabel.Name = "Joystick2LRLabel"
        Me.Joystick2LRLabel.Size = New System.Drawing.Size(51, 17)
        Me.Joystick2LRLabel.TabIndex = 5
        Me.Joystick2LRLabel.Text = "Label1"
        '
        'Joystick2UDLabel
        '
        Me.Joystick2UDLabel.AutoSize = True
        Me.Joystick2UDLabel.Location = New System.Drawing.Point(569, 302)
        Me.Joystick2UDLabel.Name = "Joystick2UDLabel"
        Me.Joystick2UDLabel.Size = New System.Drawing.Size(51, 17)
        Me.Joystick2UDLabel.TabIndex = 4
        Me.Joystick2UDLabel.Text = "Label1"
        '
        'Joystick3LRLabel
        '
        Me.Joystick3LRLabel.AutoSize = True
        Me.Joystick3LRLabel.Location = New System.Drawing.Point(636, 99)
        Me.Joystick3LRLabel.Name = "Joystick3LRLabel"
        Me.Joystick3LRLabel.Size = New System.Drawing.Size(51, 17)
        Me.Joystick3LRLabel.TabIndex = 7
        Me.Joystick3LRLabel.Text = "Label1"
        '
        'Joystick3UDLabel
        '
        Me.Joystick3UDLabel.AutoSize = True
        Me.Joystick3UDLabel.Location = New System.Drawing.Point(701, 154)
        Me.Joystick3UDLabel.Name = "Joystick3UDLabel"
        Me.Joystick3UDLabel.Size = New System.Drawing.Size(51, 17)
        Me.Joystick3UDLabel.TabIndex = 6
        Me.Joystick3UDLabel.Text = "Label1"
        '
        'RobotAddressLabel
        '
        Me.RobotAddressLabel.AutoSize = True
        Me.RobotAddressLabel.Location = New System.Drawing.Point(365, 50)
        Me.RobotAddressLabel.Name = "RobotAddressLabel"
        Me.RobotAddressLabel.Size = New System.Drawing.Size(51, 17)
        Me.RobotAddressLabel.TabIndex = 8
        Me.RobotAddressLabel.Text = "Label1"
        '
        'URCTestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RobotAddressLabel)
        Me.Controls.Add(Me.Joystick3LRLabel)
        Me.Controls.Add(Me.Joystick3UDLabel)
        Me.Controls.Add(Me.Joystick2LRLabel)
        Me.Controls.Add(Me.Joystick2UDLabel)
        Me.Controls.Add(Me.Joystick1LRLabel)
        Me.Controls.Add(Me.Joystick1UDLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "URCTestForm"
        Me.Text = "Universal Remote Controller Testing"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
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
End Class
