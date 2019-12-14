Public Class Form1
    <System.Runtime.InteropServices.DllImportAttribute("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short

    End Function
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            CheckBox2.Checked = False
        Else
            CheckBox2.Checked = True
        End If
        Timer1.Start()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = True) Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("By PedroPHSA#7855(Discord)")
        MsgBox("O Flooder pega em qualquer processo...")
        MsgBox("Se você for usar no League Of Legends, se quiser mandar no all coloque '/all' e a mensagem que você quer,pois,ele nao vem automaticamente com o all ")
    End Sub
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (GetAsyncKeyState(Keys.F1)) Then
            SendKeys.Send(TextBox1.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F2)) Then
            SendKeys.Send(TextBox2.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F3)) Then
            SendKeys.Send(TextBox3.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F4)) Then
            SendKeys.Send(TextBox4.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F5)) Then
            SendKeys.Send(TextBox5.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F6)) Then
            SendKeys.Send(TextBox6.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F7)) Then
            SendKeys.Send(TextBox7.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F8)) Then
            SendKeys.Send(TextBox8.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F9)) Then
            SendKeys.Send(TextBox9.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F10)) Then
            SendKeys.Send(TextBox10.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F11)) Then
            SendKeys.Send(TextBox11.Text)
            SendKeys.Send("{Enter}")
        End If
        If (GetAsyncKeyState(Keys.F12)) Then
            SendKeys.Send(TextBox12.Text)
            SendKeys.Send("{Enter}")
        End If
    End Sub
End Class
