Public Class Form1
    Dim n1, n2, op As String
    Dim Control As Integer = 0
    Private Sub T0_Click(sender As Object, e As EventArgs) Handles T0.Click
        If Control <> 0 Then
            txtDisplay.Text = ""
            Control = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "0"
        If op IsNot Nothing Then
            Label1.Text = Label1.Text & txtDisplay.Text
        End If
    End Sub

    Private Sub T1_Click(sender As Object, e As EventArgs) Handles T1.Click
        If Control <> 0 Then
            txtDisplay.Text = ""
            Control = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "1"
        If op IsNot Nothing Then
            Label1.Text = Label1.Text & txtDisplay.Text
        End If
    End Sub

    Private Sub T2_Click(sender As Object, e As EventArgs) Handles T2.Click
        If Control <> 0 Then
            txtDisplay.Text = ""
            Control = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "2"
        If op IsNot Nothing Then
            Label1.Text = Label1.Text & txtDisplay.Text
        End If
    End Sub

    Private Sub T3_Click(sender As Object, e As EventArgs) Handles T3.Click
        If Control <> 0 Then
            txtDisplay.Text = ""
            Control = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "3"
        If op IsNot Nothing Then
            Label1.Text = Label1.Text & txtDisplay.Text
        End If
    End Sub

    Private Sub T4_Click(sender As Object, e As EventArgs) Handles T4.Click
        If Control <> 0 Then
            txtDisplay.Text = ""
            Control = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "4"
        If op IsNot Nothing Then
            Label1.Text = Label1.Text & txtDisplay.Text
        End If
    End Sub

    Private Sub T5_Click(sender As Object, e As EventArgs) Handles T5.Click
        If Control <> 0 Then
            txtDisplay.Text = ""
            Control = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "5"
        If op IsNot Nothing Then
            Label1.Text = Label1.Text & txtDisplay.Text
        End If
    End Sub

    Private Sub T6_Click(sender As Object, e As EventArgs) Handles T6.Click
        If Control <> 0 Then
            txtDisplay.Text = ""
            Control = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "6"
        If op IsNot Nothing Then
            Label1.Text = Label1.Text & txtDisplay.Text
        End If
    End Sub

    Private Sub T7_Click(sender As Object, e As EventArgs) Handles T7.Click
        If Control <> 0 Then
            txtDisplay.Text = ""
            Control = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "7"
        If op IsNot Nothing Then
            Label1.Text = Label1.Text & txtDisplay.Text
        End If
    End Sub

    Private Sub SUMA_Click(sender As Object, e As EventArgs) Handles SUMA.Click
        op = "+"
        n1 = txtDisplay.Text
        Label1.Text = n1 & " " & op
        txtDisplay.Text = ""
    End Sub

    Private Sub RESTA_Click(sender As Object, e As EventArgs) Handles RESTA.Click
        op = "-"
        n1 = txtDisplay.Text
        Label1.Text = n1 & " " & op
        txtDisplay.Text = ""
    End Sub

    Private Sub DIVISION_Click(sender As Object, e As EventArgs) Handles DIVISION.Click
        op = "/"
        n1 = txtDisplay.Text
        Label1.Text = n1 & " " & op
        txtDisplay.Text = ""
    End Sub

    Private Sub MULTIPLICA_Click(sender As Object, e As EventArgs) Handles MULTIPLICA.Click
        op = "*"
        n1 = txtDisplay.Text
        Label1.Text = n1 & " " & op
        txtDisplay.Text = ""
    End Sub

    Private Sub IGUAL_Click(sender As Object, e As EventArgs) Handles IGUAL.Click
        n2 = txtDisplay.Text
        HazOperacion(n1, n2, op)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
    End Sub

    Private Sub T8_Click(sender As Object, e As EventArgs) Handles T8.Click
        If Control <> 0 Then
            txtDisplay.Text = ""
            Control = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "8"
        If op IsNot Nothing Then
            Label1.Text = Label1.Text & txtDisplay.Text
        End If
    End Sub

    Private Sub T9_Click(sender As Object, e As EventArgs) Handles T9.Click
        If Control <> 0 Then
            txtDisplay.Text = ""
            Control = 0
        End If
        txtDisplay.Text = txtDisplay.Text & "9"
        If op IsNot Nothing Then
            Label1.Text = Label1.Text & txtDisplay.Text
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtDisplay.Text = ""
        Label1.Text = ""
    End Sub

    Sub HazOperacion(n1 As String, n2 As String, op As String)
        Dim ValorResultado As String = ""
        Dim num1 As Decimal = Convert.ToDecimal(n1)
        Dim num2 As Decimal = Convert.ToDecimal(n2)
        Select Case op
            Case "+"
                ValorResultado = num1 + num2
            Case "-"
                ValorResultado = num1 - num2
            Case "*"
                ValorResultado = num1 * num2
            Case "/"
                If num2 = 0 Then
                    ValorResultado = "Error"
                Else
                    ValorResultado = num1 / num2
                End If
        End Select
        Limpiar()
        txtDisplay.Text = ValorResultado
        Control = 1
    End Sub
    Sub Limpiar()
        n1 = Nothing
        n2 = Nothing
        op = Nothing
        Label1.Text = ""
    End Sub
End Class


