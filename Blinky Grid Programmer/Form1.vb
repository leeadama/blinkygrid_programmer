Imports Microsoft.VisualBasic.Devices

Public Class Form1
    Dim IsCreated(99) As Boolean
    Dim Buttons As New Dictionary(Of String, Button)
    Dim MessageInBits As String
    Dim i As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim lastTop As Integer
        'Test only.  Remove from working system
        ''MessageInBits = "000011100000000000000000000001100000000100011110000010110001000100001110000101010001010100011000001010010010000000011000000110110001010100001101110000110000000000000000000000000000000111111111"
        MessageInBits = "0001000000000000000000000000011000000001110001100011000100000000000000000000000000011000000000000000000000000000000000000000000000111100001001000011110000000000001111100001000000000000000100000000011000000000000000000111111001000010010000100100001001111110000000001111111110000001100000011000000110000001100000011111111100000000100101010001000000000000001000000000011001111110010000100100001001000010011111100000000000000000000000000011110000100100001111000000000000000000000000000000000000000000011011000000010000000000001100000000011000011000000000000000000000000000101011100000000000000000000000000000000111111111"
        'MessageInBits = "0000010000000000000000000000011000000001000111100000000100010001110001010000000000000000000000000000000111111111"
        '**************************************
        For i As Integer = 0 To 55
            Dim B As New Button
            Dim buttonKey As String
            tabPixel.Controls.Add(B)
            B.Height = 15
            B.Width = 15
            B.Left = (i Mod 7) * 16
            B.Top = (i \ 7) * 16
            lastTop = B.Top
            'B.Text = Chr((i \ 8) + Asc("A")) & i Mod 8 + 1
            buttonKey = Chr((i \ 8) + Asc("A")) & i Mod 8 + 1
            Buttons.Add(buttonKey, B)
            B.Tag = i
            AddHandler B.Click, AddressOf Button_Click
        Next

        'Other setup items here
        tabMessageType.Height = lastTop + 26 + 16
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
        i = i + 1
        If i <= Len(MessageInBits) Then
            Dim bitToTransmit As Integer
            bitToTransmit = Val(Mid(MessageInBits, i, 1))
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
        i = 0
        tmrTransmitData.Enabled = True

    End Sub
End Class
