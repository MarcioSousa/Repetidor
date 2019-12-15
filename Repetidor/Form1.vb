Public Class Form1
    Dim numero As Integer = 0
    Dim clicado As Integer = 0
    Dim contagem As Integer = 0

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click

        If txtTempo.Visible = True Then
            txtTempo.Text = 1
        Else
            If txtNumero.Text = "" Then
                numero = 1
                txtNumero.Text = numero
            Else

                clicado = 1
                numero = numero & clicado
                txtNumero.Text = numero
                If txtNumero.Text.Length > 8 Then
                    MessageBox.Show("Campo Limpo Automáticamente, Digite menos que 9 Números")
                    txtNumero.Text = ""
                    numero = 0
                End If
            End If
        End If
    End Sub

    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click

        If txtTempo.Visible = True Then
            txtTempo.Text = 2
        Else
            If txtNumero.Text = "" Then
                numero = 2
                txtNumero.Text = numero
            Else

                clicado = 2
                numero = numero & clicado
                txtNumero.Text = numero
                If txtNumero.Text.Length > 8 Then
                    MessageBox.Show("Campo Limpo Automáticamente, Digite menos que 9 Números")
                    txtNumero.Text = ""
                    numero = 0
                End If
            End If
        End If
    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        If txtTempo.Visible = True Then
            txtTempo.Text = 3
        Else

            If txtNumero.Text = "" Then
                numero = 3
                txtNumero.Text = numero
            Else

                clicado = 3
                numero = numero & clicado
                txtNumero.Text = numero
                If txtNumero.Text.Length > 8 Then
                    MessageBox.Show("Campo Limpo Automáticamente, Digite menos que 9 Números")
                    txtNumero.Text = ""
                    numero = 0
                End If
            End If
        End If



    End Sub

    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        If txtTempo.Visible = True Then
            txtTempo.Text = 4
        Else
            If txtNumero.Text = "" Then
                numero = 4
                txtNumero.Text = numero
            Else

                clicado = 4
                numero = numero & clicado
                txtNumero.Text = numero
                If txtNumero.Text.Length > 8 Then
                    MessageBox.Show("Campo Limpo Automáticamente, Digite menos que 9 Números")
                    txtNumero.Text = ""
                    numero = 0
                End If
            End If
        End If

    End Sub

    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        If txtTempo.Visible = True Then
            txtTempo.Text = 5
        Else
            If txtNumero.Text = "" Then
                numero = 5
                txtNumero.Text = numero
            Else

                clicado = 5
                numero = numero & clicado
                txtNumero.Text = numero
                If txtNumero.Text.Length > 8 Then
                    MessageBox.Show("Campo Limpo Automáticamente, Digite menos que 9 Números")
                    txtNumero.Text = ""
                    numero = 0
                End If
            End If
        End If

    End Sub

    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        If txtTempo.Visible = True Then
            txtTempo.Text = 6
        Else

            If txtNumero.Text = "" Then
                numero = 6
                txtNumero.Text = numero
            Else

                clicado = 6
                numero = numero & clicado
                txtNumero.Text = numero
                If txtNumero.Text.Length > 8 Then
                    MessageBox.Show("Campo Limpo Automáticamente, Digite menos que 9 Números")
                    txtNumero.Text = ""
                    numero = 0
                End If
            End If
        End If


    End Sub

    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        If txtTempo.Visible = True Then
            txtTempo.Text = 7
        Else
            If txtNumero.Text = "" Then
                numero = 7
                txtNumero.Text = numero
            Else

                clicado = 7
                numero = numero & clicado
                txtNumero.Text = numero
                If txtNumero.Text.Length > 8 Then
                    MessageBox.Show("Campo Limpo Automáticamente, Digite menos que 9 Números")
                    txtNumero.Text = ""
                    numero = 0
                End If
            End If
        End If

    End Sub

    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        If txtTempo.Visible = True Then
            txtTempo.Text = 8
        Else
            If txtNumero.Text = "" Then
                numero = 8
                txtNumero.Text = numero
            Else

                clicado = 8
                numero = numero & clicado
                txtNumero.Text = numero
                If txtNumero.Text.Length > 8 Then
                    MessageBox.Show("Campo Limpo Automáticamente, Digite menos que 9 Números")
                    txtNumero.Text = ""
                    numero = 0
                End If
            End If
        End If

    End Sub

    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        If txtTempo.Visible = True Then
            txtTempo.Text = 9
        Else
            If txtNumero.Text = "" Then
                numero = 9
                txtNumero.Text = numero
            Else

                clicado = 9
                numero = numero & clicado
                txtNumero.Text = numero
                If txtNumero.Text.Length > 8 Then
                    MessageBox.Show("Campo Limpo Automáticamente, Digite menos que 9 Números")
                    txtNumero.Text = ""
                    numero = 0
                End If
            End If
        End If
    End Sub

    Private Sub btn0_Click(sender As System.Object, e As System.EventArgs) Handles btn0.Click
        If txtTempo.Visible = True Then
            txtTempo.Text = 0
        Else
            If txtNumero.Text = "" Then
                numero = 0
                txtNumero.Text = numero
            Else

                clicado = 0
                numero = numero & clicado
                txtNumero.Text = numero
                If txtNumero.Text.Length > 8 Then
                    MessageBox.Show("Campo Limpo Automáticamente, Digite menos que 9 Números")
                    txtNumero.Text = ""
                    numero = 0
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Not txtNumero.Text = "" Then
            txtTempo.Visible = True
            txtTempo.Focus()
        Else
            MessageBox.Show("Clique ao menos em um número", "Vazio")
        End If
    End Sub

    Private Sub btnIniciar_Click(sender As System.Object, e As System.EventArgs) Handles btnIniciar.Click
        btnParar.Enabled = True
        btnIniciar.Enabled = False

        If Not txtTempo.Text = 0 Then
            Timer1.Interval = txtTempo.Text * 1000
            Timer1.Start()
        Else
            Timer1.Interval = 500
            Timer1.Start()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim mensagem As String = numero
        Dim teclado As String

        lblQtdeNumeros.Text = txtNumero.Text.Length

        txtMensagem.Text = mensagem.Substring(0, contagem)

        If contagem > 0 Then
            teclado = txtMensagem.Text(contagem - 1)
            SendKeys.Send(teclado)
        Else
            teclado = ""
        End If

        contagem = contagem + 1

        If Not txtNumero.Text.Length > contagem - 1 Then
            contagem = 0
        End If

    End Sub

    Private Sub btnParar_Click(sender As System.Object, e As System.EventArgs) Handles btnParar.Click
        Timer1.Stop()
        MessageBox.Show("Mudança somente do tempo, para terminar com o processo, clique em LIMPAR", "Aviso")
        btnParar.Enabled = False
        btnIniciar.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        numero = 0
        clicado = 0
        contagem = 0

        lblQtdeNumeros.Text = ""
        Timer1.Stop()
        txtNumero.Text = ""
        txtTempo.Text = ""
        txtTempo.Visible = False
        txtNumero.Focus()
        txtMensagem.Text = ""
        btnIniciar.Enabled = False
        btnParar.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtNumero.Focus()
    End Sub

    Private Sub txtTempo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTempo.TextChanged
        If Not txtTempo.Text = "" Then
            btnIniciar.Enabled = True
        End If
    End Sub
End Class
