<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.Horzlab = New System.Windows.Forms.Label()
        Me.vertlab = New System.Windows.Forms.Label()
        Me.leftbtn = New System.Windows.Forms.Button()
        Me.rightbtn = New System.Windows.Forms.Button()
        Me.downbtn = New System.Windows.Forms.Button()
        Me.Upbtn = New System.Windows.Forms.Button()
        Me.autobtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'SerialPort1
        '
        Me.SerialPort1.DtrEnable = True
        Me.SerialPort1.RtsEnable = True
        '
        'connect_BTN
        '
        Me.connect_BTN.Location = New System.Drawing.Point(139, 47)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(75, 23)
        Me.connect_BTN.TabIndex = 0
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(12, 49)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.comPort_ComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COM Port"
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Location = New System.Drawing.Point(22, 98)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(13, 13)
        Me.Timer_LBL.TabIndex = 4
        Me.Timer_LBL.Text = "0"
        Me.Timer_LBL.Visible = False
        '
        'Horzlab
        '
        Me.Horzlab.AutoSize = True
        Me.Horzlab.Location = New System.Drawing.Point(22, 198)
        Me.Horzlab.Name = "Horzlab"
        Me.Horzlab.Size = New System.Drawing.Size(54, 13)
        Me.Horzlab.TabIndex = 15
        Me.Horzlab.Text = "Horizontal"
        '
        'vertlab
        '
        Me.vertlab.AutoSize = True
        Me.vertlab.Location = New System.Drawing.Point(22, 171)
        Me.vertlab.Name = "vertlab"
        Me.vertlab.Size = New System.Drawing.Size(42, 13)
        Me.vertlab.TabIndex = 14
        Me.vertlab.Text = "Vertical"
        '
        'leftbtn
        '
        Me.leftbtn.Location = New System.Drawing.Point(36, 275)
        Me.leftbtn.Name = "leftbtn"
        Me.leftbtn.Size = New System.Drawing.Size(75, 23)
        Me.leftbtn.TabIndex = 13
        Me.leftbtn.Text = "Left"
        Me.leftbtn.UseVisualStyleBackColor = True
        '
        'rightbtn
        '
        Me.rightbtn.Location = New System.Drawing.Point(207, 275)
        Me.rightbtn.Name = "rightbtn"
        Me.rightbtn.Size = New System.Drawing.Size(75, 23)
        Me.rightbtn.TabIndex = 12
        Me.rightbtn.Text = "Right"
        Me.rightbtn.UseVisualStyleBackColor = True
        '
        'downbtn
        '
        Me.downbtn.Location = New System.Drawing.Point(115, 323)
        Me.downbtn.Name = "downbtn"
        Me.downbtn.Size = New System.Drawing.Size(75, 23)
        Me.downbtn.TabIndex = 11
        Me.downbtn.Text = "Down"
        Me.downbtn.UseVisualStyleBackColor = True
        '
        'Upbtn
        '
        Me.Upbtn.Location = New System.Drawing.Point(115, 217)
        Me.Upbtn.Name = "Upbtn"
        Me.Upbtn.Size = New System.Drawing.Size(75, 23)
        Me.Upbtn.TabIndex = 10
        Me.Upbtn.Text = "Up"
        Me.Upbtn.UseVisualStyleBackColor = True
        '
        'autobtn
        '
        Me.autobtn.Location = New System.Drawing.Point(319, 143)
        Me.autobtn.Name = "autobtn"
        Me.autobtn.Size = New System.Drawing.Size(75, 23)
        Me.autobtn.TabIndex = 16
        Me.autobtn.Text = "Auto"
        Me.autobtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 497)
        Me.Controls.Add(Me.autobtn)
        Me.Controls.Add(Me.Horzlab)
        Me.Controls.Add(Me.vertlab)
        Me.Controls.Add(Me.leftbtn)
        Me.Controls.Add(Me.rightbtn)
        Me.Controls.Add(Me.downbtn)
        Me.Controls.Add(Me.Upbtn)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Controls.Add(Me.connect_BTN)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents connect_BTN As Button
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents Horzlab As Label
    Friend WithEvents vertlab As Label
    Friend WithEvents leftbtn As Button
    Friend WithEvents rightbtn As Button
    Friend WithEvents downbtn As Button
    Friend WithEvents Upbtn As Button
    Friend WithEvents autobtn As Button
End Class
