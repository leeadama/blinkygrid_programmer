Imports Microsoft.VisualBasic.Devices

Public Class frmMain
    'Basic Variables
    Dim IsCreated(99) As Boolean
    Dim Buttons As New Dictionary(Of String, Button)



    'Pixel Frames Variables
    Dim pixelFrames As Integer
    Dim columnData As New List(Of Integer)
    Dim Animation As Boolean = True



    'Messages Variables
    Dim messageData As String
    Dim TransmitData As New List(Of Integer)
    Dim MessageInBits As String
    Dim bitCounter As Integer



    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim lastTop, i As Integer
        'Test only.  Remove from working system
        ''MessageInBits = "000011100000000000000000000001100000000100011110000010110001000100001110000101010001010100011000001010010010000000011000000110110001010100001101110000110000000000000000000000000000000111111111"
        MessageInBits = "0001000000000000000000000000011000000001110001100011000100000000000000000000000000011000000000000000000000000000000000000000000000111100001001000011110000000000001111100001000000000000000100000000011000000000000000000111111001000010010000100100001001111110000000001111111110000001100000011000000110000001100000011111111100000000100101010001000000000000001000000000011001111110010000100100001001000010011111100000000000000000000000000011110000100100001111000000000000000000000000000000000000000000011011000000010000000000001100000000011000011000000000000000000000000000101011100000000000000000000000000000000111111111"
        'MessageInBits = "0000010000000000000000000000011000000001000111100000000100010001110001010000000000000000000000000000000111111111"
        '**************************************
        For i = 0 To 55
            Dim B As New Button
            Dim buttonKey As String
            boxPixelFrame.Controls.Add(B)
            'B.Margin = New Padding(0)
            B.Height = 20
            B.Width = 20
            B.Left = (i Mod 7) * 21 + 10
            B.Top = (i \ 7) * 21 + 10
            lastTop = B.Top
            'B.Text = Chr((i \ 8) + Asc("A")) & i Mod 8 + 1
            buttonKey = Chr((i \ 8) + Asc("A")) & i Mod 8 + 1
            Buttons.Add(buttonKey, B)
            B.Tag = i
            AddHandler B.Click, AddressOf Button_Click
        Next

        'Other setup items here
        'tabMessageType.Height = lastTop + 26 + 16
        cmbPixelDelay.SelectedIndex = 5



    End Sub


    Private Sub Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim B As Button = sender
        IsCreated(B.Tag) = True
        B.BackColor = Color.Red
    End Sub

    Private Sub tmrTransmitData_Tick(sender As Object, e As EventArgs) Handles tmrTransmitData.Tick
        Dim clrBlack, clrWhite As Color
        clrBlack = Color.FromName("Black")
        clrWhite = Color.FromName("White")


        'Prepare a bit for transmission
        Dim length As Integer
        length = Len(MessageInBits)
        bitCounter = bitCounter + 1
        If bitCounter <= Len(MessageInBits) Then
            Dim bitToTransmit As Integer
            bitToTransmit = Val(Mid(MessageInBits, bitCounter, 1))
            If bitToTransmit = 0 Then
                picData.BackColor = clrBlack
            Else
                picData.BackColor = clrWhite
            End If
            picData.Refresh()
            Threading.Thread.Sleep(tmrTransmitData.Interval)

            'Transmit 1 Bit of the Information Here.
            If picClock.BackColor = clrBlack Then
                picClock.BackColor = clrWhite
            Else
                picClock.BackColor = clrBlack
            End If
            picClock.Refresh()
            barProgress.Value = barProgress.Value + 1
            Threading.Thread.Sleep(tmrTransmitData.Interval)

        Else
            'Threading.Thread.Sleep(500)
            picClock.BackColor = clrBlack
            'Threading.Thread.Sleep(tmrTransmitData.Interval)
            picData.BackColor = clrBlack
            tmrTransmitData.Enabled = False

        End If

    End Sub

    Private Sub txtDelay_TextChanged(sender As Object, e As EventArgs) Handles txtDelay.TextChanged

        If Not IsNumeric(txtDelay.Text) Then
            Beep()
            Threading.Thread.Sleep(50)
            txtDelay.Text = "50"
            tmrTransmitData.Interval = Val(txtDelay.Text)
        End If


    End Sub

    Private Sub txtDelay_HideSelectionChanged(sender As Object, e As EventArgs) Handles txtDelay.HideSelectionChanged

    End Sub

    Private Sub txtDelay_LostFocus(sender As Object, e As EventArgs) Handles txtDelay.LostFocus
        If Val(txtDelay.Text) > 0 And Val(txtDelay.Text) < 9999 Then
            tmrTransmitData.Interval = Val(txtDelay.Text)
        Else
            tmrTransmitData.Interval = 70
            txtDelay.Text = "50"
        End If
    End Sub

    Private Sub cmdTransmit_Click(sender As Object, e As EventArgs) Handles cmdTransmit.Click
        'setup stuff
        barProgress.Maximum = Len(MessageInBits) + 1
        barProgress.Value = 1
        bitCounter = 0
        tmrTransmitData.Enabled = True

    End Sub

    Private Sub cmdAddFrame_Click(sender As Object, e As EventArgs) Handles cmdAddFrame.Click
        'Put Frame Image in Frames Box
        Dim bmpPixelFrame As Bitmap
        bmpPixelFrame = TakeScreenShot(boxPixelFrame)
        Dim P As New PictureBox
        P.Height = bmpPixelFrame.Height
        P.Width = bmpPixelFrame.Width
        'P.SizeMode = P.SizeMode.StretchImage
        P.Image = bmpPixelFrame
        panExistingFrames.Controls.Add(P)

        'Save Actual Frame Data for later transmission.

    End Sub

    Private Sub frmMain_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed

    End Sub

    Private Sub txtDelay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDelay.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Beep()
        End If
    End Sub

    Private Function TakeScreenShot(ByVal Control As Control) As Bitmap
        Dim tmpImg As New Bitmap(Control.Width, Control.Height)
        Using g As Graphics = Graphics.FromImage(tmpImg)
            g.CopyFromScreen(Control.PointToScreen(New Point(0, 0)), New Point(0, 0), New Size(Control.Width, Control.Height))
        End Using
        Return tmpImg
    End Function

End Class
