Public Class Form1

    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click
        If (I <= 7) Then
            Nit(I) = TextBoxNIT.Text
            Nombre(I) = TextBoxName.Text
            Personas(I) = TextBoxCnt.Text
            Habitacion(I) = ComboBoxHabi.Text

            If TextBoxCnt.Text = 4 And ComboBoxHabi.Text = "Estandar" Then
                Total(I) = 250
            End If

            If TextBoxCnt.Text = 4 And ComboBoxHabi.Text = "A/C" Then
                Total(I) = 290
            End If

            If TextBoxCnt.Text = 4 And ComboBoxHabi.Text = "Jacuzzi" Then
                Total(I) = 370
            End If

            If TextBoxCnt.Text > 4 And ComboBoxHabi.Text = "Estandar" Then
                Total(I) = 250 + (TextBoxCnt.Text - 4) * (60)
            End If

            If TextBoxCnt.Text > 4 And ComboBoxHabi.Text = "A/C" Then
                Total(I) = 290 + (TextBoxCnt.Text - 4) * (60)
            End If

            If TextBoxCnt.Text > 4 And ComboBoxHabi.Text = "Jacuzzi" Then
                Total(I) = 370 + (TextBoxCnt.Text - 4) * (60)
            End If

            DataGridView1.Rows.Add(Nit(I), Nombre(I), Personas(I), Habitacion(I), Total(I))

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim R = MsgBox("desea salir", vbQuestion + vbYesNo, "mensaje salida")
        If R = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub MatrizToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatrizToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DeEntradaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeEntradaToolStripMenuItem.Click
        TextBoxNIT.Clear()
        TextBoxName.Clear()
        TextBoxCnt.Clear()
        ComboBoxHabi.Text = ""
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 7) And Not (existe)
            If (Nit(I) = TextBoxNIT.Text) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            Nit(I) = TextBoxNIT.Text
            Nombre(I) = TextBoxName.Text
            Personas(I) = TextBoxCnt.Text
            Habitacion(I) = ComboBoxHabi.Text

            If TextBoxCnt.Text = 4 And ComboBoxHabi.Text = "Estandar" Then
                Total(I) = 250
            End If

            If TextBoxCnt.Text = 4 And ComboBoxHabi.Text = "A/C" Then
                Total(I) = 290
            End If

            If TextBoxCnt.Text = 4 And ComboBoxHabi.Text = "Jacuzzi" Then
                Total(I) = 370
            End If

            If TextBoxCnt.Text > 4 And ComboBoxHabi.Text = "Estandar" Then
                Total(I) = 250 + (TextBoxCnt.Text - 4) * (60)
            End If

            If TextBoxCnt.Text > 4 And ComboBoxHabi.Text = "A/C" Then
                Total(I) = 290 + (TextBoxCnt.Text - 4) * (60)
            End If

            If TextBoxCnt.Text > 4 And ComboBoxHabi.Text = "Jacuzzi" Then
                Total(I) = 370 + (TextBoxCnt.Text - 4) * (60)
            End If

            DataGridView1.Rows.Add(Nit(I), Nombre(I), Personas(I), Habitacion(I), Total(I))
        Else
            MsgBox("Registro no encontrado")
            TextBoxNIT.Focus()

            TextBoxNIT.Clear()
            TextBoxName.Clear()
            TextBoxCnt.Clear()
            ComboBoxHabi.Text = ""
        End If

    End Sub

    Private Sub OrdenarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenarToolStripMenuItem.Click
        Dim i As Byte
        Dim j As Byte
        Dim temp1 As Integer


        For j = 0 To 6
            For i = j + 1 To 7

                If (Nit(j) > Nit(i)) Then
                    temp1 = Nit(j)
                    Nit(j) = Nit(i)
                    Nit(i) = temp1
                End If
            Next i
        Next j
    End Sub
End Class
