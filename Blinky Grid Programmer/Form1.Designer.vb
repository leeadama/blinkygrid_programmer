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
        Me.tabMessageType = New System.Windows.Forms.TabControl()
        Me.tabPixel = New System.Windows.Forms.TabPage()
        Me.boxPixelFrame = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbPixelDelay = New System.Windows.Forms.ComboBox()
        Me.radPixelAnimation = New System.Windows.Forms.RadioButton()
        Me.radPixelMarquee = New System.Windows.Forms.RadioButton()
        Me.cmdClearFrame = New System.Windows.Forms.Button()
        Me.cmdAddFrame = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.panExistingFrames = New System.Windows.Forms.Panel()
        Me.boxExistingFrames = New System.Windows.Forms.GroupBox()
        Me.cmdAddMessage = New System.Windows.Forms.Button()
        Me.grpMessages = New System.Windows.Forms.GroupBox()
        Me.panMessagesToTransmit = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picClock = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picData = New System.Windows.Forms.PictureBox()
        Me.tmrTransmitData = New System.Windows.Forms.Timer(Me.components)
        Me.cmdTransmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDelay = New System.Windows.Forms.TextBox()
        Me.barProgress = New System.Windows.Forms.ProgressBar()
        Me.tabMessageType.SuspendLayout()
        Me.tabPixel.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.boxExistingFrames.SuspendLayout()
        Me.grpMessages.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picClock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabMessageType
        '
        Me.tabMessageType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMessageType.Controls.Add(Me.tabPixel)
        Me.tabMessageType.Controls.Add(Me.TabPage2)
        Me.tabMessageType.Location = New System.Drawing.Point(13, 13)
        Me.tabMessageType.Name = "tabMessageType"
        Me.tabMessageType.SelectedIndex = 0
        Me.tabMessageType.Size = New System.Drawing.Size(320, 214)
        Me.tabMessageType.TabIndex = 1
        '
        'tabPixel
        '
        Me.tabPixel.Controls.Add(Me.boxPixelFrame)
        Me.tabPixel.Controls.Add(Me.Label2)
        Me.tabPixel.Controls.Add(Me.cmbPixelDelay)
        Me.tabPixel.Controls.Add(Me.radPixelAnimation)
        Me.tabPixel.Controls.Add(Me.radPixelMarquee)
        Me.tabPixel.Controls.Add(Me.cmdClearFrame)
        Me.tabPixel.Controls.Add(Me.cmdAddFrame)
        Me.tabPixel.Location = New System.Drawing.Point(4, 25)
        Me.tabPixel.Name = "tabPixel"
        Me.tabPixel.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPixel.Size = New System.Drawing.Size(312, 185)
        Me.tabPixel.TabIndex = 0
        Me.tabPixel.Text = "Pixel Message"
        Me.tabPixel.UseVisualStyleBackColor = True
        '
        'boxPixelFrame
        '
        Me.boxPixelFrame.Location = New System.Drawing.Point(3, 0)
        Me.boxPixelFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.boxPixelFrame.Name = "boxPixelFrame"
        Me.boxPixelFrame.Padding = New System.Windows.Forms.Padding(0)
        Me.boxPixelFrame.Size = New System.Drawing.Size(168, 185)
        Me.boxPixelFrame.TabIndex = 6
        Me.boxPixelFrame.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Delay"
        '
        'cmbPixelDelay
        '
        Me.cmbPixelDelay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPixelDelay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPixelDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPixelDelay.FormattingEnabled = True
        Me.cmbPixelDelay.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cmbPixelDelay.Location = New System.Drawing.Point(247, 155)
        Me.cmbPixelDelay.MaxDropDownItems = 16
        Me.cmbPixelDelay.Name = "cmbPixelDelay"
        Me.cmbPixelDelay.Size = New System.Drawing.Size(59, 24)
        Me.cmbPixelDelay.TabIndex = 4
        '
        'radPixelAnimation
        '
        Me.radPixelAnimation.AutoSize = True
        Me.radPixelAnimation.Checked = True
        Me.radPixelAnimation.Location = New System.Drawing.Point(186, 115)
        Me.radPixelAnimation.Name = "radPixelAnimation"
        Me.radPixelAnimation.Size = New System.Drawing.Size(91, 21)
        Me.radPixelAnimation.TabIndex = 3
        Me.radPixelAnimation.TabStop = True
        Me.radPixelAnimation.Text = "Animation"
        Me.radPixelAnimation.UseVisualStyleBackColor = True
        '
        'radPixelMarquee
        '
        Me.radPixelMarquee.AutoSize = True
        Me.radPixelMarquee.Location = New System.Drawing.Point(186, 88)
        Me.radPixelMarquee.Name = "radPixelMarquee"
        Me.radPixelMarquee.Size = New System.Drawing.Size(85, 21)
        Me.radPixelMarquee.TabIndex = 2
        Me.radPixelMarquee.Text = "Marquee"
        Me.radPixelMarquee.UseVisualStyleBackColor = True
        '
        'cmdClearFrame
        '
        Me.cmdClearFrame.Location = New System.Drawing.Point(186, 42)
        Me.cmdClearFrame.Name = "cmdClearFrame"
        Me.cmdClearFrame.Size = New System.Drawing.Size(102, 23)
        Me.cmdClearFrame.TabIndex = 1
        Me.cmdClearFrame.Text = "Clear Frame"
        Me.cmdClearFrame.UseVisualStyleBackColor = True
        '
        'cmdAddFrame
        '
        Me.cmdAddFrame.Location = New System.Drawing.Point(186, 12)
        Me.cmdAddFrame.Name = "cmdAddFrame"
        Me.cmdAddFrame.Size = New System.Drawing.Size(102, 23)
        Me.cmdAddFrame.TabIndex = 0
        Me.cmdAddFrame.Text = "Add Frame"
        Me.cmdAddFrame.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtMessage)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(312, 185)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Text Message"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(7, 7)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(299, 22)
        Me.txtMessage.TabIndex = 0
        '
        'panExistingFrames
        '
        Me.panExistingFrames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panExistingFrames.AutoScroll = True
        Me.panExistingFrames.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.panExistingFrames.Location = New System.Drawing.Point(6, 21)
        Me.panExistingFrames.Name = "panExistingFrames"
        Me.panExistingFrames.Size = New System.Drawing.Size(546, 186)
        Me.panExistingFrames.TabIndex = 0
        '
        'boxExistingFrames
        '
        Me.boxExistingFrames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.boxExistingFrames.Controls.Add(Me.cmdAddMessage)
        Me.boxExistingFrames.Controls.Add(Me.grpMessages)
        Me.boxExistingFrames.Controls.Add(Me.panExistingFrames)
        Me.boxExistingFrames.Location = New System.Drawing.Point(13, 233)
        Me.boxExistingFrames.Name = "boxExistingFrames"
        Me.boxExistingFrames.Size = New System.Drawing.Size(687, 333)
        Me.boxExistingFrames.TabIndex = 2
        Me.boxExistingFrames.TabStop = False
        Me.boxExistingFrames.Text = "Existing Frames (0)"
        '
        'cmdAddMessage
        '
        Me.cmdAddMessage.Location = New System.Drawing.Point(558, 21)
        Me.cmdAddMessage.Name = "cmdAddMessage"
        Me.cmdAddMessage.Size = New System.Drawing.Size(123, 36)
        Me.cmdAddMessage.TabIndex = 2
        Me.cmdAddMessage.Text = "Add Message"
        Me.cmdAddMessage.UseVisualStyleBackColor = True
        '
        'grpMessages
        '
        Me.grpMessages.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMessages.Controls.Add(Me.panMessagesToTransmit)
        Me.grpMessages.Location = New System.Drawing.Point(0, 214)
        Me.grpMessages.Name = "grpMessages"
        Me.grpMessages.Size = New System.Drawing.Size(681, 113)
        Me.grpMessages.TabIndex = 1
        Me.grpMessages.TabStop = False
        Me.grpMessages.Text = "Messages To Transmit (0)"
        '
        'panMessagesToTransmit
        '
        Me.panMessagesToTransmit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.panMessagesToTransmit.Location = New System.Drawing.Point(7, 22)
        Me.panMessagesToTransmit.Name = "panMessagesToTransmit"
        Me.panMessagesToTransmit.Size = New System.Drawing.Size(661, 85)
        Me.panMessagesToTransmit.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picClock)
        Me.GroupBox1.Location = New System.Drawing.Point(339, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 148)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clock"
        '
        'picClock
        '
        Me.picClock.BackColor = System.Drawing.Color.Black
        Me.picClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picClock.Location = New System.Drawing.Point(6, 22)
        Me.picClock.Name = "picClock"
        Me.picClock.Size = New System.Drawing.Size(170, 118)
        Me.picClock.TabIndex = 0
        Me.picClock.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picData)
        Me.GroupBox2.Location = New System.Drawing.Point(513, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 148)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'picData
        '
        Me.picData.BackColor = System.Drawing.Color.Black
        Me.picData.Location = New System.Drawing.Point(-7, 22)
        Me.picData.Name = "picData"
        Me.picData.Size = New System.Drawing.Size(188, 118)
        Me.picData.TabIndex = 0
        Me.picData.TabStop = False
        '
        'tmrTransmitData
        '
        Me.tmrTransmitData.Interval = 40
        '
        'cmdTransmit
        '
        Me.cmdTransmit.Location = New System.Drawing.Point(513, 21)
        Me.cmdTransmit.Name = "cmdTransmit"
        Me.cmdTransmit.Size = New System.Drawing.Size(181, 23)
        Me.cmdTransmit.TabIndex = 5
        Me.cmdTransmit.Text = "Transmit Data"
        Me.cmdTransmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(345, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Delay(ms)"
        '
        'txtDelay
        '
        Me.txtDelay.Location = New System.Drawing.Point(423, 22)
        Me.txtDelay.MaxLength = 4
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(84, 22)
        Me.txtDelay.TabIndex = 7
        Me.txtDelay.Text = "50"
        Me.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'barProgress
        '
        Me.barProgress.Location = New System.Drawing.Point(339, 204)
        Me.barProgress.Name = "barProgress"
        Me.barProgress.Size = New System.Drawing.Size(361, 23)
        Me.barProgress.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 578)
        Me.Controls.Add(Me.barProgress)
        Me.Controls.Add(Me.txtDelay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdTransmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.boxExistingFrames)
        Me.Controls.Add(Me.tabMessageType)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tabMessageType.ResumeLayout(False)
        Me.tabPixel.ResumeLayout(False)
        Me.tabPixel.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.boxExistingFrames.ResumeLayout(False)
        Me.grpMessages.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picClock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabMessageType As TabControl
    Friend WithEvents tabPixel As TabPage
    Friend WithEvents panExistingFrames As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents boxExistingFrames As GroupBox
    Friend WithEvents cmdClearFrame As Button
    Friend WithEvents cmdAddFrame As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picClock As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents picData As PictureBox
    Friend WithEvents tmrTransmitData As Timer
    Friend WithEvents cmdTransmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDelay As TextBox
    Friend WithEvents barProgress As ProgressBar
    Friend WithEvents cmbPixelDelay As ComboBox
    Friend WithEvents radPixelAnimation As RadioButton
    Friend WithEvents radPixelMarquee As RadioButton
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents grpMessages As GroupBox
    Friend WithEvents panMessagesToTransmit As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents boxPixelFrame As GroupBox
    Friend WithEvents cmdAddMessage As Button
End Class
