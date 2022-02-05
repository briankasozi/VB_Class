Public Class easy
 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Text = "X"
        Button1.Enabled = False
 
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Text = "X"
        Button2.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button2.Enabled = True Then
 
            Button2.Text = "Y"
            Button5.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Text = "X"
        Button3.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Text = "X"
        Button4.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Text = "X"
        Button5.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Text = "X"
        Button6.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Text = "X"
        Button7.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Text = "X"
        Button8.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Text = "X"
        Button9.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub w1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
 
 
 
    End Sub
 
    Private Sub w2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
    End Sub
 
    Private Sub w3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
    End Sub
 
    Private Sub w4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
    End Sub
 
    Private Sub w5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
    End Sub
 
    Private Sub w6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
 
 
 
 
    End Sub
End Class
 
Make sure u change "public class easy "
Change "easy" to Form1 or your form Name
Code to reset bak to default
Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
 
 
        Button1.Text = ""Hello every in this tutorial we are going to see how to create a Tic Tac Toe game in Visual Basic.Net
 
Video :
<iframe width="560" height="315" src="//www.youtube.com/embed/yJDO2sIIdnk?list=UUhu9hyILIdVguU29S1m5sww" frameborder="0" allowfullscreen></iframe>
 
First of all Open visual studio
Now create a project& Name whatever you want
Add 6 buttons from toolbox on your windows form application and  leave their Text to Blank
 
Then add 6 more buttons like this & change the text to Win
 
 
Now double click the form & paste the below Code
 
Public Class easy
 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Text = "X"
        Button1.Enabled = False
 
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Text = "X"
        Button2.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button2.Enabled = True Then
 
            Button2.Text = "Y"
            Button5.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Text = "X"
        Button3.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Text = "X"
        Button4.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Text = "X"
        Button5.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Text = "X"
        Button6.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Text = "X"
        Button7.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Text = "X"
        Button8.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Text = "X"
        Button9.Enabled = False
        If Button3.Enabled = True Then
 
 
            Button3.Text = "Y"
            Button3.Enabled = "false"
 
        ElseIf Button5.Enabled = True Then
 
            Button5.Text = "Y"
            Button5.Enabled = "false"
 
 
        ElseIf Button4.Enabled = True Then
 
            Button4.Text = "Y"
            Button4.Enabled = "false"
 
        ElseIf Button6.Enabled = True Then
 
            Button6.Text = "Y"
            Button6.Enabled = "false"
        ElseIf Button7.Enabled = True Then
 
            Button7.Text = "Y"
            Button7.Enabled = "false"
 
 
        ElseIf Button8.Enabled = True Then
 
            Button8.Text = "Y"
            Button8.Enabled = "false"
 
        ElseIf Button9.Enabled = True Then
 
            Button9.Text = "Y"
            Button9.Enabled = "false"
        End If
 
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
 
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
 
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
 
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
 
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub w1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button1.Text = "X" AndAlso Button2.Text = "X" AndAlso Button3.Text = "X" Then
            w1.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button2.Text = "y" AndAlso Button3.Text = "y" Then
            w1.Visible = True
 
        End If
 
 
 
 
    End Sub
 
    Private Sub w2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button4.Text = "X" AndAlso Button5.Text = "X" AndAlso Button6.Text = "X" Then
            w2.Visible = True
 
        End If
        If Button4.Text = "y" AndAlso Button5.Text = "y" AndAlso Button6.Text = "y" Then
            w2.Visible = True
        End If
    End Sub
 
    Private Sub w3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button7.Text = "X" AndAlso Button8.Text = "X" AndAlso Button9.Text = "X" Then
            w3.Visible = True
 
        End If
        If Button7.Text = "y" AndAlso Button8.Text = "y" AndAlso Button9.Text = "y" Then
            w3.Visible = True
        End If
    End Sub
 
    Private Sub w4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button1.Text = "X" AndAlso Button4.Text = "X" AndAlso Button7.Text = "X" Then
            w4.Visible = True
 
        End If
        If Button1.Text = "y" AndAlso Button4.Text = "y" AndAlso Button7.Text = "y" Then
            w4.Visible = True
        End If
    End Sub
 
    Private Sub w5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button2.Text = "X" AndAlso Button5.Text = "X" AndAlso Button8.Text = "X" Then
            w5.Visible = True
 
        End If
        If Button2.Text = "y" AndAlso Button5.Text = "y" AndAlso Button8.Text = "y" Then
            w5.Visible = True
        End If
    End Sub
 
    Private Sub w6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Button3.Text = "X" AndAlso Button6.Text = "X" AndAlso Button9.Text = "X" Then
            w6.Visible = True
 
        End If
        If Button3.Text = "y" AndAlso Button6.Text = "y" AndAlso Button9.Text = "y" Then
            w6.Visible = True
        End If
    End Sub
 
    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
 
  
    End Sub
End Class
