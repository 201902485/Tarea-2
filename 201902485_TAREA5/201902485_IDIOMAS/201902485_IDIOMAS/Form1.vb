Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            End
        End If
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        If indice < 8 Then
            matriz(0, indice) = TextBoxNombre.Text
            matriz(1, indice) = TextBoxCarnet.Text
            matriz(2, indice) = ComboBoxIdioma.SelectedItem
            matriz(3, indice) = ComboBoxDias.SelectedItem
            matriz(4, indice) = TextBoxHoras.Text
            matriz(5, indice) = ComboBoxPago.SelectedItem
            matriz(6, indice) = DateTimePicker1.Value

            If (ComboBoxIdioma.Text = "Inglés") And (ComboBoxDias.Text = "Sábado") Then
                Subtotal = PIngles * 1 * TextBoxHoras.Text
            End If

            If (ComboBoxIdioma.Text = "Inglés") And (ComboBoxDias.Text = "Viernes") Then
                Subtotal = PIngles * 1 * TextBoxHoras.Text
            End If

            If (ComboBoxIdioma.Text = "Inglés") And (ComboBoxDias.Text = "Viernes y Sábado") Then
                Subtotal = PIngles * 2 * TextBoxHoras.Text
            End If



            If (ComboBoxIdioma.Text = "Portugués") And (ComboBoxDias.Text = "Sábado") Then
                Subtotal = PPortugues * 1 * TextBoxHoras.Text
            End If

            If (ComboBoxIdioma.Text = "Portugués") And (ComboBoxDias.Text = "Viernes") Then
                Subtotal = PPortugues * 1 * TextBoxHoras.Text
            End If

            If (ComboBoxIdioma.Text = "Portugués") And (ComboBoxDias.Text = "Viernes y Sábado") Then
                Subtotal = PPortugues * 2 * TextBoxHoras.Text
            End If



            If (ComboBoxIdioma.Text = "Francés") And (ComboBoxDias.Text = "Sábado") Then
                Subtotal = PFrances * 1 * TextBoxHoras.Text
            End If

            If (ComboBoxIdioma.Text = "Francés") And (ComboBoxDias.Text = "Viernes") Then
                Subtotal = PFrances * 1 * TextBoxHoras.Text
            End If

            If (ComboBoxIdioma.Text = "Francés") And (ComboBoxDias.Text = "Viernes y Sábado") Then
                Subtotal = PFrances * 2 * TextBoxHoras.Text
            End If



            If (ComboBoxPago.Text = "Efectivo") Then
                Descuento1 = Subtotal * Pefectivo

                If (ComboBoxPago.Text = "Cheque") Then
                    Descuento1 = Subtotal * PCheque
                End If


                If (ComboBoxDias.Text = "Viernes y Sábado") Then
                    Descuento2 = Subtotal * VyS
                Else
                    Descuento2 = 0
                End If


                Total = Subtotal - Descuento1 - Descuento2

                matriz(7, indice) = Descuento1
                matriz(8, indice) = Descuento2
                matriz(9, indice) = Subtotal
                matriz(10, indice) = Total



                DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice), matriz(5, indice), matriz(6, indice), matriz(7, indice), matriz(8, indice), matriz(9, indice), matriz(10, indice))
                indice = indice + 1

            End If

        Else
            MessageBox.Show("Ya se llegó al límite de Inscripciones")
        End If


        If TextBoxNombre.Text = ("") Then
            MessageBox.Show("Ingrese un nombre")
        End If

        If TextBoxCarnet.Text = ("") Then
            MessageBox.Show("Ingrese un número de carnet")
        End If

        If ComboBoxIdioma.Text = ("") Then
            MessageBox.Show("Seleccione un idioma")
        End If

        If ComboBoxDias.Text = ("") Then
            MessageBox.Show("Seleccione un día")
        End If

        If ComboBoxPago.Text = ("") Then
            MessageBox.Show("Seleccione un método de pago")
        End If


    End Sub


    Private Sub MatrizToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatrizToolStripMenuItem.Click
        indice = 0
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub DatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosToolStripMenuItem.Click
        TextBoxNombre.Clear()
        TextBoxCarnet.Clear()
        TextBoxHoras.Clear()
        ComboBoxDias.Text = ""
        ComboBoxPago.Text = ""
        ComboBoxIdioma.Text = ""
    End Sub
End Class
